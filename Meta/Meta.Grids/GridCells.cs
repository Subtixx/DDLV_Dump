using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Grid;

namespace Meta.Grids
{
	[Cpp2IlInjected.Token(Token = "0x2001096")]
	internal static class GridCells
	{
		[Cpp2IlInjected.Token(Token = "0x60086C3")]
		[Cpp2IlInjected.Address(RVA = "0x1D06420", Offset = "0x1D04E20", VA = "0x181D06420")]
		public unsafe static bool CreateGridCells(IGrid grid, bool validate, out Dictionary<GridPosition, List<GridObject>> gridCells)
		{
			//Discarded unreachable code: IL_0057, IL_005d
			//IL_0017: Expected O, but got Ref
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			Dictionary<GridPosition, List<GridObject>> dictionary = (Dictionary<GridPosition, List<GridObject>>)(object)(((Dictionary<, >)System.Runtime.CompilerServices.Unsafe.AsPointer(ref gridCells)).buckets = (int[])(object)new Dictionary<TKey, TValue>());
			if (dictionary != null && validate)
			{
				uint num5 = default(uint);
				if (num < (int)num5)
				{
					num += num;
					num++;
				}
				GridArea gridArea = default(GridArea);
				if (gridArea.SizeX == 0)
				{
					int num6 = 0;
					num++;
					gridArea = (GridArea)(gridArea + num);
				}
			}
			num++;
			if (dictionary != null)
			{
			}
			if (num != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60086C4")]
		[Cpp2IlInjected.Address(RVA = "0x1D061C0", Offset = "0x1D04BC0", VA = "0x181D061C0")]
		public unsafe static void AddToGridCells(Dictionary<GridPosition, List<GridObject>> gridCells, GridObject gridObject)
		{
			//Discarded unreachable code: IL_004a
			int num = 0;
			if (gridCells == null)
			{
				return;
			}
			GridOrientation orientation_ = gridObject.orientation_;
			int num2 = default(int);
			if (num >= num2)
			{
				return;
			}
			GridOrientation orientation_2 = gridObject.orientation_;
			int num3 = default(int);
			if (num < num3)
			{
				GridPosition key = *(GridPosition*)num + *(GridPosition*)num;
				if (!((Dictionary<TKey, TValue>)(object)gridCells).TryGetValue((TKey)key, out *(TValue*)num))
				{
					List<GridObject> list = (List<GridObject>)(object)new List<T>(2);
					throw new NullReferenceException();
				}
				num++;
			}
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x60086C5")]
		[Cpp2IlInjected.Address(RVA = "0x1D06CA0", Offset = "0x1D056A0", VA = "0x181D06CA0")]
		public unsafe static void RemoveFromGridCells(Dictionary<GridPosition, List<GridObject>> gridCells, GridObject gridObject)
		{
			//Discarded unreachable code: IL_0040
			int num = 0;
			if (gridCells == null)
			{
				return;
			}
			GridOrientation orientation_ = gridObject.orientation_;
			int num2 = default(int);
			if (num < num2)
			{
				GridOrientation orientation_2 = gridObject.orientation_;
				int num3 = default(int);
				if (num < num3)
				{
					GridPosition key = *(GridPosition*)num + *(GridPosition*)num;
					bool flag = ((List<T>)((Dictionary<TKey, TValue>)(object)gridCells)[(TKey)key]).Remove((T)gridObject);
					num++;
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60086C6")]
		[Cpp2IlInjected.Address(RVA = "0x1D06B40", Offset = "0x1D05540", VA = "0x181D06B40")]
		public static GridLayers GetLayersForPosition(Dictionary<GridPosition, List<GridObject>> gridCells, in GridPosition gridPosition)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			bool flag = default(bool);
			if (flag && num < num)
			{
				int num4 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				num++;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60086C7")]
		[Cpp2IlInjected.Address(RVA = "0x1D06730", Offset = "0x1D05130", VA = "0x181D06730")]
		public unsafe static List<GridObject> GetConflictedObjects(Dictionary<GridPosition, List<GridObject>> gridCells, in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject)
		{
			//Discarded unreachable code: IL_006a, IL_0070
			//IL_003d: Expected O, but got I4
			//IL_005b: Expected O, but got I4
			List<GridObject> list;
			int num5 = default(int);
			int num6 = default(int);
			GridPosition position = default(GridPosition);
			GridPosition key = default(GridPosition);
			bool flag = default(bool);
			GridLayers gridLayers = default(GridLayers);
			bool flag2 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				list = (List<GridObject>)(object)new List<T>();
				if (num >= num5)
				{
					break;
				}
				if (num < num6)
				{
					if (gridArea[position] != 0 && ((Dictionary<TKey, TValue>)(object)gridCells).TryGetValue((TKey)key, out *(TValue*)num))
					{
						if (flag)
						{
							if (((List<T>)(object)list).Contains((T)num3))
							{
								continue;
							}
							int num7 = (int)gridLayers;
							GridLayers gridLayers2 = gridArea[position];
							while (!flag2)
							{
							}
							((List<T>)(object)list).Add((T)num3);
						}
						if (num != 0)
						{
							continue;
						}
					}
					num++;
				}
				num++;
				break;
			}
			return list;
		}
	}
}
