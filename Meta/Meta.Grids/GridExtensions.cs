using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;

namespace Meta.Grids
{
	[Cpp2IlInjected.Token(Token = "0x2001090")]
	public static class GridExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60086A4")]
		[Cpp2IlInjected.Address(RVA = "0x1D0C120", Offset = "0x1D0AB20", VA = "0x181D0C120")]
		public static bool CanSupportFloorType(this IGrid grid, GridFloorType gridFloorType)
		{
			//Discarded unreachable code: IL_0011
			bool flag = default(bool);
			if (!flag)
			{
				bool flag2 = default(bool);
				if (!flag2)
				{
					return flag2;
				}
				int num = 0;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60086A5")]
		[Cpp2IlInjected.Address(RVA = "0x1D0C7D0", Offset = "0x1D0B1D0", VA = "0x181D0C7D0")]
		public unsafe static bool IsAreaValidFor(this IGrid grid, Dictionary<GridPosition, List<GridObject>> gridCells, in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, bool automaticSpawning)
		{
			//IL_0045: Expected O, but got I4
			int num = 0;
			int num2;
			if (false && (16L == 1L || ((object)typeof(IGrid).TypeHandle == null && (object)typeof(IGrid).TypeHandle == null)) && num2 > 0)
			{
				int num3;
				if (num3 > 0)
				{
					GridLayers gridLayers;
					if (gridLayers != 0)
					{
						GridPosition gridPosition2 = gridPosition + *(GridPosition*)num;
						bool flag;
						if (!flag)
						{
							goto IL_007a;
						}
						if (((Dictionary<TKey, TValue>)(object)gridCells).TryGetValue((TKey)num, out *(TValue*)num))
						{
							int num4 = 0;
							int num5 = 0;
							System.ThrowHelper.ThrowArgumentOutOfRangeException();
							int num6 = 0;
							System.ThrowHelper.ThrowArgumentOutOfRangeException();
							int num7 = 0;
							System.ThrowHelper.ThrowArgumentOutOfRangeException();
							GridLayers gridLayers2;
							int num8 = (int)gridLayers2;
							bool flag2;
							if (flag2)
							{
								goto IL_007a;
							}
							num4++;
						}
					}
					num++;
				}
				num++;
			}
			goto IL_007a;
			IL_007a:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60086A6")]
		[Cpp2IlInjected.Address(RVA = "0x1D0D080", Offset = "0x1D0BA80", VA = "0x181D0D080")]
		internal static (bool, GridCellConflict) VerifyConflicts(this IGrid grid, Dictionary<GridPosition, List<GridObject>> gridCells, in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, GridCellConflict[][] conflictedCells, bool automaticSpawning, [Optional] Item? clearedBy, GridCellConflict conflictsToCheck = GridCellConflict.All, bool stopOnFirstConflictedCell = false)
		{
			int num5 = default(int);
			int num7 = default(int);
			GridLayers gridLayers = default(GridLayers);
			GridFloorType gridFloorType = default(GridFloorType);
			bool flag = default(bool);
			bool flag2 = default(bool);
			GridLayers gridLayers2 = default(GridLayers);
			GridLayers gridLayers3 = default(GridLayers);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			uint num18 = default(uint);
			GridPosition gridPosition2 = default(GridPosition);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				if (num != 0)
				{
				}
				if (num == 0)
				{
					break;
				}
				int num3 = 0;
				int num4 = 0;
				if (num5 > 0)
				{
					int num6 = 0;
					if (num7 > 0)
					{
						if (gridLayers != 0)
						{
							int num8 = 0;
							int num9 = (int)gridFloorType;
							if (!flag)
							{
							}
							if (flag2)
							{
								int num10 = 0;
								int num11 = 0;
								System.ThrowHelper.ThrowArgumentOutOfRangeException();
								int num12 = 0;
								System.ThrowHelper.ThrowArgumentOutOfRangeException();
								int num13 = 0;
								System.ThrowHelper.ThrowArgumentOutOfRangeException();
								int num14 = (int)gridLayers2;
								int num15 = (int)gridLayers3;
								if (flag3 && num15 != 8)
								{
									int num16 = 0;
									System.ThrowHelper.ThrowArgumentOutOfRangeException();
									int num17 = 0;
									System.ThrowHelper.ThrowArgumentOutOfRangeException();
									if (flag4)
									{
										num10++;
									}
								}
								num10++;
							}
							if (num18 == 4)
							{
							}
							if (num18 == 0)
							{
								continue;
							}
							int x = gridPosition2.X;
							if (gridPosition2.X != 0)
							{
								goto IL_00bd;
							}
						}
						num6++;
					}
					num4++;
				}
				goto IL_00bd;
				IL_00bd:
				bool flag5 = num3 != 0;
				break;
			}
			Exception ex = new Exception("When verifying conflicts, you need to pass either a valid gridObject or a valid item in clearedBy.");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60086A7")]
		[Cpp2IlInjected.Address(RVA = "0x1D0CBD0", Offset = "0x1D0B5D0", VA = "0x181D0CBD0")]
		private static bool IsFloorTypeValid(IGrid grid, GridArea gridArea, GridPosition localPosition, GridPosition worldPosition, bool automaticSpawning)
		{
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
				bool flag2 = default(bool);
				while (flag2)
				{
				}
				if ((object)localPosition != null)
				{
					goto IL_001c;
				}
			}
			bool flag3 = default(bool);
			while (!flag3)
			{
			}
			GridFloorType gridFloorType = default(GridFloorType);
			int num2 = (int)gridFloorType;
			bool flag4 = default(bool);
			while (flag4)
			{
			}
			goto IL_001c;
			IL_001c:
			GridFloorType gridFloorType2 = default(GridFloorType);
			int num3 = (int)gridFloorType2;
			while (gridFloorType2 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60086A8")]
		[Cpp2IlInjected.Address(RVA = "0x1D0C740", Offset = "0x1D0B140", VA = "0x181D0C740")]
		[IteratorStateMachine(typeof(_003CGetGridObjectsForPosition_003Ed__4))]
		public static IEnumerable<GridObject> GetGridObjectsForPosition(this IGrid grid, GridPosition gridPosition, int radius)
		{
			_003CGetGridObjectsForPosition_003Ed__4 _003CGetGridObjectsForPosition_003Ed__ = new _003CGetGridObjectsForPosition_003Ed__4(-2);
			_003CGetGridObjectsForPosition_003Ed__._003C_003E3__grid = grid;
			_003CGetGridObjectsForPosition_003Ed__._003C_003E3__gridPosition = gridPosition;
			_003CGetGridObjectsForPosition_003Ed__._003C_003E3__radius = radius;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60086A9")]
		[Cpp2IlInjected.Address(RVA = "0x1D0CE70", Offset = "0x1D0B870", VA = "0x181D0CE70")]
		public static bool PositionContains(this IGrid grid, in GridPosition gridPosition, in int radius, [Optional] Predicate<GridObject> predicate)
		{
			//Discarded unreachable code: IL_0031
			_003CGetGridObjectsForPosition_003Ed__4 _003CGetGridObjectsForPosition_003Ed__ = new _003CGetGridObjectsForPosition_003Ed__4(-2);
			_003CGetGridObjectsForPosition_003Ed__._003C_003E3__grid = grid;
			Func<GridObject, bool> cpp2il__autoParamName__idx_ = (Func<GridObject, bool>)(object)(Func<T, TResult>)((GridObject x) => ((Predicate<T>)(object)predicate)?.Invoke((T)x) ?? true);
			return ((IEnumerable<>)(object)_003CGetGridObjectsForPosition_003Ed__).Any<GridObject>((Func<, >)(object)cpp2il__autoParamName__idx_);
		}

		[Cpp2IlInjected.Token(Token = "0x60086AA")]
		[Cpp2IlInjected.Address(RVA = "0x1D0C240", Offset = "0x1D0AC40", VA = "0x181D0C240")]
		[IteratorStateMachine(typeof(_003CEnumeratePositionsInSpiralOrder_003Ed__6))]
		public static IEnumerable<GridPosition> EnumeratePositionsInSpiralOrder(this IGrid grid, GridPosition center, int spiralIncrement = 1, int maxNumberOfLoops = -1, [Optional] Func<GridPosition, bool> validityCheck, [Optional] Action<int> loopCallback)
		{
			//IL_0016: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			_003CEnumeratePositionsInSpiralOrder_003Ed__6 _003CEnumeratePositionsInSpiralOrder_003Ed__ = new _003CEnumeratePositionsInSpiralOrder_003Ed__6(-2);
			_003CEnumeratePositionsInSpiralOrder_003Ed__._003C_003E3__grid = grid;
			_003CEnumeratePositionsInSpiralOrder_003Ed__._003C_003E3__validityCheck = (Func<GridPosition, bool>)0;
			_003CEnumeratePositionsInSpiralOrder_003Ed__._003C_003E3__center = center;
			_003CEnumeratePositionsInSpiralOrder_003Ed__._003C_003E3__spiralIncrement = spiralIncrement;
			_003CEnumeratePositionsInSpiralOrder_003Ed__._003C_003E3__maxNumberOfLoops = maxNumberOfLoops;
			_003CEnumeratePositionsInSpiralOrder_003Ed__._003C_003E3__loopCallback = (Action<int>)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60086AB")]
		[Cpp2IlInjected.Address(RVA = "0x1D0C310", Offset = "0x1D0AD10", VA = "0x181D0C310")]
		public static GridPosition? FindFirstPositionInSpiralOrder(this IGrid grid, GridPosition center, int spiralIncrement = 1, int maxNumberOfLoops = -1, [Optional] Func<GridPosition, bool> validityCheck, [Optional] Action<int> loopCallback)
		{
			//Discarded unreachable code: IL_004f
			//IL_001a: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			//IL_0036: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			_003CEnumeratePositionsInSpiralOrder_003Ed__6 _003CEnumeratePositionsInSpiralOrder_003Ed__ = new _003CEnumeratePositionsInSpiralOrder_003Ed__6(-2);
			_003CEnumeratePositionsInSpiralOrder_003Ed__._003C_003E3__grid = (IGrid)center;
			_003CEnumeratePositionsInSpiralOrder_003Ed__._003C_003E3__center = (GridPosition)spiralIncrement;
			_003CEnumeratePositionsInSpiralOrder_003Ed__._003C_003E3__spiralIncrement = maxNumberOfLoops;
			_003CEnumeratePositionsInSpiralOrder_003Ed__._003C_003E3__maxNumberOfLoops = 0;
			_003CEnumeratePositionsInSpiralOrder_003Ed__._003C_003E3__validityCheck = (Func<GridPosition, bool>)0;
			_003CEnumeratePositionsInSpiralOrder_003Ed__._003C_003E3__loopCallback = (Action<int>)0;
			num2 += num2;
			num2++;
			int num3 = 0;
			uint num4 = default(uint);
			if (num4 != 0)
			{
			}
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60086AC")]
		[Cpp2IlInjected.Address(RVA = "0x1D0C5E0", Offset = "0x1D0AFE0", VA = "0x181D0C5E0")]
		public unsafe static GridPosition? FindValidPositionAround(this IGrid grid, GridPosition center, GridOrientation orientation, GridArea area, bool automaticSpawning, int maxDistance = -1)
		{
			//IL_001b: Expected I4, but got O
			IReadOnlyList<int> area2 = area.area;
			IGrid grid2 = (IGrid)center;
			GridOrientation orientation2 = (GridOrientation)area2;
			bool automaticSpawning2 = false;
			Func<GridPosition, bool> func = (Func<GridPosition, bool>)(object)(Func<T, TResult>)delegate
			{
				IGrid grid3 = grid2;
				GridOrientation gridOrientation = orientation2;
				bool flag = automaticSpawning2;
				throw new NullReferenceException();
			};
			int num = 0;
			GridPosition? gridPosition = default(GridPosition?);
			bool has_value = ((Nullable<>*)(&gridPosition))->has_value;
			throw new NullReferenceException();
		}
	}
}
