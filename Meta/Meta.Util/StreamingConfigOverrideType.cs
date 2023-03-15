using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000A9E")]
	public enum StreamingConfigOverrideType
	{
		[Cpp2IlInjected.Token(Token = "0x400298C")]
		[OriginalName("PlatformDefault")]
		PlatformDefault,
		[Cpp2IlInjected.Token(Token = "0x400298D")]
		[OriginalName("Aggresive")]
		Aggresive,
		[Cpp2IlInjected.Token(Token = "0x400298E")]
		[OriginalName("LoadAlmostEverything")]
		LoadAlmostEverything,
		[Cpp2IlInjected.Token(Token = "0x400298F")]
		[OriginalName("LoadEverything")]
		LoadEverything
	}
}
