using System;
using Cpp2IlInjected;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20009A3")]
	[Flags]
	public enum HudApparitionPhases
	{
		[Cpp2IlInjected.Token(Token = "0x40027C4")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40027C5")]
		PROFILE = 1,
		[Cpp2IlInjected.Token(Token = "0x40027C6")]
		REQUESTS = 2,
		[Cpp2IlInjected.Token(Token = "0x40027C7")]
		BACKPACK = 4,
		[Cpp2IlInjected.Token(Token = "0x40027C8")]
		MAP = 8,
		[Cpp2IlInjected.Token(Token = "0x40027C9")]
		OPTION = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40027CA")]
		CATALOG = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40027CB")]
		WARDROBE = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40027CC")]
		PHOTO = 0x80,
		[Cpp2IlInjected.Token(Token = "0x40027CD")]
		PHONE = 0x100,
		[Cpp2IlInjected.Token(Token = "0x40027CE")]
		CHARACTERS = 0x200,
		[Cpp2IlInjected.Token(Token = "0x40027CF")]
		COLLECTION = 0x400,
		[Cpp2IlInjected.Token(Token = "0x40027D0")]
		SHOP = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x40027D1")]
		EVENTS = 0x2000,
		[Cpp2IlInjected.Token(Token = "0x40027D2")]
		TOOLS = 0x4000,
		[Cpp2IlInjected.Token(Token = "0x40027D3")]
		ROYAL_DUTIES = 0x8000,
		[Cpp2IlInjected.Token(Token = "0x40027D4")]
		ACHIEVEMENT_NOTIF = 0x10000,
		[Cpp2IlInjected.Token(Token = "0x40027D5")]
		BASE = 0x17FF,
		[Cpp2IlInjected.Token(Token = "0x40027D6")]
		ALL = 0x1F7FF
	}
}
