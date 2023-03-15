using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Util;
using glPlayFab;
using PlayFab;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000993")]
	public abstract class OnlineAction : IOnlineAction
	{
		[Cpp2IlInjected.Token(Token = "0x17000E8C")]
		bool IOnlineAction.IsPlayFabSuccess
		{
			[Cpp2IlInjected.Token(Token = "0x6005402")]
			[Cpp2IlInjected.Address(RVA = "0x13A1FA0", Offset = "0x13A09A0", VA = "0x1813A1FA0", Slot = "7")]
			get
			{
				return MyPlayFabResult == 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E8D")]
		protected abstract int MyPlayFabResult
		{
			[Cpp2IlInjected.Token(Token = "0x6005404")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005405")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000E8E")]
		public bool IsPlayFabSuccess
		{
			[Cpp2IlInjected.Token(Token = "0x6005406")]
			[Cpp2IlInjected.Address(RVA = "0x13A1FA0", Offset = "0x13A09A0", VA = "0x1813A1FA0")]
			get
			{
				return MyPlayFabResult == 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E8F")]
		public PlayFabErrorCode PlayFabErrorCode
		{
			[Cpp2IlInjected.Token(Token = "0x6005407")]
			[Cpp2IlInjected.Address(RVA = "0x13A1F60", Offset = "0x13A0960", VA = "0x1813A1F60")]
			get
			{
				int myPlayFabResult = MyPlayFabResult;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60053FF")]
		[Cpp2IlInjected.Address(RVA = "0x13A1E10", Offset = "0x13A0810", VA = "0x1813A1E10", Slot = "4")]
		public Task<bool> Execute(ClientSession clientSession, Profile profile, ProfileEventDispatcher dispatcher, ITransactionContext context, CancellationToken ct)
		{
			if (clientSession == null || clientSession.DisneyPlayfabContext != null)
			{
			}
			MyPlayFabResult = 2;
			return (Task<bool>)(object)Task.FromResult(result: false);
		}

		[Cpp2IlInjected.Token(Token = "0x6005400")]
		[Cpp2IlInjected.Address(RVA = "0x13A1F60", Offset = "0x13A0960", VA = "0x1813A1F60", Slot = "5")]
		PlayFabErrorCode IOnlineAction.GetPlayFabResult()
		{
			int myPlayFabResult = MyPlayFabResult;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005401")]
		[Cpp2IlInjected.Address(RVA = "0x13A1F80", Offset = "0x13A0980", VA = "0x1813A1F80", Slot = "6")]
		void IOnlineAction.SetPlayFabResult(PlayFabErrorCode playFabResult)
		{
			int myPlayFabResult = MyPlayFabResult;
		}

		[Cpp2IlInjected.Token(Token = "0x6005403")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x6005408")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected OnlineAction()
		{
		}
	}
}
