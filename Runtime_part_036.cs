
// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GamePermissionCenter.UiPermissionSearchBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GamePermissionCenter.RootPermissionSearchBinder <Root>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GamePermissionCenter.RootPermissionSearchBinder get_Root(); // 0x0678e8a0
	System.Void .ctor(FairyGUI.GComponent root); // 0x0678e904
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameOB_PC.RootGameOBPlayerListBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameOB_PC.RootGameOBPlayerListContentBinder <PlayerList>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameOB_PC.RootGameOBPlayerListContentBinder get_PlayerList(); // 0x0678ea08
	System.Void .ctor(FairyGUI.GComponent root); // 0x0678ea6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameOB_PC.RootGameOBPlayerListContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GRichTextField <Num>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComSearchBinder <SearchBox>k__BackingField; // 0x20
	FairyGUI.GList <TeamList>k__BackingField; // 0x28
	FairyGUI.GRichTextField get_Num(); // 0x0678ecf8
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComSearchBinder get_SearchBox(); // 0x0678ed5c
	FairyGUI.GList get_TeamList(); // 0x0678edc0
	System.Void .ctor(FairyGUI.GComponent root); // 0x0678eb70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameOB_PC.RootGameOBTerritoryInfoBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameOB_PC.RootGameOBTerritoryInfoContentBinder <TerritoryInfo>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameOB_PC.RootGameOBTerritoryInfoContentBinder get_TerritoryInfo(); // 0x0678ee24
	System.Void .ctor(FairyGUI.GComponent root); // 0x0678ee88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameOB_PC.RootGameOBTerritoryInfoContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GImage <Bg>k__BackingField; // 0x18
	FairyGUI.GTextField <Title>k__BackingField; // 0x20
	FairyGUI.GLabel <TitleLord>k__BackingField; // 0x28
	FairyGUI.GImage <OBTitleBgLine1>k__BackingField; // 0x30
	FairyGUI.GButton <Lord>k__BackingField; // 0x38
	FairyGUI.GLabel <TitleMember>k__BackingField; // 0x40
	FairyGUI.GImage <OBTitleBgLine2>k__BackingField; // 0x48
	FairyGUI.GList <TeamMember>k__BackingField; // 0x50
	FairyGUI.GButton get_Lord(); // 0x0678f220
	FairyGUI.GList get_TeamMember(); // 0x0678f284
	System.Void .ctor(FairyGUI.GComponent root); // 0x0678ef8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameManger.ComMangerBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GGraph <TouchHideTips>k__BackingField; // 0x18
	FairyGUI.GList <BagList>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameManger.ComMangerItemBinder <Right>k__BackingField; // 0x28
	FairyGUI.GGraph get_TouchHideTips(); // 0x0678f2e8
	FairyGUI.GList get_BagList(); // 0x0678f34c
	WizardGames.Soc.SocClient.Ui.Binder.GameManger.ComMangerItemBinder get_Right(); // 0x0678f3b0
	System.Void .ctor(FairyGUI.GComponent root); // 0x0678f414
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameManger.ComMangerItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <List>k__BackingField; // 0x18
	FairyGUI.GButton <QuickGetBtn>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlState>k__BackingField; // 0x28
	FairyGUI.GList get_List(); // 0x0678f738
	FairyGUI.GButton get_QuickGetBtn(); // 0x0678f79c
	System.Void .ctor(FairyGUI.GComponent root); // 0x0678f5f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameManger.ComMangerRootBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <TopBar>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameManger.ComMangerBinder <Content>k__BackingField; // 0x20
	FairyGUI.GLabel get_TopBar(); // 0x0678f800
	WizardGames.Soc.SocClient.Ui.Binder.GameManger.ComMangerBinder get_Content(); // 0x0678f864
	System.Void .ctor(FairyGUI.GComponent root); // 0x0678f8c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameManger.UiMangerBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameManger.ComMangerRootBinder <Root>k__BackingField; // 0x18
	FairyGUI.GComponent <LazyLoaderDropArea>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameManger.ComMangerRootBinder get_Root(); // 0x0678fa0c
	FairyGUI.GComponent get_LazyLoaderDropArea(); // 0x0678fa70
	System.Void .ctor(FairyGUI.GComponent root); // 0x0678fad4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameMainMap.RadarviewBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <InfoBtn>k__BackingField; // 0x18
	FairyGUI.GButton <BtnClose>k__BackingField; // 0x20
	FairyGUI.GButton <BtnStart>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlPlatform>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlScanning>k__BackingField; // 0x38
	FairyGUI.Transition <TransRadar>k__BackingField; // 0x40
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x48
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x50
	FairyGUI.GButton get_InfoBtn(); // 0x0678fc18
	FairyGUI.GButton get_BtnClose(); // 0x0678fc7c
	FairyGUI.GButton get_BtnStart(); // 0x0678fce0
	FairyGUI.Controller get_CtrlScanning(); // 0x0678fd44
	System.Void .ctor(FairyGUI.GComponent root); // 0x0678fda8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameMainMap.SouDJSubViewBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <TabList>k__BackingField; // 0x18
	FairyGUI.GList <TeamList>k__BackingField; // 0x20
	FairyGUI.GList <AirdropList>k__BackingField; // 0x28
	FairyGUI.GLabel <LabelCoin>k__BackingField; // 0x30
	FairyGUI.GTextField <TxtRank>k__BackingField; // 0x38
	FairyGUI.GButton <BtnOpenRank>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlTab>k__BackingField; // 0x48
	FairyGUI.GList get_TabList(); // 0x06790000
	FairyGUI.GList get_TeamList(); // 0x06790064
	FairyGUI.GList get_AirdropList(); // 0x067900c8
	FairyGUI.GLabel get_LabelCoin(); // 0x0679012c
	FairyGUI.GTextField get_TxtRank(); // 0x06790190
	FairyGUI.GButton get_BtnOpenRank(); // 0x067901f4
	FairyGUI.Controller get_CtrlTab(); // 0x06790258
	System.Void .ctor(FairyGUI.GComponent root); // 0x067902bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.BgLiftingPlatformBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Model>k__BackingField; // 0x18
	System.Void .ctor(FairyGUI.GComponent root); // 0x067905b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComCellBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.Controller <CtrlStyle>k__BackingField; // 0x18
	FairyGUI.Transition <TransIncrease>k__BackingField; // 0x20
	FairyGUI.Transition <TransMinus>k__BackingField; // 0x28
	FairyGUI.Transition <TransSwitch>k__BackingField; // 0x30
	FairyGUI.Transition <TransSwitch_01>k__BackingField; // 0x38
	FairyGUI.Controller get_CtrlStyle(); // 0x06790688
	FairyGUI.Transition get_TransIncrease(); // 0x067906ec
	FairyGUI.Transition get_TransMinus(); // 0x06790750
	System.Void .ctor(FairyGUI.GComponent root); // 0x067907b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComCraftInfoDetailsBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <Icon>k__BackingField; // 0x18
	FairyGUI.GLabel <Title>k__BackingField; // 0x20
	FairyGUI.GComponent get_BinderRoot(); // 0x0679094c
	FairyGUI.GList get_Icon(); // 0x067909b0
	System.Void .ctor(FairyGUI.GComponent root); // 0x06790a14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComDurabilityBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Title>k__BackingField; // 0x18
	FairyGUI.GTextField <Value>k__BackingField; // 0x20
	FairyGUI.GTextField <Change>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlChange>k__BackingField; // 0x30
	FairyGUI.Transition <TransLoop>k__BackingField; // 0x38
	FairyGUI.GTextField get_Title(); // 0x06790b28
	FairyGUI.GTextField get_Value(); // 0x06790b8c
	FairyGUI.GTextField get_Change(); // 0x06790bf0
	FairyGUI.Controller get_CtrlChange(); // 0x06790c54
	System.Void .ctor(FairyGUI.GComponent root); // 0x06790cb8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComIconBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Icon>k__BackingField; // 0x18
	FairyGUI.GButton <CoverInfo>k__BackingField; // 0x20
	FairyGUI.GComponent get_Icon(); // 0x06790e74
	FairyGUI.GButton get_CoverInfo(); // 0x06790ed8
	System.Void .ctor(FairyGUI.GComponent root); // 0x06790f3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComMessageBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Title>k__BackingField; // 0x18
	FairyGUI.GList <SlotList>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlChange>k__BackingField; // 0x28
	FairyGUI.Transition <TransLoop>k__BackingField; // 0x30
	FairyGUI.GTextField get_Title(); // 0x06791050
	FairyGUI.GList get_SlotList(); // 0x067910b4
	FairyGUI.Controller get_CtrlChange(); // 0x06791118
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679117c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComModuleBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Title>k__BackingField; // 0x18
	FairyGUI.GTextField <Amount>k__BackingField; // 0x20
	FairyGUI.GList <Icon>k__BackingField; // 0x28
	FairyGUI.GButton <BtnUnequip>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlShowBtnUnequip>k__BackingField; // 0x38
	FairyGUI.GComponent get_BinderRoot(); // 0x067912f8
	FairyGUI.GLabel get_Title(); // 0x0679135c
	FairyGUI.GTextField get_Amount(); // 0x067913c0
	FairyGUI.GList get_Icon(); // 0x06791424
	FairyGUI.GButton get_BtnUnequip(); // 0x06791488
	FairyGUI.Controller get_CtrlShowBtnUnequip(); // 0x067914ec
	System.Void .ctor(FairyGUI.GComponent root); // 0x06791550
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComOtherBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Icon>k__BackingField; // 0x18
	FairyGUI.GTextField <Durability>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComTipsRareLableBinder <LabelRare>k__BackingField; // 0x28
	FairyGUI.GTextField <Occupy>k__BackingField; // 0x30
	FairyGUI.GButton <BtnRepair>k__BackingField; // 0x38
	FairyGUI.GLoader get_Icon(); // 0x06791770
	FairyGUI.GTextField get_Durability(); // 0x067917d4
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComTipsRareLableBinder get_LabelRare(); // 0x06791838
	FairyGUI.GTextField get_Occupy(); // 0x0679189c
	FairyGUI.GButton get_BtnRepair(); // 0x06791900
	System.Void .ctor(FairyGUI.GComponent root); // 0x06791964
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComSelectableBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <IconList>k__BackingField; // 0x18
	FairyGUI.GList get_IconList(); // 0x06791bf4
	System.Void .ctor(FairyGUI.GComponent root); // 0x06791c58
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComSelectBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Icon>k__BackingField; // 0x18
	FairyGUI.GImage <SlotBac>k__BackingField; // 0x20
	FairyGUI.GImage <SlotFront>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x30
	FairyGUI.Transition <TransSwitch>k__BackingField; // 0x38
	FairyGUI.GComponent get_Icon(); // 0x06791d2c
	FairyGUI.GImage get_SlotBac(); // 0x06791d90
	FairyGUI.GImage get_SlotFront(); // 0x06791df4
	FairyGUI.Controller get_CtrlStatus(); // 0x06791e58
	System.Void .ctor(FairyGUI.GComponent root); // 0x06791ebc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComStatusBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <BtnRepair>k__BackingField; // 0x18
	FairyGUI.GList <StatusList>k__BackingField; // 0x20
	FairyGUI.Transition <TransComplete>k__BackingField; // 0x28
	FairyGUI.GButton get_BtnRepair(); // 0x06792078
	FairyGUI.GList get_StatusList(); // 0x067920dc
	FairyGUI.Transition get_TransComplete(); // 0x06792140
	System.Void .ctor(FairyGUI.GComponent root); // 0x067921a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComTipsBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Title>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComOtherBinder <ItemRepair>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComTipsFlexibleBinder <ItemParts>k__BackingField; // 0x28
	FairyGUI.GTextField <CantCraftTips>k__BackingField; // 0x30
	FairyGUI.GButton <BtnUnequip>k__BackingField; // 0x38
	FairyGUI.GButton <BtnInstall>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x48
	FairyGUI.GTextField get_Title(); // 0x067922ec
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComOtherBinder get_ItemRepair(); // 0x06792350
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComTipsFlexibleBinder get_ItemParts(); // 0x067923b4
	FairyGUI.GTextField get_CantCraftTips(); // 0x06792418
	FairyGUI.GButton get_BtnUnequip(); // 0x0679247c
	FairyGUI.GButton get_BtnInstall(); // 0x067924e0
	FairyGUI.Controller get_CtrlStatus(); // 0x06792544
	System.Void .ctor(FairyGUI.GComponent root); // 0x067925a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComTipsFlexibleBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComModuleBinder <ItemParts>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComCraftInfoDetailsBinder <ItemMaterials>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComModuleBinder get_ItemParts(); // 0x067929c4
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComCraftInfoDetailsBinder get_ItemMaterials(); // 0x06792a28
	System.Void .ctor(FairyGUI.GComponent root); // 0x06792850
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComTipsRareLableBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent get_BinderRoot(); // 0x06792a8c
	System.Void .ctor(FairyGUI.GComponent root); // 0x06791b68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComVehicleIconBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Number>k__BackingField; // 0x18
	FairyGUI.GTextField <Name>k__BackingField; // 0x20
	FairyGUI.GLoader <Icon>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.CommonGame.ComItemConditionBinder <Condition>k__BackingField; // 0x30
	FairyGUI.GImage <SlotBac>k__BackingField; // 0x38
	FairyGUI.GImage <SlotFront>k__BackingField; // 0x40
	FairyGUI.GImage <PlusSign>k__BackingField; // 0x48
	FairyGUI.Controller <CtrlSlot>k__BackingField; // 0x50
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x58
	FairyGUI.Transition <TransInstall>k__BackingField; // 0x60
	FairyGUI.Transition <TransLink>k__BackingField; // 0x68
	FairyGUI.GTextField get_Number(); // 0x06792af0
	FairyGUI.GTextField get_Name(); // 0x06792b54
	FairyGUI.GLoader get_Icon(); // 0x06792bb8
	WizardGames.Soc.SocClient.Ui.Binder.CommonGame.ComItemConditionBinder get_Condition(); // 0x06792c1c
	FairyGUI.GImage get_SlotBac(); // 0x06792c80
	FairyGUI.GImage get_SlotFront(); // 0x06792ce4
	FairyGUI.Controller get_CtrlSlot(); // 0x06792d48
	FairyGUI.Controller get_CtrlStatus(); // 0x06792dac
	FairyGUI.Transition get_TransInstall(); // 0x06792e10
	FairyGUI.Transition get_TransLink(); // 0x06792e74
	System.Void .ctor(FairyGUI.GComponent root); // 0x06792ed8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.RootLiftingPlatformBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <TopBar>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.RootLiftingPlatformContentBinder <Content>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlTipsState>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlIconListState>k__BackingField; // 0x30
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x38
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x40
	FairyGUI.Transition <TransSwitch>k__BackingField; // 0x48
	FairyGUI.Transition <TransSwitch_02>k__BackingField; // 0x50
	FairyGUI.Transition <TransSwitch_03>k__BackingField; // 0x58
	FairyGUI.Transition <TransSwitch_01>k__BackingField; // 0x60
	FairyGUI.GLabel get_TopBar(); // 0x06793230
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.RootLiftingPlatformContentBinder get_Content(); // 0x06793294
	System.Void .ctor(FairyGUI.GComponent root); // 0x067932f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.RootLiftingPlatformContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <SlotItemsList>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComSelectableBinder <IconList>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComStatusBinder <Status>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComTipsBinder <TipsMain>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlTipsState>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlIconListState>k__BackingField; // 0x40
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x48
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x50
	FairyGUI.Transition <TransSwitch>k__BackingField; // 0x58
	FairyGUI.Transition <TransSwitch_02>k__BackingField; // 0x60
	FairyGUI.Transition <TransSwitch_03>k__BackingField; // 0x68
	FairyGUI.Transition <TransSwitch_01>k__BackingField; // 0x70
	FairyGUI.GList get_SlotItemsList(); // 0x067939a0
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComSelectableBinder get_IconList(); // 0x06793a04
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComStatusBinder get_Status(); // 0x06793a68
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComTipsBinder get_TipsMain(); // 0x06793acc
	FairyGUI.Controller get_CtrlTipsState(); // 0x06793b30
	FairyGUI.Controller get_CtrlIconListState(); // 0x06793b94
	System.Void .ctor(FairyGUI.GComponent root); // 0x067935dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.UiLiftingPlatformBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.BgLiftingPlatformBinder <Bg>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.RootLiftingPlatformBinder <Root>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.RootLiftingPlatformBinder get_Root(); // 0x06793bf8
	System.Void .ctor(FairyGUI.GComponent root); // 0x06793c5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLeftPopUp.ComLeftPopUpRootBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Blank>k__BackingField; // 0x18
	FairyGUI.GComponent <NavBar>k__BackingField; // 0x20
	FairyGUI.GComponent <N1>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.GameLeftPopUp.ComPopUpBinder <PopUp>k__BackingField; // 0x30
	FairyGUI.GLoader get_Blank(); // 0x06793dd0
	FairyGUI.GComponent get_NavBar(); // 0x06793e34
	FairyGUI.GComponent get_N1(); // 0x06793e98
	WizardGames.Soc.SocClient.Ui.Binder.GameLeftPopUp.ComPopUpBinder get_PopUp(); // 0x06793efc
	System.Void .ctor(FairyGUI.GComponent root); // 0x06793f60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLeftPopUp.ComPopUpBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Title>k__BackingField; // 0x18
	FairyGUI.GTextField <Text>k__BackingField; // 0x20
	FairyGUI.GList <GoaltList>k__BackingField; // 0x28
	FairyGUI.GList <RewardsList>k__BackingField; // 0x30
	FairyGUI.GButton <BtnCancel>k__BackingField; // 0x38
	FairyGUI.GButton <BtnTrace>k__BackingField; // 0x40
	FairyGUI.GButton <BtnPickUp>k__BackingField; // 0x48
	FairyGUI.GTextField <Number>k__BackingField; // 0x50
	FairyGUI.GGroup <Distance>k__BackingField; // 0x58
	FairyGUI.Controller <CtrlBtnStatus>k__BackingField; // 0x60
	FairyGUI.GComponent get_BinderRoot(); // 0x067944dc
	FairyGUI.GTextField get_Title(); // 0x06794540
	FairyGUI.GTextField get_Text(); // 0x067945a4
	FairyGUI.GList get_GoaltList(); // 0x06794608
	FairyGUI.GList get_RewardsList(); // 0x0679466c
	FairyGUI.GButton get_BtnCancel(); // 0x067946d0
	FairyGUI.GButton get_BtnTrace(); // 0x06794734
	FairyGUI.GButton get_BtnPickUp(); // 0x06794798
	FairyGUI.GGroup get_Distance(); // 0x067947fc
	FairyGUI.Controller get_CtrlBtnStatus(); // 0x06794860
	System.Void .ctor(FairyGUI.GComponent root); // 0x06794124
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameLeftPopUp.UiLeftPopUpBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameLeftPopUp.ComLeftPopUpRootBinder <Root>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameLeftPopUp.ComLeftPopUpRootBinder get_Root(); // 0x067948c4
	System.Void .ctor(FairyGUI.GComponent root); // 0x06794928
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameItemTips.ComTipsItemPartsIconBinder : System.Object
{
	FairyGUI.GComponent <Root>k__BackingField; // 0x10
	FairyGUI.GComponent <Icon>k__BackingField; // 0x18
	FairyGUI.GImage <ChooseState>k__BackingField; // 0x20
	FairyGUI.GImage <Disable>k__BackingField; // 0x28
	FairyGUI.GTextField <Name>k__BackingField; // 0x30
	FairyGUI.GComponent get_Root(); // 0x06794a2c
	FairyGUI.GComponent get_Icon(); // 0x06794a90
	FairyGUI.GImage get_ChooseState(); // 0x06794af4
	FairyGUI.GImage get_Disable(); // 0x06794b58
	FairyGUI.GTextField get_Name(); // 0x06794bbc
	System.Void .ctor(FairyGUI.GComponent root); // 0x06794c20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameItemSplit.ComItem_ChangeInfoBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Title>k__BackingField; // 0x18
	FairyGUI.GList <List>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlCtrlSignIcon>k__BackingField; // 0x28
	FairyGUI.GComponent get_BinderRoot(); // 0x06794db4
	FairyGUI.GTextField get_Title(); // 0x06794e18
	FairyGUI.GList get_List(); // 0x06794e7c
	System.Void .ctor(FairyGUI.GComponent root); // 0x06794ee0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameItemPopup.ComIconAdapterBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <IconLoader>k__BackingField; // 0x18
	FairyGUI.GTextField <Title>k__BackingField; // 0x20
	FairyGUI.GComponent get_IconLoader(); // 0x06795028
	FairyGUI.GTextField get_Title(); // 0x0679508c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067950f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameItemPopup.ComIconLineBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Title>k__BackingField; // 0x18
	FairyGUI.GList <List>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlLenCtrl>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlTitleCtrl>k__BackingField; // 0x30
	FairyGUI.GLabel get_Title(); // 0x06795204
	FairyGUI.GList get_List(); // 0x06795268
	FairyGUI.Controller get_CtrlLenCtrl(); // 0x067952cc
	FairyGUI.Controller get_CtrlTitleCtrl(); // 0x06795330
	System.Void .ctor(FairyGUI.GComponent root); // 0x06795394
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameItemPopup.ComItemPopupBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Modal>k__BackingField; // 0x18
	FairyGUI.GList <Icons>k__BackingField; // 0x20
	FairyGUI.GTextField <ExtraDesc>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlSize>k__BackingField; // 0x30
	FairyGUI.GComponent get_Modal(); // 0x06795568
	FairyGUI.GList get_Icons(); // 0x067955cc
	FairyGUI.GTextField get_ExtraDesc(); // 0x06795630
	System.Void .ctor(FairyGUI.GComponent root); // 0x06795694
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameItemPopup.UiItemPopupBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameItemPopup.ComItemPopupBinder <Root>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlSize>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameItemPopup.ComItemPopupBinder get_Root(); // 0x06795874
	FairyGUI.Controller get_CtrlSize(); // 0x067958d8
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679593c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameItemChoose.ComSelectRewardTipBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GGraph <BgClose>k__BackingField; // 0x18
	FairyGUI.GList <RewardList>k__BackingField; // 0x20
	FairyGUI.GTextField <Title>k__BackingField; // 0x28
	FairyGUI.GButton <BtnCancel>k__BackingField; // 0x30
	FairyGUI.GButton <BtnGet>k__BackingField; // 0x38
	FairyGUI.GButton <Modal_btnesc>k__BackingField; // 0x40
	FairyGUI.GGraph get_BgClose(); // 0x06795a74
	FairyGUI.GList get_RewardList(); // 0x06795ad8
	FairyGUI.GTextField get_Title(); // 0x06795b3c
	FairyGUI.GButton get_BtnCancel(); // 0x06795ba0
	FairyGUI.GButton get_BtnGet(); // 0x06795c04
	FairyGUI.GButton get_Modal_btnesc(); // 0x06795c68
	System.Void .ctor(FairyGUI.GComponent root); // 0x06795ccc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameItemChoose.RootItemChooseBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GGraph <BgClose>k__BackingField; // 0x18
	FairyGUI.GImage <Panel>k__BackingField; // 0x20
	FairyGUI.GTextField <Title>k__BackingField; // 0x28
	FairyGUI.GTextField <SubTitle>k__BackingField; // 0x30
	FairyGUI.GList <ItemList>k__BackingField; // 0x38
	FairyGUI.GButton <BtnClose>k__BackingField; // 0x40
	FairyGUI.GTextField <ClosePrompt>k__BackingField; // 0x48
	FairyGUI.GTextField <CurrencyColumn>k__BackingField; // 0x50
	FairyGUI.GLoader <Icon>k__BackingField; // 0x58
	FairyGUI.GTextField <Value>k__BackingField; // 0x60
	FairyGUI.GList <BtnList>k__BackingField; // 0x68
	FairyGUI.GButton <Modal_btnesc>k__BackingField; // 0x70
	FairyGUI.Controller <CtrlCurrencyColumn>k__BackingField; // 0x78
	FairyGUI.Controller <CtrlSubTitleVisible>k__BackingField; // 0x80
	FairyGUI.GGraph get_BgClose(); // 0x06795ee0
	FairyGUI.GTextField get_Title(); // 0x06795f44
	FairyGUI.GTextField get_SubTitle(); // 0x06795fa8
	FairyGUI.GList get_ItemList(); // 0x0679600c
	FairyGUI.GButton get_BtnClose(); // 0x06796070
	FairyGUI.GTextField get_CurrencyColumn(); // 0x067960d4
	FairyGUI.GLoader get_Icon(); // 0x06796138
	FairyGUI.GTextField get_Value(); // 0x0679619c
	FairyGUI.GList get_BtnList(); // 0x06796200
	FairyGUI.GButton get_Modal_btnesc(); // 0x06796264
	FairyGUI.Controller get_CtrlCurrencyColumn(); // 0x067962c8
	FairyGUI.Controller get_CtrlSubTitleVisible(); // 0x0679632c
	System.Void .ctor(FairyGUI.GComponent root); // 0x06796390
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameItemChoose.SelectRewardIconBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Name>k__BackingField; // 0x18
	FairyGUI.GComponent <ItemIcon>k__BackingField; // 0x20
	FairyGUI.GButton <MagnifierBtn>k__BackingField; // 0x28
	FairyGUI.GTextField <Num>k__BackingField; // 0x30
	FairyGUI.GTextField <UnlockText>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlIsSelect>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlIsLock>k__BackingField; // 0x48
	FairyGUI.Controller <CtrlTalentStatus>k__BackingField; // 0x50
	FairyGUI.Transition <TransLight>k__BackingField; // 0x58
	FairyGUI.GComponent get_BinderRoot(); // 0x06796778
	FairyGUI.GTextField get_Name(); // 0x067967dc
	FairyGUI.GComponent get_ItemIcon(); // 0x06796840
	FairyGUI.GButton get_MagnifierBtn(); // 0x067968a4
	FairyGUI.GTextField get_Num(); // 0x06796908
	FairyGUI.GTextField get_UnlockText(); // 0x0679696c
	FairyGUI.Controller get_CtrlIsSelect(); // 0x067969d0
	FairyGUI.Controller get_CtrlIsLock(); // 0x06796a34
	System.Void .ctor(FairyGUI.GComponent root); // 0x06796a98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.BtnCostItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <ComItem>k__BackingField; // 0x18
	FairyGUI.GTextField <TxtAmount>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlSource>k__BackingField; // 0x28
	FairyGUI.GComponent get_ComItem(); // 0x06796d3c
	FairyGUI.GTextField get_TxtAmount(); // 0x06796da0
	FairyGUI.Controller get_CtrlSource(); // 0x06796e04
	System.Void .ctor(FairyGUI.GComponent root); // 0x06796e68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.BtnSlotCardBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Title>k__BackingField; // 0x18
	FairyGUI.GTextField <Text>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComBlueprintScaleBinder <Scale>k__BackingField; // 0x28
	FairyGUI.GTextField <Level>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x40
	FairyGUI.GTextField get_Title(); // 0x06796fb0
	FairyGUI.GTextField get_Text(); // 0x06797014
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComBlueprintScaleBinder get_Scale(); // 0x06797078
	FairyGUI.GTextField get_Level(); // 0x067970dc
	FairyGUI.Controller get_CtrlStatus(); // 0x06797140
	System.Void .ctor(FairyGUI.GComponent root); // 0x067971a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.CoConfirmBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Modal>k__BackingField; // 0x18
	FairyGUI.GLabel get_Modal(); // 0x067974d8
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679753c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComAttackedPopBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Modal>k__BackingField; // 0x18
	FairyGUI.GButton <BtnConfirm>k__BackingField; // 0x20
	FairyGUI.GTextField <TxtCDTime>k__BackingField; // 0x28
	FairyGUI.GComponent get_Modal(); // 0x06797610
	FairyGUI.GButton get_BtnConfirm(); // 0x06797674
	FairyGUI.GTextField get_TxtCDTime(); // 0x067976d8
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679773c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComBlueprintScaleBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Title>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x20
	FairyGUI.GTextField get_Title(); // 0x06797890
	FairyGUI.Controller get_CtrlStatus(); // 0x067978f4
	System.Void .ctor(FairyGUI.GComponent root); // 0x067973d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComConstructBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <List>k__BackingField; // 0x18
	FairyGUI.GComponent get_BinderRoot(); // 0x06797958
	FairyGUI.GList get_List(); // 0x067979bc
	System.Void .ctor(FairyGUI.GComponent root); // 0x06797a20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComCoolingBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <Btn>k__BackingField; // 0x18
	FairyGUI.GTextField <Time>k__BackingField; // 0x20
	FairyGUI.GButton get_Btn(); // 0x06797b4c
	FairyGUI.GTextField get_Time(); // 0x06797bb0
	System.Void .ctor(FairyGUI.GComponent root); // 0x06797c14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComCustomUpgradeBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Modal>k__BackingField; // 0x18
	FairyGUI.GTree <ListConstructionItem_ag>k__BackingField; // 0x20
	FairyGUI.GButton <BtnConfirm>k__BackingField; // 0x28
	FairyGUI.GButton <BtnSelectAll>k__BackingField; // 0x30
	FairyGUI.GLabel get_Modal(); // 0x06797d28
	FairyGUI.GTree get_ListConstructionItem_ag(); // 0x06797d8c
	FairyGUI.GButton get_BtnConfirm(); // 0x06797df0
	FairyGUI.GButton get_BtnSelectAll(); // 0x06797e54
	System.Void .ctor(FairyGUI.GComponent root); // 0x06797eb8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComInfoPanelBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Title>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComScaleBinder <Scale>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComConstructBinder <Construct>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComMaintainBinder <Maintain>k__BackingField; // 0x30
	FairyGUI.GButton <BtnReplace>k__BackingField; // 0x38
	FairyGUI.GButton <BtnSave>k__BackingField; // 0x40
	FairyGUI.GButton <BtnNot>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComCoolingBinder <BtnCooting>k__BackingField; // 0x50
	FairyGUI.GButton <BtnUnderway>k__BackingField; // 0x58
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x60
	FairyGUI.Controller <CtrlSlotData>k__BackingField; // 0x68
	FairyGUI.GTextField get_Title(); // 0x0679804c
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComScaleBinder get_Scale(); // 0x067980b0
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComConstructBinder get_Construct(); // 0x06798114
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComMaintainBinder get_Maintain(); // 0x06798178
	FairyGUI.GButton get_BtnReplace(); // 0x067981dc
	FairyGUI.GButton get_BtnSave(); // 0x06798240
	FairyGUI.GButton get_BtnNot(); // 0x067982a4
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComCoolingBinder get_BtnCooting(); // 0x06798308
	FairyGUI.Controller get_CtrlStatus(); // 0x0679836c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067983d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComLeftTimeBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <TxtDayNum>k__BackingField; // 0x18
	FairyGUI.GTextField <TxtDayText>k__BackingField; // 0x20
	FairyGUI.GTextField <TxtHourNum>k__BackingField; // 0x28
	FairyGUI.GTextField <TxtHourText>k__BackingField; // 0x30
	FairyGUI.GTextField <TxtMinNum>k__BackingField; // 0x38
	FairyGUI.GTextField <TxtMinText>k__BackingField; // 0x40
	FairyGUI.GTextField get_TxtDayNum(); // 0x06798a00
	FairyGUI.GTextField get_TxtHourNum(); // 0x06798a64
	FairyGUI.GTextField get_TxtMinNum(); // 0x06798ac8
	System.Void .ctor(FairyGUI.GComponent root); // 0x06798b2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComMaintainBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <List>k__BackingField; // 0x18
	FairyGUI.GComponent get_BinderRoot(); // 0x06798d40
	FairyGUI.GList get_List(); // 0x06798da4
	System.Void .ctor(FairyGUI.GComponent root); // 0x067988d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComMaterialsBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Icon>k__BackingField; // 0x18
	FairyGUI.GTextField <Title>k__BackingField; // 0x20
	FairyGUI.GTextField <Number>k__BackingField; // 0x28
	FairyGUI.GLoader get_Icon(); // 0x06798e08
	FairyGUI.GTextField get_Title(); // 0x06798e6c
	FairyGUI.GTextField get_Number(); // 0x06798ed0
	System.Void .ctor(FairyGUI.GComponent root); // 0x06798f34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComSavePopBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Modal>k__BackingField; // 0x18
	FairyGUI.GComponent <Input>k__BackingField; // 0x20
	FairyGUI.GTextField <Num>k__BackingField; // 0x28
	FairyGUI.GLabel get_Modal(); // 0x06799088
	FairyGUI.GComponent get_Input(); // 0x067990ec
	FairyGUI.GTextField get_Num(); // 0x06799150
	System.Void .ctor(FairyGUI.GComponent root); // 0x067991b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComScaleBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Number>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x20
	FairyGUI.GTextField get_Number(); // 0x06799308
	FairyGUI.Controller get_CtrlStatus(); // 0x0679936c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067987cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComUpkeepItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <ComItem>k__BackingField; // 0x18
	FairyGUI.GTextField <Title>k__BackingField; // 0x20
	FairyGUI.GTextField <TitleRed>k__BackingField; // 0x28
	FairyGUI.GTextField <TxtOneDayCost>k__BackingField; // 0x30
	FairyGUI.GTextField <TxtAmountNum>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlIsInProtected>k__BackingField; // 0x48
	FairyGUI.GComponent get_BinderRoot(); // 0x067993d0
	FairyGUI.GComponent get_ComItem(); // 0x06799434
	FairyGUI.GTextField get_Title(); // 0x06799498
	FairyGUI.GTextField get_TitleRed(); // 0x067994fc
	FairyGUI.GTextField get_TxtOneDayCost(); // 0x06799560
	FairyGUI.GTextField get_TxtAmountNum(); // 0x067995c4
	FairyGUI.Controller get_CtrlIsInProtected(); // 0x06799628
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679968c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComUseToolcupboardItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Modal>k__BackingField; // 0x18
	FairyGUI.GTextField <TxtWarningInfo>k__BackingField; // 0x20
	FairyGUI.GList <LstUpgradeCost>k__BackingField; // 0x28
	FairyGUI.GButton <BtnConfirm>k__BackingField; // 0x30
	FairyGUI.GButton <BtnCancel>k__BackingField; // 0x38
	FairyGUI.GComponent get_Modal(); // 0x067998c8
	FairyGUI.GTextField get_TxtWarningInfo(); // 0x0679992c
	FairyGUI.GList get_LstUpgradeCost(); // 0x06799990
	FairyGUI.GButton get_BtnConfirm(); // 0x067999f4
	FairyGUI.GButton get_BtnCancel(); // 0x06799a58
	System.Void .ctor(FairyGUI.GComponent root); // 0x06799abc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ConstructionFolderItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Title>k__BackingField; // 0x18
	FairyGUI.GTextField <TxtNum>k__BackingField; // 0x20
	FairyGUI.GButton <ComSelectState>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlExpanded>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlSelect>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlUnlock>k__BackingField; // 0x40
	FairyGUI.GTextField get_Title(); // 0x06799ce8
	FairyGUI.GTextField get_TxtNum(); // 0x06799d4c
	FairyGUI.GButton get_ComSelectState(); // 0x06799db0
	FairyGUI.Controller get_CtrlSelect(); // 0x06799e14
	FairyGUI.Controller get_CtrlUnlock(); // 0x06799e78
	System.Void .ctor(FairyGUI.GComponent root); // 0x06799edc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ConstructionItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Icon>k__BackingField; // 0x18
	FairyGUI.GTextField <Title>k__BackingField; // 0x20
	FairyGUI.GTextField <TxtNum>k__BackingField; // 0x28
	FairyGUI.GList <IconChilds>k__BackingField; // 0x30
	FairyGUI.GButton <ComSelectState>k__BackingField; // 0x38
	FairyGUI.GLoader <TargetIcon>k__BackingField; // 0x40
	FairyGUI.GTextField <TargetTitle>k__BackingField; // 0x48
	FairyGUI.GTextField <TargetNum>k__BackingField; // 0x50
	FairyGUI.GList <TargetIconChilds>k__BackingField; // 0x58
	FairyGUI.GButton <BtnToUnlock>k__BackingField; // 0x60
	FairyGUI.GTextField <TxtWarning>k__BackingField; // 0x68
	FairyGUI.Controller <CtrlSelect>k__BackingField; // 0x70
	FairyGUI.Controller <CtrlUnlock>k__BackingField; // 0x78
	FairyGUI.GLoader get_Icon(); // 0x0679a0cc
	FairyGUI.GTextField get_Title(); // 0x0679a130
	FairyGUI.GTextField get_TxtNum(); // 0x0679a194
	FairyGUI.GList get_IconChilds(); // 0x0679a1f8
	FairyGUI.GButton get_ComSelectState(); // 0x0679a25c
	FairyGUI.GLoader get_TargetIcon(); // 0x0679a2c0
	FairyGUI.GTextField get_TargetTitle(); // 0x0679a324
	FairyGUI.GList get_TargetIconChilds(); // 0x0679a388
	FairyGUI.GButton get_BtnToUnlock(); // 0x0679a3ec
	FairyGUI.GTextField get_TxtWarning(); // 0x0679a450
	FairyGUI.Controller get_CtrlSelect(); // 0x0679a4b4
	FairyGUI.Controller get_CtrlUnlock(); // 0x0679a518
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679a57c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.RootTerritoryCenterBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <NavBar>k__BackingField; // 0x18
	FairyGUI.GLabel <TopBar>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.RootTerritoryCenterContentBinder <Content>k__BackingField; // 0x28
	FairyGUI.GGraph <Fx>k__BackingField; // 0x30
	FairyGUI.GComponent get_BinderRoot(); // 0x0679a938
	FairyGUI.GComponent get_NavBar(); // 0x0679a99c
	FairyGUI.GLabel get_TopBar(); // 0x0679aa00
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.RootTerritoryCenterContentBinder get_Content(); // 0x0679aa64
	FairyGUI.GGraph get_Fx(); // 0x0679aac8
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679ab2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.RootTerritoryCenterContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubSafeBoxBinder <SubSafeBox>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubToolcupBoardBinder <SubToolcupBoard>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlPlatform>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubSafeBoxBinder get_SubSafeBox(); // 0x0679ae98
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubToolcupBoardBinder get_SubToolcupBoard(); // 0x0679aefc
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679acf0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.RootTerritoryEditBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <TopBar>k__BackingField; // 0x18
	FairyGUI.GComponent <NavBar>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.RootTerritoryEditContentBinder <Content>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlState>k__BackingField; // 0x30
	FairyGUI.GLabel get_TopBar(); // 0x0679b414
	FairyGUI.GComponent get_NavBar(); // 0x0679b478
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.RootTerritoryEditContentBinder get_Content(); // 0x0679b4dc
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679b540
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.RootTerritoryEditContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubBatchUpgradeBinder <SubBatchUpgrade>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubBatchRecoverBinder <SubBatchRecover>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubCustomBlueprintBinder <SubCustomBlueprint>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubBatchUpgradeBinder get_SubBatchUpgrade(); // 0x0679b8dc
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubBatchRecoverBinder get_SubBatchRecover(); // 0x0679b940
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubCustomBlueprintBinder get_SubCustomBlueprint(); // 0x0679b9a4
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679b6f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.RootUiTerritoryEditPopBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComAttackedPopBinder <ComAttackedPop>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComUseToolcupboardItemBinder <ComUseToolcupboardItem>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.UiSavePopBinder <ComSaveBlueprintPop>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.UIConfirmBinder <ComSaveBlueprintConfirmPop>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlState>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComAttackedPopBinder get_ComAttackedPop(); // 0x0679c6bc
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComUseToolcupboardItemBinder get_ComUseToolcupboardItem(); // 0x0679c720
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.UiSavePopBinder get_ComSaveBlueprintPop(); // 0x0679c784
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.UIConfirmBinder get_ComSaveBlueprintConfirmPop(); // 0x0679c7e8
	FairyGUI.Controller get_CtrlState(); // 0x0679c84c
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679c8b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubBatchRecoverBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <IconTargetIcon>k__BackingField; // 0x18
	FairyGUI.GImage <IconProgress>k__BackingField; // 0x20
	FairyGUI.GTextField <TxtProgress>k__BackingField; // 0x28
	FairyGUI.GButton <BtnRecover>k__BackingField; // 0x30
	FairyGUI.GList <LstUpgradeCost>k__BackingField; // 0x38
	FairyGUI.GButton <BtnChoiceAll>k__BackingField; // 0x40
	FairyGUI.GButton <BtnChoiceBase>k__BackingField; // 0x48
	FairyGUI.GTextField <TxtRepairCheckPoint>k__BackingField; // 0x50
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComCustomUpgradeBinder <ComCustomRecover>k__BackingField; // 0x58
	FairyGUI.Controller <CtrlState>k__BackingField; // 0x60
	FairyGUI.Controller <CtrlHaveTerritoryCost>k__BackingField; // 0x68
	FairyGUI.Controller <CtrlCustomChoose>k__BackingField; // 0x70
	FairyGUI.GComponent get_BinderRoot(); // 0x0679cd40
	FairyGUI.GImage get_IconProgress(); // 0x0679cda4
	FairyGUI.GButton get_BtnRecover(); // 0x0679ce08
	FairyGUI.GList get_LstUpgradeCost(); // 0x0679ce6c
	FairyGUI.GButton get_BtnChoiceAll(); // 0x0679ced0
	FairyGUI.GButton get_BtnChoiceBase(); // 0x0679cf34
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComCustomUpgradeBinder get_ComCustomRecover(); // 0x0679cf98
	FairyGUI.Controller get_CtrlState(); // 0x0679cffc
	FairyGUI.Controller get_CtrlHaveTerritoryCost(); // 0x0679d060
	FairyGUI.Controller get_CtrlCustomChoose(); // 0x0679d0c4
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679bf40
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubBatchUpgradeBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <IconTargetIcon>k__BackingField; // 0x18
	FairyGUI.GTextField <TxtTargetGrade>k__BackingField; // 0x20
	FairyGUI.GImage <IconProgress>k__BackingField; // 0x28
	FairyGUI.GTextField <TxtProgress>k__BackingField; // 0x30
	FairyGUI.GButton <BtnUpgrade>k__BackingField; // 0x38
	FairyGUI.GList <LstUpgradeCost>k__BackingField; // 0x40
	FairyGUI.GButton <BtnToWood>k__BackingField; // 0x48
	FairyGUI.GButton <BtnToStone>k__BackingField; // 0x50
	FairyGUI.GButton <BtnToMetal>k__BackingField; // 0x58
	FairyGUI.GButton <BtnToSteel>k__BackingField; // 0x60
	FairyGUI.GButton <BtnChoiceAll>k__BackingField; // 0x68
	FairyGUI.GButton <BtnChoiceMax>k__BackingField; // 0x70
	FairyGUI.GButton <BtnChoiceCustom>k__BackingField; // 0x78
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComCustomUpgradeBinder <ComCustomUpgrade>k__BackingField; // 0x80
	FairyGUI.Controller <CtrlState>k__BackingField; // 0x88
	FairyGUI.Controller <CtrlHaveTerritoryCost>k__BackingField; // 0x90
	FairyGUI.Controller <CtrlCustomChoose>k__BackingField; // 0x98
	FairyGUI.GComponent get_BinderRoot(); // 0x0679d128
	FairyGUI.GTextField get_TxtTargetGrade(); // 0x0679d18c
	FairyGUI.GImage get_IconProgress(); // 0x0679d1f0
	FairyGUI.GButton get_BtnUpgrade(); // 0x0679d254
	FairyGUI.GList get_LstUpgradeCost(); // 0x0679d2b8
	FairyGUI.GButton get_BtnToWood(); // 0x0679d31c
	FairyGUI.GButton get_BtnToStone(); // 0x0679d380
	FairyGUI.GButton get_BtnToMetal(); // 0x0679d3e4
	FairyGUI.GButton get_BtnToSteel(); // 0x0679d448
	FairyGUI.GButton get_BtnChoiceAll(); // 0x0679d4ac
	FairyGUI.GButton get_BtnChoiceMax(); // 0x0679d510
	FairyGUI.GButton get_BtnChoiceCustom(); // 0x0679d574
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComCustomUpgradeBinder get_ComCustomUpgrade(); // 0x0679d5d8
	FairyGUI.Controller get_CtrlState(); // 0x0679d63c
	FairyGUI.Controller get_CtrlHaveTerritoryCost(); // 0x0679d6a0
	FairyGUI.Controller get_CtrlCustomChoose(); // 0x0679d704
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679ba08
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubCustomBlueprintBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <List>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComInfoPanelBinder <InfoPanel>k__BackingField; // 0x20
	FairyGUI.GLoader <Model>k__BackingField; // 0x28
	FairyGUI.GButton <Switch>k__BackingField; // 0x30
	FairyGUI.GImage <SaveIcon>k__BackingField; // 0x38
	FairyGUI.GComponent <ModelIcon>k__BackingField; // 0x40
	FairyGUI.GTextField <Text>k__BackingField; // 0x48
	FairyGUI.GProgressBar <ProgressBar>k__BackingField; // 0x50
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x58
	FairyGUI.Controller <CtrlDisplay>k__BackingField; // 0x60
	FairyGUI.GComponent get_BinderRoot(); // 0x0679d768
	FairyGUI.GList get_List(); // 0x0679d7cc
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComInfoPanelBinder get_InfoPanel(); // 0x0679d830
	FairyGUI.GButton get_Switch(); // 0x0679d894
	FairyGUI.GTextField get_Text(); // 0x0679d8f8
	FairyGUI.Controller get_CtrlStatus(); // 0x0679d95c
	FairyGUI.Controller get_CtrlDisplay(); // 0x0679d9c0
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679c338
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubSafeBoxBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Content>k__BackingField; // 0x18
	FairyGUI.GButton <BtnDisassemble>k__BackingField; // 0x20
	FairyGUI.GButton <BtnCantDisassemble>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlCtrlICanCloseSafeBox>k__BackingField; // 0x30
	FairyGUI.GComponent get_BinderRoot(); // 0x0679da24
	FairyGUI.GComponent get_Content(); // 0x0679da88
	FairyGUI.GButton get_BtnDisassemble(); // 0x0679daec
	FairyGUI.GButton get_BtnCantDisassemble(); // 0x0679db50
	FairyGUI.Controller get_CtrlCtrlICanCloseSafeBox(); // 0x0679dbb4
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679af60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubToolcupBoardBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <TouchRotate>k__BackingField; // 0x18
	FairyGUI.GButton <BtnPutAll>k__BackingField; // 0x20
	FairyGUI.GButton <BtnThreeHour>k__BackingField; // 0x28
	FairyGUI.GList <LstUpkeepItem>k__BackingField; // 0x30
	FairyGUI.GTextField <TxtCapturing>k__BackingField; // 0x38
	FairyGUI.GButton <BtnSurvive>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComLeftTimeBinder <ComLeftTime>k__BackingField; // 0x48
	FairyGUI.GTextField <TxtUpkeepState>k__BackingField; // 0x50
	FairyGUI.Controller <CtrlCtrlIsInKeep>k__BackingField; // 0x58
	FairyGUI.Controller <CtrlCtrlIsCapturing>k__BackingField; // 0x60
	FairyGUI.GComponent get_BinderRoot(); // 0x0679dc18
	FairyGUI.GButton get_BtnPutAll(); // 0x0679dc7c
	FairyGUI.GButton get_BtnThreeHour(); // 0x0679dce0
	FairyGUI.GList get_LstUpkeepItem(); // 0x0679dd44
	FairyGUI.GButton get_BtnSurvive(); // 0x0679dda8
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComLeftTimeBinder get_ComLeftTime(); // 0x0679de0c
	FairyGUI.GTextField get_TxtUpkeepState(); // 0x0679de70
	FairyGUI.Controller get_CtrlCtrlIsInKeep(); // 0x0679ded4
	FairyGUI.Controller get_CtrlCtrlIsCapturing(); // 0x0679df38
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679b0e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.UIConfirmBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.CoConfirmBinder <N1>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.CoConfirmBinder get_N1(); // 0x0679df9c
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679cc3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.UiSavePopBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComSavePopBinder <Root>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.ComSavePopBinder get_Root(); // 0x0679e000
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679cb38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.UiTerritoryCenterBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.RootTerritoryCenterBinder <Root>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.RootTerritoryCenterBinder get_Root(); // 0x0679e064
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679e0c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.UiTerritoryEditBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Bg>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.RootTerritoryEditBinder <Root>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlState>k__BackingField; // 0x28
	FairyGUI.GComponent get_Bg(); // 0x0679e1cc
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.RootTerritoryEditBinder get_Root(); // 0x0679e230
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679e294
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.UiTerritoryEditPopBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.RootUiTerritoryEditPopBinder <Root>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.RootUiTerritoryEditPopBinder get_Root(); // 0x0679e40c
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679e470
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComChangeNameBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <Btn>k__BackingField; // 0x18
	FairyGUI.GTextField <Title>k__BackingField; // 0x20
	FairyGUI.GTextField <Num>k__BackingField; // 0x28
	FairyGUI.GLabel <Title1>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlTitleStyle>k__BackingField; // 0x38
	FairyGUI.GButton get_Btn(); // 0x0679e574
	FairyGUI.GTextField get_Title(); // 0x0679e5d8
	FairyGUI.GTextField get_Num(); // 0x0679e63c
	FairyGUI.GLabel get_Title1(); // 0x0679e6a0
	FairyGUI.Controller get_CtrlTitleStyle(); // 0x0679e704
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679e768
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComInventoryOthersideToolBarBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <BtnPutInAll>k__BackingField; // 0x18
	FairyGUI.GButton <BtnBatchDrop>k__BackingField; // 0x20
	FairyGUI.GButton <BtnBatchMove>k__BackingField; // 0x28
	FairyGUI.GButton <BtnAllQuickLoot>k__BackingField; // 0x30
	FairyGUI.GButton <BtnOrganize>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComChangeNameBinder <ChangeName>k__BackingField; // 0x40
	FairyGUI.GButton <BtnAllQuickLoot2>k__BackingField; // 0x48
	FairyGUI.GButton <BtnBatchDrop2>k__BackingField; // 0x50
	FairyGUI.GButton <BtnOrganize2>k__BackingField; // 0x58
	FairyGUI.GButton <Select_all_btn>k__BackingField; // 0x60
	FairyGUI.GButton <BtnPutInAll2>k__BackingField; // 0x68
	FairyGUI.GButton <BtnQuickPutIn>k__BackingField; // 0x70
	FairyGUI.GLabel <Title>k__BackingField; // 0x78
	FairyGUI.GButton <BtnDetail>k__BackingField; // 0x80
	FairyGUI.GButton <BtnActive>k__BackingField; // 0x88
	FairyGUI.GButton <Btn_cancel>k__BackingField; // 0x90
	FairyGUI.GButton <Btn_batch_confirm>k__BackingField; // 0x98
	FairyGUI.GButton <AllPick>k__BackingField; // 0xa0
	FairyGUI.Controller <CtrlNewType>k__BackingField; // 0xa8
	FairyGUI.Controller <CtrlBtnState>k__BackingField; // 0xb0
	FairyGUI.Controller <CtrlTitleType>k__BackingField; // 0xb8
	FairyGUI.Controller <CtrlAllPickPos>k__BackingField; // 0xc0
	FairyGUI.Controller <CtrlPlatform>k__BackingField; // 0xc8
	FairyGUI.Controller <CtrlBatch_del_ctrl>k__BackingField; // 0xd0
	FairyGUI.GComponent get_BinderRoot(); // 0x0679e930
	FairyGUI.GButton get_BtnPutInAll(); // 0x0679e994
	FairyGUI.GButton get_BtnBatchDrop(); // 0x0679e9f8
	FairyGUI.GButton get_BtnBatchMove(); // 0x0679ea5c
	FairyGUI.GButton get_BtnAllQuickLoot(); // 0x0679eac0
	FairyGUI.GButton get_BtnOrganize(); // 0x0679eb24
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComChangeNameBinder get_ChangeName(); // 0x0679eb88
	FairyGUI.GButton get_BtnAllQuickLoot2(); // 0x0679ebec
	FairyGUI.GButton get_BtnBatchDrop2(); // 0x0679ec50
	FairyGUI.GButton get_BtnOrganize2(); // 0x0679ecb4
	FairyGUI.GButton get_Select_all_btn(); // 0x0679ed18
	FairyGUI.GButton get_BtnPutInAll2(); // 0x0679ed7c
	FairyGUI.GButton get_BtnQuickPutIn(); // 0x0679ede0
	FairyGUI.GLabel get_Title(); // 0x0679ee44
	FairyGUI.GButton get_BtnDetail(); // 0x0679eea8
	FairyGUI.GButton get_BtnActive(); // 0x0679ef0c
	FairyGUI.GButton get_Btn_cancel(); // 0x0679ef70
	FairyGUI.GButton get_Btn_batch_confirm(); // 0x0679efd4
	FairyGUI.GButton get_AllPick(); // 0x0679f038
	FairyGUI.Controller get_CtrlNewType(); // 0x0679f09c
	FairyGUI.Controller get_CtrlBtnState(); // 0x0679f100
	FairyGUI.Controller get_CtrlTitleType(); // 0x0679f164
	FairyGUI.Controller get_CtrlAllPickPos(); // 0x0679f1c8
	FairyGUI.Controller get_CtrlBatch_del_ctrl(); // 0x0679f22c
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679f290
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOtherSideDecomposerBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComResolventBinder <Resolvent>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOutputBinder <Output>k__BackingField; // 0x20
	FairyGUI.GButton <BtnSalvageBig>k__BackingField; // 0x28
	FairyGUI.GButton <BtnTake>k__BackingField; // 0x30
	FairyGUI.GButton <BtnStop>k__BackingField; // 0x38
	FairyGUI.GButton <BtnSalvageSmall>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlBtnToggle>k__BackingField; // 0x48
	FairyGUI.Controller <CtrlBtnSalvageState>k__BackingField; // 0x50
	FairyGUI.Transition <TransLoop>k__BackingField; // 0x58
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComResolventBinder get_Resolvent(); // 0x0679f90c
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOutputBinder get_Output(); // 0x0679f970
	FairyGUI.GButton get_BtnSalvageBig(); // 0x0679f9d4
	FairyGUI.GButton get_BtnTake(); // 0x0679fa38
	FairyGUI.GButton get_BtnStop(); // 0x0679fa9c
	FairyGUI.GButton get_BtnSalvageSmall(); // 0x0679fb00
	FairyGUI.Controller get_CtrlBtnToggle(); // 0x0679fb64
	FairyGUI.Controller get_CtrlBtnSalvageState(); // 0x0679fbc8
	FairyGUI.Transition get_TransLoop(); // 0x0679fc2c
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679fc90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOtherSideHitchPostBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <List>k__BackingField; // 0x18
	FairyGUI.GButton <QuickGetBtn>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlBtnToggle>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlBtnSalvageState>k__BackingField; // 0x30
	FairyGUI.GList get_List(); // 0x067a0330
	FairyGUI.GButton get_QuickGetBtn(); // 0x067a0394
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a03f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOtherSideInventoryItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <TitleMain>k__BackingField; // 0x18
	FairyGUI.GTextField <MainNum>k__BackingField; // 0x20
	FairyGUI.GList <ListMain>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOthersideInventoryMainSpringBinder <TitleExtend>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlState>k__BackingField; // 0x38
	FairyGUI.GLabel get_TitleMain(); // 0x067a0574
	FairyGUI.GTextField get_MainNum(); // 0x067a05d8
	FairyGUI.GList get_ListMain(); // 0x067a063c
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOthersideInventoryMainSpringBinder get_TitleExtend(); // 0x067a06a0
	FairyGUI.Controller get_CtrlState(); // 0x067a0704
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a0768
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOthersideInventoryMainSpringBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <N15>k__BackingField; // 0x18
	FairyGUI.GTextField get_N15(); // 0x067a0a34
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a0960
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOtherSideLockerItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <TitleMain>k__BackingField; // 0x18
	FairyGUI.GTextField <MainNum>k__BackingField; // 0x20
	FairyGUI.GList <ListMain>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOthersideInventoryMainSpringBinder <TitleExtend>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlState>k__BackingField; // 0x38
	FairyGUI.GLabel get_TitleMain(); // 0x067a0a98
	FairyGUI.GTextField get_MainNum(); // 0x067a0afc
	FairyGUI.GList get_ListMain(); // 0x067a0b60
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOthersideInventoryMainSpringBinder get_TitleExtend(); // 0x067a0bc4
	FairyGUI.Controller get_CtrlState(); // 0x067a0c28
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a0c8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOtherSideSafeBoxItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <TitleMain>k__BackingField; // 0x18
	FairyGUI.GTextField <MainNum>k__BackingField; // 0x20
	FairyGUI.GList <ListMain>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOthersideInventoryMainSpringBinder <TitleExtend>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlState>k__BackingField; // 0x38
	FairyGUI.GLabel get_TitleMain(); // 0x067a0e84
	FairyGUI.GTextField get_MainNum(); // 0x067a0ee8
	FairyGUI.GList get_ListMain(); // 0x067a0f4c
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOthersideInventoryMainSpringBinder get_TitleExtend(); // 0x067a0fb0
	FairyGUI.Controller get_CtrlState(); // 0x067a1014
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a1078
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOutputBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <BtnOutPut>k__BackingField; // 0x18
	FairyGUI.GList <Previewlist>k__BackingField; // 0x20
	FairyGUI.GButton <BtnPreView>k__BackingField; // 0x28
	FairyGUI.GList <Outputlist>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlOutputstatus>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlListCol>k__BackingField; // 0x48
	FairyGUI.GButton get_BtnOutPut(); // 0x067a1270
	FairyGUI.GList get_Previewlist(); // 0x067a12d4
	FairyGUI.GButton get_BtnPreView(); // 0x067a1338
	FairyGUI.GList get_Outputlist(); // 0x067a139c
	FairyGUI.Controller get_CtrlStatus(); // 0x067a1400
	FairyGUI.Controller get_CtrlOutputstatus(); // 0x067a1464
	FairyGUI.Controller get_CtrlListCol(); // 0x067a14c8
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a00a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComOutputItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Icon>k__BackingField; // 0x18
	FairyGUI.GImage <Progress>k__BackingField; // 0x20
	FairyGUI.GGroup <ProgressGroup>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlTransparency>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x38
	FairyGUI.Transition <TransSwitch>k__BackingField; // 0x40
	FairyGUI.GComponent get_Icon(); // 0x067a152c
	FairyGUI.GImage get_Progress(); // 0x067a1590
	FairyGUI.GGroup get_ProgressGroup(); // 0x067a15f4
	FairyGUI.Controller get_CtrlStatus(); // 0x067a1658
	FairyGUI.Transition get_TransSwitch(); // 0x067a16bc
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a1720
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOtherside.ComResolventBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <List>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlListCol>k__BackingField; // 0x20
	FairyGUI.GComponent get_BinderRoot(); // 0x067a1910
	FairyGUI.GList get_List(); // 0x067a1974
	FairyGUI.Controller get_CtrlListCol(); // 0x067a19d8
	System.Void .ctor(FairyGUI.GComponent root); // 0x0679ffa0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventory.ComSelectGfitBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComBackpackBinder <Backpack>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComBackpackBinder get_Backpack(); // 0x067a1a3c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a1aa0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameInventory.UiSelectGiftBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameInventory.ComSelectGfitBinder <Root>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameInventory.ComSelectGfitBinder get_Root(); // 0x067a1ba8
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a1c0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ComInteractiveBtnBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ComInteractiveBtnContentBinder <Content>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlSelect>k__BackingField; // 0x20
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x28
	FairyGUI.GComponent get_BinderRoot(); // 0x067a1d10
	WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ComInteractiveBtnContentBinder get_Content(); // 0x067a1d74
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a1dd8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ComInteractiveBtnContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Bg>k__BackingField; // 0x18
	FairyGUI.GComponent <Cd>k__BackingField; // 0x20
	FairyGUI.GRichTextField <Name>k__BackingField; // 0x28
	FairyGUI.GLoader <Icon>k__BackingField; // 0x30
	FairyGUI.GButton <BtnJumpToHorseFood>k__BackingField; // 0x38
	FairyGUI.GTextField <TextNum>k__BackingField; // 0x40
	FairyGUI.GTextField <TextWater>k__BackingField; // 0x48
	FairyGUI.GComponent <MatList>k__BackingField; // 0x50
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x58
	FairyGUI.Controller <CtrlType>k__BackingField; // 0x60
	FairyGUI.Controller <CtrlSelect>k__BackingField; // 0x68
	FairyGUI.Transition <TransSwitch_select_true>k__BackingField; // 0x70
	FairyGUI.Transition <TransShow>k__BackingField; // 0x78
	FairyGUI.GComponent get_BinderRoot(); // 0x067a22dc
	FairyGUI.GRichTextField get_Name(); // 0x067a2340
	FairyGUI.GLoader get_Icon(); // 0x067a23a4
	FairyGUI.GButton get_BtnJumpToHorseFood(); // 0x067a2408
	FairyGUI.GTextField get_TextNum(); // 0x067a246c
	FairyGUI.Transition get_TransShow(); // 0x067a24d0
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a1f44
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ComInteractiveListBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <InteractiveBtnList>k__BackingField; // 0x18
	FairyGUI.Transition <TransAppear>k__BackingField; // 0x20
	FairyGUI.GComponent get_BinderRoot(); // 0x067a2534
	FairyGUI.GList get_InteractiveBtnList(); // 0x067a2598
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a25fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ComItemBtnBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ComItemBtnContentBinder <Content>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlSelect>k__BackingField; // 0x20
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x28
	FairyGUI.GComponent get_BinderRoot(); // 0x067a2704
	WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ComItemBtnContentBinder get_Content(); // 0x067a2768
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a27cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ComItemBtnContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <ItemIcon>k__BackingField; // 0x18
	FairyGUI.GTextField <Name>k__BackingField; // 0x20
	FairyGUI.GButton <BtnQuickUse>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlUseState>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlSelect>k__BackingField; // 0x40
	FairyGUI.Transition <TransSwitch_select_true>k__BackingField; // 0x48
	FairyGUI.Transition <TransShow>k__BackingField; // 0x50
	FairyGUI.Transition <TransMove>k__BackingField; // 0x58
	FairyGUI.GComponent get_BinderRoot(); // 0x067a2bc4
	FairyGUI.GComponent get_ItemIcon(); // 0x067a2c28
	FairyGUI.GTextField get_Name(); // 0x067a2c8c
	FairyGUI.GButton get_BtnQuickUse(); // 0x067a2cf0
	FairyGUI.Controller get_CtrlUseState(); // 0x067a2d54
	FairyGUI.Transition get_TransShow(); // 0x067a2db8
	FairyGUI.Transition get_TransMove(); // 0x067a2e1c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a2938
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ComPickItemListBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <ItemBtnListDefault>k__BackingField; // 0x18
	FairyGUI.Transition <TransAppear>k__BackingField; // 0x20
	FairyGUI.GList get_ItemBtnListDefault(); // 0x067a2e80
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a2ee4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ElemInteractiveListBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Name>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ComInteractiveListBinder <InteractiveList>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ComPickItemListBinder <Picklist>k__BackingField; // 0x28
	FairyGUI.GList <KeyTipsList>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlState>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlItemCount>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlMode>k__BackingField; // 0x48
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x50
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x58
	FairyGUI.GComponent get_BinderRoot(); // 0x067a3044
	FairyGUI.GTextField get_Name(); // 0x067a30a8
	WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ComInteractiveListBinder get_InteractiveList(); // 0x067a310c
	WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ComPickItemListBinder get_Picklist(); // 0x067a3170
	FairyGUI.GList get_KeyTipsList(); // 0x067a31d4
	FairyGUI.Controller get_CtrlState(); // 0x067a3238
	FairyGUI.Controller get_CtrlItemCount(); // 0x067a329c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a3300
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.RootInteractiveListBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GGraph <BgClose>k__BackingField; // 0x18
	FairyGUI.GGraph <HideArea>k__BackingField; // 0x20
	FairyGUI.GComponent <InteractiveList>k__BackingField; // 0x28
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x30
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x38
	FairyGUI.GGraph get_BgClose(); // 0x067a3650
	FairyGUI.GGraph get_HideArea(); // 0x067a36b4
	FairyGUI.GComponent get_InteractiveList(); // 0x067a3718
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a377c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHudElemVehicleStatus.ComVehicleValueBarBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GImage <FuelBg1>k__BackingField; // 0x18
	FairyGUI.GGraph <FuelBg2>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlPercent>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlType>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlIsHorseFuel>k__BackingField; // 0x38
	FairyGUI.GComponent get_BinderRoot(); // 0x067a3938
	FairyGUI.GImage get_FuelBg1(); // 0x067a399c
	FairyGUI.GGraph get_FuelBg2(); // 0x067a3a00
	FairyGUI.Controller get_CtrlPercent(); // 0x067a3a64
	FairyGUI.Controller get_CtrlIsHorseFuel(); // 0x067a3ac8
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a3b2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHudElemVehicleStatus.ElemVehicleStatusBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameHudElemVehicleStatus.ComVehicleValueBarBinder <HpBar>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameHudElemVehicleStatus.ComVehicleValueBarBinder <FuelBar>k__BackingField; // 0x20
	FairyGUI.GComponent get_BinderRoot(); // 0x067a3cdc
	WizardGames.Soc.SocClient.Ui.Binder.GameHudElemVehicleStatus.ComVehicleValueBarBinder get_HpBar(); // 0x067a3d40
	WizardGames.Soc.SocClient.Ui.Binder.GameHudElemVehicleStatus.ComVehicleValueBarBinder get_FuelBar(); // 0x067a3da4
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a3e08
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHudElemLeftTab.ElemMissionTabNewBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Mission>k__BackingField; // 0x18
	FairyGUI.GLoader <Story>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameHud.ElemTrackMissionBinder <ComMission>k__BackingField; // 0x28
	FairyGUI.GButton <BtnExpand>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlExpand>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlShowSpecialMission>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlPlatform>k__BackingField; // 0x48
	FairyGUI.Transition <TransFoldAnim>k__BackingField; // 0x50
	FairyGUI.Transition <TransExpandAnim>k__BackingField; // 0x58
	FairyGUI.GLoader get_Mission(); // 0x067a3f68
	FairyGUI.GLoader get_Story(); // 0x067a3fcc
	WizardGames.Soc.SocClient.Ui.Binder.GameHud.ElemTrackMissionBinder get_ComMission(); // 0x067a4030
	FairyGUI.GButton get_BtnExpand(); // 0x067a4094
	FairyGUI.Controller get_CtrlExpand(); // 0x067a40f8
	FairyGUI.Controller get_CtrlShowSpecialMission(); // 0x067a415c
	FairyGUI.Controller get_CtrlPlatform(); // 0x067a41c0
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a4224
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud.BtnHudAidBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.Controller <CtrlAidStyle>k__BackingField; // 0x18
	FairyGUI.GComponent get_BinderRoot(); // 0x067a4600
	FairyGUI.Controller get_CtrlAidStyle(); // 0x067a4664
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a46c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud.BtnQuickChatBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GImage <BtnBg>k__BackingField; // 0x18
	FairyGUI.GImage <CD>k__BackingField; // 0x20
	FairyGUI.GComponent <ComMsgList>k__BackingField; // 0x28
	FairyGUI.GButton <EmptyBtn>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x40
	FairyGUI.GComponent get_BinderRoot(); // 0x067a4790
	FairyGUI.GImage get_CD(); // 0x067a47f4
	FairyGUI.GComponent get_ComMsgList(); // 0x067a4858
	FairyGUI.GButton get_EmptyBtn(); // 0x067a48bc
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a4920
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud.ComMenuChooseItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Loader>k__BackingField; // 0x18
	FairyGUI.GImage <Choose>k__BackingField; // 0x20
	FairyGUI.GComponent get_Loader(); // 0x067a4b1c
	FairyGUI.GImage get_Choose(); // 0x067a4b80
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a4be4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud.ComMoveViewRootBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GGraph <Area>k__BackingField; // 0x18
	FairyGUI.GGraph <Touch>k__BackingField; // 0x20
	FairyGUI.GGraph <GraphForbidMoveView1>k__BackingField; // 0x28
	FairyGUI.GGraph <GraphForbidMoveView2>k__BackingField; // 0x30
	FairyGUI.GGraph get_Area(); // 0x067a4cf8
	FairyGUI.GGraph get_Touch(); // 0x067a4d5c
	FairyGUI.GGraph get_GraphForbidMoveView1(); // 0x067a4dc0
	FairyGUI.GGraph get_GraphForbidMoveView2(); // 0x067a4e24
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a4e88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud.ComQuickChatBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <PresetList>k__BackingField; // 0x18
	FairyGUI.GList <TabList>k__BackingField; // 0x20
	FairyGUI.GGroup <TabGroup>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlPresetsPanel>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlEditctrl>k__BackingField; // 0x38
	FairyGUI.Transition <TransPresetsFadeOut>k__BackingField; // 0x40
	FairyGUI.Transition <TransPresetsFadeIn>k__BackingField; // 0x48
	FairyGUI.GComponent get_BinderRoot(); // 0x067a501c
	FairyGUI.GList get_PresetList(); // 0x067a5080
	FairyGUI.GList get_TabList(); // 0x067a50e4
	FairyGUI.Controller get_CtrlPresetsPanel(); // 0x067a5148
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a51ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud.ComQuickChatBubbleBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <RotateNode>k__BackingField; // 0x18
	FairyGUI.GTextField <Name>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlIs_it>k__BackingField; // 0x28
	FairyGUI.Transition <TransShow>k__BackingField; // 0x30
	FairyGUI.GComponent get_RotateNode(); // 0x067a53d0
	FairyGUI.GTextField get_Name(); // 0x067a5434
	FairyGUI.Controller get_CtrlIs_it(); // 0x067a5498
	FairyGUI.Transition get_TransShow(); // 0x067a54fc
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a5560
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud.ComQuickChatMsgListBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <MsgList>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlPresetsPanel>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlEditctrl>k__BackingField; // 0x28
	FairyGUI.Transition <TransMessageFadeOut>k__BackingField; // 0x30
	FairyGUI.Transition <TransMessageFadeIn>k__BackingField; // 0x38
	FairyGUI.GList get_MsgList(); // 0x067a56dc
	FairyGUI.Transition get_TransMessageFadeOut(); // 0x067a5740
	FairyGUI.Transition get_TransMessageFadeIn(); // 0x067a57a4
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a5808
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud.ElemCombatMarkerBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Bg>k__BackingField; // 0x18
	FairyGUI.GComponent <Roulette>k__BackingField; // 0x20
	FairyGUI.GLoader <Icon>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlBtnStyle>k__BackingField; // 0x30
	FairyGUI.Transition <TransChange>k__BackingField; // 0x38
	FairyGUI.Transition <TransSwitch_01>k__BackingField; // 0x40
	FairyGUI.GComponent get_Roulette(); // 0x067a5a04
	FairyGUI.GLoader get_Icon(); // 0x067a5a68
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a5acc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud.ElemCommonBtn1Binder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Icon>k__BackingField; // 0x18
	FairyGUI.GTextField <Time>k__BackingField; // 0x20
	FairyGUI.GTextField <Title>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlEditctrl>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlShowTime>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlShowTitle>k__BackingField; // 0x48
	FairyGUI.Controller <CtrlState>k__BackingField; // 0x50
	FairyGUI.Transition <TransShow>k__BackingField; // 0x58
	FairyGUI.Transition <TransLoop>k__BackingField; // 0x60
	FairyGUI.GComponent get_BinderRoot(); // 0x067a5cbc
	FairyGUI.GTextField get_Time(); // 0x067a5d20
	FairyGUI.Controller get_CtrlShowTime(); // 0x067a5d84
	FairyGUI.Controller get_CtrlShowTitle(); // 0x067a5de8
	FairyGUI.Controller get_CtrlState(); // 0x067a5e4c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a5eb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud.ElemPlayerMsgBoxBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GImage <Bg>k__BackingField; // 0x18
	FairyGUI.GLoader <IconBg>k__BackingField; // 0x20
	FairyGUI.GLoader <Icon>k__BackingField; // 0x28
	FairyGUI.GTextField <Data_text>k__BackingField; // 0x30
	FairyGUI.GGroup <Layout>k__BackingField; // 0x38
	FairyGUI.GButton <Button>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlStyle>k__BackingField; // 0x48
	FairyGUI.Transition <TransFlashing>k__BackingField; // 0x50
	FairyGUI.Transition <TransDisappear>k__BackingField; // 0x58
	FairyGUI.Transition <TransAppear>k__BackingField; // 0x60
	FairyGUI.Transition <TransAppeared>k__BackingField; // 0x68
	FairyGUI.GComponent get_BinderRoot(); // 0x067a6170
	FairyGUI.GImage get_Bg(); // 0x067a61d4
	FairyGUI.GLoader get_IconBg(); // 0x067a6238
	FairyGUI.GLoader get_Icon(); // 0x067a629c
	FairyGUI.GTextField get_Data_text(); // 0x067a6300
	FairyGUI.GGroup get_Layout(); // 0x067a6364
	FairyGUI.GButton get_Button(); // 0x067a63c8
	FairyGUI.Controller get_CtrlStyle(); // 0x067a642c
	FairyGUI.Transition get_TransDisappear(); // 0x067a6490
	FairyGUI.Transition get_TransAppear(); // 0x067a64f4
	FairyGUI.Transition get_TransAppeared(); // 0x067a6558
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a65bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud.ElemQuickActionBubbleBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <Btn>k__BackingField; // 0x18
	FairyGUI.Transition <TransShow>k__BackingField; // 0x20
	FairyGUI.GButton get_Btn(); // 0x067a68d4
	FairyGUI.Transition get_TransShow(); // 0x067a6938
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a699c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud.ElemReloadBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GImage <Bg>k__BackingField; // 0x18
	FairyGUI.GImage <Img_progress>k__BackingField; // 0x20
	FairyGUI.GComponent <Roulette>k__BackingField; // 0x28
	FairyGUI.GLoader <Icon>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlEditctrl>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlOptionCtrl>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlIconStatus>k__BackingField; // 0x48
	FairyGUI.GComponent get_Roulette(); // 0x067a6aa4
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a6b08
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud.ElemTrackMissionBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <List>k__BackingField; // 0x18
	FairyGUI.GLoader <Guide>k__BackingField; // 0x20
	FairyGUI.GList get_List(); // 0x067a6d38
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a44ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud.ElemTriggerBtnBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <Btn>k__BackingField; // 0x18
	FairyGUI.GButton get_Btn(); // 0x067a6d9c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a6e00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud.HudCountDownBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComCountdownBinder <Countdown>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComCountdownBinder get_Countdown(); // 0x067a6ed4
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a6f38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameHud.UiMoveViewBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameHud.ComMoveViewRootBinder <Root>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameHud.ComMoveViewRootBinder get_Root(); // 0x067a7040
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a70a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComForceMissionBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComWranTipBinder <WarnTip>k__BackingField; // 0x18
	FairyGUI.GTextField <Title>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComSurplusBinder <Surplus>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComTextBinder <Text>k__BackingField; // 0x30
	FairyGUI.GList <GoaltList>k__BackingField; // 0x38
	FairyGUI.GList <RewardsList>k__BackingField; // 0x40
	FairyGUI.GButton <BtnReceive>k__BackingField; // 0x48
	FairyGUI.GButton <BtnGet>k__BackingField; // 0x50
	FairyGUI.GButton <BtnJump>k__BackingField; // 0x58
	FairyGUI.GTextField <N20>k__BackingField; // 0x60
	FairyGUI.Controller <CtrlTag>k__BackingField; // 0x68
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x70
	FairyGUI.Controller <CtrlBtnStatus>k__BackingField; // 0x78
	FairyGUI.Controller <CtrlTips>k__BackingField; // 0x80
	FairyGUI.GComponent get_BinderRoot(); // 0x067a71a8
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComWranTipBinder get_WarnTip(); // 0x067a720c
	FairyGUI.GTextField get_Title(); // 0x067a7270
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComSurplusBinder get_Surplus(); // 0x067a72d4
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComTextBinder get_Text(); // 0x067a7338
	FairyGUI.GList get_GoaltList(); // 0x067a739c
	FairyGUI.GList get_RewardsList(); // 0x067a7400
	FairyGUI.GButton get_BtnReceive(); // 0x067a7464
	FairyGUI.GButton get_BtnGet(); // 0x067a74c8
	FairyGUI.GButton get_BtnJump(); // 0x067a752c
	FairyGUI.GTextField get_N20(); // 0x067a7590
	FairyGUI.Controller get_CtrlTag(); // 0x067a75f4
	FairyGUI.Controller get_CtrlStatus(); // 0x067a7658
	FairyGUI.Controller get_CtrlBtnStatus(); // 0x067a76bc
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a7720
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.CompPowerExperienceBarBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GProgressBar <ProgressBar>k__BackingField; // 0x18
	FairyGUI.GRichTextField <Level>k__BackingField; // 0x20
	FairyGUI.GProgressBar get_ProgressBar(); // 0x067a7e5c
	FairyGUI.GRichTextField get_Level(); // 0x067a7ec0
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a7f24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComQuestItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <List>k__BackingField; // 0x18
	FairyGUI.GComponent <SwitchTask>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.CompPowerExperienceBarBinder <Power>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComForceMissionBinder <ForceMission>k__BackingField; // 0x30
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComUpperLimitBinder <Exp>k__BackingField; // 0x38
	FairyGUI.GTextField <Text>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x48
	FairyGUI.Controller <CtrlItemStatus>k__BackingField; // 0x50
	FairyGUI.GList get_List(); // 0x067a8038
	FairyGUI.GComponent get_SwitchTask(); // 0x067a809c
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.CompPowerExperienceBarBinder get_Power(); // 0x067a8100
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComForceMissionBinder get_ForceMission(); // 0x067a8164
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComUpperLimitBinder get_Exp(); // 0x067a81c8
	FairyGUI.GTextField get_Text(); // 0x067a822c
	FairyGUI.Controller get_CtrlStatus(); // 0x067a8290
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a82f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComSurplusBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Text>k__BackingField; // 0x18
	FairyGUI.GTextField get_Text(); // 0x067a87c8
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a7cb4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComSwitchPowerContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <List>k__BackingField; // 0x18
	FairyGUI.GTextField <Title>k__BackingField; // 0x20
	FairyGUI.GList get_List(); // 0x067a882c
	FairyGUI.GTextField get_Title(); // 0x067a8890
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a88f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComSwitchPowerItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Icon>k__BackingField; // 0x18
	FairyGUI.GComponent <RedDot>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlLock>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x38
	FairyGUI.GComponent get_RedDot(); // 0x067a8a08
	FairyGUI.Controller get_CtrlLock(); // 0x067a8a6c
	FairyGUI.Controller get_CtrlStatus(); // 0x067a8ad0
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a8b34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComSwitchPowerRootBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComSwitchPowerContentBinder <Content>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComSwitchPowerContentBinder get_Content(); // 0x067a8ce4
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a8d48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComTextBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Text01>k__BackingField; // 0x18
	FairyGUI.GTextField get_Text01(); // 0x067a8e4c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a7d88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComUpperLimitBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.TagLevelBinder <Level>k__BackingField; // 0x18
	FairyGUI.GTextField <Number>k__BackingField; // 0x20
	FairyGUI.GProgressBar <Progress>k__BackingField; // 0x28
	FairyGUI.GButton <DetailBtn>k__BackingField; // 0x30
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.TagLevelBinder get_Level(); // 0x067a8eb0
	FairyGUI.GTextField get_Number(); // 0x067a8f14
	FairyGUI.GProgressBar get_Progress(); // 0x067a8f78
	FairyGUI.GButton get_DetailBtn(); // 0x067a8fdc
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a8600
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComWranTipBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.Controller <CtrlWarn>k__BackingField; // 0x18
	FairyGUI.Controller get_CtrlWarn(); // 0x067a9040
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a7bec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ForceMissionRootBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <NavBar>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComQuestItemBinder <Content>k__BackingField; // 0x20
	FairyGUI.GLabel <TopBar>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComQuestItemBinder get_Content(); // 0x067a90a4
	FairyGUI.GLabel get_TopBar(); // 0x067a9108
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a916c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.UiComSwitchPowerBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComSwitchPowerRootBinder <Root>k__BackingField; // 0x18
	FairyGUI.GComponent get_BinderRoot(); // 0x067a92f0
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ComSwitchPowerRootBinder get_Root(); // 0x067a9354
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a93b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.UiForceMissionBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComForceMissionBgBinder <Bg>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ForceMissionRootBinder <Root>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComForceMissionBgBinder get_Bg(); // 0x067a94bc
	WizardGames.Soc.SocClient.Ui.Binder.GameForceMission.ForceMissionRootBinder get_Root(); // 0x067a9520
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a9584
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameForceChooseFullPop.ComForceChooseFullPopBacBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <PicBac>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlBacStyle>k__BackingField; // 0x20
	FairyGUI.GLoader get_PicBac(); // 0x067a96fc
	FairyGUI.Controller get_CtrlBacStyle(); // 0x067a9760
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a97c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameForceChooseFullPop.ComForceChooseFullPopRootBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <MainTitle>k__BackingField; // 0x18
	FairyGUI.GGraph <SubLabelBac>k__BackingField; // 0x20
	FairyGUI.GTextField <SubLabel>k__BackingField; // 0x28
	FairyGUI.GTextField <SubTitle>k__BackingField; // 0x30
	FairyGUI.GTextField <Content>k__BackingField; // 0x38
	FairyGUI.GTextField <Tips>k__BackingField; // 0x40
	FairyGUI.GButton <GlitchConfig>k__BackingField; // 0x48
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x50
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x58
	FairyGUI.GButton <SkipBtn>k__BackingField; // 0x60
	FairyGUI.GLabel get_MainTitle(); // 0x067a98cc
	FairyGUI.GGraph get_SubLabelBac(); // 0x067a9930
	FairyGUI.GTextField get_SubLabel(); // 0x067a9994
	FairyGUI.GTextField get_SubTitle(); // 0x067a99f8
	FairyGUI.GTextField get_Content(); // 0x067a9a5c
	FairyGUI.GTextField get_Tips(); // 0x067a9ac0
	FairyGUI.GButton get_GlitchConfig(); // 0x067a9b24
	FairyGUI.Transition get_TransShow_anim(); // 0x067a9b88
	FairyGUI.GButton get_SkipBtn(); // 0x067a9bec
	System.Void .ctor(FairyGUI.GComponent root); // 0x067a9c50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameForceChooseFullPop.UiForceChooseFullPopBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameForceChooseFullPop.ComForceChooseFullPopBacBinder <Bg>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameForceChooseFullPop.ComForceChooseFullPopRootBinder <Root>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameForceChooseFullPop.ComForceChooseFullPopBacBinder get_Bg(); // 0x067a9f4c
	WizardGames.Soc.SocClient.Ui.Binder.GameForceChooseFullPop.ComForceChooseFullPopRootBinder get_Root(); // 0x067a9fb0
	System.Void .ctor(FairyGUI.GComponent root); // 0x067aa014
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameForce.ComForceListBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <List>k__BackingField; // 0x18
	FairyGUI.GLoader <Icon>k__BackingField; // 0x20
	FairyGUI.GButton <TalentBtn>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x30
	FairyGUI.GList get_List(); // 0x067aa188
	FairyGUI.GLoader get_Icon(); // 0x067aa1ec
	FairyGUI.GButton get_TalentBtn(); // 0x067aa250
	FairyGUI.Controller get_CtrlStatus(); // 0x067aa2b4
	System.Void .ctor(FairyGUI.GComponent root); // 0x067aa318
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameForce.ComForceRootBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameForce.ComForceListBinder <Content>k__BackingField; // 0x18
	FairyGUI.GLabel <TopBar>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameForce.ComForceListBinder get_Content(); // 0x067aa4a0
	FairyGUI.GLabel get_TopBar(); // 0x067aa504
	System.Void .ctor(FairyGUI.GComponent root); // 0x067aa568
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameForce.UiForceBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameForce.ComForceRootBinder <Root>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameForce.ComForceRootBinder get_Root(); // 0x067aa6ac
	System.Void .ctor(FairyGUI.GComponent root); // 0x067aa710
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameDialog.eff_iconBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Icon>k__BackingField; // 0x18
	FairyGUI.GLoader get_Icon(); // 0x067aa814
	System.Void .ctor(FairyGUI.GComponent root); // 0x067aa878
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameDialog.RootGameDialogBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameDialog.RootGameDialogContentBinder <Content>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameDialog.RootGameDialogContentBinder get_Content(); // 0x067aa94c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067aa9b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameDialog.RootGameDialogContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameDialog.eff_iconBinder <Icon>k__BackingField; // 0x18
	FairyGUI.GTextField <Name>k__BackingField; // 0x20
	FairyGUI.GTextField <Desc>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.GameDialog.eff_iconBinder get_Icon(); // 0x067aac38
	FairyGUI.GTextField get_Name(); // 0x067aac9c
	FairyGUI.GTextField get_Desc(); // 0x067aad00
	System.Void .ctor(FairyGUI.GComponent root); // 0x067aaab4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameDialog.UiGameDialogBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameDialog.RootGameDialogBinder <Root>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameDialog.RootGameDialogBinder get_Root(); // 0x067aad64
	System.Void .ctor(FairyGUI.GComponent root); // 0x067aadc8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameCraft.ComRecipeQueueBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Icon>k__BackingField; // 0x18
	FairyGUI.GProgressBar <Progress>k__BackingField; // 0x20
	FairyGUI.GTextField <Countdown>k__BackingField; // 0x28
	FairyGUI.GButton <ToHead>k__BackingField; // 0x30
	FairyGUI.GButton <Cancel>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x40
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x48
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x50
	FairyGUI.Transition <TransDelete>k__BackingField; // 0x58
	FairyGUI.Transition <TransJoin>k__BackingField; // 0x60
	FairyGUI.Transition <TransInitial>k__BackingField; // 0x68
	FairyGUI.Transition <TransMove>k__BackingField; // 0x70
	FairyGUI.Transition <TransSwitch>k__BackingField; // 0x78
	FairyGUI.Transition <TransComplete>k__BackingField; // 0x80
	FairyGUI.Transition <TransMove2>k__BackingField; // 0x88
	FairyGUI.Transition <TransOutput_loop>k__BackingField; // 0x90
	FairyGUI.GComponent get_Icon(); // 0x067aaecc
	FairyGUI.GProgressBar get_Progress(); // 0x067aaf30
	FairyGUI.GTextField get_Countdown(); // 0x067aaf94
	FairyGUI.GButton get_Cancel(); // 0x067aaff8
	FairyGUI.Controller get_CtrlStatus(); // 0x067ab05c
	FairyGUI.Transition get_TransDelete(); // 0x067ab0c0
	FairyGUI.Transition get_TransJoin(); // 0x067ab124
	FairyGUI.Transition get_TransInitial(); // 0x067ab188
	FairyGUI.Transition get_TransMove(); // 0x067ab1ec
	System.Void .ctor(FairyGUI.GComponent root); // 0x067ab250
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameConsole.BtnConsoleBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Icon>k__BackingField; // 0x18
	FairyGUI.GTextField <Title>k__BackingField; // 0x20
	FairyGUI.GTextField <Time>k__BackingField; // 0x28
	FairyGUI.GComponent <RedDot>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlShowTime>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlLock>k__BackingField; // 0x48
	FairyGUI.Controller <CtrlLanguage>k__BackingField; // 0x50
	FairyGUI.GComponent get_BinderRoot(); // 0x067ab660
	FairyGUI.GLoader get_Icon(); // 0x067ab6c4
	FairyGUI.GTextField get_Title(); // 0x067ab728
	FairyGUI.GComponent get_RedDot(); // 0x067ab78c
	FairyGUI.Controller get_CtrlShowTime(); // 0x067ab7f0
	System.Void .ctor(FairyGUI.GComponent root); // 0x067ab854
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameConsole.ComConsoleIntelBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Title>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameConsole.ComConsoleIntelTitleBinder <IntelComTtile>k__BackingField; // 0x20
	FairyGUI.GComponent <RedDot>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlLock>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x40
	FairyGUI.Transition <TransScrollRTL>k__BackingField; // 0x48
	FairyGUI.Transition <TransLoop>k__BackingField; // 0x50
	FairyGUI.GComponent get_BinderRoot(); // 0x067abab8
	WizardGames.Soc.SocClient.Ui.Binder.GameConsole.ComConsoleIntelTitleBinder get_IntelComTtile(); // 0x067abb1c
	FairyGUI.GComponent get_RedDot(); // 0x067abb80
	FairyGUI.Controller get_CtrlStatus(); // 0x067abbe4
	System.Void .ctor(FairyGUI.GComponent root); // 0x067abc48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameConsole.ComConsoleIntelTitleBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Level>k__BackingField; // 0x18
	FairyGUI.GTextField <Time>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x28
	FairyGUI.GTextField get_Level(); // 0x067ac018
	FairyGUI.GTextField get_Time(); // 0x067ac07c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067abed0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameConsole.ComConsoleScreenPlayBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Title>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameConsole.ComConsoleScreenPlayTitleBinder <StoryComTitle>k__BackingField; // 0x20
	FairyGUI.GComponent <RedDot>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlLock>k__BackingField; // 0x38
	FairyGUI.Transition <TransScrollRTL>k__BackingField; // 0x40
	FairyGUI.GComponent get_BinderRoot(); // 0x067ac0e0
	WizardGames.Soc.SocClient.Ui.Binder.GameConsole.ComConsoleScreenPlayTitleBinder get_StoryComTitle(); // 0x067ac144
	FairyGUI.GComponent get_RedDot(); // 0x067ac1a8
	System.Void .ctor(FairyGUI.GComponent root); // 0x067ac20c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameConsole.ComConsoleScreenPlayTitleBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Title>k__BackingField; // 0x18
	FairyGUI.GTextField <Num>k__BackingField; // 0x20
	FairyGUI.GTextField <Time>k__BackingField; // 0x28
	FairyGUI.GTextField get_Title(); // 0x067ac580
	FairyGUI.GTextField get_Num(); // 0x067ac5e4
	FairyGUI.GTextField get_Time(); // 0x067ac648
	System.Void .ctor(FairyGUI.GComponent root); // 0x067ac42c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameConsole.ListItemConsoleGroupNEWBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <ListTitle>k__BackingField; // 0x18
	FairyGUI.GList <ConsoleBtnList>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlC1>k__BackingField; // 0x28
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x30
	FairyGUI.GLabel get_ListTitle(); // 0x067ac6ac
	FairyGUI.GList get_ConsoleBtnList(); // 0x067ac710
	System.Void .ctor(FairyGUI.GComponent root); // 0x067ac774
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameConsole.ListItemNormalBtnBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Title>k__BackingField; // 0x18
	FairyGUI.GLoader <Icon>k__BackingField; // 0x20
	FairyGUI.GComponent <RedDot>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlLock>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x38
	FairyGUI.Transition <TransLoop>k__BackingField; // 0x40
	FairyGUI.GComponent get_BinderRoot(); // 0x067ac8f0
	FairyGUI.GTextField get_Title(); // 0x067ac954
	FairyGUI.GLoader get_Icon(); // 0x067ac9b8
	FairyGUI.GComponent get_RedDot(); // 0x067aca1c
	FairyGUI.Transition get_TransLoop(); // 0x067aca80
	System.Void .ctor(FairyGUI.GComponent root); // 0x067acae4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameConsole.RootCenterConsoleBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <CloseBtn>k__BackingField; // 0x18
	FairyGUI.GList <TopList>k__BackingField; // 0x20
	FairyGUI.GList <ConsoleGroupList>k__BackingField; // 0x28
	FairyGUI.GList <BottomList>k__BackingField; // 0x30
	FairyGUI.GList <BusinessBtnList>k__BackingField; // 0x38
	FairyGUI.GButton <RollPoster>k__BackingField; // 0x40
	FairyGUI.GButton <BtnSeasons>k__BackingField; // 0x48
	FairyGUI.GButton <BackHallBtn>k__BackingField; // 0x50
	FairyGUI.GButton <FirstRecharge>k__BackingField; // 0x58
	FairyGUI.GComponent <PlayerInfo>k__BackingField; // 0x60
	FairyGUI.GButton <ComIntel>k__BackingField; // 0x68
	FairyGUI.GButton <ComScreenPlay>k__BackingField; // 0x70
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComBtnListBinder <OptCom>k__BackingField; // 0x78
	FairyGUI.Controller <CtrlShowExitSelectionCom>k__BackingField; // 0x80
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x88
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x90
	FairyGUI.Transition <TransExitSelectionCom_show_anim>k__BackingField; // 0x98
	FairyGUI.Transition <TransExitSelectionCom_hide_anim>k__BackingField; // 0xa0
	FairyGUI.GComponent get_BinderRoot(); // 0x067accd4
	FairyGUI.GButton get_CloseBtn(); // 0x067acd38
	FairyGUI.GList get_TopList(); // 0x067acd9c
	FairyGUI.GList get_ConsoleGroupList(); // 0x067ace00
	FairyGUI.GList get_BottomList(); // 0x067ace64
	FairyGUI.GList get_BusinessBtnList(); // 0x067acec8
	FairyGUI.GButton get_RollPoster(); // 0x067acf2c
	FairyGUI.GButton get_BtnSeasons(); // 0x067acf90
	FairyGUI.GButton get_BackHallBtn(); // 0x067acff4
	FairyGUI.GButton get_FirstRecharge(); // 0x067ad058
	FairyGUI.GComponent get_PlayerInfo(); // 0x067ad0bc
	FairyGUI.GButton get_ComIntel(); // 0x067ad120
	FairyGUI.GButton get_ComScreenPlay(); // 0x067ad184
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComBtnListBinder get_OptCom(); // 0x067ad1e8
	FairyGUI.Controller get_CtrlShowExitSelectionCom(); // 0x067ad24c
	FairyGUI.Transition get_TransExitSelectionCom_show_anim(); // 0x067ad2b0
	FairyGUI.Transition get_TransExitSelectionCom_hide_anim(); // 0x067ad314
	System.Void .ctor(FairyGUI.GComponent root); // 0x067ad378
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameCommonLeftInfoTip.ComLeftInfoPopTipBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GProgressBar <Progress>k__BackingField; // 0x18
	FairyGUI.GTextField <Desc>k__BackingField; // 0x20
	FairyGUI.GTextField <Title>k__BackingField; // 0x28
	FairyGUI.GButton <LeftBtn>k__BackingField; // 0x30
	FairyGUI.GButton <RightBtn>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlPlatform>k__BackingField; // 0x40
	FairyGUI.GComponent get_BinderRoot(); // 0x067ad8dc
	FairyGUI.GProgressBar get_Progress(); // 0x067ad940
	FairyGUI.GTextField get_Desc(); // 0x067ad9a4
	FairyGUI.GTextField get_Title(); // 0x067ada08
	FairyGUI.GButton get_LeftBtn(); // 0x067ada6c
	FairyGUI.GButton get_RightBtn(); // 0x067adad0
	System.Void .ctor(FairyGUI.GComponent root); // 0x067adb34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameCommonLeftInfoTip.ComTeamInvitePopBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <HeadCom>k__BackingField; // 0x18
	FairyGUI.GButton <Refuse>k__BackingField; // 0x20
	FairyGUI.GButton <Accept>k__BackingField; // 0x28
	FairyGUI.GLabel <PlayerName>k__BackingField; // 0x30
	FairyGUI.GRichTextField <Mode>k__BackingField; // 0x38
	FairyGUI.GTextField <Source>k__BackingField; // 0x40
	FairyGUI.GTextField <TxtAppointTime>k__BackingField; // 0x48
	FairyGUI.GProgressBar <Progress>k__BackingField; // 0x50
	FairyGUI.Controller <CtrlAppointTimeStatus>k__BackingField; // 0x58
	FairyGUI.Controller <CtrlPlatform>k__BackingField; // 0x60
	FairyGUI.GComponent get_BinderRoot(); // 0x067add3c
	FairyGUI.GComponent get_HeadCom(); // 0x067adda0
	FairyGUI.GButton get_Refuse(); // 0x067ade04
	FairyGUI.GButton get_Accept(); // 0x067ade68
	FairyGUI.GLabel get_PlayerName(); // 0x067adecc
	FairyGUI.GRichTextField get_Mode(); // 0x067adf30
	FairyGUI.GTextField get_Source(); // 0x067adf94
	FairyGUI.GTextField get_TxtAppointTime(); // 0x067adff8
	FairyGUI.GProgressBar get_Progress(); // 0x067ae05c
	FairyGUI.Controller get_CtrlAppointTimeStatus(); // 0x067ae0c0
	System.Void .ctor(FairyGUI.GComponent root); // 0x067ae124
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameCommonLeftInfoTip.ComTrackMonumentMissionTipsBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GProgressBar <Progress>k__BackingField; // 0x18
	FairyGUI.GLoader <Cancel>k__BackingField; // 0x20
	FairyGUI.GLoader <Confirm>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlPlatform>k__BackingField; // 0x30
	FairyGUI.GComponent get_BinderRoot(); // 0x067ae420
	FairyGUI.GProgressBar get_Progress(); // 0x067ae484
	FairyGUI.GLoader get_Cancel(); // 0x067ae4e8
	FairyGUI.GLoader get_Confirm(); // 0x067ae54c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067ae5b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.BtnCategoryBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Title>k__BackingField; // 0x18
	FairyGUI.GComponent <RedDot>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x28
	FairyGUI.GComponent get_BinderRoot(); // 0x067ae738
	FairyGUI.GComponent get_RedDot(); // 0x067ae79c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067ae800
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.BtnChannelBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <RedDot>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlRed>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlChannelType>k__BackingField; // 0x30
	FairyGUI.GComponent get_RedDot(); // 0x067ae948
	System.Void .ctor(FairyGUI.GComponent root); // 0x067ae9ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.BtnChannel_InterestGroupBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.BtnChannel_InterestGroupTitleBinder <ExpandBtn>k__BackingField; // 0x18
	FairyGUI.GList <List>k__BackingField; // 0x20
	FairyGUI.GGroup <Group>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlGroupState>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlExpandBtn>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.BtnChannel_InterestGroupTitleBinder get_ExpandBtn(); // 0x067aeb1c
	FairyGUI.GList get_List(); // 0x067aeb80
	FairyGUI.GGroup get_Group(); // 0x067aebe4
	FairyGUI.Controller get_CtrlGroupState(); // 0x067aec48
	FairyGUI.Controller get_CtrlExpandBtn(); // 0x067aecac
	System.Void .ctor(FairyGUI.GComponent root); // 0x067aed10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.BtnChannel_InterestGroupItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Avatar>k__BackingField; // 0x18
	FairyGUI.GTextField <Name>k__BackingField; // 0x20
	FairyGUI.GTextField <Desc>k__BackingField; // 0x28
	FairyGUI.GComponent <RedDot>k__BackingField; // 0x30
	FairyGUI.GComponent <TagCom>k__BackingField; // 0x38
	FairyGUI.GImage <N30>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x48
	FairyGUI.Controller <CtrlRed>k__BackingField; // 0x50
	FairyGUI.Controller <CtrlTag>k__BackingField; // 0x58
	FairyGUI.GLoader get_Avatar(); // 0x067aeffc
	FairyGUI.GTextField get_Name(); // 0x067af060
	FairyGUI.GTextField get_Desc(); // 0x067af0c4
	FairyGUI.GComponent get_RedDot(); // 0x067af128
	FairyGUI.Controller get_CtrlRed(); // 0x067af18c
	FairyGUI.Controller get_CtrlTag(); // 0x067af1f0
	System.Void .ctor(FairyGUI.GComponent root); // 0x067af254
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.BtnChannel_InterestGroupTitleBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Title>k__BackingField; // 0x18
	FairyGUI.GTextField <Num>k__BackingField; // 0x20
	FairyGUI.GComponent get_BinderRoot(); // 0x067af504
	FairyGUI.GTextField get_Title(); // 0x067af568
	FairyGUI.GTextField get_Num(); // 0x067af5cc
	System.Void .ctor(FairyGUI.GComponent root); // 0x067aeee8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.BtnTeamBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Tips>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlShowTips>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x28
	FairyGUI.GComponent get_BinderRoot(); // 0x067af630
	FairyGUI.GTextField get_Tips(); // 0x067af694
	FairyGUI.Controller get_CtrlShowTips(); // 0x067af6f8
	System.Void .ctor(FairyGUI.GComponent root); // 0x067af75c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.ChatMainBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <BtnFrozen>k__BackingField; // 0x18
	FairyGUI.GTextField <TxtRelationship>k__BackingField; // 0x20
	FairyGUI.GTextField <TxtChannelName>k__BackingField; // 0x28
	FairyGUI.GList <ChatMainLst>k__BackingField; // 0x30
	FairyGUI.GButton <BtnPreMessage>k__BackingField; // 0x38
	FairyGUI.GButton <BtnNewTribeAnnouncement>k__BackingField; // 0x40
	FairyGUI.GButton <BtnNewMessage>k__BackingField; // 0x48
	FairyGUI.GGraph <HotField>k__BackingField; // 0x50
	FairyGUI.GButton <EmptyTips>k__BackingField; // 0x58
	FairyGUI.GButton <BtnTribe>k__BackingField; // 0x60
	FairyGUI.GButton <BtnNotDisturb>k__BackingField; // 0x68
	FairyGUI.GButton <BtnTribeAnnouncement>k__BackingField; // 0x70
	FairyGUI.GButton <BtnGonggaoMessage>k__BackingField; // 0x78
	FairyGUI.GButton <BtnFindFriend>k__BackingField; // 0x80
	FairyGUI.Controller <CtrlSelectChannel>k__BackingField; // 0x88
	FairyGUI.Controller <CtrlHavePreMessage>k__BackingField; // 0x90
	FairyGUI.Controller <CtrlHaveNewMessage>k__BackingField; // 0x98
	FairyGUI.Controller <CtrlEmptyInputMessage>k__BackingField; // 0xa0
	FairyGUI.Controller <CtrlTopMax>k__BackingField; // 0xa8
	FairyGUI.Controller <CtrlTribeFrozen>k__BackingField; // 0xb0
	FairyGUI.Controller <CtrlTribeDetail>k__BackingField; // 0xb8
	FairyGUI.Controller <CtrlGongaoMessage>k__BackingField; // 0xc0
	FairyGUI.Controller <CtrlHaveNewTribeAnnouncement>k__BackingField; // 0xc8
	FairyGUI.GButton get_BtnFrozen(); // 0x067af898
	FairyGUI.GTextField get_TxtRelationship(); // 0x067af8fc
	FairyGUI.GTextField get_TxtChannelName(); // 0x067af960
	FairyGUI.GList get_ChatMainLst(); // 0x067af9c4
	FairyGUI.GButton get_BtnPreMessage(); // 0x067afa28
	FairyGUI.GButton get_BtnNewTribeAnnouncement(); // 0x067afa8c
	FairyGUI.GButton get_BtnNewMessage(); // 0x067afaf0
	FairyGUI.GGraph get_HotField(); // 0x067afb54
	FairyGUI.GButton get_EmptyTips(); // 0x067afbb8
	FairyGUI.GButton get_BtnTribe(); // 0x067afc1c
	FairyGUI.GButton get_BtnNotDisturb(); // 0x067afc80
	FairyGUI.GButton get_BtnTribeAnnouncement(); // 0x067afce4
	FairyGUI.GButton get_BtnFindFriend(); // 0x067afd48
	FairyGUI.Controller get_CtrlSelectChannel(); // 0x067afdac
	FairyGUI.Controller get_CtrlHavePreMessage(); // 0x067afe10
	FairyGUI.Controller get_CtrlHaveNewMessage(); // 0x067afe74
	FairyGUI.Controller get_CtrlTopMax(); // 0x067afed8
	FairyGUI.Controller get_CtrlTribeFrozen(); // 0x067aff3c
	FairyGUI.Controller get_CtrlTribeDetail(); // 0x067affa0
	FairyGUI.Controller get_CtrlHaveNewTribeAnnouncement(); // 0x067b0004
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b0068
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.ChatMainMessageBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessageLeftBinder <LeftMessage>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessageRightBinder <RightMessage>k__BackingField; // 0x20
	FairyGUI.GGroup <Group>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlTime>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlPos>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessageLeftBinder get_LeftMessage(); // 0x067b06a8
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessageRightBinder get_RightMessage(); // 0x067b070c
	FairyGUI.GGroup get_Group(); // 0x067b0770
	FairyGUI.Controller get_CtrlPos(); // 0x067b07d4
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b0838
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComChannelListBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <ChannelLst>k__BackingField; // 0x18
	FairyGUI.GTextField <EmptyTips>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlEmpty>k__BackingField; // 0x28
	FairyGUI.GList get_ChannelLst(); // 0x067b1584
	FairyGUI.GTextField get_EmptyTips(); // 0x067b15e8
	FairyGUI.Controller get_CtrlEmpty(); // 0x067b164c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b16b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComChannelList_InterestBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <AddBtn>k__BackingField; // 0x18
	FairyGUI.GList <List>k__BackingField; // 0x20
	FairyGUI.GButton get_AddBtn(); // 0x067b1850
	FairyGUI.GList get_List(); // 0x067b18b4
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b1918
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComChatEmojiNewBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <EmojiList>k__BackingField; // 0x18
	FairyGUI.GList <ListEmoji_Small>k__BackingField; // 0x20
	FairyGUI.GList <ListEmojii_big>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlSice>k__BackingField; // 0x30
	FairyGUI.GList get_EmojiList(); // 0x067b1a2c
	FairyGUI.GList get_ListEmoji_Small(); // 0x067b1a90
	FairyGUI.GList get_ListEmojii_big(); // 0x067b1af4
	FairyGUI.Controller get_CtrlSice(); // 0x067b1b58
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b1bbc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComChatInputBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComChatInputBoxBinder <Input>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComCreatTeamPanelBinder <ComCreateTeamPanel>k__BackingField; // 0x20
	FairyGUI.GButton <TransitionBtn>k__BackingField; // 0x28
	FairyGUI.GButton <MemeBtn>k__BackingField; // 0x30
	FairyGUI.GButton <CreateTeamBtn>k__BackingField; // 0x38
	FairyGUI.GButton <BtnSendMessage>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComConvertBinder <VoiceNode>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComChatEmojiNewBinder <EmojiNode>k__BackingField; // 0x50
	FairyGUI.Controller <CtrlShowCreateTeam>k__BackingField; // 0x58
	FairyGUI.Controller <CtrlShowVoiceNode>k__BackingField; // 0x60
	FairyGUI.Controller <CtrlShowEmjo>k__BackingField; // 0x68
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x70
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x78
	FairyGUI.GComponent get_BinderRoot(); // 0x067b1df4
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComChatInputBoxBinder get_Input(); // 0x067b1e58
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComCreatTeamPanelBinder get_ComCreateTeamPanel(); // 0x067b1ebc
	FairyGUI.GButton get_TransitionBtn(); // 0x067b1f20
	FairyGUI.GButton get_MemeBtn(); // 0x067b1f84
	FairyGUI.GButton get_CreateTeamBtn(); // 0x067b1fe8
	FairyGUI.GButton get_BtnSendMessage(); // 0x067b204c
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComConvertBinder get_VoiceNode(); // 0x067b20b0
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComChatEmojiNewBinder get_EmojiNode(); // 0x067b2114
	FairyGUI.Controller get_CtrlShowCreateTeam(); // 0x067b2178
	FairyGUI.Controller get_CtrlShowVoiceNode(); // 0x067b21dc
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b2240
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComChatInputBoxBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextInput <InpChatMessage>k__BackingField; // 0x18
	FairyGUI.GTextField <ChatMessageLength>k__BackingField; // 0x20
	FairyGUI.GTextInput get_InpChatMessage(); // 0x067b2bd8
	FairyGUI.GTextField get_ChatMessageLength(); // 0x067b2c3c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b2698
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComConversionBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Time>k__BackingField; // 0x18
	FairyGUI.GLoader <Play>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlPlace>k__BackingField; // 0x30
	FairyGUI.GTextField get_Time(); // 0x067b2ca0
	FairyGUI.GLoader get_Play(); // 0x067b2d04
	FairyGUI.Controller get_CtrlStatus(); // 0x067b2d68
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b2dcc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComConvertBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <BtnCancel>k__BackingField; // 0x18
	FairyGUI.GButton <BtnComplete>k__BackingField; // 0x20
	FairyGUI.GButton <SendBtn>k__BackingField; // 0x28
	FairyGUI.GTextField <Countdown>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x38
	FairyGUI.GButton get_BtnCancel(); // 0x067b2f48
	FairyGUI.GButton get_BtnComplete(); // 0x067b2fac
	FairyGUI.GButton get_SendBtn(); // 0x067b3010
	FairyGUI.Controller get_CtrlStatus(); // 0x067b3074
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b2a10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComCreatTeamPanelBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.BtnTeamBinder <AppointmentTeamBtn>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.BtnTeamBinder <LobbyTeamBtn>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.BtnTeamBinder <GameTeamBtn>k__BackingField; // 0x28
	FairyGUI.GGroup <GroupBtns>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlIsInGame>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlShowAppointment>k__BackingField; // 0x40
	FairyGUI.GComponent get_BinderRoot(); // 0x067b30d8
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.BtnTeamBinder get_AppointmentTeamBtn(); // 0x067b313c
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.BtnTeamBinder get_LobbyTeamBtn(); // 0x067b31a0
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.BtnTeamBinder get_GameTeamBtn(); // 0x067b3204
	FairyGUI.GGroup get_GroupBtns(); // 0x067b3268
	FairyGUI.Controller get_CtrlIsInGame(); // 0x067b32cc
	FairyGUI.Controller get_CtrlShowAppointment(); // 0x067b3330
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b27ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessageLeftBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Avatar>k__BackingField; // 0x18
	FairyGUI.GLabel <Name>k__BackingField; // 0x20
	FairyGUI.GComponent <LampItem>k__BackingField; // 0x28
	FairyGUI.GLoader <ChatBubble>k__BackingField; // 0x30
	FairyGUI.GLoader <ChatShare>k__BackingField; // 0x38
	FairyGUI.GLabel <Text>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_CreateTeamBinder <CreateTeam>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComConversionBinder <Voice>k__BackingField; // 0x50
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_GiftBinder <FriendGift>k__BackingField; // 0x58
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_EmojiBinder <Emoji>k__BackingField; // 0x60
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_GonggaoBinder <Gonggao>k__BackingField; // 0x68
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_RecommendBinder <Recommend>k__BackingField; // 0x70
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_ResultBinder <Result>k__BackingField; // 0x78
	FairyGUI.GGroup <Group>k__BackingField; // 0x80
	FairyGUI.Controller <CtrlType>k__BackingField; // 0x88
	FairyGUI.GComponent get_BinderRoot(); // 0x067b3394
	FairyGUI.GComponent get_Avatar(); // 0x067b33f8
	FairyGUI.GComponent get_LampItem(); // 0x067b345c
	FairyGUI.GLoader get_ChatBubble(); // 0x067b34c0
	FairyGUI.GLabel get_Text(); // 0x067b3524
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_CreateTeamBinder get_CreateTeam(); // 0x067b3588
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComConversionBinder get_Voice(); // 0x067b35ec
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_GiftBinder get_FriendGift(); // 0x067b3650
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_EmojiBinder get_Emoji(); // 0x067b36b4
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_GonggaoBinder get_Gonggao(); // 0x067b3718
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_RecommendBinder get_Recommend(); // 0x067b377c
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_ResultBinder get_Result(); // 0x067b37e0
	FairyGUI.GGroup get_Group(); // 0x067b3844
	FairyGUI.Controller get_CtrlType(); // 0x067b38a8
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b0a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessageRightBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Avatar>k__BackingField; // 0x18
	FairyGUI.GComponent <LampItem>k__BackingField; // 0x20
	FairyGUI.GLabel <Name>k__BackingField; // 0x28
	FairyGUI.GLoader <ChatBubble>k__BackingField; // 0x30
	FairyGUI.GLoader <ChatShare>k__BackingField; // 0x38
	FairyGUI.GLabel <Text>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_CreateTeamBinder <CreateTeam>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_GiftBinder <FriendGift>k__BackingField; // 0x50
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComConversionBinder <Voice>k__BackingField; // 0x58
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_EmojiBinder <Emoji>k__BackingField; // 0x60
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_GonggaoBinder <Gonggao>k__BackingField; // 0x68
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_RecommendBinder <Recommend>k__BackingField; // 0x70
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_ResultBinder <Result>k__BackingField; // 0x78
	FairyGUI.GGroup <Group>k__BackingField; // 0x80
	FairyGUI.Controller <CtrlType>k__BackingField; // 0x88
	FairyGUI.GComponent get_BinderRoot(); // 0x067b42d4
	FairyGUI.GComponent get_Avatar(); // 0x067b4338
	FairyGUI.GComponent get_LampItem(); // 0x067b439c
	FairyGUI.GLoader get_ChatBubble(); // 0x067b4400
	FairyGUI.GLabel get_Text(); // 0x067b4464
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_CreateTeamBinder get_CreateTeam(); // 0x067b44c8
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_GiftBinder get_FriendGift(); // 0x067b452c
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComConversionBinder get_Voice(); // 0x067b4590
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_EmojiBinder get_Emoji(); // 0x067b45f4
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_GonggaoBinder get_Gonggao(); // 0x067b4658
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_RecommendBinder get_Recommend(); // 0x067b46bc
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_ResultBinder get_Result(); // 0x067b4720
	FairyGUI.GGroup get_Group(); // 0x067b4784
	FairyGUI.Controller get_CtrlType(); // 0x067b47e8
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b0fec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_CreateTeamBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Title>k__BackingField; // 0x18
	FairyGUI.GTextField <Num>k__BackingField; // 0x20
	FairyGUI.GList <List>k__BackingField; // 0x28
	FairyGUI.GTextField <Desc>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlSource>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlApplyType>k__BackingField; // 0x48
	FairyGUI.GComponent get_BinderRoot(); // 0x067b484c
	FairyGUI.GTextField get_Title(); // 0x067b48b0
	FairyGUI.GTextField get_Num(); // 0x067b4914
	FairyGUI.GList get_List(); // 0x067b4978
	FairyGUI.GTextField get_Desc(); // 0x067b49dc
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b390c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_EmojiBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Icon_Emoji>k__BackingField; // 0x18
	FairyGUI.GLoader get_Icon_Emoji(); // 0x067b4a40
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b3d9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_GiftBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Tag>k__BackingField; // 0x18
	FairyGUI.GLoader <Quality>k__BackingField; // 0x20
	FairyGUI.GLoader <Icon_Gift>k__BackingField; // 0x28
	FairyGUI.GRichTextField <Content_Gift>k__BackingField; // 0x30
	FairyGUI.GButton <Btn_SendGiftBack>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlSource>k__BackingField; // 0x40
	FairyGUI.GLabel get_Tag(); // 0x067b4aa4
	FairyGUI.GLoader get_Icon_Gift(); // 0x067b4b08
	FairyGUI.GRichTextField get_Content_Gift(); // 0x067b4b6c
	FairyGUI.GButton get_Btn_SendGiftBack(); // 0x067b4bd0
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b3b94
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_GonggaoBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Tag>k__BackingField; // 0x18
	FairyGUI.GRichTextField <Title>k__BackingField; // 0x20
	FairyGUI.GLabel get_Tag(); // 0x067b4c34
	FairyGUI.GRichTextField get_Title(); // 0x067b4c98
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b3e70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_RecommendBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Tag>k__BackingField; // 0x18
	FairyGUI.GRichTextField <Title>k__BackingField; // 0x20
	FairyGUI.GButton <Btn>k__BackingField; // 0x28
	FairyGUI.GLabel get_Tag(); // 0x067b4cfc
	FairyGUI.GRichTextField get_Title(); // 0x067b4d60
	FairyGUI.GButton get_Btn(); // 0x067b4dc4
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b3f84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_ResultBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Tag>k__BackingField; // 0x18
	FairyGUI.GTextField <Desc>k__BackingField; // 0x20
	FairyGUI.GButton <Btn>k__BackingField; // 0x28
	FairyGUI.GTextField <TxtExpired>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlResult>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x40
	FairyGUI.GLabel get_Tag(); // 0x067b4e28
	FairyGUI.GTextField get_Desc(); // 0x067b4e8c
	FairyGUI.GButton get_Btn(); // 0x067b4ef0
	FairyGUI.Controller get_CtrlResult(); // 0x067b4f54
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b40d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComNavBarBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <PrimaryTab>k__BackingField; // 0x18
	FairyGUI.GList get_PrimaryTab(); // 0x067b4fb8
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b501c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComSystemMessageBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Title>k__BackingField; // 0x18
	FairyGUI.GTextField get_Title(); // 0x067b50f0
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b5154
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.RootChatBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.RootChatContentBinder <AnimRoot>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlInGame>k__BackingField; // 0x20
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x28
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x30
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.RootChatContentBinder get_AnimRoot(); // 0x067b5228
	FairyGUI.Controller get_CtrlInGame(); // 0x067b528c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b52f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.RootChatContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Bg>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComNavBarBinder <ChatCategoryList>k__BackingField; // 0x20
	FairyGUI.GComponent <ComChatRecruit>k__BackingField; // 0x28
	FairyGUI.GComponent <ChatMain>k__BackingField; // 0x30
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComChannelListBinder <Channel>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComChannelList_InterestBinder <ChannelInterest>k__BackingField; // 0x40
	FairyGUI.GButton <BtnBackRecruit>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComChatInputBinder <ComInput>k__BackingField; // 0x50
	FairyGUI.Controller <CtrlComRecruitStatus>k__BackingField; // 0x58
	FairyGUI.Controller <CtrlShowChannelList>k__BackingField; // 0x60
	FairyGUI.Controller <CtrlShowEmjo>k__BackingField; // 0x68
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x70
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x78
	FairyGUI.Transition <TransSwitch_01>k__BackingField; // 0x80
	FairyGUI.Transition <TransSwitch_02>k__BackingField; // 0x88
	FairyGUI.Transition <TransClick_in>k__BackingField; // 0x90
	FairyGUI.Transition <TransClick_out>k__BackingField; // 0x98
	FairyGUI.GLoader get_Bg(); // 0x067b59b8
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComNavBarBinder get_ChatCategoryList(); // 0x067b5a1c
	FairyGUI.GComponent get_ComChatRecruit(); // 0x067b5a80
	FairyGUI.GComponent get_ChatMain(); // 0x067b5ae4
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComChannelListBinder get_Channel(); // 0x067b5b48
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComChannelList_InterestBinder get_ChannelInterest(); // 0x067b5bac
	FairyGUI.GButton get_BtnBackRecruit(); // 0x067b5c10
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComChatInputBinder get_ComInput(); // 0x067b5c74
	FairyGUI.Controller get_CtrlComRecruitStatus(); // 0x067b5cd8
	FairyGUI.Controller get_CtrlShowChannelList(); // 0x067b5d3c
	FairyGUI.Controller get_CtrlShowEmjo(); // 0x067b5da0
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b5490
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameChat.UiChatBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <ClickMask>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.RootChatBinder <Root>k__BackingField; // 0x20
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x28
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x30
	FairyGUI.GLoader get_ClickMask(); // 0x067b5e04
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.RootChatBinder get_Root(); // 0x067b5e68
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b5ecc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameCartoon.ComCartoonBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Video_com>k__BackingField; // 0x18
	FairyGUI.GButton <Back_btn>k__BackingField; // 0x20
	FairyGUI.GComponent get_Video_com(); // 0x067b6078
	FairyGUI.GButton get_Back_btn(); // 0x067b60dc
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b6140
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameCartoon.UiCartoonBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameCartoon.ComCartoonBinder <Root>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameCartoon.ComCartoonBinder get_Root(); // 0x067b6254
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b62b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameCamera.BtnSwitchTextBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x18
	FairyGUI.GComponent get_BinderRoot(); // 0x067b63bc
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b6420
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameCamera.ComCameraRouteBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GSlider <Slider01>k__BackingField; // 0x18
	FairyGUI.GSlider <Slider02>k__BackingField; // 0x20
	FairyGUI.GButton <InfoPathSpeed>k__BackingField; // 0x28
	FairyGUI.GButton <InfoFowardSpeed>k__BackingField; // 0x30
	WizardGames.Soc.SocClient.Ui.Binder.GameCamera.BtnSwitchTextBinder <Switch03>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.Ui.Binder.GameCamera.BtnSwitchTextBinder <Switch01>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.GameCamera.BtnSwitchTextBinder <Switch02>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Ui.Binder.GameCamera.BtnSwitchTextBinder <Switch04>k__BackingField; // 0x50
	FairyGUI.GButton <Play>k__BackingField; // 0x58
	FairyGUI.GSlider <Slider03>k__BackingField; // 0x60
	FairyGUI.GSlider <Slider04>k__BackingField; // 0x68
	FairyGUI.GSlider <Slider05>k__BackingField; // 0x70
	FairyGUI.GSlider get_Slider01(); // 0x067b64e8
	FairyGUI.GSlider get_Slider02(); // 0x067b654c
	FairyGUI.GButton get_InfoPathSpeed(); // 0x067b65b0
	FairyGUI.GButton get_InfoFowardSpeed(); // 0x067b6614
	WizardGames.Soc.SocClient.Ui.Binder.GameCamera.BtnSwitchTextBinder get_Switch03(); // 0x067b6678
	WizardGames.Soc.SocClient.Ui.Binder.GameCamera.BtnSwitchTextBinder get_Switch01(); // 0x067b66dc
	WizardGames.Soc.SocClient.Ui.Binder.GameCamera.BtnSwitchTextBinder get_Switch02(); // 0x067b6740
	WizardGames.Soc.SocClient.Ui.Binder.GameCamera.BtnSwitchTextBinder get_Switch04(); // 0x067b67a4
	FairyGUI.GButton get_Play(); // 0x067b6808
	FairyGUI.GSlider get_Slider03(); // 0x067b686c
	FairyGUI.GSlider get_Slider04(); // 0x067b68d0
	FairyGUI.GSlider get_Slider05(); // 0x067b6934
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b6998
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.BurWeaponItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Icon>k__BackingField; // 0x18
	FairyGUI.GButton <AddBtn>k__BackingField; // 0x20
	FairyGUI.GComponent <InBag>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlEmpty>k__BackingField; // 0x30
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b6db0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.ComBurWeaponPanelBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <ConfirmBtn>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.HandlePanelBinder <HandlePanel>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.BurWeaponItemBinder <SelectItem>k__BackingField; // 0x28
	FairyGUI.GButton <CloseBtn>k__BackingField; // 0x30
	FairyGUI.GComponent <Backpack>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlEmpty>k__BackingField; // 0x40
	FairyGUI.GComponent get_Backpack(); // 0x067b6f38
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b6f9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.ComDiffIconBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.Controller <CtrlDif>k__BackingField; // 0x18
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b74d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.ExchangeItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Title>k__BackingField; // 0x18
	FairyGUI.GComponent <Icon>k__BackingField; // 0x20
	FairyGUI.GTextField <CurrencyNum>k__BackingField; // 0x28
	FairyGUI.GTextField <StorageNum>k__BackingField; // 0x30
	FairyGUI.GButton <BtnItemDetail>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlExchangeState>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlState>k__BackingField; // 0x48
	FairyGUI.Controller <CtrlValueState>k__BackingField; // 0x50
	FairyGUI.GLabel get_Title(); // 0x067b759c
	FairyGUI.GComponent get_Icon(); // 0x067b7600
	FairyGUI.GTextField get_CurrencyNum(); // 0x067b7664
	FairyGUI.GTextField get_StorageNum(); // 0x067b76c8
	FairyGUI.GButton get_BtnItemDetail(); // 0x067b772c
	FairyGUI.Controller get_CtrlExchangeState(); // 0x067b7790
	FairyGUI.Controller get_CtrlState(); // 0x067b77f4
	FairyGUI.Controller get_CtrlValueState(); // 0x067b7858
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b78bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.HandlePanelBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.BurWeaponItemBinder <DeletItem>k__BackingField; // 0x18
	FairyGUI.GButton <Close_btn>k__BackingField; // 0x20
	FairyGUI.GList <AddList>k__BackingField; // 0x28
	FairyGUI.GButton <AddBtn>k__BackingField; // 0x30
	FairyGUI.GButton <DeletBtn>k__BackingField; // 0x38
	FairyGUI.GTextField <ItemName>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlState>k__BackingField; // 0x48
	FairyGUI.GList get_AddList(); // 0x067b7b2c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b7204
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.ItemIconBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <ItemIcon>k__BackingField; // 0x18
	FairyGUI.GComponent get_ItemIcon(); // 0x067b7b90
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b7bf4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.LevelBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x18
	FairyGUI.Controller get_CtrlStatus(); // 0x067b7cc8
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b7d2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.ProgressContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GImage <ExpBar>k__BackingField; // 0x18
	FairyGUI.GTextField <Point>k__BackingField; // 0x20
	FairyGUI.GTextField <N40>k__BackingField; // 0x28
	FairyGUI.GTextField <PointTip>k__BackingField; // 0x30
	FairyGUI.GImage <Lv1Line>k__BackingField; // 0x38
	FairyGUI.GLabel <Lv1>k__BackingField; // 0x40
	FairyGUI.GImage <Lv2Line>k__BackingField; // 0x48
	FairyGUI.GLabel <Lv2>k__BackingField; // 0x50
	FairyGUI.GImage <Lv3Line>k__BackingField; // 0x58
	FairyGUI.GLabel <Lv3>k__BackingField; // 0x60
	FairyGUI.GImage <Lv4Line>k__BackingField; // 0x68
	FairyGUI.GLabel <Lv4>k__BackingField; // 0x70
	FairyGUI.GImage <Lv5Line>k__BackingField; // 0x78
	FairyGUI.GLabel <Lv5>k__BackingField; // 0x80
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x88
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x90
	FairyGUI.Transition <TransIncrease>k__BackingField; // 0x98
	FairyGUI.GComponent get_BinderRoot(); // 0x067b7df4
	FairyGUI.GImage get_ExpBar(); // 0x067b7e58
	FairyGUI.GTextField get_Point(); // 0x067b7ebc
	FairyGUI.GTextField get_N40(); // 0x067b7f20
	FairyGUI.GImage get_Lv1Line(); // 0x067b7f84
	FairyGUI.GLabel get_Lv1(); // 0x067b7fe8
	FairyGUI.GImage get_Lv2Line(); // 0x067b804c
	FairyGUI.GLabel get_Lv2(); // 0x067b80b0
	FairyGUI.GImage get_Lv3Line(); // 0x067b8114
	FairyGUI.GLabel get_Lv3(); // 0x067b8178
	FairyGUI.GImage get_Lv4Line(); // 0x067b81dc
	FairyGUI.GLabel get_Lv4(); // 0x067b8240
	FairyGUI.GImage get_Lv5Line(); // 0x067b82a4
	FairyGUI.GLabel get_Lv5(); // 0x067b8308
	FairyGUI.Transition get_TransShow_anim(); // 0x067b836c
	FairyGUI.Transition get_TransIncrease(); // 0x067b83d0
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b8434
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.RewardBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <TaskTitle>k__BackingField; // 0x18
	FairyGUI.GList <RewardIconList>k__BackingField; // 0x20
	FairyGUI.GButton <BtnClaim>k__BackingField; // 0x28
	FairyGUI.GButton <BtnGo>k__BackingField; // 0x30
	FairyGUI.GButton <BtnNotOpen>k__BackingField; // 0x38
	FairyGUI.GButton <BtnClaimed>k__BackingField; // 0x40
	FairyGUI.GImage <Red>k__BackingField; // 0x48
	FairyGUI.Controller <CtrlState>k__BackingField; // 0x50
	FairyGUI.GTextField get_TaskTitle(); // 0x067b88e4
	FairyGUI.GList get_RewardIconList(); // 0x067b8948
	FairyGUI.GButton get_BtnClaim(); // 0x067b89ac
	FairyGUI.GButton get_BtnGo(); // 0x067b8a10
	FairyGUI.GButton get_BtnNotOpen(); // 0x067b8a74
	FairyGUI.GButton get_BtnClaimed(); // 0x067b8ad8
	FairyGUI.Controller get_CtrlState(); // 0x067b8b3c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b8ba0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.RootActionExpansionBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <NavBar>k__BackingField; // 0x18
	FairyGUI.GLabel <TopBar>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.RootActionExpansionContentBinder <Content>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlTabIndex>k__BackingField; // 0x30
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x38
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x40
	FairyGUI.Transition <TransShow_anim_01>k__BackingField; // 0x48
	FairyGUI.GComponent get_NavBar(); // 0x067b8e28
	FairyGUI.GLabel get_TopBar(); // 0x067b8e8c
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.RootActionExpansionContentBinder get_Content(); // 0x067b8ef0
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b8f54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.RootActionExpansionContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiBuzzOperationBinder <UiBuzzOperation>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiTreasureHuntTaskBinder <UiTreasurehuntTask>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiDailyMissionBinder <UiDailyMission>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlTabIndex>k__BackingField; // 0x30
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x38
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x40
	FairyGUI.Transition <TransShow_anim_01>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiBuzzOperationBinder get_UiBuzzOperation(); // 0x067b945c
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiTreasureHuntTaskBinder get_UiTreasurehuntTask(); // 0x067b94c0
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiDailyMissionBinder get_UiDailyMission(); // 0x067b9524
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b91a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.TreasureHuntTaskItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <TaskName>k__BackingField; // 0x18
	FairyGUI.GTextField <TaskDesc>k__BackingField; // 0x20
	FairyGUI.GList <RewardList>k__BackingField; // 0x28
	FairyGUI.GButton <RefreshBtn>k__BackingField; // 0x30
	FairyGUI.GTextField <RefreshInfoText>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.ComDiffIconBinder <DifIcon>k__BackingField; // 0x40
	FairyGUI.GButton <GiveUpBtn>k__BackingField; // 0x48
	FairyGUI.GButton <TrackingTaskBtn>k__BackingField; // 0x50
	FairyGUI.GButton <UnTrackingTaskBtn>k__BackingField; // 0x58
	FairyGUI.GButton <GetRewardBtn>k__BackingField; // 0x60
	FairyGUI.GButton <GetTaskBtn>k__BackingField; // 0x68
	FairyGUI.GImage <TrackingIcon>k__BackingField; // 0x70
	FairyGUI.GImage <Timeicon>k__BackingField; // 0x78
	FairyGUI.GTextField <Time>k__BackingField; // 0x80
	FairyGUI.Controller <CtrlTracking>k__BackingField; // 0x88
	FairyGUI.Controller <CtrlType>k__BackingField; // 0x90
	FairyGUI.GTextField get_TaskName(); // 0x067b9b8c
	FairyGUI.GTextField get_TaskDesc(); // 0x067b9bf0
	FairyGUI.GList get_RewardList(); // 0x067b9c54
	FairyGUI.GButton get_RefreshBtn(); // 0x067b9cb8
	FairyGUI.GTextField get_RefreshInfoText(); // 0x067b9d1c
	FairyGUI.GButton get_GiveUpBtn(); // 0x067b9d80
	FairyGUI.GButton get_TrackingTaskBtn(); // 0x067b9de4
	FairyGUI.GButton get_UnTrackingTaskBtn(); // 0x067b9e48
	FairyGUI.GButton get_GetRewardBtn(); // 0x067b9eac
	FairyGUI.GButton get_GetTaskBtn(); // 0x067b9f10
	FairyGUI.GImage get_TrackingIcon(); // 0x067b9f74
	FairyGUI.GImage get_Timeicon(); // 0x067b9fd8
	FairyGUI.GTextField get_Time(); // 0x067ba03c
	FairyGUI.Controller get_CtrlTracking(); // 0x067ba0a0
	FairyGUI.Controller get_CtrlType(); // 0x067ba104
	System.Void .ctor(FairyGUI.GComponent root); // 0x067ba168
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiActionExpansionBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.RootActionExpansionBinder <Root>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlTabIndex>k__BackingField; // 0x20
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x28
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x30
	FairyGUI.Transition <TransShow_anim_01>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.RootActionExpansionBinder get_Root(); // 0x067ba66c
	FairyGUI.Controller get_CtrlTabIndex(); // 0x067ba6d0
	FairyGUI.Transition get_TransShow_anim_01(); // 0x067ba734
	System.Void .ctor(FairyGUI.GComponent root); // 0x067ba798
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiBurWeaponPanelBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.ComBurWeaponPanelBinder <Root>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.ComBurWeaponPanelBinder get_Root(); // 0x067ba96c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067ba9d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiBuzzOperationBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.ProgressContentBinder <Progress>k__BackingField; // 0x18
	FairyGUI.GTextField <PointTip>k__BackingField; // 0x20
	FairyGUI.GTextField <TaskTip>k__BackingField; // 0x28
	FairyGUI.GList <TaskList>k__BackingField; // 0x30
	FairyGUI.GButton <BtnExchange>k__BackingField; // 0x38
	FairyGUI.GButton <BtnRiskRecord>k__BackingField; // 0x40
	FairyGUI.GComponent <N12>k__BackingField; // 0x48
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x50
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x58
	FairyGUI.GComponent get_BinderRoot(); // 0x067baad4
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.ProgressContentBinder get_Progress(); // 0x067bab38
	FairyGUI.GTextField get_PointTip(); // 0x067bab9c
	FairyGUI.GTextField get_TaskTip(); // 0x067bac00
	FairyGUI.GList get_TaskList(); // 0x067bac64
	FairyGUI.GButton get_BtnExchange(); // 0x067bacc8
	FairyGUI.GButton get_BtnRiskRecord(); // 0x067bad2c
	FairyGUI.GComponent get_N12(); // 0x067bad90
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b9588
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiBuzzOperationExchangeBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiBuzzOperationExchangeRootBinder <Root>k__BackingField; // 0x18
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x20
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiBuzzOperationExchangeRootBinder get_Root(); // 0x067badf4
	System.Void .ctor(FairyGUI.GComponent root); // 0x067bae58
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiBuzzOperationExchangeRootBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Modal>k__BackingField; // 0x18
	FairyGUI.GTextField <TitleExchange>k__BackingField; // 0x20
	FairyGUI.GTextField <ValueTip>k__BackingField; // 0x28
	FairyGUI.GTextField <Value>k__BackingField; // 0x30
	FairyGUI.GList <ExchangeList>k__BackingField; // 0x38
	FairyGUI.GTextField <Reset>k__BackingField; // 0x40
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x48
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x50
	FairyGUI.GLabel get_Modal(); // 0x067bb240
	FairyGUI.GTextField get_ValueTip(); // 0x067bb2a4
	FairyGUI.GTextField get_Value(); // 0x067bb308
	FairyGUI.GList get_ExchangeList(); // 0x067bb36c
	FairyGUI.GTextField get_Reset(); // 0x067bb3d0
	System.Void .ctor(FairyGUI.GComponent root); // 0x067bafc4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiDailyMissionBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Root>k__BackingField; // 0x18
	FairyGUI.GComponent get_Root(); // 0x067bb434
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b9ab8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiTreasureHuntTaskBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GGraph <TouchHideTips>k__BackingField; // 0x18
	FairyGUI.GList <TreasureHuntTaskList>k__BackingField; // 0x20
	FairyGUI.GTextField <Clue>k__BackingField; // 0x28
	FairyGUI.GTextField <RefreshInfoText>k__BackingField; // 0x30
	FairyGUI.GGraph get_TouchHideTips(); // 0x067bb498
	FairyGUI.GList get_TreasureHuntTaskList(); // 0x067bb4fc
	FairyGUI.GTextField get_Clue(); // 0x067bb560
	FairyGUI.GTextField get_RefreshInfoText(); // 0x067bb5c4
	System.Void .ctor(FairyGUI.GComponent root); // 0x067b98cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonVideo.RootCommonVideoBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Modal>k__BackingField; // 0x18
	FairyGUI.GComponent <Video>k__BackingField; // 0x20
	FairyGUI.GLabel get_Modal(); // 0x067bb628
	FairyGUI.GComponent get_Video(); // 0x067bb68c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067bb6f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonVideo.UiCommonVideoBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonVideo.RootCommonVideoBinder <Root>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonVideo.RootCommonVideoBinder get_Root(); // 0x067bb804
	System.Void .ctor(FairyGUI.GComponent root); // 0x067bb868
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ActiveItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GImage <Icon>k__BackingField; // 0x18
	FairyGUI.GTextField <Title>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlType>k__BackingField; // 0x30
	FairyGUI.GTextField get_Title(); // 0x067bb96c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067bb9d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.BtnUnionIconItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GGraph <BgNormal>k__BackingField; // 0x18
	FairyGUI.GImage <None>k__BackingField; // 0x20
	FairyGUI.GImage <Selected>k__BackingField; // 0x28
	FairyGUI.GLoader <Icon>k__BackingField; // 0x30
	FairyGUI.GGraph <HoverStrock>k__BackingField; // 0x38
	FairyGUI.GGraph <HoverFill>k__BackingField; // 0x40
	FairyGUI.GImage <Lock>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComColorItemBinder <Color>k__BackingField; // 0x50
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x58
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x60
	FairyGUI.Transition <TransClick>k__BackingField; // 0x68
	FairyGUI.GComponent get_BinderRoot(); // 0x067bbb4c
	FairyGUI.GLoader get_Icon(); // 0x067bbbb0
	System.Void .ctor(FairyGUI.GComponent root); // 0x067bbc14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComApplicationListItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Avatar>k__BackingField; // 0x18
	FairyGUI.GLabel <PlayerName>k__BackingField; // 0x20
	FairyGUI.GButton <BtnNo>k__BackingField; // 0x28
	FairyGUI.GButton <BtnOk>k__BackingField; // 0x30
	FairyGUI.GComponent get_Avatar(); // 0x067bbf78
	FairyGUI.GLabel get_PlayerName(); // 0x067bbfdc
	FairyGUI.GButton get_BtnNo(); // 0x067bc040
	FairyGUI.GButton get_BtnOk(); // 0x067bc0a4
	System.Void .ctor(FairyGUI.GComponent root); // 0x067bc108
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.Comaward_UnigonGrowthItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GProgressBar <Progress>k__BackingField; // 0x18
	FairyGUI.GButton <Award>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComUnionLevelPointBinder <LvPoint>k__BackingField; // 0x28
	FairyGUI.GTextField <ExpValue>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlLocked>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlFirst>k__BackingField; // 0x48
	FairyGUI.GProgressBar get_Progress(); // 0x067bc29c
	FairyGUI.GButton get_Award(); // 0x067bc300
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComUnionLevelPointBinder get_LvPoint(); // 0x067bc364
	FairyGUI.GTextField get_ExpValue(); // 0x067bc3c8
	FairyGUI.Controller get_CtrlLocked(); // 0x067bc42c
	FairyGUI.Controller get_CtrlFirst(); // 0x067bc490
	System.Void .ctor(FairyGUI.GComponent root); // 0x067bc4f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComBadgeInputBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Title>k__BackingField; // 0x18
	FairyGUI.GList <ElementList>k__BackingField; // 0x20
	FairyGUI.GList <ElementList_Color>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlBgColor>k__BackingField; // 0x30
	FairyGUI.GComponent get_BinderRoot(); // 0x067bc758
	FairyGUI.GLabel get_Title(); // 0x067bc7bc
	FairyGUI.GList get_ElementList(); // 0x067bc820
	FairyGUI.GList get_ElementList_Color(); // 0x067bc884
	System.Void .ctor(FairyGUI.GComponent root); // 0x067bc8e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComColorItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GGraph <ColorBace>k__BackingField; // 0x18
	FairyGUI.GImage <Lock>k__BackingField; // 0x20
	FairyGUI.GImage <None>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlSatus>k__BackingField; // 0x38
	FairyGUI.GComponent get_BinderRoot(); // 0x0684e148
	FairyGUI.GGraph get_ColorBace(); // 0x0684e1ac
	System.Void .ctor(FairyGUI.GComponent root); // 0x0684e210
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComDataBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GRichTextField <Title>k__BackingField; // 0x18
	FairyGUI.GTextField <Value>k__BackingField; // 0x20
	FairyGUI.GRichTextField get_Title(); // 0x0684e3cc
	FairyGUI.GTextField get_Value(); // 0x0684e430
	System.Void .ctor(FairyGUI.GComponent root); // 0x0684e494
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComGongGaoRootBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Modal>k__BackingField; // 0x18
	FairyGUI.GGraph <OwnerInforBg>k__BackingField; // 0x20
	FairyGUI.GTextField <TxtCount>k__BackingField; // 0x28
	FairyGUI.GTextInput <InputAnnouncement>k__BackingField; // 0x30
	FairyGUI.GTextField <ContentText>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x40
	FairyGUI.GComponent get_BinderRoot(); // 0x0684e5a8
	FairyGUI.GLabel get_Modal(); // 0x0684e60c
	FairyGUI.GTextField get_TxtCount(); // 0x0684e670
	FairyGUI.GTextInput get_InputAnnouncement(); // 0x0684e6d4
	System.Void .ctor(FairyGUI.GComponent root); // 0x0684e738
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComInvitationListItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Badge>k__BackingField; // 0x18
	FairyGUI.GTextField <Remark>k__BackingField; // 0x20
	FairyGUI.GComponent <Avatar>k__BackingField; // 0x28
	FairyGUI.GLabel <PlayerName>k__BackingField; // 0x30
	FairyGUI.GTextField <UnionName>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComMembersNumBinder <MemberNum>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ActiveItemBinder <ActiveInfo>k__BackingField; // 0x48
	FairyGUI.GButton <BtnNo>k__BackingField; // 0x50
	FairyGUI.GButton <BtnOk>k__BackingField; // 0x58
	FairyGUI.Transition <TransAppear>k__BackingField; // 0x60
	FairyGUI.GLoader get_Badge(); // 0x0684e940
	FairyGUI.GComponent get_Avatar(); // 0x0684e9a4
	FairyGUI.GLabel get_PlayerName(); // 0x0684ea08
	FairyGUI.GTextField get_UnionName(); // 0x0684ea6c
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComMembersNumBinder get_MemberNum(); // 0x0684ead0
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ActiveItemBinder get_ActiveInfo(); // 0x0684eb34
	FairyGUI.GButton get_BtnNo(); // 0x0684eb98
	FairyGUI.GButton get_BtnOk(); // 0x0684ebfc
	System.Void .ctor(FairyGUI.GComponent root); // 0x0684ec60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComLogListItemABinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Date>k__BackingField; // 0x18
	FairyGUI.GList <List>k__BackingField; // 0x20
	FairyGUI.GTextField get_Date(); // 0x0684f0e0
	FairyGUI.GList get_List(); // 0x0684f144
	System.Void .ctor(FairyGUI.GComponent root); // 0x0684f1a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComLogListItemBBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Time>k__BackingField; // 0x18
	FairyGUI.GButton <PlayerA>k__BackingField; // 0x20
	FairyGUI.GRichTextField <TextA>k__BackingField; // 0x28
	FairyGUI.GButton <PlayerB>k__BackingField; // 0x30
	FairyGUI.GRichTextField <TextB>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlC1>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlIsFinal>k__BackingField; // 0x48
	FairyGUI.GTextField get_Time(); // 0x0684f2bc
	FairyGUI.GButton get_PlayerA(); // 0x0684f320
	FairyGUI.GRichTextField get_TextA(); // 0x0684f384
	FairyGUI.GButton get_PlayerB(); // 0x0684f3e8
	FairyGUI.GRichTextField get_TextB(); // 0x0684f44c
	FairyGUI.Controller get_CtrlC1(); // 0x0684f4b0
	System.Void .ctor(FairyGUI.GComponent root); // 0x0684f514
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComLogPopupBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Modal>k__BackingField; // 0x18
	FairyGUI.GList <LogList>k__BackingField; // 0x20
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x28
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x30
	FairyGUI.GLabel get_Modal(); // 0x0684f750
	FairyGUI.GList get_LogList(); // 0x0684f7b4
	System.Void .ctor(FairyGUI.GComponent root); // 0x0684f818
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComMemberListItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Portrait>k__BackingField; // 0x18
	FairyGUI.GComponent <TextStatus>k__BackingField; // 0x20
	FairyGUI.GTextField <ContributionValue>k__BackingField; // 0x28
	FairyGUI.GButton <BtnMore>k__BackingField; // 0x30
	FairyGUI.GButton <BtnTeam>k__BackingField; // 0x38
	FairyGUI.GButton <BtnChat>k__BackingField; // 0x40
	FairyGUI.GGroup <Btngroup>k__BackingField; // 0x48
	FairyGUI.GLabel <Name>k__BackingField; // 0x50
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComLabel_PostBinder <Label>k__BackingField; // 0x58
	FairyGUI.Controller <CtrlAdmin>k__BackingField; // 0x60
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x68
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x70
	FairyGUI.GComponent get_Portrait(); // 0x0684f994
	FairyGUI.GComponent get_TextStatus(); // 0x0684f9f8
	FairyGUI.GTextField get_ContributionValue(); // 0x0684fa5c
	FairyGUI.GButton get_BtnMore(); // 0x0684fac0
	FairyGUI.GButton get_BtnTeam(); // 0x0684fb24
	FairyGUI.GButton get_BtnChat(); // 0x0684fb88
	FairyGUI.GGroup get_Btngroup(); // 0x0684fbec
	FairyGUI.GLabel get_Name(); // 0x0684fc50
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComLabel_PostBinder get_Label(); // 0x0684fcb4
	System.Void .ctor(FairyGUI.GComponent root); // 0x0684fd18
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComMembersNumBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GImage <Icon>k__BackingField; // 0x18
	FairyGUI.GRichTextField <Num>k__BackingField; // 0x20
	FairyGUI.GRichTextField get_Num(); // 0x068500bc
	System.Void .ctor(FairyGUI.GComponent root); // 0x0684efcc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.commonBtnInputBoxBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GGraph <Bac>k__BackingField; // 0x18
	FairyGUI.GTextInput <InputArea>k__BackingField; // 0x20
	FairyGUI.GTextField <LimitNum>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlLimitNumTip>k__BackingField; // 0x38
	FairyGUI.GComponent get_BinderRoot(); // 0x06850120
	FairyGUI.GTextInput get_InputArea(); // 0x06850184
	FairyGUI.GTextField get_LimitNum(); // 0x068501e8
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685024c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComOptionalModeBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Title>k__BackingField; // 0x18
	FairyGUI.GComboBox <SelectableCondition>k__BackingField; // 0x20
	FairyGUI.GButton <Info>k__BackingField; // 0x28
	FairyGUI.GTextField <SetTitle02>k__BackingField; // 0x30
	FairyGUI.GButton <LV>k__BackingField; // 0x38
	FairyGUI.GTextField <More>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlShowAppointmentTime>k__BackingField; // 0x48
	FairyGUI.GComponent get_BinderRoot(); // 0x06850408
	FairyGUI.GComboBox get_SelectableCondition(); // 0x0685046c
	FairyGUI.GButton get_Info(); // 0x068504d0
	FairyGUI.GButton get_LV(); // 0x06850534
	System.Void .ctor(FairyGUI.GComponent root); // 0x06850598
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComRankingListHeaterBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <Title>k__BackingField; // 0x18
	FairyGUI.GList <DadaList>k__BackingField; // 0x20
	FairyGUI.GButton get_Title(); // 0x068507e0
	FairyGUI.GList get_DadaList(); // 0x06850844
	System.Void .ctor(FairyGUI.GComponent root); // 0x068508a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComRankingListItmeBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComRankingNumBinder <RankingNum>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComUnionBadgeNameBinder <Union>k__BackingField; // 0x20
	FairyGUI.GList <DadaList>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlRankingType>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlListSelf>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlBottomSelf>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComRankingNumBinder get_RankingNum(); // 0x068509bc
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComUnionBadgeNameBinder get_Union(); // 0x06850a20
	FairyGUI.GList get_DadaList(); // 0x06850a84
	FairyGUI.Controller get_CtrlRankingType(); // 0x06850ae8
	FairyGUI.Controller get_CtrlListSelf(); // 0x06850b4c
	FairyGUI.Controller get_CtrlBottomSelf(); // 0x06850bb0
	System.Void .ctor(FairyGUI.GComponent root); // 0x06850c14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComRankingNumBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <NumTop3>k__BackingField; // 0x18
	FairyGUI.GTextField <NumElse>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlTop>k__BackingField; // 0x28
	FairyGUI.GTextField get_NumTop3(); // 0x068510c0
	FairyGUI.GTextField get_NumElse(); // 0x06851124
	FairyGUI.Controller get_CtrlTop(); // 0x06851188
	System.Void .ctor(FairyGUI.GComponent root); // 0x06850e64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComRecommendUnionListItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GGraph <OverLight>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComUnionBadgeNameBinder <Union>k__BackingField; // 0x20
	FairyGUI.GTextField <Level>k__BackingField; // 0x28
	FairyGUI.GTextField <Member>k__BackingField; // 0x30
	FairyGUI.GTextField <Ative>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x40
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x48
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x50
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComUnionBadgeNameBinder get_Union(); // 0x068511ec
	FairyGUI.GTextField get_Level(); // 0x06851250
	FairyGUI.GTextField get_Member(); // 0x068512b4
	FairyGUI.GTextField get_Ative(); // 0x06851318
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685137c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComRecommendUnionmatetitle02Binder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComboBox <Contribution>k__BackingField; // 0x18
	FairyGUI.GTextField <TitleControl>k__BackingField; // 0x20
	FairyGUI.GComboBox <Role>k__BackingField; // 0x28
	FairyGUI.GComboBox get_Contribution(); // 0x0685161c
	FairyGUI.GComboBox get_Role(); // 0x06851680
	System.Void .ctor(FairyGUI.GComponent root); // 0x068516e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComTextAreaBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Text>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlC1>k__BackingField; // 0x20
	FairyGUI.GTextField get_Text(); // 0x06851838
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685189c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComTextInputBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.commonBtnInputBoxBinder <Bac>k__BackingField; // 0x18
	FairyGUI.GLabel <Title>k__BackingField; // 0x20
	FairyGUI.GImage <EditTipIcon>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.commonBtnInputBoxBinder get_Bac(); // 0x068519a4
	FairyGUI.GLabel get_Title(); // 0x06851a08
	FairyGUI.GImage get_EditTipIcon(); // 0x06851a6c
	System.Void .ctor(FairyGUI.GComponent root); // 0x06851ad0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComUnionBadgeNameBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <UnionName>k__BackingField; // 0x18
	FairyGUI.GComponent <Badge>k__BackingField; // 0x20
	FairyGUI.GComponent get_BinderRoot(); // 0x06851c54
	FairyGUI.GTextField get_UnionName(); // 0x06851cb8
	FairyGUI.GComponent get_Badge(); // 0x06851d1c
	System.Void .ctor(FairyGUI.GComponent root); // 0x06850fac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComUnionBottomBtnBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <LeaveBtn>k__BackingField; // 0x18
	FairyGUI.GButton <InvitationBtn>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComMembersNumBinder <Member>k__BackingField; // 0x28
	FairyGUI.GButton <CteateBtn>k__BackingField; // 0x30
	FairyGUI.GButton <Apply>k__BackingField; // 0x38
	FairyGUI.GButton <InviteBtn>k__BackingField; // 0x40
	FairyGUI.GButton <InviteBtn_Qq>k__BackingField; // 0x48
	FairyGUI.GButton <InviteBtn_Wechat>k__BackingField; // 0x50
	FairyGUI.GButton <ApplyListBtn>k__BackingField; // 0x58
	FairyGUI.Controller <CtrlState>k__BackingField; // 0x60
	FairyGUI.Controller <CtrlInviteBtn>k__BackingField; // 0x68
	FairyGUI.GComponent get_BinderRoot(); // 0x06851d80
	FairyGUI.GButton get_LeaveBtn(); // 0x06851de4
	FairyGUI.GButton get_InvitationBtn(); // 0x06851e48
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComMembersNumBinder get_Member(); // 0x06851eac
	FairyGUI.GButton get_CteateBtn(); // 0x06851f10
	FairyGUI.GButton get_Apply(); // 0x06851f74
	FairyGUI.GButton get_InviteBtn(); // 0x06851fd8
	FairyGUI.GButton get_ApplyListBtn(); // 0x0685203c
	FairyGUI.Controller get_CtrlState(); // 0x068520a0
	System.Void .ctor(FairyGUI.GComponent root); // 0x06852104
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComUnionLevelPointBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x18
	FairyGUI.GTextField <LvNum>k__BackingField; // 0x20
	FairyGUI.Controller get_CtrlStatus(); // 0x0685245c
	FairyGUI.GTextField get_LvNum(); // 0x068524c0
	System.Void .ctor(FairyGUI.GComponent root); // 0x06852524
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ProgressBarUnionLevelBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GImage <ImgText>k__BackingField; // 0x18
	FairyGUI.GImage <Bar>k__BackingField; // 0x20
	FairyGUI.GTextField <Value>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlStyle>k__BackingField; // 0x30
	FairyGUI.GComponent get_BinderRoot(); // 0x0685262c
	FairyGUI.GTextField get_Value(); // 0x06852690
	System.Void .ctor(FairyGUI.GComponent root); // 0x068526f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootCreateUnionBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Modal>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.UnionFlagBinder <Flag>k__BackingField; // 0x20
	FairyGUI.GLabel <TitileName>k__BackingField; // 0x28
	FairyGUI.GGraph <NameEditBoxBg>k__BackingField; // 0x30
	FairyGUI.GComponent <NameEdit>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComTextInputBinder <RA>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComOptionalModeBinder <Requirement>k__BackingField; // 0x48
	FairyGUI.GTextField <NameTip>k__BackingField; // 0x50
	FairyGUI.GImage <LineBottom>k__BackingField; // 0x58
	FairyGUI.GTextField <TitleNeed>k__BackingField; // 0x60
	FairyGUI.GList <ConsumeItems>k__BackingField; // 0x68
	FairyGUI.GButton <CteateTips>k__BackingField; // 0x70
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.UnionFlagBinder <Badge>k__BackingField; // 0x78
	FairyGUI.GList <ElementList>k__BackingField; // 0x80
	FairyGUI.Controller <CtrlStep>k__BackingField; // 0x88
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x90
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x98
	FairyGUI.GComponent get_BinderRoot(); // 0x0685287c
	FairyGUI.GLabel get_Modal(); // 0x068528e0
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.UnionFlagBinder get_Flag(); // 0x06852944
	FairyGUI.GComponent get_NameEdit(); // 0x068529a8
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComTextInputBinder get_RA(); // 0x06852a0c
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComOptionalModeBinder get_Requirement(); // 0x06852a70
	FairyGUI.GTextField get_NameTip(); // 0x06852ad4
	FairyGUI.GList get_ConsumeItems(); // 0x06852b38
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.UnionFlagBinder get_Badge(); // 0x06852b9c
	FairyGUI.GList get_ElementList(); // 0x06852c00
	System.Void .ctor(FairyGUI.GComponent root); // 0x06852c64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionApplicationBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Modal>k__BackingField; // 0x18
	FairyGUI.GList <ApplicationList>k__BackingField; // 0x20
	FairyGUI.GLabel get_Modal(); // 0x06853530
	FairyGUI.GList get_ApplicationList(); // 0x06853594
	System.Void .ctor(FairyGUI.GComponent root); // 0x068535f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionContent_Award_UnionGrowthPageBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <UnionBadge>k__BackingField; // 0x18
	FairyGUI.GTextField <UnionName>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComUnionLevelPointBinder <Level>k__BackingField; // 0x28
	FairyGUI.GProgressBar <ProgressBar01>k__BackingField; // 0x30
	FairyGUI.GButton <LevelInfo>k__BackingField; // 0x38
	FairyGUI.GList <List>k__BackingField; // 0x40
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x48
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x50
	FairyGUI.GLoader get_UnionBadge(); // 0x06853764
	FairyGUI.GTextField get_UnionName(); // 0x068537c8
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComUnionLevelPointBinder get_Level(); // 0x0685382c
	FairyGUI.GProgressBar get_ProgressBar01(); // 0x06853890
	FairyGUI.GButton get_LevelInfo(); // 0x068538f4
	FairyGUI.GList get_List(); // 0x06853958
	FairyGUI.Transition get_TransShow_anim(); // 0x068539bc
	System.Void .ctor(FairyGUI.GComponent root); // 0x06853a20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionContent_HomePageBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <TouchLoader>k__BackingField; // 0x18
	FairyGUI.GLoader <Badge>k__BackingField; // 0x20
	FairyGUI.GTextField <Level>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComTextInputBinder <InputBox>k__BackingField; // 0x30
	FairyGUI.GButton <BtnShare>k__BackingField; // 0x38
	FairyGUI.GButton <BtnLog>k__BackingField; // 0x40
	FairyGUI.GTextField <Name>k__BackingField; // 0x48
	FairyGUI.GButton <BtnNameCopy>k__BackingField; // 0x50
	FairyGUI.GTextField <IDTitle>k__BackingField; // 0x58
	FairyGUI.GTextField <IDNum>k__BackingField; // 0x60
	FairyGUI.GButton <BtnIdCopy>k__BackingField; // 0x68
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComDataBinder <Mumber>k__BackingField; // 0x70
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComDataBinder <Active>k__BackingField; // 0x78
	FairyGUI.GTextField <SocialRelations>k__BackingField; // 0x80
	FairyGUI.GButton <BtnCreateGroup>k__BackingField; // 0x88
	FairyGUI.GGroup <BaseInfo>k__BackingField; // 0x90
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ProgressBarUnionLevelBinder <BarBg>k__BackingField; // 0x98
	FairyGUI.GButton <LeaderIdCard>k__BackingField; // 0xa0
	FairyGUI.GComponent get_BinderRoot(); // 0x06853ccc
	FairyGUI.GLoader get_Badge(); // 0x06853d30
	FairyGUI.GTextField get_Level(); // 0x06853d94
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComTextInputBinder get_InputBox(); // 0x06853df8
	FairyGUI.GButton get_BtnShare(); // 0x06853e5c
	FairyGUI.GButton get_BtnLog(); // 0x06853ec0
	FairyGUI.GTextField get_Name(); // 0x06853f24
	FairyGUI.GButton get_BtnNameCopy(); // 0x06853f88
	FairyGUI.GTextField get_IDNum(); // 0x06853fec
	FairyGUI.GButton get_BtnIdCopy(); // 0x06854050
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComDataBinder get_Mumber(); // 0x068540b4
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComDataBinder get_Active(); // 0x06854118
	FairyGUI.GTextField get_SocialRelations(); // 0x0685417c
	FairyGUI.GButton get_BtnCreateGroup(); // 0x068541e0
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ProgressBarUnionLevelBinder get_BarBg(); // 0x06854244
	FairyGUI.GButton get_LeaderIdCard(); // 0x068542a8
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685430c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionContent_MemberPageBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComRecommendUnionmatetitle02Binder <ListHeader>k__BackingField; // 0x18
	FairyGUI.GList <MemberList>k__BackingField; // 0x20
	FairyGUI.GComponent <Bottom>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComRecommendUnionmatetitle02Binder get_ListHeader(); // 0x068548cc
	FairyGUI.GList get_MemberList(); // 0x06854930
	FairyGUI.GComponent get_Bottom(); // 0x06854994
	System.Void .ctor(FairyGUI.GComponent root); // 0x068549f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionContent_RankingList_ActivityBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <TouchLoader>k__BackingField; // 0x18
	FairyGUI.GButton <LeaderIdCard>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComRankingListHeaterBinder <RankinglistHeader>k__BackingField; // 0x28
	FairyGUI.GList <RankingList>k__BackingField; // 0x30
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComRankingListItmeBinder <BottomSelf>k__BackingField; // 0x38
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x40
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x48
	FairyGUI.GButton get_LeaderIdCard(); // 0x06854bd4
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComRankingListHeaterBinder get_RankinglistHeader(); // 0x06854c38
	FairyGUI.GList get_RankingList(); // 0x06854c9c
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComRankingListItmeBinder get_BottomSelf(); // 0x06854d00
	FairyGUI.Transition get_TransShow_anim(); // 0x06854d64
	System.Void .ctor(FairyGUI.GComponent root); // 0x06854dc8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionContent_Setting_CommonBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Titile01>k__BackingField; // 0x18
	FairyGUI.GTextField <NameTip>k__BackingField; // 0x20
	FairyGUI.GImage <EditTipIcon>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.commonBtnInputBoxBinder <NameEdit>k__BackingField; // 0x30
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.UnionFlagBinder <Flag>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComTextInputBinder <IA>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComTextInputBinder <RA>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComOptionalModeBinder <Requirement>k__BackingField; // 0x50
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x58
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x60
	FairyGUI.GComponent get_BinderRoot(); // 0x068550bc
	FairyGUI.GTextField get_NameTip(); // 0x06855120
	FairyGUI.GImage get_EditTipIcon(); // 0x06855184
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.commonBtnInputBoxBinder get_NameEdit(); // 0x068551e8
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.UnionFlagBinder get_Flag(); // 0x0685524c
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComTextInputBinder get_IA(); // 0x068552b0
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComTextInputBinder get_RA(); // 0x06855314
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComOptionalModeBinder get_Requirement(); // 0x06855378
	System.Void .ctor(FairyGUI.GComponent root); // 0x068553dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionInvitationBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Modal>k__BackingField; // 0x18
	FairyGUI.GList <InvitationList>k__BackingField; // 0x20
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x28
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x30
	FairyGUI.GLabel get_Modal(); // 0x068557b4
	FairyGUI.GList get_InvitationList(); // 0x06855818
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685587c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionRecommendBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <TopBar>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionRecommendContentBinder <Root>k__BackingField; // 0x20
	FairyGUI.GComponent get_BinderRoot(); // 0x06855a50
	FairyGUI.GLabel get_TopBar(); // 0x06855ab4
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionRecommendContentBinder get_Root(); // 0x06855b18
	System.Void .ctor(FairyGUI.GComponent root); // 0x06855b7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionRecommendContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <SearchBox>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.UnionBaceInfoBinder <UnionInfo>k__BackingField; // 0x20
	FairyGUI.GButton <ChangeBtn>k__BackingField; // 0x28
	FairyGUI.GLabel <Title>k__BackingField; // 0x30
	FairyGUI.GButton <RadioBox01>k__BackingField; // 0x38
	FairyGUI.GTextField <Filter01>k__BackingField; // 0x40
	FairyGUI.GButton <RadioBox02>k__BackingField; // 0x48
	FairyGUI.GTextField <Filter02>k__BackingField; // 0x50
	FairyGUI.GComponent <ListHeader>k__BackingField; // 0x58
	FairyGUI.GList <UnionList>k__BackingField; // 0x60
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComUnionBottomBtnBinder <Bottom>k__BackingField; // 0x68
	FairyGUI.GComponent <Loading>k__BackingField; // 0x70
	FairyGUI.GComponent get_BinderRoot(); // 0x0685610c
	FairyGUI.GComponent get_SearchBox(); // 0x06856170
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.UnionBaceInfoBinder get_UnionInfo(); // 0x068561d4
	FairyGUI.GButton get_ChangeBtn(); // 0x06856238
	FairyGUI.GButton get_RadioBox01(); // 0x0685629c
	FairyGUI.GButton get_RadioBox02(); // 0x06856300
	FairyGUI.GList get_UnionList(); // 0x06856364
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComUnionBottomBtnBinder get_Bottom(); // 0x068563c8
	System.Void .ctor(FairyGUI.GComponent root); // 0x06855cc0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.UiUnionApplicationPopUpBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionApplicationBinder <Root>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionApplicationBinder get_Root(); // 0x068568f0
	System.Void .ctor(FairyGUI.GComponent root); // 0x06856954
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.UnionBaceInfoBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Icon>k__BackingField; // 0x18
	FairyGUI.GButton <JoinBtn>k__BackingField; // 0x20
	FairyGUI.GGraph <InputBg>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComTextAreaBinder <InputAreaNew>k__BackingField; // 0x30
	FairyGUI.GTextField <RequirementTitle>k__BackingField; // 0x38
	FairyGUI.GTextField <R01>k__BackingField; // 0x40
	FairyGUI.GTextField <R02>k__BackingField; // 0x48
	FairyGUI.GTextField <LvTitle>k__BackingField; // 0x50
	FairyGUI.GTextField <LvNum>k__BackingField; // 0x58
	FairyGUI.GTextField <IdTitle>k__BackingField; // 0x60
	FairyGUI.GTextField <IdNum>k__BackingField; // 0x68
	FairyGUI.GTextField <UnionName>k__BackingField; // 0x70
	FairyGUI.GComponent <Portrait>k__BackingField; // 0x78
	FairyGUI.GLabel <NameMedal>k__BackingField; // 0x80
	FairyGUI.GComponent <Label>k__BackingField; // 0x88
	FairyGUI.GGroup <LeaderInfo>k__BackingField; // 0x90
	FairyGUI.GLoader get_Icon(); // 0x06856a58
	FairyGUI.GButton get_JoinBtn(); // 0x06856abc
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComTextAreaBinder get_InputAreaNew(); // 0x06856b20
	FairyGUI.GTextField get_R01(); // 0x06856b84
	FairyGUI.GTextField get_R02(); // 0x06856be8
	FairyGUI.GTextField get_LvNum(); // 0x06856c4c
	FairyGUI.GTextField get_IdNum(); // 0x06856cb0
	FairyGUI.GTextField get_UnionName(); // 0x06856d14
	FairyGUI.GComponent get_Portrait(); // 0x06856d78
	FairyGUI.GLabel get_NameMedal(); // 0x06856ddc
	FairyGUI.GComponent get_Label(); // 0x06856e40
	FairyGUI.GGroup get_LeaderInfo(); // 0x06856ea4
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685642c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.UnionFlagBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Badge>k__BackingField; // 0x18
	FairyGUI.GLoader <Icon>k__BackingField; // 0x20
	FairyGUI.GTextField <Name>k__BackingField; // 0x28
	FairyGUI.GButton <BtnChange>k__BackingField; // 0x30
	FairyGUI.GButton <BtnRandom>k__BackingField; // 0x38
	FairyGUI.GButton <BtnSave>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlMainBtn>k__BackingField; // 0x48
	FairyGUI.Controller <CtrlName>k__BackingField; // 0x50
	FairyGUI.Controller <CtrlBtnStatus>k__BackingField; // 0x58
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x60
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x68
	FairyGUI.GComponent get_BinderRoot(); // 0x06856f08
	FairyGUI.GLoader get_Icon(); // 0x06856f6c
	FairyGUI.GTextField get_Name(); // 0x06856fd0
	FairyGUI.GButton get_BtnChange(); // 0x06857034
	FairyGUI.GButton get_BtnRandom(); // 0x06857098
	FairyGUI.GButton get_BtnSave(); // 0x068570fc
	System.Void .ctor(FairyGUI.GComponent root); // 0x06853218
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComApplyJoinBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Modal>k__BackingField; // 0x18
	FairyGUI.GList <TagList>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComTextInputBinder <Input>k__BackingField; // 0x28
	FairyGUI.GList <QuickTextList>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlShowApplyDesc>k__BackingField; // 0x38
	FairyGUI.GLabel get_Modal(); // 0x06857160
	FairyGUI.GList get_TagList(); // 0x068571c4
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComTextInputBinder get_Input(); // 0x06857228
	FairyGUI.GList get_QuickTextList(); // 0x0685728c
	FairyGUI.Controller get_CtrlShowApplyDesc(); // 0x068572f0
	System.Void .ctor(FairyGUI.GComponent root); // 0x06857354
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComConditionsBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComDisplayModeBinder <FixedModeNode>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionModeAndMemberNumBinder <ModeAndMemberNumNode>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionAppointmentTimeBinder <AppointmentTimeNode>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComRecruitBinder <RecruitDescNode>k__BackingField; // 0x30
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSkilledBinder <PlayerTagsNode>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSelect_TwoBinder <MicrophoneNode>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionTimeBinder <AlwaysTimeNode>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSelect_TwoBinder <ApplyForNode>k__BackingField; // 0x50
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComTextInputBinder <TeamNameNode>k__BackingField; // 0x58
	FairyGUI.GGroup <Group>k__BackingField; // 0x60
	FairyGUI.Controller <CtrlShowMore>k__BackingField; // 0x68
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComDisplayModeBinder get_FixedModeNode(); // 0x068576a0
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionModeAndMemberNumBinder get_ModeAndMemberNumNode(); // 0x06857704
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionAppointmentTimeBinder get_AppointmentTimeNode(); // 0x06857768
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComRecruitBinder get_RecruitDescNode(); // 0x068577cc
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSkilledBinder get_PlayerTagsNode(); // 0x06857830
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSelect_TwoBinder get_MicrophoneNode(); // 0x06857894
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionTimeBinder get_AlwaysTimeNode(); // 0x068578f8
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSelect_TwoBinder get_ApplyForNode(); // 0x0685795c
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComTextInputBinder get_TeamNameNode(); // 0x068579c0
	FairyGUI.Controller get_CtrlShowMore(); // 0x06857a24
	System.Void .ctor(FairyGUI.GComponent root); // 0x06857a88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComDeclarationBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComTextInputBinder <Recruit>k__BackingField; // 0x18
	FairyGUI.GList <List>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComTextInputBinder get_Recruit(); // 0x068586dc
	FairyGUI.GList get_List(); // 0x06858740
	System.Void .ctor(FairyGUI.GComponent root); // 0x068587a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComDisplayModeBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GRichTextField <TextMode>k__BackingField; // 0x18
	FairyGUI.GComponent get_BinderRoot(); // 0x068588e8
	FairyGUI.GRichTextField get_TextMode(); // 0x0685894c
	System.Void .ctor(FairyGUI.GComponent root); // 0x06857f6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComGoodAtBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Title>k__BackingField; // 0x18
	FairyGUI.GList <Lsit>k__BackingField; // 0x20
	FairyGUI.GLabel get_Title(); // 0x068589b0
	FairyGUI.GList get_Lsit(); // 0x06858a14
	System.Void .ctor(FairyGUI.GComponent root); // 0x06858a78
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComInvitationMessageBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <MessageList>k__BackingField; // 0x18
	FairyGUI.GButton <ShieldBtn>k__BackingField; // 0x20
	FairyGUI.GButton <RefuseAllBtn>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlState>k__BackingField; // 0x30
	FairyGUI.GList get_MessageList(); // 0x06858b8c
	FairyGUI.GButton get_RefuseAllBtn(); // 0x06858bf0
	FairyGUI.Controller get_CtrlState(); // 0x06858c54
	System.Void .ctor(FairyGUI.GComponent root); // 0x06858cb8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionAppointmentTimeBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComboBox <AppointmentTimeComboBox>k__BackingField; // 0x18
	FairyGUI.GComponent get_BinderRoot(); // 0x06858e98
	FairyGUI.GComboBox get_AppointmentTimeComboBox(); // 0x06858efc
	System.Void .ctor(FairyGUI.GComponent root); // 0x06858188
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionModeAndMemberNumBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComboBox <ModeComboBox>k__BackingField; // 0x18
	FairyGUI.GList <MemberNumList>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlMemberNumStatus>k__BackingField; // 0x28
	FairyGUI.GComponent get_BinderRoot(); // 0x06858f60
	FairyGUI.GComboBox get_ModeComboBox(); // 0x06858fc4
	FairyGUI.GList get_MemberNumList(); // 0x06859028
	FairyGUI.Controller get_CtrlMemberNumStatus(); // 0x0685908c
	System.Void .ctor(FairyGUI.GComponent root); // 0x06858040
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionOpenServerTimeBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComboBox <ComboBox>k__BackingField; // 0x18
	FairyGUI.GComponent get_BinderRoot(); // 0x068590f0
	FairyGUI.GComboBox get_ComboBox(); // 0x06859154
	System.Void .ctor(FairyGUI.GComponent root); // 0x068591b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionTimeBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComboBox <DayComboBox>k__BackingField; // 0x18
	FairyGUI.GComboBox <TimeComboBox>k__BackingField; // 0x20
	FairyGUI.GComponent get_BinderRoot(); // 0x0685928c
	FairyGUI.GComboBox get_DayComboBox(); // 0x068592f0
	FairyGUI.GComboBox get_TimeComboBox(); // 0x06859354
	System.Void .ctor(FairyGUI.GComponent root); // 0x068585c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComPlatformBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <List>k__BackingField; // 0x18
	FairyGUI.GComponent get_BinderRoot(); // 0x068593b8
	FairyGUI.GList get_List(); // 0x0685941c
	System.Void .ctor(FairyGUI.GComponent root); // 0x06859480
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComRecruitBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComTextInputBinder <Recruit>k__BackingField; // 0x18
	FairyGUI.GList <List>k__BackingField; // 0x20
	FairyGUI.GComponent get_BinderRoot(); // 0x06859554
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComTextInputBinder get_Recruit(); // 0x068595b8
	FairyGUI.GList get_List(); // 0x0685961c
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685825c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComRecruitItemsBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionModeAndMemberNumBinder <ModeAndMemberNumNode>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionOpenServerTimeBinder <OpenServerTimeNode>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSkilledBinder <PlayerTagsNode>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSelect_TwoBinder <MicrophoneNode>k__BackingField; // 0x30
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComPlatformBinder <PlatformNode>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSelect_TwoBinder <ApplyForNode>k__BackingField; // 0x40
	FairyGUI.GGroup <Group>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionModeAndMemberNumBinder get_ModeAndMemberNumNode(); // 0x06859680
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionOpenServerTimeBinder get_OpenServerTimeNode(); // 0x068596e4
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSkilledBinder get_PlayerTagsNode(); // 0x06859748
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSelect_TwoBinder get_MicrophoneNode(); // 0x068597ac
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComPlatformBinder get_PlatformNode(); // 0x06859810
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSelect_TwoBinder get_ApplyForNode(); // 0x06859874
	System.Void .ctor(FairyGUI.GComponent root); // 0x068598d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSelect_ListBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Title>k__BackingField; // 0x18
	FairyGUI.GList <List>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlShowLine>k__BackingField; // 0x28
	FairyGUI.GComponent get_BinderRoot(); // 0x06859c38
	FairyGUI.GList get_List(); // 0x06859c9c
	System.Void .ctor(FairyGUI.GComponent root); // 0x06859d00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSelect_TwoBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <BtnOn>k__BackingField; // 0x18
	FairyGUI.GButton <BtnOff>k__BackingField; // 0x20
	FairyGUI.GComponent get_BinderRoot(); // 0x06859e48
	FairyGUI.GButton get_BtnOn(); // 0x06859eac
	FairyGUI.GButton get_BtnOff(); // 0x06859f10
	System.Void .ctor(FairyGUI.GComponent root); // 0x068584b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSelfBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComDeclarationBinder <Declaration>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComGoodAtBinder <GoodAt>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSelect_ListBinder <Mode>k__BackingField; // 0x28
	FairyGUI.GGroup <Conditions>k__BackingField; // 0x30
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComDeclarationBinder get_Declaration(); // 0x06859f74
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComGoodAtBinder get_GoodAt(); // 0x06859fd8
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSelect_ListBinder get_Mode(); // 0x0685a03c
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685a0a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSkilledBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Title>k__BackingField; // 0x18
	FairyGUI.GList <List>k__BackingField; // 0x20
	FairyGUI.GComponent get_BinderRoot(); // 0x0685a2c4
	FairyGUI.GList get_List(); // 0x0685a328
	System.Void .ctor(FairyGUI.GComponent root); // 0x068583a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComTextInputBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Title>k__BackingField; // 0x18
	FairyGUI.GComponent <InputField>k__BackingField; // 0x20
	FairyGUI.GTextField <Number>k__BackingField; // 0x28
	FairyGUI.GComponent get_BinderRoot(); // 0x0685a38c
	FairyGUI.GComponent get_InputField(); // 0x0685a3f0
	FairyGUI.GTextField get_Number(); // 0x0685a454
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685754c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.RootCommonTeamBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <TopBar>k__BackingField; // 0x18
	FairyGUI.GComponent <NavBar2>k__BackingField; // 0x20
	FairyGUI.GComponent <NavBar>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.RootCommonTeamContentBinder <Content>k__BackingField; // 0x30
	FairyGUI.GLabel get_TopBar(); // 0x0685a4b8
	FairyGUI.GComponent get_NavBar2(); // 0x0685a51c
	FairyGUI.GComponent get_NavBar(); // 0x0685a580
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.RootCommonTeamContentBinder get_Content(); // 0x0685a5e4
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685a648
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.RootCommonTeamContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <QuickInviteLoader>k__BackingField; // 0x18
	FairyGUI.GLoader <TeamHallLoader>k__BackingField; // 0x20
	FairyGUI.GLoader <RecommendFriendLoader>k__BackingField; // 0x28
	FairyGUI.GLoader <InviteInfoLoader>k__BackingField; // 0x30
	FairyGUI.GLoader <MyTeamLoader>k__BackingField; // 0x38
	FairyGUI.GLoader <ReserveHallLoader>k__BackingField; // 0x40
	FairyGUI.GLoader <GameHallLoader>k__BackingField; // 0x48
	FairyGUI.GButton <BtnOpenGmSearch>k__BackingField; // 0x50
	FairyGUI.GRichTextField <N20>k__BackingField; // 0x58
	FairyGUI.Controller <CtrlTabControl>k__BackingField; // 0x60
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x68
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x70
	FairyGUI.GLoader get_TeamHallLoader(); // 0x0685ab7c
	FairyGUI.GLoader get_RecommendFriendLoader(); // 0x0685abe0
	FairyGUI.GLoader get_MyTeamLoader(); // 0x0685ac44
	FairyGUI.GLoader get_ReserveHallLoader(); // 0x0685aca8
	FairyGUI.GLoader get_GameHallLoader(); // 0x0685ad0c
	FairyGUI.GButton get_BtnOpenGmSearch(); // 0x0685ad70
	FairyGUI.GRichTextField get_N20(); // 0x0685add4
	FairyGUI.Controller get_CtrlTabControl(); // 0x0685ae38
	FairyGUI.Transition get_TransShow_anim(); // 0x0685ae9c
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685a80c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.UiCommonTeamBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Bg>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.RootCommonTeamBinder <Root>k__BackingField; // 0x20
	FairyGUI.GComponent get_Bg(); // 0x0685af00
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.RootCommonTeamBinder get_Root(); // 0x0685af64
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685afc8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonShare.ComBgBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GGraph <Bg>k__BackingField; // 0x18
	FairyGUI.GLoader <BgLoader>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlType>k__BackingField; // 0x28
	FairyGUI.GLoader get_BgLoader(); // 0x0685b10c
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685b170
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonShare.ComCommercializationInfoBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <TitlePicic>k__BackingField; // 0x18
	FairyGUI.GLoader <Mark>k__BackingField; // 0x20
	FairyGUI.GTextField <Desc2>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlShowinfo>k__BackingField; // 0x30
	FairyGUI.GComponent get_BinderRoot(); // 0x0685b2b8
	FairyGUI.GLoader get_TitlePicic(); // 0x0685b31c
	FairyGUI.GLoader get_Mark(); // 0x0685b380
	FairyGUI.GTextField get_Desc2(); // 0x0685b3e4
	FairyGUI.Controller get_CtrlShowinfo(); // 0x0685b448
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685b4ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonShare.ComPlayerInfoBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Avatar>k__BackingField; // 0x18
	FairyGUI.GTextField <Name>k__BackingField; // 0x20
	FairyGUI.GComponent get_Avatar(); // 0x0685b634
	FairyGUI.GTextField get_Name(); // 0x0685b698
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685b6fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonShare.ComSharePicBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.RootCommonShare_ComShotBinder <ShareCom>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.RootCommonShare_ComShotBinder get_ShareCom(); // 0x0685b810
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685b874
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonShare.ComSkinInfoBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GRichTextField <Name>k__BackingField; // 0x18
	FairyGUI.GRichTextField <Desc>k__BackingField; // 0x20
	FairyGUI.GRichTextField <Desc2>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlNumInfoState>k__BackingField; // 0x30
	FairyGUI.GComponent get_BinderRoot(); // 0x0685bc04
	FairyGUI.GRichTextField get_Name(); // 0x0685bc68
	FairyGUI.GRichTextField get_Desc(); // 0x0685bccc
	FairyGUI.GRichTextField get_Desc2(); // 0x0685bd30
	FairyGUI.Controller get_CtrlNumInfoState(); // 0x0685bd94
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685bdf8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonShare.ComWatermarkerDefaultBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.ComPlayerInfoBinder <PlayerInfo>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlPlayerInfoState>k__BackingField; // 0x20
	FairyGUI.GComponent get_BinderRoot(); // 0x0685bf80
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.ComPlayerInfoBinder get_PlayerInfo(); // 0x0685bfe4
	FairyGUI.Controller get_CtrlPlayerInfoState(); // 0x0685c048
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685c0ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonShare.RootCommonShareBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.RootCommonShare_ComShotBinder <ComShot>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.RootCommonShare_ComShareBinder <ComShare>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlStep>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.RootCommonShare_ComShotBinder get_ComShot(); // 0x0685c1e4
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.RootCommonShare_ComShareBinder get_ComShare(); // 0x0685c248
	FairyGUI.Controller get_CtrlStep(); // 0x0685c2ac
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685c310
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonShare.RootCommonShare_ComShareBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.ComSharePicBinder <ComSharePic>k__BackingField; // 0x18
	FairyGUI.GButton <SaveBtn>k__BackingField; // 0x20
	FairyGUI.GButton <WxBtn>k__BackingField; // 0x28
	FairyGUI.GButton <WxZoneBtn>k__BackingField; // 0x30
	FairyGUI.GButton <QqBtn>k__BackingField; // 0x38
	FairyGUI.GButton <QqZoneBtn>k__BackingField; // 0x40
	FairyGUI.GGroup <ChannelGroup>k__BackingField; // 0x48
	FairyGUI.GButton <CloseBtn>k__BackingField; // 0x50
	FairyGUI.GButton <PlayerInfoSelect>k__BackingField; // 0x58
	FairyGUI.GButton <NumInfoSelect>k__BackingField; // 0x60
	FairyGUI.GButton <LotteryNumSelect>k__BackingField; // 0x68
	FairyGUI.Controller <CtrlChannelType>k__BackingField; // 0x70
	FairyGUI.GComponent get_BinderRoot(); // 0x0685c870
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.ComSharePicBinder get_ComSharePic(); // 0x0685c8d4
	FairyGUI.GButton get_SaveBtn(); // 0x0685c938
	FairyGUI.GButton get_WxBtn(); // 0x0685c99c
	FairyGUI.GButton get_WxZoneBtn(); // 0x0685ca00
	FairyGUI.GButton get_QqBtn(); // 0x0685ca64
	FairyGUI.GButton get_QqZoneBtn(); // 0x0685cac8
	FairyGUI.GGroup get_ChannelGroup(); // 0x0685cb2c
	FairyGUI.GButton get_CloseBtn(); // 0x0685cb90
	FairyGUI.GButton get_PlayerInfoSelect(); // 0x0685cbf4
	FairyGUI.GButton get_NumInfoSelect(); // 0x0685cc58
	FairyGUI.GButton get_LotteryNumSelect(); // 0x0685ccbc
	FairyGUI.Controller get_CtrlChannelType(); // 0x0685cd20
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685c4b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonShare.RootCommonShare_ComShotBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <ShotLoader>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.ComSkinInfoBinder <SkinWatermark>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.ComCommercializationInfoBinder <CommercializationWatermark>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.ComWatermarkerDefaultBinder <GameInfo>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlWatermarkType>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlGameInfoState>k__BackingField; // 0x40
	FairyGUI.GComponent get_BinderRoot(); // 0x0685cd84
	FairyGUI.GLoader get_ShotLoader(); // 0x0685cde8
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.ComSkinInfoBinder get_SkinWatermark(); // 0x0685ce4c
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.ComCommercializationInfoBinder get_CommercializationWatermark(); // 0x0685ceb0
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.ComWatermarkerDefaultBinder get_GameInfo(); // 0x0685cf14
	FairyGUI.Controller get_CtrlWatermarkType(); // 0x0685cf78
	FairyGUI.Controller get_CtrlGameInfoState(); // 0x0685cfdc
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685b978
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonShare.UiCommonShareBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.ComBgBinder <Bg>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.RootCommonShareBinder <Root>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.ComBgBinder get_Bg(); // 0x0685d040
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.RootCommonShareBinder get_Root(); // 0x0685d0a4
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685d108
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonReward.ComRewardBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Modal>k__BackingField; // 0x18
	FairyGUI.GList <List>k__BackingField; // 0x20
	FairyGUI.GTextField <Text>k__BackingField; // 0x28
	FairyGUI.GLabel get_Modal(); // 0x0685d27c
	FairyGUI.GList get_List(); // 0x0685d2e0
	FairyGUI.GTextField get_Text(); // 0x0685d344
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685d3a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonReward.ComRewardItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Text>k__BackingField; // 0x18
	FairyGUI.GList <List>k__BackingField; // 0x20
	FairyGUI.GButton <Btn>k__BackingField; // 0x28
	FairyGUI.GTextField get_Text(); // 0x0685d4fc
	FairyGUI.GList get_List(); // 0x0685d560
	FairyGUI.GButton get_Btn(); // 0x0685d5c4
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685d628
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonReward.UiRewardBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonReward.ComRewardBinder <Root>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonReward.ComRewardBinder get_Root(); // 0x0685d77c
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685d7e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonRank.BtnRankingBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Rank>k__BackingField; // 0x18
	FairyGUI.GTextField <NormalRank>k__BackingField; // 0x20
	FairyGUI.GLabel <Name>k__BackingField; // 0x28
	FairyGUI.GLoader <Information>k__BackingField; // 0x30
	FairyGUI.GList <ListIcon>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlRank>k__BackingField; // 0x48
	FairyGUI.GTextField get_Rank(); // 0x0685d8e4
	FairyGUI.GTextField get_NormalRank(); // 0x0685d948
	FairyGUI.GLabel get_Name(); // 0x0685d9ac
	FairyGUI.GLoader get_Information(); // 0x0685da10
	FairyGUI.GList get_ListIcon(); // 0x0685da74
	FairyGUI.Controller get_CtrlRank(); // 0x0685dad8
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685db3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonRank.ComPintsBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Icon>k__BackingField; // 0x18
	FairyGUI.GTextField <Num>k__BackingField; // 0x20
	FairyGUI.GLoader get_Icon(); // 0x0685dd64
	FairyGUI.GTextField get_Num(); // 0x0685ddc8
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685de2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonRank.ComRankingBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <ListRank>k__BackingField; // 0x18
	FairyGUI.GList <ListReward>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.CommonRank.BtnRankingBinder <Self>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.CommonRank.ComRewardBinder <SelfReward>k__BackingField; // 0x30
	FairyGUI.GComponent <Loading>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlType>k__BackingField; // 0x48
	FairyGUI.GList get_ListRank(); // 0x0685df40
	FairyGUI.GList get_ListReward(); // 0x0685dfa4
	WizardGames.Soc.SocClient.Ui.Binder.CommonRank.BtnRankingBinder get_Self(); // 0x0685e008
	WizardGames.Soc.SocClient.Ui.Binder.CommonRank.ComRewardBinder get_SelfReward(); // 0x0685e06c
	FairyGUI.GComponent get_Loading(); // 0x0685e0d0
	FairyGUI.Controller get_CtrlStatus(); // 0x0685e134
	FairyGUI.Controller get_CtrlType(); // 0x0685e198
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685e1fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonRank.ComRankingTitleBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Rank>k__BackingField; // 0x18
	FairyGUI.GTextField <Name>k__BackingField; // 0x20
	FairyGUI.GTextField <Score>k__BackingField; // 0x28
	FairyGUI.GTextField <Honour>k__BackingField; // 0x30
	FairyGUI.GTextField get_Rank(); // 0x0685e704
	FairyGUI.GTextField get_Name(); // 0x0685e768
	FairyGUI.GTextField get_Score(); // 0x0685e7cc
	FairyGUI.GTextField get_Honour(); // 0x0685e830
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685e894
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonRank.ComRankRewardBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Icon>k__BackingField; // 0x18
	FairyGUI.GImage <Line>k__BackingField; // 0x20
	FairyGUI.GComponent get_Icon(); // 0x0685ea28
	FairyGUI.GImage get_Line(); // 0x0685ea8c
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685eaf0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonRank.ComRewardBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <ListReward>k__BackingField; // 0x18
	FairyGUI.GTextField <Ranking>k__BackingField; // 0x20
	FairyGUI.GLabel <Name>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlPlatform>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlType>k__BackingField; // 0x38
	FairyGUI.GList get_ListReward(); // 0x0685ec04
	FairyGUI.GTextField get_Ranking(); // 0x0685ec68
	FairyGUI.GLabel get_Name(); // 0x0685eccc
	FairyGUI.Controller get_CtrlType(); // 0x0685ed30
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685e548
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonRank.RootRankBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <TopBar>k__BackingField; // 0x18
	FairyGUI.GComponent <NavBar>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.CommonRank.RootRankContentBinder <Content>k__BackingField; // 0x28
	FairyGUI.GLabel get_TopBar(); // 0x0685ed94
	FairyGUI.GComponent get_NavBar(); // 0x0685edf8
	WizardGames.Soc.SocClient.Ui.Binder.CommonRank.RootRankContentBinder get_Content(); // 0x0685ee5c
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685eec0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonRank.RootRankContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <Empty>k__BackingField; // 0x18
	FairyGUI.GComponent <TeamItem0>k__BackingField; // 0x20
	FairyGUI.GComponent <TeamItem1>k__BackingField; // 0x28
	FairyGUI.GComponent <TeamItem2>k__BackingField; // 0x30
	FairyGUI.GComponent <TeamItem3>k__BackingField; // 0x38
	FairyGUI.GList <SubTabList>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.CommonRank.ComRankingTitleBinder <Header>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Ui.Binder.CommonRank.ComRankingBinder <Ranking>k__BackingField; // 0x50
	FairyGUI.Controller <CtrlPlatform>k__BackingField; // 0x58
	FairyGUI.Controller <CtrlType>k__BackingField; // 0x60
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x68
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x70
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x78
	FairyGUI.GComponent get_BinderRoot(); // 0x0685f43c
	FairyGUI.GButton get_Empty(); // 0x0685f4a0
	FairyGUI.GComponent get_TeamItem0(); // 0x0685f504
	FairyGUI.GComponent get_TeamItem1(); // 0x0685f568
	FairyGUI.GComponent get_TeamItem2(); // 0x0685f5cc
	FairyGUI.GComponent get_TeamItem3(); // 0x0685f630
	FairyGUI.GList get_SubTabList(); // 0x0685f694
	WizardGames.Soc.SocClient.Ui.Binder.CommonRank.ComRankingTitleBinder get_Header(); // 0x0685f6f8
	WizardGames.Soc.SocClient.Ui.Binder.CommonRank.ComRankingBinder get_Ranking(); // 0x0685f75c
	FairyGUI.Controller get_CtrlType(); // 0x0685f7c0
	FairyGUI.Controller get_CtrlStatus(); // 0x0685f824
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685f044
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonRank.UiRankBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Bg>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonRank.RootRankBinder <Root>k__BackingField; // 0x20
	FairyGUI.GLoader get_Bg(); // 0x0685f888
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685f8ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.AwardHistoryListBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Time>k__BackingField; // 0x18
	FairyGUI.GList <BadgeList>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.AwardHistory_BadgeInfoBinder <Name>k__BackingField; // 0x28
	FairyGUI.GTextField get_Time(); // 0x0685fa30
	FairyGUI.GList get_BadgeList(); // 0x0685fa94
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.AwardHistory_BadgeInfoBinder get_Name(); // 0x0685faf8
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685fb5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.AwardHistory_BadgeInfoBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Badgename>k__BackingField; // 0x18
	FairyGUI.GLoader <Badgeicon>k__BackingField; // 0x20
	FairyGUI.GTextField <Add>k__BackingField; // 0x28
	FairyGUI.GTextField get_Badgename(); // 0x0685fe34
	FairyGUI.GLoader get_Badgeicon(); // 0x0685fe98
	FairyGUI.GTextField get_Add(); // 0x0685fefc
	System.Void .ctor(FairyGUI.GComponent root); // 0x0685fce0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.BadgeTaskItem_lobbyBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Number>k__BackingField; // 0x18
	FairyGUI.GImage <Icon>k__BackingField; // 0x20
	FairyGUI.GTextField <Score>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlShowIcon>k__BackingField; // 0x30
	FairyGUI.GTextField get_Number(); // 0x0685ff60
	FairyGUI.Controller get_CtrlShowIcon(); // 0x0685ffc4
	System.Void .ctor(FairyGUI.GComponent root); // 0x06860028
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.BadgeTaskList_lobbyBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Title1new>k__BackingField; // 0x18
	FairyGUI.GTextField <Title>k__BackingField; // 0x20
	FairyGUI.GList <Tasklist>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlIsTitle>k__BackingField; // 0x30
	FairyGUI.GLabel get_Title1new(); // 0x068601b0
	FairyGUI.GTextField get_Title(); // 0x06860214
	FairyGUI.GList get_Tasklist(); // 0x06860278
	FairyGUI.Controller get_CtrlIsTitle(); // 0x068602dc
	System.Void .ctor(FairyGUI.GComponent root); // 0x06860340
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComChangeNameBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.RootChangeNameBinder <Root>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.RootChangeNameBinder get_Root(); // 0x068604c8
	System.Void .ctor(FairyGUI.GComponent root); // 0x0686052c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComGameStyleBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GGraph <Bg>k__BackingField; // 0x18
	FairyGUI.GList <StyleList>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x28
	FairyGUI.GComponent get_BinderRoot(); // 0x0686086c
	FairyGUI.GList get_StyleList(); // 0x068608d0
	FairyGUI.Controller get_CtrlStatus(); // 0x06860934
	System.Void .ctor(FairyGUI.GComponent root); // 0x06860998
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComiconBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Icon>k__BackingField; // 0x18
	FairyGUI.GComponent get_Icon(); // 0x06860ae0
	System.Void .ctor(FairyGUI.GComponent root); // 0x06860b44
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComIntegralBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GImage <Normal>k__BackingField; // 0x18
	FairyGUI.GImage <Selected>k__BackingField; // 0x20
	FairyGUI.GTextField <Title>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x30
	FairyGUI.GTextField get_Title(); // 0x06860c18
	System.Void .ctor(FairyGUI.GComponent root); // 0x06860c7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComMedalQualityBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Text>k__BackingField; // 0x18
	FairyGUI.GTextField <Quantity>k__BackingField; // 0x20
	FairyGUI.GLoader <Icon>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlType>k__BackingField; // 0x30
	FairyGUI.GTextField get_Text(); // 0x06860e04
	FairyGUI.GTextField get_Quantity(); // 0x06860e68
	FairyGUI.Controller get_CtrlType(); // 0x06860ecc
	System.Void .ctor(FairyGUI.GComponent root); // 0x06860f30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComRatingBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Title>k__BackingField; // 0x18
	FairyGUI.GList <Textlist>k__BackingField; // 0x20
	FairyGUI.GLabel get_Title(); // 0x068610b8
	FairyGUI.GList get_Textlist(); // 0x0686111c
	System.Void .ctor(FairyGUI.GComponent root); // 0x06861180
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComRewardBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Title>k__BackingField; // 0x18
	FairyGUI.GList <Listicon>k__BackingField; // 0x20
	FairyGUI.GList get_Listicon(); // 0x068612ec
	System.Void .ctor(FairyGUI.GComponent root); // 0x06861350
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComSeasonStyleGroupBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.HomePage_ComSeasonBinder <SeasonCom>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComGameStyleBinder <Style>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.HomePage_ComSeasonBinder get_SeasonCom(); // 0x068614bc
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComGameStyleBinder get_Style(); // 0x06861520
	FairyGUI.Controller get_CtrlStatus(); // 0x06861584
	System.Void .ctor(FairyGUI.GComponent root); // 0x068615e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComSkinChatBubbleBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <AvatarCom>k__BackingField; // 0x18
	FairyGUI.GTextField <Name>k__BackingField; // 0x20
	FairyGUI.GComponent <BubbleCom>k__BackingField; // 0x28
	FairyGUI.GComponent get_AvatarCom(); // 0x068619a4
	FairyGUI.GTextField get_Name(); // 0x06861a08
	FairyGUI.GComponent get_BubbleCom(); // 0x06861a6c
	System.Void .ctor(FairyGUI.GComponent root); // 0x06861ad0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComSkinDetailBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Title>k__BackingField; // 0x18
	FairyGUI.GTextField <Desc>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComSkinOpBinder <OpCom>k__BackingField; // 0x28
	FairyGUI.GTextField <Time>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlQuality>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlLimited>k__BackingField; // 0x40
	FairyGUI.GLabel get_Title(); // 0x06861c24
	FairyGUI.GTextField get_Desc(); // 0x06861c88
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComSkinOpBinder get_OpCom(); // 0x06861cec
	FairyGUI.GTextField get_Time(); // 0x06861d50
	FairyGUI.Controller get_CtrlQuality(); // 0x06861db4
	FairyGUI.Controller get_CtrlLimited(); // 0x06861e18
	System.Void .ctor(FairyGUI.GComponent root); // 0x06861e7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComSkinNameCardBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <CardBg>k__BackingField; // 0x18
	FairyGUI.GComponent <AvatarCom>k__BackingField; // 0x20
	FairyGUI.GTextField <Name>k__BackingField; // 0x28
	FairyGUI.GComponent get_CardBg(); // 0x068621f0
	FairyGUI.GComponent get_AvatarCom(); // 0x06862254
	FairyGUI.GTextField get_Name(); // 0x068622b8
	System.Void .ctor(FairyGUI.GComponent root); // 0x0686231c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComSkinOpBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <ConfirmBtn>k__BackingField; // 0x18
	FairyGUI.GTextField <Getpath>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlLock>k__BackingField; // 0x28
	FairyGUI.GButton get_ConfirmBtn(); // 0x06862470
	FairyGUI.GTextField get_Getpath(); // 0x068624d4
	FairyGUI.Controller get_CtrlLock(); // 0x06862538
	System.Void .ctor(FairyGUI.GComponent root); // 0x068620a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComStyleStateItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GGraph <Bg>k__BackingField; // 0x18
	FairyGUI.GComponent <Icon>k__BackingField; // 0x20
	FairyGUI.GTextField <Title>k__BackingField; // 0x28
	FairyGUI.GTextField <Text>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x38
	FairyGUI.GComponent get_Icon(); // 0x0686259c
	FairyGUI.GTextField get_Title(); // 0x06862600
	FairyGUI.GTextField get_Text(); // 0x06862664
	FairyGUI.Controller get_CtrlStatus(); // 0x068626c8
	System.Void .ctor(FairyGUI.GComponent root); // 0x0686272c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComtextBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Mode>k__BackingField; // 0x18
	FairyGUI.GTextField <Quantity>k__BackingField; // 0x20
	FairyGUI.GTextField get_Mode(); // 0x068628f4
	FairyGUI.GTextField get_Quantity(); // 0x06862958
	System.Void .ctor(FairyGUI.GComponent root); // 0x068629bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.DetailBadge_BadgeInfoBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <MedalsName>k__BackingField; // 0x18
	FairyGUI.GComponent <Icon>k__BackingField; // 0x20
	FairyGUI.GTextField <Experience>k__BackingField; // 0x28
	FairyGUI.GImage <Icon_exp>k__BackingField; // 0x30
	FairyGUI.GProgressBar <Progress>k__BackingField; // 0x38
	System.Void .ctor(FairyGUI.GComponent root); // 0x06862ad0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.DetailBadge_ComItemICONBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <ComMedal>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlUnlock>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlType>k__BackingField; // 0x30
	FairyGUI.Transition <TransUnlock>k__BackingField; // 0x38
	FairyGUI.Transition <TransSwitch>k__BackingField; // 0x40
	FairyGUI.GComponent get_BinderRoot(); // 0x06862ca4
	FairyGUI.GComponent get_ComMedal(); // 0x06862d08
	FairyGUI.Controller get_CtrlUnlock(); // 0x06862d6c
	FairyGUI.Controller get_CtrlType(); // 0x06862dd0
	FairyGUI.Transition get_TransUnlock(); // 0x06862e34
	System.Void .ctor(FairyGUI.GComponent root); // 0x06862e98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.DetailBadge_MedalInterfaceListBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <List>k__BackingField; // 0x18
	FairyGUI.GLoader <Icon>k__BackingField; // 0x20
	FairyGUI.GRichTextField <UnlockText>k__BackingField; // 0x28
	FairyGUI.GList get_List(); // 0x0686305c
	FairyGUI.GRichTextField get_UnlockText(); // 0x068630c0
	System.Void .ctor(FairyGUI.GComponent root); // 0x06863124
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.DetailData_ListBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <Data1>k__BackingField; // 0x18
	FairyGUI.GList <Data2>k__BackingField; // 0x20
	FairyGUI.GComponent <ComTime>k__BackingField; // 0x28
	FairyGUI.GComponent <ComTime2>k__BackingField; // 0x30
	System.Void .ctor(FairyGUI.GComponent root); // 0x06863278
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.DetailData_RadarBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GGraph <Radar>k__BackingField; // 0x18
	FairyGUI.GGraph <Radar1>k__BackingField; // 0x20
	System.Void .ctor(FairyGUI.GComponent root); // 0x0686340c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.DetailMedalInterfaceBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <MedalsName>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComMedalBinder <Icon>k__BackingField; // 0x20
	FairyGUI.GTextField <Experience>k__BackingField; // 0x28
	FairyGUI.GProgressBar <Progress>k__BackingField; // 0x30
	FairyGUI.GList <List>k__BackingField; // 0x38
	FairyGUI.GTextField <NameText2>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlType>k__BackingField; // 0x48
	FairyGUI.GTextField get_MedalsName(); // 0x06863520
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComMedalBinder get_Icon(); // 0x06863584
	FairyGUI.GTextField get_Experience(); // 0x068635e8
	FairyGUI.GProgressBar get_Progress(); // 0x0686364c
	FairyGUI.GList get_List(); // 0x068636b0
	FairyGUI.GTextField get_NameText2(); // 0x06863714
	FairyGUI.Controller get_CtrlType(); // 0x06863778
	System.Void .ctor(FairyGUI.GComponent root); // 0x068637dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.HomePage_ComGameStyleBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <List>k__BackingField; // 0x18
	FairyGUI.GButton <Btn>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlState>k__BackingField; // 0x28
	FairyGUI.GButton get_Btn(); // 0x06863a58
	System.Void .ctor(FairyGUI.GComponent root); // 0x06863abc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.HomePage_ComNameCardBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <CardBg>k__BackingField; // 0x18
	FairyGUI.GComponent <AvatarCom>k__BackingField; // 0x20
	FairyGUI.GButton <Name>k__BackingField; // 0x28
	FairyGUI.GButton <ChangeCardBtn>k__BackingField; // 0x30
	FairyGUI.GButton <CopyPlayerUid>k__BackingField; // 0x38
	FairyGUI.GProgressBar <Exp>k__BackingField; // 0x40
	FairyGUI.GButton <AppWelfare1>k__BackingField; // 0x48
	FairyGUI.GButton <AppWelfare2>k__BackingField; // 0x50
	FairyGUI.Controller <CtrlIsSelf>k__BackingField; // 0x58
	FairyGUI.GComponent get_BinderRoot(); // 0x06863c04
	FairyGUI.GComponent get_CardBg(); // 0x06863c68
	FairyGUI.GComponent get_AvatarCom(); // 0x06863ccc
	FairyGUI.GButton get_Name(); // 0x06863d30
	FairyGUI.GButton get_ChangeCardBtn(); // 0x06863d94
	FairyGUI.GButton get_CopyPlayerUid(); // 0x06863df8
	FairyGUI.GProgressBar get_Exp(); // 0x06863e5c
	FairyGUI.GButton get_AppWelfare1(); // 0x06863ec0
	FairyGUI.GButton get_AppWelfare2(); // 0x06863f24
	System.Void .ctor(FairyGUI.GComponent root); // 0x06863f88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.HomePage_ComSeasonBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Icon>k__BackingField; // 0x18
	FairyGUI.GTextField <RankTitle>k__BackingField; // 0x20
	FairyGUI.GTextField <Num>k__BackingField; // 0x28
	FairyGUI.GLoader <BestIcon>k__BackingField; // 0x30
	FairyGUI.GTextField <BestRank>k__BackingField; // 0x38
	FairyGUI.GButton <Btn>k__BackingField; // 0x40
	FairyGUI.GComponent get_BinderRoot(); // 0x06864250
	FairyGUI.GComponent get_Icon(); // 0x068642b4
	FairyGUI.GTextField get_RankTitle(); // 0x06864318
	FairyGUI.GTextField get_Num(); // 0x0686437c
	System.Void .ctor(FairyGUI.GComponent root); // 0x06861790
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.HomePage_ComTagBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <TagList>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlIsSelf>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlEmpty>k__BackingField; // 0x28
	FairyGUI.GComponent get_BinderRoot(); // 0x068643e0
	FairyGUI.GList get_TagList(); // 0x06864444
	FairyGUI.Controller get_CtrlEmpty(); // 0x068644a8
	System.Void .ctor(FairyGUI.GComponent root); // 0x0686450c
}

