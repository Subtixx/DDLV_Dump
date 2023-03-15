using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Util;

namespace Meta.Grids
{
	[Cpp2IlInjected.Token(Token = "0x200108D")]
	public interface IGrid
	{
		[Cpp2IlInjected.Token(Token = "0x17001764")]
		uint ID
		{
			[Cpp2IlInjected.Token(Token = "0x6008681")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001765")]
		GridPosition Size
		{
			[Cpp2IlInjected.Token(Token = "0x6008682")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001766")]
		string GridDataPath
		{
			[Cpp2IlInjected.Token(Token = "0x6008683")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001767")]
		GridData GridData
		{
			[Cpp2IlInjected.Token(Token = "0x6008684")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001768")]
		GridFloorType AvailableFloorTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6008685")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001769")]
		IEnumerable<GridObject> Objects
		{
			[Cpp2IlInjected.Token(Token = "0x6008686")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6008687")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void Create(in WorldProfile worldProfile, ITransactionContext context);

		[Cpp2IlInjected.Token(Token = "0x6008688")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void Init();

		[Cpp2IlInjected.Token(Token = "0x6008689")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool CanExpandGridSize(string gridDataPath);

		[Cpp2IlInjected.Token(Token = "0x600868A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool ExpandGridSize(string gridDataPath);

		[Cpp2IlInjected.Token(Token = "0x600868B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool IsParentOf(IGrid subGrid);

		[Cpp2IlInjected.Token(Token = "0x600868C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool IsOnGrid(GridObject gridObject);

		[Cpp2IlInjected.Token(Token = "0x600868D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		int ObjectCount();

		[Cpp2IlInjected.Token(Token = "0x600868E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int ObjectCount(Item item);

		[Cpp2IlInjected.Token(Token = "0x600868F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		int ObjectCount(IEnumerable<Item> items);

		[Cpp2IlInjected.Token(Token = "0x6008690")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool TryGetObject(uint gridObjectID, out GridObject gridObject);

		[Cpp2IlInjected.Token(Token = "0x6008691")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool IsAreaInside(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea);

		[Cpp2IlInjected.Token(Token = "0x6008692")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool IsAreaValid(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, bool automaticSpawning);

		[Cpp2IlInjected.Token(Token = "0x6008693")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool IsAreaValidFor(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, bool automaticSpawning);

		[Cpp2IlInjected.Token(Token = "0x6008694")]
		[Cpp2IlInjected.Address(Slot = "19")]
		GridLayers GetLayersForPosition(in GridPosition gridPosition);

		[Cpp2IlInjected.Token(Token = "0x6008695")]
		[Cpp2IlInjected.Address(Slot = "20")]
		List<GridObject> GetGridObjectsForPosition(in GridPosition gridPosition);

		[Cpp2IlInjected.Token(Token = "0x6008696")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool HasConflicts(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, bool automaticSpawning, [Optional] Item? clearedBy, GridCellConflict conflictsToCheck = GridCellConflict.All);

		[Cpp2IlInjected.Token(Token = "0x6008697")]
		[Cpp2IlInjected.Address(Slot = "22")]
		(bool, GridCellConflict) GetConflicts(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, bool automaticSpawning, [Optional] Item? clearedBy, GridCellConflict conflictsToCheck = GridCellConflict.All);

		[Cpp2IlInjected.Token(Token = "0x6008698")]
		[Cpp2IlInjected.Address(Slot = "23")]
		(bool, GridCellConflict, GridCellConflict[][]) GetConflictedCells(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, bool automaticSpawning, [Optional] Item? clearedBy);

		[Cpp2IlInjected.Token(Token = "0x6008699")]
		[Cpp2IlInjected.Address(Slot = "24")]
		List<GridObject> GetConflictedObjects(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject);

		[Cpp2IlInjected.Token(Token = "0x600869A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		IGrid Clone();
	}
}
