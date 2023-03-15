using System;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface ILogger
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Log(LogLevel level, string message, Exception e);
	}
}
