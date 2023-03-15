using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Mdl.Graphic;
using Mdl.Items;
using Mdl.Systems;
using Meta.Grids;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x200048A")]
	[ExecuteInEditMode]
	public class GridTilesetObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4001CBE")]
		private static int[] tileMaskToIndex = new int[256];

		[Cpp2IlInjected.Token(Token = "0x4001CBF")]
		private static GridPosition[] adjacentTileOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001CC0")]
		public GridTilesetDef[] TilesetDefs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001CC1")]
		public NavMeshModifierVolume modifierVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001CC2")]
		public Transform VisualParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001CC3")]
		private int oldTileIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001CC4")]
		private GridEditMode gridEditModeSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001CC5")]
		private GridObjectScript gridObjectScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001CC6")]
		private GridScript gridScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001CC7")]
		private GridScript oldGridScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001CC8")]
		private GridTilesetObjectCache _gridTilesetObjectCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001CC9")]
		private ItemScript itemScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001CCA")]
		private HashSet<Item> extensionItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001CCB")]
		private List<GameObject> currentTiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001CCC")]
		private GridArea gridArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001CCD")]
		private GridOrientation gridOrientation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4001CCE")]
		public GridPosition gridPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4001CCF")]
		public int tileIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001CD0")]
		private bool[] orthogonalCheck = new bool[4];

		[Cpp2IlInjected.Token(Token = "0x17000285")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001422")]
			[Cpp2IlInjected.Address(RVA = "0x1549E20", Offset = "0x1548820", VA = "0x181549E20")]
			get
			{
				return itemScript?.Item ?? Item.Invalid;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000286")]
		private GridTilesetObjectCache gridTilesetObjectCache
		{
			[Cpp2IlInjected.Token(Token = "0x6001423")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return _gridTilesetObjectCache;
			}
			[Cpp2IlInjected.Token(Token = "0x6001424")]
			[Cpp2IlInjected.Address(RVA = "0x1549EA0", Offset = "0x15488A0", VA = "0x181549EA0")]
			set
			{
				//Discarded unreachable code: IL_0062
				//IL_001f: Expected O, but got I4
				//IL_004d: Expected O, but got I4
				if (_gridTilesetObjectCache != value)
				{
					GridTilesetObjectCache gridTilesetObjectCache = _gridTilesetObjectCache;
					int num = 0;
					if (gridTilesetObjectCache != (UnityEngine.Object)num)
					{
						bool flag = ((List<T>)(object)_gridTilesetObjectCache.cache).Remove((T)this);
					}
					_gridTilesetObjectCache = value;
					GridTilesetObjectCache gridTilesetObjectCache2 = _gridTilesetObjectCache;
					int num2 = 0;
					if (gridTilesetObjectCache2 != (UnityEngine.Object)num2)
					{
						((List<T>)(object)_gridTilesetObjectCache.cache).Add((T)this);
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001421")]
		[Cpp2IlInjected.Address(RVA = "0x1546F80", Offset = "0x1545980", VA = "0x181546F80")]
		[RuntimeInitializeOnLoadMethod]
		public static void InitTileMask()
		{
			//Discarded unreachable code: IL_02ac
			//IL_002b: Expected I4, but got I8
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			//IL_0067: Expected I8, but got I4
			//IL_009f: Expected I8, but got I4
			//IL_00d3: Expected I8, but got I4
			//IL_0107: Expected I8, but got I4
			//IL_013b: Expected I8, but got I4
			//IL_016f: Expected I8, but got I4
			//IL_01a7: Expected I8, but got I4
			//IL_01d2: Expected I8, but got I4
			//IL_0207: Expected I8, but got I4
			//IL_0240: Expected I8, but got I4
			//IL_0275: Expected I8, but got I4
			int num = 0;
			if (num == 0)
			{
				tileMaskToIndex[0] = num;
			}
			int[] array = tileMaskToIndex;
			ulong num2 = num2 + num2;
			long num3 = (long)(num2 * 255);
			uint num4 = (uint)((int)num4 - num3);
			array[0] = 1;
			int[] array2 = tileMaskToIndex;
			ulong num5 = num5 + num5;
			long num6 = (long)(num5 * 255);
			array = (int[])(array - num6);
			array2[0] = 2;
			int[] array3 = tileMaskToIndex;
			long num7 = (int)(num4 * 7);
			ulong num8 = num8 + num8;
			long num9 = (long)(num8 * 255);
			num7 -= num9;
			num9 = num7;
			array3[0] = 3;
			if (num < 2)
			{
				int[] array4 = tileMaskToIndex;
				long num10 = (int)(num4 * 17);
				ulong num11 = num11 + num11;
				long num12 = (long)(num11 * 255);
				num10 -= num12;
				num12 = num10;
				array4[0] = 4;
			}
			int[] array5 = tileMaskToIndex;
			long num13 = (int)(num4 * 21);
			ulong num14 = num14 + num14;
			long num15 = (long)(num14 * 255);
			num13 -= num15;
			num15 = num13;
			array5[0] = 5;
			int[] array6 = tileMaskToIndex;
			long num16 = (int)(num4 * 23);
			ulong num17 = num17 + num17;
			long num18 = (long)(num17 * 255);
			num16 -= num18;
			num18 = num16;
			array6[0] = 6;
			int[] array7 = tileMaskToIndex;
			long num19 = (int)(num4 * 29);
			ulong num20 = num20 + num20;
			long num21 = (long)(num20 * 255);
			num19 -= num21;
			num21 = num19;
			array7[0] = 7;
			int[] array8 = tileMaskToIndex;
			long num22 = (int)(num4 * 31);
			ulong num23 = num23 + num23;
			long num24 = (long)(num23 * 255);
			num22 -= num24;
			num24 = num22;
			array8[0] = 8;
			if (num == 0)
			{
				int[] array9 = tileMaskToIndex;
				long num25 = (int)(num4 * 85);
				ulong num26 = num26 + num26;
				long num27 = (long)(num26 * 255);
				num25 -= num27;
				num27 = num25;
			}
			int[] array10 = tileMaskToIndex;
			long num28 = (int)(num4 * 87);
			ulong num29 = num29 + num29;
			long num30 = (long)(num29 * 255);
			num28 -= num30;
			num30 = num28;
			array10[0] = 10;
			int[] array11 = tileMaskToIndex;
			long num31 = (int)(num4 * 95);
			ulong num32 = num32 + num32;
			long num33 = (long)(num32 * 255);
			num31 -= num33;
			num33 = num31;
			array11[0] = 11;
			if (num < 2)
			{
				int[] array12 = tileMaskToIndex;
				long num34 = (int)(num4 * 119);
				ulong num35 = num35 + num35;
				long num36 = (long)(num35 * 255);
				num34 -= num36;
				num36 = num34;
				array12[0] = 12;
			}
			int[] array13 = tileMaskToIndex;
			long num37 = (int)(num4 * 127);
			ulong num38 = num38 + num38;
			long num39 = (long)(num38 * 255);
			num37 -= num39;
			num39 = num37;
			array13[0] = 13;
			if (num == 0)
			{
				int[] array14 = tileMaskToIndex;
			}
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6001425")]
		[Cpp2IlInjected.Address(RVA = "0x1548450", Offset = "0x1546E50", VA = "0x181548450")]
		private void Start()
		{
			//Discarded unreachable code: IL_00ad, IL_00b3, IL_00b9
			//IL_001a: Expected O, but got I4
			int num = 0;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				GridEditMode system = _003CInstance_003Ek__BackingField.GetSystem<GridEditMode>();
			}
			gridEditModeSystem = (GridEditMode)num;
			ItemScript itemScript = (this.itemScript = GetComponentInParent<ItemScript>());
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			Item item = this.itemScript.Item;
			Func<IItemIsVariationOf, bool> func = (Func<IItemIsVariationOf, bool>)(object)(Func<T, TResult>)delegate
			{
				Item item2 = this.itemScript.Item;
				throw new NullReferenceException();
			};
			IEnumerable<> enumerable = default(IEnumerable<>);
			IEnumerable<IItemIsVariationOf> enumerable2 = (IEnumerable<IItemIsVariationOf>)Enumerable.Where<IItemIsVariationOf>(enumerable, (Func<, >)(object)func);
			Func<IItemIsVariationOf, Item> func2 = default(Func<IItemIsVariationOf, Item>);
			if (_003C_003Ec._003C_003E9__24_1 == null)
			{
				func2 = (Func<IItemIsVariationOf, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					if ((object)typeof(IItemData).TypeHandle != null && (object)typeof(IItemData).TypeHandle != null)
					{
						throw new NullReferenceException();
					}
					throw new InvalidCastException();
				});
			}
			HashSet<Item> hashSet = (extensionItems = (HashSet<Item>)(object)new HashSet<T>((IEqualityComparer<>)Enumerable.Select<IItemIsVariationOf, Item>((IEnumerable<>)enumerable2, (Func<, >)(object)func2)));
			GameObject gameObject = default(GameObject);
			GridObjectScript componentInParent = gameObject.GetComponentInParent<GridObjectScript>();
			EventHandler eventHandler = default(EventHandler);
			MethodInfo method_info = ((Delegate)eventHandler).method_info;
			bool flag = default(bool);
			if (!flag)
			{
				int num2 = 0;
				int num3 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001426")]
		[Cpp2IlInjected.Address(RVA = "0x1547680", Offset = "0x1546080", VA = "0x181547680")]
		private void Init(object sender, bool e)
		{
			//Discarded unreachable code: IL_0077, IL_007d, IL_0083
			//IL_0057: Expected O, but got I4
			int num = 0;
			GridTilesetDef[] tilesetDefs = TilesetDefs;
			int capacity = default(int);
			List<GameObject> list = (List<GameObject>)(object)new List<T>(capacity);
			capacity = tilesetDefs.Length;
			currentTiles = list;
			GridScript gridScript = (this.gridScript = this.gridObjectScript.GridScript);
			GridTilesetObjectCache gridTilesetObjectCache = (this.gridTilesetObjectCache = this.gridScript.GetOrAddComponent<GridTilesetObjectCache>());
			int num2 = 0;
			ApplyTile(updateAdjacentTiles: true, -1, (GridObject)num2);
			GridObjectScript gridObjectScript = this.gridObjectScript;
			GridObjectScript.GridEditModeChangedDelegate value = Init;
			gridObjectScript.GridObjectChangedEvent -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x6001427")]
		[Cpp2IlInjected.Address(RVA = "0x1546C50", Offset = "0x1545650", VA = "0x181546C50")]
		private GridObject FindCompatibleAdjacent(List<GridObject> adjacentObjs, GridPosition adjacentTilePos, bool editGrid)
		{
			//Discarded unreachable code: IL_0098, IL_009e, IL_00a4, IL_00aa, IL_00b0
			//IL_0017: Expected O, but got I4
			//IL_003e: Expected O, but got I4
			//IL_003e: Expected O, but got I4
			int num3;
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				num3 = 0;
				if (adjacentObjs == null)
				{
					break;
				}
				if (flag)
				{
					if (!IsCompatible((GridObject)num2, adjacentTilePos))
					{
						continue;
					}
					num3++;
				}
				num3++;
				if (num3 == 0)
				{
				}
				break;
			}
			if (editGrid)
			{
				if ((object)gridEditModeSystem != null)
				{
				}
				int num4 = 0;
				if ((UnityEngine.Object)num3 != (UnityEngine.Object)num4)
				{
					GridObject _003CGridObject_003Ek__BackingField = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject.GridObject;
					if (IsCompatible(_003CGridObject_003Ek__BackingField, adjacentTilePos))
					{
						GridScript _003CGridScript_003Ek__BackingField = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject.GridScript;
						GridScript gridScript = this.gridScript;
						if (_003CGridScript_003Ek__BackingField == gridScript)
						{
							GridObjectScript selectedGridObject = ((GridObjectGizmoSystem)gridEditModeSystem)._selectedGridObject;
						}
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001428")]
		[Cpp2IlInjected.Address(RVA = "0x15469E0", Offset = "0x15453E0", VA = "0x1815469E0")]
		private GridTilesetObject FindCompatibleAdjacentGridTilesetObject(GridPosition adjacentTilePos)
		{
			//Discarded unreachable code: IL_0037, IL_003d, IL_0043, IL_0049
			int num = 0;
			GridTilesetObjectCache gridTilesetObjectCache = _gridTilesetObjectCache;
			List<GridTilesetObject> cache = gridTilesetObjectCache.cache;
			if ((object)gridTilesetObjectCache != null)
			{
				bool flag = default(bool);
				while (!flag)
				{
				}
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				num++;
			}
			num++;
			int num2 = 0;
			if ((object)gridTilesetObjectCache != null)
			{
			}
			if (num != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001429")]
		[Cpp2IlInjected.Address(RVA = "0x1548A70", Offset = "0x1547470", VA = "0x181548A70")]
		public void UpdateGridAreaOrientationPosition()
		{
			//Discarded unreachable code: IL_0050, IL_0056, IL_005c, IL_0062
			int num = 0;
			GridObjectScript gridObjectScript = this.gridObjectScript;
			if ((object)gridObjectScript != null && gridObjectScript.GridObject != null)
			{
				GridScript gridScript = this.gridScript;
				Transform transform = base.transform;
				GridOrientation gridOrientation = default(GridOrientation);
				this.gridOrientation = gridOrientation;
				GridScript gridScript2 = this.gridScript;
				Transform transform2 = base.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				GridPosition gridPosition = default(GridPosition);
				this.gridPosition = gridPosition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600142A")]
		[Cpp2IlInjected.Address(RVA = "0x1546050", Offset = "0x1544A50", VA = "0x181546050")]
		public void ApplyTile(bool updateAdjacentTiles, int movedTileRelativeIndex = -1, [Optional] GridObject centerTile)
		{
			//Discarded unreachable code: IL_01fb, IL_0201, IL_0207, IL_020d, IL_0219, IL_021f, IL_0225, IL_022b, IL_0231, IL_0237, IL_023d, IL_0243, IL_0249, IL_024f, IL_0255, IL_025b, IL_0261, IL_0267, IL_026d, IL_0273, IL_0279, IL_027f, IL_0285, IL_028b, IL_0291, IL_0297, IL_029d, IL_02a3, IL_02a9
			//IL_0016: Expected O, but got I4
			//IL_010f: Expected O, but got I4
			//IL_0137: Expected O, but got I4
			//IL_01b9: Expected O, but got I4
			//IL_01d9: Expected O, but got I4
			uint num4 = default(uint);
			uint num6 = default(uint);
			uint num9 = default(uint);
			bool flag = default(bool);
			uint num13 = default(uint);
			GridTilesetObject gridTilesetObject = default(GridTilesetObject);
			uint num15 = default(uint);
			uint num16 = default(uint);
			uint num17 = default(uint);
			GridTilesetObject gridTilesetObject2 = default(GridTilesetObject);
			uint num24 = default(uint);
			GridObject gridObject = default(GridObject);
			uint num25 = default(uint);
			GridObject gridObject2 = default(GridObject);
			uint num26 = default(uint);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				GridEditMode gridEditMode = gridEditModeSystem;
				int num3 = 0;
				if (gridEditMode != (UnityEngine.Object)num3)
				{
					GridEditMode gridEditMode2 = gridEditModeSystem;
				}
				GridObjectScript gridObjectScript = this.gridObjectScript;
				int num8;
				if ((object)gridObjectScript != null && (long)gridObjectScript.GridObject != 0)
				{
					UpdateGridAreaOrientationPosition();
					GridScript gridScript = this.gridScript;
					GridOrientation gridOrientation = this.gridOrientation;
					GridObject _003CGridObject_003Ek__BackingField = this.gridObjectScript.GridObject;
					if (num4 == 0 || gridScript.EditGrid == null)
					{
						IGrid _003CGrid_003Ek__BackingField = gridScript.Grid;
					}
					int num5 = 0;
					if (num5 < (int)num6)
					{
						num5 += num5;
						num5++;
					}
					if (num5 != 0)
					{
					}
					int num7 = 0;
					UpdateTile(num7);
					num7 += num7;
					num5 += 600;
					num8 = 0;
					if (num2 != 0)
					{
						break;
					}
					if (num9 != 0)
					{
					}
					int num10 = 0;
					if (num8 < 8)
					{
						GridPosition[] array = adjacentTileOffsets;
						num8 += 4;
						int num11 = 0;
						bool isPlaying = Application.isPlaying;
						int num12 = 0;
						if (Application.isPlaying)
						{
						}
						if (flag)
						{
							num8 += (int)num13;
							num8 -= (int)num13;
							int num14 = 0;
							if (!(gridTilesetObject != (UnityEngine.Object)num14))
							{
								goto IL_013d;
							}
							num8 += (int)num15;
							num8 -= (int)num15;
							num16 += (uint)num8;
							int updateAdjacentTiles2 = 0;
							gridTilesetObject.ApplyTile((byte)updateAdjacentTiles2 != 0, (int)num16, (GridObject)num10);
						}
						num8 += 2;
						goto IL_013d;
					}
					goto IL_0156;
				}
				goto IL_01f3;
				IL_0156:
				if ((int)num17 < 8)
				{
					uint num18 = num17 - 1;
					num18 -= (uint)num8;
					uint num19 = num17 + 1;
					num19 -= num18;
					num19++;
					num18 = num19;
					GridPosition[] array2 = adjacentTileOffsets;
					num17 += 4;
					int num20 = 0;
					bool isPlaying2 = Application.isPlaying;
					int num21 = 0;
					if (Application.isPlaying)
					{
					}
					int num22 = 0;
					int movedTileRelativeIndex2 = 0;
					int num23 = 0;
					if (gridTilesetObject2 != (UnityEngine.Object)num23)
					{
						num8 += (int)num24;
						if ((int)num17 > 3)
						{
						}
						int updateAdjacentTiles3 = 0;
						gridTilesetObject2.ApplyTile((byte)updateAdjacentTiles3 != 0, movedTileRelativeIndex2, (GridObject)num22);
						num17 += 2;
					}
					while (gridObject == null)
					{
					}
					num8 += (int)num25;
					num17 += 2;
				}
				goto IL_01f3;
				IL_01f3:
				if (num2 == 0)
				{
					return;
				}
				continue;
				IL_013d:
				while (gridObject2 == null)
				{
				}
				num8 += (int)num26;
				num8 -= (int)num26;
				num8 += 2;
				goto IL_0156;
			}
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x600142B")]
		[Cpp2IlInjected.Address(RVA = "0x1547F70", Offset = "0x1546970", VA = "0x181547F70")]
		private void RemoveTile()
		{
			//Discarded unreachable code: IL_0105, IL_010b, IL_0111, IL_0117, IL_011d, IL_0123, IL_0129, IL_012f, IL_0135, IL_013b, IL_0141, IL_0147, IL_014d, IL_0153, IL_0159, IL_015f, IL_0165, IL_016b
			//IL_0012: Expected O, but got I4
			//IL_0050: Expected O, but got I4
			//IL_0071: Expected O, but got I4
			//IL_00e1: Expected O, but got I4
			//IL_00fd: Expected O, but got I4
			int num = 0;
			GridEditMode gridEditMode = gridEditModeSystem;
			int num2 = 0;
			if (gridEditMode != (UnityEngine.Object)num2)
			{
			}
			bool[] array = new bool[4];
			int num3 = default(int);
			if (num < 8)
			{
				GridPosition[] array2 = adjacentTileOffsets;
				GridTilesetDef gridTilesetDef = TilesetDefs[0];
				num += 4;
				GridPosition adjacentTilePos = default(GridPosition);
				GridTilesetObject gridTilesetObject = FindCompatibleAdjacentGridTilesetObject(adjacentTilePos);
				num3 = 0;
				if (gridTilesetObject != (UnityEngine.Object)num3)
				{
					num -= num3;
					uint num4 = num4 + (uint)num;
					int num5 = 0;
					int updateAdjacentTiles = 0;
					gridTilesetObject.ApplyTile((byte)updateAdjacentTiles != 0, (int)num4, (GridObject)num5);
				}
				num += 2;
			}
			uint num6 = default(uint);
			if ((int)num6 >= 8)
			{
				return;
			}
			uint num7 = num6 - 1;
			num7 -= (uint)num3;
			int length = array.Length;
			uint num8 = num6 + 1;
			num8 -= num7;
			num8++;
			num7 = num8;
			GridPosition[] array3 = adjacentTileOffsets;
			GridTilesetDef gridTilesetDef2 = TilesetDefs[0];
			num6 += 4;
			GridPosition adjacentTilePos2 = default(GridPosition);
			GridTilesetObject gridTilesetObject2 = FindCompatibleAdjacentGridTilesetObject(adjacentTilePos2);
			int movedTileRelativeIndex = 0;
			int num9 = 0;
			if (gridTilesetObject2 != (UnityEngine.Object)num9)
			{
				if ((int)num6 > 3)
				{
				}
				int num10 = 0;
				int updateAdjacentTiles2 = 0;
				gridTilesetObject2.ApplyTile((byte)updateAdjacentTiles2 != 0, movedTileRelativeIndex, (GridObject)num10);
			}
			num6 += 2;
		}

		[Cpp2IlInjected.Token(Token = "0x600142C")]
		[Cpp2IlInjected.Address(RVA = "0x1547840", Offset = "0x1546240", VA = "0x181547840")]
		private bool IsCompatibleItem(Item item)
		{
			//Discarded unreachable code: IL_0019
			if ((object)itemScript.Item != null)
			{
				return true;
			}
			HashSet<Item> hashSet = extensionItems;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600142D")]
		[Cpp2IlInjected.Address(RVA = "0x15478F0", Offset = "0x15462F0", VA = "0x1815478F0")]
		private bool IsCompatible(GridObject gridObject, GridPosition forPosition)
		{
			//Discarded unreachable code: IL_006c, IL_0072, IL_0078
			int num = 0;
			int itemID = gridObject.ItemID;
			if ((object)itemScript.Item == null)
			{
				HashSet<Item> hashSet = extensionItems;
				int itemID2 = gridObject.ItemID;
				bool flag = default(bool);
				if (flag)
				{
					GridPosition gridPosition = default(GridPosition);
					if ((object)gridPosition != null && ((object)gridPosition != null || gridObject.orientation_ == (GridOrientation)(-3)))
					{
						int num2 = 0;
					}
					if ((object)gridPosition == null)
					{
					}
					GridOrientation orientation_ = gridObject.orientation_;
					if (orientation_ == GridOrientation.Left)
					{
					}
					bool flag2 = orientation_ == GridOrientation.Right;
					int num3 = 0;
				}
				int num4 = 0;
			}
			GridPosition position = gridObject.Position;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600142E")]
		[Cpp2IlInjected.Address(RVA = "0x1548C30", Offset = "0x1547630", VA = "0x181548C30")]
		private void UpdateTile(int tileMask)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600142F")]
		[Cpp2IlInjected.Address(RVA = "0x1547BC0", Offset = "0x15465C0", VA = "0x181547BC0")]
		private void MoveTile(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_004d
			//IL_0010: Expected O, but got I4
			//IL_004c: Expected O, but got I4
			GridScript gridScript = this.gridScript;
			int num = 0;
			if (!(gridScript == (UnityEngine.Object)num))
			{
				RemoveTile();
				GridScript gridScript2 = (this.gridScript = gridObjectScript.GridScript);
				GridTilesetObjectCache gridTilesetObjectCache = (this.gridTilesetObjectCache = this.gridScript.GetOrAddComponent<GridTilesetObjectCache>());
				int num2 = 0;
				ApplyTile(updateAdjacentTiles: true, -1, (GridObject)num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001430")]
		[Cpp2IlInjected.Address(RVA = "0x1547CA0", Offset = "0x15466A0", VA = "0x181547CA0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_00f5
			//IL_0015: Expected O, but got I4
			//IL_0034: Expected O, but got I4
			//IL_0086: Expected O, but got I4
			//IL_00b8: Expected O, but got I4
			//IL_00c6: Expected O, but got I4
			GridTilesetManager component = gridScript.GetComponent<GridTilesetManager>();
			int num = 0;
			if (component != (UnityEngine.Object)num && component.isQuitting)
			{
				return;
			}
			GridObjectScript gridObjectScript = this.gridObjectScript;
			int num2 = 0;
			if (gridObjectScript != (UnityEngine.Object)num2)
			{
				GridObjectScript gridObjectScript2 = this.gridObjectScript;
				EventHandler value = MoveTile;
				gridObjectScript2.OnTransformUpdate -= value;
				GridObjectScript gridObjectScript3 = this.gridObjectScript;
				GridObjectScript.GridEditModeChangedDelegate value2 = Init;
				gridObjectScript3.GridObjectChangedEvent -= value2;
			}
			RemoveTile();
			int num3 = 0;
			gridTilesetObjectCache = (GridTilesetObjectCache)num3;
			GridTilesetDef[] tilesetDefs = TilesetDefs;
			int num4 = 0;
			if (num4 >= tilesetDefs.Length)
			{
				return;
			}
			GameObject tileTemplate = tilesetDefs[num4].TileTemplate;
			int num5 = 0;
			if (tileTemplate != (UnityEngine.Object)num5)
			{
				int num6 = 0;
				if (component != (UnityEngine.Object)num6)
				{
					Material material = TilesetDefs[num4].material;
					component.RemoveTile(material, this);
				}
			}
			GridTilesetDef[] tilesetDefs2 = TilesetDefs;
			num4++;
		}

		[Cpp2IlInjected.Token(Token = "0x6001431")]
		[Cpp2IlInjected.Address(RVA = "0x1549DC0", Offset = "0x15487C0", VA = "0x181549DC0")]
		public GridTilesetObject()
		{
		}//IL_0010: Expected I4, but got I8


		[Cpp2IlInjected.Token(Token = "0x6001432")]
		[Cpp2IlInjected.Address(RVA = "0x1549B40", Offset = "0x1548540", VA = "0x181549B40")]
		static GridTilesetObject()
		{
			//Discarded unreachable code: IL_005f
			GridPosition[] array = new GridPosition[8];
			int num = 0;
			array[0] = (GridPosition)array;
			array[1] = (GridPosition)array;
			array[2] = (GridPosition)array;
			array[3] = (GridPosition)array;
			array[4] = (GridPosition)array;
			array[5] = (GridPosition)array;
			array[6] = (GridPosition)array;
			array[7] = (GridPosition)array;
			tileMaskToIndex = (int[])(object)array;
		}
	}
}
