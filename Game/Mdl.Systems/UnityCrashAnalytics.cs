using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Meta.ErrorReporting;
using Serilog.Events;
using UnityEngine.CrashReportHandler;

namespace Mdl.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200094A")]
	public class UnityCrashAnalytics : IErrorReporter
	{
		[Cpp2IlInjected.Token(Token = "0x6002AD9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		void IErrorReporter.Log(string message, LogEventLevel level)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002ADA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
		void IErrorReporter.LogException(Exception exception)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002ADB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		void IErrorReporter.SetUserId(string userId)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002ADC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "8")]
		void IErrorReporter.Report(string message, Exception e, Dictionary<string, string> metadata)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002ADD")]
		[Cpp2IlInjected.Address(RVA = "0x13E24C0", Offset = "0x13E0EC0", VA = "0x1813E24C0", Slot = "6")]
		void IErrorReporter.SetCustomKey(string key, string value)
		{
			CrashReportHandler.SetUserMetadata(key, value);
		}

		[Cpp2IlInjected.Token(Token = "0x6002ADE")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public UnityCrashAnalytics()
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			Meta_002EErrorReporting_002EIErrorReporter_002ELogException((Exception)num);
		}
	}
}
