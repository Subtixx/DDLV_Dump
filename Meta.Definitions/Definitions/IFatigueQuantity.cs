using Cpp2IlInjected;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface IFatigueQuantity
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		int Quantity
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
