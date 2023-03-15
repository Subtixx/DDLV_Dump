using System;
using Cpp2IlInjected;
using glPlayFab;

namespace Meta.Online.Economy
{
	[Cpp2IlInjected.Token(Token = "0x2000FC4")]
	public sealed class EconomyManagerBuilder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40040EA")]
		private ClientSession session;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40040EB")]
		private Func<ClientSession, IRedeemer> redeemerFunc;

		[Cpp2IlInjected.Token(Token = "0x6007F7C")]
		[Cpp2IlInjected.Address(RVA = "0x174ABF0", Offset = "0x17495F0", VA = "0x18174ABF0")]
		public EconomyManagerBuilder(IRedeemer redeemer)
		{
			Func<ClientSession, IRedeemer> func = (redeemerFunc = (Func<ClientSession, IRedeemer>)(object)(Func<T, TResult>)((ClientSession context) => redeemer));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007F7D")]
		[Cpp2IlInjected.Address(RVA = "0x5391F0", Offset = "0x537BF0", VA = "0x1805391F0")]
		public EconomyManagerBuilder(Func<ClientSession, IRedeemer> redeemerFunc)
		{
			this.redeemerFunc = redeemerFunc;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F7E")]
		[Cpp2IlInjected.Address(RVA = "0xEE6C80", Offset = "0xEE5680", VA = "0x180EE6C80")]
		public EconomyManagerBuilder ForSession(ClientSession session)
		{
			this.session = session;
			return this;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F7F")]
		[Cpp2IlInjected.Address(RVA = "0x174AAA0", Offset = "0x17494A0", VA = "0x18174AAA0")]
		public EconomyManager Build()
		{
			//Discarded unreachable code: IL_0038
			IRedeemer redeemer;
			ClientSession clientSession;
			do
			{
				Func<ClientSession, IRedeemer> func = redeemerFunc;
				ClientSession arg = session;
				redeemer = (IRedeemer)func((T)arg);
				clientSession = session;
			}
			while (redeemer == null);
			EconomyManager economyManager = default(EconomyManager);
			economyManager.redeemer = redeemer;
			if (clientSession != null)
			{
				economyManager.session = clientSession;
				return economyManager;
			}
			ArgumentNullException ex = new ArgumentNullException("session");
			/*Error: Unexpected end of block*/;
		}
	}
}
