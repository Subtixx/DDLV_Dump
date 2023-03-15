using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000679")]
	public interface IGenericBuyable
	{
		[Cpp2IlInjected.Token(Token = "0x17001352")]
		Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6004AB1")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001353")]
		Item DefaultCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004AB2")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
