using Cpp2IlInjected;
using Definitions.Options;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A5C")]
	internal interface IDynamicTransactionPriority
	{
		[Cpp2IlInjected.Token(Token = "0x17000EC1")]
		TransactionPriorityOptions.Types.Priority? Priority
		{
			[Cpp2IlInjected.Token(Token = "0x6005928")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
