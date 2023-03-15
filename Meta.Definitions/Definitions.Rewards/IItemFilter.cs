using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x200023B")]
	public interface IItemFilter
	{
		[Cpp2IlInjected.Token(Token = "0x6001571")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Filter(ItemDatabase itemDb, List<ItemWithState> list);

		[Cpp2IlInjected.Token(Token = "0x6001572")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FilterOut(ItemDatabase itemDb, List<ItemWithState> list);
	}
}
