using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Serilog.Events;

namespace Meta.ErrorReporting
{
	[Cpp2IlInjected.Token(Token = "0x20010A9")]
	public class NullErrorReporter : IErrorReporter
	{
		[Cpp2IlInjected.Token(Token = "0x6008701")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		void IErrorReporter.Log(string message, LogEventLevel level)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6008702")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
		void IErrorReporter.LogException(Exception exception)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6008703")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		void IErrorReporter.SetCustomKey(string key, string value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6008704")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		void IErrorReporter.SetUserId(string userId)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6008705")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "8")]
		void IErrorReporter.Report(string message, Exception e, Dictionary<string, string> metadata)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6008706")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public NullErrorReporter()
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			Meta_002EErrorReporting_002EIErrorReporter_002ELogException((Exception)num);
		}
	}
}
