	System.Void .ctor(); // 0x05ba4a38
	System.Void OnBoardInit(); // 0x05ba5158
	System.Void OnBoardDestroy(); // 0x05ba52a4
	System.Void OnEnable(); // 0x05ba5414
	System.Void OnDisable(); // 0x05ba5854
	System.Void Update(); // 0x05ba59c8
	System.Void RefreshPreAutoPickItem(System.Boolean ignoreBlackList); // 0x05ba5a34
	System.Void PackUpPickList(); // 0x05ba5cf8
	System.Void ClosePickableItemList(); // 0x05ba5ef8
	System.Boolean CheckAutoPick(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05ba1b2c
	WizardGames.Soc.SocClient.Ui.ItemNodeInfo UpdatePreAutoPickItem(); // 0x05ba5bac
	System.Void CheckFakeHandle(WizardGames.Soc.SocClient.Ui.AutoPriorityPickChecker pickChecker, System.Int32 fakeId); // 0x05ba5f98
	System.Void SetAutoPickItemsList(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05ba6574
	System.Void SetAutoPickRewardBoxItemsDic(System.Int64 collectionId, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05ba63bc
	System.Void OnNearbyCorpseChange(); // 0x05ba562c
	System.Void OnNearbyRewardBoxChange(); // 0x05ba5740
	System.Void RefreshDeadPlayerCollection<T>(System.Collections.Generic.Dictionary<System.Int64,T> collectionDic, System.Collections.Generic.Dictionary<System.Int64,System.Boolean> collectionIdDic); // 0x052af1f0
	System.Collections.Generic.List<WizardGames.Soc.Share.Framework.EntityBase> GetAllCollections(); // 0x05ba68f4
	System.Collections.Generic.List<System.Int64> GetRewardBoxEntityIdList(); // 0x05ba6c8c
	System.Boolean IsExpansionBackpacks(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05ba67a0
	static System.Void .cctor(); // 0x05ba6f0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PickListDisplayComparer : System.Object
{
	
	static System.Int32 Compare(WizardGames.Soc.Common.CustomType.BaseItemNode a, WizardGames.Soc.Common.CustomType.BaseItemNode b); // 0x05ba6fac
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.PageType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.PageType Pickable = 0;
	static WizardGames.Soc.SocClient.Ui.PageType RewardBox = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudCommonPlayerStatus : System.Object
{
	System.Int32 curMaxLevel; // 0x10
	System.Boolean canSprint; // 0x14
	System.Int32 refreshWorkbenchCount; // 0x18
	WizardGames.Soc.SocClient.Ui.UiPlayerStatusData data; // 0x20
	WizardGames.Soc.SocClient.Ui.UiHudPlayerBuff playerBuff; // 0x28
	WizardGames.Soc.SocClient.Ui.UiHudPlayerMetabolism playerMetabolismTip; // 0x30
	WizardGames.Soc.SocClient.Ui.UiHudElemPlayerStatusDetailList playerMsgList; // 0x38
	System.Action<System.Collections.Generic.List<System.Int32>> hudStateChangedAction; // 0x40
	System.Action<System.Boolean> buildPanelExpandStateChangedAction; // 0x48
	System.Action<System.Boolean> shortCutsChooseMenuStateChangeAction; // 0x50
	System.Action<System.Boolean> shortCutsDeployModeStateChangedAction; // 0x58
	System.Void set_IsInjuredDown(System.Boolean value); // 0x05ba7278
	System.Void Bind(FairyGUI.GComponent node, WizardGames.Soc.Common.Unity.Ui.UiEditable board); // 0x05ba7300
	System.Void OnDispose(); // 0x05ba77ac
	System.Void SetStatusListenerAction(System.Action<System.Collections.Generic.List<System.Int32>> hudState, System.Action<System.Boolean> buildStateChange, System.Action<System.Boolean> shortCutsChoose, System.Action<System.Boolean> shortcutsDeploy); // 0x05ba7b2c
	System.Void RefreshStatus(); // 0x05ba7c00
	System.Void OnFps1PlayerStatusUpdate(System.Single dt); // 0x05ba7f10
	System.Void CheckWorktableLevel(); // 0x05ba7f88
	System.Void OnFps10PlayerStatusUpdate(System.Single dt); // 0x05ba8270
	System.Void CheckMaxWorktableLevel(); // 0x05ba8048
	System.Boolean OnDisappearConditionFunc(); // 0x05ba8304
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x05ba8370
	System.Void OnLocalPlayerAddBuff(WizardGames.Soc.SocSimulator.Buff.BuffItem buffItem); // 0x05ba8404
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocSimulator.Buff.BuffItem> GetMyPlayerBuff(); // 0x05ba860c
	System.Void OnLocalPlayerRemoveBuff(WizardGames.Soc.SocSimulator.Buff.BuffItem buffItem); // 0x05ba8704
	System.Void OnLocalPlayerUpdateBuff(WizardGames.Soc.SocSimulator.Buff.BuffItem buffItem); // 0x05ba8778
	System.Void InitplayerMsgList(FairyGUI.GComponent node); // 0x05ba76ec
	System.Void .ctor(); // 0x05ba87ec
	System.Boolean <CheckMaxWorktableLevel>b__20_0(); // 0x05ba885c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudCommonPlayerStatus.<>c__DisplayClass23_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudCommonPlayerStatus <>4__this; // 0x10
	System.Int32 buffId; // 0x18
	System.Void .ctor(); // 0x05ba9000
	System.Boolean <OnLocalPlayerAddBuff>b__0(); // 0x05ba9068
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBar : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiPlayerStatusData uiData; // 0x10
	FairyGUI.GProgressBar mainBar; // 0x18
	FairyGUI.GImage barImg; // 0x20
	FairyGUI.GImage baseBarImg; // 0x28
	FairyGUI.GImage bgBar; // 0x30
	FairyGUI.GImage warnBar; // 0x38
	FairyGUI.GTextField barTextField; // 0x40
	FairyGUI.GLoader iconLoader; // 0x48
	System.Int32 needAnimValue; // 0x50
	FairyGUI.Transition barLessTrans; // 0x58
	System.Single redFlashingValue; // 0x60
	System.Single orangeFlashingValue; // 0x64
	UnityEngine.Color offsetCol; // 0x68
	FairyGUI.Controller ctrIsBuildMode; // 0x78
	System.Void Init(WizardGames.Soc.SocClient.Ui.UiPlayerStatusData uiData, FairyGUI.GComponent root, System.Int32 maxValue); // 0x05ba9110
	System.Void UpdateCtrBuildModeState(System.Int32 index); // 0x05ba91ac
	System.Void OnDestroy(); // 0x05ba9240
	System.Void OnEnable(); // 0x05ba92a0
	System.Void Refresh(); // 0x055049cc
	System.Void SetBarValue(System.Int32 curValue, System.Int32 maxValue); // 0x05ba9300
	System.Void SetHPBarValue(System.Int32 curValue, System.Int32 maxValue); // 0x05ba9574
	System.Void SetBarLessTrans(); // 0x05ba97bc
	System.Void SetBaseBarValue(System.Single curBaseValue); // 0x05ba9b60
	System.Void SetBaseBarColor(UnityEngine.Color color); // 0x05ba9c78
	System.Void .ctor(); // 0x05ba9d90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnGetOff : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	FairyGUI.GButton mainBtn; // 0x190
	WizardGames.Soc.Common.Data.EHotKeyGuideGroup guideId; // 0x198
	System.Boolean isDriver; // 0x19c
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05ba9f08
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05baa040
	System.Void OnHotKeyAction(); // 0x05baa0a4
	System.Void OnEnable(); // 0x05baa120
	System.Void OnDisable(); // 0x05baa504
	System.Void OnFps10Update(System.Single dt); // 0x05baa5a0
	System.Void UpdateVichielGuide(); // 0x05baa190
	System.Void OnClick(); // 0x05baa6cc
	System.Void SendWantsDismount(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.Unity.Go.IMountable mountable); // 0x05baa808
	System.Void .ctor(); // 0x05baaa1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnVehicleAutoDrive : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GButton mainBtn; // 0x190
	FairyGUI.Controller mainBtnCtrl; // 0x198
	FairyGUI.Controller autoDriveCtrl; // 0x1a0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05baaa84
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05baad38
	System.Void OnHotKeyAction(); // 0x05baad9c
	System.Void OnBoardInit(); // 0x05baae18
	System.Void OnVehicleAutoDriveChange(); // 0x05baac30
	System.Void OnClick(); // 0x05baaf1c
	System.Void OnBoardDestroy(); // 0x05bab00c
	System.Void .ctor(); // 0x05bab110
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnVehicleBack : WizardGames.Soc.SocClient.Ui.UiHudElemVehicleDirection, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate_Input, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05bab178
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05bab1f8
	System.Void OnDisable(); // 0x05bab25c
	System.Void TouchBegin(); // 0x05bab2cc
	System.Void OnFps30Update(System.Single dt); // 0x05bab378
	System.Void OnFpsUnlimitedUpdate_Input(System.Single dt); // 0x05bab3ec
	System.Void .ctor(); // 0x05bab4b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnVehicleForward : WizardGames.Soc.SocClient.Ui.UiHudElemVehicleDirection, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate_Input, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05bab520
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05bab630
	System.Void OnDisable(); // 0x05bab694
	System.Void OnVehicleAutoDriveChange(); // 0x05bab744
	System.Void TouchEnd(); // 0x05bab888
	System.Void OnFps30Update(System.Single dt); // 0x05bab934
	System.Void OnFpsUnlimitedUpdate_Input(System.Single dt); // 0x05bab9a8
	System.Void OnBoardDestroy(); // 0x05baba74
	System.Void .ctor(); // 0x05babb78
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnVehicleLeft : WizardGames.Soc.SocClient.Ui.UiHudElemVehicleDirection, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate_Input, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05babbe0
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05babc60
	System.Void OnDisable(); // 0x05babcc4
	System.Void OnFps30Update(System.Single dt); // 0x05babd34
	System.Void OnFpsUnlimitedUpdate_Input(System.Single dt); // 0x05babda8
	System.Void .ctor(); // 0x05babe74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnVehicleRight : WizardGames.Soc.SocClient.Ui.UiHudElemVehicleDirection, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate_Input, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05babedc
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05babf5c
	System.Void OnDisable(); // 0x05babfc0
	System.Void OnFps30Update(System.Single dt); // 0x05bac030
	System.Void OnFpsUnlimitedUpdate_Input(System.Single dt); // 0x05bac0a4
	System.Void .ctor(); // 0x05bac170
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.EntityInteractiveIdHandle : System.Object
{
	static WizardGames.Soc.SocClient.Ui.BoxEntityInteractiveIdHandle boxEntityHandle; // 0x0
	static WizardGames.Soc.SocClient.Ui.InteractionEntityInteractiveIdHandle interactionEntityHandle; // 0x8
	static WizardGames.Soc.SocClient.Ui.VehicleEntityInteractiveIdHandle vehicleEntityHandle; // 0x10
	static WizardGames.Soc.SocClient.Ui.CorpseEntityInteractiveIdHandle corpseEntityHandle; // 0x18
	static WizardGames.Soc.SocClient.Ui.ElevatorEntityInteractiveIdHandle elevatorEntityHandle; // 0x20
	static WizardGames.Soc.SocClient.Ui.CaveLiftEntityInteractiveIdHandle caveLiftEntityHandle; // 0x28
	static WizardGames.Soc.SocClient.Ui.KatyushaEntityInteractiveIdHandle katyushaEntityHandle; // 0x30
	static WizardGames.Soc.SocClient.Ui.NPCEntityInteractiveIdHandle npcEntityHandle; // 0x38
	static WizardGames.Soc.SocClient.Ui.DigEntityInteractiveIdHandle digEntityHandle; // 0x40
	static WizardGames.Soc.SocClient.Ui.IOEntityInteractiveIdHandle ioEntityHandle; // 0x48
	static WizardGames.Soc.SocClient.Ui.PartEntityInteractiveIdHandle partEntityHandle; // 0x50
	static WizardGames.Soc.SocClient.Ui.ShopEntityInteractiveIdHandle shopEntityHandle; // 0x58
	static WizardGames.Soc.SocClient.Ui.PlayerEntityInteractiveIdHandle playerEntityHandle; // 0x60
	static WizardGames.Soc.SocClient.Ui.TempCofferEntityInteractiveIdHandle tempCofferEntityHandle; // 0x68
	static WizardGames.Soc.SocClient.Ui.TrainCarHandle trainCarHandle; // 0x70
	static WizardGames.Soc.SocClient.Ui.StorageDebrisHandle storageDebrisHandle; // 0x78
	static System.Collections.Generic.List<System.Int32> _safeBoxUnLockInteractiveId; // 0x80
	static System.Collections.Generic.List<System.Int32> InteractiveIdHandle(WizardGames.Soc.Common.Entity.IEntity baseEntity, System.Int32 entityTypeId, UnityEngine.GameObject hitGo, System.String& showName); // 0x05bac1d8
	static System.Void .cctor(); // 0x05bac6c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BoxEntityInteractiveIdHandle : WizardGames.Soc.SocClient.Ui.EntityInteractiveIdHandleBase
{
	
	System.Void InteractiveIdHandle(WizardGames.Soc.Common.Entity.IEntity baseEntity, UnityEngine.GameObject hitGo); // 0x05bad27c
	System.Void .ctor(); // 0x05bacbf0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InteractionEntityInteractiveIdHandle : WizardGames.Soc.SocClient.Ui.EntityInteractiveIdHandleBase
{
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PoiTaskNode> poiNodes; // 0x28
	System.Void InteractiveIdHandle(WizardGames.Soc.Common.Entity.IEntity baseEntity, UnityEngine.GameObject hitGo); // 0x05bada08
	System.Void .ctor(); // 0x05bacc54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.VehicleEntityInteractiveIdHandle : WizardGames.Soc.SocClient.Ui.EntityInteractiveIdHandleBase
{
	
	System.Void InteractiveIdHandle(WizardGames.Soc.Common.Entity.IEntity baseEntity, UnityEngine.GameObject hitGo); // 0x05badf38
	System.Void PushVehicle(WizardGames.Soc.Common.Entity.IBaseMountableEntity mountableEntity); // 0x05bae1d0
	System.Void .ctor(); // 0x05bacd04
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.CorpseEntityInteractiveIdHandle : WizardGames.Soc.SocClient.Ui.EntityInteractiveIdHandleBase
{
	
	System.Void InteractiveIdHandle(WizardGames.Soc.Common.Entity.IEntity baseEntity, UnityEngine.GameObject hitGo); // 0x05bae70c
	System.Void .ctor(); // 0x05bacd68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ElevatorEntityInteractiveIdHandle : WizardGames.Soc.SocClient.Ui.EntityInteractiveIdHandleBase
{
	
	System.Void InteractiveIdHandle(WizardGames.Soc.Common.Entity.IEntity baseEntity, UnityEngine.GameObject hitGo); // 0x05bae8cc
	System.Void .ctor(); // 0x05bacdcc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.CaveLiftEntityInteractiveIdHandle : WizardGames.Soc.SocClient.Ui.EntityInteractiveIdHandleBase
{
	
	System.Void InteractiveIdHandle(WizardGames.Soc.Common.Entity.IEntity baseEntity, UnityEngine.GameObject hitGo); // 0x05baed10
	System.Void .ctor(); // 0x05bace30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.KatyushaEntityInteractiveIdHandle : WizardGames.Soc.SocClient.Ui.EntityInteractiveIdHandleBase
{
	
	System.Void InteractiveIdHandle(WizardGames.Soc.Common.Entity.IEntity baseEntity, UnityEngine.GameObject hitGo); // 0x05baeecc
	System.Void .ctor(); // 0x05bace94
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TempCofferEntityInteractiveIdHandle : WizardGames.Soc.SocClient.Ui.EntityInteractiveIdHandleBase
{
	
	System.Void InteractiveIdHandle(WizardGames.Soc.Common.Entity.IEntity baseEntity, UnityEngine.GameObject hitGo); // 0x05baf1f0
	System.Void .ctor(); // 0x05bad150
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TrainCarHandle : WizardGames.Soc.SocClient.Ui.EntityInteractiveIdHandleBase
{
	
	System.Void InteractiveIdHandle(WizardGames.Soc.Common.Entity.IEntity baseEntity, UnityEngine.GameObject hitGo); // 0x05baf504
	System.Void .ctor(); // 0x05bad1b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.StorageDebrisHandle : WizardGames.Soc.SocClient.Ui.EntityInteractiveIdHandleBase
{
	
	System.Void InteractiveIdHandle(WizardGames.Soc.Common.Entity.IEntity baseEntity, UnityEngine.GameObject hitGo); // 0x05baf804
	System.Void .ctor(); // 0x05bad218
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.NPCEntityInteractiveIdHandle : WizardGames.Soc.SocClient.Ui.EntityInteractiveIdHandleBase
{
	
	System.Void InteractiveIdHandle(WizardGames.Soc.Common.Entity.IEntity baseEntity, UnityEngine.GameObject hitGo); // 0x05bafa50
	System.Void .ctor(); // 0x05bacef8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.DigEntityInteractiveIdHandle : WizardGames.Soc.SocClient.Ui.EntityInteractiveIdHandleBase
{
	
	System.Void InteractiveIdHandle(WizardGames.Soc.Common.Entity.IEntity baseEntity, UnityEngine.GameObject hitGo); // 0x05bafeac
	System.Void .ctor(); // 0x05bacf5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.IOEntityInteractiveIdHandle : WizardGames.Soc.SocClient.Ui.EntityInteractiveIdHandleBase
{
	
	System.Void InteractiveIdHandle(WizardGames.Soc.Common.Entity.IEntity baseEntity, UnityEngine.GameObject hitGo); // 0x05bb0308
	System.Void .ctor(); // 0x05bacfc0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PartEntityInteractiveIdHandle : WizardGames.Soc.SocClient.Ui.EntityInteractiveIdHandleBase
{
	
	System.Void InteractiveIdHandle(WizardGames.Soc.Common.Entity.IEntity baseEntity, UnityEngine.GameObject hitGo); // 0x05bb0664
	System.Boolean CanShowInNewbie(System.Int64 id); // 0x05bb0ffc
	System.Void .ctor(); // 0x05bad024
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ShopEntityInteractiveIdHandle : WizardGames.Soc.SocClient.Ui.EntityInteractiveIdHandleBase
{
	
	System.Void InteractiveIdHandle(WizardGames.Soc.Common.Entity.IEntity baseEntity, UnityEngine.GameObject hitGo); // 0x05bb1094
	System.Void .ctor(); // 0x05bad088
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PlayerEntityInteractiveIdHandle : WizardGames.Soc.SocClient.Ui.EntityInteractiveIdHandleBase
{
	
	System.Void InteractiveIdHandle(WizardGames.Soc.Common.Entity.IEntity baseEntity, UnityEngine.GameObject hitGo); // 0x05bb123c
	System.Boolean CanCureOther(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x05bb1348
	System.Void .ctor(); // 0x05bad0ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.EntityInteractiveIdHandleBase : System.Object
{
	System.Collections.Generic.List<System.Int32> interactiveIdList; // 0x10
	System.String showName; // 0x18
	SocLogger logger; // 0x20
	System.Collections.Generic.List<System.Int32> get_InteractiveIdList(); // 0x05bb16f0
	System.String get_ShowName(); // 0x05bb1754
	System.Void Clear(); // 0x05bad5ac
	System.Void InteractiveIdHandle(WizardGames.Soc.Common.Entity.IEntity baseEntity, UnityEngine.GameObject hitGo); // 0x0552af00
	System.Void AddInteractiveIdList(System.Collections.Generic.List<System.Int32> interactiveIds); // 0x05bad658
	System.Void AddInteractiveId(System.Int32 interactiveId); // 0x05bae600
	System.Boolean InteractiveIdCheck(System.Int32 interactiveId); // 0x05bb17b8
	System.Boolean CheckCondition(System.Int32 interactiveId); // 0x05bb18c4
	System.Void .ctor(); // 0x05bad880
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InteractiveIdListChecker : System.Object
{
	static SocLogger Log; // 0x0
	static System.String <LandMineName>k__BackingField; // 0x8
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.EInteractionType> interactionTypeSet; // 0x10
	UnityEngine.Collider[] checkDoorHitBuffer; // 0x18
	System.Collections.Generic.List<System.Int32> waterIdList; // 0x20
	System.Single lastDistance; // 0x28
	static System.Int64 LandMineEntityId; // 0x10
	static System.Int64 curRayEntityId; // 0x18
	static System.Int64 <CurAimEntityId>k__BackingField; // 0x20
	static WizardGames.Soc.SocClient.Systems.HitObjData <CurAimHitObjData>k__BackingField; // 0x28
	static System.Int64 curEyeEntityId; // 0x30
	static UnityEngine.GameObject curEyeGameObject; // 0x38
	static System.String curEyeEntityName; // 0x40
	System.String lastCurEyeEntityName; // 0x30
	System.String waterName; // 0x38
	System.String vehicleName; // 0x40
	System.Collections.Generic.List<System.Int32> interactiveIdList; // 0x48
	System.Collections.Generic.List<System.Int32> lastInteractiveIdList; // 0x50
	static System.Collections.Generic.List<System.Int32> interactiveIdSortList; // 0x48
	System.Action<System.Int64,System.Int64> EyeEntityIdChangeAction; // 0x58
	System.Action<System.Int64,UnityEngine.GameObject> EyeGameObjectChangeAction; // 0x60
	System.Action<System.Boolean,System.Int64,System.Boolean,UnityEngine.GameObject> InteractiveIdListChangeAction; // 0x68
	System.Action<System.Int64> UpdateDetectionAction; // 0x70
	System.Boolean canInteractEyeEntity; // 0x78
	static System.Int64 canInteractCrosshairEntityId; // 0x50
	System.Int64 bufferCheckDoorEntityId; // 0x80
	System.Single lastCheckDoorTime; // 0x88
	System.Int64 bufferCheckComboParentEntityId; // 0x90
	System.Single lastCheckComboTime; // 0x98
	System.Single lastCheckTrapAnimalTime; // 0x9c
	System.Int64 trapAnimalEntityId; // 0xa0
	UnityEngine.GameObject trapAnimalGo; // 0xa8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData> lastHitObjDataList; // 0xb0
	WizardGames.Soc.SocClient.Systems.HitObjData lastObstacleHitObjData; // 0xb8
	System.Collections.Generic.List<System.Int32> tagNotPassList; // 0xc0
	static System.Int64 <CurTrapAnimalEntityId>k__BackingField; // 0x58
	System.Int64 beRemovedEntityId; // 0xc8
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.InteractiveIdListChecker.InteractionRankData> interactionDataCache; // 0xd0
	static System.Collections.Generic.List<WizardGames.Soc.SocClient.EHudState> tempHudStates; // 0x60
	static System.Collections.Generic.HashSet<System.String> specialWin; // 0x68
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.InteractiveExtendData> extendData; // 0x70
	static SocLogger logger; // 0x78
	System.Collections.Generic.List<System.Int32> triggerBtnList; // 0xd8
	static System.Int32 LastTriggerBtnId; // 0x80
	System.Collections.Generic.List<System.Int32> allTriggerBtnSortedList; // 0xe0
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> allTriggerBtnIdToIndex; // 0xe8
	System.Collections.Generic.Dictionary<System.Int32,System.Func<System.Boolean>> triggerBtnCheckAction; // 0xf0
	static System.Boolean lootBtnVisible; // 0x84
	static System.Int64 lootBtnLootEntityId; // 0x88
	System.Int64 lastLootEntityId; // 0xf8
	static WizardGames.Soc.SocClient.Ui.ELadderState <LadderState>k__BackingField; // 0x90
	static WizardGames.Soc.SocClient.Ui.ENewbieRemoteControlState <RemoteControlState>k__BackingField; // 0x94
	static WizardGames.Soc.SocClient.Ui.EParachuteState <ParachuteState>k__BackingField; // 0x98
	static System.Int64 ParachuteCDTime; // 0xa0
	System.Int64 get_CurRayEntityId(); // 0x05bb1b04
	static System.Int64 get_CurEyeEntityId(); // 0x05bb1b94
	static UnityEngine.GameObject get_CurEyeGameObject(); // 0x05bb1c1c
	static System.String get_CurEyeEntityName(); // 0x05bb1ca4
	static System.String get_LandMineName(); // 0x05bb1d2c
	static System.Void set_LandMineName(System.String value); // 0x05bb1db4
	System.String get_WaterName(); // 0x05bb1e48
	System.String get_VehicleName(); // 0x05bb1eac
	static System.Collections.Generic.List<System.Int32> get_InteractiveIdSortList(); // 0x05bb1f10
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.EInteractionType> get_InteractionTypeSet(); // 0x05bb1f98
	static System.Int64 get_CurAimEntityId(); // 0x05bb1ffc
	static System.Void set_CurAimEntityId(System.Int64 value); // 0x05bb2084
	static WizardGames.Soc.SocClient.Systems.HitObjData get_CurAimHitObjData(); // 0x05bb2114
	static System.Void set_CurAimHitObjData(WizardGames.Soc.SocClient.Systems.HitObjData value); // 0x05bb219c
	static System.Int64 get_CanInteractCrosshairEntityId(); // 0x05bb2230
	static System.Int64 get_CurTrapAnimalEntityId(); // 0x05bb22b8
	static System.Void set_CurTrapAnimalEntityId(System.Int64 value); // 0x05bb2340
	System.Void OnInit(); // 0x05bb23d0
	System.Void OnDestroy(); // 0x05bb2f38
	static System.Int64 GetCurRayEntityId(); // 0x05bb395c
	System.Void CheckCurAimEntityId(); // 0x05bb39e4
	System.Void OnRemoveGo(System.Int64 entityId); // 0x05bb3ed4
	System.Void OnUiHideEvent(WizardGames.Soc.Common.Unity.Ui.WindowComBase window); // 0x05bb3f4c
	System.Boolean CheckNeedInterruptDetection(System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData> hitObjDataList, WizardGames.Soc.SocClient.Systems.HitObjData obstacle); // 0x05bb41ec
	System.Boolean CheckCurLootEntityDistance(); // 0x05bb4768
	System.Void UpdateDetection(System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData> hitObjDataList, WizardGames.Soc.SocClient.Systems.HitObjData obstacle); // 0x05bb4af0
	System.Boolean CheckHitObjChange(System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData> hitObjDataList, WizardGames.Soc.SocClient.Systems.HitObjData obstacle); // 0x05bb5a4c
	WizardGames.Soc.SocClient.Systems.HitObjData GetReallyHitObj(System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData> hitObjDataList); // 0x05bb44e4
	System.Void AdsStateChange(System.Int64 entityId, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum oldState, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum newState); // 0x05bb9504
	System.Void ProcessHitObject(WizardGames.Soc.SocClient.Systems.HitObjData hitObjData, System.Int64& entityId, UnityEngine.GameObject& gameObject); // 0x05bb6850
	System.Void HandleVehicleInteraction(System.Int64 entityId); // 0x05bb98b4
	System.Void UpdateMountableAndCollectable(); // 0x05bb6e0c
	System.Void UpdateLandMineDisposal(); // 0x05bb7864
	System.Void UpdateRFDetonationEntityDisposal(System.Int64 entityId); // 0x05bb7a5c
	System.Void HandleWaterInteraction(System.Int64 entityId); // 0x05bb6f94
	System.Void HandleEntityInteractionChange(System.Int64 entityId, System.String lastCurEyeEntityName); // 0x05bb8920
	System.Void HandleUIInteractionListChange(System.Int64 entityId, UnityEngine.GameObject hitObj); // 0x05bb8de8
	System.Boolean ContainsDriverSeat(System.Collections.Generic.List<System.Int32> interactiveIdList); // 0x05bb9da0
	System.Void UpdateEyeEntity(System.Int64 entityId, UnityEngine.GameObject gameObject); // 0x05bb9178
	System.Void CheckOutline(System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData> hitObjDataList, WizardGames.Soc.SocClient.Systems.HitObjData obstacle); // 0x05bb5bcc
	System.Boolean PlayerStateCheck(); // 0x05bb619c
	System.Boolean UpdateDistanceCheck(System.Int64 entityId); // 0x05bb9acc
	System.Void CheckComboParentEntity(System.Int64& entityId); // 0x05bb67b0
	System.Boolean ShouldRecheckComboParent(); // 0x05bba7dc
	WizardGames.Soc.Common.Entity.PartEntity FindValidComboParent(); // 0x05bba9b8
	WizardGames.Soc.Common.Entity.PartEntity GetExistingComboParent(); // 0x05bba8fc
	System.Void UpdateComboInteraction(WizardGames.Soc.Common.Entity.PartEntity comboParentEntity, System.Int64& entityId); // 0x05bbaacc
	System.Void CheckDoorEntity(System.Int64& entityId); // 0x05bb638c
	System.Void SearchAnimalTrapEntity(); // 0x05bb7cb8
	System.Void UpdateAnimalTrapCheck(); // 0x05bb7e58
	System.Void UpdateWaterHud(); // 0x05bba1f0
	System.Void UpdateWaterDetection(); // 0x05bbb89c
	System.Void HandleTriggerBtn(); // 0x05bb81d4
	System.Void UpdateCollectableEntityDetection(System.Int64 currentRayEntityId); // 0x05bb70dc
	System.Boolean CheckDoorRangeLegal(UnityEngine.Transform parentDoor, UnityEngine.Vector3 playerPos, System.Single& sAngle); // 0x05bbc1c0
	WizardGames.Soc.Common.Entity.PartEntity CheckPartAssistant(System.String assistTag); // 0x05bbb130
	System.Boolean CheckBufferAssistEntity(System.Int64& bufferEntityId, System.String tagName); // 0x05bbadfc
	System.Void Rank(); // 0x05bb9e64
	static System.Boolean IsAimHighlight(System.Int64 entityId); // 0x05bbc458
	System.Boolean IsVehicleEntityType(System.Int32 entityTypeId); // 0x05bb9808
	static System.Boolean IdIsVehicle(System.Int32 id); // 0x05bbc7b8
	static System.Boolean IdIsWater(System.Int32 id); // 0x05bbc874
	static System.Boolean IdIsCollectable(System.Int32 id); // 0x05bbc948
	static System.String GetCollectableEntityNameById(System.Int64 entityId); // 0x05bbc9b0
	static WizardGames.Soc.Common.Entity.IEntity GetEntityById(System.Int64 entityId); // 0x05bbcb58
	static System.String GetCollectableEntityName(System.Int64 templateId); // 0x05bbcc10
	static System.String GetRFC4EntityTitleName(); // 0x05bbcd30
	static System.Boolean CheckTag(System.Int32 interactiveId); // 0x05bbb678
	static System.Boolean CheckTag(System.Collections.Generic.List<System.Int32> interactiveIdList); // 0x05bb9650
	System.Void FilterNeedBlockInteractiveIds(System.Collections.Generic.List<System.Int32> filterList); // 0x05bb860c
	static WizardGames.Soc.SocClient.Ui.InteractiveExtendData GetInteractiveExtendData(System.Int32 interactiveId); // 0x05bbd220
	System.Void HandleExtendBtn(); // 0x05bb87b4
	System.Void DayNightAutoExtendBtn(System.Int32 interactiveId); // 0x05bbdd7c
	System.String GetDayNightAutoIcon(); // 0x05bbe194
	static System.Boolean CanShowDayNightAutoIconBtn(System.Boolean& isAutoState); // 0x05bbe28c
	static System.Boolean IsShowDayNightAutoState(); // 0x05bbe3a8
	static System.Void OnDayNightAutoClick(); // 0x05bbe4b4
	System.Void PleaseWaterContainerExtendBtn(System.Int32 interactiveId); // 0x05bbdbe0
	System.Void LackFuelExtendBtn(System.Int32 interactiveId); // 0x05bbda44
	System.Void AddResItemExtendBtn_FlameTurret(System.Int32 interactiveId); // 0x05bbd510
	System.Void AddResItemExtendBtn_Shotgun(System.Int32 interactiveId); // 0x05bbd6cc
	System.Void AddResItemExtendBtn_Genrator(System.Int32 interactiveId); // 0x05bbd888
	System.String GetAddAmmoIcon(); // 0x05bbe5d8
	System.String GetAddFuelIcon(); // 0x05bbe6c0
	static System.Void OnAddResItemClick(); // 0x05bbe7a8
	static System.String GetTitle(WizardGames.Soc.Common.Construction.PartType partType); // 0x05bbeaf0
	System.String GetAddResItemReplaceNameFunc_FlameTurret(); // 0x05bbec1c
	System.String GetAddResItemReplaceNameFunc_Shotgun(); // 0x05bbefdc
	System.String GetAddResItemReplaceNameFunc_Genrator(); // 0x05bbf0e8
	static System.Int64 GetNodeId(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x05bbea28
	System.String GetAddResItemReplaceName(WizardGames.Soc.Common.Entity.PartEntity partEntity, System.Int32 interactiveId); // 0x05bbed28
	System.Void AddOpenDoorExtendBtn(System.Int32 interactiveId); // 0x05bbd2f8
	static System.Boolean CanShowAutoOpenDoorBtn(); // 0x05bbf1f4
	System.String GetAutoOpenDoorIcon(); // 0x05bbf34c
	static System.Boolean CanAutoOpenDoor(); // 0x05bbf440
	static System.Void OnAutoOpenDoorClick(); // 0x05bbf524
	System.Boolean UpdateTriggerBtn_LadderSpeedUp(); // 0x05bbfb5c
	static System.Void RegistInteractiveExtend(System.Int32 interactiveId, System.String replaceIcon, System.Func<System.String> leftIconGetFunc, System.Func<System.String> replaceNameFunc, System.Action leftBtnClick, System.Action onClick, System.Func<System.Boolean> enableFunc, System.Func<System.Boolean> leftBtnEnableFunc, System.String leftText, System.Func<System.Boolean> leftAutoStatusFunc); // 0x05bbdf94
	static System.Boolean CheckIsTheRayEntityId(System.Int64 entityId); // 0x05bb9a68
	System.Void UpdateRangeInteractiveBox(System.Int64 entityId); // 0x05bb742c
	static WizardGames.Soc.SocClient.Ui.ELadderState get_LadderState(); // 0x05bc0000
	static System.Void set_LadderState(WizardGames.Soc.SocClient.Ui.ELadderState value); // 0x05bc0088
	static WizardGames.Soc.SocClient.Ui.ENewbieRemoteControlState get_RemoteControlState(); // 0x05bc0118
	static System.Void set_RemoteControlState(WizardGames.Soc.SocClient.Ui.ENewbieRemoteControlState value); // 0x05bc01a0
	static System.Boolean IsLaddderStateCan(); // 0x05bc0230
	static WizardGames.Soc.SocClient.Ui.EParachuteState get_ParachuteState(); // 0x05bc0390
	static System.Void set_ParachuteState(WizardGames.Soc.SocClient.Ui.EParachuteState value); // 0x05bc0418
	System.Void OnInitTriggerBtn(); // 0x05bb2848
	System.Void OnDestoryTriggerBtn(); // 0x05bb359c
	System.Void InitializeTriggerBtnCheckAction(); // 0x05bc0898
	static System.Boolean IsTriggerButton(System.Int32 interactiveId); // 0x05bbbe0c
	System.Void ReadAllTriggerBtnFromTable(); // 0x05bc04a8
	System.Void ClearAllTriggerBtnSortedList(); // 0x05bc0c68
	System.Void UpdateTriggerBtnList(); // 0x05bbbf04
	System.Boolean UpdateTriggerBtn_DropWater(); // 0x05bc0cec
	System.Boolean UpdateTriggerBtn_FillWater(); // 0x05bc0edc
	static System.Void SetLootStatus(System.Boolean isLoot, System.Int64 lootEntityId); // 0x05bc1070
	System.Boolean CheckLootEntityChange(); // 0x05bbc0fc
	System.Boolean UpdateTriggerBtn_Loot(); // 0x05bc111c
	System.Boolean UpdateTriggerBtn_ZiplineSpeedUp(); // 0x05bc1230
	System.Boolean UpdateTriggerBtn_Ladder(); // 0x05bc13b0
	System.Boolean UpdateTriggerBtn_LadderBottom(); // 0x05bc1524
	System.Boolean UpdateTriggerBtn_ParchuteOpen(); // 0x05bc1698
	System.Boolean UpdateTriggerBtn_ParchuteClose(); // 0x05bc188c
	System.Void OnLadderStateChange(WizardGames.Soc.SocClient.Ui.ELadderState state); // 0x05bc1a00
	System.Void OnShowNewbieRemoteControl(WizardGames.Soc.SocClient.Ui.ENewbieRemoteControlState state); // 0x05bc1c54
	System.Void OnParachuteStateChange(WizardGames.Soc.SocClient.Ui.EParachuteState state, System.Int32 cdTime); // 0x05bc1e28
	System.Boolean UpdateTriggerBtn_RemoteControlGreenBtn(); // 0x05bc1f90
	System.Boolean UpdateTriggerBtn_RemoteControlRedBtn(); // 0x05bc2100
	System.Void .ctor(); // 0x05bc2274
	static System.Void .cctor(); // 0x05bc25f4
	System.Void <UpdateWaterDetection>b__110_0(System.Int64 id, System.Object tata, System.Boolean delete); // 0x05bc2944
	System.Void <UpdateWaterDetection>b__110_1(System.Int64 id, System.Object tata, System.Boolean delete); // 0x05bc29d8
	System.Int32 <Rank>b__116_0(System.Int32 id1, System.Int32 id2); // 0x05bc2a6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InteractiveIdListChecker.TempLog : System.Object
{
	static System.Collections.Generic.HashSet<System.UInt64> whiteList; // 0x0
	static System.Single timeStart; // 0x8
	static System.Collections.Generic.List<System.String> msgList; // 0x10
	static System.Collections.Generic.List<System.String> printMsgList; // 0x18
	static System.Void ReleaseCritical(System.String msg); // 0x05bb632c
	static System.Void ClearTime(); // 0x05bb38d4
	static System.Void .cctor(); // 0x05bc2bec
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.InteractiveIdListChecker.InteractionRankData : System.ValueType
{
	System.Int32 Rank; // 0x10
	System.Int32 AcType; // 0x14
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InteractiveIdListChecker.InteractionSorter : System.Object
{
	
	static System.Int32 Compare(System.Int32 id1, System.Int32 id2, System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.InteractiveIdListChecker.InteractionRankData> dataDic); // 0x05bc2af4
	static System.Int32 CompareInteraction(System.Int32 a, System.Int32 b); // 0x05bc2e04
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InteractiveIdListChecker.InteractionRawCache : System.Object
{
	System.Int32[] IncludeIds; // 0x10
	System.Int32[] ExcludeIds; // 0x18
	System.Boolean IsValid; // 0x20
	System.Boolean HasEmptyInclude; // 0x21
	System.Void .ctor(); // 0x05bc2fa0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InteractiveIdListChecker.InteractionCacheManager : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.InteractiveIdListChecker.InteractionRawCache> Cache; // 0x0
	static System.Void PrebuildCache(); // 0x05bb2a5c
	static System.Int32[] SetToArray(System.Collections.Generic.HashSet<System.Int32> set); // 0x05bc3008
	static System.Void .cctor(); // 0x05bc3240
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InteractiveIdListChecker.InteractionBitsetContext : System.Object
{
	static System.Int32[] stateBuckets; // 0x0
	static System.Collections.Generic.List<WizardGames.Soc.SocClient.EHudState> tempHudStates; // 0x8
	static System.Int32 lastFrameIndex; // 0x10
	static System.Int32 currentHudStateHash; // 0x14
	static System.Void UpdateFrameStates(); // 0x05bbce4c
	static System.Void .cctor(); // 0x05bc32d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InteractiveIdListChecker.TagCheckCache : System.Object
{
	static WizardGames.Soc.SocClient.Ui.InteractiveIdListChecker.TagCheckCache.CacheEntry lastResult; // 0x0
	static System.Int32 currentHudStateHash; // 0xc
	static System.Void SetCache(System.Int32 id, System.Boolean result); // 0x05bbd180
	static System.Boolean TryGetCache(System.Int32 id, System.Boolean& result); // 0x05bbd0bc
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.InteractiveIdListChecker.TagCheckCache.CacheEntry : System.ValueType
{
	System.Int32 interactiveId; // 0x10
	System.Int32 hudStateHash; // 0x14
	System.Boolean result; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InteractiveIdListChecker.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.InteractiveIdListChecker.<>c <>9; // 0x0
	static System.Func<System.Boolean> <>9__142_0; // 0x8
	static System.Func<System.Boolean> <>9__143_0; // 0x10
	static System.Comparison<System.Int32> <>9__193_0; // 0x18
	static System.Void .cctor(); // 0x05bc33bc
	System.Void .ctor(); // 0x05bc3420
	System.Boolean <PleaseWaterContainerExtendBtn>b__142_0(); // 0x05bc3488
	System.Boolean <LackFuelExtendBtn>b__143_0(); // 0x05bc34ec
	System.Int32 <ReadAllTriggerBtnFromTable>b__193_0(System.Int32 a, System.Int32 b); // 0x05bc3550
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EInteractionType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EInteractionType None = 0;
	static WizardGames.Soc.SocClient.Ui.EInteractionType Entity = 1;
	static WizardGames.Soc.SocClient.Ui.EInteractionType Water = 2;
	static WizardGames.Soc.SocClient.Ui.EInteractionType Vehicle = 3;
	static WizardGames.Soc.SocClient.Ui.EInteractionType CollectableEntity = 4;
	static WizardGames.Soc.SocClient.Ui.EInteractionType PickableItem = 5;
	static WizardGames.Soc.SocClient.Ui.EInteractionType LandMine = 6;
	static WizardGames.Soc.SocClient.Ui.EInteractionType RFC4Entity = 7;
	static WizardGames.Soc.SocClient.Ui.EInteractionType RangeInteractiveBox = 8;
	static WizardGames.Soc.SocClient.Ui.EInteractionType AnimalTrap = 9;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InteractiveExtendData : System.Object
{
	System.String replaceIcon; // 0x10
	System.Func<System.String> leftIconGetFunc; // 0x18
	System.String leftBtnText; // 0x20
	System.Func<System.String> replaceNameFunc; // 0x28
	System.Action onClick; // 0x30
	System.Action leftBtnClick; // 0x38
	System.Func<System.Boolean> enableFunc; // 0x40
	System.Func<System.Boolean> leftBtnEnableFunc; // 0x48
	System.Func<System.Boolean> leftBtnAutoStatusFunc; // 0x50
	System.String get_ReplaceIcon(); // 0x05bc36f4
	System.String get_LeftIcon(); // 0x05bc3758
	System.String get_LeftBtnText(); // 0x05bc37d4
	System.String get_ReplaceName(); // 0x05bc3838
	System.Boolean get_Enable(); // 0x05bc38b4
	System.Action get_OnClick(); // 0x05bc3930
	System.Action get_LeftBtnClick(); // 0x05bc3994
	System.Func<System.Boolean> get_IsAutoOpen(); // 0x05bc39f8
	System.Void SetData(System.String replaceIcon, System.Func<System.String> leftIconGetFunc, System.Func<System.String> replaceNameFunc, System.Action leftBtnClick, System.Action onClick, System.Func<System.Boolean> enableFunc, System.Func<System.Boolean> leftBtnEnableFunc, System.String leftBtnText, System.Func<System.Boolean> leftBtnAutoStatusFunc); // 0x05bbfd84
	System.Void .ctor(System.String replaceIcon, System.Func<System.String> leftIconGetFunc, System.Func<System.String> replaceNameFunc, System.Action onClick, System.Action leftBtnClick, System.Func<System.Boolean> enableFunc, System.Func<System.Boolean> leftBtnEnableFunc, System.String leftText, System.Func<System.Boolean> leftBtnAutoStatusFunc); // 0x05bbfef0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ELadderState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ELadderState CAN_NOT = 0;
	static WizardGames.Soc.SocClient.Ui.ELadderState CAN = 1;
	static WizardGames.Soc.SocClient.Ui.ELadderState CLIMPING = 2;
	static WizardGames.Soc.SocClient.Ui.ELadderState SPEED_UP = 3;
	static WizardGames.Soc.SocClient.Ui.ELadderState CAN_BOTTOM = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ELadderClickEvent : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ELadderClickEvent CLIMP = 0;
	static WizardGames.Soc.SocClient.Ui.ELadderClickEvent SPEED_UP = 1;
	static WizardGames.Soc.SocClient.Ui.ELadderClickEvent STOP_SPEED_UP = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EParachuteState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EParachuteState NONE = 0;
	static WizardGames.Soc.SocClient.Ui.EParachuteState OPEN = 1;
	static WizardGames.Soc.SocClient.Ui.EParachuteState CLOSE = 2;
	static WizardGames.Soc.SocClient.Ui.EParachuteState IN_CD = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ENewbieRemoteControlState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ENewbieRemoteControlState NONE = -1;
	static WizardGames.Soc.SocClient.Ui.ENewbieRemoteControlState GREEN = 0;
	static WizardGames.Soc.SocClient.Ui.ENewbieRemoteControlState RED = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InteractiveListCommonInterface : System.Object
{
	static SocLogger Log; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Go.IOGo,UnityEngine.Vector3> OnCardSwiped; // 0x8
	static UnityEngine.Collider[] tempColliders; // 0x10
	static System.Int64 curLootEntityId; // 0x18
	static System.Int32 lastBoxId; // 0x20
	static System.Boolean isCloseLooting; // 0x24
	static System.Int64 curEyeEntityId; // 0x28
	static System.Boolean <OpenPickList>k__BackingField; // 0x30
	static System.Boolean isOpenBagOnBoxPickList; // 0x31
	static WizardGames.Soc.SocClient.Ui.UiPickListData uiData; // 0x38
	static System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> pickRenderList; // 0x40
	static System.Collections.Generic.List<System.Int64> pickDataIdList; // 0x48
	static System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> getDeadPlayerItemsByCollectionIdRes; // 0x50
	static System.Comparison<WizardGames.Soc.Common.CustomType.BaseItemNode> pickListDisplayComparer; // 0x58
	static System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemGroup> curPickableGroups; // 0x60
	static System.Boolean HasDrop; // 0x68
	static System.Boolean HasVictoryBox; // 0x69
	static System.Collections.Generic.List<System.Int64> usingByOtherCheckIds; // 0x70
	static System.Collections.Generic.List<System.Int64> DischargeMethodIds; // 0x78
	static System.Int64 get_CurLootEntityId(); // 0x05bc3a5c
	static System.Void set_CurLootEntityId(System.Int64 value); // 0x05bb413c
	static System.Int32 get_LastBoxId(); // 0x05bc3ae4
	static System.Int64 get_CurEyeEntityId(); // 0x05bc3b6c
	static System.Void set_CurEyeEntityId(System.Int64 value); // 0x05bc3bf4
	static System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> GetAllHorseFoodsInBag(); // 0x05bc3ca4
	static System.Boolean TryGetLootEntity(WizardGames.Soc.Common.Entity.IEntity& lootEntity, System.Int64 entityId); // 0x05bc40a4
	static System.Void OnClick(System.Int32 id); // 0x05bc42b4
	static System.Void OnUIClickAudio(System.Int32 id); // 0x05bc4790
	static System.Boolean IdIsVehicle(System.Int32 id); // 0x05bc48ec
	static System.Boolean IdIsWater(System.Int32 id); // 0x05bc7658
	static System.Boolean IdIsCollectable(System.Int32 id); // 0x05bc76e0
	static System.Boolean IdIsRangeInteractive(System.Int32 id); // 0x05bc63a4
	static System.Boolean IdIsAnimalTrapInteractive(System.Int32 id); // 0x05bc67ac
	static System.Boolean IdIsLandMine(System.Int32 id); // 0x05bc6930
	static System.Boolean IdIsRFC4(System.Int32 id); // 0x05bc6ab4
	static System.Void HideSecondaryInteractiveList(); // 0x05bc7768
	static System.Void HandleWarDrumGetReward(); // 0x05bc6d74
	static System.Boolean HandleZiplineInteraction(System.Int32 id); // 0x05bc5a48
	static System.Void HandleRangeInteractive(System.Int32 id); // 0x05bc6444
	static System.Boolean CheckPlayerEntityCanStartLooting(WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x05bc6fa8
	static System.Void HandleUnavailableInteraction(System.Int32 id, System.Int32 tipsId); // 0x05bc58ec
	static System.Void HandleWaterInteraction(); // 0x05bc5f30
	static System.Void HandleGatherItemClick(); // 0x05bc611c
	static System.Void OnGatherItemClick(); // 0x05bc7858
	static System.Boolean HandleSpecialInteractions(System.Int32 id); // 0x05bc6198
	static System.Void HandleTrapAnimalInteraction(System.Int32 id, System.Int64 entityId); // 0x05bc6814
	static WizardGames.Soc.Common.SimpleCustom.SimulatorPickUpRequest GetPickUpRequest(System.Int64 entityId); // 0x05bc7fbc
	static System.Void HandleLandMineInteraction(); // 0x05bc6998
	static System.Void HandleRFC4Interaction(); // 0x05bc6b1c
	static System.Void MountableOnClick(System.Int32 id); // 0x05bc4974
	static System.Void SendWantsMount(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.Unity.Go.SeatType seatType, WizardGames.Soc.Common.Unity.Go.IMountable mountable); // 0x05bc8d98
	static System.Boolean NoBlockBetweenEyeAndMountable(WizardGames.Soc.Common.Entity.IEntity targetMountable); // 0x05bc9544
	static System.Void SendWantsDismount(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.Unity.Go.IMountable mountable); // 0x05bc93b8
	static System.Void SendSwitchMountSeat(); // 0x05bc949c
	static System.Void SendWantsPush(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Int64 mountableId); // 0x05bc8720
	static System.Void SendHorseFollow(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Int64 mountableId, System.Boolean followOrCancel); // 0x05bc844c
	static System.Void FeedHorseBtnClick(System.Int64 mountableId); // 0x05bc8540
	static System.Void SendHorseFeed(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Int64 mountableId, System.Int64 foodTemplateId); // 0x05bc9c7c
	static System.Void HandleEntityInteraction(System.Int32 id, WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x05bc715c
	static System.Void HandleNPCEntityInteraction(System.Int32 id, WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x05bca958
	static System.Boolean HandleStorageDebrisEntityInteraction(System.Int32 id, WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x05bcbf54
	static System.Boolean HandleIOEntityInteraction(System.Int32 id, WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x05bc9f04
	static System.Boolean HandleCardSwipe(System.Int32 id, WizardGames.Soc.Common.Data.units.IOInteractive ioEntityConfig, WizardGames.Soc.Common.Entity.IOEntity ioEntity); // 0x05bccd80
	static System.Boolean HandleEntityState(System.Int32 id, WizardGames.Soc.Common.Data.units.IOInteractive ioEntityConfig, WizardGames.Soc.Common.Entity.IOEntity ioEntity); // 0x05bcd100
	static System.Void HandleElevatorInteraction(System.Int32 id, WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x05bca37c
	static System.Void HandleKatyushaInteraction(System.Int32 id, WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x05bca5f8
	static System.Void HandleCaveLiftInteraction(System.Int32 id, WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x05bca7a8
	static System.Boolean HandleDigEntityInteraction(System.Int32 id, WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x05bcaae8
	static System.Boolean HandleInteractionEntityInteraction(System.Int32 id, WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x05bcbc04
	static System.Boolean HandleTrainCarEntityInteraction(System.Int32 id, WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x05bcbdac
	static System.Boolean HandlePartEntityInteraction(System.Int32 id, WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x05bcae14
	static System.Boolean HandleBoxEntityInteraction(System.Int32 id, WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x05bcb3e8
	static WizardGames.Soc.SocClient.Ui.UiPickListData get_UiData(); // 0x05bcd440
	static System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> get_PickRenderList(); // 0x05bcd5ac
	static System.Void CreatePickUiData(); // 0x05bcd4f8
	static System.Void GeneratePickRenderList(); // 0x05bcd634
	static System.Void GeneratePickList(); // 0x05bcda90
	static System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> GetDeadPlayerItemsByCollectionId(System.Int64 collectionId); // 0x05bcdd4c
	static System.Boolean TryGetDataFromDic(System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> dic, System.Int64 collectionId, System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>& res); // 0x05bcdf64
	static System.Void AddPickDataFromList(System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> lst, System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> dest); // 0x05bce074
	static WizardGames.Soc.Common.CustomType.BaseItemNode GetFirstCanQuickPick(System.Boolean& isLastOne); // 0x05bce1b0
	static System.Void AutoPick(WizardGames.Soc.SocClient.Ui.ItemNodeInfo itemNodeInfo); // 0x05bce3ac
	static System.Void PickItemClick(System.Int64 itemNodeId, System.Boolean isAutoPick); // 0x05bce710
	static System.Void PickItemClick(System.Int64 extendBagNodeId, System.Int64 itemNodeId, System.Boolean isAutoPick); // 0x05bce634
	static System.Void PickItemClick(System.Int64 colId, System.Int64 itemUid, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05bce7e0
	static System.Void DoPickItem(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05bce8c0
	static System.Int64 GetExtendBagNodeIndex(WizardGames.Soc.Common.CustomType.BaseItemNode baseItemNode); // 0x05bceba8
	static System.Boolean CheckOpenBagValid(WizardGames.Soc.Common.Entity.IEntity lootEntity, System.Int32& tipId); // 0x05bced38
	static System.Void OpenBag(); // 0x05bcf074
	static System.Collections.Generic.List<WizardGames.Soc.Share.Framework.EntityBase> GetAllCollectionsByOpenAsOtherside(); // 0x05bcf5c0
	static System.String GetColNameByOpenAsOtherside(WizardGames.Soc.Share.Framework.EntityBase col); // 0x05bcf64c
	static System.String GetColName(WizardGames.Soc.Share.Framework.EntityBase col); // 0x05bcf6d4
	static System.Void OnBagClose(); // 0x05bcf80c
	static System.Void CloseInteractView(WizardGames.Soc.Common.Data.system.Interaction data); // 0x05bcf8e4
	static System.Void OpenInteractView(WizardGames.Soc.Common.Data.system.Interaction data, WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x05bcc02c
	static System.Void WarningTreasuretTaskTracked(WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x05bd1cfc
	static System.Void OpenTrainDischarge(WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x05bd1248
	static System.Void RefreshConfirmBtnCallback(FairyGUI.GButton obj); // 0x05bd2208
	static System.Boolean IsTrainDischargeActivation(WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x05bd2268
	static System.Void RefreshCancelBtnCallback(FairyGUI.GButton obj); // 0x05bd27e4
	static System.Void OnConfirmClickCallback(System.Int32 currentSelected); // 0x05bd2844
	static System.Boolean CheckIsUsingByOther(WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x05bd1924
	static System.Void OpenLootingOtherSideNew(WizardGames.Soc.Common.Entity.IEntity lootEntity, System.Int32 style); // 0x05bd0b80
	static System.Void OpenSwipCardGame(WizardGames.Soc.Common.Entity.IEntity lootEntity, System.Int32 interactionId); // 0x05bd0ce4
	static System.Void OpenLootingOtherSide(WizardGames.Soc.Common.Entity.IEntity lootEntity, System.Int32 style); // 0x05bc8808
	static System.Void CloseLootView(System.Int64 lootingEntityId); // 0x05bcff64
	static System.Void PlayStopLootingSound(System.Int64 lootingEntityId); // 0x05bd2d90
	static System.Void OnOpenView(WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType mode, System.Int64 lootingEntityId); // 0x05bd2f88
	static System.Void OnCloseView(WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType mode, System.Int64 lootingEntityId); // 0x05bd3484
	static System.Void OnCloseEngine(System.Int64 lootingEntityId); // 0x05bd3540
	static System.Void OnOpenEngine(System.Int64 lootingEntityId); // 0x05bd303c
	static System.Void OpenLootingInventoryOtherside(WizardGames.Soc.Common.Entity.IEntity lootEntity, System.Int32 style); // 0x05bd0a0c
	static System.Void OpenLootingWithStyle(System.Int32 style, WizardGames.Soc.Common.Entity.IEntity lootEntity); // 0x05bd0024
	static System.Void GeneratePickData(); // 0x05bcd724
	static System.Void HandleDragEdgesEffect(System.Int64 curEyeEntityId); // 0x05bd3988
	static System.Void SetDragEdgesEffect(System.Int64 entityId, UnityEngine.GameObject hitGo); // 0x05bd3af4
	static WizardGames.Soc.Common.Entity.IEntity GetMonsterCorpseEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05bd42b8
	static System.Boolean ShouldSkipPlayerOutline(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05bd43d0
	static System.Boolean ShouldDisableMountOutline(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05bd4608
	static System.Boolean ShouldEnableOutline(System.Int64 entityId); // 0x05bd3d54
	static System.Void HandleDisableOutline(System.Int64 entityId); // 0x05bd3f90
	static System.Int64 GetOutlineEntityId(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject hitGo); // 0x05bd49c8
	static System.Void EnableOutlineForEntity(System.Int64 outlineEntityId); // 0x05bd4d28
	static System.Void .cctor(); // 0x05bd506c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InteractiveListCommonInterface.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.InteractiveListCommonInterface.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.Common.CustomType.ItemContainerNode,System.Boolean> <>9__67_1; // 0x8
	static System.Func<WizardGames.Soc.Common.CustomType.ItemContainerNode,System.Boolean> <>9__67_3; // 0x10
	static System.Action <>9__68_1; // 0x18
	static System.Func<System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemGroup>> <>9__98_0; // 0x20
	static System.Func<System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Common.Data.Play.TrainDischarge>,System.Int64> <>9__109_1; // 0x28
	static System.Void .cctor(); // 0x05bd6070
	System.Void .ctor(); // 0x05bd60d4
	System.Boolean <HandlePartEntityInteraction>b__67_1(WizardGames.Soc.Common.CustomType.ItemContainerNode container); // 0x05bd613c
	System.Boolean <HandlePartEntityInteraction>b__67_3(WizardGames.Soc.Common.CustomType.ItemContainerNode container); // 0x05bd6220
	System.Void <HandleBoxEntityInteraction>b__68_1(); // 0x05bd6300
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemGroup> <OpenBag>b__98_0(); // 0x05bd6400
	System.Int64 <IsTrainDischargeActivation>b__109_1(System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Common.Data.Play.TrainDischarge> item); // 0x05bd6698
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InteractiveListCommonInterface.<>c__DisplayClass105_0 : System.Object
{
	WizardGames.Soc.Common.Data.system.Interaction data; // 0x10
	System.Void .ctor(); // 0x05bd672c
	System.Void <OpenInteractView>b__0(System.Boolean isSucess); // 0x05bd6794
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InteractiveListCommonInterface.<>c__DisplayClass109_0 : System.Object
{
	WizardGames.Soc.Common.Entity.IOEntity ioEntity; // 0x10
	System.Void .ctor(); // 0x05bd68a0
	System.Boolean <IsTrainDischargeActivation>b__0(System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Common.Data.Play.TrainDischarge> item); // 0x05bd6908
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InteractiveListCommonInterface.<>c__DisplayClass115_0 : System.Object
{
	WizardGames.Soc.Common.Entity.IOEntity ioEntity; // 0x10
	System.Int32 resetLeftTime; // 0x18
	System.Void .ctor(); // 0x05bd69b4
	System.Void <OpenSwipCardGame>b__0(WizardGames.Soc.SocClient.Ui.UiSwipeCardGame win); // 0x05bd6a1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InteractiveListCommonInterface.<>c__DisplayClass67_0 : System.Object
{
	System.Int32 id; // 0x10
	WizardGames.Soc.Common.Entity.IEntity lootEntity; // 0x18
	System.Void .ctor(); // 0x05bd6c98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InteractiveListCommonInterface.<>c__DisplayClass67_1 : System.Object
{
	System.Int64 collectionID; // 0x10
	WizardGames.Soc.Common.Data.system.Interaction config; // 0x18
	WizardGames.Soc.SocClient.Ui.InteractiveListCommonInterface.<>c__DisplayClass67_0 CS$<>8__locals1; // 0x20
	System.Void .ctor(); // 0x05bd6d00
	System.Void <HandlePartEntityInteraction>b__0(System.Boolean res); // 0x05bd6d68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InteractiveListCommonInterface.<>c__DisplayClass67_2 : System.Object
{
	System.Int64 collectionID; // 0x10
	WizardGames.Soc.Common.Data.system.Interaction config; // 0x18
	WizardGames.Soc.SocClient.Ui.InteractiveListCommonInterface.<>c__DisplayClass67_0 CS$<>8__locals2; // 0x20
	System.Void .ctor(); // 0x05bd71b4
	System.Void <HandlePartEntityInteraction>b__2(System.Boolean res); // 0x05bd721c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InteractiveListCommonInterface.<>c__DisplayClass68_0 : System.Object
{
	System.Int32 id; // 0x10
	WizardGames.Soc.Common.Entity.IEntity lootEntity; // 0x18
	WizardGames.Soc.Common.Data.units.TreasureBox config; // 0x20
	System.Int64 collectionID; // 0x28
	System.Void .ctor(); // 0x05bd7668
	System.Void <HandleBoxEntityInteraction>b__0(System.Boolean res); // 0x05bd76d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemInteractiveList : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	static SocLogger Log; // 0x0
	WizardGames.Soc.SocClient.Ui.InteractiveIdListChecker <InteractiveIdListChecker>k__BackingField; // 0x190
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.UiHudElemInteractiveList.UiInteractiveBtnCdType> uiInteractiveBtnCdTypeDic; // 0x198
	FairyGUI.GComponent interactiveRoot; // 0x1a0
	FairyGUI.GComponent <ComInteractive>k__BackingField; // 0x1a8
	WizardGames.Soc.SocClient.Ui.ComLazyLoader interactiveListLoader; // 0x1b0
	FairyGUI.GTextField titleText; // 0x1b8
	FairyGUI.Controller titleController; // 0x1c0
	FairyGUI.GButton btnReturn; // 0x1c8
	FairyGUI.GList interactiveBtnList; // 0x1d0
	FairyGUI.Controller stateCtrl; // 0x1d8
	FairyGUI.Controller itemCountCtrl; // 0x1e0
	System.Boolean isCloseInteractiveList; // 0x1e8
	System.Int64 curLootEntityId; // 0x1f0
	UnityEngine.Collider[] tempColliders; // 0x1f8
	static System.Boolean isCloseLooting; // 0x8
	System.Int32 lastBoxId; // 0x200
	System.Collections.Generic.Dictionary<FairyGUI.GObject,FairyGUI.GObject> uiGObjectPool; // 0x208
	System.Int64 updateListId; // 0x210
	System.Int32 ITEM_HEIGHT; // 0x218
	System.Int32 COIN_ITEM_HEIGHT; // 0x21c
	System.Collections.Generic.List<System.Int32> expandInteractiveIdList; // 0x220
	System.Collections.Generic.List<System.Int32> oldExpandInteractiveIdList; // 0x228
	System.Collections.Generic.List<System.Int32> nearbyInteractiveIdList; // 0x230
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EInteractionType,System.Int32> nearbyInteractiveType; // 0x238
	System.Int32 curEyeEntityTypeId; // 0x240
	System.Int64 curEyeEntityId; // 0x248
	WizardGames.Soc.SocClient.Ui.EInteractionType curSelectInteractionType; // 0x250
	WizardGames.Soc.SocClient.Ui.EInteractionType[] defaultInteractionSort; // 0x258
	System.Boolean waitResponeFlag; // 0x260
	System.Int64 curDoorEntityId; // 0x268
	System.Collections.Generic.HashSet<System.String> titleSet; // 0x270
	System.Int32 INTERACTIVE_BASE_INDEX; // 0x278
	System.Boolean expandListCanScroll; // 0x27c
	System.Boolean nearbyListCanScroll; // 0x27d
	System.Boolean pickListCanScroll; // 0x27e
	System.Boolean horseFoodListCanScroll; // 0x27f
	System.Boolean skipFramePre; // 0x280
	System.Boolean lockFramePre; // 0x281
	System.Collections.Generic.List<WizardGames.Soc.Common.Construction.ItemCostAmount> recoverChildPartCost; // 0x288
	WizardGames.Soc.SocClient.Manager.HotKeyAction wheelUpAction; // 0x290
	WizardGames.Soc.SocClient.Manager.HotKeyAction wheelDownAction; // 0x298
	System.Int32 lastNum; // 0x2a0
	System.Boolean needPlayPickUpListShowSoundEffect; // 0x2a4
	System.String SHOW_INTERACTIVE; // 0x2a8
	System.String SHOW_PICKUP; // 0x2b0
	System.String SHOW_NEARBY; // 0x2b8
	System.String SHOW_HORSEFOOD; // 0x2c0
	System.String SHOW_PICKUP_SWITCH; // 0x2c8
	System.Boolean canFeedHorse; // 0x2d0
	System.Int64 loaderCheckerTimerId; // 0x2d8
	System.Int64 lastQuestGuideId; // 0x2e0
	System.Int32 curInteractiveIndex; // 0x2e8
	WizardGames.Soc.SocClient.Ui.ComLazyLoader horseFoodListLoader; // 0x2f0
	FairyGUI.GList horseFoodList; // 0x2f8
	System.Boolean isInHorseFoodList; // 0x300
	FairyGUI.GComponent horseFoodListCom; // 0x308
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> curHorseFoods; // 0x310
	FairyGUI.GTextField horseFoodListTitle; // 0x318
	FairyGUI.Transition horseAppearTrans; // 0x320
	FairyGUI.GButton horseCloseBtn; // 0x328
	WizardGames.Soc.SocClient.Ui.ComLazyLoader nearbyListLoader; // 0x330
	FairyGUI.GComponent nearbyComRoot; // 0x338
	FairyGUI.GTextField nearbyTitleText; // 0x340
	FairyGUI.GList nearbyList; // 0x348
	FairyGUI.GLoader nearbyTitleBg; // 0x350
	System.Boolean needShowNearbyList; // 0x358
	System.String gatherStr; // 0x360
	System.String nearbyInteractablesStr; // 0x368
	System.String pickupStr; // 0x370
	System.String lootStrFormat; // 0x378
	System.String lootStr; // 0x380
	System.String dropStrFormat; // 0x388
	System.String pickDropStr; // 0x390
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.NearbyItemData> nearbyItemList; // 0x398
	WizardGames.Soc.SocClient.Ui.ComLazyLoader pickListLoader; // 0x3a0
	FairyGUI.GComponent pickComRoot; // 0x3a8
	FairyGUI.GButton autoBtn; // 0x3b0
	FairyGUI.Controller autoBtnCtrl; // 0x3b8
	FairyGUI.GButton bagBtn; // 0x3c0
	FairyGUI.GButton closeBtn; // 0x3c8
	FairyGUI.GTextField pickTitleText; // 0x3d0
	FairyGUI.GList pickItemList; // 0x3d8
	FairyGUI.GButton quickPickBtn; // 0x3e0
	FairyGUI.GButton exchangeBtn; // 0x3e8
	System.String dropItemStr; // 0x3f0
	System.String dropStr; // 0x3f8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemGroup> curPickableGroups; // 0x400
	System.Boolean isListSizeChanged; // 0x408
	System.Int32 pickItemsNum; // 0x40c
	System.Int32 lastFireMsgPickItemsNum; // 0x410
	WizardGames.Soc.SocClient.Ui.UiCollectionItemsListHandle uiCollectionItemsListHandle; // 0x418
	System.Boolean needShowPickList; // 0x420
	System.Boolean isQuickPicking; // 0x421
	System.Int64 quickUseId; // 0x428
	System.String _cachedPickTitleText; // 0x430
	FairyGUI.Controller pickListTitleController; // 0x438
	WizardGames.Soc.SocClient.Manager.HotKeyAction quickUseAction; // 0x440
	FairyGUI.GComponent pickSwitchComRoot; // 0x448
	FairyGUI.Controller pickSwitchCtrl; // 0x450
	FairyGUI.GButton btnPickSwicth; // 0x458
	FairyGUI.GButton btnPickSwicthClose; // 0x460
	FairyGUI.GTextField pickSwitchNumText; // 0x468
	FairyGUI.Transition pickSwitchEffect; // 0x470
	WizardGames.Soc.SocClient.Ui.ComLazyLoader pickSwitchLoader; // 0x478
	FairyGUI.GLoader btnLoader; // 0x480
	static System.Boolean <OpenPickList>k__BackingField; // 0x9
	System.Boolean isOpenListBefore; // 0x488
	FairyGUI.EventCallback0 OnPickSwitchClickEvent0; // 0x490
	FairyGUI.EventCallback0 OnPickSwitchCloseClickEvent0; // 0x498
	System.Int32 lastPickSwitchNum; // 0x4a0
	System.Void StartEdit(); // 0x05bd7a58
	WizardGames.Soc.SocClient.Ui.InteractiveIdListChecker get_InteractiveIdListChecker(); // 0x05bd7f28
	System.Void set_InteractiveIdListChecker(WizardGames.Soc.SocClient.Ui.InteractiveIdListChecker value); // 0x05bd7f8c
	FairyGUI.GComponent get_ComInteractive(); // 0x05bd800c
	System.Void set_ComInteractive(FairyGUI.GComponent value); // 0x05bd8070
	System.Void OnBoardInit(); // 0x05bd80f0
	System.Void OnBoardDestroy(); // 0x05bd8d34
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05bd98c8
	System.Void OnCreate_InteractiveList(FairyGUI.GComponent node); // 0x05bda714
	System.Void OnDestroy_InteractiveList(); // 0x05bdaa84
	System.Void CreateCheckerTimer(); // 0x055049cc
	System.Void ResetCheckerTimer(); // 0x05bd93e4
	System.Void UnloadTheLoaderComponent(); // 0x05bd94e8
	System.Void OnUiDestroy(); // 0x05bdab30
	System.Void OnBoardDisable(); // 0x05bdae48
	System.Boolean OnShowCheck(); // 0x05bdaf50
	System.Void OnShow(); // 0x05bdb888
	System.Void OnEnable(); // 0x05bdc304
	System.Void OnDisable(); // 0x05bdc59c
	System.Boolean CanShowInteractiveIdList(); // 0x05bdb628
	System.Boolean CanShowPickList(); // 0x05bdc9f4
	System.Void Reclassify(); // 0x05bdca58
	System.Void DefaultInteractiveList(System.Boolean selected); // 0x05bdd524
	System.Void HandleWithCrosshair(); // 0x05bdd7d4
	System.Void HandleWithoutCrosshair(); // 0x05bdde5c
	System.Void ProcessNearbyInteractiveId(System.Int32 id); // 0x05bde2a0
	System.Void SelectedInteractiveList(WizardGames.Soc.SocClient.Ui.EInteractionType type); // 0x05bdcc58
	System.Collections.Generic.List<System.Int32> GetExpandInteractiveList(); // 0x05bde46c
	System.Collections.Generic.List<System.Int32> GetNearbyInteractiveIdList(); // 0x05bde4d0
	System.Void UpdateUIStyle(); // 0x05bdb998
	System.Void ClearInteractiveLists(); // 0x05bde534
	System.Void ShowExpandList(System.Collections.Generic.List<System.Int32> expandList, System.Boolean expandListChanged); // 0x05bde7b8
	System.Void ShowPickListOnly(); // 0x05bdea7c
	System.Void TransferNearbyToExpand(System.Collections.Generic.List<System.Int32> expandList, System.Boolean expandListChanged); // 0x05bdee40
	System.Boolean IsExpandInteractiveIdChanged(); // 0x05bde5cc
	System.Void OnRenderInteractiveBtn(System.Int32 index, FairyGUI.GObject obj); // 0x05be0d70
	System.Void CheckLazyLoaderState(FairyGUI.GButton interactiveBtn); // 0x05be4568
	System.Void SetInteractiveBtnClickAction(FairyGUI.GButton interactiveBtn, FairyGUI.GComponent objCom, WizardGames.Soc.SocClient.Ui.InteractiveExtendData interactiveExtendData, FairyGUI.Controller ctrlShowLeftBtn, System.Int32 interactiveId); // 0x05be3df4
	System.Void SetStorageGoldCoins(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn, System.String nameStr); // 0x05be3604
	System.Boolean SetVehicleLockBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn); // 0x05be3204
	System.Void SetCdTypeBtnStyle(FairyGUI.GButton interactiveBtn, WizardGames.Soc.Common.Data.system.Interaction data, System.Int32 interactiveId); // 0x05be3b2c
	System.Void SetExtendDataBtnStyle(FairyGUI.GButton interactiveBtn, WizardGames.Soc.SocClient.Ui.InteractiveExtendData interactiveExtendData, System.String& iconPath, System.String& nameStr); // 0x05be3c98
	System.Void SetDriverSeatBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn); // 0x05be14c8
	System.Void SetPassengerSeatBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn); // 0x05be162c
	System.Void SetSwitchVehicleSeatBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn); // 0x05be1790
	System.Void SetPlantSystemWaterBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn); // 0x05be18f4
	System.Void SetOpenBatchUpgradeBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn); // 0x05be1cac
	System.Void SetPermRepairAllBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn); // 0x05be1db4
	System.Void SetHorseFeedBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn, FairyGUI.GTextField textNum, System.String& iconPath, System.String& nameStr); // 0x05be1ef4
	System.Void SetBuildingSkinBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn); // 0x05be24c8
	System.Void SetDefaultBtnStyle(System.String& nameStr); // 0x05be38f4
	System.Boolean SetRecoverChildPartBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn); // 0x05be2ad4
	System.Boolean SetStoargeDebrisBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn); // 0x05be2e24
	System.Boolean SetRepaireInteractiveBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn, System.Int32 type, System.Boolean isBuilding); // 0x05be2610
	System.Void SetInteractiveBtnCostStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn, System.Collections.Generic.List<WizardGames.Soc.Common.Construction.ItemCostAmount> itemsToTake); // 0x05be4b08
	System.Void SetBtnType(FairyGUI.GButton btn, System.Int32 type); // 0x05be2544
	System.Int64 GetTerrIdByCurRayPart(); // 0x05be5b54
	System.Void OnClickButtonByGuide(System.Int32 id); // 0x05be6018
	System.Void OnClickButtonByTriggerBtn(System.Int32 id); // 0x05be6604
	System.Void OnTouchBegin(); // 0x05be66a4
	System.Void OnTouchEnd(); // 0x05be68b0
	System.Void TryUnlockUpdate(); // 0x05be6708
	System.Void TryResumeLockUpdate(); // 0x05be6914
	System.Void PlayerStateAction(System.Int32 stateId); // 0x05be6a5c
	System.Void OnInventoryUpdate(); // 0x05be7248
	System.Void OnInterruptPickListMsg(System.Boolean isInterrupt); // 0x05be75bc
	System.Void EyeEntityIdChangeAction(System.Int64 curEyeEntityId, System.Int64 lastEyeEntityId); // 0x05be782c
	System.Void EyeGameobjectChangeAction(System.Int64 curEyeEntityId, UnityEngine.GameObject go); // 0x05be7f10
	System.Void OnCurEyeEntityIdChange(System.Int64 curEyeEntityId); // 0x05be78e0
	System.Void InteractiveIdListChangeAction(System.Boolean isShowList, System.Int64 curEyeEntityId, System.Boolean isForceUpdateVisible, UnityEngine.GameObject hitGo); // 0x05be7fc4
	System.Void UpdateDetectionAction(System.Int64 curEyeEntityId); // 0x05be8710
	System.Void RefreshInteractiveList(System.Int64 collectionId); // 0x05be8a70
	System.Void OnFastReconnected(); // 0x05be9208
	System.String GetExpandInteractiveTitleStr(System.Int64 curEyeEntityId); // 0x05be003c
	System.Void SetElemVisible(System.Boolean visible, System.Boolean isForceUpdateVisible); // 0x05be82a8
	System.Int64 GetCurRayEntityId(); // 0x05be49ac
	System.Void ChangeElemAnchorPoint(FairyGUI.GObject target, System.Int32 anchor); // 0x05be92a8
	static System.Void PCDirectClick(); // 0x05be9334
	static WizardGames.Soc.SocClient.Ui.UiHudElemInteractiveList GetInteractiveListElem(); // 0x05be93c4
	UnityEngine.Rect GetBlockArea(); // 0x05be972c
	System.Void PCDirectClickInternal(); // 0x05be9438
	System.Void OnBtnReturnClick(); // 0x05be9de0
	System.Void ClearCdTypeDic(); // 0x05be8bcc
	System.Void OnInteractiveCdBtnChange(System.Boolean isExist); // 0x05523a7c
	System.Void UpdateBtnCds(System.Int64 timerId, System.Object callbackData, System.Boolean needDelete); // 0x05be9ef8
	System.Void CDFinishCallback(FairyGUI.GButton btn); // 0x05bea11c
	System.Void UpdateBtnCd(System.Int32 interactiveId); // 0x05be53a8
	System.Void OnClickButtonFirst(); // 0x05be60c0
	System.Boolean TriggerGuide(); // 0x05bdf5d8
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x05bea38c
	System.Void OnCreate_HorseFoodList(FairyGUI.GComponent node); // 0x05bda528
	System.Void Init_HorseFoodList(FairyGUI.GComponent node); // 0x05bea6bc
	System.Void Destroy_HorseFoodList(); // 0x05bea9b0
	System.Void CloseHorseFoodList(FairyGUI.EventContext context); // 0x05beaa7c
	System.Void RenderHorseFoodItem(System.Int32 index, FairyGUI.GObject obj); // 0x05beab28
	System.Void ClickFood(System.Int32 index); // 0x05beaf50
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> GetAllHorseFoodsInBag(); // 0x05be5c10
	System.Void SetExpandListItemNum(System.Int32 num); // 0x05bda984
	System.Void RefreshHorseFoodList(); // 0x05be72b4
	System.Void SetNearbyItemListNum(System.Int32 num); // 0x05beb130
	System.Void SetItemListNum(System.Int32 num); // 0x05be0a54
	System.Void SetPickSwitchComRootVisible(System.Boolean value); // 0x05bdf078
	System.Void OnBoardInit_Platform(); // 0x05bd8b38
	System.Void UpdateUIStyle_Platform(); // 0x05bdf578
	System.Void OnDisable_Platform(); // 0x05bdc994
	System.Void OnEnable_Platform(); // 0x05bdc53c
	System.Void OnPickSwitchCloseClick_Platform(); // 0x05beb1d4
	System.Boolean ShouldShowExpandListOnly(System.Collections.Generic.List<System.Int32> expandList, System.Collections.Generic.List<System.Int32> nearbyList, System.Boolean canShowPickList); // 0x05bde6e0
	System.Boolean ShouldShowPickListOnly(System.Collections.Generic.List<System.Int32> expandList, System.Collections.Generic.List<System.Int32> nearbyList, System.Boolean canShowPickList); // 0x05bde9a8
	System.Boolean ShouldTransferNearbyToExpand(System.Collections.Generic.List<System.Int32> expandList, System.Boolean canShowPickList); // 0x05bded60
	System.Void ShowHorseFoodListOnly(); // 0x05bdef28
	System.Boolean ShouldShowNearbyOnly(System.Collections.Generic.List<System.Int32> nearbyList); // 0x05bdec38
	System.Void AdjustInteractiveBtnListSize(System.Collections.Generic.List<System.Int32> expandList); // 0x05bdfd9c
	System.Void OnCreate_NearbyList(FairyGUI.GComponent node); // 0x05bda33c
	System.Void OnBoardInit_Nearby(); // 0x05bd88dc
	System.Void InitUi_NearbyList(FairyGUI.GComponent node); // 0x05beb234
	System.Void Destroy_NearbyList(); // 0x05beb798
	System.Void Hide_Nearby(); // 0x05beb864
	System.Void RefreshNearbyItemList(); // 0x05be9010
	System.Void GenerateNearbyItemList(); // 0x05beb8e0
	System.Void SetNearbyListSetting(); // 0x05beb520
	FairyGUI.GObject CustomPoolGetterNearby(System.String url); // 0x05bebba8
	System.Void CustomPoolReturnnerNearBy(FairyGUI.GObject obj); // 0x05bebc84
	System.Void RenderNearbyItem(System.Int32 index, FairyGUI.GObject obj); // 0x05bebd5c
	System.Void OnNearbyItemClick(System.Int32 index); // 0x05bec8f0
	System.String GetNearbyItemName(WizardGames.Soc.SocClient.Ui.EInteractionType type, WizardGames.Soc.SocClient.Ui.NearbyItemData data); // 0x05bec00c
	System.Void UpdateNearbyStyle(); // 0x05bdecb0
	System.Int32 GetPickableItemListCount(); // 0x05beca14
	System.Void OnCreate_PickList(FairyGUI.GComponent node); // 0x05bda150
	System.Void InitUi_PickList(FairyGUI.GComponent node); // 0x05beca78
	System.Void Destroy_PickList(); // 0x05bed4c0
	System.Void OnEnable_PickList(); // 0x05bdc37c
	System.Void OnHide(); // 0x05bed65c
	System.Void InitLanguageStr(); // 0x05bed844
	System.Void OnBoardInit_PickList(); // 0x05bd8680
	System.Void OnBoardDestroy_PickList(); // 0x05bd91bc
	System.Void OnDisable_PickList(); // 0x05bdc6a8
	System.Void SetPickTitleText(); // 0x05be0bc4
	System.Void SetPickListSetting(); // 0x05bed248
	System.Void SetPickListVisible(System.Boolean visible); // 0x05bed904
	System.Void RefreshPickItemList(); // 0x05beda10
	System.Void OnSceneItemViewSwitchClick(); // 0x05bedfd4
	System.Void UpdatePickableItemsList(); // 0x05be6af4
	System.Void TryQuickPick(); // 0x05bee0c8
	System.Boolean CheckInventoryFull(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05bee628
	System.Void OnAutoBtnClick(); // 0x05bee744
	System.Void OnBtnQuickPickClick(); // 0x05bee84c
	System.Void OnBtnExchangeClick(); // 0x05bee8b8
	System.Void OnBtnCloseClick(); // 0x05bee9ac
	System.Void OnAutoPickSettingChange(System.Boolean isAutoPick); // 0x05beeba8
	System.Void RefreshBtnState(); // 0x05be0938
	FairyGUI.GObject CustomPoolGetter(System.String url); // 0x05beec20
	System.Void CustomPoolReturnner(FairyGUI.GObject obj); // 0x05beecfc
	System.Void RenderPickItem(System.Int32 index, FairyGUI.GObject obj); // 0x05beee70
	System.Void RegistPickItemEvent(FairyGUI.GButton btn, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05bef608
	System.Void RegistBtnQuickUseEvent(FairyGUI.GButton btn, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05bef4d4
	System.Void DoQuickUseItem(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05bef7fc
	System.Void TryQuickUseItem(); // 0x05be74d4
	System.Void ResetItemCom(FairyGUI.GObject obj); // 0x05beede0
	System.Void ResetItemIcon(FairyGUI.GButton btn); // 0x05bef8b8
	static System.Boolean get_OpenPickList(); // 0x05befa30
	static System.Void set_OpenPickList(System.Boolean value); // 0x05befab8
	System.Void OnCreate_PickSwitch(FairyGUI.GComponent node); // 0x05bd9f64
	System.Void OnBoardInit_PickSwitch(); // 0x05bd8a3c
	System.Void InitUi_PickSwitch(FairyGUI.GComponent node); // 0x05befb4c
	System.Void Destroy_PickSwitch(); // 0x05befc5c
	System.Void OnPickSwitchClick(); // 0x05befd60
	System.Void SetPickSwitchState(System.Boolean open); // 0x05bdf12c
	System.Void OnPickSwitchCloseClick(); // 0x05beff2c
	System.Void SetPickSwitchNum(System.Int32 num); // 0x05bedec8
	System.Void .ctor(); // 0x05bf0138
	static System.Void .cctor(); // 0x05bf0768
	System.Void <CreateCheckerTimer>b__67_0(System.Int64 a, System.Object b, System.Boolean c); // 0x05bf0850
	System.Void <SetHorseFeedBtnStyle>b__106_0(FairyGUI.EventContext ctx); // 0x05bf08e4
	System.Void <InitUi_NearbyList>b__202_0(); // 0x05bf0978
	System.Void <SetNearbyListSetting>b__207_0(); // 0x05bf09dc
	System.Void <SetNearbyListSetting>b__207_1(); // 0x05bf0a60
	System.Void <SetNearbyListSetting>b__207_2(); // 0x05bf0acc
	System.Void <SetPickListSetting>b__249_0(); // 0x05bf0b40
	System.Void <SetPickListSetting>b__249_1(); // 0x05bf0bc4
	System.Void <SetPickListSetting>b__249_2(); // 0x05bf0c30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemInteractiveList.UiInteractiveBtnCdType : System.Object
{
	FairyGUI.GImage progressImg; // 0x10
	FairyGUI.GTextField timeTextField; // 0x18
	FairyGUI.Controller cdCtrl; // 0x20
	FairyGUI.GButton btn; // 0x28
	WizardGames.Soc.SocClient.Ui.ComLazyLoader cdLoader; // 0x30
	System.Void Init(FairyGUI.GButton cdBtn); // 0x05bf0ca4
	System.Void InitWithLoader(FairyGUI.GButton cdBtn); // 0x05be5174
	System.Void SetProgress(System.Single costTime, System.Single cdTime, System.Action<FairyGUI.GButton> finishCallback); // 0x05bea19c
	System.Void ReturnPoolWithLoader(); // 0x05be9e48
	System.Void .ctor(); // 0x05bf0e14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemInteractiveList.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHudElemInteractiveList.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__64_0; // 0x8
	static System.Void .cctor(); // 0x05bf0e7c
	System.Void .ctor(); // 0x05bf0ee0
	System.Void <OnUiCreate>b__64_0(FairyGUI.EventContext context); // 0x05bf0f48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemInteractiveList.<>c__DisplayClass164_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudElemInteractiveList <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x05beaee8
	System.Void <RenderHorseFoodItem>b__0(); // 0x05bf0fcc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemInteractiveList.<>c__DisplayClass210_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudElemInteractiveList <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x05bebfa4
	System.Void <RenderNearbyItem>b__0(); // 0x05bf103c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemInteractiveList.<>c__DisplayClass267_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode itemNode; // 0x10
	System.Void .ctor(); // 0x05bef72c
	System.Void <RegistPickItemEvent>b__0(); // 0x05bf10ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemInteractiveList.<>c__DisplayClass268_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudElemInteractiveList <>4__this; // 0x10
	WizardGames.Soc.Common.CustomType.BaseItemNode itemNode; // 0x18
	System.Void .ctor(); // 0x05bef794
	System.Void <RegistBtnQuickUseEvent>b__0(); // 0x05bf113c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemInteractiveList.<>c__DisplayClass95_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.InteractiveExtendData interactiveExtendData; // 0x10
	WizardGames.Soc.SocClient.Ui.UiHudElemInteractiveList <>4__this; // 0x18
	System.Int32 interactiveId; // 0x20
	System.Void .ctor(); // 0x05be4944
	System.Void <SetInteractiveBtnClickAction>b__0(); // 0x05bf11ac
	System.Void <SetInteractiveBtnClickAction>b__1(); // 0x05bf1278
	System.Void <SetInteractiveBtnClickAction>b__2(); // 0x05bf12e8
	System.Void <SetInteractiveBtnClickAction>b__3(); // 0x05bf1354
	System.Void <SetInteractiveBtnClickAction>b__4(); // 0x05bf13c0
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.NearbyItemData : System.ValueType
{
	WizardGames.Soc.SocClient.Ui.EInteractionType type; // 0x10
	System.Int32 num; // 0x14
	System.Int32 pickIndex; // 0x18
	System.Int32 interactiveId; // 0x1c
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemMsgData : System.Object, Systems.ICustomMinHeapNode<WizardGames.Soc.SocClient.Ui.UiHudElemMsgData>
{
	WizardGames.Soc.SocClient.Ui.UiHudElemMsgData <Child>k__BackingField; // 0x10
	System.String oxygenIconUrl; // 0x18
	System.Int32 id; // 0x20
	WizardGames.Soc.SocClient.Ui.MsgAttributeSet msgAttrSet; // 0x28
	System.Single totalTime; // 0x30
	System.Int32 targetPosIndex; // 0x34
	WizardGames.Soc.SocClient.Ui.UiHudElemMsgData.HudMsgState hudMsgState; // 0x38
	System.Action<WizardGames.Soc.SocClient.Ui.UiHudElemMsgData> UpdateAction; // 0x40
	System.Func<System.Boolean> DisappearAction; // 0x48
	System.Func<System.Boolean> FlashingAction; // 0x50
	FairyGUI.EventCallback0 ButtonClickAction; // 0x58
	WizardGames.Soc.SocClient.Ui.UiHudElemMsgData get_Child(); // 0x05bf148c
	System.Void set_Child(WizardGames.Soc.SocClient.Ui.UiHudElemMsgData value); // 0x05bf14f0
	System.Int32 get_Order(); // 0x05bf1570
	System.Int32 get_Id(); // 0x05bf15e4
	System.String get_MsgStr(); // 0x05bf1648
	System.Void set_MsgStr(System.String value); // 0x05bf16d8
	System.String get_DataStr(); // 0x05bf176c
	System.Void set_DataStr(System.String value); // 0x05bf17fc
	System.String get_DesStr(); // 0x05bf1890
	System.Void set_DesStr(System.String value); // 0x05bf1920
	System.Int32 get_MsgType(); // 0x05bf19b4
	System.Single get_ShowTime(); // 0x05bf1a28
	System.String get_IconUrl(); // 0x05bf1a9c
	System.String get_IconRightUrl(); // 0x05bf1b2c
	System.Void set_IconRightUrl(System.String value); // 0x05bf1bbc
	System.String[] get_IconRightUrlTypes(); // 0x05bf1c50
	UnityEngine.Color get_BgColor(); // 0x05bf1cc4
	System.Void set_BgColor(UnityEngine.Color value); // 0x05bf1d44
	UnityEngine.Color[] get_BgColorTypes(); // 0x05bf1dec
	UnityEngine.Color get_FontColor(); // 0x05bf1e60
	UnityEngine.Color get_IconColor(); // 0x05bf1ee0
	System.Void Disappeared(); // 0x05bf1f60
	System.Void .ctor(); // 0x05bf1fd4
	System.Void Init(System.Int32 msgId, WizardGames.Soc.SocClient.Ui.MsgAttributeSet attrSet, System.Single remainingTime); // 0x05bf2098
	System.Void RefreshMsg(System.String msgStr); // 0x05bf2148
	System.Void RefreshTime(System.Single time); // 0x05bf21dc
	System.Void RefreshColor(System.String iconUrl, System.String iconRightUrl, UnityEngine.Color bgColor, UnityEngine.Color fontColor, UnityEngine.Color iconColor); // 0x05bf2270
	System.Void Update(System.Single deltaTime); // 0x05bf2420
	System.Boolean CheckDisappearTrans(); // 0x05bf24d0
	System.Boolean Equal(WizardGames.Soc.SocClient.Ui.UiHudElemMsgData data); // 0x05bf256c
	System.Void Clear(); // 0x05bf25f8
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiHudElemMsgData.HudMsgState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiHudElemMsgData.HudMsgState Init = 0;
	static WizardGames.Soc.SocClient.Ui.UiHudElemMsgData.HudMsgState Appearing = 1;
	static WizardGames.Soc.SocClient.Ui.UiHudElemMsgData.HudMsgState Appeared = 2;
	static WizardGames.Soc.SocClient.Ui.UiHudElemMsgData.HudMsgState Disappearing = 3;
	static WizardGames.Soc.SocClient.Ui.UiHudElemMsgData.HudMsgState Disappeared = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MsgAttributeSet : System.Object
{
	System.String msgStr; // 0x10
	System.String dataStr; // 0x18
	System.String desStr; // 0x20
	System.Int32 msgType; // 0x28
	System.Int32 priority; // 0x2c
	System.Single showTime; // 0x30
	System.String iconUrl; // 0x38
	System.String[] iconUrlTypes; // 0x40
	System.String iconRightUrl; // 0x48
	System.String[] iconRightUrlTypes; // 0x50
	UnityEngine.Color bgColor; // 0x58
	UnityEngine.Color[] bgColorTypes; // 0x68
	UnityEngine.Color fontColor; // 0x70
	UnityEngine.Color[] fontColorTypes; // 0x80
	UnityEngine.Color iconColor; // 0x88
	UnityEngine.Color[] iconColorTypes; // 0x98
	System.Void .ctor(); // 0x05bf2874
	System.Void Clear(); // 0x05bf2708
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemPlayerAllBars : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	WizardGames.Soc.SocClient.Ui.UiPlayerStatusData data; // 0x190
	WizardGames.Soc.SocClient.Ui.UiHudElemPlayerLifeBar playerLifeBar; // 0x198
	WizardGames.Soc.SocClient.Ui.UiHudElemPlayerWaterBar playerWaterBar; // 0x1a0
	WizardGames.Soc.SocClient.Ui.UiHudElemPlayerHungerBar playerHungerBar; // 0x1a8
	System.Single orignPosY; // 0x1b0
	FairyGUI.Controller ctrIsBuildMode; // 0x1b8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05bf29ec
	System.Void OnUiDestroy(); // 0x05bf2d6c
	System.Void OnEnable(); // 0x05bf2eac
	System.Void OnBuildModeChange(); // 0x05bf2f54
	System.Void SetStatus(WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus status, System.Boolean reset); // 0x05bf30d8
	System.Void RefreshStatus(); // 0x05bf31cc
	System.Void OnFps10Update(System.Single dt); // 0x05bf327c
	System.Void .ctor(); // 0x05bf338c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemPlayerHungerBar : WizardGames.Soc.SocClient.Ui.UiHudElemBar
{
	System.Boolean showHunger; // 0x80
	System.Void Init(WizardGames.Soc.SocClient.Ui.UiPlayerStatusData uiData, FairyGUI.GComponent root, System.Int32 maxValue); // 0x05bf33f4
	System.Void OnClickIcon(); // 0x05bf3710
	System.String GetTipString(); // 0x05bf3844
	System.Void Refresh(); // 0x05bf3ae4
	System.Void .ctor(); // 0x05bf2d04
	System.Void <Refresh>b__4_0(WizardGames.Soc.SocClient.Ui.UiHudElemMsgData msgData); // 0x05bf3df0
	System.Boolean <Refresh>b__4_1(); // 0x05bf408c
	System.Boolean <Refresh>b__4_2(); // 0x05bf4118
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemPlayerLifeBar : WizardGames.Soc.SocClient.Ui.UiHudElemBar
{
	FairyGUI.GTextField maxHpText; // 0x80
	System.Int32 lastPlayerVirtualHp; // 0x88
	System.Int32 lastPlayerHp; // 0x8c
	FairyGUI.Transition redFlashing; // 0x90
	FairyGUI.Transition orangeFlashing; // 0x98
	FairyGUI.Transition greenFlashing; // 0xa0
	FairyGUI.GImage bgResidual; // 0xa8
	FairyGUI.Transition residualTransition; // 0xb0
	System.Boolean isResidualPlaying; // 0xb8
	System.Int64 timerId; // 0xc0
	System.Void Init(WizardGames.Soc.SocClient.Ui.UiPlayerStatusData uiData, FairyGUI.GComponent root, System.Int32 maxValue); // 0x05bf4194
	System.Void OnInjuredDown(); // 0x05bf4be0
	System.Void OnDestroy(); // 0x05bf4e54
	System.Void OnEnable(); // 0x05bf4f60
	System.Void Refresh(); // 0x05bf51a8
	System.Void CheckTransition(); // 0x05bf4fd0
	System.Void TimerCallback(System.Int64 id, System.Object data, System.Boolean del); // 0x05bf59a8
	System.Void StopTransition(FairyGUI.Transition transition); // 0x05bf4c9c
	System.Void PlayTransition(FairyGUI.Transition transition); // 0x05bf4d78
	System.Void SetBarLessTrans(); // 0x05bf5a3c
	System.Void SetBarColor(); // 0x05bf4780
	System.Void .ctor(); // 0x05bf2c9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemPlayerStatus : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	UnityEngine.Vector2 orignPos; // 0x190
	System.Int32 BuildPanelExpandHeight; // 0x198
	System.Int32 BuildPanelWidthOffset; // 0x19c
	System.Boolean IsShortcutsDeployMode; // 0x1a0
	WizardGames.Soc.SocClient.Ui.UiHudCommonPlayerStatus uiHudCommonPlayerStatus; // 0x1a8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05bf63a4
	System.Void OnUiDestroy(); // 0x05bf6618
	System.Void StartEdit(); // 0x05bf66a0
	System.Void Update(); // 0x05bf67ec
	System.Void RefreshStatus(); // 0x05bf68a8
	System.Void SetStatus(WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus status, System.Boolean reset); // 0x05bf6920
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x05bf69d4
	System.Void OnBuildPanelExpandStateChanged(System.Boolean isExpand); // 0x05bf6a68
	System.Void OnHudStateChanged(System.Collections.Generic.List<System.Int32> displayElems); // 0x05bf6ff0
	System.Void OnShortCutsDeployModeStateChanged(System.Boolean isEnter); // 0x05bf7068
	System.Void OnFps1Update(System.Single dt); // 0x05bf70e8
	System.Void OnFps10Update(System.Single dt); // 0x05bf717c
	System.Void OnEnable(); // 0x05bf7210
	System.Void OnDisable(); // 0x05bf7384
	System.Void OnUiOpen(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05bf74e8
	System.Void OnShortCutsChooseMenuStateChange(System.Boolean isOpen); // 0x05bf75f8
	System.Void AutoFitPos(); // 0x05bf6b0c
	System.Void OnInitUiHudCommonPlayerStatus(FairyGUI.GComponent node); // 0x05bf6430
	System.Void .ctor(); // 0x05bf77b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemPlayerStatusDetailList : System.Object
{
	static SocLogger Logger; // 0x0
	WizardGames.Soc.SocClient.Ui.UiPlayerStatusData data; // 0x10
	FairyGUI.GComponent msgListCom; // 0x18
	FairyGUI.GList msgGlist; // 0x20
	FairyGUI.GComponent msgTranCom; // 0x28
	FairyGUI.GLoader msgTranIconLoader; // 0x30
	FairyGUI.GTextField msgTranDataText; // 0x38
	FairyGUI.GTextField msgTranNameText; // 0x40
	FairyGUI.GImage msgTransBg; // 0x48
	FairyGUI.Transition curMsgAppearTrans; // 0x50
	FairyGUI.Transition msgAppearTrans; // 0x58
	FairyGUI.Transition msgNumAppearTrans; // 0x60
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.UiHudElemMsgData> msgDataDict; // 0x68
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.Binder.GameHud.ElemPlayerMsgBoxBinder> msgUiItemDict; // 0x70
	FairyGUI.Transition moveAnim; // 0x78
	UnityEngine.Vector2 msgTranInitPos; // 0x80
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.UiHudElemPlayerStatusDetailList.ToolTipsBinder> toolTipsBinders; // 0x88
	UnityEngine.Color anoxiaIconColor1s; // 0x90
	UnityEngine.Color anoxiaNameColor1s; // 0xa0
	UnityEngine.Color anoxiaIconColor2s; // 0xb0
	UnityEngine.Color anoxiaNameColor2s; // 0xc0
	WizardGames.Soc.Common.Data.tips.MsgTip anoxiaConfig; // 0xd0
	System.Void .ctor(); // 0x05bf782c
	System.Void Init(FairyGUI.GComponent root); // 0x05bf7a40
	System.Void OnDestroy(); // 0x05bf7ffc
	System.Void OnFps10PlayerStatusDetailsUpdate(System.Single dt); // 0x05bf80b8
	System.Void InitMsgUiItem(WizardGames.Soc.SocClient.Ui.Binder.GameHud.ElemPlayerMsgBoxBinder binder, WizardGames.Soc.SocClient.Ui.UiHudElemMsgData data, System.Boolean isImmediatelyCreate); // 0x05bf822c
	System.Void UpdateMsgUiItem(WizardGames.Soc.SocClient.Ui.Binder.GameHud.ElemPlayerMsgBoxBinder binder, WizardGames.Soc.SocClient.Ui.UiHudElemMsgData data); // 0x05bf8fe8
	System.Void RemoveMsgUiItem(WizardGames.Soc.SocClient.Ui.Binder.GameHud.ElemPlayerMsgBoxBinder uiItem, WizardGames.Soc.SocClient.Ui.UiHudElemMsgData data); // 0x05bf963c
	System.Void SetMsgTranInfo(System.String url, UnityEngine.Color iconColor, System.String dataText, UnityEngine.Color dataColor, System.String nameText, UnityEngine.Color nameColor, UnityEngine.Color bgColor, System.Single bgAlpha); // 0x05bf8dac
	System.Void CreateNewMsgUiItem(System.Int32 id, WizardGames.Soc.SocClient.Ui.UiHudElemMsgData data, System.Boolean isImmediatelyCreate); // 0x05bf9954
	System.Void OnSetMoveAnim(FairyGUI.GComponent animItem); // 0x05bf9a84
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x05bf9f48
	System.Void Refresh(); // 0x05bfa04c
	System.Void RefreshMsgUiItemElement(); // 0x05bf8130
	static System.Void .cctor(); // 0x05bfa650
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemPlayerStatusDetailList.ToolTipsBinder : System.Object, WizardGames.Soc.SocClient.Ui.Utils.IToolTips
{
	FairyGUI.GComponent Target; // 0x10
	WizardGames.Soc.SocClient.Ui.UiHudElemMsgData Data; // 0x18
	System.Void .ctor(FairyGUI.GComponent target); // 0x05bfa724
	System.Void ShowTips(FairyGUI.EventContext context); // 0x05bfa7b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemPlayerStatusDetailList.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHudElemPlayerStatusDetailList.<>c <>9; // 0x0
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.UiHudElemPlayerStatusDetailList.ToolTipsBinder> <>9__25_0; // 0x8
	static System.Void .cctor(); // 0x05bfa870
	System.Void .ctor(); // 0x05bfa8d4
	WizardGames.Soc.SocClient.Ui.UiHudElemPlayerStatusDetailList.ToolTipsBinder <.ctor>b__25_0(FairyGUI.GComponent c); // 0x05bfa93c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemPlayerStatusDetailList.<>c__DisplayClass29_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudElemMsgData data; // 0x10
	WizardGames.Soc.SocClient.Ui.UiHudElemPlayerStatusDetailList <>4__this; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameHud.ElemPlayerMsgBoxBinder binder; // 0x20
	System.Void .ctor(); // 0x05bf8d44
	System.Void <InitMsgUiItem>b__0(); // 0x05bfa9dc
	System.Void <InitMsgUiItem>b__1(); // 0x05bfaab0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemPlayerStatusDetailList.<>c__DisplayClass35_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudElemPlayerStatusDetailList <>4__this; // 0x10
	FairyGUI.GComponent animItem; // 0x18
	WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__1; // 0x20
	System.Void .ctor(); // 0x05bf9ee0
	System.Void <OnSetMoveAnim>b__0(); // 0x05bfab20
	System.Void <OnSetMoveAnim>b__1(System.Int64 id, System.Object data, System.Boolean delete); // 0x05bface0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemPlayerWaterBar : WizardGames.Soc.SocClient.Ui.UiHudElemBar
{
	System.Boolean showThirsty; // 0x80
	System.Void Init(WizardGames.Soc.SocClient.Ui.UiPlayerStatusData uiData, FairyGUI.GComponent root, System.Int32 maxValue); // 0x05bfad8c
	System.Void OnClickIcon(); // 0x05bfb0a8
	System.String GetTipString(); // 0x05bfb1dc
	System.Void Refresh(); // 0x05bfb56c
	System.Void .ctor(); // 0x05bfb860
	System.Void <Refresh>b__4_0(WizardGames.Soc.SocClient.Ui.UiHudElemMsgData msgData); // 0x05bfb8c8
	System.Boolean <Refresh>b__4_1(); // 0x05bfbc08
	System.Boolean <Refresh>b__4_2(); // 0x05bfbc90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemVehicleBrake : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate_Input
{
	FairyGUI.GButton mainBtn; // 0x190
	System.Boolean isPress; // 0x198
	FairyGUI.Controller iconCtrl; // 0x1a0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05bfbd08
	System.Void OnShow(); // 0x05bfbed0
	System.Void TouchBegin(FairyGUI.EventContext context); // 0x05bfc0ac
	System.Void TouchEnd(FairyGUI.EventContext context); // 0x05bfc16c
	System.Void OnFpsUnlimitedUpdate_Input(System.Single dt); // 0x05bfc1e4
	System.Void .ctor(); // 0x05bfc2b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemVehicleDirection : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	System.Boolean isPress; // 0x190
	FairyGUI.Transition clickAnim; // 0x198
	FairyGUI.Controller vehicleTypeCtrl; // 0x1a0
	FairyGUI.GButton mainBtn; // 0x1a8
	FairyGUI.Controller mainBtnCtrl; // 0x1b0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05bfc318
	System.Void OnBoardInit(); // 0x05bfc63c
	System.Void OnBoardDestroy(); // 0x05bfc6a4
	System.Void OnEnable(); // 0x05bfc70c
	System.Void TouchBegin(); // 0x05bfc8cc
	System.Void TouchEnd(); // 0x05bfcc68
	System.Void .ctor(); // 0x05bfcccc
	System.Void <TouchBegin>b__10_0(); // 0x05bfcd34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemVehicleDown : WizardGames.Soc.SocClient.Ui.UiHudElemVehicleVerticalDirection, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05bfcda0
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05bfd334
	System.Void OnHotKeyAction(); // 0x05bfd398
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05bfd478
	System.Void StartEdit(); // 0x05bfd54c
	System.Void .ctor(); // 0x05bfd600
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemVehicleEngine : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GButton mainBtn; // 0x190
	FairyGUI.Controller styleCtrl; // 0x198
	WizardGames.Soc.SocClient.Manager.EResponseLevel <ResposeLevel>k__BackingField; // 0x1a0
	WizardGames.Soc.Common.Data.ActionName <HotKey>k__BackingField; // 0x1a4
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05bfd6cc
	WizardGames.Soc.SocClient.Manager.EResponseLevel get_ResposeLevel(); // 0x05bfd8c4
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05bfd928
	System.Void OnHotKeyAction(); // 0x05bfd98c
	System.Void OnUiDestroy(); // 0x05bfdb2c
	System.Void OnEnable(); // 0x05bfdc30
	System.Void OnLoadingSuccess(); // 0x05bfddc4
	System.Void OnClick(); // 0x05bfdf84
	System.Void OnOpenEngine(WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType mode, System.Int64 lootingEntityId); // 0x05bfe288
	System.Void OnCloseEngine(WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType mode, System.Int64 lootingEntityId); // 0x05bfe57c
	System.Void .ctor(); // 0x05bfe938
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemVehicleEngine.<>c__DisplayClass13_0 : System.Object
{
	WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountGo; // 0x10
	WizardGames.Soc.SocClient.Ui.UiHudElemVehicleEngine <>4__this; // 0x18
	System.Void .ctor(); // 0x05bfe220
	System.Void <OnClick>b__0(System.Boolean res); // 0x05bfe9ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemVehicleLight : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	FairyGUI.GButton mainBtn; // 0x190
	FairyGUI.Controller colorCtrl; // 0x198
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05bfeb94
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05bfed04
	System.Void OnHotKeyAction(); // 0x05bfed68
	System.Void OnClick(); // 0x05bfede4
	System.Void TryTurnLight(WizardGames.Soc.Common.Unity.Go.BaseMountableGo baseMountableGo); // 0x05bfee9c
	System.Void OnFps10Update(System.Single dt); // 0x05bff40c
	System.Void ChangeLightStatus(WizardGames.Soc.Common.Unity.Go.BaseMountableGo baseMountableGo); // 0x05bff4dc
	System.Void .ctor(); // 0x05bff730
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemVehicleSeat : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	FairyGUI.Container fguiContainer; // 0x190
	System.Collections.Generic.List<FairyGUI.GList> seatLists; // 0x198
	WizardGames.Soc.Common.Entity.IBaseMountableEntity baseMountableEntity; // 0x1a0
	System.Collections.Generic.Dictionary<System.Int32,FairyGUI.GObject> seatIndexToIcon; // 0x1a8
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Int32> iconToSeatIndex; // 0x1b0
	System.Collections.Generic.List<FairyGUI.GObject> seatSwitchList; // 0x1b8
	System.Collections.Generic.List<System.Int32> sortedSeatList; // 0x1c0
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> modularIndexToRow; // 0x1c8
	FairyGUI.GLoader rootLoader; // 0x1d0
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Go.BaseVehicleModuleGo> tempGoList; // 0x1d8
	WizardGames.Soc.SocClient.Manager.HotKeyAction seatKey1; // 0x1e0
	WizardGames.Soc.SocClient.Manager.HotKeyAction seatKey2; // 0x1e8
	WizardGames.Soc.SocClient.Manager.HotKeyAction seatKey3; // 0x1f0
	WizardGames.Soc.SocClient.Manager.HotKeyAction seatKey4; // 0x1f8
	WizardGames.Soc.SocClient.Manager.HotKeyAction seatKey5; // 0x200
	WizardGames.Soc.SocClient.Manager.HotKeyAction seatKey6; // 0x208
	WizardGames.Soc.SocClient.Manager.HotKeyAction seatKey7; // 0x210
	WizardGames.Soc.SocClient.Manager.HotKeyAction seatKey8; // 0x218
	WizardGames.Soc.SocClient.Manager.HotKeyAction seatKey9; // 0x220
	WizardGames.Soc.SocClient.Manager.HotKeyAction seatKey0; // 0x228
	System.Int32[] _rowNum; // 0x230
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05bff798
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05bffc44
	System.Void OnHotKeyAction(); // 0x05bffca8
	System.Void OnEnable(); // 0x05c00404
	System.Void OnGoAdd(WizardGames.Soc.Common.Unity.Go.IEntityGo go); // 0x05c009b4
	System.Void SwitchSeat(System.Int32 index); // 0x05c00a88
	System.Void OnDisable(); // 0x05c00b90
	System.Void OnUiDestroy(); // 0x05c00e04
	System.Void OnClick(FairyGUI.EventContext context); // 0x05c00f44
	System.Void OnShow(); // 0x05c012a0
	System.Boolean OnShowCheck(); // 0x05c01590
	System.Void StartEdit(); // 0x05c017e4
	System.Void OnFps10Update(System.Single dt); // 0x05c014dc
	System.Void UpdateShow(); // 0x05c021d0
	System.Void InitSeatIcon(); // 0x05c0131c
	System.Collections.Generic.List<UnityEngine.Vector3Int> GetSeatCoords(WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo); // 0x05c023dc
	System.Void AttachIndexWithIcon(System.Collections.Generic.List<UnityEngine.Vector3Int> seatCoords, System.Boolean isModularCar); // 0x05c02e24
	System.Void SetIsDriver(WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo); // 0x05c038dc
	System.Void SetOffset(WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo); // 0x05c03b64
	System.Boolean UpdateOccupied(); // 0x05c01c70
	System.Boolean IsOccupied(WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo, System.Int32 index, System.Int64& playerId); // 0x05c000a0
	System.Boolean IsDriver(WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo, System.Int32 index); // 0x05c043e4
	System.Int64 GetSeatPlayerId(WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo, System.Int32 index); // 0x05c04548
	System.Void GetRealMountIdAndIndex(WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo, System.Int64& mountId, System.Int32& index); // 0x05c00274
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Go.BaseVehicleModuleGo> GetBaseVehicleModuleGoList(WizardGames.Soc.Common.Unity.Go.BaseVehicleModuleGo baseVehicleModuleGo); // 0x05c04710
	System.Void InitView(); // 0x05bffbe4
	System.Void SetHorseSeatMountPoints(Soc.Vehicle.MountPointConfig seatConfig); // 0x05c04370
	System.Void .ctor(); // 0x05c04b64
	System.Void <OnEnable>b__25_0(); // 0x05c04df4
	System.Void <OnEnable>b__25_1(); // 0x05c04e5c
	System.Void <OnEnable>b__25_2(); // 0x05c04ec4
	System.Void <OnEnable>b__25_3(); // 0x05c04f2c
	System.Void <OnEnable>b__25_4(); // 0x05c04f94
	System.Void <OnEnable>b__25_5(); // 0x05c04ffc
	System.Void <OnEnable>b__25_6(); // 0x05c05064
	System.Void <OnEnable>b__25_7(); // 0x05c050cc
	System.Void <OnEnable>b__25_8(); // 0x05c05134
	System.Void <OnEnable>b__25_9(); // 0x05c0519c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemVehicleSeat.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHudElemVehicleSeat.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Unity.Go.BaseVehicleModuleGo> <>9__38_0; // 0x8
	static System.Comparison<System.Int32> <>9__39_0; // 0x10
	static System.Comparison<WizardGames.Soc.Common.Unity.Go.BaseVehicleModuleGo> <>9__47_0; // 0x18
	static System.Comparison<WizardGames.Soc.Common.Unity.Go.BaseVehicleModuleGo> <>9__47_1; // 0x20
	static System.Void .cctor(); // 0x05c05204
	System.Void .ctor(); // 0x05c05268
	System.Int32 <GetSeatCoords>b__38_0(WizardGames.Soc.Common.Unity.Go.BaseVehicleModuleGo a, WizardGames.Soc.Common.Unity.Go.BaseVehicleModuleGo b); // 0x05c052d0
	System.Int32 <AttachIndexWithIcon>b__39_0(System.Int32 a, System.Int32 b); // 0x05c05380
	System.Int32 <GetBaseVehicleModuleGoList>b__47_0(WizardGames.Soc.Common.Unity.Go.BaseVehicleModuleGo x, WizardGames.Soc.Common.Unity.Go.BaseVehicleModuleGo y); // 0x05c05408
	System.Int32 <GetBaseVehicleModuleGoList>b__47_1(WizardGames.Soc.Common.Unity.Go.BaseVehicleModuleGo a, WizardGames.Soc.Common.Unity.Go.BaseVehicleModuleGo b); // 0x05c054b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemVehicleSpeedBoost : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	
	System.Void .ctor(); // 0x05c05568
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemVehicleStatus : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	FairyGUI.Container fguiContainer; // 0x190
	FairyGUI.GTextField velocityText; // 0x198
	FairyGUI.GLoader fuelIcon; // 0x1a0
	FairyGUI.GLoader hpIcon; // 0x1a8
	FairyGUI.GComponent iconComp; // 0x1b0
	FairyGUI.GLoader colorIcon; // 0x1b8
	FairyGUI.Controller statusVehicleTypeCtrl; // 0x1c0
	FairyGUI.Controller iconVehicleTypeCtrl; // 0x1c8
	FairyGUI.Controller iconVehicleHealthCtrl; // 0x1d0
	WizardGames.Soc.Common.Entity.IBaseMountableEntity <BaseMountableEntity>k__BackingField; // 0x1d8
	WizardGames.Soc.Common.Unity.Go.BaseMountableGo baseMountableGo; // 0x1e0
	System.Text.StringBuilder velocityStr; // 0x1e8
	FairyGUI.GComponent horseWeakCom; // 0x1f0
	FairyGUI.GComponent vehicleDecayLoaderCom; // 0x1f8
	FairyGUI.Controller vehicleDecayCtrl; // 0x200
	FairyGUI.GComponent weakTipCom; // 0x208
	FairyGUI.GComponent horseWeakTipBg; // 0x210
	System.Boolean showWeakTips; // 0x218
	FairyGUI.Controller <DecayCtrl>k__BackingField; // 0x220
	FairyGUI.GComponent gearInfo; // 0x228
	FairyGUI.Transition flashAnim; // 0x230
	FairyGUI.GTextField autoDriveText; // 0x238
	System.Boolean bListeningCloseWindow; // 0x240
	WizardGames.Soc.SocClient.Ui.Binder.GameHudElemVehicleStatus.ElemVehicleStatusBinder viewBinder; // 0x248
	WizardGames.Soc.SocClient.Ui.Binder.GameHudElemVehicleStatus.ComVehicleValueBarBinder hpBarBinder; // 0x250
	WizardGames.Soc.SocClient.Ui.Binder.GameHudElemVehicleStatus.ComVehicleValueBarBinder fuelBarBinder; // 0x258
	System.Int32 _lastVLen; // 0x260
	System.Int32 _lastThrottleFraction; // 0x264
	WizardGames.Soc.Common.Entity.IBaseMountableEntity get_BaseMountableEntity(); // 0x05c055d0
	System.Void set_BaseMountableEntity(WizardGames.Soc.Common.Entity.IBaseMountableEntity value); // 0x05c05634
	System.Boolean get_IsHorse(); // 0x05c056b4
	FairyGUI.GComponent get_HorseWeakCom(); // 0x05c057ac
	System.Void set_VehicleDecayLoaderCom(FairyGUI.GComponent value); // 0x05c05998
	FairyGUI.GComponent get_VehicleDecayLoaderCom(); // 0x05c05a18
	FairyGUI.Controller get_DecayCtrl(); // 0x05c05c44
	System.Void set_DecayCtrl(FairyGUI.Controller value); // 0x05c05ca8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c05d28
	System.Void OnEnable(); // 0x05c064cc
	System.Void OnDisable(); // 0x05c065ec
	System.Void ClearDynamicLoadComs(); // 0x05c06720
	System.Void OnVehicleAutoDriveChange(); // 0x05c063b4
	System.Void OnListeningCloseWindow(UnityEngine.Vector2 uiPos); // 0x05c068a0
	System.Void LoadWeakTips(); // 0x05c06dc8
	System.Void SetWeakTipVisible(System.Boolean visible); // 0x05c06984
	System.Boolean TryGetMountableDecayDes(WizardGames.Soc.Common.Entity.IBaseMountableEntity entity, WizardGames.Soc.Common.Data.tips.MsgTip& msgTip); // 0x05c06ff4
	System.Void OnUiDestroy(); // 0x05c07488
	System.Void OnShortcutsChooseMenuStateChange(System.Boolean state); // 0x05c07608
	System.Void OnClickHorseWeak(); // 0x05c076f4
	System.Void OnShow(); // 0x05c07764
	System.Boolean OnShowCheck(); // 0x05c07cdc
	System.Void OnHide(); // 0x05c08130
	System.Void OnFps10Update(System.Single dt); // 0x05c07bac
	System.Boolean UpdateVelocityText(); // 0x05c081d0
	System.Boolean UpdateIcon(); // 0x05c08858
	FairyGUI.GComponent GetVehicleDecayLoaderCom(); // 0x05c0a1f4
	UnityEngine.Vector2 GetVehicleDecayLoaderComPos(); // 0x05c0a258
	System.Boolean IsLowValue(System.Single cur, System.Single max, System.Single threshold); // 0x05c0a32c
	static System.Void GetHpAndMaxHp(WizardGames.Soc.Common.Entity.IBaseMountableEntity entity, System.Single& nowHp, System.Single& maxHp); // 0x05c09cf8
	System.Boolean UpdateValueInfo(); // 0x05c08b08
	System.Boolean UpdateDecay(); // 0x05c09960
	static System.Int32 GetDecay(WizardGames.Soc.Common.Entity.IBaseMountableEntity entity); // 0x05c07230
	System.Void InitView(FairyGUI.GComponent node); // 0x05c06340
	System.Void SetVehicleSeatPos(); // 0x05c07b4c
	System.Void .ctor(); // 0x05c0a3d8
	System.Void <SetWeakTipVisible>b__55_0(); // 0x05c0a448
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemVehicleTrainChangeTrail : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GButton leftBtn; // 0x190
	FairyGUI.Controller leftCtrl; // 0x198
	FairyGUI.GButton rightBtn; // 0x1a0
	FairyGUI.Controller rightCtrl; // 0x1a8
	WizardGames.Soc.Common.Entity.TrainCarEntity mTrainCarEntity; // 0x1b0
	FairyGUI.GComponent comTips; // 0x1b8
	FairyGUI.GTextField tipText; // 0x1c0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c0a4b0
	System.Void OnEnable(); // 0x05c0a7c8
	System.Void OnDisable(); // 0x05c0ac00
	System.Void OnShow(); // 0x05c0adac
	System.Void OnTrainTrackSelectionChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldValue, System.Int32 newValue); // 0x05c0b0f4
	System.Void OnTrainChangeTrailStatusCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldValue, System.Int32 newValue); // 0x05c0b188
	System.Void UpdateTrailStatusUI(System.Int32 val); // 0x05c0af28
	System.Void UpdateTrackSelectUI(); // 0x05c0aad8
	System.Void OnClick(FairyGUI.EventContext context); // 0x05c0b220
	System.Void .ctor(); // 0x05c0b4dc
	System.Void <OnEnable>b__8_0(); // 0x05c0b544
	System.Void <OnEnable>b__8_1(); // 0x05c0b5c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemVehicleTrainChangeTrailTip : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	
	System.Void .ctor(); // 0x05c0b63c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemVehicleTrainGearInfo : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	FairyGUI.Controller gearCtrl; // 0x190
	FairyGUI.Controller speedCtrl; // 0x198
	FairyGUI.GTextField gearText; // 0x1a0
	FairyGUI.GTextField speedText; // 0x1a8
	System.Int32 gearIdx; // 0x1b0
	System.Int32 speedIdx; // 0x1b4
	WizardGames.Soc.Common.Entity.TrainCarEntity trainCarEntity; // 0x1b8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c0b6a4
	System.Boolean OnShowCheck(); // 0x05c0b820
	System.Void OnShow(); // 0x05c0b97c
	System.Void OnFps10Update(System.Single dt); // 0x05c0bc14
	System.Void UpdateGear(); // 0x05c0b9ec
	System.Void .ctor(); // 0x05c0bc8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemVehicleUp : WizardGames.Soc.SocClient.Ui.UiHudElemVehicleVerticalDirection, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	System.Boolean isUp; // 0x1b8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c0bcfc
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c0bdc4
	System.Void OnHotKeyAction(); // 0x05c0be28
	System.Void OnFps30Update(System.Single dt); // 0x05c0bf08
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05c0c008
	System.Void StartEdit(); // 0x05c0c0dc
	System.Void .ctor(); // 0x05c0c190
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemVehicleVerticalDirection : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GButton MainBtn; // 0x190
	System.Boolean IsPress; // 0x198
	WizardGames.Soc.Common.Entity.VehicleEntity VehicleEntity; // 0x1a0
	FairyGUI.GTextField Title; // 0x1a8
	FairyGUI.Transition clickAnim; // 0x1b0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05bfce98
	System.Void OnTouchBegin(); // 0x05c0c1fc
	System.Void OnTouchEnd(); // 0x05c0c2dc
	System.Void OnUiDestroy(); // 0x05c0c340
	System.Void OnEnable(); // 0x05c0c3b8
	System.Void OnDisable(); // 0x05c0c428
	System.Void .ctor(); // 0x05bfd664
	System.Void <OnTouchBegin>b__6_0(); // 0x05c0c498
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemVehicleWhistle : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate_Input
{
	FairyGUI.GButton mainBtn; // 0x190
	System.Boolean isTouching; // 0x198
	System.Boolean lastTouching; // 0x199
	static SocLogger Logger; // 0x0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c0c504
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c0c6a8
	System.Void OnHotKeyAction(); // 0x05c0c70c
	System.Void OnDisable(); // 0x05c0c7ec
	System.Void OnTouchEnd(FairyGUI.EventContext context); // 0x05c0c8b4
	System.Void OnTouchBegin(FairyGUI.EventContext context); // 0x05c0c92c
	System.Void OnFpsUnlimitedUpdate_Input(System.Single dt); // 0x05c0c9a8
	System.Void .ctor(); // 0x05c0ca80
	static System.Void .cctor(); // 0x05c0cae8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemVehicleWindow : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	FairyGUI.GButton windowBtn; // 0x190
	FairyGUI.Controller typeController; // 0x198
	FairyGUI.Controller showTimeController; // 0x1a0
	FairyGUI.GTextField txtTime; // 0x1a8
	FairyGUI.GProgressBar progressBar; // 0x1b0
	FairyGUI.GTextField txtNum; // 0x1b8
	FairyGUI.GComponent keyComp; // 0x1c0
	WizardGames.Soc.SocClient.Ui.UiHudElemVehicleWindow.ECurType curType; // 0x1c8
	WizardGames.Soc.Common.Entity.VehicleEntity vehicleEntity; // 0x1d0
	System.Void RefreshCurType(); // 0x05c0cbbc
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c0cd70
	System.Void OnEnable(); // 0x05c0d0cc
	System.Void OnDisable(); // 0x05c0d1e0
	System.Void OnMountableIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Int64 oldValue, System.Int64 newValue); // 0x05c0d2f4
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c0d390
	System.Void OnHotKeyAction(); // 0x05c0d404
	System.Boolean OnShowCheck(); // 0x05c0d480
	System.Void ClickFireBtn(); // 0x055049cc
	System.Int32 GetGanRaoDanNum(); // 0x05c0daf4
	System.Boolean IsInCD(); // 0x054c4760
	System.Void OnFps10Update(System.Single dt); // 0x05513724
	System.Void .ctor(); // 0x05c0de8c
	System.Void <OnUiCreate>b__10_0(); // 0x05c0def4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiHudElemVehicleWindow.ECurType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiHudElemVehicleWindow.ECurType OpenWindow = 0;
	static WizardGames.Soc.SocClient.Ui.UiHudElemVehicleWindow.ECurType FireGanRaoDan = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudPlayerBuff : System.Object
{
	WizardGames.Soc.Common.Component.BuffComponent myServerBuff; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.CustomType.BuffNode> currentBuffNodes; // 0x18
	System.Collections.Generic.List<System.Int32> activeBuffs; // 0x20
	System.Void Init(WizardGames.Soc.SocClient.Ui.UiPlayerStatusData uiData, FairyGUI.GComponent root); // 0x05c0e0e4
	System.Void OnBuffComponentUpdate(); // 0x05c0e2fc
	System.String GetBuffTime(System.Int64 timeLeft, System.Boolean infinite); // 0x05c0eaa0
	System.Void AddOrUpdateBuff(WizardGames.Soc.Common.CustomType.BuffNode buffNode); // 0x05c0e698
	System.Void Refresh(WizardGames.Soc.SocClient.Ui.UiPlayerStatusData data); // 0x05c0ebc4
	System.Void OnDestroy(); // 0x05c0ec38
	System.Void .ctor(); // 0x05c0ed0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudPlayerBuff.<>c__DisplayClass6_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudPlayerBuff <>4__this; // 0x10
	System.Int32 buffId; // 0x18
	System.Void .ctor(); // 0x05c0eb5c
	System.Void <AddOrUpdateBuff>b__0(WizardGames.Soc.SocClient.Ui.UiHudElemMsgData data); // 0x05c0ee18
	System.Boolean <AddOrUpdateBuff>b__1(); // 0x05c0f030
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudPlayerMetabolism : System.Object
{
	System.Boolean showBleeding; // 0x10
	System.Boolean showComfort; // 0x11
	System.Boolean showTemperature; // 0x12
	System.Boolean showRadiationPosion; // 0x13
	System.Boolean showWetness; // 0x14
	System.Boolean showPoison; // 0x15
	System.Boolean showOxygen; // 0x16
	System.Int64 lastHealTipTime; // 0x18
	System.Int64[] lastDamageTipTime; // 0x20
	System.Single hpCache; // 0x28
	System.Single comfortCache; // 0x2c
	System.Single temperatureCache; // 0x30
	System.Single radiationCache; // 0x34
	System.Single wetnessCache; // 0x38
	System.Single posionCache; // 0x3c
	static WizardGames.Soc.SocClient.Ui.UiPlayerStatusData latestStatusData; // 0x0
	System.Void Init(WizardGames.Soc.Common.Unity.Ui.UiEditable board); // 0x05c0f104
	System.Void Refresh(WizardGames.Soc.SocClient.Ui.UiPlayerStatusData data); // 0x05c0f2c4
	System.Void DisplayBleeding(); // 0x05c0f3a4
	System.Void DisplayComfort(); // 0x05c0f668
	System.Void DisplayTemperature(); // 0x05c0f880
	System.Void DisplayRadiation(); // 0x05c0fca4
	System.Void DisplayWetness(); // 0x05c0ff38
	System.Void DisplayPoison(); // 0x05c101e4
	System.String GetLoaderUrl(System.Single airSeconds, WizardGames.Soc.Common.Utility.AirSupplyType airSupplyType); // 0x05c10cbc
	System.Void DisplayOxygen(); // 0x05c10488
	System.Void TransitionColor(WizardGames.Soc.SocClient.Ui.UiHudElemMsgData msgData, System.Single currentVal, System.Single startVal, System.Single valDelta, System.Int32 bias); // 0x05c10dcc
	System.Void PopHurtTip(WizardGames.Soc.Common.SimpleCustom.DamageDataEvent damageData); // 0x05c10fa8
	System.Void PopHealTip(); // 0x05c10734
	System.Single Lerp(System.Single cache, System.Single target, System.Single close, System.Single speed); // 0x05c113c4
	System.Void .ctor(); // 0x05c1149c
	System.Boolean <DisplayBleeding>b__22_1(); // 0x05c11504
	System.Void <DisplayComfort>b__23_0(WizardGames.Soc.SocClient.Ui.UiHudElemMsgData msgData); // 0x05c115a8
	System.Boolean <DisplayComfort>b__23_1(); // 0x05c11720
	System.Void <DisplayTemperature>b__24_0(WizardGames.Soc.SocClient.Ui.UiHudElemMsgData msgData); // 0x05c117c4
	System.Boolean <DisplayTemperature>b__24_1(); // 0x05c11990
	System.Void <DisplayTemperature>b__24_3(WizardGames.Soc.SocClient.Ui.UiHudElemMsgData msgData); // 0x05c11a34
	System.Boolean <DisplayTemperature>b__24_4(); // 0x05c11bf4
	System.Void <DisplayRadiation>b__25_0(WizardGames.Soc.SocClient.Ui.UiHudElemMsgData msgData); // 0x05c11c98
	System.Boolean <DisplayRadiation>b__25_1(); // 0x05c11dac
	System.Void <DisplayWetness>b__26_0(WizardGames.Soc.SocClient.Ui.UiHudElemMsgData msgData); // 0x05c11e50
	System.Boolean <DisplayWetness>b__26_1(); // 0x05c12010
	System.Void <DisplayPoison>b__27_0(WizardGames.Soc.SocClient.Ui.UiHudElemMsgData msgData); // 0x05c120bc
	System.Boolean <DisplayPoison>b__27_1(); // 0x05c121bc
	System.Void <DisplayOxygen>b__29_0(WizardGames.Soc.SocClient.Ui.UiHudElemMsgData msgData); // 0x05c12260
	System.Boolean <DisplayOxygen>b__29_1(); // 0x05c126f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudPlayerMetabolism.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHudPlayerMetabolism.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiHudElemMsgData> <>9__22_0; // 0x8
	static System.Func<System.Boolean> <>9__22_2; // 0x10
	static System.Func<System.Boolean> <>9__24_2; // 0x18
	static System.Func<System.Boolean> <>9__24_5; // 0x20
	static System.Func<System.Boolean> <>9__25_2; // 0x28
	static System.Func<System.Boolean> <>9__26_2; // 0x30
	static System.Func<System.Boolean> <>9__27_2; // 0x38
	static System.Func<System.Boolean> <>9__29_2; // 0x40
	static System.Void .cctor(); // 0x05c127b8
	System.Void .ctor(); // 0x05c1281c
	System.Void <DisplayBleeding>b__22_0(WizardGames.Soc.SocClient.Ui.UiHudElemMsgData msgData); // 0x05c12884
	System.Boolean <DisplayBleeding>b__22_2(); // 0x05c12948
	System.Boolean <DisplayTemperature>b__24_2(); // 0x05c129ac
	System.Boolean <DisplayTemperature>b__24_5(); // 0x05c12a40
	System.Boolean <DisplayRadiation>b__25_2(); // 0x05c12ad4
	System.Boolean <DisplayWetness>b__26_2(); // 0x05c12b38
	System.Boolean <DisplayPoison>b__27_2(); // 0x05c12b9c
	System.Boolean <DisplayOxygen>b__29_2(); // 0x05c12c00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerStatusConfig : System.Object
{
	UnityEngine.Color GreenLifeBarColor; // 0x10
	UnityEngine.Color GreenLifeBarVirtualColor; // 0x20
	UnityEngine.Color RedLifeBarColor; // 0x30
	UnityEngine.Color WhiteBarNormalColor; // 0x40
	UnityEngine.Color RedBarLessColor; // 0x50
	UnityEngine.Color WhiteTextNormalColor; // 0x60
	UnityEngine.Color RedTextLessColor; // 0x70
	System.Void .ctor(); // 0x05c12cbc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerStatusData : System.Object
{
	WizardGames.Soc.Common.Entity.PlayerEntity _serverMyPlayer; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.UiHudElemMsgData> <MsgDatasDic>k__BackingField; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.UiHudElemMsgData> <MsgItemsDatasDic>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.UiHudElemMsgData <MsgCoverageData>k__BackingField; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiHudElemMsgData> <MsgIndependentDatasList>k__BackingField; // 0x30
	Systems.CustomMinHeap<WizardGames.Soc.SocClient.Ui.UiHudElemMsgData> <MsgDatasHeap>k__BackingField; // 0x38
	System.Collections.Generic.List<System.Int32> <AllMsgIdList>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Ui.UiPlayerStatusConfig config; // 0x48
	System.Boolean isInjuredDown; // 0x50
	System.Action InjuredDownAction; // 0x58
	WizardGames.Soc.Common.Entity.PlayerEntity get_ServerMyPlayer(); // 0x05c0e218
	WizardGames.Soc.SocClient.Ui.UiPlayerStatusConfig get_Config(); // 0x05c12d5c
	WizardGames.Soc.Common.Entity.PlayerEntity get_MyPlayer(); // 0x05c12dc0
	System.Int32 get_PlayerHp(); // 0x05c11210
	System.Int32 get_PlayerVirtualHp(); // 0x05c12e5c
	System.Single get_PendingHealth(); // 0x05c12ffc
	System.Int32 get_CaloriesBenefit(); // 0x05c11328
	System.Int32 get_PlayerHpMax(); // 0x05c13070
	System.Int32 get_PlayerWater(); // 0x05bfb474
	System.Int32 get_PlayerWaterMax(); // 0x05bfb508
	System.Int32 get_PlayerHunger(); // 0x05bfbb74
	System.Int32 get_PlayerHungerMax(); // 0x05c131d0
	System.Int32 get_Bleeding(); // 0x05c109b0
	System.Single get_Comfort(); // 0x05c10a40
	System.Int32 get_Temperature(); // 0x05c10ab4
	System.Int32 get_RadiationPoison(); // 0x05c10b44
	System.Single get_Wetness(); // 0x05c10bd4
	System.Single get_Poison(); // 0x05c10c48
	System.Single get_Oxygen(); // 0x05c12674
	System.Void set_IsInjuredDown(System.Boolean value); // 0x05c13234
	System.Boolean get_IsInjuredDown(); // 0x05c132d4
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.UiHudElemMsgData> get_MsgDatasDic(); // 0x05c13338
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.UiHudElemMsgData> get_MsgItemsDatasDic(); // 0x05c1339c
	WizardGames.Soc.SocClient.Ui.UiHudElemMsgData get_MsgCoverageData(); // 0x05c13400
	System.Void set_MsgCoverageData(WizardGames.Soc.SocClient.Ui.UiHudElemMsgData value); // 0x05c13464
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiHudElemMsgData> get_MsgIndependentDatasList(); // 0x05c134e4
	Systems.CustomMinHeap<WizardGames.Soc.SocClient.Ui.UiHudElemMsgData> get_MsgDatasHeap(); // 0x05c13548
	System.Collections.Generic.List<System.Int32> get_AllMsgIdList(); // 0x05c135ac
	System.Void .ctor(); // 0x05c13610
	System.Void UpdateAllMsgIdList(); // 0x05c13898
	System.Void OnExitWorld(); // 0x05c13be0
	System.Void OnCleanUp(); // 0x05c13d30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComHUDWeaponItemIcon : WizardGames.Soc.SocClient.Ui.ComItemIcon
{
	FairyGUI.GLoader iconAmmo; // 0x508
	FairyGUI.GList listParts; // 0x510
	FairyGUI.GTextField textName; // 0x518
	FairyGUI.GTextField textNum; // 0x520
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComHUDWeaponItemIcon.PartIconInfo> partInfos; // 0x528
	FairyGUI.Controller ctrlAmmoInfo; // 0x530
	System.Boolean isHasAmmoItem; // 0x538
	System.Int32 curAmmoId; // 0x53c
	System.Int32 curAmmoNum; // 0x540
	System.Int32 curAmmoInventoryNum; // 0x544
	System.Int32 numChangeSign; // 0x548
	System.Void OnInit(); // 0x05c14024
	System.Void InitItemWidgets(); // 0x05c143c0
	System.Void SetAmmoInfo(WizardGames.Soc.Common.CustomType.BaseItemNode instItem); // 0x05c14420
	System.Void SetInstData(WizardGames.Soc.Common.CustomType.BaseItemNode instItem, System.Boolean showIconOnly); // 0x05c147b4
	System.Void SetTepmlateData(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg, System.Boolean showIconOnly); // 0x05c14d74
	System.String GetItemIconUrl(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg, WizardGames.Soc.Common.Data.DataItem.SkinConfig skinCfg); // 0x05c14e90
	System.Void SetValue(); // 0x05c14f54
	System.Void SetPartsList(); // 0x05c14954
	System.Boolean SetEmpty(System.Boolean force); // 0x05c151b0
	System.Void SetAmmoIcon(); // 0x05c145a8
	System.Void RefreshAmmo(); // 0x05c15238
	System.Void ForceRefInventoryAmmoNum(System.Int64 checkAmmoId, System.Boolean localFirst); // 0x05c1533c
	System.Void .ctor(); // 0x05c155ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComHUDWeaponItemIcon.PartIconInfo : System.Object
{
	FairyGUI.GComponent comRoot; // 0x10
	FairyGUI.Controller ctrlStyle; // 0x18
	System.Void .ctor(); // 0x05c15b10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemShortcuts : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	WizardGames.Soc.SocClient.Ui.UiHudElemWeapons elemWeapons; // 0x190
	WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsBelt beltContainer; // 0x198
	System.Boolean needRefresh; // 0x1a0
	System.Single refreshCountDown; // 0x1a4
	FairyGUI.GList list; // 0x1a8
	static System.Boolean MarkRefreshOnNextInventoryUpdate; // 0x0
	FairyGUI.GObject tipsTargetPos; // 0x1b0
	WizardGames.Soc.SocClient.Manager.EResponseLevel <ResposeLevel>k__BackingField; // 0x1b8
	WizardGames.Soc.SocClient.Ui.UiHudElemWeapons get_Weapons(); // 0x05c15b78
	WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsBelt get_Belt(); // 0x05c15bdc
	FairyGUI.GObject get_TipsTargetPos(); // 0x05c15c40
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c15ca4
	WizardGames.Soc.SocClient.Manager.EResponseLevel get_ResposeLevel(); // 0x05c17094
	System.Void OnHotKeyAction(); // 0x05c170f8
	System.Void StartEdit(); // 0x05c17208
	System.Void OfflienSceneProcess(); // 0x05c163ec
	System.Void OnBoardEnable(); // 0x05c172bc
	System.Void OnEnable(); // 0x05c174b8
	System.Void OnDisable(); // 0x05c18cb0
	System.Void MarkToRefresh(); // 0x05c18f64
	System.Void OnAddOrRemoveItemNode(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05c18fcc
	System.Void OnInventoryUpdate(); // 0x05c1921c
	System.Void RefreshImmediately(); // 0x05c17354
	System.Void OnFps10Update(System.Single dt); // 0x05c19424
	System.Void OnFps30Update(System.Single dt); // 0x05c1973c
	System.Void OnUiDestroy(); // 0x05c198fc
	System.Void OnHudBlockElemChange(WizardGames.Soc.SocClient.Ui.UiHudElem curElem); // 0x05c1a158
	System.Void ExecuteShortcutByMode(System.Int32 index); // 0x05c1a28c
	static WizardGames.Soc.SocClient.Ui.UiHudElemShortcuts GetElemInst(); // 0x05c1a5f4
	System.Void OnShortcutsItemEntityChange(System.Int32 index); // 0x05c1a668
	static System.Void OnExecuteShortcut(System.Int32 index); // 0x05c1a858
	static WizardGames.Soc.Common.CustomType.BaseItemNode GetCurSelectItem(); // 0x05c1a8d0
	static System.Void RecordAndUnSelectCurPos(); // 0x05c1aa78
	static System.Void RefreshShortcuts(); // 0x05c1acfc
	System.Void OnClickItem(FairyGUI.EventContext context); // 0x05c1ad68
	static System.Void Record(System.Int32 index); // 0x05c1a4cc
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x05c1ae4c
	System.Void OnElemEditMoveBegin(FairyGUI.EventContext context); // 0x05c1aed4
	System.Void OnElemEditMoveEnd(FairyGUI.EventContext context); // 0x05c1b1e8
	System.Void SelectEffect(System.Boolean isOn); // 0x05c1b310
	System.Void CheckBubble(); // 0x05c1b4b4
	System.Void CheckBubble(System.Boolean playAnim); // 0x05c186c8
	System.Void HideBubble(); // 0x05c18dc8
	System.Void OnHudMakeFullScreen(); // 0x05c1b574
	System.Void .ctor(); // 0x05c1b640
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsBelt : WizardGames.Soc.SocClient.Ui.ClientContainerFixed
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.UiHudElemShortcuts root; // 0x78
	FairyGUI.GObject dragSafeArea; // 0x80
	FairyGUI.GButton btnMenuFolder; // 0x88
	FairyGUI.Controller ctrlBtnMenuArrowState; // 0x90
	FairyGUI.Controller ctrlMenuChooseSign; // 0x98
	FairyGUI.Controller ctrlBeltStyle; // 0xa0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.ComItemIcon> itemId2Icon; // 0xa8
	System.Single clickCDRemainT; // 0xb0
	static System.Int64 curSelectedUid; // 0x8
	System.Boolean isChooseReloadableWeapon; // 0xb4
	System.Single checkEntityRemainT; // 0xb8
	System.Int32 checkEntityFlag; // 0xbc
	System.Boolean stopUpdateWeaponInfo; // 0xc0
	System.Single fIconBottomEnableAlpha; // 0xc4
	WizardGames.Soc.SocClient.Ui.ComItemIcon toSelectOnShortcutsEntityChange; // 0xc8
	WizardGames.Soc.SocClient.Ui.ComItemIcon toSelectOnNextFrame; // 0xd0
	FairyGUI.GComponent comChooseMenuSign; // 0xd8
	FairyGUI.Controller ctrlChooseMenuSignStyle; // 0xe0
	WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsChooseMenu chooseMenu; // 0xe8
	FairyGUI.Controller ctrlSafeArea; // 0xf0
	FairyGUI.GComponent comDragTip; // 0xf8
	System.Single triggerAutoChooseMenuY; // 0x100
	System.Boolean isAutoOpenChooseMenu; // 0x104
	System.Int64 selectUidToRecover; // 0x108
	WizardGames.Soc.Common.CustomType.BaseItemNode curChangeItemNode; // 0x110
	WizardGames.Soc.SocClient.Ui.ComItemIcon <CurSelectedIcon>k__BackingField; // 0x118
	static System.Boolean SkipNotifyBattleSideOnce; // 0x10
	static System.Boolean SkipWeaponEquipRectify; // 0x11
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComItemIcon> clickExceptIcons; // 0x120
	System.Collections.Generic.List<FairyGUI.Controller> bottomIconChooseStyles; // 0x128
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsBelt.UseItemCD> useCDItems; // 0x130
	System.Collections.Generic.List<System.Int64> toRemoveUseCD; // 0x138
	static System.Boolean IsExitingFromBuild; // 0x12
	System.Boolean <isChooseMenuAtTop>k__BackingField; // 0x140
	WizardGames.Soc.Common.Data.ActionName[] hotKeys; // 0x148
	FairyGUI.GList list; // 0x150
	System.Boolean get_IsFolderUp(); // 0x05c1b6b0
	WizardGames.Soc.SocClient.Ui.ComItemIcon get_CurSelectedIcon(); // 0x05c1b770
	System.Void set_CurSelectedIcon(WizardGames.Soc.SocClient.Ui.ComItemIcon value); // 0x05c1b7d4
	WizardGames.Soc.Common.CustomType.BaseItemNode get_CurSelectItem(); // 0x05c1a948
	System.Boolean get_inMenuChoose(); // 0x05c1b854
	System.Int32 get_curMenuChooseIndex(); // 0x05c1b99c
	System.Boolean get_onlyMission(); // 0x05c1baa8
	System.Boolean get_isChooseMenuAtTop(); // 0x05c1bb0c
	System.Void set_isChooseMenuAtTop(System.Boolean value); // 0x05c1bb70
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiHudElemShortcuts rootElem); // 0x05c164d8
	System.Void BindList(); // 0x05c19320
	System.Void OnEnable(); // 0x05c17660
	System.Void OnMissionChanged(); // 0x05c1c834
	System.Void UsableChanged(System.Int64 tableId, System.Boolean newCanUse, EItemDisableReason Reason); // 0x05c1ca9c
	UnityEngine.Rect GetBlockArea(); // 0x05c1ccf0
	System.Void OnStartReload(); // 0x05c1ceb8
	System.Void OnReloadSetClip(System.Int32 ammoId); // 0x05c1cf18
	System.Void OnReloadCDFinished(); // 0x05c1cfb4
	System.Void OnDestory(); // 0x05c19d04
	System.Void CollectIcons(); // 0x05c1d188
	System.Boolean OnWheelHotKey(System.Int32 i); // 0x05c1d828
	System.Void AppendWeaponIcon(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05c1dc9c
	System.Void DealIconWhenCollect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05c1de1c
	System.Void OnClickDisaleIcon(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05c1e420
	System.Void OnItemDamaged(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05c1e9f4
	System.Boolean OnBottomBeltIconAcceptDrag(WizardGames.Soc.SocClient.Ui.ComItemIcon myItemIcon, WizardGames.Soc.Common.CustomType.BaseItemNode dropItem); // 0x05c1edc0
	System.Boolean OnBottomBeltIconAcceptDrag(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05c1f054
	System.Void SetCheckEntityFlag(System.Int32 index, System.Boolean on); // 0x05c1f1cc
	System.Boolean HasCheckEntityFlag(System.Int32 index); // 0x05c1f268
	static System.Boolean IsItemEnableInCurState(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05c1f2f0
	System.Void SetItemDatas(); // 0x05c1f3f4
	System.Void DealIconWhenSetData(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05c1f484
	System.Void ResetIconSelect(); // 0x05c1faac
	System.Void RecordIconSelect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05c1fcec
	WizardGames.Soc.Common.Entity.IHeldItemEntity GetItemHoldEntity(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x05c20038
	System.Void NotifyBattlesideItemSelect(WizardGames.Soc.Common.Utility.HoldItemIndex index, System.Boolean unload); // 0x05c20138
	System.Boolean DoItemUseImmediately(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x05c20384
	System.Void DoItemLogicOnStateChange(WizardGames.Soc.Common.CustomType.BaseItemNode item, System.Boolean state, WizardGames.Soc.Common.CustomType.BaseItemNode newSelectItem); // 0x05c20f28
	System.Boolean DoClickItemInternal(WizardGames.Soc.SocClient.Ui.ComItemIcon clickIcon); // 0x05c21048
	System.Boolean IsBuildHoldItem(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05c218a8
	System.Void AllIconsRelockUpdateAfterFrame(System.Int32 frame); // 0x05c219bc
	System.Void OnClickItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05c21b4c
	System.Void OnWeaponEquiped(System.Int64 oldWeaponId, System.Int64 weaponID); // 0x05c187d4
	System.Boolean IsIconShowReloadableWeapon(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05c1f97c
	System.Void UpdateHoldItemInfo(); // 0x05c1d018
	System.Void UpdateRemoteWeaponNum(); // 0x05c21c30
	System.Void UpdateItemUseCD(System.Single dt); // 0x05c21d80
	System.Void DoUpdateFps10(System.Single dt); // 0x05c19590
	System.Void DoUpdateFps30(System.Single dt); // 0x05c19854
	System.Void UpdateHoldItem(); // 0x05c22344
	System.Void OnShortcutsItemEntityChange(System.Int32 index); // 0x05c1a70c
	System.Void PrepareForAutoChoose(WizardGames.Soc.SocClient.Ui.ComItemIcon icon, WizardGames.Soc.Common.Data.DataItem.ItemOperationType opType); // 0x05c2267c
	System.Void PrepareForAutoChoose(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05c1ef24
	System.Void Refresh(); // 0x05c22774
	System.Void HandelIconSelectAfterRefresh(); // 0x05c228a0
	System.Void OnAddOrRemoveItemNode(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05c19148
	System.Boolean UnloadIfItemIsSelected(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x05c1ebe4
	System.Boolean UnloadCurrentSelectItem(); // 0x05c22f58
	System.Void SetChooseStyle(System.Boolean holdStateOnly); // 0x05c22fd8
	System.Void RefreshBtnMenuChooseShow(System.Boolean state); // 0x05c1c6d8
	System.Void SetChooseMenuState(System.Boolean state); // 0x05c23190
	System.Void OnDisable(); // 0x05c18ec4
	System.Void OnClickMenuFolder(); // 0x05c24060
	System.Boolean OnChooseMenuChooseItem(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Int32 chooseIndex); // 0x05c24120
	System.Void ResetMenuChooseData(); // 0x05c1bbec
	System.Void RecordAndUnSelectCurPos(); // 0x05c1aaec
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x05c24330
	System.Void SetIconLockStateIfLock(System.Boolean iconLock); // 0x05c1affc
	System.Void SetIconRootVisibleExceptFirst(System.Boolean visible); // 0x05c1c99c
	System.Void OnProactivelyExitBuildMode(); // 0x05c244ac
	System.Void OnMakeFullScreen(); // 0x05c2454c
	System.Void DoClickEmptyItem(WizardGames.Soc.SocClient.Ui.ComItemIcon clickIcon); // 0x05c21834
	System.Void SetWheelIndex(System.UInt32 index); // 0x05c21948
	System.Void OnHudBlockElemChange(WizardGames.Soc.SocClient.Ui.UiHudElem curElem, System.Boolean force); // 0x05c1a1ec
	System.Boolean DoClickItemChooseMenu(WizardGames.Soc.SocClient.Ui.ComItemIcon clickIcon); // 0x05c1e744
	System.Void ExecuteShortcut(System.Int32 index); // 0x05c1a314
	System.Int32 GetChooseMenuRowCount(); // 0x05c1c674
	System.Boolean DoClickItem(WizardGames.Soc.SocClient.Ui.ComItemIcon clickIcon, System.Boolean ignoreRootVisible); // 0x05c25140
	System.Void OnBottomBeltIconAcceptDrag_Platform(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05c1f150
	System.Void SetChooseMenuState_Platform(System.Boolean state); // 0x05c23f38
	System.Boolean TryClickItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05c1dab8
	System.Boolean OnBeltIconDragStart(WizardGames.Soc.SocClient.Ui.ItemDragInfo info, WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05c25598
	System.Void OnBeltIconDragEnd(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05c257bc
	System.Void OnIconDragging(System.Single x, System.Single y); // 0x05c25a8c
	static System.Void .cctor(); // 0x05c25ea4
	System.Boolean <SetChooseMenuState>b__115_0(); // 0x05c25f8c
	System.Void <SetChooseMenuState_Platform>b__135_0(); // 0x05c26010
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsBelt.UseItemCD : System.Object
{
	System.Single max; // 0x10
	System.Single cur; // 0x14
	System.Single get_Progress(); // 0x05c222dc
	System.Void .ctor(System.Single maxTime); // 0x05c20ea0
	System.Void Reset(System.Single maxTime); // 0x05c20e28
	System.Boolean Reduce(System.Single dt); // 0x05c22254
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsBelt.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsBelt.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__59_0; // 0x8
	static System.Action<System.Object> <>9__73_0; // 0x10
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMissionView> <>9__88_0; // 0x18
	static System.Void .cctor(); // 0x05c2607c
	System.Void .ctor(); // 0x05c260e0
	System.Void <.ctor>b__59_0(FairyGUI.EventContext context); // 0x05c26148
	System.Void <DealIconWhenCollect>b__73_0(System.Object ctx); // 0x05c261cc
	System.Void <DoItemUseImmediately>b__88_0(WizardGames.Soc.SocClient.Ui.UiMissionView win); // 0x05c26268
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsBelt.<>c__DisplayClass69_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon cacheIcon; // 0x10
	FairyGUI.GButton backTouch; // 0x18
	System.Int32 index; // 0x20
	WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsBelt <>4__this; // 0x28
	System.Void .ctor(); // 0x05c1d7c0
	System.Void <CollectIcons>b__0(); // 0x05c262f0
	System.Void <CollectIcons>b__1(); // 0x05c2636c
	System.Boolean <CollectIcons>b__2(); // 0x05c264d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsBelt.<>c__DisplayClass73_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsBelt <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x18
	System.Void .ctor(); // 0x05c1e3b8
	System.Boolean <DealIconWhenCollect>b__1(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x05c26540
	System.Void <DealIconWhenCollect>b__2(); // 0x05c265c8
	System.Void <DealIconWhenCollect>b__3(FairyGUI.EventContext ctx); // 0x05c26638
	System.Void <DealIconWhenCollect>b__4(FairyGUI.EventContext ctx); // 0x05c267e8
	System.Void <DealIconWhenCollect>b__5(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon, System.Boolean state); // 0x05c26870
	System.Void <DealIconWhenCollect>b__6(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05c26948
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsBelt.<>c__DisplayClass95_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsBelt <>4__this; // 0x10
	System.Int64 weaponID; // 0x18
	System.Boolean isNullHand; // 0x20
	System.Void .ctor(); // 0x05c21bc8
	System.Void <OnWeaponEquiped>b__0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05c26aa0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsChooseMenu : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.ComLazyLoader comRootLoader; // 0x10
	WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsChooseMenu.ComRootNodeRef nodeRef; // 0x18
	WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsBelt elemBelt; // 0x20
	System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Int32,System.Boolean> onChooseItem; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsChooseMenu.MenuItem> curItems; // 0x30
	System.Collections.Generic.HashSet<System.Int64> preItemRecord; // 0x38
	System.Collections.Generic.HashSet<System.Int64> curItemRecord; // 0x40
	System.Collections.Generic.Queue<WizardGames.Soc.Common.CustomType.BaseItemNode> newAddItems; // 0x48
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsChooseMenu.MenuItem> removedMenuItems; // 0x50
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsChooseMenu.MenuItem> emptyMenuItems; // 0x58
	System.Int32 curClickEmptyIconIndex; // 0x60
	System.Boolean canScroll; // 0x64
	System.Boolean enableUpdateLock; // 0x65
	System.Single contetnCenterX; // 0x68
	System.Int32 curSideFlag; // 0x6c
	WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsChooseMenu.MenuItem curChooseMenuItem; // 0x70
	System.Boolean canShowAutoScrollTrigger; // 0x78
	System.Boolean isAutoScrollTriggerVisible; // 0x79
	System.Single autoScrollStep; // 0x7c
	System.Single autoScrollFactor; // 0x80
	System.Single autoScrollTimer; // 0x84
	System.Single autoScrollTime; // 0x88
	System.Int32 <RowCount>k__BackingField; // 0x8c
	System.Int32 get_RowCount(); // 0x05c26de4
	System.Void set_RowCount(System.Int32 value); // 0x05c26e48
	System.Boolean get_Visible(); // 0x05c1b8c8
	System.Void set_Visible(System.Boolean value); // 0x05c23b30
	FairyGUI.GComponent get_Root(); // 0x05c26ec0
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsBelt elemBelt, WizardGames.Soc.SocClient.Ui.ComLazyLoader comRootLoader, System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Int32,System.Boolean> onChooseItem); // 0x05c1bc60
	System.Void OnRootCreate(FairyGUI.GComponent com); // 0x05c26fd8
	System.Void OnRootDestroy(); // 0x05c27e94
	System.Void RefreshContetnCenterX(); // 0x05c1c228
	FairyGUI.GObject ListIconsCustomPoolGet(System.String url); // 0x05c28008
	System.Void ListIconsCustomPoolReturn(FairyGUI.GObject obj); // 0x05c282cc
	System.Void RegisterAutoScrollTigger(FairyGUI.GComponent trigger); // 0x05c27bc4
	System.Void CheckAutoScrollTriggerState(); // 0x05c28568
	System.Void CheckAutoScroll(System.Single dt); // 0x05c28728
	System.Void ResetAutoScroll(); // 0x05c288a0
	System.Void SetAutoScrollTriggerEnable(System.Boolean enable); // 0x05c28904
	System.Void IconRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05c28a90
	System.Boolean OnMenuIconDragStart(WizardGames.Soc.SocClient.Ui.ItemDragInfo info, WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05c292a4
	System.Void OnMenuIconDragEnd(); // 0x05c29478
	System.Void DealIconWhenSetData(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05c28cac
	System.Void UnlockIfEnableLock(); // 0x05c295c0
	System.Void LockIfEnableLock(System.Int32 frame); // 0x05c293d0
	System.Boolean CallOnChooseItem(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Int32 position); // 0x05c2964c
	System.Boolean CallOnChooseItem(WizardGames.Soc.SocClient.Ui.ComItemIcon icon, System.Int32 position); // 0x05c296e4
	System.Void OnClickOrDropOnEmptyIcon(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05c29814
	System.Void OnClickIcon(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05c298dc
	System.Boolean OnIconAcceptDrag(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05c29a9c
	System.Boolean TrySwapWithMenuChoose(System.Int32 clickPos); // 0x05c2507c
	System.Void ReverseAndFlipItemList(System.Int32 maxEmptyCount); // 0x05c29c60
	System.Void SetEmpty(); // 0x05c23dd4
	System.Void SwipItemRecord(); // 0x05c2a108
	System.Int32 MenuItemComapre(WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsChooseMenu.MenuItem a, WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsChooseMenu.MenuItem b); // 0x05c2a1b4
	System.Void CollectOrModifyItemList(System.Boolean isFirstOpen); // 0x05c2a298
	System.Void SetData(System.Boolean isFirstOpen); // 0x05c23be4
	System.Void OnIconDragging(System.Single x, System.Single y); // 0x05c25ccc
	System.Void OnBeltAndMenuIconDragStart(); // 0x05c25754
	System.Void OnBeltAndMenuIconDragEnd(); // 0x05c259ec
	System.Void OnUdateItemNode(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05c22ed0
	System.Boolean OnIconAcceptDrag_Platform(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x05c29be0
	System.Void UiHudElemShortcutsChooseMenu_Plaform(FairyGUI.GComponent comRoot); // 0x05c27e20
	static System.Void .cctor(); // 0x05c2a9e4
	System.Boolean <OnRootCreate>b__38_0(); // 0x05c2aab8
	System.Void <OnRootCreate>b__38_1(); // 0x05c2ab24
	System.Void <OnRootCreate>b__38_2(); // 0x05c2aba0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsChooseMenu.MenuItem : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode ItemNode; // 0x10
	System.Int32 Index; // 0x18
	System.Boolean IsInvalid; // 0x1c
	System.Int64 get_ItemId(); // 0x05c2a968
	System.Void .ctor(System.Int32 index); // 0x05c2a06c
	System.Void .ctor(WizardGames.Soc.Common.CustomType.BaseItemNode item, System.Int32 index); // 0x05c29fcc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsChooseMenu.ComRootNodeRef : System.Object
{
	FairyGUI.GComponent comContent; // 0x10
	FairyGUI.Container contentContainer; // 0x18
	FairyGUI.GList listIcons; // 0x20
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.GameHud.ComMenuChooseItemBinder> iconBinders; // 0x28
	FairyGUI.GComponent objAutoScrollTop; // 0x30
	FairyGUI.GComponent objAutoScrollBottom; // 0x38
	WizardGames.Soc.SocClient.Ui.ComHudDropBar comDropbar; // 0x40
	FairyGUI.Controller dropbarPosCtrl; // 0x48
	FairyGUI.Controller dragTitleCtrl; // 0x50
	System.Void Release(); // 0x05c27f00
	System.Void .ctor(); // 0x05c26f24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsChooseMenu.<>c__DisplayClass43_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsChooseMenu <>4__this; // 0x10
	System.Boolean isDirectionUp; // 0x18
	FairyGUI.Controller triggerStyleCtrl; // 0x20
	System.Void .ctor(); // 0x05c28500
	System.Void <RegisterAutoScrollTigger>b__0(); // 0x05c2ac1c
	System.Void <RegisterAutoScrollTigger>b__1(); // 0x05c2accc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsChooseMenu.<>c__DisplayClass51_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsChooseMenu <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x18
	System.Void .ctor(); // 0x05c29558
	System.Void <DealIconWhenSetData>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon baseIcon); // 0x05c2ad68
	System.Void <DealIconWhenSetData>b__1(FairyGUI.EventContext ctx); // 0x05c2ae34
	System.Void <DealIconWhenSetData>b__2(FairyGUI.EventContext ctx); // 0x05c2aeb4
	System.Void <DealIconWhenSetData>b__3(FairyGUI.EventContext ctx); // 0x05c2af38
	System.Boolean <DealIconWhenSetData>b__4(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x05c2b020
	System.Void <DealIconWhenSetData>b__5(); // 0x05c2b0a8
	System.Void <DealIconWhenSetData>b__6(FairyGUI.EventContext ctx); // 0x05c2b114
	System.Void <DealIconWhenSetData>b__7(FairyGUI.EventContext ctx); // 0x05c2b2c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsChooseMenu.<>c__DisplayClass64_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsChooseMenu <>4__this; // 0x10
	System.Boolean isFirstOpen; // 0x18
	System.Void .ctor(); // 0x05c2a900
	System.Boolean <CollectOrModifyItemList>b__0(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05c2b34c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiComPhoneInfo : System.Object
{
	FairyGUI.GComponent comBattery; // 0x10
	FairyGUI.GComponent comWifi; // 0x18
	FairyGUI.Controller ctrlWifi; // 0x20
	FairyGUI.Controller batteryController; // 0x28
	FairyGUI.GImage imgBattery; // 0x30
	System.Int32 secTick; // 0x38
	WizardGames.Soc.Common.Unity.Utility.SocPing ping; // 0x40
	System.Void Init(FairyGUI.GComponent node); // 0x05c2b5d0
	System.Void SetBattery(); // 0x05c2b850
	System.Void SetNetWorkState(); // 0x05c2b9a0
	System.Void OnDestroy(); // 0x05c2bc5c
	System.Boolean CheckInfoUpdate(); // 0x05c2bcd4
	System.Void .ctor(); // 0x05c2beac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElectricWireInfo : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GButton elecWireColorBtn; // 0x190
	WizardGames.Soc.Common.Unity.Electric.WireColour curWireColor; // 0x198
	FairyGUI.GTextField txtWireDesc; // 0x1a0
	WizardGames.Soc.SocClient.Ui.UiHudElemWireColorPanel wireColorPanel; // 0x1a8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c2bf14
	System.Void OnEnable(); // 0x05c2c1c8
	System.Void OnDisable(); // 0x05c2c264
	FairyGUI.GComponent HudDefaultTouchNode(); // 0x05c2c318
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c2c3c0
	System.Void OnHotKeyAction(); // 0x05c2c424
	System.Void OnUiDestroy(); // 0x05c2c4a0
	System.Void OnClickWireColor(); // 0x05c2c630
	System.Void OnDefaultCableColorBySwitchSubMode(WizardGames.Soc.Common.Unity.Electric.WireColour color); // 0x05c2c788
	System.Void RefreshElecWireColor(WizardGames.Soc.Common.Unity.Electric.WireColour color); // 0x05c2c814
	System.Void .ctor(); // 0x05c2c9f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElectricWireModifyInfo : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GButton elecWireColorBtn; // 0x190
	WizardGames.Soc.Common.Unity.Electric.WireColour curWireColor; // 0x198
	FairyGUI.GTextField txtWireDesc; // 0x1a0
	WizardGames.Soc.SocClient.Ui.UiHudElemWireModifyColorPanel wireColorPanel; // 0x1a8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c2ca68
	System.Void OnEnable(); // 0x05c2cc1c
	System.Void OnDisable(); // 0x05c2ccb8
	FairyGUI.GComponent HudDefaultTouchNode(); // 0x05c2cd6c
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c2ce14
	System.Void OnHotKeyAction(); // 0x05c2ce78
	System.Void OnUiDestroy(); // 0x05c2cef4
	System.Void OnClickWireColor(); // 0x05c2cf74
	System.Void RefreshElecWireColor(WizardGames.Soc.Common.Unity.Electric.WireColour color); // 0x05c2d0cc
	System.Void .ctor(); // 0x05c2d284
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnAction : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	FairyGUI.Transition click01Tran; // 0x190
	FairyGUI.Transition click02Tran; // 0x198
	WizardGames.Soc.SocClient.Ui.UiRoulette uiRoulette; // 0x1a0
	System.Boolean open; // 0x1a8
	System.Boolean touching; // 0x1a9
	System.Int32 frameCount; // 0x1ac
	WizardGames.Soc.SocClient.Manager.HotKeyAction rouletteAction; // 0x1b0
	System.Int32 n; // 0x1b8
	System.Boolean longPressTrigger; // 0x1bc
	UnityEngine.Vector2 touchStartPos; // 0x1c0
	System.Single touchStartTime; // 0x1c8
	System.Boolean checkDistance; // 0x1cc
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c2d2f4
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c2d5ec
	System.Void OnHotKeyAction(); // 0x05c2d650
	System.Void OnLongPressBegin(FairyGUI.EventContext context); // 0x05c2db50
	System.Void PlayAnim(FairyGUI.Transition anim); // 0x05c2dbc4
	WizardGames.Soc.SocClient.Ui.UiRoulette OpenRoulette(System.Boolean joystick); // 0x05c2dcfc
	System.Void QuitPanel(); // 0x05c2f20c
	FairyGUI.GComponent HudDefaultTouchNode(); // 0x05c2f2fc
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.GroupData> GenData(System.Boolean joystick); // 0x05c2e1d8
	WizardGames.Soc.SocClient.Ui.OptionData MakeSprayOptionData(System.Int64 skinId); // 0x05c2f584
	WizardGames.Soc.SocClient.Ui.OptionData makeGestrueOptionData(System.Int64 skinId); // 0x05c2f3a4
	System.Void OnJoyStickTouchBegin(FairyGUI.EventContext context); // 0x05c2d8e8
	System.Void OnPressing(); // 0x05c2da60
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05c2f834
	System.Void OnJoyStickTouchMove(FairyGUI.EventContext context); // 0x05c2f8c8
	System.Void OnJoyStickTouchEnd(FairyGUI.EventContext context); // 0x05c2d7e4
	System.Void .ctor(); // 0x05c2fb64
	System.Void <PlayAnim>b__14_0(); // 0x05c2fbd4
	System.Void <OpenRoulette>b__16_0(); // 0x05c2fc40
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnAction.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHudElemBtnAction.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Manager.CommonSkinData> <>9__19_0; // 0x8
	static System.Void .cctor(); // 0x05c2fd08
	System.Void .ctor(); // 0x05c2fd6c
	System.Int32 <GenData>b__19_0(WizardGames.Soc.SocClient.Manager.CommonSkinData s1, WizardGames.Soc.SocClient.Manager.CommonSkinData s2); // 0x05c2fdd4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnAction.<>c__DisplayClass22_0 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.SprayConfig cfg; // 0x10
	System.Void .ctor(); // 0x05c2f764
	System.Void <MakeSprayOptionData>b__0(System.Int32 index); // 0x05c2fe68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnAction.<>c__DisplayClass23_0 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.GestureConfig cfg; // 0x10
	System.Void .ctor(); // 0x05c2f7cc
	System.Void <makeGestrueOptionData>b__0(System.Int32 index); // 0x05c2ff1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnAid : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	System.Int64 aidEntityId; // 0x190
	System.Boolean foreHide; // 0x198
	WizardGames.Soc.SocClient.Ui.Binder.GameHud.BtnHudAidBinder binder; // 0x1a0
	WizardGames.Soc.SocClient.Manager.HotKeyCenterGuideData guideData; // 0x1a8
	WizardGames.Soc.Common.Data.ActionName <HotKey>k__BackingField; // 0x1b0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c300c0
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c30204
	System.Void OnHotKeyAction(); // 0x05c30268
	System.Void OnDisable(); // 0x05c302ec
	System.Void OnUiDestroy(); // 0x05c303bc
	System.Void OnClick(); // 0x05c30458
	System.Void SetSelfAid(System.Boolean isSelf); // 0x05c30824
	System.Void SetVisible(System.Boolean visible, System.Int64 entityId); // 0x05c30bec
	System.Void .ctor(); // 0x05c30d94
	System.Void <OnClick>b__13_1(System.Int64 id, System.Object data, System.Boolean del); // 0x05c30e3c
	System.Void <OnClick>b__13_0(System.Int64 id, System.Object data, System.Boolean del); // 0x05c30ed0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnBag : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.Controller ctrlBag; // 0x190
	WizardGames.Soc.SocClient.Ui.ComRedDot reddot; // 0x198
	FairyGUI.GButton button; // 0x1a0
	WizardGames.Soc.SocClient.Manager.EResponseLevel <ResposeLevel>k__BackingField; // 0x1a8
	FairyGUI.GTextField title; // 0x1b0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c30f64
	WizardGames.Soc.SocClient.Manager.EResponseLevel get_ResposeLevel(); // 0x05c31374
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c313d8
	System.Void OnHotKeyAction(); // 0x05c3143c
	System.Void OnEnable(); // 0x05c3159c
	System.Void OnUiDestroy(); // 0x05c317c0
	System.Void OnBoardEnable(); // 0x05c31940
	System.Void OnClick(); // 0x05c31a14
	System.Void Forbid(System.Boolean forbidden); // 0x05c31b50
	System.Void StartEdit(); // 0x05c31c08
	System.Void InitComs(FairyGUI.GComponent node); // 0x05c312bc
	System.Void UpdateNumProgress(); // 0x05c31620
	System.Void .ctor(); // 0x05c31ccc
	System.Void <OnBoardEnable>b__12_0(System.Object obj); // 0x05c31d3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnCancelFire : WizardGames.Soc.SocClient.Ui.UiHudElemCustomHeldCtrl, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	FairyGUI.GTextField _textTitle; // 0x190
	FairyGUI.GButton _btn; // 0x198
	System.Boolean isBow; // 0x1a0
	System.Boolean isThrown; // 0x1a1
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c31dd0
	System.Void TouchBegin(); // 0x05c31f6c
	System.Void OnFps30Update(System.Single dt); // 0x05c323e4
	System.Void OnWeaponEquip(System.Int64 oldWeaponId, System.Int64 weaponID); // 0x05c326fc
	System.Void SetVisible(System.Boolean visible); // 0x05c3203c
	System.Boolean CheckHideEquip(System.Int64 weaponId, System.Int64 weaponTableId); // 0x05c32970
	System.Void .ctor(); // 0x05c329f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnChangeC4Mode : WizardGames.Soc.SocClient.Ui.UiHudElemCustomHeldCtrl
{
	FairyGUI.GButton btn; // 0x190
	FairyGUI.GTextField txt; // 0x198
	WizardGames.Soc.Common.CustomType.TimeBombNode timeBombNode; // 0x1a0
	WizardGames.Soc.Common.Entity.IHeldItemEntity heldItemEntity; // 0x1a8
	System.Int64 itemUid; // 0x1b0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c32a58
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c32d48
	System.Void OnHotKeyAction(); // 0x05c32dac
	System.Void Update(); // 0x05c32be8
	System.Void OnClick(); // 0x05c32e30
	System.Void OnEnable(); // 0x05c33090
	System.Void OnDisable(); // 0x05c33120
	System.Void OnWeaponEquip(System.Int64 oldWeaponId, System.Int64 weaponID); // 0x05c3320c
	System.Boolean CheckHideEquip(System.Int64 weaponId, System.Int64 weaponTableId); // 0x05c33568
	System.Void OnRFDetonationChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x05c335f0
	System.Void .ctor(); // 0x05c337e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnCraft : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GTextField textTimer; // 0x190
	FairyGUI.GComponent comTimer; // 0x198
	FairyGUI.Controller ctrlStyle; // 0x1a0
	FairyGUI.GLoader loaderIcon; // 0x1a8
	FairyGUI.Transition animCraft; // 0x1b0
	FairyGUI.GButton button; // 0x1b8
	System.Boolean isInCraft; // 0x1c0
	System.Int64 lastBpItemId; // 0x1c8
	System.Int64 lastItemCfgId; // 0x1d0
	System.Int32 lastItemType; // 0x1d8
	System.Int64 updateTimerId; // 0x1e0
	WizardGames.Soc.SocClient.Manager.EResponseLevel <ResposeLevel>k__BackingField; // 0x1e8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c3384c
	WizardGames.Soc.SocClient.Manager.EResponseLevel get_ResposeLevel(); // 0x05c33c00
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c33c64
	System.Void OnHotKeyAction(); // 0x05c33cc8
	System.Void StartEdit(); // 0x05c33e28
	System.Void CancelUpdateTimer(); // 0x05c33eec
	System.Void OnEnable(); // 0x05c33ff4
	System.Void OnDisable(); // 0x05c34420
	System.Void UpdateCraftStatus(); // 0x055049cc
	System.Void OnOneCrafrFinished(); // 0x05c34628
	System.Void DoFinishCraft(); // 0x05c34530
	System.Void UpdateCraftProgress(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05c346c0
	System.Void OnCraftQueueUpdate(); // 0x05c34cbc
	System.Void ShowIcon(System.Int64 itemId); // 0x05c34b68
	System.Void OnClick(); // 0x05c34de4
	System.Void InitComs(); // 0x05c33b40
	System.Void CheckVisible(); // 0x05c33ba0
	System.Void .ctor(); // 0x05c34eb4
	System.Void <OnUiCreate>b__13_0(FairyGUI.EventContext ctx); // 0x05c34f24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnDebugFly : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHud UiHud; // 0x10
	FairyGUI.GComponent node; // 0x18
	FairyGUI.GTextField playerIdTextField; // 0x20
	FairyGUI.GButton btnConfirm; // 0x28
	System.Void Init(FairyGUI.GComponent contentPanel, WizardGames.Soc.SocClient.Ui.UiHud uiHud); // 0x05c34f9c
	System.Void WindowVisible(System.Boolean visible); // 0x05c351fc
	System.Void .ctor(); // 0x05c352bc
	System.Void <Init>b__4_0(FairyGUI.EventContext ctx); // 0x05c35324
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnDown : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GButton btn; // 0x190
	System.Boolean btnEnable; // 0x198
	System.Single startTouchTime; // 0x19c
	System.Boolean isPress; // 0x1a0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c35424
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c355b8
	System.Void OnHotKeyAction(); // 0x05c3561c
	System.Void OnElemTouchBeginTurn(FairyGUI.EventContext context); // 0x05c356fc
	System.Void OnElemTouchEndTurn(FairyGUI.EventContext context); // 0x05c358a4
	System.Void .ctor(); // 0x05c35a0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnDrinkWater : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	FairyGUI.GImage imgCD; // 0x190
	System.Single cdRemain; // 0x198
	System.Single cdMax; // 0x19c
	FairyGUI.Controller ctrlBtn; // 0x1a0
	FairyGUI.GObject objDisable; // 0x1a8
	System.Boolean divingState; // 0x1b0
	static System.Action setCD; // 0x0
	FairyGUI.GButton btn; // 0x1b8
	WizardGames.Soc.Common.Data.ActionName <HotKey>k__BackingField; // 0x1c0
	System.Boolean get_IsInCD(); // 0x05c35d00
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c35d6c
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c36158
	System.Void OnHotKeyAction(); // 0x05c361bc
	System.Void OnUiDestroy(); // 0x05c36238
	System.Void SetState(System.Boolean isEnable); // 0x05c36078
	System.Void OnFps10Update(System.Single dt); // 0x05c362d0
	System.Void SetCDInternal(); // 0x05c3646c
	System.Void OnClick(); // 0x05c3658c
	System.Void OnClickDisable(); // 0x05c367ac
	System.Void .ctor(); // 0x05c368d0
	System.Void <OnUiCreate>b__10_0(FairyGUI.EventContext ctx); // 0x05c36940
	System.Void <OnUiCreate>b__10_1(FairyGUI.EventContext ctx); // 0x05c369b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnHoldMicro : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	FairyGUI.Controller volumeControl; // 0x190
	System.Int32 preVolumeControl; // 0x198
	static System.Int32 MaxVolume; // 0x0
	FairyGUI.GButton btn; // 0x1a0
	FairyGUI.Transition[] trans; // 0x1a8
	System.Single updateDtMs; // 0x1b0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c36a30
	System.Void OnVoiceBand(); // 0x05c36dd0
	System.Void OnVoice(FairyGUI.EventContext context); // 0x05523a54
	System.Void OnTouchEnd(FairyGUI.EventContext context); // 0x05c37050
	System.Void UpdateMyMicVolume(); // 0x05c37248
	System.Void OnFps10Update(System.Single dt); // 0x05c375f4
	System.Void CloseVoice(); // 0x05c370c8
	System.Void OnShow(); // 0x05c3769c
	System.Void SetElemVisible(System.Boolean isVisible); // 0x05c36e38
	System.Void OnUiDestroy(); // 0x05c37780
	System.Void .ctor(); // 0x05c37884
	static System.Void .cctor(); // 0x05c3791c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnICStorage : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GButton btn; // 0x190
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c37968
	System.Void OnClick(); // 0x05c37ac4
	System.Void .ctor(); // 0x05c37b24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnLockMissile : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GButton btn; // 0x190
	FairyGUI.Controller lockCtrl; // 0x198
	FairyGUI.Transition fireEffect; // 0x1a0
	System.Boolean canFire; // 0x1a8
	WizardGames.Soc.Common.CustomType.WeaponCustom currentWeapon; // 0x1b0
	System.Collections.Generic.HashSet<System.Int64> weaponSubscribeIds; // 0x1b8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c37b8c
	System.Void OnUiDestroy(); // 0x05c37ef0
	System.Void CheckCurrentWeapon(); // 0x05c380e0
	System.Boolean OnShowCheck(); // 0x05c38460
	System.Void OnEnable(); // 0x05c384f8
	System.Void OnDisable(); // 0x05c3872c
	System.Void OnClipsChange(WizardGames.Soc.Share.Framework.CustomTypeBase weapon, System.Int32 oldValue, System.Int32 newValue); // 0x05c38844
	System.Void CheckLockStatus(System.Single progress); // 0x05c3861c
	System.Void LockEntityChange(System.Int64 id, System.Single progress); // 0x05c389a0
	System.Void OnClick(); // 0x05c38a30
	System.Void .ctor(); // 0x05c38b90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIHudElemBtnPossession : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	FairyGUI.GButton mainBtn; // 0x190
	System.Boolean isExitPossession; // 0x198
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c38c44
	System.Void OnClick(); // 0x05c38e44
	System.Void OnFps10Update(System.Single dt); // 0x05c38f6c
	System.Void .ctor(); // 0x05c39318
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	WizardGames.Soc.SocClient.Ui.Binder.GameHud.BtnQuickChatBinder binder; // 0x190
	FairyGUI.Controller btnController; // 0x198
	WizardGames.Soc.SocClient.Ui.ComQuickChat quickChatPanel; // 0x1a0
	WizardGames.Soc.SocClient.Ui.Binder.GameHud.ComQuickChatMsgListBinder binderMsgList; // 0x1a8
	FairyGUI.GList msgList; // 0x1b0
	FairyGUI.Transition msgFadeOut; // 0x1b8
	FairyGUI.Transition msgFadeIn; // 0x1c0
	System.UInt32 msgIndex; // 0x1c8
	System.Int64 fadeOutTimerId; // 0x1d0
	System.Boolean isMsgListShow; // 0x1d8
	static System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.QuickChatMessageClient> msgDatas; // 0x0
	FairyGUI.GImage imgCD; // 0x1e0
	System.Int32 sendCD; // 0x1e8
	System.Int32 sendNearByCD; // 0x1ec
	System.Boolean <isCD>k__BackingField; // 0x1f0
	System.Boolean <isNearbyCD>k__BackingField; // 0x1f1
	System.Int64 cdTimerId; // 0x1f8
	System.Int64 cdNearByTimeId; // 0x200
	WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat.ETabType tabType; // 0x208
	System.Boolean hasTeam; // 0x20c
	WizardGames.Soc.SocClient.Manager.EResponseLevel <ResposeLevel>k__BackingField; // 0x210
	System.Boolean get_isCD(); // 0x05c39380
	System.Void set_isCD(System.Boolean value); // 0x05c393e4
	System.Boolean get_isNearbyCD(); // 0x05c39460
	System.Void set_isNearbyCD(System.Boolean value); // 0x05c394c4
	WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat.ETabType get_TabType(); // 0x05c39540
	System.Void set_TabType(WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat.ETabType value); // 0x05c395a4
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c3971c
	System.Void OnUiDestroy(); // 0x05c3b278
	System.Void OnUiOpenEvent(WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase); // 0x05c3b6e0
	System.Void OnTeamMemberCleanUp(); // 0x05c3b7e0
	System.Void SwitchTab(); // 0x05c3b06c
	System.Void SetTabType(WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat.ETabType tabType); // 0x05c3b844
	System.Void ResetMsgIndex(); // 0x05c3a38c
	System.Void OnTeamMemberChange(WizardGames.Soc.Share.Framework.ECustomDictOpType arg1, System.UInt64 arg2, WizardGames.Soc.Common.CustomType.TeamMemberInfo arg3); // 0x05c3b8c0
	static System.Void ClearQuickChatMsgCache(); // 0x05c3b95c
	System.Void OnRenderMsgListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05c3ba04
	System.Int32 GetTeammateIndex(System.UInt64 roleId); // 0x05c3bf64
	System.Void ReceiveMessage(WizardGames.Soc.SocClient.Ui.QuickChatMessageClient message); // 0x05c3a50c
	System.Void OnChatDictChanged(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.UInt32 seq, WizardGames.Soc.Common.CustomType.QuickChatMessage oldMsg); // 0x05c3c25c
	System.Void RefreshMsgList(); // 0x05c3c1d8
	WizardGames.Soc.SocClient.Manager.EResponseLevel get_ResposeLevel(); // 0x05c3c550
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c3c5b4
	System.Void OnHotKeyAction(); // 0x05c3c618
	System.Void OnEnable(); // 0x05c3c730
	System.Void OnDisable(); // 0x05c3c7c0
	System.Void StartEdit(); // 0x05c3c844
	System.Void SetCD(System.Single progress); // 0x05c39634
	System.Void OnClickBtnQuickChat(); // 0x05c3cb7c
	System.Void OnlyClosePanel(); // 0x05c3b758
	System.Void OnHudBlockElemChange(); // 0x05c3ce14
	System.Void ClosePanel(); // 0x05c3cd88
	System.Void SelectEffect(System.Boolean isOn); // 0x05c3ce78
	FairyGUI.GComponent HudDefaultTouchNode(); // 0x05c3cfc0
	System.Void InitMsgListPos(); // 0x05c3a24c
	System.Void InitQuickChatPanel(System.Boolean isEdit); // 0x05c3c984
	System.Void OpenPanel(); // 0x05c3ccb8
	System.Void OnQuickTeamChatSendSuccess(); // 0x055049cc
	System.Void OnQuickNearbyChatSendSuccess(); // 0x055049cc
	System.Void .ctor(); // 0x05c3d698
	static System.Void .cctor(); // 0x05c3d808
	System.Void <ResetMsgIndex>b__37_0(System.UInt32 key); // 0x05c3d8a4
	System.Void <ReceiveMessage>b__42_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x05c3d928
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat.ETabType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat.ETabType None = -1;
	static WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat.ETabType Battle = 0;
	static WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat.ETabType Nearby = 1;
	static WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat.ETabType Max = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat.<>c <>9; // 0x0
	static FairyGUI.ListItemProvider <>9__31_0; // 0x8
	static System.Comparison<WizardGames.Soc.Common.CustomType.TeamMemberInfo> <>9__41_0; // 0x10
	static System.Void .cctor(); // 0x05c3d9e0
	System.Void .ctor(); // 0x05c3da44
	System.String <OnUiCreate>b__31_0(System.Int32 i); // 0x05c3daac
	System.Int32 <GetTeammateIndex>b__41_0(WizardGames.Soc.Common.CustomType.TeamMemberInfo p1, WizardGames.Soc.Common.CustomType.TeamMemberInfo p2); // 0x05c3db38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat.<>c__DisplayClass43_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat <>4__this; // 0x10
	WizardGames.Soc.Common.CustomType.QuickChatMessage chatMsg; // 0x18
	System.Void .ctor(); // 0x05c3c4e8
	System.Void <OnChatDictChanged>b__0(); // 0x05c3dca8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat.<>c__DisplayClass64_0 : System.Object
{
	System.Int32 remaindTime; // 0x10
	System.Int32 interval; // 0x14
	WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat <>4__this; // 0x18
	System.Void .ctor(); // 0x05c3d310
	System.Void <OnQuickTeamChatSendSuccess>b__0(System.Int64 id, System.Object data, System.Boolean delete); // 0x05c3ddf0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat.<>c__DisplayClass65_0 : System.Object
{
	System.Int32 remaindTime; // 0x10
	System.Int32 interval; // 0x14
	WizardGames.Soc.SocClient.Ui.UiHudElemBtnQuickChat <>4__this; // 0x18
	System.Void .ctor(); // 0x05c3d630
	System.Void <OnQuickNearbyChatSendSuccess>b__0(System.Int64 id, System.Object data, System.Boolean delete); // 0x05c3e01c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnRaise : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GButton btn; // 0x190
	System.Boolean btnEnable; // 0x198
	System.Single startTouchTime; // 0x19c
	System.Boolean isPress; // 0x1a0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c3e24c
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c3e3e0
	System.Void OnHotKeyAction(); // 0x05c3e444
	System.Void OnElemTouchBeginTurn(FairyGUI.EventContext context); // 0x05c3e524
	System.Void OnElemTouchEndTurn(FairyGUI.EventContext context); // 0x05c3e6cc
	System.Void .ctor(); // 0x05c3e834
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnReview : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GButton mainBtn; // 0x190
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c3e8a4
	System.Void OnClick(); // 0x05c3e9dc
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c3ebcc
	System.Void OnHotKeyAction(); // 0x05c3ec30
	System.Void DoReview(); // 0x05c3eb3c
	System.Void .ctor(); // 0x05c3ec94
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnRFRelated : WizardGames.Soc.SocClient.Ui.UIHudElemRFBtn
{
	FairyGUI.GButton btn; // 0x1a8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c3ecfc
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c3eeb4
	System.Void OnHotKeyAction(); // 0x05c3ef18
	System.Void OnClickRFRelated(System.Boolean select); // 0x05c3ef9c
	System.Void DisableState(); // 0x05c3f178
	System.Void OnDisable(); // 0x05c3f1f4
	System.Void OnWeaponEquip(System.Int64 oldWeaponId, System.Int64 weaponID); // 0x05c3f270
	System.Void .ctor(); // 0x05c3f378
	System.Void <OnUiCreate>b__1_0(FairyGUI.EventContext ctx); // 0x05c3f3e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnSetRF : WizardGames.Soc.SocClient.Ui.UIHudElemRFBtn
{
	FairyGUI.GButton btn; // 0x1a8
	WizardGames.Soc.Common.CustomType.TimeBombNode timeBombNode; // 0x1b0
	WizardGames.Soc.Common.CustomType.RFTransmitterNode transmitterNode; // 0x1b8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c3f4b0
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c3f6f4
	System.Void OnHotKeyAction(); // 0x05c3f758
	System.Void OnEnable(); // 0x05c3f7dc
	System.Void OnDisable(); // 0x05c3faa4
	System.Void OnCloseRFUi(); // 0x05c3fc04
	System.Void OnClickSetRF(); // 0x05c3fce0
	System.Void OnUiDestroy(); // 0x05c3fdac
	System.Void OnWeaponEquip(System.Int64 oldWeaponId, System.Int64 weaponID); // 0x05c3feb0
	System.Boolean CheckHideEquip(System.Int64 weaponId, System.Int64 weaponTableId); // 0x05c3ff44
	System.Void OnFrequencyChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x05c3ffd0
	System.Void .ctor(); // 0x05c4012c
	System.Void <OnUiCreate>b__3_0(FairyGUI.EventContext ctx); // 0x05c40194
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnSpeaker : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GButton _btnSpeaker; // 0x190
	FairyGUI.Transition click01Tran; // 0x198
	FairyGUI.Transition click02Tran; // 0x1a0
	WizardGames.Soc.SocClient.Ui.UiSpeaker uiSpeaker; // 0x1a8
	WizardGames.Soc.SocClient.Manager.EResponseLevel <ResposeLevel>k__BackingField; // 0x1b0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c4020c
	WizardGames.Soc.SocClient.Manager.EResponseLevel get_ResposeLevel(); // 0x05c4070c
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c40770
	System.Void OnHotKeyAction(); // 0x05c407d4
	System.Void OnUiDestroy(); // 0x05c40934
	System.Void InitIcon(); // 0x05c40610
	System.Void RetryJoinGlobalRoomSuccess(); // 0x05c40c10
	System.Void RetryJoinTeamRoomSuccess(); // 0x05c40ca4
	System.Void PlayAnim(FairyGUI.Transition anim); // 0x05c40d38
	System.Void ChangeIcon(System.Int32 index); // 0x05c40b3c
	System.Void QuitPanel(); // 0x05c40e70
	System.Void SelectEffect(System.Boolean isOn); // 0x05c40ef8
	System.Void mainBtnOnClick(); // 0x05c410d4
	System.Void .ctor(); // 0x05c41340
	System.Void <OnUiCreate>b__4_0(FairyGUI.EventContext ctx); // 0x05c413b0
	System.Void <PlayAnim>b__15_0(); // 0x05c41428
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnStartBuild : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	WizardGames.Soc.SocClient.Ui.UiHud hudBoard; // 0x190
	FairyGUI.Controller ctrlStyle; // 0x198
	FairyGUI.Controller ctrlIcon; // 0x1a0
	System.Int64 refreshIconTimer; // 0x1a8
	FairyGUI.GButton button; // 0x1b0
	System.Int64 buildDoorMissionId; // 0x1b8
	System.Int64 workbenchMissionId1; // 0x1c0
	System.Int64 workbenchMissionId2; // 0x1c8
	WizardGames.Soc.SocClient.Manager.EResponseLevel <ResposeLevel>k__BackingField; // 0x1d0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05523a54
	WizardGames.Soc.SocClient.Manager.EResponseLevel get_ResposeLevel(); // 0x0548ba98
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c41788
	System.Void OnHotKeyAction(); // 0x05c417ec
	System.Void OnDisable(); // 0x05c418d0
	System.Void CancelRefreshIconTimer(); // 0x05c41b40
	System.Void RefreshIconStyle(); // 0x05c41c48
	System.Void RefreshIconTimerCallback(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05c41dcc
	System.Void OnEnable(); // 0x055049cc
	System.Void OnShow(); // 0x05c42874
	System.Void OnHide(); // 0x05c428e4
	System.Void OnClick(); // 0x055049cc
	System.Void Forbid(System.Boolean forbidden); // 0x05c42700
	System.Boolean CanGuideState(System.String state); // 0x05c42dfc
	System.Void TriggerGuide(); // 0x05c41fcc
	System.Void StartEdit(); // 0x05c42ea0
	System.Void OnEnable_Platform(); // 0x05c42814
	System.Void .ctor(); // 0x055049cc
	System.Void <OnUiCreate>b__10_0(FairyGUI.EventContext ctx); // 0x05c42fe8
	System.Boolean <RefreshIconTimerCallback>b__20_0(); // 0x05c43060
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnTelescope : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	FairyGUI.GButton btn; // 0x190
	WizardGames.Soc.SocClient.Ui.UiHudElemBtnTelescopeMultiple btnTelescopeMultiple; // 0x198
	WizardGames.Soc.SocClient.Ui.UiHudElemBtnTelescopeDistance btnTelescopeDistance; // 0x1a0
	System.Int64 subscribeId; // 0x1a8
	WizardGames.Soc.Common.Data.ActionName <HotKey>k__BackingField; // 0x1b0
	static System.DateTime dtDisable; // 0x0
	System.Single curCameraFov; // 0x1b4
	static System.Int64 lastClickServerTimeMS; // 0x8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c430e4
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c436b8
	System.Void OnHotKeyAction(); // 0x05c4371c
	System.Void OnInteractiveChange(WizardGames.Soc.Share.Framework.CustomTypeBase self, System.Int32 oldValue, System.Int32 newValue); // 0x05c43b68
	System.Void UIHiddenDo(); // 0x05c43c48
	System.Void OnWeaponEquiped(System.Int64 oldWeaponId, System.Int64 weaponID); // 0x05c442a4
	System.Void OnEnable(); // 0x05c446c4
	System.Void OnDisable(); // 0x05c44738
	System.Void OnFps30Update(System.Single dt); // 0x05c44824
	System.Void SetBtnEnable(System.Boolean ena); // 0x05c43d48
	System.Void TelescopeOn(); // 0x05c449b8
	System.Void TelescopeOff(); // 0x05c44da4
	System.Void BtnClick(System.Boolean isOpen); // 0x05c4383c
	System.Void TeleScopeExtComRefresh(System.Boolean isOpen); // 0x05c44204
	System.Void TeleScopeStateChange(System.Boolean isOpen); // 0x05c44f2c
	System.Void OnUiDestroy(); // 0x05c44fb4
	System.Void CloseTelescope(); // 0x05c45330
	System.Void .ctor(); // 0x05c453b0
	static System.Void .cctor(); // 0x05c45424
	System.Void <OnUiCreate>b__4_0(); // 0x05c45498
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnTelescopeDistance : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	FairyGUI.GTextField txtDistance; // 0x190
	System.Int32 oldDistance; // 0x198
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c45554
	System.Void OnEnable(); // 0x05c4561c
	System.Void OnDisable(); // 0x05c45684
	System.Void OnFps30Update(System.Single dt); // 0x05c456f8
	System.Int32 GetDistanceValue(); // 0x05c457cc
	System.Void SetDistance(); // 0x05c44c6c
	System.Void TeleScopeStateChange(System.Boolean isOpen); // 0x05c44e9c
	System.Void .ctor(); // 0x05c45988
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnTelescopeMultiple : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.Transition transition; // 0x190
	FairyGUI.GButton btn; // 0x198
	FairyGUI.Container fguiContainer; // 0x1a0
	WizardGames.Soc.Common.Data.ActionName <HotKey>k__BackingField; // 0x1a8
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.UiHudElemBtnTelescopeMultiple.ERatioLevel> ratioLevels; // 0x1b0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c459f8
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c45e00
	System.Void OnHotKeyAction(); // 0x05c45e64
	System.Int64 get_heldItemEntityId(); // 0x05c45d5c
	System.Void OnEnable(); // 0x05c45ee0
	WizardGames.Soc.SocClient.Ui.UiHudElemBtnTelescopeMultiple.ERatioLevel GetRatioLevel(); // 0x05c45fc0
	WizardGames.Soc.SocClient.Ui.UiHudElemBtnTelescopeMultiple.ERatioLevel GetCurRatioLevel(); // 0x05c46104
	System.Void BtnClick(FairyGUI.EventContext ctx); // 0x05c461e0
	System.Void RefreshFov(System.Single duration); // 0x05c43e54
	System.Void TeleScopeStateChange(System.Boolean isOpen); // 0x05c44e0c
	System.Void .ctor(); // 0x05c4631c
	System.Void <OnEnable>b__10_0(); // 0x05c463d8
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiHudElemBtnTelescopeMultiple.ERatioLevel : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiHudElemBtnTelescopeMultiple.ERatioLevel x2 = 0;
	static WizardGames.Soc.SocClient.Ui.UiHudElemBtnTelescopeMultiple.ERatioLevel x4 = 1;
	static WizardGames.Soc.SocClient.Ui.UiHudElemBtnTelescopeMultiple.ERatioLevel x16 = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnUseCard : WizardGames.Soc.SocClient.Ui.UiHudElemCustomHeldCtrl
{
	FairyGUI.GButton btn; // 0x190
	System.Int64[] itemID; // 0x198
	static System.Boolean ListenUseCardAllowed; // 0x0
	System.Int64 lastResponseTime; // 0x1a0
	WizardGames.Soc.SocClient.Manager.EResponseLevel <ResposeLevel>k__BackingField; // 0x1a8
	WizardGames.Soc.SocClient.Manager.EResponseLevel get_ResposeLevel(); // 0x05c46444
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c464a8
	System.Void OnHotKeyAction(); // 0x05c4650c
	System.Void OnBoardInit(); // 0x05c465d0
	System.Void OnBoardDestroy(); // 0x05c46798
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c4693c
	System.Void OnUiDestroy(); // 0x05c46a74
	System.Void OnWeaponEquiped(System.Int64 oldWeaponId, System.Int64 weaponID); // 0x05c46adc
	System.Boolean CheckHideEquip(System.Int64 weaponId, System.Int64 weaponTableId); // 0x05c46c94
	System.Void BtnClick(); // 0x05c46d3c
	System.Void UseCardAllowed(); // 0x05c46ebc
	System.Void .ctor(); // 0x05c46f4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnWujiTurnLeft : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GButton btn; // 0x190
	System.Boolean isPress; // 0x198
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c47010
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c471a4
	System.Void OnHotKeyAction(); // 0x05c47208
	System.Void OnElemTouchBeginTurn(FairyGUI.EventContext context); // 0x05c472e8
	System.Void OnElemTouchEndTurn(FairyGUI.EventContext context); // 0x05c47484
	System.Void .ctor(); // 0x05c4753c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemBtnWujiTurnRight : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GButton btn; // 0x190
	System.Boolean isPress; // 0x198
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c475a4
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c47738
	System.Void OnHotKeyAction(); // 0x05c4779c
	System.Void OnElemTouchBeginTurn(FairyGUI.EventContext context); // 0x05c4787c
	System.Void OnElemTouchEndTurn(FairyGUI.EventContext context); // 0x05c47a18
	System.Void .ctor(); // 0x05c47ad0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemChat : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GRichTextField gTxtSingleMessage; // 0x190
	FairyGUI.GList gMessageList; // 0x198
	WizardGames.Soc.SocClient.Ui.ComRedDot redDot; // 0x1a0
	FairyGUI.Controller ctrlIsNoMessage; // 0x1a8
	WizardGames.Soc.SocClient.Ui.KeyboardHandler keyboardHandler; // 0x1b0
	FairyGUI.GComponent btnChat; // 0x1b8
	FairyGUI.Controller iconVisibleCtrl; // 0x1c0
	System.String hudGenericMessage; // 0x1c8
	System.Boolean isChatWindowOpen; // 0x1d0
	System.Void .ctor(); // 0x05c47b38
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c47ba0
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c48c74
	WizardGames.Soc.SocClient.Manager.EResponseLevel get_ResposeLevel(); // 0x05c48cd8
	System.Void OnHotKeyAction(); // 0x05c48d3c
	System.Void RemoveListener(); // 0x05c491fc
	System.Void OnUiDestroy(); // 0x05c494e4
	System.Void StartEdit(); // 0x05c49554
	FairyGUI.GComponent GetBtnChatCom(); // 0x05c49630
	System.Void SetIconVisibleCtrl(System.Boolean isVisible); // 0x05c49694
	System.Void OnClick(System.String channelId); // 0x05c48da4
	System.Void OnCloseChatMain(); // 0x05c4972c
	System.Void RefreshMessage(); // 0x05c4891c
	System.Void RecvMessage(WizardGames.Soc.SocClient.ClientChatMessage msg); // 0x05c49988
	System.Void RefreshRedDot(); // 0x05c48764
	System.Void MessageItemRendererFunc(System.Int32 index, FairyGUI.GObject obj); // 0x05c49ab4
	System.Void SetText(WizardGames.Soc.SocClient.ClientChatMessage chatMessage, FairyGUI.GRichTextField txtField); // 0x05c49790
	System.Void SetNoMessage(System.Boolean isNoMessage); // 0x05c49900
	WizardGames.Soc.SocClient.Ui.ComRedDot GetRedDot(); // 0x05c4883c
	System.Void <OnUiCreate>b__14_0(); // 0x05c49d00
	System.Void <OnUiCreate>b__14_1(); // 0x05c49d68
	System.Void <OnClick>b__25_0(WizardGames.Soc.SocClient.Ui.UiChat uichat); // 0x05c49dd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemChat.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHudElemChat.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__14_2; // 0x8
	static FairyGUI.EventCallback1 <>9__14_3; // 0x10
	static System.Void .cctor(); // 0x05c4a1d4
	System.Void .ctor(); // 0x05c4a238
	System.Void <OnUiCreate>b__14_2(FairyGUI.EventContext context); // 0x05c4a2a0
	System.Void <OnUiCreate>b__14_3(FairyGUI.EventContext context); // 0x05c4a324
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemChat.<>c__DisplayClass25_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiChat uichat; // 0x10
	System.Void .ctor(); // 0x05c4a16c
	System.Void <OnClick>b__1(System.Int64 _, System.Object _, System.Boolean _); // 0x05c4a3a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemClearWirePoint : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GButton mainBtn; // 0x190
	FairyGUI.GTextField textPointCount; // 0x198
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c4a580
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c4a6f8
	System.Void OnHotKeyAction(); // 0x05c4a75c
	System.Void OnEnable(); // 0x05c4a7d8
	System.Void OnDisable(); // 0x05c4a874
	System.Void Show(System.Int32 count); // 0x05c4a910
	System.Void OnClick(); // 0x05c4abf4
	System.Void .ctor(); // 0x05c4ae88
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.CombatMarkerOperateType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.CombatMarkerOperateType None = 0;
	static WizardGames.Soc.SocClient.Ui.CombatMarkerOperateType ForbidRemoveSelfCreated = 1;
	static WizardGames.Soc.SocClient.Ui.CombatMarkerOperateType RemoveSelfCreated = 2;
	static WizardGames.Soc.SocClient.Ui.CombatMarkerOperateType CancelConfirmTeam = 3;
	static WizardGames.Soc.SocClient.Ui.CombatMarkerOperateType ConfirmTeam = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemCombatMarker : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	WizardGames.Soc.SocClient.Ui.Binder.GameHud.ElemCombatMarkerBinder binder; // 0x190
	FairyGUI.Transition changeTransition; // 0x198
	System.Boolean IsLongPressing; // 0x1a0
	System.Single tick; // 0x1a4
	UnityEngine.Vector2 screenCenterPos; // 0x1a8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.HudCombatMarker> combatMarkers; // 0x1b0
	System.Single longPressEndTime; // 0x1b8
	System.Int64 curAimMarkerId; // 0x1c0
	System.Int64 curAimEntityId; // 0x1c8
	WizardGames.Soc.SocClient.Ui.UiRoulette uiRoulette; // 0x1d0
	System.Boolean longPressTrigger; // 0x1d8
	UnityEngine.Vector2 touchStartPos; // 0x1dc
	System.Single touchStartTime; // 0x1e4
	System.Boolean open; // 0x1e8
	System.Boolean touching; // 0x1e9
	System.Boolean checkDistance; // 0x1ea
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c4aef0
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c4b5cc
	System.Void OnHotKeyAction(); // 0x05c4b630
	System.Void OnEnable(); // 0x05c4bb2c
	System.Void StartEdit(); // 0x05c4bc8c
	System.Void OnUiDestroy(); // 0x05c4bda8
	System.Void AddCombatMarker(WizardGames.Soc.SocClient.Marker.HudCombatMarker marker); // 0x05c4bfc0
	System.Void RemoveCombatMarker(WizardGames.Soc.SocClient.Marker.HudCombatMarker marker); // 0x05c4c0b4
	WizardGames.Soc.SocClient.Marker.IMarker GetMarkerByEntityId(System.Int64 id); // 0x05c4c150
	WizardGames.Soc.SocClient.Marker.IMarker GetMarkerByMarkerId(System.Int64 id); // 0x05c4c308
	WizardGames.Soc.SocClient.Marker.IMarker GetNearestHudMarkerByCenter(); // 0x05c4c4a8
	System.Single GetDistanceToScreenCenter(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x05c4c6a0
	System.Void OnClick(); // 0x05c4c8f8
	System.Void SetBtnUrl(System.String url, WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x05c4cc78
	System.String GetBtnUrlByMarker(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x05c4cf40
	System.Void SetBtnStateByEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05c4d088
	System.Void SetBtnStateByMarker(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x05c4d190
	WizardGames.Soc.Common.Entity.IEntity GetAimEntity(); // 0x05c4d21c
	System.Void UpdateBtnStyle(); // 0x05c4b2d4
	System.Void OnFps10Update(System.Single dt); // 0x05c4d420
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05c4d504
	System.Void OnJoyStickTouchBegin(FairyGUI.EventContext context); // 0x05c4b8c4
	System.Void OnPressing(); // 0x05c4ba3c
	WizardGames.Soc.SocClient.Ui.UiRoulette OpenRoulette(System.Boolean joystick); // 0x05c4d834
	System.Void QuitPanel(); // 0x05c4e33c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.GroupData> GenData(System.Boolean joystick); // 0x05c4dbbc
	FairyGUI.GComponent HudDefaultTouchNode(); // 0x05c4e3dc
	System.Void OnJoyStickTouchEnd(FairyGUI.EventContext context); // 0x05c4b7c4
	System.Void OnJoyStickTouchMove(FairyGUI.EventContext context); // 0x05c4d598
	System.Void .ctor(); // 0x05c4e494
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemCombatMarker.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHudElemCombatMarker.<>c <>9; // 0x0
	static System.Action<System.Int32> <>9__42_0; // 0x8
	static System.Action<System.Int32> <>9__42_1; // 0x10
	static System.Action<System.Int32> <>9__42_2; // 0x18
	static System.Action<System.Int32> <>9__42_3; // 0x20
	static System.Void .cctor(); // 0x05c4e598
	System.Void .ctor(); // 0x05c4e5fc
	System.Void <GenData>b__42_0(System.Int32 index); // 0x05c4e664
	System.Void <GenData>b__42_1(System.Int32 index); // 0x05c4e718
	System.Void <GenData>b__42_2(System.Int32 index); // 0x05c4e7cc
	System.Void <GenData>b__42_3(System.Int32 index); // 0x05c4e880
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemControlView : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	UnityEngine.Vector2 lastTouchPos; // 0x190
	UnityEngine.Vector2 targetPos; // 0x198
	UnityEngine.Vector2 initCenterPos; // 0x1a0
	FairyGUI.GButton mainBtn; // 0x1a8
	System.Single _dt; // 0x1b0
	System.Boolean IsFirstInMove; // 0x1b4
	System.Boolean canControlView; // 0x1b5
	System.Boolean isOpenDragEffect; // 0x1b6
	System.Boolean get_CanControlView(); // 0x05c4e934
	System.Void set_CanControlView(System.Boolean value); // 0x05c4e998
	System.Boolean get_IsOpenDragEffect(); // 0x05c4ea14
	System.Void set_IsOpenDragEffect(System.Boolean value); // 0x05c4ea78
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c4eaf4
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05c4edcc
	System.Void TouchBegin(FairyGUI.EventContext context); // 0x05c4eff0
	System.Void TouchMove(FairyGUI.EventContext context); // 0x05c4f148
	System.Void TouchEnd(FairyGUI.EventContext context); // 0x05c4f708
	System.Void OnTouchEnd(); // 0x05c4f78c
	System.Void RollOut(FairyGUI.EventContext context); // 0x05c4f938
	System.Void UpdateTouchPos(UnityEngine.Vector2 mousePos); // 0x05c4f3d8
	System.Void SwitchIcon(System.String iconPath); // 0x05c4f9ac
	System.Void .ctor(); // 0x05c4faa0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemCountDown : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	WizardGames.Soc.SocClient.Ui.ComCountdown comCountdown; // 0x190
	WizardGames.Soc.SocClient.Ui.Binder.GameHud.HudCountDownBinder binder; // 0x198
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c4fb50
	System.Void SetCountdown(System.Int32 ms, System.String tips, FairyGUI.EventCallback0 onFinish, FairyGUI.EventCallback0 onClickCancel, FairyGUI.EventCallback0 onAbort, System.String iconUrl, System.Boolean autoHideWhenCancel); // 0x05c4fdf4
	System.Void AbortCountDown(); // 0x05c4fefc
	System.Void StartEdit(); // 0x05c4ff74
	System.Void OnShow(); // 0x05c50100
	System.Void OnHide(); // 0x05c50184
	System.Void .ctor(); // 0x05c50208
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemCrouch : WizardGames.Soc.SocClient.Ui.UiHudElemControlView, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate_Input
{
	System.Boolean isPress; // 0x1b7
	FairyGUI.Controller ctrlMainBtn; // 0x1b8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05523a54
	System.Void OnUiDestroy(); // 0x055049cc
	System.Void OnTouchThroughSettingChanged(); // 0x05c50460
	System.Void TouchBegin(FairyGUI.EventContext context); // 0x05c507ac
	System.Void TouchEnd(FairyGUI.EventContext context); // 0x05c50878
	System.Void OnFpsUnlimitedUpdate_Input(System.Single dt); // 0x05c508fc
	System.Void PlayerStateChange(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Entity.PlayerPoseStateEnum lastState, WizardGames.Soc.Common.Entity.PlayerPoseStateEnum curState); // 0x05c509e4
	System.Void ChangeSelected(System.Boolean isCrouch); // 0x05c50b30
	System.Void OnShow(); // 0x05c50bc8
	System.Void .ctor(); // 0x05c50c90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemDirection : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	System.String normalizedNodePathMain; // 0x190
	System.String normalizedNodePathNormal; // 0x198
	FairyGUI.GObjectPool goPool; // 0x1a0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiHudElemDirection.DirInfo> directions; // 0x1a8
	System.Collections.Generic.Dictionary<FairyGUI.GComponent,System.Collections.Generic.KeyValuePair<FairyGUI.GLabel,System.Boolean>> node2InfoComs; // 0x1b0
	FairyGUI.GList list; // 0x1b8
	FairyGUI.GTextField centerPoint; // 0x1c0
	FairyGUI.GTextField centerPoint2; // 0x1c8
	System.Int32 distance; // 0x1d0
	System.Single offset; // 0x1d4
	UnityEngine.Transform cameraTransform; // 0x1d8
	FairyGUI.GImage mainIcon; // 0x1e0
	System.String[] mainNode; // 0x1e8
	System.Collections.Generic.Dictionary<System.Int32,System.String> yawNode; // 0x1f0
	WizardGames.Soc.SocClient.Marker.HudDirectionStage hudDirectionStage; // 0x1f8
	FairyGUI.Controller valueTypeCtrl; // 0x200
	System.Single preYaw; // 0x208
	System.Int32 preCenterPointYaw; // 0x20c
	System.Void OnShow(); // 0x05c50cf4
	System.Void OnHide(); // 0x05c50da0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c50e48
	System.Void OnUiDestroy(); // 0x05c51bc4
	System.Void OnEnable(); // 0x05c51ce4
	System.Void OnDisable(); // 0x05c51d60
	System.Void OnHudMakeFullScreen(); // 0x05c51ddc
	System.Void Update(); // 0x05c51e48
	System.Void OnRenderItem(System.Int32 index, FairyGUI.GObject obj); // 0x05c523bc
	System.Void OnFps30Update(System.Single dt); // 0x05c526f0
	System.Void .ctor(); // 0x05c52768
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemDirection.DirInfo : System.Object
{
	System.String title; // 0x10
	System.Boolean isMain; // 0x18
	System.Void .ctor(); // 0x05c51b38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemDown : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate_Input, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	System.Boolean _isPressed; // 0x190
	FairyGUI.GButton _mainBtn; // 0x198
	FairyGUI.GObject _objDarkCover; // 0x1a0
	System.Int32 _lastSwimPosType; // 0x1a8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c52aa0
	System.Boolean OnShowCheck(); // 0x05c52c70
	System.Void TouchBegin(FairyGUI.EventContext context); // 0x05c52d24
	System.Void OnFpsUnlimitedUpdate_Input(System.Single dt); // 0x05c52de0
	System.Void OnFps10Update(System.Single dt); // 0x05c52eac
	System.Void RefreshSwimIcon(); // 0x05c52f94
	System.Void TouchEnd(FairyGUI.EventContext context); // 0x05c5319c
	System.Void .ctor(); // 0x05c53214
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemEntryList : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiHudElem> entries; // 0x190
	System.Collections.Generic.List<System.String> entriesNames; // 0x198
	FairyGUI.GButton btnFolder; // 0x1a0
	FairyGUI.Transition folderAnim; // 0x1a8
	FairyGUI.Transition unfolderAnim; // 0x1b0
	FairyGUI.GGroup mailRedTips; // 0x1b8
	System.Int32 guideStepId1; // 0x1c0
	System.Int32 guideStepId2; // 0x1c4
	System.Int32 guideId; // 0x1c8
	System.Void OnBoardInit(); // 0x05c53284
	System.Void OnEnable(); // 0x05c5356c
	System.Void OnDisable(); // 0x05c53c54
	System.Void OnHudBlockElemChange(WizardGames.Soc.SocClient.Ui.UiHudElem curElem); // 0x05c53da4
	System.Void HideEntryGroup(); // 0x05c53e74
	System.Boolean IsCenterConsoleShow(); // 0x05c53f94
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c54080
	System.Void TryTriggerGuide(); // 0x05c5399c
	System.Boolean TryStageTriggerGuide(); // 0x05c544b4
	System.Boolean IsValidStageGuide(); // 0x05c54904
	System.Void UpdateMailRedTips(System.Int32 _); // 0x05c53788
	System.Void UpdateCommonRedDots(); // 0x05c53900
	System.Void UpdateLock(System.Int32 _); // 0x05c54a38
	System.Void OnRefreshByOpenUIDying(); // 0x05c54ab8
	System.Void OnRefreshByCloseUIDying(); // 0x05c54b1c
	System.Void RefreshRedDot(); // 0x05c536e0
	System.Void OnUiDestroy(); // 0x05c54b80
	System.Void OnClickFolder(); // 0x05c54f34
	System.Void OnOpenEntryList(); // 0x05c54ff8
	System.Void StartEdit(); // 0x05c55080
	FairyGUI.GComponent HudDefaultTouchNode(); // 0x05c551fc
	System.Void SelectEffect(System.Boolean isOn); // 0x05c552bc
	System.Void PlaySurvivalEffect(); // 0x05c55368
	System.Void .ctor(); // 0x05c55460
	static System.Void .cctor(); // 0x05c55580
	System.Void <HideEntryGroup>b__14_0(); // 0x05c55654
	System.Void <PlaySurvivalEffect>b__32_0(); // 0x05c556c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemFlashLight : WizardGames.Soc.SocClient.Ui.UiHudElemControlView
{
	FairyGUI.Controller _switchCtrl; // 0x1b8
	FairyGUI.GButton _switchBtn; // 0x1c0
	WizardGames.Soc.Common.Syncronization.ELightSourceType get_lightSourceType(); // 0x05c55730
	System.Boolean get_IsSetSoundClick(); // 0x05c55794
	System.Boolean get_IsEnabled(); // 0x05c557f8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c5585c
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c55d38
	System.Void OnHotKeyAction(); // 0x05c55d9c
	System.Void SwitchOnOff(System.Boolean isOn); // 0x05c55e18
	System.Void OnClickListener(FairyGUI.EventContext context); // 0x05c55ea0
	System.Boolean OnShowCheck(); // 0x05c56304
	System.Void RefreshUIState(); // 0x05c55a48
	System.Void .ctor(); // 0x05c564ec
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.JoystickType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.JoystickType Fixed = 0;
	static WizardGames.Soc.SocClient.Ui.JoystickType Floating = 1;
	static WizardGames.Soc.SocClient.Ui.JoystickType Dynamic = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.MoveState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.MoveState Idle = 0;
	static WizardGames.Soc.SocClient.Ui.MoveState Run = 1;
	static WizardGames.Soc.SocClient.Ui.MoveState Sprint = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemJoystick : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	UnityEngine.Vector2 input; // 0x190
	System.Boolean sprintLock; // 0x198
	System.Boolean snapX; // 0x199
	System.Boolean snapY; // 0x19a
	System.Single exemptAngleUp; // 0x19c
	System.Single deadZone; // 0x1a0
	System.Single sensitivity; // 0x1a4
	System.Single sprintHotspotAng; // 0x1a8
	System.Single sprintHotspotHeight; // 0x1ac
	UnityEngine.Vector2 touchPadFixedPos; // 0x1b0
	UnityEngine.Vector2 touchPadHotspotFixedSize; // 0x1b8
	UnityEngine.Vector2 initCenterPos; // 0x1c0
	System.Int32 touchId; // 0x1c8
	WizardGames.Soc.SocClient.Ui.JoystickType <JoystickType>k__BackingField; // 0x1cc
	FairyGUI.GComponent touchPad; // 0x1d0
	FairyGUI.GImage handle; // 0x1d8
	FairyGUI.GLoader handleBg2; // 0x1e0
	FairyGUI.GLoader horseState; // 0x1e8
	System.Single handleBgAlpha2; // 0x1f0
	FairyGUI.GComponent sprintHotspot; // 0x1f8
	FairyGUI.GComponent joystickHotspot; // 0x200
	FairyGUI.GComponent sprintLockCom; // 0x208
	WizardGames.Soc.SocClient.Ui.ComTouchArea ComTouchArea; // 0x210
	WizardGames.Soc.SocClient.Ui.ComTouchArea ComTouchArea2; // 0x218
	FairyGUI.GObject sprintLockBG; // 0x220
	FairyGUI.GObject preSprintBtn; // 0x228
	FairyGUI.GObject inSprintBtn; // 0x230
	WizardGames.Soc.Common.Data.ActionName inputVerticalDirect; // 0x238
	WizardGames.Soc.Common.Data.ActionName inputHorizontalDirect; // 0x23c
	WizardGames.Soc.SocClient.Ui.MoveState _moveState; // 0x240
	System.Single inputAngle; // 0x244
	System.Single joystickPercent; // 0x248
	System.Single runThreshold; // 0x24c
	System.Single horseRunThreshold; // 0x250
	System.Boolean isOriginPoint; // 0x254
	System.Boolean isSprintUILocked; // 0x255
	System.Boolean _isStartInForbidArea; // 0x256
	FairyGUI.Controller hotspotComModeCtrl; // 0x258
	FairyGUI.Controller sprintLockModeCtrl; // 0x260
	FairyGUI.Controller sprintLockShowModeCtrl; // 0x268
	FairyGUI.Controller sprintInOutCtrl; // 0x270
	FairyGUI.Controller sprintHorseTextCtrl; // 0x278
	System.Boolean IsHorseAutoRun; // 0x280
	System.Boolean _runlock; // 0x281
	System.Boolean IsTouching; // 0x282
	System.Boolean IsTouchEvent; // 0x283
	WizardGames.Soc.SocClient.Ui.Joystick.PlayerJoystick nowJoystick; // 0x288
	WizardGames.Soc.SocClient.Ui.Joystick.PlayerJoystick playerJoystick; // 0x290
	WizardGames.Soc.SocClient.Ui.Joystick.HorseJoystick horseJoystick; // 0x298
	FairyGUI.Transition newbieLevelShowAnim; // 0x2a0
	System.Boolean isNewbieLevelAnimFinished; // 0x2a8
	System.Boolean AutoRun; // 0x2a9
	FairyGUI.GComponent editComHotSpot; // 0x2b0
	FairyGUI.GGraph editArea; // 0x2b8
	System.Single editTopGap; // 0x2c0
	System.Single fixedX; // 0x2c4
	System.Single limitedYBottom; // 0x2c8
	System.Single limitedYTop; // 0x2cc
	System.Single editSetHeight; // 0x2d0
	FairyGUI.GComponent rootNode; // 0x2d8
	WizardGames.Soc.SocClient.Ui.JoystickType get_JoystickType(); // 0x05c56550
	System.Void set_JoystickType(WizardGames.Soc.SocClient.Ui.JoystickType value); // 0x05c565b4
	WizardGames.Soc.SocClient.Ui.MoveState get_moveState(); // 0x05c5662c
	System.Void set_moveState(WizardGames.Soc.SocClient.Ui.MoveState value); // 0x05c56690
	WizardGames.Soc.SocClient.Ui.UiMoveView get__moveView(); // 0x05c56708
	System.Boolean get_IsHorseDriver(); // 0x05c5677c
	System.Boolean get_IsHorseSprint(); // 0x05c56820
	System.Boolean get_runLock(); // 0x05c5689c
	System.Void set_runLock(System.Boolean value); // 0x05c56900
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05523a54
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c57ac8
	System.Void OnHotKeyAction(); // 0x05c57b2c
	System.Boolean OnShowCheck(); // 0x054c4760
	System.Void OnEnable(); // 0x055049cc
	System.Void SetStatus(WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus status, System.Boolean reset); // 0x05c589d8
	System.Void UpdateThreshold(); // 0x05c58d7c
	System.Void EnterHorseSprintState(); // 0x05c58e6c
	System.Void ExitHorseSprintStateIntoRun(System.Boolean isAutoRun); // 0x05c59158
	System.Void ExitHorseSprintState(); // 0x05c5970c
	System.Void onMountableChanged(System.Int64 entityId); // 0x05c599e4
	System.Void SetPlayerOrHorseMode(System.Boolean isPlayer); // 0x05c59c94
	System.Void CancelSprintMode(System.Single total, System.Action onComplete); // 0x05c59fa8
	System.Void OnFps30Update(System.Single dt); // 0x05c5a070
	System.Void UpdateHorseSprint(); // 0x05c5a0f0
	System.Boolean IsQuickStop(); // 0x05c5a2f0
	System.Void CancelSprintIntoRun(); // 0x05c59320
	System.Void EnterSprintMode(); // 0x05c582d8
	System.Void OnUiDestroy(); // 0x055049cc
	System.Void Interrupt(); // 0x05c5ad28
	System.Void SetTouchHotspotType(WizardGames.Soc.SocClient.Ui.JoystickType joystickType); // 0x05c579b0
	System.Void SwitchJoyStick(); // 0x05c59d38
	System.Void TouchBegin(FairyGUI.EventContext context); // 0x05523a54
	System.Void TouchReset(); // 0x055049cc
	System.Void TouchEnd(FairyGUI.EventContext context); // 0x05523a54
	System.Void SetSprintHotspot(System.Boolean visible, System.Boolean isHighlight, System.Boolean runOrSprint); // 0x05c59084
	System.Void RefreshSprintHotspot(System.Boolean visible); // 0x05c5b6f0
	System.Void RefreshSprintHotspotHighlight(System.Boolean isHighlight); // 0x05c5b778
	System.Void RefreshSprintHotspotHorseText(System.Boolean isHighlight); // 0x05c5b86c
	System.Void CancelSprintMode(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x05c59874
	System.Void Reset(System.Boolean cancelSprint); // 0x05c57bc8
	System.Void CollectTouchInput(UnityEngine.Vector2 touchPos); // 0x05c5b96c
	System.Void SetSprintState(System.Boolean lockSprint); // 0x05c5a3d8
	System.Void UpdateLock(); // 0x05c59dd4
	System.Void OnRunLockChanged(System.Boolean value); // 0x05c569a0
	System.Void SetSnapXYOn(System.Boolean isOn); // 0x05c5c474
	System.Void UpdateJoystickInputToMoveControl(); // 0x05c5a458
	System.Void TouchMove(FairyGUI.EventContext context); // 0x05523a54
	System.Void OnDisable(); // 0x055049cc
	System.Void Forbid(System.Boolean forbidden); // 0x05c5c900
	FairyGUI.GComponent HudDefaultTouchNode(); // 0x05c5ca24
	System.Void HandleInputPos(UnityEngine.Vector2 inputPos); // 0x05c5c010
	System.Void StartEdit(); // 0x05c5cacc
	System.Void RefreshEditStatus(); // 0x05c58acc
	System.Void OnEditAreaDragMove(FairyGUI.EventContext context); // 0x05c5ce10
	System.Void UpdateEditBoxSize(); // 0x05c5cdb0
	System.Single SafePositionAjustYMin(System.Single YMin); // 0x05c5d3d0
	System.Single GetMaxScaleFactor(); // 0x05c5d58c
	System.Void OnElemEditResize(); // 0x05c5d7d0
	System.Void SelectEffect(System.Boolean isOn); // 0x05c5dc68
	System.Void AttachScreenTouchArea(); // 0x05c5793c
	UnityEngine.Vector2 GetTouchBeginPos(FairyGUI.GComponent node, FairyGUI.EventContext context); // 0x05c5b0e8
	UnityEngine.Vector2 GetTouchMovePos(FairyGUI.EventContext context, FairyGUI.GComponent node); // 0x05c5c6e4
	System.Boolean BreakTouchEnd(FairyGUI.EventContext context); // 0x05c5b5bc
	System.Void .ctor(); // 0x05c5dd08
	System.Void <OnEnable>b__79_0(); // 0x05c5ddfc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemJump : WizardGames.Soc.SocClient.Ui.UiHudElemControlView, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	FairyGUI.GImage bg; // 0x1b8
	FairyGUI.GLoader icon; // 0x1c0
	System.Boolean isPress; // 0x1c8
	FairyGUI.Controller _slideCtrl; // 0x1d0
	FairyGUI.Controller iconCtrl; // 0x1d8
	UnityEngine.Vector2 _initCenterPos; // 0x1e0
	System.String _defaultUrl; // 0x1e8
	System.String _inAngleUrl; // 0x1f0
	System.String _outAngleUrl; // 0x1f8
	System.String _nowUrl; // 0x200
	WizardGames.Soc.SocClient.Ui.EParachuteState parachuteState; // 0x208
	WizardGames.Soc.SocClient.Ui.UiHud get_Hud(); // 0x05c5e1b4
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05523a54
	System.Void OnUiDestroy(); // 0x055049cc
	System.Void OnTouchThroughSettingChanged(); // 0x05c5e7a0
	System.Void OnShow(); // 0x05c5ecac
	System.Void TouchBegin(FairyGUI.EventContext context); // 0x05c5ef6c
	System.Void TouchMove(FairyGUI.EventContext context); // 0x05c5f274
	System.Void TouchEnd(FairyGUI.EventContext context); // 0x05c5f4dc
	System.Boolean IsParachuteCanOpen(); // 0x05c5eefc
	System.Void OnParachuteStateChange(WizardGames.Soc.SocClient.Ui.EParachuteState state, System.Int32 cdTime); // 0x05c5f688
	System.Void OnFps30Update(System.Single dt); // 0x05c5fa1c
	System.Void Forbid(System.Boolean forbidden); // 0x05c5f95c
	System.Void ChangeSelected(System.Boolean isOpen); // 0x05c5f808
	System.Void SwitchType(WizardGames.Soc.SocClient.Ui.MantleUiType uiType); // 0x05c5fafc
	System.Void OnLadderAngleOut(System.Int32 tag); // 0x05c5fb70
	System.Void .ctor(); // 0x05c5fc9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemKatyushaMissile : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GTextField mMissileNum; // 0x190
	FairyGUI.GButton mMissileBtn; // 0x198
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c5fd8c
	System.Boolean OnShowCheck(); // 0x05c60074
	System.Void UpdateMissileNum(); // 0x05c5ff98
	System.Void OnUiDestroy(); // 0x05c60188
	System.Void OnClickBtn(); // 0x05c6028c
	System.Void .ctor(); // 0x05c60420
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemKatyushaMissile.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHudElemKatyushaMissile.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiKatyusha> <>9__6_0; // 0x8
	static System.Void .cctor(); // 0x05c60488
	System.Void .ctor(); // 0x05c604ec
	System.Void <OnClickBtn>b__6_0(WizardGames.Soc.SocClient.Ui.UiKatyusha win); // 0x05c60554
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemLeftAttack : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	System.Boolean isFire; // 0x190
	FairyGUI.GButton mainBtn; // 0x198
	System.Int64 actionStateSubscribeId; // 0x1a0
	System.Boolean get_IsFire(); // 0x05c605dc
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c60640
	System.Void OnUiDestroy(); // 0x05c60e00
	System.Void OnDisable(); // 0x05c60f30
	System.Void OnActionStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x05c610ec
	System.Void UpdateAttackIcon(System.Int64 weaponId); // 0x05c611f4
	System.Void Fire1Begin(); // 0x05c61268
	System.Void Fire1End(); // 0x055049cc
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05c6136c
	System.Void SwitchIcon(System.String iconPath); // 0x05c61574
	System.Void FireCmd(); // 0x05c613fc
	System.Void OnWeaponSwitchSuccess(System.Int64 oldId, System.Int64 newId); // 0x05c60930
	System.Void .ctor(); // 0x05c61668
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemLittleEye : WizardGames.Soc.SocClient.Ui.UiHudElemControlView
{
	WizardGames.Soc.SocClient.Ui.UiHud _hudBoard; // 0x1b8
	FairyGUI.Controller _dragCtrl; // 0x1c0
	System.Single _cameraResetAngleV; // 0x1c8
	System.Single _headAngleV; // 0x1cc
	WizardGames.Soc.SocClient.Ui.ComTouchArea _comTouchArea; // 0x1d0
	System.Single _moveBeginTime; // 0x1d8
	System.Boolean _isFirstInMove; // 0x1dc
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c616d8
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c61d0c
	System.Void OnHotKeyAction(); // 0x05c61d70
	System.Void UpdateAngle(); // 0x05c61f20
	System.Void OnUiDestroy(); // 0x05c62078
	System.Void SelectEffect(System.Boolean isOn); // 0x05c62338
	System.Void TouchBegin(FairyGUI.EventContext context); // 0x05c6241c
	System.Void TouchMove(FairyGUI.EventContext context); // 0x05c62630
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05c628e8
	System.Void TouchEnd(FairyGUI.EventContext context); // 0x05c6295c
	System.Void Interrupt(); // 0x05c62a54
	System.Void OnApplicationFocusChanged(System.Boolean hasFocus); // 0x05c62ab8
	System.Void OnTouchEnd(); // 0x05c62b50
	System.Boolean OnShowCheck(); // 0x05c62c30
	System.Void OnWeaponSwitchSuccess(System.Int64 oldId, System.Int64 newId); // 0x05c62f18
	System.Void .ctor(); // 0x05c63000
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemLogo : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GLabel qualityText; // 0x190
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c63070
	System.Void OnUiDestroy(); // 0x05c63258
	System.Void OnQualityChanged(); // 0x05c6335c
	System.Void .ctor(); // 0x05c63464
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.MantleUiType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.MantleUiType Default = 0;
	static WizardGames.Soc.SocClient.Ui.MantleUiType InDependent = 1;
	static WizardGames.Soc.SocClient.Ui.MantleUiType Slide = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemMantle : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	FairyGUI.GButton mainBtn; // 0x190
	FairyGUI.GLoader icon; // 0x198
	FairyGUI.GComponent bg; // 0x1a0
	WizardGames.Soc.SocClient.Ui.UiHud get_hud(); // 0x05c634cc
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c63578
	System.Void OnUiDestroy(); // 0x05c638f0
	System.Boolean OnShowCheck(); // 0x05c63ac4
	System.Void OnDisable(); // 0x05c63ba8
	System.Void TouchBegin(FairyGUI.EventContext context); // 0x05c63c10
	System.Void TouchEnd(FairyGUI.EventContext context); // 0x05c63d08
	System.Void Forbid(System.Boolean forbidden); // 0x05c63dd0
	System.Void SwitchType(WizardGames.Soc.SocClient.Ui.MantleUiType uiType); // 0x05c63e90
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05513724
	System.Void .ctor(); // 0x05c64038
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemMap : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	SocLogger log; // 0x190
	WizardGames.Soc.SocClient.Ui.Map.MiniMap miniMap; // 0x198
	WizardGames.Soc.SocClient.Manager.HotKeyAction hotKeyAction; // 0x1a0
	FairyGUI.GTextField posTxt; // 0x1a8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c640a0
	System.Void OnEnable(); // 0x05c64588
	System.Void OnHotKey(); // 0x05c6468c
	System.Void OnDisable(); // 0x05c647fc
	System.Void OnUiDestroy(); // 0x05c64894
	System.Void StartEdit(); // 0x05c64914
	System.Void OnFps1Update(System.Single dt); // 0x05c649d8
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05c64ac0
	System.Void OnFps30Update(System.Single dt); // 0x05c64d70
	System.Void OnFps10Update(System.Single dt); // 0x05c64e40
	System.Void .ctor(); // 0x05c64f10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemMap.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHudElemMap.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__5_0; // 0x8
	static System.Void .cctor(); // 0x05c65008
	System.Void .ctor(); // 0x05c6506c
	System.Void <OnUiCreate>b__5_0(FairyGUI.EventContext ctx); // 0x05c650d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemMinerHat : WizardGames.Soc.SocClient.Ui.UiHudElemFlashLight
{
	
	WizardGames.Soc.Common.Syncronization.ELightSourceType get_lightSourceType(); // 0x05c65184
	System.Boolean get_IsSetSoundClick(); // 0x05c651e8
	System.Boolean get_IsEnabled(); // 0x05c6524c
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c653b0
	System.Void OnShow(); // 0x05c65414
	System.Void OnEnable(); // 0x05c65664
	System.Void OnDisable(); // 0x05c656fc
	System.Void .ctor(); // 0x05c65794
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemLaser : WizardGames.Soc.SocClient.Ui.UiHudElemFlashLight
{
	
	WizardGames.Soc.Common.Syncronization.ELightSourceType get_lightSourceType(); // 0x05c657fc
	System.Void OnEnable(); // 0x05c65860
	System.Void OnDisable(); // 0x05c658f8
	System.Void .ctor(); // 0x05c65990
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemMyThrownTip : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	WizardGames.Soc.SocClient.Ui.ThrownTipData _showUiData; // 0x190
	FairyGUI.GImage _imgCircle; // 0x198
	FairyGUI.GLoader _loaderIcon; // 0x1a0
	FairyGUI.GTextField _textTime; // 0x1a8
	System.Int32 _duration; // 0x1b0
	System.Void OnBoardInit(); // 0x05c659f8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c65ab8
	System.Void OnUiDestroy(); // 0x05c65dd0
	System.Boolean OnShowCheck(); // 0x05c65e3c
	System.Void OnShow(); // 0x05c65fc4
	System.Void OnFps10Update(System.Single dt); // 0x05c66034
	System.Void RefreshUI(); // 0x05c65c08
	System.Void SetShowUiData(WizardGames.Soc.SocClient.Ui.ThrownTipData data); // 0x05c6631c
	System.Void RemoveShowUiData(WizardGames.Soc.SocClient.Ui.ThrownTipData data); // 0x05c663fc
	System.Void .ctor(); // 0x05c66490
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemNightVersion : WizardGames.Soc.SocClient.Ui.UiHudElemControlView
{
	FairyGUI.Controller _switchCtrl; // 0x1b8
	FairyGUI.GButton _switchBtn; // 0x1c0
	WizardGames.Soc.Common.Data.ActionName <HotKey>k__BackingField; // 0x1c8
	System.Boolean get_isEnabled(); // 0x05c664f8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c6665c
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c66a74
	System.Void OnHotKeyAction(); // 0x05c66ad8
	System.Void SwitchOnOff(System.Boolean isOn); // 0x05c66b54
	System.Void OnClickListener(FairyGUI.EventContext context); // 0x05c66cd4
	System.Void OnEnable(); // 0x05c66edc
	System.Void OnDisable(); // 0x05c66f74
	System.Boolean OnShowCheck(); // 0x05c6700c
	System.Void RefreshUIState(); // 0x05c6684c
	System.Void .ctor(); // 0x05c670fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemOpenMirror : WizardGames.Soc.SocClient.Ui.UiHudElemControlView
{
	System.Boolean _canClick; // 0x1b7
	System.Boolean IsTouching; // 0x1b8
	FairyGUI.Controller ctrlMainBtn; // 0x1c0
	System.Int64 PreseDownTime; // 0x1c8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05523a54
	System.Void ChangeSelected(System.Boolean isAdsOn); // 0x05c67ae4
	System.Void OnDisable(); // 0x05c67b7c
	System.Boolean OnShowCheck(); // 0x05c67bfc
	System.Void OnUiDestroy(); // 0x055049cc
	System.Void OnTouchThroughSettingChanged(); // 0x05c67940
	System.Void AdsStateChange(System.Int64 playerId, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum lastState, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum curState); // 0x05c6816c
	System.Void PlayerLockingStateChange(); // 0x05c682f0
	System.Void ThrowStateChange(System.Int64 playerId, System.Boolean throwState); // 0x05c683b4
	System.Void TouchBegin(FairyGUI.EventContext context); // 0x05c684b0
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05c68994
	System.Void TouchMove(FairyGUI.EventContext context); // 0x05c68a68
	System.Void TouchEnd(FairyGUI.EventContext context); // 0x05c68ae8
	System.Void RollOut(FairyGUI.EventContext context); // 0x05c68e8c
	System.Void OpenMirrorCmd(); // 0x05c6871c
	System.Void OnWeaponSwitchSuccess(System.Int64 oldId, System.Int64 newId); // 0x05c676a8
	System.Void OnDiveStateChange(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x05c68f14
	System.Void .ctor(); // 0x05c691d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemPopTip : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	
	System.Void .ctor(); // 0x05c6923c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIHudElemPossessionPlayer : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	FairyGUI.GTextInput inputPlayerId; // 0x190
	FairyGUI.GComboBox aroundPlayers; // 0x198
	FairyGUI.GButton mainBtn; // 0x1a0
	System.UInt64 wantPossessionPlayerId; // 0x1a8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c692a4
	System.Void OnChanged(); // 0x05c699c8
	System.Void UpdateAroundPlayers(); // 0x05c694c0
	System.Void OnClick(); // 0x05c69b30
	System.Void OnFps1Update(System.Single dt); // 0x05c69ca4
	System.Void .ctor(); // 0x05c69d1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemQuickActionBubble : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	WizardGames.Soc.SocClient.Ui.Binder.GameHud.ElemQuickActionBubbleBinder nodeBinder; // 0x190
	System.Int64 toUseItemCfgId; // 0x198
	WizardGames.Soc.SocClient.Manager.HotKeyCenterGuideData guideData; // 0x1a0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c69d84
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c69f14
	System.Void OnHotKeyAction(); // 0x05c69f78
	System.Void OnEnable(); // 0x05c6a040
	System.Void OnDisable(); // 0x05c6a18c
	System.Void OnUiDestroy(); // 0x05c6a36c
	System.Void ShowBubble(System.Int64 itemCfgId, System.Boolean playAnim); // 0x05c6a418
	System.Void HideBubble(); // 0x05c6a704
	System.Void HideSelf(); // 0x05c6a7c8
	System.Void OnRemoveItemNode(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05c6a86c
	System.Void OnClick(); // 0x05c6a964
	System.Void .ctor(); // 0x05c6ac48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemQuickActionBubble.<>c__DisplayClass14_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudElemQuickActionBubble <>4__this; // 0x10
	WizardGames.Soc.Common.CustomType.BaseItemNode curItem; // 0x18
	System.Void .ctor(); // 0x05c6abe0
	System.Boolean <OnClick>b__0(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x05c6ace8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemReload : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	FairyGUI.GImage imgProgress; // 0x190
	System.Boolean shouldUpdateOption; // 0x198
	System.Int32 lastWeaponId; // 0x19c
	System.Single checkOptionSumT; // 0x1a0
	System.Collections.Generic.List<System.Int32> interactionIdList; // 0x1a8
	System.Collections.Generic.List<System.Int32> avaliableAmmoList; // 0x1b0
	System.Collections.Generic.List<System.Boolean> canUseList; // 0x1b8
	UnityEngine.Vector2 buttonCenterPos; // 0x1c0
	System.Single lastFillAmount; // 0x1c8
	WizardGames.Soc.SocClient.Ui.Binder.GameHud.ElemReloadBinder binder; // 0x1d0
	System.Int64 actionStateSubscribeId; // 0x1d8
	WizardGames.Soc.SocClient.Ui.UiRoulette uiRoulette; // 0x1e0
	System.Boolean longPressTrigger; // 0x1e8
	UnityEngine.Vector2 touchStartPos; // 0x1ec
	System.Single touchStartTime; // 0x1f4
	System.Boolean open; // 0x1f8
	System.Boolean touching; // 0x1f9
	System.Boolean checkDistance; // 0x1fa
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c6ada0
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c6b2ec
	System.Void OnHotKeyAction(); // 0x05c6b350
	System.Void Roulette_OnClick(); // 0x05c6b84c
	System.Void OnUiDestroy(); // 0x05c6b9d8
	System.Void StartEdit(); // 0x05c6bb14
	System.Void OnActionStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x05c6bc3c
	System.Void OnFps10Update(System.Single dt); // 0x05c6be88
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.GroupData> UpdateInteractionData(); // 0x05c6c51c
	System.Void UpdateOptions(); // 0x05c6be20
	System.Void SetValue(System.Int32 cur, System.Int32 max); // 0x05c6b22c
	System.Void Forbid(System.Boolean forbidden); // 0x05c6ce68
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05c6cedc
	System.Void OnJoyStickTouchBegin(FairyGUI.EventContext context); // 0x05c6b5e4
	System.Void OnPressing(); // 0x05c6b75c
	System.Void OnJoyStickTouchEnd(FairyGUI.EventContext context); // 0x05c6b4e4
	WizardGames.Soc.SocClient.Ui.UiRoulette OpenRoulette(System.Boolean joystick); // 0x05c6d20c
	System.Void QuitPanel(); // 0x05c6d578
	System.Void OnEnable(); // 0x05c6d618
	System.Void OnDisable(); // 0x05c6d680
	FairyGUI.GComponent HudDefaultTouchNode(); // 0x05c6d6e8
	System.Void OnJoyStickTouchMove(FairyGUI.EventContext context); // 0x05c6cf70
	System.Void .ctor(); // 0x05c6d7a0
	System.Void <UpdateInteractionData>b__28_0(System.Int32 index); // 0x05c6d924
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIHudElemRFBtn : WizardGames.Soc.SocClient.Ui.UiHudElemCustomHeldCtrl
{
	WizardGames.Soc.Common.CustomType.TimeBombNode timeBombNode; // 0x190
	WizardGames.Soc.Common.CustomType.RFTransmitterNode rFTransmitteNode; // 0x198
	WizardGames.Soc.Common.CustomType.IItemWithFrequency itemWithFrequency; // 0x1a0
	System.Void OnWeaponEquip(System.Int64 oldWeaponId, System.Int64 weaponID); // 0x05c6da88
	System.Boolean OnShowCheck(); // 0x05c6de20
	System.Void OnRFDetonationChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x05c6dea8
	System.Boolean CheckHideEquip(System.Int64 weaponId, System.Int64 weaponTableId); // 0x05c6df54
	System.Boolean IsHeldItemValid(WizardGames.Soc.Common.Entity.IHeldItemEntity heldItemEntity); // 0x05c6e04c
	System.Void .ctor(); // 0x05c6e274
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.FireTriggerResponse : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.FireTriggerResponse Down = 0;
	static WizardGames.Soc.SocClient.Ui.FireTriggerResponse Press = 1;
	static WizardGames.Soc.SocClient.Ui.FireTriggerResponse Up = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.RightAttackMode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.RightAttackMode Fixed = 0;
	static WizardGames.Soc.SocClient.Ui.RightAttackMode Follow = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemRightAttack : WizardGames.Soc.SocClient.Ui.UiHudElemControlView
{
	System.Boolean isFire; // 0x1b7
	WizardGames.Soc.SocClient.Ui.FireTriggerResponse fireTriggerResponse; // 0x1b8
	FairyGUI.Controller comController; // 0x1c0
	FairyGUI.Controller btnController; // 0x1c8
	System.Single cancelFireThresholdWhenFollow; // 0x1d0
	WizardGames.Soc.SocClient.Ui.RightAttackMode Mode; // 0x1d4
	System.Int64 TouchBeginTime; // 0x1d8
	System.Boolean m_IsTouching; // 0x1e0
	UnityEngine.Vector2 m_FingerPos; // 0x1e4
	UnityEngine.Vector2 m_TouchingBeginPos; // 0x1ec
	WizardGames.Soc.SocClient.Ui.UiHudElemLeftAttack _uiLeftAttack; // 0x1f8
	System.Boolean get_isHoldingThrownWeapon(); // 0x05c6e2dc
	WizardGames.Soc.SocClient.Ui.UiHud get_hudBoard(); // 0x05c6e394
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c6e440
	System.Void OnUiDestroy(); // 0x05c6ec34
	System.Void OnDisable(); // 0x05c6ee00
	System.Void AdsStateChange(System.Int64 playerId, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum lastState, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum curState); // 0x05c6f018
	System.Void UpdateAttackResponse(); // 0x05c6f114
	System.Void TouchBegin(FairyGUI.EventContext context); // 0x05c6f1b8
	System.Void TouchEnd(FairyGUI.EventContext context); // 0x05523a54
	System.Void TouchMove(FairyGUI.EventContext context); // 0x05c6fd40
	System.Void UpdateFire(); // 0x05c6ff24
	System.Void UpdateFollow(); // 0x05c6ff9c
	System.Void SetAttackBtnState(System.Boolean isOnDrag); // 0x05c6f7f8
	System.Void SetFingerPos(UnityEngine.Vector2 pos); // 0x05c6f608
	System.Void SetIsTouching(System.Boolean isTouching); // 0x05c6ee8c
	System.Void OnClick(FairyGUI.EventContext context); // 0x05c70144
	System.Void FireCmd(); // 0x05c6f8e0
	System.Void CheckFireBoth(System.Boolean fire); // 0x05c701d8
	System.Void SetMode(WizardGames.Soc.SocClient.Ui.RightAttackMode mode); // 0x05c703c0
	System.Void OnWeaponSwitchSuccess(System.Int64 oldId, System.Int64 newId); // 0x05c6e758
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05c70438
	System.Void .ctor(); // 0x05c704b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.OptionData : System.Object
{
	System.String title; // 0x10
	System.String iconUrl; // 0x18
	System.Action<System.Int32> action; // 0x20
	System.Boolean enable; // 0x28
	System.Void .ctor(System.String t, System.String icon, System.Action<System.Int32> a, System.Boolean e); // 0x05c6cd8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.GroupData : System.Object
{
	System.Int32 index; // 0x10
	System.String title; // 0x18
	System.String iconUrl; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.OptionData> options; // 0x28
	System.Void .ctor(System.Int32 i, System.String t, System.String icon, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.OptionData> d); // 0x05c6ccb8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemSwitchSocket : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	FairyGUI.GButton mainBtn; // 0x190
	WizardGames.Soc.Common.Data.ActionName <HotKey>k__BackingField; // 0x198
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c70528
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c706e0
	System.Void OnHotKeyAction(); // 0x05c70744
	System.Void OnClick(); // 0x05c707c0
	System.Void .ctor(); // 0x05c70894
	System.Void <OnUiCreate>b__1_0(FairyGUI.EventContext ctx); // 0x05c70904
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerMicCtrl : System.Object
{
	FairyGUI.Controller AudioControl; // 0x10
	System.String OpenId; // 0x18
	System.Void .ctor(); // 0x05c7097c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemTeam : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	SocLogger logger; // 0x190
	FairyGUI.GList listPlayerInfo; // 0x198
	WizardGames.Soc.SocClient.Ui.UiPlayerStatusConfig config; // 0x1a0
	System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.SocClient.Ui.UiPlayerMicCtrl> authorControllerDic; // 0x1a8
	FairyGUI.GButton btnJumpTeam; // 0x1b0
	FairyGUI.GButton btnReminder; // 0x1b8
	FairyGUI.Controller btnReminderStatus; // 0x1c0
	FairyGUI.GComponent redDot; // 0x1c8
	FairyGUI.GTextField infoText; // 0x1d0
	System.Int32 chooseEquipmentListenId; // 0x1d8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType> messageTabOrder; // 0x1e0
	System.Int32 messageRotateIndex; // 0x1e8
	System.Int32 messageRotateSecCounter; // 0x1ec
	System.Int32 lastInviteCount; // 0x1f0
	System.Int32 lastRecruitApplyCount; // 0x1f4
	System.Int32 lastTeamTipCount; // 0x1f8
	System.Int32 teamTipRotateIndex; // 0x1fc
	System.Boolean msgTransPlaying; // 0x200
	System.Nullable<WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType> curMsgTabShown; // 0x204
	System.String curMsgText; // 0x210
	System.Boolean pendingSwitch; // 0x218
	WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType pendingTab; // 0x21c
	System.String pendingText; // 0x220
	System.Collections.Generic.HashSet<System.String> roleIds; // 0x228
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.TeamMemberInfo> dataList; // 0x230
	System.Collections.Generic.List<System.Int32> pickList; // 0x238
	FairyGUI.Transition transMessageShow; // 0x240
	FairyGUI.Transition transMessageHide; // 0x248
	FairyGUI.GList pageList; // 0x250
	FairyGUI.GButton btnLeft; // 0x258
	FairyGUI.GButton btnRight; // 0x260
	System.Int32 selectPageIndex; // 0x268
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c709e4
	System.Void OpenMessagePop(); // 0x05c71ef8
	System.Void OnUiDestroy(); // 0x05c72618
	System.Void OnTeamSubscribeFieldChange(); // 0x05c71b5c
	System.Void OnTeamUnSubscribeFieldChange(); // 0x05c729b4
	static System.Void OpenUITeamWindow(); // 0x05c73548
	System.Void RefreshTeamInfoByAided(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Int64 oldValue, System.Int64 newValue); // 0x05c737b8
	System.Void RefreshTeamInfoByLifeCycle(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Int32 oldValue, System.Int32 newValue); // 0x05c73878
	System.Void RefreshTeamInfoByOnline(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Boolean oldValue, System.Boolean newValue); // 0x05c73938
	System.Void RefreshTeamInfoByCharacter(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Byte oldValue, System.Byte newValue); // 0x05c739f8
	System.Void RefreshTeamInfoByUnAlive(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Byte oldValue, System.Byte newValue); // 0x05c73ab8
	System.Void StatusSubscribeFieldChange(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x05c72d28
	System.Void StatusUnSubscribeFieldChange(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x05c73218
	System.Void OnFps1Update(System.Single dt); // 0x05c73b78
	System.Void OnTeamMemberDictChange(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x05c7541c
	System.Void OnTeammateLoginNotice(System.UInt64 roleId); // 0x05c7551c
	System.Void RefreshTeammatesInfo(); // 0x05c715bc
	System.Void RefreshTeamMemberInfoList(); // 0x05c755c0
	System.Void RefreshTeamMemberJumpTeam(); // 0x05c75758
	System.Void RefreshTeamMemberInfo(System.Int32 i, System.String nickName, System.String memOpenId); // 0x05c758e4
	System.Void RefreshHP(); // 0x05c74024
	System.Void RefreshChooseSuitInfo(); // 0x05c74344
	System.Void RefreshStatus(); // 0x05c7608c
	static System.Void SetStateByRoleId(FairyGUI.Controller statusController, WizardGames.Soc.Common.Entity.PlayerEntity player); // 0x05c76380
	System.Void RefreshMessageTicker(); // 0x05c74870
	System.Void UpdateMessageOrder(WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType tab, System.Int32 curCount, System.Int32& lastCount); // 0x05c76648
	System.Void SetInfoText(System.String text); // 0x05c76828
	System.Void SwitchInfoMessageTo(WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType tab, System.String text); // 0x05c768b4
	System.Void RemoveMessageCategory(WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType tab); // 0x05c723f0
	System.Void SetBtnReminderStatus(System.Int32 targetIndex); // 0x05c72528
	System.Void OnCreate_Platform(FairyGUI.GComponent node); // 0x05c712ac
	System.Void OnScrollEnd(); // 0x05c76ac4
	System.Void RefreshTeamMemberInfoList_Platform(); // 0x05c756f4
	System.Void OnPageItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x05c76cac
	System.Void RefreshPageList(); // 0x05c76b90
	System.Void OnClickPageRight(); // 0x05c76d74
	System.Void OnClickPageLeft(); // 0x05c76ec0
	System.Void .ctor(); // 0x05c76fa8
	System.Void <OnUiCreate>b__28_0(); // 0x05c77200
	System.Void <StatusSubscribeFieldChange>b__39_0(System.Collections.Generic.IList<System.Int64> path, System.Int32 newVal); // 0x05c77264
	System.Void <RefreshTeamMemberInfoList>b__45_0(System.Collections.Generic.List<System.String> nameList); // 0x05c77310
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemTeam.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHudElemTeam.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiCommonTeamBattle> <>9__33_0; // 0x8
	static System.Comparison<WizardGames.Soc.Common.CustomType.TeamMemberInfo> <>9__44_0; // 0x10
	static System.Void .cctor(); // 0x05c77888
	System.Void .ctor(); // 0x05c778ec
	System.Void <OpenUITeamWindow>b__33_0(WizardGames.Soc.SocClient.Ui.UiCommonTeamBattle ui); // 0x05c77954
	System.Int32 <RefreshTeammatesInfo>b__44_0(WizardGames.Soc.Common.CustomType.TeamMemberInfo p1, WizardGames.Soc.Common.CustomType.TeamMemberInfo p2); // 0x05c779dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemTeam.<>c__DisplayClass55_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudElemTeam <>4__this; // 0x10
	System.String text; // 0x18
	WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType tab; // 0x20
	FairyGUI.PlayCompleteCallback <>9__1; // 0x28
	System.Void .ctor(); // 0x05c76a5c
	System.Void <SwitchInfoMessageTo>b__0(); // 0x05c77b4c
	System.Void <SwitchInfoMessageTo>b__1(); // 0x05c77c48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemThrownSwitch : WizardGames.Soc.SocClient.Ui.UiHudElemCustomHeldCtrl
{
	FairyGUI.GButton _btn; // 0x190
	FairyGUI.GTextField _text; // 0x198
	WizardGames.Soc.Common.CustomType.TimeBombNode timeBombNode; // 0x1a0
	WizardGames.Soc.SocClient.Manager.EResponseLevel <ResposeLevel>k__BackingField; // 0x1a8
	WizardGames.Soc.Common.Data.ActionName <HotKey>k__BackingField; // 0x1ac
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c77d30
	WizardGames.Soc.SocClient.Manager.EResponseLevel get_ResposeLevel(); // 0x05c77ee0
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c77f44
	System.Void OnHotKeyAction(); // 0x05c77fa8
	System.Void StartEdit(); // 0x05c78034
	System.Void OnClick(FairyGUI.EventContext content); // 0x05c78138
	System.Void SwitchMode(System.Boolean toNear); // 0x05c781e0
	System.Void OnWeaponEquip(System.Int64 oldWeaponId, System.Int64 weaponID); // 0x05c783cc
	System.Void OnRFDetonationChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x05c78700
	System.Boolean CheckHideEquip(System.Int64 weaponId, System.Int64 weaponTableId); // 0x05c787ac
	System.Void OnEnable(); // 0x05c78864
	System.Void OnDisable(); // 0x05c7893c
	System.Void .ctor(); // 0x05c78a14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemTriggerBtn : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	WizardGames.Soc.SocClient.Ui.Binder.GameHud.ElemTriggerBtnBinder nodeBinder; // 0x190
	WizardGames.Soc.SocClient.Ui.Binder.GameHud.ElemCommonBtn1Binder commonBtn1Binder; // 0x198
	System.Int32 currentInteractiveId; // 0x1a0
	WizardGames.Soc.SocClient.Water.MgrWater.EPlayerInWaterState curWaterState; // 0x1a4
	System.Int32 curWater; // 0x1a8
	System.Int64 curWaterId; // 0x1b0
	System.Single getWaterRemainT; // 0x1b8
	System.Int32 getWaterSpeed; // 0x1bc
	System.Boolean isGettingWater; // 0x1c0
	WizardGames.Soc.SocClient.Ui.ComItemIcon curSelectIcon; // 0x1c8
	System.String waterFormat; // 0x1d0
	System.Int64 curWeaponTbId; // 0x1d8
	System.Int64 lootEntityId; // 0x1e0
	WizardGames.Soc.SocClient.Manager.HotKeyCenterGuideData guideData; // 0x1e8
	FairyGUI.Transition animShow; // 0x1f0
	FairyGUI.Transition animLoop; // 0x1f8
	System.Void OnBoardInit(); // 0x05c78a84
	System.Void OnBoardDestroy(); // 0x05c78b9c
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c78cb4
	WizardGames.Soc.SocClient.Manager.EResponseLevel get_ResposeLevel(); // 0x05c790c8
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c7912c
	System.Void OnHotKeyAction(); // 0x05c79190
	System.Void OnEnable(); // 0x05c7932c
	System.Boolean OnShowCheck(); // 0x05c793c8
	System.Void OnShow(); // 0x05c7947c
	System.Void OnDisable(); // 0x05c79a68
	System.Void OnUiDestroy(); // 0x05c79bcc
	System.Void OnBoardDisable(); // 0x05c79c68
	System.Void OnFps10Update(System.Single dt); // 0x05c79cd8
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05c7a8e8
	System.Void HideSelf(); // 0x05c7a9a8
	System.Void OnTouchBegin(); // 0x05c7aa0c
	System.Void OnTouchEnd(); // 0x05c7abc4
	System.Void OnClick(); // 0x05c7ae38
	System.Void OnTriggerBtnInteractiveIdChange(System.Int32 interactiveId); // 0x05c7c2f0
	System.Void UpdateCD(System.Int32 leftSec); // 0x05c7c634
	System.Void SendWantsPush(System.Int32 id); // 0x05c7b180
	System.Void OnTouchBegin_DropWater(); // 0x05c7aad8
	System.Void OnTouchEnd_DropWater(); // 0x05c7ac90
	System.Void CheckFillWaterVisible(); // 0x05c7a1fc
	System.Void RefreshWaterProgress(); // 0x05c7a384
	System.Void StopGetWater(); // 0x05c7c920
	System.Void TryStopGetWater(); // 0x05c79b48
	System.Void OnLootBtnShow(); // 0x05c798d4
	System.Void OnClickLoot(); // 0x05c7b3a4
	System.Void CloseLootView(System.Int64 lootingEntityId); // 0x05c7ca00
	System.Void InspectPlunderTrigger(System.Int32 interactiveId); // 0x05c7c558
	System.Void OnZiplineClick(); // 0x05c7b568
	System.Void OnZiplineSpeedUpClick(); // 0x05c7bb0c
	System.Void OnLadderClick(); // 0x05c7bc94
	System.Void OnLadderBottomClick(); // 0x05c7bd4c
	System.Void OnLadderSpeedUpClick(); // 0x05c7be04
	System.Void OnParachuteOpenClick(); // 0x05c7c008
	System.Void OnParachuteCloseClick(); // 0x05c7c248
	System.Void RefreshParachuteBtn(); // 0x05c7a688
	System.Void ClearParachuteBtn(); // 0x05c7a840
	System.Void PlayShowEffect(FairyGUI.PlayCompleteCallback onComplete); // 0x05c799d4
	System.Void PlayLoopEffect(); // 0x05c7cc2c
	System.Void StopShowEffect(); // 0x05c7ccb0
	System.Void StopLoopEffect(); // 0x05c7cd80
	System.Void StopAllEffect(); // 0x05c79968
	System.Void .ctor(); // 0x05c7ce50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemUp : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	System.Boolean _isPressed; // 0x190
	FairyGUI.GButton _mainBtn; // 0x198
	FairyGUI.GLoader _icon; // 0x1a0
	FairyGUI.Controller _slideCtrl; // 0x1a8
	UnityEngine.Vector2 _initCenterPos; // 0x1b0
	FairyGUI.GObject _objDarkCover; // 0x1b8
	System.String _mantleUrl; // 0x1c0
	System.String _upUrl; // 0x1c8
	System.Int32 _lastSwimPosType; // 0x1d0
	WizardGames.Soc.SocClient.Ui.UiHud get_Hud(); // 0x05c7cfd0
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c7d07c
	System.Boolean OnShowCheck(); // 0x05c7d350
	System.Void OnEnable(); // 0x055049cc
	System.Void OnDisable(); // 0x055049cc
	System.Void OnEnterSwim(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x05c7d6ec
	System.Void OnExitSwim(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x05c7da90
	System.Void TouchBegin(FairyGUI.EventContext context); // 0x05c7dbec
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05c7dd28
	System.Void OnFps10Update(System.Single dt); // 0x05c7ddfc
	System.Void RefreshSwimIcon(); // 0x05c7d848
	System.Void SetIcon(WizardGames.Soc.Common.Unity.Character.SwimPosType swimPosType); // 0x05c7dfc0
	System.Void TouchMove(FairyGUI.EventContext context); // 0x05c7e2c8
	System.Void TouchEnd(FairyGUI.EventContext context); // 0x05c7e4e8
	System.Void .ctor(); // 0x05c7e634
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemVoice : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	FairyGUI.GButton _btnVoice; // 0x190
	FairyGUI.GLoader paddingIcon; // 0x198
	static System.Int32 MaxVolume; // 0x0
	System.Single delta; // 0x1a0
	System.Single preAmount; // 0x1a4
	System.Single updateDtMs; // 0x1a8
	FairyGUI.GComponent voicePrint; // 0x1b0
	FairyGUI.Transition click01Tran; // 0x1b8
	FairyGUI.Transition click02Tran; // 0x1c0
	FairyGUI.Controller showVoice; // 0x1c8
	WizardGames.Soc.SocClient.Ui.UiMic uiMic; // 0x1d0
	System.Double startTouchTime; // 0x1d8
	System.Double holdTime; // 0x1e0
	System.Boolean isTouching; // 0x1e8
	System.Boolean enableHoldMic; // 0x1e9
	WizardGames.Soc.SocClient.Manager.HotKeyAction holdMicAction; // 0x1f0
	WizardGames.Soc.SocClient.Manager.EResponseLevel <ResposeLevel>k__BackingField; // 0x1f8
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c7ea1c
	WizardGames.Soc.SocClient.Manager.EResponseLevel get_ResposeLevel(); // 0x05c7f9b8
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c7fa1c
	WizardGames.Soc.Common.Data.ActionName get_HotKeyHold(); // 0x05c7fa80
	System.Void OnHotKeyAction(); // 0x05c7fae4
	System.Void OnVoiceBand(); // 0x05c7fc44
	System.Void OnEnable(); // 0x05c7fcac
	System.Void OnUiDestroy(); // 0x05c7feb8
	System.Void RetryJoinGlobalRoomSuccess(); // 0x05c80208
	System.Void RetryJoinTeamRoomSuccess(); // 0x05c802ac
	System.Void ChangeIcon(System.Int32 index); // 0x05c7f81c
	System.Void OnHoldMicAction(); // 0x05c80350
	System.Void UpdateMyMicVolume(); // 0x05c80530
	System.Boolean CheckHoldMic(); // 0x05c80734
	System.Void PlayAnim(FairyGUI.Transition anim); // 0x05c807dc
	System.Void EnableHoldMicrophone(); // 0x055049cc
	System.Void OnTouchBegin(FairyGUI.EventContext context); // 0x05c80b90
	System.Void OnTouchEnd(FairyGUI.EventContext context); // 0x05c80c5c
	System.Void QuitPanel(); // 0x05c80d54
	System.Void OnFps10Update(System.Single dt); // 0x05c80ddc
	System.Void SelectEffect(System.Boolean isOn); // 0x05c80f48
	FairyGUI.GComponent HudDefaultTouchNode(); // 0x05c81514
	System.Void mainBtnOnClick(); // 0x05c81120
	System.Void .ctor(); // 0x05c81698
	static System.Void .cctor(); // 0x05c8182c
	System.Void <OnUiCreate>b__17_0(FairyGUI.EventContext ctx); // 0x05c81878
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemWeapons : WizardGames.Soc.SocClient.Ui.UiHudElem, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsBelt comBelt; // 0x190
	FairyGUI.GObject contentForPreview; // 0x198
	FairyGUI.GButton btnChooseTab; // 0x1a0
	FairyGUI.Controller ctrlTabPos; // 0x1a8
	FairyGUI.Controller ctrlSwitch; // 0x1b0
	FairyGUI.Controller ctrlWeaponChooseStyle; // 0x1b8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComItemIcon> icons; // 0x1c0
	System.Collections.Generic.List<FairyGUI.Controller> iconStyles; // 0x1c8
	System.Collections.Generic.List<FairyGUI.Controller> iconChooseStyles; // 0x1d0
	System.Boolean touchToHideWeaponChoose; // 0x1d8
	System.Boolean skipRecover; // 0x1d9
	System.Single contentPreviewOriPosY; // 0x1dc
	System.Single lastClickSwitchT; // 0x1e0
	static System.Boolean ForceRefreshIconInventoryClipNum; // 0x0
	static System.Int64 CondRefreshIconInventoryClipNum; // 0x8
	System.Boolean <HideWeaponChooseOnDragEnd>k__BackingField; // 0x1e4
	System.Collections.Generic.List<System.Int32> weaponGuideLst; // 0x1e8
	System.Int32 IndexToChooseOnEntityChange; // 0x1f0
	System.Int32 get_CurSelectIndex(); // 0x05c818f0
	System.Int32 get_MenuChooseIndex(); // 0x05c81994
	System.Void set_MenuChooseIndex(System.Int32 value); // 0x05c81a4c
	System.Boolean get_IsTabLeft(); // 0x05c81af8
	System.Boolean get_HideWeaponChooseOnDragEnd(); // 0x05c81bb4
	System.Void set_HideWeaponChooseOnDragEnd(System.Boolean value); // 0x05c81c18
	System.Void DoInitAfterShortcuts(WizardGames.Soc.SocClient.Ui.UiHudElemShortcutsBelt beltContainer); // 0x05c81c94
	UnityEngine.Rect GetBlockArea(); // 0x05c829ec
	System.Void OnBoardEnable(); // 0x05c82bf4
	System.Void OnEnable(); // 0x05c82cc8
	System.Void TryUnEquip(); // 0x05c83000
	System.Boolean HotKeySelectIcon1(); // 0x05c830bc
	System.Boolean HotKeySelectIcon2(); // 0x05c834e8
	System.Void OnDisable(); // 0x05c836dc
	System.Void OnUpdateItemNode(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05c839c4
	System.Void OnIconDragEnd(); // 0x05c83a7c
	System.Boolean OnDragToIcon(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x05c83c20
	System.Boolean OnClickSwitch(System.Boolean needCD); // 0x05c840d8
	System.Boolean DoClickWithIndex(System.Int32 index, System.Boolean chooseOnly, System.Boolean playSetAnim); // 0x05c84318
	System.Int32 TransShowIndexWithIconIndex(System.Int32 oriIndex); // 0x05c8446c
	System.Void TryGuide(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05c84500
	System.Void OnFps10Update(System.Single dt); // 0x05c84978
	System.Void Refresh(); // 0x05c84b00
	System.Void OnAddOrRemoveItemNode(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05c84d74
	System.Void ChooseCurNormalSizeWeapon(); // 0x05c84dec
	System.Void SetSwtichIndex(System.Int32 idx); // 0x05c84ed4
	System.Boolean OnShortcutsItemEntityChange(System.Int32 index); // 0x05c84f68
	System.Void RefreshAmmo(); // 0x05c851b0
	System.Void SetAllIconHighlight(System.Boolean on); // 0x05c85028
	WizardGames.Soc.SocClient.Ui.UiHudWeaponChoose OpenWeaponChoose(System.Boolean isDrag); // 0x05c85380
	System.Void SetChooseStyle(System.Boolean holdStateOnly); // 0x05c85468
	System.Void OnDestory(); // 0x05c8561c
	static WizardGames.Soc.SocClient.Ui.UiHudElemWeapons GetElem(); // 0x05c85688
	System.Void SelectEffect(System.Boolean isOn); // 0x05c85710
	System.Void RefreshTabPos(UnityEngine.Vector3 boardLocalPos); // 0x05c859c8
	System.Void RefreshTabPos(); // 0x05c82c58
	System.Void OnElemEditMoving(FairyGUI.EventContext context); // 0x05c85c5c
	System.Boolean OnClickIcon(System.Int32 tarI); // 0x05c832bc
	UnityEngine.Vector2 GetContentPreviewLocalPos(); // 0x05c85a80
	UnityEngine.Vector2 GetWeaponChooseBoardGlobalPos(); // 0x05c86388
	System.Void OnShortcutsChooseMenuStateChange(System.Boolean open); // 0x05c86580
	System.Void DealIconWhenCollect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05c8280c
	System.Void TryOnClickSwitch(System.Int32 tarI); // 0x05c865f4
	System.Boolean OnClickWeapon(System.Int32 tarI); // 0x05c86138
	System.Void InitWeaponIconAnims(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05c825c8
	System.Void OnDragToIcon_NotAWeapon(); // 0x05c83f28
	System.Void SetWeaponChooseState(System.Boolean on, System.Int32 weaponIndex); // 0x05c85dbc
	System.Void OnDragWeaponSwitch_Palform(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.Common.CustomType.BaseItemNode dropItem); // 0x05c83f88
	System.Void SetSkipFrameUpdate(System.Boolean on); // 0x05c86744
	System.Boolean OnIconDragStart(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x05c86914
	System.Void .ctor(); // 0x05c86b68
	System.Void <DoInitAfterShortcuts>b__29_0(FairyGUI.EventContext ctx); // 0x05c86d5c
	System.Void <OnEnable>b__32_0(); // 0x05c86e34
	System.Void <OnEnable>b__32_1(); // 0x05c86e98
	System.Void <DealIconWhenCollect>b__65_0(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon, System.Boolean state); // 0x05c86efc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemWeapons.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHudElemWeapons.<>c <>9; // 0x0
	static System.Action <>9__70_0; // 0x8
	static System.Void .cctor(); // 0x05c86f90
	System.Void .ctor(); // 0x05c86ff4
	System.Void <SetWeaponChooseState>b__70_0(); // 0x05c8705c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemWeapons.<>c__DisplayClass29_0 : System.Object
{
	System.Int32 tarI; // 0x10
	WizardGames.Soc.SocClient.Ui.UiHudElemWeapons <>4__this; // 0x18
	System.Void .ctor(); // 0x05c82560
	System.Void <DoInitAfterShortcuts>b__1(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05c87114
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemWeapons.<>c__DisplayClass68_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	WizardGames.Soc.SocClient.Ui.UiHudElemWeapons <>4__this; // 0x18
	System.Void .ctor(); // 0x05c866dc
	System.Void <InitWeaponIconAnims>b__0(); // 0x05c87198
	System.Void <InitWeaponIconAnims>b__1(); // 0x05c87250
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCustomPanel : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.UiHudEdit uiHudEdit; // 0x10
	FairyGUI.GLoader BgLoader; // 0x18
	FairyGUI.GLoader PanelLoader; // 0x20
	System.Single loaderOriginHeight; // 0x28
	FairyGUI.GComponent Root; // 0x30
	FairyGUI.GLoader dragRoot; // 0x38
	FairyGUI.GButton Exit; // 0x40
	FairyGUI.GButton HideBtn; // 0x48
	FairyGUI.GComponent ComHide; // 0x50
	FairyGUI.GSlider TransSlider; // 0x58
	FairyGUI.GSlider SizeSlider; // 0x60
	FairyGUI.GComponent ComPosition; // 0x68
	FairyGUI.GButton BtnReset; // 0x70
	FairyGUI.GButton BtnSave; // 0x78
	FairyGUI.GComponent TextSaveTip; // 0x80
	FairyGUI.GButton BtnFold; // 0x88
	WizardGames.Soc.SocClient.Ui.ComComboBox comComboBox; // 0x90
	System.Int32[] settingWindowMsg; // 0x98
	System.Int64 positionBtnTimerId; // 0xa0
	FairyGUI.Controller get_FoldControl(); // 0x05c872c0
	static System.String get_schemeIndexSavePath(); // 0x05c87348
	static System.String get_SchemeIndexSavePath(); // 0x05c87400
	System.Void Init(FairyGUI.GLoader bgLoader, FairyGUI.GLoader loader, WizardGames.Soc.SocClient.Ui.UiHudEdit uiHud); // 0x05c8747c
	System.Void Bind(); // 0x05c87568
	System.Void StartEdit(); // 0x05c88c98
	System.Void OnRootTouchStart(FairyGUI.EventContext context); // 0x05c89340
	System.Void OnRootTouchEnd(FairyGUI.EventContext context); // 0x05c89464
	System.Void OnRootDragMove(FairyGUI.EventContext context); // 0x05c89588
	System.Void EndEdit(); // 0x05c899b8
	System.Void InitTransSlider(); // 0x05c88138
	System.Void TransSliderListener(FairyGUI.EventContext context); // 0x05c89c10
	System.Void ChangeGripListeners(FairyGUI.GObject grip); // 0x05c89b10
	System.Void InitSizeSlider(); // 0x05c88294
	System.Void SizeSliderListener(FairyGUI.EventContext context); // 0x05c89d64
	System.Void InitComPosition(); // 0x05c883b8
	System.Void PositionBtnTouchBegin(FairyGUI.EventContext context); // 0x05c8a19c
	System.Void PositionBtnTouchEnd(FairyGUI.EventContext context); // 0x05c8a3d0
	System.Void PositionBtnListener(FairyGUI.EventContext context); // 0x05c8a4d8
	System.Void PositionBtnListener(FairyGUI.GButton button); // 0x05c8a5f0
	System.Void MoveElem(System.Single deltaX, System.Single deltaY, WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x05c8aa58
	System.Void Reset(); // 0x05c8ac00
	System.Void Save(System.Boolean withTips); // 0x05c8aff0
	System.Void ExitListener(); // 0x05c8b230
	System.Void ExitWithoutSave(); // 0x05c8b6a8
	System.Void SaveAndExit(); // 0x05c8b724
	System.Void InitComComboBox(); // 0x05c889c4
	System.Void OnComComboBoxClick(System.Int32 index); // 0x05c8b7ac
	System.Void BtnFoldListener(FairyGUI.EventContext context); // 0x05c8b834
	System.Void BtnHideListener(FairyGUI.EventContext context); // 0x05c8ba14
	System.Void SetComHidePlayAnim(System.Boolean isClick); // 0x05c8be78
	System.Void .ctor(); // 0x05c8bf48
	static System.Void .cctor(); // 0x05c8c004
	System.Void <Bind>b__35_0(FairyGUI.EventContext ctx); // 0x05c8c0d8
	System.Void <Bind>b__35_1(FairyGUI.EventContext ctx); // 0x05c8c154
	System.Void <PositionBtnTouchBegin>b__48_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x05c8c1d0
	System.Void <Reset>b__53_0(); // 0x05c8c2b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCustomPanel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiCustomPanel.<>c <>9; // 0x0
	static System.Action <>9__54_1; // 0x8
	static System.Void .cctor(); // 0x05c8c380
	System.Void .ctor(); // 0x05c8c3e4
	System.Void <Save>b__54_1(); // 0x05c8c44c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCustomPanel.<>c__DisplayClass54_0 : System.Object
{
	System.Boolean withTips; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCustomPanel <>4__this; // 0x18
	FairyGUI.PlayCompleteCallback <>9__3; // 0x20
	System.Void .ctor(); // 0x05c8b1c8
	System.Void <Save>b__0(); // 0x05c8c55c
	System.Void <Save>b__3(); // 0x05c8c960
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCustomPanel.<>c__DisplayClass54_1 : System.Object
{
	FairyGUI.Transition hideAnim; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCustomPanel.<>c__DisplayClass54_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x05c8c8f8
	System.Void <Save>b__2(); // 0x05c8c9dc
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ETouchPenetrateCom : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ETouchPenetrateCom None = 0;
	static WizardGames.Soc.SocClient.Ui.ETouchPenetrateCom Joystick = 1;
	static WizardGames.Soc.SocClient.Ui.ETouchPenetrateCom MoveView = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EUiHudCategory : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EUiHudCategory Base = 0;
	static WizardGames.Soc.SocClient.Ui.EUiHudCategory Building = 1;
	static WizardGames.Soc.SocClient.Ui.EUiHudCategory Vehicle = 2;
	static WizardGames.Soc.SocClient.Ui.EUiHudCategory All = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHud : WizardGames.Soc.Common.Unity.Ui.UiEditable
{
	FairyGUI.GComponent hudRoot; // 0x390
	FairyGUI.GComponent <LowerRoot>k__BackingField; // 0x398
	FairyGUI.GComponent <UpperRoot>k__BackingField; // 0x3a0
	FairyGUI.GComponent <ElemRoot>k__BackingField; // 0x3a8
	System.Boolean isUseMobileStyleUI; // 0x3b0
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> blockElems; // 0x3b8
	WizardGames.Soc.SocClient.Ui.UiHudElemJoystick joystick; // 0x3c0
	WizardGames.Soc.SocClient.Ui.UiMoveView moveView; // 0x3c8
	WizardGames.Soc.SocClient.Ui.UiHudElemBtnDebugFly UiHudElemBtnDebugFly; // 0x3d0
	FairyGUI.GButton objBgBlock; // 0x3d8
	System.Action onClickBgBlock; // 0x3e0
	FairyGUI.GTextField textVerInfo; // 0x3e8
	FairyGUI.Transition transRootShow; // 0x3f0
	FairyGUI.Transition transRootHide; // 0x3f8
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ETouchPenetrateCom,System.Collections.Generic.List<System.Int32>> _touchPenetrateCom2TouchIds; // 0x400
	System.Int32 touchId; // 0x408
	System.Boolean <IsInEdit>k__BackingField; // 0x40c
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.HudButtonType,System.Int32> BlockNum; // 0x410
	static System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.ComTouchArea> AllComTouchArea; // 0x0
	System.Boolean ContentPaneTouchBegin; // 0x418
	System.Action<WizardGames.Soc.SocClient.Ui.MantleUiType> OnMantleUiTypeChanged; // 0x420
	WizardGames.Soc.SocClient.Ui.MantleUiType MantleUiType; // 0x428
	static System.Int32 editPlayId; // 0x8
	static WizardGames.Soc.SocClient.Ui.UiHudElem curBlockElem; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiHudElem curElemChangeCheck; // 0x18
	System.Boolean isRefreshRunning; // 0x42c
	System.Diagnostics.Stopwatch refreshTimer; // 0x430
	System.Collections.Generic.Queue<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> stateChangeShowQuene; // 0x438
	System.Collections.Generic.Queue<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> stateChangeHideQuene; // 0x440
	System.Int64 remoteCallGetAllObsetverInfoTimerId; // 0x448
	UnityEngine.Color gmLineColor; // 0x450
	UnityEngine.Color gmFillColor; // 0x460
	FairyGUI.GComponent get_LowerRoot(); // 0x05c8cb68
	System.Void set_LowerRoot(FairyGUI.GComponent value); // 0x05c8cbcc
	FairyGUI.GComponent get_UpperRoot(); // 0x05c8cc4c
	System.Void set_UpperRoot(FairyGUI.GComponent value); // 0x05c8ccb0
	System.Void set_ElemRoot(FairyGUI.GComponent value); // 0x05c8cd30
	System.Boolean get_IsInEdit(); // 0x05c8cdb0
	static System.Void RegisterComTouchArea(WizardGames.Soc.SocClient.Ui.ComTouchArea comTouchArea); // 0x05c8ce14
	static System.Void UnregisterComTouchArea(WizardGames.Soc.SocClient.Ui.ComTouchArea comTouchArea); // 0x05c8cf20
	System.Void RegisterAllElemTypes(); // 0x05c8cfcc
	System.Void RegisterHudElem(System.String typeName, System.String name, System.Int32 id, System.Boolean isBlock); // 0x05c8d964
	System.Void AddElemTargetElems(System.String elemName); // 0x05c8dc6c
	System.Void CreateLoaderForSlotItem(WizardGames.Soc.Common.Data.Ui.Hud elem); // 0x05c8da34
	WizardGames.Soc.Common.Unity.Ui.UiEditableScheme CreateSchemeMgr(); // 0x05c8dda4
	System.Void OnInit(); // 0x05c8de38
	System.Void SetTouchBegin(FairyGUI.EventContext context, System.Object userData); // 0x05c8f824
	System.Void OnAnimUpdateContainer(); // 0x05c8fda8
	System.Void OnAnimUnlockContainer(); // 0x05c8fec0
	System.Void OnAnimRelockContainer(); // 0x05c8ffd8
	System.Void InitAnims(); // 0x05c8f1fc
	System.Void OnLayerVisibleChanged(System.Boolean layerVisible); // 0x05c900ec
	System.Void OnEnable(); // 0x055049cc
	System.Void OnRemoteCallGetAllObsetverInfoTick(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05c90cd0
	System.Void OnDisable(); // 0x05c90ddc
	System.Void RegisterEvents(); // 0x05c9082c
	System.Void UnRegisterEvents(); // 0x05c91020
	System.Void OnHudStateChanged(System.Collections.Generic.List<System.Int32> showElems); // 0x05c91210
	System.Void CheckUIHudShowStatus(); // 0x05c90680
	System.Void OnDestroy(); // 0x05c913d0
	System.Void MarkHudElemShow(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x05c91554
	System.Void MarkHudElemHide(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x05c91638
	System.Void RefreshHudElems(System.Collections.Generic.List<System.Int32> showElems); // 0x05c909a0
	System.Void ProcessShowHideQueue(); // 0x05c91784
	System.Void OnCaptureTouchBegin(FairyGUI.EventContext context); // 0x05c91cd4
	System.Void TouchMove(FairyGUI.EventContext context); // 0x05c91eb0
	System.Void TouchEnd(FairyGUI.EventContext context); // 0x05c92144
	System.Boolean IsTouchBeBlocked(UnityEngine.Vector2 touchPos); // 0x05c924b8
	System.Boolean IsTouchJoystick(UnityEngine.Vector2 touchPos); // 0x05c92a78
	System.Boolean IsScreenPosInUI(UnityEngine.Vector2 screenPos, FairyGUI.GObject targetUI); // 0x05c8fa20
	System.Boolean IsScreenPosInUI(UnityEngine.Vector2 screenPos, UnityEngine.Rect inStageArea); // 0x05c92998
	static T GetElem<T>(System.Int32 id); // 0x052af1f0
	static T GetElem<T>(System.String name); // 0x052af1f0
	System.Void OnFps30Update(System.Single dt); // 0x05c92b60
	System.Void OnFpsUnlimitedUpdate_Input(System.Single dt); // 0x05c92c1c
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05513724
	System.Void EnableMoveViewTouchArea(System.Boolean enable); // 0x05c92eb0
	System.Void SetButtonMode(System.Boolean isFixed); // 0x05c93460
	System.Void InitButtonMode(); // 0x05c8f580
	System.Void ShowElem(System.String nodeName); // 0x05c9128c
	System.Void HideElem(System.String nodeName); // 0x05c9132c
	System.Void SwitchMantleUiType(WizardGames.Soc.SocClient.Ui.MantleUiType uiType); // 0x05c8f794
	System.Void OnTouchBgBlock(FairyGUI.EventContext ctx); // 0x05c936d4
	System.Void EnableBgBlock(System.Action onClickBg); // 0x05c93940
	System.Void DisableBgBlock(); // 0x05c938bc
	static System.Void SetHudBgBlockState(System.Action onClickBg); // 0x05c86824
	System.Void RefreshFlashUIState(); // 0x05c93a7c
	System.Void RefreshNightVersionUIState(); // 0x05c90bf8
	static System.Void RemoteSwitchElem(System.String name, System.Boolean toggle); // 0x05c93c1c
	System.Void DisableBtnRFRelated(); // 0x05c93d68
	System.Void MakeFullScreen(); // 0x05c93e40
	System.Void RefreshWinSafeArea(); // 0x05c93f18
	System.Void SetControlMode(); // 0x05c8d6d4
	System.Void TouchBegin(FairyGUI.EventContext context); // 0x05c9403c
	System.Void .ctor(); // 0x05c945a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHud.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHud.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__45_0; // 0x8
	static System.Action<WizardGames.Soc.Common.CustomType.BaseItemNode> <>9__50_0; // 0x10
	static System.Void .cctor(); // 0x05c94758
	System.Void .ctor(); // 0x05c947bc
	System.Int32 <RegisterAllElemTypes>b__45_0(WizardGames.Soc.Common.Unity.Ui.UiEditableElem a, WizardGames.Soc.Common.Unity.Ui.UiEditableElem b); // 0x05c94824
	System.Void <OnInit>b__50_0(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x05c948d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHud.<>c__DisplayClass68_0 : System.Object
{
	System.Collections.Generic.List<System.Int32> showElems; // 0x10
	System.Collections.Generic.HashSet<System.Int32> setElemsToHideArea; // 0x18
	WizardGames.Soc.SocClient.Ui.UiHud <>4__this; // 0x20
	System.Void .ctor(); // 0x05c9171c
	System.Boolean <RefreshHudElems>b__0(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x05c94988
	System.Void <RefreshHudElems>b__1(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elemTrue); // 0x05c94c94
	System.Void <RefreshHudElems>b__2(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elemFalse); // 0x05c94d38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudEdit : WizardGames.Soc.Common.Unity.Ui.UiEditable
{
	WizardGames.Soc.SocClient.Ui.UiHud uihud; // 0x390
	FairyGUI.GGraph editMask; // 0x398
	FairyGUI.GComponent hudRoot; // 0x3a0
	FairyGUI.GComponent <UpperRoot>k__BackingField; // 0x3a8
	WizardGames.Soc.SocClient.Ui.UiCustomPanel uiCustomPanel; // 0x3b0
	FairyGUI.PinchGesture _gesture; // 0x3b8
	System.Single _pinchGestureFactor; // 0x3c0
	FairyGUI.GComponent get_UpperRoot(); // 0x05c94e3c
	System.Void set_UpperRoot(FairyGUI.GComponent value); // 0x05c94ea0
	System.Void OnInit(); // 0x055049cc
	System.Void OnDestroy(); // 0x055049cc
	WizardGames.Soc.Common.Unity.Ui.UiEditableScheme CreateSchemeMgr(); // 0x05c9577c
	System.Void RegisterAllElemTypes(); // 0x05c95810
	System.Void StartEdit(System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem,System.Boolean> elemFilter); // 0x05c96010
	System.Void EndEdit(System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem,System.Boolean> elemFilter); // 0x05c961c4
	System.Void CreateLoaderForSlotItem(WizardGames.Soc.Common.Data.Ui.Hud elem); // 0x05c95dd8
	System.Void HideCurEditElem(FairyGUI.EventContext context); // 0x05c8baf4
	System.Void SetCategoryVisible(WizardGames.Soc.SocClient.Ui.EUiHudCategory freeCategory, System.Boolean maskInsteadHide); // 0x05c88f98
	System.Void ResetSortingOrder(); // 0x05c963a4
	System.Void OnPinchGestureAction(); // 0x05c965dc
	System.Void OnElemSelected(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x05c967f4
	System.Void ActionCloseCustomUi(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x05c96aa0
	System.Void OnCrawlCloseUi(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x05c96bcc
	System.Void .ctor(); // 0x05c96d80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudEdit.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHudEdit.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem,System.Boolean> <>9__15_0; // 0x8
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem,System.Boolean> <>9__19_0; // 0x10
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem,System.Boolean> <>9__20_0; // 0x18
	static System.Action<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__20_1; // 0x20
	static System.Void .cctor(); // 0x05c96e18
	System.Void .ctor(); // 0x05c96e7c
	System.Boolean <StartEdit>b__15_0(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x05c96ee4
	System.Boolean <SetCategoryVisible>b__19_0(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x05c96f9c
	System.Boolean <ResetSortingOrder>b__20_0(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x05c97054
	System.Void <ResetSortingOrder>b__20_1(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x05c9710c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudEdit.<>c__DisplayClass19_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudEdit <>4__this; // 0x10
	System.Boolean maskInsteadHide; // 0x18
	WizardGames.Soc.SocClient.Ui.EUiHudCategory freeCategory; // 0x1c
	System.Void .ctor(); // 0x05c96574
	System.Void <SetCategoryVisible>b__1(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x05c972b4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EDynamicLayoutType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EDynamicLayoutType HORIZONTAL = 0;
	static WizardGames.Soc.SocClient.Ui.EDynamicLayoutType VERTICAL = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElem : WizardGames.Soc.Common.Unity.Ui.UiEditableElem
{
	WizardGames.Soc.Common.Data.Ui.Hud <TbData>k__BackingField; // 0xe8
	FairyGUI.GComponent defaultTouchNode; // 0xf0
	FairyGUI.DisplayObject defaultTouchArea; // 0xf8
	System.Func<UnityEngine.Rect> GetStageBlockArea; // 0x100
	System.Int64 lastestWeaponTableId; // 0x108
	System.Int64 lastestWeaponEntityId; // 0x110
	UnityEngine.Color selectedColor; // 0x118
	UnityEngine.Color unselectedColor; // 0x128
	FairyGUI.GObject dynamicSlavePanel; // 0x138
	UnityEngine.Vector2 dynamicSlaveOffset; // 0x140
	UnityEngine.Vector2 dynamicSlaveOriginScale; // 0x148
	WizardGames.Soc.SocClient.Ui.EDynamicLayoutType dynamicLayoutType; // 0x150
	System.Boolean isDynamicSlaveChild; // 0x154
	System.Boolean isScroll; // 0x155
	System.Boolean isDynamicUseDefaultDir; // 0x156
	System.Boolean isTouchBeginFromSelf; // 0x157
	WizardGames.Soc.Common.Data.ActionName <HotKey>k__BackingField; // 0x158
	WizardGames.Soc.Common.Data.ActionName <HotKeyHold>k__BackingField; // 0x15c
	WizardGames.Soc.SocClient.Manager.EResponseLevel <ResposeLevel>k__BackingField; // 0x160
	System.Collections.Generic.List<UnityEngine.Vector2> m_FourAnchorsStandard; // 0x168
	System.Collections.Generic.List<UnityEngine.Vector2> m_NineAnchorsStandard; // 0x170
	System.Collections.Generic.List<UnityEngine.Vector2> m_FourAnchorsNow; // 0x178
	System.Collections.Generic.List<UnityEngine.Vector2> m_NineAnchorsNow; // 0x180
	System.Single height_now; // 0x188
	System.Single width_now; // 0x18c
	WizardGames.Soc.Common.Data.Ui.Hud get_TbData(); // 0x05c975c0
	System.Void set_TbData(WizardGames.Soc.Common.Data.Ui.Hud value); // 0x05c97624
	WizardGames.Soc.SocClient.Ui.UiHud get_hudBoard(); // 0x05c976a4
	WizardGames.Soc.SocClient.Ui.HudButtonType get_HudButtonType(); // 0x05c97754
	System.Void SetID(System.Int32 id); // 0x05c97808
	System.Void CheckExtraTreeNodeInfoHook(); // 0x05c97c5c
	System.Void SetNodeLoader(WizardGames.Soc.Common.Unity.Ui.UiEditable uiBoard, FairyGUI.GLoader uiNodeLoader); // 0x05c97cbc
	System.Void SetNode(WizardGames.Soc.Common.Unity.Ui.UiEditable uiBoard, FairyGUI.GComponent uiNode); // 0x05c97d50
	System.Void OnDynamicLoaded(System.Boolean isValid); // 0x05c97de4
	System.Boolean IsInSector(UnityEngine.Vector2 mousePos, UnityEngine.Vector2 center, UnityEngine.Vector2 forward, System.Single radius, System.Single angle); // 0x05c98154
	System.Void ExpandClickRange(FairyGUI.GButton button, System.Single exRadius); // 0x05c7f4fc
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x05c983a4
	System.Boolean CanGuideState(System.String state); // 0x05c9841c
	System.Void AttachDynamicSlavePanel(FairyGUI.GObject node, WizardGames.Soc.SocClient.Ui.EDynamicLayoutType layoutType, UnityEngine.Vector2 offset, System.Boolean isChild, System.Boolean isScroll, System.Boolean useDeafultDir); // 0x05c813a8
	System.Void OnElemEditMoving(FairyGUI.EventContext context); // 0x05c85cf4
	UnityEngine.Vector3 GetDynamicPanelPosition(FairyGUI.GObject slavePanel, WizardGames.Soc.SocClient.Ui.EDynamicLayoutType layoutType, UnityEngine.Vector2 offset, System.Boolean isChild, System.Boolean scroll, System.Boolean useDefaultDir); // 0x05c81594
	UnityEngine.Vector3 GetDynamicChildPanelPosition(FairyGUI.GObject slavePanel, WizardGames.Soc.SocClient.Ui.EDynamicLayoutType layoutType, UnityEngine.Vector2 offset, System.Boolean scroll, System.Boolean useDefaultDir); // 0x05c98f24
	UnityEngine.Vector3 GetDynamicGlobalPanelPosition(FairyGUI.GObject slavePanel, WizardGames.Soc.SocClient.Ui.EDynamicLayoutType layoutType, UnityEngine.Vector2 offset, System.Boolean scroll, System.Boolean useDefaultDir); // 0x05c98494
	UnityEngine.Vector2 GetLTOrigin(FairyGUI.GObject obj, System.Boolean withScale); // 0x05c99c0c
	System.Void TryUpdateSlavePanelPosition(); // 0x05c8a0fc
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x05c7f06c
	System.Void OnUiDestroy(); // 0x05c80118
	System.Void AutoRefreshForTouch(FairyGUI.EventContext context); // 0x05c99e04
	WizardGames.Soc.SocClient.Manager.EHotKeyLayer get_HotKeyGroup(); // 0x05c99e84
	WizardGames.Soc.Common.Data.ActionName get_HotKey(); // 0x05c99ee8
	WizardGames.Soc.Common.Data.ActionName get_HotKeyHold(); // 0x05c99f4c
	System.Void OnHotKeyAction(); // 0x05c99fb0
	WizardGames.Soc.SocClient.Manager.EResponseLevel get_ResposeLevel(); // 0x05c9a010
	System.Void OnEnable(); // 0x05c7fda4
	System.Void OnDisable(); // 0x05c838fc
	System.Void Show(); // 0x05c9a074
	System.Void Hide(); // 0x05c9a150
	System.Void ShowCenterGuideTip(); // 0x05c9a1cc
	System.Void HideCenterGuideTip(); // 0x05c9a22c
	FairyGUI.GComponent HudDefaultTouchNode(); // 0x05c9a30c
	FairyGUI.DisplayObject HudDefaultTouchArea(); // 0x05c9a3b4
	System.Void LoadEditEffectNodes(); // 0x05c9a5a4
	System.Boolean get_IsShowWhenEdit(); // 0x05c9a718
	System.Boolean get_CanEdit(); // 0x05c9a864
	System.Boolean get_CanEditBeforeShow(); // 0x05c9a974
	System.Boolean get_CanSetPos(); // 0x05c9aa84
	System.Boolean get_CanOption(); // 0x05c9ab58
	System.Boolean get_CustomControl(); // 0x05c9ac2c
	System.Single get_StandardWidth(); // 0x05c9ad24
	System.Single get_StandardHeight(); // 0x05c9add0
	System.Void SetPos(System.Single deltaX, System.Single deltaY, System.Int32 anchor); // 0x05c9ae7c
	System.Void ChangeElemAnchorPoint(FairyGUI.GObject target, System.Int32 anchor); // 0x05c9b2ec
	System.Void SetFourAnchorRelation(FairyGUI.GObject target, System.Int32 anchor); // 0x05c9b4b4
	System.Void SetNineAnchorRelation(FairyGUI.GObject target, System.Int32 anchor); // 0x05c9b838
	UnityEngine.Vector2 GetFourAnchorsNow(System.Int32 index); // 0x05c9b0f4
	UnityEngine.Vector2 GetNineAnchorsNow(System.Int32 index); // 0x05c9b1f0
	System.Void UpdateStatus(WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus status); // 0x05c9ce38
	System.Boolean IsUsingDefaultStatus(System.Int32 id); // 0x05c9d668
	System.Void GetFourAnchors(); // 0x05c9bdf4
	System.Int32 GetBelongAnchorFour(System.Single x, System.Single y, System.Boolean isStandard); // 0x05c9d4b8
	System.Void GetNineAnchors(); // 0x05c9c414
	System.Int32 GetBelongAnchorNine(System.Single x, System.Single y, System.Boolean isStandard); // 0x05c9d3bc
	System.Boolean IsInBox(System.Single x, System.Single y, System.Int32 i, System.Int32 j, System.Boolean isStandard); // 0x05c9d830
	System.Void StartEdit(); // 0x05c9d968
	System.Void SetOptionState(System.Boolean on); // 0x05c9da54
	System.Void SetStatus(WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus status, System.Boolean reset); // 0x05c9dad4
	System.Void .ctor(); // 0x05c81710
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElem.<>c__DisplayClass37_0 : System.Object
{
