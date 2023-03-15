using Cpp2IlInjected;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	public class Price
	{
		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000624")]
		public int CurrencyItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4000625")]
		public int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60007C1")]
			[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public Price()
		{
		}
	}
}
