using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000600")]
	public enum FishRarity
	{
		[Cpp2IlInjected.Token(Token = "0x40020C7")]
		[OriginalName("FishRarity_Trash")]
		Trash,
		[Cpp2IlInjected.Token(Token = "0x40020C8")]
		[OriginalName("FishRarity_Common")]
		Common,
		[Cpp2IlInjected.Token(Token = "0x40020C9")]
		[OriginalName("FishRarity_Uncommon")]
		Uncommon,
		[Cpp2IlInjected.Token(Token = "0x40020CA")]
		[OriginalName("FishRarity_Rare")]
		Rare,
		[Cpp2IlInjected.Token(Token = "0x40020CB")]
		[OriginalName("FishRarity_Unique")]
		Unique
	}
}
