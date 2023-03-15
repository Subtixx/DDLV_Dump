using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public class Amount
	{
		[Cpp2IlInjected.Token(Token = "0x17000142")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000373")]
		public int Quantity
		{
			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4000374")]
		public int Changed
		{
			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public int OldAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x1023F90", Offset = "0x1022990", VA = "0x181023F90")]
			get
			{
				return Quantity;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public Amount()
		{
		}
	}
}
