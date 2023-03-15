using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200064A")]
	public static class DayOfTheWeekFlagExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6004A2E")]
		[Cpp2IlInjected.Address(RVA = "0x27FE5B0", Offset = "0x27FCFB0", VA = "0x1827FE5B0")]
		public static DayOfTheWeekFlag GetDayOfTheWeekFlag(this DayOfWeek dayOfWeek)
		{
			return DayOfTheWeekFlag.Sunday;
		}
	}
}
