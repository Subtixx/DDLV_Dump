using System.Collections.Generic;
using Cpp2IlInjected;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x200084E")]
	public interface IItemConditions
	{
		[Cpp2IlInjected.Token(Token = "0x1700176E")]
		IEnumerable<IItemCondition> Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x6005CEF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
