using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public abstract class BaseConfig : IRemoteConfig
	{
		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public abstract Type ClassType
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public abstract ConfigType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public string BaseVersion
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CBaseVersion_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CBaseVersion_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Dictionary<string, List<ConfigDef>> Data
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x1023FA0", Offset = "0x10229A0", VA = "0x181023FA0")]
		public bool Equals(GameConfig other)
		{
			GameConfig gameConfig = other;
			string b = default(string);
			if (string.Equals(BaseVersion, b))
			{
				int count = ((Dictionary<TKey, TValue>)(object)Data).Count;
				int count2 = ((Dictionary<TKey, TValue>)(object)other.Data).Count;
				if (count == count2)
				{
					Dictionary<string, List<ConfigDef>> dictionary = Data;
					Func<KeyValuePair<string, List<ConfigDef>>, bool> func = (Func<KeyValuePair<string, List<ConfigDef>>, bool>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_0012, IL_0016, IL_004a
						Dictionary<string, List<ConfigDef>> dictionary2 = other.Data;
						throw new NullReferenceException();
					};
					return ((IEnumerable<>)dictionary).All<KeyValuePair<string, List<ConfigDef>>>((Func<, >)(object)func);
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected BaseConfig()
		{
		}
	}
}
