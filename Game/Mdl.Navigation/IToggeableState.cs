using Cpp2IlInjected;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C07")]
	internal interface IToggeableState : IPlayerTaskData
	{
		[Cpp2IlInjected.Token(Token = "0x17000753")]
		bool CurrentValue
		{
			[Cpp2IlInjected.Token(Token = "0x60036E4")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
