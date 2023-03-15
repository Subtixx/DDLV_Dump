using Cpp2IlInjected;
using Definitions.Grid;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x200045E")]
	public interface IGridMovementRestriction
	{
		[Cpp2IlInjected.Token(Token = "0x17000255")]
		GridPosition Position
		{
			[Cpp2IlInjected.Token(Token = "0x60012B9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000256")]
		GridPosition Size
		{
			[Cpp2IlInjected.Token(Token = "0x60012BA")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000257")]
		GridOrientation DefaultOrientation
		{
			[Cpp2IlInjected.Token(Token = "0x60012BB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000258")]
		GridFloorType AvailableGridFloorTypes
		{
			[Cpp2IlInjected.Token(Token = "0x60012BC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60012BD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Select();

		[Cpp2IlInjected.Token(Token = "0x60012BE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void RestrictMovement(ref GridPosition mainGridPosition, GridOrientation gridOrientation, GridArea gridArea);

		[Cpp2IlInjected.Token(Token = "0x60012BF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void Deselect();
	}
}
