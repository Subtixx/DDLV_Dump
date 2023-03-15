using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public static class Entity
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		public enum Types
		{
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			Title,
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			MasterPlayerAccount,
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			TitlePlayerAccount,
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			Character
		}

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private static Dictionary<Types, string> typeNames;

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x102E2A0", Offset = "0x102CCA0", VA = "0x18102E2A0")]
		public static string GetName(Types type)
		{
			//Discarded unreachable code: IL_0004
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x102E320", Offset = "0x102CD20", VA = "0x18102E320")]
		public static Types GetType(string name)
		{
			Func<KeyValuePair<Types, string>, bool> func = (Func<KeyValuePair<Types, string>, bool>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x102E460", Offset = "0x102CE60", VA = "0x18102E460")]
		static Entity()
		{
			//Discarded unreachable code: IL_000c, IL_0012, IL_0018, IL_001e
			Dictionary<Types, string> dictionary = (Dictionary<Types, string>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}
	}
}
