using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000646")]
	public static class EnumConditionTypeExt
	{
		[Cpp2IlInjected.Token(Token = "0x6004A23")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B9F0", Offset = "0x2C9A3F0", VA = "0x182C9B9F0")]
		public static bool EnumConditionTypeMatcher(this FlowerRarity rarity, FlowerRarityCondition rarityCondition)
		{
			if (rarityCondition == FlowerRarityCondition.Any)
			{
				return true;
			}
			bool result = default(bool);
			return result;
		}
	}
}
