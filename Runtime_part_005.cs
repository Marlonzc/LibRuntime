class WizardGames.Soc.Share.Framework.ReadonlyBytes : WizardGames.Soc.Share.Framework.CustomTypeBase, System.Buffers.IBufferWriter<System.Byte>
{
	static System.Int32 CLASS_HASH = 53;
	static System.Int32 StaticClassHash; // 0x0
	static SocLogger logger; // 0x8
	System.Int32 GetClassHash(); // 0x069c6548
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x069c65ac
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x069c6634
	static System.String[] get_PropNameArray(); // 0x069c66bc
	WizardGames.Soc.Share.Framework.Entity.UnityFixedBytes get_internalFixedBytes(); // 0x069c6744
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x069c6868
	WizardGames.Soc.Share.Framework.TypeBase get_ParentRef(); // 0x069c68f0
	System.Void set_ParentRef(WizardGames.Soc.Share.Framework.TypeBase value); // 0x069c6954
	System.Void SerializeCore(MessagePack.MessagePackWriter& msgWriter, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x069c69ec
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x069c6cc0
	static System.Void HexStringToBytesFast(System.ReadOnlySpan<System.Char> hexString, System.Span<System.Byte> bytes); // 0x069c6fbc
	static System.Int32 HexCharToByte(System.Char c); // 0x069c71e8
	System.Void Advance(System.Int32 count); // 0x069c7310
	System.Buffers.ReadOnlySequence<System.Byte> GetSequence(); // 0x069c7440
	System.Memory<System.Byte> GetMemory(System.Int32 sizeHint); // 0x069c753c
	System.Span<System.Byte> GetSpan(System.Int32 sizeHint); // 0x069c766c
	static System.Void .cctor(); // 0x069c779c
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.SyncDateValueTypeHelper<T> : System.Object
{
	static WizardGames.Soc.Share.Framework.SyncDateValueTypeHelper.DeseializeOneFunc<T> F; // 0x0
	
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.SyncDateValueTypeHelper.DeseializeOneFunc<T> : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05525a60
	T Invoke(WizardGames.Soc.Share.Framework.SyncDataValue& syncDataValue); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.SyncDateValueHelper : System.Object
{
	
	static System.Void .cctor(); // 0x069c7884
	static T DeseializeOne<T>(WizardGames.Soc.Share.Framework.SyncDataValue& syncDataValue); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.SyncDateValueHelper.<>c : System.Object
{
	static WizardGames.Soc.Share.Framework.SyncDateValueHelper.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x069c7dec
	System.Void .ctor(); // 0x069c7e50
	System.Int32 <.cctor>b__0_0(WizardGames.Soc.Share.Framework.SyncDataValue& syncDataValue); // 0x069c7eb8
	System.Int64 <.cctor>b__0_1(WizardGames.Soc.Share.Framework.SyncDataValue& syncDataValue); // 0x069c80b0
	System.Byte <.cctor>b__0_2(WizardGames.Soc.Share.Framework.SyncDataValue& syncDataValue); // 0x069c8128
	System.Int16 <.cctor>b__0_3(WizardGames.Soc.Share.Framework.SyncDataValue& syncDataValue); // 0x069c81a4
	System.Single <.cctor>b__0_4(WizardGames.Soc.Share.Framework.SyncDataValue& syncDataValue); // 0x069c8220
	System.Double <.cctor>b__0_5(WizardGames.Soc.Share.Framework.SyncDataValue& syncDataValue); // 0x069c8420
	System.String <.cctor>b__0_6(WizardGames.Soc.Share.Framework.SyncDataValue& syncDataValue); // 0x069c8620
	System.UInt64 <.cctor>b__0_7(WizardGames.Soc.Share.Framework.SyncDataValue& syncDataValue); // 0x069c8810
	System.UInt32 <.cctor>b__0_8(WizardGames.Soc.Share.Framework.SyncDataValue& syncDataValue); // 0x069c8888
	System.Boolean <.cctor>b__0_9(WizardGames.Soc.Share.Framework.SyncDataValue& syncDataValue); // 0x069c8904
}

// Client.Runtime
enum WizardGames.Soc.Share.Framework.ECustomDictOpType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Share.Framework.ECustomDictOpType Clear = 0;
	static WizardGames.Soc.Share.Framework.ECustomDictOpType InsertOrOverride = 1;
	static WizardGames.Soc.Share.Framework.ECustomDictOpType Remove = 2;
	static WizardGames.Soc.Share.Framework.ECustomDictOpType Modify = 3;
	static WizardGames.Soc.Share.Framework.ECustomDictOpType BeforeClear = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.Share.Framework.ECustomHashSetOpType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Share.Framework.ECustomHashSetOpType Clear = 0;
	static WizardGames.Soc.Share.Framework.ECustomHashSetOpType Add = 1;
	static WizardGames.Soc.Share.Framework.ECustomHashSetOpType Remove = 2;
	static WizardGames.Soc.Share.Framework.ECustomHashSetOpType BeforeClear = 3;
	
}

// Client.Runtime
interface WizardGames.Soc.Share.Framework.ICustomContainer : 
{
	static SocLogger logger; // 0x0
	System.Void DeltaUpdate(WizardGames.Soc.Share.Framework.SyncUpdateContext& ctx); // 0x05523a54
	static System.Void .cctor(); // 0x069c8af4
}

// Client.Runtime
interface WizardGames.Soc.Share.Framework.IBasicTypeContainer : , WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Share.Framework.ICustomContainer
{
	
	System.Void DeltaUpdateBasicTypeContainer(WizardGames.Soc.Share.Framework.SyncUpdateContext& ctx); // 0x05523a54
	System.Boolean ReloadData(WizardGames.Soc.Share.Framework.TypeBase other); // 0x054dec74
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.BasicTypeHashSet<T> : WizardGames.Soc.Share.Framework.TypeBase, WizardGames.Soc.Share.Framework.IBasicTypeContainer, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Share.Framework.ICustomContainer, System.Collections.Generic.ISet<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.HashSet<T> _inner; // 0x0
	System.Action<WizardGames.Soc.Share.Framework.ECustomHashSetOpType,T> updateNotify; // 0x0
	System.Collections.Generic.IEnumerator<T> GetEnumerator(); // 0x054e7844
	System.Int32 get_Count(); // 0x0548ba98
	System.Boolean get_IsReadOnly(); // 0x054c4760
	System.Void ResetWhenDeserialize(); // 0x055049cc
	System.Void Clear(); // 0x055049cc
	System.Boolean Contains(T key); // 0x052af1f0
	System.String ToPrettyString(); // 0x054e7844
	System.Int32 GetClassHash(); // 0x0548ba98
	System.Void CopyTo(T[] array, System.Int32 arrayIndex); // 0x05525b70
	System.Boolean SetEquals(System.Collections.Generic.IEnumerable<T> other); // 0x054dec74
	System.Boolean IsProperSubsetOf(System.Collections.Generic.IEnumerable<T> other); // 0x054dec74
	System.Boolean IsProperSupersetOf(System.Collections.Generic.IEnumerable<T> other); // 0x054dec74
	System.Boolean IsSubsetOf(System.Collections.Generic.IEnumerable<T> other); // 0x054dec74
	System.Boolean IsSupersetOf(System.Collections.Generic.IEnumerable<T> other); // 0x054dec74
	System.Boolean Overlaps(System.Collections.Generic.IEnumerable<T> other); // 0x054dec74
	System.Void UnionWith(System.Collections.Generic.IEnumerable<T> other); // 0x05523a54
	System.Void ExceptWith(System.Collections.Generic.IEnumerable<T> other); // 0x05523a54
	System.Void IntersectWith(System.Collections.Generic.IEnumerable<T> other); // 0x05523a54
	System.Void SymmetricExceptWith(System.Collections.Generic.IEnumerable<T> other); // 0x05523a54
	System.Collections.Generic.List<T> ToList(); // 0x054e7844
	System.Void .ctor(); // 0x055049cc
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x05525b70
	System.Void .ctor(SimpleJSON.JSONNode json); // 0x05523a54
	System.Void System.Collections.Generic.ICollection<T>.Add(T item); // 0x052af1f0
	System.Boolean Add(T item); // 0x052af1f0
	System.Boolean Remove(T item); // 0x052af1f0
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x054e7844
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x05525bf4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x05525b70
	System.Void WizardGames.Soc.Share.Framework.IBasicTypeContainer.DeltaUpdateBasicTypeContainer(WizardGames.Soc.Share.Framework.SyncUpdateContext& ctx); // 0x05523a54
	System.Void DeltaUpdateBasicTypeContainer(WizardGames.Soc.Share.Framework.SyncUpdateContext& ctx); // 0x05523a54
	System.String ToDetailedString(); // 0x054e7844
	System.Boolean WizardGames.Soc.Share.Framework.IBasicTypeContainer.ReloadData(WizardGames.Soc.Share.Framework.TypeBase other); // 0x054dec74
	System.Void SubscribeHashSetUpdate(System.Action<WizardGames.Soc.Share.Framework.ECustomHashSetOpType,T> callback); // 0x05523a54
	System.Void UnsubscribeHashSetUpdate(System.Action<WizardGames.Soc.Share.Framework.ECustomHashSetOpType,T> callback); // 0x05523a54
	System.Void callUpdateNotify(WizardGames.Soc.Share.Framework.ECustomHashSetOpType opType, T value); // 0x052af1f0
	System.Void DeltaUpdate(WizardGames.Soc.Share.Framework.SyncUpdateContext& ctx); // 0x05523a54
	SimpleJSON.JSONNode ToEJson(); // 0x054e7844
	System.Void FromEJson(SimpleJSON.JSONNode node); // 0x05523a54
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.CustomListHelper : System.Object
{
	
	static System.Void DeserializeCore<T>(System.Collections.Generic.List<T> list, System.Int32 hashValue, MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.CustomDictionaryHelper : System.Object
{
	
	static System.Void DeserializeCore<TKey,TValue>(System.Collections.Generic.Dictionary<TKey,TValue> dic, System.Int32 hashValue, MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.AbstractCustomDictionary<TKey,TValue> : WizardGames.Soc.Share.Framework.TypeBase, WizardGames.Soc.Share.Framework.ICustomContainer
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<TKey,TValue> _inner; // 0x0
	System.Action<WizardGames.Soc.Share.Framework.ECustomDictOpType,TKey,TValue> updateNotify; // 0x0
	System.Void .ctor(); // 0x055049cc
	System.Collections.Generic.IEnumerable<TKey> get_Keys(); // 0x054e7844
	System.Collections.Generic.IEnumerable<TValue> get_Values(); // 0x054e7844
	System.Int32 get_Count(); // 0x0548ba98
	System.Boolean get_IsReadOnly(); // 0x054c4760
	System.Boolean Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item); // 0x052af1f0
	System.Boolean ContainsKey(TKey key); // 0x052af1f0
	System.Void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 arrayIndex); // 0x05525b70
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator(); // 0x054e7844
	System.Boolean TryGetValue(TKey key, TValue& value); // 0x052af1f0
	System.String ToPrettyString(); // 0x054e7844
	System.Int32 GetClassHash(); // 0x0548ba98
	System.Collections.Generic.KeyValuePair<TKey,TValue> FirstOrDefault(System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,System.Boolean> judge); // 0x052af1f0
	System.Void SubscribeDictUpdate(System.Action<WizardGames.Soc.Share.Framework.ECustomDictOpType,TKey,TValue> callback); // 0x05523a54
	System.Void UnSubscribeDictUpdate(System.Action<WizardGames.Soc.Share.Framework.ECustomDictOpType,TKey,TValue> callback); // 0x05523a54
	System.Void callUpdateNotify(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, TKey key, TValue oldValue); // 0x052af1f0
	System.Void DeltaUpdate(WizardGames.Soc.Share.Framework.SyncUpdateContext& ctx); // 0x05523a54
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.KeyTypeHelperInit : System.Object
{
	
	static System.Void Init(); // 0x069c8bc8
	static System.ValueTuple<System.Boolean,System.Int16> GetShortKey(System.Nullable<System.Int64> propId); // 0x069c9b04
	static System.ValueTuple<System.Boolean,System.Int32> GetIntKey(System.Nullable<System.Int64> propId); // 0x069c9c00
	static System.ValueTuple<System.Boolean,System.Int64> GetLongKey(System.Nullable<System.Int64> propId); // 0x069c9cf8
	static System.ValueTuple<System.Boolean,System.UInt64> GetULongKey(System.Nullable<System.Int64> propId); // 0x069c9df4
	static System.ValueTuple<System.Boolean,System.UInt32> GetUIntKey(System.Nullable<System.Int64> propId); // 0x069c9ef0
	static System.ValueTuple<System.Boolean,System.UInt16> GetUShortKey(System.Nullable<System.Int64> propId); // 0x069c9fe8
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.KeyTypeHelperInit.<>c : System.Object
{
	static WizardGames.Soc.Share.Framework.KeyTypeHelperInit.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.Share.Framework.TypeBase,WizardGames.Soc.Share.Framework.TypeBase,System.Int16> <>9__0_0; // 0x8
	static System.Action<WizardGames.Soc.Share.Framework.TypeBase,WizardGames.Soc.Share.Framework.TypeBase,System.Int32> <>9__0_1; // 0x10
	static System.Action<WizardGames.Soc.Share.Framework.TypeBase,WizardGames.Soc.Share.Framework.TypeBase,System.Int64> <>9__0_2; // 0x18
	static System.Action<WizardGames.Soc.Share.Framework.TypeBase,WizardGames.Soc.Share.Framework.TypeBase,System.UInt16> <>9__0_3; // 0x20
	static System.Action<WizardGames.Soc.Share.Framework.TypeBase,WizardGames.Soc.Share.Framework.TypeBase,System.UInt32> <>9__0_4; // 0x28
	static System.Action<WizardGames.Soc.Share.Framework.TypeBase,WizardGames.Soc.Share.Framework.TypeBase,System.UInt64> <>9__0_5; // 0x30
	static System.Func<System.Int64,System.Int32> <>9__0_6; // 0x38
	static System.Func<System.Int64,System.Int64> <>9__0_7; // 0x40
	static System.Func<System.Int64,System.Int16> <>9__0_8; // 0x48
	static System.Func<System.Int64,System.UInt32> <>9__0_9; // 0x50
	static System.Func<System.Int64,System.UInt64> <>9__0_10; // 0x58
	static System.Func<System.Int64,System.UInt16> <>9__0_11; // 0x60
	static System.Func<System.Int32,System.Int64> <>9__0_12; // 0x68
	static System.Func<System.Int64,System.Int64> <>9__0_13; // 0x70
	static System.Func<System.Int16,System.Int64> <>9__0_14; // 0x78
	static System.Func<System.UInt32,System.Int64> <>9__0_15; // 0x80
	static System.Func<System.UInt64,System.Int64> <>9__0_16; // 0x88
	static System.Func<System.UInt16,System.Int64> <>9__0_17; // 0x90
	static System.Void .cctor(); // 0x069ca0e4
	System.Void .ctor(); // 0x069ca148
	System.Void <Init>b__0_0(WizardGames.Soc.Share.Framework.TypeBase val, WizardGames.Soc.Share.Framework.TypeBase parent, System.Int16 key); // 0x069ca1b0
	System.Void <Init>b__0_1(WizardGames.Soc.Share.Framework.TypeBase val, WizardGames.Soc.Share.Framework.TypeBase parent, System.Int32 key); // 0x069ca254
	System.Void <Init>b__0_2(WizardGames.Soc.Share.Framework.TypeBase val, WizardGames.Soc.Share.Framework.TypeBase parent, System.Int64 key); // 0x069ca2f8
	System.Void <Init>b__0_3(WizardGames.Soc.Share.Framework.TypeBase val, WizardGames.Soc.Share.Framework.TypeBase parent, System.UInt16 key); // 0x069ca39c
	System.Void <Init>b__0_4(WizardGames.Soc.Share.Framework.TypeBase val, WizardGames.Soc.Share.Framework.TypeBase parent, System.UInt32 key); // 0x069ca440
	System.Void <Init>b__0_5(WizardGames.Soc.Share.Framework.TypeBase val, WizardGames.Soc.Share.Framework.TypeBase parent, System.UInt64 key); // 0x069ca4e4
	System.Int32 <Init>b__0_6(System.Int64 val); // 0x069ca588
	System.Int64 <Init>b__0_7(System.Int64 val); // 0x069ca600
	System.Int16 <Init>b__0_8(System.Int64 val); // 0x069ca678
	System.UInt32 <Init>b__0_9(System.Int64 val); // 0x069ca6f0
	System.UInt64 <Init>b__0_10(System.Int64 val); // 0x069ca768
	System.UInt16 <Init>b__0_11(System.Int64 val); // 0x069ca7e0
	System.Int64 <Init>b__0_12(System.Int32 val); // 0x069ca858
	System.Int64 <Init>b__0_13(System.Int64 val); // 0x069ca8d0
	System.Int64 <Init>b__0_14(System.Int16 val); // 0x069ca948
	System.Int64 <Init>b__0_15(System.UInt32 val); // 0x069ca9c0
	System.Int64 <Init>b__0_16(System.UInt64 val); // 0x069caa38
	System.Int64 <Init>b__0_17(System.UInt16 val); // 0x069caab0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.KeyTypeHelper<TKey> : System.Object
{
	static System.Func<System.Int64,TKey> ConvertToTkeyFunc; // 0x0
	static System.Func<TKey,System.Int64> ConvertToLongFunc; // 0x8
	static System.Action<WizardGames.Soc.Share.Framework.TypeBase,WizardGames.Soc.Share.Framework.TypeBase,TKey> SetParentAction; // 0x10
	static WizardGames.Soc.Share.Framework.KeyTypeHelper.GetKeyDelegate<TKey> GetKeyAction; // 0x18
	static System.Void DoSetParent(WizardGames.Soc.Share.Framework.TypeBase val, WizardGames.Soc.Share.Framework.TypeBase parent, TKey key); // 0x052af1f0
	static System.ValueTuple<System.Boolean,TKey> DoGetKey(System.Nullable<System.Int64> propId); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.KeyTypeHelper.GetKeyDelegate<TKey> : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05525a60
	System.ValueTuple<System.Boolean,TKey> Invoke(System.Nullable<System.Int64> propId); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.BasicValueDictionary<TKey,TValue> : WizardGames.Soc.Share.Framework.AbstractCustomDictionary<TKey,TValue>, WizardGames.Soc.Share.Framework.IBasicTypeContainer, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Share.Framework.ICustomContainer, System.Collections.Generic.IDictionary<TKey,TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, System.Collections.IEnumerable
{
	
	System.Void .ctor(); // 0x055049cc
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x05525b70
	System.Void .ctor(SimpleJSON.JSONNode json); // 0x05523a54
	System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(); // 0x054e7844
	System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(); // 0x054e7844
	TValue get_Item(TKey key); // 0x052af1f0
	System.Void set_Item(TKey key, TValue value); // 0x052af1f0
	System.Void Add(TKey key, TValue value); // 0x052af1f0
	System.Void Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item); // 0x052af1f0
	System.Void Clear(); // 0x055049cc
	System.Void ResetWhenDeserialize(); // 0x055049cc
	System.Boolean Remove(TKey key); // 0x052af1f0
	System.Boolean Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item); // 0x052af1f0
	System.Void WizardGames.Soc.Share.Framework.IBasicTypeContainer.DeltaUpdateBasicTypeContainer(WizardGames.Soc.Share.Framework.SyncUpdateContext& ctx); // 0x05523a54
	System.Void DeltaUpdateBasicTypeContainer(WizardGames.Soc.Share.Framework.SyncUpdateContext& ctx); // 0x05523a54
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x05525bf4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x05525b70
	System.String ToDetailedString(); // 0x054e7844
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x054e7844
	System.Boolean WizardGames.Soc.Share.Framework.IBasicTypeContainer.ReloadData(WizardGames.Soc.Share.Framework.TypeBase other); // 0x054dec74
	SimpleJSON.JSONNode ToEJson(); // 0x054e7844
	System.Void FromEJson(SimpleJSON.JSONNode node); // 0x05523a54
	System.Void DeltaUpdate(WizardGames.Soc.Share.Framework.SyncUpdateContext& ctx); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.BasicValueDictionary.<>c<TKey,TValue> : System.Object
{
	static WizardGames.Soc.Share.Framework.BasicValueDictionary.<>c<TKey,TValue> <>9; // 0x0
	static System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,System.String> <>9__21_0; // 0x8
	static System.Void .cctor(); // 0x054fd168
	System.Void .ctor(); // 0x055049cc
	System.String <ToDetailedString>b__21_0(System.Collections.Generic.KeyValuePair<TKey,TValue> pair); // 0x052af1f0
}

// Client.Runtime
interface WizardGames.Soc.Share.Framework.ICustomValueDictionary : 
{
	
	System.Boolean ReloadData(WizardGames.Soc.Share.Framework.DictOfArrayDataSet adsDict); // 0x054dec74
	WizardGames.Soc.Share.Framework.TypeBase GetCustomType(System.Int64 index); // 0x054e931c
	System.Void NotifyModified(System.Int64 index); // 0x055112ac
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.CustomValueDictionary<TKey,TValue> : WizardGames.Soc.Share.Framework.AbstractCustomDictionary<TKey,TValue>, System.Collections.Generic.IDictionary<TKey,TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, System.Collections.IEnumerable, WizardGames.Soc.Share.Framework.ICustomValueDictionary
{
	static System.Int32 HashValueOfTValue; // 0x0
	System.Void .ctor(); // 0x055049cc
	System.Void .ctor(WizardGames.Soc.Share.Framework.DictOfArrayDataSet adsDict); // 0x05523a54
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x05525b70
	System.Void .ctor(SimpleJSON.JSONNode json); // 0x05523a54
	System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(); // 0x054e7844
	System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(); // 0x054e7844
	TValue get_Item(TKey key); // 0x052af1f0
	System.Void set_Item(TKey key, TValue value); // 0x052af1f0
	System.Void Add(TKey key, TValue value); // 0x052af1f0
	System.Void Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item); // 0x052af1f0
	System.Void Clear(); // 0x055049cc
	System.Void ResetWhenDeserialize(); // 0x055049cc
	System.Boolean Remove(TKey key); // 0x052af1f0
	System.Boolean Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item); // 0x052af1f0
	System.Boolean ReloadData(WizardGames.Soc.Share.Framework.DictOfArrayDataSet adsDict); // 0x054dec74
	System.Void DeltaUpdate(WizardGames.Soc.Share.Framework.SyncUpdateContext& ctx); // 0x05523a54
	WizardGames.Soc.Share.Framework.TypeBase GetCustomType(System.Int64 index); // 0x054e931c
	System.Void NotifyModified(System.Int64 index); // 0x055112ac
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x05525bf4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x05525b70
	System.String ToDetailedString(); // 0x054e7844
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x054e7844
	SimpleJSON.JSONNode ToEJson(); // 0x054e7844
	System.Void FromEJson(SimpleJSON.JSONNode node); // 0x05523a54
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.CustomValueDictionary.<>c<TKey,TValue> : System.Object
{
	static WizardGames.Soc.Share.Framework.CustomValueDictionary.<>c<TKey,TValue> <>9; // 0x0
	static System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,System.String> <>9__24_0; // 0x8
	static System.Void .cctor(); // 0x054fd168
	System.Void .ctor(); // 0x055049cc
	System.String <ToDetailedString>b__24_0(System.Collections.Generic.KeyValuePair<TKey,TValue> pair); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.AbstractCustomList<T> : WizardGames.Soc.Share.Framework.TypeBase, WizardGames.Soc.Share.Framework.ICustomContainer, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
{
	System.Collections.Generic.List<T> _inner; // 0x0
	System.Action<WizardGames.Soc.Share.Framework.AbstractCustomList.ECustomListOpType<T>,System.Int32,T> updateNotify; // 0x0
	System.Int32 get_Count(); // 0x0548ba98
	System.Boolean get_IsReadOnly(); // 0x054c4760
	System.Boolean Contains(T item); // 0x052af1f0
	System.Void CopyTo(T[] array, System.Int32 arrayIndex); // 0x05525b70
	System.Collections.Generic.List.Enumerator<T> GetEnumerator(); // 0x052af1f0
	System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator(); // 0x054e7844
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x054e7844
	System.Int32 IndexOf(T item); // 0x052af1f0
	System.Void Insert(System.Int32 index, T item); // 0x052af1f0
	System.String ToPrettyString(); // 0x054e7844
	System.Int32 GetClassHash(); // 0x0548ba98
	T FirstOrDefault(System.Func<T,System.Boolean> judge); // 0x052af1f0
	System.Void SubscribeListUpdate(System.Action<WizardGames.Soc.Share.Framework.AbstractCustomList.ECustomListOpType<T>,System.Int32,T> callback); // 0x05523a54
	System.Void UnsubscribeListUpdate(System.Action<WizardGames.Soc.Share.Framework.AbstractCustomList.ECustomListOpType<T>,System.Int32,T> callback); // 0x05523a54
	System.Void CallUpdateNotify(WizardGames.Soc.Share.Framework.AbstractCustomList.ECustomListOpType<T> opType, System.Int32 index, T value); // 0x052af1f0
	System.Void DeltaUpdate(WizardGames.Soc.Share.Framework.SyncUpdateContext& ctx); // 0x05523a54
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
enum WizardGames.Soc.Share.Framework.AbstractCustomList.ECustomListOpType<T> : System.Enum
{
	System.Int32 value__; // 0x0
	static WizardGames.Soc.Share.Framework.AbstractCustomList.ECustomListOpType<T> Clear = 0;
	static WizardGames.Soc.Share.Framework.AbstractCustomList.ECustomListOpType<T> InsertOrOverride = 1;
	static WizardGames.Soc.Share.Framework.AbstractCustomList.ECustomListOpType<T> Remove = 2;
	static WizardGames.Soc.Share.Framework.AbstractCustomList.ECustomListOpType<T> Modify = 3;
	static WizardGames.Soc.Share.Framework.AbstractCustomList.ECustomListOpType<T> BeforeClear = 4;
	
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.BasicTypeList<T> : WizardGames.Soc.Share.Framework.AbstractCustomList<T>, WizardGames.Soc.Share.Framework.IBasicTypeContainer, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Share.Framework.ICustomContainer, System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
{
	
	System.Void .ctor(); // 0x055049cc
	System.Void .ctor(System.Collections.Generic.IEnumerable<T> collection); // 0x05523a54
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x05525b70
	System.Void .ctor(SimpleJSON.JSONNode json); // 0x05523a54
	T get_Item(System.Int32 index); // 0x052af1f0
	System.Void set_Item(System.Int32 index, T value); // 0x052af1f0
	System.Void Add(T item); // 0x052af1f0
	System.Boolean Remove(T item); // 0x052af1f0
	System.Void RemoveAt(System.Int32 index); // 0x055056e8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x05525b70
	System.Void WizardGames.Soc.Share.Framework.IBasicTypeContainer.DeltaUpdateBasicTypeContainer(WizardGames.Soc.Share.Framework.SyncUpdateContext& ctx); // 0x05523a54
	System.Void DeltaUpdateBasicTypeContainer(WizardGames.Soc.Share.Framework.SyncUpdateContext& ctx); // 0x05523a54
	System.Void DeltaUpdate(WizardGames.Soc.Share.Framework.SyncUpdateContext& ctx); // 0x05523a54
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x05525bf4
	System.String ToDetailedString(); // 0x054e7844
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x054e7844
	System.Void ResetWhenDeserialize(); // 0x055049cc
	System.Void Clear(); // 0x055049cc
	System.Boolean WizardGames.Soc.Share.Framework.IBasicTypeContainer.ReloadData(WizardGames.Soc.Share.Framework.TypeBase other); // 0x054dec74
	SimpleJSON.JSONNode ToEJson(); // 0x054e7844
	System.Void FromEJson(SimpleJSON.JSONNode node); // 0x05523a54
}

// Client.Runtime
interface WizardGames.Soc.Share.Framework.ICustomTypeList : 
{
	
	System.Boolean ReloadData(WizardGames.Soc.Share.Framework.ListOfArrayDataSet adsList); // 0x054dec74
	WizardGames.Soc.Share.Framework.TypeBase GetCustomType(System.Int32 index); // 0x054e7c9c
	System.Void NotifyModified(System.Int32 index); // 0x055056e8
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.CustomTypeList<T> : WizardGames.Soc.Share.Framework.AbstractCustomList<T>, System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, WizardGames.Soc.Share.Framework.ICustomTypeList
{
	static System.Int32 HashValueOfT; // 0x0
	System.Void .ctor(); // 0x055049cc
	System.Void .ctor(WizardGames.Soc.Share.Framework.ListOfArrayDataSet adsList); // 0x05523a54
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x05525b70
	System.Void .ctor(SimpleJSON.JSONNode json); // 0x05523a54
	T get_Item(System.Int32 index); // 0x052af1f0
	System.Void set_Item(System.Int32 index, T value); // 0x052af1f0
	System.Void Add(T item); // 0x052af1f0
	System.Boolean Remove(T item); // 0x052af1f0
	System.Void ResetWhenDeserialize(); // 0x055049cc
	System.Void Clear(); // 0x055049cc
	System.Void RemoveAt(System.Int32 index); // 0x055056e8
	System.Boolean ReloadData(WizardGames.Soc.Share.Framework.ListOfArrayDataSet adsList); // 0x054dec74
	System.Void DeltaUpdate(WizardGames.Soc.Share.Framework.SyncUpdateContext& ctx); // 0x05523a54
	WizardGames.Soc.Share.Framework.TypeBase GetCustomType(System.Int32 index); // 0x054e7c9c
	System.Void NotifyModified(System.Int32 index); // 0x055056e8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x05525bf4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x05525b70
	System.String ToDetailedString(); // 0x054e7844
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x054e7844
	SimpleJSON.JSONNode ToEJson(); // 0x054e7844
	System.Void FromEJson(SimpleJSON.JSONNode jsonObj); // 0x05523a54
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.CustomTypeList.<>c<T> : System.Object
{
	static WizardGames.Soc.Share.Framework.CustomTypeList.<>c<T> <>9; // 0x0
	static System.Func<T,System.String> <>9__19_0; // 0x8
	static System.Void .cctor(); // 0x054fd168
	System.Void .ctor(); // 0x055049cc
	System.String <ToDetailedString>b__19_0(T item); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.CustomTypeFactoryEx : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Share.Framework.CustomTypeFactoryEx.IArrayDataSetConstructor> adsConstructorsByHash; // 0x0
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Share.Framework.CustomTypeFactoryEx.ICustomTypeDispose> DisposeByHash; // 0x8
	static System.Void RegisterArrayDataSetConstructor(System.Int32 hashCode, WizardGames.Soc.Share.Framework.CustomTypeFactoryEx.IArrayDataSetConstructor ctor); // 0x069cab28
	static WizardGames.Soc.Share.Framework.CustomTypeBase ConstructCustomTypeByHash(System.Int64 identifier, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x069cabf4
	static System.Void .cctor(); // 0x069cadf4
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.CustomTypeFactoryEx.IArrayDataSetConstructor : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x069caee4
	WizardGames.Soc.Share.Framework.CustomTypeBase Invoke(System.Int64 identifier, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x069cafac
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.CustomTypeFactoryEx.ICustomTypeDispose : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x069cb008
	System.Void Invoke(WizardGames.Soc.Common.Framework.Types.ISerializeType obj); // 0x069cb138
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.PropertyIdRegister : System.Object
{
	static System.Int32 DictInitCapacity; // 0x0
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32[]> allPropertyDict; // 0x8
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32[]> allPropertyTypeDict; // 0x10
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32[]> persistentPropertyIdsDict; // 0x18
	static System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.HashSet<System.Int32>> persistentPropertyIdSetDict; // 0x20
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32[]> ownClientPropertyDict; // 0x28
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32[]> otherClientPropertyDict; // 0x30
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32[]> clientsPropertyDict; // 0x38
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32[]> unityDsPropertyDict; // 0x40
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32[]> fieldHashValueDict; // 0x48
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Framework.Const.ESyncRange[]> syncRangeDict; // 0x50
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32[]> fieldLodArray; // 0x58
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32> classLod; // 0x60
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32> classAvailableLods; // 0x68
	static System.Collections.Generic.Dictionary<System.Int32,System.String[]> propNameDict; // 0x70
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32[]> propIndexDict; // 0x78
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32[]> refPropInfoDict; // 0x80
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32> valueTypeCount; // 0x88
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32> refTypeCount; // 0x90
	static System.Collections.Generic.Dictionary<System.Int32,System.Boolean[]> syncDelayDict; // 0x98
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32[]> servicePropertyDict; // 0xa0
	static System.Int32[] EMPTY_ARRAY; // 0xa8
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32[]> GetPropertyListFromMode(WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x069cb184
	static System.Void RegisterProperty(WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 hash, System.Int32[] propertyIds); // 0x069cb34c
	static System.Void RegisterPropertyType(System.Int32 hash, System.Int32[] propertyTypes); // 0x069cb420
	static System.Void RegisterClassInfo(System.Int32 hash, WizardGames.Soc.Common.Framework.Const.ESyncRange[] syncRangeArray, System.Int32[] fieldHashValues, System.Int32[] fieldLod); // 0x069cb4ec
	static System.Void RegisterEntityComponentLod(System.Int32 hash, System.Int32 lod, System.Int32 availableLod); // 0x069cb628
	static System.Void RegisterEntityPropName(System.Int32 hash, System.String[] propNameArray); // 0x069cb71c
	static System.Void RegisterEntityPropIndex(System.Int32 hash, System.Int32[] propIndexArray); // 0x069cb7e8
	static System.Void RegisterRefPropInfo(System.Int32 hash, System.Int32[] refPropIds); // 0x069cb8b4
	static System.Void RegisterValueTypeCount(System.Int32 hash, System.Int32 count); // 0x069cb980
	static System.Void RegisterRefTypeCount(System.Int32 hash, System.Int32 count); // 0x069cba4c
	static System.Void RegisterEntityComponentSyncDelay(System.Int32 hash, System.Boolean[] syncDelayList); // 0x069cbb18
	static System.Int32[] GetPropertyIdList(WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 hash); // 0x069cbbe4
	static System.Int32[] GetPropertyTypeList(System.Int32 hash); // 0x069cbce0
	static System.Int32[] GetFieldHashValues(System.Int32 hash); // 0x069cbe24
	static System.Boolean HasFieldArray(System.Int32 hash); // 0x069cbf68
	static System.Int32[] GetFieldLodArray(System.Int32 hash); // 0x069cc01c
	static System.String[] GetPropNameArray(System.Int32 hash); // 0x069cc160
	static System.Int32[] GetPropIndexArray(System.Int32 hash); // 0x069cc2a4
	static System.Int32[] GetRefPropInfoArray(System.Int32 hash); // 0x069cc3e8
	static System.Int32 GetValueTypeCount(System.Int32 hash); // 0x069cc52c
	static System.Int32 GetRefTypeCount(System.Int32 hash); // 0x069cc670
	static System.Int32 GetClassLod(System.Int32 hash); // 0x069cc7b4
	static System.Void .cctor(); // 0x069cc8f8
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.DeserializeTypeHelper<T> : System.Object
{
	static WizardGames.Soc.Share.Framework.DeserializeTypeHelper.DeseializeOneFunc<T> F; // 0x0
	
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.DeserializeTypeHelper.DeseializeOneFunc<T> : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05525a60
	T Invoke(MessagePack.MessagePackReader& reader); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.DeserializeHelper : System.Object
{
	
	static System.Void .cctor(); // 0x069ccf18
	static T DeseializeOne<T>(MessagePack.MessagePackReader& reader); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.DeserializeHelper.<>c : System.Object
{
	static WizardGames.Soc.Share.Framework.DeserializeHelper.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x069cd480
	System.Void .ctor(); // 0x069cd4e4
	System.Int32 <.cctor>b__0_0(MessagePack.MessagePackReader& reader); // 0x069cd54c
	System.Int64 <.cctor>b__0_1(MessagePack.MessagePackReader& reader); // 0x069cd5c8
	System.Byte <.cctor>b__0_2(MessagePack.MessagePackReader& reader); // 0x069cd644
	System.Int16 <.cctor>b__0_3(MessagePack.MessagePackReader& reader); // 0x069cd6c0
	System.Single <.cctor>b__0_4(MessagePack.MessagePackReader& reader); // 0x069cd73c
	System.Double <.cctor>b__0_5(MessagePack.MessagePackReader& reader); // 0x069cd7b8
	System.String <.cctor>b__0_6(MessagePack.MessagePackReader& reader); // 0x069cd834
	System.UInt64 <.cctor>b__0_7(MessagePack.MessagePackReader& reader); // 0x069cd8b0
	System.UInt32 <.cctor>b__0_8(MessagePack.MessagePackReader& reader); // 0x069cd92c
	System.Boolean <.cctor>b__0_9(MessagePack.MessagePackReader& reader); // 0x069cd9a8
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.ListHelper : System.Object
{
	static SocLogger logger; // 0x0
	static System.Random randomForList; // 0x8
	static System.Void SerializeBasicType<T>(System.Collections.Generic.IList<T> list, MessagePack.MessagePackWriter& writer); // 0x052af1f0
	static System.Void SerializeCore<T>(System.Collections.Generic.IList<T> list, MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 hashValueOfT); // 0x052af1f0
	static System.Void DeserializeBasicType<T>(System.Collections.Generic.List<T> list, MessagePack.MessagePackReader& reader); // 0x052af1f0
	static System.Void .cctor(); // 0x069cda24
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.DictionaryHelper : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void SerializeBasicType<TKey,TValue>(System.Collections.Generic.IDictionary<TKey,TValue> dic, MessagePack.MessagePackWriter& writer); // 0x052af1f0
	static System.Void SerializeCore<TKey,TValue>(System.Collections.Generic.IDictionary<TKey,TValue> dic, MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 hashValueOfTValue); // 0x052af1f0
	static System.Void DeserializeBasicType<TKey,TValue>(System.Collections.Generic.Dictionary<TKey,TValue> dic, MessagePack.MessagePackReader& reader); // 0x052af1f0
	static System.Void .cctor(); // 0x069cdb3c
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.HashSetHelper : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void SerializeBasicType<T>(System.Collections.Generic.ISet<T> set, MessagePack.MessagePackWriter& writer); // 0x052af1f0
	static System.Void .cctor(); // 0x069cdc10
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.QueueHelper : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void SerializeCore<T>(System.Collections.Generic.Queue<T> set, MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 hashValueOfT); // 0x052af1f0
	static System.Void .cctor(); // 0x069cdce4
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.ArrayExtensionClient : System.Object
{
	
	static T GetItem<T>(System.ArraySegment<T> array, System.Int32 index); // 0x052af1f0
	static System.Void SetItem<T>(System.ArraySegment<T> array, System.Int32 index, T value); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.NullObject : System.Object
{
	static WizardGames.Soc.Share.Framework.NullObject Instance; // 0x0
	System.Int32 Useless; // 0x10
	System.Void .ctor(); // 0x069cddb8
	static System.Void .cctor(); // 0x069cde20
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.PathPushHelper<T> : System.Object
{
	static WizardGames.Soc.Share.Framework.PathPushHelper.PathPushFunc<T> PushFunc; // 0x0
	static WizardGames.Soc.Share.Framework.PathPushHelper.ConvertFunc<T> Converter; // 0x8
	
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.PathPushHelper.PathPushFunc<T> : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05525a60
	System.Void Invoke(T path, System.Int32& pathLen, System.Nullable<System.Int64>[]& pathCache); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.PathPushHelper.ConvertFunc<T> : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05525a60
	System.Int64 Invoke(T value); // 0x052af1f0
}

// Client.Runtime
struct WizardGames.Soc.Share.Framework.LastSerializedObjectInfo : System.ValueType
{
	WizardGames.Soc.Share.Framework.TypeBase MountedObj; // 0x10
	System.Int64 EntityId; // 0x18
	System.Int32 EntityType; // 0x20
	System.Int32 ComponentHash; // 0x24
	System.Int32 ComponentId; // 0x28
	System.Nullable<System.Int64>[] Path; // 0x30
	System.Int32 PathLen; // 0x38
	
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.CustomTypeHelper : System.Object
{
	[ThreadStatic] static System.Nullable<System.Int64>[] pathCache;
	[ThreadStatic] static WizardGames.Soc.Common.Framework.FixSizeArrayWriter disposableWriter;
	[ThreadStatic] static WizardGames.Soc.Share.Framework.LastSerializedObjectInfo LastSerializedInfo;
	[ThreadStatic] static System.Boolean IsInited;
	static System.Boolean InitCustomTypeHelper(System.Int32 bufferSize); // 0x069cde84
	static System.Void .cctor(); // 0x069ce064
	static T DeserializeCustomTypeBase<T>(System.Int32 hashValue, MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x052af1f0
	static T Deserialize<T>(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 hash); // 0x052af1f0
	static WizardGames.Soc.Common.Framework.FixSizeArrayWriter GetDisposableArrayWriter(); // 0x069ce61c
	static System.Void PathPushLong(System.Int64 key, System.Int32& pathLen, System.Nullable<System.Int64>[]& pathCache); // 0x069ce6a4
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.CustomTypeHelper.<>c : System.Object
{
	static WizardGames.Soc.Share.Framework.CustomTypeHelper.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x069ce7d8
	System.Void .ctor(); // 0x069ce83c
	System.Void <.cctor>b__9_0(System.Int32 index, System.Int32& pathLen, System.Nullable<System.Int64>[]& pathCache); // 0x069ce8a4
	System.Int64 <.cctor>b__9_1(System.Int32 value); // 0x069ce964
	System.Int64 <.cctor>b__9_2(System.Int64 value); // 0x069ce9dc
	System.Void <.cctor>b__9_3(System.UInt32 index, System.Int32& pathLen, System.Nullable<System.Int64>[]& pathCache); // 0x069cea54
	System.Int64 <.cctor>b__9_4(System.UInt32 value); // 0x069ceb14
	System.Void <.cctor>b__9_5(System.UInt64 index, System.Int32& pathLen, System.Nullable<System.Int64>[]& pathCache); // 0x069ceb8c
	System.Int64 <.cctor>b__9_6(System.UInt64 value); // 0x069cec4c
	System.Void <.cctor>b__9_7(System.Int16 index, System.Int32& pathLen, System.Nullable<System.Int64>[]& pathCache); // 0x069cecc4
	System.Int64 <.cctor>b__9_8(System.Int16 value); // 0x069ced84
	System.Void <.cctor>b__9_9(System.UInt16 index, System.Int32& pathLen, System.Nullable<System.Int64>[]& pathCache); // 0x069cedfc
	System.Int64 <.cctor>b__9_10(System.UInt16 value); // 0x069ceebc
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.CustomTypeExt : System.Object
{
	
	static System.Void DeepCopyFrom<T>(T target, T data); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.JsonHelper<T> : System.Object
{
	static WizardGames.Soc.Share.Framework.JsonHelper.T2Node<T> T2NodeFunc; // 0x0
	static WizardGames.Soc.Share.Framework.JsonHelper.Node2T<T> Node2TFunc; // 0x8
	static SimpleJSON.JSONNode ToJson(T value); // 0x052af1f0
	static T FromJson(SimpleJSON.JSONNode node); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.JsonHelper.T2Node<T> : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05525a60
	SimpleJSON.JSONNode Invoke(T value); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.JsonHelper.Node2T<T> : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05525a60
	T Invoke(SimpleJSON.JSONNode node); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.SimpleCustomTypeHelper : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int32,System.Func<WizardGames.Soc.Common.SimpleCustom.IJsonSerializable>> SimpleCustomTypeConstructors; // 0x0
	static System.Collections.Generic.Dictionary<TKey,TValue> DeserializeDictionary<TKey,TValue>(System.Int32 hashValue, MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x052af1f0
	static System.Collections.Generic.Dictionary<TKey,TValue> DeserializeDictionaryBasicType<TKey,TValue>(MessagePack.MessagePackReader& reader); // 0x052af1f0
	static System.Collections.Generic.List<T> DeserializeBasicTypeList<T>(MessagePack.MessagePackReader& reader); // 0x052af1f0
	static System.Collections.Generic.List<T> DeserializeList<T>(System.Int32 hashValue, MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x052af1f0
	static System.Collections.Generic.HashSet<T> DeserializeBasicTypeHashSet<T>(MessagePack.MessagePackReader& reader); // 0x052af1f0
	static System.Byte[] Serialize<T>(T value); // 0x052af1f0
	static System.Collections.Generic.List<T> DeserializeListFromBase64<T>(System.Int32 hashValue, System.String& base64String); // 0x052af1f0
	static System.Collections.Generic.List<T> DeserializeList<T>(System.Int32 hashValue, System.ReadOnlyMemory<System.Byte> bytes); // 0x052af1f0
	static T Deserialize<T>(System.ReadOnlyMemory<System.Byte> bytes); // 0x052af1f0
	static System.Void AddConstructor(System.Int32 hash, System.Func<WizardGames.Soc.Common.SimpleCustom.IJsonSerializable> func); // 0x069cef34
	static System.Void .cctor(); // 0x069cf000
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.TimerWheelIndicator : System.Object
{
	System.Diagnostics.Stopwatch stopwatch; // 0x10
	System.UInt32 loopCount; // 0x18
	System.Int64 loopDeltaTotal; // 0x20
	System.Int64 loopDeltaMax; // 0x28
	System.Int64 loopCostTickTotal; // 0x30
	System.Int64 loopCostTickMax; // 0x38
	System.Void LoopStart(System.UInt32 delta); // 0x069cf098
	System.Int64 LoopEnd(); // 0x069cf174
	System.Void .ctor(); // 0x069cf250
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.RecordInfo : System.Object
{
	System.String Name; // 0x10
	System.UInt64 RoleId; // 0x18
	System.Int64 EntityId; // 0x20
	System.Int32 RpcVersion; // 0x28
	System.Int32 EntityVersionVerifyCode; // 0x2c
	System.Int32 RpcCustomTypeVersion; // 0x30
	System.Int32 NetworkVersion; // 0x34
	System.Int32 MapId; // 0x38
	System.Int64 StartSequence; // 0x40
	System.Int64 StartTs; // 0x48
	System.Int32 RpcCount; // 0x50
	System.String RecordFilePath; // 0x58
	System.Void .ctor(System.String name, System.UInt64 roleId, System.Int64 entityId, System.Int32 rpcVersion, System.Int32 entityVersionVerifyCode, System.Int32 rpcCustomTypeVersion, System.Int32 networkVersion, System.Int32 mapId); // 0x069cf2f0
	System.String ToString(); // 0x069cf3f0
	static WizardGames.Soc.Share.Framework.RecordInfo FromJson(SimpleJSON.JSONNode node); // 0x069cf830
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.PositionChangeEvent : System.Object
{
	
	System.Void .ctor(); // 0x069cfc0c
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.PositionSyncInfo : System.Object, WizardGames.Soc.Common.Cache.IPooledObject, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Share.Framework.PositionSyncInfo> pool; // 0x0
	static WizardGames.Soc.Share.Framework.PositionChangeEvent instance; // 0x8
	static SocLogger logger; // 0x10
	System.Single PosX; // 0x10
	System.Single PosY; // 0x14
	System.Single PosZ; // 0x18
	System.Single RotateX; // 0x1c
	System.Single RotateY; // 0x20
	System.Single RotateZ; // 0x24
	System.Int32 ClientTime; // 0x28
	System.Boolean <IsReturn>k__BackingField; // 0x2c
	static System.Int32 StaticHashValue; // 0x18
	System.Boolean get_IsReturn(); // 0x069cfc74
	System.Void set_IsReturn(System.Boolean value); // 0x069cfcd8
	static System.Void TriggerPositionChangeEvent(WizardGames.Soc.Share.Framework.EntityBase e); // 0x069cfd54
	System.Void ReturnToPool(); // 0x069cfe08
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x069cfec0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x069d0080
	System.Void .ctor(); // 0x069d015c
	static System.Void .cctor(); // 0x069d01c4
}

// Client.Runtime
struct WizardGames.Soc.Share.Framework.SinglePropChange : System.ValueType
{
	System.Int64 PropId; // 0x10
	System.Boolean IsPropIdNull; // 0x18
	System.Buffers.IMemoryOwner<System.Byte> Serialized; // 0x20
	System.Int32 SerializedLength; // 0x28
	WizardGames.Soc.Share.Framework.SyncDataValue Value; // 0x30
	System.Int32 Type; // 0x48
	
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.PropNode : System.Object, WizardGames.Soc.Common.Cache.IPooledObject
{
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Share.Framework.PropNode> pool; // 0x0
	System.Int64 Index; // 0x10
	System.Int32 Type; // 0x18
	System.Int32 ChildCount; // 0x1c
	WizardGames.Soc.Share.Framework.PropNode[] ChildNodes; // 0x20
	System.Int32 PropCount; // 0x28
	WizardGames.Soc.Share.Framework.SinglePropChange[] PropChanges; // 0x30
	System.Boolean <IsReturn>k__BackingField; // 0x38
	System.Void .ctor(); // 0x069d0350
	System.Boolean get_IsReturn(); // 0x069d0418
	System.Void set_IsReturn(System.Boolean value); // 0x069d047c
	System.Void ReturnToPool(); // 0x069d04f8
	static WizardGames.Soc.Share.Framework.PropNode Get(System.Int64 index, System.Int32 type); // 0x069d06f4
	System.String ToString(); // 0x069d07c8
	static System.Void .cctor(); // 0x069d0b18
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.EntityDeltaMsg : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.Cache.IPooledObject
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Share.Framework.EntityDeltaMsg> pool; // 0x8
	System.Int64 EntityId; // 0x10
	System.Int32 ComponentHash; // 0x18
	System.Boolean IsOwnClient; // 0x1c
	WizardGames.Soc.Share.Framework.PropNode Root; // 0x20
	System.Int32 ComponentStart; // 0x28
	System.Int32 ComponentLength; // 0x2c
	WizardGames.Soc.Share.Framework.EntityDeltaMsg.EChangeType Type; // 0x30
	System.Int32 EntityHash; // 0x34
	System.Int64 SerializedLength; // 0x38
	System.Buffers.ReadOnlySequence<System.Byte> RawData; // 0x40
	static System.Int32 StaticHashValue; // 0x10
	System.Buffers.IMemoryOwner<System.Byte> ComponentSerializedData; // 0x58
	System.Int32 ComponentSeiralizeDataLength; // 0x60
	System.Int32 DataCount; // 0x64
	System.Boolean <IsReturn>k__BackingField; // 0x68
	System.Void .ctor(); // 0x069d0bb8
	System.Boolean get_IsReturn(); // 0x069d0c20
	System.Void set_IsReturn(System.Boolean value); // 0x069d0c84
	System.Void ReturnToPool(); // 0x069d0d00
	static WizardGames.Soc.Share.Framework.EntityDeltaMsg GetFromPool(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x069d0ecc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x069d13ec
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x069d0fac
	System.Void DeserializePropNode(MessagePack.MessagePackReader& reader, WizardGames.Soc.Share.Framework.PropNode curNode, System.Int32& dataCount); // 0x069d149c
	static System.Void DeserializeBasicProp(MessagePack.MessagePackReader& reader, WizardGames.Soc.Share.Framework.SinglePropChange& prop); // 0x069d19bc
	static System.Void .cctor(); // 0x069d2444
}

// Client.Runtime
enum WizardGames.Soc.Share.Framework.EntityDeltaMsg.EChangeType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Share.Framework.EntityDeltaMsg.EChangeType None = 0;
	static WizardGames.Soc.Share.Framework.EntityDeltaMsg.EChangeType ComponentDelta = 1;
	static WizardGames.Soc.Share.Framework.EntityDeltaMsg.EChangeType ComponentAdd = 2;
	static WizardGames.Soc.Share.Framework.EntityDeltaMsg.EChangeType ComponentDel = 3;
	
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.EntityFullMsg : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.Cache.IPooledObject
{
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Share.Framework.EntityFullMsg> pool; // 0x0
	System.Int64 EntityId; // 0x10
	System.Int32 EntityLod; // 0x18
	System.Int32 DiffLod; // 0x1c
	System.Boolean IsOwnClient; // 0x20
	System.Int32 EntityHash; // 0x24
	System.Buffers.ReadOnlySequence<System.Byte> SerializeData; // 0x28
	System.Int64 SerializedLength; // 0x40
	System.Boolean <IsReturn>k__BackingField; // 0x48
	static System.Int32 StaticHashValue; // 0x8
	System.Void .ctor(); // 0x069d258c
	System.Boolean get_IsReturn(); // 0x069d25f4
	System.Void set_IsReturn(System.Boolean value); // 0x069d2658
	System.Void ReturnToPool(); // 0x069d26d4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x069d27d0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x069d2b48
	static System.Void .cctor(); // 0x069d2be8
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.DecodedEntityFullMsg : WizardGames.Soc.Share.Framework.EntityFullMsg
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Share.Framework.DecodedEntityFullMsg> pool; // 0x8
	WizardGames.Soc.Share.Framework.ArrayDataSet EntityData; // 0x50
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Share.Framework.ArrayDataSet> ComponentFullData; // 0x58
	static WizardGames.Soc.Share.Framework.DecodedEntityFullMsg GetFromPoolClient(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x069d2c9c
	static System.Void ParseFull(WizardGames.Soc.Share.Framework.ArrayDataSet& outEntityAds, System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Share.Framework.ArrayDataSet>& outComponentAds, MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 oldLods, System.Int32 diffLod); // 0x069d315c
	System.Void DeserializeClient(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x069d2d7c
	System.Void ReturnToPool(); // 0x069d364c
	System.Void .ctor(); // 0x069d3738
	static System.Void .cctor(); // 0x069d37c0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.EntityPropertyGroupData : System.Object, WizardGames.Soc.Common.Cache.IPooledObject
{
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Share.Framework.EntityPropertyGroupData> pool; // 0x0
	System.Boolean <IsReturn>k__BackingField; // 0x10
	System.Int64 EntityId; // 0x18
	WizardGames.SocConst.Soc.Const.EPropertyGroupEnum PropertyGroupEnum; // 0x20
	WizardGames.Soc.Share.Framework.Entity.PropertyGroupValue[] valTypeValues; // 0x28
	System.Boolean FullSync; // 0x30
	System.Int64 SerializedLength; // 0x38
	System.Boolean get_IsReturn(); // 0x069d38f4
	System.Void set_IsReturn(System.Boolean value); // 0x069d3958
	static WizardGames.Soc.Share.Framework.EntityPropertyGroupData Get(System.Int64 EntityId, WizardGames.SocConst.Soc.Const.EPropertyGroupEnum propertyGroupEnum); // 0x069d39d4
	System.Void ReturnToPool(); // 0x069d3aa8
	System.Void .ctor(); // 0x069d3b64
	static System.Void .cctor(); // 0x069d3bfc
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.ClientDeltaSyncMsg : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.Cache.IPooledObject
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Share.Framework.ClientDeltaSyncMsg> pool; // 0x8
	System.Collections.Generic.List<WizardGames.Soc.Share.Framework.EntityDeltaMsg> DeltaMsgList; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,System.Boolean> RemoveEntityIdDict; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent> ClientSnapshotEvents; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.Share.Framework.EntityFullMsg> FullMsgList; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.Share.Framework.EntityPropertyGroupData> PropertyGroupList; // 0x30
	System.Boolean <IsReturn>k__BackingField; // 0x38
	static System.Int32 StaticHashValue; // 0x10
	System.Boolean get_IsReturn(); // 0x069d3c9c
	System.Void set_IsReturn(System.Boolean value); // 0x069d3d00
	static WizardGames.Soc.Share.Framework.ClientDeltaSyncMsg GetFromPool(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x069d3d7c
	System.Void Reset(); // 0x069d421c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x069d438c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x069d3e5c
	System.Void ReturnToPool(); // 0x069d469c
	System.Void .ctor(); // 0x069d4864
	static System.Void .cctor(); // 0x069d4a78
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.PropertyGroupHelper : System.Object
{
	static SocLogger logger; // 0x0
	static System.Boolean Deserialize(WizardGames.SocConst.Soc.Const.EPropertyGroupEnum ePropertyGroupEnum, MessagePack.MessagePackReader& reader, WizardGames.Soc.Share.Framework.Entity.PropertyGroupValue[] result); // 0x069d443c
	static System.Void Update(WizardGames.SocConst.Soc.Const.EPropertyGroupEnum ePropertyGroupEnum, WizardGames.Soc.Share.Framework.EntityBase entity, WizardGames.Soc.Share.Framework.Entity.PropertyGroupValue[] result, System.Boolean fullSync); // 0x069d51a0
	static System.Int32 ReadIntByByte(MessagePack.MessagePackReader& reader); // 0x069d63e8
	static System.Void .cctor(); // 0x069d64fc
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.PositionPropertyGroupHelper : System.Object
{
	static SocLogger logger; // 0x0
	static System.Boolean Deserialize(MessagePack.MessagePackReader& reader, WizardGames.Soc.Share.Framework.Entity.PropertyGroupValue[] result); // 0x069d4bc0
	static System.Void Update(WizardGames.Soc.Share.Framework.EntityBase entity, WizardGames.Soc.Share.Framework.Entity.PropertyGroupValue[] result, System.Boolean fullSync); // 0x069d5440
	static System.Void .cctor(); // 0x069d65d0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Rotation3PropertyGroupHelper : System.Object
{
	static SocLogger logger; // 0x0
	static System.Boolean Deserialize(MessagePack.MessagePackReader& reader, WizardGames.Soc.Share.Framework.Entity.PropertyGroupValue[] result); // 0x069d4d5c
	static System.Void Update(WizardGames.Soc.Share.Framework.EntityBase entity, WizardGames.Soc.Share.Framework.Entity.PropertyGroupValue[] result, System.Boolean fullSync); // 0x069d592c
	static System.Void .cctor(); // 0x069d66a4
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.RotationPropertyGroupHelper : System.Object
{
	
	static System.Boolean Deserialize(MessagePack.MessagePackReader& reader, WizardGames.Soc.Share.Framework.Entity.PropertyGroupValue[] result); // 0x069d4ef8
	static System.Void Update(WizardGames.Soc.Share.Framework.EntityBase entity, WizardGames.Soc.Share.Framework.Entity.PropertyGroupValue[] result, System.Boolean fullSync); // 0x069d5dac
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.PlayerPredictPropertyGroupHelper : System.Object
{
	static SocLogger logger; // 0x0
	static System.Int32 MAX_DELTA; // 0x8
	static System.Boolean Deserialize(MessagePack.MessagePackReader& reader, WizardGames.Soc.Share.Framework.Entity.PropertyGroupValue[] result); // 0x069d5004
	static System.Void Update(WizardGames.Soc.Share.Framework.EntityBase entity, WizardGames.Soc.Share.Framework.Entity.PropertyGroupValue[] result, System.Boolean fullSync); // 0x069d5f7c
	static System.Void .cctor(); // 0x069d6778
}

// Client.Runtime
struct WizardGames.Soc.Share.Framework.SyncUpdateContext : System.ValueType
{
	WizardGames.Soc.Common.Framework.Const.ESerializeMode Mode; // 0x10
	System.Nullable<System.Int64> PropId; // 0x18
	System.Buffers.ReadOnlySequence<System.Byte> Sequence; // 0x28
	WizardGames.Soc.Share.Framework.SyncDataValue SyncValue; // 0x40
	System.Boolean IsNullValue; // 0x58
	
}

// Client.Runtime
struct WizardGames.Soc.Share.Framework.SyncDataValue : System.ValueType
{
	System.Int64 longValue; // 0x10
	System.Single floatValue; // 0x10
	System.Double doubleValue; // 0x10
	System.Boolean boolValue; // 0x10
	System.String stringValue; // 0x18
	System.Object customTypeValue; // 0x18
	System.Byte Type; // 0x20
	System.Int64 get_LongValue(); // 0x069c7f34
	System.Void set_LongValue(System.Int64 value); // 0x069d1c24
	System.Single get_FloatValue(); // 0x069c8298
	System.Void set_FloatValue(System.Single value); // 0x069d1db0
	System.Double get_DoubleValue(); // 0x069c8498
	System.Void set_DoubleValue(System.Double value); // 0x069d1f4c
	System.Boolean get_BoolValue(); // 0x069c897c
	System.Void set_BoolValue(System.Boolean value); // 0x069d20e8
	System.String get_StringValue(); // 0x069c8698
	System.Void set_StringValue(System.String value); // 0x069d2278
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.ListOfArrayDataSet : System.Object, WizardGames.Soc.Common.Cache.IPooledObject
{
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Share.Framework.ListOfArrayDataSet> pool; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.Share.Framework.ArrayDataSet> WrappedList; // 0x10
	System.Boolean <IsReturn>k__BackingField; // 0x18
	System.Boolean get_IsReturn(); // 0x069d6860
	System.Void set_IsReturn(System.Boolean value); // 0x069d68c4
	System.Void ReturnToPool(); // 0x069d6940
	static WizardGames.Soc.Share.Framework.ListOfArrayDataSet GetFromPool(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 outerHashValue); // 0x069d6f74
	System.Void .ctor(); // 0x069d73c4
	static System.Void .cctor(); // 0x069d7478
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.DictOfArrayDataSet : System.Object, WizardGames.Soc.Common.Cache.IPooledObject
{
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Share.Framework.DictOfArrayDataSet> pool; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Share.Framework.ArrayDataSet> WrappedDict; // 0x10
	System.Boolean <IsReturn>k__BackingField; // 0x18
	System.Boolean get_IsReturn(); // 0x069d7518
	System.Void set_IsReturn(System.Boolean value); // 0x069d757c
	System.Void ReturnToPool(); // 0x069d75f8
	static WizardGames.Soc.Share.Framework.DictOfArrayDataSet GetFromPool(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 outerHashValue); // 0x069d77fc
	System.Void .ctor(); // 0x069d7984
	static System.Void .cctor(); // 0x069d7a38
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.ArrayDataSet : System.Object, WizardGames.Soc.Common.Cache.IPooledObject
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Share.Framework.ArrayDataSet> pool; // 0x8
	System.Boolean <IsReturn>k__BackingField; // 0x10
	System.Int32 <HashValue>k__BackingField; // 0x14
	Share.Common.ObjPool.PropArray<WizardGames.Soc.Share.Framework.Entity.ValTypeValue> valProps; // 0x18
	Share.Common.ObjPool.PropArray<WizardGames.Soc.Share.Framework.Entity.RefTypeValue> refProps; // 0x20
	WizardGames.Soc.Share.Framework.CustomTypeBase RelatedObj; // 0x28
	System.Int32[] propertyId2Index; // 0x30
	System.Int32[] propertyIdArray; // 0x38
	System.Boolean get_IsReturn(); // 0x069d7ad8
	System.Void set_IsReturn(System.Boolean value); // 0x069d7b3c
	System.Int32 get_HashValue(); // 0x069d7bb8
	System.Void set_HashValue(System.Int32 value); // 0x069d7c1c
	System.Int32[] get_propertyTypeArray(); // 0x069d7c94
	System.Int32[] get_propertyLodArray(); // 0x069d7d68
	System.Boolean get_relateObjIsIEntity(); // 0x069d7e40
	System.Void RelateWith(WizardGames.Soc.Share.Framework.CustomTypeBase bizObj); // 0x069c1c58
	System.Int32 PropId2Type(System.Int32 propId); // 0x069d7ec8
	System.Boolean SkipProp(System.Int32 propId, System.Int32 oldLods, System.Int32 diffLod); // 0x069d7fd4
	static System.Boolean SkipProp(System.Int32[] lodArray, System.Int32 propId, System.Int32 oldLods, System.Int32 diffLod); // 0x069d8110
	System.Boolean IsInRangeLod(System.Int32 propId, System.Int32 lodLevel); // 0x069d81e4
	System.Int32 PropId2Index(System.Int32 propId); // 0x069d83ac
	static WizardGames.Soc.Share.Framework.ArrayDataSet GetFromPool(System.Int32 hashValue); // 0x069c1964
	static WizardGames.Soc.Share.Framework.ArrayDataSet GetFromPool(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 outerHashValue, System.Int32 oldLods, System.Int32 diffLod); // 0x069d3394
	static WizardGames.Soc.Share.Framework.ArrayDataSet GetFromPoolForComponent(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 outerHashValue, System.Int32 oldLods, System.Int32 diffLod, System.Int32 componentHash); // 0x069d8b1c
	static WizardGames.Soc.Share.Framework.ArrayDataSet GetFromPool(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 outerHashValue); // 0x069d7130
	static System.Void DecodeEnityOrComponentProps(WizardGames.Soc.Share.Framework.ArrayDataSet ads, MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 hashValue, System.Int32 oldLods, System.Int32 diffLod); // 0x069d8790
	static System.Void DecodeProps(WizardGames.Soc.Share.Framework.ArrayDataSet ads, MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 hashValue); // 0x069d8ec0
	static System.Void DecodePropInner(WizardGames.Soc.Share.Framework.ArrayDataSet ads, MessagePack.MessagePackReader& reader, System.Int32 propType, System.Int32 propId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 hashValue); // 0x069d91a0
	static WizardGames.Soc.Share.Framework.ArrayDataSet DecodeCustomType(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 outerHashValue); // 0x069d993c
	System.Void ReturnToPool(); // 0x069d6b38
	WizardGames.Soc.Share.Framework.ArrayDataSet ConstructorMoveEmbedded(System.Int32 propId); // 0x069d9a18
	System.Int32 GetInt(System.Int32 propId); // 0x069d9c58
	System.Int64 GetLong(System.Int32 propId); // 0x069d9d18
	System.UInt64 GetULong(System.Int32 propId); // 0x069d9dd8
	System.UInt32 GetUInt(System.Int32 propId); // 0x069d9e98
	System.Single GetFloat(System.Int32 propId); // 0x069d9f58
	System.Boolean GetBool(System.Int32 propId); // 0x069da018
	System.Byte GetByte(System.Int32 propId); // 0x069da0d8
	WizardGames.Soc.Share.Framework.Entity.UnityFixedBytes GetFixedBytes(System.Int32 propId); // 0x069c67b4
	System.String GetString(System.Int32 propId); // 0x069da198
	WizardGames.Soc.Share.Framework.TypeBase GetCustomType(System.Int32 propId); // 0x069da24c
	System.Void SetInt(System.Int32 propId, System.Int32 value); // 0x069da300
	System.Void SetLong(System.Int32 propId, System.Int64 value); // 0x069da470
	System.Void SetULong(System.Int32 propId, System.UInt64 value); // 0x069da5e0
	System.Void SetUInt(System.Int32 propId, System.UInt32 value); // 0x069da750
	System.Void SetFloat(System.Int32 propId, System.Single value); // 0x069da8c0
	System.Void SetDouble(System.Int32 propId, System.Double value); // 0x069daa44
	System.Void SetShort(System.Int32 propId, System.Int16 value); // 0x069dabc8
	System.Void SetUShort(System.Int32 propId, System.UInt16 value); // 0x069dad3c
	System.Void SetBool(System.Int32 propId, System.Boolean value); // 0x069daeb0
	System.Void SetByte(System.Int32 propId, System.Byte value); // 0x069db024
	System.Void SetFixedBytes(System.Int32 propId, WizardGames.Soc.Share.Framework.Entity.UnityFixedBytes value); // 0x069db198
	System.Void SetString(System.Int32 propId, System.String value); // 0x069db294
	System.Void SetCustomType(System.Int32 propId, WizardGames.Soc.Share.Framework.TypeBase constructed, System.Boolean invokeEmbedded); // 0x069db410
	System.Void SetCustomType(System.Int32 propId, WizardGames.Soc.Share.Framework.TypeBase constructed); // 0x069db608
	WizardGames.Soc.Share.Framework.TypeBase ReplaceCustomTypeInner(System.Int32 propId, System.Int32 propIdx, WizardGames.Soc.Share.Framework.TypeBase constructed, System.Boolean invokeEmbedded, System.Boolean attached); // 0x069db51c
	WizardGames.Soc.Share.Framework.TypeBase ReplaceCustomTypeInner(WizardGames.Soc.Share.Framework.Entity.RefTypeValue& refStruct, System.Int32 propId, WizardGames.Soc.Share.Framework.TypeBase constructed, System.Boolean invokeEmbedded, System.Boolean attached); // 0x069db8e8
	System.Void CheckEmbeddedRemove(WizardGames.Soc.Share.Framework.CustomTypeBase oldCustom); // 0x069dbb8c
	System.Void CheckEmbeddedAdd(WizardGames.Soc.Share.Framework.TypeBase newCustom); // 0x069dbdfc
	System.Void DeltaUpdateCustomType(WizardGames.Soc.Share.Framework.SyncUpdateContext& ctx); // 0x069dc05c
	System.Void DeltaUpdateBasicType(WizardGames.Soc.Share.Framework.SyncUpdateContext& ctx); // 0x069dc784
	WizardGames.Soc.Share.Framework.TypeBase ConstructorTakeOverBasicValueContainer(System.Int32 propId); // 0x069dd0d8
	WizardGames.Soc.Share.Framework.DictOfArrayDataSet ConstructorMoveCustomDictionary(System.Int32 propId); // 0x069dd334
	WizardGames.Soc.Share.Framework.ListOfArrayDataSet ConstructorMoveCustomList(System.Int32 propId); // 0x069dd580
	System.Void ConstructorSetCustomType(System.Int32 propId, WizardGames.Soc.Share.Framework.TypeBase constructed); // 0x069dd7cc
	System.Void SetCustomTypeForClone(System.Int32 propId, WizardGames.Soc.Share.Framework.TypeBase constructed); // 0x069dda98
	System.Void SetPosSyncFloatValue(System.Int32 propId, System.Single value); // 0x069ddb28
	System.Boolean UpdateFromArrayDataSet(WizardGames.Soc.Share.Framework.ArrayDataSet ads, System.Int32 oldLods, System.Int32 diffLod); // 0x069dde50
	System.Void RemoveOutOfRangeProperty(System.Int32 lodLevel); // 0x069df034
	System.Void MoveFromArrayDataSet(WizardGames.Soc.Share.Framework.ArrayDataSet ads, System.Int32 oldLods, System.Int32 diffLod); // 0x069df4f4
	System.Void UpdateFromArrayDataSetLocal(WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x069e0014
	WizardGames.Soc.Share.Framework.ArrayDataSet Clone(); // 0x069e0c48
	System.Void DeserializeNonContainerValueByJson(SimpleJSON.JSONNode jsonObj); // 0x069c3474
	SimpleJSON.JSONNode SerializeByJson(); // 0x069c2cac
	System.Void .ctor(); // 0x069e1220
	static System.Void .cctor(); // 0x069e1288
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.ComponentBasePool : System.Object
{
	static System.Collections.Generic.Stack<System.Collections.Generic.HashSet<System.Int64>> longHashSetPool; // 0x0
	static System.Collections.Generic.HashSet<System.Int64> GetLongHashSetFromPool(); // 0x069e13bc
	static System.Void ReturnLongHashSetToPool(System.Collections.Generic.HashSet<System.Int64> obj); // 0x069e14e8
	static System.Void .cctor(); // 0x069e1604
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.LodUtil : System.Object
{
	
	static System.Int32 GetAscendingLods(System.Int32 srcLod, System.Int32 targetLod); // 0x069e16a0
	static System.Int32 GetLeastSignificantBit(System.Int32 n); // 0x069e1758
	static System.Int32 GetOldLods(System.Int32 lod, System.Int32 diffLod); // 0x069e17c0
	static System.Int32 GetLods(System.Int32 old); // 0x069e18fc
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Timer.TimerBaseKit : System.Object
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,System.Action<System.Int64>> timerHandlers; // 0x10
	System.Int32 timerCountThreshold; // 0x18
	System.Int64 OwnerId; // 0x20
	WizardGames.Soc.Common.TimerWheel.TimerWheel timerWheel; // 0x28
	System.Void .ctor(WizardGames.Soc.Common.TimerWheel.TimerWheel timerWheel, System.Int64 ownerId, System.Int32 timerThreshold); // 0x069e1a20
	System.Int64 AddTimer(System.Int32 timeout, System.Int32 maxRepeat, System.Int32 interval, System.Action<System.Int64> callback, System.String filePath, System.Int32 lineNo, System.Int64 timerId, System.Int32 componentId); // 0x069e1b6c
	System.Boolean SafeCancelTimer(System.Int64& timerId); // 0x069e1f3c
	System.Void ClearTimerHandlers(); // 0x069e20c8
	static System.Void .cctor(); // 0x069e22c0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Timer.TimerBaseKit.<>c__DisplayClass6_0 : System.Object
{
	WizardGames.Soc.Share.Framework.Timer.TimerBaseKit <>4__this; // 0x10
	System.Int32 componentId; // 0x18
	System.Void .ctor(); // 0x069e1ed4
	System.Void <AddTimer>b__0(System.Int64 id, System.Object data, System.Boolean delete); // 0x069e2394
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Network.DecoderFunc : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x069e2584
	WizardGames.Soc.Share.Framework.Network.DecodedRpc Invoke(MessagePack.MessagePackReader& reader); // 0x069e265c
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Network.RpcParamPushHelper<T> : System.Object
{
	static System.Action<System.Int64[],System.Int32,T> PushFunc; // 0x0
	static System.Func<System.Int64[],System.Int32,T> GetFunc; // 0x8
	
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Network.DecodedRpcBase : System.Object, WizardGames.Soc.Common.Cache.IPooledObject
{
	static SocLogger logger; // 0x0
	System.Int32 ParamLength; // 0x10
	System.Int64[] buffer; // 0x18
	System.Object[] objRef; // 0x20
	System.Boolean <IsReturn>k__BackingField; // 0x28
	static System.Void .cctor(); // 0x069e26a8
	System.Boolean get_IsReturn(); // 0x069e30b8
	System.Void set_IsReturn(System.Boolean value); // 0x069e311c
	System.Void ReturnToPool(); // 0x055049cc
	System.Void ClearRefParams(); // 0x069e3198
	WizardGames.Soc.Share.Framework.Network.DecodedRpcBase Push<T>(T value); // 0x052af1f0
	WizardGames.Soc.Share.Framework.Network.DecodedRpcBase PushString(System.String value); // 0x069e3250
	WizardGames.Soc.Share.Framework.Network.DecodedRpcBase PushObject(System.Object obj); // 0x069e3324
	T GetParam<T>(System.Int32 index); // 0x052af1f0
	System.String GetString(System.Int32 index); // 0x069e33f8
	T GetObject<T>(System.Int32 index); // 0x052af1f0
	System.Void .ctor(); // 0x069e34c0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Network.DecodedRpcBase.<>c : System.Object
{
	static WizardGames.Soc.Share.Framework.Network.DecodedRpcBase.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x069e3588
	System.Void .ctor(); // 0x069e35ec
	System.Void <.cctor>b__0_0(System.Int64[] dst, System.Int32 offset, System.Int32 val); // 0x069e3654
	System.Void <.cctor>b__0_1(System.Int64[] dst, System.Int32 offset, System.UInt32 val); // 0x069e3708
	System.Void <.cctor>b__0_2(System.Int64[] dst, System.Int32 offset, System.Int64 val); // 0x069e37bc
	System.Void <.cctor>b__0_3(System.Int64[] dst, System.Int32 offset, System.Byte val); // 0x069e386c
	System.Void <.cctor>b__0_4(System.Int64[] dst, System.Int32 offset, System.Int16 val); // 0x069e3920
	System.Void <.cctor>b__0_5(System.Int64[] dst, System.Int32 offset, System.UInt16 val); // 0x069e39d4
	System.Void <.cctor>b__0_6(System.Int64[] dst, System.Int32 offset, System.Boolean val); // 0x069e3a88
	System.Void <.cctor>b__0_7(System.Int64[] dst, System.Int32 offset, System.UInt64 val); // 0x069e3b3c
	System.Void <.cctor>b__0_8(System.Int64[] dst, System.Int32 offset, System.Single val); // 0x069e3bec
	System.Void <.cctor>b__0_9(System.Int64[] dst, System.Int32 offset, System.Double val); // 0x069e3ca0
	System.Int32 <.cctor>b__0_10(System.Int64[] dst, System.Int32 offset); // 0x069e3d50
	System.UInt32 <.cctor>b__0_11(System.Int64[] dst, System.Int32 offset); // 0x069e3dec
	System.Int64 <.cctor>b__0_12(System.Int64[] dst, System.Int32 offset); // 0x069e3e88
	System.Byte <.cctor>b__0_13(System.Int64[] dst, System.Int32 offset); // 0x069e3f24
	System.Int16 <.cctor>b__0_14(System.Int64[] dst, System.Int32 offset); // 0x069e3fc0
	System.UInt16 <.cctor>b__0_15(System.Int64[] dst, System.Int32 offset); // 0x069e405c
	System.Boolean <.cctor>b__0_16(System.Int64[] dst, System.Int32 offset); // 0x069e40f8
	System.UInt64 <.cctor>b__0_17(System.Int64[] dst, System.Int32 offset); // 0x069e419c
	System.Single <.cctor>b__0_18(System.Int64[] dst, System.Int32 offset); // 0x069e4238
	System.Double <.cctor>b__0_19(System.Int64[] dst, System.Int32 offset); // 0x069e42d4
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Network.DecodedRpc : WizardGames.Soc.Share.Framework.Network.DecodedRpcBase
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Share.Framework.Network.DecodedRpc> pool; // 0x8
	System.Int32 MethodId; // 0x2c
	System.Int32 ComponentId; // 0x30
	System.Int64 EntityId; // 0x38
	System.Int32 NetPeerId; // 0x40
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc GetFromPool(); // 0x069e4370
	static WizardGames.Soc.Share.Framework.Network.DecodedRpc GetFromPool(System.Int64 entityId, System.Int32 componentId, System.Int32 methodId); // 0x069e442c
	System.Void ReturnToPool(); // 0x069e4508
	System.Void .ctor(); // 0x069e45c4
	static System.Void .cctor(); // 0x069e464c
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Network.RpcContext : System.Object
{
	static System.Int64 <ClientReceiveTs>k__BackingField; // 0x0
	static System.Int64 <AoiSendTs>k__BackingField; // 0x8
	static System.Int64 <GateSendTs>k__BackingField; // 0x10
	static System.Int64 get_ClientReceiveTs(); // 0x06c71c30
	static System.Void set_ClientReceiveTs(System.Int64 value); // 0x06c71ca8
	static System.Int64 get_AoiSendTs(); // 0x06c71d28
	static System.Void set_AoiSendTs(System.Int64 value); // 0x06c71da0
	static System.Int64 get_GateSendTs(); // 0x06c71e20
	static System.Void set_GateSendTs(System.Int64 value); // 0x06c71e98
}

// Client.Runtime
interface WizardGames.Soc.Share.Framework.Network.IRpcHandler : 
{
	
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Network.RpcHandlerAttribute : System.Attribute
{
	System.Single CallInterval; // 0x10
	System.Void .ctor(); // 0x06c71f18
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Event.ComponentAbilityBase<T,R> : WizardGames.Soc.Share.Framework.Event.ComponentAbilityBaseNoInput<R>
{
	T Args; // 0x0
	System.Void .ctor(T input); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Event.ComponentAbilityBaseNoInput<R> : System.Object
{
	R retVal; // 0x0
	R get_RetVal(); // 0x052af1f0
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Event.EntityEventBaseKit : WizardGames.Soc.Share.Framework.Event.EventBaseKit
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.HashSet<System.Int64>> <SubscriberEntities>k__BackingField; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.HashSet<System.Int64>> get_SubscriberEntities(); // 0x06c71f8c
	System.Void set_SubscriberEntities(System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.HashSet<System.Int64>> value); // 0x06c71ff0
	System.Void .ctor(System.Int64 ownerId); // 0x06c72070
	System.Void RemoveTargetEvent(System.Int64 targetEntityId, System.Int64 eventSeq); // 0x06c72410
	System.Void ClearEvents(); // 0x06c727cc
	static System.Void .cctor(); // 0x06c72f20
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Event.EventBaseKit : System.Object
{
	System.Int64 <OwnerId>k__BackingField; // 0x10
	WizardGames.Soc.Share.Framework.Event.EventHandlers <handlers>k__BackingField; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.HashSet<System.Int64>> <Subscribers>k__BackingField; // 0x20
	System.Void set_OwnerId(System.Int64 value); // 0x06c72ff4
	WizardGames.Soc.Share.Framework.Event.EventHandlers get_handlers(); // 0x06c7306c
	System.Void set_handlers(WizardGames.Soc.Share.Framework.Event.EventHandlers value); // 0x06c730d0
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.HashSet<System.Int64>> get_Subscribers(); // 0x06c73150
	System.Void set_Subscribers(System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.HashSet<System.Int64>> value); // 0x06c731b4
	System.Int64 AddEvent<TEventInstance>(System.Action<TEventInstance> callback); // 0x052af1f0
	System.Void RemoveEvent(System.Int64 eventSeq); // 0x06c73234
	System.Void Trigger<TEventInstance>(TEventInstance data); // 0x052af1f0
	System.Boolean HasEvent(System.Type type); // 0x06c73444
	System.Void ClearEvents(); // 0x055049cc
	System.Void RemoveTargetEvent(System.Int64 targetEntityId, System.Int64 eventSeq); // 0x05511848
	System.Void .ctor(); // 0x06c7229c
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Event.EventLinkedNode<T> : WizardGames.Soc.Common.Framework.Algorithm.LinkedNode<T>, WizardGames.Soc.Share.Framework.Event.ILinkedNode
{
	WizardGames.Soc.Common.Framework.Algorithm.SafeLinkedList<T> parent; // 0x0
	System.Void .ctor(T data, WizardGames.Soc.Common.Framework.Algorithm.SafeLinkedList<T> parent); // 0x052af1f0
	System.Void RemoveSelf(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Event.EventHandlerBase : System.Object
{
	
	System.Void .ctor(); // 0x06c735a8
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Event.EventCallBack<TEventInstance> : System.Object
{
	System.Int64 <EventSeq>k__BackingField; // 0x0
	System.Action<TEventInstance> Callback; // 0x0
	System.Void .ctor(System.Action<TEventInstance> callback); // 0x05523a54
	System.Int64 get_EventSeq(); // 0x054a4380
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Event.EventHandler<TEventInstance> : WizardGames.Soc.Share.Framework.Event.EventHandlerBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Framework.Algorithm.SafeLinkedList<WizardGames.Soc.Share.Framework.Event.EventCallBack<TEventInstance>> EventStore; // 0x0
	System.Void .ctor(); // 0x055049cc
	System.Void HandleEvent(TEventInstance data); // 0x052af1f0
	WizardGames.Soc.Share.Framework.Event.EventLinkedNode<WizardGames.Soc.Share.Framework.Event.EventCallBack<TEventInstance>> RegisterEvent(WizardGames.Soc.Share.Framework.Event.EventCallBack<TEventInstance> callback); // 0x054f9d14
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Event.EventHandlers : System.Object
{
	static SocLogger logger; // 0x0
	System.UInt32 layer; // 0x10
	System.Collections.Generic.Dictionary<System.Type,WizardGames.Soc.Share.Framework.Event.EventHandlerBase> handlers; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Share.Framework.Event.ILinkedNode> eventNodes; // 0x20
	WizardGames.Soc.Share.Framework.Event.EventHandlerBase GetEventHandler<TEventInstance>(); // 0x052af1f0
	WizardGames.Soc.Share.Framework.Event.EventHandlerBase GetEventHandler(System.Type inType); // 0x06c73610
	WizardGames.Soc.Share.Framework.Event.EventLinkedNode<WizardGames.Soc.Share.Framework.Event.EventCallBack<TEventInstance>> AddEventInner<TEventInstance>(System.Action<TEventInstance> callback); // 0x052af1f0
	System.Int64 AddEvent<TEventInstance>(System.Action<TEventInstance> callback); // 0x052af1f0
	System.Boolean HasEvent(System.Type type); // 0x06c7350c
	System.Void RemoveEvent(System.Int64 eventSeq); // 0x06c732fc
	System.Void Trigger<TEventInstance>(TEventInstance data); // 0x052af1f0
	System.Void ClearEvents(); // 0x06c72cdc
	System.Void .ctor(); // 0x06c72304
	static System.Void .cctor(); // 0x06c736c4
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Event.EventAttribute : System.Attribute
{
	
	System.Void .ctor(); // 0x06c73798
}

// Client.Runtime
interface WizardGames.Soc.Share.Framework.Event.ILinkedNode : 
{
	
	System.Void RemoveSelf(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Event.EntityStaticCallback<T> : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Framework.Algorithm.BaseLinkedNode> staticCallbacks; // 0x8
	static System.Void AddStaticCallback<TEvent>(WizardGames.Soc.Share.Framework.Event.EntityStaticCallback.EntityCallbackFunc<T,TEvent> func); // 0x052af1f0
	static System.Void InvokeStaticCallback<TEvent>(T entity, TEvent eventInstance); // 0x052af1f0
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Event.EntityStaticCallback.EntityCallbackFunc<T,TEvent> : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05525a60
	System.Void Invoke(T instance, TEvent eventData); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Event.EntityStaticCallback.CallbackHandlerClass<T,TEvent> : WizardGames.Soc.Common.Framework.Algorithm.BaseLinkedNode
{
	WizardGames.Soc.Share.Framework.Event.EntityStaticCallback.EntityCallbackFunc<T,TEvent> callback; // 0x0
	System.Void .ctor(WizardGames.Soc.Share.Framework.Event.EntityStaticCallback.EntityCallbackFunc<T,TEvent> cb); // 0x05523a54
	System.Void HandleEvent(T entity, TEvent eventData); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Entity.Sync : System.Object
{
	static SocLogger Logger; // 0x0
	static System.Void .cctor(); // 0x06c73800
}

// Client.Runtime
struct WizardGames.Soc.Share.Framework.Entity.PropertyGroupValue : System.ValueType
{
	System.Int32 IntValue; // 0x10
	System.Int64 LongValue; // 0x10
	System.UInt64 ULongValue; // 0x10
	System.UInt32 UIntValue; // 0x10
	System.Single FloatValue; // 0x10
	System.Double DoubleValue; // 0x10
	System.Int16 ShortValue; // 0x10
	System.UInt16 UShortValue; // 0x10
	System.Boolean BoolValue; // 0x10
	System.Byte ByteValue; // 0x10
	
}

// Client.Runtime
struct WizardGames.Soc.Share.Framework.Entity.ValTypeValue : System.ValueType
{
	System.Int32 intValue; // 0x10
	System.Int64 longValue; // 0x10
	System.UInt64 uLongValue; // 0x10
	System.UInt32 uIntValue; // 0x10
	System.Single floatValue; // 0x10
	System.Double doubleValue; // 0x10
	System.Int16 shortValue; // 0x10
	System.UInt16 uShortValue; // 0x10
	System.Boolean boolValue; // 0x10
	System.Byte byteValue; // 0x10
	System.Byte Type; // 0x18
	System.Int32 get_IntValue(); // 0x06c738d4
	System.Void set_IntValue(System.Int32 value); // 0x06c73a50
	System.Int64 get_LongValue(); // 0x06c73bdc
	System.Void set_LongValue(System.Int64 value); // 0x06c73d58
	System.UInt64 get_ULongValue(); // 0x06c73ee4
	System.Void set_ULongValue(System.UInt64 value); // 0x06c74060
	System.UInt32 get_UIntValue(); // 0x06c741ec
	System.Void set_UIntValue(System.UInt32 value); // 0x06c74368
	System.Single get_FloatValue(); // 0x06c744f4
	System.Void set_FloatValue(System.Single value); // 0x06c7467c
	System.Double get_DoubleValue(); // 0x06c74818
	System.Void set_DoubleValue(System.Double value); // 0x06c749a0
	System.Int16 get_ShortValue(); // 0x06c74b3c
	System.Void set_ShortValue(System.Int16 value); // 0x06c74cb4
	System.UInt16 get_UShortValue(); // 0x06c74e40
	System.Void set_UShortValue(System.UInt16 value); // 0x06c74fb8
	System.Boolean get_BoolValue(); // 0x06c75144
	System.Void set_BoolValue(System.Boolean value); // 0x06c752bc
	System.Byte get_ByteValue(); // 0x06c7544c
	System.Void set_ByteValue(System.Byte value); // 0x06c755c8
}

// Client.Runtime
struct WizardGames.Soc.Share.Framework.Entity.RefTypeValue : System.ValueType
{
	System.String stringValue; // 0x10
	WizardGames.Soc.Share.Framework.TypeBase customTypeValue; // 0x10
	WizardGames.Soc.Share.Framework.Entity.UnityFixedBytes fixedBytes; // 0x10
	System.Object arrayDataSetValue; // 0x10
	System.Byte Type; // 0x18
	System.String get_StringValue(); // 0x06c75754
	System.Void set_StringValue(System.String value); // 0x06c758cc
	WizardGames.Soc.Share.Framework.TypeBase get_CustomTypeValue(); // 0x06c75a88
	System.Void set_CustomTypeValue(WizardGames.Soc.Share.Framework.TypeBase value); // 0x06c75c00
	WizardGames.Soc.Share.Framework.Entity.UnityFixedBytes get_FixedBytes(); // 0x06c75dbc
	System.Void set_FixedBytes(WizardGames.Soc.Share.Framework.Entity.UnityFixedBytes value); // 0x06c75f34
	System.Object get_ArrayDataSetValue(); // 0x06c760f0
	System.Void set_ArrayDataSetValue(System.Object value); // 0x06c76268
}

// Client.Runtime
class WizardGames.Soc.Share.Framework.Entity.UnityFixedBytes : System.Object, System.IDisposable, System.Buffers.IBufferWriter<System.Byte>
{
	WizardGames.Soc.Common.Framework.FixSizeArrayWriter writer; // 0x10
	System.Boolean isMutable; // 0x18
	System.Boolean get_IsMutable(); // 0x06c76424
	System.Void SetUnmutable(); // 0x06c76488
	System.Void .ctor(System.Int32 segmentSize); // 0x06c764ec
	System.Void .ctor(MessagePack.MessagePackReader& reader); // 0x06c765b0
	System.Buffers.ReadOnlySequence<System.Byte> GetSequence(); // 0x06c767d4
	System.Void Dispose(); // 0x06c7685c
	System.Void Advance(System.Int32 count); // 0x06c768dc
	System.Memory<System.Byte> GetMemory(System.Int32 sizeHint); // 0x06c769b4
	System.Span<System.Byte> GetSpan(System.Int32 sizeHint); // 0x06c76a8c
}

// Client.Runtime
class WizardGames.Soc.Share.ClassDef.ClassMetaInfo : System.Object
{
	static System.Collections.Generic.IReadOnlyDictionary<System.Int32,System.Int32> ComponentHashToId; // 0x0
	static System.Collections.Generic.IReadOnlyDictionary<System.Int32,WizardGames.Soc.Share.Framework.DeserializeCustomContainerFunc> DeserializeCustomContainerFuncs; // 0x8
	static System.Void .cctor(); // 0x06c76b64
}

// Client.Runtime
class WizardGames.Soc.SocSimulator.PropModifyDict : System.Object
{
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocSimulator.PropModifySet> proertyModifyDict; // 0x10
	System.Void .ctor(); // 0x06c7c5d4
}

// Client.Runtime
class WizardGames.Soc.SocSimulator.PropModifyRequest : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.Int64 <TargetId>k__BackingField; // 0x10
	System.Single <Amount>k__BackingField; // 0x18
	System.Boolean <IsSet>k__BackingField; // 0x1c
	System.Void set_TargetId(System.Int64 value); // 0x06c7c7c0
	System.Void set_Amount(System.Single value); // 0x06c7c838
	System.Void set_IsSet(System.Boolean value); // 0x06c7c8b0
	System.Void OnGet(); // 0x06c7c92c
	System.Void OnRelease(); // 0x06c7c98c
	System.Void OnDestroy(); // 0x06c7cadc
}

// Client.Runtime
class WizardGames.Soc.SocSimulator.PropModifySet : System.Object
{
	System.Collections.Generic.Queue<WizardGames.Soc.SocSimulator.PropModifyRequest> propertyModifySet; // 0x10
	System.Void .ctor(); // 0x06c7c70c
}

// Client.Runtime
class WizardGames.Soc.SocSimulator.TargetHpComp : UnityEngine.MonoBehaviour
{
	System.Single timeToRevive; // 0x30
	System.Single rotateX; // 0x34
	System.Void .ctor(); // 0x06c7cb3c
}

// Client.Runtime
class WizardGames.Soc.SocSimulator.TargetMoveComp : UnityEngine.MonoBehaviour
{
	System.Single moveSpeed; // 0x30
	UnityEngine.Vector3 localAPos; // 0x34
	UnityEngine.Vector3 localBPos; // 0x40
	WizardGames.Soc.Common.Unity.Go.BaseTargetGo baseTargetGo; // 0x50
	WizardGames.Soc.Common.Entity.TargetEntity targetEntity; // 0x58
	WizardGames.Soc.Common.Component.DamageableComponent dc; // 0x60
	System.Boolean isOn; // 0x68
	UnityEngine.Vector3 initPos; // 0x6c
	System.Single moveToATime; // 0x78
	System.Single moveToBTime; // 0x7c
	System.Single curMoveToTime; // 0x80
	System.Boolean isMoveToA; // 0x84
	System.Void Init(WizardGames.Soc.Common.Unity.Go.BaseTargetGo btg, WizardGames.Soc.Common.Entity.TargetEntity te); // 0x06c7cbb0
	System.Void Clean(); // 0x06c7cf34
	System.Boolean IsActive(); // 0x06c7d020
	System.Void DoUpdate(System.Int32 deltaTime); // 0x06c7d0bc
	System.Void .ctor(); // 0x06c7d2d0
}

// Client.Runtime
enum WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.PhysicsShapeType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.PhysicsShapeType Sphere = 0;
	static WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.PhysicsShapeType Box = 1;
	static WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.PhysicsShapeType Capsule = 2;
	static WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.PhysicsShapeType Ray = 3;
	
}

// Client.Runtime
struct WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.CastPhysicsCommandData : System.ValueType
{
	UnityEngine.Vector3 position; // 0x10
	UnityEngine.Quaternion rotation; // 0x1c
	UnityEngine.Vector3 direction; // 0x2c
	System.Single distance; // 0x38
	System.Single radius; // 0x3c
	UnityEngine.Vector3 boundsExtents; // 0x40
	UnityEngine.Vector3 point0; // 0x4c
	UnityEngine.Vector3 point1; // 0x58
	System.Int32 layerMask; // 0x64
	UnityEngine.QueryTriggerInteraction hitTriggers; // 0x68
	WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.PhysicsShapeType shapeType; // 0x6c
	System.Int32 index; // 0x70
	
}

// Client.Runtime
struct WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.OverlapPhysicsCommandData : System.ValueType
{
	UnityEngine.Vector3 position; // 0x10
	UnityEngine.Quaternion rotation; // 0x1c
	System.Single radius; // 0x2c
	UnityEngine.Vector3 boundsExtents; // 0x30
	UnityEngine.Vector3 point0; // 0x3c
	UnityEngine.Vector3 point1; // 0x48
	System.Int32 layerMask; // 0x54
	UnityEngine.QueryTriggerInteraction hitTriggers; // 0x58
	WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.PhysicsShapeType shapeType; // 0x5c
	System.Int32 index; // 0x60
	
}

// Client.Runtime
struct WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.SortCastPhysicsCommandsJob : System.ValueType, Unity.Jobs.IJob
{
	Unity.Collections.NativeArray<WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.CastPhysicsCommandData> physicsCommandDatas; // 0x10
	Unity.Collections.NativeArray<System.Int32> sortedIndices; // 0x20
	System.Void Execute(); // 0x06c7d35c
}

// Client.Runtime
struct WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.SortOverlapPhysicsCommandsJob : System.ValueType, Unity.Jobs.IJob
{
	Unity.Collections.NativeArray<WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.OverlapPhysicsCommandData> physicsCommandDatas; // 0x10
	Unity.Collections.NativeArray<System.Int32> sortedIndices; // 0x20
	System.Void Execute(); // 0x06c7d490
}

// Client.Runtime
struct WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.FillPhysicsCastCommandsJob : System.ValueType, Unity.Jobs.IJobParallelFor
{
	Unity.Collections.NativeArray<WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.CastPhysicsCommandData> physicsCommandDatas; // 0x10
	Unity.Collections.NativeArray<UnityEngine.SpherecastCommand> spherecastCommands; // 0x20
	Unity.Collections.NativeArray<UnityEngine.BoxcastCommand> boxcastCommands; // 0x30
	Unity.Collections.NativeArray<UnityEngine.CapsulecastCommand> capsulecastCommands; // 0x40
	Unity.Collections.NativeArray<UnityEngine.RaycastCommand> raycastCommands; // 0x50
	System.Void Execute(System.Int32 index); // 0x06c7d5b0
}

// Client.Runtime
struct WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.FillRayCastCommandsJob : System.ValueType, Unity.Jobs.IJobParallelFor
{
	Unity.Collections.NativeList<WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.CastPhysicsCommandData> physicsCommandDatas; // 0x10
	Unity.Collections.NativeArray<UnityEngine.RaycastCommand> raycastCommands; // 0x18
	System.Void Execute(System.Int32 index); // 0x06c7d87c
}

// Client.Runtime
struct WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.ResolveNearestHitJob : System.ValueType, Unity.Jobs.IJobParallelFor
{
	Unity.Collections.NativeArray<UnityEngine.RaycastHit> results; // 0x10
	Unity.Collections.NativeArray<UnityEngine.RaycastHit> nearestDistanceResults; // 0x20
	System.Int32 maxHits; // 0x30
	System.Void Execute(System.Int32 index); // 0x06c7d9ac
}

// Client.Runtime
struct WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.FillPhysicsOverlapCommandsJob : System.ValueType, Unity.Jobs.IJobParallelFor
{
	Unity.Collections.NativeArray<WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.OverlapPhysicsCommandData> physicsCommandDatas; // 0x10
	Unity.Collections.NativeArray<UnityEngine.OverlapCapsuleCommand> overlapCapsuleCommands; // 0x20
	Unity.Collections.NativeArray<UnityEngine.OverlapBoxCommand> overlapBoxCommands; // 0x30
	Unity.Collections.NativeArray<UnityEngine.OverlapSphereCommand> overlapSphereCommands; // 0x40
	System.Void Execute(System.Int32 index); // 0x06c7dc4c
}

// Client.Runtime
struct WizardGames.Soc.SocSimulator.CommonUnity.Runtime.Utility.RaycastResultEnumerator : System.ValueType
{
	Unity.Collections.NativeArray<UnityEngine.RaycastHit> results; // 0x10
	System.Int32 startingIndex; // 0x20
	System.Int32 maxHits; // 0x24
	System.Int32 localIndex; // 0x28
	System.Void .ctor(Unity.Collections.NativeArray<UnityEngine.RaycastHit>& results, System.Int32 raycastIndex, System.Int32 maxHits); // 0x06c7dac4
	System.Boolean HasNextHit(UnityEngine.RaycastHit& hit); // 0x06c7db68
}

// Client.Runtime
class WizardGames.Soc.SocSimulator.Buff.BuffItem : System.Object
{
	WizardGames.Soc.Common.CustomType.Alpha3BuffData BuffData; // 0x10
	WizardGames.Soc.Common.Data.Combat.BuffTable BuffTable; // 0x18
	Effect.EffectItemHandle<Effect.FollowEffect> followEffectHandle; // 0x20
	System.Boolean NeedRelease(); // 0x06c7de70
	System.Void OnUpdate(System.Int32 deltaTime); // 0x06c7df30
	System.Void OnDestroy(); // 0x06c7e2b0
	System.Void PlayLifeCycleActions(System.Int32 liftCycle); // 0x06c7dfac
	System.Void OnRelease(); // 0x06c7e320
	System.Void .ctor(); // 0x06c7e440
}

// Client.Runtime
class WizardGames.Soc.SocSimulator.Buff.MgrBuff : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Log; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocSimulator.Buff.BuffItem>> EntityBuffMap; // 0x18
	System.Action<WizardGames.Soc.SocSimulator.Buff.BuffItem> OnLocalPlayerAddBuff; // 0x20
	System.Action<WizardGames.Soc.SocSimulator.Buff.BuffItem> OnLocalPlayerRemoveBuff; // 0x28
	System.Action<WizardGames.Soc.SocSimulator.Buff.BuffItem> OnLocalPlayerUpdateBuff; // 0x30
	System.Void Init(); // 0x06c7e4a8
	System.Void RemoveBuff(WizardGames.Soc.Common.CustomType.Alpha3BuffData buffData); // 0x06c7e5fc
	System.Void ClearEntityBuffs(System.Int64 entityId); // 0x06c7e7c4
	System.Void OnEntityRemove(WizardGames.Soc.Common.Entity.IEntity obj); // 0x06c7ea04
	System.Void .ctor(); // 0x06c7eb2c
	static System.Void .cctor(); // 0x06c7ebe0
}

// Client.Runtime
class WizardGames.Soc.Bridge.MgrSocShaderBridge : WizardGames.Soc.Common.Unity.Utility.MgrShaderInterface
{
	
	System.Void RegisterOnInit(); // 0x06c7ecb4
	System.Void RegisterOnEnterWorld(); // 0x06c7ed14
	System.Void .ctor(); // 0x06c7ef40
}

// Client.Runtime
class WizardGames.Soc.Common.BiomeData : WizardGames.Soc.Common.TerrainMap<System.Byte>
{
	static SocLogger logger; // 0x0
	UnityEngine.Texture2D BiomeTexture; // 0x48
	System.Int32 num; // 0x50
	System.Void Setup(); // 0x06c7efa8
	System.Void Awake(); // 0x06c7f324
	System.Single GetBiomeMax(UnityEngine.Vector3 worldPos, System.Int32 mask); // 0x06c7f388
	System.Single GetBiomeMax(System.Single normX, System.Single normZ, System.Int32 mask); // 0x06c7f6b0
	System.Single GetBiomeMax(System.Int32 x, System.Int32 z, System.Int32 mask); // 0x06c7f81c
	System.Int32 GetBiomeMaxIndex(UnityEngine.Vector3 worldPos, System.Int32 mask); // 0x06c7f9b8
	System.Int32 GetBiomeMaxIndex(System.Single normX, System.Single normZ, System.Int32 mask); // 0x06c7fa80
	System.Int32 GetBiomeMaxIndex(System.Int32 x, System.Int32 z, System.Int32 mask); // 0x06c7fb3c
	System.Int32 GetBiomeMaxType(UnityEngine.Vector3 worldPos, System.Int32 mask); // 0x06c7fc80
	System.Int32 GetBiomeMaxType(System.Single normX, System.Single normZ, System.Int32 mask); // 0x06c7fd6c
	System.Int32 GetBiomeMaxType(System.Int32 x, System.Int32 z, System.Int32 mask); // 0x06c7fe40
	System.Single GetBiome(UnityEngine.Vector3 worldPos, System.Int32 mask); // 0x06c7ff14
	System.Single GetBiome(System.Single normX, System.Single normZ, System.Int32 mask); // 0x06c7ffdc
	static System.Single Byte2Float(System.Int32 b); // 0x06c80288
	System.Single GetBiome(System.Int32 x, System.Int32 z, System.Int32 mask); // 0x06c80098
	System.Void GetBiomeMax2(UnityEngine.Vector3 worldPos, System.Int32& typeIndex0, System.Int32& typeIndex1, System.Single& proportion); // 0x06c803ac
	System.Void SetBiome(UnityEngine.Vector3 worldPos, System.Int32 id); // 0x06c80520
	System.Void SetBiome(System.Single normX, System.Single normZ, System.Int32 id); // 0x06c805e8
	System.Void SetBiome(System.Int32 x, System.Int32 z, System.Int32 id); // 0x06c806a4
	System.Void .ctor(); // 0x06c807e0
	static System.Void .cctor(); // 0x06c8085c
}

// Client.Runtime
class WizardGames.Soc.Common.TerrainBiome : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32> type2index; // 0x0
	static System.Int32 TypeToIndex(System.Int32 id); // 0x06c802f8
	static System.Int32 IndexToType(System.Int32 idx); // 0x06c7f950
	static System.Void .cctor(); // 0x06c80930
}

// Client.Runtime
class WizardGames.Soc.Common.ProceduralData : UnityEngine.MonoBehaviour
{
	static UnityEngine.Vector3 <Position>k__BackingField; // 0x0
	static UnityEngine.Vector3 <OneOverSize>k__BackingField; // 0xc
	static UnityEngine.Terrain <Terrain>k__BackingField; // 0x18
	UnityEngine.Vector3 size; // 0x30
	static UnityEngine.Vector3 <Size>k__BackingField; // 0x20
	static WizardGames.Soc.Common.BiomeData <BiomeMap>k__BackingField; // 0x30
	static UnityEngine.Vector3 get_Position(); // 0x06c80a2c
	static System.Void set_Position(UnityEngine.Vector3 value); // 0x06c80aa4
	static UnityEngine.Vector3 get_OneOverSize(); // 0x06c80b50
	static System.Void set_OneOverSize(UnityEngine.Vector3 value); // 0x06c80bc8
	static UnityEngine.Terrain get_Terrain(); // 0x06c80c74
	static System.Void set_Terrain(UnityEngine.Terrain value); // 0x06c80cec
	static UnityEngine.Vector3 get_Size(); // 0x06c80d70
	static System.Void set_Size(UnityEngine.Vector3 value); // 0x06c80de8
	static WizardGames.Soc.Common.BiomeData get_BiomeMap(); // 0x06c80e94
	static System.Void set_BiomeMap(WizardGames.Soc.Common.BiomeData value); // 0x06c80f0c
	System.Void Start(); // 0x06c80f90
	static System.Single NormalizeX(System.Single x); // 0x06c7f450
	static System.Single NormalizeY(System.Single y); // 0x06c812a4
	static System.Single NormalizeZ(System.Single z); // 0x06c7f580
	System.Void Init(); // 0x06c80ff4
	System.Void .ctor(); // 0x06c813d4
}

// Client.Runtime
class WizardGames.Soc.Common.TerrainMap : UnityEngine.MonoBehaviour
{
	System.Int32 res; // 0x30
	System.Int32 Index(System.Single normalized); // 0x06c7f76c
	System.Single Coordinate(System.Int32 index); // 0x06c8143c
	System.Void .ctor(); // 0x06c814c8
}

// Client.Runtime
class WizardGames.Soc.Common.TerrainMap<T> : WizardGames.Soc.Common.TerrainMap
{
	T[] src; // 0x0
	T[] dst; // 0x0
	System.Void Push(); // 0x055049cc
	System.Void Pop(); // 0x055049cc
	System.Collections.Generic.IEnumerable<T> ToEnumerable(); // 0x054e7844
	System.Int32 BytesPerElement(); // 0x0548ba98
	System.Int64 GetMemoryUsage(); // 0x054a4380
	System.Byte[] ToByteArray(); // 0x054e7844
	System.Void FromByteArray(System.Byte[] dat); // 0x05523a54
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.SocGibConfig : UnityEngine.ScriptableObject
{
	System.String GibsPrefab; // 0x18
	UnityEngine.Material GibRustMaterial; // 0x20
	System.String MaterialHpParamName; // 0x28
	System.String SpecializedVehicleDestroying; // 0x30
	System.Collections.Generic.List<System.String> MaterialCopyFloatParamNames; // 0x38
	System.Int32 maxGibDist; // 0x40
	System.Int32 minGibLife; // 0x44
	System.Int32 maxGibLife; // 0x48
	System.Void .ctor(); // 0x06c81530
}

// Client.Runtime
class WizardGames.Soc.Common.SpecializedVehicle : UnityEngine.MonoBehaviour, IEngineControllerUser
{
	UnityEngine.WheelCollider frontLeftWheel; // 0x30
	UnityEngine.WheelCollider frontRightWheel; // 0x38
	UnityEngine.WheelCollider backLeftWheel; // 0x40
	UnityEngine.WheelCollider backRightWheel; // 0x48
	System.Single frontLeftRotationSpeed; // 0x50
	UnityEngine.Transform frontLeftWheelTrans; // 0x58
	System.Single frontRightRotationSpeed; // 0x60
	UnityEngine.Transform frontRightWheelTrans; // 0x68
	System.Single wheelRadius; // 0x70
	System.Single backLeftRotationSpeed; // 0x74
	UnityEngine.Transform backLeftWheelTrans; // 0x78
	System.Single backRightRotationSpeed; // 0x80
	UnityEngine.Transform backRightWheelTrans; // 0x88
	WizardGames.Soc.Common.Unity.Go.IEntityGo OwnerEntityGo; // 0x90
	UnityEngine.Quaternion FrontLeftWheelRelativeRotation; // 0x98
	UnityEngine.Quaternion FrontRightWheelRelativeRotation; // 0xa8
	System.Collections.Generic.Dictionary<UnityEngine.Material,System.Single> _materialToOriginalDetailNormalScale; // 0xb8
	UnityEngine.Animation animation; // 0xc0
	WizardGames.Soc.Common.SpecializedVehicle.CoverInfo[] CoverInfos; // 0xc8
	System.Boolean HasFlag(BaseRustEntity.Flags f); // 0x06c816ac
	System.Boolean IsDead(); // 0x06c81724
	System.Void Awake(); // 0x06c81788
	System.Void Update(); // 0x06c81cf8
	System.Void OnEngineStart(); // 0x06c81d58
	System.Void OnEngineStop(); // 0x06c81e90
	System.Void OnEngineStartFailed(); // 0x06c82000
	System.Boolean MeetsEngineRequirements(); // 0x06c82060
	System.Boolean EngineIsAlive(); // 0x06c820c4
	System.Void SetDestroying(); // 0x06c82128
	System.Void SpecializedVehicleResume(); // 0x06c8235c
	System.Void .ctor(); // 0x06c8259c
}

// Client.Runtime
class WizardGames.Soc.Common.SpecializedVehicle.CoverInfo : System.Object
{
	UnityEngine.Transform position; // 0x10
	System.Single coverDot; // 0x18
	System.Void .ctor(); // 0x06c8269c
}

// Client.Runtime
class WizardGames.Soc.Common.Data.Ui.TbHudUtils : System.Object
{
	
	static System.Collections.Generic.IReadOnlyList<WizardGames.Soc.Common.Data.Ui.Hud> GetDataList(WizardGames.Soc.Common.Data.Ui.TbHud tbHud); // 0x06c8270c
	static WizardGames.Soc.Common.Data.Ui.Hud GetItem(WizardGames.Soc.Common.Data.Ui.TbHud tbHud, System.Int32 key); // 0x06c82778
}

// Client.Runtime
class WizardGames.Soc.Common.UtcTime.NowTimeHelper : System.Object
{
	static WizardGames.Soc.Common.UtcTime.NowTimeHelper.GetNowTime getMSec; // 0x0
	static WizardGames.Soc.Common.UtcTime.NowTimeHelper.GetNowTime getSec; // 0x8
	static System.Int32 GetNowSec(); // 0x06c82800
	static System.Void .cctor(); // 0x06c828c0
}

// Client.Runtime
class WizardGames.Soc.Common.UtcTime.NowTimeHelper.GetNowTime : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x06c829e0
	System.Int64 Invoke(); // 0x06c82aa4
}

// Client.Runtime
class WizardGames.Soc.Common.UtcTime.NowTimeHelper.<>c : System.Object
{
	static WizardGames.Soc.Common.UtcTime.NowTimeHelper.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x06c82ae8
	System.Void .ctor(); // 0x06c82b4c
	System.Int64 <.cctor>b__6_0(); // 0x06c82bb4
	System.Int64 <.cctor>b__6_1(); // 0x06c82c3c
}

// Client.Runtime
class WizardGames.Soc.Common.RuleGraph.GraphUtils : System.Object
{
	static SocLogger logger; // 0x0
	static System.Text.StringBuilder builder; // 0x8
	static WizardGames.Soc.Common.CustomType.GraphContextSync GetGraphContext(System.Int64 entityId); // 0x06c82ccc
	static WizardGames.Soc.Common.CustomType.PgcGraphDataHost GetGraphContextDataHost(System.Int64 entityId); // 0x06c82e08
	static WizardGames.Soc.Common.Component.RuleGraphComponent GetGraphComponent(System.Int64 entityId); // 0x06c82f50
	static System.Collections.Generic.List<T> ToSimpleType<T>(WizardGames.Soc.Share.Framework.BasicTypeList<T> source); // 0x052af1f0
	static System.Collections.Generic.List<TSimple> ToSimpleType<TCustom,TSimple>(WizardGames.Soc.Share.Framework.CustomTypeList<TCustom> source); // 0x052af1f0
	static System.Void .cctor(); // 0x06c8307c
}

// Client.Runtime
interface WizardGames.Soc.Common.RuleGraph.IConvert<TCustom> : 
{
	
	System.Void CopyFrom(TCustom t); // 0x052af1f0
}

// Client.Runtime
interface WizardGames.Soc.Common.RuleGraph.IGraphContainer : 
{
	
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x054e7844
}

// Client.Runtime
class WizardGames.Soc.Common.RuleGraph.ClientGraphNodeAttribute : System.Attribute
{
	WizardGames.Soc.Common.RuleGraph.ENodeType NodeType; // 0x10
	System.Void .ctor(); // 0x06c83194
}

// Client.Runtime
class WizardGames.Soc.Common.RuleGraph.GraphTypeAttribute : System.Attribute
{
	System.Boolean NeedGenerate; // 0x10
	System.Boolean AsListItem; // 0x11
	System.Boolean AsDictItem; // 0x12
	System.Void .ctor(); // 0x06c83204
}

// Client.Runtime
enum WizardGames.Soc.Common.RuleGraph.ENodeType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.RuleGraph.ENodeType Event = 0;
	static WizardGames.Soc.Common.RuleGraph.ENodeType Control = 1;
	static WizardGames.Soc.Common.RuleGraph.ENodeType Action = 2;
	static WizardGames.Soc.Common.RuleGraph.ENodeType Async = 3;
	static WizardGames.Soc.Common.RuleGraph.ENodeType Value = 4;
	static WizardGames.Soc.Common.RuleGraph.ENodeType ClientAction = 5;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Team.TeamMemberDuty : System.Object
{
	static System.Int32 HandOverLeader; // 0x0
	static System.Int32 ChangeDuty; // 0x4
	static System.Int32 KickTeamMember; // 0x8
	static System.Int32 InviteTeamMember; // 0xc
	static System.Int32 MaxTeamMemberDuty; // 0x10
	static System.Int32 HandOverLeaderValue; // 0x14
	static System.Int32 ChangeDutyValue; // 0x18
	static System.Int32 KickTeamMemberValue; // 0x1c
	static System.Int32 InviteTeamMemberValue; // 0x20
	static System.Int32 TeamLeaderDutyValue; // 0x24
	static System.Int32 TeamMemberChangedDutyValue; // 0x28
	static System.Void .cctor(); // 0x06c8327c
}

// Client.Runtime
class WizardGames.Soc.Common.Play.PlayHelper : System.Object
{
	static SocLogger logger; // 0x0
	static System.Int32 battleId; // 0x8
	static WizardGames.Soc.Common.Data.EServerInitType InitType; // 0xc
	static System.Int32 Battle2PlayExchangeFactor; // 0x10
	static System.Int32 get_BattleId(); // 0x06c832e8
	static System.Void set_BattleId(System.Int32 value); // 0x06c83370
	static System.Boolean get_IsReputationPlay(); // 0x06c835c0
	static System.Boolean get_IsNewbie(); // 0x06c83694
	static System.Boolean get_IsBombHome(); // 0x06c83724
	static System.Boolean get_IsNewbieTeaching(); // 0x06c837b4
	static System.Int32 GetPlayId(); // 0x06c834cc
	static System.Int32 GetPlayId(System.Int32 battleId); // 0x06c8383c
	static System.Int32 GetPlayCampUniqueId(System.Int32 campId); // 0x06c838d0
	static System.Boolean get_EnableSleepBagReborn(); // 0x06c839cc
	static System.Boolean get_EnableNearbyReborn(); // 0x06c83aa0
	static System.Boolean get_EnableOutpostReborn(); // 0x06c83b74
	static System.Boolean get_EnableRandomReborn(); // 0x06c83c48
	static System.Boolean get_EnableArchiveReborn(); // 0x06c83d1c
	static System.Void .cctor(); // 0x06c83df0
}

// Client.Runtime
class WizardGames.Soc.Common.Part.PartMoudleStateHelper : System.Object
{
	static SocLogger logger; // 0x0
	static System.Int32 Min; // 0x8
	static System.Int32 Open; // 0xc
	static System.Int32 Using; // 0x10
	static System.Int32 Max; // 0x14
	static System.Boolean GetMoudleState(System.Int32 partMoudleState, System.Int32 stateType); // 0x06c83ed8
	static System.Void .cctor(); // 0x06c8409c
}

// Client.Runtime
class WizardGames.Soc.Common.MiniGame.MiniGameUtil : System.Object
{
	static SocLogger _logger; // 0x0
	static System.Boolean CheckResult(System.Collections.Generic.IEnumerable<WizardGames.Soc.Common.CustomType.DragElement> list, WizardGames.Soc.Common.Data.monument.TreasureHuntGame config, System.Int32[,]& results); // 0x06c84188
	static System.Boolean IsCorrectUnlockAngle(System.Int64 gameId, System.Int32 diff); // 0x06c847c4
	static System.Int32 IndexFormat(System.Int32 index, System.Int32 count); // 0x06c84b30
	static System.Void .cctor(); // 0x06c84c28
}

// Client.Runtime
enum WizardGames.Soc.Common.Control.UserCmdConstant : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Control.UserCmdConstant MoveForwardMask = 0;
	static WizardGames.Soc.Common.Control.UserCmdConstant MoveBackwardMask = 1;
	static WizardGames.Soc.Common.Control.UserCmdConstant MoveRightMask = 2;
	static WizardGames.Soc.Common.Control.UserCmdConstant MoveLeftMask = 3;
	static WizardGames.Soc.Common.Control.UserCmdConstant MoveForwardContinuousMask = 4;
	static WizardGames.Soc.Common.Control.UserCmdConstant MoveBackwardContinuousMask = 5;
	static WizardGames.Soc.Common.Control.UserCmdConstant MoveRightContinuousMask = 6;
	static WizardGames.Soc.Common.Control.UserCmdConstant MoveLeftContinuousMask = 7;
	static WizardGames.Soc.Common.Control.UserCmdConstant JumpMask = 8;
	static WizardGames.Soc.Common.Control.UserCmdConstant JumpContinusMask = 9;
	static WizardGames.Soc.Common.Control.UserCmdConstant CrouchMask = 10;
	static WizardGames.Soc.Common.Control.UserCmdConstant CrouchContinusMask = 11;
	static WizardGames.Soc.Common.Control.UserCmdConstant CrawlMask = 12;
	static WizardGames.Soc.Common.Control.UserCmdConstant CrawlContinusMask = 13;
	static WizardGames.Soc.Common.Control.UserCmdConstant MantleMask = 14;
	static WizardGames.Soc.Common.Control.UserCmdConstant MantleContinuousMask = 15;
	static WizardGames.Soc.Common.Control.UserCmdConstant ActivePressMantleMask = 16;
	static WizardGames.Soc.Common.Control.UserCmdConstant WalkMask = 17;
	static WizardGames.Soc.Common.Control.UserCmdConstant WalkContinusMask = 18;
	static WizardGames.Soc.Common.Control.UserCmdConstant RunMask = 19;
	static WizardGames.Soc.Common.Control.UserCmdConstant RunContinusMask = 20;
	static WizardGames.Soc.Common.Control.UserCmdConstant SprintMask = 21;
	static WizardGames.Soc.Common.Control.UserCmdConstant SprintContinusMask = 22;
	static WizardGames.Soc.Common.Control.UserCmdConstant IdleMask = 23;
	static WizardGames.Soc.Common.Control.UserCmdConstant IdleContinusMask = 24;
	static WizardGames.Soc.Common.Control.UserCmdConstant Fire1Mask = 25;
	static WizardGames.Soc.Common.Control.UserCmdConstant Fire1ContinusMask = 26;
	static WizardGames.Soc.Common.Control.UserCmdConstant Fire2Mask = 27;
	static WizardGames.Soc.Common.Control.UserCmdConstant Fire2ContinusMask = 28;
	static WizardGames.Soc.Common.Control.UserCmdConstant FireBothMask = 29;
	static WizardGames.Soc.Common.Control.UserCmdConstant FireBothContinuousMask = 30;
	static WizardGames.Soc.Common.Control.UserCmdConstant ReloadMask = 31;
	static WizardGames.Soc.Common.Control.UserCmdConstant ReloadContinusMask = 32;
	static WizardGames.Soc.Common.Control.UserCmdConstant InteractionMask = 33;
	static WizardGames.Soc.Common.Control.UserCmdConstant InteractionContinuousMask = 34;
	static WizardGames.Soc.Common.Control.UserCmdConstant ReviewMask = 35;
	static WizardGames.Soc.Common.Control.UserCmdConstant ReviewContinusMask = 36;
	static WizardGames.Soc.Common.Control.UserCmdConstant SuicideMask = 37;
	static WizardGames.Soc.Common.Control.UserCmdConstant SuicideContinusMask = 38;
	static WizardGames.Soc.Common.Control.UserCmdConstant PickUpMask = 39;
	static WizardGames.Soc.Common.Control.UserCmdConstant PickUpContinuesMask = 40;
	static WizardGames.Soc.Common.Control.UserCmdConstant ShortCut = 41;
	static WizardGames.Soc.Common.Control.UserCmdConstant ItemModel = 42;
	static WizardGames.Soc.Common.Control.UserCmdConstant AttackMask = 43;
	static WizardGames.Soc.Common.Control.UserCmdConstant ShowMask = 44;
	static WizardGames.Soc.Common.Control.UserCmdConstant FireCancelMask = 45;
	static WizardGames.Soc.Common.Control.UserCmdConstant DanceMask = 46;
	static WizardGames.Soc.Common.Control.UserCmdConstant DanceContinusMask = 47;
	static WizardGames.Soc.Common.Control.UserCmdConstant WakeUpMask = 48;
	static WizardGames.Soc.Common.Control.UserCmdConstant FlyMask = 49;
	static WizardGames.Soc.Common.Control.UserCmdConstant UpMask = 50;
	static WizardGames.Soc.Common.Control.UserCmdConstant UpContinueMask = 51;
	static WizardGames.Soc.Common.Control.UserCmdConstant DownMask = 52;
	static WizardGames.Soc.Common.Control.UserCmdConstant DownContinueMask = 53;
	static WizardGames.Soc.Common.Control.UserCmdConstant EndWoundMask = 54;
	static WizardGames.Soc.Common.Control.UserCmdConstant ObserverMask = 55;
	static WizardGames.Soc.Common.Control.UserCmdConstant CollectWater = 56;
	static WizardGames.Soc.Common.Control.UserCmdConstant DrinkWater = 57;
	static WizardGames.Soc.Common.Control.UserCmdConstant PourWater = 58;
	static WizardGames.Soc.Common.Control.UserCmdConstant HiddenUse = 59;
	static WizardGames.Soc.Common.Control.UserCmdConstant SwitchSkin = 60;
	static WizardGames.Soc.Common.Control.UserCmdConstant Ladder = 61;
	static WizardGames.Soc.Common.Control.UserCmdConstant CutParachute = 62;
	static WizardGames.Soc.Common.Control.UserCmdConstant CmdPc = 63;
	static WizardGames.Soc.Common.Control.UserCmdConstant End = 64;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Electric.Alpha3ElectricUtils : System.Object
{
	static WizardGames.Soc.Common.Framework.Algorithm.OrderedDictionary<WizardGames.Soc.Common.CustomType.ElectricCBase,System.Int64> STRVisitStack; // 0x0
	static System.Collections.Generic.HashSet<WizardGames.Soc.Common.CustomType.ElectricCBase> STRExisting; // 0x8
	static System.Boolean AddDrain(WizardGames.Soc.Common.CustomType.ElectricCBase unit, System.Int32& drain, System.Int32 add); // 0x06c84cfc
	static System.Int32 GetDrainConnectedRecursive(WizardGames.Soc.Common.CustomType.ElectricCBase source, WizardGames.Soc.Common.CustomType.ElectricCBase nowNode, System.Int32 inputSlot, System.Collections.Generic.HashSet<System.Int64>& listToUse, System.Int32& drain); // 0x06c84da8
	static System.Void SendChangedToRootRecursive(WizardGames.Soc.Common.CustomType.ElectricCBase thisUnit, System.Boolean forceUpdate); // 0x06c851fc
	static System.Int64 GetPartMonsterId(WizardGames.Soc.Common.Entity.PartEntity part); // 0x06c85708
	static System.Void .cctor(); // 0x06c857c4
}

// Client.Runtime
class WizardGames.Soc.Common.Electric.CachedConnectedInfo : System.Object
{
	System.Int64 inputEntity; // 0x10
	System.Int64 outputEntity; // 0x18
	System.Int32 inputSlot; // 0x20
	System.Int32 outputSlot; // 0x24
	System.Int32 wireColor; // 0x28
	System.Void .ctor(); // 0x06c858b8
}

// Client.Runtime
enum WizardGames.Soc.Common.Electric.EMakeConnectionReason : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Electric.EMakeConnectionReason Normal = 0;
	static WizardGames.Soc.Common.Electric.EMakeConnectionReason AfterMove = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Electric.EIOSlotType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Electric.EIOSlotType Electric = 0;
	static WizardGames.Soc.Common.Electric.EIOSlotType Fluidic = 1;
	static WizardGames.Soc.Common.Electric.EIOSlotType Kinetic = 2;
	static WizardGames.Soc.Common.Electric.EIOSlotType Generic = 3;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Electric.IOSlotBase : System.Object
{
	System.String <niceName>k__BackingField; // 0x10
	WizardGames.Soc.Common.Electric.EIOSlotType type; // 0x18
	System.Int64 connectedToID; // 0x20
	System.Int32 connectedToSlot; // 0x28
	WizardGames.Soc.Common.Electric.IORef connectedTo; // 0x30
	System.Boolean enable; // 0x38
	WizardGames.Soc.Common.Algorithm.Vector3 <handlePosition>k__BackingField; // 0x3c
	WizardGames.Soc.Common.Algorithm.Vector3 <handleEuler>k__BackingField; // 0x48
	System.Boolean <mainPowerSlot>k__BackingField; // 0x54
	System.Boolean <isInput>k__BackingField; // 0x55
	System.Boolean <isSignal>k__BackingField; // 0x56
	System.Boolean <rootConnectionsOnly>k__BackingField; // 0x57
	System.Int32 <slotId>k__BackingField; // 0x58
	System.Int32 <lastPower>k__BackingField; // 0x5c
	System.Boolean <mustTag>k__BackingField; // 0x60
	System.String <tag>k__BackingField; // 0x68
	System.Int32 <tagIdx>k__BackingField; // 0x70
	System.String get_niceName(); // 0x06c85920
	System.Void set_niceName(System.String value); // 0x06c85984
	WizardGames.Soc.Common.Algorithm.Vector3 get_handlePosition(); // 0x06c85a04
	System.Void set_handlePosition(WizardGames.Soc.Common.Algorithm.Vector3 value); // 0x06c85a68
	WizardGames.Soc.Common.Algorithm.Vector3 get_handleEuler(); // 0x06c85b00
	System.Void set_handleEuler(WizardGames.Soc.Common.Algorithm.Vector3 value); // 0x06c85b64
	System.Boolean IsAvailable(); // 0x06c85bfc
	System.Boolean HasConnect(); // 0x06c85ccc
	System.Boolean get_mainPowerSlot(); // 0x06c85d3c
	System.Void set_mainPowerSlot(System.Boolean value); // 0x06c85da0
	System.Boolean get_isInput(); // 0x06c85e1c
	System.Void set_isInput(System.Boolean value); // 0x06c85e80
	System.Boolean get_isSignal(); // 0x06c85efc
	System.Void set_isSignal(System.Boolean value); // 0x06c85f60
	System.Boolean get_rootConnectionsOnly(); // 0x06c85fdc
	System.Void set_rootConnectionsOnly(System.Boolean value); // 0x06c86040
	System.Int32 get_slotId(); // 0x06c860bc
	System.Void set_slotId(System.Int32 value); // 0x06c86120
	System.Int32 get_lastPower(); // 0x06c86198
	System.Void set_lastPower(System.Int32 value); // 0x06c861fc
	System.Void InitSlot(System.Boolean isSignal, WizardGames.Soc.Common.Algorithm.Vector3 handlePosition, WizardGames.Soc.Common.Algorithm.Vector3 handleEuler, System.Boolean rootConnectionOnly, System.String niceName, System.Int32 slotId, WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x06c86274
	System.Void ResetSlot(WizardGames.Soc.Common.CustomType.Alpha3ElectricCircuitSlot slot, WizardGames.Soc.Common.Electric.IOSlotBase innerSlot); // 0x06c86770
	System.Void Clear(); // 0x06c86a4c
	System.Boolean SetPower(System.Int32 power); // 0x06c865f4
	System.Boolean get_mustTag(); // 0x06c86b3c
	System.Void set_mustTag(System.Boolean value); // 0x06c86ba0
	System.String get_tag(); // 0x06c86c1c
	System.Void set_tag(System.String value); // 0x06c86c80
	System.Int32 get_tagIdx(); // 0x06c86d00
	System.Void set_tagIdx(System.Int32 value); // 0x06c86d64
	System.Void InitAppendInfo(System.Boolean mustTag, System.String tag, System.Int32 tagIdx); // 0x06c86ddc
	System.Void .ctor(); // 0x06c86f6c
}

// Client.Runtime
class WizardGames.Soc.Common.Electric.IORef : System.Object
{
	WizardGames.Soc.Common.CustomType.ElectricCBase ioEnt; // 0x10
	WizardGames.Soc.Common.CustomType.ElectricCBase Get(); // 0x06c87008
	System.Void Clear(); // 0x06c86ad0
	System.Void Set(WizardGames.Soc.Common.CustomType.ElectricCBase ent); // 0x06c8706c
	System.Void .ctor(); // 0x06c86708
}

// Client.Runtime
class WizardGames.Soc.Common.Electric.ElectricUnitIntegratedCircuit : WizardGames.Soc.Common.Electric.ElectricUnitBase
{
	
	static System.Int32 EncodeToPortId(System.Boolean input, System.Int32 slotId); // 0x06c870ec
	static System.Void DecodeToBoInt(System.Int32 index, System.Boolean& isInput, System.Int32& slotId); // 0x06c87170
}

// Client.Runtime
interface WizardGames.Soc.Common.Electric.IWaterFacilityComponent : 
{
	
	System.Int64 get_Id(); // 0x054a4380
	System.ValueTuple<System.Boolean,System.Int32> MoveWaterDefault(System.Int64 targetColId, System.Int32 count); // 0x054b2f58
	System.Int32 CostWaterDefault(System.Int64 bizId, System.Int32 count); // 0x0548c89c
	System.ValueTuple<System.Boolean,System.Int32> MoveWater(System.Int64 outputIndex, System.Int64 inputColId, System.Int64 inputIndex, System.Int32 count); // 0x054b2f84
	System.ValueTuple<System.Int64,System.Int32> GetWaterCount(System.Int32 index); // 0x054bc6c0
}

// Client.Runtime
class WizardGames.Soc.Common.Electric.ValueSummaryBranch : System.Object, WizardGames.Soc.Common.Electric.IValueSummary
{
	System.Int32 branchValue; // 0x10
	System.Int32 value0; // 0x14
	System.Int32 value1; // 0x18
	System.Void AddValue(System.Int32 idx, System.Int32 value); // 0x06c87204
	System.Int32 GetValue(); // 0x06c87298
	System.Boolean IsNeedSummary(System.Int32 outputId); // 0x06c87310
	System.Void .ctor(); // 0x06c87390
}

// Client.Runtime
class WizardGames.Soc.Common.Electric.ValueSummaryBranchSmart : System.Object, WizardGames.Soc.Common.Electric.IValueSummary
{
	System.Int32 branch1; // 0x10
	System.Int32 branch2; // 0x14
	System.Int32 _value; // 0x18
	System.Void AddValue(System.Int32 idx, System.Int32 value); // 0x06c87400
	System.Int32 GetValue(); // 0x06c87484
	System.Boolean IsNeedSummary(System.Int32 outputId); // 0x06c874f4
	System.Void .ctor(); // 0x06c87570
}

// Client.Runtime
class WizardGames.Soc.Common.Electric.SlotInfo : System.Object
{
	System.Int64 connectedID; // 0x10
	System.Int32 connectedToSlot; // 0x18
	System.Int32 lineColor; // 0x1c
	System.Void .ctor(); // 0x06c875d8
}

// Client.Runtime
interface WizardGames.Soc.Common.Electric.IValueSummary : 
{
	
	System.Void AddValue(System.Int32 idx, System.Int32 value); // 0x055057d4
	System.Int32 GetValue(); // 0x0548ba98
	System.Boolean IsNeedSummary(System.Int32 outputId); // 0x054c4f88
}

// Client.Runtime
class WizardGames.Soc.Common.Electric.ValueSummaryNone : System.Object, WizardGames.Soc.Common.Electric.IValueSummary
{
	
	System.Void AddValue(System.Int32 idx, System.Int32 value); // 0x06c87640
	System.Int32 GetValue(); // 0x06c876bc
	System.Boolean IsNeedSummary(System.Int32 outputId); // 0x06c87720
	System.Void .ctor(); // 0x06c87798
}

// Client.Runtime
class WizardGames.Soc.Common.Electric.ValueSummaryElectricBaseDivide : System.Object, WizardGames.Soc.Common.Electric.IValueSummary
{
	System.Int32 maxValue; // 0x10
	System.Int32 valueCount; // 0x14
	System.Void AddValue(System.Int32 _, System.Int32 value); // 0x06c87800
	System.Int32 GetValue(); // 0x06c878c0
	System.Boolean IsNeedSummary(System.Int32 outputId); // 0x06c87928
	System.Void .ctor(); // 0x06c879a0
}

// Client.Runtime
class WizardGames.Soc.Common.Electric.ElectricUnitBase : System.Object
{
	static SocLogger logger; // 0x0
	static System.Int32 backtracking; // 0x8
	static System.Void .cctor(); // 0x06c87a08
}

// Client.Runtime
enum WizardGames.Soc.Common.Const.RecoverPartCode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Const.RecoverPartCode Suc = 0;
	static WizardGames.Soc.Common.Const.RecoverPartCode NoPermission = 1;
	static WizardGames.Soc.Common.Const.RecoverPartCode TerritoryNotFound = 2;
	static WizardGames.Soc.Common.Const.RecoverPartCode TerritoryInAttacking = 3;
	static WizardGames.Soc.Common.Const.RecoverPartCode InBatchCd = 4;
	static WizardGames.Soc.Common.Const.RecoverPartCode PartRecordNotFound = 5;
	static WizardGames.Soc.Common.Const.RecoverPartCode SingleRecoverPartExist = 6;
	static WizardGames.Soc.Common.Const.RecoverPartCode RecordError = 7;
	static WizardGames.Soc.Common.Const.RecoverPartCode HpFull = 8;
	static WizardGames.Soc.Common.Const.RecoverPartCode PlayerNearby = 9;
	static WizardGames.Soc.Common.Const.RecoverPartCode ConsumeItemFail = 10;
	static WizardGames.Soc.Common.Const.RecoverPartCode CreatePartEntityFail = 11;
	static WizardGames.Soc.Common.Const.RecoverPartCode NoPart = 12;
	static WizardGames.Soc.Common.Const.RecoverPartCode IsRecovering = 13;
	static WizardGames.Soc.Common.Const.RecoverPartCode ConstructionMaxNumExceed = 14;
	static WizardGames.Soc.Common.Const.RecoverPartCode ForbiddenState = 15;
	static WizardGames.Soc.Common.Const.RecoverPartCode InRecovering = 16;
	static WizardGames.Soc.Common.Const.RecoverPartCode InBatchRecovering = 17;
	static WizardGames.Soc.Common.Const.RecoverPartCode InBatchUpgrading = 18;
	static WizardGames.Soc.Common.Const.RecoverPartCode TerritoryUnowned = 19;
	static WizardGames.Soc.Common.Const.RecoverPartCode TerritoryEntityNotFound = 20;
	static WizardGames.Soc.Common.Const.RecoverPartCode ToolCupboardNearby = 21;
	static WizardGames.Soc.Common.Const.RecoverPartCode RegionLock = 22;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Const.BatchUpgradeCode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Const.BatchUpgradeCode Suc = 0;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode PermissionDenied = 1;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode ConsumeItemsFailed = 2;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode ServerDataError = 3;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode PartIdNotInTerrCenter = 4;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode PartEntityNotFound = 5;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode CannotSelectComboChild = 6;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode InBatchUpgradeCD = 7;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode InAttackedCD = 8;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode NoPartSelect = 9;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode TargetGradeToLess = 10;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode InRecovering = 11;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode InBatchRecovering = 12;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode NotCorePart = 13;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode ComboDataError = 14;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode ComboChildEntityNotFound = 15;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode BatchUpgradeNotFinish = 16;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode GradeError = 17;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode BlueprintLocked = 18;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode PartCountLimit = 19;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode BatchChangeNotFinish = 20;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode DataChanged = 21;
	static WizardGames.Soc.Common.Const.BatchUpgradeCode CompatibleGradesError = 22;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Const.EChangePartSkin : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Const.EChangePartSkin Suc = 0;
	static WizardGames.Soc.Common.Const.EChangePartSkin PartStateError = 1;
	static WizardGames.Soc.Common.Const.EChangePartSkin ServerDataError = 2;
	static WizardGames.Soc.Common.Const.EChangePartSkin TeamMismatch = 3;
	static WizardGames.Soc.Common.Const.EChangePartSkin TerrStateError = 4;
	static WizardGames.Soc.Common.Const.EChangePartSkin ServiceNotReady = 5;
	static WizardGames.Soc.Common.Const.EChangePartSkin TooFarToOwner = 6;
	static WizardGames.Soc.Common.Const.EChangePartSkin SimulatorCheckError = 7;
	static WizardGames.Soc.Common.Const.EChangePartSkin CoolingDown = 8;
	static WizardGames.Soc.Common.Const.EChangePartSkin DeployCountLimit = 9;
	static WizardGames.Soc.Common.Const.EChangePartSkin TerritoryCountLimit = 10;
	static WizardGames.Soc.Common.Const.EChangePartSkin SkinConfigNotFound = 11;
	static WizardGames.Soc.Common.Const.EChangePartSkin SkinIdMismatch = 12;
	static WizardGames.Soc.Common.Const.EChangePartSkin CoreBuilding = 13;
	static WizardGames.Soc.Common.Const.EChangePartSkin SimulatorNotReady = 14;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Const.ERepairDebris : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Const.ERepairDebris Suc = 0;
	static WizardGames.Soc.Common.Const.ERepairDebris ServerDataError = 1;
	static WizardGames.Soc.Common.Const.ERepairDebris ServiceNotReady = 2;
	static WizardGames.Soc.Common.Const.ERepairDebris SimulatorCheckError = 3;
	static WizardGames.Soc.Common.Const.ERepairDebris TemplateConfigNotFound = 4;
	static WizardGames.Soc.Common.Const.ERepairDebris ConstructionRegionLocked = 5;
	static WizardGames.Soc.Common.Const.ERepairDebris TooFarToOwner = 6;
	static WizardGames.Soc.Common.Const.ERepairDebris NoPrivilege = 7;
	static WizardGames.Soc.Common.Const.ERepairDebris ConsumeItemFail = 8;
	static WizardGames.Soc.Common.Const.ERepairDebris TerritoryLost = 9;
	static WizardGames.Soc.Common.Const.ERepairDebris DebrisEntityLost = 10;
	static WizardGames.Soc.Common.Const.ERepairDebris PartLimit = 11;
	static WizardGames.Soc.Common.Const.ERepairDebris IsBatchRecovering = 12;
	static WizardGames.Soc.Common.Const.ERepairDebris SkinLimit = 13;
	static WizardGames.Soc.Common.Const.ERepairDebris TerritoryConflict = 14;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Const.EBatchChangeSkinCode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Const.EBatchChangeSkinCode Suc = 0;
	static WizardGames.Soc.Common.Const.EBatchChangeSkinCode SkinNodeNotFound = 1;
	static WizardGames.Soc.Common.Const.EBatchChangeSkinCode SkinConfigNotFound = 2;
	static WizardGames.Soc.Common.Const.EBatchChangeSkinCode InBatchCD = 3;
	static WizardGames.Soc.Common.Const.EBatchChangeSkinCode PermissionDenied = 4;
	static WizardGames.Soc.Common.Const.EBatchChangeSkinCode NoPartSelect = 5;
	static WizardGames.Soc.Common.Const.EBatchChangeSkinCode BatchUpgradeNotFinish = 6;
	static WizardGames.Soc.Common.Const.EBatchChangeSkinCode BatchChangeNotFinish = 7;
	static WizardGames.Soc.Common.Const.EBatchChangeSkinCode GradeError = 8;
	static WizardGames.Soc.Common.Const.EBatchChangeSkinCode TooFar = 9;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Const.EFixComboChildCode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Const.EFixComboChildCode Suc = 0;
	static WizardGames.Soc.Common.Const.EFixComboChildCode NoPermission = 1;
	static WizardGames.Soc.Common.Const.EFixComboChildCode ConsumeFail = 2;
	static WizardGames.Soc.Common.Const.EFixComboChildCode RegionLock = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Const.ErrorCode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Const.ErrorCode TechnologyScrapNotEnough = 3000;
	static WizardGames.Soc.Common.Const.ErrorCode TechnologyNotInRange = 3001;
	static WizardGames.Soc.Common.Const.ErrorCode TechnologyUnlockSuccess = 3002;
	static WizardGames.Soc.Common.Const.ErrorCode TechnologyCanNotGetWorkbenchSupport = 3012;
	static WizardGames.Soc.Common.Const.ErrorCode OthersideFull = 3006;
	static WizardGames.Soc.Common.Const.ErrorCode BackpackFull = 3007;
	static WizardGames.Soc.Common.Const.ErrorCode EquipBackpackFull = 3008;
	static WizardGames.Soc.Common.Const.ErrorCode OthersideCanNotAccept = 3009;
	static WizardGames.Soc.Common.Const.ErrorCode SuccessDropItem = 3011;
	static WizardGames.Soc.Common.Const.ErrorCode SuccessSortInventory = 3013;
	static WizardGames.Soc.Common.Const.ErrorCode SuccessDropBlueprintItem = 3015;
	static WizardGames.Soc.Common.Const.ErrorCode SeedBackpackFull = 24559;
	static WizardGames.Soc.Common.Const.ErrorCode Success = 10000;
	static WizardGames.Soc.Common.Const.ErrorCode ClientArgsError = 10001;
	static WizardGames.Soc.Common.Const.ErrorCode MinganciTestFail = 10002;
	static WizardGames.Soc.Common.Const.ErrorCode IllegalChar = 10003;
	static WizardGames.Soc.Common.Const.ErrorCode CommonComposeBlueprintIdNoFind = 11002;
	static WizardGames.Soc.Common.Const.ErrorCode CommonComposeBlueprintIdUnlock = 11003;
	static WizardGames.Soc.Common.Const.ErrorCode CommonComposeBlueprintIdExcelError = 11004;
	static WizardGames.Soc.Common.Const.ErrorCode CommonComposeWorkBenchLevelNotEnough = 11005;
	static WizardGames.Soc.Common.Const.ErrorCode CommonComposeItemNotEnough = 11006;
	static WizardGames.Soc.Common.Const.ErrorCode CommonComposeBagSlotNotEnough = 11007;
	static WizardGames.Soc.Common.Const.ErrorCode CommonComposeQueueFull = 11008;
	static WizardGames.Soc.Common.Const.ErrorCode CommonComposeQueueEmpty = 11009;
	static WizardGames.Soc.Common.Const.ErrorCode CommonComposeQueueSwap = 11010;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Const.GlobalConstConfig : System.Object
{
	static System.String ClientHotfixFilename; // 0x0
	static System.Boolean EnableOnGoingLog; // 0x8
	static System.Single DecalDepth; // 0xc
	static System.Single MonsterDisablePMTime; // 0x10
	static System.Int32 ResearchCostScrapNum; // 0x14
	static System.Single VelocityLerp; // 0x18
	static System.Single AngularDrag; // 0x1c
	static System.Int32 ContainerCanNotLootAfterTimeTips; // 0x20
	static System.Int32 DefaultAreaSize; // 0x24
	static System.Int32 QuadTreeGridSize; // 0x28
	static System.Int32 GroupFindWidth; // 0x2c
	static System.Int32 GroupFindLength; // 0x30
	static System.Int32 SpawnGroupNotTick; // 0x34
	static System.Single SpawnBalanceValue; // 0x38
	static System.Single SpawnDensityMaxValue; // 0x3c
	static System.Int32 DefaultHeapCapacity; // 0x40
	static System.Int32 DefaultTimerInitDelay; // 0x44
	static System.Int32 StableTime; // 0x48
	static System.Int32 DefaultWorldGridSize; // 0x4c
	static System.Int32 DefaultMaxPlayerCount; // 0x50
	static System.Int32 CommonComposeQueueMaxSize; // 0x54
	static System.Int32 AsyncCreateEntityMaxSize; // 0x58
	static System.Int32 PlaneTrailDelay; // 0x5c
	static System.Int32 DoorCloseCd; // 0x60
	static System.Int32 InsideDoorCd; // 0x64
	static System.Int32 OutsideDoorCd; // 0x68
	static System.Single MonumentSinkDis; // 0x6c
	static System.Single MonumentSinkSpeed; // 0x70
	static System.Int32[] AirLightTime; // 0x78
	static System.String[] WingsSockets; // 0x80
	static System.Int32 AsyncCreateEntityQueueInitSize; // 0x88
	static System.Boolean EnableGroundLog; // 0x8c
	static System.Collections.Generic.Dictionary<System.Int32,System.Int64> ElevatorTypeTemplate; // 0x90
	static System.Int32 MonsterScientistType; // 0x98
	static System.Single ElevatorCheckSqrDis; // 0x9c
	static System.String[] Assemblies; // 0xa0
	static System.Void .cctor(); // 0x06c87af0
}

// Client.Runtime
enum WizardGames.Soc.Common.Const.EHeldSocketType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Const.EHeldSocketType None = 0;
	static WizardGames.Soc.Common.Const.EHeldSocketType RightHand = 1;
	static WizardGames.Soc.Common.Const.EHeldSocketType LeftHand = 2;
	static WizardGames.Soc.Common.Const.EHeldSocketType BaseWeaponAndRightHand = 3;
	static WizardGames.Soc.Common.Const.EHeldSocketType BaseWeaponAndLeftHand = 4;
	static WizardGames.Soc.Common.Const.EHeldSocketType RightHandNoLeftHand = 5;
	static WizardGames.Soc.Common.Const.EHeldSocketType LeftHandNoRightHand = 6;
	static WizardGames.Soc.Common.Const.EHeldSocketType BaseWeaponDirect = 7;
	static WizardGames.Soc.Common.Const.EHeldSocketType BackLeft = 8;
	static WizardGames.Soc.Common.Const.EHeldSocketType BackRight = 9;
	static WizardGames.Soc.Common.Const.EHeldSocketType RightHandNoLeftHandDefault = 10;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Const.EHeldSocketTypeInHorse : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Const.EHeldSocketTypeInHorse TwoHorse = 0;
	static WizardGames.Soc.Common.Const.EHeldSocketTypeInHorse LeftHorseRightWeapon = 1;
	static WizardGames.Soc.Common.Const.EHeldSocketTypeInHorse LeftWeaponRightHorse = 2;
	static WizardGames.Soc.Common.Const.EHeldSocketTypeInHorse TwoWeapon = 3;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Network.WorldEntityRpcInfo : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Framework.Network.RpcLimitCall> RpcHash2LimitCall; // 0x0
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Framework.Network.RpcInfo> RpcHashCode2Info; // 0x8
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class WizardGames.Soc.Common.Network.ClientEntityRpcInfo : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Framework.Network.RpcInfo> RpcHashCode2Info; // 0x0
	static System.Void .cctor(); // 0x06c87edc
}

// Client.Runtime
class WizardGames.Soc.Common.Network.UnityDsEntityRpcInfo : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Framework.Network.RpcLimitCall> RpcHash2LimitCall; // 0x0
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Framework.Network.RpcInfo> RpcHashCode2Info; // 0x8
	static System.Void .cctor(); // 0x06c9f500
}

// Client.Runtime
class WizardGames.Soc.Common.Network.RpcParamsAutoGenerate : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32[]> RpcParams; // 0x0
	static System.Void Init(); // 0x06ca51e8
	static System.Void .cctor(); // 0x06ca6cac
}

// Client.Runtime
class WizardGames.Soc.Common.Network.RpcParamsAutoGenerate.<>c : System.Object
{
	static WizardGames.Soc.Common.Network.RpcParamsAutoGenerate.<>c <>9; // 0x0
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.Alpha3PlantArgs>> <>9__1_0; // 0x8
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.Alpha3PlantArgs>> <>9__1_1; // 0x10
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.List<System.Int64>> <>9__1_2; // 0x18
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.IList<System.Int64>> <>9__1_3; // 0x20
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.TemplateGrades>> <>9__1_4; // 0x28
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.IDictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.TemplateGrades>> <>9__1_5; // 0x30
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.ComboTemplateGrades>> <>9__1_6; // 0x38
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.IDictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.ComboTemplateGrades>> <>9__1_7; // 0x40
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TerritoryFillUpkeepData>> <>9__1_8; // 0x48
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.TerritoryFillUpkeepData>> <>9__1_9; // 0x50
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PriceItem>> <>9__1_10; // 0x58
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.IList<WizardGames.Soc.Common.CustomType.PriceItem>> <>9__1_11; // 0x60
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.HashSet<System.Int64>> <>9__1_12; // 0x68
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.ISet<System.Int64>> <>9__1_13; // 0x70
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.List<System.Single>> <>9__1_14; // 0x78
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.IList<System.Single>> <>9__1_15; // 0x80
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.HashSet<System.Int32>> <>9__1_16; // 0x88
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.ISet<System.Int32>> <>9__1_17; // 0x90
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.List<System.Int32>> <>9__1_18; // 0x98
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.IList<System.Int32>> <>9__1_19; // 0xa0
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.List<System.UInt64>> <>9__1_20; // 0xa8
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.IList<System.UInt64>> <>9__1_21; // 0xb0
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.Dictionary<System.Int64,System.Int32>> <>9__1_22; // 0xb8
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.IDictionary<System.Int64,System.Int32>> <>9__1_23; // 0xc0
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.SimpleCustom.IntHashSetData>> <>9__1_24; // 0xc8
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.IDictionary<System.Int32,WizardGames.Soc.Common.SimpleCustom.IntHashSetData>> <>9__1_25; // 0xd0
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.CustomEventParamCfg>> <>9__1_26; // 0xd8
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.CustomEventParamCfg>> <>9__1_27; // 0xe0
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.SimpleCreatePartData>> <>9__1_28; // 0xe8
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.SimpleCreatePartData>> <>9__1_29; // 0xf0
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.BattleButonTLogInfo>> <>9__1_30; // 0xf8
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.BattleButonTLogInfo>> <>9__1_31; // 0x100
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.UgcPropertyModifyInfo>> <>9__1_32; // 0x108
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.UgcPropertyModifyInfo>> <>9__1_33; // 0x110
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<System.Collections.Generic.Queue<WizardGames.Soc.Common.CustomType.EntityRecord>> <>9__1_34; // 0x118
	static System.Void .cctor(); // 0x06ca6d44
	System.Void .ctor(); // 0x06ca6da8
	System.Void <Init>b__1_0(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.Alpha3PlantArgs> value, MessagePack.MessagePackWriter& writer); // 0x06ca6e10
	System.Void <Init>b__1_1(System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.Alpha3PlantArgs> value, MessagePack.MessagePackWriter& writer); // 0x06ca6edc
	System.Void <Init>b__1_2(System.Collections.Generic.List<System.Int64> value, MessagePack.MessagePackWriter& writer); // 0x06ca6fa8
	System.Void <Init>b__1_3(System.Collections.Generic.IList<System.Int64> value, MessagePack.MessagePackWriter& writer); // 0x06ca7068
	System.Void <Init>b__1_4(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.TemplateGrades> value, MessagePack.MessagePackWriter& writer); // 0x06ca7128
	System.Void <Init>b__1_5(System.Collections.Generic.IDictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.TemplateGrades> value, MessagePack.MessagePackWriter& writer); // 0x06ca71f4
	System.Void <Init>b__1_6(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.ComboTemplateGrades> value, MessagePack.MessagePackWriter& writer); // 0x06ca72c0
	System.Void <Init>b__1_7(System.Collections.Generic.IDictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.ComboTemplateGrades> value, MessagePack.MessagePackWriter& writer); // 0x06ca738c
	System.Void <Init>b__1_8(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TerritoryFillUpkeepData> value, MessagePack.MessagePackWriter& writer); // 0x06ca7458
	System.Void <Init>b__1_9(System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.TerritoryFillUpkeepData> value, MessagePack.MessagePackWriter& writer); // 0x06ca7524
	System.Void <Init>b__1_10(System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PriceItem> value, MessagePack.MessagePackWriter& writer); // 0x06ca75f0
	System.Void <Init>b__1_11(System.Collections.Generic.IList<WizardGames.Soc.Common.CustomType.PriceItem> value, MessagePack.MessagePackWriter& writer); // 0x06ca76bc
	System.Void <Init>b__1_12(System.Collections.Generic.HashSet<System.Int64> value, MessagePack.MessagePackWriter& writer); // 0x06ca7788
	System.Void <Init>b__1_13(System.Collections.Generic.ISet<System.Int64> value, MessagePack.MessagePackWriter& writer); // 0x06ca7848
	System.Void <Init>b__1_14(System.Collections.Generic.List<System.Single> value, MessagePack.MessagePackWriter& writer); // 0x06ca7908
	System.Void <Init>b__1_15(System.Collections.Generic.IList<System.Single> value, MessagePack.MessagePackWriter& writer); // 0x06ca79c8
	System.Void <Init>b__1_16(System.Collections.Generic.HashSet<System.Int32> value, MessagePack.MessagePackWriter& writer); // 0x06ca7a88
	System.Void <Init>b__1_17(System.Collections.Generic.ISet<System.Int32> value, MessagePack.MessagePackWriter& writer); // 0x06ca7b48
	System.Void <Init>b__1_18(System.Collections.Generic.List<System.Int32> value, MessagePack.MessagePackWriter& writer); // 0x06ca7c08
	System.Void <Init>b__1_19(System.Collections.Generic.IList<System.Int32> value, MessagePack.MessagePackWriter& writer); // 0x06ca7cc8
	System.Void <Init>b__1_20(System.Collections.Generic.List<System.UInt64> value, MessagePack.MessagePackWriter& writer); // 0x06ca7d88
	System.Void <Init>b__1_21(System.Collections.Generic.IList<System.UInt64> value, MessagePack.MessagePackWriter& writer); // 0x06ca7e48
	System.Void <Init>b__1_22(System.Collections.Generic.Dictionary<System.Int64,System.Int32> value, MessagePack.MessagePackWriter& writer); // 0x06ca7f08
	System.Void <Init>b__1_23(System.Collections.Generic.IDictionary<System.Int64,System.Int32> value, MessagePack.MessagePackWriter& writer); // 0x06ca7fc8
	System.Void <Init>b__1_24(System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.SimpleCustom.IntHashSetData> value, MessagePack.MessagePackWriter& writer); // 0x06ca8088
	System.Void <Init>b__1_25(System.Collections.Generic.IDictionary<System.Int32,WizardGames.Soc.Common.SimpleCustom.IntHashSetData> value, MessagePack.MessagePackWriter& writer); // 0x06ca8154
	System.Void <Init>b__1_26(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.CustomEventParamCfg> value, MessagePack.MessagePackWriter& writer); // 0x06ca8220
	System.Void <Init>b__1_27(System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.CustomEventParamCfg> value, MessagePack.MessagePackWriter& writer); // 0x06ca82ec
	System.Void <Init>b__1_28(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.SimpleCreatePartData> value, MessagePack.MessagePackWriter& writer); // 0x06ca83b8
	System.Void <Init>b__1_29(System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.SimpleCreatePartData> value, MessagePack.MessagePackWriter& writer); // 0x06ca8484
	System.Void <Init>b__1_30(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.BattleButonTLogInfo> value, MessagePack.MessagePackWriter& writer); // 0x06ca8550
	System.Void <Init>b__1_31(System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.BattleButonTLogInfo> value, MessagePack.MessagePackWriter& writer); // 0x06ca861c
	System.Void <Init>b__1_32(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.UgcPropertyModifyInfo> value, MessagePack.MessagePackWriter& writer); // 0x06ca86e8
	System.Void <Init>b__1_33(System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.UgcPropertyModifyInfo> value, MessagePack.MessagePackWriter& writer); // 0x06ca87b4
	System.Void <Init>b__1_34(System.Collections.Generic.Queue<WizardGames.Soc.Common.CustomType.EntityRecord> value, MessagePack.MessagePackWriter& writer); // 0x06ca8880
}

// Client.Runtime
class WizardGames.Soc.Common.NodeSystem.BluePrintConst : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int64,System.Int32> DefaultBluePrintInfo; // 0x0
	static System.Collections.Generic.Dictionary<System.Int64,System.Int64> BlueprintId2ItemId; // 0x8
	static System.Collections.Generic.Dictionary<System.Int64,System.Int64> ItemId2BlueprintId; // 0x10
	static System.Collections.Generic.Dictionary<System.Int64,System.Int64> ItemId2BlueprintItemId; // 0x18
	static System.Collections.Generic.Dictionary<System.Int64,System.Int64> BluePrintItemId2ItemId; // 0x20
	static System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<System.Int64>> BluePrintId2TechId; // 0x28
	static System.Collections.Generic.Dictionary<System.Int64,System.Int64> BluePrintId2BuildCoreId; // 0x30
	static System.Collections.Generic.Dictionary<System.Int64,System.Int64> BuildCoreId2BluePrintId; // 0x38
	static System.Collections.Generic.Dictionary<System.Int64,System.Int64> BluePrintId2ConstructionId; // 0x40
	static System.Collections.Generic.Dictionary<System.Int64,System.Int64> ConstructionId2BluePrintId; // 0x48
	static System.Void .cctor(); // 0x06c8f9b8
}

// Client.Runtime
class WizardGames.Soc.Common.NodeSystem.ConstructionChangeConst : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int64>>> ConstructionChange; // 0x0
	static System.Void .cctor(); // 0x06ca894c
}

// Client.Runtime
class WizardGames.Soc.Common.NodeSystem.ConstructionOutsideMapper_Skin : System.Object
{
	
	static System.Int64 ShortToLong(System.Int64 shortId); // 0x06ca957c
}

// Client.Runtime
class WizardGames.Soc.Common.NodeSystem.ConstructionOutsideMapper_Template : System.Object
{
	
	static System.Int64 ShortToLong(System.Int64 shortId); // 0x06ca95f8
}

// Client.Runtime
class WizardGames.Soc.Common.NodeSystem.ContainerSlot2Config : System.Object
{
	static System.Collections.Generic.IReadOnlyDictionary<System.Int32,System.Int32> BeltSlot2Config; // 0x0
	static System.Void .cctor(); // 0x06ca9fb4
}

// Client.Runtime
class WizardGames.Soc.Common.TimerWheel.TimerCallback : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x06caa100
	System.Void Invoke(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x06caa1c8
}

// Client.Runtime
class WizardGames.Soc.Common.TimerWheel.TimerWheel : System.Object
{
	static SocLogger logger; // 0x0
	System.Int32 initThreadId; // 0x10
	System.String name; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.TimerWheel.TimerWheelNode> records; // 0x20
	WizardGames.Soc.Common.TimerWheel.TimerWheelCore core; // 0x28
	System.Int64 timerIdSequence; // 0x30
	System.Func<System.Int64> IdGenFunc; // 0x38
	System.Boolean start; // 0x40
	WizardGames.Soc.Common.Utility.Counter UpdateTimer; // 0x48
	WizardGames.Soc.Share.Framework.TimerWheelIndicator Indicator; // 0x50
	System.Void .ctor(System.String name, System.Func<System.Int64> idGenFunc); // 0x06caa22c
	System.Void Start(System.Boolean statLogEnabled); // 0x06caa3f8
	System.Int64 GenTimerId(); // 0x06caa880
	System.Void AddTimerRecord(WizardGames.Soc.Common.TimerWheel.TimerWheelNode listNode); // 0x06caa8f0
	System.Void RemoveTimerRecord(System.Int64 timerId); // 0x06caa994
	System.Boolean CancelTimerRecord(System.Int64 timerId); // 0x06caaa30
	WizardGames.Soc.Common.TimerWheel.TimerWheelNode AddTimer(System.UInt64 timeout, System.Int32 maxRepeat, System.UInt64 interval, System.Int64 timerId, System.String filePath, System.Int32 lineNumber); // 0x06caadd0
	System.Int64 AddTimerOnce(System.Int32 timeout, WizardGames.Soc.Common.TimerWheel.TimerCallback callback, System.Object callbackData, System.Int64 timerId, System.String filePath, System.Int32 lineNumber); // 0x06cab464
	System.Int64 AddTimerOnce(System.UInt64 timeout, WizardGames.Soc.Common.TimerWheel.TimerCallback callback, System.Object callbackData, System.Int64 timerId, System.String filePath, System.Int32 lineNumber); // 0x06cab534
	System.Int64 AddTimerRepeat(System.Int32 timeout, System.Int32 interval, WizardGames.Soc.Common.TimerWheel.TimerCallback callback, System.Object callbackData, System.Int64 timerId, System.String filePath, System.Int32 lineNumber); // 0x06cab86c
	System.Int64 AddTimerRepeat(System.UInt64 timeout, System.UInt64 interval, WizardGames.Soc.Common.TimerWheel.TimerCallback callback, System.Object callbackData, System.Int64 timerId, System.String filePath, System.Int32 lineNumber); // 0x06cab96c
	System.Int64 AddTimerSpecifiedCount(System.UInt64 timeout, System.Int32 count, System.UInt64 interval, WizardGames.Soc.Common.TimerWheel.TimerCallback callback, System.Object callbackData, System.Int64 timerId, System.String filePath, System.Int32 lineNumber); // 0x06caba6c
	System.Int64 AddTimerExplicit(System.UInt64 timeout, System.Int32 maxRepeat, System.UInt64 interval, WizardGames.Soc.Common.TimerWheel.TimerCallback callback, System.Object callbackData, System.Int64 timerId, System.String filePath, System.Int32 lineNumber); // 0x06cab61c
	System.Boolean CancelTimer(System.Int64 timerId); // 0x06cabb64
	System.Void CancelAllTimer(); // 0x06cabce4
	System.Void Update(System.UInt32 delta, System.Int32 warningThreshold); // 0x06cabf9c
	static System.Void .cctor(); // 0x06cac6a0
	System.Int64 <.ctor>b__14_0(); // 0x06cac774
}

// Client.Runtime
class WizardGames.Soc.Common.TimerWheel.TimerCallbackProfilerFunc : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x06cac7e0
	System.Void Invoke(System.String filePath, System.Int32 lineNumber, System.Single durationMs); // 0x06cac8bc
}

// Client.Runtime
class WizardGames.Soc.Common.TimerWheel.TimerMetrics : System.Object, Share.Common.ObjPool.IPooledObjectNew
{
	System.String FilePath; // 0x10
	System.Int32 LineNumber; // 0x18
	System.Int64 TotalCostTicks; // 0x20
	System.Int64 MaxCostTicks; // 0x28
	System.Int32 AddCount; // 0x30
	System.Int32 ExecTimes; // 0x34
	System.Boolean <CareThreadSafe>k__BackingField; // 0x38
	System.UInt64 <Mid>k__BackingField; // 0x40
	System.Boolean <IsReturn>k__BackingField; // 0x48
	System.Double get_TotalCostMills(); // 0x06cac928
	System.Double get_MaxCostMills(); // 0x06cac9d4
	System.Double get_AvgCostMills(); // 0x06caca80
	System.Boolean get_CareThreadSafe(); // 0x06cacb08
	System.Void set_CareThreadSafe(System.Boolean value); // 0x06cacb6c
	System.Void ReturnToPool(); // 0x06cacbe8
	System.UInt64 get_Mid(); // 0x06cacc70
	System.Void set_Mid(System.UInt64 value); // 0x06caccd4
	System.Boolean get_IsReturn(); // 0x06cacd4c
	System.Void set_IsReturn(System.Boolean value); // 0x06cacdb0
	System.String ToString(); // 0x06cace2c
	System.Void .ctor(); // 0x06cad144
}

// Client.Runtime
class WizardGames.Soc.Common.TimerWheel.TimerWheelCore : System.Object
{
	static SocLogger logger; // 0x0
	static System.Int32 USE_SKIP_MODE_THRESHOLD = 3000;
	static System.Int32 GET_COST_TIME_EVERY_FEW = 8;
	System.UInt64 tickedCount; // 0x10
	System.Boolean skipMode; // 0x18
	System.UInt64 <TargetTicks>k__BackingField; // 0x20
	System.Action<WizardGames.Soc.Common.TimerWheel.TimerWheelNode> timerAddCallback; // 0x28
	System.Action<System.Int64> timerRemoveCallback; // 0x30
	System.Diagnostics.Stopwatch stopwatch; // 0x38
	WizardGames.Soc.Common.TimerWheel.TimerWheelNode[] minLevelSlots; // 0x40
	WizardGames.Soc.Common.TimerWheel.TimerWheelNode[][] otherLevelSlots; // 0x48
	static System.Int32 MIN_LEVEL_MASK = 1023;
	static System.Int32 OTHER_LEVEL_MASK = 63;
	static System.Int32 MIN_LEVEL_MAX_VALUE = 1024;
	static System.Int32 MIN_LEVEL_OFFSET = 10;
	static System.Int32 LEVEL_1_MAX_VALUE = 65536;
	static System.Int32 LEVEL_1_OFFSET = 16;
	static System.Int32 LEVEL_2_MAX_VALUE = 4194304;
	static System.Int32 LEVEL_2_OFFSET = 22;
	static System.Int32 LEVEL_3_MAX_VALUE = 268435456;
	static System.Int32 LEVEL_3_OFFSET = 28;
	static System.Int32 LEVEL_4_OFFSET = 34;
	System.Int64 singleTimerCostTicksThreshold; // 0x50
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.TimerWheel.TimerMetrics> TimerMetricsRecord; // 0x58
	System.Boolean statLogEnabled; // 0x60
	WizardGames.Soc.Common.TimerWheel.TimerCallbackProfilerFunc timerCallbackProfiler; // 0x68
	System.UInt64 get_TargetTicks(); // 0x06cad1ac
	System.Void set_TargetTicks(System.UInt64 value); // 0x06cad210
	System.Void .ctor(System.Action<WizardGames.Soc.Common.TimerWheel.TimerWheelNode> callback, System.Action<System.Int64> doneCallback, System.Boolean statLogEnabled); // 0x06caa650
	System.Void GetTimerWheelCoreLevel(System.UInt64 expire, System.UInt32& retLevel, System.UInt64& retLevelIndex); // 0x06cad288
	WizardGames.Soc.Common.TimerWheel.TimerWheelNode[] GetSlotArrayByLevel(System.UInt32 level); // 0x06cad384
	System.Void PushToSlot(System.UInt32 level, System.UInt64 index, WizardGames.Soc.Common.TimerWheel.TimerWheelNode node); // 0x06cad42c
	System.Void AddTimerInner(WizardGames.Soc.Common.TimerWheel.TimerWheelNode node, System.Boolean isNew); // 0x06cad608
	System.Void RemoveTimer(WizardGames.Soc.Common.TimerWheel.TimerWheelNode node); // 0x06caab28
	WizardGames.Soc.Common.TimerWheel.TimerWheelNode AddTimer(System.UInt64 timeout, System.Int32 maxRepeat, System.UInt64 interval, System.Int64 id, System.String filePath, System.Int32 lineNumber); // 0x06cab30c
	System.Void InternalCascade(System.UInt32 level, System.UInt64 index); // 0x06cad944
	System.UInt32 InternalUpdate(System.UInt32 delta, System.Int32& excuteCount, System.String wheelName, System.Int32 maxCostTime); // 0x06cac100
	static System.Void .cctor(); // 0x06cadac0
}

// Client.Runtime
class WizardGames.Soc.Common.TimerWheel.TimerWheelNode : WizardGames.Soc.Common.Framework.Algorithm.BaseLinkedNode, WizardGames.Soc.Common.Cache.IPooledObject
{
	static System.Int32 POOL_SIZE = 30;
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Common.TimerWheel.TimerWheelNode> pool; // 0x0
	System.Int64 Id; // 0x28
	System.UInt64 Timeout; // 0x30
	System.Boolean IsCancelled; // 0x38
	System.UInt64 RepeatInterval; // 0x40
	System.Int32 RepeatCount; // 0x48
	WizardGames.Soc.Common.TimerWheel.TimerCallback Callback; // 0x50
	System.Object CallbackData; // 0x58
	System.String FilePath; // 0x60
	System.Int32 LineNumber; // 0x68
	System.Int32 Hash; // 0x6c
	System.Boolean <IsReturn>k__BackingField; // 0x70
	WizardGames.Soc.Common.TimerWheel.TimerWheelNode Tail; // 0x78
	System.UInt32 Level; // 0x80
	System.UInt64 Index; // 0x88
	System.Boolean get_IsReturn(); // 0x06cadb94
	System.Void set_IsReturn(System.Boolean value); // 0x06cadbf8
	static WizardGames.Soc.Common.TimerWheel.TimerWheelNode GetFromPool(System.Int64 id, System.UInt64 timeout, System.UInt64 interval, System.Int32 maxRepeat, System.String fp, System.Int32 line); // 0x06cad7ec
	System.Void ReturnToPool(); // 0x06cad6e8
	System.Void .ctor(); // 0x06cadc74
	static System.Void .cctor(); // 0x06cadd08
}

// Client.Runtime
class WizardGames.Soc.Common.Extension.ListExt : System.Object
{
	
	static System.String Print<T>(System.Collections.Generic.IList<T> list, System.Int32 skip); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Common.Extension.ListExt.<>c__0<T> : System.Object
{
	static WizardGames.Soc.Common.Extension.ListExt.<>c__0<T> <>9; // 0x0
	static System.Func<T,System.String> <>9__0_0; // 0x8
	static System.Void .cctor(); // 0x054fd168
	System.Void .ctor(); // 0x055049cc
	System.String <Print>b__0_0(T e); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.ConsumeConditionUtil : System.Object
{
	
	static System.Void TryConsumeCondition(System.Int32 deltaTime, WizardGames.Soc.Common.Entity.IConditionConsumeEntity item); // 0x06cadda8
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.Grid<T> : System.Object
{
	System.Int32 <CellCount>k__BackingField; // 0x0
	System.Int32 <CellSize>k__BackingField; // 0x0
	System.Single CenterX; // 0x0
	System.Single CenterY; // 0x0
	WizardGames.Soc.Common.Utility.Grid.Node<T>[,] Nodes; // 0x0
	System.Collections.Generic.Dictionary<T,WizardGames.Soc.Common.Utility.Grid.Node<T>> Lookup; // 0x0
	System.Int32 cellItemNum; // 0x0
	System.Int32 get_CellCount(); // 0x0548ba98
	System.Void set_CellCount(System.Int32 value); // 0x055056e8
	System.Int32 get_CellSize(); // 0x0548ba98
	System.Void set_CellSize(System.Int32 value); // 0x055056e8
	System.Void .ctor(System.Int32 CellSize, System.Single WorldSize); // 0x05508338
	System.Int32 Query(System.Single x, System.Single y, System.Single radius, System.Collections.Generic.List<T> result, System.Func<T,System.Boolean> filter); // 0x0548cddc
	System.Int32 Clamp(System.Single input); // 0x0548ccf8
	WizardGames.Soc.Common.Utility.Grid.Node<T> GetNode(System.Single x, System.Single y, System.Boolean create); // 0x054eb700
	System.Void Add(T obj, System.Single x, System.Single y); // 0x052af1f0
	System.Void Move(T obj, System.Single x, System.Single y); // 0x052af1f0
	System.Boolean Remove(T obj); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.Grid.Node<T> : System.Object
{
	System.Collections.Generic.HashSet<T> Contents; // 0x0
	System.Void Add(T obj); // 0x052af1f0
	System.Boolean Remove(T obj); // 0x052af1f0
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
enum WizardGames.Soc.Common.Utility.AirSupplyType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Utility.AirSupplyType Lungs = 0;
	static WizardGames.Soc.Common.Utility.AirSupplyType ScubaTank = 1;
	static WizardGames.Soc.Common.Utility.AirSupplyType Submarine = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.MetabolismUtil : System.Object
{
	
	static System.Single GetOxygenTime(WizardGames.Soc.Common.Entity.PlayerEntity entity, WizardGames.Soc.Common.Utility.AirSupplyType& airSupplyType); // 0x06cadf80
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.MonsterHeldItemUtil : System.Object
{
	
	static WizardGames.Soc.Common.CustomType.WeaponCustom GetCurrentWeapon(WizardGames.Soc.Common.Entity.MonsterEntity monsterEntity); // 0x06cae380
	static WizardGames.Soc.Common.CustomType.WeaponCustom GetCurrentWeapon(WizardGames.Soc.Common.Entity.MonsterEntity monsterEntity, System.Int32 slot); // 0x06cae3fc
	static WizardGames.Soc.Common.Entity.IHeldItemEntity GetCurrentHeldItem(WizardGames.Soc.Common.Entity.MonsterEntity monsterEntity); // 0x06cae578
	static T GetCurrentHandEntity<T>(WizardGames.Soc.Common.Entity.MonsterEntity monsterEntity); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.SpringDamper : System.Object
{
	System.Single _lastVal; // 0x10
	System.Single _interpVal; // 0x14
	System.Single _interpSpeed; // 0x18
	System.Single _springVal; // 0x1c
	System.Single _springValRate; // 0x20
	System.Single _interpTarget; // 0x24
	System.Single _springTarget; // 0x28
	System.Single _springRatio; // 0x2c
	System.Boolean _bInterpConstant; // 0x30
	System.Single _frequency; // 0x34
	System.Single _damping; // 0x38
	System.Void Init(System.Single damping, System.Single frequency, System.Single interpSpeed, System.Single springRatio, System.Boolean bInterpConstant); // 0x06cae5f4
	System.Void SetTarget(System.Single val, System.Boolean isReset, System.Boolean needLastFrame); // 0x06cae6b4
	System.Void Tick(System.Single deltaTime); // 0x06cae78c
	System.Single GetInterpVal(); // 0x06caed04
	System.Single GetSpringVal(); // 0x06caed68
	System.Single GetFinalVal(); // 0x06caedcc
	static System.Void spring_damper(System.Single& InOutValue, System.Single& InOutValueRate, System.Single InTargetValue, System.Single InTargetValueRate, System.Single InDeltaTime, System.Single InUndampedFrequency, System.Single InDampingRatio); // 0x06cae97c
	static System.Single InvExpApprox(System.Single X); // 0x06caee38
	System.Void .ctor(); // 0x06caeee8
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.SpringDamperMono : UnityEngine.MonoBehaviour
{
	System.Single _lastVal; // 0x30
	System.Single _interpVal; // 0x34
	System.Single _interpSpeed; // 0x38
	System.Single _springVal; // 0x3c
	System.Single _springValRate; // 0x40
	System.Single _interpTarget; // 0x44
	System.Single _springTarget; // 0x48
	System.Single _springRatio; // 0x4c
	System.Boolean _bInterpConstant; // 0x50
	System.Single _frequency; // 0x54
	System.Single _damping; // 0x58
	System.Void SetTarget(System.Single val, System.Boolean isReset, System.Boolean needLastFrame); // 0x06caef78
	System.Void Tick(System.Int32 deltaTime); // 0x06caf050
	System.Void Tick(System.Single deltaTime); // 0x06caf0d8
	System.Single GetInterpVal(); // 0x06caf650
	System.Single GetSpringVal(); // 0x06caf6b4
	System.Single GetFinalVal(); // 0x06caf718
	static System.Void spring_damper(System.Single& InOutValue, System.Single& InOutValueRate, System.Single InTargetValue, System.Single InTargetValueRate, System.Single InDeltaTime, System.Single InUndampedFrequency, System.Single InDampingRatio); // 0x06caf2c8
	static System.Single InvExpApprox(System.Single X); // 0x06caf784
	System.Void .ctor(); // 0x06caf834
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.WeaponUtil : System.Object
{
	
	static WizardGames.Soc.Common.CustomType.WeaponCustom GetCurrentWeapon(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Boolean local); // 0x06caf8c4
	static T GetCurrentHandEntity<T>(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Boolean local); // 0x052af1f0
	static T GetByEntityId<T>(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Int64 entityId, System.Boolean local); // 0x052af1f0
	static WizardGames.Soc.Common.Entity.IEmbeddedCustom GetCurrentHandEntity(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06caf958
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.ArrayExt : System.Object
{
	
	static System.Boolean ContainsWithoutLinq<TSource>(TSource[] source, TSource value); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.DictionaryExt : System.Object
{
	
	static System.Boolean TryGetValueOrCreate<TKey,TValue>(System.Collections.Generic.IDictionary<TKey,TValue> dic, TKey key, TValue& value); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.EnumerableExt : System.Object
{
	
	static System.Collections.Generic.List<TSource> ToListWithoutLinq<TSource>(System.Collections.Generic.IEnumerable<TSource> source); // 0x052af1f0
	static TSource ElementAtOrDefaultWithoutLinq<TSource>(System.Collections.Generic.IEnumerable<TSource> source, System.Int32 index); // 0x052af1f0
	static TSource FirstOrDefaultWithoutLinq<TSource>(System.Collections.Generic.IEnumerable<TSource> source); // 0x052af1f0
	static TSource FirstOrDefaultWithoutLinq<TSource>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate); // 0x052af1f0
	static System.Boolean ContainsWithoutLinq<TSource>(System.Collections.Generic.IEnumerable<TSource> source, TSource value); // 0x052af1f0
	static System.Boolean ContainsWithoutLinq<TSource>(System.Collections.Generic.IEnumerable<TSource> source, TSource value, System.Collections.Generic.IEqualityComparer<TSource> comparer); // 0x052af1f0
	static System.Collections.Generic.IEnumerable<TSource> SkipWithoutLinq<TSource>(System.Collections.Generic.IEnumerable<TSource> source, System.Int32 count); // 0x052af1f0
	static System.Collections.Generic.IEnumerable<TSource> SkipIteratorWithoutLinq<TSource>(System.Collections.Generic.IEnumerable<TSource> source, System.Int32 count); // 0x052af1f0
	static System.Collections.Generic.IEnumerable<TResult> RepeatWithoutLinq<TResult>(TResult element, System.Int32 count); // 0x052af1f0
	static System.Collections.Generic.IEnumerable<TResult> RepeatIteratorWithoutLinq<TResult>(TResult element, System.Int32 count); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.EnumerableExt.<RepeatIteratorWithoutLinq>d__12<TResult> : System.Object, System.Collections.Generic.IEnumerable<TResult>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<TResult>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x0
	TResult <>2__current; // 0x0
	System.Int32 <>l__initialThreadId; // 0x0
	TResult element; // 0x0
	TResult <>3__element; // 0x0
	System.Int32 count; // 0x0
	System.Int32 <>3__count; // 0x0
	System.Int32 <i>5__2; // 0x0
	System.Void .ctor(System.Int32 <>1__state); // 0x055056e8
	System.Void System.IDisposable.Dispose(); // 0x055049cc
	System.Boolean MoveNext(); // 0x054c4760
	TResult System.Collections.Generic.IEnumerator<TResult>.get_Current(); // 0x052af1f0
	System.Void System.Collections.IEnumerator.Reset(); // 0x055049cc
	System.Object System.Collections.IEnumerator.get_Current(); // 0x054e7844
	System.Collections.Generic.IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator(); // 0x054e7844
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x054e7844
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.EnumerableExt.<SkipIteratorWithoutLinq>d__10<TSource> : System.Object, System.Collections.Generic.IEnumerable<TSource>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<TSource>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x0
	TSource <>2__current; // 0x0
	System.Int32 <>l__initialThreadId; // 0x0
	System.Collections.Generic.IEnumerable<TSource> source; // 0x0
	System.Collections.Generic.IEnumerable<TSource> <>3__source; // 0x0
	System.Int32 count; // 0x0
	System.Int32 <>3__count; // 0x0
	System.Collections.Generic.IEnumerator<TSource> <e>5__2; // 0x0
	System.Void .ctor(System.Int32 <>1__state); // 0x055056e8
	System.Void System.IDisposable.Dispose(); // 0x055049cc
	System.Boolean MoveNext(); // 0x054c4760
	System.Void <>m__Finally1(); // 0x055049cc
	TSource System.Collections.Generic.IEnumerator<TSource>.get_Current(); // 0x052af1f0
	System.Void System.Collections.IEnumerator.Reset(); // 0x055049cc
	System.Object System.Collections.IEnumerator.get_Current(); // 0x054e7844
	System.Collections.Generic.IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator(); // 0x054e7844
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x054e7844
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.ByteUtil : System.Object
{
	
	static System.Int32 RemoveFlag(System.Int32 data, System.Int32 flag); // 0x06caf9d8
	static System.Int32 AddFlag(System.Int32 data, System.Int32 flag); // 0x06cafa50
	static System.Boolean HasFlag(System.Int32 data, System.Int32 flag); // 0x06cafac8
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.MemoryDebugUtil : System.Object
{
	
	static System.String DebugMemoryToBytePrint(System.Memory<System.Byte> input); // 0x06cafb44
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.LocalSeqGenerator : System.Object
{
	static System.Int64 sequence; // 0x0
	static System.Int64 Next(); // 0x06cafcb4
}

// Client.Runtime
interface WizardGames.Soc.Common.Utility.IRandomFunc : 
{
	
	System.Int32 Next(System.Int32 minValue, System.Int32 maxValue); // 0x0548bebc
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.RandomFunc : System.Object, WizardGames.Soc.Common.Utility.IRandomFunc
{
	System.Random _random; // 0x10
	System.Void .ctor(); // 0x06cafdb0
	System.Int32 Next(System.Int32 minValue, System.Int32 maxValue); // 0x06cafe50
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.RandomUtil : System.Object
{
	[ThreadStatic] static WizardGames.Soc.Common.Utility.IRandomFunc _randomFunc;
	static WizardGames.Soc.Common.Utility.IRandomFunc get_Instance(); // 0x06cafed4
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.SocUtility : System.Object
{
	static SocLogger Logger; // 0x0
	static System.Void .cctor(); // 0x06caff9c
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.Alpha3EntityUtils : System.Object
{
	static SocLogger logger; // 0x0
	static System.Boolean TryInitDamageableComponent<T>(WizardGames.Soc.Share.Framework.EntityBase entity, System.Int32 combatTemplateID, T& comp); // 0x052af1f0
	static System.Boolean UpdateDamageComponet<T>(T comp, WizardGames.Soc.Common.Data.Combat.CombatComponent table); // 0x052af1f0
	static System.Void RefreshDefenceID(WizardGames.Soc.Common.Entity.IHitableEntity dc, System.Int32 defenceID); // 0x06cb0070
	static System.Single GetDamageableHp(System.Int32 combatTemplateID, System.Single maxHp); // 0x06cb0414
	static System.Void Clone(WizardGames.Soc.Common.Entity.IHitableEntity hitableEntity, WizardGames.Soc.Common.Entity.IHitableEntity from); // 0x06cb069c
	static System.Boolean TryGetIHitable(WizardGames.Soc.Share.Framework.EntityBase entity, WizardGames.Soc.Common.Entity.IHitableEntity& hitable); // 0x06cb0974
	static System.Boolean SyncHp(WizardGames.Soc.Common.Entity.IEntity to, WizardGames.Soc.Common.Entity.IEntity from); // 0x06cb0a48
	static System.Boolean IsHitableAndDead(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06cb0d40
	static System.Boolean TryGetIHitable(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Entity.IHitableEntity& hitable); // 0x06cb0c1c
	static System.Boolean TryGetPosition(WizardGames.Soc.Common.Entity.IEntity entity, System.Numerics.Vector3& pos); // 0x06cb0e6c
	static System.Void .cctor(); // 0x06cb1084
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.ConstructionExtendUtilsHotfix : System.Object
{
	static SocLogger logger; // 0x0
	static T RequireComponent<T>(WizardGames.Soc.Share.Framework.EntityBase entity, WizardGames.Soc.Common.Component.EComponentIdEnum id, System.Boolean isManual); // 0x052af1f0
	static System.Void AddComponentRequired(WizardGames.Soc.Share.Framework.EntityBase entity, WizardGames.Soc.Share.Framework.ComponentBase comp); // 0x06cb1158
	static WizardGames.Soc.Share.Framework.ComponentBase RequireComponent(WizardGames.Soc.Share.Framework.EntityBase entity, WizardGames.Soc.Common.Data.EPartComponent ePartComponent); // 0x06cb127c
	static WizardGames.Soc.Common.CustomType.ElectricCBase GetElectricC(WizardGames.Soc.Common.Component.ElectricBaseComponent comp); // 0x06cb25d8
	static System.Void .cctor(); // 0x06cb309c
}

// Client.Runtime
enum WizardGames.Soc.Common.Utility.HoldItemIndex : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Utility.HoldItemIndex Item1 = 0;
	static WizardGames.Soc.Common.Utility.HoldItemIndex Item2 = 1;
	static WizardGames.Soc.Common.Utility.HoldItemIndex Item3 = 2;
	static WizardGames.Soc.Common.Utility.HoldItemIndex Item4 = 3;
	static WizardGames.Soc.Common.Utility.HoldItemIndex Item5 = 4;
	static WizardGames.Soc.Common.Utility.HoldItemIndex Item6 = 5;
	static WizardGames.Soc.Common.Utility.HoldItemIndex Item7 = 6;
	static WizardGames.Soc.Common.Utility.HoldItemIndex Item8 = 7;
	static WizardGames.Soc.Common.Utility.HoldItemIndex ItemHiddenUse = 8;
	static WizardGames.Soc.Common.Utility.HoldItemIndex ItemConstructModel = 9;
	static WizardGames.Soc.Common.Utility.HoldItemIndex ItemEditModel = 10;
	static WizardGames.Soc.Common.Utility.HoldItemIndex ItemElectricModel = 11;
	static WizardGames.Soc.Common.Utility.HoldItemIndex ItemFluidicModel = 12;
	static WizardGames.Soc.Common.Utility.HoldItemIndex ItemGugujiModel = 13;
	static WizardGames.Soc.Common.Utility.HoldItemIndex ItemParachuteModel = 14;
	static WizardGames.Soc.Common.Utility.HoldItemIndex ItemGuideBook = 15;
	static WizardGames.Soc.Common.Utility.HoldItemIndex End = 16;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.ItemUtility : System.Object
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Data.DataItem.ItemOperationType GetItemOperationTypeByEntityId(WizardGames.Soc.Common.Entity.IEntity itemEntity); // 0x06cb3170
	static WizardGames.Soc.Common.Data.DataItem.ItemOperationType GetItemOperationTypeByEntity(WizardGames.Soc.Common.Entity.IEntity itemEntity); // 0x06cb3318
	static WizardGames.Soc.Common.Data.DataItem.ItemOperationType GetItemOperationTypeByTableId(System.Int64 tableId); // 0x06cb3558
	static System.Single FormulaCalcNewMaxCondition(System.Single currentCondition, System.Single currentMaxCondition, System.Single conditionLossRatio); // 0x06cb377c
	static System.Boolean CanBeltAcceptItem(System.Int32 pos, WizardGames.Soc.Common.Data.DataItem.ItemConfig itemConfig); // 0x06cb381c
	static System.Int64 ItemApperanceID(WizardGames.Soc.Common.Entity.IItemEntity item); // 0x06cb3b70
	static System.Int64 ItemApperanceID(System.Int64 itemId, System.Int64 skinId); // 0x06cb3cdc
	static System.Boolean ItemHasFlag(WizardGames.Soc.Common.Data.DataItem.ItemConfig config, WizardGames.Soc.Common.Data.DataItem.ItemFlags flag); // 0x06cb3f6c
	static System.Int32 GetFuelBurnTime(System.Int64 fuelBizId, System.Int64 templateId); // 0x06cb400c
	static System.Boolean GetItemArrIndex(WizardGames.Soc.Common.Utility.HoldItemIndex holdItemIndex, System.Int32& arrIndex); // 0x06cb41b0
	static WizardGames.Soc.Common.Entity.IItemEntity GetItemEntity(WizardGames.Soc.Common.Entity.PlayerEntity self, System.Int32 id); // 0x06cb4248
	static System.Void .cctor(); // 0x06cb456c
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.ModularUtil : System.Object
{
	static SocLogger logger; // 0x0
	static System.ValueTuple<System.Int64,System.Single> GetMinCostBizid(System.Int64 moduleId, System.Collections.Generic.Dictionary<System.Int64,System.Int32> itemCountRate); // 0x06cb4640
	static System.Void GetBagItemCount(System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.VehicleModuleCustom> modules, System.Collections.Generic.Dictionary<System.Int64,System.Int32> bagItems, System.Func<System.Int64,System.Int32> getPlayerItemCount); // 0x06cb4b48
	static System.Single GetSingleModuleCost(WizardGames.Soc.Common.CustomType.VehicleModuleCustom module, System.Collections.Generic.Dictionary<System.Int64,System.Int32> bagItems, System.Collections.Generic.Dictionary<System.Int64,System.Int32> costItem); // 0x06cb4fe0
	static System.Boolean GetModulesCost(System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.VehicleModuleCustom> modules, System.Collections.Generic.Dictionary<System.Int64,System.Int32> costItem, System.Collections.Generic.Dictionary<System.Int32,System.Single> addHpDict, System.Func<System.Int64,System.Int32> getPlayerItemCount); // 0x06cb54a8
	static System.Void .cctor(); // 0x06cb573c
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.PathUtil : System.Object
{
	
	static System.Boolean IsPathInInventory(System.Collections.Generic.IEnumerable<System.Int64> path); // 0x06cb5810
	static System.Boolean IsPathInSeedBackPack(System.Collections.Generic.IEnumerable<System.Int64> path); // 0x06cb5898
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.StringCheckUtility : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.List<System.ValueTuple<System.Char,System.Char>> ChineseUnicodeRangesList; // 0x8
	static System.Collections.Generic.List<System.ValueTuple<System.Char,System.Char>> FullWidthUnicodeRangesList; // 0x10
	static System.Collections.Generic.List<System.Char> FullWidthUnicodeRangesList2; // 0x18
	static System.Collections.Generic.List<System.ValueTuple<System.Char,System.Char>> SymbolUnicodeRangesList; // 0x20
	static System.Collections.Generic.List<System.Char> SymbolUnicodeRangesList2; // 0x28
	static System.String FilterIllegalCharacters(System.String input); // 0x06cb5920
	static System.Boolean IsLegalChar(System.Char c); // 0x06cb5cc8
	static System.Int32 GetCharLengh(System.Char c); // 0x06cb63cc
	static System.Boolean IsLegalKeyboardCharacter(System.Char c); // 0x06cb5ad0
	static System.Boolean IsLegalKeyboardCharacterByStr(System.String str); // 0x06cb6878
	static System.Boolean IsFullWidthSymbols(System.Char c); // 0x06cb6140
	static System.Boolean IsNumOrLetter(System.Char c); // 0x06cb6338
	static System.String FilterHtmlTag(System.String input); // 0x06cb69b4
	static System.String FilterIllegalCharactersExcludeSpace(System.String input); // 0x06cb6b9c
	static System.Boolean IsLegalKeyboardCharacterByStrExcludeSpace(System.String str); // 0x06cb6d8c
	static System.Void .cctor(); // 0x06cb6efc
}

// Client.Runtime
struct WizardGames.Soc.Common.Utility.DampingProcessor : System.ValueType
{
	System.Single Amplitude; // 0x10
	System.Single RigidityRatio; // 0x14
	System.Single DampingRatio; // 0x18
	System.Single InitialPhase; // 0x1c
	static WizardGames.Soc.Common.Utility.DampingProcessor Create(System.Single amplitude, System.Single rigidRation, System.Single dampingRatio, System.Single initPhase); // 0x06cb8b1c
	System.Void Init(System.Single amplitude, System.Single rigidRation, System.Single dampingRatio, System.Single initPhase); // 0x06cb8bcc
	System.Single ExpSin(System.Single ExpTime); // 0x06cb8c6c
	System.Single ExpCos(System.Single ExpTime); // 0x06cb8d40
}

// Client.Runtime
interface WizardGames.Soc.Common.Utility.IRequiredComponent : 
{
	
	System.Void SetupRequirement(WizardGames.Soc.Share.Framework.EntityBase entity); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.ArrayUtil : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void ClearArray(System.Single[] protections); // 0x06cb8e14
	static System.Void AddArray(System.Single[] dst, System.Single[] amounts, System.Single scale); // 0x06cb8e94
	static System.Void AddArray(System.Single[] dst, WizardGames.Soc.Common.Algorithm.ConstList<System.Single> amounts, System.Single scale); // 0x06cb8f68
	static System.Void .cctor(); // 0x06cb9060
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.ConstructionExtendUtils : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.Stack<System.Int32> requiredStack; // 0x8
	static System.Boolean inManual; // 0x10
	static System.Boolean ConstructionHasFlag(WizardGames.Soc.Common.CustomType.IEntityWithElectric entity, WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags flag); // 0x06cb9134
	static System.Void ConstructionSetFlag(WizardGames.Soc.Common.CustomType.IEntityWithElectric entity, WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags flag, System.Boolean value); // 0x06cb92ac
	static System.Int32 GetConfig_ConstructionFlag(WizardGames.Soc.Share.Framework.EntityBase entity); // 0x06cb9428
	static System.Boolean ConstructionHasFlag(WizardGames.Soc.Share.Framework.EntityBase entity, WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags flag); // 0x06cb94c8
	static WizardGames.Soc.Common.Data.constraction.ElectricalItem GetConfig_ElectricalItem(WizardGames.Soc.Common.CustomType.IEntityWithElectric entity); // 0x06cb9584
	static System.Void .cctor(); // 0x06cb96d4
}

// Client.Runtime
enum WizardGames.Soc.Common.Utility.EquipOwner : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Utility.EquipOwner None = 0;
	static WizardGames.Soc.Common.Utility.EquipOwner HumanOrCorpse = 1;
	static WizardGames.Soc.Common.Utility.EquipOwner Horse = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.EquipUtil : System.Object
{
	static System.Int32[] EquipPartFxPriority; // 0x0
	static System.Boolean GetWearItemTableIds(WizardGames.Soc.Common.Entity.IEquipEntity equipEntity, System.Collections.Generic.List<System.Int64> wearItemTableIds); // 0x06cb9800
	static System.Void GetWearItemList(WizardGames.Soc.Common.Entity.IEquipEntity equipEntity, System.Collections.Generic.List<WizardGames.Soc.Common.Entity.IWearItemEntity> wearItemList); // 0x06cb9af4
	static System.Boolean HasAffectPart(System.Int32[] effectpart, System.Int32 part); // 0x06cb9d7c
	static System.Int32 PartFxPriority(System.Int32 belongPartId); // 0x06cb9e28
	static System.Int32[] GetOccupyPosition(System.Int64 id); // 0x06cb9f0c
	static System.Void .cctor(); // 0x06cba130
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.FloatUtil : System.Object
{
	
	static System.Boolean IsGreater(System.Single x, System.Single y); // 0x06cba1d0
}

// Client.Runtime
class WizardGames.Soc.Common.Utility.UniformRandom : System.Object
{
	[ThreadStatic] static System.Int32 m_idum;
	[ThreadStatic] static System.Int32 m_iy;
	static System.Collections.Concurrent.ConcurrentDictionary<System.Int32,System.Int32> m_iv; // 0x0
	static System.Void setSeed(System.Int32 seed); // 0x06cba258
	static System.Int32 generateRandomNumber(); // 0x06cba300
	static System.Int32 randomInt(System.Int32 seed, System.Int32 iLow, System.Int32 iHigh); // 0x06cba700
	static System.Single randomFloat(System.Int32 seed, System.Single flLow, System.Single flHigh); // 0x06cb05d0
	static System.Void .cctor(); // 0x06cba7f4
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.ThreadSafeAttribute : System.Attribute
{
	
	System.Void .ctor(); // 0x06cba88c
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.LogicThreadAttribute : System.Attribute
{
	
	System.Void .ctor(); // 0x06cba8f4
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.MainThreadAttribute : System.Attribute
{
	
	System.Void .ctor(); // 0x06cba95c
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.WorkerThreadAttribute : System.Attribute
{
	
	System.Void .ctor(); // 0x06cba9c4
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.LinkableMemorySegment : System.Buffers.ReadOnlySequenceSegment<System.Byte>, System.IDisposable
{
	System.Buffers.IMemoryOwner<System.Byte> memOwner; // 0x30
	System.ArraySegment<System.Byte> Buffer; // 0x38
	System.Int32 <Position>k__BackingField; // 0x48
	System.Int32 get_Position(); // 0x06cbaa2c
	System.Void set_Position(System.Int32 value); // 0x06cbaa90
	System.Int32 get_RemainSize(); // 0x06cbab08
	System.Void .ctor(System.Int32 size); // 0x06cbabe8
	System.Void Link(WizardGames.Soc.Common.Framework.LinkableMemorySegment next); // 0x06cbaed4
	System.Void Advance(System.Int32 count); // 0x06cbb2e0
	System.Void Dispose(); // 0x06cbb3e8
	System.Void Reset(); // 0x06cbb4c8
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.MemorySegmentChain : System.Object
{
	WizardGames.Soc.Common.Framework.LinkableMemorySegment headSegment; // 0x10
	WizardGames.Soc.Common.Framework.LinkableMemorySegment currentSegment; // 0x18
	System.Int32 segmentSize; // 0x20
	System.Void .ctor(System.Int32 segmentSize); // 0x06cbb678
	System.Void Ensure(System.Int32 sizeHint); // 0x06cbb744
	System.Void Advance(System.Int32 count); // 0x06cbb834
	System.Memory<System.Byte> GetMemory(System.Int32 sizeHint); // 0x06cbb8b8
	System.Span<System.Byte> GetSpan(System.Int32 sizeHint); // 0x06cbba58
	System.Void Reset(); // 0x06cbbbe0
	System.Buffers.ReadOnlySequence<System.Byte> GetSequence(); // 0x06cbbd14
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.FixSizeArrayWriter : System.Object, System.Buffers.IBufferWriter<System.Byte>, System.IDisposable, WizardGames.Soc.Common.Cache.ICacheObject
{
	static SocLogger logger; // 0x0
	static System.Int32 DEFAULT_SEGMENT_SIZE = 10240;
	WizardGames.Soc.Common.Framework.MemorySegmentChain memChain; // 0x10
	System.Boolean <IsReturn>k__BackingField; // 0x18
	System.Void .ctor(System.Int32 segmentSize); // 0x06cbbe14
	System.Boolean get_IsReturn(); // 0x06cbbec8
	System.Void set_IsReturn(System.Boolean value); // 0x06cbbf2c
	System.Void Advance(System.Int32 count); // 0x06cbbfa8
	System.Buffers.ReadOnlySequence<System.Byte> GetSequence(); // 0x06cbc02c
	System.Memory<System.Byte> GetMemory(System.Int32 sizeHint); // 0x06cbc0b0
	System.Span<System.Byte> GetSpan(System.Int32 sizeHint); // 0x06cbc134
	System.Void Reset(); // 0x06cbc1b8
	System.Void Dispose(); // 0x06cbc224
	static System.Void .cctor(); // 0x06cbc288
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.LinkableMemoryBuffer : System.Buffers.ReadOnlySequenceSegment<System.Byte>, WizardGames.Soc.Common.Cache.IPooledObject
{
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Common.Framework.LinkableMemoryBuffer> Pool; // 0x0
	WizardGames.Soc.Common.Framework.MemoryBuffer memoryBuffer; // 0x30
	System.Int32 <Position>k__BackingField; // 0x38
	System.Boolean <IsReturn>k__BackingField; // 0x3c
	System.Int32 get_Position(); // 0x06cbc35c
	System.Void set_Position(System.Int32 value); // 0x06cbc3c0
	System.Int32 get_RemainSize(); // 0x06cbc438
	System.ArraySegment<System.Byte>& get_MemoryAvailable(); // 0x06cbc58c
	System.Boolean get_HasMultipleSegments(); // 0x06cbc5fc
	System.Boolean get_IsReturn(); // 0x06cbc674
	System.Void set_IsReturn(System.Boolean value); // 0x06cbc6d8
	System.Void .ctor(); // 0x06cbc754
	WizardGames.Soc.Common.Framework.LinkableMemoryBuffer Init(System.Int32 size); // 0x06cbc7d0
	System.Void WriteByte(System.Byte b); // 0x06cbcb2c
	System.Void Link(WizardGames.Soc.Common.Framework.LinkableMemoryBuffer nextSegment); // 0x06cbcd1c
	System.Void Advance(System.Int32 count); // 0x06cbd0dc
	System.Void ReturnToPool(); // 0x06cbd1e4
	WizardGames.Soc.Common.Framework.MemoryBuffer MoveMemory(); // 0x06cbd49c
	static System.Void .cctor(); // 0x06cbd5fc
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.ChainedMemoryBufferWriter : System.Object, System.Buffers.IBufferWriter<System.Byte>, System.IDisposable, WizardGames.Soc.Common.Cache.IPooledObject
{
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Common.Framework.ChainedMemoryBufferWriter> Pool; // 0x0
	WizardGames.Soc.Common.Framework.LinkableMemoryBuffer headSegment; // 0x10
	WizardGames.Soc.Common.Framework.LinkableMemoryBuffer currentSegment; // 0x18
	System.Boolean <IsReturn>k__BackingField; // 0x20
	System.Boolean get_IsReturn(); // 0x06cbd69c
	System.Void set_IsReturn(System.Boolean value); // 0x06cbd700
	System.Boolean get_HasMultipleSegments(); // 0x06cbd77c
	System.Void .ctor(); // 0x06cbd7e8
	WizardGames.Soc.Common.Framework.ChainedMemoryBufferWriter Init(System.Int32 segmentSize); // 0x06cbd850
	System.Void Ensure(System.Int32 sizeHint); // 0x06cbd94c
	System.Void WriteByte(System.Byte b); // 0x06cbda80
	System.Void Advance(System.Int32 count); // 0x06cbdb10
	System.Memory<System.Byte> GetMemory(System.Int32 sizeHint); // 0x06cbdb94
	System.Span<System.Byte> GetSpan(System.Int32 sizeHint); // 0x06cbdd04
	System.Void Dispose(); // 0x06cbddb8
	System.Buffers.ReadOnlySequence<System.Byte> GetSequence(); // 0x06cbdec4
	WizardGames.Soc.Common.Framework.LinkableMemoryBuffer MoveAllMemoryBuffer(); // 0x06cbdfc4
	System.Void ReturnToPool(); // 0x06cbe04c
	WizardGames.Soc.Common.Framework.MemoryBuffer MoveFromWriter(); // 0x06cbe108
	static System.Void .cctor(); // 0x06cbe324
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.MemoryBuffer : System.Object, WizardGames.Soc.Common.Cache.IPooledObject
{
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Common.Framework.MemoryBuffer> pool; // 0x0
	static SocLogger logger; // 0x8
	System.Buffers.IMemoryOwner<System.Byte> memoryOwner; // 0x10
	System.ArraySegment<System.Byte> memoryAsArray; // 0x18
	System.ArraySegment<System.Byte> MemoryAvailable; // 0x28
	System.Boolean <IsReturn>k__BackingField; // 0x38
	System.Int32 refCount; // 0x3c
	System.Int32 WriteCount; // 0x40
	System.Int32 get_FreeAnterior(); // 0x06cbe3c4
	System.Int32 get_FreePosterior(); // 0x06cbc9d4
	System.Int32 get_Length(); // 0x06cbc4f8
	System.Boolean get_IsReturn(); // 0x06cbe460
	System.Void set_IsReturn(System.Boolean value); // 0x06cbe4c4
	System.Boolean get_IsSharing(); // 0x06cbe540
	System.Void .ctor(); // 0x06cbe5ac
	static WizardGames.Soc.Common.Framework.MemoryBuffer GetFromPool(System.Int32 desiredSize); // 0x06cbc908
	WizardGames.Soc.Common.Framework.MemoryBuffer Init(System.Int32 desiredSize, System.Int32 reserveSize); // 0x06cbe614
	static System.Int32 CalcSizePower(System.Int32 desiredSize); // 0x06cbe998
	System.Void Resize(System.Int32 newSize); // 0x06cbea38
	System.Void MakeSpaceBack(System.Int32 appendSize); // 0x06cbca7c
	System.Void MakeSpaceFront(System.Int32 appendSize); // 0x06cbef60
	System.Void ShrinkFront(System.Int32 size); // 0x06cbf518
	System.Void ReturnToPool(); // 0x06cbd350
	System.Void Clear(); // 0x06cbf640
	WizardGames.Soc.Common.Framework.MemoryBuffer CopyFromThis(); // 0x06cbf7e8
	System.Void Finalize(); // 0x06cbf924
	static System.Void .cctor(); // 0x06cbfa7c
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Algorithm.CRC32.CrcHelper : System.Object
{
	static SocLogger logger; // 0x0
	static System.Boolean CheckOnePacket(System.Memory<System.Byte>& singlePacketBody); // 0x06cbfbd0
	static System.Void .cctor(); // 0x06cbff6c
}

// Client.Runtime
interface WizardGames.Soc.Common.Framework.Types.ISerializeType : 
{
	static System.Byte[] EndSignal; // 0x0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x05525bf4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x05525b70
	static System.Void .cctor(); // 0x06cc0040
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Types.CustomTypeFactory : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor> constructorsByHash; // 0x0
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.ICustomTypeConstructorByJson> ConstructorsByHashByJson; // 0x8
	static System.Void RegisterCustomTypeConstructor(System.Int32 hashCode, WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor ctor); // 0x06cc00d0
	static System.Void RegisterCustomTypeConstructor(System.Int32 hashCode, WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.ICustomTypeConstructorByJson ctor); // 0x06cc019c
	static WizardGames.Soc.Common.Framework.Types.ISerializeType ConstructCustomTypeByHash(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06cc0268
	static WizardGames.Soc.Common.Framework.Types.ISerializeType ConstructCustomTypeByHash(System.Int32 hashValue, MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06cc0434
	static WizardGames.Soc.Common.Framework.Types.ISerializeType ConstructCustomTypeByJson(SimpleJSON.JSONNode jsonData); // 0x06cc05d0
	static System.Void .cctor(); // 0x06cc07d4
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.IDeserializeConstructor : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x06cc08c8
	WizardGames.Soc.Common.Framework.Types.ISerializeType Invoke(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06cc09a4
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Types.CustomTypeFactory.ICustomTypeConstructorByJson : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x06cc0a00
	WizardGames.Soc.Common.Framework.Types.ISerializeType Invoke(SimpleJSON.JSONNode jsonData); // 0x06cc0b30
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Types.TypeHelperCommon<T> : System.Object
{
	static System.Boolean IsValueType; // 0x0
	static System.Boolean IsStringType; // 0x1
	static WizardGames.Soc.Common.Framework.Types.TypeHelperCommon.SetParamFunc<T> SetValueToUnion; // 0x8
	static WizardGames.Soc.Common.Framework.Types.TypeHelperCommon.GetParamFunc<T> GetValueFromUnion; // 0x10
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Types.TypeHelperCommon.SetParamFunc<T> : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05525a60
	System.Void Invoke(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union, T value); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Types.TypeHelperCommon.GetParamFunc<T> : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05525a60
	T Invoke(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Types.TypeHelperCommon.<>c<T> : System.Object
{
	static WizardGames.Soc.Common.Framework.Types.TypeHelperCommon.<>c<T> <>9; // 0x0
	static System.Void .cctor(); // 0x054fd168
	System.Void .ctor(); // 0x055049cc
	System.Int32 <.cctor>b__2_0(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union); // 0x0549a128
	System.Int64 <.cctor>b__2_1(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union); // 0x054a4a40
	System.Single <.cctor>b__2_2(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union); // 0x054a6f88
	System.Double <.cctor>b__2_3(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union); // 0x054a7968
	System.Boolean <.cctor>b__2_4(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union); // 0x054dec74
	System.Byte <.cctor>b__2_5(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union); // 0x054dec74
	System.Int16 <.cctor>b__2_6(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union); // 0x05485e40
	System.UInt16 <.cctor>b__2_7(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union); // 0x054e1b98
	System.UInt32 <.cctor>b__2_8(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union); // 0x054e225c
	System.UInt64 <.cctor>b__2_9(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union); // 0x054e281c
	System.Void <.cctor>b__2_10(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union, System.Int32 value); // 0x05525b70
	System.Void <.cctor>b__2_11(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union, System.Int64 value); // 0x05527094
	System.Void <.cctor>b__2_12(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union, System.Single value); // 0x05527688
	System.Void <.cctor>b__2_13(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union, System.Double value); // 0x05527b9c
	System.Void <.cctor>b__2_14(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union, System.Boolean value); // 0x0552af28
	System.Void <.cctor>b__2_15(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union, System.Byte value); // 0x0552af28
	System.Void <.cctor>b__2_16(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union, System.Int16 value); // 0x05525ae4
	System.Void <.cctor>b__2_17(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union, System.UInt16 value); // 0x0552b750
	System.Void <.cctor>b__2_18(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union, System.UInt32 value); // 0x0552b7dc
	System.Void <.cctor>b__2_19(WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion& union, System.UInt64 value); // 0x0552b938
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.ThreadTaskManager : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Collections.Concurrent.ConcurrentQueue<System.Action> callbackQueue; // 0x18
	static SocLogger Logger; // 0x0
	System.Void .ctor(); // 0x06cc0b7c
	System.Void PostToMainThread(System.Action callback); // 0x06cc0c30
	System.Void Update(); // 0x06cc0ccc
	static System.Void .cctor(); // 0x06cc0f24
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.WebSocketNoticeManager : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Collections.Concurrent.ConcurrentQueue<WizardGames.Soc.Common.Framework.Network.WebSocketNoticeManager.SimpleCallback> _callbackQueue; // 0x18
	static SocLogger Logger; // 0x0
	System.Void PostToMainThread(WizardGames.Soc.Common.Framework.Network.WebSocketNoticeManager.SimpleCallback callback); // 0x06cc0ff8
	System.Void Update(); // 0x06cc1094
	System.Void .ctor(); // 0x06cc12ec
	static System.Void .cctor(); // 0x06cc13a0
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.WebSocketNoticeManager.SimpleCallback : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x06cc1474
	System.Void Invoke(); // 0x06cc1538
}

// Client.Runtime
enum WizardGames.Soc.Common.Framework.Network.EPacketType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Framework.Network.EPacketType EntityRpc = 0;
	static WizardGames.Soc.Common.Framework.Network.EPacketType EntityRpcWithCrc = 1;
	static WizardGames.Soc.Common.Framework.Network.EPacketType EntityRpcWithCompress = 2;
	static WizardGames.Soc.Common.Framework.Network.EPacketType EntityRpcWithCompressAndCrc = 3;
	static WizardGames.Soc.Common.Framework.Network.EPacketType ClientRpcTransfer = 4;
	static WizardGames.Soc.Common.Framework.Network.EPacketType S2CRpcTransfer = 6;
	static WizardGames.Soc.Common.Framework.Network.EPacketType System = 7;
	static WizardGames.Soc.Common.Framework.Network.EPacketType RunCode = 8;
	static WizardGames.Soc.Common.Framework.Network.EPacketType BatchPacket = 9;
	static WizardGames.Soc.Common.Framework.Network.EPacketType BatchPacketWithCompress = 10;
	static WizardGames.Soc.Common.Framework.Network.EPacketType BatchPacketWithCrc = 11;
	static WizardGames.Soc.Common.Framework.Network.EPacketType BatchPacketWithCompressAndCrc = 12;
	static WizardGames.Soc.Common.Framework.Network.EPacketType EntityRpcWithExtraPayload = 13;
	static WizardGames.Soc.Common.Framework.Network.EPacketType FragmentPacket = 14;
	static WizardGames.Soc.Common.Framework.Network.EPacketType EntityRpcResponseClient = 15;
	static WizardGames.Soc.Common.Framework.Network.EPacketType EntityRpcResponseClientWithCrc = 16;
	static WizardGames.Soc.Common.Framework.Network.EPacketType PeerToPeerPacket = 17;
	static WizardGames.Soc.Common.Framework.Network.EPacketType ServiceRoutingPacket = 18;
	static WizardGames.Soc.Common.Framework.Network.EPacketType MaxValue = 63;
	static WizardGames.Soc.Common.Framework.Network.EPacketType PacketWithTimestampMask = 64;
	
}

// Client.Runtime
interface WizardGames.Soc.Common.Framework.Network.IOutgoingPacket : 
{
	
	WizardGames.Soc.Common.Framework.Network.EPacketType get_PacketType(); // 0x0548ba98
	System.Buffers.ReadOnlySequence<System.Byte> GetBuffer(); // 0x054b3a0c
	System.Byte GetPacketType(); // 0x054c4760
}

// Client.Runtime
interface WizardGames.Soc.Common.Framework.Network.IMehtodIdPacket : 
{
	
	System.Int32 get_MethodId(); // 0x0548ba98
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.BasePacket : System.Object, WizardGames.Soc.Common.Cache.IPooledObject
{
	WizardGames.Soc.Common.Framework.Network.EPacketType <PacketType>k__BackingField; // 0x10
	System.Boolean <IsReturn>k__BackingField; // 0x14
	WizardGames.Soc.Common.Framework.Network.EPacketType get_PacketType(); // 0x06cc157c
	System.Void set_PacketType(WizardGames.Soc.Common.Framework.Network.EPacketType value); // 0x06cc15e0
	System.Boolean get_IsReturn(); // 0x06cc1658
	System.Void set_IsReturn(System.Boolean value); // 0x06cc16bc
	System.Void .ctor(WizardGames.Soc.Common.Framework.Network.EPacketType packetType); // 0x06cc1738
	System.Void .ctor(); // 0x06cc17f0
	System.Byte GetPacketType(); // 0x06cc1858
	System.Void ReturnToPool(); // 0x055049cc
}

// Client.Runtime
enum WizardGames.Soc.Common.Framework.Network.DisconnectReason : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Framework.Network.DisconnectReason Unknown = 0;
	static WizardGames.Soc.Common.Framework.Network.DisconnectReason ConnectionFailed = 1;
	static WizardGames.Soc.Common.Framework.Network.DisconnectReason RemoteClose = 2;
	static WizardGames.Soc.Common.Framework.Network.DisconnectReason Timeout = 3;
	static WizardGames.Soc.Common.Framework.Network.DisconnectReason Force = 4;
	static WizardGames.Soc.Common.Framework.Network.DisconnectReason Congestion = 5;
	static WizardGames.Soc.Common.Framework.Network.DisconnectReason InvalidSend = 6;
	static WizardGames.Soc.Common.Framework.Network.DisconnectReason InvalidReceive = 7;
	static WizardGames.Soc.Common.Framework.Network.DisconnectReason ConnectionClosed = 8;
	static WizardGames.Soc.Common.Framework.Network.DisconnectReason Unexpected = 9;
	static WizardGames.Soc.Common.Framework.Network.DisconnectReason CookieError = 10;
	static WizardGames.Soc.Common.Framework.Network.DisconnectReason SocketError = 11;
	static WizardGames.Soc.Common.Framework.Network.DisconnectReason DnsResolve = 12;
	static WizardGames.Soc.Common.Framework.Network.DisconnectReason Expected = 13;
	static WizardGames.Soc.Common.Framework.Network.DisconnectReason LogicError = 14;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.EncryptBase : System.Object
{
	static SocLogger logger; // 0x0
	static System.Security.Cryptography.Aes aes; // 0x8
	System.UInt32[] mt; // 0x10
	System.UInt32 Seed; // 0x18
	System.Int64 UseIndex; // 0x20
	System.Boolean Inited; // 0x28
	System.UInt32 currentKey; // 0x2c
	System.Int32 state; // 0x30
	System.Void .ctor(); // 0x06cc1900
	System.Void InitMT(System.UInt32 seed); // 0x06cc1b74
	System.Void GenerateMT(); // 0x06cc1c5c
	System.Void InitAes(); // 0x06cc19e0
	System.UInt32 Rand(); // 0x06cc1da0
	System.Void XorData(System.ArraySegment<System.Byte>& data); // 0x06cc1e88
	System.Void XorData(System.ArraySegment<System.Byte>& data, System.Int32 offset, System.Int32 countLeft); // 0x06cc1f3c
	System.Void XorData(System.Memory<System.Byte>& data); // 0x06cc22e8
	static System.Void .cctor(); // 0x06cc2418
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Encrypter : WizardGames.Soc.Common.Framework.Network.EncryptBase
{
	
	System.Void .ctor(System.UInt32 seed); // 0x06cc24ec
	System.Byte[] AesEncrypt(); // 0x06cc2598
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Decrypter : WizardGames.Soc.Common.Framework.Network.EncryptBase
{
	
	System.Void .ctor(); // 0x06cc2734
	System.Byte[] AesDecrypt(System.Byte[] cipherBytes, System.Int32 offset, System.Int32 length); // 0x06cc27bc
	System.Boolean CheckCipherBytes(System.Byte[] cipherBytes, System.Int32 offset, System.Int32 length); // 0x06cc28f4
}

// Client.Runtime
enum WizardGames.Soc.Common.Framework.Network.Endpoint : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Framework.Network.Endpoint None = 0;
	static WizardGames.Soc.Common.Framework.Network.Endpoint Client = 1;
	static WizardGames.Soc.Common.Framework.Network.Endpoint World = 2;
	static WizardGames.Soc.Common.Framework.Network.Endpoint Simulator = 3;
	static WizardGames.Soc.Common.Framework.Network.Endpoint Auxiliary = 4;
	static WizardGames.Soc.Common.Framework.Network.Endpoint Console = 5;
	static WizardGames.Soc.Common.Framework.Network.Endpoint Gate = 6;
	static WizardGames.Soc.Common.Framework.Network.Endpoint Router = 7;
	
}

// Client.Runtime
interface WizardGames.Soc.Common.Framework.Network.INetworkCompressor : 
{
	
	
}

// Client.Runtime
interface WizardGames.Soc.Common.Framework.Network.INetworkDecompressor : 
{
	
	System.Int32 Decompress(System.Byte* compressed, System.Byte* decompressedBuffer, System.Int32 compressedLength, System.Int32 decompressedLength); // 0x054a3e28
}

// Client.Runtime
struct WizardGames.Soc.Common.Framework.Network.SyncMsgCounter : System.ValueType
{
	System.Int64 deltaSyncSize; // 0x10
	System.Int64 fullSyncSize; // 0x18
	System.Int64 snapshotEventSize; // 0x20
	System.Int64 removeEntitySize; // 0x28
	System.Int64 propertyGroupSize; // 0x30
	System.Int64 offset; // 0x38
	System.Void .ctor(MessagePack.MessagePackReader& reader); // 0x06cc29b8
}

// Client.Runtime
struct WizardGames.Soc.Common.Framework.Network.BriefNetStat : System.ValueType
{
	System.Int64 recvRawRate; // 0x10
	System.Int64 sendRawRate; // 0x18
	System.Int64 recvRawPacketRate; // 0x20
	System.Int64 sendRawPacketRate; // 0x28
	System.Int32 recvPacketCountRate; // 0x30
	System.Int32 sendPacketCountRate; // 0x34
	
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.NetFlowCounter : System.Object
{
	static WizardGames.Soc.Common.Framework.Network.NetFlowCounter <Instance>k__BackingField; // 0x0
	static SocLogger logger; // 0x8
	System.Boolean <EnableDetailRecord>k__BackingField; // 0x10
	System.Int64 startTime; // 0x18
	System.Int64 rawRecvSize; // 0x20
	System.Int32 rawRecvCount; // 0x28
	System.Int64 rawPacketSize; // 0x30
	System.Int32 rawPacketCount; // 0x38
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Framework.Network.NetFlowCounter.Record> rpcRecords; // 0x40
	System.Int64 rawSendSize; // 0x48
	System.Int32 rawSendCount; // 0x50
	System.Int64 sendRacketSize; // 0x58
	System.Int32 sendPacketCount; // 0x60
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Framework.Network.NetFlowCounter.Record> rpcSendRecords; // 0x68
	System.Object syncCounterLock; // 0x70
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Framework.Network.NetFlowCounter.Record> fullSyncRecords; // 0x78
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Framework.Network.NetFlowCounter.Record> fullSyncAddCompRecords; // 0x80
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Framework.Network.NetFlowCounter.Record> deltaSyncRecords; // 0x88
	System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Framework.Network.NetFlowCounter.Record>> detailPropRecords; // 0x90
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Framework.Network.NetFlowCounter.Record> propertyGroupSyncRecords; // 0x98
	System.Collections.Generic.Stack<System.String> curPropContext; // 0xa0
	Cysharp.Text.Utf16ValueStringBuilder builder; // 0xa8
	static WizardGames.Soc.Common.Framework.Network.NetFlowCounter get_Instance(); // 0x06cc2a44
	System.Boolean get_EnableDetailRecord(); // 0x06cc2acc
	System.Void .ctor(); // 0x06cc2b30
	System.Void GetBriefStat(WizardGames.Soc.Common.Framework.Network.BriefNetStat& netStat); // 0x06cc2e10
	System.Void RecvRawData(System.Int64 size); // 0x06cc2f78
	System.Void SendRawData(System.Int64 size); // 0x06cc3004
	System.Void RecvRawPacket(System.Int64 size); // 0x06cc3090
	System.Void SendRawPacket(System.Int64 size); // 0x06cc311c
	static System.Void .cctor(); // 0x06cc31a8
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.NetFlowCounter.Record : System.Object
{
	
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Framework.Network.ECompressorType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Framework.Network.ECompressorType Lz4 = 0;
	static WizardGames.Soc.Common.Framework.Network.ECompressorType Zstd = 1;
	static WizardGames.Soc.Common.Framework.Network.ECompressorType None = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.NetworkDecompressorFactory : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Framework.Network.ECompressorType,System.Func<WizardGames.Soc.Common.Framework.Network.INetworkDecompressor>> decompressorFactories; // 0x8
	static WizardGames.Soc.Common.Framework.Network.INetworkDecompressor CreateNew(WizardGames.Soc.Common.Framework.Network.ECompressorType decompressorType); // 0x06cc32ac
	static System.Void .cctor(); // 0x06cc3400
}

// Client.Runtime
enum WizardGames.Soc.Common.Framework.Network.ERpcTarget : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Framework.Network.ERpcTarget OwnClient = 1;
	static WizardGames.Soc.Common.Framework.Network.ERpcTarget OtherClients = 2;
	static WizardGames.Soc.Common.Framework.Network.ERpcTarget AllClients = 3;
	static WizardGames.Soc.Common.Framework.Network.ERpcTarget Simulator = 4;
	static WizardGames.Soc.Common.Framework.Network.ERpcTarget World = 16;
	static WizardGames.Soc.Common.Framework.Network.ERpcTarget BroadcastClients = 35;
	static WizardGames.Soc.Common.Framework.Network.ERpcTarget ResponeClient = 67;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.ReceivedEntityRpcPacket : WizardGames.Soc.Common.Framework.Network.BasePacket
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Common.Framework.Network.ReceivedEntityRpcPacket> pool; // 0x8
	System.Int64 EntityId; // 0x18
	System.Int32 ComponentId; // 0x20
	System.Int32 MethodId; // 0x24
	WizardGames.Soc.Common.Framework.Network.ERpcTarget Target; // 0x28
	System.Memory<System.Byte> Payload; // 0x30
	System.Memory<System.Byte> RawReceived; // 0x40
	System.Object DecodedRpc; // 0x50
	System.Int64 ClientReceiveTs; // 0x58
	System.Int64 AoiSendTs; // 0x60
	System.Int64 GateSendTs; // 0x68
	System.Void .ctor(); // 0x06cc35a8
	static WizardGames.Soc.Common.Framework.Network.ReceivedEntityRpcPacket GetFromPool(System.Memory<System.Byte>& data); // 0x06cc3610
	static WizardGames.Soc.Common.Framework.Network.ReceivedEntityRpcPacket GetHeaderFromPool(MessagePack.MessagePackReader& reader); // 0x06cc3808
	System.Void ReturnToPool(); // 0x06cc3910
	System.Void DereferencePayload(); // 0x06cc3abc
	static System.Void .cctor(); // 0x06cc3b6c
}

// Client.Runtime
struct WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion : System.ValueType
{
	System.Int32 IntValue; // 0x10
	System.Int64 LongValue; // 0x10
	System.Single FloatValue; // 0x10
	System.Double DoubleValue; // 0x10
	System.Boolean BoolValue; // 0x10
	System.Byte ByteValue; // 0x10
	System.Int16 ShortValue; // 0x10
	System.UInt16 UShortValue; // 0x10
	System.UInt32 UIntValue; // 0x10
	System.UInt64 ULongValue; // 0x10
	System.Int32 Type; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.EntityRpcRecord : System.Object
{
	System.Int32 MethodId; // 0x10
	System.Int64 Ts; // 0x18
	System.Int32 ParamsCount; // 0x20
	WizardGames.Soc.Common.Framework.Network.BasicValueTypeUnion[] BasicValueParams; // 0x28
	System.Void .ctor(); // 0x06cc3ca0
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.EntityRpcPacket : WizardGames.Soc.Common.Framework.Network.BasePacket, WizardGames.Soc.Common.Framework.Network.IOutgoingPacket, WizardGames.Soc.Common.Framework.Network.IMehtodIdPacket
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Common.Framework.Network.EntityRpcPacket> pool; // 0x8
	WizardGames.Soc.Common.Framework.MemoryBuffer buffer; // 0x18
	WizardGames.Soc.Common.Framework.ChainedMemoryBufferWriter bufferWriter; // 0x20
	static WizardGames.Soc.Common.Framework.Network.EntityRpcRecord currentRpcRecord; // 0x10
	static System.Collections.Generic.Queue<WizardGames.Soc.Common.Framework.Network.EntityRpcRecord> EntityRpcRecords; // 0x18
	System.Int32 <MethodId>k__BackingField; // 0x28
	System.Boolean <NeedDownlinkTimestamp>k__BackingField; // 0x2c
	System.Boolean <ForceFlush>k__BackingField; // 0x2d
	System.Int32 ResponseNetPeerId; // 0x30
	System.Void StartRpcRecord(System.Int32 methodId); // 0x06cc3d08
	System.Void EndRpcRecord(); // 0x06cc3f78
	System.Int32 get_MethodId(); // 0x06cc406c
	System.Void set_MethodId(System.Int32 value); // 0x06cc40d0
	System.Void set_NeedDownlinkTimestamp(System.Boolean value); // 0x06cc4148
	System.Void set_ForceFlush(System.Boolean value); // 0x06cc41c4
	static System.Void .cctor(); // 0x06cc4240
	System.Void .ctor(); // 0x06cc4c18
	static WizardGames.Soc.Common.Framework.Network.EntityRpcPacket GetFromPool(); // 0x06cc4c80
	WizardGames.Soc.Common.Framework.MemoryBuffer MoveBuffer(); // 0x06cc4da8
	System.Void ReturnToPool(); // 0x06cc4f14
	System.Buffers.ReadOnlySequence<System.Byte> GetBuffer(); // 0x06cc50f0
	System.Void TransferOwnershipToBuffer(); // 0x06cc4e78
	System.Void Append(System.Byte b); // 0x06cc522c
	System.Void Append(System.ArraySegment<System.Byte>& segment); // 0x06cc52b0
	static System.Void SerializeOneParam<T>(MessagePack.MessagePackWriter& writer, T p); // 0x052af1f0
	WizardGames.Soc.Common.Framework.Network.EntityRpcPacket Init(System.Int64 entityId, System.Int32 componentId, System.Int32 methodId, WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06cc5468
	WizardGames.Soc.Common.Framework.Network.EntityRpcPacket Init<T1>(System.Int64 entityId, System.Int32 componentId, System.Int32 methodId, WizardGames.Soc.Common.Framework.Network.ERpcTarget target, T1 p1); // 0x052af1f0
	WizardGames.Soc.Common.Framework.Network.EntityRpcPacket Init<T1,T2>(System.Int64 entityId, System.Int32 componentId, System.Int32 methodId, WizardGames.Soc.Common.Framework.Network.ERpcTarget target, T1 p1, T2 p2); // 0x052af1f0
	WizardGames.Soc.Common.Framework.Network.EntityRpcPacket Init<T1,T2,T3>(System.Int64 entityId, System.Int32 componentId, System.Int32 methodId, WizardGames.Soc.Common.Framework.Network.ERpcTarget target, T1 p1, T2 p2, T3 p3); // 0x052af1f0
	WizardGames.Soc.Common.Framework.Network.EntityRpcPacket Init<T1,T2,T3,T4>(System.Int64 entityId, System.Int32 componentId, System.Int32 methodId, WizardGames.Soc.Common.Framework.Network.ERpcTarget target, T1 p1, T2 p2, T3 p3, T4 p4); // 0x052af1f0
	WizardGames.Soc.Common.Framework.Network.EntityRpcPacket Init<T1,T2,T3,T4,T5>(System.Int64 entityId, System.Int32 componentId, System.Int32 methodId, WizardGames.Soc.Common.Framework.Network.ERpcTarget target, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5); // 0x052af1f0
	WizardGames.Soc.Common.Framework.Network.EntityRpcPacket Init<T1,T2,T3,T4,T5,T6>(System.Int64 entityId, System.Int32 componentId, System.Int32 methodId, WizardGames.Soc.Common.Framework.Network.ERpcTarget target, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6); // 0x052af1f0
	WizardGames.Soc.Common.Framework.Network.EntityRpcPacket Init<T1,T2,T3,T4,T5,T6,T7>(System.Int64 entityId, System.Int32 componentId, System.Int32 methodId, WizardGames.Soc.Common.Framework.Network.ERpcTarget target, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7); // 0x052af1f0
	WizardGames.Soc.Common.Framework.Network.EntityRpcPacket Init<T1,T2,T3,T4,T5,T6,T7,T8>(System.Int64 entityId, System.Int32 componentId, System.Int32 methodId, WizardGames.Soc.Common.Framework.Network.ERpcTarget target, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.EntityRpcPacket.<>c : System.Object
{
	static WizardGames.Soc.Common.Framework.Network.EntityRpcPacket.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x06cc55dc
	System.Void .ctor(); // 0x06cc5640
	System.Void <.cctor>b__24_0(WizardGames.Soc.Common.Algorithm.Vector3 value, MessagePack.MessagePackWriter& writer); // 0x06cc56a8
	System.Void <.cctor>b__24_1(System.Int32 value, MessagePack.MessagePackWriter& writer); // 0x06cc5778
	System.Void <.cctor>b__24_2(System.Int64 value, MessagePack.MessagePackWriter& writer); // 0x06cc5888
	System.Void <.cctor>b__24_3(System.Single value, MessagePack.MessagePackWriter& writer); // 0x06cc5998
	System.Void <.cctor>b__24_4(System.Double value, MessagePack.MessagePackWriter& writer); // 0x06cc5ab4
	System.Void <.cctor>b__24_5(System.String value, MessagePack.MessagePackWriter& writer); // 0x06cc5bd0
	System.Void <.cctor>b__24_6(System.Boolean value, MessagePack.MessagePackWriter& writer); // 0x06cc5c58
	System.Void <.cctor>b__24_7(System.Byte value, MessagePack.MessagePackWriter& writer); // 0x06cc5d6c
	System.Void <.cctor>b__24_8(System.Int16 value, MessagePack.MessagePackWriter& writer); // 0x06cc5e7c
	System.Void <.cctor>b__24_9(System.UInt16 value, MessagePack.MessagePackWriter& writer); // 0x06cc5f8c
	System.Void <.cctor>b__24_10(System.UInt32 value, MessagePack.MessagePackWriter& writer); // 0x06cc609c
	System.Void <.cctor>b__24_11(System.UInt64 value, MessagePack.MessagePackWriter& writer); // 0x06cc61ac
	System.Void <.cctor>b__24_12(System.Byte[] value, MessagePack.MessagePackWriter& writer); // 0x06cc62bc
	System.Void <.cctor>b__24_13(System.Buffers.ReadOnlySequence<System.Byte> value, MessagePack.MessagePackWriter& writer); // 0x06cc6344
	System.Void <.cctor>b__24_14(System.ArraySegment<System.Byte> value, MessagePack.MessagePackWriter& writer); // 0x06cc63ec
	System.Void <.cctor>b__24_15(System.Memory<System.Byte> value, MessagePack.MessagePackWriter& writer); // 0x06cc64b8
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.EntityRpcPacketWithExtraPayload : WizardGames.Soc.Common.Framework.Network.BasePacket, WizardGames.Soc.Common.Framework.Network.IOutgoingPacket, WizardGames.Soc.Common.Framework.Network.IMehtodIdPacket
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Common.Framework.Network.EntityRpcPacketWithExtraPayload> pool; // 0x8
	WizardGames.Soc.Common.Framework.Network.EntityRpcPacket packet; // 0x18
	System.Int32 get_MethodId(); // 0x06cc65b0
	static WizardGames.Soc.Common.Framework.Network.EntityRpcPacketWithExtraPayload Get(); // 0x06cc6658
	System.Void .ctor(); // 0x06cc6700
	WizardGames.Soc.Common.Framework.Network.EntityRpcPacketWithExtraPayload Init(WizardGames.Soc.Common.Framework.Network.EntityRpcPacket packet, System.ArraySegment<System.Byte>& extraPayload, System.Byte c1); // 0x06cc6768
	System.Void ReturnToPool(); // 0x06cc6994
	System.Buffers.ReadOnlySequence<System.Byte> GetBuffer(); // 0x06cc6a70
	WizardGames.Soc.Common.Framework.MemoryBuffer MoveBuffer(); // 0x06cc6af4
	static System.Void .cctor(); // 0x06cc6b60
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.BatchTransferPacket : System.Object
{
	static SocLogger logger; // 0x0
	static System.Int32 ReadPacketLength(System.Span<System.Byte>& buffer, System.Int32& offset); // 0x06cc6c94
	static System.Memory<System.Byte> GetOnePacket(System.Memory<System.Byte>& input, System.Int32 offset, System.Int32& newPosition, System.Byte& packetType); // 0x06cc6de0
	static System.Void .cctor(); // 0x06cc7370
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.ReceivedBatchTransferPacket : WizardGames.Soc.Common.Framework.Network.BasePacket
{
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Common.Framework.Network.ReceivedBatchTransferPacket> pool; // 0x0
	static SocLogger logger; // 0x8
	System.Memory<System.Byte> <RawReceived>k__BackingField; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.Common.Framework.Network.ReceivedEntityRpcPacket> PacketList; // 0x28
	System.Void set_RawReceived(System.Memory<System.Byte> value); // 0x06cc7444
	static WizardGames.Soc.Common.Framework.Network.ReceivedBatchTransferPacket GetFromPool(System.Memory<System.Byte>& batchData, System.Boolean withDownlinkTimestamp); // 0x06cc74d0
	System.Void PacketsMoved(); // 0x06cc7918
	System.Void ReturnToPool(); // 0x06cc79bc
	System.Void .ctor(); // 0x06cc7c48
	static System.Void .cctor(); // 0x06cc7cf8
}

// Client.Runtime
struct WizardGames.Soc.Common.Framework.Network.RpcLimitCall : System.ValueType
{
	System.Int32 MinIntervalMs; // 0x10
	System.Int32 DurationCount; // 0x14
	static WizardGames.Soc.Common.Framework.Network.RpcLimitCall Default; // 0x0
	static System.Void .cctor(); // 0x06cc7e38
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.RpcInfo : System.Object
{
	System.String Name; // 0x10
	System.Boolean ExposedToClient; // 0x18
	System.Boolean IgnoreOwner; // 0x19
	System.Void .ctor(); // 0x06cc7e88
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.RpcParamSerialize<T> : System.Object
{
	static WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<T> Func; // 0x0
	static System.Void Execute(T section, MessagePack.MessagePackWriter& writer); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.RpcParamSerialize.SerializeFunc<T> : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05525a60
	System.Void Invoke(T value, MessagePack.MessagePackWriter& writer); // 0x052af1f0
}

// Client.Runtime
struct WizardGames.Soc.Common.Framework.Network.Kcp.AckItem : System.ValueType
{
	System.UInt32 sn; // 0x10
	System.UInt32 ts; // 0x14
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Framework.Network.Kcp.EKcpInputCode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Framework.Network.Kcp.EKcpInputCode Success = 0;
	static WizardGames.Soc.Common.Framework.Network.Kcp.EKcpInputCode Invaild = -1;
	static WizardGames.Soc.Common.Framework.Network.Kcp.EKcpInputCode LengthError = -2;
	static WizardGames.Soc.Common.Framework.Network.Kcp.EKcpInputCode CmdError = -3;
	static WizardGames.Soc.Common.Framework.Network.Kcp.EKcpInputCode ChecksumError = -4;
	static WizardGames.Soc.Common.Framework.Network.Kcp.EKcpInputCode ChannelNotExpected = -5;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Kcp.Kcp : System.Object
{
	static SocLogger logger; // 0x0
	System.Int32 state; // 0x10
	System.UInt32 mtu; // 0x14
	System.UInt32 mss; // 0x18
	System.UInt32 sendUna; // 0x1c
	System.UInt32 sendNext; // 0x20
	System.UInt32 recvQueueNext; // 0x24
	System.UInt32 ssthresh; // 0x28
	System.Int32 rx_rttval; // 0x2c
	System.Int32 rx_srtt; // 0x30
	System.Int32 rx_rto; // 0x34
	System.Int32 rx_minrto; // 0x38
	System.UInt32 sendWnd; // 0x3c
	System.UInt32 recvWnd; // 0x40
	System.UInt32 rmtWnd; // 0x44
	System.UInt32 cwnd; // 0x48
	System.UInt32 probe; // 0x4c
	System.UInt32 interval; // 0x50
	System.UInt32 ts_flush; // 0x54
	System.UInt32 xmit; // 0x58
	System.UInt32 nodelay; // 0x5c
	System.Boolean updated; // 0x60
	System.UInt32 ts_probe; // 0x64
	System.UInt32 probe_wait; // 0x68
	System.UInt32 dead_link; // 0x6c
	System.UInt32 incr; // 0x70
	System.UInt32 current; // 0x74
	System.Int32 fastResend; // 0x78
	System.Int32 fastLimit; // 0x7c
	System.Boolean nocwnd; // 0x80
	System.Collections.Generic.Queue<WizardGames.Soc.Common.Framework.Network.Kcp.Segment> sendQueue; // 0x88
	System.Collections.Generic.Queue<WizardGames.Soc.Common.Framework.Network.Kcp.Segment> recvQueue; // 0x90
	System.Collections.Generic.List<WizardGames.Soc.Common.Framework.Network.Kcp.Segment> sendBuf; // 0x98
	System.Int32 sendBuffDataLength; // 0xa0
	System.Collections.Generic.List<WizardGames.Soc.Common.Framework.Network.Kcp.Segment> recvBuf; // 0xa8
	System.Collections.Generic.List<WizardGames.Soc.Common.Framework.Network.Kcp.AckItem> ackList; // 0xb0
	System.Byte[] buffer; // 0xb8
	System.Action<System.Byte[],System.Int32> output; // 0xc0
	System.UInt32 <SendCount>k__BackingField; // 0xc8
	System.UInt32 <RetransmitCount>k__BackingField; // 0xcc
	System.UInt32 <FastRetransmitCount>k__BackingField; // 0xd0
	WizardGames.Soc.Common.Framework.Network.Kcp.Fec.FecEncode fecEncoder; // 0xd8
	WizardGames.Soc.Common.Framework.Network.Kcp.Fec.FecDecode fecDecoder; // 0xe0
	System.UInt32 lastSendCount; // 0xe8
	System.UInt32 lastRetransmitCount; // 0xec
	System.UInt32 lastUpdateRetransmitRateTime; // 0xf0
	System.Single RetransmitRate; // 0xf4
	System.UInt32 get_SendCount(); // 0x06cc7ef0
	System.Void set_SendCount(System.UInt32 value); // 0x06cc7f54
	System.UInt32 get_RetransmitCount(); // 0x06cc7fcc
	System.Void set_RetransmitCount(System.UInt32 value); // 0x06cc8030
	System.UInt32 get_FastRetransmitCount(); // 0x06cc80a8
	System.Void set_FastRetransmitCount(System.UInt32 value); // 0x06cc810c
	System.Void .ctor(WizardGames.Soc.Common.Framework.Network.Kcp.KcpConfig config, System.Action<System.Byte[],System.Int32> output); // 0x06cc8184
	System.UInt16 WndUnused(); // 0x06cc85fc
	System.Int32 PeekSize(); // 0x06cc8690
	System.Int32 Receive(System.Byte[] buffer, System.Int32 len); // 0x06cc89dc
	System.Int32 Send(WizardGames.Soc.Common.Framework.Network.Kcp.EKcpHeader header, System.ArraySegment<System.Byte>& content); // 0x06cc8df4
	System.Void UpdateAck(System.Int32 rtt); // 0x06cc90e0
	System.Void ShrinkBuf(); // 0x06cc9230
	System.Void ParseAck(System.UInt32 sn); // 0x06cc92e8
	System.Void ParseUna(System.UInt32 una); // 0x06cc94f0
	System.Void ParseFastack(System.UInt32 sn, System.UInt32 ts); // 0x06cc97f0
	System.Void AckPush(System.UInt32 sn, System.UInt32 ts); // 0x06cc99a4
	System.Void InsertSegmentInReceiveBuffer(WizardGames.Soc.Common.Framework.Network.Kcp.Segment newSeg, System.Boolean checkFec); // 0x06cc9a9c
	System.Void MoveReceiveBufferReadySegmentsToQueue(); // 0x06cc9e50
	System.Void ParseData(WizardGames.Soc.Common.Framework.Network.Kcp.Segment newseg); // 0x06cca088
	WizardGames.Soc.Common.Framework.Network.Kcp.EKcpInputCode Input(System.Byte[] data, System.Int32 offset, System.Int32 size); // 0x06cca1ac
	System.Void MakeSpace(System.Int32& size, System.Int32 space); // 0x06cca7d8
	System.Void FlushBuffer(System.Int32 size); // 0x06cca890
	System.Void Flush(); // 0x06cca93c
	System.Void Update(System.UInt32 currentTimeMilliSeconds, System.Boolean forceFlush); // 0x06ccb5fc
	System.Void AddFecParityData(WizardGames.Soc.Common.Framework.Network.Kcp.Segment seg); // 0x06ccb9f8
	System.Void UpdateFecRedundancy(); // 0x06ccb744
	static System.Void .cctor(); // 0x06ccba94
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Kcp.KcpConfig : System.Object
{
	System.Int32 RecvBufferSize; // 0x10
	System.Int32 SendBufferSize; // 0x14
	System.Int32 Mtu; // 0x18
	System.Boolean NoDelay; // 0x1c
	System.UInt32 Interval; // 0x20
	System.Boolean CongestionWindow; // 0x24
	System.UInt32 SendWindowSize; // 0x28
	System.UInt32 ReceiveWindowSize; // 0x2c
	System.Int32 Timeout; // 0x30
	System.UInt32 MaxRetransmits; // 0x34
	System.Int32 FastResend; // 0x38
	System.Int32 NotConnectTimeout; // 0x3c
	System.Boolean EnableFec; // 0x40
	System.Boolean EnableAdaptiveFec; // 0x41
	static WizardGames.Soc.Common.Framework.Network.Kcp.KcpConfig ClientConfig; // 0x0
	static WizardGames.Soc.Common.Framework.Network.Kcp.KcpConfig ServerConfig; // 0x8
	System.Void .ctor(); // 0x06cccad8
	static System.Void .cctor(); // 0x06cccb84
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Kcp.CallbackToken : System.Object
{
	System.Action OnConnected; // 0x10
	System.Action<System.Memory<System.Byte>,WizardGames.Soc.Common.Framework.Network.Kcp.EKcpChannel> OnData; // 0x18
	System.Action<WizardGames.Soc.Common.Framework.Network.DisconnectReason> OnDisconnected; // 0x20
	System.Action<WizardGames.Soc.Common.Framework.Network.Kcp.EErrorCode,System.String> OnError; // 0x28
	WizardGames.Soc.Common.Framework.Network.Kcp.EKcpState State; // 0x30
	System.Void Reset(); // 0x06cccc44
	System.Void .ctor(); // 0x06cccd00
}

// Client.Runtime
enum WizardGames.Soc.Common.Framework.Network.Kcp.EKcpState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Framework.Network.Kcp.EKcpState NotConnect = 0;
	static WizardGames.Soc.Common.Framework.Network.Kcp.EKcpState Connected = 1;
	static WizardGames.Soc.Common.Framework.Network.Kcp.EKcpState Authed = 2;
	static WizardGames.Soc.Common.Framework.Network.Kcp.EKcpState Disconnected = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Framework.Network.Kcp.EKcpChannel : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Framework.Network.Kcp.EKcpChannel Reliable = 1;
	static WizardGames.Soc.Common.Framework.Network.Kcp.EKcpChannel Unreliable = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Framework.Network.Kcp.EErrorCode : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Framework.Network.Kcp.EErrorCode DnsResolve = 0;
	static WizardGames.Soc.Common.Framework.Network.Kcp.EErrorCode Timeout = 1;
	static WizardGames.Soc.Common.Framework.Network.Kcp.EErrorCode Congestion = 2;
	static WizardGames.Soc.Common.Framework.Network.Kcp.EErrorCode InvalidReceive = 3;
	static WizardGames.Soc.Common.Framework.Network.Kcp.EErrorCode InvalidSend = 4;
	static WizardGames.Soc.Common.Framework.Network.Kcp.EErrorCode ConnectionClosed = 5;
	static WizardGames.Soc.Common.Framework.Network.Kcp.EErrorCode Unexpected = 6;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Framework.Network.Kcp.EKcpHeader : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Framework.Network.Kcp.EKcpHeader Hello = 1;
	static WizardGames.Soc.Common.Framework.Network.Kcp.EKcpHeader Ping = 2;
	static WizardGames.Soc.Common.Framework.Network.Kcp.EKcpHeader Data = 3;
	static WizardGames.Soc.Common.Framework.Network.Kcp.EKcpHeader Disconnect = 4;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Kcp.KcpPeer : System.Object
{
	static SocLogger logger; // 0x0
	static System.Int32 <DownlinkBlockDataThreshold>k__BackingField; // 0x8
	static System.Int32 <DownlinkBlockDataTimeLimit>k__BackingField; // 0xc
	WizardGames.Soc.Common.Framework.Network.Kcp.Kcp kcp; // 0x10
	System.UInt32 cookie; // 0x18
	WizardGames.Soc.Common.Framework.Network.Kcp.EKcpState state; // 0x1c
	System.Int32 timeout; // 0x20
	System.UInt32 lastReceiveTime; // 0x24
	System.UInt32 lastSendTime; // 0x28
	System.Int32 reliableMax; // 0x2c
	System.Byte[] kcpMessageBuffer; // 0x30
	System.UInt32 lastPingTime; // 0x38
	System.Diagnostics.Stopwatch watch; // 0x40
	static System.ArraySegment<System.Byte> EMPTY_ARRAY; // 0x10
	System.Boolean get_EnableFec(); // 0x06cccd68
	WizardGames.Soc.Common.Framework.Network.Kcp.FecStat get_FecStat(); // 0x06cccde0
	System.UInt32 get_SendCount(); // 0x06ccce58
	System.UInt32 get_RetransmitCount(); // 0x06cccefc
	System.UInt32 get_FastRetransmitCount(); // 0x06cccfa0
	System.Single get_RetransmitRate(); // 0x06ccd044
	System.Int32 get_Rtt(); // 0x06ccd0b4
	static System.Int32 ReliableMaxMessageSizeUnlimit(System.Int32 mtu, System.UInt32 rcv_wnd); // 0x06ccd124
	static System.Int32 ReliableMaxMessageSize(System.Int32 mtu, System.UInt32 rcv_wnd); // 0x06ccd1a4
	System.Void Init(WizardGames.Soc.Common.Framework.Network.Kcp.KcpConfig config); // 0x06ccd280
	System.Void Reset(); // 0x06ccd394
	System.Void .ctor(WizardGames.Soc.Common.Framework.Network.Kcp.KcpConfig config, System.UInt32 cookie); // 0x06ccd414
	System.Void OnAuthed(System.ArraySegment<System.Byte> message); // 0x0551a40c
	System.Void OnData(System.ArraySegment<System.Byte> message, WizardGames.Soc.Common.Framework.Network.Kcp.EKcpChannel channel); // 0x0551a4bc
	System.Void OnDisconnected(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x055056e8
	System.Void OnError(WizardGames.Soc.Common.Framework.Network.Kcp.EErrorCode error, System.String message); // 0x05524154
	System.Void UdpSend(System.ArraySegment<System.Byte> data, System.Byte channel); // 0x0551a4bc
	System.Void SendHello(System.ArraySegment<System.Byte> data); // 0x06ccd5e8
	System.Void SendPing(); // 0x06ccd980
	System.Void SendDisconnect(); // 0x06ccda18
	System.Void SendData(System.ArraySegment<System.Byte>& data, WizardGames.Soc.Common.Framework.Network.Kcp.EKcpChannel channel); // 0x06ccdab0
	System.Void Disconnect(WizardGames.Soc.Common.Framework.Network.DisconnectReason code); // 0x06ccdc2c
	System.Void HandleTimeout(System.UInt32 time); // 0x06ccdf44
	System.Void HandleDeadLink(); // 0x06cce0a0
	System.Void HandlePing(System.UInt32 time); // 0x06cce1e8
	System.Void HandleChoked(System.UInt32 timeMs); // 0x06cce278
	System.Boolean ReceiveNextReliable(WizardGames.Soc.Common.Framework.Network.Kcp.EKcpHeader& header, System.ArraySegment<System.Byte>& message); // 0x06cce564
	System.Void TryPeekPackets(); // 0x06cce7ec
	System.Void OnTickProcessInConnected(System.UInt32 time); // 0x06ccebc4
	System.Void OnTickProcessAuthed(System.UInt32 time); // 0x06ccec54
	System.Void TickIncoming(); // 0x06ccecf0
	System.Void TickOutgoing(System.Boolean forceFlush); // 0x06cceecc
	WizardGames.Soc.Common.Framework.Network.Kcp.EKcpInputCode OnRawInputReliable(System.ArraySegment<System.Byte> message); // 0x06ccf0bc
	System.Void NetSendReliable(System.Byte[] data, System.Int32 length); // 0x06ccf1a0
	System.Void SendReliable(WizardGames.Soc.Common.Framework.Network.Kcp.EKcpHeader header, System.ArraySegment<System.Byte>& content); // 0x06ccd76c
	static System.Void .cctor(); // 0x06ccf364
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Kcp.FecStat : System.Object
{
	System.Int32 Recovered; // 0x10
	System.Int32 DecodeErrors; // 0x14
	System.Int32 DataShards; // 0x18
	System.Int32 ParityShards; // 0x1c
	System.Int32 ShardsSent; // 0x20
	System.Int32 ParitySent; // 0x24
	System.Int32 Redundancy; // 0x28
	System.String ToString(); // 0x06ccf518
	System.Void .ctor(); // 0x06ccf730
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Kcp.KcpUtils : System.Object
{
	static System.Random rd; // 0x0
	static System.Int32 Clamp(System.Int32 value, System.Int32 min, System.Int32 max); // 0x06ccf798
	static System.Int32 Encode8u(System.Byte[] p, System.Int32 offset, System.Byte value); // 0x06ccf824
	static System.Int32 Decode8u(System.Byte[] p, System.Int32 offset, System.Byte& value); // 0x06ccf8c4
	static System.Int32 Encode16U(System.Byte[] p, System.Int32 offset, System.UInt16 value); // 0x06ccf968
	static System.Int32 Decode16U(System.Byte[] p, System.Int32 offset, System.UInt16& value); // 0x06ccfa20
	static System.Int32 Encode32U(System.Byte[] p, System.Int32 offset, System.UInt32 value); // 0x06ccfad8
	static System.Int32 Decode32U(System.Byte[] p, System.Int32 offset, System.UInt32& value); // 0x06ccfbc0
	static System.Int32 Diff(System.UInt32 later, System.UInt32 earlier); // 0x06ccfca0
	static System.UInt32 GetEncryptSeed(); // 0x06ccfd18
	static System.Void .cctor(); // 0x06ccfdb0
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Kcp.Segment : System.Object, WizardGames.Soc.Common.Cache.IPooledObject
{
	System.Byte Cmd; // 0x10
	System.Byte Frg; // 0x11
	System.UInt16 Wnd; // 0x12
	System.UInt32 Ts; // 0x14
	System.UInt32 Sn; // 0x18
	System.UInt32 Una; // 0x1c
	System.Byte[] <Data>k__BackingField; // 0x20
	System.Int32 <DataLength>k__BackingField; // 0x28
	System.Int32 Rto; // 0x2c
	System.UInt32 Resendts; // 0x30
	System.UInt32 Fastack; // 0x34
	System.UInt32 Xmit; // 0x38
	System.Int32 FecPacketType; // 0x3c
	System.Int32 FecRedundancy; // 0x40
	System.Int32 FecFrg; // 0x44
	System.Int32 refCount; // 0x48
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Common.Framework.Network.Kcp.Segment> pool; // 0x0
	System.Boolean <IsReturn>k__BackingField; // 0x4c
	System.Byte[] get_Data(); // 0x06ccfe2c
	System.Int32 get_DataLength(); // 0x06ccfe90
	System.Void set_DataLength(System.Int32 value); // 0x06ccfef4
	System.Boolean get_IsReturn(); // 0x06ccff6c
	System.Void set_IsReturn(System.Boolean value); // 0x06ccffd0
	static WizardGames.Soc.Common.Framework.Network.Kcp.Segment GetFromPool(); // 0x06cd004c
	System.Void Retain(); // 0x06cd0158
	System.Void Release(); // 0x06cd01c4
	System.Void ReturnToPool(); // 0x06cd0244
	System.Int32 Encode(System.Byte[] ptr, System.Int32 offset); // 0x06cd03c0
	static System.ValueTuple<System.Byte,System.Byte,System.UInt16,System.UInt32,System.UInt32,System.UInt32,System.UInt16,System.ValueTuple<System.Int32>> Decode(System.Byte[] data, System.Int32& offset); // 0x06cd05e8
	System.Void CopyTo(System.Byte[] dst, System.Int32 offset); // 0x06cd07c8
	System.Void CopyFrom(System.Byte[] src, System.Int32 offset, System.Int32 length); // 0x06cd08f0
	System.Void CopyFrom(System.ArraySegment<System.Byte>& src, System.Int32 offset, System.Int32 length); // 0x06cd0ac8
	System.Void Write(System.Byte byteVal); // 0x06cd0cfc
	System.Int32 CopyFecDataTo(System.Byte[] dst, System.Int32 offset, System.Boolean isParity); // 0x06cd0ed4
	System.Boolean DecodeFecData(System.Byte[] data, System.Int32 offset); // 0x06cd10ec
	System.Void Reset(); // 0x06cd0300
	System.Void .ctor(); // 0x06cd1290
	static System.Void .cctor(); // 0x06cd1328
}

// Client.Runtime
interface WizardGames.Soc.Common.Framework.Network.Kcp.Fec.ICodingLoop : 
{
	
	System.Void CodeSomeShards(System.ArraySegment<System.Byte>[] matrixRows, System.ArraySegment<System.Byte>[] inputs, System.Int32 inputCount, System.ArraySegment<System.Byte>[] outputs, System.Int32 outputCount, System.Int32 offset, System.Int32 byteCount); // 0x0552c07c
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Kcp.Fec.CodingLoopBase : System.Object, WizardGames.Soc.Common.Framework.Network.Kcp.Fec.ICodingLoop
{
	
	System.Void CodeSomeShards(System.ArraySegment<System.Byte>[] matrixRows, System.ArraySegment<System.Byte>[] inputs, System.Int32 inputCount, System.ArraySegment<System.Byte>[] outputs, System.Int32 outputCount, System.Int32 offset, System.Int32 byteCount); // 0x0552c07c
	System.Void .ctor(); // 0x06cd13c8
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Kcp.Fec.FecAdaptiveController : System.Object
{
	System.Double gamma; // 0x10
	System.Double delta; // 0x18
	System.Double beta; // 0x20
	System.Double baseTargetR; // 0x28
	System.Double integral; // 0x30
	System.Double prevR; // 0x38
	System.Double prevAlpha; // 0x40
	System.Collections.Generic.Queue<System.Double> oscillationWindow; // 0x48
	System.Void .ctor(System.Double initGamma, System.Double initDelta); // 0x06cd1430
	System.Double Update(System.Double r, System.Double deltaTime, System.Int32 rtt); // 0x06cd1514
	static System.Double CalculateStandardDeviation(System.Collections.Generic.IEnumerable<System.Double> values); // 0x06cd179c
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Kcp.Fec.FecPacketNode : WizardGames.Soc.Common.Framework.Algorithm.LinkedNode<WizardGames.Soc.Common.Framework.Network.Kcp.Segment>, WizardGames.Soc.Common.Cache.IPooledObject
{
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Common.Framework.Network.Kcp.Fec.FecPacketNode> pool; // 0x0
	System.Boolean <IsReturn>k__BackingField; // 0x30
	System.Int64 Seq; // 0x38
	System.Boolean get_IsReturn(); // 0x06cd1ae8
	System.Void set_IsReturn(System.Boolean value); // 0x06cd1b4c
	System.Void .ctor(); // 0x06cd1bc8
	System.Void ReturnToPool(); // 0x06cd1c48
	static WizardGames.Soc.Common.Framework.Network.Kcp.Fec.FecPacketNode GetFromPool(WizardGames.Soc.Common.Framework.Network.Kcp.Segment seg); // 0x06cd1d1c
	static System.Void .cctor(); // 0x06cd1dfc
}

// Client.Runtime
struct WizardGames.Soc.Common.Framework.Network.Kcp.Fec.DecodeResult : System.ValueType
{
	System.UInt32 Sn; // 0x10
	System.Boolean IsDataShard; // 0x14
	System.ArraySegment<System.Byte> Data; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Kcp.Fec.FecDecode : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Framework.Network.Kcp.Fec.ReedSolomon[] codecs; // 0x10
	System.Int32 configRecvLimit; // 0x18
	WizardGames.Soc.Common.Framework.Algorithm.NoAllocLinkedList<WizardGames.Soc.Common.Framework.Network.Kcp.Segment> receivedPackets; // 0x20
	System.Int32 receivedPacketsCount; // 0x28
	System.Boolean[] tempFlagArray; // 0x30
	WizardGames.Soc.Common.Framework.Network.Kcp.Fec.FecPacketNode[] packetsReadyToDecode; // 0x38
	System.ArraySegment<System.Byte>[] decodeCache; // 0x40
	WizardGames.Soc.Common.Framework.Network.Kcp.Fec.DecodeResult[] decodeResultCache; // 0x48
	WizardGames.Soc.Common.Framework.Network.Kcp.FecStat stat; // 0x50
	System.Int64 expectedSeqStart; // 0x58
	System.Int32 currentDataCount; // 0x60
	System.Int32 currentParityCount; // 0x64
	System.Int64 expiredSeq; // 0x68
	System.Int32 get_totalShardCount(); // 0x06cd1e9c
	System.Void .ctor(System.Int32 recvLimit, WizardGames.Soc.Common.Framework.Network.Kcp.FecStat stat); // 0x06cd1f04
	System.Int32 Input(WizardGames.Soc.Common.Framework.Network.Kcp.Segment segment, WizardGames.Soc.Common.Framework.Network.Kcp.Fec.DecodeResult[]& results); // 0x06cd23c0
	System.Void DropOldestPackets(); // 0x06cd259c
	System.Int64 AdjustSequence(System.UInt32 sn); // 0x06cd28b4
	System.Int32 Insert(WizardGames.Soc.Common.Framework.Network.Kcp.Fec.FecPacketNode incomingNode, WizardGames.Soc.Common.Framework.Network.Kcp.Fec.FecPacketNode& groupBeginNode, WizardGames.Soc.Common.Framework.Network.Kcp.Fec.FecPacketNode& groupBeginEnd); // 0x06cd2964
	System.Int32 Decode(WizardGames.Soc.Common.Framework.Network.Kcp.Fec.FecPacketNode beginNode, WizardGames.Soc.Common.Framework.Network.Kcp.Fec.FecPacketNode endNode, System.Int32 packetsInGroup); // 0x06cd2dc4
	static System.Void .cctor(); // 0x06cd41a4
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Kcp.Fec.FecEncode : System.Object
{
	WizardGames.Soc.Common.Framework.Network.Kcp.Fec.ReedSolomon[] codecs; // 0x10
	System.ArraySegment<System.Byte>[] shardDataArray; // 0x18
	System.Int32[] shardDataUsedLength; // 0x20
	System.Int32 shardCount; // 0x28
	System.Int32 maxShardDataSize; // 0x2c
	System.Action<WizardGames.Soc.Common.Framework.Network.Kcp.Segment> outputParityFunc; // 0x30
	WizardGames.Soc.Common.Framework.Network.Kcp.FecStat Stat; // 0x38
	System.Int32 nextRedundancy; // 0x40
	System.Int32 currentRedundancy; // 0x44
	System.Boolean enableAdaptive; // 0x48
	WizardGames.Soc.Common.Framework.Network.Kcp.Fec.FecAdaptiveController controller; // 0x50
	System.Void set_Redundancy(System.Int32 value); // 0x06cd4278
	System.Void .ctor(System.Action<WizardGames.Soc.Common.Framework.Network.Kcp.Segment> output, System.Boolean adaptive); // 0x06cd43c0
	System.Void SendOutput(WizardGames.Soc.Common.Framework.Network.Kcp.Segment seg); // 0x06cd4790
	System.Void UpdateRedundancy(System.Double dropRate, System.Double deltaTime, System.Int32 rtt); // 0x06cd4f5c
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Kcp.Fec.FecConfig : System.Object
{
	static System.Collections.Generic.List<System.Tuple<System.Int32,System.Int32>> FecMapping; // 0x0
	static System.Void .cctor(); // 0x06cd51fc
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Kcp.Fec.FecUtils : System.Object
{
	
	static System.UInt16 EncodeFecHeader(System.Int32 packetType, System.Int32 redundancy, System.Int32 frg); // 0x06cd0560
	static System.Void DecodeFecHeader(System.UInt16 header, System.Int32& packetType, System.Int32& redundancy, System.Int32& frg); // 0x06cd5710
	static System.Int32 CalculateRedundancy(System.Double alpha); // 0x06cd5030
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Kcp.Fec.Galois : System.Object
{
	static System.Int16[] LOG_TABLE; // 0x0
	static System.SByte[] EXP_TABLE; // 0x8
	static System.Byte[] EXP_TABLE_BYTE; // 0x10
	static System.Byte[][] MULTIPLICATION_TABLE; // 0x18
	static System.Byte multiply(System.Byte a, System.Byte b); // 0x06cd57b8
	static System.Byte divide(System.Byte a, System.Byte b); // 0x06cd58c4
	static System.Byte exp(System.Byte a, System.Int32 n); // 0x06cd5a38
	static System.Byte[] generateExpTable(); // 0x06cd5b74
	static System.Byte[][] generateMultiplicationTable(); // 0x06cd5cb8
	static System.Void .cctor(); // 0x06cd5e24
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Kcp.Fec.InputOutputByteTableCodingLoop : WizardGames.Soc.Common.Framework.Network.Kcp.Fec.CodingLoopBase
{
	
	System.Void CodeSomeShards(System.ArraySegment<System.Byte>[] matrixRows, System.ArraySegment<System.Byte>[] inputs, System.Int32 inputCount, System.ArraySegment<System.Byte>[] outputs, System.Int32 outputCount, System.Int32 offset, System.Int32 byteCount); // 0x06cd5f5c
	System.Void .ctor(); // 0x06cd6658
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Kcp.Fec.Matrix : System.Object, WizardGames.Soc.Common.Cache.IPooledObject
{
	static System.Collections.Concurrent.ConcurrentDictionary<System.Int64,WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Common.Framework.Network.Kcp.Fec.Matrix>> matrixPools; // 0x0
	System.Boolean <IsReturn>k__BackingField; // 0x10
	System.Int32 rows; // 0x14
	System.Int32 columns; // 0x18
	System.Byte[][] data; // 0x20
	System.Boolean get_IsReturn(); // 0x06cd66bc
	System.Void set_IsReturn(System.Boolean value); // 0x06cd6720
	System.Void .ctor(); // 0x06cd679c
	static WizardGames.Soc.Common.Framework.Network.Kcp.Fec.Matrix GetFromPool(System.Int32 rows, System.Int32 columns); // 0x06cd6804
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Common.Framework.Network.Kcp.Fec.Matrix> CreateMatrixPool(System.Int64 key); // 0x06cd6ae8
	System.Void Init(System.Int32 initRows, System.Int32 initColumns); // 0x06cd6958
	static WizardGames.Soc.Common.Framework.Network.Kcp.Fec.Matrix Identity(System.Int32 size); // 0x06cd6c14
	System.Int32 getColumns(); // 0x06cd6e54
	System.Int32 getRows(); // 0x06cd6eb8
	System.Byte get(System.Int32 r, System.Int32 c); // 0x06cd6f1c
	System.Void set(System.Int32 r, System.Int32 c, System.Byte value); // 0x06cd6ce0
	System.Void CopyFrom(System.Int32 row, System.Int32 count, System.Byte[] src); // 0x06cd7088
	WizardGames.Soc.Common.Framework.Network.Kcp.Fec.Matrix Times(WizardGames.Soc.Common.Framework.Network.Kcp.Fec.Matrix right); // 0x06cd7148
	WizardGames.Soc.Common.Framework.Network.Kcp.Fec.Matrix Augment(WizardGames.Soc.Common.Framework.Network.Kcp.Fec.Matrix right); // 0x06cd75f0
	WizardGames.Soc.Common.Framework.Network.Kcp.Fec.Matrix Submatrix(System.Int32 rmin, System.Int32 cmin, System.Int32 rmax, System.Int32 cmax); // 0x06cd7840
	System.Byte[] getRow(System.Int32 row); // 0x06cd79d0
	System.Void swapRows(System.Int32 r1, System.Int32 r2); // 0x06cd7abc
	WizardGames.Soc.Common.Framework.Network.Kcp.Fec.Matrix Invert(); // 0x06cd7bfc
	System.Void gaussianElimination(); // 0x06cd7e2c
	System.Void ReturnToPool(); // 0x06cd7d30
	static System.Void .cctor(); // 0x06cd82b0
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Kcp.Fec.ReedSolomon : System.Object
{
	System.Int32 <DataShardCount>k__BackingField; // 0x10
	System.Int32 <ParityShardCount>k__BackingField; // 0x14
	System.Int32 <TotalShardCount>k__BackingField; // 0x18
	WizardGames.Soc.Common.Framework.Network.Kcp.Fec.Matrix matrix; // 0x20
	WizardGames.Soc.Common.Framework.Network.Kcp.Fec.ICodingLoop codingLoop; // 0x28
	System.ArraySegment<System.Byte>[] parityRows; // 0x30
	[ThreadStatic] static System.ArraySegment<System.Byte>[] encodeOutputsTemp;
	[ThreadStatic] static System.ArraySegment<System.Byte>[] matrixRowsTemp;
	[ThreadStatic] static System.ArraySegment<System.Byte>[] decodeOutputsTemp;
	System.Int32 get_DataShardCount(); // 0x06cd8348
	System.Void set_DataShardCount(System.Int32 value); // 0x06cd83ac
	System.Int32 get_ParityShardCount(); // 0x06cd8424
	System.Void set_ParityShardCount(System.Int32 value); // 0x06cd8488
	System.Int32 get_TotalShardCount(); // 0x06cd8500
	System.Void set_TotalShardCount(System.Int32 value); // 0x06cd8564
	static WizardGames.Soc.Common.Framework.Network.Kcp.Fec.ReedSolomon Create(System.Int32 dataShardCount, System.Int32 parityShardCount); // 0x06cd22f4
	System.Void .ctor(System.Int32 dataShardCount, System.Int32 parityShardCount, WizardGames.Soc.Common.Framework.Network.Kcp.Fec.ICodingLoop codingLoop); // 0x06cd85dc
	System.Void EncodeParity(System.ArraySegment<System.Byte>[] shards, System.Int32 offset, System.Int32 byteCount); // 0x06cd4bcc
	System.Void DecodeMissing(System.ArraySegment<System.Byte>[] shards, System.Boolean[] shardPresent, System.Int32 offset, System.Int32 byteCount); // 0x06cd3584
	static WizardGames.Soc.Common.Framework.Network.Kcp.Fec.Matrix BuildMatrix(System.Int32 dataShards, System.Int32 totalShards); // 0x06cd8924
	static WizardGames.Soc.Common.Framework.Network.Kcp.Fec.Matrix Vandermonde(System.Int32 rows, System.Int32 cols); // 0x06cd8a04
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Impl.UserArgs : System.Object, WizardGames.Soc.Common.Cache.IPooledObject
{
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Common.Framework.Network.Impl.UserArgs> pool; // 0x0
	System.Boolean <IsReturn>k__BackingField; // 0x10
	System.Int32 <ClientId>k__BackingField; // 0x14
	WizardGames.Soc.Common.Framework.MemoryBuffer <Buffer>k__BackingField; // 0x18
	System.Boolean <IsReadArgs>k__BackingField; // 0x20
	static WizardGames.Soc.Common.Framework.Network.Impl.UserArgs GetFromPool(); // 0x06cd8b38
	System.Boolean get_IsReturn(); // 0x06cd8be0
	System.Void set_IsReturn(System.Boolean value); // 0x06cd8c44
	System.Int32 get_ClientId(); // 0x06cd8cc0
	WizardGames.Soc.Common.Framework.MemoryBuffer get_Buffer(); // 0x06cd8d24
	System.Void set_Buffer(WizardGames.Soc.Common.Framework.MemoryBuffer value); // 0x06cd8d88
	System.Void set_IsReadArgs(System.Boolean value); // 0x06cd8e08
	System.Void ReturnToPool(); // 0x06cd8e84
	System.Void .ctor(); // 0x06cd8fe8
	static System.Void .cctor(); // 0x06cd9050
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Impl.UdpBuffer : System.Object, WizardGames.Soc.Common.Cache.IPooledObject
{
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Common.Framework.Network.Impl.UdpBuffer> pool; // 0x0
	System.Buffers.IMemoryOwner<System.Byte> memoryOwner; // 0x10
	System.ArraySegment<System.Byte> MemoryAsArray; // 0x18
	System.Int32 UsedSize; // 0x28
	System.Boolean <IsReturn>k__BackingField; // 0x2c
	System.Boolean get_IsReturn(); // 0x06cd90f0
	System.Void set_IsReturn(System.Boolean value); // 0x06cd9154
	static WizardGames.Soc.Common.Framework.Network.Impl.UdpBuffer GetFromPool(); // 0x06cd91d0
	System.Void ReturnToPool(); // 0x06cd9494
	System.Void .ctor(); // 0x06cd954c
	static System.Void .cctor(); // 0x06cd95b4
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Impl.ArrayAppender : System.Object
{
	static SocLogger logger; // 0x0
	static System.Buffers.MemoryPool<System.Byte> pool; // 0x8
	WizardGames.Soc.Common.Framework.MemoryBuffer <Buffer>k__BackingField; // 0x10
	System.Int32 length; // 0x18
	static System.Buffers.IMemoryOwner<System.Byte> RentMemory(System.Int32 size); // 0x06cd93f0
	WizardGames.Soc.Common.Framework.MemoryBuffer get_Buffer(); // 0x06cd9654
	System.Void set_Buffer(WizardGames.Soc.Common.Framework.MemoryBuffer value); // 0x06cd96b8
	System.Void .ctor(); // 0x06cd9738
	System.Byte GetByte(System.Int32 position); // 0x06cd9800
	System.Memory<System.Byte> Slice(System.Int32 start, System.Int32 length); // 0x06cd9960
	System.Void Clear(); // 0x06cd9a94
	System.Void Concat(System.Memory<System.Byte> mem); // 0x06cd9ba8
	System.Int32 get_Length(); // 0x06cd9f48
	System.Void Advance(System.Int32 count); // 0x06cd9fac
	static System.Void .cctor(); // 0x06cda190
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Impl.UdpNetCommon : System.Object
{
	
	static System.Void SetBuffer(System.Net.Sockets.SocketAsyncEventArgs e); // 0x06cda324
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Impl.SocketAsyncEventArgsPool : System.Object
{
	System.Int32 poolSize; // 0x10
	System.Collections.Generic.Stack<System.Net.Sockets.SocketAsyncEventArgs> pool; // 0x18
	System.Func<System.Net.Sockets.SocketAsyncEventArgs> createFunc; // 0x20
	System.Void .ctor(System.Int32 poolSize, System.Func<System.Net.Sockets.SocketAsyncEventArgs> createFunc); // 0x06cda424
	System.Net.Sockets.SocketAsyncEventArgs Get(); // 0x06cda560
	System.Void Return(System.Net.Sockets.SocketAsyncEventArgs evt); // 0x06cda704
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Impl.TcpNetBase : System.Object
{
	static SocLogger logger; // 0x0
	System.Int32 WriteCompletedCount; // 0x10
	System.Buffers.MemoryPool<System.Byte> memoryPool; // 0x18
	System.Boolean isRunning; // 0x20
	WizardGames.Soc.Common.Framework.Network.Impl.SocketAsyncEventArgsPool writePool; // 0x28
	System.Action<System.Int32> SendCounterCallback; // 0x30
	System.Action<System.Int32,System.Int32> SendCompletedCounterCallback; // 0x38
	System.Void ReturnWriteEventToPool(System.Net.Sockets.SocketAsyncEventArgs e); // 0x06cda868
	System.Net.Sockets.SocketAsyncEventArgs CreateNewWriteEvent(); // 0x054e7844
	System.Void ReadCompleted(System.Object sender, System.Net.Sockets.SocketAsyncEventArgs e); // 0x06cda9b0
	System.Void WriteCompleted(System.Object sender, System.Net.Sockets.SocketAsyncEventArgs e); // 0x06cdb198
	static System.Void SetSendingEventBuffer(System.Net.Sockets.SocketAsyncEventArgs e, WizardGames.Soc.Common.Framework.Network.EPacketType packetType, WizardGames.Soc.Common.Framework.MemoryBuffer payload); // 0x06cdb554
	static System.Void SetSendingEventBufferHead(WizardGames.Soc.Common.Framework.Network.EPacketType packetType, WizardGames.Soc.Common.Framework.MemoryBuffer payload); // 0x06cdb65c
	static System.Memory<System.Byte> GetFullPacket(WizardGames.Soc.Common.Framework.Network.Impl.ArrayAppender writer, System.Int32 logClientId); // 0x06cdb828
	static System.Void Advance(WizardGames.Soc.Common.Framework.Network.Impl.ArrayAppender writer, System.Memory<System.Byte> p); // 0x06cdba54
	System.Void OnDataReceive(System.Net.Sockets.SocketAsyncEventArgs e); // 0x05523a54
	System.Void CloseClientSocket(System.Net.Sockets.SocketAsyncEventArgs e, System.Net.Sockets.SocketError err); // 0x05525b70
	System.Net.Sockets.Socket GetSocket(System.Net.Sockets.SocketAsyncEventArgs e); // 0x054f9d14
	System.Void ProcessReceive(System.Net.Sockets.SocketAsyncEventArgs e); // 0x06cdaafc
	System.Void ProcessSend(System.Net.Sockets.SocketAsyncEventArgs e); // 0x06cdb2e4
	System.Void .ctor(); // 0x06cdbb14
	static System.Void .cctor(); // 0x06cdbc30
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Impl.NetUtil : System.Object
{
	static SocLogger logger; // 0x0
	static System.Boolean ResolveHostname(System.String hostname, System.Net.IPAddress[]& addresses); // 0x06cdbd04
	static System.Void ConfigureSocketBuffers(System.Net.Sockets.Socket socket, System.Int32 recvBufferSize, System.Int32 sendBufferSize); // 0x06cdbebc
	static System.Void .cctor(); // 0x06cdc354
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Impl.ConnectToken : System.Object
{
	System.Boolean <IsConnecting>k__BackingField; // 0x10
	System.Boolean get_IsConnecting(); // 0x06cdc428
	System.Void set_IsConnecting(System.Boolean value); // 0x06cdc48c
	System.Void .ctor(); // 0x06cdc508
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Impl.TcpNetClient : WizardGames.Soc.Common.Framework.Network.Impl.TcpNetBase
{
	static SocLogger logger; // 0x0
	System.Net.Sockets.Socket sock; // 0x40
	System.String targetIp; // 0x48
	System.Int32 targetPort; // 0x50
	WizardGames.Soc.Common.Framework.Network.Impl.ConnectToken connectToken; // 0x58
	System.Int32 DisconnectTimeout; // 0x60
	System.Int32 ReciveTimeout; // 0x64
	System.Boolean connected; // 0x68
	System.Net.Sockets.SocketAsyncEventArgs readEvent; // 0x70
	System.Action OnConnected; // 0x78
	System.Action OnConnectFailed; // 0x80
	System.Action<System.Memory<System.Byte>> OnDataReceived; // 0x88
	System.Action<System.Net.Sockets.SocketError> OnDisconnected; // 0x90
	WizardGames.Soc.Common.Framework.Network.Impl.ArrayAppender appender; // 0x98
	System.Int32 <SendBufferSize>k__BackingField; // 0xa0
	System.Int32 <ReceiveBufferSize>k__BackingField; // 0xa4
	System.Boolean get_Connected(); // 0x06cdc570
	System.Void set_Connected(System.Boolean value); // 0x06cdc5dc
	System.Int32 get_SendBufferSize(); // 0x06cdc65c
	System.Void set_SendBufferSize(System.Int32 value); // 0x06cdc6c0
	System.Int32 get_ReceiveBufferSize(); // 0x06cdc738
	System.Void set_ReceiveBufferSize(System.Int32 value); // 0x06cdc79c
	System.Void .ctor(System.String targetIp, System.Int32 targetPort, System.Int32 receiveBufferSize, System.Int32 writePoolSize, System.Action<System.Int32> sendCounterCallback, System.Action<System.Int32,System.Int32> sendCompletedCounterCallback); // 0x06cdc814
	System.Net.Sockets.SocketAsyncEventArgs CreateNewWriteEvent(); // 0x06cdcae8
	System.Net.Sockets.SocketAsyncEventArgs GetWriteEventFromPool(WizardGames.Soc.Common.Framework.MemoryBuffer buffer); // 0x06cdcbdc
	System.Void Connect(); // 0x06cdcd54
	System.Void OnConnectSuccess(); // 0x06cdd920
	static System.Void OnConnectCompleted(System.Object sender, System.Net.Sockets.SocketAsyncEventArgs e); // 0x06cdd56c
	System.Void SendBytes(WizardGames.Soc.Common.Framework.Network.EPacketType type, WizardGames.Soc.Common.Framework.MemoryBuffer buffer); // 0x06cdda50
	System.Void Disconnect(); // 0x06cdde04
	System.Void Cleanup(); // 0x06cdd9b0
	System.Net.Sockets.Socket GetSocket(System.Net.Sockets.SocketAsyncEventArgs e); // 0x06cdde78
	System.Void CloseClientSocket(System.Net.Sockets.SocketAsyncEventArgs e, System.Net.Sockets.SocketError err); // 0x06cddef0
	System.Void OnDataReceive(System.Net.Sockets.SocketAsyncEventArgs e); // 0x06cde020
	System.Void OnDataReceive(System.Memory<System.Byte> readBuffer); // 0x06cde13c
	static System.Void .cctor(); // 0x06cde4d8
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Impl.TcpNetClient.<>c__DisplayClass29_0 : System.Object
{
	WizardGames.Soc.Common.Framework.Network.Impl.TcpNetClient <>4__this; // 0x10
	WizardGames.Soc.Common.Framework.Network.Impl.ConnectToken localToken; // 0x18
	System.Void .ctor(); // 0x06cdd504
	System.Void <Connect>b__0(); // 0x06cde5ac
}

// Client.Runtime
struct WizardGames.Soc.Common.Framework.Network.Impl.TcpNetClient.<>c__DisplayClass29_0.<<Connect>b__0>d : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.Common.Framework.Network.Impl.TcpNetClient.<>c__DisplayClass29_0 <>4__this; // 0x38
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x40
	System.Void MoveNext(); // 0x06cde68c
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x06cdeb98
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Impl.UdpNetClient : System.Object
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Framework.Network.Impl.SocketAsyncEventArgsPool sendPool; // 0x8
	System.Net.Sockets.Socket sock; // 0x10
	System.Net.IPEndPoint remote; // 0x18
	System.Boolean isRunning; // 0x20
	System.Action<System.ArraySegment<System.Byte>,WizardGames.Soc.Common.Framework.Network.Impl.UdpBuffer> onRawDataReceived; // 0x28
	System.Action<WizardGames.Soc.Common.Framework.Network.DisconnectReason> onDisconnect; // 0x30
	System.Void .ctor(System.Net.IPEndPoint ipEndPoint, System.Action<System.ArraySegment<System.Byte>,WizardGames.Soc.Common.Framework.Network.Impl.UdpBuffer> action, System.Action<WizardGames.Soc.Common.Framework.Network.DisconnectReason> diconnectAction); // 0x06cdec18
	System.Void Start(); // 0x06cdeffc
	System.Net.Sockets.SocketAsyncEventArgs ProcessReceive(System.Net.Sockets.SocketAsyncEventArgs e); // 0x06cdf234
	System.Void OnDataReceive(System.Net.Sockets.SocketAsyncEventArgs e); // 0x06cdf5dc
	System.Void ReadCompleted(System.Object sender, System.Net.Sockets.SocketAsyncEventArgs e); // 0x06cdf754
	System.Void SendRawData(System.ArraySegment<System.Byte> dataSection1, System.ArraySegment<System.Byte> dataSection2); // 0x06cdf89c
	System.Void WriteCompleted(System.Object _, System.Net.Sockets.SocketAsyncEventArgs e); // 0x06ce01a8
	System.Void OnDataSentCallback(System.Net.Sockets.SocketAsyncEventArgs e); // 0x06cdfec0
	System.Void Disconnect(); // 0x06ce02f4
	static System.Void .cctor(); // 0x06ce0374
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Impl.UdpNetClient.<>c : System.Object
{
	static WizardGames.Soc.Common.Framework.Network.Impl.UdpNetClient.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x06ce050c
	System.Void .ctor(); // 0x06ce0570
	System.Net.Sockets.SocketAsyncEventArgs <.cctor>b__26_0(); // 0x06ce05d8
}

// Client.Runtime
interface WizardGames.Soc.Common.Framework.Network.Client.INetworkEndpoint : 
{
	
	System.Boolean get_IsWorking(); // 0x054c4760
	System.Void SendPacket(WizardGames.Soc.Common.Framework.Network.IOutgoingPacket packet); // 0x05523a54
	System.Void Disconnect(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x055056e8
}

// Client.Runtime
interface WizardGames.Soc.Common.Framework.Network.Client.INetworkEndpointForClient : , WizardGames.Soc.Common.Framework.Network.Client.INetworkEndpoint
{
	
	System.Void Connect(); // 0x055049cc
	System.Action get_OnConnected(); // 0x054e7844
	System.Void set_OnConnected(System.Action value); // 0x05523a54
	System.Action get_OnConnectFailed(); // 0x054e7844
	System.Void set_OnConnectFailed(System.Action value); // 0x05523a54
	System.Action<WizardGames.Soc.Common.Framework.Network.DisconnectReason> get_OnDisconnect(); // 0x054e7844
	System.Void set_OnDisconnect(System.Action<WizardGames.Soc.Common.Framework.Network.DisconnectReason> value); // 0x05523a54
	System.Collections.Concurrent.ConcurrentQueue<WizardGames.Soc.Common.Framework.Network.BasePacket> get_DecodedPackets(); // 0x054e7844
}

// Client.Runtime
enum WizardGames.Soc.Common.Framework.Network.Client.EFrameworkKickReason : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Framework.Network.Client.EFrameworkKickReason None = 0;
	static WizardGames.Soc.Common.Framework.Network.Client.EFrameworkKickReason ServerNotReady = 1;
	static WizardGames.Soc.Common.Framework.Network.Client.EFrameworkKickReason NetworkVersionMismatch = 2;
	static WizardGames.Soc.Common.Framework.Network.Client.EFrameworkKickReason ServerClear = 3;
	static WizardGames.Soc.Common.Framework.Network.Client.EFrameworkKickReason PacketLimit = 4;
	static WizardGames.Soc.Common.Framework.Network.Client.EFrameworkKickReason LobbyKick = 5;
	static WizardGames.Soc.Common.Framework.Network.Client.EFrameworkKickReason GameLogic = 6;
	static WizardGames.Soc.Common.Framework.Network.Client.EFrameworkKickReason RelayLogin = 7;
	static WizardGames.Soc.Common.Framework.Network.Client.EFrameworkKickReason PacketError = 8;
	static WizardGames.Soc.Common.Framework.Network.Client.EFrameworkKickReason Logout = 9;
	static WizardGames.Soc.Common.Framework.Network.Client.EFrameworkKickReason VersionMismatch = 10;
	static WizardGames.Soc.Common.Framework.Network.Client.EFrameworkKickReason TagNotMatch = 11;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Framework.Network.Client.SocNetClient : System.Object, WizardGames.Soc.Common.Framework.Network.Client.INetworkEndpoint
{
	static SocLogger logger; // 0x0
	System.Func<System.Memory<System.Byte>,WizardGames.Soc.Common.Framework.Network.BasePacket> decodeFunc; // 0x10
	System.Collections.Concurrent.ConcurrentQueue<WizardGames.Soc.Common.Framework.Network.BasePacket> <DecodedPackets>k__BackingField; // 0x18
	System.Action <OnConnected>k__BackingField; // 0x20
	System.Action <OnConnectFailed>k__BackingField; // 0x28
	System.Action<WizardGames.Soc.Common.Framework.Network.DisconnectReason> <OnDisconnect>k__BackingField; // 0x30
	System.Boolean <IsWorking>k__BackingField; // 0x38
	System.Boolean disableCallback; // 0x39
	System.Boolean isHelloDone; // 0x3a
	System.Action<WizardGames.Soc.Common.Framework.Network.ReceivedEntityRpcPacket> updateClientTimeCallback; // 0x40
	System.Collections.Concurrent.ConcurrentQueue<WizardGames.Soc.Common.Framework.Network.BasePacket> get_DecodedPackets(); // 0x06ce0664
	System.Action get_OnConnected(); // 0x06ce06c8
	System.Void set_OnConnected(System.Action value); // 0x06ce072c
	System.Action get_OnConnectFailed(); // 0x06ce07ac
	System.Void set_OnConnectFailed(System.Action value); // 0x06ce0810
	System.Action<WizardGames.Soc.Common.Framework.Network.DisconnectReason> get_OnDisconnect(); // 0x06ce0890
	System.Void set_OnDisconnect(System.Action<WizardGames.Soc.Common.Framework.Network.DisconnectReason> value); // 0x06ce08f4
	System.Boolean get_IsWorking(); // 0x06ce0974
	System.Void set_IsWorking(System.Boolean value); // 0x06ce09d8
	System.Void .ctor(System.Func<System.Memory<System.Byte>,WizardGames.Soc.Common.Framework.Network.BasePacket> decodeFunc); // 0x06ce0a54
	System.Void Connect(); // 0x055049cc
	System.Void DoDisconnect(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x055056e8
	System.Void SendPacket(WizardGames.Soc.Common.Framework.Network.IOutgoingPacket packet); // 0x05523a54
	System.Void Disconnect(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x06ce0b2c
	System.Void BaseOnConnectToWorldFailed(); // 0x06ce0d14
	System.Void BaseOnConnectToWorld(); // 0x06ce0e7c
	System.Void BaseOnDisconnected(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x06ce1034
	System.Void BaseOnDisconnected(System.Net.Sockets.SocketError err); // 0x06ce11fc
	System.Void TryEnqueuePacket(WizardGames.Soc.Common.Framework.Network.BasePacket packet); // 0x06ce14c8
	static System.Void .cctor(); // 0x06ce1758
}

// Client.Runtime
enum WizardGames.Soc.Common.State.Monster.AdditiveLayerStateEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.State.Monster.AdditiveLayerStateEnum AdditiveLayerOff = 0;
	static WizardGames.Soc.Common.State.Monster.AdditiveLayerStateEnum HitOn = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.State.Monster.FullBodyLayerStateEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.State.Monster.FullBodyLayerStateEnum NonFullBody = 0;
	static WizardGames.Soc.Common.State.Monster.FullBodyLayerStateEnum Roll = 1;
	static WizardGames.Soc.Common.State.Monster.FullBodyLayerStateEnum Stagger = 2;
	static WizardGames.Soc.Common.State.Monster.FullBodyLayerStateEnum KnockOff = 3;
	static WizardGames.Soc.Common.State.Monster.FullBodyLayerStateEnum Collapse = 4;
	static WizardGames.Soc.Common.State.Monster.FullBodyLayerStateEnum Arise = 5;
	static WizardGames.Soc.Common.State.Monster.FullBodyLayerStateEnum Death = 6;
	static WizardGames.Soc.Common.State.Monster.FullBodyLayerStateEnum Show = 7;
	static WizardGames.Soc.Common.State.Monster.FullBodyLayerStateEnum Sprint = 8;
	static WizardGames.Soc.Common.State.Monster.FullBodyLayerStateEnum StandTurn = 9;
	static WizardGames.Soc.Common.State.Monster.FullBodyLayerStateEnum Eat = 10;
	static WizardGames.Soc.Common.State.Monster.FullBodyLayerStateEnum Sleep = 11;
	static WizardGames.Soc.Common.State.Monster.FullBodyLayerStateEnum Wakeup = 12;
	static WizardGames.Soc.Common.State.Monster.FullBodyLayerStateEnum Recourse = 13;
	static WizardGames.Soc.Common.State.Monster.FullBodyLayerStateEnum Attack = 14;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.State.Monster.LowerLayerStateEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.State.Monster.LowerLayerStateEnum Idle = 0;
	static WizardGames.Soc.Common.State.Monster.LowerLayerStateEnum Locomotion = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.State.Monster.UpperLayerStateEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.State.Monster.UpperLayerStateEnum Idle = 0;
	static WizardGames.Soc.Common.State.Monster.UpperLayerStateEnum SwitchProp = 1;
	static WizardGames.Soc.Common.State.Monster.UpperLayerStateEnum Reload = 2;
	static WizardGames.Soc.Common.State.Monster.UpperLayerStateEnum Throw = 3;
	static WizardGames.Soc.Common.State.Monster.UpperLayerStateEnum UseProp = 4;
	static WizardGames.Soc.Common.State.Monster.UpperLayerStateEnum Attack = 5;
	static WizardGames.Soc.Common.State.Monster.UpperLayerStateEnum Run = 6;
	static WizardGames.Soc.Common.State.Monster.UpperLayerStateEnum GunShoot = 7;
	static WizardGames.Soc.Common.State.Monster.UpperLayerStateEnum BowShoot = 8;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.State.Monster.EMonsterLifeState : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.State.Monster.EMonsterLifeState Alive = 0;
	static WizardGames.Soc.Common.State.Monster.EMonsterLifeState Death = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.State.Monster.EMonsterPoseState : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.State.Monster.EMonsterPoseState Stand = 0;
	static WizardGames.Soc.Common.State.Monster.EMonsterPoseState Crouch = 1;
	static WizardGames.Soc.Common.State.Monster.EMonsterPoseState Sit = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.State.Monster.EMonsterSkillPlayStage : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.State.Monster.EMonsterSkillPlayStage Invalid = 0;
	static WizardGames.Soc.Common.State.Monster.EMonsterSkillPlayStage SkillPreSwingTime = 0;
	static WizardGames.Soc.Common.State.Monster.EMonsterSkillPlayStage SkillCastTime = 2;
	static WizardGames.Soc.Common.State.Monster.EMonsterSkillPlayStage SkillRecoveryTime = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.State.Monster.EMonsterGrenadeThrowType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.State.Monster.EMonsterGrenadeThrowType None = 0;
	static WizardGames.Soc.Common.State.Monster.EMonsterGrenadeThrowType NearThrowing = 1;
	static WizardGames.Soc.Common.State.Monster.EMonsterGrenadeThrowType FarThrowing = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.State.Monster.EMonsterAiState : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.State.Monster.EMonsterAiState Idle = 0;
	static WizardGames.Soc.Common.State.Monster.EMonsterAiState Battle = 1;
	static WizardGames.Soc.Common.State.Monster.EMonsterAiState General = 2;
	static WizardGames.Soc.Common.State.Monster.EMonsterAiState Death = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.State.Monster.EMonsterAttackState : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.State.Monster.EMonsterAttackState Default = 0;
	static WizardGames.Soc.Common.State.Monster.EMonsterAttackState Preparing = 1;
	static WizardGames.Soc.Common.State.Monster.EMonsterAttackState Aming = 2;
	static WizardGames.Soc.Common.State.Monster.EMonsterAttackState Atk = 3;
	static WizardGames.Soc.Common.State.Monster.EMonsterAttackState AtkInterval = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.State.Monster.EMonsterActionState : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.State.Monster.EMonsterActionState Hold = 0;
	static WizardGames.Soc.Common.State.Monster.EMonsterActionState SwitchWeapon = 1;
	static WizardGames.Soc.Common.State.Monster.EMonsterActionState Fire = 2;
	static WizardGames.Soc.Common.State.Monster.EMonsterActionState Reload = 3;
	static WizardGames.Soc.Common.State.Monster.EMonsterActionState Show = 4;
	static WizardGames.Soc.Common.State.Monster.EMonsterActionState Attack = 5;
	static WizardGames.Soc.Common.State.Monster.EMonsterActionState Eat = 6;
	static WizardGames.Soc.Common.State.Monster.EMonsterActionState Recourse = 7;
	static WizardGames.Soc.Common.State.Monster.EMonsterActionState FarThrow = 8;
	static WizardGames.Soc.Common.State.Monster.EMonsterActionState NearThrow = 9;
	static WizardGames.Soc.Common.State.Monster.EMonsterActionState Sleep = 10;
	static WizardGames.Soc.Common.State.Monster.EMonsterActionState ToWakeUp = 11;
	static WizardGames.Soc.Common.State.Monster.EMonsterActionState WakeUp = 12;
	static WizardGames.Soc.Common.State.Monster.EMonsterActionState ClientSwitchWeapon = 31;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.State.Monster.EMonsterDirectionType : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.State.Monster.EMonsterDirectionType None = 0;
