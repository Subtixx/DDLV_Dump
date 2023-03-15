using System;
using Cpp2IlInjected;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000735")]
	internal class Clock
	{
		[Cpp2IlInjected.Token(Token = "0x40029ED")]
		private static readonly DateTime _epoch;

		[Cpp2IlInjected.Token(Token = "0x6001FF7")]
		[Cpp2IlInjected.Address(RVA = "0xA85C10", Offset = "0xA84610", VA = "0x180A85C10")]
		public static long CurrentTimestamp()
		{
			int num = 0;
			DateTime utcNow = DateTime.UtcNow;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FF8")]
		[Cpp2IlInjected.Address(RVA = "0xA85CC0", Offset = "0xA846C0", VA = "0x180A85CC0")]
		public static long DateToTimestamp(DateTime time)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001FF9")]
		[Cpp2IlInjected.Address(RVA = "0xA85D80", Offset = "0xA84780", VA = "0x180A85D80")]
		public static DateTime TimestampToDate(long timestamp)
		{
			//IL_0006: Expected F8, but got I4
			TimeSpan timeSpan = TimeSpan.FromMilliseconds(0.0);
			DateTime result = default(DateTime);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FFA")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public Clock()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001FFB")]
		[Cpp2IlInjected.Address(RVA = "0xA85E60", Offset = "0xA84860", VA = "0x180A85E60")]
		static Clock()
		{
			int num = 0;
		}
	}
}
