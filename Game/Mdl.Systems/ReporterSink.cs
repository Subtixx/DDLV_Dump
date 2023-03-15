using System;
using Cpp2IlInjected;
using Meta.ErrorReporting;
using Serilog.Core;
using Serilog.Events;

namespace Mdl.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000961")]
	public class ReporterSink : ILogEventSink
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400340F")]
		private readonly IErrorReporter reporter;

		[Cpp2IlInjected.Token(Token = "0x6002B9F")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public ReporterSink(IErrorReporter reporter)
		{
			this.reporter = reporter;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BA0")]
		[Cpp2IlInjected.Address(RVA = "0xCC1540", Offset = "0xCBFF40", VA = "0x180CC1540", Slot = "4")]
		public void Emit(LogEvent logEvent)
		{
			//Discarded unreachable code: IL_005e
			//IL_0014: Expected O, but got I4
			if ((long)reporter == 0)
			{
				return;
			}
			int num = 0;
			string text = logEvent.RenderMessage((IFormatProvider)num);
			IErrorReporter errorReporter = reporter;
			LogEventLevel _003CLevel_003Ek__BackingField = logEvent.Level;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			if (logEvent.Exception != null)
			{
				IErrorReporter errorReporter2 = reporter;
				uint num4 = default(uint);
				if (num2 < (int)num4)
				{
					num2 += num2;
					num2++;
				}
			}
		}
	}
}
