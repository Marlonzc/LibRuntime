
// Client.Runtime
class WizardGames.Soc.Common.CustomType.ThrowWeaponCustom : WizardGames.Soc.Common.CustomType.EmbeddedCustomBase, WizardGames.Soc.Common.Entity.IHeldItemEntity, WizardGames.Soc.Common.Entity.IItemEntity, WizardGames.Soc.Common.Entity.IEmbeddedCustom, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Share.Framework.IPredictType
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1365005966;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 TableId_Local; // 0x28
	System.Int32 <TriggerEffect>k__BackingField; // 0x30
	System.Int32 <TriggerMinNum>k__BackingField; // 0x34
	System.Int32 <TriggerMaxNum>k__BackingField; // 0x38
	System.Int32 <ReadyTime>k__BackingField; // 0x3c
	System.Int32 <ReloadTime>k__BackingField; // 0x40
	System.Int32 <DelayThrowTime>k__BackingField; // 0x44
	System.Boolean <DelayThrow>k__BackingField; // 0x48
	System.Int32 <TakeOutTime>k__BackingField; // 0x4c
	System.Int32[] <AdsorptionType>k__BackingField; // 0x50
	System.Single <FarThrowSpeed>k__BackingField; // 0x58
	System.Single <NearThrowSpeed>k__BackingField; // 0x5c
	System.Single <DudPercentage>k__BackingField; // 0x60
	System.Int32 GetClassHash(); // 0x0716c434
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0716c49c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0716c54c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0716c61c
	System.Int64 get_OwnerEntityId(); // 0x0716c6cc
	System.Void set_OwnerEntityId(System.Int64 value); // 0x0716c740
	System.Int64 get_ItemUid(); // 0x0716c7cc
	System.Void set_ItemUid(System.Int64 value); // 0x0716c840
	System.Int64 get_TableId(); // 0x0716c8cc
	System.Void set_TableId(System.Int64 value); // 0x0716c940
	System.Int32 get_Amount(); // 0x0716c9cc
	System.Void set_Amount(System.Int32 value); // 0x0716ca40
	System.Single get_Condition(); // 0x0716cacc
	System.Void set_Condition(System.Single value); // 0x0716cb40
	System.Single get_MaxCondition(); // 0x0716cbcc
	System.Void set_MaxCondition(System.Single value); // 0x0716cc40
	System.Int32 get_Position(); // 0x0716cccc
	System.Void set_Position(System.Int32 value); // 0x0716cd40
	System.Int32 get_TemplateId(); // 0x0716cdcc
	System.Void set_TemplateId(System.Int32 value); // 0x0716ce40
	System.Int64 get_NextFireTime(); // 0x0716cecc
	System.Void set_NextFireTime(System.Int64 value); // 0x0716cf40
	System.Boolean get_FarThrow(); // 0x0716cfcc
	System.Void set_FarThrow(System.Boolean value); // 0x0716d040
	System.Int64 get_SkinId(); // 0x0716d0cc
	System.Void set_SkinId(System.Int64 value); // 0x0716d140
	System.Int32 get_TriggerMode(); // 0x0716d1cc
	System.Void set_TriggerMode(System.Int32 value); // 0x0716d240
	System.Int32 get_TriggerMinTime(); // 0x0716d2cc
	System.Void set_TriggerMinTime(System.Int32 value); // 0x0716d340
	System.Int32 get_TriggerMaxTime(); // 0x0716d3cc
	System.Void set_TriggerMaxTime(System.Int32 value); // 0x0716d440
	System.Boolean get_IsRFDetonation(); // 0x0716d4cc
	System.Void set_IsRFDetonation(System.Boolean value); // 0x0716d540
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0716d5cc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0716da58
	WizardGames.Soc.Share.Framework.IPredictType GetNewInstance(System.Int64 id); // 0x0716de84
	System.Void .ctor(System.Int64 id); // 0x0716df24
	System.Boolean get_isBroken(); // 0x0716dfcc
	System.Int32 get_TriggerEffect(); // 0x0716e03c
	System.Void set_TriggerEffect(System.Int32 value); // 0x0716e0a0
	System.Int32 get_TriggerMinNum(); // 0x0716e118
	System.Void set_TriggerMinNum(System.Int32 value); // 0x0716e17c
	System.Int32 get_TriggerMaxNum(); // 0x0716e1f4
	System.Void set_TriggerMaxNum(System.Int32 value); // 0x0716e258
	System.Int32 get_ReadyTime(); // 0x0716e2d0
	System.Void set_ReadyTime(System.Int32 value); // 0x0716e334
	System.Int32 get_ReloadTime(); // 0x0716e3ac
	System.Void set_ReloadTime(System.Int32 value); // 0x0716e410
	System.Int32 get_DelayThrowTime(); // 0x0716e488
	System.Void set_DelayThrowTime(System.Int32 value); // 0x0716e4ec
	System.Boolean get_DelayThrow(); // 0x0716e564
	System.Void set_DelayThrow(System.Boolean value); // 0x0716e5c8
	System.Int32 get_TakeOutTime(); // 0x0716e644
	System.Void set_TakeOutTime(System.Int32 value); // 0x0716e6a8
	System.Int32[] get_AdsorptionType(); // 0x0716e720
	System.Void set_AdsorptionType(System.Int32[] value); // 0x0716e784
	System.Single get_FarThrowSpeed(); // 0x0716e804
	System.Void set_FarThrowSpeed(System.Single value); // 0x0716e868
	System.Single get_NearThrowSpeed(); // 0x0716e8e0
	System.Void set_NearThrowSpeed(System.Single value); // 0x0716e944
	System.Single get_DudPercentage(); // 0x0716e9bc
	System.Void set_DudPercentage(System.Single value); // 0x0716ea20
	System.Void LoadTableParam(); // 0x0716ea98
	System.Void OnDeploy(); // 0x0716f06c
	System.Void OnHolster(); // 0x0716f0cc
	static System.Void .cctor(); // 0x0716f12c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.TimeBombNode : WizardGames.Soc.Common.CustomType.StackableRFReceiverNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1221341805;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0716f5cc
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0716f634
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0716f6e4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0716f794
	System.Boolean get_IsRFDetonation(); // 0x0716f844
	System.Void set_IsRFDetonation(System.Boolean value); // 0x0716f8b8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0716f944
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0716fdac
	static System.Void .cctor(); // 0x07170210
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.TimerInt3Param : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 174749737;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x071705e0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07170648
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071706d4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07170760
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071707ec
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07170a54
	static System.Void .cctor(); // 0x07170d34
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.TimerIntAndIntParam : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 223641151;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07170efc
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07170f64
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07170ff0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0717107c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07171108
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07171370
	static System.Void .cctor(); // 0x07171650
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.TimerIntParam : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 90081382;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x071717e4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0717184c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071718d8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07171964
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071719f0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07171c58
	static System.Void .cctor(); // 0x07171f38
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.TimerLongAndIntParam : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1203986322;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07172098
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07172100
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0717218c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07172218
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071722a4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0717250c
	static System.Void .cctor(); // 0x071727ec
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.TimerLongAndLongParam : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1706379149;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07172980
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071729e8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07172a74
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07172b00
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07172b8c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07172df4
	static System.Void .cctor(); // 0x071730d4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.TimerLongIntIntParam : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1828296532;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07173268
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071732d0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0717335c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071733e8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07173474
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x071736dc
	static System.Void .cctor(); // 0x071739bc
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.TimerLongListParam : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1796233888;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07173b84
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07173bec
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07173c78
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07173d04
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07173d90
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07173ff8
	static System.Object DeserializeTimerLongListParamContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071742d8
	static System.Void .cctor(); // 0x071743a8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.TimerLongParam : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 797771888;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07174508
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07174570
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071745fc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07174688
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07174714
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0717497c
	static System.Void .cctor(); // 0x07174c5c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.TimerULongListParam : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1276123625;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07174dbc
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07174e24
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07174eb0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07174f3c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07174fc8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07175230
	static System.Object DeserializeTimerULongListParamContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07175510
	static System.Void .cctor(); // 0x071755e0
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.TimerULongParam : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 520164504;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07175740
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071757a8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07175834
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071758c0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0717594c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07175bb4
	static System.Void .cctor(); // 0x07175e94
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.TreeBriefData : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 2001273391;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07175ff4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0717605c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071760e8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07176174
	System.Byte get_Scale(); // 0x07176200
	System.Void set_Scale(System.Byte value); // 0x07176274
	System.Int32 get_RotY(); // 0x07176300
	System.Void set_RotY(System.Int32 value); // 0x07176374
	System.Int32 get_TemplateId(); // 0x07176400
	System.Void set_TemplateId(System.Int32 value); // 0x07176474
	System.Single get_PosX(); // 0x07176500
	System.Void set_PosX(System.Single value); // 0x07176574
	System.Single get_PosY(); // 0x07176600
	System.Void set_PosY(System.Single value); // 0x07176674
	System.Single get_PosZ(); // 0x07176700
	System.Void set_PosZ(System.Single value); // 0x07176774
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07176800
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07176b50
	static System.Void .cctor(); // 0x07176ef0
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.UgcLevel : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1024838785;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07177154
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071771bc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07177248
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071772d4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07177360
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x071775c8
	static System.Object DeserializeUgcLevelContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071778a8
	static System.Void .cctor(); // 0x0717797c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ULongQueueData : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1975177725;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07177b44
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07177bac
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07177c38
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07177cc4
	System.UInt64 get_UlongValue(); // 0x07177d50
	System.Void set_UlongValue(System.UInt64 value); // 0x07177dc4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07177e50
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x071780f0
	static System.Void .cctor(); // 0x07178408
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.UnderseaExploreTaskNode : WizardGames.Soc.Common.CustomType.PoiTaskNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1343309098;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07178568
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071785d0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07178680
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07178730
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071787e0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07178c34
	static System.Void .cctor(); // 0x07179054
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.UniqueItemNode : WizardGames.Soc.Common.CustomType.BaseItemNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 279237543;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07179354
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071793bc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0717946c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0717951c
	System.Int32 get_Status(); // 0x071795cc
	System.Void set_Status(System.Int32 value); // 0x07179640
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071796cc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07179ae4
	System.Void .ctor(System.Int64 bizId, System.Int64 index); // 0x07179f18
	static System.Void .cctor(); // 0x07179fc8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.UseItemCustom : WizardGames.Soc.Common.CustomType.CustomBaseItem, WizardGames.Soc.Common.Entity.IHeldItemEntity, WizardGames.Soc.Common.Entity.IItemEntity, WizardGames.Soc.Common.Entity.IEmbeddedCustom, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Share.Framework.IPredictType
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1036771144;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0717a330
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0717a398
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0717a448
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0717a4f8
	System.Int64 get_NextFireTime(); // 0x0717a5a8
	System.Void set_NextFireTime(System.Int64 value); // 0x0717a61c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0717a6a8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0717ab10
	WizardGames.Soc.Share.Framework.IPredictType GetNewInstance(System.Int64 id); // 0x0717af64
	System.Void .ctor(System.Int64 id); // 0x0717b004
	System.Void OnDeploy(); // 0x0717b0ac
	System.Void OnHolster(); // 0x0717b10c
	static System.Void .cctor(); // 0x0717b16c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ValueDebugInfo : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1699316826;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0717b508
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0717b570
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0717b5fc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0717b6d0
	System.String get_FieldName(); // 0x0717b75c
	System.Void set_FieldName(System.String value); // 0x0717b7d0
	System.String get_FieldValue(); // 0x0717b85c
	System.Void set_FieldValue(System.String value); // 0x0717b8d0
	System.String get_ValueCfgName(); // 0x0717b95c
	System.Void set_ValueCfgName(System.String value); // 0x0717b9d0
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.ValueDebugInfo> get_Children(); // 0x0717ba5c
	System.Void set_Children(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.ValueDebugInfo> value); // 0x0717bafc
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x0717bb88
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0717bce8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0717c0dc
	static System.Object DeserializeValueDebugInfoContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0717c474
	static System.Void .cctor(); // 0x0717c544
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.VarDebugInfo : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 98611904;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0717c740
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0717c7a8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0717c834
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0717c8c0
	System.Int64 get_VarId(); // 0x0717c94c
	System.Void set_VarId(System.Int64 value); // 0x0717c9c0
	System.String get_VarValue(); // 0x0717ca4c
	System.Void set_VarValue(System.String value); // 0x0717cac0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0717cb4c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0717ce10
	static System.Void .cctor(); // 0x0717d14c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.VariableId : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 655868547;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0717d2e0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0717d348
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0717d3d4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0717d460
	System.Int64 get_VarId(); // 0x0717d4ec
	System.Void set_VarId(System.Int64 value); // 0x0717d560
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0717d5ec
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0717d88c
	static System.Void .cctor(); // 0x0717dba4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.Variable : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1147408437;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0717dd04
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0717dd6c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0717ddf8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0717de84
	WizardGames.Soc.Common.SimpleCustom.EVariableType get_VariableType(); // 0x0717df10
	System.Void set_VariableType(WizardGames.Soc.Common.SimpleCustom.EVariableType value); // 0x0717df84
	System.Boolean get_BoolValue(); // 0x0717e010
	System.Void set_BoolValue(System.Boolean value); // 0x0717e084
	System.Int64 get_LongValue(); // 0x0717e110
	System.Void set_LongValue(System.Int64 value); // 0x0717e184
	System.Single get_FloatValue(); // 0x0717e210
	System.Void set_FloatValue(System.Single value); // 0x0717e284
	System.String get_StringValue(); // 0x0717e310
	System.Void set_StringValue(System.String value); // 0x0717e384
	WizardGames.Soc.Share.Framework.TypeBase get_ObjectValue(); // 0x0717e410
	System.Void set_ObjectValue(WizardGames.Soc.Share.Framework.TypeBase value); // 0x0717e484
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0717e510
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0717e8f0
	static System.Void .cctor(); // 0x0717ece4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.VehicleItemContainerNode : WizardGames.Soc.Common.CustomType.ItemContainerNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 596483992;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0717ef48
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0717efb0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0717f060
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0717f110
	System.Int64 get_VehicleModuleTemplateId(); // 0x0717f1c0
	System.Void set_VehicleModuleTemplateId(System.Int64 value); // 0x0717f234
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0717f2c0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0717f7ac
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x0717fbe8
	static System.Object DeserializeVehicleItemContainerNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0717fe40
	static System.Void .cctor(); // 0x0717ff14
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.VehicleModuleCustom : WizardGames.Soc.Common.CustomType.EmbeddedCustomBase, WizardGames.Soc.Common.Entity.IBaseMountableEntity, WizardGames.Soc.Common.Entity.ICombatEntity, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.IBaseVehicleEntity, WizardGames.Soc.Common.Entity.IVehicleModuleCustom, WizardGames.Soc.Common.Entity.IHitableEntity, WizardGames.Soc.Common.Entity.IShortcutEntity, WizardGames.Soc.Common.Entity.IPlatformEntity, WizardGames.Soc.Common.Entity.IHaveEmbedded, WizardGames.Soc.Share.Framework.IPredictType
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 36;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Boolean <HasInitProperty>k__BackingField; // 0x28
	System.Collections.Generic.List<System.Int64> subscribeIds; // 0x30
	System.Boolean IsClient; // 0x38
	System.Single <PosX>k__BackingField; // 0x3c
	System.Single <PosY>k__BackingField; // 0x40
	System.Single <PosZ>k__BackingField; // 0x44
	System.Single <RotateX>k__BackingField; // 0x48
	System.Single <RotateY>k__BackingField; // 0x4c
	System.Single <RotateZ>k__BackingField; // 0x50
	System.Single <LastHp>k__BackingField; // 0x54
	System.Int64 <LastAttackedTime>k__BackingField; // 0x58
	System.Single <SecondsSinceAttacked>k__BackingField; // 0x60
	System.Int64 <LastAttackPlayerId>k__BackingField; // 0x68
	System.Int64 <LastAttackedTimeByPlayer>k__BackingField; // 0x70
	System.Int64 <KillPlayerId>k__BackingField; // 0x78
	System.Single[] <BaseProtection>k__BackingField; // 0x80
	System.Single[][] <AreaProtections>k__BackingField; // 0x88
	System.Int32 <CombatTemplateId>k__BackingField; // 0x90
	System.Int32 <DefenseTemplateId>k__BackingField; // 0x94
	System.Boolean <HasOtherMountableNearby>k__BackingField; // 0x98
	System.Single <VelocityX>k__BackingField; // 0x9c
	System.Single <VelocityY>k__BackingField; // 0xa0
	System.Single <VelocityZ>k__BackingField; // 0xa4
	System.Boolean CanPlatform; // 0xa8
	System.Collections.Generic.HashSet<System.Int64> _childrenList; // 0xb0
	System.Int64 <firstTakeInPlayerId>k__BackingField; // 0xb8
	System.Boolean <moveAwayPlayer>k__BackingField; // 0xc0
	System.Int32 <SpawnType>k__BackingField; // 0xc4
	System.Int64 <BornTime>k__BackingField; // 0xc8
	System.Int64 <LastDriverId>k__BackingField; // 0xd0
	System.Single[] <RiderProtection>k__BackingField; // 0xd8
	System.Int32 <Attribution>k__BackingField; // 0xe0
	System.Boolean <IsAuthority>k__BackingField; // 0xe4
	System.Int32 <PosKey>k__BackingField; // 0xe8
	System.Action<System.Int32,WizardGames.Soc.Common.Entity.IItemEntity> OnEngineItemChanged; // 0xf0
	System.Int32 GetClassHash(); // 0x07180214
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07180278
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071803d0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07180660
	System.Int64 get_BelongEntityId(); // 0x071807b8
	System.Void set_BelongEntityId(System.Int64 value); // 0x0718082c
	System.Int32 get_Flag(); // 0x071808b8
	System.Void set_Flag(System.Int32 value); // 0x0718092c
	System.Int64 get_TableId(); // 0x071809b8
	System.Void set_TableId(System.Int64 value); // 0x07180a2c
	System.Boolean get_IsGround(); // 0x07180ab8
	System.Void set_IsGround(System.Boolean value); // 0x07180b2c
	System.Int64 get_Seat1Id(); // 0x07180bb8
	System.Void set_Seat1Id(System.Int64 value); // 0x07180c2c
	System.Int64 get_Seat2Id(); // 0x07180cb8
	System.Void set_Seat2Id(System.Int64 value); // 0x07180d2c
	System.Int64 get_Seat3Id(); // 0x07180db8
	System.Void set_Seat3Id(System.Int64 value); // 0x07180e2c
	System.Int64 get_Seat4Id(); // 0x07180eb8
	System.Void set_Seat4Id(System.Int64 value); // 0x07180f2c
	System.Int64 get_Seat5Id(); // 0x07180fb8
	System.Void set_Seat5Id(System.Int64 value); // 0x0718102c
	System.Int64 get_Seat6Id(); // 0x071810b8
	System.Void set_Seat6Id(System.Int64 value); // 0x0718112c
	System.Int64 get_Seat7Id(); // 0x071811b8
	System.Void set_Seat7Id(System.Int64 value); // 0x0718122c
	System.Int64 get_Seat8Id(); // 0x071812b8
	System.Void set_Seat8Id(System.Int64 value); // 0x0718132c
	System.Int64 get_Seat9Id(); // 0x071813b8
	System.Void set_Seat9Id(System.Int64 value); // 0x0718142c
	System.Int64 get_Seat10Id(); // 0x071814b8
	System.Void set_Seat10Id(System.Int64 value); // 0x0718152c
	System.Single get_MaxHp(); // 0x071815b8
	System.Void set_MaxHp(System.Single value); // 0x0718162c
	System.Single get_Hp(); // 0x071816b8
	System.Void set_Hp(System.Single value); // 0x0718172c
	System.Int64 get_TemplateId(); // 0x071817b8
	System.Void set_TemplateId(System.Int64 value); // 0x0718182c
	System.Int32 get_VehicleType(); // 0x071818b8
	System.Void set_VehicleType(System.Int32 value); // 0x0718192c
	System.Int64 get_DriverId(); // 0x071819b8
	System.Void set_DriverId(System.Int64 value); // 0x07181a2c
	System.Single get_Fuel(); // 0x07181ab8
	System.Void set_Fuel(System.Single value); // 0x07181b2c
	System.Single get_MaxFuel(); // 0x07181bb8
	System.Void set_MaxFuel(System.Single value); // 0x07181c2c
	System.Int32 get_Decoy(); // 0x07181cb8
	System.Void set_Decoy(System.Int32 value); // 0x07181d2c
	System.Boolean get_CanDecay(); // 0x07181db8
	System.Void set_CanDecay(System.Boolean value); // 0x07181e2c
	System.Single get_Power(); // 0x07181eb8
	System.Void set_Power(System.Single value); // 0x07181f2c
	System.Single get_MountableMaxSpeed(); // 0x07181fb8
	System.Void set_MountableMaxSpeed(System.Single value); // 0x0718202c
	System.Single get_FuelConsumption(); // 0x071820b8
	System.Void set_FuelConsumption(System.Single value); // 0x0718212c
	System.Int64 get_ModularCarId(); // 0x071821b8
	System.Void set_ModularCarId(System.Int64 value); // 0x0718222c
	System.Int32 get_SocketIndex(); // 0x071822b8
	System.Void set_SocketIndex(System.Int32 value); // 0x0718232c
	System.Int32 get_SocketsTaken(); // 0x071823b8
	System.Void set_SocketsTaken(System.Int32 value); // 0x0718242c
	System.Boolean get_Seat1Window(); // 0x071824b8
	System.Void set_Seat1Window(System.Boolean value); // 0x0718252c
	System.Boolean get_Seat2Window(); // 0x071825b8
	System.Void set_Seat2Window(System.Boolean value); // 0x0718262c
	System.Single get_Steering(); // 0x071826b8
	System.Void set_Steering(System.Single value); // 0x0718272c
	System.Single get_GasPedal(); // 0x071827b8
	System.Void set_GasPedal(System.Single value); // 0x0718282c
	System.Int32 get_SpeedInt(); // 0x071828b8
	System.Void set_SpeedInt(System.Int32 value); // 0x0718292c
	System.Int32 get_SteerAngleInt(); // 0x071829b8
	System.Void set_SteerAngleInt(System.Int32 value); // 0x07182a2c
	System.Single get_Break(); // 0x07182ab8
	System.Void set_Break(System.Single value); // 0x07182b2c
	System.Single get_Throttle(); // 0x07182bb8
	System.Void set_Throttle(System.Single value); // 0x07182c2c
	System.Boolean get_LightsAreOn(); // 0x07182cb8
	System.Void set_LightsAreOn(System.Boolean value); // 0x07182d2c
	System.Single get_DriveWheelVelocity(); // 0x07182db8
	System.Void set_DriveWheelVelocity(System.Single value); // 0x07182e2c
	System.Single get_SteerAngle(); // 0x07182eb8
	System.Void set_SteerAngle(System.Single value); // 0x07182f2c
	System.Single get_DriveWheelSlip(); // 0x07182fb8
	System.Void set_DriveWheelSlip(System.Single value); // 0x0718302c
	System.Boolean get_IsGrounded(); // 0x071830b8
	System.Void set_IsGrounded(System.Boolean value); // 0x0718312c
	System.Boolean get_IsEngineStartFailed(); // 0x071831b8
	System.Void set_IsEngineStartFailed(System.Boolean value); // 0x0718322c
	System.Single get_BornPosX(); // 0x071832b8
	System.Void set_BornPosX(System.Single value); // 0x0718332c
	System.Single get_BornPosY(); // 0x071833b8
	System.Void set_BornPosY(System.Single value); // 0x0718342c
	System.Single get_BornPosZ(); // 0x071834b8
	System.Void set_BornPosZ(System.Single value); // 0x0718352c
	System.Boolean get_IsInterior(); // 0x071835b8
	System.Void set_IsInterior(System.Boolean value); // 0x0718362c
	WizardGames.Soc.Common.CustomType.CustomBaseItem get_CarburetorCustom(); // 0x071836b8
	System.Void set_CarburetorCustom(WizardGames.Soc.Common.CustomType.CustomBaseItem value); // 0x0718377c
	WizardGames.Soc.Common.CustomType.CustomBaseItem get_CrankshaftCustom(); // 0x07183808
	System.Void set_CrankshaftCustom(WizardGames.Soc.Common.CustomType.CustomBaseItem value); // 0x071838cc
	WizardGames.Soc.Common.CustomType.CustomBaseItem get_PistonCustom(); // 0x07183958
	System.Void set_PistonCustom(WizardGames.Soc.Common.CustomType.CustomBaseItem value); // 0x07183a1c
	WizardGames.Soc.Common.CustomType.CustomBaseItem get_SparkPlugCustom(); // 0x07183aa8
	System.Void set_SparkPlugCustom(WizardGames.Soc.Common.CustomType.CustomBaseItem value); // 0x07183b6c
	WizardGames.Soc.Common.CustomType.CustomBaseItem get_ValveCustom(); // 0x07183bf8
	System.Void set_ValveCustom(WizardGames.Soc.Common.CustomType.CustomBaseItem value); // 0x07183cbc
	System.Boolean get_IsForceServerAuthority(); // 0x07183d48
	System.Void set_IsForceServerAuthority(System.Boolean value); // 0x07183dbc
	System.Boolean get_IsSleep(); // 0x07183e48
	System.Void set_IsSleep(System.Boolean value); // 0x07183ebc
	System.Boolean get_IsInvincible(); // 0x07183f48
	System.Void set_IsInvincible(System.Boolean value); // 0x07183fbc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07184048
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07184ab8
	System.Void InvokeChildOnCustomCreate(); // 0x0718515c
	System.Void InvokeChildOnCustomRemove(); // 0x07185510
	WizardGames.Soc.Share.Framework.IPredictType GetNewInstance(System.Int64 id); // 0x07185900
	System.Void SubscribePropertyChange(WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07185af0
	System.Void UnSubscribePropertyChange(); // 0x07187948
	System.Void OnBelongEntityId(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07187aac
	System.Void OnFlag(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07187b54
	System.Void OnIsGround(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07187cbc
	System.Void OnSeat1Id(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07187e24
	System.Void OnSeat2Id(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07187ecc
	System.Void OnSeat3Id(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07187f74
	System.Void OnSeat4Id(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x0718801c
	System.Void OnSeat5Id(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x071880c4
	System.Void OnSeat6Id(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x0718816c
	System.Void OnSeat7Id(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07188214
	System.Void OnSeat8Id(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x071882bc
	System.Void OnSeat9Id(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07188364
	System.Void OnSeat10Id(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x0718840c
	System.Void OnMaxHp(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x071884b4
	System.Void OnHp(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x0718855c
	System.Void OnDriverId(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07188604
	System.Void OnFuel(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x071886ac
	System.Void OnMaxFuel(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07188754
	System.Void OnCanDecay(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x071887fc
	System.Void OnPower(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x071888a4
	System.Void OnMountableMaxSpeed(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x0718894c
	System.Void OnFuelConsumption(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x071889f4
	System.Void OnModularCarId(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07188a9c
	System.Void OnSocketIndex(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07188b44
	System.Void OnSocketsTaken(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07188bec
	System.Void OnSeat1Window(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07188c94
	System.Void OnSeat2Window(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07188d3c
	System.Void OnSteering(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07188de4
	System.Void OnGasPedal(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07188f4c
	System.Void OnBreak(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x071890b4
	System.Void OnThrottle(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x0718921c
	System.Void OnLightsAreOn(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07189384
	System.Void OnDriveWheelVelocity(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x071894ec
	System.Void OnSteerAngle(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07189654
	System.Void OnDriveWheelSlip(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x071896fc
	System.Void OnIsGrounded(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07189864
	System.Void OnIsEngineStartFailed(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x071899cc
	System.Void OnCarburetorCustom(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07189b34
	System.Void OnCrankshaftCustom(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07189cb4
	System.Void OnPistonCustom(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07189e34
	System.Void OnSparkPlugCustom(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x07189fb4
	System.Void OnValveCustom(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x0718a134
	System.Void OnIsForceServerAuthority(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x0718a2b4
	System.Void OnSpeedIntChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x0718a35c
	System.Void OnSteerAngleIntChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.CustomType.VehicleModuleCustom target); // 0x0718a404
	System.Void .ctor(System.Int64 id); // 0x071859a0
	System.Single get_PosX(); // 0x0718a4c8
	System.Void set_PosX(System.Single value); // 0x0718a52c
	System.Single get_PosY(); // 0x0718a5a4
	System.Void set_PosY(System.Single value); // 0x0718a608
	System.Single get_PosZ(); // 0x0718a680
	System.Void set_PosZ(System.Single value); // 0x0718a6e4
	System.Single get_RotateX(); // 0x0718a75c
	System.Void set_RotateX(System.Single value); // 0x0718a7c0
	System.Single get_RotateY(); // 0x0718a838
	System.Void set_RotateY(System.Single value); // 0x0718a89c
	System.Single get_RotateZ(); // 0x0718a914
	System.Void set_RotateZ(System.Single value); // 0x0718a978
	System.Single get_LastHp(); // 0x0718a9f0
	System.Void set_LastHp(System.Single value); // 0x0718aa54
	System.Single[] get_BaseProtection(); // 0x0718aacc
	System.Void set_BaseProtection(System.Single[] value); // 0x0718ab30
	System.Int32 get_CombatTemplateId(); // 0x0718abb0
	System.Void set_CombatTemplateId(System.Int32 value); // 0x0718ac14
	System.Void set_DefenseTemplateId(System.Int32 value); // 0x0718ac8c
	System.Int32 get_DriversCount(); // 0x0718ad04
	System.Single get_VelocityX(); // 0x0718ad74
	System.Void set_VelocityX(System.Single value); // 0x0718add8
	System.Single get_VelocityY(); // 0x0718ae50
	System.Void set_VelocityY(System.Single value); // 0x0718aeb4
	System.Single get_VelocityZ(); // 0x0718af2c
	System.Void set_VelocityZ(System.Single value); // 0x0718af90
	System.Collections.Generic.HashSet<System.Int64> GetChildrenList(); // 0x0718b008
	System.Void set_firstTakeInPlayerId(System.Int64 value); // 0x0718b06c
	System.Int32 get_SpawnType(); // 0x0718b0e4
	System.Int64 get_VehicleLastAttackedTime(); // 0x0718b148
	System.Int64 get_VehicleLastRepairedTime(); // 0x0718b234
	System.Collections.Generic.IEnumerable<System.Int64> GetSeatedIds(); // 0x0718b320
	System.Int32 get_RemainLimitedAuthorityTs(); // 0x0718b454
	System.Boolean get_IsAuthority(); // 0x0718b4b8
	System.Void set_IsAuthority(System.Boolean value); // 0x0718b51c
	System.Boolean HasAnyMounted(); // 0x0718b598
	WizardGames.Soc.Common.Entity.IItemEntity get_Carburetor(); // 0x0718b6a0
	System.Void set_Carburetor(WizardGames.Soc.Common.Entity.IItemEntity value); // 0x0718b704
	WizardGames.Soc.Common.Entity.IItemEntity get_Crankshaft(); // 0x0718b7c8
	System.Void set_Crankshaft(WizardGames.Soc.Common.Entity.IItemEntity value); // 0x0718b82c
	WizardGames.Soc.Common.Entity.IItemEntity get_Piston(); // 0x0718b8f0
	System.Void set_Piston(WizardGames.Soc.Common.Entity.IItemEntity value); // 0x0718b954
	WizardGames.Soc.Common.Entity.IItemEntity get_SparkPlug(); // 0x0718ba18
	System.Void set_SparkPlug(WizardGames.Soc.Common.Entity.IItemEntity value); // 0x0718ba7c
	WizardGames.Soc.Common.Entity.IItemEntity get_Valve(); // 0x0718bb40
	System.Void set_Valve(WizardGames.Soc.Common.Entity.IItemEntity value); // 0x0718bba4
	WizardGames.Soc.Common.Entity.IItemEntity GetItemEntity(System.Int32 id); // 0x0718bc68
	System.Void OnItemChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue); // 0x0718bda8
	System.Void UnsubscribeEngineItemChange(); // 0x0718bf10
	System.Void SubscribeEngineItemChange(System.Action<System.Int32,WizardGames.Soc.Common.Entity.IItemEntity> cb); // 0x0718c014
	System.Void InitConfigData(); // 0x0718c100
	static System.Void .cctor(); // 0x0718c518
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.VehicleModuleCustom.<>c__DisplayClass185_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.VehicleModuleCustom <>4__this; // 0x10
	WizardGames.Soc.Common.CustomType.VehicleModuleCustom target; // 0x18
	System.Void .ctor(); // 0x071878e0
	System.Void <SubscribePropertyChange>b__0(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x0718d194
	System.Void <SubscribePropertyChange>b__1(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x0718d240
	System.Void <SubscribePropertyChange>b__2(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x0718d2ec
	System.Void <SubscribePropertyChange>b__3(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x0718d398
	System.Void <SubscribePropertyChange>b__4(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x0718d444
	System.Void <SubscribePropertyChange>b__5(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x0718d4f0
	System.Void <SubscribePropertyChange>b__6(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x0718d59c
	System.Void <SubscribePropertyChange>b__7(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x0718d648
	System.Void <SubscribePropertyChange>b__8(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x0718d6f4
	System.Void <SubscribePropertyChange>b__9(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x0718d7a0
	System.Void <SubscribePropertyChange>b__10(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x0718d84c
	System.Void <SubscribePropertyChange>b__11(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x0718d8f8
	System.Void <SubscribePropertyChange>b__12(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x0718d9a4
	System.Void <SubscribePropertyChange>b__13(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x0718da50
	System.Void <SubscribePropertyChange>b__14(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x0718dafc
	System.Void <SubscribePropertyChange>b__15(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x0718dba8
	System.Void <SubscribePropertyChange>b__16(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x0718dc54
	System.Void <SubscribePropertyChange>b__17(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x0718dd00
	System.Void <SubscribePropertyChange>b__18(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x0718ddac
	System.Void <SubscribePropertyChange>b__19(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x0718de58
	System.Void <SubscribePropertyChange>b__20(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x0718df04
	System.Void <SubscribePropertyChange>b__21(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x0718dfb0
	System.Void <SubscribePropertyChange>b__22(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x0718e05c
	System.Void <SubscribePropertyChange>b__23(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x0718e108
	System.Void <SubscribePropertyChange>b__24(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x0718e1b4
	System.Void <SubscribePropertyChange>b__25(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x0718e260
	System.Void <SubscribePropertyChange>b__26(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x0718e30c
	System.Void <SubscribePropertyChange>b__27(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x0718e3b8
	System.Void <SubscribePropertyChange>b__28(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x0718e464
	System.Void <SubscribePropertyChange>b__29(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x0718e510
	System.Void <SubscribePropertyChange>b__30(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x0718e5bc
	System.Void <SubscribePropertyChange>b__31(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x0718e668
	System.Void <SubscribePropertyChange>b__32(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x0718e714
	System.Void <SubscribePropertyChange>b__33(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x0718e7c0
	System.Void <SubscribePropertyChange>b__34(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x0718e86c
	System.Void <SubscribePropertyChange>b__35(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x0718e918
	System.Void <SubscribePropertyChange>b__36(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x0718e9c4
	System.Void <SubscribePropertyChange>b__37(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue); // 0x0718ea70
	System.Void <SubscribePropertyChange>b__38(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue); // 0x0718eb1c
	System.Void <SubscribePropertyChange>b__39(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue); // 0x0718ebc8
	System.Void <SubscribePropertyChange>b__40(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue); // 0x0718ec74
	System.Void <SubscribePropertyChange>b__41(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue); // 0x0718ed20
	System.Void <SubscribePropertyChange>b__42(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x0718edcc
	System.Void <SubscribePropertyChange>b__43(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x0718ee78
	System.Void <SubscribePropertyChange>b__44(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x0718ef24
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.VehicleModuleCustom.<GetSeatedIds>d__360 : System.Object, System.Collections.Generic.IEnumerable<System.Int64>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Int64>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Int64 <>2__current; // 0x18
	System.Int32 <>l__initialThreadId; // 0x20
	WizardGames.Soc.Common.CustomType.VehicleModuleCustom <>4__this; // 0x28
	System.Void .ctor(System.Int32 <>1__state); // 0x0718b3c4
	System.Void System.IDisposable.Dispose(); // 0x0718efd0
	System.Boolean MoveNext(); // 0x0718f030
	System.Int64 System.Collections.Generic.IEnumerator<System.Int64>.get_Current(); // 0x0718f304
	System.Void System.Collections.IEnumerator.Reset(); // 0x0718f368
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0718f3f0
	System.Collections.Generic.IEnumerator<System.Int64> System.Collections.Generic.IEnumerable<System.Int64>.GetEnumerator(); // 0x0718f484
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x0718f554
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.VehicleRootNode : WizardGames.Soc.Common.CustomType.ItemSystemRootNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1164401620;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0718f5b8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0718f620
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0718f6d0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0718f780
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x0718f830
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0718f990
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0718fecc
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x071902d8
	static System.Object DeserializeVehicleRootNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0719066c
	static System.Void .cctor(); // 0x07190790
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.WardrobeRootNode : WizardGames.Soc.Common.CustomType.ItemSystemRootNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 380218189;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x071909f4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07190a5c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07190b0c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07190bbc
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x07190c6c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07190dcc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07191308
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x07191714
	static System.Object DeserializeWardrobeRootNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07191aa8
	static System.Void .cctor(); // 0x07191bcc
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.WarZoneTeamRecruitment : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 515015131;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07191e30
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07191e98
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07191f24
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0719201c
	System.Int64 get_TeamId(); // 0x071920a8
	System.Void set_TeamId(System.Int64 value); // 0x0719211c
	System.String get_Statement(); // 0x071921a8
	System.Void set_Statement(System.String value); // 0x0719221c
	System.String get_TeamName(); // 0x071922a8
	System.Void set_TeamName(System.String value); // 0x0719231c
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> get_TeamPreferences(); // 0x071923a8
	System.Void set_TeamPreferences(WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> value); // 0x07192448
	System.Boolean get_Microphone(); // 0x071924d4
	System.Void set_Microphone(System.Boolean value); // 0x07192548
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.UInt64,WizardGames.Soc.Common.CustomType.RecruitmentTeammateInfo> get_TeamMembers(); // 0x071925d4
	System.Void set_TeamMembers(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.UInt64,WizardGames.Soc.Common.CustomType.RecruitmentTeammateInfo> value); // 0x07192674
	System.Int64 get_DisableTs(); // 0x07192700
	System.Void set_DisableTs(System.Int64 value); // 0x07192774
	System.Int32 get_OnlinePeriodWeek(); // 0x07192800
	System.Void set_OnlinePeriodWeek(System.Int32 value); // 0x07192874
	System.Int32 get_OnlinePeriodDay(); // 0x07192900
	System.Void set_OnlinePeriodDay(System.Int32 value); // 0x07192974
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x07192a00
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07192b60
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x071930d8
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x07193530
	static System.Object DeserializeWarZoneTeamRecruitmentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071938a4
	static System.Void .cctor(); // 0x071939c8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.WaterBottleItemNode : WizardGames.Soc.Common.CustomType.DirectoryItemNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1438112792;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07193cc8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07193d30
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07193de0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07193e90
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07193f40
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0719449c
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x0719493c
	static System.Object DeserializeWaterBottleItemNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07194b94
	System.Boolean get_IsFull(); // 0x07194c68
	System.Int32 get_ContentCount(); // 0x07194d4c
	static System.Void .cctor(); // 0x07194e1c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom : WizardGames.Soc.Common.CustomType.CustomBaseItem, WizardGames.Soc.Common.Entity.IItemEntity, WizardGames.Soc.Common.Entity.IEmbeddedCustom, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Share.Framework.IPredictType
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 956519199;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom.LocalStatusEnum _localStatus; // 0x38
	System.Action<WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom.LocalStatusEnum,WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom.LocalStatusEnum> OnLocalStatusChange; // 0x40
	System.Int32 LastPosition; // 0x48
	System.Int32 GetClassHash(); // 0x071951ec
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07195254
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07195304
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071953b4
	System.Int64 get_OwnerWeaponEntityId(); // 0x07195464
	System.Void set_OwnerWeaponEntityId(System.Int64 value); // 0x071954d8
	System.Int64 get_OwnerWeaponTableId(); // 0x07195564
	System.Void set_OwnerWeaponTableId(System.Int64 value); // 0x071955d8
	System.Int64 get_Slot(); // 0x07195664
	System.Void set_Slot(System.Int64 value); // 0x071956d8
	System.Int32 get_Status(); // 0x07195764
	System.Void set_Status(System.Int32 value); // 0x071957d8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07195864
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07195cdc
	WizardGames.Soc.Share.Framework.IPredictType GetNewInstance(System.Int64 id); // 0x07196104
	System.Void .ctor(System.Int64 id); // 0x071961a4
	WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom.LocalStatusEnum get_LocalStatus(); // 0x07196274
	System.Void set_LocalStatus(WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom.LocalStatusEnum value); // 0x071962d8
	static System.Void .cctor(); // 0x0719637c
}

// Client.Runtime
enum WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom.LocalStatusEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom.LocalStatusEnum Invalid = 0;
	static WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom.LocalStatusEnum OFF = 1;
	static WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom.LocalStatusEnum ON = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.WeaponAccessoryItemNode : WizardGames.Soc.Common.CustomType.UniqueItemNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1309736305;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x071967b4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0719681c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071968c8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07196974
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07196a20
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07196e38
	static System.Void .cctor(); // 0x0719726c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.WeaponCustom : WizardGames.Soc.Common.CustomType.CustomBaseItem, WizardGames.Soc.Common.Entity.IHeldItemEntity, WizardGames.Soc.Common.Entity.IItemEntity, WizardGames.Soc.Common.Entity.IEmbeddedCustom, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Common.Entity.IHaveBulletEntity, WizardGames.Soc.Common.Combat.Shoot.IShootState, WizardGames.Soc.Common.Entity.Ability.IWeaponState, WizardGames.Soc.Common.Entity.IHaveEmbedded, WizardGames.Soc.Share.Framework.IPredictType
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 223627915;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Boolean IsWarmupWeapon_Local; // 0x38
	System.Boolean fake; // 0x39
	System.Boolean <IsNewWeaponFp>k__BackingField; // 0x3a
	System.Int32 <recoilShootCountTime>k__BackingField; // 0x3c
	System.Int32 <shotsFired>k__BackingField; // 0x40
	System.Single <viewKickPeakScale>k__BackingField; // 0x44
	WizardGames.Soc.Common.Combat.Shoot.SOCViewkickFormula <formula>k__BackingField; // 0x48
	System.Single <ViewKickPitch>k__BackingField; // 0x50
	System.Single <ViewKickYaw>k__BackingField; // 0x54
	UnityEngine.Vector2 <LastPunchOffset>k__BackingField; // 0x58
	UnityEngine.Vector2 <LastViewOffset>k__BackingField; // 0x60
	System.Int32 <LastShotsFired>k__BackingField; // 0x68
	UnityEngine.Vector2 <LastShootDir>k__BackingField; // 0x6c
	System.Int32 <IgnoreViewKickCount>k__BackingField; // 0x74
	System.Single <spread>k__BackingField; // 0x78
	System.Single <moveSpread>k__BackingField; // 0x7c
	System.Single <shootSpread>k__BackingField; // 0x80
	System.Single <ammoSpreadScale>k__BackingField; // 0x84
	System.Single <accuracy>k__BackingField; // 0x88
	System.Single <direction>k__BackingField; // 0x8c
	System.Int64 <UsingAmmoNodeId>k__BackingField; // 0x90
	System.Boolean <IsEmptyReload>k__BackingField; // 0x98
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> LaunchShootAttackRange; // 0xa0
	System.Single ShootAttackDamage; // 0xa8
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> WarningShootBulletHitRate; // 0xb0
	System.Int32 ResumeDeRateBulletCount; // 0xb8
	System.Boolean DeRateBulletTag; // 0xbc
	System.Int64 StartDeRateBulletTime; // 0xc0
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> WarningShootCd; // 0xc8
	WizardGames.Soc.Common.Algorithm.ConstList<System.Int32> WarningShootBulletNum; // 0xd0
	System.Int32 AimType; // 0xd8
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> AtkAimTime; // 0xe0
	System.Single AtkPrepareTime; // 0xe8
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> AtkSustainTime; // 0xf0
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> AtkTimeInterval; // 0xf8
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> HitRate; // 0x100
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> HitRange; // 0x108
	System.Single MinHitRate; // 0x110
	System.Int32 TargetHpCorrection; // 0x114
	System.Single AtkStartTime; // 0x118
	System.Single AtkEndTime; // 0x11c
	System.Single AtkShootInterval; // 0x120
	System.Single MissAngleLimit; // 0x124
	System.Single BulletReloadTime; // 0x128
	System.Single StartReloadTime; // 0x12c
	System.Single BulletSpeed; // 0x130
	System.Single LastShootTime; // 0x134
	System.Boolean UseGroundRandomShoot; // 0x138
	System.Int32 GroundRandomShootPointCount; // 0x13c
	System.Single <FireCountEndTime>k__BackingField; // 0x140
	System.Boolean <CanFireReload>k__BackingField; // 0x144
	System.Single <ChargeSpeedScale>k__BackingField; // 0x148
	System.Single <ChargeDamageScale>k__BackingField; // 0x14c
	System.Boolean <IsInAds>k__BackingField; // 0x150
	System.Boolean <IsInMovingVehicle>k__BackingField; // 0x151
	System.Single <initialPitch>k__BackingField; // 0x154
	System.Single <AdsSpreadScale>k__BackingField; // 0x158
	System.Boolean IsClient; // 0x15c
	System.Single <KickCorrection>k__BackingField; // 0x160
	System.Single <BulletSpeedCorrection>k__BackingField; // 0x164
	System.Single <DamageCorrection>k__BackingField; // 0x168
	System.Int32 <FireRateCorrection>k__BackingField; // 0x16c
	System.Single <SpreadCorrection>k__BackingField; // 0x170
	System.Int32 <AdsUpTime>k__BackingField; // 0x174
	System.Int32 <AdsDownTime>k__BackingField; // 0x178
	System.Boolean isCreateLocal; // 0x17c
	WizardGames.Soc.Common.CustomType.WeaponCustom.EWarmupState warmupState; // 0x180
	System.Boolean WarmupToggle; // 0x184
	System.Single Speed; // 0x188
	System.Boolean WarmupPressed; // 0x18c
	System.Int32 <SubClipConsume>k__BackingField; // 0x190
	System.Int32 GetClassHash(); // 0x071975d4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0719763c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071979e4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07197eb0
	System.Int64 get_NextFireTime(); // 0x07198258
	System.Void set_NextFireTime(System.Int64 value); // 0x071982cc
	System.Int32 get_FireInterval(); // 0x07198358
	System.Void set_FireInterval(System.Int32 value); // 0x071983cc
	System.Int32 get_UsingAmmoId(); // 0x07198458
	System.Void set_UsingAmmoId(System.Int32 value); // 0x071984cc
	System.Int32 get_LastAmmoId(); // 0x07198558
	System.Void set_LastAmmoId(System.Int32 value); // 0x071985cc
	System.Int32 get_Clips(); // 0x07198658
	System.Void set_Clips(System.Int32 value); // 0x071986cc
	System.Int32 get_ClipCapacity(); // 0x07198758
	System.Void set_ClipCapacity(System.Int32 value); // 0x071987cc
	System.Int32 get_ContinueReloadingAmmoID(); // 0x07198858
	System.Void set_ContinueReloadingAmmoID(System.Int32 value); // 0x071988cc
	System.Int32 get_StepReloadingAmmoAmount(); // 0x07198958
	System.Void set_StepReloadingAmmoAmount(System.Int32 value); // 0x071989cc
	System.Boolean get_IsReloading(); // 0x07198a58
	System.Void set_IsReloading(System.Boolean value); // 0x07198acc
	System.Single get_DamageScale(); // 0x07198b58
	System.Void set_DamageScale(System.Single value); // 0x07198bcc
	WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom get_Accessory0(); // 0x07198c58
	System.Void set_Accessory0(WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom value); // 0x07198d1c
	WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom get_Accessory1(); // 0x07198da8
	System.Void set_Accessory1(WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom value); // 0x07198e6c
	WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom get_Accessory2(); // 0x07198ef8
	System.Void set_Accessory2(WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom value); // 0x07198fbc
	WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom get_Accessory3(); // 0x07199048
	System.Void set_Accessory3(WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom value); // 0x0719910c
	System.Int32 get_MonsterWeaponAttackState(); // 0x07199198
	System.Void set_MonsterWeaponAttackState(System.Int32 value); // 0x0719920c
	System.Int64 get_NextClipConsumeTime(); // 0x07199298
	System.Void set_NextClipConsumeTime(System.Int64 value); // 0x0719930c
	System.Int32 get_BurstFireCount(); // 0x07199398
	System.Void set_BurstFireCount(System.Int32 value); // 0x0719940c
	System.Int32 get_NextBurstFireTime(); // 0x07199498
	System.Void set_NextBurstFireTime(System.Int32 value); // 0x0719950c
	System.Single get_WarmupProgress(); // 0x07199598
	System.Void set_WarmupProgress(System.Single value); // 0x0719960c
	System.Int32 get_WarmupAnimState(); // 0x07199698
	System.Void set_WarmupAnimState(System.Int32 value); // 0x0719970c
	System.Boolean get_IsWarmupWeapon(); // 0x07199798
	System.Void set_IsWarmupWeapon(System.Boolean value); // 0x0719980c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07199898
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0719a054
	System.Void InvokeChildOnCustomCreate(); // 0x0719a5c0
	System.Void InvokeChildOnCustomRemove(); // 0x0719a8d4
	WizardGames.Soc.Share.Framework.IPredictType GetNewInstance(System.Int64 id); // 0x0719ac18
	System.Void .ctor(System.Int64 id); // 0x0719acb8
	System.Int32 get_shotsFired(); // 0x0719b29c
	System.Void set_shotsFired(System.Int32 value); // 0x0719b300
	System.Single get_viewKickPeakScale(); // 0x0719b378
	System.Void set_viewKickPeakScale(System.Single value); // 0x0719b3dc
	WizardGames.Soc.Common.Combat.Shoot.SOCViewkickFormula get_formula(); // 0x0719b454
	System.Void set_formula(WizardGames.Soc.Common.Combat.Shoot.SOCViewkickFormula value); // 0x0719b4b8
	System.Single get_ViewKickPitch(); // 0x0719b538
	System.Void set_ViewKickPitch(System.Single value); // 0x0719b59c
	System.Single get_ViewKickYaw(); // 0x0719b614
	System.Void set_ViewKickYaw(System.Single value); // 0x0719b678
	UnityEngine.Vector2 get_LastPunchOffset(); // 0x0719b6f0
	System.Void set_LastPunchOffset(UnityEngine.Vector2 value); // 0x0719b750
	UnityEngine.Vector2 get_LastViewOffset(); // 0x0719b7d0
	System.Void set_LastViewOffset(UnityEngine.Vector2 value); // 0x0719b830
	System.Int32 get_LastShotsFired(); // 0x0719b8b0
	System.Void set_LastShotsFired(System.Int32 value); // 0x0719b914
	System.Single get_spread(); // 0x0719b98c
	System.Void set_spread(System.Single value); // 0x0719b9f0
	System.Single get_moveSpread(); // 0x0719ba68
	System.Void set_moveSpread(System.Single value); // 0x0719bacc
	System.Single get_shootSpread(); // 0x0719bb44
	System.Void set_shootSpread(System.Single value); // 0x0719bba8
	System.Single get_ammoSpreadScale(); // 0x0719bc20
	System.Void set_ammoSpreadScale(System.Single value); // 0x0719bc84
	System.Void set_UsingAmmoNodeId(System.Int64 value); // 0x0719bcfc
	System.Void set_IsEmptyReload(System.Boolean value); // 0x0719bd74
	System.Boolean get_StepReload(); // 0x0719bdf0
	System.Int32 get_SingleReloadClipNum(); // 0x0719be6c
	System.Boolean get_HasReloadStart(); // 0x0719bf90
	System.Boolean get_HasReloadEnd(); // 0x0719c0a4
	System.Int32 get_ReloadTime(); // 0x0719c1b8
	System.Int32 get_TotalReloadTime(); // 0x0719c2c4
	System.Int32[] get_AvailableAmmos(); // 0x0719c428
	System.Int32 get_BoltTime(); // 0x0719c534
	System.Single get_FireCountEndTime(); // 0x0719c640
	System.Void set_FireCountEndTime(System.Single value); // 0x0719c6a4
	System.Boolean get_CanFireReload(); // 0x0719c71c
	System.Single get_ChargeSpeedScale(); // 0x0719c780
	System.Void set_ChargeSpeedScale(System.Single value); // 0x0719c7e4
	System.Single get_ChargeDamageScale(); // 0x0719c85c
	System.Void set_ChargeDamageScale(System.Single value); // 0x0719c8c0
	System.Boolean get_IsInAds(); // 0x0719c938
	System.Void set_IsInAds(System.Boolean value); // 0x0719c99c
	System.Single get_initialPitch(); // 0x0719ca18
	System.Void set_initialPitch(System.Single value); // 0x0719ca7c
	System.Single get_AdsSpreadScale(); // 0x0719caf4
	System.Void set_AdsSpreadScale(System.Single value); // 0x0719cb58
	System.Boolean get_EmptyClip(); // 0x0719cbd0
	System.Boolean get_InsufficientClip(); // 0x0719cc40
	System.Single get_KickCorrection(); // 0x0719ccbc
	System.Void set_KickCorrection(System.Single value); // 0x0719cd20
	System.Single get_BulletSpeedCorrection(); // 0x0719cd98
	System.Void set_BulletSpeedCorrection(System.Single value); // 0x0719cdfc
	System.Single get_DamageCorrection(); // 0x0719ce74
	System.Void set_DamageCorrection(System.Single value); // 0x0719ced8
	System.Int32 get_FireRateCorrection(); // 0x0719cf50
	System.Void set_FireRateCorrection(System.Int32 value); // 0x0719cfb4
	System.Single get_SpreadCorrection(); // 0x0719d02c
	System.Void set_SpreadCorrection(System.Single value); // 0x0719d090
	System.Int32 get_AdsUpTime(); // 0x0719d108
	System.Void set_AdsUpTime(System.Int32 value); // 0x0719d16c
	System.Int32 get_AdsDownTime(); // 0x0719d1e4
	System.Void set_AdsDownTime(System.Int32 value); // 0x0719d248
	System.Int32 ExpectReloadTime(System.Int32 ammoCnt, System.Boolean followPerform); // 0x0719d2c0
	System.Boolean get_IsAttachedToMgr(); // 0x0719d490
	System.Void SetIsCreateLocal(System.Boolean isCreateLocal); // 0x0719d4fc
	System.Boolean get_IsLockableWeapon(); // 0x0719d578
	System.Single get_UpSpeed(); // 0x0719d684
	System.Single get_DownSpeed(); // 0x0719d7a4
	System.Single get_Threshold(); // 0x0719d8c4
	System.Boolean get_ReloadNearJackhammer(); // 0x0719d9d8
	System.Void UpdateWarmupProgress(System.Single dt); // 0x0719dae4
	System.Void TryStartWarmup(); // 0x0719dc64
	System.Void StopWarmup(); // 0x0719dd20
	System.Void ResetWarmup(); // 0x0719dd98
	System.Boolean WarmupComplete(); // 0x0719de34
	System.Void OnDeploy(); // 0x0719deac
	System.Void OnHolster(); // 0x0719df40
	static System.Void .cctor(); // 0x0719e2e4
}

// Client.Runtime
enum WizardGames.Soc.Common.CustomType.WeaponCustom.EWarmupState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.CustomType.WeaponCustom.EWarmupState None = 0;
	static WizardGames.Soc.Common.CustomType.WeaponCustom.EWarmupState Up = 1;
	static WizardGames.Soc.Common.CustomType.WeaponCustom.EWarmupState Down = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.WeaponDisplayData : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1458284881;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0719ea84
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0719eaec
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0719eb78
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0719ec4c
	System.Int32 get_HoldItemIndex(); // 0x0719ecd8
	System.Void set_HoldItemIndex(System.Int32 value); // 0x0719ed4c
	System.Int64 get_TableId(); // 0x0719edd8
	System.Void set_TableId(System.Int64 value); // 0x0719ee4c
	System.Int64 get_SkinId(); // 0x0719eed8
	System.Void set_SkinId(System.Int64 value); // 0x0719ef4c
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.AccessoryDisplayData> get_AccessoryDisplayDatas(); // 0x0719efd8
	System.Void set_AccessoryDisplayDatas(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.AccessoryDisplayData> value); // 0x0719f078
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x0719f104
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0719f264
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0719f658
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x0719fa00
	static System.Object DeserializeWeaponDisplayDataContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0719fc48
	System.Void .ctor(System.Int64 tableId, System.Int64 skinId); // 0x0719fd18
	System.Void .ctor(WizardGames.Soc.Common.CustomType.WeaponDisplayData other); // 0x0719fdfc
	static System.Void .cctor(); // 0x071a0088
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.WeaponItemNode : WizardGames.Soc.Common.CustomType.DirectoryItemNode, WizardGames.Soc.Share.Game.NodeSystem.IHaveBulletItemNode, WizardGames.Soc.Share.Game.NodeSystem.INode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1568308495;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x071a0284
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071a02ec
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071a039c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071a044c
	System.Int32 get_BulletBizId(); // 0x071a04fc
	System.Void set_BulletBizId(System.Int32 value); // 0x071a0570
	System.Int32 get_BulletAmount(); // 0x071a05fc
	System.Void set_BulletAmount(System.Int32 value); // 0x071a0670
	System.Int32 get_SubClipConsume(); // 0x071a06fc
	System.Void set_SubClipConsume(System.Int32 value); // 0x071a0770
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071a07fc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x071a0d60
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x071a11d8
	static System.Object DeserializeWeaponItemNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071a1430
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.ItemSlot> get_AvailableSlots(); // 0x071a1504
	System.Int32[] get_AvailableAmmos(); // 0x071a1654
	static System.Void .cctor(); // 0x071a17a4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.WearItemCustom : WizardGames.Soc.Common.CustomType.CustomBaseItem, WizardGames.Soc.Common.Entity.IWearItemEntity, WizardGames.Soc.Common.Entity.IItemEntity, WizardGames.Soc.Common.Entity.IEmbeddedCustom, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Common.Entity.IRechargeableEntity, WizardGames.Soc.Common.Entity.IConditionConsumeEntity, WizardGames.Soc.Share.Framework.IPredictType
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 35;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.List<System.Int64> subscribeIds; // 0x38
	System.Int32 <PrepareTime>k__BackingField; // 0x40
	System.Int32 <ProtectAreaValue>k__BackingField; // 0x44
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> <Protection>k__BackingField; // 0x48
	System.Int32 GetClassHash(); // 0x071a1c10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071a1c74
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071a1d8c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071a1ea4
	System.Single get_ConditionConsumeMS(); // 0x071a1fbc
	System.Void set_ConditionConsumeMS(System.Single value); // 0x071a2030
	System.Int32 get_BelongPosition(); // 0x071a20bc
	System.Void set_BelongPosition(System.Int32 value); // 0x071a2130
	System.Int32 get_EquipOwner(); // 0x071a21bc
	System.Void set_EquipOwner(System.Int32 value); // 0x071a2230
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071a22bc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x071a2710
	WizardGames.Soc.Share.Framework.IPredictType GetNewInstance(System.Int64 id); // 0x071a2b40
	System.Void SubscribePropertyChange(WizardGames.Soc.Common.CustomType.WearItemCustom target); // 0x071a2d00
	System.Void UnSubscribePropertyChange(); // 0x071a348c
	System.Void OnOwnerEntityIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.CustomType.WearItemCustom target); // 0x071a35f0
	System.Void OnItemUidChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.CustomType.WearItemCustom target); // 0x071a369c
	System.Void OnAmountChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.CustomType.WearItemCustom target); // 0x071a3748
	System.Void OnConditionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.CustomType.WearItemCustom target); // 0x071a37f4
	System.Void OnMaxConditionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.CustomType.WearItemCustom target); // 0x071a38a0
	System.Void OnPositionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.CustomType.WearItemCustom target); // 0x071a394c
	System.Void OnSkinIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.CustomType.WearItemCustom target); // 0x071a39f8
	System.Void OnBelongPositionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.CustomType.WearItemCustom target); // 0x071a3aa4
	System.Void OnEquipOwnerChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.CustomType.WearItemCustom target); // 0x071a3b4c
	System.Void .ctor(System.Int64 id); // 0x071a2be0
	System.Boolean get_hasCondition(); // 0x071a3bf4
	System.Boolean get_isBroken(); // 0x071a3d08
	System.Int32 get_PrepareTime(); // 0x071a3d90
	System.Void set_PrepareTime(System.Int32 value); // 0x071a3df4
	System.Boolean get_CanRecharge(); // 0x071a3e6c
	System.Int32 get_ProtectAreaValue(); // 0x071a40d0
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> get_Protection(); // 0x071a4134
	System.Boolean get_IsUsing(); // 0x071a3ff8
	static System.Void .cctor(); // 0x071a4198
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.WearItemCustom.<>c__DisplayClass22_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.WearItemCustom <>4__this; // 0x10
	WizardGames.Soc.Common.CustomType.WearItemCustom target; // 0x18
	System.Void .ctor(); // 0x071a3424
	System.Void <SubscribePropertyChange>b__0(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x071a4598
	System.Void <SubscribePropertyChange>b__1(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x071a4644
	System.Void <SubscribePropertyChange>b__2(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x071a46f0
	System.Void <SubscribePropertyChange>b__3(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x071a479c
	System.Void <SubscribePropertyChange>b__4(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x071a4848
	System.Void <SubscribePropertyChange>b__5(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x071a48f4
	System.Void <SubscribePropertyChange>b__6(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x071a49a0
	System.Void <SubscribePropertyChange>b__7(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x071a4a4c
	System.Void <SubscribePropertyChange>b__8(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x071a4af8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.WireSlotInfoWithLine : WizardGames.Soc.Common.CustomType.WireSlotInfo
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1761745241;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x071a4ba4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071a4c0c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071a4d44
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071a4ec4
	System.Int32 get_LineColor(); // 0x071a4ffc
	System.Void set_LineColor(System.Int32 value); // 0x071a5070
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.CustomVector3> get_LinePoses(); // 0x071a50fc
	System.Void set_LinePoses(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.CustomVector3> value); // 0x071a519c
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x071a5228
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071a5388
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x071a5944
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x071a5e5c
	static System.Object DeserializeWireSlotInfoWithLineContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071a60a4
	static System.Void .cctor(); // 0x071a6174
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.WireSlotInfo : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 2133960027;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x071a63a4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071a4cb8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071a4e38
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071a4f70
	System.Int64 get_ConnectedID(); // 0x071a5d00
	System.Void set_ConnectedID(System.Int64 value); // 0x071a57a0
	System.Int32 get_ConnectedToSlot(); // 0x071a5d74
	System.Void set_ConnectedToSlot(System.Int32 value); // 0x071a582c
	System.Int32 get_LinePower(); // 0x071a5de8
	System.Void set_LinePower(System.Int32 value); // 0x071a58b8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071a640c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x071a66f4
	static System.Void .cctor(); // 0x071a6a44
}

// Client.Runtime
interface WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap : , WizardGames.Soc.Share.Game.NodeSystem.IItemContainerNode, WizardGames.Soc.Share.Game.NodeSystem.IDirectoryNode, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Common.CustomType.NodeBase>>, System.Collections.IEnumerable, WizardGames.Soc.Share.Game.NodeSystem.INode
{
	
	WizardGames.Soc.Common.CustomType.Alpha3ContainerClient get_Impl(); // 0x054b6094
	WizardGames.Soc.Common.CustomType.BaseItemNode GetSlot(System.Int32 slot); // 0x071a6c0c
}

// Client.Runtime
struct WizardGames.Soc.Common.CustomType.Alpha3ContainerClient : System.ValueType
{
	WizardGames.Soc.Share.Game.NodeSystem.IItemContainerNode Node; // 0x10
	System.Int64 get_NodeId(); // 0x071a6d44
	System.Int64 get_EntityId(); // 0x071a6e20
	WizardGames.Soc.Common.Data.DataItem.Container get_Config(); // 0x071a6f48
	System.Int64 get_ConfigId(); // 0x071a7020
	System.Int32 get_Capacity(); // 0x071a7090
	WizardGames.Soc.Common.Data.DataItem.ItemContainerFlag get_Flags(); // 0x071a7158
	System.Collections.Generic.IDictionary<System.Int64,System.Int64> get_Childs(); // 0x071a7224
	System.Boolean get_HasChild(); // 0x071a72f0
	System.Int64 get_SystemIndex(); // 0x071a73e4
	System.Int64 get_ContainerIndex(); // 0x071a7678
	System.Int32 get_MaxStackSize(); // 0x071a7884
	WizardGames.Soc.Common.Data.DataItem.ItemFlags[] get_AllowedContents(); // 0x071a7904
	System.Int64[] get_OnlyAllowedItemIds(); // 0x071a7974
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.ItemSlot> get_AvailableSlots(); // 0x071a79e4
	System.Boolean get_IsFull(); // 0x071a7a9c
	System.Boolean get_IsEmpty(); // 0x071a7b90
	System.Void .ctor(WizardGames.Soc.Share.Game.NodeSystem.IItemContainerNode node); // 0x071a7c8c
	WizardGames.Soc.Common.CustomType.BaseItemNode GetFirstAvaliableItem(); // 0x071a7d0c
	System.Int32 GetAmount(System.Int64 cfgId); // 0x071a8064
	System.Void GetAllAmount(System.Collections.Generic.Dictionary<System.Int64,System.Int32> result); // 0x071a83ec
	WizardGames.Soc.Common.CustomType.BaseItemNode FindItemByNodeId(System.Int64 nodeId); // 0x071a8858
	WizardGames.Soc.Common.CustomType.BaseItemNode FindItemByCfgId(System.Int32 cfgId); // 0x071a8a0c
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> FindItemsByCfgId(System.Int64 cfgId, System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> result); // 0x071a8e5c
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> FindItemsByCfgId1(System.Int64 cfgId, System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> result); // 0x071a940c
	WizardGames.Soc.SocClient.Collection.Common.CanAcceptResult CanAcceptItem(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x071a9924
	WizardGames.Soc.SocClient.Collection.Common.CanAcceptResult CanBeltAcceptItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, System.Int32 targetPos); // 0x071aa408
	WizardGames.Soc.SocClient.Collection.Common.CanAcceptResult _canBeltAcceptItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, System.Int32 targetPos); // 0x071aa860
	System.Boolean IsBeltFull(WizardGames.Soc.Common.CustomType.BaseItemNode item, System.Int32 targetPos); // 0x071aab7c
	System.Boolean CanPartEquip(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x071a9fa8
	System.Boolean IsEntireAttainStackLimit(System.Int64 cfgId); // 0x071ab0f0
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.PgcGraphDataTypeHelper<T> : System.Object
{
	static System.Int32 <TypeId>k__BackingField; // 0x0
	static System.Int32 get_TypeId(); // 0x05485ecc
	static System.Void set_TypeId(System.Int32 value); // 0x054fd240
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.PgcGraphDataTypeHelper.ChangeCallback<T> : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05525a60
	System.Void Invoke(System.Collections.Generic.IList<System.Int64> path, T newValue); // 0x052af1f0
}

// Client.Runtime
interface WizardGames.Soc.Common.CustomType.IPgcGraphDataCallback : 
{
	
	System.Boolean IsPathMatch(System.Collections.Generic.IList<System.Int64> callbackPath); // 0x054dec74
	System.Boolean IsTypeMatch(System.Int32 type); // 0x054c4f88
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.PgcGraphDataCallback<T> : System.Object, WizardGames.Soc.Common.CustomType.IPgcGraphDataCallback
{
	System.Collections.Generic.IList<System.Int64> path; // 0x0
	WizardGames.Soc.Common.CustomType.PgcGraphDataTypeHelper.ChangeCallback<T> cb; // 0x0
	System.Void .ctor(System.Collections.Generic.IList<System.Int64> path, WizardGames.Soc.Common.CustomType.PgcGraphDataTypeHelper.ChangeCallback<T> cb); // 0x0552af00
	System.Boolean IsPathMatch(System.Collections.Generic.IList<System.Int64> callbackPath); // 0x054dec74
	System.Boolean IsTypeMatch(System.Int32 type); // 0x054c4f88
	System.Void Invoke(System.Collections.Generic.IList<System.Int64> path, T newValue); // 0x052af1f0
}

// Client.Runtime
struct WizardGames.Soc.Common.CustomType.DirEnumerator<T> : System.ValueType, System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,T>>, System.Collections.IEnumerator, System.IDisposable
{
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,System.Int64>> innerEnumerator; // 0x0
	System.Func<System.Int64,T> getNodeFunc; // 0x0
	System.Void .ctor(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,System.Int64>> innerEnumerator, System.Func<System.Int64,T> getNodeFunc); // 0x0552af00
	System.Collections.Generic.KeyValuePair<System.Int64,T> get_Current(); // 0x052af1f0
	System.Object System.Collections.IEnumerator.get_Current(); // 0x054e7844
	System.Void Dispose(); // 0x055049cc
	System.Boolean MoveNext(); // 0x054c4760
	System.Void Reset(); // 0x055049cc
}

// Client.Runtime
struct WizardGames.Soc.Common.CustomType.Alpha3ItemContainerEnumerator : System.ValueType, System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Common.CustomType.NodeBase>>, System.Collections.IEnumerator, System.IDisposable
{
	System.Collections.Generic.IDictionary<System.Int64,System.Int64> index2Id; // 0x10
	System.Func<System.Int64,WizardGames.Soc.Common.CustomType.NodeBase> getNodeFunc; // 0x18
	System.Int32 start; // 0x20
	System.Int32 length; // 0x24
	System.Int32 cur; // 0x28
	System.Void .ctor(System.Int32 start, System.Int32 length, System.Collections.Generic.IDictionary<System.Int64,System.Int64> index2Id, System.Func<System.Int64,WizardGames.Soc.Common.CustomType.NodeBase> getNodeFunc); // 0x071ab4b4
	System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Common.CustomType.NodeBase> get_Current(); // 0x071ab578
	System.Object System.Collections.IEnumerator.get_Current(); // 0x071ab748
	System.Void Dispose(); // 0x071ab948
	System.Boolean MoveNext(); // 0x071ab9cc
	System.Void Reset(); // 0x071aba40
}

// Client.Runtime
enum WizardGames.Soc.Common.CustomType.WarmAnimType : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.CustomType.WarmAnimType Empty = 0;
	static WizardGames.Soc.Common.CustomType.WarmAnimType Warmup = 1;
	static WizardGames.Soc.Common.CustomType.WarmAnimType WarmLoop = 2;
	static WizardGames.Soc.Common.CustomType.WarmAnimType WarmEnd = 3;
	
}

// Client.Runtime
interface WizardGames.Soc.Common.CustomType.IBuildingPartBriefEx : 
{
	
	System.Void RefreshData(); // 0x071abaa4
	System.Void Setup(); // 0x055049cc
	System.Void RefreshData(WizardGames.Soc.Common.CustomType.BuildingPartBriefWithExtraData infoExtra); // 0x05523a54
	System.Void CleanupData(WizardGames.Soc.Common.CustomType.BuildingPartBriefWithExtraData infoExtra); // 0x05523a54
}

// Client.Runtime
interface WizardGames.Soc.Common.CustomType.IBuildingPartBriefExSubMovableMesh : 
{
	
	System.Void RefreshRender(System.Boolean force); // 0x05523a7c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BuildingPartBriefExt : System.Object
{
	
	static WizardGames.Soc.Common.Component.OutsideDataSetComponent GetOutsideDataSetComp(WizardGames.Soc.Common.CustomType.IBuildingPartBriefEx self); // 0x071abc30
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CustomTypeLoader : System.Object
{
	static SocLogger logger; // 0x0
	static System.Threading.Tasks.Task LoadCustomData(); // 0x071abd38
	static System.Boolean DeserializeCustomData(); // 0x071abe30
	static System.Boolean Deserialize(System.IO.Stream stream); // 0x071ac3f8
	static System.Void .cctor(); // 0x071adf58
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CustomTypeLoader.<>c : System.Object
{
	static WizardGames.Soc.Common.CustomType.CustomTypeLoader.<>c <>9; // 0x0
	static System.Converter<System.Int16,System.Int32> <>9__8_0; // 0x8
	static System.Converter<System.Byte,System.Int32> <>9__8_1; // 0x10
	static System.Converter<System.Int16,System.Int32> <>9__8_2; // 0x18
	static System.Converter<System.Int16,System.Int32> <>9__8_3; // 0x20
	static System.Converter<System.Int16,System.Int32> <>9__8_4; // 0x28
	static System.Converter<System.Int16,System.Int32> <>9__8_5; // 0x30
	static System.Converter<System.Int16,System.Int32> <>9__8_6; // 0x38
	static System.Converter<System.Byte,WizardGames.Soc.Common.Framework.Const.ESyncRange> <>9__8_7; // 0x40
	static System.Converter<System.Byte,System.Int32> <>9__8_8; // 0x48
	static System.Converter<System.Int16,System.Int32> <>9__8_9; // 0x50
	static System.Converter<System.Int32,System.Int32> <>9__8_10; // 0x58
	static System.Converter<System.Byte,System.Int32> <>9__8_11; // 0x60
	static System.Void .cctor(); // 0x071ae02c
	System.Void .ctor(); // 0x071ae090
	System.Int32 <Deserialize>b__8_0(System.Int16 s); // 0x071ae0f8
	System.Int32 <Deserialize>b__8_1(System.Byte s); // 0x071ae170
	System.Int32 <Deserialize>b__8_2(System.Int16 s); // 0x071ae1e8
	System.Int32 <Deserialize>b__8_3(System.Int16 s); // 0x071ae260
	System.Int32 <Deserialize>b__8_4(System.Int16 s); // 0x071ae2d8
	System.Int32 <Deserialize>b__8_5(System.Int16 s); // 0x071ae350
	System.Int32 <Deserialize>b__8_6(System.Int16 s); // 0x071ae3c8
	WizardGames.Soc.Common.Framework.Const.ESyncRange <Deserialize>b__8_7(System.Byte s); // 0x071ae440
	System.Int32 <Deserialize>b__8_8(System.Byte s); // 0x071ae4b8
	System.Int32 <Deserialize>b__8_9(System.Int16 s); // 0x071ae530
	System.Int32 <Deserialize>b__8_10(System.Int32 s); // 0x071ae5a8
	System.Int32 <Deserialize>b__8_11(System.Byte s); // 0x071ae620
}

// Client.Runtime
struct WizardGames.Soc.Common.CustomType.CustomTypeLoader.<LoadCustomData>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x30
	System.Void MoveNext(); // 0x071ae698
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x071ae99c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricBluePrintSystemHotfix : System.Object
{
	
	static WizardGames.Soc.Common.SimpleCustom.ISnapshot<WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit> MakeICSnapshot(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x071aea40
	static System.Void ApplyICCmd(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ICmd cmd); // 0x071aeaf0
	static System.Boolean GenRevertICCmd(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ICmd cmd, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x071aebd8
	static System.Boolean OnlineVerify_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ICmd cmd); // 0x071aecbc
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricConnectSystemHotfix : System.Object
{
	
	static System.Boolean TryGetElectricC(System.Int64 id, WizardGames.Soc.Common.CustomType.ElectricCBase& comp); // 0x071aed9c
	static System.Boolean CanPlayeUseWires(); // 0x071aee54
	static System.Boolean RequestClear(System.Int64 entityId, System.Int32 index, System.Boolean isInput, System.Boolean tempVisiable); // 0x071aeeb0
	static System.Void GetWireOtherside(WizardGames.Soc.Common.CustomType.ElectricCBase comp, System.Int32 slot, System.Boolean isOutput, WizardGames.Soc.Common.CustomType.ElectricCBase& othersideComp, System.Int32& othersideSlot); // 0x071af440
	static System.Void RemoveWireConnection(System.Int64 entityId, System.Int32 slotIndex, System.Boolean isOutput); // 0x071af244
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricUpdateGroupHotfix : System.Object
{
	
	static System.Void BeforeCompRemove(WizardGames.Soc.Common.CustomType.ElectricUpdateGroup self, WizardGames.Soc.Common.CustomType.ElectricCBase comp); // 0x071af5c0
	static System.Void ClearGroup(WizardGames.Soc.Common.CustomType.ElectricUpdateGroup self); // 0x071af674
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricUpdateGroupContextHotfix : System.Object
{
	
	static System.Void Clear(WizardGames.Soc.Common.CustomType.ElectricUpdateGroupContext self); // 0x071af878
	static System.Boolean TryGetGroup(WizardGames.Soc.Common.CustomType.ElectricUpdateGroupContext self, System.Int64 groupId, WizardGames.Soc.Common.CustomType.ElectricUpdateGroup& group); // 0x071af900
	static System.Boolean TryGetGroup(WizardGames.Soc.Common.CustomType.ElectricUpdateGroupContext self, WizardGames.Soc.Common.CustomType.ElectricCBase comp, WizardGames.Soc.Common.CustomType.ElectricUpdateGroup& group); // 0x071af9ac
	static System.Void RemoveGroup(WizardGames.Soc.Common.CustomType.ElectricUpdateGroupContext self, System.Int64 groupId); // 0x071afa60
	static System.Void BeforeCompRemove(WizardGames.Soc.Common.CustomType.ElectricUpdateGroupContext self, WizardGames.Soc.Common.CustomType.ElectricCBase unit); // 0x071afcac
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricUpdateSystemHotfix : System.Object
{
	
	static System.Boolean TryGetElectricC(System.Int64 id, WizardGames.Soc.Common.CustomType.ElectricCBase& comp); // 0x071afd74
	static System.Void Init(WizardGames.Soc.Common.CustomType.ElectricUpdateSystem self); // 0x071afe2c
	static System.Void Clear(WizardGames.Soc.Common.CustomType.ElectricUpdateSystem self); // 0x071afee4
	static System.Void ApplyUpdateToGroups(WizardGames.Soc.Common.CustomType.ElectricUpdateSystem self, WizardGames.Soc.Common.CustomType.ElectricCBase comp); // 0x071b0024
	static System.Boolean JoinProcessDic(WizardGames.Soc.Common.CustomType.ElectricUpdateSystem self, WizardGames.Soc.Common.CustomType.ElectricCBase comp); // 0x071b0130
	static System.Boolean AddUpdateTimer(WizardGames.Soc.Common.CustomType.ElectricUpdateSystem self, WizardGames.Soc.Common.CustomType.ElectricCBase comp, System.Int32 delayTime); // 0x071b03d4
	static System.Void ElectricMarkDirty(WizardGames.Soc.Common.CustomType.ElectricUpdateSystem self, System.Int64 id); // 0x071b06cc
	static System.Void CancelElectricUnitTimer(WizardGames.Soc.Common.CustomType.ElectricUpdateSystem self, WizardGames.Soc.Common.CustomType.ElectricCBase unit); // 0x071b0298
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricUpdateSystemHotfix.<>c__DisplayClass7_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.ElectricUpdateSystem self; // 0x10
	WizardGames.Soc.Common.CustomType.ElectricCBase comp; // 0x18
	System.Void .ctor(); // 0x071b0664
	System.Void <AddUpdateTimer>b__0(System.Int64 _); // 0x071b0828
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCAndSwitchHotfix : System.Object
{
	
	static System.Void CleanupImpl(WizardGames.Soc.Common.CustomType.ElectricCAndSwitch self); // 0x071b08a0
	static System.Int32 DesiredPowerSlotImpl(WizardGames.Soc.Common.CustomType.ElectricCAndSwitch self, System.Int32 inputSlot); // 0x071b0910
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCAndSwitch self, System.Int32 outputSlot); // 0x071b09c0
	static System.Void UpdateHasPowerImpl(WizardGames.Soc.Common.CustomType.ElectricCAndSwitch self, System.Int32 inputAmount, System.Int32 inputSlot); // 0x071b0ab0
	static System.Void UpdateFromInputInnerImpl(WizardGames.Soc.Common.CustomType.ElectricCAndSwitch self, System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.CustomType.ElectricCBase outputUnit); // 0x071b0b48
	static System.Int32 GetNeedRecursiveImpl(WizardGames.Soc.Common.CustomType.ElectricCAndSwitch self, System.Int32 inputSlot, System.Collections.Generic.HashSet<System.Int64> listToUse); // 0x071b0ed0
	static System.Void UpdateLightStateImpl(WizardGames.Soc.Common.CustomType.ElectricCAndSwitch self); // 0x071b0fcc
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCAutoTurretHotfix : System.Object
{
	
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCAutoTurret self, System.Int32 outputSlot); // 0x071b123c
	static System.Int32 DesiredPowerImpl(WizardGames.Soc.Common.CustomType.ElectricCAutoTurret self, WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x071b133c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCBackupPowerICHotfix : System.Object
{
	
	static WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit GetTemplateImpl(WizardGames.Soc.Common.CustomType.ElectricCBackupPowerIC self); // 0x071b13e4
	static System.Void UpdateLightStateImpl(WizardGames.Soc.Common.CustomType.ElectricCBackupPowerIC self); // 0x071b1f18
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCBaseHotfix : System.Object
{
	
	static System.Void SetupEntityAgent(WizardGames.Soc.Common.CustomType.ElectricCBase self, WizardGames.Soc.Common.CustomType.IEntityWithElectric agent); // 0x071b20f0
	static System.Int32 GetPassthroughAmountForAnySlot(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Boolean input, System.Int32 index); // 0x071b1114
	static System.Void SendChangedToRoot(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Boolean forceUpdate); // 0x071af39c
	static System.Void UpdatePowerInput(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Int32 inputAmount, System.Int32 inputSlot); // 0x071b23e0
	static System.Boolean IsConnectedTo(WizardGames.Soc.Common.CustomType.ElectricCBase self, WizardGames.Soc.Common.CustomType.ElectricCBase unit, System.Int32 depth, System.Boolean defaultReturn); // 0x071b2568
	static WizardGames.Soc.Common.Algorithm.Vector3 GetIOSlotPosition(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Boolean isInput, System.Int32 slotIndex); // 0x071b2744
	static System.ValueTuple<WizardGames.Soc.Common.CustomType.ElectricCBase,WizardGames.Soc.Common.Algorithm.Vector3> FindGravitySource(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Int32 depth, System.Boolean ignoreSelf); // 0x071b2ba0
	static System.Boolean TryGetModuleSlot(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Boolean input, System.Int32 slotId, WizardGames.Soc.Common.Electric.IOSlotBase& slot); // 0x071af150
	static System.Void SetSlotPower(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.CustomType.ElectricCBase outputUnit); // 0x071b2fac
	static System.Boolean TryGetICOutWireInfo(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Boolean isInput, System.Int32 slotId, WizardGames.Soc.Common.CustomType.WireSlotInfo& ret); // 0x071b30d0
	static WizardGames.Soc.Common.CustomType.WireSlotInfo GetICOutWireInfo(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Boolean isInput, System.Int32 slotId); // 0x071b318c
	static System.Void PostInitLogic_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self); // 0x071b3600
	static System.Void ClearLogic_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self); // 0x071b36b8
	static System.Void UpdateFromInputInner_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.CustomType.ElectricCBase outputUnit); // 0x071b37d4
	static System.Boolean TryGetSlot_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Boolean input, System.Int32 slotId, WizardGames.Soc.Common.Electric.IOSlotBase& slot); // 0x071b39c4
	static System.Int32 ConsumptionAmount_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self, WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x071b3a64
	static System.Boolean IsRootEntity_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self); // 0x071b3b0c
	static System.Int32 GetCurrentEnergy_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self, WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x071b3b70
	static System.Int32 CalculateCurrentEnergy_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x071b3c7c
	static System.Int32 MaximalPowerOutput_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self); // 0x071b3d10
	static System.Int32 GetPassthroughAmount_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Int32 outputSlot); // 0x071b3d80
	static System.Void SendChangedToRootUpdate_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self); // 0x071b3e70
	static System.Void UpdateHasPower_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Int32 inputAmount, System.Int32 inputSlot); // 0x071b3ed0
	static System.Boolean WantsPower_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self); // 0x071b4084
	static System.ValueTuple<WizardGames.Soc.Common.CustomType.ElectricCBase,System.Int32,System.Int64> TransConnectedEntInfo_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Boolean isInput, System.Int32 slotId); // 0x071b40e8
	static System.Void OnCircuitChanged_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Boolean forceUpdate); // 0x071b41bc
	static System.Void UpdateUsedOutputs_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self); // 0x071b4254
	static System.Int32 DesiredPower_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self, WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x071b43e0
	static System.Int32 DesiredPowerSlot_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Int32 inputSlot); // 0x071b445c
	static System.Boolean WantsPassthroughPower_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self); // 0x071b457c
	static System.Boolean AllowDrainFrom_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Int32 outputSlot); // 0x071b45e8
	static System.Boolean IsConnectedTo_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self, WizardGames.Soc.Common.CustomType.ElectricCBase entity, System.Int32 slot, System.Int32 depth, System.Boolean defaultReturn); // 0x071b4660
	static System.Boolean ConsiderConnectedTo_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self, WizardGames.Soc.Common.CustomType.ElectricCBase entity); // 0x071b4878
	static System.Int32 UpdateDelayTime_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Int64 seqNow); // 0x071b48f0
	static WizardGames.Soc.Common.Electric.IValueSummary GetNeedSummary_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self); // 0x071b4968
	static System.Int32 GetNeedRecursive_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Int32 inputSlot, System.Collections.Generic.HashSet<System.Int64> listToUse); // 0x071b49f4
	static System.Boolean AllowLiquidPassthrough_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self, WizardGames.Soc.Common.CustomType.ElectricCBase fromSource, WizardGames.Soc.Common.Algorithm.Vector3 worldPos, System.Boolean forPlacement); // 0x071b4ed4
	static System.Void SetFuelType_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Int64 itemId, WizardGames.Soc.Common.CustomType.FluidicCContainer source); // 0x071b5050
	static System.Void IOStateChanged_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Int32 inputAmount, System.Int32 inputSlot); // 0x071b50cc
	static System.Void UpdateLightState_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self); // 0x071b5148
	static System.Boolean IsSetLightFlag_ECBase(WizardGames.Soc.Common.CustomType.ElectricCBase self, System.Boolean input, System.Int32 slotIndex, System.Int32 powerAmount); // 0x071b5320
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCBatteryHotfix : System.Object
{
	
	static System.Boolean IsRootEntityImpl(WizardGames.Soc.Common.CustomType.ElectricCBattery self); // 0x071b5470
	static System.Void CleanupImpl(WizardGames.Soc.Common.CustomType.ElectricCBattery self); // 0x071b54d4
	static System.Void PostInitLogicimpl(WizardGames.Soc.Common.CustomType.ElectricCBattery self); // 0x071b5548
	static System.Void ClearLogicImpl(WizardGames.Soc.Common.CustomType.ElectricCBattery self); // 0x071b56cc
	static System.Void OnCircuitChangedImpl(WizardGames.Soc.Common.CustomType.ElectricCBattery self, System.Boolean forceUpdate); // 0x071b5758
	static System.Void UpdateHasPowerImpl(WizardGames.Soc.Common.CustomType.ElectricCBattery self, System.Int32 inputAmount, System.Int32 inputSlot); // 0x071b5a14
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCBattery self, System.Int32 outputSlot); // 0x071b5b34
	static System.Boolean WantsPowerImpl(WizardGames.Soc.Common.CustomType.ElectricCBattery self); // 0x071b5c8c
	static System.Int32 DesiredPowerImpl(WizardGames.Soc.Common.CustomType.ElectricCBattery self, WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x071b5d48
	static WizardGames.Soc.Common.Electric.IValueSummary GetNeedSummaryImpl(WizardGames.Soc.Common.CustomType.ElectricCBattery self); // 0x071b5e8c
	static System.Void CheckDischarge(WizardGames.Soc.Common.CustomType.ElectricCBattery self); // 0x071b5f18
	static System.Void SetDischarging(WizardGames.Soc.Common.CustomType.ElectricCBattery self, System.Boolean wantsOn); // 0x071b60b4
	static System.Void SetPassthroughOn(WizardGames.Soc.Common.CustomType.ElectricCBattery self, System.Boolean wantsOn); // 0x071b6130
	static System.Single GetEnergyGained(WizardGames.Soc.Common.CustomType.ElectricCBattery self); // 0x071b61ec
	static System.Void AddCharge(WizardGames.Soc.Common.CustomType.ElectricCBattery self); // 0x071b62c8
	static System.Void ChargeChanged(WizardGames.Soc.Common.CustomType.ElectricCBattery self); // 0x071b64b0
	static System.Void TickUsage(WizardGames.Soc.Common.CustomType.ElectricCBattery self); // 0x071b66c8
	static System.Void Tick(WizardGames.Soc.Common.CustomType.ElectricCBattery self, System.Int64 _); // 0x071b698c
	static System.Void TickAction(WizardGames.Soc.Common.CustomType.ElectricCBattery self, System.Single deltaTime, System.Single& timer, System.Single tickRate, System.Action action); // 0x071b6b3c
	static System.Int32 GetDrain(WizardGames.Soc.Common.CustomType.ElectricCBattery self); // 0x071b57e0
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCBlockerHotfix : System.Object
{
	
	static System.Void PostInitLogicImpl(WizardGames.Soc.Common.CustomType.ElectricCBlocker self); // 0x071b6c10
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCBlocker self, System.Int32 outputSlot); // 0x071b6cb0
	static System.Boolean WantsPowerImpl(WizardGames.Soc.Common.CustomType.ElectricCBlocker self); // 0x071b6d5c
	static System.Void UpdateHasPowerImpl(WizardGames.Soc.Common.CustomType.ElectricCBlocker self, System.Int32 inputAmount, System.Int32 inputSlot); // 0x071b6dd8
	static System.Void IOStateChangedImpl(WizardGames.Soc.Common.CustomType.ElectricCBlocker self, System.Int32 inputAmount, System.Int32 inputSlot); // 0x071b6eec
	static System.Void UpdateBlocked(WizardGames.Soc.Common.CustomType.ElectricCBlocker self); // 0x071b6f84
	static System.Int32 UpdateDelayTimeImpl(WizardGames.Soc.Common.CustomType.ElectricCBlocker self, System.Int64 seqNow); // 0x071b7140
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCBranchHotfix : System.Object
{
	
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCBranch self, System.Int32 outputSlot); // 0x071b7308
	static WizardGames.Soc.Common.Electric.IValueSummary GetNeedSummaryImpl(WizardGames.Soc.Common.CustomType.ElectricCBranch self); // 0x071b748c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCBranchSmartHotfix : System.Object
{
	
	static System.Int32 MaximalPowerOutputImpl(WizardGames.Soc.Common.CustomType.ElectricCBranchSmart self); // 0x071b7538
	static System.Void PostInitCommonImpl(WizardGames.Soc.Common.CustomType.ElectricCBranchSmart self); // 0x071b759c
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCBranchSmart self, System.Int32 outputSlot); // 0x071b7610
	static System.Void SendChangedToRootUpdateImpl(WizardGames.Soc.Common.CustomType.ElectricCBranchSmart self); // 0x071b7794
	static System.Int32 GetNeedAmount(WizardGames.Soc.Common.CustomType.ElectricCBranchSmart self, System.Int32 slotIdx, System.Int32 oldValue); // 0x071b78dc
	static WizardGames.Soc.Common.Electric.IValueSummary GetNeedSummaryImpl(WizardGames.Soc.Common.CustomType.ElectricCBranchSmart self); // 0x071b7aa8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCButtonHotfix : System.Object
{
	
	static System.Void ClearLogicImpl(WizardGames.Soc.Common.CustomType.ElectricCButton self); // 0x071b7b54
	static System.Boolean WantsPowerImpl(WizardGames.Soc.Common.CustomType.ElectricCButton self); // 0x071b7c28
	static System.Int32 ConsumptionAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCButton self, WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x071b7c98
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCButton self, System.Int32 outputSlot); // 0x071b7d78
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCCombinerHotfix : System.Object
{
	
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCCombiner self, System.Int32 outputSlot); // 0x071b7ec4
	static System.Void UpdateFromInputInnerImpl(WizardGames.Soc.Common.CustomType.ElectricCCombiner self, System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.CustomType.ElectricCBase outputUnit); // 0x071b8158
	static System.Int32 GetTotalInputsAmount(WizardGames.Soc.Common.CustomType.ElectricCCombiner self); // 0x071b7fe8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCCounterHotfix : System.Object
{
	
	static System.Boolean WantsPowerImpl(WizardGames.Soc.Common.CustomType.ElectricCCounter self); // 0x071b8304
	static System.Void SetCounterNow(WizardGames.Soc.Common.CustomType.ElectricCCounter self, System.Int32 value); // 0x071b83a8
	static System.Void OnCounterChange(WizardGames.Soc.Common.CustomType.ElectricCCounter self); // 0x071b846c
	static System.Void UpdatePassPower(WizardGames.Soc.Common.CustomType.ElectricCCounter self); // 0x071b8520
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCCounter self, System.Int32 outputSlot); // 0x071b85ec
	static System.Void IOStateChangedImpl(WizardGames.Soc.Common.CustomType.ElectricCCounter self, System.Int32 inputAmount, System.Int32 inputSlot); // 0x071b86c0
	static System.Void ReceiveSignal(WizardGames.Soc.Common.CustomType.ElectricCCounter self, System.Int32 inputSlot); // 0x071b881c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCFuelGeneratorHotfix : System.Object
{
	
	static System.Void OnFlagChangedLogic(WizardGames.Soc.Common.CustomType.ElectricCFuelGenerator self, System.Int32 oldVal, System.Int32 newVal); // 0x071b89a8
	static System.Void PostInitLogicImpl(WizardGames.Soc.Common.CustomType.ElectricCFuelGenerator self); // 0x071b8a74
	static System.Void ClearLogicImpl(WizardGames.Soc.Common.CustomType.ElectricCFuelGenerator self); // 0x071b8c00
	static System.Int32 GetCurrentEnergyImpl(WizardGames.Soc.Common.CustomType.ElectricCFuelGenerator self, WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x071b8d8c
	static System.Boolean IsRootEntityImpl(WizardGames.Soc.Common.CustomType.ElectricCFuelGenerator self); // 0x071b8e3c
	static System.Void IOStateChangedImpl(WizardGames.Soc.Common.CustomType.ElectricCFuelGenerator self, System.Int32 inputAmount, System.Int32 inputSlot); // 0x071b8ea0
	static System.Void SwitchAction(WizardGames.Soc.Common.CustomType.ElectricCFuelGenerator self, System.Boolean isOn); // 0x071b8f88
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCIntegratedCircuitHotfix : System.Object
{
	
	static System.Int32 EncodeToPortId(System.Boolean input, System.Int32 slotId); // 0x071b9104
	static System.Void DecodeToBoInt(System.Int32 index, System.Boolean& isInput, System.Int32& slotId); // 0x071b9188
	static WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit GetTemplateImpl(WizardGames.Soc.Common.CustomType.ElectricCIntegratedCircuit self); // 0x071b921c
	static System.Void PostInitLogicImpl(WizardGames.Soc.Common.CustomType.ElectricCIntegratedCircuit self); // 0x071b9b50
	static System.Void ClearLogicImpl(WizardGames.Soc.Common.CustomType.ElectricCIntegratedCircuit self); // 0x071b9f40
	static WizardGames.Soc.Common.Electric.IOSlotBase GetInnerSlot(WizardGames.Soc.Common.CustomType.ElectricCIntegratedCircuit self, System.Int32 encodedSlotId); // 0x071ba304
	static System.ValueTuple<WizardGames.Soc.Common.CustomType.ElectricCBase,System.Int32,System.Int64> TransConnectedEntInfoImpl(WizardGames.Soc.Common.CustomType.ElectricCIntegratedCircuit self, System.Boolean isInput, System.Int32 slotId); // 0x071ba4ac
	static WizardGames.Soc.Common.Electric.IOSlotBase GetInnerSlotWithUnencoded(WizardGames.Soc.Common.CustomType.ElectricCIntegratedCircuit self, System.Boolean isInput, System.Int32 slotId); // 0x071ba690
	static System.Void ResetIntegratedCircuitInfo(WizardGames.Soc.Common.CustomType.ElectricCIntegratedCircuit self, WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit electricIntegratedCircuit); // 0x071ba720
	static WizardGames.Soc.Common.Electric.IOSlotBase TryGetSlotImpl(WizardGames.Soc.Common.CustomType.ElectricCIntegratedCircuit self, System.Boolean input, System.Int32 slotId); // 0x071baf3c
	static WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit GetIntegratedCircuit(WizardGames.Soc.Common.CustomType.ElectricCIntegratedCircuit self); // 0x071baff4
	static System.Int32 ConsumptionAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCIntegratedCircuit self, WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x071bb064
	static System.Boolean IsConnectedToImpl(WizardGames.Soc.Common.CustomType.ElectricCIntegratedCircuit self, WizardGames.Soc.Common.CustomType.ElectricCBase entity, System.Int32 slot, System.Int32 depth, System.Boolean defaultReturn); // 0x071bb438
	static System.Void UpdateUsedOutputsImpl(WizardGames.Soc.Common.CustomType.ElectricCIntegratedCircuit self); // 0x071bb574
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCLaserDetectorHotfix : System.Object
{
	
	static System.Void UpdateHasPowerImpl(WizardGames.Soc.Common.CustomType.ElectricCLaserDetector self, System.Int32 inputAmount, System.Int32 inputSlot); // 0x071bb5d4
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCLaserDetector self, System.Int32 outputSlot); // 0x071bb7d0
	static System.Boolean AllowDrainFromImpl(WizardGames.Soc.Common.CustomType.ElectricCLaserDetector self, System.Int32 outputSlot); // 0x071bb878
	static System.Void SetLaserState(WizardGames.Soc.Common.CustomType.ElectricCLaserDetector self, System.Boolean state); // 0x071bb6c4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCLiveSensorHotfix : System.Object
{
	
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCLiveSensor self, System.Int32 outputSlot); // 0x071bb8fc
	static System.Boolean AllowDrainFromImpl(WizardGames.Soc.Common.CustomType.ElectricCLiveSensor self, System.Int32 outputSlot); // 0x071bb9a4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCMemoryCellHotfix : System.Object
{
	
	static System.Void PostInitLogicImpl(WizardGames.Soc.Common.CustomType.ElectricCMemoryCell self); // 0x071bba28
	static System.Void ClearLogicImpl(WizardGames.Soc.Common.CustomType.ElectricCMemoryCell self); // 0x071bba9c
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCMemoryCell self, System.Int32 outputSlot); // 0x071bbb38
	static System.Void UpdateHasPowerImpl(WizardGames.Soc.Common.CustomType.ElectricCMemoryCell self, System.Int32 inputAmount, System.Int32 inputSlot); // 0x071bbc08
	static System.Void IOStateChangedImpl(WizardGames.Soc.Common.CustomType.ElectricCMemoryCell self, System.Int32 inputAmount, System.Int32 inputSlot); // 0x071bbd1c
	static System.Boolean GetState(WizardGames.Soc.Common.CustomType.ElectricCMemoryCell self); // 0x071bbf64
	static System.Void RefreshSetReset(WizardGames.Soc.Common.CustomType.ElectricCMemoryCell self); // 0x071bbdb8
	static System.Boolean AllowDrainFromImpl(WizardGames.Soc.Common.CustomType.ElectricCMemoryCell self, System.Int32 outputSlot); // 0x071bc058
	static System.Void OnEmitPowerTimerImpl(WizardGames.Soc.Common.CustomType.ElectricCMemoryCell self, System.Int64 _); // 0x071bc104
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCMultiBranchHotfix : System.Object
{
	
	static WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit GetTemplateImpl(WizardGames.Soc.Common.CustomType.ElectricCMultiBranch self); // 0x071bc198
	static System.Void UpdateLightStateImpl(WizardGames.Soc.Common.CustomType.ElectricCMultiBranch self); // 0x071bcef8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCOrSwitchHotfix : System.Object
{
	
	static System.Void CleanupImpl(WizardGames.Soc.Common.CustomType.ElectricCOrSwitch self); // 0x071bd104
	static System.Int32 DesiredPowerSlotImpl(WizardGames.Soc.Common.CustomType.ElectricCOrSwitch self, System.Int32 inputSlot); // 0x071bd170
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCOrSwitch self, System.Int32 outputSlot); // 0x071bd220
	static System.Void UpdateHasPowerImpl(WizardGames.Soc.Common.CustomType.ElectricCOrSwitch self, System.Int32 inputAmount, System.Int32 inputSlot); // 0x071bd2f0
	static System.Void UpdateFromInputInnerImpl(WizardGames.Soc.Common.CustomType.ElectricCOrSwitch self, System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.CustomType.ElectricCBase outputUnit); // 0x071bd388
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCPressurePadHotfix : System.Object
{
	
	static System.Void CleanupImpl(WizardGames.Soc.Common.CustomType.ElectricCPressurePad self); // 0x071bd6b4
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCPressurePad self, System.Int32 outputSlot); // 0x071bd7f0
	static System.Boolean AllowDrainFromImpl(WizardGames.Soc.Common.CustomType.ElectricCPressurePad self, System.Int32 outputSlot); // 0x071bd8b0
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCRandSwitchHotfix : System.Object
{
	
	static System.Boolean WantsPowerImpl(WizardGames.Soc.Common.CustomType.ElectricCRandSwitch self); // 0x071bd934
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCRandSwitch self, System.Int32 outputSlot); // 0x071bd9b0
	static System.Void UpdateHasPowerImpl(WizardGames.Soc.Common.CustomType.ElectricCRandSwitch self, System.Int32 inputAmount, System.Int32 inputSlot); // 0x071bda58
	static System.Void IOStateChangedImpl(WizardGames.Soc.Common.CustomType.ElectricCRandSwitch self, System.Int32 inputAmount, System.Int32 inputSlot); // 0x071bdb6c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCSolarPanelHotfix : System.Object
{
	
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCSolarPanel self, System.Int32 outputSlot); // 0x071bdd38
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCSwitchHotfix : System.Object
{
	
	static System.Void ClearLogicImpl(WizardGames.Soc.Common.CustomType.ElectricCSwitch self); // 0x071bddd4
	static System.Boolean WantsPowerImpl(WizardGames.Soc.Common.CustomType.ElectricCSwitch self); // 0x071bde94
	static System.Int32 ConsumptionAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCSwitch self, WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x071bdf04
	static System.Void IOStateChangedImpl(WizardGames.Soc.Common.CustomType.ElectricCSwitch self, System.Int32 inputAmount, System.Int32 inputSlot); // 0x071bdfe4
	static System.Void SetSwitch(WizardGames.Soc.Common.CustomType.ElectricCSwitch self, System.Boolean wantsOn); // 0x071be0d8
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCSwitch self, System.Int32 outputSlot); // 0x071be244
	static System.Void OnBusyTimerImpl(WizardGames.Soc.Common.CustomType.ElectricCSwitch self, System.Int64 _); // 0x071be2ec
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCTestGeneratorHotfix : System.Object
{
	
	static System.Boolean IsRootEntityImpl(WizardGames.Soc.Common.CustomType.ElectricCTestGenerator self); // 0x071be378
	static System.Int32 GetCurrentEnergyImpl(WizardGames.Soc.Common.CustomType.ElectricCTestGenerator self, WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x071be3dc
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCTestGenerator self, System.Int32 outputSlot); // 0x071be468
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCTimerHotfix : System.Object
{
	
	static System.Void InitImpl(WizardGames.Soc.Common.CustomType.ElectricCTimer self); // 0x071be4ec
	static System.Void ClearLogicImpl(WizardGames.Soc.Common.CustomType.ElectricCTimer self); // 0x071be5b0
	static System.Void UpdateFromInputInnerImpl(WizardGames.Soc.Common.CustomType.ElectricCTimer self, System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.CustomType.ElectricCBase outputUnit); // 0x071be680
	static System.Void IOStateChangedImpl(WizardGames.Soc.Common.CustomType.ElectricCTimer self, System.Int32 inputAmount, System.Int32 inputSlot); // 0x071be884
	static System.Void TrySetOn(WizardGames.Soc.Common.CustomType.ElectricCTimer self); // 0x071be964
	static System.Void AddResetTimer(WizardGames.Soc.Common.CustomType.ElectricCTimer self, System.Int64 time); // 0x071beab8
	static System.Void Reset(WizardGames.Soc.Common.CustomType.ElectricCTimer self, System.Int64 _); // 0x071be7c0
	static System.Boolean WantsPowerImpl(WizardGames.Soc.Common.CustomType.ElectricCTimer self); // 0x071bebc8
	static System.Int32 ConsumptionAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCTimer self, WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x071bec38
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCTimer self, System.Int32 outputSlot); // 0x071bed18
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCWindmillHotfix : System.Object
{
	
	static WizardGames.Soc.Common.Algorithm.Vector3 GetWindAimDir(System.Single time); // 0x071bedc0
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCXorSwitchHotfix : System.Object
{
	
	static System.Void CleanupImpl(WizardGames.Soc.Common.CustomType.ElectricCXorSwitch self); // 0x071bef60
	static System.Int32 DesiredPowerSlotImpl(WizardGames.Soc.Common.CustomType.ElectricCXorSwitch self, System.Int32 inputSlot); // 0x071befd0
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.ElectricCXorSwitch self, System.Int32 outputSlot); // 0x071bf084
	static System.Void UpdateHasPowerImpl(WizardGames.Soc.Common.CustomType.ElectricCXorSwitch self, System.Int32 inputAmount, System.Int32 inputSlot); // 0x071bf170
	static System.Void UpdateFromInputInnerImpl(WizardGames.Soc.Common.CustomType.ElectricCXorSwitch self, System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.CustomType.ElectricCBase outputUnit); // 0x071bf218
	static System.Void UpdateLightStateImpl(WizardGames.Soc.Common.CustomType.ElectricCXorSwitch self); // 0x071bf5b0
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricIntegratedCircuitHotfix : System.Object
{
	
	static System.Collections.Generic.KeyValuePair<System.Int32,WizardGames.Soc.Common.CustomType.Alpha3ElectricCircuitSlot> GetSlot(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit self, System.Int64 id, System.Int32 portId); // 0x071b34d0
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricIntegratedCircuitHotfix.<>c__DisplayClass1_0 : System.Object
{
	System.Int64 id; // 0x10
	System.Int32 portId; // 0x18
	System.Void .ctor(); // 0x071bf6f8
	System.Boolean <GetSlot>b__0(System.Collections.Generic.KeyValuePair<System.Int32,WizardGames.Soc.Common.CustomType.Alpha3ElectricCircuitSlot> item); // 0x071bf760
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.FluidicCContainerHotfix : System.Object
{
	
	static System.Void ClearDrains(WizardGames.Soc.Common.CustomType.FluidicCContainer self); // 0x071bf828
	static System.Void UpdateDrainAmount(WizardGames.Soc.Common.CustomType.FluidicCContainer self); // 0x071bf9c8
	static System.Void CalculateDrain(WizardGames.Soc.Common.CustomType.FluidicCContainer self, WizardGames.Soc.Common.CustomType.ElectricCBase ent, WizardGames.Soc.Common.Algorithm.Vector3 fromSlotWorld, System.Int32 depth, System.Int32& amount, WizardGames.Soc.Common.CustomType.ElectricCBase lastEntity, System.Int64 waterType); // 0x071bfd08
	static System.Void DeductFuel(WizardGames.Soc.Common.CustomType.FluidicCContainer self); // 0x071c00c0
	static System.Boolean HasLiquidItem(WizardGames.Soc.Common.CustomType.FluidicCContainer self); // 0x071c044c
	static System.ValueTuple<System.Int64,System.Int32> GetLiquid(WizardGames.Soc.Common.CustomType.FluidicCContainer self, System.Int32 index); // 0x071c04c0
	static System.Int64 GetLiquidItem(WizardGames.Soc.Common.CustomType.FluidicCContainer self, System.Int32 index); // 0x071bfc8c
	static System.Int32 GetLiquidCount(WizardGames.Soc.Common.CustomType.FluidicCContainer self, System.Int32 index); // 0x071c05ec
	static System.Void UpdatePushLiquidTargets(WizardGames.Soc.Common.CustomType.FluidicCContainer self); // 0x071c0670
	static System.Void PushLiquidThroughOutputs(WizardGames.Soc.Common.CustomType.FluidicCContainer self); // 0x071c0cbc
	static System.Void CheckPushLiquid(WizardGames.Soc.Common.CustomType.FluidicCContainer self, WizardGames.Soc.Common.CustomType.ElectricCBase connected, System.Int64 ourFuel, WizardGames.Soc.Common.CustomType.ElectricCBase fromSource, System.Int32 depth); // 0x071c08bc
	static System.Void PostInitLogic_FCContainer(WizardGames.Soc.Common.CustomType.FluidicCContainer self); // 0x071c1348
	static System.Void ClearLogic_FCContainer(WizardGames.Soc.Common.CustomType.FluidicCContainer self); // 0x071c13ac
	static System.Void OnCircuitChanged_FCContainer(WizardGames.Soc.Common.CustomType.FluidicCContainer self, System.Boolean forceUpdate); // 0x071c1458
	static System.Void SendChangedToRootUpdate_FCContainer(WizardGames.Soc.Common.CustomType.FluidicCContainer self); // 0x071c1528
	static System.Int32 GetCurrentEnergy_FCContainer(WizardGames.Soc.Common.CustomType.FluidicCContainer self, WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x071c15cc
	static System.Int32 CalculateCurrentEnergy_FCContainer(WizardGames.Soc.Common.CustomType.FluidicCContainer self, System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x071c16c0
	static System.Boolean ConsiderConnectedTo_FCContainer(WizardGames.Soc.Common.CustomType.FluidicCContainer self, WizardGames.Soc.Common.CustomType.ElectricCBase entity); // 0x071c1790
	static System.Void UpdateFromInputInner_FCContainer(WizardGames.Soc.Common.CustomType.FluidicCContainer self, System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.CustomType.ElectricCBase outputUnit); // 0x071c1818
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.FluidicCSprinklerHotfix : System.Object
{
	
	static System.Void SetFuelTypeImpl(WizardGames.Soc.Common.CustomType.FluidicCSprinkler self, System.Int64 itemId, WizardGames.Soc.Common.CustomType.FluidicCContainer source); // 0x071c1928
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.FluidicCSwitchHotfix : System.Object
{
	
	static System.Boolean AllowLiquidPassthroughImpl(WizardGames.Soc.Common.CustomType.FluidicCSwitch self, WizardGames.Soc.Common.CustomType.ElectricCBase fromSource, WizardGames.Soc.Common.Algorithm.Vector3 worldPos, System.Boolean forPlacement); // 0x071c1a90
	static System.Boolean WantsPowerImpl(WizardGames.Soc.Common.CustomType.FluidicCSwitch self); // 0x071c1bfc
	static System.Int32 ConsumptionAmountImpl(WizardGames.Soc.Common.CustomType.FluidicCSwitch self, WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x071c1c6c
	static System.Void IOStateChangedImpl(WizardGames.Soc.Common.CustomType.FluidicCSwitch self, System.Int32 inputAmount, System.Int32 inputSlot); // 0x071c1d18
	static System.Void UpdateHasPowerImpl(WizardGames.Soc.Common.CustomType.FluidicCSwitch self, System.Int32 inputAmount, System.Int32 inputSlot); // 0x071c2088
	static System.Void SetSwitch(WizardGames.Soc.Common.CustomType.FluidicCSwitch self, System.Boolean wantsOn); // 0x071c1e24
	static System.Void OnBusyTimerImpl(WizardGames.Soc.Common.CustomType.FluidicCSwitch self, System.Int64 _); // 0x071c2188
	static System.Int32 GetPassthroughAmountImpl(WizardGames.Soc.Common.CustomType.FluidicCSwitch self, System.Int32 outputSlot); // 0x071c2214
	static System.Void CleanupImpl(WizardGames.Soc.Common.CustomType.FluidicCSwitch self); // 0x071c22f4
}

// Client.Runtime
interface WizardGames.Soc.Common.CustomType.IEntityWithElectric : 
{
	
	System.Int64 get_EntityId(); // 0x054a4380
	System.Boolean get_IsLocalEntity(); // 0x054c4760
	System.Int64 get_TemplateId(); // 0x054a4380
	T GetComponent<T>(System.Int32 componentId); // 0x052af1f0
}

// Client.Runtime
interface WizardGames.Soc.Common.CustomType.IItemWithFrequency : 
{
	
	System.Int32 get_Frequency(); // 0x0548ba98
}

// Client.Runtime
interface WizardGames.Soc.Common.CustomType.IItemRFTransmitter : , WizardGames.Soc.Common.CustomType.IItemWithFrequency
{
	
	
}

// Client.Runtime
interface WizardGames.Soc.Common.CustomType.IItemRFReceiver : , WizardGames.Soc.Common.CustomType.IItemWithFrequency
{
	
	
}

// Client.Runtime
interface WizardGames.Soc.Common.CustomType.IFlowData : 
{
	
	System.Int32 get_DataType(); // 0x0548ba98
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.FlowDataType : System.Object
{
	static System.Int32 PlunderPlayerFlowData; // 0x0
	static System.Int32 PlunderBuffFlowData; // 0x4
	static System.Int32 PlunderAIDamageFlowData; // 0x8
	static System.Int32 PlunderConstructionDestroyFlowData; // 0xc
	static System.Void .cctor(); // 0x071c23c4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DataObjectHelper<T> : System.Object
{
	static System.Action<WizardGames.Soc.Common.CustomType.DataObject,T> Setter; // 0x0
	static System.Func<WizardGames.Soc.Common.CustomType.DataObject,T> Getter; // 0x8
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DataObjectHelper.<>c<T> : System.Object
{
	static WizardGames.Soc.Common.CustomType.DataObjectHelper.<>c<T> <>9; // 0x0
	static System.Void .cctor(); // 0x054fd168
	System.Void .ctor(); // 0x055049cc
	System.Void <.cctor>b__2_0(WizardGames.Soc.Common.CustomType.DataObject obj, System.Int32 val); // 0x05525b70
	System.Void <.cctor>b__2_1(WizardGames.Soc.Common.CustomType.DataObject obj, System.UInt32 val); // 0x0552b7dc
	System.Void <.cctor>b__2_2(WizardGames.Soc.Common.CustomType.DataObject obj, System.Int64 val); // 0x05527094
	System.Void <.cctor>b__2_3(WizardGames.Soc.Common.CustomType.DataObject obj, System.Byte val); // 0x0552af28
	System.Void <.cctor>b__2_4(WizardGames.Soc.Common.CustomType.DataObject obj, System.Int16 val); // 0x05525ae4
	System.Void <.cctor>b__2_5(WizardGames.Soc.Common.CustomType.DataObject obj, System.UInt16 val); // 0x0552b750
	System.Void <.cctor>b__2_6(WizardGames.Soc.Common.CustomType.DataObject obj, System.Boolean val); // 0x0552af28
	System.Void <.cctor>b__2_7(WizardGames.Soc.Common.CustomType.DataObject obj, System.UInt64 val); // 0x0552b938
	System.Void <.cctor>b__2_8(WizardGames.Soc.Common.CustomType.DataObject obj, System.Single val); // 0x05527688
	System.Void <.cctor>b__2_9(WizardGames.Soc.Common.CustomType.DataObject obj, System.Double val); // 0x05527b9c
	System.Int32 <.cctor>b__2_10(WizardGames.Soc.Common.CustomType.DataObject obj); // 0x0549a128
	System.UInt32 <.cctor>b__2_11(WizardGames.Soc.Common.CustomType.DataObject obj); // 0x054e225c
	System.Int64 <.cctor>b__2_12(WizardGames.Soc.Common.CustomType.DataObject obj); // 0x054a4a40
	System.Byte <.cctor>b__2_13(WizardGames.Soc.Common.CustomType.DataObject obj); // 0x054dec74
	System.Int16 <.cctor>b__2_14(WizardGames.Soc.Common.CustomType.DataObject obj); // 0x05485e40
	System.UInt16 <.cctor>b__2_15(WizardGames.Soc.Common.CustomType.DataObject obj); // 0x054e1b98
	System.Boolean <.cctor>b__2_16(WizardGames.Soc.Common.CustomType.DataObject obj); // 0x054dec74
	System.UInt64 <.cctor>b__2_17(WizardGames.Soc.Common.CustomType.DataObject obj); // 0x054e281c
	System.Single <.cctor>b__2_18(WizardGames.Soc.Common.CustomType.DataObject obj); // 0x054a6f88
	System.Double <.cctor>b__2_19(WizardGames.Soc.Common.CustomType.DataObject obj); // 0x054a7968
}

// Client.Runtime
enum WizardGames.Soc.Common.CustomType.ENodeDebugStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.CustomType.ENodeDebugStatus None = 0;
	static WizardGames.Soc.Common.CustomType.ENodeDebugStatus Running = 1;
	static WizardGames.Soc.Common.CustomType.ENodeDebugStatus Success = 2;
	static WizardGames.Soc.Common.CustomType.ENodeDebugStatus Failed = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.CustomType.ENodeExecLogType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.CustomType.ENodeExecLogType Start = 0;
	static WizardGames.Soc.Common.CustomType.ENodeExecLogType Success = 1;
	static WizardGames.Soc.Common.CustomType.ENodeExecLogType Failed = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.CustomType.EPersonalNoticeType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.CustomType.EPersonalNoticeType TerritoryCaptureSucNotice = 0;
	static WizardGames.Soc.Common.CustomType.EPersonalNoticeType TerritoryCapturedNotice = 1;
	static WizardGames.Soc.Common.CustomType.EPersonalNoticeType TerritoryAdminChangeNotice = 2;
	static WizardGames.Soc.Common.CustomType.EPersonalNoticeType TerritoryGroupChangeNotice = 3;
	static WizardGames.Soc.Common.CustomType.EPersonalNoticeType TerritoryMemberRemovedNotice = 4;
	static WizardGames.Soc.Common.CustomType.EPersonalNoticeType LoseTeritoryOwnership = 5;
	static WizardGames.Soc.Common.CustomType.EPersonalNoticeType BecomeTeritoryOwner = 6;
	static WizardGames.Soc.Common.CustomType.EPersonalNoticeType GetMemberTerritory = 7;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.CustomType.ETerritoryState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.CustomType.ETerritoryState Invalid = 0;
	static WizardGames.Soc.Common.CustomType.ETerritoryState Normal = 1;
	static WizardGames.Soc.Common.CustomType.ETerritoryState Debris = 2;
	static WizardGames.Soc.Common.CustomType.ETerritoryState Deserted = 3;
	
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CustomEx : System.Object
{
	
	static WizardGames.Soc.Common.Algorithm.Vector3 CustomV3ToCV3(WizardGames.Soc.Common.CustomType.CustomVector3 v3); // 0x071c2414
	static UnityEngine.Vector3 SV3ToUV3(WizardGames.Soc.Common.SimpleCustom.SimpleVector3 v3); // 0x071c24c0
	static UnityEngine.Vector3 CV3ToUV3(WizardGames.Soc.Common.CustomType.CustomVector3 v3); // 0x071c2564
	static WizardGames.Soc.Common.CustomType.CustomVector3 UV3ToA3CV3(UnityEngine.Vector3 v3); // 0x071c2648
	static UnityEngine.Quaternion CQToUQ(WizardGames.Soc.Common.Framework.Algorithm.Quaternion q); // 0x071c2734
	static WizardGames.Soc.Common.Framework.Algorithm.Quaternion UQToCQ(UnityEngine.Quaternion q); // 0x071c27d4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.Ugc.PgcDataHelper : System.Object
{
	
	static T GetData<T>(WizardGames.Soc.Common.CustomType.PgcGraphDataHost host, System.Int64 index, System.Int64 index2); // 0x052af1f0
	static T GetData<T>(WizardGames.Soc.Common.CustomType.PgcGraphDataHost host, System.Int64 index, System.Int64 index2, System.Int64 index3); // 0x052af1f0
	static WizardGames.Soc.Common.CustomType.PgcGraphData GetNode(WizardGames.Soc.Common.CustomType.PgcGraphDataHost host, System.Int64 index); // 0x071c2874
	static WizardGames.Soc.Common.CustomType.PgcGraphData GetNode(WizardGames.Soc.Common.CustomType.PgcGraphDataHost host, System.Int64 index, System.Int64 index2); // 0x071c28fc
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ActivationComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1962873132;
	static System.Int32 StaticClassHash; // 0x0
	static System.String TYPE_NAME = "ActivationComponent";
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071c29ac
	System.String GetTypeName(); // 0x071c2a14
	System.Int32 get_Id(); // 0x071c2a8c
	System.Void .ctor(); // 0x071c2af0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071c2b7c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071c2c2c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071c2cdc
	System.Int32 get_ActivationId(); // 0x071c2d40
	static System.Void .cctor(); // 0x071c2db4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ActivityStateComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1530092602;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071c2e70
	System.String GetTypeName(); // 0x071c2ed8
	System.Int32 get_Id(); // 0x071c2f50
	System.Void .ctor(); // 0x071c2fb4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071c3040
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071c30f0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071c31a0
	System.Int64 get_TemplateId(); // 0x071c3204
	WizardGames.Soc.Common.Data.Play.ActivityStation get_Config(); // 0x071c3278
	System.Boolean IsOpenInDuration(); // 0x071c3374
	static System.Void .cctor(); // 0x071c3474
}

// Client.Runtime
class WizardGames.Soc.Common.Component.AnchorComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1011965527;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	static WizardGames.Soc.Common.Component.AnchorComponent Instance; // 0x10
	System.Int64 nextGetAllPlayerTime; // 0x38
	System.Int32 GetClassHash(); // 0x071c3530
	System.String GetTypeName(); // 0x071c3598
	System.Int32 get_Id(); // 0x071c3610
	System.Void .ctor(); // 0x071c3674
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071c3708
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071c37c0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071c3878
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x071c38dc
	System.Void RemoteCallGetAllTerritory(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x071c3e6c
	System.Void RemoteCallGetTerritoryDetail(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 territoryId); // 0x071c3fc8
	System.Void RemoteCallGetAllPlayer(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x071c4150
	System.Void RemoteCallGetPlayerDetail(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.UInt64 roleId); // 0x071c42ac
	System.Void RemoteCallFollowPlayer(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.UInt64 roleId); // 0x071c4434
	System.Void PostInit(); // 0x071c45bc
	System.Void GetAllTerritoryAck(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.PatrolTerritoryBriefInfo> territories); // 0x071c3b9c
	System.Void GetTerritoryDetailAck(WizardGames.Soc.Common.CustomType.PatrolTerritoryDetailInfo detailInfo); // 0x071c3c50
	System.Void GetAllPlayerAck(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo> players); // 0x071c3d04
	System.Void GetPlayerDetailAck(WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo detailInfo); // 0x071c3db8
	static System.Void .cctor(); // 0x071c4690
}

// Client.Runtime
class WizardGames.Soc.Common.Component.AutoSyncBoxComponent : WizardGames.Soc.Common.Component.BoxComponent
{
	static System.Int32 CLASS_HASH = 1682000271;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071c4714
	System.String GetTypeName(); // 0x071c477c
	System.Int32 get_Id(); // 0x071c47f4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071c4858
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071c4908
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071c49b8
	static System.Object DeserializeAutoSyncBoxComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071c4a1c
	static System.Void .cctor(); // 0x071c4af0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.AutoTurretComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 1762523761;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071c4f90
	System.String GetTypeName(); // 0x071c4ff8
	System.Int32 get_Id(); // 0x071c5070
	System.Void .ctor(); // 0x071c50d4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071c5160
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071c5210
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071c52c0
	static System.Void .cctor(); // 0x071c5324
}

// Client.Runtime
class WizardGames.Soc.Common.Component.BaseCorpseComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 537080731;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071c5448
	System.String GetTypeName(); // 0x071c54b0
	System.Int32 get_Id(); // 0x071c5528
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071c558c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071c563c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071c56ec
	static System.Void .cctor(); // 0x071c5750
}

// Client.Runtime
class WizardGames.Soc.Common.Component.BeeBuzzComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1001381970;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071c5840
	System.String GetTypeName(); // 0x071c58a8
	System.Int32 get_Id(); // 0x071c5920
	System.Void .ctor(); // 0x071c5984
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071c5a10
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071c5b08
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071c5bb8
	System.Int32 get_TotalOutControlNum(); // 0x071c5c1c
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.BeeBuzzContributeRecord> get_ContributeRecord(); // 0x071c5c90
	System.Void set_ContributeRecord(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.BeeBuzzContributeRecord> value); // 0x071c5d30
	System.Int64 get_HasExchangedCardId(); // 0x071c5dbc
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x071c5e30
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x071c5f90
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x071c61d8
	System.Void RemoteCallExchangeSignalCard(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 cardId); // 0x071c67b8
	System.Void RemoteCallCheckUseBeeBuzzSignalCard(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 cardUid); // 0x071c6940
	static System.Object DeserializeBeeBuzzComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071c6ac8
	WizardGames.Soc.Common.Entity.PlayerEntity get_Player(); // 0x071c6b98
	System.Void PostInit(); // 0x071c6c50
	System.Void CheckUseBeeBuzzSignalCardAck(System.Int32 code); // 0x071c63a4
	static System.Void .cctor(); // 0x071c6d98
}

// Client.Runtime
class WizardGames.Soc.Common.Component.BeeBuzzComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.BeeBuzzComponent.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.Share.Framework.CustomTypeBase,System.Int32,System.Int32> <>9__43_0; // 0x8
	static System.Void .cctor(); // 0x071c6f8c
	System.Void .ctor(); // 0x071c6ff0
	System.Void <PostInit>b__43_0(WizardGames.Soc.Share.Framework.CustomTypeBase _, System.Int32 oldValue, System.Int32 newValue); // 0x071c7058
}

// Client.Runtime
class WizardGames.Soc.Common.Component.BlueprintComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1271476125;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071c7148
	System.String GetTypeName(); // 0x071c71b0
	System.Int32 get_Id(); // 0x071c7228
	System.Void .ctor(); // 0x071c728c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071c7318
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071c74d8
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071c7588
	WizardGames.Soc.Common.CustomType.BlueprintRootNode get_SystemRoot(); // 0x071c75ec
	WizardGames.Soc.Common.CustomType.TechnologyTreeRootNode get_TechSystemRoot(); // 0x071c76b0
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.BluePrintInfo> get_UnlockBluePrints(); // 0x071c7774
	System.Void set_UnlockBluePrints(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.BluePrintInfo> value); // 0x071c7814
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> get_UnlockTechIds(); // 0x071c78a0
	System.Void set_UnlockTechIds(WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> value); // 0x071c7940
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x071c79cc
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x071c7b2c
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x071c7ea0
	System.Void RemoteCallGetElectricBlueprint(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 itemId); // 0x071c879c
	System.Void RemoteCallStartEditElectricBlueprint(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 itemId); // 0x071c8924
	System.Void RemoteCallStopEditElectricBlueprint(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 blueprintId); // 0x071c8aac
	System.Void RemoteCallBluePrintOp(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 bpId, System.Int32 opType); // 0x071c8c34
	System.Void RemoteCallTechnologyUnlock(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Collections.Generic.ISet<System.Int64> bizIds, System.Int64 workBenchId); // 0x071c8dc8
	static System.Object DeserializeBlueprintComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071c8f5c
	WizardGames.Soc.Common.Entity.PlayerEntity get_Player(); // 0x071c9080
	WizardGames.Soc.Common.Component.RootNodeComponent get_Root(); // 0x071c9138
	System.Void Init(); // 0x071c91c4
	System.Void PostInit(); // 0x071c922c
	System.Void TechnologyUpdateNotify(System.Int32 opCode); // 0x071c81c4
	System.Void BlueprintOpResponse(); // 0x071c8334
	System.Void GetElectricBlueprintAck(System.Int64 itemId, System.Buffers.ReadOnlySequence<System.Byte> blueprint); // 0x071c8394
	System.Void OnUseBlueprintItem(System.Int64 id, System.Int32 count); // 0x071c8460
	static System.Void .cctor(); // 0x071c9350
}

// Client.Runtime
class WizardGames.Soc.Common.Component.BlueprintComponent.<>c__DisplayClass46_0 : System.Object
{
	System.Int64 id; // 0x10
	System.Void .ctor(); // 0x071c92e8
	System.Void <OnUseBlueprintItem>b__0(); // 0x071c94dc
}

// Client.Runtime
class WizardGames.Soc.Common.Component.BoxComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 1945005400;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071c95ec
	System.String GetTypeName(); // 0x071c9654
	System.Int32 get_Id(); // 0x071c96cc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071c9730
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071c97e0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071c9890
	System.Int64 get_CorpseId(); // 0x071c98f4
	System.Int64 get_CorpseHostTemplateId(); // 0x071c9968
	System.Int64 get_StorageTemplateId(); // 0x071c99dc
	static System.Object DeserializeBoxComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071c9a50
	System.Void PostInit(); // 0x071c9b24
	System.Int64 get_PlayerId(); // 0x071c9b98
	WizardGames.Soc.Common.Entity.BoxEntity get_boxEntity(); // 0x071c9c0c
	static System.Void .cctor(); // 0x071c9cc4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.BoxDamageableComponent : WizardGames.Soc.Common.Component.DamageableComponent
{
	static System.Int32 CLASS_HASH = 413338704;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071c9f54
	System.String GetTypeName(); // 0x071c9fbc
	System.Int32 get_Id(); // 0x071ca034
	System.Void .ctor(); // 0x071ca098
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071ca1b4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071ca318
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071ca47c
	static System.Void .cctor(); // 0x071ca4e0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.BoxGameComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 499854868;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071ca708
	System.String GetTypeName(); // 0x071ca770
	System.Int32 get_Id(); // 0x071ca7e8
	System.Void .ctor(); // 0x071ca84c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071ca8d8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071ca9c4
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071caa74
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int64> get_GameList(); // 0x071caad8
	System.Void set_GameList(WizardGames.Soc.Share.Framework.BasicTypeList<System.Int64> value); // 0x071cab78
	System.Int64 get_NextOpenTs(); // 0x071cac04
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x071cac78
	System.Void RemoteCallStopGame(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x071caebc
	System.Void RemoteCallHitUnlockAngle(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 gameId, System.Int32 angle); // 0x071cb018
	static System.Object DeserializeBoxGameComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071cb1ac
	static System.Void .cctor(); // 0x071cb27c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.BuffComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1985451735;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071cb3a0
	System.String GetTypeName(); // 0x071cb408
	System.Int32 get_Id(); // 0x071cb480
	System.Void .ctor(); // 0x071cb4e4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071cb570
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071cb688
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071cb738
	WizardGames.Soc.Common.CustomType.BuffRootNode get_SystemRoot(); // 0x071cb79c
	static System.Object DeserializeBuffComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071cb860
	System.Void Init(); // 0x071cb96c
	System.ValueTuple<System.Int32,System.Int32> GetBuff(WizardGames.Soc.Common.Data.BuffType buffType); // 0x071cbbb8
	static System.Void .cctor(); // 0x071cbcfc
	System.Void <Init>b__18_0(WizardGames.Soc.Share.Framework.ECustomDictOpType type, System.Int64 key, WizardGames.Soc.Common.CustomType.NodeBase value); // 0x071cbe88
}

// Client.Runtime
class WizardGames.Soc.Common.Component.BuffComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.BuffComponent.<>c <>9; // 0x0
	static System.Action <>9__18_2; // 0x8
	static System.Action <>9__18_1; // 0x10
	static System.Void .cctor(); // 0x071cc07c
	System.Void .ctor(); // 0x071cc0e0
	System.Void <Init>b__18_2(); // 0x071cc148
	System.Void <Init>b__18_1(); // 0x071cc1e4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.CampingTentComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 328695419;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071cc280
	System.String GetTypeName(); // 0x071cc2e8
	System.Int32 get_Id(); // 0x071cc360
	System.Void .ctor(); // 0x071cc3c4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071cc450
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071cc500
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071cc5b0
	static System.Void .cctor(); // 0x071cc614
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ChatComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 2074289843;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071cc738
	System.String GetTypeName(); // 0x071cc7a0
	System.Int32 get_Id(); // 0x071cc818
	System.Void .ctor(); // 0x071cc87c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071cc908
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071cca54
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071ccb04
	WizardGames.Soc.Common.CustomType.TeamChatSession get_TeamChat(); // 0x071ccb68
	WizardGames.Soc.Common.CustomType.QuickTeamChatSession get_QuickTeamChat(); // 0x071ccc2c
	System.Boolean get_IsDisableChat(); // 0x071cccf0
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x071ccd64
	System.Void RemoteCallSendWorldChat(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.String content, System.String metaData); // 0x071ce604
	System.Void RemoteCallGetTeamChatMessage(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x071ce798
	System.Void RemoteCallSetMessageRead(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.UInt64 channelId, System.UInt32 sequence); // 0x071ce8f4
	System.Void RemoteCallSendQuickTeamChat(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 textId); // 0x071cea88
	System.Void RemoteCallSendTeamChat(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.String content, System.String metaData); // 0x071cec10
	System.Void PostInit(); // 0x071ceda4
	System.Void OnGetTeamChatMessage(System.Buffers.ReadOnlySequence<System.Byte> serialized); // 0x071cd1ec
	System.Void OnTeamChat(System.UInt64 roleId, System.String name, System.Buffers.ReadOnlySequence<System.Byte> serialize); // 0x071cdd54
	System.Void OnDisableChat(System.Int32 time, System.Int32 reason); // 0x071ce04c
	System.Void OnForiddenChat(); // 0x071ce164
	System.Void OnSendChatFailed(System.Int32 errorCode); // 0x071ce1c4
	System.Void OnSendQuickTeamSuccess(); // 0x071ce32c
	static System.Void OnReceiveWorldChat(WizardGames.Soc.Common.CustomType.ChatMessageWithInfo message); // 0x071cef34
	System.Void OnWorldChat(WizardGames.Soc.Common.CustomType.ChatMessageWithInfo msg); // 0x071ce3cc
	System.Void OnWorldChatByLoad(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.ChatMessageWithInfo> msgs); // 0x071ce468
	static System.Void .cctor(); // 0x071cf18c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ClientGraphNodeComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1635910869;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071cf34c
	System.String GetTypeName(); // 0x071cf3b4
	System.Int32 get_Id(); // 0x071cf42c
	System.Void .ctor(); // 0x071cf490
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071cf51c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071cf5cc
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071cf67c
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x071cf6e0
	System.Void ModifyBackgrounMusic(System.String musicId); // 0x071cfef4
	System.Void OpenTeamSelector(System.Int64 graphEntityId, WizardGames.Soc.Common.CustomType.MultiLangStringBuilder title, System.Int64 roleIdToTeamId, WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.SelectableTeamInfo> teamSelectorData, System.Int64 autoCloseTime); // 0x071d00ac
	System.Void InitTargetState(System.Int64 graphEntityId, System.Boolean isCountDown, System.Int64 targetIds, System.Int64 countDownStartTsSec, System.Int64 countDownSecond, WizardGames.Soc.Common.SimpleCustom.EProgressBarType type); // 0x071d034c
	System.Void SwitchTargetTip(System.Int64 tipId1, WizardGames.Soc.Common.CustomType.MultiLangStringBuilder text1, System.Int64 tipId2, WizardGames.Soc.Common.CustomType.MultiLangStringBuilder text2); // 0x071d0508
	System.Void ShowResidentTargetTip(WizardGames.Soc.Common.CustomType.MultiLangStringBuilder text); // 0x071d076c
	System.Void CloseResidentTargetTip(); // 0x071d0930
	System.Void ShowTempStateTip(WizardGames.Soc.Common.CustomType.MultiLangStringBuilder text); // 0x071d0a40
	System.Void CloseTempStateTip(); // 0x071d0c04
	System.Void ShowGameResultPanel(WizardGames.Soc.Common.SimpleCustom.EGameResultType gameResultType, WizardGames.Soc.Common.CustomType.MultiLangStringBuilder title, WizardGames.Soc.Common.CustomType.MultiLangStringBuilder desc, WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.ItemCount> itemCount, System.Int64 winUIAutoCloseTime, System.Int64 rewardAutoCloseTime, System.Int64 manuallyCloseTime, System.Int64 autoCloseTime); // 0x071d0d14
	System.Void SwitchClientUIModule(System.String moduleId, System.Boolean toggle); // 0x071d11b8
	System.Void ShowImageMessage(System.Int64 picBoxId); // 0x071d129c
	System.Void InitStatPanel(System.Int64 graphEntityId, WizardGames.Soc.Common.CustomType.InitStatPanelData data); // 0x055128b0
	System.Void ShowNewbieProtectionCountdown(System.Int64 endStamp); // 0x071d1494
	static System.String MultiLangStringToString(WizardGames.Soc.Common.SimpleCustom.MultiLangStringBuilderCfg builder); // 0x071d1868
	static System.String MultiLangStringToString(WizardGames.Soc.Common.SimpleCustom.MultiLangStringCfg strCfg); // 0x071d1c04
	static System.String[] MultiLangStringBuilderToServerTipDataContent(WizardGames.Soc.Common.SimpleCustom.MultiLangStringBuilderCfg builder); // 0x071d1a0c
	static System.Void .cctor(); // 0x071d1d1c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ClientGraphNodeComponent.<>c__DisplayClass23_0 : System.Object
{
	WizardGames.Soc.Common.SimpleCustom.EGameResultType gameResultType; // 0x10
	WizardGames.Soc.Common.CustomType.MultiLangStringBuilder title; // 0x18
	WizardGames.Soc.Common.CustomType.MultiLangStringBuilder desc; // 0x20
	System.Int64 manuallyCloseTime; // 0x28
	System.Int64 autoCloseTime; // 0x30
	System.Void .ctor(); // 0x071d193c
	System.Void <ShowGameResultPanel>b__0(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ClientGraphNodeComponent.<>c__DisplayClass27_0 : System.Object
{
	System.Int64 endStamp; // 0x10
	System.Void .ctor(); // 0x071d19a4
	System.Void <ShowNewbieProtectionCountdown>b__0(WizardGames.Soc.SocClient.Ui.ComOngoingTip ongoingTip); // 0x071d2114
}

// Client.Runtime
class WizardGames.Soc.Common.Component.CombatBaseComponentDefine : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 2043569384;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071d2314
	System.String GetTypeName(); // 0x071d237c
	System.Int32 get_Id(); // 0x071d23f4
	System.Void .ctor(); // 0x071d2458
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071d24e4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071d2594
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071d2644
	static System.Void .cctor(); // 0x071d26a8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.CommonComposeComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1705611506;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071d2834
	System.String GetTypeName(); // 0x071d289c
	System.Int32 get_Id(); // 0x071d2914
	System.Void .ctor(); // 0x071d2978
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071d2a04
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071d2b1c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071d2bcc
	WizardGames.Soc.Common.CustomType.SystemRootNode get_SystemRoot(); // 0x071d2c30
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x071d2cf4
	System.Void RemoteCallCommonComposeCancel(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 index); // 0x071d34d0
	System.Void RemoteCallCommonComposeStart(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 bpId, System.Int32 count, System.Int64 entityId, System.Int64 skinConfigId, System.Int32 composeSourceMark); // 0x071d3658
	System.Void RemoteCallCommonComposeClaim(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x071d3838
	WizardGames.Soc.Common.Entity.PlayerEntity get_Player(); // 0x071d3994
	WizardGames.Soc.Common.Component.RootNodeComponent get_Root(); // 0x071d3a4c
	System.Void Init(); // 0x071d3ad8
	System.Void PostInit(); // 0x071d3b40
	System.Void CommonComposeCancelResponse(System.Int32 opCode); // 0x071d2f8c
	System.Void CommonComposeClaimResponse(System.Int32 opCode); // 0x071d3124
	System.Void CommonComposeDoneNotify(); // 0x071d32a8
	System.Void CommonComposeStartResponse(System.Int32 opCode, System.Int32 workBenchLevel); // 0x071d3344
	static System.Void .cctor(); // 0x071d3bd4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ComposterComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 1617124838;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	WizardGames.Soc.Common.CustomType.ItemContainerNode container; // 0x38
	WizardGames.Soc.Common.Component.ComposterComponent.OnCompostingChangeCallBack CallBack; // 0x40
	System.Int32 GetClassHash(); // 0x071d3c90
	System.String GetTypeName(); // 0x071d3cf8
	System.Int32 get_Id(); // 0x071d3d70
	System.Void .ctor(); // 0x071d3dd4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071d3e60
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071d3f10
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071d3fc0
	System.Single get_Manure(); // 0x071d4024
	System.Boolean get_IsOpen(); // 0x071d4098
	System.Int64 get_CompostingNodeId(); // 0x071d410c
	System.Int64 get_CompostingStartTs(); // 0x071d4180
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x071d41f4
	System.Void RemoteCallComposting(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean start); // 0x071d43a4
	static System.Void .cctor(); // 0x071d452c
	System.Void PostInit(); // 0x071d4790
	System.Void Cleanup(); // 0x071d490c
	System.Void CompostingAck(); // 0x071d4a00
	System.Void ComposterAnyUpdate(); // 0x071d4b0c
	static System.Void ComposterStartCallback(WizardGames.Soc.Share.Framework.CustomTypeBase comp, System.Int64 oldVal, System.Int64 newVal); // 0x071d4bac
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ComposterComponent.OnCompostingChangeCallBack : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x071d4c80
	System.Void Invoke(System.Boolean ret); // 0x071d4d48
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ConstructionBaseComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 26;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071d4d94
	System.String GetTypeName(); // 0x071d4df8
	System.Int32 get_Id(); // 0x071d4e70
	System.Void .ctor(); // 0x071d4ed4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071d4f60
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071d5010
	System.Int64 get_TerritoryId(); // 0x071d5074
	System.Int64 get_SkinId(); // 0x071d50e8
	System.Int64 get_LastChangeSkinTs(); // 0x071d515c
	System.Boolean get_IsImport(); // 0x071d51d0
	System.Void RequestRotate(); // 0x071d5244
	System.Void ReturnToPoolBusiness(); // 0x071d5640
	WizardGames.Soc.Common.Entity.PartEntity get_parentPartEntity(); // 0x071d5588
	System.Int64 get_TemplateId(); // 0x071d5514
	static System.Void .cctor(); // 0x071d56a0
	static System.Void OnEntitySkinIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int64 oldValue, System.Int64 skinId); // 0x071d5930
	System.Void RefreshSkinId(); // 0x071d5a04
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ConstructionCombinationComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1338012942;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071d5cd8
	System.String GetTypeName(); // 0x071d5d40
	System.Int32 get_Id(); // 0x071d5db8
	System.Void .ctor(); // 0x071d5e1c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071d5ea8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071d5fa0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071d6050
	System.Boolean get_IsComboPart(); // 0x071d60b4
	System.Int64 get_ComboParentId(); // 0x071d6128
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.ComboChildPartData> get_ComboChildInfoDict(); // 0x071d619c
	System.Void set_ComboChildInfoDict(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.ComboChildPartData> value); // 0x071d623c
	System.Int64 get_ComboChildGroupId(); // 0x071d62c8
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x071d633c
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x071d649c
	static System.Object DeserializeConstructionCombinationComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071d66e4
	static System.Void .cctor(); // 0x071d67b4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ConstructionCoreComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 25;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071d690c
	System.String GetTypeName(); // 0x071d6970
	System.Int32 get_Id(); // 0x071d69e8
	System.Void .ctor(); // 0x071d6a4c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071d6ad8
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071d6b88
	System.Int32 get_Grade(); // 0x071d6bec
	WizardGames.Soc.Common.Entity.PartEntity get_parentPartEntity(); // 0x071d6c60
	System.Void Init(); // 0x071d6d18
	System.Void OnGoLoaded(); // 0x071d6d80
	static System.Void .cctor(); // 0x071d6de8
	static System.Void OnEntityGradeChange(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int32 oldValue, System.Int32 grade); // 0x071d6f40
	System.Void RefreshGrade(); // 0x071d7080
	System.Void ReturnToPoolBusiness(); // 0x071d71e8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ConstructionDecayProtectionComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 863698831;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071d7248
	System.String GetTypeName(); // 0x071d72b0
	System.Int32 get_Id(); // 0x071d7328
	System.Void .ctor(); // 0x071d738c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071d7418
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071d74c8
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071d7578
	System.Single get_CupboardToolProtectTime(); // 0x071d75dc
	static System.Void .cctor(); // 0x071d7650
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ConstructionDoorBaseComponent : WizardGames.Soc.Share.Framework.ComponentBase, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 2012521359;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	static System.String OpenTriggerName; // 0x10
	static SocLogger logger; // 0x18
	WizardGames.Soc.Common.Unity.Construction.IBinaryAnimationPlayer animationPlayer; // 0x38
	static System.Collections.Generic.List<System.String> DoorAnimations; // 0x20
	System.Int64 nextAnimCheckTimeMSec; // 0x40
	WizardGames.Soc.Common.Construction.AnimSubNodeMeshDealer animDealer; // 0x48
	UnityEngine.Transform staticCloseMeshRender; // 0x50
	UnityEngine.Transform staticOpenMeshRender; // 0x58
	WizardGames.Soc.Common.Construction.LadderHatchBind ladderHatchBind; // 0x60
	UnityEngine.GameObject skinObj; // 0x68
	WizardGames.Soc.Common.Combat.AdsorbCollideConfig[] _adsorbCollideConfigs; // 0x70
	System.Int64 timerId; // 0x78
	System.Int64 ladderTimerId; // 0x80
	System.Boolean doubleDirAnimation; // 0x88
	WizardGames.Soc.Common.Component.ConstructionFlagComponent FlagComp; // 0x90
	System.Int32 GetClassHash(); // 0x071d770c
	System.String GetTypeName(); // 0x071d7774
	System.Int32 get_Id(); // 0x071d77ec
	System.Void .ctor(); // 0x071d7850
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071d78dc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071d798c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071d7a3c
	System.Void OnGoLoaded(); // 0x071d7aa0
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x071d7b08
	System.Void OnSkinGoRemove(); // 0x071d815c
	System.Void SetupAnimationNode(); // 0x071d7dc0
	System.Void OnFlagChangeCallback(System.Int32 oldFlag, System.Int32 newFlag); // 0x071d81c4
	System.Void OnFlagChange(System.Int32 oldFlag, System.Int32 newFlag, System.Boolean isInit); // 0x071d825c
	System.Void OpenDoorInternal(System.Boolean isOpen, System.Boolean bImmediate); // 0x071d84c8
	System.Void TickAdsorb(System.Int64 deltaTime); // 0x071d8af8
	System.Void RefreshAdsorb(); // 0x071d7ff0
	System.Void OpenHatchInternal(System.Boolean isOpen, System.Boolean bImmediate); // 0x071d8c8c
	System.Void Cleanup(); // 0x071d8e04
	System.Void Tick(System.Int64 deltaTime); // 0x071d8eb8
	System.Void SwitchStaticMeshRender(); // 0x071d9214
	System.Void CloseStaticMeshRender(); // 0x071d8870
	UnityEngine.Vector3 GetDoorPlaneXZDir(); // 0x071d9384
	System.Boolean GetOpenDoorDir(UnityEngine.Vector3 doorPlaneDir, WizardGames.Soc.Common.Entity.PlayerEntity player); // 0x071d9484
	System.Boolean IsOpen(); // 0x071d931c
	System.Boolean IsBusy(); // 0x071d8460
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x071d8a40
	System.Boolean HasFlag(WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags flag); // 0x071d8980
	static System.Void .cctor(); // 0x071d9620
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ConstructionDoorComponent : WizardGames.Soc.Common.Component.ConstructionDoorBaseComponent, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 342218603;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	static SocLogger logger; // 0x10
	System.Action OpenDoorAction; // 0x98
	System.Boolean hasHatch; // 0xa0
	WizardGames.Soc.Common.Unity.Construction.AutoOpenDoorConfig autoOpenDoorConfig; // 0xa8
	System.Boolean <NewIsOpen>k__BackingField; // 0xb0
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0xb8
	System.Int32 GetClassHash(); // 0x071d997c
	System.String GetTypeName(); // 0x071d99e4
	System.Int32 get_Id(); // 0x071d9a5c
	System.Void .ctor(); // 0x071d9ac0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071d9b80
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071d9c64
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071d9d48
	System.Boolean get_IsAutoOpen(); // 0x071d9dac
	System.Int64 get_NxtAutoCloseTime(); // 0x071d9e20
	System.Int32 get_AutoOpenState(); // 0x071d9e94
	System.Void RemoteCallOpenDoorServer(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean isOpen, System.Boolean openRevertDir); // 0x071d9f08
	System.Void RemoteCallKnockDoorServer(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x071da09c
	System.Void RemoteCallOpenHatchServer(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean isOpen); // 0x071da1f8
	System.Void RemoteCallSetAutoOpenDoor(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean isAutoOpen); // 0x071da380
	WizardGames.Soc.Common.Entity.PartEntity get_partEntity(); // 0x071da508
	System.Boolean get_NewIsOpen(); // 0x071da5c0
	System.Void set_NewIsOpen(System.Boolean value); // 0x071da624
	static System.Void .cctor(); // 0x071da6a0
	static System.Void IsAutoOpenDoorChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Boolean oldVal, System.Boolean newVal); // 0x071da978
	static System.Void AutoOpenDoorStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldVal, System.Int32 newVal); // 0x071daaac
	System.Void OnGoLoaded(); // 0x071dabe4
	System.Void OnSkinGoRemove(); // 0x071dad74
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x071daee8
	System.Void InitInstanceToggleGroup(); // 0x071db560
	System.Void Cleanup(); // 0x071db950
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x071dbb40
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x071dbbb4
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag, System.Boolean isInit); // 0x071dbfd4
	System.Void OpenDoorRequest(System.Boolean isOpen); // 0x071dbcb4
	System.Void KnockDoorRequest(); // 0x071dbe3c
	System.Void OpenHatchRequest(System.Boolean isOpen); // 0x071dbefc
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x071dc4cc
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x071dc5bc
	System.Boolean TerritoryCenterStateMeetConditions(); // 0x071dc92c
	System.Void OnTriggerOpenDoor(); // 0x071dcaa4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ConstructionDoorComponent.<>c__DisplayClass43_0 : System.Object
{
	WizardGames.Soc.Common.Component.ConstructionDoorComponent <>4__this; // 0x10
	WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer gpuInstContainer; // 0x18
	System.Void .ctor(); // 0x071db4f8
	System.Void <OnSkinGoLoaded>b__0(System.Boolean enable); // 0x071dcd78
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ConstructionFlagComponent : WizardGames.Soc.Share.Framework.ComponentBase, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler, WizardGames.Soc.Common.Component.IFlagComp
{
	static System.Int32 CLASS_HASH = 32;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Collections.Generic.List<WizardGames.Soc.Common.Construction.EntityFlag_Toggle> FlagToggleLst; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.Construction.EntityFlag_Toggle> SkinFlagToggleLst; // 0x40
	System.Action<System.Int32,System.Int32> OnFlagChanged; // 0x48
	System.Int32 GetClassHash(); // 0x071dce58
	System.String GetTypeName(); // 0x071dcebc
	System.Int32 get_Id(); // 0x071dcf34
	System.Void .ctor(); // 0x071dcf98
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071dd0a0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071dd1cc
	System.Int32 get_Flags(); // 0x071db84c
	System.Void set_Flags(System.Int32 value); // 0x071dd230
	System.Void OnGoLoaded(); // 0x071dd2bc
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x071dd634
	System.Void OnSkinGoRemove(); // 0x071dd6b4
	System.Void BindToggleLst(UnityEngine.GameObject go, System.Collections.Generic.List<WizardGames.Soc.Common.Construction.EntityFlag_Toggle> lst); // 0x071dd404
	System.Void UnBindToggleLst(System.Collections.Generic.List<WizardGames.Soc.Common.Construction.EntityFlag_Toggle> lst); // 0x071dd71c
	System.Void ReturnToPoolBusiness(); // 0x071dd8e8
	WizardGames.Soc.Common.Entity.PartEntity get_parentPartEntity(); // 0x071dd34c
	System.Void Init(); // 0x071dd9b8
	System.Void Cleanup(); // 0x071dda18
	System.Void OnUnityCleanup(); // 0x071dda98
	static System.Void .cctor(); // 0x071ddb0c
	static System.Void OnFlagsChanged(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldVal, System.Int32 newVal); // 0x071ddc64
	static System.Void RegisterFlagChangeCallback(WizardGames.Soc.Common.Component.ConstructionFlagComponent comp, System.Action<System.Int32,System.Int32> callback); // 0x071db8c0
	static System.Void UnRegisterFlagChangeCallback(WizardGames.Soc.Common.Component.ConstructionFlagComponent comp, System.Action<System.Int32,System.Int32> callback); // 0x071dae58
	System.Void RegisterFlagChangeCallback(System.Action<System.Int32,System.Int32> callback); // 0x071ddd3c
	System.Void UnRegisterFlagChangeCallback(System.Action<System.Int32,System.Int32> callback); // 0x071dde20
	System.Void SetFlag(WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags flag, System.Boolean value); // 0x071ddf04
	System.Boolean HasFlag(WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags flag); // 0x071ddfa0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ConstructionGapComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1355273944;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	static SocLogger <Logger>k__BackingField; // 0x10
	WizardGames.Soc.Common.Unity.Construction.ConstructionGapSkin constructionGapSkin; // 0x38
	System.Collections.Generic.HashSet<System.Int64> entityhHashSet; // 0x40
	System.Int32 GetClassHash(); // 0x071de024
	System.String GetTypeName(); // 0x071de08c
	System.Int32 get_Id(); // 0x071de104
	System.Void .ctor(); // 0x071de168
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071de240
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071de33c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071de438
	System.Single get_GapPosXLeft(); // 0x071de49c
	System.Single get_GapPosZLeft(); // 0x071de510
	System.Single get_GapPosYLeft(); // 0x071de584
	System.Single get_GapRotateXLeft(); // 0x071de5f8
	System.Single get_GapRotateYLeft(); // 0x071de66c
	System.Single get_GapRotateZLeft(); // 0x071de6e0
	System.Boolean get_IsShowLeft(); // 0x071de754
	System.Int64 get_TargetEntityIdLeft(); // 0x071de7c8
	System.Int32 get_TargetGapIdLeft(); // 0x071de83c
	System.Int64 get_DependEntityIdLeft(); // 0x071de8b0
	System.Int32 get_DependGapIdLeft(); // 0x071de924
	System.Single get_GapPosXRight(); // 0x071de998
	System.Single get_GapPosZRight(); // 0x071dea0c
	System.Single get_GapPosYRight(); // 0x071dea80
	System.Single get_GapRotateXRight(); // 0x071deaf4
	System.Single get_GapRotateYRight(); // 0x071deb68
	System.Single get_GapRotateZRight(); // 0x071debdc
	System.Boolean get_IsShowRight(); // 0x071dec50
	System.Int64 get_TargetEntityIdRight(); // 0x071decc4
	System.Int32 get_TargetGapIdRight(); // 0x071ded38
	System.Int64 get_DependEntityIdRight(); // 0x071dedac
	System.Int32 get_DependGapIdRight(); // 0x071dee20
	WizardGames.Soc.Common.Entity.PartEntity get_parentPartEntity(); // 0x071dee94
	WizardGames.Soc.Common.Unity.Construction.ConstructionGapSkin get_ConstructionGapSkin(); // 0x071def4c
	static System.Void .cctor(); // 0x071deff0
	static System.Void OnEntityGapTargetEntityIDChange_Left(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int64 oldValue, System.Int64 newValue); // 0x071dfb2c
	static System.Void OnEntityGapTargetIDChange_Left(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int32 oldValue, System.Int32 newValue); // 0x071dfd90
	static System.Void OnEntityGapDependEntityIDChange_Left(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int64 oldValue, System.Int64 newValue); // 0x071dfec4
	static System.Void OnEntityGapDependIDChange_Left(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int32 oldValue, System.Int32 newValue); // 0x071dfff8
	static System.Void OnEntityGapPosChange_Left(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Single oldValue, System.Single newValue); // 0x071e012c
	static System.Void OnEntityGapRotChange_Left(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Single oldValue, System.Single newValue); // 0x071e0260
	static System.Void OnEntityGapShowStateChange_Left(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Boolean oldValue, System.Boolean newValue); // 0x071e0394
	static System.Void OnEntityGapTargetEntityIDChange_Right(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int64 oldValue, System.Int64 newValue); // 0x071e04c8
	static System.Void OnEntityGapTargetIDChange_Right(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int32 oldValue, System.Int32 newValue); // 0x071e05fc
	static System.Void OnEntityGapDependEntityIDChange_Right(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int64 oldValue, System.Int64 newValue); // 0x071e0730
	static System.Void OnEntityGapDependIDChange_Right(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int32 oldValue, System.Int32 newValue); // 0x071e0864
	static System.Void OnEntityGapPosChange_Right(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Single oldValue, System.Single newValue); // 0x071e0998
	static System.Void OnEntityGapRotChange_Right(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Single oldValue, System.Single newValue); // 0x071e0acc
	static System.Void OnEntityGapShowStateChange_Right(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Boolean oldValue, System.Boolean newValue); // 0x071e0c00
	System.Void Cleanup(); // 0x071e0d34
	System.Void OnGoLoaded(); // 0x071e0e08
	System.Void RequestGapPropertyChangeSystem(System.Int64 entityId); // 0x071dfc60
	System.Void OnGapStateChange(); // 0x071e0ed8
	System.Void SetGapMaterialsToBuildMove(WizardGames.AssetPool.AssetPoolHandle moveMat); // 0x071e10e0
	System.Void MoveRecoverMats(); // 0x071e11f8
	System.Void UpdateGPUInstance(); // 0x071e12f4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ConstructionLadderComponent : WizardGames.Soc.Share.Framework.ComponentBase, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 1892811092;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	WizardGames.Soc.Common.Combat.AdsorbCollideConfig[] <adsorbCollideConfigs>k__BackingField; // 0x38
	System.Int32 GetClassHash(); // 0x071e13ec
	System.String GetTypeName(); // 0x071e1454
	System.Int32 get_Id(); // 0x071e14cc
	System.Void .ctor(); // 0x071e1530
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071e15bc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071e166c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071e171c
	WizardGames.Soc.Common.Entity.PartEntity get_parentPartEntity(); // 0x071e1780
	WizardGames.Soc.Common.Combat.AdsorbCollideConfig[] get_adsorbCollideConfigs(); // 0x071e1838
	System.Void set_adsorbCollideConfigs(WizardGames.Soc.Common.Combat.AdsorbCollideConfig[] value); // 0x071e189c
	System.Void OnGoLoaded(); // 0x071e191c
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x071e1984
	System.Void OnSkinGoRemove(); // 0x071e1c68
	System.Void RefreshLadder(); // 0x071e19fc
	System.Void AfterChangeTransform(); // 0x071e1ccc
	System.Void ReturnToPoolBusiness(); // 0x071e1d30
	static System.Void .cctor(); // 0x071e1d90
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ConstructionMoveComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 1680943661;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071e1e14
	System.String GetTypeName(); // 0x071e1e7c
	System.Int32 get_Id(); // 0x071e1ef4
	System.Void .ctor(); // 0x071e1f58
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071e1fe4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071e2094
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071e2144
	static System.Void .cctor(); // 0x071e21a8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ConstructionProduceComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 959450195;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071e2264
	System.String GetTypeName(); // 0x071e22cc
	System.Int32 get_Id(); // 0x071e2344
	System.Void .ctor(); // 0x071e23a8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071e2434
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071e24e4
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071e2594
	System.Int64 get_OutputItemId(); // 0x071e25f8
	System.Int32 get_ProducedCount(); // 0x071e266c
	System.Int32 get_ProduceSum(); // 0x071e26e0
	static System.Void .cctor(); // 0x071e2754
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ConstructionRenameComponent : WizardGames.Soc.Share.Framework.ComponentBase, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler
{
	static System.Int32 CLASS_HASH = 1927206227;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	WizardGames.Soc.Common.Component.SleepingBagComponent sleepingBagComponent; // 0x38
	System.Int32 GetClassHash(); // 0x071e2878
	System.String GetTypeName(); // 0x071e28e0
	System.Int32 get_Id(); // 0x071e2958
	System.Void .ctor(); // 0x071e29bc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071e2a48
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071e2af8
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071e2ba8
	System.String get_ConstructionName(); // 0x071e2c0c
	System.Void OnGoLoaded(); // 0x071e2c80
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x071e2d2c
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x071e2da0
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x071e2f74
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x071e2fe8
	System.Void RenameCheck(); // 0x071e3078
	System.Boolean CanUse(System.Int64 roleId); // 0x071e2e98
	System.Void OpenRenameUIDialog(); // 0x071e317c
	System.Void ClientRename(System.String newName); // 0x071e3338
	static System.Void .cctor(); // 0x071e3508
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ConstructionSkinComponent : WizardGames.Soc.Share.Framework.ComponentBase, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler
{
	static System.Int32 CLASS_HASH = 28;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.UInt64 skinGoAsyncId; // 0x38
	System.String skinGoPath; // 0x40
	UnityEngine.GameObject skinGo; // 0x48
	System.Int32 GetClassHash(); // 0x071e35c4
	System.String GetTypeName(); // 0x071e3628
	System.Int32 get_Id(); // 0x071e36a0
	System.Void .ctor(); // 0x071e3704
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071e3790
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071e3840
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x071e38a4
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x071e3918
	System.Void GetUiBtnListInSkin(System.Collections.Generic.List<System.Int32> retList); // 0x071e3994
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x071e3dd0
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x071e3e44
	WizardGames.Soc.Common.Entity.PartEntity get_parentPartEntity(); // 0x071e3d18
	System.Void OnGoLoaded(); // 0x071e4010
	System.Void Cleanup(); // 0x071e4080
	System.Void ChangeSkinGo(); // 0x071d5c6c
	System.Void LoadSkinGo(); // 0x071e43c0
	System.Void RemoveSkinGo(); // 0x071e40f0
	System.Void OnSkinGoLoaded(UnityEngine.GameObject go); // 0x071e4954
	System.Void ReturnToPoolBusiness(); // 0x071e4c88
	static System.Void .cctor(); // 0x071e4d1c
	System.Void <LoadSkinGo>b__32_0(UnityEngine.GameObject go, System.Object[] objs); // 0x071e4d9c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ConstructionSocketBaseComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 27;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Boolean BLinked; // 0x33
	System.Collections.Generic.HashSet<System.Int64> LinkedConstructionIdList; // 0x38
	System.Collections.Generic.List<BuildingProximity> allProximities; // 0x40
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Construction.SocketRuntimeBase> allSocketDict; // 0x48
	System.Boolean IsLinkedToNeighbors; // 0x50
	static System.UInt32 globalBroadcastProtocol; // 0x10
	System.UInt32 broadcastProtocol; // 0x54
	static System.Collections.Generic.Queue<WizardGames.Soc.Common.Entity.PartEntity> globalBroadcastQueue; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.Common.Construction.SocketRuntimeBase> allSocketList; // 0x58
	System.Int32 GetClassHash(); // 0x071e4e24
	System.String GetTypeName(); // 0x071e4e88
	System.Int32 get_Id(); // 0x071e4f00
	System.Void .ctor(); // 0x071e4f64
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071e4ff0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071e50a0
	System.Int64 get_SocketLinkedInfo(); // 0x071e5104
	System.Int64 get_AdditionBlockInfo(); // 0x071e5178
	System.Void RequestLinkToNeighboursOnClient(); // 0x071e51ec
	System.Boolean HasLinkedToOtherEntity(System.Int64 targetEntityId); // 0x071e623c
	System.Void LinkToEntity(WizardGames.Soc.Common.Entity.PartEntity targetEntity); // 0x071e5a90
	System.Boolean CanConnectWithoutOccupiedCheck(WizardGames.Soc.Common.Construction.SocketRuntimeBase socketDataA, WizardGames.Soc.Common.Construction.SocketRuntimeBase socketDataB); // 0x071e6368
	System.Void CheckAndRemoveLink(System.Int64 targetEntityId); // 0x071e6568
	static System.Void .cctor(); // 0x071e6640
	System.Collections.Generic.List<BuildingProximity> get_AllProximities(); // 0x071e6864
	WizardGames.Soc.Common.Unity.Construction.TemplateGoConfig GetPartGoConfig(); // 0x071e6910
	System.Void RefreshSkinId(); // 0x071d5c00
	System.Void OnGoLoadedBegin(); // 0x071e69bc
	System.Void OnGoLoaded(); // 0x071e6a1c
	System.Void WaitRefreshGrade(); // 0x071e6a80
	System.Void InitSockets(); // 0x071e6b30
	System.Void ResetSocketDic(System.Int32 dicSize); // 0x071e6d5c
	System.Void FindMaleSockets(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget target, System.Collections.Generic.List<WizardGames.Soc.Common.Construction.SocketRuntimeBase> sockets); // 0x071e70a8
	System.ValueTuple<System.Boolean,System.Int32> HasMaleSockets(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget target); // 0x071e7340
	System.Boolean UpdatePlacement(WizardGames.Soc.Common.Component.DeployComponent deployComponent, UnityEngine.Vector3 playerPos, WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target); // 0x071e75c8
	static System.Void OnAdditionBlockInfoChanged(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int64 oldVal, System.Int64 newVal); // 0x071e7df8
	System.Boolean IsOccupied(WizardGames.Soc.Common.Construction.SocketRuntimeBase socketData); // 0x071e7ecc
	System.Boolean IsOccupied(WizardGames.Soc.Common.Construction.SocketRuntimeBase socketData, System.Boolean toHoldingPart); // 0x071e7cf4
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x071e59d8
	System.Int32 get_SocketCounts(); // 0x071e62e4
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Construction.SocketRuntimeBase> get_AllSocketDict(); // 0x071e7f78
	System.Collections.Generic.List<WizardGames.Soc.Common.Construction.SocketRuntimeBase> get_AllSocketList(); // 0x071e7fdc
	System.Void Cleanup(); // 0x071e80a4
	System.Void FreeSockets(); // 0x071e6e8c
	System.Void FreeLinks(); // 0x071e8110
	System.Void InitLinks(); // 0x071e834c
	System.Void ReturnToPoolBusiness(); // 0x071e83ac
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ConsumeItemComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 605458405;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int64 ConsumeId; // 0x38
	System.Int32 deductionAmount; // 0x40
	System.Int32 GetClassHash(); // 0x071e84b4
	System.String GetTypeName(); // 0x071e851c
	System.Int32 get_Id(); // 0x071e8594
	System.Void .ctor(); // 0x071e85f8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071e8684
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071e8734
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071e87e4
	System.Int32 get_Times(); // 0x071e8848
	System.Void RemoteCallTryInteract(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x071e88bc
	System.Void Init(); // 0x071e8a18
	static System.Void .cctor(); // 0x071e8a8c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ContainerLinkComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 626227895;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071e8b48
	System.String GetTypeName(); // 0x071e8bb0
	System.Int32 get_Id(); // 0x071e8c28
	System.Void .ctor(); // 0x071e8c8c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071e8d18
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071e8dc8
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071e8e78
	System.Int64 get_FoundEntityId(); // 0x071e8edc
	static System.Void .cctor(); // 0x071e8f50
	static System.Void OnFoundEntityIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase component, System.Int64 oldValue, System.Int64 newValue); // 0x071e90b0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.CorpseBoxComponent : WizardGames.Soc.Common.Component.AutoSyncBoxComponent
{
	static System.Int32 CLASS_HASH = 2127356657;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071e923c
	System.String GetTypeName(); // 0x071e92a4
	System.Int32 get_Id(); // 0x071e931c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071e9380
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071e9430
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071e94e0
	static System.Object DeserializeCorpseBoxComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071e9544
	System.Void PostInit(); // 0x071e9618
	static System.Void .cctor(); // 0x071e97d0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.CorpseComponent : WizardGames.Soc.Common.Component.BaseCorpseComponent
{
	static System.Int32 CLASS_HASH = 1634281477;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071e9a60
	System.String GetTypeName(); // 0x071e9ac8
	System.Int32 get_Id(); // 0x071e9b40
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071e9ba4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071e9c50
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071e9cfc
	static System.Object DeserializeCorpseComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071e9d60
	System.Void PostInit(); // 0x071e9e34
	static System.Void .cctor(); // 0x071e9f74
}

// Client.Runtime
class WizardGames.Soc.Common.Component.DamageableComponent : WizardGames.Soc.Share.Framework.ComponentBase, WizardGames.Soc.Common.Entity.IHitableEntity
{
	static System.Int32 CLASS_HASH = 29;
	static System.Int32 StaticClassHash; // 0x0
	static System.String TYPE_NAME = "DamageableComponent";
	static System.String[] PropNameArray; // 0x8
	System.Int32 <DefenseTemplateId>k__BackingField; // 0x34
	System.Single[] <BaseProtection>k__BackingField; // 0x38
	System.Single[][] <AreaProtections>k__BackingField; // 0x40
	System.Boolean <ScaleDamageByPart>k__BackingField; // 0x48
	System.Int32 GetClassHash(); // 0x071ea098
	System.String GetTypeName(); // 0x071ea0fc
	System.Int32 get_Id(); // 0x071ea174
	System.Void .ctor(); // 0x071ca120
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071ca260
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071ca3c4
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071ea1d8
	System.Int32 get_CombatTemplateId(); // 0x071ea23c
	System.Void set_CombatTemplateId(System.Int32 value); // 0x071ea2b0
	System.Single get_MaxHp(); // 0x071ea33c
	System.Void set_MaxHp(System.Single value); // 0x071ea3b0
	System.Single get_Hp(); // 0x071ea43c
	System.Void set_Hp(System.Single value); // 0x071ea4b0
	System.Int64 get_LastAttackPlayerId(); // 0x071ea53c
	System.Void PostInit(); // 0x071ea5b0
	System.Int32 get_DefenseTemplateId(); // 0x071eaaa8
	System.Void set_DefenseTemplateId(System.Int32 value); // 0x071eab0c
	System.Single[] get_BaseProtection(); // 0x071eab84
	System.Void set_BaseProtection(System.Single[] value); // 0x071eabe8
	System.Single[][] get_AreaProtections(); // 0x071eac68
	System.Void set_AreaProtections(System.Single[][] value); // 0x071eaccc
	System.Void set_ScaleDamageByPart(System.Boolean value); // 0x071ead4c
	static System.Void .cctor(); // 0x071eadc8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.DayNightAutoSwitchComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 113062494;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071eafec
	System.String GetTypeName(); // 0x071eb054
	System.Int32 get_Id(); // 0x071eb0cc
	System.Void .ctor(); // 0x071eb130
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071eb1bc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071eb26c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071eb31c
	System.Boolean get_Enable(); // 0x071eb380
	System.Void RemoteCallSetEnable(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean enable); // 0x071eb3f4
	static System.Void .cctor(); // 0x071eb57c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.DebrisComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 979712518;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071eb638
	System.String GetTypeName(); // 0x071eb6a0
	System.Int32 get_Id(); // 0x071eb718
	System.Void .ctor(); // 0x071eb77c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071eb808
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071eb8b8
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071eb968
	System.Int64 get_SkinId(); // 0x071eb9cc
	System.Int64 get_TerritoryEntityId(); // 0x071eba40
	System.Int32 get_DestroyTimeTs(); // 0x071ebab4
	System.Void RemoteCallPickup(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x071ebb28
	System.Void RemoteCallRepair(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x071ebc84
	WizardGames.Soc.Common.Entity.TerritoryEntity get_TerritoryEnt(); // 0x071ebde0
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x071ebec0
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x071ec35c
	System.Boolean CheckHitSecneBox(); // 0x071ed1f4
	System.Void CheckToRepair(); // 0x071ec83c
	System.Boolean CheckRepairDebrisPartLegal(System.Int32& errorCode); // 0x071ed5ec
	System.Void OnGoLoaded(); // 0x071ed9d0
	System.Void AfterChangeGoTransform(); // 0x071eda30
	WizardGames.Soc.Common.Entity.StorageDebrisEntity get_parentStorageDebrisEntity(); // 0x071ec2a4
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> GetRepairConsume(); // 0x071ed408
	static System.Void .cctor(); // 0x071edabc
	System.Void <OnUiBtnClicked>b__37_0(); // 0x071edc7c
	System.Void <CheckToRepair>b__39_1(); // 0x071edce4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.DebrisComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.DebrisComponent.<>c <>9; // 0x0
	static System.Action <>9__39_0; // 0x8
	static System.Void .cctor(); // 0x071edd4c
	System.Void .ctor(); // 0x071eddb0
	System.Void <CheckToRepair>b__39_0(); // 0x071ede18
}

// Client.Runtime
class WizardGames.Soc.Common.Component.DecomposeMachineComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 326920871;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	WizardGames.Soc.Common.CustomType.ItemContainerNode container; // 0x38
	System.Boolean lastIsOpen; // 0x40
	System.Int32 GetClassHash(); // 0x071ede78
	System.String GetTypeName(); // 0x071edee0
	System.Int32 get_Id(); // 0x071edf58
	System.Void .ctor(); // 0x071edfbc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071ee048
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071ee0f8
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071ee1a8
	System.Boolean get_IsOpen(); // 0x071ee20c
	System.Int64 get_ItemUId(); // 0x071ee280
	System.Int64 get_StartTime(); // 0x071ee2f4
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x071ee368
	System.Void RemoteCallDecomposeOp(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean open); // 0x071ee540
	static System.Void .cctor(); // 0x071ee6c8
	static System.Void OnIsOpenChange(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Boolean oldValue, System.Boolean newValue); // 0x071ee970
	System.Void PostInit(); // 0x071eec40
	System.Void OnGoLoaded(); // 0x071eedbc
	System.Void PlayAudio(); // 0x071eea38
	System.Void Cleanup(); // 0x071eee2c
	System.Void DoDecomposeOpResponse(System.Int32 opCode); // 0x071eeff8
	System.Void DecomposeAnyUpdate(); // 0x071ef190
	static System.Void DecomposeStartCallback(WizardGames.Soc.Share.Framework.CustomTypeBase comp, System.Int64 oldVal, System.Int64 newVal); // 0x071ef230
}

// Client.Runtime
class WizardGames.Soc.Common.Component.DestroyComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 953133761;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071ef304
	System.String GetTypeName(); // 0x071ef36c
	System.Int32 get_Id(); // 0x071ef3e4
	System.Void .ctor(); // 0x071ef448
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071ef4d4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071ef584
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071ef634
	static System.Void .cctor(); // 0x071ef698
}

// Client.Runtime
class WizardGames.Soc.Common.Component.DigComponent : WizardGames.Soc.Common.Component.StorageComponent
{
	static System.Int32 CLASS_HASH = 792427834;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071ef754
	System.String GetTypeName(); // 0x071ef7bc
	System.Int32 get_Id(); // 0x071ef834
	System.Void .ctor(); // 0x071ef898
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071ef924
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071efa3c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071efaec
	WizardGames.Soc.Common.CustomType.OvenFuel get_FuelInfo(); // 0x071efb50
	System.Boolean get_IsOpen(); // 0x071efc14
	System.Void RemoteCallOperateDig(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean isOpen); // 0x071efc88
	static System.Object DeserializeDigComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x071efe10
	System.Single get_Progress(); // 0x071efee0
	System.Void PostInit(); // 0x071f00a4
	static System.Void .cctor(); // 0x071f016c
	System.Void <PostInit>b__24_0(); // 0x071f02c4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricAndSwitchComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 1113662372;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject skinGo; // 0x40
	UnityEngine.GameObject obj; // 0x48
	UnityEngine.GameObject[] greenLights; // 0x50
	UnityEngine.GameObject[] redLights; // 0x58
	UnityEngine.GameObject[] offLights; // 0x60
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x68
	System.Int32 GetClassHash(); // 0x071f037c
	System.String GetTypeName(); // 0x071f03e4
	System.Int32 get_Id(); // 0x071f045c
	System.Void .ctor(); // 0x071f04c0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071f05f8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071f0754
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071f08b0
	System.Void OnGoLoaded(); // 0x071f0914
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x071f0a30
	System.Void OnSkinGoRemove(); // 0x071f13f4
	System.Void Cleanup(); // 0x071f1454
	System.Void InitInstanceToggleGroup(); // 0x071f0ea4
	System.Void RefreshLights(); // 0x071f10d4
	System.Void FindLights(); // 0x071f0ba8
	System.Void ClearLights(); // 0x071f1554
	static System.Void .cctor(); // 0x071f1640
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricAutoTurretComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 807898949;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	UnityEngine.GameObject skinObj; // 0x48
	UnityEngine.GameObject redLight; // 0x50
	UnityEngine.GameObject greenLight; // 0x58
	UnityEngine.GameObject offLight1; // 0x60
	UnityEngine.GameObject offLight2; // 0x68
	System.Boolean curFlagOpen; // 0x70
	System.Boolean curHasPower; // 0x71
	static System.Boolean isInit; // 0x10
	System.Single lastAngle; // 0x74
	System.Single lastYaw; // 0x78
	System.Int64 flakUpdateTimerId; // 0x80
	System.Int32 MonsterEntityBehaviorTemplateId; // 0x88
	WizardGames.Soc.Common.Data.units.MonsterTurretBehavior TbTurretBehavior; // 0x90
	WizardGames.Soc.Common.Unity.Monster.GeneralConfig GeneralConfig; // 0x98
	UnityEngine.GameObject _rotateYawGo; // 0xa0
	UnityEngine.GameObject _rotatePitchGo; // 0xa8
	UnityEngine.Animator _animator; // 0xb0
	WizardGames.Soc.Common.Construction.AnimSubNodeMeshDealer animDealer; // 0xb8
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0xc0
	System.Single cachedY; // 0xc8
	System.Boolean nowState; // 0xcc
	System.Int32 GetClassHash(); // 0x071f16fc
	System.String GetTypeName(); // 0x071f1764
	System.Int32 get_Id(); // 0x071f17dc
	System.Void .ctor(); // 0x071f1840
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071f1910
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071f1a04
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071f1af8
	System.Int64 get_AutoTurretId(); // 0x071f1b5c
	System.Void RemoteCallSetAutoTurretMode(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 mode); // 0x071f1bd0
	System.Void OnGoLoaded(); // 0x071f1d58
	System.Void UpdateRotation(System.Int64 id); // 0x071f1fcc
	System.Void SwitchInstance(System.Boolean enable); // 0x071f2464
	System.Void InitTransforms(); // 0x071f261c
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x071f2f88
	System.Void Cleanup(); // 0x071f3be0
	System.Void ClearShow(); // 0x071f3c48
	System.Void InitInstanceToggleGroup(); // 0x071f2bb4
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x071f324c
	System.Void OnSkinGoRemove(); // 0x071f3ea4
	static System.Void AutoTurretSwitch(System.Int64 partEntityId); // 0x071f3f20
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x071f4014
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x071f4088
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x071f41dc
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x071f4250
	System.Void SetupRequirement(WizardGames.Soc.Share.Framework.EntityBase entity); // 0x071f4320
	static System.Void .cctor(); // 0x071f4484
}

// Client.Runtime
enum WizardGames.Soc.Common.Component.ElectricAutoTurretComponent.EAutoTurretOperation : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Component.ElectricAutoTurretComponent.EAutoTurretOperation Open = 221;
	static WizardGames.Soc.Common.Component.ElectricAutoTurretComponent.EAutoTurretOperation SwitchOn = 222;
	static WizardGames.Soc.Common.Component.ElectricAutoTurretComponent.EAutoTurretOperation SwitchOff = 223;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricBackupPowerICComponent : WizardGames.Soc.Common.Component.ElectricIntegratedCircuitComponent, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 366106716;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	UnityEngine.GameObject greenLight1; // 0x48
	UnityEngine.GameObject greenLight2; // 0x50
	UnityEngine.GameObject redLight1; // 0x58
	UnityEngine.GameObject redLight2; // 0x60
	UnityEngine.GameObject offLight1; // 0x68
	UnityEngine.GameObject offLight2; // 0x70
	System.Int64 flashTimer; // 0x78
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x80
	System.Int32 GetClassHash(); // 0x071f4634
	System.String GetTypeName(); // 0x071f469c
	System.Int32 get_Id(); // 0x071f4714
	System.Void .ctor(); // 0x071f4778
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071f48c0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071f4a50
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071f4be0
	System.Void OnGoLoaded(); // 0x071f4c44
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x071f4f90
	System.Void OnSkinGoRemove(); // 0x071f5a40
	System.Void Cleanup(); // 0x071f5aa0
	System.Void InitInstanceToggleGroup(); // 0x071f535c
	System.Void OnLightFlagChange(); // 0x071f5830
	System.Void Tick(System.Int64 deltaTime); // 0x071f5c9c
	static System.Void .cctor(); // 0x071f5dd4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricBaseComponent : WizardGames.Soc.Share.Framework.ComponentBase, WizardGames.Soc.Common.Utility.IRequiredComponent
{
	static System.Int32 CLASS_HASH = 854351851;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	static System.Collections.Generic.List<WizardGames.Soc.Common.Component.ElectricBaseComponent> WireToolBuildModeFinishWireModuleLst; // 0x10
	WizardGames.Soc.Common.Component.ConstructionFlagComponent FlagComponent; // 0x38
	System.Int32 GetClassHash(); // 0x071f5e90
	System.String GetTypeName(); // 0x071f5ef8
	System.Int32 get_Id(); // 0x071f5f70
	System.Void .ctor(); // 0x071f5fd4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071f6060
	System.Void InitByArrayDataSet(WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071f6178
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071f6260
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071f6310
	WizardGames.Soc.Common.CustomType.ElectricCBase get_ElectricC(); // 0x071f576c
	System.Void set_ElectricC(WizardGames.Soc.Common.CustomType.ElectricCBase value); // 0x071f6374
	System.Void OnGoLoaded(); // 0x071f6400
	System.Void ClearShow(); // 0x071f6610
	System.Void OnGridWireEntityModify(WizardGames.Soc.Share.Framework.ECustomDictOpType op, System.Int32 key, WizardGames.Soc.Common.CustomType.WireSlotInfo oldVal); // 0x071f6670
	System.Void RefreshSlotConnect(System.Boolean input, System.Int32 index, WizardGames.Soc.Common.CustomType.WireSlotInfo info); // 0x071f67dc
	System.Void RefreshAllSlotConnect(); // 0x071f76c8
	WizardGames.Soc.Common.Electric.IOSlotBase[] get_Inputs(); // 0x071f78b4
	WizardGames.Soc.Common.Electric.IOSlotBase[] get_Outputs(); // 0x071f7960
	System.Boolean TryGetModuleSlot(System.Boolean input, System.Int32 slotId, WizardGames.Soc.Common.Electric.IOSlotBase& slot); // 0x071f7a0c
	System.Boolean TryGetSlot(System.Boolean input, System.Int32 slotId, WizardGames.Soc.Common.Electric.IOSlotBase& slot); // 0x071f7ab4
	WizardGames.Soc.Common.CustomType.PartWireConnection get_PartWireConnection(); // 0x071f7840
	System.Boolean IsRootEntity(); // 0x071f7b64
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x071f4ed8
	System.Void Init(); // 0x071f7bd8
	System.Void PostInit(); // 0x071f7e30
	System.Void Cleanup(); // 0x071f5b9c
	System.Void SetupRequirement(WizardGames.Soc.Share.Framework.EntityBase entity); // 0x071f7ea4
	static System.Void .cctor(); // 0x071f7f60
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricBatteryComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 33;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	UnityEngine.GameObject partical; // 0x48
	Effect.EffectItemHandle<Effect.EffectItem> effectItemHandle; // 0x50
	System.Int64 templateId; // 0x60
	System.Int32 GetClassHash(); // 0x071f8074
	System.String GetTypeName(); // 0x071f80d8
	System.Int32 get_Id(); // 0x071f8150
	System.Void .ctor(); // 0x071f81b4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071f823c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071f82e8
	System.Void OnGoLoaded(); // 0x071f834c
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x071f8414
	System.Void OnSkinGoRemove(); // 0x071f8708
	System.Void Cleanup(); // 0x071f8768
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x071f8634
	System.Void PlayFx(System.Boolean isOpen); // 0x071f882c
	System.Void ReturnToPoolBusiness(); // 0x071f8d00
	static System.Void .cctor(); // 0x071f8d88
	System.Void <PlayFx>b__23_0(System.Boolean success, Effect.EffectItem effectItem, System.Object o); // 0x071f8e40
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricBlockerComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 893871385;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	UnityEngine.GameObject greenLight1; // 0x48
	UnityEngine.GameObject greenLight2; // 0x50
	UnityEngine.GameObject redLight1; // 0x58
	UnityEngine.GameObject redLight2; // 0x60
	UnityEngine.GameObject offLight1; // 0x68
	UnityEngine.GameObject offLight2; // 0x70
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x78
	System.Int32 GetClassHash(); // 0x071f8f24
	System.String GetTypeName(); // 0x071f8f8c
	System.Int32 get_Id(); // 0x071f9004
	System.Void .ctor(); // 0x071f9068
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071f9128
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071f920c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071f92f0
	System.Void OnGoLoaded(); // 0x071f9354
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x071f941c
	System.Void OnSkinGoRemove(); // 0x071f9d74
	System.Void Cleanup(); // 0x071f9dd4
	System.Void InitInstanceToggleGroup(); // 0x071f97e4
	System.Void OnLightFlagChange(); // 0x071f9bf4
	static System.Void .cctor(); // 0x071f9eb0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricBranchComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 423770098;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	UnityEngine.GameObject greenLight1; // 0x48
	UnityEngine.GameObject greenLight2; // 0x50
	UnityEngine.GameObject offLight1; // 0x58
	UnityEngine.GameObject offLight2; // 0x60
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x68
	System.Int32 GetClassHash(); // 0x071f9f6c
	System.String GetTypeName(); // 0x071f9fd4
	System.Int32 get_Id(); // 0x071fa04c
	System.Void .ctor(); // 0x071fa0b0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071fa170
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071fa254
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071fa338
	System.Void RemoteCallRequestSetBranchOffPower(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 power); // 0x071fa39c
	System.Void OnGoLoaded(); // 0x071fa524
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x071fa5ec
	System.Void OnSkinGoRemove(); // 0x071fad80
	System.Void ClearShow(); // 0x071fade0
	System.Void InitInstanceToggleGroup(); // 0x071fa8dc
	System.Void OnLightFlagChange(); // 0x071fac3c
	static System.Void .cctor(); // 0x071faebc
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricBranchSmartComponent : WizardGames.Soc.Common.Component.ElectricBranchComponent
{
	static System.Int32 CLASS_HASH = 1489920319;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x071fafac
	System.String GetTypeName(); // 0x071fb014
	System.Int32 get_Id(); // 0x071fb08c
	System.Void .ctor(); // 0x071fb0f0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071fb178
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071fb224
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071fb2d0
	static System.Void .cctor(); // 0x071fb334
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricButtonComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 1805185848;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	UnityEngine.Transform buttonTransform; // 0x48
	static System.Boolean isInit; // 0x10
	WizardGames.Soc.Common.Unity.Construction.LerpBetweenPointsBool lerpBool; // 0x50
	UnityEngine.Vector3 offsetVector3; // 0x58
	System.Int32 GetClassHash(); // 0x071fb424
	System.String GetTypeName(); // 0x071fb48c
	System.Int32 get_Id(); // 0x071fb504
	System.Void .ctor(); // 0x071fb568
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071fb600
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071fb6bc
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071fb778
	System.Void RemoteCallPushButton(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x071fb7dc
	System.Void OnGoLoaded(); // 0x071fb938
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x071fba00
	System.Void OnSkinGoRemove(); // 0x071fc05c
	System.Void ClearShow(); // 0x071fc0bc
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x071fbe84
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x071fc1a0
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x071fc214
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x071fc2f0
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x071fc364
	static System.Void .cctor(); // 0x071fc43c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricButtonComponent.<>c__DisplayClass22_0 : System.Object
{
	WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer gpuContainer; // 0x10
	System.Void .ctor(); // 0x071fbe1c
	System.Void <OnSkinGoLoaded>b__0(System.Boolean status); // 0x071fc4f8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricChristmasLightComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler
{
	static System.Int32 CLASS_HASH = 64936650;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	System.Collections.Generic.List<System.UInt64> asyncIdList; // 0x48
	WizardGames.Soc.Common.Component.ElectricChristmasLightComponent.LightMode curLightMode; // 0x50
	System.Single bulbSpacing; // 0x54
	System.Single wireThickness; // 0x58
	UnityEngine.LineRenderer lineRenderer; // 0x60
	System.Collections.Generic.List<Electric.BaseBulb> bulbs; // 0x68
	System.Int32 GetClassHash(); // 0x071fc5a0
	System.String GetTypeName(); // 0x071fc608
	System.Int32 get_Id(); // 0x071fc680
	System.Void .ctor(); // 0x071fc6e4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071fc824
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071fc9f0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071fcb54
	System.Int32 get_FlashMode(); // 0x071fcbb8
	WizardGames.Soc.Common.CustomType.ChristmasLightsCustom get_ChristmasPointLst(); // 0x071fcc2c
	System.Void RemoteCallAddPoint(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 itemUid, System.Single pointX, System.Single pointY, System.Single pointZ, System.Single normalX, System.Single normalY, System.Single normalZ); // 0x071fccf0
	System.Void RemoteCallSetFlashMode(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 mode); // 0x071fcee4
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.PointWithNormal> get_Points(); // 0x071fd06c
	System.String get_bulbPrefabPath(); // 0x071fd0e8
	System.Void OnGoLoaded(); // 0x071fd1d0
	static System.Void .cctor(); // 0x071fd648
	System.Void Cleanup(); // 0x071fd878
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x071fd57c
	System.Void SetPointsChangeListener(); // 0x071fd418
	System.Void PointsChangeCallback(WizardGames.Soc.Share.Framework.AbstractCustomList.ECustomListOpType<WizardGames.Soc.Common.CustomType.PointWithNormal> customListOpType, System.Int32 index, WizardGames.Soc.Common.CustomType.PointWithNormal value); // 0x071fe6b4
	UnityEngine.Vector3 PartLocalToWorldPoint(UnityEngine.Vector3 localPos); // 0x071fe748
	UnityEngine.Vector3 PartLocalToWorldDirection(UnityEngine.Vector3 localDir); // 0x071fe888
	System.Void RegenerateLightsAsync(); // 0x071fdb8c
	System.Void GetBulbObjectAsync(System.Action<UnityEngine.GameObject,System.Object[]> onComplete, System.Object[] parameters); // 0x071fe9c8
	static System.Void OnFlashModeChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Int32 oldValue, System.Int32 grade); // 0x071fed54
	System.Void OnModeChange(); // 0x071fe63c
	System.Void UpdateBulbs(); // 0x071fee28
	System.Void SetBulbsOn(System.Boolean wantsOn); // 0x071fefa0
	System.Void ClearAllBulb(); // 0x071fd988
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x071ff12c
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x071ff1a0
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x071ff23c
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x071ff2b0
	System.Void <RegenerateLightsAsync>b__49_0(UnityEngine.GameObject go, System.Object[] parameters); // 0x071ff434
}

// Client.Runtime
enum WizardGames.Soc.Common.Component.ElectricChristmasLightComponent.LightMode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Component.ElectricChristmasLightComponent.LightMode ON = 156;
	static WizardGames.Soc.Common.Component.ElectricChristmasLightComponent.LightMode FLASHING = 157;
	static WizardGames.Soc.Common.Component.ElectricChristmasLightComponent.LightMode CHASING = 158;
	static WizardGames.Soc.Common.Component.ElectricChristmasLightComponent.LightMode FADE = 159;
	static WizardGames.Soc.Common.Component.ElectricChristmasLightComponent.LightMode SLOWGLOW = 160;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricChristmasLightComponent.<>c__DisplayClass51_0 : System.Object
{
	WizardGames.Soc.Common.Component.ElectricChristmasLightComponent <>4__this; // 0x10
	UnityEngine.GameObject bulb; // 0x18
	System.Action<UnityEngine.GameObject,System.Object[]> onComplete; // 0x20
	System.UInt64 asyncId; // 0x28
	System.Void .ctor(); // 0x071fecec
	System.Void <GetBulbObjectAsync>b__0(UnityEngine.GameObject go, System.Object[] objs); // 0x071ff7b8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricCombinerComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 1660034391;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	UnityEngine.GameObject greenLight1; // 0x48
	UnityEngine.GameObject greenLight2; // 0x50
	UnityEngine.GameObject redLight1; // 0x58
	UnityEngine.GameObject redLight2; // 0x60
	UnityEngine.GameObject offLight1; // 0x68
	UnityEngine.GameObject offLight2; // 0x70
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x78
	System.Int32 GetClassHash(); // 0x071ff9d8
	System.String GetTypeName(); // 0x071ffa40
	System.Int32 get_Id(); // 0x071ffab8
	System.Void .ctor(); // 0x071ffb1c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071ffbdc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071ffcc0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x071ffda4
	System.Void OnGoLoaded(); // 0x071ffe08
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x071fff18
	System.Void OnSkinGoRemove(); // 0x0720088c
	System.Void Cleanup(); // 0x072008ec
	System.Void InitInstanceToggleGroup(); // 0x072002e4
	System.Void OnLightFlagChange(); // 0x072006f4
	static System.Void .cctor(); // 0x072009cc
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricCounterComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler
{
	static System.Int32 CLASS_HASH = 2136811485;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Boolean counterMode; // 0x40
	System.Int32 counterTarget; // 0x44
	System.Int32 PowerOrCounter; // 0x48
	System.Boolean inited; // 0x4c
	UnityEngine.GameObject obj; // 0x50
	UnityEngine.GameObject uiRoot; // 0x58
	FairyGUI.UIPanel uiPanel; // 0x60
	FairyGUI.GTextField textNum; // 0x68
	System.Int32 GetClassHash(); // 0x07200a88
	System.String GetTypeName(); // 0x07200af0
	System.Int32 get_Id(); // 0x07200b68
	System.Void .ctor(); // 0x07200bcc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07200c54
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07200d00
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07200dac
	System.Void RemoteCallSetMode(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean counterMode); // 0x07200e10
	System.Void RemoteCallSetCounterTarget(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 value); // 0x07200f98
	static System.Void .cctor(); // 0x07201120
	System.Void OnGoLoaded(); // 0x072012b4
	System.Void ClearShow(); // 0x0720186c
	System.Void InitUIComponent(); // 0x0720141c
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x07201600
	static System.Void OnNumberChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Int32 oldVal, System.Int32 newVal); // 0x07201930
	System.Void ChangeState(); // 0x07201730
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x07201a6c
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x07201ae0
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x07201b54
	System.Void ShowElectricity(); // 0x07201bc8
	System.Void SetCounterMode(System.Boolean isOpen); // 0x07201c30
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x07201d78
	System.Void OpenCountElectricity(); // 0x07201e24
	System.Void OnCounterConfirmCallBack(System.Int32 num); // 0x0720223c
	System.Void UpdateRaycastTarget(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x07202490
	System.Void OnHudRootCaptureTouchExcludeJoyStick(UnityEngine.Vector2 screen); // 0x072025cc
	System.Void OnCancel(); // 0x072022d0
}

// Client.Runtime
enum WizardGames.Soc.Common.Component.ElectricCounterComponent.ECounterOperation : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Component.ElectricCounterComponent.ECounterOperation ShowElectricity = 251;
	static WizardGames.Soc.Common.Component.ElectricCounterComponent.ECounterOperation CountElectricity = 252;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricDoorControllerComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 1626931892;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	UnityEngine.GameObject greenLightPower; // 0x48
	UnityEngine.GameObject redLightPower; // 0x50
	UnityEngine.GameObject offLightPower; // 0x58
	UnityEngine.GameObject greenLightBlock; // 0x60
	UnityEngine.GameObject redLightBlock; // 0x68
	UnityEngine.GameObject offLightBlock; // 0x70
	System.Boolean hasPower; // 0x78
	System.Boolean doorHasMatch; // 0x79
	System.Boolean doorHasOpen; // 0x7a
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x80
	System.Int32 GetClassHash(); // 0x0720264c
	System.String GetTypeName(); // 0x072026b4
	System.Int32 get_Id(); // 0x0720272c
	System.Void .ctor(); // 0x07202790
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07202850
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07202934
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07202a18
	System.Void RemoteCallDoorControllerMatch(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x07202a7c
	System.Boolean get_DoorHasMatch(); // 0x07202bd8
	System.Void OnGoLoaded(); // 0x07202c3c
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x07202d04
	System.Void OnSkinGoRemove(); // 0x072036cc
	System.Void InitInstanceToggleGroup(); // 0x072031f8
	System.Void Cleanup(); // 0x0720372c
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x07203608
	System.Void DoorStateChange(System.Int64 partId); // 0x07203ae0
	System.Void RefreshLight(); // 0x072038e0
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x07203c3c
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x07203cb0
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x07203d64
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x07203dd8
	WizardGames.Soc.Common.CustomType.ElectricCDoorController get_electricCDoorController(); // 0x07203b88
	static System.Void .cctor(); // 0x07203e6c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricElevatorBaseComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 1728728570;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.Transform shaftTopTransform; // 0x40
	UnityEngine.Transform shaftTopCollider; // 0x48
	UnityEngine.Transform shaftTopObj; // 0x50
	UnityEngine.Transform cableLift; // 0x58
	UnityEngine.Transform liftSpawnTransform; // 0x60
	UnityEngine.Vector3 liftLocalPos; // 0x68
	System.Single initLocalPosY; // 0x74
	System.Single moveTime; // 0x78
	System.Int64 tickTimerId; // 0x80
	System.String ElevatorMaleName; // 0x88
	System.String ElevatorFemaleName; // 0x90
	System.Single LiftSpeedPerMetre; // 0x98
	WizardGames.Soc.Common.Component.ConstructionSocketBaseComponent SocketBaseComponent; // 0xa0
	System.Int32 GetClassHash(); // 0x07203f28
	System.String GetTypeName(); // 0x07203f90
	System.Int32 get_Id(); // 0x07204008
	System.Void .ctor(); // 0x0720406c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07204148
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07204248
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07204348
	System.Int32 get_Floor(); // 0x072043ac
	System.Int64 get_MoveStartTime(); // 0x07204420
	System.Int64 get_MoveEndTime(); // 0x07204494
	System.Single get_LiftStartPosY(); // 0x07204508
	System.Single get_LiftEndPosY(); // 0x0720457c
	System.Int64 get_LiftEntityId(); // 0x072045f0
	System.Int32 get_CurFloor(); // 0x07204664
	System.Single get_floorHeight(); // 0x072046d8
	System.Void OnGoLoaded(); // 0x07204740
	System.Void Cleanup(); // 0x07204874
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x07204968
	System.Void OnSkinGoRemove(); // 0x07204fa8
	System.Void OnFlagChangeCallback(System.Int32 oldFlag, System.Int32 newFlag); // 0x07205008
	System.Void RefreshLiftState(System.Boolean isTop); // 0x072050a0
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag, System.Boolean isInit); // 0x072053e4
	System.Void UpdateLift(System.Boolean moveEnd); // 0x072056b8
	System.Void Tick(System.Int64 id); // 0x07205808
	WizardGames.Soc.Common.CustomType.ElectricCElevator get_unitElevator(); // 0x07205890
	System.Boolean get_isTop(); // 0x07204f34
	static System.Void .cctor(); // 0x07205944
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricElevatorComponent : WizardGames.Soc.Common.Component.ElectricElevatorBaseComponent, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler
{
	static System.Int32 CLASS_HASH = 925997071;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Single originLiftScale; // 0xa8
	System.Single targetScale; // 0xac
	WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer gpuInstContainer; // 0xb0
	WizardGames.Soc.SocClient.GpuInstance.GpuInstObject liftCableGpuObj; // 0xb8
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0xc0
	System.Int32 GetClassHash(); // 0x07205ba0
	System.String GetTypeName(); // 0x07205c08
	System.Int32 get_Id(); // 0x07205c80
	System.Void .ctor(); // 0x07205ce4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07205da4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07205e88
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07205f6c
	System.Void RemoteCallRaiseLowerElevator(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 dir, System.Boolean goTopBottom); // 0x07205fd0
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x07206164
	System.Void InitInstanceToggleGroup(); // 0x07206438
	System.Void UpdateCableLiftGpuInst(); // 0x072065e4
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag, System.Boolean isInit); // 0x072066cc
	System.Void RefreshLiftState(System.Boolean isTop); // 0x07206994
	System.Void UpdateCable(UnityEngine.Vector3 curPos); // 0x07206af4
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x07206c5c
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x07206cd0
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x07206d44
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x07206db8
	static System.Void .cctor(); // 0x07206e2c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricFuelGeneratorComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent
{
	static System.Int32 CLASS_HASH = 1660015009;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	System.Int32 GetClassHash(); // 0x07207088
	System.String GetTypeName(); // 0x072070f0
	System.Int32 get_Id(); // 0x07207168
	System.Void .ctor(); // 0x072071cc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07207254
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07207300
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072073ac
	System.Void OnGoLoaded(); // 0x07207410
	System.Void ClearShow(); // 0x07207840
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x0720753c
	static System.Void .cctor(); // 0x0720793c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricHeaterComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Construction.IChangeTransform, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 1822396795;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	UnityEngine.Transform lod0; // 0x48
	UnityEngine.Transform lod1; // 0x50
	UnityEngine.MeshRenderer heaterRenderer0; // 0x58
	UnityEngine.MeshRenderer heaterRenderer1; // 0x60
	System.Single targetIntensity; // 0x68
	static UnityEngine.Color targetEmissionColor; // 0x10
	System.Single maxIntensity; // 0x6c
	System.Single intensityPerSecond; // 0x70
	System.Single curIntensity; // 0x74
	static System.Int32 EmissionColor; // 0x20
	static UnityEngine.MaterialPropertyBlock block; // 0x28
	UnityEngine.Transform effectTransform; // 0x78
	WizardGames.Soc.SocClient.Construction.ConstructionEffectPlay effectPlayer; // 0x80
	WizardGames.Soc.Common.Component.ConstructionFlagComponent flagComp; // 0x88
	System.Int64 updateTimer; // 0x90
	System.Int32 intervalTime; // 0x98
	WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer gpuInstContainer; // 0xa0
	System.Int32 GetClassHash(); // 0x072079f8
	System.String GetTypeName(); // 0x07207a60
	System.Int32 get_Id(); // 0x07207ad8
	System.Void .ctor(); // 0x07207b3c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07207bd4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07207c90
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07207d4c
	System.Single get_duration(); // 0x07207db0
	UnityEngine.Color get_curEmissionColor(); // 0x07207ea0
	System.Void OnGoLoaded(); // 0x07207f44
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x07208268
	System.Void OnSkinGoRemove(); // 0x07208f50
	System.Void SetHeaterRenderer(); // 0x07208c9c
	System.Void Cleanup(); // 0x07208fb0
	System.Void OnFlagChangeCallback(System.Int32 oldFlag, System.Int32 newFlag); // 0x0720917c
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag, System.Boolean isInit); // 0x07208754
	System.Void Tick(System.Int64 id); // 0x07209208
	System.Void OnTransformChanged(); // 0x072093e0
	static System.Void .cctor(); // 0x07209458
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricIgniterComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 190374807;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	UnityEngine.Transform effectTransform; // 0x48
	WizardGames.Soc.SocClient.Construction.ConstructionEffectPlay effectPlayer; // 0x50
	WizardGames.Soc.Common.Entity.PartEntity partEntity; // 0x58
	WizardGames.Soc.Common.Component.ConstructionFlagComponent flagComp; // 0x60
	System.Int32 GetClassHash(); // 0x07209558
	System.String GetTypeName(); // 0x072095c0
	System.Int32 get_Id(); // 0x07209638
	System.Void .ctor(); // 0x0720969c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07209724
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072097d0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0720987c
	System.Void OnGoLoaded(); // 0x072098e0
	System.Void Cleanup(); // 0x07209a0c
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x07209b14
	System.Void OnSkinGoRemove(); // 0x07209f08
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x07209f68
	static System.Void .cctor(); // 0x0720a0fc
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricIntegratedCircuitComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent
{
	static System.Int32 CLASS_HASH = 68099972;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x0720a1b8
	System.String GetTypeName(); // 0x0720a220
	System.Int32 get_Id(); // 0x0720a298
	System.Void .ctor(); // 0x071f4838
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x071f49a4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x071f4b34
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0720a2fc
	System.Void OnGoLoaded(); // 0x071f4d50
	System.Void ClearShow(); // 0x0720a360
	static System.Void .cctor(); // 0x0720a3c4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricLaserDetectorComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Construction.IChangeTransform, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 766515277;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	System.Boolean powerd; // 0x48
	UnityEngine.GameObject lightOn; // 0x50
	UnityEngine.GameObject lightOff; // 0x58
	Effect.EffectItemHandle<Effect.EffectItem> effectItemHandle; // 0x60
	UnityEngine.LineRenderer[] lineRenderers; // 0x70
	Effect.EffectItemHandle<Effect.EffectItem> effectRedPointItemHandle; // 0x78
	UnityEngine.Transform fXsocket01; // 0x88
	System.Int32[] constructionFX; // 0x90
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x98
	static System.Int32 fxRedPoint; // 0x10
	WizardGames.Soc.Common.Component.ConstructionFlagComponent flagComp; // 0xa0
	WizardGames.Soc.Common.CustomType.ElectricCLaserDetector laserDetector; // 0xa8
	System.Int32 GetClassHash(); // 0x0720a480
	System.String GetTypeName(); // 0x0720a4e8
	System.Int32 get_Id(); // 0x0720a560
	System.Void .ctor(); // 0x0720a5c4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0720a684
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0720a768
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0720a84c
	System.Single get_DetectLength(); // 0x0720a8b0
	System.Void OnGoLoaded(); // 0x0720a924
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x0720a9ec
	System.Boolean CanShowClosedLaserEffect(); // 0x0720b4ec
	System.Void OnSkinGoRemove(); // 0x0720b578
	static System.Void .cctor(); // 0x0720b5d8
	System.Void InitInstanceToggleGroup(); // 0x0720b020
	System.Void Cleanup(); // 0x0720b77c
	static System.Void OnDetectLightChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Single oldValue, System.Single grade); // 0x0720b92c
	System.Void OnDistanceChange(); // 0x0720ba0c
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x0720b41c
	System.Void PlayFx(System.Boolean isOpen); // 0x0720b884
	System.Void PlayLaserFx(System.Boolean isOpen); // 0x0720bfb0
	System.Void PlayerRedPointFx(System.Boolean isOpen); // 0x0720bc90
	System.Void ChangeLightMaterial(System.Boolean isOn); // 0x0720b2d0
	System.Void OnTransformChanged(); // 0x0720c2bc
	System.Void <PlayLaserFx>b__41_0(System.Boolean success, Effect.EffectItem effectItem, System.Object o); // 0x0720c31c
	System.Void <PlayerRedPointFx>b__42_0(System.Boolean success, Effect.EffectItem effectItem, System.Object o); // 0x0720c400
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricLiveSensorComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 1672682423;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	WizardGames.Soc.Common.Component.ConstructionFlagComponent flagComp; // 0x40
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x48
	WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer gpuInstContainer; // 0x50
	UnityEngine.GameObject lightOn; // 0x58
	UnityEngine.GameObject lightOff; // 0x60
	WizardGames.Soc.Common.CustomType.ElectricCLiveSensor liveSensorUnit; // 0x68
	UnityEngine.GameObject obj; // 0x70
	System.Boolean includeAuthorizer; // 0x78
	UnityEngine.Vector3 objPos; // 0x7c
	System.Int32 GetClassHash(); // 0x0720c4e4
	System.String GetTypeName(); // 0x0720c54c
	System.Int32 get_Id(); // 0x0720c5c4
	System.Void .ctor(); // 0x0720c628
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0720c6e8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0720c7cc
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0720c8b0
	System.Void RemoteCallChangeAuthorizerState(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean include); // 0x0720c914
	System.Void OnGoLoaded(); // 0x0720ca9c
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x0720cc64
	System.Void OnSkinGoRemove(); // 0x0720d188
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x0720d0b0
	System.Void ChangeLightMaterial(System.Boolean isOn); // 0x0720d1e8
	System.Void ChangeSensorDetect(System.Boolean isIncludeAuthorizer); // 0x0720d2e4
	System.Void Cleanup(); // 0x0720d478
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x0720d564
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x0720d5d8
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x0720d7b8
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x0720d82c
	static System.Void .cctor(); // 0x0720d8d4
}

// Client.Runtime
enum WizardGames.Soc.Common.Component.ElectricLiveSensorComponent.EOperation : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Component.ElectricLiveSensorComponent.EOperation IncludeAuthorizer = 154;
	static WizardGames.Soc.Common.Component.ElectricLiveSensorComponent.EOperation ExcludeAuthorizer = 155;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricLoadComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent
{
	static System.Int32 CLASS_HASH = 2080795085;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x0720d990
	System.String GetTypeName(); // 0x0720d9f8
	System.Int32 get_Id(); // 0x0720da70
	System.Void .ctor(); // 0x0720dad4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0720db5c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0720dc08
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0720dcb4
	static System.Void .cctor(); // 0x0720dd18
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricMemoryCellComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 1033102979;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	UnityEngine.GameObject greenLight1; // 0x48
	UnityEngine.GameObject greenLight2; // 0x50
	UnityEngine.GameObject redLight1; // 0x58
	UnityEngine.GameObject redLight2; // 0x60
	UnityEngine.GameObject offLight1; // 0x68
	UnityEngine.GameObject offLight2; // 0x70
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x78
	System.Int32 GetClassHash(); // 0x0720ddd4
	System.String GetTypeName(); // 0x0720de3c
	System.Int32 get_Id(); // 0x0720deb4
	System.Void .ctor(); // 0x0720df18
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0720dfd8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0720e0bc
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0720e1a0
	System.Void OnGoLoaded(); // 0x0720e204
	System.Void Cleanup(); // 0x0720e2cc
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x0720e3a8
	System.Void OnSkinGoRemove(); // 0x0720ece0
	System.Void InitInstanceToggleGroup(); // 0x0720e770
	System.Void OnLightFlagChange(); // 0x0720eb80
	static System.Void .cctor(); // 0x0720ed40
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricMultiBranchComponent : WizardGames.Soc.Common.Component.ElectricIntegratedCircuitComponent, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 381529943;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	UnityEngine.GameObject greenLight1; // 0x48
	UnityEngine.GameObject greenLight2; // 0x50
	UnityEngine.GameObject redLight1; // 0x58
	UnityEngine.GameObject redLight2; // 0x60
	UnityEngine.GameObject offLight1; // 0x68
	UnityEngine.GameObject offLight2; // 0x70
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x78
	System.Int32 GetClassHash(); // 0x0720edfc
	System.String GetTypeName(); // 0x0720ee64
	System.Int32 get_Id(); // 0x0720eedc
	System.Void .ctor(); // 0x0720ef40
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0720f000
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0720f0e4
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0720f1c8
	System.Void OnGoLoaded(); // 0x0720f22c
	System.Void Cleanup(); // 0x0720f2f4
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x0720f3d4
	System.Void OnSkinGoRemove(); // 0x0720fcec
	System.Void InitInstanceToggleGroup(); // 0x0720f7a0
	System.Void OnLightFlagChange(); // 0x0720fbb0
	static System.Void .cctor(); // 0x0720fd4c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricMultiPortCombinerComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 1379789398;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	UnityEngine.GameObject greenLight1; // 0x48
	UnityEngine.GameObject greenLight2; // 0x50
	UnityEngine.GameObject redLight1; // 0x58
	UnityEngine.GameObject redLight2; // 0x60
	UnityEngine.GameObject offLight1; // 0x68
	UnityEngine.GameObject offLight2; // 0x70
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x78
	System.Int32 GetClassHash(); // 0x0720fe08
	System.String GetTypeName(); // 0x0720fe70
	System.Int32 get_Id(); // 0x0720fee8
	System.Void .ctor(); // 0x0720ff4c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0721000c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072100f0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072101d4
	System.Void OnGoLoaded(); // 0x07210238
	System.Void Cleanup(); // 0x07210300
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x072103e0
	System.Void OnSkinGoRemove(); // 0x07210dec
	System.Void InitInstanceToggleGroup(); // 0x072107ac
	System.Void OnLightFlagChange(); // 0x07210bbc
	static System.Void .cctor(); // 0x07210e4c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricOrSwitchComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 1588496088;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	UnityEngine.GameObject greenLightNode; // 0x48
	UnityEngine.GameObject redLightNode; // 0x50
	UnityEngine.GameObject offNode; // 0x58
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x60
	System.Int32 GetClassHash(); // 0x07210f08
	System.String GetTypeName(); // 0x07210f70
	System.Int32 get_Id(); // 0x07210fe8
	System.Void .ctor(); // 0x0721104c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0721110c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072111f0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072112d4
	System.Void OnGoLoaded(); // 0x07211338
	System.Void Cleanup(); // 0x072113c8
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x07211490
	System.Void OnSkinGoRemove(); // 0x07211e24
	System.Void InitInstanceToggleGroup(); // 0x07211750
	System.Void HideAllChildLight(UnityEngine.Transform lightParent); // 0x07211e84
	System.Void HideAllLight(); // 0x07211f7c
	System.Void LightUpLightByIndex(UnityEngine.GameObject lightParent, System.Int32 index); // 0x07212030
	System.Void OnLightFlagChange(); // 0x07211c9c
	static System.Void .cctor(); // 0x07212138
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricOvenComponent : WizardGames.Soc.Common.Component.OvenComponent
{
	static System.Int32 CLASS_HASH = 464410683;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x072121f4
	System.String GetTypeName(); // 0x0721225c
	System.Int32 get_Id(); // 0x072122d4
	System.Void .ctor(); // 0x07212338
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072123c4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07212474
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07212524
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x07212588
	static System.Void .cctor(); // 0x07212824
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricPressurePadComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 1851236662;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	System.Int32 GetClassHash(); // 0x072128e0
	System.String GetTypeName(); // 0x07212948
	System.Int32 get_Id(); // 0x072129c0
	System.Void .ctor(); // 0x07212a24
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07212aac
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07212b58
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07212c04
	System.Void OnGoLoaded(); // 0x07212c68
	System.Void Cleanup(); // 0x07212d30
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x07212d94
	System.Void OnSkinGoRemove(); // 0x07212f94
	System.Void OnFlagChangeCallback(System.Int32 oldFlag, System.Int32 newFlag); // 0x07212ff4
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag, System.Boolean isInit); // 0x07212eb4
	System.Void PlayAudio(System.Boolean isOn); // 0x07213080
	static System.Void .cctor(); // 0x072132b4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricRandSwitchComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 1113588167;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	UnityEngine.GameObject greenLight1; // 0x48
	UnityEngine.GameObject greenLight2; // 0x50
	UnityEngine.GameObject redLight1; // 0x58
	UnityEngine.GameObject redLight2; // 0x60
	UnityEngine.GameObject offLight1; // 0x68
	UnityEngine.GameObject offLight2; // 0x70
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x78
	System.Int32 GetClassHash(); // 0x07213370
	System.String GetTypeName(); // 0x072133d8
	System.Int32 get_Id(); // 0x07213450
	System.Void .ctor(); // 0x072134b4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07213574
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07213658
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0721373c
	System.Void OnGoLoaded(); // 0x072137a0
	System.Void ClearShow(); // 0x07213868
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x07213944
	System.Void OnSkinGoRemove(); // 0x0721425c
	System.Void InitInstanceToggleGroup(); // 0x07213d0c
	System.Void OnLightFlagChange(); // 0x0721411c
	static System.Void .cctor(); // 0x072142bc
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricSearchLightComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 83401556;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	UnityEngine.Transform sentryYaw; // 0x48
	UnityEngine.Transform sentryPitchBase; // 0x50
	UnityEngine.Transform sentryPitch; // 0x58
	UnityEngine.Transform fxPointTransform; // 0x60
	Effect.EffectItemHandle<Effect.FollowEffect> effectItemHandle; // 0x68
	WizardGames.Soc.SocClient.ClientLight.LightItem lightItem; // 0x78
	System.Boolean hasPower; // 0x80
	System.Boolean isMoveAudio; // 0x81
	System.Boolean isSwitchAudio; // 0x82
	System.Int64 rotUpdateTimer; // 0x88
	System.Int32 intervalTime; // 0x90
	System.Int32 GetClassHash(); // 0x07214378
	System.String GetTypeName(); // 0x072143e0
	System.Int32 get_Id(); // 0x07214458
	System.Void .ctor(); // 0x072144bc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0721454c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07214600
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072146b4
	System.Single get_Yaw(); // 0x07214718
	System.Single get_Pitch(); // 0x0721478c
	System.UInt64 get_BindRoleId(); // 0x07214800
	System.Void RemoteCallSwitchRotate(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean isStart); // 0x07214874
	System.Void OnGoLoaded(); // 0x072149fc
	System.Void Cleanup(); // 0x07214a8c
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x07215044
	System.Void OnSkinGoRemove(); // 0x07215dd0
	System.Void OnFlagChangeCallback(System.Int32 oldFlag, System.Int32 newFlag); // 0x07215e30
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag, System.Boolean isInit); // 0x072154c8
	System.Void PlayFx(System.Boolean isOpen); // 0x07215ebc
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x0721666c
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x072166e0
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x07216ae0
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x07216b54
	System.Void InitRotation(); // 0x07214c7c
	System.Void RefreshLightRotation(System.Int64 id); // 0x07216c54
	System.Void Tick(System.Boolean isInit); // 0x07215938
	System.Void PlayMoveAudio(System.Boolean isMove); // 0x07214de8
	System.Void PlaySwitchAudio(System.Boolean inUse); // 0x072162d4
	static System.Single get_bindDistance(); // 0x0721698c
	System.Boolean get_HasTarget(); // 0x07216a6c
	static System.Void .cctor(); // 0x07216cd0
	System.Void <PlayFx>b__45_0(System.Boolean success, Effect.EffectItem effectItem, System.Object o); // 0x07216e28
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricSolarPanelComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent
{
	static System.Int32 CLASS_HASH = 1139234185;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x07216f0c
	System.String GetTypeName(); // 0x07216f74
	System.Int32 get_Id(); // 0x07216fec
	System.Void .ctor(); // 0x07217050
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072170dc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0721718c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0721723c
	static System.Void .cctor(); // 0x072172a0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricSplitterComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent
{
	static System.Int32 CLASS_HASH = 1861612170;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x07217390
	System.String GetTypeName(); // 0x072173f8
	System.Int32 get_Id(); // 0x07217470
	System.Void .ctor(); // 0x072174d4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07217560
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07217610
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072176c0
	static System.Void .cctor(); // 0x07217724
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricSwitchComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 410269729;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	UnityEngine.GameObject greenLight; // 0x48
	UnityEngine.GameObject redLight; // 0x50
	UnityEngine.GameObject offLightOfRed; // 0x58
	UnityEngine.GameObject offLightOfGreen; // 0x60
	WizardGames.Soc.Common.Unity.Construction.IBinaryAnimationPlayer animationPlayer; // 0x68
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x70
	static System.Boolean isInit; // 0x10
	System.Int64 timer; // 0x78
	System.Int32 GetClassHash(); // 0x072177e0
	System.String GetTypeName(); // 0x07217848
	System.Int32 get_Id(); // 0x072178c0
	System.Void .ctor(); // 0x07217924
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072179e8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07217ad0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07217bb8
	System.Void OnGoLoaded(); // 0x07217c1c
	System.Void ClearShow(); // 0x07217cec
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x07217e70
	System.Void OnSkinGoRemove(); // 0x07218b34
	System.Void InitInstanceToggleGroup(); // 0x072185a8
	System.Void Tick(System.Int64 timerId); // 0x07218b94
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x0721890c
	System.Void SwitchLight(System.Boolean on); // 0x07218d80
	System.Void TurnOffLight(); // 0x072184f0
	System.Void PlayAnimation(System.Boolean on); // 0x07218e58
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x0721901c
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x07219090
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x0721914c
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x072191c0
	static System.Void .cctor(); // 0x072192ec
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricSwitchComponent.<>c__DisplayClass30_0 : System.Object
{
	WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer gpuInstContainer; // 0x10
	System.Void .ctor(); // 0x07218488
	System.Void <OnSkinGoLoaded>b__0(System.Boolean enable); // 0x072193a8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricTestGeneratorComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent
{
	static System.Int32 CLASS_HASH = 1978493939;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x07219450
	System.String GetTypeName(); // 0x072194b8
	System.Int32 get_Id(); // 0x07219530
	System.Void .ctor(); // 0x07219594
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07219620
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x072196d0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07219780
	static System.Void .cctor(); // 0x072197e4
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricTimerComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 1861832476;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int64 timer; // 0x40
	UnityEngine.GameObject obj; // 0x48
	UnityEngine.GameObject needle; // 0x50
	WizardGames.Soc.Common.Unity.Construction.IBinaryAnimationPlayer animationPlayer; // 0x58
	UnityEngine.GameObject[] greenLights; // 0x60
	UnityEngine.GameObject[] redLights; // 0x68
	UnityEngine.GameObject[] offLights; // 0x70
	System.Int64 needleTimer; // 0x78
	System.Boolean handleState; // 0x80
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x88
	WizardGames.Soc.SocClient.GpuInstance.GpuInstObject needleInstObject; // 0x90
	WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer gpuInstContainer; // 0x98
	System.Int32 GetClassHash(); // 0x072198a0
	System.String GetTypeName(); // 0x07219908
	System.Int32 get_Id(); // 0x07219980
	System.Void .ctor(); // 0x072199e4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07219b1c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07219c78
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07219dd4
	System.Void RemoteCallSetTimerTime(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Single timeTarget); // 0x07219e38
	System.Void OnGoLoaded(); // 0x07219fc0
	System.Void ClearShow(); // 0x0721a11c
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x0721a74c
	System.Void OnSkinGoRemove(); // 0x0721b67c
	System.Void InitInstanceToggleGroup(); // 0x0721b388
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x0721b5b8
	System.Void RefreshTimerState(System.Boolean hasPower, System.Boolean active, System.Boolean immediatePlayAnimToEnd); // 0x0721aff8
	System.Void Tick(System.Int64 timerId); // 0x0721ba94
	System.Void SetLights(System.Boolean hasPower, System.Boolean active); // 0x0721b6dc
	System.Void FindLights(UnityEngine.GameObject root); // 0x0721acf0
	System.Void ClearLights(); // 0x0721a458
	System.Void StartNeedleTimer(); // 0x0721b84c
	System.Void StopNeedleTimer(); // 0x0721a300
	System.Void PlayAudio(System.Boolean working); // 0x0721a544
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x0721bce8
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x0721bd5c
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x0721bea8
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x0721bf1c
	static System.Void .cctor(); // 0x0721c300
	System.Void <OnSkinGoLoaded>b__35_0(System.Boolean enable); // 0x0721c3bc
	System.Void <OnUiBtnClicked>b__50_1(System.String curValue); // 0x0721c464
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricTimerComponent.<>c : System.Object
{
	static WizardGames.Soc.Common.Component.ElectricTimerComponent.<>c <>9; // 0x0
	static System.Func<System.String,System.String> <>9__50_0; // 0x8
	static System.Void .cctor(); // 0x0721c67c
	System.Void .ctor(); // 0x0721c6e0
	System.String <OnUiBtnClicked>b__50_0(System.String curValue); // 0x0721c748
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricTimerComponent.<>c__DisplayClass44_0 : System.Object
{
	WizardGames.Soc.Common.Component.ElectricTimerComponent <>4__this; // 0x10
	System.Int64 startTime; // 0x18
	System.Int64 during; // 0x20
	System.Void .ctor(); // 0x0721bc80
	System.Void <StartNeedleTimer>b__0(System.Int64 timerId); // 0x0721c848
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricWindmillComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 1699775527;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Single powerChange; // 0x40
	UnityEngine.GameObject obj; // 0x48
	System.Int64 timer; // 0x50
	UnityEngine.Transform windmillVaneA; // 0x58
	UnityEngine.Transform windmillVaneB; // 0x60
	UnityEngine.Transform windmillVaneC; // 0x68
	WizardGames.Soc.Common.Construction.AnimSubNodeMeshDealer animDealerA; // 0x70
	WizardGames.Soc.Common.Construction.AnimSubNodeMeshDealer animDealerB; // 0x78
	WizardGames.Soc.Common.Construction.AnimSubNodeMeshDealer animDealerC; // 0x80
	System.Single yaw; // 0x88
	System.Single pitch; // 0x8c
	WizardGames.Soc.Common.CustomType.BuildingPartBriefExWindmill extraData; // 0x90
	System.Boolean playingAudio; // 0x98
	System.Boolean oldNotVisible; // 0x99
	System.Int32 count; // 0x9c
	WizardGames.Soc.Common.Algorithm.Vector3 windMir; // 0xa0
	System.Int32 GetClassHash(); // 0x0721c9d8
	System.String GetTypeName(); // 0x0721ca40
	System.Int32 get_Id(); // 0x0721cab8
	System.Void .ctor(); // 0x0721cb1c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0721cbb0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0721cc68
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0721cd20
	WizardGames.Soc.Common.CustomType.BuildingPartBriefExWindmill get_windmillExtra(); // 0x0721cd84
	static System.Void .cctor(); // 0x0721d008
	System.Void OnGoLoaded(); // 0x0721d168
	System.Void Cleanup(); // 0x0721d238
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x0721d3c0
	System.Void OnSkinGoRemove(); // 0x0721da7c
	static System.Void OnWindUpdate(WizardGames.Soc.Share.Framework.CustomTypeBase custom, System.Single oldVal, System.Single newVal); // 0x0721db54
	System.Void OnWindPowerChange(); // 0x0721d7d4
	System.Void Tick(System.Int64 timerId); // 0x0721dcb8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.ElectricXorSwitchComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 998181783;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	UnityEngine.GameObject[] greenLights; // 0x48
	UnityEngine.GameObject[] redLights; // 0x50
	UnityEngine.GameObject[] offLights; // 0x58
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x60
	System.Int32 GetClassHash(); // 0x0721e0c8
	System.String GetTypeName(); // 0x0721e130
	System.Int32 get_Id(); // 0x0721e1a8
	System.Void .ctor(); // 0x0721e20c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0721e344
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0721e4a0
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0721e5fc
	System.Void OnGoLoaded(); // 0x0721e660
	System.Void Cleanup(); // 0x0721e730
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x0721e918
	System.Void OnSkinGoRemove(); // 0x0721f2dc
	System.Void InitInstanceToggleGroup(); // 0x0721ed80
	System.Void RefreshLights(); // 0x0721efb0
	System.Void FindLights(UnityEngine.GameObject root); // 0x0721ea84
	System.Void ClearLights(); // 0x0721e82c
	static System.Void .cctor(); // 0x0721f33c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.FlakTurretComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 340105258;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x38
	System.Int32 GetClassHash(); // 0x0721f3f8
	System.String GetTypeName(); // 0x0721f460
	System.Int32 get_Id(); // 0x0721f4d8
	System.Void .ctor(); // 0x0721f53c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0721f600
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0721f6e8
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0721f7d0
	System.Int64 get_TargetId(); // 0x0721f834
	System.Single get_TargetLookX(); // 0x0721f8a8
	System.Single get_TargetLookY(); // 0x0721f91c
	System.Single get_TargetLookZ(); // 0x0721f990
	System.Void OnGoLoaded(); // 0x0721fa04
	static System.Void .cctor(); // 0x0721fa6c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.FluidicContainerComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler
{
	static System.Int32 CLASS_HASH = 1226788200;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Boolean isHaveWaterContainer; // 0x40
	WizardGames.Soc.SocClient.Electric.DrinkWaterMixin drinkWater; // 0x44
	System.Int32 GetClassHash(); // 0x0721fbc4
	System.String GetTypeName(); // 0x0721fc2c
	System.Int32 get_Id(); // 0x0721fca4
	System.Void .ctor(); // 0x0721fd08
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0721fd98
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0721fe4c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0721ff00
	System.Void OnGoLoaded(); // 0x0721ff64
	System.Void Cleanup(); // 0x072202b8
	System.Void OnSwitchWeaponSuccess(System.Int64 oldid, System.Int64 newid); // 0x072203d4
	System.Void UpdateWaterContainerState(); // 0x07220084
	System.Void StartGetWater(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x07220454
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x07220578
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x072205ec
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x0722073c
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x072207b0
	static System.Void .cctor(); // 0x07220ae0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.FluidicPoweredWaterPurifierComponent : WizardGames.Soc.Common.Component.FluidicContainerComponent, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 1131158954;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x48
	UnityEngine.Transform lod0; // 0x50
	UnityEngine.Transform lod1; // 0x58
	UnityEngine.MeshRenderer renderer0; // 0x60
	UnityEngine.MeshRenderer renderer1; // 0x68
	static UnityEngine.Color startColor; // 0x10
	static UnityEngine.MaterialPropertyBlock block; // 0x20
	static System.Int32 EmissionColor; // 0x28
	System.Int32 GetClassHash(); // 0x07220b9c
	System.String GetTypeName(); // 0x07220c04
	System.Int32 get_Id(); // 0x07220c7c
	System.Void .ctor(); // 0x07220ce0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07220d68
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07220e14
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07220ec0
	WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer get_gpuInstContainer(); // 0x07220f24
	System.Void OnGoLoaded(); // 0x07220fdc
	System.Void OptimizeLodMaterial(UnityEngine.Transform lod, UnityEngine.MeshRenderer& renderer); // 0x072210a4
	System.Void Cleanup(); // 0x072211ac
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x07221390
	System.Void OnSkinGoRemove(); // 0x0722194c
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x072219ac
	System.Void OnFlagChangeAction(System.Int32 lastFlag, System.Int32 newFlag, System.Boolean isInit); // 0x07221634
	System.Void SetWaterPurifierRenderer(System.Boolean isOn, System.Boolean isInit); // 0x07221a38
	static System.Void .cctor(); // 0x07221fd8
}

// Client.Runtime
class WizardGames.Soc.Common.Component.FluidicPumpComponent : WizardGames.Soc.Common.Component.FluidicContainerComponent, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 875156996;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x48
	UnityEngine.Transform lod0; // 0x50
	UnityEngine.MeshRenderer renderer0; // 0x58
	static UnityEngine.Color startColor; // 0x10
	static UnityEngine.MaterialPropertyBlock block; // 0x20
	static System.Int32 EmissionColor; // 0x28
	WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer gpuInstContainer; // 0x60
	System.Int32 GetClassHash(); // 0x072220d4
	System.String GetTypeName(); // 0x0722213c
	System.Int32 get_Id(); // 0x072221b4
	System.Void .ctor(); // 0x07222218
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072222a0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0722234c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072223f8
	System.Void OnGoLoaded(); // 0x0722245c
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x07222524
	System.Void OnSkinGoRemove(); // 0x07222c84
	System.Void OptimizeLodMaterial(UnityEngine.Transform lod, UnityEngine.MeshRenderer& renderer); // 0x072227f0
	System.Void SetWaterPurifierRenderer(System.Boolean isOn, System.Boolean isInit); // 0x07222ce4
	System.Void Cleanup(); // 0x07223210
	System.Void OnFlagChangeInner(System.Int32 lastFlag, System.Int32 newFlag, System.Boolean isInit); // 0x072228f8
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x07223480
	static System.Void .cctor(); // 0x0722350c
}

// Client.Runtime
class WizardGames.Soc.Common.Component.FluidicSprinklerComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 567477698;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	UnityEngine.Transform effectTransform; // 0x48
	WizardGames.Soc.SocClient.Construction.ConstructionEffectPlay effectPlayer; // 0x50
	System.Int32 waterPerSplash; // 0x58
	System.Int32 GetClassHash(); // 0x07223608
	System.String GetTypeName(); // 0x07223670
	System.Int32 get_Id(); // 0x072236e8
	System.Void .ctor(); // 0x0722374c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072237d8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07223888
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07223938
	System.Void OnGoLoaded(); // 0x0722399c
	System.Void Cleanup(); // 0x07223dd8
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x07223b30
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x07224048
	System.Void OnSkinGoRemove(); // 0x07224390
	static System.Void .cctor(); // 0x072243f0
}

// Client.Runtime
class WizardGames.Soc.Common.Component.FluidicSwitchComponent : WizardGames.Soc.Common.Component.ElectricBaseComponent, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 489989498;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x40
	UnityEngine.Transform handle; // 0x48
	UnityEngine.Quaternion targetQuaternion; // 0x50
	UnityEngine.GameObject onGo; // 0x60
	UnityEngine.GameObject offGo; // 0x68
	UnityEngine.GameObject nopowerGo; // 0x70
	System.Int64 rotateTimer; // 0x78
	WizardGames.Soc.SocClient.GpuInstance.Utils.GpuInstToggleGroup instanceToggleGroup; // 0x80
	WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer gpuInstContainer; // 0x88
	System.Int32 GetClassHash(); // 0x072244ac
	System.String GetTypeName(); // 0x07224514
	System.Int32 get_Id(); // 0x0722458c
	System.Void .ctor(); // 0x072245f0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072246b4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0722479c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07224884
	System.Void OnGoLoaded(); // 0x072248e8
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x072249b8
	System.Void OnSkinGoRemove(); // 0x072251d8
	System.Void Cleanup(); // 0x07225238
	System.Void OnFlagChange(System.Int32 lastFlag, System.Int32 newFlag); // 0x07224d74
	System.Void RotateHandle(System.Boolean isOn); // 0x0722544c
	System.Void CheckState(); // 0x07225620
	System.Void Tick(System.Int64 timerId); // 0x072257e4
	System.Void SwitchAnimatedNode(System.Boolean enable); // 0x07225714
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x07225960
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x072259d4
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x07225a90
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x07225b04
	static System.Void .cctor(); // 0x07225c30
}

// Client.Runtime
class WizardGames.Soc.Common.Component.FoundationLinkComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 23;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x07225cec
	System.String GetTypeName(); // 0x07225d50
	System.Int32 get_Id(); // 0x07225dc8
	System.Void .ctor(); // 0x07225e2c
	System.Void InitByArrayDataSet(WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07225eb8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07225f74
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07226024
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> get_ContainerEntityIds(); // 0x07226088
	System.Void set_ContainerEntityIds(WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> value); // 0x07226128
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x072261b4
	System.Void ReturnToPoolFramework(); // 0x072263f4
	static System.Object DeserializeFoundationLinkComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07226490
	static System.Void .cctor(); // 0x07226560
}

// Client.Runtime
class WizardGames.Soc.Common.Component.FuelConsumptionComponent : WizardGames.Soc.Common.Component.StorageComponent, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler
{
	static System.Int32 CLASS_HASH = 591080140;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.GameObject obj; // 0x38
	WizardGames.Soc.Common.Data.DataItem.Container containerConfig; // 0x40
	WizardGames.Soc.Common.Component.ConstructionFlagComponent flagComponent; // 0x48
	System.Int64 leftTimeMs; // 0x50
	System.Int32 GetClassHash(); // 0x07226618
	System.String GetTypeName(); // 0x07226680
	System.Int32 get_Id(); // 0x072266f8
	System.Void .ctor(); // 0x0722675c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x072267e8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07226898
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07226948
	System.Int64 get_BurningFuelBizId(); // 0x072269ac
	System.Int64 get_StopTimeStamp(); // 0x07226a20
	WizardGames.Soc.Common.Entity.PartEntity get_ParentPartEntity(); // 0x07226a94
	System.Int64 get_NODE_ID(); // 0x07226b4c
	System.Int64 get_LeftTimeMs(); // 0x07226bec
	System.Void OnGoLoaded(); // 0x07226c50
	System.Void Init(); // 0x07226e0c
	System.Void Cleanup(); // 0x07226fb8
	System.Int64 GetFuleAmount(); // 0x07227130
	System.Void UpdateLeftTimeMs(); // 0x07226eec
	System.Void SwitchFuelGenerator(System.Boolean open); // 0x072273ec
	System.Void GenratorAddFuel(); // 0x072275d8
	System.Void GenratorRemoveFuel(); // 0x072277f0
	System.Void GenratorLackFuel(); // 0x0722799c
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x07227aac
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x07227e5c
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x07227ed0
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x07227f44
	static System.Void .cctor(); // 0x07228048
	System.Void <Init>b__33_0(); // 0x072281d4
}

// Client.Runtime
enum WizardGames.Soc.Common.Component.FuelConsumptionComponent.EFuelGenratorOperation : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Component.FuelConsumptionComponent.EFuelGenratorOperation TurnOn = 247;
	static WizardGames.Soc.Common.Component.FuelConsumptionComponent.EFuelGenratorOperation TurnOff = 248;
	static WizardGames.Soc.Common.Component.FuelConsumptionComponent.EFuelGenratorOperation GenratorAddFuel = 584;
	static WizardGames.Soc.Common.Component.FuelConsumptionComponent.EFuelGenratorOperation GenratorRemoveFuel = 585;
	static WizardGames.Soc.Common.Component.FuelConsumptionComponent.EFuelGenratorOperation GenratorLackFuel = 586;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Component.FunctionParamComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 2070510628;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	static WizardGames.Soc.Common.Component.FunctionParamComponent Instance; // 0x10
	System.Int32 GetClassHash(); // 0x07228238
	System.String GetTypeName(); // 0x072282a0
	System.Int32 get_Id(); // 0x07228318
	System.Void .ctor(); // 0x0722837c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07228408
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07228518
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x072285c8
	System.Int32 get_TeamMemberLimit(); // 0x0722862c
	System.Int32 get_Platform(); // 0x072286a0
	System.Int32 get_GameModeId(); // 0x07228714
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int32,System.Int32> get_PermissionGroupLimit(); // 0x07228788
	System.Void set_PermissionGroupLimit(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int32,System.Int32> value); // 0x07228828
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int32,System.Single> get_SpawnRuleRateFactor(); // 0x072288b4
	System.Void set_SpawnRuleRateFactor(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int32,System.Single> value); // 0x07228954
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x072289e0
	static System.Object DeserializeFunctionParamComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07228d54
	System.Void Init(); // 0x07228ec8
	System.Void Cleanup(); // 0x07228f5c
	System.Int32 GetPermissionGroupLimit(System.Int32 groupId); // 0x07228ff0
	static System.Void .cctor(); // 0x07229180
}

// Client.Runtime
class WizardGames.Soc.Common.Component.FunctionSwitchComponent : WizardGames.Soc.Share.Framework.ComponentBase
{
	static System.Int32 CLASS_HASH = 795831748;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	static WizardGames.Soc.Common.Component.FunctionSwitchComponent Instance; // 0x10
	System.Int32 GetClassHash(); // 0x072296b4
	System.String GetTypeName(); // 0x0722971c
	System.Int32 get_Id(); // 0x07229794
	System.Void .ctor(); // 0x072297f8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07229884
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0722999c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x07229a4c
	WizardGames.Soc.Common.CustomType.SystemRootNode get_Root(); // 0x07229ab0
	System.Void Init(); // 0x07229b74
	System.Void Cleanup(); // 0x07229c08
	System.Boolean IsEnable(WizardGames.Soc.Common.Component.FunctionName configName); // 0x07229c9c
	System.Boolean IsDisable(WizardGames.Soc.Common.Component.FunctionName configName); // 0x0722a024
	static System.Void .cctor(); // 0x0722a0ac
}

// Client.Runtime
class WizardGames.Soc.Common.Component.GoldCoinAirdropBoxComponent : WizardGames.Soc.Common.Component.BoxComponent
{
	static System.Int32 CLASS_HASH = 1063730756;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x0722a168
	System.String GetTypeName(); // 0x0722a1d0
	System.Int32 get_Id(); // 0x0722a248
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0722a2ac
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0722a35c
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0722a40c
	static System.Object DeserializeGoldCoinAirdropBoxComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0722a470
	static System.Void .cctor(); // 0x0722a544
}

// Client.Runtime
class WizardGames.Soc.Common.Component.GoldCoinDropBoxComponent : WizardGames.Soc.Common.Component.BoxComponent
{
	static System.Int32 CLASS_HASH = 415799995;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x0722a7d4
	System.String GetTypeName(); // 0x0722a83c
	System.Int32 get_Id(); // 0x0722a8b4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0722a918
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0722a9c8
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0722aa78
	static System.Object DeserializeGoldCoinDropBoxComponentContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0722aadc
	static System.Void .cctor(); // 0x0722ac00
}

// Client.Runtime
class WizardGames.Soc.Common.Component.GunTrapComponent : WizardGames.Soc.Common.Component.StorageComponent, WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler, WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler
{
	static System.Int32 CLASS_HASH = 162537849;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.Transform controlTransform; // 0x38
	WizardGames.Soc.Common.Data.units.GunTrapTriggerConfig gunTrapTb; // 0x40
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent <objectComponent>k__BackingField; // 0x48
	Effect.EffectItemHandle<Effect.FollowEffect> firePersistentEffectItemHandle; // 0x50
	Effect.EffectItemHandle<Effect.FollowEffect> standByEffectItemHandle; // 0x60
	System.String nowLoopSoundName; // 0x70
	UnityEngine.GameObject mainGo; // 0x78
	UnityEngine.GameObject skinGo; // 0x80
	System.Single nowRotateYaw; // 0x88
	System.Boolean manageBySystem; // 0x8c
	System.Int32 GetClassHash(); // 0x0722aec4
	System.String GetTypeName(); // 0x0722af2c
	System.Int32 get_Id(); // 0x0722afa4
	System.Void .ctor(); // 0x0722b008
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0722b094
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0722b144
	WizardGames.Soc.Common.Framework.Const.ESyncRange get_SyncRange(); // 0x0722b1f4
