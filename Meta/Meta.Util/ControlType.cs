using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AA1")]
	public enum ControlType
	{
		[Cpp2IlInjected.Token(Token = "0x400299B")]
		[OriginalName("None")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400299C")]
		[OriginalName("Xbox360")]
		Xbox360 = 1,
		[Cpp2IlInjected.Token(Token = "0x400299D")]
		[OriginalName("XBoxOne")]
		XboxOne = 2,
		[Cpp2IlInjected.Token(Token = "0x400299E")]
		[OriginalName("PlayStation4")]
		PlayStation4 = 3,
		[Cpp2IlInjected.Token(Token = "0x400299F")]
		[OriginalName("NintendoSwitch")]
		NintendoSwitch = 4,
		[Cpp2IlInjected.Token(Token = "0x40029A0")]
		[OriginalName("Keyboard")]
		Keyboard = 6
	}
}
