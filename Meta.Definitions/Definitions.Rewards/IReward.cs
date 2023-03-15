using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x2000245")]
	public interface IReward
	{
		[Cpp2IlInjected.Token(Token = "0x170004C3")]
		string DebugDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x6001589")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600158A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CanGive(IRewardRecipient recipient);

		[Cpp2IlInjected.Token(Token = "0x600158B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Give(IRewardRecipient recipient, in PlayerProfile giverProfile, in WorldProfile receiverProfile, ITransactionContext context, [Optional] Item? characterItem, bool canSendToInbox = false);

		[Cpp2IlInjected.Token(Token = "0x600158C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int GetGivenItems(MultiItemInstance rewards);
	}
}
