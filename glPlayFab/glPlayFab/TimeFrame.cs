using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class TimeFrame : ITimeFrame
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private ITimeFrame recurring;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public unsafe Date Start
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xF0A3C0", Offset = "0xF08DC0", VA = "0x180F0A3C0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xF0A930", Offset = "0xF09330", VA = "0x180F0A930")]
			[CompilerGenerated]
			set
			{
				//IL_000e: Expected native int or pointer, but got O
				int num = value.Day;
				((Date*)(IntPtr)_003CStart_003Ek__BackingField)->Day = num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public Date? End
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xF0A3E0", Offset = "0xF08DE0", VA = "0x180F0A3E0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xF0A940", Offset = "0xF09340", VA = "0x180F0A940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x2C"), Cpp2IlInjected.Token(Token = "0x400016B")]
		public bool Recurring
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xDD7720", Offset = "0xDD6120", VA = "0x180DD7720")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xDD7730", Offset = "0xDD6130", VA = "0x180DD7730")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x400016C")]
		public Time Time
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AD0", Offset = "0x6E44D0", VA = "0x1806E5AD0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public unsafe Duration Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x13C8F80", Offset = "0x13C7980", VA = "0x1813C8F80", Slot = "9")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x14F8030", Offset = "0x14F6A30", VA = "0x1814F8030")]
			[CompilerGenerated]
			set
			{
				//IL_000e: Expected native int or pointer, but got O
				int _003CMinutes_003Ek__BackingField = value.Minutes;
				((Duration*)(IntPtr)_003CDuration_003Ek__BackingField)->Minutes = _003CMinutes_003Ek__BackingField;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		[JsonConverter(typeof(StringEnumConverter))]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x44"), Cpp2IlInjected.Token(Token = "0x400016E")]
		public DayOfWeek? DayOfWeek
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x14F7FD0", Offset = "0x14F69D0", VA = "0x1814F7FD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x14F8020", Offset = "0x14F6A20", VA = "0x1814F8020")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x4C"), Cpp2IlInjected.Token(Token = "0x400016F")]
		public int? Day
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x14F7FE0", Offset = "0x14F69E0", VA = "0x1814F7FE0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xEFF4A0", Offset = "0xEFDEA0", VA = "0x180EFF4A0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public string Cron
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003CCron_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			set
			{
				_003CCron_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		[JsonIgnore]
		public string CronExpression
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x14F7F70", Offset = "0x14F6970", VA = "0x1814F7F70", Slot = "7")]
			get
			{
				if (recurring == null)
				{
					Build();
					ITimeFrame timeFrame = recurring;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private ITimeFrame RecurringTimeFrame
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x14F7FF0", Offset = "0x14F69F0", VA = "0x1814F7FF0")]
			get
			{
				ITimeFrame timeFrame = recurring;
				if (timeFrame == null)
				{
					Build();
				}
				return timeFrame;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x14F7BF0", Offset = "0x14F65F0", VA = "0x1814F7BF0", Slot = "8")]
		public unsafe int GetPeriod(DateTime start, DateTime now)
		{
			ITimeFrame timeFrame = recurring;
			if (timeFrame == null)
			{
				Build();
				ITimeFrame timeFrame2 = recurring;
			}
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			bool flag = timeFrame.IsActive(start, out *(DateTime*)now);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x14F7CE0", Offset = "0x14F66E0", VA = "0x1814F7CE0")]
		public int GetPeriod(DateTime now)
		{
			//Discarded unreachable code: IL_0033
			int num = Start.Day;
			if (recurring == null)
			{
				Build();
				ITimeFrame timeFrame = recurring;
			}
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x14F75C0", Offset = "0x14F5FC0", VA = "0x1814F75C0")]
		public unsafe void Build()
		{
			//Discarded unreachable code: IL_0166
			//IL_0050: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_00a4: Expected native int or pointer, but got O
			//IL_00d7: Expected O, but got I4
			//IL_00fe: Expected native int or pointer, but got O
			//IL_0128: Expected O, but got I4
			//IL_014f: Expected native int or pointer, but got O
			if ((object)Day == null)
			{
				DayOfWeek? dayOfWeek = DayOfWeek;
				if ((object)dayOfWeek == null)
				{
					if ((IntPtr)(Recurring ? 1 : 0) == (IntPtr)(void*)dayOfWeek && (object)dayOfWeek == null)
					{
						SingleTimeFrame singleTimeFrame = new SingleTimeFrame();
						Time time = Time;
						int num = 0;
						singleTimeFrame.Start = (DateTime)time;
						Time time2 = Time;
						int num2 = 0;
						singleTimeFrame.End = (DateTime?)(object)num2;
						recurring = singleTimeFrame;
						return;
					}
					DailyTimeFrame dailyTimeFrame = new DailyTimeFrame();
					int num3 = Start.Day;
					DateTime dateTime = default(DateTime);
					if ((object)dateTime != null)
					{
					}
					int num4 = 0;
					((RecurringTimeFrame)dailyTimeFrame).RecurencePeriod = (Period)num4;
					Time time3 = (((RecurringTimeFrame)dailyTimeFrame).Time = Time);
					int _003CMinutes_003Ek__BackingField = Duration.Minutes;
					((Duration*)(IntPtr)((RecurringTimeFrame)dailyTimeFrame).Duration)->Minutes = _003CMinutes_003Ek__BackingField;
					recurring = dailyTimeFrame;
					return;
				}
				WeeklyTimeFrame weeklyTimeFrame = new WeeklyTimeFrame();
				int num5 = Start.Day;
				DateTime dateTime2 = default(DateTime);
				if ((object)dateTime2 != null)
				{
				}
				int num6 = 0;
				((RecurringTimeFrame)weeklyTimeFrame).RecurencePeriod = (Period)num6;
				Time time4 = (((RecurringTimeFrame)weeklyTimeFrame).Time = Time);
				int _003CMinutes_003Ek__BackingField2 = Duration.Minutes;
				((Duration*)(IntPtr)((RecurringTimeFrame)weeklyTimeFrame).Duration)->Minutes = _003CMinutes_003Ek__BackingField2;
			}
			MonthlyTimeFrame monthlyTimeFrame = new MonthlyTimeFrame();
			int num7 = Start.Day;
			DateTime dateTime3 = default(DateTime);
			if ((object)dateTime3 != null)
			{
			}
			int num8 = 0;
			((RecurringTimeFrame)monthlyTimeFrame).RecurencePeriod = (Period)num8;
			Time time5 = (((RecurringTimeFrame)monthlyTimeFrame).Time = Time);
			int _003CMinutes_003Ek__BackingField3 = Duration.Minutes;
			((Duration*)(IntPtr)((RecurringTimeFrame)monthlyTimeFrame).Duration)->Minutes = _003CMinutes_003Ek__BackingField3;
			int num9 = default(int);
			monthlyTimeFrame.Day = num9;
			recurring = monthlyTimeFrame;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x14F7EF0", Offset = "0x14F68F0", VA = "0x1814F7EF0", Slot = "4")]
		public bool IsActive(DateTime now, out DateTime ends)
		{
			//Discarded unreachable code: IL_001c
			//IL_001c: Expected I4, but got O
			if (recurring == null)
			{
				Build();
				ITimeFrame timeFrame = recurring;
			}
			return (byte)(int)typeof(ITimeFrame).TypeHandle != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x14F7AF0", Offset = "0x14F64F0", VA = "0x1814F7AF0", Slot = "6")]
		public DateTime? GetNextOccurence(DateTime now)
		{
			int num = 0;
			num += num;
			num++;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x14F7DF0", Offset = "0x14F67F0", VA = "0x1814F7DF0", Slot = "5")]
		public DateTime? GetPreviousOccurence(DateTime now)
		{
			int num = 0;
			num += num;
			num++;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TimeFrame()
		{
		}
	}
}
