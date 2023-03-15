using Cpp2IlInjected;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200099D")]
	public abstract class IntComparator : MiniProfileComparator
	{
		[Cpp2IlInjected.Token(Token = "0x6005452")]
		[Cpp2IlInjected.Address(RVA = "0x784780", Offset = "0x783180", VA = "0x180784780")]
		protected IntComparator(MiniProfile miniProfile)
			: base(miniProfile)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005453")]
		[Cpp2IlInjected.Address(RVA = "0x1709D50", Offset = "0x1708750", VA = "0x181709D50")]
		protected bool IsOlder(int left, int right)
		{
			return left < right;
		}

		[Cpp2IlInjected.Token(Token = "0x6005454")]
		[Cpp2IlInjected.Address(RVA = "0x1709D40", Offset = "0x1708740", VA = "0x181709D40")]
		protected bool IsNewer(int left, int right)
		{
			return left > right;
		}
	}
}
