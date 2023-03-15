using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200099B")]
	public interface IInventory
	{
		[Cpp2IlInjected.Token(Token = "0x600544B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Dictionary<(Item, ItemState), int> GetAllItems();
	}
}
