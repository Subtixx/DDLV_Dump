using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Meta;
using Meta.Missions;

namespace Definitions.Store
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class DeliverySystemExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1A27D70", Offset = "0x1A26770", VA = "0x181A27D70")]
		public unsafe static List<Item> GetClothingItemsInDeliverySystem(this StoreData storeData, Profile profile)
		{
			//Discarded unreachable code: IL_00d5, IL_00db, IL_00e1, IL_00e7, IL_00ed, IL_00f3, IL_00f9, IL_00ff, IL_0105, IL_010b, IL_0111
			//IL_00b1: Expected O, but got I4
			HashSet<Item> hashSet;
			bool flag = default(bool);
			IEnumerable<ProfileWorld.FilterInfo> enumerable = default(IEnumerable<ProfileWorld.FilterInfo>);
			uint num3 = default(uint);
			long num4 = default(long);
			ItemFilterData itemFilterData = default(ItemFilterData);
			bool flag2 = default(bool);
			ItemType itemType = default(ItemType);
			ItemFilterData itemFilterData2 = default(ItemFilterData);
			ItemFilterData itemFilterData3 = default(ItemFilterData);
			Func<int, bool> func = default(Func<int, bool>);
			ItemType itemType2 = default(ItemType);
			int num5 = default(int);
			while (true)
			{
				int num = 0;
				hashSet = (HashSet<Item>)(object)new HashSet<T>();
				RepeatedField<int> clothingsToDisplay_ = storeData.clothingsToDisplay_;
				if (flag && profile.Player != null)
				{
					continue;
				}
				int num2 = 0;
				if (enumerable == null)
				{
					break;
				}
				if (num2 < (int)num3)
				{
					num2 += num2;
					if (num2 == (int)num3)
					{
						goto IL_0059;
					}
					num2++;
				}
				num4 = Convert.ToInt64((uint)itemFilterData.item_);
				if (flag2 && itemType == ItemType.Clothing)
				{
					goto IL_0059;
				}
				goto IL_0060;
				IL_0060:
				if (!Enumerable.Any<int>((IEnumerable<>)(object)itemFilterData2.itemList_))
				{
					continue;
				}
				RepeatedField<int> itemList_ = itemFilterData3.itemList_;
				if (_003C_003Ec._003C_003E9__0_0 == null)
				{
					func = (Func<int, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int x) => itemType2 == ItemType.Clothing));
				}
				IEnumerable<int> enumerable2 = (IEnumerable<int>)Enumerable.Where<int>((IEnumerable<>)(object)itemList_, (Func<, >)(object)func);
				Func<int, Item> func2 = (Func<int, Item>)(object)new Func<T, TResult>(num5, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<int, Item>*/)(&Item.New));
				num5 = 0;
				IEnumerable<int> enumerable3 = (IEnumerable<int>)Enumerable.Select<int, Item>((IEnumerable<>)enumerable2, (Func<, >)(object)func2);
				((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)enumerable3);
				break;
				IL_0059:
				num4 += num4;
				goto IL_0060;
			}
			if (enumerable != null)
			{
			}
			return (List<Item>)(object)Enumerable.ToList<Item>((IEnumerable<>)hashSet);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1A283A0", Offset = "0x1A26DA0", VA = "0x181A283A0")]
		public static List<(Item, int?)> GetFurnitureItemsInDeliverySystem(this StoreData storeData, Profile profile)
		{
			//Discarded unreachable code: IL_0122, IL_0128, IL_012e, IL_0134, IL_013a
			List<(Item, int?)> result;
			bool flag = default(bool);
			Func<CraftingRecipeItemData, Item> func = default(Func<CraftingRecipeItemData, Item>);
			IEnumerable<> enumerable = default(IEnumerable<>);
			ListInventory listInventory = default(ListInventory);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			Func<ProfileWorld.FilterInfo, IEnumerable<MissionObjective>> func2 = default(Func<ProfileWorld.FilterInfo, IEnumerable<MissionObjective>>);
			IEnumerable<ProfileWorld.FilterInfo> enumerable2 = default(IEnumerable<ProfileWorld.FilterInfo>);
			bool flag4 = default(bool);
			ItemType itemType = default(ItemType);
			bool flag5 = default(bool);
			bool flag6 = default(bool);
			ItemType itemType2 = default(ItemType);
			while (true)
			{
				int num = 0;
				HashSet<Item> hashSet = (HashSet<Item>)(object)new HashSet<T>();
				result = (List<(Item, int?)>)(object)new List<T>();
				RepeatedField<int> furnituresToDisplay_ = storeData.furnituresToDisplay_;
				if (flag)
				{
				}
				if (_003C_003Ec._003C_003E9__1_0 == null)
				{
					func = (Func<CraftingRecipeItemData, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CraftingRecipeItemData x) => x.result_.Item));
				}
				HashSet<CraftingRecipeItemData> hashSet2 = (HashSet<CraftingRecipeItemData>)(object)MoreLinq.ToHashSet<Item>(Enumerable.Select<CraftingRecipeItemData, Item>(enumerable, (Func<, >)(object)func));
				ICollection<int> keys = (ICollection<int>)((MapField<TKey, TValue>)(object)listInventory.inventory_).get_Keys();
				if (keys != null)
				{
					if (flag2)
					{
						while (flag2)
						{
						}
					}
					while (flag3)
					{
					}
				}
				int num2 = 0;
				if (keys != null)
				{
					int num3 = 0;
				}
				if (_003C_003Ec._003C_003E9__1_1 == null)
				{
					func2 = (Func<ProfileWorld.FilterInfo, IEnumerable<MissionObjective>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ProfileWorld.FilterInfo x)
					{
						List<MissionObjective> _003CObjectives_003Ek__BackingField = x.Objectives;
						throw new NullReferenceException();
					});
				}
				MissionObjective[] array = Enumerable.SelectMany<ProfileWorld.FilterInfo, MissionObjective>((IEnumerable<>)enumerable2, (Func<, >)(object)func2).ToArray<MissionObjective>();
				if (num2 >= array.Length)
				{
					break;
				}
				MissionObjective missionObjective = array[num2];
				int item_ = missionObjective.itemFilter_.data_.item_;
				if (flag4 && itemType == ItemType.Furniture)
				{
					num2++;
				}
				if (!Enumerable.Any<int>((IEnumerable<>)(object)missionObjective.itemFilter_.data_.itemList_))
				{
					continue;
				}
				RepeatedField<int> itemList_ = missionObjective.itemFilter_.data_.itemList_;
				if (flag5)
				{
					while (!flag6)
					{
					}
					while (itemType2 != ItemType.Furniture)
					{
					}
				}
				break;
			}
			return result;
		}
	}
}
