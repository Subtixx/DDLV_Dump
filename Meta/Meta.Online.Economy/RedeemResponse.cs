using Cpp2IlInjected;
using PlayFab;
using PlayFab.EconomyModels;

namespace Meta.Online.Economy
{
	[Cpp2IlInjected.Token(Token = "0x2000FD2")]
	public class RedeemResponse
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004113")]
		public PlayFabResult<RedeemMarketplaceAssetsResult> redeemMarketplaceAssetsResult;

		[Cpp2IlInjected.Token(Token = "0x6007F9E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public RedeemResponse()
		{
		}
	}
}
