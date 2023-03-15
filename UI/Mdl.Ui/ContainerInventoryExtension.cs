using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Meta;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000833")]
	public static class ContainerInventoryExtension
	{
		[Cpp2IlInjected.Token(Token = "0x6003417")]
		[Cpp2IlInjected.Address(RVA = "0x14A3460", Offset = "0x14A1E60", VA = "0x1814A3460")]
		[IteratorStateMachine(typeof(_003CGetItemsToDisplay_003Ed__0))]
		public static IEnumerable<(Item, ItemState, int, bool)> GetItemsToDisplay(this ContainerInventory containerInventory)
		{
			new _003CGetItemsToDisplay_003Ed__0(-2)._003C_003E3__containerInventory = containerInventory;
			throw new NullReferenceException();
		}
	}
}
