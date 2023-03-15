using Cpp2IlInjected;
using Serilog;
using Serilog.Configuration;
using Serilog.Events;

namespace Mdl.Native.iOS
{
	[Cpp2IlInjected.Token(Token = "0x20003A6")]
	public static class SerilogNSLogExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000F94")]
		[Cpp2IlInjected.Address(RVA = "0xF48090", Offset = "0xF46A90", VA = "0x180F48090")]
		public static LoggerConfiguration NSLog(this LoggerSinkConfiguration sinkConfiguration, LogEventLevel restrictedToMinimumLevel = LogEventLevel.Verbose)
		{
			//Discarded unreachable code: IL_0008
			NSLogSink nSLogSink = new NSLogSink();
			LoggerConfiguration result = default(LoggerConfiguration);
			return result;
		}
	}
}
