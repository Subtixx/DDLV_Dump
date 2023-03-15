using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.WellKnownTypes;

namespace Meta.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2001108")]
	public class MealExtraInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17001853")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4004638")]
		public BuffType Buff
		{
			[Cpp2IlInjected.Token(Token = "0x6008AD9")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6008ADA")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001854")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4004639")]
		public float BuffPercentageEffect
		{
			[Cpp2IlInjected.Token(Token = "0x6008ADB")]
			[Cpp2IlInjected.Address(RVA = "0x7F3600", Offset = "0x7F2000", VA = "0x1807F3600")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6008ADC")]
			[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F2010", VA = "0x1807F3610")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001855")]
		public Duration Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6008ADD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CDuration_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6008ADE")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CDuration_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008ADF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public MealExtraInfo()
		{
		}
	}
}
