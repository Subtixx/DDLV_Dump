using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AA0")]
	public enum ControlSchemeType
	{
		[Cpp2IlInjected.Token(Token = "0x4002996")]
		[OriginalName("VPad")]
		Vpad,
		[Cpp2IlInjected.Token(Token = "0x4002997")]
		[OriginalName("FreeCameraControl")]
		FreeCameraControl,
		[Cpp2IlInjected.Token(Token = "0x4002998")]
		[OriginalName("HookedCamera")]
		HookedCamera,
		[Cpp2IlInjected.Token(Token = "0x4002999")]
		[OriginalName("ThirdPerson")]
		ThirdPerson
	}
}
