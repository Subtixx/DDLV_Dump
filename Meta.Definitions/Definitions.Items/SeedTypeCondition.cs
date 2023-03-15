using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000605")]
	public enum SeedTypeCondition
	{
		[Cpp2IlInjected.Token(Token = "0x40020E1")]
		[OriginalName("SeedTypeCondition_Any")]
		Any,
		[Cpp2IlInjected.Token(Token = "0x40020E2")]
		[OriginalName("SeedTypeCondition_Regular")]
		Regular,
		[Cpp2IlInjected.Token(Token = "0x40020E3")]
		[OriginalName("SeedTypeCondition_FruitTree")]
		FruitTree,
		[Cpp2IlInjected.Token(Token = "0x40020E4")]
		[OriginalName("SeedTypeCondition_WildCrop")]
		WildCrop
	}
}
