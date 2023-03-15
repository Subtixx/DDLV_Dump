using System;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A3A")]
	public static class IRecurringEventExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600589F")]
		[Cpp2IlInjected.Address(RVA = "0x1708130", Offset = "0x1706B30", VA = "0x181708130")]
		public static void Reschedule(this IRecurringEvent recurringEvent, IRecurringEventData recurringEventData, in World world, ITransactionContext context, Random random)
		{
			//IL_0034: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			//IL_008a: Expected I4, but got I8
			int num = 0;
			uint num2 = default(uint);
			if ((IntPtr)typeof(Timestamp).TypeHandle == (IntPtr)(int)num2)
			{
				RecurringEventIntervalData.Types.DurationData durationData = default(RecurringEventIntervalData.Types.DurationData);
				TimeSpan timeSpan = durationData.min_.ToTimeSpan();
				RecurringEventIntervalData.Types.DurationData durationData2 = default(RecurringEventIntervalData.Types.DurationData);
				Duration max_ = durationData2.max_;
				TimeSpan timeSpan2 = max_.ToTimeSpan();
				int num3 = 0;
				max_.WriteTo((CodedOutputStream)num3);
				double value = default(double);
				Duration duration = TimeSpan.FromSeconds(value).ToProto();
				return;
			}
			if ((long)typeof(Timestamp).TypeHandle == 2)
			{
				int num4 = 0;
				RecurringEventIntervalData.Types.TimeOfDayDataList timeOfDayDataList = default(RecurringEventIntervalData.Types.TimeOfDayDataList);
				int num6 = default(int);
				if (timeOfDayDataList.GetNextTimeOfDay((DateTime)num4).day_ != (DayOfTheWeek)(-9))
				{
					int num5 = 0;
					DayOfWeek dayOfWeek = default(DayOfWeek);
					if (dayOfWeek == (DayOfWeek)num5)
					{
					}
					num6 = 0;
					DayOfWeek dayOfWeek2 = default(DayOfWeek);
					num = (int)(num - dayOfWeek2);
					num += 5;
					ulong num7 = num7 + num7;
					long num8 = (long)(num7 * 7);
					num = (int)(num - num8);
					num++;
				}
				if (num6 == 8)
				{
					int num9 = 0;
				}
			}
			InvalidOperationException ex = new InvalidOperationException("A new case needs to be added");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60058A0")]
		[Cpp2IlInjected.Address(RVA = "0x1708040", Offset = "0x1706A40", VA = "0x181708040")]
		public static bool IsEventOver(this IRecurringEvent recurringEvent)
		{
			//Discarded unreachable code: IL_0016
			//IL_000e: Expected I4, but got O
			if ((object)typeof(IRecurringEvent).TypeHandle == null)
			{
				return (byte)(int)typeof(IRecurringEvent).TypeHandle != 0;
			}
			DateTime dateTime = default(DateTime);
			DateTime dateTime2 = default(DateTime);
			return dateTime > dateTime2;
		}
	}
}
