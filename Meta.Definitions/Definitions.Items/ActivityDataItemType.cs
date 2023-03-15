using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005DC")]
	public enum ActivityDataItemType
	{
		[Cpp2IlInjected.Token(Token = "0x4002000")]
		[OriginalName("ActivityDataItemType_CookingRecipe")]
		CookingRecipe,
		[Cpp2IlInjected.Token(Token = "0x4002001")]
		[OriginalName("ActivityDataItemType_FishingData")]
		FishingData,
		[Cpp2IlInjected.Token(Token = "0x4002002")]
		[OriginalName("ActivityDataItemType_MiningData")]
		MiningData,
		[Cpp2IlInjected.Token(Token = "0x4002003")]
		[OriginalName("ActivityDataItemType_CraftingRecipe")]
		CraftingRecipe
	}
}
