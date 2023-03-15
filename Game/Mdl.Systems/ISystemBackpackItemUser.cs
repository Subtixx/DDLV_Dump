using Cpp2IlInjected;
using Definitions.Items;

namespace Mdl.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000970")]
	public interface ISystemBackpackItemUser
	{
		[Cpp2IlInjected.Token(Token = "0x6002BC8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CanUseItem(Item item);

		[Cpp2IlInjected.Token(Token = "0x6002BC9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UseItem(uint containerInventoryID, int containerInventoryPosition);
	}
}
