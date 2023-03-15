using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000649")]
	[Flags]
	public enum DayOfTheWeekFlag
	{
		[Cpp2IlInjected.Token(Token = "0x4002236")]
		Sunday = 1,
		[Cpp2IlInjected.Token(Token = "0x4002237")]
		Monday = 2,
		[Cpp2IlInjected.Token(Token = "0x4002238")]
		Tuesday = 4,
		[Cpp2IlInjected.Token(Token = "0x4002239")]
		Wednesday = 8,
		[Cpp2IlInjected.Token(Token = "0x400223A")]
		Thursday = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400223B")]
		Friday = 0x20,
		[Cpp2IlInjected.Token(Token = "0x400223C")]
		Saturday = 0x40,
		[Cpp2IlInjected.Token(Token = "0x400223D")]
		EveryDay = 0x7F
	}
}
