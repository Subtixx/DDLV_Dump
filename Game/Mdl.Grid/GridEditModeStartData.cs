using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x200045A")]
	public class GridEditModeStartData : ISystemData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001BB0")]
		public GridObjectScript InitialSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001BB1")]
		public ItemFilterData ItemFilters;

		[Cpp2IlInjected.Token(Token = "0x60012B1")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public GridEditModeStartData()
		{
		}
	}
}
