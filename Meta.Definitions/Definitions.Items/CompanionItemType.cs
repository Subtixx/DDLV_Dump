using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005E0")]
	public enum CompanionItemType
	{
		[Cpp2IlInjected.Token(Token = "0x400200E")]
		[OriginalName("CompanionItemType_Pet")]
		Pet,
		[Cpp2IlInjected.Token(Token = "0x400200F")]
		[OriginalName("CompanionItemType_Critter")]
		Critter
	}
}
