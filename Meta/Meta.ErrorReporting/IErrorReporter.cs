using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Serilog.Events;

namespace Meta.ErrorReporting
{
	[Cpp2IlInjected.Token(Token = "0x20010A8")]
	public interface IErrorReporter
	{
		[Cpp2IlInjected.Token(Token = "0x60086FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Log(string message, LogEventLevel level);

		[Cpp2IlInjected.Token(Token = "0x60086FD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LogException(Exception exception);

		[Cpp2IlInjected.Token(Token = "0x60086FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetCustomKey(string key, string value);

		[Cpp2IlInjected.Token(Token = "0x60086FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SetUserId(string userId);

		[Cpp2IlInjected.Token(Token = "0x6008700")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Report(string message, Exception e, Dictionary<string, string> metadata);
	}
}
