using Cpp2IlInjected;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20005F4")]
	public class CharacterLevelRewardItem : CustomElement
	{
		[Cpp2IlInjected.Token(Token = "0x20005F5")]
		public enum Phase
		{
			[Cpp2IlInjected.Token(Token = "0x4002110")]
			CurrencyOngoing,
			[Cpp2IlInjected.Token(Token = "0x4002111")]
			CurrencyClaimed,
			[Cpp2IlInjected.Token(Token = "0x4002112")]
			ItemOngoing,
			[Cpp2IlInjected.Token(Token = "0x4002113")]
			ItemClaimed,
			[Cpp2IlInjected.Token(Token = "0x4002114")]
			FinalOngoing,
			[Cpp2IlInjected.Token(Token = "0x4002115")]
			FinalClaimed,
			[Cpp2IlInjected.Token(Token = "0x4002116")]
			FinalGenderedOngoing,
			[Cpp2IlInjected.Token(Token = "0x4002117")]
			FinalGenderedClaimed
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400210D")]
		public AsyncAtlassedIcon RewardIconMale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400210E")]
		public UnityEvent[] OnPhases;

		[Cpp2IlInjected.Token(Token = "0x6002726")]
		[Cpp2IlInjected.Address(RVA = "0xFF8FF0", Offset = "0xFF79F0", VA = "0x180FF8FF0")]
		public CharacterLevelRewardItem()
		{
		}
	}
}
