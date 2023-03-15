using System;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct DisneyPeriod
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public DateTime start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public TimeSpan duration;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public DateTime end
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x102C450", Offset = "0x102AE50", VA = "0x18102C450")]
			get
			{
				DateTime result = default(DateTime);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x102C2B0", Offset = "0x102ACB0", VA = "0x18102C2B0")]
		public bool IsValid(DateTime now)
		{
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			DateTime dateTime = default(DateTime);
			return now < dateTime;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x102C440", Offset = "0x102AE40", VA = "0x18102C440")]
		public DisneyPeriod(DateTime start, TimeSpan duration)
		{
			this.start = start;
			this.duration = duration;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x102C3C0", Offset = "0x102ADC0", VA = "0x18102C3C0")]
		public DisneyPeriod(DateTime start, DateTime end)
		{
			this.start = start;
			TimeSpan timeSpan = (duration = end - start);
		}
	}
}
