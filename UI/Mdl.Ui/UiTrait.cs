using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20008C2")]
	public class UiTrait
	{
		[Cpp2IlInjected.Token(Token = "0x20008C3")]
		public enum Trait
		{
			[Cpp2IlInjected.Token(Token = "0x4003468")]
			Complexity,
			[Cpp2IlInjected.Token(Token = "0x4003469")]
			Mood,
			[Cpp2IlInjected.Token(Token = "0x400346A")]
			Normality,
			[Cpp2IlInjected.Token(Token = "0x400346B")]
			Sturdiness
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003464")]
		public Trait type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4003465")]
		public int SubIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003466")]
		public int MandatoryAmount;

		[Cpp2IlInjected.Token(Token = "0x6003736")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public UiTrait()
		{
		}
	}
}
