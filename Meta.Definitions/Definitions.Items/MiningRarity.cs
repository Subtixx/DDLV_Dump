using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000602")]
	public enum MiningRarity
	{
		[Cpp2IlInjected.Token(Token = "0x40020D3")]
		[OriginalName("MiningRarity_Common")]
		Common,
		[Cpp2IlInjected.Token(Token = "0x40020D4")]
		[OriginalName("MiningRarity_Uncommon")]
		Uncommon,
		[Cpp2IlInjected.Token(Token = "0x40020D5")]
		[OriginalName("MiningRarity_Rare")]
		Rare,
		[Cpp2IlInjected.Token(Token = "0x40020D6")]
		[OriginalName("MiningRarity_Gem")]
		Gem,
		[Cpp2IlInjected.Token(Token = "0x40020D7")]
		[OriginalName("MiningRarity_RareGem")]
		RareGem
	}
}
