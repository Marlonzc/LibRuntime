	System.Int64 get_TemplateId(); // 0x0722b258
	System.Boolean get_TrapIsWorking(); // 0x0722b2cc
	System.Boolean get_TrapIsOpen(); // 0x0722b340
	System.Single get_ControlPointYaw(); // 0x0722b3b4
	System.Int64 get_StartRotateTime(); // 0x0722b428
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x0722b49c
	System.Void RemoteCallCompostingTrap(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean start); // 0x0722b6dc
	UnityEngine.Transform get_ControlTransform(); // 0x0722b864
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent get_objectComponent(); // 0x0722b8c8
	System.Void set_objectComponent(WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent value); // 0x0722b92c
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x0722b9ac
	System.Void OnSkinGoRemove(); // 0x0722c198
	System.Void Init(); // 0x0722c1f8
	System.Void UpdateRotate(); // 0x0722c38c
	System.Single CalRotateYaw(); // 0x0722c4f0
	System.Single CalRecoverYaw(); // 0x0722c644
	System.Void OnGoLoaded(); // 0x0722c8bc
	System.Void InitControlPoint(); // 0x0722bac8
	System.Void Add2GunTrapSystem(); // 0x0722cc9c
	System.Void RemoveFromGunTrapSystem(); // 0x0722cd74
	System.Void InitEffect(); // 0x0722bc68
	UnityEngine.Transform GetWeaponFireMuzzle(); // 0x0722ce48
	System.Void TrapIsOpenChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x0722d1a4
	System.Void TrapIsWorkingChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x0722d408
	System.Void PlayWorkAudio(); // 0x0722cfa4
	System.Void PlayFireEffect(); // 0x0722d684
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x0722d890
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x0722d904
	System.Boolean HasFuel(); // 0x0722da70
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x0722dfc0
	System.Void AddInteractiveId1(System.Collections.Generic.List<System.Int32> retList); // 0x0722db4c
	System.Void AddInteractiveId2(System.Collections.Generic.List<System.Int32> retList); // 0x0722dd24
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x0722e034
	System.Void OnClickAdd(); // 0x0722e28c
	System.Void OnClickRemove(); // 0x0722e464
	System.Void Cleanup(); // 0x0722e5e4
	System.Void CompostingTrapAck(System.Int32 result); // 0x0722b668
	static System.Void .cctor(); // 0x0722e8f8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.HitchTroughComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 1143425585;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x0722eab8
	System.String GetTypeName(); // 0x0722eb20
	System.Int32 get_Id(); // 0x0722eb98
	System.Void .ctor(); // 0x0722ebfc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0722ec88
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0722ed38
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0722ede8
	System.Void PostInit(); // 0x0722ee4c
	static System.Void .cctor(); // 0x0722eeb4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.HorseComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 2129343526;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x0722efa4
	System.String GetTypeName(); // 0x0722f00c
	System.Int32 get_Id(); // 0x0722f084
	System.Void .ctor(); // 0x0722f0e8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0722f174
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0722f224
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0722f2d4
	System.UInt64 get_OwnerId(); // 0x0722f338
	System.Int32 get_LastBuyTs(); // 0x0722f3ac
	System.Void PostInit(); // 0x0722f420
	static System.Void .cctor(); // 0x0722f494
}

// Client.Runtime
class WizardGames.Soc.Common.Component.HorseCorpseComponent : WizardGames.Soc.Common.Component.BaseCorpseComponent
{
	static System.Int32 CLASS_HASH = 476724902;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x0722f620
	System.String GetTypeName(); // 0x0722f688
	System.Int32 get_Id(); // 0x0722f700
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0722f764
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0722f814
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0722f8c4
	System.Void PostInit(); // 0x0722f928
	static System.Void .cctor(); // 0x0722f99c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.HorseStableComponent : WizardGames.Soc.Common.Component.NpcShopComponent
{
	static System.Int32 CLASS_HASH = 1665172534;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x0722fa8c
	System.String GetTypeName(); // 0x0722faf4
	System.Int32 get_Id(); // 0x0722fb6c
	System.Void .ctor(); // 0x0722fbd0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0722fce4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0722fe40
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0722ff9c
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x07230000
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x07230160
	static System.Object DeserializeHorseStableComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072303b8
	System.Void PostInit(); // 0x072304dc
	System.Void OpenShopUi(); // 0x07230544
	static System.Void .cctor(); // 0x07230624
}

// Client.Runtime
class WizardGames.Soc.Common.Component.IOComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 239538141;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x07230818
	System.String GetTypeName(); // 0x07230880
	System.Int32 get_Id(); // 0x072308f8
	System.Void .ctor(); // 0x0723095c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072309e8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07230a98
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07230b48
	static System.Void .cctor(); // 0x07230bac
}

// Client.Runtime
class WizardGames.Soc.Common.Component.KatyushaComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 830994838;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	static SocLogger logger; // 0x10
	System.Collections.Generic.List<System.Int64> nodePath; // 0x38
	System.Int32 GetClassHash(); // 0x07230cd0
	System.String GetTypeName(); // 0x07230d38
	System.Int32 get_Id(); // 0x07230db0
	System.Void .ctor(); // 0x07230e14
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07230fc4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07231198
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0723136c
	System.Void RemoteCallLaunch(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Single x, System.Single y, System.Single z); // 0x072313d0
	System.Void RemoteCallLoad(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 num); // 0x0723157c
	System.Void RemoteCallUnload(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 num); // 0x07231704
	System.Int32 GetMissileCount(); // 0x0723188c
	System.Void PostInit(); // 0x07231aa4
	static System.Void .cctor(); // 0x07231b18
}

