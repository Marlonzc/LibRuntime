	System.Void UpdataSecondIcon(); // 0x061ad760
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> ChoseEquipPlanDic(); // 0x061b01f8
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> ChoseCostumePlanDic(); // 0x061b02b0
	System.Void ShowSelectData(System.Boolean isShow); // 0x061ade70
	System.Void SetCollect(System.String pageName); // 0x061b04ec
	System.Void SetShare(System.String pageName); // 0x061b0574
	System.Void OnClickShareBack(); // 0x061b05fc
	System.Void OnClickCollectBack(); // 0x061b090c
	System.Void OnReceiveCollect(); // 0x061b0b9c
	System.Void OnSortRefreshBack(System.Int32 index); // 0x061b0c10
	System.Void RefreshPlan(); // 0x061b0d28
	System.Void InitTempPlan(); // 0x061ac400
	System.Void OnEnable(); // 0x061b0e28
	System.Void OnDisable(); // 0x061b1bf8
	System.Void OnDestroy(); // 0x061b1e2c
	System.Void BeforeClose(); // 0x061b1f58
	System.Void RefreshEquipBtn(); // 0x061afb00
	System.Void SetLimitTimeTxt(); // 0x061b0368
	System.Void RefreshCollectBtn(); // 0x061afc78
	System.Void SetEquipState(System.String state); // 0x061b2354
	System.Void SetEquipSkinDesc(); // 0x061afe28
	System.Void RefreshDescription(System.String title, System.String desc, System.Int32 level); // 0x061b256c
	System.Void UpdatePrimaryTabConfig(); // 0x061ad2a0
	System.Void MakeFullScreen(); // 0x061b2648
	System.Void InitDescriptionCom(); // 0x061acac8
	System.Void InitSkinWeaponAppWelfareCom(); // 0x061acde8
	System.Void RefreshSkinWeaponAppWelfareInfo(); // 0x061b0040
	System.Void RefreshInUseTextPrivilegeInfo(); // 0x061b23e4
	System.Void OnReceiveArmorSkinInfo(); // 0x061b26b0
	System.Void OnReceiveEquipResult(); // 0x061b2710
	System.Void UpdateModifyState(); // 0x061b00bc
	System.Void OnClickModifyBtn(); // 0x061b29b0
	System.Void OnClickEquipBtn(); // 0x061b2a64
	System.Void OnClickPreviewBtn(); // 0x061b2b98
	System.Void RefreshEquipBtnGroup(); // 0x061af170
	System.Void OnClickSwtichLightBtn(); // 0x061b32ec
	System.Void OnClickSwitchSexBtn(); // 0x061b3568
	System.Void OnClickHighLightBtn(); // 0x061b370c
	System.Void OnClickActionBtn(); // 0x061b38e0
	System.Void OnClickEnterAction(); // 0x061b3a1c
	System.Void OnClickShowAction(); // 0x061b3c38
	System.Void InitModel(); // 0x061b1258
	System.Void RefreshModel(); // 0x061b14b0
	System.Void OnFps10Update(System.Single dt); // 0x061b3e54
	System.Void OnFps30Update(System.Single dt); // 0x061b4104
	System.Void SetLoaderImgShader(); // 0x061b3ee4
	System.Void .ctor(); // 0x061b41a4
	WizardGames.Soc.SocClient.GoLoader.DisplayModel <OnInit>b__94_0(); // 0x061b451c
	System.Void <OnInit>b__94_1(); // 0x061b45c4
	System.Void <OnInit>b__94_2(FairyGUI.EventContext ctx); // 0x061b46f4
	System.Void <OnInit>b__94_3(FairyGUI.EventContext ctx); // 0x061b476c
	System.Void <OnInit>b__94_4(FairyGUI.EventContext ctx); // 0x061b47e4
	System.Void <OnInit>b__94_5(FairyGUI.EventContext ctx); // 0x061b485c
	System.Int32 <UpdateOnePartAllSkin>b__104_0(WizardGames.Soc.Common.Data.resource.OBJSkin x, WizardGames.Soc.Common.Data.resource.OBJSkin y); // 0x061b48d4
	System.Int32 <UpdateOnePartAllSkin>b__104_1(WizardGames.Soc.Common.Data.resource.OBJSkin x, WizardGames.Soc.Common.Data.resource.OBJSkin y); // 0x061b4d74
	System.Void <OnClickShareBack>b__115_0(); // 0x061b517c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiGameSkinEquip.ESkinOrderType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiGameSkinEquip.ESkinOrderType Default = 0;
	static WizardGames.Soc.SocClient.Ui.UiGameSkinEquip.ESkinOrderType Quality = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiGameSkinEquip.ENewSkinOrderType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiGameSkinEquip.ENewSkinOrderType Default = 0;
	static WizardGames.Soc.SocClient.Ui.UiGameSkinEquip.ENewSkinOrderType GetTime = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiGameSkinEquip.EFirstTabType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiGameSkinEquip.EFirstTabType Costume = 0;
	static WizardGames.Soc.SocClient.Ui.UiGameSkinEquip.EFirstTabType Equip = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameSkinEquip.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiGameSkinEquip.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Data.DataItem.SkinArmorConfig> <>9__103_0; // 0x8
	static System.Comparison<WizardGames.Soc.Common.Data.DataItem.SkinArmorType> <>9__133_0; // 0x10
	static System.Void .cctor(); // 0x061b51f8
	System.Void .ctor(); // 0x061b525c
	System.Int32 <UpdateSecondaryTabConfig>b__103_0(WizardGames.Soc.Common.Data.DataItem.SkinArmorConfig config1, WizardGames.Soc.Common.Data.DataItem.SkinArmorConfig config2); // 0x061b52c4
	System.Int32 <UpdatePrimaryTabConfig>b__133_0(WizardGames.Soc.Common.Data.DataItem.SkinArmorType config1, WizardGames.Soc.Common.Data.DataItem.SkinArmorType config2); // 0x061b5358
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.GPlayerHomeWeaponItem : FairyGUI.GComponent
{
	FairyGUI.GList <ParentListCom>k__BackingField; // 0x288
	FairyGUI.GLoader loaderIcon; // 0x290
	FairyGUI.GTextField titleTxt; // 0x298
	FairyGUI.Controller equipCtr; // 0x2a0
	FairyGUI.Controller statusCtr; // 0x2a8
	FairyGUI.Controller collectCtr; // 0x2b0
	FairyGUI.Controller timeLimitCtr; // 0x2b8
	FairyGUI.Controller redDotCtr; // 0x2c0
	FairyGUI.Controller rarityCtr; // 0x2c8
	FairyGUI.Controller styleCtr; // 0x2d0
	WizardGames.Soc.SocClient.Ui.UiChosePlanPop <Owner>k__BackingField; // 0x2d8
	System.Int32 <SkinId>k__BackingField; // 0x2e0
	WizardGames.Soc.Common.Data.DataItem.SkinWeaponConfig <OriginSkinCfg>k__BackingField; // 0x2e8
	WizardGames.Soc.Common.Data.DataItem.ItemConfig <OriginSkinItemCfg>k__BackingField; // 0x2f0
	FairyGUI.GComponent <SkinItem>k__BackingField; // 0x2f8
	WizardGames.Soc.SocClient.Ui.GPlayerHomeWeaponItem.EWeaponSkinType <SkinType>k__BackingField; // 0x300
	WizardGames.Soc.Common.Data.DataItem.SkinConfig <SkinConfig>k__BackingField; // 0x308
	FairyGUI.GLoader appWelfareIconGLoader; // 0x310
	System.Void set_ParentListCom(FairyGUI.GList value); // 0x061b53ec
	WizardGames.Soc.SocClient.Ui.UiChosePlanPop get_Owner(); // 0x061b546c
	System.Void set_Owner(WizardGames.Soc.SocClient.Ui.UiChosePlanPop value); // 0x061b54d0
	System.Void set_SkinId(System.Int32 value); // 0x061b5550
	System.Int32 get_SkinId(); // 0x061b55c8
	WizardGames.Soc.Common.Data.DataItem.SkinWeaponConfig get_OriginSkinCfg(); // 0x061b562c
	System.Void set_OriginSkinCfg(WizardGames.Soc.Common.Data.DataItem.SkinWeaponConfig value); // 0x061b5690
	System.Void set_OriginSkinItemCfg(WizardGames.Soc.Common.Data.DataItem.ItemConfig value); // 0x061b5710
	FairyGUI.GComponent get_SkinItem(); // 0x061b5790
	System.Void set_SkinItem(FairyGUI.GComponent value); // 0x061b57f4
	WizardGames.Soc.SocClient.Ui.GPlayerHomeWeaponItem.EWeaponSkinType get_SkinType(); // 0x061b5874
	System.Void set_SkinType(WizardGames.Soc.SocClient.Ui.GPlayerHomeWeaponItem.EWeaponSkinType value); // 0x061b58d8
	System.Void set_SkinConfig(WizardGames.Soc.Common.Data.DataItem.SkinConfig value); // 0x061b5950
	WizardGames.Soc.Common.Data.DataItem.SkinConfig get_SkinConfig(); // 0x061b59d0
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x061b5a34
	System.Void UpdataOriginSkin(WizardGames.Soc.SocClient.Ui.UiChosePlanPop owner, FairyGUI.GList skinList, WizardGames.Soc.Common.Data.DataItem.SkinWeaponConfig config, System.Boolean owned); // 0x061b607c
	System.Void UpdateOriginSkinCom(); // 0x061b63cc
	System.Void RefreshAppWelfareInfo(System.Int64 skinId); // 0x061b6d10
	System.Void UpdataSkin(WizardGames.Soc.SocClient.Ui.UiChosePlanPop owner, FairyGUI.GList skinList, WizardGames.Soc.Common.Data.DataItem.SkinConfig config, System.Boolean owned); // 0x061b6ea8
	System.Void RenderSkinListItem(); // 0x061b71a0
	System.Void UpdataOriginSkinEquipState(); // 0x061b65bc
	System.Void UpdataSkinEquipState(); // 0x061b73cc
	System.Void UpdateSelect(); // 0x061b69d4
	System.Void SetNewState(System.Boolean isShow); // 0x061b6778
	System.Void SetEquipState(System.String page); // 0x061b7500
	System.Void SetRarityState(System.Int32 level); // 0x061b66f0
	System.Void UpdataCollect(); // 0x061b6830
	System.Void UpdataTimeLimit(); // 0x061b6b50
	System.Void SetSelect(System.Boolean isSelect); // 0x061b7588
	System.Void OnSkinListItemClick(FairyGUI.EventContext context); // 0x061b7660
	System.Void .ctor(); // 0x061b79b0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.GPlayerHomeWeaponItem.EWeaponSkinType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.GPlayerHomeWeaponItem.EWeaponSkinType None = 0;
	static WizardGames.Soc.SocClient.Ui.GPlayerHomeWeaponItem.EWeaponSkinType OriginSkin = 1;
	static WizardGames.Soc.SocClient.Ui.GPlayerHomeWeaponItem.EWeaponSkinType Skin = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.GSkinArmorItem : FairyGUI.GComponent
{
	WizardGames.Soc.Common.Data.DataItem.SkinArmorConfig <OriginSkinCfg>k__BackingField; // 0x288
	WizardGames.Soc.Common.Data.DataItem.ItemConfig <OriginSkinItemCfg>k__BackingField; // 0x290
	WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor <Owner>k__BackingField; // 0x298
	FairyGUI.GList <ParentListCom>k__BackingField; // 0x2a0
	FairyGUI.GLoader appWelfareIconGLoader; // 0x2a8
	FairyGUI.GComponent skinItem; // 0x2b0
	WizardGames.Soc.SocClient.Ui.GSkinArmorItem.EArmorSkinType <SkinType>k__BackingField; // 0x2b8
	System.Int32 <SkinId>k__BackingField; // 0x2bc
	WizardGames.Soc.Common.Data.DataItem.SkinConfig skinConfig; // 0x2c0
	FairyGUI.GLoader loaderIcon; // 0x2c8
	FairyGUI.GTextField titleTxt; // 0x2d0
	FairyGUI.Controller equipCtr; // 0x2d8
	FairyGUI.Controller statusCtr; // 0x2e0
	FairyGUI.Controller collectCtr; // 0x2e8
	FairyGUI.Controller timeLimitCtr; // 0x2f0
	FairyGUI.Controller redDotCtr; // 0x2f8
	FairyGUI.Controller rarityCtr; // 0x300
	FairyGUI.Controller styleCtr; // 0x308
	WizardGames.Soc.Common.Data.DataItem.SkinArmorConfig get_OriginSkinCfg(); // 0x061b7a18
	System.Void set_OriginSkinCfg(WizardGames.Soc.Common.Data.DataItem.SkinArmorConfig value); // 0x061b7a7c
	WizardGames.Soc.Common.Data.DataItem.ItemConfig get_OriginSkinItemCfg(); // 0x061b7afc
	System.Void set_OriginSkinItemCfg(WizardGames.Soc.Common.Data.DataItem.ItemConfig value); // 0x061b7b60
	WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor get_Owner(); // 0x061b7be0
	System.Void set_Owner(WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor value); // 0x061b7c44
	FairyGUI.GList get_ParentListCom(); // 0x061b7cc4
	System.Void set_ParentListCom(FairyGUI.GList value); // 0x061b7d28
	WizardGames.Soc.SocClient.Ui.GSkinArmorItem.EArmorSkinType get_SkinType(); // 0x061b7da8
	System.Void set_SkinType(WizardGames.Soc.SocClient.Ui.GSkinArmorItem.EArmorSkinType value); // 0x061b7e0c
	System.Void set_SkinId(System.Int32 value); // 0x061b7e84
	System.Int32 get_SkinId(); // 0x061b7efc
	System.Boolean get_IsEquip(); // 0x061b7f60
	System.Boolean get_IsLock(); // 0x061b7ff0
	System.Boolean get_IsSelect(); // 0x061b8080
	System.Boolean get_IsCollect(); // 0x061b8134
	System.Boolean get_IsExpired(); // 0x061b81c4
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x061b8254
	System.Void UpdataOriginSkin(WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor owner, FairyGUI.GList skinList, WizardGames.Soc.Common.Data.DataItem.SkinArmorConfig config, System.Boolean owned); // 0x061b8608
	System.Void UpdateOriginSkinCom(); // 0x061b8950
	System.Void UpdataSkin(WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor owner, FairyGUI.GList skinList, WizardGames.Soc.Common.Data.DataItem.SkinConfig config, System.Boolean owned); // 0x061b9a7c
	System.Void RenderSkinListItem(); // 0x061b9cdc
	System.Void RefreshAppWelfareInfo(System.Int64 skinId); // 0x061b98e4
	System.Void UpdataSkinEquipState(); // 0x061b9efc
	System.Void SetNewState(System.Boolean isShow); // 0x061b8e10
	System.Void SetEquipState(System.String page); // 0x061ba0b4
	System.Void SetRarityState(System.Int32 level); // 0x061b8c58
	System.Void UpdataOriginEquipState(); // 0x061b8ce0
	System.Void OnSkinListItemClick(FairyGUI.EventContext context); // 0x061b906c
	System.Void CheckIsCoverServerData(System.Boolean isWear, System.Int32 part); // 0x061ba238
	System.Void OnSkinWearChange(); // 0x061ba13c
	System.Void UpdataSelect(System.Boolean isSelect); // 0x061b9690
	System.Void UpdataCollect(); // 0x061b8ec8
	System.Void UpdataTimeLimit(); // 0x061b9724
	System.Void .ctor(); // 0x061ba47c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.GSkinArmorItem.EArmorSkinType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.GSkinArmorItem.EArmorSkinType None = 0;
	static WizardGames.Soc.SocClient.Ui.GSkinArmorItem.EArmorSkinType OriginSkin = 1;
	static WizardGames.Soc.SocClient.Ui.GSkinArmorItem.EArmorSkinType Skin = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.GSkinOptionTip : System.Object
{
	System.Int64 lastClickTime; // 0x10
	FairyGUI.GComponent rootCom; // 0x18
	FairyGUI.GList optionList; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.GSkinOptionTip.OptionData> showOptionDataList; // 0x28
	System.Action onChange; // 0x30
	WizardGames.Soc.SocClient.Ui.GSkinOptionTip.EShowType showType; // 0x38
	System.Func<WizardGames.Soc.SocClient.GoLoader.DisplayModel> getDisplayModelFunc; // 0x40
	System.Int32 hideOptionId; // 0x48
	System.Void Init(FairyGUI.GComponent root, System.Action onChangeBack, System.Func<WizardGames.Soc.SocClient.GoLoader.DisplayModel> getDisplayModelFunc, WizardGames.Soc.SocClient.Ui.GSkinOptionTip.EShowType tempShowType); // 0x061ac10c
	System.Void OnClickMask(FairyGUI.EventContext context); // 0x061baa5c
	System.Void InitOptionData(); // 0x061ba4e4
	System.Void ChangeVisible(); // 0x061b4630
	System.String ChoseOptionItem(System.Int32 index); // 0x061bac18
	System.Void OnRenderOption(System.Int32 index, FairyGUI.GObject obj); // 0x061bad3c
	System.Void OnClickOptionBack(FairyGUI.EventContext context); // 0x061bb2c8
	System.Void CheckIgnoreConfig(); // 0x061bb8a4
	System.Void OnChangeSuccess(); // 0x061bbba8
	System.Void .ctor(); // 0x061ac050
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.GSkinOptionTip.EShowType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.GSkinOptionTip.EShowType All = 0;
	static WizardGames.Soc.SocClient.Ui.GSkinOptionTip.EShowType Lobby = 1;
	static WizardGames.Soc.SocClient.Ui.GSkinOptionTip.EShowType Game = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.GSkinOptionTip.OptionData : System.Object
{
	System.Boolean <IsType>k__BackingField; // 0x10
	WizardGames.Soc.Common.Data.collection.OBJRoleShowOption <OptionCfg>k__BackingField; // 0x18
	System.Void set_IsType(System.Boolean value); // 0x061bbc20
	System.Boolean get_IsType(); // 0x061bbc9c
	System.Void set_OptionCfg(WizardGames.Soc.Common.Data.collection.OBJRoleShowOption value); // 0x061bbd00
	WizardGames.Soc.Common.Data.collection.OBJRoleShowOption get_OptionCfg(); // 0x061bbd80
	System.Void .ctor(System.Boolean isType, WizardGames.Soc.Common.Data.collection.OBJRoleShowOption data); // 0x061baae4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.GSkinOptionTip.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.GSkinOptionTip.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.GSkinOptionTip.OptionData> <>9__11_0; // 0x8
	static System.Void .cctor(); // 0x061bbde4
	System.Void .ctor(); // 0x061bbe48
	System.Int32 <InitOptionData>b__11_0(WizardGames.Soc.SocClient.Ui.GSkinOptionTip.OptionData x, WizardGames.Soc.SocClient.Ui.GSkinOptionTip.OptionData y); // 0x061bbeb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.GSkinPrimaryTabItem : FairyGUI.GButton
{
	FairyGUI.GTextField <Title>k__BackingField; // 0x318
	FairyGUI.GTextField <Title01>k__BackingField; // 0x320
	FairyGUI.GTextField <MaskText>k__BackingField; // 0x328
	FairyGUI.GLoader <IconLoader>k__BackingField; // 0x330
	FairyGUI.Controller <Status>k__BackingField; // 0x338
	FairyGUI.Controller <Owned>k__BackingField; // 0x340
	System.Void set_Title(FairyGUI.GTextField value); // 0x061bbfd4
	System.Void set_Title01(FairyGUI.GTextField value); // 0x061bc054
	System.Void set_MaskText(FairyGUI.GTextField value); // 0x061bc0d4
	System.Void set_IconLoader(FairyGUI.GLoader value); // 0x061bc154
	System.Void set_Status(FairyGUI.Controller value); // 0x061bc1d4
	System.Void set_Owned(FairyGUI.Controller value); // 0x061bc254
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x061bc2d4
	System.Void .ctor(); // 0x061bc674
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.GSkinWeaponItem : FairyGUI.GComponent
{
	FairyGUI.GList <ParentListCom>k__BackingField; // 0x288
	FairyGUI.GLoader loaderIcon; // 0x290
	FairyGUI.GTextField titleTxt; // 0x298
	FairyGUI.Controller equipCtr; // 0x2a0
	FairyGUI.Controller statusCtr; // 0x2a8
	FairyGUI.Controller collectCtr; // 0x2b0
	FairyGUI.Controller timeLimitCtr; // 0x2b8
	FairyGUI.Controller redDotCtr; // 0x2c0
	FairyGUI.Controller rarityCtr; // 0x2c8
	FairyGUI.Controller styleCtr; // 0x2d0
	FairyGUI.Controller showHangingCtr; // 0x2d8
	FairyGUI.GLoader hangingsIcon; // 0x2e0
	WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon <Owner>k__BackingField; // 0x2e8
	System.Int32 <SkinId>k__BackingField; // 0x2f0
	WizardGames.Soc.Common.Data.DataItem.SkinWeaponConfig <OriginSkinCfg>k__BackingField; // 0x2f8
	WizardGames.Soc.Common.Data.DataItem.ItemConfig <OriginSkinItemCfg>k__BackingField; // 0x300
	FairyGUI.GComponent <SkinItem>k__BackingField; // 0x308
	WizardGames.Soc.SocClient.Ui.GSkinWeaponItem.EWeaponSkinType <SkinType>k__BackingField; // 0x310
	WizardGames.Soc.Common.Data.DataItem.SkinConfig <SkinConfig>k__BackingField; // 0x318
	WizardGames.Soc.Common.Data.resource.OBJSkin skinCfg; // 0x320
	FairyGUI.GLoader appWelfareIconGLoader; // 0x328
	FairyGUI.GList get_ParentListCom(); // 0x061bc6dc
	System.Void set_ParentListCom(FairyGUI.GList value); // 0x061bc740
	WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon get_Owner(); // 0x061bc7c0
	System.Void set_Owner(WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon value); // 0x061bc824
	System.Void set_SkinId(System.Int32 value); // 0x061bc8a4
	System.Int32 get_SkinId(); // 0x061bc91c
	WizardGames.Soc.Common.Data.DataItem.SkinWeaponConfig get_OriginSkinCfg(); // 0x061bc980
	System.Void set_OriginSkinCfg(WizardGames.Soc.Common.Data.DataItem.SkinWeaponConfig value); // 0x061bc9e4
	WizardGames.Soc.Common.Data.DataItem.ItemConfig get_OriginSkinItemCfg(); // 0x061bca64
	System.Void set_OriginSkinItemCfg(WizardGames.Soc.Common.Data.DataItem.ItemConfig value); // 0x061bcac8
	System.Boolean get_IsEquip(); // 0x061bcb48
	System.Boolean get_IsLock(); // 0x061bcbd8
	System.Boolean get_IsCollect(); // 0x061bcc68
	FairyGUI.GComponent get_SkinItem(); // 0x061bccf8
	System.Void set_SkinItem(FairyGUI.GComponent value); // 0x061bcd5c
	WizardGames.Soc.SocClient.Ui.GSkinWeaponItem.EWeaponSkinType get_SkinType(); // 0x061bcddc
	System.Void set_SkinType(WizardGames.Soc.SocClient.Ui.GSkinWeaponItem.EWeaponSkinType value); // 0x061bce40
	System.Void set_SkinConfig(WizardGames.Soc.Common.Data.DataItem.SkinConfig value); // 0x061bceb8
	WizardGames.Soc.Common.Data.DataItem.SkinConfig get_SkinConfig(); // 0x061bcf38
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x061bcf9c
	System.Void UpdataOriginSkin(WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon owner, FairyGUI.GList skinList, WizardGames.Soc.Common.Data.DataItem.SkinWeaponConfig config, System.Boolean owned); // 0x061bd6d0
	System.Void UpdateOriginSkinCom(); // 0x061bdae0
	System.Void RefreshAppWelfareInfo(System.Int64 skinId); // 0x061be414
	System.Void UpdataSkin(WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon owner, FairyGUI.GList skinList, WizardGames.Soc.Common.Data.DataItem.SkinConfig config, System.Boolean owned); // 0x061be7cc
	System.Void RenderSkinListItem(); // 0x061beba8
	System.Void UpdateHangings(); // 0x061be5ac
	System.Void UpdateSelect(); // 0x061be120
	System.Void UpdataSkinEquipState(); // 0x061bede4
	System.Void UpdataOriginEquipState(); // 0x061bdd98
	System.Void SetNewState(System.Boolean isShow); // 0x061bdec4
	System.Void SetEquipState(System.String page); // 0x061bf0b8
	System.Void SetRarityState(System.Int32 level); // 0x061bdd10
	System.Void UpdataCollect(); // 0x061bdf7c
	System.Void UpdataTimeLimit(); // 0x061be254
	System.Void SetSelect(System.Boolean isSelect); // 0x061befe0
	System.Void OnSkinListItemClick(FairyGUI.EventContext context); // 0x061bf140
	System.Void .ctor(); // 0x061bf320
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.GSkinWeaponItem.EWeaponSkinType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.GSkinWeaponItem.EWeaponSkinType None = 0;
	static WizardGames.Soc.SocClient.Ui.GSkinWeaponItem.EWeaponSkinType OriginSkin = 1;
	static WizardGames.Soc.SocClient.Ui.GSkinWeaponItem.EWeaponSkinType Skin = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.LobbySkinBuildingUtil : System.Object
{
	
	static System.Void RenderOneSkinItem(WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ThirdTabItemBinder binder, WizardGames.Soc.SocClient.Ui.SkinData listSkinData, System.Int64 selectSkinId, WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x061bf388
	static System.Void RefreshCommonInfo(WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ThirdTabItemBinder binder, System.Int64 skinId); // 0x061bfc70
	static System.Void RefreshAppWelfareInfo(WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ThirdTabItemBinder binder, System.Int64 skinId); // 0x061bfe5c
	static System.Void UpdataTimeLimit(WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ThirdTabItemBinder binder, System.Int64 skinID); // 0x061c0068
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChosePlanPop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComponent root; // 0x338
	FairyGUI.GList costumePlanList; // 0x340
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComChosePlanBinder binder; // 0x348
	System.Int32 curChosePlanId; // 0x350
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.collection.OBJCostumePlan> curShowPlanList; // 0x358
	FairyGUI.GButton choseBtn; // 0x360
	System.Boolean firstSelect; // 0x368
	WizardGames.Soc.SocClient.Ui.GPlayerHomeWeaponItem curSelectWeapon; // 0x370
	System.Int32 SelectSkinId; // 0x378
	WizardGames.Soc.SocClient.Ui.ComDualTabs comdualTab; // 0x380
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.WeaponSkinType,System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.Int32,System.Int32>>> secendTab; // 0x388
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.WeaponSkinType> skinweaponTypeDic; // 0x390
	WizardGames.Soc.Common.Data.WeaponSkinType <SelectedFirstIndex>k__BackingField; // 0x398
	System.Boolean setWeaponed; // 0x39c
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.OBJSkin>> OnePartAllSkinDic; // 0x3a0
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.SkinWeaponConfig> OnePartTabConfig; // 0x3a8
	WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.ENewSkinOrderType curSortType; // 0x3b0
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.SkinWeaponType> primaryTabConfig; // 0x3b8
	System.Int32 <SelectedSecondIndex>k__BackingField; // 0x3c0
	WizardGames.Soc.Common.Data.WeaponSkinType get_SelectedFirstIndex(); // 0x061c02bc
	System.Void set_SelectedFirstIndex(WizardGames.Soc.Common.Data.WeaponSkinType value); // 0x061c0320
	System.Void OnInit(); // 0x061c0398
	System.Void InitComDualTab(); // 0x061c0e7c
	System.Void FirstTabBack(System.Int32 index); // 0x061c2738
	System.Void SecondTabBack(System.Int32 first, System.Int32 second); // 0x061c27e8
	System.Void ShowWeaponList(System.Int32 itemIndex); // 0x061c23a8
	System.Void OnEnable(); // 0x061c2af0
	System.Void RenderThirdTab(System.Int32 index, FairyGUI.GObject obj); // 0x061c318c
	System.Void OnClickWeapon(FairyGUI.EventContext context); // 0x061c3b00
	System.Void OnClickCloth(FairyGUI.EventContext context); // 0x061c21b8
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x061c3d70
	System.Void InitList(); // 0x061c0b78
	System.Void OnRenderPlanList(System.Int32 index, FairyGUI.GObject obj); // 0x061c3e3c
	System.Boolean PlanIsEmpty(System.Int32 planId); // 0x061c4a94
	System.Void RefreshChoseBtn(); // 0x061c3828
	System.Void OnClickPlan(FairyGUI.EventContext context); // 0x061c4e28
	System.Void OnClickChoseBack(); // 0x061c4f78
	System.Int32 get_SelectedSecondIndex(); // 0x061c5238
	System.Void set_SelectedSecondIndex(System.Int32 value); // 0x061c529c
	System.Void UpdatePrimaryTabConfig(); // 0x061c24a8
	System.Void UpdateSecondaryTabConfig(); // 0x061c14d0
	System.Void UpdateOnePartAllSkin(); // 0x061c18e0
	System.Void SelectSkinItem(WizardGames.Soc.SocClient.Ui.GPlayerHomeWeaponItem clickItem); // 0x061b7820
	System.Void .ctor(); // 0x061c5314
	System.Void <OnInit>b__18_0(); // 0x061c5554
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChosePlanPop.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiChosePlanPop.<>c <>9; // 0x0
	static System.Predicate<WizardGames.Soc.Common.Data.resource.OBJSkin> <>9__23_1; // 0x8
	static System.Comparison<WizardGames.Soc.Common.Data.DataItem.SkinWeaponType> <>9__45_0; // 0x10
	static System.Comparison<WizardGames.Soc.Common.Data.DataItem.SkinWeaponConfig> <>9__46_0; // 0x18
	static System.Comparison<WizardGames.Soc.Common.Data.resource.OBJSkin> <>9__47_0; // 0x20
	static System.Void .cctor(); // 0x061c55c8
	System.Void .ctor(); // 0x061c562c
	System.Boolean <OnEnable>b__23_1(WizardGames.Soc.Common.Data.resource.OBJSkin a); // 0x061c5694
	System.Int32 <UpdatePrimaryTabConfig>b__45_0(WizardGames.Soc.Common.Data.DataItem.SkinWeaponType config1, WizardGames.Soc.Common.Data.DataItem.SkinWeaponType config2); // 0x061c575c
	System.Int32 <UpdateSecondaryTabConfig>b__46_0(WizardGames.Soc.Common.Data.DataItem.SkinWeaponConfig config1, WizardGames.Soc.Common.Data.DataItem.SkinWeaponConfig config2); // 0x061c57f0
	System.Int32 <UpdateOnePartAllSkin>b__47_0(WizardGames.Soc.Common.Data.resource.OBJSkin x, WizardGames.Soc.Common.Data.resource.OBJSkin y); // 0x061c5884
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChosePlanPop.<>c__DisplayClass23_0 : System.Object
{
	System.Int32 typeId; // 0x10
	System.Void .ctor(); // 0x061c3124
	System.Boolean <OnEnable>b__0(System.Collections.Generic.Dictionary<System.Int32,System.Int32> a); // 0x061c5dac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChoseSkinConstruction : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.UiChoseSkinConstructionBinder binder; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SkinData> skinDataList; // 0x340
	System.Int32 curSelelctIndex; // 0x348
	System.Int64 currentSkinId; // 0x350
	WizardGames.Soc.Common.Entity.PartEntity partEntity; // 0x358
	System.Int64 partEntityId; // 0x360
	WizardGames.Soc.SocClient.MallSkinData curMallData; // 0x368
	FairyGUI.GLoader iconLoader; // 0x370
	FairyGUI.GTextField consumeNum; // 0x378
	System.Void OnInit(); // 0x061c5e48
	System.Void BtnEquipSkinClick(FairyGUI.EventContext context); // 0x061c6964
	System.Void BtnBuySkinClick(FairyGUI.EventContext context); // 0x061c6b1c
	System.Void BtnGoSkinClick(FairyGUI.EventContext context); // 0x061c6da0
	System.Void UsingSkinClick(FairyGUI.EventContext context); // 0x061c6e6c
	System.Void LockedSkinClick(FairyGUI.EventContext context); // 0x061c6f90
	System.Void OnEnable(); // 0x061c70cc
	System.Void OnDisable(); // 0x061c7398
	System.Void SetPartEntity(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x061c7664
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x061c84b8
	System.Void OnConstructionChangeSkinOver(System.Int64 partId); // 0x061c8538
	System.Void OnBundleInfoUpdate(); // 0x061c86e4
	System.Void OnMallItemIdInfoUpdate(System.Int32 mallItemShopId); // 0x061c8748
	System.Void OnMallItemInfoUpdate(); // 0x061c87c0
	System.Void OnMallSkinShopComplete(WizardGames.Soc.SocClient.MallSkinData mallSkinData); // 0x061c8824
	System.Void RefreshInfo(); // 0x061c85cc
	System.Void ClearListData(); // 0x061c8d80
	System.Void RefreshSkinListData(); // 0x061c7b94
	System.Int32 SortSkinData(WizardGames.Soc.SocClient.Ui.SkinData skinData1, WizardGames.Soc.SocClient.Ui.SkinData skinData2); // 0x061c8f7c
	System.Void OnSkinItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x061c9410
	System.Void OnSkinItemClick(FairyGUI.EventContext context); // 0x061c9568
	System.Void SelectSkin(System.Int64 skinId); // 0x061c8160
	System.Void RefreshLockedInfo(); // 0x061c89d0
	static System.Void Show(System.Int64 partEntityId); // 0x061c98f8
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x061c9a1c
	System.Void .ctor(); // 0x061c9b54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonPreview : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	WizardGames.Soc.SocClient.Ui.UiCommonPreview.EPerspectiveType perspectiveType; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.SkinPreviewData> previewDataList; // 0x340
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SkinPreviewItem> previewItemList; // 0x348
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComPreviewRootBinder binderRoot; // 0x350
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComPreviewContentBinder binder; // 0x358
	WizardGames.Soc.SocClient.Manager.SkinPreviewData curSelectData; // 0x360
	WizardGames.Soc.SocClient.Ui.SkinPreviewItem curSelectItem; // 0x368
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel tpPlayerModel; // 0x370
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel fpPlayerModel; // 0x378
	WizardGames.Soc.SocClient.Ui.ComUiModel WeaponModel; // 0x380
	WizardGames.Soc.SocClient.Ui.ComUiModel itemModel; // 0x388
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x390
	UnityEngine.Vector3 uiModelCameraPosition; // 0x398
	UnityEngine.Transform uiModelCamera; // 0x3a8
	UnityEngine.AzureSky.AzureWeatherPresetEnum azureType; // 0x3b0
	UnityEngine.AzureSky.EAzureControllerPresetEnum newPreset; // 0x3b4
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.SkinPreviewData> <EquipDataList>k__BackingField; // 0x3b8
	System.Collections.Generic.HashSet<System.Int32> suitSKinIDList; // 0x3c0
	System.Action onWndClose; // 0x3c8
	System.Boolean isShowTab; // 0x3d0
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComPartPreviewBinder previewBind; // 0x3d8
	System.Int64[] curShowAccess; // 0x3e0
	System.Boolean isLongPressing; // 0x3e8
	System.Collections.Generic.Dictionary<System.Int64,System.ValueTuple<UnityEngine.GameObject,System.String>> accessorys; // 0x3f0
	System.Collections.Generic.List<System.Int64> tempAccessoryList; // 0x3f8
	System.Int64 selectedAccessorySkinId; // 0x400
	DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> tweener; // 0x408
	FairyGUI.GButton lastSelectPartItem; // 0x410
	System.Int32 curBgId; // 0x418
	WizardGames.Soc.SocClient.Ui.ComAppWelfareText skinWeaponAppWelfareCom; // 0x420
	System.Collections.Generic.HashSet<System.Int32> equipDataSkinIdList; // 0x428
	System.Collections.Generic.List<System.Int64> suitDetailList; // 0x430
	WizardGames.Soc.SocClient.Ui.ExtraSkinPreviewData extraData; // 0x438
	WizardGames.Soc.SocClient.Ui.UiCommonPreview.EShowModelType showOnEnable; // 0x440
	System.Boolean isUseDefaultPlan; // 0x444
	System.Boolean useMallPosConfig; // 0x445
	System.Void set_EquipDataList(System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.SkinPreviewData> value); // 0x061c9c34
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.SkinPreviewData> get_EquipDataList(); // 0x061c9cb4
	System.Void OnInit(); // 0x061c9d18
	System.Void OnEnable(); // 0x061cae24
	System.Void SetShowData(System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.SkinPreviewData> dataList, System.Action onClose, System.Boolean showTab, System.Int32 selectIndex, WizardGames.Soc.SocClient.Ui.ExtraSkinPreviewData extraData, System.Boolean useMallPosConfig); // 0x061b2ecc
	System.Void SetShowData(WizardGames.Soc.SocClient.Manager.SkinPreviewData data, System.Action onClose); // 0x061cc088
	System.Void UpdateOneWnd(WizardGames.Soc.SocClient.Manager.SkinPreviewData data); // 0x061cc1b0
	System.Void OnRenderItem(System.Int32 index, FairyGUI.GObject obj); // 0x061ccbcc
	System.Void OnDisable(); // 0x061ccd70
	System.Void OnDestroy(); // 0x061ccff4
	System.Boolean CanCancelClick(); // 0x061cd514
	System.Void UpdateMultiWnd(WizardGames.Soc.SocClient.Ui.SkinPreviewItem item, System.Boolean isSelect); // 0x061cd81c
	System.Void CheckConflict(WizardGames.Soc.SocClient.Manager.SkinPreviewData curData); // 0x061cef68
	System.Boolean CheckPartIsLow(System.Int32 partSkinId, System.Boolean partIsEquip, System.Collections.Generic.Dictionary<System.Int32,System.Int32> targetDic, System.Int32 suitId); // 0x061d0594
	System.Void UpdateShowModelType(WizardGames.Soc.SocClient.Manager.SkinPreviewData data); // 0x061ccab0
	System.Void UpdatePartPreviewVisble(System.Boolean isOnlySetVisible); // 0x061d0be0
	System.Void UpdatePartPreview(); // 0x061d10e0
	System.Void OnRenderPartPreviewList(System.Int32 index, FairyGUI.GObject obj); // 0x061d1c24
	System.Void OnLongPressBegin(FairyGUI.EventContext context); // 0x061d1fd0
	System.Void OnLongPressEnd(); // 0x061d2294
	System.Void LateResetLongPressState(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x061d2434
	System.Void OnClickPartItem(FairyGUI.EventContext context); // 0x061d24c8
	System.Void OnPartPreviewClick(); // 0x061d28f4
	System.Void OnNormalClick(); // 0x061d29e4
	System.Void OnSuperClick(); // 0x061d2a4c
	System.Void SetCtrlParPreview(System.Int32 index); // 0x061d1004
	System.Void SetCtrlState(System.String page); // 0x061cff64
	System.Void SetTitleAndTabName(System.String title, System.String tabName); // 0x061d2ab4
	System.Void SetContent(WizardGames.Soc.SocClient.Manager.SkinPreviewData data); // 0x061cc358
	System.Void RefreshSkinWeaponAppWelfareInfo(System.Int32 skinId); // 0x061d0f70
	System.Void SetBtnGroupVisible(System.Boolean visible, System.Boolean isWeapon); // 0x061cc798
	System.Int32 GetSex(); // 0x061d2c0c
	System.Void InitFpPlayerModel(); // 0x061d30a0
	System.Void RefreshFpPlayerModel(); // 0x061d353c
	System.Boolean CheckCostumeSuit(System.Int32 id); // 0x061d0038
	System.Void AddCostumeSuit(System.Int32 suitId, System.Collections.Generic.List<System.Int32> itemIds, System.Collections.Generic.List<System.Int32> skinIds); // 0x061d0144
	System.Void InitTpPlayerModel(); // 0x061cb318
	System.Void HandlePlaySuitPerformanceEnd(); // 0x061d4480
	System.Void RefreshTpPlayerModel(); // 0x061cb854
	System.Boolean CanPlaySuitAnim(); // 0x061d43f8
	System.Void ChangeTpModelCamera(WizardGames.Soc.SocClient.Manager.SkinPreviewData data); // 0x061d4b3c
	System.Void CheckIsAddDefaultPlan(System.Collections.Generic.List<System.Int32> itemIds, System.Collections.Generic.List<System.Int32> itemSkinIds); // 0x061d3c94
	System.Void InitItemModel(); // 0x061cafd8
	System.ValueTuple<UnityEngine.AzureSky.AzureWeatherPresetEnum,UnityEngine.AzureSky.EAzureControllerPresetEnum> GetExtraTodInfo(System.Boolean isItemModel); // 0x061d4dc4
	System.Void RefreshItemModel(); // 0x061d5034
	System.Void ShowBuildingSkins(System.Int32 buildingSkinId); // 0x061d5630
	System.Void OnBgClick(FairyGUI.EventContext context); // 0x061d5c54
	System.Void OnSuitDetailItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x061d5f10
	System.Void OnSuitDetailItemClick(FairyGUI.EventContext context); // 0x061d63e0
	WizardGames.Soc.SocClient.Ui.ComUiModel GetCurrItemModel(); // 0x061d6b5c
	System.Void MakeFullScreen(); // 0x061d6c08
	System.Boolean CheckCanAdd(WizardGames.Soc.SocClient.Manager.SkinPreviewData data); // 0x061ce9f8
	WizardGames.Soc.SocClient.Ui.SkinPreviewItem GetPreviewItem(System.Int32 skinId); // 0x061d042c
	System.Void OnClickHighLight(); // 0x061d6c70
	System.Void OnClickSwitchPerspective(); // 0x061d6cfc
	System.Void SetPerspective(WizardGames.Soc.SocClient.Ui.UiCommonPreview.EPerspectiveType type); // 0x061d0b44
	System.Void SwitchPerspective(); // 0x061d6ef0
	System.Void OnClickPreviewModel(); // 0x061d7110
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x061d729c
	System.Void AddAccessories(System.Int64[] accessoryList); // 0x061d1604
	System.Void AddAccessory(System.Int64 accessorySkinId, System.Int64 weaponTableId, WizardGames.Soc.SocClient.GoLoader.ModelType modelType); // 0x061d74a8
	System.Void RemoveAllAccessories(); // 0x061cd154
	System.Void RemoveAccessory(System.Int64 accessorySkinId); // 0x061d731c
	System.Void SelectAccessory(System.Int64 accessorySkinId); // 0x061d2738
	System.Void DOMove(UnityEngine.Vector3 pos); // 0x061d7abc
	System.Void CancelSelectAccessory(); // 0x061d14fc
	System.Void ResetPartPreview(); // 0x061cd42c
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x061d7be8
	System.Void SetBg(System.Int32 bgId); // 0x061d7058
	System.Void .ctor(); // 0x061d7cd0
	System.Void <RefreshTpPlayerModel>b__80_0(System.Int64 a, System.Object b, System.Boolean c); // 0x061d7eb4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiCommonPreview.EShowModelType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiCommonPreview.EShowModelType None = 0;
	static WizardGames.Soc.SocClient.Ui.UiCommonPreview.EShowModelType Weapon = 1;
	static WizardGames.Soc.SocClient.Ui.UiCommonPreview.EShowModelType Item = 2;
	static WizardGames.Soc.SocClient.Ui.UiCommonPreview.EShowModelType TpPlayer = 3;
	static WizardGames.Soc.SocClient.Ui.UiCommonPreview.EShowModelType FpPlayer = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiCommonPreview.EPerspectiveType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiCommonPreview.EPerspectiveType ModelP = 0;
	static WizardGames.Soc.SocClient.Ui.UiCommonPreview.EPerspectiveType FirstP = 1;
	static WizardGames.Soc.SocClient.Ui.UiCommonPreview.EPerspectiveType ThirdP = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonPreview.<>c__DisplayClass51_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.SkinPreviewData previewData; // 0x10
	System.Void .ctor(); // 0x061d8150
	System.Boolean <UpdateMultiWnd>b__0(WizardGames.Soc.Common.Data.resource.FixedPackage x); // 0x061d81b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonPreview.<>c__DisplayClass51_1 : System.Object
{
	WizardGames.Soc.Common.Data.resource.FixedPackage package; // 0x10
	System.Void .ctor(); // 0x061d824c
	System.Boolean <UpdateMultiWnd>b__1(WizardGames.Soc.SocClient.Manager.SkinPreviewData x); // 0x061d82b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonPreview.<>c__DisplayClass51_2 : System.Object
{
	System.Int32 resourceID; // 0x10
	System.Void .ctor(); // 0x061d8348
	System.Boolean <UpdateMultiWnd>b__2(WizardGames.Soc.SocClient.Manager.SkinPreviewData x); // 0x061d83b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SkinPreviewItem : System.Object
{
	WizardGames.Soc.SocClient.Manager.SkinPreviewData <PreviewData>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCommonPreview previewParent; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ThirdTabItemBinder bind; // 0x20
	System.Boolean isSelect; // 0x28
	System.Void set_PreviewData(WizardGames.Soc.SocClient.Manager.SkinPreviewData value); // 0x061d843c
	WizardGames.Soc.SocClient.Manager.SkinPreviewData get_PreviewData(); // 0x061d84bc
	System.Void .ctor(WizardGames.Soc.SocClient.Manager.SkinPreviewData skinData); // 0x061d8520
	System.Void UpdateCom(WizardGames.Soc.SocClient.Ui.UiCommonPreview preview, FairyGUI.GComponent item, WizardGames.Soc.SocClient.Manager.SkinPreviewData data); // 0x061d85e0
	System.Void SetSelect(System.Boolean select); // 0x061d8fd0
	System.Void SetEquip(System.Boolean equip); // 0x061d8b94
	System.Void SetTagTitle(System.String tagText); // 0x061d8db4
	System.Void OnClick(); // 0x061d90b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ExtraSkinPreviewData : System.Object
{
	System.Int32 mallBundleId; // 0x10
	System.Int32 mallLotteryId; // 0x14
	System.Void .ctor(); // 0x061d9180
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameCharm : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiInventoryItemSkin weaponIns; // 0x10
	FairyGUI.GList comList; // 0x18
	WizardGames.Soc.SocClient.Ui.UiGameCharm.GSkinCharmItem <CurSelectItem>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootLobbySkinBuildingContentBinder content; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiGameCharm.GSkinCharmItem> charmItemList; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.OBJSkin> allCharmCfgList; // 0x38
	DoMoveUtil doMoveUtil; // 0x40
	System.Void set_CurSelectItem(WizardGames.Soc.SocClient.Ui.UiGameCharm.GSkinCharmItem value); // 0x061d91e8
	WizardGames.Soc.SocClient.Ui.UiGameCharm.GSkinCharmItem get_CurSelectItem(); // 0x061d9268
	System.Void Init(WizardGames.Soc.SocClient.Ui.UiInventoryItemSkin _weaponIns, WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootLobbySkinBuildingContentBinder contentRoot, FairyGUI.GList _comList); // 0x061d92cc
	System.Void InitcharmData(); // 0x061d94ec
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x061d97b0
	System.Void OnReciveEuqipHangings(System.Int32 skinId, System.Int32 hangingsSkinId, System.Int32 opType); // 0x061d9e94
	System.Void UpdateAll(); // 0x061da1f4
	System.Single GetSkinDataWeight(WizardGames.Soc.Common.Data.resource.OBJSkin cfg); // 0x061daaf8
	System.Void UpdataWnd(System.Int32 selectIndex); // 0x061dacd4
	System.Void SetSelectItem(WizardGames.Soc.SocClient.Ui.UiGameCharm.GSkinCharmItem item); // 0x061dae1c
	System.Void UpdateState(); // 0x061da748
	System.Void UpdateEquipState(); // 0x061daeec
	System.Void StartDoMove(); // 0x061dcf9c
	System.Void EndDoMove(); // 0x061dd2f0
	System.Void OnCloseWnd(); // 0x061dd4b8
	System.Void .ctor(); // 0x061dd5d4
	System.Int32 <UpdataWnd>b__16_0(WizardGames.Soc.Common.Data.resource.OBJSkin x, WizardGames.Soc.Common.Data.resource.OBJSkin y); // 0x061dd6e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameCharm.GSkinCharmItem : System.Object
{
	FairyGUI.GButton com; // 0x10
	WizardGames.Soc.Common.Data.resource.OBJSkin charmCfg; // 0x18
	WizardGames.Soc.Common.Data.resource.OBJGenaral objCfg; // 0x20
	WizardGames.Soc.SocClient.Ui.UiGameCharm charmParent; // 0x28
	WizardGames.Soc.SocClient.Manager.CommonSkinData skinData; // 0x30
	System.Int32 count; // 0x38
	FairyGUI.GComponent SkinItem; // 0x40
	FairyGUI.GLoader loaderIcon; // 0x48
	FairyGUI.GTextField titleTxt; // 0x50
	FairyGUI.Controller equipCtr; // 0x58
	FairyGUI.Controller statusCtr; // 0x60
	FairyGUI.Controller collectCtr; // 0x68
	FairyGUI.Controller timeLimitCtr; // 0x70
	FairyGUI.Controller redDotCtr; // 0x78
	FairyGUI.Controller rarityCtr; // 0x80
	FairyGUI.Controller styleCtr; // 0x88
	FairyGUI.Controller countCtr; // 0x90
	FairyGUI.GLoader appWelfareIconGLoader; // 0x98
	System.Boolean isLock; // 0xa0
	System.Boolean isTimeLimit; // 0xa1
	System.Boolean isEquip; // 0xa2
	System.Boolean isCollect; // 0xa3
	System.Void .ctor(FairyGUI.GButton _com, WizardGames.Soc.Common.Data.resource.OBJSkin _charmCfg, WizardGames.Soc.SocClient.Ui.UiGameCharm _charmParent); // 0x061d9954
	System.Void UpdateCom(); // 0x061da2b4
	System.Void RefreshRed(); // 0x061dd964
	System.Void SetCtrState(FairyGUI.Controller contr, System.String page); // 0x061dd8d4
	System.Void SetSelect(System.Boolean isSelect); // 0x061dd840
	System.Void OnClick(); // 0x061dda64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHighLightBox : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComponent rootCom; // 0x338
	FairyGUI.GList picList; // 0x340
	FairyGUI.GTextField desText; // 0x348
	FairyGUI.GButton leftBtn; // 0x350
	FairyGUI.GButton rightBtn; // 0x358
	FairyGUI.GList pointList; // 0x360
	System.Int32 curPageIndex; // 0x368
	WizardGames.Soc.SocClient.Ui.ComVideo videoPlayer; // 0x370
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.tips.SkinHighLightConfig> cfgList; // 0x378
	WizardGames.Soc.SocClient.Ui.ComModal modal; // 0x380
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ModalBtnInfo> btnList; // 0x388
	FairyGUI.GTextField descTxt; // 0x390
	System.Void OnInit(); // 0x061ddc30
	System.Void RefreshWnd(System.Collections.Generic.List<System.Int32> idList); // 0x061de588
	System.Void OnRenderPicItem(System.Int32 index, FairyGUI.GObject obj); // 0x061df048
	System.Void OnRenderPointItem(System.Int32 index, FairyGUI.GObject obj); // 0x061df14c
	System.Void UpdataSelectPage(System.Int32 page); // 0x061df240
	System.Void OnScrollBegin(FairyGUI.EventContext context); // 0x061df414
	System.Void OnScrollEnd(FairyGUI.EventContext context); // 0x061df624
	System.Void TryPlayVideo(); // 0x061deb6c
	System.Void OnClickLeftBtn(); // 0x061df7b8
	System.Void OnClickRightBtn(); // 0x061df848
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x061df8d8
	static WizardGames.Soc.SocClient.Ui.UiHighLightBox ShowWnd(System.Collections.Generic.List<System.Int32> idList); // 0x061df958
	System.Void .ctor(); // 0x061dfaa0
	System.Void <OnInit>b__15_0(FairyGUI.EventContext ctx); // 0x061dfb34
	System.Void <OnInit>b__15_1(FairyGUI.EventContext ctx); // 0x061dfbac
	System.Void <RefreshWnd>b__16_0(); // 0x061dfc24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHighLightBox.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHighLightBox.<>c <>9; // 0x0
	static FairyGUI.TimerCallback <>9__22_2; // 0x8
	static System.Action<UnityEngine.Video.VideoPlayer> <>9__22_0; // 0x10
	static System.Void .cctor(); // 0x061dfc98
	System.Void .ctor(); // 0x061dfcfc
	System.Void <TryPlayVideo>b__22_0(UnityEngine.Video.VideoPlayer player); // 0x061dfd64
	System.Void <TryPlayVideo>b__22_2(System.Object param); // 0x061dfeb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHighLightBox.<>c__DisplayClass16_0 : System.Object
{
	System.Int32 index; // 0x10
	WizardGames.Soc.SocClient.Ui.UiHighLightBox <>4__this; // 0x18
	System.Void .ctor(); // 0x061defe0
	System.Void <RefreshWnd>b__1(); // 0x061dff24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHighLightBox.<>c__DisplayClass22_0 : System.Object
{
	System.String name; // 0x10
	System.Void .ctor(); // 0x061df750
	System.Void <TryPlayVideo>b__1(UnityEngine.Video.VideoPlayer player); // 0x061dffb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryItemSkin : WizardGames.Soc.SocClient.Ui.UiLobbySkinBase
{
	System.Int64 currentSkinId; // 0x390
	System.Int64 currentHostItemId; // 0x398
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel uiPlayerModel; // 0x3a0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SkinData> thirdItemList; // 0x3a8
	FairyGUI.GButton btnModify; // 0x3b0
	WizardGames.Soc.Common.CustomType.BaseItemNode inventoryCurItemNode; // 0x3b8
	System.Int32 inventoryCurSelectItemIndex; // 0x3c0
	System.Int32 inventoryCurEquipItemIndex; // 0x3c4
	WizardGames.Soc.SocClient.Ui.UiGameCharm charmIns; // 0x3c8
	System.Boolean isFirstOpen; // 0x3d0
	WizardGames.Soc.Common.CustomType.BaseItemNode get_CurItemNode(); // 0x061e00cc
	System.Void OnInit(); // 0x061e0130
	System.Void OnEnable(); // 0x061e134c
	System.Void OnDisable(); // 0x061e206c
	System.Void OnSwitchWeather(); // 0x061e2194
	System.Void BeforeClose(); // 0x061e2218
	System.Void OnDestroy(); // 0x061e2278
	System.Void ThirdTabItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x061e26ac
	System.Void RefreshAppWelfareInfo(WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ThirdTabItemBinder binder, System.Int64 skinId); // 0x061e3914
	System.Void ThirdTabItemClick(FairyGUI.EventContext context); // 0x061e3b28
	System.Void Refresh(); // 0x061e1d08
	System.Void SetSkinTitle(System.String name, System.String desc, System.Int32 rarity); // 0x061db070
	System.Void SetEquipIndexState(System.Int32 index); // 0x061dcbbc
	System.Void SetLimitTxt(System.String limitTxt); // 0x061dc014
	System.Void RefreshModel(); // 0x061dc1f4
	System.Boolean IsCharmType(); // 0x061e4198
	System.Void SetCollectBtn(System.Boolean isShow, System.Boolean isCollect); // 0x061db4e8
	System.Void SetShareBtn(System.Boolean isShow); // 0x061dba7c
	System.Void RefreshThirdTab(System.Int64 itemId, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x061e437c
	System.Void ShowCharmTip(); // 0x061e5c94
	System.Void SetEquipState(System.String page); // 0x061e5da4
	System.Int32 GetCurSkinId(); // 0x061e5e20
	System.Void BtnEquipSkinClick(FairyGUI.EventContext context); // 0x061e5ef8
	System.Void BtnCollectClick(FairyGUI.EventContext context); // 0x061e673c
	System.Void BtnPreviewClick(FairyGUI.EventContext context); // 0x061e6adc
	System.Void BtnShareClick(); // 0x061e6d4c
	System.Void HideModifyBtn(); // 0x061dc180
	System.Void UpdateModifyState(); // 0x061e4124
	System.Void OnClickModifyBtn(); // 0x061e6ff0
	System.Void OnClickWeaponBtn(); // 0x061e70a4
	System.Void OnClickCharmBtn(); // 0x061e750c
	System.Void OnClickSyncLobby(); // 0x061e79ac
	WizardGames.Soc.SocClient.Ui.ComUiModel GetCurrItemModel(); // 0x061e1bfc
	static System.Void OpenFromInventoryTips(System.Int64 itemId, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x061e7ba0
	System.Void MakeFullScreen(); // 0x061e8848
	System.Void OnItemUpdate(); // 0x061e88b0
	System.Void OnStopLootingAck(); // 0x061e8988
	System.Void .ctor(); // 0x061e89f8
	System.Void <OnEnable>b__14_0(System.Int32 index); // 0x061e8abc
	System.Int32 <OnEnable>b__14_1(WizardGames.Soc.SocClient.Ui.SkinData a, WizardGames.Soc.SocClient.Ui.SkinData b); // 0x061e8ca0
	System.Int32 <RefreshThirdTab>b__30_0(WizardGames.Soc.SocClient.Ui.SkinData a, WizardGames.Soc.SocClient.Ui.SkinData b); // 0x061e8e78
	System.Void <BtnEquipSkinClick>b__34_1(); // 0x061e9050
	System.Void <BtnEquipSkinClick>b__34_0(); // 0x061e92c0
	System.Void <BtnShareClick>b__37_0(); // 0x061e9530
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInventoryItemSkin.<>c__DisplayClass35_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiInventoryItemSkin <>4__this; // 0x10
	System.Boolean isStar; // 0x18
	System.Void .ctor(); // 0x061e6a74
	System.Void <BtnCollectClick>b__0(); // 0x061e95ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SkinData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.Int64 Id; // 0x10
	System.Int64 <ItemId>k__BackingField; // 0x18
	System.Int64 <SkinId>k__BackingField; // 0x20
	System.Int32 <Level>k__BackingField; // 0x28
	System.String <Icon>k__BackingField; // 0x30
	System.String <Name>k__BackingField; // 0x38
	System.String <ShortName>k__BackingField; // 0x40
	System.String <Text>k__BackingField; // 0x48
	System.Int64 <GotTime>k__BackingField; // 0x50
	System.Int64 <StarredTime>k__BackingField; // 0x58
	WizardGames.Soc.SocClient.Manager.MgrSkinPreview.ESkinPreviewType skinType; // 0x60
	System.Int64 get_ItemId(); // 0x061e974c
	System.Void set_ItemId(System.Int64 value); // 0x061e97b0
	System.Int64 get_SkinId(); // 0x061e9828
	System.Void set_SkinId(System.Int64 value); // 0x061e988c
	System.Int32 get_Level(); // 0x061e9904
	System.Void set_Level(System.Int32 value); // 0x061e9968
	System.String get_Icon(); // 0x061e99e0
	System.Void set_Icon(System.String value); // 0x061e9a44
	System.String get_Name(); // 0x061e9ac4
	System.Void set_Name(System.String value); // 0x061e9b28
	System.String get_ShortName(); // 0x061e9ba8
	System.Void set_ShortName(System.String value); // 0x061e9c0c
	System.String get_Text(); // 0x061e9c8c
	System.Void set_Text(System.String value); // 0x061e9cf0
	System.Int64 get_GotTime(); // 0x061e9d70
	System.Void set_GotTime(System.Int64 value); // 0x061e9dd4
	System.Int64 get_StarredTime(); // 0x061e9e4c
	System.Void set_StarredTime(System.Int64 value); // 0x061e9eb0
	System.Void RegisterData(WizardGames.Soc.Common.Data.DataItem.SkinConfig skinConfig); // 0x061e54d0
	System.Int64 GetStarredTime(); // 0x061e9f28
	System.Int64 GetGotTime(); // 0x061ea020
	System.Void RegisterData(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemConfig); // 0x061e5870
	System.Void OnGet(); // 0x061ea118
	System.Void OnRelease(); // 0x061ea358
	System.Void OnDestroy(); // 0x061ea3b8
	System.Void .ctor(); // 0x061ea418
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyCharm : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon weaponIns; // 0x10
	FairyGUI.GList comList; // 0x18
	WizardGames.Soc.SocClient.Ui.UiLobbyCharm.GSkinCharmItem <CurSelectItem>k__BackingField; // 0x20
	FairyGUI.GComponent content; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiLobbyCharm.GSkinCharmItem> charmItemList; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.OBJSkin> allCharmCfgList; // 0x38
	DoMoveUtil doMoveUtil; // 0x40
	System.Void set_CurSelectItem(WizardGames.Soc.SocClient.Ui.UiLobbyCharm.GSkinCharmItem value); // 0x061ea480
	WizardGames.Soc.SocClient.Ui.UiLobbyCharm.GSkinCharmItem get_CurSelectItem(); // 0x061ea500
	System.Void Init(WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon _weaponIns, FairyGUI.GComponent contentRoot, FairyGUI.GList _comList); // 0x061ea564
	System.Void InitcharmData(); // 0x061ea784
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x061eaa48
	System.Void OnReciveEuqipHangings(System.Int32 skinId, System.Int32 hangingsSkinId, System.Int32 opType); // 0x061eb644
	System.Void UpdateAll(); // 0x061eb9ac
	System.Void UpdataWnd(System.Int32 selectIndex); // 0x061ebe90
	System.Single GetSkinDataWeight(WizardGames.Soc.Common.Data.resource.OBJSkin cfg); // 0x061ebfd8
	System.Void SetSelectItem(WizardGames.Soc.SocClient.Ui.UiLobbyCharm.GSkinCharmItem item); // 0x061ec214
	System.Void UpdateSelectItem(); // 0x061ec2e4
	System.Void UpdateState(); // 0x061eba6c
	System.Void UpdateEquipState(); // 0x061ec39c
	System.Void StartDoMove(); // 0x061ec588
	System.Void EndDoMove(); // 0x061ec7e8
	System.Void OnCloseWnd(); // 0x061ec8b0
	System.Void .ctor(); // 0x061ec9cc
	System.Int32 <UpdataWnd>b__15_0(WizardGames.Soc.Common.Data.resource.OBJSkin x, WizardGames.Soc.Common.Data.resource.OBJSkin y); // 0x061ecad8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyCharm.GSkinCharmItem : System.Object
{
	FairyGUI.GButton com; // 0x10
	WizardGames.Soc.Common.Data.resource.OBJSkin charmCfg; // 0x18
	WizardGames.Soc.Common.Data.resource.OBJGenaral objCfg; // 0x20
	WizardGames.Soc.SocClient.Ui.UiLobbyCharm charmParent; // 0x28
	WizardGames.Soc.SocClient.Manager.CommonSkinData skinData; // 0x30
	System.Int32 count; // 0x38
	FairyGUI.GComponent SkinItem; // 0x40
	FairyGUI.GLoader loaderIcon; // 0x48
	FairyGUI.GTextField titleTxt; // 0x50
	FairyGUI.Controller equipCtr; // 0x58
	FairyGUI.Controller statusCtr; // 0x60
	FairyGUI.Controller collectCtr; // 0x68
	FairyGUI.Controller timeLimitCtr; // 0x70
	FairyGUI.Controller redDotCtr; // 0x78
	FairyGUI.Controller rarityCtr; // 0x80
	FairyGUI.Controller styleCtr; // 0x88
	FairyGUI.Controller countCtr; // 0x90
	FairyGUI.GLoader appWelfareIconGLoader; // 0x98
	System.Boolean isLock; // 0xa0
	System.Boolean isTimeLimit; // 0xa1
	System.Boolean isEquip; // 0xa2
	System.Boolean isCollect; // 0xa3
	System.Void .ctor(FairyGUI.GButton _com, WizardGames.Soc.Common.Data.resource.OBJSkin _charmCfg, WizardGames.Soc.SocClient.Ui.UiLobbyCharm _charmParent); // 0x061eac10
	System.Void UpdateCom(); // 0x061eb150
	System.Void RefreshRed(); // 0x061ecd5c
	System.Void SetCtrState(FairyGUI.Controller contr, System.String page); // 0x061ecccc
	System.Void SetSelect(System.Boolean isSelect); // 0x061ecc38
	System.Void OnClick(); // 0x061ece5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyCostume : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor <UiSkinArmorIns>k__BackingField; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.CostumePartConfig> allCostumeParyCfg; // 0x18
	FairyGUI.GList partList; // 0x20
	FairyGUI.GList suitList; // 0x28
	FairyGUI.GList suitPlanList; // 0x30
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.CostumeConfig>> allCostumeCfg; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.CostumeConfig> curShowPartList; // 0x40
	System.Int32 curPart; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.CostumeItemData> costumeItemList; // 0x50
	WizardGames.Soc.SocClient.Ui.CostumeItemData curCostumeItemData; // 0x58
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.collection.OBJCostumeSuit> curShowSuitList; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.CostumeSuitItemData> costumeSuitItemList; // 0x68
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.collection.OBJCostumePlan> curShowPlanList; // 0x70
	WizardGames.Soc.SocClient.Ui.CostumeSuitItemData curCostumeSuitItemData; // 0x78
	System.Int32 tempSex; // 0x80
	System.Void set_UiSkinArmorIns(WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor value); // 0x061ed028
	WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor get_UiSkinArmorIns(); // 0x061ed0a8
	System.Void Init(WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor skinArmorIns, FairyGUI.GList comPartList, FairyGUI.GList comSuitList, FairyGUI.GList comSuitPlanList); // 0x061ed10c
	System.Void UpdataList(System.Int32 partIndex); // 0x061eda50
	System.Void SortShowList(); // 0x061ee214
	System.Void UpdataCostumePart(); // 0x061ed4c4
	System.Void UpdataCostumeSuit(); // 0x061ed704
	System.Void UpdataOnePart(System.Int32 costumePart); // 0x061ee650
	System.Void OnRenderPartList(System.Int32 index, FairyGUI.GObject obj); // 0x061eea6c
	System.Void OnRenderSuitList(System.Int32 index, FairyGUI.GObject obj); // 0x061ef7d0
	System.Void OnRenderPlanList(System.Int32 index, FairyGUI.GObject obj); // 0x061f03a8
	System.Void OnCostumeItemClick(WizardGames.Soc.SocClient.Ui.CostumeItemData itemData, FairyGUI.EventContext context); // 0x061f105c
	System.Void OnCostumeSuitClick(WizardGames.Soc.SocClient.Ui.CostumeSuitItemData data, FairyGUI.EventContext context); // 0x061f1ab8
	System.Void CheckIsCoverServerData(System.Boolean isWear, System.Int32 part, System.Int32 skinId); // 0x061f1830
	System.Void OnCostumeWearChange(); // 0x061f19bc
	System.Void OnEditorBack(FairyGUI.EventContext context); // 0x061f28cc
	System.Void OnUseBtnBack(FairyGUI.EventContext context); // 0x061f2a78
	System.Void HideList(); // 0x061f2fe8
	System.Void UpdataPartListCount(System.Int32 count); // 0x061ee44c
	System.Void UpdataSuitListCount(System.Int32 count); // 0x061ee078
	System.Int32 ChangeSex(System.Int32 sex); // 0x061f2f64
	System.Void CheckUnWearBySex(System.Int32 costumeId); // 0x061f3320
	System.Void .ctor(); // 0x061f34bc
	static System.Void .cctor(); // 0x061f3570
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyCostume.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiLobbyCostume.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Data.DataItem.CostumePartConfig> <>9__22_0; // 0x8
	static System.Void .cctor(); // 0x061f3644
	System.Void .ctor(); // 0x061f36a8
	System.Int32 <UpdataCostumePart>b__22_0(WizardGames.Soc.Common.Data.DataItem.CostumePartConfig x, WizardGames.Soc.Common.Data.DataItem.CostumePartConfig y); // 0x061f3710
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyCostume.<>c__DisplayClass21_0 : System.Object
{
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> costumeDic; // 0x10
	System.Void .ctor(); // 0x061ee5e8
	System.Int32 <SortShowList>b__0(WizardGames.Soc.Common.Data.DataItem.CostumeConfig x, WizardGames.Soc.Common.Data.DataItem.CostumeConfig y); // 0x061f37a4
	System.Int32 <SortShowList>b__1(WizardGames.Soc.Common.Data.DataItem.CostumeConfig x, WizardGames.Soc.Common.Data.DataItem.CostumeConfig y); // 0x061f3c54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.CostumeSuitItemData : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbyCostume <LobbyCostumeIns>k__BackingField; // 0x10
	WizardGames.Soc.Common.Data.collection.OBJCostumeSuit <CostumeSuitCfg>k__BackingField; // 0x18
	WizardGames.Soc.Common.Data.resource.OBJGenaral genaralCfg; // 0x20
	FairyGUI.GComponent <Com>k__BackingField; // 0x28
	System.Action<WizardGames.Soc.SocClient.Ui.CostumeSuitItemData,FairyGUI.EventContext> clickBack; // 0x30
	System.Boolean <IsSelect>k__BackingField; // 0x38
	System.Boolean <IsWear>k__BackingField; // 0x39
	System.Boolean <IsUnlock>k__BackingField; // 0x3a
	System.Boolean <IsCollect>k__BackingField; // 0x3b
	FairyGUI.Controller newStateCtr; // 0x40
	FairyGUI.Controller timeLimitCtr; // 0x48
	FairyGUI.Controller rarityCtr; // 0x50
	System.Void set_LobbyCostumeIns(WizardGames.Soc.SocClient.Ui.UiLobbyCostume value); // 0x061f40b4
	WizardGames.Soc.SocClient.Ui.UiLobbyCostume get_LobbyCostumeIns(); // 0x061f4134
	System.Void set_CostumeSuitCfg(WizardGames.Soc.Common.Data.collection.OBJCostumeSuit value); // 0x061f4198
	WizardGames.Soc.Common.Data.collection.OBJCostumeSuit get_CostumeSuitCfg(); // 0x061f4218
	System.Void set_Com(FairyGUI.GComponent value); // 0x061f427c
	FairyGUI.GComponent get_Com(); // 0x061f42fc
	System.Void set_IsSelect(System.Boolean value); // 0x061f4360
	System.Boolean get_IsSelect(); // 0x061f43dc
	System.Void set_IsWear(System.Boolean value); // 0x061f4440
	System.Boolean get_IsWear(); // 0x061f44bc
	System.Void set_IsUnlock(System.Boolean value); // 0x061f4520
	System.Boolean get_IsUnlock(); // 0x061f459c
	System.Void set_IsCollect(System.Boolean value); // 0x061f4600
	System.Boolean get_IsCollect(); // 0x061f467c
	System.Void SetData(WizardGames.Soc.SocClient.Ui.UiLobbyCostume UiLobbyCostumeIns, System.Action<WizardGames.Soc.SocClient.Ui.CostumeSuitItemData,FairyGUI.EventContext> back, WizardGames.Soc.Common.Data.collection.OBJCostumeSuit data, FairyGUI.GComponent com); // 0x061ef99c
	System.Boolean CheckIsNew(); // 0x061f4894
	System.Boolean CheckIsGet(); // 0x061f46e0
	System.Boolean CheckIsCollect(); // 0x061f5710
	System.Boolean CheckIsEquip(); // 0x061f4a40
	System.Void UpdataSelect(System.Boolean isSelect); // 0x061f53cc
	System.Boolean CheckCostumeIsEquip(System.Int64 costumeId); // 0x061f58c4
	System.Void OnClickSuitItem(FairyGUI.EventContext context); // 0x061f4d5c
	System.Void UpdataCollect(); // 0x061f4ba8
	System.Void UpdataTimeLimit(System.Int32 id); // 0x061f55dc
	System.Void Reset(); // 0x061f31b4
	System.Void .ctor(); // 0x061f314c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.CostumeItemData : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbyCostume <LobbyCostumeIns>k__BackingField; // 0x10
	System.Int32 <CurPart>k__BackingField; // 0x18
	WizardGames.Soc.Common.Data.DataItem.CostumeConfig <CostumeCfg>k__BackingField; // 0x20
	FairyGUI.GComponent <Com>k__BackingField; // 0x28
	System.Action<WizardGames.Soc.SocClient.Ui.CostumeItemData,FairyGUI.EventContext> clickBack; // 0x30
	System.Boolean <IsSelect>k__BackingField; // 0x38
	System.Boolean <IsUnlock>k__BackingField; // 0x39
	System.Boolean <IsCollect>k__BackingField; // 0x3a
	FairyGUI.Controller timeLimitCtr; // 0x40
	System.Boolean <IsWear>k__BackingField; // 0x48
	FairyGUI.Controller newStateCtr; // 0x50
	FairyGUI.GLoader appWelfareIconGLoader; // 0x58
	System.Void set_LobbyCostumeIns(WizardGames.Soc.SocClient.Ui.UiLobbyCostume value); // 0x061f5af0
	WizardGames.Soc.SocClient.Ui.UiLobbyCostume get_LobbyCostumeIns(); // 0x061f5b70
	System.Void set_CurPart(System.Int32 value); // 0x061f5bd4
	System.Int32 get_CurPart(); // 0x061f5c4c
	System.Void set_CostumeCfg(WizardGames.Soc.Common.Data.DataItem.CostumeConfig value); // 0x061f5cb0
	WizardGames.Soc.Common.Data.DataItem.CostumeConfig get_CostumeCfg(); // 0x061f5d30
	System.Void set_Com(FairyGUI.GComponent value); // 0x061f5d94
	FairyGUI.GComponent get_Com(); // 0x061f5e14
	System.Void set_IsSelect(System.Boolean value); // 0x061f5e78
	System.Boolean get_IsSelect(); // 0x061f5ef4
	System.Void set_IsUnlock(System.Boolean value); // 0x061f5f58
	System.Boolean get_IsUnlock(); // 0x061f5fd4
	System.Void set_IsCollect(System.Boolean value); // 0x061f6038
	System.Boolean get_IsCollect(); // 0x061f60b4
	System.Void set_IsWear(System.Boolean value); // 0x061f6118
	System.Boolean get_IsWear(); // 0x061f6194
	System.Void SetData(WizardGames.Soc.SocClient.Ui.UiLobbyCostume UiLobbyCostumeIns, System.Action<WizardGames.Soc.SocClient.Ui.CostumeItemData,FairyGUI.EventContext> back, WizardGames.Soc.Common.Data.DataItem.CostumeConfig data, FairyGUI.GComponent com, System.Int32 curPart); // 0x061eec3c
	System.Void UpdataSelect(System.Boolean isSelect); // 0x061f6b90
	System.Void RefreshAppWelfareInfo(System.Int64 skinId); // 0x061f6ecc
	System.Void UpdataTimeLimit(); // 0x061f6d5c
	System.Boolean CheckCostumeIsWear(System.Int64 costumeId); // 0x061f61f8
	System.Void OnClickPartItem(FairyGUI.EventContext context); // 0x061f6600
	System.Void UpdataCollect(); // 0x061f63a8
	System.Void Reset(); // 0x061f30ec
	System.Void .ctor(); // 0x061f3084
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyGesture : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon weaponIns; // 0x10
	FairyGUI.GList comList; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.GestureConfig> GestureCfgList; // 0x20
	WizardGames.Soc.SocClient.Ui.GSkinGestureItem <CurSelectItem>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.GSkinGestureItem oldSelectItem; // 0x30
	WizardGames.Soc.SocClient.Ui.ComRoulette roulette; // 0x38
	FairyGUI.GComponent content; // 0x40
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> gestureDataDic; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.GSkinGestureItem> gestureItemList; // 0x50
	System.Int32 activeIndex; // 0x58
	FairyGUI.GButton perspectiveBtn; // 0x60
	FairyGUI.GButton thirdpersonBtn; // 0x68
	FairyGUI.Controller perspectiveCtr; // 0x70
	System.Void set_CurSelectItem(WizardGames.Soc.SocClient.Ui.GSkinGestureItem value); // 0x061f7064
	WizardGames.Soc.SocClient.Ui.GSkinGestureItem get_CurSelectItem(); // 0x061f70e4
	System.Void Init(WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon _weaponIns, FairyGUI.GComponent rootContent, FairyGUI.GList _comList); // 0x061f7148
	System.Void InitGestureData(); // 0x061f74f0
	System.Void SetRoulette(); // 0x061f7998
	System.Void SelectGestureBack(System.Int32 selectIndex); // 0x061f7c40
	System.Void OnClickItemBack(); // 0x061f7d1c
	System.Void ClearGestureBack(); // 0x061f8540
	System.Void ResetGestureData(System.Int32 index); // 0x061f8458
	System.Void UpdataWnd(); // 0x061f8818
	System.Single GetSkinDataWeight(WizardGames.Soc.Common.Data.DataItem.GestureConfig cfg); // 0x061f8f10
	System.Void OnRenderItem(System.Int32 index, FairyGUI.GObject obj); // 0x061f9008
	System.Void SetPerSpectVisible(System.Boolean isShow); // 0x061f91b0
	System.Void SetPerspective(System.String pageName); // 0x061f8ddc
	System.Void OnClickPerspective(); // 0x061f924c
	System.Void OnClickThirdPerson(); // 0x061f97dc
	System.Void CancelSelect(); // 0x061f991c
	System.Void ReSelectOldItem(); // 0x061f9ad8
	System.Void SwtichToView(); // 0x061f8e64
	System.Void SwitchToSet(); // 0x061f9f20
	System.Void SetSelectItem(WizardGames.Soc.SocClient.Ui.GSkinGestureItem item); // 0x061f938c
	System.Void CancelSelectItemFX(); // 0x061f9fb8
	System.Void UpdateEquipState(); // 0x061f9b74
	System.Boolean GetEquipState(WizardGames.Soc.SocClient.Ui.GSkinGestureItem item); // 0x061fa088
	System.Void SyncToServer(); // 0x061fa280
	System.Boolean CheckIsChange(); // 0x061fa48c
	System.Void .ctor(); // 0x061faaa0
	System.Int32 <UpdataWnd>b__23_0(WizardGames.Soc.Common.Data.DataItem.GestureConfig x, WizardGames.Soc.Common.Data.DataItem.GestureConfig y); // 0x061fabb4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.GSkinGestureItem : FairyGUI.GButton
{
	WizardGames.Soc.SocClient.Ui.UiLobbyGesture gestureIns; // 0x318
	FairyGUI.GComponent tabItem; // 0x320
	FairyGUI.GLoader iconLoad; // 0x328
	FairyGUI.Controller equipCtr; // 0x330
	FairyGUI.Controller newStateCtr; // 0x338
	FairyGUI.Controller selectCtr; // 0x340
	FairyGUI.Controller rarityCtr; // 0x348
	FairyGUI.GTextField titleTxt; // 0x350
	WizardGames.Soc.Common.Data.DataItem.GestureConfig <Cfg>k__BackingField; // 0x358
	System.Boolean get_IsLock(); // 0x061fb034
	System.Void set_Cfg(WizardGames.Soc.Common.Data.DataItem.GestureConfig value); // 0x061fb0c4
	WizardGames.Soc.Common.Data.DataItem.GestureConfig get_Cfg(); // 0x061fb144
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x061fb1a8
	System.Void SetData(WizardGames.Soc.SocClient.Ui.UiLobbyGesture gesture, WizardGames.Soc.Common.Data.DataItem.GestureConfig gestureCfg); // 0x061fb440
	System.Void UpdataItem(); // 0x061fb65c
	System.Void OnClickItem(); // 0x061fb930
	System.Void SetSelect(System.Boolean isSelect); // 0x061fb89c
	System.Void .ctor(); // 0x061fbbfc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySaveCostumePop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComponent root; // 0x338
	FairyGUI.GList savePlanList; // 0x340
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.collection.OBJCostumePlan> curShowPlanList; // 0x348
	System.Int32 selectIndex; // 0x350
	System.Boolean hasLockEquip; // 0x354
	System.Void OnInit(); // 0x061fbc64
	System.Void SetHasLockEquip(System.Boolean hasLock); // 0x061fc4f4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x061fc570
	System.Void OnEnable(); // 0x061fc5f0
	System.Void OnRenderItem(System.Int32 index, FairyGUI.GObject obj); // 0x061fc658
	System.Void OnClickSaveBack(); // 0x061fd27c
	System.Void SaveSuccessBack(); // 0x061fda7c
	System.Boolean CheckPlanHaveEquip(System.Int32 planId); // 0x061fd6f8
	System.Void OnDisable(); // 0x061fdc60
	System.Void .ctor(); // 0x061fdcc8
	System.Void <OnInit>b__5_0(); // 0x061fdd54
	System.Void <OnInit>b__5_1(); // 0x061fddc8
	System.Void <OnClickSaveBack>b__10_0(); // 0x061fde34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySaveCostumePop.<>c__DisplayClass9_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbySaveCostumePop <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x061fd214
	System.Void <OnRenderItem>b__0(); // 0x061fdf98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	FairyGUI.GComponent content; // 0x338
	FairyGUI.GComponent root; // 0x340
	FairyGUI.GButton btnEquip; // 0x348
	FairyGUI.GButton btnBuy; // 0x350
	FairyGUI.GTextField desTitle; // 0x358
	FairyGUI.Controller desLevleController; // 0x360
	FairyGUI.GTextField desDetail; // 0x368
	System.Boolean loaderShaderSetted; // 0x370
	FairyGUI.GLoader loaderModel; // 0x378
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel playerModel; // 0x380
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.SkinArmorType> primaryTabConfig; // 0x388
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.SkinArmorConfig> OnePartTabConfig; // 0x390
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.OBJSkin>> OnePartAllSkinDic; // 0x398
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.OBJSkin>> AllArmorSkinDic; // 0x3a0
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.GSkinArmorItem> secondaryTabItem; // 0x3a8
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.SkinConfig> skinListConfig; // 0x3b0
	WizardGames.Soc.SocClient.Ui.GSkinArmorItem curSelectArmor; // 0x3b8
	FairyGUI.GComponent titleCom; // 0x3c0
	FairyGUI.Controller titleComCtr; // 0x3c8
	FairyGUI.GTextField limitTimeTxt; // 0x3d0
	System.Boolean hasLockEquip; // 0x3d8
	System.Boolean selectSuit; // 0x3d9
	WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.ESkinOrderType <OrderType>k__BackingField; // 0x3dc
	System.Int32 <SelectedSecondIndex>k__BackingField; // 0x3e0
	System.Int32 <SelectedIndex>k__BackingField; // 0x3e4
	WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.EFirstTabType <SelectedFirstIndex>k__BackingField; // 0x3e8
	System.Boolean <IsEditPlan>k__BackingField; // 0x3ec
	System.Int32 <EditPlanId>k__BackingField; // 0x3f0
	System.Boolean isShowModel; // 0x3f4
	System.Int64 EquippedSkinId; // 0x3f8
	System.Int32 SelectSkinId; // 0x400
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> CachedSkin; // 0x408
	FairyGUI.Controller Status; // 0x410
	FairyGUI.Controller equipStateCtr; // 0x418
	System.Collections.Generic.List<Bright.Config.BeanBase> skinVirtualListDatas; // 0x420
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> virtualToSkinCfg; // 0x428
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> virtualToOriginSkin; // 0x430
	WizardGames.Soc.SocClient.Ui.ComDualTabs comdualTab; // 0x438
	FairyGUI.GList thirdTab; // 0x440
	FairyGUI.GComponent comDescription; // 0x448
	WizardGames.Soc.SocClient.Ui.ComComboBox sortCom; // 0x450
	WizardGames.Soc.SocClient.Ui.ComComboBox editPlanChose; // 0x458
	FairyGUI.GButton btnPreview; // 0x460
	FairyGUI.GComponent actionTip; // 0x468
	FairyGUI.GButton switchLightBtn; // 0x470
	FairyGUI.GButton switchSexBtn; // 0x478
	FairyGUI.GButton highLightBtn; // 0x480
	FairyGUI.GButton actionBtn; // 0x488
	FairyGUI.Controller sexCtr; // 0x490
	FairyGUI.Controller lightCtr; // 0x498
	System.Collections.Generic.List<System.String> editPlanName; // 0x4a0
	WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.ENewSkinOrderType curSortType; // 0x4a8
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> editEquipPlan; // 0x4b0
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> editCostumePlan; // 0x4b8
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> tempEquipPlan; // 0x4c0
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> tempCostumePlan; // 0x4c8
	WizardGames.Soc.SocClient.Ui.UiLobbyCostume costumeIns; // 0x4d0
	FairyGUI.GList costumePartList; // 0x4d8
	FairyGUI.GList costumeSuitList; // 0x4e0
	FairyGUI.GList costumePlanList; // 0x4e8
	FairyGUI.GButton suitBtn; // 0x4f0
	FairyGUI.GButton planBtn; // 0x4f8
	FairyGUI.GButton savePlanBtn; // 0x500
	FairyGUI.GButton saveEditPlanBtn; // 0x508
	FairyGUI.GObject collectBtn; // 0x510
	FairyGUI.GObject shareBtn; // 0x518
	FairyGUI.Controller collectCtr; // 0x520
	FairyGUI.Controller shareCtr; // 0x528
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x530
	FairyGUI.GButton showOptionBtn; // 0x538
	FairyGUI.GComponent optionRoot; // 0x540
	WizardGames.Soc.SocClient.Ui.GSkinOptionTip optionTipIns; // 0x548
	FairyGUI.GButton btnModify; // 0x550
	FairyGUI.GTextField lockedComTextField; // 0x558
	WizardGames.Soc.SocClient.Ui.ComAppWelfareText skinWeaponAppWelfareCom; // 0x560
	WizardGames.Soc.SocClient.MallSkinData saveMallSkinData; // 0x568
	System.Void set_OrderType(WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.ESkinOrderType value); // 0x061fe00c
	System.Int32 get_SelectedSecondIndex(); // 0x061fe084
	System.Void set_SelectedSecondIndex(System.Int32 value); // 0x061fe0e8
	System.Int32 get_SelectedIndex(); // 0x061fe160
	System.Void set_SelectedIndex(System.Int32 value); // 0x061fe1c4
	WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.EFirstTabType get_SelectedFirstIndex(); // 0x061fe23c
	System.Void set_SelectedFirstIndex(WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.EFirstTabType value); // 0x061fe2a0
	System.Boolean get_IsEditPlan(); // 0x061fe318
	System.Void set_IsEditPlan(System.Boolean value); // 0x061fe37c
	System.Int32 get_EditPlanId(); // 0x061fe3f8
	System.Void set_EditPlanId(System.Int32 value); // 0x061fe45c
	System.Void OnInit(); // 0x061fe4d4
	System.Void InitAllArmorSkinTypeDatas(); // 0x062007c8
	System.Void InitComDualTab(); // 0x06200ee8
	System.Boolean IsHasNewSkin(WizardGames.Soc.Common.Data.DataItem.SkinArmorType skinArmorType); // 0x06201984
	System.Boolean IsHasNewSkin(WizardGames.Soc.Common.Data.DataItem.CostumePartConfig costumePartConfig, WizardGames.Soc.SocClient.Ui.UiLobbyCostume uiLobbyCostume); // 0x06201630
	System.Void RefreshDualTabRedDot(); // 0x06201d14
	System.Void UpdateSecondTab(System.Int32 parentIndex, System.Collections.Generic.List<System.String> secondDatas); // 0x06201fec
	System.Void FirstTabBack(System.Int32 index); // 0x06202108
	System.Void SecondTabBack(System.Int32 first, System.Int32 second); // 0x062029a8
	System.Void UpdataTitleCom(); // 0x06203a7c
	System.Void RenderThirdTab(System.Int32 index, FairyGUI.GObject obj); // 0x06204320
	System.Void SelectSkinItem(WizardGames.Soc.SocClient.Ui.GSkinArmorItem clickItem); // 0x06204810
	System.Void UpdateSecondaryTabConfig(); // 0x06202ed0
	System.Void UpdateOnePartAllSkin(); // 0x062032e0
	System.Void UpdataSecondIcon(); // 0x062021cc
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> ChoseEquipPlanDic(); // 0x062058a0
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> ChoseCostumePlanDic(); // 0x06205958
	System.String CheckIsWearSuit(); // 0x06205a10
	System.Boolean CheckCostumeIsEquip(System.Int64 costumeId); // 0x06205d34
	System.Void ShowSelectData(System.Boolean isShow); // 0x06202ca8
	System.Void SetCollect(System.String pageName); // 0x06206260
	System.Void SetShare(System.String pageName); // 0x062062e8
	System.Void OnSuitBtnClick(); // 0x06206370
	System.Void OnPlanBtnClick(); // 0x06206440
	System.Void OnClickSavePlanBack(); // 0x06206504
	System.Void UpdateHasLockEquip(System.Collections.Generic.Dictionary<System.Int32,System.Int32> equipDic, System.Collections.Generic.Dictionary<System.Int32,System.Int32> costumeDic); // 0x0620664c
	System.Void OnClickSaveEditPlanBack(); // 0x06206a88
	System.Void OnClickShareBack(); // 0x06207330
	System.Void OnClickCollectBack(); // 0x06207860
	System.Void OnReceiveCollect(); // 0x062081b4
	System.Void RefreshEditPlan(System.Boolean isEditor, System.Int32 editorId); // 0x0620825c
	System.String GetEditPlanName(); // 0x062071b8
	System.Void OnSortRefreshBack(System.Int32 index); // 0x062091b0
	System.Void OnEditPlanRefreshBack(System.Int32 index); // 0x062092c8
	System.Void RefreshPlan(); // 0x062096d0
	System.Void OnAvatarChange(); // 0x062097d0
	System.Void InitTempPlan(); // 0x061fffe8
	System.Void OnEnable(); // 0x06209918
	System.Void OnDisable(); // 0x0620a0c0
	System.Void OnDestroy(); // 0x0620a358
	System.Void BeforeClose(); // 0x0620a3c0
	System.Boolean CheckEditPlanDiff(); // 0x0620a824
	System.Boolean CheckPartIsLow(System.Int32 partSkinId, System.Boolean partIsEquip, System.Collections.Generic.Dictionary<System.Int32,System.Int32> targetDic); // 0x0620ad7c
	System.Void RefreshEquipBtn(); // 0x062049e4
	System.Void SetLimitTimeTxt(); // 0x06205f50
	System.Void RefreshCollectBtn(); // 0x06204f08
	System.Void SetEquipState(System.String state); // 0x06205ec0
	System.Void RefreshInUseTextPrivilegeInfo(); // 0x0620b2b4
	System.Void SetEquipSkinDesc(); // 0x062051e8
	System.Void RefreshDescription(System.String title, System.String desc, System.Int32 level); // 0x0620b43c
	System.Void UpdatePrimaryTabConfig(); // 0x06201444
	System.Void InitDescriptionCom(); // 0x06200300
	System.Void InitSkinWeaponAppWelfareCom(); // 0x06200620
	System.Void RefreshSkinWeaponAppWelfareInfo(); // 0x06205400
	System.Void OnReceiveArmorSkinInfo(); // 0x0620b518
	System.Void OnReceiveEquipResult(); // 0x0620b578
	System.Void OnMallSkinChange(WizardGames.Soc.SocClient.MallSkinData mallSkinData); // 0x0620b818
	System.Void OnClickBuy(); // 0x0620bbbc
	System.Int32 GetCurSkinId(); // 0x0620ba4c
	System.Void OnClickEquipBtn(); // 0x0620bc8c
	System.Void OnClickPreviewBtn(); // 0x0620c170
	System.Void UpdateModifyState(); // 0x0620547c
	System.Void OnClickModifyBtn(); // 0x0620c5c8
	System.Void RefreshEquipBtnGroup(); // 0x06203e00
	System.Void OnClickSwtichLightBtn(); // 0x0620c7d8
	System.Void OnClickSwitchSexBtn(); // 0x0620ca54
	System.Void OnClickHighLightBtn(); // 0x0620cb2c
	System.Void OnClickActionBtn(); // 0x0620ce04
	System.Void OnClickEnterAction(); // 0x0620cf40
	System.Void OnClickShowAction(); // 0x0620d248
	System.Void MakeFullScreen(); // 0x0620d550
	System.Void InitModel(); // 0x06209db4
	System.Void RefreshModel(); // 0x06208afc
	System.Void OnFps10Update(System.Single dt); // 0x0620d5b8
	System.Void SetLoaderImgShader(); // 0x0620d648
	System.Void .ctor(); // 0x0620d868
	System.Void <OnInit>b__110_0(FairyGUI.EventContext ctx); // 0x0620dc28
	WizardGames.Soc.SocClient.GoLoader.DisplayModel <OnInit>b__110_1(); // 0x0620dca0
	System.Void <OnInit>b__110_2(); // 0x0620dd48
	System.Void <OnInit>b__110_3(FairyGUI.EventContext ctx); // 0x0620ddb8
	System.Void <OnInit>b__110_4(FairyGUI.EventContext ctx); // 0x0620de30
	System.Int32 <UpdateOnePartAllSkin>b__124_0(WizardGames.Soc.Common.Data.resource.OBJSkin x, WizardGames.Soc.Common.Data.resource.OBJSkin y); // 0x0620dea8
	System.Int32 <UpdateOnePartAllSkin>b__124_1(WizardGames.Soc.Common.Data.resource.OBJSkin x, WizardGames.Soc.Common.Data.resource.OBJSkin y); // 0x0620e348
	System.Void <OnClickShareBack>b__138_0(); // 0x0620e78c
	System.Void <BeforeClose>b__151_0(); // 0x0620e808
	System.Void <BeforeClose>b__151_1(); // 0x0620e874
	System.Void <OnClickEquipBtn>b__171_0(); // 0x0620e8e8
	System.Void <OnClickEquipBtn>b__171_1(); // 0x0620e95c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.ESkinOrderType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.ESkinOrderType Default = 0;
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.ESkinOrderType Quality = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.ENewSkinOrderType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.ENewSkinOrderType Default = 0;
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.ENewSkinOrderType GetTime = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.EFirstTabType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.EFirstTabType Costume = 0;
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.EFirstTabType Equip = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Data.DataItem.SkinArmorConfig> <>9__111_0; // 0x8
	static System.Comparison<WizardGames.Soc.Common.Data.DataItem.SkinArmorConfig> <>9__123_0; // 0x10
	static System.Comparison<WizardGames.Soc.Common.Data.DataItem.SkinArmorType> <>9__162_0; // 0x18
	static System.Void .cctor(); // 0x0620e9d0
	System.Void .ctor(); // 0x0620ea34
	System.Int32 <InitAllArmorSkinTypeDatas>b__111_0(WizardGames.Soc.Common.Data.DataItem.SkinArmorConfig config1, WizardGames.Soc.Common.Data.DataItem.SkinArmorConfig config2); // 0x0620ea9c
	System.Int32 <UpdateSecondaryTabConfig>b__123_0(WizardGames.Soc.Common.Data.DataItem.SkinArmorConfig config1, WizardGames.Soc.Common.Data.DataItem.SkinArmorConfig config2); // 0x0620eb30
	System.Int32 <UpdatePrimaryTabConfig>b__162_0(WizardGames.Soc.Common.Data.DataItem.SkinArmorType config1, WizardGames.Soc.Common.Data.DataItem.SkinArmorType config2); // 0x0620ebc4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EBuildingSkinTexture : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EBuildingSkinTexture Wood = 0;
	static WizardGames.Soc.SocClient.Ui.EBuildingSkinTexture Stone = 1;
	static WizardGames.Soc.SocClient.Ui.EBuildingSkinTexture Iron = 2;
	static WizardGames.Soc.SocClient.Ui.EBuildingSkinTexture Steel = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySkinBuilding : WizardGames.Soc.SocClient.Ui.UiLobbySkinBase
{
	System.Int32 currentFirstMenuId; // 0x390
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.constraction.BuildingSkinFirstMenu> firstMenuList; // 0x398
	System.Int32 currentSecondMenuId; // 0x3a0
	System.Int32 currentMenuId; // 0x3a4
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.constraction.BuildingSkinSecondMenu> secondMenuList; // 0x3a8
	System.Int32 curSelelctIndex; // 0x3b0
	System.Int64 currentSkinId; // 0x3b8
	System.Int64 currentEquipedSkinId; // 0x3c0
	System.Int64 currentHostItemId; // 0x3c8
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.constraction.BuildingCoreSkin> thirdBuildingSuitList; // 0x3d0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SkinData> thirdFurnitureList; // 0x3d8
	System.Collections.Generic.List<System.Int64> suitDetailList; // 0x3e0
	System.Int32 lastClickTime; // 0x3e8
	FairyGUI.GButton btnModify; // 0x3f0
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int64>> allSkinDic; // 0x3f8
	System.Boolean isFirst; // 0x400
	System.Void OnInit(); // 0x0620ec58
	System.Void InitData(); // 0x0620f6b0
	System.Void OnEnable(); // 0x06211bb4
	System.Void OnDisable(); // 0x06214178
	System.Void OnDestroy(); // 0x062141f4
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.constraction.BuildingSkinFirstMenu> SortFirstMenu(); // 0x06210cf4
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.constraction.BuildingSkinSecondMenu> GetSecondMenu(System.Int32 firstMenuId); // 0x06211078
	System.Void RefreshThirdTab(System.Int32 firstMenuId, System.Int32 secondMenuid, System.Boolean isDefaultSelect); // 0x062123c8
	System.Void OnFirstTabClick(System.Int32 id); // 0x062144c0
	System.Void OnSecondTabClick(System.Int32 firstId, System.Int32 secondId); // 0x06214660
	System.Void OnThirdTabClick(FairyGUI.EventContext context); // 0x06214e68
	System.Void RefreshDualTabRedDot(); // 0x06218e14
	System.Boolean IsValidMenu(System.Int32 tieroneTagId, System.Int32 tierTwoTagId); // 0x06219614
	System.Boolean IsHasNewBuildingSkin(System.Int32 tieroneTagId, System.Int32 tierTwoTagId); // 0x06211410
	System.Boolean GetIsSkinNew(System.Int32 skinId); // 0x062197bc
	System.Void MakeFullScreen(); // 0x062198d0
	System.Void OnClickChangeDoor(); // 0x06219938
	System.Void OnBgClick(FairyGUI.EventContext context); // 0x06219c9c
	System.Void SuitDetailItemClick(FairyGUI.EventContext context); // 0x0621a120
	System.Void SetLimitTimeTxt(); // 0x06218f20
	System.Void ThirdTabItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x0621ac18
	System.Void UpdateModifyState(); // 0x0621943c
	System.Void OnClickModifyBtn(); // 0x0621b650
	System.Void SuitDetailItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x0621b704
	System.Void BtnEquipSkinClick(FairyGUI.EventContext context); // 0x0621bd40
	System.Void EquipSkin(System.Boolean isEquip); // 0x0621c530
	System.Void SetEquipState(System.String page); // 0x0621c6e4
	System.Int32 GetCurSkinId(); // 0x0621c760
	System.Void RefreshEquipBtn(System.String pageName); // 0x06214c6c
	System.Void BtnPreviewClick(FairyGUI.EventContext context); // 0x0621c7c4
	System.Void BtnCollectClick(FairyGUI.EventContext context); // 0x0621ca14
	System.Void BtnShareClick(FairyGUI.EventContext context); // 0x0621ce8c
	System.Void Select(System.Int32 menu_1, System.Int32 menu_2); // 0x06211b20
	System.Void CheckHighLight(); // 0x06219224
	System.Void OnHighLightClick(FairyGUI.EventContext context); // 0x0621d228
	static System.Void OpenBuildingSkin(WizardGames.Soc.SocClient.Ui.EBuildingSkinTexture texture, System.Int64 partEntityId); // 0x0621d364
	System.Void BeforeClose(); // 0x0621d570
	System.Void .ctor(); // 0x0621d60c
	System.Void <OnInit>b__18_0(FairyGUI.EventContext ctx); // 0x0621d780
	System.Void <InitData>b__19_0(System.Int32 index); // 0x0621d7f8
	System.Int32 <InitData>b__19_2(WizardGames.Soc.Common.Data.constraction.BuildingCoreSkin a, WizardGames.Soc.Common.Data.constraction.BuildingCoreSkin b); // 0x0621dacc
	System.Void <BtnEquipSkinClick>b__42_0(); // 0x0621db70
	System.Void <BtnEquipSkinClick>b__42_1(); // 0x0621dcec
	System.Void <EquipSkin>b__43_0(); // 0x0621de68
	System.Void <EquipSkin>b__43_1(); // 0x0621e008
	System.Void <BtnCollectClick>b__48_0(); // 0x0621e1a4
	System.Void <BtnCollectClick>b__48_1(); // 0x0621e588
	System.Void <BtnShareClick>b__49_0(); // 0x0621e96c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySkinBuilding.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinBuilding.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Data.constraction.BuildingSkinFirstMenu> <>9__23_0; // 0x8
	static System.Comparison<WizardGames.Soc.Common.Data.constraction.BuildingSkinSecondMenu> <>9__24_0; // 0x10
	static System.Void .cctor(); // 0x0621eb14
	System.Void .ctor(); // 0x0621eb78
	System.Int32 <SortFirstMenu>b__23_0(WizardGames.Soc.Common.Data.constraction.BuildingSkinFirstMenu a, WizardGames.Soc.Common.Data.constraction.BuildingSkinFirstMenu b); // 0x0621ebe0
	System.Int32 <GetSecondMenu>b__24_0(WizardGames.Soc.Common.Data.constraction.BuildingSkinSecondMenu a, WizardGames.Soc.Common.Data.constraction.BuildingSkinSecondMenu b); // 0x0621ec74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySkinBuilding.<>c__DisplayClass19_0 : System.Object
{
	System.Int64 curEquipSkinId; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLobbySkinBuilding <>4__this; // 0x18
	System.Void .ctor(); // 0x0621ed08
	System.Int32 <InitData>b__1(WizardGames.Soc.SocClient.Ui.SkinData a, WizardGames.Soc.SocClient.Ui.SkinData b); // 0x0621ed70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySkinBuilding.<>c__DisplayClass25_0 : System.Object
{
	System.Int64 equipSkinId; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLobbySkinBuilding <>4__this; // 0x18
	System.Void .ctor(); // 0x0621ef48
	System.Int32 <RefreshThirdTab>b__0(WizardGames.Soc.Common.Data.constraction.BuildingCoreSkin a, WizardGames.Soc.Common.Data.constraction.BuildingCoreSkin b); // 0x0621efb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySkinBuilding.<>c__DisplayClass25_1 : System.Object
{
	System.Int64 equipSkinId; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLobbySkinBuilding <>4__this; // 0x18
	System.Void .ctor(); // 0x0621f058
	System.Int32 <RefreshThirdTab>b__1(WizardGames.Soc.SocClient.Ui.SkinData a, WizardGames.Soc.SocClient.Ui.SkinData b); // 0x0621f0c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySkinBuilding.<>c__DisplayClass27_0 : System.Object
{
	System.Int32 secondId; // 0x10
	System.Void .ctor(); // 0x0621f298
	System.Boolean <OnSecondTabClick>b__0(WizardGames.Soc.Common.Data.constraction.BuildingSkinSecondMenu x); // 0x0621f300
	System.Boolean <OnSecondTabClick>b__1(WizardGames.Soc.Common.Data.constraction.BuildingSkinSecondMenu x); // 0x0621f38c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySkinEntrance : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComponent weaponNewTag; // 0x338
	FairyGUI.GComponent armorNewTag; // 0x340
	FairyGUI.GComponent buildingNewTag; // 0x348
	FairyGUI.GComponent content; // 0x350
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x358
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel playerModel; // 0x360
	FairyGUI.GLoader loaderModel; // 0x368
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootLobbySkinEntranceContentBinder contentContentBinder; // 0x370
	System.Void OnInit(); // 0x0621f418
	System.Void OnClickArmorBack(FairyGUI.EventContext context); // 0x0621fcf0
	System.Void OnClickBuildBack(); // 0x0621fddc
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0621feb4
	System.Void OnEnable(); // 0x0621ff34
	System.Void OnDestroy(); // 0x06220064
	System.Void OnDisable(); // 0x06220128
	System.Void .ctor(); // 0x062201ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySkinEntrance.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinEntrance.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__8_0; // 0x8
	static System.Void .cctor(); // 0x06220238
	System.Void .ctor(); // 0x0622029c
	System.Void <OnInit>b__8_0(); // 0x06220304
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	WizardGames.Soc.SocClient.Ui.ComComboBox sortCom; // 0x338
	FairyGUI.Controller showCtr; // 0x340
	FairyGUI.GButton btnEquipToLobby; // 0x348
	FairyGUI.GButton btnEquip; // 0x350
	FairyGUI.GButton btnUnEquip; // 0x358
	FairyGUI.GButton btnBuy; // 0x360
	FairyGUI.GTextField desTitle; // 0x368
	FairyGUI.Controller desLevleController; // 0x370
	FairyGUI.GTextField desDetail; // 0x378
	WizardGames.Soc.SocClient.Ui.ComUiModel uiModel; // 0x380
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel fpPlayerModel; // 0x388
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel tpPlayerModel; // 0x390
	System.Boolean loaderShaderSetted; // 0x398
	System.Collections.Generic.List<System.Int64> sparyIdList; // 0x3a0
	System.Collections.Generic.List<System.Int64> gestureIdList; // 0x3a8
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.SkinWeaponType> primaryTabConfig; // 0x3b0
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.SkinWeaponConfig> secondaryTabConfig; // 0x3b8
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.GSkinWeaponItem> secondaryTabItem; // 0x3c0
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.SkinConfig> skinListConfig; // 0x3c8
	WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon.ESkinOrderType <OrderType>k__BackingField; // 0x3d0
	WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon.ECustomType curCustType; // 0x3d4
	System.Int32 <SelectedPrimaryIndex>k__BackingField; // 0x3d8
	System.Int32 <SelectedSecondaryIndex>k__BackingField; // 0x3dc
	System.Boolean <SecondaryIsFold>k__BackingField; // 0x3e0
	System.Int32 <SelectedSkinIndex>k__BackingField; // 0x3e4
	System.Int64 EquippedSkinId; // 0x3e8
	FairyGUI.Controller Status; // 0x3f0
	System.Collections.Generic.List<Bright.Config.BeanBase> skinVirtualListDatas; // 0x3f8
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> virtualToSkinCfg; // 0x400
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> virtualToOriginSkin; // 0x408
	System.Int32 isRefreshView; // 0x410
	FairyGUI.GComponent uiRootContent; // 0x418
	FairyGUI.GComponent uiRoot; // 0x420
	WizardGames.Soc.SocClient.Ui.ComDualTabs comdualTab; // 0x428
	WizardGames.Soc.Common.Data.WeaponSkinType <SelectedFirstIndex>k__BackingField; // 0x430
	FairyGUI.GList thirdTab; // 0x438
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.SkinWeaponConfig> OnePartTabConfig; // 0x440
	System.Int32 <SelectedSecondIndex>k__BackingField; // 0x448
	System.Int32 <SelectedIndex>k__BackingField; // 0x44c
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.OBJSkin>> OnePartAllSkinDic; // 0x450
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.OBJSkin>> AllSkinDic; // 0x458
	WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.ENewSkinOrderType curSortType; // 0x460
	FairyGUI.GComponent comDescription; // 0x468
	FairyGUI.Controller collectCtr; // 0x470
	FairyGUI.GObject collectBtn; // 0x478
	FairyGUI.Controller shareCtr; // 0x480
	FairyGUI.GObject shareBtn; // 0x488
	WizardGames.Soc.SocClient.Ui.GSkinWeaponItem curSelectWeapon; // 0x490
	System.Int32 SelectSkinId; // 0x498
	FairyGUI.GButton weaponBtn; // 0x4a0
	FairyGUI.GButton charmBtn; // 0x4a8
	FairyGUI.GComponent titleCom; // 0x4b0
	FairyGUI.Controller titleComCtr; // 0x4b8
	FairyGUI.GButton highLightBtn; // 0x4c0
	FairyGUI.GButton switchLightBtn; // 0x4c8
	FairyGUI.Controller lightCtr; // 0x4d0
	FairyGUI.GTextField limitTimeTxt; // 0x4d8
	FairyGUI.GGroup btnGroup; // 0x4e0
	FairyGUI.GGroup descGroup; // 0x4e8
	FairyGUI.GButton btnPreview; // 0x4f0
	FairyGUI.GButton btnModify; // 0x4f8
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x500
	System.Boolean firstSelect; // 0x508
	FairyGUI.GList charmList; // 0x510
	FairyGUI.GList customList; // 0x518
	WizardGames.Soc.SocClient.Ui.UiLobbyGesture gestureIns; // 0x520
	WizardGames.Soc.SocClient.Ui.UiLobbySpray sprayIns; // 0x528
	FairyGUI.Controller CustomViewCtr; // 0x530
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> sprayAndGestureDic; // 0x538
	System.Int32 gestureType; // 0x540
	System.Int32 sprayType; // 0x544
	WizardGames.Soc.SocClient.Ui.UiLobbyCharm charmIns; // 0x548
	WizardGames.Soc.SocClient.Ui.ComAppWelfareText leftSkinWeaponAppWelfareCom; // 0x550
	WizardGames.Soc.SocClient.Ui.ComAppWelfareText rightSkinWeaponAppWelfareCom; // 0x558
	FairyGUI.GComponent tipsCom; // 0x560
	FairyGUI.GTextField inUseComTextField; // 0x568
	System.Boolean isInit; // 0x570
	FairyGUI.GLoader bgLoader; // 0x578
	FairyGUI.GButton finishConfigBtn; // 0x580
	WizardGames.Soc.SocClient.MallSkinData saveMallSkinData; // 0x588
	System.Void set_OrderType(WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon.ESkinOrderType value); // 0x062203dc
	System.Void set_SelectedPrimaryIndex(System.Int32 value); // 0x06220454
	System.Void set_SelectedSecondaryIndex(System.Int32 value); // 0x062204cc
	System.Void set_SecondaryIsFold(System.Boolean value); // 0x06220544
	System.Void set_SelectedSkinIndex(System.Int32 value); // 0x062205c0
	WizardGames.Soc.Common.Data.WeaponSkinType get_SelectedFirstIndex(); // 0x06220638
	System.Void set_SelectedFirstIndex(WizardGames.Soc.Common.Data.WeaponSkinType value); // 0x0622069c
	System.Int32 get_SelectedSecondIndex(); // 0x06220714
	System.Void set_SelectedSecondIndex(System.Int32 value); // 0x06220778
	System.Int32 get_SelectedIndex(); // 0x062207f0
	System.Void set_SelectedIndex(System.Int32 value); // 0x06220854
	System.Void OnInit(); // 0x062208cc
	System.Void OnEnable(); // 0x062234a4
	System.Void OneSharePopQuit(); // 0x0622413c
	System.Void OnDestroy(); // 0x062241e8
	System.Void OnDisable(); // 0x062242a0
	System.Void InitComDualTab(); // 0x06222fd4
	System.Boolean IsHasNewSkin(WizardGames.Soc.Common.Data.DataItem.SkinWeaponType skinWeaponType); // 0x0622485c
	System.Void InitAllSkinTypeDatas(); // 0x062228b4
	System.Void RefreshDualTabRedDot(); // 0x06225024
	System.Void FirstTabBack(System.Int32 index); // 0x0622522c
	System.Void SecondTabBack(System.Int32 first, System.Int32 second); // 0x06225414
	System.Void SetBgLoaderVisivle(System.Boolean show); // 0x06226010
	System.Void SelectSkinItem(WizardGames.Soc.SocClient.Ui.GSkinWeaponItem clickItem); // 0x062278a0
	System.Void UpdataCurList(); // 0x06223da8
	System.Void RenderThirdTab(System.Int32 index, FairyGUI.GObject obj); // 0x06228954
	System.Void UpdateSecondaryTabConfig(); // 0x06226098
	System.Void UpdateOnePartAllSkin(); // 0x062264a8
	System.Void SetEquipSkinDesc(); // 0x06227ed4
	System.Void RefreshCollectBtn(); // 0x06227d84
	System.Void UpdataSecondIcon(); // 0x062253b4
	System.Void SetEquipState(System.String state); // 0x06228fa4
	System.Void UpdateEquipState(); // 0x06227688
	System.Void RefreshInUseTextPrivilegeInfo(); // 0x0622907c
	System.Void OnMallSkinChange(WizardGames.Soc.SocClient.MallSkinData mallSkinData); // 0x062292d8
	System.Void OnClickBuy(); // 0x062298fc
	System.Int32 GetCurSkinId(); // 0x0622950c
	System.Void RefreshEquipBtn(); // 0x06227b44
	System.Void SetLimitTimeTxt(); // 0x062299cc
	System.Void SetLimitTxt(System.String txt); // 0x06229b84
	System.Void RefreshDescription(System.String title, System.String desc, System.Int32 level); // 0x06228ec8
	System.Void UpdataTitleCom(); // 0x06226d00
	System.Void UpdatePrimaryTabConfig(); // 0x06224670
	System.Void OnSortRefreshBack(System.Int32 index); // 0x06229c04
	System.Void InitSkinWeaponAppWelfareCom(); // 0x062225b8
	System.Void RefreshSkinWeaponAppWelfareInfo(); // 0x062281b0
	System.Void OnClickTips(); // 0x06229d64
	System.Void InitDescriptionCom(); // 0x06222298
	System.Void ShowSelectData(System.Boolean isShow); // 0x06225a44
	System.Void SetViewCtr(System.String pageName); // 0x06229ed8
	System.Void SetCollect(System.String pageName); // 0x06226f54
	System.Void SetShare(System.Boolean isShow); // 0x06226e9c
	System.Void OnReceiveWeaponSkinInfo(); // 0x06229f60
	System.Void OnReceiveEquipResult(); // 0x06229fc0
	System.Void OnClickEquipToLobby(); // 0x0622a27c
	System.Void OnClickFinishConfigBtn(); // 0x0622a644
	System.Void ResetByClickFinishConfig(); // 0x0622a6c4
	System.Void ClickEquipBtnByConfigType(); // 0x0622a9c4
	System.Void OnClickEquipBtn(); // 0x0622adf0
	System.Void OnClickUnEquipBtn(); // 0x0622b848
	System.Void OnClickCollectBack(); // 0x0622bac4
	System.Void OnClickShareBtn(); // 0x0622c058
	System.Void OnClickHighLight(); // 0x0622c430
	System.Void OnClickSwitchLight(); // 0x0622c590
	System.Void SwitchCustomView(); // 0x0622a888
	System.Void SwitchCustomSet(); // 0x0622ab98
	System.Void OnClickWeaponBtn(); // 0x0622c948
	System.Void OnClickCharmBtn(); // 0x0622c9f4
	System.Void OnReceiveCollect(); // 0x0622cc10
	System.Void OnClickPreviewBtn(); // 0x0622ccb4
	System.Void UpdateModifyState(); // 0x06228770
	System.Void HideModifyBtn(); // 0x06227614
	System.Void OnClickModifyBtn(); // 0x0622d194
	System.Void RefreshModel(); // 0x06228330
	System.Boolean IsCharmType(); // 0x062288c4
	System.Void OnFps10Update(System.Single dt); // 0x0622d248
	System.Void PlayTpAnim(System.String anim); // 0x0622d2dc
	System.Void CreateTpModel(System.String startAnimPath); // 0x0622d39c
	System.Void MakeFullScreen(); // 0x0622d568
	System.Void PlayFpAnim(System.String anim); // 0x0622d5d0
	System.Void TriggerInterruptEvent(System.String placeholderName); // 0x0622599c
	System.Void CreateFpModel(System.String startAnimPath); // 0x0622d690
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x0622db74
	System.Void .ctor(); // 0x0622dd2c
	System.Void <OnInit>b__109_0(FairyGUI.EventContext context); // 0x0622e0f0
	System.Void <OnInit>b__109_1(FairyGUI.EventContext ctx); // 0x0622e170
	System.Void <OnInit>b__109_2(FairyGUI.EventContext ctx); // 0x0622e1e8
	System.Void <OnClickEquipBtn>b__160_0(); // 0x0622e260
	System.Void <OnClickEquipBtn>b__160_1(); // 0x0622e3e8
	System.Void <OnClickEquipBtn>b__160_2(); // 0x0622e45c
	System.Void <OnClickShareBtn>b__163_0(); // 0x0622e4d0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon.ESkinOrderType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon.ESkinOrderType Default = 0;
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon.ESkinOrderType Quality = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon.ECustomType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon.ECustomType None = 0;
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon.ECustomType Gesture = 1;
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon.ECustomType Spray = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Data.DataItem.SkinWeaponConfig> <>9__116_0; // 0x8
	static System.Comparison<WizardGames.Soc.Common.Data.DataItem.SkinWeaponConfig> <>9__124_0; // 0x10
	static System.Comparison<WizardGames.Soc.Common.Data.resource.OBJSkin> <>9__125_0; // 0x18
	static System.Comparison<WizardGames.Soc.Common.Data.resource.OBJSkin> <>9__125_1; // 0x20
	static System.Comparison<WizardGames.Soc.Common.Data.DataItem.SkinWeaponType> <>9__141_0; // 0x28
	static System.Void .cctor(); // 0x0622e54c
	System.Void .ctor(); // 0x0622e5b0
	System.Int32 <InitAllSkinTypeDatas>b__116_0(WizardGames.Soc.Common.Data.DataItem.SkinWeaponConfig config1, WizardGames.Soc.Common.Data.DataItem.SkinWeaponConfig config2); // 0x0622e618
	System.Int32 <UpdateSecondaryTabConfig>b__124_0(WizardGames.Soc.Common.Data.DataItem.SkinWeaponConfig config1, WizardGames.Soc.Common.Data.DataItem.SkinWeaponConfig config2); // 0x0622e6ac
	System.Int32 <UpdateOnePartAllSkin>b__125_0(WizardGames.Soc.Common.Data.resource.OBJSkin x, WizardGames.Soc.Common.Data.resource.OBJSkin y); // 0x0622e740
	System.Int32 <UpdateOnePartAllSkin>b__125_1(WizardGames.Soc.Common.Data.resource.OBJSkin x, WizardGames.Soc.Common.Data.resource.OBJSkin y); // 0x0622ec68
	System.Int32 <UpdatePrimaryTabConfig>b__141_0(WizardGames.Soc.Common.Data.DataItem.SkinWeaponType config1, WizardGames.Soc.Common.Data.DataItem.SkinWeaponType config2); // 0x0622f134
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySpray : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon weaponIns; // 0x10
	FairyGUI.GList comList; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.SprayConfig> SprayCfgList; // 0x20
	WizardGames.Soc.SocClient.Ui.GSkinSprayItem <CurSelectItem>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.GSkinSprayItem oldSelectItem; // 0x30
	WizardGames.Soc.SocClient.Ui.ComRoulette roulette; // 0x38
	FairyGUI.GComponent content; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.GSkinSprayItem> sprayItemList; // 0x48
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> sprayDataDic; // 0x50
	System.Int32 activeIndex; // 0x58
	WizardGames.Soc.SocClient.Ui.SprayBinder sprayBinder; // 0x60
	FairyGUI.GGraph fxRoot; // 0x68
	FairyGUI.GoWrapper fxSpray; // 0x70
	System.Boolean isPlayFX; // 0x78
	System.Single allFXTime; // 0x7c
	System.Single playFXTime; // 0x80
	System.Boolean isInitFX; // 0x84
	System.Void set_CurSelectItem(WizardGames.Soc.SocClient.Ui.GSkinSprayItem value); // 0x0622f1c8
	WizardGames.Soc.SocClient.Ui.GSkinSprayItem get_CurSelectItem(); // 0x0622f248
	System.Void Init(WizardGames.Soc.SocClient.Ui.UiLobbySkinWeapon _weaponIns, FairyGUI.GComponent contentRoot, FairyGUI.GList _comList); // 0x062220a0
	System.Void InitSprayData(); // 0x0622f2ac
	System.Void SetRoulette(); // 0x0622f77c
	System.Void SelectSprayBack(System.Int32 selectIndex); // 0x0622fa24
	System.Void OnClickItemBack(); // 0x0622fb90
	System.Void ClearSprayBack(); // 0x06230674
	System.Void ResetSprayData(System.Int32 index); // 0x06230350
	System.Void UpdataWnd(); // 0x06226fdc
	System.Single GetSkinDataWeight(WizardGames.Soc.Common.Data.DataItem.SprayConfig cfg); // 0x06230948
	System.Void OnRenderItem(System.Int32 index, FairyGUI.GObject obj); // 0x06230a40
	System.Void CancelSelect(); // 0x0622ac3c
	System.Void ReSelectOldItem(); // 0x0622a92c
	System.Void SwtichToView(); // 0x0622c80c
	System.Void SwitchToSet(); // 0x0622c8b4
	System.Void CancelSelectItemFX(); // 0x062311a4
	System.Void SetSelectItem(WizardGames.Soc.SocClient.Ui.GSkinSprayItem item); // 0x06223a40
	System.Void OnFxSprayDispose(); // 0x062315a4
	System.Void PlaySprayFX(); // 0x06231270
	System.Void StopSprayFX(); // 0x062245c0
	System.Void SetSprayObjVisible(System.Boolean show); // 0x06227580
	System.Void UpdateFPS(); // 0x0622dc6c
	System.Void UpdateEquipState(); // 0x06230e00
	System.Boolean GetEquipState(WizardGames.Soc.SocClient.Ui.GSkinSprayItem item); // 0x06231650
	System.Void .ctor(); // 0x06221f80
	System.Int32 <UpdataWnd>b__27_0(WizardGames.Soc.Common.Data.DataItem.SprayConfig x, WizardGames.Soc.Common.Data.DataItem.SprayConfig y); // 0x06231848
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.GSkinSprayItem : FairyGUI.GButton
{
	WizardGames.Soc.SocClient.Ui.UiLobbySpray SprayIns; // 0x318
	FairyGUI.GComponent tabItem; // 0x320
	FairyGUI.GLoader iconLoad; // 0x328
	FairyGUI.Controller equipCtr; // 0x330
	FairyGUI.Controller newStateCtr; // 0x338
	FairyGUI.Controller selectCtr; // 0x340
	FairyGUI.Controller rarityCtr; // 0x348
	FairyGUI.GTextField titleTxt; // 0x350
	WizardGames.Soc.Common.Data.DataItem.SprayConfig <Cfg>k__BackingField; // 0x358
	System.Boolean get_IsLock(); // 0x062302c0
	System.Void set_Cfg(WizardGames.Soc.Common.Data.DataItem.SprayConfig value); // 0x062319a8
	WizardGames.Soc.Common.Data.DataItem.SprayConfig get_Cfg(); // 0x06231a28
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x06231a8c
	System.Void SetData(WizardGames.Soc.SocClient.Ui.UiLobbySpray Spray, WizardGames.Soc.Common.Data.DataItem.SprayConfig SprayCfg); // 0x06230be4
	System.Void UpdataItem(); // 0x06230438
	System.Void OnClickItem(); // 0x06231d24
	System.Void SetSelect(System.Boolean isSelect); // 0x0622fafc
	System.Void .ctor(); // 0x06231fe4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWeaponPartPop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootWeaponPartBinder binder; // 0x338
	System.Int64[] curShowAccess; // 0x340
	System.Int32 curSkinId; // 0x348
	System.Int32[] allAccess; // 0x350
	System.Collections.Generic.List<FairyGUI.GComponent> showItems; // 0x358
	System.Void OnInit(); // 0x0623204c
	System.Void OnEnable(); // 0x062324bc
	System.Void OnDisable(); // 0x06232524
	System.Void UpdateWeaponPart(System.Int32 skinId); // 0x0623258c
	System.Void OnRenderItem(System.Int32 index, FairyGUI.GObject obj); // 0x06232be4
	System.Void UpdateSelect(); // 0x06232a58
	System.Void OnClickWeaponPart(FairyGUI.EventContext context); // 0x06232e34
	System.Void OnClickNormal(); // 0x06233094
	System.Void OnClickSuper(); // 0x062330fc
	System.Void .ctor(); // 0x06233164
	System.Void <OnInit>b__5_0(); // 0x0623323c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.LobbyStashIPropData : System.Object
{
	System.Boolean IsRed; // 0x10
	System.String uniqueID; // 0x18
	System.Int32 id; // 0x20
	System.Int32 amount; // 0x24
	System.Int64 expireAt; // 0x28
	System.Int64 latestUpdate; // 0x30
	System.String get_UniqueID(); // 0x062332a8
	System.Int32 get_Id(); // 0x0623330c
	System.Int32 get_Amount(); // 0x06233370
	System.Int64 get_ExpireAt(); // 0x062333d4
	System.Int64 get_LatestUpdate(); // 0x06233438
	System.Void .ctor(SimpleJSON.JSONNode prop); // 0x0623349c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.LobbyStashProfileData : System.Object
{
	System.Boolean IsRed; // 0x10
	System.Int32 id; // 0x14
	System.Int32 amount; // 0x18
	System.Int64 expireAt; // 0x20
	System.Int32 get_Id(); // 0x06233694
	System.Int64 get_ExpireAt(); // 0x062336f8
	System.Boolean get_IsLimited(); // 0x0623375c
	System.Boolean get_IsExpired(); // 0x062337c8
	System.Void .ctor(SimpleJSON.JSONNode prop); // 0x062338f4
	System.Void .ctor(System.Int32 id, System.Int32 amount, System.Int64 expireAt); // 0x06233a3c
	System.Void ChangeData(System.Int32 id, System.Int32 amount, System.Int64 expireAt); // 0x06233ae0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyStash : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.UiLobbyStash.ELobbyStashTab,System.String> tabNameDic; // 0x338
	static SocLogger <logger>k__BackingField; // 0x0
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x340
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navTab; // 0x348
	WizardGames.Soc.SocClient.Ui.UiLobbyStashItemDetailInfo itemDetailInfo; // 0x350
	FairyGUI.GList itemGlist; // 0x358
	FairyGUI.Controller emptyStatusCtrl; // 0x360
	FairyGUI.GTextField emptyTipsText; // 0x368
	FairyGUI.GComponent comTips; // 0x370
	System.Int32 curSelectTabIndex; // 0x378
	static System.Int32 newlyTime; // 0x8
	System.Int32 curSelectItemIndex; // 0x37c
	System.Boolean isInit; // 0x380
	static System.Int32 DaySec; // 0xc
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.LobbyStashIPropData> curSelectTabPropDataList; // 0x388
	System.Int32[] coinIdArray; // 0x390
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.NavBarData> navBarDataList; // 0x398
	System.Int64 timerId; // 0x3a0
	System.Boolean redDotDataDirty; // 0x3a8
	static SocLogger get_logger(); // 0x06233b78
	System.Void OnInit(); // 0x06233c00
	System.Void ClearTimer(); // 0x06234b20
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06234c28
	System.Void OnLobbyStashItemTimeOutNotice(); // 0x06234ca8
	System.Void RefreshPackback(); // 0x06234d0c
	System.Void SetCurSelecyPropDataList(); // 0x06234de8
	System.Void SortSelectTabPropDataList(); // 0x0623562c
	System.Void InitNavTab(); // 0x062346d8
	System.Void RefreshRedDot(); // 0x06235388
	System.Boolean IsTabRed(System.Int32 id); // 0x062356fc
	System.Boolean IsAllPropDataRed(); // 0x06235804
	System.Boolean IsNewlyPropDataRed(); // 0x06235954
	System.Boolean IsLimitPropPropDataRed(); // 0x06235bac
	System.Boolean IsPropPropDataRed(); // 0x06235d7c
	System.Boolean IsGiftPropDataRed(); // 0x06235ff8
	System.Void OnClickTab(WizardGames.Soc.SocClient.Ui.NavBarData data); // 0x06236278
	System.Void RenderItemList(System.Int32 index, FairyGUI.GObject obj); // 0x06236640
	System.Void OnClickItem(System.Int32 index, WizardGames.Soc.SocClient.Ui.ComBaseIcon comBaseIcon); // 0x06236ce0
	System.Void RefreshItemDetailInfo(); // 0x06235518
	System.Void OnEnable(); // 0x062375b0
	System.Void PlayListItemAnim(); // 0x06236598
	System.Void OnDisable(); // 0x062377b0
	System.Void OnDestroy(); // 0x062379f8
	System.Void .ctor(); // 0x06237ae4
	static System.Void .cctor(); // 0x06237df0
	System.Int32 <SortSelectTabPropDataList>b__28_0(WizardGames.Soc.SocClient.Ui.LobbyStashIPropData a, WizardGames.Soc.SocClient.Ui.LobbyStashIPropData b); // 0x06237ea0
	System.Void <InitNavTab>b__29_0(WizardGames.Soc.SocClient.Ui.NavBarData navTabData, System.Boolean _); // 0x0623846c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiLobbyStash.ELobbyStashTab : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiLobbyStash.ELobbyStashTab All = 0;
	static WizardGames.Soc.SocClient.Ui.UiLobbyStash.ELobbyStashTab Newly = 1;
	static WizardGames.Soc.SocClient.Ui.UiLobbyStash.ELobbyStashTab LimitProp = 2;
	static WizardGames.Soc.SocClient.Ui.UiLobbyStash.ELobbyStashTab Prop = 3;
	static WizardGames.Soc.SocClient.Ui.UiLobbyStash.ELobbyStashTab Gift = 4;
	static WizardGames.Soc.SocClient.Ui.UiLobbyStash.ELobbyStashTab Skin = 5;
	static WizardGames.Soc.SocClient.Ui.UiLobbyStash.ELobbyStashTab Battle = 6;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyStash.<>c__DisplayClass38_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbyStash <>4__this; // 0x10
	System.Int32 index; // 0x18
	WizardGames.Soc.SocClient.Ui.ComResIcon comResIcon; // 0x20
	System.Void .ctor(); // 0x06236c78
	System.Void <RenderItemList>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon comBaseIcon); // 0x062384f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyStashItemDetailInfo : System.Object
{
	static SocLogger <logger>k__BackingField; // 0x0
	FairyGUI.GRichTextField title; // 0x10
	WizardGames.Soc.SocClient.Ui.UiResTitle uiResTitle; // 0x18
	FairyGUI.GComponent itemParts; // 0x20
	FairyGUI.GComponent comViewProbability; // 0x28
	WizardGames.Soc.SocClient.Ui.ComInfoButton btnView; // 0x30
	WizardGames.Soc.SocClient.Ui.UiResSourceInfo uiResSourceInfo; // 0x38
	WizardGames.Soc.SocClient.Ui.UiItemGetWay itemGetWay; // 0x40
	WizardGames.Soc.SocClient.Ui.UiLobbyFunctionButton uiLobbyFunctionButton; // 0x48
	FairyGUI.Controller showTipsCtrl; // 0x50
	FairyGUI.GTextField txtTips; // 0x58
	System.Int32 propDataId; // 0x60
	WizardGames.Soc.Common.Data.resource.OBJGenaral itemConfig; // 0x68
	System.String viewDesc; // 0x70
	static SocLogger get_logger(); // 0x0623858c
	System.Void OnInit(FairyGUI.GComponent root); // 0x06234118
	System.String GetTooltips(); // 0x06238d8c
	System.Void RefreshViewProbabilityBySkinShard(); // 0x06238df0
	System.Void ResetItemPartsPos(); // 0x06238f3c
	System.Void SetItemDetailInfo(System.String uniqueID); // 0x062370e8
	System.Void RefreshShowTipsCtrl(); // 0x06239a50
	System.Void RefreshAccessList(); // 0x062399dc
	System.Void OnEnable(); // 0x06237744
	System.Void OnDisable(); // 0x06237954
	System.Void OnDestroy(); // 0x06237a78
	System.Void .ctor(); // 0x062340b0
	static System.Void .cctor(); // 0x06239ff0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EUiResSourceInfoUseSource : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EUiResSourceInfoUseSource LobbyStash = 0;
	static WizardGames.Soc.SocClient.Ui.EUiResSourceInfoUseSource ItemTips = 1;
	static WizardGames.Soc.SocClient.Ui.EUiResSourceInfoUseSource Other = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResSourceInfo : System.Object
{
	FairyGUI.GComponent comSourceInfo; // 0x10
	FairyGUI.Controller showBtnViewCtrl; // 0x18
	System.String viewDesc; // 0x20
	FairyGUI.GLabel sourceTitle; // 0x28
	FairyGUI.GList randomItemList; // 0x30
	WizardGames.Soc.SocClient.Ui.ComInfoButton btnView; // 0x38
	System.Action btnViewMoreFoldCallback; // 0x40
	System.Int32 maxShowNum; // 0x48
	System.Int32 defaultItemSize; // 0x4c
	System.Int32 defaultItemSizeExpand; // 0x50
	System.Int32 selectIndex; // 0x54
	System.Boolean isExpanding; // 0x58
	System.Int64 animTimerId; // 0x60
	System.Int32 propDataId; // 0x68
	WizardGames.Soc.Common.Data.resource.OBJGenaral itemConfig; // 0x70
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.randomPackageItem> randomPackageItems; // 0x78
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.FixedPackage> fixPackageItems; // 0x80
	WizardGames.Soc.SocClient.Ui.EUiResSourceInfoUseSource sourceType; // 0x88
	WizardGames.Soc.SocClient.Ui.ComBaseIcon selectComBaseIcon; // 0x90
	System.Void .ctor(FairyGUI.GComponent comSourceInfo, WizardGames.Soc.SocClient.Ui.EUiResSourceInfoUseSource sourceType); // 0x062389f8
	System.Void SetRootVisible(System.Boolean isVisible); // 0x0623a088
	System.Void OnEnable(); // 0x06239be8
	System.Void OnDisable(); // 0x06239dec
	System.Void OnHideItemTips(); // 0x0623a110
	System.Void SetData(System.Int32 propDataId); // 0x06239000
	System.Void SetBtnViewMoreFoldCallback(System.Action callback); // 0x0623a23c
	System.Boolean IsShowComSourceInfo(); // 0x0623a2bc
	System.Void RefreshSourceInfo(); // 0x062391b4
	System.String GetTooltips(); // 0x0623a844
	System.Void OnClickBtnViewMoreExpand(); // 0x0623a8a8
	System.Void RefreshItemTopsPos(); // 0x0623ab74
	System.Void OnClickBtnViewMoreFold(); // 0x0623acd8
	System.Void RefreshRandomItemList(); // 0x0623a338
	System.Void ResetExpandingStatus(); // 0x0623911c
	System.Void ClearAnimTimer(); // 0x0623ad70
	System.Void PlayRandomItemListAnim(); // 0x0623a930
	WizardGames.Soc.Common.Data.resource.ENUMResourceType GetResourceType(); // 0x0623aee0
	System.Void SetSelectStatus(WizardGames.Soc.SocClient.Ui.ComBaseIcon comBaseIcon); // 0x0623af50
	System.Void RenderReSourceItem(System.Int32 index, FairyGUI.GObject obj); // 0x0623b0a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResSourceInfo.<>c__DisplayClass35_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiResSourceInfo <>4__this; // 0x10
	System.Single targetSize; // 0x18
	System.Single addItemSize; // 0x1c
	System.Void .ctor(); // 0x0623ae78
	System.Void <PlayRandomItemListAnim>b__0(System.Int32 index, FairyGUI.GComponent item); // 0x0623b9a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResSourceInfo.<>c__DisplayClass38_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiResSourceInfo <>4__this; // 0x10
	FairyGUI.GComponent comItem; // 0x18
	System.String timeLimitParam; // 0x20
	System.Int32 timeLimitType; // 0x28
	System.Int32 index; // 0x2c
	System.Void .ctor(); // 0x0623b8d8
	System.Void <RenderReSourceItem>b__0(FairyGUI.EventContext ctx); // 0x0623bb4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResSourceInfo.<>c__DisplayClass38_1 : System.Object
{
	WizardGames.Soc.Common.Data.resource.OBJGenaral itemCfg; // 0x10
	WizardGames.Soc.SocClient.Ui.UiResSourceInfo.<>c__DisplayClass38_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x0623b940
	System.Void <RenderReSourceItem>b__1(WizardGames.Soc.SocClient.Ui.ComBaseIcon comBaseIcon); // 0x0623bbf4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ELobbyResSourceType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ELobbyResSourceType LobbyStash = 0;
	static WizardGames.Soc.SocClient.Ui.ELobbyResSourceType Other = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResTitle : System.Object
{
	FairyGUI.GLabel title; // 0x10
	FairyGUI.Controller qualityStateCtrl; // 0x18
	FairyGUI.GLoader icon; // 0x20
	FairyGUI.GTextField hasNum; // 0x28
	FairyGUI.GTextField timeTxt; // 0x30
	FairyGUI.Controller statusCtrl; // 0x38
	FairyGUI.Controller timeShowCtrl; // 0x40
	FairyGUI.GTextField rareLabel; // 0x48
	FairyGUI.Controller destroyCtrl; // 0x50
	FairyGUI.Controller showBtnPreviewCtrl; // 0x58
	FairyGUI.GButton btnPreview; // 0x60
	System.Int64 timerID; // 0x68
	System.Int64 expireAt; // 0x70
	FairyGUI.GComponent root; // 0x78
	WizardGames.Soc.SocClient.Ui.ELobbyResSourceType sourceType; // 0x80
	System.Int32 rid; // 0x84
	System.Void .ctor(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.ELobbyResSourceType sourceType); // 0x06238614
	System.Void SetShowBtnPreviewVisible(); // 0x0623be68
	System.Void OnClickBtnPreview(); // 0x0623c204
	System.Void OpenUiCommonPreviewBySkinShard(); // 0x0623c674
	System.Void OpenUiCommonPreviewByFixOrRandom(WizardGames.Soc.Common.Data.resource.ENUMResourceType type); // 0x0623c514
	System.Void SetRootVisible(System.Boolean isShow); // 0x0623c78c
	System.Void SetTime(System.Int64 time); // 0x055112ac
	System.Void Refresh(System.Int32 rid, System.Int64 time, System.String timeLimitParam, System.Int32 timeLimitType); // 0x0623cbc4
	System.Void Refresh(System.String uniqueID, System.Int32 rid, System.Int64 time); // 0x06239400
	System.Void SetQualityStateCtrl(WizardGames.Soc.Common.Data.resource.ENUMResourceRare eRare); // 0x0623d194
	System.Void TimerCallBack(System.Int64 timerId, System.Object _, System.Boolean delete); // 0x0623d314
	System.Void OnDisable(); // 0x06239ce0
	System.Void OnDestroy(); // 0x06239ee4
	System.Void <OpenUiCommonPreviewBySkinShard>b__19_0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0623d674
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResTitle.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiResTitle.<>c <>9; // 0x0
	static System.Action <>9__26_0; // 0x8
	static System.Void .cctor(); // 0x0623ddd4
	System.Void .ctor(); // 0x0623de38
	System.Void <TimerCallBack>b__26_0(); // 0x0623dea0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResTitle.<>c__DisplayClass20_0 : System.Object
{
	WizardGames.Soc.Common.Data.resource.ENUMResourceType type; // 0x10
	WizardGames.Soc.SocClient.Ui.UiResTitle <>4__this; // 0x18
	System.Void .ctor(); // 0x0623df40
	System.Void <OpenUiCommonPreviewByFixOrRandom>b__0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0623dfa8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeamBottomPanel : System.Object
{
	System.Func<System.Boolean> isAppointmentGetter; // 0x10
	FairyGUI.GComponent shareCom; // 0x18
	FairyGUI.GButton shareBtn; // 0x20
	WizardGames.Soc.SocClient.Ui.TeamShareListPanel teamShareListPanel; // 0x28
	FairyGUI.GComponent bootomEffectCom; // 0x30
	FairyGUI.Transition rectLoopAnim; // 0x38
	FairyGUI.Transition rectContractAnim; // 0x40
	FairyGUI.Transition findFriendLoopAnim; // 0x48
	FairyGUI.Transition findFriendStopLoopAnim; // 0x50
	FairyGUI.Transition recruitLoopAnim; // 0x58
	FairyGUI.Transition recruitStopLoopAnim; // 0x60
	FairyGUI.Controller recruitTypeCtrl; // 0x68
	WizardGames.Soc.SocClient.Ui.ComStateBtn btnFindFriend; // 0x70
	WizardGames.Soc.SocClient.Ui.ComStateBtn btnRecruit; // 0x78
	System.Void .ctor(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.ComTopBar topBar, System.Func<System.Boolean> isAppointmentGetter); // 0x0623e634
	System.Void OnEnable(); // 0x0623eca0
	System.Void OnDisable(); // 0x0623f24c
	System.Void PlayRecruitBtnAnim(); // 0x0623efec
	System.Void OnPlayAnim(); // 0x0623f5c4
	System.Void StopAnim(); // 0x0623f400
	System.Void OnTouchBegin(FairyGUI.EventContext context, UnityEngine.Vector2 uiPos); // 0x0623f694
	System.Void OnClickSelfRecommend(); // 0x0623f7dc
	System.Void OnClickRecruit(); // 0x0623fa74
	System.Void OnClickShare(); // 0x0623fca8
	System.Void CloseSharePanel(); // 0x0623fe40
	System.Void SetExpandSharePanel(System.Boolean isExpand); // 0x0623ee80
	System.Void InitBottomList(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.ComTopBar topBar); // 0x0623e778
	System.Void SetFindFriendIcon(); // 0x0623fea8
	System.Void SetBtnRecruitTitle(System.String title); // 0x0623f544
	System.Void <OnPlayAnim>b__16_0(); // 0x06240194
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeamBottomPanel.<>c__DisplayClass19_0 : System.Object
{
	System.Boolean isAppointment; // 0x10
	System.Void .ctor(); // 0x0623fa0c
	System.Void <OnClickSelfRecommend>b__0(System.Collections.Generic.List<System.String> roleIds, System.String teamChangeEntrance); // 0x06240210
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeamBottomPanel.<>c__DisplayClass20_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ETeamTabType tabType; // 0x10
	System.Void .ctor(); // 0x0623fc40
	System.Void <OnClickRecruit>b__0(WizardGames.Soc.SocClient.Ui.UiCommonTeamLobby win); // 0x0624032c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeamMultipleMatch : System.Object
{
	FairyGUI.Controller multipleMatchCtrl; // 0x10
	FairyGUI.GButton additionalBtn; // 0x18
	FairyGUI.GButton confirmAddMode; // 0x20
	FairyGUI.GList multipleMatchCaptainModeList; // 0x28
	FairyGUI.GList multipleMatchMemberModeList; // 0x30
	FairyGUI.Controller additionalVisibleCtrl; // 0x38
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.MatchOptionsData>> captainMultipleMatchModeDataDic; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.MatchOptionsData> captainSelectModeDataList; // 0x48
	System.Boolean isOpenmultipleMatch; // 0x50
	System.Void .ctor(FairyGUI.GComponent root); // 0x062403b4
	System.Void OnRefresh(); // 0x06240818
	System.Boolean ContainsAll<T>(System.Collections.Generic.List<T> sourceList, System.Collections.Generic.List<T> targetList); // 0x052af1f0
	System.Void OnClickConfirmAddMode(); // 0x06240be4
	System.Void OnClickAdditional(); // 0x06241538
	System.Void OnOpenMultipleMatchTime(); // 0x06241714
	System.Void OnLobbyTeamOnTeamTurnToMultipleWarzoneMatchMemberNotice(); // 0x0624184c
	System.Void OnEnable(); // 0x06241a08
	System.Void OnDisable(); // 0x06241b54
	System.Void OnResetData(); // 0x06240ad0
	System.Void OnRenderMultipleMatchMemberModeItem(System.Int32 index, FairyGUI.GObject obj); // 0x06241ca8
	System.Void OnRenderMultipleMatchCaptainModeItem(System.Int32 index, FairyGUI.GObject obj, System.Int32 modeId); // 0x06242354
	System.Void OnRenderMultipleMatchCaptainModeListItem(System.Int32 index, FairyGUI.GObject obj); // 0x0624325c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.MatchOptionsData> GetCaptainMultipleMatchModeDataListByModeId(System.Int32 modeId); // 0x06242994
	System.Void AddModeData(System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.MatchOptionsData> modeDataList, WizardGames.Soc.SocClient.Manager.LobbyTeamData currentTeamData, System.Int32 recommendModeId, System.Int32[] teamCapacities, System.Boolean isMixedModeAllowed); // 0x06243680
	System.Boolean IsMatchOptionExist(WizardGames.Soc.SocClient.Manager.MatchOptionsData option1, System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.MatchOptionsData> option2List); // 0x06243168
	System.Boolean IsEqualMatchOption(WizardGames.Soc.SocClient.Manager.MatchOptionsData option1, WizardGames.Soc.SocClient.Manager.MatchOptionsData option2); // 0x06243960
	System.Boolean IsCurrentMatchOption(System.Int32 modeId, System.Int32 platform, System.Int32 teamCapacity); // 0x0624214c
	WizardGames.Soc.SocClient.Manager.MatchOptionsData CreateMatchOption(System.Int32 _modeId, System.Int32 _platform, System.Int32 _teamCapacity, System.String _batch); // 0x06241454
	System.Int32 <GetCaptainMultipleMatchModeDataListByModeId>b__22_0(WizardGames.Soc.SocClient.Manager.MatchOptionsData a, WizardGames.Soc.SocClient.Manager.MatchOptionsData b); // 0x06243a38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeamMultipleMatch.<>c__DisplayClass11_0<T> : System.Object
{
	System.Collections.Generic.HashSet<T> sourceSet; // 0x0
	System.Void .ctor(); // 0x055049cc
	System.Boolean <ContainsAll>b__0(T item); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeamMultipleMatch.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.LobbyTeamData curTeamInfo; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLobbyTeamMultipleMatch <>4__this; // 0x18
	System.Void .ctor(); // 0x06241384
	System.Boolean <OnClickConfirmAddMode>b__0(WizardGames.Soc.SocClient.Manager.MatchOptionsData data); // 0x06243b50
	System.Void <OnClickConfirmAddMode>b__1(); // 0x06243d10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeamMultipleMatch.<>c__DisplayClass12_1 : System.Object
{
	System.Int32 i; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLobbyTeamMultipleMatch.<>c__DisplayClass12_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x062413ec
	System.Boolean <OnClickConfirmAddMode>b__2(WizardGames.Soc.SocClient.Manager.MatchOptionsData data); // 0x06243dbc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeamMultipleMatch.<>c__DisplayClass20_0 : System.Object
{
	FairyGUI.GButton radioBox; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLobbyTeamMultipleMatch <>4__this; // 0x18
	WizardGames.Soc.SocClient.Manager.MatchOptionsData modeData; // 0x20
	System.Void .ctor(); // 0x0624292c
	System.Void <OnRenderMultipleMatchCaptainModeItem>b__0(); // 0x06243fe4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeamMultipleMatch.<>c__DisplayClass21_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbyTeamMultipleMatch <>4__this; // 0x10
	WizardGames.Soc.SocClient.Manager.LobbyTeamData teamData; // 0x18
	System.Int32 index; // 0x20
	System.Void .ctor(); // 0x06243618
	System.Void <OnRenderMultipleMatchCaptainModeListItem>b__0(System.Int32 _index, FairyGUI.GObject _obj); // 0x06244150
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMatchFeedback : System.Object
{
	FairyGUI.GComponent <binderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <timeTxt>k__BackingField; // 0x18
	FairyGUI.GButton <btnClose>k__BackingField; // 0x20
	FairyGUI.Controller <ctrlStatus>k__BackingField; // 0x28
	FairyGUI.GTextField estimatedWaitTime; // 0x30
	System.Int64 timerId; // 0x38
	System.Int32 time; // 0x40
	System.Boolean isAppointment; // 0x44
	System.Int32 matchingRandomSeed; // 0x48
	System.Boolean isShowMultipleMatch; // 0x4c
	System.Int32 realTime; // 0x50
	System.Boolean isWarzonebattleMode; // 0x54
	FairyGUI.GComponent get_binderRoot(); // 0x06244268
	FairyGUI.GTextField get_timeTxt(); // 0x062442cc
	FairyGUI.GButton get_btnClose(); // 0x06244330
	FairyGUI.Controller get_ctrlStatus(); // 0x06244394
	System.Void .ctor(FairyGUI.GComponent root); // 0x062443f8
	System.Void OnClickClose(); // 0x062446a4
	System.Void TimerCallBack(System.Int64 timerId, System.Object _, System.Boolean delete); // 0x06244c4c
	System.Void CancelTimer(); // 0x06244ed8
	System.Void RefreshDesc(); // 0x06244ff0
	System.Void OnRefreshStatus(System.Boolean isAppointment); // 0x05523a7c
	System.Void OnEnable(); // 0x06245600
	System.Void OnDisable(); // 0x06245660
	System.Void <OnClickClose>b__21_0(); // 0x062456c0
	System.Void <OnClickClose>b__21_1(); // 0x06245728
	System.Void <OnClickClose>b__21_2(); // 0x06245790
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMatchFeedback.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiMatchFeedback.<>c <>9; // 0x0
	static System.Action <>9__21_3; // 0x8
	static System.Void .cctor(); // 0x062458f0
	System.Void .ctor(); // 0x06245954
	System.Void <OnClickClose>b__21_3(); // 0x062459bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeamMode : System.Object
{
	FairyGUI.GLoader bgLoader; // 0x10
	FairyGUI.GTextField modeName; // 0x18
	FairyGUI.GTextField modeInfo; // 0x20
	FairyGUI.Controller typeCtrl; // 0x28
	System.Void .ctor(FairyGUI.GComponent root); // 0x06245b24
	System.Void OnEnable(); // 0x06245d6c
	System.Void OnDisable(); // 0x06245eb8
	System.Void OnResetTypeCtrl(); // 0x06246004
	System.Void SetTypeCtrl(); // 0x062461cc
	System.Void RefreshMode(System.Int32 modeID); // 0x06246254
	System.Void RefreshCurModeInfo(System.String str); // 0x06246328
	System.Void ChangeMode(); // 0x062463a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeamMode.<>c__DisplayClass12_0 : System.Object
{
	System.Int32 modeId; // 0x10
	System.Void .ctor(); // 0x062467c0
	System.Void <ChangeMode>b__0(System.Int32 changeModeId); // 0x06246828
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamPlayerInfo : System.Object
{
	static SocLogger Log; // 0x0
	FairyGUI.GComponent playerCom; // 0x10
	FairyGUI.Controller nameStatus; // 0x18
	FairyGUI.GImage captainIcon; // 0x20
	FairyGUI.Controller voiceCtrl; // 0x28
	FairyGUI.Controller isPreparedCtrl; // 0x30
	System.String curRoleId; // 0x38
	System.Boolean isAppointment; // 0x40
	FairyGUI.Controller inviteStatusCtrl; // 0x48
	FairyGUI.GButton invitationBtn; // 0x50
	FairyGUI.Transition speakerTransition; // 0x58
	WizardGames.Soc.SocClient.Ui.ComNameMedal comNameMedal; // 0x60
	FairyGUI.GLoader medalLoader; // 0x68
	FairyGUI.Controller medalController; // 0x70
	FairyGUI.GLoader clickShowPlayerInfo; // 0x78
	FairyGUI.Controller statusCtrl; // 0x80
	FairyGUI.GButton preferenceBtn; // 0x88
	FairyGUI.GButton switchPreference; // 0x90
	FairyGUI.GTextField lobbyTeamOnlineStatusTxt; // 0x98
	FairyGUI.Controller unionInfoCtrl; // 0xa0
	FairyGUI.GComponent unionInfoCom; // 0xa8
	System.Int32 time; // 0xb0
	System.Void .ctor(FairyGUI.GComponent com); // 0x062468f8
	System.Void RefreshPreferenceTitle(); // 0x0624708c
	System.Void OnClickPreference(); // 0x062474f8
	System.Void OnClickInvitationBtn(); // 0x062475c4
	System.Void RefreshInviteStatusCtrl(System.Int32 index, System.Int32 teamCapacity, System.Int32 teamMemberCount); // 0x06247910
	System.Void RefreshPreparedStatus(); // 0x06247a58
	System.Void OnClickOpenPlayerInfo(); // 0x06247b54
	System.Void SetIsAppointment(System.Boolean isAppointment); // 0x06247cc8
	System.Void SetPlayerInfo(SimpleJSON.JSONNode jsonNode); // 0x06247d44
	System.Void RefreshPlayerVoiceState(System.Boolean showVoice); // 0x06248424
	System.Void RefreshUnionInfo(System.String communityID); // 0x0624821c
	System.Void SetUnionInfoCom(WizardGames.Soc.SocClient.Ui.UnionInfo info); // 0x0624885c
	System.Void Clear(); // 0x06248c34
	static System.Void .cctor(); // 0x06248c94
	System.Void <OnClickInvitationBtn>b__25_0(System.Collections.Generic.List<System.String> roleIds, System.String teamChangeEntrance); // 0x06248d68
	System.Void <RefreshUnionInfo>b__32_0(SimpleJSON.JSONNode info); // 0x06248f5c
	System.Void <RefreshUnionInfo>b__32_1(); // 0x0624903c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyMicPanel : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTeam.ComLobbyMicPanelBinder binder; // 0x10
	System.Boolean isShow; // 0x18
	WizardGames.Soc.SocClient.Ui.UiLobbyTeam uilobbyTeam; // 0x20
	WizardGames.Soc.SocClient.Ui.ELobbyTeamVoiceType curType; // 0x28
	System.Void .ctor(FairyGUI.GComponent root); // 0x062490c4
	System.Void RefreshUi(); // 0x0624963c
	System.Void RefreshMicState(); // 0x06249764
	System.Boolean CheckVoiceRoom(WizardGames.Soc.SocClient.Ui.ELobbyTeamVoiceType type); // 0x06249908
	System.Void OpenTeamMicroClick(WizardGames.Soc.SocClient.Ui.ELobbyTeamVoiceType type); // 0x062499c4
	System.Void OpenTeamMicroInternal(System.Boolean isSuccess); // 0x05523a7c
	System.Void CloseMicClick(); // 0x055049cc
	System.Void SwitchHoldTeamMicro(WizardGames.Soc.SocClient.Ui.ELobbyTeamVoiceType type); // 0x0624a3f0
	System.Void SwitchHoldTeamMicroInternal(System.Boolean isSuccess); // 0x05523a7c
	System.Void ShowPanel(); // 0x0624a9a4
	System.Void Show(); // 0x0624aab8
	System.Void HidePanel(); // 0x0624ab1c
	System.Void <.ctor>b__3_0(FairyGUI.EventContext ctx); // 0x0624abe4
	System.Void <.ctor>b__3_1(FairyGUI.EventContext ctx); // 0x0624ac60
	System.Void <.ctor>b__3_2(FairyGUI.EventContext ctx); // 0x0624acd8
	System.Void <.ctor>b__3_3(FairyGUI.EventContext ctx); // 0x0624ad54
	System.Void <.ctor>b__3_4(FairyGUI.EventContext ctx); // 0x0624add0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySpeakerPanel : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTeam.ComLobbySpeakerPanelBinder binder; // 0x10
	UnityEngine.Vector3 pos; // 0x18
	System.Boolean isShow; // 0x24
	WizardGames.Soc.SocClient.Ui.UiLobbyTeam uilobbyTeam; // 0x28
	System.Collections.Generic.Dictionary<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.LobbyTeammateSpeaker> dicTeamSpeakers; // 0x30
	SocLogger Log; // 0x38
	System.Void .ctor(FairyGUI.GComponent root); // 0x0624ae4c
	System.Void OnClickTeamFreeSpeaker(WizardGames.Soc.SocClient.Ui.ELobbyTeamVoiceType type, System.Int32 tipId); // 0x055057d4
	System.Boolean CheckVoiceRoom(WizardGames.Soc.SocClient.Ui.ELobbyTeamVoiceType type); // 0x0624b808
	System.Void ShowPanel(); // 0x0624b930
	System.Void RefreshUi(); // 0x0624ba4c
	System.Void RefreshSpeakerState(); // 0x0624b668
	System.Void Show(); // 0x0624bb74
	System.Void HidePanel(); // 0x0624ca20
	System.Void <.ctor>b__6_0(FairyGUI.EventContext ctx); // 0x0624cae8
	System.Void <.ctor>b__6_1(FairyGUI.EventContext ctx); // 0x0624cb68
	System.Void <.ctor>b__6_2(FairyGUI.EventContext ctx); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySpeakerPanel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiLobbySpeakerPanel.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__6_3; // 0x8
	static System.Void .cctor(); // 0x0624cdb4
	System.Void .ctor(); // 0x0624ce18
	System.Void <.ctor>b__6_3(FairyGUI.EventContext ctx); // 0x0624ce80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySpeakerPanel.<>c__DisplayClass12_0 : System.Object
{
	FairyGUI.GTextField textName; // 0x10
	WizardGames.Soc.SocClient.Manager.LobbyTeamMemberData teamMemberData; // 0x18
	FairyGUI.GSlider sliderBar; // 0x20
	WizardGames.Soc.SocClient.Ui.LobbyTeammateSpeaker teammateSpeaker; // 0x28
	FairyGUI.GTextField labelValue; // 0x30
	FairyGUI.GButton btnMute; // 0x38
	System.Void .ctor(); // 0x0624c9b8
	System.Void <Show>b__0(Config.LobbyRoleInfo userInfo); // 0x0624d0c8
	System.Void <Show>b__1(); // 0x0624d160
	System.Void <Show>b__2(); // 0x0624d4c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeam : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update, WizardGames.Soc.Common.Unity.Ui.IUiTriggerGuide
{
	FairyGUI.GButton btnSpeaker; // 0x338
	FairyGUI.GButton btnMic; // 0x340
	FairyGUI.Controller speakerController; // 0x348
	FairyGUI.Controller speakerChoseController; // 0x350
	FairyGUI.Controller micController; // 0x358
	FairyGUI.Controller micChoseController; // 0x360
	FairyGUI.Controller micHoldController; // 0x368
	FairyGUI.Transition micTransition; // 0x370
	FairyGUI.GComponent micEffect; // 0x378
	FairyGUI.GButton btnchat; // 0x380
	WizardGames.Soc.SocClient.Ui.UiLobbySpeakerPanel speakerPanel; // 0x388
	WizardGames.Soc.SocClient.Ui.UiLobbyMicPanel micPanel; // 0x390
	System.Boolean micBtnDown; // 0x398
	System.Single micBtnDownTime; // 0x39c
	static SocLogger Log; // 0x0
	WizardGames.Soc.SocClient.Ui.UiLobbyTeamMode uiLobbyTeamMode; // 0x3a0
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x3a8
	FairyGUI.GComponent[] playersCom; // 0x3b0
	WizardGames.Soc.SocClient.Ui.UiTeamPlayerInfo[] uiTeamPlayerInfos; // 0x3b8
	WizardGames.Soc.SocClient.Ui.UiHudElemChat chat; // 0x3c0
	System.Int32 selectModeId; // 0x3c8
	System.Int32 clickPlayBtnCD; // 0x3cc
	System.Int32 curNowTime; // 0x3d0
	static System.Action jumpOpenTeamUIcallback; // 0x8
	System.Collections.Generic.HashSet<System.String> roleIds; // 0x3d8
	FairyGUI.Controller newBieStatusCtrl; // 0x3e0
	FairyGUI.GTextField pageTitle; // 0x3e8
	WizardGames.Soc.SocClient.Ui.ComCustomButton switchBtn; // 0x3f0
	FairyGUI.Transition switchClickTrans; // 0x3f8
	FairyGUI.GTextField teamLeftTopTitle; // 0x400
	FairyGUI.GTextField teamLeftTopTime; // 0x408
	FairyGUI.GButton quitBtn; // 0x410
	FairyGUI.GButton btnMessage; // 0x418
	FairyGUI.Controller btnStyleCtrl; // 0x420
	FairyGUI.Controller btnBGStyleCtrl; // 0x428
	FairyGUI.Controller btnTextColorCtrl; // 0x430
	FairyGUI.GButton btnPlay; // 0x438
	FairyGUI.Transition dynamicModeNoReadyAnim; // 0x440
	FairyGUI.Transition appointTimeStartAnim; // 0x448
	WizardGames.Soc.SocClient.Ui.UiMatchFeedback uiMatchFeedback; // 0x450
	FairyGUI.Controller teamStatusCtrl; // 0x458
	WizardGames.Soc.SocClient.Ui.UiLobbyTeamMultipleMatch uiLobbyTeamMultipleMatch; // 0x460
	WizardGames.Soc.SocClient.Ui.UiLobbyTeamBottomPanel bottomPanel; // 0x468
	FairyGUI.GComponent unionInfoCom; // 0x470
	FairyGUI.Transition transMessageShow; // 0x478
	FairyGUI.Transition transMessageHide; // 0x480
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType> messageTabOrder; // 0x488
	System.Int32 messageRotateIndex; // 0x490
	System.Int32 messageRotateSecCounter; // 0x494
	System.Int32 lastInviteCount; // 0x498
	System.Int32 lastLobbyApplyCount; // 0x49c
	System.Int32 lastAppointmentApplyCount; // 0x4a0
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType> suppressedTabs; // 0x4a8
	System.Boolean msgTransPlaying; // 0x4b0
	System.Nullable<WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType> curMsgTabShown; // 0x4b4
	System.String curMsgText; // 0x4c0
	System.Boolean pendingSwitch; // 0x4c8
	WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType pendingTab; // 0x4cc
	System.String pendingText; // 0x4d0
	static System.Boolean isAppointment; // 0x10
	System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>>> teamMemberAllCostumePlanDic; // 0x4d8
	System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>>> teamMemberAllEquipPlanDic; // 0x4e0
	FairyGUI.GButton Message; // 0x4e8
	WizardGames.Soc.SocClient.Ui.Binder.CommonLobby.ComSeasonBinder comSeason; // 0x4f0
	System.Int32 dynamicModeNoReadyCurTime; // 0x4f8
	System.Boolean IsFirstShowAnimByDynamicMode; // 0x4fc
	System.Int32 matchExtendTimeIndex; // 0x500
	System.Int64 reqStartGameTimerId; // 0x508
	System.Int64 reqStartGameTimeoutTimerId; // 0x510
	System.Int32 curModeRandom; // 0x518
	System.Void OnInitVoice(); // 0x0624d7a0
	System.Void CloseVoicePanel(UnityEngine.Vector2 uiPos); // 0x0624e46c
	System.Void RefreshMicSpeakerPanel(); // 0x0624e798
	System.Void RefreshTeammateSpeaker(); // 0x0624df70
	System.Void UpdateMyMicVolume(); // 0x0624e818
	System.Void OnFpsUnlimitedUpdateVoice(System.Single dt); // 0x0624e9c0
	System.Boolean CloseVoicePanel(); // 0x0624ece8
	System.Void ChangeSpeaker(); // 0x0624b8c4
	System.Void HideMicPanel(); // 0x0624e044
	System.Void HideSpeakerPanel(); // 0x0624e704
	System.Void ChangeMic(); // 0x0624a048
	System.Void RefreshVoiceState(); // 0x055049cc
	System.Void OnVoiceBegin(FairyGUI.EventContext context); // 0x0624ee6c
	System.Void OnVoice(); // 0x055049cc
	System.Void OnTouchEnd(FairyGUI.EventContext context); // 0x0624ef00
	System.Void CloseVoice(); // 0x055049cc
	System.Void GetPlatformButtons(FairyGUI.GComponent content); // 0x0624dc68
	System.Void OnInit(); // 0x0624ef7c
	System.Void RefreshSeasonBtn(); // 0x06250160
	System.Void MessageTips(); // 0x06250694
	System.Void OnTouchBegin(FairyGUI.EventContext context); // 0x06250998
	System.Void CheckNotificationPermissionForAppointmentTeam(); // 0x06250ab4
	System.Void OnClickSwitch(); // 0x06250c68
	System.Void OnLobbyTeamSwitchTeam(System.Boolean _isAppointment); // 0x06250d60
	System.Void OnClickBtnQuickInvite(); // 0x06251340
	System.Void OnClickBtnApplyMessage(); // 0x062516e8
	System.Void OnClickLeaveTeam(); // 0x062517dc
	System.Void OnUpdateLobbyTeamMemberDisplay(System.String updateRoleID, System.String teamID); // 0x06251cb8
	System.Void OnRefreshAddTeamMember(System.String joinID, System.Boolean isAppointment); // 0x06251e84
	System.Void OnRefreshBtnStyleCtrlStatus(); // 0x06251f90
	System.Void RefreshBtnStyleByWarzone(); // 0x0625293c
	System.Void RefreshBtnStyleByAppointment(); // 0x0625214c
	System.Void RefreshDynamicBtnStyleCtrlStatus(); // 0x06252550
	System.Void LeaveTeamUI(System.String msg); // 0x06252c28
	System.Void RegistEvent(); // 0x062501cc
	System.Void OnHandleLobbyOnReconnected(SimpleJSON.JSONNode node, System.Boolean _isAppointment); // 0x06253044
	System.Void HandleReconnectionForAppointmentTeam(SimpleJSON.JSONNode node, System.Boolean _isAppointment); // 0x06253204
	System.Void HandleReconnectionForNormalTeam(SimpleJSON.JSONNode node); // 0x06253354
	System.Void HandleReconnectionForBothTeams(SimpleJSON.JSONNode node, System.Boolean _isAppointment); // 0x062535dc
	System.Boolean IsTeamDataMissing(SimpleJSON.JSONNode node); // 0x06253864
	System.Void OnPrepare(); // 0x06253d80
	System.Void OnLobbyTeamMatchStateCancelNotice(); // 0x06253e60
	System.Void ResetDynamicModeNoReadyCurTime(); // 0x06253ed4
	System.Void OnCancelPrepare(); // 0x06254050
	System.Void OnCancelMatching(); // 0x0625448c
	System.Void LeaveTeam(); // 0x06254a30
	System.Void OnClickStartPlay(); // 0x06254b88
	System.Void OnClickBtnPlay(); // 0x055049cc
	System.Void OnStartGameTeamNoFull(); // 0x06255bc8
	System.Void OnStartGame(); // 0x06256ee8
	System.Void ShowDynamicModeNoReadyAnim(); // 0x06256f54
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x06257334
	System.Void OnFps10Update(System.Single dt); // 0x062573b0
	System.Void OnFps1Update(System.Single dt); // 0x062578ac
	System.Void UpdatePlayerComPos(); // 0x06257498
	System.Void RefreshMessageTicker(); // 0x06257a2c
	System.String BuildMessageText(WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType tab, System.Int32 inviteCount, System.Int32 lobbyApplyCount, System.Int32 appointmentApplyCount); // 0x062581f4
	System.Void SetMessageText(System.String text); // 0x06258404
	System.Void SwitchMessageTo(WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType tab, System.String text); // 0x062584c0
	System.Void UpdateMessageOrder(WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType tab, System.Int32 curCount, System.Int32& lastCount); // 0x06258014
	System.Void RemoveMessageCategory(WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType tab); // 0x06250860
	System.Void OnClickCloseBtn(FairyGUI.EventContext context); // 0x0625866c
	System.Void HandleClickClose(); // 0x06258a04
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06258d20
	static System.Void Open(System.Int32 modeId, System.Action callback, System.Boolean isAppointment, WizardGames.Soc.SocClient.Manager.EUiOpenTriggerType triggerType); // 0x054fe40c
	System.Void Refresh(); // 0x06250ef0
	System.Void OpenInitInfo(System.Boolean isAppointment); // 0x062539a0
	System.Void OpenQuickInviteUI(); // 0x062511c4
	System.Void CreatePlayerModelList(); // 0x06259058
	System.Void RefreshPlayerInfoByIndex(System.Int32 index, SimpleJSON.JSONNode jsonNode); // 0x06259928
	System.Void RefreshByCreateTeam(System.Boolean isAppointment); // 0x06259a00
	System.Void OnHandleLobbyTeamMemberLeave(System.String leftRoleId, System.Boolean isAppointment); // 0x06259af0
	System.Void RefreshPlayerInfo(); // 0x062592b0
	System.Void RefreshModeInfo(); // 0x06259d78
	System.Void OnDestroy(); // 0x0625a704
	System.Void SetPageTitle(); // 0x06250068
	System.Void SetLeftTopTitle(); // 0x055049cc
	System.Void RefreshPlayerPreparedStatus(); // 0x0625ac00
	System.Void OnLobbyTeamCancelFakeMathingNotice(); // 0x0625aca8
	System.Void RefreshChoosePlatformlPop(); // 0x0625a4b0
	System.Void RefreshLobbyModelScene(); // 0x0625af3c
	System.Void OnEnable(); // 0x0625b050
	System.Void OnDisable(); // 0x0625b7a0
	System.Void RefreshPreferenceTitle(); // 0x0625bdc4
	System.Void OnAppointmentTeamTimeOutNotice(); // 0x0625be60
	static System.Void CloseWin(); // 0x054fd168
	System.Boolean TriggerGuide(); // 0x0625bf5c
	System.Void OnHandleReqStartGame(); // 0x055049cc
	System.Void SendSyncGameStartHttp(System.Int32 randomMatchSec); // 0x0625c2dc
	System.Void OnReqStopMatch(); // 0x0625c77c
	System.Void CancelReqStartGameTimer(); // 0x0625ad24
	System.Void CancelReqStartGameTimeoutTimer(); // 0x0625ae30
	System.Void OnLobbyTeamFakeMatchExtendTime(); // 0x0625c7e8
	System.Void HandleSelfDynamicMatching(); // 0x0625c138
	System.Void OnRefreshMatchInfo(); // 0x06259bc0
	System.Void SetCurModeRandom(); // 0x0625a44c
	System.Void InitPlatform(FairyGUI.GComponent content); // 0x0624fe88
	FairyGUI.GComponent GetChatCom(FairyGUI.GComponent content); // 0x0624ffb0
	System.Void OnRefreshByOnEnable(); // 0x0625b73c
	System.Void .ctor(); // 0x0625ca20
	static System.Void .cctor(); // 0x0625cc38
	System.Void <OnInitVoice>b__14_0(FairyGUI.EventContext ctx); // 0x0625cd0c
	System.Void <OnInitVoice>b__14_1(FairyGUI.EventContext ctx); // 0x0625cdf0
	System.Void <OnInitVoice>b__14_2(FairyGUI.EventContext ctx); // 0x0625cef8
	System.Void <OnInit>b__89_1(); // 0x0625cf8c
	System.Void <OnInit>b__89_2(); // 0x0625d01c
	System.Void <OnCancelPrepare>b__117_0(); // 0x0625d0c4
	System.Void <OnCancelMatching>b__118_0(); // 0x0625d1f8
	System.Void <OnClickBtnPlay>b__121_0(); // 0x0625d424
	System.Void <Refresh>b__139_0(); // 0x0625d4bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeam.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiLobbyTeam.<>c <>9; // 0x0
	static System.Func<System.Boolean> <>9__89_0; // 0x8
	static System.Action<System.Boolean> <>9__94_0; // 0x10
	static System.Action<System.Collections.Generic.List<System.String>,System.String> <>9__98_0; // 0x18
	static System.Action <>9__100_1; // 0x20
	static System.Action <>9__100_0; // 0x28
	static System.Action <>9__118_2; // 0x30
	static System.Action <>9__118_1; // 0x38
	static WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__146_1; // 0x40
	static System.Void .cctor(); // 0x0625d8d0
	System.Void .ctor(); // 0x0625d934
	System.Boolean <OnInit>b__89_0(); // 0x0625d99c
	System.Void <CheckNotificationPermissionForAppointmentTeam>b__94_0(System.Boolean result); // 0x0625da2c
	System.Void <OnClickBtnQuickInvite>b__98_0(System.Collections.Generic.List<System.String> roleIds, System.String teamChangeEntrance); // 0x0625db64
	System.Void <OnClickLeaveTeam>b__100_0(); // 0x0625dda8
	System.Void <OnClickLeaveTeam>b__100_1(); // 0x0625df34
	System.Void <OnCancelMatching>b__118_1(); // 0x0625e028
	System.Void <OnCancelMatching>b__118_2(); // 0x0625e1b4
	System.Void <RefreshPlayerInfo>b__146_1(System.Int64 timer, System.Object data, System.Boolean delete); // 0x0625e27c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeam.<>c__DisplayClass122_0 : System.Object
{
	System.String nowTimeKey; // 0x10
	System.Void .ctor(); // 0x0625e370
	System.Void <OnStartGameTeamNoFull>b__1(); // 0x0625e3d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeam.<>c__DisplayClass122_1 : System.Object
{
	System.Boolean isPlayLoopAnim; // 0x10
	System.Int32 playLoopAnimNum; // 0x14
	System.Void .ctor(); // 0x0625e484
	System.Void <OnStartGameTeamNoFull>b__0(); // 0x0625e4ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeam.<>c__DisplayClass132_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbyTeam <>4__this; // 0x10
	System.String text; // 0x18
	WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType tab; // 0x20
	FairyGUI.PlayCompleteCallback <>9__1; // 0x28
	System.Void .ctor(); // 0x0625e660
	System.Void <SwitchMessageTo>b__0(); // 0x0625e6c8
	System.Void <SwitchMessageTo>b__1(); // 0x0625e7c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeam.<>c__DisplayClass146_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbyTeam <>4__this; // 0x10
	System.Collections.Generic.HashSet<System.String> communityIDs; // 0x18
	System.Void .ctor(); // 0x0625e8b4
	System.Void <RefreshPlayerInfo>b__0(SimpleJSON.JSONArray jsonArray); // 0x0625e91c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeam.<>c__DisplayClass150_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbyTeam <>4__this; // 0x10
	WizardGames.Soc.SocClient.Manager.LobbyTeamData curTeamInfo; // 0x18
	System.Void .ctor(); // 0x055049cc
	System.Void <SetLeftTopTitle>b__0(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeam.<>c__DisplayClass166_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.LobbyTeamData curTeamData; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLobbyTeam <>4__this; // 0x18
	System.Void .ctor(); // 0x0625f1d4
	System.Void <SendSyncGameStartHttp>b__0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x0625f23c
	System.Void <SendSyncGameStartHttp>b__1(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x0625f394
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSwitchAppointmentPop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger Log; // 0x0
	WizardGames.Soc.SocClient.Ui.ComModal modal; // 0x338
	WizardGames.Soc.SocClient.Ui.ComInfoButton btnInfo; // 0x340
	FairyGUI.GList list; // 0x348
	System.Int32 modeId; // 0x350
	System.Int32 selectIndex; // 0x354
	System.Void OnInit(); // 0x0625f568
	System.Void SetConfirmBtnVisible(); // 0x055049cc
	System.Void OnConfirm(); // 0x055049cc
	System.Void Refresh(System.Int32 modeId); // 0x055056e8
	System.Void RefreshInfo(); // 0x055049cc
	System.Void SetSelectIndexByCurAppointmentTime(); // 0x055049cc
	System.Void OnRenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x0550f6d4
	System.Void OnDestroy(); // 0x06260968
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x062609d0
	static System.Void Open(System.Int32 modeId); // 0x06260a50
	System.Void .ctor(); // 0x06260cc4
	static System.Void .cctor(); // 0x06260d50
	System.Void <OnInit>b__6_0(); // 0x06260e24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSwitchAppointmentPop.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSwitchAppointmentPop <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.RoundTimeData> dataList; // 0x20
	System.Void .ctor(); // 0x06260900
	System.Void <OnRenderListItem>b__0(); // 0x06260e98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSwitchAppointmentPop.<>c__DisplayClass15_0 : System.Object
{
	System.Int32 modeId; // 0x10
	System.Void .ctor(); // 0x06260c5c
	System.Void <Open>b__0(WizardGames.Soc.SocClient.Ui.UiSwitchAppointmentPop win); // 0x06260f3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSwitchTeam : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTeam.RootSwitchTeamBinder binder; // 0x338
	System.Int32 selectIndex; // 0x340
	System.Int32 curClickTime; // 0x344
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiSwitchTeam.LobbyTeamSwitchData> teamDatas; // 0x348
	System.Void OnInit(); // 0x06260fc0
	System.Void OnClickItem(System.Int32 index); // 0x0626121c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x062615b0
	System.Void OnRefresh(); // 0x06261630
	System.Void OnClickTeamAuthor(System.Boolean isAppointment, FairyGUI.GButton btn); // 0x062618d0
	System.Void OnItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x0550f6d4
	System.Void OnClickSwitchTeam(System.Int32 index); // 0x062613d0
	System.Void OnClickStartTeam(System.Int32 index); // 0x06262c5c
	System.Void OnRefreshTeamMember(System.String teamId, System.Boolean isAppointment); // 0x06262d1c
	System.Void RefreshByCreateTeam(System.Boolean isAppointment); // 0x06262d9c
	System.Void OnEnable(); // 0x06262e24
	System.Void OnDisable(); // 0x06263100
	System.Void OnDestroy(); // 0x0626340c
	static System.Void Open(System.Boolean isAppointment); // 0x06263474
	System.Void .ctor(); // 0x062636f0
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiSwitchTeam.LobbyTeamSwitchData : System.ValueType
{
	System.Boolean IsAppointment; // 0x10
	WizardGames.Soc.SocClient.Manager.LobbyTeamData TeamData; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSwitchTeam.<>c__DisplayClass10_0 : System.Object
{
	FairyGUI.GButton btn; // 0x10
	System.Boolean isHasAuthor; // 0x18
	System.Boolean isAppointment; // 0x19
	System.Void .ctor(); // 0x06261e14
	System.Void <OnClickTeamAuthor>b__0(); // 0x062637c8
	System.Void <OnClickTeamAuthor>b__1(); // 0x0626383c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSwitchTeam.<>c__DisplayClass11_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTeam.ComTeamlistBinder itemBinder; // 0x10
	WizardGames.Soc.SocClient.Manager.LobbyTeamData teamData; // 0x18
	WizardGames.Soc.SocClient.Ui.UiSwitchTeam <>4__this; // 0x20
	System.Int32 index; // 0x28
	System.Boolean isAppointment; // 0x2c
	System.Void .ctor(); // 0x06262bf4
	System.Void <OnItemRenderer>b__5(); // 0x055049cc
	System.Void <OnItemRenderer>b__0(); // 0x055049cc
	System.Void <OnItemRenderer>b__1(); // 0x055049cc
	System.Void <OnItemRenderer>b__2(); // 0x055049cc
	System.Void <OnItemRenderer>b__3(); // 0x055049cc
	System.Void <OnItemRenderer>b__4(SimpleJSON.JSONArray jsonArray); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSwitchTeam.<>c__DisplayClass11_1 : System.Object
{
	SimpleJSON.JSONArray jsonArray; // 0x10
	WizardGames.Soc.SocClient.Ui.UiSwitchTeam.<>c__DisplayClass11_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x06263f8c
	System.Void <OnItemRenderer>b__6(System.Int32 i, FairyGUI.GObject item); // 0x06263ff4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSwitchTeam.<>c__DisplayClass19_0 : System.Object
{
	System.Boolean isAppointment; // 0x10
	System.Void .ctor(); // 0x06263688
	System.Void <Open>b__0(WizardGames.Soc.SocClient.Ui.UiSwitchTeam win); // 0x06264438
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLockMissile : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	SocLogger log; // 0x338
	FairyGUI.GComponent panelRoot; // 0x340
	FairyGUI.GTextField txtDistance; // 0x348
	FairyGUI.Controller stateCtrl; // 0x350
	FairyGUI.Controller clipsStateCtrl; // 0x358
	FairyGUI.GComponent nodePanel; // 0x360
	UnityEngine.Transform playerCameraTransform; // 0x368
	System.Collections.Generic.Dictionary<System.Int64,FairyGUI.GComponent> id2MarkerCom; // 0x370
	System.Int64 lockingId; // 0x378
	System.Single progress; // 0x380
	FairyGUI.GComponent lockedMarker; // 0x388
	WizardGames.Soc.Common.CustomType.WeaponCustom currentWeapon; // 0x390
	System.Collections.Generic.HashSet<System.Int64> weaponSubscribeIds; // 0x398
	System.String Locking_WwiseName; // 0x3a0
	System.String Locked_WwiseName; // 0x3a8
	WizardGames.Soc.SocClient.Ui.UiLockMissile.EPlayLockAudioState playLockAudioState; // 0x3b0
	System.Void OnInit(); // 0x062644c0
	System.Void OnEnable(); // 0x06264804
	System.Void OnDisable(); // 0x06264c10
	System.Void OnClipsChange(WizardGames.Soc.Share.Framework.CustomTypeBase weapon, System.Int32 oldValue, System.Int32 newValue); // 0x06264fa0
	System.Void LockMissileTargetSyn(System.Collections.Generic.List<System.Int64> ids); // 0x06265074
	FairyGUI.GComponent CreateNewMarker(); // 0x0626473c
	System.Void RemoveMarker(System.Int64 id); // 0x06265904
	System.Void PlayLockAudio(System.Int64 id, System.Single progress); // 0x062659cc
	System.Void LockEntityChange(System.Int64 id, System.Single progress); // 0x06265bc8
	System.Void RefreshMarkerCom(System.Int64 id, FairyGUI.GComponent com); // 0x06265cfc
	System.Void OnFps30Update(System.Single dt); // 0x06265e9c
	System.Void SetDistance(UnityEngine.Vector3 position); // 0x06265f10
	UnityEngine.Vector3 GetEntityPos(System.Int64 id); // 0x0626615c
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x062662f8
	System.Void OnFps10Update(System.Single dt); // 0x062666f4
	System.Void OnDestroy(); // 0x06266768
	System.Void OnFps1Update(System.Single dt); // 0x06266808
	System.Void .ctor(); // 0x0626687c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiLockMissile.EPlayLockAudioState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiLockMissile.EPlayLockAudioState None = 0;
	static WizardGames.Soc.SocClient.Ui.UiLockMissile.EPlayLockAudioState Locking = 1;
	static WizardGames.Soc.SocClient.Ui.UiLockMissile.EPlayLockAudioState Locked = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAccountCenter : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	
	System.Void OnInit(); // 0x06266a50
	System.Void CreateIntlLoginPanelWrapper(); // 0x06266bc4
	System.Void .ctor(); // 0x06266c24
	System.Void <OnInit>b__0_0(System.Boolean result); // 0x06266cb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLogin : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	SocLogger log; // 0x338
	FairyGUI.GComponent content; // 0x340
	FairyGUI.Controller ctrlStyle; // 0x348
	FairyGUI.GTextField versionInfo; // 0x350
	FairyGUI.GTextField textEditionInfo; // 0x358
	FairyGUI.GButton btnBoard; // 0x360
	FairyGUI.GGroup groupLoginBtns; // 0x368
	FairyGUI.GComponent enterPanel; // 0x370
	FairyGUI.GGroup enterGroup; // 0x378
	FairyGUI.GButton severEntrance; // 0x380
	FairyGUI.GButton tryAgainConnectBtn; // 0x388
	FairyGUI.GButton exitSdkBtn; // 0x390
	FairyGUI.Controller ctrlShowTryAgain; // 0x398
	WizardGames.Soc.SocClient.Ui.UiLogin.EAnnouncementPullState pullAnnouncementStateInternal; // 0x3a0
	System.Single fPullAnnouncementTime; // 0x3a4
	System.Boolean tryAutoLogin; // 0x3a8
	static System.Boolean hasAutoLoginned; // 0x0
	System.Boolean hasPendingBeforeLoginAnnouncement; // 0x3a9
	WizardGames.Soc.SDK.ServerNode selectServerNode; // 0x3b0
	WizardGames.Soc.SocClient.Ui.UiLogin.EAnnouncementPullState get_pullAnnouncementState(); // 0x06266d44
	System.Void set_pullAnnouncementState(WizardGames.Soc.SocClient.Ui.UiLogin.EAnnouncementPullState value); // 0x06266da8
	System.Void MakeFullScreen(); // 0x06266f20
	System.Void OnInit(); // 0x062670e8
	System.Void OnSelectServer(WizardGames.Soc.SDK.ServerNode serverNode); // 0x0626903c
	System.Void OnSdkFinish(); // 0x06269724
	System.Void OnQueryServerFinish(); // 0x06269be0
	System.Void OnLobbyLoginFail(); // 0x06269dc4
	System.Void OnEnable(); // 0x06269e48
	System.Void OnExitSdk(FairyGUI.EventContext context); // 0x0626a3f0
	System.Void OnClickAgainLogin(FairyGUI.EventContext e); // 0x0626a5b0
	System.Void TryAgainLogin(); // 0x0626a740
	System.Void OnLobbyLoginRetry(); // 0x0626a974
	System.Void ShowSDKLoginPanel(); // 0x0626a390
	System.Void HideSDKLoginPanel(); // 0x0626a9d8
	System.Void OnUiOpen(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0626aa38
	System.Void OnUiHide(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0626ab98
	System.Void PullAnnouncement(); // 0x06268f14
	System.Void ShowBeforeLoginAnnouncement(); // 0x0626ad30
	System.Boolean LoginEnableCheck(); // 0x0626aec0
	System.Void InitAllLoginBtns(); // 0x06268954
	System.Void OnFps10Update(System.Single dt); // 0x0626b07c
	System.Void OnClickDevLogin(); // 0x0626b510
	System.Void OpenServerSelectWindow(FairyGUI.EventContext e); // 0x0626b5d4
	System.Void ShowDeviceInfo(); // 0x06269eb4
	System.Void OnClickReplay(FairyGUI.EventContext ctx); // 0x0626b6ac
	System.Void OnClickRepair(FairyGUI.EventContext ctx); // 0x0626b794
	System.Void OnDisable(); // 0x0626ba30
	System.Void OnDestroy(); // 0x0626ba98
	System.Void OnFps1Update(System.Single dt); // 0x0626bd1c
	System.Void InitView(); // 0x06268608
	System.Void OnClickService(FairyGUI.EventContext context); // 0x0626be20
	System.Void .ctor(); // 0x0626bec8
	System.Void <OnExitSdk>b__33_0(SimpleJSON.JSONNode jsonNode); // 0x0626bffc
	System.Void <PullAnnouncement>b__42_0(); // 0x0626c248
	System.Void <InitAllLoginBtns>b__45_0(FairyGUI.EventContext ctx); // 0x0626c468
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiLogin.EAnnouncementPullState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiLogin.EAnnouncementPullState Pulling = 0;
	static WizardGames.Soc.SocClient.Ui.UiLogin.EAnnouncementPullState Popup = 1;
	static WizardGames.Soc.SocClient.Ui.UiLogin.EAnnouncementPullState Finish = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLogin.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiLogin.<>c <>9; // 0x0
	static System.Action <>9__27_5; // 0x8
	static System.Action<System.Int32,System.String> <>9__27_0; // 0x10
	static System.Action<System.Int32,System.String> <>9__27_1; // 0x18
	static System.Action <>9__27_2; // 0x20
	static System.Action<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__27_6; // 0x28
	static FairyGUI.EventCallback1 <>9__27_3; // 0x30
	static FairyGUI.EventCallback0 <>9__27_4; // 0x38
	static System.Action<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__43_0; // 0x40
	static System.Action <>9__51_4; // 0x48
	static System.Action<WizardGames.Soc.Common.Download.DownloadResult> <>9__51_1; // 0x50
	static System.Action<System.String,System.Single,System.Single,System.Int64,System.Single> <>9__51_2; // 0x58
	static System.Action<System.String,System.String,System.Action,System.String,System.Action> <>9__51_3; // 0x60
	static System.Action <>9__51_0; // 0x68
	static FairyGUI.EventCallback0 <>9__55_1; // 0x70
	static FairyGUI.EventCallback0 <>9__55_2; // 0x78
	static System.Void .cctor(); // 0x0626c550
	System.Void .ctor(); // 0x0626c5b4
	System.Void <OnInit>b__27_0(System.Int32 method, System.String resultJson); // 0x0626c61c
	System.Void <OnInit>b__27_5(); // 0x0626cd04
	System.Void <OnInit>b__27_1(System.Int32 method, System.String resultJson); // 0x0626cd64
	System.Void <OnInit>b__27_2(); // 0x0626ce84
	System.Void <OnInit>b__27_3(FairyGUI.EventContext context); // 0x0626cf3c
	System.Void <OnInit>b__27_6(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0626d0d4
	System.Void <OnInit>b__27_4(); // 0x0626d1a8
	System.Void <ShowBeforeLoginAnnouncement>b__43_0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0626d26c
	System.Void <OnClickRepair>b__51_0(); // 0x0626d340
	System.Void <OnClickRepair>b__51_1(WizardGames.Soc.Common.Download.DownloadResult result); // 0x0626d634
	System.Void <OnClickRepair>b__51_4(); // 0x0626d9dc
	System.Void <OnClickRepair>b__51_2(System.String message, System.Single downloadSpeed, System.Single curSize, System.Int64 totalSize, System.Single progress); // 0x0626da64
	System.Void <OnClickRepair>b__51_3(System.String label, System.String leftBtnText, System.Action leftCb, System.String rightBtnText, System.Action rightCb); // 0x0626db3c
	System.Void <InitView>b__55_1(); // 0x0626deac
	System.Void <InitView>b__55_2(); // 0x0626df64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLogin.<>c__DisplayClass45_0 : System.Object
{
	FairyGUI.GButton btnLogin; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLogin <>4__this; // 0x18
	System.Void .ctor(); // 0x0626b014
	System.Void <InitAllLoginBtns>b__1(FairyGUI.EventContext ctx); // 0x0626e01c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLogin.<>c__DisplayClass55_0 : System.Object
{
	FairyGUI.Controller showCodeLogin; // 0x10
	System.Void .ctor(); // 0x0626bdb8
	System.Void <InitView>b__0(); // 0x0626e164
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLoginPop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComInputBox accountInput; // 0x338
	WizardGames.Soc.SocClient.Ui.ComCustomButton loginBtn; // 0x340
	FairyGUI.GButton closeBtn; // 0x348
	System.Void OnInit(); // 0x0626e228
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0626e988
	System.Void LoginAction(); // 0x0626ea18
	System.Void SaveToLocal(); // 0x0626efa0
	System.Boolean IsValidAccount(System.String account); // 0x0626ece8
	System.Void CloseLoginWindow(); // 0x0626f040
	System.Void .ctor(); // 0x0626f0bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLoginPop.<>c__DisplayClass3_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLoginPop <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.ComInputBox inputMirror; // 0x18
	System.Void .ctor(); // 0x0626e920
	System.Void <OnInit>b__0(FairyGUI.EventContext ctx); // 0x0626f148
	System.Void <OnInit>b__1(FairyGUI.EventContext ctx); // 0x0626f1e8
	System.Void <OnInit>b__2(); // 0x0626f268
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLoginPrivacy : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLogin.UiLoginPrivacyBinder binder; // 0x338
	System.Void OnInit(); // 0x0626f328
	System.Void OnEnable(); // 0x0627030c
	System.Void OnDisable(); // 0x062703d8
	System.Void OnClickLink(FairyGUI.EventContext context); // 0x062704b0
	System.Void OnAgreeClick(); // 0x0627059c
	System.Void OnRefuseClick(); // 0x062707ac
	System.Void OnCloseClick(); // 0x06270cb0
	System.Void RefusePop(); // 0x06270810
	System.Void .ctor(); // 0x06270d14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLoginPrivacy.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiLoginPrivacy.<>c <>9; // 0x0
	static System.Action <>9__8_0; // 0x8
	static System.Void .cctor(); // 0x06270da0
	System.Void .ctor(); // 0x06270e04
	System.Void <RefusePop>b__8_0(); // 0x06270e6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiReplayBox : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GTextInput inputSvrName; // 0x338
	FairyGUI.GTextInput inputUserName; // 0x340
	FairyGUI.GTextInput inputDate; // 0x348
	System.Void OnInit(); // 0x06270ef4
	System.Void SaveReplayInfo(); // 0x06271310
	System.Void RecoverReplayInfo(); // 0x062711d8
	System.Void OnClickReplay(); // 0x0627145c
	System.Void .ctor(); // 0x062715ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelectServer : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLogin.UiSelectServerPopBinder binder; // 0x338
	System.Collections.Generic.IReadOnlyList<WizardGames.Soc.SDK.ServerNode> allServerNodes; // 0x340
	System.Collections.Generic.IReadOnlyList<WizardGames.Soc.SDK.ServerNode> myServerNodes; // 0x348
	System.Void OnInit(); // 0x06271678
	System.Void OnEnable(); // 0x062725a4
	System.Void RenderServerStatus(System.Int32 index, FairyGUI.GObject go); // 0x0627268c
	System.Void RenderAllServers(System.Int32 index, FairyGUI.GObject go); // 0x0627275c
	System.Void RenderMyServers(System.Int32 index, FairyGUI.GObject go); // 0x06272fec
	System.Void RefreshServerItem(FairyGUI.GObject go, WizardGames.Soc.SDK.ServerNode serverNode); // 0x062728ec
	System.Void OnClickServer(WizardGames.Soc.SDK.ServerNode serverNode); // 0x062731e4
	System.Void .ctor(); // 0x06273668
	System.Void <OnInit>b__3_0(); // 0x062736f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelectServer.<>c__DisplayClass8_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSelectServer <>4__this; // 0x10
	WizardGames.Soc.SDK.ServerNode serverNode; // 0x18
	System.Void .ctor(); // 0x0627317c
	System.Void <RefreshServerItem>b__0(FairyGUI.EventContext context); // 0x06273760
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLoopCostDebug : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.String defaultTitleName; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.LobbySafeAreaDebug.ComCostInfoItemBinder titleBinder; // 0x340
	WizardGames.Soc.SocClient.Ui.Binder.LobbySafeAreaDebug.ComCostInfoBinder contentBinder; // 0x348
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.LobbySafeAreaDebug.ComCostInfoItemBinder> listItemBinders; // 0x350
	System.Collections.Generic.List<UiLoopCostDebuger.UiLoopCostItem> loopCostItems; // 0x358
	UiLoopCostDebuger.UiLoopCostItem debugRootItem; // 0x360
	UiLoopCostDebuger.UiLoopCostItem curRootItem; // 0x368
	System.Int64 updateTimerId; // 0x370
	System.Void OnInit(); // 0x055049cc
	System.Void InitDrag(); // 0x06273eac
	System.Void CostItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x062741f4
	System.Void RefreshCurCostInfo(); // 0x06273fe0
	System.Void SwitchToPage(UiLoopCostDebuger.UiLoopCostItem rootItem); // 0x0627493c
	System.Void OnDestroy(); // 0x062749d8
	System.Void .ctor(); // 0x06274af4
	System.Void <OnInit>b__8_0(); // 0x06274c24
	System.Void <OnInit>b__8_1(); // 0x06274ce0
	System.Void <OnInit>b__8_2(System.Int64 _, System.Object _, System.Boolean _); // 0x06274d4c
	System.Void <InitDrag>b__9_0(FairyGUI.EventContext ctx); // 0x06274de0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLoopCostDebug.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLoopCostDebug <>4__this; // 0x10
	UiLoopCostDebuger.UiLoopCostItem data; // 0x18
	System.Void .ctor(); // 0x062748d4
	System.Void <CostItemRender>b__0(); // 0x06274ec0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMainQuest : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.Collections.Generic.List<System.Int32> factionDataLst; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.GameForce.UiForceBinder binder; // 0x340
	FairyGUI.GList factionLst; // 0x348
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,System.Object>> factionGODic; // 0x350
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x358
	System.Int64 timerId; // 0x360
	System.Void OnInit(); // 0x06274f30
	System.Void OnEnable(); // 0x06275898
	System.Void OnDisable(); // 0x06275c48
	System.Void OnRenderFactionItem(System.Int32 index, FairyGUI.GObject obj); // 0x06275dcc
	System.Void OnClickTraining(); // 0x06276a28
	System.Void OnClickTalent(); // 0x06276ab4
	System.Void OnClickFaction(FairyGUI.EventContext context); // 0x06276b98
	System.Void RefreshMainQuestMission(); // 0x0627716c
	System.Void RefreshList(); // 0x06275998
	System.Void RefreshTrainingEntry(); // 0x06275aa4
	System.Void ClearTimer(); // 0x06275cc4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x062771d8
	static System.Void OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiMainQuest> callBack); // 0x06277328
	static System.Void CloseWindow(); // 0x0627724c
	System.Void .ctor(); // 0x06277428
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMainQuest.<>c__DisplayClass12_0 : System.Object
{
	System.Int32 factionId; // 0x10
	System.Void .ctor(); // 0x06277004
	System.Void <OnClickFaction>b__0(WizardGames.Soc.SocClient.Ui.UiMainQuestDetail win); // 0x06277558
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiForceSwitch : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.UiComSwitchPowerBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComSwitchPowerItemBinder> itemBinders; // 0x340
	System.Collections.Generic.List<System.String> talentTreeIds; // 0x348
	System.Collections.Generic.List<System.Int32> factionTabDataLst; // 0x350
	System.Action<System.Int32> mainQuestCb; // 0x358
	System.Void OnInit(); // 0x06277698
	System.Void OnMainQuestTabItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x0627798c
	System.Void Show(System.Int32 factionId, System.Action<System.Int32> cb); // 0x06277cf0
	System.Void OnEnable(); // 0x06278310
	System.Void OnDisable(); // 0x06278378
	System.Void .ctor(); // 0x062783e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiForceSwitch.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiForceSwitch.<>c <>9; // 0x0
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComSwitchPowerItemBinder> <>9__13_0; // 0x8
	static System.Void .cctor(); // 0x06278618
	System.Void .ctor(); // 0x0627867c
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComSwitchPowerItemBinder <.ctor>b__13_0(FairyGUI.GComponent g); // 0x062786e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiForceSwitch.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiForceSwitch <>4__this; // 0x10
	System.Action<System.Int32> cb; // 0x18
	System.Void .ctor(); // 0x062782a8
	System.Void <Show>b__0(); // 0x06278788
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMainQuestDetail : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GList missionLst; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.UiForceMissionBinder binder; // 0x340
	System.Collections.Generic.List<System.Int32> factionTabDataLst; // 0x348
	System.Collections.Generic.List<WizardGames.Soc.SocClient.MainQuestData> missionDataLst; // 0x350
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,System.Object>> missionGODic; // 0x358
	System.Int32 curFactionId; // 0x360
	WizardGames.Soc.SocClient.MainQuestData curSelectMission; // 0x368
	System.Collections.Generic.List<WizardGames.Soc.SocClient.MainQuestData> missionDescDataLst; // 0x370
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.common.BTuple2> rewardlist; // 0x378
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x380
	System.Int64 getRewardStamp; // 0x388
	System.Collections.Generic.List<WizardGames.Soc.SocClient.MainQuestData> inProgressLst; // 0x390
	System.Void OnInit(); // 0x06278a68
	System.Void OnEnable(); // 0x06279684
	System.Void OnDisable(); // 0x0627a73c
	System.Void OnRenderMissionItem(System.Int32 index, FairyGUI.GObject obj); // 0x0627a7b0
	System.Void OnRenderMissionDescItem(System.Int32 index, FairyGUI.GObject obj); // 0x0627b10c
	System.Void OnRenderRewardItem(System.Int32 index, FairyGUI.GObject obj); // 0x0627b824
	System.Void OnClickFaction(FairyGUI.EventContext context); // 0x0627bb74
	System.Void RefreshMissionState(); // 0x0627d4f4
	System.Void RefreshMissionDetail(); // 0x0627bcd4
	System.Void OnClickGetReward(); // 0x0627e1f4
	System.Void RefreshMission(); // 0x06279ae4
	System.Void RefreshFactionLevel(); // 0x0627e454
	System.Void RefreshDetailLevel(); // 0x06279f04
	System.Void OnClickJump(); // 0x0627e4b8
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0627e74c
	System.Void JumpToFaction(System.Int32 id); // 0x062775dc
	System.Void RefreshWeekExp(); // 0x0627db2c
	System.Void JumpToMission(System.Int32 missionId); // 0x0627eca8
	System.Void OpenForceSwitch(); // 0x0627ee6c
	System.Void OnChangeFaction(System.Int32 id); // 0x0627e7c0
	System.Void OnClickBattlePass(); // 0x0627efb4
	static System.Void OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiMainQuestDetail> callBack); // 0x0627706c
	static System.Void CloseWindow(); // 0x0627e670
	System.Void .ctor(); // 0x0627f078
	System.Void <OnClickGetReward>b__21_0(); // 0x0627f250
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMainQuestDetail.<>c__DisplayClass17_0 : System.Object
{
	WizardGames.Soc.Common.Data.resource.OBJGenaral cfg; // 0x10
	FairyGUI.GObject obj; // 0x18
	System.Void .ctor(); // 0x0627bb0c
	System.Void <OnRenderRewardItem>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon baseItemIcon); // 0x0627f2c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMainQuestConfirm : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyPowerSpecialTraining.UiConfirmPopNewBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x340
	System.Int32 factionId; // 0x348
	System.Void OnInit(); // 0x0627f3d4
	System.Void OnEnable(); // 0x0627f65c
	System.Void OnDisable(); // 0x0627f720
	System.Void Setup(System.Int32 id); // 0x0627f794
	System.Void Setup(System.Boolean finish); // 0x062800d8
	System.Void OnMissionTraceIdChanged(); // 0x06280964
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06280b2c
	static WizardGames.Soc.SocClient.Ui.UiMainQuestConfirm OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiMainQuestConfirm> cb); // 0x06280ba0
	static System.Void CloseWindow(); // 0x06280ab8
	static WizardGames.Soc.SocClient.Ui.UiMainQuestConfirm GetWindow(); // 0x06280c78
	System.Void .ctor(); // 0x06280d38
	System.Void <OnMissionTraceIdChanged>b__8_0(WizardGames.Soc.SocClient.Ui.UiMissionBook win); // 0x06280dcc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMainQuestConfirm.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiMainQuestConfirm.<>c <>9; // 0x0
	static System.Action <>9__7_1; // 0x8
	static FairyGUI.ListItemRenderer <>9__7_2; // 0x10
	static System.Void .cctor(); // 0x06280e58
	System.Void .ctor(); // 0x06280ebc
	System.Void <Setup>b__7_1(); // 0x06280f24
	System.Void <Setup>b__7_2(System.Int32 index, FairyGUI.GObject gObj); // 0x062810bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMainQuestConfirm.<>c__DisplayClass6_0 : System.Object
{
	System.Int32 id; // 0x10
	WizardGames.Soc.Common.Data.Play.OBJMainTaskForce mainQuestCfg; // 0x18
	System.Void .ctor(); // 0x0628159c
	System.Void <Setup>b__0(); // 0x06281604
	System.Void <Setup>b__1(System.Int32 index, FairyGUI.GObject gObj); // 0x062816e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMainQuestConfirm.<>c__DisplayClass7_0 : System.Object
{
	System.Boolean finish; // 0x10
	System.Action <>9__3; // 0x18
	System.Void .ctor(); // 0x06281950
	System.Void <Setup>b__0(); // 0x062819b8
	System.Void <Setup>b__3(); // 0x06281b60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMainQuestTraining : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.LobbyPowerSpecialTraining.UiPowerSpecialTrainingBinder binder; // 0x338
	System.Collections.Generic.List<System.Int32> factionDataLst; // 0x340
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,System.Object>> factionGODic; // 0x348
	FairyGUI.GList factionLst; // 0x350
	FairyGUI.GButton detailBtn; // 0x358
	FairyGUI.GTextField timeTxt; // 0x360
	FairyGUI.GGroup timeGroup; // 0x368
	FairyGUI.Controller rewardCtrl; // 0x370
	FairyGUI.GButton rewardBtn; // 0x378
	WizardGames.Soc.SocClient.Ui.ComResIcon rewardItem; // 0x380
	FairyGUI.TypingEffect te; // 0x388
	System.Int64 timerId; // 0x390
	System.Int64 listAnimTimerId; // 0x398
	System.Void OnInit(); // 0x06281c38
	System.Void OnEnable(); // 0x055049cc
	System.Void OnDisable(); // 0x0628387c
	System.Void RefreshTime(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x06283abc
	System.Void OnClickDetail(); // 0x06283c50
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06283cf8
	System.Void RefreshList(); // 0x0628300c
	System.Void RefreshState(); // 0x06283118
	System.Boolean get_canLeave(); // 0x06283e28
	System.Void OnRenderFactionItem(System.Int32 index, FairyGUI.GObject obj); // 0x06284130
	System.Void OnClickFinish(); // 0x06285860
	System.Void OnClickReward(FairyGUI.EventContext context); // 0x0628596c
	System.Boolean CheckCanGetReward(); // 0x06283344
	System.Void ClearTimer(); // 0x062839b4
	static WizardGames.Soc.SocClient.Ui.UiMainQuestTraining OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiMainQuestTraining> cb); // 0x06285a1c
	static System.Void CloseWindow(); // 0x06283d90
	static WizardGames.Soc.SocClient.Ui.UiMainQuestTraining GetWindow(); // 0x06285af4
	System.Void .ctor(); // 0x06285bb4
	static System.Void .cctor(); // 0x06285cf0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMainQuestTraining.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiMainQuestTraining.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMainQuestConfirm> <>9__25_0; // 0x8
	static System.Void .cctor(); // 0x06285dc4
	System.Void .ctor(); // 0x06285e28
	System.Void <OnClickFinish>b__25_0(WizardGames.Soc.SocClient.Ui.UiMainQuestConfirm win); // 0x06285e90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMainQuestTraining.<>c__DisplayClass24_0 : System.Object
{
	WizardGames.Soc.Common.Data.Play.OBJMainTaskForce mainQuestCfg; // 0x10
	System.Boolean isFinished; // 0x18
	FairyGUI.GComponent comObj; // 0x20
	System.Action<WizardGames.Soc.SocClient.Ui.UiMainQuestConfirm> <>9__1; // 0x28
	System.Action<WizardGames.Soc.SocClient.Ui.UiMainQuestDetail> <>9__3; // 0x30
	System.Void .ctor(); // 0x06285728
	System.Void <OnRenderFactionItem>b__0(); // 0x06285f24
	System.Void <OnRenderFactionItem>b__1(WizardGames.Soc.SocClient.Ui.UiMainQuestConfirm win); // 0x06285fec
	System.Void <OnRenderFactionItem>b__2(); // 0x0628607c
	System.Void <OnRenderFactionItem>b__3(WizardGames.Soc.SocClient.Ui.UiMainQuestDetail win); // 0x0628616c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMainQuestTraining.<>c__DisplayClass24_1 : System.Object
{
	FairyGUI.GButton realBtnDetail; // 0x10
	WizardGames.Soc.SocClient.Ui.UiMainQuestTraining.<>c__DisplayClass24_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x06285790
	System.Void <OnRenderFactionItem>b__4(); // 0x062861fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMainQuestTraining.<>c__DisplayClass24_2 : System.Object
{
	System.Collections.Generic.List<UnityEngine.Vector2> rewardDatalist; // 0x10
	WizardGames.Soc.SocClient.Ui.UiMainQuestTraining.<>c__DisplayClass24_0 CS$<>8__locals2; // 0x18
	System.Void .ctor(); // 0x062857f8
	System.Void <OnRenderFactionItem>b__5(System.Int32 index, FairyGUI.GObject gObj); // 0x0628628c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMainQuestTraining.<>c__DisplayClass24_3 : System.Object
{
	WizardGames.Soc.Common.Data.resource.OBJGenaral cfg; // 0x10
	WizardGames.Soc.SocClient.Ui.ComItemIcon comItemIcon; // 0x18
	WizardGames.Soc.SocClient.Ui.UiMainQuestTraining.<>c__DisplayClass24_2 CS$<>8__locals3; // 0x20
	System.Void .ctor(); // 0x062865c4
	System.Void <OnRenderFactionItem>b__6(WizardGames.Soc.SocClient.Ui.ComBaseIcon baseItemIcon); // 0x0628662c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Com3DUiSceneModel : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Manager.EPreviewType curPreviewType; // 0x10
	System.Boolean curIsAsync; // 0x14
	WizardGames.Soc.SocClient.Manager.PreviewScene curPreviewScene; // 0x18
	System.Boolean DefaultDestoryModel; // 0x20
	UnityEngine.RenderTexture texture; // 0x28
	WizardGames.Soc.SocClient.Manager.Ui3DScene ui3D; // 0x30
	System.Void .ctor(WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase); // 0x0628671c
	System.Void CreateScene(WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase); // 0x062867ac
	System.Void OnPreviewScenePrepared(UnityEngine.GameObject objBg, UnityEngine.GameObject objModel); // 0x06286954
	System.Void Dispose(WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase); // 0x062869d0
	System.Void RefreshUiPanel(System.String packageName, System.String comName, System.Action<FairyGUI.GComponent,UnityEngine.RenderTexture> uiCallback); // 0x06286aa8
	T GetComponent<T>(); // 0x052af1f0
	static System.Void .cctor(); // 0x06286c10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComMallBg : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.ComBgBinder bgBinder; // 0x10
	FairyGUI.GLoader loaderKV; // 0x18
	WizardGames.Soc.SocClient.Ui.ComVideo comVideo; // 0x20
	FairyGUI.Controller ctrlStyle; // 0x28
	System.String curStyle; // 0x30
	System.Action onVideoFinished; // 0x38
	UnityEngine.Coroutine coVideoAutoPlay; // 0x40
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.ComBgBinder bgBinder); // 0x06286ce4
	System.Void ClearPreContent(System.Boolean disposeRes); // 0x06286fac
	System.Void ClearAllContent(System.Boolean playBgAnim); // 0x06287574
	System.Void SetCurStyle(System.String style); // 0x062874b4
	System.Void SetKV(System.String url); // 0x062876f0
	System.Void OnVideoPrepareCompleted(UnityEngine.Video.VideoPlayer player); // 0x06287b8c
	System.Void OnVideoLoopPointReached(UnityEngine.Video.VideoPlayer player); // 0x06287c4c
	System.Void StopVideo(System.Boolean callFinished); // 0x0628736c
	System.Collections.IEnumerator AutoPlayVideoCo(System.String kv, System.String videoPath, System.Action onFinished); // 0x06287cf4
	System.Void SetVideoAutoPlay(System.String kv, System.String videoPath, System.Action onFinished); // 0x06287e7c
	System.Void StopVideoAutoPlay(UnityEngine.MonoBehaviour env); // 0x06287188
	System.Void OnScenePrepared(); // 0x06287ffc
	System.Void SetScene(System.String path); // 0x062880f8
	static System.Void .cctor(); // 0x06288204
	System.Void <OnScenePrepared>b__27_0(System.Object param); // 0x062882d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComMallBg.<AutoPlayVideoCo>d__24 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.String kv; // 0x20
	WizardGames.Soc.SocClient.Ui.ComMallBg <>4__this; // 0x28
	System.Action onFinished; // 0x30
	System.String videoPath; // 0x38
	System.Single <startLoadVideoTime>5__2; // 0x40
	WizardGames.Soc.SocClient.Ui.ComCommonVideo <commonVideo>5__3; // 0x48
	System.Void .ctor(System.Int32 <>1__state); // 0x06287df8
	System.Void System.IDisposable.Dispose(); // 0x06288374
	System.Boolean MoveNext(); // 0x062883d4
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x06288998
	System.Void System.Collections.IEnumerator.Reset(); // 0x062889fc
	System.Object System.Collections.IEnumerator.get_Current(); // 0x06288a84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSceneModel : FairyGUI.GComponent
{
	FairyGUI.GLoader bgLoader; // 0x288
	FairyGUI.Controller sceneTypeCtrl; // 0x290
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Manager.EPreviewType curPreviewType; // 0x298
	System.Int32 curBgCfgId; // 0x29c
	System.Int32 defaultBgCfgId; // 0x2a0
	System.Boolean curIsAsync; // 0x2a4
	UnityEngine.GameObject objSceneBg; // 0x2a8
	UnityEngine.GameObject objModelRoot; // 0x2b0
	WizardGames.Soc.SocClient.Manager.PreviewScene curPreviewScene; // 0x2b8
	FairyGUI.GObject rotateArea; // 0x2c0
	WizardGames.Soc.SocClient.Manager.RotateModeBase rotateModeBase; // 0x2c8
	System.Boolean hasSetRotateAction; // 0x2d0
	WizardGames.Soc.SocClient.Ui.ModelConfig modelConfig; // 0x2d8
	System.String itemModelPath; // 0x2e0
	UnityEngine.GameObject curModelGo; // 0x2e8
	WizardGames.Soc.SocClient.Ui.PlayerSceneModel playerModel; // 0x2f0
	System.Action<UnityEngine.GameObject,UnityEngine.GameObject> onScenePrepared; // 0x2f8
	System.Boolean DestroyModelResOnFree; // 0x300
	UnityEngine.Renderer bgRender; // 0x308
	UnityEngine.GameObject cameraRoot; // 0x310
	System.Collections.Generic.HashSet<System.String> usePoolKeys; // 0x318
	System.Boolean <IsShowItem>k__BackingField; // 0x320
	UnityEngine.Vector3 cameraPos; // 0x324
	System.Func<System.Int32,System.Int32> switchFunc; // 0x330
	System.Boolean show2D; // 0x338
	WizardGames.Soc.SocClient.Ui.SprayBinder sprayBinder; // 0x340
	FairyGUI.GoWrapper fxSpray; // 0x348
	System.Boolean isPlayFX; // 0x350
	System.Single allFXTime; // 0x354
	System.Single playFXTime; // 0x358
	System.Boolean isInitFX; // 0x35c
	System.Int64 timerSprayId; // 0x360
	UnityEngine.Vector3 origiPos; // 0x368
	UnityEngine.Transform rotateNode; // 0x378
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x06288ae8
	System.Void .ctor(); // 0x06288c0c
	System.Void SetSceneModel(WizardGames.Soc.SocClient.Manager.EPreviewType previewType, System.Int32 bgCfgId, WizardGames.Soc.SocClient.Manager.RotateModeBase rotateModeBase, FairyGUI.GObject rotateArea, System.Boolean isAsync); // 0x06288d1c
	System.Boolean get_IsShowItem(); // 0x06288e90
	System.Void set_IsShowItem(System.Boolean value); // 0x06288ef4
	UnityEngine.GameObject get_CurModelGo(); // 0x06288f70
	System.Void .ctor(WizardGames.Soc.SocClient.Manager.EPreviewType previewType, System.Int32 bgCfgId, WizardGames.Soc.SocClient.Manager.RotateModeBase rotateModeBase, FairyGUI.GObject rotateArea, System.Boolean isAsync); // 0x06288fd4
	System.Void SetSwitchBgIdFunc(System.Func<System.Int32,System.Int32> func); // 0x062891a0
	UnityEngine.GameObject GoPoolGetAndRecord(System.String modelPath); // 0x06289220
	System.String GetItemModelPathFromPool(System.String modelPath); // 0x062892ec
	System.Void FreeAllGoPools(); // 0x062894c4
	System.Void FreeLastModel(); // 0x062896f4
	System.Boolean SetResData(System.Int32 resId, WizardGames.Soc.SocClient.Ui.ModelConfig modelCfg, System.Action<UnityEngine.GameObject,UnityEngine.GameObject> onShow); // 0x06289c50
	System.Void SetSceneCameraPlan(System.Int32 planId); // 0x0628b91c
	System.Void OnlySetPreviewBg(System.Int32 resId, System.Action<UnityEngine.GameObject,UnityEngine.GameObject> onShow); // 0x0628ba40
	System.Void OnFxSprayDispose(); // 0x0628bb18
	System.Void PlaySprayFX(System.Int32 id, FairyGUI.GGraph fxRoot); // 0x0550f6d4
	System.Void UpdateFPS(System.Int64 timeId, System.Object callbackData, System.Boolean needDelete); // 0x0628bbc8
	System.Void StopSprayFX(); // 0x062899c4
	System.String Get2DResUrl(System.Int32 resId); // 0x0628afcc
	System.Boolean IsNeedToShow2DRes(System.Int32 resId, WizardGames.Soc.Common.Data.resource.ENUMSkinType& skinType); // 0x0628a9f4
	System.Boolean SetPlayerData(System.Int32 id, System.Collections.Generic.Dictionary<System.Int32,System.Int32> equips, WizardGames.Soc.SocClient.Ui.PlayerAppearanceInfo info, WizardGames.Soc.SocClient.Ui.ModelConfig modelCfg, System.Action<UnityEngine.GameObject,UnityEngine.GameObject> onShow, System.Boolean playSuitAnim, System.Int32 tarSex); // 0x0628bcb0
	System.Boolean PlaySuitPerformance(); // 0x0628cbc0
	System.Void ApplyModel(); // 0x0628b484
	System.Void ShowScene(); // 0x0628cd00
	System.Void HandleModelOnScenePrepared(); // 0x0628ced0
	System.Void OnPreviewScenePrepared(UnityEngine.GameObject objBg, UnityEngine.GameObject objModel); // 0x0628b30c
	System.Void SetModelActive(System.Boolean active); // 0x0628d324
	System.Void SwitchPreviewScene(WizardGames.Soc.SocClient.Manager.EPreviewType previewType, System.Int32 bgCfgId, System.Boolean isAsync); // 0x0628a928
	System.Void DisposeRes(); // 0x0628d3f8
	static System.Boolean SetBg(UnityEngine.Renderer bgRender, System.Int32 bgId); // 0x0628d604
	System.Boolean SetBg(System.Int32 bgId); // 0x0628d924
	static System.Void .cctor(); // 0x0628dadc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ListItemShopPageSpecial : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.ListItemShopPageSpecialBinder itemBinder; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.ListItemShopPageItemSpecialBinder item1; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.ListItemShopPageItemSpecialBinder item2; // 0x20
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.ListItemShopPageSpecialBinder binder); // 0x0628dbb0
	System.Void SetData(WizardGames.Soc.SocClient.Ui.UiMallSpecial.RewardLisData data); // 0x0628dcf4
	System.Void OnItemClick(WizardGames.Soc.Common.Data.mall.OBJLotteryExchangeRewards data); // 0x0628e8bc
	System.Void OnClickPurchaseBtn(FairyGUI.EventContext context, WizardGames.Soc.Common.Data.mall.OBJLotteryExchangeRewards data); // 0x0628eb28
	System.Void SetItem(WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.ListItemShopPageItemSpecialBinder item, WizardGames.Soc.Common.Data.mall.OBJLotteryExchangeRewards reward); // 0x0628e284
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ListItemShopPageSpecial.<>c__DisplayClass4_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ListItemShopPageSpecial <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.UiMallSpecial.RewardLisData data; // 0x18
	System.Void .ctor(); // 0x0628e21c
	System.Void <SetData>b__0(); // 0x0628ed90
	System.Void <SetData>b__1(FairyGUI.EventContext ctx); // 0x0628ee08
	System.Void <SetData>b__2(); // 0x0628ee98
	System.Void <SetData>b__3(FairyGUI.EventContext ctx); // 0x0628ef10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PlayerSceneModel : System.Object
{
	WizardGames.Soc.SocClient.GoLoader.DisplayModel displayModel; // 0x10
	UnityEngine.GameObject objPlayerModel; // 0x18
	UnityEngine.GameObject objModelRoot; // 0x20
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent objPlayerModelPoint; // 0x28
	WizardGames.Soc.Common.CustomType.PlayerDisplayData displayData; // 0x30
	System.Boolean <IsValid>k__BackingField; // 0x38
	System.Boolean get_IsValid(); // 0x0628efa0
	System.Void set_IsValid(System.Boolean value); // 0x0628f004
	UnityEngine.GameObject CreateModel(System.String name, WizardGames.Soc.SocClient.GoLoader.ModelType modelType, System.String animPath, System.Boolean playSuitAnim, System.Int32 tarSex); // 0x0628c044
	System.Void ChangeSex(System.Int32 tarSex, System.Boolean callRefresh); // 0x0628c5c4
	System.Void ReleaseModel(); // 0x06289b00
	System.Void ChangeAppearance(WizardGames.Soc.SocClient.Ui.PlayerAppearanceInfo info); // 0x0628c84c
	System.Void SetPlayerEquip(System.Collections.Generic.Dictionary<System.Int32,System.Int32> equips, System.Boolean callUpdate); // 0x0628c924
	System.Void UpdateAllPart(); // 0x0628f080
	System.Void PlaySuitPerformance(); // 0x0628cc8c
	System.Void .ctor(); // 0x06288e28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MallPageBase : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComLazyLoader lazyLoader; // 0x10
	WizardGames.Soc.SocClient.Ui.UiMall uiMain; // 0x18
	FairyGUI.GComponent comRoot; // 0x20
	System.Boolean isActive; // 0x28
	WizardGames.Soc.SocClient.Ui.MallPageBase BindLoader(WizardGames.Soc.SocClient.Ui.UiMall main, WizardGames.Soc.SocClient.Ui.ComLazyLoader loader); // 0x0628f0f0
	System.Void OnLoaderCreate(FairyGUI.GComponent com); // 0x0628f230
	System.Void OnLoaderDestory(); // 0x0628f2b0
	System.Void OnShow(System.Int32 jumpId, WizardGames.Soc.Common.Data.mall.OBJMallNavTab tabCfg); // 0x0628f31c
	System.Void OnHide(); // 0x0628f394
	System.Void OnShowByLayerStack(); // 0x0628f3f4
	System.Void OnHideByLayerStack(System.String coverUiName); // 0x0628f454
	System.Void OnRefresh(System.Int32 jumpId, WizardGames.Soc.Common.Data.mall.OBJMallNavTab tabCfg); // 0x0628f4c8
	System.Void OnPlayShowAnim(); // 0x0628f544
	System.Void Show(System.Int32 jumpId, WizardGames.Soc.Common.Data.mall.OBJMallNavTab tabCfg); // 0x0628f5a4
	System.Void Hide(); // 0x0628f684
	System.Void .ctor(); // 0x0628f700
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MallPageBundles : WizardGames.Soc.SocClient.Ui.MallPageBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.RootMallContent_BundlePageBinder pageRoot; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.mall.OBJBundle> allBundles; // 0x38
	WizardGames.Soc.Common.Data.mall.OBJBundle curSelectBundleData; // 0x40
	System.Collections.Generic.List<System.String> requestParams; // 0x48
	WizardGames.Soc.Common.Data.mall.OBJMallNavTab oBJMallNavTab; // 0x50
	System.Int64 autoPlayTimerId; // 0x58
	System.Void OnLoaderCreate(FairyGUI.GComponent com); // 0x05523a54
	System.Void OnLoaderDestory(); // 0x0628fc58
	System.Void OnShow(System.Int32 jumpId, WizardGames.Soc.Common.Data.mall.OBJMallNavTab tabCfg); // 0x0550f6d4
	System.Void OnHide(); // 0x062900ec
	System.Void OnPlayShowAnim(); // 0x062902fc
	System.Void OnShowByLayerStack(); // 0x062903c0
	System.Void OnHideByLayerStack(System.String coverUiName); // 0x062904b0
	System.Void RequestBundleInfo(); // 0x0628fdf8
	System.Void OnBundleInfoUpdate(); // 0x06290594
	System.Void RefreshCurData(); // 0x055049cc
	System.Void OnRefresh(System.Int32 jumpId, WizardGames.Soc.Common.Data.mall.OBJMallNavTab tabCfg); // 0x0550f6d4
	System.Void CancelAutoPlayTimer(); // 0x055049cc
	System.Void ResetAutoPlayTimer(); // 0x055049cc
	System.Void OnBundleListItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x062919d8
	System.Void SetBG(WizardGames.Soc.Common.Data.mall.OBJBundle bundleData); // 0x06291b14
	System.Void OnSelectItem(WizardGames.Soc.Common.Data.mall.OBJBundle bundleData); // 0x06291414
	System.Boolean IsContainBuildingOrFurniture(WizardGames.Soc.Common.Data.mall.OBJBundle bundleData); // 0x06291c6c
	System.Void OnSelectItem(FairyGUI.EventContext ctx); // 0x06291ec8
	System.Void OnClickPlayBtn(System.Boolean showTips); // 0x05523a7c
	System.Void OnClickDetailBtn(); // 0x06292240
	System.Void OnClickBuyBtn(); // 0x06292410
	System.Void .ctor(); // 0x062926e8
	System.Void <OnLoaderCreate>b__6_0(); // 0x055049cc
	System.Void <ResetAutoPlayTimer>b__18_0(System.Int64 _, System.Object _, System.Boolean _); // 0x05512cfc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MallPageBundles.<>c__DisplayClass16_0 : System.Object
{
	System.Int32 jumpId; // 0x10
	System.Void .ctor(); // 0x055049cc
	System.Boolean <OnRefresh>b__0(WizardGames.Soc.Common.Data.mall.OBJBundle bundle); // 0x054dec74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MallPageBundles.<>c__DisplayClass24_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MallPageBundles <>4__this; // 0x10
	System.Boolean showTips; // 0x18
	System.Action <>9__1; // 0x20
	System.Action <>9__2; // 0x28
	System.Void .ctor(); // 0x055049cc
	System.Void <OnClickPlayBtn>b__0(); // 0x055049cc
	System.Void <OnClickPlayBtn>b__1(); // 0x055049cc
	System.Void <OnClickPlayBtn>b__2(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MallPageGacha : WizardGames.Soc.SocClient.Ui.MallPageBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.RootMallContent_LucklyDrawPageBinder pageRoot; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.mall.OBJMallGacha> allGachas; // 0x38
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.ListItemBigBinder> lotteryItemMap; // 0x40
	System.Void OnLoaderCreate(FairyGUI.GComponent com); // 0x06292d9c
	System.Void OnLoaderDestory(); // 0x06292f54
	System.Void OnPlayShowAnim(); // 0x06292fc8
	System.Void OnRefresh(System.Int32 jumpId, WizardGames.Soc.Common.Data.mall.OBJMallNavTab tabCfg); // 0x0629308c
	System.Void GachaListItemRenderer(System.Int32 index, FairyGUI.GObject gObject); // 0x06293384
	System.Void OnClickGacha(WizardGames.Soc.Common.Data.mall.OBJMallGacha gacha); // 0x062939b4
	System.Void OnShow(System.Int32 jumpId, WizardGames.Soc.Common.Data.mall.OBJMallNavTab tabCfg); // 0x06293ab4
	System.Void OnHide(); // 0x06293b3c
	System.Void .ctor(); // 0x06293ba0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MallPageGacha.<>c__DisplayClass6_0 : System.Object
{
	System.Int32 jumpId; // 0x10
	System.Void .ctor(); // 0x0629331c
	System.Boolean <OnRefresh>b__0(WizardGames.Soc.Common.Data.mall.OBJMallGacha g); // 0x06293c50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MallPageGacha.<>c__DisplayClass7_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MallPageGacha <>4__this; // 0x10
	WizardGames.Soc.Common.Data.mall.OBJMallGacha gacha; // 0x18
	System.Void .ctor(); // 0x0629394c
	System.Void <GachaListItemRenderer>b__0(); // 0x06293cdc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MallPageHotSale : WizardGames.Soc.SocClient.Ui.MallPageBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.RootMallContent_HotPageBinder pageRoot; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.mall.OBJHotSale> allHotSales; // 0x38
	WizardGames.Soc.Common.Data.mall.OBJHotSale curSelectHotSaleData; // 0x40
	System.Int64 autoRollTimerId; // 0x48
	System.Int32 autoScrollCDMs; // 0x50
	System.Int64 autoPlayTimerId; // 0x58
	System.Void OnLoaderCreate(FairyGUI.GComponent com); // 0x06293d4c
	System.Void OnLoaderDestory(); // 0x06294124
	System.Void OnShow(System.Int32 jumpId, WizardGames.Soc.Common.Data.mall.OBJMallNavTab tabCfg); // 0x06294198
	System.Void OnHide(); // 0x062942b4
	System.Void OnPlayShowAnim(); // 0x06294558
	System.Void OnShowByLayerStack(); // 0x0629461c
	System.Void OnHideByLayerStack(System.String coverUiName); // 0x06294698
	System.Void OnRefresh(System.Int32 jumpId, WizardGames.Soc.Common.Data.mall.OBJMallNavTab tabCfg); // 0x06294784
	System.Void CancelAutoPlayTimer(); // 0x06294450
	System.Void ResetAutoPlayTimer(); // 0x062955a4
	System.Void CancelAutoRollTimer(); // 0x06294348
	System.Void ResetAutoRollTimer(); // 0x055049cc
	System.Void OnListItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x062957d4
	System.Void SetBG(WizardGames.Soc.Common.Data.mall.OBJHotSale hotSaleData); // 0x06295910
	System.Void OnSelectItem(WizardGames.Soc.Common.Data.mall.OBJHotSale hotSaleData); // 0x06294c1c
	System.Void OnSelectItem(FairyGUI.EventContext ctx); // 0x06295a68
	System.Void DoScroll(); // 0x06295c40
	System.Void OnAutoScrollTimer(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x06295ddc
	System.Void OnClickJump(); // 0x06295e70
	System.Void OnClickPlayBtn(System.Boolean showTips); // 0x0629641c
	System.Void .ctor(); // 0x062965c4
	System.Void <OnLoaderCreate>b__7_0(); // 0x06296628
	System.Void <ResetAutoPlayTimer>b__16_0(System.Int64 _, System.Object _, System.Boolean _); // 0x06296690
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MallPageHotSale.<>c__DisplayClass25_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MallPageHotSale <>4__this; // 0x10
	WizardGames.Soc.Common.Data.mall.OBJHotSale saleData; // 0x18
	System.Void .ctor(); // 0x062961d8
	System.Void <OnClickJump>b__0(); // 0x0629672c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MallPageHotSale.<>c__DisplayClass26_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MallPageHotSale <>4__this; // 0x10
	System.Boolean showTips; // 0x18
	System.Action <>9__1; // 0x20
	System.Action <>9__2; // 0x28
	System.Void .ctor(); // 0x0629655c
	System.Void <OnClickPlayBtn>b__0(); // 0x062967ac
	System.Void <OnClickPlayBtn>b__1(); // 0x06296a40
	System.Void <OnClickPlayBtn>b__2(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MallPageShopItems : WizardGames.Soc.SocClient.Ui.MallPageBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.RootMallContent_ShopPageSpecialBinder pageRoot; // 0x30
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.ListItemShopPageSpecialBinder> itemBinders; // 0x38
	System.Single biggerItemWidth; // 0x40
	System.Single smallItemWidth; // 0x44
	System.Int64 showAnimTimerId; // 0x48
	System.Boolean hasAddPack; // 0x50
	System.Int32 curScrollIndex; // 0x54
	WizardGames.Soc.Common.Data.mall.MallShelfType curShelf; // 0x58
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.MallPageShopItems.MallListData> mallListDataPool; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.MallPageShopItems.MallListData> allListDatas; // 0x68
	System.Int32 jumpId; // 0x70
	WizardGames.Soc.Common.Data.mall.OBJMallNavTab oBJMallNavTab; // 0x78
	System.Void OnLoaderCreate(FairyGUI.GComponent com); // 0x06296c94
	System.Void OnLoaderDestory(); // 0x06296f88
	System.Void AddMallItemRefPacks(); // 0x06297024
	System.Void ReleaseMallItemRefPacks(); // 0x0629713c
	System.Void OnShow(System.Int32 jumpId, WizardGames.Soc.Common.Data.mall.OBJMallNavTab tabCfg); // 0x0550f6d4
	System.Void OnHide(); // 0x06297548
	System.Void OnPlayShowAnim(); // 0x062976e4
	System.Void OnMallItemInfoUpdate(); // 0x055049cc
	System.Void OnRefresh(System.Int32 jumpId, WizardGames.Soc.Common.Data.mall.OBJMallNavTab tabCfg); // 0x0629781c
	System.Void TryOpenJumpMallBuy(System.Int32 jumpId); // 0x06297f30
	WizardGames.Soc.SocClient.Ui.MallPageShopItems.MallListData GetMallListDataFromPool(System.Boolean isBig, WizardGames.Soc.SocClient.MallItemAdapter adapter1, WizardGames.Soc.SocClient.MallItemAdapter adapter2); // 0x062982e4
	System.Void ReturnMallListDatasToPool(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.MallPageShopItems.MallListData> datas); // 0x06298478
	System.Void CollectListDatasAndRefresh(WizardGames.Soc.Common.Data.mall.MallShelfType shelf, System.Int32 jumpId); // 0x06297918
	System.Void FillRowOfListDatas(System.Boolean isBig); // 0x06298748
	System.Void JumpShopItemMallBuy(WizardGames.Soc.SocClient.MallItemAdapter adapter); // 0x06298064
	System.Void OnClickShopItem(WizardGames.Soc.SocClient.MallItemAdapter adapter); // 0x0629af90
	System.Void OnClickShopItemBuy(WizardGames.Soc.SocClient.MallItemAdapter adapter); // 0x0629b14c
	System.Void SetShopItem(WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.ListItemShopPageItemSpecialBinder itemBinder, WizardGames.Soc.SocClient.MallItemAdapter adapter); // 0x0552af00
	System.Void OnShopItemListItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x0629d4a4
	System.Void .ctor(); // 0x0629d744
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MallPageShopItems.MallListData : System.Object
{
	WizardGames.Soc.SocClient.MallItemAdapter data1; // 0x10
	WizardGames.Soc.SocClient.MallItemAdapter data2; // 0x18
	System.Boolean isBig; // 0x20
	System.Void Clear(); // 0x062986c4
	System.Void .ctor(); // 0x06298410
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MallPageShopItems.<>c__DisplayClass31_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MallPageShopItems <>4__this; // 0x10
	WizardGames.Soc.SocClient.MallItemAdapter adapter; // 0x18
	System.Void .ctor(); // 0x055049cc
	System.Void <SetShopItem>b__0(); // 0x055049cc
	System.Void <SetShopItem>b__1(FairyGUI.EventContext context); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMall : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.SocClient.Ui.IJumpToUIWindow
{
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.mall.MallPageType,System.Func<WizardGames.Soc.SocClient.Ui.MallPageBase>> pageRegister; // 0x338
	WizardGames.Soc.SocClient.Ui.ComMallBg <ComBg>k__BackingField; // 0x340
	FairyGUI.Controller ctrlPage; // 0x348
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar comNavBar; // 0x350
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.mall.MallPageType,WizardGames.Soc.SocClient.Ui.ComLazyLoader> pageLazyLoaders; // 0x358
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.mall.MallPageType,WizardGames.Soc.SocClient.Ui.MallPageBase> pages; // 0x360
	System.Collections.Generic.Dictionary<System.Int32,System.String> pageBgs; // 0x368
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.mall.OBJMallNavTab>> tabGroupRec; // 0x370
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.mall.MallShelfType,System.Int32> shelfItemCount; // 0x378
	WizardGames.Soc.Common.Data.mall.MallPageType curPageType; // 0x380
	System.Int32 curNavID; // 0x384
	System.Int32 autoJumpId; // 0x388
	System.Boolean JumpFromHotSale; // 0x38c
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x390
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.NavBarData> navBarDataList; // 0x398
	System.Collections.Generic.List<System.Int32> mallGachaList; // 0x3a0
	System.Collections.Generic.List<System.Int32> mallfragmentList; // 0x3a8
	WizardGames.Soc.SocClient.Ui.ComMallBg get_ComBg(); // 0x0629d900
	System.Void set_ComBg(WizardGames.Soc.SocClient.Ui.ComMallBg value); // 0x0629d964
	System.Void OnInit(); // 0x0629d9e4
	WizardGames.Soc.SocClient.Ui.NavBarData AppendBavBarData(WizardGames.Soc.Common.Data.mall.OBJMallNavTab tabCfg, System.Int32 parentID); // 0x0629ede8
	System.Boolean IsShowRedDot(System.Int32 pageId); // 0x0629f054
	System.Boolean IsGachaShowRedDot(); // 0x0629f0e8
	System.Void RefreshRedDot(); // 0x0629f3b4
	System.Void RefreshNavTabs(System.Boolean autoChoose, System.Boolean curChooseFirst); // 0x0629e66c
	System.Void OnEnable(); // 0x0629f654
	System.Void OnDisable(); // 0x0629f84c
	System.Void OnShowByLayerStack(); // 0x0629f8b4
	System.Void OnHideByLayerStack(System.String coverUiName); // 0x0629f978
	System.Void ChooseNavByCfg(WizardGames.Soc.Common.Data.mall.OBJMallNavTab navCfg); // 0x0629f58c
	System.Void OnClickTab(WizardGames.Soc.SocClient.Ui.NavBarData tab, System.Boolean isBtnClick); // 0x0629fa4c
	System.Void JumpToInternal(WizardGames.Soc.Common.Data.mall.OBJMallNavTab tabCfg, System.Int32 jumpId); // 0x0629fbf8
	System.Void JumpTo(System.Int32 mallNavID, System.Int32 jumpId); // 0x06296240
	System.Void JumpToUIWindow(WizardGames.Soc.SocClient.Ui.JumpData jumpData); // 0x0629ff4c
	System.Void OnClickClose(FairyGUI.EventContext ctx); // 0x0629ffe0
	System.Void OnDestroy(); // 0x062a0060
	System.Void .ctor(); // 0x062a0174
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMall.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiMall.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.SocClient.Ui.MallPageBase> <>9__37_0; // 0x8
	static System.Func<WizardGames.Soc.SocClient.Ui.MallPageBase> <>9__37_1; // 0x10
	static System.Func<WizardGames.Soc.SocClient.Ui.MallPageBase> <>9__37_2; // 0x18
	static System.Func<WizardGames.Soc.SocClient.Ui.MallPageBase> <>9__37_3; // 0x20
	static System.Void .cctor(); // 0x062a0748
	System.Void .ctor(); // 0x062a07ac
	WizardGames.Soc.SocClient.Ui.MallPageBase <.ctor>b__37_0(); // 0x062a0814
	WizardGames.Soc.SocClient.Ui.MallPageBase <.ctor>b__37_1(); // 0x062a089c
	WizardGames.Soc.SocClient.Ui.MallPageBase <.ctor>b__37_2(); // 0x062a0924
	WizardGames.Soc.SocClient.Ui.MallPageBase <.ctor>b__37_3(); // 0x062a09ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMallBuy : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.UiMallBuyBinder uiBinder; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.RootMallBuyContentBinder contentBinder; // 0x340
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x348
	FairyGUI.Controller ctrlRare; // 0x350
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComResIcon> allResIcons; // 0x358
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiMallBuy.SubResInfo> allSubRes; // 0x360
	WizardGames.Soc.Common.Data.mall.OBJBundle curBundle; // 0x368
	System.Boolean isCurBundleSoldOut; // 0x370
	System.Int32 curSellGoodId; // 0x374
	System.Int32 curGoodsIndex; // 0x378
	WizardGames.Soc.SocClient.MallItemAdapter curMallItem; // 0x380
	System.Int32 curShowResId; // 0x388
	WizardGames.Soc.SocClient.Ui.ComSceneModel comSceneModel; // 0x390
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> modelShowCfg; // 0x398
	WizardGames.Soc.SocClient.Manager.RotateModeConstraintAngle rotateModel; // 0x3a0
	WizardGames.Soc.SocClient.Manager.RotateModeConstraintAngleParams rotateAllParam; // 0x3a8
	WizardGames.Soc.SocClient.Manager.RotateModeConstraintAngleParams rotateHorizontalParam; // 0x3b0
	MallModelPreviewBgSwitch bgSwitch; // 0x3b8
	FairyGUI.GButton skinModifyBtn; // 0x3c0
	System.Int32 curBgId; // 0x3c8
	System.String originalBgUrl; // 0x3d0
	System.Int32 curBundleCanSellResCount; // 0x3d8
	System.Int32 azureType; // 0x3dc
	System.Int32 newPreset; // 0x3e0
	WizardGames.Soc.SocClient.Ui.ModelConfig playerModelConfig; // 0x3e8
	WizardGames.Soc.SocClient.Ui.SprayBinder sprayBinder; // 0x3f0
	FairyGUI.GGraph fxRoot; // 0x3f8
	FairyGUI.GoWrapper fxSpray; // 0x400
	System.Boolean isPlayFX; // 0x408
	System.Single allFXTime; // 0x40c
	System.Single playFXTime; // 0x410
	System.Boolean isInitFX; // 0x414
	System.Int64 timerSprayId; // 0x418
	System.Void OnInit(); // 0x062a0a34
	System.Void Clear(System.Boolean includeShowCfg); // 0x062a14f8
	System.Void InitTODData(); // 0x062a1680
	System.Int32 OnSwitchBgId(System.Int32 id); // 0x062a1754
	System.Void SetBundleTodData(System.Int32 id); // 0x062a1b2c
	System.Void SetMallTodData(System.Int32 id); // 0x062a1e24
	WizardGames.Soc.Common.Data.mall.OBJReTailMallTod GetReTailMallTod(WizardGames.Soc.Common.Data.resource.OBJSkin skinConfig); // 0x062a20a4
	System.Void OnComponentUpdate(); // 0x062a220c
	System.Void OnEnable(); // 0x062a22b0
	System.Boolean IsContainBuildingOrFurniture(WizardGames.Soc.Common.Data.mall.OBJBundle bundleData); // 0x062a27d4
	System.Void SwitchCustomWeather(); // 0x062a2a30
	System.Void OnDisable(); // 0x062a2c40
	System.Void RecoverTODOnExit(); // 0x062a2e9c
	System.Void OnShowByLayerStack(); // 0x062a2efc
	System.Void OnClickClose(FairyGUI.EventContext ctx); // 0x062a3064
	System.Void OnBundleInfoUpdate(); // 0x062a2f74
	System.Void OnMallItemInfoUpdate(); // 0x062a2fec
	System.Void SetData(WizardGames.Soc.Common.Data.mall.OBJBundle bundle); // 0x062909e4
	System.Void SetData(WizardGames.Soc.SocClient.MallItemAdapter adapter); // 0x06298994
	System.Void OnClickBuy(); // 0x062a3134
	System.Void OnClickDisplay(); // 0x062a3770
	System.Void OnClickModifySkin(); // 0x062a3e44
	System.Void OnClickSingleBuy(); // 0x062a3efc
	System.Void ResItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x062a4008
	System.Void OnClickResIcon(System.Int32 index, WizardGames.Soc.SocClient.Ui.ComBaseIcon icon, WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg, WizardGames.Soc.SocClient.Ui.UiMallBuy.SubResInfo info); // 0x062a44b0
	System.Boolean IsNeedToShowPlayerModel(WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg, System.Collections.Generic.Dictionary<System.Int32,System.Int32> res); // 0x062a4bc4
	System.Boolean IsNeedToShowCostumeSuitModel(WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg, System.Collections.Generic.Dictionary<System.Int32,System.Int32> res, System.Int32& sex); // 0x062a4e18
	System.Boolean IsNeedToShowFixedPackPlayerModel(WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg, System.Collections.Generic.Dictionary<System.Int32,System.Int32> res, System.Int32& sex); // 0x062a51dc
	System.Boolean IsNeedToShow2DRes(WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg, WizardGames.Soc.Common.Data.resource.ENUMSkinType& skinType); // 0x062a55b8
	System.Void RefreshModelBg(); // 0x062a56f4
	System.Void OnModelScenePrepared(UnityEngine.GameObject objModel, UnityEngine.GameObject objBg); // 0x062a584c
	WizardGames.Soc.SocClient.Ui.ModelConfig GetModelConfigByResId(System.Int32 resId); // 0x062a5a9c
	System.Void Refresh2DResBg(WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg, WizardGames.Soc.Common.Data.resource.ENUMSkinType type); // 0x062a5db0
	System.Void Refresh2DResShow(WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg, WizardGames.Soc.Common.Data.resource.ENUMSkinType type); // 0x062a5f48
	System.Void OnFxSprayDispose(); // 0x062a6b4c
	System.Void PlaySprayFX(System.Int32 id); // 0x055056e8
	System.Void StopSprayFX(); // 0x062a2d4c
	System.Void UpdateFPS(System.Int64 timeId, System.Object callbackData, System.Boolean needDelete); // 0x062a6bf8
	System.Void UpdateModifyState(); // 0x062a6ce0
	System.Void RefreshResShow(WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg); // 0x062a242c
	System.Void .ctor(); // 0x062a6e1c
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiMallBuy.SubResInfo : System.ValueType
{
	System.Int32 <ResId>k__BackingField; // 0x10
	System.Int32 <SellGoodId>k__BackingField; // 0x14
	System.Int32 <Price>k__BackingField; // 0x18
	System.Boolean <IsOwned>k__BackingField; // 0x1c
	System.Int32 <Count>k__BackingField; // 0x20
	System.Boolean <IsFree>k__BackingField; // 0x24
	System.Int32 get_ResId(); // 0x062a7e74
	System.Void set_ResId(System.Int32 value); // 0x062a7ed8
	System.Int32 get_SellGoodId(); // 0x062a7f50
	System.Void set_SellGoodId(System.Int32 value); // 0x062a7fb4
	System.Int32 get_Price(); // 0x062a802c
	System.Void set_Price(System.Int32 value); // 0x062a8090
	System.Boolean get_IsOwned(); // 0x062a8108
	System.Void set_IsOwned(System.Boolean value); // 0x062a816c
	System.Int32 get_Count(); // 0x062a81e8
	System.Void set_Count(System.Int32 value); // 0x062a824c
	System.Boolean get_IsFree(); // 0x062a82c4
	System.Void set_IsFree(System.Boolean value); // 0x062a8328
	static WizardGames.Soc.SocClient.Ui.UiMallBuy.SubResInfo CreateBundleRes(System.Int32 resId, System.Int32 sellGoodd, System.Int32 price, System.Boolean isOwned, System.Int32 count); // 0x062a83a4
	static WizardGames.Soc.SocClient.Ui.UiMallBuy.SubResInfo CreateMallPackRes(System.Int32 resId, System.Int32 count, System.Boolean isFree); // 0x062a8648
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMallBuy.<>c__DisplayClass50_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiMallBuy <>4__this; // 0x10
	System.Int32 index; // 0x18
	WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg; // 0x20
	WizardGames.Soc.SocClient.Ui.UiMallBuy.SubResInfo resInfo; // 0x28
	System.Void .ctor(); // 0x062a88c4
	System.Void <ResItemRenderer>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x062a892c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMallBuy.<>c__DisplayClass74_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiMallBuy <>4__this; // 0x10
	WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg; // 0x18
	WizardGames.Soc.Common.Data.resource.ENUMSkinType skinType; // 0x20
	System.Void .ctor(); // 0x062a89e0
	System.Void <RefreshResShow>b__0(UnityEngine.GameObject objModel, UnityEngine.GameObject objBg); // 0x062a8a48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMallHelper : System.Object
{
	
	static System.Boolean SetBundleDetailInfo(WizardGames.Soc.Common.Data.mall.OBJBundle bundle, WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.ComDetailBinder detailBinder, WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.BtnBuyBinder buyBtnBinder, System.String bundleDesc); // 0x062a8b10
	static System.Boolean TryAutoPlayInnerVideo(WizardGames.Soc.SocClient.Ui.ComMallBg comBg, System.String kv, System.String innerVideoUrl); // 0x062a9908
	static System.Boolean TryPlayFullScreenVideo(System.String fullScreenVideoUrl, System.Boolean checkTips, System.Action onVideoFinished, System.Action onVideoPrepareCompleted); // 0x062a9a0c
	static System.Boolean CanAutoPlayFullScreenVideo(System.String fullScreenVideoUrl); // 0x062a9b4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMallPayConfirm : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.RootMallPayConfirmBinder rootBinder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComStepper comStepper; // 0x340
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiMallPayConfirm.ResInfo> allResList; // 0x348
	UnityEngine.Vector3Int curCurrency; // 0x350
	UnityEngine.Vector3Int secondCurCurrency; // 0x35c
	UnityEngine.Vector2Int curBuyBundleInfo; // 0x368
	UnityEngine.Vector2Int curBuyMallInfo; // 0x370
	UnityEngine.Vector3Int curFragmentMallInfo; // 0x378
	System.Int32 lotteryID; // 0x384
	System.Void OnInit(); // 0x062a9c44
	System.Void OnDisable(); // 0x062aa1cc
	System.Void ItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x062aa234
	System.Int32 GetMallItemBuyCount(); // 0x062aa5a4
	System.Int32 GetFragmentMallCount(); // 0x062aa670
	System.Void OnBuyBtnClick(); // 0x055049cc
	System.Void ShowMallItemRewards(System.Int32 shopId, System.Int32 num); // 0x062aaec4
	System.Void SetPriceInfo(System.Single num); // 0x05513724
	System.Void SetPriceInfo(WizardGames.Soc.Common.Data.resource.OBJGenaral currency, System.Int32 num, WizardGames.Soc.Common.Data.resource.OBJGenaral currency2, System.Int32 num2); // 0x062abbfc
	System.Void SetData(WizardGames.Soc.Common.Data.mall.OBJBundle bundle, System.Int32 sellGoodId); // 0x062ac774
	System.Void SetData(WizardGames.Soc.SocClient.MallItemAdapter adapter, System.Int32 tarNum, System.Int32 lotteryID); // 0x062ad008
	System.Void SetData(WizardGames.Soc.Common.Data.mall.OBJLotteryExchangeRewards item, System.Int32 tarNum); // 0x062ae010
	System.Void UpdateMallItemPrice(WizardGames.Soc.SocClient.MallItemAdapter adapter); // 0x062adb78
	System.Void UpdateFragmentItemPrice(WizardGames.Soc.Common.Data.mall.OBJLotteryExchangeRewards mallItem); // 0x062ae574
	System.Void OnStepperValueChanged(System.Int32 value); // 0x062ae6c0
	System.Void .ctor(); // 0x062ae8a4
	System.Void <OnInit>b__10_0(); // 0x062aea84
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiMallPayConfirm.ResInfo : System.ValueType
{
	System.Int32 ResId; // 0x10
	System.Int32 ResNum; // 0x14
	System.Boolean IsFree; // 0x18
	System.Void .ctor(System.Int32 resId, System.Int32 resNum, System.Boolean isFree); // 0x062ab7c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMallPayConfirm.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiMallPayConfirm.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SDK.MidasWrapper.EPayResult,System.String> <>9__15_4; // 0x8
	static System.Void .cctor(); // 0x062aeaf0
	System.Void .ctor(); // 0x062aeb54
	System.Void <OnBuyBtnClick>b__15_4(WizardGames.Soc.SDK.MidasWrapper.EPayResult result, System.String msg); // 0x062aebbc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMallPayConfirm.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.SocClient.MallItemAdapter adapter; // 0x10
	WizardGames.Soc.SocClient.Ui.UiMallPayConfirm <>4__this; // 0x18
	System.Int32 num; // 0x20
	System.Int32 shopId; // 0x24
	System.Action<WizardGames.Soc.SDK.MidasWrapper.EPayResult,System.String> <>9__3; // 0x28
	System.Void .ctor(); // 0x062aae5c
	System.Void <OnBuyBtnClick>b__0(System.String urlParams); // 0x05523a54
	System.Void <OnBuyBtnClick>b__3(WizardGames.Soc.SDK.MidasWrapper.EPayResult result, System.String msg); // 0x0550f6d4
	System.Void <OnBuyBtnClick>b__1(); // 0x055049cc
	System.Void <OnBuyBtnClick>b__2(System.String urlParams); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMallSpecial : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.UiMallSpeicalBinder uiBinder; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.RootMallSpecialBinder rootBinder; // 0x340
	WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.RootMallContent_ShopPageSpecialBinder contentBinder; // 0x348
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x350
	System.Int32 lotteryId; // 0x358
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiMallSpecial.RewardLisData> rewards; // 0x360
	System.Void OnInit(); // 0x062af124
	System.Void OnRefreshData(System.Int32 lotteryID); // 0x062af47c
	System.Void OnEnable(); // 0x062afe88
	System.Void OnDisable(); // 0x062affa0
	System.Void SetData(System.Int32 lotteryID); // 0x062af9d0
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject gObject); // 0x062b0120
	System.Void RefreshCurrency(); // 0x062af500
	static System.Void ShowFragmentShop(System.Int32 lotteryID); // 0x062b02c0
	System.Void .ctor(); // 0x062b0474
	System.Void <OnInit>b__9_0(FairyGUI.EventContext ctx); // 0x062b054c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMallSpecial.RewardLisData : System.Object
{
	WizardGames.Soc.Common.Data.mall.OBJLotteryExchangeRewards Data1; // 0x10
	WizardGames.Soc.Common.Data.mall.OBJLotteryExchangeRewards Data2; // 0x18
	System.Boolean isBig; // 0x20
	System.Void .ctor(); // 0x062b00b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMallSpecial.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiMallSpecial.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__15_2; // 0x8
	static System.Void .cctor(); // 0x062b05cc
	System.Void .ctor(); // 0x062b0630
	System.Void <RefreshCurrency>b__15_2(); // 0x062b0698
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMallSpecial.<>c__DisplayClass15_0 : System.Object
{
	System.Int32 costResourceID; // 0x10
	WizardGames.Soc.SocClient.Ui.UiMallSpecial <>4__this; // 0x18
	WizardGames.Soc.Common.Data.resource.OBJGenaral costConfig; // 0x20
	System.Void .ctor(); // 0x062b0258
	System.String <RefreshCurrency>b__0(); // 0x062b0720
	System.Void <RefreshCurrency>b__1(); // 0x062b07e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMallSpecial.<>c__DisplayClass16_0 : System.Object
{
	System.Int32 lotteryID; // 0x10
	System.Void .ctor(); // 0x062b040c
	System.Void <ShowFragmentShop>b__0(WizardGames.Soc.SocClient.Ui.UiMallSpecial win); // 0x062b0960
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiManger : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameManger.UiMangerBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x340
	FairyGUI.Controller BtnQuickStateController; // 0x348
	WizardGames.Soc.SocClient.Ui.ComLazyLoader loaderDropArea; // 0x350
	System.Boolean initData; // 0x358
	WizardGames.Soc.SocClient.Ui.UiMangerContainer mangerContainer; // 0x360
	WizardGames.Soc.Common.CustomType.ItemContainerNode mangerItemContainer; // 0x368
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.InventoryUIInfo> dataList; // 0x370
	System.Boolean needCloseQuickLootWhenLootOver; // 0x378
	System.Boolean finishLootWhenAck; // 0x379
	WizardGames.Soc.SocClient.Ui.ComItemIcon curChooseIcon; // 0x380
	System.Void OnInit(); // 0x062b09e4
	System.Void OnClickAllQuickLoot(); // 0x062b167c
	System.Void DoAllQuickLoot(); // 0x062b18b8
	System.Void OnEnable(); // 0x062b1b4c
	System.Void OnDisable(); // 0x062b23f0
	System.Void OnQuickLootStateChanged(System.Boolean state); // 0x062b2930
	System.Void OnQuickLootFinished(); // 0x062b29ac
	System.Void SetQickLootState(System.Boolean state); // 0x062b2a20
	System.Void OnQuickPutOneFinished(System.Int64 uid); // 0x062b2ae0
	System.Void OnQuickLootBagFull(); // 0x062b2b54
	System.Void OnFps30Update(System.Single dt); // 0x062b2bb4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x062b2e1c
	System.Void CloseWindow(); // 0x062b2e94
	System.Void OnItemNodeUpdate(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x062b2f4c
	System.Void BindeData(); // 0x062b2080
	System.Void Refresh(); // 0x062b2374
	System.Void InitData(); // 0x062b20e0
	System.Void RefreshBag(); // 0x062b21b8
	System.Void RefreshBagList(); // 0x062b2fc4
	System.Void MainInventoryData(); // 0x062b33cc
	System.Void BagRenderList(System.Int32 index, FairyGUI.GObject obj); // 0x062b3974
	System.Void DealIconWhenCollect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x062b3b5c
	System.Void OnClickItemIcon(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x062b3e30
	System.Void UnChooseAllIcons(); // 0x062b3338
	System.Void OnShowAreaEvent(WizardGames.Soc.SocClient.Ui.ComItemIcon icon, System.Int32 ammount); // 0x062b44b8
	System.Void OnItemDragStart(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x062b45c4
	System.Void OnItemDragEnd(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem, System.Boolean isDragValid); // 0x062b4638
	static System.Void OpenWindow(System.Int64 collectionID); // 0x062b4790
	System.Void .ctor(); // 0x062b49fc
	static System.Void .cctor(); // 0x062b4ad4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiManger.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiManger.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__11_0; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> <>9__13_0; // 0x10
	static System.Action<WizardGames.Soc.SocClient.Ui.ComBaseIcon,System.Boolean> <>9__32_0; // 0x18
	static System.Action<System.Boolean> <>9__39_0; // 0x20
	static System.Void .cctor(); // 0x062b4ba8
	System.Void .ctor(); // 0x062b4c0c
	System.Void <OnInit>b__11_0(); // 0x062b4c74
	System.Void <DoAllQuickLoot>b__13_0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x062b4cfc
	System.Void <DealIconWhenCollect>b__32_0(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, System.Boolean state); // 0x062b4e60
	System.Void <OpenWindow>b__39_0(System.Boolean res); // 0x062b5070
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiManger.<>c__DisplayClass32_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	System.Void .ctor(); // 0x062b3dc8
	System.Void <DealIconWhenCollect>b__1(FairyGUI.EventContext ctx); // 0x062b5170
	System.Void <DealIconWhenCollect>b__2(FairyGUI.EventContext ctx); // 0x062b5670
	System.Boolean <DealIconWhenCollect>b__3(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x062b56f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMangerContainer : WizardGames.Soc.SocClient.Ui.ClientContainerFixed
{
	System.Collections.Generic.List<FairyGUI.GComponent> decomposeIcons; // 0x78
	WizardGames.Soc.SocClient.Ui.EConversionContainerType containerType; // 0x80
	System.Void Bind(FairyGUI.GList iconList); // 0x062b1568
	System.Void BindItemContainer(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container); // 0x062b3120
	System.Void CollectIcons(); // 0x062b57d0
	System.Void DealIconWhenCollect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x062b5a64
	System.Void SetItemDatas(); // 0x062b5c94
	System.Boolean OnIconAcceptDrag(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x062b609c
	System.Void .ctor(); // 0x062b14b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMangerContainer.<>c__DisplayClass5_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	System.Void .ctor(); // 0x062b5c2c
	System.Void <DealIconWhenCollect>b__0(FairyGUI.EventContext ctx); // 0x062b62e0
	System.Void <DealIconWhenCollect>b__1(FairyGUI.EventContext ctx); // 0x062b67e0
	System.Boolean <DealIconWhenCollect>b__2(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x062b6868
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyMap : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Map.LobbyMap mainMap; // 0x338
	WizardGames.Soc.Common.Data.Play.OBJLobbyMap mapCfg; // 0x340
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x348
	System.Void OnInit(); // 0x062b6940
	System.Void SetMapData(WizardGames.Soc.Common.Data.Play.OBJLobbyMap data); // 0x062b6bf4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x062b6c74
	System.Void OnEnable(); // 0x062b6cf4
	System.Void OnDisable(); // 0x062b6d60
	System.Void OnDestroy(); // 0x062b6dcc
	static WizardGames.Soc.SocClient.Ui.UiLobbyMap OpenLobbyMap(WizardGames.Soc.Common.Data.Play.OBJLobbyMap data); // 0x062b6e54
	System.Void .ctor(); // 0x062b6fd4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMainMap : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update, WizardGames.Soc.Common.Unity.Ui.IUiTriggerGuide
{
	WizardGames.Soc.SocClient.Ui.Map.MainMap mainMap; // 0x338
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x340
	System.Collections.Generic.List<System.Int32> hotKeyIds; // 0x348
	System.Int64 currentGuideMonumentId; // 0x350
	System.Void OnInit(); // 0x062b7060
	System.Void AddCommonResetKeyPC(); // 0x062b7390
	System.Void KeyMapSizerKeyRebinging(); // 0x062b7a38
	System.Void OnEnable(); // 0x062b7af4
	System.Void OnDisable(); // 0x062b7bac
	System.Void OnDestroy(); // 0x062b7c64
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x062b7d84
	System.Void OnFps30Update(System.Single dt); // 0x062b7e28
	System.Void OnFps1Update(System.Single dt); // 0x062b7ecc
	System.Void JumpToMission(System.Int32 missionId); // 0x062b7f70
	System.Void SelectMarker(System.Int64 markerId); // 0x062b8004
	System.Void JumpToSDJTab(System.Int32 pageIndex); // 0x062b80ac
	static System.Void OpenAndJumpToSDJTab(System.Int32 pageIndex); // 0x062b8134
	static System.Void OpenAndJumpToReputationTerritory(); // 0x062b8238
	System.Int64 get_CurrentGuideMonumentId(); // 0x062b870c
	System.Void set_CurrentGuideMonumentId(System.Int64 value); // 0x062b8770
	System.Boolean TriggerGuide(); // 0x062b87e8
	FairyGUI.GObject GetGuideObjByIDArray(System.Collections.Generic.List<System.Int64> idArray); // 0x062b8e90
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x062b8f54
	WizardGames.Soc.SocClient.Marker.MonumentMarker GetNearestMonumentMarkerByCfgId(System.Collections.Generic.List<System.Int64> cfgIdArray); // 0x062b8b48
	System.Void SortedSiteList(System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.GMarkerBase> markers); // 0x062b9160
	System.Void OnSidePanelSubviewCreated(); // 0x062b934c
	System.Void .ctor(); // 0x062b93b0
	System.Void <AddCommonResetKeyPC>b__6_0(FairyGUI.EventContext a); // 0x062b9488
	System.Void <AddCommonResetKeyPC>b__6_1(FairyGUI.EventContext _); // 0x062b9500
	System.Void <AddCommonResetKeyPC>b__6_2(FairyGUI.EventContext _); // 0x062b95d0
	System.Void <AddCommonResetKeyPC>b__6_3(FairyGUI.EventContext _); // 0x062b96a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMainMap.<>c__DisplayClass27_0 : System.Object
{
	UnityEngine.Vector3 myPos; // 0x10
	System.Void .ctor(); // 0x062b92e4
	System.Int32 <SortedSiteList>b__0(WizardGames.Soc.SocClient.Marker.GMarkerBase a, WizardGames.Soc.SocClient.Marker.GMarkerBase b); // 0x062b9770
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRadar : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.GameMainMap.RadarviewBinder binder; // 0x338
	FairyGUI.Transition radarAni; // 0x340
	System.Void OnInit(); // 0x062b99e4
	System.Void AnimationComplete(); // 0x062b9d7c
	System.Void OnStartClick(); // 0x062b9e30
	System.Void OnEnable(); // 0x062b9fbc
	System.Void OnDisable(); // 0x062ba09c
	static System.Void OpenWindow(); // 0x062ba160
	System.Void .ctor(); // 0x062ba230
	System.Void <OnInit>b__2_0(); // 0x062ba2bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMainObMap : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	WizardGames.Soc.SocClient.Ui.Map.MainObMap mainMap; // 0x338
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x340
	System.Collections.Generic.List<System.Int32> hotKeyIds; // 0x348
	System.Void OnInit(); // 0x062ba330
	System.Void AddCommonResetKeyPC(); // 0x062ba5e4
	System.Void OpenUiGameOBPlayerListPanel(); // 0x062baa98
	System.Void OnEnable(); // 0x062babe4
	System.Void OnDisable(); // 0x062bac60
	System.Void OnDestroy(); // 0x062bae98
	System.Void CloseUnnecessaryPanel(); // 0x062bad18
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x062baf28
	System.Void OnFps30Update(System.Single dt); // 0x062bafcc
	System.Void OnFps1Update(System.Single dt); // 0x062bb070
	System.Void .ctor(); // 0x062bb114
	System.Void <AddCommonResetKeyPC>b__4_2(FairyGUI.EventContext _); // 0x062bb1ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMainObMap.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiMainObMap.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__4_0; // 0x8
	static FairyGUI.EventCallback1 <>9__4_1; // 0x10
	static System.Void .cctor(); // 0x062bb264
	System.Void .ctor(); // 0x062bb2c8
	System.Void <AddCommonResetKeyPC>b__4_0(FairyGUI.EventContext _); // 0x062bb330
	System.Void <AddCommonResetKeyPC>b__4_1(FairyGUI.EventContext _); // 0x062bb3a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMarquee : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps2Update, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	FairyGUI.GComponent comMarquee; // 0x338
	FairyGUI.GTextField title; // 0x340
	FairyGUI.Transition transition; // 0x348
	WizardGames.Soc.SocClient.Manager.MarqueeData curData; // 0x350
	System.Single speed; // 0x358
	System.Void OnInit(); // 0x062bb418
	static System.Void Open(); // 0x062bb5d0
	System.Void OnFps2Update(System.Single dt); // 0x062bb9b0
	System.Void RefreshMarquee(); // 0x062bb864
	System.Void StartMarqueeDisplay(); // 0x062bba28
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x062bbc14
	System.Void OnDestroy(); // 0x062bbe48
	System.Void .ctor(); // 0x062bbeb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMarquee.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiMarquee.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMarquee> <>9__6_0; // 0x8
	static System.Void .cctor(); // 0x062bbf48
	System.Void .ctor(); // 0x062bbfac
	System.Void <Open>b__6_0(WizardGames.Soc.SocClient.Ui.UiMarquee win); // 0x062bc014
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMemory : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	static SocLogger Log; // 0x0
	FairyGUI.GList categoryList; // 0x338
	FairyGUI.GButton recordBtn; // 0x340
	FairyGUI.GButton callGcBtn; // 0x348
	FairyGUI.GGroup diffGroup; // 0x350
	FairyGUI.GTextField diffText; // 0x358
	FairyGUI.Controller recordBtnController; // 0x360
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiMemory.UiMemoryProfiler> profilers; // 0x368
	System.Boolean isRecord; // 0x370
	System.Single recordSystemTotalMemory; // 0x374
	WizardGames.Soc.SocClient.Ui.UiMemory.UiMemoryProfiler systemUsedMemoryProfiler; // 0x378
	FairyGUI.GComponent panelRoot; // 0x380
	System.Void OnInit(); // 0x062bc094
	System.Void OnEnable(); // 0x062bc3e4
	System.Void OnDisable(); // 0x062bcd60
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x062bd034
	System.Void OnFps1Update(System.Single dt); // 0x062bd2cc
	System.Void OnRecordBtnClick(); // 0x062bd984
	System.Void OnCallGcBtnClick(); // 0x062bdc5c
	System.Void .ctor(); // 0x062bdce4
	static System.Void .cctor(); // 0x062bdd70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMemory.UiMemoryProfiler : System.Object
{
	Unity.Profiling.ProfilerRecorder recorder; // 0x10
	System.Single sumValue; // 0x18
	System.Int32 counter; // 0x1c
	System.String <Name>k__BackingField; // 0x20
	System.String get_Name(); // 0x062bde44
	System.Void set_Name(System.String value); // 0x062bdea8
	System.Single get_AverageValue(); // 0x062bd8a0
	System.Void .ctor(System.String name, Unity.Profiling.ProfilerRecorder recorder); // 0x062bcc7c
	System.Void Collect(); // 0x062bd1b4
	System.Void ResetCounter(); // 0x062bd920
	System.Void Dispose(); // 0x062bcf54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMemory.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiMemory.<>c <>9; // 0x0
	static System.Predicate<WizardGames.Soc.SocClient.Ui.UiMemory.UiMemoryProfiler> <>9__33_0; // 0x8
	static System.Void .cctor(); // 0x062bdf28
	System.Void .ctor(); // 0x062bdf8c
	System.Boolean <OnEnable>b__33_0(WizardGames.Soc.SocClient.Ui.UiMemory.UiMemoryProfiler p); // 0x062bdff4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MissionPageFactory : System.Object
{
	
	static WizardGames.Soc.SocClient.Ui.UiMissionBasePage CreateInstance(WizardGames.Soc.Common.Data.MissionTabType page); // 0x062be0d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionBasePage : System.Object
{
	
	System.Void Init(FairyGUI.GComponent com); // 0x062be5d8
	System.Void OnInit(FairyGUI.GComponent com); // 0x062be648
	System.Void Enable(); // 0x062be6bc
	System.Void OnEnable(); // 0x062be71c
	System.Void Update(); // 0x062be77c
	System.Void OnUpdate(); // 0x062be7dc
	System.Void Disable(); // 0x062be83c
	System.Void OnDisable(); // 0x062be89c
	System.Void Dispose(); // 0x062be8fc
	System.Void OnDispose(); // 0x062be95c
	System.Void .ctor(); // 0x062be570
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionBoxPage : WizardGames.Soc.SocClient.Ui.UiMissionBasePage
{
	static SocLogger logger; // 0x0
	FairyGUI.GComponent root; // 0x10
	FairyGUI.GList taskLst; // 0x18
	System.Int32 curSelectIndex; // 0x20
	FairyGUI.Controller trackBtnCtrl; // 0x28
	FairyGUI.Controller bottomCtrl; // 0x30
	FairyGUI.Controller hasTaskCtrl; // 0x38
	FairyGUI.GObject downArrow; // 0x40
	System.Void OnInit(FairyGUI.GComponent com); // 0x062be9bc
	System.Void OnEnable(); // 0x062bf308
	System.Void OnDisable(); // 0x062bf3c4
	System.Void OnDispose(); // 0x062bf46c
	System.Void OnScrollBarScroll(); // 0x062bf6c8
	System.Void OnUpdate(); // 0x062bf7a0
	System.Void OnRenderSubTask(System.Int32 index, FairyGUI.GObject obj); // 0x062bf804
	System.Void OnClickClaim(System.Int32 index); // 0x062c043c
	System.Void OnClickItem(FairyGUI.EventContext context); // 0x062c054c
	System.Void OnClickTrack(FairyGUI.EventContext context); // 0x062c0a24
	System.Void RenderListRewardItem(System.Int32 rewardIndex, FairyGUI.GObject obj, System.Int32[] rewards); // 0x062c0ca0
	System.Void RefreshUI(); // 0x062befc0
	System.Void RefreshBottom(); // 0x062c0804
	System.Boolean Tracking(System.Int32 taskid); // 0x062c0368
	System.Int32 get_CurrentTaskID(); // 0x062c0b70
	System.Void .ctor(); // 0x062be504
	static System.Void .cctor(); // 0x062c0fac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionBoxPage.<>c__DisplayClass14_0 : System.Object
{
	System.Int32 curTaskId; // 0x10
	WizardGames.Soc.SocClient.Ui.UiMissionBoxPage <>4__this; // 0x18
	System.Int32[] taskRewardID; // 0x20
	System.Int32 index; // 0x28
	System.Void .ctor(); // 0x062c0300
	System.Boolean <OnRenderSubTask>b__0(WizardGames.Soc.Common.Data.Play.QuestPhase taskData); // 0x062c1080
	System.Void <OnRenderSubTask>b__1(System.Int32 rewardIndex, FairyGUI.GObject obj); // 0x062c110c
	System.Void <OnRenderSubTask>g__clickClaim|2(FairyGUI.EventContext context); // 0x062c11a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionMonumentPage : WizardGames.Soc.SocClient.Ui.UiMissionBasePage
{
	FairyGUI.GButton trackBtn; // 0x10
	FairyGUI.GTextField titleTxt; // 0x18
	FairyGUI.GList taskLst; // 0x20
	FairyGUI.Controller trackBtnCtrl; // 0x28
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,System.Object>> subTaskGODic; // 0x30
	System.Collections.Generic.List<System.Int32> monumentDataLst; // 0x38
	FairyGUI.GObject disText; // 0x40
	FairyGUI.Controller stateCtrl; // 0x48
	FairyGUI.GButton detailBtn; // 0x50
	FairyGUI.GButton backBtn; // 0x58
	FairyGUI.GButton confirmBtn; // 0x60
	System.Int32 curMonumentTypeId; // 0x68
	System.Void OnInit(FairyGUI.GComponent com); // 0x062c1224
	System.Void OnEnable(); // 0x062c182c
	System.Void OnDispose(); // 0x062c1e88
	System.Void OnClickTrack(); // 0x062c2030
	System.Void UpdateMission(); // 0x062c22a8
	System.Void OnRenderSubTask(System.Int32 index, FairyGUI.GObject obj); // 0x062c2438
	System.Void UpdateMonumentId(); // 0x062c19dc
	System.Void OnUpdate(); // 0x062c32e8
	System.Void RefreshDis(); // 0x062c2df4
	System.Void OnClickTaskItem(FairyGUI.EventContext context); // 0x062c3354
	System.Void UpdateTrackId(); // 0x062c34f0
	System.Void OnClickDetail(); // 0x062c368c
	System.Void OnClickConfirm(); // 0x062c3708
	System.Void .ctor(); // 0x062be390
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionNewBiePage : WizardGames.Soc.SocClient.Ui.UiMissionBasePage
{
	FairyGUI.GButton trackBtn; // 0x10
	FairyGUI.GTextField titleTxt; // 0x18
	FairyGUI.GTextField progressTxt; // 0x20
	FairyGUI.GList taskLst; // 0x28
	FairyGUI.GList rewardLst; // 0x30
	FairyGUI.Controller trackBtnCtrl; // 0x38
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> subTaskGODic; // 0x40
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> rewardGODic; // 0x48
	System.Collections.Generic.List<System.Int64> taskLstData; // 0x50
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Reward> rewardsData; // 0x58
	System.Collections.Generic.Dictionary<System.Int64,FairyGUI.GObject> distanceDic; // 0x60
	FairyGUI.Controller stateCtrl; // 0x68
	FairyGUI.GGroup trackTipsGroup; // 0x70
	System.Void OnInit(FairyGUI.GComponent com); // 0x062c3784
	System.Void OnEnable(); // 0x062c3c60
	System.Void OnDispose(); // 0x062c4330
	System.Void OnClickTrack(); // 0x062c44d8
	System.Void UpdateMission(); // 0x062c3cec
	System.Void UpdateMissionCount(); // 0x062c4c68
	System.Void UpdateTrackId(); // 0x062c4ccc
	System.Void OnRenderSubTask(System.Int32 index, FairyGUI.GObject obj); // 0x062c4d30
	System.Void OnRenderReward(System.Int32 index, FairyGUI.GObject obj); // 0x062c5658
	System.Void OnUpdate(); // 0x062c5a50
	System.Void RefreshDistance(); // 0x062c4724
	System.Void .ctor(); // 0x062be258
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionPointPage : WizardGames.Soc.SocClient.Ui.UiMissionBasePage
{
	static SocLogger logger; // 0x0
	FairyGUI.GComponent root; // 0x10
	FairyGUI.GList taskLst; // 0x18
	WizardGames.Soc.SocClient.Ui.UiMissionSelectPointTask uiSelectTask; // 0x20
	FairyGUI.Controller bottomController; // 0x28
	FairyGUI.GTextField txtDaily; // 0x30
	FairyGUI.GTextField txtDailyReset; // 0x38
	System.Void OnInit(FairyGUI.GComponent com); // 0x062c5abc
	System.Void InitTaskList(); // 0x062c5f9c
	System.Void OnEnable(); // 0x062c690c
	System.Void OnDispose(); // 0x062c6978
	System.Void OnUpdate(); // 0x062c6b30
	System.Void UpdateCD(); // 0x062c6b9c
	System.Void OnRenderSubTask(System.Int32 index, FairyGUI.GObject obj); // 0x062c6bfc
	System.Void OnClickSelectTask(System.Int32 index); // 0x062c76bc
	System.Void OnClickRefresh(System.Int32 index); // 0x062c77d4
	System.Void OnClickChange(System.Int32 index); // 0x062c7a38
	System.Void OnClickClaim(System.Int32 index); // 0x062c7abc
	System.Void OnClickTrack(System.Int32 index); // 0x062c7cf0
	System.Void OnClickRandomTask(FairyGUI.EventContext context); // 0x062c7eac
	System.Void RenderListRewardItem(System.Int32 rewardIndex, FairyGUI.GObject obj, System.Int32[] rewards); // 0x062c7f20
	System.Void RefreshUI(); // 0x062c6614
	System.Void .ctor(); // 0x062be4a0
	static System.Void .cctor(); // 0x062c822c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionPointPage.<>c__DisplayClass15_0 : System.Object
{
	System.Int64 curTaskId; // 0x10
	WizardGames.Soc.SocClient.Ui.UiMissionPointPage <>4__this; // 0x18
	System.Int32[] taskRewardID; // 0x20
	System.Void .ctor(); // 0x062c7654
	System.Boolean <OnRenderSubTask>b__0(WizardGames.Soc.Common.Data.Play.QuestPhase taskData); // 0x062c8300
	System.Void <OnRenderSubTask>b__1(System.Int32 rewardIndex, FairyGUI.GObject obj); // 0x062c838c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionPointPage.<>c__DisplayClass17_0 : System.Object
{
	System.Int64 curTaskId; // 0x10
	System.Void .ctor(); // 0x062c79d0
	System.Boolean <OnClickRefresh>b__0(WizardGames.Soc.Common.Data.Play.IntergalTask taskData); // 0x062c8420
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionPointPage.<>c__DisplayClass9_0 : System.Object
{
	System.Int32 index; // 0x10
	WizardGames.Soc.SocClient.Ui.UiMissionPointPage <>4__this; // 0x18
	System.Void .ctor(); // 0x062c68a4
	System.Void <InitTaskList>b__0(FairyGUI.EventContext context); // 0x062c84ac
	System.Void <InitTaskList>b__1(FairyGUI.EventContext context); // 0x062c8530
	System.Void <InitTaskList>b__2(FairyGUI.EventContext context); // 0x062c85b4
	System.Void <InitTaskList>b__3(FairyGUI.EventContext context); // 0x062c8638
	System.Void <InitTaskList>b__4(FairyGUI.EventContext context); // 0x062c86bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionSelectPointTask : System.Object
{
	FairyGUI.GComponent rootNode; // 0x10
	FairyGUI.GButton simpleBtn; // 0x18
	FairyGUI.GButton hardBtn; // 0x20
	FairyGUI.GList gList; // 0x28
	FairyGUI.Controller bottomController; // 0x30
	System.Int32 curSelectIndex; // 0x38
	System.Int32 curSlotIndex; // 0x3c
	static WizardGames.Soc.SocClient.Ui.UiMissionSelectPointTask Create(FairyGUI.GComponent root); // 0x062c5e80
	System.Void Init(FairyGUI.GComponent root); // 0x062c87b4
	System.Void OnClickItem(FairyGUI.EventContext context); // 0x062c8d30
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x062c9010
	System.Void OnClickSelectSimple(FairyGUI.EventContext context); // 0x062c925c
	System.Void OnClickSelectHard(FairyGUI.EventContext context); // 0x062c93a4
	System.Void OnClickClose(FairyGUI.EventContext context); // 0x062c94ec
	System.Void Show(System.Int32 slot); // 0x062c7740
	System.Void Hide(); // 0x062c5f1c
	System.Void RefreshUI(); // 0x062c8ee8
	System.Void OnDispose(); // 0x062c6ad0
	System.Void .ctor(); // 0x062c8740
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionTreasurePage : WizardGames.Soc.SocClient.Ui.UiMissionBasePage
{
	static SocLogger logger; // 0x0
	FairyGUI.GComponent root; // 0x10
	FairyGUI.Controller hasTask; // 0x18
	FairyGUI.GButton trackBtn; // 0x20
	FairyGUI.Controller trackBtnCtrl; // 0x28
	FairyGUI.GList taskLst; // 0x30
	System.Int64 selectId; // 0x38
	System.Collections.Generic.List<System.Int64> taskIds; // 0x40
	System.Void OnInit(FairyGUI.GComponent com); // 0x062ea1d4
	System.Void RefreshUI(); // 0x062ea57c
	System.Void SetBtnState(System.Int64 id); // 0x062ea770
	System.Void OnClickTrack(); // 0x062ea868
	System.Void OnEnable(); // 0x062ea984
	System.Void OnDisable(); // 0x062eaa44
	System.Void OnDispose(); // 0x062eaaac
	System.Void OnUpdate(); // 0x062eac50
	System.Void OnRenderSubTask(System.Int32 index, FairyGUI.GObject obj); // 0x062eacb8
	System.Void OnClickClaim(System.Int32 index); // 0x062eb82c
	System.Void .ctor(); // 0x062eb9c4
	static System.Void .cctor(); // 0x062eba78
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionTreasurePage.<>c__DisplayClass16_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiMissionTreasurePage <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x062eb7c4
	System.Void <OnRenderSubTask>g__clickClaim|0(FairyGUI.EventContext context); // 0x062ebb4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionView : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	static SocLogger Log; // 0x0
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.MissionTabType,WizardGames.Soc.SocClient.Ui.UiMissionBasePage> pageDic; // 0x338
	FairyGUI.Controller pageCtrl; // 0x340
	FairyGUI.GLoader blank; // 0x348
	WizardGames.Soc.Common.Data.MissionTabType lastPageType; // 0x350
	WizardGames.Soc.Common.Data.MissionTabType curTabPage; // 0x354
	System.Boolean isFirstSetPage; // 0x358
	FairyGUI.GButton closeBtn; // 0x360
	FairyGUI.GList tabList; // 0x368
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> tabGODic; // 0x370
	System.Collections.Generic.List<Assets.Scripts.UI.Window.UI.UiMission.MissionTabData> tabDataLst; // 0x378
	FairyGUI.GObject monumentTrackIcon; // 0x380
	FairyGUI.GObject newbieTrackIcon; // 0x388
	FairyGUI.GObject boxTrackIcon; // 0x390
	FairyGUI.GObject pointTrackIcon; // 0x398
	FairyGUI.GObject treasureTrackIcon; // 0x3a0
	FairyGUI.GObject actionExpansionTrackIcon; // 0x3a8
	System.Int32 lastSelectedTabIndex; // 0x3b0
	System.Void OnInit(); // 0x062ebbd0
	System.Void SetTabPage(WizardGames.Soc.Common.Data.MissionTabType type); // 0x062ed094
	System.Void OnDestroy(); // 0x062ed59c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x062ed968
	System.Void OnClickClose(); // 0x062ed9e0
	System.Void OnChangePage(); // 0x062edb40
	System.Void OnRenderTabItem(System.Int32 index, FairyGUI.GObject obj); // 0x062edc40
	System.Void OnClickTabItem(FairyGUI.EventContext context); // 0x062ee18c
	System.Void RefreshMissionTabs(); // 0x062ec940
	static System.Boolean PlayIdCheck(WizardGames.Soc.Common.Data.Play.MissionTab missionTabData); // 0x062ee42c
	System.Void UpdateTrackId(); // 0x062ee5d4
	System.Void OnFps1Update(System.Single dt); // 0x062ee664
	System.Void UpdateMonumentTrackState(); // 0x062ed164
	System.Void UpdateTrackState(); // 0x062ed240
	System.Void JumpToPage(WizardGames.Soc.Common.Data.MissionTabType missionType); // 0x062ee720
	static System.Void OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiMissionView> callBack); // 0x062ee80c
	static System.Void HideWindow(); // 0x062ee93c
	static System.Void CloseWindow(); // 0x062eda64
	System.Void OnListeningCloseWindow(WizardGames.Soc.SocClient.Ui.UiHudElem vector); // 0x062eea18
	System.Void OnHudRootCaptureTouchExcludeJoyStick(UnityEngine.Vector2 screen); // 0x062eea90
	System.Boolean CanShowActionExpansionBtn(); // 0x062ec704
	System.Void OnEnable(); // 0x062eeb0c
	System.Void .ctor(); // 0x062eebb8
	static System.Void .cctor(); // 0x062eed50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionView.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiMissionView.<>c <>9; // 0x0
	static System.Action <>9__19_1; // 0x8
	static FairyGUI.EventCallback0 <>9__19_0; // 0x10
	static System.Comparison<Assets.Scripts.UI.Window.UI.UiMission.MissionTabData> <>9__27_0; // 0x18
	static System.Void .cctor(); // 0x062eee24
	System.Void .ctor(); // 0x062eee88
	System.Void <OnInit>b__19_0(); // 0x062eeef0
	System.Void <OnInit>b__19_1(); // 0x062ef070
	System.Int32 <RefreshMissionTabs>b__27_0(Assets.Scripts.UI.Window.UI.UiMission.MissionTabData a, Assets.Scripts.UI.Window.UI.UiMission.MissionTabData b); // 0x062ef0f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionBook : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.UiMissionBookBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.MissionBookNavBar navBar; // 0x340
	FairyGUI.GList optionList; // 0x348
	FairyGUI.GList pageList; // 0x350
	WizardGames.Soc.SocClient.Ui.UiMissionBook.EBookTabType curTabType; // 0x358
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.UiMissionBook.EBookTabType,System.String> tabTitles; // 0x360
	System.Collections.Generic.List<UnityEngine.Vector2> rewardDataList; // 0x368
	System.Collections.Generic.List<WizardGames.Soc.SocClient.MainQuestData> curMissionList; // 0x370
	System.Collections.Generic.List<WizardGames.Soc.SocClient.MainQuestData> displayMissionList; // 0x378
	System.Int32 curFactionID; // 0x380
	System.Int32 lastFactionID; // 0x384
	System.Int32 curStage; // 0x388
	System.Int32 lastStage; // 0x38c
	System.Boolean factionCompelete; // 0x390
	System.Boolean isPlayingAnim; // 0x391
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ListItemPage_TrainInfo1Binder binder1; // 0x398
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ListItemPage_TrainInfo2Binder binder2; // 0x3a0
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ListItemPage_StageInfo1Binder storyPage1Binder; // 0x3a8
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ListItemPage_StageInfo2Binder storyPage2Binder; // 0x3b0
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ListItemStageBinder curStageBinder; // 0x3b8
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ListItemStageBinder nextStageBinder; // 0x3c0
	WizardGames.Soc.Common.Data.Play.StoryStageStage curStageCfg; // 0x3c8
	WizardGames.Soc.Common.Data.Play.StoryStageStage nextStageCfg; // 0x3d0
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ListItemPage_TaskInfoBinder basicBinder; // 0x3d8
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ListItemPage_TaskInfoBinder advancedBinder; // 0x3e0
	System.Int64 curSurvivalMissionId; // 0x3e8
	System.Int64 listAnimStartId; // 0x3f0
	System.Int64 listAnimEndId; // 0x3f8
	WizardGames.Soc.SocClient.Ui.UiMissionBook.ESurvivalState curSurvivalState; // 0x400
	System.Void OnInit(); // 0x062ef1b8
	System.Void OnEnable(); // 0x062efc6c
	System.Void OnDisable(); // 0x062efcd4
	System.Void OnShowAnimFinish(); // 0x062efd48
	System.Void RefreshFactionComOption(); // 0x062f06c0
	System.Void OnClickReward(FairyGUI.EventContext context); // 0x062f0b74
	System.Void OnClickMore(FairyGUI.EventContext context); // 0x062f0c34
	System.Void OnRenderItem(System.Int32 index, FairyGUI.GObject item); // 0x062f0f00
	System.String ItemProvider(System.Int32 index); // 0x062f2f54
	System.Void SetData(WizardGames.Soc.SocClient.Ui.UiMissionBook.EBookTabType tabType, System.Int32 factionId); // 0x062f3220
	System.Void SetData(WizardGames.Soc.SocClient.Ui.UiMissionBook.EBookTabType tabType); // 0x062f3c7c
	System.Void RefreshPage(); // 0x062f39a0
	System.Boolean CheckRefreshPage(); // 0x062f3cf8
	System.Void RefreshTabs(); // 0x062ef804
	static WizardGames.Soc.SocClient.Ui.UiMissionBook OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiMissionBook> cb); // 0x062f3f34
	static System.Void CloseWindow(); // 0x062f0e68
	static WizardGames.Soc.SocClient.Ui.UiMissionBook GetWindow(); // 0x062f409c
	System.Void SetFactionData(System.Int32 factionId); // 0x062f32b0
	System.Void SetRewardDataList(); // 0x062f415c
	System.Void OnFactionRenderItem(System.Int32 index, FairyGUI.GObject item); // 0x062f1c14
	System.String OnFactionItemProvider(System.Int32 index); // 0x062f30b8
	System.Void OnRewardItemRender(System.Int32 index, FairyGUI.GObject gObj); // 0x062f47e8
	System.Void OnTaskListItemRender(System.Int32 index, FairyGUI.GObject gObj); // 0x062f4a9c
	System.Void OnCheckFactionStageChange(); // 0x062efef4
	System.Void RefreshTaskListItem(); // 0x062f5384
	System.Void CompeleteOneFaction(WizardGames.Soc.SocClient.Ui.Binder.GameStory.ListItemPage_TrainInfo2Binder pageBinder); // 0x062f55d4
	System.Void CompeleteOneStage(WizardGames.Soc.SocClient.Ui.Binder.GameStory.ListItemPage_TrainInfo2Binder pageBinder); // 0x062f54a0
	System.Collections.IEnumerator IEPlayTransitionsSequentially(); // 0x062f5708
	System.Collections.IEnumerator IECompeleteOneFaction(WizardGames.Soc.SocClient.Ui.Binder.GameStory.ListItemPage_TrainInfo2Binder pageBinder); // 0x062f57ac
	System.Collections.IEnumerator IECompeleteOneStage(WizardGames.Soc.SocClient.Ui.Binder.GameStory.ListItemPage_TrainInfo2Binder pageBinder); // 0x062f5874
	System.Collections.IEnumerator IEPlayTransitionsSequentially(FairyGUI.GList list); // 0x062f5ac8
	System.Void CacheFactionMissionData(); // 0x062f4dc4
	System.Void OnRenderStoryPageItem(System.Int32 index, FairyGUI.GObject item); // 0x062f2654
	System.Void OnRenderStageTagItem(System.Int32 index, FairyGUI.GObject item); // 0x062f5c04
	System.Void OnRenderNextStageTagItem(System.Int32 index, FairyGUI.GObject item); // 0x062f5ea4
	System.Void TagItemRender(WizardGames.Soc.Common.Data.Play.StoryStageDescription cfg, FairyGUI.GObject item); // 0x062f5d6c
	System.String StoryItemProvider(System.Int32 index); // 0x062f316c
	System.Void OnRenderSurvivalPageItem(System.Int32 index, FairyGUI.GObject item); // 0x062f0fe8
	System.Void OnRenderSurvivalBasicListItem(System.Int32 index, FairyGUI.GObject item); // 0x062f62fc
	System.Void OnRenderSurvivalAdvancedListItem(System.Int32 index, FairyGUI.GObject item); // 0x062f6b50
	System.String SurvivalItemProvider(System.Int32 index); // 0x062f302c
	System.Boolean IsPageFinished(System.Int32 idx); // 0x062f600c
	System.Void PlaySurvivalAnim(); // 0x062f74b4
	System.Void TryPlayListAnim(System.Action finishCb); // 0x062f80ac
	System.Collections.IEnumerator IEPlaySurvivalTransitionsSequentially(System.Action finishCb); // 0x062f8464
	System.Boolean get_hasPreState(); // 0x062f83e4
	System.Void SetData(WizardGames.Soc.SocClient.Ui.UiMissionBook.ESurvivalState survivalState); // 0x062f85b0
	System.Void .ctor(); // 0x062f8638
	static System.Void .cctor(); // 0x062f87e0
	System.Void <OnInit>b__7_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x062f88b4
	System.Void <OnInit>b__7_1(); // 0x062f8cbc
	System.Void <OnClickReward>b__12_0(WizardGames.Soc.SocClient.Ui.UiMainQuestDetail win); // 0x062f8d38
	System.Void <OnClickMore>b__13_0(WizardGames.Soc.Common.Unity.Ui.WindowComBase base); // 0x062f8de8
	System.Void <OnCheckFactionStageChange>b__42_0(); // 0x062f8ebc
	System.Void <OnCheckFactionStageChange>b__42_1(); // 0x062f8f40
	System.Void <PlaySurvivalAnim>b__73_0(); // 0x062f903c
	System.Void <PlaySurvivalAnim>b__73_1(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x062fa210
	System.Void <PlaySurvivalAnim>b__73_4(); // 0x062fa4bc
	System.Void <PlaySurvivalAnim>b__73_5(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x062fa57c
	System.Void <PlaySurvivalAnim>b__73_8(); // 0x062fa828
	System.Void <PlaySurvivalAnim>b__73_10(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x062fa8e8
	System.Void <PlaySurvivalAnim>b__73_13(); // 0x062fab94
	System.Void <PlaySurvivalAnim>b__73_14(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x062fac54
	System.Void <PlaySurvivalAnim>b__73_17(); // 0x062faf00
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiMissionBook.EBookTabType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiMissionBook.EBookTabType SurvivalGuide = 0;
	static WizardGames.Soc.SocClient.Ui.UiMissionBook.EBookTabType Faction = 1;
	static WizardGames.Soc.SocClient.Ui.UiMissionBook.EBookTabType BattleInformation = 2;
	static WizardGames.Soc.SocClient.Ui.UiMissionBook.EBookTabType Story = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiMissionBook.ESurvivalState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiMissionBook.ESurvivalState NORMAL = 0;
	static WizardGames.Soc.SocClient.Ui.UiMissionBook.ESurvivalState FINISHBASIC = 1;
	static WizardGames.Soc.SocClient.Ui.UiMissionBook.ESurvivalState FINISHADVANCED = 2;
	static WizardGames.Soc.SocClient.Ui.UiMissionBook.ESurvivalState NORMALFINISHBASIC = 3;
	static WizardGames.Soc.SocClient.Ui.UiMissionBook.ESurvivalState NORMALFINISHADVANCED = 4;
	static WizardGames.Soc.SocClient.Ui.UiMissionBook.ESurvivalState AWAKE = 5;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionBook.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiMissionBook.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMainQuestTraining> <>9__13_1; // 0x8
	static FairyGUI.TransitionHook <>9__47_1; // 0x10
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMainQuestTraining> <>9__47_3; // 0x18
	static FairyGUI.TransitionHook <>9__48_1; // 0x20
	static FairyGUI.TransitionHook <>9__73_3; // 0x28
	static WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__73_2; // 0x30
	static FairyGUI.TransitionHook <>9__73_7; // 0x38
	static System.Action<WizardGames.Soc.SocClient.Ui.UiNewbieSelectMode> <>9__73_9; // 0x40
	static WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__73_6; // 0x48
	static FairyGUI.TransitionHook <>9__73_12; // 0x50
	static WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__73_11; // 0x58
	static FairyGUI.TransitionHook <>9__73_16; // 0x60
	static System.Action<WizardGames.Soc.SocClient.Ui.UiNewbieSelectMode> <>9__73_18; // 0x68
	static WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__73_15; // 0x70
	static System.Void .cctor(); // 0x062fafc0
	System.Void .ctor(); // 0x062fb024
	System.Void <OnClickMore>b__13_1(WizardGames.Soc.SocClient.Ui.UiMainQuestTraining win); // 0x062fb08c
	System.Void <IECompeleteOneFaction>b__47_1(); // 0x062fb11c
	System.Void <IECompeleteOneFaction>b__47_3(WizardGames.Soc.SocClient.Ui.UiMainQuestTraining win); // 0x062fb1dc
	System.Void <IECompeleteOneStage>b__48_1(); // 0x062fb26c
	System.Void <PlaySurvivalAnim>b__73_3(); // 0x062fb30c
	System.Void <PlaySurvivalAnim>b__73_2(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x062fb3ac
	System.Void <PlaySurvivalAnim>b__73_7(); // 0x062fb52c
	System.Void <PlaySurvivalAnim>b__73_6(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x062fb5cc
	System.Void <PlaySurvivalAnim>b__73_9(WizardGames.Soc.SocClient.Ui.UiNewbieSelectMode win); // 0x062fb72c
	System.Void <PlaySurvivalAnim>b__73_12(); // 0x062fb7b4
	System.Void <PlaySurvivalAnim>b__73_11(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x062fb854
	System.Void <PlaySurvivalAnim>b__73_16(); // 0x062fb9d4
	System.Void <PlaySurvivalAnim>b__73_15(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x062fba74
	System.Void <PlaySurvivalAnim>b__73_18(WizardGames.Soc.SocClient.Ui.UiNewbieSelectMode win); // 0x062fbbd4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionBook.<>c__DisplayClass47_0 : System.Object
{
	System.Boolean callbackTriggered; // 0x10
	System.Void .ctor(); // 0x062fbc5c
	System.Void <IECompeleteOneFaction>b__0(); // 0x062fbcc4
	System.Boolean <IECompeleteOneFaction>b__2(); // 0x062fbd2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionBook.<>c__DisplayClass48_0 : System.Object
{
	System.Boolean callbackTriggered; // 0x10
	WizardGames.Soc.SocClient.Ui.UiMissionBook <>4__this; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ListItemPage_TrainInfo2Binder pageBinder; // 0x20
	System.Boolean turnPage; // 0x28
	System.Void .ctor(); // 0x062fbd90
	System.Void <IECompeleteOneStage>b__0(); // 0x062fbdf8
	System.Boolean <IECompeleteOneStage>b__2(); // 0x062fbe60
	System.Void <IECompeleteOneStage>b__3(); // 0x062fbec4
	System.Boolean <IECompeleteOneStage>b__4(); // 0x062fc250
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionBook.<IECompeleteOneFaction>d__47 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Ui.UiMissionBook <>4__this; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ListItemPage_TrainInfo2Binder pageBinder; // 0x28
	WizardGames.Soc.SocClient.Ui.UiMissionBook.<>c__DisplayClass47_0 <>8__1; // 0x30
	System.Void .ctor(System.Int32 <>1__state); // 0x062f59c0
	System.Void System.IDisposable.Dispose(); // 0x062fc2b4
	System.Boolean MoveNext(); // 0x062fc314
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x062fc9d0
	System.Void System.Collections.IEnumerator.Reset(); // 0x062fca34
	System.Object System.Collections.IEnumerator.get_Current(); // 0x062fcabc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionBook.<IECompeleteOneStage>d__48 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Ui.UiMissionBook <>4__this; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ListItemPage_TrainInfo2Binder pageBinder; // 0x28
	WizardGames.Soc.SocClient.Ui.UiMissionBook.<>c__DisplayClass48_0 <>8__1; // 0x30
