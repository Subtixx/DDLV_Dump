using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x2000244")]
	public interface IRewardRecipient
	{
		[Cpp2IlInjected.Token(Token = "0x6001586")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CanAddItem(Item item, int amount, [Optional] ItemState state);

		[Cpp2IlInjected.Token(Token = "0x6001587")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AddItem(Item item, int amount, IProfileEventDispatcher dispatcher, ITransactionContext context, [Optional] Item? characterItem, [Optional] ItemState state, bool canSendToInbox = false);

		[Cpp2IlInjected.Token(Token = "0x6001588")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void AddCharacterFriendship(Item item, int amount, FriendshipSource source, in PlayerProfile giverProfile, in WorldProfile receiverProfile, ITransactionContext context);
	}
}
