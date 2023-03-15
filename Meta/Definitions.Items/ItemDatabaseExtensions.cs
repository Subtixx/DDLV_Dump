using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Gameloft.Localization.Core;
using Meta;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class ItemDatabaseExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x19ADE90", Offset = "0x19AC890", VA = "0x1819ADE90")]
		public static IEnumerable<> GetOwnedItems<T>(this ItemDatabase P_0, ListInventory P_1, ItemType P_2) where T : class, IItemData
		{
			Func<KeyValuePair<int, ListInventory.Types.Data>, bool> func = default(Func<KeyValuePair<int, ListInventory.Types.Data>, bool>);
			if (P_1.compatibleItemType_ == P_2)
			{
				return Enumerable.Where<KeyValuePair<int, ListInventory.Types.Data>>((IEnumerable<>)(object)P_1.inventory_, (Func<, >)(object)func);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x19ADDD0", Offset = "0x19AC7D0", VA = "0x1819ADDD0")]
		[IteratorStateMachine(typeof(_003CGetOwnedItemsWithTags_003Ed__1<>))]
		public static IEnumerable<> GetOwnedItemsWithTags<T>(this ItemDatabase P_0, ListInventory P_1, ItemType P_2, IEnumerable<> P_3) where T : class, IItemData, IHasTags
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1711F50", Offset = "0x1710950", VA = "0x181711F50")]
		public static IEnumerable<FurnitureItemData> GetOwnedFurnitures(this ItemDatabase itemDatabase, ListInventory catalog)
		{
			return (IEnumerable<FurnitureItemData>)itemDatabase.GetOwnedFurnitures<FurnitureItemData>(catalog);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x19ADDB0", Offset = "0x19AC7B0", VA = "0x1819ADDB0")]
		public static IEnumerable<> GetOwnedFurnitures<T>(this ItemDatabase cpp2il__autoParamName__idx_0, ListInventory cpp2il__autoParamName__idx_1) where T : class, IItemData
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1711EE0", Offset = "0x17108E0", VA = "0x181711EE0")]
		public static IEnumerable<FurnitureItemData> GetOwnedFurnituresWithTags(this ItemDatabase itemDatabase, ListInventory catalog, IEnumerable<Item> tags)
		{
			return (IEnumerable<FurnitureItemData>)itemDatabase.GetOwnedItemsWithTags<FurnitureItemData>(catalog, ItemType.Furniture, (IEnumerable<>)tags);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1711FF0", Offset = "0x17109F0", VA = "0x181711FF0")]
		public static IEnumerable<TrimmingItemData> GetOwnedTrimmings(this ItemDatabase itemDatabase, ListInventory trimmings)
		{
			return (IEnumerable<TrimmingItemData>)itemDatabase.GetOwnedItems<TrimmingItemData>(trimmings, ItemType.Trimming);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1711E90", Offset = "0x1710890", VA = "0x181711E90")]
		public static IEnumerable<ClothingItemData> GetOwnedClothes(this ItemDatabase itemDatabase, ListInventory wardrobe)
		{
			return (IEnumerable<ClothingItemData>)itemDatabase.GetOwnedItems<ClothingItemData>(wardrobe, ItemType.Clothing);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1711E20", Offset = "0x1710820", VA = "0x181711E20")]
		public static IEnumerable<ClothingItemData> GetOwnedClothesWithTags(this ItemDatabase itemDatabase, ListInventory wardrobe, IEnumerable<Item> tags)
		{
			return (IEnumerable<ClothingItemData>)itemDatabase.GetOwnedItemsWithTags<ClothingItemData>(wardrobe, ItemType.Clothing, (IEnumerable<>)tags);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1711FA0", Offset = "0x17109A0", VA = "0x181711FA0")]
		public static IEnumerable<MakeupItemData> GetOwnedMakeup(this ItemDatabase itemDatabase, ListInventory makeupInventory)
		{
			return (IEnumerable<MakeupItemData>)itemDatabase.GetOwnedItems<MakeupItemData>(makeupInventory, ItemType.Makeup);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1711940", Offset = "0x1710340", VA = "0x181711940")]
		private static string ApplyStyle(IItemData data, string str)
		{
			//Discarded unreachable code: IL_0028
			int num = 0;
			ItemNameSettings instance = ItemNameSettings.Instance;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			ItemNameTagCondition itemNameTagCondition = default(ItemNameTagCondition);
			if (itemNameTagCondition == null || itemNameTagCondition.AddTag(str) == null)
			{
			}
			return str;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1711A60", Offset = "0x1710460", VA = "0x181711A60")]
		public static string GetLocalizedDisplayName(this IItemData data, Localizator localizator, bool useXml = true)
		{
			//Discarded unreachable code: IL_005f
			//IL_003f: Expected O, but got I4
			int num = 0;
			if (data != null)
			{
				if (data != null)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				}
				if (data == null)
				{
				}
			}
			if (num == 0 && localizator != null && useXml)
			{
				int num2 = 0;
				ItemNameSettings instance = ItemNameSettings.Instance;
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				ItemNameTagCondition itemNameStyle = instance.GetItemNameStyle((Item)num);
				string str = default(string);
				if (itemNameStyle == null || itemNameStyle.AddTag(str) == null)
				{
					itemNameStyle = (ItemNameTagCondition)(object)((object)itemNameStyle + (object)itemNameStyle);
				}
			}
			return "";
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1711D30", Offset = "0x1710730", VA = "0x181711D30")]
		public static string GetLocalizedDisplayName(this Item item, Localizator localizator, bool useXml = true)
		{
			//Discarded unreachable code: IL_000f
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData data = default(IItemData);
			return data.GetLocalizedDisplayName(localizator, useXml);
		}
	}
}
