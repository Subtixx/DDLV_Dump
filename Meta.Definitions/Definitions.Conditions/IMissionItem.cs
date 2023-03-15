using Cpp2IlInjected;
using Definitions.Items;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007CA")]
	public interface IMissionItem
	{
		[Cpp2IlInjected.Token(Token = "0x17001592")]
		Item MissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x600557E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
