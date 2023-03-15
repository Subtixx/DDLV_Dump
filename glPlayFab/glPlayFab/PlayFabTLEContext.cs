using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public class PlayFabTLEContext
	{
		[Cpp2IlInjected.Token(Token = "0x2000154")]
		public enum Type
		{
			[Cpp2IlInjected.Token(Token = "0x400050F")]
			Social,
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			Game
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public readonly Dictionary<Type, string> PlayerDataKeys;

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x14EFC50", Offset = "0x14EE650", VA = "0x1814EFC50")]
		public string GetPlayerDataKey(Type type)
		{
			//Discarded unreachable code: IL_0009
			Dictionary<Type, string> playerDataKeys = PlayerDataKeys;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x14EFCB0", Offset = "0x14EE6B0", VA = "0x1814EFCB0")]
		public PlayFabTLEContext()
		{
			//Discarded unreachable code: IL_000c, IL_0012, IL_0020
			Dictionary<Type, string> dictionary = (Dictionary<Type, string>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}
	}
}
