using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006A0")]
	public interface IItemGeneratorOwner
	{
		[Cpp2IlInjected.Token(Token = "0x6004AF7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(ItemType, ActivityItemType?) GetItemGeneratorParameters();
	}
}
