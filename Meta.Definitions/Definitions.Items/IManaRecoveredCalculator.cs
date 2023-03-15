using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006A5")]
	public interface IManaRecoveredCalculator
	{
		[Cpp2IlInjected.Token(Token = "0x6004AFB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GetManaRecovered(ItemState itemState);
	}
}
