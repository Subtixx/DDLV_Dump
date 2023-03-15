using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public class TitleDataOnlineSyncAlways : ITitleDataOnlineSyncCondition
	{
		[Cpp2IlInjected.Token(Token = "0x17000122")]
		public bool RequiresOnlineSync
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "4")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		public bool IsUpToDate
		{
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "5")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public void ConfirmOnlineSync()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TitleDataOnlineSyncAlways()
		{
			ConfirmOnlineSync();
		}
	}
}
