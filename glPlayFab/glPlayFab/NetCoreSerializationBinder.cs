using System;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Newtonsoft.Json.Serialization;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	public class NetCoreSerializationBinder : DefaultSerializationBinder
	{
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private static readonly Regex regex = new Regex("System\\.Private\\.CoreLib(, Version=[\\d\\.]+)?(, Culture=[\\w-]+)(, PublicKeyToken=[\\w\\d]+)?");

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private static readonly ConcurrentDictionary<Type, (string assembly, string type)> cache;

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x1033AD0", Offset = "0x10324D0", VA = "0x181033AD0", Slot = "4")]
		public unsafe override void BindToName(Type serializedType, out string assemblyName, out string typeName)
		{
			//IL_0037: Expected O, but got I4
			int num = 0;
			base.BindToName(serializedType, out assemblyName, out typeName);
			if (!((ConcurrentDictionary<TKey, TValue>)(object)cache).TryGetValue((TKey)serializedType, out *(TValue*)num))
			{
				Regex regex = NetCoreSerializationBinder.regex;
				Regex regex2 = NetCoreSerializationBinder.regex;
				int num2 = 0;
				bool flag = ((ConcurrentDictionary<TKey, TValue>)(object)cache).TryAdd((TKey)serializedType, (TValue)num2);
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x1033E50", Offset = "0x1032850", VA = "0x181033E50")]
		public NetCoreSerializationBinder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x1033D80", Offset = "0x1032780", VA = "0x181033D80")]
		static NetCoreSerializationBinder()
		{
			regex = (Regex)(object)new ConcurrentDictionary<TKey, TValue>();
			/*Error: Unexpected end of block*/;
		}
	}
}
