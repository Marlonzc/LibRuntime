
// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWaterProgress : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GProgressBar progressGetWater; // 0x338
	static WizardGames.Soc.SocClient.Ui.UiWaterProgress instance; // 0x0
	System.Void OnInit(); // 0x06685244
	static System.Void Show(System.Int32 max, System.Int32 current); // 0x0668539c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06685500
	static System.Void Hide(); // 0x066855a4
	static System.Void SetProgress(System.Single val); // 0x0668565c
	System.Void .ctor(); // 0x06685710
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWireColorBasePanel : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GList cableLst; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.CableItemInfo> cableInfoLst; // 0x340
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Electric.WireColour,System.Int32> color2IdxDic; // 0x348
	WizardGames.Soc.Common.Unity.Electric.WireColour curSelectColor; // 0x350
	WizardGames.Soc.Common.Unity.Electric.WireColour curUseColor; // 0x354
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x358
	System.Void OnInit(); // 0x0668579c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06685ff4
	System.Void OnEnable(); // 0x06686074
	System.Void OnDisable(); // 0x06686164
	System.Void UpdateCableData(); // 0x066860e4
	System.Void InitCableData(); // 0x06685ae8
	System.Void OnRenderCableItem(System.Int32 index, FairyGUI.GObject obj); // 0x066861cc
	System.Void OnClickCable(FairyGUI.EventContext context); // 0x06686310
	System.Void OnSelectedColor(WizardGames.Soc.Common.Unity.Electric.WireColour color); // 0x06686550
	System.Void .ctor(); // 0x066865c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWireColorPanel : WizardGames.Soc.SocClient.Ui.UiWireColorBasePanel
{
	
	System.Void OnSelectedColor(WizardGames.Soc.Common.Unity.Electric.WireColour color); // 0x066866fc
	System.Void .ctor(); // 0x066867dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWireModifyColorPanel : WizardGames.Soc.SocClient.Ui.UiWireColorBasePanel
{
	System.Int64 timer; // 0x360
	System.Void OnSelectedColor(WizardGames.Soc.Common.Unity.Electric.WireColour color); // 0x06686840
	System.Void .ctor(); // 0x06686e90
	System.Void <OnSelectedColor>b__1_0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x06686ef4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BloodController : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	FairyGUI.GComponent Root; // 0x10
	FairyGUI.GImage virtualBar; // 0x18
	FairyGUI.GImage solidBar; // 0x20
	FairyGUI.GImage dangerSolidBar; // 0x28
	FairyGUI.Controller dangerController; // 0x30
	FairyGUI.GImage line; // 0x38
	FairyGUI.Transition lineAnim; // 0x40
	System.Int32 motionState; // 0x48
	System.Int32 startFrame; // 0x4c
	System.Int32 moveFrame; // 0x50
	System.Single startPercent; // 0x54
	FairyGUI.PlayCompleteCallback onAnimEnd; // 0x58
	static WizardGames.Soc.SocClient.Ui.BloodController Create(FairyGUI.GComponent barRoot, System.Single initAmount, System.Boolean isdanger); // 0x0668700c
	System.Void OnAnimEnd(); // 0x066873fc
	System.Void Init(FairyGUI.GComponent barRoot, System.Single initAmount, System.Boolean isdanger); // 0x066870f4
	System.Void SetFillAmount(System.Single percent, System.Boolean danger); // 0x06687470
	System.Void OnUpdate(); // 0x06687764
	System.Void Release(); // 0x06687948
	System.Void OnGet(); // 0x06687a68
	System.Void OnRelease(); // 0x06687ac8
	System.Void OnDestroy(); // 0x06687b28
	System.Void .ctor(); // 0x06687b88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComEnhancedTip : WizardGames.Soc.SocClient.Ui.ComWorldFlagBase
{
	UnityEngine.Vector3 worldPos; // 0x5c
	System.Boolean isShow; // 0x68
	System.Boolean isDisappearing; // 0x69
	FairyGUI.GLoader flagLoader; // 0x70
	FairyGUI.Transition appearTrans; // 0x78
	FairyGUI.Transition disappearTrans; // 0x80
	System.Void Init(); // 0x06687bf0
	FairyGUI.GComponent LoadFlag(); // 0x066883dc
	System.Void DisposeFlag(); // 0x066884f0
	UnityEngine.Vector3 GetWorldPos(); // 0x066886d8
	System.Boolean CanFlagDispose(); // 0x0668873c
	System.Void SetActive(System.Boolean isActive); // 0x066887b8
	System.Void SetShowState(System.Boolean isShow); // 0x06688968
	System.Void SetShow(); // 0x066880b4
	System.Void SetIcon(System.String iconUrl); // 0x06688b18
	System.Void SetWorldPos(UnityEngine.Vector3 pos); // 0x06688c10
	System.Void SetBrightness(System.Single brightness); // 0x06688ca8
	System.Void ReturnToPool(); // 0x06688dec
	System.Void .ctor(); // 0x06688e4c
	System.Void <SetShow>b__14_0(); // 0x06688f70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComEntityGuideFlag : WizardGames.Soc.SocClient.Ui.ComWorldFlagBase
{
	System.Int64 entityId; // 0x60
	WizardGames.Soc.Common.Data.Play.GuideConfig guideCfg; // 0x68
	FairyGUI.GComponent comBase; // 0x70
	FairyGUI.GTextField titleTxt; // 0x78
	FairyGUI.GTextField descTxt; // 0x80
	FairyGUI.GLoader timeBar; // 0x88
	FairyGUI.Transition disappearTrans; // 0x90
	System.Boolean disappearShowed; // 0x98
	System.Boolean isBreak; // 0x99
	System.Single showTime; // 0x9c
	System.Int32 showTimeCfg; // 0xa0
	System.Void Init(); // 0x06688fd4
	System.Void Update(System.Single dt); // 0x066895dc
	FairyGUI.GComponent LoadFlag(); // 0x06689794
	UnityEngine.Vector3 GetWorldPos(); // 0x066898c8
	System.Boolean CanFlagDispose(); // 0x06689b84
	System.Boolean CanFlagActive(); // 0x06689c78
	System.Void SetGuideInfo(System.Int32 id, System.Int64 entityId); // 0x06689da4
	System.Void OnGetFromPool(System.Int64 entityId); // 0x06689f90
	System.Void DisposeFlag(); // 0x0668a02c
	System.Void OnBreak(); // 0x0668a328
	System.Void ReturnToPool(); // 0x0668a390
	System.Void .ctor(); // 0x0668a3f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComWorldFlagBase : System.Object, Share.Common.ObjPool.IPooledObjectNew
{
	System.Int32 LastIndex; // 0x10
	UnityEngine.Plane[] cachedFrustumPlanes; // 0x18
	UnityEngine.Vector3 lastCameraPosition; // 0x20
	UnityEngine.Quaternion lastCameraRotation; // 0x2c
	System.Single positionTolerance; // 0x3c
	System.Single rotationTolerance; // 0x40
	FairyGUI.GComponent <ComFlag>k__BackingField; // 0x48
	System.UInt64 <Mid>k__BackingField; // 0x50
	System.Boolean <IsReturn>k__BackingField; // 0x58
	System.Boolean <CareThreadSafe>k__BackingField; // 0x59
	FairyGUI.GComponent get_ComFlag(); // 0x0668a4ec
	System.Void set_ComFlag(FairyGUI.GComponent value); // 0x0668a550
	System.UInt64 get_Mid(); // 0x0668a5d0
	System.Void set_Mid(System.UInt64 value); // 0x0668a634
	System.Boolean get_IsReturn(); // 0x0668a6ac
	System.Void set_IsReturn(System.Boolean value); // 0x0668a710
	System.Boolean get_CareThreadSafe(); // 0x0668a78c
	System.Void set_CareThreadSafe(System.Boolean value); // 0x0668a7f0
	System.Void Init(); // 0x06687e2c
	FairyGUI.GComponent LoadFlag(); // 0x054e7844
	System.Void DisposeFlag(); // 0x0668a1c4
	System.Void LockFlag(FairyGUI.GComponent target, System.Int32 frame); // 0x066893cc
	System.Void UnlockFlag(FairyGUI.GComponent target, System.Boolean skipFrame); // 0x0668a86c
	System.Void LockFlag(System.Int32 frame); // 0x06687fec
	System.Void UnlockFlag(System.Boolean skipFrame); // 0x06688a50
	UnityEngine.Vector3 GetWorldPos(); // 0x054b1148
	System.Boolean IsFlagActive(); // 0x0668aa3c
	System.Boolean CanFlagActive(); // 0x06689d40
	System.Boolean CanFlagDispose(); // 0x054c4760
	System.Boolean UpdateFlag(UnityEngine.Vector2 screenPos, System.Single disToCam); // 0x0668ab6c
	System.Void SetActive(System.Boolean isActive); // 0x0668889c
	System.Boolean IsTargetVisible(); // 0x0668ac64
	System.Void CacheFrustumPlanes(UnityEngine.Camera cam); // 0x0668b008
	System.Boolean HasCameraPositionChanged(UnityEngine.Camera cam); // 0x0668ae44
	System.Boolean HasCameraRotationChanged(UnityEngine.Camera cam); // 0x0668af10
	System.Void ReturnToPool(); // 0x055049cc
	System.Void .ctor(); // 0x06688ef0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComWorldFlagElectricICStorage : WizardGames.Soc.SocClient.Ui.ComWorldFlagPart
{
	
	System.Void ReturnToPool(); // 0x0668b118
	System.Void .ctor(); // 0x0668b1a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComWorldFlagIO : WizardGames.Soc.SocClient.Ui.ComWorldFlagBase
{
	WizardGames.Soc.Common.Entity.IOEntity target; // 0x60
	WizardGames.Soc.SocClient.Go.IOGo targetGo; // 0x68
	UnityEngine.Vector3 v3TarPos; // 0x70
	System.Single posYOffset; // 0x7c
	System.Boolean isExist; // 0x80
	FairyGUI.GLoader icon; // 0x88
	FairyGUI.GImage iconImg01; // 0x90
	FairyGUI.GImage iconImg02; // 0x98
	FairyGUI.GLoader iconBg; // 0xa0
	FairyGUI.GImage bg; // 0xa8
	FairyGUI.GTextField countText; // 0xb0
	System.String imgUrl; // 0xb8
	System.String urlBg; // 0xc0
	FairyGUI.Transition iconSwingTrans; // 0xc8
	System.Void .ctor(); // 0x0668b3c0
	System.Void OnGetFromPool(WizardGames.Soc.Common.Entity.IOEntity entity); // 0x0668b48c
	System.Void OnReturnPool(); // 0x0668b654
	System.Void Init(); // 0x0668b6c8
	UnityEngine.Vector3 GetWorldPos(); // 0x0668bb04
	FairyGUI.GComponent LoadFlag(); // 0x0668bcb8
	System.Boolean CanFlagDispose(); // 0x0668bd80
	System.Boolean UpdateFlag(UnityEngine.Vector2 screenPos, System.Single disToCam); // 0x0668bdec
	System.Void DisposeFlag(); // 0x0668c034
	System.Void ReturnToPool(); // 0x0668c158
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComWorldFlagLabel : WizardGames.Soc.SocClient.Ui.ComWorldFlagBase
{
	System.Int64 targetEntityId; // 0x60
	FairyGUI.GTextField labelTextField; // 0x68
	UnityEngine.Transform labelPointTransform; // 0x70
	UnityEngine.Vector3 v3TarPos; // 0x78
	System.Boolean isFocus; // 0x84
	System.String actTipsSwitchNotEnableStr; // 0x88
	System.String actTipsSwitchNotOpenStr; // 0x90
	System.String interactiveOpStr; // 0x98
	System.String interactiveCallElevatorStr; // 0xa0
	System.Void .ctor(); // 0x0668c1b8
	System.Void OnGetFromPool(System.Int64 entityId); // 0x0668c34c
	System.Void OnReturnPool(); // 0x0668c454
	System.Void Init(); // 0x0668c50c
	UnityEngine.Vector3 GetWorldPos(); // 0x0668c608
	FairyGUI.GComponent LoadFlag(); // 0x0668c8d4
	System.Boolean CanFlagDispose(); // 0x0668c99c
	System.Boolean UpdateFlag(UnityEngine.Vector2 screenPos, System.Single disToCam); // 0x0668cac0
	System.Void DisposeFlag(); // 0x0668cb60
	System.Boolean IsTargetVisible(); // 0x0668cbfc
	System.Void SetFocus(System.Boolean focus); // 0x0668cdec
	System.Void OnUpdate(System.Single dt); // 0x0668ce68
	System.Void HandleIOEntity(WizardGames.Soc.Common.Entity.IOEntity ioEntity); // 0x0668d060
	System.Void ElevatorEntityNameText(WizardGames.Soc.Common.Entity.ElevatorEntity elevatorEntity); // 0x0668d29c
	System.Void ReturnToPool(); // 0x0668d4b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComWorldFlagMonumentTask : WizardGames.Soc.SocClient.Ui.ComWorldFlagBase
{
	FairyGUI.GTextField mDistanceText; // 0x60
	System.Boolean mIsDispose; // 0x68
	System.Boolean mIsActive; // 0x69
	UnityEngine.Vector3 mShowPos; // 0x6c
	System.Single lastFactor; // 0x78
	System.Int32 lastDis; // 0x7c
	System.Void .ctor(); // 0x0668d510
	System.Void Init(); // 0x0668d5c0
	UnityEngine.Vector3 GetWorldPos(); // 0x0668d6bc
	FairyGUI.GComponent LoadFlag(); // 0x0668d758
	System.Boolean CanFlagDispose(); // 0x0668d820
	System.Boolean CanFlagActive(); // 0x0668d884
	System.Boolean UpdateFlag(UnityEngine.Vector2 screenPos, System.Single disToCam); // 0x0668d8e8
	System.Void DisposeFlag(); // 0x0668dcb0
	System.Void ReturnToPool(); // 0x0668dd68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComWorldFlagNewBloodBar : WizardGames.Soc.SocClient.Ui.ComWorldFlagBase
{
	static SocLogger logger; // 0x0
	System.Single showTime; // 0x5c
	UnityEngine.Vector3 v3TarPos; // 0x60
	System.Single lastScale; // 0x6c
	System.Boolean <IsFocusBar>k__BackingField; // 0x70
	WizardGames.Soc.SocClient.Ui.HpBarInfo Info; // 0x78
	WizardGames.Soc.Common.Data.Combat.CombatComponent CombatTable; // 0x90
	WizardGames.Soc.Common.Data.global.GlobalEntity EntityTable; // 0x98
	WritableString writableString; // 0xa0
	System.String coreBuildStringFormat; // 0xb0
	FairyGUI.GComponent ComArmor; // 0xb8
	FairyGUI.GComponent ComMaterial; // 0xc0
	FairyGUI.GComponent ComShield; // 0xc8
	WizardGames.Soc.SocClient.Ui.HpBarScale hpBarScale; // 0xd0
	WizardGames.Soc.SocClient.Ui.BloodController bloodController; // 0xd8
	FairyGUI.GImage BarScale; // 0xe0
	FairyGUI.GTextField Name; // 0xe8
	FairyGUI.GTextField Support; // 0xf0
	System.Boolean isFriend; // 0xf8
	UnityEngine.Transform hpPointTransform; // 0x100
	System.Int64 get_targetEntityId(); // 0x0668ddf0
	System.Void set_IsFocusBar(System.Boolean value); // 0x0668de54
	System.Boolean get_IsFocusBar(); // 0x0668ded0
	System.Int32 get_BarType(); // 0x0668df34
	System.Void SetHpBarInfo(WizardGames.Soc.SocClient.Ui.HpBarInfo info); // 0x0668dfa8
	System.Void OnReturnPool(); // 0x0668e03c
	System.Void Init(); // 0x0668e138
	System.Void TryGetHpPoint(); // 0x0668f204
	UnityEngine.Vector3 GetWorldPos(); // 0x0668f5f8
	FairyGUI.GComponent LoadFlag(); // 0x0668f9e8
	System.Boolean CanFlagDispose(); // 0x0668fab0
	System.Void DisposeFlag(); // 0x0668fd88
	System.Boolean IsTargetVisible(); // 0x0668fed8
	System.Void SetShowTime(System.Single time); // 0x0668ff3c
	System.Void SetFocus(System.Boolean isfocus); // 0x0668ffb4
	System.Void UpdateBloodBar(); // 0x06690064
	System.Void SetTextFieldInternal(FairyGUI.GTextField com, System.String txt); // 0x066902d4
	System.Void Update10FPS(); // 0x0669039c
	System.Boolean UpdateFlag(UnityEngine.Vector2 screenPos, System.Single disToCam); // 0x066905e4
	System.Void UpdateInfoBar(); // 0x0668ecc8
	System.Void PlayerEntityInfoBar(WizardGames.Soc.Common.Entity.PlayerEntity player); // 0x06690c70
	System.Void PartEntityInfoBar(WizardGames.Soc.Common.Unity.Go.ClientPartGo partGo); // 0x06690d14
	System.Void MonsterEntityInfoBar(WizardGames.Soc.SocClient.Go.MonsterGo monsterGo); // 0x066910b8
	System.Void CorpseEntityInfoBar(WizardGames.Soc.SocClient.Go.CorpseGo corpseGo); // 0x06691208
	System.Void VehicleEntityInfoBar(WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo); // 0x06691358
	System.Void BoxEntityInfoBar(WizardGames.Soc.Common.Entity.BoxEntity boxEntity); // 0x06691404
	System.Void CollectableEntityInfoBar(WizardGames.Soc.Common.Entity.CollectableEntity collectableEntity); // 0x0669154c
	System.Void ReturnToPool(); // 0x06691694
	System.Void .ctor(); // 0x066916f4
	static System.Void .cctor(); // 0x0669188c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComWorldFlagPart : WizardGames.Soc.SocClient.Ui.ComWorldFlagBase
{
	UnityEngine.Transform cameraTrans; // 0x60
	UnityEngine.Vector3 playerPos; // 0x68
	System.Single[] distances; // 0x78
	System.Int64 targetEntityId; // 0x80
	UnityEngine.GameObject uiRoot; // 0x88
	FairyGUI.UIPanel uiPanel; // 0x90
	System.Boolean isExist; // 0x98
	System.String uiRootKey; // 0xa0
	WizardGames.Soc.Common.Entity.PartEntity get_TargetEntity(); // 0x06691960
	WizardGames.Soc.Common.Entity.PartEntity get_TargetCommonPartGo(); // 0x06691a00
	UnityEngine.GameObject get_TargetGo(); // 0x06691a64
	UnityEngine.Vector3 get_CameraPos(); // 0x06691b7c
	System.Void .ctor(); // 0x0668b204
	System.Void OnGetFromPool(System.Int64 entityId); // 0x06691cec
	System.Void OnReturnPool(); // 0x06691d6c
	UnityEngine.Vector3 GetWorldPos(); // 0x06691e3c
	System.Void Init(); // 0x06691f78
	System.Void OnConstructionMoveSuc(System.Int64 entityId); // 0x0669208c
	FairyGUI.GComponent LoadFlag(); // 0x06692224
	System.Boolean CanFlagActive(); // 0x0669247c
	System.Void SetActive(System.Boolean isActive); // 0x06692564
	System.Boolean IsFlagActive(); // 0x06692640
	System.Boolean CanFlagDispose(); // 0x066926fc
	System.Void DisposeFlag(); // 0x06692768
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComWorldFlagShopGo : WizardGames.Soc.SocClient.Ui.ComWorldFlagBase
{
	WizardGames.Soc.Common.Entity.ShopEntity target; // 0x60
	UnityEngine.Vector3 v3TarPos; // 0x68
	System.Single hudOffset; // 0x74
	System.Boolean isExist; // 0x78
	FairyGUI.GLoader icon; // 0x80
	System.String imgUrl; // 0x88
	System.Single lastFactor; // 0x90
	System.Void .ctor(); // 0x0669292c
	System.Void Init(); // 0x06692a00
	UnityEngine.Vector3 GetWorldPos(); // 0x06692bd0
	FairyGUI.GComponent LoadFlag(); // 0x06692cb8
	System.Boolean CanFlagDispose(); // 0x06692d80
	System.Boolean UpdateFlag(UnityEngine.Vector2 screenPos, System.Single disToCam); // 0x06692e0c
	System.Void DisposeFlag(); // 0x06692ff8
	System.Void ReturnToPool(); // 0x066930ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComWorldSpaceFlag : WizardGames.Soc.SocClient.Ui.ComWorldFlagPart
{
	FairyGUI.GLoader icon; // 0xa8
	FairyGUI.GImage iconImg01; // 0xb0
	FairyGUI.GImage iconImg02; // 0xb8
	FairyGUI.GLoader iconBg; // 0xc0
	FairyGUI.GTextField countText; // 0xc8
	FairyGUI.Transition gearTrans; // 0xd0
	FairyGUI.Transition iconSwingTrans; // 0xd8
	System.String imgUrl; // 0xe0
	System.String urlBg; // 0xe8
	FairyGUI.GTextField goldNum; // 0xf0
	FairyGUI.GLoader goldLoader; // 0xf8
	FairyGUI.Controller typeCtrl; // 0x100
	System.String decomposeIcon; // 0x108
	System.Void OnReturnPool(); // 0x0669310c
	System.Void Init(); // 0x06693264
	System.Boolean UpdateFlag(UnityEngine.Vector2 screenPos, System.Single disToCam); // 0x0669381c
	System.Void ShowGold(); // 0x06694700
	System.Void SetUrl(System.String imgUrl, System.String urlBg); // 0x06694564
	System.Void DisposeFlag(); // 0x066948d8
	System.Void ReturnToPool(); // 0x0669496c
	System.Void .ctor(); // 0x066949cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.HpBarScale : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	FairyGUI.GImage Image; // 0x10
	System.Single RepresentHp; // 0x18
	System.Single MaxHp; // 0x1c
	System.Single BarWidth; // 0x20
	static WizardGames.Soc.SocClient.Ui.HpBarScale Create(FairyGUI.GImage image, System.Single representHp, System.Single maxHp, System.Single barWidth); // 0x06694c74
	System.Void Init(); // 0x06694d70
	System.Void Release(); // 0x06694e1c
	System.Void OnGet(); // 0x06694ebc
	System.Void OnRelease(); // 0x06694f1c
	System.Void OnDestroy(); // 0x06694f88
	System.Void .ctor(); // 0x06694fe8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWorldFlag : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	FairyGUI.GComponent flagRoot; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComWorldFlagBase> flags; // 0x340
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.ComWorldFlagBase> tempRemoveflags; // 0x348
	static System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComWorldFlagBase> comWorldFlagCacheList; // 0x0
	UnityEngine.Vector3 flagComparePos; // 0x350
	System.Collections.Generic.List<FairyGUI.GObject> flagSortList; // 0x360
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x06695050
	System.Void OnInit(); // 0x066950d0
	System.Void OnDisable(); // 0x0669519c
	System.Void RegisterFlag(WizardGames.Soc.SocClient.Ui.ComWorldFlagBase flag); // 0x066953e0
	System.Void OnComponentUpdate(); // 0x066957ac
	System.Void OnFps1Update(System.Single dt); // 0x06695bbc
	System.Void CollectFlagsToRemove(); // 0x06695c78
	System.Int32 FlagCompare(WizardGames.Soc.SocClient.Ui.ComWorldFlagBase flag1, WizardGames.Soc.SocClient.Ui.ComWorldFlagBase flag2); // 0x066962c8
	System.Void SortByDistance(); // 0x06695e14
	System.Boolean RefreshFlagState(WizardGames.Soc.SocClient.Ui.ComWorldFlagBase flag, System.Boolean& needRemove); // 0x06695968
	System.Void RefreshFlagPos(WizardGames.Soc.SocClient.Ui.ComWorldFlagBase flag); // 0x06695a7c
	System.Void RemoveFlag(WizardGames.Soc.SocClient.Ui.ComWorldFlagBase flag); // 0x066961b4
	System.Void OnDestroy(); // 0x066963f0
	static System.Void Register(WizardGames.Soc.SocClient.Ui.ComWorldFlagBase flag); // 0x06696774
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComWorldFlagBase> GetFlags(); // 0x06696aa4
	System.Void .ctor(); // 0x06696b08
	static System.Void .cctor(); // 0x06696cd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWorldFlag.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiWorldFlag.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ComWorldFlagBase> <>9__8_0; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.ComWorldFlagBase> <>9__18_0; // 0x10
	static System.Action<WizardGames.Soc.SocClient.Ui.UiWorldFlag> <>9__19_0; // 0x18
	static System.Void .cctor(); // 0x06696d68
	System.Void .ctor(); // 0x06696dcc
	System.Void <OnDisable>b__8_0(WizardGames.Soc.SocClient.Ui.ComWorldFlagBase flag); // 0x06696e34
	System.Void <OnDestroy>b__18_0(WizardGames.Soc.SocClient.Ui.ComWorldFlagBase flag); // 0x06696ec0
	System.Void <Register>b__19_0(WizardGames.Soc.SocClient.Ui.UiWorldFlag uiWorldFlag); // 0x06696f4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ClientConditionParser : System.Object, WizardGames.Soc.SocClient.Ui.ICondParser
{
	System.Collections.Generic.Dictionary<System.String,System.Func<System.Collections.Generic.List<System.String>,System.Boolean>> condHandler; // 0x10
	static SocLogger logger; // 0x0
	System.Void .ctor(); // 0x0669718c
	System.Boolean Parse(System.String cond, System.Collections.Generic.List<System.String> vals); // 0x066977fc
	System.Boolean ApplyCompare<T>(System.String operateor, T valL, T valR); // 0x052af1f0
	System.Boolean CompareRegisterDay(System.Collections.Generic.List<System.String> vals); // 0x06697900
	System.Boolean ReachLobbyLevel(System.Collections.Generic.List<System.String> vals); // 0x06697a20
	System.Boolean LockByChannelId(System.Collections.Generic.List<System.String> vals); // 0x06697b7c
	System.Boolean LockByChannelType(System.Collections.Generic.List<System.String> vals); // 0x06697d00
	System.Boolean NotNewbie(System.Collections.Generic.List<System.String> vals); // 0x06697f60
	System.Boolean AlwaysTrue(System.Collections.Generic.List<System.String> vals); // 0x06698008
	System.Boolean AlwaysFalse(System.Collections.Generic.List<System.String> vals); // 0x06698080
	System.Boolean PandoraEntryShow(System.Collections.Generic.List<System.String> vals); // 0x066980f8
	System.Boolean UnlockMainQuestEntry(System.Collections.Generic.List<System.String> vals); // 0x06698170
	System.Boolean UnlockActionExpansionEntry(System.Collections.Generic.List<System.String> vals); // 0x06698220
	System.Boolean IsPlayerWounded(System.Collections.Generic.List<System.String> vals); // 0x066983d0
	System.Boolean IsAdminAuthority(System.Collections.Generic.List<System.String> vals); // 0x066984cc
	System.Boolean IsCampTentingIoen(System.Collections.Generic.List<System.String> vals); // 0x06698600
	System.Boolean IsCompleteMainQuestInNewBie(System.Collections.Generic.List<System.String> vals); // 0x066986b0
	System.Boolean IsConsoleMedalUnlock(System.Collections.Generic.List<System.String> vals); // 0x0669885c
	System.Boolean IsServerManager(System.Collections.Generic.List<System.String> vals); // 0x0669890c
	static System.Void .cctor(); // 0x06698a3c
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Ui.IComBinderDestroy : 
{
	
	System.Void OnDestroy(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBinderDictionary<T> : System.Object
{
	System.Collections.Generic.Dictionary<FairyGUI.GObject,T> items; // 0x0
	System.Func<FairyGUI.GComponent,T> factory; // 0x0
	System.Collections.Generic.Dictionary<FairyGUI.GObject,T> get_Items(); // 0x054e7844
	System.Void .ctor(System.Func<FairyGUI.GComponent,T> factory); // 0x05523a54
	T Get(FairyGUI.GObject obj); // 0x052af1f0
	System.Void Clear(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComIconSeedPool : System.Object
{
	System.Int32 poolResidentCapacity; // 0x10
	System.Boolean usePoolResident; // 0x14
	System.String resourceURL; // 0x18
	FairyGUI.GComponent <PoolRoot>k__BackingField; // 0x20
	FairyGUI.GObjectPool comPool; // 0x28
	System.String poolName; // 0x30
	System.Single autoRemoveTimeSec; // 0x38
	System.Boolean initPool; // 0x3c
	FairyGUI.GComponent get_PoolRoot(); // 0x06698b10
	System.Void set_PoolRoot(FairyGUI.GComponent value); // 0x06698b74
	System.Void .ctor(FairyGUI.GComponent parent, System.String name, System.Int32 residentCapacity); // 0x06698bf4
	System.Void ClearPool(); // 0x06699030
	FairyGUI.GComponent GetComInternal(System.Boolean fromPoolOnly); // 0x066990ac
	System.Void InitResidentComData(); // 0x066991d8
	FairyGUI.GComponent GetCom(); // 0x066996b0
	System.Void ReturnCom(FairyGUI.GComponent com); // 0x066993d0
	System.Void OnFps1Update(System.Single dt); // 0x06699728
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComItemPropertyUtil : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.ItemAttrEnum> Name2FoodAttr; // 0x0
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.ItemAttrEnum> Name2MedicalAttr; // 0x8
	static System.Void FillAttr_Remote(WizardGames.Soc.Common.Data.DataItem.ItemConfig item, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.AttrData> attrs); // 0x06699868
	static System.Void FillAttr_Melee(WizardGames.Soc.Common.Data.DataItem.ItemConfig item, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.AttrData> attrs); // 0x06699fdc
	static System.Void FillAttr_WeaponMod(WizardGames.Soc.Common.Data.DataItem.ItemConfig item, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.AttrData> attrs); // 0x0669a734
	static System.Void FillAttr_Food(WizardGames.Soc.Common.Data.DataItem.ItemConfig item, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.AttrData> attrs); // 0x0669aed8
	static System.Void FillAttr_Medical(WizardGames.Soc.Common.Data.DataItem.ItemConfig item, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.AttrData> attrs); // 0x0669b214
	static System.Void FillAttr_Cloth(WizardGames.Soc.Common.Data.DataItem.ItemConfig item, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.AttrData> attrs); // 0x0669b5d4
	static System.Void FillAttr_PetCloth(WizardGames.Soc.Common.Data.DataItem.ItemConfig item, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.AttrData> attrs); // 0x0669ba10
	static System.Void FillAttr_ThrownExplosive(WizardGames.Soc.Common.Data.DataItem.ItemConfig item, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.AttrData> attrs); // 0x0669c270
	static System.Void FillAttr_AmmoExplosive(WizardGames.Soc.Common.Data.DataItem.ItemConfig item, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.AttrData> attrs); // 0x0669cb7c
	static System.Void FillAttr_Ammo(WizardGames.Soc.Common.Data.DataItem.ItemConfig item, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.AttrData> attrs); // 0x0669d1ac
	static System.Void FillAttr_Electric(WizardGames.Soc.Common.Data.DataItem.ItemConfig item, WizardGames.Soc.Common.CustomType.BaseItemNode itemInst, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.AttrData> attrs); // 0x0669d5ec
	static System.Void FillAttr_Vehicle(WizardGames.Soc.Common.Data.DataItem.ItemConfig item, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.AttrData> attrs); // 0x0669d9c4
	static System.Void FillAttr_Vehicle_Addition(WizardGames.Soc.SocClient.Ui.ItemAttrEnum itemAttrEnum, System.Single value, System.Int32 tier, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.AttrData> attrs); // 0x0669dca8
	static System.Void .cctor(); // 0x0669de74
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Ui.ICondParser : 
{
	
	System.Boolean Parse(System.String cond, System.Collections.Generic.List<System.String> vals); // 0x054e0cf4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ConditionParser : System.Object
{
	static SocLogger logger; // 0x0
	static System.Text.StringBuilder replaceStrBuilder; // 0x8
	static System.Int32 fieldIndex; // 0x10
	static System.Text.RegularExpressions.Regex regexSign1; // 0x18
	static System.Text.RegularExpressions.Regex regexSign2; // 0x20
	static System.Text.RegularExpressions.Regex regexConds; // 0x28
	static System.Collections.Generic.List<System.String> subStrs; // 0x30
	static System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.ConditionParser.FieldData> fieldQueue; // 0x38
	static System.Collections.Generic.Stack<WizardGames.Soc.SocClient.Ui.ConditionParser.FieldData> fieldStack; // 0x40
	static System.Collections.Generic.Stack<System.Boolean> opValStack; // 0x48
	static System.Collections.Generic.Stack<System.Char> operatorStack; // 0x50
	static System.Collections.Generic.Dictionary<System.Char,System.Int32> op2Weight; // 0x58
	static WizardGames.Soc.SocClient.Ui.ICondParser parser; // 0x60
	static System.Void SetParser(WizardGames.Soc.SocClient.Ui.ICondParser p); // 0x0669e080
	static System.Boolean IsCondTrue(System.Int32 condId); // 0x0669e114
	static System.String GenerateBoolStr(WizardGames.Soc.Common.Data.Ui.Condition condData); // 0x0669e2b4
	static System.Boolean ParseFields(System.String rootStr); // 0x0669e6c8
	static System.Boolean ProcessFieldStack(); // 0x0669ee1c
	static System.Boolean DoField(System.String strField); // 0x0669f1b0
	static System.Boolean IsHigherPrecedence(System.Char op1, System.Char op2); // 0x0669f7dc
	static System.Void ApplyOperatorWithCurStack(); // 0x0669f570
	static System.Void .cctor(); // 0x0669f8e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ConditionParser.FieldData : System.Object
{
	static System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.ConditionParser.FieldData> pool; // 0x0
	System.Int32 index; // 0x10
	WizardGames.Soc.SocClient.Ui.ConditionParser.FieldData parent; // 0x18
	System.String field; // 0x20
	static WizardGames.Soc.SocClient.Ui.ConditionParser.FieldData Get(System.Int32 index, WizardGames.Soc.SocClient.Ui.ConditionParser.FieldData parent, System.String field); // 0x0669f06c
	static System.Void Return(WizardGames.Soc.SocClient.Ui.ConditionParser.FieldData data); // 0x0669f4bc
	System.Void .ctor(); // 0x0669fd34
	static System.Void .cctor(); // 0x0669fda4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.HyperlinkUtil : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32> urlDic; // 0x8
	static System.Void OpenUrl(System.String url); // 0x0669fe3c
	static System.Void OpenServiceUrl(System.String url); // 0x066a0450
	static System.Void Open(System.String kfurl); // 0x066a11e4
	static System.Boolean IsSurveyUrl(System.String url); // 0x0669ff3c
	static System.String CompleteSurveyUrl(System.String url); // 0x066a0030
	static System.Boolean IsQQInstalled(); // 0x066a10b4
	static System.Boolean IsWxInstalled(); // 0x066a114c
	static System.String GetUrl(System.Int32 urlId); // 0x066a1284
	static System.Void .cctor(); // 0x066a1504
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SocGLoader : FairyGUI.GLoader
{
	static UnityEngine.MonoBehaviour monoStage; // 0x0
	System.String curReqUrl; // 0x250
	FairyGUI.NTexture curReqRes; // 0x258
	UnityEngine.Coroutine curReqCo; // 0x260
	System.Void ClearReqCache(); // 0x066a16b0
	System.Void LoadExternal(); // 0x066a17c0
	System.Void FreeExternal(FairyGUI.NTexture texture); // 0x066a1b20
	System.Void LoadHttpTexture(); // 0x066a18b4
	System.Collections.IEnumerator CoLoadHttpTexture(); // 0x066a1c38
	System.Void OnLoadRes(FairyGUI.NTexture nt); // 0x066a1ba0
	System.Void .ctor(); // 0x066a1d60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SocGLoader.<CoLoadHttpTexture>d__8 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Ui.SocGLoader <>4__this; // 0x20
	UnityEngine.Networking.UnityWebRequest <www>5__2; // 0x28
	System.Void .ctor(System.Int32 <>1__state); // 0x066a1cdc
	System.Void System.IDisposable.Dispose(); // 0x066a1dc8
	System.Boolean MoveNext(); // 0x066a1e4c
	System.Void <>m__Finally1(); // 0x066a2254
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x066a2330
	System.Void System.Collections.IEnumerator.Reset(); // 0x066a2394
	System.Object System.Collections.IEnumerator.get_Current(); // 0x066a241c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SocHtmlPageContext : FairyGUI.Utils.HtmlPageContext
{
	static SocLogger logger; // 0x0
	UnityEngine.MonoBehaviour monoStage; // 0x40
	System.Collections.Generic.Dictionary<System.String,UnityEngine.Coroutine> loadingCo; // 0x48
	System.Collections.Generic.Dictionary<System.String,FairyGUI.NTexture> loadedNT; // 0x50
	System.Boolean skipNetTextureFree; // 0x58
	System.Boolean autoFreeTexture; // 0x59
	FairyGUI.GRichTextField bindRichTextField; // 0x60
	System.Void Bind(FairyGUI.GRichTextField textField, System.Boolean autoFreeTexture); // 0x066a2480
	System.Void RefreshBindText(); // 0x066a25c4
	System.Collections.IEnumerator CoLoadHttpTexture(System.String path); // 0x066a2640
	System.Void StopPreLoadImageFrom(System.String path); // 0x066a278c
	System.Void StartPreLoadImageFrom(System.String path); // 0x066a28e0
	System.String GetNetImagePathFromElem(FairyGUI.Utils.HtmlElement elem); // 0x066a2ae4
	FairyGUI.Utils.IHtmlObject CreateObject(FairyGUI.RichTextField owner, FairyGUI.Utils.HtmlElement element); // 0x066a2bcc
	FairyGUI.NTexture GetImageTexture(FairyGUI.Utils.HtmlImage image); // 0x066a2d00
	System.Void FreeImageTexture(FairyGUI.Utils.HtmlImage image, FairyGUI.NTexture texture); // 0x066a2e4c
	System.Void FreeAllImageTexture(); // 0x066a2fd0
	System.Void .ctor(); // 0x066a3204
	static System.Void .cctor(); // 0x066a3318
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SocHtmlPageContext.<CoLoadHttpTexture>d__10 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.String path; // 0x20
	WizardGames.Soc.SocClient.Ui.SocHtmlPageContext <>4__this; // 0x28
	System.Int32 <curCount>5__2; // 0x30
	UnityEngine.Networking.UnityWebRequest <www>5__3; // 0x38
	System.Void .ctor(System.Int32 <>1__state); // 0x066a2708
	System.Void System.IDisposable.Dispose(); // 0x066a33ec
	System.Boolean MoveNext(); // 0x066a3470
	System.Void <>m__Finally1(); // 0x066a38a0
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x066a397c
	System.Void System.Collections.IEnumerator.Reset(); // 0x066a39e0
	System.Object System.Collections.IEnumerator.get_Current(); // 0x066a3a68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SortUtils : System.Object
{
	
	static System.Void Sort<T>(System.Collections.Generic.List<T> list, System.Func<T,T,System.Int32> comparer); // 0x052af1f0
	static System.Void Heapify<T>(System.Collections.Generic.List<T> list, System.Int32 n, System.Int32 i, System.Func<T,T,System.Int32> comparer); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.EnhancedTip : System.Object
{
	System.Int64 targetEntityId; // 0x10
	UnityEngine.GameObject targetGo; // 0x18
	UnityEngine.Vector3 worldPos; // 0x20
	System.Single heightOffset; // 0x2c
	System.Boolean canCovered; // 0x30
	System.Single brightness; // 0x34
	System.String iconUrl; // 0x38
	System.Boolean isInCamera; // 0x40
	System.Boolean isCovered; // 0x41
	UnityEngine.Transform localEyePos; // 0x48
	WizardGames.Soc.SocClient.Ui.ComEnhancedTip enhancedTipCom; // 0x50
	UnityEngine.Vector3 localGeometricCenter; // 0x58
	UnityEngine.Vector3 get_WorldPos(); // 0x066a3acc
	System.Void Refresh(); // 0x066a3b84
	System.Boolean IsExistGo(); // 0x066a3c64
	System.Boolean HorseIsLive(); // 0x066a3dfc
	System.Void Show(); // 0x066a4094
	System.Void Hide(); // 0x066a3f84
	System.Void RefreshTipCom(); // 0x066a4008
	System.Void OnGetFromPool(System.Int64 entityId, UnityEngine.GameObject go); // 0x066a41bc
	System.Void OnReturnPool(); // 0x066a4434
	System.Boolean CanShowIgnoreCover(); // 0x066a4588
	System.Void SetWorldPos(UnityEngine.Vector3 pos); // 0x066a4680
	UnityEngine.Vector3 CalcLocalGeometricCenter(WizardGames.Soc.Common.Unity.Go.BaseEntityGo entityGo); // 0x066a4720
	System.Void .ctor(); // 0x066a4f74
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.HpBarInfo : System.ValueType
{
	System.Int64 TargetId; // 0x10
	System.Int32 TargetType; // 0x18
	System.Single Distance; // 0x1c
	System.Int32 ShowLimit; // 0x20
	System.Single InitHp; // 0x24
	static WizardGames.Soc.SocClient.Ui.HpBarInfo Create(WizardGames.Soc.Common.SimpleCustom.DamageDataEvent e); // 0x066a5094
	static WizardGames.Soc.SocClient.Ui.HpBarInfo Create(WizardGames.Soc.Common.Entity.IEntity target, System.Single dis); // 0x066a5264
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.HitHpBarController : System.Object
{
	static SocLogger logger; // 0x0
	System.Single ShowTimeConfig; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.HpBarInfo> WaitingList; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.HpBarInfo> FinalWaitingList; // 0x20
	System.Collections.Generic.HashSet<System.Int64> ExistTarget; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComWorldFlagNewBloodBar> ShowingList; // 0x30
	WizardGames.Soc.SocClient.Ui.ComWorldFlagNewBloodBar <FocusBloodBar>k__BackingField; // 0x38
	static System.Comparison<WizardGames.Soc.SocClient.Ui.HpBarInfo> comparisonHpBar; // 0x8
	WizardGames.Soc.SocClient.Ui.ComWorldFlagNewBloodBar get_FocusBloodBar(); // 0x066a54a0
	System.Void set_FocusBloodBar(WizardGames.Soc.SocClient.Ui.ComWorldFlagNewBloodBar value); // 0x066a5504
	System.Void .ctor(); // 0x066a5584
	System.Void ObserverAddBarInfo(WizardGames.Soc.SocClient.Ui.HpBarInfo info); // 0x066a581c
	System.Boolean TryAddHitBarInfo(WizardGames.Soc.SocClient.Ui.HpBarInfo info, System.Int32 damageType, System.Int32 killType); // 0x066a59a8
	System.Boolean TryAddAimBarInfo(WizardGames.Soc.SocClient.Ui.HpBarInfo info); // 0x066a5f50
	System.Void ClearFocusBloodBar(); // 0x066a5df0
	System.Void HandleHitHpBar(System.Single dt); // 0x066a6428
	WizardGames.Soc.SocClient.Ui.ComWorldFlagNewBloodBar DoCreateBlood(WizardGames.Soc.SocClient.Ui.HpBarInfo info); // 0x066a6228
	System.Void Release(); // 0x066a6be0
	static System.Void .cctor(); // 0x066a6e98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.HitHpBarController.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.HitHpBarController.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x066a6ffc
	System.Void .ctor(); // 0x066a7060
	System.Int32 <.cctor>b__19_0(WizardGames.Soc.SocClient.Ui.HpBarInfo a, WizardGames.Soc.SocClient.Ui.HpBarInfo b); // 0x066a70c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrWorldFlag : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.WorldFlagCollector worldFlagCollector; // 0x18
	WizardGames.Soc.SocClient.Ui.HitHpBarController HitHpBarController; // 0x20
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.ComWorldFlagPart> worldSpaceFlagDic; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.ComWorldFlagLabel> labelFlagDic; // 0x30
	System.String uiRootKey; // 0x38
	System.String worldElectricalFlag; // 0x40
	System.Single focusStartTime; // 0x48
	WizardGames.Soc.SocClient.Ui.ComEntityGuideFlag guideFlag; // 0x50
	System.Int64 timerId; // 0x58
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.EnhancedTip> enhancedTipDic; // 0x60
	System.Collections.Generic.Dictionary<System.Int64,System.Single> showingDistanceDic; // 0x68
	System.Collections.Generic.HashSet<System.Int64> showingObjectHashSet; // 0x70
	System.Collections.Generic.HashSet<System.Int64> lastShowingObjectHashSet; // 0x78
	System.Collections.Generic.List<System.Int64> waitRemoveList; // 0x80
	UnityEngine.Ray coverCheckRay; // 0x88
	System.Int32 frameCountCache; // 0xa0
	System.Int32 showNumCache; // 0xa4
	System.Collections.Generic.Stack<FairyGUI.GComponent> enhancedTipComCache; // 0xa8
	System.Int32 rayCheckDistance; // 0xb0
	System.Int32 tipNumMax; // 0xb4
	System.Int32 instanceIdBatches; // 0xb8
	UnityEngine.RaycastHit[] hitInfos; // 0xc0
	System.Collections.Generic.List<UnityEngine.RaycastHit> hitFilterInfos; // 0xc8
	System.Void Init(); // 0x066a7288
	System.Threading.Tasks.Task OnEnterWorld(); // 0x066a78a4
	System.Threading.Tasks.Task OnExitWorld(); // 0x066a7f60
	System.Void OnFps10Update(System.Single dt); // 0x066a880c
	System.Void HandleFocusBloodBar(System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData> hitObjDataList, WizardGames.Soc.SocClient.Systems.HitObjData obstacle); // 0x066a90a4
	System.Void OnShowHpBarChanged(); // 0x066a9818
	System.Void AddWorldFlag(System.Int64 id); // 0x066a9964
	System.Void RemoveWorldFlag(System.Int64 id); // 0x066a9c30
	System.Void UpdateWorldFlag(System.Single dt); // 0x066a8a78
	System.Void UpdateLabel(System.Single dt); // 0x066a8ce0
	System.Void AddLabel(System.Int64 entityId); // 0x066a9d1c
	System.Void RemoveLabel(System.Int64 id); // 0x066a9ed8
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.ComWorldFlagLabel> GetLabelDic(); // 0x066a9fb0
	System.Void SetFocusShowLabel(System.Int64 entityId, System.Boolean isFocus); // 0x066aa014
	System.Void AddEntityGuideFlag(System.Int32 guideId, System.Int64 entityId); // 0x05507378
	System.Void RemoveEntityGuideFlag(); // 0x066aa608
	System.Void UpdateEntityGuideFlag(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x066aa714
	System.Boolean HasEntityGuide(); // 0x066aa7c8
	System.Void InitEnhancedTip(); // 0x066a76ec
	System.Void OnExitWorldEnhancedTip(); // 0x066a8700
	System.Void AddEnhancedTip(Systems.EnhancedDisplayUnitData data); // 0x066aa834
	System.Void RemoveEnhancedTip(Systems.EnhancedDisplayUnitData data); // 0x066aabf0
	System.Int64 GetInstanceID(Systems.EnhancedDisplayUnitData data); // 0x066aaa68
	System.Void UpdateEnhancedTip(System.Single dt); // 0x066a8e74
	System.Void InitializeCollections(); // 0x066ab0a8
	System.Boolean IsEnhancedTipDicEmpty(); // 0x066ab150
	System.Void ProcessEnhancedTips(UnityEngine.Vector3 origin); // 0x066ab1e4
	System.Void RemoveExcessTips(UnityEngine.Vector3 origin); // 0x066ab4dc
	System.Int64 FindMinDistance(System.Single& minDistance); // 0x066abc04
	System.Void CameraCheck(WizardGames.Soc.SocClient.Ui.EnhancedTip enhancedTip); // 0x066ab890
	System.Void CoverCheck(WizardGames.Soc.SocClient.Ui.EnhancedTip enhancedTip, UnityEngine.Vector3 origin); // 0x066abdec
	System.Boolean IsCameraFrontVisible(UnityEngine.Vector3 worldPos, UnityEngine.Transform camTransform); // 0x066ac4a0
	System.Boolean IsCovered(UnityEngine.RaycastHit hitInfo, UnityEngine.Vector3 origin, UnityEngine.Vector3 targetPos, UnityEngine.GameObject targetGo); // 0x066ac6fc
	FairyGUI.GComponent TryGetFromPool(); // 0x066acb74
	System.Void ReturnPool(FairyGUI.GComponent com); // 0x066acc20
	System.Void ClearPool(); // 0x066965bc
	System.Void .ctor(); // 0x066accfc
	static System.Void .cctor(); // 0x066acf4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrWorldFlag.<>c__DisplayClass13_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.HpBarInfo info; // 0x10
	System.Void .ctor(); // 0x066a97b0
	System.Void <HandleFocusBloodBar>b__0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x066ad020
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.EnhancedTipPool : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	
	System.Void .ctor(); // 0x066ad10c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiThirdInfo : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.UiThirdInfoComponent> uiThirdInfoComDict; // 0x338
	System.Collections.Generic.List<System.Int64> deleteList; // 0x340
	System.Single disappearCountDown; // 0x348
	System.Void .ctor(); // 0x066ad174
	System.Void OnEnable(); // 0x066ad2a4
	System.Void OnDestroy(); // 0x066ad314
	System.Void OnFps30Update(System.Single dt); // 0x066ad5b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiThirdInfoComponent : FairyGUI.GComponent
{
	
	System.Void .ctor(); // 0x066ad6e4
	System.Void Hide(); // 0x066ad550
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.WorldFlagCollector : System.Object
{
	SocLogger logger; // 0x10
	System.Collections.Generic.List<System.Int64> disappearHpCacheList; // 0x18
	System.Collections.Generic.HashSet<System.Int64> buildingCacheSetWithUiPanel; // 0x20
	System.Collections.Generic.Dictionary<System.Int64,UnityEngine.Transform> cachedFlagTransforms; // 0x28
	System.Collections.Generic.List<System.Int64> toAddWorldFlagList; // 0x30
	System.Collections.Generic.SortedDictionary<System.Single,WizardGames.Soc.SocClient.Ui.DamageDataForUi> sortedHpCache; // 0x38
	PriorityQueue<WizardGames.Soc.SocClient.Ui.DamageDataForUi> damagePriorityQueue; // 0x40
	System.Collections.Generic.List<System.Int64> removeItemLst; // 0x48
	System.Action<WizardGames.Soc.SocClient.Ui.DamageDataForUi> onAddHp; // 0x50
	System.Action<System.Int64> onRemoveHp; // 0x58
	System.Action<System.Int64> onAddWorldFlag; // 0x60
	System.Action<System.Int64> onRemoveWorldFlag; // 0x68
	System.Action<System.Int64> onAddLabel; // 0x70
	System.Action<System.Int64> onRemoveLabel; // 0x78
	System.String uiRootKey; // 0x80
	System.Void .ctor(); // 0x066a73dc
	System.Void Init(); // 0x066a7c50
	System.Void Clear(); // 0x066a8334
	System.Void OnGoAdded(WizardGames.Soc.Common.Unity.Go.IEntityGo go); // 0x066ad75c
	System.Void OnRemoveGo(System.Int64 entityId); // 0x066adab8
	System.Void FilterBuildingCacheSetWithUiPanel(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x066ad8c0
	System.Void Handle(); // 0x066a8a0c
	System.Void HandleBuilding(); // 0x066adc68
	System.Void HandleLabel(); // 0x066ae274
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.DamageDataForUi : System.ValueType
{
	System.Single damage; // 0x10
	System.Int64 targetId; // 0x18
	System.String IconUrl; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.VehicleInfo.MgrVehicleInfo : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Int64 <MountUIStatus>k__BackingField; // 0x18
	System.Collections.Generic.List<System.String> ShowUINames; // 0x20
	System.Collections.Generic.List<System.String> HideUINames; // 0x28
	System.Collections.Generic.List<System.String> NeedCloseUINames; // 0x30
	System.Void set_MountUIStatus(System.Int64 value); // 0x066ae640
	System.Int64 get_MountUIStatus(); // 0x066ae6b8
	System.Void Init(); // 0x066ae71c
	System.Threading.Tasks.Task AfterEnterWorld(); // 0x066ae870
	System.Threading.Tasks.Task OnExitWorld(); // 0x066aec18
	System.Void RegisterVehicleEvent(); // 0x066ae92c
	System.Void UnregisterVehicleEvent(); // 0x066aec88
	System.Void OnPhotoModeEntered(); // 0x066aeec4
	System.Void OnPhotoModeExited(); // 0x066af220
	System.Void OnMountableChanged(System.Int64 mountableId); // 0x066aef74
	System.Void OnSeatChanged(System.Boolean isDriver, System.Int64 mountableId); // 0x066af5f8
	System.Void OpenVehicleInfo(); // 0x066af2d0
	System.Void OpenVehicleSeekingInfo(); // 0x066af3a8
	System.Void CloseVehicleSeekingInfo(); // 0x066af540
	System.Void CloseVehicleInfo(); // 0x066af480
	System.Void ClearUINames(); // 0x066afe24
	System.Void .ctor(); // 0x066aff20
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.VendingMachineCom.OpenType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.VendingMachineCom.OpenType Add = 0;
	static WizardGames.Soc.SocClient.Ui.VendingMachineCom.OpenType Change = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComChangeOrder : System.Object
{
	FairyGUI.GComponent node; // 0x10
	FairyGUI.GButton btnConfirm; // 0x18
	WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComOrderItemIcon saleItem; // 0x20
	WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComOrderItemIcon priceItem; // 0x28
	WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComSlider priceItemSlider; // 0x30
	WizardGames.Soc.SocClient.Ui.UiShopUpload uiShopUpload; // 0x38
	FairyGUI.GButton btnAdd; // 0x40
	FairyGUI.GButton btnAddNew; // 0x48
	FairyGUI.Controller btnAddController; // 0x50
	FairyGUI.Controller btnAddNewController; // 0x58
	FairyGUI.GButton btnDelete; // 0x60
	FairyGUI.Controller orderState; // 0x68
	WizardGames.Soc.SocClient.Ui.EditPriceItem curEditPriceItem; // 0x70
	FairyGUI.Transition showTransition; // 0x78
	FairyGUI.Transition hideTransition; // 0x80
	System.Void .ctor(FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.UiShopUpload shopUpload); // 0x066aff88
	System.Void SetIcon(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemConfig); // 0x066b0a74
	System.Void RefreshBtnState(); // 0x066b0c44
	System.Void OnClickCloseCom(); // 0x066b12b0
	System.Void OnClickDelete(); // 0x066b1818
	System.Void OnClickConfirm(); // 0x066b18a8
	System.Void OnClickAdd(); // 0x066b1d08
	System.Void OnClickAddNew(); // 0x066b20b8
	System.Void AddOrder(); // 0x066b1d80
	System.Void SetVisible(System.Boolean isVisible, WizardGames.Soc.SocClient.Ui.VendingMachineCom.OpenType openType, System.Int32 editItemId); // 0x066b1320
	System.Void <.ctor>b__15_0(FairyGUI.EventContext ctx); // 0x066b21e4
	System.Void <.ctor>b__15_1(FairyGUI.EventContext ctx); // 0x066b225c
	System.Void <RefreshBtnState>b__17_2(FairyGUI.EventContext ctx); // 0x066b22d4
	System.Void <RefreshBtnState>b__17_4(FairyGUI.EventContext ctx); // 0x066b234c
	System.Void <SetVisible>b__24_0(); // 0x066b23c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComChangeOrder.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComChangeOrder.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__17_0; // 0x8
	static FairyGUI.EventCallback1 <>9__17_1; // 0x10
	static FairyGUI.EventCallback1 <>9__17_3; // 0x18
	static System.Void .cctor(); // 0x066b2438
	System.Void .ctor(); // 0x066b249c
	System.Void <RefreshBtnState>b__17_0(FairyGUI.EventContext ctx); // 0x066b2504
	System.Void <RefreshBtnState>b__17_1(FairyGUI.EventContext ctx); // 0x066b2578
	System.Void <RefreshBtnState>b__17_3(FairyGUI.EventContext ctx); // 0x066b25ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComOrderItemIcon : System.Object
{
	System.Int64 ItemBizId; // 0x10
	FairyGUI.GComponent node; // 0x18
	WizardGames.Soc.SocClient.Ui.ComItemIcon comItemIcon; // 0x20
	FairyGUI.GButton btnAddItem; // 0x28
	FairyGUI.GButton btnCancel; // 0x30
	FairyGUI.Controller saleItemShowController; // 0x38
	System.Int32 index; // 0x40
	WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComSlider slider; // 0x48
	System.Void .ctor(FairyGUI.GComponent com, System.Int32 index, WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComSlider slider); // 0x066b067c
	System.Void OnClickIcon(WizardGames.Soc.SocClient.Ui.ComBaseIcon comItemIcon); // 0x066b27bc
	System.Void SetIcon(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemConfig); // 0x066b0b3c
	System.Void OnClickAddItem(); // 0x066b2834
	System.Void SetEmpty(); // 0x066b211c
	System.Void <.ctor>b__8_0(FairyGUI.EventContext ctx); // 0x066b290c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.VendingMachineCom.ItemTypeClass : System.Object
{
	System.Int32 Id; // 0x10
	System.Int32 Count; // 0x14
	System.String Name; // 0x18
	System.Void .ctor(System.Int32 id, System.Int32 count, System.String name); // 0x066b2984
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComSelectItem : System.Object
{
	FairyGUI.GComponent node; // 0x10
	WizardGames.Soc.SocClient.Ui.ComStateBtn btnConfirm; // 0x18
	FairyGUI.GButton btnInStock; // 0x20
	FairyGUI.GLoader bg; // 0x28
	FairyGUI.GButton btnExpand; // 0x30
	FairyGUI.GTextField textClassName; // 0x38
	FairyGUI.GTextField textClassNum; // 0x40
	FairyGUI.GList listClass; // 0x48
	WizardGames.Soc.SocClient.Ui.ComSearch comSearch; // 0x50
	FairyGUI.GComponent comSearchNode; // 0x58
	FairyGUI.GList listIcons; // 0x60
	FairyGUI.Transition showTransition; // 0x68
	FairyGUI.Transition hideTransition; // 0x70
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.ItemConfig> normalDataList; // 0x78
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.ItemConfig> showDataList; // 0x80
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.DataItem.ItemConfig,System.Int32> showDataDic; // 0x88
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.DataItem.ItemConfig,System.Int32> normalDataDic; // 0x90
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.VendingMachineCom.ItemTypeClass> classDic; // 0x98
	WizardGames.Soc.SocClient.Ui.UiShopUpload uiShopUpload; // 0xa0
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.ItemConfig> stockDataList; // 0xa8
	System.Int32 curSelectIndex; // 0xb0
	System.Int32 get_CurSelectIndex(); // 0x066b2a38
	System.Void set_CurSelectIndex(System.Int32 value); // 0x066b2a9c
	System.Void .ctor(FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.UiShopUpload uiShopUpload); // 0x066b2c84
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x066b40f8
	System.Void InitBtnExpand(); // 0x066b3e40
	System.Void RefreshClassData(); // 0x066b4594
	System.Void OnClickSearch(System.String searchStr); // 0x066b49b0
	System.Void OnClickClearText(); // 0x066b4e5c
	System.Void OnClickChangeClass(System.Int32 classId); // 0x066b521c
	System.Void SetBtnExpandTitle(System.Int32 classId); // 0x066b4490
	System.Void SetVisible(System.Boolean isVisible); // 0x066b5788
	System.Void OnClickItem(FairyGUI.EventContext context); // 0x066b58ec
	System.Void OnClickInStock(FairyGUI.EventContext context); // 0x066b5bc8
	System.Void OnClickExpand(FairyGUI.EventContext context); // 0x066b66e8
	System.Void UpdateList(); // 0x066b4d9c
	System.Void OnClickCloseCom(FairyGUI.EventContext context); // 0x066b67c4
	System.Void OnClickCloseTip(FairyGUI.EventContext context); // 0x066b6840
	System.Void OnClickConfirm(FairyGUI.EventContext context); // 0x066b68fc
	System.Void InitData(); // 0x066b3588
	System.Void InitStockData(); // 0x066b5cf4
	System.Void <SetVisible>b__32_0(); // 0x066b6a50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComSelectItem.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComSelectItem.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__23_0; // 0x8
	static System.Void .cctor(); // 0x066b6c78
	System.Void .ctor(); // 0x066b6cdc
	System.Void <set_CurSelectIndex>b__23_0(FairyGUI.EventContext ctx); // 0x066b6d44
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComSelectItem.<>c__DisplayClass27_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.VendingMachineCom.ItemTypeClass classData; // 0x10
	WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComSelectItem <>4__this; // 0x18
	System.Void .ctor(); // 0x066b6db8
	System.Void <RefreshClassData>b__0(FairyGUI.EventContext ctx); // 0x066b6e20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComSlider : System.Object
{
	FairyGUI.GComponent node; // 0x10
	System.Int32 num; // 0x18
	FairyGUI.GSlider slider; // 0x20
	FairyGUI.GButton btnAdd; // 0x28
	FairyGUI.GButton btnReduce; // 0x30
	FairyGUI.GButton btnMax; // 0x38
	FairyGUI.GTextInput textInput; // 0x40
	UnityEngine.Vector2 CounterPos; // 0x48
	System.Int32 get_Num(); // 0x066b6eb0
	System.Void set_Num(System.Int32 value); // 0x066b6f14
	System.Void .ctor(FairyGUI.GComponent com); // 0x066b6fec
	System.Void OnClickSlider(); // 0x066b7620
	System.Void SetSliderValue(System.Int32 value); // 0x066b77a4
	System.Void OnSliderChange(); // 0x066b7840
	System.Void SetVisible(System.Boolean isVisible); // 0x066b7910
	System.Void OnTextInputChange(); // 0x066b79b8
	System.Void OnClickBuyNumReduceBtn(FairyGUI.EventContext context); // 0x066b7bf0
	System.Void OnClickBuyNumAddBtn(FairyGUI.EventContext context); // 0x066b7e44
	System.Void OnClickBuyNumMaxBtn(FairyGUI.EventContext context); // 0x066b8098
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComSlider.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComSlider.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__11_0; // 0x8
	static System.Void .cctor(); // 0x066b82e4
	System.Void .ctor(); // 0x066b8348
	System.Void <.ctor>b__11_0(); // 0x066b83b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.VendingMachineCom.StockItemConfig : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemConfig itemConfig; // 0x10
	System.Int32 stock; // 0x18
	System.Void .ctor(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemConfig, System.Int32 stock); // 0x066b84e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComStockManagement : System.Object
{
	FairyGUI.GComponent node; // 0x10
	WizardGames.Soc.SocClient.Ui.ComSearch comSearch; // 0x18
	FairyGUI.GList listItems; // 0x20
	System.Collections.Generic.List<System.Int64> inventoryPath; // 0x28
	System.Collections.Generic.List<System.Int64> shopPath; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.VendingMachineCom.StockItemConfig> dataList; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.VendingMachineCom.StockItemConfig> showDataList; // 0x40
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> curOwnedResAmountDic; // 0x48
	WizardGames.Soc.SocClient.Ui.UiShopUpload uiShopUpload; // 0x50
	FairyGUI.Controller showControl; // 0x58
	FairyGUI.Transition showTransition; // 0x60
	FairyGUI.Transition hideTransition; // 0x68
	FairyGUI.GComponent handlePanelCom; // 0x70
	WizardGames.Soc.SocClient.Ui.UiResHandle uiResHandle; // 0x78
	WizardGames.Soc.Common.CustomType.ItemContainerNode itemContainerNode; // 0x80
	FairyGUI.GButton btnClose; // 0x88
	System.Void .ctor(FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.UiShopUpload uiShopUpload); // 0x066b857c
	System.Void InitUI(); // 0x066b8ce4
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x066b8d74
	System.Void OnClickSearch(System.String searchStr); // 0x066b923c
	System.Void OnClickClearText(); // 0x066b9644
	System.Void SetVisible(System.Boolean isVisible); // 0x066b9864
	System.Void Refresh(); // 0x066b9b54
	System.Void OnClickItem(FairyGUI.EventContext context, System.Int64 itemId, System.Boolean isAdd); // 0x066ba248
	System.Void SetHandleBtn(System.Int64 itemId); // 0x066ba480
	System.Void TransFerItem(System.Int64 itemId); // 0x066ba66c
	System.Void RefreshItemDic(WizardGames.Soc.SocClient.Ui.EResHandleType handleType); // 0x066ba7e0
	System.Void UpdateList(); // 0x066b9590
	System.Void OnClickCloseCom(FairyGUI.EventContext context); // 0x066baab0
	System.Void UpdateResHandle(System.Single dt); // 0x066bab2c
	System.Boolean <SetVisible>b__21_0(); // 0x066babbc
	System.Void <SetVisible>b__21_1(); // 0x066bac40
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComStockManagement.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComStockManagement.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.VendingMachineCom.StockItemConfig> <>9__22_0; // 0x8
	static System.Void .cctor(); // 0x066bacb4
	System.Void .ctor(); // 0x066bad18
	System.Int32 <Refresh>b__22_0(WizardGames.Soc.SocClient.Ui.VendingMachineCom.StockItemConfig a, WizardGames.Soc.SocClient.Ui.VendingMachineCom.StockItemConfig b); // 0x066bad80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComStockManagement.<>c__DisplayClass18_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComStockManagement <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.VendingMachineCom.StockItemConfig data; // 0x18
	System.Void .ctor(); // 0x066b91d4
	System.Void <RenderListItem>b__0(FairyGUI.EventContext ctx); // 0x066bae14
	System.Void <RenderListItem>b__1(FairyGUI.EventContext ctx); // 0x066baeb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComStockManagement.<>c__DisplayClass24_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComStockManagement <>4__this; // 0x10
	System.Int64 itemId; // 0x18
	System.Void .ctor(); // 0x066ba604
	System.Void <SetHandleBtn>b__0(); // 0x066baf4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Marker.GuideLine : System.Object
{
	FairyGUI.GComponent com; // 0x10
	FairyGUI.GLoader line; // 0x18
	System.Void .ctor(FairyGUI.GComponent parent, System.String iconUrl); // 0x066bafbc
	System.Void UpdateFromStage(WizardGames.Soc.SocClient.Marker.IMarker start, WizardGames.Soc.SocClient.Marker.IMarker end); // 0x066bb1bc
	System.Boolean get_Active(); // 0x066bb460
	System.Void set_Active(System.Boolean value); // 0x066bb504
	System.Void Dispose(); // 0x066bb5fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Marker.MapRoad : System.Object
{
	FairyGUI.GComponent container; // 0x10
	WizardGames.Soc.SocClient.Ui.Map.MapBase map; // 0x18
	System.Collections.Generic.List<UnityEngine.Vector3> roadPoints; // 0x20
	System.Single roadLength; // 0x28
	System.Boolean isDrawed; // 0x2c
	FairyGUI.GLoader RoadDrawBoardLoader; // 0x30
	UnityEngine.Mesh roadMesh; // 0x38
	System.Single startPos; // 0x40
	System.Int64 timerId; // 0x48
	System.Void .ctor(FairyGUI.GComponent parent, WizardGames.Soc.SocClient.Ui.Map.MapBase map, UnityEngine.Vector2 containerSize); // 0x0552cfa0
	System.Void CheckProgress(System.Int64 timerId, System.Object obj, System.Boolean needDelete); // 0x066bbe70
	System.Void DrawRoad(); // 0x066bc238
	System.Void OnMainMapViewScaleChanged(System.Single oldScale, System.Single newScale); // 0x066bcf94
	System.Void ShowRoad(System.Boolean IsRefshRoadBeginPos); // 0x066bbdb0
	System.Void HideRoad(); // 0x066bbd3c
	System.Void OnMarkerDataCreate(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x066bd028
	System.Void OnMarkerDataRemove(System.Int64 id); // 0x066bd10c
	System.Void Dispose(); // 0x066bd1f0
	System.Void CreateMesh(System.Collections.Generic.List<UnityEngine.Vector2> points); // 0x066bc678
	System.Void CalRoadBeginPos(); // 0x066bcc78
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Marker.MarkerUtils : System.Object
{
	
	static System.Boolean LineIntersectEllipseZero(UnityEngine.Vector2 endPoint, UnityEngine.Vector2 startPoint, System.Single axisX, System.Single axisY, UnityEngine.Vector2& ptInter1, UnityEngine.Vector2& ptInter2); // 0x066bd5ac
	static System.Boolean LineIntersectEllipse(UnityEngine.Vector2 endPoint, UnityEngine.Vector2 startPoint, UnityEngine.Vector2 center, System.Single axisX, System.Single axisY, UnityEngine.Vector2& ptInter1, UnityEngine.Vector2& ptInter2); // 0x066bd794
	static System.Int32 LineIntersectBox(UnityEngine.Vector2 boxMin, UnityEngine.Vector2 boxMax, UnityEngine.Vector2& s, UnityEngine.Vector2& e); // 0x066bd908
	static System.Single GetSignedAngle(UnityEngine.Vector3 vec, UnityEngine.Vector3 forward, UnityEngine.Vector3 up); // 0x066bdc2c
	static UnityEngine.Vector3 GetScreenPos(UnityEngine.Camera mainCamera, UnityEngine.Transform cameraTransform, UnityEngine.Vector3 worldPos); // 0x066bdf18
	static UnityEngine.Vector3 GetCameraForward(UnityEngine.Transform cameraTransform); // 0x066be244
	static System.Boolean IsInFrontOfPlayer(UnityEngine.Transform cameraTransform, UnityEngine.Vector3 targetPos); // 0x066be0a4
	static System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.Map.SpecialMonumentLayoutInfo> GetSpecialMonumentLayoutInfos(System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.MarkerBaseData> datas); // 0x066be368
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MapBase : System.Object
{
	static SocLogger Log; // 0x0
	FairyGUI.GComponent <MapUiNode>k__BackingField; // 0x10
	System.Single mapScale; // 0x18
	System.Action<System.Single,System.Single> OnMapScaleChanged; // 0x20
	WizardGames.Soc.SocClient.Ui.Map.EMapLevel mapLevel; // 0x28
	System.Action<WizardGames.Soc.SocClient.Ui.Map.EMapLevel,WizardGames.Soc.SocClient.Ui.Map.EMapLevel> OnMapLevelChanged; // 0x30
	System.Action OnMapDrag; // 0x38
	FairyGUI.GComponent get_MapUiNode(); // 0x066be6fc
	System.Void set_MapUiNode(FairyGUI.GComponent value); // 0x066be760
	System.Void Init(FairyGUI.GComponent bindUiNode); // 0x066be7e0
	System.Void OnEnable(); // 0x066be894
	System.Void OnDisable(); // 0x066be8f4
	System.Void OnDestroy(); // 0x066be954
	System.Void OnFpsUnlimitedUpdate(); // 0x066be9b4
	System.Void OnFps30Update(); // 0x066bea14
	System.Void OnFps10Update(); // 0x066bea74
	System.Void OnFps1Update(); // 0x066bead4
	System.Single get_MapScale(); // 0x066beb34
	System.Void set_MapScale(System.Single value); // 0x066beb98
	WizardGames.Soc.SocClient.Ui.Map.EMapLevel get_MapLevel(); // 0x066bec94
	System.Void set_MapLevel(WizardGames.Soc.SocClient.Ui.Map.EMapLevel value); // 0x066becf8
	System.Boolean get_Active(); // 0x054c4760
	System.Void .ctor(); // 0x066beda4
	static System.Void .cctor(); // 0x066bee0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.SidePanelBase : System.Object
{
	SocLogger log; // 0x10
	WizardGames.Soc.SocClient.Ui.Map.ISidePanelMap map; // 0x18
	FairyGUI.GComponent <UiRootNode>k__BackingField; // 0x20
	FairyGUI.GComponent get_UiRootNode(); // 0x066beee0
	System.Void set_UiRootNode(FairyGUI.GComponent value); // 0x066bef44
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.ISidePanelMap map); // 0x066befc4
	System.Void Init(); // 0x066bf0e0
	System.Void InitFairyBatching(); // 0x066bf140
	System.Void OnEnable(); // 0x066bf1f8
	System.Void OnDisable(); // 0x066bf258
	System.Void OnDestroy(); // 0x066bf2b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.SidePanelSubviewBase : System.Object
{
	System.Boolean isInited; // 0x10
	WizardGames.Soc.SocClient.Ui.Map.MainMapSidePanel <parentSidePanel>k__BackingField; // 0x18
	FairyGUI.GComponent <Root>k__BackingField; // 0x20
	FairyGUI.GLoader gLoader; // 0x28
	FairyGUI.Transition showTransition; // 0x30
	FairyGUI.Transition hideTransition; // 0x38
	WizardGames.Soc.SocClient.Ui.Map.ISidePanelMap map; // 0x40
	System.Void set_parentSidePanel(WizardGames.Soc.SocClient.Ui.Map.MainMapSidePanel value); // 0x066bf318
	FairyGUI.GComponent get_Root(); // 0x066bf398
	System.Void set_Root(FairyGUI.GComponent value); // 0x066bf3fc
	System.Boolean get_Active(); // 0x066bf47c
	System.Void Bind(WizardGames.Soc.SocClient.Ui.Map.ISidePanelMap map, WizardGames.Soc.SocClient.Ui.Map.MainMapSidePanel parentPanel, FairyGUI.GLoader rootLoader, System.String name); // 0x066bf568
	System.Void Show(); // 0x066bf870
	System.Void Hide(); // 0x066bf908
	System.Void Refresh(); // 0x066bf994
	System.Void SelectItem(System.Int64 markerId, WizardGames.Soc.Common.Data.MarkerType markerType); // 0x066bf9f4
	System.Void OnInit(); // 0x066bfa70
	System.Void OnEnable(); // 0x066bfad0
	System.Void OnDisable(); // 0x066bfb30
	System.Void OnDestroy(); // 0x066bfb90
	System.Void OnExpand(); // 0x066bfbf0
	System.Void OnCollapse(); // 0x066bfcc8
	System.Void .ctor(); // 0x066bfd84
	System.Void <OnCollapse>b__25_0(); // 0x066bfdec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.ViewBase : System.Object
{
	SocLogger log; // 0x10
	WizardGames.Soc.SocClient.Ui.Map.MapBase map; // 0x18
	FairyGUI.GComponent <UiRootNode>k__BackingField; // 0x20
	FairyGUI.GComponent <ViewContainer>k__BackingField; // 0x28
	FairyGUI.GComponent <MarkerLayer>k__BackingField; // 0x30
	FairyGUI.GComponent <GuideLineLayer>k__BackingField; // 0x38
	FairyGUI.GComponent <RoadLayer>k__BackingField; // 0x40
	FairyGUI.GComponent <GridLayer>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Ui.Marker.GuideLine <GuideLine>k__BackingField; // 0x50
	FairyGUI.GComponent <AreaLayer>k__BackingField; // 0x58
	FairyGUI.GLoader loaderMapTex; // 0x60
	FairyGUI.GLoader metroMapTexLoader; // 0x68
	FairyGUI.NTexture nTexture; // 0x70
	FairyGUI.GImage dummy; // 0x78
	FairyGUI.Controller seaColorCtrl; // 0x80
	System.Collections.Generic.Dictionary<FairyGUI.GImage,UnityEngine.Vector3> layoutImg2Pos; // 0x88
	FairyGUI.GComponent get_UiRootNode(); // 0x066bfeac
	System.Void set_UiRootNode(FairyGUI.GComponent value); // 0x066bff10
	FairyGUI.GComponent get_ViewContainer(); // 0x066bff90
	System.Void set_ViewContainer(FairyGUI.GComponent value); // 0x066bfff4
	FairyGUI.GComponent get_MarkerLayer(); // 0x066c0074
	System.Void set_MarkerLayer(FairyGUI.GComponent value); // 0x066c00d8
	FairyGUI.GComponent get_GuideLineLayer(); // 0x066c0158
	System.Void set_GuideLineLayer(FairyGUI.GComponent value); // 0x066c01bc
	FairyGUI.GComponent get_RoadLayer(); // 0x066c023c
	System.Void set_RoadLayer(FairyGUI.GComponent value); // 0x066c02a0
	FairyGUI.GComponent get_GridLayer(); // 0x066c0320
	System.Void set_GridLayer(FairyGUI.GComponent value); // 0x066c0384
	WizardGames.Soc.SocClient.Ui.Marker.GuideLine get_GuideLine(); // 0x066c0404
	System.Void set_GuideLine(WizardGames.Soc.SocClient.Ui.Marker.GuideLine value); // 0x066c0468
	FairyGUI.GComponent get_AreaLayer(); // 0x066c04e8
	System.Void set_AreaLayer(FairyGUI.GComponent value); // 0x066c054c
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.MapBase map); // 0x066c05cc
	System.Void Init(FairyGUI.GComponent root); // 0x066c0740
	System.Void InitFairyBatching(); // 0x066c1000
	System.Void OnEnable(); // 0x066c1060
	System.Void OnDisable(); // 0x066c10c0
	System.Void OnDestroy(); // 0x066c1120
	System.Void InitSpecialMonumentLayoutDic(System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.Map.SpecialMonumentLayoutInfo> infos, System.Int32 terrainSize); // 0x066c14cc
	System.Void UpdataeSpecialMonumentLayout(); // 0x066c1a38
	System.Void OnFps30Update(); // 0x066c1cfc
	System.Void OnFps10Update(); // 0x066c1d5c
	System.Void OnFps1Update(); // 0x066c1dbc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.WidgetBase : System.Object
{
	WizardGames.Soc.SocClient.Ui.Map.MapBase map; // 0x10
	FairyGUI.GComponent <UiRootNode>k__BackingField; // 0x18
	FairyGUI.GComponent get_UiRootNode(); // 0x066c1e1c
	System.Void set_UiRootNode(FairyGUI.GComponent value); // 0x066c1e80
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.MapBase map); // 0x066c1f00
	System.Void Init(); // 0x066c1f8c
	System.Void InitFairyBatching(); // 0x066c20cc
	System.Void OnEnable(); // 0x066c2184
	System.Void OnDisable(); // 0x066c21e4
	System.Void OnDestroy(); // 0x066c2244
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Ui.Map.IGridContainer : 
{
	
	FairyGUI.GComponent get_GridContainer(); // 0x054e7844
	System.Single get_CurrentContainerSize(); // 0x054a5abc
	System.Single get_InitContainerSize(); // 0x054a5abc
	System.Single get_MaxContainerSize(); // 0x054a5abc
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Ui.Map.ISidePanelMap : 
{
	
	WizardGames.Soc.SocClient.Marker.IMarker GetMarker(System.Int64 markerId); // 0x054e931c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.GMarkerBase> GetMarkerGroup(WizardGames.Soc.Common.Data.MarkerType markerType); // 0x054e7c9c
	System.Void LocateToMarker(System.Int64 markerId, System.Single xOffset, System.Single yOffset, System.Boolean needAni); // 0x05511f1c
	WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo get_CurSelectedMarkerInfo(); // 0x054e7844
	System.Void SelectMarker(System.Int64 markerId); // 0x055112ac
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.Map.SpecialMonumentLayoutInfo : System.ValueType
{
	System.String Name; // 0x10
	UnityEngine.Vector3 Pos; // 0x18
	System.Single Rotation; // 0x24
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.Map.EMapType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.Map.EMapType BigMap = 0;
	static WizardGames.Soc.SocClient.Ui.Map.EMapType MiniMap = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.Map.EMapLevel : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.Map.EMapLevel Floor = 0;
	static WizardGames.Soc.SocClient.Ui.Map.EMapLevel Metro = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.Map.ELabelName : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.Map.ELabelName None = 0;
	static WizardGames.Soc.SocClient.Ui.Map.ELabelName Event = 1;
	static WizardGames.Soc.SocClient.Ui.Map.ELabelName Monument = 2;
	static WizardGames.Soc.SocClient.Ui.Map.ELabelName Shop = 3;
	static WizardGames.Soc.SocClient.Ui.Map.ELabelName Respawn = 4;
	static WizardGames.Soc.SocClient.Ui.Map.ELabelName TerritoryCenter = 5;
	static WizardGames.Soc.SocClient.Ui.Map.ELabelName ObserverModeTerritoryCenter = 6;
	static WizardGames.Soc.SocClient.Ui.Map.ELabelName ObserverModePlayer = 7;
	static WizardGames.Soc.SocClient.Ui.Map.ELabelName SouDJ = 8;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.Map.UiSubViewInfo : System.ValueType
{
	System.String ComponentName; // 0x10
	System.Func<WizardGames.Soc.SocClient.Ui.Map.SidePanelSubviewBase> Creator; // 0x18
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.Map.PrimaryMenuLabel : System.ValueType
{
	WizardGames.Soc.SocClient.Ui.Map.ELabelName Name; // 0x10
	System.String IconUrl; // 0x18
	System.Int32 TitleConst; // 0x20
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.Map.RespawnItemInfo : System.ValueType
{
	System.Int64 <EntityId>k__BackingField; // 0x10
	System.Int64 <TemplateId>k__BackingField; // 0x18
	System.Int64 <TimeLeft>k__BackingField; // 0x20
	System.String <Title>k__BackingField; // 0x28
	System.String <Grid>k__BackingField; // 0x30
	System.Int64 get_EntityId(); // 0x066c22a4
	System.Void set_EntityId(System.Int64 value); // 0x066c2308
	System.Int64 get_TemplateId(); // 0x066c2380
	System.Void set_TemplateId(System.Int64 value); // 0x066c23e4
	System.Int64 get_TimeLeft(); // 0x066c245c
	System.Void set_TimeLeft(System.Int64 value); // 0x066c24c0
	System.String get_Title(); // 0x066c2538
	System.Void set_Title(System.String value); // 0x066c259c
	System.String get_Grid(); // 0x066c261c
	System.Void set_Grid(System.String value); // 0x066c2680
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.Map.SiteItemInfo : System.ValueType
{
	System.String ResName; // 0x10
	System.String MonumentName; // 0x18
	System.Int32 MonumentTypeId; // 0x20
	WizardGames.Soc.Common.Data.monumentType MonumentType; // 0x24
	System.Int32 MonumentInfoId; // 0x28
	System.Int32 ThreatLevel; // 0x2c
	System.String MonumentIcon; // 0x30
	System.Int64 MarkerId; // 0x38
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.Map.EMapEventType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.Map.EMapEventType Advance = 0;
	static WizardGames.Soc.SocClient.Ui.Map.EMapEventType InProgress = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.EventMarkerData : System.Object
{
	WizardGames.Soc.Common.Data.MarkerType MarkerType; // 0x10
	WizardGames.Soc.SocClient.Marker.MarkerBaseData MarkerData; // 0x18
	WizardGames.Soc.SocClient.Ui.Map.EMapEventType EventType; // 0x20
	System.Int64 EndTime; // 0x28
	System.Int64 StartTime; // 0x30
	System.String IconPath; // 0x38
	System.String Title; // 0x40
	WizardGames.Soc.SocClient.Talent.ETalentEffect TalentStatus; // 0x48
	System.Void .ctor(); // 0x066c2700
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.SDJMapRankTeamInfo : System.Object
{
	System.String TeamName; // 0x10
	System.Int64 TeamId; // 0x18
	System.Int32 Money; // 0x20
	System.String PosGridName; // 0x28
	System.Boolean IsMySelf; // 0x30
	System.Int32 Rank; // 0x34
	System.Void .ctor(); // 0x066c2768
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.SDJGoldAirdropInfo : System.Object
{
	System.Int64 Id; // 0x10
	System.Int64 AirDropEntityId; // 0x18
	System.Int32 Money; // 0x20
	System.Boolean IsLanded; // 0x24
	System.Int32 Distance; // 0x28
	System.Void .ctor(); // 0x066c27d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.ListExtension : System.Object
{
	
	static System.Int32 LastIndexOfList<TSource>(System.Collections.Generic.List<TSource> source, TSource& result, System.Func<TSource,System.Boolean> predicate); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.KatyushaMap : WizardGames.Soc.SocClient.Ui.Map.MapBase
{
	WizardGames.Soc.SocClient.Ui.Map.KatyushaMapView <View>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Marker.KatyushaMapStage <MarkerStage>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo <CurSelectedMarkerInfo>k__BackingField; // 0x50
	WizardGames.Soc.SocClient.Ui.UiKatyusha mMainUIController; // 0x58
	WizardGames.Soc.SocClient.Ui.Map.KatyushaMapView get_View(); // 0x066c2838
	System.Void set_View(WizardGames.Soc.SocClient.Ui.Map.KatyushaMapView value); // 0x066c289c
	WizardGames.Soc.SocClient.Marker.KatyushaMapStage get_MarkerStage(); // 0x066c291c
	System.Void set_MarkerStage(WizardGames.Soc.SocClient.Marker.KatyushaMapStage value); // 0x066c2980
	WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo get_CurSelectedMarkerInfo(); // 0x066c2a00
	System.Void set_CurSelectedMarkerInfo(WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo value); // 0x066c2a64
	System.Single get_MapScale(); // 0x066c2ae4
	System.Void set_MapScale(System.Single value); // 0x066c2b48
	System.Void Init(FairyGUI.GComponent uiNode, WizardGames.Soc.SocClient.Ui.UiKatyusha mainUIController); // 0x066c2c44
	System.Boolean get_IsForbidCreateMarker(); // 0x066c3248
	System.Void OnEnable(); // 0x066c3360
	System.Void OnDisable(); // 0x066c346c
	System.Void OnDestroy(); // 0x066c3578
	System.Void OnFps1Update(); // 0x066c37ec
	System.Void OnFps30Update(); // 0x066c38fc
	System.Boolean get_Active(); // 0x066c39b0
	System.Boolean IsMapState(WizardGames.Soc.SocClient.Ui.EKatyushaState state); // 0x066c3a80
	System.Void .ctor(); // 0x066c3b00
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.Map.BombRestrictedAreaData : System.ValueType
{
	UnityEngine.Vector3 areaCenterPos; // 0x10
	System.Single areaRotation; // 0x1c
	System.Single width; // 0x20
	System.Single height; // 0x24
	System.String monumentKey; // 0x28
	UnityEngine.Vector2 posMinMax; // 0x30
	FairyGUI.GComponent areaUI; // 0x38
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.Map.Matrix2x2 : System.ValueType
{
	System.Single m11; // 0x10
	System.Single m12; // 0x14
	System.Single m21; // 0x18
	System.Single m22; // 0x1c
	System.Void .ctor(System.Single rotation); // 0x066c3b88
	UnityEngine.Vector2 Translate(UnityEngine.Vector2 vt, UnityEngine.Vector2 posOffset); // 0x066c3c24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.KatyushaMapView : WizardGames.Soc.SocClient.Ui.Map.ViewBase, WizardGames.Soc.SocClient.Ui.Map.IGridContainer
{
	FairyGUI.PinchGesture pinchGesture; // 0x90
	System.Boolean isGestureValid; // 0x98
	FairyGUI.GComponent comScaleWidgetParent; // 0xa0
	FairyGUI.GObject comMapWidgetBg; // 0xa8
	FairyGUI.GButton btnAutoAim; // 0xb0
	FairyGUI.GSlider scaleSlider; // 0xb8
	FairyGUI.Transition showMapAnim; // 0xc0
	FairyGUI.Transition hideMapAnim; // 0xc8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.BombRestrictedAreaData> mBombRestrictedAreaData; // 0xd0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.MarkerBaseData> markerDatas; // 0xd8
	FairyGUI.GButton scalePlusBtn; // 0xe0
	FairyGUI.GButton scaleMinusBtn; // 0xe8
	WizardGames.Soc.SocClient.Manager.HotKeyAction wheelUpAction; // 0xf0
	WizardGames.Soc.SocClient.Manager.HotKeyAction wheelDownAction; // 0xf8
	WizardGames.Soc.SocClient.Ui.Map.Misc.MapGridManager gridManager; // 0x100
	System.Int32 markIndex; // 0x108
	WizardGames.Soc.SocClient.Ui.Map.KatyushaMap get_parentMap(); // 0x066c3ce4
	System.Single get_InitContainerSize(); // 0x066c3d90
	System.Single get_CurrentContainerSize(); // 0x066c3e40
	System.Single get_MaxContainerSize(); // 0x066c3ef4
	FairyGUI.GComponent get_GridContainer(); // 0x066c3f9c
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.MapBase mapWrapper); // 0x066c2fdc
	System.Void Init(FairyGUI.GComponent root); // 0x066c4034
	System.Void OnDestroy(); // 0x066c6050
	System.Void OnEnable(); // 0x066c64bc
	System.Void OnDisable(); // 0x066c660c
	System.Void InitFairyBatching(); // 0x066c66a4
	System.Void InitMapTexLoader(); // 0x066c483c
	System.Void InitTrackLine(); // 0x066c4b14
	System.Void OnGesturePreBegin(); // 0x066c680c
	System.Void OnGestureAction(); // 0x066c6e6c
	System.Void OnGestureEnd(); // 0x066c6fdc
	System.Void OnDragStart(); // 0x066c7c64
	System.Void OnDragMove(); // 0x066c7d64
	System.Void OnDragEnd(); // 0x066c7dfc
	UnityEngine.Rect GetDragBound(); // 0x066c71a0
	System.Void CheckBoundClamp(); // 0x066c76a8
	System.Void SetMapPivot(UnityEngine.Vector2 p, System.Boolean isPercent); // 0x066c6c84
	System.Void UpdateMapViewScale(System.Single oldScale, System.Single newScale); // 0x066c7e78
	System.Void OnMapBlankClick(FairyGUI.EventContext e); // 0x066c7f88
	System.Void AutoAim(UnityEngine.Vector3 worldPos); // 0x066c83d4
	UnityEngine.Vector2 TransformUiRootNodeCenterToTarget(FairyGUI.GObject targetObj); // 0x066c8e7c
	System.Boolean IsTouchPointInView(UnityEngine.Vector2 touchPointLocal); // 0x066c6b3c
	System.Void OnFps1Update(); // 0x066c9054
	System.Void LocateMapToCenter(UnityEngine.Vector2 posInContainer, System.Boolean needAni); // 0x066c8ba4
	System.Void SetNodeCenterAsContainerPivot(); // 0x066c90b8
	System.Void InitScaleWidgets(); // 0x066c4c68
	System.Void OnWheelUp(); // 0x066c9294
	System.Void OnWheelDown(); // 0x066c9374
	System.Void OnLocateBtnSelected(System.Boolean needAni); // 0x066c30f0
	System.Void OnClickAutoAimBtn(); // 0x066c9454
	System.Void OnScaleBtnClick(System.Boolean isPositiveDelta); // 0x066c95dc
	System.Void OnSliderValueChanged(); // 0x066c9174
	System.Void UpdateSliderValue(System.Single oldScale, System.Single newScale); // 0x066c980c
	System.Void InitBombRestrictedAreaData(); // 0x066c54b8
	System.Void CreateBombRestrictedAreaUI(); // 0x066c5d48
	System.Boolean IsInBombRestrictedAreaRange(UnityEngine.Vector2 mapPos); // 0x066c898c
	System.Void UpdateBombRestrictedAreaUI(); // 0x066c96d4
	WizardGames.Soc.SocClient.Ui.Map.BombRestrictedAreaData SetAreaUIPosAndScale(WizardGames.Soc.SocClient.Ui.Map.BombRestrictedAreaData bombRestrictedAreaData); // 0x066c991c
	System.Void ResetMapScale(); // 0x066c9da8
	System.Void SetMapMarkerContainerChild(FairyGUI.GObject gObj, System.Int32 childIndex); // 0x066c9e54
	System.Int32 GetMarkerContainerChildIndex(FairyGUI.GObject gObj); // 0x066c9fc8
	System.Void UpdateMapShow(WizardGames.Soc.SocClient.Ui.EKatyushaState preState, WizardGames.Soc.SocClient.Ui.EKatyushaState nowState, System.Boolean init, WizardGames.Soc.SocClient.Ui.UiKatyusha mMainUIController); // 0x066ca094
	System.Void <LocateMapToCenter>b__49_0(); // 0x066ca758
	System.Void <InitScaleWidgets>b__51_0(FairyGUI.EventContext ctx); // 0x066ca7f0
	System.Void <InitScaleWidgets>b__51_1(FairyGUI.EventContext ctx); // 0x066ca86c
	System.Void <InitScaleWidgets>b__51_2(FairyGUI.EventContext ctx); // 0x066ca8e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.KatyushaMapView.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.Map.KatyushaMapView.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__60_0; // 0x8
	static System.Void .cctor(); // 0x066ca964
	System.Void .ctor(); // 0x066ca9c8
	System.Void <CreateBombRestrictedAreaUI>b__60_0(); // 0x066caa30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.KatyushaMapView.<>c__DisplayClass67_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.Map.KatyushaMapView <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.UiKatyusha mMainUIController; // 0x18
	System.Void .ctor(); // 0x066ca6f0
	System.Void <UpdateMapShow>b__0(); // 0x066cac00
	System.Void <UpdateMapShow>b__1(); // 0x066cadd4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.LobbyMap : WizardGames.Soc.SocClient.Ui.Map.MapBase
{
	WizardGames.Soc.Common.Data.Play.OBJLobbyMap <MapCfg>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Ui.Map.LobbyMapView <View>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Ui.Map.LobbyMapWidget <Widget>k__BackingField; // 0x50
	WizardGames.Soc.SocClient.Marker.LobbyMapStage <MarkerStage>k__BackingField; // 0x58
	WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo <CurSelectedMarkerInfo>k__BackingField; // 0x60
	WizardGames.Soc.Common.Data.Play.OBJLobbyMap get_MapCfg(); // 0x066caf38
	System.Void set_MapCfg(WizardGames.Soc.Common.Data.Play.OBJLobbyMap value); // 0x066caf9c
	WizardGames.Soc.SocClient.Ui.Map.LobbyMapView get_View(); // 0x066cb01c
	System.Void set_View(WizardGames.Soc.SocClient.Ui.Map.LobbyMapView value); // 0x066cb080
	WizardGames.Soc.SocClient.Ui.Map.LobbyMapWidget get_Widget(); // 0x066cb100
	System.Void set_Widget(WizardGames.Soc.SocClient.Ui.Map.LobbyMapWidget value); // 0x066cb164
	WizardGames.Soc.SocClient.Marker.LobbyMapStage get_MarkerStage(); // 0x066cb1e4
	System.Void set_MarkerStage(WizardGames.Soc.SocClient.Marker.LobbyMapStage value); // 0x066cb248
	WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo get_CurSelectedMarkerInfo(); // 0x066cb2c8
	System.Void set_CurSelectedMarkerInfo(WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo value); // 0x066cb32c
	System.Boolean get_Active(); // 0x066cb3ac
	System.Void Init(FairyGUI.GComponent uiNode, WizardGames.Soc.Common.Data.Play.OBJLobbyMap cfg); // 0x066cb47c
	System.Void OnEnable(); // 0x066cbb50
	System.Void OnDisable(); // 0x066cbcb4
	System.Void OnDestroy(); // 0x066cbe10
	System.Void .ctor(); // 0x066cc12c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.LobbyMapView : WizardGames.Soc.SocClient.Ui.Map.ViewBase, WizardGames.Soc.SocClient.Ui.Map.IGridContainer
{
	FairyGUI.PinchGesture pinchGesture; // 0x90
	System.Boolean isGestureValid; // 0x98
	System.Collections.Generic.HashSet<UnityEngine.Texture> toRelease; // 0xa0
	WizardGames.Soc.SocClient.Ui.Map.LobbyMap get_Map(); // 0x066cc1b4
	System.Single get_InitContainerSize(); // 0x066cc260
	System.Single get_CurrentContainerSize(); // 0x066cc310
	System.Single get_MaxContainerSize(); // 0x066cc3c4
	FairyGUI.GComponent get_GridContainer(); // 0x066cc46c
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.MapBase mapWrapper); // 0x066cba0c
	System.Void Init(FairyGUI.GComponent root); // 0x066cc504
	System.Void SetMonumentLayoutDic(); // 0x066ccf5c
	System.Void OnDestroy(); // 0x066cd0dc
	System.Void OnEnable(); // 0x066cd62c
	System.Void InitFairyBatching(); // 0x066cdc2c
	System.Void ReleaseAllTextures(); // 0x066cd45c
	System.Void InitMapTexLoader(); // 0x066ccaf8
	System.Void OnGesturePreBegin(); // 0x066cdd94
	System.Void OnGestureAction(); // 0x066ce3f4
	System.Void OnGestureEnd(); // 0x066ce564
	System.Void OnDragStart(); // 0x066cf1d8
	System.Void OnDragEnd(); // 0x066cf2d8
	UnityEngine.Rect GetDragBound(); // 0x066ce714
	System.Void CheckBoundClamp(); // 0x066cec1c
	System.Void SetMapPivot(UnityEngine.Vector2 p, System.Boolean isPercent); // 0x066ce20c
	System.Void UpdateMapViewScale(System.Single oldScale, System.Single newScale); // 0x066cf33c
	System.Void BlankClick(FairyGUI.EventContext e); // 0x066cf438
	UnityEngine.Vector2 TransformUiRootNodeCenterToTarget(FairyGUI.GObject targetObj); // 0x066cf554
	System.Boolean IsTouchPointInView(UnityEngine.Vector2 touchPointLocal); // 0x066ce0c4
	System.Void LocateMapToCenter(UnityEngine.Vector2 posInContainer, System.Boolean needAni); // 0x066cd9e8
	System.Void SetNodeCenterAsContainerPivot(); // 0x066cf72c
	System.Void SwitchMapTexture(WizardGames.Soc.SocClient.Ui.Map.EMapLevel mapLevel); // 0x066cd7f4
	System.Void UpdataeSpecialMonumentLayout(); // 0x066cf7e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.LobbyMapWidget : WizardGames.Soc.SocClient.Ui.Map.WidgetBase
{
	FairyGUI.GButton scalePlusBtn; // 0x20
	FairyGUI.GButton scaleMinusBtn; // 0x28
	FairyGUI.GSlider scaleSlider; // 0x30
	FairyGUI.GButton locateBtn; // 0x38
	FairyGUI.GButton gridBtn; // 0x40
	FairyGUI.GButton removeGoingToMarkerBtn; // 0x48
	FairyGUI.GButton debugTransformBtn; // 0x50
	FairyGUI.GButton btnGround; // 0x58
	FairyGUI.GButton btnMetro; // 0x60
	FairyGUI.GButton trackBtn; // 0x68
	WizardGames.Soc.SocClient.Ui.Map.MarkerDetailView markerDetailView; // 0x70
	System.Boolean isFirstTip; // 0x78
	WizardGames.Soc.SocClient.Manager.HotKeyAction wheelUpAction; // 0x80
	WizardGames.Soc.SocClient.Manager.HotKeyAction wheelDownAction; // 0x88
	WizardGames.Soc.SocClient.Ui.Map.LobbyMap get_Map(); // 0x066cfb3c
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.MapBase mapWrapper); // 0x066cbad4
	System.Void Init(); // 0x066cfbe8
	System.Void OnDestroy(); // 0x066d091c
	System.Void ChangeMarkerSelectedStatus(); // 0x066d0b0c
	System.Void CheckShowMarkerDetail(); // 0x066d0c8c
	System.Void OnEnable(); // 0x066d0f8c
	System.Void OnWheelUp(); // 0x066d1338
	System.Void OnWheelDown(); // 0x066d14f0
	System.Void ForceHideMarkerDetail(); // 0x066d1558
	System.Void OnDisable(); // 0x066d15cc
	System.Void OnScaleBtnClick(System.Boolean isPositiveDelta); // 0x066d13a0
	System.Void OnSliderValueChanged(); // 0x066d17d4
	System.Void UpdateSliderValue(System.Single oldScale, System.Single newScale); // 0x066d190c
	System.Void OnMapLevelChanged(WizardGames.Soc.SocClient.Ui.Map.EMapLevel oldLevel, WizardGames.Soc.SocClient.Ui.Map.EMapLevel newLevel); // 0x066d1b60
	System.Void RefreshMetroBtnSelected(); // 0x066d1230
	System.Void OnMapLevelBtnClick(WizardGames.Soc.SocClient.Ui.Map.EMapLevel level); // 0x066d1be0
	System.Void <Init>b__19_0(FairyGUI.EventContext ctx); // 0x066d1cc0
	System.Void <Init>b__19_1(FairyGUI.EventContext ctx); // 0x066d1d3c
	System.Void <Init>b__19_2(FairyGUI.EventContext ctx); // 0x066d1db8
	System.Void <Init>b__19_3(FairyGUI.EventContext ctx); // 0x066d1e34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MainMap : WizardGames.Soc.SocClient.Ui.Map.MapBase, WizardGames.Soc.SocClient.Ui.Map.ISidePanelMap
{
	WizardGames.Soc.SocClient.Ui.Map.MainMapSidePanel <SidePanel>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Ui.Map.MainMapView <View>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Ui.Map.MainMapWidget <Widget>k__BackingField; // 0x50
	WizardGames.Soc.SocClient.Marker.MainMapStage <MarkerStage>k__BackingField; // 0x58
	WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo <CurSelectedMarkerInfo>k__BackingField; // 0x60
	System.Boolean <IsMarkerFiltering>k__BackingField; // 0x68
	WizardGames.Soc.SocClient.Ui.Map.MainMapSidePanel get_SidePanel(); // 0x066d1eb0
	System.Void set_SidePanel(WizardGames.Soc.SocClient.Ui.Map.MainMapSidePanel value); // 0x066d1f14
	WizardGames.Soc.SocClient.Ui.Map.MainMapView get_View(); // 0x066d1f94
	System.Void set_View(WizardGames.Soc.SocClient.Ui.Map.MainMapView value); // 0x066d1ff8
	WizardGames.Soc.SocClient.Ui.Map.MainMapWidget get_Widget(); // 0x066d2078
	System.Void set_Widget(WizardGames.Soc.SocClient.Ui.Map.MainMapWidget value); // 0x066d20dc
	WizardGames.Soc.SocClient.Marker.MainMapStage get_MarkerStage(); // 0x066d215c
	System.Void set_MarkerStage(WizardGames.Soc.SocClient.Marker.MainMapStage value); // 0x066d21c0
	WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo get_CurSelectedMarkerInfo(); // 0x066d2240
	System.Void set_CurSelectedMarkerInfo(WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo value); // 0x066d22a4
	System.Boolean get_IsMarkerFiltering(); // 0x066d2324
	System.Void set_IsMarkerFiltering(System.Boolean value); // 0x066d2388
	System.Void Init(FairyGUI.GComponent uiNode); // 0x066d2404
	System.Void OnEnable(); // 0x066d2b30
	System.Void OnDisable(); // 0x066d2dbc
	System.Void OnDestroy(); // 0x066d3020
	System.Void OnFps1Update(); // 0x066d33f4
	System.Void OnFpsUnlimitedUpdate(); // 0x066d3504
	System.Void OnFps30Update(); // 0x066d35b8
	System.Boolean get_Active(); // 0x066d366c
	WizardGames.Soc.SocClient.Marker.IMarker GetMarker(System.Int64 markerId); // 0x066d373c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.GMarkerBase> GetMarkerGroup(WizardGames.Soc.Common.Data.MarkerType markerType); // 0x066d3808
	System.Void LocateToMarker(System.Int64 markerId, System.Single xOffset, System.Single yOffset, System.Boolean needAni); // 0x066d38d4
	System.Void LocateToPositionOnMap(UnityEngine.Vector2 positionInMapContainer, System.Boolean needAni); // 0x066d3ddc
	System.Void SelectMarker(System.Int64 markerId); // 0x066d3ec8
	System.Void CancelSelectMarker(WizardGames.Soc.SocClient.Ui.Map.UpdateReason reason); // 0x066d3f98
	System.Void RefreshMarkerFilterGroup(System.Collections.Generic.List<System.Int32> filterGroupIds); // 0x066d4064
	System.Void JumpToMission(System.Int32 missionId); // 0x066d4130
	System.Void JumpToSDJTab(System.Int32 pageIndex); // 0x066d4dfc
	System.Void .ctor(); // 0x066d4ff8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MainMapRaidPanel : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComInfoButton btnInfo; // 0x10
	FairyGUI.Controller stageCtrol; // 0x18
	FairyGUI.GRichTextField txtCurStage; // 0x20
	FairyGUI.GRichTextField txtTime; // 0x28
	System.Int64 timerId; // 0x30
	System.Boolean isRaiding; // 0x38
	FairyGUI.GComponent rootNode; // 0x40
	System.Void .ctor(FairyGUI.GComponent node); // 0x066d5080
	System.Void UpdateNodeVisible(); // 0x066d52fc
	System.Void RefreshRaidInfo(); // 0x066d541c
	System.Void TimerCallBack(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x066d58a8
	System.String ConvertCountDown(System.Int32 countDown); // 0x066d5770
	System.Void CreateTimer(); // 0x055049cc
	System.Void ClearTimer(); // 0x066d5aec
	System.Void OnDisable(); // 0x066d5bf8
	System.Void OnEnable(); // 0x066d5c5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MainMapSDJStagePanel : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComInfoButton btnInfo; // 0x10
	FairyGUI.GRichTextField txtCurStage; // 0x18
	FairyGUI.GRichTextField txtTime; // 0x20
	FairyGUI.GComponent rootNode; // 0x28
	System.Int64 timerId; // 0x30
	MgrSouDJ.ESouDJStageName curStage; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.SouDJStageCfg> curSouDjCfgList; // 0x40
	System.Int32 serverStage; // 0x48
	System.Void .ctor(FairyGUI.GComponent node); // 0x066d5d10
	System.Void RefreshStageInfo(); // 0x066d5f14
	System.Void TimerCallBack(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x066d6230
	System.String ConvertCountDown(System.Int32 countDown); // 0x066d60f8
	System.Void ResetStageCfg(); // 0x066d6394
	System.Void ClearTimer(); // 0x066d64b0
	System.Void OnDisable(); // 0x066d65bc
	System.Void OnEnable(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MainMapSidePanel : WizardGames.Soc.SocClient.Ui.Map.SidePanelBase
{
	FairyGUI.GComponent subViewContainer; // 0x28
	FairyGUI.GButton btnFilter; // 0x30
	FairyGUI.GComponent comFilterSubView; // 0x38
	WizardGames.Soc.SocClient.Ui.Map.FilterSubview filterSubview; // 0x40
	FairyGUI.Transition filterShowTransition; // 0x48
	FairyGUI.Transition filterHideTransition; // 0x50
	FairyGUI.GList primaryMenuList; // 0x58
	System.Boolean isSubViewExpand; // 0x60
	System.Int32 curSelectedIdx; // 0x64
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.PrimaryMenuLabel> primaryMenuLabels; // 0x68
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.Map.ELabelName,WizardGames.Soc.SocClient.Ui.Map.SidePanelSubviewBase> subviewCaches; // 0x70
	static System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.Map.ELabelName,WizardGames.Soc.SocClient.Ui.Map.UiSubViewInfo> SubviewComNameMap; // 0x0
	WizardGames.Soc.SocClient.Ui.Map.MainMap get_Map(); // 0x066d67f8
	System.Int32 get_CurSelectedIdx(); // 0x066d68a4
	System.Void set_CurSelectedIdx(System.Int32 value); // 0x066d6908
	WizardGames.Soc.SocClient.Ui.Map.ELabelName get_CurSelectedLabelName(); // 0x066d69c8
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.ISidePanelMap map); // 0x066d2990
	System.Void Init(); // 0x066d6a78
	System.Void ResetPrimaryMenuLabel(); // 0x066d711c
	System.Void OnEnable(); // 0x066d7878
	System.Void SouDJSateChange(); // 0x066d7d88
	System.Void OnListLeft(); // 0x066d8290
	System.Void OnListRight(); // 0x066d84b4
	System.Void OnDisable(); // 0x066d8568
	System.Void OnDestroy(); // 0x066d8840
	System.Void ExpandSubview(); // 0x066d89f8
	System.Void CollapseSubview(System.Boolean playAnimImmediately); // 0x066d7c94
	System.Void OnPrimaryMenuLabelRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x066d8efc
	System.Void ChangeSubView(WizardGames.Soc.SocClient.Ui.Map.ELabelName nameToShow); // 0x066d7fd4
	WizardGames.Soc.SocClient.Ui.Map.ELabelName GetCurrentShowViewName(); // 0x066d8b28
	System.Void OnPrimaryMenuLabelClick(); // 0x066d833c
	System.Void OnSelectedMarkerInfoChanged(); // 0x066d9344
	System.Void SelectSidePanelItem(System.Int64 markerId, WizardGames.Soc.Common.Data.MarkerType markerType); // 0x066d9840
	WizardGames.Soc.SocClient.Ui.Map.ELabelName MarkerType2ShowName(WizardGames.Soc.Common.Data.MarkerType type); // 0x066d96d4
	System.Void ShowSubview(WizardGames.Soc.SocClient.Ui.Map.ELabelName labelName); // 0x066d91f8
	System.Void HideSubview(WizardGames.Soc.SocClient.Ui.Map.ELabelName labelName); // 0x066d90a8
	System.Void RefreshSubview(WizardGames.Soc.SocClient.Ui.Map.ELabelName labelName); // 0x066d9144
	WizardGames.Soc.SocClient.Ui.Map.SidePanelSubviewBase GetOrCreateSubview(WizardGames.Soc.SocClient.Ui.Map.ELabelName labelName); // 0x066d8cc0
	System.Void OnBtnFilterClick(FairyGUI.EventContext context); // 0x066d9994
	System.Void SimulateClickBtnFilter(); // 0x066d9b60
	System.Void JumpToMission(System.Int32 missionId); // 0x066d4204
	System.Void JumpToSDJTab(System.Int32 pageIndex); // 0x066d4ed0
	static System.Void .cctor(); // 0x066d9bd8
	System.Boolean <ExpandSubview>b__30_0(); // 0x066da10c
	System.Void <OnBtnFilterClick>b__43_0(); // 0x066da17c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MainMapSidePanel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.Map.MainMapSidePanel.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x066da1f8
	System.Void .ctor(); // 0x066da25c
	WizardGames.Soc.SocClient.Ui.Map.SidePanelSubviewBase <.cctor>b__47_0(); // 0x066da2c4
	WizardGames.Soc.SocClient.Ui.Map.SidePanelSubviewBase <.cctor>b__47_1(); // 0x066da350
	WizardGames.Soc.SocClient.Ui.Map.SidePanelSubviewBase <.cctor>b__47_2(); // 0x066da3dc
	WizardGames.Soc.SocClient.Ui.Map.SidePanelSubviewBase <.cctor>b__47_3(); // 0x066da468
	WizardGames.Soc.SocClient.Ui.Map.SidePanelSubviewBase <.cctor>b__47_4(); // 0x066da4f4
	WizardGames.Soc.SocClient.Ui.Map.SidePanelSubviewBase <.cctor>b__47_5(); // 0x066da580
	WizardGames.Soc.SocClient.Ui.Map.SidePanelSubviewBase <.cctor>b__47_6(); // 0x066da60c
	WizardGames.Soc.SocClient.Ui.Map.SidePanelSubviewBase <.cctor>b__47_7(); // 0x066da698
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MainMapSidePanel.<>c__DisplayClass33_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.Map.ELabelName nameToShow; // 0x10
	System.Void .ctor(); // 0x066d9040
	System.Boolean <ChangeSubView>b__0(WizardGames.Soc.SocClient.Ui.Map.PrimaryMenuLabel label); // 0x066da724
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MainMapView : WizardGames.Soc.SocClient.Ui.Map.ViewBase, WizardGames.Soc.SocClient.Ui.Map.IGridContainer
{
	FairyGUI.PinchGesture pinchGesture; // 0x90
	System.Boolean isGestureValid; // 0x98
	WizardGames.Soc.SocClient.Ui.Map.Misc.MapGridManager gridManager; // 0xa0
	System.Boolean isPlayerOnGround; // 0xa8
	WizardGames.Soc.SocClient.Ui.Marker.MapRoad mapRoad; // 0xb0
	FairyGUI.GLoader newbieLevelGuideObj; // 0xb8
	WizardGames.Soc.SocClient.Ui.Map.MainMap get_Map(); // 0x066da7bc
	System.Single get_InitContainerSize(); // 0x066da868
	System.Single get_CurrentContainerSize(); // 0x066da918
	System.Single get_MaxContainerSize(); // 0x066da9cc
	FairyGUI.GComponent get_GridContainer(); // 0x066daa74
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.MapBase mapWrapper); // 0x066d2aac
	System.Void Init(FairyGUI.GComponent root); // 0x066dab0c
	System.Void OnDestroy(); // 0x066db870
	System.Void OnEnable(); // 0x066dbc18
	System.Void OnDisable(); // 0x066dc454
	System.Void InitFairyBatching(); // 0x066dc518
	System.Void InitMapTexLoader(); // 0x066db3b8
	System.Void InitTrackLine(); // 0x066db740
	System.Void OnGesturePreBegin(); // 0x066dc680
	System.Void OnGestureAction(); // 0x066dcce0
	System.Void OnGestureEnd(); // 0x066dce50
	System.Void OnDragStart(); // 0x066ddad8
	System.Void OnDragMove(); // 0x066ddbd8
	System.Void OnDragEnd(); // 0x066ddc70
	UnityEngine.Rect GetDragBound(); // 0x066dd014
	System.Void CheckBoundClamp(); // 0x066dd51c
	System.Void SetMapPivot(UnityEngine.Vector2 p, System.Boolean isPercent); // 0x066dcaf8
	System.Void UpdateMapViewScale(System.Single oldScale, System.Single newScale); // 0x066ddcec
	System.Void BlankClick(FairyGUI.EventContext e); // 0x066dddfc
	UnityEngine.Vector2 TransformUiRootNodeCenterToTarget(FairyGUI.GObject targetObj); // 0x066de080
	System.Boolean IsTouchPointInView(UnityEngine.Vector2 touchPointLocal); // 0x066dc9b0
	System.Void OnFps1Update(); // 0x066de258
	System.Void SetGridActive(System.Boolean active); // 0x066de2c8
	System.Void LocateMapToCenter(UnityEngine.Vector2 posInContainer, System.Boolean needAni); // 0x066d3b04
	System.Void SetNodeCenterAsContainerPivot(); // 0x066de350
	System.Void UpdateMapTexture(System.Boolean isEnableTrigger); // 0x066dbc90
	System.Void SwitchMapTexture(WizardGames.Soc.SocClient.Ui.Map.EMapLevel mapLevel, System.Boolean forceSwitch); // 0x066de40c
	System.Void TryGuideMarker(); // 0x066dbeb8
	System.Void OnClickNewbieLevelGuideObj(); // 0x066de714
	System.Void <LocateMapToCenter>b__39_0(); // 0x066de8c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MainMapWidget : WizardGames.Soc.SocClient.Ui.Map.WidgetBase
{
	FairyGUI.GButton scalePlusBtn; // 0x20
	FairyGUI.GButton scaleMinusBtn; // 0x28
	FairyGUI.GSlider scaleSlider; // 0x30
	FairyGUI.GButton locateBtn; // 0x38
	FairyGUI.GButton gridBtn; // 0x40
	FairyGUI.GButton removeGoingToMarkerBtn; // 0x48
	FairyGUI.GButton debugTransformBtn; // 0x50
	FairyGUI.GButton btnGround; // 0x58
	FairyGUI.GButton btnMetro; // 0x60
	WizardGames.Soc.SocClient.Ui.Map.MainMapRaidPanel raidPanel; // 0x68
	WizardGames.Soc.SocClient.Ui.Map.MainMapSDJStagePanel sdjStagePanel; // 0x70
	FairyGUI.GButton trackBtn; // 0x78
	FairyGUI.Controller btnCtrol; // 0x80
	WizardGames.Soc.SocClient.Ui.Map.MarkerDetailView markerDetailView; // 0x88
	FairyGUI.GButton hideTerritoryBtn; // 0x90
	FairyGUI.GButton hidePlayerBtn; // 0x98
	System.Boolean isFirstTip; // 0xa0
	WizardGames.Soc.SocClient.Manager.HotKeyAction wheelUpAction; // 0xa8
	WizardGames.Soc.SocClient.Manager.HotKeyAction wheelDownAction; // 0xb0
	WizardGames.Soc.SocClient.Ui.Map.MainMap get_Map(); // 0x066dea20
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.MapBase mapWrapper); // 0x066deacc
	System.Void Init(); // 0x066deb4c
	System.Void InitHotKey(); // 0x066e0268
	System.Void SimulateChangedGridBtn(); // 0x066e040c
	System.Void OnDestroy(); // 0x066e0484
	System.Void ObserverHideMapMarkers(WizardGames.Soc.Common.Data.MarkerType markerType, System.Boolean isHide); // 0x066e0918
	System.Void ChangeMarkerSelectedStatus(); // 0x066e0b0c
	System.Void CheckShowMarkerDetail(); // 0x066e10fc
	System.Void SetTrackButton(System.Int64 selectedMarkerId); // 0x066e0f3c
	System.Void OnTrackBtnClick(); // 0x066e1d4c
	System.Void OnEnable(); // 0x066e1f2c
	System.Void OnWheelUp(); // 0x066e2650
	System.Void OnWheelDown(); // 0x066e2730
	System.Void ForceShowMarkerDetail(WizardGames.Soc.Common.Data.MarkerType markerType); // 0x066e2810
	System.Void ForceHideMarkerDetail(); // 0x066e2900
	System.Void OnDisable(); // 0x066e2970
	System.Void OnScaleBtnClick(System.Boolean isPositiveDelta); // 0x066e2c14
	System.Void OnSliderValueChanged(); // 0x066e2d68
	System.Void UpdateSliderValue(System.Single oldScale, System.Single newScale); // 0x066e2ea4
	System.Void OnDebugTransformBtnClick(FairyGUI.EventContext context); // 0x066e30f8
	System.Void OnMapLevelChanged(WizardGames.Soc.SocClient.Ui.Map.EMapLevel oldLevel, WizardGames.Soc.SocClient.Ui.Map.EMapLevel newLevel); // 0x066e3448
	System.Void RefreshMetroBtnSelected(); // 0x066e2548
	System.Void OnMapLevelBtnClick(WizardGames.Soc.SocClient.Ui.Map.EMapLevel level); // 0x066e34c8
	System.Void OnLocateBtnClick(FairyGUI.EventContext context); // 0x066e35b0
	System.Void SimulateClickLocateBtn(); // 0x066e23c8
	System.Void SimulateClickRemoveGotoMarkerBtn(); // 0x066e3738
	System.Void OnRemoveGotoMarkerBtnClick(FairyGUI.EventContext context); // 0x066e37b0
	System.Void <Init>b__23_0(FairyGUI.EventContext ctx); // 0x066e39b4
	System.Void <Init>b__23_1(FairyGUI.EventContext ctx); // 0x066e3adc
	System.Void <Init>b__23_2(FairyGUI.EventContext ctx); // 0x066e3bb0
	System.Void <Init>b__23_3(FairyGUI.EventContext ctx); // 0x066e3c2c
	System.Void <Init>b__23_4(); // 0x066e3ca8
	System.Void <Init>b__23_5(FairyGUI.EventContext ctx); // 0x066e3eb0
	System.Void <Init>b__23_6(FairyGUI.EventContext ctx); // 0x066e3f2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.ComMarkerDetailView : System.Object
{
	WizardGames.Soc.Common.Data.MarkerType markerType; // 0x10
	System.Int64 timerId; // 0x18
	System.Boolean isSourceAdvanceEvent; // 0x20
	FairyGUI.GComponent root; // 0x28
	FairyGUI.GComponent content; // 0x30
	FairyGUI.GList rewardList; // 0x38
	FairyGUI.GTextField titleText; // 0x40
	FairyGUI.GLoader eventIcon; // 0x48
	FairyGUI.GTextField threatText; // 0x50
	FairyGUI.GTextField descText; // 0x58
	FairyGUI.GTextField rewardTitle; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.ItemInfo> rewardItems; // 0x68
	FairyGUI.GTextField timeText; // 0x70
	FairyGUI.Controller timeCtrl; // 0x78
	System.Void .ctor(FairyGUI.GComponent root); // 0x066e3fa8
	System.Void Refresh(WizardGames.Soc.Common.Data.MarkerType type, System.Boolean isSourceAdvanceEvent, WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x066e434c
	System.Void SetRewardInfos(System.Int32[] rewards); // 0x066e4864
	System.Void RenderRewardInfoItem(System.Int32 index, FairyGUI.GObject obj); // 0x066e5168
	System.Void ClearTimer(); // 0x066e5448
	System.Void CheckCountDown(); // 0x066e4b7c
	System.Void Hide(); // 0x066e55b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.ComMarkerDetailView.<>c__DisplayClass17_0 : System.Object
{
	FairyGUI.GObject obj; // 0x10
	WizardGames.Soc.SocClient.Ui.Map.ItemInfo itemInfo; // 0x18
	System.Void .ctor(); // 0x066e53e0
	System.Void <RenderRewardInfoItem>b__0(); // 0x066e561c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.ComMarkerDetailView.<>c__DisplayClass19_0 : System.Object
{
	System.Int32 countDown; // 0x10
	WizardGames.Soc.SocClient.Ui.Map.ComMarkerDetailView <>4__this; // 0x18
	System.String tips1; // 0x20
	System.String tips2; // 0x28
	System.Boolean continueShowEndTips; // 0x30
	System.Void .ctor(); // 0x066e5550
	System.Void <CheckCountDown>b__0(System.Int64 _, System.Object _, System.Boolean _); // 0x066e568c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MarkerDetailView : System.Object
{
	FairyGUI.GComponent root; // 0x10
	WizardGames.Soc.SocClient.Ui.Map.ShopMarkerDetailView shopMarkerDetailView; // 0x18
	WizardGames.Soc.SocClient.Ui.Map.MonumentMarkerDetailView monumentMarkerDetailView; // 0x20
	WizardGames.Soc.SocClient.Ui.Map.ComMarkerDetailView comMarkerDetailView; // 0x28
	WizardGames.Soc.SocClient.Ui.Map.ObserverMarkerDetailView observerMarkerDetailView; // 0x30
	FairyGUI.Controller subViewController; // 0x38
	FairyGUI.Transition showTransition; // 0x40
	FairyGUI.Transition hideTransition; // 0x48
	System.Void .ctor(FairyGUI.GComponent root); // 0x066e0138
	System.Void Show(System.Boolean forceShow); // 0x066e1504
	System.Void Hide(System.Boolean ignoreAni); // 0x066e1ba8
	System.Void SetData(WizardGames.Soc.Common.Data.MarkerType markerType, WizardGames.Soc.SocClient.Ui.Map.MainMap map, WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData, System.Boolean isSourceAdvanceEvent); // 0x066e16ac
	static System.Boolean CheckIsUseComDetailPanel(WizardGames.Soc.Common.Data.MarkerType type); // 0x066e1ab0
	System.Void Dispose(); // 0x066e08ac
	System.Boolean <Show>b__10_0(); // 0x066e7524
	System.Void <Hide>b__11_0(); // 0x066e7594
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.Map.ItemInfo : System.ValueType
{
	System.String icon; // 0x10
	System.Boolean showText; // 0x18
	System.String content; // 0x20
	System.Boolean showHoverTips; // 0x28
	System.String tips; // 0x30
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MonumentMarkerDetailView : System.Object
{
	static SocLogger logger; // 0x0
	FairyGUI.GComponent detailPanel; // 0x10
	FairyGUI.GComponent detailPanelContent; // 0x18
	FairyGUI.GComponent comThreat; // 0x20
	FairyGUI.GComponent comFeature; // 0x28
	FairyGUI.GComponent comBaseSupplies; // 0x30
	FairyGUI.GComponent comCardRoom; // 0x38
	FairyGUI.GList threatList; // 0x40
	FairyGUI.GList featureList; // 0x48
	FairyGUI.GList baseSuppliesList; // 0x50
	FairyGUI.GList cardRoomList; // 0x58
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.ItemInfo> threatItemInfoList; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.ItemInfo> featureItemInfoList; // 0x68
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.ItemInfo> suppliesItemInfoList; // 0x70
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.ItemInfo> cardRoomItemInfoList; // 0x78
	System.Single threatOriginalHeight; // 0x80
	WizardGames.Soc.SocClient.Marker.MarkerMonumentData curMonumentData; // 0x88
	static System.String iconPathFormat; // 0x8
	static System.String iconEnemy; // 0x10
	static System.String iconTF; // 0x18
	static System.String iconRadiation; // 0x20
	static System.String iconBeast; // 0x28
	static System.String iconLowTemp; // 0x30
	static System.String iconUnderwater; // 0x38
	static System.String iconDarkArea; // 0x40
	static System.String defaultItemIcon; // 0x48
	WizardGames.Soc.SocClient.Ui.Map.MainMap Map; // 0x90
	System.Void .ctor(FairyGUI.GComponent root); // 0x066e6db0
	System.Void SetData(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData, WizardGames.Soc.SocClient.Ui.Map.MainMap map); // 0x066e7238
	System.Void RefreshPanel(WizardGames.Soc.SocClient.Ui.Map.SiteItemInfo data); // 0x066e762c
	System.Void RefreshThreatList(WizardGames.Soc.Common.Data.mapmark.MonumentMapInfo monumentInfo); // 0x066e8090
	System.Boolean CheckIfListIsWrapped(FairyGUI.GList list); // 0x066e8eec
	System.Void OnThreatItemRender(System.Int32 index, FairyGUI.GObject gObject); // 0x066e90d0
	System.Void RefreshFeatureList(WizardGames.Soc.Common.Data.mapmark.MonumentMapInfo monumentInfo); // 0x066e87bc
	System.Void OnFeatureItemRender(System.Int32 index, FairyGUI.GObject gObject); // 0x066e93cc
	System.Void RefreshSupplies(System.Int32[] supplies, FairyGUI.GList targetList, FairyGUI.GComponent targetCom, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.ItemInfo> itemInfoList); // 0x066e8bb8
	System.Void OnSuppliesRender(System.Int32 index, FairyGUI.GObject gObject); // 0x066e9640
	System.Void OnCardRoomRender(System.Int32 index, FairyGUI.GObject gObject); // 0x066e98e8
	System.Void UpdateUnlockTime(WizardGames.Soc.Common.Data.mapmark.MonumentMapInfo monumentInfo); // 0x066e7f0c
	System.Boolean NeedShowRotationMonumentUnLockTime(WizardGames.Soc.Common.Data.mapmark.MonumentMapInfo monumentInfo, System.String& timeText); // 0x066e9b90
	static System.Void .cctor(); // 0x066e9d38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MonumentMarkerDetailView.<>c__DisplayClass30_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.Map.MonumentMarkerDetailView <>4__this; // 0x10
	WizardGames.Soc.Common.Data.mapmark.MonumentMapInfo monumentInfo; // 0x18
	System.Void .ctor(); // 0x066e7ea4
	System.Void <RefreshPanel>b__0(); // 0x066e9f94
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MonumentMarkerDetailView.<>c__DisplayClass33_0 : System.Object
{
	FairyGUI.GComponent threatCom; // 0x10
	WizardGames.Soc.SocClient.Ui.Map.ItemInfo threatInfo; // 0x18
	System.Void .ctor(); // 0x066e9364
	System.Void <OnThreatItemRender>b__0(); // 0x066ea078
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MonumentMarkerDetailView.<>c__DisplayClass35_0 : System.Object
{
	FairyGUI.GObject gObject; // 0x10
	WizardGames.Soc.SocClient.Ui.Map.MonumentMarkerDetailView <>4__this; // 0x18
	System.Int32 index; // 0x20
	System.Void .ctor(); // 0x066e95d8
	System.Void <OnFeatureItemRender>b__0(); // 0x066ea0e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MonumentMarkerDetailView.<>c__DisplayClass37_0 : System.Object
{
	FairyGUI.GObject gObject; // 0x10
	WizardGames.Soc.SocClient.Ui.Map.ItemInfo itemInfo; // 0x18
	System.Void .ctor(); // 0x066e9880
	System.Void <OnSuppliesRender>b__0(); // 0x066ea1a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MonumentMarkerDetailView.<>c__DisplayClass38_0 : System.Object
{
	FairyGUI.GObject gObject; // 0x10
	WizardGames.Soc.SocClient.Ui.Map.ItemInfo itemInfo; // 0x18
	System.Void .ctor(); // 0x066e9b28
	System.Void <OnCardRoomRender>b__0(); // 0x066ea214
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.ObserverMarkerDetailView : System.Object
{
	FairyGUI.GTextField title; // 0x10
	FairyGUI.GRichTextField content; // 0x18
	FairyGUI.Controller type; // 0x20
	WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData; // 0x28
	WizardGames.Soc.Common.CustomType.PatrolTerritoryBriefInfo territoryBriefInfo; // 0x30
	WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo playerBriefInfo; // 0x38
	WizardGames.Soc.Common.CustomType.PatrolTerritoryDetailInfo territoryDetailInfo; // 0x40
	System.Text.StringBuilder sb; // 0x48
	System.Void .ctor(FairyGUI.GComponent root); // 0x066e5868
	System.Void GetTerritoryDetail(WizardGames.Soc.Common.CustomType.PatrolTerritoryDetailInfo info); // 0x066ea284
	System.Void GetPlayerDetail(WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo info); // 0x066ea5e8
	System.Void SetData(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x066e5df4
	System.Void <.ctor>b__9_0(FairyGUI.EventContext ctx); // 0x066eabd8
	System.Void <.ctor>b__9_1(FairyGUI.EventContext ctx); // 0x066ead74
	System.Void <.ctor>b__9_2(FairyGUI.EventContext ctx); // 0x066eaeb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.ShopMarkerDetailView : System.Object
{
	static SocLogger logger; // 0x0
	FairyGUI.GTextField txtShopName; // 0x10
	FairyGUI.GList shopItemList; // 0x18
	FairyGUI.GComboBox gComboBox; // 0x20
	static System.Int32 userShopSubtitleId; // 0x8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.ShopMarkerDetailView.ShopItemGroupData> curShopDataList; // 0x28
	System.Collections.Generic.List<System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.ShopMarkerDetailView.ShopItemData>> allShopItemDatas; // 0x30
	System.Int32 curComboBoxValue; // 0x38
	WizardGames.Soc.SocClient.Ui.Map.EShopType shopType; // 0x3c
	FairyGUI.GLabel talentTips; // 0x40
	System.Int32 talentId; // 0x48
	System.Void .ctor(FairyGUI.GComponent root); // 0x066e62a0
	System.Void SetData(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x066e65a0
	System.Void SetTalentTips(WizardGames.Soc.Common.CustomType.ShopInfo shop); // 0x066eb108
	System.Void RefreshComboBox(); // 0x066ecc0c
	System.Void ComboOnChange(); // 0x066ed66c
	System.Void RefreshShopItemList(); // 0x066ecf4c
	System.Void OnRenderShopItem(System.Int32 index, FairyGUI.GObject obj); // 0x066ed7dc
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.ShopMarkerDetailView.ShopItemGroupData> GetSortedShopItemDict(WizardGames.Soc.SocClient.Ui.Map.EShopType shopType, WizardGames.Soc.Common.CustomType.ShopInfo shop); // 0x066eb6bc
	static System.Void .cctor(); // 0x066ee35c
	System.Void <SetData>b__14_0(Config.LobbyRoleInfo userInfo); // 0x066ee444
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.Map.ShopMarkerDetailView.ShopItemGroupData : System.ValueType
{
	System.Int64 GroupId; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.ShopMarkerDetailView.ShopItemData> ItemList; // 0x18
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.Map.ShopMarkerDetailView.ShopItemData : System.ValueType
{
	System.Int64 ItemId; // 0x10
	System.String IconRes; // 0x18
	System.String ItemName; // 0x20
	System.Int32 LeftNum; // 0x28
	System.Int32 ItemNum; // 0x2c
	System.Int32 CurPrice; // 0x30
	System.Int32 Price; // 0x34
	System.String PriceIconRes; // 0x38
	WizardGames.Soc.Common.CustomType.ShopItemInfo ItemInfo; // 0x40
	System.Int32 GroupType; // 0x48
	System.Int32 IndexInGroup; // 0x4c
	System.Single TalentDiscount; // 0x50
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.GMarkerSelectedPanel : FairyGUI.GComponent
{
	SocLogger log; // 0x288
	WizardGames.Soc.SocClient.Marker.MarkerStage stage; // 0x290
	FairyGUI.GList normalSlotList; // 0x298
	FairyGUI.Transition showTransition; // 0x2a0
	FairyGUI.Transition hideTransition; // 0x2a8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.GMarkerBase> markers; // 0x2b0
	WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo curSelectedMarkerInfo; // 0x2b8
	System.Action<System.Int64> itemClickAction; // 0x2c0
	System.Collections.Generic.Dictionary<System.Int64,System.String> playerId2Name; // 0x2c8
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x066ee564
	System.Void Init(WizardGames.Soc.SocClient.Marker.MarkerStage stage, FairyGUI.GComponent viewContainer); // 0x066ee69c
	System.Void UpdatePanel(WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo info); // 0x066ee950
	System.Void UpdatePanelPosForMapScaleChanged(System.Single oldScale, System.Single newScale); // 0x066ef758
	System.Void UpdatePanelPosForMarkerPosChanged(WizardGames.Soc.SocClient.Marker.IMarker marker, WizardGames.Soc.SocClient.Marker.MarkerCluster cluster); // 0x066ef8bc
	System.Void UpdateNormalSlotList(); // 0x066ef3a8
	System.Void NormalSlotRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x066efbb8
	System.Void SetListItemSize(FairyGUI.GList list); // 0x066efae4
	System.Void OnMarkerSlotClick(System.Int32 index); // 0x066f0038
	System.Void SetItemClickAction(System.Action<System.Int64> action); // 0x066f0344
	System.Void SetPosition(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x066ef54c
	System.Void Hide(); // 0x066ef1bc
	System.Void Show(); // 0x066ef2d0
	System.Void Dispose(); // 0x066f03c4
	System.String GetMarkerRealName(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x066efec8
	System.String GetShopMarkerName(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x066f049c
	System.Void .ctor(); // 0x066f08a0
	System.Void <UpdatePanel>b__11_1(SimpleJSON.JSONArray jsonArray); // 0x066f0a48
	System.Void <Hide>b__20_0(); // 0x066f0c94
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.GMarkerSelectedPanel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.Map.GMarkerSelectedPanel.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Marker.GMarkerBase> <>9__11_0; // 0x8
	static System.Void .cctor(); // 0x066f0d10
	System.Void .ctor(); // 0x066f0d74
	System.Int32 <UpdatePanel>b__11_0(WizardGames.Soc.SocClient.Marker.GMarkerBase a, WizardGames.Soc.SocClient.Marker.GMarkerBase b); // 0x066f0ddc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.GMarkerSelectedPanel.<>c__DisplayClass10_0 : System.Object
{
	FairyGUI.GComponent viewContainer; // 0x10
	System.Void .ctor(); // 0x066ee8e8
	System.Void <Init>b__0(FairyGUI.EventContext context); // 0x066f0f10
	System.Void <Init>b__1(FairyGUI.EventContext context); // 0x066f0f98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.GMarkerSelectedPanel.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.Map.GMarkerSelectedPanel <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x066efe60
	System.Void <NormalSlotRenderer>b__0(FairyGUI.EventContext ctx); // 0x066f1020
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.Map.UpdateReason : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.Map.UpdateReason None = 0;
	static WizardGames.Soc.SocClient.Ui.Map.UpdateReason OnMarkerCreate = 1;
	static WizardGames.Soc.SocClient.Ui.Map.UpdateReason OnMarkerRemove = 2;
	static WizardGames.Soc.SocClient.Ui.Map.UpdateReason MapMarkerClickSelect = 3;
	static WizardGames.Soc.SocClient.Ui.Map.UpdateReason MapClickDeselect = 4;
	static WizardGames.Soc.SocClient.Ui.Map.UpdateReason MapBlankClickDeselect = 5;
	static WizardGames.Soc.SocClient.Ui.Map.UpdateReason MarkerZoomHideDeselect = 6;
	static WizardGames.Soc.SocClient.Ui.Map.UpdateReason SidePanelItemClickSelect = 7;
	static WizardGames.Soc.SocClient.Ui.Map.UpdateReason OnTrackCreate = 8;
	static WizardGames.Soc.SocClient.Ui.Map.UpdateReason OnTrackRemove = 9;
	static WizardGames.Soc.SocClient.Ui.Map.UpdateReason MapScaleChangedRebuildCluster = 10;
	static WizardGames.Soc.SocClient.Ui.Map.UpdateReason MapLevelChangedRebuildCluster = 11;
	static WizardGames.Soc.SocClient.Ui.Map.UpdateReason MarkerFilterRefreshRebuildCluster = 12;
	static WizardGames.Soc.SocClient.Ui.Map.UpdateReason TeamCombatMarkerHide = 13;
	static WizardGames.Soc.SocClient.Ui.Map.UpdateReason AdvanceEventClick = 14;
	static WizardGames.Soc.SocClient.Ui.Map.UpdateReason InValidData = 15;
	static WizardGames.Soc.SocClient.Ui.Map.UpdateReason ClearData = 16;
	static WizardGames.Soc.SocClient.Ui.Map.UpdateReason TalentNotActived = 17;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo : System.Object
{
	System.Int64 <CurrentMarkerId>k__BackingField; // 0x10
	System.Int64 <OldMarkerId>k__BackingField; // 0x18
	System.Collections.Generic.List<System.Int64> <ClusterMembers>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Marker.EClusterType <ClusterType>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Map.UpdateReason <UpdateReason>k__BackingField; // 0x2c
	System.Action OnSelectedMarkerInfoChanged; // 0x30
	System.Int64 get_CurrentMarkerId(); // 0x066f10a4
	System.Void set_CurrentMarkerId(System.Int64 value); // 0x066f1108
	System.Int64 get_OldMarkerId(); // 0x066f1180
	System.Void set_OldMarkerId(System.Int64 value); // 0x066f11e4
	System.Collections.Generic.List<System.Int64> get_ClusterMembers(); // 0x066f125c
	WizardGames.Soc.SocClient.Marker.EClusterType get_ClusterType(); // 0x066f12c0
	System.Void set_ClusterType(WizardGames.Soc.SocClient.Marker.EClusterType value); // 0x066f1324
	System.Void set_UpdateReason(WizardGames.Soc.SocClient.Ui.Map.UpdateReason value); // 0x066f139c
	System.Void Update(System.Int64 curMarkerId, System.Int64 oldMarkerId, System.Collections.Generic.List<System.Int64> members, WizardGames.Soc.SocClient.Marker.EClusterType type, WizardGames.Soc.SocClient.Ui.Map.UpdateReason reason, System.Boolean invokeAction); // 0x066f1414
	System.Void RegisterSelectedMarkerCb(System.Action callback); // 0x066e0338
	System.Void UnregisterSelectedMarkerCb(System.Action callback); // 0x066e07d8
	System.Void Clear(WizardGames.Soc.SocClient.Ui.Map.UpdateReason reason, System.Boolean invokeAction); // 0x066f16f8
	System.Void OnDestroy(); // 0x066f1790
	System.Void .ctor(); // 0x066f180c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MainMapObView : WizardGames.Soc.SocClient.Ui.Map.ViewBase, WizardGames.Soc.SocClient.Ui.Map.IGridContainer
{
	FairyGUI.PinchGesture pinchGesture; // 0x90
	System.Boolean isGestureValid; // 0x98
	WizardGames.Soc.SocClient.Ui.Map.Misc.MapGridManager gridManager; // 0xa0
	System.Boolean isPlayerOnGround; // 0xa8
	WizardGames.Soc.SocClient.Ui.Marker.MapRoad mapRoad; // 0xb0
	FairyGUI.GLoader newbieLevelGuideObj; // 0xb8
	WizardGames.Soc.SocClient.Manager.HotKeyAction obUpArrowAction; // 0xc0
	WizardGames.Soc.SocClient.Manager.HotKeyAction obDownArrowAction; // 0xc8
	WizardGames.Soc.SocClient.Manager.HotKeyAction obLeftArrowAction; // 0xd0
	WizardGames.Soc.SocClient.Manager.HotKeyAction obRightArrowAction; // 0xd8
	UnityEngine.Rect viewContainerGlobalRect; // 0xe0
	UnityEngine.Rect viewContainerDragBoundRect; // 0xf0
	UnityEngine.Vector2 viewContainerHotArrowVector; // 0x100
	WizardGames.Soc.SocClient.Ui.Map.MainObMap get_Map(); // 0x066f18c0
	System.Single get_InitContainerSize(); // 0x066f196c
	System.Single get_CurrentContainerSize(); // 0x066f1a1c
	System.Single get_MaxContainerSize(); // 0x066f1ad0
	FairyGUI.GComponent get_GridContainer(); // 0x066f1b78
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.MapBase mapWrapper); // 0x066f1c10
	System.Void Init(FairyGUI.GComponent root); // 0x066f1c98
	System.Void OnDestroy(); // 0x066f2a0c
	System.Void OnEnable(); // 0x066f2dbc
	System.Void OnDisable(); // 0x066f3810
	System.Void AddMapKeyboard(); // 0x066f3604
	System.Void RemoveMapHotKey(); // 0x066f38d8
	System.Void OnObUpArrow(); // 0x066f3988
	System.Void OnObDownArrow(); // 0x066f3f40
	System.Void OnObLeftArrow(); // 0x066f3fa8
	System.Void OnObRightArrow(); // 0x066f4010
	System.Void OnObCallerOnceArrow(WizardGames.Soc.Common.Data.ActionName actionName); // 0x066f39f0
	UnityEngine.Rect GetRealViewContainerGlobalRect(); // 0x066f4078
	System.Void InitFairyBatching(); // 0x066f47d8
	System.Void InitMapTexLoader(); // 0x066f2550
	System.Void InitTrackLine(); // 0x066f28d8
	System.Void OnGesturePreBegin(); // 0x066f4940
	System.Void OnGestureAction(); // 0x066f4fa0
	System.Void OnGestureEnd(); // 0x066f5110
	System.Void OnDragStart(); // 0x066f5890
	System.Void OnDragMove(); // 0x066f4740
	System.Void OnDragEnd(); // 0x066f5990
	UnityEngine.Rect GetDragBound(); // 0x066f422c
	System.Void CheckBoundClamp(); // 0x066f52d4
	System.Void SetMapPivot(UnityEngine.Vector2 p, System.Boolean isPercent); // 0x066f4db8
	System.Void UpdateMapViewScale(System.Single oldScale, System.Single newScale); // 0x066f5a0c
	System.Void BlankClick(FairyGUI.EventContext e); // 0x066f5b1c
	UnityEngine.Vector2 TransformUiRootNodeCenterToTarget(FairyGUI.GObject targetObj); // 0x066f5da0
	System.Boolean IsTouchPointInView(UnityEngine.Vector2 touchPointLocal); // 0x066f4c70
	System.Void OnFps1Update(); // 0x066f5f78
	System.Void SetGridActive(System.Boolean active); // 0x066f5fec
	System.Void LocateMapToCenter(UnityEngine.Vector2 posInContainer, System.Boolean needAni); // 0x066f6074
	System.Void SetNodeCenterAsContainerPivot(); // 0x066f634c
	System.Void UpdateMapTexture(System.Boolean isEnableTrigger); // 0x066f2e40
	System.Void SwitchMapTexture(WizardGames.Soc.SocClient.Ui.Map.EMapLevel mapLevel, System.Boolean forceSwitch); // 0x066f6408
	System.Void TryGuideMarker(); // 0x066f3068
	System.Void OnClickNewbieLevelGuideObj(); // 0x066f6714
	System.Void <LocateMapToCenter>b__54_0(); // 0x066f68c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MainMapObWidget : WizardGames.Soc.SocClient.Ui.Map.WidgetBase
{
	FairyGUI.GButton scalePlusBtn; // 0x20
	FairyGUI.GButton scaleMinusBtn; // 0x28
	FairyGUI.GSlider scaleSlider; // 0x30
	FairyGUI.GButton locateBtn; // 0x38
	FairyGUI.GButton gridBtn; // 0x40
	FairyGUI.GButton removeGoingToMarkerBtn; // 0x48
	FairyGUI.GButton debugTransformBtn; // 0x50
	FairyGUI.GButton btnGround; // 0x58
	FairyGUI.GButton btnMetro; // 0x60
	WizardGames.Soc.SocClient.Ui.Map.MainMapRaidPanel raidPanel; // 0x68
	FairyGUI.GButton trackBtn; // 0x70
	FairyGUI.Controller btnCtrol; // 0x78
	WizardGames.Soc.SocClient.Ui.Map.MarkerObDetailView markerObDetailView; // 0x80
	FairyGUI.GButton hideTerritoryBtn; // 0x88
	FairyGUI.GButton hidePlayerBtn; // 0x90
	System.Boolean isFirstTip; // 0x98
	WizardGames.Soc.SocClient.Manager.HotKeyAction wheelUpAction; // 0xa0
	WizardGames.Soc.SocClient.Manager.HotKeyAction wheelDownAction; // 0xa8
	WizardGames.Soc.SocClient.Ui.Map.MainObMap get_Map(); // 0x066f6958
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.MapBase mapWrapper); // 0x066f6a04
	System.Void Init(); // 0x066f6a84
	System.Void InitHotKey(); // 0x066f80f0
	System.Void OnDestroy(); // 0x066f81c0
	System.Void ObserverHideMapMarkers(WizardGames.Soc.Common.Data.MarkerType markerType, System.Boolean isHide); // 0x066f8580
	System.Void ChangeMarkerSelectedStatus(); // 0x066f883c
	System.Void CheckShowMarkerDetail(); // 0x066f8e2c
	System.Void SetTrackButton(System.Int64 selectedMarkerId); // 0x066f8c6c
	System.Void OnTrackBtnClick(); // 0x066f9a00
	System.Void OnEnable(); // 0x066f9be0
	System.Void OnWheelUp(); // 0x066fa2f0
	System.Void OnWheelDown(); // 0x066fa3d0
	System.Void ForceShowMarkerDetail(WizardGames.Soc.Common.Data.MarkerType markerType); // 0x066fa4b0
	System.Void ForceHideMarkerDetail(); // 0x066fa5a0
	System.Void OnDisable(); // 0x066fa610
	System.Void OnScaleBtnClick(System.Boolean isPositiveDelta); // 0x066fa8a4
	System.Void OnSliderValueChanged(); // 0x066fa9f4
	System.Void UpdateSliderValue(System.Single oldScale, System.Single newScale); // 0x066fab2c
	System.Void OnDebugTransformBtnClick(FairyGUI.EventContext context); // 0x066fad80
	System.Void OnMapLevelChanged(WizardGames.Soc.SocClient.Ui.Map.EMapLevel oldLevel, WizardGames.Soc.SocClient.Ui.Map.EMapLevel newLevel); // 0x066fb040
	System.Void RefreshMetroBtnSelected(); // 0x066fa1e8
	System.Void OnMapLevelBtnClick(WizardGames.Soc.SocClient.Ui.Map.EMapLevel level); // 0x066fb0c0
	System.Void OnLocateBtnClick(FairyGUI.EventContext context); // 0x066fb1a4
	System.Void SimulateClickLocateBtn(); // 0x066fa06c
	System.Void OnRemoveGotoMarkerBtnClick(FairyGUI.EventContext context); // 0x066fb328
	System.Void <Init>b__22_0(FairyGUI.EventContext ctx); // 0x066fb52c
	System.Void <Init>b__22_1(FairyGUI.EventContext ctx); // 0x066fb654
	System.Void <Init>b__22_2(FairyGUI.EventContext ctx); // 0x066fb728
	System.Void <Init>b__22_3(FairyGUI.EventContext ctx); // 0x066fb7a4
	System.Void <Init>b__22_4(); // 0x066fb820
	System.Void <Init>b__22_5(FairyGUI.EventContext ctx); // 0x066fba24
	System.Void <Init>b__22_6(FairyGUI.EventContext ctx); // 0x066fbaa0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MainObMap : WizardGames.Soc.SocClient.Ui.Map.MapBase, WizardGames.Soc.SocClient.Ui.Map.ISidePanelMap
{
	WizardGames.Soc.SocClient.Ui.Map.MainMapObView <View>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Ui.Map.MainMapObWidget <Widget>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Marker.MainMapObStage <MarkerStage>k__BackingField; // 0x50
	WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo <CurSelectedMarkerInfo>k__BackingField; // 0x58
	System.Boolean <IsMarkerFiltering>k__BackingField; // 0x60
	WizardGames.Soc.SocClient.Ui.Map.MainMapObView get_View(); // 0x066fbb1c
	System.Void set_View(WizardGames.Soc.SocClient.Ui.Map.MainMapObView value); // 0x066fbb80
	WizardGames.Soc.SocClient.Ui.Map.MainMapObWidget get_Widget(); // 0x066fbc00
	System.Void set_Widget(WizardGames.Soc.SocClient.Ui.Map.MainMapObWidget value); // 0x066fbc64
	WizardGames.Soc.SocClient.Marker.MainMapObStage get_MarkerStage(); // 0x066fbce4
	System.Void set_MarkerStage(WizardGames.Soc.SocClient.Marker.MainMapObStage value); // 0x066fbd48
	WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo get_CurSelectedMarkerInfo(); // 0x066fbdc8
	System.Void set_CurSelectedMarkerInfo(WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo value); // 0x066fbe2c
	System.Boolean get_IsMarkerFiltering(); // 0x066fbeac
	System.Void Init(FairyGUI.GComponent uiNode); // 0x066fbf10
	System.Void OnEnable(); // 0x066fc3c0
	System.Void OnDisable(); // 0x066fc5f4
	System.Void OnDestroy(); // 0x066fc800
	System.Void OnFps1Update(); // 0x066fcb20
	System.Void OnFpsUnlimitedUpdate(); // 0x066fcc30
	System.Void OnFps30Update(); // 0x066fcce4
	System.Boolean get_Active(); // 0x066fcd98
	WizardGames.Soc.SocClient.Marker.IMarker GetMarker(System.Int64 markerId); // 0x066fce68
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.GMarkerBase> GetMarkerGroup(WizardGames.Soc.Common.Data.MarkerType markerType); // 0x066f8770
	System.Void LocateToMarker(System.Int64 markerId, System.Single xOffset, System.Single yOffset, System.Boolean needAni); // 0x066fcf34
	System.Void LocateToPositionOnMap(UnityEngine.Vector2 positionInMapContainer, System.Boolean needAni); // 0x066fd164
	System.Void SelectMarker(System.Int64 markerId); // 0x066fd250
	System.Void CancelSelectMarker(WizardGames.Soc.SocClient.Ui.Map.UpdateReason reason); // 0x066fd320
	System.Single get_MapScale(); // 0x066fd3ec
	System.Void set_MapScale(System.Single value); // 0x066fd450
	System.Void .ctor(); // 0x066fd54c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MarkerObDetailView : System.Object
{
	FairyGUI.GComponent root; // 0x10
	WizardGames.Soc.SocClient.Ui.Map.ShopMarkerDetailView shopMarkerDetailView; // 0x18
	WizardGames.Soc.SocClient.Ui.Map.MonumentMarkerObDetailView monumentMarkerObDetailView; // 0x20
	WizardGames.Soc.SocClient.Ui.Map.ComMarkerDetailView comMarkerDetailView; // 0x28
	WizardGames.Soc.SocClient.Ui.Map.ObserverMarkerDetailView observerMarkerDetailView; // 0x30
	FairyGUI.Controller subViewController; // 0x38
	FairyGUI.Transition showTransition; // 0x40
	FairyGUI.Transition hideTransition; // 0x48
	System.Void .ctor(FairyGUI.GComponent root); // 0x066f7fc0
	System.Void Show(System.Boolean forceShow); // 0x066f91b8
	System.Void Hide(System.Boolean ignoreAni); // 0x066f985c
	System.Void SetData(WizardGames.Soc.Common.Data.MarkerType markerType, WizardGames.Soc.SocClient.Ui.Map.MainObMap map, WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData, System.Boolean isSourceAdvanceEvent); // 0x066f9360
	static System.Boolean CheckIsUseComDetailPanel(WizardGames.Soc.Common.Data.MarkerType type); // 0x066f9764
	System.Void Dispose(); // 0x066f8514
	System.Boolean <Show>b__9_0(); // 0x066fdd4c
	System.Void <Hide>b__10_0(); // 0x066fddbc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MonumentMarkerObDetailView : System.Object
{
	static SocLogger logger; // 0x0
	FairyGUI.GComponent detailPanel; // 0x10
	FairyGUI.GComponent detailPanelContent; // 0x18
	FairyGUI.GComponent comThreat; // 0x20
	FairyGUI.GComponent comFeature; // 0x28
	FairyGUI.GComponent comBaseSupplies; // 0x30
	FairyGUI.GComponent comCardRoom; // 0x38
	FairyGUI.GList threatList; // 0x40
	FairyGUI.GList featureList; // 0x48
	FairyGUI.GList baseSuppliesList; // 0x50
	FairyGUI.GList cardRoomList; // 0x58
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.ItemInfo> threatItemInfoList; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.ItemInfo> featureItemInfoList; // 0x68
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.ItemInfo> suppliesItemInfoList; // 0x70
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.ItemInfo> cardRoomItemInfoList; // 0x78
	System.Single threatOriginalHeight; // 0x80
	WizardGames.Soc.SocClient.Marker.MarkerMonumentData curMonumentData; // 0x88
	static System.String iconPathFormat; // 0x8
	static System.String iconEnemy; // 0x10
	static System.String iconTF; // 0x18
	static System.String iconRadiation; // 0x20
	static System.String iconBeast; // 0x28
	static System.String iconLowTemp; // 0x30
	static System.String iconUnderwater; // 0x38
	static System.String iconDarkArea; // 0x40
	static System.String defaultItemIcon; // 0x48
	WizardGames.Soc.SocClient.Ui.Map.MainObMap Map; // 0x90
	System.Void .ctor(FairyGUI.GComponent root); // 0x066fd5d8
	System.Void SetData(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData, WizardGames.Soc.SocClient.Ui.Map.MainObMap map); // 0x066fda60
	System.Void RefreshPanel(WizardGames.Soc.SocClient.Ui.Map.SiteItemInfo data); // 0x066fde54
	System.Void RefreshThreatList(WizardGames.Soc.Common.Data.mapmark.MonumentMapInfo monumentInfo); // 0x066fe854
	System.Boolean CheckIfListIsWrapped(FairyGUI.GList list); // 0x066ff6b0
	System.Void OnThreatItemRender(System.Int32 index, FairyGUI.GObject gObject); // 0x066ff894
	System.Void RefreshFeatureList(WizardGames.Soc.Common.Data.mapmark.MonumentMapInfo monumentInfo); // 0x066fef80
	System.Void OnFeatureItemRender(System.Int32 index, FairyGUI.GObject gObject); // 0x066ffb2c
	System.Void RefreshSupplies(System.Int32[] supplies, FairyGUI.GList targetList, FairyGUI.GComponent targetCom, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.ItemInfo> itemInfoList); // 0x066ff37c
	System.Void OnSuppliesRender(System.Int32 index, FairyGUI.GObject gObject); // 0x066ffd3c
	System.Void OnCardRoomRender(System.Int32 index, FairyGUI.GObject gObject); // 0x066fff80
	System.Void UpdateUnlockTime(WizardGames.Soc.Common.Data.mapmark.MonumentMapInfo monumentInfo); // 0x066fe6d0
	System.Boolean NeedShowRotationMonumentUnLockTime(WizardGames.Soc.Common.Data.mapmark.MonumentMapInfo monumentInfo, System.String& timeText); // 0x067001c4
	static System.Void .cctor(); // 0x0670036c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MonumentMarkerObDetailView.<>c__DisplayClass30_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.Map.MonumentMarkerObDetailView <>4__this; // 0x10
	WizardGames.Soc.Common.Data.mapmark.MonumentMapInfo monumentInfo; // 0x18
	System.Void .ctor(); // 0x0670062c
	System.Void <RefreshPanel>b__0(); // 0x06700694
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MonumentMarkerObDetailView.<>c__DisplayClass33_0 : System.Object
{
	FairyGUI.GComponent threatCom; // 0x10
	WizardGames.Soc.SocClient.Ui.Map.ItemInfo threatInfo; // 0x18
	System.Void .ctor(); // 0x06700778
	System.Void <OnThreatItemRender>b__0(); // 0x067007e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MonumentMarkerObDetailView.<>c__DisplayClass35_0 : System.Object
{
	FairyGUI.GObject gObject; // 0x10
	WizardGames.Soc.SocClient.Ui.Map.MonumentMarkerObDetailView <>4__this; // 0x18
	System.Int32 index; // 0x20
	System.Void .ctor(); // 0x06700850
	System.Void <OnFeatureItemRender>b__0(); // 0x067008b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MonumentMarkerObDetailView.<>c__DisplayClass37_0 : System.Object
{
	FairyGUI.GObject gObject; // 0x10
	WizardGames.Soc.SocClient.Ui.Map.ItemInfo itemInfo; // 0x18
	System.Void .ctor(); // 0x06700974
	System.Void <OnSuppliesRender>b__0(); // 0x067009dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MonumentMarkerObDetailView.<>c__DisplayClass38_0 : System.Object
{
	FairyGUI.GObject gObject; // 0x10
	WizardGames.Soc.SocClient.Ui.Map.ItemInfo itemInfo; // 0x18
	System.Void .ctor(); // 0x06700a4c
	System.Void <OnCardRoomRender>b__0(); // 0x06700ab4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MiniMap : WizardGames.Soc.SocClient.Ui.Map.MapBase
{
	WizardGames.Soc.SocClient.Ui.Map.MiniMapView <View>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Marker.MiniMapStage <MarkerStage>k__BackingField; // 0x48
	System.Boolean get_Active(); // 0x06700b24
	WizardGames.Soc.SocClient.Ui.Map.MiniMapView get_View(); // 0x06700c54
	System.Void set_View(WizardGames.Soc.SocClient.Ui.Map.MiniMapView value); // 0x06700cb8
	WizardGames.Soc.SocClient.Marker.MiniMapStage get_MarkerStage(); // 0x06700d38
	System.Void set_MarkerStage(WizardGames.Soc.SocClient.Marker.MiniMapStage value); // 0x06700d9c
	System.Void Init(FairyGUI.GComponent uiNode); // 0x06700e1c
	System.Void OnEnable(); // 0x067012ec
	System.Void OnDisable(); // 0x067013f8
	System.Void OnDestroy(); // 0x06701504
	System.Void OnFpsUnlimitedUpdate(); // 0x067016cc
	System.Void OnFps30Update(); // 0x06701780
	System.Void OnFps10Update(); // 0x0670188c
	System.Void OnFps1Update(); // 0x0670193c
	System.Void .ctor(); // 0x06701a4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.MiniMapView : WizardGames.Soc.SocClient.Ui.Map.ViewBase
{
	UnityEngine.Vector2 viewCenter; // 0x90
	UnityEngine.Vector2 mapTextureSize; // 0x98
	UnityEngine.Vector2 textureScaleVector; // 0xa0
	WizardGames.Soc.SocClient.Ui.Marker.MapRoad mapRoad; // 0xa8
	System.Collections.Generic.List<UnityEngine.Material> matList; // 0xb0
	System.Single get_initContainerSize(); // 0x06701ad8
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.MapBase map); // 0x067010a0
	System.Void Init(FairyGUI.GComponent root); // 0x06701bc0
	System.Void OnDestroy(); // 0x06702548
	System.Void OnFps30Update(); // 0x06702618
	System.Void OnFps10Update(); // 0x06702c50
	System.Void InitMapTexLoader(); // 0x06701e90
	System.Void InitTrackLine(); // 0x06702414
	System.Void InitFairyBatching(); // 0x06702fa0
	System.Void RefreshPlayerToCenter(); // 0x0670267c
	System.Void RefreshMapTypeVisible(); // 0x06702cb4
	System.Void SwitchMapTexture(WizardGames.Soc.SocClient.Ui.Map.EMapLevel mapLevel); // 0x0670222c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.RespawnMap : WizardGames.Soc.SocClient.Ui.Map.MapBase
{
	SocLogger log; // 0x40
	WizardGames.Soc.SocClient.Ui.Map.RespawnMapView <View>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Marker.RespawnMapStage <MarkerStage>k__BackingField; // 0x50
	WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo <CurSelectedMarkerInfo>k__BackingField; // 0x58
	WizardGames.Soc.SocClient.Ui.Map.RespawnMapView get_View(); // 0x06703108
	System.Void set_View(WizardGames.Soc.SocClient.Ui.Map.RespawnMapView value); // 0x0670316c
	WizardGames.Soc.SocClient.Marker.RespawnMapStage get_MarkerStage(); // 0x067031ec
	System.Void set_MarkerStage(WizardGames.Soc.SocClient.Marker.RespawnMapStage value); // 0x06703250
	WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo get_CurSelectedMarkerInfo(); // 0x067032d0
	System.Void set_CurSelectedMarkerInfo(WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo value); // 0x06703334
	System.Boolean get_Active(); // 0x067033b4
	System.Single get_MapScale(); // 0x067034e4
	System.Void set_MapScale(System.Single value); // 0x06703548
	System.Void Init(FairyGUI.GComponent uiNode); // 0x06703644
	System.Void UnLimitSetMapScale(System.Single scale); // 0x06703b18
	System.Void SelectedPointChange(WizardGames.Soc.SocClient.Ui.RespawnRebornPoint data); // 0x06703c00
	System.Void OnEnable(); // 0x0670403c
	System.Void OnDisable(); // 0x06704154
	System.Void OnDestroy(); // 0x06704260
	System.Void OnFps1Update(); // 0x067044d4
	System.Void OnFps30Update(); // 0x067045f0
	System.Void SetCurSelectedMarkerInfo(System.Int64 markerId); // 0x067046b0
	System.Void SelectMarker(System.Int64 markerId); // 0x0670473c
	System.Void LocateToMarker(System.Int64 markerId, System.Boolean needAni); // 0x0670480c
	System.Void .ctor(); // 0x06704c38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.RespawnMapView : WizardGames.Soc.SocClient.Ui.Map.ViewBase, WizardGames.Soc.SocClient.Ui.Map.IGridContainer
{
	FairyGUI.PinchGesture pinchGesture; // 0x90
	System.Boolean isGestureValid; // 0x98
	FairyGUI.GComponent comScaleWidgetParent; // 0xa0
	FairyGUI.GSlider scaleSlider; // 0xa8
	FairyGUI.GButton btnGridSwitch; // 0xb0
	System.Boolean isFirstTip; // 0xb8
	FairyGUI.GGraph rangeGraph; // 0xc0
	UnityEngine.Vector3 diePos; // 0xc8
	FairyGUI.GButton scalePlusBtn; // 0xd8
	FairyGUI.GButton scaleMinusBtn; // 0xe0
	WizardGames.Soc.SocClient.Ui.Map.Misc.MapGridManager gridManager; // 0xe8
	WizardGames.Soc.SocClient.Manager.HotKeyAction wheelUpAction; // 0xf0
	WizardGames.Soc.SocClient.Manager.HotKeyAction wheelDownAction; // 0xf8
	System.Single nearbyRadius; // 0x100
	WizardGames.Soc.SocClient.Ui.Map.RespawnMap get_Map(); // 0x06704d60
	System.Single get_InitContainerSize(); // 0x06704e0c
	System.Single get_CurrentContainerSize(); // 0x06704ebc
	System.Single get_MaxContainerSize(); // 0x06704f70
	FairyGUI.GComponent get_GridContainer(); // 0x06705018
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.MapBase mapWrapper); // 0x067039f0
	System.Void Init(FairyGUI.GComponent root); // 0x067050b0
	System.Void OnDestroy(); // 0x06706894
	System.Void OnEnable(); // 0x06706cfc
	System.Void OnDisable(); // 0x06706e58
	System.Void OnWheelUp(); // 0x06706efc
	System.Void OnWheelDown(); // 0x06706fdc
	System.Void InitFairyBatching(); // 0x067070bc
	System.Void InitRangeGraph(); // 0x067061a4
	System.Void SetRangeGraphVisible(System.Boolean visible); // 0x06703e60
	System.Void SetRangeGraphSize(System.Single size); // 0x06703f58
	System.Void InitMapTexLoader(); // 0x067058c8
	System.Void OnGesturePreBegin(); // 0x06707224
	System.Void OnGestureAction(); // 0x06707884
	System.Void OnGestureEnd(); // 0x067079f4
	System.Void OnDragStart(); // 0x067083d0
	System.Void OnDragMove(); // 0x067084d0
	System.Void OnDragEnd(); // 0x06708568
	UnityEngine.Rect GetDragBound(); // 0x06707bb8
	System.Void CheckBoundClamp(); // 0x06707f5c
	System.Void SetMapPivot(UnityEngine.Vector2 p, System.Boolean isPercent); // 0x0670769c
	System.Void UpdateMapViewScale(System.Single oldScale, System.Single newScale); // 0x067085e4
	System.Void OnMapBlankClick(FairyGUI.EventContext e); // 0x067086f4
	UnityEngine.Vector2 TransformUiRootNodeCenterToTarget(FairyGUI.GObject targetObj); // 0x06708768
	System.Boolean IsTouchPointInView(UnityEngine.Vector2 touchPointLocal); // 0x06707554
	System.Void OnFps1Update(); // 0x06708940
	System.Void SetGridActive(System.Boolean active); // 0x067089a8
	System.Void LocateMapToCenter(UnityEngine.Vector2 posInContainer, System.Boolean needAni); // 0x06704960
	System.Void SetNodeCenterAsContainerPivot(); // 0x06708a30
	System.Void InitScaleWidgets(); // 0x06705ba0
	System.Void OnScaleBtnClick(System.Boolean isPositiveDelta); // 0x06708bcc
	System.Void OnSliderValueChanged(); // 0x06708aec
	System.Void UpdateSliderValue(System.Single oldScale, System.Single newScale); // 0x06708cc4
	System.Void MoveMapToViewCenterByWorldPosition(UnityEngine.Vector3 worldPosition, System.Boolean needAni); // 0x06708ec0
	System.Void <LocateMapToCenter>b__51_0(); // 0x06709060
	System.Void <InitScaleWidgets>b__53_0(FairyGUI.EventContext ctx); // 0x067090f8
	System.Void <InitScaleWidgets>b__53_1(FairyGUI.EventContext ctx); // 0x06709174
	System.Void <InitScaleWidgets>b__53_2(); // 0x067091f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.EventSubView : WizardGames.Soc.SocClient.Ui.Map.SidePanelSubviewBase
{
	static SocLogger log; // 0x0
	FairyGUI.Controller inProgressCtrl; // 0x48
	FairyGUI.Controller advanceCtrl; // 0x50
	FairyGUI.GList inProgressList; // 0x58
	FairyGUI.GList advanceList; // 0x60
	FairyGUI.GComponent inProgressText; // 0x68
	FairyGUI.GComponent advanceText; // 0x70
	System.Collections.Generic.Dictionary<System.Int32,System.UInt32> comingEvents; // 0x78
	System.Collections.Generic.Dictionary<System.Int32,System.UInt32> endingEvents; // 0x80
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.EventMarkerData> inProgressEventDatas; // 0x88
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.EventMarkerData> allInProgressEventDatas; // 0x90
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.EventMarkerData> advanceEventDatas; // 0x98
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.EventMarkerData> allAdvanceEventDatas; // 0xa0
	System.Int64 timerId; // 0xa8
	UnityEngine.Transform selfTransform; // 0xb0
	System.Boolean hasAddListener; // 0xb8
	System.Int64 curSelectMarkerId; // 0xc0
	WizardGames.Soc.Common.Data.MarkerType curSelectMarkerType; // 0xc8
	WizardGames.Soc.SocClient.Ui.Map.EMapEventType curSelectType; // 0xcc
	System.Void OnInit(); // 0x06709394
	System.Void ParseInProgressEventDatas(); // 0x067096f0
	System.Void ParseAdvanceEventDatas(); // 0x06709ea4
	System.String GetEventIconUrl(WizardGames.Soc.Common.Data.mapmark.NewMarker config, WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x06709dac
	System.Void RefreshInProgressList(); // 0x0670a33c
	System.Void RefreshAdvanceList(); // 0x0670a6f8
	System.Void RenderInProgressItem(System.Int32 index, FairyGUI.GObject obj); // 0x0670aab4
	System.Void RenderAdvanceItem(System.Int32 index, FairyGUI.GObject obj); // 0x0670aec8
	System.Void OnInProgressItemClick(System.Int32 index); // 0x0670b288
	System.Void OnAdvanceItemClick(System.Int32 index); // 0x0670b478
	System.Void Refresh(); // 0x0670b614
	System.Void OnComingEventsUpdate(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int32 markerType, System.UInt32 _); // 0x0670b68c
	System.Void OnEndingEventsUpdate(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int32 markerType, System.UInt32 _); // 0x0670b880
	System.Void OnMarkerDataCreate(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x0670ba74
	System.Void OnMarkerDataRemove(System.Int64 id); // 0x0670bbfc
	System.Void TimerCallBack(System.Int64 timerId, System.Object _, System.Boolean delete); // 0x0670bdf0
	System.Int32 GetDistance(WizardGames.Soc.SocClient.Marker.MarkerBaseData data); // 0x0670c6c8
	System.Void ClearTimer(); // 0x0670c820
	System.Void SelectItem(System.Int64 markerId, WizardGames.Soc.Common.Data.MarkerType markerType); // 0x0670c928
	System.Void OnEnable(); // 0x055049cc
	System.Void OnDisable(); // 0x0670d7fc
	System.Void .ctor(); // 0x0670dbf0
	static System.Void .cctor(); // 0x0670dda8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.EventSubView.<>c__DisplayClass25_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.Map.EventSubView <>4__this; // 0x10
	System.Int32 index; // 0x18
	WizardGames.Soc.SocClient.Ui.Map.EventMarkerData data; // 0x20
	System.Void .ctor(); // 0x0670ae60
	System.Void <RenderInProgressItem>b__0(); // 0x0670de7c
	System.Void <RenderInProgressItem>b__1(); // 0x0670df60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.EventSubView.<>c__DisplayClass26_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.Map.EventSubView <>4__this; // 0x10
	System.Int32 index; // 0x18
	WizardGames.Soc.SocClient.Ui.Map.EventMarkerData data; // 0x20
	System.Void .ctor(); // 0x0670b220
	System.Void <RenderAdvanceItem>b__0(); // 0x0670e194
	System.Void <RenderAdvanceItem>b__1(); // 0x0670e278
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.FilterSubview : System.Object
{
	FairyGUI.GButton allSelectBtn; // 0x10
	FairyGUI.GList filterList; // 0x18
	FairyGUI.Controller tipsCtrl; // 0x20
	WizardGames.Soc.SocClient.Ui.Map.MainMap map; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.mapmark.FilterType> descendingDataList; // 0x30
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> filterSelectDic; // 0x38
	System.Void OnInit(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.Map.MainMap map); // 0x0670e37c
	System.Void InitFilterList(); // 0x0670e660
	System.Void OnEnable(); // 0x0670ea94
	System.Void OnDisable(); // 0x0670efa8
	System.Void OnItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x0670f08c
	System.Void RefreshMark(); // 0x0670ed2c
	System.Void OnClickAllSelectBtn(FairyGUI.EventContext context); // 0x0670f3fc
	System.Void SetAllFilter(System.Boolean active); // 0x0670eb7c
	System.Void RefreshList(); // 0x0670e9fc
	System.Void .ctor(); // 0x0670f5c4
	System.Void <OnInit>b__6_0(FairyGUI.EventContext ctx); // 0x0670f6d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.FilterSubview.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.Map.FilterSubview.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Data.mapmark.FilterType> <>9__7_0; // 0x8
	static System.Void .cctor(); // 0x0670f7a8
	System.Void .ctor(); // 0x0670f80c
	System.Int32 <InitFilterList>b__7_0(WizardGames.Soc.Common.Data.mapmark.FilterType a, WizardGames.Soc.Common.Data.mapmark.FilterType b); // 0x0670f874
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.FilterSubview.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.Common.Data.mapmark.FilterType config; // 0x10
	FairyGUI.GButton selectState; // 0x18
	WizardGames.Soc.SocClient.Ui.Map.FilterSubview <>4__this; // 0x20
	System.Void .ctor(); // 0x0670f394
	System.Void <OnItemRenderer>b__0(FairyGUI.EventContext ctx); // 0x0670f910
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.ObserverPlayerSubview : WizardGames.Soc.SocClient.Ui.Map.SidePanelSubviewBase
{
	static UnityEngine.Color white; // 0x0
	static UnityEngine.Color red; // 0x10
	FairyGUI.GList itemList; // 0x48
	System.UInt64 lastSelectRoleId; // 0x50
	FairyGUI.GTextInput inputSearch; // 0x58
	FairyGUI.Controller ctrlSearchState; // 0x60
	FairyGUI.GButton btnClearInput; // 0x68
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo> searchResult; // 0x70
	System.Boolean searchMode; // 0x78
	WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo selectPlayerDetailInfo; // 0x80
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo> patrolPlayerBriefInfoList; // 0x88
	System.Double lastTouchTime; // 0x90
	System.Void OnInit(); // 0x0670fa88
	System.Void OnEnable(); // 0x067103b0
	System.Void OnDisable(); // 0x067105e8
	System.Void OnInputChanged(FairyGUI.EventContext context); // 0x067107e0
	System.Void ShowSearchResult(); // 0x067108d0
	System.Void OnBtnClearInputClick(FairyGUI.EventContext context); // 0x06710c68
	System.Void ClearSearchInput(); // 0x06710710
	System.Void OnGetAllPlayer(); // 0x0671051c
	System.Void RenderObserverItem(System.Int32 index, FairyGUI.GObject obj); // 0x06710cf4
	System.Boolean CheckPlayerSharp(WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo playerBriefInfo); // 0x06711720
	System.Void OnClickItem(FairyGUI.EventContext context); // 0x067117ec
	System.Void .ctor(); // 0x06711a3c
	static System.Void .cctor(); // 0x06711af0
	System.Void <OnInit>b__13_0(FairyGUI.EventContext ctx); // 0x06711b48
	System.Void <OnInit>b__13_3(FairyGUI.EventContext context); // 0x06711c2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.ObserverPlayerSubview.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.Map.ObserverPlayerSubview.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__13_1; // 0x8
	static FairyGUI.EventCallback1 <>9__13_2; // 0x10
	static FairyGUI.EventCallback1 <>9__13_4; // 0x18
	static System.Void .cctor(); // 0x06711ce8
	System.Void .ctor(); // 0x06711d4c
	System.Void <OnInit>b__13_1(FairyGUI.EventContext ctx); // 0x06711db4
	System.Void <OnInit>b__13_2(FairyGUI.EventContext context); // 0x06711e64
	System.Void <OnInit>b__13_4(FairyGUI.EventContext context); // 0x06711ee8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.ObserverPlayerSubview.<>c__DisplayClass21_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.Map.ObserverPlayerSubview <>4__this; // 0x10
	FairyGUI.GTextField roleIdTxt; // 0x18
	FairyGUI.GTextField openIdTxt; // 0x20
	System.Void .ctor(); // 0x067116b8
	System.Void <RenderObserverItem>b__0(FairyGUI.EventContext ctx); // 0x06711f6c
	System.Void <RenderObserverItem>b__1(FairyGUI.EventContext ctx); // 0x06711ff8
	System.Void <RenderObserverItem>b__2(FairyGUI.EventContext ctx); // 0x06712170
	System.Void <RenderObserverItem>b__3(FairyGUI.EventContext ctx); // 0x067121fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.ObserverTerritorySubview : WizardGames.Soc.SocClient.Ui.Map.SidePanelSubviewBase
{
	FairyGUI.GList itemList; // 0x48
	FairyGUI.GButton lastSelectItem; // 0x50
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PatrolTerritoryBriefInfo> patrolTerritoryBriefInfoList; // 0x58
	System.Void OnInit(); // 0x06712374
	System.Void OnEnable(); // 0x06712478
	System.Void OnDisable(); // 0x067126ac
	System.Void OnGetAllTerritory(); // 0x067125e0
	System.Void RenderObserverItem(System.Int32 index, FairyGUI.GObject obj); // 0x06712800
	System.Void OnClickItem(System.Int32 index); // 0x06712b60
	System.Void .ctor(); // 0x06712d10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.ObserverTerritorySubview.<>c__DisplayClass7_0 : System.Object
{
	FairyGUI.Controller selectCtrl; // 0x10
	WizardGames.Soc.SocClient.Ui.Map.ObserverTerritorySubview <>4__this; // 0x18
	FairyGUI.GButton btn; // 0x20
	System.Int32 index; // 0x28
	System.Void .ctor(); // 0x06712af8
	System.Void <RenderObserverItem>b__0(FairyGUI.EventContext ctx); // 0x06712d78
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.RespawnSubview : WizardGames.Soc.SocClient.Ui.Map.SidePanelSubviewBase
{
	static System.String defaultSiteIcon; // 0x0
	FairyGUI.GList respawnList; // 0x48
	FairyGUI.GButton ComEmpty; // 0x50
	System.Void Show(); // 0x06712e84
	System.Void Hide(); // 0x06712eec
	System.Void Refresh(); // 0x06712f54
	System.Void OnInit(); // 0x06713308
	System.Void OnDestroy(); // 0x067135e4
	System.Void OnEnable(); // 0x067136e8
	System.Void OnDisable(); // 0x0671383c
	System.Void InitList(); // 0x0671375c
	System.Void ClearList(); // 0x067138ac
	System.Void BuildFromRespawnInfo(); // 0x06713a88
	System.Void BuildItem(WizardGames.Soc.SocClient.Ui.Map.RespawnItemInfo itemInfo, System.Int32 index); // 0x067143a0
	System.Void OnSelectItem(FairyGUI.EventContext context); // 0x06714a78
	System.Void OnClickRenameBtn(FairyGUI.EventContext context); // 0x06714cdc
	System.Void ClientRename(System.Int64 entityId, System.String newName); // 0x06715060
	System.Void OnClickDeleteBtn(FairyGUI.EventContext context); // 0x0671515c
	System.Void OnItemTimerTick(System.Object param); // 0x06715804
	System.Void LocateItem(); // 0x06712fc4
	System.Void .ctor(); // 0x06715c60
	static System.Void .cctor(); // 0x06715cc8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.RespawnSubview.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.Map.RespawnSubview <>4__this; // 0x10
	System.Int64 entityId; // 0x18
	System.Void .ctor(); // 0x06714ff8
	System.Void <OnClickRenameBtn>b__0(System.String str); // 0x06715d30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.RespawnSubview.<>c__DisplayClass17_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.Map.RespawnSubview <>4__this; // 0x10
	System.Int64 entityId; // 0x18
	System.Void .ctor(); // 0x0671579c
	System.Void <OnClickDeleteBtn>b__0(); // 0x06715db8
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.Map.EShopType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.Map.EShopType Default = 0;
	static WizardGames.Soc.SocClient.Ui.Map.EShopType Horse = 1;
	static WizardGames.Soc.SocClient.Ui.Map.EShopType Helicopter = 2;
	static WizardGames.Soc.SocClient.Ui.Map.EShopType UserShop = 3;
	static WizardGames.Soc.SocClient.Ui.Map.EShopType Ship = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.ShopSubview : WizardGames.Soc.SocClient.Ui.Map.SidePanelSubviewBase
{
	static System.Int64 HorseNpcId; // 0x0
	static System.Int64 HelicopterNpcId; // 0x8
	static System.Int64 ShipNpcId; // 0x10
	FairyGUI.GList shopList; // 0x48
	System.Int64 curExpandTab; // 0x50
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.ShopSubview.ShopGroupData> shopGroupDatas; // 0x58
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.ShopSubview.TabData> tabDataList; // 0x60
	System.Int64 lastSelectTabId; // 0x68
	FairyGUI.GButton lastSelectShopItem; // 0x70
	System.Collections.Generic.Dictionary<System.Int64,System.String> playerId2Name; // 0x78
	System.Void Show(); // 0x06715e84
	System.Void Hide(); // 0x06715eec
	System.Void Refresh(); // 0x06715f54
	System.Void OnInit(); // 0x06715fbc
	System.Void OnEnable(); // 0x06716120
	System.Void OnDisable(); // 0x06717628
	System.Void ParseShopListData(); // 0x06716190
	System.Void RefreshTabDatas(); // 0x06717690
	System.Void RenderShopItem(System.Int32 index, FairyGUI.GObject obj); // 0x06717a8c
	System.Void OnClickMainTab(WizardGames.Soc.SocClient.Ui.Map.ShopSubview.TabData tabdata); // 0x067188b4
	System.Void OnClickShopItem(System.Int64 shopId); // 0x0671894c
	static System.String GetSystemShopName(WizardGames.Soc.SocClient.Ui.Map.EShopType shopType, WizardGames.Soc.Common.CustomType.ShopInfo& shop); // 0x06718518
	System.Void .ctor(); // 0x06718d00
	static System.Void .cctor(); // 0x06718e70
	System.Void <ParseShopListData>b__22_1(SimpleJSON.JSONArray jsonArray); // 0x06718ec8
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.Map.ShopSubview.ETabType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.Map.ShopSubview.ETabType Main = 0;
	static WizardGames.Soc.SocClient.Ui.Map.ShopSubview.ETabType Sub = 1;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.Map.ShopSubview.TabData : System.ValueType
{
	WizardGames.Soc.SocClient.Ui.Map.ShopSubview.ETabType Type; // 0x10
	System.Int64 Id; // 0x18
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.Map.ShopSubview.ShopGroupData : System.ValueType
{
	System.Int64 OwnId; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.ShopInfo> ShopList; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.ShopSubview.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.Map.ShopSubview.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.Map.ShopSubview.ShopGroupData> <>9__22_0; // 0x8
	static System.Void .cctor(); // 0x06719114
	System.Void .ctor(); // 0x06719178
	System.Int32 <ParseShopListData>b__22_0(WizardGames.Soc.SocClient.Ui.Map.ShopSubview.ShopGroupData a, WizardGames.Soc.SocClient.Ui.Map.ShopSubview.ShopGroupData b); // 0x067191e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.ShopSubview.<>c__DisplayClass24_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.Map.ShopSubview <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.Map.ShopSubview.TabData tabdata; // 0x18
	FairyGUI.Controller selectCtrl; // 0x28
	FairyGUI.GButton btn; // 0x30
	System.Void .ctor(); // 0x06718448
	System.Void <RenderShopItem>b__0(FairyGUI.EventContext ctx); // 0x06719298
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.ShopSubview.<>c__DisplayClass24_1 : System.Object
{
	System.Int64 id; // 0x10
	WizardGames.Soc.SocClient.Ui.Map.ShopSubview.<>c__DisplayClass24_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x067184b0
	System.Void <RenderShopItem>b__1(FairyGUI.EventContext ctx); // 0x0671931c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.SiteSubview : WizardGames.Soc.SocClient.Ui.Map.SidePanelSubviewBase
{
	static System.String folderItemPath; // 0x0
	static System.String childItemPath; // 0x8
	UnityEngine.Vector3 myPos; // 0x48
	FairyGUI.GTree siteTree; // 0x58
	FairyGUI.GTreeNode siteRootNode; // 0x60
	FairyGUI.GTreeNode titleNodeSafeArea; // 0x68
	System.Collections.Generic.Dictionary<System.Int32,FairyGUI.GTreeNode> titleNodeMonumentMap; // 0x70
	System.Collections.Generic.List<FairyGUI.GTreeNode> gTreeNodePool; // 0x78
	System.Collections.Generic.List<FairyGUI.GTreeNode> gTreeNodeUsePool; // 0x80
	FairyGUI.GTreeNode selectedNode; // 0x88
	static System.Int32 ThreatTextConst(System.Int32 lvl); // 0x06719428
	System.Void Refresh(); // 0x067194ac
	System.Void OnInit(); // 0x067197b8
	System.Void OnEnable(); // 0x067199e0
	System.Void OnDisable(); // 0x06719a54
	System.Void InitMyPos(); // 0x06719abc
	System.Void InitGTree(); // 0x0671965c
	System.Void InitGTreeItems(); // 0x06719dc0
	System.Collections.Generic.List<System.Tuple<System.Int32,System.Single,System.Int32>> GetSortedSiteList(System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.GMarkerBase> markers); // 0x0671a7b8
	FairyGUI.GTreeNode InitGTreeFolder(System.String name); // 0x0671a504
	System.Void InitMonumentGTreeTiTleNode(); // 0x0671a668
	System.Void ClearGTree(); // 0x06719b9c
	FairyGUI.GTreeNode GetGTreeNode(System.Boolean isFolder, WizardGames.Soc.SocClient.Ui.Map.SiteItemInfo siteItemInfo); // 0x0671aef0
	System.Void RenderTreeNode(FairyGUI.GTreeNode node, FairyGUI.GComponent obj); // 0x0671b21c
	System.Void OnClickSiteItem(FairyGUI.EventContext context); // 0x0671b38c
	System.Void OnSelectItemMsg(); // 0x0671b67c
	System.Void OnItemSelectStateChange(FairyGUI.GTreeNode node, System.Boolean selected); // 0x0671b570
	FairyGUI.GTreeNode BuildSiteItem(System.String siteName, System.Int64 markerId, System.Int32 threatLevel); // 0x0671ac18
	System.Void SelectItem(System.Int64 markerId, WizardGames.Soc.Common.Data.MarkerType markerType); // 0x0671b8ec
	System.Void SelectNodeByMarker(System.Int64 markerId); // 0x0671a23c
	System.Void .ctor(); // 0x0671b984
	static System.Void .cctor(); // 0x0671bab4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.SiteSubview.<>c__DisplayClass24_0 : System.Object
{
	System.Boolean isFolder; // 0x10
	System.Void .ctor(); // 0x0671b1b4
	System.Boolean <GetGTreeNode>b__0(FairyGUI.GTreeNode node); // 0x0671bb4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.SouDJSubView : WizardGames.Soc.SocClient.Ui.Map.SidePanelSubviewBase
{
	WizardGames.Soc.SocClient.Ui.Binder.GameMainMap.SouDJSubViewBinder binder; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.SDJMapRankTeamInfo> rankTeamInfos; // 0x50
	UnityEngine.Vector3 tempPos; // 0x58
	System.Int32 myTeamMoney; // 0x64
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Map.SDJGoldAirdropInfo> goldAirdropInfos; // 0x68
	System.Void OnInit(); // 0x0671bbe4
	System.Void Refresh(); // 0x0671c1a0
	System.Void JumpToPage(System.Int32 pageIndex); // 0x0671c208
	System.Void OnTeamListItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x0671c2dc
	System.Void OnTeamListItemClick(FairyGUI.EventContext context); // 0x0671c524
	System.Void ParseRankInfos(); // 0x0671c828
	System.String GetPosGridName(System.Single x, System.Single y, System.Single z); // 0x0671ceb4
	System.Void GetRankInfoResult(System.Boolean isDailyRank); // 0x0671cf90
	System.Void RefreshTeamBottomPanel(); // 0x0671d2f4
	System.Void OpenRanView(); // 0x0671d4c8
	System.Void ParseAirdropInfos(); // 0x0671d52c
	System.Void OnAirdopItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x0671de2c
	System.Void OnAirdropItemClick(FairyGUI.EventContext context); // 0x0671e014
	System.Void OnEnable(); // 0x0671e318
	System.Void OnDisable(); // 0x0671e464
	System.Void .ctor(); // 0x0671e57c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.SouDJSubView.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.Map.SouDJSubView.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.Map.SDJGoldAirdropInfo> <>9__15_0; // 0x8
	static System.Void .cctor(); // 0x0671e6c8
	System.Void .ctor(); // 0x0671e72c
	System.Int32 <ParseAirdropInfos>b__15_0(WizardGames.Soc.SocClient.Ui.Map.SDJGoldAirdropInfo a, WizardGames.Soc.SocClient.Ui.Map.SDJGoldAirdropInfo b); // 0x0671e794
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.TerritorySubview : WizardGames.Soc.SocClient.Ui.Map.SidePanelSubviewBase
{
	static System.String folderItemPath; // 0x0
	static System.String childItemPath; // 0x8
	static System.String defaultIcon; // 0x10
	static System.String ToolCarbinetIcon; // 0x18
	static System.String IntelligenceToolCarbinetIcon; // 0x20
	static System.String BenchIconLevel0; // 0x28
	static System.String BenchIconLevel1; // 0x30
	static System.String BenchIconLevel2; // 0x38
	static System.String BenchIconLevel3; // 0x40
	static System.String PermissionIconYes; // 0x48
	static System.String TerritoryRustIcon; // 0x50
	static System.String TerritoryRepairIcon; // 0x58
	static System.String TerritoryRaidIcon; // 0x60
	static System.String TerritoryNoRaidIcon; // 0x68
	static System.String ComUnionBadge; // 0x70
	static System.Collections.Generic.Dictionary<System.Int32,System.String> benchIconDict; // 0x78
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32> benchLevelDict; // 0x80
	FairyGUI.GTree gTree; // 0x48
	FairyGUI.GTreeNode rootNode; // 0x50
	System.Collections.Generic.List<FairyGUI.GTreeNode> gTreeNodePool; // 0x58
	System.Collections.Generic.List<FairyGUI.GTreeNode> gTreeNodeUsePool; // 0x60
	System.Collections.Generic.Dictionary<System.Int32,System.Int64> index2Marker; // 0x68
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> marker2Index; // 0x70
	FairyGUI.GButton ComEmpty; // 0x78
	System.Void Show(); // 0x0671e828
	System.Void Hide(); // 0x0671e890
	System.Void Refresh(); // 0x0671e8f8
	System.Void OnInit(); // 0x0671edac
	System.Void OnEnable(); // 0x0671f054
	System.Void OnDisable(); // 0x0671f6ec
	System.Void ClearGTree(); // 0x0671f0d0
	FairyGUI.GTreeNode GetGTreeNode(System.Boolean isFolder); // 0x0671f75c
	System.Void BuildGListFromData(); // 0x0671f2c0
	System.Void GenerateChildItem(FairyGUI.GTreeNode par, System.String text, System.String iconPath); // 0x067202bc
	System.Void GenerateItemGroup(WizardGames.Soc.Common.CustomType.BriefPrivilegeInfo info, System.Int64 markerId); // 0x0671f9a4
	System.Void RefreshUnionInfo(WizardGames.Soc.Common.CustomType.CommunityInfo communityInfo, FairyGUI.GTreeNode titleNode); // 0x06720dc4
	System.String GenerateTitleInfoSuffix(WizardGames.Soc.Common.CustomType.BriefTerritoryInfo tInfo, System.String terrName); // 0x06720480
	System.Void GenerateRaidProtectChildItem(WizardGames.Soc.Common.CustomType.BriefTerritoryInfo tInfo, FairyGUI.GTreeNode titleNode); // 0x06720b8c
	System.Void GeneratePermissionChildItem(WizardGames.Soc.Common.CustomType.BriefPrivilegeInfo info, FairyGUI.GTreeNode titleNode); // 0x067206cc
	System.Void OnClickItem(FairyGUI.EventContext context); // 0x067212d4
	System.Void GTreeSelectItem(FairyGUI.GTreeNode node); // 0x06721590
	System.Void LocateTitle(); // 0x0671e968
	System.Boolean IsShowUnion(WizardGames.Soc.Common.CustomType.CommunityInfo communityInfo, System.String& unionName, System.Collections.Generic.List<System.Int32>& iconList); // 0x06721104
	System.Void .ctor(); // 0x06721788
	static System.Void .cctor(); // 0x0672191c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.TerritorySubview.<>c__DisplayClass31_0 : System.Object
{
	System.Boolean isFolder; // 0x10
	System.Void .ctor(); // 0x06721d64
	System.Boolean <GetGTreeNode>b__0(FairyGUI.GTreeNode node); // 0x06721dcc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.TerritorySubview.<>c__DisplayClass35_0 : System.Object
{
	FairyGUI.GButton unionBtn; // 0x10
	System.String unionName; // 0x18
	System.Void .ctor(); // 0x06721e64
	System.Void <RefreshUnionInfo>b__0(); // 0x06721ecc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.Misc.MapGridManager : System.Object
{
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.Map.Misc.MapGridManager.Line> horizontalLines; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.Map.Misc.MapGridManager.Line> verticalLines; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.Map.Misc.MapGridManager.Label> labels; // 0x20
	WizardGames.Soc.SocClient.Ui.Map.IGridContainer container; // 0x28
	UnityEngine.Rect visibleGlobalRect; // 0x30
	static UnityEngine.Color LineColor; // 0x0
	System.Collections.Generic.List<FairyGUI.GGraph> graphPool; // 0x40
	FairyGUI.GObjectPool labelPool; // 0x48
	System.Single unitUv; // 0x50
	System.Int32 validLabelIndex; // 0x54
	System.Boolean IgnoreAlpha; // 0x58
	System.Single MaxScaleRatio; // 0x5c
	System.Single MinScaleRatio; // 0x60
	System.Single CurScaleRatio; // 0x64
	System.Single CurLineAlpha; // 0x68
	System.Single CurLabelAlpha; // 0x6c
	System.Boolean isVisible; // 0x70
	System.Boolean get_IsVisible(); // 0x06721fd4
	System.Void set_IsVisible(System.Boolean value); // 0x06722038
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.IGridContainer container, System.Single maxScale, System.Single minScale, System.Boolean IgnoreAlpha); // 0x067227f0
	System.Void Destroy(); // 0x06722cd0
	System.Void Refresh(System.Boolean isTransformRefresh); // 0x06722168
	System.Void RefreshLine(System.Int32 min, System.Int32 max, System.Boolean isHorizontal, System.Boolean isTransformRefresh); // 0x06723768
	System.Void RefreshLabel(System.Int32 xMin, System.Int32 yMin, System.Int32 xMax, System.Int32 yMax, System.Boolean isTransformRefresh); // 0x06723d00
	System.Int32 GetLabelIndex(System.Int32 x, System.Int32 y); // 0x06724bd8
	System.Void CalculateAlpha(); // 0x067234a4
	static System.Void .cctor(); // 0x0672507c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.Misc.MapGridManager.Line : System.Object
{
	WizardGames.Soc.SocClient.Ui.Map.Misc.MapGridManager gridManager; // 0x10
	System.Boolean isHorizontal; // 0x18
	FairyGUI.GGraph graph; // 0x20
	System.Int32 index; // 0x28
	System.Void Setup(WizardGames.Soc.SocClient.Ui.Map.Misc.MapGridManager gridManager, System.Int32 index, System.Boolean isHorizontal); // 0x06724620
	System.Void Update(); // 0x06724440
	System.Void Release(); // 0x0672322c
	System.Void .ctor(); // 0x067250e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Map.Misc.MapGridManager.Label : System.Object
{
	WizardGames.Soc.SocClient.Ui.Map.Misc.MapGridManager gridManager; // 0x10
	System.Int32 <X>k__BackingField; // 0x18
	System.Int32 <Y>k__BackingField; // 0x1c
	FairyGUI.GComponent label; // 0x20
	System.Int32 get_X(); // 0x06725150
	System.Void set_X(System.Int32 value); // 0x067251b4
	System.Int32 get_Y(); // 0x0672522c
	System.Void set_Y(System.Int32 value); // 0x06725290
	System.Void Setup(WizardGames.Soc.SocClient.Ui.Map.Misc.MapGridManager gridManager, System.Int32 x, System.Int32 y); // 0x06724c60
	System.Void Update(); // 0x067249b0
	System.Void Release(); // 0x06723350
	System.Void .ctor(); // 0x06725308
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.KillDataEvent.MgrKillDataEvent : WizardGames.Soc.Common.Manager.MgrBase
{
	static System.String UIName; // 0x0
	System.Void Init(); // 0x06725370
	System.Threading.Tasks.Task AfterEnterWorld(); // 0x067253d8
	System.Threading.Tasks.Task OnExitWorld(); // 0x067255cc
	System.Void RegisterKillDataEvent(); // 0x06725448
	System.Void UnregisterKillDataEvent(); // 0x0672563c
	System.Void OnAddKillEventData(WizardGames.Soc.Common.SimpleCustom.KillEventData data); // 0x067257c0
	System.Void ShowKillEventDataWindow(WizardGames.Soc.Common.SimpleCustom.KillEventData data); // 0x0672583c
	System.Void .ctor(); // 0x06725968
	static System.Void .cctor(); // 0x067259d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.FocusInfo.MgrFocusInfo : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Boolean isFocusInfoOpen; // 0x11
	System.String uiName; // 0x18
	System.String uiName2; // 0x20
	static System.Collections.Generic.HashSet<System.Int32> ValidTypes; // 0x0
	System.Threading.Tasks.Task AfterEnterWorld(); // 0x06725a38
	System.Threading.Tasks.Task OnExitWorld(); // 0x06725d60
	System.Void RegisterFocusInfoEvent(); // 0x06725b58
	System.Void UnregisterFocusInfoEvent(); // 0x06725e80
	System.Void UpdateRaycastTarget(System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData> hitObjDataList, WizardGames.Soc.SocClient.Systems.HitObjData obstacle); // 0x06726088
	System.Boolean CheckTag(); // 0x06726280
	System.Boolean DoCheckHudStatus(); // 0x06726a48
	System.Boolean CheckNeedShowForRaycastTarget(System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData> hitObjDataList, WizardGames.Soc.SocClient.Systems.HitObjData obstacle); // 0x06726388
	WizardGames.Soc.SocClient.Systems.HitObjData GetBaseEntity(System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData> hitObjDataList, WizardGames.Soc.SocClient.Systems.HitObjData obstacle); // 0x06726ed8
	System.Void ShowFocusInfo(); // 0x06726cb8
	System.Void HideFocusInfo(); // 0x06726e04
	System.Void OnCloseFocusInfoNotice(); // 0x067272b4
	System.Void OnHudOpenStatesChange(); // 0x06727318
	System.Void OpenQuickChat(System.Int32 textId, System.Int64 entityId); // 0x06727394
	System.Void .ctor(); // 0x067274f8
	static System.Void .cctor(); // 0x067275a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.FocusInfo.MgrFocusInfo.<>c__DisplayClass17_0 : System.Object
{
	System.Int32 textId; // 0x10
	System.Int64 entityId; // 0x18
	System.Void .ctor(); // 0x06727490
	System.Void <OpenQuickChat>b__0(WizardGames.Soc.SocClient.Ui.UiQuickChatBubble win); // 0x06727774
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDecal.Mgr.MgrDecal : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger <log>k__BackingField; // 0x0
	UnityEngine.RaycastHit[] cache; // 0x18
	System.Void .ctor(); // 0x06727800
	static System.Void .cctor(); // 0x06727898
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Joystick.HorseJoystick : WizardGames.Soc.SocClient.Ui.Joystick.PlayerJoystick
{
	System.Single cancelSprintPercent; // 0x34
	System.Void .ctor(); // 0x0672796c
	System.Single GetClampByInputDeltaPos(UnityEngine.Vector2 input, System.Single width); // 0x06727e04
	WizardGames.Soc.SocClient.Ui.MoveState GetInputMoveState(System.Boolean sprintLock, WizardGames.Soc.SocClient.Ui.MoveState nowState, UnityEngine.Vector2 inputPos, System.Boolean isDeadZone, System.Single width, UnityEngine.Vector2 scale, System.Single& percent); // 0x06727f4c
	System.Boolean CanSprintInputMoveStateViaRide(); // 0x0672814c
	System.Boolean IsInSprintAngleInSprint(UnityEngine.Vector2 input); // 0x06728200
	System.Boolean CancleLockRun(UnityEngine.Vector2 input, System.Single width); // 0x06728568
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Joystick.PlayerJoystick : System.Object
{
	static SocLogger logger; // 0x0
	System.Single deadXZone; // 0x10
	System.Single deadYZone; // 0x14
	System.Single joyStickRunThreshold; // 0x18
	System.Single toleranceAngleF; // 0x1c
	System.Single toleranceAngleLR; // 0x20
	System.Single toleranceAngleB; // 0x24
	System.Single directionFBRangeAngle; // 0x28
	System.Single directionLRRangeAngle; // 0x2c
	System.Single sprintHotspotAng; // 0x30
	System.Void .ctor(); // 0x06727b08
	System.Boolean InDeadZone(UnityEngine.Vector2& inputPos, UnityEngine.Vector2 scale); // 0x06728668
	System.Single GetInputAngle(UnityEngine.Vector2& inputPos, System.Boolean snapX, System.Boolean snapY); // 0x067287e4
	System.Void GetInputDirect(UnityEngine.Vector2 inputPos, WizardGames.Soc.Common.Data.ActionName& vertical, WizardGames.Soc.Common.Data.ActionName& horizontal); // 0x06728c64
	WizardGames.Soc.SocClient.Ui.MoveState GetInputMoveState(System.Boolean sprintLock, WizardGames.Soc.SocClient.Ui.MoveState nowState, UnityEngine.Vector2 inputPos, System.Boolean isDeadZone, System.Single width, UnityEngine.Vector2 scale, System.Single& percent); // 0x06728e7c
	UnityEngine.Vector2 GetInputPosWithOutScale(UnityEngine.Vector2 inputWithScale, UnityEngine.Vector2 scale); // 0x06728750
	System.Single GetClampByInputDeltaPos(UnityEngine.Vector2 input, System.Single width); // 0x06728fcc
	System.Boolean IsInSprintClamp(UnityEngine.Vector2 input, System.Single angle, System.Single width, UnityEngine.Vector2 scale); // 0x06728444
	System.Single GetSprintClamp(UnityEngine.Vector2 scale); // 0x067283a8
	System.Boolean IsInSprintAngle(UnityEngine.Vector2 input, System.Single angle); // 0x067290bc
	static System.Void .cctor(); // 0x06729268
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Construction.BlueprintPartViewData : WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBlueprintState
{
	WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType <PartViewDataType>k__BackingField; // 0x70
	WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType get_PartViewDataType(); // 0x0672933c
	System.Void SetBuildData(WizardGames.Soc.Common.Data.constraction.ConstructionBueprint constructionBlueprint, System.Int32 firstTag, System.Int32 secondTag); // 0x067293a0
	WizardGames.Soc.SocClient.Ui.ConstructionInfoData GetTipsInfo(WizardGames.Soc.SocClient.Ui.ConstructionInfoData constructionInfoData, WizardGames.Soc.SocClient.Ui.EConstructionEditMode& editMode); // 0x067299a0
	System.Void .ctor(); // 0x06729ea8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Construction.ComboPartViewData : WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBlueprintState
{
	WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType <PartViewDataType>k__BackingField; // 0x70
	WizardGames.Soc.Common.Construction.ConstructionGrade defaultConstructionGrade; // 0x74
	System.Int64 <ComboId>k__BackingField; // 0x78
	System.Int64 <ChildGroupId>k__BackingField; // 0x80
	System.Collections.Generic.List<System.String> <ChildIconUrls>k__BackingField; // 0x88
	WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType get_PartViewDataType(); // 0x06729fe8
	System.Int64 get_ComboId(); // 0x0672a04c
	System.Void set_ComboId(System.Int64 value); // 0x0672a0b0
	System.Int64 get_ChildGroupId(); // 0x0672a128
	System.Void set_ChildGroupId(System.Int64 value); // 0x0672a18c
	System.Collections.Generic.List<System.String> get_ChildIconUrls(); // 0x0672a204
	System.Void OnGet(); // 0x0672a268
	System.Void OnRelease(); // 0x0672a330
	System.Int32 GetLockStateImpl(); // 0x0672a8ec
	System.String GetPieName(); // 0x0672aa3c
	System.Void SetBuildData(WizardGames.Soc.Common.Data.constraction.ConstructionComboConfig comboConfig, System.Int32 firstTag, System.Int32 secondTag); // 0x0672adb4
	System.Void SetBuildData(WizardGames.Soc.Common.Data.constraction.ConstructionComboChildGroupConfig childGroupConfig, System.Int32 grade, System.Int32 firstTag, System.Int32 secondTag); // 0x0672b988
	WizardGames.Soc.SocClient.Ui.ConstructionInfoData GetTipsInfo(WizardGames.Soc.SocClient.Ui.ConstructionInfoData constructionInfoData, WizardGames.Soc.SocClient.Ui.EConstructionEditMode& editMode); // 0x0672c484
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UIConstructionBaseDetailInfo> GetChildParts(WizardGames.Soc.Common.Data.constraction.ConstructionComboConfig comboConfig); // 0x0672c990
	static System.Void SetTipsInfoInEdit(WizardGames.Soc.SocClient.Ui.ConstructionInfoData constructionInfoData, WizardGames.Soc.SocClient.Ui.Construction.ComboPartViewData comboPartViewData, WizardGames.Soc.SocClient.Ui.EConstructionEditMode& editMode); // 0x0672ccb0
	System.Collections.Generic.List<System.String> GetPieIcons(); // 0x0672db04
	System.Collections.Generic.List<System.String> GetPieCenterIcons(); // 0x0672de2c
	System.Void .ctor(); // 0x0672dffc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Construction.CorePartViewData : WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase
{
	WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType <PartViewDataType>k__BackingField; // 0x64
	WizardGames.Soc.Common.Construction.ConstructionGrade defaultConstructionGrade; // 0x68
	WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType get_PartViewDataType(); // 0x0672e0b8
	System.Void OnGet(); // 0x0672e11c
	System.Void OnRelease(); // 0x0672e180
	System.String GetPieName(); // 0x0672e1e4
	System.Void SetBuildData(WizardGames.Soc.Common.Data.constraction.BuildingCore buildingCore, System.Int32 firstTag, System.Int32 secondTag, System.Int32 grade, System.Int32 priority, System.Int32 priorityPie, System.Boolean isBuildData); // 0x0672e534
	WizardGames.Soc.SocClient.Ui.ConstructionInfoData GetTipsInfo(WizardGames.Soc.SocClient.Ui.ConstructionInfoData constructionInfoData, WizardGames.Soc.SocClient.Ui.EConstructionEditMode& editMode); // 0x0672e9e4
	static System.Void SetCoreTipsInfo(WizardGames.Soc.SocClient.Ui.ConstructionInfoData constructionInfoData, WizardGames.Soc.SocClient.Ui.Construction.CorePartViewData corePartViewData, WizardGames.Soc.SocClient.Ui.EConstructionEditMode& editMode); // 0x0672ea74
	static System.ValueTuple<System.Int64,System.Int32> GetBuildCostConfig(WizardGames.Soc.SocClient.Ui.Construction.CorePartViewData corePartViewData, WizardGames.Soc.Common.Data.constraction.BuildingCore coreConfig); // 0x0672ede0
	System.Collections.Generic.List<System.String> GetPieIcons(); // 0x0672efb8
	System.Void .ctor(); // 0x0672f324
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Construction.CustomBlueprintPartViewData : WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBlueprintState
{
	WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType <PartViewDataType>k__BackingField; // 0x70
	System.Int64 <Id>k__BackingField; // 0x78
	WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType get_PartViewDataType(); // 0x0672f4ac
	System.Int64 get_Id(); // 0x0672f510
	System.Void set_Id(System.Int64 value); // 0x0672f574
	System.String GetUnLockDescImpl(); // 0x0672f5ec
	System.Boolean IsUnlockImpl(); // 0x0672f820
	System.Void SetBuildData(WizardGames.Soc.Common.CustomType.ConstructionBlueprintBriefData briefData, System.Int32 firstTag, System.Int32 secondTag); // 0x0672fc58
	WizardGames.Soc.SocClient.Ui.ConstructionInfoData GetTipsInfo(WizardGames.Soc.SocClient.Ui.ConstructionInfoData constructionInfoData, WizardGames.Soc.SocClient.Ui.EConstructionEditMode& editMode); // 0x067301f8
	System.Void .ctor(); // 0x067303bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Construction.DeployPartViewData : WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBlueprintState
{
	WizardGames.Soc.Common.Construction.ConstructionPartType <ConstructionPartType>k__BackingField; // 0x70
	WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType <PartViewDataType>k__BackingField; // 0x74
	WizardGames.Soc.Common.Construction.ConstructionPartType get_ConstructionPartType(); // 0x06730428
	System.Void set_ConstructionPartType(WizardGames.Soc.Common.Construction.ConstructionPartType value); // 0x0673048c
	WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType get_PartViewDataType(); // 0x06730504
	System.Int64 GetLockBlueprintIdImpl(); // 0x06730568
	System.Void SetBuildData(WizardGames.Soc.Common.Data.constraction.BuildingCore buildingCore, System.Int32 firstTag, System.Int32 secondTag, System.Int32 grade, System.Int32 priority, System.Int32 priorityPie); // 0x067307f0
	WizardGames.Soc.SocClient.Ui.ConstructionInfoData GetTipsInfo(WizardGames.Soc.SocClient.Ui.ConstructionInfoData constructionInfoData, WizardGames.Soc.SocClient.Ui.EConstructionEditMode& editMode); // 0x06730f58
	System.Void .ctor(); // 0x06731668
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Construction.DeployPartViewData.<>c__DisplayClass9_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ConstructionInfoData constructionInfoData; // 0x10
	System.Void .ctor(); // 0x06731600
	System.Void <GetTipsInfo>b__0(); // 0x067316d4
	System.Void <GetTipsInfo>b__1(); // 0x0673178c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.Construction.EBuildEditType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.Construction.EBuildEditType Rotate = 0;
	static WizardGames.Soc.SocClient.Ui.Construction.EBuildEditType Delete = 1;
	static WizardGames.Soc.SocClient.Ui.Construction.EBuildEditType PickUp = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Construction.EditPartViewData : WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase
{
	WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType <PartViewDataType>k__BackingField; // 0x64
	WizardGames.Soc.SocClient.Ui.Construction.EBuildEditType <EditType>k__BackingField; // 0x68
	WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType get_PartViewDataType(); // 0x06731834
	WizardGames.Soc.SocClient.Ui.Construction.EBuildEditType get_EditType(); // 0x06731898
	System.Void set_EditType(WizardGames.Soc.SocClient.Ui.Construction.EBuildEditType value); // 0x067318fc
	System.Void SetBuildData(System.Int32 firstTag, WizardGames.Soc.SocClient.Ui.Construction.EBuildEditType type, System.Boolean isGrayed); // 0x06731974
	WizardGames.Soc.SocClient.Ui.ConstructionInfoData GetTipsInfo(WizardGames.Soc.SocClient.Ui.ConstructionInfoData constructionInfoData, WizardGames.Soc.SocClient.Ui.EConstructionEditMode& editMode); // 0x06732080
	System.Void .ctor(); // 0x06732108
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Ui.Construction.IBlueprintState : 
{
	
	System.Boolean IsUnlockImpl(); // 0x054c4760
	System.Int32 GetLockStateImpl(); // 0x0548ba98
	System.String GetUnLockDescImpl(); // 0x054e7844
	System.Int64 GetLockBlueprintIdImpl(); // 0x054a4380
	System.Boolean IsHasCheckImpl(); // 0x054c4760
	System.Void CheckImpl(); // 0x055049cc
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.Construction.BuildTagData : System.ValueType, System.IEquatable<WizardGames.Soc.SocClient.Ui.Construction.BuildTagData>
{
	System.Int32 FirstTagId; // 0x10
	System.Int32 SecondTagId; // 0x14
	System.Void .ctor(System.Int32 firstTag, System.Int32 secondTag); // 0x06732198
	System.Boolean Equals(WizardGames.Soc.SocClient.Ui.Construction.BuildTagData other); // 0x06732218
	System.Boolean Equals(System.Object obj); // 0x067322b0
	System.Int32 GetHashCode(); // 0x06732374
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType None = 0;
	static WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType Core = 1;
	static WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType Deploy = 2;
	static WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType Combo = 3;
	static WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType Blueprint = 4;
	static WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType CustomBlueprint = 5;
	static WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType Edit = 6;
	static WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType Placeholder = 1000;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger logger; // 0x0
	System.Int64 <TemplateId>k__BackingField; // 0x10
	System.Int32 <FirstTagId>k__BackingField; // 0x18
	System.Int32 <SecondTagId>k__BackingField; // 0x1c
	System.String <IconUrl>k__BackingField; // 0x20
	System.Int32 <Priority>k__BackingField; // 0x28
	System.Int32 <PriorityPie>k__BackingField; // 0x2c
	System.String <Name>k__BackingField; // 0x30
	System.String <Desc>k__BackingField; // 0x38
	System.Int32 <Grade>k__BackingField; // 0x40
	System.Boolean <IsAvailable>k__BackingField; // 0x44
	System.Boolean <IsGrayed>k__BackingField; // 0x45
	WizardGames.Soc.SocClient.Ui.EPieOptionItemState PieOptionItemState; // 0x48
	System.Boolean IsEnableSelected; // 0x4c
	System.Collections.Generic.List<System.String> pieIcons; // 0x50
	System.Collections.Generic.List<System.String> pieCenterIcons; // 0x58
	System.Boolean IsUpgradeData; // 0x60
	System.Boolean <IsBuildData>k__BackingField; // 0x61
	WizardGames.Soc.SocClient.Ui.Construction.EPartViewDataType get_PartViewDataType(); // 0x0673241c
	System.Int64 get_TemplateId(); // 0x06732480
	System.Void set_TemplateId(System.Int64 value); // 0x067324e4
	System.Int32 get_FirstTagId(); // 0x0673255c
	System.Void set_FirstTagId(System.Int32 value); // 0x067325c0
	System.Int32 get_SecondTagId(); // 0x06732638
	System.Void set_SecondTagId(System.Int32 value); // 0x0673269c
	System.String get_IconUrl(); // 0x06732714
	System.Void set_IconUrl(System.String value); // 0x06732778
	System.Int32 get_Priority(); // 0x067327f8
	System.Void set_Priority(System.Int32 value); // 0x0673285c
	System.Void set_PriorityPie(System.Int32 value); // 0x067328d4
	System.String get_Name(); // 0x0673294c
	System.Void set_Name(System.String value); // 0x067329b0
	System.String get_Desc(); // 0x06732a30
	System.Void set_Desc(System.String value); // 0x06732a94
	System.Int32 get_Grade(); // 0x06732b14
	System.Void set_Grade(System.Int32 value); // 0x06732b78
	System.Boolean get_IsAvailable(); // 0x06732bf0
	System.Void set_IsAvailable(System.Boolean value); // 0x06732c54
	System.Boolean get_IsGrayed(); // 0x06732cd0
	System.Void set_IsGrayed(System.Boolean value); // 0x06732d34
	WizardGames.Soc.SocClient.Ui.Construction.BuildTagData get_BuildTagData(); // 0x06732db0
	System.Boolean get_IsCombo(); // 0x06732ec8
	System.Boolean get_IsCore(); // 0x06732f40
	System.Boolean get_IsDeploy(); // 0x06732fb8
	System.Boolean get_IsConstructionBlueprint(); // 0x06733030
	System.Boolean get_IsCustomBlueprint(); // 0x067330a8
	System.Boolean get_IsPlaceholder(); // 0x06733120
	System.Boolean get_IsEditData(); // 0x06733198
	System.Boolean get_IsBuildData(); // 0x06733210
	System.Void set_IsBuildData(System.Boolean value); // 0x06733274
	System.Int64 get_ComboChildGroupId(); // 0x0672acd0
	System.String GetPieName(); // 0x0672ac38
	WizardGames.Soc.SocClient.Ui.ConstructionInfoData GetTipsInfo(WizardGames.Soc.SocClient.Ui.ConstructionInfoData constructionInfoData, WizardGames.Soc.SocClient.Ui.EConstructionEditMode& editMode); // 0x067332f0
	System.Collections.Generic.List<System.String> GetPieIcons(); // 0x0672f1c8
	System.Collections.Generic.List<System.String> GetPieCenterIcons(); // 0x067333a0
	System.Boolean IsUnLock(); // 0x0672d944
	System.Int64 GetLockBlueprintId(); // 0x0672da24
	System.Boolean IsHasCheck(); // 0x067334fc
	System.Void Check(); // 0x067335e0
	System.Int32 LockState(); // 0x067336c0
	System.String GetUnLockDesc(); // 0x067337a0
	System.Void OnGet(); // 0x0672a2cc
	System.Void OnRelease(); // 0x0672a50c
	System.Void OnDestroy(); // 0x067338a0
	System.Void .ctor(); // 0x0672f3b4
	static System.Void .cctor(); // 0x06733900
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBlueprintState : WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase, WizardGames.Soc.SocClient.Ui.Construction.IBlueprintState
{
	System.Collections.Generic.List<System.Int64> <BlueprintIds>k__BackingField; // 0x68
	System.Collections.Generic.List<System.Int64> get_BlueprintIds(); // 0x067339d4
	System.Boolean IsUnlockImpl(); // 0x06733a38
	System.Boolean IsNewImpl(); // 0x06733ab4
	System.Int32 GetLockStateImpl(); // 0x0672a9ac
	System.String GetUnLockDescImpl(); // 0x0672f7a8
	System.Int64 GetLockBlueprintIdImpl(); // 0x06733d80
	System.Boolean IsHasCheckImpl(); // 0x06733b44
	System.Boolean HasBluePrintNodeImpl(); // 0x06733f78
	System.Void CheckImpl(); // 0x06734184
	System.Void .ctor(); // 0x06729f14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Construction.PartViewDataFactory : System.Object
{
	static SocLogger logger; // 0x0
	static T Create<T>(); // 0x052af1f0
	static System.Void Release(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase partViewData); // 0x067343a8
	static System.Void .cctor(); // 0x067344e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Construction.PlaceholderPartViewData : WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase
{
	System.Boolean IsUse; // 0x62
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Utils.CommonNumberFormatUtils : System.Object
{
	static SocLogger logger; // 0x0
	static System.String FormatTime(System.TimeSpan offset); // 0x067345bc
	static System.String FormatTime(System.Int64 seconds); // 0x06734864
	static System.String LeftTimeFormat(System.Int32 LanguageConstId, System.Int64 seconds); // 0x06734b00
	static System.String FullDateTimeFormat(System.Int64 time, System.Boolean isShort); // 0x06734e0c
	static System.String DateTimeFormat(System.DateTime dateTime, System.Boolean isShort); // 0x06735124
	static System.String CurrencyFormatNumber(System.Int32 number); // 0x0673531c
	static System.String BuffFormatTime(System.Int64 seconds); // 0x067354d0
	static System.String LiquidVolumeFormat(System.Int32 curValue, System.Int32 maxValue); // 0x067356ac
	static System.Void .cctor(); // 0x067357e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Utils.FairyGuiUtil : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.Dictionary<System.String,System.String> loadGameHudIconPathDic; // 0x8
	static System.String GetItemIconUrl(System.Int64 itemId); // 0x067358b8
	static System.String WrapNum(System.Int32 num); // 0x067359b0
	static System.String GetTechLevelIcon(System.Int32 techLevel); // 0x06735aac
	static System.String FormatTime(System.Int64 time); // 0x06735b64
	static System.String GetOffSetByTimestamp(System.Int64 start, System.Int64 end); // 0x06735d08
	static System.String GetOffSetTimeStr(System.Int64 offSet); // 0x06735da4
	static System.String GetOffSetByTimestamp(System.Int32 start, System.Int32 end); // 0x06735fcc
	static System.String GetOffSetTimeStr(System.Int32 offSet); // 0x06736068
	static System.Void SetListScrollEnable(FairyGUI.GList list, System.Boolean enable); // 0x06736274
	static System.Int64 PlayListAnimation(FairyGUI.GList list, System.Int32 interval, System.Action<System.Int32,FairyGUI.GComponent> action); // 0x067364b4
	static System.Void CancelListAnimation(FairyGUI.GList list, System.Int64 timerId); // 0x06736774
	static System.String GetAvatarUrl(System.String url, System.Boolean isSelf, System.Boolean& isSDK); // 0x06736924
	static System.String GetHeadFrameUrl(System.Int32 id, System.Boolean isSelf); // 0x06736b4c
	static System.String GetNameCardUrl(System.Int32 id); // 0x06736d8c
	static System.Void CheckInputTextLimit(FairyGUI.GTextInput input, FairyGUI.GTextField limitNumText, System.Int32 minLength, System.Int32 maxLength, System.Boolean& showMinLengthTip, System.Boolean canWhiteSpace); // 0x06736f6c
	static System.Void SwitchGameHudIcon(FairyGUI.GLoader loader, System.String iconName); // 0x06737374
	static System.Boolean IsAllWhiteSpace(System.String str); // 0x06737508
	static System.Void .cctor(); // 0x0673760c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Utils.FairyGuiUtil.<>c__DisplayClass10_0 : System.Object
{
	FairyGUI.GList list; // 0x10
	System.Int32 index; // 0x18
	System.Action<System.Int32,FairyGUI.GComponent> action; // 0x20
	System.Void .ctor(); // 0x0673670c
	System.Void <PlayListAnimation>b__0(System.Int64 id, System.Object _, System.Boolean delete); // 0x06737738
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Ui.Utils.IToolTips : 
{
	
	System.Void ShowTips(FairyGUI.EventContext context); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Utils.CommonToolTips : System.Object, WizardGames.Soc.SocClient.Ui.Utils.IToolTips
{
	FairyGUI.EventCallback0 ShowTipsCallback; // 0x10
	FairyGUI.EventCallback0 HideTipsCallback; // 0x18
	System.Void ShowTips(FairyGUI.EventContext context); // 0x06737b40
	System.Void .ctor(); // 0x06737bf8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Utils.SafeUtil : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void SafeSetProgress(FairyGUI.GProgressBar target, System.Double rate, System.String text); // 0x06737c60
	static System.Void SafeSetText(FairyGUI.GObject target, System.String content); // 0x06737d48
	static System.Void SafeSetVisible(FairyGUI.GObject target, System.Boolean visible); // 0x06737df4
	static System.Void SafeAddClickEvent(FairyGUI.GObject target, FairyGUI.EventCallback0 clickEvent); // 0x06737e88
	static System.Void SafeSetBtnTitle(FairyGUI.GButton target, System.String content); // 0x06737f3c
	static System.Void SafeSetLoaderUrl(FairyGUI.GLoader loader, System.String url, System.Boolean force); // 0x06737ff4
	static System.String SafeStringFormat(System.String format, System.Object[] args); // 0x067380a4
	static System.Void SafeSetTooltips(FairyGUI.GComponent target, WizardGames.Soc.SocClient.Ui.Utils.IToolTips toolTips, System.Boolean useHover); // 0x067381ac
	static System.Void .cctor(); // 0x0673838c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Utils.TimeUtil : System.Object
{
	
	static System.String SecToHMS(System.Single sec, System.Boolean simpleMode, System.UInt32 secDEC); // 0x06738460
	static System.String MsToHMS(System.Int64 ms, System.Boolean simpleMode); // 0x067389b4
	static System.String SecToDHMS(System.Int64 seconds, System.Boolean simpleMode); // 0x06738a40
	static System.String MsToDHMS1(System.Int64 seconds, System.Boolean simpleMode); // 0x06738fd0
	static System.String FormatTime(System.Int64 time, System.Boolean ignore24H); // 0x06739434
	static System.String FormatTimeDateTime(System.String time); // 0x06739610
	static System.String FormatTimeDateTimeYMDHM(System.String time); // 0x06739720
	static System.String FormatTimeSmall(System.Int64 time); // 0x06739830
	static System.String MsToHM(System.Int64 seconds); // 0x06739ba4
	static System.String MsToYMDH(System.Int64 seconds); // 0x06739dac
	static System.String MsToHMSimple(System.Int64 seconds); // 0x0673a08c
	static System.String TimestampToYMDHM(System.Int64 seconds); // 0x0673a1d4
	static System.Void FormatTime(System.Int64 time, System.String& formatDay, System.String& formatHour, System.String& formatMin, System.String& formatSec); // 0x0673a394
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Utils.WindowCDTime : System.Object
{
	System.Collections.Generic.Dictionary<System.String,System.Single> nextExecuteTimeMap; // 0x10
	System.Boolean IsInCdTime(FairyGUI.GObject obj, System.Single cdTime, System.Boolean isAutoRecordTime); // 0x0673a66c
	System.Void SetCdTime(FairyGUI.GObject obj, System.Single cdTime); // 0x0673a7f0
	System.Void .ctor(); // 0x0673a8fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbyWarSituation.ComNewRootBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <N32>k__BackingField; // 0x18
	FairyGUI.GTextField <Anking>k__BackingField; // 0x20
	FairyGUI.GTextField <Progress>k__BackingField; // 0x28
	FairyGUI.GTextField <Name>k__BackingField; // 0x30
	FairyGUI.GTextField <Level>k__BackingField; // 0x38
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x40
	FairyGUI.GTextField get_N32(); // 0x0673a9b0
	FairyGUI.GTextField get_Anking(); // 0x0673aa14
	FairyGUI.GTextField get_Progress(); // 0x0673aa78
	FairyGUI.GTextField get_Name(); // 0x0673aadc
	FairyGUI.GTextField get_Level(); // 0x0673ab40
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673aba4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbyUnlockSystem.RootCommonUnlockSystemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <CloseBtn>k__BackingField; // 0x18
	FairyGUI.GTextField <UnlockTips>k__BackingField; // 0x20
	FairyGUI.GLoader <Icon>k__BackingField; // 0x28
	FairyGUI.GTextField <Name>k__BackingField; // 0x30
	FairyGUI.GButton get_CloseBtn(); // 0x0673adac
	FairyGUI.GTextField get_UnlockTips(); // 0x0673ae10
	FairyGUI.GLoader get_Icon(); // 0x0673ae74
	FairyGUI.GTextField get_Name(); // 0x0673aed8
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673af3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbyUnlockSystem.UiCommonUnlockSystemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.LobbyUnlockSystem.RootCommonUnlockSystemBinder <Root>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlBgType>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.LobbyUnlockSystem.RootCommonUnlockSystemBinder get_Root(); // 0x0673b0d0
	FairyGUI.Controller get_CtrlBgType(); // 0x0673b134
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673b198
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.ComDoubleBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GRichTextField <Number>k__BackingField; // 0x18
	FairyGUI.GTextField <Text>k__BackingField; // 0x20
	FairyGUI.Transition <TransAppear>k__BackingField; // 0x28
	FairyGUI.GRichTextField get_Number(); // 0x0673b2d0
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673b334
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.ComExchangeBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Modal>k__BackingField; // 0x18
	FairyGUI.GTextField <SpendText>k__BackingField; // 0x20
	FairyGUI.GComponent <ComSpend>k__BackingField; // 0x28
	FairyGUI.GTextField <ExchangeText>k__BackingField; // 0x30
	FairyGUI.GComponent <ComExchange>k__BackingField; // 0x38
	FairyGUI.GComponent <InputNum>k__BackingField; // 0x40
	FairyGUI.GGroup <Exchange>k__BackingField; // 0x48
	FairyGUI.GComponent get_Modal(); // 0x0673b47c
	FairyGUI.GComponent get_ComSpend(); // 0x0673b4e0
	FairyGUI.GComponent get_ComExchange(); // 0x0673b544
	FairyGUI.GComponent get_InputNum(); // 0x0673b5a8
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673b60c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.ComGiftBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GRichTextField <TxtNum>k__BackingField; // 0x18
	FairyGUI.Transition <TransAppear>k__BackingField; // 0x20
	FairyGUI.GRichTextField get_TxtNum(); // 0x0673b860
	FairyGUI.Transition get_TransAppear(); // 0x0673b8c4
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673b928
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.ComItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Number>k__BackingField; // 0x18
	FairyGUI.GTextField <Cost>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.ComGiftBinder <ComGift>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.ComDoubleBinder <ComDouble>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlStyle>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x40
	FairyGUI.Transition <TransAppear>k__BackingField; // 0x48
	FairyGUI.GTextField get_Number(); // 0x0673ba30
	FairyGUI.GTextField get_Cost(); // 0x0673ba94
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.ComGiftBinder get_ComGift(); // 0x0673baf8
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.ComDoubleBinder get_ComDouble(); // 0x0673bb5c
	FairyGUI.Controller get_CtrlStyle(); // 0x0673bbc0
	FairyGUI.Controller get_CtrlStatus(); // 0x0673bc24
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673bc88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.ComTipsBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Modal>k__BackingField; // 0x18
	FairyGUI.GTextField <Text>k__BackingField; // 0x20
	FairyGUI.GButton <BtnSelect>k__BackingField; // 0x28
	FairyGUI.GComponent get_Modal(); // 0x0673bf18
	FairyGUI.GTextField get_Text(); // 0x0673bf7c
	FairyGUI.GButton get_BtnSelect(); // 0x0673bfe0
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673c044
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.ComTopUpBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GGraph <Fx>k__BackingField; // 0x18
	FairyGUI.GList <List>k__BackingField; // 0x20
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x28
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x30
	FairyGUI.GGraph get_Fx(); // 0x0673c198
	FairyGUI.GList get_List(); // 0x0673c1fc
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673c260
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.ComTopUpRootBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComTopBarBinder <TopBar>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.ComTopUpBinder <Content>k__BackingField; // 0x20
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x28
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x30
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComTopBarBinder get_TopBar(); // 0x0673c434
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.ComTopUpBinder get_Content(); // 0x0673c498
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673c4fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.UiCurrencyExchangeBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.ComExchangeBinder <Root>k__BackingField; // 0x18
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x20
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.ComExchangeBinder get_Root(); // 0x0673c6dc
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673c740
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.UiInsufficientTipsBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.ComTipsBinder <Root>k__BackingField; // 0x18
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x20
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.ComTipsBinder get_Root(); // 0x0673c8ac
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673c910
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.UiLobbyTopUpBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.ComTopUpRootBinder <Root>k__BackingField; // 0x18
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x20
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTopUp.ComTopUpRootBinder get_Root(); // 0x0673ca7c
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673cae0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbyTeam.BtnAllowInviteBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <ToggleBtn>k__BackingField; // 0x18
	FairyGUI.GButton get_ToggleBtn(); // 0x0673cc4c
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673ccb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbyTeam.ComLobbyMicPanelBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <BtnFreeMircoTeam>k__BackingField; // 0x18
	FairyGUI.GButton <BtnFreeMircoAppointment>k__BackingField; // 0x20
	FairyGUI.GButton <BtnFreeMircoNone>k__BackingField; // 0x28
	FairyGUI.GButton <BtnHoldMircoTeam>k__BackingField; // 0x30
	FairyGUI.GButton <BtnHoldMircoTeamAppointment>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlBtnControl>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlType>k__BackingField; // 0x48
	FairyGUI.GComponent get_BinderRoot(); // 0x0673cd84
	FairyGUI.GButton get_BtnFreeMircoTeam(); // 0x0673cde8
	FairyGUI.GButton get_BtnFreeMircoAppointment(); // 0x0673ce4c
	FairyGUI.GButton get_BtnFreeMircoNone(); // 0x0673ceb0
	FairyGUI.GButton get_BtnHoldMircoTeam(); // 0x0673cf14
	FairyGUI.GButton get_BtnHoldMircoTeamAppointment(); // 0x0673cf78
	FairyGUI.Controller get_CtrlBtnControl(); // 0x0673cfdc
	FairyGUI.Controller get_CtrlType(); // 0x0673d040
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673d0a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbyTeam.ComLobbySpeakerPanelBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <ListSpeaker>k__BackingField; // 0x18
	FairyGUI.GButton <BtnFreeSpeakerTeam>k__BackingField; // 0x20
	FairyGUI.GButton <BtnFreeSpeakerTeamAppointment>k__BackingField; // 0x28
	FairyGUI.GButton <BtnFreeSpeakerNone>k__BackingField; // 0x30
	FairyGUI.GButton <BtnReport>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlBtnControl>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlType>k__BackingField; // 0x48
	FairyGUI.GComponent get_BinderRoot(); // 0x0673d2e0
	FairyGUI.GList get_ListSpeaker(); // 0x0673d344
	FairyGUI.GButton get_BtnFreeSpeakerTeam(); // 0x0673d3a8
	FairyGUI.GButton get_BtnFreeSpeakerTeamAppointment(); // 0x0673d40c
	FairyGUI.GButton get_BtnFreeSpeakerNone(); // 0x0673d470
	FairyGUI.GButton get_BtnReport(); // 0x0673d4d4
	FairyGUI.Controller get_CtrlBtnControl(); // 0x0673d538
	FairyGUI.Controller get_CtrlType(); // 0x0673d59c
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673d600
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbyTeam.ComTeamlistBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <Avatarlist>k__BackingField; // 0x18
	FairyGUI.GTextField <Time>k__BackingField; // 0x20
	FairyGUI.GButton <ChangeTime>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTeam.BtnAllowInviteBinder <AllowInviteBtn>k__BackingField; // 0x30
	FairyGUI.GButton <StartTeam>k__BackingField; // 0x38
	FairyGUI.GButton <BtnClickArea>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x48
	FairyGUI.Controller <CtrlType>k__BackingField; // 0x50
	FairyGUI.Controller <CtrlAllowAccess>k__BackingField; // 0x58
	FairyGUI.Controller <CtrlHasTeam>k__BackingField; // 0x60
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x68
	FairyGUI.Controller <CtrlSelect>k__BackingField; // 0x70
	FairyGUI.GList get_Avatarlist(); // 0x0673d83c
	FairyGUI.GTextField get_Time(); // 0x0673d8a0
	FairyGUI.GButton get_ChangeTime(); // 0x0673d904
	WizardGames.Soc.SocClient.Ui.Binder.LobbyTeam.BtnAllowInviteBinder get_AllowInviteBtn(); // 0x0673d968
	FairyGUI.GButton get_StartTeam(); // 0x0673d9cc
	FairyGUI.GButton get_BtnClickArea(); // 0x0673da30
	FairyGUI.Controller get_CtrlStatus(); // 0x0673da94
	FairyGUI.Controller get_CtrlType(); // 0x0673daf8
	FairyGUI.Controller get_CtrlAllowAccess(); // 0x0673db5c
	FairyGUI.Controller get_CtrlHasTeam(); // 0x0673dbc0
	FairyGUI.Controller get_CtrlSelect(); // 0x0673dc24
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673dc88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbyTeam.RootSwitchTeamBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <ClickClose>k__BackingField; // 0x18
	FairyGUI.GList <List>k__BackingField; // 0x20
	FairyGUI.GLoader get_ClickClose(); // 0x0673e004
	FairyGUI.GList get_List(); // 0x0673e068
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673e0cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.BtnSelect2Binder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <New>k__BackingField; // 0x18
	FairyGUI.GComponent get_New(); // 0x0673e1e0
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673e244
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.BtnSelect3Binder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <New>k__BackingField; // 0x18
	FairyGUI.GComponent get_New(); // 0x0673e318
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673e37c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.BtnSelectBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <New>k__BackingField; // 0x18
	FairyGUI.GComponent get_New(); // 0x0673e450
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673e4b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComChosePlanBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <ListWeapon>k__BackingField; // 0x18
	FairyGUI.GButton <Cloth>k__BackingField; // 0x20
	FairyGUI.GButton <WeaponBtn>k__BackingField; // 0x28
	FairyGUI.GList <CostumePlanList>k__BackingField; // 0x30
	FairyGUI.GButton <ChoseBtn>k__BackingField; // 0x38
	FairyGUI.GComponent <CommonTabs>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x48
	FairyGUI.GList get_ListWeapon(); // 0x0673e588
	FairyGUI.GButton get_Cloth(); // 0x0673e5ec
	FairyGUI.GButton get_WeaponBtn(); // 0x0673e650
	FairyGUI.GList get_CostumePlanList(); // 0x0673e6b4
	FairyGUI.GComponent get_CommonTabs(); // 0x0673e718
	FairyGUI.Controller get_CtrlStatus(); // 0x0673e77c
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673e7e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComPartPreviewBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <PartPreviewBtn>k__BackingField; // 0x18
	FairyGUI.GList <PartPreviewList>k__BackingField; // 0x20
	FairyGUI.GButton <NormalBtn>k__BackingField; // 0x28
	FairyGUI.GButton <SuperBtn>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlSwitchPart>k__BackingField; // 0x38
	FairyGUI.GComponent get_BinderRoot(); // 0x0673ead8
	FairyGUI.GButton get_PartPreviewBtn(); // 0x0673eb3c
	FairyGUI.GList get_PartPreviewList(); // 0x0673eba0
	FairyGUI.GButton get_NormalBtn(); // 0x0673ec04
	FairyGUI.GButton get_SuperBtn(); // 0x0673ec68
	FairyGUI.Controller get_CtrlSwitchPart(); // 0x0673eccc
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673ed30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComPreviewContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <ImgPreview>k__BackingField; // 0x18
	FairyGUI.GLoader <ModelLoader>k__BackingField; // 0x20
	FairyGUI.GComponent <UiModelWeapon>k__BackingField; // 0x28
	FairyGUI.GComponent <UiModel>k__BackingField; // 0x30
	FairyGUI.GButton <PreviewModel>k__BackingField; // 0x38
	FairyGUI.GButton <PerspectiveBtn>k__BackingField; // 0x40
	FairyGUI.GButton <HighLightBtn>k__BackingField; // 0x48
	FairyGUI.GGroup <BtnGroup>k__BackingField; // 0x50
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.SkinTitleBinder <ComDescription>k__BackingField; // 0x58
	FairyGUI.GList <SuitDetail>k__BackingField; // 0x60
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComPartPreviewBinder <ComPartPreview>k__BackingField; // 0x68
	FairyGUI.GList <PreviewList>k__BackingField; // 0x70
	FairyGUI.GComponent <TitleCom>k__BackingField; // 0x78
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x80
	FairyGUI.Controller <CtrlModelType>k__BackingField; // 0x88
	FairyGUI.Controller <CtrlSuitStatus>k__BackingField; // 0x90
	FairyGUI.GComponent get_BinderRoot(); // 0x0673eef8
	FairyGUI.GLoader get_ImgPreview(); // 0x0673ef5c
	FairyGUI.GLoader get_ModelLoader(); // 0x0673efc0
	FairyGUI.GComponent get_UiModelWeapon(); // 0x0673f024
	FairyGUI.GComponent get_UiModel(); // 0x0673f088
	FairyGUI.GButton get_PreviewModel(); // 0x0673f0ec
	FairyGUI.GButton get_PerspectiveBtn(); // 0x0673f150
	FairyGUI.GButton get_HighLightBtn(); // 0x0673f1b4
	FairyGUI.GGroup get_BtnGroup(); // 0x0673f218
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.SkinTitleBinder get_ComDescription(); // 0x0673f27c
	FairyGUI.GList get_SuitDetail(); // 0x0673f2e0
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComPartPreviewBinder get_ComPartPreview(); // 0x0673f344
	FairyGUI.GList get_PreviewList(); // 0x0673f3a8
	FairyGUI.GComponent get_TitleCom(); // 0x0673f40c
	FairyGUI.Controller get_CtrlStatus(); // 0x0673f470
	FairyGUI.Controller get_CtrlModelType(); // 0x0673f4d4
	FairyGUI.Controller get_CtrlSuitStatus(); // 0x0673f538
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673f59c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComPreviewRootBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComPreviewContentBinder <Content>k__BackingField; // 0x18
	FairyGUI.GLabel <TopBar>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlModelType>k__BackingField; // 0x30
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComPreviewContentBinder get_Content(); // 0x0673fd28
	FairyGUI.GLabel get_TopBar(); // 0x0673fd8c
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673fdf0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComSkinModifyRewardBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Title>k__BackingField; // 0x18
	FairyGUI.GTextField <SubTitle>k__BackingField; // 0x20
	FairyGUI.GList <RewardList>k__BackingField; // 0x28
	FairyGUI.GTextField get_Title(); // 0x0673ff9c
	FairyGUI.GTextField get_SubTitle(); // 0x06740000
	FairyGUI.GList get_RewardList(); // 0x06740064
	System.Void .ctor(FairyGUI.GComponent root); // 0x067400c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComTagBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Text>k__BackingField; // 0x18
	FairyGUI.GTextField get_Text(); // 0x0674021c
	System.Void .ctor(FairyGUI.GComponent root); // 0x06740280
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComTitle_IconBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GButton <Btn1>k__BackingField; // 0x18
	FairyGUI.GButton <Btn2>k__BackingField; // 0x20
	FairyGUI.GLoader <ItemIcon>k__BackingField; // 0x28
	FairyGUI.GTextField <Title>k__BackingField; // 0x30
	FairyGUI.GTextField <CenterTitle>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlStyle>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlTitleIcon>k__BackingField; // 0x48
	FairyGUI.Controller <CtrlButtonNum>k__BackingField; // 0x50
	FairyGUI.Controller <CtrlTab>k__BackingField; // 0x58
	FairyGUI.GButton get_Btn1(); // 0x06740354
	FairyGUI.GButton get_Btn2(); // 0x067403b8
	FairyGUI.GLoader get_ItemIcon(); // 0x0674041c
	FairyGUI.GTextField get_Title(); // 0x06740480
	FairyGUI.GTextField get_CenterTitle(); // 0x067404e4
	FairyGUI.Controller get_CtrlStyle(); // 0x06740548
	FairyGUI.Controller get_CtrlTitleIcon(); // 0x067405ac
	FairyGUI.Controller get_CtrlButtonNum(); // 0x06740610
	System.Void .ctor(FairyGUI.GComponent root); // 0x06740674
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootChoseSkinConstructionBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComSideShotTop_SmallBinder <Title>k__BackingField; // 0x18
	FairyGUI.GList <List>k__BackingField; // 0x20
	FairyGUI.GButton <CheckBtn>k__BackingField; // 0x28
	FairyGUI.GButton <BtnEquip>k__BackingField; // 0x30
	FairyGUI.GButton <BtnBuy>k__BackingField; // 0x38
	FairyGUI.GButton <BtnGo>k__BackingField; // 0x40
	FairyGUI.GLabel <Using>k__BackingField; // 0x48
	FairyGUI.GLabel <Locked>k__BackingField; // 0x50
	FairyGUI.Controller <CtrlEquipCtr>k__BackingField; // 0x58
	FairyGUI.Controller <CtrlPlatform>k__BackingField; // 0x60
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComSideShotTop_SmallBinder get_Title(); // 0x06740918
	FairyGUI.GList get_List(); // 0x0674097c
	FairyGUI.GButton get_CheckBtn(); // 0x067409e0
	FairyGUI.GButton get_BtnEquip(); // 0x06740a44
	FairyGUI.GButton get_BtnBuy(); // 0x06740aa8
	FairyGUI.GButton get_BtnGo(); // 0x06740b0c
	FairyGUI.GLabel get_Using(); // 0x06740b70
	FairyGUI.GLabel get_Locked(); // 0x06740bd4
	FairyGUI.Controller get_CtrlEquipCtr(); // 0x06740c38
	System.Void .ctor(FairyGUI.GComponent root); // 0x06740c9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootLobbySkinBuildingBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootLobbySkinBuildingContentBinder <Content>k__BackingField; // 0x18
	FairyGUI.GLabel <TopBar>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlSuitStatus>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlStyle>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlModelStyle>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlTitleIcon>k__BackingField; // 0x48
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x50
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x58
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootLobbySkinBuildingContentBinder get_Content(); // 0x06741024
	FairyGUI.GLabel get_TopBar(); // 0x06741088
	System.Void .ctor(FairyGUI.GComponent root); // 0x067410ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootLobbySkinBuildingContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <ImgPreview>k__BackingField; // 0x18
	FairyGUI.GComponent <UiModel>k__BackingField; // 0x20
	FairyGUI.GComponent <WeaponModel>k__BackingField; // 0x28
	FairyGUI.GComponent <UiPlayerModel>k__BackingField; // 0x30
	FairyGUI.GButton <HighLightBtn>k__BackingField; // 0x38
	FairyGUI.GComponent <CommonTabs>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComTitle_IconBinder <TitleCom>k__BackingField; // 0x48
	FairyGUI.GList <ThirdTab>k__BackingField; // 0x50
	FairyGUI.GList <CharmList>k__BackingField; // 0x58
	FairyGUI.GComboBox <CmboBox>k__BackingField; // 0x60
	FairyGUI.GButton <BtnPreview>k__BackingField; // 0x68
	FairyGUI.GButton <BtnModify>k__BackingField; // 0x70
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.SkinTitleBinder <SkinTitle>k__BackingField; // 0x78
	FairyGUI.GList <SuitDetail>k__BackingField; // 0x80
	FairyGUI.GButton <ChangeDoorBtn>k__BackingField; // 0x88
	FairyGUI.GLabel <Using>k__BackingField; // 0x90
	FairyGUI.GButton <BtnEquipSkin>k__BackingField; // 0x98
	FairyGUI.GButton <BtnUnEquip>k__BackingField; // 0xa0
	FairyGUI.GButton <BtnSyncLobby>k__BackingField; // 0xa8
	FairyGUI.GButton <BtnBuy>k__BackingField; // 0xb0
	FairyGUI.GTextField <LimitTimeTxt>k__BackingField; // 0xb8
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0xc0
	FairyGUI.Controller <CtrlSuitStatus>k__BackingField; // 0xc8
	FairyGUI.Controller <CtrlStyle>k__BackingField; // 0xd0
	FairyGUI.Controller <CtrlModelStyle>k__BackingField; // 0xd8
	FairyGUI.Controller <CtrlDoorCtr>k__BackingField; // 0xe0
	FairyGUI.Controller <CtrlShowCharm>k__BackingField; // 0xe8
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0xf0
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0xf8
	FairyGUI.GComponent get_BinderRoot(); // 0x06741c20
	FairyGUI.GLoader get_ImgPreview(); // 0x06741c84
	FairyGUI.GComponent get_UiModel(); // 0x06741ce8
	FairyGUI.GComponent get_WeaponModel(); // 0x06741d4c
	FairyGUI.GComponent get_UiPlayerModel(); // 0x06741db0
	FairyGUI.GButton get_HighLightBtn(); // 0x06741e14
	FairyGUI.GComponent get_CommonTabs(); // 0x06741e78
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComTitle_IconBinder get_TitleCom(); // 0x06741edc
	FairyGUI.GList get_ThirdTab(); // 0x06741f40
	FairyGUI.GList get_CharmList(); // 0x06741fa4
	FairyGUI.GComboBox get_CmboBox(); // 0x06742008
	FairyGUI.GButton get_BtnPreview(); // 0x0674206c
	FairyGUI.GButton get_BtnModify(); // 0x067420d0
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.SkinTitleBinder get_SkinTitle(); // 0x06742134
	FairyGUI.GList get_SuitDetail(); // 0x06742198
	FairyGUI.GButton get_ChangeDoorBtn(); // 0x067421fc
	FairyGUI.GLabel get_Using(); // 0x06742260
	FairyGUI.GButton get_BtnEquipSkin(); // 0x067422c4
	FairyGUI.GButton get_BtnUnEquip(); // 0x06742328
	FairyGUI.GButton get_BtnSyncLobby(); // 0x0674238c
	FairyGUI.GButton get_BtnBuy(); // 0x067423f0
	FairyGUI.GTextField get_LimitTimeTxt(); // 0x06742454
	FairyGUI.Controller get_CtrlStatus(); // 0x067424b8
	FairyGUI.Controller get_CtrlSuitStatus(); // 0x0674251c
	FairyGUI.Controller get_CtrlStyle(); // 0x06742580
	FairyGUI.Controller get_CtrlDoorCtr(); // 0x067425e4
	FairyGUI.Controller get_CtrlShowCharm(); // 0x06742648
	System.Void .ctor(FairyGUI.GComponent root); // 0x0674139c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootLobbySkinEntranceBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootLobbySkinEntranceContentBinder <Content>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootLobbySkinEntranceContentBinder get_Content(); // 0x067426ac
	System.Void .ctor(FairyGUI.GComponent root); // 0x06742710
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootLobbySkinEntranceContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.BtnSelectBinder <BtnWeaponSkin>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.BtnSelect2Binder <BtnBuildingSkin>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.BtnSelect3Binder <BtnArmorSkin>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.BtnSelectBinder get_BtnWeaponSkin(); // 0x067429f8
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.BtnSelect2Binder get_BtnBuildingSkin(); // 0x06742a5c
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.BtnSelect3Binder get_BtnArmorSkin(); // 0x06742ac0
	System.Void .ctor(FairyGUI.GComponent root); // 0x06742814
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootLobbySkinModifyBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootLobbySkinModifyContentBinder <Content>k__BackingField; // 0x18
	FairyGUI.GLabel <TopBar>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootLobbySkinModifyContentBinder get_Content(); // 0x06742b24
	FairyGUI.GLabel get_TopBar(); // 0x06742b88
	System.Void .ctor(FairyGUI.GComponent root); // 0x06742bec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootLobbySkinModifyContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <ImgPreview>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComNavBar_ProgressBinder <NavBar>k__BackingField; // 0x20
	FairyGUI.GButton <UnlockBtn>k__BackingField; // 0x28
	FairyGUI.GButton <EquipBtn>k__BackingField; // 0x30
	FairyGUI.GButton <UnEquipBtn>k__BackingField; // 0x38
	FairyGUI.GButton <BtnPreview>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.SkinTitleBinder <SkinTitle>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComSkinModifyRewardBinder <ComModifyReward>k__BackingField; // 0x50
	FairyGUI.GComponent <UiWeaponModel>k__BackingField; // 0x58
	FairyGUI.GComponent <PlayerModel>k__BackingField; // 0x60
	FairyGUI.GComponent <UiModel>k__BackingField; // 0x68
	FairyGUI.Controller <CtrlState>k__BackingField; // 0x70
	FairyGUI.GLoader get_ImgPreview(); // 0x0674314c
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComNavBar_ProgressBinder get_NavBar(); // 0x067431b0
	FairyGUI.GButton get_UnlockBtn(); // 0x06743214
	FairyGUI.GButton get_EquipBtn(); // 0x06743278
	FairyGUI.GButton get_UnEquipBtn(); // 0x067432dc
	FairyGUI.GButton get_BtnPreview(); // 0x06743340
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.SkinTitleBinder get_SkinTitle(); // 0x067433a4
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComSkinModifyRewardBinder get_ComModifyReward(); // 0x06743408
	FairyGUI.GComponent get_UiWeaponModel(); // 0x0674346c
	FairyGUI.GComponent get_PlayerModel(); // 0x067434d0
	FairyGUI.GComponent get_UiModel(); // 0x06743534
	FairyGUI.Controller get_CtrlState(); // 0x06743598
	System.Void .ctor(FairyGUI.GComponent root); // 0x06742d30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootWeaponPartBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <BgCom>k__BackingField; // 0x18
	FairyGUI.GList <PartList>k__BackingField; // 0x20
	FairyGUI.GButton <NormalBtn>k__BackingField; // 0x28
	FairyGUI.GButton <SuperBtn>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlSwitch>k__BackingField; // 0x38
	FairyGUI.GLabel get_BgCom(); // 0x067435fc
	FairyGUI.GList get_PartList(); // 0x06743660
	FairyGUI.GButton get_NormalBtn(); // 0x067436c4
	FairyGUI.GButton get_SuperBtn(); // 0x06743728
	FairyGUI.Controller get_CtrlSwitch(); // 0x0674378c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067437f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.SkinTitleBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <TxtTitle>k__BackingField; // 0x18
	FairyGUI.GGraph <BtnCollect>k__BackingField; // 0x20
	FairyGUI.GButton <BtnShare>k__BackingField; // 0x28
	FairyGUI.GTextField <TxtDetail>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlCollected>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlRarity>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlShare>k__BackingField; // 0x48
	FairyGUI.Controller <CtrlDetail>k__BackingField; // 0x50
	FairyGUI.GComponent get_BinderRoot(); // 0x067439b8
	FairyGUI.GTextField get_TxtTitle(); // 0x06743a1c
	FairyGUI.GGraph get_BtnCollect(); // 0x06743a80
	FairyGUI.GButton get_BtnShare(); // 0x06743ae4
	FairyGUI.GTextField get_TxtDetail(); // 0x06743b48
	FairyGUI.Controller get_CtrlCollected(); // 0x06743bac
	FairyGUI.Controller get_CtrlRarity(); // 0x06743c10
	FairyGUI.Controller get_CtrlShare(); // 0x06743c74
	System.Void .ctor(FairyGUI.GComponent root); // 0x0673fac4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ThirdTabItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <LoaderSkinBanner>k__BackingField; // 0x18
	FairyGUI.GTextField <TxtSkinName>k__BackingField; // 0x20
	FairyGUI.GButton <Star>k__BackingField; // 0x28
	FairyGUI.GLoader <HangingsIcon>k__BackingField; // 0x30
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComTagBinder <Tag>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlEquiped>k__BackingField; // 0x48
	FairyGUI.Controller <CtrlStyle>k__BackingField; // 0x50
	FairyGUI.Controller <CtrlRarity>k__BackingField; // 0x58
	FairyGUI.Controller <CtrlStarState>k__BackingField; // 0x60
	FairyGUI.Controller <CtrlRedDotState>k__BackingField; // 0x68
	FairyGUI.Controller <CtrlTimeLimit>k__BackingField; // 0x70
	FairyGUI.Controller <CtrlShowHangings>k__BackingField; // 0x78
	FairyGUI.Controller <CtrlShowIcon>k__BackingField; // 0x80
	FairyGUI.Controller <CtrlShowTag>k__BackingField; // 0x88
	FairyGUI.Controller <CtrlCanSelect>k__BackingField; // 0x90
	FairyGUI.Controller <CtrlCount>k__BackingField; // 0x98
	FairyGUI.Transition <TransShow_sg>k__BackingField; // 0xa0
	FairyGUI.GComponent get_BinderRoot(); // 0x06743cd8
	FairyGUI.GLoader get_LoaderSkinBanner(); // 0x06743d3c
	FairyGUI.GTextField get_TxtSkinName(); // 0x06743da0
	FairyGUI.GLoader get_HangingsIcon(); // 0x06743e04
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ComTagBinder get_Tag(); // 0x06743e68
	FairyGUI.Controller get_CtrlEquiped(); // 0x06743ecc
	FairyGUI.Controller get_CtrlStyle(); // 0x06743f30
	FairyGUI.Controller get_CtrlRarity(); // 0x06743f94
	FairyGUI.Controller get_CtrlStarState(); // 0x06743ff8
	FairyGUI.Controller get_CtrlRedDotState(); // 0x0674405c
	FairyGUI.Controller get_CtrlTimeLimit(); // 0x067440c0
	FairyGUI.Controller get_CtrlShowHangings(); // 0x06744124
	FairyGUI.Controller get_CtrlShowTag(); // 0x06744188
	System.Void .ctor(FairyGUI.GComponent root); // 0x067441ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.UiChoseSkinConstructionBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootChoseSkinConstructionBinder <Root>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootChoseSkinConstructionBinder get_Root(); // 0x06744694
	System.Void .ctor(FairyGUI.GComponent root); // 0x067446f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.UiLobbySkinBuildingBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootLobbySkinBuildingBinder <Root>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootLobbySkinBuildingBinder get_Root(); // 0x067447fc
	System.Void .ctor(FairyGUI.GComponent root); // 0x06744860
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.UiLobbySkinEntranceBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootLobbySkinEntranceBinder <Root>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootLobbySkinEntranceBinder get_Root(); // 0x06744964
	System.Void .ctor(FairyGUI.GComponent root); // 0x067449c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.BtnModeChooseBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GGraph <Bg>k__BackingField; // 0x18
	FairyGUI.GImage <Arrow>k__BackingField; // 0x20
	FairyGUI.GLabel <TeamNum>k__BackingField; // 0x28
	FairyGUI.GLabel <PlatfromName>k__BackingField; // 0x30
	FairyGUI.GLabel <AreaName>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x40
	FairyGUI.GComponent get_BinderRoot(); // 0x06744acc
	FairyGUI.GLabel get_TeamNum(); // 0x06744b30
	FairyGUI.GLabel get_PlatfromName(); // 0x06744b94
	FairyGUI.GLabel get_AreaName(); // 0x06744bf8
	FairyGUI.Controller get_CtrlButton(); // 0x06744c5c
	System.Void .ctor(FairyGUI.GComponent root); // 0x06744cc0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.ComChoosePopBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.BtnModeChooseBinder <BtnSelect>k__BackingField; // 0x18
	FairyGUI.GComponent <Content>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlShowSelMode>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlPlatform>k__BackingField; // 0x30
	WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.BtnModeChooseBinder get_BtnSelect(); // 0x06744ec8
	FairyGUI.GComponent get_Content(); // 0x06744f2c
	FairyGUI.Controller get_CtrlShowSelMode(); // 0x06744f90
	System.Void .ctor(FairyGUI.GComponent root); // 0x06744ff4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.ComMapBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <MapList>k__BackingField; // 0x18
	FairyGUI.GList <PageChange>k__BackingField; // 0x20
	FairyGUI.GComponent get_BinderRoot(); // 0x067451a0
	FairyGUI.GList get_MapList(); // 0x06745204
	FairyGUI.GList get_PageChange(); // 0x06745268
	System.Void .ctor(FairyGUI.GComponent root); // 0x067452cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.ComRightPopBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.ComMapBinder <Map>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.ComTimeBinder <OpenServiceTime>k__BackingField; // 0x20
	FairyGUI.GList <ListDesc>k__BackingField; // 0x28
	FairyGUI.GTextField <Desc>k__BackingField; // 0x30
	FairyGUI.GList <Labels>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlRankTag>k__BackingField; // 0x40
	FairyGUI.GComponent get_BinderRoot(); // 0x06745438
	WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.ComMapBinder get_Map(); // 0x0674549c
	WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.ComTimeBinder get_OpenServiceTime(); // 0x06745500
	FairyGUI.GList get_ListDesc(); // 0x06745564
	FairyGUI.GTextField get_Desc(); // 0x067455c8
	FairyGUI.GList get_Labels(); // 0x0674562c
	FairyGUI.Controller get_CtrlRankTag(); // 0x06745690
	System.Void .ctor(FairyGUI.GComponent root); // 0x067456f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.ComTimeBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Title>k__BackingField; // 0x18
	FairyGUI.GComponent get_BinderRoot(); // 0x06745a30
	FairyGUI.GTextField get_Title(); // 0x06745a94
	System.Void .ctor(FairyGUI.GComponent root); // 0x0674595c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.RootGameDialogContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Desc>k__BackingField; // 0x18
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x20
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0x28
	FairyGUI.GComponent get_BinderRoot(); // 0x06745af8
	FairyGUI.GTextField get_Desc(); // 0x06745b5c
	FairyGUI.Transition get_TransShow_anim(); // 0x06745bc0
	FairyGUI.Transition get_TransHide_anim(); // 0x06745c24
	System.Void .ctor(FairyGUI.GComponent root); // 0x06745c88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.RootSelectPlayModeBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <TopBar>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.RootSelectPlayModeContentBinder <Content>k__BackingField; // 0x20
	FairyGUI.GLabel get_TopBar(); // 0x06745dc4
	WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.RootSelectPlayModeContentBinder get_Content(); // 0x06745e28
	System.Void .ctor(FairyGUI.GComponent root); // 0x06745e8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.RootSelectPlayModeContentBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <PageBar>k__BackingField; // 0x18
	FairyGUI.GLabel <ModeBgNew>k__BackingField; // 0x20
	FairyGUI.GTextField <BigTitle>k__BackingField; // 0x28
	FairyGUI.GImage <Bg>k__BackingField; // 0x30
	WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.ComRightPopBinder <RightPop>k__BackingField; // 0x38
	FairyGUI.GButton <BtnInfo>k__BackingField; // 0x40
	FairyGUI.GButton <WarSituation>k__BackingField; // 0x48
	FairyGUI.GButton <BtnReserve>k__BackingField; // 0x50
	FairyGUI.GButton <BtnStart>k__BackingField; // 0x58
	FairyGUI.GButton <BtnServer>k__BackingField; // 0x60
	FairyGUI.GTextField <ReserveTitle>k__BackingField; // 0x68
	FairyGUI.GTextField <ReserveTime>k__BackingField; // 0x70
	FairyGUI.GGraph <Eff_black>k__BackingField; // 0x78
	WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.RootGameDialogContentBinder <Yeqian>k__BackingField; // 0x80
	WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.ComChoosePopBinder <ModeSelect>k__BackingField; // 0x88
	FairyGUI.Controller <CtrlPreModeStatus>k__BackingField; // 0x90
	FairyGUI.Controller <CtrlType>k__BackingField; // 0x98
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0xa0
	FairyGUI.Transition <TransHide_anim>k__BackingField; // 0xa8
	FairyGUI.Transition <TransClick>k__BackingField; // 0xb0
	FairyGUI.Transition <TransShow_anim_tuijian>k__BackingField; // 0xb8
	FairyGUI.Transition <TransHide_anim_tuijian>k__BackingField; // 0xc0
	FairyGUI.GComponent get_BinderRoot(); // 0x06746620
	FairyGUI.GComponent get_PageBar(); // 0x06746684
	FairyGUI.GTextField get_BigTitle(); // 0x067466e8
	WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.ComRightPopBinder get_RightPop(); // 0x0674674c
	FairyGUI.GButton get_BtnInfo(); // 0x067467b0
	FairyGUI.GButton get_WarSituation(); // 0x06746814
	FairyGUI.GButton get_BtnReserve(); // 0x06746878
	FairyGUI.GButton get_BtnStart(); // 0x067468dc
	FairyGUI.GButton get_BtnServer(); // 0x06746940
	FairyGUI.GTextField get_ReserveTime(); // 0x067469a4
	WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.RootGameDialogContentBinder get_Yeqian(); // 0x06746a08
	WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.ComChoosePopBinder get_ModeSelect(); // 0x06746a6c
	FairyGUI.Controller get_CtrlPreModeStatus(); // 0x06746ad0
	FairyGUI.Controller get_CtrlType(); // 0x06746b34
	FairyGUI.Transition get_TransShow_anim(); // 0x06746b98
	FairyGUI.Transition get_TransClick(); // 0x06746bfc
	System.Void .ctor(FairyGUI.GComponent root); // 0x06745fd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.BadgeLevelBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.DetailBadge_ComItemICON_SideShotBinder <Level1>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.DetailBadge_ComItemICON_SideShotBinder <Level2>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.DetailBadge_ComItemICON_SideShotBinder <Level3>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlBadgeNum>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlChosePage>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.DetailBadge_ComItemICON_SideShotBinder get_Level1(); // 0x06746c60
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.DetailBadge_ComItemICON_SideShotBinder get_Level2(); // 0x06746cc4
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.DetailBadge_ComItemICON_SideShotBinder get_Level3(); // 0x06746d28
	FairyGUI.Controller get_CtrlBadgeNum(); // 0x06746d8c
	System.Void .ctor(FairyGUI.GComponent root); // 0x06746df0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.BadgeTaskItem_lobbyBinder : System.Object
{
	
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ComCompletedBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Text>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlExpandState>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlShowArrary>k__BackingField; // 0x30
	FairyGUI.GComponent get_BinderRoot(); // 0x06747020
	FairyGUI.GTextField get_Text(); // 0x06747084
	FairyGUI.Controller get_CtrlStatus(); // 0x067470e8
	FairyGUI.Controller get_CtrlExpandState(); // 0x0674714c
	FairyGUI.Controller get_CtrlShowArrary(); // 0x067471b0
	System.Void .ctor(FairyGUI.GComponent root); // 0x06747214
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ComCompletedItemBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Text>k__BackingField; // 0x18
	FairyGUI.GTextField <Completed>k__BackingField; // 0x20
	FairyGUI.GTextField <Omit>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlIsComplete>k__BackingField; // 0x30
	FairyGUI.GTextField get_Text(); // 0x06747384
	FairyGUI.GTextField get_Omit(); // 0x067473e8
	FairyGUI.Controller get_CtrlIsComplete(); // 0x0674744c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067474b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ComIntegralBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GImage <Normal>k__BackingField; // 0x18
	FairyGUI.GImage <Selected>k__BackingField; // 0x20
	FairyGUI.GTextField <Title>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x30
	FairyGUI.GTextField get_Title(); // 0x06747638
	FairyGUI.Controller get_CtrlStatus(); // 0x0674769c
	System.Void .ctor(FairyGUI.GComponent root); // 0x06747700
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ComMedalinterfaceBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <TopBar>k__BackingField; // 0x18
	FairyGUI.GComponent <NavBar>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.MedalDetailsBinder <Content>k__BackingField; // 0x28
	FairyGUI.GComponent get_NavBar(); // 0x06747888
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.MedalDetailsBinder get_Content(); // 0x067478ec
	System.Void .ctor(FairyGUI.GComponent root); // 0x06747950
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ComPass_EntranceBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <TagLevel>k__BackingField; // 0x18
	FairyGUI.GTextField <Text>k__BackingField; // 0x20
	FairyGUI.GComponent get_BinderRoot(); // 0x06747ad8
	FairyGUI.GLabel get_TagLevel(); // 0x06747b3c
	System.Void .ctor(FairyGUI.GComponent root); // 0x06747ba0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ComPointBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GImage <NotUnlocked>k__BackingField; // 0x18
	FairyGUI.GImage <Collected>k__BackingField; // 0x20
	FairyGUI.GImage <Selected>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x30
	FairyGUI.Controller get_CtrlStatus(); // 0x06747cb4
	System.Void .ctor(FairyGUI.GComponent root); // 0x06747d18
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ComponentbarBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GTextField <Text>k__BackingField; // 0x18
	FairyGUI.GButton <Info>k__BackingField; // 0x20
	FairyGUI.GTextField <Benztext>k__BackingField; // 0x28
	FairyGUI.GTextField <Text1>k__BackingField; // 0x30
	FairyGUI.GTextField <Jifentext>k__BackingField; // 0x38
	FairyGUI.GProgressBar <PointBar>k__BackingField; // 0x40
	FairyGUI.GButton get_Info(); // 0x06747ea0
	FairyGUI.GTextField get_Jifentext(); // 0x06747f04
	FairyGUI.GProgressBar get_PointBar(); // 0x06747f68
	System.Void .ctor(FairyGUI.GComponent root); // 0x06747fcc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ComponenttopBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GRichTextField <Title>k__BackingField; // 0x18
	FairyGUI.GLoader <Iconxing>k__BackingField; // 0x20
	FairyGUI.GTextField <Xing>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlRank>k__BackingField; // 0x30
	FairyGUI.GRichTextField get_Title(); // 0x067481e0
	FairyGUI.GTextField get_Xing(); // 0x06748244
	FairyGUI.Controller get_CtrlRank(); // 0x067482a8
	System.Void .ctor(FairyGUI.GComponent root); // 0x0674830c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ComRewardBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <TopBar>k__BackingField; // 0x18
	FairyGUI.GComponent <NavBar2>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ContentSeasonBinder <Content>k__BackingField; // 0x28
	FairyGUI.GComponent get_NavBar2(); // 0x0674870c
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ContentSeasonBinder get_Content(); // 0x06748770
	System.Void .ctor(FairyGUI.GComponent root); // 0x067487d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ComRewardPointsBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <RewardTitle>k__BackingField; // 0x18
	FairyGUI.GList <List>k__BackingField; // 0x20
	FairyGUI.GButton <Get>k__BackingField; // 0x28
	FairyGUI.GList get_List(); // 0x06748c44
	FairyGUI.GButton get_Get(); // 0x06748ca8
	System.Void .ctor(FairyGUI.GComponent root); // 0x06748d0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ComSeasonBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <TopBar>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.SeasonrewardsContentBinder <Content>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.SeasonrewardsContentBinder get_Content(); // 0x06748e60
	System.Void .ctor(FairyGUI.GComponent root); // 0x06748ec4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ContentSeasonBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <List>k__BackingField; // 0x18
	FairyGUI.GButton <Left>k__BackingField; // 0x20
	FairyGUI.GButton <Right>k__BackingField; // 0x28
	FairyGUI.GTextField <Ranktext>k__BackingField; // 0x30
	FairyGUI.GList <Jianglilist>k__BackingField; // 0x38
	FairyGUI.Controller <CtrlSwitch>k__BackingField; // 0x40
	FairyGUI.Controller <CtrlPlatform>k__BackingField; // 0x48
	FairyGUI.GList get_List(); // 0x0674910c
	FairyGUI.GButton get_Left(); // 0x06749170
	FairyGUI.GButton get_Right(); // 0x067491d4
	FairyGUI.GTextField get_Ranktext(); // 0x06749238
	FairyGUI.GList get_Jianglilist(); // 0x0674929c
	FairyGUI.Controller get_CtrlSwitch(); // 0x06749300
	System.Void .ctor(FairyGUI.GComponent root); // 0x06748958
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.DetailBadge_ComItemICONBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <ComMedal>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlUnlock>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlIsGet>k__BackingField; // 0x30
	FairyGUI.Transition <TransUnlock>k__BackingField; // 0x38
	FairyGUI.Transition <TransSwitch>k__BackingField; // 0x40
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x48
	FairyGUI.GComponent get_BinderRoot(); // 0x06749364
	FairyGUI.GComponent get_ComMedal(); // 0x067493c8
	FairyGUI.Controller get_CtrlUnlock(); // 0x0674942c
	FairyGUI.Controller get_CtrlIsGet(); // 0x06749490
	FairyGUI.Transition get_TransUnlock(); // 0x067494f4
	System.Void .ctor(FairyGUI.GComponent root); // 0x06749558
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.DetailBadge_ComItemICON_SideShotBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <ComMedals>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlIsHide>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlUnlock>k__BackingField; // 0x30
	FairyGUI.Controller <CtrlIsGet>k__BackingField; // 0x38
	FairyGUI.GComponent get_BinderRoot(); // 0x06749750
	FairyGUI.GComponent get_ComMedals(); // 0x067497b4
	FairyGUI.Controller get_CtrlUnlock(); // 0x06749818
	FairyGUI.Controller get_CtrlIsGet(); // 0x0674987c
	System.Void .ctor(FairyGUI.GComponent root); // 0x067498e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.DetailBadge_MedalListBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLabel <Title>k__BackingField; // 0x18
	FairyGUI.GList <List>k__BackingField; // 0x20
	FairyGUI.GLabel get_Title(); // 0x06749a84
	FairyGUI.GList get_List(); // 0x06749ae8
	System.Void .ctor(FairyGUI.GComponent root); // 0x06749b4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ListItemPayRewardBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Bg>k__BackingField; // 0x18
	FairyGUI.GLoader <Icon>k__BackingField; // 0x20
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x28
	FairyGUI.Controller <CtrlQuality>k__BackingField; // 0x30
	FairyGUI.GComponent get_BinderRoot(); // 0x06749c60
	FairyGUI.GLoader get_Icon(); // 0x06749cc4
	FairyGUI.Controller get_CtrlQuality(); // 0x06749d28
	System.Void .ctor(FairyGUI.GComponent root); // 0x06749d8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.MedalDetailsBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GList <GroupList>k__BackingField; // 0x18
	FairyGUI.GTextField <SelectSeasonTitle>k__BackingField; // 0x20
	FairyGUI.GComboBox <AllSeasonCombox>k__BackingField; // 0x28
	FairyGUI.GRichTextField <Title>k__BackingField; // 0x30
	FairyGUI.GTextField <MedalText>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.BadgeLevelBinder <ComBadge>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ComCompletedBinder <Completed>k__BackingField; // 0x48
	FairyGUI.GRichTextField <IntelligenceText>k__BackingField; // 0x50
	FairyGUI.GList <List>k__BackingField; // 0x58
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ComRewardPointsBinder <RewardPoints>k__BackingField; // 0x60
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x68
	FairyGUI.Controller <CtrlType>k__BackingField; // 0x70
	FairyGUI.Controller <CtrlShowList>k__BackingField; // 0x78
	FairyGUI.Controller <CtrlShowUnlockTip>k__BackingField; // 0x80
	FairyGUI.Transition <TransReset>k__BackingField; // 0x88
	FairyGUI.Transition <TransShow_anim>k__BackingField; // 0x90
	FairyGUI.GList get_GroupList(); // 0x06749f08
	FairyGUI.GTextField get_SelectSeasonTitle(); // 0x06749f6c
	FairyGUI.GComboBox get_AllSeasonCombox(); // 0x06749fd0
	FairyGUI.GRichTextField get_Title(); // 0x0674a034
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.BadgeLevelBinder get_ComBadge(); // 0x0674a098
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ComCompletedBinder get_Completed(); // 0x0674a0fc
	FairyGUI.GRichTextField get_IntelligenceText(); // 0x0674a160
	FairyGUI.GList get_List(); // 0x0674a1c4
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ComRewardPointsBinder get_RewardPoints(); // 0x0674a228
	FairyGUI.Controller get_CtrlType(); // 0x0674a28c
	FairyGUI.Controller get_CtrlShowList(); // 0x0674a2f0
	FairyGUI.Controller get_CtrlShowUnlockTip(); // 0x0674a354
	FairyGUI.Transition get_TransReset(); // 0x0674a3b8
	System.Void .ctor(FairyGUI.GComponent root); // 0x0674a41c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.RankiconBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GComponent <Icon>k__BackingField; // 0x18
	FairyGUI.Controller <CtrlReceive>k__BackingField; // 0x20
	FairyGUI.GComponent get_Icon(); // 0x0674a958
	FairyGUI.Controller get_CtrlReceive(); // 0x0674a9bc
	System.Void .ctor(FairyGUI.GComponent root); // 0x0674aa20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.RankliskBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <Rankicon>k__BackingField; // 0x18
	FairyGUI.GImage <SelectBG>k__BackingField; // 0x20
	FairyGUI.GComponent <RedDot>k__BackingField; // 0x28
	FairyGUI.GProgressBar <LeftLine>k__BackingField; // 0x30
	FairyGUI.GProgressBar <RightLine>k__BackingField; // 0x38
	FairyGUI.GTextField <Ranktext>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ComPointBinder <Point>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ComIntegralBinder <Integral>k__BackingField; // 0x50
	FairyGUI.GTextField <Number>k__BackingField; // 0x58
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x60
	FairyGUI.Controller <CtrlEnough>k__BackingField; // 0x68
	FairyGUI.Controller <CtrlLineState>k__BackingField; // 0x70
	FairyGUI.Controller <CtrlSelectState>k__BackingField; // 0x78
	FairyGUI.Controller <CtrlPlatform>k__BackingField; // 0x80
	FairyGUI.GLoader get_Rankicon(); // 0x0674ab28
	FairyGUI.GComponent get_RedDot(); // 0x0674ab8c
	FairyGUI.GProgressBar get_LeftLine(); // 0x0674abf0
	FairyGUI.GProgressBar get_RightLine(); // 0x0674ac54
	FairyGUI.GTextField get_Ranktext(); // 0x0674acb8
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ComPointBinder get_Point(); // 0x0674ad1c
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ComIntegralBinder get_Integral(); // 0x0674ad80
	FairyGUI.GTextField get_Number(); // 0x0674ade4
	FairyGUI.Controller get_CtrlButton(); // 0x0674ae48
	FairyGUI.Controller get_CtrlEnough(); // 0x0674aeac
	FairyGUI.Controller get_CtrlLineState(); // 0x0674af10
	FairyGUI.Controller get_CtrlSelectState(); // 0x0674af74
	System.Void .ctor(FairyGUI.GComponent root); // 0x0674afd8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.RootBattlemadalBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.RootBattleMedalcontentBinder <Content>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.RootBattleMedalcontentBinder get_Content(); // 0x0674b418
	System.Void .ctor(FairyGUI.GComponent root); // 0x0674b47c
}

// Client.Runtime
