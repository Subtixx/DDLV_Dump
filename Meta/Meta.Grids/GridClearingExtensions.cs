using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Items;
using Google.Protobuf.Collections;

namespace Meta.Grids
{
	[Cpp2IlInjected.Token(Token = "0x200108E")]
	public static class GridClearingExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600869B")]
		[Cpp2IlInjected.Address(RVA = "0x1D07040", Offset = "0x1D05A40", VA = "0x181D07040")]
		public static bool CanBeCleared(Item item, GridState gridState, Item clearedBy)
		{
			IGridEditRestriction gridEditRestriction = default(IGridEditRestriction);
			ItemType itemType = default(ItemType);
			bool flag2 = default(bool);
			BuildingItemType buildingItemType = default(BuildingItemType);
			FurnitureItemType furnitureItemType = default(FurnitureItemType);
			ActivityItemType activityItemType = default(ActivityItemType);
			bool flag3 = default(bool);
			BuildingItemType buildingItemType2 = default(BuildingItemType);
			Func<GardenData.Types.GardeningSlot, bool> func = default(Func<GardenData.Types.GardeningSlot, bool>);
			while (true)
			{
				int num = 0;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				bool flag = gridEditRestriction.CanBeCleared();
				if (flag)
				{
					if (!flag)
					{
						goto IL_0056;
					}
					if (flag)
					{
						if (itemType == ItemType.Character)
						{
							if (gridState != null)
							{
								GridState.StateOneofCase stateCase_ = gridState.stateCase_;
							}
							if (num == 0 || (num != 1 && num != 11))
							{
								if ((flag2 && buildingItemType != BuildingItemType.Garden) || furnitureItemType == FurnitureItemType.GroundAlteration)
								{
									break;
								}
								return furnitureItemType == FurnitureItemType.Landscaping;
							}
						}
					}
					else if (activityItemType == ActivityItemType.Flower)
					{
						break;
					}
				}
				int num2 = 0;
				goto IL_0056;
				IL_0056:
				while (!flag3)
				{
				}
				while (buildingItemType2 != BuildingItemType.Garden)
				{
				}
				while (gridState == null)
				{
				}
				if (gridState.GardenData == null)
				{
					continue;
				}
				RepeatedField<GardenData.Types.GardeningSlot> slots_ = gridState.GardenData.slots_;
				if (_003C_003Ec._003C_003E9__0_0 == null)
				{
					func = (Func<GardenData.Types.GardeningSlot, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GardenData.Types.GardeningSlot x)
					{
						Item plantedSeedItem = x.PlantedSeedItem;
						throw new NullReferenceException();
					});
				}
				if (((IEnumerable<>)(object)slots_).All<GardenData.Types.GardeningSlot>((Func<, >)(object)func))
				{
					break;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600869C")]
		[Cpp2IlInjected.Address(RVA = "0x1D07C00", Offset = "0x1D06600", VA = "0x181D07C00")]
		public static bool IsAreaValidWithClearing(IGrid grid, in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, bool automaticSpawning, Item clearedBy)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600869D")]
		[Cpp2IlInjected.Address(RVA = "0x1D07A90", Offset = "0x1D06490", VA = "0x181D07A90")]
		public static bool IsAreaValidForWithClearing(IGrid grid, in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, bool automaticSpawning, [Optional] Item? clearedBy)
		{
			if ((object)typeof(IGrid).TypeHandle != null && (gridArea.Stride == 1 || ((object)typeof(IGrid).TypeHandle == null && (object)typeof(IGrid).TypeHandle == null)))
			{
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if (num != 0)
				{
					return num == 12;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600869E")]
		[Cpp2IlInjected.Address(RVA = "0x1D06E60", Offset = "0x1D05860", VA = "0x181D06E60")]
		internal static GridObject AddObjectWithClearing(IGridInternal grid, Item item, in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridState gridState, bool automaticSpawning, in Player player, in World world, [Optional] GridSource? source, [Optional] GridAddObjectOptions options)
		{
			int itemID = item.ItemID;
			int num = 0;
			bool flag = default(bool);
			bool flag2 = default(bool);
			uint num2 = default(uint);
			if (flag && flag2 && num < (int)num2)
			{
				num += num;
				num++;
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600869F")]
		[Cpp2IlInjected.Address(RVA = "0x1D07CB0", Offset = "0x1D066B0", VA = "0x181D07CB0")]
		internal static bool UpdateTransformWithClearing(IGridInternal grid, GridObject gridObject, GridPosition newGridPosition, GridOrientation newOrientation, in Player player, in World world)
		{
			GridArea gridArea = default(GridArea);
			if ((object)gridArea != null)
			{
				int num = 0;
				bool flag = default(bool);
				bool flag2 = default(bool);
				if (flag && flag2)
				{
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
					return flag2;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60086A0")]
		[Cpp2IlInjected.Address(RVA = "0x1D073F0", Offset = "0x1D05DF0", VA = "0x181D073F0")]
		private static bool ClearConflictedObjects(IGridInternal grid, Item clearedBy, in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, in Player player, in World world, [Optional] GridObject clearedByGridObject)
		{
			//Discarded unreachable code: IL_00c0, IL_00c6, IL_00cc, IL_00d2, IL_00d8, IL_00de, IL_00e4, IL_00ea, IL_00f0, IL_00f6, IL_00fc
			//IL_002d: Expected O, but got I4
			//IL_00b4: Expected O, but got I4
			//IL_00b4: Expected O, but got I4
			//IL_00b4: Expected O, but got I4
			uint num4 = default(uint);
			bool flag = default(bool);
			bool flag2 = default(bool);
			ProfilePlayer profilePlayer = default(ProfilePlayer);
			ProfilePlayer profilePlayer2 = default(ProfilePlayer);
			int num2;
			while (true)
			{
				int num = 0;
				num2 = 0;
				int num3 = 0;
				if (num2 < (int)num4)
				{
					num2 += num2;
					num2++;
				}
				if (!flag)
				{
					break;
				}
				if (flag2)
				{
					int num5 = 0;
					if (!profilePlayer.Catalog.IsCompatibleItem((Item)num5))
					{
						continue;
					}
					int num6 = 0;
					ListInventory catalog = profilePlayer2.Catalog;
					num6 += num6;
				}
				int num7 = 0;
				num2++;
				break;
			}
			num2++;
			int num8 = 0;
			if (num2 != 0)
			{
			}
			bool flag3 = default(bool);
			if (flag3)
			{
				bool flag4 = default(bool);
				while (!flag4)
				{
				}
				FurnitureItemType furnitureItemType = default(FurnitureItemType);
				while (furnitureItemType != FurnitureItemType.Fence)
				{
				}
				bool flag5 = default(bool);
				while (flag5)
				{
				}
				GridOrientation[] fenceDirections = FenceModeUtility.FenceDirections;
				while (num8 >= fenceDirections.Length)
				{
				}
				GridOrientation gridOrientation2 = fenceDirections[num8];
				bool flag6 = default(bool);
				if (flag6 && num2 != 0)
				{
					int num9 = 0;
					bool flag7 = default(bool);
					if (!flag7)
					{
						int num10 = 0;
						ProfilePlayer profilePlayer3 = default(ProfilePlayer);
						ListInventory catalog2 = profilePlayer3.Catalog;
						int num11 = 0;
						catalog2.AddItem((Item)num10, 1, (ProfileEventDispatcher)num11, (AddDetail)num8);
					}
				}
				num8++;
			}
			throw new NullReferenceException();
		}
	}
}
