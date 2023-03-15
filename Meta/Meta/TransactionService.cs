using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Rpc.Core;
using Gameloft.Rpc.Core.Client;
using Gameloft.Rpc.Core.Server;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20005EA")]
	public static class TransactionService
	{
		[Cpp2IlInjected.Token(Token = "0x20005EB")]
		public class TransactionServiceBase : ServiceBase
		{
			[Cpp2IlInjected.Token(Token = "0x60038E6")]
			[Cpp2IlInjected.Address(RVA = "0x58FAE0", Offset = "0x58E4E0", VA = "0x18058FAE0")]
			public TransactionServiceBase()
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x60038E7")]
			[Cpp2IlInjected.Address(RVA = "0x582C50", Offset = "0x581650", VA = "0x180582C50")]
			[AsyncStateMachine(typeof(_003CPingInvokerAsync_003Ed__1))]
			public Task<CallResult<IMessage>> PingInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60038E8")]
			[Cpp2IlInjected.Address(RVA = "0x582AA0", Offset = "0x5814A0", VA = "0x180582AA0")]
			[AsyncStateMachine(typeof(_003CPingAsyncStub_003Ed__2))]
			public Task<IMessage> PingAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60038E9")]
			[Cpp2IlInjected.Address(RVA = "0x582C00", Offset = "0x581600", VA = "0x180582C00", Slot = "8")]
			public virtual Task<Ping.Types.Response> PingAsync(Ping.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: PingAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60038EA")]
			[Cpp2IlInjected.Address(RVA = "0x586060", Offset = "0x584A60", VA = "0x180586060")]
			[AsyncStateMachine(typeof(_003CSaveProfileInvokerAsync_003Ed__4))]
			public Task<CallResult<IMessage>> SaveProfileInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60038EB")]
			[Cpp2IlInjected.Address(RVA = "0x585EB0", Offset = "0x5848B0", VA = "0x180585EB0")]
			[AsyncStateMachine(typeof(_003CSaveProfileAsyncStub_003Ed__5))]
			public Task<IMessage> SaveProfileAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60038EC")]
			[Cpp2IlInjected.Address(RVA = "0x586010", Offset = "0x584A10", VA = "0x180586010", Slot = "9")]
			public virtual Task<SaveProfile.Types.Response> SaveProfileAsync(SaveProfile.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SaveProfileAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60038ED")]
			[Cpp2IlInjected.Address(RVA = "0x573130", Offset = "0x571B30", VA = "0x180573130")]
			[AsyncStateMachine(typeof(_003CChangeCurrentSceneInvokerAsync_003Ed__7))]
			public Task<CallResult<IMessage>> ChangeCurrentSceneInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60038EE")]
			[Cpp2IlInjected.Address(RVA = "0x572F80", Offset = "0x571980", VA = "0x180572F80")]
			[AsyncStateMachine(typeof(_003CChangeCurrentSceneAsyncStub_003Ed__8))]
			public Task<IMessage> ChangeCurrentSceneAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60038EF")]
			[Cpp2IlInjected.Address(RVA = "0x5730E0", Offset = "0x571AE0", VA = "0x1805730E0", Slot = "10")]
			public virtual Task<ChangeCurrentScene.Types.Response> ChangeCurrentSceneAsync(ChangeCurrentScene.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ChangeCurrentSceneAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60038F0")]
			[Cpp2IlInjected.Address(RVA = "0x588210", Offset = "0x586C10", VA = "0x180588210")]
			[AsyncStateMachine(typeof(_003CSetManaHasAlreadyMissedInvokerAsync_003Ed__10))]
			public Task<CallResult<IMessage>> SetManaHasAlreadyMissedInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60038F1")]
			[Cpp2IlInjected.Address(RVA = "0x588060", Offset = "0x586A60", VA = "0x180588060")]
			[AsyncStateMachine(typeof(_003CSetManaHasAlreadyMissedAsyncStub_003Ed__11))]
			public Task<IMessage> SetManaHasAlreadyMissedAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60038F2")]
			[Cpp2IlInjected.Address(RVA = "0x5881C0", Offset = "0x586BC0", VA = "0x1805881C0", Slot = "11")]
			public virtual Task<SetManaHasAlreadyMissed.Types.Response> SetManaHasAlreadyMissedAsync(SetManaHasAlreadyMissed.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SetManaHasAlreadyMissedAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60038F3")]
			[Cpp2IlInjected.Address(RVA = "0x57DCB0", Offset = "0x57C6B0", VA = "0x18057DCB0")]
			[AsyncStateMachine(typeof(_003CEnterRealmInvokerAsync_003Ed__13))]
			public Task<CallResult<IMessage>> EnterRealmInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60038F4")]
			[Cpp2IlInjected.Address(RVA = "0x57DB00", Offset = "0x57C500", VA = "0x18057DB00")]
			[AsyncStateMachine(typeof(_003CEnterRealmAsyncStub_003Ed__14))]
			public Task<IMessage> EnterRealmAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60038F5")]
			[Cpp2IlInjected.Address(RVA = "0x57DC60", Offset = "0x57C660", VA = "0x18057DC60", Slot = "12")]
			public virtual Task<EnterRealm.Types.Response> EnterRealmAsync(EnterRealm.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: EnterRealmAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60038F6")]
			[Cpp2IlInjected.Address(RVA = "0x58D1B0", Offset = "0x58BBB0", VA = "0x18058D1B0")]
			[AsyncStateMachine(typeof(_003CUnlockRealmInvokerAsync_003Ed__16))]
			public Task<CallResult<IMessage>> UnlockRealmInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60038F7")]
			[Cpp2IlInjected.Address(RVA = "0x58D000", Offset = "0x58BA00", VA = "0x18058D000")]
			[AsyncStateMachine(typeof(_003CUnlockRealmAsyncStub_003Ed__17))]
			public Task<IMessage> UnlockRealmAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60038F8")]
			[Cpp2IlInjected.Address(RVA = "0x58D160", Offset = "0x58BB60", VA = "0x18058D160", Slot = "13")]
			public virtual Task<UnlockRealm.Types.Response> UnlockRealmAsync(UnlockRealm.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: UnlockRealmAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60038F9")]
			[Cpp2IlInjected.Address(RVA = "0x583580", Offset = "0x581F80", VA = "0x180583580")]
			[AsyncStateMachine(typeof(_003CPlaceOnGridInvokerAsync_003Ed__19))]
			public Task<CallResult<IMessage>> PlaceOnGridInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60038FA")]
			[Cpp2IlInjected.Address(RVA = "0x5833D0", Offset = "0x581DD0", VA = "0x1805833D0")]
			[AsyncStateMachine(typeof(_003CPlaceOnGridAsyncStub_003Ed__20))]
			public Task<IMessage> PlaceOnGridAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60038FB")]
			[Cpp2IlInjected.Address(RVA = "0x583530", Offset = "0x581F30", VA = "0x180583530", Slot = "14")]
			public virtual Task<PlaceOnGrid.Types.Response> PlaceOnGridAsync(PlaceOnGrid.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: PlaceOnGridAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60038FC")]
			[Cpp2IlInjected.Address(RVA = "0x5847E0", Offset = "0x5831E0", VA = "0x1805847E0")]
			[AsyncStateMachine(typeof(_003CRemoveFromGridInvokerAsync_003Ed__22))]
			public Task<CallResult<IMessage>> RemoveFromGridInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60038FD")]
			[Cpp2IlInjected.Address(RVA = "0x584630", Offset = "0x583030", VA = "0x180584630")]
			[AsyncStateMachine(typeof(_003CRemoveFromGridAsyncStub_003Ed__23))]
			public Task<IMessage> RemoveFromGridAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60038FE")]
			[Cpp2IlInjected.Address(RVA = "0x584790", Offset = "0x583190", VA = "0x180584790", Slot = "15")]
			public virtual Task<RemoveFromGrid.Types.Response> RemoveFromGridAsync(RemoveFromGrid.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: RemoveFromGridAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60038FF")]
			[Cpp2IlInjected.Address(RVA = "0x5844D0", Offset = "0x582ED0", VA = "0x1805844D0")]
			[AsyncStateMachine(typeof(_003CRemoveBlockerInvokerAsync_003Ed__25))]
			public Task<CallResult<IMessage>> RemoveBlockerInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003900")]
			[Cpp2IlInjected.Address(RVA = "0x584320", Offset = "0x582D20", VA = "0x180584320")]
			[AsyncStateMachine(typeof(_003CRemoveBlockerAsyncStub_003Ed__26))]
			public Task<IMessage> RemoveBlockerAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003901")]
			[Cpp2IlInjected.Address(RVA = "0x584480", Offset = "0x582E80", VA = "0x180584480", Slot = "16")]
			public virtual Task<RemoveBlocker.Types.Response> RemoveBlockerAsync(RemoveBlocker.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: RemoveBlockerAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003902")]
			[Cpp2IlInjected.Address(RVA = "0x580AA0", Offset = "0x57F4A0", VA = "0x180580AA0")]
			[AsyncStateMachine(typeof(_003CLoginInvokerAsync_003Ed__28))]
			public Task<CallResult<IMessage>> LoginInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003903")]
			[Cpp2IlInjected.Address(RVA = "0x5808F0", Offset = "0x57F2F0", VA = "0x1805808F0")]
			[AsyncStateMachine(typeof(_003CLoginAsyncStub_003Ed__29))]
			public Task<IMessage> LoginAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003904")]
			[Cpp2IlInjected.Address(RVA = "0x580A50", Offset = "0x57F450", VA = "0x180580A50", Slot = "17")]
			public virtual Task<Login.Types.Response> LoginAsync(Login.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: LoginAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003905")]
			[Cpp2IlInjected.Address(RVA = "0x570960", Offset = "0x56F360", VA = "0x180570960")]
			[AsyncStateMachine(typeof(_003CActualizeInvokerAsync_003Ed__31))]
			public Task<CallResult<IMessage>> ActualizeInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003906")]
			[Cpp2IlInjected.Address(RVA = "0x5707B0", Offset = "0x56F1B0", VA = "0x1805707B0")]
			[AsyncStateMachine(typeof(_003CActualizeAsyncStub_003Ed__32))]
			public Task<IMessage> ActualizeAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003907")]
			[Cpp2IlInjected.Address(RVA = "0x570910", Offset = "0x56F310", VA = "0x180570910", Slot = "18")]
			public virtual Task<Actualize.Types.Response> ActualizeAsync(Actualize.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ActualizeAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003908")]
			[Cpp2IlInjected.Address(RVA = "0x580790", Offset = "0x57F190", VA = "0x180580790")]
			[AsyncStateMachine(typeof(_003CInitWithServerProfileInvokerAsync_003Ed__34))]
			public Task<CallResult<IMessage>> InitWithServerProfileInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003909")]
			[Cpp2IlInjected.Address(RVA = "0x5805E0", Offset = "0x57EFE0", VA = "0x1805805E0")]
			[AsyncStateMachine(typeof(_003CInitWithServerProfileAsyncStub_003Ed__35))]
			public Task<IMessage> InitWithServerProfileAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600390A")]
			[Cpp2IlInjected.Address(RVA = "0x580740", Offset = "0x57F140", VA = "0x180580740", Slot = "19")]
			public virtual Task<InitWithServerProfile.Types.Response> InitWithServerProfileAsync(InitWithServerProfile.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: InitWithServerProfileAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600390B")]
			[Cpp2IlInjected.Address(RVA = "0x588830", Offset = "0x587230", VA = "0x180588830")]
			[AsyncStateMachine(typeof(_003CSetNameInvokerAsync_003Ed__37))]
			public Task<CallResult<IMessage>> SetNameInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600390C")]
			[Cpp2IlInjected.Address(RVA = "0x588680", Offset = "0x587080", VA = "0x180588680")]
			[AsyncStateMachine(typeof(_003CSetNameAsyncStub_003Ed__38))]
			public Task<IMessage> SetNameAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600390D")]
			[Cpp2IlInjected.Address(RVA = "0x5887E0", Offset = "0x5871E0", VA = "0x1805887E0", Slot = "20")]
			public virtual Task<SetName.Types.Response> SetNameAsync(SetName.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SetNameAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600390E")]
			[Cpp2IlInjected.Address(RVA = "0x58C570", Offset = "0x58AF70", VA = "0x18058C570")]
			[AsyncStateMachine(typeof(_003CTrackClaimedFoundersPackInvokerAsync_003Ed__40))]
			public Task<CallResult<IMessage>> TrackClaimedFoundersPackInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600390F")]
			[Cpp2IlInjected.Address(RVA = "0x58C3C0", Offset = "0x58ADC0", VA = "0x18058C3C0")]
			[AsyncStateMachine(typeof(_003CTrackClaimedFoundersPackAsyncStub_003Ed__41))]
			public Task<IMessage> TrackClaimedFoundersPackAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003910")]
			[Cpp2IlInjected.Address(RVA = "0x58C520", Offset = "0x58AF20", VA = "0x18058C520", Slot = "21")]
			public virtual Task<TrackClaimedFoundersPack.Types.Response> TrackClaimedFoundersPackAsync(TrackClaimedFoundersPack.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: TrackClaimedFoundersPackAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003911")]
			[Cpp2IlInjected.Address(RVA = "0x582010", Offset = "0x580A10", VA = "0x180582010")]
			[AsyncStateMachine(typeof(_003CPickUpContainerItemInvokerAsync_003Ed__43))]
			public Task<CallResult<IMessage>> PickUpContainerItemInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003912")]
			[Cpp2IlInjected.Address(RVA = "0x581E60", Offset = "0x580860", VA = "0x180581E60")]
			[AsyncStateMachine(typeof(_003CPickUpContainerItemAsyncStub_003Ed__44))]
			public Task<IMessage> PickUpContainerItemAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003913")]
			[Cpp2IlInjected.Address(RVA = "0x581FC0", Offset = "0x5809C0", VA = "0x180581FC0", Slot = "22")]
			public virtual Task<PickUpContainerItem.Types.Response> PickUpContainerItemAsync(PickUpContainerItem.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: PickUpContainerItemAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003914")]
			[Cpp2IlInjected.Address(RVA = "0x583EB0", Offset = "0x5828B0", VA = "0x180583EB0")]
			[AsyncStateMachine(typeof(_003CPutDownContainerItemInvokerAsync_003Ed__46))]
			public Task<CallResult<IMessage>> PutDownContainerItemInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003915")]
			[Cpp2IlInjected.Address(RVA = "0x583D00", Offset = "0x582700", VA = "0x180583D00")]
			[AsyncStateMachine(typeof(_003CPutDownContainerItemAsyncStub_003Ed__47))]
			public Task<IMessage> PutDownContainerItemAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003916")]
			[Cpp2IlInjected.Address(RVA = "0x583E60", Offset = "0x582860", VA = "0x180583E60", Slot = "23")]
			public virtual Task<PutDownContainerItem.Types.Response> PutDownContainerItemAsync(PutDownContainerItem.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: PutDownContainerItemAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003917")]
			[Cpp2IlInjected.Address(RVA = "0x57CD60", Offset = "0x57B760", VA = "0x18057CD60")]
			[AsyncStateMachine(typeof(_003CDropContainerInventoryStackInvokerAsync_003Ed__49))]
			public Task<CallResult<IMessage>> DropContainerInventoryStackInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003918")]
			[Cpp2IlInjected.Address(RVA = "0x57CBB0", Offset = "0x57B5B0", VA = "0x18057CBB0")]
			[AsyncStateMachine(typeof(_003CDropContainerInventoryStackAsyncStub_003Ed__50))]
			public Task<IMessage> DropContainerInventoryStackAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003919")]
			[Cpp2IlInjected.Address(RVA = "0x57CD10", Offset = "0x57B710", VA = "0x18057CD10", Slot = "24")]
			public virtual Task<DropContainerInventoryStack.Types.Response> DropContainerInventoryStackAsync(DropContainerInventoryStack.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DropContainerInventoryStackAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600391A")]
			[Cpp2IlInjected.Address(RVA = "0x582630", Offset = "0x581030", VA = "0x180582630")]
			[AsyncStateMachine(typeof(_003CPickUpListItemInvokerAsync_003Ed__52))]
			public Task<CallResult<IMessage>> PickUpListItemInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600391B")]
			[Cpp2IlInjected.Address(RVA = "0x582480", Offset = "0x580E80", VA = "0x180582480")]
			[AsyncStateMachine(typeof(_003CPickUpListItemAsyncStub_003Ed__53))]
			public Task<IMessage> PickUpListItemAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600391C")]
			[Cpp2IlInjected.Address(RVA = "0x5825E0", Offset = "0x580FE0", VA = "0x1805825E0", Slot = "25")]
			public virtual Task<PickUpListItem.Types.Response> PickUpListItemAsync(PickUpListItem.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: PickUpListItemAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600391D")]
			[Cpp2IlInjected.Address(RVA = "0x5841C0", Offset = "0x582BC0", VA = "0x1805841C0")]
			[AsyncStateMachine(typeof(_003CPutDownListItemInvokerAsync_003Ed__55))]
			public Task<CallResult<IMessage>> PutDownListItemInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600391E")]
			[Cpp2IlInjected.Address(RVA = "0x584010", Offset = "0x582A10", VA = "0x180584010")]
			[AsyncStateMachine(typeof(_003CPutDownListItemAsyncStub_003Ed__56))]
			public Task<IMessage> PutDownListItemAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600391F")]
			[Cpp2IlInjected.Address(RVA = "0x584170", Offset = "0x582B70", VA = "0x180584170", Slot = "26")]
			public virtual Task<PutDownListItem.Types.Response> PutDownListItemAsync(PutDownListItem.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: PutDownListItemAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003920")]
			[Cpp2IlInjected.Address(RVA = "0x582320", Offset = "0x580D20", VA = "0x180582320")]
			[AsyncStateMachine(typeof(_003CPickUpItemInvokerAsync_003Ed__58))]
			public Task<CallResult<IMessage>> PickUpItemInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003921")]
			[Cpp2IlInjected.Address(RVA = "0x582170", Offset = "0x580B70", VA = "0x180582170")]
			[AsyncStateMachine(typeof(_003CPickUpItemAsyncStub_003Ed__59))]
			public Task<IMessage> PickUpItemAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003922")]
			[Cpp2IlInjected.Address(RVA = "0x5822D0", Offset = "0x580CD0", VA = "0x1805822D0", Slot = "27")]
			public virtual Task<PickUpItem.Types.Response> PickUpItemAsync(PickUpItem.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: PickUpItemAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003923")]
			[Cpp2IlInjected.Address(RVA = "0x583270", Offset = "0x581C70", VA = "0x180583270")]
			[AsyncStateMachine(typeof(_003CPlaceLandscapingItemInvokerAsync_003Ed__61))]
			public Task<CallResult<IMessage>> PlaceLandscapingItemInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003924")]
			[Cpp2IlInjected.Address(RVA = "0x5830C0", Offset = "0x581AC0", VA = "0x1805830C0")]
			[AsyncStateMachine(typeof(_003CPlaceLandscapingItemAsyncStub_003Ed__62))]
			public Task<IMessage> PlaceLandscapingItemAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003925")]
			[Cpp2IlInjected.Address(RVA = "0x583220", Offset = "0x581C20", VA = "0x180583220", Slot = "28")]
			public virtual Task<PlaceLandscapingItem.Types.Response> PlaceLandscapingItemAsync(PlaceLandscapingItem.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: PlaceLandscapingItemAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003926")]
			[Cpp2IlInjected.Address(RVA = "0x58E410", Offset = "0x58CE10", VA = "0x18058E410")]
			[AsyncStateMachine(typeof(_003CUpdateGridObjectTransformInvokerAsync_003Ed__64))]
			public Task<CallResult<IMessage>> UpdateGridObjectTransformInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003927")]
			[Cpp2IlInjected.Address(RVA = "0x58E260", Offset = "0x58CC60", VA = "0x18058E260")]
			[AsyncStateMachine(typeof(_003CUpdateGridObjectTransformAsyncStub_003Ed__65))]
			public Task<IMessage> UpdateGridObjectTransformAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003928")]
			[Cpp2IlInjected.Address(RVA = "0x58E3C0", Offset = "0x58CDC0", VA = "0x18058E3C0", Slot = "29")]
			public virtual Task<UpdateGridObjectTransform.Types.Response> UpdateGridObjectTransformAsync(UpdateGridObjectTransform.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: UpdateGridObjectTransformAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003929")]
			[Cpp2IlInjected.Address(RVA = "0x58BF50", Offset = "0x58A950", VA = "0x18058BF50")]
			[AsyncStateMachine(typeof(_003CSwitchGridObjectGridInvokerAsync_003Ed__67))]
			public Task<CallResult<IMessage>> SwitchGridObjectGridInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600392A")]
			[Cpp2IlInjected.Address(RVA = "0x58BDA0", Offset = "0x58A7A0", VA = "0x18058BDA0")]
			[AsyncStateMachine(typeof(_003CSwitchGridObjectGridAsyncStub_003Ed__68))]
			public Task<IMessage> SwitchGridObjectGridAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600392B")]
			[Cpp2IlInjected.Address(RVA = "0x58BF00", Offset = "0x58A900", VA = "0x18058BF00", Slot = "30")]
			public virtual Task<SwitchGridObjectGrid.Types.Response> SwitchGridObjectGridAsync(SwitchGridObjectGrid.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SwitchGridObjectGridAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600392C")]
			[Cpp2IlInjected.Address(RVA = "0x585420", Offset = "0x583E20", VA = "0x180585420")]
			[AsyncStateMachine(typeof(_003CReplaceGridObjectInvokerAsync_003Ed__70))]
			public Task<CallResult<IMessage>> ReplaceGridObjectInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600392D")]
			[Cpp2IlInjected.Address(RVA = "0x585270", Offset = "0x583C70", VA = "0x180585270")]
			[AsyncStateMachine(typeof(_003CReplaceGridObjectAsyncStub_003Ed__71))]
			public Task<IMessage> ReplaceGridObjectAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600392E")]
			[Cpp2IlInjected.Address(RVA = "0x5853D0", Offset = "0x583DD0", VA = "0x1805853D0", Slot = "31")]
			public virtual Task<ReplaceGridObject.Types.Response> ReplaceGridObjectAsync(ReplaceGridObject.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ReplaceGridObjectAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600392F")]
			[Cpp2IlInjected.Address(RVA = "0x5819F0", Offset = "0x5803F0", VA = "0x1805819F0")]
			[AsyncStateMachine(typeof(_003CMoveInContainerInventoryInvokerAsync_003Ed__73))]
			public Task<CallResult<IMessage>> MoveInContainerInventoryInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003930")]
			[Cpp2IlInjected.Address(RVA = "0x581840", Offset = "0x580240", VA = "0x180581840")]
			[AsyncStateMachine(typeof(_003CMoveInContainerInventoryAsyncStub_003Ed__74))]
			public Task<IMessage> MoveInContainerInventoryAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003931")]
			[Cpp2IlInjected.Address(RVA = "0x5819A0", Offset = "0x5803A0", VA = "0x1805819A0", Slot = "32")]
			public virtual Task<MoveInContainerInventory.Types.Response> MoveInContainerInventoryAsync(MoveInContainerInventory.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: MoveInContainerInventoryAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003932")]
			[Cpp2IlInjected.Address(RVA = "0x589780", Offset = "0x588180", VA = "0x180589780")]
			[AsyncStateMachine(typeof(_003CSortContainerInventoryInvokerAsync_003Ed__76))]
			public Task<CallResult<IMessage>> SortContainerInventoryInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003933")]
			[Cpp2IlInjected.Address(RVA = "0x5895D0", Offset = "0x587FD0", VA = "0x1805895D0")]
			[AsyncStateMachine(typeof(_003CSortContainerInventoryAsyncStub_003Ed__77))]
			public Task<IMessage> SortContainerInventoryAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003934")]
			[Cpp2IlInjected.Address(RVA = "0x589730", Offset = "0x588130", VA = "0x180589730", Slot = "33")]
			public virtual Task<SortContainerInventory.Types.Response> SortContainerInventoryAsync(SortContainerInventory.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SortContainerInventoryAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003935")]
			[Cpp2IlInjected.Address(RVA = "0x589470", Offset = "0x587E70", VA = "0x180589470")]
			[AsyncStateMachine(typeof(_003CSmartInventoryTransferInvokerAsync_003Ed__79))]
			public Task<CallResult<IMessage>> SmartInventoryTransferInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003936")]
			[Cpp2IlInjected.Address(RVA = "0x5892C0", Offset = "0x587CC0", VA = "0x1805892C0")]
			[AsyncStateMachine(typeof(_003CSmartInventoryTransferAsyncStub_003Ed__80))]
			public Task<IMessage> SmartInventoryTransferAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003937")]
			[Cpp2IlInjected.Address(RVA = "0x589420", Offset = "0x587E20", VA = "0x180589420", Slot = "34")]
			public virtual Task<SmartInventoryTransfer.Types.Response> SmartInventoryTransferAsync(SmartInventoryTransfer.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SmartInventoryTransferAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003938")]
			[Cpp2IlInjected.Address(RVA = "0x570C70", Offset = "0x56F670", VA = "0x180570C70")]
			[AsyncStateMachine(typeof(_003CAddItemToKeyholeInvokerAsync_003Ed__82))]
			public Task<CallResult<IMessage>> AddItemToKeyholeInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003939")]
			[Cpp2IlInjected.Address(RVA = "0x570AC0", Offset = "0x56F4C0", VA = "0x180570AC0")]
			[AsyncStateMachine(typeof(_003CAddItemToKeyholeAsyncStub_003Ed__83))]
			public Task<IMessage> AddItemToKeyholeAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600393A")]
			[Cpp2IlInjected.Address(RVA = "0x570C20", Offset = "0x56F620", VA = "0x180570C20", Slot = "35")]
			public virtual Task<AddItemToKeyhole.Types.Response> AddItemToKeyholeAsync(AddItemToKeyhole.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: AddItemToKeyholeAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600393B")]
			[Cpp2IlInjected.Address(RVA = "0x585110", Offset = "0x583B10", VA = "0x180585110")]
			[AsyncStateMachine(typeof(_003CRemoveItemFromKeyholeInvokerAsync_003Ed__85))]
			public Task<CallResult<IMessage>> RemoveItemFromKeyholeInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600393C")]
			[Cpp2IlInjected.Address(RVA = "0x584F60", Offset = "0x583960", VA = "0x180584F60")]
			[AsyncStateMachine(typeof(_003CRemoveItemFromKeyholeAsyncStub_003Ed__86))]
			public Task<IMessage> RemoveItemFromKeyholeAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600393D")]
			[Cpp2IlInjected.Address(RVA = "0x5850C0", Offset = "0x583AC0", VA = "0x1805850C0", Slot = "36")]
			public virtual Task<RemoveItemFromKeyhole.Types.Response> RemoveItemFromKeyholeAsync(RemoveItemFromKeyhole.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: RemoveItemFromKeyholeAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600393E")]
			[Cpp2IlInjected.Address(RVA = "0x58BC40", Offset = "0x58A640", VA = "0x18058BC40")]
			[AsyncStateMachine(typeof(_003CSwapItemInKeyholeInvokerAsync_003Ed__88))]
			public Task<CallResult<IMessage>> SwapItemInKeyholeInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600393F")]
			[Cpp2IlInjected.Address(RVA = "0x58BA90", Offset = "0x58A490", VA = "0x18058BA90")]
			[AsyncStateMachine(typeof(_003CSwapItemInKeyholeAsyncStub_003Ed__89))]
			public Task<IMessage> SwapItemInKeyholeAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003940")]
			[Cpp2IlInjected.Address(RVA = "0x58BBF0", Offset = "0x58A5F0", VA = "0x18058BBF0", Slot = "37")]
			public virtual Task<SwapItemInKeyhole.Types.Response> SwapItemInKeyholeAsync(SwapItemInKeyhole.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SwapItemInKeyholeAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003941")]
			[Cpp2IlInjected.Address(RVA = "0x587BF0", Offset = "0x5865F0", VA = "0x180587BF0")]
			[AsyncStateMachine(typeof(_003CSetFurnitureToggleStateInvokerAsync_003Ed__91))]
			public Task<CallResult<IMessage>> SetFurnitureToggleStateInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003942")]
			[Cpp2IlInjected.Address(RVA = "0x587A40", Offset = "0x586440", VA = "0x180587A40")]
			[AsyncStateMachine(typeof(_003CSetFurnitureToggleStateAsyncStub_003Ed__92))]
			public Task<IMessage> SetFurnitureToggleStateAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003943")]
			[Cpp2IlInjected.Address(RVA = "0x587BA0", Offset = "0x5865A0", VA = "0x180587BA0", Slot = "38")]
			public virtual Task<SetFurnitureToggleState.Types.Response> SetFurnitureToggleStateAsync(SetFurnitureToggleState.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SetFurnitureToggleStateAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003944")]
			[Cpp2IlInjected.Address(RVA = "0x5878E0", Offset = "0x5862E0", VA = "0x1805878E0")]
			[AsyncStateMachine(typeof(_003CSetFurnitureIndexStateInvokerAsync_003Ed__94))]
			public Task<CallResult<IMessage>> SetFurnitureIndexStateInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003945")]
			[Cpp2IlInjected.Address(RVA = "0x587730", Offset = "0x586130", VA = "0x180587730")]
			[AsyncStateMachine(typeof(_003CSetFurnitureIndexStateAsyncStub_003Ed__95))]
			public Task<IMessage> SetFurnitureIndexStateAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003946")]
			[Cpp2IlInjected.Address(RVA = "0x587890", Offset = "0x586290", VA = "0x180587890", Slot = "39")]
			public virtual Task<SetFurnitureIndexState.Types.Response> SetFurnitureIndexStateAsync(SetFurnitureIndexState.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SetFurnitureIndexStateAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003947")]
			[Cpp2IlInjected.Address(RVA = "0x5752E0", Offset = "0x573CE0", VA = "0x1805752E0")]
			[AsyncStateMachine(typeof(_003CCollectLootPresentInvokerAsync_003Ed__97))]
			public Task<CallResult<IMessage>> CollectLootPresentInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003948")]
			[Cpp2IlInjected.Address(RVA = "0x575130", Offset = "0x573B30", VA = "0x180575130")]
			[AsyncStateMachine(typeof(_003CCollectLootPresentAsyncStub_003Ed__98))]
			public Task<IMessage> CollectLootPresentAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003949")]
			[Cpp2IlInjected.Address(RVA = "0x575290", Offset = "0x573C90", VA = "0x180575290", Slot = "40")]
			public virtual Task<CollectLootPresent.Types.Response> CollectLootPresentAsync(CollectLootPresent.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: CollectLootPresentAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600394A")]
			[Cpp2IlInjected.Address(RVA = "0x5749B0", Offset = "0x5733B0", VA = "0x1805749B0")]
			[AsyncStateMachine(typeof(_003CCollectConsummableInvokerAsync_003Ed__100))]
			public Task<CallResult<IMessage>> CollectConsummableInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600394B")]
			[Cpp2IlInjected.Address(RVA = "0x574800", Offset = "0x573200", VA = "0x180574800")]
			[AsyncStateMachine(typeof(_003CCollectConsummableAsyncStub_003Ed__101))]
			public Task<IMessage> CollectConsummableAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600394C")]
			[Cpp2IlInjected.Address(RVA = "0x574960", Offset = "0x573360", VA = "0x180574960", Slot = "41")]
			public virtual Task<CollectConsummable.Types.Response> CollectConsummableAsync(CollectConsummable.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: CollectConsummableAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600394D")]
			[Cpp2IlInjected.Address(RVA = "0x575C10", Offset = "0x574610", VA = "0x180575C10")]
			[AsyncStateMachine(typeof(_003CConsumeItemInvokerAsync_003Ed__103))]
			public Task<CallResult<IMessage>> ConsumeItemInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600394E")]
			[Cpp2IlInjected.Address(RVA = "0x575A60", Offset = "0x574460", VA = "0x180575A60")]
			[AsyncStateMachine(typeof(_003CConsumeItemAsyncStub_003Ed__104))]
			public Task<IMessage> ConsumeItemAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600394F")]
			[Cpp2IlInjected.Address(RVA = "0x575BC0", Offset = "0x5745C0", VA = "0x180575BC0", Slot = "42")]
			public virtual Task<ConsumeItem.Types.Response> ConsumeItemAsync(ConsumeItem.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ConsumeItemAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003950")]
			[Cpp2IlInjected.Address(RVA = "0x58C260", Offset = "0x58AC60", VA = "0x18058C260")]
			[AsyncStateMachine(typeof(_003CSwitchPictureFrameInvokerAsync_003Ed__106))]
			public Task<CallResult<IMessage>> SwitchPictureFrameInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003951")]
			[Cpp2IlInjected.Address(RVA = "0x58C0B0", Offset = "0x58AAB0", VA = "0x18058C0B0")]
			[AsyncStateMachine(typeof(_003CSwitchPictureFrameAsyncStub_003Ed__107))]
			public Task<IMessage> SwitchPictureFrameAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003952")]
			[Cpp2IlInjected.Address(RVA = "0x58C210", Offset = "0x58AC10", VA = "0x18058C210", Slot = "43")]
			public virtual Task<SwitchPictureFrame.Types.Response> SwitchPictureFrameAsync(SwitchPictureFrame.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SwitchPictureFrameAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003953")]
			[Cpp2IlInjected.Address(RVA = "0x5721E0", Offset = "0x570BE0", VA = "0x1805721E0")]
			[AsyncStateMachine(typeof(_003CBuyItemInvokerAsync_003Ed__109))]
			public Task<CallResult<IMessage>> BuyItemInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003954")]
			[Cpp2IlInjected.Address(RVA = "0x572030", Offset = "0x570A30", VA = "0x180572030")]
			[AsyncStateMachine(typeof(_003CBuyItemAsyncStub_003Ed__110))]
			public Task<IMessage> BuyItemAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003955")]
			[Cpp2IlInjected.Address(RVA = "0x572190", Offset = "0x570B90", VA = "0x180572190", Slot = "44")]
			public virtual Task<BuyItem.Types.Response> BuyItemAsync(BuyItem.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: BuyItemAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003956")]
			[Cpp2IlInjected.Address(RVA = "0x5718B0", Offset = "0x5702B0", VA = "0x1805718B0")]
			[AsyncStateMachine(typeof(_003CAvatarTransferInvokerAsync_003Ed__112))]
			public Task<CallResult<IMessage>> AvatarTransferInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003957")]
			[Cpp2IlInjected.Address(RVA = "0x571700", Offset = "0x570100", VA = "0x180571700")]
			[AsyncStateMachine(typeof(_003CAvatarTransferAsyncStub_003Ed__113))]
			public Task<IMessage> AvatarTransferAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003958")]
			[Cpp2IlInjected.Address(RVA = "0x571860", Offset = "0x570260", VA = "0x180571860", Slot = "45")]
			public virtual Task<AvatarTransfer.Types.Response> AvatarTransferAsync(AvatarTransfer.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: AvatarTransferAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003959")]
			[Cpp2IlInjected.Address(RVA = "0x586CA0", Offset = "0x5856A0", VA = "0x180586CA0")]
			[AsyncStateMachine(typeof(_003CSetAvatarCustomizationInvokerAsync_003Ed__115))]
			public Task<CallResult<IMessage>> SetAvatarCustomizationInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600395A")]
			[Cpp2IlInjected.Address(RVA = "0x586AF0", Offset = "0x5854F0", VA = "0x180586AF0")]
			[AsyncStateMachine(typeof(_003CSetAvatarCustomizationAsyncStub_003Ed__116))]
			public Task<IMessage> SetAvatarCustomizationAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600395B")]
			[Cpp2IlInjected.Address(RVA = "0x586C50", Offset = "0x585650", VA = "0x180586C50", Slot = "46")]
			public virtual Task<AvatarCustomization.Types.Response> SetAvatarCustomizationAsync(AvatarCustomization.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SetAvatarCustomizationAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600395C")]
			[Cpp2IlInjected.Address(RVA = "0x585A40", Offset = "0x584440", VA = "0x180585A40")]
			[AsyncStateMachine(typeof(_003CSaveClothingDesignInvokerAsync_003Ed__118))]
			public Task<CallResult<IMessage>> SaveClothingDesignInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600395D")]
			[Cpp2IlInjected.Address(RVA = "0x585890", Offset = "0x584290", VA = "0x180585890")]
			[AsyncStateMachine(typeof(_003CSaveClothingDesignAsyncStub_003Ed__119))]
			public Task<IMessage> SaveClothingDesignAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600395E")]
			[Cpp2IlInjected.Address(RVA = "0x5859F0", Offset = "0x5843F0", VA = "0x1805859F0", Slot = "47")]
			public virtual Task<SaveClothingDesign.Types.Response> SaveClothingDesignAsync(SaveClothingDesign.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SaveClothingDesignAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600395F")]
			[Cpp2IlInjected.Address(RVA = "0x57C430", Offset = "0x57AE30", VA = "0x18057C430")]
			[AsyncStateMachine(typeof(_003CDeleteClothingDesignInvokerAsync_003Ed__121))]
			public Task<CallResult<IMessage>> DeleteClothingDesignInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003960")]
			[Cpp2IlInjected.Address(RVA = "0x57C280", Offset = "0x57AC80", VA = "0x18057C280")]
			[AsyncStateMachine(typeof(_003CDeleteClothingDesignAsyncStub_003Ed__122))]
			public Task<IMessage> DeleteClothingDesignAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003961")]
			[Cpp2IlInjected.Address(RVA = "0x57C3E0", Offset = "0x57ADE0", VA = "0x18057C3E0", Slot = "48")]
			public virtual Task<DeleteClothingDesign.Types.Response> DeleteClothingDesignAsync(DeleteClothingDesign.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DeleteClothingDesignAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003962")]
			[Cpp2IlInjected.Address(RVA = "0x5875D0", Offset = "0x585FD0", VA = "0x1805875D0")]
			[AsyncStateMachine(typeof(_003CSetFurnitureCustomizationInvokerAsync_003Ed__124))]
			public Task<CallResult<IMessage>> SetFurnitureCustomizationInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003963")]
			[Cpp2IlInjected.Address(RVA = "0x587420", Offset = "0x585E20", VA = "0x180587420")]
			[AsyncStateMachine(typeof(_003CSetFurnitureCustomizationAsyncStub_003Ed__125))]
			public Task<IMessage> SetFurnitureCustomizationAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003964")]
			[Cpp2IlInjected.Address(RVA = "0x587580", Offset = "0x585F80", VA = "0x180587580", Slot = "49")]
			public virtual Task<FurnitureCustomization.Types.Response> SetFurnitureCustomizationAsync(FurnitureCustomization.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SetFurnitureCustomizationAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003965")]
			[Cpp2IlInjected.Address(RVA = "0x585D50", Offset = "0x584750", VA = "0x180585D50")]
			[AsyncStateMachine(typeof(_003CSaveFurnitureDesignInvokerAsync_003Ed__127))]
			public Task<CallResult<IMessage>> SaveFurnitureDesignInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003966")]
			[Cpp2IlInjected.Address(RVA = "0x585BA0", Offset = "0x5845A0", VA = "0x180585BA0")]
			[AsyncStateMachine(typeof(_003CSaveFurnitureDesignAsyncStub_003Ed__128))]
			public Task<IMessage> SaveFurnitureDesignAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003967")]
			[Cpp2IlInjected.Address(RVA = "0x585D00", Offset = "0x584700", VA = "0x180585D00", Slot = "50")]
			public virtual Task<SaveFurnitureDesign.Types.Response> SaveFurnitureDesignAsync(SaveFurnitureDesign.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SaveFurnitureDesignAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003968")]
			[Cpp2IlInjected.Address(RVA = "0x57C740", Offset = "0x57B140", VA = "0x18057C740")]
			[AsyncStateMachine(typeof(_003CDeleteFurnitureDesignInvokerAsync_003Ed__130))]
			public Task<CallResult<IMessage>> DeleteFurnitureDesignInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003969")]
			[Cpp2IlInjected.Address(RVA = "0x57C590", Offset = "0x57AF90", VA = "0x18057C590")]
			[AsyncStateMachine(typeof(_003CDeleteFurnitureDesignAsyncStub_003Ed__131))]
			public Task<IMessage> DeleteFurnitureDesignAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600396A")]
			[Cpp2IlInjected.Address(RVA = "0x57C6F0", Offset = "0x57B0F0", VA = "0x18057C6F0", Slot = "51")]
			public virtual Task<DeleteFurnitureDesign.Types.Response> DeleteFurnitureDesignAsync(DeleteFurnitureDesign.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DeleteFurnitureDesignAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600396B")]
			[Cpp2IlInjected.Address(RVA = "0x57D380", Offset = "0x57BD80", VA = "0x18057D380")]
			[AsyncStateMachine(typeof(_003CEnableCharacterInvokerAsync_003Ed__133))]
			public Task<CallResult<IMessage>> EnableCharacterInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600396C")]
			[Cpp2IlInjected.Address(RVA = "0x57D1D0", Offset = "0x57BBD0", VA = "0x18057D1D0")]
			[AsyncStateMachine(typeof(_003CEnableCharacterAsyncStub_003Ed__134))]
			public Task<IMessage> EnableCharacterAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600396D")]
			[Cpp2IlInjected.Address(RVA = "0x57D330", Offset = "0x57BD30", VA = "0x18057D330", Slot = "52")]
			public virtual Task<EnableCharacter.Types.Response> EnableCharacterAsync(EnableCharacter.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: EnableCharacterAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600396E")]
			[Cpp2IlInjected.Address(RVA = "0x57CA50", Offset = "0x57B450", VA = "0x18057CA50")]
			[AsyncStateMachine(typeof(_003CDiscussWithCharacterInvokerAsync_003Ed__136))]
			public Task<CallResult<IMessage>> DiscussWithCharacterInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600396F")]
			[Cpp2IlInjected.Address(RVA = "0x57C8A0", Offset = "0x57B2A0", VA = "0x18057C8A0")]
			[AsyncStateMachine(typeof(_003CDiscussWithCharacterAsyncStub_003Ed__137))]
			public Task<IMessage> DiscussWithCharacterAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003970")]
			[Cpp2IlInjected.Address(RVA = "0x57CA00", Offset = "0x57B400", VA = "0x18057CA00", Slot = "53")]
			public virtual Task<DiscussWithCharacter.Types.Response> DiscussWithCharacterAsync(DiscussWithCharacter.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DiscussWithCharacterAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003971")]
			[Cpp2IlInjected.Address(RVA = "0x585730", Offset = "0x584130", VA = "0x180585730")]
			[AsyncStateMachine(typeof(_003CResetCharacterDiscussionsInvokerAsync_003Ed__139))]
			public Task<CallResult<IMessage>> ResetCharacterDiscussionsInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003972")]
			[Cpp2IlInjected.Address(RVA = "0x585580", Offset = "0x583F80", VA = "0x180585580")]
			[AsyncStateMachine(typeof(_003CResetCharacterDiscussionsAsyncStub_003Ed__140))]
			public Task<IMessage> ResetCharacterDiscussionsAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003973")]
			[Cpp2IlInjected.Address(RVA = "0x5856E0", Offset = "0x5840E0", VA = "0x1805856E0", Slot = "54")]
			public virtual Task<ResetCharacterDiscussions.Types.Response> ResetCharacterDiscussionsAsync(ResetCharacterDiscussions.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ResetCharacterDiscussionsAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003974")]
			[Cpp2IlInjected.Address(RVA = "0x57FB50", Offset = "0x57E550", VA = "0x18057FB50")]
			[AsyncStateMachine(typeof(_003CGiveItemsToCharacterInvokerAsync_003Ed__142))]
			public Task<CallResult<IMessage>> GiveItemsToCharacterInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003975")]
			[Cpp2IlInjected.Address(RVA = "0x57F9A0", Offset = "0x57E3A0", VA = "0x18057F9A0")]
			[AsyncStateMachine(typeof(_003CGiveItemsToCharacterAsyncStub_003Ed__143))]
			public Task<IMessage> GiveItemsToCharacterAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003976")]
			[Cpp2IlInjected.Address(RVA = "0x57FB00", Offset = "0x57E500", VA = "0x18057FB00", Slot = "55")]
			public virtual Task<GiveItemsToCharacter.Types.Response> GiveItemsToCharacterAsync(GiveItemsToCharacter.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: GiveItemsToCharacterAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003977")]
			[Cpp2IlInjected.Address(RVA = "0x586FB0", Offset = "0x5859B0", VA = "0x180586FB0")]
			[AsyncStateMachine(typeof(_003CSetCharacterPreferredItemsAsSeenInvokerAsync_003Ed__145))]
			public Task<CallResult<IMessage>> SetCharacterPreferredItemsAsSeenInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003978")]
			[Cpp2IlInjected.Address(RVA = "0x586E00", Offset = "0x585800", VA = "0x180586E00")]
			[AsyncStateMachine(typeof(_003CSetCharacterPreferredItemsAsSeenAsyncStub_003Ed__146))]
			public Task<IMessage> SetCharacterPreferredItemsAsSeenAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003979")]
			[Cpp2IlInjected.Address(RVA = "0x586F60", Offset = "0x585960", VA = "0x180586F60", Slot = "56")]
			public virtual Task<SetCharacterPreferredItemsAsSeen.Types.Response> SetCharacterPreferredItemsAsSeenAsync(SetCharacterPreferredItemsAsSeen.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SetCharacterPreferredItemsAsSeenAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600397A")]
			[Cpp2IlInjected.Address(RVA = "0x58DDF0", Offset = "0x58C7F0", VA = "0x18058DDF0")]
			[AsyncStateMachine(typeof(_003CUpdateCharacterSchedulesInvokerAsync_003Ed__148))]
			public Task<CallResult<IMessage>> UpdateCharacterSchedulesInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600397B")]
			[Cpp2IlInjected.Address(RVA = "0x58DC40", Offset = "0x58C640", VA = "0x18058DC40")]
			[AsyncStateMachine(typeof(_003CUpdateCharacterSchedulesAsyncStub_003Ed__149))]
			public Task<IMessage> UpdateCharacterSchedulesAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600397C")]
			[Cpp2IlInjected.Address(RVA = "0x58DDA0", Offset = "0x58C7A0", VA = "0x18058DDA0", Slot = "57")]
			public virtual Task<UpdateCharacterSchedules.Types.Response> UpdateCharacterSchedulesAsync(UpdateCharacterSchedules.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: UpdateCharacterSchedulesAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600397D")]
			[Cpp2IlInjected.Address(RVA = "0x586370", Offset = "0x584D70", VA = "0x180586370")]
			[AsyncStateMachine(typeof(_003CSecretCharacterDiscoveredInvokerAsync_003Ed__151))]
			public Task<CallResult<IMessage>> SecretCharacterDiscoveredInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600397E")]
			[Cpp2IlInjected.Address(RVA = "0x5861C0", Offset = "0x584BC0", VA = "0x1805861C0")]
			[AsyncStateMachine(typeof(_003CSecretCharacterDiscoveredAsyncStub_003Ed__152))]
			public Task<IMessage> SecretCharacterDiscoveredAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600397F")]
			[Cpp2IlInjected.Address(RVA = "0x586320", Offset = "0x584D20", VA = "0x180586320", Slot = "58")]
			public virtual Task<SecretCharacterDiscovered.Types.Response> SecretCharacterDiscoveredAsync(SecretCharacterDiscovered.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SecretCharacterDiscoveredAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003980")]
			[Cpp2IlInjected.Address(RVA = "0x571290", Offset = "0x56FC90", VA = "0x180571290")]
			[AsyncStateMachine(typeof(_003CApplyCharacterProfessionInvokerAsync_003Ed__154))]
			public Task<CallResult<IMessage>> ApplyCharacterProfessionInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003981")]
			[Cpp2IlInjected.Address(RVA = "0x5710E0", Offset = "0x56FAE0", VA = "0x1805710E0")]
			[AsyncStateMachine(typeof(_003CApplyCharacterProfessionAsyncStub_003Ed__155))]
			public Task<IMessage> ApplyCharacterProfessionAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003982")]
			[Cpp2IlInjected.Address(RVA = "0x571240", Offset = "0x56FC40", VA = "0x180571240", Slot = "59")]
			public virtual Task<ApplyCharacterProfession.Types.Response> ApplyCharacterProfessionAsync(ApplyCharacterProfession.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ApplyCharacterProfessionAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003983")]
			[Cpp2IlInjected.Address(RVA = "0x572B10", Offset = "0x571510", VA = "0x180572B10")]
			[AsyncStateMachine(typeof(_003CChangeCharacterProfessionInvokerAsync_003Ed__157))]
			public Task<CallResult<IMessage>> ChangeCharacterProfessionInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003984")]
			[Cpp2IlInjected.Address(RVA = "0x572960", Offset = "0x571360", VA = "0x180572960")]
			[AsyncStateMachine(typeof(_003CChangeCharacterProfessionAsyncStub_003Ed__158))]
			public Task<IMessage> ChangeCharacterProfessionAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003985")]
			[Cpp2IlInjected.Address(RVA = "0x572AC0", Offset = "0x5714C0", VA = "0x180572AC0", Slot = "60")]
			public virtual Task<ChangeCharacterProfession.Types.Response> ChangeCharacterProfessionAsync(ChangeCharacterProfession.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ChangeCharacterProfessionAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003986")]
			[Cpp2IlInjected.Address(RVA = "0x5715A0", Offset = "0x56FFA0", VA = "0x1805715A0")]
			[AsyncStateMachine(typeof(_003CApplyCharacterSkinInvokerAsync_003Ed__160))]
			public Task<CallResult<IMessage>> ApplyCharacterSkinInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003987")]
			[Cpp2IlInjected.Address(RVA = "0x5713F0", Offset = "0x56FDF0", VA = "0x1805713F0")]
			[AsyncStateMachine(typeof(_003CApplyCharacterSkinAsyncStub_003Ed__161))]
			public Task<IMessage> ApplyCharacterSkinAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003988")]
			[Cpp2IlInjected.Address(RVA = "0x571550", Offset = "0x56FF50", VA = "0x180571550", Slot = "61")]
			public virtual Task<ApplyCharacterSkin.Types.Response> ApplyCharacterSkinAsync(ApplyCharacterSkin.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ApplyCharacterSkinAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003989")]
			[Cpp2IlInjected.Address(RVA = "0x58D7D0", Offset = "0x58C1D0", VA = "0x18058D7D0")]
			[AsyncStateMachine(typeof(_003CUnlockVillageAreaInvokerAsync_003Ed__163))]
			public Task<CallResult<IMessage>> UnlockVillageAreaInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600398A")]
			[Cpp2IlInjected.Address(RVA = "0x58D620", Offset = "0x58C020", VA = "0x18058D620")]
			[AsyncStateMachine(typeof(_003CUnlockVillageAreaAsyncStub_003Ed__164))]
			public Task<IMessage> UnlockVillageAreaAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600398B")]
			[Cpp2IlInjected.Address(RVA = "0x58D780", Offset = "0x58C180", VA = "0x18058D780", Slot = "62")]
			public virtual Task<UnlockVillageArea.Types.Response> UnlockVillageAreaAsync(UnlockVillageArea.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: UnlockVillageAreaAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600398C")]
			[Cpp2IlInjected.Address(RVA = "0x57E2D0", Offset = "0x57CCD0", VA = "0x18057E2D0")]
			[AsyncStateMachine(typeof(_003CExecuteDailyResetInvokerAsync_003Ed__166))]
			public Task<CallResult<IMessage>> ExecuteDailyResetInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600398D")]
			[Cpp2IlInjected.Address(RVA = "0x57E120", Offset = "0x57CB20", VA = "0x18057E120")]
			[AsyncStateMachine(typeof(_003CExecuteDailyResetAsyncStub_003Ed__167))]
			public Task<IMessage> ExecuteDailyResetAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600398E")]
			[Cpp2IlInjected.Address(RVA = "0x57E280", Offset = "0x57CC80", VA = "0x18057E280", Slot = "63")]
			public virtual Task<ExecuteDailyReset.Types.Response> ExecuteDailyResetAsync(ExecuteDailyReset.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ExecuteDailyResetAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600398F")]
			[Cpp2IlInjected.Address(RVA = "0x5810C0", Offset = "0x57FAC0", VA = "0x1805810C0")]
			[AsyncStateMachine(typeof(_003CMeditateInvokerAsync_003Ed__169))]
			public Task<CallResult<IMessage>> MeditateInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003990")]
			[Cpp2IlInjected.Address(RVA = "0x580F10", Offset = "0x57F910", VA = "0x180580F10")]
			[AsyncStateMachine(typeof(_003CMeditateAsyncStub_003Ed__170))]
			public Task<IMessage> MeditateAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003991")]
			[Cpp2IlInjected.Address(RVA = "0x581070", Offset = "0x57FA70", VA = "0x180581070", Slot = "64")]
			public virtual Task<Meditate.Types.Response> MeditateAsync(Meditate.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: MeditateAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003992")]
			[Cpp2IlInjected.Address(RVA = "0x57BB00", Offset = "0x57A500", VA = "0x18057BB00")]
			[AsyncStateMachine(typeof(_003CDebugUnlockCharacterInvokerAsync_003Ed__172))]
			public Task<CallResult<IMessage>> DebugUnlockCharacterInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003993")]
			[Cpp2IlInjected.Address(RVA = "0x57B950", Offset = "0x57A350", VA = "0x18057B950")]
			[AsyncStateMachine(typeof(_003CDebugUnlockCharacterAsyncStub_003Ed__173))]
			public Task<IMessage> DebugUnlockCharacterAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003994")]
			[Cpp2IlInjected.Address(RVA = "0x57BAB0", Offset = "0x57A4B0", VA = "0x18057BAB0", Slot = "65")]
			public virtual Task<DebugUnlockCharacter.Types.Response> DebugUnlockCharacterAsync(DebugUnlockCharacter.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugUnlockCharacterAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003995")]
			[Cpp2IlInjected.Address(RVA = "0x57ABB0", Offset = "0x5795B0", VA = "0x18057ABB0")]
			[AsyncStateMachine(typeof(_003CDebugStartEventInvokerAsync_003Ed__175))]
			public Task<CallResult<IMessage>> DebugStartEventInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003996")]
			[Cpp2IlInjected.Address(RVA = "0x57AA00", Offset = "0x579400", VA = "0x18057AA00")]
			[AsyncStateMachine(typeof(_003CDebugStartEventAsyncStub_003Ed__176))]
			public Task<IMessage> DebugStartEventAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003997")]
			[Cpp2IlInjected.Address(RVA = "0x57AB60", Offset = "0x579560", VA = "0x18057AB60", Slot = "66")]
			public virtual Task<DebugStartEvent.Types.Response> DebugStartEventAsync(DebugStartEvent.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugStartEventAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003998")]
			[Cpp2IlInjected.Address(RVA = "0x5783E0", Offset = "0x576DE0", VA = "0x1805783E0")]
			[AsyncStateMachine(typeof(_003CDebugEndEventInvokerAsync_003Ed__178))]
			public Task<CallResult<IMessage>> DebugEndEventInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003999")]
			[Cpp2IlInjected.Address(RVA = "0x578230", Offset = "0x576C30", VA = "0x180578230")]
			[AsyncStateMachine(typeof(_003CDebugEndEventAsyncStub_003Ed__179))]
			public Task<IMessage> DebugEndEventAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600399A")]
			[Cpp2IlInjected.Address(RVA = "0x578390", Offset = "0x576D90", VA = "0x180578390", Slot = "67")]
			public virtual Task<DebugEndEvent.Types.Response> DebugEndEventAsync(DebugEndEvent.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugEndEventAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600399B")]
			[Cpp2IlInjected.Address(RVA = "0x57A8A0", Offset = "0x5792A0", VA = "0x18057A8A0")]
			[AsyncStateMachine(typeof(_003CDebugSkipTimeInvokerAsync_003Ed__181))]
			public Task<CallResult<IMessage>> DebugSkipTimeInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600399C")]
			[Cpp2IlInjected.Address(RVA = "0x57A6F0", Offset = "0x5790F0", VA = "0x18057A6F0")]
			[AsyncStateMachine(typeof(_003CDebugSkipTimeAsyncStub_003Ed__182))]
			public Task<IMessage> DebugSkipTimeAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600399D")]
			[Cpp2IlInjected.Address(RVA = "0x57A850", Offset = "0x579250", VA = "0x18057A850", Slot = "68")]
			public virtual Task<DebugSkipTime.Types.Response> DebugSkipTimeAsync(DebugSkipTime.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugSkipTimeAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600399E")]
			[Cpp2IlInjected.Address(RVA = "0x579640", Offset = "0x578040", VA = "0x180579640")]
			[AsyncStateMachine(typeof(_003CDebugGenericCheatInvokerAsync_003Ed__184))]
			public Task<CallResult<IMessage>> DebugGenericCheatInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600399F")]
			[Cpp2IlInjected.Address(RVA = "0x579490", Offset = "0x577E90", VA = "0x180579490")]
			[AsyncStateMachine(typeof(_003CDebugGenericCheatAsyncStub_003Ed__185))]
			public Task<IMessage> DebugGenericCheatAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039A0")]
			[Cpp2IlInjected.Address(RVA = "0x5795F0", Offset = "0x577FF0", VA = "0x1805795F0", Slot = "69")]
			public virtual Task<DebugGenericCheat.Types.Response> DebugGenericCheatAsync(DebugGenericCheat.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugGenericCheatAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039A1")]
			[Cpp2IlInjected.Address(RVA = "0x577490", Offset = "0x575E90", VA = "0x180577490")]
			[AsyncStateMachine(typeof(_003CDebugAddItemInvokerAsync_003Ed__187))]
			public Task<CallResult<IMessage>> DebugAddItemInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039A2")]
			[Cpp2IlInjected.Address(RVA = "0x5772E0", Offset = "0x575CE0", VA = "0x1805772E0")]
			[AsyncStateMachine(typeof(_003CDebugAddItemAsyncStub_003Ed__188))]
			public Task<IMessage> DebugAddItemAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039A3")]
			[Cpp2IlInjected.Address(RVA = "0x577440", Offset = "0x575E40", VA = "0x180577440", Slot = "70")]
			public virtual Task<DebugAddItem.Types.Response> DebugAddItemAsync(DebugAddItem.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugAddItemAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039A4")]
			[Cpp2IlInjected.Address(RVA = "0x579C60", Offset = "0x578660", VA = "0x180579C60")]
			[AsyncStateMachine(typeof(_003CDebugRemoveItemInvokerAsync_003Ed__190))]
			public Task<CallResult<IMessage>> DebugRemoveItemInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039A5")]
			[Cpp2IlInjected.Address(RVA = "0x579AB0", Offset = "0x5784B0", VA = "0x180579AB0")]
			[AsyncStateMachine(typeof(_003CDebugRemoveItemAsyncStub_003Ed__191))]
			public Task<IMessage> DebugRemoveItemAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039A6")]
			[Cpp2IlInjected.Address(RVA = "0x579C10", Offset = "0x578610", VA = "0x180579C10", Slot = "71")]
			public virtual Task<DebugRemoveItem.Types.Response> DebugRemoveItemAsync(DebugRemoveItem.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugRemoveItemAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039A7")]
			[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575B80", VA = "0x180577180")]
			[AsyncStateMachine(typeof(_003CDebugAddFriendshipInvokerAsync_003Ed__193))]
			public Task<CallResult<IMessage>> DebugAddFriendshipInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039A8")]
			[Cpp2IlInjected.Address(RVA = "0x576FD0", Offset = "0x5759D0", VA = "0x180576FD0")]
			[AsyncStateMachine(typeof(_003CDebugAddFriendshipAsyncStub_003Ed__194))]
			public Task<IMessage> DebugAddFriendshipAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039A9")]
			[Cpp2IlInjected.Address(RVA = "0x577130", Offset = "0x575B30", VA = "0x180577130", Slot = "72")]
			public virtual Task<DebugAddFriendship.Types.Response> DebugAddFriendshipAsync(DebugAddFriendship.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugAddFriendshipAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039AA")]
			[Cpp2IlInjected.Address(RVA = "0x5777A0", Offset = "0x5761A0", VA = "0x1805777A0")]
			[AsyncStateMachine(typeof(_003CDebugAddPlayerXPInvokerAsync_003Ed__196))]
			public Task<CallResult<IMessage>> DebugAddPlayerXPInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039AB")]
			[Cpp2IlInjected.Address(RVA = "0x5775F0", Offset = "0x575FF0", VA = "0x1805775F0")]
			[AsyncStateMachine(typeof(_003CDebugAddPlayerXPAsyncStub_003Ed__197))]
			public Task<IMessage> DebugAddPlayerXPAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039AC")]
			[Cpp2IlInjected.Address(RVA = "0x577750", Offset = "0x576150", VA = "0x180577750", Slot = "73")]
			public virtual Task<DebugAddPlayerXP.Types.Response> DebugAddPlayerXPAsync(DebugAddPlayerXP.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugAddPlayerXPAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039AD")]
			[Cpp2IlInjected.Address(RVA = "0x57A280", Offset = "0x578C80", VA = "0x18057A280")]
			[AsyncStateMachine(typeof(_003CDebugSetPlayerLevelInvokerAsync_003Ed__199))]
			public Task<CallResult<IMessage>> DebugSetPlayerLevelInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039AE")]
			[Cpp2IlInjected.Address(RVA = "0x57A0D0", Offset = "0x578AD0", VA = "0x18057A0D0")]
			[AsyncStateMachine(typeof(_003CDebugSetPlayerLevelAsyncStub_003Ed__200))]
			public Task<IMessage> DebugSetPlayerLevelAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039AF")]
			[Cpp2IlInjected.Address(RVA = "0x57A230", Offset = "0x578C30", VA = "0x18057A230", Slot = "74")]
			public virtual Task<DebugSetPlayerLevel.Types.Response> DebugSetPlayerLevelAsync(DebugSetPlayerLevel.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugSetPlayerLevelAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039B0")]
			[Cpp2IlInjected.Address(RVA = "0x576E70", Offset = "0x575870", VA = "0x180576E70")]
			[AsyncStateMachine(typeof(_003CDebugAddFreeTimerInvokerAsync_003Ed__202))]
			public Task<CallResult<IMessage>> DebugAddFreeTimerInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039B1")]
			[Cpp2IlInjected.Address(RVA = "0x576CC0", Offset = "0x5756C0", VA = "0x180576CC0")]
			[AsyncStateMachine(typeof(_003CDebugAddFreeTimerAsyncStub_003Ed__203))]
			public Task<IMessage> DebugAddFreeTimerAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039B2")]
			[Cpp2IlInjected.Address(RVA = "0x576E20", Offset = "0x575820", VA = "0x180576E20", Slot = "75")]
			public virtual Task<DebugAddFreeTimer.Types.Response> DebugAddFreeTimerAsync(DebugAddFreeTimer.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugAddFreeTimerAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039B3")]
			[Cpp2IlInjected.Address(RVA = "0x578A00", Offset = "0x577400", VA = "0x180578A00")]
			[AsyncStateMachine(typeof(_003CDebugForceActivityBonusRewardInvokerAsync_003Ed__205))]
			public Task<CallResult<IMessage>> DebugForceActivityBonusRewardInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039B4")]
			[Cpp2IlInjected.Address(RVA = "0x578850", Offset = "0x577250", VA = "0x180578850")]
			[AsyncStateMachine(typeof(_003CDebugForceActivityBonusRewardAsyncStub_003Ed__206))]
			public Task<IMessage> DebugForceActivityBonusRewardAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039B5")]
			[Cpp2IlInjected.Address(RVA = "0x5789B0", Offset = "0x5773B0", VA = "0x1805789B0", Slot = "76")]
			public virtual Task<DebugForceActivityBonusReward.Types.Response> DebugForceActivityBonusRewardAsync(DebugForceActivityBonusReward.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugForceActivityBonusRewardAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039B6")]
			[Cpp2IlInjected.Address(RVA = "0x578D10", Offset = "0x577710", VA = "0x180578D10")]
			[AsyncStateMachine(typeof(_003CDebugForceBurningStateInvokerAsync_003Ed__208))]
			public Task<CallResult<IMessage>> DebugForceBurningStateInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039B7")]
			[Cpp2IlInjected.Address(RVA = "0x578B60", Offset = "0x577560", VA = "0x180578B60")]
			[AsyncStateMachine(typeof(_003CDebugForceBurningStateAsyncStub_003Ed__209))]
			public Task<IMessage> DebugForceBurningStateAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039B8")]
			[Cpp2IlInjected.Address(RVA = "0x578CC0", Offset = "0x5776C0", VA = "0x180578CC0", Slot = "77")]
			public virtual Task<DebugForceBurningState.Types.Response> DebugForceBurningStateAsync(DebugForceBurningState.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugForceBurningStateAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039B9")]
			[Cpp2IlInjected.Address(RVA = "0x579020", Offset = "0x577A20", VA = "0x180579020")]
			[AsyncStateMachine(typeof(_003CDebugForceSecretCharacterInvokerAsync_003Ed__211))]
			public Task<CallResult<IMessage>> DebugForceSecretCharacterInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039BA")]
			[Cpp2IlInjected.Address(RVA = "0x578E70", Offset = "0x577870", VA = "0x180578E70")]
			[AsyncStateMachine(typeof(_003CDebugForceSecretCharacterAsyncStub_003Ed__212))]
			public Task<IMessage> DebugForceSecretCharacterAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039BB")]
			[Cpp2IlInjected.Address(RVA = "0x578FD0", Offset = "0x5779D0", VA = "0x180578FD0", Slot = "78")]
			public virtual Task<DebugForceSecretCharacter.Types.Response> DebugForceSecretCharacterAsync(DebugForceSecretCharacter.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugForceSecretCharacterAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039BC")]
			[Cpp2IlInjected.Address(RVA = "0x57B4E0", Offset = "0x579EE0", VA = "0x18057B4E0")]
			[AsyncStateMachine(typeof(_003CDebugUnlockAllCrittersInvokerAsync_003Ed__214))]
			public Task<CallResult<IMessage>> DebugUnlockAllCrittersInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039BD")]
			[Cpp2IlInjected.Address(RVA = "0x57B330", Offset = "0x579D30", VA = "0x18057B330")]
			[AsyncStateMachine(typeof(_003CDebugUnlockAllCrittersAsyncStub_003Ed__215))]
			public Task<IMessage> DebugUnlockAllCrittersAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039BE")]
			[Cpp2IlInjected.Address(RVA = "0x57B490", Offset = "0x579E90", VA = "0x18057B490", Slot = "79")]
			public virtual Task<DebugUnlockAllCritters.Types.Response> DebugUnlockAllCrittersAsync(DebugUnlockAllCritters.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugUnlockAllCrittersAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039BF")]
			[Cpp2IlInjected.Address(RVA = "0x57C120", Offset = "0x57AB20", VA = "0x18057C120")]
			[AsyncStateMachine(typeof(_003CDebugUnlockVillageAreaInvokerAsync_003Ed__217))]
			public Task<CallResult<IMessage>> DebugUnlockVillageAreaInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039C0")]
			[Cpp2IlInjected.Address(RVA = "0x57BF70", Offset = "0x57A970", VA = "0x18057BF70")]
			[AsyncStateMachine(typeof(_003CDebugUnlockVillageAreaAsyncStub_003Ed__218))]
			public Task<IMessage> DebugUnlockVillageAreaAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039C1")]
			[Cpp2IlInjected.Address(RVA = "0x57C0D0", Offset = "0x57AAD0", VA = "0x18057C0D0", Slot = "80")]
			public virtual Task<DebugUnlockVillageArea.Types.Response> DebugUnlockVillageAreaAsync(DebugUnlockVillageArea.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugUnlockVillageAreaAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039C2")]
			[Cpp2IlInjected.Address(RVA = "0x57B1D0", Offset = "0x579BD0", VA = "0x18057B1D0")]
			[AsyncStateMachine(typeof(_003CDebugUnlockAllBuildingsInvokerAsync_003Ed__220))]
			public Task<CallResult<IMessage>> DebugUnlockAllBuildingsInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039C3")]
			[Cpp2IlInjected.Address(RVA = "0x57B020", Offset = "0x579A20", VA = "0x18057B020")]
			[AsyncStateMachine(typeof(_003CDebugUnlockAllBuildingsAsyncStub_003Ed__221))]
			public Task<IMessage> DebugUnlockAllBuildingsAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039C4")]
			[Cpp2IlInjected.Address(RVA = "0x57B180", Offset = "0x579B80", VA = "0x18057B180", Slot = "81")]
			public virtual Task<DebugUnlockAllBuildings.Types.Response> DebugUnlockAllBuildingsAsync(DebugUnlockAllBuildings.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugUnlockAllBuildingsAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039C5")]
			[Cpp2IlInjected.Address(RVA = "0x57B7F0", Offset = "0x57A1F0", VA = "0x18057B7F0")]
			[AsyncStateMachine(typeof(_003CDebugUnlockAllRealmsInvokerAsync_003Ed__223))]
			public Task<CallResult<IMessage>> DebugUnlockAllRealmsInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039C6")]
			[Cpp2IlInjected.Address(RVA = "0x57B640", Offset = "0x57A040", VA = "0x18057B640")]
			[AsyncStateMachine(typeof(_003CDebugUnlockAllRealmsAsyncStub_003Ed__224))]
			public Task<IMessage> DebugUnlockAllRealmsAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039C7")]
			[Cpp2IlInjected.Address(RVA = "0x57B7A0", Offset = "0x57A1A0", VA = "0x18057B7A0", Slot = "82")]
			public virtual Task<DebugUnlockAllRealms.Types.Response> DebugUnlockAllRealmsAsync(DebugUnlockAllRealms.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugUnlockAllRealmsAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039C8")]
			[Cpp2IlInjected.Address(RVA = "0x57BE10", Offset = "0x57A810", VA = "0x18057BE10")]
			[AsyncStateMachine(typeof(_003CDebugUnlockCharacterPreferredItemsInvokerAsync_003Ed__226))]
			public Task<CallResult<IMessage>> DebugUnlockCharacterPreferredItemsInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039C9")]
			[Cpp2IlInjected.Address(RVA = "0x57BC60", Offset = "0x57A660", VA = "0x18057BC60")]
			[AsyncStateMachine(typeof(_003CDebugUnlockCharacterPreferredItemsAsyncStub_003Ed__227))]
			public Task<IMessage> DebugUnlockCharacterPreferredItemsAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039CA")]
			[Cpp2IlInjected.Address(RVA = "0x57BDC0", Offset = "0x57A7C0", VA = "0x18057BDC0", Slot = "83")]
			public virtual Task<DebugUnlockCharacterPreferredItems.Types.Response> DebugUnlockCharacterPreferredItemsAsync(DebugUnlockCharacterPreferredItems.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugUnlockCharacterPreferredItemsAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039CB")]
			[Cpp2IlInjected.Address(RVA = "0x579950", Offset = "0x578350", VA = "0x180579950")]
			[AsyncStateMachine(typeof(_003CDebugRemoveAllForagingItemsInvokerAsync_003Ed__229))]
			public Task<CallResult<IMessage>> DebugRemoveAllForagingItemsInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039CC")]
			[Cpp2IlInjected.Address(RVA = "0x5797A0", Offset = "0x5781A0", VA = "0x1805797A0")]
			[AsyncStateMachine(typeof(_003CDebugRemoveAllForagingItemsAsyncStub_003Ed__230))]
			public Task<IMessage> DebugRemoveAllForagingItemsAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039CD")]
			[Cpp2IlInjected.Address(RVA = "0x579900", Offset = "0x578300", VA = "0x180579900", Slot = "84")]
			public virtual Task<DebugRemoveAllForagingItems.Types.Response> DebugRemoveAllForagingItemsAsync(DebugRemoveAllForagingItems.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugRemoveAllForagingItemsAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039CE")]
			[Cpp2IlInjected.Address(RVA = "0x5780D0", Offset = "0x576AD0", VA = "0x1805780D0")]
			[AsyncStateMachine(typeof(_003CDebugEmptyAllActivitySourcesInvokerAsync_003Ed__232))]
			public Task<CallResult<IMessage>> DebugEmptyAllActivitySourcesInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039CF")]
			[Cpp2IlInjected.Address(RVA = "0x577F20", Offset = "0x576920", VA = "0x180577F20")]
			[AsyncStateMachine(typeof(_003CDebugEmptyAllActivitySourcesAsyncStub_003Ed__233))]
			public Task<IMessage> DebugEmptyAllActivitySourcesAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039D0")]
			[Cpp2IlInjected.Address(RVA = "0x578080", Offset = "0x576A80", VA = "0x180578080", Slot = "85")]
			public virtual Task<DebugEmptyAllActivitySources.Types.Response> DebugEmptyAllActivitySourcesAsync(DebugEmptyAllActivitySources.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugEmptyAllActivitySourcesAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039D1")]
			[Cpp2IlInjected.Address(RVA = "0x5786F0", Offset = "0x5770F0", VA = "0x1805786F0")]
			[AsyncStateMachine(typeof(_003CDebugFakeRPCExceptionInvokerAsync_003Ed__235))]
			public Task<CallResult<IMessage>> DebugFakeRPCExceptionInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039D2")]
			[Cpp2IlInjected.Address(RVA = "0x578540", Offset = "0x576F40", VA = "0x180578540")]
			[AsyncStateMachine(typeof(_003CDebugFakeRPCExceptionAsyncStub_003Ed__236))]
			public Task<IMessage> DebugFakeRPCExceptionAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039D3")]
			[Cpp2IlInjected.Address(RVA = "0x5786A0", Offset = "0x5770A0", VA = "0x1805786A0", Slot = "86")]
			public virtual Task<DebugFakeRPCException.Types.Response> DebugFakeRPCExceptionAsync(DebugFakeRPCException.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugFakeRPCExceptionAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039D4")]
			[Cpp2IlInjected.Address(RVA = "0x57D9A0", Offset = "0x57C3A0", VA = "0x18057D9A0")]
			[AsyncStateMachine(typeof(_003CEndMissionInvokerAsync_003Ed__238))]
			public Task<CallResult<IMessage>> EndMissionInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039D5")]
			[Cpp2IlInjected.Address(RVA = "0x57D7F0", Offset = "0x57C1F0", VA = "0x18057D7F0")]
			[AsyncStateMachine(typeof(_003CEndMissionAsyncStub_003Ed__239))]
			public Task<IMessage> EndMissionAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039D6")]
			[Cpp2IlInjected.Address(RVA = "0x57D950", Offset = "0x57C350", VA = "0x18057D950", Slot = "87")]
			public virtual Task<EndMission.Types.Response> EndMissionAsync(EndMission.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: EndMissionAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039D7")]
			[Cpp2IlInjected.Address(RVA = "0x580480", Offset = "0x57EE80", VA = "0x180580480")]
			[AsyncStateMachine(typeof(_003CInitTLEInvokerAsync_003Ed__241))]
			public Task<CallResult<IMessage>> InitTLEInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039D8")]
			[Cpp2IlInjected.Address(RVA = "0x5802D0", Offset = "0x57ECD0", VA = "0x1805802D0")]
			[AsyncStateMachine(typeof(_003CInitTLEAsyncStub_003Ed__242))]
			public Task<IMessage> InitTLEAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039D9")]
			[Cpp2IlInjected.Address(RVA = "0x580430", Offset = "0x57EE30", VA = "0x180580430", Slot = "88")]
			public virtual Task<InitTLE.Types.Response> InitTLEAsync(InitTLE.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: InitTLEAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039DA")]
			[Cpp2IlInjected.Address(RVA = "0x573D70", Offset = "0x572770", VA = "0x180573D70")]
			[AsyncStateMachine(typeof(_003CClaimMiniEventRewardInvokerAsync_003Ed__244))]
			public Task<CallResult<IMessage>> ClaimMiniEventRewardInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039DB")]
			[Cpp2IlInjected.Address(RVA = "0x573BC0", Offset = "0x5725C0", VA = "0x180573BC0")]
			[AsyncStateMachine(typeof(_003CClaimMiniEventRewardAsyncStub_003Ed__245))]
			public Task<IMessage> ClaimMiniEventRewardAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039DC")]
			[Cpp2IlInjected.Address(RVA = "0x573D20", Offset = "0x572720", VA = "0x180573D20", Slot = "89")]
			public virtual Task<ClaimMiniEventReward.Types.Response> ClaimMiniEventRewardAsync(ClaimMiniEventReward.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ClaimMiniEventRewardAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039DD")]
			[Cpp2IlInjected.Address(RVA = "0x58A9E0", Offset = "0x5893E0", VA = "0x18058A9E0")]
			[AsyncStateMachine(typeof(_003CStartMissionInvokerAsync_003Ed__247))]
			public Task<CallResult<IMessage>> StartMissionInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039DE")]
			[Cpp2IlInjected.Address(RVA = "0x58A830", Offset = "0x589230", VA = "0x18058A830")]
			[AsyncStateMachine(typeof(_003CStartMissionAsyncStub_003Ed__248))]
			public Task<IMessage> StartMissionAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039DF")]
			[Cpp2IlInjected.Address(RVA = "0x58A990", Offset = "0x589390", VA = "0x18058A990", Slot = "90")]
			public virtual Task<StartMission.Types.Response> StartMissionAsync(StartMission.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: StartMissionAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039E0")]
			[Cpp2IlInjected.Address(RVA = "0x58E100", Offset = "0x58CB00", VA = "0x18058E100")]
			[AsyncStateMachine(typeof(_003CUpdateDialogueFlagsInvokerAsync_003Ed__250))]
			public Task<CallResult<IMessage>> UpdateDialogueFlagsInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039E1")]
			[Cpp2IlInjected.Address(RVA = "0x58DF50", Offset = "0x58C950", VA = "0x18058DF50")]
			[AsyncStateMachine(typeof(_003CUpdateDialogueFlagsAsyncStub_003Ed__251))]
			public Task<IMessage> UpdateDialogueFlagsAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039E2")]
			[Cpp2IlInjected.Address(RVA = "0x58E0B0", Offset = "0x58CAB0", VA = "0x18058E0B0", Slot = "91")]
			public virtual Task<UpdateDialogueFlags.Types.Response> UpdateDialogueFlagsAsync(UpdateDialogueFlags.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: UpdateDialogueFlagsAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039E3")]
			[Cpp2IlInjected.Address(RVA = "0x58C880", Offset = "0x58B280", VA = "0x18058C880")]
			[AsyncStateMachine(typeof(_003CTrackMissionInvokerAsync_003Ed__253))]
			public Task<CallResult<IMessage>> TrackMissionInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039E4")]
			[Cpp2IlInjected.Address(RVA = "0x58C6D0", Offset = "0x58B0D0", VA = "0x18058C6D0")]
			[AsyncStateMachine(typeof(_003CTrackMissionAsyncStub_003Ed__254))]
			public Task<IMessage> TrackMissionAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039E5")]
			[Cpp2IlInjected.Address(RVA = "0x58C830", Offset = "0x58B230", VA = "0x18058C830", Slot = "92")]
			public virtual Task<TrackMission.Types.Response> TrackMissionAsync(TrackMission.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: TrackMissionAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039E6")]
			[Cpp2IlInjected.Address(RVA = "0x588520", Offset = "0x586F20", VA = "0x180588520")]
			[AsyncStateMachine(typeof(_003CSetMissionNextChoiceInvokerAsync_003Ed__256))]
			public Task<CallResult<IMessage>> SetMissionNextChoiceInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039E7")]
			[Cpp2IlInjected.Address(RVA = "0x588370", Offset = "0x586D70", VA = "0x180588370")]
			[AsyncStateMachine(typeof(_003CSetMissionNextChoiceAsyncStub_003Ed__257))]
			public Task<IMessage> SetMissionNextChoiceAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039E8")]
			[Cpp2IlInjected.Address(RVA = "0x5884D0", Offset = "0x586ED0", VA = "0x1805884D0", Slot = "93")]
			public virtual Task<SetMissionNextChoice.Types.Response> SetMissionNextChoiceAsync(SetMissionNextChoice.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SetMissionNextChoiceAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039E9")]
			[Cpp2IlInjected.Address(RVA = "0x582940", Offset = "0x581340", VA = "0x180582940")]
			[AsyncStateMachine(typeof(_003CPictureTakenInvokerAsync_003Ed__259))]
			public Task<CallResult<IMessage>> PictureTakenInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039EA")]
			[Cpp2IlInjected.Address(RVA = "0x582790", Offset = "0x581190", VA = "0x180582790")]
			[AsyncStateMachine(typeof(_003CPictureTakenAsyncStub_003Ed__260))]
			public Task<IMessage> PictureTakenAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039EB")]
			[Cpp2IlInjected.Address(RVA = "0x5828F0", Offset = "0x5812F0", VA = "0x1805828F0", Slot = "94")]
			public virtual Task<PictureTaken.Types.Response> PictureTakenAsync(PictureTaken.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: PictureTakenAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039EC")]
			[Cpp2IlInjected.Address(RVA = "0x5816E0", Offset = "0x5800E0", VA = "0x1805816E0")]
			[AsyncStateMachine(typeof(_003CMissionItemInteractionInvokerAsync_003Ed__262))]
			public Task<CallResult<IMessage>> MissionItemInteractionInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039ED")]
			[Cpp2IlInjected.Address(RVA = "0x581530", Offset = "0x57FF30", VA = "0x180581530")]
			[AsyncStateMachine(typeof(_003CMissionItemInteractionAsyncStub_003Ed__263))]
			public Task<IMessage> MissionItemInteractionAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039EE")]
			[Cpp2IlInjected.Address(RVA = "0x581690", Offset = "0x580090", VA = "0x180581690", Slot = "95")]
			public virtual Task<MissionItemInteraction.Types.Response> MissionItemInteractionAsync(MissionItemInteraction.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: MissionItemInteractionAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039EF")]
			[Cpp2IlInjected.Address(RVA = "0x5813D0", Offset = "0x57FDD0", VA = "0x1805813D0")]
			[AsyncStateMachine(typeof(_003CMissionCompleteStepInvokerAsync_003Ed__265))]
			public Task<CallResult<IMessage>> MissionCompleteStepInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039F0")]
			[Cpp2IlInjected.Address(RVA = "0x581220", Offset = "0x57FC20", VA = "0x180581220")]
			[AsyncStateMachine(typeof(_003CMissionCompleteStepAsyncStub_003Ed__266))]
			public Task<IMessage> MissionCompleteStepAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039F1")]
			[Cpp2IlInjected.Address(RVA = "0x581380", Offset = "0x57FD80", VA = "0x180581380", Slot = "96")]
			public virtual Task<MissionCompleteStep.Types.Response> MissionCompleteStepAsync(MissionCompleteStep.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: MissionCompleteStepAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039F2")]
			[Cpp2IlInjected.Address(RVA = "0x577AB0", Offset = "0x5764B0", VA = "0x180577AB0")]
			[AsyncStateMachine(typeof(_003CDebugCancelMissionInvokerAsync_003Ed__268))]
			public Task<CallResult<IMessage>> DebugCancelMissionInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039F3")]
			[Cpp2IlInjected.Address(RVA = "0x577900", Offset = "0x576300", VA = "0x180577900")]
			[AsyncStateMachine(typeof(_003CDebugCancelMissionAsyncStub_003Ed__269))]
			public Task<IMessage> DebugCancelMissionAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039F4")]
			[Cpp2IlInjected.Address(RVA = "0x577A60", Offset = "0x576460", VA = "0x180577A60", Slot = "97")]
			public virtual Task<DebugCancelMission.Types.Response> DebugCancelMissionAsync(DebugCancelMission.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugCancelMissionAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039F5")]
			[Cpp2IlInjected.Address(RVA = "0x57AEC0", Offset = "0x5798C0", VA = "0x18057AEC0")]
			[AsyncStateMachine(typeof(_003CDebugTestMissionInvokerAsync_003Ed__271))]
			public Task<CallResult<IMessage>> DebugTestMissionInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039F6")]
			[Cpp2IlInjected.Address(RVA = "0x57AD10", Offset = "0x579710", VA = "0x18057AD10")]
			[AsyncStateMachine(typeof(_003CDebugTestMissionAsyncStub_003Ed__272))]
			public Task<IMessage> DebugTestMissionAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039F7")]
			[Cpp2IlInjected.Address(RVA = "0x57AE70", Offset = "0x579870", VA = "0x18057AE70", Slot = "98")]
			public virtual Task<DebugTestMission.Types.Response> DebugTestMissionAsync(DebugTestMission.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugTestMissionAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039F8")]
			[Cpp2IlInjected.Address(RVA = "0x57A590", Offset = "0x578F90", VA = "0x18057A590")]
			[AsyncStateMachine(typeof(_003CDebugSkipMissionStepInvokerAsync_003Ed__274))]
			public Task<CallResult<IMessage>> DebugSkipMissionStepInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039F9")]
			[Cpp2IlInjected.Address(RVA = "0x57A3E0", Offset = "0x578DE0", VA = "0x18057A3E0")]
			[AsyncStateMachine(typeof(_003CDebugSkipMissionStepAsyncStub_003Ed__275))]
			public Task<IMessage> DebugSkipMissionStepAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039FA")]
			[Cpp2IlInjected.Address(RVA = "0x57A540", Offset = "0x578F40", VA = "0x18057A540", Slot = "99")]
			public virtual Task<DebugSkipMissionStep.Types.Response> DebugSkipMissionStepAsync(DebugSkipMissionStep.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugSkipMissionStepAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039FB")]
			[Cpp2IlInjected.Address(RVA = "0x576850", Offset = "0x575250", VA = "0x180576850")]
			[AsyncStateMachine(typeof(_003CCreateGardeningTileInvokerAsync_003Ed__277))]
			public Task<CallResult<IMessage>> CreateGardeningTileInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039FC")]
			[Cpp2IlInjected.Address(RVA = "0x5766A0", Offset = "0x5750A0", VA = "0x1805766A0")]
			[AsyncStateMachine(typeof(_003CCreateGardeningTileAsyncStub_003Ed__278))]
			public Task<IMessage> CreateGardeningTileAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039FD")]
			[Cpp2IlInjected.Address(RVA = "0x576800", Offset = "0x575200", VA = "0x180576800", Slot = "100")]
			public virtual Task<CreateGardeningTile.Types.Response> CreateGardeningTileAsync(CreateGardeningTile.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: CreateGardeningTileAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60039FE")]
			[Cpp2IlInjected.Address(RVA = "0x584AF0", Offset = "0x5834F0", VA = "0x180584AF0")]
			[AsyncStateMachine(typeof(_003CRemoveGardeningTileInvokerAsync_003Ed__280))]
			public Task<CallResult<IMessage>> RemoveGardeningTileInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x60039FF")]
			[Cpp2IlInjected.Address(RVA = "0x584940", Offset = "0x583340", VA = "0x180584940")]
			[AsyncStateMachine(typeof(_003CRemoveGardeningTileAsyncStub_003Ed__281))]
			public Task<IMessage> RemoveGardeningTileAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A00")]
			[Cpp2IlInjected.Address(RVA = "0x584AA0", Offset = "0x5834A0", VA = "0x180584AA0", Slot = "101")]
			public virtual Task<RemoveGardeningTile.Types.Response> RemoveGardeningTileAsync(RemoveGardeningTile.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: RemoveGardeningTileAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A01")]
			[Cpp2IlInjected.Address(RVA = "0x583890", Offset = "0x582290", VA = "0x180583890")]
			[AsyncStateMachine(typeof(_003CPlantSeedInvokerAsync_003Ed__283))]
			public Task<CallResult<IMessage>> PlantSeedInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A02")]
			[Cpp2IlInjected.Address(RVA = "0x5836E0", Offset = "0x5820E0", VA = "0x1805836E0")]
			[AsyncStateMachine(typeof(_003CPlantSeedAsyncStub_003Ed__284))]
			public Task<IMessage> PlantSeedAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A03")]
			[Cpp2IlInjected.Address(RVA = "0x583840", Offset = "0x582240", VA = "0x180583840", Slot = "102")]
			public virtual Task<PlantSeed.Types.Response> PlantSeedAsync(PlantSeed.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: PlantSeedAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A04")]
			[Cpp2IlInjected.Address(RVA = "0x57EF10", Offset = "0x57D910", VA = "0x18057EF10")]
			[AsyncStateMachine(typeof(_003CFinishGardeningSlotGrowthInvokerAsync_003Ed__286))]
			public Task<CallResult<IMessage>> FinishGardeningSlotGrowthInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A05")]
			[Cpp2IlInjected.Address(RVA = "0x57ED60", Offset = "0x57D760", VA = "0x18057ED60")]
			[AsyncStateMachine(typeof(_003CFinishGardeningSlotGrowthAsyncStub_003Ed__287))]
			public Task<IMessage> FinishGardeningSlotGrowthAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A06")]
			[Cpp2IlInjected.Address(RVA = "0x57EEC0", Offset = "0x57D8C0", VA = "0x18057EEC0", Slot = "103")]
			public virtual Task<FinishGardeningSlotGrowth.Types.Response> FinishGardeningSlotGrowthAsync(FinishGardeningSlotGrowth.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: FinishGardeningSlotGrowthAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A07")]
			[Cpp2IlInjected.Address(RVA = "0x57FE60", Offset = "0x57E860", VA = "0x18057FE60")]
			[AsyncStateMachine(typeof(_003CHarvestGardeningSlotInvokerAsync_003Ed__289))]
			public Task<CallResult<IMessage>> HarvestGardeningSlotInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A08")]
			[Cpp2IlInjected.Address(RVA = "0x57FCB0", Offset = "0x57E6B0", VA = "0x18057FCB0")]
			[AsyncStateMachine(typeof(_003CHarvestGardeningSlotAsyncStub_003Ed__290))]
			public Task<IMessage> HarvestGardeningSlotAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A09")]
			[Cpp2IlInjected.Address(RVA = "0x57FE10", Offset = "0x57E810", VA = "0x18057FE10", Slot = "104")]
			public virtual Task<HarvestGardeningSlot.Types.Response> HarvestGardeningSlotAsync(HarvestGardeningSlot.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: HarvestGardeningSlotAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A0A")]
			[Cpp2IlInjected.Address(RVA = "0x574FD0", Offset = "0x5739D0", VA = "0x180574FD0")]
			[AsyncStateMachine(typeof(_003CCollectGardenStallSlotInvokerAsync_003Ed__292))]
			public Task<CallResult<IMessage>> CollectGardenStallSlotInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A0B")]
			[Cpp2IlInjected.Address(RVA = "0x574E20", Offset = "0x573820", VA = "0x180574E20")]
			[AsyncStateMachine(typeof(_003CCollectGardenStallSlotAsyncStub_003Ed__293))]
			public Task<IMessage> CollectGardenStallSlotAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A0C")]
			[Cpp2IlInjected.Address(RVA = "0x574F80", Offset = "0x573980", VA = "0x180574F80", Slot = "105")]
			public virtual Task<CollectGardenStallSlot.Types.Response> CollectGardenStallSlotAsync(CollectGardenStallSlot.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: CollectGardenStallSlotAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A0D")]
			[Cpp2IlInjected.Address(RVA = "0x58F980", Offset = "0x58E380", VA = "0x18058F980")]
			[AsyncStateMachine(typeof(_003CWaterObjectsInvokerAsync_003Ed__295))]
			public Task<CallResult<IMessage>> WaterObjectsInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A0E")]
			[Cpp2IlInjected.Address(RVA = "0x58F7D0", Offset = "0x58E1D0", VA = "0x18058F7D0")]
			[AsyncStateMachine(typeof(_003CWaterObjectsAsyncStub_003Ed__296))]
			public Task<IMessage> WaterObjectsAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A0F")]
			[Cpp2IlInjected.Address(RVA = "0x58F930", Offset = "0x58E330", VA = "0x18058F930", Slot = "106")]
			public virtual Task<WaterObjects.Types.Response> WaterObjectsAsync(WaterObjects.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: WaterObjectsAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A10")]
			[Cpp2IlInjected.Address(RVA = "0x589DA0", Offset = "0x5887A0", VA = "0x180589DA0")]
			[AsyncStateMachine(typeof(_003CStartFishingInvokerAsync_003Ed__298))]
			public Task<CallResult<IMessage>> StartFishingInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A11")]
			[Cpp2IlInjected.Address(RVA = "0x589BF0", Offset = "0x5885F0", VA = "0x180589BF0")]
			[AsyncStateMachine(typeof(_003CStartFishingAsyncStub_003Ed__299))]
			public Task<IMessage> StartFishingAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A12")]
			[Cpp2IlInjected.Address(RVA = "0x589D50", Offset = "0x588750", VA = "0x180589D50", Slot = "107")]
			public virtual Task<StartFishing.Types.Response> StartFishingAsync(StartFishing.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: StartFishingAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A13")]
			[Cpp2IlInjected.Address(RVA = "0x586680", Offset = "0x585080", VA = "0x180586680")]
			[AsyncStateMachine(typeof(_003CSendFishingResultInvokerAsync_003Ed__301))]
			public Task<CallResult<IMessage>> SendFishingResultInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A14")]
			[Cpp2IlInjected.Address(RVA = "0x5864D0", Offset = "0x584ED0", VA = "0x1805864D0")]
			[AsyncStateMachine(typeof(_003CSendFishingResultAsyncStub_003Ed__302))]
			public Task<IMessage> SendFishingResultAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A15")]
			[Cpp2IlInjected.Address(RVA = "0x586630", Offset = "0x585030", VA = "0x180586630", Slot = "108")]
			public virtual Task<SendFishingResult.Types.Response> SendFishingResultAsync(SendFishingResult.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SendFishingResultAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A16")]
			[Cpp2IlInjected.Address(RVA = "0x58EA30", Offset = "0x58D430", VA = "0x18058EA30")]
			[AsyncStateMachine(typeof(_003CUpdatePendingFishesInvokerAsync_003Ed__304))]
			public Task<CallResult<IMessage>> UpdatePendingFishesInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A17")]
			[Cpp2IlInjected.Address(RVA = "0x58E880", Offset = "0x58D280", VA = "0x18058E880")]
			[AsyncStateMachine(typeof(_003CUpdatePendingFishesAsyncStub_003Ed__305))]
			public Task<IMessage> UpdatePendingFishesAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A18")]
			[Cpp2IlInjected.Address(RVA = "0x58E9E0", Offset = "0x58D3E0", VA = "0x18058E9E0", Slot = "109")]
			public virtual Task<UpdatePendingFishes.Types.Response> UpdatePendingFishesAsync(UpdatePendingFishes.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: UpdatePendingFishesAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A19")]
			[Cpp2IlInjected.Address(RVA = "0x574CC0", Offset = "0x5736C0", VA = "0x180574CC0")]
			[AsyncStateMachine(typeof(_003CCollectFishingStallInvokerAsync_003Ed__307))]
			public Task<CallResult<IMessage>> CollectFishingStallInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A1A")]
			[Cpp2IlInjected.Address(RVA = "0x574B10", Offset = "0x573510", VA = "0x180574B10")]
			[AsyncStateMachine(typeof(_003CCollectFishingStallAsyncStub_003Ed__308))]
			public Task<IMessage> CollectFishingStallAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A1B")]
			[Cpp2IlInjected.Address(RVA = "0x574C70", Offset = "0x573670", VA = "0x180574C70", Slot = "110")]
			public virtual Task<CollectFishingStall.Types.Response> CollectFishingStallAsync(CollectFishingStall.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: CollectFishingStallAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A1C")]
			[Cpp2IlInjected.Address(RVA = "0x58A3C0", Offset = "0x588DC0", VA = "0x18058A3C0")]
			[AsyncStateMachine(typeof(_003CStartHangoutWithCharacterInvokerAsync_003Ed__310))]
			public Task<CallResult<IMessage>> StartHangoutWithCharacterInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A1D")]
			[Cpp2IlInjected.Address(RVA = "0x58A210", Offset = "0x588C10", VA = "0x18058A210")]
			[AsyncStateMachine(typeof(_003CStartHangoutWithCharacterAsyncStub_003Ed__311))]
			public Task<IMessage> StartHangoutWithCharacterAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A1E")]
			[Cpp2IlInjected.Address(RVA = "0x58A370", Offset = "0x588D70", VA = "0x18058A370", Slot = "111")]
			public virtual Task<StartHangoutWithCharacter.Types.Response> StartHangoutWithCharacterAsync(StartHangoutWithCharacter.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: StartHangoutWithCharacterAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A1F")]
			[Cpp2IlInjected.Address(RVA = "0x58B000", Offset = "0x589A00", VA = "0x18058B000")]
			[AsyncStateMachine(typeof(_003CStopHangoutWithCharacterInvokerAsync_003Ed__313))]
			public Task<CallResult<IMessage>> StopHangoutWithCharacterInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A20")]
			[Cpp2IlInjected.Address(RVA = "0x58AE50", Offset = "0x589850", VA = "0x18058AE50")]
			[AsyncStateMachine(typeof(_003CStopHangoutWithCharacterAsyncStub_003Ed__314))]
			public Task<IMessage> StopHangoutWithCharacterAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A21")]
			[Cpp2IlInjected.Address(RVA = "0x58AFB0", Offset = "0x5899B0", VA = "0x18058AFB0", Slot = "112")]
			public virtual Task<StopHangoutWithCharacter.Types.Response> StopHangoutWithCharacterAsync(StopHangoutWithCharacter.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: StopHangoutWithCharacterAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A22")]
			[Cpp2IlInjected.Address(RVA = "0x589A90", Offset = "0x588490", VA = "0x180589A90")]
			[AsyncStateMachine(typeof(_003CSpawnHangoutRewardsForCharacterInvokerAsync_003Ed__316))]
			public Task<CallResult<IMessage>> SpawnHangoutRewardsForCharacterInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A23")]
			[Cpp2IlInjected.Address(RVA = "0x5898E0", Offset = "0x5882E0", VA = "0x1805898E0")]
			[AsyncStateMachine(typeof(_003CSpawnHangoutRewardsForCharacterAsyncStub_003Ed__317))]
			public Task<IMessage> SpawnHangoutRewardsForCharacterAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A24")]
			[Cpp2IlInjected.Address(RVA = "0x589A40", Offset = "0x588440", VA = "0x180589A40", Slot = "113")]
			public virtual Task<SpawnHangoutRewardsForCharacter.Types.Response> SpawnHangoutRewardsForCharacterAsync(SpawnHangoutRewardsForCharacter.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SpawnHangoutRewardsForCharacterAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A25")]
			[Cpp2IlInjected.Address(RVA = "0x582F60", Offset = "0x581960", VA = "0x180582F60")]
			[AsyncStateMachine(typeof(_003CPlaceBuildingInvokerAsync_003Ed__319))]
			public Task<CallResult<IMessage>> PlaceBuildingInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A26")]
			[Cpp2IlInjected.Address(RVA = "0x582DB0", Offset = "0x5817B0", VA = "0x180582DB0")]
			[AsyncStateMachine(typeof(_003CPlaceBuildingAsyncStub_003Ed__320))]
			public Task<IMessage> PlaceBuildingAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A27")]
			[Cpp2IlInjected.Address(RVA = "0x582F10", Offset = "0x581910", VA = "0x180582F10", Slot = "114")]
			public virtual Task<PlaceBuilding.Types.Response> PlaceBuildingAsync(PlaceBuilding.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: PlaceBuildingAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A28")]
			[Cpp2IlInjected.Address(RVA = "0x584E00", Offset = "0x583800", VA = "0x180584E00")]
			[AsyncStateMachine(typeof(_003CRemoveHouseInvokerAsync_003Ed__322))]
			public Task<CallResult<IMessage>> RemoveHouseInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A29")]
			[Cpp2IlInjected.Address(RVA = "0x584C50", Offset = "0x583650", VA = "0x180584C50")]
			[AsyncStateMachine(typeof(_003CRemoveHouseAsyncStub_003Ed__323))]
			public Task<IMessage> RemoveHouseAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A2A")]
			[Cpp2IlInjected.Address(RVA = "0x584DB0", Offset = "0x5837B0", VA = "0x180584DB0", Slot = "115")]
			public virtual Task<RemoveHouse.Types.Response> RemoveHouseAsync(RemoveHouse.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: RemoveHouseAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A2B")]
			[Cpp2IlInjected.Address(RVA = "0x571BC0", Offset = "0x5705C0", VA = "0x180571BC0")]
			[AsyncStateMachine(typeof(_003CBuildHouseInvokerAsync_003Ed__325))]
			public Task<CallResult<IMessage>> BuildHouseInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A2C")]
			[Cpp2IlInjected.Address(RVA = "0x571A10", Offset = "0x570410", VA = "0x180571A10")]
			[AsyncStateMachine(typeof(_003CBuildHouseAsyncStub_003Ed__326))]
			public Task<IMessage> BuildHouseAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A2D")]
			[Cpp2IlInjected.Address(RVA = "0x571B70", Offset = "0x570570", VA = "0x180571B70", Slot = "116")]
			public virtual Task<BuildHouse.Types.Response> BuildHouseAsync(BuildHouse.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: BuildHouseAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A2E")]
			[Cpp2IlInjected.Address(RVA = "0x58CB90", Offset = "0x58B590", VA = "0x18058CB90")]
			[AsyncStateMachine(typeof(_003CTransferToPantryInvokerAsync_003Ed__328))]
			public Task<CallResult<IMessage>> TransferToPantryInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A2F")]
			[Cpp2IlInjected.Address(RVA = "0x58C9E0", Offset = "0x58B3E0", VA = "0x18058C9E0")]
			[AsyncStateMachine(typeof(_003CTransferToPantryAsyncStub_003Ed__329))]
			public Task<IMessage> TransferToPantryAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A30")]
			[Cpp2IlInjected.Address(RVA = "0x58CB40", Offset = "0x58B540", VA = "0x18058CB40", Slot = "117")]
			public virtual Task<TransferToPantry.Types.Response> TransferToPantryAsync(TransferToPantry.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: TransferToPantryAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A31")]
			[Cpp2IlInjected.Address(RVA = "0x576230", Offset = "0x574C30", VA = "0x180576230")]
			[AsyncStateMachine(typeof(_003CCookWithIngredientsInvokerAsync_003Ed__331))]
			public Task<CallResult<IMessage>> CookWithIngredientsInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A32")]
			[Cpp2IlInjected.Address(RVA = "0x576080", Offset = "0x574A80", VA = "0x180576080")]
			[AsyncStateMachine(typeof(_003CCookWithIngredientsAsyncStub_003Ed__332))]
			public Task<IMessage> CookWithIngredientsAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A33")]
			[Cpp2IlInjected.Address(RVA = "0x5761E0", Offset = "0x574BE0", VA = "0x1805761E0", Slot = "118")]
			public virtual Task<CookWithIngredients.Types.Response> CookWithIngredientsAsync(CookWithIngredients.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: CookWithIngredientsAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A34")]
			[Cpp2IlInjected.Address(RVA = "0x57D070", Offset = "0x57BA70", VA = "0x18057D070")]
			[AsyncStateMachine(typeof(_003CEatItemInvokerAsync_003Ed__334))]
			public Task<CallResult<IMessage>> EatItemInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A35")]
			[Cpp2IlInjected.Address(RVA = "0x57CEC0", Offset = "0x57B8C0", VA = "0x18057CEC0")]
			[AsyncStateMachine(typeof(_003CEatItemAsyncStub_003Ed__335))]
			public Task<IMessage> EatItemAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A36")]
			[Cpp2IlInjected.Address(RVA = "0x57D020", Offset = "0x57BA20", VA = "0x18057D020", Slot = "119")]
			public virtual Task<EatItem.Types.Response> EatItemAsync(EatItem.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: EatItemAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A37")]
			[Cpp2IlInjected.Address(RVA = "0x58ED40", Offset = "0x58D740", VA = "0x18058ED40")]
			[AsyncStateMachine(typeof(_003CUpdateRestaurantOrdersInvokerAsync_003Ed__337))]
			public Task<CallResult<IMessage>> UpdateRestaurantOrdersInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A38")]
			[Cpp2IlInjected.Address(RVA = "0x58EB90", Offset = "0x58D590", VA = "0x18058EB90")]
			[AsyncStateMachine(typeof(_003CUpdateRestaurantOrdersAsyncStub_003Ed__338))]
			public Task<IMessage> UpdateRestaurantOrdersAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A39")]
			[Cpp2IlInjected.Address(RVA = "0x58ECF0", Offset = "0x58D6F0", VA = "0x18058ECF0", Slot = "120")]
			public virtual Task<UpdateRestaurantOrders.Types.Response> UpdateRestaurantOrdersAsync(UpdateRestaurantOrders.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: UpdateRestaurantOrdersAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A3A")]
			[Cpp2IlInjected.Address(RVA = "0x57F220", Offset = "0x57DC20", VA = "0x18057F220")]
			[AsyncStateMachine(typeof(_003CFulfillRestaurantOrdersInvokerAsync_003Ed__340))]
			public Task<CallResult<IMessage>> FulfillRestaurantOrdersInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A3B")]
			[Cpp2IlInjected.Address(RVA = "0x57F070", Offset = "0x57DA70", VA = "0x18057F070")]
			[AsyncStateMachine(typeof(_003CFulfillRestaurantOrdersAsyncStub_003Ed__341))]
			public Task<IMessage> FulfillRestaurantOrdersAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A3C")]
			[Cpp2IlInjected.Address(RVA = "0x57F1D0", Offset = "0x57DBD0", VA = "0x18057F1D0", Slot = "121")]
			public virtual Task<FulfillRestaurantOrders.Types.Response> FulfillRestaurantOrdersAsync(FulfillRestaurantOrders.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: FulfillRestaurantOrdersAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A3D")]
			[Cpp2IlInjected.Address(RVA = "0x580170", Offset = "0x57EB70", VA = "0x180580170")]
			[AsyncStateMachine(typeof(_003CHitMiningRockInvokerAsync_003Ed__343))]
			public Task<CallResult<IMessage>> HitMiningRockInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A3E")]
			[Cpp2IlInjected.Address(RVA = "0x57FFC0", Offset = "0x57E9C0", VA = "0x18057FFC0")]
			[AsyncStateMachine(typeof(_003CHitMiningRockAsyncStub_003Ed__344))]
			public Task<IMessage> HitMiningRockAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A3F")]
			[Cpp2IlInjected.Address(RVA = "0x580120", Offset = "0x57EB20", VA = "0x180580120", Slot = "122")]
			public virtual Task<HitMiningRock.Types.Response> HitMiningRockAsync(HitMiningRock.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: HitMiningRockAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A40")]
			[Cpp2IlInjected.Address(RVA = "0x576540", Offset = "0x574F40", VA = "0x180576540")]
			[AsyncStateMachine(typeof(_003CCraftWithRecipeInvokerAsync_003Ed__346))]
			public Task<CallResult<IMessage>> CraftWithRecipeInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A41")]
			[Cpp2IlInjected.Address(RVA = "0x576390", Offset = "0x574D90", VA = "0x180576390")]
			[AsyncStateMachine(typeof(_003CCraftWithRecipeAsyncStub_003Ed__347))]
			public Task<IMessage> CraftWithRecipeAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A42")]
			[Cpp2IlInjected.Address(RVA = "0x5764F0", Offset = "0x574EF0", VA = "0x1805764F0", Slot = "123")]
			public virtual Task<CraftWithRecipe.Types.Response> CraftWithRecipeAsync(CraftWithRecipe.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: CraftWithRecipeAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A43")]
			[Cpp2IlInjected.Address(RVA = "0x5872C0", Offset = "0x585CC0", VA = "0x1805872C0")]
			[AsyncStateMachine(typeof(_003CSetCraftingRecipeAsSeenInvokerAsync_003Ed__349))]
			public Task<CallResult<IMessage>> SetCraftingRecipeAsSeenInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A44")]
			[Cpp2IlInjected.Address(RVA = "0x587110", Offset = "0x585B10", VA = "0x180587110")]
			[AsyncStateMachine(typeof(_003CSetCraftingRecipeAsSeenAsyncStub_003Ed__350))]
			public Task<IMessage> SetCraftingRecipeAsSeenAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A45")]
			[Cpp2IlInjected.Address(RVA = "0x587270", Offset = "0x585C70", VA = "0x180587270", Slot = "124")]
			public virtual Task<SetCraftingRecipeAsSeen.Types.Response> SetCraftingRecipeAsSeenAsync(SetCraftingRecipeAsSeen.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SetCraftingRecipeAsSeenAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A46")]
			[Cpp2IlInjected.Address(RVA = "0x57EC00", Offset = "0x57D600", VA = "0x18057EC00")]
			[AsyncStateMachine(typeof(_003CFeedCritterInvokerAsync_003Ed__352))]
			public Task<CallResult<IMessage>> FeedCritterInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A47")]
			[Cpp2IlInjected.Address(RVA = "0x57EA50", Offset = "0x57D450", VA = "0x18057EA50")]
			[AsyncStateMachine(typeof(_003CFeedCritterAsyncStub_003Ed__353))]
			public Task<IMessage> FeedCritterAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A48")]
			[Cpp2IlInjected.Address(RVA = "0x57EBB0", Offset = "0x57D5B0", VA = "0x18057EBB0", Slot = "125")]
			public virtual Task<FeedCritter.Types.Response> FeedCritterAsync(FeedCritter.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: FeedCritterAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A49")]
			[Cpp2IlInjected.Address(RVA = "0x581D00", Offset = "0x580700", VA = "0x180581D00")]
			[AsyncStateMachine(typeof(_003CPetCompanionInvokerAsync_003Ed__355))]
			public Task<CallResult<IMessage>> PetCompanionInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A4A")]
			[Cpp2IlInjected.Address(RVA = "0x581B50", Offset = "0x580550", VA = "0x180581B50")]
			[AsyncStateMachine(typeof(_003CPetCompanionAsyncStub_003Ed__356))]
			public Task<IMessage> PetCompanionAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A4B")]
			[Cpp2IlInjected.Address(RVA = "0x581CB0", Offset = "0x5806B0", VA = "0x180581CB0", Slot = "126")]
			public virtual Task<PetCompanion.Types.Response> PetCompanionAsync(PetCompanion.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: PetCompanionAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A4C")]
			[Cpp2IlInjected.Address(RVA = "0x576B60", Offset = "0x575560", VA = "0x180576B60")]
			[AsyncStateMachine(typeof(_003CDebugAddCurrencyInvokerAsync_003Ed__358))]
			public Task<CallResult<IMessage>> DebugAddCurrencyInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A4D")]
			[Cpp2IlInjected.Address(RVA = "0x5769B0", Offset = "0x5753B0", VA = "0x1805769B0")]
			[AsyncStateMachine(typeof(_003CDebugAddCurrencyAsyncStub_003Ed__359))]
			public Task<IMessage> DebugAddCurrencyAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A4E")]
			[Cpp2IlInjected.Address(RVA = "0x576B10", Offset = "0x575510", VA = "0x180576B10", Slot = "127")]
			public virtual Task<DebugAddCurrency.Types.Response> DebugAddCurrencyAsync(DebugAddCurrency.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugAddCurrencyAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A4F")]
			[Cpp2IlInjected.Address(RVA = "0x57E5E0", Offset = "0x57CFE0", VA = "0x18057E5E0")]
			[AsyncStateMachine(typeof(_003CExecuteRecurringEventInvokerAsync_003Ed__361))]
			public Task<CallResult<IMessage>> ExecuteRecurringEventInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A50")]
			[Cpp2IlInjected.Address(RVA = "0x57E430", Offset = "0x57CE30", VA = "0x18057E430")]
			[AsyncStateMachine(typeof(_003CExecuteRecurringEventAsyncStub_003Ed__362))]
			public Task<IMessage> ExecuteRecurringEventAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A51")]
			[Cpp2IlInjected.Address(RVA = "0x57E590", Offset = "0x57CF90", VA = "0x18057E590", Slot = "128")]
			public virtual Task<ExecuteRecurringEvent.Types.Response> ExecuteRecurringEventAsync(ExecuteRecurringEvent.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ExecuteRecurringEventAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A52")]
			[Cpp2IlInjected.Address(RVA = "0x57DFC0", Offset = "0x57C9C0", VA = "0x18057DFC0")]
			[AsyncStateMachine(typeof(_003CExecuteCampaignEventInvokerAsync_003Ed__364))]
			public Task<CallResult<IMessage>> ExecuteCampaignEventInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A53")]
			[Cpp2IlInjected.Address(RVA = "0x57DE10", Offset = "0x57C810", VA = "0x18057DE10")]
			[AsyncStateMachine(typeof(_003CExecuteCampaignEventAsyncStub_003Ed__365))]
			public Task<IMessage> ExecuteCampaignEventAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A54")]
			[Cpp2IlInjected.Address(RVA = "0x57DF70", Offset = "0x57C970", VA = "0x18057DF70", Slot = "129")]
			public virtual Task<ExecuteCampaignEvent.Types.Response> ExecuteCampaignEventAsync(ExecuteCampaignEvent.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ExecuteCampaignEventAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A55")]
			[Cpp2IlInjected.Address(RVA = "0x588E50", Offset = "0x587850", VA = "0x180588E50")]
			[AsyncStateMachine(typeof(_003CShopRefreshInvokerAsync_003Ed__367))]
			public Task<CallResult<IMessage>> ShopRefreshInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A56")]
			[Cpp2IlInjected.Address(RVA = "0x588CA0", Offset = "0x5876A0", VA = "0x180588CA0")]
			[AsyncStateMachine(typeof(_003CShopRefreshAsyncStub_003Ed__368))]
			public Task<IMessage> ShopRefreshAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A57")]
			[Cpp2IlInjected.Address(RVA = "0x588E00", Offset = "0x587800", VA = "0x180588E00", Slot = "130")]
			public virtual Task<ShopRefresh.Types.Response> ShopRefreshAsync(ShopRefresh.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ShopRefreshAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A58")]
			[Cpp2IlInjected.Address(RVA = "0x588B40", Offset = "0x587540", VA = "0x180588B40")]
			[AsyncStateMachine(typeof(_003CShopBuyItemInvokerAsync_003Ed__370))]
			public Task<CallResult<IMessage>> ShopBuyItemInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A59")]
			[Cpp2IlInjected.Address(RVA = "0x588990", Offset = "0x587390", VA = "0x180588990")]
			[AsyncStateMachine(typeof(_003CShopBuyItemAsyncStub_003Ed__371))]
			public Task<IMessage> ShopBuyItemAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A5A")]
			[Cpp2IlInjected.Address(RVA = "0x588AF0", Offset = "0x5874F0", VA = "0x180588AF0", Slot = "131")]
			public virtual Task<ShopBuyItem.Types.Response> ShopBuyItemAsync(ShopBuyItem.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ShopBuyItemAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A5B")]
			[Cpp2IlInjected.Address(RVA = "0x589160", Offset = "0x587B60", VA = "0x180589160")]
			[AsyncStateMachine(typeof(_003CShopSellItemsInvokerAsync_003Ed__373))]
			public Task<CallResult<IMessage>> ShopSellItemsInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A5C")]
			[Cpp2IlInjected.Address(RVA = "0x588FB0", Offset = "0x5879B0", VA = "0x180588FB0")]
			[AsyncStateMachine(typeof(_003CShopSellItemsAsyncStub_003Ed__374))]
			public Task<IMessage> ShopSellItemsAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A5D")]
			[Cpp2IlInjected.Address(RVA = "0x589110", Offset = "0x587B10", VA = "0x180589110", Slot = "132")]
			public virtual Task<ShopSellItems.Types.Response> ShopSellItemsAsync(ShopSellItems.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ShopSellItemsAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A5E")]
			[Cpp2IlInjected.Address(RVA = "0x58B930", Offset = "0x58A330", VA = "0x18058B930")]
			[AsyncStateMachine(typeof(_003CStoreRefreshInvokerAsync_003Ed__376))]
			public Task<CallResult<IMessage>> StoreRefreshInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A5F")]
			[Cpp2IlInjected.Address(RVA = "0x58B780", Offset = "0x58A180", VA = "0x18058B780")]
			[AsyncStateMachine(typeof(_003CStoreRefreshAsyncStub_003Ed__377))]
			public Task<IMessage> StoreRefreshAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A60")]
			[Cpp2IlInjected.Address(RVA = "0x58B8E0", Offset = "0x58A2E0", VA = "0x18058B8E0", Slot = "133")]
			public virtual Task<StoreRefresh.Types.Response> StoreRefreshAsync(StoreRefresh.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: StoreRefreshAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A61")]
			[Cpp2IlInjected.Address(RVA = "0x58B620", Offset = "0x58A020", VA = "0x18058B620")]
			[AsyncStateMachine(typeof(_003CStoreBuyItemInvokerAsync_003Ed__379))]
			public Task<CallResult<IMessage>> StoreBuyItemInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A62")]
			[Cpp2IlInjected.Address(RVA = "0x58B470", Offset = "0x589E70", VA = "0x18058B470")]
			[AsyncStateMachine(typeof(_003CStoreBuyItemAsyncStub_003Ed__380))]
			public Task<IMessage> StoreBuyItemAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A63")]
			[Cpp2IlInjected.Address(RVA = "0x58B5D0", Offset = "0x589FD0", VA = "0x18058B5D0", Slot = "134")]
			public virtual Task<StoreBuyItem.Types.Response> StoreBuyItemAsync(StoreBuyItem.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: StoreBuyItemAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A64")]
			[Cpp2IlInjected.Address(RVA = "0x57F530", Offset = "0x57DF30", VA = "0x18057F530")]
			[AsyncStateMachine(typeof(_003CGenericBuyItemInvokerAsync_003Ed__382))]
			public Task<CallResult<IMessage>> GenericBuyItemInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A65")]
			[Cpp2IlInjected.Address(RVA = "0x57F380", Offset = "0x57DD80", VA = "0x18057F380")]
			[AsyncStateMachine(typeof(_003CGenericBuyItemAsyncStub_003Ed__383))]
			public Task<IMessage> GenericBuyItemAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A66")]
			[Cpp2IlInjected.Address(RVA = "0x57F4E0", Offset = "0x57DEE0", VA = "0x18057F4E0", Slot = "135")]
			public virtual Task<GenericBuyItem.Types.Response> GenericBuyItemAsync(GenericBuyItem.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: GenericBuyItemAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A67")]
			[Cpp2IlInjected.Address(RVA = "0x57F840", Offset = "0x57E240", VA = "0x18057F840")]
			[AsyncStateMachine(typeof(_003CGenericSellItemsInvokerAsync_003Ed__385))]
			public Task<CallResult<IMessage>> GenericSellItemsInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A68")]
			[Cpp2IlInjected.Address(RVA = "0x57F690", Offset = "0x57E090", VA = "0x18057F690")]
			[AsyncStateMachine(typeof(_003CGenericSellItemsAsyncStub_003Ed__386))]
			public Task<IMessage> GenericSellItemsAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A69")]
			[Cpp2IlInjected.Address(RVA = "0x57F7F0", Offset = "0x57E1F0", VA = "0x18057F7F0", Slot = "136")]
			public virtual Task<GenericSellItems.Types.Response> GenericSellItemsAsync(GenericSellItems.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: GenericSellItemsAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A6A")]
			[Cpp2IlInjected.Address(RVA = "0x571ED0", Offset = "0x5708D0", VA = "0x180571ED0")]
			[AsyncStateMachine(typeof(_003CBuyDeliverySystemInvokerAsync_003Ed__388))]
			public Task<CallResult<IMessage>> BuyDeliverySystemInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A6B")]
			[Cpp2IlInjected.Address(RVA = "0x571D20", Offset = "0x570720", VA = "0x180571D20")]
			[AsyncStateMachine(typeof(_003CBuyDeliverySystemAsyncStub_003Ed__389))]
			public Task<IMessage> BuyDeliverySystemAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A6C")]
			[Cpp2IlInjected.Address(RVA = "0x571E80", Offset = "0x570880", VA = "0x180571E80", Slot = "137")]
			public virtual Task<BuyDeliverySystem.Types.Response> BuyDeliverySystemAsync(BuyDeliverySystem.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: BuyDeliverySystemAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A6D")]
			[Cpp2IlInjected.Address(RVA = "0x575F20", Offset = "0x574920", VA = "0x180575F20")]
			[AsyncStateMachine(typeof(_003CConvertToDreamDustInvokerAsync_003Ed__391))]
			public Task<CallResult<IMessage>> ConvertToDreamDustInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A6E")]
			[Cpp2IlInjected.Address(RVA = "0x575D70", Offset = "0x574770", VA = "0x180575D70")]
			[AsyncStateMachine(typeof(_003CConvertToDreamDustAsyncStub_003Ed__392))]
			public Task<IMessage> ConvertToDreamDustAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A6F")]
			[Cpp2IlInjected.Address(RVA = "0x575ED0", Offset = "0x5748D0", VA = "0x180575ED0", Slot = "138")]
			public virtual Task<ConvertToDreamDust.Types.Response> ConvertToDreamDustAsync(ConvertToDreamDust.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ConvertToDreamDustAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A70")]
			[Cpp2IlInjected.Address(RVA = "0x572800", Offset = "0x571200", VA = "0x180572800")]
			[AsyncStateMachine(typeof(_003CBuySoftCurrencyInvokerAsync_003Ed__394))]
			public Task<CallResult<IMessage>> BuySoftCurrencyInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A71")]
			[Cpp2IlInjected.Address(RVA = "0x572650", Offset = "0x571050", VA = "0x180572650")]
			[AsyncStateMachine(typeof(_003CBuySoftCurrencyAsyncStub_003Ed__395))]
			public Task<IMessage> BuySoftCurrencyAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A72")]
			[Cpp2IlInjected.Address(RVA = "0x5727B0", Offset = "0x5711B0", VA = "0x1805727B0", Slot = "139")]
			public virtual Task<BuySoftCurrency.Types.Response> BuySoftCurrencyAsync(BuySoftCurrency.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: BuySoftCurrencyAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A73")]
			[Cpp2IlInjected.Address(RVA = "0x58CEA0", Offset = "0x58B8A0", VA = "0x18058CEA0")]
			[AsyncStateMachine(typeof(_003CUnlockBuildingInvokerAsync_003Ed__397))]
			public Task<CallResult<IMessage>> UnlockBuildingInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A74")]
			[Cpp2IlInjected.Address(RVA = "0x58CCF0", Offset = "0x58B6F0", VA = "0x18058CCF0")]
			[AsyncStateMachine(typeof(_003CUnlockBuildingAsyncStub_003Ed__398))]
			public Task<IMessage> UnlockBuildingAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A75")]
			[Cpp2IlInjected.Address(RVA = "0x58CE50", Offset = "0x58B850", VA = "0x18058CE50", Slot = "140")]
			public virtual Task<UnlockBuilding.Types.Response> UnlockBuildingAsync(UnlockBuilding.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: UnlockBuildingAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A76")]
			[Cpp2IlInjected.Address(RVA = "0x58F670", Offset = "0x58E070", VA = "0x18058F670")]
			[AsyncStateMachine(typeof(_003CUpgradeBuildingInvokerAsync_003Ed__400))]
			public Task<CallResult<IMessage>> UpgradeBuildingInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A77")]
			[Cpp2IlInjected.Address(RVA = "0x58F4C0", Offset = "0x58DEC0", VA = "0x18058F4C0")]
			[AsyncStateMachine(typeof(_003CUpgradeBuildingAsyncStub_003Ed__401))]
			public Task<IMessage> UpgradeBuildingAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A78")]
			[Cpp2IlInjected.Address(RVA = "0x58F620", Offset = "0x58E020", VA = "0x18058F620", Slot = "141")]
			public virtual Task<UpgradeBuilding.Types.Response> UpgradeBuildingAsync(UpgradeBuilding.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: UpgradeBuildingAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A79")]
			[Cpp2IlInjected.Address(RVA = "0x5724F0", Offset = "0x570EF0", VA = "0x1805724F0")]
			[AsyncStateMachine(typeof(_003CBuyOfflineInvokerAsync_003Ed__403))]
			public Task<CallResult<IMessage>> BuyOfflineInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A7A")]
			[Cpp2IlInjected.Address(RVA = "0x572340", Offset = "0x570D40", VA = "0x180572340")]
			[AsyncStateMachine(typeof(_003CBuyOfflineAsyncStub_003Ed__404))]
			public Task<IMessage> BuyOfflineAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A7B")]
			[Cpp2IlInjected.Address(RVA = "0x5724A0", Offset = "0x570EA0", VA = "0x1805724A0", Slot = "142")]
			public virtual Task<BuyOffline.Types.Response> BuyOfflineAsync(BuyOffline.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: BuyOfflineAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A7C")]
			[Cpp2IlInjected.Address(RVA = "0x573A60", Offset = "0x572460", VA = "0x180573A60")]
			[AsyncStateMachine(typeof(_003CCheckWeatherChangeInvokerAsync_003Ed__406))]
			public Task<CallResult<IMessage>> CheckWeatherChangeInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A7D")]
			[Cpp2IlInjected.Address(RVA = "0x5738B0", Offset = "0x5722B0", VA = "0x1805738B0")]
			[AsyncStateMachine(typeof(_003CCheckWeatherChangeAsyncStub_003Ed__407))]
			public Task<IMessage> CheckWeatherChangeAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A7E")]
			[Cpp2IlInjected.Address(RVA = "0x573A10", Offset = "0x572410", VA = "0x180573A10", Slot = "143")]
			public virtual Task<CheckWeatherChange.Types.Response> CheckWeatherChangeAsync(CheckWeatherChange.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: CheckWeatherChangeAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A7F")]
			[Cpp2IlInjected.Address(RVA = "0x58A0B0", Offset = "0x588AB0", VA = "0x18058A0B0")]
			[AsyncStateMachine(typeof(_003CStartFtueEventInvokerAsync_003Ed__409))]
			public Task<CallResult<IMessage>> StartFtueEventInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A80")]
			[Cpp2IlInjected.Address(RVA = "0x589F00", Offset = "0x588900", VA = "0x180589F00")]
			[AsyncStateMachine(typeof(_003CStartFtueEventAsyncStub_003Ed__410))]
			public Task<IMessage> StartFtueEventAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A81")]
			[Cpp2IlInjected.Address(RVA = "0x58A060", Offset = "0x588A60", VA = "0x18058A060", Slot = "144")]
			public virtual Task<StartFtueEvent.Types.Response> StartFtueEventAsync(StartFtueEvent.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: StartFtueEventAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A82")]
			[Cpp2IlInjected.Address(RVA = "0x57D690", Offset = "0x57C090", VA = "0x18057D690")]
			[AsyncStateMachine(typeof(_003CEndFtueEventInvokerAsync_003Ed__412))]
			public Task<CallResult<IMessage>> EndFtueEventInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A83")]
			[Cpp2IlInjected.Address(RVA = "0x57D4E0", Offset = "0x57BEE0", VA = "0x18057D4E0")]
			[AsyncStateMachine(typeof(_003CEndFtueEventAsyncStub_003Ed__413))]
			public Task<IMessage> EndFtueEventAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A84")]
			[Cpp2IlInjected.Address(RVA = "0x57D640", Offset = "0x57C040", VA = "0x18057D640", Slot = "145")]
			public virtual Task<EndFtueEvent.Types.Response> EndFtueEventAsync(EndFtueEvent.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: EndFtueEventAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A85")]
			[Cpp2IlInjected.Address(RVA = "0x579F70", Offset = "0x578970", VA = "0x180579F70")]
			[AsyncStateMachine(typeof(_003CDebugResetFtueEventInvokerAsync_003Ed__415))]
			public Task<CallResult<IMessage>> DebugResetFtueEventInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A86")]
			[Cpp2IlInjected.Address(RVA = "0x579DC0", Offset = "0x5787C0", VA = "0x180579DC0")]
			[AsyncStateMachine(typeof(_003CDebugResetFtueEventAsyncStub_003Ed__416))]
			public Task<IMessage> DebugResetFtueEventAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A87")]
			[Cpp2IlInjected.Address(RVA = "0x579F20", Offset = "0x578920", VA = "0x180579F20", Slot = "146")]
			public virtual Task<DebugResetFtueEvent.Types.Response> DebugResetFtueEventAsync(DebugResetFtueEvent.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugResetFtueEventAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A88")]
			[Cpp2IlInjected.Address(RVA = "0x587F00", Offset = "0x586900", VA = "0x180587F00")]
			[AsyncStateMachine(typeof(_003CSetHudApparitionInvokerAsync_003Ed__418))]
			public Task<CallResult<IMessage>> SetHudApparitionInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A89")]
			[Cpp2IlInjected.Address(RVA = "0x587D50", Offset = "0x586750", VA = "0x180587D50")]
			[AsyncStateMachine(typeof(_003CSetHudApparitionAsyncStub_003Ed__419))]
			public Task<IMessage> SetHudApparitionAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A8A")]
			[Cpp2IlInjected.Address(RVA = "0x587EB0", Offset = "0x5868B0", VA = "0x180587EB0", Slot = "147")]
			public virtual Task<SetHudApparition.Types.Response> SetHudApparitionAsync(SetHudApparition.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SetHudApparitionAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A8B")]
			[Cpp2IlInjected.Address(RVA = "0x57E8F0", Offset = "0x57D2F0", VA = "0x18057E8F0")]
			[AsyncStateMachine(typeof(_003CExpandPlayerHouseRoomInvokerAsync_003Ed__421))]
			public Task<CallResult<IMessage>> ExpandPlayerHouseRoomInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A8C")]
			[Cpp2IlInjected.Address(RVA = "0x57E740", Offset = "0x57D140", VA = "0x18057E740")]
			[AsyncStateMachine(typeof(_003CExpandPlayerHouseRoomAsyncStub_003Ed__422))]
			public Task<IMessage> ExpandPlayerHouseRoomAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A8D")]
			[Cpp2IlInjected.Address(RVA = "0x57E8A0", Offset = "0x57D2A0", VA = "0x18057E8A0", Slot = "148")]
			public virtual Task<ExpandPlayerHouseRoom.Types.Response> ExpandPlayerHouseRoomAsync(ExpandPlayerHouseRoom.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ExpandPlayerHouseRoomAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A8E")]
			[Cpp2IlInjected.Address(RVA = "0x580DB0", Offset = "0x57F7B0", VA = "0x180580DB0")]
			[AsyncStateMachine(typeof(_003CManagePlayerHouseRoomInvokerAsync_003Ed__424))]
			public Task<CallResult<IMessage>> ManagePlayerHouseRoomInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A8F")]
			[Cpp2IlInjected.Address(RVA = "0x580C00", Offset = "0x57F600", VA = "0x180580C00")]
			[AsyncStateMachine(typeof(_003CManagePlayerHouseRoomAsyncStub_003Ed__425))]
			public Task<IMessage> ManagePlayerHouseRoomAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A90")]
			[Cpp2IlInjected.Address(RVA = "0x580D60", Offset = "0x57F760", VA = "0x180580D60", Slot = "149")]
			public virtual Task<ManagePlayerHouseRoom.Types.Response> ManagePlayerHouseRoomAsync(ManagePlayerHouseRoom.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ManagePlayerHouseRoomAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A91")]
			[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F980", VA = "0x180570F80")]
			[AsyncStateMachine(typeof(_003CAddPlayerHouseFloorInvokerAsync_003Ed__427))]
			public Task<CallResult<IMessage>> AddPlayerHouseFloorInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A92")]
			[Cpp2IlInjected.Address(RVA = "0x570DD0", Offset = "0x56F7D0", VA = "0x180570DD0")]
			[AsyncStateMachine(typeof(_003CAddPlayerHouseFloorAsyncStub_003Ed__428))]
			public Task<IMessage> AddPlayerHouseFloorAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A93")]
			[Cpp2IlInjected.Address(RVA = "0x570F30", Offset = "0x56F930", VA = "0x180570F30", Slot = "150")]
			public virtual Task<AddPlayerHouseFloor.Types.Response> AddPlayerHouseFloorAsync(AddPlayerHouseFloor.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: AddPlayerHouseFloorAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A94")]
			[Cpp2IlInjected.Address(RVA = "0x573440", Offset = "0x571E40", VA = "0x180573440")]
			[AsyncStateMachine(typeof(_003CChangePlayerHouseFlooringInvokerAsync_003Ed__430))]
			public Task<CallResult<IMessage>> ChangePlayerHouseFlooringInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A95")]
			[Cpp2IlInjected.Address(RVA = "0x573290", Offset = "0x571C90", VA = "0x180573290")]
			[AsyncStateMachine(typeof(_003CChangePlayerHouseFlooringAsyncStub_003Ed__431))]
			public Task<IMessage> ChangePlayerHouseFlooringAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A96")]
			[Cpp2IlInjected.Address(RVA = "0x5733F0", Offset = "0x571DF0", VA = "0x1805733F0", Slot = "151")]
			public virtual Task<ChangePlayerHouseFlooring.Types.Response> ChangePlayerHouseFlooringAsync(ChangePlayerHouseFlooring.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ChangePlayerHouseFlooringAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A97")]
			[Cpp2IlInjected.Address(RVA = "0x573750", Offset = "0x572150", VA = "0x180573750")]
			[AsyncStateMachine(typeof(_003CChangePlayerHouseWallpaperInvokerAsync_003Ed__433))]
			public Task<CallResult<IMessage>> ChangePlayerHouseWallpaperInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A98")]
			[Cpp2IlInjected.Address(RVA = "0x5735A0", Offset = "0x571FA0", VA = "0x1805735A0")]
			[AsyncStateMachine(typeof(_003CChangePlayerHouseWallpaperAsyncStub_003Ed__434))]
			public Task<IMessage> ChangePlayerHouseWallpaperAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A99")]
			[Cpp2IlInjected.Address(RVA = "0x573700", Offset = "0x572100", VA = "0x180573700", Slot = "152")]
			public virtual Task<ChangePlayerHouseWallpaper.Types.Response> ChangePlayerHouseWallpaperAsync(ChangePlayerHouseWallpaper.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ChangePlayerHouseWallpaperAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A9A")]
			[Cpp2IlInjected.Address(RVA = "0x572E20", Offset = "0x571820", VA = "0x180572E20")]
			[AsyncStateMachine(typeof(_003CChangeCurrentPetInvokerAsync_003Ed__436))]
			public Task<CallResult<IMessage>> ChangeCurrentPetInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A9B")]
			[Cpp2IlInjected.Address(RVA = "0x572C70", Offset = "0x571670", VA = "0x180572C70")]
			[AsyncStateMachine(typeof(_003CChangeCurrentPetAsyncStub_003Ed__437))]
			public Task<IMessage> ChangeCurrentPetAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A9C")]
			[Cpp2IlInjected.Address(RVA = "0x572DD0", Offset = "0x5717D0", VA = "0x180572DD0", Slot = "153")]
			public virtual Task<ChangeCurrentPet.Types.Response> ChangeCurrentPetAsync(ChangeCurrentPet.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ChangeCurrentPetAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A9D")]
			[Cpp2IlInjected.Address(RVA = "0x58ACF0", Offset = "0x5896F0", VA = "0x18058ACF0")]
			[AsyncStateMachine(typeof(_003CStartPendingBurningStateInvokerAsync_003Ed__439))]
			public Task<CallResult<IMessage>> StartPendingBurningStateInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A9E")]
			[Cpp2IlInjected.Address(RVA = "0x58AB40", Offset = "0x589540", VA = "0x18058AB40")]
			[AsyncStateMachine(typeof(_003CStartPendingBurningStateAsyncStub_003Ed__440))]
			public Task<IMessage> StartPendingBurningStateAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003A9F")]
			[Cpp2IlInjected.Address(RVA = "0x58ACA0", Offset = "0x5896A0", VA = "0x18058ACA0", Slot = "154")]
			public virtual Task<StartPendingBurningState.Types.Response> StartPendingBurningStateAsync(StartPendingBurningState.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: StartPendingBurningStateAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AA0")]
			[Cpp2IlInjected.Address(RVA = "0x5746A0", Offset = "0x5730A0", VA = "0x1805746A0")]
			[AsyncStateMachine(typeof(_003CCollectBurningStateInvokerAsync_003Ed__442))]
			public Task<CallResult<IMessage>> CollectBurningStateInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AA1")]
			[Cpp2IlInjected.Address(RVA = "0x5744F0", Offset = "0x572EF0", VA = "0x1805744F0")]
			[AsyncStateMachine(typeof(_003CCollectBurningStateAsyncStub_003Ed__443))]
			public Task<IMessage> CollectBurningStateAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AA2")]
			[Cpp2IlInjected.Address(RVA = "0x574650", Offset = "0x573050", VA = "0x180574650", Slot = "155")]
			public virtual Task<CollectBurningState.Types.Response> CollectBurningStateAsync(CollectBurningState.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: CollectBurningStateAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AA3")]
			[Cpp2IlInjected.Address(RVA = "0x574080", Offset = "0x572A80", VA = "0x180574080")]
			[AsyncStateMachine(typeof(_003CClearBurningStateInvokerAsync_003Ed__445))]
			public Task<CallResult<IMessage>> ClearBurningStateInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AA4")]
			[Cpp2IlInjected.Address(RVA = "0x573ED0", Offset = "0x5728D0", VA = "0x180573ED0")]
			[AsyncStateMachine(typeof(_003CClearBurningStateAsyncStub_003Ed__446))]
			public Task<IMessage> ClearBurningStateAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AA5")]
			[Cpp2IlInjected.Address(RVA = "0x574030", Offset = "0x572A30", VA = "0x180574030", Slot = "156")]
			public virtual Task<ClearBurningState.Types.Response> ClearBurningStateAsync(ClearBurningState.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ClearBurningStateAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AA6")]
			[Cpp2IlInjected.Address(RVA = "0x583BA0", Offset = "0x5825A0", VA = "0x180583BA0")]
			[AsyncStateMachine(typeof(_003CPullWeedInvokerAsync_003Ed__448))]
			public Task<CallResult<IMessage>> PullWeedInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AA7")]
			[Cpp2IlInjected.Address(RVA = "0x5839F0", Offset = "0x5823F0", VA = "0x1805839F0")]
			[AsyncStateMachine(typeof(_003CPullWeedAsyncStub_003Ed__449))]
			public Task<IMessage> PullWeedAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AA8")]
			[Cpp2IlInjected.Address(RVA = "0x583B50", Offset = "0x582550", VA = "0x180583B50", Slot = "157")]
			public virtual Task<PullWeed.Types.Response> PullWeedAsync(PullWeed.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: PullWeedAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AA9")]
			[Cpp2IlInjected.Address(RVA = "0x58A6D0", Offset = "0x5890D0", VA = "0x18058A6D0")]
			[AsyncStateMachine(typeof(_003CStartItemCollectMinigameInvokerAsync_003Ed__451))]
			public Task<CallResult<IMessage>> StartItemCollectMinigameInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AAA")]
			[Cpp2IlInjected.Address(RVA = "0x58A520", Offset = "0x588F20", VA = "0x18058A520")]
			[AsyncStateMachine(typeof(_003CStartItemCollectMinigameAsyncStub_003Ed__452))]
			public Task<IMessage> StartItemCollectMinigameAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AAB")]
			[Cpp2IlInjected.Address(RVA = "0x58A680", Offset = "0x589080", VA = "0x18058A680", Slot = "158")]
			public virtual Task<StartItemCollectMinigame.Types.Response> StartItemCollectMinigameAsync(StartItemCollectMinigame.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: StartItemCollectMinigameAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AAC")]
			[Cpp2IlInjected.Address(RVA = "0x5755F0", Offset = "0x573FF0", VA = "0x1805755F0")]
			[AsyncStateMachine(typeof(_003CCollectMinigameItemInvokerAsync_003Ed__454))]
			public Task<CallResult<IMessage>> CollectMinigameItemInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AAD")]
			[Cpp2IlInjected.Address(RVA = "0x575440", Offset = "0x573E40", VA = "0x180575440")]
			[AsyncStateMachine(typeof(_003CCollectMinigameItemAsyncStub_003Ed__455))]
			public Task<IMessage> CollectMinigameItemAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AAE")]
			[Cpp2IlInjected.Address(RVA = "0x5755A0", Offset = "0x573FA0", VA = "0x1805755A0", Slot = "159")]
			public virtual Task<CollectMinigameItem.Types.Response> CollectMinigameItemAsync(CollectMinigameItem.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: CollectMinigameItemAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AAF")]
			[Cpp2IlInjected.Address(RVA = "0x58B310", Offset = "0x589D10", VA = "0x18058B310")]
			[AsyncStateMachine(typeof(_003CStopItemCollectMinigameInvokerAsync_003Ed__457))]
			public Task<CallResult<IMessage>> StopItemCollectMinigameInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AB0")]
			[Cpp2IlInjected.Address(RVA = "0x58B160", Offset = "0x589B60", VA = "0x18058B160")]
			[AsyncStateMachine(typeof(_003CStopItemCollectMinigameAsyncStub_003Ed__458))]
			public Task<IMessage> StopItemCollectMinigameAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AB1")]
			[Cpp2IlInjected.Address(RVA = "0x58B2C0", Offset = "0x589CC0", VA = "0x18058B2C0", Slot = "160")]
			public virtual Task<StopItemCollectMinigame.Types.Response> StopItemCollectMinigameAsync(StopItemCollectMinigame.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: StopItemCollectMinigameAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AB2")]
			[Cpp2IlInjected.Address(RVA = "0x58F050", Offset = "0x58DA50", VA = "0x18058F050")]
			[AsyncStateMachine(typeof(_003CUpdateRoyalDutySlotsInvokerAsync_003Ed__460))]
			public Task<CallResult<IMessage>> UpdateRoyalDutySlotsInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AB3")]
			[Cpp2IlInjected.Address(RVA = "0x58EEA0", Offset = "0x58D8A0", VA = "0x18058EEA0")]
			[AsyncStateMachine(typeof(_003CUpdateRoyalDutySlotsAsyncStub_003Ed__461))]
			public Task<IMessage> UpdateRoyalDutySlotsAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AB4")]
			[Cpp2IlInjected.Address(RVA = "0x58F000", Offset = "0x58DA00", VA = "0x18058F000", Slot = "161")]
			public virtual Task<UpdateRoyalDutySlots.Types.Response> UpdateRoyalDutySlotsAsync(UpdateRoyalDutySlots.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: UpdateRoyalDutySlotsAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AB5")]
			[Cpp2IlInjected.Address(RVA = "0x575900", Offset = "0x574300", VA = "0x180575900")]
			[AsyncStateMachine(typeof(_003CCollectRoyalDutyRewardInvokerAsync_003Ed__463))]
			public Task<CallResult<IMessage>> CollectRoyalDutyRewardInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AB6")]
			[Cpp2IlInjected.Address(RVA = "0x575750", Offset = "0x574150", VA = "0x180575750")]
			[AsyncStateMachine(typeof(_003CCollectRoyalDutyRewardAsyncStub_003Ed__464))]
			public Task<IMessage> CollectRoyalDutyRewardAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AB7")]
			[Cpp2IlInjected.Address(RVA = "0x5758B0", Offset = "0x5742B0", VA = "0x1805758B0", Slot = "162")]
			public virtual Task<CollectRoyalDutyReward.Types.Response> CollectRoyalDutyRewardAsync(CollectRoyalDutyReward.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: CollectRoyalDutyRewardAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AB8")]
			[Cpp2IlInjected.Address(RVA = "0x579330", Offset = "0x577D30", VA = "0x180579330")]
			[AsyncStateMachine(typeof(_003CDebugGenerateNewRoyalDutiesInvokerAsync_003Ed__466))]
			public Task<CallResult<IMessage>> DebugGenerateNewRoyalDutiesInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AB9")]
			[Cpp2IlInjected.Address(RVA = "0x579180", Offset = "0x577B80", VA = "0x180579180")]
			[AsyncStateMachine(typeof(_003CDebugGenerateNewRoyalDutiesAsyncStub_003Ed__467))]
			public Task<IMessage> DebugGenerateNewRoyalDutiesAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ABA")]
			[Cpp2IlInjected.Address(RVA = "0x5792E0", Offset = "0x577CE0", VA = "0x1805792E0", Slot = "163")]
			public virtual Task<DebugGenerateNewRoyalDuties.Types.Response> DebugGenerateNewRoyalDutiesAsync(DebugGenerateNewRoyalDuties.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugGenerateNewRoyalDutiesAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ABB")]
			[Cpp2IlInjected.Address(RVA = "0x574390", Offset = "0x572D90", VA = "0x180574390")]
			[AsyncStateMachine(typeof(_003CCollectAchievementRewardInvokerAsync_003Ed__469))]
			public Task<CallResult<IMessage>> CollectAchievementRewardInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ABC")]
			[Cpp2IlInjected.Address(RVA = "0x5741E0", Offset = "0x572BE0", VA = "0x1805741E0")]
			[AsyncStateMachine(typeof(_003CCollectAchievementRewardAsyncStub_003Ed__470))]
			public Task<IMessage> CollectAchievementRewardAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ABD")]
			[Cpp2IlInjected.Address(RVA = "0x574340", Offset = "0x572D40", VA = "0x180574340", Slot = "164")]
			public virtual Task<CollectAchievementReward.Types.Response> CollectAchievementRewardAsync(CollectAchievementReward.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: CollectAchievementRewardAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ABE")]
			[Cpp2IlInjected.Address(RVA = "0x577DC0", Offset = "0x5767C0", VA = "0x180577DC0")]
			[AsyncStateMachine(typeof(_003CDebugCompleteAchievementMilestoneInvokerAsync_003Ed__472))]
			public Task<CallResult<IMessage>> DebugCompleteAchievementMilestoneInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ABF")]
			[Cpp2IlInjected.Address(RVA = "0x577C10", Offset = "0x576610", VA = "0x180577C10")]
			[AsyncStateMachine(typeof(_003CDebugCompleteAchievementMilestoneAsyncStub_003Ed__473))]
			public Task<IMessage> DebugCompleteAchievementMilestoneAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AC0")]
			[Cpp2IlInjected.Address(RVA = "0x577D70", Offset = "0x576770", VA = "0x180577D70", Slot = "165")]
			public virtual Task<DebugCompleteAchievementMilestone.Types.Response> DebugCompleteAchievementMilestoneAsync(DebugCompleteAchievementMilestone.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugCompleteAchievementMilestoneAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AC1")]
			[Cpp2IlInjected.Address(RVA = "0x58F360", Offset = "0x58DD60", VA = "0x18058F360")]
			[AsyncStateMachine(typeof(_003CUpdateTimeAcumulatedInvokerAsync_003Ed__475))]
			public Task<CallResult<IMessage>> UpdateTimeAcumulatedInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AC2")]
			[Cpp2IlInjected.Address(RVA = "0x58F1B0", Offset = "0x58DBB0", VA = "0x18058F1B0")]
			[AsyncStateMachine(typeof(_003CUpdateTimeAcumulatedAsyncStub_003Ed__476))]
			public Task<IMessage> UpdateTimeAcumulatedAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AC3")]
			[Cpp2IlInjected.Address(RVA = "0x58F310", Offset = "0x58DD10", VA = "0x18058F310", Slot = "166")]
			public virtual Task<UpdateTimeAcumulated.Types.Response> UpdateTimeAcumulatedAsync(UpdateTimeAcumulated.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: UpdateTimeAcumulatedAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AC4")]
			[Cpp2IlInjected.Address(RVA = "0x58D4C0", Offset = "0x58BEC0", VA = "0x18058D4C0")]
			[AsyncStateMachine(typeof(_003CUnlockStorageInvokerAsync_003Ed__478))]
			public Task<CallResult<IMessage>> UnlockStorageInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AC5")]
			[Cpp2IlInjected.Address(RVA = "0x58D310", Offset = "0x58BD10", VA = "0x18058D310")]
			[AsyncStateMachine(typeof(_003CUnlockStorageAsyncStub_003Ed__479))]
			public Task<IMessage> UnlockStorageAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AC6")]
			[Cpp2IlInjected.Address(RVA = "0x58D470", Offset = "0x58BE70", VA = "0x18058D470", Slot = "167")]
			public virtual Task<UnlockStorage.Types.Response> UnlockStorageAsync(UnlockStorage.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: UnlockStorageAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AC7")]
			[Cpp2IlInjected.Address(RVA = "0x586990", Offset = "0x585390", VA = "0x180586990")]
			[AsyncStateMachine(typeof(_003CSendItemsToInboxInvokerAsync_003Ed__481))]
			public Task<CallResult<IMessage>> SendItemsToInboxInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AC8")]
			[Cpp2IlInjected.Address(RVA = "0x5867E0", Offset = "0x5851E0", VA = "0x1805867E0")]
			[AsyncStateMachine(typeof(_003CSendItemsToInboxAsyncStub_003Ed__482))]
			public Task<IMessage> SendItemsToInboxAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003AC9")]
			[Cpp2IlInjected.Address(RVA = "0x586940", Offset = "0x585340", VA = "0x180586940", Slot = "168")]
			public virtual Task<SendItemsToInbox.Types.Response> SendItemsToInboxAsync(SendItemsToInbox.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SendItemsToInboxAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ACA")]
			[Cpp2IlInjected.Address(RVA = "0x58DAE0", Offset = "0x58C4E0", VA = "0x18058DAE0")]
			[AsyncStateMachine(typeof(_003CUpdateBattlePassTasksProgressionInvokerAsync_003Ed__484))]
			public Task<CallResult<IMessage>> UpdateBattlePassTasksProgressionInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ACB")]
			[Cpp2IlInjected.Address(RVA = "0x58D930", Offset = "0x58C330", VA = "0x18058D930")]
			[AsyncStateMachine(typeof(_003CUpdateBattlePassTasksProgressionAsyncStub_003Ed__485))]
			public Task<IMessage> UpdateBattlePassTasksProgressionAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ACC")]
			[Cpp2IlInjected.Address(RVA = "0x58DA90", Offset = "0x58C490", VA = "0x18058DA90", Slot = "169")]
			public virtual Task<UpdateBattlePassTasksProgression.Types.Response> UpdateBattlePassTasksProgressionAsync(UpdateBattlePassTasksProgression.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: UpdateBattlePassTasksProgressionAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ACD")]
			[Cpp2IlInjected.Address(RVA = "0x58E720", Offset = "0x58D120", VA = "0x18058E720")]
			[AsyncStateMachine(typeof(_003CUpdateOnlineShopStatesInvokerAsync_003Ed__487))]
			public Task<CallResult<IMessage>> UpdateOnlineShopStatesInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ACE")]
			[Cpp2IlInjected.Address(RVA = "0x58E570", Offset = "0x58CF70", VA = "0x18058E570")]
			[AsyncStateMachine(typeof(_003CUpdateOnlineShopStatesAsyncStub_003Ed__488))]
			public Task<IMessage> UpdateOnlineShopStatesAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ACF")]
			[Cpp2IlInjected.Address(RVA = "0x58E6D0", Offset = "0x58D0D0", VA = "0x18058E6D0", Slot = "170")]
			public virtual Task<UpdateOnlineShopStates.Types.Response> UpdateOnlineShopStatesAsync(UpdateOnlineShopStates.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: UpdateOnlineShopStatesAsync");
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000733")]
		public class TransactionServiceClient : ClientBase
		{
			[Cpp2IlInjected.Token(Token = "0x6003E01")]
			[Cpp2IlInjected.Address(RVA = "0x784780", Offset = "0x783180", VA = "0x180784780")]
			public TransactionServiceClient(Gameloft.Rpc.Core.Client.ICallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6003E02")]
			[Cpp2IlInjected.Address(RVA = "0x777040", Offset = "0x775A40", VA = "0x180777040")]
			public Task<Ping.Types.Response> PingAsync(Ping.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<Ping.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E03")]
			[Cpp2IlInjected.Address(RVA = "0x776EC0", Offset = "0x7758C0", VA = "0x180776EC0")]
			[AsyncStateMachine(typeof(_003CPingAsync_003Ed__2))]
			public Task<Ping.Types.Response> PingAsync(Ping.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<Ping.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E04")]
			[Cpp2IlInjected.Address(RVA = "0x77A4F0", Offset = "0x778EF0", VA = "0x18077A4F0")]
			public Task<SaveProfile.Types.Response> SaveProfileAsync(SaveProfile.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SaveProfile.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E05")]
			[Cpp2IlInjected.Address(RVA = "0x77A6A0", Offset = "0x7790A0", VA = "0x18077A6A0")]
			[AsyncStateMachine(typeof(_003CSaveProfileAsync_003Ed__4))]
			public Task<SaveProfile.Types.Response> SaveProfileAsync(SaveProfile.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SaveProfile.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E06")]
			[Cpp2IlInjected.Address(RVA = "0x766AE0", Offset = "0x7654E0", VA = "0x180766AE0")]
			public Task<ChangeCurrentScene.Types.Response> ChangeCurrentSceneAsync(ChangeCurrentScene.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ChangeCurrentScene.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E07")]
			[Cpp2IlInjected.Address(RVA = "0x766960", Offset = "0x765360", VA = "0x180766960")]
			[AsyncStateMachine(typeof(_003CChangeCurrentSceneAsync_003Ed__6))]
			public Task<ChangeCurrentScene.Types.Response> ChangeCurrentSceneAsync(ChangeCurrentScene.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ChangeCurrentScene.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E08")]
			[Cpp2IlInjected.Address(RVA = "0x77C980", Offset = "0x77B380", VA = "0x18077C980")]
			public Task<SetManaHasAlreadyMissed.Types.Response> SetManaHasAlreadyMissedAsync(SetManaHasAlreadyMissed.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SetManaHasAlreadyMissed.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E09")]
			[Cpp2IlInjected.Address(RVA = "0x77C800", Offset = "0x77B200", VA = "0x18077C800")]
			[AsyncStateMachine(typeof(_003CSetManaHasAlreadyMissedAsync_003Ed__8))]
			public Task<SetManaHasAlreadyMissed.Types.Response> SetManaHasAlreadyMissedAsync(SetManaHasAlreadyMissed.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SetManaHasAlreadyMissed.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E0A")]
			[Cpp2IlInjected.Address(RVA = "0x771BE0", Offset = "0x7705E0", VA = "0x180771BE0")]
			public Task<EnterRealm.Types.Response> EnterRealmAsync(EnterRealm.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<EnterRealm.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E0B")]
			[Cpp2IlInjected.Address(RVA = "0x771D90", Offset = "0x770790", VA = "0x180771D90")]
			[AsyncStateMachine(typeof(_003CEnterRealmAsync_003Ed__10))]
			public Task<EnterRealm.Types.Response> EnterRealmAsync(EnterRealm.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<EnterRealm.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E0C")]
			[Cpp2IlInjected.Address(RVA = "0x781AE0", Offset = "0x7804E0", VA = "0x180781AE0")]
			public Task<UnlockRealm.Types.Response> UnlockRealmAsync(UnlockRealm.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<UnlockRealm.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E0D")]
			[Cpp2IlInjected.Address(RVA = "0x781C90", Offset = "0x780690", VA = "0x180781C90")]
			[AsyncStateMachine(typeof(_003CUnlockRealmAsync_003Ed__12))]
			public Task<UnlockRealm.Types.Response> UnlockRealmAsync(UnlockRealm.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<UnlockRealm.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E0E")]
			[Cpp2IlInjected.Address(RVA = "0x7779D0", Offset = "0x7763D0", VA = "0x1807779D0")]
			public Task<PlaceOnGrid.Types.Response> PlaceOnGridAsync(PlaceOnGrid.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<PlaceOnGrid.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E0F")]
			[Cpp2IlInjected.Address(RVA = "0x777850", Offset = "0x776250", VA = "0x180777850")]
			[AsyncStateMachine(typeof(_003CPlaceOnGridAsync_003Ed__14))]
			public Task<PlaceOnGrid.Types.Response> PlaceOnGridAsync(PlaceOnGrid.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PlaceOnGrid.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E10")]
			[Cpp2IlInjected.Address(RVA = "0x778CF0", Offset = "0x7776F0", VA = "0x180778CF0")]
			public Task<RemoveFromGrid.Types.Response> RemoveFromGridAsync(RemoveFromGrid.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<RemoveFromGrid.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E11")]
			[Cpp2IlInjected.Address(RVA = "0x778B70", Offset = "0x777570", VA = "0x180778B70")]
			[AsyncStateMachine(typeof(_003CRemoveFromGridAsync_003Ed__16))]
			public Task<RemoveFromGrid.Types.Response> RemoveFromGridAsync(RemoveFromGrid.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<RemoveFromGrid.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E12")]
			[Cpp2IlInjected.Address(RVA = "0x7789C0", Offset = "0x7773C0", VA = "0x1807789C0")]
			public Task<RemoveBlocker.Types.Response> RemoveBlockerAsync(RemoveBlocker.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<RemoveBlocker.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E13")]
			[Cpp2IlInjected.Address(RVA = "0x778840", Offset = "0x777240", VA = "0x180778840")]
			[AsyncStateMachine(typeof(_003CRemoveBlockerAsync_003Ed__18))]
			public Task<RemoveBlocker.Types.Response> RemoveBlockerAsync(RemoveBlocker.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<RemoveBlocker.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E14")]
			[Cpp2IlInjected.Address(RVA = "0x774D30", Offset = "0x773730", VA = "0x180774D30")]
			public Task<Login.Types.Response> LoginAsync(Login.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<Login.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E15")]
			[Cpp2IlInjected.Address(RVA = "0x774BB0", Offset = "0x7735B0", VA = "0x180774BB0")]
			[AsyncStateMachine(typeof(_003CLoginAsync_003Ed__20))]
			public Task<Login.Types.Response> LoginAsync(Login.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<Login.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E16")]
			[Cpp2IlInjected.Address(RVA = "0x764170", Offset = "0x762B70", VA = "0x180764170")]
			public Task<Actualize.Types.Response> ActualizeAsync(Actualize.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<Actualize.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E17")]
			[Cpp2IlInjected.Address(RVA = "0x763FF0", Offset = "0x7629F0", VA = "0x180763FF0")]
			[AsyncStateMachine(typeof(_003CActualizeAsync_003Ed__22))]
			public Task<Actualize.Types.Response> ActualizeAsync(Actualize.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<Actualize.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E18")]
			[Cpp2IlInjected.Address(RVA = "0x774A00", Offset = "0x773400", VA = "0x180774A00")]
			public Task<InitWithServerProfile.Types.Response> InitWithServerProfileAsync(InitWithServerProfile.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<InitWithServerProfile.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E19")]
			[Cpp2IlInjected.Address(RVA = "0x774880", Offset = "0x773280", VA = "0x180774880")]
			[AsyncStateMachine(typeof(_003CInitWithServerProfileAsync_003Ed__24))]
			public Task<InitWithServerProfile.Types.Response> InitWithServerProfileAsync(InitWithServerProfile.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<InitWithServerProfile.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E1A")]
			[Cpp2IlInjected.Address(RVA = "0x77CFE0", Offset = "0x77B9E0", VA = "0x18077CFE0")]
			public Task<SetName.Types.Response> SetNameAsync(SetName.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SetName.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E1B")]
			[Cpp2IlInjected.Address(RVA = "0x77CE60", Offset = "0x77B860", VA = "0x18077CE60")]
			[AsyncStateMachine(typeof(_003CSetNameAsync_003Ed__26))]
			public Task<SetName.Types.Response> SetNameAsync(SetName.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SetName.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E1C")]
			[Cpp2IlInjected.Address(RVA = "0x780FA0", Offset = "0x77F9A0", VA = "0x180780FA0")]
			public Task<TrackClaimedFoundersPack.Types.Response> TrackClaimedFoundersPackAsync(TrackClaimedFoundersPack.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<TrackClaimedFoundersPack.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E1D")]
			[Cpp2IlInjected.Address(RVA = "0x780E20", Offset = "0x77F820", VA = "0x180780E20")]
			[AsyncStateMachine(typeof(_003CTrackClaimedFoundersPackAsync_003Ed__28))]
			public Task<TrackClaimedFoundersPack.Types.Response> TrackClaimedFoundersPackAsync(TrackClaimedFoundersPack.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<TrackClaimedFoundersPack.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E1E")]
			[Cpp2IlInjected.Address(RVA = "0x776200", Offset = "0x774C00", VA = "0x180776200")]
			public Task<PickUpContainerItem.Types.Response> PickUpContainerItemAsync(PickUpContainerItem.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<PickUpContainerItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E1F")]
			[Cpp2IlInjected.Address(RVA = "0x7763B0", Offset = "0x774DB0", VA = "0x1807763B0")]
			[AsyncStateMachine(typeof(_003CPickUpContainerItemAsync_003Ed__30))]
			public Task<PickUpContainerItem.Types.Response> PickUpContainerItemAsync(PickUpContainerItem.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PickUpContainerItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E20")]
			[Cpp2IlInjected.Address(RVA = "0x778360", Offset = "0x776D60", VA = "0x180778360")]
			public Task<PutDownContainerItem.Types.Response> PutDownContainerItemAsync(PutDownContainerItem.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<PutDownContainerItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E21")]
			[Cpp2IlInjected.Address(RVA = "0x7781E0", Offset = "0x776BE0", VA = "0x1807781E0")]
			[AsyncStateMachine(typeof(_003CPutDownContainerItemAsync_003Ed__32))]
			public Task<PutDownContainerItem.Types.Response> PutDownContainerItemAsync(PutDownContainerItem.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PutDownContainerItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E22")]
			[Cpp2IlInjected.Address(RVA = "0x770D70", Offset = "0x76F770", VA = "0x180770D70")]
			public Task<DropContainerInventoryStack.Types.Response> DropContainerInventoryStackAsync(DropContainerInventoryStack.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DropContainerInventoryStack.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E23")]
			[Cpp2IlInjected.Address(RVA = "0x770BF0", Offset = "0x76F5F0", VA = "0x180770BF0")]
			[AsyncStateMachine(typeof(_003CDropContainerInventoryStackAsync_003Ed__34))]
			public Task<DropContainerInventoryStack.Types.Response> DropContainerInventoryStackAsync(DropContainerInventoryStack.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DropContainerInventoryStack.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E24")]
			[Cpp2IlInjected.Address(RVA = "0x776860", Offset = "0x775260", VA = "0x180776860")]
			public Task<PickUpListItem.Types.Response> PickUpListItemAsync(PickUpListItem.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<PickUpListItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E25")]
			[Cpp2IlInjected.Address(RVA = "0x776A10", Offset = "0x775410", VA = "0x180776A10")]
			[AsyncStateMachine(typeof(_003CPickUpListItemAsync_003Ed__36))]
			public Task<PickUpListItem.Types.Response> PickUpListItemAsync(PickUpListItem.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PickUpListItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E26")]
			[Cpp2IlInjected.Address(RVA = "0x778690", Offset = "0x777090", VA = "0x180778690")]
			public Task<PutDownListItem.Types.Response> PutDownListItemAsync(PutDownListItem.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<PutDownListItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E27")]
			[Cpp2IlInjected.Address(RVA = "0x778510", Offset = "0x776F10", VA = "0x180778510")]
			[AsyncStateMachine(typeof(_003CPutDownListItemAsync_003Ed__38))]
			public Task<PutDownListItem.Types.Response> PutDownListItemAsync(PutDownListItem.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PutDownListItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E28")]
			[Cpp2IlInjected.Address(RVA = "0x776530", Offset = "0x774F30", VA = "0x180776530")]
			public Task<PickUpItem.Types.Response> PickUpItemAsync(PickUpItem.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<PickUpItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E29")]
			[Cpp2IlInjected.Address(RVA = "0x7766E0", Offset = "0x7750E0", VA = "0x1807766E0")]
			[AsyncStateMachine(typeof(_003CPickUpItemAsync_003Ed__40))]
			public Task<PickUpItem.Types.Response> PickUpItemAsync(PickUpItem.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PickUpItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E2A")]
			[Cpp2IlInjected.Address(RVA = "0x777520", Offset = "0x775F20", VA = "0x180777520")]
			public Task<PlaceLandscapingItem.Types.Response> PlaceLandscapingItemAsync(PlaceLandscapingItem.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<PlaceLandscapingItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E2B")]
			[Cpp2IlInjected.Address(RVA = "0x7776D0", Offset = "0x7760D0", VA = "0x1807776D0")]
			[AsyncStateMachine(typeof(_003CPlaceLandscapingItemAsync_003Ed__42))]
			public Task<PlaceLandscapingItem.Types.Response> PlaceLandscapingItemAsync(PlaceLandscapingItem.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PlaceLandscapingItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E2C")]
			[Cpp2IlInjected.Address(RVA = "0x782E00", Offset = "0x781800", VA = "0x180782E00")]
			public Task<UpdateGridObjectTransform.Types.Response> UpdateGridObjectTransformAsync(UpdateGridObjectTransform.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<UpdateGridObjectTransform.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E2D")]
			[Cpp2IlInjected.Address(RVA = "0x782FB0", Offset = "0x7819B0", VA = "0x180782FB0")]
			[AsyncStateMachine(typeof(_003CUpdateGridObjectTransformAsync_003Ed__44))]
			public Task<UpdateGridObjectTransform.Types.Response> UpdateGridObjectTransformAsync(UpdateGridObjectTransform.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<UpdateGridObjectTransform.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E2E")]
			[Cpp2IlInjected.Address(RVA = "0x7807C0", Offset = "0x77F1C0", VA = "0x1807807C0")]
			public Task<SwitchGridObjectGrid.Types.Response> SwitchGridObjectGridAsync(SwitchGridObjectGrid.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SwitchGridObjectGrid.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E2F")]
			[Cpp2IlInjected.Address(RVA = "0x780970", Offset = "0x77F370", VA = "0x180780970")]
			[AsyncStateMachine(typeof(_003CSwitchGridObjectGridAsync_003Ed__46))]
			public Task<SwitchGridObjectGrid.Types.Response> SwitchGridObjectGridAsync(SwitchGridObjectGrid.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SwitchGridObjectGrid.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E30")]
			[Cpp2IlInjected.Address(RVA = "0x779830", Offset = "0x778230", VA = "0x180779830")]
			public Task<ReplaceGridObject.Types.Response> ReplaceGridObjectAsync(ReplaceGridObject.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ReplaceGridObject.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E31")]
			[Cpp2IlInjected.Address(RVA = "0x7799E0", Offset = "0x7783E0", VA = "0x1807799E0")]
			[AsyncStateMachine(typeof(_003CReplaceGridObjectAsync_003Ed__48))]
			public Task<ReplaceGridObject.Types.Response> ReplaceGridObjectAsync(ReplaceGridObject.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ReplaceGridObject.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E32")]
			[Cpp2IlInjected.Address(RVA = "0x775BA0", Offset = "0x7745A0", VA = "0x180775BA0")]
			public Task<MoveInContainerInventory.Types.Response> MoveInContainerInventoryAsync(MoveInContainerInventory.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<MoveInContainerInventory.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E33")]
			[Cpp2IlInjected.Address(RVA = "0x775D50", Offset = "0x774750", VA = "0x180775D50")]
			[AsyncStateMachine(typeof(_003CMoveInContainerInventoryAsync_003Ed__50))]
			public Task<MoveInContainerInventory.Types.Response> MoveInContainerInventoryAsync(MoveInContainerInventory.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<MoveInContainerInventory.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E34")]
			[Cpp2IlInjected.Address(RVA = "0x77DE50", Offset = "0x77C850", VA = "0x18077DE50")]
			public Task<SortContainerInventory.Types.Response> SortContainerInventoryAsync(SortContainerInventory.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SortContainerInventory.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E35")]
			[Cpp2IlInjected.Address(RVA = "0x77E000", Offset = "0x77CA00", VA = "0x18077E000")]
			[AsyncStateMachine(typeof(_003CSortContainerInventoryAsync_003Ed__52))]
			public Task<SortContainerInventory.Types.Response> SortContainerInventoryAsync(SortContainerInventory.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SortContainerInventory.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E36")]
			[Cpp2IlInjected.Address(RVA = "0x77DB20", Offset = "0x77C520", VA = "0x18077DB20")]
			public Task<SmartInventoryTransfer.Types.Response> SmartInventoryTransferAsync(SmartInventoryTransfer.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SmartInventoryTransfer.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E37")]
			[Cpp2IlInjected.Address(RVA = "0x77DCD0", Offset = "0x77C6D0", VA = "0x18077DCD0")]
			[AsyncStateMachine(typeof(_003CSmartInventoryTransferAsync_003Ed__54))]
			public Task<SmartInventoryTransfer.Types.Response> SmartInventoryTransferAsync(SmartInventoryTransfer.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SmartInventoryTransfer.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E38")]
			[Cpp2IlInjected.Address(RVA = "0x764320", Offset = "0x762D20", VA = "0x180764320")]
			public Task<AddItemToKeyhole.Types.Response> AddItemToKeyholeAsync(AddItemToKeyhole.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<AddItemToKeyhole.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E39")]
			[Cpp2IlInjected.Address(RVA = "0x7644D0", Offset = "0x762ED0", VA = "0x1807644D0")]
			[AsyncStateMachine(typeof(_003CAddItemToKeyholeAsync_003Ed__56))]
			public Task<AddItemToKeyhole.Types.Response> AddItemToKeyholeAsync(AddItemToKeyhole.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<AddItemToKeyhole.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E3A")]
			[Cpp2IlInjected.Address(RVA = "0x779500", Offset = "0x777F00", VA = "0x180779500")]
			public Task<RemoveItemFromKeyhole.Types.Response> RemoveItemFromKeyholeAsync(RemoveItemFromKeyhole.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<RemoveItemFromKeyhole.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E3B")]
			[Cpp2IlInjected.Address(RVA = "0x7796B0", Offset = "0x7780B0", VA = "0x1807796B0")]
			[AsyncStateMachine(typeof(_003CRemoveItemFromKeyholeAsync_003Ed__58))]
			public Task<RemoveItemFromKeyhole.Types.Response> RemoveItemFromKeyholeAsync(RemoveItemFromKeyhole.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<RemoveItemFromKeyhole.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E3C")]
			[Cpp2IlInjected.Address(RVA = "0x780490", Offset = "0x77EE90", VA = "0x180780490")]
			public Task<SwapItemInKeyhole.Types.Response> SwapItemInKeyholeAsync(SwapItemInKeyhole.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SwapItemInKeyhole.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E3D")]
			[Cpp2IlInjected.Address(RVA = "0x780640", Offset = "0x77F040", VA = "0x180780640")]
			[AsyncStateMachine(typeof(_003CSwapItemInKeyholeAsync_003Ed__60))]
			public Task<SwapItemInKeyhole.Types.Response> SwapItemInKeyholeAsync(SwapItemInKeyhole.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SwapItemInKeyhole.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E3E")]
			[Cpp2IlInjected.Address(RVA = "0x77C1A0", Offset = "0x77ABA0", VA = "0x18077C1A0")]
			public Task<SetFurnitureToggleState.Types.Response> SetFurnitureToggleStateAsync(SetFurnitureToggleState.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SetFurnitureToggleState.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E3F")]
			[Cpp2IlInjected.Address(RVA = "0x77C350", Offset = "0x77AD50", VA = "0x18077C350")]
			[AsyncStateMachine(typeof(_003CSetFurnitureToggleStateAsync_003Ed__62))]
			public Task<SetFurnitureToggleState.Types.Response> SetFurnitureToggleStateAsync(SetFurnitureToggleState.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SetFurnitureToggleState.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E40")]
			[Cpp2IlInjected.Address(RVA = "0x77BE70", Offset = "0x77A870", VA = "0x18077BE70")]
			public Task<SetFurnitureIndexState.Types.Response> SetFurnitureIndexStateAsync(SetFurnitureIndexState.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SetFurnitureIndexState.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E41")]
			[Cpp2IlInjected.Address(RVA = "0x77C020", Offset = "0x77AA20", VA = "0x18077C020")]
			[AsyncStateMachine(typeof(_003CSetFurnitureIndexStateAsync_003Ed__64))]
			public Task<SetFurnitureIndexState.Types.Response> SetFurnitureIndexStateAsync(SetFurnitureIndexState.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SetFurnitureIndexState.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E42")]
			[Cpp2IlInjected.Address(RVA = "0x768DF0", Offset = "0x7677F0", VA = "0x180768DF0")]
			public Task<CollectLootPresent.Types.Response> CollectLootPresentAsync(CollectLootPresent.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<CollectLootPresent.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E43")]
			[Cpp2IlInjected.Address(RVA = "0x768C70", Offset = "0x767670", VA = "0x180768C70")]
			[AsyncStateMachine(typeof(_003CCollectLootPresentAsync_003Ed__66))]
			public Task<CollectLootPresent.Types.Response> CollectLootPresentAsync(CollectLootPresent.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CollectLootPresent.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E44")]
			[Cpp2IlInjected.Address(RVA = "0x768460", Offset = "0x766E60", VA = "0x180768460")]
			public Task<CollectConsummable.Types.Response> CollectConsummableAsync(CollectConsummable.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<CollectConsummable.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E45")]
			[Cpp2IlInjected.Address(RVA = "0x7682E0", Offset = "0x766CE0", VA = "0x1807682E0")]
			[AsyncStateMachine(typeof(_003CCollectConsummableAsync_003Ed__68))]
			public Task<CollectConsummable.Types.Response> CollectConsummableAsync(CollectConsummable.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CollectConsummable.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E46")]
			[Cpp2IlInjected.Address(RVA = "0x769780", Offset = "0x768180", VA = "0x180769780")]
			public Task<ConsumeItem.Types.Response> ConsumeItemAsync(ConsumeItem.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ConsumeItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E47")]
			[Cpp2IlInjected.Address(RVA = "0x769600", Offset = "0x768000", VA = "0x180769600")]
			[AsyncStateMachine(typeof(_003CConsumeItemAsync_003Ed__70))]
			public Task<ConsumeItem.Types.Response> ConsumeItemAsync(ConsumeItem.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ConsumeItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E48")]
			[Cpp2IlInjected.Address(RVA = "0x780C70", Offset = "0x77F670", VA = "0x180780C70")]
			public Task<SwitchPictureFrame.Types.Response> SwitchPictureFrameAsync(SwitchPictureFrame.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SwitchPictureFrame.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E49")]
			[Cpp2IlInjected.Address(RVA = "0x780AF0", Offset = "0x77F4F0", VA = "0x180780AF0")]
			[AsyncStateMachine(typeof(_003CSwitchPictureFrameAsync_003Ed__72))]
			public Task<SwitchPictureFrame.Types.Response> SwitchPictureFrameAsync(SwitchPictureFrame.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SwitchPictureFrame.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E4A")]
			[Cpp2IlInjected.Address(RVA = "0x765AF0", Offset = "0x7644F0", VA = "0x180765AF0")]
			public Task<BuyItem.Types.Response> BuyItemAsync(BuyItem.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<BuyItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E4B")]
			[Cpp2IlInjected.Address(RVA = "0x765970", Offset = "0x764370", VA = "0x180765970")]
			[AsyncStateMachine(typeof(_003CBuyItemAsync_003Ed__74))]
			public Task<BuyItem.Types.Response> BuyItemAsync(BuyItem.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<BuyItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E4C")]
			[Cpp2IlInjected.Address(RVA = "0x765160", Offset = "0x763B60", VA = "0x180765160")]
			public Task<AvatarTransfer.Types.Response> AvatarTransferAsync(AvatarTransfer.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<AvatarTransfer.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E4D")]
			[Cpp2IlInjected.Address(RVA = "0x764FE0", Offset = "0x7639E0", VA = "0x180764FE0")]
			[AsyncStateMachine(typeof(_003CAvatarTransferAsync_003Ed__76))]
			public Task<AvatarTransfer.Types.Response> AvatarTransferAsync(AvatarTransfer.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<AvatarTransfer.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E4E")]
			[Cpp2IlInjected.Address(RVA = "0x77B330", Offset = "0x779D30", VA = "0x18077B330")]
			public Task<AvatarCustomization.Types.Response> SetAvatarCustomizationAsync(AvatarCustomization.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<AvatarCustomization.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E4F")]
			[Cpp2IlInjected.Address(RVA = "0x77B1B0", Offset = "0x779BB0", VA = "0x18077B1B0")]
			[AsyncStateMachine(typeof(_003CSetAvatarCustomizationAsync_003Ed__78))]
			public Task<AvatarCustomization.Types.Response> SetAvatarCustomizationAsync(AvatarCustomization.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<AvatarCustomization.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E50")]
			[Cpp2IlInjected.Address(RVA = "0x77A010", Offset = "0x778A10", VA = "0x18077A010")]
			public Task<SaveClothingDesign.Types.Response> SaveClothingDesignAsync(SaveClothingDesign.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SaveClothingDesign.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E51")]
			[Cpp2IlInjected.Address(RVA = "0x779E90", Offset = "0x778890", VA = "0x180779E90")]
			[AsyncStateMachine(typeof(_003CSaveClothingDesignAsync_003Ed__80))]
			public Task<SaveClothingDesign.Types.Response> SaveClothingDesignAsync(SaveClothingDesign.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SaveClothingDesign.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E52")]
			[Cpp2IlInjected.Address(RVA = "0x7703E0", Offset = "0x76EDE0", VA = "0x1807703E0")]
			public Task<DeleteClothingDesign.Types.Response> DeleteClothingDesignAsync(DeleteClothingDesign.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DeleteClothingDesign.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E53")]
			[Cpp2IlInjected.Address(RVA = "0x770260", Offset = "0x76EC60", VA = "0x180770260")]
			[AsyncStateMachine(typeof(_003CDeleteClothingDesignAsync_003Ed__82))]
			public Task<DeleteClothingDesign.Types.Response> DeleteClothingDesignAsync(DeleteClothingDesign.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DeleteClothingDesign.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E54")]
			[Cpp2IlInjected.Address(RVA = "0x77BB40", Offset = "0x77A540", VA = "0x18077BB40")]
			public Task<FurnitureCustomization.Types.Response> SetFurnitureCustomizationAsync(FurnitureCustomization.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<FurnitureCustomization.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E55")]
			[Cpp2IlInjected.Address(RVA = "0x77BCF0", Offset = "0x77A6F0", VA = "0x18077BCF0")]
			[AsyncStateMachine(typeof(_003CSetFurnitureCustomizationAsync_003Ed__84))]
			public Task<FurnitureCustomization.Types.Response> SetFurnitureCustomizationAsync(FurnitureCustomization.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<FurnitureCustomization.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E56")]
			[Cpp2IlInjected.Address(RVA = "0x77A340", Offset = "0x778D40", VA = "0x18077A340")]
			public Task<SaveFurnitureDesign.Types.Response> SaveFurnitureDesignAsync(SaveFurnitureDesign.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SaveFurnitureDesign.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E57")]
			[Cpp2IlInjected.Address(RVA = "0x77A1C0", Offset = "0x778BC0", VA = "0x18077A1C0")]
			[AsyncStateMachine(typeof(_003CSaveFurnitureDesignAsync_003Ed__86))]
			public Task<SaveFurnitureDesign.Types.Response> SaveFurnitureDesignAsync(SaveFurnitureDesign.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SaveFurnitureDesign.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E58")]
			[Cpp2IlInjected.Address(RVA = "0x770590", Offset = "0x76EF90", VA = "0x180770590")]
			public Task<DeleteFurnitureDesign.Types.Response> DeleteFurnitureDesignAsync(DeleteFurnitureDesign.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DeleteFurnitureDesign.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E59")]
			[Cpp2IlInjected.Address(RVA = "0x770740", Offset = "0x76F140", VA = "0x180770740")]
			[AsyncStateMachine(typeof(_003CDeleteFurnitureDesignAsync_003Ed__88))]
			public Task<DeleteFurnitureDesign.Types.Response> DeleteFurnitureDesignAsync(DeleteFurnitureDesign.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DeleteFurnitureDesign.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E5A")]
			[Cpp2IlInjected.Address(RVA = "0x7713D0", Offset = "0x76FDD0", VA = "0x1807713D0")]
			public Task<EnableCharacter.Types.Response> EnableCharacterAsync(EnableCharacter.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<EnableCharacter.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E5B")]
			[Cpp2IlInjected.Address(RVA = "0x771250", Offset = "0x76FC50", VA = "0x180771250")]
			[AsyncStateMachine(typeof(_003CEnableCharacterAsync_003Ed__90))]
			public Task<EnableCharacter.Types.Response> EnableCharacterAsync(EnableCharacter.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<EnableCharacter.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E5C")]
			[Cpp2IlInjected.Address(RVA = "0x770A40", Offset = "0x76F440", VA = "0x180770A40")]
			public Task<DiscussWithCharacter.Types.Response> DiscussWithCharacterAsync(DiscussWithCharacter.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DiscussWithCharacter.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E5D")]
			[Cpp2IlInjected.Address(RVA = "0x7708C0", Offset = "0x76F2C0", VA = "0x1807708C0")]
			[AsyncStateMachine(typeof(_003CDiscussWithCharacterAsync_003Ed__92))]
			public Task<DiscussWithCharacter.Types.Response> DiscussWithCharacterAsync(DiscussWithCharacter.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DiscussWithCharacter.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E5E")]
			[Cpp2IlInjected.Address(RVA = "0x779B60", Offset = "0x778560", VA = "0x180779B60")]
			public Task<ResetCharacterDiscussions.Types.Response> ResetCharacterDiscussionsAsync(ResetCharacterDiscussions.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ResetCharacterDiscussions.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E5F")]
			[Cpp2IlInjected.Address(RVA = "0x779D10", Offset = "0x778710", VA = "0x180779D10")]
			[AsyncStateMachine(typeof(_003CResetCharacterDiscussionsAsync_003Ed__94))]
			public Task<ResetCharacterDiscussions.Types.Response> ResetCharacterDiscussionsAsync(ResetCharacterDiscussions.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ResetCharacterDiscussions.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E60")]
			[Cpp2IlInjected.Address(RVA = "0x773BC0", Offset = "0x7725C0", VA = "0x180773BC0")]
			public Task<GiveItemsToCharacter.Types.Response> GiveItemsToCharacterAsync(GiveItemsToCharacter.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<GiveItemsToCharacter.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E61")]
			[Cpp2IlInjected.Address(RVA = "0x773D70", Offset = "0x772770", VA = "0x180773D70")]
			[AsyncStateMachine(typeof(_003CGiveItemsToCharacterAsync_003Ed__96))]
			public Task<GiveItemsToCharacter.Types.Response> GiveItemsToCharacterAsync(GiveItemsToCharacter.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<GiveItemsToCharacter.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E62")]
			[Cpp2IlInjected.Address(RVA = "0x77B4E0", Offset = "0x779EE0", VA = "0x18077B4E0")]
			public Task<SetCharacterPreferredItemsAsSeen.Types.Response> SetCharacterPreferredItemsAsSeenAsync(SetCharacterPreferredItemsAsSeen.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SetCharacterPreferredItemsAsSeen.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E63")]
			[Cpp2IlInjected.Address(RVA = "0x77B690", Offset = "0x77A090", VA = "0x18077B690")]
			[AsyncStateMachine(typeof(_003CSetCharacterPreferredItemsAsSeenAsync_003Ed__98))]
			public Task<SetCharacterPreferredItemsAsSeen.Types.Response> SetCharacterPreferredItemsAsSeenAsync(SetCharacterPreferredItemsAsSeen.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SetCharacterPreferredItemsAsSeen.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E64")]
			[Cpp2IlInjected.Address(RVA = "0x782920", Offset = "0x781320", VA = "0x180782920")]
			public Task<UpdateCharacterSchedules.Types.Response> UpdateCharacterSchedulesAsync(UpdateCharacterSchedules.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<UpdateCharacterSchedules.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E65")]
			[Cpp2IlInjected.Address(RVA = "0x7827A0", Offset = "0x7811A0", VA = "0x1807827A0")]
			[AsyncStateMachine(typeof(_003CUpdateCharacterSchedulesAsync_003Ed__100))]
			public Task<UpdateCharacterSchedules.Types.Response> UpdateCharacterSchedulesAsync(UpdateCharacterSchedules.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<UpdateCharacterSchedules.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E66")]
			[Cpp2IlInjected.Address(RVA = "0x77A9A0", Offset = "0x7793A0", VA = "0x18077A9A0")]
			public Task<SecretCharacterDiscovered.Types.Response> SecretCharacterDiscoveredAsync(SecretCharacterDiscovered.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SecretCharacterDiscovered.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E67")]
			[Cpp2IlInjected.Address(RVA = "0x77A820", Offset = "0x779220", VA = "0x18077A820")]
			[AsyncStateMachine(typeof(_003CSecretCharacterDiscoveredAsync_003Ed__102))]
			public Task<SecretCharacterDiscovered.Types.Response> SecretCharacterDiscoveredAsync(SecretCharacterDiscovered.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SecretCharacterDiscovered.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E68")]
			[Cpp2IlInjected.Address(RVA = "0x764980", Offset = "0x763380", VA = "0x180764980")]
			public Task<ApplyCharacterProfession.Types.Response> ApplyCharacterProfessionAsync(ApplyCharacterProfession.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ApplyCharacterProfession.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E69")]
			[Cpp2IlInjected.Address(RVA = "0x764B30", Offset = "0x763530", VA = "0x180764B30")]
			[AsyncStateMachine(typeof(_003CApplyCharacterProfessionAsync_003Ed__104))]
			public Task<ApplyCharacterProfession.Types.Response> ApplyCharacterProfessionAsync(ApplyCharacterProfession.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ApplyCharacterProfession.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E6A")]
			[Cpp2IlInjected.Address(RVA = "0x766300", Offset = "0x764D00", VA = "0x180766300")]
			public Task<ChangeCharacterProfession.Types.Response> ChangeCharacterProfessionAsync(ChangeCharacterProfession.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ChangeCharacterProfession.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E6B")]
			[Cpp2IlInjected.Address(RVA = "0x7664B0", Offset = "0x764EB0", VA = "0x1807664B0")]
			[AsyncStateMachine(typeof(_003CChangeCharacterProfessionAsync_003Ed__106))]
			public Task<ChangeCharacterProfession.Types.Response> ChangeCharacterProfessionAsync(ChangeCharacterProfession.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ChangeCharacterProfession.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E6C")]
			[Cpp2IlInjected.Address(RVA = "0x764CB0", Offset = "0x7636B0", VA = "0x180764CB0")]
			public Task<ApplyCharacterSkin.Types.Response> ApplyCharacterSkinAsync(ApplyCharacterSkin.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ApplyCharacterSkin.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E6D")]
			[Cpp2IlInjected.Address(RVA = "0x764E60", Offset = "0x763860", VA = "0x180764E60")]
			[AsyncStateMachine(typeof(_003CApplyCharacterSkinAsync_003Ed__108))]
			public Task<ApplyCharacterSkin.Types.Response> ApplyCharacterSkinAsync(ApplyCharacterSkin.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ApplyCharacterSkin.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E6E")]
			[Cpp2IlInjected.Address(RVA = "0x782140", Offset = "0x780B40", VA = "0x180782140")]
			public Task<UnlockVillageArea.Types.Response> UnlockVillageAreaAsync(UnlockVillageArea.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<UnlockVillageArea.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E6F")]
			[Cpp2IlInjected.Address(RVA = "0x7822F0", Offset = "0x780CF0", VA = "0x1807822F0")]
			[AsyncStateMachine(typeof(_003CUnlockVillageAreaAsync_003Ed__110))]
			public Task<UnlockVillageArea.Types.Response> UnlockVillageAreaAsync(UnlockVillageArea.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<UnlockVillageArea.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E70")]
			[Cpp2IlInjected.Address(RVA = "0x7723C0", Offset = "0x770DC0", VA = "0x1807723C0")]
			public Task<ExecuteDailyReset.Types.Response> ExecuteDailyResetAsync(ExecuteDailyReset.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ExecuteDailyReset.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E71")]
			[Cpp2IlInjected.Address(RVA = "0x772240", Offset = "0x770C40", VA = "0x180772240")]
			[AsyncStateMachine(typeof(_003CExecuteDailyResetAsync_003Ed__112))]
			public Task<ExecuteDailyReset.Types.Response> ExecuteDailyResetAsync(ExecuteDailyReset.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ExecuteDailyReset.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E72")]
			[Cpp2IlInjected.Address(RVA = "0x775210", Offset = "0x773C10", VA = "0x180775210")]
			public Task<Meditate.Types.Response> MeditateAsync(Meditate.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<Meditate.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E73")]
			[Cpp2IlInjected.Address(RVA = "0x7753C0", Offset = "0x773DC0", VA = "0x1807753C0")]
			[AsyncStateMachine(typeof(_003CMeditateAsync_003Ed__114))]
			public Task<Meditate.Types.Response> MeditateAsync(Meditate.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<Meditate.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E74")]
			[Cpp2IlInjected.Address(RVA = "0x76FA50", Offset = "0x76E450", VA = "0x18076FA50")]
			public Task<DebugUnlockCharacter.Types.Response> DebugUnlockCharacterAsync(DebugUnlockCharacter.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugUnlockCharacter.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E75")]
			[Cpp2IlInjected.Address(RVA = "0x76F8D0", Offset = "0x76E2D0", VA = "0x18076F8D0")]
			[AsyncStateMachine(typeof(_003CDebugUnlockCharacterAsync_003Ed__116))]
			public Task<DebugUnlockCharacter.Types.Response> DebugUnlockCharacterAsync(DebugUnlockCharacter.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugUnlockCharacter.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E76")]
			[Cpp2IlInjected.Address(RVA = "0x76E8E0", Offset = "0x76D2E0", VA = "0x18076E8E0")]
			public Task<DebugStartEvent.Types.Response> DebugStartEventAsync(DebugStartEvent.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugStartEvent.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E77")]
			[Cpp2IlInjected.Address(RVA = "0x76EA90", Offset = "0x76D490", VA = "0x18076EA90")]
			[AsyncStateMachine(typeof(_003CDebugStartEventAsync_003Ed__118))]
			public Task<DebugStartEvent.Types.Response> DebugStartEventAsync(DebugStartEvent.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugStartEvent.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E78")]
			[Cpp2IlInjected.Address(RVA = "0x76C0F0", Offset = "0x76AAF0", VA = "0x18076C0F0")]
			public Task<DebugEndEvent.Types.Response> DebugEndEventAsync(DebugEndEvent.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugEndEvent.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E79")]
			[Cpp2IlInjected.Address(RVA = "0x76BF70", Offset = "0x76A970", VA = "0x18076BF70")]
			[AsyncStateMachine(typeof(_003CDebugEndEventAsync_003Ed__120))]
			public Task<DebugEndEvent.Types.Response> DebugEndEventAsync(DebugEndEvent.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugEndEvent.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E7A")]
			[Cpp2IlInjected.Address(RVA = "0x76E5B0", Offset = "0x76CFB0", VA = "0x18076E5B0")]
			public Task<DebugSkipTime.Types.Response> DebugSkipTimeAsync(DebugSkipTime.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugSkipTime.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E7B")]
			[Cpp2IlInjected.Address(RVA = "0x76E760", Offset = "0x76D160", VA = "0x18076E760")]
			[AsyncStateMachine(typeof(_003CDebugSkipTimeAsync_003Ed__122))]
			public Task<DebugSkipTime.Types.Response> DebugSkipTimeAsync(DebugSkipTime.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugSkipTime.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E7C")]
			[Cpp2IlInjected.Address(RVA = "0x76D290", Offset = "0x76BC90", VA = "0x18076D290")]
			public Task<DebugGenericCheat.Types.Response> DebugGenericCheatAsync(DebugGenericCheat.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugGenericCheat.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E7D")]
			[Cpp2IlInjected.Address(RVA = "0x76D440", Offset = "0x76BE40", VA = "0x18076D440")]
			[AsyncStateMachine(typeof(_003CDebugGenericCheatAsync_003Ed__124))]
			public Task<DebugGenericCheat.Types.Response> DebugGenericCheatAsync(DebugGenericCheat.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugGenericCheat.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E7E")]
			[Cpp2IlInjected.Address(RVA = "0x76B100", Offset = "0x769B00", VA = "0x18076B100")]
			public Task<DebugAddItem.Types.Response> DebugAddItemAsync(DebugAddItem.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugAddItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E7F")]
			[Cpp2IlInjected.Address(RVA = "0x76AF80", Offset = "0x769980", VA = "0x18076AF80")]
			[AsyncStateMachine(typeof(_003CDebugAddItemAsync_003Ed__126))]
			public Task<DebugAddItem.Types.Response> DebugAddItemAsync(DebugAddItem.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugAddItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E80")]
			[Cpp2IlInjected.Address(RVA = "0x76DA70", Offset = "0x76C470", VA = "0x18076DA70")]
			public Task<DebugRemoveItem.Types.Response> DebugRemoveItemAsync(DebugRemoveItem.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugRemoveItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E81")]
			[Cpp2IlInjected.Address(RVA = "0x76D8F0", Offset = "0x76C2F0", VA = "0x18076D8F0")]
			[AsyncStateMachine(typeof(_003CDebugRemoveItemAsync_003Ed__128))]
			public Task<DebugRemoveItem.Types.Response> DebugRemoveItemAsync(DebugRemoveItem.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugRemoveItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E82")]
			[Cpp2IlInjected.Address(RVA = "0x76ADD0", Offset = "0x7697D0", VA = "0x18076ADD0")]
			public Task<DebugAddFriendship.Types.Response> DebugAddFriendshipAsync(DebugAddFriendship.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugAddFriendship.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E83")]
			[Cpp2IlInjected.Address(RVA = "0x76AC50", Offset = "0x769650", VA = "0x18076AC50")]
			[AsyncStateMachine(typeof(_003CDebugAddFriendshipAsync_003Ed__130))]
			public Task<DebugAddFriendship.Types.Response> DebugAddFriendshipAsync(DebugAddFriendship.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugAddFriendship.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E84")]
			[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x769E30", VA = "0x18076B430")]
			public Task<DebugAddPlayerXP.Types.Response> DebugAddPlayerXPAsync(DebugAddPlayerXP.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugAddPlayerXP.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E85")]
			[Cpp2IlInjected.Address(RVA = "0x76B2B0", Offset = "0x769CB0", VA = "0x18076B2B0")]
			[AsyncStateMachine(typeof(_003CDebugAddPlayerXPAsync_003Ed__132))]
			public Task<DebugAddPlayerXP.Types.Response> DebugAddPlayerXPAsync(DebugAddPlayerXP.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugAddPlayerXP.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E86")]
			[Cpp2IlInjected.Address(RVA = "0x76E0D0", Offset = "0x76CAD0", VA = "0x18076E0D0")]
			public Task<DebugSetPlayerLevel.Types.Response> DebugSetPlayerLevelAsync(DebugSetPlayerLevel.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugSetPlayerLevel.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E87")]
			[Cpp2IlInjected.Address(RVA = "0x76DF50", Offset = "0x76C950", VA = "0x18076DF50")]
			[AsyncStateMachine(typeof(_003CDebugSetPlayerLevelAsync_003Ed__134))]
			public Task<DebugSetPlayerLevel.Types.Response> DebugSetPlayerLevelAsync(DebugSetPlayerLevel.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugSetPlayerLevel.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E88")]
			[Cpp2IlInjected.Address(RVA = "0x76A920", Offset = "0x769320", VA = "0x18076A920")]
			public Task<DebugAddFreeTimer.Types.Response> DebugAddFreeTimerAsync(DebugAddFreeTimer.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugAddFreeTimer.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E89")]
			[Cpp2IlInjected.Address(RVA = "0x76AAD0", Offset = "0x7694D0", VA = "0x18076AAD0")]
			[AsyncStateMachine(typeof(_003CDebugAddFreeTimerAsync_003Ed__136))]
			public Task<DebugAddFreeTimer.Types.Response> DebugAddFreeTimerAsync(DebugAddFreeTimer.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugAddFreeTimer.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E8A")]
			[Cpp2IlInjected.Address(RVA = "0x76C750", Offset = "0x76B150", VA = "0x18076C750")]
			public Task<DebugForceActivityBonusReward.Types.Response> DebugForceActivityBonusRewardAsync(DebugForceActivityBonusReward.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugForceActivityBonusReward.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E8B")]
			[Cpp2IlInjected.Address(RVA = "0x76C5D0", Offset = "0x76AFD0", VA = "0x18076C5D0")]
			[AsyncStateMachine(typeof(_003CDebugForceActivityBonusRewardAsync_003Ed__138))]
			public Task<DebugForceActivityBonusReward.Types.Response> DebugForceActivityBonusRewardAsync(DebugForceActivityBonusReward.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugForceActivityBonusReward.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E8C")]
			[Cpp2IlInjected.Address(RVA = "0x76CA80", Offset = "0x76B480", VA = "0x18076CA80")]
			public Task<DebugForceBurningState.Types.Response> DebugForceBurningStateAsync(DebugForceBurningState.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugForceBurningState.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E8D")]
			[Cpp2IlInjected.Address(RVA = "0x76C900", Offset = "0x76B300", VA = "0x18076C900")]
			[AsyncStateMachine(typeof(_003CDebugForceBurningStateAsync_003Ed__140))]
			public Task<DebugForceBurningState.Types.Response> DebugForceBurningStateAsync(DebugForceBurningState.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugForceBurningState.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E8E")]
			[Cpp2IlInjected.Address(RVA = "0x76CDB0", Offset = "0x76B7B0", VA = "0x18076CDB0")]
			public Task<DebugForceSecretCharacter.Types.Response> DebugForceSecretCharacterAsync(DebugForceSecretCharacter.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugForceSecretCharacter.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E8F")]
			[Cpp2IlInjected.Address(RVA = "0x76CC30", Offset = "0x76B630", VA = "0x18076CC30")]
			[AsyncStateMachine(typeof(_003CDebugForceSecretCharacterAsync_003Ed__142))]
			public Task<DebugForceSecretCharacter.Types.Response> DebugForceSecretCharacterAsync(DebugForceSecretCharacter.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugForceSecretCharacter.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E90")]
			[Cpp2IlInjected.Address(RVA = "0x76F3F0", Offset = "0x76DDF0", VA = "0x18076F3F0")]
			public Task<DebugUnlockAllCritters.Types.Response> DebugUnlockAllCrittersAsync(DebugUnlockAllCritters.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugUnlockAllCritters.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E91")]
			[Cpp2IlInjected.Address(RVA = "0x76F270", Offset = "0x76DC70", VA = "0x18076F270")]
			[AsyncStateMachine(typeof(_003CDebugUnlockAllCrittersAsync_003Ed__144))]
			public Task<DebugUnlockAllCritters.Types.Response> DebugUnlockAllCrittersAsync(DebugUnlockAllCritters.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugUnlockAllCritters.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E92")]
			[Cpp2IlInjected.Address(RVA = "0x76FF30", Offset = "0x76E930", VA = "0x18076FF30")]
			public Task<DebugUnlockVillageArea.Types.Response> DebugUnlockVillageAreaAsync(DebugUnlockVillageArea.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugUnlockVillageArea.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E93")]
			[Cpp2IlInjected.Address(RVA = "0x7700E0", Offset = "0x76EAE0", VA = "0x1807700E0")]
			[AsyncStateMachine(typeof(_003CDebugUnlockVillageAreaAsync_003Ed__146))]
			public Task<DebugUnlockVillageArea.Types.Response> DebugUnlockVillageAreaAsync(DebugUnlockVillageArea.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugUnlockVillageArea.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E94")]
			[Cpp2IlInjected.Address(RVA = "0x76EF40", Offset = "0x76D940", VA = "0x18076EF40")]
			public Task<DebugUnlockAllBuildings.Types.Response> DebugUnlockAllBuildingsAsync(DebugUnlockAllBuildings.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugUnlockAllBuildings.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E95")]
			[Cpp2IlInjected.Address(RVA = "0x76F0F0", Offset = "0x76DAF0", VA = "0x18076F0F0")]
			[AsyncStateMachine(typeof(_003CDebugUnlockAllBuildingsAsync_003Ed__148))]
			public Task<DebugUnlockAllBuildings.Types.Response> DebugUnlockAllBuildingsAsync(DebugUnlockAllBuildings.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugUnlockAllBuildings.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E96")]
			[Cpp2IlInjected.Address(RVA = "0x76F720", Offset = "0x76E120", VA = "0x18076F720")]
			public Task<DebugUnlockAllRealms.Types.Response> DebugUnlockAllRealmsAsync(DebugUnlockAllRealms.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugUnlockAllRealms.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E97")]
			[Cpp2IlInjected.Address(RVA = "0x76F5A0", Offset = "0x76DFA0", VA = "0x18076F5A0")]
			[AsyncStateMachine(typeof(_003CDebugUnlockAllRealmsAsync_003Ed__150))]
			public Task<DebugUnlockAllRealms.Types.Response> DebugUnlockAllRealmsAsync(DebugUnlockAllRealms.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugUnlockAllRealms.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E98")]
			[Cpp2IlInjected.Address(RVA = "0x76FD80", Offset = "0x76E780", VA = "0x18076FD80")]
			public Task<DebugUnlockCharacterPreferredItems.Types.Response> DebugUnlockCharacterPreferredItemsAsync(DebugUnlockCharacterPreferredItems.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugUnlockCharacterPreferredItems.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E99")]
			[Cpp2IlInjected.Address(RVA = "0x76FC00", Offset = "0x76E600", VA = "0x18076FC00")]
			[AsyncStateMachine(typeof(_003CDebugUnlockCharacterPreferredItemsAsync_003Ed__152))]
			public Task<DebugUnlockCharacterPreferredItems.Types.Response> DebugUnlockCharacterPreferredItemsAsync(DebugUnlockCharacterPreferredItems.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugUnlockCharacterPreferredItems.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E9A")]
			[Cpp2IlInjected.Address(RVA = "0x76D5C0", Offset = "0x76BFC0", VA = "0x18076D5C0")]
			public Task<DebugRemoveAllForagingItems.Types.Response> DebugRemoveAllForagingItemsAsync(DebugRemoveAllForagingItems.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugRemoveAllForagingItems.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E9B")]
			[Cpp2IlInjected.Address(RVA = "0x76D770", Offset = "0x76C170", VA = "0x18076D770")]
			[AsyncStateMachine(typeof(_003CDebugRemoveAllForagingItemsAsync_003Ed__154))]
			public Task<DebugRemoveAllForagingItems.Types.Response> DebugRemoveAllForagingItemsAsync(DebugRemoveAllForagingItems.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugRemoveAllForagingItems.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E9C")]
			[Cpp2IlInjected.Address(RVA = "0x76BC40", Offset = "0x76A640", VA = "0x18076BC40")]
			public Task<DebugEmptyAllActivitySources.Types.Response> DebugEmptyAllActivitySourcesAsync(DebugEmptyAllActivitySources.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugEmptyAllActivitySources.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E9D")]
			[Cpp2IlInjected.Address(RVA = "0x76BDF0", Offset = "0x76A7F0", VA = "0x18076BDF0")]
			[AsyncStateMachine(typeof(_003CDebugEmptyAllActivitySourcesAsync_003Ed__156))]
			public Task<DebugEmptyAllActivitySources.Types.Response> DebugEmptyAllActivitySourcesAsync(DebugEmptyAllActivitySources.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugEmptyAllActivitySources.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E9E")]
			[Cpp2IlInjected.Address(RVA = "0x76C420", Offset = "0x76AE20", VA = "0x18076C420")]
			public Task<DebugFakeRPCException.Types.Response> DebugFakeRPCExceptionAsync(DebugFakeRPCException.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugFakeRPCException.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003E9F")]
			[Cpp2IlInjected.Address(RVA = "0x76C2A0", Offset = "0x76ACA0", VA = "0x18076C2A0")]
			[AsyncStateMachine(typeof(_003CDebugFakeRPCExceptionAsync_003Ed__158))]
			public Task<DebugFakeRPCException.Types.Response> DebugFakeRPCExceptionAsync(DebugFakeRPCException.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugFakeRPCException.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EA0")]
			[Cpp2IlInjected.Address(RVA = "0x7718B0", Offset = "0x7702B0", VA = "0x1807718B0")]
			public Task<EndMission.Types.Response> EndMissionAsync(EndMission.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<EndMission.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EA1")]
			[Cpp2IlInjected.Address(RVA = "0x771A60", Offset = "0x770460", VA = "0x180771A60")]
			[AsyncStateMachine(typeof(_003CEndMissionAsync_003Ed__160))]
			public Task<EndMission.Types.Response> EndMissionAsync(EndMission.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<EndMission.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EA2")]
			[Cpp2IlInjected.Address(RVA = "0x7746D0", Offset = "0x7730D0", VA = "0x1807746D0")]
			public Task<InitTLE.Types.Response> InitTLEAsync(InitTLE.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<InitTLE.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EA3")]
			[Cpp2IlInjected.Address(RVA = "0x774550", Offset = "0x772F50", VA = "0x180774550")]
			[AsyncStateMachine(typeof(_003CInitTLEAsync_003Ed__162))]
			public Task<InitTLE.Types.Response> InitTLEAsync(InitTLE.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<InitTLE.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EA4")]
			[Cpp2IlInjected.Address(RVA = "0x767620", Offset = "0x766020", VA = "0x180767620")]
			public Task<ClaimMiniEventReward.Types.Response> ClaimMiniEventRewardAsync(ClaimMiniEventReward.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ClaimMiniEventReward.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EA5")]
			[Cpp2IlInjected.Address(RVA = "0x7677D0", Offset = "0x7661D0", VA = "0x1807677D0")]
			[AsyncStateMachine(typeof(_003CClaimMiniEventRewardAsync_003Ed__164))]
			public Task<ClaimMiniEventReward.Types.Response> ClaimMiniEventRewardAsync(ClaimMiniEventReward.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ClaimMiniEventReward.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EA6")]
			[Cpp2IlInjected.Address(RVA = "0x77F2F0", Offset = "0x77DCF0", VA = "0x18077F2F0")]
			public Task<StartMission.Types.Response> StartMissionAsync(StartMission.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<StartMission.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EA7")]
			[Cpp2IlInjected.Address(RVA = "0x77F170", Offset = "0x77DB70", VA = "0x18077F170")]
			[AsyncStateMachine(typeof(_003CStartMissionAsync_003Ed__166))]
			public Task<StartMission.Types.Response> StartMissionAsync(StartMission.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<StartMission.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EA8")]
			[Cpp2IlInjected.Address(RVA = "0x782AD0", Offset = "0x7814D0", VA = "0x180782AD0")]
			public Task<UpdateDialogueFlags.Types.Response> UpdateDialogueFlagsAsync(UpdateDialogueFlags.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<UpdateDialogueFlags.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EA9")]
			[Cpp2IlInjected.Address(RVA = "0x782C80", Offset = "0x781680", VA = "0x180782C80")]
			[AsyncStateMachine(typeof(_003CUpdateDialogueFlagsAsync_003Ed__168))]
			public Task<UpdateDialogueFlags.Types.Response> UpdateDialogueFlagsAsync(UpdateDialogueFlags.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<UpdateDialogueFlags.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EAA")]
			[Cpp2IlInjected.Address(RVA = "0x7812D0", Offset = "0x77FCD0", VA = "0x1807812D0")]
			public Task<TrackMission.Types.Response> TrackMissionAsync(TrackMission.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<TrackMission.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EAB")]
			[Cpp2IlInjected.Address(RVA = "0x781150", Offset = "0x77FB50", VA = "0x180781150")]
			[AsyncStateMachine(typeof(_003CTrackMissionAsync_003Ed__170))]
			public Task<TrackMission.Types.Response> TrackMissionAsync(TrackMission.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<TrackMission.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EAC")]
			[Cpp2IlInjected.Address(RVA = "0x77CCB0", Offset = "0x77B6B0", VA = "0x18077CCB0")]
			public Task<SetMissionNextChoice.Types.Response> SetMissionNextChoiceAsync(SetMissionNextChoice.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SetMissionNextChoice.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EAD")]
			[Cpp2IlInjected.Address(RVA = "0x77CB30", Offset = "0x77B530", VA = "0x18077CB30")]
			[AsyncStateMachine(typeof(_003CSetMissionNextChoiceAsync_003Ed__172))]
			public Task<SetMissionNextChoice.Types.Response> SetMissionNextChoiceAsync(SetMissionNextChoice.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SetMissionNextChoice.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EAE")]
			[Cpp2IlInjected.Address(RVA = "0x776D10", Offset = "0x775710", VA = "0x180776D10")]
			public Task<PictureTaken.Types.Response> PictureTakenAsync(PictureTaken.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<PictureTaken.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EAF")]
			[Cpp2IlInjected.Address(RVA = "0x776B90", Offset = "0x775590", VA = "0x180776B90")]
			[AsyncStateMachine(typeof(_003CPictureTakenAsync_003Ed__174))]
			public Task<PictureTaken.Types.Response> PictureTakenAsync(PictureTaken.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PictureTaken.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EB0")]
			[Cpp2IlInjected.Address(RVA = "0x7759F0", Offset = "0x7743F0", VA = "0x1807759F0")]
			public Task<MissionItemInteraction.Types.Response> MissionItemInteractionAsync(MissionItemInteraction.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<MissionItemInteraction.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EB1")]
			[Cpp2IlInjected.Address(RVA = "0x775870", Offset = "0x774270", VA = "0x180775870")]
			[AsyncStateMachine(typeof(_003CMissionItemInteractionAsync_003Ed__176))]
			public Task<MissionItemInteraction.Types.Response> MissionItemInteractionAsync(MissionItemInteraction.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<MissionItemInteraction.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EB2")]
			[Cpp2IlInjected.Address(RVA = "0x775540", Offset = "0x773F40", VA = "0x180775540")]
			public Task<MissionCompleteStep.Types.Response> MissionCompleteStepAsync(MissionCompleteStep.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<MissionCompleteStep.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EB3")]
			[Cpp2IlInjected.Address(RVA = "0x7756F0", Offset = "0x7740F0", VA = "0x1807756F0")]
			[AsyncStateMachine(typeof(_003CMissionCompleteStepAsync_003Ed__178))]
			public Task<MissionCompleteStep.Types.Response> MissionCompleteStepAsync(MissionCompleteStep.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<MissionCompleteStep.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EB4")]
			[Cpp2IlInjected.Address(RVA = "0x76B760", Offset = "0x76A160", VA = "0x18076B760")]
			public Task<DebugCancelMission.Types.Response> DebugCancelMissionAsync(DebugCancelMission.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugCancelMission.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EB5")]
			[Cpp2IlInjected.Address(RVA = "0x76B5E0", Offset = "0x769FE0", VA = "0x18076B5E0")]
			[AsyncStateMachine(typeof(_003CDebugCancelMissionAsync_003Ed__180))]
			public Task<DebugCancelMission.Types.Response> DebugCancelMissionAsync(DebugCancelMission.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugCancelMission.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EB6")]
			[Cpp2IlInjected.Address(RVA = "0x76ED90", Offset = "0x76D790", VA = "0x18076ED90")]
			public Task<DebugTestMission.Types.Response> DebugTestMissionAsync(DebugTestMission.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugTestMission.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EB7")]
			[Cpp2IlInjected.Address(RVA = "0x76EC10", Offset = "0x76D610", VA = "0x18076EC10")]
			[AsyncStateMachine(typeof(_003CDebugTestMissionAsync_003Ed__182))]
			public Task<DebugTestMission.Types.Response> DebugTestMissionAsync(DebugTestMission.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugTestMission.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EB8")]
			[Cpp2IlInjected.Address(RVA = "0x76E400", Offset = "0x76CE00", VA = "0x18076E400")]
			public Task<DebugSkipMissionStep.Types.Response> DebugSkipMissionStepAsync(DebugSkipMissionStep.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugSkipMissionStep.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EB9")]
			[Cpp2IlInjected.Address(RVA = "0x76E280", Offset = "0x76CC80", VA = "0x18076E280")]
			[AsyncStateMachine(typeof(_003CDebugSkipMissionStepAsync_003Ed__184))]
			public Task<DebugSkipMissionStep.Types.Response> DebugSkipMissionStepAsync(DebugSkipMissionStep.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugSkipMissionStep.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EBA")]
			[Cpp2IlInjected.Address(RVA = "0x76A2C0", Offset = "0x768CC0", VA = "0x18076A2C0")]
			public Task<CreateGardeningTile.Types.Response> CreateGardeningTileAsync(CreateGardeningTile.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<CreateGardeningTile.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EBB")]
			[Cpp2IlInjected.Address(RVA = "0x76A470", Offset = "0x768E70", VA = "0x18076A470")]
			[AsyncStateMachine(typeof(_003CCreateGardeningTileAsync_003Ed__186))]
			public Task<CreateGardeningTile.Types.Response> CreateGardeningTileAsync(CreateGardeningTile.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CreateGardeningTile.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EBC")]
			[Cpp2IlInjected.Address(RVA = "0x778EA0", Offset = "0x7778A0", VA = "0x180778EA0")]
			public Task<RemoveGardeningTile.Types.Response> RemoveGardeningTileAsync(RemoveGardeningTile.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<RemoveGardeningTile.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EBD")]
			[Cpp2IlInjected.Address(RVA = "0x779050", Offset = "0x777A50", VA = "0x180779050")]
			[AsyncStateMachine(typeof(_003CRemoveGardeningTileAsync_003Ed__188))]
			public Task<RemoveGardeningTile.Types.Response> RemoveGardeningTileAsync(RemoveGardeningTile.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<RemoveGardeningTile.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EBE")]
			[Cpp2IlInjected.Address(RVA = "0x777B80", Offset = "0x776580", VA = "0x180777B80")]
			public Task<PlantSeed.Types.Response> PlantSeedAsync(PlantSeed.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<PlantSeed.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EBF")]
			[Cpp2IlInjected.Address(RVA = "0x777D30", Offset = "0x776730", VA = "0x180777D30")]
			[AsyncStateMachine(typeof(_003CPlantSeedAsync_003Ed__190))]
			public Task<PlantSeed.Types.Response> PlantSeedAsync(PlantSeed.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PlantSeed.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EC0")]
			[Cpp2IlInjected.Address(RVA = "0x772F00", Offset = "0x771900", VA = "0x180772F00")]
			public Task<FinishGardeningSlotGrowth.Types.Response> FinishGardeningSlotGrowthAsync(FinishGardeningSlotGrowth.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<FinishGardeningSlotGrowth.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EC1")]
			[Cpp2IlInjected.Address(RVA = "0x7730B0", Offset = "0x771AB0", VA = "0x1807730B0")]
			[AsyncStateMachine(typeof(_003CFinishGardeningSlotGrowthAsync_003Ed__192))]
			public Task<FinishGardeningSlotGrowth.Types.Response> FinishGardeningSlotGrowthAsync(FinishGardeningSlotGrowth.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<FinishGardeningSlotGrowth.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EC2")]
			[Cpp2IlInjected.Address(RVA = "0x774070", Offset = "0x772A70", VA = "0x180774070")]
			public Task<HarvestGardeningSlot.Types.Response> HarvestGardeningSlotAsync(HarvestGardeningSlot.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<HarvestGardeningSlot.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EC3")]
			[Cpp2IlInjected.Address(RVA = "0x773EF0", Offset = "0x7728F0", VA = "0x180773EF0")]
			[AsyncStateMachine(typeof(_003CHarvestGardeningSlotAsync_003Ed__194))]
			public Task<HarvestGardeningSlot.Types.Response> HarvestGardeningSlotAsync(HarvestGardeningSlot.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<HarvestGardeningSlot.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EC4")]
			[Cpp2IlInjected.Address(RVA = "0x768940", Offset = "0x767340", VA = "0x180768940")]
			public Task<CollectGardenStallSlot.Types.Response> CollectGardenStallSlotAsync(CollectGardenStallSlot.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<CollectGardenStallSlot.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EC5")]
			[Cpp2IlInjected.Address(RVA = "0x768AF0", Offset = "0x7674F0", VA = "0x180768AF0")]
			[AsyncStateMachine(typeof(_003CCollectGardenStallSlotAsync_003Ed__196))]
			public Task<CollectGardenStallSlot.Types.Response> CollectGardenStallSlotAsync(CollectGardenStallSlot.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CollectGardenStallSlot.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EC6")]
			[Cpp2IlInjected.Address(RVA = "0x784450", Offset = "0x782E50", VA = "0x180784450")]
			public Task<WaterObjects.Types.Response> WaterObjectsAsync(WaterObjects.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<WaterObjects.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EC7")]
			[Cpp2IlInjected.Address(RVA = "0x784600", Offset = "0x783000", VA = "0x180784600")]
			[AsyncStateMachine(typeof(_003CWaterObjectsAsync_003Ed__198))]
			public Task<WaterObjects.Types.Response> WaterObjectsAsync(WaterObjects.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<WaterObjects.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EC8")]
			[Cpp2IlInjected.Address(RVA = "0x77E630", Offset = "0x77D030", VA = "0x18077E630")]
			public Task<StartFishing.Types.Response> StartFishingAsync(StartFishing.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<StartFishing.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EC9")]
			[Cpp2IlInjected.Address(RVA = "0x77E4B0", Offset = "0x77CEB0", VA = "0x18077E4B0")]
			[AsyncStateMachine(typeof(_003CStartFishingAsync_003Ed__200))]
			public Task<StartFishing.Types.Response> StartFishingAsync(StartFishing.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<StartFishing.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ECA")]
			[Cpp2IlInjected.Address(RVA = "0x77ACD0", Offset = "0x7796D0", VA = "0x18077ACD0")]
			public Task<SendFishingResult.Types.Response> SendFishingResultAsync(SendFishingResult.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SendFishingResult.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ECB")]
			[Cpp2IlInjected.Address(RVA = "0x77AB50", Offset = "0x779550", VA = "0x18077AB50")]
			[AsyncStateMachine(typeof(_003CSendFishingResultAsync_003Ed__202))]
			public Task<SendFishingResult.Types.Response> SendFishingResultAsync(SendFishingResult.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SendFishingResult.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ECC")]
			[Cpp2IlInjected.Address(RVA = "0x783460", Offset = "0x781E60", VA = "0x180783460")]
			public Task<UpdatePendingFishes.Types.Response> UpdatePendingFishesAsync(UpdatePendingFishes.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<UpdatePendingFishes.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ECD")]
			[Cpp2IlInjected.Address(RVA = "0x783610", Offset = "0x782010", VA = "0x180783610")]
			[AsyncStateMachine(typeof(_003CUpdatePendingFishesAsync_003Ed__204))]
			public Task<UpdatePendingFishes.Types.Response> UpdatePendingFishesAsync(UpdatePendingFishes.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<UpdatePendingFishes.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ECE")]
			[Cpp2IlInjected.Address(RVA = "0x768790", Offset = "0x767190", VA = "0x180768790")]
			public Task<CollectFishingStall.Types.Response> CollectFishingStallAsync(CollectFishingStall.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<CollectFishingStall.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ECF")]
			[Cpp2IlInjected.Address(RVA = "0x768610", Offset = "0x767010", VA = "0x180768610")]
			[AsyncStateMachine(typeof(_003CCollectFishingStallAsync_003Ed__206))]
			public Task<CollectFishingStall.Types.Response> CollectFishingStallAsync(CollectFishingStall.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CollectFishingStall.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ED0")]
			[Cpp2IlInjected.Address(RVA = "0x77EB10", Offset = "0x77D510", VA = "0x18077EB10")]
			public Task<StartHangoutWithCharacter.Types.Response> StartHangoutWithCharacterAsync(StartHangoutWithCharacter.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<StartHangoutWithCharacter.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ED1")]
			[Cpp2IlInjected.Address(RVA = "0x77ECC0", Offset = "0x77D6C0", VA = "0x18077ECC0")]
			[AsyncStateMachine(typeof(_003CStartHangoutWithCharacterAsync_003Ed__208))]
			public Task<StartHangoutWithCharacter.Types.Response> StartHangoutWithCharacterAsync(StartHangoutWithCharacter.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<StartHangoutWithCharacter.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ED2")]
			[Cpp2IlInjected.Address(RVA = "0x77F7D0", Offset = "0x77E1D0", VA = "0x18077F7D0")]
			public Task<StopHangoutWithCharacter.Types.Response> StopHangoutWithCharacterAsync(StopHangoutWithCharacter.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<StopHangoutWithCharacter.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ED3")]
			[Cpp2IlInjected.Address(RVA = "0x77F980", Offset = "0x77E380", VA = "0x18077F980")]
			[AsyncStateMachine(typeof(_003CStopHangoutWithCharacterAsync_003Ed__210))]
			public Task<StopHangoutWithCharacter.Types.Response> StopHangoutWithCharacterAsync(StopHangoutWithCharacter.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<StopHangoutWithCharacter.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ED4")]
			[Cpp2IlInjected.Address(RVA = "0x77E300", Offset = "0x77CD00", VA = "0x18077E300")]
			public Task<SpawnHangoutRewardsForCharacter.Types.Response> SpawnHangoutRewardsForCharacterAsync(SpawnHangoutRewardsForCharacter.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SpawnHangoutRewardsForCharacter.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ED5")]
			[Cpp2IlInjected.Address(RVA = "0x77E180", Offset = "0x77CB80", VA = "0x18077E180")]
			[AsyncStateMachine(typeof(_003CSpawnHangoutRewardsForCharacterAsync_003Ed__212))]
			public Task<SpawnHangoutRewardsForCharacter.Types.Response> SpawnHangoutRewardsForCharacterAsync(SpawnHangoutRewardsForCharacter.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SpawnHangoutRewardsForCharacter.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ED6")]
			[Cpp2IlInjected.Address(RVA = "0x777370", Offset = "0x775D70", VA = "0x180777370")]
			public Task<PlaceBuilding.Types.Response> PlaceBuildingAsync(PlaceBuilding.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<PlaceBuilding.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ED7")]
			[Cpp2IlInjected.Address(RVA = "0x7771F0", Offset = "0x775BF0", VA = "0x1807771F0")]
			[AsyncStateMachine(typeof(_003CPlaceBuildingAsync_003Ed__214))]
			public Task<PlaceBuilding.Types.Response> PlaceBuildingAsync(PlaceBuilding.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PlaceBuilding.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ED8")]
			[Cpp2IlInjected.Address(RVA = "0x779350", Offset = "0x777D50", VA = "0x180779350")]
			public Task<RemoveHouse.Types.Response> RemoveHouseAsync(RemoveHouse.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<RemoveHouse.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003ED9")]
			[Cpp2IlInjected.Address(RVA = "0x7791D0", Offset = "0x777BD0", VA = "0x1807791D0")]
			[AsyncStateMachine(typeof(_003CRemoveHouseAsync_003Ed__216))]
			public Task<RemoveHouse.Types.Response> RemoveHouseAsync(RemoveHouse.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<RemoveHouse.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EDA")]
			[Cpp2IlInjected.Address(RVA = "0x765490", Offset = "0x763E90", VA = "0x180765490")]
			public Task<BuildHouse.Types.Response> BuildHouseAsync(BuildHouse.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<BuildHouse.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EDB")]
			[Cpp2IlInjected.Address(RVA = "0x765310", Offset = "0x763D10", VA = "0x180765310")]
			[AsyncStateMachine(typeof(_003CBuildHouseAsync_003Ed__218))]
			public Task<BuildHouse.Types.Response> BuildHouseAsync(BuildHouse.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<BuildHouse.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EDC")]
			[Cpp2IlInjected.Address(RVA = "0x781600", Offset = "0x780000", VA = "0x180781600")]
			public Task<TransferToPantry.Types.Response> TransferToPantryAsync(TransferToPantry.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<TransferToPantry.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EDD")]
			[Cpp2IlInjected.Address(RVA = "0x781480", Offset = "0x77FE80", VA = "0x180781480")]
			[AsyncStateMachine(typeof(_003CTransferToPantryAsync_003Ed__220))]
			public Task<TransferToPantry.Types.Response> TransferToPantryAsync(TransferToPantry.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<TransferToPantry.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EDE")]
			[Cpp2IlInjected.Address(RVA = "0x769DE0", Offset = "0x7687E0", VA = "0x180769DE0")]
			public Task<CookWithIngredients.Types.Response> CookWithIngredientsAsync(CookWithIngredients.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<CookWithIngredients.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EDF")]
			[Cpp2IlInjected.Address(RVA = "0x769C60", Offset = "0x768660", VA = "0x180769C60")]
			[AsyncStateMachine(typeof(_003CCookWithIngredientsAsync_003Ed__222))]
			public Task<CookWithIngredients.Types.Response> CookWithIngredientsAsync(CookWithIngredients.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CookWithIngredients.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EE0")]
			[Cpp2IlInjected.Address(RVA = "0x7710A0", Offset = "0x76FAA0", VA = "0x1807710A0")]
			public Task<EatItem.Types.Response> EatItemAsync(EatItem.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<EatItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EE1")]
			[Cpp2IlInjected.Address(RVA = "0x770F20", Offset = "0x76F920", VA = "0x180770F20")]
			[AsyncStateMachine(typeof(_003CEatItemAsync_003Ed__224))]
			public Task<EatItem.Types.Response> EatItemAsync(EatItem.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<EatItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EE2")]
			[Cpp2IlInjected.Address(RVA = "0x783910", Offset = "0x782310", VA = "0x180783910")]
			public Task<UpdateRestaurantOrders.Types.Response> UpdateRestaurantOrdersAsync(UpdateRestaurantOrders.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<UpdateRestaurantOrders.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EE3")]
			[Cpp2IlInjected.Address(RVA = "0x783790", Offset = "0x782190", VA = "0x180783790")]
			[AsyncStateMachine(typeof(_003CUpdateRestaurantOrdersAsync_003Ed__226))]
			public Task<UpdateRestaurantOrders.Types.Response> UpdateRestaurantOrdersAsync(UpdateRestaurantOrders.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<UpdateRestaurantOrders.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EE4")]
			[Cpp2IlInjected.Address(RVA = "0x7733B0", Offset = "0x771DB0", VA = "0x1807733B0")]
			public Task<FulfillRestaurantOrders.Types.Response> FulfillRestaurantOrdersAsync(FulfillRestaurantOrders.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<FulfillRestaurantOrders.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EE5")]
			[Cpp2IlInjected.Address(RVA = "0x773230", Offset = "0x771C30", VA = "0x180773230")]
			[AsyncStateMachine(typeof(_003CFulfillRestaurantOrdersAsync_003Ed__228))]
			public Task<FulfillRestaurantOrders.Types.Response> FulfillRestaurantOrdersAsync(FulfillRestaurantOrders.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<FulfillRestaurantOrders.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EE6")]
			[Cpp2IlInjected.Address(RVA = "0x774220", Offset = "0x772C20", VA = "0x180774220")]
			public Task<HitMiningRock.Types.Response> HitMiningRockAsync(HitMiningRock.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<HitMiningRock.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EE7")]
			[Cpp2IlInjected.Address(RVA = "0x7743D0", Offset = "0x772DD0", VA = "0x1807743D0")]
			[AsyncStateMachine(typeof(_003CHitMiningRockAsync_003Ed__230))]
			public Task<HitMiningRock.Types.Response> HitMiningRockAsync(HitMiningRock.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<HitMiningRock.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EE8")]
			[Cpp2IlInjected.Address(RVA = "0x769F90", Offset = "0x768990", VA = "0x180769F90")]
			public Task<CraftWithRecipe.Types.Response> CraftWithRecipeAsync(CraftWithRecipe.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<CraftWithRecipe.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EE9")]
			[Cpp2IlInjected.Address(RVA = "0x76A140", Offset = "0x768B40", VA = "0x18076A140")]
			[AsyncStateMachine(typeof(_003CCraftWithRecipeAsync_003Ed__232))]
			public Task<CraftWithRecipe.Types.Response> CraftWithRecipeAsync(CraftWithRecipe.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CraftWithRecipe.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EEA")]
			[Cpp2IlInjected.Address(RVA = "0x77B810", Offset = "0x77A210", VA = "0x18077B810")]
			public Task<SetCraftingRecipeAsSeen.Types.Response> SetCraftingRecipeAsSeenAsync(SetCraftingRecipeAsSeen.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SetCraftingRecipeAsSeen.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EEB")]
			[Cpp2IlInjected.Address(RVA = "0x77B9C0", Offset = "0x77A3C0", VA = "0x18077B9C0")]
			[AsyncStateMachine(typeof(_003CSetCraftingRecipeAsSeenAsync_003Ed__234))]
			public Task<SetCraftingRecipeAsSeen.Types.Response> SetCraftingRecipeAsSeenAsync(SetCraftingRecipeAsSeen.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SetCraftingRecipeAsSeen.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EEC")]
			[Cpp2IlInjected.Address(RVA = "0x772D50", Offset = "0x771750", VA = "0x180772D50")]
			public Task<FeedCritter.Types.Response> FeedCritterAsync(FeedCritter.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<FeedCritter.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EED")]
			[Cpp2IlInjected.Address(RVA = "0x772BD0", Offset = "0x7715D0", VA = "0x180772BD0")]
			[AsyncStateMachine(typeof(_003CFeedCritterAsync_003Ed__236))]
			public Task<FeedCritter.Types.Response> FeedCritterAsync(FeedCritter.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<FeedCritter.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EEE")]
			[Cpp2IlInjected.Address(RVA = "0x775ED0", Offset = "0x7748D0", VA = "0x180775ED0")]
			public Task<PetCompanion.Types.Response> PetCompanionAsync(PetCompanion.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<PetCompanion.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EEF")]
			[Cpp2IlInjected.Address(RVA = "0x776080", Offset = "0x774A80", VA = "0x180776080")]
			[AsyncStateMachine(typeof(_003CPetCompanionAsync_003Ed__238))]
			public Task<PetCompanion.Types.Response> PetCompanionAsync(PetCompanion.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PetCompanion.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EF0")]
			[Cpp2IlInjected.Address(RVA = "0x76A5F0", Offset = "0x768FF0", VA = "0x18076A5F0")]
			public Task<DebugAddCurrency.Types.Response> DebugAddCurrencyAsync(DebugAddCurrency.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugAddCurrency.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EF1")]
			[Cpp2IlInjected.Address(RVA = "0x76A7A0", Offset = "0x7691A0", VA = "0x18076A7A0")]
			[AsyncStateMachine(typeof(_003CDebugAddCurrencyAsync_003Ed__240))]
			public Task<DebugAddCurrency.Types.Response> DebugAddCurrencyAsync(DebugAddCurrency.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugAddCurrency.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EF2")]
			[Cpp2IlInjected.Address(RVA = "0x772570", Offset = "0x770F70", VA = "0x180772570")]
			public Task<ExecuteRecurringEvent.Types.Response> ExecuteRecurringEventAsync(ExecuteRecurringEvent.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ExecuteRecurringEvent.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EF3")]
			[Cpp2IlInjected.Address(RVA = "0x772720", Offset = "0x771120", VA = "0x180772720")]
			[AsyncStateMachine(typeof(_003CExecuteRecurringEventAsync_003Ed__242))]
			public Task<ExecuteRecurringEvent.Types.Response> ExecuteRecurringEventAsync(ExecuteRecurringEvent.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ExecuteRecurringEvent.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EF4")]
			[Cpp2IlInjected.Address(RVA = "0x771F10", Offset = "0x770910", VA = "0x180771F10")]
			public Task<ExecuteCampaignEvent.Types.Response> ExecuteCampaignEventAsync(ExecuteCampaignEvent.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ExecuteCampaignEvent.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EF5")]
			[Cpp2IlInjected.Address(RVA = "0x7720C0", Offset = "0x770AC0", VA = "0x1807720C0")]
			[AsyncStateMachine(typeof(_003CExecuteCampaignEventAsync_003Ed__244))]
			public Task<ExecuteCampaignEvent.Types.Response> ExecuteCampaignEventAsync(ExecuteCampaignEvent.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ExecuteCampaignEvent.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EF6")]
			[Cpp2IlInjected.Address(RVA = "0x77D4C0", Offset = "0x77BEC0", VA = "0x18077D4C0")]
			public Task<ShopRefresh.Types.Response> ShopRefreshAsync(ShopRefresh.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ShopRefresh.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EF7")]
			[Cpp2IlInjected.Address(RVA = "0x77D670", Offset = "0x77C070", VA = "0x18077D670")]
			[AsyncStateMachine(typeof(_003CShopRefreshAsync_003Ed__246))]
			public Task<ShopRefresh.Types.Response> ShopRefreshAsync(ShopRefresh.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ShopRefresh.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EF8")]
			[Cpp2IlInjected.Address(RVA = "0x77D190", Offset = "0x77BB90", VA = "0x18077D190")]
			public Task<ShopBuyItem.Types.Response> ShopBuyItemAsync(ShopBuyItem.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ShopBuyItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EF9")]
			[Cpp2IlInjected.Address(RVA = "0x77D340", Offset = "0x77BD40", VA = "0x18077D340")]
			[AsyncStateMachine(typeof(_003CShopBuyItemAsync_003Ed__248))]
			public Task<ShopBuyItem.Types.Response> ShopBuyItemAsync(ShopBuyItem.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ShopBuyItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EFA")]
			[Cpp2IlInjected.Address(RVA = "0x77D970", Offset = "0x77C370", VA = "0x18077D970")]
			public Task<ShopSellItems.Types.Response> ShopSellItemsAsync(ShopSellItems.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ShopSellItems.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EFB")]
			[Cpp2IlInjected.Address(RVA = "0x77D7F0", Offset = "0x77C1F0", VA = "0x18077D7F0")]
			[AsyncStateMachine(typeof(_003CShopSellItemsAsync_003Ed__250))]
			public Task<ShopSellItems.Types.Response> ShopSellItemsAsync(ShopSellItems.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ShopSellItems.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EFC")]
			[Cpp2IlInjected.Address(RVA = "0x780160", Offset = "0x77EB60", VA = "0x180780160")]
			public Task<StoreRefresh.Types.Response> StoreRefreshAsync(StoreRefresh.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<StoreRefresh.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EFD")]
			[Cpp2IlInjected.Address(RVA = "0x780310", Offset = "0x77ED10", VA = "0x180780310")]
			[AsyncStateMachine(typeof(_003CStoreRefreshAsync_003Ed__252))]
			public Task<StoreRefresh.Types.Response> StoreRefreshAsync(StoreRefresh.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<StoreRefresh.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EFE")]
			[Cpp2IlInjected.Address(RVA = "0x77FFB0", Offset = "0x77E9B0", VA = "0x18077FFB0")]
			public Task<StoreBuyItem.Types.Response> StoreBuyItemAsync(StoreBuyItem.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<StoreBuyItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003EFF")]
			[Cpp2IlInjected.Address(RVA = "0x77FE30", Offset = "0x77E830", VA = "0x18077FE30")]
			[AsyncStateMachine(typeof(_003CStoreBuyItemAsync_003Ed__254))]
			public Task<StoreBuyItem.Types.Response> StoreBuyItemAsync(StoreBuyItem.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<StoreBuyItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F00")]
			[Cpp2IlInjected.Address(RVA = "0x773560", Offset = "0x771F60", VA = "0x180773560")]
			public Task<GenericBuyItem.Types.Response> GenericBuyItemAsync(GenericBuyItem.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<GenericBuyItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F01")]
			[Cpp2IlInjected.Address(RVA = "0x773710", Offset = "0x772110", VA = "0x180773710")]
			[AsyncStateMachine(typeof(_003CGenericBuyItemAsync_003Ed__256))]
			public Task<GenericBuyItem.Types.Response> GenericBuyItemAsync(GenericBuyItem.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<GenericBuyItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F02")]
			[Cpp2IlInjected.Address(RVA = "0x773890", Offset = "0x772290", VA = "0x180773890")]
			public Task<GenericSellItems.Types.Response> GenericSellItemsAsync(GenericSellItems.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<GenericSellItems.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F03")]
			[Cpp2IlInjected.Address(RVA = "0x773A40", Offset = "0x772440", VA = "0x180773A40")]
			[AsyncStateMachine(typeof(_003CGenericSellItemsAsync_003Ed__258))]
			public Task<GenericSellItems.Types.Response> GenericSellItemsAsync(GenericSellItems.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<GenericSellItems.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F04")]
			[Cpp2IlInjected.Address(RVA = "0x7657C0", Offset = "0x7641C0", VA = "0x1807657C0")]
			public Task<BuyDeliverySystem.Types.Response> BuyDeliverySystemAsync(BuyDeliverySystem.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<BuyDeliverySystem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F05")]
			[Cpp2IlInjected.Address(RVA = "0x765640", Offset = "0x764040", VA = "0x180765640")]
			[AsyncStateMachine(typeof(_003CBuyDeliverySystemAsync_003Ed__260))]
			public Task<BuyDeliverySystem.Types.Response> BuyDeliverySystemAsync(BuyDeliverySystem.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<BuyDeliverySystem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F06")]
			[Cpp2IlInjected.Address(RVA = "0x769930", Offset = "0x768330", VA = "0x180769930")]
			public Task<ConvertToDreamDust.Types.Response> ConvertToDreamDustAsync(ConvertToDreamDust.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ConvertToDreamDust.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F07")]
			[Cpp2IlInjected.Address(RVA = "0x769AE0", Offset = "0x7684E0", VA = "0x180769AE0")]
			[AsyncStateMachine(typeof(_003CConvertToDreamDustAsync_003Ed__262))]
			public Task<ConvertToDreamDust.Types.Response> ConvertToDreamDustAsync(ConvertToDreamDust.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ConvertToDreamDust.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F08")]
			[Cpp2IlInjected.Address(RVA = "0x765FD0", Offset = "0x7649D0", VA = "0x180765FD0")]
			public Task<BuySoftCurrency.Types.Response> BuySoftCurrencyAsync(BuySoftCurrency.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<BuySoftCurrency.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F09")]
			[Cpp2IlInjected.Address(RVA = "0x766180", Offset = "0x764B80", VA = "0x180766180")]
			[AsyncStateMachine(typeof(_003CBuySoftCurrencyAsync_003Ed__264))]
			public Task<BuySoftCurrency.Types.Response> BuySoftCurrencyAsync(BuySoftCurrency.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<BuySoftCurrency.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F0A")]
			[Cpp2IlInjected.Address(RVA = "0x781930", Offset = "0x780330", VA = "0x180781930")]
			public Task<UnlockBuilding.Types.Response> UnlockBuildingAsync(UnlockBuilding.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<UnlockBuilding.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F0B")]
			[Cpp2IlInjected.Address(RVA = "0x7817B0", Offset = "0x7801B0", VA = "0x1807817B0")]
			[AsyncStateMachine(typeof(_003CUnlockBuildingAsync_003Ed__266))]
			public Task<UnlockBuilding.Types.Response> UnlockBuildingAsync(UnlockBuilding.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<UnlockBuilding.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F0C")]
			[Cpp2IlInjected.Address(RVA = "0x784120", Offset = "0x782B20", VA = "0x180784120")]
			public Task<UpgradeBuilding.Types.Response> UpgradeBuildingAsync(UpgradeBuilding.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<UpgradeBuilding.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F0D")]
			[Cpp2IlInjected.Address(RVA = "0x7842D0", Offset = "0x782CD0", VA = "0x1807842D0")]
			[AsyncStateMachine(typeof(_003CUpgradeBuildingAsync_003Ed__268))]
			public Task<UpgradeBuilding.Types.Response> UpgradeBuildingAsync(UpgradeBuilding.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<UpgradeBuilding.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F0E")]
			[Cpp2IlInjected.Address(RVA = "0x765E20", Offset = "0x764820", VA = "0x180765E20")]
			public Task<BuyOffline.Types.Response> BuyOfflineAsync(BuyOffline.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<BuyOffline.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F0F")]
			[Cpp2IlInjected.Address(RVA = "0x765CA0", Offset = "0x7646A0", VA = "0x180765CA0")]
			[AsyncStateMachine(typeof(_003CBuyOfflineAsync_003Ed__270))]
			public Task<BuyOffline.Types.Response> BuyOfflineAsync(BuyOffline.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<BuyOffline.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F10")]
			[Cpp2IlInjected.Address(RVA = "0x767470", Offset = "0x765E70", VA = "0x180767470")]
			public Task<CheckWeatherChange.Types.Response> CheckWeatherChangeAsync(CheckWeatherChange.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<CheckWeatherChange.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F11")]
			[Cpp2IlInjected.Address(RVA = "0x7672F0", Offset = "0x765CF0", VA = "0x1807672F0")]
			[AsyncStateMachine(typeof(_003CCheckWeatherChangeAsync_003Ed__272))]
			public Task<CheckWeatherChange.Types.Response> CheckWeatherChangeAsync(CheckWeatherChange.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CheckWeatherChange.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F12")]
			[Cpp2IlInjected.Address(RVA = "0x77E7E0", Offset = "0x77D1E0", VA = "0x18077E7E0")]
			public Task<StartFtueEvent.Types.Response> StartFtueEventAsync(StartFtueEvent.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<StartFtueEvent.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F13")]
			[Cpp2IlInjected.Address(RVA = "0x77E990", Offset = "0x77D390", VA = "0x18077E990")]
			[AsyncStateMachine(typeof(_003CStartFtueEventAsync_003Ed__274))]
			public Task<StartFtueEvent.Types.Response> StartFtueEventAsync(StartFtueEvent.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<StartFtueEvent.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F14")]
			[Cpp2IlInjected.Address(RVA = "0x771580", Offset = "0x76FF80", VA = "0x180771580")]
			public Task<EndFtueEvent.Types.Response> EndFtueEventAsync(EndFtueEvent.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<EndFtueEvent.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F15")]
			[Cpp2IlInjected.Address(RVA = "0x771730", Offset = "0x770130", VA = "0x180771730")]
			[AsyncStateMachine(typeof(_003CEndFtueEventAsync_003Ed__276))]
			public Task<EndFtueEvent.Types.Response> EndFtueEventAsync(EndFtueEvent.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<EndFtueEvent.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F16")]
			[Cpp2IlInjected.Address(RVA = "0x76DDA0", Offset = "0x76C7A0", VA = "0x18076DDA0")]
			public Task<DebugResetFtueEvent.Types.Response> DebugResetFtueEventAsync(DebugResetFtueEvent.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugResetFtueEvent.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F17")]
			[Cpp2IlInjected.Address(RVA = "0x76DC20", Offset = "0x76C620", VA = "0x18076DC20")]
			[AsyncStateMachine(typeof(_003CDebugResetFtueEventAsync_003Ed__278))]
			public Task<DebugResetFtueEvent.Types.Response> DebugResetFtueEventAsync(DebugResetFtueEvent.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugResetFtueEvent.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F18")]
			[Cpp2IlInjected.Address(RVA = "0x77C650", Offset = "0x77B050", VA = "0x18077C650")]
			public Task<SetHudApparition.Types.Response> SetHudApparitionAsync(SetHudApparition.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SetHudApparition.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F19")]
			[Cpp2IlInjected.Address(RVA = "0x77C4D0", Offset = "0x77AED0", VA = "0x18077C4D0")]
			[AsyncStateMachine(typeof(_003CSetHudApparitionAsync_003Ed__280))]
			public Task<SetHudApparition.Types.Response> SetHudApparitionAsync(SetHudApparition.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SetHudApparition.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F1A")]
			[Cpp2IlInjected.Address(RVA = "0x772A20", Offset = "0x771420", VA = "0x180772A20")]
			public Task<ExpandPlayerHouseRoom.Types.Response> ExpandPlayerHouseRoomAsync(ExpandPlayerHouseRoom.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ExpandPlayerHouseRoom.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F1B")]
			[Cpp2IlInjected.Address(RVA = "0x7728A0", Offset = "0x7712A0", VA = "0x1807728A0")]
			[AsyncStateMachine(typeof(_003CExpandPlayerHouseRoomAsync_003Ed__282))]
			public Task<ExpandPlayerHouseRoom.Types.Response> ExpandPlayerHouseRoomAsync(ExpandPlayerHouseRoom.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ExpandPlayerHouseRoom.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F1C")]
			[Cpp2IlInjected.Address(RVA = "0x774EE0", Offset = "0x7738E0", VA = "0x180774EE0")]
			public Task<ManagePlayerHouseRoom.Types.Response> ManagePlayerHouseRoomAsync(ManagePlayerHouseRoom.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ManagePlayerHouseRoom.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F1D")]
			[Cpp2IlInjected.Address(RVA = "0x775090", Offset = "0x773A90", VA = "0x180775090")]
			[AsyncStateMachine(typeof(_003CManagePlayerHouseRoomAsync_003Ed__284))]
			public Task<ManagePlayerHouseRoom.Types.Response> ManagePlayerHouseRoomAsync(ManagePlayerHouseRoom.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ManagePlayerHouseRoom.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F1E")]
			[Cpp2IlInjected.Address(RVA = "0x7647D0", Offset = "0x7631D0", VA = "0x1807647D0")]
			public Task<AddPlayerHouseFloor.Types.Response> AddPlayerHouseFloorAsync(AddPlayerHouseFloor.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<AddPlayerHouseFloor.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F1F")]
			[Cpp2IlInjected.Address(RVA = "0x764650", Offset = "0x763050", VA = "0x180764650")]
			[AsyncStateMachine(typeof(_003CAddPlayerHouseFloorAsync_003Ed__286))]
			public Task<AddPlayerHouseFloor.Types.Response> AddPlayerHouseFloorAsync(AddPlayerHouseFloor.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<AddPlayerHouseFloor.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F20")]
			[Cpp2IlInjected.Address(RVA = "0x766C90", Offset = "0x765690", VA = "0x180766C90")]
			public Task<ChangePlayerHouseFlooring.Types.Response> ChangePlayerHouseFlooringAsync(ChangePlayerHouseFlooring.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ChangePlayerHouseFlooring.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F21")]
			[Cpp2IlInjected.Address(RVA = "0x766E40", Offset = "0x765840", VA = "0x180766E40")]
			[AsyncStateMachine(typeof(_003CChangePlayerHouseFlooringAsync_003Ed__288))]
			public Task<ChangePlayerHouseFlooring.Types.Response> ChangePlayerHouseFlooringAsync(ChangePlayerHouseFlooring.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ChangePlayerHouseFlooring.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F22")]
			[Cpp2IlInjected.Address(RVA = "0x767140", Offset = "0x765B40", VA = "0x180767140")]
			public Task<ChangePlayerHouseWallpaper.Types.Response> ChangePlayerHouseWallpaperAsync(ChangePlayerHouseWallpaper.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ChangePlayerHouseWallpaper.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F23")]
			[Cpp2IlInjected.Address(RVA = "0x766FC0", Offset = "0x7659C0", VA = "0x180766FC0")]
			[AsyncStateMachine(typeof(_003CChangePlayerHouseWallpaperAsync_003Ed__290))]
			public Task<ChangePlayerHouseWallpaper.Types.Response> ChangePlayerHouseWallpaperAsync(ChangePlayerHouseWallpaper.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ChangePlayerHouseWallpaper.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F24")]
			[Cpp2IlInjected.Address(RVA = "0x7667B0", Offset = "0x7651B0", VA = "0x1807667B0")]
			public Task<ChangeCurrentPet.Types.Response> ChangeCurrentPetAsync(ChangeCurrentPet.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ChangeCurrentPet.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F25")]
			[Cpp2IlInjected.Address(RVA = "0x766630", Offset = "0x765030", VA = "0x180766630")]
			[AsyncStateMachine(typeof(_003CChangeCurrentPetAsync_003Ed__292))]
			public Task<ChangeCurrentPet.Types.Response> ChangeCurrentPetAsync(ChangeCurrentPet.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ChangeCurrentPet.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F26")]
			[Cpp2IlInjected.Address(RVA = "0x77F620", Offset = "0x77E020", VA = "0x18077F620")]
			public Task<StartPendingBurningState.Types.Response> StartPendingBurningStateAsync(StartPendingBurningState.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<StartPendingBurningState.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F27")]
			[Cpp2IlInjected.Address(RVA = "0x77F4A0", Offset = "0x77DEA0", VA = "0x18077F4A0")]
			[AsyncStateMachine(typeof(_003CStartPendingBurningStateAsync_003Ed__294))]
			public Task<StartPendingBurningState.Types.Response> StartPendingBurningStateAsync(StartPendingBurningState.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<StartPendingBurningState.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F28")]
			[Cpp2IlInjected.Address(RVA = "0x767FB0", Offset = "0x7669B0", VA = "0x180767FB0")]
			public Task<CollectBurningState.Types.Response> CollectBurningStateAsync(CollectBurningState.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<CollectBurningState.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F29")]
			[Cpp2IlInjected.Address(RVA = "0x768160", Offset = "0x766B60", VA = "0x180768160")]
			[AsyncStateMachine(typeof(_003CCollectBurningStateAsync_003Ed__296))]
			public Task<CollectBurningState.Types.Response> CollectBurningStateAsync(CollectBurningState.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CollectBurningState.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F2A")]
			[Cpp2IlInjected.Address(RVA = "0x767950", Offset = "0x766350", VA = "0x180767950")]
			public Task<ClearBurningState.Types.Response> ClearBurningStateAsync(ClearBurningState.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ClearBurningState.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F2B")]
			[Cpp2IlInjected.Address(RVA = "0x767B00", Offset = "0x766500", VA = "0x180767B00")]
			[AsyncStateMachine(typeof(_003CClearBurningStateAsync_003Ed__298))]
			public Task<ClearBurningState.Types.Response> ClearBurningStateAsync(ClearBurningState.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ClearBurningState.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F2C")]
			[Cpp2IlInjected.Address(RVA = "0x778030", Offset = "0x776A30", VA = "0x180778030")]
			public Task<PullWeed.Types.Response> PullWeedAsync(PullWeed.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<PullWeed.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F2D")]
			[Cpp2IlInjected.Address(RVA = "0x777EB0", Offset = "0x7768B0", VA = "0x180777EB0")]
			[AsyncStateMachine(typeof(_003CPullWeedAsync_003Ed__300))]
			public Task<PullWeed.Types.Response> PullWeedAsync(PullWeed.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PullWeed.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F2E")]
			[Cpp2IlInjected.Address(RVA = "0x77EE40", Offset = "0x77D840", VA = "0x18077EE40")]
			public Task<StartItemCollectMinigame.Types.Response> StartItemCollectMinigameAsync(StartItemCollectMinigame.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<StartItemCollectMinigame.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F2F")]
			[Cpp2IlInjected.Address(RVA = "0x77EFF0", Offset = "0x77D9F0", VA = "0x18077EFF0")]
			[AsyncStateMachine(typeof(_003CStartItemCollectMinigameAsync_003Ed__302))]
			public Task<StartItemCollectMinigame.Types.Response> StartItemCollectMinigameAsync(StartItemCollectMinigame.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<StartItemCollectMinigame.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F30")]
			[Cpp2IlInjected.Address(RVA = "0x768FA0", Offset = "0x7679A0", VA = "0x180768FA0")]
			public Task<CollectMinigameItem.Types.Response> CollectMinigameItemAsync(CollectMinigameItem.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<CollectMinigameItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F31")]
			[Cpp2IlInjected.Address(RVA = "0x769150", Offset = "0x767B50", VA = "0x180769150")]
			[AsyncStateMachine(typeof(_003CCollectMinigameItemAsync_003Ed__304))]
			public Task<CollectMinigameItem.Types.Response> CollectMinigameItemAsync(CollectMinigameItem.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CollectMinigameItem.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F32")]
			[Cpp2IlInjected.Address(RVA = "0x77FC80", Offset = "0x77E680", VA = "0x18077FC80")]
			public Task<StopItemCollectMinigame.Types.Response> StopItemCollectMinigameAsync(StopItemCollectMinigame.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<StopItemCollectMinigame.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F33")]
			[Cpp2IlInjected.Address(RVA = "0x77FB00", Offset = "0x77E500", VA = "0x18077FB00")]
			[AsyncStateMachine(typeof(_003CStopItemCollectMinigameAsync_003Ed__306))]
			public Task<StopItemCollectMinigame.Types.Response> StopItemCollectMinigameAsync(StopItemCollectMinigame.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<StopItemCollectMinigame.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F34")]
			[Cpp2IlInjected.Address(RVA = "0x783AC0", Offset = "0x7824C0", VA = "0x180783AC0")]
			public Task<UpdateRoyalDutySlots.Types.Response> UpdateRoyalDutySlotsAsync(UpdateRoyalDutySlots.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<UpdateRoyalDutySlots.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F35")]
			[Cpp2IlInjected.Address(RVA = "0x783C70", Offset = "0x782670", VA = "0x180783C70")]
			[AsyncStateMachine(typeof(_003CUpdateRoyalDutySlotsAsync_003Ed__308))]
			public Task<UpdateRoyalDutySlots.Types.Response> UpdateRoyalDutySlotsAsync(UpdateRoyalDutySlots.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<UpdateRoyalDutySlots.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F36")]
			[Cpp2IlInjected.Address(RVA = "0x7692D0", Offset = "0x767CD0", VA = "0x1807692D0")]
			public Task<CollectRoyalDutyReward.Types.Response> CollectRoyalDutyRewardAsync(CollectRoyalDutyReward.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<CollectRoyalDutyReward.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F37")]
			[Cpp2IlInjected.Address(RVA = "0x769480", Offset = "0x767E80", VA = "0x180769480")]
			[AsyncStateMachine(typeof(_003CCollectRoyalDutyRewardAsync_003Ed__310))]
			public Task<CollectRoyalDutyReward.Types.Response> CollectRoyalDutyRewardAsync(CollectRoyalDutyReward.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CollectRoyalDutyReward.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F38")]
			[Cpp2IlInjected.Address(RVA = "0x76CF60", Offset = "0x76B960", VA = "0x18076CF60")]
			public Task<DebugGenerateNewRoyalDuties.Types.Response> DebugGenerateNewRoyalDutiesAsync(DebugGenerateNewRoyalDuties.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugGenerateNewRoyalDuties.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F39")]
			[Cpp2IlInjected.Address(RVA = "0x76D110", Offset = "0x76BB10", VA = "0x18076D110")]
			[AsyncStateMachine(typeof(_003CDebugGenerateNewRoyalDutiesAsync_003Ed__312))]
			public Task<DebugGenerateNewRoyalDuties.Types.Response> DebugGenerateNewRoyalDutiesAsync(DebugGenerateNewRoyalDuties.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugGenerateNewRoyalDuties.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F3A")]
			[Cpp2IlInjected.Address(RVA = "0x767E00", Offset = "0x766800", VA = "0x180767E00")]
			public Task<CollectAchievementReward.Types.Response> CollectAchievementRewardAsync(CollectAchievementReward.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<CollectAchievementReward.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F3B")]
			[Cpp2IlInjected.Address(RVA = "0x767C80", Offset = "0x766680", VA = "0x180767C80")]
			[AsyncStateMachine(typeof(_003CCollectAchievementRewardAsync_003Ed__314))]
			public Task<CollectAchievementReward.Types.Response> CollectAchievementRewardAsync(CollectAchievementReward.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CollectAchievementReward.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F3C")]
			[Cpp2IlInjected.Address(RVA = "0x76B910", Offset = "0x76A310", VA = "0x18076B910")]
			public Task<DebugCompleteAchievementMilestone.Types.Response> DebugCompleteAchievementMilestoneAsync(DebugCompleteAchievementMilestone.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugCompleteAchievementMilestone.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F3D")]
			[Cpp2IlInjected.Address(RVA = "0x76BAC0", Offset = "0x76A4C0", VA = "0x18076BAC0")]
			[AsyncStateMachine(typeof(_003CDebugCompleteAchievementMilestoneAsync_003Ed__316))]
			public Task<DebugCompleteAchievementMilestone.Types.Response> DebugCompleteAchievementMilestoneAsync(DebugCompleteAchievementMilestone.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugCompleteAchievementMilestone.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F3E")]
			[Cpp2IlInjected.Address(RVA = "0x783DF0", Offset = "0x7827F0", VA = "0x180783DF0")]
			public Task<UpdateTimeAcumulated.Types.Response> UpdateTimeAcumulatedAsync(UpdateTimeAcumulated.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<UpdateTimeAcumulated.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F3F")]
			[Cpp2IlInjected.Address(RVA = "0x783FA0", Offset = "0x7829A0", VA = "0x180783FA0")]
			[AsyncStateMachine(typeof(_003CUpdateTimeAcumulatedAsync_003Ed__318))]
			public Task<UpdateTimeAcumulated.Types.Response> UpdateTimeAcumulatedAsync(UpdateTimeAcumulated.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<UpdateTimeAcumulated.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F40")]
			[Cpp2IlInjected.Address(RVA = "0x781E10", Offset = "0x780810", VA = "0x180781E10")]
			public Task<UnlockStorage.Types.Response> UnlockStorageAsync(UnlockStorage.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<UnlockStorage.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F41")]
			[Cpp2IlInjected.Address(RVA = "0x781FC0", Offset = "0x7809C0", VA = "0x180781FC0")]
			[AsyncStateMachine(typeof(_003CUnlockStorageAsync_003Ed__320))]
			public Task<UnlockStorage.Types.Response> UnlockStorageAsync(UnlockStorage.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<UnlockStorage.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F42")]
			[Cpp2IlInjected.Address(RVA = "0x77AE80", Offset = "0x779880", VA = "0x18077AE80")]
			public Task<SendItemsToInbox.Types.Response> SendItemsToInboxAsync(SendItemsToInbox.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SendItemsToInbox.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F43")]
			[Cpp2IlInjected.Address(RVA = "0x77B030", Offset = "0x779A30", VA = "0x18077B030")]
			[AsyncStateMachine(typeof(_003CSendItemsToInboxAsync_003Ed__322))]
			public Task<SendItemsToInbox.Types.Response> SendItemsToInboxAsync(SendItemsToInbox.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SendItemsToInbox.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F44")]
			[Cpp2IlInjected.Address(RVA = "0x782470", Offset = "0x780E70", VA = "0x180782470")]
			public Task<UpdateBattlePassTasksProgression.Types.Response> UpdateBattlePassTasksProgressionAsync(UpdateBattlePassTasksProgression.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<UpdateBattlePassTasksProgression.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F45")]
			[Cpp2IlInjected.Address(RVA = "0x782620", Offset = "0x781020", VA = "0x180782620")]
			[AsyncStateMachine(typeof(_003CUpdateBattlePassTasksProgressionAsync_003Ed__324))]
			public Task<UpdateBattlePassTasksProgression.Types.Response> UpdateBattlePassTasksProgressionAsync(UpdateBattlePassTasksProgression.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<UpdateBattlePassTasksProgression.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F46")]
			[Cpp2IlInjected.Address(RVA = "0x783130", Offset = "0x781B30", VA = "0x180783130")]
			public Task<UpdateOnlineShopStates.Types.Response> UpdateOnlineShopStatesAsync(UpdateOnlineShopStates.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<UpdateOnlineShopStates.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003F47")]
			[Cpp2IlInjected.Address(RVA = "0x7832E0", Offset = "0x781CE0", VA = "0x1807832E0")]
			[AsyncStateMachine(typeof(_003CUpdateOnlineShopStatesAsync_003Ed__326))]
			public Task<UpdateOnlineShopStates.Types.Response> UpdateOnlineShopStatesAsync(UpdateOnlineShopStates.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<UpdateOnlineShopStates.Types.Response>)(object)result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40011CD")]
		private static readonly MethodDescriptor PingMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011CE")]
		private static readonly MethodDescriptor SaveProfileMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011CF")]
		private static readonly MethodDescriptor ChangeCurrentSceneMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011D0")]
		private static readonly MethodDescriptor SetManaHasAlreadyMissedMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011D1")]
		private static readonly MethodDescriptor EnterRealmMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011D2")]
		private static readonly MethodDescriptor UnlockRealmMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011D3")]
		private static readonly MethodDescriptor PlaceOnGridMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011D4")]
		private static readonly MethodDescriptor RemoveFromGridMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011D5")]
		private static readonly MethodDescriptor RemoveBlockerMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011D6")]
		private static readonly MethodDescriptor LoginMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011D7")]
		private static readonly MethodDescriptor ActualizeMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011D8")]
		private static readonly MethodDescriptor InitWithServerProfileMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011D9")]
		private static readonly MethodDescriptor SetNameMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011DA")]
		private static readonly MethodDescriptor TrackClaimedFoundersPackMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011DB")]
		private static readonly MethodDescriptor PickUpContainerItemMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011DC")]
		private static readonly MethodDescriptor PutDownContainerItemMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011DD")]
		private static readonly MethodDescriptor DropContainerInventoryStackMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011DE")]
		private static readonly MethodDescriptor PickUpListItemMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011DF")]
		private static readonly MethodDescriptor PutDownListItemMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011E0")]
		private static readonly MethodDescriptor PickUpItemMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011E1")]
		private static readonly MethodDescriptor PlaceLandscapingItemMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011E2")]
		private static readonly MethodDescriptor UpdateGridObjectTransformMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011E3")]
		private static readonly MethodDescriptor SwitchGridObjectGridMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011E4")]
		private static readonly MethodDescriptor ReplaceGridObjectMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011E5")]
		private static readonly MethodDescriptor MoveInContainerInventoryMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011E6")]
		private static readonly MethodDescriptor SortContainerInventoryMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011E7")]
		private static readonly MethodDescriptor SmartInventoryTransferMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011E8")]
		private static readonly MethodDescriptor AddItemToKeyholeMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011E9")]
		private static readonly MethodDescriptor RemoveItemFromKeyholeMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011EA")]
		private static readonly MethodDescriptor SwapItemInKeyholeMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011EB")]
		private static readonly MethodDescriptor SetFurnitureToggleStateMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011EC")]
		private static readonly MethodDescriptor SetFurnitureIndexStateMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011ED")]
		private static readonly MethodDescriptor CollectLootPresentMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011EE")]
		private static readonly MethodDescriptor CollectConsummableMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011EF")]
		private static readonly MethodDescriptor ConsumeItemMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011F0")]
		private static readonly MethodDescriptor SwitchPictureFrameMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011F1")]
		private static readonly MethodDescriptor BuyItemMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011F2")]
		private static readonly MethodDescriptor AvatarTransferMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011F3")]
		private static readonly MethodDescriptor SetAvatarCustomizationMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011F4")]
		private static readonly MethodDescriptor SaveClothingDesignMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011F5")]
		private static readonly MethodDescriptor DeleteClothingDesignMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011F6")]
		private static readonly MethodDescriptor SetFurnitureCustomizationMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011F7")]
		private static readonly MethodDescriptor SaveFurnitureDesignMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011F8")]
		private static readonly MethodDescriptor DeleteFurnitureDesignMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011F9")]
		private static readonly MethodDescriptor EnableCharacterMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011FA")]
		private static readonly MethodDescriptor DiscussWithCharacterMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011FB")]
		private static readonly MethodDescriptor ResetCharacterDiscussionsMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011FC")]
		private static readonly MethodDescriptor GiveItemsToCharacterMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011FD")]
		private static readonly MethodDescriptor SetCharacterPreferredItemsAsSeenMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011FE")]
		private static readonly MethodDescriptor UpdateCharacterSchedulesMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40011FF")]
		private static readonly MethodDescriptor SecretCharacterDiscoveredMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001200")]
		private static readonly MethodDescriptor ApplyCharacterProfessionMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001201")]
		private static readonly MethodDescriptor ChangeCharacterProfessionMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001202")]
		private static readonly MethodDescriptor ApplyCharacterSkinMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001203")]
		private static readonly MethodDescriptor UnlockVillageAreaMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001204")]
		private static readonly MethodDescriptor ExecuteDailyResetMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001205")]
		private static readonly MethodDescriptor MeditateMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001206")]
		private static readonly MethodDescriptor DebugUnlockCharacterMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001207")]
		private static readonly MethodDescriptor DebugStartEventMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001208")]
		private static readonly MethodDescriptor DebugEndEventMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001209")]
		private static readonly MethodDescriptor DebugSkipTimeMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400120A")]
		private static readonly MethodDescriptor DebugGenericCheatMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400120B")]
		private static readonly MethodDescriptor DebugAddItemMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400120C")]
		private static readonly MethodDescriptor DebugRemoveItemMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400120D")]
		private static readonly MethodDescriptor DebugAddFriendshipMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400120E")]
		private static readonly MethodDescriptor DebugAddPlayerXPMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400120F")]
		private static readonly MethodDescriptor DebugSetPlayerLevelMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001210")]
		private static readonly MethodDescriptor DebugAddFreeTimerMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001211")]
		private static readonly MethodDescriptor DebugForceActivityBonusRewardMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001212")]
		private static readonly MethodDescriptor DebugForceBurningStateMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001213")]
		private static readonly MethodDescriptor DebugForceSecretCharacterMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001214")]
		private static readonly MethodDescriptor DebugUnlockAllCrittersMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001215")]
		private static readonly MethodDescriptor DebugUnlockVillageAreaMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001216")]
		private static readonly MethodDescriptor DebugUnlockAllBuildingsMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001217")]
		private static readonly MethodDescriptor DebugUnlockAllRealmsMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001218")]
		private static readonly MethodDescriptor DebugUnlockCharacterPreferredItemsMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001219")]
		private static readonly MethodDescriptor DebugRemoveAllForagingItemsMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400121A")]
		private static readonly MethodDescriptor DebugEmptyAllActivitySourcesMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400121B")]
		private static readonly MethodDescriptor DebugFakeRPCExceptionMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400121C")]
		private static readonly MethodDescriptor EndMissionMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400121D")]
		private static readonly MethodDescriptor InitTLEMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400121E")]
		private static readonly MethodDescriptor ClaimMiniEventRewardMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400121F")]
		private static readonly MethodDescriptor StartMissionMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001220")]
		private static readonly MethodDescriptor UpdateDialogueFlagsMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001221")]
		private static readonly MethodDescriptor TrackMissionMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001222")]
		private static readonly MethodDescriptor SetMissionNextChoiceMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001223")]
		private static readonly MethodDescriptor PictureTakenMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001224")]
		private static readonly MethodDescriptor MissionItemInteractionMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001225")]
		private static readonly MethodDescriptor MissionCompleteStepMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001226")]
		private static readonly MethodDescriptor DebugCancelMissionMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001227")]
		private static readonly MethodDescriptor DebugTestMissionMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001228")]
		private static readonly MethodDescriptor DebugSkipMissionStepMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001229")]
		private static readonly MethodDescriptor CreateGardeningTileMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400122A")]
		private static readonly MethodDescriptor RemoveGardeningTileMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400122B")]
		private static readonly MethodDescriptor PlantSeedMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400122C")]
		private static readonly MethodDescriptor FinishGardeningSlotGrowthMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400122D")]
		private static readonly MethodDescriptor HarvestGardeningSlotMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400122E")]
		private static readonly MethodDescriptor CollectGardenStallSlotMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400122F")]
		private static readonly MethodDescriptor WaterObjectsMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001230")]
		private static readonly MethodDescriptor StartFishingMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001231")]
		private static readonly MethodDescriptor SendFishingResultMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001232")]
		private static readonly MethodDescriptor UpdatePendingFishesMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001233")]
		private static readonly MethodDescriptor CollectFishingStallMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001234")]
		private static readonly MethodDescriptor StartHangoutWithCharacterMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001235")]
		private static readonly MethodDescriptor StopHangoutWithCharacterMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001236")]
		private static readonly MethodDescriptor SpawnHangoutRewardsForCharacterMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001237")]
		private static readonly MethodDescriptor PlaceBuildingMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001238")]
		private static readonly MethodDescriptor RemoveHouseMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001239")]
		private static readonly MethodDescriptor BuildHouseMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400123A")]
		private static readonly MethodDescriptor TransferToPantryMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400123B")]
		private static readonly MethodDescriptor CookWithIngredientsMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400123C")]
		private static readonly MethodDescriptor EatItemMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400123D")]
		private static readonly MethodDescriptor UpdateRestaurantOrdersMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400123E")]
		private static readonly MethodDescriptor FulfillRestaurantOrdersMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400123F")]
		private static readonly MethodDescriptor HitMiningRockMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001240")]
		private static readonly MethodDescriptor CraftWithRecipeMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001241")]
		private static readonly MethodDescriptor SetCraftingRecipeAsSeenMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001242")]
		private static readonly MethodDescriptor FeedCritterMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001243")]
		private static readonly MethodDescriptor PetCompanionMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001244")]
		private static readonly MethodDescriptor DebugAddCurrencyMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001245")]
		private static readonly MethodDescriptor ExecuteRecurringEventMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001246")]
		private static readonly MethodDescriptor ExecuteCampaignEventMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001247")]
		private static readonly MethodDescriptor ShopRefreshMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001248")]
		private static readonly MethodDescriptor ShopBuyItemMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001249")]
		private static readonly MethodDescriptor ShopSellItemsMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400124A")]
		private static readonly MethodDescriptor StoreRefreshMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400124B")]
		private static readonly MethodDescriptor StoreBuyItemMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400124C")]
		private static readonly MethodDescriptor GenericBuyItemMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400124D")]
		private static readonly MethodDescriptor GenericSellItemsMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400124E")]
		private static readonly MethodDescriptor BuyDeliverySystemMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400124F")]
		private static readonly MethodDescriptor ConvertToDreamDustMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001250")]
		private static readonly MethodDescriptor BuySoftCurrencyMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001251")]
		private static readonly MethodDescriptor UnlockBuildingMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001252")]
		private static readonly MethodDescriptor UpgradeBuildingMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001253")]
		private static readonly MethodDescriptor BuyOfflineMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001254")]
		private static readonly MethodDescriptor CheckWeatherChangeMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001255")]
		private static readonly MethodDescriptor StartFtueEventMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001256")]
		private static readonly MethodDescriptor EndFtueEventMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001257")]
		private static readonly MethodDescriptor DebugResetFtueEventMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001258")]
		private static readonly MethodDescriptor SetHudApparitionMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001259")]
		private static readonly MethodDescriptor ExpandPlayerHouseRoomMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400125A")]
		private static readonly MethodDescriptor ManagePlayerHouseRoomMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400125B")]
		private static readonly MethodDescriptor AddPlayerHouseFloorMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400125C")]
		private static readonly MethodDescriptor ChangePlayerHouseFlooringMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400125D")]
		private static readonly MethodDescriptor ChangePlayerHouseWallpaperMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400125E")]
		private static readonly MethodDescriptor ChangeCurrentPetMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400125F")]
		private static readonly MethodDescriptor StartPendingBurningStateMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001260")]
		private static readonly MethodDescriptor CollectBurningStateMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001261")]
		private static readonly MethodDescriptor ClearBurningStateMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001262")]
		private static readonly MethodDescriptor PullWeedMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001263")]
		private static readonly MethodDescriptor StartItemCollectMinigameMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001264")]
		private static readonly MethodDescriptor CollectMinigameItemMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001265")]
		private static readonly MethodDescriptor StopItemCollectMinigameMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001266")]
		private static readonly MethodDescriptor UpdateRoyalDutySlotsMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001267")]
		private static readonly MethodDescriptor CollectRoyalDutyRewardMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001268")]
		private static readonly MethodDescriptor DebugGenerateNewRoyalDutiesMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4001269")]
		private static readonly MethodDescriptor CollectAchievementRewardMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400126A")]
		private static readonly MethodDescriptor DebugCompleteAchievementMilestoneMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400126B")]
		private static readonly MethodDescriptor UpdateTimeAcumulatedMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400126C")]
		private static readonly MethodDescriptor UnlockStorageMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400126D")]
		private static readonly MethodDescriptor SendItemsToInboxMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400126E")]
		private static readonly MethodDescriptor UpdateBattlePassTasksProgressionMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400126F")]
		private static readonly MethodDescriptor UpdateOnlineShopStatesMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x17000A75")]
		[field: Cpp2IlInjected.Token(Token = "0x40011CC")]
		public static ServiceDescriptor ServiceDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60038E4")]
			[Cpp2IlInjected.Address(RVA = "0x7AD710", Offset = "0x7AC110", VA = "0x1807AD710")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60038E5")]
		[Cpp2IlInjected.Address(RVA = "0x7A7F20", Offset = "0x7A6920", VA = "0x1807A7F20")]
		static TransactionService()
		{
			ServiceDescriptor serviceDescriptor = default(ServiceDescriptor);
			ServiceDescriptor = serviceDescriptor;
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("Ping");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("SaveProfile");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("ChangeCurrentScene");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("SetManaHasAlreadyMissed");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("EnterRealm");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("UnlockRealm");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("PlaceOnGrid");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("RemoveFromGrid");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("RemoveBlocker");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("Login");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("Actualize");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("InitWithServerProfile");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("SetName");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("TrackClaimedFoundersPack");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("PickUpContainerItem");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("PutDownContainerItem");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("DropContainerInventoryStack");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("PickUpListItem");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("PutDownListItem");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("PickUpItem");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("PlaceLandscapingItem");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("UpdateGridObjectTransform");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("SwitchGridObjectGrid");
			/*Error: Unexpected end of block*/;
		}
	}
}
