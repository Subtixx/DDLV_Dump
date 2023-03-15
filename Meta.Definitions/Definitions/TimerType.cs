using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum TimerType
	{
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[OriginalName("TimerType_Gardening")]
		Gardening,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[OriginalName("TimerType_Cooking")]
		Cooking
	}
}
