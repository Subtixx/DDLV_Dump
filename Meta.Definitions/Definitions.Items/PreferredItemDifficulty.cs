using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000615")]
	public enum PreferredItemDifficulty
	{
		[Cpp2IlInjected.Token(Token = "0x400217D")]
		[OriginalName("PreferredItemDifficulty_None")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400217E")]
		[OriginalName("PreferredItemDifficulty_Low")]
		Low,
		[Cpp2IlInjected.Token(Token = "0x400217F")]
		[OriginalName("PreferredItemDifficulty_Medium")]
		Medium,
		[Cpp2IlInjected.Token(Token = "0x4002180")]
		[OriginalName("PreferredItemDifficulty_High")]
		High
	}
}
