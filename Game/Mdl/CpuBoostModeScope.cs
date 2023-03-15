using System;
using Cpp2IlInjected;

namespace Mdl
{
	[Cpp2IlInjected.Token(Token = "0x200020E")]
	public struct CpuBoostModeScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200020F")]
		public enum CpuBoostMode
		{
			[Cpp2IlInjected.Token(Token = "0x40011AA")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x40011AB")]
			FastLoad
		}

		[Cpp2IlInjected.Token(Token = "0x40011A7")]
		private static CpuBoostMode CurrentBoostMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40011A8")]
		private CpuBoostMode oldBoostMode;

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x10FED90", Offset = "0x10FD790", VA = "0x1810FED90")]
		private static void SetCPUBoostMode(CpuBoostMode mode)
		{
			CurrentBoostMode = mode;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x10FEEF0", Offset = "0x10FD8F0", VA = "0x1810FEEF0")]
		private CpuBoostModeScope(CpuBoostMode mode)
		{
			CpuBoostMode cpuBoostMode = (oldBoostMode = CurrentBoostMode);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x10FED30", Offset = "0x10FD730", VA = "0x1810FED30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x10FECC0", Offset = "0x10FD6C0", VA = "0x1810FECC0")]
		public static CpuBoostModeScope Create(CpuBoostMode mode)
		{
			int currentBoostMode = (int)CurrentBoostMode;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		static CpuBoostModeScope()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
