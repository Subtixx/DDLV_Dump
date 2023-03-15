using Cpp2IlInjected;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	public class StoreRotation : StoreDefinition
	{
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		public enum RotationInterval
		{
			[Cpp2IlInjected.Token(Token = "0x4000609")]
			Daily,
			[Cpp2IlInjected.Token(Token = "0x400060A")]
			Weekly
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public override StoreType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0xD51100", Offset = "0xD4FB00", VA = "0x180D51100", Slot = "4")]
			get
			{
				return StoreType.Rotation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000606")]
		public RotationInterval Interval
		{
			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4000607")]
		public int NumItemsPerInterval
		{
			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600076F")]
			[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public StoreRotation()
		{
		}
	}
}
