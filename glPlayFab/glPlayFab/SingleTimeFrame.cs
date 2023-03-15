using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class SingleTimeFrame : ITimeFrame
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000164")]
		public DateTime Start
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AB0", Offset = "0x6E44B0", VA = "0x1806E5AB0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public DateTime? End
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x8FD6D0", Offset = "0x8FC0D0", VA = "0x1808FD6D0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x997FC0", Offset = "0x9969C0", VA = "0x180997FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public DateTime RealEnd
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x14F6810", Offset = "0x14F5210", VA = "0x1814F6810")]
			get
			{
				DateTime? dateTime = End;
				if ((object)typeof(DateTime).TypeHandle != null)
				{
				}
				return DateTime.MaxValue;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Duration Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x14F6770", Offset = "0x14F5170", VA = "0x1814F6770", Slot = "9")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public string CronExpression
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x14F6710", Offset = "0x14F5110", VA = "0x1814F6710", Slot = "7")]
			get
			{
				return Start.CronExpression();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "8")]
		public int GetPeriod(DateTime start, DateTime now)
		{
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x14F6530", Offset = "0x14F4F30", VA = "0x1814F6530", Slot = "5")]
		public DateTime? GetPreviousOccurence(DateTime now)
		{
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			int num3 = 0;
			if ((object)typeof(ITimeFrame).TypeHandle != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x14F6640", Offset = "0x14F5040", VA = "0x1814F6640", Slot = "4")]
		public bool IsActive(DateTime now, out DateTime ends)
		{
			//IL_000e: Expected I8, but got O
			DateTime realEnd = RealEnd;
			ends.dateData = (ulong)(long)realEnd;
			DateTime dateTime = Start;
			bool flag = now >= dateTime;
			if (!flag)
			{
				return flag;
			}
			DateTime realEnd2 = RealEnd;
			return now < realEnd2;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x14F64A0", Offset = "0x14F4EA0", VA = "0x1814F64A0", Slot = "6")]
		public DateTime? GetNextOccurence(DateTime now)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public SingleTimeFrame()
		{
		}
	}
}
