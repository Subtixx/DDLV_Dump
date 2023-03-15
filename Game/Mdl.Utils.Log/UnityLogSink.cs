using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Cpp2IlInjected;
using Serilog.Core;
using Serilog.Events;
using Serilog.Formatting;
using UnityEngine;

namespace Mdl.Utils.Log
{
	[Cpp2IlInjected.Token(Token = "0x20007D8")]
	public class UnityLogSink : ILogEventSink
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002C0E")]
		private readonly ITextFormatter formatter;

		[Cpp2IlInjected.Token(Token = "0x60022D1")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public UnityLogSink()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60022D2")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public UnityLogSink(ITextFormatter outputFormatter)
		{
			formatter = outputFormatter;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60022D3")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620")]
		private static bool IsStandalone()
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60022D4")]
		[Cpp2IlInjected.Address(RVA = "0x13E3500", Offset = "0x13E1F00", VA = "0x1813E3500")]
		private static string Format(LogEvent evt, LogEventLevel level, [System.Runtime.InteropServices.Optional] ITextFormatter formatter)
		{
			//Discarded unreachable code: IL_0079
			//IL_0066: Expected O, but got I4
			int num = 0;
			StringBuilder stringBuilder = new StringBuilder();
			int num2 = 0;
			if (stringBuilder != null)
			{
			}
			int num3 = 0;
			DateTime utcNow = DateTime.UtcNow;
			string text = default(string);
			string text2 = "[" + text + "] ";
			int num4 = 0;
			DateTime utcNow2 = DateTime.UtcNow;
			string text3 = default(string);
			string value = $"[{text3}] [{text3}] ";
			StringBuilder stringBuilder2 = stringBuilder.Append(value);
			string value2 = default(string);
			StringBuilder stringBuilder3 = stringBuilder.Append(value2);
			int num5 = 0;
			string value3 = evt.RenderMessage((IFormatProvider)num5);
			StringBuilder stringBuilder4 = stringBuilder.Append(value3);
			return stringBuilder.ToString();
		}

		[Cpp2IlInjected.Token(Token = "0x60022D5")]
		[Cpp2IlInjected.Address(RVA = "0x13E3410", Offset = "0x13E1E10", VA = "0x1813E3410", Slot = "4")]
		public void Emit(LogEvent _logEvent)
		{
			//Discarded unreachable code: IL_0025
			int num = 0;
			if (SynchronizationContext.Current != null)
			{
				Log(_logEvent);
			}
			else
			{
				object obj = ((ICloneable)new SendOrPostCallback(Log)).Clone();
			}
			[Cpp2IlInjected.Token(Token = "0x60022D8")]
			[Cpp2IlInjected.Address(RVA = "0x13E3740", Offset = "0x13E2140", VA = "0x1813E3740")]
			void Log(object x)
			{
				//Discarded unreachable code: IL_0027
				int num2 = 0;
				if (x != null)
				{
					if ((long)typeof(LogEvent).TypeHandle <= 5)
					{
						string message = default(string);
						Debug.Log(message);
						string message2 = default(string);
						Debug.LogWarning(message2);
						string message3 = default(string);
						Debug.LogError(message3);
					}
					if (x == null)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}
	}
}
