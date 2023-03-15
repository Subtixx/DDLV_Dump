using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000668")]
	public interface IPriceOverrider
	{
		[Cpp2IlInjected.Token(Token = "0x17001349")]
		PriceOverride PriceOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6004A78")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
