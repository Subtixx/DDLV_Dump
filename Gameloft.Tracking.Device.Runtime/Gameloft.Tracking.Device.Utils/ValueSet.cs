using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Linq;
using UnityEngine.UI;

namespace Gameloft.Tracking.Device.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class ValueSet
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private KeyValueStorage parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private ConcurrentDictionary<string, JToken> values;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x4030690", Offset = "0x402F090", VA = "0x184030690")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((ConcurrentDictionary<TKey, TValue>)(object)values).IsEmpty;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000048")]
		public bool IsDirty
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4030640", Offset = "0x402F040", VA = "0x184030640")]
		internal ValueSet(KeyValueStorage parent, ConcurrentDictionary<string, JToken> values)
		{
			((Graphic)this).GraphicUpdateComplete();
			this.parent = parent;
			this.values = values;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x20BF040", Offset = "0x20BDA40", VA = "0x1820BF040")]
		public unsafe T GetAs<T>(string key, [Optional] T defaultValue)
		{
			//Discarded unreachable code: IL_001a
			int num = 0;
			if (!((ConcurrentDictionary<TKey, TValue>)(object)values).TryGetValue((TKey)key, out *(TValue*)num))
			{
				return defaultValue;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x20BF4C0", Offset = "0x20BDEC0", VA = "0x1820BF4C0")]
		public ValueSet Set<T>(string key, T value)
		{
			//Discarded unreachable code: IL_0022
			ConcurrentDictionary<string, JToken> concurrentDictionary = values;
			if ((long)"{il2cpp array field il2cppMethodInfo->}" == 1)
			{
			}
			JToken value2 = default(JToken);
			((ConcurrentDictionary<TKey, TValue>)(object)concurrentDictionary)[(TKey)key] = (TValue)value2;
			IsDirty = true;
			return this;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4030610", Offset = "0x402F010", VA = "0x184030610")]
		public void Save()
		{
			//Discarded unreachable code: IL_0016
			if (IsDirty)
			{
				parent.Store();
			}
		}
	}
}
