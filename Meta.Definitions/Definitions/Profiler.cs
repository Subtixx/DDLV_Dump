using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	public class Profiler
	{
		[Cpp2IlInjected.Token(Token = "0x17000311")]
		public static IProfiler Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8D")]
			[Cpp2IlInjected.Address(RVA = "0x2889BD0", Offset = "0x28885D0", VA = "0x182889BD0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000C8E")]
			[Cpp2IlInjected.Address(RVA = "0x2889C30", Offset = "0x2888630", VA = "0x182889C30")]
			[CompilerGenerated]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public Profiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x2889B60", Offset = "0x2888560", VA = "0x182889B60")]
		static Profiler()
		{
			NullProfiler nullProfiler = new NullProfiler();
			/*Error: Unexpected end of block*/;
		}
	}
}
