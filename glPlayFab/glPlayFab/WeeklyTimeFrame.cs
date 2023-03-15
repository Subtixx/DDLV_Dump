using System;
using Cpp2IlInjected;
using NCrontab;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class WeeklyTimeFrame : RecurringTimeFrame
	{
		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x4000167")]
		public DayOfWeek Day
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public override string CronExpression
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x15053C0", Offset = "0x1503DC0", VA = "0x1815053C0", Slot = "10")]
			get
			{
				Time time = base.Time;
				Time time2 = base.Time;
				DayOfWeek dayOfWeek = Day;
				return $"{time} {time} * * {time}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public TimeSpan Period
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x1505470", Offset = "0x1503E70", VA = "0x181505470")]
			get
			{
				TimeSpan result = default(TimeSpan);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x15050D0", Offset = "0x1503AD0", VA = "0x1815050D0", Slot = "13")]
		public override bool IsActive(DateTime now, out DateTime ends)
		{
			//IL_0041: Expected I8, but got O
			//IL_0058: Expected I8, but got O
			Period period = base.RecurencePeriod;
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				DateTime maxValue = DateTime.MaxValue;
				int _003CMinutes_003Ek__BackingField = base.Duration.Minutes;
				TimeSpan timeSpan = default(TimeSpan);
				DateTime dateTime = maxValue + timeSpan;
				ends.dateData = (ulong)(long)dateTime;
				bool flag2 = default(bool);
				if (!flag2)
				{
					return flag2;
				}
			}
			DateTime maxValue2 = DateTime.MaxValue;
			ends.dateData = (ulong)(long)maxValue2;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x1504EB0", Offset = "0x15038B0", VA = "0x181504EB0", Slot = "11")]
		public override int GetPeriod(DateTime start, DateTime now)
		{
			CrontabSchedule crontabSchedule = base.Schedule;
			if (crontabSchedule != null)
			{
				DateTime nextOccurrence = crontabSchedule.GetNextOccurrence(start);
				int num = 0;
			}
			int num2 = 0;
			DateTime dateTime = default(DateTime);
			TimeSpan timeSpan = now - dateTime;
			double value = default(double);
			TimeSpan timeSpan2 = TimeSpan.FromDays(value);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x1505020", Offset = "0x1503A20", VA = "0x181505020", Slot = "12")]
		public override DateTime? GetPreviousOccurence(DateTime now)
		{
			CrontabSchedule crontabSchedule = default(CrontabSchedule);
			if (crontabSchedule != null)
			{
				DateTime baseTime = default(DateTime);
				DateTime nextOccurrence = crontabSchedule.GetNextOccurrence(baseTime);
				int num = 0;
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public WeeklyTimeFrame()
		{
		}
	}
}
