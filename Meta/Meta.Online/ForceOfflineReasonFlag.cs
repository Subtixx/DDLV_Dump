using System;
using Cpp2IlInjected;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000EFE")]
	[Flags]
	public enum ForceOfflineReasonFlag
	{
		[Cpp2IlInjected.Token(Token = "0x4003D36")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4003D37")]
		Cheats = 1,
		[Cpp2IlInjected.Token(Token = "0x4003D38")]
		NintendoSwitchNoNSA = 2,
		[Cpp2IlInjected.Token(Token = "0x4003D39")]
		AgeGate = 4
	}
}
