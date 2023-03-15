using System;
using Cpp2IlInjected;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public static class DailyResetUtil
	{
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public static readonly TimeSpan DailyResetTime;

		[Cpp2IlInjected.Token(Token = "0x6000CA3")]
		[Cpp2IlInjected.Address(RVA = "0x356C420", Offset = "0x356AE20", VA = "0x18356C420")]
		public static bool MustReset(Timestamp lastDailyReset, DateTime now)
		{
			if (lastDailyReset == null)
			{
				return true;
			}
			DateTime dateTime = lastDailyReset.ToDateTime();
			int num = 0;
			DateTime dateTime2 = default(DateTime);
			return now >= dateTime2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA4")]
		[Cpp2IlInjected.Address(RVA = "0x356C2F0", Offset = "0x356ACF0", VA = "0x18356C2F0")]
		public static DateTime LastDailyReset(DateTime now)
		{
			int num = 0;
			DateTime result = default(DateTime);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA5")]
		[Cpp2IlInjected.Address(RVA = "0x356C5F0", Offset = "0x356AFF0", VA = "0x18356C5F0")]
		public static DateTime NextDailyReset(DateTime now)
		{
			int num = 0;
			DateTime result = default(DateTime);
			return result;
		}
	}
}
