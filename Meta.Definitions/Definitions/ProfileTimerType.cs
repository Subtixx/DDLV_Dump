using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public enum ProfileTimerType
	{
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[OriginalName("ProfileTimerType_Played")]
		Played,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[OriginalName("ProfileTimerType_Uncursed")]
		Uncursed
	}
}
