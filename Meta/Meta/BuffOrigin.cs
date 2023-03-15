using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20007DA")]
	public enum BuffOrigin
	{
		[Cpp2IlInjected.Token(Token = "0x4001F38")]
		[OriginalName("BuffOrigin_Default")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4001F39")]
		[OriginalName("BuffOrigin_MicroEvent")]
		MicroEvent,
		[Cpp2IlInjected.Token(Token = "0x4001F3A")]
		[OriginalName("BuffOrigin_Hangout")]
		Hangout,
		[Cpp2IlInjected.Token(Token = "0x4001F3B")]
		[OriginalName("BuffOrigin_BuffElixir")]
		BuffElixir
	}
}
