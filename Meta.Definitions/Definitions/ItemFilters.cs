using Cpp2IlInjected;
using Definitions.Items;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	public static class ItemFilters
	{
		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x25D7C30", Offset = "0x25D6630", VA = "0x1825D7C30")]
		public static bool IsRewardItem(Item item)
		{
			ItemType itemType = default(ItemType);
			if (itemType != ItemType.ActivityItem)
			{
				ItemType itemType2 = default(ItemType);
				ItemType itemType3 = default(ItemType);
				ItemType itemType4 = default(ItemType);
				ItemType itemType5 = default(ItemType);
				ItemType itemType6 = default(ItemType);
				if (itemType2 != ItemType.Furniture && itemType3 != ItemType.Clothing && itemType4 != ItemType.Decal && itemType5 != ItemType.Companion)
				{
					return itemType6 == ItemType.Makeup;
				}
				return true;
			}
			return 0 != 15;
		}
	}
}
