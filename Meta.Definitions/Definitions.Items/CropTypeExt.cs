using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000647")]
	public static class CropTypeExt
	{
		[Cpp2IlInjected.Token(Token = "0x6004A24")]
		[Cpp2IlInjected.Address(RVA = "0x2D42820", Offset = "0x2D41220", VA = "0x182D42820")]
		public static bool IsSameAs(this CropTypeCondition me, CropType other)
		{
			if (me == CropTypeCondition.Any)
			{
				return true;
			}
			bool flag = other != CropType.Fruit;
			return me == (flag ? CropTypeCondition.Fruit : CropTypeCondition.Any);
		}

		[Cpp2IlInjected.Token(Token = "0x6004A25")]
		[Cpp2IlInjected.Address(RVA = "0x2D42800", Offset = "0x2D41200", VA = "0x182D42800")]
		public static bool IsSameAs(this CropType me, CropTypeCondition other)
		{
			if (other == CropTypeCondition.Any)
			{
				return true;
			}
			bool flag = me != CropType.Fruit;
			return other == (flag ? CropTypeCondition.Fruit : CropTypeCondition.Any);
		}

		[Cpp2IlInjected.Token(Token = "0x6004A26")]
		[Cpp2IlInjected.Address(RVA = "0xD766E0", Offset = "0xD750E0", VA = "0x180D766E0")]
		public static bool IsSameAs(this CropType me, CropType other)
		{
			return me == other;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A27")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F2C0", Offset = "0x2C9DCC0", VA = "0x182C9F2C0")]
		public static bool IsSameAs(this CropTypeCondition me, CropTypeCondition other)
		{
			if (me != other && me != 0)
			{
				return other == CropTypeCondition.Any;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A28")]
		[Cpp2IlInjected.Address(RVA = "0x2D42840", Offset = "0x2D41240", VA = "0x182D42840")]
		public static CropTypeCondition ToCropTypeCondition(this CropType me)
		{
			bool flag = me != CropType.Fruit;
			/*Error: Unexpected end of block*/;
		}
	}
}
