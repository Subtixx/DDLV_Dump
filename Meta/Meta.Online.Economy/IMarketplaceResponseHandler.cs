using Cpp2IlInjected;

namespace Meta.Online.Economy
{
	[Cpp2IlInjected.Token(Token = "0x2000FD3")]
	public interface IMarketplaceResponseHandler
	{
		[Cpp2IlInjected.Token(Token = "0x6007F9F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HandleRedeemResponse(RedeemResponse redeemResponse);
	}
}
