using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class JwtPayload
	{
		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		[JsonProperty]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400025D")]
		public int? Exp
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AB0", Offset = "0x6E44B0", VA = "0x1806E5AB0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		[JsonProperty]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400025E")]
		public int? Iat
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AC0", Offset = "0x6E44C0", VA = "0x1806E5AC0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		[JsonProperty]
		public string Jti
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CJti_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			private set
			{
				_003CJti_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		[JsonExtensionData]
		public IDictionary<string, JToken> AdditionalData
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CAdditionalData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CAdditionalData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public object this[string key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x10329F0", Offset = "0x10313F0", VA = "0x1810329F0")]
			get
			{
				IDictionary<string, JToken> dictionary = AdditionalData;
				int num = 0;
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
				JToken jToken = (JToken)((IDictionary<TKey, TValue>)dictionary)[(TKey)key];
				goto IL_0021;
				IL_0021:
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public JwtPayload()
		{
		}
	}
}
