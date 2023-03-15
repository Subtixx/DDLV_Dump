using System;
using Cpp2IlInjected;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface IFatigue
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CanRefresh(DateTime lastRefresh, DateTime now);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		DateTime NextAutoRefresh(DateTime now);
	}
}
