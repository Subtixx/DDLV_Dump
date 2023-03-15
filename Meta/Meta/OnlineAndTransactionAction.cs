using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Util;
using glPlayFab;
using PlayFab;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000994")]
	public abstract class OnlineAndTransactionAction<TResult> : IOnlineAndTransactionAction, ITransactionAction, IOnlineAction where TResult : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000E90")]
		bool IOnlineAction.IsPlayFabSuccess
		{
			[Cpp2IlInjected.Token(Token = "0x600540E")]
			[Cpp2IlInjected.Address(RVA = "0x1A30F90", Offset = "0x1A2F990", VA = "0x181A30F90", Slot = "13")]
			get
			{
				int myPlayFabResult = MyPlayFabResult;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E91")]
		protected abstract int MyPlayFabResult
		{
			[Cpp2IlInjected.Token(Token = "0x6005410")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005411")]
			[Cpp2IlInjected.Address(Slot = "16")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000E92")]
		public bool IsPlayFabSuccess
		{
			[Cpp2IlInjected.Token(Token = "0x6005412")]
			[Cpp2IlInjected.Address(RVA = "0x25BF2B0", Offset = "0x25BDCB0", VA = "0x1825BF2B0")]
			get
			{
				//Discarded unreachable code: IL_000a
				return MyPlayFabResult == 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E93")]
		bool ITransactionAction.IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6005415")]
			[Cpp2IlInjected.Address(RVA = "0x25BF280", Offset = "0x25BDC80", VA = "0x1825BF280", Slot = "8")]
			get
			{
				int myPlayFabResult = MyPlayFabResult;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E94")]
		bool ITransactionAction.IsTriggeringSave
		{
			[Cpp2IlInjected.Token(Token = "0x6005416")]
			[Cpp2IlInjected.Address(RVA = "0x25BF250", Offset = "0x25BDC50", VA = "0x1825BF250", Slot = "9")]
			get
			{
				int myPlayFabResult = MyPlayFabResult;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E95")]
		protected abstract TResult MyResult
		{
			[Cpp2IlInjected.Token(Token = "0x6005418")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005419")]
			[Cpp2IlInjected.Address(Slot = "19")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000E96")]
		protected virtual bool IsTriggeringSave
		{
			[Cpp2IlInjected.Token(Token = "0x600541A")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "20")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E97")]
		public virtual bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600541B")]
			[Cpp2IlInjected.Address(RVA = "0x25BF360", Offset = "0x25BDD60", VA = "0x1825BF360", Slot = "21")]
			get
			{
				//Discarded unreachable code: IL_0012
				TResult myResult = MyResult;
				return (long)"{il2cpp field on {'constant7' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x0}" == 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005409")]
		[Cpp2IlInjected.Address(RVA = "0x25BEE30", Offset = "0x25BD830", VA = "0x1825BEE30", Slot = "10")]
		public Task<bool> Execute(ClientSession clientSession, Profile profile, ProfileEventDispatcher dispatcher, ITransactionContext context, CancellationToken ct)
		{
			Task<bool> result = default(Task<bool>);
			if (clientSession != null && clientSession.DisneyPlayfabContext != null)
			{
				return result;
			}
			MyPlayFabResult = 2;
			Task<> task = Task.FromResult(result: false);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600540A")]
		[Cpp2IlInjected.Address(RVA = "0x25BEB30", Offset = "0x25BD530", VA = "0x1825BEB30", Slot = "4")]
		[AsyncStateMachine(typeof(OnlineAndTransactionAction<>._003CExecuteAndApply_003Ed__1))]
		public Task<bool> ExecuteAndApply(ClientSession clientSession, Player player, World world, ITransactionContext transactionContext, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600540B")]
		[Cpp2IlInjected.Address(RVA = "0x25BE850", Offset = "0x25BD250", VA = "0x1825BE850")]
		public bool Apply(in Player player, in World world, ITransactionContext transactionContext)
		{
			//Discarded unreachable code: IL_0027
			string fullName = GetType().FullName;
			string text = "OnlineAndProfileAction<" + fullName + ">.Apply";
			return ApplyThis(in player, in world, transactionContext);
		}

		[Cpp2IlInjected.Token(Token = "0x600540C")]
		[Cpp2IlInjected.Address(RVA = "0x25BEF90", Offset = "0x25BD990", VA = "0x1825BEF90", Slot = "11")]
		PlayFabErrorCode IOnlineAction.GetPlayFabResult()
		{
			int myPlayFabResult = MyPlayFabResult;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600540D")]
		[Cpp2IlInjected.Address(RVA = "0x25BEFC0", Offset = "0x25BD9C0", VA = "0x1825BEFC0", Slot = "12")]
		void IOnlineAction.SetPlayFabResult(PlayFabErrorCode playFabResult)
		{
			//Discarded unreachable code: IL_0008
			int myPlayFabResult = MyPlayFabResult;
		}

		[Cpp2IlInjected.Token(Token = "0x600540F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x6005413")]
		[Cpp2IlInjected.Address(RVA = "0x25BF050", Offset = "0x25BDA50", VA = "0x1825BF050", Slot = "6")]
		object ITransactionAction.GetResult()
		{
			TResult myResult = MyResult;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005414")]
		[Cpp2IlInjected.Address(RVA = "0x25BF180", Offset = "0x25BDB80", VA = "0x1825BF180", Slot = "7")]
		void ITransactionAction.SetResult(int result)
		{
		}//Discarded unreachable code: IL_0001


		[Cpp2IlInjected.Token(Token = "0x6005417")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext);

		[Cpp2IlInjected.Token(Token = "0x600541C")]
		[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x911AA0", VA = "0x1809130A0")]
		protected OnlineAndTransactionAction()
		{
		}//Discarded unreachable code: IL_0007


		[Cpp2IlInjected.Token(Token = "0x600541D")]
		[Cpp2IlInjected.Address(RVA = "0x25BEFF0", Offset = "0x25BD9F0", VA = "0x1825BEFF0", Slot = "5")]
		bool ITransactionAction.Apply(in Player player, in World world, ITransactionContext transactionContext)
		{
			int myPlayFabResult = MyPlayFabResult;
			throw new NullReferenceException();
		}
	}
}
