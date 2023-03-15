using Cpp2IlInjected;
using Definitions.Items;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x200084D")]
	public interface IItemCondition
	{
		[Cpp2IlInjected.Token(Token = "0x1700176D")]
		string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005CEE")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool Evaluate(Item target);
	}
}
