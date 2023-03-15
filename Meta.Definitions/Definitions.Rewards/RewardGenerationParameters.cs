using Cpp2IlInjected;
using Definitions.Items;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x2000243")]
	public class RewardGenerationParameters
	{
		[Cpp2IlInjected.Token(Token = "0x170004C2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000908")]
		public RewardAppearanceCondition? RewardAppearanceCondition
		{
			[Cpp2IlInjected.Token(Token = "0x6001583")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001584")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AB0", Offset = "0x6E44B0", VA = "0x1806E5AB0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6001585")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public RewardGenerationParameters()
		{
		}
	}
}
