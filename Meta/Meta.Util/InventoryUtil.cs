using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Meta.Customization;
using Meta.Grids;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000ABB")]
	public static class InventoryUtil
	{
		[Cpp2IlInjected.Token(Token = "0x6005D19")]
		[Cpp2IlInjected.Address(RVA = "0x170F390", Offset = "0x170DD90", VA = "0x18170F390")]
		public static Dictionary<Item, int> ExtractItems(GridCollection grids)
		{
			//Discarded unreachable code: IL_001f, IL_0023, IL_0029, IL_0039, IL_003f, IL_0045, IL_004b, IL_0051, IL_0057
			Dictionary<Item, int> result = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			if (grids != null)
			{
				IEnumerable<IGrid> allGrids = (IEnumerable<IGrid>)grids.get_AllGrids();
				if (allGrids != null)
				{
					if (allGrids != null)
					{
						throw new NullReferenceException();
					}
					if (allGrids == null)
					{
					}
				}
				if (allGrids == null)
				{
				}
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D1A")]
		[Cpp2IlInjected.Address(RVA = "0x170F150", Offset = "0x170DB50", VA = "0x18170F150")]
		public static Dictionary<Item, int> ExtractClothes(IAvatar avatar)
		{
			//Discarded unreachable code: IL_0030, IL_0036
			int num = 0;
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			if (avatar != null)
			{
				if (dictionary != null)
				{
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						if (num == (int)num2)
						{
							dictionary = (Dictionary<Item, int>)(object)((object)dictionary + (object)dictionary);
							goto IL_002a;
						}
						num++;
					}
					throw new NullReferenceException();
				}
				goto IL_002a;
			}
			goto IL_002e;
			IL_002e:
			return dictionary;
			IL_002a:
			if (dictionary == null)
			{
			}
			goto IL_002e;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D1B")]
		[Cpp2IlInjected.Address(RVA = "0x170F690", Offset = "0x170E090", VA = "0x18170F690")]
		public static Dictionary<Item, int> ExtractMakeup(IAvatar avatar)
		{
			//Discarded unreachable code: IL_0037, IL_003d, IL_0043
			int num = 0;
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			if (avatar != null)
			{
				if (dictionary != null)
				{
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						if (num == (int)num2)
						{
							dictionary = (Dictionary<Item, int>)(object)((object)dictionary + (object)dictionary);
							goto IL_0031;
						}
						num++;
					}
					Dictionary<, >.Entry[] entries = (Dictionary<, >.Entry[])(object)((Dictionary<, >)(object)dictionary).entries;
					throw new NullReferenceException();
				}
				goto IL_0031;
			}
			goto IL_0035;
			IL_0035:
			return dictionary;
			IL_0031:
			if (dictionary == null)
			{
			}
			goto IL_0035;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D1C")]
		[Cpp2IlInjected.Address(RVA = "0x170F900", Offset = "0x170E300", VA = "0x18170F900")]
		public static bool FurnituresAreOwned(GridCollection grids, ProfilePlayer profilePlayer, GridCollection defaultGrids)
		{
			//Discarded unreachable code: IL_001f, IL_0035, IL_003b
			int num = 0;
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)InventoryUtil.ExtractItems(grids);
			if (defaultGrids != null)
			{
				Dictionary<Item, int> dictionary2 = (Dictionary<Item, int>)(object)InventoryUtil.ExtractItems(defaultGrids);
				bool flag = default(bool);
				if (flag)
				{
					throw new NullReferenceException();
				}
			}
			ListInventory catalog = profilePlayer.Catalog;
			return InventoryUtil.ItemsAreInInventory((Dictionary<, >)(object)dictionary, catalog);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D1D")]
		[Cpp2IlInjected.Address(RVA = "0x170F100", Offset = "0x170DB00", VA = "0x18170F100")]
		public static bool ClothesAreOwned(IAvatar avatar, ProfilePlayer profilePlayer)
		{
			//Discarded unreachable code: IL_0016
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)InventoryUtil.ExtractClothes(avatar);
			ListInventory wardrobe = profilePlayer.Wardrobe;
			return InventoryUtil.ItemsAreInInventory((Dictionary<, >)(object)dictionary, wardrobe);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D1E")]
		[Cpp2IlInjected.Address(RVA = "0x170FF30", Offset = "0x170E930", VA = "0x18170FF30")]
		public static bool MakeupIsOwned(IAvatar avatar, ProfilePlayer profilePlayer)
		{
			//Discarded unreachable code: IL_0016
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)InventoryUtil.ExtractMakeup(avatar);
			ListInventory makeup = profilePlayer.Makeup;
			return InventoryUtil.ItemsAreInInventory((Dictionary<, >)(object)dictionary, makeup);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D1F")]
		[Cpp2IlInjected.Address(RVA = "0x170FD90", Offset = "0x170E790", VA = "0x18170FD90")]
		public static bool ItemsAreInInventory(Dictionary<Item, int> items, ListInventory inventory)
		{
			//Discarded unreachable code: IL_0022
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (flag2)
				{
				}
				int num3 = 0;
				num2++;
			}
			if (num2 + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D20")]
		[Cpp2IlInjected.Address(RVA = "0x170FF80", Offset = "0x170E980", VA = "0x18170FF80")]
		public static Dictionary<Item, int> MissingFromInventory(GridCollection grids, Profile profile)
		{
			//Discarded unreachable code: IL_0016
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)InventoryUtil.ExtractItems(grids);
			ListInventory catalog = profile.Catalog;
			return (Dictionary<Item, int>)(object)InventoryUtil.MissingFromInventory((Dictionary<, >)(object)dictionary, catalog);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D21")]
		[Cpp2IlInjected.Address(RVA = "0x17101A0", Offset = "0x170EBA0", VA = "0x1817101A0")]
		public static Dictionary<Item, int> MissingFromInventory(IAvatar avatar, Profile profile)
		{
			//Discarded unreachable code: IL_0016
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)InventoryUtil.ExtractClothes(avatar);
			ListInventory wardrobe = profile.Wardrobe;
			return (Dictionary<Item, int>)(object)InventoryUtil.MissingFromInventory((Dictionary<, >)(object)dictionary, wardrobe);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D22")]
		[Cpp2IlInjected.Address(RVA = "0x170FFD0", Offset = "0x170E9D0", VA = "0x18170FFD0")]
		public static Dictionary<Item, int> MissingFromInventory(Dictionary<Item, int> items, ListInventory inventory)
		{
			//Discarded unreachable code: IL_0019, IL_001f, IL_0025, IL_002b
			int num = 0;
			Dictionary<Item, int> result = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				if (flag2)
				{
				}
				throw new NullReferenceException();
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D23")]
		[Cpp2IlInjected.Address(RVA = "0x170FB00", Offset = "0x170E500", VA = "0x18170FB00")]
		public unsafe static Dictionary<Item, int> GetTotalPrice(Dictionary<Item, int> items)
		{
			//Discarded unreachable code: IL_001e, IL_0023, IL_0029, IL_003a, IL_0040, IL_0046
			//IL_0030: Expected O, but got I4
			//IL_0032: Expected I4, but got O
			Dictionary<Item, int> result;
			bool flag = default(bool);
			IGenericBuyable genericBuyable = default(IGenericBuyable);
			while (true)
			{
				int num = 0;
				result = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
				if (!flag)
				{
					break;
				}
				if (genericBuyable.TryGetPrice(out *(int*)num, out *(Item*)num))
				{
					throw new NullReferenceException();
				}
			}
			return result;
		}
	}
}
