using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	public static class DateTimeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x17000314")]
		public static DateTime Epoch
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA8")]
			[Cpp2IlInjected.Address(RVA = "0x356CC80", Offset = "0x356B680", VA = "0x18356CC80")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0x356C9A0", Offset = "0x356B3A0", VA = "0x18356C9A0")]
		public static Season GetSeason(this DateTime timestamp)
		{
			ulong num = num + num;
			int num2 = 0;
			num2 += 2;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0x102BF70", Offset = "0x102A970", VA = "0x18102BF70")]
		public static int Months(this DateTime self)
		{
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x356CB50", Offset = "0x356B550", VA = "0x18356CB50")]
		public static int Weeks(this DateTime self)
		{
			//Discarded unreachable code: IL_001e
			//IL_0014: Expected I8, but got I4
			//IL_001b: Expected I4, but got I8
			int num = 0;
			Calendar calendar = CultureInfo.InvariantCulture.Calendar;
			int num2 = default(int);
			long num3 = num2 * 52;
			int num4 = default(int);
			return (int)(num4 + num3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x356CA50", Offset = "0x356B450", VA = "0x18356CA50")]
		public static long Hours(this DateTime self)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAC")]
		[Cpp2IlInjected.Address(RVA = "0x356C8A0", Offset = "0x356B2A0", VA = "0x18356C8A0")]
		public static long Days(this DateTime self)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAD")]
		[Cpp2IlInjected.Address(RVA = "0x356CC20", Offset = "0x356B620", VA = "0x18356CC20")]
		static DateTimeExtensions()
		{
			int num = 0;
		}
	}
}
