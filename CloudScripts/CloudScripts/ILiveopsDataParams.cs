using System.Collections.Generic;
using Cpp2IlInjected;
using glPlayFab.Disney;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	public interface ILiveopsDataParams
	{
		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		Dictionary<string, KnownConfig> KnownConfigIds
		{
			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		string CurrentLanguage
		{
			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		bool IncludeScheduled
		{
			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		ServerDataType ServerDataType
		{
			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		string OnlineFlagKey
		{
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
}
