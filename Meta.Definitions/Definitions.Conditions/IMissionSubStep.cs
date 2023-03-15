using Cpp2IlInjected;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007CC")]
	public interface IMissionSubStep : IMissionStep, IMissionItem
	{
		[Cpp2IlInjected.Token(Token = "0x17001594")]
		int SubStepID
		{
			[Cpp2IlInjected.Token(Token = "0x6005581")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005582")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
}
