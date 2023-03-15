using Cpp2IlInjected;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007CD")]
	public interface IMissionObjective : IMissionSubStep, IMissionStep, IMissionItem
	{
		[Cpp2IlInjected.Token(Token = "0x17001595")]
		int ObjectiveID
		{
			[Cpp2IlInjected.Token(Token = "0x6005583")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005584")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
}
