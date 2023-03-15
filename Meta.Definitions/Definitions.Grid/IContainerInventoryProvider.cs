using Cpp2IlInjected;
using Definitions.Items;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x200071A")]
	public interface IContainerInventoryProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6004EE4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		uint AddContainerInventory(Item parentItem, string containerInventoryDefaultData);

		[Cpp2IlInjected.Token(Token = "0x6004EE5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RemoveContainerInventory(uint containerInventoryID);
	}
}
