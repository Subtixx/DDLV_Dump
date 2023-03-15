using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf.WellKnownTypes;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class CronTimeFrame : RecurringTimeFrame
	{
		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public string Cron
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CCron_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			set
			{
				_003CCron_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public override string CronExpression
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "10")]
			get
			{
				return Cron;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x102B650", Offset = "0x102A050", VA = "0x18102B650", Slot = "11")]
		public override int GetPeriod(DateTime start, DateTime now)
		{
			//Discarded unreachable code: IL_0025
			Period period = base.RecurencePeriod;
			bool flag = default(bool);
			if (!flag)
			{
				return -1;
			}
			return base.Schedule.GetNextOccurrences(start, now).ToArray<DateTime>().Length;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x102B710", Offset = "0x102A110", VA = "0x18102B710", Slot = "12")]
		public override DateTime? GetPreviousOccurence(DateTime now)
		{
			bool flag = default(bool);
			if (flag)
			{
				IEnumerable<DateTime> cpp2il__autoParamName__idx_ = default(IEnumerable<DateTime>);
				DateTime[] array = ((IEnumerable<>)cpp2il__autoParamName__idx_).ToArray<DateTime>();
				int length = array.Length;
				if (length != 0)
				{
					DateTime dateTime = array[length];
					int num = 0;
				}
			}
			int num2 = 0;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x102B5A0", Offset = "0x1029FA0", VA = "0x18102B5A0")]
		public static CronTimeFrame Create(string cron, DateTime start, [Optional] DateTime? end)
		{
			//Discarded unreachable code: IL_0016
			CronTimeFrame cronTimeFrame = new CronTimeFrame();
			((RecurringTimeFrame)cronTimeFrame).RecurencePeriod = (Period)start;
			cronTimeFrame.Cron = cron;
			return cronTimeFrame;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public CronTimeFrame()
		{
			((SourceContext._003C_003Ec)(object)this)._002Ector();
		}
	}
}
