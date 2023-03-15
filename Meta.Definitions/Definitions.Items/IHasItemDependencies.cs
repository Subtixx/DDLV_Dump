using System.Collections.Generic;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200067D")]
	public interface IHasItemDependencies
	{
		[Cpp2IlInjected.Token(Token = "0x17001356")]
		List<ItemType> ExclusiveItemTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6004AB7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001357")]
		bool AreItemsExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x6004AB8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001358")]
		List<Item> ItemDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x6004AB9")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
}
