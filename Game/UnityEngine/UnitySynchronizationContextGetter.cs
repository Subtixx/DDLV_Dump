using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;

namespace UnityEngine
{
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public static class UnitySynchronizationContextGetter
	{
		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public static SynchronizationContext Context
		{
			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0xD37C90", Offset = "0xD36690", VA = "0x180D37C90")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0xD37CD0", Offset = "0xD366D0", VA = "0x180D37CD0")]
			[CompilerGenerated]
			private set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xD37C40", Offset = "0xD36640", VA = "0x180D37C40")]
		[RuntimeInitializeOnLoadMethod]
		private static void InitSynchronizationContext()
		{
			int num = 0;
			SynchronizationContext current = SynchronizationContext.Current;
			/*Error: Unexpected end of block*/;
		}
	}
}
