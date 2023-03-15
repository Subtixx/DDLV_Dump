using System.Threading;
using System.Threading.Tasks;
using CloudScripts;
using Cpp2IlInjected;
using glPlayFab;

namespace Meta.Online.Economy
{
	[Cpp2IlInjected.Token(Token = "0x2000FD4")]
	public interface IRedeemer
	{
		[Cpp2IlInjected.Token(Token = "0x6007FA0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task RedeemAsync(ClientSession session, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x6007FA1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RedeemProductIds.Request> GetEntitlementsAsync();

		[Cpp2IlInjected.Token(Token = "0x6007FA2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task VerifyPurchaseAsync(ClientSession session, CancellationToken ct);
	}
}
