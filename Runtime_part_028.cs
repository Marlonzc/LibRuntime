	System.Void .ctor(); // 0x05fa696c
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiTribeLampView win); // 0x05fa7424
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EQuickActionDirection : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EQuickActionDirection Invalid = 0;
	static WizardGames.Soc.SocClient.Ui.EQuickActionDirection Backpack = 1;
	static WizardGames.Soc.SocClient.Ui.EQuickActionDirection Equip = 2;
	static WizardGames.Soc.SocClient.Ui.EQuickActionDirection Weapon = 3;
	static WizardGames.Soc.SocClient.Ui.EQuickActionDirection WeaponPart = 4;
	static WizardGames.Soc.SocClient.Ui.EQuickActionDirection WeaponAmmo = 5;
	static WizardGames.Soc.SocClient.Ui.EQuickActionDirection Tool = 6;
	static WizardGames.Soc.SocClient.Ui.EQuickActionDirection Other = 7;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComQuickActionArea : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComLazyLoader rootLoader; // 0x10
	FairyGUI.Controller ctrlBac; // 0x18
	FairyGUI.Controller ctrlSign; // 0x20
	FairyGUI.GObject objFirstHotArea; // 0x28
	WizardGames.Soc.Common.CustomType.BaseItemNode tarItem; // 0x30
	WizardGames.Soc.Common.CustomType.ItemContainerNode tarContainer; // 0x38
	static WizardGames.Soc.SocClient.Ui.ComQuickActionArea.ActionParam actParam; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ItemDragInfo> doItemDragDrop; // 0x8
	static WizardGames.Soc.SocClient.Ui.EQuickActionDirection ActionDir; // 0x10
	static System.Boolean <EnableQuickAction>k__BackingField; // 0x14
	static System.Boolean get_EnableQuickAction(); // 0x05fa74a8
	static System.Void set_EnableQuickAction(System.Boolean value); // 0x05fa7530
	static System.Boolean get_HahJudegment(); // 0x05fa75c4
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.ComLazyLoader loader); // 0x05fa7714
	System.Void OnInit(FairyGUI.GComponent comRoot); // 0x05fa790c
	System.Void OnDestory(); // 0x05fa7c68
	System.Void SetActive(System.Boolean active, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05fa7cf4
	WizardGames.Soc.SocClient.Ui.EQuickActionDirection GenActDirection(); // 0x05fa7f88
	System.String GenSignPage(); // 0x05fa82ac
	System.Void DoPreJudgment(); // 0x05fa83c4
	System.Void PreJudgmentForBackpack(); // 0x05fa8654
	System.Void PreJudgmentForWeapon(); // 0x05fa88b4
	System.Void PreJudgmentForWeaponPart(); // 0x05fa8ac0
	System.Void PreJudgmentForWeaponAmmo(); // 0x05fa8d40
	System.Void PreJudgmentForEquip(); // 0x05fa8f70
	System.Void PreJudgmentForTool(); // 0x05fa9118
	static System.Void ShowActErrorTips(); // 0x05fa92ac
	static System.Boolean DoAcceptAction(WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05fa9414
	static System.Void FireMsgToAcceptDrag(WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05fa9560
	static System.Void FireMsgToIconHighlight(System.Boolean on); // 0x05fa97e4
	static System.Void SetQuickActionEnable(System.Boolean on); // 0x05fa812c
	System.Void OnFirstHotAreaMoveIn(); // 0x05fa9a8c
	System.Void OnIconMoveIn(); // 0x05fa9b3c
	System.Void OnIconMoveOut(); // 0x05fa9c14
	static System.Boolean IsQuickActTarget(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fa9d08
	static System.Void UpdateQuickActionTarget(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fa9f10
	static System.Void .cctor(); // 0x05faa1c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComQuickActionArea.ActionParam : System.Object
{
	System.Int64 tarItemId; // 0x10
	System.Int64 tarCotnaienrEnum; // 0x18
	System.Int64 tarCotnaienrSysIndex; // 0x20
	System.Int32 tarIndex; // 0x28
	System.Boolean get_IsValid(); // 0x05fa7680
	System.Void Clear(); // 0x05fa80bc
	System.Void .ctor(); // 0x05faa250
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComQuickActionArea.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.ComQuickActionArea.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ItemDragInfo> <>9__17_0; // 0x8
	static System.Void .cctor(); // 0x05faa2c8
	System.Void .ctor(); // 0x05faa32c
	System.Void <OnInit>b__17_0(WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05faa394
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComWeaponItemIcon : WizardGames.Soc.SocClient.Ui.ComItemIcon
{
	FairyGUI.GLoader iconAmmo; // 0x508
	FairyGUI.GList listParts; // 0x510
	FairyGUI.GTextField textName; // 0x518
	FairyGUI.GTextField textNum; // 0x520
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComWeaponItemIcon.PartIconInfo> partInfos; // 0x528
	FairyGUI.Controller ctrlAmmoInfo; // 0x530
	System.Boolean isHasAmmoItem; // 0x538
	System.Int32 curAmmoId; // 0x53c
	System.Int32 curAmmoNum; // 0x540
	System.Int32 curAmmoInventoryNum; // 0x544
	System.Boolean ForceRefreshInventoryAmmoNum; // 0x548
	WizardGames.Soc.SocClient.Ui.IconDoubleClickCfg doubleClickWeaponPartCfg; // 0x550
	System.Void OnInit(); // 0x05faa490
	System.Void InitItemWidgets(); // 0x05faa91c
	System.Void DoPartBlink(WizardGames.Soc.Common.Data.DataItem.ItemSlot parttype); // 0x05faa97c
	System.Void SetAmmoInfo(WizardGames.Soc.Common.CustomType.BaseItemNode instItem, System.Boolean localFirst); // 0x05faaa74
	System.Void SetInstData(WizardGames.Soc.Common.CustomType.BaseItemNode instItem, System.Boolean showIconOnly); // 0x05faae80
	System.Void SetTepmlateData(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg, System.Boolean showIconOnly); // 0x05fab788
	System.String GetItemIconUrl(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg, WizardGames.Soc.Common.Data.DataItem.SkinConfig skinCfg); // 0x05fab8a8
	System.Void SetValue(); // 0x05fab96c
	System.Void SetPartsList(); // 0x05fab024
	System.Void ModifyDoubleClickWeaponPartCfg(); // 0x05fabbf4
	System.Void DoubleClickToUnEquipPart(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fabda4
	System.Void OnDisable(); // 0x05fac02c
	System.Void SetAmmoIcon(); // 0x05faac9c
	System.Void RefreshAmmo(System.Boolean localFirst); // 0x05fac1ac
	System.Void ForceRefInventoryAmmoNum(); // 0x05fac2cc
	System.Void OnItemNodeUpdate(System.Boolean force); // 0x05fac4d4
	System.Void .ctor(); // 0x05fac5c4
	System.Boolean <SetPartsList>b__22_1(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon, WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x05fac638
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComWeaponItemIcon.PartIconInfo : System.Object
{
	FairyGUI.GComponent comRoot; // 0x10
	WizardGames.Soc.SocClient.Ui.ComItemIconLoader iconLoader; // 0x18
	FairyGUI.GObject objDisable; // 0x20
	System.Void .ctor(); // 0x05faa8b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComWeaponItemIcon.<>c__DisplayClass22_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon partIcon; // 0x10
	System.Void .ctor(); // 0x05fabd3c
	System.Boolean <SetPartsList>b__0(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x05fac6c0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EAmmoType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EAmmoType Normal = 1;
	static WizardGames.Soc.SocClient.Ui.EAmmoType High = 2;
	static WizardGames.Soc.SocClient.Ui.EAmmoType Fire = 3;
	static WizardGames.Soc.SocClient.Ui.EAmmoType Explode = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ModelState : System.Object
{
	UnityEngine.Vector3 pos; // 0x10
	UnityEngine.Vector2 Softness; // 0x1c
	System.Single fov; // 0x24
	System.Void .ctor(); // 0x05fac798
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryDefine : System.Object
{
	static System.String BagBeltIconBac; // 0x0
	static System.String WeaponPosBac; // 0x8
	static System.String TentIconBac; // 0x10
	static System.Collections.Generic.Dictionary<System.Int32,System.String> WearPos2Bac; // 0x18
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.DataItem.ItemSlot,System.String> SlotType2BacImg; // 0x20
	static System.Collections.Generic.List<System.String> EngineSlotBacImg; // 0x28
	static System.Collections.Generic.List<System.Int32> EngineSlotNames; // 0x30
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.DataItem.ItemSlot,System.Int32> SlotType2Name; // 0x38
	static WizardGames.Soc.SocClient.Ui.ModelState DefaultModelState; // 0x40
	static UnityEngine.Vector3 LightModelHolderInsidePos; // 0x48
	static WizardGames.Soc.SocClient.Ui.ModelState[] BodyModelState; // 0x58
	static System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EAmmoType,System.String> AmmoType2BacImg; // 0x60
	static System.Void .cctor(); // 0x05fac800
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EInventoryType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EInventoryType None = -1;
	static WizardGames.Soc.SocClient.Ui.EInventoryType Main = 0;
	static WizardGames.Soc.SocClient.Ui.EInventoryType Seed = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryMain : System.Object
{
	FairyGUI.GObject objIconLocateArea; // 0x10
	FairyGUI.GList iconList; // 0x18
	FairyGUI.Controller ctrlTrigger; // 0x20
	FairyGUI.GObject downTrigger; // 0x28
	FairyGUI.GObject scrollTopEffect; // 0x30
	FairyGUI.GObject scrollBottomEffect; // 0x38
	FairyGUI.Transition scrollTopLoopAnim; // 0x40
	FairyGUI.Transition scrollBottomLoopAnim; // 0x48
	System.Boolean isDraging; // 0x50
	FairyGUI.Controller scrollTopCtrl; // 0x58
	FairyGUI.Controller scrollBottomCtrl; // 0x60
	FairyGUI.GList listTabs; // 0x68
	System.String title; // 0x70
	System.Int32 curNum; // 0x78
	System.Int32 maxNum; // 0x7c
	FairyGUI.GLabel titleLabel; // 0x80
	FairyGUI.Controller emptyCtrl; // 0x88
	FairyGUI.Controller batchDropCtrl; // 0x90
	FairyGUI.Controller topBtnsStyleCtrl; // 0x98
	FairyGUI.GLoader topBtnsLoader; // 0xa0
	FairyGUI.GLoader bottomBtnsLoader; // 0xa8
	FairyGUI.GButton btnSelectAll; // 0xb0
	WizardGames.Soc.SocClient.Ui.ComStateBtn btnConfirmDrop; // 0xb8
	FairyGUI.GComponent comExtendBagTitle; // 0xc0
	FairyGUI.GComponent <ComRoot>k__BackingField; // 0xc8
	System.String strGeneralTypeTitle; // 0xd0
	System.Collections.Generic.List<System.Int32> mainPackItemIndexs; // 0xd8
	System.Collections.Generic.List<System.Int32> extendPackItemIndexs; // 0xe0
	System.Boolean dirtyToRefreshMain; // 0xe8
	System.Boolean dirtyToRefreshSeed; // 0xe9
	System.Boolean resortOnRefresh; // 0xea
	System.Single autoScrollFactor; // 0xec
	System.Single autoScrollTimer; // 0xf0
	System.Single autoScrollTime; // 0xf4
	System.Single autoScrollStep; // 0xf8
	System.Int32 lastMainBackpackCapcity; // 0xfc
	System.Int32 lastSeedBackpackNum; // 0x100
	System.Single fIconListKeepScrollPosY; // 0x104
	System.Int32 lastExtendPackItemNum; // 0x108
	WizardGames.Soc.SocClient.Ui.UiInventoryMainItems <ItemListContainer>k__BackingField; // 0x110
	System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> <ShowFilter>k__BackingField; // 0x118
	System.Boolean needFixedTabPage; // 0x120
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiInventoryMain.InventoryTabData> tabTypes; // 0x128
	WizardGames.Soc.SocClient.Ui.EInventoryType curSelectType; // 0x130
	WizardGames.Soc.SocClient.Ui.EInventoryType preSelectType; // 0x134
	FairyGUI.GButton btnPutInAll; // 0x138
	System.Collections.Generic.Dictionary<System.Int64,UnityEngine.Vector2Int> itemPos; // 0x140
	FairyGUI.GComponent get_ComRoot(); // 0x05fad50c
	System.Void set_ComRoot(FairyGUI.GComponent value); // 0x05fad570
	WizardGames.Soc.SocClient.Ui.UiInventoryMainItems get_ItemListContainer(); // 0x05fad5f0
	System.Void set_ItemListContainer(WizardGames.Soc.SocClient.Ui.UiInventoryMainItems value); // 0x05fad654
	System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> get_ShowFilter(); // 0x05fad6d4
	System.Void set_ShowFilter(System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> value); // 0x05fad738
	System.Boolean get_IsInBatchDrop(); // 0x05fad7b8
	System.Void Bind(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiInventoryTools inventoryTools); // 0x05fad878
	System.Void OnEnable(); // 0x05faeda0
	System.Void OnClickMainPanel(FairyGUI.EventContext ctx); // 0x05faf0c8
	System.Void OnDisable(); // 0x05faf14c
	System.Void OnDestory(); // 0x05faf52c
	System.Void InitTabs(); // 0x05faec98
	System.Void InitScrollTriggers(FairyGUI.GComponent comRoot); // 0x05fae794
	System.Void RefreshTopBtnsStyle(); // 0x05faf730
	System.Void SetBatchDropState(System.Boolean on); // 0x05fae064
	System.Void RefreshTags(); // 0x05faf92c
	System.Void FilterNowItems(); // 0x05faf9e0
	System.Void CollectAndSetItemsOfType(WizardGames.Soc.SocClient.Ui.EInventoryType inventoryType, System.Int32& mainItemNum, System.Int32& extendItemNum, System.Int32& mainSlotNum, System.Int32& extendSlotNum); // 0x05fafe04
	System.Void SetNum(System.Int32 curMain, System.Int32 curExtend, System.Int32 maxMain, System.Int32 maxExtend); // 0x05fb0360
	System.Void OnClickTab(WizardGames.Soc.SocClient.Ui.UiInventoryMain.InventoryTabData itemtype, System.Boolean force); // 0x05fb0624
	System.Void SetTitle(); // 0x05fb04ac
	WizardGames.Soc.SocClient.Ui.ComItemIcon BeforeQuickDropAct(System.Int64 itemid); // 0x05fb0cac
	System.Void OnClickQuickDrop(); // 0x05fb0e08
	System.Void OnClickBatchDropCancel(); // 0x05fb0b6c
	System.Void OnClickBatchDropConfirm(); // 0x05fb0f90
	System.Void OnClickBatchDropSelectAll(); // 0x05fb1078
	System.Void SelectTabOfType(WizardGames.Soc.SocClient.Ui.EInventoryType tabType, System.Boolean scrollAnim, System.Boolean keepIfGeneral); // 0x05faef34
	System.Void SelectTabOfTypeNoScrollMove(WizardGames.Soc.SocClient.Ui.EInventoryType tabType, System.Boolean scroll); // 0x05fb11b4
	System.Void OnIconDragStart(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x05fb1308
	System.Void OnIconDragEnd(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem, System.Boolean isDragValid); // 0x05fb16d8
	System.Void OnIconAcceptDrag(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x05fb188c
	System.Void OnIconDoubleClick(WizardGames.Soc.SocClient.Ui.ComItemIcon clickIcon); // 0x05fb1918
	System.Void DoItemBlink(System.Int32 mainType, System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> cond); // 0x05fb1ad4
	System.Void DoItemBlink(System.Int32 mainType, System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> cond, System.Boolean scroll); // 0x05fb1c88
	System.Void RefreshConfirmDropBtnState(); // 0x05faf7e0
	System.Void DoFps30Update(System.Single dt); // 0x05fb1eac
	System.Void MarkMainDirtyToRefresh(); // 0x05fb22d0
	System.Void DoRefreshDirtyMain(); // 0x05fb1f40
	System.Void MarkSeedDirtyToRefresh(); // 0x05fb2634
	System.Void DoRefreshDirtySeed(); // 0x05fb2078
	System.Boolean IsIconBeloneToBackpack(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x05fb15fc
	System.Void OnAnyIconClick(WizardGames.Soc.SocClient.Ui.ComItemIcon clickIcon); // 0x05fb26a0
	System.Void OnIconLocateAreaRollOver(); // 0x05fb294c
	System.Void CheckAutoScroll(System.Single dt); // 0x05fb20f8
	System.Void ResetAutoScroll(); // 0x05fb1828
	System.Void SetIconHighLight(System.Int32 index, System.Boolean on); // 0x05fb2a14
	System.Void DoIconAcceptDrag(System.Int32 index, WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x05fb2aec
	System.Void KeepIconListScrollPosY(); // 0x05fb2bc4
	System.Void OnQuickDropStateChanged(System.Boolean state, System.Boolean dealItemPos); // 0x05faf324
	System.Void OnQuickDropSelectAll(System.Boolean on); // 0x05fb2ccc
	System.Void OnClickItemIcon(System.Boolean isQuickDrop); // 0x05fb2eec
	System.Void OnClickSort(); // 0x05fb2f78
	System.Void DoRefresh(WizardGames.Soc.SocClient.Ui.EInventoryType inventoryType); // 0x05fb233c
	FairyGUI.GComponent BorrowExtendBagTitle(FairyGUI.GComponent parent); // 0x05fb31dc
	System.Void ResetExtendBagTitle(); // 0x05fb332c
	WizardGames.Soc.SocClient.Ui.ComItemIcon GetGuideObjByItemId(System.Int64 itemId); // 0x05fb340c
	System.Void TabRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05fb34d8
	System.Void RefreshMainTabsInfo(); // 0x05fb317c
	System.Void OnQuickDropStateFinished(); // 0x05fb3734
	System.Void On30FpsCheckQuickDropState(); // 0x05fb2270
	System.Void RefreshScrollEffectVisible(); // 0x05fb1468
	System.Void .ctor(); // 0x05fb37dc
	System.Void <InitScrollTriggers>b__67_0(); // 0x05fb3b5c
	System.Void <InitScrollTriggers>b__67_1(); // 0x05fb3c18
	System.Void <InitScrollTriggers>b__67_2(); // 0x05fb3cc4
	System.Void <InitScrollTriggers>b__67_3(); // 0x05fb3d7c
	System.Void <SetBatchDropState>b__69_0(FairyGUI.EventContext ctx); // 0x05fb3e28
	System.Void <SetBatchDropState>b__69_1(FairyGUI.EventContext ctx); // 0x05fb3ea0
	System.Void <SetBatchDropState>b__69_2(FairyGUI.EventContext ctx); // 0x05fb3f18
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryMain.InventoryTabData : System.Object
{
	System.String name; // 0x10
	System.String iconPath; // 0x18
	WizardGames.Soc.SocClient.Ui.EInventoryType type; // 0x20
	System.Void .ctor(System.String name, System.String iconPath, WizardGames.Soc.SocClient.Ui.EInventoryType type); // 0x05fb3ff4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryMain.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiInventoryMain.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> <>9__97_0; // 0x8
	static System.Void .cctor(); // 0x05fb40b4
	System.Void .ctor(); // 0x05fb4118
	System.Boolean <OnAnyIconClick>b__97_0(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x05fb4180
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryMain.<>c__DisplayClass105_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MgrQuickLoot mgrLoot; // 0x10
	WizardGames.Soc.SocClient.Ui.ComItemIcon firstIcon; // 0x18
	System.Void .ctor(); // 0x05fb4240
	System.Boolean <OnQuickDropSelectAll>b__0(WizardGames.Soc.Common.CustomType.BaseItemNode item, WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fb42a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryMain.<>c__DisplayClass112_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiInventoryMain.InventoryTabData typeData; // 0x10
	WizardGames.Soc.SocClient.Ui.UiInventoryMain <>4__this; // 0x18
	System.Void .ctor(); // 0x05fb438c
	System.Void <TabRenderer>b__0(FairyGUI.EventContext ctx); // 0x05fb43f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryMain.<>c__DisplayClass82_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.EInventoryType tabType; // 0x10
	WizardGames.Soc.SocClient.Ui.UiInventoryMain.InventoryTabData typeData; // 0x18
	System.Void .ctor(); // 0x05fb4480
	System.Boolean <SelectTabOfType>b__0(WizardGames.Soc.SocClient.Ui.UiInventoryMain.InventoryTabData data); // 0x05fb44e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryMain.<>c__DisplayClass83_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.EInventoryType tabType; // 0x10
	WizardGames.Soc.SocClient.Ui.UiInventoryMain.InventoryTabData typeData; // 0x18
	System.Void .ctor(); // 0x05fb4590
	System.Boolean <SelectTabOfTypeNoScrollMove>b__0(WizardGames.Soc.SocClient.Ui.UiInventoryMain.InventoryTabData data); // 0x05fb45f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryMainDoubleClick : System.Object
{
	WizardGames.Soc.SocClient.Ui.IconDoubleClickCfg <DoubleClickCfg>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.EQuickActionDirection doubleClickDir; // 0x18
	WizardGames.Soc.SocClient.Ui.IconDoubleClickCfg get_DoubleClickCfg(); // 0x05fb46a0
	System.Void set_DoubleClickCfg(WizardGames.Soc.SocClient.Ui.IconDoubleClickCfg value); // 0x05fb4704
	System.Void DoubleClickToEquipWear(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x05fb4784
	System.Void DoubleClickToEquipWeapon(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x05fb484c
	System.Void DoubleClickToEquipTool(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x05fb4a98
	System.Void .ctor(); // 0x05fb4ce4
	System.Boolean DoubleClickCheck(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fb4ec4
	System.Void DoDoubleClick(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fb5098
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryMainItems : WizardGames.Soc.SocClient.Ui.ClientContainerFixed
{
	System.Single iconSizeWidth; // 0x78
	System.Int32 oldCurRowCount; // 0x7c
	System.Int32 curColumnCount; // 0x80
	WizardGames.Soc.SocClient.Ui.UiInventoryMain inventoryMain; // 0x88
	WizardGames.Soc.SocClient.Ui.UiInventoryTools inventoryTools; // 0x90
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiInventoryMainItems.RowInfo> poolRows; // 0x98
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiInventoryMainItems.RowInfo> curRows; // 0xa0
	System.Boolean useVirtualPos; // 0xa8
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.UiInventoryMainItems.VirtualPosInfo> virtualPosDic; // 0xb0
	WizardGames.Soc.SocClient.Ui.UiInventoryMainDoubleClick doubleClick; // 0xb8
	System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> processCallback; // 0xc0
	System.Action<System.Boolean> OnClickItemAct; // 0xc8
	System.Comparison<System.Int32> containerIndexCompare; // 0xd0
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiInventoryMain inventoryMain); // 0x05fb5204
	System.Void RefreshIconList(); // 0x05fb53a0
	FairyGUI.GObject CustomPoolGetter(System.String url); // 0x05fb5464
	System.Void CustomPoolReturnner(FairyGUI.GObject obj); // 0x05fb5710
	System.Void OnEnable(); // 0x05fb5844
	System.Void OnEnableData(); // 0x05fb58b8
	System.Void OnDisable(); // 0x05fb5b50
	WizardGames.Soc.SocClient.Ui.ComItemIcon GetFirstVisibleIcon(); // 0x05fb5f38
	WizardGames.Soc.SocClient.Ui.UiInventoryMainItems.RowInfo GetRowInfoFromPool(System.Boolean isTitle); // 0x05fb6060
	System.Void SortContainerIndex(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container, System.Collections.Generic.List<System.Int32> indexs); // 0x05fb6388
	System.Void ReturnAllIconAndRows(); // 0x05fb5c44
	System.Void SetItemInfos(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap mainContainer, System.Collections.Generic.List<System.Int32> mainItemIndexs, WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap extendContainer, System.Collections.Generic.List<System.Int32> expandItemIndexs, System.Boolean virtualPos); // 0x05fb6544
	WizardGames.Soc.SocClient.Ui.ComItemIcon ScrollAndGetIcon(System.Int32 itemRow, System.Int32 itemColumn); // 0x05fb6e10
	WizardGames.Soc.SocClient.Ui.ComItemIcon ScrollAndGetIcon(System.Int64 itemId); // 0x05fb6f48
	System.Void SetItemDatas(); // 0x05fb7334
	System.Void RefreshFirstEquipBag(); // 0x05fb73d4
	System.Void DealIconWhenSetData(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fb75e4
	System.Void CheckItemIconListControl(WizardGames.Soc.SocClient.Ui.UiInventoryMainItems.RowInfo rowInfo, FairyGUI.GComponent iconsRoot); // 0x05fb782c
	System.Void ForeachIcon(System.Func<System.Int32,System.Int32,WizardGames.Soc.SocClient.Ui.ComItemIcon,System.Boolean> process, System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> processIcon); // 0x05fb7a1c
	System.Void ForeachIcon(System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> process); // 0x05fb7c20
	System.Void ForeachItem(System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,WizardGames.Soc.SocClient.Ui.ComItemIcon,System.Boolean> process); // 0x05fb7ca0
	System.Void GetItemSlotIndexs(System.Collections.Generic.Dictionary<System.Int64,UnityEngine.Vector2Int>& res); // 0x05fb7f8c
	System.Void GetItemNumAndSlotNum(System.Int32& mainItemNum, System.Int32& extendItemNum, System.Int32& mainSlotNum, System.Int32& extendSlotNum); // 0x05fb81bc
	System.Boolean OnIconAcceptDrag(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05fb84c0
	System.Void LocateToFirstEmptyIcon(); // 0x05fb8ac8
	System.Void DoItemBlink(System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> cond); // 0x05fb8cc4
	System.Int32 FindFirstItemIndex(System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> cond); // 0x05fb8e7c
	System.Void DoItemBlinkNoScrollMove(System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> cond); // 0x05fb906c
	System.Void DoItemHightlight(System.Int32 index, System.Boolean on); // 0x05fb91f0
	System.Void DoItemAcceptDrag(System.Int32 index, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05fb94a4
	System.Void OnClickItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05fb9548
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiInventoryTools inventoryTools); // 0x05fb9774
	System.Void RefhreshDoubleClickCfgTips(); // 0x05fb5af0
	static System.Boolean MonitorDragEndOperation(WizardGames.Soc.SocClient.Ui.ComBaseIcon comItem, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05fb89dc
	System.Void NarrowWinAdaptation(); // 0x05fb5920
	System.Void DealIconWhenCollect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fb9ac8
	WizardGames.Soc.SocClient.Ui.ComItemIcon ScrollAndGetIconOfIndex(System.Int32 index); // 0x05fb9294
	System.Void RowRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05fb9e14
	System.Void <RefreshFirstEquipBag>b__35_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x05fba38c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryMainItems.RowInfo : System.Object
{
	System.Boolean isTitle; // 0x10
	FairyGUI.GComponent iconsRoot; // 0x18
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container; // 0x20
	System.Collections.Generic.List<System.Int32> itemIndexs; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComItemIcon> icons; // 0x30
	WizardGames.Soc.SocClient.Ui.UiInventoryMainItems.RowInfo Reset(System.Boolean isTitle); // 0x05fb6288
	System.Void .ctor(); // 0x05fb617c
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiInventoryMainItems.VirtualPosInfo : System.ValueType
{
	System.Int32 row; // 0x10
	System.Int32 column; // 0x14
	System.Void .ctor(System.Int32 row, System.Int32 column); // 0x05fb6d90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryMainItems.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiInventoryMainItems.<>c <>9; // 0x0
	static System.Func<System.String,FairyGUI.GObject> <>9__22_0; // 0x8
	static System.Action<FairyGUI.GObject> <>9__22_1; // 0x10
	static System.Action<WizardGames.Soc.SocClient.Ui.ComBaseIcon,System.Boolean> <>9__60_0; // 0x18
	static System.Void .cctor(); // 0x05fba5bc
	System.Void .ctor(); // 0x05fba620
	FairyGUI.GObject <CustomPoolGetter>b__22_0(System.String url); // 0x05fba688
	System.Void <CustomPoolGetter>b__22_1(FairyGUI.GObject obj); // 0x05fba784
	System.Void <DealIconWhenCollect>b__60_0(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, System.Boolean state); // 0x05fba8e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryMainItems.<>c__DisplayClass29_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container; // 0x10
	System.Void .ctor(); // 0x05fb64dc
	System.Int32 <SortContainerIndex>b__0(System.Int32 a, System.Int32 b); // 0x05fbaaf0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryMainItems.<>c__DisplayClass44_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon myItemIcon; // 0x10
	WizardGames.Soc.Common.CustomType.BaseItemNode dropItem; // 0x18
	System.Int32 aRow; // 0x20
	System.Int32 aIndex; // 0x24
	WizardGames.Soc.SocClient.Ui.ComItemIcon fromIcon; // 0x28
	System.Int32 bRow; // 0x30
	System.Int32 bIndex; // 0x34
	System.Void .ctor(); // 0x05fb8974
	System.Boolean <OnIconAcceptDrag>b__0(System.Int32 row, System.Int32 index, WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fbac84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryMainItems.<>c__DisplayClass46_0 : System.Object
{
	System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> cond; // 0x10
	System.Void .ctor(); // 0x05fb8e14
	System.Boolean <DoItemBlink>b__0(System.Int32 i, System.Int32 j, WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fbae24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryMainItems.<>c__DisplayClass48_0 : System.Object
{
	System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> cond; // 0x10
	System.Void .ctor(); // 0x05fb9188
	System.Boolean <DoItemBlinkNoScrollMove>b__0(System.Int32 i, System.Int32 j, WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fbaf78
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryMainItems.<>c__DisplayClass60_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	System.Void .ctor(); // 0x05fb9dac
	System.Void <DealIconWhenCollect>b__1(FairyGUI.EventContext ctx); // 0x05fbb0cc
	System.Void <DealIconWhenCollect>b__2(FairyGUI.EventContext ctx); // 0x05fbb3b4
	System.Boolean <DealIconWhenCollect>b__3(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x05fbb43c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryPlayerInfo : System.Object
{
	FairyGUI.GTextField textPlayerName; // 0x10
	FairyGUI.GProgressBar barLife; // 0x18
	FairyGUI.GProgressBar barWater; // 0x20
	FairyGUI.GProgressBar barHungry; // 0x28
	System.Boolean useTweenWhenSetVal; // 0x30
	System.Void Bind(FairyGUI.GComponent comRoot, FairyGUI.GTextField textName); // 0x05fbb514
	System.Void SetBarWithData(FairyGUI.GProgressBar bar, System.Int32 val, System.Int32 max); // 0x05fbb710
	System.Void Refresh(); // 0x05fbb944
	System.Void OnDisable(); // 0x05fbbadc
	System.Void .ctor(); // 0x05fbbb40
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryTools : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ClientContainerFixed> toolContainers; // 0x10
	FairyGUI.Controller ctrlStyle; // 0x18
	FairyGUI.Controller equipStyle; // 0x20
	FairyGUI.GObject disableMask; // 0x28
	WizardGames.Soc.SocClient.Ui.UiInventoryToolsBelt toolsBelt; // 0x30
	WizardGames.Soc.SocClient.Ui.UiInventoryToolsWear toolsWear; // 0x38
	WizardGames.Soc.SocClient.Ui.UiInventoryToolsWeapon toolsWeapon; // 0x40
	FairyGUI.GComponent <ComRoot>k__BackingField; // 0x48
	static System.Boolean RefreshOnEnable; // 0x0
	FairyGUI.GComponent get_ComRoot(); // 0x05fbbba8
	System.Void set_ComRoot(FairyGUI.GComponent value); // 0x05fbbc0c
	System.Void Bind(FairyGUI.GComponent root); // 0x05fbbc8c
	System.Void OnEnable(); // 0x05fbc898
	System.Void OnClickToolsPanel(FairyGUI.EventContext ctx); // 0x05fbccfc
	System.Void OnDisable(); // 0x05fbcd80
	System.Void UpdateItemIconState(); // 0x05fbd3a0
	System.Void RefreshTags(); // 0x05fbd4f0
	System.Void OnSuitStateChanged(System.Boolean state); // 0x05fbd580
	System.Void RefreshAll(); // 0x05fbd638
	System.Void RefreshEquip(); // 0x05fbd7ac
	System.Void RefreshBelt(); // 0x05fbd818
	System.Void UnChooseAllIcons(); // 0x05fbd898
	System.Void IsAttachmentIcon(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem, System.Boolean& isEquip, System.Boolean& isAttachment); // 0x05fbda0c
	System.Void OnIconDragStart(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x05fbdb7c
	System.Void OnIconDragEnd(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem, System.Boolean isDragValid); // 0x05fbdf9c
	System.Void OnAnyIconClick(WizardGames.Soc.SocClient.Ui.ComItemIcon clickIcon); // 0x05fbe210
	System.Void OnReloadSetClip(System.Int32 usingAmmoId); // 0x05fbe810
	System.Void DoFps2Update(System.Single dt); // 0x05fbe89c
	System.Void OnMainPackUpdate(); // 0x05fbe928
	FairyGUI.GObject GetGuideObjById(System.Int64 id); // 0x05fbebb4
	System.Void .ctor(); // 0x05fbecb8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryTools.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiInventoryTools.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__12_0; // 0x8
	static System.Void .cctor(); // 0x05fbed20
	System.Void .ctor(); // 0x05fbed84
	System.Void <Bind>b__12_0(); // 0x05fbedec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryToolsBelt : WizardGames.Soc.SocClient.Ui.ClientContainerFixed
{
	System.Boolean needReqIconsOnEnable; // 0x78
	WizardGames.Soc.SocClient.Ui.UiInventoryToolsWear wearBase; // 0x80
	WizardGames.Soc.SocClient.Ui.IconDoubleClickCfg doubleClickCfg; // 0x88
	System.Void Bind(FairyGUI.GComponent comRoot, WizardGames.Soc.SocClient.Ui.UiInventoryToolsWear wearBase); // 0x05fbeefc
	System.Void UpdateItemIconState(); // 0x05fbf150
	System.Void CheckHighlightOnMoveOut(WizardGames.Soc.SocClient.Ui.ComItemIcon myIcon); // 0x05fbf20c
	System.Void OnEnable(); // 0x05fbf2e8
	System.Void OnDisable(); // 0x05fbf46c
	System.Void DoItemHightlight(System.Int32 index, System.Boolean on); // 0x05fbf5fc
	System.Void DoItemAcceptDrag(System.Int32 index, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05fbf6d8
	System.Boolean OnIconAcceptDrop(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.SocClient.Ui.ItemDragInfo dropData); // 0x05fbf7b4
	System.Boolean OnItemDrop(FairyGUI.EventContext context); // 0x05fbfae8
	System.Void OnIconDragEnd(); // 0x05fbfbec
	System.Void CheckMainPackBlink(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05fbfd14
	System.Void OnAnyIconClick(WizardGames.Soc.SocClient.Ui.ComItemIcon clickIcon); // 0x05fc0090
	System.Void DoubleClickToUnEquip(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc0268
	FairyGUI.GObject GetGuideObjById(System.Int64 id); // 0x05fbec38
	System.Void OnClickItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon clickIcon); // 0x05fc04f0
	System.Void DealIconWhenSetData(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc0674
	System.Void CheckHighlightOnMoveIn(WizardGames.Soc.SocClient.Ui.ComItemIcon myIcon); // 0x05fc070c
	System.Void DealIconWhenCollect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc09d4
	System.Void .ctor(); // 0x05fbc7c8
	System.Void <Bind>b__5_0(FairyGUI.EventContext ctx); // 0x05fc0c5c
	System.Void <UpdateItemIconState>b__6_0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc0e0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryToolsBelt.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiInventoryToolsBelt.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> <>9__14_0; // 0x8
	static System.Void .cctor(); // 0x05fc0e98
	System.Void .ctor(); // 0x05fc0efc
	System.Void <OnIconDragEnd>b__14_0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc0f64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryToolsBelt.<>c__DisplayClass15_0 : System.Object
{
	System.Boolean hasItem; // 0x10
	System.Int32 curBeltIndex; // 0x14
	System.Void .ctor(); // 0x05fc0028
	System.Boolean <CheckMainPackBlink>b__0(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x05fc0fec
	System.Boolean <CheckMainPackBlink>b__1(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x05fc10c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryToolsBelt.<>c__DisplayClass22_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	WizardGames.Soc.SocClient.Ui.UiInventoryToolsBelt <>4__this; // 0x18
	System.Void .ctor(); // 0x05fc0bf4
	System.Void <DealIconWhenCollect>b__0(FairyGUI.EventContext ctx); // 0x05fc1188
	System.Void <DealIconWhenCollect>b__1(FairyGUI.EventContext ctx); // 0x05fc124c
	System.Boolean <DealIconWhenCollect>b__2(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x05fc12d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryToolsWeapon : WizardGames.Soc.SocClient.Ui.ClientContainerFixed
{
	WizardGames.Soc.SocClient.Ui.IconDoubleClickCfg doubleClickCfg; // 0x78
	System.Void Bind(FairyGUI.GComponent comRoot); // 0x05fc13a8
	System.Void UpdateItemIconState(); // 0x05fc1540
	System.Void CollectIcons(); // 0x05fc15fc
	System.Void DealIconWhenSetData(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc1950
	System.Void CheckHighlightOnMoveOut(WizardGames.Soc.SocClient.Ui.ComItemIcon myIcon); // 0x05fc1a34
	System.Void OnIconDragEnd(); // 0x05fc1b10
	System.Void CheckMainPackBlink(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05fc1c38
	System.Boolean OnIconAcceptDrop(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.SocClient.Ui.ItemDragInfo dropData); // 0x05fc1ff8
	System.Void OnAnyIconClick(WizardGames.Soc.SocClient.Ui.ComItemIcon clickIcon); // 0x05fc24e4
	System.Void RefreshAmmoClips(); // 0x05fc2a64
	System.Void ForceRefreshInventoryAmmoNum(); // 0x05fbe99c
	System.Void OnReloadSetClip(System.Int32 usingAmmoId); // 0x05fc2c9c
	System.Void DoFps2Update(System.Single dt); // 0x05fc2d20
	System.Void OnEnable(); // 0x05fc2da4
	System.Void OnDisable(); // 0x05fc2f10
	System.Void DoItemHightlight(System.Int32 index, System.Boolean on); // 0x05fc31cc
	System.Void DoItemAcceptDrag(System.Int32 index, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05fc32a8
	System.Void DoubleClickToUnEquip(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc3384
	System.Void OnClickItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon clickIcon); // 0x05fc360c
	System.Void CheckHighlightOnMoveIn(WizardGames.Soc.SocClient.Ui.ComItemIcon myIcon); // 0x05fc3790
	System.Void DealIconWhenCollect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc3ca4
	System.Void .ctor(); // 0x05fbc830
	System.Void <UpdateItemIconState>b__2_0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc3f2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryToolsWeapon.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiInventoryToolsWeapon.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> <>9__6_0; // 0x8
	static System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> <>9__7_1; // 0x10
	static System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> <>9__9_0; // 0x18
	static System.Void .cctor(); // 0x05fc3fb8
	System.Void .ctor(); // 0x05fc401c
	System.Void <OnIconDragEnd>b__6_0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc4084
	System.Boolean <CheckMainPackBlink>b__7_1(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x05fc410c
	System.Void <OnAnyIconClick>b__9_0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc41c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryToolsWeapon.<>c__DisplayClass21_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	WizardGames.Soc.SocClient.Ui.UiInventoryToolsWeapon <>4__this; // 0x18
	System.Void .ctor(); // 0x05fc3ec4
	System.Boolean <DealIconWhenCollect>b__0(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x05fc4244
	System.Void <DealIconWhenCollect>b__1(FairyGUI.EventContext ctx); // 0x05fc431c
	System.Void <DealIconWhenCollect>b__2(FairyGUI.EventContext ctx); // 0x05fc43e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryToolsWeapon.<>c__DisplayClass7_0 : System.Object
{
	System.Boolean hasItem; // 0x10
	System.Void .ctor(); // 0x05fc1f90
	System.Boolean <CheckMainPackBlink>b__0(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x05fc4464
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryToolsWeapon.<>c__DisplayClass9_0 : System.Object
{
	System.Int64 bulletConfigId; // 0x10
	System.Void .ctor(); // 0x05fc2994
	System.Void <OnAnyIconClick>b__1(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc452c
	System.Boolean <OnAnyIconClick>b__2(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x05fc46a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryToolsWeapon.<>c__DisplayClass9_1 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemSlot parttype; // 0x10
	System.Void .ctor(); // 0x05fc29fc
	System.Void <OnAnyIconClick>b__3(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc4758
	System.Boolean <OnAnyIconClick>b__4(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x05fc4948
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryToolsWear : WizardGames.Soc.SocClient.Ui.ClientContainerFixed
{
	System.String iconSuitsBac; // 0x78
	WizardGames.Soc.SocClient.Ui.ComItemIcon iconUpperBodyArmor; // 0x80
	WizardGames.Soc.SocClient.Ui.ComItemIcon iconExtendPack; // 0x88
	System.Collections.Generic.Dictionary<System.Int32,FairyGUI.GObject> wearUnloadSign; // 0x90
	System.Collections.Generic.HashSet<System.Int32> dragItemOccupyPos; // 0x98
	WizardGames.Soc.SocClient.Ui.UiInventoryToolsWear.ClothItemStateInfo stateInfo; // 0xa0
	System.Boolean needReqIconsOnEnable; // 0xa8
	FairyGUI.GComponent comAttachment; // 0xb0
	WizardGames.Soc.SocClient.Ui.ComItemIconLoader campLoader; // 0xb8
	FairyGUI.GComponent inventoryToolsCom; // 0xc0
	WizardGames.Soc.SocClient.Ui.IconDoubleClickCfg doubleClickCfg; // 0xc8
	System.Void Bind(FairyGUI.GComponent comAttachment, FairyGUI.GComponent comWear); // 0x05fbc400
	System.Void UpdateItemIconState(); // 0x05fbd434
	System.Void ParseAndAddIcon(FairyGUI.GComponent com); // 0x05fc4a00
	System.Void CollectIcons(); // 0x05fc4d54
	System.Void DealIconWhenSetData(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc4fa8
	System.Boolean CanCurDragEquipAccept(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc5218
	System.Void CheckHighlightOnMoveOut(WizardGames.Soc.SocClient.Ui.ComItemIcon myIcon); // 0x05fc5494
	System.Void CheckMainPackBlink(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05fc58b8
	System.Boolean IsEquipOccupyWithPos(WizardGames.Soc.Common.Data.Item.Equipment equip, System.Int32 pos); // 0x05fc5c38
	System.Void RefreshWearUnloadSign(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc5d00
	System.Void OnIconDragStart(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem, System.Boolean isDrag); // 0x05fbdc74
	System.Void OnIconDragStart(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x05fc6160
	System.Void OnIconDragEnd(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem, System.Boolean isDrag); // 0x05fbe05c
	System.Void OnIconDragEnd(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x05fc6364
	System.Void OnHideWearUnloadSign(); // 0x05fc61e0
	System.Void DoubleClickWearToUnEquip(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc63e4
	System.Void OnCampLoaderEnable(); // 0x05fc666c
	System.Void OnEnable(); // 0x05fbcad4
	System.Void OnCampLoaderDisable(); // 0x05fc69fc
	System.Void OnDisable(); // 0x05fbd090
	System.Void DoItemHightlight(System.Int32 index, System.Boolean on); // 0x05fc55c8
	System.Void DoItemAcceptDrag(System.Int32 index, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05fc6afc
	System.Void OnAnyIconClick(WizardGames.Soc.SocClient.Ui.ComItemIcon clickIcon); // 0x05fbe5f4
	System.Void OnExtendPackIconRefresh(System.Int32 curNum, System.Int32 maxNum); // 0x05fc6d54
	System.Void UnChooseAllIcons(); // 0x05fc6e94
	System.Void OnClickItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon clickIcon); // 0x05fc6f40
	System.Void CheckHighlightOnMoveIn(WizardGames.Soc.SocClient.Ui.ComItemIcon myIcon); // 0x05fc70b8
	System.Boolean OnIconAcceptDrag(WizardGames.Soc.SocClient.Ui.ComBaseIcon iconSelf, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05fc7204
	System.Void DealIconWhenCollect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc72e0
	System.Void .ctor(); // 0x05fbc2e8
	System.Void <Bind>b__12_0(FairyGUI.EventContext ctx); // 0x05fc78bc
	System.Void <UpdateItemIconState>b__13_0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc79cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryToolsWear.ClothItemStateInfo : System.Object
{
	System.Boolean hasInfo; // 0x10
	System.Boolean isDrag; // 0x11
	System.Int32 belongPos; // 0x14
	System.Int64 uid; // 0x18
	System.Int64 cfgId; // 0x20
	System.Void Clear(); // 0x05fc6a8c
	System.Void .ctor(); // 0x05fc784c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryToolsWear.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiInventoryToolsWear.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> <>9__24_0; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.ComBaseIcon> <>9__28_0; // 0x10
	static System.Void .cctor(); // 0x05fc7a58
	System.Void .ctor(); // 0x05fc7abc
	System.Void <OnIconDragEnd>b__24_0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc7b24
	System.Void <OnCampLoaderEnable>b__28_0(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05fc7bbc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryToolsWear.<>c__DisplayClass19_0 : System.Object
{
	System.Boolean hasItem; // 0x10
	System.Int32 curEquipPos; // 0x14
	System.Void .ctor(); // 0x05fc5bd0
	System.Boolean <CheckMainPackBlink>b__0(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x05fc7d94
	System.Boolean <CheckMainPackBlink>b__1(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x05fc7ee8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryToolsWear.<>c__DisplayClass22_0 : System.Object
{
	System.Boolean isDrag; // 0x10
	WizardGames.Soc.SocClient.Ui.UiInventoryToolsWear <>4__this; // 0x18
	System.Void .ctor(); // 0x05fc60f8
	System.Void <OnIconDragStart>b__0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc8018
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryToolsWear.<>c__DisplayClass28_0 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemConfig campCfg; // 0x10
	WizardGames.Soc.SocClient.Ui.UiInventoryToolsWear <>4__this; // 0x18
	System.Void .ctor(); // 0x05fc6994
	System.Void <OnCampLoaderEnable>b__1(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05fc80b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryToolsWear.<>c__DisplayClass34_0 : System.Object
{
	System.Int32 belongPos; // 0x10
	System.Void .ctor(); // 0x05fc6cec
	System.Void <OnAnyIconClick>b__0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05fc836c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryToolsWear.<>c__DisplayClass40_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	WizardGames.Soc.SocClient.Ui.UiInventoryToolsWear <>4__this; // 0x18
	System.Void .ctor(); // 0x05fc77e4
	System.Void <DealIconWhenCollect>b__0(FairyGUI.EventContext ctx); // 0x05fc8458
	System.Void <DealIconWhenCollect>b__1(FairyGUI.EventContext ctx); // 0x05fc851c
	System.Boolean <DealIconWhenCollect>b__2(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x05fc85a0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EDirectionType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EDirectionType Invalid = 0;
	static WizardGames.Soc.SocClient.Ui.EDirectionType Backpack = 1;
	static WizardGames.Soc.SocClient.Ui.EDirectionType OtherSide = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiQuickActionArea : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComQuickActionAreaBinder binder; // 0x10
	WizardGames.Soc.Common.CustomType.BaseItemNode tarItem; // 0x18
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap tarContainer; // 0x20
	WizardGames.Soc.SocClient.Ui.UiQuickActionArea.ActionParam actParam; // 0x28
	System.Action<WizardGames.Soc.SocClient.Ui.ItemDragInfo> doItemDragDrop; // 0x30
	WizardGames.Soc.SocClient.Ui.EQuickActionDirection curActionDir; // 0x38
	static System.Boolean <EnableQuickAction>k__BackingField; // 0x0
	FairyGUI.GComponent comRoot; // 0x40
	System.Boolean packageRight; // 0x48
	WizardGames.Soc.SocClient.Ui.EDirectionType type; // 0x4c
	System.Func<WizardGames.Soc.Common.CustomType.ItemContainerNode> getOtherNode; // 0x50
	static System.Boolean get_EnableQuickAction(); // 0x05fc8678
	static System.Void set_EnableQuickAction(System.Boolean value); // 0x05fc86f0
	System.Void OnInit(FairyGUI.GComponent comRoot, System.Boolean packageRight, WizardGames.Soc.SocClient.Ui.EDirectionType type); // 0x05fc8774
	System.Void DoItemDragDrop(WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05fc8a20
	System.Boolean SetActive(System.Boolean active, System.Int32& count, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Int32 index); // 0x05fc8da8
	System.Boolean GetSignIsLeft(System.Int32 signPage); // 0x05fc98c0
	WizardGames.Soc.SocClient.Ui.EQuickActionDirection GenActDirection(); // 0x05fc91f0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.EQuickActionDirection> OtherSideGenActDirection(); // 0x05fc9304
	System.Int32 GenSignPage(); // 0x05fc9744
	System.Void DoPreJudgment(); // 0x05fc9958
	System.Void PreJudgmentForBackpack(); // 0x05fc9ba4
	System.Void PreJudgmentForOther(); // 0x05fca844
	System.Void PreJudgmentForWeapon(); // 0x05fc9e38
	System.Void PreJudgmentForWeaponPart(); // 0x05fca050
	System.Void PreJudgmentForWeaponAmmo(); // 0x05fca300
	System.Void PreJudgmentForEquip(); // 0x05fca550
	System.Void PreJudgmentForTool(); // 0x05fca6cc
	System.Void ShowActErrorTips(); // 0x05fcaaa8
	System.Boolean DoAcceptAction(WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05fc8ae4
	System.Void FireMsgToAcceptDrag(WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05fcabec
	System.Void FireMsgToIconHighlightCur(System.Boolean on); // 0x05fcae0c
	System.Void SetQuickActionEnableCur(System.Boolean on); // 0x05fc8bf4
	System.Void OnIconMoveIn(); // 0x05fcb03c
	System.Void DoOtherSidePreJudgment(); // 0x05fcb150
	System.Void OnIconMoveOut(); // 0x05fcb3b8
	System.Void .ctor(); // 0x05fcb498
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiQuickActionArea.ActionParam : System.Object
{
	System.Int64 tarItemId; // 0x10
	System.Int64 tarCotnaienrEnum; // 0x18
	System.Int64 tarCotnaienrSysIndex; // 0x20
	System.Int32 tarIndex; // 0x28
	System.Void Clear(); // 0x05fc8d38
	System.Void .ctor(); // 0x05fcb534
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventory : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update, WizardGames.Soc.Common.Unity.Ui.IUiFps2Update, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	FairyGUI.GComponent content; // 0x338
	FairyGUI.GComponent comInventoryTools; // 0x340
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x348
	WizardGames.Soc.SocClient.Ui.ComLazyLoader loaderDropArea; // 0x350
	FairyGUI.Controller ctrlInventoryPartCtrl; // 0x358
	FairyGUI.GButton btnClearInventory; // 0x360
	FairyGUI.GLabel textPlayerName; // 0x368
	FairyGUI.GButton btnPlayerViewer; // 0x370
	FairyGUI.GObject objPlayerViewHotArea; // 0x378
	FairyGUI.GTextField playerLevelTxt; // 0x380
	FairyGUI.GObject anchorPosMainNormal; // 0x388
	FairyGUI.GObject anchorposMainNarrow; // 0x390
	FairyGUI.GObject anchorPosToolNormal; // 0x398
	FairyGUI.GObject anchorposToolNarrow; // 0x3a0
	System.Boolean isDealRecovered; // 0x3a8
	System.Boolean KeepStateWhenDisable; // 0x3a9
	WizardGames.Soc.SocClient.Ui.UiInventoryMain <inventoryMain>k__BackingField; // 0x3b0
	WizardGames.Soc.SocClient.Ui.UiInventoryTools <inventoryTools>k__BackingField; // 0x3b8
	WizardGames.Soc.SocClient.Ui.UiInventoryMan man; // 0x3c0
	WizardGames.Soc.SocClient.Ui.ComQuickActionArea quickActionArea; // 0x3c8
	FairyGUI.GTextField levelTextField; // 0x3d0
	FairyGUI.GComponent btnCostume; // 0x3d8
	FairyGUI.GTextField btnCostumeNameText; // 0x3e0
	System.Boolean hideManModeOnDisable; // 0x3e8
	static System.Boolean <IsOpen>k__BackingField; // 0x0
	FairyGUI.GButton btnSeason; // 0x3f0
	FairyGUI.GTextField btnSeasonText; // 0x3f8
	FairyGUI.Controller seasonCtrl; // 0x400
	FairyGUI.GLoader seasonBigIcon; // 0x408
	FairyGUI.GLoader seasonSmallIcon; // 0x410
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.ComItemIcon> quickLootQueue; // 0x418
	FairyGUI.GProgressBar lifeBar; // 0x420
	FairyGUI.GProgressBar waterBar; // 0x428
	FairyGUI.GProgressBar hungryBar; // 0x430
	WizardGames.Soc.SocClient.Ui.UiInventoryMain get_inventoryMain(); // 0x05fcb5ac
	System.Void set_inventoryMain(WizardGames.Soc.SocClient.Ui.UiInventoryMain value); // 0x05fcb610
	WizardGames.Soc.SocClient.Ui.UiInventoryTools get_inventoryTools(); // 0x05fcb690
	System.Void set_inventoryTools(WizardGames.Soc.SocClient.Ui.UiInventoryTools value); // 0x05fcb6f4
	static System.Boolean get_IsOpen(); // 0x05fcb774
	static System.Void set_IsOpen(System.Boolean value); // 0x05fcb7ec
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x05fcb870
	System.Void OnInit(); // 0x05fcb904
	System.Void RegisterEvents(); // 0x05fcc760
	System.Void OnEnable(); // 0x05fcd6c0
	System.Void OnDisable(); // 0x05fce55c
	System.Void OnDestroy(); // 0x05fcf158
	System.Void MakeFullScreen(); // 0x05fcf25c
	System.Void OnShowByLayerStack(); // 0x05fcf340
	System.Void RefreshTags(); // 0x05fcdbf0
	System.Void RefreshMain(); // 0x05fcf550
	System.Void RefreshSeed(); // 0x05fcf6a4
	System.Void RefreshEquip(); // 0x05fcf724
	System.Void RefreshBelt(); // 0x05fcf7a0
	System.Void UnChooseAllIcons(); // 0x05fcec48
	System.Void DealProcessOnInventoryEnable(); // 0x05fcdb8c
	System.Void DealRecoverOnInventoryDisable(); // 0x05fced78
	System.Void UpdateItemIconState(); // 0x05fcf87c
	static System.Void CloseInventory(System.Boolean immediately); // 0x05fcf8f8
	System.Void OpenUiReputationReward(); // 0x05fcfab8
	System.Void InitComReputationBadge(); // 0x05fcd454
	System.Void RefreshSeasonBadge(); // 0x05fce070
	System.Void ReputationLevelHideChange(); // 0x05fcfc60
	System.Void OnClickCostume(); // 0x05fcfde4
	System.Void DoShowInventory(); // 0x05fcfea8
	System.Void RefreshAll(); // 0x05fd00a0
	System.Void OnHideByLayerStack(System.String coverUiName); // 0x05fd0114
	System.Void TryJumpInventoryOnEnable(); // 0x05fcdc9c
	System.Void OnClickBack(System.Boolean immediately); // 0x05fcf9ec
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05fd024c
	System.Void OnItemDoubleClick(WizardGames.Soc.SocClient.Ui.ComItemIcon clickIcon); // 0x05fd0324
	System.Void OnItemDragStart(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x05fd03bc
	System.Void OnItemDragEnd(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem, System.Boolean isDragValid); // 0x05fd0520
	System.Void OnBlinkInventoryItemsByCond(System.Int32 mainType, System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> cond); // 0x05fd0760
	System.Void OnBlinkInventoryItemsByCondNoScroll(System.Int32 mainType, System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> cond, System.Boolean scroll); // 0x05fd0804
	System.Void OnReloadSetClip(System.Int32 usingAmmoId); // 0x05fd08c0
	System.Void OnClickClearInventory(); // 0x05fd0950
	System.Void RefreshReputationLevel(); // 0x05fcdeb8
	System.Void OnQuickDropSelectAll(System.Boolean on); // 0x05fd0a10
	System.Void OnQuickDropStateFinished(); // 0x05fd0aa8
	System.Void SetBarWithData(FairyGUI.GProgressBar bar, System.Int32 val, System.Int32 max); // 0x05fd0b28
	System.Void OnFps30Update(System.Single dt); // 0x05fd0d30
	System.Void OnFps2Update(System.Single dt); // 0x05fd0fa0
	System.Void OnFps1Update(System.Single dt); // 0x05fd103c
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x05fd10b4
	static System.Boolean IsCorpseRewardBoxEntity(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x05fd11b4
	static System.Boolean IsDropItemEntity(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x05fd1428
	static System.Void DragBarNormalAcceptDropRemoteCallMoveItemAround(WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo, System.Boolean isSplit, System.Int32 splitAmout, System.Collections.Generic.List<System.Int64> srcPath); // 0x05fd162c
	FairyGUI.GComponent GetInventoryToolsCom(); // 0x05fd1924
	System.Void OnItemClick(WizardGames.Soc.SocClient.Ui.ComItemIcon clickIcon); // 0x05fd1988
	static WizardGames.Soc.SocClient.Ui.UiInventory OpenAsNormal(); // 0x05fd1a3c
	System.Void OnQuickDropStateChanged(System.Boolean state); // 0x05fd1c10
	System.Void InitBtnCostumeNameElementShowState(); // 0x05fcfb7c
	System.Void RefreshLevelOrExp(); // 0x05fce234
	System.Void InitInventoryMan(); // 0x05fcdd58
	System.Void ModifyQuickActionAreaActivateState(System.Boolean isActivate, WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x05fd048c
	System.Void OnQuickMoveStateChanged(System.Boolean state); // 0x05fd1e10
	System.Void InitInventoryUniqueInfo(); // 0x05fcc700
	System.Void DisposeInventoryUniqueInfo(); // 0x05fcf1fc
	System.Void InventoryUniqueInfoEnabele(); // 0x05fce4fc
	System.Void InventoryUniqueInfoDisable(); // 0x05fcf0f8
	System.Void InitPlayerNameCtrlState(); // 0x05fcfb1c
	System.Void OnFps10Update(System.Single dt); // 0x05fd1e84
	System.Void UnChooseAllComPickIcons(); // 0x05fcf81c
	System.Void OnFps30UpdateToInventoryComPick(System.Single dt); // 0x05fd0f2c
	System.Void InitDragBarMainCtrl(); // 0x05fcd3f4
	System.Void OnShowRetrieveAreaEvent(WizardGames.Soc.SocClient.Ui.ComItemIcon icon, System.Int32 ammount); // 0x05fd1ef8
	System.Void ModifyInventoryDragTipsAreaState(System.Int32 state); // 0x05fd06ec
	System.Void OnInitInventoryPlayerAllBars(); // 0x05fcce08
	System.Void RefreshPlayerStatus(); // 0x05fce370
	System.Void OnHideByLayerStackOtherness(); // 0x05fd01ec
	System.Void .ctor(); // 0x05fd2004
	System.Void <OnInit>b__46_1(FairyGUI.EventContext ctx); // 0x05fd20e4
	System.Void <OnInit>b__46_2(FairyGUI.EventContext ctx); // 0x05fd21cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventory.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiInventory.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__46_0; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.UiInventory> <>9__102_0; // 0x10
	static System.Void .cctor(); // 0x05fd224c
	System.Void .ctor(); // 0x05fd22b0
	System.Void <OnInit>b__46_0(); // 0x05fd2318
	System.Void <OpenAsNormal>b__102_0(WizardGames.Soc.SocClient.Ui.UiInventory win); // 0x05fd23b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.DisplayWeaponIK : System.Object
{
	WizardGames.Soc.SocClient.GoLoader.DisplayModel displayModel; // 0x10
	WizardGames.Soc.Common.Unity.Animation.TwoBoneIKComponentAutoUpdate leftIKComponent; // 0x18
	WizardGames.Soc.Common.Unity.Animation.TwoBoneIKComponentAutoUpdate rightIKComponent; // 0x20
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent objectPointComponent; // 0x28
	WizardGames.Soc.SocClient.GoLoader.DisplayWeapon displayWeapon; // 0x30
	System.Boolean leftik_on; // 0x38
	System.Boolean rightik_on; // 0x39
	System.Boolean reserved; // 0x3a
	System.Void .ctor(WizardGames.Soc.SocClient.GoLoader.DisplayModel displayModel, WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent objectPointComponent, WizardGames.Soc.SocClient.GoLoader.DisplayWeapon displayWeapon, System.Int32 IKType); // 0x05fd243c
	System.Void InitIk(); // 0x05fd2638
	System.Void Dispose(); // 0x05fd2b28
	System.Void SetupIKComponent(System.Boolean bLeft); // 0x05fd2764
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryMan : System.Object
{
	FairyGUI.GObject touchGesture; // 0x10
	FairyGUI.GList listWholeAttrs; // 0x18
	FairyGUI.GButton btnAttrExplosion; // 0x20
	FairyGUI.GButton btnAttrColdExposure; // 0x28
	FairyGUI.GButton btnAttrRadiationExposure; // 0x30
	FairyGUI.GButton btnAttrBite; // 0x38
	UnityEngine.GameObject objPlayerModel; // 0x40
	UnityEngine.Camera camPlayerModel; // 0x48
	WizardGames.Soc.SocClient.GoLoader.DisplayModel displayModel; // 0x50
	System.Single manRotateStartPosX; // 0x58
	UnityEngine.Vector3 manStartEulerAng; // 0x5c
	System.Boolean isModelInited; // 0x68
	System.Boolean isEventAdded; // 0x69
	System.Collections.Generic.List<System.Int64> subscribeIds; // 0x70
	static SocLogger <Logger>k__BackingField; // 0x0
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel comUiPlayerModel; // 0x78
	FairyGUI.GComponent rootCom; // 0x80
	System.Int32 previewBgId; // 0x88
	static SocLogger get_Logger(); // 0x05fd2c18
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiInventory comBoard); // 0x05fccff0
	System.Void ShowPlayerModel(); // 0x05fd2e30
	System.Void MakeFullScreen(); // 0x05fcf2dc
	System.Void OnShowByLayerStack(); // 0x05fcf3c0
	System.Void OnEquipChange(); // 0x05fd34b0
	System.Void OnCurrentWeaponIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase _, System.Int64 __, System.Int64 newValue); // 0x05fd3670
	System.Void InitAttrs(); // 0x05fd2ca0
	System.Boolean OnItemDrop(FairyGUI.EventContext context); // 0x05fd38c8
	System.Single GetWholeAttrPercentValue(WizardGames.Soc.Common.SimpleCustom.DamageType type); // 0x05fd3ae0
	System.Void SetSingleAttr(FairyGUI.GButton node, System.Single value, System.String format); // 0x05fd3c7c
	System.Void RefreshCharacterGo(); // 0x05fd3514
	System.Void UpdateModelPosition(); // 0x05fd3274
	System.Void ShowModelOnEnable(); // 0x05fd3ee8
	System.Void ItemChangeHandler(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue); // 0x05fd4350
	System.Void OnEnable(); // 0x05fd1cac
	System.Void OnDisable(); // 0x05fcede4
	System.Void RefreshWholeAttrs(); // 0x05fd43f0
	System.Void OnManRotateTouchMove(FairyGUI.EventContext ctx); // 0x05fd450c
	System.Void CloseManModel(); // 0x05fd47ac
	System.Void PopPlayerViewer(); // 0x05fd2164
	System.Void OnManRotateTouchEnd(FairyGUI.EventContext ctx); // 0x05fd4824
	System.Void OnClickGestureArea(); // 0x05fd4898
	System.Void OnManRotateTouchBegin(FairyGUI.EventContext ctx); // 0x05fd496c
	UnityEngine.Vector3 GetModelPos(UnityEngine.Camera camera); // 0x05fd3db8
	System.Void InitPlayerModel(); // 0x05fd2ed0
	System.Void .ctor(); // 0x05fccf34
	static System.Void .cctor(); // 0x05fd4af0
	System.Void <Bind>b__20_0(FairyGUI.EventContext ctx); // 0x05fd4bc4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EIconDragDir : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EIconDragDir None = 0;
	static WizardGames.Soc.SocClient.Ui.EIconDragDir Up = 1;
	static WizardGames.Soc.SocClient.Ui.EIconDragDir Down = 2;
	static WizardGames.Soc.SocClient.Ui.EIconDragDir Left = 3;
	static WizardGames.Soc.SocClient.Ui.EIconDragDir Right = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ItemDragInfo : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode item; // 0x10
	WizardGames.Soc.Common.Data.resource.OBJGenaral resItem; // 0x18
	System.Object customData; // 0x20
	WizardGames.Soc.SocClient.Ui.EIconDragDir dir; // 0x28
	System.Void .ctor(); // 0x05fd4c7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemIconDragDrop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComponent comRoot; // 0x338
	WizardGames.Soc.SocClient.Ui.ComAutoIcon dragIcon; // 0x340
	FairyGUI.GComponent dragCom; // 0x348
	FairyGUI.Controller dirCtrl; // 0x350
	WizardGames.Soc.SocClient.Ui.ComBaseIcon dragFom; // 0x358
	System.Single dragFromStartAlpha; // 0x360
	WizardGames.Soc.SocClient.Ui.ItemDragInfo dragData; // 0x368
	System.Boolean needDoDragOnEnable; // 0x370
	System.Action<System.Object> onNoReceiverCall; // 0x378
	System.Action onDragEndCall; // 0x380
	System.Int32 iCurTouchID; // 0x388
	static System.Boolean <IsDragging>k__BackingField; // 0x0
	static WizardGames.Soc.SocClient.Ui.ComBaseIcon <CurDragIcon>k__BackingField; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.ItemDragInfo> OnDragReceive; // 0x10
	static System.Action<System.Single,System.Single> OnDraggingIcon; // 0x18
	static System.Boolean UseFromIconSize; // 0x20
	static System.String DragIconCustomBg; // 0x28
	UnityEngine.Vector2 originalIconScale; // 0x38c
	static System.Boolean get_IsDragging(); // 0x05fd4ce4
	static System.Void set_IsDragging(System.Boolean value); // 0x05fd4d6c
	static WizardGames.Soc.SocClient.Ui.ComBaseIcon get_CurDragIcon(); // 0x05fd4e00
	static System.Void set_CurDragIcon(WizardGames.Soc.SocClient.Ui.ComBaseIcon value); // 0x05fd4e88
	System.Void OnInit(); // 0x05fd4f1c
	System.Void SetDirSign(WizardGames.Soc.SocClient.Ui.EIconDragDir dir); // 0x05fd5304
	System.Void HideDragIcon(); // 0x05fd53cc
	System.Void OnEnable(); // 0x05fd54ac
	System.Void OnDisable(); // 0x05fd5994
	System.Void OnRemoveItemNode(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05fd5b58
	System.Void FireDragEvent(System.Boolean dragStart, System.Boolean isDragValid); // 0x05fd60a8
	System.Void DoStartDrag(WizardGames.Soc.SocClient.Ui.ComBaseIcon from, WizardGames.Soc.SocClient.Ui.ItemDragInfo data, System.Action<System.Object> onNoReceiver, System.Action onDragEnd, System.Int32 touchPointID); // 0x05fd554c
	System.Void DoCancelDrag(System.Boolean hideAfterCancel); // 0x05fd5d04
	System.Void OnDragMove(FairyGUI.EventContext evt); // 0x05fd62e4
	System.Boolean DoNormalDragEnd(); // 0x05fd67cc
	System.Void OnDragEnd(FairyGUI.EventContext evt); // 0x05fd69ec
	static System.Void StartItemDrag(WizardGames.Soc.SocClient.Ui.ComBaseIcon from, WizardGames.Soc.SocClient.Ui.ItemDragInfo data, System.Action<System.Object> onNoReceiver, System.Action onDragEnd, System.Int32 touchPointID); // 0x05fd6e8c
	static System.Void CancelItemDrag(); // 0x05fc0d20
	static System.Void SetDragIconDir(WizardGames.Soc.SocClient.Ui.EIconDragDir dir); // 0x05fd6fcc
	System.Void SetValueOnDragStart(System.String value); // 0x05fd70c0
	System.Void SetValueOnDragEnd(); // 0x05fd719c
	System.Void SetDragIconSize(WizardGames.Soc.SocClient.Ui.ComBaseIcon from); // 0x05fd61fc
	System.Void SetDragIocnCustomBg(WizardGames.Soc.SocClient.Ui.ComBaseIcon curDragIcon); // 0x05fd6270
	System.Void .ctor(); // 0x05fd72e0
	static System.Void .cctor(); // 0x05fd7374
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemSplit : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComSliderBarBtn comSliderBarBtn; // 0x338
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x340
	FairyGUI.Controller stateCtrl; // 0x348
	FairyGUI.GSlider slider; // 0x350
	FairyGUI.GComponent comSlider; // 0x358
	FairyGUI.GButton btnLess; // 0x360
	FairyGUI.GButton btnMore; // 0x368
	FairyGUI.GButton btnMax; // 0x370
	FairyGUI.Controller ctrlSliderHideMax; // 0x378
	WizardGames.Soc.Common.CustomType.StackableItemNode curItem; // 0x380
	FairyGUI.GTextField consumeText; // 0x388
	FairyGUI.GLabel labelName; // 0x390
	FairyGUI.GLabel labelNum; // 0x398
	FairyGUI.GLabel labelChangeInfo; // 0x3a0
	FairyGUI.GTextField tipsTxt; // 0x3a8
	WizardGames.Soc.SocClient.Ui.Binder.GameItemSplit.ComItem_ChangeInfoBinder upkeepChangeInfo; // 0x3b0
	System.Int64 curItemBizId; // 0x3b8
	System.Boolean showSign; // 0x3c0
	System.Boolean isAddSign; // 0x3c1
	System.Boolean showNumTag; // 0x3c2
	System.Collections.Generic.List<System.Int64> safeBoxPath; // 0x3c8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ModalBtnInfo> btnInfos; // 0x3d0
	System.Collections.Generic.List<System.Int64> targetPath; // 0x3d8
	WizardGames.Soc.SocClient.Ui.UiItemSplit.ESplitItemType splitType; // 0x3e0
	System.Int64 entityId; // 0x3e8
	System.Int64 curDigTempId; // 0x3f0
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComItemIconSimpleBinder comItemIconSimpleBinder; // 0x3f8
	System.Boolean isloadMissile; // 0x400
	System.Boolean onAnimFinishRefresh; // 0x401
	WizardGames.Soc.Common.Component.KatyushaComponent katyushaCompClient; // 0x408
	System.Int32 lobbyRid; // 0x410
	WizardGames.Soc.Common.CustomType.ItemContainerNode fuelContainer; // 0x418
	System.Collections.Generic.List<System.Int64> fuelAddResItemIdList; // 0x420
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> fuelOwnedResAmountDic; // 0x428
	System.Boolean IsTakingOutOil; // 0x430
	WizardGames.Soc.Common.CustomType.BaseItemNode curVehicleFuelItem; // 0x438
	static System.Void ShowSplitAddItem(System.Int64 bizId, System.Int32 amount, System.Int32 capcity, System.String title, System.Int64 entityId); // 0x05ff8d58
	System.Void ShowSplitAddItem(System.Int64 bizId, System.Int32 amount, System.Int32 capcity, System.Int64 entityId, System.String title, System.Boolean isPartDrop); // 0x05ff8f5c
	System.Void UiAddItemSetup(); // 0x05ffa070
	System.Void OnInit(); // 0x05ffb04c
	System.Void BindComponents(); // 0x05ffb638
	System.Void OnEnable(); // 0x05ffbcb4
	System.String FormatTitle(System.String agr1, System.String agr2, System.String agr3); // 0x05ff9490
	System.Void OnClickLess(); // 0x05ffbd1c
	System.Void OnClickMore(); // 0x05ffbfc4
	System.Void OnClickMax(); // 0x05ffc26c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05ffc3a8
	System.Void OnClickClose(); // 0x05ffc420
	System.Void OnDisable(); // 0x05ffc4a4
	System.Void OnItemNodeRemoved(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05ffc518
	System.Void SetItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, System.Boolean isPartDrop, System.String title); // 0x05ffc5cc
	System.Void SetIconAndNum(System.Int64 bizId, System.Int32 amount, System.Boolean isPartDrop, System.String title, WizardGames.Soc.Common.Data.DataItem.SkinConfig skinCfg); // 0x05ffc878
	System.Void SetEmptySpliItem(System.Int64 bizId, System.String title); // 0x05ffd300
	System.Void SetSplitNumToPath(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Collections.Generic.List<System.Int64> path, WizardGames.Soc.SocClient.Ui.UiItemSplit.ESplitItemType splitType, System.Boolean isPartDrop, System.String title, System.Single defaultAmountPercent); // 0x05ffd7e8
	System.Void SetSplitPathBtnState(); // 0x05ffddd8
	System.Void DoSplitItemToPath(); // 0x05ffef9c
	System.Void SetSplitBtnState(); // 0x05ff97fc
	System.Void SetPartDropBtnState(); // 0x05ff9580
	System.Boolean CanSplitItemMoveToContainer(WizardGames.Soc.Common.CustomType.StackableItemNode item, WizardGames.Soc.Common.CustomType.ItemContainerNode container); // 0x05fffbe8
	System.Void DoSplitItemTo(System.Boolean toMySide); // 0x05fffda8
	System.Void OnClickPartDrop(); // 0x060005d8
	System.Void SetLabelChangeInfo(); // 0x06000794
	System.Void OnSliderValueChanged(FairyGUI.EventContext context); // 0x05ffa458
	static System.Void ShowItemSplit(WizardGames.Soc.Common.CustomType.BaseItemNode item, System.Boolean isPartDrop, System.String name); // 0x06001db4
	static System.Void ShowIconSplit(System.Int64 bizId, System.Int32 amount, System.String name); // 0x06001fa8
	static System.Void ShowSplitItemToPath(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Collections.Generic.List<System.Int64> path, WizardGames.Soc.SocClient.Ui.UiItemSplit.ESplitItemType splitType, System.String name, System.Single defaultAmountPercent); // 0x0600218c
	static System.Void ShowEmptySplitItem(System.Int64 bizId, System.String name); // 0x060023bc
	static System.Void ShowSplitAddItemForDig(System.Int64 bizId, System.Int64 digTempId, System.Collections.Generic.List<System.Int64> path, System.Int32 maxCount, System.String name, System.Single defaultAmountPercent); // 0x06002594
	System.Void SetSplitPathBtnState_Dig(); // 0x05ffe3e4
	System.Void SetSplitNumToPathForDig(System.Int64 bizId, System.Int64 digTempId, System.Collections.Generic.List<System.Int64> path, WizardGames.Soc.SocClient.Ui.UiItemSplit.ESplitItemType splitType, System.Int32 maxCount, System.Boolean isPartDrop, System.String title, System.Single defaultAmountPercent); // 0x060027c0
	System.Void DoSplitItemToPath_Dig(); // 0x05fff3f8
	System.Void OnSliderValueChanged_Dig(); // 0x06000f30
	System.Void SetSplitPathBtnState_InventoryToCabinet(); // 0x05ffdffc
	System.Void DoSplitItemToPath_InventoryToCabinet(); // 0x05fff060
	System.Boolean UiSubToolcupBoardSetup(); // 0x05ffce3c
	System.Void DoToolcupboardSplitIn(); // 0x060032ec
	System.Void OnSliderValueChanged_InventoryToCabinet(); // 0x06000a2c
	System.Boolean IsGlodCoinItem(); // 0x06003278
	static System.Void ShowSplitItemForKatyusha(System.Boolean isloadMissile, System.Int64 bizId, System.Int32 amount, System.Int32 capcity, System.String title); // 0x0600369c
	System.Void SetSplitNumToPathForKatyusha(System.Boolean isloadMissile, System.Int64 bizId, System.Int32 amount, System.Int32 capcity, System.String title); // 0x060038a4
	System.Void SetSplitPathBtnState_Katyusha(); // 0x05ffe7cc
	System.Void DoSplitItemToPath_Katyusha(); // 0x05fff694
	System.Void OnShowAnimFinish(); // 0x06003dec
	System.Void SetLobbyItemIconAndNumConsume(System.Int32 rid, System.Int32 useAmount, System.Int32 maxAmount, System.String title, System.String consume, System.Action<System.Int32> callback); // 0x060040a0
	System.Void SetLobbyItemIconAndNum(System.Int32 rid, System.Int32 amount, System.Int32 maxAmount, System.String title, System.Action<System.Int32> callback); // 0x0600483c
	System.Void SetLobbyItemIconAndNum(System.Int32 rid, System.Int32 amount, System.Int32 maxAmount, System.String title, WizardGames.Soc.SocClient.Ui.UiItemSplit.ESplitItemType type, System.Action<System.Int32> callback); // 0x0600504c
	static System.Void ShowLobbyItemSplit(System.Int32 rid, System.Int32 amount, System.Int32 maxAmount, System.String title, WizardGames.Soc.SocClient.Ui.UiItemSplit.ESplitItemType type, System.Action<System.Int32> callback); // 0x06005120
	static System.Void ShowLobbyItemSplit(System.Int32 rid, System.Int32 amount, System.Int32 maxAmount, System.String title, System.Action<System.Int32> callback); // 0x06005348
	static System.Void ShowEmptyLobbyItemSplit(System.Int32 rid, System.Int32 amount, System.Int32 maxAmount, System.String title, System.String consume, System.Action<System.Int32> callback); // 0x06005558
	System.Boolean IsInventoryEnterLootState(); // 0x05fffb84
	static System.Void ShowVehicleFuelSplitItem(WizardGames.Soc.Common.CustomType.ItemContainerNode fuelContainer, System.Collections.Generic.List<System.Int64> fuelAddResItemIdList, System.Collections.Generic.Dictionary<System.Int64,System.Int32> fuelOwnedResAmountDic, WizardGames.Soc.Common.CustomType.BaseItemNode vehicleFuelItem, System.Boolean isTakingOutOil); // 0x0600578c
	System.Void SetUpFuelData(WizardGames.Soc.Common.CustomType.ItemContainerNode fuelContainer, System.Collections.Generic.List<System.Int64> fuelAddResItemIdList, System.Collections.Generic.Dictionary<System.Int64,System.Int32> fuelOwnedResAmountDic, WizardGames.Soc.Common.CustomType.BaseItemNode vehicleFuelItem, System.Boolean isTakingOutOil); // 0x060059c0
	System.Void OnSliderValueChanged_VehicleFuel(); // 0x06001628
	System.Void SetupRefuelWinInfo(System.Boolean resetSliderValue); // 0x06005bb4
	System.Void SetupTakingOutOilWinInfo(System.Boolean resetSliderValue); // 0x06005f14
	System.Void SetSplitPathBtnState_VehicleFuel(); // 0x05ffebb4
	System.Void DoSplitItemToPath_VehicleFuel(); // 0x05fff858
	System.Void .ctor(); // 0x06006170
	System.Void <UiAddItemSetup>b__2_0(); // 0x06006334
	System.Void <SetSplitBtnState>b__51_0(); // 0x060067c0
	System.Void <SetSplitBtnState>b__51_1(); // 0x06006828
	System.Void <SetSplitBtnState>b__51_4(); // 0x06006890
	System.Void <SetSplitPathBtnState_Dig>b__63_0(); // 0x060068f8
	System.Void <SetSplitPathBtnState_InventoryToCabinet>b__67_0(); // 0x0600695c
	System.Void <UiSubToolcupBoardSetup>b__69_0(); // 0x06006adc
	System.Void <SetSplitPathBtnState_Katyusha>b__76_0(); // 0x06006b44
	System.Void <SetSplitPathBtnState_VehicleFuel>b__97_0(); // 0x06006ba8
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiItemSplit.ESplitItemType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiItemSplit.ESplitItemType None = 0;
	static WizardGames.Soc.SocClient.Ui.UiItemSplit.ESplitItemType InventoryToCabinet = 1;
	static WizardGames.Soc.SocClient.Ui.UiItemSplit.ESplitItemType AddItemRes = 2;
	static WizardGames.Soc.SocClient.Ui.UiItemSplit.ESplitItemType Dig = 3;
	static WizardGames.Soc.SocClient.Ui.UiItemSplit.ESplitItemType Katyusha = 4;
	static WizardGames.Soc.SocClient.Ui.UiItemSplit.ESplitItemType VehicleFuel = 5;
	static WizardGames.Soc.SocClient.Ui.UiItemSplit.ESplitItemType ExperienceCard = 6;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemSplit.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiItemSplit.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.Share.Framework.EntityBase,System.Boolean> <>9__51_2; // 0x8
	static System.Action<WizardGames.Soc.Share.Framework.EntityBase> <>9__51_3; // 0x10
	static System.Void .cctor(); // 0x06006c0c
	System.Void .ctor(); // 0x06006c70
	System.Void <SetSplitBtnState>b__51_2(WizardGames.Soc.Share.Framework.EntityBase loot, System.Boolean needToast); // 0x06006cd8
	System.Void <SetSplitBtnState>b__51_3(WizardGames.Soc.Share.Framework.EntityBase loot); // 0x06006d54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemSplit.<>c__DisplayClass0_0 : System.Object
{
	System.Int64 bizId; // 0x10
	System.Int32 amount; // 0x18
	System.Int32 capcity; // 0x1c
	System.Int64 entityId; // 0x20
	System.String title; // 0x28
	System.Void .ctor(); // 0x05ff8ef4
	System.Void <ShowSplitAddItem>b__0(WizardGames.Soc.SocClient.Ui.UiItemSplit win); // 0x06006dc8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemSplit.<>c__DisplayClass34_0 : System.Object
{
	FairyGUI.GObject sliderGrip; // 0x10
	System.Void .ctor(); // 0x05ffb5d0
	System.Void <OnInit>b__0(FairyGUI.EventContext ctx); // 0x06006e58
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemSplit.<>c__DisplayClass54_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiItemSplit <>4__this; // 0x10
	System.Boolean isAllFull; // 0x18
	System.Boolean toMySide; // 0x19
	System.Int32 choose; // 0x1c
	System.Void .ctor(); // 0x06000570
	System.Boolean <DoSplitItemTo>b__0(WizardGames.Soc.Common.CustomType.ItemContainerNode container); // 0x06006f48
	System.Boolean <DoSplitItemTo>b__1(WizardGames.Soc.Common.CustomType.ItemContainerNode container); // 0x06006ff0
	System.Void <DoSplitItemTo>b__2(); // 0x06007098
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemSplit.<>c__DisplayClass58_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode item; // 0x10
	System.Boolean isPartDrop; // 0x18
	System.String name; // 0x20
	System.Void .ctor(); // 0x06001f40
	System.Void <ShowItemSplit>b__0(WizardGames.Soc.SocClient.Ui.UiItemSplit win); // 0x06007970
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemSplit.<>c__DisplayClass59_0 : System.Object
{
	System.Int64 bizId; // 0x10
	System.Int32 amount; // 0x18
	System.String name; // 0x20
	System.Void .ctor(); // 0x06002124
	System.Void <ShowIconSplit>b__0(WizardGames.Soc.SocClient.Ui.UiItemSplit win); // 0x060079fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemSplit.<>c__DisplayClass60_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode itemNode; // 0x10
	System.Collections.Generic.List<System.Int64> path; // 0x18
	WizardGames.Soc.SocClient.Ui.UiItemSplit.ESplitItemType splitType; // 0x20
	System.String name; // 0x28
	System.Single defaultAmountPercent; // 0x30
	System.Void .ctor(); // 0x06002354
	System.Void <ShowSplitItemToPath>b__0(WizardGames.Soc.SocClient.Ui.UiItemSplit win); // 0x06007a90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemSplit.<>c__DisplayClass61_0 : System.Object
{
	System.Int64 bizId; // 0x10
	System.String name; // 0x18
	System.Void .ctor(); // 0x0600252c
	System.Void <ShowEmptySplitItem>b__0(WizardGames.Soc.SocClient.Ui.UiItemSplit win); // 0x06007b24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemSplit.<>c__DisplayClass62_0 : System.Object
{
	System.Int64 bizId; // 0x10
	System.Int64 digTempId; // 0x18
	System.Collections.Generic.List<System.Int64> path; // 0x20
	System.Int32 maxCount; // 0x28
	System.String name; // 0x30
	System.Single defaultAmountPercent; // 0x38
	System.Void .ctor(); // 0x06002758
	System.Void <ShowSplitAddItemForDig>b__0(WizardGames.Soc.SocClient.Ui.UiItemSplit win); // 0x06007ba8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemSplit.<>c__DisplayClass74_0 : System.Object
{
	System.Boolean isloadMissile; // 0x10
	System.Int64 bizId; // 0x18
	System.Int32 amount; // 0x20
	System.Int32 capcity; // 0x24
	System.String title; // 0x28
	System.Void .ctor(); // 0x0600383c
	System.Void <ShowSplitItemForKatyusha>b__0(WizardGames.Soc.SocClient.Ui.UiItemSplit win); // 0x06007c54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemSplit.<>c__DisplayClass80_0 : System.Object
{
	System.Action<System.Int32> callback; // 0x10
	System.Int32 useAmount; // 0x18
	System.Void .ctor(); // 0x060047d4
	System.Void <SetLobbyItemIconAndNumConsume>b__0(); // 0x06007ce4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemSplit.<>c__DisplayClass81_0 : System.Object
{
	System.Action<System.Int32> callback; // 0x10
	WizardGames.Soc.SocClient.Ui.UiItemSplit <>4__this; // 0x18
	System.Void .ctor(); // 0x06004fe4
	System.Void <SetLobbyItemIconAndNum>b__0(); // 0x06007d68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemSplit.<>c__DisplayClass83_0 : System.Object
{
	System.Int32 rid; // 0x10
	System.Int32 amount; // 0x14
	System.Int32 maxAmount; // 0x18
	System.String title; // 0x20
	WizardGames.Soc.SocClient.Ui.UiItemSplit.ESplitItemType type; // 0x28
	System.Action<System.Int32> callback; // 0x30
	System.Void .ctor(); // 0x060052e0
	System.Void <ShowLobbyItemSplit>b__0(WizardGames.Soc.SocClient.Ui.UiItemSplit win); // 0x06007e5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemSplit.<>c__DisplayClass84_0 : System.Object
{
	System.Int32 rid; // 0x10
	System.Int32 amount; // 0x14
	System.Int32 maxAmount; // 0x18
	System.String title; // 0x20
	System.Action<System.Int32> callback; // 0x28
	System.Void .ctor(); // 0x060054f0
	System.Void <ShowLobbyItemSplit>b__0(WizardGames.Soc.SocClient.Ui.UiItemSplit win); // 0x06007ef0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemSplit.<>c__DisplayClass85_0 : System.Object
{
	System.Int32 rid; // 0x10
	System.Int32 amount; // 0x14
	System.Int32 maxAmount; // 0x18
	System.String title; // 0x20
	System.String consume; // 0x28
	System.Action<System.Int32> callback; // 0x30
	System.Void .ctor(); // 0x06005724
	System.Void <ShowEmptyLobbyItemSplit>b__0(WizardGames.Soc.SocClient.Ui.UiItemSplit win); // 0x06007f7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemSplit.<>c__DisplayClass92_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.ItemContainerNode fuelContainer; // 0x10
	System.Collections.Generic.List<System.Int64> fuelAddResItemIdList; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> fuelOwnedResAmountDic; // 0x20
	WizardGames.Soc.Common.CustomType.BaseItemNode vehicleFuelItem; // 0x28
	System.Boolean isTakingOutOil; // 0x30
	System.Void .ctor(); // 0x06005958
	System.Void <ShowVehicleFuelSplitItem>b__0(WizardGames.Soc.SocClient.Ui.UiItemSplit win); // 0x0600800c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIItemSplitComponentUtils : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void SetCtrlCtrlSignIcon(WizardGames.Soc.SocClient.Ui.Binder.GameItemSplit.ComItem_ChangeInfoBinder binder, System.Int32 index); // 0x060017cc
	static System.Void SetData(WizardGames.Soc.SocClient.Ui.Binder.GameItemSplit.ComItem_ChangeInfoBinder binder, System.Collections.Generic.List<System.String> itemIcons, System.Collections.Generic.List<System.Int32> itemCounts); // 0x06002e54
	static System.Void Reset(WizardGames.Soc.SocClient.Ui.Binder.GameItemSplit.ComItem_ChangeInfoBinder binder); // 0x05ffdea4
	static System.Void SetVisible(WizardGames.Soc.SocClient.Ui.Binder.GameItemSplit.ComItem_ChangeInfoBinder binder, System.Boolean isVisible); // 0x0600169c
	static System.Void SetFirstChildInfo(WizardGames.Soc.SocClient.Ui.Binder.GameItemSplit.ComItem_ChangeInfoBinder binder, System.String iconUrl, System.String title); // 0x0600340c
	static System.Void SetFirstChildIcon(WizardGames.Soc.SocClient.Ui.Binder.GameItemSplit.ComItem_ChangeInfoBinder binder, System.String iconUrl); // 0x060019e0
	static System.Void SetFirstChildTitle(WizardGames.Soc.SocClient.Ui.Binder.GameItemSplit.ComItem_ChangeInfoBinder binder, System.String title); // 0x06001bf8
	static System.Void .cctor(); // 0x06008098
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBlueprintContainerConsume : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiResearchController uiController; // 0x10
	WizardGames.Soc.SocClient.Ui.UiResearchStateContainer container; // 0x18
	FairyGUI.GRichTextField tipText; // 0x20
	FairyGUI.GList listContainer; // 0x28
	WizardGames.Soc.SocClient.Ui.ComItemIcon itemIconCom; // 0x30
	FairyGUI.GLoader dragLoader; // 0x38
	FairyGUI.GLoader maskLoader; // 0x40
	FairyGUI.Controller stateController; // 0x48
	FairyGUI.Controller existController; // 0x50
	FairyGUI.Transition dragInTrans; // 0x58
	System.Boolean isDroppingInput; // 0x60
	System.String researchCostStr; // 0x68
	WizardGames.Soc.SocClient.Ui.UiResearchData get_UiData(); // 0x0600816c
	System.Boolean get_inputHad(); // 0x06008210
	System.Boolean get_consumeHad(); // 0x0600830c
	System.Void Init(WizardGames.Soc.SocClient.Ui.UiResearchController uiController, FairyGUI.GComponent root, UnityEngine.Vector2 tipsPos); // 0x06008408
	System.Void OnEnable(); // 0x060092a0
	System.Void InitData(); // 0x0600950c
	System.Void InitUi(); // 0x06009748
	System.Void OnInputItemChangeAction(); // 0x06009cd0
	System.Void OnConsumeItemNumChangeAction(System.Boolean add); // 0x06009de8
	WizardGames.Soc.Common.CustomType.BaseItemNode GetConsumeItem(); // 0x06009e80
	System.Void Refresh(); // 0x060091c0
	System.Void UnChooseAllIcons(); // 0x06009fa4
	System.Void ResearchStateChange(WizardGames.Soc.SocClient.Ui.UiResearchState curState, WizardGames.Soc.SocClient.Ui.UiResearchState lastState); // 0x0600a010
	System.Void OnIconDragStart(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x0600a0d4
	System.Void OnIconDragEnd(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x0600a1d4
	System.Void OnUpdate(); // 0x060098a0
	System.Void SetTipText(); // 0x06009904
	System.Void .ctor(); // 0x0600a270
	System.Void <Init>b__18_4(FairyGUI.EventContext ctx); // 0x0600a31c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBlueprintContainerConsume.<>c__DisplayClass18_0 : System.Object
{
	FairyGUI.GComponent itemIconComponent; // 0x10
	System.Void .ctor(); // 0x06009158
	System.Void <Init>b__0(FairyGUI.EventContext ctx); // 0x0600a3e4
	System.Void <Init>b__1(FairyGUI.EventContext ctx); // 0x0600a4d4
	System.Void <Init>b__2(FairyGUI.EventContext ctx); // 0x0600a5c4
	System.Void <Init>b__3(FairyGUI.EventContext ctx); // 0x0600a6b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBlueprintContainerInput : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.UiResearchController uiController; // 0x10
	WizardGames.Soc.SocClient.Ui.UiResearchStateContainer container; // 0x18
	FairyGUI.GTextField itemNameText; // 0x20
	FairyGUI.GImage alreadyResearchedTipImg; // 0x28
	FairyGUI.GTextField alreadyResearchedTipText; // 0x30
	FairyGUI.GList listContainer; // 0x38
	WizardGames.Soc.SocClient.Ui.ComItemIcon itemIconCom; // 0x40
	FairyGUI.GLoader dragLoader; // 0x48
	FairyGUI.GLoader maskLoader; // 0x50
	FairyGUI.Controller stateController; // 0x58
	FairyGUI.Controller existController; // 0x60
	FairyGUI.Transition dragInTrans; // 0x68
	WizardGames.Soc.SocClient.Ui.UiResearchData get_UiData(); // 0x0600a7a4
	System.Void Init(WizardGames.Soc.SocClient.Ui.UiResearchController uiController, FairyGUI.GComponent root, UnityEngine.Vector2 tipsPos); // 0x0600a848
	System.Void OnEnable(); // 0x0600b2b4
	System.Void InitData(); // 0x0600b470
	System.Void InitUi(); // 0x0600b584
	System.Boolean GetUnLockState(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x0600b8ac
	System.Void OnInputItemChangeAction(); // 0x0600b9ec
	WizardGames.Soc.Common.CustomType.BaseItemNode GetInputItem(); // 0x0600b78c
	System.Void Refresh(); // 0x0600b248
	System.Void UnChooseAllIcons(); // 0x0600bbdc
	System.Void ResearchStateChange(WizardGames.Soc.SocClient.Ui.UiResearchState curState, WizardGames.Soc.SocClient.Ui.UiResearchState lastState); // 0x0600bc48
	System.Void OnIconDragStart(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x0600bd0c
	System.Void OnIconDragEnd(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x0600be30
	UnityEngine.Color HexToColor(System.String hex); // 0x0600b090
	System.Void .ctor(); // 0x0600becc
	static System.Void .cctor(); // 0x0600bf34
	System.Void <Init>b__17_4(FairyGUI.EventContext ctx); // 0x0600c008
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBlueprintContainerInput.<>c__DisplayClass17_0 : System.Object
{
	FairyGUI.GComponent itemIconComponent; // 0x10
	System.Void .ctor(); // 0x0600b1e0
	System.Void <Init>b__0(FairyGUI.EventContext ctx); // 0x0600c0d0
	System.Void <Init>b__1(FairyGUI.EventContext ctx); // 0x0600c1c0
	System.Void <Init>b__2(FairyGUI.EventContext ctx); // 0x0600c2b0
	System.Void <Init>b__3(FairyGUI.EventContext ctx); // 0x0600c3a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBlueprintContainerOutput : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiResearchController uiController; // 0x10
	WizardGames.Soc.SocClient.Ui.UiResearchStateContainer container; // 0x18
	FairyGUI.GList listContainer; // 0x20
	FairyGUI.GLoader itemGrayIconLoader; // 0x28
	FairyGUI.GLoader barProgressImg; // 0x30
	FairyGUI.GLoader itemIconLoader; // 0x38
	FairyGUI.GComponent timeCom; // 0x40
	FairyGUI.GTextField timeText; // 0x48
	FairyGUI.GTextField valueText; // 0x50
	FairyGUI.Transition inputItemChangeTrans; // 0x58
	FairyGUI.Transition researchSuccessTrans; // 0x60
	FairyGUI.Transition timeGearTransition; // 0x68
	System.Int64 researchingUpdateTimerId; // 0x70
	WizardGames.Soc.SocClient.Ui.UiResearchData get_UiData(); // 0x0600c490
	System.Void Init(WizardGames.Soc.SocClient.Ui.UiResearchController uiController, FairyGUI.GComponent root, UnityEngine.Vector2 tipsPos); // 0x0600c534
	System.Void OnEnable(); // 0x0600cb8c
	System.Void OnDisable(); // 0x0600cd48
	System.Void ContainerIconProcess(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x0600ce4c
	System.Void InitData(); // 0x0600cecc
	System.Void InitUi(); // 0x055049cc
	System.Void ResearchStateChange(WizardGames.Soc.SocClient.Ui.UiResearchState curState, WizardGames.Soc.SocClient.Ui.UiResearchState lastState); // 0x055057d4
	System.Void ResearchingUpdateTimer(System.Int64 timerId, System.Object callbackData, System.Boolean needDelete); // 0x0600da24
	System.Void OnInputItemChangeAction(); // 0x0600dcdc
	WizardGames.Soc.Common.CustomType.BaseItemNode GetInputItem(); // 0x0600ddb0
	System.Void Refresh(); // 0x0600cb20
	System.Void UnChooseAllIcons(); // 0x0600ded0
	System.Void .ctor(); // 0x0600df3c
	System.Void <ResearchStateChange>b__21_0(); // 0x0600dfa4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideBlueprint : WizardGames.Soc.SocClient.Ui.UiOthersideBase
{
	WizardGames.Soc.SocClient.Ui.UiBlueprintContainerInput containerResearchInput; // 0x30
	WizardGames.Soc.SocClient.Ui.UiBlueprintContainerConsume containerResearchConsume; // 0x38
	WizardGames.Soc.SocClient.Ui.UiBlueprintContainerOutput containerResearchOutput; // 0x40
	FairyGUI.GButton btnResearch; // 0x48
	FairyGUI.Controller btnController; // 0x50
	FairyGUI.Transition showTrans; // 0x58
	FairyGUI.Transition hideTrans; // 0x60
	FairyGUI.Transition btnResearchClickTrans; // 0x68
	System.Boolean initBlueprint; // 0x70
	WizardGames.Soc.SocClient.Ui.UiResearchController uiController; // 0x78
	WizardGames.Soc.SocClient.Ui.UiResearchData uiData; // 0x80
	System.Boolean clickedBtn; // 0x88
	System.Void OnInit(); // 0x0600e014
	System.Void RegisterEvents(); // 0x0600e65c
	System.Void UnRegisterEvents(); // 0x0600e858
	System.Void OnEnable(); // 0x0600ea54
	System.Void OnDisable(); // 0x0600f4b4
	System.Void Refresh(); // 0x0600f918
	System.Void InitData(); // 0x0600f9b0
	System.Void InitUi(); // 0x0600ffac
	System.Void UnChooseAllIcons(); // 0x060100d0
	System.Void ResearchStateChange(WizardGames.Soc.SocClient.Ui.UiResearchState curState, WizardGames.Soc.SocClient.Ui.UiResearchState lastState); // 0x06010154
	System.Void OnClickBack(); // 0x06010578
	System.Void OnClickResearchBtn(); // 0x060105e8
	System.Void SetBackpackCondFilter(); // 0x0600ef50
	System.Void RefreshBackpackUnlockState(); // 0x0600f198
	System.Void UnlockStateProcess(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06010b2c
	System.Void UpdateResearchInfo(); // 0x06010cd8
	System.Void OnIconDragStart(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x06010d44
	System.Void OnIconDragEnd(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem, System.Boolean isDragValid); // 0x06010dec
	System.Void .ctor(); // 0x06010e9c
	System.Void <OnInit>b__12_0(FairyGUI.EventContext ctx); // 0x06010f04
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideBlueprint.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiOthersideBlueprint.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.Common.Data.DataItem.ItemConfig,System.Boolean> <>9__24_0; // 0x8
	static System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> <>9__24_1; // 0x10
	static System.Void .cctor(); // 0x06010f7c
	System.Void .ctor(); // 0x06010fe0
	System.Boolean <SetBackpackCondFilter>b__24_0(WizardGames.Soc.Common.Data.DataItem.ItemConfig item); // 0x06011048
	System.Boolean <SetBackpackCondFilter>b__24_1(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x060111a8
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ResearchContainerType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ResearchContainerType Input = 0;
	static WizardGames.Soc.SocClient.Ui.ResearchContainerType Consume = 1;
	static WizardGames.Soc.SocClient.Ui.ResearchContainerType Output = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResearchController : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiResearchData uiData; // 0x10
	System.Action<WizardGames.Soc.SocClient.Ui.UiResearchState,WizardGames.Soc.SocClient.Ui.UiResearchState> ResearchStateChangeAction; // 0x18
	System.Action OnInputItemChangeAction; // 0x20
	System.Action<System.Boolean> OnConsumeItemNumChangeAction; // 0x28
	WizardGames.Soc.SocClient.Ui.UiResearchData get_UiData(); // 0x06011290
	System.Void set_ResearchState(WizardGames.Soc.SocClient.Ui.UiResearchState value); // 0x060112f4
	System.Void OnInit(); // 0x0600e5cc
	System.Void OnEnable(); // 0x0600ecb4
	System.Void OnDisable(); // 0x0600f640
	System.Void ResearchStateChange(WizardGames.Soc.SocClient.Ui.UiResearchState curState, WizardGames.Soc.SocClient.Ui.UiResearchState lastState); // 0x060114ac
	System.Int32 GetConsumeNumNeed(System.Int64 itemCfgId); // 0x0600fe80
	System.Void UpdateResearchInfo(); // 0x0601154c
	System.Void ResearchableCheck(); // 0x06011ab8
	System.Void SetResearchState(System.Boolean isResearching, System.Single researchTime); // 0x06011c2c
	System.Void UpdateServerData(System.Boolean syncTime); // 0x0600f304
	System.Void .ctor(); // 0x0600e564
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResearchData : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiResearchState researchState; // 0x10
	System.Single totalResearchTime; // 0x14
	System.Int64 curResearchCompleteTimeTs; // 0x18
	WizardGames.Soc.Common.CustomType.ItemContainerNode inputItemContainer; // 0x20
	WizardGames.Soc.Common.CustomType.ItemContainerNode consumeItemContainer; // 0x28
	WizardGames.Soc.Common.CustomType.ItemContainerNode outputItemContainer; // 0x30
	System.Int64 itemTableId; // 0x38
	System.Int32 consumeNumNeed; // 0x40
	System.Boolean isResearching; // 0x44
	WizardGames.Soc.Common.Entity.PartEntity curOpenEntity; // 0x48
	System.Int32 lackConsume; // 0x50
	System.Int32 curConsumeNum; // 0x54
	WizardGames.Soc.Common.Component.ResearchBenchComponent get_ResearchBenchClient(); // 0x06010998
	System.Void ClearData(); // 0x0600f860
	System.Void .ctor(); // 0x060113a8
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiResearchState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiResearchState Unresearchable = 0;
	static WizardGames.Soc.SocClient.Ui.UiResearchState Researchable = 1;
	static WizardGames.Soc.SocClient.Ui.UiResearchState Researching = 2;
	static WizardGames.Soc.SocClient.Ui.UiResearchState ResearchSuccess = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResearchStateContainer : WizardGames.Soc.SocClient.Ui.ClientContainerFixed
{
	FairyGUI.GComponent iconCom; // 0x78
	System.Boolean isUseCustomTipsPos; // 0x80
	UnityEngine.Vector2 customTipsPos; // 0x84
	WizardGames.Soc.SocClient.Ui.ResearchContainerType containerType; // 0x8c
	static System.Collections.Generic.List<System.Int64> tempPathList; // 0x0
	System.Collections.Generic.List<System.Int64> tempSrcPath; // 0x90
	System.Collections.Generic.List<System.Int64> tempTargetPath; // 0x98
	System.Void Bind(FairyGUI.GList iconList, WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container, WizardGames.Soc.SocClient.Ui.ResearchContainerType containerType, System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> iconProcess); // 0x06008d4c
	System.Void BindItemContainer(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container); // 0x06008eec
	System.Void SetContainerCond(WizardGames.Soc.Common.CustomType.ItemContainerNode container); // 0x06011d28
	System.Void CollectIcons(); // 0x06011e78
	System.Void DealIconWhenCollect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x060121c0
	System.Void SetItemDatas(); // 0x060124d4
	System.Boolean OnIconAcceptDrag(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x060129bc
	System.Void SetComItemIconDisplay(System.Boolean display); // 0x0600d8dc
	System.Void MoveToConsume(WizardGames.Soc.Common.CustomType.BaseItemNode moveItem); // 0x06012f90
	System.Void .ctor(); // 0x06008c30
	static System.Void .cctor(); // 0x0601335c
	WizardGames.Soc.SocClient.Collection.Common.CanAcceptResult <SetContainerCond>b__11_0(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x060133f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResearchStateContainer.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiResearchStateContainer.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.Share.Framework.EntityBase> <>9__17_1; // 0x8
	static System.Void .cctor(); // 0x06013a04
	System.Void .ctor(); // 0x06013a68
	System.Void <MoveToConsume>b__17_1(WizardGames.Soc.Share.Framework.EntityBase loot); // 0x06013ad0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResearchStateContainer.<>c__DisplayClass13_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	System.Void .ctor(); // 0x060122e0
	System.Boolean <DealIconWhenCollect>b__0(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x06013c0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResearchStateContainer.<>c__DisplayClass17_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode moveItem; // 0x10
	System.Void .ctor(); // 0x060132f4
	System.Void <MoveToConsume>b__0(WizardGames.Soc.Share.Framework.EntityBase loot, System.Boolean needToast); // 0x06013ce4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ClientContainerCore : System.Object
{
	System.Boolean isDisableDarkIcons; // 0x10
	System.Func<WizardGames.Soc.Common.Data.DataItem.ItemConfig,System.Boolean> condFilter; // 0x18
	System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> condItemNodeFilter; // 0x20
	System.Boolean tipsAtIconLeft; // 0x28
	FairyGUI.GComponent iconParent; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComItemIcon> icons; // 0x38
	System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> onCollectIcon; // 0x40
	System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> onSetIcon; // 0x48
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> typeFilter; // 0x50
	System.Int64 preChooseItemUid; // 0x58
	WizardGames.Soc.SocClient.Ui.ComItemIcon preChooseItemIcon; // 0x60
	FairyGUI.GList get_iconList(); // 0x06011e00
	System.Void set_iconList(FairyGUI.GList value); // 0x06013e7c
	System.Void Refresh(); // 0x055049cc
	System.Void Bind(FairyGUI.GComponent iconParent, System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> onCollectIcon, System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> onSetIcon); // 0x06013efc
	System.Void DealIconWhenCollect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06012348
	System.Void DealIconWhenSetData(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06014020
	System.Void ChooseItemByUid(System.Int64 uid, WizardGames.Soc.SocClient.Ui.ComItemIcon preChooseIcon); // 0x060140b8
	System.Void UnChooseAllIcons(); // 0x06014348
	System.Void SetIconDarkState(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x0601267c
	System.Void ForeachIcon(System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> process); // 0x06014470
	System.Void RefreshIconDarkState(); // 0x0601452c
	System.Void ApplyTypeFilter(System.Collections.Generic.Dictionary<System.Int32,System.Boolean> filter, System.Boolean disableDarkIcons); // 0x060145e0
	System.Void ClearFilters(); // 0x06014678
	WizardGames.Soc.SocClient.Ui.ComItemIcon GetNeastIconAtPos(UnityEngine.Vector2 pos); // 0x06014704
	System.Boolean get_onlyMission(); // 0x060148b8
	System.Void RefreshTags(); // 0x0601491c
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x06014a98
	System.Void SetChooseInfo(System.Int64 uid, WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06014cd4
	System.Void ClearChooseInfo(); // 0x06014d60
	System.Void OnClickItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x06014dd4
	System.Void .ctor(); // 0x0601532c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ClientContainerCore.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.ClientContainerCore.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> <>9__21_0; // 0x8
	static System.Void .cctor(); // 0x060153a4
	System.Void .ctor(); // 0x06015408
	System.Void <UnChooseAllIcons>b__21_0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06015470
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ClientContainerCore.<>c__DisplayClass18_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	System.Void .ctor(); // 0x06013fb8
	System.Void <DealIconWhenCollect>b__0(FairyGUI.EventContext ctx); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ClientContainerCore.<>c__DisplayClass20_0 : System.Object
{
	System.Int64 uid; // 0x10
	System.Boolean hasIconChoosed; // 0x18
	System.Void .ctor(); // 0x060142e0
	System.Void <ChooseItemByUid>b__0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06015724
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ClientContainerCore.<>c__DisplayClass31_0 : System.Object
{
	UnityEngine.Vector2 pos; // 0x10
	System.Single minDis; // 0x18
	WizardGames.Soc.SocClient.Ui.ComItemIcon minDisIcon; // 0x20
	System.Void .ctor(); // 0x06014850
	System.Void <GetNeastIconAtPos>b__0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06015888
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ClientContainerFixed : WizardGames.Soc.SocClient.Ui.ClientContainerCore
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComItemIconLoader> iconLoaders; // 0x68
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap <BindNode>k__BackingField; // 0x70
	System.Boolean get_UseIconLoader(); // 0x06015ccc
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap get_BindNode(); // 0x06015d54
	System.Void set_BindNode(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap value); // 0x06015db8
	WizardGames.Soc.Common.CustomType.Alpha3ContainerClient get_BindContainer(); // 0x06015e38
	System.Void Bind(FairyGUI.GComponent iconParent, WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container, System.Boolean autoSetItemDatas, System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> onCollectIcon, System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> onSetIcon); // 0x06015f48
	System.Void CollectIcons(); // 0x060160a4
	System.Void ReturnAllIconsOfLoaders(); // 0x06016498
	System.Void RequestAllIconsOfLoaders(System.Boolean setDataAfterIconCollected); // 0x0601664c
	System.Void SetItemDatas(); // 0x06016980
	System.Void Refresh(); // 0x06016e00
	System.Void .ctor(); // 0x06016e64
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.ContainerIndexInfo : System.ValueType
{
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap Container; // 0x10
	System.Int32 Index; // 0x18
	System.Void .ctor(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap c, System.Int32 i); // 0x06016ecc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ClientContainerFlexible : WizardGames.Soc.SocClient.Ui.ClientContainerCore
{
	System.Int64 preChooseItemUid; // 0x68
	WizardGames.Soc.SocClient.Ui.ComItemIcon preChooseIcon; // 0x70
	System.Func<System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> itemListProvider; // 0x78
	System.Func<System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ContainerIndexInfo>> itemIndexListProvider; // 0x80
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> curItemList; // 0x88
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ContainerIndexInfo> curIndexList; // 0x90
	WizardGames.Soc.SocClient.Ui.IItemIconProvider iconProvider; // 0x98
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.IItemIconProvider provider); // 0x06016f5c
	System.Void Bind(FairyGUI.GList iconParent, System.Func<System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> provider, System.Boolean autoSetItemDatas, System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> onCollectIcon, System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> onSetIcon); // 0x06016ff0
	System.Void Bind(FairyGUI.GList iconParent, System.Func<System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ContainerIndexInfo>> provider, System.Boolean autoSetItemDatas, System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> onCollectIcon, System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> onSetIcon); // 0x0601715c
	System.Void IconRenderer(System.Int32 index, FairyGUI.GObject item); // 0x060172c8
	System.Void ClearAllIcons(); // 0x06017ca4
	System.Void SetItemDatas(); // 0x06017efc
	System.Void Refresh(); // 0x060181a8
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Ui.IItemIconProvider : 
{
	
	WizardGames.Soc.SocClient.Ui.ComItemIcon GetIcon(); // 0x054e7844
	System.Void ReturnIcon(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ConversionPreViewItemData : System.Object
{
	System.Boolean UsePartialNum; // 0x10
	System.Single PartialNum; // 0x14
	WizardGames.Soc.Common.Data.DataItem.ItemConfig itemConfig; // 0x18
	System.Int64 itemId; // 0x20
	System.Int32 itemCount; // 0x28
	System.Int32 Stack; // 0x2c
	System.Void SetData(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemConfig, System.Int32 itemCount); // 0x0601820c
	System.Void Clear(); // 0x060182ac
	System.Void .ctor(); // 0x06018328
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EConversionContainerType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EConversionContainerType Input = 0;
	static WizardGames.Soc.SocClient.Ui.EConversionContainerType Output = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EConversionStateType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EConversionStateType Normal = 0;
	static WizardGames.Soc.SocClient.Ui.EConversionStateType Working = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiConversionContainerBase : WizardGames.Soc.SocClient.Ui.ClientContainerFixed
{
	System.Collections.Generic.List<System.Int32> oldItemCount; // 0x78
	WizardGames.Soc.SocClient.Ui.EConversionContainerType containerType; // 0x80
	System.Int32 get_ColCount(); // 0x06018390
	System.Void BindItemContainer(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container); // 0x060183f4
	System.Void CollectIcons(); // 0x0601860c
	System.Void DealIconWhenCollect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06018920
	System.Void SetItemDatas(); // 0x060189b4
	System.Void ProgressItemStateChange(WizardGames.Soc.SocClient.Ui.ComItemIcon icon, System.Int32 changeState); // 0x06018e3c
	System.Boolean OnIconAcceptDrag(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x06018eb8
	System.Boolean GetItemPos(System.Int64 itemUid, System.Int32& pos); // 0x06019178
	System.Void SetItemDecomposeProgress(System.Int32 pos, System.Single progress); // 0x06019538
	System.Void ClearAllIconProgress(); // 0x0601962c
	System.Void .ctor(); // 0x060197a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiConversionContainerInput : WizardGames.Soc.SocClient.Ui.UiConversionContainerBase
{
	WizardGames.Soc.SocClient.Ui.UiConversionDataBase uiData; // 0x88
	FairyGUI.GComponent Root; // 0x90
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiConversionDataBase uiData, WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComResolventBinder resolventBinder, WizardGames.Soc.SocClient.Ui.EConversionContainerType containerType, System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> iconProcess); // 0x06019850
	System.Void ProgressItemStateChange(WizardGames.Soc.SocClient.Ui.ComItemIcon icon, System.Int32 changeState); // 0x06019cb8
	System.Void .ctor(); // 0x06019d54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiConversionContainerOutput : WizardGames.Soc.SocClient.Ui.UiConversionContainerBase
{
	WizardGames.Soc.SocClient.Ui.UiConversionDataBase uiData; // 0x88
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOutputBinder binder; // 0x90
	FairyGUI.GList preViewList; // 0x98
	System.Int32 outPutStatus; // 0xa0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ConversionPreViewItemData> PreviewDatas; // 0xa8
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> decomposeResultDics; // 0xb0
	System.Collections.Generic.Dictionary<System.Int64,System.Single> partialDecomposeResultDics; // 0xb8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOutputItemBinder> outPutIcons; // 0xc0
	System.Int32 RecycleNum; // 0xc8
	System.Boolean get_CustomShowOutput(); // 0x06019db8
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiConversionDataBase uiData, WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOutputBinder comOutputBinder, WizardGames.Soc.SocClient.Ui.EConversionContainerType containerType, System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> iconProcess); // 0x06019e1c
	System.Void Refresh(); // 0x0601a3d8
	System.Void OnClickOutPut(); // 0x0601a5b0
	System.Void OnClickPreView(); // 0x0601a61c
	System.Void SetStatus(); // 0x0601a68c
	System.Void SetOutputState(); // 0x0601a8cc
	System.Void CollectIcons(); // 0x0601aa64
	System.Void SetItemDatas(); // 0x0601aef8
	System.Void PlayFinishAnim(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x0601b3c0
	System.Void RefreshPreviewData(); // 0x0601b474
	System.Void CalcPreviewListData(); // 0x0601bd58
	System.Void AddPreViewResultItem(System.Int32 itemId, System.Int32 itemCount); // 0x0601bdb8
	System.Void AddPartialPreViewResultItem(System.Int32 itemId, System.Single itemCount); // 0x0601bedc
	System.Void OnPreViewRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x0601c00c
	System.Void OnClickPreViewItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x0601c584
	System.Void .ctor(); // 0x0601c84c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiConversionContainerOutput.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiConversionContainerOutput.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.ConversionPreViewItemData> <>9__20_0; // 0x8
	static System.Void .cctor(); // 0x0601ca04
	System.Void .ctor(); // 0x0601ca68
	System.Int32 <RefreshPreviewData>b__20_0(WizardGames.Soc.SocClient.Ui.ConversionPreViewItemData a1, WizardGames.Soc.SocClient.Ui.ConversionPreViewItemData a2); // 0x0601cad0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiConversionDataBase : System.Object
{
	System.Boolean InputItemRemoveFlag; // 0x10
	WizardGames.Soc.SocClient.Ui.EConversionStateType State; // 0x14
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap inputItemContainer; // 0x18
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap outputItemContainer; // 0x20
	WizardGames.Soc.Common.Entity.PartEntity curOpenEntity; // 0x28
	System.Int64 startTime; // 0x30
	System.Int64 EndTime; // 0x38
	System.Int32 curDecomposePos; // 0x40
	System.Boolean get_HasInputItems(); // 0x0601a7d0
	System.Boolean get_HasOutputItems(); // 0x0601a4b4
	System.Boolean get_isOpen(); // 0x0601cb8c
	System.Int64 get_StartTimeTsFromEntity(); // 0x0601cc48
	System.Int64 get_WorkingItemId(); // 0x0601ccac
	System.Void .ctor(); // 0x0601cd10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideConversionBase : WizardGames.Soc.SocClient.Ui.UiOthersideBase
{
	WizardGames.Soc.SocClient.Ui.UiConversionDataBase uiData; // 0x30
	System.Boolean initDecomposableMachine; // 0x38
	System.Int64 refreshInputProgressTimerId; // 0x40
	System.Boolean firstInit; // 0x48
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOtherSideDecomposerBinder binder; // 0x50
	WizardGames.Soc.SocClient.Ui.UiConversionContainerInput containerInput; // 0x58
	WizardGames.Soc.SocClient.Ui.UiConversionContainerOutput containerOutput; // 0x60
	System.Boolean get_DefaultToggleSelect(); // 0x0601cd80
	System.Boolean get_DefaultToggleShowState(); // 0x0601cde4
	System.String get_OtherSideName(); // 0x0601ce48
	System.Void RegisterEvents(); // 0x0601ceac
	System.Void UnRegisterEvents(); // 0x0601cfa0
	System.Void OnEnable(); // 0x0601d094
	System.Void OnDisable(); // 0x0601d4b0
	System.Void OnInit(); // 0x0601d5c4
	System.Void OnClickSalvage(); // 0x0601d974
	System.Void OnClickStop(); // 0x0601d9d4
	System.Void InitData(); // 0x0601da34
	System.Void OnIconDragStart(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x0601da94
	System.Void OnIconDragEnd(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem, System.Boolean isDragValid); // 0x0601db08
	System.Void OnComItemIconChoose(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Boolean choose); // 0x0601dc58
	System.Void ComversionStateUpdate(System.Boolean updateStartTime); // 0x05523a7c
	System.Void SetTimeState(); // 0x0601e390
	System.Void PlayLoopAnim(); // 0x0601e0a4
	System.Void StopLoopAnim(); // 0x0601e220
	System.Void Refresh(); // 0x0601e5c0
	System.Void UnChooseAllIcons(); // 0x0601e660
	System.Void UpdateBtnState(); // 0x0601e6e0
	System.Void DoAllQuickLoot(); // 0x0601ec00
	System.Void OnQuickLootFinished(); // 0x0601eff0
	System.Void OnQuickLootStateChanged(System.Boolean state); // 0x0601f0a0
	System.Void RefreshInputProgressTimer(System.Int64 timerId, System.Object callbackData, System.Boolean needDelete); // 0x0601f134
	System.Int64 GetOnceWorkingTime(); // 0x0601f364
	System.Single CalcInputItemProgress(System.Int64 startTime, System.Int64 endTime, System.Int64 now); // 0x0601f3c8
	System.Void SetBackpackCondFilter(); // 0x0601f488
	System.Void .ctor(); // 0x0601f668
	System.Boolean <SetBackpackCondFilter>b__37_0(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x0601f6d0
	System.Boolean <SetBackpackCondFilter>b__37_1(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x0601f784
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideConversionBase.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiOthersideConversionBase.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> <>9__22_0; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> <>9__31_0; // 0x10
	static System.Void .cctor(); // 0x0601f838
	System.Void .ctor(); // 0x0601f89c
	System.Void <OnIconDragEnd>b__22_0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x0601f904
	System.Void <DoAllQuickLoot>b__31_0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x0601f98c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiComposterContainerInput : WizardGames.Soc.SocClient.Ui.UiConversionContainerInput
{
	
	System.Int32 get_ColCount(); // 0x0601fcbc
	System.Void .ctor(); // 0x0601fd20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiComposterContainerOutput : WizardGames.Soc.SocClient.Ui.UiConversionContainerOutput
{
	
	System.Int32 get_ColCount(); // 0x0601fd84
	System.Boolean get_CustomShowOutput(); // 0x0601fde8
	System.Void SetStatus(); // 0x0601ff9c
	System.Void CalcPreviewListData(); // 0x06020180
	System.Void SetItemDatas(); // 0x0602054c
	System.Void .ctor(); // 0x06020d2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiComposterData : WizardGames.Soc.SocClient.Ui.UiConversionDataBase
{
	
	WizardGames.Soc.Common.Component.ComposterComponent get_Composter(); // 0x0601fed0
	System.Boolean get_isOpen(); // 0x06020d90
	System.Int64 get_StartTimeTsFromEntity(); // 0x06020e20
	System.Int64 get_WorkingItemId(); // 0x06020eac
	System.Void .ctor(); // 0x06020f38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideComposter : WizardGames.Soc.SocClient.Ui.UiOthersideConversionBase
{
	
	System.Boolean get_DefaultToggleSelect(); // 0x06020f9c
	System.Boolean get_DefaultToggleShowState(); // 0x06021000
	System.String get_OtherSideName(); // 0x06021064
	System.Void .ctor(); // 0x060210f4
	System.Void RegisterEvents(); // 0x0602118c
	System.Void UnRegisterEvents(); // 0x060212fc
	System.Void OnInit(); // 0x0602146c
	System.Void OnClickSalvage(); // 0x060216c8
	System.Void OnClickStop(); // 0x06021908
	System.Void InitData(); // 0x060219f4
	System.Void UpdateBtnState(); // 0x06021d10
	System.Void OnIconDragStart(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x060222b4
	System.Void Refresh(); // 0x0602248c
	System.Int64 GetOnceWorkingTime(); // 0x0602256c
	System.Void ComposterAnyUpdate(); // 0x060224f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideComposter.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiOthersideComposter.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> <>9__14_0; // 0x8
	static System.Void .cctor(); // 0x06022664
	System.Void .ctor(); // 0x060226c8
	System.Void <OnIconDragStart>b__14_0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06022730
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDecomposeMachineContainerInput : WizardGames.Soc.SocClient.Ui.UiConversionContainerInput
{
	
	System.Void .ctor(); // 0x060227b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDecomposeMachineContainerOutput : WizardGames.Soc.SocClient.Ui.UiConversionContainerOutput
{
	
	System.Void CalcPreviewListData(); // 0x0602281c
	System.Void .ctor(); // 0x06022d54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDecomposeMachineDataNew : WizardGames.Soc.SocClient.Ui.UiConversionDataBase
{
	
	WizardGames.Soc.Common.Component.DecomposeMachineComponent get_DecomposeMachine(); // 0x06022db8
	System.Int64 get_StartTimeTsFromEntity(); // 0x06022e84
	System.Int64 get_WorkingItemId(); // 0x06022f10
	System.Void .ctor(); // 0x06022f9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideDecomposeNew : WizardGames.Soc.SocClient.Ui.UiOthersideConversionBase
{
	static System.Boolean OpenGuide; // 0x0
	WizardGames.Soc.SocClient.Ui.UiInventoryOtherside uiInventory; // 0x68
	System.String get_OtherSideName(); // 0x06023000
	System.Void .ctor(); // 0x06023090
	System.Void Show(System.Int64 targetCollectionId); // 0x06023128
	System.Void RegisterEvents(); // 0x0602337c
	System.Void UnRegisterEvents(); // 0x060234ec
	System.Void OnInit(); // 0x0602365c
	System.Void OnEnable(); // 0x06023914
	System.Void OnClickSalvage(); // 0x060239d8
	System.Void OnClickStop(); // 0x06023c18
	System.Void InitData(); // 0x06023d04
	System.Void OnIconDragStart(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x06024020
	System.Void Refresh(); // 0x0602416c
	System.Void UnChooseAllIcons(); // 0x0602424c
	System.Void DecomposeAnyUpdate(); // 0x060241d8
	System.Int64 GetOnceWorkingTime(); // 0x060242cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideDecomposeNew.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiOthersideDecomposeNew.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> <>9__13_0; // 0x8
	static System.Void .cctor(); // 0x060243bc
	System.Void .ctor(); // 0x06024420
	System.Void <OnIconDragStart>b__13_0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06024488
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideFuse : WizardGames.Soc.SocClient.Ui.UiOthersideBase
{
	FairyGUI.Controller ctrlStyle; // 0x30
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x38
	System.Int64 lastFuseItemID; // 0x40
	System.Boolean isDroppingFuse; // 0x48
	System.Void OnInit(); // 0x06024510
	System.Boolean OnIconAcceptDrag(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x06024ae0
	System.Boolean OnItemDrop(WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x06024b64
	WizardGames.Soc.Common.CustomType.BaseItemNode GetFuseItem(); // 0x060249d0
	System.Void Refresh(); // 0x06024ed0
	System.Void OnEnable(); // 0x06025170
	System.Void .ctor(); // 0x060252ac
	System.Void <OnInit>b__4_2(FairyGUI.EventContext ctx); // 0x06025314
	System.Void <OnInit>b__4_3(); // 0x06025424
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideFuse.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiOthersideFuse.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.SocClient.Ui.ItemDragInfo,System.Boolean> <>9__4_0; // 0x8
	static FairyGUI.EventCallback1 <>9__4_1; // 0x10
	static System.Void .cctor(); // 0x0602565c
	System.Void .ctor(); // 0x060256c0
	System.Boolean <OnInit>b__4_0(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x06025728
	System.Void <OnInit>b__4_1(FairyGUI.EventContext ctx); // 0x06025874
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHitchPostContainer : WizardGames.Soc.SocClient.Ui.ClientContainerFixed
{
	
	System.Void Bind(FairyGUI.GList iconList, System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> iconProcess); // 0x06025910
	System.Void BindItemContainer(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container); // 0x06025a3c
	System.Void CollectIcons(); // 0x06025c54
	System.Void DealIconWhenCollect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06025e3c
	System.Boolean OnIconAcceptDrag(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x060260c8
	System.Void SetItemDatas(); // 0x06026358
	WizardGames.Soc.SocClient.Ui.ComItemIcon GetIconByIndex(System.Int32 index); // 0x060266ac
	System.Void .ctor(); // 0x06026774
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHitchPostContainer.<>c__DisplayClass3_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	System.Void .ctor(); // 0x06026060
	System.Void <DealIconWhenCollect>b__0(FairyGUI.EventContext ctx); // 0x060267d8
	System.Void <DealIconWhenCollect>b__1(FairyGUI.EventContext ctx); // 0x06027320
	System.Boolean <DealIconWhenCollect>b__2(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x060273a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideHitchPostNew : WizardGames.Soc.SocClient.Ui.UiOthersideBase
{
	System.Boolean initData; // 0x30
	WizardGames.Soc.SocClient.Ui.UiHitchPostContainer hitchPostContainer; // 0x38
	WizardGames.Soc.Common.CustomType.ItemContainerNode itemContainer; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOtherSideHitchPostBinder binder; // 0x48
	System.Void OnInit(); // 0x0602752c
	System.Void InitData(); // 0x0602783c
	System.Void Refresh(); // 0x06027918
	System.Void OnEnable(); // 0x06027af8
	System.Void OnDisable(); // 0x06027df8
	WizardGames.Soc.SocClient.Ui.ComItemIcon SetOtherHightLight(System.Int32 tarIndex, System.Boolean on); // 0x06027e64
	System.Void UnChooseAllIcons(); // 0x06027f10
	System.Void DoAllQuickLoot(); // 0x06027f7c
	System.Void SetBackpackCondFilter(); // 0x06027b70
	System.Void .ctor(); // 0x06028204
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideHitchPostNew.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiOthersideHitchPostNew.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> <>9__11_0; // 0x8
	static System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> <>9__12_0; // 0x10
	static System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> <>9__12_1; // 0x18
	static System.Void .cctor(); // 0x0602826c
	System.Void .ctor(); // 0x060282d0
	System.Void <DoAllQuickLoot>b__11_0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06028338
	System.Boolean <SetBackpackCondFilter>b__12_0(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x06028498
	System.Boolean <SetBackpackCondFilter>b__12_1(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x06028580
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideHitchPostNew.<>c__DisplayClass4_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiInventoryOtherside inventory; // 0x10
	System.Void .ctor(); // 0x060277d4
	System.Void <OnInit>b__0(); // 0x06028668
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.LockerRowInfo : System.Object
{
	System.Boolean isTitle; // 0x10
	System.Int32 maxCount; // 0x14
	WizardGames.Soc.SocClient.Ui.ELockerTitleType type; // 0x18
	System.String title; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ELockerIconType> iconTypes; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap> containers; // 0x30
	System.Collections.Generic.List<System.Int32> itemIndexs; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComItemIcon> icons; // 0x40
	System.Void .ctor(); // 0x060286dc
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.ELockerTitleType type, System.Int32 maxCount); // 0x060288a0
	System.String GetTitle(); // 0x06028a9c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ELockerTitleType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ELockerTitleType None = 0;
	static WizardGames.Soc.SocClient.Ui.ELockerTitleType Equip = 1;
	static WizardGames.Soc.SocClient.Ui.ELockerTitleType ShortcutBar = 2;
	static WizardGames.Soc.SocClient.Ui.ELockerTitleType Inventory = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ELockerIconType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ELockerIconType None = 0;
	static WizardGames.Soc.SocClient.Ui.ELockerIconType Equip = 1;
	static WizardGames.Soc.SocClient.Ui.ELockerIconType Weapon = 2;
	static WizardGames.Soc.SocClient.Ui.ELockerIconType ShortcutBar = 3;
	static WizardGames.Soc.SocClient.Ui.ELockerIconType Inventory = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideLocker : WizardGames.Soc.SocClient.Ui.UiOthersideBase
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.LockerRowInfo> dataList; // 0x30
	FairyGUI.GList list; // 0x38
	FairyGUI.GList listTitleTabs; // 0x40
	FairyGUI.GButton exChangeBtn; // 0x48
	System.Single titleHeight2; // 0x50
	System.Single itemHeight; // 0x54
	System.Single titleHeight; // 0x58
	System.Single lineHeight; // 0x5c
	System.Collections.Generic.Dictionary<System.Int32,System.Single> itemHeights; // 0x60
	System.Int32 currentSlotIndex; // 0x68
	System.Int32 rowCount; // 0x6c
	WizardGames.Soc.SocClient.Ui.ComItemIcon curChooseIcon; // 0x70
	System.Void OnInit(); // 0x06028bb4
	System.Void OnEnable(); // 0x06028ed4
	System.Void OnDisable(); // 0x06029124
	System.Void RegisterEvents(); // 0x06029184
	System.Void UnRegisterEvents(); // 0x0602927c
	System.Boolean CanDoubleClickToMove(); // 0x06029374
	System.Void OnEquipChange(); // 0x060293d8
	System.Void RefreshTabs(); // 0x06029020
	System.Void OnClickExChange(); // 0x060294c0
	System.Void TabRenderer(System.Int32 index, FairyGUI.GObject item); // 0x060296c0
	System.Void OnClickTab(System.Int32 index); // 0x06029a38
	System.Void ScrollViewToTop(); // 0x06029ad4
	System.Void Refresh(); // 0x06029b58
	System.Void InitData(); // 0x06029bc4
	System.Void ReLoadListData(); // 0x06029c24
	System.Void RefreshData(); // 0x06029d04
	System.Void EquipData(); // 0x06029ef4
	System.Void SetRowIconData(WizardGames.Soc.SocClient.Ui.LockerRowInfo data, WizardGames.Soc.Common.CustomType.ItemContainerNode containerNode, System.Int32 soltIndex, WizardGames.Soc.SocClient.Ui.ELockerIconType iconType); // 0x0602a728
	System.Void ShortcutBarData(); // 0x0602a264
	System.Void InventoryData(); // 0x0602a4b4
	System.Void CalculateItemHeights(); // 0x06029db4
	System.Void RenderList(System.Int32 index, FairyGUI.GObject obj); // 0x0602a924
	System.Void SetTitle(FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOtherSideLockerItemBinder binder, WizardGames.Soc.SocClient.Ui.LockerRowInfo data); // 0x0602aff4
	System.Void CheckItemIconListControl(WizardGames.Soc.SocClient.Ui.LockerRowInfo data, FairyGUI.GList listMain); // 0x0602b510
	System.Void OnClickItemIcon(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x0602bb0c
	System.Void DealIconWhenCollect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x0602b6e8
	System.Void SetIconDarkState(WizardGames.Soc.SocClient.Ui.LockerRowInfo data, WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x0602b954
	System.Single CollectLastOneAddHeight(); // 0x0602b9d0
	System.Void .ctor(); // 0x0602c230
	System.Void <OnInit>b__12_0(FairyGUI.EventContext ctx); // 0x0602c34c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideLocker.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiOthersideLocker.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ComBaseIcon,System.Boolean> <>9__38_0; // 0x8
	static System.Void .cctor(); // 0x0602c3c4
	System.Void .ctor(); // 0x0602c428
	System.Void <DealIconWhenCollect>b__38_0(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, System.Boolean state); // 0x0602c490
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideLocker.<>c__DisplayClass21_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiOthersideLocker <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x060299d0
	System.Void <TabRenderer>b__0(); // 0x0602c6a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideLocker.<>c__DisplayClass38_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	System.Void .ctor(); // 0x0602c1c8
	System.Void <DealIconWhenCollect>b__1(FairyGUI.EventContext ctx); // 0x0602c710
	System.Void <DealIconWhenCollect>b__2(FairyGUI.EventContext ctx); // 0x0602cb14
	System.Boolean <DealIconWhenCollect>b__3(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x0602cb9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrQuickLoot : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.MgrQuickLoot.QueueInfo> itemID2Info; // 0x18
	System.Collections.Generic.Queue<System.Int64> fromOtherToMine; // 0x20
	System.Collections.Generic.Queue<System.Int64> fromMineToOther; // 0x28
	System.Collections.Generic.Queue<System.Int64> forQuickDrop; // 0x30
	System.Collections.Generic.Queue<System.Int64> forQuickDoubleClick; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.MgrQuickLoot.PrepareInfo> prepareInfos; // 0x40
	System.Int64 quickMoveItemUid; // 0x48
	WizardGames.Soc.SocClient.Ui.ComItemIcon quickMoveItemIcon; // 0x50
	System.Int32 cantToOthersideCount; // 0x58
	System.Int32 canToOthersideCount; // 0x5c
	System.Int32 cantToInventoryCount; // 0x60
	System.Boolean <IsQuickLooting>k__BackingField; // 0x64
	System.Boolean <IsLootingToMineOnly>k__BackingField; // 0x65
	System.Boolean <IsQuickDrop>k__BackingField; // 0x66
	System.Boolean <IsQuickDoubleClick>k__BackingField; // 0x67
	System.Func<System.Int64,WizardGames.Soc.SocClient.Ui.ComItemIcon> beforeQuickAct; // 0x68
	System.Boolean get_HasPrepareInfos(); // 0x0602cc74
	System.Int32 get_PrepareInfosCount(); // 0x0602cd00
	System.Boolean get_IsQuickLooting(); // 0x0602cd8c
	System.Void set_IsQuickLooting(System.Boolean value); // 0x0602cdf0
	System.Boolean get_IsLootingToMineOnly(); // 0x0602ce6c
	System.Void set_IsLootingToMineOnly(System.Boolean value); // 0x0602ced0
	System.Boolean get_IsQuickDrop(); // 0x0602cf4c
	System.Void set_IsQuickDrop(System.Boolean value); // 0x0602cfb0
	System.Boolean get_IsQuickAction(); // 0x06017728
	System.Boolean get_IsQuickDoubleClick(); // 0x0602d02c
	System.Void set_IsQuickDoubleClick(System.Boolean value); // 0x0602d090
	System.Void Init(); // 0x0602d10c
	System.Void CleanUp(); // 0x0602d174
	WizardGames.Soc.SocClient.Ui.MgrQuickLoot.QueueInfo GetInfo(System.Int64 uid); // 0x0602d714
	System.Void RefreshInfo(System.Int64 uid, WizardGames.Soc.SocClient.Ui.ComItemIcon icon, System.Boolean forceSet); // 0x06017864
	System.Void RecoverIcon(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x0602d89c
	System.Void ReleaseInfo(System.Int64 uid); // 0x0602da40
	System.Void ClearQueue(System.Collections.Generic.Queue<System.Int64> queue); // 0x0602d380
	System.Void SetQuickLootState(System.Boolean state, System.Boolean needTip, System.Boolean toMineOnly, System.Func<System.Int64,WizardGames.Soc.SocClient.Ui.ComItemIcon> beforeQuickAct); // 0x0601d1ac
	System.Void SetQuickDropState(System.Boolean state, System.Boolean needTip, System.Func<System.Int64,WizardGames.Soc.SocClient.Ui.ComItemIcon> beforeQuickAct); // 0x0602db08
	System.Void SetQuickDoubleClickState(System.Boolean state, System.Boolean needTip, System.Func<System.Int64,WizardGames.Soc.SocClient.Ui.ComItemIcon> beforeQuickAct); // 0x0602de58
	System.Boolean QuickLootToMine(System.Int64 uid, WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x0601faec
	System.Boolean QuickLootToOther(System.Int64 uid, WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06026ccc
	System.Void QuickDrop(System.Int64 uid, WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06026f2c
	System.Void QuickDoubleClick(System.Int64 uid, WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x0602e6fc
	System.Void RemovePreparedQuickAction(System.Int64 uid); // 0x0602e8bc
	System.Void ClearPreparedQuickActions(); // 0x0602d52c
	System.Boolean IsPreparedForQuickAction(System.Int64 uid); // 0x0602e9c4
	System.Void FlushPrepareInfo(); // 0x0602ea6c
	System.Boolean CanMoveItemFromMineToOther(System.Int64 uid, System.Boolean showTips); // 0x0602e43c
	System.Void MoveItemFromMineToOther(System.Int64 uid); // 0x0602ee24
	System.Void DropItem(System.Int64 uid); // 0x0602f0d8
	System.Void DoubleClickItem(System.Int64 uid); // 0x0602f2d8
	System.Void CheckAndShowQuickLoopTips(); // 0x0602e050
	System.Void MoveLootQueueHeadItem(System.Collections.Generic.Queue<System.Int64> queue, System.Boolean moveToMine); // 0x0602f468
	System.Void DealLootQueueHead(System.Collections.Generic.Queue<System.Int64> queue, System.Single dt, System.Boolean moveToMine); // 0x0602f8cc
	System.Void DealDropQueueHead(System.Collections.Generic.Queue<System.Int64> queue, System.Single dt); // 0x0602fc30
	System.Void DealDoubleClickQueueHead(System.Collections.Generic.Queue<System.Int64> queue, System.Single dt); // 0x0602fe84
	System.Void UpdateQuickLooting(System.Single dt); // 0x06030098
	System.Void UpdateQuickDrop(System.Single dt); // 0x0603018c
	System.Void UpdateQuickDoubleClick(System.Single dt); // 0x06030268
	System.Boolean HasQuickLootingData(); // 0x0601ef50
	System.Boolean HasFromOtherToMineQuickLootingData(); // 0x06030344
	System.Void RecordAsQuickMoveItem(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x0602c0a0
	System.Void ClearQuickMoveItem(); // 0x0601c7dc
	System.Boolean HasQuickMoveItem(); // 0x060303d0
	System.Void TryQuickMoveItem(WizardGames.Soc.SocClient.Ui.ComItemIcon emptyIcon); // 0x060254c0
	System.Void CheckDropAndMove(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05523a54
	static System.Single get_QuickLootCdTime(); // 0x0602fb48
	System.Void MoveItemFromOtherToMine(System.Int64 uid); // 0x0602f5ec
	System.Boolean CanMoveItemFromOtherToMine(System.Int64 uid, System.Boolean showTips); // 0x0602e26c
	System.Boolean PrepareToQuickAction(System.Int64 uid, WizardGames.Soc.SocClient.Ui.ComItemIcon icon, WizardGames.Soc.SocClient.Ui.MgrQuickLoot.QuickActionType type); // 0x0603043c
	System.Void .ctor(); // 0x06030954
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrQuickLoot.QueueInfo : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	System.Single cd; // 0x18
	System.Boolean hasDonePreOp; // 0x1c
	System.Void RefreshIconCD(System.Boolean isDrop); // 0x0602d990
	System.Void .ctor(); // 0x0602d834
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.MgrQuickLoot.QuickActionType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.MgrQuickLoot.QuickActionType LootToMine = 0;
	static WizardGames.Soc.SocClient.Ui.MgrQuickLoot.QuickActionType LootToOther = 1;
	static WizardGames.Soc.SocClient.Ui.MgrQuickLoot.QuickActionType Drop = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrQuickLoot.PrepareInfo : System.Object
{
	static System.Int32 SumOrder; // 0x0
	System.Int32 <Order>k__BackingField; // 0x10
	System.Int64 Uid; // 0x18
	WizardGames.Soc.SocClient.Ui.ComItemIcon Icon; // 0x20
	WizardGames.Soc.SocClient.Ui.MgrQuickLoot.QuickActionType Type; // 0x28
	System.Int32 get_Order(); // 0x060309bc
	System.Void set_Order(System.Int32 value); // 0x06030a20
	System.Void .ctor(System.Int64 uid, WizardGames.Soc.SocClient.Ui.ComItemIcon icon, WizardGames.Soc.SocClient.Ui.MgrQuickLoot.QuickActionType type); // 0x060308a4
	System.Void SetData(System.Int64 uid, WizardGames.Soc.SocClient.Ui.ComItemIcon icon, WizardGames.Soc.SocClient.Ui.MgrQuickLoot.QuickActionType type, System.Boolean resetOrder); // 0x0603076c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrQuickLoot.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.MgrQuickLoot.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.MgrQuickLoot.PrepareInfo> <>9__62_0; // 0x8
	static System.Void .cctor(); // 0x06030a98
	System.Void .ctor(); // 0x06030afc
	System.Int32 <FlushPrepareInfo>b__62_0(WizardGames.Soc.SocClient.Ui.MgrQuickLoot.PrepareInfo a, WizardGames.Soc.SocClient.Ui.MgrQuickLoot.PrepareInfo b); // 0x06030b64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrQuickLoot.<>c__DisplayClass63_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode item; // 0x10
	System.Boolean bAllReject; // 0x18
	System.Boolean bAllFull; // 0x19
	System.Void .ctor(); // 0x0602edbc
	System.Boolean <CanMoveItemFromMineToOther>b__0(WizardGames.Soc.Common.CustomType.ItemContainerNode container); // 0x06030c90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideNearBy : WizardGames.Soc.SocClient.Ui.UiOthersideBase
{
	FairyGUI.Controller ctrlTabCount; // 0x30
	FairyGUI.GButton tabSingle; // 0x38
	FairyGUI.GList listTitleTabs; // 0x40
	FairyGUI.GButton btnPickableTab; // 0x48
	FairyGUI.GButton btnFirsColTab; // 0x50
	FairyGUI.GObject downTrigger; // 0x58
	FairyGUI.GObject upTrigger; // 0x60
	System.Boolean showPickableTab; // 0x68
	System.Int32 curSelectTabIndex; // 0x6c
	WizardGames.Soc.SocClient.Ui.UiOthersideNearbyStorage storage; // 0x70
	WizardGames.Soc.SocClient.Ui.UiOthersideNearbyInventory inventory; // 0x78
	WizardGames.Soc.SocClient.Ui.UiOthersideNearbyInventoryNoGroup inventoryNoGroup; // 0x80
	WizardGames.Soc.SocClient.Ui.UiOthersideBase curMode; // 0x88
	System.Func<System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemGroup>> curItemGroupSource; // 0x90
	System.Func<System.Collections.Generic.List<WizardGames.Soc.Share.Framework.EntityBase>> curCollectionSource; // 0x98
	System.Collections.Generic.List<WizardGames.Soc.Share.Framework.EntityBase> curCollections; // 0xa0
	System.Func<WizardGames.Soc.Share.Framework.EntityBase,System.String> curColNameProvider; // 0xa8
	System.Single fLastClickTime; // 0xb0
	System.Boolean quickDropState; // 0xb4
	System.Single autoScrollTime; // 0xb8
	System.Single autoScrollStep; // 0xbc
	System.Single autoScrollFactor; // 0xc0
	System.Single autoScrollTimer; // 0xc4
	System.Boolean distanceToClose; // 0xc8
	UnityEngine.Vector3 checkPos; // 0xcc
	UnityEngine.Vector3 playerPos; // 0xd8
	System.Single defaultCloseWinDistanceSqr; // 0xe4
	FairyGUI.Controller ctrlContainerPosState; // 0xe8
	WizardGames.Soc.SocClient.Ui.UiInventoryOtherside uiInventory; // 0xf0
	System.Int64 lastLootingId; // 0xf8
	System.Int64 autoHideTimerHandler; // 0x100
	WizardGames.Soc.Share.Framework.EntityBase curShowCol; // 0x108
	System.Collections.Generic.List<System.Int64> foundationIds; // 0x110
	System.Collections.Generic.List<System.Int64> curCollectionIds; // 0x118
	System.Collections.Generic.Dictionary<System.Int64,System.String> entityIdToNames; // 0x120
	System.Boolean needReloadWin; // 0x128
	System.Int32 get_CurSelectTabIndex(); // 0x06030df4
	System.Boolean get_needNewLootWhenChangeTab(); // 0x06030e58
	System.Void OnInit(); // 0x06030ebc
	System.Void RefreshOtherSideName(); // 0x060319c4
	System.Void InitScrollTriggers(FairyGUI.GComponent comRoot); // 0x06031650
	System.Void ResetAutoScroll(); // 0x06031a7c
	System.String GetPlayerColTitle(WizardGames.Soc.Share.Framework.EntityBase ent, System.Boolean& isOfflinePlayer); // 0x06031ae0
	System.String GetNormalColTitle(WizardGames.Soc.Share.Framework.EntityBase col, System.Int32 index, System.Boolean preSetLootName); // 0x06031de4
	System.Boolean HaveDestroyTip(FairyGUI.GTextField textField); // 0x0603219c
	System.String GetBtnTips(); // 0x06032214
	System.Void TabRenderer(System.Int32 index, FairyGUI.GObject item); // 0x0603228c
	WizardGames.Soc.Share.Framework.EntityBase GetCurEntity(System.Int32 curIndex); // 0x060328f0
	System.Void OnClickNearByTab(System.Int32 index, System.Boolean isForce); // 0x0603298c
	System.Void CancelTimer(); // 0x060339a0
	System.Void RefreshTabs(); // 0x06033aa8
	System.Void UpdateTabCoutCtrl(System.Int32 tabCount); // 0x06033d68
	System.Int32 GetColCount(); // 0x06034058
	System.Void UpdateCurSelectTabIndex(); // 0x0603418c
	System.Int32 GetTabCount(); // 0x06034258
	System.Void SetNearBy(System.Func<System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemGroup>> itemGroupSource, System.Func<System.Collections.Generic.List<WizardGames.Soc.Share.Framework.EntityBase>> colSource, System.Func<WizardGames.Soc.Share.Framework.EntityBase,System.String> colNameProvider); // 0x0603434c
	System.Boolean IsPlayerInventoryCol(WizardGames.Soc.Share.Framework.EntityBase ent); // 0x06032744
	System.Void ShowItemListPage(); // 0x060330e8
	System.Void ShowContainerPage(System.Int32 index); // 0x060333d0
	System.Void UpdateTabSingle(System.String title, System.String iconUrl); // 0x06034408
	System.Void UpdateContainerPos(); // 0x060345b4
	System.Void SetBtnTitle(); // 0x06034814
	System.Void SetBtnNormalTitle(System.String title); // 0x06034874
	System.Void SetCurContainer(System.Int32 index); // 0x060348fc
	WizardGames.Soc.SocClient.Ui.ComItemIcon SetOtherHightLight(System.Int32 tarIndex, System.Boolean on); // 0x06034970
	WizardGames.Soc.SocClient.Ui.ComItemIcon GetItemIcon(System.Int64 itemId, System.Boolean scrollToItem); // 0x06034a20
	WizardGames.Soc.SocClient.Ui.ComItemIcon ScrollAndGetIconOfIndex(System.Int32 index); // 0x06034aac
	System.Void Show(System.Int64 collectionId); // 0x06034b34
	System.Void RegisterEvents(); // 0x06034e9c
	System.Void UnRegisterEvents(); // 0x06035408
	System.Void OnOvenNameUpdate(System.Int64 entityId); // 0x06035974
	System.Void OnNearbyCollectionChanged(); // 0x060359f8
	System.Void UiPlayerLootUpdate(); // 0x06035a5c
	System.Void UiPickableDataChange(); // 0x06035ac0
	System.Void OnEnable(); // 0x06035b24
	System.Void OnDisable(); // 0x06035c4c
	System.Void OnItemDragStart(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x06035e90
	System.Void OnItemDragEnd(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem, System.Boolean isDragValid); // 0x06035f58
	System.Void OnUpdateFps10(System.Single dt); // 0x06035ffc
	System.Void CheckAutoScroll(System.Single dt); // 0x060360a0
	System.Void Refresh(); // 0x0603654c
	System.Void CheckEmptyToClose(); // 0x060365d4
	System.Void UnChooseAllIcons(); // 0x060366fc
	System.Void OnQuickDropSelectAll(System.Boolean on); // 0x06036774
	System.Void OnQuickLootStateChanged(System.Boolean state); // 0x06036804
	System.Void RefreshDropState(); // 0x06034530
	System.Void OnQuickDropStateChanged(System.Boolean state); // 0x06036894
	System.Void DoAllQuickLoot(); // 0x06036914
	System.Void OnQuickLootFinished(); // 0x0603698c
	System.Boolean ContainItem(System.Int64 id); // 0x06036a98
	WizardGames.Soc.Common.CustomType.ItemContainerNode GetItemContainerNode(); // 0x06036e30
	System.Void ScrollViewToTop(); // 0x06036ee8
	System.Void InitCollectionData(System.Collections.Generic.List<System.Int64> collectionIds); // 0x06034bf0
	System.Void SetCheckPosClose(System.Int64 collectionId); // 0x06036f58
	System.Void CheckDisAndPermission(); // 0x060361f4
	System.Void CheckReloadWin(); // 0x060364bc
	System.Void OnSwitchLootingAck(System.Int64 collectionId, System.Collections.Generic.List<System.Int64> collectionIds); // 0x06037090
	System.Void OnPartContainerLinkUpdate(System.Int64 entityId, System.Int64 oldValue, System.Int64 newValue); // 0x0603716c
	System.Void OnClientGoCreate(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06037354
	System.Void OnClientGoRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06037458
	System.Void .ctor(); // 0x06037704
	System.Void <OnInit>b__39_0(); // 0x06037864
	System.Void <InitScrollTriggers>b__41_0(); // 0x060378c8
	System.Void <InitScrollTriggers>b__41_1(); // 0x06037934
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideNearBy.<>c__DisplayClass47_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiOthersideNearBy <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x06037a64
	System.Void <TabRenderer>b__0(); // 0x06037acc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideNearBy.<>c__DisplayClass49_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiOthersideNearBy <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x06037b44
	System.Void <OnClickNearByTab>b__0(System.Int64 _, System.Object _, System.Boolean _); // 0x06037bac
	System.Void <OnClickNearByTab>b__1(System.Boolean res); // 0x06037c68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideNearByContainer : WizardGames.Soc.SocClient.Ui.UiOthersideNearBy
{
	System.Func<System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.ItemContainerNode>> curContainerSource; // 0x130
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.ItemContainerNode> curContainers; // 0x138
	System.Func<WizardGames.Soc.Common.CustomType.ItemContainerNode,System.String> curConNameProvider; // 0x140
	WizardGames.Soc.Common.CustomType.ItemContainerNode curShowCon; // 0x148
	System.Boolean get_needNewLootWhenChangeTab(); // 0x06037d30
	System.Void SetNearBy(System.Func<System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemGroup>> itemGroupSource, System.Func<System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.ItemContainerNode>> conSource, System.Func<WizardGames.Soc.Common.CustomType.ItemContainerNode,System.String> conNameProvider); // 0x06037d94
	System.Int32 GetColCount(); // 0x06037e50
	System.Void UpdateCurSelectTabIndex(); // 0x06037f58
	System.Int32 GetTabCount(); // 0x06037ff8
	System.Void SetCurContainer(System.Int32 index); // 0x060380ec
	System.Void SetBtnTitle(); // 0x06038220
	WizardGames.Soc.Share.Framework.EntityBase GetCurEntity(System.Int32 curIndex); // 0x060382d0
	System.Void RegisterEvents(); // 0x06038380
	System.Void UnRegisterEvents(); // 0x06038460
	System.Void OnEnable(); // 0x06038540
	System.Void OnDisable(); // 0x060385a8
	System.Void .ctor(); // 0x06038610
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideNearbyInventory : WizardGames.Soc.SocClient.Ui.UiOthersideBase
{
	WizardGames.Soc.SocClient.Ui.IItemIconProvider iconProvider; // 0x30
	FairyGUI.GTextField textMainSize; // 0x38
	FairyGUI.GComponent comMainSpring; // 0x40
	FairyGUI.GButton comTitleBelt; // 0x48
	FairyGUI.GButton comTitleWear; // 0x50
	FairyGUI.GButton comTitleMain; // 0x58
	FairyGUI.GList comMain; // 0x60
	FairyGUI.GList comExtraPack; // 0x68
	FairyGUI.GList comBelt; // 0x70
	FairyGUI.GList comWear; // 0x78
	FairyGUI.Controller ctrlStyle; // 0x80
	WizardGames.Soc.SocClient.Ui.ClientContainerFlexible clientConWeapon; // 0x88
	WizardGames.Soc.SocClient.Ui.ClientContainerFlexible clientConMain; // 0x90
	WizardGames.Soc.SocClient.Ui.ClientContainerFlexible clientConExtraPack; // 0x98
	WizardGames.Soc.SocClient.Ui.ClientContainerFlexible clientConBelt; // 0xa0
	WizardGames.Soc.SocClient.Ui.ClientContainerFlexible clientConWear; // 0xa8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ContainerIndexInfo> listMain; // 0xb0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ContainerIndexInfo> listExtraPack; // 0xb8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ContainerIndexInfo> listWear; // 0xc0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ContainerIndexInfo> listBelt; // 0xc8
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap dataConMain; // 0xd0
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap dataConWear; // 0xd8
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap dataConBelt; // 0xe0
	System.Func<WizardGames.Soc.Share.Framework.EntityBase,System.String> curColNameProvider; // 0xe8
	System.String playerName; // 0xf0
	System.Boolean curIsCorpose; // 0xf8
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.IItemIconProvider provider, System.Func<WizardGames.Soc.Share.Framework.EntityBase,System.String> colNameProvider); // 0x06038678
	System.Void OnInit(); // 0x06038844
	System.Void ClearAlIcons(); // 0x06038e40
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ContainerIndexInfo> GetMainIndexList(); // 0x06038ef8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ContainerIndexInfo> GetExtraPackIndexList(); // 0x06039148
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ContainerIndexInfo> GetWearIndexList(); // 0x060393f8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ContainerIndexInfo> GetBeltIndexList(); // 0x06039674
	System.Void OnCollectIcon(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x060397dc
	System.Void OnSetCommonIcon(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06039aa4
	System.Void OnSetBeltIcon(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06039b54
	System.Void OnSetWearIcon(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06039c14
	System.Boolean OnWearIconAcceptDrag(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x06039e28
	System.Void Refresh(); // 0x0603a204
	System.Void RefreshUiNodes(); // 0x0603ac18
	System.String GetPlayerColName(WizardGames.Soc.Share.Framework.EntityBase col); // 0x0603aa94
	System.Void UnChooseAllIcons(); // 0x0603ae70
	System.Void DoAllQuickLoot(); // 0x0603af2c
	System.Void ScrollContentPane(System.Single offset); // 0x0603b0b4
	System.Boolean IsScrollPaneAtTop(); // 0x0603b300
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideNearbyInventory.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiOthersideNearbyInventory.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__27_0; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.ComBaseIcon,System.Boolean> <>9__33_1; // 0x10
	static System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> <>9__42_0; // 0x18
	static System.Void .cctor(); // 0x0603b40c
	System.Void .ctor(); // 0x0603b470
	System.Void <OnInit>b__27_0(); // 0x0603b4d8
	System.Void <OnCollectIcon>b__33_1(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon, System.Boolean state); // 0x0603b5a4
	System.Void <DoAllQuickLoot>b__42_0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x0603b7b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideNearbyInventory.<>c__DisplayClass33_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	System.Void .ctor(); // 0x06039a3c
	System.Void <OnCollectIcon>b__0(FairyGUI.EventContext ctx); // 0x0603b918
	System.Boolean <OnCollectIcon>b__2(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x0603bc28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideNearbyInventoryNoGroup : WizardGames.Soc.SocClient.Ui.UiOthersideBase
{
	WizardGames.Soc.SocClient.Ui.IItemIconProvider iconProvider; // 0x30
	FairyGUI.GButton comTitleMain; // 0x38
	FairyGUI.GList comMain; // 0x40
	FairyGUI.Controller ctrlStyle; // 0x48
	WizardGames.Soc.SocClient.Ui.ClientContainerFlexible clientConMain; // 0x50
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ContainerIndexInfo> listMain; // 0x58
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap dataConMain; // 0x60
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap dataConWear; // 0x68
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap dataConBelt; // 0x70
	System.Func<WizardGames.Soc.Share.Framework.EntityBase,System.String> curColNameProvider; // 0x78
	System.String playerName; // 0x80
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.IItemIconProvider provider, System.Func<WizardGames.Soc.Share.Framework.EntityBase,System.String> colNameProvider); // 0x0603bd00
	System.Void OnInit(); // 0x0603bdec
	System.Void ClearAlIcons(); // 0x0603c0c8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ContainerIndexInfo> GetMainIndexList(); // 0x0603c140
	System.Void OnCollectIcon(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x0603ca64
	System.Void OnSetCommonIcon(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x0603cd2c
	System.Boolean OnWearIconAcceptDrag(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x0603ce80
	System.Void Refresh(); // 0x0603d25c
	System.Boolean IsEmpty(); // 0x0603d674
	System.String GetPlayerColName(WizardGames.Soc.Share.Framework.EntityBase col); // 0x0603d4f0
	System.Void UnChooseAllIcons(); // 0x0603d71c
	System.Void DoAllQuickLoot(); // 0x0603d788
	System.Void ScrollContentPane(System.Single offset); // 0x0603d8b0
	System.Boolean IsScrollPaneAtTop(); // 0x0603da88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideNearbyInventoryNoGroup.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiOthersideNearbyInventoryNoGroup.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__13_0; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.ComBaseIcon,System.Boolean> <>9__16_1; // 0x10
	static System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> <>9__23_0; // 0x18
	static System.Void .cctor(); // 0x0603db94
	System.Void .ctor(); // 0x0603dbf8
	System.Void <OnInit>b__13_0(); // 0x0603dc60
	System.Void <OnCollectIcon>b__16_1(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon, System.Boolean state); // 0x0603dd2c
	System.Void <DoAllQuickLoot>b__23_0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x0603df3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideNearbyInventoryNoGroup.<>c__DisplayClass16_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	System.Void .ctor(); // 0x0603ccc4
	System.Void <OnCollectIcon>b__0(FairyGUI.EventContext ctx); // 0x0603e0a0
	System.Boolean <OnCollectIcon>b__2(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x0603e3b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ItemGroup : System.Object
{
	System.String Name; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> Items; // 0x18
	System.Void .ctor(); // 0x0603e488
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideNearbyStorage : WizardGames.Soc.SocClient.Ui.UiOthersideBase
{
	System.Int32 columnCount; // 0x30
	WizardGames.Soc.SocClient.Ui.IItemIconProvider iconProvider; // 0x38
	FairyGUI.GList listContent; // 0x40
	FairyGUI.GObject objDisableMask; // 0x48
	System.Int64 curChooseItemUid; // 0x50
	WizardGames.Soc.SocClient.Ui.ComItemIcon curChooseIcon; // 0x58
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap curContainer; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap> curContainerList; // 0x68
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiOthersideNearbyStorage.RowInfo> curRowList; // 0x70
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.ExtraPackItemNode> curExtraPacks; // 0x78
	System.Int32 lastExtraPackSubItemCount; // 0x80
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> curItemList; // 0x88
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.ComItemIcon> curAllIcons; // 0x90
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComItemIcon> iconsToRemove; // 0x98
	System.Func<System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemGroup>> itemGroupSource; // 0xa0
	System.Boolean NeedClearIconsToRemove; // 0xa8
	static System.Single LISTITEM_TITLE_HEIGHT; // 0x0
	static System.Single LISTITEM_LIST_HEIGHT; // 0x4
	WizardGames.Soc.SocClient.Ui.UiOthersideNearBy othersideNearBy; // 0xb0
	System.Boolean needGetContainerByIndex; // 0xb8
	System.Boolean get_HasBindContainer(); // 0x0603e4f0
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.IItemIconProvider privoder, WizardGames.Soc.SocClient.Ui.UiOthersideNearBy othersideNearBy); // 0x0603e55c
	System.Void OnInit(); // 0x0603e768
	System.Void CaculateItemSizeOnInit(); // 0x0603ea6c
	System.Void OnDisable(); // 0x0603ecb4
	System.Void OnUpdateFps10(System.Single dt); // 0x0603f0b0
	System.Void Refresh(); // 0x0603f2ac
	WizardGames.Soc.SocClient.Ui.UiOthersideNearbyStorage.RowInfo CheckAndGetRow(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiOthersideNearbyStorage.RowInfo> rows, System.String titleName); // 0x0603faf8
	System.Int32 FillEmptyToRowInfos(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiOthersideNearbyStorage.RowInfo> oriRows); // 0x0603fe14
	System.Int32 GenerateRowInfos(System.Boolean fillEmpty, System.String name); // 0x06040634
	System.Int32 GenerateRowInfosForAllContainers(System.Boolean fillEmpty); // 0x06040f4c
	System.Void ReturnItemIcon(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06041904
	System.Void IncreaseIconListToCount(FairyGUI.GList listIcon, System.Int32 tarCount); // 0x06041a3c
	System.Void ClearAllIcons(); // 0x0603ede0
	System.Void ClearChooseInfo(); // 0x0603f028
	System.Void SetAsLootContainer(); // 0x0603f5dc
	System.Void SetAsItemGroupList(); // 0x0603f330
	System.Void SetIconOnRowRenderer(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06041ba0
	System.Void ListRowRenderer(System.Int32 index, FairyGUI.GObject rowNode); // 0x06042200
	System.Void UnChooseAllIcons(); // 0x06042eb4
	System.Void OnClickItemIcon(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x06042f80
	System.Void OnQuickDropSelectAll(System.Boolean on); // 0x060434ac
	System.Void OnQuickLootStateChanged(System.Boolean state); // 0x06043db0
	System.Void OnQuickDropStateChanged(System.Boolean state); // 0x06043f2c
	System.Void SortDropItemQuickLootList(System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> itemsOri, System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>& itemsToLoot); // 0x06043948
	System.Void DoAllQuickLoot(); // 0x060440bc
	System.Void ScrollContentPane(System.Single offset); // 0x0604456c
	System.Boolean IsScrollPaneAtTop(); // 0x060446b4
	System.Boolean IsEmpty(); // 0x060447c0
	WizardGames.Soc.SocClient.Ui.ComItemIcon ScrollAndGetIconOfIndex(System.Int32 index); // 0x06044848
	WizardGames.Soc.SocClient.Ui.ComItemIcon GetItemIcon(System.Int64 itemId, System.Boolean scrollToItem); // 0x06044984
	System.Void ScrollViewToTop(); // 0x06044d24
	System.String GetOthersideCapacity(); // 0x06044da4
	static System.Void .cctor(); // 0x06044f2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideNearbyStorage.RowInfo : System.Object
{
	System.String TitleName; // 0x10
	System.Boolean isBlackTitle; // 0x18
	System.Int32 curVolume; // 0x1c
	System.Int32 maxVolume; // 0x20
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap Container; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> Items; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComItemIcon> icons; // 0x38
	System.Collections.Generic.List<System.Int32> Indexs; // 0x40
	System.Boolean get_HasValidData(); // 0x06040328
	System.Int32 get_Count(); // 0x0603fd08
	System.Void AppendItem(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x060403ac
	System.Void AppendIcon(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06042d6c
	System.Void AppendIndex(System.Int32 index); // 0x060404f4
	System.Void .ctor(); // 0x0603fda4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideNearbyStorage.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiOthersideNearbyStorage.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__26_0; // 0x8
	static FairyGUI.EventCallback0 <>9__26_1; // 0x10
	static System.Action<WizardGames.Soc.SocClient.Ui.ComBaseIcon,System.Boolean> <>9__42_0; // 0x18
	static System.Void .cctor(); // 0x06044f78
	System.Void .ctor(); // 0x06044fdc
	System.Void <OnInit>b__26_0(); // 0x06045044
	System.Void <OnInit>b__26_1(); // 0x06045110
	System.Void <SetIconOnRowRenderer>b__42_0(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon, System.Boolean state); // 0x06045220
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideNearbyStorage.<>c__DisplayClass42_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	System.Void .ctor(); // 0x06042198
	System.Void <SetIconOnRowRenderer>b__1(FairyGUI.EventContext ctx); // 0x06045430
	System.Void <SetIconOnRowRenderer>b__2(FairyGUI.EventContext ctx); // 0x06045674
	System.Boolean <SetIconOnRowRenderer>b__3(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x060456fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideNearbyStorage.<>c__DisplayClass46_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MgrQuickLoot mgrLoot; // 0x10
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.CustomType.BaseItemNode,WizardGames.Soc.SocClient.Ui.ComItemIcon> item2Icon; // 0x18
	WizardGames.Soc.SocClient.Ui.ComItemIcon lastIcon; // 0x20
	System.Void .ctor(); // 0x060438e0
	System.Void <OnQuickDropSelectAll>b__0(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x06045880
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideNearbyStorage.<>c__DisplayClass50_0 : System.Object
{
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.CustomType.BaseItemNode,WizardGames.Soc.SocClient.Ui.ComItemIcon> item2Icon; // 0x10
	WizardGames.Soc.SocClient.Ui.ComItemIcon lastIcon; // 0x18
	System.Void .ctor(); // 0x06044504
	System.Void <DoAllQuickLoot>b__0(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x060459c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideNearByStorageDebris : WizardGames.Soc.SocClient.Ui.UiOthersideNearBy
{
	FairyGUI.GTextField destroyTitle; // 0x130
	System.Void OnEnable(); // 0x06045b2c
	System.String GetBtnTips(); // 0x06045bf4
	System.Boolean HaveDestroyTip(FairyGUI.GTextField textField); // 0x06045c84
	System.Void OnUpdateFps30(System.Single dt); // 0x06045d0c
	System.Void SetDestroyTime(); // 0x06045d84
	System.Void .ctor(); // 0x06046018
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideBase : System.Object
{
	System.Boolean inited; // 0x10
	FairyGUI.GComponent root; // 0x18
	System.Boolean registerEvents; // 0x20
	System.Int64 EntityId; // 0x28
	FairyGUI.GComponent get_Root(); // 0x06046080
	System.Void Bind(FairyGUI.GComponent node); // 0x060460e4
	System.Void Show(System.Int64 targetCollectionId); // 0x06046164
	System.Void Hide(); // 0x0604623c
	System.Void OnInit(); // 0x06038de0
	System.Void RegisterEvents(); // 0x060462c8
	System.Void UnRegisterEvents(); // 0x06046328
	System.Void OnEnable(); // 0x06046388
	System.Void RefreshInfoByTargetEntity(System.Int64 targetEntityId); // 0x060463ec
	System.Void OnDisable(); // 0x0603ed64
	System.Void OnUpdateFps30(System.Single dt); // 0x06046464
	System.Void OnUpdateFps10(System.Single dt); // 0x060464d8
	System.Void Refresh(); // 0x0603a940
	System.Void UnChooseAllIcons(); // 0x06042f20
	System.Void OnQuickLootStateChanged(System.Boolean state); // 0x0604654c
	System.Void OnQuickDropStateChanged(System.Boolean state); // 0x060465c0
	System.Void DoAllQuickLoot(); // 0x06046634
	System.Void OnClickBack(); // 0x06046694
	System.Void OnQuickLootFinished(); // 0x060466f4
	System.Void OnQuickDropSelectAll(System.Boolean on); // 0x06046754
	System.Void OnIconDragStart(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x060467c8
	System.Void OnIconDragEnd(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem, System.Boolean isDragValid); // 0x0604683c
	System.Void OnIconClick(WizardGames.Soc.SocClient.Ui.ComItemIcon clickIcon); // 0x060468b8
	System.Void ScrollContentPane(System.Single pos); // 0x0603b28c
	System.Boolean IsScrollPaneAtTop(); // 0x0604692c
	System.Boolean CanDoubleClickToMove(); // 0x06046990
	System.Boolean IsEmpty(); // 0x060469f4
	System.Boolean ContainItem(System.Int64 id); // 0x06046a58
	WizardGames.Soc.SocClient.Ui.ComItemIcon SetOtherHightLight(System.Int32 tarIndex, System.Boolean on); // 0x06046ad0
	WizardGames.Soc.SocClient.Ui.ComItemIcon GetItemIcon(System.Int64 itemId, System.Boolean scrollToItem); // 0x06046b50
	WizardGames.Soc.Common.CustomType.ItemContainerNode GetItemContainerNode(); // 0x06046bd0
	System.Void ScrollViewToTop(); // 0x06046c34
	System.Void RefreshOtherSideName(); // 0x06046c94
	System.String GetOthersideCapacity(); // 0x06046cf4
	System.Void .ctor(); // 0x060387dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOtherSideRepairBenchNew : WizardGames.Soc.SocClient.Ui.UiOthersideBase
{
	static SocLogger logger; // 0x0
	FairyGUI.GTextField itemTips; // 0x30
	FairyGUI.GButton repairBtn; // 0x38
	FairyGUI.GButton dressBtn; // 0x40
	FairyGUI.GComponent touchAgent; // 0x48
	WizardGames.Soc.SocClient.Ui.ComItemIcon containerItemIcon; // 0x50
	FairyGUI.GImage containerItemIconDefault; // 0x58
	FairyGUI.GGraph containerItemIconBgDefault; // 0x60
	FairyGUI.GComponent comIngredient; // 0x68
	FairyGUI.GList ingredientList; // 0x70
	FairyGUI.GComponent comErrorTips; // 0x78
	FairyGUI.GTextField errorTips; // 0x80
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> needgredientCountDic; // 0x88
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiOtherSideRepairBenchNew.NeedGredientData> needIngredientList; // 0x90
	WizardGames.Soc.Common.CustomType.BaseItemNode containerItem; // 0x98
	System.Single orgContainerItemCdtion; // 0xa0
	System.Boolean hasEnoughInGredient; // 0xa4
	System.String errorContent; // 0xa8
	System.Int32 tipId; // 0xb0
	System.Void OnInit(); // 0x06046d58
	System.Void RegisterEvents(); // 0x06047758
	System.Void UnRegisterEvents(); // 0x06047850
	System.Void OnEnable(); // 0x06047948
	System.Void OnDisable(); // 0x06047df0
	System.Void Refresh(); // 0x06047f4c
	System.Void RepairBenchContainerChange(); // 0x06048214
	System.Boolean OnIconAcceptDrag(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x060483f8
	WizardGames.Soc.Common.CustomType.BaseItemNode GetContainerItem(); // 0x06047b40
	System.Void UpdateLocalContainerItem(WizardGames.Soc.Common.CustomType.BaseItemNode containerItem); // 0x060476a8
	System.Void CheckContainerItemState(); // 0x06048564
	System.Void OnRepairBtnClick(); // 0x06049290
	System.Void OnDressBtnClick(); // 0x0604964c
	System.Void OnIngredientItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x0604978c
	System.Void .ctor(); // 0x06049a88
	static System.Void .cctor(); // 0x06049b98
	System.Void <OnInit>b__20_0(FairyGUI.EventContext ctx); // 0x06049c6c
	System.Void <OnInit>b__20_1(FairyGUI.EventContext ctx); // 0x06049d0c
	System.Void <OnInit>b__20_2(FairyGUI.EventContext ctx); // 0x06049dac
	System.Void <OnInit>b__20_3(FairyGUI.EventContext ctx); // 0x06049e4c
	System.Void <OnInit>b__20_4(FairyGUI.EventContext ctx); // 0x06049eec
	System.Void <OnInit>b__20_5(); // 0x06049fec
	System.Void <OnInit>b__20_6(); // 0x0604a050
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiOtherSideRepairBenchNew.NeedGredientData : System.ValueType
{
	System.Int32 templateId; // 0x10
	System.Int32 ownedCount; // 0x14
	System.Int32 needCount; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SafetyBoxRowInfo : System.Object
{
	System.Boolean isTitle; // 0x10
	System.Int32 maxCount; // 0x14
	WizardGames.Soc.SocClient.Ui.ESafeBoxtyTitleType type; // 0x18
	System.String title; // 0x20
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container; // 0x28
	System.Collections.Generic.List<System.Int32> itemIndexs; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComItemIcon> icons; // 0x38
	System.Void .ctor(); // 0x0604a0b4
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.ESafeBoxtyTitleType type, System.Int32 maxCount); // 0x0604a1c8
	System.String GetTitle(); // 0x0604a314
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ESafeBoxtyTitleType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ESafeBoxtyTitleType None = 0;
	static WizardGames.Soc.SocClient.Ui.ESafeBoxtyTitleType Weapon = 1;
	static WizardGames.Soc.SocClient.Ui.ESafeBoxtyTitleType Belt = 2;
	static WizardGames.Soc.SocClient.Ui.ESafeBoxtyTitleType Universe = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBeta1SafeBox : WizardGames.Soc.SocClient.Ui.UiOthersideBase
{
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.ItemContainerNode> itemContainerNodes; // 0x30
	FairyGUI.Controller openState; // 0x38
	FairyGUI.GList list; // 0x40
	FairyGUI.GComponent rightTab; // 0x48
	System.Collections.Generic.Dictionary<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.ESafeBoxtyTitleType> tabDic; // 0x50
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SafetyBoxRowInfo> dataList; // 0x58
	System.Int32 rowCount; // 0x60
	System.Single titleHeight2; // 0x64
	System.Single itemHeight; // 0x68
	System.Single titleHeight; // 0x6c
	System.Single lineHeight; // 0x70
	System.Collections.Generic.Dictionary<System.Int32,System.Single> itemHeights; // 0x78
	WizardGames.Soc.SocClient.Ui.ESafeBoxtyTitleType curType; // 0x80
	WizardGames.Soc.SocClient.Ui.ComItemIcon curChooseIcon; // 0x88
	System.Boolean isDraging; // 0x90
	WizardGames.Soc.Common.CustomType.BaseItemNode dragingItem; // 0x98
	WizardGames.Soc.Common.CustomType.ItemContainerNode targetContainerNode; // 0xa0
	System.Void OnInit(); // 0x0604a42c
	System.Void OnEnable(); // 0x0604aad4
	System.Void OnDisable(); // 0x0604acd4
	System.Void RegisterEvents(); // 0x0604addc
	System.Void UnRegisterEvents(); // 0x0604b020
	System.Void ScrollViewToTop(); // 0x0604b264
	System.Void RefreshData(); // 0x0604b52c
	System.Void AddNodeRowDataNotLooting(WizardGames.Soc.SocClient.Ui.ESafeBoxtyTitleType titleType, System.Int32 configId); // 0x0604b6e4
	System.Void AddNodeRowData(WizardGames.Soc.SocClient.Ui.ESafeBoxtyTitleType titleType, System.Int32 nodeIndex); // 0x0604ba3c
	System.Void JumpToType(WizardGames.Soc.SocClient.Ui.ESafeBoxtyTitleType type); // 0x0604bddc
	System.Int32 FindIndex(WizardGames.Soc.SocClient.Ui.ESafeBoxtyTitleType type); // 0x0604bee4
	System.Void SelectTab(WizardGames.Soc.SocClient.Ui.ESafeBoxtyTitleType selectedType); // 0x0604b2f4
	System.Void OnScroll(FairyGUI.EventContext context); // 0x0604bfc4
	System.Void RenderList(System.Int32 index, FairyGUI.GObject obj); // 0x0604c1b8
	System.Void SetIconDarkState(WizardGames.Soc.SocClient.Ui.SafetyBoxRowInfo data, WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x0604cc58
	System.Single CollectLastOneAddHeight(); // 0x0604cda8
	System.Void CheckItemIconListControl(WizardGames.Soc.SocClient.Ui.SafetyBoxRowInfo data, FairyGUI.GList listMain); // 0x0604ca80
	System.Void OnClickItemIcon(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x0604d024
	System.Void CalculateItemHeights(); // 0x0604cee4
	System.Void DealIconWhenCollect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x0604d668
	System.Void SetTitle(FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOtherSideSafeBoxItemBinder binder, WizardGames.Soc.SocClient.Ui.SafetyBoxRowInfo data); // 0x0604c6bc
	System.Void RefreshTeammate(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x0604d93c
	System.Void RefreshPermissionChange(); // 0x0604d9d0
	System.Void Refresh(); // 0x0604dd44
	System.Void ReLoadListData(); // 0x0604ddbc
	System.Void UnChooseAllIcons(); // 0x0604de9c
	System.Void InitData(); // 0x0604df28
	System.Void OnIconDragStart(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x0604e02c
	System.Boolean CheckCanBePutIn(WizardGames.Soc.Common.CustomType.ItemContainerNode bindNode, WizardGames.Soc.Common.CustomType.BaseItemNode item, System.Boolean& exChange); // 0x0604e224
	System.Void OnIconClick(WizardGames.Soc.SocClient.Ui.ComItemIcon dragIcon); // 0x0604e3ac
	System.Void OnIconDragEnd(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem, System.Boolean isDragValid); // 0x0604e420
	WizardGames.Soc.Common.CustomType.ItemContainerNode GetItemContainerNode(); // 0x0604e4d8
	WizardGames.Soc.SocClient.Ui.ComItemIcon SetOtherHightLight(System.Int32 tarIndex, System.Boolean on); // 0x0604e53c
	WizardGames.Soc.SocClient.Ui.ComItemIcon GetItemIcon(System.Int64 itemId, System.Boolean scrollToItem); // 0x0604e7f4
	WizardGames.Soc.SocClient.Ui.ComItemIcon ScrollAndGetIconOfIndex(System.Int32 index); // 0x0604e5e0
	System.Void DoAllQuickLoot(); // 0x0604eaf4
	System.Void OnQuickLootFinished(); // 0x0604ef7c
	System.Void OnQuickLootStateChanged(System.Boolean state); // 0x0604f030
	System.Void OnQuickDropSelectAll(System.Boolean on); // 0x0604f0fc
	System.Void .ctor(); // 0x0604f468
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBeta1SafeBox.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiBeta1SafeBox.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ComBaseIcon,System.Boolean> <>9__34_0; // 0x8
	static System.Void .cctor(); // 0x0604f630
	System.Void .ctor(); // 0x0604f694
	System.Void <DealIconWhenCollect>b__34_0(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, System.Boolean state); // 0x0604f6fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBeta1SafeBox.<>c__DisplayClass13_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ESafeBoxtyTitleType type; // 0x10
	WizardGames.Soc.SocClient.Ui.UiBeta1SafeBox <>4__this; // 0x18
	System.Void .ctor(); // 0x0604aa6c
	System.Void <OnInit>b__0(FairyGUI.EventContext ctx); // 0x0604f90c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBeta1SafeBox.<>c__DisplayClass34_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	System.Void .ctor(); // 0x0604d8d4
	System.Void <DealIconWhenCollect>b__1(FairyGUI.EventContext ctx); // 0x0604f990
	System.Void <DealIconWhenCollect>b__2(FairyGUI.EventContext ctx); // 0x0604fc98
	System.Boolean <DealIconWhenCollect>b__3(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x0604fd20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBeta1TempCofferSafeBox : WizardGames.Soc.SocClient.Ui.UiBeta1SafeBox
{
	WizardGames.Soc.SocClient.Ui.ComStateBtn btnTakeAll; // 0xa8
	WizardGames.Soc.SocClient.Ui.UiInventoryOtherside uiInventory; // 0xb0
	FairyGUI.GObject cdIcon; // 0xb8
	FairyGUI.GTextField textCountDown; // 0xc0
	System.Int64 timerID; // 0xc8
	System.Void OnInit(); // 0x0604fdf8
	System.Void OnEnable(); // 0x06050118
	System.Void OnDisable(); // 0x060503d4
	System.Void CancelTick(); // 0x06050570
	System.Void OnStartLootingBack(System.Int64 cabinetId); // 0x06050674
	System.Void OnClickBtn(); // 0x0605075c
	System.Void Refresh(); // 0x06050c08
	System.Void InitData(); // 0x06051270
	System.Void SafeBoxStateRefresh(); // 0x06051388
	System.Void RefreshBtnState(); // 0x055049cc
	System.Void Tick(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x06051568
	System.Void DestroySafeBox(); // 0x06050830
	System.Void DealIconWhenCollect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x060516cc
	System.Boolean OnIconAcceptDrag(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x060517a4
	System.Boolean CheckCanBePutIn(WizardGames.Soc.Common.CustomType.ItemContainerNode bindNode, WizardGames.Soc.Common.CustomType.BaseItemNode item, System.Boolean& exChange); // 0x06051954
	System.Void CheckSafeBoxEmptyTrigger(); // 0x060510b8
	System.Void OnQuickLootFinished(); // 0x060519ec
	System.Void OnQuickLootStateChanged(System.Boolean state); // 0x06051a68
	System.Void .ctor(); // 0x06051b00
	System.Void <OnInit>b__7_0(FairyGUI.EventContext ctx); // 0x06051b64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBeta1TempCofferSafeBox.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiBeta1TempCofferSafeBox.<>c <>9; // 0x0
	static System.Action <>9__18_0; // 0x8
	static System.Void .cctor(); // 0x06051bdc
	System.Void .ctor(); // 0x06051c40
	System.Void <DestroySafeBox>b__18_0(); // 0x06051ca8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideSafeBox : WizardGames.Soc.SocClient.Ui.UiOthersideBase
{
	static System.Int64 PartEntityId; // 0x0
	static System.Boolean IsInSafeBox; // 0x8
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideToolCupboard : WizardGames.Soc.SocClient.Ui.UiOthersideBase
{
	static SocLogger logger; // 0x0
	FairyGUI.GList listMain; // 0x30
	FairyGUI.GComponent infoGreen; // 0x38
	FairyGUI.GComponent infoRed; // 0x40
	WizardGames.Soc.SocClient.Ui.ClientContainerFixed containerMain; // 0x48
	WizardGames.Soc.Common.CustomType.ItemContainerNode lootMain; // 0x50
	FairyGUI.GList listItemCost; // 0x58
	FairyGUI.GButton btnBatchRecover; // 0x60
	FairyGUI.GButton btnPermission; // 0x68
	FairyGUI.GButton btnBatchUpgrade; // 0x70
	WizardGames.Soc.SocClient.Ui.UiInventoryOtherside inventory; // 0x78
	FairyGUI.GButton btnOthersideBatchMoveNew; // 0x80
	FairyGUI.GButton btnOthersidePutInAllNew; // 0x88
	FairyGUI.GButton btnOthersideBatchDropNew; // 0x90
	FairyGUI.GButton btnOthersideOrganizeNew; // 0x98
	FairyGUI.GButton btnAllQuickLootNew; // 0xa0
	System.Void OnInit(); // 0x06051d54
	System.Void OnClickPopGuide(); // 0x06052104
	System.Void InitToolBar(); // 0x060521a4
	System.Boolean HasPermission(); // 0x06052810
	System.Void IconProcess(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06052bc8
	System.Void OnEnable(); // 0x06052e84
	System.Void RegisterEvents(); // 0x0605307c
	System.Void UnRegisterEvents(); // 0x060531f8
	System.Void RefreshInfoByTargetEntity(System.Int64 targetEntityId); // 0x06053374
	System.Void OnShowUpKeepInfo(System.Single upkeepTime, System.Collections.Generic.Dictionary<System.Int64,System.Int32> itemCost, System.Int64 entityId); // 0x0605389c
	System.Int32[] ConvertMinuteToDate(System.Single upKeepMinute); // 0x06053f9c
	System.Void OnDisable(); // 0x06054174
	System.Void Refresh(); // 0x0605420c
	System.Void FetchCostInfo(); // 0x06054350
	System.Void UnChooseAllIcons(); // 0x060543b0
	System.Void DoAllQuickLoot(); // 0x0605441c
	System.Void OnQuickLootFinished(); // 0x06054544
	System.Void OnQuickLootStateChanged(System.Boolean state); // 0x06054618
	System.Void OnQuickDropStateChanged(System.Boolean state); // 0x0605471c
	System.Void .ctor(); // 0x06054808
	static System.Void .cctor(); // 0x0605486c
	System.Void <OnInit>b__19_0(); // 0x06054940
	System.Void <OnInit>b__19_1(); // 0x060549a4
	System.Void <InitToolBar>b__21_0(FairyGUI.EventContext ctx); // 0x06054ac4
	System.Void <InitToolBar>b__21_1(FairyGUI.EventContext ctx); // 0x06054bb4
	System.Void <InitToolBar>b__21_2(FairyGUI.EventContext ctx); // 0x06054cc0
	System.Void <InitToolBar>b__21_3(FairyGUI.EventContext ctx); // 0x06054ddc
	System.Void <InitToolBar>b__21_4(FairyGUI.EventContext ctx); // 0x06054f3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideToolCupboard.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiOthersideToolCupboard.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ComBaseIcon,System.Boolean> <>9__23_1; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> <>9__36_0; // 0x10
	static System.Void .cctor(); // 0x0605504c
	System.Void .ctor(); // 0x060550b0
	System.Void <IconProcess>b__23_1(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon, System.Boolean state); // 0x06055118
	System.Void <DoAllQuickLoot>b__36_0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06055328
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideToolCupboard.<>c__DisplayClass23_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	System.Void .ctor(); // 0x06052e1c
	System.Void <IconProcess>b__0(FairyGUI.EventContext ctx); // 0x0605548c
	System.Boolean <IconProcess>b__2(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x0605579c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideToolCupboard.<>c__DisplayClass27_0 : System.Object
{
	WizardGames.Soc.Common.Entity.PartEntity targetPartEntity; // 0x10
	WizardGames.Soc.SocClient.Ui.UiOthersideToolCupboard <>4__this; // 0x18
	System.Void .ctor(); // 0x06053834
	System.Void <RefreshInfoByTargetEntity>b__1(); // 0x06055874
	System.Void <RefreshInfoByTargetEntity>b__0(); // 0x060558dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryOtherside : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiTriggerGuide, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.Common.Unity.Ui.IUiStopLooting
{
	FairyGUI.Controller ctrlBacStyle; // 0x338
	WizardGames.Soc.SocClient.Ui.UiInventoryOthersidePanel panel; // 0x340
	System.Boolean DontStopLootWhenClose; // 0x348
	static System.Boolean <IsOpen>k__BackingField; // 0x0
	static System.Boolean <OpenFromPickList>k__BackingField; // 0x1
	FairyGUI.GLoader gLoaderBg; // 0x350
	FairyGUI.GObject gBlockBg; // 0x358
	FairyGUI.GComponent content; // 0x360
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x368
	WizardGames.Soc.SocClient.Manager.UiConstructionPreviewSceneController uiPreviewSceneController; // 0x370
	System.Boolean UsePreview; // 0x378
	System.Int64 curColId; // 0x380
	WizardGames.Soc.SocClient.Ui.UiInventoryOthersideContainers get_ContainerOtherside(); // 0x06055948
	static System.Boolean get_IsOpen(); // 0x060559b8
	static System.Void set_IsOpen(System.Boolean value); // 0x06055a30
	static System.Boolean get_OpenFromPickList(); // 0x06055ab4
	static System.Void set_OpenFromPickList(System.Boolean value); // 0x06055b2c
	System.Void OnInit(); // 0x06055bb0
	System.Void OnEnable(); // 0x060565f4
	System.Void OnHideByLayerStack(System.String coverUiName); // 0x060567ec
	System.Void OnShowByLayerStack(); // 0x06056888
	System.Void ClosePanel(); // 0x06056918
	System.Void OnDisable(); // 0x0605697c
	System.Void OnDestroy(); // 0x06056d2c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06056dcc
	System.Void OnClickBack(System.Boolean immediately); // 0x06056e48
	System.Void ShowOtherSideAnim(System.Boolean isOn); // 0x06053008
	System.Void OnFps30Update(System.Single dt); // 0x06056f98
	System.Void OnFps10Update(System.Single dt); // 0x06057020
	System.Void SetCondFilter(System.Func<WizardGames.Soc.Common.Data.DataItem.ItemConfig,System.Boolean> condFilter, System.Boolean disableDarkIcons); // 0x060570a8
	System.Void SetCondItemNodeFilter(System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> condItemNodeFilter, System.Boolean disableDarkIcons); // 0x0605713c
	System.Void SetCondItemNodeShowFilter(System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> condItemNodeShowFilter, System.Boolean defauleSelect, System.Boolean toggleShowState); // 0x060571d0
	System.Void ForeachIcon(System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> process); // 0x0605727c
	System.Void SetProcessCallback(System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> process); // 0x06057304
	System.Void OnStartLootingAck(System.Int64 colId); // 0x0605738c
	System.Void SetBacWithOthersideTtpe(WizardGames.Soc.SocClient.Ui.UiOthersideType mode); // 0x06057414
	static System.Void OpenAsTempSafeBox(WizardGames.Soc.SocClient.Ui.UiOthersideType mode, System.Int64 collectionID, System.Action<System.Int64> onClose); // 0x0605751c
	static System.Void OpenAsOtherside(WizardGames.Soc.SocClient.Ui.UiOthersideType mode, System.Int64 collectionID, System.Action<System.Int64> onClose, System.Boolean isFromDetailList); // 0x06057720
	static System.Void OpenAsMulitOtherside(WizardGames.Soc.SocClient.Ui.UiOthersideType mode, System.Int64 collectionID, System.Int32 uiType, System.Action<System.Int64> onClose); // 0x060579e8
	static System.Void OpenAsOtherside(System.Func<System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemGroup>> itemGroupSource, WizardGames.Soc.SocClient.Ui.UiOthersideType othersideType, System.Func<System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.ItemContainerNode>> conSource, System.Func<WizardGames.Soc.Common.CustomType.ItemContainerNode,System.String> conNameProvider, System.Action onClose, System.Boolean dontStopLootWhenClose); // 0x06057c14
	static System.Void OpenAsOtherside(System.Func<System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemGroup>> itemGroupSource, System.Func<System.Collections.Generic.List<WizardGames.Soc.Share.Framework.EntityBase>> colSource, System.Func<WizardGames.Soc.Share.Framework.EntityBase,System.String> colNameProvider, System.Action onClose); // 0x06057e60
	static System.Void OpenAsOthersideInLooting(WizardGames.Soc.SocClient.Ui.UiOthersideType mode, System.Int64 collectionID, System.Action<System.Int64> onClose); // 0x06058084
	static System.Void CloseInventory(System.Boolean immediately); // 0x0603a9a0
	System.Boolean TriggerGuide(); // 0x060582a0
	System.Void StopLooting(); // 0x060584f0
	System.Void OnClickSort(); // 0x06054b44
	System.Void OnClickPutInAll(FairyGUI.GButton btn, System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> func); // 0x06054d48
	System.Void SetNewToolCupBoardType(System.Boolean isShow, System.String title); // 0x06047d38
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x06058624
	System.Void SetHelpState(System.Boolean isShow, FairyGUI.EventCallback0 callback, System.Int32 manualId); // 0x0605030c
	System.Void OnClickAllQuickLoot(System.Boolean v); // 0x06054c38
	System.Void OnClickOthersideBatchMove(System.Boolean selected); // 0x06054eb4
	System.Void InitPreviewScene(System.Boolean usePreview, System.Int64 colId, WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase, System.Boolean havePlayer, System.Boolean isFromDetailList); // 0x060586ac
	System.Void ChangePreviewScene(System.Int64 entityId); // 0x06058988
	System.Void DisposePreviewScene(System.Boolean isForceDispose); // 0x06056c30
	WizardGames.Soc.SocClient.Manager.EPreviewType GetPreviewType(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x060588e0
	System.Void CheckLockState(UnityEngine.GameObject goModel, WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06058b40
	System.Void .ctor(); // 0x06058e90
	System.Void <OnInit>b__18_3(FairyGUI.EventContext context); // 0x06058f1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryOtherside.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiInventoryOtherside.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__18_4; // 0x8
	static FairyGUI.EventCallback1 <>9__18_5; // 0x10
	static FairyGUI.EventCallback0 <>9__18_0; // 0x18
	static FairyGUI.EventCallback0 <>9__18_1; // 0x20
	static FairyGUI.EventCallback0 <>9__18_2; // 0x28
	static System.Void .cctor(); // 0x06059068
	System.Void .ctor(); // 0x060590cc
	System.Void <OnInit>b__18_4(FairyGUI.EventContext context); // 0x06059134
	System.Void <OnInit>b__18_5(FairyGUI.EventContext context); // 0x06059234
	System.Void <OnInit>b__18_0(); // 0x06059334
	System.Void <OnInit>b__18_1(); // 0x060593d4
	System.Void <OnInit>b__18_2(); // 0x060594a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryOtherside.<>c__DisplayClass37_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiOthersideType mode; // 0x10
	System.Int64 collectionID; // 0x18
	System.Action<System.Int64> onClose; // 0x20
	System.Action <>9__1; // 0x28
	System.Void .ctor(); // 0x0605956c
	System.Void <OpenAsTempSafeBox>b__0(WizardGames.Soc.SocClient.Ui.UiInventoryOtherside win); // 0x060595d4
	System.Void <OpenAsTempSafeBox>b__1(); // 0x0605a100
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryOtherside.<>c__DisplayClass38_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiOthersideType mode; // 0x10
	System.Int64 collectionID; // 0x18
	System.Boolean isFromDetailList; // 0x20
	System.Action<System.Int64> onClose; // 0x28
	System.Action <>9__2; // 0x30
	System.Action<WizardGames.Soc.SocClient.Ui.UiInventoryOtherside> <>9__1; // 0x38
	System.Void .ctor(); // 0x0605a184
	System.Void <OpenAsOtherside>b__0(System.Boolean res); // 0x0605a1ec
	System.Void <OpenAsOtherside>b__1(WizardGames.Soc.SocClient.Ui.UiInventoryOtherside win); // 0x0605a354
	System.Void <OpenAsOtherside>b__2(); // 0x0605a600
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryOtherside.<>c__DisplayClass39_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiOthersideType mode; // 0x10
	System.Action<System.Int64> onClose; // 0x18
	System.Void .ctor(); // 0x0605a684
	System.Void <OpenAsMulitOtherside>b__0(System.Int64 collectionId, System.Collections.Generic.List<System.Int64> collectionIds); // 0x0605a6ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryOtherside.<>c__DisplayClass39_1 : System.Object
{
	System.Boolean b; // 0x10
	System.Int64 collectionId; // 0x18
	System.Collections.Generic.List<System.Int64> collectionIds; // 0x20
	WizardGames.Soc.SocClient.Ui.UiInventoryOtherside.<>c__DisplayClass39_0 CS$<>8__locals1; // 0x28
	System.Action <>9__2; // 0x30
	System.Void .ctor(); // 0x0605a880
	System.Void <OpenAsMulitOtherside>b__1(WizardGames.Soc.SocClient.Ui.UiInventoryOtherside win); // 0x0605a8e8
	System.Void <OpenAsMulitOtherside>b__2(); // 0x0605b274
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryOtherside.<>c__DisplayClass39_2 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiInventoryOtherside win; // 0x10
	WizardGames.Soc.SocClient.Ui.UiInventoryOtherside.<>c__DisplayClass39_1 CS$<>8__locals2; // 0x18
	System.Void .ctor(); // 0x0605ad70
	System.Void <OpenAsMulitOtherside>b__3(); // 0x0605b304
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryOtherside.<>c__DisplayClass40_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiOthersideType othersideType; // 0x10
	System.Func<System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemGroup>> itemGroupSource; // 0x18
	System.Func<System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.ItemContainerNode>> conSource; // 0x20
	System.Func<WizardGames.Soc.Common.CustomType.ItemContainerNode,System.String> conNameProvider; // 0x28
	System.Action onClose; // 0x30
	System.Boolean dontStopLootWhenClose; // 0x38
	System.Void .ctor(); // 0x0605b3ac
	System.Void <OpenAsOtherside>b__0(WizardGames.Soc.SocClient.Ui.UiInventoryOtherside win); // 0x0605b414
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryOtherside.<>c__DisplayClass42_0 : System.Object
{
	System.Func<System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemGroup>> itemGroupSource; // 0x10
	System.Func<System.Collections.Generic.List<WizardGames.Soc.Share.Framework.EntityBase>> colSource; // 0x18
	System.Func<WizardGames.Soc.Share.Framework.EntityBase,System.String> colNameProvider; // 0x20
	System.Action onClose; // 0x28
	System.Void .ctor(); // 0x0605b804
	System.Void <OpenAsOtherside>b__0(WizardGames.Soc.SocClient.Ui.UiInventoryOtherside win); // 0x0605b86c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryOtherside.<>c__DisplayClass43_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiOthersideType mode; // 0x10
	System.Int64 collectionID; // 0x18
	System.Action<System.Int64> onClose; // 0x20
	System.Action <>9__1; // 0x28
	System.Void .ctor(); // 0x0605babc
	System.Void <OpenAsOthersideInLooting>b__0(WizardGames.Soc.SocClient.Ui.UiInventoryOtherside win); // 0x0605bb24
	System.Void <OpenAsOthersideInLooting>b__1(); // 0x0605bd20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryOtherside.<>c__DisplayClass59_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiInventoryOtherside <>4__this; // 0x10
	WizardGames.Soc.SocClient.Manager.EPreviewType previewType; // 0x18
	WizardGames.Soc.Common.Entity.PartEntity partEntity; // 0x20
	System.Void .ctor(); // 0x0605bda4
	System.Void <InitPreviewScene>b__0(UnityEngine.GameObject bg, UnityEngine.GameObject model); // 0x0605be0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryOtherside.<>c__DisplayClass60_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiInventoryOtherside <>4__this; // 0x10
	WizardGames.Soc.Common.Entity.PartEntity partEntity; // 0x18
	System.Void .ctor(); // 0x0605bec8
	System.Void <ChangePreviewScene>b__0(UnityEngine.GameObject bg, UnityEngine.GameObject model); // 0x0605bf30
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiOthersideType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiOthersideType None = 0;
	static WizardGames.Soc.SocClient.Ui.UiOthersideType Fuse = 1;
	static WizardGames.Soc.SocClient.Ui.UiOthersideType Decompose = 9;
	static WizardGames.Soc.SocClient.Ui.UiOthersideType Blueprint = 10;
	static WizardGames.Soc.SocClient.Ui.UiOthersideType ToolCupboard = 11;
	static WizardGames.Soc.SocClient.Ui.UiOthersideType RepairBench = 12;
	static WizardGames.Soc.SocClient.Ui.UiOthersideType AutoTurret = 13;
	static WizardGames.Soc.SocClient.Ui.UiOthersideType NearBy = 14;
	static WizardGames.Soc.SocClient.Ui.UiOthersideType NearByContainer = 19;
	static WizardGames.Soc.SocClient.Ui.UiOthersideType VehicleStorage = 20;
	static WizardGames.Soc.SocClient.Ui.UiOthersideType StorageDebris = 21;
	static WizardGames.Soc.SocClient.Ui.UiOthersideType SafeBox = 24;
	static WizardGames.Soc.SocClient.Ui.UiOthersideType Bate1SafeBox = 25;
	static WizardGames.Soc.SocClient.Ui.UiOthersideType Composter = 26;
	static WizardGames.Soc.SocClient.Ui.UiOthersideType HitchPost = 27;
	static WizardGames.Soc.SocClient.Ui.UiOthersideType Locker = 28;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiInventoryOtherSideInfo : System.ValueType
{
	System.String componentName; // 0x10
	System.Func<WizardGames.Soc.SocClient.Ui.UiOthersideBase> creator; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryOthersideContainers : System.Object
{
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.UiOthersideType,WizardGames.Soc.SocClient.Ui.UiInventoryOtherSideInfo> othersideComNameMap; // 0x10
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.UiOthersideType,WizardGames.Soc.Common.Profile.EProfileFunc> fps10ProfileFunc; // 0x18
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.UiOthersideType> disableBGCfg; // 0x20
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.UiOthersideType> disableMoveSignCfg; // 0x28
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.UiOthersideType> quickAreaCfg; // 0x30
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.UiOthersideType> newBtnStateCfg; // 0x38
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.UiOthersideType> disableToolBarCfg; // 0x40
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.UiOthersideType> disableQuickLootCfg; // 0x48
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.UiOthersideType> disableAllLootCfg; // 0x50
	static SocLogger Log; // 0x0
	FairyGUI.GObject objBG; // 0x58
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.UiOthersideType,WizardGames.Soc.SocClient.Ui.UiOthersideBase> modes; // 0x60
	WizardGames.Soc.SocClient.Ui.UiOthersideType eCurMode; // 0x68
	WizardGames.Soc.SocClient.Ui.ComLazyLoader boardLoader; // 0x70
	System.Action onOthersideClose; // 0x78
	WizardGames.Soc.SocClient.Ui.ComLazyLoader loaderCommonTip; // 0x80
	WizardGames.Soc.SocClient.Ui.UiInventoryOthersidePanel uiInventory; // 0x88
	FairyGUI.Transition animShow; // 0x90
	FairyGUI.Transition animHide; // 0x98
	WizardGames.Soc.SocClient.Ui.UiOthersideType Firstmode; // 0xa0
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiInventoryOthersidePanel inventory, WizardGames.Soc.SocClient.Ui.ComLazyLoader nodeLoader); // 0x0605bfc4
	System.Void InitOtherside(FairyGUI.GComponent node); // 0x0605c174
	System.Void DestoryOtherside(); // 0x0605c550
	System.Void OnDestroy(); // 0x0605c67c
	System.Void OnClickShowCupboardTip(); // 0x0605c6ec
	System.Void OnClickCloseCommonTip(); // 0x0605c810
	System.Void HideAllContainer(); // 0x0605c8e0
	System.Void TryOthersideGuide(); // 0x0605ca5c
	System.Boolean IsPlayerInventoryCol(WizardGames.Soc.Share.Framework.EntityBase ent); // 0x0605cb98
	System.Void ShowContainer(WizardGames.Soc.SocClient.Ui.UiOthersideType mode, System.Int64 targetCollectionId, System.Action onClose); // 0x060597e0
	System.Void SetCheckPosClose(System.Int64 collectionId); // 0x0605b14c
	System.Void ShowContainer(System.Func<System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemGroup>> itemGroupSource, WizardGames.Soc.SocClient.Ui.UiOthersideType othersideType, System.Func<System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.ItemContainerNode>> conSource, System.Func<WizardGames.Soc.Common.CustomType.ItemContainerNode,System.String> conNameProvider, System.Action onClose); // 0x0605b544
	System.Void ShowContainer(System.Func<System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemGroup>> itemGroupSource, System.Func<System.Collections.Generic.List<WizardGames.Soc.Share.Framework.EntityBase>> colSource, System.Func<WizardGames.Soc.Share.Framework.EntityBase,System.String> colNameProvider, System.Action onClose); // 0x0605b938
	System.Void RefreshBtnsState(); // 0x0605d1f4
	System.Void Refresh(); // 0x0605d864
	System.Void UnChooseAllIcons(); // 0x0605d990
	System.Void OnOthersideDisable(); // 0x0605da5c
	System.Void OnQuickDropStateChanged(System.Boolean state); // 0x0605e2a8
	System.Void OnClickBack(); // 0x0605e418
	System.Void DoUpdateFps30(System.Single dt); // 0x0605e630
	System.Void DoUpdateFps10(System.Single dt); // 0x0605e70c
	System.Void PlayInventoryOthersideOpenAudio(System.Int64 lootingId); // 0x060599a0
	System.Void PlayInventoryOthersideCloseAudio(System.Int64 lootingId); // 0x0605dc08
	WizardGames.Soc.SocClient.Ui.UiOthersideBase GetOrCreateUiOtherSideBase(WizardGames.Soc.SocClient.Ui.UiOthersideType mode); // 0x0605ccf0
	System.Void OnIconDragStart(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x0605e884
	System.Void OnIconDragEnd(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem, System.Boolean isDragValid); // 0x0605e94c
	System.Void OnIconClick(WizardGames.Soc.SocClient.Ui.ComItemIcon clickIcon); // 0x0605ea2c
	WizardGames.Soc.SocClient.Ui.UiOthersideBase GetCurMode(); // 0x0605e370
	WizardGames.Soc.SocClient.Ui.ComItemIcon SetOtherHightLight(System.Int32 tarIndex, System.Boolean on); // 0x0605eaf4
	System.Void ScrollViewToTop(); // 0x0605ebdc
	WizardGames.Soc.Common.CustomType.ItemContainerNode GetItemContainerNode(); // 0x0605ec98
	System.Boolean OpenQuickArea(); // 0x0605ed0c
	System.Boolean CanDoubleClickToMove(); // 0x0605ed94
	System.Void .ctor(); // 0x0605ee5c
	static System.Void .cctor(); // 0x0605fe88
	System.Void <InitOtherside>b__20_0(FairyGUI.GComponent com); // 0x0605ff5c
	System.Void <InitOtherside>b__20_1(); // 0x06060070
	System.Boolean <OnClickShowCupboardTip>b__23_0(); // 0x06060100
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryOthersideContainers.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiInventoryOthersideContainers.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.SocClient.Ui.UiOthersideBase> <>9__54_0; // 0x8
	static System.Func<WizardGames.Soc.SocClient.Ui.UiOthersideBase> <>9__54_1; // 0x10
	static System.Func<WizardGames.Soc.SocClient.Ui.UiOthersideBase> <>9__54_2; // 0x18
	static System.Func<WizardGames.Soc.SocClient.Ui.UiOthersideBase> <>9__54_3; // 0x20
	static System.Func<WizardGames.Soc.SocClient.Ui.UiOthersideBase> <>9__54_4; // 0x28
	static System.Func<WizardGames.Soc.SocClient.Ui.UiOthersideBase> <>9__54_5; // 0x30
	static System.Func<WizardGames.Soc.SocClient.Ui.UiOthersideBase> <>9__54_6; // 0x38
	static System.Func<WizardGames.Soc.SocClient.Ui.UiOthersideBase> <>9__54_7; // 0x40
	static System.Func<WizardGames.Soc.SocClient.Ui.UiOthersideBase> <>9__54_8; // 0x48
	static System.Func<WizardGames.Soc.SocClient.Ui.UiOthersideBase> <>9__54_9; // 0x50
	static System.Func<WizardGames.Soc.SocClient.Ui.UiOthersideBase> <>9__54_10; // 0x58
	static System.Func<WizardGames.Soc.SocClient.Ui.UiOthersideBase> <>9__54_11; // 0x60
	static System.Func<WizardGames.Soc.SocClient.Ui.UiOthersideBase> <>9__54_12; // 0x68
	static System.Func<WizardGames.Soc.SocClient.Ui.UiOthersideBase> <>9__54_13; // 0x70
	static System.Void .cctor(); // 0x0606016c
	System.Void .ctor(); // 0x060601d0
	WizardGames.Soc.SocClient.Ui.UiOthersideBase <.ctor>b__54_0(); // 0x06060238
	WizardGames.Soc.SocClient.Ui.UiOthersideBase <.ctor>b__54_1(); // 0x060602c4
	WizardGames.Soc.SocClient.Ui.UiOthersideBase <.ctor>b__54_2(); // 0x06060350
	WizardGames.Soc.SocClient.Ui.UiOthersideBase <.ctor>b__54_3(); // 0x060603dc
	WizardGames.Soc.SocClient.Ui.UiOthersideBase <.ctor>b__54_4(); // 0x06060468
	WizardGames.Soc.SocClient.Ui.UiOthersideBase <.ctor>b__54_5(); // 0x060604f4
	WizardGames.Soc.SocClient.Ui.UiOthersideBase <.ctor>b__54_6(); // 0x06060580
	WizardGames.Soc.SocClient.Ui.UiOthersideBase <.ctor>b__54_7(); // 0x0606060c
	WizardGames.Soc.SocClient.Ui.UiOthersideBase <.ctor>b__54_8(); // 0x06060698
	WizardGames.Soc.SocClient.Ui.UiOthersideBase <.ctor>b__54_9(); // 0x06060724
	WizardGames.Soc.SocClient.Ui.UiOthersideBase <.ctor>b__54_10(); // 0x060607b0
	WizardGames.Soc.SocClient.Ui.UiOthersideBase <.ctor>b__54_11(); // 0x0606083c
	WizardGames.Soc.SocClient.Ui.UiOthersideBase <.ctor>b__54_12(); // 0x060608c8
	WizardGames.Soc.SocClient.Ui.UiOthersideBase <.ctor>b__54_13(); // 0x06060954
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.LeftTabData : System.Object
{
	FairyGUI.GComponent MainInventoryTab; // 0x10
	FairyGUI.GComponent RangedWeaponTab; // 0x18
	FairyGUI.GComponent ShortcutBarTab; // 0x20
	UnityEngine.Vector2 Pos1; // 0x28
	UnityEngine.Vector2 Pos2; // 0x30
	UnityEngine.Vector2 Pos3; // 0x38
	System.Void InitTabData(FairyGUI.GComponent comRoot); // 0x060609e0
	System.Void ResetInfo(); // 0x06060b5c
	System.Void SetTabShowInfo(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.OtherSideInventoryRowInfo> dataList); // 0x06060c34
	System.Void SetPos(FairyGUI.GComponent component, System.Int32 index); // 0x06060e64
	System.Void .ctor(); // 0x06060f30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryOthersidePanel : System.Object
{
	WizardGames.Soc.SocClient.Ui.LeftTabData leftTabData; // 0x10
	WizardGames.Soc.Common.Unity.Ui.WindowComBase parentPanel; // 0x18
	FairyGUI.Controller ctrlInventoryPartCtrl; // 0x20
	FairyGUI.Controller quikAreaTypeCtrl; // 0x28
	FairyGUI.Controller quikNumCtrl; // 0x30
	FairyGUI.Controller showQuikAreaCtrl; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiQuickActionArea> quickAreas; // 0x40
	FairyGUI.GGroup QuikNode; // 0x48
	FairyGUI.GGraph LeftNode; // 0x50
	FairyGUI.GGraph RightNode; // 0x58
	System.Collections.Generic.Dictionary<System.Int64,System.String> tempIconDisplay; // 0x60
	FairyGUI.GComponent ComRoot; // 0x68
	WizardGames.Soc.SocClient.Ui.ComLazyLoader loaderDropArea; // 0x70
	FairyGUI.GList list; // 0x78
	FairyGUI.GList LeftList; // 0x80
	FairyGUI.Controller TabCtrl; // 0x88
	FairyGUI.Controller ScreenToggleCtrl; // 0x90
	FairyGUI.GButton BtnScreenToggle; // 0x98
	FairyGUI.Controller TimeStateCtrl; // 0xa0
	FairyGUI.GTextField TimeTitle; // 0xa8
	FairyGUI.GTextField TimeValue; // 0xb0
	FairyGUI.GGraph graphFx; // 0xb8
	WizardGames.Soc.SocClient.Ui.UiInventoryOthersideContainers containerOtherside; // 0xc0
	UiInventoryOthersideOthersideMoveSign <OthersideMoveSign>k__BackingField; // 0xc8
	System.Boolean finishLootWhenAck; // 0xd0
	System.Collections.Generic.List<System.Int64> curCollectionIds; // 0xd8
	System.Int64 currCollectionId; // 0xe0
	System.Collections.Generic.Dictionary<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.ETitleType> tabDic; // 0xe8
	FairyGUI.GLoader loaderTouchRotate; // 0xf0
	System.Single autoScrollTime; // 0xf8
	System.Single autoScrollStep; // 0xfc
	System.Single autoScrollFactor; // 0x100
	System.Single autoScrollTimer; // 0x104
	FairyGUI.GObject downTrigger; // 0x108
	FairyGUI.GObject upTrigger; // 0x110
	System.Action CustomQuickStorageAction; // 0x118
	System.Boolean isHaveExtraPack; // 0x120
	WizardGames.Soc.SocClient.Ui.ComItemIcon curChooseIcon; // 0x128
	System.Single titleHeight; // 0x130
	System.Single lineHeight; // 0x134
	System.Collections.Generic.Dictionary<System.Int32,System.Single> itemHeights; // 0x138
	System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> processCallback; // 0x140
	System.Single titleHeight1; // 0x148
	System.Single titleHeight2; // 0x14c
	System.Single itemHeight; // 0x150
	WizardGames.Soc.SocClient.Ui.ComItemIcon hightIcon; // 0x158
	WizardGames.Soc.SocClient.Ui.ETitleType curType; // 0x160
	System.Boolean firstInit; // 0x164
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.OtherSideInventoryRowInfo> dataList; // 0x168
	System.Int32 rowCount; // 0x170
	System.Boolean extendInventory; // 0x174
	System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> lootFilter; // 0x178
	System.Collections.Generic.Queue<UnityEngine.Vector2Int> quickLootQueue; // 0x180
	System.Boolean resortOnRefresh; // 0x188
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.OtherSideTabItemData> tabItemDatas; // 0x190
	System.Func<WizardGames.Soc.Common.Data.DataItem.ItemConfig,System.Boolean> condFilter; // 0x198
	System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> condItemNodeFilter; // 0x1a0
	System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> condItemNodeShowFilter; // 0x1a8
	System.Boolean isDisableDarkIcons; // 0x1b0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ClientCollectionItem> TabDatas; // 0x1b8
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComInventoryOthersideToolBarBinder toolBarBinder; // 0x1c0
	WizardGames.Soc.SocClient.Ui.ComLazyLoader loaderToolBar; // 0x1c8
	System.Boolean needCloseQuickLootWhenLootOver; // 0x1d0
	System.Action ToolBarCreateCall; // 0x1d8
	System.Int32 cacheType; // 0x1e0
	System.Int32 cacheAllPickPosType; // 0x1e4
	WizardGames.Soc.Common.Entity.PartEntity othersideEntity; // 0x1e8
	UiInventoryOthersideOthersideMoveSign get_OthersideMoveSign(); // 0x06060f98
	System.Void set_OthersideMoveSign(UiInventoryOthersideOthersideMoveSign value); // 0x06060ffc
	System.Void OnInit(FairyGUI.GComponent content, WizardGames.Soc.Common.Unity.Ui.WindowComBase parentPanel); // 0x0606107c
	System.Void InitScrollTriggers(FairyGUI.GComponent comRoot); // 0x06062440
	System.Void ResetAutoScroll(); // 0x06062814
	System.Void CheckAutoScroll(System.Single dt); // 0x06062878
	System.Void OnClickItemIcon(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x06062a8c
	System.Void OnScroll(FairyGUI.EventContext context); // 0x060630cc
	System.Void RenderList(System.Int32 index, FairyGUI.GObject obj); // 0x0606350c
	System.Void CalculateItemHeights(); // 0x06064f08
	System.Void RenderTabList(System.Int32 index, FairyGUI.GObject obj); // 0x06065048
	System.Void SetTitle(FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOtherSideInventoryItemBinder binder, WizardGames.Soc.SocClient.Ui.OtherSideInventoryRowInfo data); // 0x06064090
	System.Void GetMainInventoryNum(System.Int32& mainPackSize, System.Int32& num); // 0x0606434c
	System.Single CollectLastOneAddHeight(); // 0x06064dcc
	System.Void DealIconWhenCollect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06064824
	System.Void CheckItemIconListControl(WizardGames.Soc.SocClient.Ui.OtherSideInventoryRowInfo data, FairyGUI.GList listMain); // 0x060645d8
	System.Boolean OnIconAcceptDrop(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.SocClient.Ui.ItemDragInfo dropData); // 0x06065240
	System.Void RegisterEvents(); // 0x060653c8
	System.Void UnRegisterEvents(); // 0x06066068
	System.Void DoAcceptAction(System.Int32 arg1, WizardGames.Soc.SocClient.Ui.ItemDragInfo arg2); // 0x06066d08
	WizardGames.Soc.Common.CustomType.ItemContainerNode GetOtherItemContainerNode(); // 0x06066dbc
	System.Void SetOtherHightLight(System.Int32 tarIndex, System.Boolean arg2); // 0x06066e28
	System.Void SetIconToolHightLight(System.Int32 tarIndex, System.Boolean arg2); // 0x06066ef8
	System.Void SetWeaponHightLight(System.Int32 tarIndex, System.Boolean arg2); // 0x0606712c
	System.Void SetEquipHightLight(System.Int32 tarIndex, System.Boolean arg2); // 0x06067364
	System.Void SetBackpackHightLight(System.Int32 tarIndex, System.Boolean arg2); // 0x060675bc
	System.Void JumpToType(WizardGames.Soc.SocClient.Ui.ETitleType type); // 0x06067850
	System.Int32 FindIndex(WizardGames.Soc.SocClient.Ui.ETitleType type); // 0x06067958
	System.Void SelectTab(WizardGames.Soc.SocClient.Ui.ETitleType selectedType); // 0x060632dc
	System.Void OnEnable(); // 0x06067a88
	System.Void RegisterWeather(); // 0x06067c7c
	System.Void UnRegisterWeather(); // 0x06067d24
	System.Void OnDisable(WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase); // 0x06067de8
	System.Void OnDestroy(WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase); // 0x060683c8
	System.Void OnClickBack(System.Boolean immediately); // 0x0606844c
	System.Void DoShowInventory(); // 0x060685a8
	System.Void OnItemNodeUpdate(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x06068854
	System.Void RefreshAll(); // 0x060688cc
	System.Void RefreshAllWithReloadData(System.Boolean reloadData); // 0x06068758
	System.Void RefreshData(); // 0x06068934
	System.Boolean CondItemNodeShow(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x0606a6fc
	System.Void SeedData(); // 0x0606a278
	System.Void MainInventoryData(); // 0x06068a04
	System.Void ExtendInventoryData(); // 0x06068ecc
	System.Void RangedWeaponData(); // 0x0606946c
	System.Void EquipData(); // 0x060697d0
	System.Void SurvivalItemData(); // 0x06069ba0
	System.Void ShortcutBarData(); // 0x06069ea8
	System.Void UiPlayerLootUpdate(); // 0x0606aa34
	System.Void RefreshLoot(); // 0x0606aa98
	System.Void UnChooseAllIcons(); // 0x0606ab0c
	System.Void TryJumpInventoryOnEnable(); // 0x06067bc0
	System.Void OnFps30Update(System.Single dt); // 0x0606aba4
	System.Void OnFps10Update(System.Single dt); // 0x0606aeb4
	System.Void OnQuickLootStateChanged(System.Boolean state); // 0x0606af44
	System.Void OnQuickLootFinished(); // 0x0606b2d8
	System.Void OnQuickDropSelectAll(System.Boolean on); // 0x0606b440
	System.Void OnQuickDropSelectOne(); // 0x0606b688
	System.Void OnOthersideMoveItemAck(); // 0x0606b6ec
	System.Void OnQuickPutOneFinished(System.Int64 uid); // 0x0606b974
	System.Void OnQuickLootBagFull(); // 0x0606bc38
	System.Void OnItemDragStart(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x0606bcbc
	System.Void OnItemDragEnd(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem, System.Boolean isDragValid); // 0x0606be98
	System.Void OnItemClick(WizardGames.Soc.SocClient.Ui.ComItemIcon clickIcon); // 0x0606c074
	System.Void ForeachIcon(System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> process); // 0x0606c0f0
	System.Void SetProcessCallback(System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> process); // 0x0606c2ac
	System.Void OnStartLootingAck(System.Int64 colId); // 0x0605b728
	System.Void OnSwitchLootingAck(System.Int64 collectionId, System.Collections.Generic.List<System.Int64> collectionIds); // 0x0606c7d8
	System.Void OnOvenNameUpdate(System.Int64 entityId); // 0x0606c8cc
	System.Boolean StopLooting(); // 0x0606ca3c
	System.Void OnTabClick(FairyGUI.EventContext context); // 0x0606d6b4
	System.Boolean ReloadSwitchLooting(System.Int64 selectCollectionId, System.Int64 removeCollectionId); // 0x0606cadc
	System.Void ReloadSwitchLooting(); // 0x0606d828
	System.Void RefreshTabs(System.Int64 colId); // 0x0606c340
	System.Void OnTriggerPutInAll(System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> func); // 0x0606d894
	System.Void OnClickPutInAll(FairyGUI.GButton btn, System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> func); // 0x0606d914
	System.Void OnClickQuickStorage(FairyGUI.GButton btn, System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> func); // 0x0606dcc0
	System.Void StartPutOneItem(); // 0x0606b9ec
	WizardGames.Soc.SocClient.Ui.ComItemIcon GetItemIcon(UnityEngine.Vector2Int lootInfo); // 0x0606e188
	System.Void GetItemSlotIndexs(System.Collections.Generic.Queue<UnityEngine.Vector2Int>& res); // 0x0606da90
	System.Void GetkQuickStorageItemSlotIndexs(System.Collections.Generic.Queue<UnityEngine.Vector2Int>& res); // 0x0606df18
	System.Void OnShowAreaEvent(WizardGames.Soc.SocClient.Ui.ComItemIcon icon, System.Int32 ammount); // 0x0606e2b0
	System.Void OnReloadSetClip(System.Int32 usingAmmoId); // 0x0606e3bc
	System.Void OnClickSort(); // 0x0606e434
	System.Void OnClickScreenToggle(); // 0x0606e4e8
	System.Void SetPartCtrl(WizardGames.Soc.SocClient.Ui.InventoryOtherSidePartCtrl partCtrl); // 0x0606e604
	System.Void SetQickLootState(System.Boolean state); // 0x0606b370
	System.Void SetCollections(System.Collections.Generic.List<System.Int64> collectionIds); // 0x0605add8
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x0606e9e4
	System.Boolean HaveItem(System.Int64 id); // 0x0606ec54
	System.Void SetCondFilter(System.Func<WizardGames.Soc.Common.Data.DataItem.ItemConfig,System.Boolean> condFilter, System.Boolean disableDarkIcons); // 0x0606ee44
	System.Void SetCondItemNodeFilter(System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> condItemNodeFilter, System.Boolean disableDarkIcons); // 0x0606eee8
	System.Void SetCondItemNodeShowFilter(System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> condItemNodeShowFilter, System.Boolean defauleSelect, System.Boolean toggleShowState); // 0x060682c8
	System.Void RefreshLeftTab(); // 0x0606e594
	System.Void ClearFilter(); // 0x06068508
	System.Void SetIconDarkState(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06064bac
	System.Void SetTimeState(System.Boolean show, System.String title, System.String value); // 0x060681a0
	System.Void OnQuickDropStateChanged(System.Boolean state); // 0x06068120
	System.Void OnQuickDropStateChanged(System.Boolean state, System.Boolean dealItemPos); // 0x0606ef8c
	System.Void OnQuickMoveStateChanged(System.Boolean state); // 0x0606f2f8
	System.Void InitOthersideToolBar(); // 0x06062268
	System.Void SetToolBarType(System.Int32 newType); // 0x0605d478
	System.Void RefreshHotKey(); // 0x0606f36c
	System.Void SetAllPickPos(System.Int32 index); // 0x0606f90c
	System.Int32 GetToolBarType(); // 0x0606f9f4
	System.Void SetBtnState(System.Int32 index); // 0x0606fafc
	System.Void InitOthersideToolBarBtns(FairyGUI.GComponent toolBar); // 0x0606fbd8
	System.Void SetOtherSideTitle(System.String title, System.Int32 type, System.String num, System.Boolean isNameEditable); // 0x0607117c
	System.Void OnClickChangeName(FairyGUI.EventContext context); // 0x06071704
	System.Void RenameName(); // 0x06071810
	System.Void ClientRename(System.String newName); // 0x06071d78
	System.Void SetButtonTouchable(System.Boolean state); // 0x0606e70c
	System.String GetContainerOthersideName(); // 0x06071af4
	System.Void OnClickActiveSafeBox(FairyGUI.EventContext context); // 0x06071eb8
	System.Void OnClickPopGuide(FairyGUI.EventContext context); // 0x06071f88
	System.Void DestoryOthersideToolBarBtns(); // 0x0607203c
	System.Void OnClickOthersideBatchMove(System.Boolean state); // 0x0607209c
	System.Boolean ReputationFilter(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x0607215c
	System.Void SetOthersideToolBarVisible(System.Boolean visible); // 0x0605d7b8
	System.Void SetBatchMoveVisible(System.Boolean visible); // 0x0605d568
	System.Void SetAllQuickLootVisible(System.Boolean visible); // 0x0605d660
	System.Void RefreshPutInAllState(); // 0x0606c5a4
	System.Void OnClickAllQuickLoot(System.Boolean fromOtherBtn); // 0x06072208
	System.Void OnToolBarQuickLootStateChanged(System.Boolean state); // 0x0606aff0
	System.Void OnToolBarQuickLootFinished(); // 0x0606b7ac
	WizardGames.Soc.SocClient.Ui.ComItemIcon BeforeQuickDropAct(System.Int64 itemid); // 0x060724a8
	System.Void OnClickQuickDrop(); // 0x060727b4
	System.Void OnClickBatchDropCancel(); // 0x06072944
	System.Void OnClickBatchDropConfirm(); // 0x06072a80
	System.Void OnClickBatchDropSelectAll(); // 0x06072b68
	System.Void RefreshConfirmDropBtnState(); // 0x0606b4e0
	System.Void .ctor(); // 0x06072dc4
	static System.Void .cctor(); // 0x06073170
	System.Void <OnInit>b__32_0(); // 0x06073244
	System.Void <OnInit>b__32_1(FairyGUI.EventContext ctx); // 0x060732d4
	System.Void <InitScrollTriggers>b__41_0(); // 0x0607334c
	System.Void <InitScrollTriggers>b__41_1(); // 0x060733b8
	System.Void <RefreshHotKey>b__169_0(); // 0x06073420
	System.Void <RefreshHotKey>b__169_1(); // 0x060734e8
	System.Void <InitOthersideToolBarBtns>b__174_0(FairyGUI.EventContext ctx); // 0x060735b0
	System.Void <InitOthersideToolBarBtns>b__174_1(FairyGUI.EventContext ctx); // 0x06073628
	System.Void <InitOthersideToolBarBtns>b__174_2(FairyGUI.EventContext ctx); // 0x060736a4
	System.Void <InitOthersideToolBarBtns>b__174_3(FairyGUI.EventContext ctx); // 0x060737c0
	System.Void <InitOthersideToolBarBtns>b__174_4(FairyGUI.EventContext ctx); // 0x060738e0
	System.Void <InitOthersideToolBarBtns>b__174_5(FairyGUI.EventContext ctx); // 0x06073ae4
	System.Void <InitOthersideToolBarBtns>b__174_6(FairyGUI.EventContext ctx); // 0x06073b5c
	System.Void <InitOthersideToolBarBtns>b__174_7(FairyGUI.EventContext ctx); // 0x06073bd8
	System.Void <InitOthersideToolBarBtns>b__174_8(FairyGUI.EventContext ctx); // 0x06073cf4
	System.Void <InitOthersideToolBarBtns>b__174_9(FairyGUI.EventContext ctx); // 0x06073e10
	System.Void <InitOthersideToolBarBtns>b__174_10(FairyGUI.EventContext ctx); // 0x06073e88
	System.Void <InitOthersideToolBarBtns>b__174_11(FairyGUI.EventContext ctx); // 0x06073f00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryOthersidePanel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiInventoryOthersidePanel.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ComBaseIcon> <>9__50_0; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.ComBaseIcon,System.Boolean> <>9__60_0; // 0x10
	static System.Void .cctor(); // 0x06073f7c
	System.Void .ctor(); // 0x06073fe0
	System.Void <RenderList>b__50_0(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x06074048
	System.Void <DealIconWhenCollect>b__60_0(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, System.Boolean state); // 0x060741e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryOthersidePanel.<>c__DisplayClass32_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ETitleType type; // 0x10
	WizardGames.Soc.SocClient.Ui.UiInventoryOthersidePanel <>4__this; // 0x18
	System.Void .ctor(); // 0x060627ac
	System.Void <OnInit>b__2(FairyGUI.EventContext ctx); // 0x060743f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryOthersidePanel.<>c__DisplayClass50_0 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemConfig campCfg; // 0x10
	WizardGames.Soc.SocClient.Ui.UiInventoryOthersidePanel <>4__this; // 0x18
	System.Void .ctor(); // 0x06064b44
	System.Void <RenderList>b__1(WizardGames.Soc.SocClient.Ui.ComBaseIcon curIcon); // 0x06074478
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryOthersidePanel.<>c__DisplayClass60_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	System.Void .ctor(); // 0x060651d8
	System.Void <DealIconWhenCollect>b__1(FairyGUI.EventContext ctx); // 0x06074648
	System.Void <DealIconWhenCollect>b__2(FairyGUI.EventContext ctx); // 0x06074950
	System.Boolean <DealIconWhenCollect>b__3(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x060749d8
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.InventoryOtherSidePartCtrl : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.InventoryOtherSidePartCtrl All = 0;
	static WizardGames.Soc.SocClient.Ui.InventoryOtherSidePartCtrl LeftOnly = 1;
	static WizardGames.Soc.SocClient.Ui.InventoryOtherSidePartCtrl RightOnly = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.OtherSideInventoryRowInfo : System.Object
{
	System.Boolean isTitle; // 0x10
	WizardGames.Soc.SocClient.Ui.ETitleType type; // 0x14
	System.String title; // 0x18
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container; // 0x20
	System.Collections.Generic.List<System.Int32> itemIndexs; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComItemIcon> icons; // 0x30
	System.Void .ctor(); // 0x0606a920
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.ETitleType type); // 0x0606a7e8
	System.String GetTitle(); // 0x06074ab0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ETitleType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ETitleType None = 0;
	static WizardGames.Soc.SocClient.Ui.ETitleType MainInventory = 1;
	static WizardGames.Soc.SocClient.Ui.ETitleType ExtendInventory = 2;
	static WizardGames.Soc.SocClient.Ui.ETitleType RangedWeapon = 3;
	static WizardGames.Soc.SocClient.Ui.ETitleType Equip = 4;
	static WizardGames.Soc.SocClient.Ui.ETitleType SurvivalItem = 5;
	static WizardGames.Soc.SocClient.Ui.ETitleType ShortcutBar = 6;
	static WizardGames.Soc.SocClient.Ui.ETitleType Seed = 7;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryReputationBadge : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GList badgeList; // 0x338
	FairyGUI.GLoader closeLoader; // 0x340
	FairyGUI.GButton btnBadgeExpand; // 0x348
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Reputation.BadgeData> badgeDatas; // 0x350
	System.Void OnInit(); // 0x06074c88
	System.Void OnEnable(); // 0x0607501c
	System.Void OnDisable(); // 0x0607527c
	System.Void RefreshReputationBadge(); // 0x06075128
	System.Void OnReputationBadgeWearChange(); // 0x06075380
	System.Void OnCloseSelf(); // 0x060754c8
	System.Void OnRenderBadgeItem(System.Int32 index, FairyGUI.GObject obj); // 0x06075534
	System.Void OnClickBadgeItem(FairyGUI.EventContext context); // 0x0607591c
	System.Void .ctor(); // 0x06075b88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemChoose : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.GameItemChoose.RootItemChooseBinder rootBinder; // 0x338
	FairyGUI.GButton btnCancel; // 0x340
	FairyGUI.GButton btnConfirm; // 0x348
	WizardGames.Soc.SocClient.Ui.ItemChooseData itemChooseData; // 0x350
	System.Int32 currentSelectedIndex; // 0x358
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemChooseInfo> itemList; // 0x360
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.UiItemChoose.ToolTipsBinder> toolTipsBinders; // 0x368
	System.Void OnInit(); // 0x06075c14
	System.Void OnDestroy(); // 0x060761ac
	System.Void SetData(WizardGames.Soc.SocClient.Ui.ItemChooseData data); // 0x0607622c
	System.Void UpdateUI(); // 0x06076318
	System.Void UpdateItemList(); // 0x06076f0c
	System.Void SetTitle(System.String str); // 0x06076810
	System.Void SetSubTitle(System.String str); // 0x0607692c
	System.Void SetCurrencyColumnText(System.String str); // 0x06076a44
	System.Void SetValueText(System.String str); // 0x06076c70
	System.Void SetIcon(System.String iconUrl); // 0x06076e18
	System.Void SetCurrencyColumnVisible(System.Boolean show); // 0x06076b40
	System.Void SetSubTitleVisible(System.Boolean show); // 0x06077420
	System.Void InitBtns(); // 0x0607649c
	System.Void OnItemClick(FairyGUI.EventContext context); // 0x0607754c
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x06077810
	System.Void UpdateBtnText(); // 0x06077040
	System.Void RefreshBtnState(); // 0x06077154
	System.Void UpdateConformBtnCost(); // 0x06077208
	System.Void Close(); // 0x06078780
	System.Void OnBtnConfirmClick(FairyGUI.EventContext context); // 0x060787ec
	System.Void OnDisable(); // 0x060788b4
	System.Void .ctor(); // 0x06078948
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemChoose.ToolTipsBinder : System.Object, WizardGames.Soc.SocClient.Ui.Utils.IToolTips
{
	FairyGUI.GComponent Target; // 0x10
	FairyGUI.GComponent Item; // 0x18
	WizardGames.Soc.Common.Data.DataItem.ItemConfig ItemConfig; // 0x20
	WizardGames.Soc.Common.Data.resource.OBJGenaral itemGeneral; // 0x28
	System.Int32 Index; // 0x30
	System.Void .ctor(FairyGUI.GComponent target); // 0x06078b4c
	System.Void ShowTips(FairyGUI.EventContext context); // 0x06078bd8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemChoose.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiItemChoose.<>c <>9; // 0x0
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.UiItemChoose.ToolTipsBinder> <>9__29_0; // 0x8
	static System.Void .cctor(); // 0x06078d3c
	System.Void .ctor(); // 0x06078da0
	WizardGames.Soc.SocClient.Ui.UiItemChoose.ToolTipsBinder <.ctor>b__29_0(FairyGUI.GComponent c); // 0x06078e08
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ItemChooseData : System.Object
{
	System.String Title; // 0x10
	System.String SubTitle; // 0x18
	System.Int32 DefaultSelectIndex; // 0x20
	System.Boolean IsSingleSelect; // 0x24
	System.Func<System.Int32> GetCurrentCurrency; // 0x28
	System.Action<System.Int32> OnConfirmClickCallback; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemChooseInfo> ItemList; // 0x38
	System.String CurrencyColumnText; // 0x40
	System.String IconUrl; // 0x48
	System.Boolean ConfirmBtnShowCost; // 0x50
	System.String CancelBtnText; // 0x58
	System.String ConfirmBtnText; // 0x60
	System.Action<FairyGUI.GButton> RefreshCancelBtnCallback; // 0x68
	System.Action<FairyGUI.GButton> RefreshConfirmBtnCallback; // 0x70
	System.Void .ctor(); // 0x06078ea8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ItemChooseInfo : System.Object
{
	System.String Title; // 0x10
	System.Int64 ItemId; // 0x18
	System.Boolean Exchanged; // 0x20
	System.Int32 Num; // 0x24
	System.Int32 StorageNum; // 0x28
	System.Int32 Cost; // 0x2c
	System.Boolean Enable; // 0x30
	System.String IconUrl; // 0x38
	System.Boolean ShowQuantity; // 0x40
	System.Int32 ConsumStateIndex; // 0x44
	System.Boolean HasRadioBox; // 0x48
	System.Int32 SizeStateIndex; // 0x4c
	System.Int32 BottomTextStateIndex; // 0x50
	System.String BottomTextStr; // 0x58
	System.String TagTitle; // 0x60
	System.Boolean IsShowSelected; // 0x68
	System.Int32 ChooseCurrency; // 0x6c
	System.Int32 Quality; // 0x70
	System.Boolean ShowStock; // 0x74
	System.Boolean UseDefaultStockText; // 0x75
	System.String OtherStockText; // 0x78
	System.Void .ctor(); // 0x06078f44
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRewardChoose : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.GameItemChoose.ComSelectRewardTipBinder rootBinder; // 0x338
	WizardGames.Soc.SocClient.Ui.RewardChooseData rewardChooseData; // 0x340
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardChooseInfo> rewardList; // 0x348
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.UiRewardChoose.ToolTipsBinder> toolTipsBinders; // 0x350
	System.Void OnInit(); // 0x0607901c
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x06079508
	System.Int32 CurrentSelectedCount(); // 0x06079b2c
	System.Void UpdateTitle(); // 0x06079d80
	System.Void Close(); // 0x06079ee0
	System.Void OnItemClick(FairyGUI.EventContext context); // 0x06079f4c
	System.Void OnBtnGetClick(); // 0x0607a350
	System.Void UpdateBtnState(); // 0x0607a258
	System.Void .ctor(); // 0x0607a4a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRewardChoose.ToolTipsBinder : System.Object, WizardGames.Soc.SocClient.Ui.Utils.IToolTips
{
	FairyGUI.GComponent Target; // 0x10
	FairyGUI.GComponent Item; // 0x18
	WizardGames.Soc.Common.Data.DataItem.ItemConfig ItemConfig; // 0x20
	System.Int32 Index; // 0x28
	System.Void .ctor(FairyGUI.GComponent target); // 0x0607a640
	System.Void ShowTips(FairyGUI.EventContext context); // 0x0607a6cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRewardChoose.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiRewardChoose.<>c <>9; // 0x0
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.UiRewardChoose.ToolTipsBinder> <>9__14_0; // 0x8
	static System.Void .cctor(); // 0x0607a7f0
	System.Void .ctor(); // 0x0607a854
	WizardGames.Soc.SocClient.Ui.UiRewardChoose.ToolTipsBinder <.ctor>b__14_0(FairyGUI.GComponent c); // 0x0607a8bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RewardChooseData : System.Object
{
	System.Int32 MaxSelectCount; // 0x10
	System.Action OnGetBtnClickCallback; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RewardChooseInfo : System.Object
{
	System.Int64 ItemId; // 0x10
	System.Boolean IsLock; // 0x18
	System.Boolean Enable; // 0x19
	System.Int32 Num; // 0x1c
	System.String UnLockInfo; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComDetailLists : System.Object
{
	SocLogger logger; // 0x10
	FairyGUI.GComponent node; // 0x18
	FairyGUI.GList listDetails; // 0x20
	FairyGUI.Controller controller; // 0x28
	System.String gongzuotaiBg; // 0x30
	System.String fenjietaiBg; // 0x38
	System.String shopBg; // 0x40
	System.String tiaozhitaiBg; // 0x48
	System.String yanjiutaiBg; // 0x50
	System.Int32 itemSize; // 0x58
	System.Boolean isNarrowScreen; // 0x5c
	WizardGames.Soc.SocClient.Ui.CraftConfig craftConfig; // 0x60
	WizardGames.Soc.SocClient.Ui.BlueprintConfig blueprintConfig; // 0x68
	WizardGames.Soc.SocClient.Ui.DecomposeConfig decomposeConfig; // 0x70
	WizardGames.Soc.SocClient.Ui.UseForCraftConfig useForCraftConfig; // 0x78
	WizardGames.Soc.SocClient.Ui.DropConfig dropConfig; // 0x80
	WizardGames.Soc.SocClient.Ui.TaskConfig taskConfig; // 0x88
	System.Void .ctor(FairyGUI.GComponent node); // 0x0607a95c
	System.Void SetListItemSize(FairyGUI.GList list); // 0x0607ad54
	System.Void HideAllIconsChoose(); // 0x0607ae80
	System.Void OnDestory(); // 0x0607b0f0
	System.Void Bind(System.Int32[] titles, WizardGames.Soc.SocClient.Ui.EDetailListType type); // 0x0607b1e8
	System.Void BindDropType(WizardGames.Soc.SocClient.Ui.DropConfig dropConfig); // 0x0607b46c
	System.Void OnRenderDropItem(System.Int32 index, FairyGUI.GObject obj); // 0x0607bba8
	System.Void BindShopType(WizardGames.Soc.SocClient.Ui.DropConfig dropConfig); // 0x0607b574
	System.Void OnRenderShopItem(System.Int32 index, FairyGUI.GObject obj); // 0x0607c638
	System.Void BindTraceItemUseless(FairyGUI.GComponent itemSheet); // 0x0607c3a8
	System.Void BindTraceItemUnSee(FairyGUI.GComponent itemSheet); // 0x0607d0f0
	System.Void OnClickTrace(System.Int32 traceId); // 0x0607d1b0
	System.Void BindBlueprintType(WizardGames.Soc.SocClient.Ui.BlueprintConfig blueprintConfig); // 0x0607b77c
	System.Void OnRenderAllBlueprintItem(System.Int32 index, FairyGUI.GObject obj); // 0x0607d264
	System.Void RenderBlueprintItem(FairyGUI.GComponent com); // 0x0607d5f8
	System.Void RenderResearchItem(FairyGUI.GComponent com); // 0x0607dca0
	System.Void BindCraftType(WizardGames.Soc.SocClient.Ui.CraftConfig craftConfig); // 0x0607b67c
	System.Void OnRenderCraftItem(System.Int32 index, FairyGUI.GObject obj); // 0x0607e57c
	System.Void BindDecomposeType(WizardGames.Soc.SocClient.Ui.DecomposeConfig decomposeConfig); // 0x0607b884
	System.Void OnRenderAllDecomposeItem(System.Int32 index, FairyGUI.GObject obj); // 0x0607f568
	System.Void RenderDecomposeItem(FairyGUI.GComponent com); // 0x0607f87c
	System.Void RenderBeDecomposeItem(System.Int32 index, FairyGUI.GComponent com); // 0x06080114
	System.Void BindUseForCraftType(WizardGames.Soc.SocClient.Ui.UseForCraftConfig useForCraftConfig); // 0x0607b9a8
	System.Void OnRenderUseForCraftItem(System.Int32 index, FairyGUI.GObject obj); // 0x06080a4c
	System.Void BindTaskType(WizardGames.Soc.SocClient.Ui.TaskConfig taskConfig); // 0x0607baa8
	System.Void OnRenderTaskItem(System.Int32 index, FairyGUI.GObject obj); // 0x06081984
	WizardGames.Soc.SocClient.Ui.ComItemIcon SetTemplateData(FairyGUI.GList gList, WizardGames.Soc.Common.Data.DataItem.ItemConfig itemConfig); // 0x0607cf90
	System.Void OnClickItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon clickIcon); // 0x06082208
	System.String GetWorkBenchLan(System.Int64 num); // 0x0607e450
	System.Void OpenCraft(System.Int64 craftId); // 0x06082490
	System.Void SetHighLight(WizardGames.Soc.SocClient.Ui.ComItemIcon comItemIcon); // 0x06081844
	System.Void SetIconLock(WizardGames.Soc.SocClient.Ui.ComItemIcon comItemIcon, System.Boolean islock); // 0x0607f364
	System.Void OpenWorkBench(System.Int32 needWorkBenchLevel); // 0x06082744
	System.Void OpenResearchTable(); // 0x06082840
	System.Void OpenMixingTable(); // 0x0608314c
	System.Void OpenDecomposeTable(FairyGUI.EventContext context); // 0x060834f4
	System.Void JumpToTaskWin(WizardGames.Soc.SocClient.Ui.EItemDetailTaskType type); // 0x060838c4
	System.Void OpenOven(System.Int64 ovenId, System.String ovenName); // 0x06083b80
	System.Void OnClick(System.Int32 id, WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06082eb8
	System.Void OpenInteractView(WizardGames.Soc.Common.Data.system.Interaction data, WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x0608403c
	System.Void OpenLootingWithStyle(System.Int32 style, WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x06084328
	System.Void OpenLootingOtherSide(WizardGames.Soc.Common.Entity.IEntity lootEntity, System.Int32 style); // 0x06085144
	System.Void OpenLootingOtherSideNew(WizardGames.Soc.Common.Entity.IEntity lootEntity, System.Int32 style); // 0x0608573c
	System.Void OpenLootingInventoryOtherside(WizardGames.Soc.Common.Entity.IEntity lootEntity, System.Int32 style); // 0x06084fc8
	System.Void OnCloseView(WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType mode, System.Int64 lootingEntityId); // 0x06085864
	System.Void RemoveSourceWin(); // 0x0608262c
	System.Void CloseLootView(System.Int64 lootingEntityId); // 0x060858e8
	System.Boolean HasObstacleBetween(UnityEngine.Vector3 position1, WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06082be8
	System.Void CheckIsNarrowScreen(); // 0x0607ac78
	System.Void <RenderBlueprintItem>b__31_0(FairyGUI.EventContext ctx); // 0x06085998
	System.Void <RenderBlueprintItem>b__31_1(FairyGUI.EventContext ctx); // 0x06085a20
	System.Void <RenderResearchItem>b__32_0(FairyGUI.EventContext ctx); // 0x06085aa8
	System.Void <OnRenderCraftItem>b__34_0(FairyGUI.EventContext ctx); // 0x06085b20
	System.Void <OnRenderCraftItem>b__34_2(FairyGUI.EventContext ctx); // 0x06085bd4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComDetailLists.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.ComDetailLists.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__26_0; // 0x8
	static FairyGUI.EventCallback1 <>9__34_1; // 0x10
	static System.Void .cctor(); // 0x06085c4c
	System.Void .ctor(); // 0x06085cb0
	System.Void <BindTraceItemUseless>b__26_0(FairyGUI.EventContext ctx); // 0x06085d18
	System.Void <OnRenderCraftItem>b__34_1(FairyGUI.EventContext ctx); // 0x06085e3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComDetailLists.<>c__DisplayClass23_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComDetailLists <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.TraceConfig drop; // 0x18
	System.Void .ctor(); // 0x0607c340
	System.Void <OnRenderDropItem>b__0(FairyGUI.EventContext ctx); // 0x06085f7c
	System.Void <OnRenderDropItem>b__1(FairyGUI.EventContext ctx); // 0x06086008
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComDetailLists.<>c__DisplayClass25_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComDetailLists <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.TraceConfig shop; // 0x18
	System.Void .ctor(); // 0x0607cf28
	System.Void <OnRenderShopItem>b__0(FairyGUI.EventContext ctx); // 0x06086138
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComDetailLists.<>c__DisplayClass34_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.Ingredient ingredientConfig; // 0x10
	WizardGames.Soc.SocClient.Ui.ComDetailLists <>4__this; // 0x18
	System.Void .ctor(); // 0x0607f2fc
	System.Void <OnRenderCraftItem>b__3(FairyGUI.EventContext ctx); // 0x060861c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComDetailLists.<>c__DisplayClass40_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComDetailLists <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.CraftItem userForCraftItem; // 0x18
	System.Void .ctor(); // 0x060817dc
	System.Void <OnRenderUseForCraftItem>b__0(FairyGUI.EventContext ctx); // 0x06086250
	System.Void <OnRenderUseForCraftItem>b__1(FairyGUI.EventContext ctx); // 0x060862d0
	System.Void <OnRenderUseForCraftItem>b__2(FairyGUI.EventContext ctx); // 0x0608635c
	System.Void <OnRenderUseForCraftItem>b__3(FairyGUI.EventContext ctx); // 0x060863ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComDetailLists.<>c__DisplayClass42_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComDetailLists <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.TaskInfo task; // 0x18
	System.Void .ctor(); // 0x060821a0
	System.Void <OnRenderTaskItem>b__0(FairyGUI.EventContext ctx); // 0x060866c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComDetailLists.<>c__DisplayClass54_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.EItemDetailTaskType type; // 0x10
	System.Void .ctor(); // 0x06083b18
	System.Void <JumpToTaskWin>b__0(WizardGames.Soc.SocClient.Ui.UiMissionView win); // 0x0608674c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ItemDetailConfig : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Data.DataItem.ItemConfig ItemConfig; // 0x10
	System.Int64 ItemId; // 0x18
	System.Boolean ShouldShowWinCraft; // 0x20
	System.Boolean ShouldShowWinBlueprint; // 0x21
	System.Boolean ShouldShowWinDecompose; // 0x22
	System.Boolean ShouldShowUseForCraft; // 0x23
	System.Boolean ShouldShowDrop; // 0x24
	System.Boolean ShouldShowTrade; // 0x25
	System.Boolean ShouldShowTask; // 0x26
	WizardGames.Soc.SocClient.Ui.DecomposeConfig DecomposeConfig; // 0x28
	WizardGames.Soc.SocClient.Ui.CraftConfig CraftConfig; // 0x30
	WizardGames.Soc.SocClient.Ui.BlueprintConfig BlueprintConfig; // 0x38
	WizardGames.Soc.SocClient.Ui.UseForCraftConfig UseForCraftConfig; // 0x40
	WizardGames.Soc.SocClient.Ui.DropConfig DropConfig; // 0x48
	WizardGames.Soc.Common.Data.blueprintData.Blueprint curBluePrint; // 0x50
	WizardGames.Soc.SocClient.Ui.TaskConfig TaskConfig; // 0x58
	System.Boolean isExploration; // 0x60
	System.Boolean isBounty; // 0x61
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Construction.PartType,WizardGames.Soc.Common.Construction.PartType> PartTypeToPartTypeV1; // 0x8
	System.Void LoadInfo(System.Int64 Id); // 0x060867f0
	System.Void CheckDropandTradeAndTask(); // 0x06086c2c
	System.Void CheckPlayMode(); // 0x06086ae0
	System.Void CheckCraftandBlueprint(); // 0x06087778
	System.Void CheckBlueprint(); // 0x0608781c
	System.Boolean CheckCraft(); // 0x060891bc
	System.Void CheckCanUseForCraft(); // 0x06088000
	System.Boolean CheckCanBlueprint(); // 0x06089a30
	System.Boolean CheckCanResearch(); // 0x06089c4c
	System.Void CheckDecompose(); // 0x06087914
	WizardGames.Soc.Common.Data.DataItem.Technology GetTechByItemId(WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprint); // 0x0608a580
	System.Boolean IsExistIngredients(System.Int32[] ingredients); // 0x0608a110
	System.Void .ctor(); // 0x0608adc4
	static System.Void .cctor(); // 0x0608ae34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BlueprintConfig : System.Object
{
	System.Boolean canBlueprint; // 0x10
	System.Boolean blueprintUnlock; // 0x11
	System.Int32 unlockWorkBenchId; // 0x14
	System.Int32 consumption; // 0x18
	System.Int32 reverseConsumption; // 0x1c
	System.Boolean canResearch; // 0x20
	System.Void .ctor(); // 0x060899c0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ItemDetailCraftType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ItemDetailCraftType Craft = 0;
	static WizardGames.Soc.SocClient.Ui.ItemDetailCraftType MixingTable = 1;
	static WizardGames.Soc.SocClient.Ui.ItemDetailCraftType Cook = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.CraftConfig : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Ingredient> ingredients; // 0x10
	System.Void .ctor(); // 0x06089108
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Ingredient : System.Object
{
	System.Int32[] craftIngredients; // 0x10
	System.Int32[] craftIngredientsNum; // 0x18
	System.Int32 workBenchLevel; // 0x20
	WizardGames.Soc.SocClient.Ui.ItemDetailCraftType CraftType; // 0x24
	System.Int64 ovenId; // 0x28
	System.String ovenName; // 0x30
	System.Int32 resultItemNum; // 0x38
	System.Void .ctor(System.Int32[] craftIngredients, System.Int32[] craftIngredientsNum, WizardGames.Soc.SocClient.Ui.ItemDetailCraftType craftType, System.Int32 workBenchLevel); // 0x06089e9c
	System.Void .ctor(System.Int32[] craftIngredients, System.Int32[] craftIngredientsNum, System.Int32 resultItemNum, System.Int64 ovenId, System.String ovenName); // 0x06089f64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.DecomposeConfig : System.Object
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<System.Tuple<System.Int32,System.Single>> retItemInfo; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<System.Tuple<System.Int32,System.Single>>> item2RetItemInfo; // 0x18
	System.Boolean get_canDecompose(); // 0x060809c4
	System.Boolean get_canBeDecomposed(); // 0x0607f4d8
	System.Collections.Generic.List<System.Tuple<System.Int32,System.Single>> OnDecompose(System.Int64 curItemId, WizardGames.Soc.Common.Data.blueprintData.Blueprint curBluePrint); // 0x0608a8cc
	System.Void .ctor(); // 0x0608a818
	static System.Void .cctor(); // 0x0608b018
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TraceConfig : System.Object, System.IComparable<WizardGames.Soc.SocClient.Ui.TraceConfig>
{
	System.String traceSource; // 0x10
	System.Int32 traceId; // 0x18
	WizardGames.Soc.Common.Data.ItemCount itemCounts; // 0x20
	System.Int32 traceTip; // 0x28
	System.Void .ctor(System.Int32 traceId, System.String traceSource, WizardGames.Soc.Common.Data.ItemCount itemCounts); // 0x0608904c
	System.Void .ctor(System.Int32 traceId, System.String traceSource, System.Int32 traceTip); // 0x06088e5c
	System.Int32 CompareTo(WizardGames.Soc.SocClient.Ui.TraceConfig other); // 0x0608b0ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.DropConfig : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TraceConfig> dropsLists; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TraceConfig> shopsLists; // 0x18
	System.Void .ctor(); // 0x06088ac0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EItemDetailTaskType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EItemDetailTaskType CoreTaskEasy = 0;
	static WizardGames.Soc.SocClient.Ui.EItemDetailTaskType CoreTaskNormal = 1;
	static WizardGames.Soc.SocClient.Ui.EItemDetailTaskType BoxTask = 2;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.ItemDetailTaskItemInfo : System.ValueType
{
	System.Int32 ItemId; // 0x10
	System.Int32 Count; // 0x14
	System.Void .ctor(System.Int32 itemId, System.Int32 count); // 0x0608b174
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TaskInfo : System.Object
{
	System.Int64 taskId; // 0x10
	System.String taskName; // 0x18
	WizardGames.Soc.SocClient.Ui.EItemDetailTaskType taskType; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemDetailTaskItemInfo> Rewards; // 0x28
	System.Void .ctor(System.Int32 dropId, System.Int32 traceId, System.Collections.Generic.List<WizardGames.Soc.Common.Data.Reward> rewardsData, System.String name); // 0x06088ba4
	System.Void ParseCoreTaskCfg(System.Int32 dropId); // 0x0608b1f4
	System.Void ParseBoxTaskCfg(System.Int32 dropId); // 0x0608b518
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TaskConfig : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TaskInfo> TaskLists; // 0x10
	System.Void SortTaskList(); // 0x06088f10
	System.Void .ctor(); // 0x06088a0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TaskConfig.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.TaskConfig.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.TaskInfo> <>9__1_0; // 0x8
	static System.Void .cctor(); // 0x0608b978
	System.Void .ctor(); // 0x0608b9dc
	System.Int32 <SortTaskList>b__1_0(WizardGames.Soc.SocClient.Ui.TaskInfo a, WizardGames.Soc.SocClient.Ui.TaskInfo b); // 0x0608ba44
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.CraftItem : System.Object
{
	System.Int64 resultItem; // 0x10
	System.Int32 resultItemNum; // 0x18
	System.Int64 partType; // 0x20
	System.String partName; // 0x28
	System.Int32[] ingredients; // 0x30
	System.Int32[] ingredientsNum; // 0x38
	System.Boolean isUnlock; // 0x40
	System.Void .ctor(WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprint); // 0x0608a1dc
	System.Void .ctor(WizardGames.Soc.Common.Data.Item.MixingRecipe mixingRecipe); // 0x0608a2ec
	System.Void .ctor(WizardGames.Soc.Common.Data.DataItem.ItemConfig ovenData, WizardGames.Soc.Common.Data.Item.Cookable cookData); // 0x0608a3ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UseForCraftConfig : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.CraftItem> craftItems; // 0x10
	System.Void .ctor(); // 0x0608a05c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EItemDetailPageType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EItemDetailPageType Craft = 0;
	static WizardGames.Soc.SocClient.Ui.EItemDetailPageType Blueprint = 1;
	static WizardGames.Soc.SocClient.Ui.EItemDetailPageType Decompose = 2;
	static WizardGames.Soc.SocClient.Ui.EItemDetailPageType UseForCraft = 3;
	static WizardGames.Soc.SocClient.Ui.EItemDetailPageType Drop = 4;
	static WizardGames.Soc.SocClient.Ui.EItemDetailPageType Trade = 5;
	static WizardGames.Soc.SocClient.Ui.EItemDetailPageType Task = 6;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EDetailListType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EDetailListType Craft = 0;
	static WizardGames.Soc.SocClient.Ui.EDetailListType Blueprint = 1;
	static WizardGames.Soc.SocClient.Ui.EDetailListType Research = 2;
	static WizardGames.Soc.SocClient.Ui.EDetailListType Decompose = 3;
	static WizardGames.Soc.SocClient.Ui.EDetailListType BeDecomposed = 4;
	static WizardGames.Soc.SocClient.Ui.EDetailListType UseForCraft = 5;
	static WizardGames.Soc.SocClient.Ui.EDetailListType Drop = 6;
	static WizardGames.Soc.SocClient.Ui.EDetailListType Shop = 7;
	static WizardGames.Soc.SocClient.Ui.EDetailListType Task = 8;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemDetail : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComboBox btnTimeLine; // 0x338
	FairyGUI.GTextField textCurItemDesc; // 0x340
	FairyGUI.GComponent comCraft; // 0x348
	FairyGUI.GComponent comBlueprint; // 0x350
	FairyGUI.GComponent comDecompose; // 0x358
	FairyGUI.GComponent comUseforCrafting; // 0x360
	FairyGUI.GComponent comDropsandTrade; // 0x368
	FairyGUI.GComponent comTrade; // 0x370
	FairyGUI.GComponent comTask; // 0x378
	FairyGUI.Controller pageControl; // 0x380
	WizardGames.Soc.SocClient.Ui.UiWinCraft winCraft; // 0x388
	WizardGames.Soc.SocClient.Ui.UiWinDecompose winDecompose; // 0x390
	WizardGames.Soc.SocClient.Ui.UiWinUseforCrafting winUseforCrafting; // 0x398
	WizardGames.Soc.SocClient.Ui.UiWinDrop winDrop; // 0x3a0
	WizardGames.Soc.SocClient.Ui.UiWinTrade winTrade; // 0x3a8
	WizardGames.Soc.SocClient.Ui.UiWinBlueprint winBlueprint; // 0x3b0
	WizardGames.Soc.SocClient.Ui.UiWinTask winTask; // 0x3b8
	WizardGames.Soc.SocClient.Ui.ComUiModel uiModel; // 0x3c0
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x3c8
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x3d0
	static WizardGames.Soc.SocClient.Ui.ItemDetailConfig itemDetailConfig; // 0x0
	static System.String sourceInterface; // 0x8
	static System.Collections.Generic.Dictionary<System.Int64,System.Int32> matNums; // 0x10
	static System.Int32 LimitedNumer; // 0x18
	System.Int64 openTechTreeNodeId; // 0x3d8
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.ItemConfig> historyItems; // 0x3e0
	System.Collections.Generic.List<System.String> tempList; // 0x3e8
	System.Void OnInit(); // 0x0608baf0
	static System.Void OpenItemDetailWin(WizardGames.Soc.Common.Data.DataItem.ItemConfig tbItem, System.String sourceWin, System.Int32 idx); // 0x06086544
	System.Void SetData(WizardGames.Soc.Common.Data.DataItem.ItemConfig tbItem, System.String sourceWin, System.Int32 idx); // 0x0608d96c
	WizardGames.Soc.Common.Data.DataItem.ItemConfig GetCurItem(); // 0x0608e09c
	System.Void RefreshCurItem(); // 0x0608e240
	System.Void OnDestroy(); // 0x0608e968
	System.Void OnEnable(); // 0x0608f15c
	System.Void OnDisable(); // 0x0608f464
	System.Void RefreshMatItemNums(); // 0x0608f2d0
	System.Void OnClickTimeLine(); // 0x0608f5c8
	System.Void HideIconChooseAndItemTips(); // 0x0608f668
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0608f734
	System.Void GoToBlueprint(); // 0x0608f808
	System.Void SetArrowVisible(System.Boolean visible); // 0x0608f880
	System.Void .ctor(); // 0x0608f8f4
	static System.Void .cctor(); // 0x0608fa24
	System.Void <OnInit>b__27_0(System.Int32 index, FairyGUI.GObject item); // 0x0608fa84
	System.Void <OnInit>b__27_1(System.Object obj); // 0x0608fc04
	System.Void <RefreshCurItem>b__31_0(WizardGames.Soc.SocClient.Ui.NavBarData navData, System.Boolean btnClicked); // 0x0608fd0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemDetailWin : System.Object
{
	WizardGames.Soc.SocClient.Ui.EItemDetailPageType pageType; // 0x10
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.EItemDetailPageType pageType); // 0x0608fe84
	System.Void Refresh(FairyGUI.Controller controller); // 0x0608fefc
	System.Void .ctor(); // 0x0608ffb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWinBlueprint : WizardGames.Soc.SocClient.Ui.UiItemDetailWin
{
	FairyGUI.GComponent comBlueprint; // 0x18
	WizardGames.Soc.SocClient.Ui.ComDetailLists blueprintList; // 0x20
	System.Action<System.Boolean> onScroll; // 0x28
	System.Void .ctor(FairyGUI.GComponent node); // 0x0608ce8c
	System.Void Refresh(FairyGUI.Controller controller); // 0x06090018
	System.Void OnDestory(); // 0x0608f084
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWinBlueprint.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiWinBlueprint.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__3_0; // 0x8
	static System.Void .cctor(); // 0x060900f4
	System.Void .ctor(); // 0x06090158
	System.Void <.ctor>b__3_0(); // 0x060901c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWinCraft : WizardGames.Soc.SocClient.Ui.UiItemDetailWin
{
	FairyGUI.GComponent comCraft; // 0x18
	WizardGames.Soc.SocClient.Ui.ComDetailLists craftList; // 0x20
	System.Action<System.Boolean> onScroll; // 0x28
	System.Void .ctor(FairyGUI.GComponent node); // 0x0608ccbc
	System.Void Refresh(FairyGUI.Controller controller); // 0x0609028c
	System.Void OnDestory(); // 0x0608eed4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWinCraft.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiWinCraft.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__3_0; // 0x8
	static System.Void .cctor(); // 0x06090368
	System.Void .ctor(); // 0x060903cc
	System.Void <.ctor>b__3_0(); // 0x06090434
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWinDecompose : WizardGames.Soc.SocClient.Ui.UiItemDetailWin
{
	FairyGUI.GComponent comDecompose; // 0x18
	WizardGames.Soc.SocClient.Ui.ComDetailLists decomposeList; // 0x20
	System.Action<System.Boolean> onScroll; // 0x28
	System.Void .ctor(FairyGUI.GComponent node); // 0x0608d05c
	System.Void Refresh(FairyGUI.Controller controller); // 0x06090500
	System.Void OnDestory(); // 0x0608ee68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWinDecompose.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiWinDecompose.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__3_0; // 0x8
	static System.Void .cctor(); // 0x060905dc
	System.Void .ctor(); // 0x06090640
	System.Void <.ctor>b__3_0(); // 0x060906a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWinDrop : WizardGames.Soc.SocClient.Ui.UiItemDetailWin
{
	FairyGUI.GComponent comDrop; // 0x18
	WizardGames.Soc.SocClient.Ui.ComDetailLists dropList; // 0x20
	System.Action<System.Boolean> onScroll; // 0x28
	System.Void .ctor(FairyGUI.GComponent node); // 0x0608d3fc
	System.Void Refresh(FairyGUI.Controller controller); // 0x06090774
	System.Void OnDestory(); // 0x0608ef40
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWinDrop.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiWinDrop.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__3_0; // 0x8
	static System.Void .cctor(); // 0x0609085c
	System.Void .ctor(); // 0x060908c0
	System.Void <.ctor>b__3_0(); // 0x06090928
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWinTask : WizardGames.Soc.SocClient.Ui.UiItemDetailWin
{
	FairyGUI.GComponent comTask; // 0x18
	WizardGames.Soc.SocClient.Ui.ComDetailLists taskList; // 0x20
	System.Action<System.Boolean> onScroll; // 0x28
	System.Void .ctor(FairyGUI.GComponent node); // 0x0608d79c
	System.Void Refresh(FairyGUI.Controller controller); // 0x060909f4
	System.Void OnDestory(); // 0x0608f0f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWinTask.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiWinTask.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__3_0; // 0x8
	static System.Void .cctor(); // 0x06090ad0
	System.Void .ctor(); // 0x06090b34
	System.Void <.ctor>b__3_0(); // 0x06090b9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWinTrade : WizardGames.Soc.SocClient.Ui.UiItemDetailWin
{
	FairyGUI.GComponent comTrade; // 0x18
	WizardGames.Soc.SocClient.Ui.ComDetailLists tradeList; // 0x20
	System.Action<System.Boolean> onScroll; // 0x28
	System.Void .ctor(FairyGUI.GComponent node); // 0x0608d5cc
	System.Void Refresh(FairyGUI.Controller controller); // 0x06090c68
	System.Void OnDestory(); // 0x0608efac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWinTrade.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiWinTrade.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__3_0; // 0x8
	static System.Void .cctor(); // 0x06090d44
	System.Void .ctor(); // 0x06090da8
	System.Void <.ctor>b__3_0(); // 0x06090e10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWinUseforCrafting : WizardGames.Soc.SocClient.Ui.UiItemDetailWin
{
	FairyGUI.GComponent comBeCraft; // 0x18
	WizardGames.Soc.SocClient.Ui.ComDetailLists beCraftList; // 0x20
	System.Action<System.Boolean> onScroll; // 0x28
	System.Void .ctor(FairyGUI.GComponent node); // 0x0608d22c
	System.Void Refresh(FairyGUI.Controller controller); // 0x06090edc
	System.Void OnDestory(); // 0x0608f018
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWinUseforCrafting.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiWinUseforCrafting.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__3_0; // 0x8
	static System.Void .cctor(); // 0x06090fb8
	System.Void .ctor(); // 0x0609101c
	System.Void <.ctor>b__3_0(); // 0x06091084
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemIconBox : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GLabel title; // 0x338
	WizardGames.Soc.SocClient.Ui.UiMsgBoxContent comMsg; // 0x340
	FairyGUI.GButton btnClose; // 0x348
	FairyGUI.GList listBtns; // 0x350
	FairyGUI.GList listItems; // 0x358
	FairyGUI.GTextField gotoConstructionTip; // 0x360
	WizardGames.Soc.SocClient.Ui.MsgItemBoxInfo curInfo; // 0x368
	System.Void OnInit(); // 0x06091150
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x060915c0
	System.Void OnItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x06091650
	System.Void OnBtnsItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x060918ec
	System.Void OnClickClose(); // 0x06091b18
	System.Void OnEnable(); // 0x06091b84
	System.Void OnDisable(); // 0x06091bec
	System.Void OnDestroy(); // 0x06091c54
	static System.Void ShowMsgBox(WizardGames.Soc.SocClient.Ui.MsgItemBoxInfo info); // 0x06091cbc
	System.Void SetInfo(WizardGames.Soc.SocClient.Ui.MsgItemBoxInfo info); // 0x06091e7c
	System.Void .ctor(); // 0x06092144
	System.Void <OnInit>b__7_0(FairyGUI.EventContext ctx); // 0x060921d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemIconBox.<>c__DisplayClass10_0 : System.Object
{
	System.Collections.Generic.KeyValuePair<System.String,System.Action> info; // 0x10
	WizardGames.Soc.SocClient.Ui.UiItemIconBox <>4__this; // 0x20
	System.Void .ctor(); // 0x06091ab0
	System.Void <OnBtnsItemRenderer>b__0(FairyGUI.EventContext ctx); // 0x06092248
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemIconBox.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MsgItemBoxInfo info; // 0x10
	System.Void .ctor(); // 0x06091e14
	System.Void <ShowMsgBox>b__0(WizardGames.Soc.SocClient.Ui.UiItemIconBox win); // 0x06092544
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MsgItemBoxInfo : System.Object
{
	System.String title; // 0x10
	System.String msg; // 0x18
	System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String,System.Action>> btns; // 0x20
	System.Collections.Generic.List<System.Int64> itemIds; // 0x28
	System.Boolean HasCloseBtn; // 0x30
	System.Void .ctor(); // 0x060925c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemPopup : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GObjectPool iconLoaderPool; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.GameItemPopup.UiItemPopupBinder rootBinder; // 0x340
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x348
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.GameItemPopup.ComIconLineBinder> lineBinders; // 0x350
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.GameItemPopup.ComIconAdapterBinder> iconBinders; // 0x358
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiItemPopup.ItemGroupInfo> infos; // 0x360
	System.Boolean isMuiltLine; // 0x368
	System.Void OnInit(); // 0x0609267c
	System.Void OnDisable(); // 0x06092d3c
	System.Void OnClickIcon(WizardGames.Soc.SocClient.Ui.ComBaseIcon clickIcon); // 0x06092e90
	System.Int32 GetIconLineIndex(FairyGUI.GObject obj); // 0x0609319c
	System.Void IconRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x06093414
	System.Void IconRowRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x0609384c
	System.Void Refresh(); // 0x06093fd4
	WizardGames.Soc.SocClient.Ui.UiItemPopup SetItems(WizardGames.Soc.SocClient.Ui.UiItemPopup.ItemGroupInfo group); // 0x060943a8
	WizardGames.Soc.SocClient.Ui.UiItemPopup SetItems(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiItemPopup.ItemGroupInfo> groups); // 0x060944dc
	WizardGames.Soc.SocClient.Ui.UiItemPopup SetPopup(System.Int32 msgBoxCfgId, System.Collections.Generic.List<System.Action> callbacks); // 0x060945c0
	static WizardGames.Soc.SocClient.Ui.UiItemPopup Open(); // 0x06094890
	System.Void .ctor(); // 0x06094960
	FairyGUI.GObject <OnInit>b__8_0(System.String url); // 0x06094ae8
	System.Void <OnInit>b__8_1(FairyGUI.GObject obj); // 0x06094c64
	System.Void <OnInit>b__8_2(); // 0x06094e74
	FairyGUI.GObject <IconRowRenderer>b__13_0(System.String url); // 0x06094ee0
	System.Void <IconRowRenderer>b__13_1(FairyGUI.GObject obj); // 0x06094f70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemPopup.ItemGroupInfo : System.Object
{
	System.String <Title>k__BackingField; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.ItemConfig> <Items>k__BackingField; // 0x18
	System.Collections.Generic.List<System.Int32> <ItemsCount>k__BackingField; // 0x20
	System.String get_Title(); // 0x060950ec
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.ItemConfig> get_Items(); // 0x06095150
	System.Collections.Generic.List<System.Int32> get_ItemsCount(); // 0x060951b4
	System.Void .ctor(System.String title, System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.ItemConfig> items); // 0x06095218
	System.Void .ctor(System.String title, System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.ItemConfig> items, System.Collections.Generic.List<System.Int32> itemsCount); // 0x060952bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemPopup.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	System.Void .ctor(); // 0x06093134
	System.Void <OnClickIcon>b__0(); // 0x06095384
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AttrData : System.Object
{
	System.String AttrName; // 0x10
	System.String StrValue; // 0x18
	System.Single CurValue; // 0x20
	System.Single CurMaxValue; // 0x24
	System.Single MaxValue; // 0x28
	System.Boolean ShowAsPercent; // 0x2c
	System.Boolean ShowValueWithColor; // 0x2d
	System.Boolean ShowValueWithPM; // 0x2e
	System.String colorPositive; // 0x30
	System.String colorNegative; // 0x38
	System.String numFormat; // 0x40
	System.String valuePrefix; // 0x48
	System.String valuePostfix; // 0x50
	WizardGames.Soc.Common.Data.Attr.AttributeDisplay attrData; // 0x58
	System.String get_AttrDesc(); // 0x060953f8
	System.Boolean SetAttrData(WizardGames.Soc.SocClient.Ui.ItemAttrEnum attr); // 0x06095470
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.ItemAttrEnum attr, System.Single curV); // 0x060955d8
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.ItemAttrEnum attr, System.Single curV, System.Single curMaxV, System.Single maxV); // 0x060956c4
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.ItemAttrEnum attr, System.String strV); // 0x060957b0
	WizardGames.Soc.SocClient.Ui.AttrData WithPercent(); // 0x06095888
	WizardGames.Soc.SocClient.Ui.AttrData WithColor(System.String positive, System.String negative); // 0x060958f4
	WizardGames.Soc.SocClient.Ui.AttrData WithPM(); // 0x060959bc
	WizardGames.Soc.SocClient.Ui.AttrData WithFormat(System.String format); // 0x06095a28
	WizardGames.Soc.SocClient.Ui.AttrData WithPostfix(System.String postfix); // 0x06095ac0
	WizardGames.Soc.SocClient.Ui.AttrData WithEnginePartTier(System.Int32 tier); // 0x06095b58
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComItemAttrs : System.Object
{
	FairyGUI.GComponent comAttr; // 0x10
	FairyGUI.GList listAttr; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.AttrData> attrs; // 0x20
	System.Boolean isSubTips; // 0x28
	static System.Collections.Generic.List<System.String> attrStr; // 0x0
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.ItemAttrEnum> Name2FoodAttr; // 0x8
	FairyGUI.GComponent get_comBoard(); // 0x06095c58
	System.Void .ctor(FairyGUI.GComponent comAttrBoard, System.Boolean isVirtual, System.Boolean isSubTips); // 0x06095cbc
	System.Void OnClickItem(FairyGUI.EventContext ctx); // 0x06095f5c
	System.Void ListItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x06096158
	System.Boolean SetItem(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg, WizardGames.Soc.Common.CustomType.BaseItemNode itemInst, System.Boolean resizeToFit); // 0x0609681c
	static System.Void ShowPropertiesChange(System.Collections.Generic.List<System.Int32> properties, System.Collections.Generic.List<System.Single> propertiesNums); // 0x06096d64
	static System.Void .cctor(); // 0x060972b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComItemAttrs.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.ComItemAttrs.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__8_0; // 0x8
	static System.Void .cctor(); // 0x06097464
	System.Void .ctor(); // 0x060974c8
	System.Void <.ctor>b__8_0(FairyGUI.EventContext ctx); // 0x06097530
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Ui.IItemTipsBoard : 
{
	
	FairyGUI.GComponent get_ComBoard(); // 0x060975b4
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain, System.Boolean isSubTips); // 0x0552af28
	System.Void SetItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, WizardGames.Soc.Common.Data.DataItem.ItemConfig tbItem); // 0x0552af00
	System.Void SetItem(WizardGames.Soc.Common.Data.resource.OBJGenaral item); // 0x05523a54
	System.Void SetItem(WizardGames.Soc.Common.Data.Reputation.ReputationSelectConfig item); // 0x05523a54
	System.Void SetItem(WizardGames.Soc.SocClient.Talent.TalentNode item); // 0x05523a54
	System.Void OnEnable(); // 0x06097618
	System.Void OnDisable(); // 0x06097678
	System.Void UnChooseAllBoardIcons(); // 0x060976d8
	System.Single GetBoardHeight(); // 0x06097738
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ItemAttrEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum GunDamage = 1000;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum GunAccuracy = 1001;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum GunRecoil = 1002;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum GunFireRate = 1003;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum GunRange = 1004;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum MeleeDamage = 1100;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum MeleeSwingSpeed = 1101;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum MeleeRange = 1102;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum MeleeOreGather = 1103;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum MeleeTreeGather = 1104;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum MeleeFleshGather = 1105;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum MeleeOreAttack = 1106;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum MeleeTreeAttack = 1107;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum MeleeFleshAttack = 1108;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum MeleeAttackSize = 1109;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum FoodHealth = 1200;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum FoodHealthOverTime = 1201;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum FoodRadiation = 1202;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum FoodCalories = 1203;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum FoodHydration = 1204;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum FoodBleeding = 1205;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum FoodRadiationExposure = 1206;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum FoodPoison = 1207;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum ClothBullet = 1300;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum ClothMelee = 1301;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum ClothBite = 1302;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum ClothRadiation = 1303;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum ClothCold = 1304;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum ClothExplosion = 1305;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum PartRecoil = 1400;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum PartZoom = 1401;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum PartFireRate = 1402;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum PartVelocity = 1403;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum PartDamage = 1404;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum PartAccuracy = 1405;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum PartMagazine = 1406;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum SeedHarvests = 1500;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum SeedWaterResilience = 1501;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum SeedLightResilience = 1502;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum SeedGroundResilience = 1503;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum SeedTemperatureResilience = 1504;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum BulletDamage = 1600;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum BulletVelocity = 1601;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum BulletFalloff = 1602;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum BulletNum = 1603;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum MedicalHealth = 1700;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum MedicalHealthOverTime = 1701;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum MedicalRadiation = 1702;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum MedicalCalories = 1703;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum MedicalHydration = 1704;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum MedicalBleeding = 1705;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum MedicalRadiationExposure = 1706;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum ExplosiveDmg = 1800;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum ExplosiveLethality = 1801;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum ExplosiveThrowDistance = 1802;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum ExplosiveFuseLength = 1804;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum ExplosiveBlastRadius = 1805;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum ElectricReq = 1900;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum ElectricGen = 1902;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum ElectricCharge = 1903;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum ElectricCapacity = 1904;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum ElectricWaterReq = 1905;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum EnginePartTier = 2000;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum SpeedAdditon = 2001;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum AccelerateAdditon = 2002;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum FuelAdditon = 2003;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum HorseProtection = 2100;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum RiderProtection = 2101;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum MaxSpeed = 2102;
	static WizardGames.Soc.SocClient.Ui.ItemAttrEnum Backpack = 2103;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardAttr : System.Object, WizardGames.Soc.SocClient.Ui.IItemTipsBoard
{
	FairyGUI.GComponent comAttr; // 0x10
	WizardGames.Soc.SocClient.Ui.ComItemAttrs attrs; // 0x18
	FairyGUI.GComponent get_ComBoard(); // 0x06097974
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain, System.Boolean isSubTips); // 0x060979d8
	System.Void SetItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, WizardGames.Soc.Common.Data.DataItem.ItemConfig tbItem); // 0x06097b28
	System.Void SetItem(WizardGames.Soc.Common.Data.resource.OBJGenaral item); // 0x06097ca0
	System.Void SetItem(WizardGames.Soc.SocClient.Talent.TalentNode item); // 0x06097d28
	System.Void SetItem(WizardGames.Soc.Common.Data.Reputation.ReputationSelectConfig item); // 0x06097db0
	System.Void .ctor(); // 0x06097e38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardBtns : System.Object, WizardGames.Soc.SocClient.Ui.IItemTipsBoard
{
	static SocLogger logger; // 0x0
	FairyGUI.GList listBtns; // 0x10
	FairyGUI.Controller listController; // 0x18
	WizardGames.Soc.Common.CustomType.BaseItemNode curInstItem; // 0x20
	WizardGames.Soc.Common.Data.DataItem.ItemConfig curItemConfig; // 0x28
	System.Boolean isSubTips; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiItemTipsBoardBtns.TipsBtnInfo> curBtns; // 0x38
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.UiItemTipsBoardBtns.TipsBtnInfo> btnMap; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiItemTipsBoardBtns.TipsBtnInfo> allBtns; // 0x48
	FairyGUI.GComponent get_ComBoard(); // 0x06097fcc
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain, System.Boolean isSubTips); // 0x06098030
	WizardGames.Soc.SocClient.Ui.UiItemTipsBoardBtns.TipsBtnInfo AddBtn(System.Int32 index); // 0x06098548
	System.Void SetItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, WizardGames.Soc.Common.Data.DataItem.ItemConfig tbItem); // 0x06098718
	System.Void SetItem(WizardGames.Soc.Common.Data.resource.OBJGenaral item); // 0x06099620
	System.Void SetItem(WizardGames.Soc.SocClient.Talent.TalentNode item); // 0x060996a8
	System.Void SetItem(WizardGames.Soc.Common.Data.Reputation.ReputationSelectConfig item); // 0x06099730
	System.Int32 CompareBtns(WizardGames.Soc.SocClient.Ui.UiItemTipsBoardBtns.TipsBtnInfo a, WizardGames.Soc.SocClient.Ui.UiItemTipsBoardBtns.TipsBtnInfo b); // 0x060997b8
	System.Void SetInstBtns(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x06098940
	System.Void CheckAddInfoItem(); // 0x06099b34
	System.Void SetCfgBtns(WizardGames.Soc.Common.Data.DataItem.ItemConfig item); // 0x060994d4
	System.Void BtnRenderer(System.Int32 index, FairyGUI.GObject item); // 0x06099e4c
	static System.Boolean OnClickItemPartDrop(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609a378
	static System.Boolean OnClickItemSplit(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609a42c
	static System.Boolean OnClickItemMoveToInventorySome(WizardGames.Soc.Common.Data.DataItem.ItemConfig ic); // 0x0609a4e4
	static System.Boolean OnClickConfigMoveToBoxSome(WizardGames.Soc.Common.Data.DataItem.ItemConfig ic); // 0x0609a594
	static System.Boolean OnClickItemMoveToInventory(WizardGames.Soc.Common.Data.DataItem.ItemConfig ic); // 0x0609a644
	static System.Boolean OnClickNormalUse(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609a6f4
	static System.Boolean OnClickItemUseEquip(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609ae54
	static System.Boolean OnClickDeployUse(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609af4c
	static System.Boolean CondWaterBottleBtn(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609aff0
	static System.Boolean OnClickHoldModelUse(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609b0c4
	static System.Boolean OnClickDropWater(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609b2ec
	static System.Boolean OnClickItemLearnBlueprint(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609b50c
	static System.Boolean OnClickUnloadAmmo(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609b7b8
	static System.Boolean OnClickUnloadPart(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609b8a0
	static System.Boolean OnClickClothTakeOff(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609be24
	static System.Boolean OnClickMoveToBackpack(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609c220
	static System.Boolean OnClickMoveToOtherside(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609c47c
	static System.Boolean OnClickMoveToSafeBox(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609c9f8
	static System.Boolean OnClickEditIC(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609ca5c
	static System.Boolean OnClickSeed(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609cb18
	static System.Boolean OnClickRecharge(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609cbc0
	static System.Boolean CondRecharge(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609cf10
	static System.Boolean OnClickEquipBelt(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609d00c
	static System.Boolean OnClickUnloadBelt(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609d1d4
	static System.Boolean OnClickCampTent(WizardGames.Soc.Common.Data.DataItem.ItemConfig curItem); // 0x0609d46c
	static System.Boolean OnClickMovetoCabinet(WizardGames.Soc.Common.Data.DataItem.ItemConfig curItem); // 0x0609d664
