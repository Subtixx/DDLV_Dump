using Cpp2IlInjected;
using Definitions.Items;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x200023E")]
	public interface ISubTypeFilter
	{
		[Cpp2IlInjected.Token(Token = "0x6001579")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool IsValid(ItemDatabase itemDb, Item item);
	}
}
