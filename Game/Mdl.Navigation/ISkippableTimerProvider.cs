using System;
using Cpp2IlInjected;
using Definitions;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C4B")]
	public interface ISkippableTimerProvider
	{
		[Cpp2IlInjected.Token(Token = "0x1700078E")]
		TimerType TimerType
		{
			[Cpp2IlInjected.Token(Token = "0x600386A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600386B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TimeSpan GetRemainingTime();
	}
}
