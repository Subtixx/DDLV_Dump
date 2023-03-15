using Cpp2IlInjected;
using Definitions.Grid;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000653")]
	public interface IGridPlaceableItemData
	{
		[Cpp2IlInjected.Token(Token = "0x1700131B")]
		GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x6004A42")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
