using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200065D")]
	public interface IHasTraits
	{
		[Cpp2IlInjected.Token(Token = "0x17001329")]
		Complexity Complexity
		{
			[Cpp2IlInjected.Token(Token = "0x6004A57")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700132A")]
		int ComplexityStrength
		{
			[Cpp2IlInjected.Token(Token = "0x6004A58")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700132B")]
		Mood Mood
		{
			[Cpp2IlInjected.Token(Token = "0x6004A59")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700132C")]
		int MoodStrength
		{
			[Cpp2IlInjected.Token(Token = "0x6004A5A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700132D")]
		Sturdiness Sturdiness
		{
			[Cpp2IlInjected.Token(Token = "0x6004A5B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700132E")]
		int SturdinessStrength
		{
			[Cpp2IlInjected.Token(Token = "0x6004A5C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700132F")]
		Normality Normality
		{
			[Cpp2IlInjected.Token(Token = "0x6004A5D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001330")]
		int NormalityStrength
		{
			[Cpp2IlInjected.Token(Token = "0x6004A5E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
}
