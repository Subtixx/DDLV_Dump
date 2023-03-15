using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000659")]
	public interface IHasCurrencyGlotIDs
	{
		[Cpp2IlInjected.Token(Token = "0x17001322")]
		uint CurrencyGlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6004A50")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001323")]
		uint CurrencyTypeGlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6004A51")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
