using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006A9")]
	public interface IItemIsVariationAmountModifier
	{
		[Cpp2IlInjected.Token(Token = "0x6004B02")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GetAmountOfVariation(int amount);
	}
}
