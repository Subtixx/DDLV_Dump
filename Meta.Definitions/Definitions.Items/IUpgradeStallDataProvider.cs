using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006A7")]
	public interface IUpgradeStallDataProvider
	{
		[Cpp2IlInjected.Token(Token = "0x17001383")]
		int RefreshCost
		{
			[Cpp2IlInjected.Token(Token = "0x6004AFE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001384")]
		int NumberOfSlots
		{
			[Cpp2IlInjected.Token(Token = "0x6004AFF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
