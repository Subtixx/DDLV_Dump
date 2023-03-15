using System;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public interface ITimeFrame
	{
		[Cpp2IlInjected.Token(Token = "0x17000077")]
		string CronExpression
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		Duration Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool IsActive(DateTime now, out DateTime ends);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "1")]
		DateTime? GetPreviousOccurence(DateTime now);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DateTime? GetNextOccurence(DateTime now);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int GetPeriod(DateTime start, DateTime now);
	}
}
