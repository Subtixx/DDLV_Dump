using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Gameloft.Common;

namespace Meta.Grids
{
	[Cpp2IlInjected.Token(Token = "0x2001086")]
	public struct FenceModeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2001087")]
		public struct SpatialInformation
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4004441")]
			public GridObject Base;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4004442")]
			public GridObject Extension;
		}

		[Cpp2IlInjected.Token(Token = "0x4004438")]
		public static readonly GridOrientation[] FenceDirections;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4004439")]
		private readonly GridObject gridObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400443A")]
		private readonly IReadOnlyDictionary<GridPosition, List<GridObject>> gridCells;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400443B")]
		private SpatialInformation[] spatialInformation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400443C")]
		public readonly Item BaseItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400443D")]
		private readonly HashSet<Item> extensions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400443E")]
		private readonly Dictionary<int, Item> extensionsBySize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400443F")]
		public readonly (Item item, int size) MinExtension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4004440")]
		public readonly (Item item, int size) MaxExtension;

		[Cpp2IlInjected.Token(Token = "0x1700175F")]
		public IEnumerable<Item> AllExtensions
		{
			[Cpp2IlInjected.Token(Token = "0x6008663")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				HashSet<Item> hashSet = extensions;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001760")]
		public bool HasExtensions
		{
			[Cpp2IlInjected.Token(Token = "0x6008664")]
			[Cpp2IlInjected.Address(RVA = "0x17FB310", Offset = "0x17F9D10", VA = "0x1817FB310")]
			get
			{
				//Discarded unreachable code: IL_0009
				HashSet<Item> hashSet = extensions;
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001761")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6008667")]
			[Cpp2IlInjected.Address(RVA = "0x17FB360", Offset = "0x17F9D60", VA = "0x1817FB360")]
			get
			{
				HashSet<Item> hashSet = extensions;
				int num = 0;
				GridOrientation[] fenceDirections = FenceDirections;
				int length = fenceDirections.Length;
				GridOrientation gridOrientation;
				if (num < length)
				{
					gridOrientation = fenceDirections[num];
					bool flag = default(bool);
					if (flag)
					{
						goto IL_0056;
					}
					SpatialInformation[] array = spatialInformation;
					num += num;
					if ((long)"{il2cpp array field local8->}" == 0)
					{
						gridOrientation = (GridOrientation)((int)gridOrientation + (int)gridOrientation);
						if ((long)"{il2cpp array field local8->}" != 0)
						{
							int num2 = 0;
							goto IL_0056;
						}
					}
					goto IL_0088;
				}
				goto IL_008c;
				IL_0056:
				int num3 = (int)gridOrientation;
				if (gridOrientation != 0)
				{
					if (gridOrientation != 0)
					{
						if (gridOrientation == GridOrientation.Up)
						{
							goto IL_0076;
						}
						if (num3 != 1)
						{
							goto IL_0088;
						}
					}
					SpatialInformation[] array2 = spatialInformation;
				}
				goto IL_0076;
				IL_0076:
				SpatialInformation[] array3 = spatialInformation;
				while ((long)"{il2cpp array field local12->}" == 0)
				{
				}
				goto IL_0088;
				IL_008c:
				throw new NullReferenceException();
				IL_0088:
				num++;
				goto IL_008c;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008665")]
		[Cpp2IlInjected.Address(RVA = "0x17FA730", Offset = "0x17F9130", VA = "0x1817FA730")]
		public bool IsExtension(Item item)
		{
			//Discarded unreachable code: IL_0009
			HashSet<Item> hashSet = extensions;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6008666")]
		[Cpp2IlInjected.Address(RVA = "0x17FA790", Offset = "0x17F9190", VA = "0x1817FA790")]
		public bool TryGetExtension(int size, out Item extensionItem)
		{
			//Discarded unreachable code: IL_0009
			Dictionary<int, Item> dictionary = extensionsBySize;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6008668")]
		[Cpp2IlInjected.Address(RVA = "0x17FB2D0", Offset = "0x17F9CD0", VA = "0x1817FB2D0")]
		public FenceModeUtility(GridObject gridObject, Grid grid)
		{
			//Discarded unreachable code: IL_0008
			Dictionary<GridPosition, List<GridObject>> dictionary = (Dictionary<GridPosition, List<GridObject>>)(object)grid.get_GridCells();
		}

		[Cpp2IlInjected.Token(Token = "0x6008669")]
		[Cpp2IlInjected.Address(RVA = "0x17FAAD0", Offset = "0x17F94D0", VA = "0x1817FAAD0")]
		internal unsafe FenceModeUtility(GridObject gridObject, IReadOnlyDictionary<GridPosition, List<GridObject>> gridCells)
		{
			//Discarded unreachable code: IL_0092, IL_0105, IL_010b, IL_0111, IL_0123, IL_0129
			//IL_001e: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			//IL_00d3: Expected I4, but got O
			//IL_0104: Expected I4, but got O
			int num = 0;
			this.gridObject = gridObject;
			this.gridCells = gridCells;
			int itemID = gridObject.ItemID;
			BaseItem = (Item)itemID;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int itemID2 = gridObject.ItemID;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (flag && flag2)
			{
				BaseItem = (Item)flag2;
			}
			Dictionary<int, Item> dictionary = (extensionsBySize = (Dictionary<int, Item>)(object)new Dictionary<TKey, TValue>());
			HashSet<Item> hashSet = (extensions = (HashSet<Item>)(object)new HashSet<T>());
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			int itemID3 = gridObject.ItemID;
			IEnumerable<> enumerable = default(IEnumerable<>);
			if (enumerable != null)
			{
				while (enumerable == null)
				{
				}
				if (enumerable != null)
				{
					Dictionary<int, Item> dictionary2 = extensionsBySize;
					if (enumerable != null)
					{
						throw new NullReferenceException();
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			int num2 = 0;
			if (enumerable != null)
			{
			}
			Func<KeyValuePair<int, Item>, int> func = default(Func<KeyValuePair<int, Item>, int>);
			if (_003C_003Ec._003C_003E9__19_0 == null)
			{
				func = (Func<KeyValuePair<int, Item>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, Item> x) => (int)((KeyValuePair<, >*)(&x))->key));
			}
			int num3 = (int)((KeyValuePair<, >)MoreLinq.MaxByOrDefault<KeyValuePair<int, Item>, int>(enumerable, (Func<, >)(object)func)).key;
			Func<KeyValuePair<int, Item>, int> func2 = default(Func<KeyValuePair<int, Item>, int>);
			if (_003C_003Ec._003C_003E9__19_1 == null)
			{
				func2 = (Func<KeyValuePair<int, Item>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, Item> x) => (int)((KeyValuePair<, >*)(&x))->key));
			}
			int num4 = (int)((KeyValuePair<, >)MoreLinq.MaxByOrDefault<KeyValuePair<int, Item>, int>(enumerable, (Func<, >)(object)func2)).key;
		}

		[Cpp2IlInjected.Token(Token = "0x600866A")]
		[Cpp2IlInjected.Address(RVA = "0x17FA960", Offset = "0x17F9360", VA = "0x1817FA960")]
		public void UpdateSpatialInformation(GridPosition selectedObjectPosition)
		{
			SpatialInformation[] array = default(SpatialInformation[]);
			spatialInformation = array;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600866B")]
		[Cpp2IlInjected.Address(RVA = "0x17F9EC0", Offset = "0x17F88C0", VA = "0x1817F9EC0")]
		public unsafe SpatialInformation[] GetSpatialInformationForItemAtPosition(Item item, GridPosition selectedObjectPosition, GridOrientation selectedObjectOrientation)
		{
			//Discarded unreachable code: IL_011f
			//IL_00a2: Expected O, but got I4
			SpatialInformation[] result;
			int num5 = default(int);
			GridPosition gridPosition2 = default(GridPosition);
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			int num11 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				Item baseItem = BaseItem;
				IGridPlaceableItemData itemData = _003CInstance_003Ek__BackingField2.GetItemData<IGridPlaceableItemData>(baseItem);
				HashSet<Item> hashSet = extensions;
				result = new SpatialInformation[4];
				HashSet<Item> hashSet2 = extensions;
				GridOrientation[] fenceDirections = FenceDirections;
				if (num >= fenceDirections.Length)
				{
					break;
				}
				GridOrientation gridOrientation = fenceDirections[num];
				int num4 = (int)gridOrientation;
				if (gridOrientation != 0 && gridOrientation != 0 && (gridOrientation == GridOrientation.Up || num4 == 1))
				{
					int num6 = num5;
				}
				IReadOnlyDictionary<GridPosition, List<GridObject>> readOnlyDictionary = gridCells;
				GridPosition gridPosition = *(GridPosition*)num * num;
				GridPosition gridPosition3 = *(GridPosition*)gridPosition2 + *(GridPosition*)gridPosition;
				int num7 = 0;
				if ((object)MoreLinq.GetValueOrDefault<GridPosition, List<GridObject>>((IReadOnlyDictionary<, >)readOnlyDictionary, (List<GridObject>)gridPosition3, (GridPosition)num7) != null)
				{
					if (flag)
					{
						if (!flag)
						{
							while (!flag2)
							{
							}
							int num8 = (int)gridOrientation;
							if (gridOrientation != 0)
							{
								if (gridOrientation != 0)
								{
									if (gridOrientation == GridOrientation.Up)
									{
										goto IL_00d6;
									}
									if (num8 != 1)
									{
										goto IL_00e5;
									}
								}
								if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) != null)
								{
								}
							}
							goto IL_00d6;
						}
						goto IL_00eb;
					}
					goto IL_0108;
				}
				goto IL_0118;
				IL_00eb:
				int num9 = (int)gridOrientation;
				if ((gridOrientation == GridOrientation.Up || gridOrientation == GridOrientation.Up || gridOrientation == GridOrientation.Up || num9 == 1) && !flag3)
				{
				}
				goto IL_0108;
				IL_0118:
				num++;
				break;
				IL_00e5:
				int num10 = 0;
				num11 = 0;
				goto IL_00eb;
				IL_0108:
				if (num != 0)
				{
					continue;
				}
				if (num11 != 0)
				{
					num++;
				}
				goto IL_0118;
				IL_00d6:
				if ((ulong)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) == 3)
				{
				}
				if ((ulong)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) == 1)
				{
					goto IL_00e5;
				}
				goto IL_0108;
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600866C")]
		[Cpp2IlInjected.Address(RVA = "0x17F9E10", Offset = "0x17F8810", VA = "0x1817F9E10")]
		public static GridOrientation GetDirection(GridPosition delta)
		{
			if ((object)delta != null)
			{
				if ((object)delta == null)
				{
					return GridOrientation.Right;
				}
			}
			else if ((object)delta != null)
			{
				return GridOrientation.Down;
			}
			ArgumentException ex = new ArgumentException("delta must be in only one direction (horizontal or vertical)", "delta");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600866D")]
		[Cpp2IlInjected.Address(RVA = "0x17FA800", Offset = "0x17F9200", VA = "0x1817FA800")]
		public bool TryGetFencesInDirection(GridPosition delta, out GridObject baseFence, out GridObject extensionFence)
		{
			GridOrientation direction = GetDirection(delta);
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600866E")]
		[Cpp2IlInjected.Address(RVA = "0x17FA8A0", Offset = "0x17F92A0", VA = "0x1817FA8A0")]
		public bool TryGetFencesInDirection(GridOrientation direction, out GridObject baseFence, out GridObject extensionFence)
		{
			int num = (int)direction;
			SpatialInformation[] array = spatialInformation;
			SpatialInformation[] array2 = spatialInformation;
			num += num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600866F")]
		[Cpp2IlInjected.Address(RVA = "0x17F9DB0", Offset = "0x17F87B0", VA = "0x1817F9DB0")]
		public bool CanMove()
		{
			int direction = 0;
			if (!CanMove((GridOrientation)direction) && !CanMove(GridOrientation.Down) && !CanMove(GridOrientation.Left))
			{
				return CanMove(GridOrientation.Right);
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6008670")]
		[Cpp2IlInjected.Address(RVA = "0x17F9B50", Offset = "0x17F8550", VA = "0x1817F9B50")]
		public bool CanMove(GridPosition delta)
		{
			GridOrientation direction = GetDirection(delta);
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6008671")]
		[Cpp2IlInjected.Address(RVA = "0x17F9BC0", Offset = "0x17F85C0", VA = "0x1817F9BC0")]
		public bool CanMove(GridOrientation direction)
		{
			//Discarded unreachable code: IL_00b4
			int num = (int)direction;
			int length = spatialInformation.Length;
			if ((long)"{il2cpp array field local3->}" != 0)
			{
				if ((long)"{il2cpp array field local3->}" < 0)
				{
				}
				if ((long)"{il2cpp array field local3->}" != 0)
				{
					num += num;
					if (((long)"{il2cpp array field local3->}" != 0 && (long)"{il2cpp array field local3->}" != 0) || ((object)typeof(Item).TypeHandle != null && (object)typeof(Item).TypeHandle != null))
					{
						int num2 = 0;
					}
				}
			}
			SpatialInformation[] array = spatialInformation;
			int num3 = num + 1;
			if ((long)(IntPtr)array < 0L)
			{
				num3++;
			}
			int length2 = array.Length;
			num3 += num3;
			if ((long)"{il2cpp array field local10->}" == 0)
			{
				if ((long)"{il2cpp array field local10->}" < 0)
				{
					num3++;
				}
				num3 += num3;
				if ((long)"{il2cpp array field local10->}" != 0)
				{
				}
			}
			return (long)"{il2cpp array field local10->}" == 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6008672")]
		[Cpp2IlInjected.Address(RVA = "0x17FA9C0", Offset = "0x17F93C0", VA = "0x1817FA9C0")]
		static FenceModeUtility()
		{
			Array values = Enum.GetValues(typeof(GridOrientation));
			if (values == null)
			{
			}
			if (values != null)
			{
				FenceDirections = (GridOrientation[])values;
			}
			throw new InvalidCastException();
		}
	}
}
