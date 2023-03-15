using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200032C")]
	public class CollectionTooltipEnergySellPrice : CollectionTooltip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000F1D")]
		public CollectionTooltipElement Energy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000F1E")]
		public CollectionTooltipElement SellPrice;

		[Cpp2IlInjected.Token(Token = "0x600143D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CollectionTooltipEnergySellPrice()
		{
		}
	}
}
