using System;
using System.Threading;
using System.Threading.Tasks;
using CloudScripts;
using Cpp2IlInjected;
using glPlayFab;

namespace Meta.Online.Economy
{
	[Cpp2IlInjected.Token(Token = "0x2000FC3")]
	public sealed class EconomyManager
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40040E8")]
		private readonly IRedeemer redeemer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40040E9")]
		private readonly ClientSession session;

		[Cpp2IlInjected.Token(Token = "0x6007F78")]
		[Cpp2IlInjected.Address(RVA = "0x174AE50", Offset = "0x1749850", VA = "0x18174AE50")]
		public EconomyManager(IRedeemer redeemer, ClientSession session)
		{
			if (redeemer != null)
			{
				this.redeemer = redeemer;
				if (session == null)
				{
					goto IL_0027;
				}
				this.session = session;
			}
			ArgumentNullException ex = new ArgumentNullException("redeemer");
			goto IL_0027;
			IL_0027:
			ArgumentNullException ex2 = new ArgumentNullException("session");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F79")]
		[Cpp2IlInjected.Address(RVA = "0x174AD90", Offset = "0x1749790", VA = "0x18174AD90")]
		public Task RedeemAsync(CancellationToken ct)
		{
			//Discarded unreachable code: IL_000d
			IRedeemer redeemer = this.redeemer;
			return (Task)typeof(IRedeemer).TypeHandle;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F7A")]
		[Cpp2IlInjected.Address(RVA = "0x174ADF0", Offset = "0x17497F0", VA = "0x18174ADF0")]
		public Task VerifyPurchaseAsync(CancellationToken ct)
		{
			//Discarded unreachable code: IL_000d
			IRedeemer redeemer = this.redeemer;
			return (Task)typeof(IRedeemer).TypeHandle;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F7B")]
		[Cpp2IlInjected.Address(RVA = "0x174ACD0", Offset = "0x17496D0", VA = "0x18174ACD0")]
		public Task<RedeemProductIds.Request> GetEntitlementsAsync()
		{
			//Discarded unreachable code: IL_001c, IL_0023
			IRedeemer redeemer = this.redeemer;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			return (Task<RedeemProductIds.Request>)(object)redeemer.GetEntitlementsAsync();
		}
	}
}
