using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public static class OnlineEnvironmentConfig
	{
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private static Dictionary<OnlineEnvironment, string> titleIds;

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x1034620", Offset = "0x1033020", VA = "0x181034620")]
		public static string GetTitleId(OnlineEnvironment env)
		{
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x10346C0", Offset = "0x10330C0", VA = "0x1810346C0")]
		public static OnlineEnvironment ParseEnv(string envAsStr)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x1034470", Offset = "0x1032E70", VA = "0x181034470")]
		public unsafe static OnlineEnvironment GetOnlineEnvFromTitleId(string titleId)
		{
			//Discarded unreachable code: IL_002c
			//IL_0028: Expected I4, but got O
			Func<KeyValuePair<OnlineEnvironment, string>, bool> func = (Func<KeyValuePair<OnlineEnvironment, string>, bool>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_0009
				string text = titleId;
				bool result2 = default(bool);
				return result2;
			};
			int num = 0;
			KeyValuePair<OnlineEnvironment, string> keyValuePair = default(KeyValuePair<OnlineEnvironment, string>);
			if ((object)keyValuePair == null)
			{
				return (OnlineEnvironment)((KeyValuePair<, >*)(&keyValuePair))->key;
			}
			OnlineEnvironment result = default(OnlineEnvironment);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x1034740", Offset = "0x1033140", VA = "0x181034740")]
		static OnlineEnvironmentConfig()
		{
			//Discarded unreachable code: IL_000c, IL_0012, IL_0018, IL_001e, IL_0024, IL_002a, IL_0030, IL_0036
			Dictionary<OnlineEnvironment, string> dictionary = (Dictionary<OnlineEnvironment, string>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}
	}
}
