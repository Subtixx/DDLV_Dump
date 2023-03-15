using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CloudScripts;
using Cpp2IlInjected;
using glPlayFab;
using PlayFab.EconomyModels;

namespace Meta.Online.Economy
{
	[Cpp2IlInjected.Token(Token = "0x2000FD5")]
	public sealed class MarketplaceRedeemer : IRedeemer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004114")]
		private readonly IMarketplaceRequestProvider requestProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004115")]
		private readonly IMarketplaceResponseHandler responseHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004116")]
		private readonly ILocalEntitlementsProvider localEntitlementsProvider;

		[Cpp2IlInjected.Token(Token = "0x6007FA3")]
		[Cpp2IlInjected.Address(RVA = "0x7F3330", Offset = "0x7F1D30", VA = "0x1807F3330")]
		public MarketplaceRedeemer(IMarketplaceRequestProvider requestProvider, [Optional] IMarketplaceResponseHandler responseHandler, [Optional] ILocalEntitlementsProvider localEntitlementsProvider)
		{
			if (requestProvider != null)
			{
				this.requestProvider = requestProvider;
				this.responseHandler = responseHandler;
				this.localEntitlementsProvider = localEntitlementsProvider;
			}
			ArgumentNullException ex = new ArgumentNullException("requestProvider");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007FA4")]
		[Cpp2IlInjected.Address(RVA = "0x7F30E0", Offset = "0x7F1AE0", VA = "0x1807F30E0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CRedeemAsync_003Ed__4))]
		public Task RedeemAsync(ClientSession session, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007FA5")]
		[Cpp2IlInjected.Address(RVA = "0x7F2490", Offset = "0x7F0E90", VA = "0x1807F2490", Slot = "5")]
		[AsyncStateMachine(typeof(_003CGetEntitlementsAsync_003Ed__5))]
		public Task<RedeemProductIds.Request> GetEntitlementsAsync()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<RedeemProductIds.Request>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007FA6")]
		[Cpp2IlInjected.Address(RVA = "0x7F3210", Offset = "0x7F1C10", VA = "0x1807F3210", Slot = "6")]
		[AsyncStateMachine(typeof(_003CVerifyPurchaseAsync_003Ed__6))]
		public Task VerifyPurchaseAsync(ClientSession session, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007FA7")]
		[Cpp2IlInjected.Address(RVA = "0x7F25D0", Offset = "0x7F0FD0", VA = "0x1807F25D0")]
		public static void PrettyTraceRedeemResult(RedeemMarketplaceAssetsResult redeemResult)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
