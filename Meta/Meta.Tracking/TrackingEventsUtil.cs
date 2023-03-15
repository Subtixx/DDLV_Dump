using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A82")]
	public static class TrackingEventsUtil
	{
		[Cpp2IlInjected.Token(Token = "0x6005AF1")]
		[Cpp2IlInjected.Address(RVA = "0x78CBC0", Offset = "0x78B5C0", VA = "0x18078CBC0")]
		public static TrackingItem BuildItemProduct(IItemData itemData, int amount)
		{
			//Discarded unreachable code: IL_0023, IL_0036, IL_0049, IL_0093, IL_0098, IL_00a2, IL_00a9, IL_012d, IL_0133, IL_0139, IL_013f, IL_0145, IL_014b
			//IL_00c6: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			if (false)
			{
			}
			Dictionary<string, string> dictionary = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();
			if (dictionary != null)
			{
				string text = dictionary.ToString();
				Dictionary<string, string> dictionary2 = dictionary;
				throw new NullReferenceException();
			}
			Dictionary<TagItemType, string> dictionary3 = (Dictionary<TagItemType, string>)(object)new Dictionary<TKey, TValue>();
			if (dictionary3 != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				bool flag = default(bool);
				if (flag)
				{
					string text2 = default(string);
					string text3 = text2.Replace("DisplayName", "");
					throw new NullReferenceException();
				}
			}
			ItemType itemType = default(ItemType);
			string text4 = ((Enum)itemType).ToString();
			ItemType itemType2 = itemType;
			ItemType itemType3 = default(ItemType);
			string text6 = default(string);
			if (itemType3 == ItemType.ActivityItem)
			{
				string text5 = default(string);
				uint value = default(uint);
				int num4 = text5.LastIndexOf((char)value);
				uint value2 = default(uint);
				int length = text5.LastIndexOf((char)value2);
				int startIndex = 0;
				text6 = text5.Substring(startIndex, length);
			}
			TrackingItem trackingItem = default(TrackingItem);
			trackingItem.itemAmount = 0;
			trackingItem.itemName = text6;
			trackingItem.itemType = text6;
			uint itemRarity = default(uint);
			trackingItem.itemRarity = (int)itemRarity;
			trackingItem.ItemTraits = dictionary;
			trackingItem.ItemTags = dictionary3;
			return trackingItem;
		}
	}
}
