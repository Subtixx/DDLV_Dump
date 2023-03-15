using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000C8")]
public abstract class SerializableDictionaryBase
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public abstract class Storage
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected Storage()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	protected class Dictionary<TKey, TValue> : System.Collections.Generic.Dictionary<TKey, TValue>
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x912C70", Offset = "0x911670", VA = "0x180912C70")]
		public Dictionary()
		{
			//Discarded unreachable code: IL_0008
			ICollection<> collection = ((IDictionary<TKey, TValue>)this).get_Keys();
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x1C35980", Offset = "0x1C34380", VA = "0x181C35980")]
		public Dictionary(IDictionary<TKey, TValue> dict)
		{
			//Discarded unreachable code: IL_0008
			ICollection<> collection = ((IDictionary<TKey, TValue>)this).get_Keys();
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x213D740", Offset = "0x213C140", VA = "0x18213D740")]
		public Dictionary(SerializationInfo info, StreamingContext context)
		{
		}//Discarded unreachable code: IL_0001

	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
	protected SerializableDictionaryBase()
	{
		((ArraySegment<T>.ArraySegmentEnumerator)this).Dispose();
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public abstract class SerializableDictionaryBase<TKey, TValue, TValueStorage> : SerializableDictionaryBase, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, ISerializationCallbackReceiver, IDeserializationCallback, ISerializable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private Dictionary<TKey, TValue> m_dict;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	[SerializeField]
	private TKey[] m_keys;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	[SerializeField]
	private TValueStorage[] m_values;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public ICollection<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x213B680", Offset = "0x213A080", VA = "0x18213B680", Slot = "6")]
		get
		{
			Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
			throw new NullReferenceException();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public ICollection<TValue> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x213B730", Offset = "0x213A130", VA = "0x18213B730", Slot = "7")]
		get
		{
			Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
			throw new NullReferenceException();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x213B450", Offset = "0x2139E50", VA = "0x18213B450", Slot = "33")]
		get
		{
			Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
			throw new NullReferenceException();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool IsReadOnly
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x213B500", Offset = "0x2139F00", VA = "0x18213B500", Slot = "28")]
		get
		{
			Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
			throw new NullReferenceException();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public TValue this[TKey key]
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x213B610", Offset = "0x213A010", VA = "0x18213B610", Slot = "4")]
		get
		{
			Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
			throw new NullReferenceException();
		}
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x213B790", Offset = "0x213A190", VA = "0x18213B790", Slot = "5")]
		set
		{
			//Discarded unreachable code: IL_0008
			Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool IsFixedSize
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x213B4B0", Offset = "0x2139EB0", VA = "0x18213B4B0", Slot = "29")]
		get
		{
			Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
			throw new NullReferenceException();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	ICollection IDictionary.Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x213B0E0", Offset = "0x2139AE0", VA = "0x18213B0E0", Slot = "23")]
		get
		{
			Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
			throw new NullReferenceException();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	ICollection IDictionary.Values
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x213B130", Offset = "0x2139B30", VA = "0x18213B130", Slot = "24")]
		get
		{
			Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
			throw new NullReferenceException();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool IsSynchronized
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x213B560", Offset = "0x2139F60", VA = "0x18213B560", Slot = "35")]
		get
		{
			Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
			throw new NullReferenceException();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public object SyncRoot
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x213B6E0", Offset = "0x213A0E0", VA = "0x18213B6E0", Slot = "34")]
		get
		{
			Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
			throw new NullReferenceException();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public object this[object key]
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x213B5B0", Offset = "0x2139FB0", VA = "0x18213B5B0", Slot = "21")]
		get
		{
			Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
			throw new NullReferenceException();
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x213B810", Offset = "0x213A210", VA = "0x18213B810", Slot = "22")]
		set
		{
			//Discarded unreachable code: IL_0008
			Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x213B260", Offset = "0x2139C60", VA = "0x18213B260")]
	public SerializableDictionaryBase()
	{
		((Attribute)(object)this)._002Ector();
		Dictionary<, > dictionary = (Dictionary<, >)(object)(((SerializableDictionaryBase<, , >)(object)this).m_dict = (Dictionary<TKey, TValue>)(object)new Dictionary<TKey, TValue>());
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x213B3B0", Offset = "0x2139DB0", VA = "0x18213B3B0")]
	public SerializableDictionaryBase(IDictionary<TKey, TValue> dict)
	{
		((Attribute)(object)this)._002Ector();
		Dictionary<, > dictionary = (Dictionary<, >)(object)(((SerializableDictionaryBase<, , >)(object)this).m_dict = (Dictionary<TKey, TValue>)(object)new Dictionary<TKey, TValue>((IDictionary<, >)dict));
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "40")]
	protected abstract void SetValue(TValueStorage[] storage, int i, TValue value);

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "41")]
	protected abstract TValue GetValue(TValueStorage[] storage, int i);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x213A5C0", Offset = "0x2138FC0", VA = "0x18213A5C0")]
	public void CopyFrom(IDictionary<TKey, TValue> dict)
	{
		//Discarded unreachable code: IL_001d, IL_0023
		int num = 0;
		((System.Collections.Generic.Dictionary<TKey, TValue>)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict).Clear();
		num += num;
		num++;
		Dictionary<, > dict2 = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x213AA90", Offset = "0x2139490", VA = "0x18213AA90", Slot = "37")]
	public void OnAfterDeserialize()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x213ABF0", Offset = "0x21395F0", VA = "0x18213ABF0", Slot = "36")]
	public void OnBeforeSerialize()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x213A200", Offset = "0x2138C00", VA = "0x18213A200", Slot = "9")]
	public void Add(TKey key, TValue value)
	{
		//Discarded unreachable code: IL_0008
		Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x213A420", Offset = "0x2138E20", VA = "0x18213A420", Slot = "8")]
	public bool ContainsKey(TKey key)
	{
		Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x213AEF0", Offset = "0x21398F0", VA = "0x18213AEF0", Slot = "10")]
	public bool Remove(TKey key)
	{
		Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x213B180", Offset = "0x2139B80", VA = "0x18213B180", Slot = "11")]
	public bool TryGetValue(TKey key, out TValue value)
	{
		Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
		int num = 0;
		uint num2 = default(uint);
		if (num < (int)num2)
		{
			num += num;
			if (num == (int)num2)
			{
				goto IL_0020;
			}
			num++;
		}
		ICollection<> keys = ((IDictionary<TKey, TValue>)dict).get_Keys();
		goto IL_0020;
		IL_0020:
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x213A280", Offset = "0x2138C80", VA = "0x18213A280", Slot = "14")]
	public void Add(KeyValuePair<TKey, TValue> item)
	{
		Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
		int num = 0;
		uint num2 = default(uint);
		if (num < (int)num2)
		{
			num += num;
			if (num == (int)num2)
			{
				throw new NullReferenceException();
			}
			num++;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x213A3C0", Offset = "0x2138DC0", VA = "0x18213A3C0", Slot = "27")]
	public void Clear()
	{
		Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x213A490", Offset = "0x2138E90", VA = "0x18213A490", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TValue> item)
	{
		Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
		int num = 0;
		uint num2 = default(uint);
		if (num < (int)num2)
		{
			num += num;
			if (num != (int)num2)
			{
				num++;
			}
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x213A880", Offset = "0x2139280", VA = "0x18213A880", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
	{
		Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
		int num = 0;
		uint num2 = default(uint);
		if (num < (int)num2)
		{
			num += num;
			if (num == (int)num2)
			{
				throw new NullReferenceException();
			}
			num++;
		}
		ICollection<> keys = ((IDictionary<TKey, TValue>)dict).get_Keys();
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x213AF60", Offset = "0x2139960", VA = "0x18213AF60", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TValue> item)
	{
		Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
		int num = 0;
		uint num2 = default(uint);
		if (num < (int)num2)
		{
			num += num;
			if (num != (int)num2)
			{
				num++;
			}
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x213A960", Offset = "0x2139360", VA = "0x18213A960", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x213A960", Offset = "0x2139360", VA = "0x18213A960", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x213A350", Offset = "0x2138D50", VA = "0x18213A350", Slot = "26")]
	public void Add(object key, object value)
	{
		//Discarded unreachable code: IL_0008
		Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x213A560", Offset = "0x2138F60", VA = "0x18213A560", Slot = "25")]
	public bool Contains(object key)
	{
		Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x213B090", Offset = "0x2139A90", VA = "0x18213B090", Slot = "30")]
	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x213B030", Offset = "0x2139A30", VA = "0x18213B030", Slot = "31")]
	public void Remove(object key)
	{
		Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x213A7B0", Offset = "0x21391B0", VA = "0x18213A7B0", Slot = "32")]
	public void CopyTo(Array array, int index)
	{
		//Discarded unreachable code: IL_001d
		Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
		int num = 0;
		uint num2 = default(uint);
		if (num < (int)num2)
		{
			num += num;
			num++;
		}
		ICollection<> keys = ((IDictionary<TKey, TValue>)dict).get_Keys();
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x213AE90", Offset = "0x2139890", VA = "0x18213AE90", Slot = "38")]
	public void OnDeserialization(object sender)
	{
		Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x213B2F0", Offset = "0x2139CF0", VA = "0x18213B2F0")]
	protected SerializableDictionaryBase(SerializationInfo info, StreamingContext context)
	{
		((Attribute)(object)this)._002Ector();
		Dictionary<, > dict = default(Dictionary<, >);
		((SerializableDictionaryBase<, , >)(object)this).m_dict = (Dictionary<TKey, TValue>)(object)dict;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x213A9C0", Offset = "0x21393C0", VA = "0x18213A9C0", Slot = "39")]
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_0016
		Dictionary<, > dict = (Dictionary<, >)(object)((SerializableDictionaryBase<, , >)(object)this).m_dict;
		int num = 0;
		uint num2 = default(uint);
		if (num < (int)num2)
		{
			num += num;
			num++;
		}
	}
}
