using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta.Online.Fed
{
	[Cpp2IlInjected.Token(Token = "0x2000FE8")]
	public enum Platform
	{
		[Cpp2IlInjected.Token(Token = "0x4004156")]
		[OriginalName("Platform_iOS")]
		IOs,
		[Cpp2IlInjected.Token(Token = "0x4004157")]
		[OriginalName("Platform_Android")]
		Android,
		[Cpp2IlInjected.Token(Token = "0x4004158")]
		[OriginalName("Platform_Switch")]
		Switch,
		[Cpp2IlInjected.Token(Token = "0x4004159")]
		[OriginalName("Platform_Windows")]
		Windows,
		[Cpp2IlInjected.Token(Token = "0x400415A")]
		[OriginalName("Platform_Steam")]
		Steam
	}
}
