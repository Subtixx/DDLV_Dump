using Cpp2IlInjected;
using Meta.ErrorReporting;
using Serilog;
using Serilog.Configuration;
using Serilog.Events;

namespace Mdl.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000962")]
	public static class SerilogReporterExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6002BA1")]
		[Cpp2IlInjected.Address(RVA = "0xF48110", Offset = "0xF46B10", VA = "0x180F48110")]
		public static LoggerConfiguration ErrorReporter(this LoggerSinkConfiguration sinkConfiguration, IErrorReporter reporter, LogEventLevel restrictedToMinimumLevel = LogEventLevel.Verbose)
		{
			//Discarded unreachable code: IL_0009
			ReporterSink reporterSink = new ReporterSink(reporter);
			LoggerConfiguration result = default(LoggerConfiguration);
			return result;
		}
	}
}
