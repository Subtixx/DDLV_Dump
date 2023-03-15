using System;
using Cpp2IlInjected;
using Mono.Net;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class MonthlyTimeFrame : RecurringTimeFrame
	{
		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x4000168")]
		public int Day
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public override string CronExpression
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x1033A20", Offset = "0x1032420", VA = "0x181033A20", Slot = "10")]
			get
			{
				Time time = base.Time;
				Time time2 = base.Time;
				int num = Day;
				return $"{time} {time} {time} * *";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x10338A0", Offset = "0x10322A0", VA = "0x1810338A0", Slot = "11")]
		public override int GetPeriod(DateTime start, DateTime now)
		{
			//IL_0009: Expected O, but got I4
			//IL_0011: Expected O, but got I4
			int num = 0;
			DateTime dateTime = start - (TimeSpan)num;
			DateTime dateTime2 = now - (TimeSpan)num;
			int num3 = default(int);
			int num2 = num2 - num3;
			int num4 = default(int);
			return num4 - num4;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x10339D0", Offset = "0x10323D0", VA = "0x1810339D0", Slot = "12")]
		public override DateTime? GetPreviousOccurence(DateTime now)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public MonthlyTimeFrame()
		{
			((Mono.Net.CFNetwork._003C_003Ec__DisplayClass13_0)(object)this)._002Ector();
		}
	}
}
