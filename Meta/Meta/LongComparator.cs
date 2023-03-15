using Cpp2IlInjected;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200099E")]
	public abstract class LongComparator : MiniProfileComparator
	{
		[Cpp2IlInjected.Token(Token = "0x6005455")]
		[Cpp2IlInjected.Address(RVA = "0x784780", Offset = "0x783180", VA = "0x180784780")]
		protected LongComparator(MiniProfile miniProfile)
			: base(miniProfile)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005456")]
		[Cpp2IlInjected.Address(RVA = "0x18B34A0", Offset = "0x18B1EA0", VA = "0x1818B34A0")]
		protected bool IsOlder(long left, long right)
		{
			return left < right;
		}

		[Cpp2IlInjected.Token(Token = "0x6005457")]
		[Cpp2IlInjected.Address(RVA = "0x18B3490", Offset = "0x18B1E90", VA = "0x1818B3490")]
		protected bool IsNewer(long left, long right)
		{
			return left > right;
		}
	}
}
