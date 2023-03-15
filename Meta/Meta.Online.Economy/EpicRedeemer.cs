using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CloudScripts;
using Cpp2IlInjected;
using glPlayFab;

namespace Meta.Online.Economy
{
	[Cpp2IlInjected.Token(Token = "0x2000FC6")]
	public sealed class EpicRedeemer : IRedeemer
	{
		[Cpp2IlInjected.Token(Token = "0x2000FC7")]
		public class EpicRedeemCredential
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40040F1")]
			public string AccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40040F2")]
			public string ClientId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40040F3")]
			public string AccessToken;

			[Cpp2IlInjected.Token(Token = "0x6007F89")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public EpicRedeemCredential()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40040ED")]
		private const string storeKey = "Epic";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40040EE")]
		private readonly LocalStorage storage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40040EF")]
		private readonly Func<Task<string>> getItemOwnershipTokenAsync;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40040F0")]
		private readonly Func<Task<EpicRedeemCredential>> getEpicRedeemCredential;

		[Cpp2IlInjected.Token(Token = "0x6007F82")]
		[Cpp2IlInjected.Address(RVA = "0x174E180", Offset = "0x174CB80", VA = "0x18174E180")]
		public EpicRedeemer(Func<Task<string>> getItemOwnershipTokenAsync, LocalStorage storage, Func<Task<EpicRedeemCredential>> getEpicRedeemCredential)
		{
			while (true)
			{
				base._002Ector();
				if (getItemOwnershipTokenAsync != null)
				{
					this.getItemOwnershipTokenAsync = getItemOwnershipTokenAsync;
					if (storage == null)
					{
						continue;
					}
					this.storage = storage;
					if (getEpicRedeemCredential == null)
					{
						break;
					}
					this.getEpicRedeemCredential = getEpicRedeemCredential;
				}
				ArgumentNullException ex = new ArgumentNullException("getItemOwnershipTokenAsync");
				break;
			}
			ArgumentNullException ex2 = new ArgumentNullException("getEpicRedeemCredential");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F83")]
		[Cpp2IlInjected.Address(RVA = "0x174DDB0", Offset = "0x174C7B0", VA = "0x18174DDB0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CMeta_002DOnline_002DEconomy_002DIRedeemer_002DRedeemAsync_003Ed__6))]
		Task IRedeemer.RedeemAsync(ClientSession session, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F84")]
		[Cpp2IlInjected.Address(RVA = "0x174DEE0", Offset = "0x174C8E0", VA = "0x18174DEE0")]
		[AsyncStateMachine(typeof(_003CRedeemEntitlementsAsync_003Ed__7))]
		private Task RedeemEntitlementsAsync(ClientSession session, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F85")]
		[Cpp2IlInjected.Address(RVA = "0x174E000", Offset = "0x174CA00", VA = "0x18174E000")]
		[AsyncStateMachine(typeof(_003CRedeemItemOwnershipAsync_003Ed__8))]
		private Task RedeemItemOwnershipAsync(ClientSession session, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F86")]
		[Cpp2IlInjected.Address(RVA = "0x174D7F0", Offset = "0x174C1F0", VA = "0x18174D7F0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CGetEntitlementsAsync_003Ed__9))]
		public Task<RedeemProductIds.Request> GetEntitlementsAsync()
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<RedeemProductIds.Request>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F87")]
		[Cpp2IlInjected.Address(RVA = "0x174E130", Offset = "0x174CB30", VA = "0x18174E130", Slot = "6")]
		public Task VerifyPurchaseAsync(ClientSession session, CancellationToken ct)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F88")]
		[Cpp2IlInjected.Address(RVA = "0x174D8E0", Offset = "0x174C2E0", VA = "0x18174D8E0")]
		private bool IsAnyNewItemToRedeem(LocalStorageData.StoreInfo store, string token)
		{
			//Discarded unreachable code: IL_0032, IL_0037, IL_004c, IL_0080, IL_0085, IL_008e, IL_0092, IL_0097, IL_009c, IL_00a0, IL_00a8, IL_00b1, IL_00be, IL_00c4, IL_00ca, IL_00d0
			int num = 0;
			int num2 = 0;
			if ("catalogItemId" == null)
			{
				if (store.RedeemedPurchases == null)
				{
					Dictionary<string, List<string>> dictionary = (store.RedeemedPurchases = (Dictionary<string, List<string>>)(object)new Dictionary<TKey, TValue>());
					Dictionary<string, List<string>> _003CRedeemedPurchases_003Ek__BackingField = store.RedeemedPurchases;
				}
				throw new NullReferenceException();
			}
			int num3 = 0;
			throw new NullReferenceException();
		}
	}
}
