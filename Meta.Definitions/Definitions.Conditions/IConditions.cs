using System.Collections.Generic;
using Cpp2IlInjected;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007C8")]
	public interface IConditions
	{
		[Cpp2IlInjected.Token(Token = "0x17001590")]
		IEnumerable<ICondition> Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x600557C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
