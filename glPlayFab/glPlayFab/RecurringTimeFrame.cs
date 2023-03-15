using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using NCrontab;
using Newtonsoft.Json;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public abstract class RecurringTimeFrame : ITimeFrame
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[JsonIgnore]
		private CrontabSchedule schedule;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Period RecurencePeriod
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xC3E270", Offset = "0xC3CC70", VA = "0x180C3E270")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xC3E2B0", Offset = "0xC3CCB0", VA = "0x180C3E2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4000161")]
		public Time Time
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x6E6160", Offset = "0x6E4B60", VA = "0x1806E6160")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public unsafe Duration Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x14F4EA0", Offset = "0x14F38A0", VA = "0x1814F4EA0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x14F4F50", Offset = "0x14F3950", VA = "0x1814F4F50")]
			[CompilerGenerated]
			set
			{
				//IL_000e: Expected native int or pointer, but got O
				int _003CMinutes_003Ek__BackingField = value.Minutes;
				((Duration*)(IntPtr)_003CDuration_003Ek__BackingField)->Minutes = _003CMinutes_003Ek__BackingField;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public abstract string CronExpression
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		[JsonIgnore]
		public CrontabSchedule Schedule
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x14F4EC0", Offset = "0x14F38C0", VA = "0x1814F4EC0")]
			get
			{
				CrontabSchedule crontabSchedule = schedule;
				if (crontabSchedule == null)
				{
					CrontabSchedule crontabSchedule2 = (schedule = CrontabSchedule.TryParse(CronExpression));
				}
				return crontabSchedule;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract int GetPeriod(DateTime start, DateTime now);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x14F4C30", Offset = "0x14F3630", VA = "0x1814F4C30")]
		public int GetPeriod(DateTime now)
		{
			Period period = RecurencePeriod;
			string cronExpression = CronExpression;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract DateTime? GetPreviousOccurence(DateTime now);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x14F4AA0", Offset = "0x14F34A0", VA = "0x1814F4AA0", Slot = "6")]
		public DateTime? GetNextOccurence(DateTime now)
		{
			CrontabSchedule crontabSchedule = default(CrontabSchedule);
			if (crontabSchedule != null)
			{
				int num = 0;
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x14F4B30", Offset = "0x14F3530", VA = "0x1814F4B30")]
		public IEnumerable<DateTime> GetNextOcurrences(DateTime baseTime, DateTime endTime)
		{
			while (true)
			{
				CrontabSchedule crontabSchedule = Schedule;
				if (crontabSchedule != null && crontabSchedule.GetNextOccurrences(baseTime, endTime) == null)
				{
					/*Error: Could not find block for branch target IL_0016*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x14F4E70", Offset = "0x14F3870", VA = "0x1814F4E70")]
		public bool IsInside(DateTime now)
		{
			Period period = RecurencePeriod;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x14F4C60", Offset = "0x14F3660", VA = "0x1814F4C60", Slot = "13")]
		public virtual bool IsActive(DateTime now, out DateTime ends)
		{
			//IL_002e: Expected I8, but got O
			//IL_0048: Expected I8, but got O
			Period period = RecurencePeriod;
			bool flag = default(bool);
			DateTime? dateTime = default(DateTime?);
			if (flag && (object)dateTime != null)
			{
				int _003CMinutes_003Ek__BackingField = Duration.Minutes;
				DateTime dateTime2 = default(DateTime);
				TimeSpan timeSpan = default(TimeSpan);
				DateTime dateTime3 = dateTime2 + timeSpan;
				ends.dateData = (ulong)(long)dateTime3;
				bool flag2 = default(bool);
				bool result = default(bool);
				if (flag2)
				{
					return result;
				}
			}
			DateTime maxValue = DateTime.MaxValue;
			int num = 0;
			ends.dateData = (ulong)(long)maxValue;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected RecurringTimeFrame()
		{
		}
	}
}
