using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class Multimap<TKey, TValue> : IDictionary<TKey, IList<TValue>>, ICollection<KeyValuePair<TKey, IList<TValue>>>, IEnumerable<KeyValuePair<TKey, IList<TValue>>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly Dictionary<TKey, IList<TValue>> dictionary;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x27DB760", Offset = "0x27DA160", VA = "0x1827DB760", Slot = "12")]
			get
			{
				ICollection<> keys = ((IDictionary<TKey, TValue>)((Multimap<, >)(object)this).dictionary).get_Keys();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "13")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public IList<TValue> this[TKey key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x28B3430", Offset = "0x28B1E30", VA = "0x1828B3430", Slot = "4")]
			get
			{
				ICollection<> keys = ((IDictionary<TKey, TValue>)((Multimap<, >)(object)this).dictionary).get_Keys();
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x28B34C0", Offset = "0x28B1EC0", VA = "0x1828B34C0", Slot = "5")]
			set
			{
				//Discarded unreachable code: IL_000d
				ICollection<> keys = ((IDictionary<TKey, TValue>)((Multimap<, >)(object)this).dictionary).get_Keys();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public ICollection<TKey> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x28B3460", Offset = "0x28B1E60", VA = "0x1828B3460", Slot = "6")]
			get
			{
				//Discarded unreachable code: IL_000c
				return (ICollection<TKey>)((IDictionary<TKey, TValue>)((Multimap<, >)(object)this).dictionary).get_Keys();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ICollection<IList<TValue>> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x28B3490", Offset = "0x28B1E90", VA = "0x1828B3490", Slot = "7")]
			get
			{
				//Discarded unreachable code: IL_000c
				return (ICollection<IList<TValue>>)((IDictionary<TKey, TValue>)((Multimap<, >)(object)this).dictionary).get_Keys();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1C2EC10", Offset = "0x1C2D610", VA = "0x181C2EC10")]
		public Multimap()
		{
			Dictionary<, > dictionary = (Dictionary<, >)(object)(((Multimap<, >)(object)this).dictionary = (Dictionary<TKey, IList<TValue>>)(object)new Dictionary<TKey, TValue>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x28B3390", Offset = "0x28B1D90", VA = "0x1828B3390")]
		public Multimap(IEqualityComparer<TKey> comparer)
		{
			Dictionary<, > dictionary = (Dictionary<, >)(object)(((Multimap<, >)(object)this).dictionary = (Dictionary<TKey, IList<TValue>>)(object)new Dictionary<TKey, TValue>((IEqualityComparer<>)comparer));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x28B31B0", Offset = "0x28B1BB0", VA = "0x1828B31B0", Slot = "19")]
		public IEnumerator<KeyValuePair<TKey, IList<TValue>>> GetEnumerator()
		{
			Dictionary<, > dictionary = (Dictionary<, >)(object)((Multimap<, >)(object)this).dictionary;
			Dictionary<, >.Enumerator enumerator = default(Dictionary<, >.Enumerator);
			KeyValuePair<, > current = (KeyValuePair<, >)enumerator.current;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x28B31B0", Offset = "0x28B1BB0", VA = "0x1828B31B0", Slot = "20")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			Dictionary<, > dictionary = (Dictionary<, >)(object)((Multimap<, >)(object)this).dictionary;
			Dictionary<, >.Enumerator enumerator = default(Dictionary<, >.Enumerator);
			KeyValuePair<, > current = (KeyValuePair<, >)enumerator.current;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x28B3040", Offset = "0x28B1A40", VA = "0x1828B3040", Slot = "14")]
		public void Add(KeyValuePair<TKey, IList<TValue>> item)
		{
			bool flag = default(bool);
			if (flag)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("Could not add values to Multimap.");
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x28B2990", Offset = "0x28B1390", VA = "0x1828B2990")]
		public void Add(Multimap<TKey, TValue> multimap)
		{
			//Discarded unreachable code: IL_0038
			int num = 0;
			IEnumerator<> enumerator = multimap.GetEnumerator();
			if (enumerator != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0021;
					}
					num++;
				}
				bool flag = default(bool);
				if (!flag)
				{
					InvalidOperationException ex = new InvalidOperationException("Could not add values to Multimap.");
					throw new NullReferenceException();
				}
			}
			goto IL_0021;
			IL_0021:
			if (enumerator == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x28B30D0", Offset = "0x28B1AD0", VA = "0x1828B30D0", Slot = "15")]
		public void Clear()
		{
			//Discarded unreachable code: IL_000d
			ICollection<> keys = ((IDictionary<TKey, TValue>)((Multimap<, >)(object)this).dictionary).get_Keys();
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x28B3130", Offset = "0x28B1B30", VA = "0x1828B3130", Slot = "16")]
		public bool Contains(KeyValuePair<TKey, IList<TValue>> item)
		{
			NotImplementedException ex = new NotImplementedException();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x28B3170", Offset = "0x28B1B70", VA = "0x1828B3170", Slot = "17")]
		public void CopyTo(KeyValuePair<TKey, IList<TValue>>[] array, int arrayIndex)
		{
			NotImplementedException ex = new NotImplementedException();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x28B3270", Offset = "0x28B1C70", VA = "0x1828B3270", Slot = "18")]
		public bool Remove(KeyValuePair<TKey, IList<TValue>> item)
		{
			NotImplementedException ex = new NotImplementedException();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x28B2D30", Offset = "0x28B1730", VA = "0x1828B2D30", Slot = "9")]
		public unsafe void Add(TKey key, IList<TValue> value)
		{
			//Discarded unreachable code: IL_0031, IL_0037
			int num = 0;
			if (value != null)
			{
				if (!((Dictionary<TKey, TValue>)(object)((Multimap<, >)(object)this).dictionary).TryGetValue((TKey)key, out *(TValue*)num) || num + 1 != 0)
				{
				}
				List<> list = (List<>)(object)new List<T>((IEnumerable<>)value);
				if (!this.TryAdd(key, (IList<>)list))
				{
					InvalidOperationException ex = new InvalidOperationException("Could not add values to Multimap.");
					/*Error: Unexpected end of block*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x28B3100", Offset = "0x28B1B00", VA = "0x1828B3100", Slot = "8")]
		public bool ContainsKey(TKey key)
		{
			ICollection<> keys = ((IDictionary<TKey, TValue>)((Multimap<, >)(object)this).dictionary).get_Keys();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x28B3230", Offset = "0x28B1C30", VA = "0x1828B3230", Slot = "10")]
		public bool Remove(TKey key)
		{
			//Discarded unreachable code: IL_0002
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x28B32F0", Offset = "0x28B1CF0", VA = "0x1828B32F0", Slot = "11")]
		public bool TryGetValue(TKey key, out IList<TValue> value)
		{
			ICollection<> keys = ((IDictionary<TKey, TValue>)((Multimap<, >)(object)this).dictionary).get_Keys();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x28B2B90", Offset = "0x28B1590", VA = "0x1828B2B90")]
		public void Add(TKey key, TValue value)
		{
			//Discarded unreachable code: IL_0028
			if (value == null)
			{
				return;
			}
			Dictionary<, > dictionary = (Dictionary<, >)(object)((Multimap<, >)(object)this).dictionary;
			bool flag = default(bool);
			if (!flag)
			{
				List<> list = (List<>)(object)new List<T>();
				((List<T>)(object)list).Add((T)value);
				if (!this.TryAdd(key, (IList<>)list))
				{
					InvalidOperationException ex = new InvalidOperationException("Could not add value to Multimap.");
					/*Error: Unexpected end of block*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x28B3320", Offset = "0x28B1D20", VA = "0x1828B3320")]
		private bool TryRemove(TKey key, out IList<TValue> value)
		{
			Dictionary<, > dictionary = (Dictionary<, >)(object)((Multimap<, >)(object)this).dictionary;
			ICollection<> keys = ((IDictionary<TKey, TValue>)((Multimap<, >)(object)this).dictionary).get_Keys();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x28B32B0", Offset = "0x28B1CB0", VA = "0x1828B32B0")]
		private bool TryAdd(TKey key, IList<TValue> value)
		{
			//Discarded unreachable code: IL_000f
			((Dictionary<TKey, TValue>)(object)((Multimap<, >)(object)this).dictionary).Add((TKey)key, (TValue)value);
			return true;
		}
	}
}
