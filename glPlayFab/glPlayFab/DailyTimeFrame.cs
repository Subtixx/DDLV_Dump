using System;
using Cpp2IlInjected;
using Google.Protobuf.WellKnownTypes;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class DailyTimeFrame : RecurringTimeFrame
	{
		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public override string CronExpression
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x102B980", Offset = "0x102A380", VA = "0x18102B980", Slot = "10")]
			get
			{
				Time time = base.Time;
				Time time2 = base.Time;
				return $"{time} {time} * * *";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x102B920", Offset = "0x102A320", VA = "0x18102B920", Slot = "12")]
		public override DateTime? GetPreviousOccurence(DateTime now)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x102B840", Offset = "0x102A240", VA = "0x18102B840", Slot = "11")]
		public override int GetPeriod(DateTime start, DateTime now)
		{
			TimeSpan timeSpan = now - start;
			double value = default(double);
			TimeSpan timeSpan2 = TimeSpan.FromDays(value);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public DailyTimeFrame()
		{
			((SourceContext._003C_003Ec)(object)this)._002Ector();
		}
	}
}
