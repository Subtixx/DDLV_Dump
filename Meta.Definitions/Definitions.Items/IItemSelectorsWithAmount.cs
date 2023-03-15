using System.Collections.Generic;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200068A")]
	public interface IItemSelectorsWithAmount
	{
		[Cpp2IlInjected.Token(Token = "0x17001366")]
		IEnumerable<AnyItemSelectorWithAmount> ItemSelectorsWithAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6004AD5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
