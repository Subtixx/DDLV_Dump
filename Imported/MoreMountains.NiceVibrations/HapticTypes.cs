using Cpp2IlInjected;

namespace MoreMountains.NiceVibrations
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public enum HapticTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		Selection,
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		Failure,
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		LightImpact,
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		MediumImpact,
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		HeavyImpact,
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		None
	}
}
