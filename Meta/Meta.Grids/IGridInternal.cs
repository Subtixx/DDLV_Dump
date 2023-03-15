using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;

namespace Meta.Grids
{
	[Cpp2IlInjected.Token(Token = "0x200108C")]
	internal interface IGridInternal : IGrid
	{
		[Cpp2IlInjected.Token(Token = "0x600867D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GridObject AddObject(Item item, in GridPosition position, GridOrientation orientation, GridState state, IWorldEventDispatcher dispatcher, bool automaticSpawning, [Optional] GridSource? source, [Optional] GridAddObjectOptions options);

		[Cpp2IlInjected.Token(Token = "0x600867E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CanAddObject(Item item, in GridPosition position, GridOrientation orientation, GridState state, IWorldEventDispatcher dispatcher, bool automaticSpawning, [Optional] GridSource? source, [Optional] GridAddObjectOptions options);

		[Cpp2IlInjected.Token(Token = "0x600867F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool RemoveObject(GridObject gridObject, in World world, bool automaticRemove = false);

		[Cpp2IlInjected.Token(Token = "0x6008680")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool UpdateTransform(GridObject gridObject, in GridPosition newGridPosition, GridOrientation newGridOrientation, IWorldEventDispatcher dispatcher);
	}
}
