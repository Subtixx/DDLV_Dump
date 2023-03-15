using System;
using Cpp2IlInjected;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000DC7")]
	[Flags]
	public enum PurgeFilter
	{
		[Cpp2IlInjected.Token(Token = "0x40037B3")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40037B4")]
		Claimed = 1,
		[Cpp2IlInjected.Token(Token = "0x40037B5")]
		Expired = 2,
		[Cpp2IlInjected.Token(Token = "0x40037B6")]
		All = -1
	}
}
