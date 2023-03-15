using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000645")]
	public static class SeedTypeExt
	{
		[Cpp2IlInjected.Token(Token = "0x6004A1E")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F290", Offset = "0x2C9DC90", VA = "0x182C9F290")]
		public static bool IsSameAs(this SeedTypeCondition me, SeedType other)
		{
			if (me == SeedTypeCondition.Any)
			{
			}
			if (other != 0)
			{
				bool flag = other != SeedType.FruitTree;
				return me == (flag ? SeedTypeCondition.Regular : SeedTypeCondition.Any);
			}
			uint num = default(uint);
			return me == (SeedTypeCondition)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A1F")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F2E0", Offset = "0x2C9DCE0", VA = "0x182C9F2E0")]
		public static bool IsSameAs(this SeedType me, SeedTypeCondition other)
		{
			if (other == SeedTypeCondition.Any)
			{
			}
			if (me != 0)
			{
				bool flag = me != SeedType.FruitTree;
				return other == (flag ? SeedTypeCondition.Regular : SeedTypeCondition.Any);
			}
			uint num = default(uint);
			return other == (SeedTypeCondition)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A20")]
		[Cpp2IlInjected.Address(RVA = "0xD766E0", Offset = "0xD750E0", VA = "0x180D766E0")]
		public static bool IsSameAs(this SeedType me, SeedType other)
		{
			return me == other;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A21")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F2C0", Offset = "0x2C9DCC0", VA = "0x182C9F2C0")]
		public static bool IsSameAs(this SeedTypeCondition me, SeedTypeCondition other)
		{
			if (me != other && me != 0)
			{
				return other == SeedTypeCondition.Any;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A22")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F310", Offset = "0x2C9DD10", VA = "0x182C9F310")]
		public static SeedTypeCondition ToSeedTypeCondition(this SeedType me)
		{
			while (me == SeedType.Regular)
			{
			}
			bool flag = me != SeedType.FruitTree;
			/*Error: Unexpected end of block*/;
		}
	}
}
