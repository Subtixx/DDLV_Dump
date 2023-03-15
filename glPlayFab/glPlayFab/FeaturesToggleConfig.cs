using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public class FeaturesToggleConfig : ITitleDataConfig
	{
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private static readonly string TitleDataKeyName = "FeaturesToggle";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public string RedeemProductIdAllowedVersion = string.Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public bool RedeemProductIdAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public bool RefundProductIdAllowed;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x102E930", Offset = "0x102D330", VA = "0x18102E930", Slot = "4")]
		public string GetTitleDataConfigKeyName()
		{
			return TitleDataKeyName;
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x102E9E0", Offset = "0x102D3E0", VA = "0x18102E9E0")]
		public FeaturesToggleConfig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x102E990", Offset = "0x102D390", VA = "0x18102E990")]
		static FeaturesToggleConfig()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
