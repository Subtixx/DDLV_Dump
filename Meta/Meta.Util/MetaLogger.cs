using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Log;
using Serilog;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000ABC")]
	public static class MetaLogger
	{
		[Cpp2IlInjected.Token(Token = "0x1700103E")]
		public static ILogger Log
		{
			[Cpp2IlInjected.Token(Token = "0x6005D24")]
			[Cpp2IlInjected.Address(RVA = "0x7F4CB0", Offset = "0x7F36B0", VA = "0x1807F4CB0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D25")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C20", Offset = "0x7F3620", VA = "0x1807F4C20")]
		static MetaLogger()
		{
			ILogger logger = Serilogger.Create("Meta");
			/*Error: Unexpected end of block*/;
		}
	}
}
