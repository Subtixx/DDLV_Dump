using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public interface ITitleDataOnlineSyncCondition
	{
		[Cpp2IlInjected.Token(Token = "0x17000120")]
		bool RequiresOnlineSync
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		bool IsUpToDate
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ConfirmOnlineSync();
	}
}
