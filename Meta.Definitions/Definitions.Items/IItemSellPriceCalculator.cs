using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006A4")]
	public interface IItemSellPriceCalculator
	{
		[Cpp2IlInjected.Token(Token = "0x6004AFA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CurrencyCost GetSellPrice(ItemState itemState);
	}
}
