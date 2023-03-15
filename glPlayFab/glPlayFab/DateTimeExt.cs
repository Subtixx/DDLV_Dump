using System;
using Cpp2IlInjected;
using NCrontab;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public static class DateTimeExt
	{
		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		[field: Cpp2IlInjected.Token(Token = "0x400022E")]
		public static DateTime MinValueUtc
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x102C1A0", Offset = "0x102ABA0", VA = "0x18102C1A0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		[field: Cpp2IlInjected.Token(Token = "0x400022F")]
		public static DateTime MaxValueUtc
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x102C140", Offset = "0x102AB40", VA = "0x18102C140")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		[field: Cpp2IlInjected.Token(Token = "0x4000230")]
		public static DateTime Epoch
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x102C0E0", Offset = "0x102AAE0", VA = "0x18102C0E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x102BA90", Offset = "0x102A490", VA = "0x18102BA90")]
		public static string CronExpression(this DateTime self)
		{
			//Discarded unreachable code: IL_0071
			//IL_0017: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			//IL_0050: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object[] array;
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			while (true)
			{
				array = new object[5];
				if (num != 0 && num == 0)
				{
					continue;
				}
				array[0] = num;
				num = num2;
				if (num2 != 0 && num2 == 0)
				{
					continue;
				}
				array[1] = num;
				num = num3;
				if (num3 != 0 && num3 == 0)
				{
					continue;
				}
				array[2] = num;
				num = num4;
				if (num4 == 0 || num4 != 0)
				{
					array[3] = num;
					num = num5;
					if (num5 == 0 || num5 != 0)
					{
						break;
					}
				}
			}
			array[4] = num;
			return string.Format("{0} {1} {2} {3} {4} *", array);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x102BE80", Offset = "0x102A880", VA = "0x18102BE80")]
		public unsafe static DateTime? GetNextOccurence(this DateTime self, DateTime now)
		{
			//IL_0019: Expected I8, but got I4
			//IL_0014: Expected native int or pointer, but got O
			if (CrontabSchedule.TryParse(now.CronExpression()) != null)
			{
				int num = 0;
			}
			int num2 = 0;
			((DateTime*)(IntPtr)self)->dateData = (ulong)num2;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x102BF70", Offset = "0x102A970", VA = "0x18102BF70")]
		public static int TotalMonths(this DateTime self)
		{
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x102BD80", Offset = "0x102A780", VA = "0x18102BD80")]
		public static long Days(this DateTime self)
		{
			DateTime dateTime = Epoch;
			TimeSpan timeSpan = self - dateTime;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x102BFA0", Offset = "0x102A9A0", VA = "0x18102BFA0")]
		static DateTimeExt()
		{
			//IL_000c: Expected O, but got I8
			//IL_001b: Expected O, but got I8
			//IL_0022: Expected O, but got I8
			DateTime minValue = DateTime.MinValue;
			ulong num = default(ulong);
			MinValueUtc = (DateTime)num;
			DateTime maxValue = DateTime.MaxValue;
			int num2 = 0;
			ulong num3 = default(ulong);
			MaxValueUtc = (DateTime)num3;
			ulong num4 = default(ulong);
			Epoch = (DateTime)num4;
		}
	}
}
