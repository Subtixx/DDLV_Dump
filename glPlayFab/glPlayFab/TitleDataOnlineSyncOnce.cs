using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public class TitleDataOnlineSyncOnce : ITitleDataOnlineSyncCondition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private bool WasSync;

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		public bool RequiresOnlineSync
		{
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0x14F81E0", Offset = "0x14F6BE0", VA = "0x1814F81E0", Slot = "4")]
			get
			{
				return !WasSync;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		public bool IsUpToDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0", Slot = "5")]
			get
			{
				return WasSync;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xA28AC0", Offset = "0xA274C0", VA = "0x180A28AC0", Slot = "6")]
		public void ConfirmOnlineSync()
		{
			WasSync = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TitleDataOnlineSyncOnce()
		{
		}
	}
}
