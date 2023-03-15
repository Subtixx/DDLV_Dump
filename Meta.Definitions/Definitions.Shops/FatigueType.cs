using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Shops
{
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	public enum FatigueType
	{
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		[OriginalName("FatigueType_Unlimited")]
		Unlimited = 0,
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		[OriginalName("FatigueType_Hourly")]
		Hourly = 1,
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		[OriginalName("FatigueType_Daily")]
		Daily = 2,
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		[OriginalName("FatigueType_Weekly")]
		Weekly = 3,
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		[OriginalName("FatigueType_Monthy")]
		Monthy = 4,
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		[OriginalName("FatigueType_Interval")]
		Interval = 9,
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		[OriginalName("FatigueType_Absolute")]
		Absolute = 10
	}
}
