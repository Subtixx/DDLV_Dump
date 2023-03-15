using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200067C")]
	public interface IAvailability
	{
		[Cpp2IlInjected.Token(Token = "0x17001355")]
		bool IsUnavailableForGenerator
		{
			[Cpp2IlInjected.Token(Token = "0x6004AB5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6004AB6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
}
