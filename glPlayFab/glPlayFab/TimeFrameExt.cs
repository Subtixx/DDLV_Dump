using System;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class TimeFrameExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x14F7300", Offset = "0x14F5D00", VA = "0x1814F7300")]
		public static bool TryGetNextOccurence(this ITimeFrame self, DateTime now, out DateTime nextOccurence)
		{
			//IL_001b: Expected I8, but got O
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			DateTime maxValue = DateTime.MaxValue;
			nextOccurence.dateData = (ulong)(long)maxValue;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x14F7460", Offset = "0x14F5E60", VA = "0x1814F7460")]
		public static bool TryGetPreviousOccurence(this ITimeFrame self, DateTime now, out DateTime prevOccurence)
		{
			//IL_001b: Expected I8, but got O
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			DateTime maxValue = DateTime.MaxValue;
			prevOccurence.dateData = (ulong)(long)maxValue;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x14F7240", Offset = "0x14F5C40", VA = "0x1814F7240")]
		public static bool IsActive(this ITimeFrame self, DateTime now)
		{
			//Discarded unreachable code: IL_0014
			//IL_0014: Expected I4, but got O
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			return (byte)(int)typeof(ITimeFrame).TypeHandle != 0;
		}
	}
}