// Client.Runtime
class WizardGames.Soc.Common.Component.LiftPlatformComponent : WizardGames.Soc.Share.Framework.ComponentBase, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 37281883;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer gpuInstContainer; // 0x38
	UnityEngine.RaycastHit[] rayCastHitArrayCache; // 0x40
	WizardGames.Soc.Common.Component.LiftPlatformComponent.RaycastComparer raycastComparer; // 0x48
	System.Collections.Generic.List<System.Int32> tempList; // 0x50
	WizardGames.Soc.Common.Component.ConstructionFlagComponent flagComp; // 0x58
	UnityEngine.Animator animator; // 0x60
	UnityEngine.Transform staticDownMeshTrans; // 0x68
	UnityEngine.Transform staticUpMeshTrans; // 0x70
	UnityEngine.Transform dynamicMeshTrans; // 0x78
	System.String animName; // 0x80
	VehicleLiftDetectTrigger playerTrigger; // 0x88
	UnityEngine.Collider playerTriggerCollider; // 0x90
	System.Int32 GetClassHash(); // 0x07231c74
	System.String GetTypeName(); // 0x07231cdc
	System.Int32 get_Id(); // 0x07231d54
	System.Void .ctor(); // 0x07231db8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07231f9c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0723213c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072322dc
	System.Int64 get_GrabCarEntityId(); // 0x07232340
	System.Void RemoteCallTryEditCar(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x072323b4
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x07232510
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x07232584
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x072325f8
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x07232f30
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x0723315c
	UnityEngine.GameObject get_MainGo(); // 0x07233214
	System.Boolean get_IsBusy(); // 0x07232e64
	System.Boolean get_IsOn(); // 0x07232d98
	System.Void OnGoLoaded(); // 0x072332d8
	System.Void Cleanup(); // 0x072334e4
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x072335f8
	System.Void OnSkinGoRemove(); // 0x07233d70
	System.Void OnFlagChanged(System.Int32 lastFlag, System.Int32 newFlag); // 0x07233ba4
	System.Void SwitchTransRender(System.Boolean isOn, System.Boolean isBusy); // 0x07233dd0
	System.Void OnBeginLiftUp(); // 0x07234174
	System.Void OnBeginLiftDown(); // 0x07234230
	System.Void OnEndLiftDown(); // 0x072342ec
	System.Void OnGoLoadedDifferentSide(); // 0x07233940
	System.Void OnFlagChangedDifferentSide(System.Int32 lastFlag, System.Int32 newFlag); // 0x07233ffc
	System.Void OnAnimEnableChanged(System.Boolean enable); // 0x07233ee0
	static System.Void .cctor(); // 0x0723434c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.LiftPlatformComponent.RaycastComparer : System.Object, System.Collections.Generic.IComparer<UnityEngine.RaycastHit>
{
	
	System.Int32 Compare(UnityEngine.RaycastHit hit1, UnityEngine.RaycastHit hit2); // 0x07234408
	System.Void .ctor(); // 0x07231f34
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ModularCarComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 1073733678;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072344cc
	System.String GetTypeName(); // 0x07234534
	System.Int32 get_Id(); // 0x072345ac
	System.Void .ctor(); // 0x07234610
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0723469c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0723474c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072347fc
	System.Void PostInit(); // 0x07234860
	static System.Void .cctor(); // 0x072348d4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ModularCarDamageableComponent : WizardGames.Soc.Common.Component.DamageableComponent
{
	static System.Int32 CLASS_HASH = 1486138441;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x07234990
	System.String GetTypeName(); // 0x072349f8
	System.Int32 get_Id(); // 0x07234a70
	System.Void .ctor(); // 0x07234ad4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07234b60
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07234c10
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07234cc0
	static System.Void .cctor(); // 0x07234d24
}

// Client.Runtime
class WizardGames.Soc.Common.Component.MonsterComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1320827101;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x07234f4c
	System.String GetTypeName(); // 0x07234fb4
	System.Int32 get_Id(); // 0x0723502c
	System.Void .ctor(); // 0x07235090
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0723511c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072351cc
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0723527c
	static System.Object DeserializeMonsterComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072352e0
	static System.Void .cctor(); // 0x072353b8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.NpcShopComponent : WizardGames.Soc.Common.Component.ShopComponent
{
	static System.Int32 CLASS_HASH = 902067698;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072354a8
	System.String GetTypeName(); // 0x07235510
	System.Int32 get_Id(); // 0x07235588
	System.Void .ctor(); // 0x0722fc58
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0722fd90
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0722feec
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072355ec
	System.Int64 get_NpcTableId(); // 0x07235650
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x072356c4
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x07235824
	static System.Object DeserializeNpcShopComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07235a7c
	static System.Void .cctor(); // 0x07235ba0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.OutsideDataSetComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1703013973;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 cachedOldLod; // 0x34
	System.Int32 GetClassHash(); // 0x07235d94
	System.String GetTypeName(); // 0x07235dfc
	System.Int32 get_Id(); // 0x07235e74
	System.Void .ctor(); // 0x07235ed8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07235f64
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0723609c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0723614c
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.BuildingPartBrief> get_OutsideParts(); // 0x072361b0
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.BuildingPartBrief> get_OutsidePartsMedium(); // 0x07236250
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x072362f0
	static System.Object DeserializeOutsideDataSetComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07236454
	static System.Void .cctor(); // 0x0723657c
	System.Void PostInit(); // 0x0723698c
	System.Void Cleanup(); // 0x07236e78
	static System.Void OnLongFieldChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Int64 oldValue, System.Int64 newValue); // 0x07237314
	static System.Void OnIntFieldChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Int32 oldValue, System.Int32 newValue); // 0x07237534
	static System.Void OnPropChanged(WizardGames.Soc.Share.Framework.CustomTypeBase customType); // 0x072373b8
	System.Void OnOutsidePartsChange(WizardGames.Soc.Share.Framework.ECustomDictOpType dictOp, System.Int64 key, WizardGames.Soc.Common.CustomType.BuildingPartBrief oldInfo); // 0x072375d8
	System.Void OnLodSwitch(System.Int32 oldLod, System.Int32 newLod); // 0x0723787c
	System.Void OnOutsideDicAdded(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.BuildingPartBrief> dic); // 0x07236b24
	System.Void OnOutsideDicClear(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.BuildingPartBrief> dic); // 0x07236fd4
	System.Boolean TryGetPartInfo(System.Int64 entityId, WizardGames.Soc.Common.CustomType.BuildingPartBrief& info); // 0x0723779c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.OvenComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 1845104910;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x07237a24
	System.String GetTypeName(); // 0x07237a8c
	System.Int32 get_Id(); // 0x07237b04
	System.Void .ctor(); // 0x07237b68
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07237bf4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07237ca4
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07237d54
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x07237db8
	System.Void RemoteCallOvenComposeStart(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 recipeId, System.Int32 count); // 0x07238054
	System.Void RemoteCallOvenComposeCancel(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 index); // 0x072381e8
	System.Void RemoteCallOvenMoveToHead(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 index); // 0x07238370
	System.Void RemoteCallOvenClaim(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 index); // 0x072384f8
	System.Void PostInit(); // 0x07238680
	System.Void OvenComposeStartResponse(System.Int32 opCode); // 0x072387b0
	System.Void OvenComposeCancelResponse(System.Int32 opCode); // 0x07238958
	System.Void OvenMoveToHeadResponse(System.Int32 opCode); // 0x07238b00
	System.Void OvenClaimResponse(System.Int32 opCode); // 0x07238bf0
	static System.Void .cctor(); // 0x07238d98
	System.Void <PostInit>b__19_0(); // 0x07238e54
	System.Void <PostInit>b__19_1(WizardGames.Soc.Share.Framework.CustomTypeBase _, WizardGames.Soc.Share.Framework.CustomTypeBase oldRoot, WizardGames.Soc.Share.Framework.CustomTypeBase newRoot); // 0x07238f1c
	System.Void <PostInit>b__19_2(); // 0x07239054
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PartDamageableComponent : WizardGames.Soc.Share.Framework.ComponentBase, WizardGames.Soc.Common.Entity.IHitableEntity
{
	static System.Int32 CLASS_HASH = 22;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 <DefenseTemplateId>k__BackingField; // 0x34
	System.Single[] <BaseProtection>k__BackingField; // 0x38
	System.Single[][] <AreaProtections>k__BackingField; // 0x40
	System.Boolean <ScaleDamageByPart>k__BackingField; // 0x48
	System.Int32 GetClassHash(); // 0x0723911c
	System.String GetTypeName(); // 0x07239180
	System.Int32 get_Id(); // 0x072391f8
	System.Void .ctor(); // 0x0723925c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072392f0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072393a8
	System.Int32 get_CombatTemplateId(); // 0x0723940c
	System.Void set_CombatTemplateId(System.Int32 value); // 0x07239480
	System.Single get_PartMaxHp(); // 0x0723950c
	System.Void set_PartMaxHp(System.Single value); // 0x07239580
	System.Single get_PartHp(); // 0x0723960c
	System.Void set_PartHp(System.Single value); // 0x07239680
	System.Int64 get_LastAttackedTime(); // 0x0723970c
	System.Void PostInit(); // 0x07239780
	System.Void set_DefenseTemplateId(System.Int32 value); // 0x0723993c
	System.Single[] get_BaseProtection(); // 0x072399b4
	System.Void set_BaseProtection(System.Single[] value); // 0x07239a18
	System.Void set_AreaProtections(System.Single[][] value); // 0x07239a98
	System.Void set_ScaleDamageByPart(System.Boolean value); // 0x07239b18
	System.Single get_SecondsSinceAttacked(); // 0x07239b94
	System.Single get_Hp(); // 0x07239c40
	System.Void set_Hp(System.Single value); // 0x07239e3c
	System.Single get_MaxHp(); // 0x0723a090
	System.Void set_MaxHp(System.Single value); // 0x0723a28c
	System.Void ReturnToPoolBusiness(); // 0x0723a4e0
	static System.Void .cctor(); // 0x0723a690
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PassiveTrapComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1560796158;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x0723a8b4
	System.String GetTypeName(); // 0x0723a91c
	System.Int32 get_Id(); // 0x0723a994
	System.Void .ctor(); // 0x0723a9f8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0723aa84
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0723ab34
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0723abe4
	static System.Void .cctor(); // 0x0723ac48
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PatrolComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1578245163;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x0723ad04
	System.String GetTypeName(); // 0x0723ad6c
	System.Int32 get_Id(); // 0x0723ade4
	System.Void .ctor(); // 0x0723ae48
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0723aed4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0723af84
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0723b034
	System.Int32 get_TableId(); // 0x0723b098
	System.Single get_RoadLength(); // 0x0723b10c
	System.Single get_PatrolLength(); // 0x0723b180
	WizardGames.Soc.Common.Entity.EPatrolGroupState get_PatrolState(); // 0x0723b1f4
	System.Single get_BornPosX(); // 0x0723b268
	System.Single get_BornPosY(); // 0x0723b2dc
	System.Single get_BornPosZ(); // 0x0723b350
	System.Boolean get_PatrolMove(); // 0x0723b3c4
	static System.Void .cctor(); // 0x0723b438
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PermissionHubComponent : WizardGames.Soc.Share.Framework.ComponentBase, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler, WizardGames.Soc.Common.Construction.IChangeTransform, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 275607432;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x38
	Effect.EffectItemHandle<Effect.EffectItem> wallEffectItemHandle; // 0x40
	System.Collections.Generic.Dictionary<System.Int32,Effect.EffectItemHandle<Effect.EffectItem>> pillarEffectItemHandles; // 0x50
	System.Boolean isFxShow; // 0x58
	static System.Boolean IsEffectColorInited; // 0x10
	static UnityEngine.Color WallEffectLandDay; // 0x14
	static UnityEngine.Color WallEffectLandNight; // 0x24
	static UnityEngine.Color WallEffectWaterDay; // 0x34
	static UnityEngine.Color WallEffectWaterNight; // 0x44
	static UnityEngine.Color PillarEffectLandDay; // 0x54
	static UnityEngine.Color PillarEffectLandNight; // 0x64
	static UnityEngine.Color PillarEffectWaterDay; // 0x74
	static UnityEngine.Color PillarEffectWaterNight; // 0x84
	System.Boolean isVirtualPartRecordDirty; // 0x59
	static System.Int32 RuledDistance; // 0x94
	System.Collections.Generic.List<System.Int64> RuledWorkbench; // 0x60
	WizardGames.Soc.Common.Entity.PartEntity partEntity; // 0x68
	System.Boolean canShowSafeBox; // 0x70
	UnityEngine.Vector3 originLockPos; // 0x74
	UnityEngine.Vector3 reputationLockPos; // 0x80
	WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer <gpuInstContainer>k__BackingField; // 0x90
	WizardGames.Soc.SocClient.GpuInstance.GpuInstObject[] lockInstObjects; // 0x98
	UnityEngine.GameObject skinNode; // 0xa0
	System.Int32 GetClassHash(); // 0x0723b730
	System.String GetTypeName(); // 0x0723b798
	System.Int32 get_Id(); // 0x0723b810
	System.Void .ctor(); // 0x0723b874
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0723b9a4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0723baf8
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0723bc4c
	System.Void RemoteCallRequestSwitchToolboxMode(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 mode); // 0x0723bcb0
	System.Void InitEffectColorConst(); // 0x0723be38
	UnityEngine.Color ParseColorFromConfig(System.Collections.Generic.List<System.Int32> colorArray); // 0x0723c2b8
	System.Void ShowPermissionEffect(); // 0x0723c3e4
	System.Void HidePermissionEffect(); // 0x0723d334
	System.Void ReLocatedFxPosition(); // 0x0723d574
	System.Void ChangeFxColor(); // 0x0723ca60
	System.Void ReleaseEffect(); // 0x0723d940
	WizardGames.Soc.Common.Entity.TerritoryEntity get_TerritoryEnt(); // 0x0723dbd4
	System.Boolean get_IsReputationMode(); // 0x0723dd7c
	WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer get_gpuInstContainer(); // 0x0723dec4
	System.Void set_gpuInstContainer(WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer value); // 0x0723df28
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x0723dfa8
	System.Void Init(); // 0x0723e060
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x0723e0c8
	System.Boolean HasFlag(WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags flag); // 0x0723dde4
	System.Void OnSkinGoRemove(); // 0x0723f528
	System.Void OnGoLoaded(); // 0x0723f588
	System.Void Cleanup(); // 0x0723f798
	System.Void RecordLockOriginPosAndLockInstObjects(UnityEngine.GameObject skinGo); // 0x0723e7ac
	System.Void GetHighestLevelWorkBench(System.Int32& maxLv, System.Int64& maxEntityId); // 0x0723fb50
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x0723fd5c
	System.Void ShowMeshNode(System.Int32 newFlag); // 0x0723f3f8
	System.Void ChangeLockPos(UnityEngine.Vector3 newPos); // 0x0723edf0
	System.Void TryShowNode(System.String nodeName, System.String path); // 0x0723ec00
	System.Void TryHideNode(System.String nodeName); // 0x0723ea28
	System.Void RecordRuledConstruction(); // 0x0723f0ac
	System.Void RuledConstructionCreateFilter(WizardGames.Soc.Common.Entity.IEntity entity); // 0x0723fdf8
	System.Void RuledConstructionRemoveFilter(WizardGames.Soc.Common.Entity.IEntity entity); // 0x07240150
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x072402f8
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x07240ee0
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x07241a88
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x07241afc
	System.Boolean CheckNeedAddGoldUiBtn(); // 0x07240e30
	System.Void StorageGoldCoins(); // 0x0724281c
	System.String GetSouDJCanSwitchToolBoxTimeDesc(); // 0x07242a50
	System.Void RequestSwitchToolBoxMode(System.Int64 entityId, System.Int32 mode); // 0x07241f64
	System.Void OnTransformChanged(); // 0x07242c58
	static System.Void .cctor(); // 0x07242cbc
	System.Void <OnSkinGoLoaded>b__82_0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x07242d54
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PermissionHubComponent.<>c__DisplayClass103_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode packItemNode; // 0x10
	System.Void .ctor(); // 0x07242eec
	System.Boolean <StorageGoldCoins>b__0(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x07242f54
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PermissionHubComponent.<>c__DisplayClass105_0 : System.Object
{
	System.Boolean souDJCurStageBan; // 0x10
	WizardGames.Soc.Common.Component.PermissionHubComponent <>4__this; // 0x18
	System.Int32 mode; // 0x20
	System.Void .ctor(); // 0x07243008
	System.Void <RequestSwitchToolBoxMode>b__0(); // 0x07243070
	System.Void <RequestSwitchToolBoxMode>b__1(); // 0x07243268
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PickableItemComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 301488303;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x07243390
	System.String GetTypeName(); // 0x072433f8
	System.Int32 get_Id(); // 0x07243470
	System.Void .ctor(); // 0x072434d4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07243560
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07243678
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07243728
	WizardGames.Soc.Common.CustomType.SystemRootNode get_SystemRoot(); // 0x0724378c
	WizardGames.Soc.Common.Component.RootNodeComponent get_rootNode(); // 0x07243850
	System.Void Init(); // 0x072438e8
	System.Void PostInit(); // 0x07243950
	System.Void Cleanup(); // 0x072439e4
	static System.Void .cctor(); // 0x07243a78
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlantBoxComponent : WizardGames.Soc.Common.Component.StorageComponent, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 142602436;
	static System.Int32 StaticClassHash; // 0x0
	static System.String TYPE_NAME = "PlantBoxComponent";
	static System.String[] PropNameArray; // 0x8
	static SocLogger logger; // 0x10
	static System.Int32 PLANT_MGR_ID = 500;
	static System.Int32 SEED_ID = 501;
	static System.Int32 WATER_ID = 502;
	static System.Int32 MANURE_ID = 503;
	static System.Int32 HARVEST_ID = 504;
	WizardGames.Soc.SocClient.Ui.PlantBoxCtrl plantBoxCtrl; // 0x38
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x40
	System.Int64 updateWaterTimerId; // 0x48
	Effect.EffectItemHandle<Effect.EffectItem> splashWaterHandle; // 0x50
	Effect.EffectItemHandle<Effect.EffectItem> fallWaterHandle; // 0x60
	ConstructionSkinNodeConfig constructionSkinNodeConfig; // 0x70
	WizardGames.Soc.SocClient.Plant.PlantBoxData plantBoxData; // 0x78
	System.Int32 GetClassHash(); // 0x07243b34
	System.String GetTypeName(); // 0x07243b9c
	System.Int32 get_Id(); // 0x07243c14
	System.Void .ctor(); // 0x07243c78
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07243d3c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07243e24
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07243f0c
	System.Int32 get_Water(); // 0x07243f70
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x07243fe4
	System.Void RemoteCallAddWater(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x072444d4
	System.Void RemoteCallAddManure(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int32> indexes); // 0x07244630
	System.Void RemoteCallPlant(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.Alpha3PlantArgs> args); // 0x072447b8
	System.Void RemoteCallHarvest(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 index); // 0x07244940
	System.Void RemoteCallRemove(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 index); // 0x07244ac8
	System.Void RemoteCallManualHybridizeFinish(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 magicNum, System.Collections.Generic.IList<System.Int32> pointIndexes, System.Collections.Generic.IList<System.Int32> pointValues, System.Int32 result); // 0x07244c50
	static System.Void .cctor(); // 0x07244e18
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x07245078
	WizardGames.Soc.SocClient.Plant.PlantBoxData get_PlantBoxData(); // 0x07245130
	System.Void PostInit(); // 0x07245194
	System.Void UpdatePlants(); // 0x072453a0
	static System.Void WaterUpdated(WizardGames.Soc.Share.Framework.CustomTypeBase comp, System.Int32 oldVal, System.Int32 newVal); // 0x07245418
	System.Void OnGoLoaded(); // 0x072456cc
	System.Void Cleanup(); // 0x07245c54
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x07245f38
	System.Void OnSkinGoRemove(); // 0x07245fe0
	System.Boolean HasAnyPlant(); // 0x07246040
	System.Void RefreshPlants(System.Int64 entityId); // 0x07245b98
	System.Void InitInstanceToggleGroup(); // 0x072458c4
	System.Void OnWaterSuccess(System.Int64 id, System.Int32 waterVal); // 0x072460c0
	System.Void OnManualSuccess(System.Int64 id); // 0x0724683c
	System.Void PlayFx(); // 0x07246250
	System.Void ReleaseEffectGo(); // 0x072469bc
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x07246a94
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x07246d40
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x07246db4
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x07246e28
	System.Void OnAddWater(System.Int32 value, System.Int32 result); // 0x07247524
	System.Void OnAddManure(WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> indexes, System.Int32 result); // 0x0724774c
	System.Void OnPlant(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.Alpha3PlantArgs> successList, System.Int32 result); // 0x072478f8
	System.Void OnHarvest(System.Int32 index, System.Int32 result); // 0x07247a98
	System.Void OnRemove(System.Int32 index, System.Int32 result); // 0x07247c20
	System.Void OnManualHybridizeStart(System.Int64 index, System.Int32 result, System.Int32 magicNum); // 0x07247d1c
	System.Void OnManualHybridizeFinish(System.Int64 index, System.Int32 result); // 0x07247fa0
	System.Void OnManualHybridizeClear(System.Int32 result); // 0x072481b8
	System.Void <PlayFx>b__56_2(System.Int64 id, System.Object data, System.Boolean delete); // 0x0724839c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlantBoxComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.PlantBoxComponent.<>c <>9; // 0x0
	static System.Action<System.Boolean,Effect.EffectItem,System.Object> <>9__56_0; // 0x8
	static System.Action<System.Boolean,Effect.EffectItem,System.Object> <>9__56_1; // 0x10
	static System.Void .cctor(); // 0x07248430
	System.Void .ctor(); // 0x07248494
	System.Void <PlayFx>b__56_0(System.Boolean success, Effect.EffectItem effectItem, System.Object o); // 0x072484fc
	System.Void <PlayFx>b__56_1(System.Boolean success, Effect.EffectItem effectItem, System.Object o); // 0x072485bc
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlantBoxComponent.<>c__DisplayClass46_0 : System.Object
{
	WizardGames.Soc.Common.Component.PlantBoxComponent self; // 0x10
	System.Void .ctor(); // 0x07245664
	System.Void <WaterUpdated>b__0(System.Int64 _); // 0x0724867c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlantBoxComponent.<>c__DisplayClass61_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode waterHolder; // 0x10
	System.Void .ctor(); // 0x072473c8
	System.Boolean <OnUiBtnClicked>b__0(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x0724876c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerActivityComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1675713851;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x07248854
	System.String GetTypeName(); // 0x072488bc
	System.Int32 get_Id(); // 0x07248934
	System.Void .ctor(); // 0x07248998
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07248a24
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07248b3c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07248bec
	WizardGames.Soc.Common.CustomType.PlayerActivityRootNode get_SystemRoot(); // 0x07248c50
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x07248d14
	System.Void RemoteCallGetDrumReward(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 partEntityId, System.Collections.Generic.IList<System.Int64> itemUidList); // 0x07249270
	System.Void Init(); // 0x07249404
	System.Void PostInit(); // 0x0724946c
	WizardGames.Soc.Common.CustomType.ActivityContainer GetActivityContainer(System.Int32 activityId); // 0x072494d4
	WizardGames.Soc.Common.CustomType.ItemContainerNode GetDrumContainer(System.Int32 activityId); // 0x07249750
	System.Collections.Generic.List<System.Int64> GetDrumItemList(System.Int32 activityId); // 0x0724993c
	System.Void DrummingAck(System.Int32 opCode); // 0x07248f20
	System.Void GetDrumRewardAck(System.Int32 opCode); // 0x0724906c
	static System.Void .cctor(); // 0x07249dcc
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerArchiveRebornPointComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 2085467596;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x07249e88
	System.String GetTypeName(); // 0x07249ef0
	System.Int32 get_Id(); // 0x07249f68
	System.Void .ctor(); // 0x07249fcc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0724a058
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0724a108
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0724a1b8
	System.Single get_PositionX(); // 0x0724a21c
	System.Single get_PositionY(); // 0x0724a290
	System.Single get_PositionZ(); // 0x0724a304
	System.Single get_Range(); // 0x0724a378
	System.Int32 get_ActivateCdSec(); // 0x0724a3ec
	System.Int32 get_AutoRebornCdSec(); // 0x0724a460
	static System.Void .cctor(); // 0x0724a4d4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerBombHomeComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 402416853;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	static SocLogger log; // 0x10
	System.Int32 GetClassHash(); // 0x0724a764
	System.String GetTypeName(); // 0x0724a7cc
	System.Int32 get_Id(); // 0x0724a844
	System.Void .ctor(); // 0x0724a8a8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0724a934
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0724a9e4
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0724aa94
	System.Boolean get_ShouldOpenEquipPick(); // 0x0724aaf8
	System.Int64 get_PickEquipEndTs(); // 0x0724ab6c
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x0724abe0
	System.Void RemoteCallPickEquipment(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 suiteId); // 0x0724af94
	System.Void PostInit(); // 0x0724b11c
	System.Int32 GetPlayRuleId(); // 0x0724b274
	System.Int64 GetTeamId(); // 0x0724b360
	System.Int64 GetTeamAttackerId(); // 0x0724b408
	System.Int64 GetTeamDefenderId(); // 0x0724b4f4
	System.Int32 GetCurSuitId(); // 0x0724b5e0
	System.Void PickEquipmentCallback(System.Int32 result); // 0x0724adac
	static System.Void OnShouldOpenEquipPickChanged(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Boolean oldValue, System.Boolean newValue); // 0x0724b6e4
	System.Void OpenCombatSuitPanel(); // 0x0724b874
	static System.Void .cctor(); // 0x0724b8e8
	System.Void <PostInit>b__26_0(System.Object obj); // 0x0724ba78
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerBotComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 962520672;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x0724bc68
	System.String GetTypeName(); // 0x0724bcd0
	System.Int32 get_Id(); // 0x0724bd48
	System.Void .ctor(); // 0x0724bdac
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0724be38
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0724bee8
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0724bf98
	static System.Object DeserializePlayerBotComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0724bffc
	static System.Void .cctor(); // 0x0724c0d0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerCommunityComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1054320623;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x0724c2c4
	System.String GetTypeName(); // 0x0724c32c
	System.Int32 get_Id(); // 0x0724c3a4
	System.Void .ctor(); // 0x0724c408
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0724c494
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0724c5ac
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0724c65c
	static System.Void .cctor(); // 0x0724c6c0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerConstructionComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 715434822;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x0724c77c
	System.String GetTypeName(); // 0x0724c7e4
	System.Int32 get_Id(); // 0x0724c85c
	System.Void .ctor(); // 0x0724c8c0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0724c94c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0724cc9c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0724cd4c
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.SleepingBagInfo> get_SleepingBagInfo(); // 0x0724cdb0
	System.Void set_SleepingBagInfo(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.SleepingBagInfo> value); // 0x0724ce50
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.BriefPrivilegeInfo> get_BriefBPInfo(); // 0x0724cedc
	System.Void set_BriefBPInfo(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.BriefPrivilegeInfo> value); // 0x0724cf7c
	WizardGames.Soc.Common.CustomType.CustomQueue get_Notices(); // 0x0724d008
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.MiddleStatePartsRecord> get_MiddleStateParts(); // 0x0724d0cc
	System.Void set_MiddleStateParts(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.MiddleStatePartsRecord> value); // 0x0724d16c
	WizardGames.Soc.Common.CustomType.PartLimitInfo get_WildPartLimitInfo(); // 0x0724d1f8
	WizardGames.Soc.Common.CustomType.PartLimitInfo get_PartLimitInfo(); // 0x0724d2bc
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int32> get_BlueprintCd(); // 0x0724d380
	System.Void set_BlueprintCd(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int32> value); // 0x0724d420
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int32> get_BlueprintUseNum(); // 0x0724d4ac
	System.Void set_BlueprintUseNum(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int32> value); // 0x0724d54c
	System.Int64 get_ToRecoverBlueprintReUseTimesSec(); // 0x0724d5d8
	System.Boolean get_OpenDoorAutoDirEnable(); // 0x0724d64c
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> get_EnteredDeadSheepTerritories(); // 0x0724d6c0
	System.Void set_EnteredDeadSheepTerritories(WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> value); // 0x0724d760
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int32,System.Int32> get_ConstrctionFirstOpenDic(); // 0x0724d7ec
	System.Void set_ConstrctionFirstOpenDic(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int32,System.Int32> value); // 0x0724d88c
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.CommonPosRotData> get_OfficialBpRecordInfoToGuide(); // 0x0724d918
	System.Void set_OfficialBpRecordInfoToGuide(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.CommonPosRotData> value); // 0x0724d9b8
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.ConstructionBlueprintBriefData> get_BriefDataDict(); // 0x0724da44
	System.Boolean get_BriefDataInited(); // 0x0724dae4
	System.Int32 get_LastPlacePlayerBlueprintSlot(); // 0x0724db58
	System.Int64 get_NextPlacePlayerBlueprintTimeLimit(); // 0x0724dbcc
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x0724dc40
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x0724df58
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x0724e9f0
	System.Void RemoteCallClearOfflineNotice(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x07254830
	System.Void RemoteCallMakeConnection(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 inputID, System.Int32 inputIndex, System.Int64 outputID, System.Int32 outputIndex, System.Int32 color, System.Collections.Generic.IList<System.Single> v3Lst, System.Int32 reason); // 0x0725498c
	System.Void RemoteCallRequestClear(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 entityId, System.Int32 index, System.Boolean isInput); // 0x07254b88
	System.Void RemoteCallRequestChangeWireColor(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean isInput, System.Int64 entityId, System.Int32 index, System.Int32 color, System.Int32 type); // 0x07254d44
	System.Void RemoteCallSVSwitch(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 entityId); // 0x07254f24
	System.Void RemoteCallRequestBatteryAdditionalData(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 entityId); // 0x072550ac
	System.Void RemoteCallRequestElectricalData(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 partId); // 0x07255234
	System.Void RemoteCallSetOpenDoorAutoDirEnable(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean targetValue); // 0x072553bc
	System.Void RemoteCallSetModeFirstOpenState(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 firstModeType, System.Int32 openState); // 0x07255544
	System.Void RemoteCallGenerateBlueprintData(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 toolboxId, System.Int32 slot, System.String name); // 0x072556d8
	System.Void RemoteCallRequestCreatePlayerConstructionBlueprint(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 blueprintId, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 position, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 eulerAngles, System.Collections.Generic.ISet<System.Int32> extraConditions); // 0x07255894
	System.Void RemoteCallRequestPullPlayerConstructionBlueprintBriefList(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x07255a58
	System.Void RemoteCallEnterDeadSheepTerritory(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 terrId); // 0x07255bb4
	System.Void RemoteCallReqFixComboChildren(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 partId); // 0x07255d3c
	System.Void RemoteCallQueryPartOwner(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 entityId); // 0x07255ec4
	System.Void RemoteCallCheckTeammateTerritoryCabinet(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.UInt64 teammateRoleId); // 0x0725604c
	System.Void RemoteCallAddMemberToBuildingPrivilegeGroup(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 partEntityId, System.Collections.Generic.IList<System.Int32> groupIds, System.UInt64 targetRoleId); // 0x072561d4
	System.Void RemoteCallDeleteMemberFromBuildingPrivilegeGroup(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 partEntityId, System.Int32 groupId, System.UInt64 roleId); // 0x07256390
	System.Void RemoteCallDeleteMemberCompletelyFromBuildingPrivilege(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 partEntityId, System.UInt64 roleId); // 0x0725654c
	System.Void RemoteCallAddBuildingPrivilegeAdmin(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 partEntity, System.UInt64 roleId); // 0x072566e0
	System.Void RemoteCallRemoveBuildingPrivilegeAdmin(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 entityId, System.UInt64 roleId); // 0x07256874
	System.Void RemoteCallRenameTerritory(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 partEntityId, System.String name); // 0x07256a08
	System.Void RemoteCallRenameSleepingBag(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 sleepingBagId, System.String newName); // 0x07256b9c
	System.Void RemoteCallMakeSleepingBagPublic(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 sleepingBagId, System.Boolean isPublic); // 0x07256d30
	System.Void RemoteCallGivePartOwnership(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.UInt64 toRoleId, System.Int64 entityId); // 0x07256ec4
	System.Void RemoteCallSetSleepingBagGivenPermissions(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 flag); // 0x07257058
	System.Void RemoteCallRebornPlayer(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 sleepingBagId); // 0x072571e0
	static System.Object DeserializePlayerConstructionComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07257368
	System.Void PostInit(); // 0x0725761c
	System.Void OnSleepingBagChanged(WizardGames.Soc.Share.Framework.ECustomDictOpType op, System.Int64 sleepingBagId, WizardGames.Soc.Common.CustomType.SleepingBagInfo oldVal); // 0x072579fc
	System.String GetSleepingBagDefaultName(System.Int64 sleepingBagId); // 0x07257b9c
	WizardGames.Soc.Common.CustomType.SleepingBagInfo GetSleepingBagInfo(System.Int64 entityId); // 0x07257dec
	System.Boolean IsSleepingBagUnlocked(System.Int64 entityId); // 0x07257ea4
	System.Void ReceiveElectricalData(System.Int64 partId, System.Collections.Generic.List<System.Int32> powerNow); // 0x0724f794
	System.Void ChristmasLightsConstructed(System.Int64 entityId); // 0x0724f86c
	System.Void ReceiveBatteryAddtionalData(System.Int64 partId, System.Collections.Generic.List<System.Int32> batteryData); // 0x0724f938
	System.Int32 GetModeFirstOpenState(WizardGames.Soc.Common.Data.EBuildFirstModeType firstModeType); // 0x07257fa8
	System.Int32 GetWildPartTypeCount(System.Int64 partType); // 0x072580ec
	System.Int32 GetPersonalPartTypeCount(WizardGames.Soc.Common.Data.constraction.BuildingCore partConfig); // 0x07258288
	System.Int32 GetPartTypeCount(System.Int64 partType, UnityEngine.Vector3 pos); // 0x07258394
	System.Int32 GetPartTypeLimitCount(System.Int64 partType, UnityEngine.Vector3 pos); // 0x0725865c
	System.Int32 CheckPartTypeLimit(System.Int64 partType, System.Int32 addNum, UnityEngine.Vector3 pos); // 0x0725887c
	System.Int32 CheckPartTypeLimit(System.Int64 partType, System.Int32 addNum, WizardGames.Soc.Common.Entity.TerritoryEntity terrEnt); // 0x07258a14
	System.Void ConstructionPartCountLimit(System.Int32 limitType, System.Int64 partType); // 0x0724fa68
	System.Void OnCreateComboPartOver(System.Int32 result, System.Int64 markId); // 0x0725045c
	System.Void DeployPartPlayAnimationAndEffect(System.Int64 partEntityId, System.Boolean isChangeSkin); // 0x07250518
	System.Void NotifyBuildingPrivilegeOperation(System.Int64 entityId, System.Int32 op, System.Int32 opCode); // 0x072506e8
	System.Void OnAddTerritoryInfo(System.Int64 territoryCenterId); // 0x07250a98
	System.Void OnRemoveTerritoryInfo(System.Int64 territoryCenterId); // 0x07250b4c
	System.Void OnPutInUpkeepMaterialsAck(System.Int32 result, System.Collections.Generic.List<System.Int64> fillMaxLimitList); // 0x07250c00
	System.Void OnRequestUpgradeData(System.Int64 partEntityId, System.Int32 dataVersion, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.GradeCountInfo> nonComboPartCount, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ComboPartInfo> comboPartInfo, System.Collections.Generic.Dictionary<System.Int64,System.Int32> storageBoxIngredients, System.Collections.Generic.Dictionary<System.Int64,System.Int32> territoryCabinetIngredients); // 0x07251134
	System.Void OnUpgradeDataVersionChanged(System.Int64 partEntityId, System.Int32 dataVersion); // 0x072513fc
	System.Void OnRequestUpgradeBatch(System.Int64 partEntityId, System.Int32 result, System.Int32 needSec, System.Collections.Generic.List<System.Int64> args); // 0x0725166c
	System.Void OnBatchUpgradeFinish(System.Int64 entityId, System.Boolean interrupt, System.Boolean backItemByMail); // 0x07251908
	System.Void ReceiveNotice(WizardGames.Soc.Common.CustomType.PersonalNotice notice); // 0x07251c00
	System.Void ReceiveOfflieNotice(); // 0x0725279c
	System.Void OnRenameSleepingBagCallback(System.Int32 code, System.Int64 partEntityId); // 0x07252924
	System.Void OnRenameSleepingBagGroupFailed(System.Int32 code); // 0x07252b68
	System.Void GetPartOwnershipSuccess(System.String sourceName, System.Int64 entityId); // 0x07252bdc
	System.Void OnReqTerritoryRecoverCost(System.Int64 terrId, System.Collections.Generic.Dictionary<System.Int64,System.Int32> baseCost, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.GradeCountInfo> tGrade, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.GradeCountInfo> cGrade, System.Collections.Generic.Dictionary<System.Int64,System.Int32> storageBoxIngredients, System.Collections.Generic.Dictionary<System.Int64,System.Int32> territoryCabinetIngredients); // 0x07252dec
	System.Void OnReqBatchRecover(WizardGames.Soc.Common.SimpleCustom.RecoverPartResult result); // 0x072530e4
	System.Void OnFixComboChildren(System.Int64 partId, System.Int32 code); // 0x072538a4
	System.Void QueryPartOwnerAck(System.Int64 entityId, System.UInt64 roleId); // 0x07253b78
	System.Void CheckTeammateTerritoryCabinetAck(System.UInt64 teammateRoleId, System.Int32 code); // 0x07253d1c
	System.Void RequestGenerateBlueprintData(System.Int32 slot, System.Int64 toolboxId, System.String name); // 0x07258b94
	System.Void GenerateBlueprintDataResp(System.Int32 respCode, System.Int32 slot, System.String extraInfo); // 0x07253ec0
	System.Void RequestCreatePlayerConstructionBlueprintResp(System.Int32 respCode, System.Int64 blueprintId); // 0x072544b4
	System.Void PartRenameResponse(System.Int64 entityId, System.Int32 opCode); // 0x07258e30
	static System.Void .cctor(); // 0x07259148
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerConstructionComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.PlayerConstructionComponent.<>c <>9; // 0x0
	static System.Action <>9__111_0; // 0x8
	static System.Action<WizardGames.Soc.Share.Framework.ECustomDictOpType,System.Int64,WizardGames.Soc.Common.CustomType.BriefPrivilegeInfo> <>9__111_1; // 0x10
	static System.Void .cctor(); // 0x07259648
	System.Void .ctor(); // 0x072596ac
	System.Void <PostInit>b__111_0(); // 0x07259714
	System.Void <PostInit>b__111_1(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int64 roleId, WizardGames.Soc.Common.CustomType.BriefPrivilegeInfo inviteInfo); // 0x072597b4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerDamageableComponent : WizardGames.Soc.Common.Component.DamageableComponent
{
	static System.Int32 CLASS_HASH = 37;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x07259884
	System.String GetTypeName(); // 0x072598e8
	System.Int32 get_Id(); // 0x07259960
	System.Void .ctor(); // 0x072599c4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07259a50
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07259b00
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07259bb0
	static System.Void .cctor(); // 0x07259c14
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerDataStatisticComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 34;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x07259e38
	System.String GetTypeName(); // 0x07259e9c
	System.Int32 get_Id(); // 0x07259f14
	System.Void .ctor(); // 0x07259f78
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0725a004
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0725a11c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0725a1cc
	static System.Void .cctor(); // 0x0725a230
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerDeathComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 471134832;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x0725a2e8
	System.String GetTypeName(); // 0x0725a350
	System.Int32 get_Id(); // 0x0725a3c8
	System.Void .ctor(); // 0x0725a42c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0725a4b8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0725a5b0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0725a660
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.PlayerDeathPoint> get_DeathPoints(); // 0x0725a6c4
	System.Void set_DeathPoints(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.PlayerDeathPoint> value); // 0x0725a764
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x0725a7f0
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x0725a94c
	static System.Object DeserializePlayerDeathComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0725ab90
	System.Void Init(); // 0x0725acb0
	System.Void Cleanup(); // 0x0725ae08
	static System.Void .cctor(); // 0x0725af60
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerDeathComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.PlayerDeathComponent.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.Share.Framework.ECustomDictOpType,System.Int64,WizardGames.Soc.Common.CustomType.PlayerDeathPoint> <>9__20_0; // 0x8
	static System.Action<WizardGames.Soc.Share.Framework.ECustomDictOpType,System.Int64,WizardGames.Soc.Common.CustomType.PlayerDeathPoint> <>9__21_0; // 0x10
	static System.Void .cctor(); // 0x0725b0ec
	System.Void .ctor(); // 0x0725b150
	System.Void <Init>b__20_0(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int64 id, WizardGames.Soc.Common.CustomType.PlayerDeathPoint _); // 0x0725b1b8
	System.Void <Cleanup>b__21_0(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int64 id, WizardGames.Soc.Common.CustomType.PlayerDeathPoint _); // 0x0725b28c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerDebugComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 44746348;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	WizardGames.Soc.Common.Component.NetworkTestSession <TestSession>k__BackingField; // 0x38
	System.Collections.Generic.Dictionary<System.String,System.String> consoleResultDictionary; // 0x40
	System.Byte[] tempBuffer; // 0x48
	System.Int32 GetClassHash(); // 0x0725b360
	System.String GetTypeName(); // 0x0725b3c8
	System.Int32 get_Id(); // 0x0725b440
	System.Void .ctor(); // 0x0725b4a4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0725b5b8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0725b6f0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0725b828
	System.Boolean get_NoConsumptionMode(); // 0x0725b88c
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x0725b900
	System.Void RemoteCallWorldGMEnableSwarmAI(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean enableSwarm); // 0x0725c874
	System.Void RemoteCallTestAddGraphDebugEntity(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x0725c9fc
	System.Void RemoteCallTestReloadGraphCfg(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.String fileName); // 0x0725cb58
	System.Void RemoteCallExecuteClientGm(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.String cmd); // 0x0725cce0
	System.Void RemoteCallTestSummonMonster(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 templateId, System.Int32 createCount, System.Single posX, System.Single posY, System.Single posZ); // 0x0725ce68
	System.Void RemoteCallTestSetPlayerDamageDisable(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean disable); // 0x0725d038
	System.Void RemoteCallTestSetPlayerPosition(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Single posX, System.Single posY, System.Single posZ, System.Boolean checkPosY); // 0x0725d1c0
	System.Void RemoteCallTestSetToOtherPlayerPosition(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.UInt64 roleId, System.Boolean checkPosY); // 0x0725d384
	System.Void RemoteCallTestGmRemovePartsByUserId(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x0725d518
	System.Void RemoteCallGmCompleteGuideTask(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x0725d674
	System.Void RemoteCallGmResetGuideTask(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x0725d7d0
	System.Void RemoteCallGmAcceptTask(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 taskId); // 0x0725d92c
	System.Void RemoteCallGmSwitchGuideTask(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 taskId); // 0x0725dab4
	System.Void RemoteCallGmSwitchToLastGuideTask(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x0725dc3c
	System.Void RemoteCallCompleteTask(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 taskId); // 0x0725dd98
	System.Void RemoteCallSpawnModularCarViaTableId(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 tableId, System.Single posx, System.Single posy, System.Single posz, System.Single rotx, System.Single roty, System.Single rotz); // 0x0725df20
	System.Void RemoteCallNetworkTest(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 sessionId, System.Buffers.ReadOnlySequence<System.Byte> payload); // 0x0725e114
	System.Void RemoteCallTestRpcParam(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, WizardGames.Soc.Common.CustomType.ItemCount itemCount, System.Collections.Generic.IList<System.Int64> basicTypeList, System.Collections.Generic.IDictionary<System.Int64,System.Int32> basicValueDict, System.Collections.Generic.IList<WizardGames.Soc.Common.CustomType.ItemCount> customTypeList, System.Collections.Generic.IDictionary<System.Int64,WizardGames.Soc.Common.CustomType.ItemCount> customValueDict); // 0x0725e2c8
	System.Void RemoteCallChangeUGCTriggerRegionPropertyClient(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 entityId, System.Int32 colliderType, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 scale, System.String uGCIdentityTag, System.String enterEvent, System.String exitEvent, System.String stayEvent); // 0x0725e4a4
	System.Void RemoteCallTestModifyProperty(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 entityId, System.Int32 propId, System.Single amount); // 0x0725e694
	System.Void RemoteCallNetworkTest2(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 sessionId, System.Buffers.ReadOnlySequence<System.Byte> payload); // 0x0725e840
	System.Void RemoteCallGmLagCompensationToggle(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean toggle); // 0x0725e9f4
	System.Void RemoteCallDebugCheatCreateTheEntityHasCount(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 playerId, System.Int32 entityType, System.Int32 templateId, System.Int32 amount, System.Single distance); // 0x0725eb7c
	System.Void RemoteCallTestOverrideCCMoveSpeed(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 entityId, System.Single targetSpeed); // 0x0725ed5c
	System.Void RemoteCallTestMoveComfort(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 entityId, System.Single targetComfort); // 0x0725eefc
	System.Void RemoteCallTestSwitchDamageDebug(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean isOpen); // 0x0725f09c
	System.Void RemoteCallTestAddTemperTrigger(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 entityId, System.Single temperature); // 0x0725f224
	System.Void RemoteCallTestSetPlayerObserver(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 playerId, System.Boolean bObserver); // 0x0725f3c4
	WizardGames.Soc.Common.Component.NetworkTestSession get_TestSession(); // 0x0725f558
	System.Void set_TestSession(WizardGames.Soc.Common.Component.NetworkTestSession value); // 0x0725f5bc
	System.Void ReceiveConsoleMsg(System.String cmd, System.String ret); // 0x0725bf64
	System.Void StartNewNetworkTestSession(System.Int32 targetKBytesPerSecond, System.Int32 duration, System.Boolean toSimulator); // 0x0725f63c
	System.Void OnTimerCheckNetworkSend(System.Int64 _); // 0x0725f920
	System.Void NetworkTestCallback(System.Int32 sessionId, System.Buffers.ReadOnlySequence<System.Byte> payload); // 0x0725c00c
	System.Void NetworkTestError(); // 0x07260228
	System.Void TestRpcParamAck(WizardGames.Soc.Common.CustomType.ItemCount itemCount, WizardGames.Soc.Share.Framework.BasicTypeList<System.Int64> basicTypeList, WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int32> basicValueDict, WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.ItemCount> customTypeList, WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.ItemCount> customValueDict); // 0x0725c634
	static System.Void .cctor(); // 0x072603a8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerDropGatherComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 365158121;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x07260464
	System.String GetTypeName(); // 0x072604cc
	System.Int32 get_Id(); // 0x07260544
	System.Void .ctor(); // 0x072605a8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07260634
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072606e4
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07260794
	static System.Object DeserializePlayerDropGatherComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072607f8
	static System.Void .cctor(); // 0x072608d0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerFriendComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1443401591;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072609f4
	System.String GetTypeName(); // 0x07260a5c
	System.Int32 get_Id(); // 0x07260ad4
	System.Void .ctor(); // 0x07260b38
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07260bc4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07260cfc
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07260dac
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.UInt64,WizardGames.Soc.Common.CustomType.RecentFriend> get_TemporaryFriends(); // 0x07260e10
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.UInt64,WizardGames.Soc.Common.CustomType.EncounteredPlayer> get_EncounteredPlayers(); // 0x07260eb0
	System.Void set_EncounteredPlayers(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.UInt64,WizardGames.Soc.Common.CustomType.EncounteredPlayer> value); // 0x07260f50
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x07260fdc
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x072611b0
	static System.Object DeserializePlayerFriendComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072613f8
	static System.Void .cctor(); // 0x0726154c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerInventoryComponent : WizardGames.Soc.Share.Framework.ComponentBase, WizardGames.Soc.SocClient.Manager.IObserverUse
{
	static System.Int32 CLASS_HASH = 272582786;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x07261670
	System.String GetTypeName(); // 0x072616d8
	System.Int32 get_Id(); // 0x07261750
	System.Void .ctor(); // 0x072617b4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07261840
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072619fc
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07261aac
	WizardGames.Soc.Common.CustomType.PlayerInventoryRootNode get_SystemRoot(); // 0x07261b10
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> get_HasEnterInventoryItems(); // 0x07261bd4
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.BaseItemNode> get_DropItems(); // 0x07261c74
	System.Void set_DropItems(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.BaseItemNode> value); // 0x07261d14
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.BaseItemNode> get_ProtectedItems(); // 0x07261da0
	System.Void set_ProtectedItems(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.BaseItemNode> value); // 0x07261e40
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x07261ecc
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x07262034
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x07262374
	System.Void RemoteCallClientInterruptReload(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x07264744
	System.Void RemoteCallMoveItemToPath(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int64> srcPath, System.Collections.Generic.IList<System.Int64> targetPath); // 0x072648a0
	System.Void RemoteCallMoveItemToPathWithConfirm(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int64> srcPath, System.Collections.Generic.IList<System.Int64> targetPath); // 0x07264a34
	System.Void RemoteCallExchangeItem(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int64> srcPath, System.Collections.Generic.IList<System.Int64> targetPath); // 0x07264bc8
	System.Void RemoteCallSplitItem(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int64> srcPath, System.Boolean toMine, System.Int32 amount); // 0x07264d5c
	System.Void RemoteCallSplitItemToPath(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int64> srcPath, System.Collections.Generic.IList<System.Int64> dstPath, System.Int32 amount); // 0x07264f18
	System.Void RemoteCallSortInventory(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x072650d4
	System.Void RemoteCallDropItem(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int64> itemPath, System.Int32 count); // 0x07265230
	System.Void RemoteCallDropItemWithConfirm(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int64> itemPath, System.Int32 count); // 0x072653c4
	System.Void RemoteCallPourWater(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 itemId, System.Single velocityX, System.Single velocityY, System.Single velocityZ); // 0x07265558
	System.Void RemoteCallUnloadBullet(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 itemUid); // 0x0726571c
	System.Void RemoteCallForceMoveExtraPack(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int64> srcPath, System.Collections.Generic.IList<System.Int64> targetPath); // 0x072658a4
	System.Void RemoteCallTransferItemBetweenContainers(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 bizId, System.Int32 maxCount, System.Collections.Generic.IList<System.Int64> srcPath, System.Collections.Generic.IList<System.Int64> targetPath); // 0x07265a38
	System.Void RemoteCallTryTransferItemBetweenContainers(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 bizId, System.Int32 maxCount, System.Collections.Generic.IList<System.Int64> srcPath, System.Collections.Generic.IList<System.Int64> targetPath, System.Boolean withConfirm); // 0x07265bfc
	System.Void RemoteCallTakeOffCloth(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 itemUid); // 0x07265de0
	System.Void RemoteCallPartDrinkWater(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 partId, System.Int32 idx); // 0x07265f68
	System.Void RemoteCallUseItem(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 entityId, System.Int64 itemUid, System.Int32 count); // 0x072660fc
	System.Void RemoteCallOpenPackage(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 itemUid, System.Int32 selectDropId); // 0x072662b8
	System.Void RemoteCallRechargeItem(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 itemUid); // 0x0726644c
	System.Void RemoteCallUpdateEnterInventoryItems(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int64> items); // 0x072665d4
	System.Void RemoteCallChangeItemSkin(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 itemUId, System.Int64 skinUId); // 0x0726675c
	System.Void RemoteCallSetItemFrequency(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 itemId, System.Int32 freq); // 0x072668f0
	System.Void RemoteCallSetDetonationMode(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 heldItemId, System.Boolean isRFDetonation); // 0x07266a84
	System.Void RemoteCallFrequencyAssiciate(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int64> assiciateIdList, System.Int64 itemId); // 0x07266c18
	System.Void RemoteCallCancelFrequencyAssiciate(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int64> itemIdList, System.Int64 cancelItemId); // 0x07266dac
	System.Void RemoteCallMoveItemAround(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int64> srcPath, System.Collections.Generic.IList<System.Int64> dstPath, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 cameraPos, System.Single yaw, System.Single pitch); // 0x07266f40
	System.Void RemoteCallSplitItemAround(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int64> srcPath, System.Collections.Generic.IList<System.Int64> dstPath, System.Int32 amount, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 cameraPos, System.Single yaw, System.Single pitch); // 0x07267120
	static System.Object DeserializePlayerInventoryComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07267308
	WizardGames.Soc.Common.Entity.PlayerEntity get_Player(); // 0x07267440
	WizardGames.Soc.Common.Component.RootNodeComponent get_Root(); // 0x07247430
	WizardGames.Soc.Common.Component.PlayerLootingComponent get_LootingComp(); // 0x072674f8
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_ContainerMainNode(); // 0x07267584
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_ContainerBeltNode(); // 0x072474bc
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_ContainerWearNode(); // 0x072676dc
	WizardGames.Soc.Common.CustomType.Alpha3ContainerClient get_ContainerMain(); // 0x07267744
	WizardGames.Soc.Common.CustomType.Alpha3ContainerClient get_ContainerBelt(); // 0x072677f0
	WizardGames.Soc.Common.CustomType.Alpha3ContainerClient get_ContainerWear(); // 0x0726789c
	System.Void Init(); // 0x07267948
	System.Void SubscribeEvents(); // 0x07267b00
	System.Void UnSubscribeEvents(); // 0x07267d8c
	System.Void OnMainNodeUpdate(); // 0x07268018
	System.Void OnBeltNodeUpdate(); // 0x072680b8
	System.Void OnWearNodeUpdate(); // 0x07268158
	System.Void OnRootNodesUpdate(); // 0x072681f8
	System.Void AttachObserver(); // 0x072682dc
	System.Void DetachObserver(); // 0x07268384
	System.Void OnMyWearChange(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int64 key, System.Int64 value); // 0x072683e8
	System.Void PostInit(); // 0x07268510
	System.Void OnNormalStoreRootNodesUpdate(WizardGames.Soc.Share.Framework.ECustomDictOpType opt, System.Int64 id, WizardGames.Soc.Common.CustomType.NodeBase oldVal); // 0x072685a4
	WizardGames.Soc.Common.CustomType.ItemContainerNode GetInventoryContainerNode(System.Int32 id); // 0x072675ec
	WizardGames.Soc.Common.CustomType.ItemContainerNode GetLootContainerNode(System.Int32 id); // 0x07268830
	System.Int32 GetAmount(System.Int64 cfgID); // 0x07268b5c
	System.Void ForeachItemInMain(System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> process); // 0x07268c34
	static System.Boolean IterOneContainer(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap cc, System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> process); // 0x07268cf8
	System.Void ForeachItem(System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> process); // 0x07269100
	WizardGames.Soc.Common.CustomType.ItemContainerNode GetVehicleStorageContainer(System.Int32 id); // 0x07268a80
	WizardGames.Soc.Common.CustomType.ItemContainerNode GetNotFullVehicleStorageContainer(); // 0x072693e0
	System.Int32 GetVehicleStorageContainerIndex(); // 0x07269224
	System.Void DropExtraPackAck(System.Collections.Generic.List<System.Int64> itemPath, System.Int32 code, System.Collections.Generic.Dictionary<System.Int64,System.Int32> oversizeItems); // 0x07262a58
	System.Void MoveExtraPackAck(System.Collections.Generic.List<System.Int64> srcPath, System.Collections.Generic.List<System.Int64> tarPath, System.Int32 code, System.Collections.Generic.Dictionary<System.Int64,System.Int32> oversizeItems); // 0x07262b30
	System.Void NewItemTips(System.Int64 bizId); // 0x07262d30
	System.Void ChangeSkinResult(System.Int32 mode); // 0x07263040
	System.Void MoveItemToPathAck(System.Collections.Generic.List<System.Int64> srcPath, System.Collections.Generic.List<System.Int64> tarPath, System.Int32 result); // 0x07263184
	System.Void StartInventoryReload(System.Int64 bulletId, System.Int64 weaponId, System.Int32 reloadTime); // 0x07263714
	System.Void ExchangeItemAck(System.Collections.Generic.List<System.Int64> srcPath, System.Collections.Generic.List<System.Int64> tarPath, System.Int32 result); // 0x072638a0
	System.Void InterruptInventoryReload(System.Int64 bulletId, System.Int64 weaponId); // 0x07263a14
	System.Void PickCollectable(System.Int64 entityId); // 0x07263ce4
	System.Void TryTransferTargetContainerFull(System.Collections.Generic.List<System.Int64> srcPath, System.Int32 maxCount); // 0x07263ee4
	System.Void EmptyRpc(); // 0x07264160
	System.Void OpenPackageAck(System.Int32 opCode); // 0x072641c0
	System.Void Cleanup(); // 0x07269640
	System.Void TransferItemBetweenContainersAck(System.Int64 bizId, System.Int32 count, System.Collections.Generic.List<System.Int64> srcPath, System.Collections.Generic.List<System.Int64> targetPath); // 0x07264310
	static System.Void .cctor(); // 0x072696e0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerInventoryComponent.<>c__DisplayClass106_0 : System.Object
{
	WizardGames.Soc.Common.Component.PlayerInventoryComponent <>4__this; // 0x10
	System.Collections.Generic.List<System.Int64> srcPath; // 0x18
	System.Int32 maxCount; // 0x20
	System.Void .ctor(); // 0x072695d8
	System.Void <TryTransferTargetContainerFull>b__0(); // 0x072698a0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerKOLComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 2032667680;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.UInt64 serverOwnerRoleId; // 0x38
	System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.Common.SimpleCustom.KOLPlayerInfo> playerInfoCache; // 0x40
	System.Int64 updateTime; // 0x48
	System.Int32 GetClassHash(); // 0x072699f4
	System.String GetTypeName(); // 0x07269a5c
	System.Int32 get_Id(); // 0x07269ad4
	System.Void .ctor(); // 0x07269b38
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07269bc4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07269c74
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07269d24
	System.Boolean get_IsServerOwner(); // 0x07269d88
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x07269dfc
	System.Void RemoteCallQueryPlayer(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x0726a618
	System.Void RemoteCallUpdatePlayerState(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.UInt64 targetRoleId, System.Boolean useMark, System.Byte newMark); // 0x0726a774
	System.Void RemoteCallSetPlayerDamageDisable(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean disable); // 0x0726a930
	System.Void RemoteCallSummonMonster(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 templateId, System.Int32 createCount, System.Single posX, System.Single posY, System.Single posZ); // 0x0726aab8
	System.Void RemoteCallSpawnVehicle(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 templateId, WizardGames.Soc.Common.CustomType.CustomVector3 pos, WizardGames.Soc.Common.CustomType.CustomVector3 rot); // 0x0726ac88
	System.Void RemoteCallSpawnModularCar(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 tableId, System.Single posX, System.Single posY, System.Single posZ, System.Single rotX, System.Single rotY, System.Single rotZ); // 0x0726ae44
	System.Void RemoteCallAddItem(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 bizId, System.Int32 count); // 0x0726b038
	System.Void RemoteCallAddItems(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int64> itemsToAdd); // 0x0726b1cc
	System.Void RemoteCallClearInventory(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x0726b354
	System.Void RemoteCallEquipExtraBackpack(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean enable); // 0x0726b4b0
	System.Void RemoteCallSetPlayerPosition(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Single posX, System.Single posY, System.Single posZ, System.Boolean checkPosY); // 0x0726b638
	System.Void Cleanup(); // 0x0726b7fc
	System.Boolean CheckRefreshCD(System.Int32& time); // 0x0726b98c
	System.Void QueryPlayerList(); // 0x0726ba7c
	System.Void OnQueryPlayerAck(System.UInt64 serverOwner, System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.Common.SimpleCustom.KOLPlayerInfo> playerInfoDict); // 0x0726a124
	System.Void OnPlayerInfoSyncDone(); // 0x0726bb7c
	System.Void SetAdmin(System.UInt64 targetRoleId, System.Boolean isSet); // 0x0726bc34
	System.Void SetDisableChat(System.UInt64 targetRoleId, System.Boolean isSet); // 0x0726bcc4
	System.Void SetDisableLogin(System.UInt64 targetRoleId, System.Boolean isSet); // 0x0726bd54
	System.Void UpdatePlayerStateAck(System.Boolean useMark, System.Byte newMark, System.Boolean isSuc, System.UInt64 targetRoleId, System.Byte targetPlayerState); // 0x0726a218
	System.Void OnSendItemsAck(System.Int32 code); // 0x0726a4c4
	static System.Void .cctor(); // 0x0726bde4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerLootingComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1843194433;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x0726bea0
	System.String GetTypeName(); // 0x0726bf08
	System.Int32 get_Id(); // 0x0726bf80
	System.Void .ctor(); // 0x0726bfe4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0726c070
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0726c120
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0726c1d0
	System.Int64 get_LootingEntityId(); // 0x07268a0c
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x0726c234
	System.Void RemoteCallStopLooting(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x0726d2c4
	System.Void Init(); // 0x0726d420
	System.Void PostInit(); // 0x0726d488
	System.Void StartLootingAck(System.Int64 entityId, System.Int32 code); // 0x0726c5e8
	System.Void StopLootingAck(System.Int64 entityId, System.Int32 code); // 0x0726c828
	System.Void SwitchLootingAck(System.Int64 entityId, System.Collections.Generic.List<System.Int64> entityIds, System.Int32 code); // 0x0726ca00
	System.Void QuickMergeAck(System.Int64 entityId, System.Int32 code); // 0x0726cc94
	System.Void QuickRequireAck(System.Int64 entityId, System.Int32 code); // 0x0726cfac
	System.Void DealWithAckCode(System.Int32 code); // 0x0726d5e8
	System.Void StopLooting(); // 0x0726d888
	System.Void OnLootCollectionChanged(); // 0x0726d570
	System.Void OnLootCollectionChanged(WizardGames.Soc.Share.Framework.CustomTypeBase _, System.Int64 oldValue, System.Int64 newValue); // 0x0726d974
	System.Void OnLootCollectionCreated(WizardGames.Soc.Common.Component.RootNodeComponent lootRoot); // 0x0726dd30
	static System.Void .cctor(); // 0x0726dde4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerMailComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 313245718;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x0726dea0
	System.String GetTypeName(); // 0x0726df08
	System.Int32 get_Id(); // 0x0726df80
	System.Void .ctor(); // 0x0726dfe4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0726e070
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0726e188
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0726e238
	WizardGames.Soc.Common.CustomType.MailRootNode get_Mails(); // 0x0726e29c
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x0726e360
	System.Void RemoteCallRefreshExpiredMail(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x0726f9a4
	System.Void RemoteCallReadMail(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 mailId); // 0x0726fb00
	System.Void RemoteCallDeleteMail(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 mailId); // 0x0726fc88
	System.Void RemoteCallReceivedAttachment(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 mailId); // 0x0726fe10
	System.Void RemoteCallReadAllMail(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x0726ff98
	System.Void RemoteCallDeleteAllReadMail(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x072700f4
	System.Void RemoteCallReceivedAllAttachment(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x07270250
	static System.Object DeserializePlayerMailComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072703ac
	WizardGames.Soc.Common.Entity.PlayerEntity get_Player(); // 0x07270480
	WizardGames.Soc.Common.Component.RootNodeComponent get_Root(); // 0x07270538
	System.Void Init(); // 0x072705c4
	System.Void PostInit(); // 0x0727062c
	System.Void Cleanup(); // 0x07270760
	System.Void OnMailChange(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int64 mailId, WizardGames.Soc.Common.CustomType.NodeBase oldVal); // 0x072707c8
	System.Void OnRefreshExpiredMailAck(); // 0x0726e788
	System.Void OnReadMailAck(System.Int64 mailId, System.Int32 result); // 0x0726e854
	System.Void OnDeleteMailAck(System.Int64 mailId, System.Int32 result); // 0x0726e9f0
	System.Void OnReceivedAttachmentAck(System.Int64 mailId, System.Int32 result); // 0x0726eb48
	System.Void OnReadAllMailAck(System.Collections.Generic.List<System.Int64> mailIds, System.Int32 result); // 0x0726ee9c
	System.Void OnDeleteAllMailAck(System.Collections.Generic.List<System.Int64> mailIds, System.Int32 result); // 0x0726f21c
	System.Void OnReceivedAllAttachmentAck(System.Collections.Generic.List<System.Int64> mailIds, System.Int32 result); // 0x0726f55c
	static System.Void .cctor(); // 0x07270a44
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerMarkComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 9598302;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x0729635c
	System.String GetTypeName(); // 0x072963c4
	System.Int32 get_Id(); // 0x0729643c
	System.Void .ctor(); // 0x072964a0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0729652c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07296624
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072966d4
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.MarkerBase> get_MarkerDict(); // 0x07296738
	System.Void set_MarkerDict(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.MarkerBase> value); // 0x072967d8
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x07296864
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x072969c0
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x07296c04
	System.Void RemoteCallAddCombatMarkerFollowPosition(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 templateId, System.Single x, System.Single y, System.Single z, System.Boolean soundAndAnim); // 0x072971d4
	System.Void RemoteCallRemoveCombatMarker(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 markerSeq); // 0x072973a4
	System.Void RemoteCallAddCombatMarkerFollowEntity(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 templateId, System.Int64 entityId, System.Boolean soundAndAnim); // 0x0729752c
	System.Void RemoteCallConfirmTeamCombatMarker(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 markerId); // 0x072976e8
	System.Void RemoteCallCancelConfirmTeamCombatMarker(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 markerId); // 0x07297870
	System.Void RemoteCallQueryMyPartEntity(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 seq, System.Int32 templateId); // 0x072979f8
	static System.Object DeserializePlayerMarkComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07297b8c
	System.Void PostInit(); // 0x07297cac
	System.Void Cleanup(); // 0x07297dd0
	System.Void OnAddCombatMarker(System.Int64 markerId, System.Int64 afterSeq); // 0x07296ec4
	System.Void OnModifyCombatMarker(System.Int64 markerId); // 0x07296f9c
	System.Void OnQueryMyPartEntity(System.Int64 seq, System.Boolean isFound, System.Int64 entityId, System.Int64 snapSequence); // 0x07297010
	static System.Void .cctor(); // 0x07297ef4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerMiscComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1853076051;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x07297fe4
	System.String GetTypeName(); // 0x0729804c
	System.Int32 get_Id(); // 0x072980c4
	System.Void .ctor(); // 0x07298128
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072981b4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07298264
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07298314
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x07298378
	System.Void RemoteCallSearchNearestJunkpile(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 taskId, System.Int32 searchId); // 0x0729a668
	System.Void RemoteCallSearchNearestDeaSheepTerritoryCabinet(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 taskId, System.Int32 searchId); // 0x0729a7fc
	System.Void RemoteCallSearchPlayer(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.String searchName, System.Boolean containsNotOnline); // 0x0729a990
	System.Void RemoteCallGasStationCallSoldiers(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 interativeEntityId); // 0x0729ab24
	System.Void RemoteCallGetCosReportTempCredential(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x0729acac
	static System.Object DeserializePlayerMiscComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0729ae08
	System.Void Init(); // 0x0729aedc
	System.Void PostInit(); // 0x0729af44
	System.Void Cleanup(); // 0x0729afac
	System.Void OnSearchNearestJunkpile(System.Int64 seq, System.Boolean find, System.Int64 junkpileEntityId); // 0x07298a9c
	System.Void OnSearchNearestDeaSheepTerritoryCabinet(System.Int64 seq, System.Boolean find, System.Int64 territoryCabinetEntityId); // 0x07298c40
	System.Void NotifyBeeBuzzPlayerEvent(WizardGames.Soc.Common.SimpleCustom.BeeBuzzPlayerEvent eventData); // 0x07298de4
	System.Void NotifyGunshipEvent(WizardGames.Soc.Common.SimpleCustom.GunshipEvent eventData); // 0x07298f30
	System.Void SearchPlayerAck(System.Int32 code, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.SearchPlayerInfo> searchPlayerInfos); // 0x072992fc
	System.Void GasStationCallSoldiersResponse(System.Int32 result, System.Int64 interativeEntityId); // 0x072993ec
	System.Void StartPlayBoxGame(System.Int64 boxEntityId); // 0x07299744
	System.Void HitUnlockAngleAck(System.Int64 boxEntityId, System.Boolean isCompleted, System.Int32 opCode); // 0x07299980
	System.Void DebrisPickUpAck(System.Int64 debrisEntityId, System.Int32 opCode); // 0x07299ce8
	System.Void DebrisRepairAck(System.Int64 debrisEntityId, System.Int32 opCode, System.Int64 param); // 0x07299ffc
	System.Void GetCosReportTempCredentialAck(System.Int32 opCode, System.String url, System.String token, System.String tmpSecretId, System.String tmpSecretKey, System.String filePath); // 0x0729a3f4
	System.Void RenameVendingMachineAck(System.Int32 result, System.Int64 vendingMachineEntityId); // 0x0729b014
	static System.Void .cctor(); // 0x0729b298
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerPickUpComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1756857337;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x0729b3f0
	System.String GetTypeName(); // 0x0729b458
	System.Int32 get_Id(); // 0x0729b4d0
	System.Void .ctor(); // 0x0729b534
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0729b5c0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0729b670
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0729b720
	System.Void RemoteCallReportNearbyEntities(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.ISet<System.Int64> entityIds); // 0x0729b784
	static System.Void .cctor(); // 0x0729b90c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerPlunderComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 127276024;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	LZ4Sharp.LZ4Decompressor64 lz4Decompressor; // 0x38
	System.Int32 GetClassHash(); // 0x0729b9c8
	System.String GetTypeName(); // 0x0729ba30
	System.Int32 get_Id(); // 0x0729baa8
	System.Void .ctor(); // 0x0729bb0c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0729bbd0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0729bd54
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0729be3c
	WizardGames.Soc.Common.CustomType.CustomQueue get_AttackQueue(); // 0x0729bea0
	WizardGames.Soc.Common.CustomType.CustomQueue get_DefendQueue(); // 0x0729bf64
	System.Int64 get_AttackerReportId(); // 0x0729c028
	System.Int64 get_DefenderReportId(); // 0x0729c09c
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x0729c110
	System.Void RemoteCallReqResetTopPlunderReport(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x0729d098
	System.Void RemoteCallReqPlunderReport(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 reportId); // 0x0729d1f4
	System.Void RemoteCallSharePlunderReport(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 reportId, System.Boolean isAttackReport); // 0x0729d37c
	System.Void RemoteCallGetPlunderReport(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 reportId, System.String battleServerId); // 0x0729d510
	System.Void PlunderShouldGoBackDefence(System.Int64 terrId, WizardGames.Soc.Common.SimpleCustom.SimpleVector3 pos); // 0x0729c450
	System.Void ReqPlunderReportAck(System.Int64 reportId, WizardGames.Soc.Share.Framework.ReadonlyBytes reportBytes); // 0x0729c80c
	System.Void GetPlunderReportAck(System.Int64 reportId, System.Int32 code, WizardGames.Soc.Share.Framework.ReadonlyBytes reportBytes); // 0x0729cba8
	System.Void SharePlunderReportAck(System.Int32 code); // 0x0729cf4c
	WizardGames.Soc.Common.CustomType.PlunderReport CreateReport(System.Int64 reportId, WizardGames.Soc.Share.Framework.ReadonlyBytes reportBytes); // 0x0729d774
	WizardGames.Soc.Common.CustomType.PlunderReportData DecompressReportData(System.Int64 reportId, WizardGames.Soc.Share.Framework.ReadonlyBytes readonlyBytes); // 0x0729d8c8
	static System.Void .cctor(); // 0x0729e1e4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerPlunderComponent.<>c__DisplayClass34_0 : System.Object
{
	System.Int64 terrId; // 0x10
	WizardGames.Soc.Common.Component.PlayerPlunderComponent <>4__this; // 0x18
	System.Action<WizardGames.Soc.SocClient.Ui.UiMainMap> <>9__1; // 0x20
	System.Void .ctor(); // 0x0729d6a4
	System.Void <PlunderShouldGoBackDefence>b__0(); // 0x0729e33c
	System.Void <PlunderShouldGoBackDefence>b__1(WizardGames.Soc.SocClient.Ui.UiMainMap win); // 0x0729e488
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerPlunderComponent.<>c__DisplayClass35_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.PlunderReport report; // 0x10
	System.Void .ctor(); // 0x0729d70c
	System.Void <ReqPlunderReportAck>b__0(WizardGames.Soc.SocClient.Ui.UiBattleReport win); // 0x0729e640
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerPlunderComponent.<>c__DisplayClass36_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.PlunderReport report; // 0x10
	System.Void .ctor(); // 0x0729d860
	System.Void <GetPlunderReportAck>b__0(WizardGames.Soc.SocClient.Ui.UiBattleReport win); // 0x0729e6c8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerSafeOfflineComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1527580787;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x0729e750
	System.String GetTypeName(); // 0x0729e7b8
	System.Int32 get_Id(); // 0x0729e830
	System.Void .ctor(); // 0x0729e894
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0729e920
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0729e9d0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0729ea80
	System.UInt32 get_TodayRemainingSafeTime(); // 0x0729eae4
	System.Int64 get_CampingTentEntityId(); // 0x0729eb58
	System.Int64 get_LastStartTime(); // 0x0729ebcc
	System.Int64 get_LastEndTime(); // 0x0729ec40
	System.UInt32 get_CampingTentValidTime(); // 0x0729ecb4
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x0729ed28
	System.Void RemoteCallStartPutCampingTent(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x0729f040
	System.Void CheckPutCampingTentIntervalAck(System.Int32 result); // 0x0729eef4
	static System.Void .cctor(); // 0x0729f19c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerSeedBackpackComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1406460907;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x0729f328
	System.String GetTypeName(); // 0x0729f390
	System.Int32 get_Id(); // 0x0729f408
	System.Void .ctor(); // 0x0729f46c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0729f4f8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0729f610
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0729f6c0
	WizardGames.Soc.Common.CustomType.SeedBackpackRootNode get_SystemRoot(); // 0x0729f724
	WizardGames.Soc.Common.Entity.PlayerEntity get_Player(); // 0x0729f7e8
	WizardGames.Soc.Common.Component.RootNodeComponent get_Root(); // 0x0729f8a0
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_ContainerSeedNode(); // 0x0729f92c
	WizardGames.Soc.Common.CustomType.Alpha3ContainerClient get_ContainerSeed(); // 0x0729fa84
	System.Void Init(); // 0x0729fb30
	System.Void PostInit(); // 0x0729fc74
	System.Void Cleanup(); // 0x072a0268
	WizardGames.Soc.Common.CustomType.ItemContainerNode GetContainerNode(System.Int64 id); // 0x0729f994
	static System.Boolean IterOneContainer(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap cc, System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> process); // 0x072a06cc
	System.Void ForeachItem(System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> process); // 0x072a0ad4
	static System.Void .cctor(); // 0x072a0b98
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerSeedBackpackComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.PlayerSeedBackpackComponent.<>c <>9; // 0x0
	static System.Action <>9__25_0; // 0x8
	static System.Void .cctor(); // 0x072a0c54
	System.Void .ctor(); // 0x072a0cb8
	System.Void <Init>b__25_0(); // 0x072a0d20
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerShopComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1270469708;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072a0dc0
	System.String GetTypeName(); // 0x072a0e28
	System.Int32 get_Id(); // 0x072a0ea0
	System.Void .ctor(); // 0x072a0f04
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072a0f90
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072a1040
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072a10f0
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x072a1154
	System.Void RemoteCallStartShopping(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 entityId); // 0x072a18b4
	System.Void RemoteCallStopShopping(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x072a1a3c
	System.Void RemoteCallBuy(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 shopEntityId, System.Int32 shopItemId, System.Int32 count); // 0x072a1b98
	System.Void StartShoppingAck(System.Int64 shopEntityId); // 0x072a13a4
	System.Void BuyAck(System.Int64 shopEntityId, System.Int32 shopItemId, System.Int32 result); // 0x072a14ec
	static System.Void .cctor(); // 0x072a1e0c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerSkinComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 683219466;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.HashSet<System.Int64>> ItemId2SkinIds; // 0x38
	System.Int32 GetClassHash(); // 0x072a1ec8
	System.String GetTypeName(); // 0x072a1f30
	System.Int32 get_Id(); // 0x072a1fa8
	System.Void .ctor(); // 0x072a200c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072a20e4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072a22e8
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072a23e4
	WizardGames.Soc.Common.CustomType.SkinRootNode get_SystemRoot(); // 0x072a2448
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> get_Costumes(); // 0x072a250c
	System.Void set_Costumes(WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> value); // 0x072a25ac
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int32,System.Boolean> get_CostumeOptions(); // 0x072a2638
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int64> get_GunBuddies(); // 0x072a26d8
	System.Void set_GunBuddies(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int64> value); // 0x072a2778
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int32> get_SkinIdToLevel(); // 0x072a2804
	System.Void set_SkinIdToLevel(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int32> value); // 0x072a28a4
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x072a2930
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x072a2dcc
	System.Void RemoteCallSetDefaultItemSkinId(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 itemId, System.Int64 skinId); // 0x072a3270
	System.Void RemoteCallStarSkin(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 skinNodeId); // 0x072a3404
	System.Void RemoteCallUnStarSkin(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 skinNodeId); // 0x072a358c
	System.Void RemoteCallOverrideCostumePlan(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.ISet<System.Int64> costumePlan, System.Int32 gender); // 0x072a3714
	System.Void RemoteCallOverrideCostumeOptions(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IDictionary<System.Int32,System.Boolean> costumeOptions); // 0x072a38a8
	static System.Object DeserializePlayerSkinComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072a3a30
	WizardGames.Soc.Common.Entity.PlayerEntity get_Player(); // 0x072a3cc8
	WizardGames.Soc.Common.Component.RootNodeComponent get_Root(); // 0x072a3d80
	System.Void Init(); // 0x072a3e0c
	System.Void PostInit(); // 0x072a3e74
	System.Void CostumesChange(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, WizardGames.Soc.Share.Framework.TypeBase oldValue, WizardGames.Soc.Share.Framework.TypeBase newValue); // 0x072a46b0
	System.Void ForceUpdateEquip(); // 0x072a459c
	System.Void OnSoftReconnectSuc(WizardGames.Soc.Share.Framework.SoftReconnectSuc evt); // 0x072a47f8
	System.Void InitItemSkinCache(); // 0x072a41f0
	System.Void OnSkinNodeChange(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int64 key, WizardGames.Soc.Common.CustomType.NodeBase oldVal); // 0x072a4ad0
	System.Void AddSkinNode(WizardGames.Soc.Common.CustomType.SkinNode skinNode); // 0x072a48a4
	System.Void RemoveSkinNode(WizardGames.Soc.Common.CustomType.SkinNode skinNode); // 0x072a4cc0
	System.Int64 GetSkinOwnId(System.Int64 skinId); // 0x072a5014
	System.Int64 GetDefaultSkinByItemId(System.Int64 itemId); // 0x072a51f0
	System.Void StarSkinAck(System.Int64 skinNodeId); // 0x072a2fd8
	System.Void UnStarSkinAck(System.Int64 skinNodeId); // 0x072a3124
	WizardGames.Soc.Common.CustomType.SkinNode GetSkin(System.Int64 skinId); // 0x072a5848
	WizardGames.Soc.Common.CustomType.BaseItemNode GetWearItemNodeByItemId(System.Int64 itemId); // 0x072a5c00
	WizardGames.Soc.Common.CustomType.BaseItemNode GetItemNodeByItemId(System.Int64 itemId, WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap node); // 0x072a5cc0
	static System.Void .cctor(); // 0x072a5e74
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerTaskComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1325313153;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072a6138
	System.String GetTypeName(); // 0x072a61a0
	System.Int32 get_Id(); // 0x072a6218
	System.Void .ctor(); // 0x072a627c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072a6308
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072a6454
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072a6504
	WizardGames.Soc.Common.CustomType.PlayerTaskRootNode get_SystemRoot(); // 0x072a6568
	System.Int64 get_TrackTaskId(); // 0x072a662c
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int32,System.Int32> get_Guide2Count(); // 0x072a66a0
	System.Void set_Guide2Count(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int32,System.Int32> value); // 0x072a6740
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x072a67cc
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x072a6a14
	System.Void RemoteCallClientTrigger(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 triggerId); // 0x072a8afc
	System.Void RemoteCallCompleteGuide(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 guideId); // 0x072a8c84
	System.Void RemoteCallClientTrackTask(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 taskId); // 0x072a8e0c
	System.Void RemoteCallCancelTrackTask(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 taskId); // 0x072a8f94
	System.Void RemoteCallGetExploreTaskReward(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 taskId); // 0x072a911c
	System.Void RemoteCallGetStoryTaskReward(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 taskId); // 0x072a92a4
	System.Void RemoteCallResetPlayerStatusByTask(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 statusId); // 0x072a942c
	System.Void RemoteCallRefreshSinglePoiTask(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 taskId); // 0x072a95b4
	System.Void RemoteCallAcceptPoiTask(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 taskId); // 0x072a973c
	System.Void RemoteCallSubmitPoiTask(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 taskId); // 0x072a98c4
	System.Void RemoteCallAbandonPoiTask(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 taskId); // 0x072a9a4c
	System.Void RemoteCallGetBeeBuzzTaskReward(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 taskId); // 0x072a9bd4
	System.Void RemoteCallSummonPoiTaskTrap(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x072a9d5c
	System.Void RemoteCallGetDailyTaskReward(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 taskId); // 0x072a9eb8
	System.Void RemoteCallGetLobbyMainTaskReward(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 taskId); // 0x072aa040
	System.Void RemoteCallGetMedalRewards(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int32> medalIds, System.Collections.Generic.IList<System.Int32> levels); // 0x072aa1c8
	System.Void RemoteCallRecordMiniGameProcess(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 interactionEntityId, System.Int64 taskId, WizardGames.Soc.Common.CustomType.CubeMiniGameRecord record); // 0x072aa35c
	System.Void RemoteCallCompleteMiniGame(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 interactionEntityId, WizardGames.Soc.Common.CustomType.CubeMiniGameRecord record); // 0x072aa518
	System.Void RemoteCallSkipNewbieAction(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x072aa6ac
	System.Void RemoteCallHidePoiTaskItem(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 interactionEntityId, System.Int64 itemId); // 0x072aa808
	System.Void RemoteCallEmitPoiTaskSignal(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 interactionEntityId); // 0x072aa99c
	static System.Object DeserializePlayerTaskComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072aab24
	WizardGames.Soc.Common.Entity.PlayerEntity get_Player(); // 0x072aabf8
	System.Void PostInit(); // 0x072aacb0
	System.Void RefreshTask(); // 0x072ab47c
	System.Void SubPoiGuideDataChange(WizardGames.Soc.Common.CustomType.DirectoryNode inProgressNode); // 0x072ab20c
	System.Void RefreshTaskCompletedNoGetReward(); // 0x072ac29c
	System.Void RefreshTaskNode(WizardGames.Soc.Common.CustomType.DirectoryNode dicNode, System.Boolean isNewbie); // 0x072ab6f4
	System.Void OnClearTask(System.Boolean isNewbie); // 0x072ac3b4
	System.Void OnCreateOrUpdateTask(WizardGames.Soc.Common.CustomType.TaskNode task); // 0x072ac4a4
	System.Void OnPoiTaskNodeUpdate(WizardGames.Soc.Common.CustomType.TaskNode task); // 0x072ac574
	System.Void SpawnByTaskAck(); // 0x072a6f6c
	System.Void ActivateGuide(System.Int32 guideId); // 0x072a7140
	System.Void OnGetFreeModeTaskReward(System.Int32 result); // 0x072a71b4
	System.Void OnGetDailyTaskReward(System.Int32 result); // 0x072a7290
	System.Void OnGetStoryTaskReward(System.Int32 result); // 0x072a7514
	System.Void AcceptPoiTaskResponse(System.Int32 result); // 0x072a762c
	System.Void SubmitPoiTaskResponse(System.Int32 result); // 0x072a78f4
	System.Void AbandonPoiTaskResponse(System.Int32 result); // 0x072a7b5c
	System.Void RefreshSinglePoiTaskResponse(System.Int32 result); // 0x072a7d60
	System.Void SummonPoiTaskTrapResponse(System.Int32 result); // 0x072a7f38
	System.Void HidePoiTaskItemResponse(System.Int32 result); // 0x072a7fac
	System.Void EmitPoiTaskSignalResponse(System.Int32 result); // 0x072a8020
	System.Void FinishMissionAck(System.Int32 missionId); // 0x072a8094
	System.Void GetMedalRewardsAck(System.Int32 httpCode, System.Int32 result); // 0x072a88ec
	static System.Void .cctor(); // 0x072ac840
	System.Void <PostInit>b__53_0(WizardGames.Soc.Share.Framework.CustomTypeBase _, System.Int64 _, System.Int64 _); // 0x072ac9cc
	System.Void <PostInit>b__53_1(WizardGames.Soc.Share.Framework.ECustomDictOpType _, System.Int32 _, System.Int32 _); // 0x072acba0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerTaskComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.PlayerTaskComponent.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMissionBook> <>9__57_6; // 0x8
	static System.Action <>9__57_2; // 0x10
	static System.Action <>9__57_3; // 0x18
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMissionBook> <>9__57_7; // 0x20
	static System.Action <>9__57_4; // 0x28
	static System.Action <>9__57_5; // 0x30
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMissionBook> <>9__57_8; // 0x38
	static System.Action <>9__57_0; // 0x40
	static System.Action <>9__57_1; // 0x48
	static WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__61_0; // 0x50
	static System.Void .cctor(); // 0x072acc7c
	System.Void .ctor(); // 0x072acce0
	System.Void <RefreshTaskNode>b__57_2(); // 0x072acd48
	System.Void <RefreshTaskNode>b__57_6(WizardGames.Soc.SocClient.Ui.UiMissionBook win); // 0x072aceb4
	System.Void <RefreshTaskNode>b__57_3(); // 0x072acf48
	System.Void <RefreshTaskNode>b__57_4(); // 0x072ad074
	System.Void <RefreshTaskNode>b__57_7(WizardGames.Soc.SocClient.Ui.UiMissionBook win); // 0x072ad1e0
	System.Void <RefreshTaskNode>b__57_5(); // 0x072ad274
	System.Void <RefreshTaskNode>b__57_0(); // 0x072ad3a0
	System.Void <RefreshTaskNode>b__57_8(WizardGames.Soc.SocClient.Ui.UiMissionBook win); // 0x072ad50c
	System.Void <RefreshTaskNode>b__57_1(); // 0x072ad5a0
	System.Void <SpawnByTaskAck>b__61_0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x072ad6cc
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerTaskComponent.<>c__DisplayClass64_0 : System.Object
{
	WizardGames.Soc.Common.Data.Play.QuestPhase cfg; // 0x10
	System.Void .ctor(); // 0x072ac708
	System.Void <OnGetDailyTaskReward>b__0(WizardGames.Soc.SocClient.Ui.UiCommonRewardPop win); // 0x072ad798
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerTaskComponent.<>c__DisplayClass73_0 : System.Object
{
	WizardGames.Soc.Common.Data.Play.QuestPhase questCfg; // 0x10
	System.Action<WizardGames.Soc.SocClient.Ui.UiMainQuestDetail> <>9__4; // 0x18
	System.Void .ctor(); // 0x072ac770
	System.Void <FinishMissionAck>b__1(); // 0x072adbc4
	System.Void <FinishMissionAck>b__4(WizardGames.Soc.SocClient.Ui.UiMainQuestDetail win); // 0x072adc8c
	System.Void <FinishMissionAck>b__0(); // 0x072add1c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerTaskComponent.<>c__DisplayClass73_1 : System.Object
{
	System.Int32 factionId; // 0x10
	System.Action<WizardGames.Soc.SocClient.Ui.UiMissionBook> <>9__3; // 0x18
	System.Void .ctor(); // 0x072ac7d8
	System.Void <FinishMissionAck>b__2(); // 0x072addcc
	System.Void <FinishMissionAck>b__3(WizardGames.Soc.SocClient.Ui.UiMissionBook win); // 0x072adec4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerVehicleComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 227076830;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072adfb0
	System.String GetTypeName(); // 0x072ae018
	System.Int32 get_Id(); // 0x072ae090
	System.Void .ctor(); // 0x072ae0f4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072ae180
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072ae26c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072ae31c
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> get_LockVehicles(); // 0x072ae380
	System.Void set_LockVehicles(WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> value); // 0x072ae420
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x072ae4ac
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x072ae6f0
	System.Void RemoteCallLockVehicle(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 vehicleId); // 0x072af9fc
	System.Void RemoteCallUnlockVehicle(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 vehicleId); // 0x072afb84
	System.Void RemoteCallLoadEquipToHorse(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 horseId, System.Int64 itemUid, System.Int32 position); // 0x072afd0c
	System.Void RemoteCallUnloadEquipFromHorse(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 horseId, System.Int32 position); // 0x072afec8
	System.Void RemoteCallLoadVehicleModular(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 vehicleId, System.Int32 position, System.Int64 itemUid); // 0x072b005c
	System.Void RemoteCallUnLoadVehicleModular(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 vehicleId, System.Int32 position); // 0x072b0218
	System.Void RemoteCallModuleCompose(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 entityId, System.Int64 bpId, System.Int32 count, System.Int64 vehicleId, System.Int32 position); // 0x072b03ac
	System.Void RemoteCallStopVehicleLooting(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x072b058c
	System.Void RemoteCallRepairModules(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 vehicleId, System.Collections.Generic.IList<System.Int32> moduleIndexes, System.Collections.Generic.IDictionary<System.Int64,System.Int32> expectToConsume); // 0x072b06e8
	static System.Object DeserializePlayerVehicleComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072b08a4
	System.Void UnloadEquipFromHorseAck(System.Int32 result); // 0x072aead4
	System.Void LoadVehicleModularAck(System.Int32 result, System.Boolean isReplace); // 0x072aec48
	System.Void UnLoadVehicleModularAck(System.Int32 result); // 0x072aef74
	System.Void ModuleComposeAck(System.Int32 result, System.Boolean replace); // 0x072af048
	System.Void RepairModulesAck(System.Int32 result); // 0x072af460
	System.Void RepairSuccessSound(System.Int64 entityId); // 0x072af734
	System.Void StartVehicleLootingAck(System.Int64 liftEntityId, System.Int64 entityId); // 0x072af7e8
	static System.Void .cctor(); // 0x072b097c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.RepairBenchComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 113430346;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Action<System.Int32> ActionDoRepairFinished; // 0x38
	WizardGames.Soc.Common.CustomType.ItemContainerNode container; // 0x40
	System.Int32 GetClassHash(); // 0x072b0a6c
	System.String GetTypeName(); // 0x072b0ad4
	System.Int32 get_Id(); // 0x072b0b4c
	System.Void .ctor(); // 0x072b0bb0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072b0cc4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072b0e88
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072b0fe4
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x072b1048
	System.Void RemoteCallDoRepair(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int64> srcPath); // 0x072b1220
	System.Void PostInit(); // 0x072b13a8
	System.Void DoRepairResult(System.Int32 opCode); // 0x072b1784
	static System.Void .cctor(); // 0x072b1b20
}

// Client.Runtime
class WizardGames.Soc.Common.Component.RepairBenchComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.RepairBenchComponent.<>c <>9; // 0x0
	static System.Action <>9__18_0; // 0x8
	static System.Void .cctor(); // 0x072b1bdc
	System.Void .ctor(); // 0x072b1c40
	System.Void <PostInit>b__18_0(); // 0x072b1ca8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ReputationComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1682591539;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072b1d48
	System.String GetTypeName(); // 0x072b1db0
	System.Int32 get_Id(); // 0x072b1e28
	System.Void .ctor(); // 0x072b1e8c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072b1f18
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072b2160
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072b2210
	WizardGames.Soc.Common.CustomType.SystemRootNode get_SystemRoot(); // 0x072b2274
	WizardGames.Soc.Common.CustomType.ReputationBadgeRootNode get_BadgeSystemRoot(); // 0x072b2338
	System.Int32 get_ReputationExp(); // 0x072b23fc
	System.Int32 get_ReputationLevel(); // 0x072b2470
	System.Boolean get_HideReputationLevel(); // 0x072b24e4
	System.Int64 get_CurrentBadgeId(); // 0x072b2558
	System.Int64 get_ReputationCabinetId(); // 0x072b25cc
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.PlayerReputationRecord> get_ReputationRecords(); // 0x072b2640
	System.Void set_ReputationRecords(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.PlayerReputationRecord> value); // 0x072b26e0
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> get_ReputationUnlockDropIds(); // 0x072b276c
	System.Void set_ReputationUnlockDropIds(WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> value); // 0x072b280c
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.ReputationReward> get_BattleRewardDict(); // 0x072b2898
	System.Void set_BattleRewardDict(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.ReputationReward> value); // 0x072b2938
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int32> get_LobbyAwardLevels(); // 0x072b29c4
	System.Void set_LobbyAwardLevels(WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int32> value); // 0x072b2a64
	System.Int32 get_Efficiency(); // 0x072b2af0
	System.Int64 get_ConvertedTimeStamp(); // 0x072b2b64
	System.Int64 get_StorageCount(); // 0x072b2bd8
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int32> get_UnlockedReward(); // 0x072b2c4c
	System.Void set_UnlockedReward(WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int32> value); // 0x072b2cec
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x072b2d78
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x072b2f64
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x072b3644
	System.Void RemoteCallReputationBadgeUnlock(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 badgeId); // 0x072b4920
	System.Void RemoteCallReputationBadgeEquip(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 badgeId, System.Int32 slot); // 0x072b4aa8
	System.Void RemoteCallSetHideReputationLevel(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean hide); // 0x072b4c3c
	System.Void RemoteCallWearReputationBadgeId(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 badgeId); // 0x072b4dc4
	System.Void RemoteCallAwardBattleReward(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 level, System.Collections.Generic.IDictionary<System.Int32,WizardGames.Soc.Common.SimpleCustom.IntHashSetData> selectIds); // 0x072b4f4c
	System.Void RemoteCallAwardLobbyReward(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 level); // 0x072b50e0
	static System.Object DeserializeReputationComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072b5268
	WizardGames.Soc.Common.Entity.PlayerEntity get_Player(); // 0x072b5438
	WizardGames.Soc.Common.Component.RootNodeComponent get_Root(); // 0x072b54f0
	System.Void Init(); // 0x072b557c
	System.Void PostInit(); // 0x072b55e4
	System.Void OnSetHideReputationLevelAck(System.Int32 result); // 0x072b3c04
	System.Void OnWearReputationBadgeIdAck(System.Int32 result, System.Int64 badgeId); // 0x072b3d94
	System.Void OnSetLobbyRewardCheckListAck(System.Int32 result); // 0x072b3f2c
	System.Void QueryPlayerBriefInfoAck(System.Int32 result, WizardGames.Soc.Common.SimpleCustom.EntityBriefInfo info); // 0x072b4078
	System.Void ReputationBadgeEquipAck(System.Int64 badgeId, System.Int32 slot, System.Int32 result); // 0x072b422c
	System.Void ReputationBadgeUnlockAck(System.Int64 badgeId, System.Int32 result); // 0x072b42bc
	System.Void SetClientLastCheckReputationLevelAck(System.Int32 Level); // 0x072b4404
	System.Void ConvertToReputationCabinetAck(System.Int64 terrinetCabinetId, System.Boolean status); // 0x072b4478
	System.Void ConvertToToolBoxAck(System.Int64 terrinetCabinetId, System.Boolean status); // 0x072b44f4
	System.Void GetClientLastCheckReputationLevelAck(System.Int32 reputationLevel); // 0x072b46d8
	System.Void GenReputationRewardAck(System.Int32 result); // 0x072b47a4
	System.Void ChangeReputationRewardAck(System.Int32 result); // 0x072b486c
	static System.Void .cctor(); // 0x072b59b0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ReputationComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.ReputationComponent.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.Share.Framework.CustomTypeBase,WizardGames.Soc.Share.Framework.CustomTypeBase,WizardGames.Soc.Share.Framework.CustomTypeBase> <>9__81_0; // 0x8
	static System.Action<WizardGames.Soc.Share.Framework.CustomTypeBase,System.Int32,System.Int32> <>9__81_1; // 0x10
	static System.Void .cctor(); // 0x072b5de0
	System.Void .ctor(); // 0x072b5e44
	System.Void <PostInit>b__81_0(WizardGames.Soc.Share.Framework.CustomTypeBase _, WizardGames.Soc.Share.Framework.CustomTypeBase old, WizardGames.Soc.Share.Framework.CustomTypeBase newList); // 0x072b5eac
	System.Void <PostInit>b__81_1(WizardGames.Soc.Share.Framework.CustomTypeBase _, System.Int32 old, System.Int32 newLevel); // 0x072b5f7c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ResearchBenchComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 402722977;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072b604c
	System.String GetTypeName(); // 0x072b60b4
	System.Int32 get_Id(); // 0x072b612c
	System.Void .ctor(); // 0x072b6190
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072b6218
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072b62c4
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072b6370
	System.Boolean get_IsOpen(); // 0x072b63d4
	System.Int64 get_StartTime(); // 0x072b6448
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x072b64bc
	System.Void RemoteCallResearchBenchOpen(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean open, System.Collections.Generic.IList<System.Int64> srcPath); // 0x072b66f0
	System.Void PostInit(); // 0x072b6884
	System.Void DoResearchBenchOpenResponse(System.Int32 opCode, System.Boolean open); // 0x072b69b0
	System.Void ResearchDoneNotify(); // 0x072b6cb8
	static System.Void .cctor(); // 0x072b6de8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ResearchBenchComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.ResearchBenchComponent.<>c <>9; // 0x0
	static System.Action <>9__22_0; // 0x8
	static System.Void .cctor(); // 0x072b6f40
	System.Void .ctor(); // 0x072b6fa4
	System.Void <PostInit>b__22_0(); // 0x072b700c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.RootNodeComponent : WizardGames.Soc.Share.Framework.ComponentBase, WizardGames.Soc.Share.Game.NodeSystem.ILogicRoot, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Share.Game.NodeSystem.INode>>, System.Collections.IEnumerable
{
	static System.Int32 CLASS_HASH = 30;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int64 CurShowLootingSysIndex; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.CustomType.SystemRootNode> systemRoots; // 0x40
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> Node2System; // 0x48
	System.Int32 GetClassHash(); // 0x072b70ac
	System.String GetTypeName(); // 0x072b7110
	System.Int32 get_Id(); // 0x072b7188
	System.Void .ctor(); // 0x072b71ec
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072b7324
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072b7480
	WizardGames.Soc.Common.Entity.PlayerEntity get_Player(); // 0x072b74e4
	WizardGames.Soc.Share.Game.NodeSystem.IDirectoryNode get_LootSystemNode(); // 0x072b759c
	System.Int64 get_LootingSystemIndex(); // 0x072b7880
	WizardGames.Soc.Common.Component.RootNodeComponent get_LootingRoot(); // 0x072b795c
	System.Int32 get_ChildCount(); // 0x072b7a00
	WizardGames.Soc.Share.Game.NodeSystem.INode GetNodeByPath(System.Collections.Generic.IEnumerable<System.Int64> path); // 0x072a5438
	WizardGames.Soc.Common.CustomType.SystemRootNode GetSystemNode(System.Int64 type); // 0x072b7a84
	WizardGames.Soc.Share.Game.NodeSystem.INode GetChildNode(System.Int64 index); // 0x072b7b4c
	WizardGames.Soc.Common.CustomType.NodeBase GetNodeById(System.Int64 nodeId); // 0x072a4f98
	WizardGames.Soc.Common.CustomType.NodeBase GetNode(System.Int64 nodeId); // 0x072b7c14
	System.Void GetContainerAndItemFromPath(System.Collections.Generic.List<System.Int64> path, WizardGames.Soc.Common.CustomType.ItemContainerNode& containerNode, WizardGames.Soc.Common.CustomType.BaseItemNode& itemNode); // 0x072b7d2c
	WizardGames.Soc.Share.Game.NodeSystem.INode GetNodeByPath(System.Int64 index); // 0x072b7fd4
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Share.Game.NodeSystem.INode>> GetEnumerator(); // 0x072b809c
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x072b8238
	WizardGames.Soc.Share.Game.NodeSystem.IDirectoryNode GetMoveToLootSystem(); // 0x072b7600
	System.Int64 get_IdentifyId(); // 0x072b82c0
	System.Void RegisterSystemRootNode(WizardGames.Soc.Common.CustomType.SystemRootNode systemRoot); // 0x0729fd04
	System.Void UnregisterSystemRootNode(WizardGames.Soc.Common.CustomType.SystemRootNode systemRoot); // 0x072a0304
	System.Void ReturnToPoolBusiness(); // 0x072b83d8
	WizardGames.Soc.Share.Game.NodeSystem.INode GetNodeByPath(System.Int64 firstIndex, System.Int64 secondIndex); // 0x072b848c
	WizardGames.Soc.Share.Game.NodeSystem.INode GetNodeByPath(System.Int64 firstIndex, System.Int64 secondIndex, System.Int64 thirdIndex); // 0x072b859c
	static System.Void .cctor(); // 0x072b86c8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.RootNodeComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.RootNodeComponent.<>c <>9; // 0x0
	static System.Func<System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Common.CustomType.SystemRootNode>,System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Share.Game.NodeSystem.INode>> <>9__38_0; // 0x8
	static System.Void .cctor(); // 0x072b8780
	System.Void .ctor(); // 0x072b87e4
	System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Share.Game.NodeSystem.INode> <GetEnumerator>b__38_0(System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Common.CustomType.SystemRootNode> pair); // 0x072b884c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.RootNodeComponent.<>c__DisplayClass45_0 : System.Object
{
	WizardGames.Soc.Common.Component.RootNodeComponent <>4__this; // 0x10
	WizardGames.Soc.Common.CustomType.SystemRootNode systemRoot; // 0x18
	System.Void .ctor(); // 0x072b8370
	System.Void <RegisterSystemRootNode>b__0(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int64 id, WizardGames.Soc.Common.CustomType.NodeBase oldNode); // 0x072b8900
}

// Client.Runtime
class WizardGames.Soc.Common.Component.RuleGraphComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 40630280;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072b8cd0
	System.String GetTypeName(); // 0x072b8d38
	System.Int32 get_Id(); // 0x072b8db0
	System.Void .ctor(); // 0x072b8e14
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072b8ea0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072b8fec
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072b909c
	WizardGames.Soc.Common.CustomType.GraphContextSync get_ContextSync(); // 0x072b9100
	WizardGames.Soc.Common.CustomType.GraphContext get_GraphContext(); // 0x072b91c4
	System.Void RemoteCallSendCustomEventGlobalWithRoleId(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.String eventName, System.UInt64 roleId, System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.CustomEventParamCfg> eventParams); // 0x072b9288
	static System.Object DeserializeRuleGraphComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072b9444
	System.Void Init(); // 0x072b9514
	System.Void Cleanup(); // 0x072b9594
	static System.Void .cctor(); // 0x072b9614
}

// Client.Runtime
class WizardGames.Soc.Common.Component.SafetyBoxComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 1421331618;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072b976c
	System.String GetTypeName(); // 0x072b97d4
	System.Int32 get_Id(); // 0x072b984c
	System.Void .ctor(); // 0x072b98b0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072b9938
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072b99e4
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072b9a90
	static System.Void .cctor(); // 0x072b9af4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.SeekerTargetComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1925227005;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072b9bb0
	System.String GetTypeName(); // 0x072b9c18
	System.Int32 get_Id(); // 0x072b9c90
	System.Void .ctor(); // 0x072b9cf4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072b9d80
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072b9e90
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072b9f40
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Boolean> get_TargeterInfos(); // 0x072b9fa4
	System.Void set_TargeterInfos(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Boolean> value); // 0x072ba044
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int64> get_SeekerIds(); // 0x072ba0d0
	System.Void set_SeekerIds(WizardGames.Soc.Share.Framework.BasicTypeList<System.Int64> value); // 0x072ba170
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x072ba1fc
	static System.Object DeserializeSeekerTargetComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072ba56c
	static System.Void .cctor(); // 0x072ba68c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ShopComponent : WizardGames.Soc.Share.Framework.ComponentBase, WizardGames.Soc.Common.Component.IClientShopBase
{
	static System.Int32 CLASS_HASH = 1743157294;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	WizardGames.Soc.Common.Component.IClientShopBase.OnShopItemBuyCallBack ShopItemBuyCallBack; // 0x38
	System.Int32 GetClassHash(); // 0x072ba77c
	System.String GetTypeName(); // 0x072ba7e4
	System.Int32 get_Id(); // 0x072ba85c
	System.Void .ctor(); // 0x072ba8c0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072ba94c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072baa44
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072baaf4
	System.Int64 get_ShopId(); // 0x072bab58
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.ShopItemData> get_ShopItemDataDict(); // 0x072babcc
	System.Void set_ShopItemDataDict(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.ShopItemData> value); // 0x072bac6c
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x072bacf8
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x072bae58
	static System.Object DeserializeShopComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072bb0a0
	System.Void PostInit(); // 0x072bb1c4
	System.Void OnShopItemDataChanged(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int32 itemId, WizardGames.Soc.Common.CustomType.ShopItemData oldVal); // 0x072bb728
	System.Void OpenShopUi(); // 0x072bb7f8
	System.Void Cleanup(); // 0x072bb8d8
	System.Void BuyAck(System.Int32 result, System.Boolean isVehicle); // 0x072a1d54
	System.Void RegisterShopItemBuyCallBack(WizardGames.Soc.Common.Component.IClientShopBase.OnShopItemBuyCallBack callback); // 0x072bbd28
	System.Void CloseShopUI(); // 0x072bbdbc
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.ShopItemData> GetShopItemDataDict(); // 0x072bbe80
	System.Void DoBuy(System.Int32 shopItemId, System.Int32 count); // 0x072bbee4
	static System.Void .cctor(); // 0x072bbfd4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ShopComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.ShopComponent.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.Share.Framework.CustomTypeBase,System.UInt32,System.UInt32> <>9__27_0; // 0x8
	static System.Action<WizardGames.Soc.Share.Framework.CustomTypeBase,System.Int32,System.Int32> <>9__27_1; // 0x10
	static System.Void .cctor(); // 0x072bc12c
	System.Void .ctor(); // 0x072bc190
	System.Void <PostInit>b__27_0(WizardGames.Soc.Share.Framework.CustomTypeBase _, System.UInt32 oldValue, System.UInt32 newValue); // 0x072bc1f8
	System.Void <PostInit>b__27_1(WizardGames.Soc.Share.Framework.CustomTypeBase _, System.Int32 oldValue, System.Int32 newValue); // 0x072bc2c8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ShowCabinetComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 292495095;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072bc398
	System.String GetTypeName(); // 0x072bc400
	System.Int32 get_Id(); // 0x072bc478
	System.Void .ctor(); // 0x072bc4dc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072bc568
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072bc618
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072bc6c8
	static System.Void .cctor(); // 0x072bc72c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.SleepingBagBaseComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1212881751;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	SocLogger logger; // 0x38
	static System.Collections.Generic.List<WizardGames.Soc.Common.Component.SleepingBagBaseComponent> allSleepingBagModules; // 0x10
	static System.Collections.Generic.List<WizardGames.Soc.Common.Component.SleepingBagBaseComponent> defaultSleepingBags; // 0x18
	System.Int64 <UnlockTime>k__BackingField; // 0x40
	WizardGames.Soc.Common.Component.RespawnType RespawnType; // 0x48
	System.Int32 GetClassHash(); // 0x072bc850
	System.String GetTypeName(); // 0x072bc8b8
	System.Int32 get_Id(); // 0x072bc930
	System.Void .ctor(); // 0x072bc994
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072bcacc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072bcc28
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072bcd84
	System.Void OnGoLoaded(); // 0x072bcde8
	System.Void Cleanup(); // 0x072bd0d0
	System.Int64 get_UnlockTime(); // 0x072bd250
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x072bd018
	WizardGames.Soc.Common.Component.ConstructionRenameComponent get_renameComponent(); // 0x072bd2b4
	System.Boolean HasFlag(WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags flag); // 0x072bd328
	System.Boolean IsPublic(); // 0x072bd3e8
	System.Boolean CanUse(System.Int64 roleId, System.Boolean ignoreTimers); // 0x072bd450
	System.Boolean CanPublic(); // 0x072bd574
	System.Boolean CanDelete(); // 0x072bd5f8
	static System.Void .cctor(); // 0x072bd67c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.SleepingBagComponent : WizardGames.Soc.Common.Component.SleepingBagBaseComponent, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler
{
	static System.Int32 CLASS_HASH = 1513689877;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Single hideTime; // 0x4c
	System.Int32 GetClassHash(); // 0x072bd780
	System.String GetTypeName(); // 0x072bd7e8
	System.Int32 get_Id(); // 0x072bd860
	System.Void .ctor(); // 0x072bd8c4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072bd94c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072bd9f8
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072bdaa4
	System.Single get_HideTime(); // 0x072bdb08
	System.Void OnGoLoaded(); // 0x072bdb6c
	static System.Boolean IsShareCd(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x072bde38
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x072be478
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x072be4ec
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x072be768
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x072be7dc
	System.Void OpenAssignUIDialog(); // 0x072bed74
	System.Void ClientRename(System.String newName); // 0x072bdd50
	static System.Void TryShowNewGet(System.Int64 entityId, System.Single hideTime); // 0x072beee8
	static System.Void .cctor(); // 0x072bf0f4
	System.Void <OnUiBtnClicked>b__21_0(); // 0x072bf1b0
	System.Void <OpenAssignUIDialog>b__22_0(System.UInt64 id); // 0x072bf284
}

// Client.Runtime
class WizardGames.Soc.Common.Component.SouDaJianComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1337228256;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	static WizardGames.Soc.Common.Component.SouDaJianComponent Instance; // 0x10
	System.Int32 GetClassHash(); // 0x072bf380
	System.String GetTypeName(); // 0x072bf3e8
	System.Int32 get_Id(); // 0x072bf460
	System.Void .ctor(); // 0x072bf4c4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072bf550
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072bf6ac
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072bf75c
	System.Boolean get_Open(); // 0x072bf7c0
	System.Boolean get_SignOpen(); // 0x072bf834
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.SouDaJianTeamInfo> get_TeamInfos(); // 0x072bf8a8
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int32,System.Int32> get_EventSecTs(); // 0x072bf948
	System.Int32 get_StageId(); // 0x072bf9e8
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.GoldCoinAirdropData> get_GoldCoinAirdropData(); // 0x072bfa5c
	System.Int32 get_CurRound(); // 0x072bfafc
	System.Int64 get_NextRoundOpenTsSec(); // 0x072bfb70
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x072bfbe4
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x072bfdbc
	static System.Object DeserializeSouDaJianComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072bff88
	System.Void Init(); // 0x072c013c
	System.Void Cleanup(); // 0x072c0508
	System.Void OnTeamElimination(System.Int64 teamId); // 0x072c0730
	System.Void RegistEvent(); // 0x072c0240
	static System.Void .cctor(); // 0x072c07a4
	System.Void <RegistEvent>b__57_1(WizardGames.Soc.Share.Framework.CustomTypeBase _, WizardGames.Soc.Share.Framework.TypeBase old, WizardGames.Soc.Share.Framework.TypeBase newLevel); // 0x072c0c3c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.SouDaJianComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.SouDaJianComponent.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.Share.Framework.CustomTypeBase,System.Int32,System.Int32> <>9__57_0; // 0x8
	static System.Void .cctor(); // 0x072c0dac
	System.Void .ctor(); // 0x072c0e10
	System.Void <RegistEvent>b__57_0(WizardGames.Soc.Share.Framework.CustomTypeBase _, System.Int32 old, System.Int32 newLevel); // 0x072c0e78
}

// Client.Runtime
class WizardGames.Soc.Common.Component.SpawnComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1819763832;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072c0f60
	System.String GetTypeName(); // 0x072c0fc8
	System.Int32 get_Id(); // 0x072c1040
	System.Void .ctor(); // 0x072c10a4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072c1130
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072c11e0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072c1290
	static System.Void .cctor(); // 0x072c12f4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.StabilityComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 24;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072c1418
	System.String GetTypeName(); // 0x072c147c
	System.Int32 get_Id(); // 0x072c14f4
	System.Void .ctor(); // 0x072c1558
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072c15e4
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072c1694
	System.Single get_Stability(); // 0x072c16f8
	static System.Void .cctor(); // 0x072c176c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.StorageBoxComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 465591263;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072c1824
	System.String GetTypeName(); // 0x072c188c
	System.Int32 get_Id(); // 0x072c1904
	System.Void .ctor(); // 0x072c1968
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072c19f0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072c1a9c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072c1b48
	System.Void PostInit(); // 0x072c1bac
	static System.Void .cctor(); // 0x072c1c10
}

// Client.Runtime
class WizardGames.Soc.Common.Component.StorageComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1937061881;
	static System.Int32 StaticClassHash; // 0x0
	static System.String TYPE_NAME = "StorageComponent";
	static System.String[] PropNameArray; // 0x8
	System.Boolean rootRegistered; // 0x33
	System.Int32 GetClassHash(); // 0x072c1ccc
	System.String GetTypeName(); // 0x072c1d34
	System.Int32 get_Id(); // 0x072c1dac
	System.Void .ctor(); // 0x072b0c38
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072b0d70
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072b0f34
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072c1e10
	WizardGames.Soc.Common.CustomType.ItemSystemRootNode get_Root(); // 0x072b16c0
	WizardGames.Soc.Common.Entity.PartEntity get_partEntity(); // 0x072c1e74
	WizardGames.Soc.Common.Entity.PartEntity get_PartEntity(); // 0x072c1f2c
	System.Void PostInit(); // 0x072b1580
	System.Void Cleanup(); // 0x072c2140
	System.Void OnFullSubscribed(); // 0x072c2204
	System.Void OnLodChange(); // 0x072c1f90
	System.Void OnLodChange(System.Int32 level); // 0x072c2264
	static System.Void .cctor(); // 0x072c22dc
	System.Void <PostInit>b__22_0(WizardGames.Soc.Share.Framework.CustomTypeBase _, WizardGames.Soc.Share.Framework.CustomTypeBase oldRoot, WizardGames.Soc.Share.Framework.CustomTypeBase newRoot); // 0x072c2398
}

// Client.Runtime
class WizardGames.Soc.Common.Component.StorageComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.StorageComponent.<>c <>9; // 0x0
	static System.Action <>9__22_1; // 0x8
	static System.Action <>9__25_0; // 0x10
	static System.Void .cctor(); // 0x072c25bc
	System.Void .ctor(); // 0x072c2620
	System.Void <PostInit>b__22_1(); // 0x072c2688
	System.Void <OnLodChange>b__25_0(); // 0x072c2728
}

// Client.Runtime
class WizardGames.Soc.Common.Component.SwimmingComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1501205018;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072c27c8
	System.String GetTypeName(); // 0x072c2830
	System.Int32 get_Id(); // 0x072c28a8
	System.Void .ctor(); // 0x072c290c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072c2998
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072c2a48
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072c2af8
	System.Boolean get_IsInDeepWater(); // 0x072c2b5c
	static System.Void .cctor(); // 0x072c2bd0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.SwitchComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1073725193;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072c2c8c
	System.String GetTypeName(); // 0x072c2cf4
	System.Int32 get_Id(); // 0x072c2d6c
	System.Void .ctor(); // 0x072c2dd0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072c2e5c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072c2f0c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072c2fbc
	System.Boolean get_IsOpen(); // 0x072c3020
	System.Void RemoteCallSwitchOp(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean isOpen); // 0x072c3094
	System.Void PostInit(); // 0x072c321c
	static System.Void .cctor(); // 0x072c33d8
	static System.Void OnIsOpenChange(WizardGames.Soc.Share.Framework.CustomTypeBase component, System.Boolean oldValue, System.Boolean newValue); // 0x072c3538
	System.Void OnSwitchStatusChange(System.Boolean flagChange); // 0x072c3290
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TeamComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1825031374;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.String CacheTlogParam; // 0x38
	System.Int32 GetClassHash(); // 0x072c3610
	System.String GetTypeName(); // 0x072c3678
	System.Int32 get_Id(); // 0x072c36f0
	System.Void .ctor(); // 0x072c3754
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072c380c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072c39d0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072c3aac
	WizardGames.Soc.Common.CustomType.TeamTipsRootNode get_Root(); // 0x072c3b10
	System.Int64 get_TeamId(); // 0x072c3bd4
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.UInt64,WizardGames.Soc.Common.CustomType.TeamInviteInfo> get_InviteInfos(); // 0x072c3c48
	System.Void set_InviteInfos(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.UInt64,WizardGames.Soc.Common.CustomType.TeamInviteInfo> value); // 0x072c3ce8
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.UInt64,WizardGames.Soc.Common.CustomType.SendInviteInfo> get_SendInvites(); // 0x072c3d74
	System.Void set_SendInvites(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.UInt64,WizardGames.Soc.Common.CustomType.SendInviteInfo> value); // 0x072c3e14
	System.Int32 get_InviteOtherCount(); // 0x072c3ea0
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x072c3f14
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x072c40ec
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x072c4460
	System.Void RemoteCallTeamSendInvite(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.UInt64 inviteeId, System.Int32 type, System.String teamSource, System.String teamChangeEntrance); // 0x072c8608
	System.Void RemoteCallTeamAcceptInvite(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.UInt64 inviterId, System.String teamChangeEntrance); // 0x072c87cc
	System.Void RemoteCallRefuseInvite(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.UInt64> roleIds); // 0x072c8960
	System.Void RemoteCallTeamHandoverCaptain(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.UInt64 toRoleId); // 0x072c8ae8
	System.Void RemoteCallKickOut(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.UInt64 targetRoleId, System.String teamChangeEntrance); // 0x072c8c70
	System.Void RemoteCallTeamChangeDuty(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.UInt64 toRoleId, System.Boolean grant); // 0x072c8e04
	System.Void RemoteCallTeamLeaveTeam(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.String teamChangeEntrance); // 0x072c8f98
	System.Void RemoteCallGetRecommendListInBattle(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x072c9120
	System.Void RemoteCallUpdateInviteState(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x072c927c
	System.Void RemoteCallSearchPlayer(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.String name); // 0x072c93d8
	System.Void RemoteCallShareTeam(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x072c9560
	System.Void RemoteCallCallTeammateOnline(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.UInt64 roleId); // 0x072c96bc
	System.Void RemoteCallApplyForCaptain(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x072c9844
	System.Void RemoteCallVoteToMember(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean agree); // 0x072c99a0
	System.Void RemoteCallRemoveTeamTips(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int64> mailIds); // 0x072c9b28
	System.Void RemoteCallGetDailyRankList(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 page); // 0x072c9cb0
	System.Void RemoteCallGetBattleRankList(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 page); // 0x072c9e38
	System.Void RemoteCallGetOneTeamDailyInfo(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 teamEntityId); // 0x072c9fc0
	System.Void RemoteCallRecruit(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, WizardGames.Soc.Common.CustomType.RecruitmentParam recruitmentParam); // 0x072ca148
	System.Void RemoteCallWarZoneTeamRecruit(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, WizardGames.Soc.Common.CustomType.RecruitmentParam recruitmentParam); // 0x072ca2d0
	System.Void RemoteCallCancelWarZoneTeamRecruit(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x072ca458
	System.Void RemoteCallFilterWarZoneTeamRecruitmentList(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int32> teamPreference, System.Boolean microphone); // 0x072ca5b4
	System.Void RemoteCallGetWarZoneTeamRecruitmentList(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<System.Int64> teamIds); // 0x072ca748
	System.Void RemoteCallGetWarZoneTeamRecruitmentChatList(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean isFrist); // 0x0550f700
	System.Void RemoteCallApplyWarZoneTeam(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 teamId, System.String applyRemark, System.Int32 source, System.Collections.Generic.IList<System.Int32> preference); // 0x072caa2c
	System.Void RemoteCallResponseRecruitmentApplication(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.UInt64 roleId, System.Boolean isAccept, System.Boolean isLobbyRecruitment, System.String teamChangeEntrance); // 0x072cabf0
	System.Void RemoteCallGetRecruitmentApplications(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x072cadb4
	static System.Object DeserializeTeamComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072caf10
	WizardGames.Soc.Common.Entity.PlayerEntity get_Player(); // 0x072cb014
	System.Void Init(); // 0x072cb0cc
	System.Void PostInit(); // 0x072cb550
	System.Void OnGetRecommendListInBattle(System.Collections.Generic.List<System.UInt64> roleIds); // 0x072c4e80
	System.Void SearchPlayerFailed(System.Int32 code); // 0x072c4f4c
	System.Void OnTeammateLogin(System.UInt64 roleId); // 0x072c5120
	System.Void OnTeammateLogout(System.UInt64 roleId); // 0x072c51ec
	System.Void SyncTeamSearch(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TeamSearchItemData> args); // 0x072c52b8
	System.Void GetTeamMemberDisplayInfoAck(System.String serializeData); // 0x072c53e0
	System.Void ShareTeamAck(System.Int64 teamId); // 0x072c54f8
	System.Void GetRecruitmentApplicationsAck(System.Buffers.ReadOnlySequence<System.Byte> applicationBytes); // 0x072c5604
	System.Void NewRecruitmentApplicationNotify(System.UInt64 roleId, System.Buffers.ReadOnlySequence<System.Byte> applicationBytes); // 0x072c5788
	System.Void CallTeammateOnlineSuccess(); // 0x072c5b30
	System.Void OnLeaveTeam(); // 0x072c5c40
	System.Void WarZoneTeamRecruitmentListNotify(System.Buffers.ReadOnlySequence<System.Byte> recruitmentSequece, System.Boolean getSelfTeamRecruitment); // 0x072c6050
	System.Void WarZoneTeamRecruitmentChatListAck(System.Buffers.ReadOnlySequence<System.Byte> recruitmentSequece); // 0x072c6608
	System.Void WarZoneTeamRecruitAck(System.Int32 result); // 0x072c71cc
	System.Void SendTlogOfPublishRecruit(); // 0x072cb6a4
	System.Void CancelWarZoneTeamRecruitAck(System.Int32 result); // 0x072c764c
	System.Void SelfTeamRecruitNotify(System.Boolean isCancel, System.Buffers.ReadOnlySequence<System.Byte> recruitmentSequece); // 0x072c77c8
	System.Void ApplyWarZoneTeamAck(System.Int32 result, System.Int64 teamId); // 0x072c7c90
	System.Void WarZoneTeamRecruitmentApplyResultNotify(System.Int64 teamId, System.Boolean isAccept, System.Boolean teamNeedmicrophone); // 0x072c80f8
	System.Void RecruitAck(System.Int32 code, System.Int32 msgId); // 0x072c826c
	System.Void GetDailyRankListAck(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TeamRankInfo> teamDailyRankList, System.Int32 currPage, System.Int32 totalPage); // 0x072c836c
	System.Void GetBattleRankListAck(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TeamRankInfo> teamBattleRankList, System.Int32 currPage, System.Int32 totalPage); // 0x072c8454
	System.Void GetOneTeamInfoAck(System.Int64 teamEntityId, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.PlayerDisplaySimple> teamMembers); // 0x072c853c
	static System.Void .cctor(); // 0x072cb80c
	System.Void <Init>b__66_0(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamInviteInfo oldVal); // 0x072cba00
	System.Void <PostInit>b__67_0(WizardGames.Soc.Share.Framework.CustomTypeBase _, System.Int64 _, System.Int64 newTeamId); // 0x072cbd20
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TeamSouDaJianComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 902521157;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072cbe2c
	System.String GetTypeName(); // 0x072cbe94
	System.Int32 get_Id(); // 0x072cbf0c
	System.Void .ctor(); // 0x072cbf70
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072cbffc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072cc0ac
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072cc15c
	System.Boolean get_IsSignUp(); // 0x072cc1c0
	System.Int32 get_ReputationGoldCoinNum(); // 0x072cc234
	System.Int32 get_DailyReputationGoldCoinIncrement(); // 0x072cc2a8
	System.Int32 get_OverallRank(); // 0x072cc31c
	System.Int32 get_DailyRank(); // 0x072cc390
	System.Int32 get_CupNum(); // 0x072cc404
	System.Void Init(); // 0x072cc478
	System.Void Cleanup(); // 0x072cc618
	System.Void RegistEvent(); // 0x072cc4dc
	static System.Void .cctor(); // 0x072cc680
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TeamSouDaJianComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.TeamSouDaJianComponent.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.Share.Framework.CustomTypeBase,System.Boolean,System.Boolean> <>9__37_0; // 0x8
	static System.Void .cctor(); // 0x072cc874
	System.Void .ctor(); // 0x072cc8d8
	System.Void <RegistEvent>b__37_0(WizardGames.Soc.Share.Framework.CustomTypeBase _, System.Boolean old, System.Boolean newLevel); // 0x072cc940
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TerritoryBaseComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1465637299;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072cca10
	System.String GetTypeName(); // 0x072cca78
	System.Int32 get_Id(); // 0x072ccaf0
	System.Void .ctor(); // 0x072ccb54
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072ccbe0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072ccdac
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072cce5c
	System.Int64 get_PartEntityId(); // 0x072ccec0
	System.Int32 get_SpawnType(); // 0x072ccf34
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.TerritoryCenterLocationInfo> get_LocList(); // 0x072ccfa8
	System.Void set_LocList(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.TerritoryCenterLocationInfo> value); // 0x072cd048
	System.UInt64 get_CreatorRoleId(); // 0x072cd0d4
	System.Int32 get_NormalPartCount(); // 0x072cd148
	System.Int32 get_CanExportBlueprintPartCount(); // 0x072cd1bc
	WizardGames.Soc.Common.CustomType.PartLimitInfo get_PartLimitInfo(); // 0x072cd230
	System.Int64 get_LastBatchUpgradeTs(); // 0x072cd2f4
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.ConstructionGapLinkInfo> get_GapLinkInfoDic(); // 0x072cd368
	System.Void set_GapLinkInfoDic(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.ConstructionGapLinkInfo> value); // 0x072cd408
	System.Int32 get_ToolCupboardDebrisDestroyedSec(); // 0x072cd494
	WizardGames.Soc.Common.CustomType.CommunityInfo get_CommunityInfo(); // 0x072cd508
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x072cd5cc
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x072cd7b8
	static System.Object DeserializeTerritoryBaseComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072cdb2c
	System.Int32 GetPartTypeCount(System.Int64 partType); // 0x072cdd00
	static System.Void .cctor(); // 0x072cde9c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TerritoryBatchRecoverComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1718541335;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072ce264
	System.String GetTypeName(); // 0x072ce2cc
	System.Int32 get_Id(); // 0x072ce344
	System.Void .ctor(); // 0x072ce3a8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072ce434
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072ce54c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072ce5fc
	System.Int64 get_LastRecoverTs(); // 0x072ce660
	System.Boolean get_IsRecovering(); // 0x072ce6d4
	System.Void RemoteCallReqTerritoryRecoverCost(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x072ce748
	System.Void RemoteCallReqBatchRecover(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IDictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.TemplateGrades> tGrades, System.Collections.Generic.IDictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.TemplateGrades> cGrades); // 0x072ce8a4
	WizardGames.Soc.Common.Entity.TerritoryEntity get_TerrEnt(); // 0x072cea38
	System.Boolean get_HasRecordLeft(); // 0x072ceaf4
	System.Boolean IsNewCreatedInRecord(WizardGames.Soc.Common.Entity.PartEntity part); // 0x072ceb58
	static System.Void .cctor(); // 0x072cebd0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TerritoryBatchUpgradeComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1204833149;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> StorageBoxIngredients; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> TerritoryCabinetIngredients; // 0x40
	System.Int32 GetClassHash(); // 0x072cecf4
	System.String GetTypeName(); // 0x072ced5c
	System.Int32 get_Id(); // 0x072cedd4
	System.Void .ctor(); // 0x072cee38
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072cef40
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072cf0d4
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072cf200
	WizardGames.Soc.Common.CustomType.BatchUpgradeRecord get_UpgradeRecord(); // 0x072cf264
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x072cf328
	System.Void RemoteCallRequestUpgradeData(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x072cf654
	System.Void RemoteCallRequestUpgradeBatch(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 dataVersion, System.Int32 targetGrade, System.Collections.Generic.IDictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.TemplateGrades> selNonComboUpgradeInfo, System.Collections.Generic.IDictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.ComboTemplateGrades> selComboUpgradeInfo, System.Collections.Generic.IList<System.Int64> orderedPartList); // 0x072cf7b0
	System.Void Cleanup(); // 0x072cf98c
	System.Void OnRequestUpgradeData(System.Int32 dataVersion, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.GradeCountInfo> nonComboPartCount, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ComboPartInfo> comboPartInfo, System.Collections.Generic.Dictionary<System.Int64,System.Int32> storageBoxIngredients, System.Collections.Generic.Dictionary<System.Int64,System.Int32> territoryCabinetIngredients); // 0x072cfa2c
	System.Void OnUpgradeDataVersionChanged(System.Int32 dataVersion); // 0x072cffa8
	System.Void OnRequestUpgradeBatch(System.Int32 result, System.Int32 needSec, System.Collections.Generic.List<System.Int64> args); // 0x072d0134
	System.Void OnBatchUpgradeStatusChange(System.Int64 entityId); // 0x072cf4f4
	static System.Void .cctor(); // 0x072d0468
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TerritoryCabinetComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 889361513;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> inputStackableItemNodeList; // 0x38
	System.Int32 GetClassHash(); // 0x072d0524
	System.String GetTypeName(); // 0x072d058c
	System.Int32 get_Id(); // 0x072d0604
	System.Void .ctor(); // 0x072d0668
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072d0740
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072d083c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072d0938
	System.Int64 get_ItemNodeId(); // 0x072d099c
	System.Int64 get_StartTimeStamp(); // 0x072d0a10
	System.Int32 get_Efficiency(); // 0x072d0a84
	System.Int32 get_ReputationLevel(); // 0x072d0af8
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x072d0b6c
	System.Void RemoteCallCommit(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x072d10a4
	System.Void RemoteCallFillingUpkeepMaterials(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.TerritoryFillUpkeepData> data); // 0x072d1200
	System.Void RemoteCallSouDaJianSignUp(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x072d1388
	System.Void RemoteCallCancelSouDaJianSignUp(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x072d14e4
	System.Void RemoteCallCommitReputionGoldCoins(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 count); // 0x072d1640
	static System.Object DeserializeTerritoryCabinetComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072d17c8
	static System.Void .cctor(); // 0x072d189c
	System.Void PostInit(); // 0x072d1bb0
	System.Void Cleanup(); // 0x072d1ed4
	System.Void OnLodChange(System.Int32 level); // 0x072d1f3c
	static System.Void OnInputContainChange(); // 0x072d20d4
	static System.Void OnOutputContainChange(); // 0x072d216c
	static System.Void EfficiencyUpdateCallback(WizardGames.Soc.Share.Framework.CustomTypeBase comp, System.Int32 oldVal, System.Int32 newVal); // 0x072d2204
	static System.Void ReputationLevelUpdateCallback(WizardGames.Soc.Share.Framework.CustomTypeBase comp, System.Int32 oldVal, System.Int32 newVal); // 0x072d22c0
	WizardGames.Soc.Common.CustomType.ItemContainerNode GetInputContainer(); // 0x072d1d3c
	WizardGames.Soc.Common.CustomType.ItemContainerNode GetOutputContainer(); // 0x072d1e08
	WizardGames.Soc.Common.CustomType.ItemContainerNode GetSafetyBoxTemporarStorageContainer(); // 0x072d237c
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> GetInputItemList(); // 0x072d2448
	WizardGames.Soc.Common.CustomType.BaseItemNode GetOutputItemNode(); // 0x072d26b0
	WizardGames.Soc.Common.CustomType.ItemContainerNode GetItemContainerById(System.Int64 id); // 0x072d2780
	static System.Boolean CheckReputationPart(); // 0x072d2860
	static System.Boolean TryMoveReputationItemToToolCupboardCheck(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x072d2a0c
	static System.Boolean IsReputationItem(System.Int64 itemTableId); // 0x072d2b24
	System.Void CommitResponse(System.Int32 result); // 0x072d0e08
	System.Void SouDaJianSignUpResponse(System.Int32 result); // 0x072d0f48
	System.Void CancelSouDaJianSignUpResponse(System.Int32 result); // 0x072d0fbc
	System.Void CommitReputionGoldCoinsAck(System.Int32 result); // 0x072d1030
	System.Void <PostInit>b__35_0(WizardGames.Soc.Share.Framework.CustomTypeBase _, WizardGames.Soc.Share.Framework.CustomTypeBase oldRoot, WizardGames.Soc.Share.Framework.CustomTypeBase newRoot); // 0x072d2d30
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TerritoryDeadSheepComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1509258670;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072d2e7c
	System.String GetTypeName(); // 0x072d2ee4
	System.Int32 get_Id(); // 0x072d2f5c
	System.Void .ctor(); // 0x072d2fc0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072d304c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072d3144
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072d31f4
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.DeadSheepMission> get_MissionInfo(); // 0x072d3258
	System.Void set_MissionInfo(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.DeadSheepMission> value); // 0x072d32f8
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x072d3384
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x072d34e4
	static System.Object DeserializeTerritoryDeadSheepComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072d372c
	static System.Void .cctor(); // 0x072d38a0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TerritoryDoorComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1820312440;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072d3a60
	System.String GetTypeName(); // 0x072d3ac8
	System.Int32 get_Id(); // 0x072d3b40
	System.Void .ctor(); // 0x072d3ba4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072d3c30
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072d3ce0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072d3d90
	System.Void RemoteCallSetOnlyAutoCloseDoorEnable(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean onlyAutoColse); // 0x072d3df4
	System.Void RemoteCallChangeTerritoryCenterDoorsAutoOpen(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean state); // 0x072d3f7c
	static System.Void .cctor(); // 0x072d4104
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TerritoryOutsideComponent : WizardGames.Soc.Common.Component.OutsideDataSetComponent
{
	static System.Int32 CLASS_HASH = 44468567;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072d41f4
	System.String GetTypeName(); // 0x072d425c
	System.Int32 get_Id(); // 0x072d42d4
	System.Void .ctor(); // 0x072d4338
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072d43c4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072d4474
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072d4524
	System.Single get_RawPosX(); // 0x072d4588
	System.Single get_RawPosY(); // 0x072d45fc
	System.Single get_RawPosZ(); // 0x072d4670
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x072d46e4
	static System.Object DeserializeTerritoryOutsideComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072d4848
	static System.Void .cctor(); // 0x072d4970
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TerritoryPermissionComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 538103709;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072d4bcc
	System.String GetTypeName(); // 0x072d4c34
	System.Int32 get_Id(); // 0x072d4cac
	System.Void .ctor(); // 0x072d4d10
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072d4d9c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072d4eb8
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072d4f68
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.UInt64,System.Int32> get_Admins(); // 0x072d4fcc
	System.Void set_Admins(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.UInt64,System.Int32> value); // 0x072d506c
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.BuildingPrivilegeGroup> get_Groups(); // 0x072d50f8
	System.Void set_Groups(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.BuildingPrivilegeGroup> value); // 0x072d5198
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x072d5224
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x072d5384
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x072d56f4
	static System.Object DeserializeTerritoryPermissionComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072d651c
	System.Void OnAdminChange(System.UInt64 roleId, System.Boolean isAdd); // 0x072d5a3c
	System.Void OnAddToGroup(System.Collections.Generic.List<System.Int32> groupIds, System.UInt64 roleId); // 0x072d5da8
	System.Void OnDeleteFromGroup(System.Int32 groupId, System.UInt64 roleId); // 0x072d5f3c
	System.Void OnDeleteMemberCompletely(System.UInt64 roleId); // 0x072d60fc
	System.Void OnTerritoryCenterNameChanged(); // 0x072d6288
	WizardGames.Soc.Common.Entity.TerritoryEntity get_TerrEnt(); // 0x072d663c
	static System.Void .cctor(); // 0x072d66f8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TerritoryPlayComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 435472117;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072d67e8
	System.String GetTypeName(); // 0x072d6850
	System.Int32 get_Id(); // 0x072d68c8
	System.Void .ctor(); // 0x072d692c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072d69b8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072d6aa4
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072d6b54
	WizardGames.Soc.Common.CustomType.ETerritoryState get_State(); // 0x072d6bb8
	System.Int64 get_StateTimeSinceStartup(); // 0x072d6c2c
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.UInt64> get_AmityRoles(); // 0x072d6ca0
	System.Void set_AmityRoles(WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.UInt64> value); // 0x072d6d40
	System.Int64 get_AttackedTime(); // 0x072d6dcc
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x072d6e40
	static System.Object DeserializeTerritoryPlayComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072d7088
	static System.Void .cctor(); // 0x072d715c
	static System.Void OnTerritoryStateDataChange(WizardGames.Soc.Share.Framework.CustomTypeBase baseType, System.Int64 oldValue, System.Int64 newValue); // 0x072d745c
	WizardGames.Soc.Common.Entity.TerritoryEntity get_TerrEnt(); // 0x072d75f8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TerritoryPlunderComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1772751465;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072d76b4
	System.String GetTypeName(); // 0x072d771c
	System.Int32 get_Id(); // 0x072d7794
	System.Void .ctor(); // 0x072d77f8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072d7884
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072d7934
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072d79e4
	System.Int64 get_PlunderTs(); // 0x072d7a48
	static System.Void .cctor(); // 0x072d7abc
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TerritorySkinComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1102554152;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072d7b78
	System.String GetTypeName(); // 0x072d7be0
	System.Int32 get_Id(); // 0x072d7c58
	System.Void .ctor(); // 0x072d7cbc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072d7d48
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072d7e84
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072d7f34
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int32,System.Int64> get_DefaultBuildingCoreSkinIds(); // 0x072d7f98
	System.Void set_DefaultBuildingCoreSkinIds(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int32,System.Int64> value); // 0x072d8038
	System.Int64 get_LastBatchChangeTs(); // 0x072d80c4
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x072d8138
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x072d837c
	System.Void RemoteCallRequestChangeSkinBatch(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 grade, System.Int64 targetSkinNodeId, System.Boolean isDoorChanged); // 0x072d8c78
	static System.Object DeserializeTerritorySkinComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072d8e34
	System.Void PostInit(); // 0x072d8f54
	System.Void OnDefaultBuildingCoreSkinsUpdate(WizardGames.Soc.Share.Framework.ECustomDictOpType op, System.Int32 key, System.Int64 skinId); // 0x072d903c
	System.Void OnRequestChangeSkinBatch(System.Int32 result); // 0x072d8548
	static System.Void .cctor(); // 0x072d90cc
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TerritorySouDaJianComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1368805723;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072d9258
	System.String GetTypeName(); // 0x072d92c0
	System.Int32 get_Id(); // 0x072d9338
	System.Void .ctor(); // 0x072d939c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072d9428
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072d94d8
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072d9588
	static System.Void .cctor(); // 0x072d95ec
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TrainComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 2022762941;
	static System.Int32 StaticClassHash; // 0x0
	static System.String TYPE_NAME = "TrainComponent";
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072d96a8
	System.String GetTypeName(); // 0x072d9710
	System.Int32 get_Id(); // 0x072d9788
	System.Void .ctor(); // 0x072d97ec
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072d9878
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072d9928
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072d99d8
	static System.Object DeserializeTrainComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072d9a3c
	static System.Void .cctor(); // 0x072d9b0c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TransformComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 31;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072d9c98
	System.String GetTypeName(); // 0x072d9cfc
	System.Int32 get_Id(); // 0x072d9d74
	System.Void .ctor(); // 0x072d9dd8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072d9e64
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072d9f14
	System.Int32 get_UsedTimes(); // 0x072d9f78
	System.Int64 get_LastCostTimeTime(); // 0x072d9fec
	static System.Void .cctor(); // 0x072da060
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TrapComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 765247899;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072da14c
	System.String GetTypeName(); // 0x072da1b4
	System.Int32 get_Id(); // 0x072da22c
	System.Void .ctor(); // 0x072da290
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072da31c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072da3cc
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072da47c
	static System.Void .cctor(); // 0x072da4e0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.UgcArchiveComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1641040234;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072da638
	System.String GetTypeName(); // 0x072da6a0
	System.Int32 get_Id(); // 0x072da718
	System.Void .ctor(); // 0x072da77c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072da808
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072da8b8
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072da968
	System.Void set_Weight(System.Int32 value); // 0x072da9cc
	static System.Void .cctor(); // 0x072daa58
}

// Client.Runtime
class WizardGames.Soc.Common.Component.UgcComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 859082956;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Component.IModifyBuild> MoDic; // 0x10
	System.Int32 GetClassHash(); // 0x072dab14
	System.String GetTypeName(); // 0x072dab7c
	System.Int32 get_Id(); // 0x072dabf4
	System.Void .ctor(); // 0x072dac58
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072dace4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072dad94
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072dae44
	System.Int32 get_Number(); // 0x072daea8
	System.Void set_Number(System.Int32 value); // 0x072daf1c
	System.Int32 get_Weight(); // 0x072dafa8
	System.Void set_Weight(System.Int32 value); // 0x072db01c
	System.Single get_Scale(); // 0x072db0a8
	System.Void set_Scale(System.Single value); // 0x072db11c
	static System.Void .cctor(); // 0x072db1a8
	static System.Void RegisterModifyBuild<T>(System.Int32 propertyId, System.Action<WizardGames.Soc.Common.Component.UgcComponent,T> Set, System.Func<WizardGames.Soc.Common.Component.UgcComponent,T> Get); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.UgcComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.UgcComponent.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x072db5b0
	System.Void .ctor(); // 0x072db614
	System.Void <.cctor>b__27_0(WizardGames.Soc.Common.Component.UgcComponent obj, System.Int32 value); // 0x072db67c
	System.Int32 <.cctor>b__27_1(WizardGames.Soc.Common.Component.UgcComponent obj); // 0x072db7d0
	System.Void <.cctor>b__27_2(WizardGames.Soc.Common.Component.UgcComponent obj, System.Int32 value); // 0x072db850
	System.Int32 <.cctor>b__27_3(WizardGames.Soc.Common.Component.UgcComponent obj); // 0x072db918
	System.Void <.cctor>b__27_4(WizardGames.Soc.Common.Component.UgcComponent obj, System.Single value); // 0x072db998
	System.Single <.cctor>b__27_5(WizardGames.Soc.Common.Component.UgcComponent obj); // 0x072dbb38
}

// Client.Runtime
class WizardGames.Soc.Common.Component.UgcGameResultComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1680593153;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072dbbb8
	System.String GetTypeName(); // 0x072dbc20
	System.Int32 get_Id(); // 0x072dbc98
	System.Void .ctor(); // 0x072dbcfc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072dbd88
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072dbe38
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072dbee8
	static System.Void .cctor(); // 0x072dbf4c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.UgcMonsterSpawnComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1546759353;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072dbfd0
	System.String GetTypeName(); // 0x072dc038
	System.Int32 get_Id(); // 0x072dc0b0
	System.Void .ctor(); // 0x072dc114
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072dc1a0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072dc250
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072dc300
	static System.Void .cctor(); // 0x072dc364
}

// Client.Runtime
class WizardGames.Soc.Common.Component.UgcSpawnComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 648745504;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072dc420
	System.String GetTypeName(); // 0x072dc488
	System.Int32 get_Id(); // 0x072dc500
	System.Void .ctor(); // 0x072dc564
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072dc5f0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072dc6a0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072dc750
	System.Void set_Number(System.Int32 value); // 0x072db744
	static System.Void .cctor(); // 0x072dc7b4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.UGCTriggerRegionComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1338297859;
	static System.Int32 StaticClassHash; // 0x0
	static System.String TYPE_NAME = "UGCTriggerRegionComponent";
	static System.String[] PropNameArray; // 0x8
	WizardGames.Soc.Common.Component.UGCTriggerRegionCompEdit edit; // 0x38
	System.Int32 GetClassHash(); // 0x072dc870
	System.String GetTypeName(); // 0x072dc8d8
	System.Int32 get_Id(); // 0x072dc950
	System.Void .ctor(); // 0x072dc9b4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072dca40
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072dcb58
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072dcc08
	System.Int32 get_RegionColliderType(); // 0x072dcc6c
	WizardGames.Soc.Common.CustomType.CustomVector3 get_CustomScale(); // 0x072dcce0
	System.Void set_CustomScale(WizardGames.Soc.Common.CustomType.CustomVector3 value); // 0x072dbaac
	System.String get_UGCIdentityTag(); // 0x072dcda4
	System.String get_EnterEvent(); // 0x072dce18
	System.String get_ExitEvent(); // 0x072dce8c
	System.String get_StayEvent(); // 0x072dcf00
	System.Int32 get_DataVersion(); // 0x072dcf74
	static System.Void .cctor(); // 0x072dcfe8
	static System.Void OnDataVersionChanged(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Int32 oldValue, System.Int32 newValue); // 0x072dd280
	System.Void OnGoLoaded(); // 0x072dd35c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.VehicleComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 1023428497;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072dd3dc
	System.String GetTypeName(); // 0x072dd444
	System.Int32 get_Id(); // 0x072dd4bc
	System.Void .ctor(); // 0x072dd520
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072dd5ac
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072dd65c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072dd70c
	System.UInt64 get_OwnerId(); // 0x072dd770
	System.Int32 get_LastBuyTs(); // 0x072dd7e4
	System.Void PostInit(); // 0x072dd858
	static System.Void .cctor(); // 0x072dd8cc
}

// Client.Runtime
class WizardGames.Soc.Common.Component.VehicleDamageableComponent : WizardGames.Soc.Common.Component.DamageableComponent
{
	static System.Int32 CLASS_HASH = 303247695;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072dda24
	System.String GetTypeName(); // 0x072dda8c
	System.Int32 get_Id(); // 0x072ddb04
	System.Void .ctor(); // 0x072ddb68
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072ddbf4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072ddca4
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072ddd54
	static System.Void .cctor(); // 0x072dddb8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.VehicleShopComponent : WizardGames.Soc.Common.Component.NpcShopComponent
{
	static System.Int32 CLASS_HASH = 2095239903;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072ddfe0
	System.String GetTypeName(); // 0x072de048
	System.Int32 get_Id(); // 0x072de0c0
	System.Void .ctor(); // 0x072de124
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072de1b0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072de260
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072de310
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x072de374
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x072de4d4
	static System.Object DeserializeVehicleShopComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072de72c
	System.Void PostInit(); // 0x072de850
	System.Void OpenShopUi(); // 0x072de8b8
	static System.Void .cctor(); // 0x072de998
}

// Client.Runtime
class WizardGames.Soc.Common.Component.VendingMachineComponent : WizardGames.Soc.Common.Component.StorageComponent, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler
{
	static System.Int32 CLASS_HASH = 1092902034;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x38
	UnityEngine.Transform objTrans; // 0x40
	UnityEngine.Transform playerTrans; // 0x48
	WizardGames.Soc.Common.Data.Item.Shop vendingMachineConfig; // 0x50
	System.String uiRootKey; // 0x58
	UnityEngine.GameObject uiRoot; // 0x60
	System.String iconLoaderKey; // 0x68
	System.String storageNumTextKey; // 0x70
	System.String saleNumTextKey; // 0x78
	System.String priceNumTexttKey; // 0x80
	System.String priceItemTextKey; // 0x88
	System.String showUseStateAnimKey; // 0x90
	System.String useStateLoopAnimKey; // 0x98
	System.String hideUseStateAnimKey; // 0xa0
	System.String soldOutGroupKey; // 0xa8
	System.String showControlKey; // 0xb0
	FairyGUI.GLoader iconLoader; // 0xb8
	FairyGUI.GTextField saleNumText; // 0xc0
	FairyGUI.GTextField priceNumText; // 0xc8
	FairyGUI.GTextField priceItemText; // 0xd0
	FairyGUI.GGroup soldOutGroup; // 0xd8
	FairyGUI.Controller showController; // 0xe0
	FairyGUI.Controller UseState; // 0xe8
	FairyGUI.Transition showUseStateAnim; // 0xf0
	FairyGUI.Transition useStateLoopAnim; // 0xf8
	FairyGUI.Transition hideUseStateAnim; // 0x100
	System.Int64 timerID; // 0x108
	System.Boolean isUse; // 0x110
	System.Int32 iconShowIndex; // 0x114
	static System.Int32 CRTisRed; // 0x10
	FairyGUI.UIPanel uiPanel; // 0x118
	WizardGames.Soc.Common.CustomType.ItemContainerNode goodsNode; // 0x120
	System.String shopOwnerName; // 0x128
	WizardGames.Soc.Common.Component.VendingMachineComponent.OnShopItemBuyCallBack shopItemBuyCallBack; // 0x130
	WizardGames.Soc.Common.Component.VendingMachineComponent.OnShopRenameCallBack ShopRenameCallBack; // 0x138
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> Stocks; // 0x140
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PriceItem> PriceItemList; // 0x148
	System.Int32 GetClassHash(); // 0x072deb8c
	System.String GetTypeName(); // 0x072debf4
	System.Int32 get_Id(); // 0x072dec6c
	System.Void .ctor(); // 0x072decd0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072def8c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072df2a8
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072df57c
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.PriceItem> get_PriceItemDt(); // 0x072df5e0
	System.Void set_PriceItemDt(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.PriceItem> value); // 0x072df680
	System.Boolean get_MarkOpen(); // 0x072df70c
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x072df780
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x072df8e0
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x072dfb28
	System.Void RemoteCallEditPriceItem(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.IList<WizardGames.Soc.Common.CustomType.PriceItem> newItems, System.Collections.Generic.IList<System.Int64> delItems, System.Collections.Generic.IList<WizardGames.Soc.Common.CustomType.PriceItem> modifyItems); // 0x072dfd44
	System.Void RemoteCallBuy(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 priceId, System.Int32 num); // 0x072dff00
	System.Void RemoteCallRename(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.String name); // 0x072e0094
	System.Void RemoteCallSetMarkOpen(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean open); // 0x072e021c
	static System.Object DeserializeVendingMachineComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072e03a4
	WizardGames.Soc.Common.Entity.PartEntity get_partEntity(); // 0x072e0474
	System.String get_Name(); // 0x072e052c
	System.Int32 get_ItemCount(); // 0x072e0650
	WizardGames.Soc.Common.Entity.PartEntity get_parentPartEntity(); // 0x072e0760
	System.Void Init(); // 0x072e0818
	System.Void PostInit(); // 0x072e0dcc
	System.Void Cleanup(); // 0x072e1468
	System.Void LoadingPriceItemList(); // 0x072e094c
	System.Void LoadOwnerName(); // 0x072e1338
	System.Void RegisterShopItemBuyCallBack(WizardGames.Soc.Common.Component.VendingMachineComponent.OnShopItemBuyCallBack callback); // 0x072e179c
	System.Void RegisterShopRenameCallBack(WizardGames.Soc.Common.Component.VendingMachineComponent.OnShopRenameCallBack callBack); // 0x072e1830
	System.Void BuyAck(System.Int64 priceId, System.Int32 num, System.Int32 result); // 0x072e18c4
	System.Void UpdateStockData(); // 0x072e0fc0
	System.Void OnGoLoaded(); // 0x055049cc
	System.Void InitUIComponent(); // 0x072e1e60
	System.Void SetController(FairyGUI.Controller ctr, System.String page, System.Boolean directly); // 0x072e2308
	System.Void Tick(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x072e241c
	System.Void PlayAudio(System.Boolean isPlay); // 0x072e1670
	System.Void OnUseStateChanged(System.Int32 lootCount); // 0x072e2960
	System.Void StopAnim(FairyGUI.Transition anim); // 0x072e2ac4
	System.Void PlayAnim(FairyGUI.Transition anim, System.Action callback); // 0x072e2c20
	System.Void OnShowAnimPlayComplete(); // 0x072e2e00
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x072e2e6c
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x072e2ee0
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x072e3260
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x072e32d4
	static System.Void .cctor(); // 0x072e3384
	System.Void <Init>b__78_0(); // 0x072e34d8
	System.Void <PostInit>b__79_0(); // 0x072e3580
	System.Void <PostInit>b__79_1(WizardGames.Soc.Share.Framework.CustomTypeBase _, WizardGames.Soc.Share.Framework.CustomTypeBase oldRoot, WizardGames.Soc.Share.Framework.CustomTypeBase newRoot); // 0x072e3628
	System.Void <PostInit>b__79_2(); // 0x072e3820
	System.Void <LoadOwnerName>b__82_0(SimpleJSON.JSONNode result); // 0x072e38c8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.VendingMachineComponent.OnShopItemBuyCallBack : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x072e3988
	System.Void Invoke(System.Int64 priceId, System.Int32 num, System.Int32 result); // 0x072e3a50
}

// Client.Runtime
class WizardGames.Soc.Common.Component.VendingMachineComponent.OnShopRenameCallBack : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x072e3ab4
	System.Void Invoke(System.Int32 result); // 0x072e3b7c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.VendingMachineComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.VendingMachineComponent.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.CustomType.PriceItem> <>9__81_0; // 0x8
	static System.Void .cctor(); // 0x072e3bc8
	System.Void .ctor(); // 0x072e3c2c
	System.Int32 <LoadingPriceItemList>b__81_0(WizardGames.Soc.Common.CustomType.PriceItem item1, WizardGames.Soc.Common.CustomType.PriceItem item2); // 0x072e3c94
}

// Client.Runtime
class WizardGames.Soc.Common.Component.VendingMachineComponent.<>c__DisplayClass94_0 : System.Object
{
	WizardGames.Soc.Common.Component.VendingMachineComponent <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x072e2d98
	System.Void <PlayAnim>b__0(); // 0x072e3d54
}

// Client.Runtime
class WizardGames.Soc.Common.Component.WardrobeComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 258993697;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072e3e30
	System.String GetTypeName(); // 0x072e3e98
	System.Int32 get_Id(); // 0x072e3f10
	System.Void .ctor(); // 0x072e3f74
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072e4000
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072e40b0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072e4160
	System.Void RemoteCallExchange(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 slotIndex); // 0x072e41c4
	static System.Void .cctor(); // 0x072e434c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.WaterCatcherComponent : WizardGames.Soc.Common.Component.WaterFacilityComponent
{
	static System.Int32 CLASS_HASH = 1825793545;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072e4408
	System.String GetTypeName(); // 0x072e4470
	System.Int32 get_Id(); // 0x072e44e8
	System.Void .ctor(); // 0x072e454c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072e4660
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072e47bc
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072e4918
	WizardGames.Soc.Common.Data.Item.WaterCatcherConfig get_Config(); // 0x072e497c
	System.Int32 GetCatchWater(System.Int32 count); // 0x072e4b3c
	System.Boolean IsRain(); // 0x072e4cf0
	System.Boolean IsSnow(); // 0x072e4d54
	System.Boolean IsFog(); // 0x072e4c8c
	static System.Void .cctor(); // 0x072e4db8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.WaterFacilityComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 519760955;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	WizardGames.Soc.Common.CustomType.ItemContainerNode pureItemContainerNode; // 0x38
	WizardGames.Soc.Common.CustomType.ItemContainerNode saltItemContainerNode; // 0x40
	WizardGames.Soc.Common.CustomType.ItemContainerNode anyItemContainerNode; // 0x48
	WizardGames.Soc.Common.CustomType.ItemContainerNode defaultContainer; // 0x50
	System.Int32 GetClassHash(); // 0x072e4e74
	System.String GetTypeName(); // 0x072e4edc
	System.Int32 get_Id(); // 0x072e4f54
	System.Void .ctor(); // 0x072e45d4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072e470c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072e4868
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072e4fb8
	System.Void RemoteCallDrinkWater(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 containerNodeId, System.Int32 count); // 0x072e501c
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x072e4a84
	System.Void PostInit(); // 0x072e51b0
	WizardGames.Soc.Common.CustomType.NodeBase GetWaterContainer(System.Int64 index); // 0x072e5498
	WizardGames.Soc.Common.CustomType.StackableItemNode GetWaterItem(System.Int64 index); // 0x072e5520
	System.Int64 GetDefaultWaterBizId(System.Int64 index); // 0x072e5604
	System.Int32 GetWaterAmount(System.Int64 index); // 0x072e5790
	System.Int32 GetWaterMax(System.Int64 index); // 0x072e5830
	static System.Void .cctor(); // 0x072e5938
}

// Client.Runtime
class WizardGames.Soc.Common.Component.WildOutsideComponent : WizardGames.Soc.Common.Component.OutsideDataSetComponent
{
	static System.Int32 CLASS_HASH = 626757539;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072e59f4
	System.String GetTypeName(); // 0x072e5a5c
	System.Int32 get_Id(); // 0x072e5ad4
	System.Void .ctor(); // 0x072e5b38
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072e5bc4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072e5c74
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072e5d24
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x072e5d88
	static System.Object DeserializeWildOutsideComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072e5eec
	static System.Void .cctor(); // 0x072e6014
}

// Client.Runtime
class WizardGames.Soc.Common.Component.BaseComponentLocal : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = -1;
	static System.Int32 StaticClassHash; // 0x0
	WizardGames.Soc.Common.Framework.Const.ESyncRange <SyncRange>k__BackingField; // 0x34
	SimpleJSON.JSONNode ToEJson(); // 0x072e61d4
	System.Void FromEJson(SimpleJSON.JSONNode jsonObj); // 0x072e6260
	System.Int32 GetClassHash(); // 0x072e62d4
	System.Void .ctor(); // 0x072e6338
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072e63c4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x072e6428
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x072e64c8
	System.String GetTypeName(); // 0x072e6578
	static System.Void .cctor(); // 0x072e65f0
}

// Client.Runtime
enum WizardGames.Soc.Common.Component.ClickSleepingBagType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Component.ClickSleepingBagType GiveToFriend = 218;
	static WizardGames.Soc.Common.Component.ClickSleepingBagType AddPermission = 227;
	static WizardGames.Soc.Common.Component.ClickSleepingBagType SetPublic = 228;
	static WizardGames.Soc.Common.Component.ClickSleepingBagType SetPrivate = 229;
	static WizardGames.Soc.Common.Component.ClickSleepingBagType Delete = 530;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ColliderComponentClient : WizardGames.Soc.Common.Component.CommonColliderComponentUnity
{
	
	System.Void CreateColliderData(); // 0x072e663c
	System.Void RemoveColliderData(); // 0x072e6710
	System.Void .ctor(); // 0x072e67f0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ConstructionRenderComponent : WizardGames.Soc.Common.Component.BaseComponentLocal
{
	System.Int32 <CurrentGrade>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.Manager.BuildingEntityInfo buildingEntityInfo; // 0x40
	static System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.ConstructionConditionalModel> tmpConditionModules; // 0x0
	System.Collections.Generic.List<System.Int32> gpuInstanceIds; // 0x48
	System.Int32 get_Id(); // 0x072e6858
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x072e68bc
	System.Int32 get_CurrentGrade(); // 0x072e6974
	System.Void set_CurrentGrade(System.Int32 value); // 0x072e69d8
	System.Void OnGoLoaded(); // 0x072e6a50
	System.Void Cleanup(); // 0x072e6c58
	System.Void ShowRender(); // 0x072e6ac0
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.MeshTRSData> GetMeshDataList(); // 0x072e70c0
	System.Boolean AddMeshRenderData(System.String meshPath, UnityEngine.Vector3 pos, UnityEngine.Quaternion rotation, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.MeshTRSData>& resultDatas); // 0x072e77f8
	System.Void CleanRender(); // 0x072e6cc8
	System.Void ShowUnityGoRender(); // 0x072e7060
	System.Void ClearUnityGoRender(); // 0x072e7bd8
	System.Void RefreshGrade(); // 0x072e7ce8
	System.Void RefreshSkinId(); // 0x072e7dc8
	System.Void RefreshAdditionInfo(); // 0x072e7e2c
	System.Void AfterChangePartGoTransform(); // 0x072e7e90
	System.Void RefreshRecoveringState(); // 0x072e7ffc
	System.Void RefreshRecoveringGPUState(); // 0x072e8060
	System.Void ShowGPUInstanceRender(WizardGames.Soc.Common.Unity.Construction.TemplateGoConfig templateGoConfig); // 0x072e6d80
	System.Void ClearGpuInstanceRender(); // 0x072e7c38
	System.Void EnableOutline(UnityEngine.Color color, System.Single dilateShift, System.Single blurShift, System.Int32 lodLevel); // 0x072e8104
	System.Void DisableOutline(); // 0x072e8210
	System.Void .ctor(); // 0x072e8288
	static System.Void .cctor(); // 0x072e835c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ConstructionRenderData : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	static SocLogger logger; // 0x0
	System.Boolean submitButNotRender; // 0x1a
	System.Boolean isLoadingMeshRender; // 0x1b
	System.Int64 entityId; // 0x20
	WizardGames.Soc.Common.Unity.Construction.MeshRenderConfig meshRenderConfig; // 0x28
	System.String meshPath; // 0x30
	System.Int64 key; // 0x38
	UnityEngine.Vector3 pos; // 0x40
	UnityEngine.Quaternion rotation; // 0x4c
	UnityEngine.Vector3 scale; // 0x5c
	UnityEngine.Color emissionColor; // 0x68
	System.Int32 gpuInstanceId; // 0x78
	System.Int32 state; // 0x7c
	UnityEngine.Vector3 localPos; // 0x80
	UnityEngine.Quaternion localRotation; // 0x8c
	System.Collections.Generic.List<System.Int32> SubNodesInstanceIdLst; // 0xa0
	UnityEngine.Vector3 get_RenderPos(); // 0x072e83f4
	UnityEngine.Quaternion get_RenderRotation(); // 0x072e8498
	System.Void set_State(System.Int32 value); // 0x072e85f0
	System.Void Clear(); // 0x072e8674
	System.Void SubmitToRender(WizardGames.Soc.Common.Unity.Construction.MeshRenderConfig meshRenderConfig); // 0x072e89b8
	System.Void Submit(); // 0x072e8a70
	System.Void UnSubmit(); // 0x072e88b8
	static WizardGames.Soc.Common.Component.ConstructionRenderData Generate(); // 0x072e8c44
	System.Void ReleaseToPool(); // 0x072e8cbc
	System.Void .ctor(); // 0x072e8ec8
	static System.Void .cctor(); // 0x072e8f7c
}

// Client.Runtime
enum WizardGames.Soc.Common.Component.EPlacementState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Component.EPlacementState Invalid = 0;
	static WizardGames.Soc.Common.Component.EPlacementState Neutral = 1;
	static WizardGames.Soc.Common.Component.EPlacementState Valid = 2;
	static WizardGames.Soc.Common.Component.EPlacementState Invalid_InWater = 3;
	static WizardGames.Soc.Common.Component.EPlacementState Neutral_InWater = 4;
	static WizardGames.Soc.Common.Component.EPlacementState Valid_InWater = 5;
	static WizardGames.Soc.Common.Component.EPlacementState None = 6;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Component.DeployComponent : WizardGames.Soc.Common.Component.BaseComponentLocal
{
	WizardGames.Soc.Common.Component.DeployComponent.EAutoTurretDirect curAutoTurretPrebuildDirect; // 0x38
	UnityEngine.Renderer[] meshList; // 0x40
	UnityEngine.Color32 wallBlueBlue; // 0x48
	UnityEngine.Color32 wallBlueRed; // 0x4c
	System.Int32 comboId; // 0x50
	WizardGames.Soc.Common.Component.EPlacementState lastPlacementState; // 0x54
	UnityEngine.GameObject meshRoot; // 0x58
	UnityEngine.Vector3 position; // 0x60
	System.String replacePrebuildGoPath; // 0x70
	System.Action InstantiateAsyncComplete; // 0x78
	System.Int32 toolBoxMode; // 0x80
	System.UInt64 loadReplacePrebuildGoAsyncId; // 0x88
	static System.String[] towardStr; // 0x0
	UnityEngine.GameObject replacePrebuildGo; // 0x90
	WizardGames.Soc.SocClient.Construction.FaceShowFx <FaceShowFx>k__BackingField; // 0x98
	WizardGames.Soc.SocClient.Construction.RangeShowFx <RangeShowFx>k__BackingField; // 0xa0
	UnityEngine.GameObject holdingGameObject; // 0xa8
	System.String prefabPath; // 0xb0
	System.UInt64 _loadPrefabAsyncId; // 0xb8
	System.Int32 get_Id(); // 0x072e9050
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x072e90b4
	System.Void set_Position(UnityEngine.Vector3 value); // 0x072e916c
	System.Void add_InstantiateAsyncComplete(System.Action value); // 0x072e9204
	System.Void remove_InstantiateAsyncComplete(System.Action value); // 0x072e92dc
	System.Void set_ToolBoxMode(System.Int32 value); // 0x072e93b4
	System.Int32 get_ComboId(); // 0x072e942c
	System.Void set_ComboId(System.Int32 value); // 0x072e9490
	WizardGames.Soc.SocClient.Construction.FaceShowFx get_FaceShowFx(); // 0x072e9508
	WizardGames.Soc.SocClient.Construction.RangeShowFx get_RangeShowFx(); // 0x072e956c
	System.Boolean get_CanPlaceAtMaxDistance(); // 0x072e95d0
	UnityEngine.Vector3 get_CombineFixPos(); // 0x072e970c
	System.Void ClearForToolCupboard(); // 0x072e98f0
	System.Void TrySetPrebuild(); // 0x072e9b18
	System.Void ClearReplacePrebuildGo(); // 0x072e9f3c
	System.Void Init(); // 0x072ea184
	UnityEngine.GameObject get_HoldingGameObject(); // 0x072ea3fc
	System.Void InstantiateAsync(); // 0x072ea1f4
	System.Void OnPreBuildLoadFinish(UnityEngine.GameObject go, System.Object[] arg); // 0x072ea460
	System.Void SetToolBoxMode(System.Int32 toolBoxMode); // 0x072ea888
	System.Void TryShowNode(UnityEngine.GameObject skinNode, System.String nodeName); // 0x072eafd8
	System.Void TryHideNode(UnityEngine.GameObject skinNode, System.String nodeName); // 0x072eaeac
	System.Void Cleanup(); // 0x072eb108
	System.Void IntoEditMode(); // 0x072eaa94
	System.Void SetWallEditColor(System.Boolean canBuild, System.Boolean isInWater); // 0x072eb36c
	System.Void SetMainGoMeshRenderer(System.Boolean active); // 0x072eb774
	System.Boolean ShowAsNeutralNoMono(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget target); // 0x072eb884
	System.Void SetPlaceState(WizardGames.Soc.Common.Component.EPlacementState placementState, System.Boolean force); // 0x072eba1c
	System.Void SetPlaceState(System.Boolean valid, System.Boolean isInWater); // 0x072ebd78
	System.Void SetEditMatBlue(System.Boolean isInWater); // 0x072eb234
	System.Void SetEditMatOrange(System.Boolean isInWater); // 0x072ebca8
	System.Void SetEditMatRed(System.Boolean isInWater); // 0x072ebb6c
	System.Void SetRenderersMaterial(UnityEngine.Renderer[] renderers, WizardGames.AssetPool.AssetPoolHandle material); // 0x072ebe20
	static System.Boolean CheckBuildPermission(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target, System.Int64 partType, UnityEngine.Vector3 pos, System.Boolean silent); // 0x072ec014
	static System.Boolean CheckDeployOverlapNoMono(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target, System.Int64 partType, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, WizardGames.Soc.Common.Entity.PartEntity ignorePart); // 0x072ec2e4
	System.Void RemoveGo(); // 0x072ec604
	System.Void CancelColliderAsyncLoad(); // 0x072ec7bc
	static System.Boolean CheckCanPlace(System.Int64 roleId, WizardGames.Soc.Common.Entity.PartEntity partEntity, UnityEngine.Vector3 playerPos, System.Single maxDistance, WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Bounds bounds, WizardGames.Soc.Common.Entity.PartEntity ignorePart); // 0x072ec858
	System.Void .ctor(); // 0x072ecc78
	static System.Void .cctor(); // 0x072ecd98
	System.Void <TrySetPrebuild>b__43_0(UnityEngine.GameObject instGo, System.Object[] owner); // 0x072ece0c
}

// Client.Runtime
enum WizardGames.Soc.Common.Component.DeployComponent.EAutoTurretDirect : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Component.DeployComponent.EAutoTurretDirect Forward = 0;
	static WizardGames.Soc.Common.Component.DeployComponent.EAutoTurretDirect Back = 1;
	static WizardGames.Soc.Common.Component.DeployComponent.EAutoTurretDirect Left = 2;
	static WizardGames.Soc.Common.Component.DeployComponent.EAutoTurretDirect Right = 3;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Component.DestroyEffectComponent : WizardGames.Soc.Common.Component.BaseComponentLocal
{
	
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x072ed058
	System.Int32 get_Id(); // 0x072ed110
	System.Void PartDestroyEvent(); // 0x072ed174
	System.Void StopAllAudio(); // 0x072ed1d8
	System.Void .ctor(); // 0x072ed5a0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricCeilingLightComponent : WizardGames.Soc.Common.Component.BaseComponentLocal, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	WizardGames.Soc.Common.Component.ConstructionFlagComponent flagComp; // 0x38
	System.Int64 templateId; // 0x40
	UnityEngine.Transform onTrans; // 0x48
	UnityEngine.Transform offTrans; // 0x50
	Effect.EffectItemHandle<Effect.EffectItem> effectItemHandle; // 0x58
	UnityEngine.Transform effectTransform; // 0x68
	UnityEngine.GameObject <Obj>k__BackingField; // 0x70
	WizardGames.Soc.SocClient.Construction.ConstructionEffectPlay effectPlayer; // 0x78
	WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer gpuInstContainer; // 0x80
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x88
	System.Int32 get_Id(); // 0x072ed628
	UnityEngine.GameObject get_Obj(); // 0x072ed68c
	System.Void set_Obj(UnityEngine.GameObject value); // 0x072ed6f0
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x072ed770
	System.Void OnGoLoaded(); // 0x072ed828
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x072ed990
	System.Void InitInstanceToggleGroup(); // 0x072edfa0
	System.Void OnSkinGoRemove(); // 0x072ee210
	System.Void Cleanup(); // 0x072ee270
	System.Void OnFlagChanged(System.Int32 oldVal, System.Int32 newVal); // 0x072ee14c
	System.Void SetSwitch(System.Boolean on, System.Boolean isInit); // 0x072ee3fc
	System.Void .ctor(); // 0x072ee6f0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricFlasherLightComponent : WizardGames.Soc.Common.Component.BaseComponentLocal, WizardGames.Soc.Common.Construction.IChangeTransform, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	WizardGames.Soc.Common.Component.ConstructionFlagComponent flagComp; // 0x38
	System.Int64 templateId; // 0x40
	UnityEngine.GameObject obj; // 0x48
	UnityEngine.GameObject OnMesh; // 0x50
	UnityEngine.GameObject OffMesh; // 0x58
	UnityEngine.Transform effectTransform; // 0x60
	WizardGames.Soc.SocClient.Construction.ConstructionEffectPlay effectPlayer; // 0x68
	System.Boolean hasPower; // 0x70
	System.Int32 get_Id(); // 0x072ee7b0
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x072ee814
	System.Void OnGoLoaded(); // 0x072ee8cc
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x072eea58
	System.Void OnSkinGoRemove(); // 0x072eefe4
	System.Void Cleanup(); // 0x072ef044
	System.Void OnFlagChanged(System.Int32 lastFlag, System.Int32 newFlag); // 0x072eee78
	System.Void OnTransformChanged(); // 0x072ef14c
	System.Void .ctor(); // 0x072ef1c4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricFurnaceFireFxComponent : WizardGames.Soc.Common.Component.BaseComponentLocal, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	UnityEngine.GameObject enableGo; // 0x38
	UnityEngine.GameObject disableGo; // 0x40
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x48
	WizardGames.Soc.SocClient.Construction.ConstructionEffectPlay effectPlayer; // 0x50
	System.Int32 get_Id(); // 0x072ef24c
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x072ef2b0
	System.Void OnGoLoaded(); // 0x072ef368
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x072ef530
	System.Void LightUp(System.Boolean isOpen, System.Boolean flagChange); // 0x072ef5f4
	System.Void Cleanup(); // 0x072ef770
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x072ef810
	System.Void OnSkinGoRemove(); // 0x072efd78
	System.Void InitInstanceToggleGroup(); // 0x072efa54
	System.Void .ctor(); // 0x072efe08
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricSirenLightComponent : WizardGames.Soc.Common.Component.BaseComponentLocal, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	WizardGames.Soc.Common.Component.ConstructionFlagComponent flagComp; // 0x38
	System.Int64 templateId; // 0x40
	UnityEngine.GameObject obj; // 0x48
	UnityEngine.GameObject OnMesh; // 0x50
	UnityEngine.GameObject OffMesh; // 0x58
	UnityEngine.Transform effectTransform; // 0x60
	WizardGames.Soc.SocClient.Construction.ConstructionEffectPlay effectPlayer; // 0x68
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x70
	System.Boolean hasPower; // 0x78
	System.Int32 get_Id(); // 0x072eff0c
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x072eff70
	System.Void OnGoLoaded(); // 0x072f0028
	System.Void Cleanup(); // 0x072f00bc
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x072f0248
	System.Void OnSkinGoRemove(); // 0x072f0dd0
	System.Void InitInstanceToggleGroup(); // 0x072f07f0
	System.Void OnFlagChanged(System.Int32 lastFlag, System.Int32 newFlag); // 0x072f0aa0
	System.Void .ctor(); // 0x072f0eb8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.FireEffectByModuleStateComponent : WizardGames.Soc.Common.Component.BaseComponentLocal, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	UnityEngine.GameObject enableGo; // 0x38
	UnityEngine.GameObject disableGo; // 0x40
	UnityEngine.Transform mainTrans; // 0x48
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x50
	WizardGames.Soc.SocClient.Construction.ConstructionEffectPlay effectPlayer; // 0x58
	System.Int64 switchChangeEventHandle; // 0x60
	System.Int32 get_Id(); // 0x072f0f78
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x072f0fdc
	System.Void OnGoLoaded(); // 0x072f1094
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x072f12e4
	System.Void OnSwitchChangeEvent(WizardGames.Soc.Common.Event.SwitchChangeEvent evt); // 0x072f1554
	System.Void LightUp(System.Boolean isOpen, System.Boolean flagChange); // 0x072f13d8
	System.Void Cleanup(); // 0x072f1604
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x072f1734
	System.Void OnSkinGoRemove(); // 0x072f1d3c
	System.Void InitInstanceToggleGroup(); // 0x072f1a18
	System.Void .ctor(); // 0x072f1dcc
}

// Client.Runtime
enum WizardGames.Soc.Common.Component.EBuildEditInteractiveType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Component.EBuildEditInteractiveType RepairAll = 307;
	static WizardGames.Soc.Common.Component.EBuildEditInteractiveType BuildUpgrade = 400;
	static WizardGames.Soc.Common.Component.EBuildEditInteractiveType BuildRepair = 401;
	static WizardGames.Soc.Common.Component.EBuildEditInteractiveType BuildRotate = 402;
	static WizardGames.Soc.Common.Component.EBuildEditInteractiveType BuildPickup = 403;
	static WizardGames.Soc.Common.Component.EBuildEditInteractiveType BuildDestroy = 404;
	static WizardGames.Soc.Common.Component.EBuildEditInteractiveType ElectricClearWire = 405;
	static WizardGames.Soc.Common.Component.EBuildEditInteractiveType DeployUpgrade = 406;
	static WizardGames.Soc.Common.Component.EBuildEditInteractiveType DeployMove = 407;
	static WizardGames.Soc.Common.Component.EBuildEditInteractiveType SwitchSocket = 514;
	static WizardGames.Soc.Common.Component.EBuildEditInteractiveType BuildComboUpgrade = 516;
	static WizardGames.Soc.Common.Component.EBuildEditInteractiveType BuildModify = 517;
	static WizardGames.Soc.Common.Component.EBuildEditInteractiveType Electric = 161;
	static WizardGames.Soc.Common.Component.EBuildEditInteractiveType Water = 162;
	static WizardGames.Soc.Common.Component.EBuildEditInteractiveType UGCInspector = 800;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Component.InteractiveComponent : WizardGames.Soc.Common.Component.BaseComponentLocal
{
	System.Single lastBtnListTime; // 0x38
	System.Collections.Generic.List<System.Int32> uiBtnList; // 0x40
	System.Collections.Generic.List<System.Int32> buildModeIdList; // 0x48
	System.Collections.Generic.List<System.Int32> commonIdList; // 0x50
	WizardGames.Soc.SocClient.Ui.UiHud get_UiHud(); // 0x072f1ed0
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x072f1fd8
	System.Int32 get_Id(); // 0x072f2090
	System.Collections.Generic.List<System.Int32> GetUiBtnList(); // 0x072f20f4
	System.Boolean get_NeedRepair(); // 0x072f24bc
	System.Collections.Generic.List<System.Int32> GetUiBtnListAtBeta1BuildMode(); // 0x072f256c
	System.Collections.Generic.List<System.Int32> GetCommonUiBtnList(); // 0x072f291c
	System.Boolean CheckWarDrumsCanInteractive(); // 0x072f31dc
	System.Collections.Generic.List<System.Int32> GetUiBtnList(System.Collections.Generic.List<WizardGames.Soc.SocClient.EHudState> curHudStates); // 0x072f2380
	System.Void BuildEditOnClick(System.Int32 btnId); // 0x072f3410
	System.Void OnUiBtnClicked(System.Int32 btnId, System.Boolean& permissionCheckRst); // 0x072f3924
	System.Void .ctor(); // 0x072f3f50
	System.Void <OnUiBtnClicked>b__19_0(WizardGames.Soc.SocClient.Ui.UiUGCInspector win); // 0x072f4078
}

// Client.Runtime
enum WizardGames.Soc.Common.Component.LightEffectByFlagType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Component.LightEffectByFlagType Working = 1;
	static WizardGames.Soc.Common.Component.LightEffectByFlagType ElectricPower = 2;
	static WizardGames.Soc.Common.Component.LightEffectByFlagType Switch = 3;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Component.LightEffectByFlagComponent : WizardGames.Soc.Common.Component.BaseComponentLocal, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	UnityEngine.Transform lightRoot; // 0x38
	WizardGames.Soc.Common.Component.LightEffectByFlagType lightEffectType; // 0x40
	System.Int32 get_Id(); // 0x072f4128
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x072f418c
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x072f4244
	System.Void OnSwitchChangeEvent(WizardGames.Soc.Common.Event.SwitchChangeEvent evt); // 0x072f4898
	System.Void RefreshBySwitch(); // 0x072f46e8
	System.Void RefreshByFlag(); // 0x072f4550
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x072f4b0c
	System.Void LightUp(System.Boolean open); // 0x072f4940
	System.Void OnSkinGoRemove(); // 0x072f4ce4
	System.Void .ctor(); // 0x072f4d50
}

// Client.Runtime
class WizardGames.Soc.Common.Component.MixingFireFxComponent : WizardGames.Soc.Common.Component.BaseComponentLocal, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	System.Collections.Generic.List<Effect.EffectItemHandle<Effect.EffectItem>> mMixingTableFireEffect; // 0x38
	System.Boolean mixingFlag; // 0x40
	System.Int32 get_Id(); // 0x072f4dd8
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x072f4e3c
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x072f4ef4
	System.Void OnSkinGoRemove(); // 0x072f545c
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x072f56b4
	System.Void HandleMixingState(System.Boolean isMixing); // 0x072f5010
	System.Void LoadMixingTableEffect(UnityEngine.Transform root, System.Int32 templateID); // 0x072f575c
	System.Void ReleaseMixingTableEffect(); // 0x072f5534
	System.Void .ctor(); // 0x072f5988
}

// Client.Runtime
class WizardGames.Soc.Common.Component.MixingTableComponent : WizardGames.Soc.Common.Component.StorageComponent, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	System.Action ActionStartMixSuccess; // 0x38
	System.Action<System.Int32> ActionFinishMixSuccess; // 0x40
	System.Action ActionPickupSuccess; // 0x48
	System.Action ActionDestroy; // 0x50
	UnityEngine.Transform mMixingTableFire01Root; // 0x58
	UnityEngine.Transform mMixingTableFire02Root; // 0x60
	System.Collections.Generic.List<Effect.EffectItemHandle<Effect.EffectItem>> mMixingTableFireEffect; // 0x68
	System.Boolean mixingFlag; // 0x70
	System.Void PostInit(); // 0x072f5ac4
	System.Void Cleanup(); // 0x072f5b2c
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x072f5bf0
	System.Void OnSkinGoRemove(); // 0x072f5ed0
	static System.Void .cctor(); // 0x072f60c0
	static System.Void OnIsOpenChange(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int32 oldValue, System.Int32 newValue); // 0x072f617c
	System.Void RefreshModuleState(System.Boolean isInit, System.Int32 oldValue, System.Int32 newValue); // 0x072f5cfc
	System.Void HandleMixingState(System.Boolean isMixing); // 0x072f6268
	System.Void LoadMixingTableEffect(UnityEngine.Transform root, System.Int32 templateID); // 0x072f65a8
	System.Void ReleaseMixingTableEffect(); // 0x072f5f34
	System.Void .ctor(); // 0x072f6870
}

// Client.Runtime
class WizardGames.Soc.Common.Component.NewBieLevelPartComponent : WizardGames.Soc.Common.Component.BaseComponentLocal, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler
{
	
	System.Int32 get_Id(); // 0x072f694c
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x072f69b0
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x072f6a24
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x072f6a98
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x072f6d88
	System.Void .ctor(); // 0x072f6dfc
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PartGOUnityComponent : WizardGames.Soc.Common.Component.BaseComponentLocal, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static WizardGames.Soc.Common.Construction.PartType[] NoInstanceParts; // 0x0
	WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer gpuInstContainer; // 0x38
	WizardGames.Soc.Common.Combat.ConstructionColliderConfigCollection baseConfigCollection; // 0x40
	WizardGames.Soc.Common.Combat.ConstructionColliderConfigCollection skinConfigCollection; // 0x48
	WizardGames.Soc.Common.Combat.ColliderConfigSet colliderConfigSet; // 0x50
	ConstructionSkinNodeConfig constructionSkinNodeConfig; // 0x58
	System.Boolean isLoaded; // 0x60
	WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer get_GpuInstContainer(); // 0x072f6e88
	ConstructionSkinNodeConfig get_ConstructionSkinNodeConfig(); // 0x072f6eec
	System.Void TrySetup(); // 0x072f6f50
	System.Void RefreshRecoveringState(); // 0x072f7030
	System.Void RefreshRecoveringGPUState(); // 0x072f7094
	System.Void InitGPUInstance(); // 0x072f722c
	System.Void RemoveGPUInstance(); // 0x072f7dfc
	System.Void SetGpuBuildingMeshGoState(System.Boolean value); // 0x072f78bc
	System.Void GpuInstanceClearOnRemove(); // 0x072f7e6c
	System.Int32 get_Id(); // 0x072f7f34
	UnityEngine.GameObject get_MainGo(); // 0x072f7f98
	UnityEngine.GameObject get_MeshRootGo(); // 0x072f7cd0
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x072f7174
	System.Void OnGoLoaded(); // 0x072f8024
	System.Void Cleanup(); // 0x072f8be0
	System.Void RefreshPartPos(); // 0x072f8d48
	System.Void RefreshPartRot(); // 0x072f9078
	System.Void AfterChangePartGoTransform(); // 0x072f91b0
	System.Void InitSkinGo(UnityEngine.GameObject skinGo); // 0x072f959c
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x072f9854
	System.Void OnSkinGoRemove(); // 0x072f99e8
	System.Void CleanupUnityInfo(); // 0x072f8cb8
	System.Void BeforeChangePartGoTransform(); // 0x072f9ad8
	System.Void InitSkinGoMonoInfo(UnityEngine.GameObject skinGo); // 0x072f97a4
	System.Void InitBaseColliderConfigSet(); // 0x072f8364
	System.Void UpdateUnityPositionInfo(); // 0x072f9474
	System.Void InitSkinGoInfo(UnityEngine.GameObject skinGo); // 0x072f98d8
	System.Void RemoveSkinGoInfo(); // 0x072f9a54
	System.Void UpdateColliderSet(); // 0x072f85ac
	System.Void .ctor(); // 0x072f9b38
	static System.Void .cctor(); // 0x072f9bc4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PartHighLightEffectComponent : WizardGames.Soc.Common.Component.BaseComponentLocal, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	System.Collections.Generic.List<UnityEngine.Renderer> rendererList; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.MeshTRSData> _meshTRSDataList; // 0x40
	WizardGames.Soc.SocClient.Construction.FaceShowFx <FaceShowFx>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Construction.RangeShowFx <RangeShowFx>k__BackingField; // 0x50
	ConstructionSkinNodeConfig constructionSkinNodeConfig; // 0x58
	UnityEngine.Mesh bakeMesh; // 0x60
	static System.Void .cctor(); // 0x072f9c64
	WizardGames.Soc.Common.Entity.PartEntity get_parentPartEntity(); // 0x072f9d8c
	System.Int32 get_Id(); // 0x072f9e44
	WizardGames.Soc.SocClient.Construction.FaceShowFx get_FaceShowFx(); // 0x072f9ea8
	WizardGames.Soc.SocClient.Construction.RangeShowFx get_RangeShowFx(); // 0x072f9f0c
	System.Void OnGoLoaded(); // 0x072f9f70
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGO); // 0x072f9fd8
	System.Void OnSkinGoRemove(); // 0x072fa444
	System.Void Init(); // 0x072fa4a4
	System.Void OnRotationChanged(); // 0x072fa50c
	System.Void ReCollectMeshData(); // 0x072fa668
	System.Void OnEnterEditMode(); // 0x072fa840
	System.Void OnExitEditMode(); // 0x072fab2c
	WizardGames.AssetPool.AssetPoolHandle GetHighlightMatByType(WizardGames.Soc.SocClient.Manager.EPartHighlightType type); // 0x072fac40
	System.Void DrawHighLight(WizardGames.Soc.SocClient.Manager.EPartHighlightType partHighlightType); // 0x072fad38
	System.Void HighlightMeshTRSData(WizardGames.Soc.Common.Unity.Construction.MeshTRSData meshTRSData, WizardGames.Soc.SocClient.Manager.EPartHighlightType highlightState); // 0x072fb3e0
	System.Void Highlight(UnityEngine.Renderer renderer, WizardGames.AssetPool.AssetPoolHandle highlightMat); // 0x072fbb48
	System.Boolean IsMeshNoNeedToDeal(System.String nodeName, UnityEngine.Mesh mesh); // 0x072fc1ac
	System.Void ClearMeshList(); // 0x072fa6d4
	System.Void CollectMeshList(); // 0x072fa088
	System.Void Cleanup(); // 0x072fc3a4
	System.Void .ctor(); // 0x072fc4cc
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PartHighLightEffectComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.PartHighLightEffectComponent.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x072fc620
	System.Void .ctor(); // 0x072fc684
	System.Void <.cctor>b__0_0(WizardGames.Soc.Common.Entity.PartEntity ent, WizardGames.Soc.Common.Event.PartEntityRotationChangeEvent _); // 0x072fc6ec
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PartSkinAnimateComponent : WizardGames.Soc.Common.Component.BaseComponentLocal, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	System.Boolean animationFlag; // 0x38
	UnityEngine.Animation animation; // 0x40
	UnityEngine.GameObject skinGo; // 0x48
	System.Int64 animTimerId; // 0x50
	System.Int32 get_Id(); // 0x072fc7ec
	WizardGames.Soc.Common.Entity.PartEntity get_parentPartEntity(); // 0x072fc850
	System.Void MarkAnimationFlag(System.Boolean isChangeSkin); // 0x072fc908
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x072fcc58
	System.Void CheckAndPlayTriggerAnimationAndEffect(); // 0x072fca00
	System.Void CheckAndPlayTriggerEffect(); // 0x072fd428
	System.Void CheckAndPlayIdleEffect(); // 0x072fcec0
	System.Void PlayTriggerAnimation(); // 0x072fd990
	System.Void Tick(System.Int64 deltaTime); // 0x072fdcac
	System.Void OnSkinGoRemove(); // 0x072fddf8
	System.Void .ctor(); // 0x072fde74
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PermissionLockComponent : WizardGames.Soc.Common.Component.BaseComponentLocal, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	System.Boolean authorizeStatus; // 0x38
	System.Collections.Generic.List<UnityEngine.GameObject> authorizedNodes; // 0x40
	System.Collections.Generic.List<UnityEngine.GameObject> unauthorizedNodes; // 0x48
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x50
	UnityEngine.GameObject skinGo; // 0x58
	System.Int32 get_Id(); // 0x072fdf00
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x072fdf64
	System.Void OnGoLoaded(); // 0x072fe01c
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x072fe118
	System.Void OnSkinGoRemove(); // 0x072fedec
	System.Void Cleanup(); // 0x072feed0
	System.Void FindStatusGoNodes(); // 0x072fe230
	System.Void InitInstanceToggleGroup(); // 0x072fe900
	System.Void SetLockRenderStatus(System.Boolean authorized); // 0x072feb84
	System.Void CheckLockRenderState(); // 0x072fefc0
	System.Void InitializeMaterials(); // 0x072fe1d0
	System.Void .ctor(); // 0x072ff1b0
	System.Void <OnGoLoaded>b__15_0(System.Int64 _); // 0x072ff304
}

// Client.Runtime
enum WizardGames.Soc.Common.Component.ERenderCode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Component.ERenderCode None = 0;
	static WizardGames.Soc.Common.Component.ERenderCode Add = 1;
	static WizardGames.Soc.Common.Component.ERenderCode Remove = 2;
	static WizardGames.Soc.Common.Component.ERenderCode ForceUpdate = 3;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Component.GpuInstComponent : WizardGames.Soc.Common.Component.BaseComponentLocal
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer container; // 0x38
	WizardGames.Soc.SocClient.Manager.RenderType renderType; // 0x40
	WizardGames.Soc.Common.Unity.Go.BaseEntityGo go; // 0x48
	System.Int32 entityTypeId; // 0x50
	System.Boolean isRendering; // 0x54
	WizardGames.Soc.Common.Component.ERenderCode renderCode; // 0x58
	System.Int32 instId; // 0x5c
	UnityEngine.GameObject prefab; // 0x60
	System.Action addCallback; // 0x68
	System.Action removeCallback; // 0x70
	System.Boolean isMultiModel; // 0x78
	System.Int32 modelIndex; // 0x7c
	System.Int32 newModelIndex; // 0x80
	System.Collections.Generic.List<UnityEngine.GameObject> prefabList; // 0x88
	System.Collections.Generic.List<UnityEngine.GameObject> gameObjectList; // 0x90
	System.Int32 get_InstId(); // 0x072ff37c
	System.Int32 get_Id(); // 0x072ff3e0
	UnityEngine.GameObject get_mainGo(); // 0x072ff444
	System.Int64 get_entityId(); // 0x072ff4bc
	System.Void Init(); // 0x072ff538
	System.Void OnGoLoaded(); // 0x072ff5a0
	System.Void Cleanup(); // 0x072ff608
	System.Void UpdateRender(); // 0x072ffa18
	System.Void SetRenderInfo(WizardGames.Soc.SocClient.Manager.RenderType rType, WizardGames.Soc.Common.Unity.Go.BaseEntityGo parentGo, WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer instContainer, System.Action addCb, System.Action removeCb); // 0x072ffd38
	System.Void SetMultiPrefab(System.Int32 typeId, System.Collections.Generic.List<UnityEngine.GameObject> prefabs, System.Collections.Generic.List<UnityEngine.GameObject> gameObjects); // 0x072fff08
	System.Void SetRenderCode(WizardGames.Soc.Common.Component.ERenderCode code, System.Int32 index); // 0x072fffc8
	System.Void AddToRenderer(); // 0x072ffad0
	System.Void RemoveFromRenderer(); // 0x072ff878
	System.Void UpdateRenderInfo(); // 0x072ffca0
	System.Void AddToRendererMulti(System.Int32 idx); // 0x073000b4
	System.Void RemoveFromRendererMulti(System.Int32 idx); // 0x072ff70c
	System.Boolean IdxValid(System.Int32 idx); // 0x073004ac
	System.Void SetMeshRenderer(System.Boolean enabled, UnityEngine.GameObject go); // 0x0730026c
	System.Void .ctor(); // 0x0730055c
	static System.Void .cctor(); // 0x073005f0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerDrawComponentClient : WizardGames.Soc.Common.Component.PlayerDrawComponent
{
	
	System.Void UnEquip(EItemBreakReason reason); // 0x07300684
	System.Void UnEquip(EItemBreakReason reason, System.Boolean needSwitchBack); // 0x0550f700
	System.Void Equip(WizardGames.Soc.Common.Utility.HoldItemIndex itemIndex); // 0x0730077c
	System.Void Equip(System.Int64 itemId, EItemBreakReason reason); // 0x07300df8
	System.Void SwitchHoldItem(WizardGames.Soc.Common.Utility.HoldItemIndex itemIndex, System.Boolean unEquip); // 0x073008c8
	System.Void SwitchCollection(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x05523a54
	System.Boolean SetCmdByItem(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Utility.HoldItemIndex slot, System.Boolean unEquip); // 0x0730162c
	System.Void .ctor(); // 0x073018d4
}

// Client.Runtime
interface WizardGames.Soc.Common.Component.IClientShopBase : 
{
	
	System.Void DoBuy(System.Int32 shopItemId, System.Int32 count); // 0x055057d4
	System.Void CloseShopUI(); // 0x055049cc
	System.Void RegisterShopItemBuyCallBack(WizardGames.Soc.Common.Component.IClientShopBase.OnShopItemBuyCallBack callback); // 0x05523a54
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.ShopItemData> GetShopItemDataDict(); // 0x054e7844
}

// Client.Runtime
class WizardGames.Soc.Common.Component.IClientShopBase.OnShopItemBuyCallBack : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x073019e8
	System.Void Invoke(System.Int32 ret, System.Boolean isVehicle); // 0x07301ab0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.SocHorseStaminaComponent : WizardGames.Soc.Common.Component.BaseComponentLocal
{
	static SocLogger logger; // 0x0
	System.Single MaxStaminaSeconds; // 0x38
	System.Single FindFoodStaminaRatio; // 0x3c
	System.Single StaminaCoreSpeedBonus; // 0x40
	System.Single StaminaCoreLossRatio; // 0x44
	System.Single StaminaReplenishRatioMoving; // 0x48
	System.Single StaminaReplenishRatioStanding; // 0x4c
	System.Single MaxStaminaCoreFromWater; // 0x50
	System.Single MinStaminaThreshold; // 0x54
	System.Int32 get_Id(); // 0x07301b0c
	System.String GetTypeName(); // 0x07301b70
	WizardGames.Soc.Common.Entity.HorseEntity get_HorseEntity(); // 0x07301be8
	System.Void InitEntity(WizardGames.Soc.Common.Entity.HorseEntity serverHorseEntity); // 0x07301ca0
	System.Void InitStamina(WizardGames.Soc.Common.Entity.HorseEntity serverHorseEntity, WizardGames.Soc.Common.Data.Vehicle.VehicleInfo vehicleInfo); // 0x07301f30
	System.Void UpdateStamina(System.Single delta); // 0x07302034
	System.Void UseStamina(System.Single amount); // 0x07302148
	System.Void ReplenishStamina(System.Single amount); // 0x07302228
	System.Void .ctor(); // 0x07302584
	static System.Void .cctor(); // 0x07302610
}

// Client.Runtime
class WizardGames.Soc.Common.Component.NetworkTestSession : System.Object
{
	System.Int64 BytesSent; // 0x10
	System.Int64 BytesReceived; // 0x18
	System.Collections.Generic.Queue<System.ValueTuple<System.Buffers.IMemoryOwner<System.Byte>,System.Int32>> Pending; // 0x20
	System.Int64 StartTs; // 0x28
	System.Int64 EndTs; // 0x30
	System.Int32 Duration; // 0x38
	System.Int32 TargetBytesPerSecond; // 0x3c
	System.Int32 SendBytesPerSecond; // 0x40
	System.Int32 ActualBytesPerSecond; // 0x44
	System.Boolean IsError; // 0x48
	System.Int32 SessionId; // 0x4c
	System.Int64 TimerId; // 0x50
	System.Random R; // 0x58
	System.Boolean ToSimulator; // 0x60
	System.Void .ctor(); // 0x073026e4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.CommonColliderComponentUnity : WizardGames.Soc.Common.Component.BaseComponentLocal
{
	WizardGames.Soc.Common.Unity.Construction.CoreColliderData colliderData; // 0x38
	System.Int32 get_Id(); // 0x07302798
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x073027fc
	System.Void Cleanup(); // 0x073028b4
	System.Void RemoveColliderData(); // 0x07302918
	System.Void OnGoLoaded(); // 0x073029a8
	System.Void SetColliderData(); // 0x07302a18
	System.Void CreateColliderData(); // 0x07302d18
	System.Void RefreshColliderRootTransform(); // 0x07302a98
	System.Void RefreshGradeAndSplicingCollider(); // 0x07302c2c
	System.Void .ctor(); // 0x07302ea4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.NodeEnableByFuelComponent : WizardGames.Soc.Common.Component.BaseComponentLocal, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	UnityEngine.GameObject enableGo; // 0x38
	UnityEngine.GameObject disableGo; // 0x40
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x07302f30
	System.Int32 get_Id(); // 0x07302fe8
	System.Void OnGoLoaded(); // 0x0730304c
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x073030b4
	System.Void RefreshNodeEnableByFlag(); // 0x073031d0
	System.Void OnSkinGoRemove(); // 0x073033a4
	static System.Void .cctor(); // 0x07303420
	static System.Void OnFlagCompChangeState(WizardGames.Soc.Share.Framework.CustomTypeBase componentBase, System.Int32 oldValue, System.Int32 newValue); // 0x073034dc
	System.Void ShowNode(System.Boolean isOpen); // 0x07303290
	System.String GetTypeName(); // 0x0730361c
	System.Void .ctor(); // 0x07303694
}

// Client.Runtime
class WizardGames.Soc.Common.Component.UGCTriggerRegionCompEdit : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Component.UGCTriggerRegionComponent cachedComp; // 0x30
	System.Boolean DrawCollider; // 0x38
	System.Boolean BeginEdit; // 0x39
	WizardGames.Soc.Common.Component.EUGCTriggerRegionColliderType RegionColliderType; // 0x3c
	UnityEngine.Vector3 CustomScale; // 0x40
	System.String UGCIdentityTag; // 0x50
	System.String EnterEvent; // 0x58
	System.String ExitEvent; // 0x60
	System.String StayEvent; // 0x68
	System.Int32 Version; // 0x70
	System.Int64 timerId; // 0x78
	UnityEngine.GameObject interactiveObj; // 0x80
	System.Void BindCurrentPart(System.Int64 entityId); // 0x07303720
	System.Void RefreshData(); // 0x07303b0c
	System.Void RequestChange(); // 0x07303ca8
	System.Void ChangeTick(System.Int64 _); // 0x07303e14
	static System.Void BindPart(UnityEngine.GameObject go, System.Int64 entityId, WizardGames.Soc.Common.Component.UGCTriggerRegionCompEdit& comp); // 0x07303e8c
	System.Void OnBeforeSerialize(); // 0x07304018
	System.Void OnAfterDeserialize(); // 0x07304238
	System.Void .ctor(); // 0x07304298
	static System.Void .cctor(); // 0x07304300
}

// Client.Runtime
class WizardGames.Soc.Common.Component.BuoyancyComponent : WizardGames.Soc.Common.Component.BaseComponentLocal
{
	System.Int32 BuoyancyTemplateId; // 0x38
	System.Single BuoyancyHeight; // 0x3c
	System.Single BuoyancyTargetPosY; // 0x40
	System.Int32 <BuoyancyPhase>k__BackingField; // 0x44
	System.Single FloatAcc; // 0x48
	System.Single FloatSpeedMax; // 0x4c
	System.Single StaticDepthAcc; // 0x50
	System.Single DampingAcc; // 0x54
	System.Single DampingAmpMin; // 0x58
	System.Single CurFloatingSpeed; // 0x5c
	System.Int64 LastPosCheckTime; // 0x60
	UnityEngine.Vector3 LastCheckedPos; // 0x68
	System.Int32 get_Id(); // 0x073043d4
	WizardGames.Soc.Share.Framework.IPositionEntity get_PositionEntity(); // 0x07304438
	System.Int32 get_BuoyancyPhase(); // 0x073044bc
	System.Void set_BuoyancyPhase(System.Int32 value); // 0x07304520
	System.Void OnGoLoaded(); // 0x07304598
	System.Void InitBuoyancyProp(); // 0x07304608
	System.Void SetBuoyancyPhase(System.Int32 newPhase); // 0x07304c50
	System.Void .ctor(); // 0x07304e7c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ConsumeItemComponentHotifx : System.Object
{
	
	static System.Void InitImpl(WizardGames.Soc.Common.Component.ConsumeItemComponent self); // 0x07304f08
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricAutoTurretComponentHotfix : System.Object
{
	
	static System.Boolean IsPartAI(WizardGames.Soc.Common.Component.ElectricAutoTurretComponent self); // 0x07305250
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricBaseComponentHotfix : System.Object
{
	
	static System.Boolean IsBusy(WizardGames.Soc.Common.Component.ElectricBaseComponent self); // 0x07305328
	static System.Void OnPostInit(WizardGames.Soc.Common.Component.ElectricBaseComponent self); // 0x073053a0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.SleepingBagBaseComponentHotfix : System.Object
{
	
	static System.Boolean IsRespawnType(System.Int64 templateId); // 0x07305468
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TerritoryBaseComponentHotfix : System.Object
{
	
	static System.Boolean IsDeadSheep(WizardGames.Soc.Common.Component.TerritoryBaseComponent self); // 0x073054e0
	static System.Boolean IsConstructionBlueprint(WizardGames.Soc.Common.Component.TerritoryBaseComponent self); // 0x0730555c
	static System.Boolean IsBatchUpgrading(WizardGames.Soc.Common.Component.TerritoryBaseComponent self); // 0x073055d8
	static System.Int64 BatchUpgradeFinishTs(WizardGames.Soc.Common.Component.TerritoryBaseComponent self); // 0x073057b8
	static WizardGames.Soc.Common.CustomType.BatchUpgradeRecord GetBatchUpgradeRecord(WizardGames.Soc.Common.Component.TerritoryBaseComponent self); // 0x07305648
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TerritoryBatchRecoverComponentHotfix : System.Object
{
	
	static System.Boolean IsExemptPartCreatedByOthers(WizardGames.Soc.Common.Component.TerritoryBatchRecoverComponent self, WizardGames.Soc.Common.Entity.PartEntity part); // 0x07305834
	static System.Boolean IsExemptPartCreatedByOthers(WizardGames.Soc.Common.Component.TerritoryBatchRecoverComponent self, System.Int64 templateId, System.UInt64 ownerId); // 0x073058d8
	static System.Boolean IsExemptPartCreatedByOthers(WizardGames.Soc.Common.Component.TerritoryBatchRecoverComponent self, WizardGames.Soc.Common.Data.constraction.BuildingCore config, System.UInt64 ownerId); // 0x073059f0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TerritoryPermissionComponentHotfix : System.Object
{
	
	static System.Boolean IsAdminOrCreator(WizardGames.Soc.Common.Component.TerritoryPermissionComponent self, System.UInt64 roleId); // 0x07305f0c
	static System.Boolean IsAdmin(WizardGames.Soc.Common.Component.TerritoryPermissionComponent self, System.UInt64 roleId); // 0x07305fd0
	static System.Boolean IsNormalMember(WizardGames.Soc.Common.Component.TerritoryPermissionComponent self, System.UInt64 roleId); // 0x07306078
	static System.Boolean HasAnyPermission(WizardGames.Soc.Common.Component.TerritoryPermissionComponent self, System.UInt64 roleId); // 0x07306384
	static System.Boolean HasSpecialPermission(WizardGames.Soc.Common.Component.TerritoryPermissionComponent self, System.UInt64 roleId, System.Int32 permissionGroupId); // 0x07306424
	static System.Void GetPermissionGroupIds(WizardGames.Soc.Common.Component.TerritoryPermissionComponent self, System.UInt64 roleId, System.Collections.Generic.List<System.Int32>& groupIds); // 0x07306544
	static System.Boolean HasSinglePermission(WizardGames.Soc.Common.Component.TerritoryPermissionComponent self, System.UInt64 roleId, System.Int32 permUnitId); // 0x07305abc
}

// Client.Runtime
class WizardGames.Soc.Common.Component.TerritoryPlayComponentHotfix : System.Object
{
	
	static System.Boolean IsPartEntityAlive(WizardGames.Soc.Common.Component.TerritoryPlayComponent self); // 0x073068c4
	static System.Boolean IsPartEntityDead(WizardGames.Soc.Common.Component.TerritoryPlayComponent self); // 0x07306940
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ConstructionSocketBaseComponentHotfix : System.Object
{
	
	static System.Void InitSocketsAndLink(WizardGames.Soc.Common.Component.ConstructionSocketBaseComponent self); // 0x073069bc
	static System.Boolean TryGetSocket(WizardGames.Soc.Common.Component.ConstructionSocketBaseComponent self, System.Int32 socketId, WizardGames.Soc.Common.Construction.SocketRuntimeBase& socketData); // 0x07306a38
	static WizardGames.Soc.Common.Construction.SocketRuntimeBase GetSocketByName(WizardGames.Soc.Common.Component.ConstructionSocketBaseComponent self, System.String name); // 0x07306b08
	static System.Int64 GetSocketMaskById(WizardGames.Soc.Common.Component.ConstructionSocketBaseComponent self, System.Int32 id); // 0x07306cd8
}

// Client.Runtime
interface WizardGames.Soc.Common.Component.IFlagComp : 
{
	
	System.Int32 get_Flags(); // 0x0548ba98
	System.Void set_Flags(System.Int32 value); // 0x055056e8
	System.Void SetFlag(WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags flag, System.Boolean value); // 0x07306e38
	System.Boolean HasFlag(WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags flag); // 0x07306f90
	System.Void RegisterFlagChangeCallback(System.Action<System.Int32,System.Int32> callback); // 0x05523a54
	System.Void UnRegisterFlagChangeCallback(System.Action<System.Int32,System.Int32> callback); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.Common.Component.FunctionConst : System.Object
{
	static WizardGames.Soc.Common.Component.FunctionName Task; // 0x0
	static WizardGames.Soc.Common.Component.FunctionName ExplorationTask; // 0x8
	static WizardGames.Soc.Common.Component.FunctionName TreasureTask; // 0x10
	static WizardGames.Soc.Common.Component.FunctionName BeebuzzTask; // 0x18
	static WizardGames.Soc.Common.Component.FunctionName MedalTask; // 0x20
	static WizardGames.Soc.Common.Component.FunctionName DailyTask; // 0x28
	static WizardGames.Soc.Common.Component.FunctionName LobbyMainTask; // 0x30
	static WizardGames.Soc.Common.Component.FunctionName ConstructionExtras; // 0x38
	static WizardGames.Soc.Common.Component.FunctionName Plunder; // 0x40
	static WizardGames.Soc.Common.Component.FunctionName PlunderNotice; // 0x48
	static WizardGames.Soc.Common.Component.FunctionName DeadSheep; // 0x50
	static WizardGames.Soc.Common.Component.FunctionName EnableDeadSheepSpawnAtOnce; // 0x58
	static WizardGames.Soc.Common.Component.FunctionName RaidProtection; // 0x60
	static WizardGames.Soc.Common.Component.FunctionName ReputationRaidProtect; // 0x68
	static WizardGames.Soc.Common.Component.FunctionName PartDebris; // 0x70
	static WizardGames.Soc.Common.Component.FunctionName ReputationPartDebris; // 0x78
	static WizardGames.Soc.Common.Component.FunctionName SleepingBagReborn; // 0x80
	static WizardGames.Soc.Common.Component.FunctionName NearbyReborn; // 0x88
	static WizardGames.Soc.Common.Component.FunctionName OutpostReborn; // 0x90
	static WizardGames.Soc.Common.Component.FunctionName RandomReborn; // 0x98
	static WizardGames.Soc.Common.Component.FunctionName ArchiveReborn; // 0xa0
	static WizardGames.Soc.Common.Component.FunctionName DeathDropProtect; // 0xa8
	static WizardGames.Soc.Common.Component.FunctionName Reputation; // 0xb0
	static WizardGames.Soc.Common.Component.FunctionName Team; // 0xb8
	static WizardGames.Soc.Common.Component.FunctionName TeamSendInvite; // 0xc0
	static WizardGames.Soc.Common.Component.FunctionName TeamSendInviteToLobby; // 0xc8
	static WizardGames.Soc.Common.Component.FunctionName TeamAcceptInvite; // 0xd0
	static WizardGames.Soc.Common.Component.FunctionName TeamRefuseInvite; // 0xd8
	static WizardGames.Soc.Common.Component.FunctionName TeamHandoverCaptain; // 0xe0
	static WizardGames.Soc.Common.Component.FunctionName TeamLeave; // 0xe8
	static WizardGames.Soc.Common.Component.FunctionName TeamKick; // 0xf0
	static WizardGames.Soc.Common.Component.FunctionName TeamChangeDuty; // 0xf8
	static WizardGames.Soc.Common.Component.FunctionName TeamRecruitment; // 0x100
	static WizardGames.Soc.Common.Component.FunctionName TeamWarZoneRecruitment; // 0x108
	static WizardGames.Soc.Common.Component.FunctionName SafeBox; // 0x110
	static WizardGames.Soc.Common.Component.FunctionName RandomAirdrop; // 0x118
	static WizardGames.Soc.Common.Component.FunctionName NewbieProtection; // 0x120
	static WizardGames.Soc.Common.Component.FunctionName TeamTechUnlockShare; // 0x128
	static WizardGames.Soc.Common.Component.FunctionName DisableTransferOutItems; // 0x130
	static WizardGames.Soc.Common.Component.FunctionName Activity; // 0x138
	static WizardGames.Soc.Common.Component.FunctionName LobbyReward; // 0x140
	static WizardGames.Soc.Common.Component.FunctionName Shop; // 0x148
	static WizardGames.Soc.Common.Component.FunctionName ShopMiniCopter; // 0x150
	static WizardGames.Soc.Common.Component.FunctionName UgcMode; // 0x158
	static WizardGames.Soc.Common.Component.FunctionName DayNightSwitch; // 0x160
	static WizardGames.Soc.Common.Component.FunctionName WoundedToDied; // 0x168
	static WizardGames.Soc.Common.Component.FunctionName RespawnToWakeUp; // 0x170
	static WizardGames.Soc.Common.Component.FunctionName Hunger; // 0x178
	static WizardGames.Soc.Common.Component.FunctionName Thirst; // 0x180
	static WizardGames.Soc.Common.Component.FunctionName FallDamage; // 0x188
	static WizardGames.Soc.Common.Component.FunctionName ConstructionBlueprint; // 0x190
	static WizardGames.Soc.Common.Component.FunctionName UnlockAllTechnology; // 0x198
	static WizardGames.Soc.Common.Component.FunctionName EliminationReborn; // 0x1a0
	static WizardGames.Soc.Common.Component.FunctionName AttackedFinishImmediately; // 0x1a8
	static System.Void .cctor(); // 0x07307078
}

// Client.Runtime
enum WizardGames.Soc.Common.Component.FunctionConst.EPath : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Component.FunctionConst.EPath ExtraTaskType = 0;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath ExplorationTask = 1;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath TreasureTask = 2;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath BeebuzzTask = 3;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath MedalTask = 4;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath DailyTask = 5;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath LobbyTask = 6;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath ConstructionExtras = 7;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath Plunder = 8;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath PlunderTip = 9;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath DeadSheep = 10;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath EnableDeadSheepSpawnAtOnce = 11;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath RaidProtection = 12;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath ReputationRaidProtect = 13;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath PartDebris = 14;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath ReputationPartDebris = 15;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath SleepingBagReborn = 16;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath NearbyReborn = 17;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath OutpostReborn = 18;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath RandomReborn = 19;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath ArchiveReborn = 20;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath DeathDropProtect = 21;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath Reputation = 22;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath ReputationBadge = 23;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath Team = 24;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath TeamSendInvite = 25;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath TeamAcceptInvite = 26;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath TeamRefuseInvite = 27;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath TeamHandoverCaptain = 28;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath TeamLeave = 29;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath TeamKick = 30;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath TeamChangeDuty = 31;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath TeamRecruitment = 32;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath TeamWarZoneRecruitment = 33;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath TeamSendInviteToLobby = 34;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath SafeBox = 35;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath RandomAirdrop = 36;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath NewbieProtection = 37;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath TeamTechUnlockShare = 38;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath DisableTransferOutItems = 39;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath Activity = 40;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath LobbyReward = 41;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath Shop = 42;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath MiniCopter = 43;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath UgcMode = 1000;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath DayNightSwitch = 1001;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath WoundedToDied = 1002;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath RespawnToWakeUp = 1003;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath Hunger = 1004;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath Thirst = 1005;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath FallDamage = 1006;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath ConstructionBlueprint = 1007;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath UnlockAllTechnology = 1008;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath EliminationReborn = 1009;
	static WizardGames.Soc.Common.Component.FunctionConst.EPath AttackedFinishImmediately = 1010;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Component.FunctionName : System.Object
{
	System.String <TableColumnName>k__BackingField; // 0x10
	System.Collections.Generic.List<System.Int64> <Path>k__BackingField; // 0x18
	System.Boolean <DynamicSwitch>k__BackingField; // 0x20
	System.String get_TableColumnName(); // 0x07308b64
	System.Void set_TableColumnName(System.String value); // 0x07308bc8
	System.Collections.Generic.List<System.Int64> get_Path(); // 0x07308c48
	System.Void set_Path(System.Collections.Generic.List<System.Int64> value); // 0x07308cac
	System.Boolean get_DynamicSwitch(); // 0x07308d2c
	System.Void set_DynamicSwitch(System.Boolean value); // 0x07308d90
	System.Void .ctor(System.String tableColumnName, WizardGames.Soc.Common.Component.FunctionConst.EPath[] path); // 0x07308838
	WizardGames.Soc.Common.Component.FunctionName EnableDynamicSwitch(); // 0x07308ab0
	System.String ToString(); // 0x07308e0c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PhysicsMoveComponent : WizardGames.Soc.Common.Component.BaseComponentLocal
{
	static SocLogger logger; // 0x0
	static System.Single k_CheckUnderGroundTime = 0.10000000149011612;
	static System.Collections.Generic.List<System.Int32> collisionEntityList; // 0x8
	static System.Collections.Generic.List<System.Int32> ignorePlatformSpeedList; // 0x10
	UnityEngine.RaycastHit[] tmpHits; // 0x38
	System.Collections.Generic.List<UnityEngine.RaycastHit> tmpHitsList; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.Common.Combat.SocRaycastHit> tmpSocHitsList; // 0x48
	UnityEngine.Collider[] tmpColliders; // 0x50
	UnityEngine.Vector3 velocity; // 0x58
	System.Single maxGravitySpeed; // 0x64
	System.Single minGravitySpeed; // 0x68
	System.Int64 ignoreCollisionId; // 0x70
	System.Int64 ignoreEntityId; // 0x78
	System.Boolean ignorePlayer; // 0x80
	System.Boolean useCommonCollision; // 0x81
	System.Boolean rotateLandGround; // 0x82
	System.Boolean reflectInfluceY; // 0x83
	System.Single reboundCoefficient; // 0x84
	System.Int32 layerMask; // 0x88
	System.Boolean canBuoyancy; // 0x8c
	System.Boolean stopWhenHit; // 0x8d
	System.Collections.Generic.List<System.Int32> adsorptionList; // 0x90
	System.Action<WizardGames.Soc.Common.Combat.SocRaycastHit,UnityEngine.Collider> OnLandGround; // 0x98
	System.Action<System.Single,System.Boolean> OnPhysicsMove; // 0xa0
	System.Action AfterStopMove; // 0xa8
	System.Action AfterSyncTransform; // 0xb0
	System.Action<WizardGames.Soc.Common.Combat.SocRaycastHit> OnCollisionHit; // 0xb8
	System.Action<System.Int64,System.Int32,System.Boolean> OnAttached; // 0xc0
	System.Int32 colliderType; // 0xc8
	UnityEngine.Collider baseCollider; // 0xd0
	System.Int64 attachedId; // 0xd8
	System.Boolean isLand; // 0xe0
	UnityEngine.Vector3 initPosition; // 0xe4
	UnityEngine.Vector3 worldPosition; // 0xf0
	UnityEngine.Vector3 localPosition; // 0xfc
	UnityEngine.Quaternion worldRotation; // 0x108
	UnityEngine.Quaternion localRotation; // 0x118
	UnityEngine.Vector3 lastWorldPosition; // 0x128
	UnityEngine.Quaternion lastWorldRotation; // 0x134
	UnityEngine.Transform attachParent; // 0x148
	WizardGames.Soc.Share.Framework.IPositionEntity attachParentEntity; // 0x150
	UnityEngine.Vector3 attachEntityPosition; // 0x158
	WizardGames.Soc.SocClient.Trigger.TriggerForce triggerForce; // 0x168
	UnityEngine.Vector3 triggerForceVelocity; // 0x170
	WizardGames.Soc.Common.Component.PhysicsMoveComponent.MoveState curState; // 0x17c
	UnityEngine.Vector3 lastCheckWorldPos; // 0x180
	System.Single checkUnderGroundTimer; // 0x18c
	System.Boolean UseCoordinateTrans; // 0x190
	WizardGames.Soc.Common.Component.PhysicsMoveComponent.OnGetUCT OnGetUseCoordinateTrans; // 0x198
	WizardGames.Soc.Common.Component.PhysicsMoveComponent.OnGetNewHistoryVector3 OnGetNewPos; // 0x1a0
	WizardGames.Soc.Common.Component.PhysicsMoveComponent.OnGetNewHistoryVector3 OnGetNewVelocity; // 0x1a8
	WizardGames.Soc.Common.Component.PhysicsMoveComponent.OnGetNewHistoryVector3 OnGetRelativePos; // 0x1b0
	WizardGames.Soc.Common.Component.PhysicsMoveComponent.OnGetNewHistoryVector3 OnGetHistoryVelocity; // 0x1b8
	System.Boolean needOverlapScene; // 0x1c0
	System.Boolean isHitScreenBox; // 0x1c1
	System.Boolean manageBySystem; // 0x1c2
	System.Single castOffsetY; // 0x1c4
	WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.PhysicsShapeType <shapeType>k__BackingField; // 0x1c8
	System.Int32 castJobHitCount; // 0x1cc
	System.Boolean isAirDropBox; // 0x1d0
	System.Boolean isDropBox; // 0x1d1
	System.Boolean isRebound; // 0x1d2
	System.Single gravityY; // 0x1d4
	System.Single defaultRadius; // 0x1d8
	UnityEngine.Vector3 defaultSize; // 0x1dc
	UnityEngine.Vector3 defaultCenter; // 0x1e8
	System.Single defaultHeight; // 0x1f4
	System.Int32 defaultDirection; // 0x1f8
	System.Int32 get_Id(); // 0x07308ff4
	System.String GetTypeName(); // 0x07309058
	UnityEngine.Vector3 get_Velocity(); // 0x073090d0
	System.Void set_Velocity(UnityEngine.Vector3 value); // 0x07309134
	WizardGames.Soc.Share.Framework.IPositionEntity get_positionEntity(); // 0x073091cc
	WizardGames.Soc.Common.Entity.IRotation3Entity get_rotation3Entity(); // 0x07309250
	WizardGames.Soc.Common.Component.PhysicsMoveComponent.MoveState get_CurState(); // 0x073092d4
	System.Void set_CurState(WizardGames.Soc.Common.Component.PhysicsMoveComponent.MoveState value); // 0x07309338
	System.Void set_shapeType(WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.PhysicsShapeType value); // 0x073093b0
	System.Void Add2PhysicsSystem(); // 0x07309428
	System.Void RemoveFromPhysicsSystem(System.Boolean delayRemove); // 0x073094fc
	System.Void InitPhysics(UnityEngine.Collider baseCollider, System.Boolean initGravity, UnityEngine.Vector3 velocity, System.Boolean canBuoyancy, System.Boolean handleOverlapScene, System.Boolean stopWhenHit, System.Int32 layerMask, System.Collections.Generic.List<System.Int32> selfAdsorptionList, System.Boolean rotateLandGround, System.Single rc, System.Single maxGravitySpeed, System.Single minGravitySpeed, System.Int64 ignoreCollisionId, System.Boolean ignorePlayer, System.Boolean useCommonCollision, System.Boolean reflectInfluceY, System.Single gravityScale); // 0x073095e4
	System.Void JudgeFreeFall(System.Boolean initGravity); // 0x0730c460
	System.Boolean TryAttach2Parent(System.Int64 targetEntityId, System.Int32 colliderIndex, UnityEngine.Vector3 localPos, UnityEngine.Quaternion localRot); // 0x0730b86c
	System.Void RestartFall(); // 0x0730d5ec
	System.Void ParentRemove(); // 0x0730d6b8
	System.Void PhysicsMove(WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, System.Single dt); // 0x0730e3ac
	System.Void SyncEntityPositionAndRotation(); // 0x0730e7b8
	System.Void ContinuousCheckGround(); // 0x073109e4
	System.Void FreeFallMove(WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, System.Single dt); // 0x0730ed48
	System.Void RaiseIfUnderGround(); // 0x0730c904
	System.Void FixedIfUnderGround(); // 0x07313044
	System.Boolean HasTriggerForce(); // 0x073137fc
	System.Void UpdateForceMove(System.Single dt); // 0x07313890
	System.Void Translate(UnityEngine.Vector3 dir); // 0x07312330
	System.Void SetPosition(UnityEngine.Vector3 point); // 0x07312a64
	System.Void Rotate(UnityEngine.Quaternion quaternion); // 0x07313ecc
	System.Void SetWorldRotation(UnityEngine.Quaternion quaternion); // 0x07312c3c
	System.Void CheckEnterMovingEntity(); // 0x0730b4b4
	System.Void CheckLeaveMovingEntity(); // 0x07312dbc
	System.Void ReflectMove(UnityEngine.Vector3 normal, System.Boolean hitEntity, System.Int64 hitEntityId, System.Int32 hitEntityType); // 0x07311d38
	UnityEngine.Vector3 DecaySpeed(UnityEngine.Vector3 normal, UnityEngine.Vector3 velocity); // 0x0731409c
	System.Boolean IsColliderMovingEntity(System.Int32 entityType, System.Int64 entityId); // 0x0730de10
	UnityEngine.Vector3 GetMovingEntityVelocity(System.Int64 entityId); // 0x0730de98
	System.Void HandleAdsorp(WizardGames.Soc.Common.Combat.SocRaycastHit hitInfo, WizardGames.Soc.Common.Entity.IEntity ownerEntity, System.Boolean& ignoreVehicleSpeed); // 0x07312434
	System.Boolean NeedAttach(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean& isAdsorp, System.Boolean judgeCollision); // 0x073120b8
	System.Boolean IsOverlapTriggerForce(); // 0x07313c84
	System.Single GetColliderHeight(); // 0x0730e300
	System.Void InitCollider(System.Boolean handleOverlapScene); // 0x0730a754
	System.Void ScaleCollider(); // 0x0731420c
	System.Boolean FilterRaycastHit(UnityEngine.RaycastHit raycastHit); // 0x073146a8
	System.Int32 CollisionCheck(UnityEngine.Quaternion quaternion, UnityEngine.Vector3 pos, UnityEngine.Vector3 velocityNormal, System.Single dis, System.Boolean isFirstCheck); // 0x07310cec
	System.Int32 CollisionOverlap(UnityEngine.Quaternion quaternion, UnityEngine.Vector3 pos, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction); // 0x0730c5ec
	System.Void SyncPositionAndRotation(); // 0x0730cce4
	System.Void SyncLocalPositionAndRotation(System.Boolean forceSync); // 0x0730d1f8
	System.Boolean TryGetColliderEntityId(UnityEngine.Collider collider, WizardGames.Soc.Common.Entity.IEntity& entity, System.Int64& entityId, System.Int32& entityType); // 0x07312b5c
	System.Boolean TryGetColliderEntityId(UnityEngine.GameObject go, WizardGames.Soc.Common.Entity.IEntity ownerEntity, WizardGames.Soc.Common.Entity.IEntity& entity, System.Int64& entityId, System.Int32& entityType, WizardGames.Soc.Common.Combat.ColliderConfig& colliderConfig); // 0x07311750
	System.Void Cleanup(); // 0x073149e0
	System.Void .ctor(); // 0x07314b80
	static System.Void .cctor(); // 0x07314d28
}

// Client.Runtime
enum WizardGames.Soc.Common.Component.PhysicsMoveComponent.MoveState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Component.PhysicsMoveComponent.MoveState FreeFall = 0;
	static WizardGames.Soc.Common.Component.PhysicsMoveComponent.MoveState AttachIdle = 1;
	static WizardGames.Soc.Common.Component.PhysicsMoveComponent.MoveState NormalIdle = 2;
	static WizardGames.Soc.Common.Component.PhysicsMoveComponent.MoveState ContinuousCheckIdle = 3;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PhysicsMoveComponent.OnGetUCT : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x07314dfc
	System.Boolean Invoke(); // 0x07314ec0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PhysicsMoveComponent.OnGetNewHistoryVector3 : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x07314f04
	UnityEngine.Vector3 Invoke(UnityEngine.Vector3 v3); // 0x07314fcc
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PhysicsMoveComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.PhysicsMoveComponent.<>c <>9; // 0x0
	static System.Comparison<UnityEngine.RaycastHit> <>9__108_0; // 0x8
	static System.Void .cctor(); // 0x07315038
	System.Void .ctor(); // 0x0731509c
	System.Int32 <FreeFallMove>b__108_0(UnityEngine.RaycastHit left, UnityEngine.RaycastHit right); // 0x07315104
}

// Client.Runtime
class WizardGames.Soc.Common.Component.PlayerDrawComponent : WizardGames.Soc.Common.Component.BaseComponentLocal
{
	static SocLogger logger; // 0x0
	System.Int32 get_Id(); // 0x073151c8
	System.String GetTypeName(); // 0x0731522c
	System.Void UnEquip(EItemBreakReason reason); // 0x055056e8
	System.Void Equip(System.Int64 itemId, EItemBreakReason reason); // 0x055112d4
	System.Void .ctor(); // 0x0730195c
	static System.Void .cctor(); // 0x073152a4
}

// Client.Runtime
enum WizardGames.Soc.Common.Component.ESendtemCode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Component.ESendtemCode Suc = 0;
	static WizardGames.Soc.Common.Component.ESendtemCode NoPrivilege = 1;
	static WizardGames.Soc.Common.Component.ESendtemCode PlayerCountError = 2;
	static WizardGames.Soc.Common.Component.ESendtemCode ItemIdCountError = 3;
	static WizardGames.Soc.Common.Component.ESendtemCode NoValidItem = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Component.RespawnType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Component.RespawnType SleepingBag = 11010014;
	static WizardGames.Soc.Common.Component.RespawnType Bed = 2;
	static WizardGames.Soc.Common.Component.RespawnType BeachTowel = 3;
	static WizardGames.Soc.Common.Component.RespawnType Camper = 4;
	
}

// Client.Runtime
interface WizardGames.Soc.Common.Component.IModifyBuild : 
{
	
	
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ModifyBuild<T> : System.Object, WizardGames.Soc.Common.Component.IModifyBuild
{
	System.Int32 PropertyId; // 0x0
	System.Action<WizardGames.Soc.Common.Component.UgcComponent,T> Set; // 0x0
	System.Func<WizardGames.Soc.Common.Component.UgcComponent,T> Get; // 0x0
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
enum WizardGames.Soc.Common.Component.EUGCTriggerRegionColliderType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Component.EUGCTriggerRegionColliderType None = 0;
	static WizardGames.Soc.Common.Component.EUGCTriggerRegionColliderType Box = 1;
	static WizardGames.Soc.Common.Component.EUGCTriggerRegionColliderType Sphere = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.MgrAdmin : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger _logger; // 0x0
	System.Boolean <IsInvincible>k__BackingField; // 0x11
	System.Boolean <IsShowHint>k__BackingField; // 0x12
	System.Single <DefaultLongitude>k__BackingField; // 0x14
	System.Single <DefaultLatitude>k__BackingField; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> _uiLayerVisibleDict; // 0x20
	System.Boolean get_IsInvincible(); // 0x07315378
	System.Void set_IsInvincible(System.Boolean value); // 0x073153dc
	System.Boolean get_IsShowHint(); // 0x07315458
	System.Void set_IsShowHint(System.Boolean value); // 0x073154bc
	System.Void set_DefaultLongitude(System.Single value); // 0x07315538
	System.Void set_DefaultLatitude(System.Single value); // 0x073155b0
	System.Void Init(); // 0x07315628
	System.Void CleanUp(); // 0x073157dc
	System.Void Destroy(); // 0x073158f4
	System.Threading.Tasks.Task AfterEnterWorld(); // 0x0731595c
	System.Threading.Tasks.Task OnExitWorld(); // 0x07315a80
	System.Void LateUpdate(); // 0x07315ae8
	System.Void HideLayers(System.Boolean isHide, System.Int32 layerId); // 0x07315bd4
	System.Void OnUiOpen(WizardGames.Soc.Common.Unity.Ui.WindowComBase com); // 0x07315d88
	System.Void .ctor(); // 0x07315f98
	static System.Void .cctor(); // 0x0731604c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.BaseCameraState : System.Object, WizardGames.Soc.Common.Unity.ICameraState
{
	static SocLogger logger; // 0x0
	UnityEngine.GameObject SceneCameraGo; // 0x10
	UnityEngine.Camera <SceneCamera>k__BackingField; // 0x18
	UnityEngine.Transform <SceneCameraTransform>k__BackingField; // 0x20
	System.Boolean <IsDamping>k__BackingField; // 0x28
	WizardGames.Soc.Common.Unity.CameraBlendRule <BlendRule>k__BackingField; // 0x2c
	UnityEngine.Vector3 <AddAnimationCameraPos>k__BackingField; // 0x30
	UnityEngine.Quaternion <AddAnimationCameraRot>k__BackingField; // 0x3c
	UnityEngine.Vector3 <AddWorldCameraPos>k__BackingField; // 0x4c
	UnityEngine.Quaternion <AddWorldCameraRot>k__BackingField; // 0x58
	WizardGames.Soc.Common.Unity.Shake.CameraShakeWeight <CameraShakeWeight>k__BackingField; // 0x68
	System.Boolean <IsMyPlayerDead>k__BackingField; // 0x70
	UnityEngine.Vector3 KillerSourcePos; // 0x74
	System.Single DeadCameraOffsetXZ; // 0x80
	System.Single DeadCameraOffsetY; // 0x84
	UnityEngine.Camera get_SceneCamera(); // 0x07316120
	System.Void set_SceneCamera(UnityEngine.Camera value); // 0x07316184
	UnityEngine.Transform get_SceneCameraTransform(); // 0x07316204
	System.Void set_SceneCameraTransform(UnityEngine.Transform value); // 0x07316268
	System.Boolean get_IsDamping(); // 0x073162e8
	System.Boolean get_IsBlending(); // 0x0731634c
	System.Single get_BlendPercent(); // 0x073163b0
	WizardGames.Soc.Common.Unity.CameraBlendRule get_BlendRule(); // 0x07316414
	System.Void set_BlendRule(WizardGames.Soc.Common.Unity.CameraBlendRule value); // 0x07316478
	UnityEngine.Vector3 get_AddAnimationCameraPos(); // 0x073164f0
	System.Void set_AddAnimationCameraPos(UnityEngine.Vector3 value); // 0x07316554
	UnityEngine.Quaternion get_AddAnimationCameraRot(); // 0x073165ec
	System.Void set_AddAnimationCameraRot(UnityEngine.Quaternion value); // 0x07316650
	UnityEngine.Vector3 get_AddWorldCameraPos(); // 0x073166f0
	System.Void set_AddWorldCameraPos(UnityEngine.Vector3 value); // 0x07316754
	UnityEngine.Quaternion get_AddWorldCameraRot(); // 0x073167ec
	System.Void set_AddWorldCameraRot(UnityEngine.Quaternion value); // 0x07316850
	WizardGames.Soc.Common.Unity.Shake.CameraShakeWeight get_CameraShakeWeight(); // 0x073168f0
	System.Void set_CameraShakeWeight(WizardGames.Soc.Common.Unity.Shake.CameraShakeWeight value); // 0x07316954
	System.Boolean get_IsMyPlayerDead(); // 0x073169d4
	System.Void set_IsMyPlayerDead(System.Boolean value); // 0x07316a38
	System.Void OnCreate(WizardGames.Soc.Common.Unity.ICameraStateController controller); // 0x07316ab4
	System.Void OnDestroy(); // 0x073179b8
	System.Void OnEnter(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.Unity.CameraState preState); // 0x07317cd0
	System.Void OnLeave(WizardGames.Soc.Common.Unity.ICameraStateController controller); // 0x07317d4c
	System.Int32 RenderUpdate(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x07317dc0
	UnityEngine.Vector2 CorrectShootPitchYaw(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.SimpleCustom.UserCmd nowCmd); // 0x07317e5c
	System.Int32 LateUpdate(WizardGames.Soc.Common.Unity.ICameraStateController controller, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x07317edc
	System.Int32 PhotoLateUpdate(WizardGames.Soc.Common.Unity.ICameraStateController controller, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x07317f70
	System.Void AddAnimationCameraShake(UnityEngine.Vector3 addPos, UnityEngine.Quaternion addRot); // 0x07318004
	System.Void ClearAnimationCameraShake(); // 0x073182b0
	System.Void AddAnimationCameraShakeWorld(UnityEngine.Vector3 addPos, UnityEngine.Quaternion addRot); // 0x07318458
	System.Void ClearAnimationCameraShakeWorld(); // 0x07318704
	WizardGames.Soc.Common.Unity.Go.BaseMountableGo GetMountableGo(WizardGames.Soc.Common.Unity.CameraStateController controller); // 0x073188ac
	System.Void ApplyCameraShakeWeightFp(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.Unity.CameraStateController controller, UnityEngine.Quaternion& rotation); // 0x07318a78
	System.Void ApplyCameraShakeWeightTp(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.Unity.CameraStateController controller, UnityEngine.Quaternion& rotation); // 0x07318e84
	System.Void RefreshSceneFov(System.Single fov); // 0x073191dc
	System.Void RefreshVehicleFov(System.Single fov); // 0x07319250
	System.Single[] RefreshEaseData(WizardGames.Soc.Common.Unity.ICameraStateController controller); // 0x073192c4
	System.Void OnMyPlayerDie(System.Single sourcePositionX, System.Single sourcePositionY, System.Single sourcePositionZ); // 0x07319680
	System.Void OnPlayerStateChange(System.Int32 state); // 0x073197a4
	System.Void HandleDeadCamera(UnityEngine.Transform cameraLocator, WizardGames.Soc.Common.Unity.CameraPosAndRot& cameraPosAndRot); // 0x07319aa4
	System.Void .ctor(); // 0x0731a290
	static System.Void .cctor(); // 0x0731a33c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.CameraAnchorThirdState : WizardGames.Soc.Common.Unity.BaseCameraState
{
	SocLogger logger; // 0x88
	System.Single _cameraHideDistance; // 0x90
	System.Single _cameraCrouchHideDistance; // 0x94
	System.Single _cameraDyingHideDistance; // 0x98
	UnityEngine.Vector3 m_PreviousFollowTargetPosition; // 0x9c
	UnityEngine.Vector3 m_DampingCorrection; // 0xa8
	WizardGames.Soc.Common.Entity.PlayerEntity playerEntity; // 0xb8
	System.Single cameraSphereCastRadius; // 0xc0
	System.Single m_CamPosCollisionCorrection; // 0xc4
	System.Void .ctor(); // 0x0731a53c
	System.Void OnEnter(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.Unity.CameraState preState); // 0x0731a7c0
	System.Int32 RenderUpdate(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.SimpleCustom.UserCmd nowCmd, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x0731a9ac
	System.Int32 LateUpdate(WizardGames.Soc.Common.Unity.ICameraStateController controller, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x0731aaac
	System.Void HandlePlayerVisible(WizardGames.Soc.Common.Entity.PlayerEntity entity, UnityEngine.Vector3 targetPointPos); // 0x0731b884
	UnityEngine.Vector3 DetachedFollowTargetDamp(UnityEngine.Vector3 initial, UnityEngine.Vector3 dampTime, System.Single deltaTime); // 0x0731b2c0
	System.Void GetRawRigPositions(UnityEngine.Vector3 root, UnityEngine.Quaternion heading, UnityEngine.Vector3& hand); // 0x0731b400
	static UnityEngine.Quaternion GetHeading(UnityEngine.Quaternion targetRot, UnityEngine.Vector3 up); // 0x0731b0b4
	UnityEngine.Vector3 ResolveCollisions(UnityEngine.Vector3 root, UnityEngine.Vector3 tip, System.Single deltaTime, System.Single cameraRadius, System.Single& collisionCorrection); // 0x0731b55c
	System.Void OnLeave(WizardGames.Soc.Common.Unity.ICameraStateController controller); // 0x0731ba94
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.CameraFirstSingleState : WizardGames.Soc.Common.Unity.BaseCameraState, WizardGames.Soc.Common.Unity.Ease.ICameraEaseController, System.IDisposable
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Ease.CameraEaseUnit <CameraEaseUnit>k__BackingField; // 0x88
	WizardGames.Soc.Common.Unity.Ease.CameraEaseData _cameraEaseData; // 0x90
	WizardGames.Soc.Common.Utility.SpringDamper CameraRollDamping; // 0x98
	System.Boolean _reset; // 0xa0
	System.Boolean _isFirstUpdate; // 0xa1
	System.Boolean InTP2FPADSTransition; // 0xa2
	UnityEngine.Quaternion _lastCameraShakeRot; // 0xa4
	System.Single _lerpTime; // 0xb4
	System.Single tp2FPADSTime; // 0xb8
	System.Boolean blending; // 0xbc
	System.Single blendTime; // 0xc0
	System.Single blendRate; // 0xc4
	WizardGames.Soc.Common.Unity.FP.FpCameraBlendData _CurrentBlendCameraBlendData; // 0xc8
	WizardGames.Soc.Common.Unity.FP.FpCameraBlendData _SrcBlendCameraBlendData; // 0xd0
	WizardGames.Soc.Common.Unity.FP.FpCameraBlendData _DstBlendCameraBlendData; // 0xd8
	WizardGames.Soc.Common.Unity.EntityState LastState; // 0xe0
	WizardGames.Soc.Common.Unity.EntityState NowState; // 0xe6
	System.UInt64 loadConfigTask; // 0xf0
	WizardGames.Soc.Common.Unity.FP.FPCameraStateDataCollection blendCollection; // 0xf8
	UnityEngine.GameObject bindGo; // 0x100
	WizardGames.Soc.Common.Unity.Ease.CameraEaseUnit get_CameraEaseUnit(); // 0x0731bbbc
	System.Void set_CameraEaseUnit(WizardGames.Soc.Common.Unity.Ease.CameraEaseUnit value); // 0x0731bc20
	System.Boolean get_IsBlending(); // 0x0731bca0
	System.Single get_BlendPercent(); // 0x0731bd04
	System.Void .ctor(); // 0x0731bdd0
	System.Void OnCameraEaseDataLoaded(WizardGames.Soc.Common.Unity.Ease.CameraEaseData cameraEaseData); // 0x0731c1b8
	System.Void Dispose(); // 0x0731c294
	System.Void OnEnter(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.Unity.CameraState preState); // 0x0731c4f0
	System.Void RefreshSceneFov(System.Single fov); // 0x0731cfbc
	System.Void OnLeave(WizardGames.Soc.Common.Unity.ICameraStateController controller); // 0x0731d088
	System.Int32 RenderUpdate(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.SimpleCustom.UserCmd nowCmd, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x0731d37c
	static System.Void SetCmdYawPitch(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.SimpleCustom.UserCmd nowCmd); // 0x0731ce40
	System.Int32 LateUpdate(WizardGames.Soc.Common.Unity.ICameraStateController controller, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x0731d694
	WizardGames.Soc.Common.Unity.CameraPosAndRot CameraEase(WizardGames.Soc.Common.Unity.CameraStateController controller, UnityEngine.Transform cameraLocator, WizardGames.Soc.Common.Unity.CameraPosAndRot cameraPosAndRot); // 0x0731f0fc
	WizardGames.Soc.Common.Unity.CameraPosAndRot UpdateCameraLatePosAndRot(WizardGames.Soc.Common.Unity.CameraStateController controller, System.Single yaw, System.Single pitch, System.Single roll, UnityEngine.Transform cameraLocator); // 0x0731e1e0
	System.Void FixWorldCameraShake(System.Single pitch, System.Single yaw, System.Single roll); // 0x0731f474
	System.Void TP2FPADSTransition(WizardGames.Soc.Common.Unity.CameraStateController controller); // 0x0731ef54
	static System.Boolean AdsParametersCheck(WizardGames.Soc.Common.Unity.CameraStateController controller); // 0x0731fb08
	System.Void SwitchAds(WizardGames.Soc.Common.Unity.CameraStateController controller, System.Boolean adsIn); // 0x0731fc70
	UnityEngine.Vector3 StateEuler(WizardGames.Soc.Common.Unity.CameraStateController controller, UnityEngine.Vector3 controlEuler); // 0x0731f7e4
	System.Single LimitPitch(System.Single pitch, System.Single limitPitch); // 0x0731df84
	static System.Void .cctor(); // 0x0731fd8c
	System.Void <.ctor>b__32_0(System.UInt64 task, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> result); // 0x0731fe60
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.CameraFreeState : WizardGames.Soc.Common.Unity.BaseCameraState
{
	SocLogger logger; // 0x88
	System.Boolean ObChanged; // 0x90
	System.Void OnEnter(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.Unity.CameraState preState); // 0x073200ec
	System.Int32 RenderUpdate(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.SimpleCustom.UserCmd nowCmd, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x07320180
	System.Int32 LateUpdate(WizardGames.Soc.Common.Unity.ICameraStateController controller, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x0732027c
	WizardGames.Soc.Common.Unity.CameraPosAndRot UpdateCameraLatePosAndRot(WizardGames.Soc.Common.Unity.CameraStateController controller, System.Single yaw, System.Single pitch, UnityEngine.Transform cameraLocator); // 0x07320b54
	System.Void .ctor(); // 0x07320cac
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.CameraState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.CameraState None = 0;
	static WizardGames.Soc.Common.Unity.CameraState FirstSingle = 1;
	static WizardGames.Soc.Common.Unity.CameraState Third = 2;
	static WizardGames.Soc.Common.Unity.CameraState FirstDouble = 3;
	static WizardGames.Soc.Common.Unity.CameraState Free = 4;
	static WizardGames.Soc.Common.Unity.CameraState Story = 5;
	static WizardGames.Soc.Common.Unity.CameraState Highlight = 6;
	static WizardGames.Soc.Common.Unity.CameraState Construction = 7;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.CameraThirdHierarchyState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.CameraThirdHierarchyState None = 0;
	static WizardGames.Soc.Common.Unity.CameraThirdHierarchyState InMantle = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.CameraMode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.CameraMode NONE = 0;
	static WizardGames.Soc.Common.Unity.CameraMode DEFAULT_FP = 1;
	static WizardGames.Soc.Common.Unity.CameraMode DEFAULT_TP = 2;
	static WizardGames.Soc.Common.Unity.CameraMode DYING = 3;
	static WizardGames.Soc.Common.Unity.CameraMode ZIPLINE = 4;
	static WizardGames.Soc.Common.Unity.CameraMode ADS = 5;
	static WizardGames.Soc.Common.Unity.CameraMode VEHICLE_TP = 6;
	static WizardGames.Soc.Common.Unity.CameraMode VEHICLE_FP = 7;
	static WizardGames.Soc.Common.Unity.CameraMode SLEEP = 8;
	static WizardGames.Soc.Common.Unity.CameraMode GM_FP = 9;
	static WizardGames.Soc.Common.Unity.CameraMode GM_TP = 10;
	static WizardGames.Soc.Common.Unity.CameraMode Story = 11;
	static WizardGames.Soc.Common.Unity.CameraMode PHOTO_FP = 12;
	static WizardGames.Soc.Common.Unity.CameraMode PHOTO_TP = 13;
	static WizardGames.Soc.Common.Unity.CameraMode PHOTO_VEHICLE_FP = 14;
	static WizardGames.Soc.Common.Unity.CameraMode PHOTO_VEHICLE_TP = 15;
	static WizardGames.Soc.Common.Unity.CameraMode AnchorFree = 16;
	static WizardGames.Soc.Common.Unity.CameraMode AnchorFirstFollow = 17;
	static WizardGames.Soc.Common.Unity.CameraMode AnchorThirdFollow = 18;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.FovChangeType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.FovChangeType Constant = 0;
	static WizardGames.Soc.Common.Unity.FovChangeType Lerp = 1;
	static WizardGames.Soc.Common.Unity.FovChangeType SmoothDamp = 2;
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.FovChangeInfo : System.ValueType
{
	System.Single Fov; // 0x10
	WizardGames.Soc.Common.Unity.FovChangeType FovChangeType; // 0x14
	System.Single Para; // 0x18
	System.Single SmoothDampVelocity; // 0x1c
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.CameraStateController : System.Object, WizardGames.Soc.Common.Unity.ICameraStateController
{
	static System.String SceneCameraAssetPath = "Camera/SceneCamera";
	static System.String SceneCameraName = "SceneCamera";
	static System.String ThirdPlayerViewGoPath = "MyPlayerTp";
	WizardGames.Soc.Common.Unity.ICameraState _nowCameraState; // 0x10
	WizardGames.Soc.Common.Unity.CameraState _previousState; // 0x18
	WizardGames.Soc.Common.Unity.CameraState _nowState; // 0x1c
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.CameraState,WizardGames.Soc.Common.Unity.ICameraState> _states; // 0x20
	UnityEngine.GameObject _cameraRoot; // 0x28
	System.Action<WizardGames.Soc.Common.Unity.CameraState,WizardGames.Soc.Common.Unity.CameraState> CameraStateChange; // 0x30
	System.Action<UnityEngine.Matrix4x4> OnUpdateCameraRender; // 0x38
	System.Action<UnityEngine.GameObject> OnUpdateCameraPostProcess; // 0x40
	System.Action OnTP2FPADSTransitionFinished; // 0x48
	System.Action<System.Boolean> OnTPCameraEnterOrExitPlayer; // 0x50
	static System.String CameraRootNames; // 0x0
	System.Action FinishFovChange; // 0x58
	WizardGames.Soc.Common.Entity.PlayerEntity <MyEntity>k__BackingField; // 0x60
	UnityEngine.GameObject MyPlayerGo; // 0x68
	UnityEngine.GameObject ThirdPlayerViewGo; // 0x70
	System.Boolean EnableCameraShake; // 0x78
	System.Single hitYaw; // 0x7c
	System.Single hitRoll; // 0x80
	System.Single hitPitch; // 0x84
	System.Single tpHitYaw; // 0x88
	System.Single tpHitRoll; // 0x8c
	System.Single tpHitPitch; // 0x90
	System.Single littleEyeYaw; // 0x94
	System.Single littleEyeRoll; // 0x98
	System.Single littleEyePitch; // 0x9c
	System.Single PitchOffset; // 0xa0
	System.Single CameraYaw; // 0xa4
	System.Single CameraPitch; // 0xa8
	System.Single CameraRoll; // 0xac
	System.Single VehicleCameraRoll; // 0xb0
	System.Single PunchRoll; // 0xb4
	UnityEngine.Vector3 CurrentGunFovOffset; // 0xb8
	System.Single CurrentGunFov; // 0xc4
	WizardGames.Soc.Common.Unity.FovChangeInfo FovChangeInfo; // 0xc8
	WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo <MgrGo>k__BackingField; // 0xd8
	WizardGames.Soc.Common.Unity.CameraState get_NowState(); // 0x07320dd4
	WizardGames.Soc.Common.Unity.CameraState get_PreviousState(); // 0x07320e38
	UnityEngine.GameObject get_CameraRoot(); // 0x07320e9c
	WizardGames.Soc.Common.Entity.PlayerEntity get_MyEntity(); // 0x0732100c
	System.Void set_MyEntity(WizardGames.Soc.Common.Entity.PlayerEntity value); // 0x07321070
	WizardGames.Soc.Common.Unity.ICameraState get_NowCameraState(); // 0x073210f0
	System.Single get_FpCameraYaw(); // 0x0731e084
	System.Single get_FpCameraPitch(); // 0x0731e0f8
	System.Single get_FpCameraRoll(); // 0x0731e16c
	System.Single get_TpCameraYaw(); // 0x07321154
	System.Single get_TpCameraPitch(); // 0x073211c8
	System.Single get_TpCameraRoll(); // 0x0732123c
	System.Single get_TargetCameraRoll(); // 0x0731e01c
	WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo get_MgrGo(); // 0x073212b0
	System.Void set_MgrGo(WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo value); // 0x07321314
	System.Void Init(UnityEngine.GameObject myPlayerGo, WizardGames.Soc.Common.Entity.PlayerEntity myEntity, WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo mgrGo); // 0x07321394
	System.Void Destroy(); // 0x07321a88
	System.Void InitGo(System.Boolean force); // 0x0731cc4c
	System.Void FPRenderForceUpdate(System.Single yaw, System.Single pitch, UnityEngine.Transform cameraLocator); // 0x07321db0
	System.Void ChangeState(WizardGames.Soc.Common.Unity.CameraState state); // 0x073218b8
	System.Boolean CheckCanChangeState(WizardGames.Soc.Common.Unity.CameraState stateEnum, WizardGames.Soc.Common.Unity.ICameraState& state); // 0x07321ef0
	WizardGames.Soc.Common.Unity.ICameraState GetCameraState(WizardGames.Soc.Common.Unity.CameraState state); // 0x07321630
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ICameraState> GetAllStates(); // 0x073226d8
	System.Void RenderUpdate(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x07322778
	System.Void LateUpdate(System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x07322968
	System.Void PhotoLateUpdate(System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x07322de0
	UnityEngine.Vector2 CorrectShootPitchYaw(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x07322eec
	System.Void SetLitteEyeParas(System.Single yaw, System.Single pitch, System.Single roll); // 0x07322fe8
	System.Single AngleNormalize(System.Single angle); // 0x0731f984
	System.Void AddAnimationCameraShake(System.Boolean isFp, UnityEngine.Vector3 addPos, UnityEngine.Quaternion addRot); // 0x07323080
	System.Void AddAnimationCameraShakeWorld(UnityEngine.Vector3 addPos, UnityEngine.Quaternion addRot); // 0x07323260
	System.Single GetCameraShakeHitWeight(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0732339c
	System.Void .ctor(); // 0x07323504
	static System.Void .cctor(); // 0x073235c8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.CameraStoryState : WizardGames.Soc.Common.Unity.BaseCameraState, WizardGames.Soc.Common.Unity.ICameraState
{
	SocLogger logger; // 0x88
	System.Boolean entered; // 0x90
	System.Void OnEnter(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.Unity.CameraState preState); // 0x07323630
	System.Int32 LateUpdate(WizardGames.Soc.Common.Unity.ICameraStateController controller, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x073236c4
	System.Void .ctor(); // 0x073225b0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.CameraThirdState : WizardGames.Soc.Common.Unity.BaseCameraState, WizardGames.Soc.Common.Unity.Ease.ICameraEaseController, System.IDisposable
{
	static SocLogger logger; // 0x0
	System.Single _cameraHideDistance; // 0x88
	System.Single _cameraCrouchHideDistance; // 0x8c
	System.Single _cameraDyingHideDistance; // 0x90
	System.Single _cameraSphereCastRadius; // 0x94
	System.Single _cameraRecoveryDelay; // 0x98
	System.Single _lastHitDistance; // 0x9c
	System.Boolean _lastCollided; // 0xa0
	UnityEngine.Vector3 _lastCameraLocalPos; // 0xa4
	UnityEngine.Vector3 _lastSceneCameraLocalPos; // 0xb0
	System.Single _curRecoveryDelay; // 0xbc
	System.Boolean _isDelaying; // 0xc0
	System.Boolean _isRecovering; // 0xc1
	UnityEngine.Vector3 _lastPosOffset; // 0xc4
	WizardGames.Soc.Common.Unity.Ease.CameraEaseUnit <CameraEaseUnit>k__BackingField; // 0xd0
	WizardGames.Soc.Common.Unity.Ease.CameraEaseData _cameraEaseData; // 0xd8
	WizardGames.Soc.Common.Unity.Ease.CameraEaseData _cameraEaseDyingData; // 0xe0
	WizardGames.Soc.Common.Unity.Ease.CameraEaseData _cameraEaseRecoverData; // 0xe8
	System.Boolean _isDelayTp2Fp; // 0xf0
	System.Action _onDelayTp2FpFinished; // 0xf8
	System.Boolean _isFirstUpdate; // 0x100
	static WizardGames.Soc.Common.Unity.TPS.TPSCameraState s_DefaultCameraState; // 0x8
	WizardGames.Soc.Common.Entity.PlayerEntity playerEntity; // 0x108
	System.Boolean lastIsCrouch; // 0x110
	System.Boolean enterPlayerBody; // 0x111
	UnityEngine.Quaternion _renderRotation; // 0x114
	WizardGames.Soc.Common.Unity.CameraThirdStateController _cameraThirdStateController; // 0x128
	WizardGames.Soc.Common.Unity.TPS.TPSCameraListData _tpsCameraListData; // 0x130
	WizardGames.Soc.Common.Unity.TPS.TPSCameraStateTransitionListData _tpsCameraStateTransitionListData; // 0x138
	UnityEngine.GameObject bindGo; // 0x140
	UnityEngine.RaycastHit[] _cameraHitResults; // 0x148
	System.Collections.Generic.List<UnityEngine.RaycastHit> _cameraHitResultList; // 0x150
	WizardGames.Soc.Common.Data.TPSCharacterStateType currentCharacterStateType; // 0x158
	WizardGames.Soc.Common.Unity.TPS.TPSCameraStateType currentStateType; // 0x15c
	WizardGames.Soc.Common.Unity.TPS.TPSCameraStateType lastStateType; // 0x160
	System.Boolean useSmooth; // 0x164
	System.Single smoothTime; // 0x168
	WizardGames.Soc.Common.Unity.TPS.TPSCameraState currentState; // 0x170
	WizardGames.Soc.Common.Unity.TPS.TPSCameraState lerpSourceState; // 0x178
	WizardGames.Soc.Common.Unity.TPS.TPSCameraState lerpTargetState; // 0x180
	WizardGames.Soc.Common.Unity.Ease.CameraEaseUnit get_CameraEaseUnit(); // 0x0732388c
	System.Void set_CameraEaseUnit(WizardGames.Soc.Common.Unity.Ease.CameraEaseUnit value); // 0x073238f0
	System.Void .ctor(); // 0x07321fb8
	System.Void OnDestroy(); // 0x07323a24
	UnityEngine.Quaternion GetThirdPlayerViewGoRotation(); // 0x07323bd0
	System.Void OnCameraEaseDataLoaded(WizardGames.Soc.Common.Unity.Ease.CameraEaseData cameraEaseData); // 0x07323c3c
	System.Void OnCameraEaseDyingDataLoaded(WizardGames.Soc.Common.Unity.Ease.CameraEaseData cameraEaseData); // 0x07323d18
	System.Void OnCameraEaseRecoverDataLoaded(WizardGames.Soc.Common.Unity.Ease.CameraEaseData cameraEaseData); // 0x07323d98
	System.Void Dispose(); // 0x07323e18
	System.Void OnEnter(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.Unity.CameraState preState); // 0x0732402c
	System.Void RefreshSceneFov(System.Single fov); // 0x07325040
	System.Void RefreshVehicleFov(System.Single fov); // 0x073250c0
	System.Void OnLeave(WizardGames.Soc.Common.Unity.ICameraStateController controller); // 0x07325238
	System.Int32 RenderUpdate(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.SimpleCustom.UserCmd nowCmd, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x07325620
	System.Int32 LateUpdate(WizardGames.Soc.Common.Unity.ICameraStateController controller, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x0732605c
	System.Int32 PhotoLateUpdate(WizardGames.Soc.Common.Unity.ICameraStateController controller, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x07328810
	System.Void CameraEase(UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation); // 0x073280ec
	System.Boolean DelayTp2FpCameraEase(UnityEngine.Vector3 targetPointPos, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation); // 0x07327e00
	System.Void DelayDyingTp2Fp(System.Action callback); // 0x073294b8
	System.Void CameraShake(WizardGames.Soc.Common.Unity.CameraStateController controller, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot); // 0x07326850
	System.Void CameraRotate(WizardGames.Soc.Common.Unity.CameraStateController controller, UnityEngine.Quaternion rotation); // 0x07326bc4
	WizardGames.Soc.Common.Unity.CameraPosAndRot UpdateCameraLatePosAndRot(WizardGames.Soc.Common.Unity.CameraStateController castController, UnityEngine.Transform cameraLocator, UnityEngine.Vector3& targetPointPos, UnityEngine.Vector3& armDirection); // 0x073264e4
	System.Void HandlePlayerBody(WizardGames.Soc.Common.Unity.CameraStateController castController, UnityEngine.Vector3 position); // 0x073299bc
	System.Void TPSSmooth(UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3 targetPos, UnityEngine.Vector3& cameraRayPos); // 0x07326f18
	WizardGames.Soc.Common.Unity.TPS.TPSCameraStateTransition GetTPSCameraTransitionData(); // 0x07329c74
	System.Void Damping(UnityEngine.Vector3& pos, WizardGames.Soc.Common.Unity.CameraStateController castController, System.Int32 interval); // 0x0732775c
	System.Void UpdateSceneCameraPos(WizardGames.Soc.Common.Unity.CameraStateController controller, UnityEngine.Vector3 targetPointPos); // 0x07327ac4
	System.Void UpdateLastSceneCameraLocalPos(WizardGames.Soc.Common.Unity.CameraStateController controller, UnityEngine.Vector3 targetPointPos); // 0x0732869c
	System.Void RecoveryDamping(UnityEngine.Vector3& pos); // 0x07327bfc
	UnityEngine.Vector2 CorrectShootPitchYaw(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.SimpleCustom.UserCmd nowCmd); // 0x07329e24
	System.Void ChangeTpsCameraListData(WizardGames.Soc.Common.Data.TPSCharacterStateType characterStateType); // 0x0732aaac
	System.Void OnLoadTpsCameraListData(WizardGames.Soc.Common.Data.TPSCharacterStateType characterStateType); // 0x0732b3f4
	System.Void SetTpsCameraState(); // 0x0732b190
	System.Void LoadTpsCameraListData(System.String path); // 0x0732b28c
	System.Void LoadTpsCameraStateTransitionListData(); // 0x07324c64
	System.Void ChangeTPSCameraState(WizardGames.Soc.Common.Unity.TPS.TPSCameraStateType wantStateType, System.Boolean hasSmooth, System.Boolean force); // 0x0732b5e4
	System.Void UpdateTPSCharacterState(System.Boolean force); // 0x0732480c
	System.Void UpdateTPSCameraState(System.Boolean hasSmooth, System.Boolean force); // 0x07324a74
	System.Void UpdateTPSState(); // 0x07326ea0
	System.Boolean CheckIsOnMount(WizardGames.Soc.Common.Unity.Go.BaseMountableGo baseMountableGo); // 0x07328a08
	System.Boolean CheckValid(WizardGames.Soc.Common.Unity.CameraStateController controller); // 0x0732b878
	UnityEngine.Vector3 GetTargetPoint(WizardGames.Soc.Common.Unity.CameraStateController controller, UnityEngine.Transform cameraLocator); // 0x07328afc
	UnityEngine.Vector3 GetTargetPointOnMount(WizardGames.Soc.Common.Unity.CameraStateController controller, WizardGames.Soc.Common.Unity.Go.BaseMountableGo baseMountableGo); // 0x07328de8
	System.Void ChangeTargetPointPosOnHorse(UnityEngine.Transform targetPoint, UnityEngine.Vector3 rootPos, System.Single dis); // 0x0732ba20
	UnityEngine.Vector3 CorrectTargetPointPosition(WizardGames.Soc.Common.Unity.Go.BaseMountableGo baseMountableGo, System.Single angle, System.Single maxAngle, UnityEngine.Vector3 axis, UnityEngine.Vector3 pos); // 0x0732bc34
	UnityEngine.Vector2 CameraShootPitchYaw(WizardGames.Soc.Common.Unity.CameraStateController controller, System.Single cameraPitch, System.Single cameraYaw); // 0x07329f28
	UnityEngine.Vector3 StateEuler(WizardGames.Soc.Common.Unity.CameraStateController controller, UnityEngine.Vector3 controlEuler); // 0x07325968
	UnityEngine.Vector3 GetArmPos(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Quaternion localRotation); // 0x073295e0
	System.Void CameraCollisionCulling(WizardGames.Soc.Common.Unity.CameraStateController controller, UnityEngine.Vector3& position, UnityEngine.Vector3 targetPointPos, UnityEngine.Vector3 armDirection, UnityEngine.Vector3 rayPos); // 0x0732720c
	System.Void HandlePlayerVisible(WizardGames.Soc.Common.Entity.PlayerEntity entity, UnityEngine.Vector3 targetPointPos); // 0x0732848c
	UnityEngine.Vector3 HandleCameraCollisionOnMount(UnityEngine.RaycastHit hitInfo, UnityEngine.Vector3 targetPointPos, UnityEngine.Vector3 armDirection); // 0x0732bef4
	UnityEngine.Vector3 HandleCameraCollision(WizardGames.Soc.Common.Unity.CameraStateController controller, System.Boolean isCollide, WizardGames.Soc.Common.Entity.PlayerEntity entity, UnityEngine.RaycastHit hitInfo, UnityEngine.Vector3 position, UnityEngine.Vector3 targetPointPos, UnityEngine.Vector3 armDirection, UnityEngine.Vector3 rayPos); // 0x0732bff4
	System.Void HandleCameraCollisionTimer(WizardGames.Soc.Common.Unity.CameraStateController controller, UnityEngine.RaycastHit hitInfo, System.Boolean isCollide, UnityEngine.Vector3 position, UnityEngine.Vector3 targetPointPos); // 0x0732c934
	System.Boolean CalVirtualCollisionPoint(UnityEngine.Vector3 hitPoint, UnityEngine.Vector3 normal, UnityEngine.Vector3 rayStart, UnityEngine.Vector3 rayEnd, UnityEngine.Vector3& virtualCollisionPoint); // 0x0732c738
	System.Single UpdateArmLength(UnityEngine.Vector3 eulerAngles); // 0x0732bde4
	System.Single CorrectAngle(System.Single angle); // 0x0732bb7c
	static System.Void .cctor(); // 0x0732cc88
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.CameraThirdState.<>c__DisplayClass75_0 : System.Object
{
	WizardGames.Soc.Common.Unity.CameraThirdState <>4__this; // 0x10
	System.String path; // 0x18
	System.Void .ctor(); // 0x0732b7a8
	System.Void <LoadTpsCameraListData>b__0(System.UInt64 task, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> results); // 0x0732cda0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.CameraThirdState.<>c__DisplayClass76_0 : System.Object
{
	WizardGames.Soc.Common.Unity.CameraThirdState <>4__this; // 0x10
	System.String path; // 0x18
	System.Void .ctor(); // 0x0732b810
	System.Void <LoadTpsCameraStateTransitionListData>b__0(System.UInt64 task, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> results); // 0x0732cfa0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.CameraThirdStateController : System.Object, WizardGames.Soc.Common.Unity.ICameraStateController
{
	WizardGames.Soc.Common.Unity.CameraThirdHierarchyState _nowCameraState; // 0x10
	WizardGames.Soc.Common.Unity.ICameraState _nowState; // 0x18
	WizardGames.Soc.Common.Unity.ICameraState _previousState; // 0x20
	UnityEngine.GameObject SceneCameraGo; // 0x28
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.CameraThirdHierarchyState,WizardGames.Soc.Common.Unity.ICameraState> _states; // 0x30
	UnityEngine.GameObject <CameraRoot>k__BackingField; // 0x38
	WizardGames.Soc.Common.Entity.PlayerEntity <MyEntity>k__BackingField; // 0x40
	WizardGames.Soc.Common.Unity.Character.CharacterConfig get_CharacterConfig(); // 0x0732d194
	System.Void OnDestroy(); // 0x07323aec
	System.Void OnEnter(WizardGames.Soc.Common.Unity.CameraStateController controller, WizardGames.Soc.Common.Unity.BaseCameraState baseCameraState); // 0x07324ef4
	WizardGames.Soc.Common.Unity.CameraThirdHierarchyState WantToState(); // 0x0732d224
	System.Void OnLeave(WizardGames.Soc.Common.Unity.CameraStateController controller); // 0x073255a4
	System.Void ChangeState(WizardGames.Soc.Common.Unity.CameraThirdHierarchyState state); // 0x0732d32c
	WizardGames.Soc.Common.Unity.ICameraState GetCameraState(WizardGames.Soc.Common.Unity.CameraThirdHierarchyState state); // 0x0732d4d0
	System.Void RenderUpdate(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x07325ec8
	UnityEngine.GameObject get_CameraRoot(); // 0x0732d7b0
	WizardGames.Soc.Common.Entity.PlayerEntity get_MyEntity(); // 0x0732d814
	System.Void set_MyEntity(WizardGames.Soc.Common.Entity.PlayerEntity value); // 0x0732d878
	System.Void .ctor(); // 0x07323970
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.CameraThirdStateInMantle : WizardGames.Soc.Common.Unity.BaseCameraState, WizardGames.Soc.Common.Unity.ICameraState
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<KAnimation.RootMotionWarping.RootMotionWarpingData> ResList; // 0x88
	System.Void OnCreate(WizardGames.Soc.Common.Unity.ICameraStateController controller); // 0x0732d8f8
	System.Void OnEnter(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.Unity.CameraState preState); // 0x0732da14
	System.Void OnLeave(WizardGames.Soc.Common.Unity.ICameraStateController controller); // 0x0732da90
	System.Int32 RenderUpdate(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.SimpleCustom.UserCmd nowCmd, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x0732db04
	System.Void .ctor(); // 0x0732d724
	static System.Void .cctor(); // 0x0732e190
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.CameraThirdStateNone : WizardGames.Soc.Common.Unity.BaseCameraState, WizardGames.Soc.Common.Unity.ICameraState
{
	
	System.Void OnCreate(WizardGames.Soc.Common.Unity.ICameraStateController controller); // 0x0732e264
	System.Void OnEnter(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.Unity.CameraState preState); // 0x0732e2d8
	System.Void OnLeave(WizardGames.Soc.Common.Unity.ICameraStateController controller); // 0x0732e354
	System.Int32 RenderUpdate(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.SimpleCustom.UserCmd nowCmd, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x0732e3c8
	System.Void .ctor(); // 0x0732d698
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.CameraPosAndRot : System.ValueType
{
	UnityEngine.Vector3 Position; // 0x10
	UnityEngine.Quaternion Rotation; // 0x1c
	System.Void .ctor(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); // 0x07329b9c
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.ICameraStateController : 
{
	
	UnityEngine.GameObject get_CameraRoot(); // 0x054e7844
	WizardGames.Soc.Common.Entity.PlayerEntity get_MyEntity(); // 0x054e7844
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.CameraBlendRule : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.CameraBlendRule None = 0;
	static WizardGames.Soc.Common.Unity.CameraBlendRule Blend = 1;
	static WizardGames.Soc.Common.Unity.CameraBlendRule FullCamera = 2;
	
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.ICameraState : 
{
	
	UnityEngine.Camera get_SceneCamera(); // 0x054e7844
	System.Boolean get_IsMyPlayerDead(); // 0x054c4760
	System.Boolean get_IsBlending(); // 0x054c4760
	System.Single get_BlendPercent(); // 0x054a5abc
	WizardGames.Soc.Common.Unity.CameraBlendRule get_BlendRule(); // 0x0548ba98
	System.Void OnCreate(WizardGames.Soc.Common.Unity.ICameraStateController controller); // 0x05523a54
	System.Void OnDestroy(); // 0x055049cc
	System.Void OnEnter(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.Unity.CameraState preState); // 0x05525b70
	System.Void OnLeave(WizardGames.Soc.Common.Unity.ICameraStateController controller); // 0x05523a54
	System.Void RefreshSceneFov(System.Single fov); // 0x05513724
	System.Void RefreshVehicleFov(System.Single fov); // 0x05513724
	System.Int32 RenderUpdate(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.SimpleCustom.UserCmd nowCmd, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x054a3ed0
	UnityEngine.Vector2 CorrectShootPitchYaw(WizardGames.Soc.Common.Unity.ICameraStateController controller, WizardGames.Soc.Common.SimpleCustom.UserCmd nowCmd); // 0x054b8850
	System.Int32 LateUpdate(WizardGames.Soc.Common.Unity.ICameraStateController controller, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x0549a8ec
	System.Int32 PhotoLateUpdate(WizardGames.Soc.Common.Unity.ICameraStateController controller, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x0549a8ec
	System.Void AddAnimationCameraShake(UnityEngine.Vector3 addPos, UnityEngine.Quaternion addRot); // 0x0551b2f8
	System.Void ClearAnimationCameraShake(); // 0x055049cc
	System.Void AddAnimationCameraShakeWorld(UnityEngine.Vector3 addPos, UnityEngine.Quaternion addRot); // 0x0551b2f8
	System.Void ClearAnimationCameraShakeWorld(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.MgrCamera : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.CameraStateController _controller; // 0x18
	WizardGames.Soc.Common.Unity.CameraMode <_modeNow>k__BackingField; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.CameraMode> _cameraModeList; // 0x28
	System.Int32 LOWEST_MODE_PRIORITY; // 0x30
	WizardGames.Soc.Common.Unity.CameraMode DEFAULT_CAMERAMODE; // 0x34
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.TPSCharacterStateType,WizardGames.Soc.Common.Unity.TPS.TPSCameraListData> TpsCameraListDataDict; // 0x38
	UnityEngine.GameObject bindGo; // 0x40
	System.Action<WizardGames.Soc.Common.Data.TPSCharacterStateType> OnChangeTpsCameraListDataAction; // 0x48
	System.Boolean <IsEnableUpdate>k__BackingField; // 0x50
	System.Boolean AttachNewTransform; // 0x51
	UnityEngine.Transform NewTransform; // 0x58
	System.Boolean inAds; // 0x60
	System.Boolean EnableBtnSwitchTps; // 0x61
	WizardGames.Soc.Common.Unity.CameraStateController get_Controller(); // 0x0732e510
	WizardGames.Soc.Common.Unity.CameraState get_NowState(); // 0x0732e574
	WizardGames.Soc.Common.Unity.CameraMode get__modeNow(); // 0x0732e618
	System.Void set__modeNow(WizardGames.Soc.Common.Unity.CameraMode value); // 0x0732e67c
	UnityEngine.Vector2 get_Forward2D(); // 0x0732e6f4
	UnityEngine.Camera get_SceneCamera(); // 0x0732e8a0
	System.Boolean get_IsEnableUpdate(); // 0x0732e9c8
	System.Void set_IsEnableUpdate(System.Boolean value); // 0x0732ea2c
	System.Action<WizardGames.Soc.Common.Unity.CameraState,WizardGames.Soc.Common.Unity.CameraState> get_OnCameraStateChangeAction(); // 0x0732eaa8
	System.Void set_OnCameraStateChangeAction(System.Action<WizardGames.Soc.Common.Unity.CameraState,WizardGames.Soc.Common.Unity.CameraState> value); // 0x0732eb18
	System.Action<UnityEngine.Matrix4x4> get_OnUpdateCameraRender(); // 0x0732eba0
	System.Void set_OnUpdateCameraRender(System.Action<UnityEngine.Matrix4x4> value); // 0x0732ec10
	System.Action get_OnTP2FPADSTransitionFinished(); // 0x0732ec98
	System.Void set_OnTP2FPADSTransitionFinished(System.Action value); // 0x0732ed08
	System.Void Init(UnityEngine.GameObject myPlayerGo, WizardGames.Soc.Common.Entity.PlayerEntity myEntity, WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo mgrGo); // 0x0552d210
	System.Void CleanUp(); // 0x055049cc
	System.Void SetCameraFarClipPlane(System.Single distance); // 0x0732faf8
	System.Void RenderUpdate(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x0732fd5c
	System.Void LateUpdate(System.Int32 interval, UnityEngine.Transform cameraLocator); // 0x0732ff10
	UnityEngine.Vector3 CorrectShootPitchYaw(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x0733000c
	System.Void SwitchFpTp(); // 0x07330098
	System.Void ChangeState(WizardGames.Soc.Common.Unity.CameraMode modeToChange, System.Boolean isEnter); // 0x07330178
	System.Void EnterCameraMode(WizardGames.Soc.Common.Unity.CameraMode modeToChange, System.Int32 priorityToChange, WizardGames.Soc.Common.Unity.CameraState stateToChange, System.Int32 priorityNow); // 0x073304e0
	System.Void LeaveCameraMode(WizardGames.Soc.Common.Unity.CameraMode modeToChange); // 0x07330834
	System.Void FindHighestPriorityCameraMode(WizardGames.Soc.Common.Unity.CameraMode& highestPriorityMode); // 0x07330bd4
	System.Void GetCameraModeConfig(WizardGames.Soc.Common.Unity.CameraMode mode, System.Int32& priority, WizardGames.Soc.Common.Unity.CameraState& state); // 0x073302ec
	System.Void HandleMutualExclusiveCameraModes(WizardGames.Soc.Common.Unity.CameraMode mode); // 0x07330430
	System.Void ClearAllCameraModes(); // 0x07330d8c
	System.Void ChangeState(WizardGames.Soc.Common.Unity.CameraState state); // 0x07330b50
	System.Void EnableCameraShake(System.Boolean enable); // 0x07330e5c
	System.Void AllowBtnTpsSwitch(System.Boolean enable); // 0x07330ee4
	System.Void AfterChangeState(System.Single yaw, System.Single pitch, UnityEngine.Transform cameraLocator); // 0x07330f60
	System.Void OnCharacterPoseStateChange(WizardGames.Soc.Common.Entity.PlayerEntity entity, WizardGames.Soc.Common.Entity.PlayerPoseStateEnum oldState, WizardGames.Soc.Common.Entity.PlayerPoseStateEnum newState); // 0x0732f764
	System.Void DelayDyingTp2Fp(); // 0x07331008
	System.Void OnCharacterStateChange(WizardGames.Soc.Common.Entity.PlayerEntity _, WizardGames.Soc.Common.Entity.PlayerCharacterStateEnum oldState, WizardGames.Soc.Common.Entity.PlayerCharacterStateEnum newState); // 0x0733134c
	System.Void OnUnAliveStateChange(System.Int64 entityId, WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum fromState, WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum toState); // 0x0733140c
	System.Void OnCharacterAdsStateChange(System.Int64 entityId, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum oldState, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum newState); // 0x073314cc
	System.Void InitTpCameraStateData(); // 0x0732f0d4
	System.Void RefreshFov(System.Single fov); // 0x07331774
	System.Void RefreshVehicleFov(System.Single fov); // 0x07331904
	System.Boolean GetMyPlayerDead(); // 0x07331a94
	System.Void Destroy(); // 0x07331bb0
	System.Void .ctor(); // 0x07331ce0
	static System.Void .cctor(); // 0x07331de8
	System.Void <DelayDyingTp2Fp>b__64_0(); // 0x07331ebc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.MgrCamera.<>c__DisplayClass68_0 : System.Object
{
	System.Object stateType; // 0x10
	WizardGames.Soc.Common.Data.TPSCharacterStateType characterStateType; // 0x18
	WizardGames.Soc.Common.Unity.MgrCamera <>4__this; // 0x20
	System.Void .ctor(); // 0x0733170c
	System.Void <InitTpCameraStateData>b__0(System.UInt64 arg1, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> result); // 0x07331f28
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.StateApplyRule : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.StateApplyRule And = 0;
	static WizardGames.Soc.Common.Unity.StateApplyRule Or = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.StateApplyType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.StateApplyType State = 0;
	static WizardGames.Soc.Common.Unity.StateApplyType Param = 1;
	static WizardGames.Soc.Common.Unity.StateApplyType ParamApply = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.AnimSpeedSetType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.AnimSpeedSetType F = 0;
