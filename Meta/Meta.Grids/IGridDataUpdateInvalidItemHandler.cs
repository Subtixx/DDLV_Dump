using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Util;

namespace Meta.Grids
{
	[Cpp2IlInjected.Token(Token = "0x2001097")]
	internal interface IGridDataUpdateInvalidItemHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700176E")]
		int MaxNumberOfTries
		{
			[Cpp2IlInjected.Token(Token = "0x60086C8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60086C9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CanMoveInvalidObject(Item item, GridState gridState);

		[Cpp2IlInjected.Token(Token = "0x60086CA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int GetTryForObjectRemoval(Item item, GridState gridState, ITransactionContext context);

		[Cpp2IlInjected.Token(Token = "0x60086CB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Remove(Item item, GridState gridState, int tryNumber);

		[Cpp2IlInjected.Token(Token = "0x60086CC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PostUpdateValidation(Grid grid, Dictionary<GridPosition, List<GridObject>> checkGridCells, List<GridObject> removedObjects);
	}
}
