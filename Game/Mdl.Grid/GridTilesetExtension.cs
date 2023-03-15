using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Mdl.Items;
using UnityEngine;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000489")]
	[ExecuteInEditMode]
	public class GridTilesetExtension : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001CB7")]
		private ItemScript itemScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001CB8")]
		private Item baseItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001CB9")]
		private GridArea baseItemGridArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001CBA")]
		private GridObjectScript gridObjectScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001CBB")]
		private GridScript gridScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001CBC")]
		private GridTilesetObjectCache gridTilesetObjectCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001CBD")]
		private GridPosition gridPosition;

		[Cpp2IlInjected.Token(Token = "0x600141A")]
		[Cpp2IlInjected.Address(RVA = "0x1543770", Offset = "0x1542170", VA = "0x181543770")]
		private void Start()
		{
			//IL_0091: Expected O, but got I4
			ItemScript itemScript = (this.itemScript = GetComponentInParent<ItemScript>());
			ItemScript itemScript2 = this.itemScript;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = itemScript2.Item;
			IItemIsVariationOf itemIsVariationOf = default(IItemIsVariationOf);
			baseItem = (Item)itemIsVariationOf;
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			Item item2 = baseItem;
			IGridPlaceableItemData itemData = _003CInstance_003Ek__BackingField2.GetItemData<IGridPlaceableItemData>(item2);
			GridObjectScript gridObjectScript = (this.gridObjectScript = base.gameObject.GetComponentInParent<GridObjectScript>());
			GridObjectScript gridObjectScript2 = this.gridObjectScript;
			EventHandler value = MoveTile;
			gridObjectScript2.OnTransformUpdate += value;
			GridScript _003CGridScript_003Ek__BackingField = this.gridObjectScript.GridScript;
			int num = 0;
			if (!(_003CGridScript_003Ek__BackingField == (UnityEngine.Object)num))
			{
				GridScript gridScript = (this.gridScript = this.gridObjectScript.GridScript);
				GridTilesetObjectCache gridTilesetObjectCache = (this.gridTilesetObjectCache = this.gridScript.GetOrAddComponent<GridTilesetObjectCache>());
				ApplyTile(add: true);
				GridObjectScript gridObjectScript3 = this.gridObjectScript;
				GridObjectScript.GridEditModeChangedDelegate value2 = Init;
				gridObjectScript3.GridObjectChangedEvent -= value2;
				return;
			}
			GridObjectScript gridObjectScript4 = this.gridObjectScript;
			GridObjectScript.GridEditModeChangedDelegate value3 = Init;
			gridObjectScript4.GridObjectChangedEvent += value3;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600141B")]
		[Cpp2IlInjected.Address(RVA = "0x1543760", Offset = "0x1542160", VA = "0x181543760")]
		private void OnDestroy()
		{
			int add = 0;
			ApplyTile((byte)add != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600141C")]
		[Cpp2IlInjected.Address(RVA = "0x1543590", Offset = "0x1541F90", VA = "0x181543590")]
		private void Init(GridObjectScript sender, bool editModeResynchronize)
		{
			//Discarded unreachable code: IL_0049
			GridScript gridScript = (this.gridScript = this.gridObjectScript.GridScript);
			GridTilesetObjectCache gridTilesetObjectCache = (this.gridTilesetObjectCache = this.gridScript.GetOrAddComponent<GridTilesetObjectCache>());
			ApplyTile(add: true);
			GridObjectScript gridObjectScript = this.gridObjectScript;
			GridObjectScript.GridEditModeChangedDelegate value = Init;
			gridObjectScript.GridObjectChangedEvent -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x600141D")]
		[Cpp2IlInjected.Address(RVA = "0x1543680", Offset = "0x1542080", VA = "0x181543680")]
		private void MoveTile(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_004c
			//IL_0010: Expected O, but got I4
			GridScript gridScript = this.gridScript;
			int num = 0;
			if (!(gridScript == (UnityEngine.Object)num))
			{
				int add = 0;
				ApplyTile((byte)add != 0);
				GridScript gridScript2 = (this.gridScript = gridObjectScript.GridScript);
				GridTilesetObjectCache gridTilesetObjectCache = (this.gridTilesetObjectCache = this.gridScript.GetOrAddComponent<GridTilesetObjectCache>());
				ApplyTile(add: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600141E")]
		[Cpp2IlInjected.Address(RVA = "0x1543300", Offset = "0x1541D00", VA = "0x181543300")]
		private void ApplyTile(bool add)
		{
			//Discarded unreachable code: IL_0067
			//IL_0066: Expected O, but got I4
			ItemScript itemScript = this.itemScript;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = itemScript.Item;
			GridScript gridScript = this.gridScript;
			Transform transform = base.transform;
			int num = 0;
			GridOrientation gridOrientation = default(GridOrientation);
			int num2 = (int)gridOrientation;
			if (add)
			{
				GridScript gridScript2 = this.gridScript;
				Transform transform2 = base.transform;
				GridPosition gridPosition = default(GridPosition);
				this.gridPosition = gridPosition;
			}
			if (num2 != 0 && (num2 == 0 || (num2 != 0 && num2 == 1)))
			{
				int num3 = 0;
				UpdateAdjacentTiles((GridPosition)num3);
			}
			[Cpp2IlInjected.Token(Token = "0x6001420")]
			[Cpp2IlInjected.Address(RVA = "0x1543B60", Offset = "0x1542560", VA = "0x181543B60")]
			void UpdateAdjacentTiles(GridPosition delta)
			{
				//Discarded unreachable code: IL_0026, IL_002c
				int num4 = 0;
				List<GridTilesetObject> cache = gridTilesetObjectCache.cache;
				GridPosition gridPosition2 = default(GridPosition);
				if ((object)gridPosition2 != null)
				{
					bool flag = default(bool);
					while (!flag)
					{
					}
					Item item2 = default(Item);
					while ((object)item2 == null)
					{
					}
					int num5 = 0;
					int num6 = 0;
				}
				if ((object)gridPosition2 == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600141F")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public GridTilesetExtension()
		{
		}
	}
}
