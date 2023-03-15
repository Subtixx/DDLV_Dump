using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Serilog;
using Serilog.Configuration;
using Serilog.Events;
using Serilog.Formatting.Display;

namespace Mdl.Utils.Log
{
	[Cpp2IlInjected.Token(Token = "0x20007DA")]
	public static class SerilogExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60022D9")]
		[Cpp2IlInjected.Address(RVA = "0xF47FB0", Offset = "0xF469B0", VA = "0x180F47FB0")]
		public static LoggerConfiguration Unity(this LoggerSinkConfiguration sinkConfiguration, LogEventLevel restrictedToMinimumLevel = LogEventLevel.Verbose, [System.Runtime.InteropServices.Optional] string outputTemplate)
		{
			//Discarded unreachable code: IL_0022
			//IL_0015: Expected O, but got I4
			if ((object)typeof(UnityLogSink).TypeHandle != null)
			{
				UnityLogSink unityLogSink = new UnityLogSink();
			}
			int num = default(int);
			MessageTemplateTextFormatter outputFormatter = new MessageTemplateTextFormatter(outputTemplate, (IFormatProvider)num);
			num = 0;
			UnityLogSink unityLogSink2 = new UnityLogSink(outputFormatter);
			LoggerConfiguration result = default(LoggerConfiguration);
			return result;
		}
	}
}
