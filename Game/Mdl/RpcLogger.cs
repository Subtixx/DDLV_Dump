using System;
using Cpp2IlInjected;
using Gameloft.Rpc.Core;
using Serilog;

namespace Mdl
{
	[Cpp2IlInjected.Token(Token = "0x20001FE")]
	public class RpcLogger : Gameloft.Rpc.Core.ILogger
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400112F")]
		public Serilog.ILogger seriLogger;

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public RpcLogger(Serilog.ILogger seriLogger)
		{
			this.seriLogger = seriLogger;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0xCC6740", Offset = "0xCC5140", VA = "0x180CC6740", Slot = "4")]
		public void Log(LogLevel level, string message, Exception e)
		{
			if (level <= LogLevel.Debug)
			{
				Serilog.ILogger logger = seriLogger;
			}
			Serilog.ILogger logger2 = seriLogger;
			Serilog.ILogger logger3 = seriLogger;
			throw new NullReferenceException();
		}
	}
}
