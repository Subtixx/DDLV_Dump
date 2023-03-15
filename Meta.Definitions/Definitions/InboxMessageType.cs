using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public enum InboxMessageType
	{
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		[OriginalName("Unset")]
		Unset,
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		[OriginalName("DailyLogin")]
		DailyLogin,
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		[OriginalName("TLE")]
		Tle,
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		[OriginalName("Social")]
		Social,
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		[OriginalName("CustomerCare")]
		CustomerCare,
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		[OriginalName("GameCommunication")]
		GameCommunication,
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		[OriginalName("WelcomeMessage")]
		WelcomeMessage,
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		[OriginalName("Promotion")]
		Promotion,
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		[OriginalName("InventoryFull")]
		InventoryFull
	}
}
