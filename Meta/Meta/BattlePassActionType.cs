using System;
using Cpp2IlInjected;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20009AB")]
	[Flags]
	public enum BattlePassActionType
	{
		[Cpp2IlInjected.Token(Token = "0x400280A")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400280B")]
		CollectCurrencies = 1,
		[Cpp2IlInjected.Token(Token = "0x400280C")]
		BuyPremium = 2,
		[Cpp2IlInjected.Token(Token = "0x400280D")]
		BuyCurrencies = 4,
		[Cpp2IlInjected.Token(Token = "0x400280E")]
		BuyReward = 8,
		[Cpp2IlInjected.Token(Token = "0x400280F")]
		BuyBundle = 0x1000
	}
}
