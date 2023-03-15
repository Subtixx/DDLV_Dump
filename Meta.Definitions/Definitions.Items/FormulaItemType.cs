using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200061B")]
	public enum FormulaItemType
	{
		[Cpp2IlInjected.Token(Token = "0x40021AA")]
		[OriginalName("FormulaItemType_Price")]
		Price,
		[Cpp2IlInjected.Token(Token = "0x40021AB")]
		[OriginalName("FormulaItemType_MissionStep")]
		MissionStep,
		[Cpp2IlInjected.Token(Token = "0x40021AC")]
		[OriginalName("FormulaItemType_SellPrice")]
		SellPrice,
		[Cpp2IlInjected.Token(Token = "0x40021AD")]
		[OriginalName("FormulaItemType_ProfessionStat")]
		ProfessionStat
	}
}
