using Cpp2IlInjected;
using Definitions.Conditions;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	public interface ITimeLimited
	{
		[Cpp2IlInjected.Token(Token = "0x170002D4")]
		ConditionDate StartDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB1")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002D5")]
		ConditionDate EndDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB2")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
