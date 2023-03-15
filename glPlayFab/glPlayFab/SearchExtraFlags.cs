using System;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[Flags]
	public enum SearchExtraFlags
	{
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		Inversed = 1,
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		AllowNull = 2,
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		All = -1
	}
}
