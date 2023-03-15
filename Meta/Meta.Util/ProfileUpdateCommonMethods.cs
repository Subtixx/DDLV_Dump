using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;
using Newtonsoft.Json.Linq;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AC2")]
	internal static class ProfileUpdateCommonMethods
	{
		[Cpp2IlInjected.Token(Token = "0x6005D43")]
		[Cpp2IlInjected.Address(RVA = "0x14747C0", Offset = "0x14731C0", VA = "0x1814747C0")]
		internal unsafe static void RemoveItemsInListInventory(JObject profile, uint listInventoryID, IEnumerable<Item> itemsToRemove)
		{
			//Discarded unreachable code: IL_005c, IL_0062
			int num = 0;
			if (!profile.TryGetValue("Player", out *(JToken?*)num) || num == 0)
			{
				return;
			}
			int num2 = 0;
			bool flag = default(bool);
			if (num == 0 || !flag || num == 0)
			{
				return;
			}
			int num3 = 0;
			bool flag2 = default(bool);
			if (num == 0 || !flag2 || num == 0)
			{
				return;
			}
			int num4 = 0;
			bool flag3 = default(bool);
			if (num == 0 || !flag3 || num == 0)
			{
				return;
			}
			int num5 = 0;
			if (num != 0)
			{
				if (num5 != 0)
				{
				}
				num++;
				if (num5 != 0)
				{
				}
				if (num == 0)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D44")]
		[Cpp2IlInjected.Address(RVA = "0x1474160", Offset = "0x1472B60", VA = "0x181474160")]
		internal unsafe static void RemoveItemsInCollections(JObject profile, IEnumerable<Item> itemsToRemove)
		{
			//Discarded unreachable code: IL_00f5, IL_00fb, IL_0101, IL_0107, IL_010d
			bool flag = default(bool);
			IEnumerator<JToken> enumerator = default(IEnumerator<JToken>);
			bool flag2 = default(bool);
			IEnumerator<JToken> enumerator2 = default(IEnumerator<JToken>);
			bool flag3 = default(bool);
			IEnumerable<JProperty> cpp2il__autoParamName__idx_ = default(IEnumerable<JProperty>);
			bool flag4 = default(bool);
			int num10 = default(int);
			while (true)
			{
				int num = 0;
				if (!profile.TryGetValue("Player", out *(JToken?*)num) || num == 0)
				{
					return;
				}
				int num2 = 0;
				if (num == 0 || !flag || num == 0)
				{
					return;
				}
				int num3 = 0;
				if (num == 0)
				{
					return;
				}
				if (enumerator != null)
				{
					while (enumerator == null)
					{
					}
					int num4 = 0;
					while (enumerator == null)
					{
					}
					while (!flag2)
					{
					}
					while (num == 0)
					{
					}
					int num5 = 0;
					while (num == 0)
					{
					}
					if (enumerator2 != null)
					{
						int num6 = 0;
						while (enumerator2 == null)
						{
						}
						int num7 = 0;
						while (enumerator2 == null)
						{
						}
						while (!flag3)
						{
						}
						while (num == 0)
						{
						}
						int num8 = 0;
						while (num == 0)
						{
						}
						JProperty[] array = ((IEnumerable<>)cpp2il__autoParamName__idx_).ToArray<JProperty>();
						while (num >= array.Length)
						{
						}
						JProperty jProperty = array[num];
						if (int.TryParse(jProperty._name, out *(int*)num))
						{
							long num9 = Convert.ToInt64((uint)num);
							if (flag4)
							{
								string name = jProperty._name;
							}
						}
						num++;
					}
					num++;
					if (enumerator2 != null)
					{
					}
					if (num != 0)
					{
						break;
					}
					while (num == 0)
					{
					}
				}
				num10++;
				if (enumerator != null)
				{
				}
				if (num == 0)
				{
					if (num10 == 0)
					{
					}
					return;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D45")]
		[Cpp2IlInjected.Address(RVA = "0x1474C20", Offset = "0x1473620", VA = "0x181474C20")]
		internal unsafe static void RemoveTrimmingItems(Profile profile, Item[] trimmingsToRemove)
		{
			//Discarded unreachable code: IL_0162, IL_0168, IL_016e, IL_0174, IL_017a, IL_0180, IL_0186, IL_0192, IL_0198
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Dictionary<(Item, ItemState), int>.KeyCollection keys = (Dictionary<(Item, ItemState), int>.KeyCollection)(object)((Dictionary<TKey, TValue>)(object)profile.player_.Trimming.GetAllItems()).get_Keys();
			Func<(Item, ItemState), Item> _003C_003E9__2_ = _003C_003Ec._003C_003E9__2_0;
			if (_003C_003E9__2_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			Item[] array = Enumerable.Except<Item>(Enumerable.Select<(Item, ItemState), Item>((IEnumerable<>)(object)keys, (Func<, >)(object)_003C_003E9__2_), (IEnumerable<>)(object)trimmingsToRemove).ToArray<Item>();
			Array values = Enum.GetValues(typeof(House.Types.WallPosition));
			if (values == null)
			{
			}
			if (values != null)
			{
				if (num >= trimmingsToRemove.Length)
				{
					return;
				}
				Item item = trimmingsToRemove[num];
				if (profile.player_.Trimming.TryGetInventoryData(item, out *(ListInventory.Types.Data*)num))
				{
					MapField<int, ListInventory.Types.Data> inventory_ = profile.player_.Trimming.inventory_;
					RepeatedField<House.Types.Floor> floors_ = profile.world_.playerHouse_.floors_;
					bool flag = default(bool);
					if (flag)
					{
						ICollection<> collection = default(ICollection<>);
						if (collection != null)
						{
							if (collection == null)
							{
								bool flag2 = default(bool);
								if (flag2 && flag2)
								{
									Func<Item, bool> func = default(Func<Item, bool>);
									if (_003C_003Ec._003C_003E9__2_2 == null)
									{
										bool flag4 = default(bool);
										TrimmingItemType trimmingItemType2 = default(TrimmingItemType);
										func = (Func<Item, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Item x) => (!flag4) ? flag4 : (trimmingItemType2 == TrimmingItemType.Wallpaper)));
									}
									int itemID = Enumerable.First<Item>((IEnumerable<>)(object)array, (Func<, >)(object)func).ItemID;
									Item item2 = default(Item);
									int itemID2 = item2.ItemID;
								}
								num++;
							}
							Func<Item, bool> func2 = default(Func<Item, bool>);
							if (_003C_003Ec._003C_003E9__2_1 == null)
							{
								bool flag3 = default(bool);
								TrimmingItemType trimmingItemType = default(TrimmingItemType);
								func2 = (Func<Item, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Item x) => (!flag3) ? flag3 : (trimmingItemType == TrimmingItemType.Flooring)));
							}
							int itemID3 = Enumerable.First<Item>((IEnumerable<>)(object)array, (Func<, >)(object)func2).ItemID;
						}
						if (collection != null)
						{
						}
						if (num != 0)
						{
							throw new NullReferenceException();
						}
					}
					if (num != 0)
					{
						goto IL_019e;
					}
				}
				num++;
				return;
			}
			goto IL_019e;
			IL_019e:
			throw new InvalidCastException();
		}
	}
}
