using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006AB")]
	public interface IMissionStepName
	{
		[Cpp2IlInjected.Token(Token = "0x17001389")]
		string StepName
		{
			[Cpp2IlInjected.Token(Token = "0x6004B05")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6004B06")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
}
