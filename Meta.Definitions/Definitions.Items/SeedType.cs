using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000604")]
	public enum SeedType
	{
		[Cpp2IlInjected.Token(Token = "0x40020DD")]
		[OriginalName("SeedType_Regular")]
		Regular,
		[Cpp2IlInjected.Token(Token = "0x40020DE")]
		[OriginalName("SeedType_FruitTree")]
		FruitTree,
		[Cpp2IlInjected.Token(Token = "0x40020DF")]
		[OriginalName("SeedType_WildCrop")]
		WildCrop
	}
}
