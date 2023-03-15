using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Linq;

namespace Gameloft.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class JsonExtension
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4113A80", Offset = "0x4112480", VA = "0x184113A80")]
		public static bool IsNull(this JToken token)
		{
			if (token == null)
			{
				return true;
			}
			return token.Type == JTokenType.Null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x41139E0", Offset = "0x41123E0", VA = "0x1841139E0")]
		public static JToken Get(this JToken token, string key)
		{
			JToken jToken = token[key];
			if (jToken != null)
			{
				return jToken;
			}
			ArgumentException ex = new ArgumentException("Invalid key", "key");
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x41139A0", Offset = "0x41123A0", VA = "0x1841139A0")]
		public static JToken GetOrDefault(this JToken token, string key, [Optional] JToken defaultValue)
		{
			//Discarded unreachable code: IL_0008
			return token[key];
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x16CA3A0", Offset = "0x16C8DA0", VA = "0x1816CA3A0")]
		public static T GetAs<T>(this JToken token)
		{
			JToken jToken = token.CloneToken();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x19B2390", Offset = "0x19B0D90", VA = "0x1819B2390")]
		public static T GetAs<T>(this JToken token, Func<JToken, T> converter)
		{
			object obj = ((ICloneable)converter).Clone();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x19B22C0", Offset = "0x19B0CC0", VA = "0x1819B22C0")]
		public static T GetAsOrDefault<T>(this JToken token, [Optional] T defaultValue)
		{
			if (!token.IsNull())
			{
				JToken jToken = token.CloneToken();
			}
			return defaultValue;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x19B2360", Offset = "0x19B0D60", VA = "0x1819B2360")]
		public static T GetAs<T>(this JToken token, string key)
		{
			JToken jToken = token.Get(key).CloneToken();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x19B2320", Offset = "0x19B0D20", VA = "0x1819B2320")]
		public static T GetAs<T>(this JToken token, string key, Func<JToken, T> converter)
		{
			JToken jToken = token.Get(key).CloneToken();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x19B2280", Offset = "0x19B0C80", VA = "0x1819B2280")]
		public static T GetAsOrDefault<T>(this JToken token, string key, [Optional] T defaultValue)
		{
			//IL_000a: Expected O, but got I4
			int num = 0;
			JToken jToken = token.GetOrDefault(key, (JToken)num).CloneToken();
			/*Error: Unexpected end of block*/;
		}
	}
}
