using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000A9B")]
	public enum MetaThreadPriority
	{
		[Cpp2IlInjected.Token(Token = "0x4002976")]
		[OriginalName("MetaThreadPriority_Default")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4002977")]
		[OriginalName("MetaThreadPriority_Low")]
		Low = 1,
		[Cpp2IlInjected.Token(Token = "0x4002978")]
		[OriginalName("MetaThreadPriority_BelowNormal")]
		BelowNormal = 2,
		[Cpp2IlInjected.Token(Token = "0x4002979")]
		[OriginalName("MetaThreadPriority_Normal")]
		Normal = 3,
		[Cpp2IlInjected.Token(Token = "0x400297A")]
		[OriginalName("MetaThreadPriority_High")]
		High = 5
	}
}
