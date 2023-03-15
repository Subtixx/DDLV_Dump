using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf.Collections;
using Meta.Collections;
using Meta.Grids;
using Meta.Missions;

namespace Meta.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000E0E")]
	public static class ActionsHelper
	{
		[Cpp2IlInjected.Token(Token = "0x6007637")]
		[Cpp2IlInjected.Address(RVA = "0x18DDAC0", Offset = "0x18DC4C0", VA = "0x1818DDAC0")]
		internal static string GetMissionName(Item item)
		{
			//Discarded unreachable code: IL_0011
			string text = default(string);
			return text.Replace("Mission/MissionData/", "");
		}

		[Cpp2IlInjected.Token(Token = "0x6007638")]
		[Cpp2IlInjected.Address(RVA = "0x18DE4F0", Offset = "0x18DCEF0", VA = "0x1818DE4F0")]
		internal static bool LogSuccess(string name, string msg)
		{
			//Discarded unreachable code: IL_008c
			string[] array;
			while (true)
			{
				array = new string[5];
				if ("[ACTION] " != null && "[ACTION] " == null)
				{
					continue;
				}
				array[0] = "[ACTION] ";
				if (name != null && "[ACTION] " == null)
				{
					continue;
				}
				array[1] = name;
				if (" - " != null && " - " == null)
				{
					continue;
				}
				array[2] = " - ";
				if (msg == null || " - " != null)
				{
					array[3] = msg;
					if ("\n" == null || "\n" != null)
					{
						break;
					}
				}
			}
			array[4] = "\n";
			string text = string.Concat(array);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6007639")]
		[Cpp2IlInjected.Address(RVA = "0x18DE1D0", Offset = "0x18DCBD0", VA = "0x1818DE1D0")]
		internal static bool LogError(string name, string msg)
		{
			string[] array;
			while (true)
			{
				array = new string[5];
				if ("[ACTION] " != null && "[ACTION] " == null)
				{
					continue;
				}
				array[0] = "[ACTION] ";
				if (name != null && "[ACTION] " == null)
				{
					continue;
				}
				array[1] = name;
				if (" - ERROR: " != null && " - ERROR: " == null)
				{
					continue;
				}
				array[2] = " - ERROR: ";
				if (msg == null || " - ERROR: " != null)
				{
					array[3] = msg;
					if ("\n" == null || "\n" != null)
					{
						break;
					}
				}
			}
			array[4] = "\n";
			string text = string.Concat(array);
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600763A")]
		[Cpp2IlInjected.Address(RVA = "0x18DD310", Offset = "0x18DBD10", VA = "0x1818DD310")]
		internal static bool AddItem(Item item, int amount, Profile profile)
		{
			//Discarded unreachable code: IL_0044
			//IL_001a: Expected O, but got I4
			//IL_001a: Expected O, but got I4
			//IL_001a: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			int itemID = item.ItemID;
			int num = 0;
			AddRemoveItemResult addRemoveItemResult = default(AddRemoveItemResult);
			if (addRemoveItemResult != 0)
			{
				string msg = $"{addRemoveItemResult}, did not give {addRemoveItemResult}x {addRemoveItemResult}";
				return LogError("AddItem", msg);
			}
			string msg2 = $"Give {addRemoveItemResult}x {addRemoveItemResult}";
			return LogSuccess("AddItem", msg2);
		}

		[Cpp2IlInjected.Token(Token = "0x600763B")]
		[Cpp2IlInjected.Address(RVA = "0x18DF170", Offset = "0x18DDB70", VA = "0x1818DF170")]
		internal static void RemoveFromInventory(List<Item> items, Profile profile, bool fromContainer = true, bool fromList = true)
		{
			if (fromContainer)
			{
				int num = ActionsHelper.RemoveItemsInContainerInventories((List<>)(object)items, profile);
			}
			if (fromList)
			{
				ActionsHelper.RemoveItemsInListInventories((List<>)(object)items, profile);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600763C")]
		[Cpp2IlInjected.Address(RVA = "0x18DF1C0", Offset = "0x18DDBC0", VA = "0x1818DF1C0")]
		internal static void RemoveFromInventory(Item item, Profile profile, bool fromContainer = true, bool fromList = true)
		{
			int itemID = item.ItemID;
			if (fromContainer)
			{
				int num = RemoveItemInContainerInventories(item, profile);
			}
			if (!fromList)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600763D")]
		[Cpp2IlInjected.Address(RVA = "0x18DEE80", Offset = "0x18DD880", VA = "0x1818DEE80")]
		internal static void RemoveFromGrid(List<Item> items, Profile profile)
		{
			int num = ActionsHelper.RemoveItemsInCollectionDiffGrids((List<>)(object)items, profile);
			int num2 = ActionsHelper.RemoveItemsInCollectionGrids((List<>)(object)items, profile);
		}

		[Cpp2IlInjected.Token(Token = "0x600763E")]
		[Cpp2IlInjected.Address(RVA = "0x18DEEB0", Offset = "0x18DD8B0", VA = "0x1818DEEB0")]
		internal static int RemoveFromGrid(Item item, Profile profile, bool GiveBack = false)
		{
			//IL_003a: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_0058: Expected O, but got I4
			//IL_0058: Expected O, but got I4
			int itemID = item.ItemID;
			int num = ActionsHelper.RemoveItemsInCollectionDiffGrids((List<>)(object)new List<T>(), profile);
			int num2 = ActionsHelper.RemoveItemsInCollectionGrids((List<>)(object)new List<T>(), profile);
			if (GiveBack)
			{
				int num3 = 0;
				AddRemoveItemResult addRemoveItemResult = default(AddRemoveItemResult);
				if (addRemoveItemResult != 0)
				{
					string msg = $"{addRemoveItemResult}, did not give {addRemoveItemResult}x {addRemoveItemResult}";
					bool flag = LogError("AddItem", msg);
				}
				string msg2 = $"Give {addRemoveItemResult}x {addRemoveItemResult}";
				bool flag2 = LogSuccess("AddItem", msg2);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600763F")]
		[Cpp2IlInjected.Address(RVA = "0x18DDB30", Offset = "0x18DC530", VA = "0x1818DDB30")]
		internal static bool IsItemOnGrid(Item item, Profile profile, bool includeDiffGrid = true)
		{
			//Discarded unreachable code: IL_00fa, IL_0100, IL_0106, IL_010c, IL_0112, IL_0118, IL_011e, IL_0124, IL_012a, IL_0130, IL_0136, IL_013c
			int num = 0;
			ICollection<Grid> values = (ICollection<Grid>)((MapField<TKey, TValue>)(object)profile.world_.gridCollection_.grids_).get_Values();
			if (values != null)
			{
				int num2 = 0;
				ICollection<> collection = default(ICollection<>);
				if (collection != null)
				{
					while (collection == null)
					{
					}
					num++;
				}
				num++;
				int num3 = default(int);
				if (collection != null)
				{
					num3 = 0;
				}
				while (num == 0)
				{
				}
				if (num3 == 253)
				{
				}
				while (num3 != 103)
				{
				}
			}
			int num4 = num4 + 1;
			int num5 = 0;
			int num6 = default(int);
			if (values != null)
			{
				num6 = 0;
			}
			int num7 = default(int);
			if (num4 != 0)
			{
				num7 = num4 - 1;
				if (num6 == 253)
				{
					goto IL_00f4;
				}
			}
			ICollection<> collection2 = default(ICollection<>);
			ICollection<> collection3 = default(ICollection<>);
			if (collection2 != null)
			{
				uint num8 = default(uint);
				if (num5 < (int)num8)
				{
					num5 += num5;
					if (num5 == (int)num8)
					{
						goto IL_00a0;
					}
					num5++;
				}
				if (collection3 != null)
				{
					while (collection3 == null)
					{
					}
					num7++;
					goto IL_00a0;
				}
				goto IL_00aa;
			}
			goto IL_00e4;
			IL_00a0:
			num7 += 312;
			goto IL_00aa;
			IL_00aa:
			num7++;
			if (collection3 != null)
			{
			}
			while (num7 == 0)
			{
			}
			int num9 = num7 - 1;
			num7 = num9;
			if ((long)typeof(IDisposable).TypeHandle == 253)
			{
			}
			while ((long)typeof(IDisposable).TypeHandle != 228)
			{
			}
			num7 = num9;
			goto IL_00e4;
			IL_00e4:
			num9++;
			if (collection2 != null)
			{
			}
			if (num9 == 0)
			{
			}
			goto IL_00f4;
			IL_00f4:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007640")]
		[Cpp2IlInjected.Address(RVA = "0x18DF3F0", Offset = "0x18DDDF0", VA = "0x1818DF3F0")]
		internal static int RemoveItemInContainerInventories(Item item, Profile profile)
		{
			//Discarded unreachable code: IL_000c
			return ActionsHelper.RemoveItemsInContainerInventories((List<>)(object)new List<T>(), profile);
		}

		[Cpp2IlInjected.Token(Token = "0x6007641")]
		[Cpp2IlInjected.Address(RVA = "0x18E0810", Offset = "0x18DF210", VA = "0x1818E0810")]
		internal static int RemoveItemsInContainerInventories(List<Item> items, Profile profile)
		{
			//Discarded unreachable code: IL_00e8, IL_0106, IL_010c, IL_0112, IL_0118, IL_011e, IL_0124, IL_012a, IL_0130, IL_0136, IL_013c, IL_0142
			//IL_0074: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			//IL_00a9: Expected O, but got I4
			int num2 = default(int);
			ContainerInventory.Types.Slot slot = default(ContainerInventory.Types.Slot);
			bool flag = default(bool);
			bool flag2 = default(bool);
			int amount_ = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = 0;
				ICollection<ContainerInventory> values = (ICollection<ContainerInventory>)((MapField<TKey, TValue>)(object)profile.player_.containerInventories_).get_Values();
				if (values != null && num < num2)
				{
					List<Item> list = items;
					int itemID = slot.ItemID;
					if (flag || flag2)
					{
						object[] array = new object[4];
						amount_ = slot.amount_;
						if (amount_ != 0 && amount_ == 0)
						{
							throw new IndexOutOfRangeException();
						}
						array[0] = amount_;
						int itemID2 = slot.ItemID;
						amount_ = itemID2;
						if (itemID2 != 0 && itemID2 == 0)
						{
							throw new IndexOutOfRangeException();
						}
						array[1] = amount_;
						if (num3 != 0 && num3 == 0)
						{
							throw new IndexOutOfRangeException();
						}
						array[2] = num3;
						if (values != null && values == null)
						{
							break;
						}
						array[3] = values;
						string msg = string.Format("Remove {0}x {1} at idx{2} deleted from ContainerID={3}", array);
						bool flag3 = LogSuccess("ContainerInventories", msg);
					}
					num++;
				}
				if (values != null)
				{
				}
				if (amount_ == 0)
				{
					return num;
				}
			}
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007642")]
		[Cpp2IlInjected.Address(RVA = "0x18DF490", Offset = "0x18DDE90", VA = "0x1818DF490")]
		internal static void RemoveItemInListInventories(Item item, Profile profile)
		{
			//Discarded unreachable code: IL_000c
			ActionsHelper.RemoveItemsInListInventories((List<>)(object)new List<T>(), profile);
		}

		[Cpp2IlInjected.Token(Token = "0x6007643")]
		[Cpp2IlInjected.Address(RVA = "0x18E0DA0", Offset = "0x18DF7A0", VA = "0x1818E0DA0")]
		internal static void RemoveItemsInListInventories(List<Item> items, Profile profile)
		{
			//Discarded unreachable code: IL_0069, IL_006f, IL_007b
			//IL_0045: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			uint num4 = default(uint);
			bool flag = default(bool);
			bool flag2 = default(bool);
			string text = default(string);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				ICollection<ListInventory> values = (ICollection<ListInventory>)((MapField<TKey, TValue>)(object)profile.player_.listInventories_).get_Values();
				if (values != null)
				{
					if (num3 < (int)num4)
					{
						num3 += num3;
						if (num3 == (int)num4)
						{
							goto IL_0055;
						}
						num3++;
					}
					if (flag)
					{
						while (!flag2)
						{
						}
						text = $"Remove {flag2} from InventoryID={flag2}";
						bool flag3 = LogSuccess("ListInventories", text);
						goto IL_0055;
					}
					goto IL_005c;
				}
				goto IL_0060;
				IL_005c:
				if (num2 != 0)
				{
					break;
				}
				goto IL_0060;
				IL_0060:
				if (values != null)
				{
				}
				if (num2 == 0)
				{
					return;
				}
				continue;
				IL_0055:
				text += text;
				goto IL_005c;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007644")]
		[Cpp2IlInjected.Address(RVA = "0x18DF210", Offset = "0x18DDC10", VA = "0x1818DF210")]
		internal static int RemoveItemInCollectionDiffGrids(Item item, Profile profile)
		{
			//Discarded unreachable code: IL_000c
			return ActionsHelper.RemoveItemsInCollectionDiffGrids((List<>)(object)new List<T>(), profile);
		}

		[Cpp2IlInjected.Token(Token = "0x6007645")]
		[Cpp2IlInjected.Address(RVA = "0x18DF530", Offset = "0x18DDF30", VA = "0x1818DF530")]
		internal static int RemoveItemsInCollectionDiffGrids(List<Item> items, Profile profile)
		{
			//Discarded unreachable code: IL_0102, IL_0120, IL_0126, IL_012c, IL_0132, IL_0138, IL_013e, IL_0144, IL_014a
			//IL_002c: Expected O, but got I4
			//IL_0052: Expected I4, but got I8
			//IL_0052: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			//IL_00a3: Expected O, but got I4
			//IL_00b9: Expected O, but got I4
			//IL_00cc: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			ulong num3 = default(ulong);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				MapField<uint, DiffGrid> diffGrids_ = profile.world_.gridCollection_.diffGrids_;
				if (flag)
				{
					DiffGrid grid = (DiffGrid)num;
					List<uint> list = (List<uint>)(object)new List<T>();
					MapField<uint, GridObject> modifiedObjects_ = grid.modifiedObjects_;
					if (flag2)
					{
						if (!ActionsHelper.ShouldRemoveGridObjectOrFix((List<>)(object)items, (GridObject)num, (byte)num3 != 0))
						{
							continue;
						}
						((List<T>)(object)list).Add((T)num);
						object[] array = new object[4];
						if (array != null && array == null)
						{
							throw new IndexOutOfRangeException();
						}
						array[0] = array;
						uint iD_ = grid.iD_;
						if (iD_ != 0 && iD_ == 0)
						{
							throw new IndexOutOfRangeException();
						}
						array[1] = iD_;
						if (iD_ != 0 && iD_ == 0)
						{
							throw new IndexOutOfRangeException();
						}
						array[2] = iD_;
						if (num != 0 && iD_ == 0)
						{
							break;
						}
						array[3] = num;
						string msg = string.Format("{0} deleted from DiffGrids={1} (gridObject.ID={2}, state={3})", array);
						bool flag3 = LogSuccess("RemoveFromDiffGrids", msg);
					}
					Action<uint> action = (Action<uint>)(object)(Action<T>)delegate(uint x)
					{
						//Discarded unreachable code: IL_0013
						//IL_0011: Expected O, but got I4
						bool flag4 = ((MapField<TKey, TValue>)(object)grid.modifiedObjects_).Remove((TKey)x);
					};
					((List<T>)(object)list).ForEach((Action<>)(object)action);
				}
				return num;
			}
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007646")]
		[Cpp2IlInjected.Address(RVA = "0x18DF2B0", Offset = "0x18DDCB0", VA = "0x1818DF2B0")]
		internal static int RemoveItemInCollectionGrids(Item item, Profile profile)
		{
			//Discarded unreachable code: IL_000c
			return ActionsHelper.RemoveItemsInCollectionGrids((List<>)(object)new List<T>(), profile);
		}

		[Cpp2IlInjected.Token(Token = "0x6007647")]
		[Cpp2IlInjected.Address(RVA = "0x18DFBE0", Offset = "0x18DE5E0", VA = "0x1818DFBE0")]
		internal static int RemoveItemsInCollectionGrids(List<Item> items, Profile profile)
		{
			//Discarded unreachable code: IL_0105, IL_0123, IL_0129, IL_012f, IL_0135, IL_013b, IL_0141, IL_0147, IL_014d
			//IL_002c: Expected O, but got I4
			//IL_0052: Expected I4, but got I8
			//IL_0052: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			//IL_00a3: Expected O, but got I4
			//IL_00b9: Expected O, but got I4
			//IL_00cf: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			ulong num3 = default(ulong);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				MapField<uint, Grid> grids_ = profile.world_.gridCollection_.grids_;
				if (flag)
				{
					Grid grid = (Grid)num;
					List<uint> list = (List<uint>)(object)new List<T>();
					MapField<uint, GridObject> objects_ = grid.objects_;
					if (flag2)
					{
						if (!ActionsHelper.ShouldRemoveGridObjectOrFix((List<>)(object)items, (GridObject)num, (byte)num3 != 0))
						{
							continue;
						}
						((List<T>)(object)list).Add((T)num);
						object[] array = new object[4];
						if (array != null && array == null)
						{
							throw new IndexOutOfRangeException();
						}
						array[0] = array;
						uint iD_ = grid.iD_;
						if (iD_ != 0 && iD_ == 0)
						{
							throw new IndexOutOfRangeException();
						}
						array[1] = iD_;
						if (iD_ != 0 && iD_ == 0)
						{
							throw new IndexOutOfRangeException();
						}
						array[2] = iD_;
						if (iD_ != 0 && iD_ == 0)
						{
							break;
						}
						array[3] = iD_;
						string msg = string.Format("{0} deleted from Grids={1} (gridObject.ID={2}, gridObject.state={3})", array);
						bool flag3 = LogSuccess("RemoveFromGrids", msg);
					}
					Action<uint> action = (Action<uint>)(object)(Action<T>)delegate(uint x)
					{
						//Discarded unreachable code: IL_0013
						//IL_0011: Expected O, but got I4
						bool flag4 = ((MapField<TKey, TValue>)(object)grid.objects_).Remove((TKey)x);
					};
					((List<T>)(object)list).ForEach((Action<>)(object)action);
				}
				return num;
			}
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007648")]
		[Cpp2IlInjected.Address(RVA = "0x18E11D0", Offset = "0x18DFBD0", VA = "0x1818E11D0")]
		private static bool ShouldRemoveGridObjectOrFix(List<Item> items, GridObject gridObject, bool advanceStateCheck = true)
		{
			//IL_0200: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag6 = default(bool);
			while (true)
			{
				int itemID = gridObject.ItemID;
				if (flag || !advanceStateCheck)
				{
					break;
				}
				GridState state_ = gridObject.state_;
				if (state_ != null)
				{
					WeedData weedData = state_.WeedData;
					if (weedData != null && weedData.Treasure != null)
					{
						Item item = gridObject.state_.WeedData.Treasure.Item;
						if (flag2)
						{
							break;
						}
					}
				}
				GridState state_2 = gridObject.state_;
				if (state_2 != null)
				{
					AmountWithState itemAmountState = state_2.ItemAmountState;
					if (itemAmountState != null)
					{
						ItemState state_3 = itemAmountState.state_;
						if (state_3 != null && state_3.ConsummableData != null)
						{
							Item item2 = gridObject.state_.ItemAmountState.state_.ConsummableData.Item;
							if (flag3)
							{
								break;
							}
						}
					}
				}
				GridState state_4 = gridObject.state_;
				if (state_4 == null)
				{
					break;
				}
				AmountWithState itemAmountState2 = state_4.ItemAmountState;
				if (itemAmountState2 != null)
				{
					ItemState state_5 = itemAmountState2.state_;
					if (state_5 != null)
					{
						MultiItemInstance lootPresentData = state_5.LootPresentData;
						if (lootPresentData != null)
						{
							RepeatedField<ItemInstance> items_ = lootPresentData.items_;
							Predicate<ItemInstance> predicate = (Predicate<ItemInstance>)(object)(Predicate<T>)delegate(ItemInstance x)
							{
								//Discarded unreachable code: IL_0010
								List<Item> list = items;
								Item item4 = x.Item;
								bool result = default(bool);
								return result;
							};
							bool flag4 = ((RepeatedField<>)(object)items_).Any<ItemInstance>((Predicate<>)(object)predicate);
							int num = 0;
						}
					}
				}
				int num2 = 0;
				bool flag5 = num2 == 1;
				if (num2 == 1)
				{
					break;
				}
				int count = ((RepeatedField<T>)(object)gridObject.state_.ItemAmountState.state_.LootPresentData.items_).Count;
				int itemID2 = ((ItemInstance)((RepeatedField<T>)(object)gridObject.state_.ItemAmountState.state_.LootPresentData.items_)[count]).Item.ItemID;
				if (flag6)
				{
					object[] array = new object[4];
					Item item3 = ((ItemInstance)((RepeatedField<T>)(object)gridObject.state_.ItemAmountState.state_.LootPresentData.items_)[count]).Item;
					if ((object)item3 != null && (object)item3 == null)
					{
						continue;
					}
					array[0] = item3;
					if ((object)item3 != null && (object)item3 == null)
					{
						continue;
					}
					array[1] = item3;
					uint iD_ = gridObject.iD_;
					if (iD_ != 0 && iD_ == 0)
					{
						continue;
					}
					array[2] = iD_;
					GridState state_6 = gridObject.state_;
					if (state_6 != null && iD_ == 0)
					{
						continue;
					}
					array[3] = state_6;
					string msg = string.Format("{0} deleted from grid LootPresentData idx={1} (gridObject.ID={2}, gridObject.state={3})", array);
					bool flag7 = LogSuccess("RemoveFromGrids", msg);
					((RepeatedField<T>)(object)gridObject.state_.ItemAmountState.state_.LootPresentData.items_).RemoveAt(count);
				}
				return ((RepeatedField<T>)(object)gridObject.state_.ItemAmountState.state_.LootPresentData.items_).Count == 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007649")]
		[Cpp2IlInjected.Address(RVA = "0x18DF350", Offset = "0x18DDD50", VA = "0x1818DF350")]
		internal static int RemoveItemInCollections(Item item, Profile profile)
		{
			//Discarded unreachable code: IL_000c
			return ActionsHelper.RemoveItemsInCollections((List<>)(object)new List<T>(), profile);
		}

		[Cpp2IlInjected.Token(Token = "0x600764A")]
		[Cpp2IlInjected.Address(RVA = "0x18E0280", Offset = "0x18DEC80", VA = "0x1818E0280")]
		internal static int RemoveItemsInCollections(List<Item> items, Profile profile)
		{
			//Discarded unreachable code: IL_00ac, IL_00ca, IL_00d0, IL_00d6, IL_00dc, IL_00e2, IL_00e8
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			RepeatedField<CollectionSet> collectionSets_ = profile.player_.collectionSets_;
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			if (flag && flag2 && flag3)
			{
				bool flag4 = default(bool);
				while (!flag4)
				{
				}
				num4++;
				object[] array = new object[4];
				if (array != null && array == null)
				{
					throw new IndexOutOfRangeException();
				}
				array[0] = array;
				if (array != null && array == null)
				{
					throw new IndexOutOfRangeException();
				}
				array[1] = array;
				if (array != null && array == null)
				{
					throw new IndexOutOfRangeException();
				}
				array[2] = array;
				if (array != null && array == null)
				{
					throw new IndexOutOfRangeException();
				}
				array[3] = array;
				string msg = string.Format("{0} deleted from CollectionDefinitionID={1} (GroupIndex={2}, GroupsName={3})", array);
				bool flag5 = LogSuccess("RemoveFromCollections", msg);
			}
			return num4;
		}

		[Cpp2IlInjected.Token(Token = "0x600764B")]
		[Cpp2IlInjected.Address(RVA = "0x18DEDE0", Offset = "0x18DD7E0", VA = "0x1818DEDE0")]
		internal static void RemoveCurrencyAmounts(Item item, Profile profile)
		{
			//Discarded unreachable code: IL_000d
			int num = ActionsHelper.RemoveCurrenciesAmounts((List<>)(object)new List<T>(), profile);
		}

		[Cpp2IlInjected.Token(Token = "0x600764C")]
		[Cpp2IlInjected.Address(RVA = "0x18DEC20", Offset = "0x18DD620", VA = "0x1818DEC20")]
		internal static int RemoveCurrenciesAmounts(List<Item> items, Profile profile)
		{
			//Discarded unreachable code: IL_0039, IL_003f, IL_0045, IL_004b
			//IL_0027: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				MapField<int, int> currencyAmounts_ = profile.player_.currencyAmounts_;
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				num++;
				string msg = $"{flag2} deleted";
				bool flag3 = LogSuccess("RemoveCurrency", msg);
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600764D")]
		[Cpp2IlInjected.Address(RVA = "0x18DE900", Offset = "0x18DD300", VA = "0x1818DE900")]
		internal static void ReApplyItemToDeleteAfterMission(Item missionItem, Profile profile)
		{
			//Discarded unreachable code: IL_0088
			//IL_0077: Expected O, but got I4
			//IL_0077: Expected O, but got I4
			int itemID = missionItem.ItemID;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			bool flag = default(bool);
			if (flag)
			{
				if (_003C_003Ec._003C_003E9__22_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int x) => (Item)typeof(Item).TypeHandle);
				}
				IEnumerable<int> enumerable = default(IEnumerable<int>);
				List<Item> list = (List<Item>)(object)Enumerable.ToList<Item>((IEnumerable<>)enumerable);
				ProfileWorld world_ = profile.world_;
				bool flag2 = default(bool);
				if (flag2)
				{
					int num = ActionsHelper.RemoveItemsInContainerInventories((List<>)(object)list, profile);
					ActionsHelper.RemoveItemsInListInventories((List<>)(object)list, profile);
					int num2 = ActionsHelper.RemoveItemsInCollectionDiffGrids((List<>)(object)list, profile);
					int num3 = ActionsHelper.RemoveItemsInCollectionGrids((List<>)(object)list, profile);
				}
			}
			else
			{
				string msg = $"Invalid MissionID={flag} (item={flag})";
				bool flag3 = LogError("DeleteAfterMission", msg);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600764E")]
		[Cpp2IlInjected.Address(RVA = "0x18DD650", Offset = "0x18DC050", VA = "0x1818DD650")]
		internal static void ApplyNewItemToDeleteAfterMission(Item missionItem, List<Item> items, Profile profile)
		{
			//Discarded unreachable code: IL_002c
			ProfileWorld world_ = profile.world_;
			bool flag = default(bool);
			if (flag)
			{
				int num = ActionsHelper.RemoveItemsInContainerInventories((List<>)(object)items, profile);
				ActionsHelper.RemoveItemsInListInventories((List<>)(object)items, profile);
				int num2 = ActionsHelper.RemoveItemsInCollectionDiffGrids((List<>)(object)items, profile);
				int num3 = ActionsHelper.RemoveItemsInCollectionGrids((List<>)(object)items, profile);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600764F")]
		[Cpp2IlInjected.Address(RVA = "0x18DD9F0", Offset = "0x18DC3F0", VA = "0x1818DD9F0")]
		internal static void FixMissionObjectiveTargetAmount(Item missionItem, string stepName, int newAmount, Profile profile, [Optional] Func<MissionObjective, string> validator)
		{
			int itemID = missionItem.ItemID;
			int num = 0;
			SlotEditor slotEditor = default(SlotEditor);
			if (slotEditor != null)
			{
			}
			if (slotEditor == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007650")]
		[Cpp2IlInjected.Address(RVA = "0x18DE810", Offset = "0x18DD210", VA = "0x1818DE810")]
		internal static void MoveMissionObjective(Item missionItem, string stepName, int fromIndex, int toIndex, Profile profile, [Optional] Func<MissionObjective, string> validator)
		{
			int itemID = missionItem.ItemID;
			int num = 0;
			SlotEditor slotEditor = default(SlotEditor);
			if (slotEditor != null)
			{
			}
			if (slotEditor == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007651")]
		[Cpp2IlInjected.Address(RVA = "0x18E1110", Offset = "0x18DFB10", VA = "0x1818E1110")]
		internal static void SetMissionCurrentStep(Item missionItem, int newCurrentStepIndex, Profile profile)
		{
			int itemID = missionItem.ItemID;
			SlotEditor slotEditor = default(SlotEditor);
			if (slotEditor != null)
			{
				bool flag = slotEditor.SetCurrentStep(newCurrentStepIndex);
			}
			if (slotEditor == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007652")]
		[Cpp2IlInjected.Address(RVA = "0x18DD6D0", Offset = "0x18DC0D0", VA = "0x1818DD6D0")]
		internal static void ApplyNewMissionStep(Item missionItem, int stepID, bool canOverrideActive, Profile profile)
		{
			int itemID = missionItem.ItemID;
			SlotEditor slotEditor = default(SlotEditor);
			if (slotEditor != null)
			{
				bool flag = slotEditor.AddStepFromStepID(stepID, canOverrideActive);
			}
			if (slotEditor == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007653")]
		[Cpp2IlInjected.Address(RVA = "0x18DD940", Offset = "0x18DC340", VA = "0x1818DD940")]
		internal static void ApplyRemoveMissionSteps(Item missionItem, int stepIndex, Profile profile)
		{
			//Discarded unreachable code: IL_0013
			//IL_0012: Expected O, but got I4
			int itemID = missionItem.ItemID;
			new List<T>().Add((T)stepIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6007654")]
		[Cpp2IlInjected.Address(RVA = "0x18DD7A0", Offset = "0x18DC1A0", VA = "0x1818DD7A0")]
		internal static void ApplyRemoveMissionSteps(Item missionItem, List<int> stepIndexes, Profile profile)
		{
			int itemID = missionItem.ItemID;
			SlotEditor slotEditor = default(SlotEditor);
			if (slotEditor != null)
			{
				bool flag = slotEditor.RemoveSteps((List<>)(object)stepIndexes);
			}
			if (slotEditor == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007655")]
		[Cpp2IlInjected.Address(RVA = "0x18DD870", Offset = "0x18DC270", VA = "0x1818DD870")]
		internal static void ApplyRemoveMissionSteps(Item missionItem, List<(int StepIndex, int SubStepIndex, int ObjectiveIndex)> stepsToDelete, Profile profile, [Optional] Func<MissionObjective, int, string> validator)
		{
			int itemID = missionItem.ItemID;
			SlotEditor slotEditor = default(SlotEditor);
			if (slotEditor != null)
			{
				bool flag = slotEditor.RemoveSteps((List<>)(object)stepsToDelete, (Func<, , >)(object)validator);
			}
			if (slotEditor == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007656")]
		[Cpp2IlInjected.Address(RVA = "0x18DD4D0", Offset = "0x18DBED0", VA = "0x1818DD4D0")]
		internal static void ApplyDeletedItem(Item item, Profile profile)
		{
			int itemID = item.ItemID;
			int num = RemoveItemInCollections(item, profile);
		}

		[Cpp2IlInjected.Token(Token = "0x6007657")]
		[Cpp2IlInjected.Address(RVA = "0x18DD520", Offset = "0x18DBF20", VA = "0x1818DD520")]
		internal static void ApplyDeletedItems(List<Item> items, Profile profile)
		{
			bool flag = default(bool);
			if (!flag)
			{
			}
		}
	}
}
