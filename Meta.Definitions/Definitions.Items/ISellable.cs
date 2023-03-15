using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000666")]
	public interface ISellable
	{
		[Cpp2IlInjected.Token(Token = "0x17001347")]
		bool CanBeSold
		{
			[Cpp2IlInjected.Token(Token = "0x6004A76")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
