using System;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface ILogger
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Info(string msg, params object[] arguments);

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Warning(string msg, params object[] arguments);

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Error(string msg, params object[] arguments);

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Error(Exception e, string msg, params object[] arguments);
	}
}
