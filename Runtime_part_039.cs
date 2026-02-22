	WizardGames.Soc.Common.Data.EBuildFirstModeType get_CurrentFirstModeType(); // 0x06a3f66c
	System.Void set_CurrentFirstModeType(WizardGames.Soc.Common.Data.EBuildFirstModeType value); // 0x06a3f6d0
	WizardGames.Soc.Common.Data.EBuildSecondModeType get_CurrentSecondModeType(); // 0x06a3f748
	System.Void set_CurrentSecondModeType(WizardGames.Soc.Common.Data.EBuildSecondModeType value); // 0x06a3f7ac
	System.Void OnInit(); // 0x06a3f824
	System.Void OnEnter(); // 0x06a3f9b0
	System.Void OnExit(); // 0x06a3fafc
	System.Void OnExitTerritory(System.Int64 territoryEntityId); // 0x06a3fc70
	System.Void OnCustomBlueprintDataChange(); // 0x06a3fd50
	System.Void OnEnterTerritory(System.Int64 territoryEntityId); // 0x06a40124
	System.Void ExitSkinModeNoPermission(); // 0x06a4030c
	System.Void CollectBuildModeData(); // 0x06a40408
	System.Void SetCurBuildItemData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData, System.Boolean refreshUi); // 0x06a40a58
	System.Void UiBuildItemSelect(); // 0x06a4164c
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase GetSelectedBuildItemData(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase> buildItemDatas, WizardGames.Soc.SocClient.Ui.SelectedBuildData selectedBuildData); // 0x06a418fc
	System.Void EnterFirstBuildMode(); // 0x06a41aa4
	System.Void EnterFirstBuildModeImpl(WizardGames.Soc.Common.Data.EBuildFirstModeType firstModeType, System.Boolean autoEnterSubMode); // 0x06a41b10
	System.Void EnterSecondBuildMode(WizardGames.Soc.Common.Data.EBuildSecondModeType secondModeType, System.Boolean autoEnterSubMode); // 0x06a4240c
	System.Void SwitchSecondBuildMode(); // 0x06a43288
	System.Void ProcessBuildData(); // 0x06a43528
	System.Void FindMIssionMarkerItems(); // 0x06a43e58
	System.Void SetBuildPanelDataList(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase> buildItemDataList, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.BuildTagData> discardSecondTagList, System.Boolean autoSelectData); // 0x06a3ff64
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase GetDefaultItemData(); // 0x06a44708
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase GetFirstPartViewDataBase(); // 0x06a44c7c
	System.Void RefreshHasDeployItemDataList(System.Int32 firstTagId); // 0x06a44f0c
	System.Boolean IsDiscardSecondTag(WizardGames.Soc.SocClient.Ui.Construction.BuildTagData tagData); // 0x06a44be0
	WizardGames.Soc.Common.Data.EBuildThirdModeType GetThirdModeType(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x06a40f7c
	WizardGames.Soc.Common.Data.EBuildThirdModeType GetThirdModeType(); // 0x06a429c0
	System.Void EnterBuildMode(WizardGames.Soc.Common.Data.EBuildThirdModeType thirdModeType); // 0x06a450b4
	System.Void EnterBuildMode(WizardGames.Soc.Common.Data.EBuildFirstModeType firstModeType, WizardGames.Soc.Common.Data.EBuildSecondModeType secondModeType, WizardGames.Soc.Common.Data.EBuildThirdModeType thirdModeType); // 0x06a455fc
	System.Void GetSelectedBuildData(WizardGames.Soc.Common.Data.EBuildSecondModeType secondModeType, WizardGames.Soc.SocClient.Ui.SelectedBuildData& selectedBuildData); // 0x06a40cb0
	System.Void ClearSelectedData(); // 0x06a421cc
	System.Void ExitBuildMode(); // 0x06a45c78
	System.Void ClearPartViewDataClassify(); // 0x06a43d2c
	System.Void SetTargetSelectedBuildData(WizardGames.Soc.SocClient.Ui.SelectedBuildData selectedBuildData, System.Boolean clearAfterUse, System.Boolean place); // 0x06a46524
	System.Void PartTransformationOver(); // 0x06a46974
	System.Void ClearTargetSelectedBuildData(); // 0x06a469ec
	System.Boolean MatchGuideTarget(System.Int64 templateId, System.Int64 comboId); // 0x06a46c88
	System.Boolean MatchGuideTarget(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase itemData); // 0x06a46dec
	System.Void DealTargetSelect(WizardGames.Soc.Common.Data.EBuildSecondModeType secondModeType); // 0x06a4447c
	System.Void TriggerGuide(); // 0x06a46e84
	System.Void UpgradeWallGuide(System.Int32 guideId, System.Int32 stepId); // 0x06a4726c
	System.Void ChangeWallToDoorGuide(System.Int32 guideId, System.Int32 stepId); // 0x06a476b0
	System.Void BuildSleepingBagGuide(System.Int32 guideId, System.Int32 stepId); // 0x06a473dc
	System.Void BuildWallDoorwayDoorGuide(System.Int32 guideId, System.Int32 stepId); // 0x06a4790c
	System.Void WaitGuidePartCreate(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06a47c84
	System.Boolean get_IsBlueprintBuildMode(); // 0x06a47e28
	System.Boolean get_IsEmptyHandMode(); // 0x06a47f64
	System.Boolean get_IsDeployMode(); // 0x06a480a0
	System.Boolean get_IsBuildWireMode(); // 0x06a481dc
	System.Boolean get_IsBuildSkinMode(); // 0x06a48318
	System.Boolean get_IsBuildCoreMode(); // 0x06a48454
	Construction.BuildMode.BuildSkinMode get_SkinMode(); // 0x06a48590
	System.Boolean get_IsInBuildModeWithoutShortcuts(); // 0x06a486cc
	System.Boolean get_IsInBuildEditMode(); // 0x06a4894c
	System.Boolean get_IsInUiDeployBuildMode(); // 0x06a48a88
	System.Boolean get_IsInRepairMode(); // 0x06a48bc8
	System.Boolean get_IsInElectricDeployMode(); // 0x06a48d24
	System.Boolean get_IsCampingTentDeployMode(); // 0x06a48dd4
	System.Boolean get_IsInDeployMoveMode(); // 0x06a48f1c
	System.Boolean get_IsInBuildPlaceMode(); // 0x06a49094
	System.Void SetLastSelectedDataDict(WizardGames.Soc.SocClient.Ui.SelectedBuildData selectedBuildData); // 0x06a491a4
	WizardGames.Soc.SocClient.Ui.SelectedBuildData GetLastSelectedDataDict(System.Int32 firstTagId, System.Int32 secondTagId); // 0x06a49a08
	System.Void SetLastFirstTagSelectedSecondTagId(WizardGames.Soc.SocClient.Ui.SelectedBuildData copy); // 0x06a496e4
	System.Int32 GetLastFirstTagSelectedSecondTagId(System.Int32 firstTagId); // 0x06a49ce8
	System.Void ClearRecordData(); // 0x06a457cc
	System.Void set_EditorGrade(System.Int64 value); // 0x06a49f00
	System.Int64 get_EditorGrade(); // 0x06a49f78
	System.Boolean get_IsHaveRecommend(); // 0x06a49fdc
	WizardGames.Soc.SocClient.Ui.SelectedBuildData get_SelectedBuildDataRecommend(); // 0x06a4a040
	System.Void RecordChangeData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase itemData); // 0x06a4a0a4
	System.Void RecordChangeType(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase itemData, System.Boolean targetIsCombo); // 0x06a4a3e4
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase GetDefaultChangeItemData(); // 0x06a44a64
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase GetTargetUpgradeData(); // 0x06a4aaec
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase GetModifyDataByCategory(); // 0x06a4a710
	System.Void .ctor(); // 0x06a4b45c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.BuildOperationBase : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Event.MsgHandler msgHandler; // 0x10
	static WizardGames.Soc.SocClient.Construction.BuildMode.WireTool WireTool; // 0x8
	static WizardGames.Soc.SocClient.Ui.ConstructionInfoData ConstructionInfoData; // 0x10
	static WizardGames.Soc.SocClient.Construction.BuildMode.IBuildMode <CurrentMode>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase CurBuildItemData; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase> CurBuildItemDataList; // 0x20
	System.Boolean isInit; // 0x28
	static WizardGames.Soc.SocClient.Construction.BuildMode.IBuildMode get_CurrentMode(); // 0x06a4ba3c
	static System.Void set_CurrentMode(WizardGames.Soc.SocClient.Construction.BuildMode.IBuildMode value); // 0x06a4bac4
	WizardGames.Soc.SocClient.Manager.EditTargetPartData get_EditTargetPart(); // 0x06a4a350
	System.Void OnInit(); // 0x06a3f888
	System.Void OnEnter(); // 0x06a3fa14
	System.Void OnExit(); // 0x06a3fc00
	System.Void OnCustomBlueprintDataChange(); // 0x06a3ff04
	System.Void CollectBuildModeData(); // 0x06a4bb58
	System.Void OnEnterTerritory(System.Int64 territoryEntityId); // 0x06a4bbb8
	System.Void OnExitTerritory(System.Int64 territoryEntityId); // 0x06a4bc2c
	System.Void ExitSkinModeNoPermission(); // 0x06a4bca0
	System.Void PlayerStateAction(System.Int32 stateId); // 0x06a4bd00
	System.Void ClearWireToolCache(System.Int32 state); // 0x06a4bd88
	System.Void TriggerGuide(); // 0x06a4be54
	System.Void SetCurBuildItemData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData, System.Boolean refreshUi); // 0x06a4beb4
	System.Void ReleaseBuildItemData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x06a4bf30
	System.Boolean HaveSkinMode(); // 0x06a402a8
	System.Void ExitBuildModeState(); // 0x06a40374
	System.Void ExitBuildMode(); // 0x06a46068
	WizardGames.Soc.Common.Data.EBuildThirdModeType GetCurrentBuildThirdModeType(); // 0x06a46138
	System.Void EnterBuildThirdMode(WizardGames.Soc.Common.Data.EBuildThirdModeType thirdModeType, System.Boolean addEmpty); // 0x06a41128
	System.Void ExitCurrentThirdMode(WizardGames.Soc.Common.Data.EBuildThirdModeType nextBuildModeType); // 0x06a42d38
	System.Void BuildModeChange(); // 0x06a46474
	System.Void UpdateUiHudState(WizardGames.Soc.Common.Data.EBuildThirdModeType thirdModeType, System.Boolean isOpen); // 0x06a4c074
	System.Boolean IsShortcutsDeployModeType(WizardGames.Soc.Common.Data.EBuildThirdModeType thirdModeType); // 0x06a463f4
	System.Void EnterFirstBuildMode(); // 0x06a4c790
	System.Void EnterBuildMode(WizardGames.Soc.Common.Data.EBuildThirdModeType thirdModeType); // 0x06a4c7f0
	System.Boolean get_IsBlueprintBuildMode(); // 0x06a4c864
	System.Boolean get_IsEmptyHandMode(); // 0x06a4c8c8
	System.Boolean get_IsDeployMode(); // 0x06a4c92c
	System.Boolean get_IsBuildWireMode(); // 0x06a4c990
	System.Boolean get_IsBuildSkinMode(); // 0x06a4c9f4
	System.Boolean get_IsBuildCoreMode(); // 0x06a4ca58
	System.Boolean get_IsInBuildMode(); // 0x06a456d8
	System.Boolean get_IsShortcutsDeployMode(); // 0x06a48750
	System.Boolean get_IsInBuildModeWithoutShortcuts(); // 0x06a4cabc
	System.Boolean get_IsInBuildEditMode(); // 0x06a4cb40
	System.Boolean get_IsInUiDeployBuildMode(); // 0x06a4cba4
	System.Boolean get_IsInRepairMode(); // 0x06a4cc08
	System.Boolean get_IsInElectricDeployMode(); // 0x06a4cc6c
	System.Boolean get_IsCampingTentDeployMode(); // 0x06a4ccd0
	System.Boolean get_IsInDeployMoveMode(); // 0x06a4cd34
	System.Boolean get_IsInBuildPlaceMode(); // 0x06a4cd98
	System.Void .ctor(); // 0x06a4b968
	static System.Void .cctor(); // 0x06a4cdfc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.BuildOperationUtil : System.Object
{
	static SocLogger Logger; // 0x0
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.EBuildThirdModeType,WizardGames.Soc.SocClient.Construction.BuildMode.BuildModeBase> buildThirdModeDict; // 0x8
	static System.Collections.Generic.Dictionary<System.Int64,System.Int32> PartEditItemNeedDic; // 0x10
	static WizardGames.Soc.SocClient.Manager.EditTargetPartData get_editTarget(); // 0x06a4cf50
	static System.Boolean TryGetBuildThirdMode(WizardGames.Soc.Common.Data.EBuildThirdModeType buildThirdModeType, WizardGames.Soc.SocClient.Construction.BuildMode.IBuildMode& buildMode); // 0x06a4c618
	static WizardGames.Soc.SocClient.Construction.BuildMode.BuildModeBase CreateBuildThirdMode(WizardGames.Soc.Common.Data.EBuildThirdModeType buildModeType); // 0x06a4cfdc
	static System.ValueTuple<System.Boolean,System.Int32> GetSlotInfo(WizardGames.Soc.Common.Component.ElectricBaseComponent module, WizardGames.Soc.Common.Electric.IOSlotBase slot); // 0x06a4d394
	static System.Int32 FindIndex(WizardGames.Soc.Common.Electric.IOSlotBase[] slots, WizardGames.Soc.Common.Electric.IOSlotBase target); // 0x06a4d500
	static System.Int32 SortAlpha3IOSlotCommodity(WizardGames.Soc.Common.Electric.IOSlotBase a, WizardGames.Soc.Common.Electric.IOSlotBase b); // 0x06a4d5bc
	static System.Int32 GetSlotPower(WizardGames.Soc.Common.Component.ElectricBaseComponent baseComponent, WizardGames.Soc.Common.Electric.IOSlotBase slot); // 0x06a4d7a0
	static WizardGames.Soc.Common.Electric.IOSlotBase GetFirstSlot(WizardGames.Soc.Common.Component.ElectricBaseComponent electricBase, System.Boolean isAvailable); // 0x06a4d974
	static WizardGames.Soc.Common.Electric.IOSlotBase GetCanConnectionSlot(WizardGames.Soc.Common.Component.ElectricBaseComponent electricBase, System.Boolean isOutput, WizardGames.Soc.Common.Electric.EIOSlotType ioSlotType); // 0x06a4dac0
	static System.Boolean IsUpgrade(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase itemData); // 0x06a4a504
	static System.Boolean IsUpgradePath(System.Int64 fromChildGroupId, System.Int64 toChildGroupId); // 0x06a4b230
	static System.Void RefreshEditConsumeDic(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData, System.Boolean isUpdate, System.Int32 transformTimes); // 0x06a4dbe8
	static System.Int32 GetTransformTimes(); // 0x06a4df78
	static WizardGames.Soc.SocClient.Ui.UIConstructionDetailInfo CreateConstructionDetailInfo(WizardGames.Soc.Common.Data.constraction.BuildingCore coreConfig, WizardGames.Soc.Common.Data.constraction.ConstructionComboChildGroupConfig childGroupConfig, WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x06a4e060
	static System.Boolean CanChangePart(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase partViewData); // 0x06a4e614
	static System.Boolean CheckConsumeItem(System.Collections.Generic.Dictionary<System.Int64,System.Int32> dic, System.Int32 failTip, System.Boolean showTip); // 0x06a4e750
	static System.Void HandlePartViewDataInfo(WizardGames.Soc.SocClient.Ui.ConstructionInfoData constructionInfoData, WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase curBuildItemData); // 0x06a4eb48
	static System.Void .cctor(); // 0x06a4f79c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.BuildPieOperation : WizardGames.Soc.SocClient.Manager.BuildOperationBase
{
	Construction.Util.EBuildFirstModeTypePie previousFirstModeType; // 0x2c
	Construction.Util.EBuildFirstModeTypePie <CurFirstModeTypePie>k__BackingField; // 0x30
	System.Collections.Generic.Dictionary<Construction.Util.EBuildFirstModeTypePie,System.Collections.Generic.List<WizardGames.Soc.Common.Data.EBuildThirdModeType>> firstModeThirdModeDict; // 0x38
	System.Collections.Generic.Dictionary<Construction.Util.EBuildFirstModeTypePie,System.Int32> firstModeTypeToFirstTagIdDic; // 0x40
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> firstTagIdToSecondTagIdDic; // 0x48
	System.Collections.Generic.Dictionary<Construction.Util.EBuildFirstModeTypePie,System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int64>>> recordDataDict; // 0x50
	Construction.Util.EBuildFirstModeTypePie get_CurFirstModeTypePie(); // 0x06a4f920
	System.Void set_CurFirstModeTypePie(Construction.Util.EBuildFirstModeTypePie value); // 0x06a4f984
	System.Void OnInit(); // 0x06a4f9fc
	System.Void OnEnter(); // 0x06a4fa60
	System.Void OnExit(); // 0x06a4fb1c
	System.Void OnCustomBlueprintDataChange(); // 0x06a4fbf8
	System.Void CollectBuildModeData(); // 0x06a50144
	System.Void EnterBuildMode(WizardGames.Soc.Common.Data.EBuildThirdModeType thirdModeType); // 0x06a50554
	System.Void EnterFirstBuildMode(); // 0x06a50de8
	System.Void EnterFirstBuildMode(Construction.Util.EBuildFirstModeTypePie firstModeType); // 0x06a507cc
	WizardGames.Soc.Common.Data.EBuildThirdModeType GetThirdModeType(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x06a50e58
	System.Void SetBuildPanelDataList(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase> buildItemDataList, System.Boolean autoSelectData); // 0x06a4ff78
	System.Void SetCurBuildItemData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData, System.Boolean refreshUi); // 0x06a51008
	System.Void ExitBuildMode(); // 0x06a5120c
	System.Boolean get_IsBlueprintBuildMode(); // 0x06a515a0
	System.Boolean get_IsDeployMode(); // 0x06a51650
	System.Boolean get_IsBuildWireMode(); // 0x06a5178c
	System.Boolean get_IsBuildCoreMode(); // 0x06a5183c
	System.Boolean get_IsInBuildModeWithoutShortcuts(); // 0x06a51978
	System.Boolean get_IsInBuildEditMode(); // 0x06a519fc
	System.Boolean get_IsInUiDeployBuildMode(); // 0x06a51b38
	System.Boolean get_IsInRepairMode(); // 0x06a51c2c
	System.Boolean get_IsInElectricDeployMode(); // 0x06a51c90
	System.Boolean get_IsCampingTentDeployMode(); // 0x06a51d98
	System.Boolean get_IsInDeployMoveMode(); // 0x06a51ee0
	System.Boolean get_IsInBuildPlaceMode(); // 0x06a52058
	System.Void Clear(); // 0x06a4bfcc
	System.Void SetLastDataDict(Construction.Util.EBuildFirstModeTypePie buildFirstModeTypePie, System.Int32 firstTagId, System.Int32 secondTagId, System.Int64 template); // 0x06a52168
	System.Int64 GetLastDataDict(Construction.Util.EBuildFirstModeTypePie buildFirstModeTypePie, System.Int32 firstTagId, System.Int32 secondTagId); // 0x06a52454
	System.Void .ctor(); // 0x06a52620
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.Mc : WizardGames.Soc.Common.Manager.McCommon
{
	static SocLogger Log; // 0x0
	static System.String strLoadTableException; // 0x8
	System.Boolean re_RegMgr; // 0x62
	System.Boolean <HasDoneBeforeEnterWorld>k__BackingField; // 0x63
	static WizardGames.Soc.SocClient.Entity.MgrEntity Entity; // 0x10
	static WizardGames.Soc.SocClient.Network.SocClientService LocalService; // 0x18
	static MgrGamePyhsicsSystem GamePyhsicsSystemMgr; // 0x20
	static WizardGames.Soc.SocClient.Control.MgrInputSystem InputSystem; // 0x28
	static WizardGames.Soc.SocClient.Control.MgrControlLobby ControlLobby; // 0x30
	static WizardGames.Soc.SocClient.Control.MgrControl Control; // 0x38
	static WizardGames.Soc.SocClient.Control.MgrRebindKey RebindKey; // 0x40
	static WizardGames.Soc.Common.Syncronization.MgrMyPlayer MyPlayer; // 0x48
	static WizardGames.Soc.SocClient.Go.MgrEntityGo Go; // 0x50
	static Config.MgrConfig Config; // 0x58
	static Config.MgrDebugConfig DebugConfig; // 0x60
	static WizardGames.Soc.Common.Syncronization.MgrPredict Predict; // 0x68
	static WizardGames.Soc.Common.Syncronization.MgrUserCmd UserCmd; // 0x70
	static WizardGames.Soc.Common.Unity.MgrCamera Camera; // 0x78
	static WizardGames.Soc.SocClient.Ui.MgrUi Ui; // 0x80
	static WizardGames.Soc.SocClient.Manager.MgrPowerOptimization PowerOptimization; // 0x88
	static WizardGames.Soc.SocClient.MgrHud Hud; // 0x90
	static WizardGames.Soc.SocClient.MgrHudCommon HudCommon; // 0x98
	static WizardGames.Soc.Common.TimerWheel.TimerWheel persistentTimerWheel; // 0xa0
	static WizardGames.Soc.SocClient.Audio.MgrAudio Audio; // 0xa8
	static Effect.Manager.MgrEffect Effect; // 0xb0
	static WizardGames.Soc.SocClient.Entity.MgrTOD TOD; // 0xb8
	static WizardGames.Soc.SocClient.Entity.MgrPPV PPV; // 0xc0
	static WizardGames.Soc.SocClient.Gathering.MgrGathering Gathering; // 0xc8
	static WizardGames.Soc.SocClient.ClientItem.MgrItem Item; // 0xd0
	static WizardGames.Soc.SocClient.ClientItem.MgrCollectionItem CollectionItem; // 0xd8
	static WizardGames.Soc.SocClient.Water.MgrWater Water; // 0xe0
	static MgrToEntityCalcCache ToEntityCalcCache; // 0xe8
	static WizardGames.Soc.SocClient.Auxiliary.MgrAuxiliaryAim AuxiliaryAim; // 0xf0
	static WizardGames.Soc.SocClient.Manager.MgrShopEntity shopEntityMgr; // 0xf8
	static Systems.MgrRaycast Raycast; // 0x100
	static WizardGames.Soc.SocClient.WorldResource.MgrGatherItemPickable GatherItemPickable; // 0x108
	static WizardGames.Soc.SocClient.WorldResource.MgrWorldResource WorldResource; // 0x110
	static Systems.MgrHudMsg HudMsg; // 0x118
	static Systems.MgrTips MsgTips; // 0x120
	static Systems.MgrAntiAddiction AntiAddiction; // 0x128
	static WizardGames.Soc.Common.Unity.Event.MgrMsg Msg; // 0x130
	static WizardGames.Soc.SocClient.Ui.MgrBlueprint Blueprint; // 0x138
	static WizardGames.Soc.SocClient.Ui.MgrWorldFlag WorldFlag; // 0x140
	static WizardGames.Soc.SocClient.Ui.MgrQuickLoot QuickLoot; // 0x148
	static WizardGames.Soc.SocClient.Technology.MgrTechnology Technology; // 0x150
	static WizardGames.Soc.SocClient.Map.MgrMap Map; // 0x158
	static WizardGames.Soc.Bridge.MgrSocShaderBridge SocShaderBridge; // 0x160
	static WizardGames.Soc.SocClient.Network.MgrNetworkMonitor NetWorkMonitor; // 0x168
	static WizardGames.Soc.SocClient.Shatter.MgrBoxShatter BoxShatter; // 0x170
	static WizardGames.Soc.SocClient.Terrain.MgrTerrain Terrain; // 0x178
	static WizardGames.Soc.SocClient.Team.MgrGameTeam GameTeam; // 0x180
	static WizardGames.Soc.SocClient.Marker.MgrMarker Marker; // 0x188
	static WizardGames.Soc.SocClient.MgrLootCollection LootCollection; // 0x190
	static WizardGames.Soc.SocClient.Manager.MgrIOEntity ioEntityMgr; // 0x198
	static WizardGames.Soc.SocClient.Manager.MgrElevator Elevator; // 0x1a0
	static WizardGames.Soc.SocClient.Manager.MgrMonumentEvent MonumentEvent; // 0x1a8
	static WizardGames.Soc.SocClient.Manager.MgrKatyusha Katyusha; // 0x1b0
	static WizardGames.Soc.SocClient.Manager.MgrGuideLine GuideLine; // 0x1b8
	static WizardGames.Soc.SocClient.Manager.MgrDig Dig; // 0x1c0
	static Systems.MgrEnhancedDisplayTip EnhancedDisplayTip; // 0x1c8
	static WizardGames.Soc.SocClient.Voice.MgrVoice Voice; // 0x1d0
	static WizardGames.Soc.SocClient.Indicator.MgrIndicator Indicator; // 0x1d8
	static WizardGames.Soc.Common.Syncronization.ClientSnapshotReceiver SnapshotReceiver; // 0x1e0
	static WizardGames.Soc.SocClient.MgrChat Chat; // 0x1e8
	static MgrLoginStep LoginStep; // 0x1f0
	static WizardGames.Soc.Common.Unity.Monster.State.AimationState.Mgr.MgrMonsterAnimation MonsterAnimation; // 0x1f8
	static WizardGames.Soc.SocClient.Setting.MgrSetting SettingClient; // 0x200
	static WizardGames.Soc.SocClient.ServerList.MgrServerList ServerListClient; // 0x208
	static WizardGames.Soc.SocClient.Ui.MgrRedDot RedDot; // 0x210
	static WizardGames.Soc.SocClient.Ui.MgrFullScreenEffect FullScreenEffect; // 0x218
	static WizardGames.Soc.SocClient.Manager.MgrObjectRenderer ObjectRenderer; // 0x220
	static WizardGames.Soc.SocClient.Ui.MgrUiModel UiModel; // 0x228
	static WizardGames.Soc.SocClient.Corpse.MgrCorpse Corpse; // 0x230
	static WizardGames.Soc.SocClient.ClientLight.MgrLight Light; // 0x238
	static WizardGames.Soc.SocClient.PersistentData.MgrPersistentData PersistentData; // 0x240
	static Go.PureGo.MgrPureGo PureGo; // 0x248
	static WizardGames.Soc.SocClient.MgrMission Mission; // 0x250
	static WizardGames.Soc.SocClient.Manager.MgrDeviceLevel DeviceLevel; // 0x258
	static WizardGames.Soc.SocClient.Weapon.MgrWeaponFxController WeaponFxController; // 0x260
	static WizardGames.Soc.SocClient.Plant.MgrPlant Plant; // 0x268
	static WizardGames.Soc.SocClient.Manager.MgrElectricLocal ElectricLocal; // 0x270
	static WizardGames.Soc.SocClient.Manager.MgrMail Mail; // 0x278
	static WizardGames.Soc.SocClient.Manager.MgrInterestTribe Tribe; // 0x280
	static WizardGames.Soc.SocClient.MgrMall Mall; // 0x288
	static WizardGames.Soc.SocClient.MgrBattlePass BattlePass; // 0x290
	static WizardGames.Soc.SocClient.MgrSeason Season; // 0x298
	static WizardGames.Soc.SocSimulator.Buff.MgrBuff Buff; // 0x2a0
	static WizardGames.Soc.SocClient.Guide.MgrGuide Guide; // 0x2a8
	static WizardGames.Soc.SocClient.ActionExecutor.MgrClientActionExecutor ActionExecutor; // 0x2b0
	static WizardGames.Soc.Common.Profile.MgrProfiler Profiler; // 0x2b8
	static WizardGames.Soc.SocClient.Announcement.MgrAnnouncement Announcement; // 0x2c0
	static Vehicle.MgrVehicle Vehicle; // 0x2c8
	static WizardGames.Soc.SocClient.Manager.MgrPermissionCenter PermCenter; // 0x2d0
	static WizardGames.Soc.SocClient.Manager.MgrLobby Lobby; // 0x2d8
	static WizardGames.Soc.SocClient.Manager.MgrMarquee Marquee; // 0x2e0
	static WizardGames.Soc.SocClient.Ui.MgrLobbyTeam LobbyTeam; // 0x2e8
	static WizardGames.Soc.SocClient.Manager.MgrRecruit Recruit; // 0x2f0
	static WizardGames.Soc.SocClient.Trigger.MgrTrigger Trigger; // 0x2f8
	static WizardGames.Soc.SocClient.Vehcle.MgrTrain Train; // 0x300
	static LobbyFriend.MgrLobbyFriend LobbyFriend; // 0x308
	static LobbyFriend.MgrLobbyTempFriend LobbyTempFriend; // 0x310
	static LobbyFriend.MgrLobbyPlatformFriend LobbyPlatformFriend; // 0x318
	static WizardGames.Soc.SocClient.Manager.MgrLobbyStash LobbyStash; // 0x320
	static WizardGames.Soc.SocClient.Manager.MgrLobbySkin LobbySkin; // 0x328
	static WizardGames.Soc.SocClient.Manager.MgrSkinPreview SkinPreview; // 0x330
	static WizardGames.Soc.SocClient.Manager.MgrSkinModify SkinModify; // 0x338
	static WizardGames.Soc.SocClient.Manager.MgrUploadLog UploadLog; // 0x340
	static WizardGames.Soc.SocClient.Manager.MgrSearch Search; // 0x348
	static WizardGames.Soc.SocClient.Manager.MgrMonumentTask MonumentTask; // 0x350
	static WizardGames.Soc.SocClient.Manager.MgrRaid Raid; // 0x358
	static WizardGames.Soc.SocClient.Manager.MgrTreeControl TreeControl; // 0x360
	static WizardGames.Soc.SocClient.Manager.MgrMonumentPreventBuildings MonumentPreventBuildings; // 0x368
	static WizardGames.Soc.SocClient.Reputation.MgrReputation Reputation; // 0x370
	static MgrSignifianceDbgDraw SignifianceDbgDraw; // 0x378
	static MgrSignifianceRes SignifianceRes; // 0x380
	static WizardGames.Soc.SocClient.Ui.MgrPopQueue PopQueue; // 0x388
	static WizardGames.Soc.SocClient.Talent.MgrTalent Talent; // 0x390
	static WizardGames.Soc.SocClient.Manager.MgrPlayerBlueprintData PlayerBlueprintData; // 0x398
	static WizardGames.Soc.SocClient.Ui.UiDecal.Mgr.MgrDecal Decal; // 0x3a0
	static WizardGames.Soc.SocClient.MgrFriendShare FriendShare; // 0x3a8
	static WizardGames.Soc.SocClient.Manager.MgrUnion LobbyUnion; // 0x3b0
	static MgrSouDJ SouDJ; // 0x3b8
	static WizardGames.Soc.SocClient.MgrInventory Inventory; // 0x3c0
	static MgrAce Ace; // 0x3c8
	static WizardGames.Soc.SocClient.MgrPerfSight PerfSight; // 0x3d0
	static MgrSocTpAnim SocTpAnim; // 0x3d8
	static MgrSignifianceReq SignifianceReq; // 0x3e0
	static WizardGames.Soc.Common.Syncronization.MgrEntityCareStates EntityCareStates; // 0x3e8
	static WizardGames.Soc.SocClient.Ui.MgrReport Report; // 0x3f0
	static WizardGames.Soc.SDK.MgrSDK SDK; // 0x3f8
	static WizardGames.Soc.SocClient.Ui.MgrReportEvent ReportEvent; // 0x400
	static WizardGames.Soc.SDK.MgrPay Pay; // 0x408
	static WizardGames.Soc.SocClient.Weapon.MgrAccessoryManagers AccessoryManagers; // 0x410
	static WizardGames.Soc.SocClient.Manager.MgrAoiGrid AoiGrid; // 0x418
	static WizardGames.Soc.SocClient.Ui.FocusInfo.MgrFocusInfo FocusInfo; // 0x420
	static WizardGames.Soc.SocClient.Ui.KillDataEvent.MgrKillDataEvent KillDataEvent; // 0x428
	static WizardGames.Soc.SocClient.Timeline.MgrClientTimeline Timeline; // 0x430
	static WizardGames.Soc.SocClient.Manager.MgrNewbieLevel NewbieLevel; // 0x438
	static WizardGames.Soc.SocClient.Ui.VehicleInfo.MgrVehicleInfo VehicleInfo; // 0x440
	static WizardGames.Soc.SocClient.TPNSPush.MgrPushNotice PushNotice; // 0x448
	static WizardGames.Soc.SocClient.Story.MgrStory Story; // 0x450
	static WizardGames.Soc.SocClient.Manager.MgrLocalLog LocalLog; // 0x458
	static WizardGames.Soc.SocClient.Manager.MgrUIConstructionDetailTips ConstructionDetailTips; // 0x460
	static WizardGames.Soc.SocClient.Manager.MgrWireControl WireControl; // 0x468
	static WizardGames.Soc.SocClient.Ui.MgrQuickActBubble QuickActBubble; // 0x470
	static WizardGames.Soc.SocClient.Manager.MgrSocMemoryProfiler SocMemory; // 0x478
	static WizardGames.Soc.SocClient.Manager.MgrPreviewSceneManager PreviewSceneManager; // 0x480
	static WizardGames.Soc.SocClient.Manager.MgrLobbyTime LobbyTime; // 0x488
	static MgrClientCondition ConditionMgr; // 0x490
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.MgrPlatformPlayerInfo PlatformPlayerInfo; // 0x498
	static WizardGames.Soc.Common.Unity.MgrPhoto Photo; // 0x4a0
	static WizardGames.Soc.Common.Unity.MgrAdmin Admin; // 0x4a8
	static MgrCenterConsole CenterConsole; // 0x4b0
	static WizardGames.Soc.AdaptivePerformance.MgrThermal Thermal; // 0x4b8
	static WizardGames.Soc.SocClient.Map.MgrBattleReport BattleReport; // 0x4c0
	static WizardGames.Soc.SocClient.Map.MgrSoundPrint SoundPrint; // 0x4c8
	static WizardGames.Soc.SocClient.Map.MgrKOL KOL; // 0x4d0
	static WizardGames.Soc.SocClient.Manager.MgrConstructionReport ConstructionReport; // 0x4d8
	static WizardGames.Soc.SocClient.Manager.MgrMedal Medal; // 0x4e0
	static WizardGames.Soc.SocClient.Manager.MgrActivity Activity; // 0x4e8
	static WizardGames.Soc.SocClient.Manager.MgrGacha Gacha; // 0x4f0
	static WizardGames.Soc.SocClient.Manager.MgrTokenLink TokenLink; // 0x4f8
	static WizardGames.Soc.SocClient.Manager.MgrCommercialBgm CommercialBgm; // 0x500
	static WizardGames.Soc.SocClient.Manager.MgrFragmentLottery FragmentLottery; // 0x508
	static WizardGames.Soc.SocClient.Manager.MgrActiveLottery ActiveLottery; // 0x510
	static WizardGames.Soc.SocClient.Manager.MgrObserver Observer; // 0x518
	static WizardGames.Soc.SocClient.Manager.MgrLobbyObserver LobbyObserver; // 0x520
	static WizardGames.Soc.SocClient.Manager.ObMode obMode; // 0x528
	static System.Boolean <ObserverMode>k__BackingField; // 0x52c
	System.Boolean get_HasDoneBeforeEnterWorld(); // 0x06a52804
	System.Void set_HasDoneBeforeEnterWorld(System.Boolean value); // 0x06a52868
	static WizardGames.Soc.SocClient.Manager.Mc get_Instance(); // 0x06a528e4
	static System.Void Init(); // 0x06a529b0
	static System.Void InitShadowConfig(); // 0x06a533cc
	System.Void CheckTableInitError(); // 0x06a52fbc
	static WizardGames.Soc.Common.Framework.Network.Client.INetworkEndpointForClient get_LocalClient(); // 0x06a535e8
	static WizardGames.Soc.SocClient.Manager.MgrConstruction get_Construction(); // 0x06a31b94
	static WizardGames.Soc.Common.TimerWheel.TimerWheel get_TimerWheel(); // 0x06a536c4
	static System.Void set_TimerWheel(WizardGames.Soc.Common.TimerWheel.TimerWheel value); // 0x06a5373c
	static WizardGames.Soc.Common.TimerWheel.TimerWheel get_TimerWheelPersistent(); // 0x06a537c0
	static System.Void set_TimerWheelPersistent(WizardGames.Soc.Common.TimerWheel.TimerWheel value); // 0x06a53848
	System.Void RegisterAllMgrs(); // 0x06a538dc
	System.Void CreateMgrInsts(); // 0x06a52e40
	System.Void BeforeEnterWorld(); // 0x06a5b1dc
	System.Void AfterExitWorld(); // 0x06a5b6ec
	System.Void ResetTimer(); // 0x06a5b5cc
	static System.Void SetCharacterMaxLOD(System.Int32 level); // 0x06a5bdc0
	System.Void RegisterPlatformMgrs(); // 0x06a5b17c
	static System.Boolean get_IsReplayMode(); // 0x06a5bed4
	static System.Boolean get_IsPatrollerMode(); // 0x06a5bf64
	static System.Boolean get_IsAnchorMode(); // 0x06a5bff4
	static System.Boolean get_ObserverMode(); // 0x06a5c084
	static System.Void set_ObserverMode(System.Boolean value); // 0x06a5c10c
	static System.Boolean get_HasObserverTarget(); // 0x06a5c1a0
	static System.Void SetObserverMode(System.Boolean isOpen, WizardGames.Soc.SocClient.Manager.ObMode mode); // 0x06a5bbc0
	System.Void .ctor(); // 0x06a52db4
	static System.Void .cctor(); // 0x06a5c308
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.Mc.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Manager.Mc.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_0; // 0x8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_1; // 0x10
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_2; // 0x18
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_3; // 0x20
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_4; // 0x28
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_5; // 0x30
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_6; // 0x38
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_7; // 0x40
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_8; // 0x48
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_9; // 0x50
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_10; // 0x58
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_11; // 0x60
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_12; // 0x68
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_13; // 0x70
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_14; // 0x78
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_15; // 0x80
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_16; // 0x88
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_17; // 0x90
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_18; // 0x98
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_19; // 0xa0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_20; // 0xa8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_21; // 0xb0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_22; // 0xb8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_23; // 0xc0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_24; // 0xc8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_25; // 0xd0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_26; // 0xd8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_27; // 0xe0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_28; // 0xe8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_29; // 0xf0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_30; // 0xf8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_31; // 0x100
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_32; // 0x108
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_33; // 0x110
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_34; // 0x118
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_35; // 0x120
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_36; // 0x128
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_37; // 0x130
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_38; // 0x138
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_39; // 0x140
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_40; // 0x148
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_41; // 0x150
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_42; // 0x158
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_43; // 0x160
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_44; // 0x168
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_45; // 0x170
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_46; // 0x178
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_47; // 0x180
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_48; // 0x188
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_49; // 0x190
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_50; // 0x198
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_51; // 0x1a0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_52; // 0x1a8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_53; // 0x1b0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_54; // 0x1b8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_55; // 0x1c0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_56; // 0x1c8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_57; // 0x1d0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_58; // 0x1d8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_59; // 0x1e0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_60; // 0x1e8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_61; // 0x1f0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_62; // 0x1f8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_63; // 0x200
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_64; // 0x208
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_65; // 0x210
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_66; // 0x218
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_67; // 0x220
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_68; // 0x228
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_69; // 0x230
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_70; // 0x238
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_71; // 0x240
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_72; // 0x248
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_73; // 0x250
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_74; // 0x258
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_75; // 0x260
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_76; // 0x268
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_77; // 0x270
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_78; // 0x278
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_79; // 0x280
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_80; // 0x288
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_81; // 0x290
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_82; // 0x298
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_83; // 0x2a0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_84; // 0x2a8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_85; // 0x2b0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_86; // 0x2b8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_87; // 0x2c0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_88; // 0x2c8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_89; // 0x2d0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_90; // 0x2d8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_91; // 0x2e0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_92; // 0x2e8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_93; // 0x2f0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_94; // 0x2f8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_95; // 0x300
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_96; // 0x308
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_97; // 0x310
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_98; // 0x318
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_99; // 0x320
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_100; // 0x328
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_101; // 0x330
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_102; // 0x338
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_103; // 0x340
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_104; // 0x348
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_105; // 0x350
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_106; // 0x358
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_107; // 0x360
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_108; // 0x368
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_109; // 0x370
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_110; // 0x378
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_111; // 0x380
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_112; // 0x388
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_113; // 0x390
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_114; // 0x398
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_115; // 0x3a0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_116; // 0x3a8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_117; // 0x3b0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_118; // 0x3b8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_119; // 0x3c0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_120; // 0x3c8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_121; // 0x3d0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_122; // 0x3d8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_123; // 0x3e0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_124; // 0x3e8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_125; // 0x3f0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_126; // 0x3f8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_127; // 0x400
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_128; // 0x408
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_129; // 0x410
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_130; // 0x418
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_131; // 0x420
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_132; // 0x428
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_133; // 0x430
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_134; // 0x438
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_135; // 0x440
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_136; // 0x448
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_137; // 0x450
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_138; // 0x458
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_139; // 0x460
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_140; // 0x468
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_141; // 0x470
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_142; // 0x478
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_143; // 0x480
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_144; // 0x488
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_145; // 0x490
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_146; // 0x498
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_147; // 0x4a0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_148; // 0x4a8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_149; // 0x4b0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_150; // 0x4b8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_151; // 0x4c0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_152; // 0x4c8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_153; // 0x4d0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_154; // 0x4d8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_155; // 0x4e0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_156; // 0x4e8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_157; // 0x4f0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_158; // 0x4f8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_159; // 0x500
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_160; // 0x508
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_161; // 0x510
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_162; // 0x518
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__186_163; // 0x520
	static System.Void .cctor(); // 0x06a5c5f4
	System.Void .ctor(); // 0x06a5c658
	System.Void <RegisterAllMgrs>b__186_0(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5c6c0
	System.Void <RegisterAllMgrs>b__186_1(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5c7fc
	System.Void <RegisterAllMgrs>b__186_2(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5c938
	System.Void <RegisterAllMgrs>b__186_3(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5ca74
	System.Void <RegisterAllMgrs>b__186_4(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5cbb0
	System.Void <RegisterAllMgrs>b__186_5(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5cce4
	System.Void <RegisterAllMgrs>b__186_6(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5ce20
	System.Void <RegisterAllMgrs>b__186_7(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5cf5c
	System.Void <RegisterAllMgrs>b__186_8(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5d098
	System.Void <RegisterAllMgrs>b__186_9(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5d1cc
	System.Void <RegisterAllMgrs>b__186_10(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5d300
	System.Void <RegisterAllMgrs>b__186_11(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5d434
	System.Void <RegisterAllMgrs>b__186_12(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5d568
	System.Void <RegisterAllMgrs>b__186_13(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5d69c
	System.Void <RegisterAllMgrs>b__186_14(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5d7d0
	System.Void <RegisterAllMgrs>b__186_15(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5d904
	System.Void <RegisterAllMgrs>b__186_16(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5da38
	System.Void <RegisterAllMgrs>b__186_17(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5db6c
	System.Void <RegisterAllMgrs>b__186_18(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5dca0
	System.Void <RegisterAllMgrs>b__186_19(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5dddc
	System.Void <RegisterAllMgrs>b__186_20(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5df10
	System.Void <RegisterAllMgrs>b__186_21(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5e044
	System.Void <RegisterAllMgrs>b__186_22(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5e16c
	System.Void <RegisterAllMgrs>b__186_23(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5e2a8
	System.Void <RegisterAllMgrs>b__186_24(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5e3e4
	System.Void <RegisterAllMgrs>b__186_25(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5e518
	System.Void <RegisterAllMgrs>b__186_26(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5e64c
	System.Void <RegisterAllMgrs>b__186_27(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5e780
	System.Void <RegisterAllMgrs>b__186_28(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5e8bc
	System.Void <RegisterAllMgrs>b__186_29(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5e9f0
	System.Void <RegisterAllMgrs>b__186_30(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5eae0
	System.Void <RegisterAllMgrs>b__186_31(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5ec14
	System.Void <RegisterAllMgrs>b__186_32(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5ed48
	System.Void <RegisterAllMgrs>b__186_33(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5ee40
	System.Void <RegisterAllMgrs>b__186_34(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5ef74
	System.Void <RegisterAllMgrs>b__186_35(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5f0b0
	System.Void <RegisterAllMgrs>b__186_36(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5f1ec
	System.Void <RegisterAllMgrs>b__186_37(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5f328
	System.Void <RegisterAllMgrs>b__186_38(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5f45c
	System.Void <RegisterAllMgrs>b__186_39(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5f598
	System.Void <RegisterAllMgrs>b__186_40(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5f6d4
	System.Void <RegisterAllMgrs>b__186_41(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5f810
	System.Void <RegisterAllMgrs>b__186_42(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5f94c
	System.Void <RegisterAllMgrs>b__186_43(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5fa88
	System.Void <RegisterAllMgrs>b__186_44(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5fbc4
	System.Void <RegisterAllMgrs>b__186_45(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5fd00
	System.Void <RegisterAllMgrs>b__186_46(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5fe34
	System.Void <RegisterAllMgrs>b__186_47(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a5ff68
	System.Void <RegisterAllMgrs>b__186_48(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a600a4
	System.Void <RegisterAllMgrs>b__186_49(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a601e0
	System.Void <RegisterAllMgrs>b__186_50(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a6031c
	System.Void <RegisterAllMgrs>b__186_51(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a60458
	System.Void <RegisterAllMgrs>b__186_52(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a60594
	System.Void <RegisterAllMgrs>b__186_53(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a606c8
	System.Void <RegisterAllMgrs>b__186_54(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a60804
	System.Void <RegisterAllMgrs>b__186_55(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a60940
	System.Void <RegisterAllMgrs>b__186_56(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a60a7c
	System.Void <RegisterAllMgrs>b__186_57(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a60bb8
	System.Void <RegisterAllMgrs>b__186_58(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a60cf4
	System.Void <RegisterAllMgrs>b__186_59(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a60e30
	System.Void <RegisterAllMgrs>b__186_60(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a60f6c
	System.Void <RegisterAllMgrs>b__186_61(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a610a8
	System.Void <RegisterAllMgrs>b__186_62(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a611e4
	System.Void <RegisterAllMgrs>b__186_63(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a61320
	System.Void <RegisterAllMgrs>b__186_64(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a6145c
	System.Void <RegisterAllMgrs>b__186_65(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a61598
	System.Void <RegisterAllMgrs>b__186_66(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a616d4
	System.Void <RegisterAllMgrs>b__186_67(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a61810
	System.Void <RegisterAllMgrs>b__186_68(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a6194c
	System.Void <RegisterAllMgrs>b__186_69(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a61a88
	System.Void <RegisterAllMgrs>b__186_70(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a61bc4
	System.Void <RegisterAllMgrs>b__186_71(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a61d00
	System.Void <RegisterAllMgrs>b__186_72(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a61e3c
	System.Void <RegisterAllMgrs>b__186_73(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a61f78
	System.Void <RegisterAllMgrs>b__186_74(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a620b4
	System.Void <RegisterAllMgrs>b__186_75(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a621f0
	System.Void <RegisterAllMgrs>b__186_76(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a6232c
	System.Void <RegisterAllMgrs>b__186_77(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a62424
	System.Void <RegisterAllMgrs>b__186_78(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a62560
	System.Void <RegisterAllMgrs>b__186_79(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a6269c
	System.Void <RegisterAllMgrs>b__186_80(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a627d8
	System.Void <RegisterAllMgrs>b__186_81(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a62914
	System.Void <RegisterAllMgrs>b__186_82(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a62a50
	System.Void <RegisterAllMgrs>b__186_83(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a62b8c
	System.Void <RegisterAllMgrs>b__186_84(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a62cc8
	System.Void <RegisterAllMgrs>b__186_85(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a62e04
	System.Void <RegisterAllMgrs>b__186_86(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a62f40
	System.Void <RegisterAllMgrs>b__186_87(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a6307c
	System.Void <RegisterAllMgrs>b__186_88(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a63174
	System.Void <RegisterAllMgrs>b__186_89(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a632b0
	System.Void <RegisterAllMgrs>b__186_90(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a633ec
	System.Void <RegisterAllMgrs>b__186_91(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a63528
	System.Void <RegisterAllMgrs>b__186_92(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a63664
	System.Void <RegisterAllMgrs>b__186_93(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a637a0
	System.Void <RegisterAllMgrs>b__186_94(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a638dc
	System.Void <RegisterAllMgrs>b__186_95(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a63a18
	System.Void <RegisterAllMgrs>b__186_96(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a63b54
	System.Void <RegisterAllMgrs>b__186_97(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a63c90
	System.Void <RegisterAllMgrs>b__186_98(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a63dcc
	System.Void <RegisterAllMgrs>b__186_99(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a63f08
	System.Void <RegisterAllMgrs>b__186_100(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a64044
	System.Void <RegisterAllMgrs>b__186_101(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a64180
	System.Void <RegisterAllMgrs>b__186_102(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a642bc
	System.Void <RegisterAllMgrs>b__186_103(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a643f8
	System.Void <RegisterAllMgrs>b__186_104(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a64534
	System.Void <RegisterAllMgrs>b__186_105(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a64668
	System.Void <RegisterAllMgrs>b__186_106(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a647a4
	System.Void <RegisterAllMgrs>b__186_107(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a648e0
	System.Void <RegisterAllMgrs>b__186_108(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a64a1c
	System.Void <RegisterAllMgrs>b__186_109(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a64b58
	System.Void <RegisterAllMgrs>b__186_110(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a64c94
	System.Void <RegisterAllMgrs>b__186_111(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a64dd0
	System.Void <RegisterAllMgrs>b__186_112(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a64f0c
	System.Void <RegisterAllMgrs>b__186_113(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a65048
	System.Void <RegisterAllMgrs>b__186_114(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a65184
	System.Void <RegisterAllMgrs>b__186_115(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a652c0
	System.Void <RegisterAllMgrs>b__186_116(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a653fc
	System.Void <RegisterAllMgrs>b__186_117(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a65538
	System.Void <RegisterAllMgrs>b__186_118(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a65674
	System.Void <RegisterAllMgrs>b__186_119(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a657b0
	System.Void <RegisterAllMgrs>b__186_120(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a658ec
	System.Void <RegisterAllMgrs>b__186_121(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a65a20
	System.Void <RegisterAllMgrs>b__186_122(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a65b5c
	System.Void <RegisterAllMgrs>b__186_123(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a65c98
	System.Void <RegisterAllMgrs>b__186_124(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a65dd4
	System.Void <RegisterAllMgrs>b__186_125(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a65f10
	System.Void <RegisterAllMgrs>b__186_126(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a6604c
	System.Void <RegisterAllMgrs>b__186_127(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a66188
	System.Void <RegisterAllMgrs>b__186_128(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a662c4
	System.Void <RegisterAllMgrs>b__186_129(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a66400
	System.Void <RegisterAllMgrs>b__186_130(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a6653c
	System.Void <RegisterAllMgrs>b__186_131(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a66678
	System.Void <RegisterAllMgrs>b__186_132(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a667b4
	System.Void <RegisterAllMgrs>b__186_133(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a668f0
	System.Void <RegisterAllMgrs>b__186_134(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a66a2c
	System.Void <RegisterAllMgrs>b__186_135(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a66b60
	System.Void <RegisterAllMgrs>b__186_136(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a66c9c
	System.Void <RegisterAllMgrs>b__186_137(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a66dd0
	System.Void <RegisterAllMgrs>b__186_138(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a66f04
	System.Void <RegisterAllMgrs>b__186_139(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a67040
	System.Void <RegisterAllMgrs>b__186_140(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a6717c
	System.Void <RegisterAllMgrs>b__186_141(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a672b8
	System.Void <RegisterAllMgrs>b__186_142(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a673f4
	System.Void <RegisterAllMgrs>b__186_143(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a67530
	System.Void <RegisterAllMgrs>b__186_144(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a67628
	System.Void <RegisterAllMgrs>b__186_145(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a67764
	System.Void <RegisterAllMgrs>b__186_146(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a678a0
	System.Void <RegisterAllMgrs>b__186_147(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a679dc
	System.Void <RegisterAllMgrs>b__186_148(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a67b18
	System.Void <RegisterAllMgrs>b__186_149(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a67c54
	System.Void <RegisterAllMgrs>b__186_150(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a67d90
	System.Void <RegisterAllMgrs>b__186_151(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a67ecc
	System.Void <RegisterAllMgrs>b__186_152(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a68008
	System.Void <RegisterAllMgrs>b__186_153(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a68144
	System.Void <RegisterAllMgrs>b__186_154(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a68280
	System.Void <RegisterAllMgrs>b__186_155(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a683bc
	System.Void <RegisterAllMgrs>b__186_156(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a684f8
	System.Void <RegisterAllMgrs>b__186_157(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a68634
	System.Void <RegisterAllMgrs>b__186_158(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a68770
	System.Void <RegisterAllMgrs>b__186_159(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a688ac
	System.Void <RegisterAllMgrs>b__186_160(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a689e8
	System.Void <RegisterAllMgrs>b__186_161(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a68b24
	System.Void <RegisterAllMgrs>b__186_162(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a68c60
	System.Void <RegisterAllMgrs>b__186_163(WizardGames.Soc.Common.Manager.MgrBase m); // 0x06a68d9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrDebugCheat : System.Object
{
	static WizardGames.Soc.SocClient.Manager.MgrDebugCheat _instance; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.MgrDebugCheat.Command> _commands; // 0x10
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Manager.MgrDebugCheat.Command> _dict; // 0x18
	static SocLogger logger; // 0x8
	System.Collections.Generic.HashSet<UnityEngine.GameObject> currentPrefabs; // 0x20
	static System.Boolean openShadowCache; // 0x10
	static System.Boolean IsOpenRenderResolution; // 0x11
	System.Collections.Generic.List<Effect.EffectItemHandle<Effect.EffectItem>> effectItemHandles; // 0x28
	static WizardGames.Soc.SocClient.Manager.MgrDebugCheat get_Instance(); // 0x06a68ed8
	System.Void .ctor(); // 0x06a68fa0
	System.Collections.Generic.IReadOnlyList<WizardGames.Soc.SocClient.Manager.MgrDebugCheat.Command> GetAllCommands(); // 0x06a69228
	System.Void InitializeAllCommands(); // 0x06a691c8
	static System.Void .cctor(); // 0x06a692ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrDebugCheat.Command : System.Object
{
	System.String name; // 0x10
	System.Action call; // 0x18
	System.Action<System.String> callWithParam; // 0x20
	System.Boolean hideWhenClick; // 0x28
	System.String paramDesc; // 0x30
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrDeviceLevel : WizardGames.Soc.Common.Manager.MgrBase
{
	SocLogger Log; // 0x18
	System.Collections.Generic.Dictionary<System.String,System.Boolean> deviceCompatOptions; // 0x20
	WizardGames.Soc.SocClient.Device.DeviceInfo <DeviceInfo>k__BackingField; // 0x28
	WizardGames.Soc.RMQualityLevelBeta <CurrentQuality>k__BackingField; // 0x30
	WizardGames.Soc.RMQualityLevel <RecommendQuality>k__BackingField; // 0x34
	System.Int32 <DeviceLevel>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.Device.DeviceInfo get_DeviceInfo(); // 0x06a69390
	System.Void set_DeviceInfo(WizardGames.Soc.SocClient.Device.DeviceInfo value); // 0x06a693f4
	WizardGames.Soc.RMQualityLevelBeta get_CurrentQuality(); // 0x06a69474
	System.Void set_CurrentQuality(WizardGames.Soc.RMQualityLevelBeta value); // 0x06a694d8
	WizardGames.Soc.RMQualityLevel get_CurrentQualityOld(); // 0x06a69550
	System.Void set_RecommendQuality(WizardGames.Soc.RMQualityLevel value); // 0x06a69628
	System.Int32 get_DeviceLevel(); // 0x06a696a0
	System.Void set_DeviceLevel(System.Int32 value); // 0x06a69704
	System.Void Init(); // 0x06a6977c
	System.Void OnAccountLogined(); // 0x06a6a058
	System.Void OnAccountLogout(); // 0x06a6a230
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06a6a408
	System.Void SetGameQuality(WizardGames.Soc.RMQualityLevelBeta quality, System.Boolean showTip, System.Boolean needPostInfo); // 0x06a6a4b0
	System.Void InitDeviceInfo(); // 0x06a69880
	WizardGames.Soc.RMQualityLevel SearchRecommendGameQuality(System.Int32 deviceLevel); // 0x06a6ae48
	System.String QualityName(WizardGames.Soc.RMQualityLevel quality); // 0x06a6ac50
	System.Boolean CanEffectPlay(UnityEngine.Vector3 myPos, UnityEngine.Vector3 targetPos); // 0x06a6af8c
	System.Boolean CanEffectPlay(WizardGames.Soc.Share.Framework.IPositionEntity targetEntity); // 0x06a6b18c
	System.Void CheckConfigFromSetting(System.Collections.Generic.Dictionary<System.String,System.String> remoteConfigData); // 0x06a6b410
	System.Boolean ShowTpByQuality(); // 0x06a6b5c0
	System.Void .ctor(); // 0x06a6b7e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbyCreateRoleSceneModelPoint : UnityEngine.MonoBehaviour
{
	UnityEngine.GameObject playerLoaderMain; // 0x30
	System.Void .ctor(); // 0x06a6b938
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbyMainSceneCameraController : UnityEngine.MonoBehaviour
{
	Cinemachine.CinemachineVirtualCamera camera; // 0x30
	WizardGames.Soc.SocClient.Manager.VisibleFloatDictionary fovList; // 0x38
	WizardGames.Soc.SocClient.Manager.InterpolationCalculator cameraCal; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.ListItemData> PosList; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.ListItemScaleData> itemScaleList; // 0x50
	WizardGames.Soc.SocClient.Manager.VisibleFloatDictionary fovListPC; // 0x58
	WizardGames.Soc.SocClient.Manager.InterpolationCalculator cameraCalPC; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.ListItemData> PosListPC; // 0x68
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.ListItemScaleData> itemScaleListPC; // 0x70
	System.Collections.Generic.List<System.ValueTuple<UnityEngine.GameObject,System.Collections.Generic.Dictionary<System.Single,UnityEngine.Vector3>>> _runtimePosData; // 0x78
	System.Collections.Generic.List<System.ValueTuple<UnityEngine.GameObject,System.Collections.Generic.Dictionary<System.Single,System.Single>>> _runtimeScaleData; // 0x80
	System.Void Awake(); // 0x06a6b9a0
	System.Void OnEnable(); // 0x06a6befc
	System.Void OnDisable(); // 0x06a6c728
	System.Void RefreshCamera(); // 0x06a6bfec
	System.Void SyncRuntimeData(); // 0x06a6ba04
	System.Void .ctor(); // 0x06a6e3ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbySceneCameraController : UnityEngine.MonoBehaviour
{
	UnityEngine.Camera camera; // 0x30
	WizardGames.Soc.SocClient.Manager.VisibleFloatDictionary fovList; // 0x38
	WizardGames.Soc.SocClient.Manager.InterpolationCalculator cameraCal; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.ListItemData> PosList; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.ListItemScaleData> itemScaleList; // 0x50
	WizardGames.Soc.SocClient.Manager.VisibleFloatDictionary fovListPC; // 0x58
	WizardGames.Soc.SocClient.Manager.InterpolationCalculator cameraCalPC; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.ListItemData> PosListPC; // 0x68
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.ListItemScaleData> itemScaleListPC; // 0x70
	System.Collections.Generic.List<System.ValueTuple<UnityEngine.GameObject,System.Collections.Generic.Dictionary<System.Single,UnityEngine.Vector3>>> _runtimePosData; // 0x78
	System.Collections.Generic.List<System.ValueTuple<UnityEngine.GameObject,System.Collections.Generic.Dictionary<System.Single,System.Single>>> _runtimeScaleData; // 0x80
	System.Void Awake(); // 0x06a6e704
	System.Void OnEnable(); // 0x06a6ec60
	System.Void OnDisable(); // 0x06a6f4a4
	System.Void RefreshCamera(); // 0x06a6ed60
	System.Void SyncRuntimeData(); // 0x06a6e768
	System.Void .ctor(); // 0x06a6f59c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.FloatVector3Pair : System.Object
{
	System.Single key; // 0x10
	UnityEngine.Vector3 value; // 0x14
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.FloatPair : System.Object
{
	System.Single key; // 0x10
	System.Single value; // 0x14
	System.Single get_Key(); // 0x06a6f800
	System.Single get_Value(); // 0x06a6f864
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.VisibleFloatDictionary : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.FloatPair> pairs; // 0x10
	System.Collections.Generic.Dictionary<System.Single,System.Single> ToRealDictionary(); // 0x06a6c81c
	System.Void .ctor(); // 0x06a6e650
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.SerializableFloatVector3Dict : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.FloatVector3Pair> entries; // 0x10
	System.Collections.Generic.Dictionary<System.Single,UnityEngine.Vector3> ToDictionary(); // 0x06a6e12c
	System.Void .ctor(); // 0x06a6f8c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.ListItemScaleData : System.Object
{
	UnityEngine.GameObject targetObject; // 0x10
	WizardGames.Soc.SocClient.Manager.VisibleFloatDictionary scaleData; // 0x18
	System.Void .ctor(); // 0x06a6f97c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.ListItemData : System.Object
{
	UnityEngine.GameObject targetObject; // 0x10
	WizardGames.Soc.SocClient.Manager.SerializableFloatVector3Dict positionData; // 0x18
	System.Void .ctor(); // 0x06a6fa18
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.InterpolationCalculatorVector3 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.DataVector3Point> _dataPoints; // 0x10
	static SocLogger logger; // 0x0
	System.Void .ctor(System.Single[] xValues, UnityEngine.Vector3[] yValues); // 0x06a6d64c
	UnityEngine.Vector3 Calculate(System.Single x); // 0x06a6dbbc
	static System.Void .cctor(); // 0x06a6fb54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.InterpolationCalculatorVector3.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Manager.InterpolationCalculatorVector3.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Manager.DataVector3Point> <>9__2_0; // 0x8
	static System.Func<WizardGames.Soc.SocClient.Manager.DataVector3Point,System.Single> <>9__2_1; // 0x10
	static System.Func<System.Linq.IGrouping<System.Single,WizardGames.Soc.SocClient.Manager.DataVector3Point>,System.Boolean> <>9__2_2; // 0x18
	static System.Void .cctor(); // 0x06a6fbec
	System.Void .ctor(); // 0x06a6fc50
	System.Int32 <.ctor>b__2_0(WizardGames.Soc.SocClient.Manager.DataVector3Point a, WizardGames.Soc.SocClient.Manager.DataVector3Point b); // 0x06a6fcb8
	System.Single <.ctor>b__2_1(WizardGames.Soc.SocClient.Manager.DataVector3Point p); // 0x06a6fe38
	System.Boolean <.ctor>b__2_2(System.Linq.IGrouping<System.Single,WizardGames.Soc.SocClient.Manager.DataVector3Point> g); // 0x06a6ff2c
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Manager.DataVector3Point : System.ValueType
{
	System.Single <X>k__BackingField; // 0x10
	UnityEngine.Vector3 <Y>k__BackingField; // 0x14
	System.Single get_X(); // 0x06a6ffc8
	UnityEngine.Vector3 get_Y(); // 0x06a7002c
	System.Void .ctor(System.Single x, UnityEngine.Vector3 y); // 0x06a6fab4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.InterpolationCalculator : System.Object
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.DataPoint> _dataPoints; // 0x10
	System.Void .ctor(System.Single[] xValues, System.Single[] yValues); // 0x06a6cbd8
	System.Single Calculate(System.Single x); // 0x06a6d128
	static System.Void .cctor(); // 0x06a70110
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.InterpolationCalculator.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Manager.InterpolationCalculator.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Manager.DataPoint> <>9__2_0; // 0x8
	static System.Func<WizardGames.Soc.SocClient.Manager.DataPoint,System.Single> <>9__2_1; // 0x10
	static System.Func<System.Linq.IGrouping<System.Single,WizardGames.Soc.SocClient.Manager.DataPoint>,System.Boolean> <>9__2_2; // 0x18
	static System.Void .cctor(); // 0x06a701a8
	System.Void .ctor(); // 0x06a7020c
	System.Int32 <.ctor>b__2_0(WizardGames.Soc.SocClient.Manager.DataPoint a, WizardGames.Soc.SocClient.Manager.DataPoint b); // 0x06a70274
	System.Single <.ctor>b__2_1(WizardGames.Soc.SocClient.Manager.DataPoint p); // 0x06a703b4
	System.Boolean <.ctor>b__2_2(System.Linq.IGrouping<System.Single,WizardGames.Soc.SocClient.Manager.DataPoint> g); // 0x06a70488
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Manager.DataPoint : System.ValueType
{
	System.Single <X>k__BackingField; // 0x10
	System.Single <Y>k__BackingField; // 0x14
	System.Single get_X(); // 0x06a70524
	System.Single get_Y(); // 0x06a70588
	System.Void .ctor(System.Single x, System.Single y); // 0x06a70090
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbySceneCameraMoreController : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	UnityEngine.Camera camera; // 0x30
	System.Int32 usePlan; // 0x38
	WizardGames.Soc.SocClient.Manager.SerializableDictionary<System.Int32,WizardGames.Soc.SocClient.Manager.SchemeData> schemes; // 0x40
	WizardGames.Soc.SocClient.Manager.InterpolationCalculator cameraCal; // 0x48
	WizardGames.Soc.SocClient.Manager.InterpolationCalculator cameraCalPC; // 0x50
	System.Collections.Generic.List<System.ValueTuple<UnityEngine.GameObject,System.Collections.Generic.Dictionary<System.Single,UnityEngine.Vector3>>> _runtimePosData; // 0x58
	System.Collections.Generic.List<System.ValueTuple<UnityEngine.GameObject,System.Collections.Generic.Dictionary<System.Single,System.Single>>> _runtimeScaleData; // 0x60
	System.Int32 get_UsePlan1(); // 0x06a705ec
	System.Void set_UsePlan1(System.Int32 value); // 0x06a70650
	System.Void Awake(); // 0x06a714f8
	System.Void OnEnable(); // 0x06a71598
	System.Void OnDisable(); // 0x06a71698
	System.Void RefreshCamera(); // 0x06a70e44
	System.Void SyncRuntimeData(); // 0x06a70788
	System.Void .ctor(); // 0x06a71790
	static System.Void .cctor(); // 0x06a718fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.SchemeData : System.Object
{
	WizardGames.Soc.SocClient.Manager.VisibleFloatDictionary fovList; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.ListItemData> posList; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.ListItemScaleData> itemScaleList; // 0x20
	WizardGames.Soc.SocClient.Manager.VisibleFloatDictionary fovListPC; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.ListItemData> posListPC; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.ListItemScaleData> itemScaleListPC; // 0x38
	System.Void .ctor(); // 0x06a719d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.SerializableKeyValuePair<TKey,TValue> : System.Object
{
	TKey key; // 0x0
	TValue value; // 0x0
	TKey get_Key(); // 0x052af1f0
	TValue get_Value(); // 0x052af1f0
	System.Void .ctor(TKey key, TValue value); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.SerializableDictionary<TKey,TValue> : System.Collections.Generic.Dictionary<TKey,TValue>, UnityEngine.ISerializationCallbackReceiver
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.SerializableKeyValuePair<TKey,TValue>> entries; // 0x0
	System.Void OnBeforeSerialize(); // 0x055049cc
	System.Void OnAfterDeserialize(); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.Ui3DScene : UnityEngine.MonoBehaviour
{
	UnityEngine.Camera camera; // 0x30
	UnityEngine.RenderTexture texture; // 0x38
	FairyGUI.UIPanel panel; // 0x40
	System.String packageName; // 0x48
	UnityEngine.RenderTexture RefreshUiPanel(System.String packageName, System.String comName, System.Action<FairyGUI.GComponent,UnityEngine.RenderTexture> uiCallback); // 0x06a71b84
	System.Void ClearTexture(); // 0x06a71f68
	System.Void OnDisable(); // 0x06a72100
	System.Void .ctor(); // 0x06a72164
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbyPlayerInfoData : System.Object
{
	System.String roleId; // 0x10
	System.Int32 onlineStatus; // 0x18
	System.String nickname; // 0x20
	System.Int64 exp; // 0x28
	System.Int32 level; // 0x30
	System.String portrait; // 0x38
	System.Int64 createtime; // 0x40
	System.Int64 lastlogouttime; // 0x48
	System.Int32 portraitFrameId; // 0x50
	System.Void .ctor(System.String roleId, System.Int32 onlineStatus, System.String nickname, System.Int64 exp, System.Int32 level, System.String portrait, System.Int64 createtime, System.Int64 lastlogouttime, System.Int32 portraitFrameId); // 0x06a721cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbySceneHideLight : UnityEngine.MonoBehaviour
{
	System.Collections.Generic.List<UnityEngine.GameObject> lights; // 0x30
	System.Collections.Generic.List<System.String> hideLightUis; // 0x38
	UnityEngine.Coroutine showCoroutine; // 0x40
	UnityEngine.Coroutine hideCoroutine; // 0x48
	System.Int32 count; // 0x50
	System.Void Awake(); // 0x06a72308
	System.Void OnDestroy(); // 0x06a72494
	System.Void ShowLight(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x06a72620
	System.Collections.IEnumerator DelayedSetGlobalSpotAttributes(); // 0x06a72810
	System.Collections.IEnumerator DelayedSetGlobalSpotAttributes2(); // 0x06a72938
	System.Void HideLight(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x06a72a60
	System.Void ClearCoroutine(); // 0x06a72764
	System.Void .ctor(); // 0x06a72b9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbySceneHideLight.<DelayedSetGlobalSpotAttributes2>d__9 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Manager.LobbySceneHideLight <>4__this; // 0x20
	System.Void .ctor(System.Int32 <>1__state); // 0x06a729dc
	System.Void System.IDisposable.Dispose(); // 0x06a72ca8
	System.Boolean MoveNext(); // 0x06a72d08
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x06a72f68
	System.Void System.Collections.IEnumerator.Reset(); // 0x06a72fcc
	System.Object System.Collections.IEnumerator.get_Current(); // 0x06a73054
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbySceneHideLight.<DelayedSetGlobalSpotAttributes>d__8 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Manager.LobbySceneHideLight <>4__this; // 0x20
	System.Void .ctor(System.Int32 <>1__state); // 0x06a728b4
	System.Void System.IDisposable.Dispose(); // 0x06a730b8
	System.Boolean MoveNext(); // 0x06a73118
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x06a733ec
	System.Void System.Collections.IEnumerator.Reset(); // 0x06a73450
	System.Object System.Collections.IEnumerator.get_Current(); // 0x06a734d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbySceneModelPoint : UnityEngine.MonoBehaviour
{
	UnityEngine.GameObject[] playerLoaderTeams; // 0x30
	UnityEngine.GameObject playerLoaderMain; // 0x38
	System.Void .ctor(); // 0x06a7353c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MatchOptionsData : System.Object
{
	System.String batch; // 0x10
	System.Int32 modeId; // 0x18
	System.Int32 platform; // 0x1c
	System.Int32 teamCapacity; // 0x20
	System.Void .ctor(SimpleJSON.JSONNode node); // 0x06a735a4
	System.Void .ctor(); // 0x06a7375c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbyTeamData : System.Object
{
	System.Boolean IsFakeMatching; // 0x10
	System.Int32 MatchingRandomSeed; // 0x14
	WizardGames.Soc.SocClient.Ui.EMatchState MatchingState; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.LobbyTeamMemberData> lobbyTeamMemberDataList; // 0x20
	System.String _leaderId; // 0x28
	System.Int32 _modeId; // 0x30
	System.String _teamId; // 0x38
	System.Int32 _permission; // 0x40
	System.String _region; // 0x48
	System.Int32 _status; // 0x50
	System.Int64 _appointmentTime; // 0x58
	System.Int32 _teamCapacity; // 0x60
	System.Int32 _clientPlatform; // 0x64
	System.Collections.Generic.List<System.Int32> recommendModeIdList; // 0x68
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.MatchOptionsData> matchOptionsDataList; // 0x70
	System.String get_LeaderID(); // 0x06a737c4
	System.Int32 get_ModeID(); // 0x06a73828
	System.String get_TeamID(); // 0x06a7388c
	System.Int32 get_Permission(); // 0x06a738f0
	System.String get_Region(); // 0x06a73954
	System.Int64 get_AppointmentTime(); // 0x06a739b8
	System.Boolean get_IsAppointment(); // 0x06a73a1c
	System.Int32 get_TeamCapacity(); // 0x06a73acc
	System.Int32 get_ClientPlatform(); // 0x06a73b30
	System.Collections.Generic.List<System.Int32> get_RecommendModeIdList(); // 0x06a73b94
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.MatchOptionsData> get_MatchOptionsDataList(); // 0x06a73bf8
	System.Void SetTeamData(SimpleJSON.JSONNode ret); // 0x06a73c5c
	System.Void SetMatchOptionsDataList(SimpleJSON.JSONArray matchOptions); // 0x06a746c4
	System.Void ClearRecommendModeData(); // 0x06a74ad4
	System.Void SetRecommendModeIdList(SimpleJSON.JSONArray modeIdList); // 0x06a748b0
	System.Void SetMatchOptionsDataList(System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.MatchOptionsData> optionsDataList); // 0x06a74b90
	System.Void SetAllReady(System.Boolean isReady); // 0x06a74c64
	System.Void SetReady(System.String roleId, System.Boolean isReady); // 0x06a74d98
	System.Void SetTeamCapacity(System.Int32 teamCapacity); // 0x06a74f5c
	System.Void SetTeamRegion(System.String region); // 0x06a74fd4
	System.Void SetAppointmentTime(System.Int64 appointmentTime); // 0x06a75054
	System.Void SetBattlePlatform(System.Int32 battlePlatform); // 0x06a750cc
	System.Void SetTeamID(System.String teamID); // 0x06a75144
	System.Void SetMemberPlatform(System.String roleId, System.Int32 platform); // 0x06a751c4
	System.Void SetLeaderID(System.String leaderId); // 0x06a75384
	System.Void SetModeID(System.Int32 modeId); // 0x06a75404
	System.Void SetPermission(System.Int32 permission); // 0x06a7547c
	System.Boolean HasLobbyTeam(); // 0x06a754f4
	System.Boolean IsCaptain(System.String roleId); // 0x06a75580
	System.Boolean IsAppointmentTimeReached(); // 0x06a7564c
	WizardGames.Soc.SocClient.Manager.LobbyTeamMemberData GetMemberDataByRoleId(System.String roleId); // 0x06a75770
	System.Void Clear(); // 0x06a758dc
	System.Void .ctor(); // 0x06a75a3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbyTeamMemberData : System.Object
{
	System.Collections.Generic.List<System.Int32> preferenceOptionList; // 0x10
	System.String _battlePlayerData; // 0x18
	System.String _joinTime; // 0x20
	System.String _roleId; // 0x28
	System.Boolean ready; // 0x30
	System.Int64 _lastMatchWarzoneTime; // 0x38
	System.Int32 clientPlatform; // 0x40
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> _costumeSlotInfo; // 0x48
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> _equipmentSlotInfo; // 0x50
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> _showOptInfo; // 0x58
	System.String get_RoleID(); // 0x06a75c0c
	System.Boolean get_Ready(); // 0x06a75c70
	System.Int32 get_ClientPlatform(); // 0x06a75cd4
	System.Int64 get_LastMatchWarzoneTime(); // 0x06a75d38
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> get_CostumeSlotInfo(); // 0x06a75d9c
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> get_EquipmentSlotInfo(); // 0x06a75e00
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> get_ShowOptInfo(); // 0x06a75e64
	System.Void .ctor(System.String joinTime, System.String roleId, System.Boolean isReady, System.Int64 lastMatchWarzoneTime, System.Int32 clientPlatform, SimpleJSON.JSONNode costumeSlotInfo, SimpleJSON.JSONNode equipmentSlotInfo, SimpleJSON.JSONNode showOptInfo); // 0x06a75ec8
	System.Void .ctor(SimpleJSON.JSONNode node); // 0x06a74250
	System.Void SetPreferenceOptionList(SimpleJSON.JSONArray jobs); // 0x06a76640
	System.Void SetCostumeSlotInfo(SimpleJSON.JSONNode costumeSlotInfo); // 0x06a76148
	System.Void SetEquipmentSlotInfo(SimpleJSON.JSONNode equipmentSlotInfo); // 0x06a762f0
	System.Void SetShowOptInfo(SimpleJSON.JSONNode showOptInfo); // 0x06a76498
	System.Void SetReady(System.Boolean isReady); // 0x06a767ac
	System.Void SetClientPlatform(System.Int32 platform); // 0x06a76828
	System.Void SetPreferenceOptionList(System.Collections.Generic.List<System.Int32> dataList); // 0x06a768a0
	System.Collections.Generic.List<System.Int32> GetPreferenceOptionList(); // 0x06a76a08
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.ELobbyModelType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.ELobbyModelType LobbyTeamModel = 0;
	static WizardGames.Soc.SocClient.Manager.ELobbyModelType HistoryModel = 1;
	static WizardGames.Soc.SocClient.Manager.ELobbyModelType MainModel = 2;
	static WizardGames.Soc.SocClient.Manager.ELobbyModelType AppointmentTeamModel = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbyModelData : System.Object
{
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Manager.LobbDisplayModel> playersDic; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.CustomType.PlayerDisplayData> displayDataDic; // 0x18
	System.Void .ctor(); // 0x06a76a6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbDisplayModel : System.Object
{
	WizardGames.Soc.SocClient.GoLoader.DisplayModel displayModel; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x06a76b78
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LobbyTeamPlayerModel : System.Object
{
	static SocLogger Log; // 0x0
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Manager.ELobbyModelType,WizardGames.Soc.SocClient.Manager.LobbyModelData> playerModelsDic; // 0x10
	System.Single[] hideTime; // 0x18
	System.Single animTime; // 0x20
	System.Collections.Generic.List<System.Int32> keysToRemove; // 0x28
	WizardGames.Soc.SocClient.Manager.LobbySceneModelPoint lobbyModelPoint; // 0x30
	System.String TEAM_TRACK; // 0x38
	System.Void InitLobbyModelPoint(); // 0x06a76be0
	UnityEngine.GameObject GetLobbyMainModelRoot(); // 0x06a76d04
	System.Void PlayerBindTimeline(); // 0x06a76df0
	System.Void ReleaseDisplayPlayers(WizardGames.Soc.SocClient.Manager.ELobbyModelType type); // 0x06a771b8
	System.Void ReleaseAllDisplayPlayers(); // 0x06a778e0
	UnityEngine.Vector3 GetPlayerParentPos(System.Int32 index); // 0x06a77ab8
	System.Boolean IsPlayerModelsDicNull(WizardGames.Soc.SocClient.Manager.ELobbyModelType type); // 0x06a77c5c
	System.Void SetModelActive(WizardGames.Soc.SocClient.Manager.ELobbyModelType type, System.Boolean show); // 0x06a77dd8
	WizardGames.Soc.SocClient.Manager.LobbyModelData GetPlayerModelByType(WizardGames.Soc.SocClient.Manager.ELobbyModelType type); // 0x06a78014
	System.Void DeletePlayer(WizardGames.Soc.SocClient.Manager.ELobbyModelType type, System.Int32 index); // 0x06a775ac
	System.Void CreatePlayModel(WizardGames.Soc.SocClient.Manager.ELobbyModelType type, System.Int32 index, WizardGames.Soc.Common.CustomType.PlayerDisplayData displayData, System.String roleId, System.Boolean isAppointment, System.Boolean isPlayAnim); // 0x06a780f0
	System.Void SetGoLayer(System.Int32 layer); // 0x06a797a4
	System.Void PutOnPlan(WizardGames.Soc.SocClient.Manager.LobbDisplayModel displayModel, WizardGames.Soc.Common.CustomType.PlayerDisplayData displayData, System.String roleId, System.Boolean isAppointment); // 0x06a79958
	System.Void SetSpecialIdleAnim(WizardGames.Soc.Common.CustomType.PlayerDisplayData displayData, System.String roleId, System.Boolean isAppointment); // 0x06a794b4
	System.Void PutOnPlan(WizardGames.Soc.Common.CustomType.PlayerDisplayData displayData, System.String roleId, System.Boolean isAppointment); // 0x06a78cc4
	System.Void GetPlayerDisplayData(WizardGames.Soc.SocClient.Manager.ELobbyModelType type, System.Int32 index, WizardGames.Soc.SocClient.Manager.LobbDisplayModel& displayModel, WizardGames.Soc.Common.CustomType.PlayerDisplayData& displayData); // 0x06a79a18
	System.Void UpdateLobbyModelData(WizardGames.Soc.SocClient.Manager.ELobbyModelType type, System.Int32 index, WizardGames.Soc.Common.CustomType.PlayerDisplayData displayData); // 0x06a79b94
	System.Void OnPartModelLoaded(UnityEngine.Animator animator, UnityEngine.AnimatorCullingMode mode); // 0x06a796cc
	System.Void SetCaptainParent(UnityEngine.Transform parent); // 0x06a79cb0
	System.Void .ctor(); // 0x06a7a0d4
	static System.Void .cctor(); // 0x06a7a26c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrMail : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger log; // 0x0
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Mail.Core.MailInfo> lobbyMailInfos; // 0x18
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Mail.Core.MailInfo> gameMailInfos; // 0x20
	System.Action OnMailsFetchDone; // 0x28
	System.Action<System.String> OnMailContentFetchDone; // 0x30
	System.Int32 CLICK_CD; // 0x38
	System.Void OnAccountEnterLobby(); // 0x06a7a340
	System.Void OnAccountLogout(); // 0x06a7a4e0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Mail.Core.MailInfo> GetLobbyMailInfos(); // 0x06a7a570
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Mail.Core.MailInfo> GetGameMailInfos(); // 0x06a7a674
	System.Int32 GetMailCount(); // 0x06a7a778
	System.Boolean HasUnreadMail(WizardGames.Soc.SocClient.Mail.Core.EMailSource mailSource); // 0x06a7a81c
	System.Boolean HasUnreadLobbyMail(); // 0x06a7a8a8
	System.Boolean HasUnreadGameMail(); // 0x06a7aab8
	System.Int32 GetCanDeleteMailCount(WizardGames.Soc.SocClient.Mail.Core.EMailSource mailSource); // 0x06a7acc8
	System.Boolean HasUnReceiveAttachment(WizardGames.Soc.SocClient.Mail.Core.EMailSource mailSource); // 0x06a7b068
	System.Boolean HasUnReceiveLobbyAttachment(); // 0x06a7b0f4
	System.Int32 GetUnReceiveLobbyAttachmentCount(); // 0x06a7b49c
	System.Boolean HasUnReceiveGameAttachment(); // 0x06a7b2c8
	System.Int32 GetUnReceiveGameAttachmentCount(); // 0x06a7b678
	System.Void CheckAwakeUpTips(); // 0x06a7b854
	WizardGames.Soc.SocClient.Mail.Core.MailInfo GetMailById(System.String id, WizardGames.Soc.SocClient.Mail.Core.EMailSource mailSource); // 0x06a7be7c
	System.Boolean IsShowMailRedDot(); // 0x06a7bf98
	System.Void ReqLobbyMailList(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule); // 0x06a7a3b4
	System.Void ReqLobbyMailCallback(SimpleJSON.JSONNode response); // 0x06a7c59c
	System.Void ReqLobbyMailContent(System.String id); // 0x06a7cb40
	System.Void RefreshLobbyMailContent(SimpleJSON.JSONNode response); // 0x06a7cd44
	System.Void ReqDeleteAllLobbyMail(); // 0x06a7d030
	System.Void ReqDeleteLobbyMail(System.String id); // 0x06a7d760
	System.Void ReqDeleteLobbyMailCallback(System.String[] ids); // 0x06a7d9b0
	System.Void ReqReadLobbyMail(System.String id); // 0x06a7dac4
	System.Void ReqReadAllLobbyMail(); // 0x06a7dd14
	System.Void LobbyReadMailCallback(System.String[] ids); // 0x06a7e20c
	System.Void ReqReceivedAllLobbyAttachment(); // 0x06a7e39c
	System.Void ReqReceivedLobbyAttachment(System.String id); // 0x06a7e82c
	System.Void LobbyRecvAttachmentCallback(System.String[] ids); // 0x06a7ea7c
	System.Void CallLobbyPost(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, WizardGames.Soc.SocClient.Mail.Core.ERequestOp opName, System.Action<SimpleJSON.JSONNode> callback, SimpleJSON.JSONObject body); // 0x06a7d544
	System.Void CallLobbyGet(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, WizardGames.Soc.SocClient.Mail.Core.ERequestOp opName, System.Boolean showErrorPopup, System.Collections.Generic.IDictionary<System.String,System.String> param, System.Action<SimpleJSON.JSONNode> callback, System.Action<SimpleJSON.JSONNode> errprCallBack); // 0x06a7c364
	System.Void ReqRefreshGameMailList(); // 0x06a7ebbc
	System.Void RefreshGameMailInfos(); // 0x06a7ec98
	System.Void ResponseAddOneGameMail(System.Int64 mailId, WizardGames.Soc.Common.CustomType.MailNode mailNode); // 0x06a7f004
	System.Void ReqReadOneGameMail(System.Int64 id); // 0x06a7f1b0
	System.Void ReqReadOneGameMailCallback(System.Int64 mailId); // 0x06a7f2a8
	System.Void ReqReadAllGameMail(); // 0x06a7f3c8
	System.Void ReqReadAllGameMailCallback(System.Collections.Generic.List<System.Int64> mailIds); // 0x06a7f4a4
	System.Void ReqDeleteOneGameMail(System.Int64 id); // 0x06a7f6d4
	System.Void ResponseDeleteOneGameMail(System.Int64 mailId); // 0x06a7f7cc
	System.Void ReqDeleteAllGameMail(); // 0x06a7f8f0
	System.Void ResponseDeleteAllGameMail(); // 0x06a7f9cc
	System.Void ReqReceivedOneGameAttachment(System.Int64 id); // 0x06a7fa90
	System.Void ReqReceivedOneGameAttachmentCallback(System.Int64 id); // 0x06a7fb88
	System.Void ReqReceivedAllGameAttachment(); // 0x06a7fd58
	System.Void ReqReceivedAllGameAttachmentCallback(System.Collections.Generic.List<System.Int64> mailIds); // 0x06a7fe34
	System.Void OnMyPlayerLoadSuccess(); // 0x06a80138
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06a8019c
	System.Threading.Tasks.Task OnExitWorld(); // 0x06a802e0
	System.Void .ctor(); // 0x06a80448
	static System.Void .cctor(); // 0x06a80534
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrMail.<>c__DisplayClass30_0 : System.Object
{
	System.String id; // 0x10
	WizardGames.Soc.SocClient.Manager.MgrMail <>4__this; // 0x18
	System.Void .ctor(); // 0x06a7ccdc
	System.Void <ReqLobbyMailContent>b__0(SimpleJSON.JSONNode error); // 0x06a80608
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrMail.<>c__DisplayClass32_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrMail <>4__this; // 0x10
	System.String[] ids; // 0x18
	System.Void .ctor(); // 0x06a7d4dc
	System.Void <ReqDeleteAllLobbyMail>b__0(SimpleJSON.JSONNode json); // 0x06a808a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrMail.<>c__DisplayClass33_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrMail <>4__this; // 0x10
	System.String[] array; // 0x18
	System.Void .ctor(); // 0x06a7d948
	System.Void <ReqDeleteLobbyMail>b__0(SimpleJSON.JSONNode json); // 0x06a80928
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrMail.<>c__DisplayClass35_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrMail <>4__this; // 0x10
	System.String[] array; // 0x18
	System.Void .ctor(); // 0x06a7dcac
	System.Void <ReqReadLobbyMail>b__0(SimpleJSON.JSONNode json); // 0x06a809ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrMail.<>c__DisplayClass36_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrMail <>4__this; // 0x10
	System.String[] array; // 0x18
	System.Void .ctor(); // 0x06a7e1a4
	System.Void <ReqReadAllLobbyMail>b__0(SimpleJSON.JSONNode json); // 0x06a80a30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrMail.<>c__DisplayClass38_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrMail <>4__this; // 0x10
	System.String[] array; // 0x18
	System.Void .ctor(); // 0x06a7e7c4
	System.Void <ReqReceivedAllLobbyAttachment>b__0(SimpleJSON.JSONNode json); // 0x06a80ab4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrMail.<>c__DisplayClass39_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrMail <>4__this; // 0x10
	System.String[] array; // 0x18
	System.Void .ctor(); // 0x06a7ea14
	System.Void <ReqReceivedLobbyAttachment>b__0(SimpleJSON.JSONNode json); // 0x06a80b38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrActiveLottery : WizardGames.Soc.SocClient.Manager.MgrLotteryBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Manager.FragmentLotteryInfo> activeLotteryMap; // 0x38
	System.Void ReqActivityLotteryInfos(); // 0x06a80bbc
	System.Boolean IsValidDrawLottery(System.Int32 lotteryId); // 0x06a81144
	System.Void OnRspLotteryInfos(SimpleJSON.JSONNode ret); // 0x06a81528
	System.Void DrawLottery(System.Int32 lotteryID, System.Int32 count); // 0x06a820f0
	System.Void OnRspDrawLottery(SimpleJSON.JSONNode ret, System.Boolean isTenLottery); // 0x06a824cc
	System.Void ShowLotteryRewardUI(System.Int32 lotteryID, System.Boolean isTenLottery, System.Boolean isHotResources); // 0x06a82784
	System.Int32 GetCurrentActiveLotteryId(System.Int32 lastLotteryId); // 0x06a829ac
	WizardGames.Soc.SocClient.Manager.FragmentLotteryInfo GetActiveLotteryInfo(System.Int32 lotteryID); // 0x06a82ca4
	System.Collections.Generic.List<System.String> GetActivityGachaId(); // 0x06a80d88
	System.Collections.Generic.List<System.Int32> GetPoolRewardResourceGroupID(System.Int32 lotteryID); // 0x06a82d50
	System.Boolean GetSpecialTagShow(); // 0x06a8301c
	System.Void .ctor(); // 0x06a831ec
	static System.Void .cctor(); // 0x06a833e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrActiveLottery.<>c__DisplayClass5_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrActiveLottery <>4__this; // 0x10
	System.Int32 count; // 0x18
	System.Void .ctor(); // 0x06a82464
	System.Void <DrawLottery>b__0(SimpleJSON.JSONNode ret); // 0x06a834b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrCommercialBgm : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.String stateName; // 0x18
	System.Void SwitchBGMStateName(System.String stateName); // 0x06a83544
	System.Void InitCommercialBgm(System.Action completeAction); // 0x06a836b0
	System.Void StopCommercialBgm(); // 0x06a838dc
	System.Void SwitchGachaPvBgm(); // 0x06a839d4
	System.Void SwitchGachaCgBgm(); // 0x06a83d84
	System.Void SwitchGachaNormalBgm(); // 0x06a83efc
	System.Void .ctor(); // 0x06a8411c
	static System.Void .cctor(); // 0x06a84184
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrCommercialBgm.<>c__DisplayClass3_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrCommercialBgm <>4__this; // 0x10
	System.Action completeAction; // 0x18
	System.Void .ctor(); // 0x06a83874
	System.Void <InitCommercialBgm>b__0(WizardGames.Soc.SocClient.Audio.WWise.AudioEventData data, System.Object id); // 0x06a84258
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrFragmentLottery : WizardGames.Soc.SocClient.Manager.MgrLotteryBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.mall.OBJLotteryBaseInfo> allAcitveCachas; // 0x38
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Manager.FragmentLotteryInfo> fragmentLotteryMap; // 0x40
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.HashSet<System.Int32>> hotResourcesIdMap; // 0x48
	FairyGUI.Transition transition; // 0x50
	System.Void OnAccountLogout(); // 0x06a8435c
	System.Boolean IsValidDrawLottery(System.Int32 lotteryId); // 0x06a844f0
	WizardGames.Soc.SocClient.Manager.FragmentLotteryInfo GetPoolInfo(System.Int32 lotteryId); // 0x06a84668
	System.Void RequestFragmentLotteryInfos(); // 0x06a84714
	System.Void RequestLotteryInfos(System.Collections.Generic.List<System.String> lotteryIDs); // 0x06a84be0
	System.Void OnRspLotteryInfos(SimpleJSON.JSONNode ret); // 0x06a84da8
	System.Void ExchangeLotteryItem(System.Int32 lotteryID, System.Int32 resourcesGroupId, System.Int32 count); // 0x06a8531c
	System.Void OnRspExchangeLotteryItem(SimpleJSON.JSONNode ret); // 0x06a855d8
	System.Void ClaimProgressReward(System.Int32 lotteryID, System.Int32 progressID); // 0x06a85890
	System.Void OnRspClaimProgressReward(SimpleJSON.JSONNode ret); // 0x06a85af4
	System.Void DrawLottery(System.Int32 lotteryID, System.Int32 count, FairyGUI.Transition transition); // 0x06a85b74
	System.Void OnRspDrawLottery(SimpleJSON.JSONNode ret, System.Boolean isTenLottery); // 0x06a86024
	System.Void PraseLotteryRspInfo(SimpleJSON.JSONNode ret, WizardGames.Soc.Common.Unity.Event.EventDefine eventDefine); // 0x06a85658
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.mall.OBJLotteryBaseInfo> GetAllActiveGachas(); // 0x06a8497c
	System.Collections.Generic.List<System.Int32> GetActivityGachaId(); // 0x06a86548
	WizardGames.Soc.SocClient.Manager.FragmentLotteryInfo GetFragmentLotteryPoolInfo(System.Int32 lotteryId); // 0x06a868ec
	System.Int32 GetCurExchangeRewardAmount(System.Int32 lotteryId, System.Int32 resourceGroupID); // 0x06a86998
	System.Int32 GetProgressReward(System.Int32 lotteryId, System.Int32 lotteryCount, System.Int32 totalNum); // 0x06a86b10
	System.String GetLotteryProbability(System.Int32 lotteryId, System.Int32 poolNum, System.Int32 resourceGroupID); // 0x06a86c64
	System.Boolean IsOwnedReward(System.Int32 lotteryId, System.Int32 resourceGroupID); // 0x06a86fbc
	System.Boolean IsSkipAnimation(); // 0x06a87050
	System.Void SetIsSkipAnimation(System.Boolean isSKip); // 0x06a87100
	System.Void ShowLotteryRewardUI(System.Int32 lotteryID, System.Boolean isTenLottery, System.Boolean isHotResources); // 0x06a871c4
	System.Void OpenShareWin(); // 0x06a87424
	System.Void .ctor(); // 0x06a875b4
	static System.Void .cctor(); // 0x06a87714
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrFragmentLottery.<>c__DisplayClass16_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrFragmentLottery <>4__this; // 0x10
	System.Int32 count; // 0x18
	System.Void .ctor(); // 0x06a85fbc
	System.Void <DrawLottery>b__0(SimpleJSON.JSONNode ret); // 0x06a877e8
	System.Void <DrawLottery>b__1(SimpleJSON.JSONNode errorJson); // 0x06a87878
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrFragmentLottery.<>c__DisplayClass17_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrFragmentLottery <>4__this; // 0x10
	System.Boolean isTenLottery; // 0x18
	System.Int32 lotteryID; // 0x1c
	System.Boolean isHotResources; // 0x20
	System.Void .ctor(); // 0x06a8645c
	System.Void <OnRspDrawLottery>b__0(); // 0x06a879f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.FragmentLotteryInfo : System.Object
{
	System.Int32 lotteryID; // 0x10
	System.Boolean isOpen; // 0x14
	System.Int32 count; // 0x18
	System.Int32 dailyCount; // 0x1c
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> exchangeRewardedMap; // 0x20
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> poolGraranteeMap; // 0x28
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> poolRewardedMap; // 0x30
	System.Collections.Generic.HashSet<System.Int32> progressRewardedIDList; // 0x38
	System.Collections.Generic.HashSet<System.Int32> newGetRewardIdList; // 0x40
	System.Void SetLotteryInfo(SimpleJSON.JSONNode jsonNode); // 0x06a8194c
	System.Boolean IsProgressRewardObtain(System.Int32 progressID); // 0x06a87af0
	System.Int32 GetExchangeRewardedInfo(System.Int32 id); // 0x06a86a64
	System.Boolean IsOwnedReward(System.Int32 id); // 0x06a86f20
	System.Collections.Generic.HashSet<System.Int32> GetNewGetRewardIdList(); // 0x06a87b8c
	System.Void ClearNewGetRewardIdList(); // 0x06a864c4
	System.Int32 GetGraranteeCount(System.Int32 groupID); // 0x06a87bf0
	System.Void .ctor(); // 0x06a817c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrGacha : WizardGames.Soc.SocClient.Manager.MgrLotteryBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<System.String> gacheReqParams; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.mall.OBJMallGacha> allAcitveCachas; // 0x40
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> cachasPoolMap; // 0x48
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Manager.GachaPoolInfo> gachaPoolInfosMap; // 0x50
	System.Void OnAccountLogout(); // 0x06a87ccc
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.mall.OBJMallGacha> GetAllActiveGachas(); // 0x06a87de4
	System.Collections.Generic.List<System.Int32> GetActivityGachaId(); // 0x06a88118
	System.Void RequestAllWithoutReplacementLotteryInfos(); // 0x06a884b0
	System.Void RequestWithoutReplacementLotteryInfos(System.Collections.Generic.List<System.String> lotteryIDs); // 0x06a88718
	System.Void OnRspWithoutReplacementLotteryInfos(SimpleJSON.JSONNode ret); // 0x06a888e0
	System.Void DrawWithoutReplacementLottery(System.Int32 lotteryID, System.Int32 round); // 0x06a88e10
	System.Void OnRspDrawWithoutReplacementLottery(SimpleJSON.JSONNode ret); // 0x06a891f8
	System.Boolean IsValidDrawLottery(System.Int32 lotteryId); // 0x06a89628
	WizardGames.Soc.SocClient.Manager.GachaPoolInfo GetGachaPoolInfo(System.Int32 lotteryId); // 0x06a89790
	System.Boolean IsGachaPoolIdxOwned(System.Int32 letteryId, System.Int32 poolId); // 0x06a8983c
	System.String GetGachaPoolProbability(System.Int32 letteryId, System.Int32 poolNum, System.Int32 poolIdx); // 0x06a898dc
	System.Void ShowLotteryRewardUI(System.Int32 lotteryID, System.Boolean isTenLottery, System.Boolean isHotResources); // 0x06a89b84
	System.Void OpenShareWin(); // 0x06a89de8
	System.Void .ctor(); // 0x06a89e54
	static System.Void .cctor(); // 0x06a8a00c
	System.Void <DrawWithoutReplacementLottery>b__11_0(SimpleJSON.JSONNode errorJson); // 0x06a8a0e0
	System.Void <ShowLotteryRewardUI>b__17_0(); // 0x06a8a25c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrGacha.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Manager.MgrGacha.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Data.mall.OBJMallGacha> <>9__6_0; // 0x8
	static System.Void .cctor(); // 0x06a8a2c0
	System.Void .ctor(); // 0x06a8a324
	System.Int32 <GetAllActiveGachas>b__6_0(WizardGames.Soc.Common.Data.mall.OBJMallGacha a, WizardGames.Soc.Common.Data.mall.OBJMallGacha b); // 0x06a8a38c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.GachaPoolInfo : System.Object
{
	System.Int32 lotteryId; // 0x10
	System.Int32 round; // 0x14
	System.Collections.Generic.List<System.Int32> poolIdxList; // 0x18
	System.Void .ctor(System.Int32 lotteryID, System.Int32 round, System.Collections.Generic.List<System.Int32> poolList); // 0x06a88d14
	System.Boolean IsContainPool(System.Int32 idx); // 0x06a8958c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLotteryBase : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Data.common.OBJConditionSwitch> gachaConditionSwitchMap; // 0x18
	System.Collections.Generic.HashSet<System.Int32> lotteryPvPlayTag; // 0x20
	SimpleJSON.JSONObject reqParams; // 0x28
	System.Int32 shareLotteryId; // 0x30
	WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType shareType; // 0x34
	System.Boolean CheckOBJConditionSwitchValid(System.Int32[] groupIds, WizardGames.Soc.Common.Data.common.OBJConditionSwitch& conditionSwitch); // 0x06a81384
	System.Boolean IsValidCachaCondition(WizardGames.Soc.Common.Data.common.OBJConditionSwitch conditionSwitch); // 0x06a8a430
	System.Boolean IsValidDrawLottery(System.Int32 lotteryId); // 0x06a812bc
	System.Boolean GetRemainTimeDesc(System.TimeSpan offset, System.String& desc); // 0x06a8a510
	System.Boolean GetRemainTimeDesc(System.String serverTimeStr, System.String& desc); // 0x06a8a85c
	System.Boolean IsGachaPoolRead(System.Int32 lotteryId); // 0x06a8a98c
	System.Void SetGachaPoolRead(System.Int32 lotteryId); // 0x06a8ab2c
	System.String GenerateSaveKey(System.Int32 lotteryId); // 0x06a8aa60
	WizardGames.Soc.Common.Data.common.OBJConditionSwitch GetConditionSwitch(System.Int32 lotteryId); // 0x06a8abf8
	System.Void ShowCommonRewardUI(); // 0x06a828bc
	System.Void ShowLotteryRewardUI(System.Int32 lotteryID, System.Boolean isTenLottery, System.Boolean isHotResources); // 0x06a8282c
	System.Void Clear(); // 0x06a8445c
	System.Void OpenShareWin(); // 0x06a87490
	System.Void .ctor(); // 0x06a8329c
	System.Void <OpenShareWin>b__18_0(); // 0x06a8ac94
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.EMallLotteryType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.EMallLotteryType None = 0;
	static WizardGames.Soc.SocClient.Manager.EMallLotteryType NoReturnGacha = 1;
	static WizardGames.Soc.SocClient.Manager.EMallLotteryType FragmentLottery = 2;
	static WizardGames.Soc.SocClient.Manager.EMallLotteryType ActiveLottery = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.GameViewColliderVisualizer : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	System.Boolean isEnabled; // 0x30
	System.Collections.Generic.List<UnityEngine.Collider> allColliders; // 0x38
	System.Collections.Generic.Dictionary<UnityEngine.Collider,UnityEngine.GameObject> visualizerObjects; // 0x40
	UnityEngine.Material redMaterial; // 0x48
	UnityEngine.Texture2D dynamicRedTexture; // 0x50
	System.Void Initialize(); // 0x06a8acf8
	System.Void CreateRedMaterial(); // 0x06a8af30
	System.Void SetupTransparentMaterial(UnityEngine.Material material); // 0x06a8badc
	UnityEngine.Texture2D CreateSolidColorTexture(System.Int32 width, System.Int32 height, UnityEngine.Color color); // 0x06a8b96c
	System.Void RefreshColliders(); // 0x06a8b618
	System.Void Update(); // 0x06a8bd9c
	System.Void UpdateVisualization(); // 0x06a8b71c
	System.Boolean ShouldVisualizeCollider(UnityEngine.Collider collider); // 0x06a8c484
	System.Void CreateColliderVisualization(UnityEngine.Collider collider); // 0x06a8c6b4
	UnityEngine.Mesh GetMeshFromCollider(UnityEngine.Collider collider); // 0x06a8c9cc
	UnityEngine.Mesh CreatePrimitiveMesh(UnityEngine.PrimitiveType primitiveType); // 0x06a8ceb8
	System.Void AdjustVisualizerScale(UnityEngine.GameObject visualizerObj, UnityEngine.Collider collider); // 0x06a8cb78
	System.Void CleanupDestroyedColliders(); // 0x06a8c020
	System.Void ClearVisualization(); // 0x06a8be18
	System.Void ReleaseResources(); // 0x06a8cfa8
	System.Void OnDestroy(); // 0x06a8d0e8
	System.Void .ctor(); // 0x06a8d154
	static System.Void .cctor(); // 0x06a8d260
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.EEscCloseName : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.EEscCloseName None = 0;
	static WizardGames.Soc.SocClient.Manager.EEscCloseName BuildPanel = 1;
	static WizardGames.Soc.SocClient.Manager.EEscCloseName UiHudUsingItem = 2;
	static WizardGames.Soc.SocClient.Manager.EEscCloseName ShotcutsBelt = 3;
	static WizardGames.Soc.SocClient.Manager.EEscCloseName AidProgressBar = 4;
	static WizardGames.Soc.SocClient.Manager.EEscCloseName TerritoryEditComform = 5;
	static WizardGames.Soc.SocClient.Manager.EEscCloseName InventoryOthersideContainerTip = 6;
	static WizardGames.Soc.SocClient.Manager.EEscCloseName KatyushaLoadMissile = 7;
	static WizardGames.Soc.SocClient.Manager.EEscCloseName StockManagement = 8;
	static WizardGames.Soc.SocClient.Manager.EEscCloseName SurprisePlayRank = 9;
	static WizardGames.Soc.SocClient.Manager.EEscCloseName VehicleItemPopup = 10;
	static WizardGames.Soc.SocClient.Manager.EEscCloseName UiLeftInfoTip = 11;
	static WizardGames.Soc.SocClient.Manager.EEscCloseName UiMissionCompletePop = 12;
	static WizardGames.Soc.SocClient.Manager.EEscCloseName UiTaskTipPop = 13;
	static WizardGames.Soc.SocClient.Manager.EEscCloseName MainMapSidePanel = 14;
	static WizardGames.Soc.SocClient.Manager.EEscCloseName MainMapMarkerDetailView = 15;
	static WizardGames.Soc.SocClient.Manager.EEscCloseName UiHudQuickChat = 16;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.EHotKeyLayer : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.EHotKeyLayer Base = 0;
	static WizardGames.Soc.SocClient.Manager.EHotKeyLayer HudMain = 1;
	static WizardGames.Soc.SocClient.Manager.EHotKeyLayer Build = 2;
	static WizardGames.Soc.SocClient.Manager.EHotKeyLayer Interactive = 3;
	static WizardGames.Soc.SocClient.Manager.EHotKeyLayer ScreenUI = 4;
	static WizardGames.Soc.SocClient.Manager.EHotKeyLayer PopUI = 5;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.EResponseLevel : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.EResponseLevel NoCursor = 0;
	static WizardGames.Soc.SocClient.Manager.EResponseLevel OnHud = 1;
	static WizardGames.Soc.SocClient.Manager.EResponseLevel OnUi = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.HotKeyAction : System.Object
{
	
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.HotKeyResData : System.Object
{
	
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.HotKeyCenterGuideData : System.Object
{
	System.Int32 id; // 0x10
	WizardGames.Soc.Common.Data.EHotKeyGuideGroup Group; // 0x14
	System.String Text; // 0x18
	System.Int32 Status; // 0x20
	System.Int32 Time; // 0x24
	System.Single Progress; // 0x28
	System.Boolean PlayEffect; // 0x2c
	System.Void set_Id(System.Int32 value); // 0x06a8d398
	System.Void Reset(); // 0x06a8d4c0
	System.Void .ctor(); // 0x06a8d528
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.HotKeyUtils : System.Object
{
	static System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.HotKeyCenterGuideData> HotKeyBuildGuide; // 0x0
	static System.String BuildGuideTitle; // 0x8
	static System.String BuildGuideDescription; // 0x10
	static System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.HotKeyResData> BuildGuideResList; // 0x18
	static System.Boolean get_DebugHotKey(); // 0x06a8d590
	static System.Boolean HandleHotKey(WizardGames.Soc.Common.Data.ActionName hKey, WizardGames.Soc.Common.Data.ActionName originKey); // 0x06a8d5ec
	static System.Boolean HandleHotKeyUp(WizardGames.Soc.Common.Data.ActionName hKey); // 0x06a8d664
	static System.Boolean IsKeyPressing(WizardGames.Soc.Common.Data.ActionName hKey); // 0x06a8d6c8
	static System.Void RecordKeyPress(WizardGames.Soc.Common.Data.ActionName hKey); // 0x06a8d72c
	static System.Single GetKeyPressTime(WizardGames.Soc.Common.Data.ActionName hKey); // 0x06a8d78c
	static System.Void ForgetKeyPress(WizardGames.Soc.Common.Data.ActionName hKey); // 0x06a8d7f0
	static System.Void ClearAllKeyPressTime(); // 0x06a8d850
	static System.Void UpdateMaxKeyGruop(); // 0x06a8d8a8
	static System.Void InvokeAllEsc(); // 0x06a8d900
	static System.Void OnFpsUnlimitedUpdateUI(System.Single dt); // 0x06a8d958
	static WizardGames.Soc.SocClient.Manager.HotKeyAction AddHotKey(WizardGames.Soc.Common.Data.ActionName hKey, FairyGUI.EventCallback0 func, WizardGames.Soc.SocClient.Manager.EHotKeyLayer group, WizardGames.Soc.SocClient.Manager.EResponseLevel responseLevel); // 0x06a8d9c4
	static System.Void RemoveHotKey(WizardGames.Soc.SocClient.Manager.HotKeyAction& action); // 0x06a8da58
	static System.Void ShowCenterGuide(WizardGames.Soc.SocClient.Manager.HotKeyCenterGuideData data); // 0x06a8dab8
	static System.Void HideCenterGuide(WizardGames.Soc.SocClient.Manager.HotKeyCenterGuideData data); // 0x06a8db18
	static System.Void ClearBuildInfo(); // 0x06a8db78
	static System.Void ShowBuildGuide(WizardGames.Soc.SocClient.Manager.HotKeyCenterGuideData data); // 0x06a8dbd0
	static System.Void HideBuildGuide(WizardGames.Soc.SocClient.Manager.HotKeyCenterGuideData data); // 0x06a8dc30
	static System.Void FireHotKeyBuildGuideChangedMsg(); // 0x06a8dc90
	static System.Void AddWheelHotKey(System.UInt32 index, System.Func<System.Boolean> func); // 0x06a8dce8
	static System.Void RemoveWheelHotKey(System.UInt32 index); // 0x06a8dd5c
	static System.Void ShowSideGuide(WizardGames.Soc.Common.Data.EHotKeyGuideGroup group); // 0x06a8ddbc
	static System.Void HideSideGuide(WizardGames.Soc.Common.Data.EHotKeyGuideGroup group); // 0x06a8de1c
	static System.Void UpdateSideGuideCustomText(WizardGames.Soc.Common.Data.EHotKeyGuideGroup group, WizardGames.Soc.Common.Data.ActionName actionName, System.String customText); // 0x06a8de7c
	static System.Void AddSideGuideFilterItem(WizardGames.Soc.Common.Data.EHotKeyGuideGroup group, WizardGames.Soc.Common.Data.ActionName actionName); // 0x06a8def8
	static System.Void RemoveSideGuideFilterItem(WizardGames.Soc.Common.Data.EHotKeyGuideGroup group, WizardGames.Soc.Common.Data.ActionName actionName); // 0x06a8df6c
	static System.Single GetHotKeyProgressStartTime(WizardGames.Soc.Common.Data.ActionName hKey); // 0x06a8dfe0
	static System.Boolean IsPressed(WizardGames.Soc.Common.Data.ActionName hKey); // 0x06a8e10c
	static System.Void .cctor(); // 0x06a8e170
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.ObMode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.ObMode None = 0;
	static WizardGames.Soc.SocClient.Manager.ObMode Patroller = 1;
	static WizardGames.Soc.SocClient.Manager.ObMode Anchor = 2;
	static WizardGames.Soc.SocClient.Manager.ObMode Replay = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrAoiGrid : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Int32 xMapOffset; // 0x14
	System.Int32 zMapOffset; // 0x18
	System.Int32 gridSize; // 0x1c
	System.Void InitGrid(System.Int32 xMapOffset, System.Int32 zMapOffset, System.Int32 gridSize); // 0x06a8e224
	System.ValueTuple<System.Int32,System.Int32> GetGridByPos(System.Single posX, System.Single posZ); // 0x06a8e2bc
	System.Void .ctor(); // 0x06a8e3b0
	static System.Void .cctor(); // 0x06a8e418
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.PreviewBg : System.Object
{
	SocLogger logger; // 0x10
	UnityEngine.GameObject <GoPreviewBg>k__BackingField; // 0x18
	UnityEngine.Transform <TrCamera>k__BackingField; // 0x20
	UnityEngine.Transform <TrModelHolder>k__BackingField; // 0x28
	UnityEngine.Camera <PreviewCamera>k__BackingField; // 0x30
	UnityEngine.Camera <CustomMainCamera>k__BackingField; // 0x38
	Effect.EffectItemHandle<Effect.EffectItem> effectItemHandle; // 0x40
	System.Int32 bgPrefabId; // 0x50
	System.UInt64 asyncId; // 0x58
	System.Boolean RemovePoolOnDispose; // 0x60
	System.Action<UnityEngine.GameObject> ActionBgLoadComplete; // 0x68
	UnityEngine.GameObject get_GoPreviewBg(); // 0x06a8e4ec
	System.Void set_GoPreviewBg(UnityEngine.GameObject value); // 0x06a8e550
	UnityEngine.Transform get_TrCamera(); // 0x06a8e5d0
	System.Void set_TrCamera(UnityEngine.Transform value); // 0x06a8e634
	UnityEngine.Transform get_TrModelHolder(); // 0x06a8e6b4
	System.Void set_TrModelHolder(UnityEngine.Transform value); // 0x06a8e718
	UnityEngine.Camera get_PreviewCamera(); // 0x06a8e798
	System.Void set_PreviewCamera(UnityEngine.Camera value); // 0x06a8e7fc
	UnityEngine.Camera get_CustomMainCamera(); // 0x06a8e87c
	System.Void set_CustomMainCamera(UnityEngine.Camera value); // 0x06a8e8e0
	System.Void InstanceBgPrefab(System.Int32 bgPrefabId, UnityEngine.Vector3 position, UnityEngine.Vector3 eulerAngles, UnityEngine.Transform trParent, System.Boolean isAsync); // 0x06a8e960
	System.Void Init(System.Int32 bgPrefabId, UnityEngine.Vector3 position, UnityEngine.Vector3 eulerAngles, UnityEngine.GameObject goBg, UnityEngine.Transform trParent); // 0x06a8ef18
	System.Void Dispose(); // 0x06a90520
	System.Void Show(); // 0x06a90a9c
	System.Void Hide(); // 0x06a90b5c
	System.Void SetBgLayer(); // 0x06a8f830
	System.Void SetPreviewModel(WizardGames.Soc.SocClient.Manager.PreviewModel previewModel); // 0x06a90c1c
	System.Void InstanceFx(System.Int32 fxId); // 0x06a90374
	System.Void SetCameraParams(); // 0x06a8faa8
	System.Void SetCameraLayerCullDistances(); // 0x06a900c0
	System.Void SetCameraToSceneCamera(); // 0x06a90f8c
	System.Void SetCameraCullingMask(); // 0x06a90274
	UnityEngine.Camera GetSceneCamera(); // 0x06a911fc
	System.Void .ctor(); // 0x06a913fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.PreviewBg.<>c__DisplayClass26_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.PreviewBg <>4__this; // 0x10
	System.Int32 bgPrefabId; // 0x18
	UnityEngine.Vector3 position; // 0x1c
	UnityEngine.Vector3 eulerAngles; // 0x28
	UnityEngine.Transform trParent; // 0x38
	System.Void .ctor(); // 0x06a8eeb0
	System.Void <InstanceBgPrefab>b__0(UnityEngine.GameObject goBg, System.Object[] objs); // 0x06a914fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.PreviewModel : System.Object
{
	UnityEngine.GameObject <GoModel>k__BackingField; // 0x10
	System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Collections.Generic.Dictionary<UnityEngine.Renderer,WizardGames.Soc.SocClient.Manager.PreviewModel.RendererInfo>> rendererInfos; // 0x18
	UnityEngine.GameObject get_GoModel(); // 0x06a91670
	System.Void set_GoModel(UnityEngine.GameObject value); // 0x06a916d4
	System.Void SetGoModel(UnityEngine.GameObject goModel, System.Boolean isSetLayer); // 0x06a91754
	System.Void Dispose(); // 0x06a91d0c
	System.Void SetGoLayer(UnityEngine.GameObject go, System.Int32 layer, System.Boolean includeInactive); // 0x06a91864
	System.Void ResetGoLayer(UnityEngine.GameObject go, System.Boolean includeInactive); // 0x06a91e48
	System.Void UpdateGoLayer(); // 0x06a9220c
	System.Void .ctor(); // 0x06a923c8
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Manager.PreviewModel.RendererInfo : System.ValueType
{
	System.Int32 layer; // 0x10
	System.UInt32 renderingLayer; // 0x14
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.PreviewScene : System.Object
{
	System.Boolean <IsInitBg>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Manager.PreviewBg previewBg; // 0x18
	WizardGames.Soc.SocClient.Manager.PreviewModel previewModel; // 0x20
	WizardGames.Soc.SocClient.Manager.PreviewBg previewBgNew; // 0x28
	WizardGames.Soc.SocClient.Manager.PreviewModel previewModelNew; // 0x30
	WizardGames.Soc.SocClient.Manager.EPreviewType previewType; // 0x38
	System.Action<UnityEngine.GameObject> ActionInitBgLoadComplete; // 0x40
	System.Action<UnityEngine.GameObject> ActionChangeBgLoadComplete; // 0x48
	WizardGames.Soc.SocClient.Manager.RotateModeBase rotateModeBase; // 0x50
	System.Func<System.Boolean> modelRotateCondition; // 0x58
	System.Boolean get_IsInitBg(); // 0x06a92430
	System.Void set_IsInitBg(System.Boolean value); // 0x06a92494
	System.Void .ctor(WizardGames.Soc.SocClient.Manager.EPreviewType previewType); // 0x06a92510
	System.Void InitPreviewScene(System.Int32 bgPrefabId, UnityEngine.Vector3 bgPos, UnityEngine.Vector3 bgEuler, UnityEngine.Transform trPreviewRoot, UnityEngine.GameObject goModel, WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase, System.Boolean isAsync); // 0x06a92750
	System.Void ChangePreviewScene(System.Int32 bgPrefabIdNew, UnityEngine.GameObject goModel, UnityEngine.Transform trPreviewRoot, UnityEngine.Vector3 bgPos, UnityEngine.Vector3 bgEuler, System.Boolean isAsync); // 0x06a9299c
	System.Void CancelChangePreviewScene(); // 0x06a92c50
	System.Void DisposePreviewScene(WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase); // 0x06a92cf4
	System.Void ResetPreviewModel(UnityEngine.GameObject goModel); // 0x06a9316c
	System.Void UpdateGoLayer(); // 0x06a9327c
	System.Void Show(WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase); // 0x06a932e8
	System.Void Hide(WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase); // 0x06a9347c
	System.Void DisableSceneCamRender(WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase); // 0x06a93380
	System.Void RecoverSceneCamRender(WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase); // 0x06a92eb0
	System.Void EnableModelRotate(FairyGUI.GObject touchArea, WizardGames.Soc.SocClient.Manager.RotateModeBase rotateModeBase, System.Func<System.Boolean> condition); // 0x06a93514
	System.Void ResetRotate(); // 0x06a937c4
	System.Void OnItemTouchBegin(FairyGUI.EventContext context); // 0x06a93838
	System.Void OnItemTouchMove(FairyGUI.EventContext context); // 0x06a9394c
	System.Void OnItemTouchEnd(FairyGUI.EventContext context); // 0x06a93a40
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.PreviewScene.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.PreviewScene <>4__this; // 0x10
	UnityEngine.GameObject goModel; // 0x18
	WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase; // 0x20
	System.Void .ctor(); // 0x06a92934
	System.Void <InitPreviewScene>b__0(UnityEngine.GameObject goBg); // 0x06a93b34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.PreviewScene.<>c__DisplayClass13_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.PreviewScene <>4__this; // 0x10
	UnityEngine.GameObject goModel; // 0x18
	System.Void .ctor(); // 0x06a92be8
	System.Void <ChangePreviewScene>b__0(UnityEngine.GameObject goBg); // 0x06a93d1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.RotateModeBase : System.Object
{
	WizardGames.Soc.SocClient.Manager.RotateModeBaseParams baseParams; // 0x10
	UnityEngine.GameObject goModel; // 0x18
	UnityEngine.Vector2 touchStartPos; // 0x20
	UnityEngine.Vector3 goModelDefaultLocalEulerAngles; // 0x28
	UnityEngine.Vector3 currentEuler; // 0x34
	System.Single get_resetRotateDuration(); // 0x06a93efc
	System.Single get_slideSensitiven(); // 0x06a93fe4
	System.Void SetRotateModelParams(WizardGames.Soc.SocClient.Manager.RotateModeBaseParams baseParams); // 0x06a940cc
	System.Void Dispose(); // 0x06a9414c
	System.Void Init(UnityEngine.GameObject goModel); // 0x06a941e4
	System.Void ResetRotate(); // 0x06a9434c
	System.Void OnItemTouchBegin(FairyGUI.EventContext context); // 0x06a94404
	System.Void OnItemTouchMove(FairyGUI.EventContext context); // 0x06a94514
	System.Void OnItemTouchEnd(FairyGUI.EventContext context); // 0x06a948b0
	System.Void SetRotate(UnityEngine.Vector3 euler); // 0x06a94b7c
	System.Void .ctor(); // 0x06a94cc8
	System.Void <OnItemTouchEnd>b__15_1(System.Single progress); // 0x06a94da8
	System.Void <OnItemTouchEnd>b__15_2(); // 0x06a94ee8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.RotateModeBase.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Manager.RotateModeBase.<>c <>9; // 0x0
	static DG.Tweening.Core.DOGetter<System.Single> <>9__15_0; // 0x8
	static System.Void .cctor(); // 0x06a94fa0
	System.Void .ctor(); // 0x06a95004
	System.Single <OnItemTouchEnd>b__15_0(); // 0x06a9506c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.ERotateMode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.ERotateMode None = 0;
	static WizardGames.Soc.SocClient.Manager.ERotateMode Horizontal = 1;
	static WizardGames.Soc.SocClient.Manager.ERotateMode Vertical = 2;
	static WizardGames.Soc.SocClient.Manager.ERotateMode All = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.RotateModeBaseParams : System.Object
{
	WizardGames.Soc.SocClient.Manager.ERotateMode rotateMode; // 0x10
	UnityEngine.Space space; // 0x14
	System.Void .ctor(WizardGames.Soc.SocClient.Manager.ERotateMode rotateMode, UnityEngine.Space space); // 0x06a950d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.RotateModeConstraintAngle : WizardGames.Soc.SocClient.Manager.RotateModeBase
{
	System.Single minHorizontalAngle; // 0x40
	System.Single maxHorizontalAngle; // 0x44
	System.Single minVerticalAngle; // 0x48
	System.Single maxVerticalAngle; // 0x4c
	WizardGames.Soc.SocClient.Manager.RotateModeConstraintAngleParams get_constraintAngleParams(); // 0x06a95164
	System.Void Init(UnityEngine.GameObject goModel); // 0x06a95214
	System.Void OnItemTouchMove(FairyGUI.EventContext context); // 0x06a95314
	System.Void .ctor(); // 0x06a95710
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.RotateModeConstraintAngleParams : WizardGames.Soc.SocClient.Manager.RotateModeBaseParams
{
	System.Single horizontalAngleOffset; // 0x18
	System.Single verticalAngleOffset; // 0x1c
	System.Void .ctor(WizardGames.Soc.SocClient.Manager.ERotateMode rotateMode, System.Single horizontalAngleOffset, System.Single verticalAngleOffset, UnityEngine.Space space); // 0x06a95774
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.PreviewSceneCutDirector : System.Object
{
	WizardGames.Soc.SocClient.Manager.TrackAnimBase trackAnim; // 0x10
	System.Int32 <previewConfigId>k__BackingField; // 0x18
	System.Boolean isPlayingAnim; // 0x1c
	System.Boolean isCutEnd; // 0x1d
	WizardGames.Soc.SocClient.Manager.PreviewScene previewScene; // 0x20
	System.Action<UnityEngine.GameObject> ActionInitBgLoadComplete; // 0x28
	System.Action<UnityEngine.GameObject> ActionChangeBgLoadComplete; // 0x30
	System.Int64 timerID; // 0x38
	System.Boolean isPostProcessEffect; // 0x40
	SOC.TA.PostProcessEffectController postProcessEffectController; // 0x48
	UnityEngine.AzureSky.AzureWeatherPresetEnum defaultTODEnum; // 0x50
	UnityEngine.AzureSky.AzureWeatherPresetEnum curModelTODEnum; // 0x54
	UnityEngine.AzureSky.AzureWeatherPresetEnum preModelTODEnum; // 0x58
	System.UInt64 fxAsyncId; // 0x60
	UnityEngine.GameObject goFx; // 0x68
	System.Int64 timerId; // 0x70
	System.Int32 get_previewConfigId(); // 0x06a95820
	System.Void set_previewConfigId(System.Int32 value); // 0x06a95884
	System.Void .ctor(); // 0x06a958fc
	System.Void InitPreviewScene(WizardGames.Soc.SocClient.Manager.EPreviewType previewType, System.Int32 previewConfigId, UnityEngine.Vector3 bgPos, UnityEngine.Vector3 bgEuler, WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase, UnityEngine.GameObject goModel, System.Boolean isAnim, System.Boolean isPostProcessEffect, System.Boolean isAsync); // 0x06a95aac
	System.Void ChangePreviewScene(WizardGames.Soc.SocClient.Manager.EPreviewType previewType, System.Int32 previewConfigIdNew, UnityEngine.GameObject goModel, UnityEngine.Vector3 bgPos, UnityEngine.Vector3 bgEuler, System.Boolean isAsync); // 0x06a965a4
	System.Void CancelChangePreviewScene(WizardGames.Soc.SocClient.Manager.EPreviewType previewType); // 0x06a96a74
	System.Void DisposePreviewScene(WizardGames.Soc.SocClient.Manager.EPreviewType previewType, WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase); // 0x06a96c90
	System.Void Show(WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase); // 0x06a97670
	System.Void Hide(WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase); // 0x06a97700
	System.Void EnableModelRotate(WizardGames.Soc.SocClient.Manager.EPreviewType previewType, FairyGUI.GObject touchArea, WizardGames.Soc.SocClient.Manager.RotateModeBase rotateModeBase); // 0x06a97790
	System.Void PlayTrack(System.Int32 track, System.Boolean isAnim, System.Action onAnimCompleted, System.Boolean isCheckCutEnd); // 0x06a979c4
	WizardGames.Soc.SocClient.Manager.TrackAnimParamsBase GetPlayTrackParms(System.Int32 track, System.Boolean isAnim); // 0x06a97c1c
	System.Int32 get_delayTime(); // 0x06a983b4
	System.Single get_postProcessEffectTime(); // 0x06a9849c
	System.Void StartPlayCut(System.Boolean isAnim); // 0x06a98584
	System.Void CancelTimer(); // 0x06a96e88
	System.Void GetCurWeather(); // 0x06a95ed0
	System.Void RegisterWeather(); // 0x06a98934
	System.Void UnregisterWeather(); // 0x06a9712c
	System.Void InstantiateUIFx(FairyGUI.GoWrapper goWrapper); // 0x06a98bc8
	System.Void DestroyUIFx(); // 0x06a97288
	System.Void <ChangePreviewScene>b__12_0(UnityEngine.GameObject goBg); // 0x06a98e7c
	System.Boolean <EnableModelRotate>b__17_0(); // 0x06a98f28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.PreviewSceneCutDirector.<>c__DisplayClass11_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.PreviewSceneCutDirector <>4__this; // 0x10
	WizardGames.Soc.SocClient.Manager.EPreviewType previewType; // 0x18
	System.Boolean isAnim; // 0x1c
	System.Void .ctor(); // 0x06a95e68
	System.Void <InitPreviewScene>b__0(UnityEngine.GameObject goBg, UnityEngine.GameObject model); // 0x06a98fa4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.PreviewSceneCutDirector.<>c__DisplayClass18_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.PreviewSceneCutDirector <>4__this; // 0x10
	System.Action onAnimCompleted; // 0x18
	System.Void .ctor(); // 0x06a97bb4
	System.Void <PlayTrack>b__0(); // 0x06a991c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.PreviewSceneCutDirector.<>c__DisplayClass27_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.PreviewSceneCutDirector <>4__this; // 0x10
	System.Boolean isAnim; // 0x18
	System.Action <>9__2; // 0x20
	System.Void .ctor(); // 0x06a988cc
	System.Void <StartPlayCut>b__0(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x06a9924c
	System.Void <StartPlayCut>b__2(); // 0x06a99360
	System.Void <StartPlayCut>b__1(); // 0x06a993d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.PreviewSceneCutDirector.<>c__DisplayClass38_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.PreviewSceneCutDirector <>4__this; // 0x10
	FairyGUI.GoWrapper goWrapper; // 0x18
	WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__1; // 0x20
	System.Void .ctor(); // 0x06a98e14
	System.Void <InstantiateUIFx>b__0(UnityEngine.GameObject go, System.Object[] objs); // 0x06a99448
	System.Void <InstantiateUIFx>b__1(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x06a99728
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.RotateModeConstructionAndPlayer : WizardGames.Soc.SocClient.Manager.RotateModeBase
{
	
	System.Void Init(UnityEngine.GameObject goModel); // 0x06a997c4
	System.Void OnItemTouchEnd(FairyGUI.EventContext context); // 0x06a9994c
	System.Void .ctor(); // 0x06a999c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.TrackAnimBase : System.Object
{
	WizardGames.Soc.SocClient.Manager.TrackAnimParamsBase trackAnimParams; // 0x10
	System.Void SetTrackParams(WizardGames.Soc.SocClient.Manager.TrackAnimParamsBase trackAnimParams); // 0x06a99a24
	System.Void PlayTrack(System.Action onAnimCompleted); // 0x06a99aa4
	System.Void Dispose(); // 0x06a99d24
	System.Void .ctor(); // 0x06a99d90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.TrackAnimBase.<>c__DisplayClass2_0 : System.Object
{
	System.Action onAnimCompleted; // 0x10
	System.Void .ctor(); // 0x06a99cbc
	System.Void <PlayTrack>b__0(); // 0x06a99df8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.TrackAnimImmediate : WizardGames.Soc.SocClient.Manager.TrackAnimBase
{
	
	System.Void PlayTrack(System.Action onAnimCompleted); // 0x06a99e70
	System.Void .ctor(); // 0x06a95a48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.TrackAnimPan : WizardGames.Soc.SocClient.Manager.TrackAnimBase
{
	
	WizardGames.Soc.SocClient.Manager.TrackAnimParamsPan get_trackAnimParamsPan(); // 0x06a99f6c
	System.Void PlayTrack(System.Action onAnimCompleted); // 0x06a9a01c
	System.Void .ctor(); // 0x06a959e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.TrackAnimPan.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Manager.TrackAnimPan.<>c <>9; // 0x0
	static DG.Tweening.Core.DOGetter<System.Single> <>9__2_0; // 0x8
	static System.Void .cctor(); // 0x06a9a5d8
	System.Void .ctor(); // 0x06a9a63c
	System.Single <PlayTrack>b__2_0(); // 0x06a9a6a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.TrackAnimPan.<>c__DisplayClass2_0 : System.Object
{
	UnityEngine.Vector3 eulerStart; // 0x10
	UnityEngine.Vector3 eulerEnd; // 0x1c
	UnityEngine.Vector3 dirStart; // 0x28
	UnityEngine.Vector3 dirEnd; // 0x34
	WizardGames.Soc.SocClient.Manager.TrackAnimPan <>4__this; // 0x40
	UnityEngine.Quaternion startRot; // 0x48
	UnityEngine.Quaternion endRot; // 0x58
	System.Single startFov; // 0x68
	System.Action onAnimCompleted; // 0x70
	System.Void .ctor(); // 0x06a9a570
	System.Void <PlayTrack>b__1(System.Single progress); // 0x06a9a708
	System.Void <PlayTrack>b__2(); // 0x06a9addc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.TrackAnimParamsBase : System.Object
{
	UnityEngine.Transform trCamera; // 0x10
	UnityEngine.Camera cameraPreview; // 0x18
	System.Single duration; // 0x20
	DG.Tweening.Ease ease; // 0x24
	UnityEngine.Vector3 configPos; // 0x28
	UnityEngine.Vector3 configRot; // 0x34
	System.Single configFov; // 0x40
	System.Boolean isUseFov; // 0x44
	System.Void .ctor(UnityEngine.Transform trCamera, System.Single duration, DG.Tweening.Ease ease, UnityEngine.Vector3 configPos, UnityEngine.Vector3 configRot, System.Single configFov, System.Boolean isUseFov); // 0x06a98240
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.TrackAnimParamsPan : WizardGames.Soc.SocClient.Manager.TrackAnimParamsBase
{
	UnityEngine.Transform trBg; // 0x48
	System.Void .ctor(UnityEngine.Transform trBg, UnityEngine.Transform trCamera, System.Single duration, DG.Tweening.Ease ease, UnityEngine.Vector3 configPos, UnityEngine.Vector3 configRot, System.Single configFov, System.Boolean isUseFov); // 0x06a980f8
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.EPreviewType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.EPreviewType Base = 0;
	static WizardGames.Soc.SocClient.Manager.EPreviewType Construction = 1;
	static WizardGames.Soc.SocClient.Manager.EPreviewType ConstructionResearch = 2;
	static WizardGames.Soc.SocClient.Manager.EPreviewType ConstructionRecycler = 3;
	static WizardGames.Soc.SocClient.Manager.EPreviewType CreateRole = 4;
	static WizardGames.Soc.SocClient.Manager.EPreviewType MallTimeline = 5;
	static WizardGames.Soc.SocClient.Manager.EPreviewType MallModel = 6;
	static WizardGames.Soc.SocClient.Manager.EPreviewType GameTeamModel = 7;
	static WizardGames.Soc.SocClient.Manager.EPreviewType Item = 8;
	static WizardGames.Soc.SocClient.Manager.EPreviewType LobbyItem = 9;
	static WizardGames.Soc.SocClient.Manager.EPreviewType LobbyPlayer = 10;
	static WizardGames.Soc.SocClient.Manager.EPreviewType FpPlayer = 11;
	static WizardGames.Soc.SocClient.Manager.EPreviewType PreviewItem = 12;
	static WizardGames.Soc.SocClient.Manager.EPreviewType PreviewPlayer = 13;
	static WizardGames.Soc.SocClient.Manager.EPreviewType PreviewFpPlayer = 14;
	static WizardGames.Soc.SocClient.Manager.EPreviewType SkinReward = 15;
	static WizardGames.Soc.SocClient.Manager.EPreviewType ConstructionAndPlayer = 16;
	static WizardGames.Soc.SocClient.Manager.EPreviewType LobbyWeaponItem = 17;
	static WizardGames.Soc.SocClient.Manager.EPreviewType PreviewWeaponItem = 18;
	static WizardGames.Soc.SocClient.Manager.EPreviewType Plant = 19;
	static WizardGames.Soc.SocClient.Manager.EPreviewType Season = 20;
	static WizardGames.Soc.SocClient.Manager.EPreviewType NewGetLobbyPlayer = 21;
	static WizardGames.Soc.SocClient.Manager.EPreviewType NewGetLobbyWeaponItem = 22;
	static WizardGames.Soc.SocClient.Manager.EPreviewType NewGetLobbyItem = 23;
	static WizardGames.Soc.SocClient.Manager.EPreviewType NewGetLobbyHangings = 24;
	static WizardGames.Soc.SocClient.Manager.EPreviewType NewGetLobbyEquipment = 25;
	static WizardGames.Soc.SocClient.Manager.EPreviewType ColorSkinItem = 26;
	static WizardGames.Soc.SocClient.Manager.EPreviewType ColorSkinWeapon = 27;
	static WizardGames.Soc.SocClient.Manager.EPreviewType ColorSkinPlayer = 28;
	static WizardGames.Soc.SocClient.Manager.EPreviewType LiftingPlatform = 29;
	static WizardGames.Soc.SocClient.Manager.EPreviewType SeasonRankPlayer = 30;
	static WizardGames.Soc.SocClient.Manager.EPreviewType Sleep = 31;
	static WizardGames.Soc.SocClient.Manager.EPreviewType Union = 32;
	static WizardGames.Soc.SocClient.Manager.EPreviewType SouDJRank = 33;
	static WizardGames.Soc.SocClient.Manager.EPreviewType PcInventory = 34;
	static WizardGames.Soc.SocClient.Manager.EPreviewType PlayerHome = 35;
	static WizardGames.Soc.SocClient.Manager.EPreviewType Test = 36;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.ELightType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.ELightType None = 0;
	static WizardGames.Soc.SocClient.Manager.ELightType Day = 1;
	static WizardGames.Soc.SocClient.Manager.ELightType Night = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrPreviewSceneManager : WizardGames.Soc.Common.Manager.MgrBase
{
	SocLogger logger; // 0x18
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Manager.EPreviewType,WizardGames.Soc.SocClient.Manager.PreviewScene> previewSceneDic; // 0x20
	UnityEngine.Vector2Int shadowCascadeCache; // 0x28
	System.Void Destroy(); // 0x06a9ae54
	System.Void Register(WizardGames.Soc.SocClient.Manager.EPreviewType previewType, WizardGames.Soc.SocClient.Manager.PreviewScene previewScene); // 0x06a9263c
	System.Void UnRegister(WizardGames.Soc.SocClient.Manager.EPreviewType previewType); // 0x06a93038
	WizardGames.Soc.SocClient.Manager.PreviewScene GetPreviewScene(WizardGames.Soc.SocClient.Manager.EPreviewType previewType); // 0x06a990e8
	WizardGames.Soc.SocClient.Manager.PreviewScene EnablePreviewScene(WizardGames.Soc.SocClient.Manager.EPreviewType previewType, System.Int32 bgPrefabId, UnityEngine.GameObject goModel, UnityEngine.Vector3 bgPos, UnityEngine.Vector3 bgEuler, System.Action<UnityEngine.GameObject,UnityEngine.GameObject> actionAllLoadComplete, System.Boolean isAsync, UnityEngine.Camera previewCam, UnityEngine.Camera customMainCamera, WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase); // 0x06a96014
	System.Void ChangePreviewScene(WizardGames.Soc.SocClient.Manager.EPreviewType previewType, System.Int32 bgPrefabIdNew, UnityEngine.GameObject goModel, UnityEngine.Vector3 bgPos, UnityEngine.Vector3 bgEuler, System.Action<UnityEngine.GameObject> actionBgLoadComplete, System.Boolean isAsync); // 0x06a96824
	System.Void CancelChangePreviewScene(WizardGames.Soc.SocClient.Manager.EPreviewType previewType); // 0x06a96b24
	System.Void DisablePreviewScene(WizardGames.Soc.SocClient.Manager.EPreviewType previewType, WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase); // 0x06a96f8c
	System.Void UpdateGoLayer(WizardGames.Soc.SocClient.Manager.EPreviewType previewType); // 0x06a9b5d0
	System.Void EnableModelRotate(WizardGames.Soc.SocClient.Manager.EPreviewType previewType, FairyGUI.GObject touchArea, WizardGames.Soc.SocClient.Manager.RotateModeBase rotateModeBase, System.Func<System.Boolean> condition); // 0x06a978b0
	System.Void ResetModelRotate(WizardGames.Soc.SocClient.Manager.EPreviewType previewType); // 0x06a9b6b0
	System.Void SwitchLight(WizardGames.Soc.SocClient.Manager.EPreviewType modelType, WizardGames.Soc.SocClient.Manager.ELightType lightType); // 0x06a9b790
	System.Void CacheCurShadowCascadeCountAndSetTo1(); // 0x06a9afe4
	System.Boolean TrySetCurShadowCascadeCount(System.Int32 rendererIndex, System.Int32 cascadeCount); // 0x06a9baf4
	System.Void RecoverCurShadowCascadeCount(); // 0x06a9b250
	System.Void .ctor(); // 0x06a9bdf8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrPreviewSceneManager.<>c__DisplayClass7_0 : System.Object
{
	System.Action<UnityEngine.GameObject,UnityEngine.GameObject> actionAllLoadComplete; // 0x10
	UnityEngine.GameObject goModel; // 0x18
	System.Void .ctor(); // 0x06a9b31c
	System.Void <EnablePreviewScene>b__0(UnityEngine.GameObject goBg); // 0x06a9bf80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.UiConstructionPreviewSceneController : System.Object
{
	static SocLogger <Logger>k__BackingField; // 0x0
	WizardGames.Soc.SocClient.Manager.PreviewSceneCutDirector cutDirector; // 0x10
	System.Boolean isActiveChangeByStatck; // 0x18
	System.Boolean isInitPreviewScene; // 0x19
	System.Boolean isPlayer; // 0x1a
	FairyGUI.GoWrapper fxWrapper; // 0x20
	WizardGames.Soc.SocClient.Manager.ConstructionPreviewModelFactory constructionPreviewModelFactoryCur; // 0x28
	WizardGames.Soc.SocClient.Manager.ConstructionPreviewModelFactory constructionPreviewModelFactoryNew; // 0x30
	System.Action<UnityEngine.GameObject,UnityEngine.GameObject> ActionInitAllLoadComplete; // 0x38
	System.Action<UnityEngine.GameObject,UnityEngine.GameObject> ActionChangeAllLoadComplete; // 0x40
	System.Action ActionDisposeComplete; // 0x48
	System.Collections.Generic.Dictionary<System.Int32,UnityEngine.GameObject> bgMapId2GoDic; // 0x50
	WizardGames.Soc.SocClient.GoLoader.DisplayModel displayModel; // 0x58
	static SocLogger get_Logger(); // 0x06a9c020
	System.Void .ctor(); // 0x06a9c0a8
	System.Void Finalize(); // 0x06a9c194
	System.Void OnHideByLayerStack(); // 0x06a9c2b4
	System.Void OnShowByLayerStack(); // 0x06a9c31c
	System.Void InitPreviewScene(System.Int64 entityId, WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase, FairyGUI.GGraph gFx, System.Boolean isPlayer, WizardGames.Soc.SocClient.Manager.EPreviewType previewType, System.Boolean isFromDetailList); // 0x06a9c384
	System.Void ChangePreviewScene(System.Int64 entityId, WizardGames.Soc.SocClient.Manager.EPreviewType previewType); // 0x06a9ccf0
	System.Void DisposePreviewScene(WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase, WizardGames.Soc.SocClient.Manager.EPreviewType previewType, System.Boolean isForceDispose, System.Boolean isHidePreviewScene); // 0x06a9d238
	System.Void EnableModelRotate(FairyGUI.GLoader rotate, WizardGames.Soc.SocClient.Manager.EPreviewType previewType); // 0x06a9d520
	System.Void PlayTrack(System.Int32 track); // 0x06a9d668
	System.Void InstantiateUIFx(FairyGUI.GGraph gFx); // 0x06a9d704
	System.Void RefreshBgMap(UnityEngine.GameObject goBg); // 0x06a9d7e8
	System.Void InitPlayerModel(UnityEngine.GameObject goPreviewBg); // 0x06a9dc00
	System.Void RefreshCharacterGo(); // 0x06a9e130
	System.Void DisposeDisplayModel(); // 0x06a9d394
	static System.Void .cctor(); // 0x06a9e294
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.UiConstructionPreviewSceneController.<>c__DisplayClass20_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.UiConstructionPreviewSceneController <>4__this; // 0x10
	FairyGUI.GGraph gFx; // 0x18
	System.Boolean isFromDetailList; // 0x20
	System.Boolean isPlayer; // 0x21
	WizardGames.Soc.SocClient.Manager.EPreviewType previewType; // 0x24
	WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase; // 0x28
	System.Int32 configId; // 0x30
	System.Void .ctor(); // 0x06a9c690
	System.Void <InitPreviewScene>b__0(UnityEngine.GameObject goModel); // 0x06a9e368
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.UiConstructionPreviewSceneController.<>c__DisplayClass20_1 : System.Object
{
	UnityEngine.GameObject goModel; // 0x10
	WizardGames.Soc.SocClient.Manager.UiConstructionPreviewSceneController.<>c__DisplayClass20_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x06a9e590
	System.Void <InitPreviewScene>b__1(UnityEngine.GameObject goBg); // 0x06a9e5f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.UiConstructionPreviewSceneController.<>c__DisplayClass21_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.UiConstructionPreviewSceneController <>4__this; // 0x10
	WizardGames.Soc.SocClient.Manager.EPreviewType previewType; // 0x18
	System.Int32 previewConfigIdTemp; // 0x1c
	System.Void .ctor(); // 0x06a9cedc
	System.Void <ChangePreviewScene>b__0(UnityEngine.GameObject goModel); // 0x06a9e6e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.UiConstructionPreviewSceneController.<>c__DisplayClass21_1 : System.Object
{
	UnityEngine.GameObject goModel; // 0x10
	WizardGames.Soc.SocClient.Manager.UiConstructionPreviewSceneController.<>c__DisplayClass21_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x06a9e890
	System.Void <ChangePreviewScene>b__1(UnityEngine.GameObject goBg); // 0x06a9e8f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.ConstructionPreviewModelFactory : System.Object
{
	UnityEngine.GameObject <GoModel>k__BackingField; // 0x10
	System.String modelPath; // 0x18
	System.UInt64 asyncId; // 0x20
	System.Action<UnityEngine.GameObject> ActionModelComplete; // 0x28
	UnityEngine.GameObject get_GoModel(); // 0x06a9eb28
	System.Void set_GoModel(UnityEngine.GameObject value); // 0x06a9eb8c
	System.Void InitModel(System.Int64 templateId, System.Int64 skinId, System.Int32& previewConfigId, System.Boolean isAsync); // 0x06a9c8bc
	System.Int32 GetPreviewConfigId(System.Int64 templateId, System.Int64 skinId, System.Boolean& isDefaultSkin); // 0x06a9ec74
	System.String GetPath(System.Boolean isDefaultSkin, WizardGames.Soc.Common.Data.DataItem.CameraPreviewConfig cameraPreviewConfig); // 0x06a9ed38
	System.Void Dispose(); // 0x06a9cf44
	System.Void Clear(); // 0x06a9f124
	System.Void CopyFrom(WizardGames.Soc.SocClient.Manager.ConstructionPreviewModelFactory temp); // 0x06a9e9e4
	System.Void .ctor(); // 0x06a9c79c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.ConstructionPreviewModelFactory.<>c__DisplayClass7_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.ConstructionPreviewModelFactory <>4__this; // 0x10
	WizardGames.Soc.Common.Data.DataItem.CameraPreviewConfig cameraPreviewConfig; // 0x18
	System.Void .ctor(); // 0x06a9ec0c
	System.Void <InitModel>b__0(UnityEngine.GameObject go, System.Object[] objs); // 0x06a9f210
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.PreviewSceneUtil : System.Object
{
	static System.Boolean IsPostProcessEnable; // 0x0
	static UnityEngine.GameObject goPreviewRoot; // 0x8
	static UnityEngine.Transform get_TrPreviewRoot(); // 0x06a9b384
	static System.Boolean HavePreviewConfig(System.Int64 templateId, System.Int64 skinId); // 0x06a9c6f8
	static System.Int32 GetPreviewConfigId(System.Int64 templateId, System.Int64 skinId); // 0x06a9ee58
	static System.Void PreHideLayersForHideBelowOptLevel(WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase, System.Int32 exceptLayer); // 0x06a9c804
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrConstructionReport : WizardGames.Soc.Common.Manager.MgrBase
{
	UnityEngine.Texture2D tex2D; // 0x18
	System.Void Init(); // 0x06a9f460
	System.Void CleanUp(); // 0x06a9f5b8
	System.Void OnConstructionReportPhotoModeEntered(); // 0x06a9f720
	System.Void OnConstructionReportPhotoModeExited(); // 0x06a9f800
	System.Void TakeShot(System.Action<UnityEngine.Texture2D> completeAction); // 0x06a9f95c
	System.Collections.IEnumerator StartCapturePic(System.Action<UnityEngine.Texture2D> completeAction); // 0x06a9fad4
	System.Void CapturePic(); // 0x06a9fc20
	System.Boolean DetectionConstruction(WizardGames.Soc.Common.Entity.PartEntity& partEntity, UnityEngine.Vector3& outsidePos, System.Int64& outsideEntityId, System.Boolean isShowTips); // 0x06a9fd7c
	System.Void .ctor(); // 0x06aa0350
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrConstructionReport.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Manager.MgrConstructionReport.<>c <>9; // 0x0
	static System.Comparison<UnityEngine.RaycastHit> <>9__8_0; // 0x8
	static System.Void .cctor(); // 0x06aa03b8
	System.Void .ctor(); // 0x06aa041c
	System.Int32 <DetectionConstruction>b__8_0(UnityEngine.RaycastHit a, UnityEngine.RaycastHit b); // 0x06aa0484
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrConstructionReport.<StartCapturePic>d__6 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Manager.MgrConstructionReport <>4__this; // 0x20
	System.Action<UnityEngine.Texture2D> completeAction; // 0x28
	System.Void .ctor(System.Int32 <>1__state); // 0x06a9fb9c
	System.Void System.IDisposable.Dispose(); // 0x06aa0548
	System.Boolean MoveNext(); // 0x06aa05a8
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x06aa06e4
	System.Void System.Collections.IEnumerator.Reset(); // 0x06aa0748
	System.Object System.Collections.IEnumerator.get_Current(); // 0x06aa07d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrDig : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Log; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.DigEntity> allDigEntities; // 0x18
	System.Void Init(); // 0x06aa0834
	System.Threading.Tasks.Task OnExitWorld(); // 0x06aa0a38
	System.Void OnCreateEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06aa0c6c
	System.Void OnRemoveEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06aa0e60
	System.Void .ctor(); // 0x06aa0ffc
	static System.Void .cctor(); // 0x06aa10b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrElevator : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.ElevatorEntity>> ElevatorEntityDic; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.ElevatorEntity>> TerrainElevatorEntityDic; // 0x20
	System.Int64 callFailureCb; // 0x28
	System.Int32 callFailureIdx; // 0x30
	System.Int32[] callFailureTips; // 0x38
	System.Void Init(); // 0x06aa1188
	System.Threading.Tasks.Task OnExitWorld(); // 0x06aa138c
	System.Void OnCreateEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06aa15bc
	System.Void OnRemoveEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06aa1ab4
	System.Void ElevatorTips(System.Int32 tipsId, System.Boolean fail); // 0x06aa1de8
	System.Void CallFailureCb(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x06aa2168
	System.Void .ctor(); // 0x06aa220c
	static System.Void .cctor(); // 0x06aa2448
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrGuideLine : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	static System.Single defaultRectWidth; // 0x8
	static System.Single defaultRectHeight; // 0xc
	static System.Int32 targetType0; // 0x10
	static System.Int32 targetType1; // 0x14
	System.Int32 curGuideLineId; // 0x14
	Effect.EffectItemHandle<Effect.EffectItem> guideLineTargetEffectItemHandle; // 0x18
	UnityEngine.GameObject guideLineGo; // 0x28
	GuideLines guideLine; // 0x30
	System.Collections.Generic.List<UnityEngine.Vector3> m_targetPoss; // 0x38
	System.Collections.Generic.List<UnityEngine.Rect> guideLineRects; // 0x40
	System.Collections.Generic.HashSet<System.Int32> groundFreeIds; // 0x48
	System.Boolean m_useHeightMap; // 0x50
	System.Boolean isMultipleLine; // 0x51
	System.Int32 m_targetType; // 0x54
	System.Int32 indexTargetPos; // 0x58
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06aa251c
	System.Void ShowGuideLinesById(System.Int32 guideLineId); // 0x06aa27c8
	System.Void ShowGuideLines(System.Int32 index); // 0x06aa2bb0
	System.Void TryInitGuideLineGo(); // 0x06aa25bc
	System.Void PreloadEffectResource(); // 0x06aa317c
	System.Void SetEffectHandle(UnityEngine.Vector3 targetPos, System.Int32 targetType); // 0x06aa2ef8
	System.Void HideGuideLine(); // 0x06aa2a7c
	System.Void Update(); // 0x06aa34ac
	System.Void .ctor(); // 0x06aa3524
	static System.Void .cctor(); // 0x06aa3690
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrIOEntity : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Log; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.IOEntity>> ioEntityDic; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.IOEntity> allIOEntities; // 0x20
	System.Void Init(); // 0x06aa3784
	System.Threading.Tasks.Task OnExitWorld(); // 0x06aa389c
	System.Void OnTeamMemberChange(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x06aa3a04
	WizardGames.Soc.Common.Entity.IOEntity GetTargetIOEntity(System.Int32 monumentID, System.Int32 templateID); // 0x06aa3ae0
	System.Void .ctor(); // 0x06aa3be0
	static System.Void .cctor(); // 0x06aa3cf0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.ObjectPoolSystemInit : System.Object
{
	
	static System.Void Init(); // 0x06aa3dc4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrKatyusha : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Log; // 0x0
	WizardGames.Soc.Common.Entity.KatyushaEntity mKatyushaEntity; // 0x18
	WizardGames.Soc.Common.Data.units.KatyushaConfig mKatyushaConfig; // 0x20
	System.Single MapGridAlpha; // 0x28
	static UnityEngine.Vector3 KatyushaTargetMarkerPos; // 0x8
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.MissileEntity> allMissileEntities; // 0x30
	System.Boolean mIsKatyushaLaunch; // 0x38
	static System.Int32 missileMaxNum; // 0x14
	System.Single aimingTimeMs; // 0x3c
	System.Int64 launchPlayerId; // 0x40
	WizardGames.Soc.Common.Entity.KatyushaEntity get_KatyushaEntity(); // 0x06aa3f34
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.MissileEntity> get_AllMissileEntities(); // 0x06aa3f98
	WizardGames.Soc.Common.Data.units.KatyushaConfig get_TbKatyusha(); // 0x06aa3ffc
	System.Void Init(); // 0x06aa4140
	System.Threading.Tasks.Task OnExitWorld(); // 0x06aa4348
	System.Void OnCreateEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06aa4554
	System.Void RefreshLaunchPlayer(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int64 oldValue, System.Int64 newValue); // 0x06aa49b4
	System.Void OnRemoveEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06aa4b38
	System.Int32 CheckBagMissileCount(); // 0x06aa4e34
	System.Boolean IsShowKatyushaMissileHud(System.Int64 playerID); // 0x06aa4ed8
	System.Void OnKatyushaLanchStateChanged(); // 0x06aa4914
	System.Int32 get_MissileNum(); // 0x06aa4f90
	System.Void .ctor(); // 0x06aa500c
	static System.Void .cctor(); // 0x06aa515c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobbyObserver : WizardGames.Soc.Common.Manager.MgrBase
{
	SocLogger logger; // 0x18
	System.Boolean haveObPermission; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.ServerList.ServerInfo> observerBattleList; // 0x28
	System.Void Init(); // 0x06aa5284
	System.Void OnAccountLogined(); // 0x06aa52f4
	System.Void OnAccountLogout(); // 0x06aa55dc
	System.Void GetObPermissionStatus(); // 0x06aa5364
	System.Void ReqObPermissionStatus(SimpleJSON.JSONNode json); // 0x06aa564c
	System.Void GetObBattleList(); // 0x06aa5724
	System.Void ReqObBattleList(SimpleJSON.JSONNode json); // 0x06aa5918
	System.Void .ctor(); // 0x06aa5ae8
	System.Void <GetObPermissionStatus>b__9_0(SimpleJSON.JSONNode node); // 0x06aa5c38
	System.Void <GetObBattleList>b__11_0(SimpleJSON.JSONNode node); // 0x06aa5d00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLobbyTime : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Double setTimeStampRec; // 0x18
	System.Int64 lastServerTimeStamp; // 0x20
	System.Int64 lastGMRealServerTimeStamp; // 0x28
	System.String <ServerINIATimerZone>k__BackingField; // 0x30
	System.Boolean UseGMLocalTime; // 0x38
	System.String get_ServerINIATimerZone(); // 0x054e7844
	System.Void set_ServerINIATimerZone(System.String value); // 0x05523a54
	System.Void SetServerTimeData(System.String stamp, System.String zone); // 0x0552af00
	System.Void SetGMServerTimeData(System.String stamp, System.String zone); // 0x0552af00
	System.Void ResetGMLobbyServerTime(); // 0x055049cc
	System.Void OnAccountLogout(); // 0x055049cc
	System.Boolean TryGetCurSvrUtc0DateTime(System.DateTime& time); // 0x06aa60c8
	System.Boolean TryGetCurSvrUtc0TimeStamp(System.Int64& time); // 0x06aa61f8
	System.Boolean TryGetCurSvrZonedTime(NodaTime.ZonedDateTime& time); // 0x06aa62b4
	System.Boolean TryGetCurSvrTime(System.DateTime& time); // 0x06aa64a0
	System.Boolean TryGetCurSvrTimeStamp(System.Int64& curTimeStamp); // 0x06aa6584
	System.Boolean TryGetCurLocalTime(System.DateTime& time); // 0x06aa6640
	System.Boolean InTimeRange(System.DateTime nowDT, System.String startSvrZonedTime, System.String endSvrZonedTime); // 0x06aa6724
	System.Boolean InTimeRange(System.String startSvrZonedTime, System.String endSvrZonedTime); // 0x06aa68ac
	System.Boolean HasReachedTime(System.DateTime nowDT, System.String svrZonedTimeStr, System.Boolean emptyTimeRes); // 0x06aa6968
	System.Boolean HasReachedTime(System.String svrZonedTimeStr, System.Boolean emptyTimeRes); // 0x06aa6a78
	System.Boolean TryGetTimeOffset(System.DateTime tarTime, System.TimeSpan& span); // 0x06aa6b34
	System.Boolean TryGetTimeOffset(System.String svrZonedTimeStr, System.TimeSpan& span); // 0x06aa6c48
	System.Void .ctor(); // 0x06aa6d5c
	static System.Void .cctor(); // 0x06aa6dc4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.EButtonId : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.EButtonId LeftExitConstruction = 101;
	static WizardGames.Soc.SocClient.Manager.EButtonId RightExitConstruction = 102;
	static WizardGames.Soc.SocClient.Manager.EButtonId FirstModeChange = 103;
	static WizardGames.Soc.SocClient.Manager.EButtonId RightOperation = 104;
	static WizardGames.Soc.SocClient.Manager.EButtonId LeftOperation = 105;
	static WizardGames.Soc.SocClient.Manager.EButtonId CancelOperation = 106;
	static WizardGames.Soc.SocClient.Manager.EButtonId Detail = 107;
	static WizardGames.Soc.SocClient.Manager.EButtonId FirstTag = 108;
	static WizardGames.Soc.SocClient.Manager.EButtonId SecondTag = 109;
	static WizardGames.Soc.SocClient.Manager.EButtonId SelectItem = 110;
	static WizardGames.Soc.SocClient.Manager.EButtonId ExpandBtn = 111;
	static WizardGames.Soc.SocClient.Manager.EButtonId SecondModeChange = 112;
	static WizardGames.Soc.SocClient.Manager.EButtonId ConstructionTipsWithBtn = 113;
	static WizardGames.Soc.SocClient.Manager.EButtonId InteractveListBtn = 114;
	static WizardGames.Soc.SocClient.Manager.EButtonId DownUpBtn = 115;
	static WizardGames.Soc.SocClient.Manager.EButtonId RotationBtn = 116;
	static WizardGames.Soc.SocClient.Manager.EButtonId ChangeForward = 117;
	static WizardGames.Soc.SocClient.Manager.EButtonId DeleteOrPickUp = 118;
	static WizardGames.Soc.SocClient.Manager.EButtonId DropdownList = 119;
	static WizardGames.Soc.SocClient.Manager.EButtonId IntelligentBtn = 201;
	static WizardGames.Soc.SocClient.Manager.EButtonId ManualBtn = 202;
	static WizardGames.Soc.SocClient.Manager.EButtonId DropdownListSlot = 203;
	static WizardGames.Soc.SocClient.Manager.EButtonId SlotChange = 204;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.EButtonGroup : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.EButtonGroup ConstructionGroup1 = 1;
	static WizardGames.Soc.SocClient.Manager.EButtonGroup ConstructionGroup2 = 2;
	static WizardGames.Soc.SocClient.Manager.EButtonGroup ConstructionGroup3 = 3;
	static WizardGames.Soc.SocClient.Manager.EButtonGroup ConstructionGroup4 = 4;
	static WizardGames.Soc.SocClient.Manager.EButtonGroup ConstructionGroup5 = 5;
	static WizardGames.Soc.SocClient.Manager.EButtonGroup ElectricityGroup1 = 6;
	static WizardGames.Soc.SocClient.Manager.EButtonGroup ElectricityGroup2 = 7;
	static WizardGames.Soc.SocClient.Manager.EButtonGroup ElectricityGroup3 = 8;
	static WizardGames.Soc.SocClient.Manager.EButtonGroup ElectricityGroup4 = 9;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.LogInfo : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.ButtonLogInfo> ButtonLogInfos; // 0x10
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Manager.EButtonId,System.Int32> ButtonCountDic; // 0x18
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Manager.EButtonGroup,System.Int32> GroupCountDic; // 0x20
	System.Single ManualTimer; // 0x28
	System.Single IntelligentTimer; // 0x2c
	System.Void AddTimer(System.Boolean isInIntelligentWireState); // 0x06aa6e98
	System.Void AddLog(WizardGames.Soc.SocClient.Manager.EButtonId buttonId, WizardGames.Soc.SocClient.Manager.EButtonGroup buttonGroup); // 0x06aa6f48
	System.Void .ctor(); // 0x06aa739c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.ButtonLogInfo : System.Object
{
	System.String ButtonId; // 0x10
	System.String ButtonGroup; // 0x18
	System.Int64 Timestamp; // 0x20
	System.String Time; // 0x28
	System.Void .ctor(); // 0x06aa7334
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrLocalLog : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Boolean isOpenLog; // 0x11
	WizardGames.Soc.SocClient.Manager.LogInfo logInfo; // 0x18
	System.Void AddTimer(System.Boolean isInIntelligentWireState); // 0x06aa7500
	System.Void AddLog(WizardGames.Soc.SocClient.Manager.EButtonId buttonId, WizardGames.Soc.SocClient.Manager.EButtonGroup buttonGroup); // 0x06aa759c
	System.Void .ctor(); // 0x06aa7644
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrMonumentEvent : WizardGames.Soc.Common.Unity.Manager.MgrMonumentEventBase
{
	static System.String tickTimerMark; // 0x0
	System.Int64 tickTimerHandle; // 0x98
	System.Int32 activeEventCnt; // 0xa0
	System.Int32 eventToBeRemovedCnt; // 0xa4
	System.Void TryCancelTimer(); // 0x06aa76e0
	System.Void RegisterActionExecutor(); // 0x06aa77ec
	WizardGames.Soc.Common.Data.monument.MonumentEventData BaseCheck(System.Int32 monumentId, System.Int64 eventId); // 0x06aa7970
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06aa7c48
	System.Threading.Tasks.Task OnExitWorld(); // 0x06aa7cb8
	System.Void TriggerCachedData(); // 0x06aa7d28
	System.Void TickTimerCb(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x06aa7fb8
	System.Void OnActionExecuteSuccess(WizardGames.Soc.Common.Unity.Monument.MonumentActionParams actionParams, System.UInt64 monumentActionMid); // 0x06aa8344
	System.Void AddConcreteAction(System.Int32 monumentId, System.UInt64 monumentActionMid); // 0x0550fb24
	System.Boolean CheckTimerNeedStart(); // 0x06aa8894
	System.Boolean CheckTimerNeedStop(); // 0x06aa82d8
	System.Void AddActionToBeRemoved(System.UInt64 monumentActionMid); // 0x055251fc
	System.Void RemoveAction(WizardGames.Soc.Common.Unity.Monument.MonumentActionParams actionParams, System.UInt64 actionMid); // 0x06aa8aec
	System.Void RemoveAction(System.Int32 monumentId, System.UInt64 monumentActionMid); // 0x06aa8ba4
	System.Void RemoveAction(); // 0x06aa8cd0
	System.Void .ctor(); // 0x06aa8d40
	static System.Void .cctor(); // 0x06aa8dd4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.PreventBuildingArea : System.Object
{
	System.Int32 id; // 0x10
	UnityEngine.Vector3 effectSize; // 0x14
	WizardGames.Soc.Common.Unity.Utility.OBB obb; // 0x20
	System.Boolean isFxShow; // 0x70
	Effect.EffectItemHandle<Effect.EffectItem> wallEffectItemHandle; // 0x78
	System.Void Clear(); // 0x06aa8e3c
	System.Void ShowEffect(); // 0x06aa8fc4
	System.Void HideEffect(); // 0x06aa8f08
	System.Void .ctor(); // 0x06aa91d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrMonumentPreventBuildings : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Manager.PreventBuildingArea> allDatas; // 0x18
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06aa9240
	System.Threading.Tasks.Task OnExitWorld(); // 0x06aa9358
	System.Void BuildStateSwitchEvent(System.Boolean isInBuildMode); // 0x06aa9470
	System.Void OnFps1Update(); // 0x06aa9e34
	System.Void CheckFx(); // 0x06aa9e98
	System.Void OnEnterConstructionMode(); // 0x06aa96f4
	System.Void OnExitConstructionMode(); // 0x06aa94fc
	System.Void .ctor(); // 0x06aaa250
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrMonumentTask : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Log; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.Common.MonumentPath.BasePointInfo> mNearStartPoints; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.Common.MonumentPath.BasePointInfo> mTargetEndPoints; // 0x20
	System.Collections.Generic.Stack<WizardGames.Soc.Common.MonumentPath.BasePointInfo> mCurGuidePath; // 0x28
	WizardGames.Soc.Common.MonumentPath.BasePointInfo mCurGuidePoint; // 0x30
	UnityEngine.GameObject mAudioSender; // 0x78
	WizardGames.Soc.SocClient.Manager.MgrMonumentTask.EGuideStage mCurGuideStage; // 0x80
	UnityEngine.Vector3 mLastPlayerPos; // 0x84
	System.Int64 mCurGuideEntityID; // 0x90
	WizardGames.Soc.Common.Entity.IOEntity mCurGuideIOEntity; // 0x98
	System.Int64 myPlayerEntityId; // 0xa0
	System.Int64 lastTickTime; // 0xa8
	System.Int64 posSubId; // 0xb0
	System.Int64 taskIdSubId; // 0xb8
	WizardGames.Soc.Common.MonumentPath.BasePointInfo get_CurGuidePoint(); // 0x06aaa304
	System.Int64 get_GetGuideEntityID(); // 0x06aaa384
	System.Void Init(); // 0x06aaa684
	System.Void OnCreateEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06aaa938
	System.Void OnEntityBeforeRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06aaaf38
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06aab428
	System.Threading.Tasks.Task AfterEnterWorld(); // 0x06aab490
	System.Void RefreshGuideStage(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldValue, System.Int32 newValue); // 0x06aab4f8
	System.Void UpdateGuideStage(); // 0x06aab5ac
	System.Threading.Tasks.Task OnExitWorld(); // 0x06aab858
	System.Void SubscribePlayerMove(); // 0x06aaad74
	System.Void SubscribePlayerMonumentState(); // 0x06aaabac
	System.Void UnsubscribePlayerMove(); // 0x06aab150
	System.Void UnsubscribePlayerMonumentState(); // 0x06aab2bc
	System.Void OnPosChange(WizardGames.Soc.Share.Framework.PositionChangeEvent e); // 0x06aaba54
	System.Void OnTaskIDChanged(System.Int32 groupId, System.Int32 taskId); // 0x06aac430
	System.Void UpdateGuideEntity(); // 0x06aaa3fc
	System.Void UpdateGuidePath(); // 0x06aabb5c
	static System.Int32 PointComparer(WizardGames.Soc.Common.MonumentPath.BasePointInfo pointA, WizardGames.Soc.Common.MonumentPath.BasePointInfo pointB); // 0x06aad0e8
	static System.Single GetNodeDist(WizardGames.Soc.Common.MonumentPath.BasePointInfo point); // 0x06aad1f8
	System.Void GetGuidePath(System.Int32 monumentId, System.Collections.Generic.Stack<WizardGames.Soc.Common.MonumentPath.BasePointInfo>& path, System.Single& pathCost); // 0x06aac738
	System.Void SetGuidePoint(System.Boolean findOptimizationPoint); // 0x06aac91c
	System.Void UpdateGuidePoint(); // 0x06aacd2c
	System.Void ShowGuideHint(); // 0x06aad384
	System.Void SetGuideStage(WizardGames.Soc.SocClient.Manager.MgrMonumentTask.EGuideStage stage); // 0x06aab748
	System.Void OnPlayerLoaded(); // 0x06aad468
	System.Void SetGuideEntity(System.Int64 entityID, System.Boolean isShow); // 0x06aac5e0
	System.Void .ctor(); // 0x06aad4cc
	static System.Void .cctor(); // 0x06aad614
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.MgrMonumentTask.EGuideStage : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.MgrMonumentTask.EGuideStage None = 0;
	static WizardGames.Soc.SocClient.Manager.MgrMonumentTask.EGuideStage FindPath = 1;
	static WizardGames.Soc.SocClient.Manager.MgrMonumentTask.EGuideStage PathGuide = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrNewbieLevel : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Boolean isAwake; // 0x11
	System.Boolean firstUpdate; // 0x12
	static System.Collections.Generic.List<UnityEngine.Vector3> pathListCache; // 0x8
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.Dictionary<System.Int64,System.Int64>> npcTaskNum2State; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Timeline.FakeNPC> fakeNpcs; // 0x20
	System.Collections.Generic.HashSet<System.Int64> timelineAnimatedModels; // 0x28
	System.Collections.Generic.HashSet<System.Int64> lookAtIKModels; // 0x30
	UnityEngine.Animator helicopterAnimator; // 0x38
	System.Boolean helicopterTriggered; // 0x40
	WizardGames.Soc.SocClient.Timeline.FakeNPC tankModel; // 0x48
	System.Int32 presetAfterCartoon; // 0x50
	System.Int64 presetAfterCartoonTimerId; // 0x58
	System.Collections.Generic.List<System.Int64> weatherTaskIds; // 0x60
	System.Collections.Generic.HashSet<System.Int64> cartoonWeatherTaskIds; // 0x68
	static System.Int32 overrideWeatherPresetId; // 0x10
	static System.Boolean LevelStreamingFlag; // 0x14
	static System.Int32 destroyMaxCount; // 0x18
	WizardGames.Soc.SocClient.LevelStreaming.LevelStreamingTag streamingTag; // 0x70
	System.Collections.Generic.List<UnityEngine.GameObject> streamingDestroyList; // 0x78
	System.Collections.Generic.List<System.Int64> ambienceTaskIds; // 0x80
	System.String curAmbienceEvent; // 0x88
	WizardGames.Soc.SocClient.Audio.WWise.AudioEventData audioEventdata; // 0x90
	System.Action<WizardGames.Soc.SocClient.Audio.WWise.AudioEventData> SoundPlayAction; // 0x98
	System.Action<WizardGames.Soc.SocClient.Audio.WWise.AudioEventData> SoundStopAction; // 0xa0
	static System.Boolean EnableDestroyTest; // 0x1c
	static System.Int32 DebugObjectDestroyCount; // 0x20
	static System.Int32 DebugDestroyMaxFrameTimeMs; // 0x24
	static System.Collections.Generic.Queue<UnityEngine.Transform> debugObjectDestroyQueue; // 0x28
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06aad6e8
	System.Threading.Tasks.Task OnExitWorld(); // 0x06aae404
	System.Void Update(System.Int32 deltaTime); // 0x06aae960
	System.Void AddListener(); // 0x06aae1dc
	System.Void RemoveListener(); // 0x06aae738
	System.Void OnMissionChanged(); // 0x06aaee8c
	System.Void OnPlayerAwake(); // 0x06ab0458
	System.Void LoadNPCModel(); // 0x06aad7e4
	System.Void ReleaseNPCModel(); // 0x06aae6ac
	WizardGames.Soc.SocClient.Timeline.FakeNPC GetFakeNPC(System.Int64 modelId); // 0x06ab0d30
	System.Void CreateFakeNPC(WizardGames.Soc.Common.Data.Play.NewbieModelConfig config, UnityEngine.GameObject model); // 0x06ab0dc4
	System.Void FakeNpcLoadModel(System.Int64 modelId); // 0x06ab100c
	System.Void OnPlayerEnterTrigger(UnityEngine.GameObject triggerGo); // 0x06ab10c8
	System.Void OnTriggerStateChange(WizardGames.Soc.Common.Unity.Trigger.CommonTriggerNewbieEvent trigger, System.Int64 modelId, System.Boolean inTrigger, WizardGames.Soc.Common.Data.ENewbieTrigger tType); // 0x06ab12b4
	System.Void UpdateNPCMove(System.Int32 deltaTime); // 0x06aaea2c
	System.Void UpdateNPCState(System.Int64 taskId); // 0x06aaf2c8
	System.Void InitNPCTask(); // 0x06ab05f8
	System.Void FindPathCallback(System.Int64 modelId, System.Collections.Generic.List<System.Single> nodeX, System.Collections.Generic.List<System.Single> nodeY, System.Collections.Generic.List<System.Single> nodeZ); // 0x06ab1380
	System.Void AddTimelineAnimatedModel(System.Int64 modelId); // 0x06ab1700
	System.Void ClearNPCAnimatorController(); // 0x06ab179c
	System.Void RebindNPCAnimatorController(); // 0x06ab196c
	System.Void UnloadSingleNPC(System.Int64 modelId); // 0x06ab1b60
	System.Void ClearNPCData(); // 0x06ab09c0
	System.Void InitLookAtIKModels(); // 0x06ab1c1c
	System.Void AddLookAtIKModel(System.Int64 modelId); // 0x06ab1ca0
	System.Boolean HasLookAtIK(System.Int64 modelId); // 0x06ab1d3c
	static System.Void InitLookAtIK(System.Int64 modelId, UnityEngine.GameObject mainGo); // 0x06ab1dd8
	System.Void ConstructionOverrideWeather(); // 0x06ab21d8
	System.Void ResetOverrideWeather(); // 0x06ab25a8
	System.Void TimelineChangeWeather(System.Int32 weatherPresetId); // 0x06ab274c
	System.Void UpdateWeather(System.Int64 taskId, System.Boolean isInstant); // 0x06aaf560
	System.Void OnCartoonStart(); // 0x06ab2a34
	System.Void BuildWeatherTaskList(); // 0x06aad848
	static System.Void SetWeatherPreset(System.Int32 presetIndex, System.Single easeDuration); // 0x06ab2348
	System.Void SetWeatherPresetCb(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x06ab2e30
	System.Void BindHelicopter(UnityEngine.Animator animator); // 0x06ab2efc
	System.Void UpdateHelicopterState(System.Int64 taskId); // 0x06aaf7e0
	System.Void UpdateTankState(System.Int64 taskId); // 0x06aaf968
	System.Void InitLevelStreamingTag(); // 0x06aadb78
	System.Void UpdateStreamingInfo(System.Int64 taskId); // 0x06aaff28
	System.Void UpdateStreamingDestroy(); // 0x06aaebd4
	UnityEngine.GameObject GetNpcHudPos(System.Int64 npcId); // 0x06ab3018
	System.Void InitAudioTaskList(); // 0x06aadf44
	System.Void UpdateAmbientByTask(System.Int64 taskId); // 0x06ab0240
	System.Void OnSoundPlay(WizardGames.Soc.SocClient.Audio.WWise.AudioEventData data); // 0x06ab30dc
	System.Void OnSoundStop(WizardGames.Soc.SocClient.Audio.WWise.AudioEventData data); // 0x06ab3168
	System.Void CreateAudioEventData(WizardGames.Soc.Common.Unity.Timeline.SoundPrintData data, UnityEngine.GameObject audioGo); // 0x06ab31f4
	System.Void StartAudio(UnityEngine.GameObject audioGo); // 0x06ab32f0
	System.Void StartAudio(WizardGames.Soc.Common.Unity.Timeline.SoundPrintData data); // 0x06ab3500
	System.Void StopAudio(WizardGames.Soc.Common.Unity.Timeline.SoundPrintData data); // 0x06ab3b08
	static UnityEngine.GameObject FindGameObjectByPath(UnityEngine.Transform transform, System.String path); // 0x06ab39c8
	static System.Int64 GetNearestTaskId(System.Int64 taskId, System.Collections.Generic.List<System.Int64> taskList); // 0x06ab28b4
	System.Void .ctor(); // 0x06ab3ed0
	static System.Void .cctor(); // 0x06ab41cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrObjectRenderer : WizardGames.Soc.Common.Manager.MgrBase
{
	SocLogger Log; // 0x18
	static System.Boolean ConstructionEnabled; // 0x0
	static System.Boolean NatureEnabled; // 0x1
	static System.Boolean InteractiveEnabled; // 0x2
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Manager.RenderType,WizardGames.Soc.SocClient.GpuRendererHandler.RendererHandler> rendererHandlers; // 0x20
	RendererHandlerCharacter CharRenderHandler; // 0x28
	System.Boolean get_ConstructionGpuInstanceEnabled(); // 0x06ab459c
	System.Boolean get_NatureGpuInstanceEnabled(); // 0x06ab462c
	System.Boolean get_InteractiveGpuInstanceEnabled(); // 0x06ab46bc
	System.Void Init(); // 0x06ab474c
	System.Void AddObject(WizardGames.Soc.SocClient.Manager.RenderType oType, System.Int32 id, UnityEngine.GameObject prefab, UnityEngine.Matrix4x4 matrix, System.String prefabPath, System.Int64 prefabId, UnityEngine.Color emissionColor, System.Action cb); // 0x06ab4898
	System.Boolean AddInstanceRenderObject(WizardGames.Soc.SocClient.Manager.RenderType oType, UnityEngine.Rendering.Universal.InstanceRenderInfo instanceRenderInfo); // 0x06ab4b40
	System.Void RemoveObject(WizardGames.Soc.SocClient.Manager.RenderType oType, System.Collections.Generic.List<System.Int32> removeObjects, System.Action cb); // 0x06ab4c24
	System.Void RemoveObject(WizardGames.Soc.SocClient.Manager.RenderType oType, System.Int32 instanceId); // 0x06ab4d04
	System.Void UpdateTransformObject(WizardGames.Soc.SocClient.Manager.RenderType oType, System.Int32 id, UnityEngine.Matrix4x4 transform, UnityEngine.Color emissionColor); // 0x06ab4ddc
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06ab4f18
	System.Threading.Tasks.Task OnExitWorld(); // 0x06ab51a4
	System.Void OnFullSnapshotReceived(); // 0x06ab537c
	System.Void Update(); // 0x06ab552c
	System.Void .ctor(); // 0x06ab56d8
	static System.Void .cctor(); // 0x06ab5828
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.RenderType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.RenderType None = 0;
	static WizardGames.Soc.SocClient.Manager.RenderType Construction = 1;
	static WizardGames.Soc.SocClient.Manager.RenderType Nature = 2;
	
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Manager.IObserverUse : 
{
	
	System.Void AttachObserver(); // 0x055049cc
	System.Void DetachObserver(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrObserver : WizardGames.Soc.Common.Manager.MgrBase
{
	SocLogger logger; // 0x18
	WizardGames.Soc.Common.Entity.PlayerEntity emptyPlayerEntity; // 0x20
	WizardGames.Soc.Common.Unity.Free.AnchorCameraParam anchorCameraParam; // 0x28
	WizardGames.AssetPool.WeakHandle weakHandle; // 0x30
	System.Single MoveAccSpeed; // 0x40
	System.Single RunMaxSpeed; // 0x44
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.CustomType.PatrolTerritoryBriefInfo> PatrolTerritoryBriefInfoDict; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PatrolTerritoryBriefInfo> PatrolTerritoryBriefInfoList; // 0x50
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo> PatrolPlayerBriefInfoDict; // 0x58
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo> PatrolPlayerBriefInfoList; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo> OnlinePatrolPlayerBriefInfoList; // 0x68
	System.UInt64 <PossessionRoleId>k__BackingField; // 0x70
	System.Int64 <PossessionPlayerId>k__BackingField; // 0x78
	System.Int64 <LastObserverPlayerId>k__BackingField; // 0x80
	System.UInt64 <WantPossessionRoleId>k__BackingField; // 0x88
	System.Boolean WaitForLoading; // 0x90
	System.Single SmoothYaw; // 0x94
	System.Single SmoothPitch; // 0x98
	System.Boolean hasFullPossessionPlayerData; // 0x9c
	System.Boolean TryAttach; // 0x9d
	System.Collections.Generic.List<System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo>> teamList; // 0xa0
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo>> teamGroupDict; // 0xa8
	System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo>>> teamGroupsWithTeam; // 0xb0
	System.Int64 nextGetAllPlayerTime; // 0xb8
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PatrolTerritoryBriefInfo> obTerritoryBriefInfoList; // 0xc0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.CustomType.PatrolTerritoryBriefInfo> obTerritoryBriefInfoDict; // 0xc8
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo> obPlayerBriefInfoList; // 0xd0
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo> onLineObPlayerBriefInfoList; // 0xd8
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo> obPlayerBriefInfoDict; // 0xe0
	System.Void Init(); // 0x06ab587c
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06ab59e0
	System.Threading.Tasks.Task OnExitWorld(); // 0x06ab5af0
	System.Void InitStartPlayer(); // 0x06ab5b84
	WizardGames.Soc.Common.Entity.TeamEntity GetObPlayerTeam(System.Int64 playerId); // 0x06ab6094
	System.UInt64 get_PossessionRoleId(); // 0x06ab6240
	System.Void set_PossessionRoleId(System.UInt64 value); // 0x06ab62a4
	System.Int64 get_PossessionPlayerId(); // 0x06ab631c
	System.Void set_PossessionPlayerId(System.Int64 value); // 0x06ab6380
	System.Void set_LastObserverPlayerId(System.Int64 value); // 0x06ab645c
	System.UInt64 get_WantPossessionRoleId(); // 0x06ab64d4
	System.Void set_WantPossessionRoleId(System.UInt64 value); // 0x06ab6538
	System.Void SetWantPossessionRoleId(System.UInt64 roleId); // 0x055251fc
	System.Void SwitchPossessionPlayer(System.Int64 playerId); // 0x055112ac
	System.Void ShallowAttachComponents(WizardGames.Soc.Common.Entity.PlayerEntity self, WizardGames.Soc.Common.Entity.PlayerEntity other); // 0x06ab734c
	System.Void ShallowDeAttachComponents(WizardGames.Soc.Common.Entity.PlayerEntity self); // 0x06ab765c
	System.Single LimitAnchorPitch(System.Single pitch); // 0x06ab7a14
	System.Void ObserverMove(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06ab7adc
	System.Void MoveCamera(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams); // 0x06ab7e10
	System.Void HandleTeamList(System.Collections.Generic.IReadOnlyList<WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo> playerLists); // 0x06ab8644
	System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo>> GetTeamList(); // 0x06ab90b4
	System.Int32 SortTeamPlayer(System.Collections.Generic.KeyValuePair<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo>> left, System.Collections.Generic.KeyValuePair<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo>> right); // 0x06ab9118
	System.Int32 SortSinglePlayer(WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo left, WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo right); // 0x06ab91dc
	System.Void RemoteCallGetAllTerritory(); // 0x06ab92f0
	System.Void RemoteCallGetTerritoryDetail(System.Int64 territoryId); // 0x06ab9430
	System.Void RemoteCallGetAllPlayer(); // 0x06ab9594
	System.Void RemoteCallGetPlayerDetail(System.UInt64 roleId); // 0x06ab9744
	System.Void GetAllTerritoryAck(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.PatrolTerritoryBriefInfo> territories); // 0x06ab98a8
	System.Void GetAllTerritoryPatrolAck(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.PatrolTerritoryBriefInfo> territories); // 0x06ab9a18
	System.Void GetTerritoryDetailAck(WizardGames.Soc.Common.CustomType.PatrolTerritoryDetailInfo detailInfo); // 0x06aba370
	System.Void GetAllPlayerAck(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo> players); // 0x06aba50c
	System.Void GetAllPlayerPatrolAck(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo> players); // 0x06aba67c
	System.Int32 SortPlayers(WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo left, WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo right); // 0x06abb094
	System.Void GetPlayerDetailAck(WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo detailInfo); // 0x06abb48c
	System.Void GetAllTerritoryObAck(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.PatrolTerritoryBriefInfo> territories); // 0x06ab9ec4
	System.Void GetAllPlayerObAck(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo> players); // 0x06abab88
	System.Void .ctor(); // 0x06abb558
	System.Threading.Tasks.Task <>n__0(); // 0x06abb99c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrObserver.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Manager.MgrObserver.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.CustomType.PatrolTerritoryBriefInfo> <>9__63_0; // 0x8
	static System.Comparison<WizardGames.Soc.Common.CustomType.PatrolTerritoryBriefInfo> <>9__74_0; // 0x10
	static System.Void .cctor(); // 0x06abba04
	System.Void .ctor(); // 0x06abba68
	System.Int32 <GetAllTerritoryPatrolAck>b__63_0(WizardGames.Soc.Common.CustomType.PatrolTerritoryBriefInfo left, WizardGames.Soc.Common.CustomType.PatrolTerritoryBriefInfo right); // 0x06abbad0
	System.Int32 <GetAllTerritoryObAck>b__74_0(WizardGames.Soc.Common.CustomType.PatrolTerritoryBriefInfo left, WizardGames.Soc.Common.CustomType.PatrolTerritoryBriefInfo right); // 0x06abbb90
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Manager.MgrObserver.<OnEnterWorld>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Manager.MgrObserver <>4__this; // 0x30
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x38
	System.Void MoveNext(); // 0x06abbc50
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x06abbf88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrPowerOptimization : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Single pauseDuration; // 0x14
	System.Single beginPauseTime; // 0x18
	System.Int32 lobbyFrameRate; // 0x1c
	System.Boolean enablePowerOptimization; // 0x20
	SocLogger logger; // 0x28
	System.Boolean FullUIState; // 0x30
	System.Boolean InLobby; // 0x31
	System.Int32 POFrameRate; // 0x34
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> framerateCount; // 0x38
	System.Boolean isPaused; // 0x40
	System.Boolean get_EnablePowerOptimization(); // 0x06abc02c
	System.Void set_EnablePowerOptimization(System.Boolean value); // 0x06abc090
	System.Void InitializeInGameSetting(); // 0x06abc16c
	System.Void ResetInGameSetting(); // 0x06abc354
	System.Void AddLobbyListener(); // 0x06abc690
	System.Void RemoveLobbyListener(); // 0x06abc7dc
	System.Void Init(); // 0x06abc928
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06abc9ec
	System.Threading.Tasks.Task OnExitWorld(); // 0x06abcc30
	System.Void OnFullSnapshotReceived(); // 0x06abcdac
	System.Void OnHpChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Single oldValue, System.Single newValue); // 0x06abcf08
	System.Void CloseUI(); // 0x06abcffc
	System.Void OpenUI(); // 0x06abd230
	System.Int32 LimitFrameRate(System.Int32 rate); // 0x06abcd04
	System.Void OnUiOpened(WizardGames.Soc.Common.Unity.Ui.WindowComBase window); // 0x06abd430
	System.Void OnUiRemove(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x06abd918
	System.Void OnBombHomeGameOver(System.Boolean _); // 0x06abdc44
	System.Void OnUiLoginInit(); // 0x06abdcc8
	System.Void OnUiLobbyInit(); // 0x06abdd34
	System.Void OnFps10Update(); // 0x06abdf80
	System.Void OnFps1Update(); // 0x06abe108
	System.Void Destroy(); // 0x06abe3b0
	System.Boolean IsOptimizationOpen(); // 0x06abcb98
	System.Boolean NeedOptimization(); // 0x06abe294
	System.Boolean InterestUi(System.String uiName); // 0x06abd6d0
	System.Int32 GetMinFramerate(System.Int32 defaultValue); // 0x06abd780
	System.Void OnApplicationPause(System.Boolean pause); // 0x06abe440
	System.Void .ctor(); // 0x06abe6f4
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Manager.TimeRange : System.ValueType
{
	System.Int32 startHour; // 0x10
	System.Int32 startMinute; // 0x14
	System.Int32 endHour; // 0x18
	System.Int32 endMinute; // 0x1c
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrRaid : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Log; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.TimeRange> raidTimeRanges; // 0x18
	System.Single timeRecord; // 0x20
	System.Int32 downTime; // 0x24
	System.Boolean IsInRading; // 0x28
	System.Boolean get_IsOpenRaid(); // 0x06abe854
	System.Void Init(); // 0x06abe950
	System.Void Destroy(); // 0x06abed50
	System.Void UpdateRaidTime(); // 0x06abea68
	System.Boolean IsInRaidTimeRange(System.Int32& countDown); // 0x06abee54
	System.Void OnFps1Update(System.Single dt); // 0x06abf3f8
	System.Void RecordTime(); // 0x06abf764
	System.Void ShowEnterTerrCenterNoPermissionTip(System.Boolean isDeadSheep); // 0x06abf7e4
	System.Void .ctor(); // 0x06abf97c
	static System.Void .cctor(); // 0x06abfa30
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.EUiOpenTriggerType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.EUiOpenTriggerType None = 0;
	static WizardGames.Soc.SocClient.Manager.EUiOpenTriggerType Click = 1;
	static WizardGames.Soc.SocClient.Manager.EUiOpenTriggerType Auto = 2;
	static WizardGames.Soc.SocClient.Manager.EUiOpenTriggerType Jump = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.EUiJumpSource : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.EUiJumpSource Lobby = 0;
	static WizardGames.Soc.SocClient.Manager.EUiJumpSource Game = 1;
	static WizardGames.Soc.SocClient.Manager.EUiJumpSource BattlePass = 2;
	static WizardGames.Soc.SocClient.Manager.EUiJumpSource Banner = 3;
	static WizardGames.Soc.SocClient.Manager.EUiJumpSource Mall = 4;
	static WizardGames.Soc.SocClient.Manager.EUiJumpSource ActiveMall = 5;
	static WizardGames.Soc.SocClient.Manager.EUiJumpSource Activity = 6;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.UiReportEventData : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.Dictionary<System.String,System.String> data; // 0x8
	System.String <UiName>k__BackingField; // 0x10
	System.String lastUiName; // 0x18
	System.Int64 openTime; // 0x20
	WizardGames.Soc.SocClient.Manager.EUiOpenTriggerType triggerType; // 0x28
	WizardGames.Soc.SocClient.Manager.EUiJumpSource jumpSource; // 0x2c
	WizardGames.Soc.SocClient.Ui.RedDotType redDot; // 0x30
	System.Int32 redDotValue; // 0x34
	System.String get_UiName(); // 0x06abfb04
	System.Void set_UiName(System.String value); // 0x06abfb68
	System.Void .ctor(System.String uiName); // 0x06abfbe8
	System.Void SetParams(System.String lastUiNameArg, WizardGames.Soc.SocClient.Manager.EUiOpenTriggerType triggerTypeArg, WizardGames.Soc.SocClient.Manager.EUiJumpSource jumpSourceArg); // 0x06abfcb0
	System.Collections.Generic.Dictionary<System.String,System.String> GetOpenParams(); // 0x06ac0094
	System.Collections.Generic.Dictionary<System.String,System.String> GetCloseParams(); // 0x06ac0474
	static System.Void PrepareCommonData(); // 0x06ac0910
	static System.Void .cctor(); // 0x06ac0cfc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrShopEntity : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Log; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.ShopEntity> shopEntityDic; // 0x18
	System.Int32 shopHudCheckDis; // 0x20
	System.Boolean isCheckObstacle; // 0x24
	System.Boolean isNeedInFrontOfCamera; // 0x25
	System.Int32 mask; // 0x28
	System.Void Init(); // 0x06ac0e28
	System.Void CleanUp(); // 0x06ac0e90
	System.Void .ctor(); // 0x06ac0ef8
	static System.Void .cctor(); // 0x06ac100c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrTokenLink : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Log; // 0x0
	System.Collections.Generic.Stack<System.String> tokenStack; // 0x18
	System.Collections.Generic.Dictionary<System.String,System.String> urlParameters; // 0x20
	System.Collections.Generic.Dictionary<System.String,System.String> extraParams; // 0x28
	System.Boolean loginDone; // 0x30
	System.Boolean isHandlingTokenLink; // 0x31
	System.String lastHandledUrl; // 0x38
	System.Void Init(); // 0x06ac10e0
	System.Threading.Tasks.Task OnExitWorld(); // 0x06ac172c
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06ac1794
	System.Void OnDeepLinkActivated(System.String url); // 0x06ac1364
	System.Boolean CheckHttpsUrlValid(System.String url); // 0x06ac1800
	System.Void OnAccountLogined(); // 0x06ac1e60
	System.Void OnAccountLogout(); // 0x06ac222c
	System.Void Destroy(); // 0x06ac230c
	System.Void HandleTokenLink(System.String url); // 0x06ac245c
	System.Void CheckExecuteTokenLink(); // 0x06ac1b38
	System.Void OnFps1UpdateUI(System.Single dt); // 0x06ac3198
	System.Boolean CheckUILobbyMainExist(); // 0x06ac2d44
	System.Void ParseQueryString(System.String query); // 0x06ac2774
	System.Void ExecuteActions(); // 0x06ac2e08
	System.Void OpenExternalUrl(System.String url); // 0x06ac3210
	System.Void JumpGameUI(System.String jumpId); // 0x06ac367c
	System.Void InitExtraParams(); // 0x06ac1ed8
	System.String GetPlatId(); // 0x06ac384c
	System.Void .ctor(); // 0x06ac38c4
	static System.Void .cctor(); // 0x06ac3a18
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Manager.BlockId : System.ValueType, System.IEquatable<WizardGames.Soc.SocClient.Manager.BlockId>
{
	System.Int32 id; // 0x10
	System.Int32 xIndex; // 0x14
	System.Int32 yIndex; // 0x18
	System.Int32 GetHashCode(); // 0x06ac3aec
	System.Boolean Equals(System.Object other); // 0x06ac3b6c
	System.Boolean Equals(WizardGames.Soc.SocClient.Manager.BlockId other); // 0x06ac3c34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.TreeControlBlockData : System.Object
{
	System.Int32 distanceSqr; // 0x10
	System.Boolean isDirty; // 0x14
	System.Boolean showState; // 0x15
	System.Boolean needCollider; // 0x16
	WizardGames.Soc.SocClient.Manager.BlockId blockId; // 0x18
	System.Boolean isAllTreeDirty; // 0x24
	WizardGames.Soc.Stl.SocDict<System.Int64,WizardGames.Soc.SocClient.Manager.TreeData> Trees; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.TreeData> DirtyTrees; // 0x30
	System.Void AddOrUpdateTree(System.Int64 treeEntityId, WizardGames.Soc.SocClient.Manager.TreeData treeData); // 0x06ac3ce0
	System.Void Hide(); // 0x06ac3ef0
	System.Void Show(); // 0x06ac3f64
	System.Void SetDirty(WizardGames.Soc.SocClient.Manager.TreeData treeData); // 0x06ac3dd8
	System.Void RefreshBlockData(System.Int32& delCount); // 0x06ac3fd8
	System.Void RefreshIfDataRemove(WizardGames.Soc.SocClient.Manager.TreeData treeData); // 0x06ac4348
	System.Void RefreshTree(WizardGames.Soc.SocClient.Manager.TreeData treeData); // 0x06ac4238
	System.Void SetNeedCollider(System.Boolean value); // 0x06ac4478
	System.Void Clear(); // 0x06ac4508
	System.Void RefreshDistance(WizardGames.Soc.SocClient.Manager.BlockId targetBlockId); // 0x06ac4758
	System.Void .ctor(); // 0x06ac47f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.TreeData : WizardGames.Soc.SocClient.Manager.GpuInstanceInfo
{
	System.Boolean isLoadingMeshRender; // 0x61
	WizardGames.Soc.Common.Unity.Construction.MeshRenderConfig meshRenderConfig; // 0x68
	System.Boolean isDirty; // 0x70
	System.Boolean haveControlTree; // 0x71
	System.Boolean haveEntityTree; // 0x72
	UnityEngine.GameObject instGo; // 0x78
	System.Int32 instanceId; // 0x80
	System.String ColliderPrefabPath; // 0x88
	System.UInt64 _loadPrefabAsyncId; // 0x90
	UnityEngine.GameObject colliderGo; // 0x98
	System.Void RemoveLoadingDataAndFreeMeshData(); // 0x06ac48fc
	System.String GoName(); // 0x06ac49c8
	System.Void AddRenderObject(); // 0x06ac4a94
	System.Void RemoveRenderObject(); // 0x06ac51ec
	System.Void SubmitToRender(WizardGames.Soc.Common.Unity.Construction.MeshRenderConfig meshRenderConfig); // 0x06ac501c
	System.Void UnSubmit(); // 0x06ac547c
	System.Void SetCollider(System.Boolean needCollider); // 0x06ac43ec
	System.Void CancelColliderAsyncLoad(); // 0x06ac56e4
	System.Void RemoveColliderGo(); // 0x06ac5278
	System.Void CreateColliderGo(); // 0x06ac552c
	System.Void OnLoadFinish(UnityEngine.GameObject go, System.Object[] arg); // 0x06ac5788
	System.Void .ctor(); // 0x06ac5cd4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrTreeControl : WizardGames.Soc.Common.Manager.MgrBase
{
	static System.Int32 maxBlockDelta; // 0x0
	static System.Int32 maxColliderDelta; // 0x4
	static SocLogger Log; // 0x8
	WizardGames.Soc.Stl.SocDict<System.Int64,WizardGames.Soc.SocClient.Manager.TreeData> AllTrees; // 0x18
	System.Collections.Generic.HashSet<System.Int64> treeEntityIds; // 0x20
	WizardGames.Soc.Stl.SocDict<WizardGames.Soc.SocClient.Manager.BlockId,WizardGames.Soc.SocClient.Manager.TreeControlBlockData> BlockMap; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.TreeControlBlockData> dirtyBlockData; // 0x30
	UnityEngine.Vector3 oldPlayerPos; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.BlockId> oldBlocks; // 0x48
	System.Boolean initPlayerPos; // 0x50
	UnityEngine.GameObject treeTemplateRoot; // 0x58
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Construction.MeshRenderConfig> meshRenderGoDict; // 0x60
	System.Collections.Generic.Dictionary<System.Int64,System.UInt64> loadingMeshRenderGoMap; // 0x68
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.TreeData>> loadingRenderTreeDatas; // 0x70
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Manager.BlockId,WizardGames.Soc.SocClient.Manager.FindTreeResult> findResults; // 0x78
	System.Void Init(); // 0x06ac5d60
	System.Void CleanUp(); // 0x06ac5dc8
	System.Boolean IsOutsideTree(System.Int64 entityId); // 0x06ac605c
	UnityEngine.GameObject get_TreeTemplateRoot(); // 0x06ac611c
	WizardGames.Soc.Common.Unity.Construction.MeshRenderConfig GetMeshRenderConfig(System.Int64 templateId, System.Int32& state); // 0x06ac4bdc
	System.Void LoadMeshRenderConfigAsync(System.Int64 templateId, System.String path); // 0x06ac620c
	System.Void OnMeshRenderConfigLoadFinish(UnityEngine.GameObject obj, System.Object[] parameters); // 0x06ac6438
	System.Void AddLoadingTreeData(WizardGames.Soc.SocClient.Manager.TreeData treeData); // 0x06ac4e80
	System.Void OnTreeMeshRenderConfigLoadComplete(System.Int64 templateId, WizardGames.Soc.Common.Unity.Construction.MeshRenderConfig meshRenderConfig); // 0x06ac68cc
	System.Void CheckDisposeMeshRenderConfig(); // 0x06ac6a58
	System.Void SetTreeEntityGoMeshRendererEnable(System.Boolean enabled, UnityEngine.GameObject go); // 0x06ac6e4c
	System.Void AddEntityTree(System.Int64 treeEntityId, WizardGames.Soc.SocClient.Go.ClientTreeGo treeGo); // 0x06ac708c
	System.Void AddOrUpdateEntityTree(System.Int64 treeEntityId, WizardGames.Soc.SocClient.Go.ClientTreeGo treeGo); // 0x06ac7160
	System.Void RemoveEntityTree(System.Int64 treeEntityId); // 0x06ac75cc
	System.Void AddTrees(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.VisionTree> trees); // 0x06ac772c
	System.Void AddOrUpdateControlTree(System.Int64 treeEntityId, WizardGames.Soc.Common.SimpleCustom.VisionTree tree); // 0x06ac79f0
	System.Void RemoveControlTree(System.Int64 treeEntityId); // 0x06ac7d18
	WizardGames.Soc.SocClient.Manager.TreeControlBlockData FindBlockData(UnityEngine.Vector3 position, System.Boolean addIfNotPresent); // 0x06ac73e8
	WizardGames.Soc.SocClient.Manager.TreeControlBlockData FindBlockData(WizardGames.Soc.SocClient.Manager.BlockId blockId, System.Boolean addIfNotPresent); // 0x06ac7fb8
	WizardGames.Soc.SocClient.Manager.BlockId FindBlockId(UnityEngine.Vector3 position); // 0x06ac7e50
	System.Void OnFps1Update(); // 0x06ac8260
	System.Void UpdateView(); // 0x06ac82cc
	System.Void SortDirtyBlockDatas(); // 0x06ac8e90
	System.Void UpdateBlockData(); // 0x06ac8964
	System.Void GetShowBlocks(WizardGames.Soc.SocClient.Manager.BlockId sourceBlock); // 0x06ac8c14
	System.Void SetDirty(WizardGames.Soc.SocClient.Manager.TreeControlBlockData blockData); // 0x06ac74b4
	WizardGames.Soc.SocClient.Manager.TreeData GetTreeData(System.Int64 entityId); // 0x06ac904c
	WizardGames.Soc.SocClient.Manager.TreeData GetNearstTreeData(UnityEngine.Vector3 findPos, System.Collections.Generic.HashSet<System.Int64> templateIds, System.Single maxDistance, System.Boolean ignoreSafeArea); // 0x06ac9100
	WizardGames.Soc.SocClient.Manager.TreeData InternalFindTree(UnityEngine.Vector3 findPos, System.Collections.Generic.HashSet<System.Int64> templateIds, System.Single findDistance, System.Single maxDistance, System.Boolean ignoreSafeArea); // 0x06ac9200
	System.Boolean IsInSafeArea(UnityEngine.Vector3 pos); // 0x06ac98cc
	System.Void .ctor(); // 0x06ac999c
	static System.Void .cctor(); // 0x06ac9cec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrTreeControl.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Manager.MgrTreeControl.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Manager.TreeControlBlockData> <>9__42_0; // 0x8
	static System.Void .cctor(); // 0x06ac9dd8
	System.Void .ctor(); // 0x06ac9e3c
	System.Int32 <SortDirtyBlockDatas>b__42_0(WizardGames.Soc.SocClient.Manager.TreeControlBlockData item1, WizardGames.Soc.SocClient.Manager.TreeControlBlockData item2); // 0x06ac9ea4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.FindTreeResult : System.Object
{
	WizardGames.Soc.SocClient.Manager.TreeData treeData; // 0x10
	System.Single sqrMagnitude; // 0x18
	System.Void .ctor(); // 0x06ac9864
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUIConstructionDetailTips : WizardGames.Soc.Common.Manager.MgrBase
{
	
	System.Void OpenDetailTips(WizardGames.Soc.SocClient.Ui.ConstructionInfoData constructionInfoData, UnityEngine.Vector2 screenPos); // 0x06ac9f40
	System.Void .ctor(); // 0x06aca594
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUIConstructionDetailTips.<>c__DisplayClass0_0 : System.Object
{
	System.Int64 blueprintId; // 0x10
	System.Void .ctor(); // 0x06aca52c
	System.Boolean <OpenDetailTips>b__0(WizardGames.Soc.Common.Data.DataItem.ItemConfig value); // 0x06aca5fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.UnionGrowthRewardData> rewardDataLst; // 0x18
	System.Collections.Generic.SortedDictionary<System.UInt64,WizardGames.Soc.SocClient.Manager.UnionRankGroupData> curRankGroupDic; // 0x20
	System.Collections.Generic.SortedDictionary<System.UInt64,WizardGames.Soc.SocClient.Manager.UnionRankGroupData> lastRankGroupDic; // 0x28
	WizardGames.Soc.SocClient.Manager.UnionRankData curSelfRankData; // 0x30
	WizardGames.Soc.SocClient.Manager.UnionRankData lastSelfRankData; // 0x38
	System.Int64 lastMsgSeq; // 0x40
	System.Int32 lowSpeedPullCd; // 0x48
	System.UInt64 HighSpeedPullUnionId; // 0x50
	System.Int64 autoPullInGameChatMsgTimerId; // 0x58
	System.String PageApplication; // 0x60
	System.String PageBadgeSetting; // 0x68
	System.String PageChangeAnnouncement; // 0x70
	System.String PageCreate; // 0x78
	System.String PageInvitation; // 0x80
	System.String PageLog; // 0x88
	System.String PageMain; // 0x90
	System.String PageRecommend; // 0x98
	System.String LoaderIcon; // 0xa0
	System.String LoaderHomePage; // 0xa8
	System.String LoaderSettingPage; // 0xb0
	System.String LoaderMemberPage; // 0xb8
	System.String LoaderRewardPage; // 0xc0
	System.String LoaderWeekRankPage; // 0xc8
	WizardGames.Soc.SocClient.Ui.UnionInfo unionInfo; // 0xd0
	System.Boolean memberState; // 0xd8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UnionMember> members; // 0xe0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UnionInfo> recommendList; // 0xe8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UnionInvitation> invitationList; // 0xf0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UnionInfo> searchResult; // 0xf8
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.PresidentInfo> presidentDic; // 0x100
	System.Collections.Generic.List<System.UInt64> applicationIds; // 0x108
	System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.SocClient.RoleInfo> roleInfoDic; // 0x110
	WizardGames.Soc.SDK.SDKGroupRet groupInfo; // 0x118
	System.String GroupId; // 0x120
	WizardGames.Soc.SDK.SDKGroupRet groupRelation; // 0x128
	System.Single InputAlpha; // 0x130
	System.Int32 MEMBER_CACHE_CD; // 0x134
	System.Single memberCacheTime; // 0x138
	System.Int32 UNIONINFO_CACHE_CD; // 0x13c
	System.Single unionInfoCacheTime; // 0x140
	SocLogger log; // 0x148
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ApplicatonPlayerInfo> applicationList; // 0x150
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UnionLogInfo> unionLogList; // 0x158
	System.Collections.Generic.List<System.Int32> badgeValue; // 0x160
	System.Collections.Generic.List<System.Int32> badgeValueTmp; // 0x168
	System.String CHANGE_NAME; // 0x170
	System.String CHANGE_ANNOUNCEMENT; // 0x178
	System.String CHANGE_HIREANNOUNCEMENT; // 0x180
	System.String CHANGE_BADGE; // 0x188
	System.String JOIN; // 0x190
	System.Boolean groupSign; // 0x198
	System.Boolean groupState; // 0x199
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Manager.MgrUnion.CachedUnionInfo> localCache; // 0x1a0
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Manager.MgrUnion.CachedUnionInfo> tempLocalCache; // 0x1a8
	System.Void RefreshGrowthReward(); // 0x06aca6d0
	System.Void GetGrowthRewardData(System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.UnionGrowthRewardData>& list); // 0x06aca9e8
	System.Void ClearRank(); // 0x06acaabc
	System.Boolean IsCurRankDataValid(System.UInt64 startNum); // 0x06acae60
	System.Boolean IsLastRankDataValid(System.UInt64 startNum); // 0x06acb23c
	System.Void GetCurrentWeekRankData(System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.UnionRankData>& list, System.UInt64 startNum); // 0x06acb504
	System.Void GetLastWeekRankData(System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.UnionRankData>& list, System.UInt64 startNum); // 0x06acb734
	System.Void ReqCurRankData(System.UInt64 startNum); // 0x06acb964
	System.Void ReqLastRankData(System.UInt64 startNum); // 0x06acc130
	System.Void PullMsg(); // 0x06acc900
	System.Void PullMsgCallBack(System.String ingameGroupId, System.Collections.Generic.List<WizardGames.Soc.SDK.InGameMsgContent> msgs); // 0x06accbcc
	System.Void UpdateCacheMsgs(System.UInt64 unionID, System.Collections.Generic.List<WizardGames.Soc.SDK.InGameMsgContent> msgs); // 0x06accde4
	System.Void InitAutoPullInGameChatMsgTimer(); // 0x055049cc
	System.Void ClearAutoPullInGameChatMsgTimer(); // 0x06acd23c
	System.Void DoAutoPullChatMsg(System.Int64 timerId, System.Object _, System.Boolean delete); // 0x06acd350
	System.Void ForcePullAllTribeMsg(); // 0x06acd544
	System.Void SendAnnouncementToUnion(System.String content); // 0x06acd63c
	System.Void SendNoticeToUnion(System.String content); // 0x06acd864
	System.Void AddUnionMemberInGame(System.String inGameGroupID, System.String roleId); // 0x06acd908
	System.Void RemoveUnionMemberInGame(System.String inGameGroupID, System.String roleId); // 0x06acd9ec
	System.Void DestoryUnionInGame(System.String inGameGroupID); // 0x06acdad0
	System.Void Init(); // 0x06acdbac
	System.Void Destroy(); // 0x06acdc14
	System.Void OnAccountLogined(); // 0x055049cc
	System.Void OnAccountLogout(); // 0x06acde90
	System.Void ReloadCommunity(); // 0x055049cc
	System.Void ResetAll(); // 0x06acdf00
	WizardGames.Soc.SocClient.Ui.UnionInfo GetUnionInfo(); // 0x06ace26c
	System.Void SetUnionInfo(WizardGames.Soc.SocClient.Ui.UnionInfo info); // 0x06ace2d0
	System.Void ClearUnionInfo(); // 0x06ace400
	System.Void GetPlayerUnionInfo(System.Action<WizardGames.Soc.SocClient.Ui.UnionInfo> callback, System.Boolean force); // 0x0552af28
	System.Void GetPlayerUnionInfoByCD(System.Action<WizardGames.Soc.SocClient.Ui.UnionInfo> callback); // 0x06ace698
	System.Void GetPlayerMembers(System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UnionMember>> callback); // 0x06ace740
	System.Void ForceUpdatePlayerMembers(); // 0x06aceb94
	System.Void GetPlayerMembersByCD(); // 0x06acec00
	System.Void SetPlayerMembers(SimpleJSON.JSONNode info); // 0x06acec98
	WizardGames.Soc.SocClient.Ui.UnionMember GetMemberByRoleID(System.UInt64 roleID); // 0x06acef28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UnionMember> GetMembers(); // 0x06acf088
	WizardGames.Soc.SocClient.Ui.UnionMember GetMyMemberInfo(); // 0x06acf0ec
	System.Boolean IsMemberFull(); // 0x06acf19c
	System.Void GetPlayerRoleInfo(System.UInt64 roleId, System.Action<WizardGames.Soc.SocClient.RoleInfo> callback); // 0x06acf2a4
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UnionInfo> GetSearchResult(); // 0x06acf46c
	System.Void SetRecommendList(SimpleJSON.JSONNode info, System.Boolean clear); // 0x06acf4d0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UnionInvitation> GetInvitationList(); // 0x06acf7b8
	System.Void SetInvitationList(SimpleJSON.JSONNode info, System.Boolean clear); // 0x06acf81c
	System.Void RemoveInvitationById(System.UInt64 id); // 0x06acfb34
	System.Void ClearInvitation(); // 0x06acfca0
	System.Void SetSearchResult(SimpleJSON.JSONNode info); // 0x06acfd78
	System.Boolean GetModifyPermission(WizardGames.Soc.SocClient.Ui.EUnionModifyPermission type); // 0x06acff4c
	System.Collections.Generic.List<System.Int32> GetBadgeValue(); // 0x06ad0000
	System.Void SetBadgeValue(System.Collections.Generic.List<System.Int32> val); // 0x06ad0064
	System.Collections.Generic.List<System.Int32> GetBadgeValueTmp(); // 0x06ad00f4
	System.Void SetBadgeValueTmp(System.Collections.Generic.List<System.Int32> val); // 0x06ad0158
	System.Void InitBadgeDefaultValue(); // 0x06ad01d8
	System.Void SetLocalData(System.String key, System.Int32 value); // 0x06ad026c
	System.Int32 GetLocalData(System.String key); // 0x06ad0400
	System.Void SetChangeNameTime(); // 0x06ad056c
	System.Int32 GetChangeNameLastTime(); // 0x06ad0608
	System.Void SetChangeAnnouncementTime(); // 0x06ad0670
	System.Int32 GetChangeAnnouncemntTime(); // 0x06ad070c
	System.Void SetChangeHireAnnouncementTime(); // 0x06ad0774
	System.Int32 GetChangeHireAnnouncemntTime(); // 0x06ad0810
	System.Void SetChangeBadgeTime(); // 0x06ad0878
	System.Int32 GetChangeBadgeTime(); // 0x06ad0914
	System.Int32 GetJoinTime(); // 0x06ad097c
	System.Void SetJoinTime(); // 0x06ad09e4
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UnionInfo> FilterRecommendList(System.Boolean byReview, System.Boolean byCondition); // 0x06ad0a80
	System.Void PresidentCache(WizardGames.Soc.SocClient.Ui.PresidentInfo info); // 0x06ad0c08
	WizardGames.Soc.SocClient.Ui.PresidentInfo GetPresident(System.UInt64 id); // 0x06ad0cac
	System.String[] GetAllInvitationIds(); // 0x06ad0d7c
	System.String[] GetAllMemberIds(); // 0x06ad1084
	System.Void IsUnionMember(System.String roleID, System.Action<System.Boolean> action); // 0x06ad138c
	System.Void IsUnionTeam(System.Collections.Generic.List<System.String> roleIDs, System.Action<System.Boolean> action); // 0x06ad1628
	System.Void ApplyCacheClear(); // 0x06ace164
	System.Void ApplyCacheAdd(System.UInt64 communityId); // 0x06ad1868
	System.Boolean ApplyIsExisted(System.UInt64 communityId); // 0x06ad1954
	System.Void ClearGroup(); // 0x06ace1e8
	System.Boolean GetGroupState(); // 0x06ad1ad8
	System.Void SetGroupState(System.Boolean state); // 0x06ad1b3c
	System.Void SetGroupInfo(WizardGames.Soc.SDK.SDKGroupRet info); // 0x06ad1c00
	System.Boolean IsInGroup(); // 0x06ad1cd8
	System.Void SetGroupRelation(WizardGames.Soc.SDK.SDKGroupRet info); // 0x06ad1d58
	System.Void SendMessage(System.String content, System.String msgMeta, System.Boolean isVoice); // 0x06acd6e0
	System.Void JumpToUnionMain(); // 0x06ad1ea8
	System.Void ReqError(SimpleJSON.JSONNode error, System.String title); // 0x06ad2018
	System.Void ReqCreateCommunity(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, WizardGames.Soc.SocClient.Ui.UnionCreateOptions data, System.Action<SimpleJSON.JSONNode> callback); // 0x06ad227c
	System.Void ReqUpdateCommunityInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, WizardGames.Soc.SocClient.Ui.UnionCreateOptions data, System.Action<SimpleJSON.JSONNode> callback); // 0x06ad29bc
	System.Void ReqCurrentPlayerCommunityInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action<WizardGames.Soc.SocClient.Ui.UnionInfo> callback, System.Boolean req); // 0x05510620
	System.Void ReqPlayerCommunityInfoByRoleId(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String roleId, System.Action<WizardGames.Soc.SocClient.Ui.UnionInfo> callback); // 0x06ad3380
	System.Void ReqCommunityMembersInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.UInt64 communityID, System.Action<SimpleJSON.JSONNode> callback); // 0x06ace8d4
	System.Void ReqRequestJoinCommunity(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.UInt64 communityID, System.Action<SimpleJSON.JSONNode> callback); // 0x06ad35ec
	System.Void ReqAppointCommunityIdentity(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String communityID, WizardGames.Soc.SocClient.Ui.EUnionIdentityType identity, WizardGames.Soc.SocClient.Ui.EUnionOperationType operation, System.String roleID, System.Action callback); // 0x06ad38ac
	System.Void ReqTransferpresident(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String roleID, System.Action callback); // 0x06ad3c40
	System.Void ReqBatchRejectCommunityInvitation(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action callback); // 0x06ad3efc
	System.Void ReqGetInvitations(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action callback); // 0x06ad4118
	System.DateTime ConvertTimestampToDate(System.Int64 timeStamp); // 0x06ad4334
	System.Void ReqCommunityEventLog(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String communityID, System.Action callback); // 0x06ad4434
	System.Void ReqGetMemberApplications(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action callback); // 0x06ad46e0
	System.Void ReqDetailInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String[] roldIds, System.Action<SimpleJSON.JSONArray> callback); // 0x06ad4a04
	System.Void DeleteDealtApplicationByRoleId(System.String roleId); // 0x06ad4b64
	System.Void ReqBatchRejectCommunityApplication(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action callback); // 0x06ad4cd4
	System.Void ReqProcessApplication(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String roleID, System.Int32 accept, System.Action callback); // 0x06ad5008
	System.Void ReqGetRecommendCommunityList(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action<SimpleJSON.JSONNode> callback); // 0x06ad53c4
	System.Void ReqSearchCommunityInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String word, System.Action<SimpleJSON.JSONNode> callback, System.Action errorCallback); // 0x06ad55e0
	System.Void ReqInviteCommunityMember(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String communityId, System.String roleId, System.Action<SimpleJSON.JSONNode> callback); // 0x06ad5894
	System.Void ReqKickCommunityMember(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String roleName, System.String roleId, System.Action callback); // 0x06ad5b94
	System.Void ReqLeaveCommunity(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String communityName, System.Action callback); // 0x06ad5f14
	System.Void ReqProcessInvitation(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Int32 accept, System.UInt64 communityId, System.UInt64 roleId, System.Action callback); // 0x06ad61f4
	System.Void OnAccountEnterLobby(); // 0x06ad6558
	System.Void InitUnionData(); // 0x06ad65d0
	System.Int32 HaveInviteMsg(); // 0x06ad66fc
	System.Int32 HaveApplyMsg(); // 0x06ad67bc
	System.Void ReqBatchCommunityInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Collections.Generic.List<System.String> ids, System.Action<SimpleJSON.JSONArray> callback, System.Boolean immediateRequest); // 0x06ad68d0
	System.Void CheckCacheDataDead(); // 0x06ad7094
	System.Void OnJoinCommunity(SimpleJSON.JSONNode jsonNode); // 0x05523a54
	System.Void OnKickedFromCommunity(SimpleJSON.JSONNode jsonNode); // 0x06ad74a0
	System.Void OnCommunityInvitation(SimpleJSON.JSONNode jsonNode); // 0x06ad76e8
	System.Void OnCommunityReceiveNewApplication(SimpleJSON.JSONNode jsonNode); // 0x06ad77ac
	System.Void OnCommunityIndentityChange(SimpleJSON.JSONNode jsonNode); // 0x06ad7870
	System.Void .ctor(); // 0x06ad7c00
	System.Void <OnJoinCommunity>b__176_0(WizardGames.Soc.SocClient.Ui.UnionInfo res); // 0x06ad8480
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.CachedUnionInfo : System.Object
{
	SimpleJSON.JSONNode unionInfo; // 0x10
	System.Single cachedTime; // 0x18
	System.Void .ctor(); // 0x06ad871c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass118_0 : System.Object
{
	System.Boolean byReview; // 0x10
	System.Boolean byCondition; // 0x11
	System.Int32 roleLevel; // 0x14
	System.Void .ctor(); // 0x06ad8784
	System.Boolean <FilterRecommendList>b__0(WizardGames.Soc.SocClient.Ui.UnionInfo v); // 0x06ad87ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass124_0 : System.Object
{
	System.String roleID; // 0x10
	System.Action<System.Boolean> action; // 0x18
	System.Void .ctor(); // 0x06ad8934
	System.Void <IsUnionMember>b__0(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UnionMember> lst); // 0x06ad899c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass125_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x10
	System.Collections.Generic.List<System.String> roleIDs; // 0x18
	System.Action<System.Boolean> action; // 0x20
	System.Void .ctor(); // 0x06ad8b24
	System.Void <IsUnionTeam>b__0(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UnionMember> lst); // 0x06ad8b8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass128_0 : System.Object
{
	System.UInt64 communityId; // 0x10
	System.Void .ctor(); // 0x06ad8cc8
	System.Boolean <ApplyIsExisted>b__0(System.UInt64 v); // 0x06ad8d30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass13_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x10
	System.UInt64 startNum; // 0x18
	System.UInt64 stopNum; // 0x20
	System.Void .ctor(); // 0x06ad8db0
	System.Void <ReqCurRankData>b__0(SimpleJSON.JSONNode ret); // 0x06ad8e18
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass147_0 : System.Object
{
	System.Action<SimpleJSON.JSONNode> callback; // 0x10
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x18
	System.Void .ctor(); // 0x06ad9c00
	System.Void <ReqCreateCommunity>b__0(SimpleJSON.JSONNode info); // 0x06ad9c68
	System.Void <ReqCreateCommunity>b__1(SimpleJSON.JSONNode error); // 0x06ad9d2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass148_0 : System.Object
{
	System.Action<SimpleJSON.JSONNode> callback; // 0x10
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x18
	System.Void .ctor(); // 0x06ad9dcc
	System.Void <ReqUpdateCommunityInfo>b__0(SimpleJSON.JSONNode info); // 0x06ad9e34
	System.Void <ReqUpdateCommunityInfo>b__1(SimpleJSON.JSONNode error); // 0x06ad9ef8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass149_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x10
	System.Action<WizardGames.Soc.SocClient.Ui.UnionInfo> callback; // 0x18
	System.Void .ctor(); // 0x06ad9f98
	System.Void <ReqCurrentPlayerCommunityInfo>b__0(WizardGames.Soc.SocClient.Ui.UnionInfo info); // 0x06ada000
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass14_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x10
	System.UInt64 startNum; // 0x18
	System.UInt64 stopNum; // 0x20
	System.Void .ctor(); // 0x06ada0a4
	System.Void <ReqLastRankData>b__0(SimpleJSON.JSONNode ret); // 0x06ada10c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass150_0 : System.Object
{
	System.Action<WizardGames.Soc.SocClient.Ui.UnionInfo> callback; // 0x10
	System.Void .ctor(); // 0x06ada4d8
	System.Void <ReqPlayerCommunityInfoByRoleId>b__0(SimpleJSON.JSONNode info); // 0x06ada540
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass151_0 : System.Object
{
	System.Action<SimpleJSON.JSONNode> callback; // 0x10
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x18
	System.Void .ctor(); // 0x06ada668
	System.Void <ReqCommunityMembersInfo>b__0(SimpleJSON.JSONNode info); // 0x06ada6d0
	System.Void <ReqCommunityMembersInfo>b__1(SimpleJSON.JSONNode error); // 0x06ada794
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass152_0 : System.Object
{
	System.Action<SimpleJSON.JSONNode> callback; // 0x10
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x18
	System.Void .ctor(); // 0x06ada834
	System.Void <ReqRequestJoinCommunity>b__0(SimpleJSON.JSONNode info); // 0x06ada89c
	System.Void <ReqRequestJoinCommunity>b__1(SimpleJSON.JSONNode error); // 0x06ada960
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass153_0 : System.Object
{
	System.Action callback; // 0x10
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x18
	System.Void .ctor(); // 0x06adaa00
	System.Void <ReqAppointCommunityIdentity>b__0(SimpleJSON.JSONNode info); // 0x06adaa68
	System.Void <ReqAppointCommunityIdentity>b__1(SimpleJSON.JSONNode error); // 0x06adab00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass154_0 : System.Object
{
	System.Action callback; // 0x10
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x18
	System.Void .ctor(); // 0x06adaba0
	System.Void <ReqTransferpresident>b__0(SimpleJSON.JSONNode info); // 0x06adac08
	System.Void <ReqTransferpresident>b__1(SimpleJSON.JSONNode error); // 0x06adaca0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass155_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x06adad40
	System.Void <ReqBatchRejectCommunityInvitation>b__0(SimpleJSON.JSONNode info); // 0x06adada8
	System.Void <ReqBatchRejectCommunityInvitation>b__1(SimpleJSON.JSONNode error); // 0x06adae54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass156_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x06adaef4
	System.Void <ReqGetInvitations>b__0(SimpleJSON.JSONNode info); // 0x06adaf5c
	System.Void <ReqGetInvitations>b__1(SimpleJSON.JSONNode error); // 0x06adb048
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass158_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x06adb0e8
	System.Void <ReqCommunityEventLog>b__0(SimpleJSON.JSONNode info); // 0x06adb150
	System.Void <ReqCommunityEventLog>b__1(SimpleJSON.JSONNode error); // 0x06adb9d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass159_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x10
	WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule; // 0x18
	System.Action callback; // 0x20
	System.Action<SimpleJSON.JSONArray> <>9__2; // 0x28
	System.Void .ctor(); // 0x06adba78
	System.Void <ReqGetMemberApplications>b__0(SimpleJSON.JSONNode res); // 0x06adbae0
	System.Void <ReqGetMemberApplications>b__2(SimpleJSON.JSONArray jsonArray); // 0x06adbd00
	System.Void <ReqGetMemberApplications>b__1(SimpleJSON.JSONNode error); // 0x06adc228
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass160_0 : System.Object
{
	System.Action<SimpleJSON.JSONArray> callback; // 0x10
	System.Void .ctor(); // 0x06adc2c8
	System.Void <ReqDetailInfo>b__0(SimpleJSON.JSONArray jsonArray); // 0x06adc330
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass162_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x06adc3bc
	System.Void <ReqBatchRejectCommunityApplication>b__0(SimpleJSON.JSONNode info); // 0x06adc424
	System.Void <ReqBatchRejectCommunityApplication>b__1(SimpleJSON.JSONNode error); // 0x06adc55c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass163_0 : System.Object
{
	System.Action callback; // 0x10
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x18
	System.Void .ctor(); // 0x06adc5fc
	System.Void <ReqProcessApplication>b__0(SimpleJSON.JSONNode info); // 0x06adc664
	System.Void <ReqProcessApplication>b__1(SimpleJSON.JSONNode error); // 0x06adc6fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass164_0 : System.Object
{
	System.Action<SimpleJSON.JSONNode> callback; // 0x10
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x18
	System.Void .ctor(); // 0x06adc79c
	System.Void <ReqGetRecommendCommunityList>b__0(SimpleJSON.JSONNode info); // 0x06adc804
	System.Void <ReqGetRecommendCommunityList>b__1(SimpleJSON.JSONNode error); // 0x06adc8c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass165_0 : System.Object
{
	System.Action<SimpleJSON.JSONNode> callback; // 0x10
	System.Action errorCallback; // 0x18
	System.Void .ctor(); // 0x06adc968
	System.Void <ReqSearchCommunityInfo>b__0(SimpleJSON.JSONNode info); // 0x06adc9d0
	System.Void <ReqSearchCommunityInfo>b__1(SimpleJSON.JSONNode error); // 0x06adca94
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass166_0 : System.Object
{
	System.Action<SimpleJSON.JSONNode> callback; // 0x10
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x18
	System.Void .ctor(); // 0x06adcc50
	System.Void <ReqInviteCommunityMember>b__0(SimpleJSON.JSONNode info); // 0x06adccb8
	System.Void <ReqInviteCommunityMember>b__1(SimpleJSON.JSONNode error); // 0x06adcd7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass167_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x06adce1c
	System.Void <ReqKickCommunityMember>b__0(SimpleJSON.JSONNode info); // 0x06adce84
	System.Void <ReqKickCommunityMember>b__1(SimpleJSON.JSONNode error); // 0x06add01c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass168_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x10
	System.String communityName; // 0x18
	System.Action callback; // 0x20
	System.Void .ctor(); // 0x06add0bc
	System.Void <ReqLeaveCommunity>b__0(SimpleJSON.JSONNode info); // 0x06add124
	System.Void <ReqLeaveCommunity>b__1(SimpleJSON.JSONNode error); // 0x06add348
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass169_0 : System.Object
{
	System.Action callback; // 0x10
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x18
	System.Void .ctor(); // 0x06add3e8
	System.Void <ReqProcessInvitation>b__0(SimpleJSON.JSONNode info); // 0x06add450
	System.Void <ReqProcessInvitation>b__1(SimpleJSON.JSONNode error); // 0x06add4e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass174_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x10
	System.Action<SimpleJSON.JSONArray> callback; // 0x18
	SimpleJSON.JSONArray oldJsonArray; // 0x20
	System.Collections.Generic.Dictionary<System.String,System.Int32> unionIdMap; // 0x28
	System.Void .ctor(); // 0x06add588
	System.Void <ReqBatchCommunityInfo>b__0(SimpleJSON.JSONNode res); // 0x06add5f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass74_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x10
	System.Action<WizardGames.Soc.SocClient.Ui.UnionInfo> callback; // 0x18
	System.Void .ctor(); // 0x06addb1c
	System.Void <GetPlayerUnionInfo>b__0(WizardGames.Soc.SocClient.Ui.UnionInfo info); // 0x06addb84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass76_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x10
	System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UnionMember>> callback; // 0x18
	System.Void .ctor(); // 0x06addc28
	System.Void <GetPlayerMembers>b__0(SimpleJSON.JSONNode info); // 0x06addc90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass84_0 : System.Object
{
	System.UInt64 roleId; // 0x10
	WizardGames.Soc.SocClient.Manager.MgrUnion <>4__this; // 0x18
	System.Action<WizardGames.Soc.SocClient.RoleInfo> callback; // 0x20
	System.Void .ctor(); // 0x06addd5c
	System.Void <GetPlayerRoleInfo>b__0(Config.LobbyRoleInfo userInfo); // 0x06adddc4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass87_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UnionInfo item; // 0x10
	System.Void .ctor(); // 0x06ade040
	System.Boolean <SetRecommendList>b__0(WizardGames.Soc.SocClient.Ui.UnionInfo vv); // 0x06ade0a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass89_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UnionInvitation item; // 0x10
	System.Void .ctor(); // 0x06ade1bc
	System.Boolean <SetInvitationList>b__0(WizardGames.Soc.SocClient.Ui.UnionInvitation vv); // 0x06ade224
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUnion.<>c__DisplayClass90_0 : System.Object
{
	System.UInt64 id; // 0x10
	System.Void .ctor(); // 0x06ade3d8
	System.Boolean <RemoveInvitationById>b__0(WizardGames.Soc.SocClient.Ui.UnionInvitation v); // 0x06ade440
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.UnionGrowthRewardData : System.Object
{
	System.String iconPath; // 0x10
	System.String iconBgPath; // 0x18
	System.String desc; // 0x20
	System.Int32 exp; // 0x28
	System.Int32 level; // 0x2c
	System.Void Refresh(WizardGames.Soc.Common.Data.Play.OBJCommunityLevel cfg, System.Int32 exp); // 0x06ade560
	System.Void .ctor(); // 0x06ade618
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.UnionRankData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	WizardGames.Soc.SocClient.Manager.UnionRankGroupData groupData; // 0x10
	System.Int64 rank; // 0x18
	System.Collections.Generic.List<System.Int32> icons; // 0x20
	System.String name; // 0x28
	System.Int32 activeScore; // 0x30
	System.UInt32 level; // 0x34
	System.Int32 memberCount; // 0x38
	System.UInt64 communityID; // 0x40
	System.UInt64 presidentID; // 0x48
	System.Boolean Exist; // 0x50
	System.Void Refresh(System.Int32 rank, SimpleJSON.JSONNode node, WizardGames.Soc.SocClient.Manager.UnionRankGroupData groupData); // 0x06ad981c
	System.UInt64 get_GroupFinalNumber(); // 0x06ade680
	System.Void OnGet(); // 0x06ade750
	System.Void OnRelease(); // 0x06ade7b0
	System.Void OnDestroy(); // 0x06ade874
	System.Void .ctor(); // 0x06ade8d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.UnionRankGroupData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.UnionRankData> rankLst; // 0x10
	System.String timeTag; // 0x18
	System.Int64 reqTimeStamp; // 0x20
	System.Int32 startNum; // 0x28
	System.Int32 endNum; // 0x2c
	System.Collections.Generic.HashSet<System.UInt64> communityIDSet; // 0x30
	System.Void Refresh(System.Int32 startNum, System.Int32 length, SimpleJSON.JSONNode ret); // 0x06ad91e4
	System.Void Trim(WizardGames.Soc.SocClient.Manager.UnionRankGroupData groupInfo); // 0x06ad96b0
	System.Boolean Contains(System.UInt64 id); // 0x06ade988
	System.UInt64 get_FinalNumber(); // 0x06ade6ec
	System.Void OnGet(); // 0x06adea24
	System.Void OnRelease(); // 0x06adea84
	System.Void OnDestroy(); // 0x06adecbc
	System.Void .ctor(); // 0x06aded1c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.EBattleButtonId : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.EBattleButtonId Setting = 1;
	static WizardGames.Soc.SocClient.Manager.EBattleButtonId Craft = 2;
	static WizardGames.Soc.SocClient.Manager.EBattleButtonId Bag = 3;
	static WizardGames.Soc.SocClient.Manager.EBattleButtonId Tech = 4;
	static WizardGames.Soc.SocClient.Manager.EBattleButtonId MainWeapon = 11;
	static WizardGames.Soc.SocClient.Manager.EBattleButtonId SecondWeapon = 12;
	static WizardGames.Soc.SocClient.Manager.EBattleButtonId ChooseWeapon = 13;
	static WizardGames.Soc.SocClient.Manager.EBattleButtonId Consumables = 21;
	static WizardGames.Soc.SocClient.Manager.EBattleButtonId UniversalProps = 22;
	static WizardGames.Soc.SocClient.Manager.EBattleButtonId Missile = 23;
	static WizardGames.Soc.SocClient.Manager.EBattleButtonId QuickChatNearby = 24;
	static WizardGames.Soc.SocClient.Manager.EBattleButtonId QuickChatBattle = 25;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.EBattleButtonGroup : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.EBattleButtonGroup Btn = 1;
	static WizardGames.Soc.SocClient.Manager.EBattleButtonGroup Weapon = 2;
	static WizardGames.Soc.SocClient.Manager.EBattleButtonGroup ShortCut = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrUploadLog : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Int64 timerID; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.SimpleCustom.BattleButonTLogInfo> battleBtnId2LogInfo; // 0x20
	static System.String get_url(); // 0x06adee54
	System.Void Init(); // 0x06adeee0
	System.Threading.Tasks.Task OnEnterWorld(); // 0x054e7844
	System.Threading.Tasks.Task OnExitWorld(); // 0x06adf150
	System.Void RecordClick(WizardGames.Soc.SocClient.Manager.EBattleButtonId battleBtnId, WizardGames.Soc.SocClient.Manager.EBattleButtonGroup battleBtnGroup); // 0x06adf258
	System.Void Tick(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x06adf6b0
	System.Void UploadAllBattleBtnTLogBeforeExitWorld(); // 0x06adf748
	System.Void UploadBattleBtnTLog(System.Int32 battleBtnId); // 0x06adf3d0
	static System.Void UploadClientLogByWebRequest(System.String logName, System.String data, System.Boolean includeBaseParam); // 0x06adf800
	static System.String CombineBaseStr(); // 0x06adfcfc
	System.Void .ctor(); // 0x06ae02c4
	static System.Void .cctor(); // 0x06ae0334
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrWireControl : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Log; // 0x0
	static System.Boolean isOpenDebug; // 0x8
	static System.Int32 maxBlockDelta; // 0xc
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Manager.WireData> allWireDataDic; // 0x18
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Manager.BlockId,WizardGames.Soc.SocClient.Manager.WireBlockData> AllWireBlockDataDic; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.WireBlockData> dirtyBlockDataList; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.BlockId> oldBlocks; // 0x30
	System.Boolean initPlayerPos; // 0x38
	UnityEngine.Vector3 oldPlayerPos; // 0x3c
	WizardGames.Soc.SocClient.Manager.BlockId lastPlayerBlockId; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.BlockId> needRemoveBlocks; // 0x58
	System.Void CleanUp(); // 0x06ae0408
	System.Void OnFps1Update(); // 0x06ae0844
	System.Void OnAfterUpdate(); // 0x06ae1078
	System.Void UpdateView(System.Boolean isForceUpdate, System.Boolean isForceUpdateBlockDataDic); // 0x06ae08b8
	System.Void UpdateBlockDataDic(System.Boolean isForceUpdateisForceUpdateBlockDataDic); // 0x06ae1238
	System.Void GetShowBlocks(WizardGames.Soc.SocClient.Manager.BlockId sourceBlock); // 0x06ae1a08
	System.Void UpdateBlockData(); // 0x06ae0f04
	WizardGames.Soc.SocClient.Manager.WireBlockData FindBlockData(UnityEngine.Vector3 position, System.Boolean addIfNotPresent); // 0x06ae23cc
	WizardGames.Soc.SocClient.Manager.WireBlockData FindBlockData(WizardGames.Soc.SocClient.Manager.BlockId blockId, System.Boolean addIfNotPresent); // 0x06ae1604
	System.Void AddToDirtyBlockList(WizardGames.Soc.SocClient.Manager.WireBlockData wireBlockData); // 0x06ae18d8
	WizardGames.Soc.SocClient.Manager.BlockId FindBlockId(UnityEngine.Vector3 position); // 0x06ae10d8
	System.Void AddOrUpdateWire(System.String wireInstId, UnityEngine.Vector3 inputPos, UnityEngine.Vector3 outputPos, UnityEngine.GameObject wireGo, System.Int64 inputEntityId, System.Int64 outputEntityId); // 0x06ae25a4
	System.Void RemoveWire(System.String wireInstId); // 0x06ae2884
	System.Void .ctor(); // 0x06ae29dc
	static System.Void .cctor(); // 0x06ae2bbc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.WireData : System.Object
{
	System.String instId; // 0x10
	UnityEngine.GameObject instGo; // 0x18
	System.Int64 outputEntityId; // 0x20
	System.Int64 inputEntityId; // 0x28
	UnityEngine.Vector3 outputPos; // 0x30
	UnityEngine.Vector3 inputPos; // 0x3c
	UnityEngine.Vector3 nearPlayerPos; // 0x48
	WizardGames.Soc.SocClient.Manager.BlockId curBlockId; // 0x54
	System.Void UpdateNearPlayerPos(); // 0x06ae1cf4
	System.Void SetWireState(System.Boolean isState); // 0x06ae2ca8
	System.Void Clear(); // 0x06ae2d7c
	System.Void .ctor(); // 0x06ae281c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.WireBlockData : System.Object
{
	WizardGames.Soc.SocClient.Manager.BlockId blockId; // 0x10
	System.Boolean showState; // 0x1c
	System.Boolean isAllTreeDirty; // 0x1d
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Manager.WireData> WireDic; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.WireData> DirtyWireList; // 0x28
	System.Void Show(); // 0x06ae1c84
	System.Void Hide(); // 0x06ae1868
	System.Void AddOrUpdateWire(WizardGames.Soc.SocClient.Manager.WireData wireData); // 0x06ae2090
	System.Void RemoveWire(WizardGames.Soc.SocClient.Manager.WireData wireData); // 0x06ae1f60
	System.Void RefreshBlockData(); // 0x06ae2178
	System.Void AddToDirtyList(WizardGames.Soc.SocClient.Manager.WireData wireData); // 0x06ae2e6c
	System.Void RefreshWireData(WizardGames.Soc.SocClient.Manager.WireData wireData); // 0x06ae2f9c
	System.Void Clear(); // 0x06ae061c
	System.Void .ctor(); // 0x06ae2498
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.ReconnectDataSyncManager : System.Object
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.SocClient.Manager.ReconnectDataSyncManager <Instance>k__BackingField; // 0x8
	System.Collections.Generic.HashSet<System.Int64> toDeleteEntities; // 0x10
	System.Collections.Generic.List<System.Int64> removeEntityIds; // 0x18
	System.Int64 removeEntityTimerId; // 0x20
	static WizardGames.Soc.SocClient.Manager.ReconnectDataSyncManager get_Instance(); // 0x06ae305c
	static System.Void set_Instance(WizardGames.Soc.SocClient.Manager.ReconnectDataSyncManager value); // 0x06ae30e4
	System.Void Reset(); // 0x06ae3178
	System.Void Start(); // 0x06ae3280
	System.Void EntityResynced(System.Int64 entityId); // 0x06ae3888
	System.Void RemoveEntityInRange(); // 0x06ae39a4
	static System.Void Restart(); // 0x06ae45ec
	System.Void .ctor(); // 0x06ae4864
	static System.Void .cctor(); // 0x06ae4918
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.ReconnectDataSyncManager.<>c__DisplayClass11_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.ReconnectDataSyncManager <>4__this; // 0x10
	System.Int64 cleanUpDelay; // 0x18
	System.Void .ctor(); // 0x06ae3820
	System.Void <Start>b__0(System.Int64 _, System.Object _, System.Boolean _); // 0x06ae49ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MarqueeData : System.Object
{
	System.String _id; // 0x10
	System.String _content; // 0x18
	System.Int32 _priorityLevel; // 0x20
	System.Int64 _endTimeSec; // 0x28
	System.String get_Id(); // 0x06ae5590
	System.String get_Content(); // 0x06ae55f4
	System.Int32 get_PriorityLevel(); // 0x06ae5658
	System.Int64 get_EndTimeSec(); // 0x06ae56bc
	System.Void .ctor(System.String content, System.Int32 priorityLevel); // 0x06ae5720
	System.Void .ctor(System.String id, System.String content, System.Int32 priorityLevel, System.Int64 endTimeSec); // 0x06ae57d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrMarquee : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Log; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.MarqueeData> marqueeList; // 0x18
	System.Void AddMarqueeInfo(SimpleJSON.JSONNode jsonNode); // 0x06ae589c
	System.Void DeleteMarqueeInfo(SimpleJSON.JSONNode jsonNode); // 0x06ae5bf0
	System.Void AddMarqueeInfo(System.String content, System.Int32 priorityLevel, System.Int32 repeat); // 0x06ae5e48
	System.Void AddMarqueeInfo(WizardGames.Soc.SocClient.Manager.MarqueeData marqueeData); // 0x06ae5afc
	WizardGames.Soc.SocClient.Manager.MarqueeData GetMarqueeInfo(); // 0x06ae5f0c
	System.Void RemoveById(System.String id); // 0x06ae5d08
	System.Void .ctor(); // 0x06ae627c
	static System.Void .cctor(); // 0x06ae6330
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrMarquee.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Manager.MgrMarquee.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.SocClient.Manager.MarqueeData,System.Int32> <>9__6_1; // 0x8
	static System.Void .cctor(); // 0x06ae6404
	System.Void .ctor(); // 0x06ae6468
	System.Int32 <GetMarqueeInfo>b__6_1(WizardGames.Soc.SocClient.Manager.MarqueeData m); // 0x06ae64d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrMarquee.<>c__DisplayClass6_0 : System.Object
{
	System.Int64 nowSec; // 0x10
	System.Void .ctor(); // 0x06ae61ac
	System.Boolean <GetMarqueeInfo>b__0(WizardGames.Soc.SocClient.Manager.MarqueeData m); // 0x06ae659c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrMarquee.<>c__DisplayClass8_0 : System.Object
{
	System.String id; // 0x10
	System.Void .ctor(); // 0x06ae6214
	System.Boolean <RemoveById>b__0(WizardGames.Soc.SocClient.Manager.MarqueeData m); // 0x06ae66b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrSocMemoryProfiler : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Logger; // 0x0
	System.Collections.Generic.Dictionary<System.String,System.Int32> tag2Count; // 0x18
	static System.Void DisableShadowMalloc(); // 0x06ae6784
	static System.Void EndAutoMallocHook(); // 0x06ae68ec
	static System.Void EndMallocHook(); // 0x06ae699c
	System.Void .ctor(); // 0x06ae69f8
	static System.Void .cctor(); // 0x06ae6aac
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Manager.PrintMemoryUsage : System.ValueType, System.IDisposable
{
	
	System.Void .ctor(System.String inDesc); // 0x06ae6b80
	System.Void Dispose(); // 0x06ae6bf4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrPermissionCenter : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Boolean <IsInWater>k__BackingField; // 0x11
	System.Boolean <IsInNight>k__BackingField; // 0x12
	SocLogger log; // 0x18
	System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.SocClient.RoleInfo> memberRoleInfosCaches; // 0x20
	System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.SocClient.RoleInfo> searchResultRoleInfosCaches; // 0x28
	System.Collections.Generic.List<System.UInt64> admins; // 0x30
	System.Collections.Generic.List<System.UInt64> normalMembers; // 0x38
	System.Collections.Generic.List<System.UInt64> teammateMembers; // 0x40
	System.Collections.Generic.List<System.UInt64> sortedTotalMembers; // 0x48
	System.Collections.Generic.Dictionary<System.UInt64,System.Int32> memberEarliestTimeJoinGroup; // 0x50
	System.Collections.Generic.List<System.UInt64> <SearchResultCaches>k__BackingField; // 0x58
	System.Int64 <OperateEntityId>k__BackingField; // 0x60
	System.Int64 <OperateTerrId>k__BackingField; // 0x68
	System.Collections.Generic.List<System.Int32> <SortedTablePermissionGroupId>k__BackingField; // 0x70
	UnityEngine.Vector2 preStayPos; // 0x78
	System.Collections.Generic.List<System.Int64> nearbyPermElectricPartCache; // 0x80
	System.Int64 nearbyPermElectricPartCheckTimer; // 0x88
	System.Int64 subscribeId; // 0x90
	WizardGames.Soc.SocClient.Manager.TriggerRecord preRecord; // 0x98
	WizardGames.Soc.SocClient.Manager.TriggerRecord curRecord; // 0xa0
	WizardGames.Soc.SocClient.EDeadSheepMissionState CurrState; // 0xa8
	System.Int64 StateRemainTime; // 0xb0
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> playerEnterTimesCache; // 0xb8
	WritableString strWriter; // 0xc0
	WizardGames.Soc.Common.Entity.TerritoryEntity curTerrEntity; // 0xd0
	WizardGames.Soc.Common.Entity.TerritoryEntity lastTerrEntity; // 0xd8
	System.Int64 lastToolCupboardId; // 0xe0
	System.Int32[] needShowLordBuffIds; // 0xe8
	System.Boolean showOngoingTip; // 0xf0
	System.Boolean get_IsInWater(); // 0x06ae6c54
	System.Void set_IsInWater(System.Boolean value); // 0x06ae6cb8
	System.Boolean get_IsInNight(); // 0x06ae6d34
	System.Void set_IsInNight(System.Boolean value); // 0x06ae6d98
	System.Void DelayShowCenterEffectOnCreate(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06ae6e14
	System.Void OnCenterFxEnterMode(); // 0x06ae7274
	System.Void OnCenterFxExitMode(); // 0x06ae7430
	System.Void CheckCenterFx(); // 0x06ae74d0
	System.Void SetCenterEffectActive(WizardGames.Soc.Common.Entity.TerritoryEntity terrEnt, System.Boolean active); // 0x06ae70e4
	System.Void OnFps2Update(); // 0x06ae7b08
	System.Void UpdateWaterNightState(); // 0x06ae7f84
	System.Collections.Generic.List<System.UInt64> get_SearchResultCaches(); // 0x06ae831c
	System.Int64 get_OperateEntityId(); // 0x06ae8380
	System.Void set_OperateEntityId(System.Int64 value); // 0x06ae83e4
	System.Int64 get_OperateTerrId(); // 0x06ae845c
	System.Void set_OperateTerrId(System.Int64 value); // 0x06ae84c0
	WizardGames.Soc.Common.Entity.TerritoryEntity get_CurTerrEnt(); // 0x06ae8538
	System.Collections.Generic.List<System.Int32> get_SortedTablePermissionGroupId(); // 0x06ae8658
	System.Int32 get_MemberCount(); // 0x06ae86bc
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06ae8738
	System.Threading.Tasks.Task OnExitWorld(); // 0x06ae8f40
	System.Void BuildStateSwitchEvent(System.Boolean isInBuildMode); // 0x06ae9554
	System.Void OnWireModeChange(System.Boolean isWireMode); // 0x06ae96b8
	System.Void OnEnterConstructionMode(); // 0x06ae964c
	System.Void OnExitConstructionMode(); // 0x06ae95e0
	System.Void OperateCenter(System.Boolean isOpen, WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06ae9b60
	System.UInt64 GetMemberRoleIdByIndex(System.Int32 index); // 0x06ae9d84
	WizardGames.Soc.SocClient.Ui.RoleIdentity GetRoleIdentity(System.UInt64 roleId); // 0x06ae9e48
	System.Int32 GetGroupNormalMemberCnt(System.Int32 groupId); // 0x06ae9f78
	WizardGames.Soc.SocClient.RoleInfo GetRoleInfoCache(System.UInt64 roleId); // 0x06aea078
	System.Boolean DoesPlayerHasPermission(System.UInt64 roleId, System.Int32 groupId); // 0x06aea144
	System.Int32 CountOfPermissionsPlayerHas(System.UInt64 roleId); // 0x06aea240
	System.Void RefreshCenterMembers(); // 0x06aea568
	System.Void RefreshMemberRoleInfos(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.PlayerBriefInfo> infos); // 0x06aeb238
	System.Void RefreshSearchInfos(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TeamSearchItemData> args); // 0x06aeb744
	System.Void RefreshSearchInfos(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.SearchPlayerInfo> searchPlayerInfos); // 0x06aebd9c
	System.Void ClearRoleInfosCache(); // 0x06ae94c0
	System.Void OnElectricWireEnterMode(); // 0x055049cc
	System.Void OnElectricWireExitMode(); // 0x06ae99e0
	static System.Void OnLinePowerStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int32 oldValue, System.Int32 newValue); // 0x06aecb3c
	System.Void OnWireConnect(WizardGames.Soc.Common.Component.ElectricBaseComponent electricModule); // 0x06aed030
	System.Void OnMyPermChanged(); // 0x06aed70c
	System.Void UpdateElectricWireStatus(System.Boolean forceUdt); // 0x06aec558
	System.Void UpdateElectricWireStatus(System.Int64 partEntityId); // 0x06aecd14
	System.Void ClearElectricWireStatus(); // 0x06aec8d0
	System.Void SetElectricWireStatus(System.Boolean isFlow, WizardGames.Soc.Common.Component.ElectricBaseComponent electricModule); // 0x06aed260
	WizardGames.Soc.Common.Entity.TerritoryEntity get_LastTerrEntity(); // 0x06aedb68
	System.Void set_LastTerrEntity(WizardGames.Soc.Common.Entity.TerritoryEntity value); // 0x06aedbcc
	System.Void ResetTrigger(); // 0x06ae8ea4
	System.Void OnFps1Update(); // 0x06aee168
	System.Int64 get_TerrCenterId(); // 0x06af2b4c
	System.Boolean get_IsDeadSheep(); // 0x06af2bf4
	System.Int32 get_BuildingId(); // 0x06af2c9c
	WizardGames.Soc.Common.CustomType.DeadSheepMission GetDeadSheepMission(System.Int32 type); // 0x06af2d44
	WizardGames.Soc.Common.Data.constraction.DeadSheepLevel GetDeadSheepLevel(); // 0x06af2e8c
	System.Int64 GetDeadSheepDebrisRemainTime(WizardGames.Soc.Common.Entity.TerritoryEntity terrEnt); // 0x06af30c8
	System.Int64 GetDeadSheepDesertedRemainTime(WizardGames.Soc.Common.Entity.TerritoryEntity terrEnt); // 0x06af3270
	System.Void CheckDeadSheepMissionState(WizardGames.Soc.Common.Entity.TerritoryEntity terrEnt); // 0x06af1830
	System.Void OnPlayerAwake(); // 0x06af3418
	System.Void CheckGuildState(WizardGames.Soc.Common.Entity.TerritoryEntity terrEnt); // 0x06aef340
	System.Void ForceShowTerrGuild(); // 0x06af3944
	System.Void FireMsgShowTerrGuild(); // 0x06af347c
	System.Void FireMsgHideTerrGuild(); // 0x06af36e4
	System.Void UpdateDetection(System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData> hitObjDataList, WizardGames.Soc.SocClient.Systems.HitObjData obstacle); // 0x06af3cf0
	System.Void ShowPermissionIdentityBuff(); // 0x06af0b00
	System.Void SetShowLordBuffDesStr(System.Int32 buffId); // 0x06af4068
	System.String GetCurrentLordStr(); // 0x06af44f8
	System.Void ShowTerrCenterCorrosionBuff(); // 0x06af14a8
	System.Void CheckEnterExitTerrCenterEventTrigger(); // 0x06aef8a4
	System.Void ShowEnterTerritoryTip(System.Int64 territoryEntityId); // 0x06af4730
	System.Void CheckEnterTerrCenterNoPermission(); // 0x06aefdb8
	System.Void EnterDeadSheepTerritory(System.Int64 terrId); // 0x06af4c28
	System.Void CheckDamageOnDefence(); // 0x06af0270
	System.Void CheckDebrisState(); // 0x06af074c
	System.Void ShowDebrisTip(); // 0x06af55ec
	System.Void CheckDebrisDestroyTip(); // 0x06af52cc
	System.Int32 GetRemainTime(System.Int64 startTimeMs, System.Int32 duringTimeSec); // 0x06af50bc
	System.Void ShowOnAttackBuff(); // 0x06af51a4
	System.String CollectPermGroupName(System.Collections.Generic.List<System.Int32> groupIds); // 0x06af42a4
	System.Void .ctor(); // 0x06af59ac
	System.Void <RefreshCenterMembers>b__56_0(System.UInt64 roleId); // 0x06af5fc0
	System.Void <RefreshCenterMembers>b__56_1(System.UInt64 roleId); // 0x06af60ac
	System.Int32 <RefreshCenterMembers>b__56_2(System.UInt64 x, System.UInt64 y); // 0x06af61c4
	System.Void <OnElectricWireEnterMode>b__65_0(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x06af6354
	System.Boolean <ShowPermissionIdentityBuff>b__121_0(); // 0x06af64c8
	System.Boolean <ShowPermissionIdentityBuff>b__121_1(); // 0x06af659c
	System.Boolean <ShowPermissionIdentityBuff>b__121_4(); // 0x06af66c8
	System.Boolean <ShowPermissionIdentityBuff>b__121_2(); // 0x06af6848
	System.Boolean <ShowPermissionIdentityBuff>b__121_5(); // 0x06af6974
	System.Boolean <ShowPermissionIdentityBuff>b__121_3(); // 0x06af6af4
	System.Void <ShowTerrCenterCorrosionBuff>b__124_0(WizardGames.Soc.SocClient.Ui.UiHudElemMsgData msgData); // 0x06af6bc8
	System.Boolean <ShowTerrCenterCorrosionBuff>b__124_1(); // 0x06af6df8
	System.Boolean <ShowTerrCenterCorrosionBuff>b__124_2(); // 0x06af6f38
	System.Boolean <ShowDebrisTip>b__131_0(); // 0x06af7078
	System.Boolean <ShowOnAttackBuff>b__134_0(); // 0x06af7194
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrPermissionCenter.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Manager.MgrPermissionCenter.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Data.constraction.PermissionSysGroup> <>9__43_0; // 0x8
	static System.Void .cctor(); // 0x06af720c
	System.Void .ctor(); // 0x06af7270
	System.Int32 <OnEnterWorld>b__43_0(WizardGames.Soc.Common.Data.constraction.PermissionSysGroup x, WizardGames.Soc.Common.Data.constraction.PermissionSysGroup y); // 0x06af72d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.TriggerRecord : System.Object
{
	System.Collections.Generic.List<System.Int32> permGroupIds; // 0x10
	System.Int64 <TerrCenterId>k__BackingField; // 0x18
	System.Int64 <TerrEntityId>k__BackingField; // 0x20
	System.UInt64 <CreatorRoleId>k__BackingField; // 0x28
	System.Boolean <IsDeadSheep>k__BackingField; // 0x30
	System.Int64 <StateStartTime>k__BackingField; // 0x38
	System.Int64 <AttackedStartTime>k__BackingField; // 0x40
	System.Int32 <ToolCupboardDebrisDestroyedSec>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Manager.PermRole <Role>k__BackingField; // 0x4c
	System.Boolean <HasFullPerm>k__BackingField; // 0x50
	System.Boolean <HasAnyPerm>k__BackingField; // 0x51
	System.Int32 <BuildingId>k__BackingField; // 0x54
	System.Single <ProtectTimeMinutes>k__BackingField; // 0x58
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> MissionInfo; // 0x60
	System.Boolean HaveToolcupboardEntityClient; // 0x68
	System.Collections.Generic.List<System.Int32> get_PermGroupIds(); // 0x06af736c
	System.Boolean get_CenterValid(); // 0x06ae7a58
	System.Int64 get_TerrCenterId(); // 0x06af73d0
	System.Void set_TerrCenterId(System.Int64 value); // 0x06af7434
	System.Int64 get_TerrEntityId(); // 0x06af74ac
	System.Void set_TerrEntityId(System.Int64 value); // 0x06af7510
	System.UInt64 get_CreatorRoleId(); // 0x06af7588
	System.Void set_CreatorRoleId(System.UInt64 value); // 0x06af75ec
	System.Boolean get_IsDeadSheep(); // 0x06af7664
	System.Void set_IsDeadSheep(System.Boolean value); // 0x06af76c8
	System.Int64 get_StateStartTime(); // 0x06af7744
	System.Void set_StateStartTime(System.Int64 value); // 0x06af77a8
	System.Int64 get_AttackedStartTime(); // 0x06af7820
	System.Void set_AttackedStartTime(System.Int64 value); // 0x06af7884
	System.Boolean get_IsOnAttackDuringTime(); // 0x06af500c
	System.Int32 get_ToolCupboardDebrisDestroyedSec(); // 0x06af78fc
	System.Void set_ToolCupboardDebrisDestroyedSec(System.Int32 value); // 0x06af7960
	WizardGames.Soc.SocClient.Manager.PermRole get_Role(); // 0x06af79d8
	System.Void set_Role(WizardGames.Soc.SocClient.Manager.PermRole value); // 0x06af7a3c
	System.Boolean get_HasFullPerm(); // 0x06af7ab4
	System.Void set_HasFullPerm(System.Boolean value); // 0x06af7b18
	System.Boolean get_HasAnyPerm(); // 0x06af7b94
	System.Void set_HasAnyPerm(System.Boolean value); // 0x06af7bf8
	System.Int32 get_BuildingId(); // 0x06af7c74
	System.Void set_BuildingId(System.Int32 value); // 0x06af7cd8
	System.Single get_ProtectTimeMinutes(); // 0x06af7d50
	System.Void set_ProtectTimeMinutes(System.Single value); // 0x06af7db4
	System.Void .ctor(); // 0x06af5eac
	System.Void Reset(); // 0x06aedce4
	System.Void CopyTo(WizardGames.Soc.SocClient.Manager.TriggerRecord target); // 0x06af1fe8
	System.Void Record(WizardGames.Soc.Common.Entity.TerritoryEntity terrEnt); // 0x06aee424
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.PermRole : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.PermRole Creator = 0;
	static WizardGames.Soc.SocClient.Manager.PermRole Admin = 1;
	static WizardGames.Soc.SocClient.Manager.PermRole NormalMember = 2;
	static WizardGames.Soc.SocClient.Manager.PermRole Stranger = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrSearch : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Log; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Search.SearchTask> tasks; // 0x18
	System.Action<WizardGames.Soc.SocClient.Search.SearchResult,WizardGames.Soc.Common.Data.MarkerType> OnMarkerGetOrUpdateSearchResult; // 0x20
	System.Action<System.Int64,System.Int64> OnSearchMarkerRemove; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.Entity.IEntity>> entityCacheDict; // 0x30
	System.Boolean firstWakeUp; // 0x38
	System.Int64 curSearchEntityIdByServer; // 0x40
	System.Int64 curItemDetailSearchTaskId; // 0x48
	System.Int64 itemSearchTaskTimer; // 0x50
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> taskId2MissionId; // 0x58
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Search.SearchGroup> missionId2SearchGroup; // 0x60
	System.Collections.Generic.List<System.Int64> currentMissionIds; // 0x68
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> safetyBoxSearchId2TaskId; // 0x70
	System.Int64 curTreasureBoxMissionTrackId; // 0x78
	System.Int64 curTreasureBoxSearchJobId; // 0x80
	System.Void Init(); // 0x06af7e2c
	System.Void CleanUp(); // 0x06af83b8
	System.Threading.Tasks.Task OnExitWorld(); // 0x06af85b4
	System.Void OnPlayerAwake(); // 0x06af9584
	WizardGames.Soc.SocClient.Search.SearchTask GetSearchTask(System.Int64 taskId); // 0x06afa650
	System.Int64 CreateSearchTask(System.Int64 searchId, System.Action<WizardGames.Soc.SocClient.Search.SearchResult> onResultGetOrUpdate, System.Action<System.Int64,System.Int64> onTaskRelease, System.Int64 missionId); // 0x06afa6fc
	System.Void CancelSearch(System.Int64 taskId); // 0x06af89dc
	WizardGames.Soc.SocClient.Search.SearchTask GenerateTask(WizardGames.Soc.Common.Data.Search.SearchConfig config); // 0x06afab90
	System.Void OnServerSearchResponse(System.Int64 taskId, System.Boolean isFound, System.Int64 entityId); // 0x06afae40
	System.Void CreateOrUpdateTaskBindMarker(WizardGames.Soc.SocClient.Search.SearchResult searchResult, WizardGames.Soc.Common.Data.MarkerType markerType); // 0x06afafc4
	System.Void RemoveTaskBindMarker(System.Int64 taskId, System.Int64 searchId); // 0x06afb0b4
	System.Void InitEntityCacheDict(); // 0x06af8030
	System.Void OnEntityCreate(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06afb148
	System.Void OnEntityRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06afb314
	System.Void SearchFromItemSystem(System.Int64 searchId); // 0x06afb954
	System.Void ShowSearchTaskResultTip(System.Int64 taskId); // 0x06afc2d4
	System.Boolean IsReachedItemDestination(System.Int64 taskId); // 0x06afbe48
	System.Void GenerateItemSearchTaskTimer(); // 0x055049cc
	System.Void CancelItemSearchTaskTimer(); // 0x06af9480
	System.Void UpdateMissionSearch(); // 0x06af974c
	System.Void CreateSearchs(WizardGames.Soc.Common.Data.Play.QuestPhase mission); // 0x06afc4c0
	System.Void ClearSearchGroup(); // 0x06af9214
	System.Void ForceRunCurrentMissionSearch(); // 0x06afcc44
	System.Void ReRunMissionSearch(System.Int64 entityId); // 0x06afb538
	System.Int64 GetTaskId(System.Int64 searchId); // 0x06afce74
	System.Int64 GetMissionIdByTaskId(System.Int64 taskId); // 0x06afd130
	System.Void UpdateSafetyBoxSearch(); // 0x06af9cf4
	System.Void UpdateTreasureBoxMissionSearch(); // 0x06afa210
	System.Void .ctor(); // 0x06afd1e4
	static System.Void .cctor(); // 0x06afd42c
	System.Void <SearchFromItemSystem>b__23_0(WizardGames.Soc.SocClient.Search.SearchResult searchResult); // 0x06afd500
	System.Void <SearchFromItemSystem>b__23_1(WizardGames.Soc.SocClient.Search.SearchResult searchResult); // 0x06afd580
	System.Void <GenerateItemSearchTaskTimer>b__26_0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x06afd600
	System.Void <UpdateSafetyBoxSearch>b__39_0(WizardGames.Soc.SocClient.Search.SearchResult result); // 0x06afd798
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrSearch.<>c__DisplayClass32_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrSearch <>4__this; // 0x10
	WizardGames.Soc.Common.Data.Play.QuestPhase mission; // 0x18
	WizardGames.Soc.SocClient.Search.SearchGroup group; // 0x20
	System.Action<WizardGames.Soc.SocClient.Search.SearchResult> <>9__1; // 0x28
	System.Action<WizardGames.Soc.SocClient.Search.SearchResult> <>9__2; // 0x30
	System.Void .ctor(); // 0x06afdaec
	System.Void <CreateSearchs>b__0(WizardGames.Soc.SocClient.Search.SearchResult result); // 0x06afdb54
	System.Void <CreateSearchs>b__1(WizardGames.Soc.SocClient.Search.SearchResult result); // 0x06afdbe8
	System.Void <CreateSearchs>b__2(WizardGames.Soc.SocClient.Search.SearchResult result); // 0x06afdc70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrSearch.<>c__DisplayClass42_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrSearch <>4__this; // 0x10
	WizardGames.Soc.Common.Data.Play.QuestPhase mission; // 0x18
	System.Void .ctor(); // 0x06afdcf8
	System.Void <UpdateTreasureBoxMissionSearch>b__0(WizardGames.Soc.SocClient.Search.SearchResult result); // 0x06afdd60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.AmbientLightSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	static SocLogger Log; // 0x0
	System.Collections.Generic.Dictionary<System.String,UnityEngine.Cubemap> loadedCubemap; // 0x28
	UnityEngine.Texture restProbeTex; // 0x30
	System.Boolean isInteriorPrevState; // 0x38
	static UnityEngine.AzureSky.AzureWeatherPresetEnum todSettingOnEnterLight; // 0x8
	static UnityEngine.AzureSky.AzureWeatherPresetEnum prevTod; // 0xc
	static UnityEngine.AzureSky.AzureWeatherPresetEnum todType; // 0x10
	static System.Boolean isChangedTod; // 0x14
	static System.Boolean isInterior; // 0x15
	static System.Boolean isHideSea; // 0x16
	static System.Boolean isOpenShadowFunc; // 0x17
	static System.Boolean isLightVolumeTriggerChanged; // 0x18
	static System.Int32 monumentLightVolumeId; // 0x1c
	static System.Single mainLightIntensity; // 0x20
	static System.Single envIntensity; // 0x24
	static System.Single lastLightVolumeTime; // 0x28
	static WizardGames.Soc.SocClient.Trigger.LightVolumeCfg lightVolume; // 0x30
	static WizardGames.Soc.SocClient.Trigger.TriggerMonumentArea monumentAreaVolume; // 0x38
	static WizardGames.Soc.SocClient.Trigger.LightVolumeCfg lastTrigger; // 0x40
	static System.Collections.Generic.List<WizardGames.Soc.SocClient.Trigger.LightVolumeCfg> lightVolumeList; // 0x48
	static System.Single destEnvIntensity; // 0x50
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x06afddf4
	static System.Boolean get_IsInterior(); // 0x06afde58
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x06afdee0
	System.Void OnDestroy(); // 0x06afe33c
	System.Void ResetLightVolumeData(); // 0x06afe054
	System.Void OnTriggerDataLoadFinish(); // 0x06afe894
	static System.Void OnEnterVolume(WizardGames.Soc.SocClient.Trigger.LightVolumeCfg volume); // 0x06afed70
	static System.Void OnLeaveVolume(WizardGames.Soc.SocClient.Trigger.LightVolumeCfg volume); // 0x06afeecc
	System.Void ClearAllVolumes(); // 0x06afe4a4
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06afefd4
	System.Void Update(System.Int32 deltaTime); // 0x06aff0c0
	System.Void UpdateLightVolumeInteriorState(); // 0x06aff5b8
	System.String GetCustomBakedTexturePath(); // 0x06afe90c
	System.Boolean BindAzureSkySystem(); // 0x06afe218
	System.Void UpdateASkySystemProbeCubeMap(System.Boolean playerInterior, System.String customBakedTexturePath); // 0x06afea30
	static System.Void OnLightVolumeInteriorStateChanged(); // 0x06aff708
	System.Void CheckAndUpdateTOD(); // 0x06aff898
	static System.Void ApplyTod(UnityEngine.AzureSky.AzureWeatherPresetEnum tod); // 0x06affbe4
	static System.Void SetShadowState(System.Boolean enable); // 0x06afe6e8
	System.Void OnLightVolumeTriggerChanged(); // 0x06affaf4
	static System.Void UpdateLightIntensity(System.Int32 deltaTime); // 0x06aff26c
	static System.Void ProcessLightIntensity(WizardGames.Soc.SocClient.Trigger.LightVolumeCfg volume, System.Int32 deltaTime); // 0x06b0013c
	static System.Void ProcessIntensity(); // 0x06affee0
	static System.Void ResetPlayerLightVolume(); // 0x06affc44
	static System.Void UpdateLightOutVolume(System.Int32 deltaTime); // 0x06affd00
	static System.Single GetMaxDelta(System.Int32 deltaTimeMs); // 0x06b00468
	System.Void .ctor(); // 0x06b00568
	static System.Void .cctor(); // 0x06b0061c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.BuoyancyRenderSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x06b007b8
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x06b0081c
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06b008b8
	System.Single BuoyancyThirdTwoPhase(System.Single deltaTime, WizardGames.Soc.Common.Component.BuoyancyComponent buoyancyEntity, UnityEngine.Vector3 originPos); // 0x06b00dc4
	System.Void Normalization(UnityEngine.Vector3 originPos, System.Single& res, System.Single& newSpeed, System.Single up, System.Single below); // 0x06b00f94
	System.Void .ctor(); // 0x06b0124c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrActivity : WizardGames.Soc.Common.Manager.MgrBase
{
	
	System.Boolean IsOpenInSpecifiedTimeframe(WizardGames.Soc.Common.Data.common.ENUMSwitchTimeType switchTimeType, System.String timeParam1, System.String timeParam2); // 0x06b012b4
	System.Boolean IsCurrentTimeInMonthRange(System.String startTime, System.String endTime); // 0x06b01908
	System.Boolean IsCurrentTimeInWeeklyRange(System.String time1, System.String time2); // 0x06b015f4
	System.Boolean IsCurrentTimeInDayRange(System.String startTime, System.String endTime); // 0x06b0142c
	System.Void .ctor(); // 0x06b01ca8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrRecruit : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger log; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RecruitData> lobbyRecruitTeamList; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RecruitData> lobbyAppointmentRecruitTeamList; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RecruitData> gameRecruitTeamList; // 0x28
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.PlayerApplyEnterTeamInfo> playerApplyEnterTeamInfoDic; // 0x30
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.PlayerApplyEnterTeamInfo> playerApplyEnterTeamInfoDicAppointment; // 0x38
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.PlayerApplyEnterTeamInfo> playerApplyEnterTeamInfoDicInGame; // 0x40
	System.Boolean hasNewInGameApplyEnterTeamInfo; // 0x48
	System.Int64 LastPublishGameRecruitTime; // 0x50
	System.Collections.Generic.Dictionary<System.String,System.Int64> RoleId2ApplyInGameRecruitTime; // 0x58
	System.Collections.Generic.Dictionary<System.String,System.Int64> RoleId2ApplyNormalRecruitTime; // 0x60
	System.Collections.Generic.Dictionary<System.String,System.Int64> RoleId2ApplyAppointmentRecruitTime; // 0x68
	SimpleJSON.JSONNode ApplyEnterGameRecruitTeamSuccessResult; // 0x70
	WizardGames.Soc.SocClient.Ui.MyTeamRecruitData myTeamRecruitData; // 0x78
	WizardGames.Soc.SocClient.Ui.MyTeamRecruitData myAppointmentRecruitData; // 0x80
	WizardGames.Soc.SocClient.Ui.MyTeamRecruitData myGameTeamRecruitData; // 0x88
	WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData RecruitFilterConditionDataInGameCache; // 0x90
	System.Boolean IsFirstReqGameChatRecruitList; // 0x98
	System.Boolean get_HasGameRecruit(); // 0x06b01d10
	System.Boolean HasNewInGameApplyEnterTeamInfo(); // 0x06b01d7c
	System.Void SetHasNewInGameApplyEnterTeamInfo(System.Boolean hasNew); // 0x06b01ee4
	System.Void ReqPublishGameRecruit(System.String teamName, System.String teamStatement, System.Collections.Generic.List<System.Int32> teamPreference, System.Int32 microphone, System.Boolean isPublishToLobby, System.Int32 regularDay, System.Int32 regularTime, System.String tlogData); // 0x0552db88
	System.Void ReqGetGameApplyInfos(); // 0x06b024cc
	System.Void AddOrUpdateGameApplyInfo(System.UInt64 roleIdUlong, WizardGames.Soc.Common.CustomType.TeamRecruitmentApplicationInfo info); // 0x06b026a4
	System.Void RefreshGameApplyInfos(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.UInt64,WizardGames.Soc.Common.CustomType.TeamRecruitmentApplicationInfo> infos); // 0x06b02888
	System.Void ClearGameApplyInfos(); // 0x06b02dec
	System.Void ReqOperationGameApplyInfo(System.String roleId, System.Boolean isAccept, System.Boolean isSourceBattle); // 0x06b02e7c
	System.Void ShowApplyGameRecruitSuccessPop(); // 0x055049cc
	System.Void AddChatIngameRecruitData(WizardGames.Soc.SocClient.Ui.RecruitData recruitData); // 0x06b03978
	System.Void RemoveChatGameRecruitData(System.String teamId); // 0x06b03c28
	System.Void ReqGameRecruitData(); // 0x06b03dac
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RecruitData> GetLobbyRecruitTeamList(System.Boolean isAppointment); // 0x06b040d4
	System.Void ReqRecruitmentList(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, SimpleJSON.JSONObject param, System.Action<SimpleJSON.JSONNode> callback); // 0x055105f0
	System.Void ReqMyRecruitment(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action<SimpleJSON.JSONNode> callback, System.Boolean isAppointment); // 0x05510620
	System.Void ReqInGameRecruitmentRandomList(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action<SimpleJSON.JSONArray> callback, WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData filterData); // 0x055105f0
	System.Void ReqRefreshInGameRecruitmentList(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action<SimpleJSON.JSONArray> callback, WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData filterData, System.Collections.Generic.List<System.String> teamIDList); // 0x05510c9c
	System.Void ReqApplyForTeamStep1(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String teamId, System.Boolean needAudit, System.Boolean isAppointment, WizardGames.Soc.SocClient.Ui.ERecruitSource recruitSource, System.String sourceExtStr, System.Action<System.Boolean> cb); // 0x055106f4
	System.Void ReqApplyForTeamStep2(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String teamId, System.Boolean needAudit, System.String joinRemark, SimpleJSON.JSONArray tagArray, System.Boolean isAppointment, WizardGames.Soc.SocClient.Ui.ERecruitSource recruitSource, System.String sourceExtStr, System.Action<System.Boolean> cb); // 0x055107b4
	System.Void ReqApplyForInGameTeam(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, SimpleJSON.JSONObject param, System.String teamId, System.Action<System.Boolean> cb); // 0x05510c9c
	System.Void ReqRecruitInfoByTeamIds(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Collections.Generic.List<System.String> teamIds, System.Action<SimpleJSON.JSONNode> callback); // 0x055105f0
	System.Void ReqRecruitmentCancel(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action callback, System.Boolean isAppointment); // 0x05510620
	System.Void ReqRecruitmentPublish(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, SimpleJSON.JSONObject param, System.Action callback); // 0x055105f0
	System.Void ReqRecruitmentQuickApplyFor(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, SimpleJSON.JSONObject param, System.Action callback); // 0x055105f0
	System.Void RemoveChatLobbyRecruitData(System.String teamId, System.Boolean isAppointment); // 0x06b07a5c
	System.Void AddRecruitData(SimpleJSON.JSONNode jsonNode); // 0x06b07c00
	System.Void UpdateRecruitTeamList(System.Boolean isAppointment, SimpleJSON.JSONNode jsonNode); // 0x06b087d4
	System.Void ReqGetPlayApplyEnterTeamInfos(System.Boolean isAppointment); // 0x05523a7c
	System.Void AddPlayApplyEnterTeamInfo(System.String roleId, System.String joinRemark, System.Int32 sourceID, System.String sourceTribeId, System.Boolean isAppointment); // 0x06b09130
	System.Void RemovePlayApplyEnterTeamInfo(System.String roleId, System.Boolean isAppointment); // 0x06b09510
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.PlayerApplyEnterTeamInfo> GetPlayerApplyEnterTeamInfos(System.Boolean isAppointment); // 0x06b09690
	System.Void ClearPlayerApplyEnterTeamInfos(System.Boolean isAppointment); // 0x06b0900c
	System.Boolean HasNewApplyEnterTeamInfo(); // 0x06b0974c
	System.Boolean HasNewAppointmentApplyEnterTeamInfo(); // 0x06b0995c
	System.Void SetApplyInfosRead(System.Boolean isAppointment); // 0x06b09b6c
	System.Void ResponseAllowPlayerEnterTeam(System.String roleID, System.Boolean isAppointment, System.Action callback); // 0x0552b278
	System.Void ResponseRejectPlayerEnterTeam(System.String roleID, System.Boolean isAppointment, System.Action callback); // 0x0552b278
	static System.String GetRecruitSourceName(WizardGames.Soc.SocClient.Ui.ERecruitSource type); // 0x06b0a7e0
	System.Void OnTeamMemberDictChange(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x06b0a954
	WizardGames.Soc.SocClient.Ui.MyTeamRecruitData GetMyTeamRecruitData(System.Boolean isAppointment); // 0x06b07320
	WizardGames.Soc.SocClient.Ui.MyTeamRecruitData GetMyGameTeamRecruitData(); // 0x06b0ab0c
	System.Void SetMyGameTeamRecruitData(WizardGames.Soc.SocClient.Ui.MyTeamRecruitData data); // 0x06b0aa48
	static System.Collections.Generic.HashSet<System.Int32> PlayerTagJson2HashSet(SimpleJSON.JSONNode json); // 0x06b08648
	System.Void UpdateTeamRecruitDataByLocal(SimpleJSON.JSONObject param); // 0x06b0ab70
	System.Void UpdateTeamRecruitData(SimpleJSON.JSONNode json, System.Boolean isAppointment); // 0x06b0af78
	System.Void ClearTeamRecruitData(System.Boolean isAppointment); // 0x06b0b18c
	System.Void Init(); // 0x06b0b354
	System.Void Destroy(); // 0x06b0b498
	System.Threading.Tasks.Task OnEnterWorld(); // 0x054e7844
	System.Threading.Tasks.Task OnExitWorld(); // 0x06b0b72c
	System.Void .ctor(); // 0x055049cc
	static System.Void .cctor(); // 0x06b0bae4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrRecruit.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Manager.MgrRecruit.<>c <>9; // 0x0
	static System.Action <>9__28_0; // 0x8
	static System.Action<SimpleJSON.JSONNode> <>9__33_1; // 0x10
	static System.Action<SimpleJSON.JSONNode> <>9__34_1; // 0x18
	static System.Action<SimpleJSON.JSONNode> <>9__35_1; // 0x20
	static System.Action<SimpleJSON.JSONNode> <>9__36_1; // 0x28
	static System.Action<SimpleJSON.JSONNode> <>9__38_2; // 0x30
	static System.Action<SimpleJSON.JSONNode> <>9__40_1; // 0x38
	static System.Action<SimpleJSON.JSONNode> <>9__41_1; // 0x40
	static System.Action<SimpleJSON.JSONNode> <>9__42_2; // 0x48
	static System.Action<SimpleJSON.JSONNode> <>9__43_1; // 0x50
	static System.Void .cctor(); // 0x06b0bbb8
	System.Void .ctor(); // 0x06b0bc1c
	System.Void <ShowApplyGameRecruitSuccessPop>b__28_0(); // 0x055049cc
	System.Void <ReqRecruitmentList>b__33_1(SimpleJSON.JSONNode error); // 0x05523a54
	System.Void <ReqMyRecruitment>b__34_1(SimpleJSON.JSONNode error); // 0x05523a54
	System.Void <ReqInGameRecruitmentRandomList>b__35_1(SimpleJSON.JSONNode error); // 0x05523a54
	System.Void <ReqRefreshInGameRecruitmentList>b__36_1(SimpleJSON.JSONNode error); // 0x05523a54
	System.Void <ReqApplyForTeamStep2>b__38_2(SimpleJSON.JSONNode json); // 0x05523a54
	System.Void <ReqRecruitInfoByTeamIds>b__40_1(SimpleJSON.JSONNode error); // 0x05523a54
	System.Void <ReqRecruitmentCancel>b__41_1(SimpleJSON.JSONNode error); // 0x05523a54
	System.Void <ReqRecruitmentPublish>b__42_2(SimpleJSON.JSONNode error); // 0x05523a54
	System.Void <ReqRecruitmentQuickApplyFor>b__43_1(SimpleJSON.JSONNode error); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrRecruit.<>c__DisplayClass22_0 : System.Object
{
	System.String teamName; // 0x10
	System.String teamStatement; // 0x18
	System.Collections.Generic.List<System.Int32> teamPreference; // 0x20
	System.Int32 microphone; // 0x28
	System.Int32 regularTime; // 0x2c
	System.Int32 regularDay; // 0x30
	System.String tlogData; // 0x38
	System.Boolean isPublishToLobby; // 0x40
	System.Void .ctor(); // 0x055049cc
	System.Void <ReqPublishGameRecruit>b__0(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrRecruit.<>c__DisplayClass28_0 : System.Object
{
	SimpleJSON.JSONNode battleServerID; // 0x10
	System.Void .ctor(); // 0x055049cc
	System.Void <ShowApplyGameRecruitSuccessPop>b__1(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrRecruit.<>c__DisplayClass33_0 : System.Object
{
	System.Action<SimpleJSON.JSONNode> callback; // 0x10
	System.Void .ctor(); // 0x06b049ac
	System.Void <ReqRecruitmentList>b__0(SimpleJSON.JSONNode res); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrRecruit.<>c__DisplayClass34_0 : System.Object
{
	System.Boolean isAppointment; // 0x10
	WizardGames.Soc.SocClient.Manager.MgrRecruit <>4__this; // 0x18
	System.Action<SimpleJSON.JSONNode> callback; // 0x20
	System.Void .ctor(); // 0x06b050c8
	System.Void <ReqMyRecruitment>b__0(SimpleJSON.JSONNode jsonNode); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrRecruit.<>c__DisplayClass35_0 : System.Object
{
	System.Action<SimpleJSON.JSONArray> callback; // 0x10
	System.Void .ctor(); // 0x06b05828
	System.Void <ReqInGameRecruitmentRandomList>b__0(SimpleJSON.JSONNode jsonNode); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrRecruit.<>c__DisplayClass36_0 : System.Object
{
	System.Action<SimpleJSON.JSONArray> callback; // 0x10
	System.Void .ctor(); // 0x06b05b70
	System.Void <ReqRefreshInGameRecruitmentList>b__0(SimpleJSON.JSONNode jsonNode); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrRecruit.<>c__DisplayClass37_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrRecruit <>4__this; // 0x10
	WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule; // 0x18
	System.String teamId; // 0x20
	System.Boolean needAudit; // 0x28
	System.Boolean isAppointment; // 0x29
	WizardGames.Soc.SocClient.Ui.ERecruitSource recruitSource; // 0x2c
	System.String sourceExtStr; // 0x30
	System.Action<System.Boolean> cb; // 0x38
	System.Void .ctor(); // 0x06b0632c
	System.Void <ReqApplyForTeamStep1>b__0(System.String str, SimpleJSON.JSONArray tagArray); // 0x0552af00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrRecruit.<>c__DisplayClass38_0 : System.Object
{
	System.Boolean needAudit; // 0x10
	WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule; // 0x14
	System.Boolean isAppointment; // 0x18
	System.Action<System.Boolean> cb; // 0x20
	WizardGames.Soc.SocClient.Manager.MgrRecruit <>4__this; // 0x28
	System.String teamId; // 0x30
	System.Action<SimpleJSON.JSONNode> <>9__3; // 0x38
	System.Void .ctor(); // 0x06b067fc
	System.Void <ReqApplyForTeamStep2>b__0(SimpleJSON.JSONNode res); // 0x05523a54
	System.Void <ReqApplyForTeamStep2>b__1(SimpleJSON.JSONNode error); // 0x05523a54
	System.Void <ReqApplyForTeamStep2>b__3(SimpleJSON.JSONNode jsonNode); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrRecruit.<>c__DisplayClass39_0 : System.Object
{
	SimpleJSON.JSONObject param; // 0x10
	System.Action<System.Boolean> cb; // 0x18
	System.Void .ctor(); // 0x06b06c64
	System.Void <ReqApplyForInGameTeam>b__0(SimpleJSON.JSONNode res); // 0x05523a54
	System.Void <ReqApplyForInGameTeam>b__1(SimpleJSON.JSONNode error); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrRecruit.<>c__DisplayClass40_0 : System.Object
{
	System.Action<SimpleJSON.JSONNode> callback; // 0x10
	System.Void .ctor(); // 0x06b072b8
	System.Void <ReqRecruitInfoByTeamIds>b__0(SimpleJSON.JSONNode res); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrRecruit.<>c__DisplayClass41_0 : System.Object
{
	System.Action callback; // 0x10
	System.String tlogData; // 0x18
	WizardGames.Soc.SocClient.Manager.MgrRecruit <>4__this; // 0x20
	System.Boolean isAppointment; // 0x28
	System.Void .ctor(); // 0x06b07618
	System.Void <ReqRecruitmentCancel>b__0(SimpleJSON.JSONNode res); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrRecruit.<>c__DisplayClass42_0 : System.Object
{
	WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule; // 0x10
	System.Action callback; // 0x18
	SimpleJSON.JSONObject param; // 0x20
	WizardGames.Soc.SocClient.Manager.MgrRecruit <>4__this; // 0x28
	System.Action<SimpleJSON.JSONNode> <>9__1; // 0x30
	System.Void .ctor(); // 0x06b079f4
	System.Void <ReqRecruitmentPublish>b__0(); // 0x055049cc
	System.Void <ReqRecruitmentPublish>b__1(SimpleJSON.JSONNode res); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrRecruit.<>c__DisplayClass43_0 : System.Object
{
	System.Action callback; // 0x10
	System.Void .ctor(); // 0x055049cc
	System.Void <ReqRecruitmentQuickApplyFor>b__0(SimpleJSON.JSONNode res); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrRecruit.<>c__DisplayClass47_0 : System.Object
{
	System.Boolean isAppointment; // 0x10
	WizardGames.Soc.SocClient.Manager.MgrRecruit <>4__this; // 0x18
	System.Void .ctor(); // 0x055049cc
	System.Void <ReqGetPlayApplyEnterTeamInfos>b__0(SimpleJSON.JSONNode res); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrRecruit.<>c__DisplayClass55_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrRecruit <>4__this; // 0x10
	System.String roleID; // 0x18
	System.Boolean isAppointment; // 0x20
	System.Action callback; // 0x28
	System.Void .ctor(); // 0x06b0a778
	System.Void <ResponseAllowPlayerEnterTeam>b__0(SimpleJSON.JSONNode res); // 0x05523a54
	System.Void <ResponseAllowPlayerEnterTeam>b__1(SimpleJSON.JSONNode error); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrRecruit.<>c__DisplayClass56_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrRecruit <>4__this; // 0x10
	System.String roleID; // 0x18
	System.Boolean isAppointment; // 0x20
	System.Action callback; // 0x28
	System.Void .ctor(); // 0x055049cc
	System.Void <ResponseRejectPlayerEnterTeam>b__0(SimpleJSON.JSONNode res); // 0x05523a54
	System.Void <ResponseRejectPlayerEnterTeam>b__1(SimpleJSON.JSONNode error); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Int64 heartBeatTimerId; // 0x18
	System.Int64 autoPullInGameChatMsgTimerId; // 0x20
	System.String HighSpeedPullTribeId; // 0x28
	System.Int32 lowSpeedPullCd; // 0x30
	System.Collections.Generic.Dictionary<System.String,System.Int64> tribeId2LastMsgSeq; // 0x38
	System.Collections.Generic.HashSet<System.String> repairedTribeChatTribeIds; // 0x40
	static SocLogger log; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeInfo> myTribeInfos; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeInviteInfo> tribeInviteInfos; // 0x50
	System.Int64 replaceSystemTribeCdTime; // 0x58
	System.Int32 lastReqTribeDetailTime; // 0x60
	System.Boolean OnlyShowOnLinePlayer; // 0x64
	System.String offlineReJoinSystemGroupId; // 0x68
	System.Collections.Generic.List<System.String> offlineNotifys; // 0x70
	System.String scanQrCodeJoinTribeTipTribeId; // 0x78
	System.String scanQrCodeJoinTribeTipTribeName; // 0x80
	System.Void SendMessage(System.String tribeID, System.String content, System.String msgMeta, System.Boolean isVoice); // 0x06b106ec
	System.Void ReqAddActiveByChat(System.String tribeID, System.String msgType); // 0x06b10c18
	System.Void ReqAddActiveByShareTeam(System.String tribeID); // 0x06b110a4
	System.Void ReqAddActiveByResponseJoinTeam(System.String tribeID); // 0x06b114a4
	System.Void PullMsg(WizardGames.Soc.SocClient.Ui.TribeInfo tribe); // 0x06b118a4
	System.Void PullMsgCallBack(System.String ingameGroupId, System.Collections.Generic.List<WizardGames.Soc.SDK.InGameMsgContent> msgs); // 0x06b11b8c
	System.Void InGameErrorCallBack(System.String ingameGroupId, System.Int32 errorCode); // 0x06b1206c
	System.Void ReqRepairTribeChat(System.String tribeID); // 0x06b12438
	System.Void UpdateCacheMsgs(System.String tribeID, System.Collections.Generic.List<WizardGames.Soc.SDK.InGameMsgContent> msgs); // 0x06b11de4
	System.Void OnAccountLogined(); // 0x06b12838
	System.Void DoChatGroupHeartbeat(System.Int64 timerId, System.Object _, System.Boolean delete); // 0x06b128ec
	System.Void DoAutoPullChatMsg(System.Int64 timerId, System.Object _, System.Boolean delete); // 0x06b129e8
	System.Void ForcePullAllTribeMsg(); // 0x06b12db4
	System.Void ClearInGameHeartbeatTimer(); // 0x06b12fa4
	System.Void ClearAutoPullInGameChatMsgTimer(); // 0x06b130b4
	System.Int32 get_MaxActiveScoreLevel(); // 0x06b131c4
	System.Void Init(); // 0x06b13350
	System.Void Destroy(); // 0x06b13454
	System.Void OnAccountEnterLobby(); // 0x06b13558
	System.Void InitTribeData(); // 0x055049cc
	System.Void UiLobbyMainAnimFinish(); // 0x06b13d08
	System.Void CheckIsShowReJoinSystemGroupTip(); // 0x06b13d74
	System.Int64 GetReplaceSystemTribeCdTime(System.Boolean inNewbieGroup); // 0x06b141cc
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeInfo> GetMyTribeInfos(); // 0x06b14320
	System.Boolean CheckRoleIsInTribe(System.String tribeID, System.String roleID); // 0x06b14384
	WizardGames.Soc.SocClient.Ui.TribeInfo GetMyTribeInfoById(System.String tribeID); // 0x06b10a28
	WizardGames.Soc.SocClient.Ui.TribeInfo GetMyTribeInfoByInGameGroupId(System.String inGameGroupId); // 0x06b12248
	System.String GetMyTribeNameById(System.String tribeID); // 0x06b14720
	System.Void RemoveMyTribeInfo(System.String tribeID, System.Boolean isDismiss); // 0x06b149a8
	System.Void AddMyTribeInfo(WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo); // 0x06b14d04
	System.Boolean IsCreateSuperTribeCountLimit(); // 0x06b1516c
	System.Boolean IsCreateNormalTribeCountLimit(); // 0x06b153ec
	System.Void SortTribeInfos(); // 0x06b15030
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeInviteInfo> GetTribeInviteInfos(); // 0x06b1566c
	System.Void RemoveTribeInviteInfo(System.String tribeID); // 0x06b156d0
	System.Void AddTribeInviteInfo(WizardGames.Soc.SocClient.Ui.TribeInviteInfo tribeInviteInfo); // 0x06b15874
	System.Void AddTribeApplyInfo(System.String tribeID, WizardGames.Soc.SocClient.Ui.ApplyEnterTribeInfo applyInfo); // 0x06b15b44
	System.Void RemoveTribeApplyInfo(System.String tribeID, System.String roleID); // 0x06b15d3c
	System.Int32 GetTribeInviteCount(); // 0x06b15f34
	System.Int32 GetTribeApplyCount(); // 0x06b15fb0
	System.Boolean NeedShowChatAnnouncementTip(System.String tribeID); // 0x06b16210
	System.Void HasShowChatAnnouncementTip(System.String tribeID); // 0x06b163c8
	System.Boolean IsOpenChatNotDisturbSwitch(System.String tribeID); // 0x06b164e4
	System.Boolean GetLocalCacheChatNotDisturbSwitch(System.String tribeID); // 0x06b1656c
	System.Void SetChatNotDisturbSwitch(System.String tribeID, System.Boolean isOpen); // 0x06b16648
	System.Void ReqCreateTribe(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, WizardGames.Soc.SocClient.Ui.ETribeGroupType groupType, System.String icon, System.String name, System.Collections.Generic.List<System.String> tags, System.Action<System.String> CallBack); // 0x06b16750
	System.Void ReqModifyTribeTags(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String tribeID, System.Collections.Generic.List<System.String> tags); // 0x06b16cf8
	System.Void ReqModifyTribeIcon(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String tribeID, System.Int32 iconId); // 0x06b17244
	System.Void ReqModifyTribeName(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String tribeID, System.String name, System.Action acion); // 0x06b17710
	System.Void ReqModifyTribePermission(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String tribeID, System.Boolean allowMemberApproval, System.Boolean allowMemberInvite); // 0x06b17bf8
	System.Void ReqExitTribe(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String tribeID, System.Action action); // 0x06b18150
	System.Void ReqDismissTribe(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String tribeID, System.Action action); // 0x06b185e0
	System.Void ReqTribeDetailInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String tribeID, System.Action<SimpleJSON.JSONNode> callback); // 0x06b18a70
	System.Void ReqGetMyTribeBaseInfos(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action callback); // 0x06b13acc
	System.Void ParseOfflineNotifications(SimpleJSON.JSONArray offlineNotifications); // 0x06b18ee8
	System.Void UpdateMyAllTribeInfos(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action callback); // 0x06b19334
	System.Void ReqUpdateMyTribeDetailInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String tribeID, System.Action<WizardGames.Soc.SocClient.Ui.TribeInfo> callback); // 0x06b1976c
	System.Void ReqInviteTribeMembers(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String tribeID, System.Collections.Generic.List<System.String> memberIDs, System.Boolean IsSourceCreateTribe); // 0x06b19b18
	System.Void ReqReplaceSystemTribe(System.Action action); // 0x06b19f44
	System.Void ReqGetTribeInviteList(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule); // 0x06b138e0
	System.Void ReqAcceptTribeInvite(System.String tribeID, System.Action action); // 0x06b1a500
	System.Void ReqRejectTribeInvite(System.String tribeID, System.Action action); // 0x06b1a8a8
	System.Void ReqRejectAllTribeInvite(System.Action action); // 0x06b1accc
	System.Void ReqKickTribeMember(System.String tribeID, System.String memberID, System.Action action); // 0x06b1afa4
	System.Void ReqApplyToTribe(System.String tribeID, System.Action action); // 0x06b1b420
	System.Void ReqHandleTribeApply(System.String tribeID, System.String playerName, System.String roleID, System.Boolean isAccept, System.Action action); // 0x06b1b81c
	System.Void ReqRejectAllTribeApply(System.String tribeID, System.Action action); // 0x06b1bc94
	System.Void ReqSearchTribe(System.String query, System.Int32 searchType, System.Action<SimpleJSON.JSONNode> action); // 0x06b1c0b8
	System.Void ReqGetRecommendTribe(System.Action<SimpleJSON.JSONNode> action); // 0x06b1c458
	System.Void ReqModifyTribeLampTitles(System.String tribeID, System.String[] names); // 0x06b1c680
	System.Void ReqEquipTribeLampTitle(System.String tribeID, System.Action cb); // 0x06b1cae4
	System.Void ReqSetTribeAnnouncement(System.String tribeID, System.String announcement, System.Action cb); // 0x06b1cee0
	System.Void ReqUpgradeToAdvancedTribe(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String tribeID); // 0x06b1d35c
	System.Void EnterTribeNotify(System.String tribeID, System.Boolean needSendChatMsg); // 0x06b1d770
	System.Void ExitTribeNotify(System.String tribeID); // 0x06b1d8a0
	System.Void OnTribeApply(SimpleJSON.JSONNode jsonNode); // 0x06b1d920
	System.Void OnTribeInvite(SimpleJSON.JSONNode jsonNode); // 0x06b1da90
	System.Void AddTribeMemberInGame(System.String inGameGroupID, System.String roleId); // 0x06b1def0
	System.Void RemoveTribeMemberInGame(System.String inGameGroupID, System.String roleId); // 0x06b1e248
	System.Void DestoryTribeInGame(System.String inGameGroupID); // 0x06b1e440
	System.Void ReqShareTeamToTribe(System.String tribeID, WizardGames.Soc.SocClient.Ui.ERecruitType eRecruitType); // 0x06b1e680
	System.Void ShareLobbyTeamToTribe(System.String tribeID); // 0x06b1e850
	System.Void ShareAppointmentTeamToTribe(System.String tribeID); // 0x06b1ec9c
	System.Void ShareGameTeamToTribe(System.String tribeID); // 0x06b1f0e8
	System.Void SendAnnouncementToTribe(System.String tribeID, System.String content); // 0x06b1f6f4
	System.Void OnLobbyReconnected(); // 0x06b1f7b0
	System.Void OnFastReconnected(); // 0x06b1f914
	System.Void ClearData(); // 0x06b1f828
	System.Void OnAccountLogout(); // 0x06b1f98c
	System.Boolean CheckIsGraduated(); // 0x06b1facc
	System.Boolean HasPopupedGraduatedMsgBox(); // 0x06b1fc00
	System.Void SetHasPopupedGraduatedMsgBox(); // 0x06b1fcc4
	System.Boolean CheckNeedShowGraduatedTip(); // 0x06b1fd98
	System.Void SetOfflineNotify(System.Collections.Generic.List<System.String> notifys); // 0x06b1fe1c
	System.Void ClearOfflineNotify(); // 0x06b1fe9c
	System.Void TryPopSpecialTip(); // 0x06b1ff40
	System.Boolean NeedShowTribeSpecialTipTextInBtn(System.String& tips); // 0x06b203d8
	System.Void SetScanQrCodeJoinTribeTipData(System.String param); // 0x06b206b8
	System.Void CheckAndPopScanQrCodeJoinTribeMsgBox(); // 0x06b13f28
	System.Void ClearScanQrCodeJoinTribeTipData(); // 0x06b1fa2c
	System.Boolean IsShowTribeUpTips(); // 0x06b20544
	System.Boolean IsShowTribeUpRedDotOne(WizardGames.Soc.SocClient.Ui.TribeInfo tribe); // 0x06b20a0c
	System.Void SetUpgradeRDIsShow(System.String tribeID); // 0x06b20b88
	System.Void .ctor(); // 0x06b20cbc
	static System.Void .cctor(); // 0x06b20f44
	System.Void <ReqGetTribeInviteList>b__75_0(SimpleJSON.JSONNode info); // 0x06b21018
	System.Void <CheckAndPopScanQrCodeJoinTribeMsgBox>b__119_0(); // 0x06b214bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c <>9; // 0x0
	static System.Action<SimpleJSON.JSONNode> <>9__7_0; // 0x8
	static System.Action<SimpleJSON.JSONNode> <>9__7_1; // 0x10
	static System.Action<SimpleJSON.JSONNode> <>9__8_0; // 0x18
	static System.Action<SimpleJSON.JSONNode> <>9__8_1; // 0x20
	static System.Action<SimpleJSON.JSONNode> <>9__9_0; // 0x28
	static System.Action<SimpleJSON.JSONNode> <>9__9_1; // 0x30
	static System.Action<SimpleJSON.JSONNode> <>9__13_0; // 0x38
	static System.Action<SimpleJSON.JSONNode> <>9__13_1; // 0x40
	static System.Comparison<WizardGames.Soc.SocClient.Ui.TribeInfo> <>9__48_0; // 0x48
	static System.Comparison<WizardGames.Soc.SocClient.Ui.TribeInviteInfo> <>9__51_0; // 0x50
	static System.Action<SimpleJSON.JSONNode> <>9__61_1; // 0x58
	static System.Action<SimpleJSON.JSONNode> <>9__62_1; // 0x60
	static System.Action<SimpleJSON.JSONNode> <>9__63_1; // 0x68
	static System.Action<SimpleJSON.JSONNode> <>9__64_1; // 0x70
	static System.Action<SimpleJSON.JSONNode> <>9__65_1; // 0x78
	static System.Action<SimpleJSON.JSONNode> <>9__66_1; // 0x80
	static System.Action<SimpleJSON.JSONNode> <>9__67_1; // 0x88
	static System.Action<SimpleJSON.JSONNode> <>9__74_1; // 0x90
	static System.Action<SimpleJSON.JSONNode> <>9__77_1; // 0x98
	static System.Action<SimpleJSON.JSONNode> <>9__78_1; // 0xa0
	static System.Action<SimpleJSON.JSONNode> <>9__79_2; // 0xa8
	static System.Action<SimpleJSON.JSONNode> <>9__79_1; // 0xb0
	static System.Action<SimpleJSON.JSONNode> <>9__80_1; // 0xb8
	static System.Action<SimpleJSON.JSONNode> <>9__82_1; // 0xc0
	static System.Action<SimpleJSON.JSONNode> <>9__85_1; // 0xc8
	static System.Action<SimpleJSON.JSONNode> <>9__86_1; // 0xd0
	static System.Action<SimpleJSON.JSONNode> <>9__87_1; // 0xd8
	static System.Action<SimpleJSON.JSONNode> <>9__88_1; // 0xe0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.TribeInviteInfo> <>9__92_0; // 0xe8
	static System.Void .cctor(); // 0x06b21530
	System.Void .ctor(); // 0x06b21594
	System.Void <ReqAddActiveByChat>b__7_0(SimpleJSON.JSONNode info); // 0x06b215fc
	System.Void <ReqAddActiveByChat>b__7_1(SimpleJSON.JSONNode error); // 0x06b21768
	System.Void <ReqAddActiveByShareTeam>b__8_0(SimpleJSON.JSONNode info); // 0x06b219e0
	System.Void <ReqAddActiveByShareTeam>b__8_1(SimpleJSON.JSONNode error); // 0x06b21b4c
	System.Void <ReqAddActiveByResponseJoinTeam>b__9_0(SimpleJSON.JSONNode info); // 0x06b21dc4
	System.Void <ReqAddActiveByResponseJoinTeam>b__9_1(SimpleJSON.JSONNode error); // 0x06b21f30
	System.Void <ReqRepairTribeChat>b__13_0(SimpleJSON.JSONNode info); // 0x06b221a8
	System.Void <ReqRepairTribeChat>b__13_1(SimpleJSON.JSONNode error); // 0x06b22314
	System.Int32 <SortTribeInfos>b__48_0(WizardGames.Soc.SocClient.Ui.TribeInfo a, WizardGames.Soc.SocClient.Ui.TribeInfo b); // 0x06b22544
	System.Int32 <AddTribeInviteInfo>b__51_0(WizardGames.Soc.SocClient.Ui.TribeInviteInfo a, WizardGames.Soc.SocClient.Ui.TribeInviteInfo b); // 0x06b227a8
	System.Void <ReqCreateTribe>b__61_1(SimpleJSON.JSONNode error); // 0x06b2283c
	System.Void <ReqModifyTribeTags>b__62_1(SimpleJSON.JSONNode error); // 0x06b22a9c
	System.Void <ReqModifyTribeIcon>b__63_1(SimpleJSON.JSONNode error); // 0x06b22cfc
	System.Void <ReqModifyTribeName>b__64_1(SimpleJSON.JSONNode error); // 0x06b22f5c
	System.Void <ReqModifyTribePermission>b__65_1(SimpleJSON.JSONNode error); // 0x06b231bc
	System.Void <ReqExitTribe>b__66_1(SimpleJSON.JSONNode error); // 0x06b2341c
	System.Void <ReqDismissTribe>b__67_1(SimpleJSON.JSONNode error); // 0x06b2367c
	System.Void <ReqReplaceSystemTribe>b__74_1(SimpleJSON.JSONNode error); // 0x06b238dc
	System.Void <ReqRejectTribeInvite>b__77_1(SimpleJSON.JSONNode error); // 0x06b23b3c
	System.Void <ReqRejectAllTribeInvite>b__78_1(SimpleJSON.JSONNode error); // 0x06b23d9c
	System.Void <ReqKickTribeMember>b__79_2(SimpleJSON.JSONNode jsonNode); // 0x06b23ffc
	System.Void <ReqKickTribeMember>b__79_1(SimpleJSON.JSONNode error); // 0x06b24140
	System.Void <ReqApplyToTribe>b__80_1(SimpleJSON.JSONNode error); // 0x06b243a0
	System.Void <ReqRejectAllTribeApply>b__82_1(SimpleJSON.JSONNode error); // 0x06b24600
	System.Void <ReqModifyTribeLampTitles>b__85_1(SimpleJSON.JSONNode error); // 0x06b24860
	System.Void <ReqEquipTribeLampTitle>b__86_1(SimpleJSON.JSONNode error); // 0x06b24b00
	System.Void <ReqSetTribeAnnouncement>b__87_1(SimpleJSON.JSONNode error); // 0x06b24d60
	System.Void <ReqUpgradeToAdvancedTribe>b__88_1(SimpleJSON.JSONNode error); // 0x06b24fc0
	System.Int32 <OnTribeInvite>b__92_0(WizardGames.Soc.SocClient.Ui.TribeInviteInfo a, WizardGames.Soc.SocClient.Ui.TribeInviteInfo b); // 0x06b25220
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass61_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ETribeGroupType groupType; // 0x10
	System.String icon; // 0x18
	System.String name; // 0x20
	System.Collections.Generic.List<System.String> tags; // 0x28
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x30
	System.Action<System.String> CallBack; // 0x38
	System.Void .ctor(); // 0x06b16c90
	System.Void <ReqCreateTribe>b__0(SimpleJSON.JSONNode info); // 0x06b252b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass62_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x10
	System.String tribeID; // 0x18
	System.Collections.Generic.List<System.String> tags; // 0x20
	System.Void .ctor(); // 0x06b171dc
	System.Void <ReqModifyTribeTags>b__0(SimpleJSON.JSONNode info); // 0x06b25678
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass63_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x10
	System.String tribeID; // 0x18
	System.Int32 iconId; // 0x20
	System.Void .ctor(); // 0x06b176a8
	System.Void <ReqModifyTribeIcon>b__0(SimpleJSON.JSONNode info); // 0x06b2585c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass64_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x10
	System.String tribeID; // 0x18
	System.String name; // 0x20
	System.Action acion; // 0x28
	System.Void .ctor(); // 0x06b17b90
	System.Void <ReqModifyTribeName>b__0(SimpleJSON.JSONNode info); // 0x06b25a40
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass65_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x10
	System.String tribeID; // 0x18
	System.Boolean allowMemberApproval; // 0x20
	System.Boolean allowMemberInvite; // 0x21
	System.Void .ctor(); // 0x06b180e8
	System.Void <ReqModifyTribePermission>b__0(SimpleJSON.JSONNode info); // 0x06b25cfc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass66_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x10
	System.String tribeID; // 0x18
	System.Action action; // 0x20
	System.Void .ctor(); // 0x06b18578
	System.Void <ReqExitTribe>b__0(SimpleJSON.JSONNode info); // 0x06b25ee4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass67_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x10
	System.String tribeID; // 0x18
	System.Action action; // 0x20
	System.Void .ctor(); // 0x06b18a08
	System.Void <ReqDismissTribe>b__0(SimpleJSON.JSONNode info); // 0x06b2607c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass68_0 : System.Object
{
	System.Action<SimpleJSON.JSONNode> callback; // 0x10
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x18
	System.String tribeID; // 0x20
	System.Void .ctor(); // 0x06b18e18
	System.Void <ReqTribeDetailInfo>b__0(SimpleJSON.JSONNode info); // 0x06b26214
	System.Void <ReqTribeDetailInfo>b__1(SimpleJSON.JSONNode error); // 0x06b2638c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass69_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x06b18e80
	System.Void <ReqGetMyTribeBaseInfos>b__0(SimpleJSON.JSONNode info); // 0x06b2664c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrInterestTribe.<>c__DisplayClass71_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrInterestTribe <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x06b26bdc
	System.Void <UpdateMyAllTribeInfos>b__0(SimpleJSON.JSONNode info); // 0x06b26c44
}
