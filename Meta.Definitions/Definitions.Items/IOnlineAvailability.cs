using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200067E")]
	public interface IOnlineAvailability : IAvailability
	{
		[Cpp2IlInjected.Token(Token = "0x17001359")]
		bool IsSyncOnlineItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004ABA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6004ABB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
}
