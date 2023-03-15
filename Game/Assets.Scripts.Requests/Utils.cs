using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Meta;
using NodeCanvas.Framework;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	public class Utils
	{
		[Cpp2IlInjected.Token(Token = "0x2000161")]
		public class ItemFilters
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000611")]
			public BBParameter<Item> Item = (BBParameter<Item>)(object)new BBParameter<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000612")]
			public BBParameter<ItemType> ItemType = (BBParameter<ItemType>)(object)new BBParameter<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000613")]
			public BBParameter<Item> ItemSet = (BBParameter<Item>)(object)new BBParameter<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000614")]
			public BBParameter<Complexity> Complexity = (BBParameter<Complexity>)(object)new BBParameter<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000615")]
			public BBParameter<Mood> Mood = (BBParameter<Mood>)(object)new BBParameter<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000616")]
			public BBParameter<Sturdiness> Sturdiness = (BBParameter<Sturdiness>)(object)new BBParameter<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000617")]
			public BBParameter<Normality> Normality = (BBParameter<Normality>)(object)new BBParameter<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000618")]
			public BBParameter<List<Item>> Tags = (BBParameter<List<Item>>)(object)new BBParameter<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			public BBParameter<int> MinRarity = (BBParameter<int>)(object)new BBParameter<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400061A")]
			public BBParameter<ClothingItemType> Clothing = (BBParameter<ClothingItemType>)(object)new BBParameter<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400061B")]
			public BBParameter<FurnitureItemType> Furniture = (BBParameter<FurnitureItemType>)(object)new BBParameter<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400061C")]
			public BBParameter<ActivityItemType> ActivityItem = (BBParameter<ActivityItemType>)(object)new BBParameter<T>();

			[Cpp2IlInjected.Token(Token = "0x60006B0")]
			[Cpp2IlInjected.Address(RVA = "0xF87380", Offset = "0xF85D80", VA = "0x180F87380")]
			public ItemFilters()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0xD3FC00", Offset = "0xD3E600", VA = "0x180D3FC00")]
		public unsafe static int GetItemsQuantity(object target, Dictionary<Item, int> itemList)
		{
			//Discarded unreachable code: IL_004b, IL_0053, IL_0316
			//IL_0024: Expected O, but got I4
			//IL_0107: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			Func<KeyValuePair<Item, int>, Item> func = default(Func<KeyValuePair<Item, int>, Item>);
			FieldInfo fieldInfo = default(FieldInfo);
			ItemType itemType = default(ItemType);
			Func<Item, bool> func2 = default(Func<Item, bool>);
			ItemType itemType4 = default(ItemType);
			List<Item> list2 = default(List<Item>);
			ItemDatabase.ItemTypeMetaInfo metaInfo = default(ItemDatabase.ItemTypeMetaInfo);
			FieldInfo fieldInfo2 = default(FieldInfo);
			bool flag3 = default(bool);
			List<Item> list3 = default(List<Item>);
			FieldInfo fieldInfo3 = default(FieldInfo);
			FieldInfo fieldInfo4 = default(FieldInfo);
			FieldInfo fieldInfo5 = default(FieldInfo);
			FieldInfo fieldInfo6 = default(FieldInfo);
			FieldInfo fieldInfo7 = default(FieldInfo);
			FieldInfo fieldInfo8 = default(FieldInfo);
			FieldInfo fieldInfo9 = default(FieldInfo);
			bool flag4 = default(bool);
			int num14 = default(int);
			while (true)
			{
				int num = 0;
				_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
				FieldInfo field = target.GetType().GetField("Item", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				int num2 = 0;
				if (field != (FieldInfo)num2)
				{
					object value = field.GetValue(target);
					int num3 = 0;
					if (value == null)
					{
						throw new InvalidCastException();
					}
					if (!flag && flag2)
					{
						throw new NullReferenceException();
					}
				}
				if (_003C_003Ec._003C_003E9__1_0 == null)
				{
					func = (Func<KeyValuePair<Item, int>, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<Item, int> x) => (Item)((KeyValuePair<, >*)(&x))->key));
				}
				List<Item> list = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<KeyValuePair<Item, int>, Item>((IEnumerable<>)itemList, (Func<, >)(object)func));
				Type type = target.GetType();
				CS_0024_003C_003E8__locals0.itemType = (ItemType)num;
				if ((object)fieldInfo != null)
				{
					object value2 = fieldInfo.GetValue(target);
					int num4 = 0;
					if (value2 != null)
					{
						int num5 = 0;
						if (value2 != null)
						{
							CS_0024_003C_003E8__locals0.itemType = itemType;
							func2 = (Func<Item, bool>)(object)(Func<T, TResult>)((Item x) => itemType4 == CS_0024_003C_003E8__locals0.itemType);
							list2 = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Where<Item>((IEnumerable<>)list, (Func<, >)(object)func2));
							goto IL_00e0;
						}
					}
					throw new InvalidCastException();
				}
				goto IL_00e0;
				IL_00e0:
				if (func2 != null)
				{
					CS_0024_003C_003E8__locals0.metaInfo = metaInfo;
					Type type2 = target.GetType();
					ItemType itemType2 = CS_0024_003C_003E8__locals0.itemType;
					string text = ((Enum)itemType2).ToString();
					ItemType itemType3 = (CS_0024_003C_003E8__locals0.itemType = itemType2);
					if ((object)fieldInfo2 != null)
					{
						object value3 = fieldInfo2.GetValue(target);
						int num6 = 0;
						if (value3 == null)
						{
							throw new InvalidCastException();
						}
						if (!flag3)
						{
							_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = CS_0024_003C_003E8__locals0;
							object subType = value3.GetType().GetProperty("value", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue(value3);
							Func<Item, bool> func3 = (Func<Item, bool>)(object)(Func<T, TResult>)delegate
							{
								//Discarded unreachable code: IL_004d
								//IL_0028: Expected O, but got I4
								Type _003CSubItemType_003Ek__BackingField;
								object[] array;
								int num18 = default(int);
								do
								{
									_003CSubItemType_003Ek__BackingField = _003C_003Ec__DisplayClass1_.metaInfo.SubItemType;
									array = new object[1];
								}
								while (num18 != 0 && num18 == 0);
								array[0] = num18;
								PropertyInfo property = Activator.CreateInstance(_003CSubItemType_003Ek__BackingField, array).GetType().GetProperty("Type");
								object objB = default(object);
								return object.Equals(subType, objB);
							};
							list3 = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Where<Item>((IEnumerable<>)list2, (Func<, >)(object)func3));
						}
					}
					if ((long)list3 == 5 || (long)list3 == 4)
					{
						_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_2 = CS_0024_003C_003E8__locals0;
						Type type3 = target.GetType();
						object value4 = fieldInfo3.GetValue(target);
						if (value4 == null)
						{
						}
						int num7 = 0;
						if (value4 == null)
						{
							continue;
						}
						BBParameter<Item> itemItemSet = (BBParameter<Item>)value4;
						Type type4 = target.GetType();
						object value5 = fieldInfo4.GetValue(target);
						if (value5 == null)
						{
						}
						int num8 = 0;
						if (value5 == null)
						{
							continue;
						}
						BBParameter<Complexity> itemComplexity = (BBParameter<Complexity>)value5;
						Type type5 = target.GetType();
						object value6 = fieldInfo5.GetValue(target);
						if (value6 == null)
						{
						}
						int num9 = 0;
						if (value6 == null)
						{
							break;
						}
						BBParameter<Mood> itemMood = (BBParameter<Mood>)value6;
						Type type6 = target.GetType();
						object value7 = fieldInfo6.GetValue(target);
						if (value7 == null)
						{
						}
						int num10 = 0;
						if (value7 == null)
						{
							break;
						}
						BBParameter<Sturdiness> itemSturdiness = (BBParameter<Sturdiness>)value7;
						Type type7 = target.GetType();
						object value8 = fieldInfo7.GetValue(target);
						if (value8 == null)
						{
						}
						int num11 = 0;
						if (value8 == null)
						{
							break;
						}
						BBParameter<Normality> itemNormality = (BBParameter<Normality>)value8;
						Type type8 = target.GetType();
						object value9 = fieldInfo8.GetValue(target);
						if (value9 == null)
						{
						}
						int num12 = 0;
						if (value9 == null)
						{
							break;
						}
						BBParameter<List<Item>> itemTags = (BBParameter<List<Item>>)value9;
						Type type9 = target.GetType();
						object value10 = fieldInfo9.GetValue(target);
						if (value10 == null)
						{
						}
						int num13 = 0;
						if (value10 == null)
						{
							break;
						}
						BBParameter<int> itemMinRarity = (BBParameter<int>)value10;
						Func<Item, bool> func4 = (Func<Item, bool>)(object)(Func<T, TResult>)delegate
						{
							//IL_0246: Expected I4, but got O
							//IL_0261: Expected I4, but got O
							//IL_0299: Expected I4, but got O
							//IL_02b4: Expected I4, but got O
							int num15 = 0;
							HashSet<Item> hashSet = (HashSet<Item>)(object)new HashSet<T>();
							if (_003C_003Ec__DisplayClass1_2.itemType == ItemType.Clothing)
							{
								ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
								ClothingItemData clothingItemData = default(ClothingItemData);
								if (clothingItemData != null)
								{
									int setItemID = clothingItemData.SetItemID;
									Complexity complexity_ = clothingItemData.complexity_;
									RepeatedField<int> tags_ = clothingItemData.tags_;
									Mood mood_ = clothingItemData.mood_;
									Normality normality_ = clothingItemData.normality_;
									int rarity_ = clothingItemData.rarity_;
									Func<int, Item> _003C_003E9__1_ = _003C_003Ec._003C_003E9__1_4;
									if (_003C_003E9__1_ == null)
									{
										_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
										{
											throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
										};
									}
									List<Item> list5 = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<int, Item>((IEnumerable<>)(object)tags_, (Func<, >)(object)_003C_003E9__1_));
									((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)list5);
									int setItemID2 = clothingItemData.SetItemID;
									int setItemID3 = clothingItemData.SetItemID;
									bool flag5 = default(bool);
									if (flag5)
									{
										ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
										int setItemID4 = clothingItemData.SetItemID;
										SetItemData setItemData = default(SetItemData);
										if (setItemData != null)
										{
											RepeatedField<int> tags_2 = setItemData.tags_;
											Func<int, Item> func5 = default(Func<int, Item>);
											if (_003C_003Ec._003C_003E9__1_5 == null)
											{
												func5 = (Func<int, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
												{
													throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
												});
											}
											List<Item> list6 = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<int, Item>((IEnumerable<>)(object)tags_2, (Func<, >)(object)func5));
											((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)list6);
										}
									}
								}
							}
							int setItemID5 = default(int);
							Sturdiness sturdiness_ = default(Sturdiness);
							if (_003C_003Ec__DisplayClass1_2.itemType == ItemType.Furniture)
							{
								ItemDatabase _003CInstance_003Ek__BackingField3 = ItemDatabase.Instance;
								FurnitureItemData furnitureItemData = default(FurnitureItemData);
								if (furnitureItemData != null)
								{
									setItemID5 = furnitureItemData.SetItemID;
									Complexity complexity_2 = furnitureItemData.complexity_;
									sturdiness_ = furnitureItemData.sturdiness_;
									RepeatedField<int> tags_3 = furnitureItemData.tags_;
									Mood mood_2 = furnitureItemData.mood_;
									Normality normality_2 = furnitureItemData.normality_;
									int rarity_2 = furnitureItemData.rarity_;
									Func<int, Item> func6 = default(Func<int, Item>);
									if (_003C_003Ec._003C_003E9__1_6 == null)
									{
										func6 = (Func<int, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
										{
											throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
										});
									}
									List<Item> list7 = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<int, Item>((IEnumerable<>)(object)tags_3, (Func<, >)(object)func6));
									((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)list7);
									int setItemID6 = furnitureItemData.SetItemID;
									int setItemID7 = furnitureItemData.SetItemID;
									bool flag6 = default(bool);
									if (flag6)
									{
										ItemDatabase _003CInstance_003Ek__BackingField4 = ItemDatabase.Instance;
										int setItemID8 = furnitureItemData.SetItemID;
										SetItemData setItemData2 = default(SetItemData);
										if (setItemData2 != null)
										{
											RepeatedField<int> tags_4 = setItemData2.tags_;
											Func<int, Item> func7 = default(Func<int, Item>);
											if (_003C_003Ec._003C_003E9__1_7 == null)
											{
												func7 = (Func<int, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
												{
													throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
												});
											}
											List<Item> list8 = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<int, Item>((IEnumerable<>)(object)tags_4, (Func<, >)(object)func7));
											((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)list8);
										}
									}
								}
							}
							if (itemItemSet.isNone || (IntPtr)((BBParameter<T>)(object)itemItemSet).value == (IntPtr)setItemID5)
							{
								if (!itemComplexity.isNone)
								{
									Complexity complexity = (Complexity)((BBParameter<T>)(object)itemComplexity).value;
								}
								if (!itemMood.isNone)
								{
									Mood mood = (Mood)((BBParameter<T>)(object)itemMood).value;
								}
								if (itemSturdiness.isNone || (IntPtr)((BBParameter<T>)(object)itemSturdiness).value == (IntPtr)(void*)(int)sturdiness_)
								{
									if (!itemNormality.isNone)
									{
										Normality normality = (Normality)((BBParameter<T>)(object)itemNormality).value;
									}
									if (!itemMinRarity.isNone)
									{
										int num16 = (int)((BBParameter<T>)(object)itemMinRarity).value;
									}
									if (itemTags.isNone)
									{
										goto IL_02f3;
									}
									HashSet<Item> hashSet2 = (HashSet<Item>)(object)new HashSet<T>();
									List<Item> value11 = (List<Item>)((BBParameter<T>)(object)itemTags).value;
									((HashSet<T>)(object)hashSet2).UnionWith((IEnumerable<>)value11);
									int count = ((HashSet<>)(object)hashSet2)._count;
									((HashSet<T>)(object)hashSet2).IntersectWith((IEnumerable<>)hashSet);
								}
							}
							int num17 = 0;
							goto IL_02f3;
							IL_02f3:
							throw new NullReferenceException();
						};
						List<Item> list4 = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Where<Item>((IEnumerable<>)list3, (Func<, >)(object)func4));
					}
					if (flag4)
					{
						num += num14;
					}
					if (CS_0024_003C_003E8__locals0 != null)
					{
						break;
					}
				}
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0xD3F6C0", Offset = "0xD3E0C0", VA = "0x180D3F6C0")]
		public static void GetBackpackItems(ref Dictionary<Item, int> itemList)
		{
			//Discarded unreachable code: IL_003d, IL_0042, IL_0059, IL_0067, IL_006c
			RepeatedField<ContainerInventory.Types.Slot> inventory_ = SystemRoot.Instance.Client.Profile.Backpack.inventory_;
			int num = 0;
			int count = ((RepeatedField<T>)(object)inventory_).Count;
			if (num < count)
			{
				ContainerInventory.Types.Slot slot = (ContainerInventory.Types.Slot)((RepeatedField<T>)(object)inventory_)[num];
				int itemID = slot.ItemID;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0xD3F8E0", Offset = "0xD3E2E0", VA = "0x180D3F8E0")]
		public static void GetContainerInventoriesItems(ref Dictionary<Item, int> itemList)
		{
			//Discarded unreachable code: IL_0034, IL_0039, IL_0058, IL_005c, IL_0062, IL_0067, IL_006d, IL_0073, IL_0079, IL_007f, IL_0085
			int num = 0;
			MapField<uint, ContainerInventory> containerInventories_ = SystemRoot.Instance.Client.Profile.player_.containerInventories_;
			bool flag = default(bool);
			if (flag)
			{
				int num2 = default(int);
				while (num >= num2)
				{
				}
				ContainerInventory.Types.Slot slot = default(ContainerInventory.Types.Slot);
				int itemID = slot.ItemID;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0xD40B20", Offset = "0xD3F520", VA = "0x180D40B20")]
		public static void GetListInventoryItems(ref Dictionary<Item, int> itemList)
		{
			//Discarded unreachable code: IL_002e, IL_0033, IL_0039, IL_0040, IL_0046, IL_004c, IL_0052, IL_0058, IL_005e, IL_0064
			int num = 0;
			int num2 = 0;
			MapField<uint, ListInventory> listInventories_ = SystemRoot.Instance.Client.Profile.player_.listInventories_;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (flag && flag2)
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public Utils()
		{
		}
	}
}
