using Cpp2IlInjected;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum HttpMethod
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Get,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		Post,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		Put,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		Delete,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		Head,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		Options,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		Patch
	}
}
