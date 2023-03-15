using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200060C")]
	public class RewardItem : CustomButton
	{
		[Cpp2IlInjected.Token(Token = "0x170005FD")]
		public TextBase Amount
		{
			[Cpp2IlInjected.Token(Token = "0x600279C")]
			[Cpp2IlInjected.Address(RVA = "0xE32C90", Offset = "0xE31690", VA = "0x180E32C90")]
			get
			{
				//Discarded unreachable code: IL_000c
				return base.View.Label;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005FE")]
		public AsyncAtlassedIcon Icon
		{
			[Cpp2IlInjected.Token(Token = "0x600279D")]
			[Cpp2IlInjected.Address(RVA = "0xE32CB0", Offset = "0xE316B0", VA = "0x180E32CB0")]
			get
			{
				//Discarded unreachable code: IL_0011
				return base.View.DynamicIcon.AsyncAtlassedIcon;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600279E")]
		[Cpp2IlInjected.Address(RVA = "0x863470", Offset = "0x861E70", VA = "0x180863470")]
		public RewardItem()
		{
		}
	}
}
