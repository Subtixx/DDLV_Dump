using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000648")]
	public static class EphemeralTypeExt
	{
		[Cpp2IlInjected.Token(Token = "0x6004A29")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F290", Offset = "0x2C9DC90", VA = "0x182C9F290")]
		public static bool IsSameAs(this EphemeralTypeCondition me, EphemeralType other)
		{
			if (me == EphemeralTypeCondition.Any)
			{
			}
			if (other != 0)
			{
				bool flag = other != EphemeralType.QuestItem;
				return me == (flag ? EphemeralTypeCondition.NightThorn : EphemeralTypeCondition.Any);
			}
			uint num = default(uint);
			return me == (EphemeralTypeCondition)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A2A")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F2E0", Offset = "0x2C9DCE0", VA = "0x182C9F2E0")]
		public static bool IsSameAs(this EphemeralType me, EphemeralTypeCondition other)
		{
			if (other == EphemeralTypeCondition.Any)
			{
			}
			if (me != 0)
			{
				bool flag = me != EphemeralType.QuestItem;
				return other == (flag ? EphemeralTypeCondition.NightThorn : EphemeralTypeCondition.Any);
			}
			uint num = default(uint);
			return other == (EphemeralTypeCondition)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A2B")]
		[Cpp2IlInjected.Address(RVA = "0xD766E0", Offset = "0xD750E0", VA = "0x180D766E0")]
		public static bool IsSameAs(this EphemeralType me, EphemeralType other)
		{
			return me == other;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A2C")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F2C0", Offset = "0x2C9DCC0", VA = "0x182C9F2C0")]
		public static bool IsSameAs(this EphemeralTypeCondition me, EphemeralTypeCondition other)
		{
			if (me != other && me != 0)
			{
				return other == EphemeralTypeCondition.Any;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A2D")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F310", Offset = "0x2C9DD10", VA = "0x182C9F310")]
		public static EphemeralTypeCondition ToEphemeralTypeCondition(this EphemeralType me)
		{
			while (me == EphemeralType.NightThorn)
			{
			}
			bool flag = me != EphemeralType.QuestItem;
			/*Error: Unexpected end of block*/;
		}
	}
}
