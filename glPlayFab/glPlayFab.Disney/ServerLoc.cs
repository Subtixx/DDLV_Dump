using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	public class ServerLoc
	{
		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public Dictionary<string, string> LocByLanguage
		{
			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CLocByLanguage_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CLocByLanguage_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0x14F61A0", Offset = "0x14F4BA0", VA = "0x1814F61A0")]
		public string GetLocalizedText()
		{
			if (LocByLanguage != null)
			{
			}
			return string.Empty;
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ServerLoc()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x14F6220", Offset = "0x14F4C20", VA = "0x1814F6220")]
		public ServerLoc(ServerLoc other)
		{
			//Discarded unreachable code: IL_0027
			Dictionary<string, string> dictionary = (LocByLanguage = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>());
			Dictionary<string, string> dictionary2 = other.LocByLanguage;
			bool flag = default(bool);
			if (flag)
			{
				Dictionary<string, string> dictionary3 = LocByLanguage;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x14F6000", Offset = "0x14F4A00", VA = "0x1814F6000")]
		public unsafe static ServerLoc CreateSingleLocFrom(ServerLoc allServerLoc, string language)
		{
			//Discarded unreachable code: IL_0051, IL_0053
			int num = 0;
			ServerLoc serverLoc = new ServerLoc();
			Dictionary<string, string> dictionary = (serverLoc.LocByLanguage = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>());
			if (!((Dictionary<TKey, TValue>)(object)allServerLoc.LocByLanguage).TryGetValue((TKey)language, out *(TValue*)num))
			{
				bool flag = ((Dictionary<TKey, TValue>)(object)allServerLoc.LocByLanguage).TryGetValue((TKey)"neutral", out *(TValue*)num);
				Dictionary<string, string> dictionary2 = serverLoc.LocByLanguage;
				if (flag)
				{
				}
			}
			Dictionary<string, string> dictionary3 = serverLoc.LocByLanguage;
			throw new NullReferenceException();
		}
	}
}
