using Cpp2IlInjected;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007CB")]
	public interface IMissionStep : IMissionItem
	{
		[Cpp2IlInjected.Token(Token = "0x17001593")]
		int StepID
		{
			[Cpp2IlInjected.Token(Token = "0x600557F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005580")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
}
