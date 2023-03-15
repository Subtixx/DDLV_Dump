using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006D3")]
	public interface IItemInstance : IItemWithState
	{
		[Cpp2IlInjected.Token(Token = "0x1700139E")]
		int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x6004C1D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
