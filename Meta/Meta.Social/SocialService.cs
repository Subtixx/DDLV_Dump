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

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000D0A")]
	public static class SocialService
	{
		[Cpp2IlInjected.Token(Token = "0x2000D0B")]
		public class SocialServiceBase : ServiceBase
		{
			[Cpp2IlInjected.Token(Token = "0x6006FCB")]
			[Cpp2IlInjected.Address(RVA = "0xC7A800", Offset = "0xC79200", VA = "0x180C7A800")]
			public SocialServiceBase()
				: base(ServiceDescriptor.Name)
			{
				MethodDescriptor loginMethodDesc = LoginMethodDesc;
				RpcMethodBinding.MethodInvokerDelegate methodInvoker = LoginInvokerAsync;
				RpcMethodBinding.MethodImplDelegate methodImpl = LoginAsyncStub;
				RpcMethodBinding.CreateRequestDelegate _003C_003E9__0_ = _003C_003Ec._003C_003E9__0_0;
				if (_003C_003E9__0_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(RpcMethodBinding.CreateRequestDelegate)(() => null);
				}
				RpcMethodBinding methodBinding = new RpcMethodBinding(loginMethodDesc, methodInvoker, methodImpl, _003C_003E9__0_);
				int num = 0;
				AddMethod(methodBinding);
				MethodDescriptor postLoginMethodDesc = PostLoginMethodDesc;
				RpcMethodBinding.MethodInvokerDelegate methodInvoker2 = PostLoginInvokerAsync;
				RpcMethodBinding.MethodImplDelegate methodImpl2 = PostLoginAsyncStub;
				RpcMethodBinding.CreateRequestDelegate createRequest = default(RpcMethodBinding.CreateRequestDelegate);
				if (_003C_003Ec._003C_003E9__0_1 == null)
				{
					createRequest = (RpcMethodBinding.CreateRequestDelegate)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(RpcMethodBinding.CreateRequestDelegate)(() => null));
				}
				RpcMethodBinding methodBinding2 = new RpcMethodBinding(postLoginMethodDesc, methodInvoker2, methodImpl2, createRequest);
				AddMethod(methodBinding2);
				MethodDescriptor autoRedeemFoundersPackMethodDesc = AutoRedeemFoundersPackMethodDesc;
				RpcMethodBinding.MethodInvokerDelegate methodInvoker3 = AutoRedeemFoundersPackInvokerAsync;
				RpcMethodBinding.MethodImplDelegate methodImpl3 = AutoRedeemFoundersPackAsyncStub;
				RpcMethodBinding.CreateRequestDelegate createRequest2 = default(RpcMethodBinding.CreateRequestDelegate);
				if (_003C_003Ec._003C_003E9__0_2 == null)
				{
					createRequest2 = (RpcMethodBinding.CreateRequestDelegate)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(RpcMethodBinding.CreateRequestDelegate)(() => null));
				}
				RpcMethodBinding methodBinding3 = new RpcMethodBinding(autoRedeemFoundersPackMethodDesc, methodInvoker3, methodImpl3, createRequest2);
				AddMethod(methodBinding3);
				MethodDescriptor transferMarketplacePacksMethodDesc = TransferMarketplacePacksMethodDesc;
				RpcMethodBinding.MethodInvokerDelegate methodInvoker4 = TransferMarketplacePacksInvokerAsync;
				RpcMethodBinding.MethodImplDelegate methodImpl4 = TransferMarketplacePacksAsyncStub;
				RpcMethodBinding.CreateRequestDelegate createRequest3 = default(RpcMethodBinding.CreateRequestDelegate);
				if (_003C_003Ec._003C_003E9__0_3 == null)
				{
					createRequest3 = (RpcMethodBinding.CreateRequestDelegate)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(RpcMethodBinding.CreateRequestDelegate)(() => null));
				}
				RpcMethodBinding methodBinding4 = new RpcMethodBinding(transferMarketplacePacksMethodDesc, methodInvoker4, methodImpl4, createRequest3);
				AddMethod(methodBinding4);
				MethodDescriptor getFilesMethodDesc = GetFilesMethodDesc;
				RpcMethodBinding.MethodInvokerDelegate methodInvoker5 = GetFilesInvokerAsync;
				RpcMethodBinding.MethodImplDelegate methodImpl5 = GetFilesAsyncStub;
				RpcMethodBinding.CreateRequestDelegate createRequest4 = default(RpcMethodBinding.CreateRequestDelegate);
				if (_003C_003Ec._003C_003E9__0_4 == null)
				{
					createRequest4 = (RpcMethodBinding.CreateRequestDelegate)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(RpcMethodBinding.CreateRequestDelegate)(() => null));
				}
				RpcMethodBinding methodBinding5 = new RpcMethodBinding(getFilesMethodDesc, methodInvoker5, methodImpl5, createRequest4);
				AddMethod(methodBinding5);
				MethodDescriptor validateActionsMethodDesc = ValidateActionsMethodDesc;
				RpcMethodBinding.MethodInvokerDelegate methodInvoker6 = ValidateActionsInvokerAsync;
				RpcMethodBinding.MethodImplDelegate methodImpl6 = ValidateActionsAsyncStub;
				RpcMethodBinding.CreateRequestDelegate createRequest5 = default(RpcMethodBinding.CreateRequestDelegate);
				if (_003C_003Ec._003C_003E9__0_5 == null)
				{
					createRequest5 = (RpcMethodBinding.CreateRequestDelegate)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(RpcMethodBinding.CreateRequestDelegate)(() => null));
				}
				RpcMethodBinding methodBinding6 = new RpcMethodBinding(validateActionsMethodDesc, methodInvoker6, methodImpl6, createRequest5);
				AddMethod(methodBinding6);
				MethodDescriptor followUserMethodDesc = FollowUserMethodDesc;
				RpcMethodBinding.MethodInvokerDelegate methodInvoker7 = FollowUserInvokerAsync;
				RpcMethodBinding.MethodImplDelegate methodImpl7 = FollowUserAsyncStub;
				RpcMethodBinding.CreateRequestDelegate createRequest6 = default(RpcMethodBinding.CreateRequestDelegate);
				if (_003C_003Ec._003C_003E9__0_6 == null)
				{
					createRequest6 = (RpcMethodBinding.CreateRequestDelegate)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(RpcMethodBinding.CreateRequestDelegate)(() => null));
				}
				RpcMethodBinding methodBinding7 = new RpcMethodBinding(followUserMethodDesc, methodInvoker7, methodImpl7, createRequest6);
				AddMethod(methodBinding7);
				MethodDescriptor getFollowDataMethodDesc = GetFollowDataMethodDesc;
				RpcMethodBinding.MethodInvokerDelegate methodInvoker8 = GetFollowDataInvokerAsync;
				RpcMethodBinding.MethodImplDelegate methodImpl8 = GetFollowDataAsyncStub;
				RpcMethodBinding.CreateRequestDelegate createRequest7 = default(RpcMethodBinding.CreateRequestDelegate);
				if (_003C_003Ec._003C_003E9__0_7 == null)
				{
					createRequest7 = (RpcMethodBinding.CreateRequestDelegate)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(RpcMethodBinding.CreateRequestDelegate)(() => null));
				}
				RpcMethodBinding methodBinding8 = new RpcMethodBinding(getFollowDataMethodDesc, methodInvoker8, methodImpl8, createRequest7);
				AddMethod(methodBinding8);
				MethodDescriptor listConnectionsMethodDesc = ListConnectionsMethodDesc;
				RpcMethodBinding.MethodInvokerDelegate methodInvoker9 = ListConnectionsInvokerAsync;
				RpcMethodBinding.MethodImplDelegate methodImpl9 = ListConnectionsAsyncStub;
				RpcMethodBinding.CreateRequestDelegate createRequest8 = default(RpcMethodBinding.CreateRequestDelegate);
				if (_003C_003Ec._003C_003E9__0_8 == null)
				{
					createRequest8 = (RpcMethodBinding.CreateRequestDelegate)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(RpcMethodBinding.CreateRequestDelegate)(() => null));
				}
				RpcMethodBinding methodBinding9 = new RpcMethodBinding(listConnectionsMethodDesc, methodInvoker9, methodImpl9, createRequest8);
				AddMethod(methodBinding9);
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FCC")]
			[Cpp2IlInjected.Address(RVA = "0xC75D20", Offset = "0xC74720", VA = "0x180C75D20")]
			[AsyncStateMachine(typeof(_003CLoginInvokerAsync_003Ed__1))]
			public Task<CallResult<IMessage>> LoginInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FCD")]
			[Cpp2IlInjected.Address(RVA = "0xC75B70", Offset = "0xC74570", VA = "0x180C75B70")]
			[AsyncStateMachine(typeof(_003CLoginAsyncStub_003Ed__2))]
			public Task<IMessage> LoginAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FCE")]
			[Cpp2IlInjected.Address(RVA = "0xC75CD0", Offset = "0xC746D0", VA = "0x180C75CD0", Slot = "8")]
			public virtual Task<Login.Types.Response> LoginAsync(Login.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: LoginAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FCF")]
			[Cpp2IlInjected.Address(RVA = "0xC76650", Offset = "0xC75050", VA = "0x180C76650")]
			[AsyncStateMachine(typeof(_003CPostLoginInvokerAsync_003Ed__4))]
			public Task<CallResult<IMessage>> PostLoginInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FD0")]
			[Cpp2IlInjected.Address(RVA = "0xC764A0", Offset = "0xC74EA0", VA = "0x180C764A0")]
			[AsyncStateMachine(typeof(_003CPostLoginAsyncStub_003Ed__5))]
			public Task<IMessage> PostLoginAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FD1")]
			[Cpp2IlInjected.Address(RVA = "0xC76600", Offset = "0xC75000", VA = "0x180C76600", Slot = "9")]
			public virtual Task<PostLogin.Types.Response> PostLoginAsync(PostLogin.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: PostLoginAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FD2")]
			[Cpp2IlInjected.Address(RVA = "0xC71FE0", Offset = "0xC709E0", VA = "0x180C71FE0")]
			[AsyncStateMachine(typeof(_003CAutoRedeemFoundersPackInvokerAsync_003Ed__7))]
			public Task<CallResult<IMessage>> AutoRedeemFoundersPackInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FD3")]
			[Cpp2IlInjected.Address(RVA = "0xC71E30", Offset = "0xC70830", VA = "0x180C71E30")]
			[AsyncStateMachine(typeof(_003CAutoRedeemFoundersPackAsyncStub_003Ed__8))]
			public Task<IMessage> AutoRedeemFoundersPackAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FD4")]
			[Cpp2IlInjected.Address(RVA = "0xC71F90", Offset = "0xC70990", VA = "0x180C71F90", Slot = "10")]
			public virtual Task<AutoRedeemFoundersPack.Types.Response> AutoRedeemFoundersPackAsync(AutoRedeemFoundersPack.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: AutoRedeemFoundersPackAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FD5")]
			[Cpp2IlInjected.Address(RVA = "0xC7A080", Offset = "0xC78A80", VA = "0x180C7A080")]
			[AsyncStateMachine(typeof(_003CTransferMarketplacePacksInvokerAsync_003Ed__10))]
			public Task<CallResult<IMessage>> TransferMarketplacePacksInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FD6")]
			[Cpp2IlInjected.Address(RVA = "0xC79ED0", Offset = "0xC788D0", VA = "0x180C79ED0")]
			[AsyncStateMachine(typeof(_003CTransferMarketplacePacksAsyncStub_003Ed__11))]
			public Task<IMessage> TransferMarketplacePacksAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FD7")]
			[Cpp2IlInjected.Address(RVA = "0xC7A030", Offset = "0xC78A30", VA = "0x180C7A030", Slot = "11")]
			public virtual Task<TransferMarketplacePacks.Types.Response> TransferMarketplacePacksAsync(TransferMarketplacePacks.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: TransferMarketplacePacksAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FD8")]
			[Cpp2IlInjected.Address(RVA = "0xC747B0", Offset = "0xC731B0", VA = "0x180C747B0")]
			[AsyncStateMachine(typeof(_003CGetFilesInvokerAsync_003Ed__13))]
			public Task<CallResult<IMessage>> GetFilesInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FD9")]
			[Cpp2IlInjected.Address(RVA = "0xC74600", Offset = "0xC73000", VA = "0x180C74600")]
			[AsyncStateMachine(typeof(_003CGetFilesAsyncStub_003Ed__14))]
			public Task<IMessage> GetFilesAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FDA")]
			[Cpp2IlInjected.Address(RVA = "0xC74760", Offset = "0xC73160", VA = "0x180C74760", Slot = "12")]
			public virtual Task<GetFiles.Types.Response> GetFilesAsync(GetFiles.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: GetFilesAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FDB")]
			[Cpp2IlInjected.Address(RVA = "0xC7A6A0", Offset = "0xC790A0", VA = "0x180C7A6A0")]
			[AsyncStateMachine(typeof(_003CValidateActionsInvokerAsync_003Ed__16))]
			public Task<CallResult<IMessage>> ValidateActionsInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FDC")]
			[Cpp2IlInjected.Address(RVA = "0xC7A4F0", Offset = "0xC78EF0", VA = "0x180C7A4F0")]
			[AsyncStateMachine(typeof(_003CValidateActionsAsyncStub_003Ed__17))]
			public Task<IMessage> ValidateActionsAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FDD")]
			[Cpp2IlInjected.Address(RVA = "0xC7A650", Offset = "0xC79050", VA = "0x180C7A650", Slot = "13")]
			public virtual Task<ValidateActions.Types.Response> ValidateActionsAsync(ValidateActions.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ValidateActionsAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FDE")]
			[Cpp2IlInjected.Address(RVA = "0xC73860", Offset = "0xC72260", VA = "0x180C73860")]
			[AsyncStateMachine(typeof(_003CFollowUserInvokerAsync_003Ed__19))]
			public Task<CallResult<IMessage>> FollowUserInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FDF")]
			[Cpp2IlInjected.Address(RVA = "0xC736B0", Offset = "0xC720B0", VA = "0x180C736B0")]
			[AsyncStateMachine(typeof(_003CFollowUserAsyncStub_003Ed__20))]
			public Task<IMessage> FollowUserAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FE0")]
			[Cpp2IlInjected.Address(RVA = "0xC73810", Offset = "0xC72210", VA = "0x180C73810", Slot = "14")]
			public virtual Task<FollowUser.Types.Response> FollowUserAsync(FollowUser.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: FollowUserAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FE1")]
			[Cpp2IlInjected.Address(RVA = "0xC74AC0", Offset = "0xC734C0", VA = "0x180C74AC0")]
			[AsyncStateMachine(typeof(_003CGetFollowDataInvokerAsync_003Ed__22))]
			public Task<CallResult<IMessage>> GetFollowDataInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FE2")]
			[Cpp2IlInjected.Address(RVA = "0xC74910", Offset = "0xC73310", VA = "0x180C74910")]
			[AsyncStateMachine(typeof(_003CGetFollowDataAsyncStub_003Ed__23))]
			public Task<IMessage> GetFollowDataAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FE3")]
			[Cpp2IlInjected.Address(RVA = "0xC74A70", Offset = "0xC73470", VA = "0x180C74A70", Slot = "15")]
			public virtual Task<GetFollowData.Types.Response> GetFollowDataAsync(GetFollowData.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: GetFollowDataAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FE4")]
			[Cpp2IlInjected.Address(RVA = "0xC75A10", Offset = "0xC74410", VA = "0x180C75A10")]
			[AsyncStateMachine(typeof(_003CListConnectionsInvokerAsync_003Ed__25))]
			public Task<CallResult<IMessage>> ListConnectionsInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FE5")]
			[Cpp2IlInjected.Address(RVA = "0xC75860", Offset = "0xC74260", VA = "0x180C75860")]
			[AsyncStateMachine(typeof(_003CListConnectionsAsyncStub_003Ed__26))]
			public Task<IMessage> ListConnectionsAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FE6")]
			[Cpp2IlInjected.Address(RVA = "0xC759C0", Offset = "0xC743C0", VA = "0x180C759C0", Slot = "16")]
			public virtual Task<ListConnections.Types.Response> ListConnectionsAsync(ListConnections.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ListConnectionsAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FE7")]
			[Cpp2IlInjected.Address(RVA = "0xC744A0", Offset = "0xC72EA0", VA = "0x180C744A0")]
			[AsyncStateMachine(typeof(_003CGetConnectionsCountInvokerAsync_003Ed__28))]
			public Task<CallResult<IMessage>> GetConnectionsCountInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FE8")]
			[Cpp2IlInjected.Address(RVA = "0xC742F0", Offset = "0xC72CF0", VA = "0x180C742F0")]
			[AsyncStateMachine(typeof(_003CGetConnectionsCountAsyncStub_003Ed__29))]
			public Task<IMessage> GetConnectionsCountAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FE9")]
			[Cpp2IlInjected.Address(RVA = "0xC74450", Offset = "0xC72E50", VA = "0x180C74450", Slot = "17")]
			public virtual Task<GetConnectionsCount.Types.Response> GetConnectionsCountAsync(GetConnectionsCount.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: GetConnectionsCountAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FEA")]
			[Cpp2IlInjected.Address(RVA = "0xC79440", Offset = "0xC77E40", VA = "0x180C79440")]
			[AsyncStateMachine(typeof(_003CSuggestFollowerInvokerAsync_003Ed__31))]
			public Task<CallResult<IMessage>> SuggestFollowerInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FEB")]
			[Cpp2IlInjected.Address(RVA = "0xC79290", Offset = "0xC77C90", VA = "0x180C79290")]
			[AsyncStateMachine(typeof(_003CSuggestFollowerAsyncStub_003Ed__32))]
			public Task<IMessage> SuggestFollowerAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FEC")]
			[Cpp2IlInjected.Address(RVA = "0xC793F0", Offset = "0xC77DF0", VA = "0x180C793F0", Slot = "18")]
			public virtual Task<SuggestFollower.Types.Response> SuggestFollowerAsync(SuggestFollower.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SuggestFollowerAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FED")]
			[Cpp2IlInjected.Address(RVA = "0xC784F0", Offset = "0xC76EF0", VA = "0x180C784F0")]
			[AsyncStateMachine(typeof(_003CSearchFriendsInvokerAsync_003Ed__34))]
			public Task<CallResult<IMessage>> SearchFriendsInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FEE")]
			[Cpp2IlInjected.Address(RVA = "0xC78340", Offset = "0xC76D40", VA = "0x180C78340")]
			[AsyncStateMachine(typeof(_003CSearchFriendsAsyncStub_003Ed__35))]
			public Task<IMessage> SearchFriendsAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FEF")]
			[Cpp2IlInjected.Address(RVA = "0xC784A0", Offset = "0xC76EA0", VA = "0x180C784A0", Slot = "19")]
			public virtual Task<SearchFriends.Types.Response> SearchFriendsAsync(SearchFriends.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SearchFriendsAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FF0")]
			[Cpp2IlInjected.Address(RVA = "0xC72C20", Offset = "0xC71620", VA = "0x180C72C20")]
			[AsyncStateMachine(typeof(_003CCreateNewsFeedInvokerAsync_003Ed__37))]
			public Task<CallResult<IMessage>> CreateNewsFeedInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FF1")]
			[Cpp2IlInjected.Address(RVA = "0xC72A70", Offset = "0xC71470", VA = "0x180C72A70")]
			[AsyncStateMachine(typeof(_003CCreateNewsFeedAsyncStub_003Ed__38))]
			public Task<IMessage> CreateNewsFeedAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FF2")]
			[Cpp2IlInjected.Address(RVA = "0xC72BD0", Offset = "0xC715D0", VA = "0x180C72BD0", Slot = "20")]
			public virtual Task<CreateNewsFeed.Types.Response> CreateNewsFeedAsync(CreateNewsFeed.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: CreateNewsFeedAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FF3")]
			[Cpp2IlInjected.Address(RVA = "0xC753F0", Offset = "0xC73DF0", VA = "0x180C753F0")]
			[AsyncStateMachine(typeof(_003CGetUserPostsInvokerAsync_003Ed__40))]
			public Task<CallResult<IMessage>> GetUserPostsInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FF4")]
			[Cpp2IlInjected.Address(RVA = "0xC75240", Offset = "0xC73C40", VA = "0x180C75240")]
			[AsyncStateMachine(typeof(_003CGetUserPostsAsyncStub_003Ed__41))]
			public Task<IMessage> GetUserPostsAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FF5")]
			[Cpp2IlInjected.Address(RVA = "0xC753A0", Offset = "0xC73DA0", VA = "0x180C753A0", Slot = "21")]
			public virtual Task<GetUserPosts.Types.Response> GetUserPostsAsync(GetUserPosts.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: GetUserPostsAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FF6")]
			[Cpp2IlInjected.Address(RVA = "0xC75700", Offset = "0xC74100", VA = "0x180C75700")]
			[AsyncStateMachine(typeof(_003CLikeNewsFeedInvokerAsync_003Ed__43))]
			public Task<CallResult<IMessage>> LikeNewsFeedInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FF7")]
			[Cpp2IlInjected.Address(RVA = "0xC75550", Offset = "0xC73F50", VA = "0x180C75550")]
			[AsyncStateMachine(typeof(_003CLikeNewsFeedAsyncStub_003Ed__44))]
			public Task<IMessage> LikeNewsFeedAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FF8")]
			[Cpp2IlInjected.Address(RVA = "0xC756B0", Offset = "0xC740B0", VA = "0x180C756B0", Slot = "22")]
			public virtual Task<LikeNewsFeed.Types.Response> LikeNewsFeedAsync(LikeNewsFeed.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: LikeNewsFeedAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FF9")]
			[Cpp2IlInjected.Address(RVA = "0xC7A390", Offset = "0xC78D90", VA = "0x180C7A390")]
			[AsyncStateMachine(typeof(_003CUnlikeNewsFeedInvokerAsync_003Ed__46))]
			public Task<CallResult<IMessage>> UnlikeNewsFeedInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FFA")]
			[Cpp2IlInjected.Address(RVA = "0xC7A1E0", Offset = "0xC78BE0", VA = "0x180C7A1E0")]
			[AsyncStateMachine(typeof(_003CUnlikeNewsFeedAsyncStub_003Ed__47))]
			public Task<IMessage> UnlikeNewsFeedAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FFB")]
			[Cpp2IlInjected.Address(RVA = "0xC7A340", Offset = "0xC78D40", VA = "0x180C7A340", Slot = "23")]
			public virtual Task<UnlikeNewsFeed.Types.Response> UnlikeNewsFeedAsync(UnlikeNewsFeed.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: UnlikeNewsFeedAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FFC")]
			[Cpp2IlInjected.Address(RVA = "0xC74DD0", Offset = "0xC737D0", VA = "0x180C74DD0")]
			[AsyncStateMachine(typeof(_003CGetInboxInvokerAsync_003Ed__49))]
			public Task<CallResult<IMessage>> GetInboxInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FFD")]
			[Cpp2IlInjected.Address(RVA = "0xC74C20", Offset = "0xC73620", VA = "0x180C74C20")]
			[AsyncStateMachine(typeof(_003CGetInboxAsyncStub_003Ed__50))]
			public Task<IMessage> GetInboxAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FFE")]
			[Cpp2IlInjected.Address(RVA = "0xC74D80", Offset = "0xC73780", VA = "0x180C74D80", Slot = "24")]
			public virtual Task<GetInbox.Types.Response> GetInboxAsync(GetInbox.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: GetInboxAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6006FFF")]
			[Cpp2IlInjected.Address(RVA = "0xC775A0", Offset = "0xC75FA0", VA = "0x180C775A0")]
			[AsyncStateMachine(typeof(_003CPurgeInboxInvokerAsync_003Ed__52))]
			public Task<CallResult<IMessage>> PurgeInboxInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007000")]
			[Cpp2IlInjected.Address(RVA = "0xC773F0", Offset = "0xC75DF0", VA = "0x180C773F0")]
			[AsyncStateMachine(typeof(_003CPurgeInboxAsyncStub_003Ed__53))]
			public Task<IMessage> PurgeInboxAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007001")]
			[Cpp2IlInjected.Address(RVA = "0xC77550", Offset = "0xC75F50", VA = "0x180C77550", Slot = "25")]
			public virtual Task<PurgeInbox.Types.Response> PurgeInboxAsync(PurgeInbox.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: PurgeInboxAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6007002")]
			[Cpp2IlInjected.Address(RVA = "0xC71CD0", Offset = "0xC706D0", VA = "0x180C71CD0")]
			[AsyncStateMachine(typeof(_003CAddInboxMessageInvokerAsync_003Ed__55))]
			public Task<CallResult<IMessage>> AddInboxMessageInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007003")]
			[Cpp2IlInjected.Address(RVA = "0xC71B20", Offset = "0xC70520", VA = "0x180C71B20")]
			[AsyncStateMachine(typeof(_003CAddInboxMessageAsyncStub_003Ed__56))]
			public Task<IMessage> AddInboxMessageAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007004")]
			[Cpp2IlInjected.Address(RVA = "0xC71C80", Offset = "0xC70680", VA = "0x180C71C80", Slot = "26")]
			public virtual Task<AddInboxMessage.Types.Response> AddInboxMessageAsync(AddInboxMessage.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: AddInboxMessageAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6007005")]
			[Cpp2IlInjected.Address(RVA = "0xC77ED0", Offset = "0xC768D0", VA = "0x180C77ED0")]
			[AsyncStateMachine(typeof(_003CRemoveInboxMessageInvokerAsync_003Ed__58))]
			public Task<CallResult<IMessage>> RemoveInboxMessageInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007006")]
			[Cpp2IlInjected.Address(RVA = "0xC77D20", Offset = "0xC76720", VA = "0x180C77D20")]
			[AsyncStateMachine(typeof(_003CRemoveInboxMessageAsyncStub_003Ed__59))]
			public Task<IMessage> RemoveInboxMessageAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007007")]
			[Cpp2IlInjected.Address(RVA = "0xC77E80", Offset = "0xC76880", VA = "0x180C77E80", Slot = "27")]
			public virtual Task<RemoveInboxMessage.Types.Response> RemoveInboxMessageAsync(RemoveInboxMessage.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: RemoveInboxMessageAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6007008")]
			[Cpp2IlInjected.Address(RVA = "0xC778B0", Offset = "0xC762B0", VA = "0x180C778B0")]
			[AsyncStateMachine(typeof(_003CReadInboxMessagesInvokerAsync_003Ed__61))]
			public Task<CallResult<IMessage>> ReadInboxMessagesInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007009")]
			[Cpp2IlInjected.Address(RVA = "0xC77700", Offset = "0xC76100", VA = "0x180C77700")]
			[AsyncStateMachine(typeof(_003CReadInboxMessagesAsyncStub_003Ed__62))]
			public Task<IMessage> ReadInboxMessagesAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600700A")]
			[Cpp2IlInjected.Address(RVA = "0xC77860", Offset = "0xC76260", VA = "0x180C77860", Slot = "28")]
			public virtual Task<ReadInboxMessages.Types.Response> ReadInboxMessagesAsync(ReadInboxMessages.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ReadInboxMessagesAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600700B")]
			[Cpp2IlInjected.Address(RVA = "0xC72600", Offset = "0xC71000", VA = "0x180C72600")]
			[AsyncStateMachine(typeof(_003CClaimInboxMessagesInvokerAsync_003Ed__64))]
			public Task<CallResult<IMessage>> ClaimInboxMessagesInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600700C")]
			[Cpp2IlInjected.Address(RVA = "0xC72450", Offset = "0xC70E50", VA = "0x180C72450")]
			[AsyncStateMachine(typeof(_003CClaimInboxMessagesAsyncStub_003Ed__65))]
			public Task<IMessage> ClaimInboxMessagesAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600700D")]
			[Cpp2IlInjected.Address(RVA = "0xC725B0", Offset = "0xC70FB0", VA = "0x180C725B0", Slot = "29")]
			public virtual Task<ClaimInboxMessages.Types.Response> ClaimInboxMessagesAsync(ClaimInboxMessages.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ClaimInboxMessagesAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600700E")]
			[Cpp2IlInjected.Address(RVA = "0xC77BC0", Offset = "0xC765C0", VA = "0x180C77BC0")]
			[AsyncStateMachine(typeof(_003CRefundInboxMessagesInvokerAsync_003Ed__67))]
			public Task<CallResult<IMessage>> RefundInboxMessagesInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600700F")]
			[Cpp2IlInjected.Address(RVA = "0xC77A10", Offset = "0xC76410", VA = "0x180C77A10")]
			[AsyncStateMachine(typeof(_003CRefundInboxMessagesAsyncStub_003Ed__68))]
			public Task<IMessage> RefundInboxMessagesAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007010")]
			[Cpp2IlInjected.Address(RVA = "0xC77B70", Offset = "0xC76570", VA = "0x180C77B70", Slot = "30")]
			public virtual Task<RefundInboxMessages.Types.Response> RefundInboxMessagesAsync(RefundInboxMessages.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: RefundInboxMessagesAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6007011")]
			[Cpp2IlInjected.Address(RVA = "0xC76960", Offset = "0xC75360", VA = "0x180C76960")]
			[AsyncStateMachine(typeof(_003CPostPictureInvokerAsync_003Ed__70))]
			public Task<CallResult<IMessage>> PostPictureInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007012")]
			[Cpp2IlInjected.Address(RVA = "0xC767B0", Offset = "0xC751B0", VA = "0x180C767B0")]
			[AsyncStateMachine(typeof(_003CPostPictureAsyncStub_003Ed__71))]
			public Task<IMessage> PostPictureAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007013")]
			[Cpp2IlInjected.Address(RVA = "0xC76910", Offset = "0xC75310", VA = "0x180C76910", Slot = "31")]
			public virtual Task<PostPicture.Types.Response> PostPictureAsync(PostPicture.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: PostPictureAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6007014")]
			[Cpp2IlInjected.Address(RVA = "0xC73550", Offset = "0xC71F50", VA = "0x180C73550")]
			[AsyncStateMachine(typeof(_003CEditPictureInvokerAsync_003Ed__73))]
			public Task<CallResult<IMessage>> EditPictureInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007015")]
			[Cpp2IlInjected.Address(RVA = "0xC733A0", Offset = "0xC71DA0", VA = "0x180C733A0")]
			[AsyncStateMachine(typeof(_003CEditPictureAsyncStub_003Ed__74))]
			public Task<IMessage> EditPictureAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007016")]
			[Cpp2IlInjected.Address(RVA = "0xC73500", Offset = "0xC71F00", VA = "0x180C73500", Slot = "32")]
			public virtual Task<EditPicture.Types.Response> EditPictureAsync(EditPicture.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: EditPictureAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6007017")]
			[Cpp2IlInjected.Address(RVA = "0xC78B10", Offset = "0xC77510", VA = "0x180C78B10")]
			[AsyncStateMachine(typeof(_003CSetPlayfabNameInvokerAsync_003Ed__76))]
			public Task<CallResult<IMessage>> SetPlayfabNameInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007018")]
			[Cpp2IlInjected.Address(RVA = "0xC78960", Offset = "0xC77360", VA = "0x180C78960")]
			[AsyncStateMachine(typeof(_003CSetPlayfabNameAsyncStub_003Ed__77))]
			public Task<IMessage> SetPlayfabNameAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007019")]
			[Cpp2IlInjected.Address(RVA = "0xC78AC0", Offset = "0xC774C0", VA = "0x180C78AC0", Slot = "33")]
			public virtual Task<SetPlayfabName.Types.Response> SetPlayfabNameAsync(SetPlayfabName.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SetPlayfabNameAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600701A")]
			[Cpp2IlInjected.Address(RVA = "0xC78800", Offset = "0xC77200", VA = "0x180C78800")]
			[AsyncStateMachine(typeof(_003CSetPlayfabAvatarInvokerAsync_003Ed__79))]
			public Task<CallResult<IMessage>> SetPlayfabAvatarInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600701B")]
			[Cpp2IlInjected.Address(RVA = "0xC78650", Offset = "0xC77050", VA = "0x180C78650")]
			[AsyncStateMachine(typeof(_003CSetPlayfabAvatarAsyncStub_003Ed__80))]
			public Task<IMessage> SetPlayfabAvatarAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600701C")]
			[Cpp2IlInjected.Address(RVA = "0xC787B0", Offset = "0xC771B0", VA = "0x180C787B0", Slot = "34")]
			public virtual Task<SetPlayfabAvatar.Types.Response> SetPlayfabAvatarAsync(SetPlayfabAvatar.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SetPlayfabAvatarAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600701D")]
			[Cpp2IlInjected.Address(RVA = "0xC781E0", Offset = "0xC76BE0", VA = "0x180C781E0")]
			[AsyncStateMachine(typeof(_003CResetPlayfabNameChangeCooldownInvokerAsync_003Ed__82))]
			public Task<CallResult<IMessage>> ResetPlayfabNameChangeCooldownInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600701E")]
			[Cpp2IlInjected.Address(RVA = "0xC78030", Offset = "0xC76A30", VA = "0x180C78030")]
			[AsyncStateMachine(typeof(_003CResetPlayfabNameChangeCooldownAsyncStub_003Ed__83))]
			public Task<IMessage> ResetPlayfabNameChangeCooldownAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600701F")]
			[Cpp2IlInjected.Address(RVA = "0xC78190", Offset = "0xC76B90", VA = "0x180C78190", Slot = "35")]
			public virtual Task<ResetPlayfabNameChangeCooldown.Types.Response> ResetPlayfabNameChangeCooldownAsync(ResetPlayfabNameChangeCooldown.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: ResetPlayfabNameChangeCooldownAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6007020")]
			[Cpp2IlInjected.Address(RVA = "0xC78E20", Offset = "0xC77820", VA = "0x180C78E20")]
			[AsyncStateMachine(typeof(_003CSpendEntryTicketsInvokerAsync_003Ed__85))]
			public Task<CallResult<IMessage>> SpendEntryTicketsInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007021")]
			[Cpp2IlInjected.Address(RVA = "0xC78C70", Offset = "0xC77670", VA = "0x180C78C70")]
			[AsyncStateMachine(typeof(_003CSpendEntryTicketsAsyncStub_003Ed__86))]
			public Task<IMessage> SpendEntryTicketsAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007022")]
			[Cpp2IlInjected.Address(RVA = "0xC78DD0", Offset = "0xC777D0", VA = "0x180C78DD0", Slot = "36")]
			public virtual Task<SpendEntryTickets.Types.Response> SpendEntryTicketsAsync(SpendEntryTickets.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SpendEntryTicketsAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6007023")]
			[Cpp2IlInjected.Address(RVA = "0xC73B70", Offset = "0xC72570", VA = "0x180C73B70")]
			[AsyncStateMachine(typeof(_003CGainVotingTicketsInvokerAsync_003Ed__88))]
			public Task<CallResult<IMessage>> GainVotingTicketsInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007024")]
			[Cpp2IlInjected.Address(RVA = "0xC739C0", Offset = "0xC723C0", VA = "0x180C739C0")]
			[AsyncStateMachine(typeof(_003CGainVotingTicketsAsyncStub_003Ed__89))]
			public Task<IMessage> GainVotingTicketsAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007025")]
			[Cpp2IlInjected.Address(RVA = "0xC73B20", Offset = "0xC72520", VA = "0x180C73B20", Slot = "37")]
			public virtual Task<GainVotingTickets.Types.Response> GainVotingTicketsAsync(GainVotingTickets.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: GainVotingTicketsAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6007026")]
			[Cpp2IlInjected.Address(RVA = "0xC722F0", Offset = "0xC70CF0", VA = "0x180C722F0")]
			[AsyncStateMachine(typeof(_003CBuyIAPInvokerAsync_003Ed__91))]
			public Task<CallResult<IMessage>> BuyIAPInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007027")]
			[Cpp2IlInjected.Address(RVA = "0xC72140", Offset = "0xC70B40", VA = "0x180C72140")]
			[AsyncStateMachine(typeof(_003CBuyIAPAsyncStub_003Ed__92))]
			public Task<IMessage> BuyIAPAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007028")]
			[Cpp2IlInjected.Address(RVA = "0xC722A0", Offset = "0xC70CA0", VA = "0x180C722A0", Slot = "38")]
			public virtual Task<BuyIAP.Types.Response> BuyIAPAsync(BuyIAP.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: BuyIAPAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6007029")]
			[Cpp2IlInjected.Address(RVA = "0xC76030", Offset = "0xC74A30", VA = "0x180C76030")]
			[AsyncStateMachine(typeof(_003COnlineClaimPromoCodeInvokerAsync_003Ed__94))]
			public Task<CallResult<IMessage>> OnlineClaimPromoCodeInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600702A")]
			[Cpp2IlInjected.Address(RVA = "0xC75E80", Offset = "0xC74880", VA = "0x180C75E80")]
			[AsyncStateMachine(typeof(_003COnlineClaimPromoCodeAsyncStub_003Ed__95))]
			public Task<IMessage> OnlineClaimPromoCodeAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600702B")]
			[Cpp2IlInjected.Address(RVA = "0xC75FE0", Offset = "0xC749E0", VA = "0x180C75FE0", Slot = "39")]
			public virtual Task<OnlineClaimPromoCode.Types.Response> OnlineClaimPromoCodeAsync(OnlineClaimPromoCode.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: OnlineClaimPromoCodeAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600702C")]
			[Cpp2IlInjected.Address(RVA = "0xC76340", Offset = "0xC74D40", VA = "0x180C76340")]
			[AsyncStateMachine(typeof(_003COnlineCollectLootPresentInvokerAsync_003Ed__97))]
			public Task<CallResult<IMessage>> OnlineCollectLootPresentInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600702D")]
			[Cpp2IlInjected.Address(RVA = "0xC76190", Offset = "0xC74B90", VA = "0x180C76190")]
			[AsyncStateMachine(typeof(_003COnlineCollectLootPresentAsyncStub_003Ed__98))]
			public Task<IMessage> OnlineCollectLootPresentAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600702E")]
			[Cpp2IlInjected.Address(RVA = "0xC762F0", Offset = "0xC74CF0", VA = "0x180C762F0", Slot = "40")]
			public virtual Task<OnlineCollectLootPresent.Types.Response> OnlineCollectLootPresentAsync(OnlineCollectLootPresent.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: OnlineCollectLootPresentAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600702F")]
			[Cpp2IlInjected.Address(RVA = "0xC74190", Offset = "0xC72B90", VA = "0x180C74190")]
			[AsyncStateMachine(typeof(_003CGetBundlesInvokerAsync_003Ed__100))]
			public Task<CallResult<IMessage>> GetBundlesInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007030")]
			[Cpp2IlInjected.Address(RVA = "0xC73FE0", Offset = "0xC729E0", VA = "0x180C73FE0")]
			[AsyncStateMachine(typeof(_003CGetBundlesAsyncStub_003Ed__101))]
			public Task<IMessage> GetBundlesAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007031")]
			[Cpp2IlInjected.Address(RVA = "0xC74140", Offset = "0xC72B40", VA = "0x180C74140", Slot = "41")]
			public virtual Task<GetBundles.Types.Response> GetBundlesAsync(GetBundles.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: GetBundlesAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6007032")]
			[Cpp2IlInjected.Address(RVA = "0xC750E0", Offset = "0xC73AE0", VA = "0x180C750E0")]
			[AsyncStateMachine(typeof(_003CGetStoresInvokerAsync_003Ed__103))]
			public Task<CallResult<IMessage>> GetStoresInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007033")]
			[Cpp2IlInjected.Address(RVA = "0xC74F30", Offset = "0xC73930", VA = "0x180C74F30")]
			[AsyncStateMachine(typeof(_003CGetStoresAsyncStub_003Ed__104))]
			public Task<IMessage> GetStoresAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007034")]
			[Cpp2IlInjected.Address(RVA = "0xC75090", Offset = "0xC73A90", VA = "0x180C75090", Slot = "42")]
			public virtual Task<GetStores.Types.Response> GetStoresAsync(GetStores.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: GetStoresAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6007035")]
			[Cpp2IlInjected.Address(RVA = "0xC79130", Offset = "0xC77B30", VA = "0x180C79130")]
			[AsyncStateMachine(typeof(_003CStorePurchaseInvokerAsync_003Ed__106))]
			public Task<CallResult<IMessage>> StorePurchaseInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007036")]
			[Cpp2IlInjected.Address(RVA = "0xC78F80", Offset = "0xC77980", VA = "0x180C78F80")]
			[AsyncStateMachine(typeof(_003CStorePurchaseAsyncStub_003Ed__107))]
			public Task<IMessage> StorePurchaseAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007037")]
			[Cpp2IlInjected.Address(RVA = "0xC790E0", Offset = "0xC77AE0", VA = "0x180C790E0", Slot = "43")]
			public virtual Task<StorePurchase.Types.Response> StorePurchaseAsync(StorePurchase.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: StorePurchaseAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6007038")]
			[Cpp2IlInjected.Address(RVA = "0xC73E80", Offset = "0xC72880", VA = "0x180C73E80")]
			[AsyncStateMachine(typeof(_003CGetBattlePassesInvokerAsync_003Ed__109))]
			public Task<CallResult<IMessage>> GetBattlePassesInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007039")]
			[Cpp2IlInjected.Address(RVA = "0xC73CD0", Offset = "0xC726D0", VA = "0x180C73CD0")]
			[AsyncStateMachine(typeof(_003CGetBattlePassesAsyncStub_003Ed__110))]
			public Task<IMessage> GetBattlePassesAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600703A")]
			[Cpp2IlInjected.Address(RVA = "0xC73E30", Offset = "0xC72830", VA = "0x180C73E30", Slot = "44")]
			public virtual Task<GetBattlePasses.Types.Response> GetBattlePassesAsync(GetBattlePasses.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: GetBattlePassesAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600703B")]
			[Cpp2IlInjected.Address(RVA = "0xC72910", Offset = "0xC71310", VA = "0x180C72910")]
			[AsyncStateMachine(typeof(_003CCollectBattlePassTaskCurrencyInvokerAsync_003Ed__112))]
			public Task<CallResult<IMessage>> CollectBattlePassTaskCurrencyInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600703C")]
			[Cpp2IlInjected.Address(RVA = "0xC72760", Offset = "0xC71160", VA = "0x180C72760")]
			[AsyncStateMachine(typeof(_003CCollectBattlePassTaskCurrencyAsyncStub_003Ed__113))]
			public Task<IMessage> CollectBattlePassTaskCurrencyAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600703D")]
			[Cpp2IlInjected.Address(RVA = "0xC728C0", Offset = "0xC712C0", VA = "0x180C728C0", Slot = "45")]
			public virtual Task<CollectBattlePassTaskCurrency.Types.Response> CollectBattlePassTaskCurrencyAsync(CollectBattlePassTaskCurrency.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: CollectBattlePassTaskCurrencyAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600703E")]
			[Cpp2IlInjected.Address(RVA = "0xC76F80", Offset = "0xC75980", VA = "0x180C76F80")]
			[AsyncStateMachine(typeof(_003CPurchaseBattlePassRewardInvokerAsync_003Ed__115))]
			public Task<CallResult<IMessage>> PurchaseBattlePassRewardInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600703F")]
			[Cpp2IlInjected.Address(RVA = "0xC76DD0", Offset = "0xC757D0", VA = "0x180C76DD0")]
			[AsyncStateMachine(typeof(_003CPurchaseBattlePassRewardAsyncStub_003Ed__116))]
			public Task<IMessage> PurchaseBattlePassRewardAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007040")]
			[Cpp2IlInjected.Address(RVA = "0xC76F30", Offset = "0xC75930", VA = "0x180C76F30", Slot = "46")]
			public virtual Task<PurchaseBattlePassReward.Types.Response> PurchaseBattlePassRewardAsync(PurchaseBattlePassReward.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: PurchaseBattlePassRewardAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6007041")]
			[Cpp2IlInjected.Address(RVA = "0xC77290", Offset = "0xC75C90", VA = "0x180C77290")]
			[AsyncStateMachine(typeof(_003CPurchasePremiumPassInvokerAsync_003Ed__118))]
			public Task<CallResult<IMessage>> PurchasePremiumPassInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007042")]
			[Cpp2IlInjected.Address(RVA = "0xC770E0", Offset = "0xC75AE0", VA = "0x180C770E0")]
			[AsyncStateMachine(typeof(_003CPurchasePremiumPassAsyncStub_003Ed__119))]
			public Task<IMessage> PurchasePremiumPassAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007043")]
			[Cpp2IlInjected.Address(RVA = "0xC77240", Offset = "0xC75C40", VA = "0x180C77240", Slot = "47")]
			public virtual Task<PurchasePremiumPass.Types.Response> PurchasePremiumPassAsync(PurchasePremiumPass.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: PurchasePremiumPassAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6007044")]
			[Cpp2IlInjected.Address(RVA = "0xC76C70", Offset = "0xC75670", VA = "0x180C76C70")]
			[AsyncStateMachine(typeof(_003CPurchaseBattlePassCurrencyInvokerAsync_003Ed__121))]
			public Task<CallResult<IMessage>> PurchaseBattlePassCurrencyInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007045")]
			[Cpp2IlInjected.Address(RVA = "0xC76AC0", Offset = "0xC754C0", VA = "0x180C76AC0")]
			[AsyncStateMachine(typeof(_003CPurchaseBattlePassCurrencyAsyncStub_003Ed__122))]
			public Task<IMessage> PurchaseBattlePassCurrencyAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007046")]
			[Cpp2IlInjected.Address(RVA = "0xC76C20", Offset = "0xC75620", VA = "0x180C76C20", Slot = "48")]
			public virtual Task<PurchaseBattlePassCurrency.Types.Response> PurchaseBattlePassCurrencyAsync(PurchaseBattlePassCurrency.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: PurchaseBattlePassCurrencyAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6007047")]
			[Cpp2IlInjected.Address(RVA = "0xC72F30", Offset = "0xC71930", VA = "0x180C72F30")]
			[AsyncStateMachine(typeof(_003CDebugAddOnlineCurrencyInvokerAsync_003Ed__124))]
			public Task<CallResult<IMessage>> DebugAddOnlineCurrencyInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007048")]
			[Cpp2IlInjected.Address(RVA = "0xC72D80", Offset = "0xC71780", VA = "0x180C72D80")]
			[AsyncStateMachine(typeof(_003CDebugAddOnlineCurrencyAsyncStub_003Ed__125))]
			public Task<IMessage> DebugAddOnlineCurrencyAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007049")]
			[Cpp2IlInjected.Address(RVA = "0xC72EE0", Offset = "0xC718E0", VA = "0x180C72EE0", Slot = "49")]
			public virtual Task<DebugAddOnlineCurrency.Types.Response> DebugAddOnlineCurrencyAsync(DebugAddOnlineCurrency.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugAddOnlineCurrencyAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600704A")]
			[Cpp2IlInjected.Address(RVA = "0xC73240", Offset = "0xC71C40", VA = "0x180C73240")]
			[AsyncStateMachine(typeof(_003CDebugSpendOnlineCurrencyInvokerAsync_003Ed__127))]
			public Task<CallResult<IMessage>> DebugSpendOnlineCurrencyInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600704B")]
			[Cpp2IlInjected.Address(RVA = "0xC73090", Offset = "0xC71A90", VA = "0x180C73090")]
			[AsyncStateMachine(typeof(_003CDebugSpendOnlineCurrencyAsyncStub_003Ed__128))]
			public Task<IMessage> DebugSpendOnlineCurrencyAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600704C")]
			[Cpp2IlInjected.Address(RVA = "0xC731F0", Offset = "0xC71BF0", VA = "0x180C731F0", Slot = "50")]
			public virtual Task<DebugSpendOnlineCurrency.Types.Response> DebugSpendOnlineCurrencyAsync(DebugSpendOnlineCurrency.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: DebugSpendOnlineCurrencyAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600704D")]
			[Cpp2IlInjected.Address(RVA = "0xC79D70", Offset = "0xC78770", VA = "0x180C79D70")]
			[AsyncStateMachine(typeof(_003CSyncOnlineInvokerAsync_003Ed__130))]
			public Task<CallResult<IMessage>> SyncOnlineInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600704E")]
			[Cpp2IlInjected.Address(RVA = "0xC795A0", Offset = "0xC77FA0", VA = "0x180C795A0")]
			[AsyncStateMachine(typeof(_003CSyncOnlineAsyncStub_003Ed__131))]
			public Task<IMessage> SyncOnlineAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600704F")]
			[Cpp2IlInjected.Address(RVA = "0xC79700", Offset = "0xC78100", VA = "0x180C79700", Slot = "51")]
			public virtual Task<SyncOnline.Types.Response> SyncOnlineAsync(SyncOnline.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SyncOnlineAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6007050")]
			[Cpp2IlInjected.Address(RVA = "0xC79C10", Offset = "0xC78610", VA = "0x180C79C10")]
			[AsyncStateMachine(typeof(_003CSyncOnlineInventoryInvokerAsync_003Ed__133))]
			public Task<CallResult<IMessage>> SyncOnlineInventoryInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007051")]
			[Cpp2IlInjected.Address(RVA = "0xC79A60", Offset = "0xC78460", VA = "0x180C79A60")]
			[AsyncStateMachine(typeof(_003CSyncOnlineInventoryAsyncStub_003Ed__134))]
			public Task<IMessage> SyncOnlineInventoryAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007052")]
			[Cpp2IlInjected.Address(RVA = "0xC79BC0", Offset = "0xC785C0", VA = "0x180C79BC0", Slot = "52")]
			public virtual Task<SyncOnlineInventory.Types.Response> SyncOnlineInventoryAsync(SyncOnlineInventory.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SyncOnlineInventoryAsync");
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6007053")]
			[Cpp2IlInjected.Address(RVA = "0xC79900", Offset = "0xC78300", VA = "0x180C79900")]
			[AsyncStateMachine(typeof(_003CSyncOnlineCurrenciesInvokerAsync_003Ed__136))]
			public Task<CallResult<IMessage>> SyncOnlineCurrenciesInvokerAsync(Gameloft.Rpc.Core.Server.ICallInvoker callInvoker, IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CallResult<IMessage>>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007054")]
			[Cpp2IlInjected.Address(RVA = "0xC79750", Offset = "0xC78150", VA = "0x180C79750")]
			[AsyncStateMachine(typeof(_003CSyncOnlineCurrenciesAsyncStub_003Ed__137))]
			public Task<IMessage> SyncOnlineCurrenciesAsyncStub(IMessage request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<IMessage>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007055")]
			[Cpp2IlInjected.Address(RVA = "0xC798B0", Offset = "0xC782B0", VA = "0x180C798B0", Slot = "53")]
			public virtual Task<SyncOnlineCurrencies.Types.Response> SyncOnlineCurrenciesAsync(SyncOnlineCurrencies.Types.Request request, Gameloft.Rpc.Core.Server.CallContext context)
			{
				NotImplementedException ex = new NotImplementedException("Method not implemented: SyncOnlineCurrenciesAsync");
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000D69")]
		public class SocialServiceClient : ClientBase
		{
			[Cpp2IlInjected.Token(Token = "0x600713E")]
			[Cpp2IlInjected.Address(RVA = "0x784780", Offset = "0x783180", VA = "0x180784780")]
			public SocialServiceClient(Gameloft.Rpc.Core.Client.ICallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600713F")]
			[Cpp2IlInjected.Address(RVA = "0xC831C0", Offset = "0xC81BC0", VA = "0x180C831C0")]
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

			[Cpp2IlInjected.Token(Token = "0x6007140")]
			[Cpp2IlInjected.Address(RVA = "0xC83040", Offset = "0xC81A40", VA = "0x180C83040")]
			[AsyncStateMachine(typeof(_003CLoginAsync_003Ed__2))]
			public Task<Login.Types.Response> LoginAsync(Login.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<Login.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007141")]
			[Cpp2IlInjected.Address(RVA = "0xC839D0", Offset = "0xC823D0", VA = "0x180C839D0")]
			public Task<PostLogin.Types.Response> PostLoginAsync(PostLogin.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<PostLogin.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007142")]
			[Cpp2IlInjected.Address(RVA = "0xC83B80", Offset = "0xC82580", VA = "0x180C83B80")]
			[AsyncStateMachine(typeof(_003CPostLoginAsync_003Ed__4))]
			public Task<PostLogin.Types.Response> PostLoginAsync(PostLogin.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PostLogin.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007143")]
			[Cpp2IlInjected.Address(RVA = "0xC7F200", Offset = "0xC7DC00", VA = "0x180C7F200")]
			public Task<AutoRedeemFoundersPack.Types.Response> AutoRedeemFoundersPackAsync(AutoRedeemFoundersPack.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<AutoRedeemFoundersPack.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007144")]
			[Cpp2IlInjected.Address(RVA = "0xC7F080", Offset = "0xC7DA80", VA = "0x180C7F080")]
			[AsyncStateMachine(typeof(_003CAutoRedeemFoundersPackAsync_003Ed__6))]
			public Task<AutoRedeemFoundersPack.Types.Response> AutoRedeemFoundersPackAsync(AutoRedeemFoundersPack.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<AutoRedeemFoundersPack.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007145")]
			[Cpp2IlInjected.Address(RVA = "0xC877E0", Offset = "0xC861E0", VA = "0x180C877E0")]
			public Task<TransferMarketplacePacks.Types.Response> TransferMarketplacePacksAsync(TransferMarketplacePacks.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<TransferMarketplacePacks.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007146")]
			[Cpp2IlInjected.Address(RVA = "0xC87660", Offset = "0xC86060", VA = "0x180C87660")]
			[AsyncStateMachine(typeof(_003CTransferMarketplacePacksAsync_003Ed__8))]
			public Task<TransferMarketplacePacks.Types.Response> TransferMarketplacePacksAsync(TransferMarketplacePacks.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<TransferMarketplacePacks.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007147")]
			[Cpp2IlInjected.Address(RVA = "0xC819F0", Offset = "0xC803F0", VA = "0x180C819F0")]
			public Task<GetFiles.Types.Response> GetFilesAsync(GetFiles.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<GetFiles.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007148")]
			[Cpp2IlInjected.Address(RVA = "0xC81BA0", Offset = "0xC805A0", VA = "0x180C81BA0")]
			[AsyncStateMachine(typeof(_003CGetFilesAsync_003Ed__10))]
			public Task<GetFiles.Types.Response> GetFilesAsync(GetFiles.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<GetFiles.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007149")]
			[Cpp2IlInjected.Address(RVA = "0xC87CC0", Offset = "0xC866C0", VA = "0x180C87CC0")]
			public Task<ValidateActions.Types.Response> ValidateActionsAsync(ValidateActions.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ValidateActions.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600714A")]
			[Cpp2IlInjected.Address(RVA = "0xC87E70", Offset = "0xC86870", VA = "0x180C87E70")]
			[AsyncStateMachine(typeof(_003CValidateActionsAsync_003Ed__12))]
			public Task<ValidateActions.Types.Response> ValidateActionsAsync(ValidateActions.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ValidateActions.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600714B")]
			[Cpp2IlInjected.Address(RVA = "0xC80A00", Offset = "0xC7F400", VA = "0x180C80A00")]
			public Task<FollowUser.Types.Response> FollowUserAsync(FollowUser.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<FollowUser.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600714C")]
			[Cpp2IlInjected.Address(RVA = "0xC80BB0", Offset = "0xC7F5B0", VA = "0x180C80BB0")]
			[AsyncStateMachine(typeof(_003CFollowUserAsync_003Ed__14))]
			public Task<FollowUser.Types.Response> FollowUserAsync(FollowUser.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<FollowUser.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600714D")]
			[Cpp2IlInjected.Address(RVA = "0xC81D20", Offset = "0xC80720", VA = "0x180C81D20")]
			public Task<GetFollowData.Types.Response> GetFollowDataAsync(GetFollowData.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<GetFollowData.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600714E")]
			[Cpp2IlInjected.Address(RVA = "0xC81ED0", Offset = "0xC808D0", VA = "0x180C81ED0")]
			[AsyncStateMachine(typeof(_003CGetFollowDataAsync_003Ed__16))]
			public Task<GetFollowData.Types.Response> GetFollowDataAsync(GetFollowData.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<GetFollowData.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600714F")]
			[Cpp2IlInjected.Address(RVA = "0xC82E90", Offset = "0xC81890", VA = "0x180C82E90")]
			public Task<ListConnections.Types.Response> ListConnectionsAsync(ListConnections.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ListConnections.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007150")]
			[Cpp2IlInjected.Address(RVA = "0xC82D10", Offset = "0xC81710", VA = "0x180C82D10")]
			[AsyncStateMachine(typeof(_003CListConnectionsAsync_003Ed__18))]
			public Task<ListConnections.Types.Response> ListConnectionsAsync(ListConnections.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ListConnections.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007151")]
			[Cpp2IlInjected.Address(RVA = "0xC816C0", Offset = "0xC800C0", VA = "0x180C816C0")]
			public Task<GetConnectionsCount.Types.Response> GetConnectionsCountAsync(GetConnectionsCount.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<GetConnectionsCount.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007152")]
			[Cpp2IlInjected.Address(RVA = "0xC81870", Offset = "0xC80270", VA = "0x180C81870")]
			[AsyncStateMachine(typeof(_003CGetConnectionsCountAsync_003Ed__20))]
			public Task<GetConnectionsCount.Types.Response> GetConnectionsCountAsync(GetConnectionsCount.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<GetConnectionsCount.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007153")]
			[Cpp2IlInjected.Address(RVA = "0xC869A0", Offset = "0xC853A0", VA = "0x180C869A0")]
			public Task<SuggestFollower.Types.Response> SuggestFollowerAsync(SuggestFollower.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SuggestFollower.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007154")]
			[Cpp2IlInjected.Address(RVA = "0xC86B50", Offset = "0xC85550", VA = "0x180C86B50")]
			[AsyncStateMachine(typeof(_003CSuggestFollowerAsync_003Ed__22))]
			public Task<SuggestFollower.Types.Response> SuggestFollowerAsync(SuggestFollower.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SuggestFollower.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007155")]
			[Cpp2IlInjected.Address(RVA = "0xC859B0", Offset = "0xC843B0", VA = "0x180C859B0")]
			public Task<SearchFriends.Types.Response> SearchFriendsAsync(SearchFriends.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SearchFriends.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007156")]
			[Cpp2IlInjected.Address(RVA = "0xC85B60", Offset = "0xC84560", VA = "0x180C85B60")]
			[AsyncStateMachine(typeof(_003CSearchFriendsAsync_003Ed__24))]
			public Task<SearchFriends.Types.Response> SearchFriendsAsync(SearchFriends.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SearchFriends.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007157")]
			[Cpp2IlInjected.Address(RVA = "0xC7FEC0", Offset = "0xC7E8C0", VA = "0x180C7FEC0")]
			public Task<CreateNewsFeed.Types.Response> CreateNewsFeedAsync(CreateNewsFeed.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<CreateNewsFeed.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007158")]
			[Cpp2IlInjected.Address(RVA = "0xC7FD40", Offset = "0xC7E740", VA = "0x180C7FD40")]
			[AsyncStateMachine(typeof(_003CCreateNewsFeedAsync_003Ed__26))]
			public Task<CreateNewsFeed.Types.Response> CreateNewsFeedAsync(CreateNewsFeed.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CreateNewsFeed.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007159")]
			[Cpp2IlInjected.Address(RVA = "0xC82830", Offset = "0xC81230", VA = "0x180C82830")]
			public Task<GetUserPosts.Types.Response> GetUserPostsAsync(GetUserPosts.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<GetUserPosts.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600715A")]
			[Cpp2IlInjected.Address(RVA = "0xC826B0", Offset = "0xC810B0", VA = "0x180C826B0")]
			[AsyncStateMachine(typeof(_003CGetUserPostsAsync_003Ed__28))]
			public Task<GetUserPosts.Types.Response> GetUserPostsAsync(GetUserPosts.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<GetUserPosts.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600715B")]
			[Cpp2IlInjected.Address(RVA = "0xC82B60", Offset = "0xC81560", VA = "0x180C82B60")]
			public Task<LikeNewsFeed.Types.Response> LikeNewsFeedAsync(LikeNewsFeed.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<LikeNewsFeed.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600715C")]
			[Cpp2IlInjected.Address(RVA = "0xC829E0", Offset = "0xC813E0", VA = "0x180C829E0")]
			[AsyncStateMachine(typeof(_003CLikeNewsFeedAsync_003Ed__30))]
			public Task<LikeNewsFeed.Types.Response> LikeNewsFeedAsync(LikeNewsFeed.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<LikeNewsFeed.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600715D")]
			[Cpp2IlInjected.Address(RVA = "0xC87990", Offset = "0xC86390", VA = "0x180C87990")]
			public Task<UnlikeNewsFeed.Types.Response> UnlikeNewsFeedAsync(UnlikeNewsFeed.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<UnlikeNewsFeed.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600715E")]
			[Cpp2IlInjected.Address(RVA = "0xC87B40", Offset = "0xC86540", VA = "0x180C87B40")]
			[AsyncStateMachine(typeof(_003CUnlikeNewsFeedAsync_003Ed__32))]
			public Task<UnlikeNewsFeed.Types.Response> UnlikeNewsFeedAsync(UnlikeNewsFeed.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<UnlikeNewsFeed.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600715F")]
			[Cpp2IlInjected.Address(RVA = "0xC821D0", Offset = "0xC80BD0", VA = "0x180C821D0")]
			public Task<GetInbox.Types.Response> GetInboxAsync(GetInbox.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<GetInbox.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007160")]
			[Cpp2IlInjected.Address(RVA = "0xC82050", Offset = "0xC80A50", VA = "0x180C82050")]
			[AsyncStateMachine(typeof(_003CGetInboxAsync_003Ed__34))]
			public Task<GetInbox.Types.Response> GetInboxAsync(GetInbox.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<GetInbox.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007161")]
			[Cpp2IlInjected.Address(RVA = "0xC849C0", Offset = "0xC833C0", VA = "0x180C849C0")]
			public Task<PurgeInbox.Types.Response> PurgeInboxAsync(PurgeInbox.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<PurgeInbox.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007162")]
			[Cpp2IlInjected.Address(RVA = "0xC84B70", Offset = "0xC83570", VA = "0x180C84B70")]
			[AsyncStateMachine(typeof(_003CPurgeInboxAsync_003Ed__36))]
			public Task<PurgeInbox.Types.Response> PurgeInboxAsync(PurgeInbox.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PurgeInbox.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007163")]
			[Cpp2IlInjected.Address(RVA = "0xC7EED0", Offset = "0xC7D8D0", VA = "0x180C7EED0")]
			public Task<AddInboxMessage.Types.Response> AddInboxMessageAsync(AddInboxMessage.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<AddInboxMessage.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007164")]
			[Cpp2IlInjected.Address(RVA = "0xC7ED50", Offset = "0xC7D750", VA = "0x180C7ED50")]
			[AsyncStateMachine(typeof(_003CAddInboxMessageAsync_003Ed__38))]
			public Task<AddInboxMessage.Types.Response> AddInboxMessageAsync(AddInboxMessage.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<AddInboxMessage.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007165")]
			[Cpp2IlInjected.Address(RVA = "0xC854D0", Offset = "0xC83ED0", VA = "0x180C854D0")]
			public Task<RemoveInboxMessage.Types.Response> RemoveInboxMessageAsync(RemoveInboxMessage.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<RemoveInboxMessage.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007166")]
			[Cpp2IlInjected.Address(RVA = "0xC85350", Offset = "0xC83D50", VA = "0x180C85350")]
			[AsyncStateMachine(typeof(_003CRemoveInboxMessageAsync_003Ed__40))]
			public Task<RemoveInboxMessage.Types.Response> RemoveInboxMessageAsync(RemoveInboxMessage.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<RemoveInboxMessage.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007167")]
			[Cpp2IlInjected.Address(RVA = "0xC84CF0", Offset = "0xC836F0", VA = "0x180C84CF0")]
			public Task<ReadInboxMessages.Types.Response> ReadInboxMessagesAsync(ReadInboxMessages.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ReadInboxMessages.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007168")]
			[Cpp2IlInjected.Address(RVA = "0xC84EA0", Offset = "0xC838A0", VA = "0x180C84EA0")]
			[AsyncStateMachine(typeof(_003CReadInboxMessagesAsync_003Ed__42))]
			public Task<ReadInboxMessages.Types.Response> ReadInboxMessagesAsync(ReadInboxMessages.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ReadInboxMessages.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007169")]
			[Cpp2IlInjected.Address(RVA = "0xC7F860", Offset = "0xC7E260", VA = "0x180C7F860")]
			public Task<ClaimInboxMessages.Types.Response> ClaimInboxMessagesAsync(ClaimInboxMessages.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ClaimInboxMessages.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600716A")]
			[Cpp2IlInjected.Address(RVA = "0xC7F6E0", Offset = "0xC7E0E0", VA = "0x180C7F6E0")]
			[AsyncStateMachine(typeof(_003CClaimInboxMessagesAsync_003Ed__44))]
			public Task<ClaimInboxMessages.Types.Response> ClaimInboxMessagesAsync(ClaimInboxMessages.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ClaimInboxMessages.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600716B")]
			[Cpp2IlInjected.Address(RVA = "0xC85020", Offset = "0xC83A20", VA = "0x180C85020")]
			public Task<RefundInboxMessages.Types.Response> RefundInboxMessagesAsync(RefundInboxMessages.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<RefundInboxMessages.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600716C")]
			[Cpp2IlInjected.Address(RVA = "0xC851D0", Offset = "0xC83BD0", VA = "0x180C851D0")]
			[AsyncStateMachine(typeof(_003CRefundInboxMessagesAsync_003Ed__46))]
			public Task<RefundInboxMessages.Types.Response> RefundInboxMessagesAsync(RefundInboxMessages.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<RefundInboxMessages.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600716D")]
			[Cpp2IlInjected.Address(RVA = "0xC83D00", Offset = "0xC82700", VA = "0x180C83D00")]
			public Task<PostPicture.Types.Response> PostPictureAsync(PostPicture.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<PostPicture.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600716E")]
			[Cpp2IlInjected.Address(RVA = "0xC83EB0", Offset = "0xC828B0", VA = "0x180C83EB0")]
			[AsyncStateMachine(typeof(_003CPostPictureAsync_003Ed__48))]
			public Task<PostPicture.Types.Response> PostPictureAsync(PostPicture.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PostPicture.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600716F")]
			[Cpp2IlInjected.Address(RVA = "0xC806D0", Offset = "0xC7F0D0", VA = "0x180C806D0")]
			public Task<EditPicture.Types.Response> EditPictureAsync(EditPicture.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<EditPicture.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007170")]
			[Cpp2IlInjected.Address(RVA = "0xC80880", Offset = "0xC7F280", VA = "0x180C80880")]
			[AsyncStateMachine(typeof(_003CEditPictureAsync_003Ed__50))]
			public Task<EditPicture.Types.Response> EditPictureAsync(EditPicture.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<EditPicture.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007171")]
			[Cpp2IlInjected.Address(RVA = "0xC86010", Offset = "0xC84A10", VA = "0x180C86010")]
			public Task<SetPlayfabName.Types.Response> SetPlayfabNameAsync(SetPlayfabName.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SetPlayfabName.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007172")]
			[Cpp2IlInjected.Address(RVA = "0xC861C0", Offset = "0xC84BC0", VA = "0x180C861C0")]
			[AsyncStateMachine(typeof(_003CSetPlayfabNameAsync_003Ed__52))]
			public Task<SetPlayfabName.Types.Response> SetPlayfabNameAsync(SetPlayfabName.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SetPlayfabName.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007173")]
			[Cpp2IlInjected.Address(RVA = "0xC85CE0", Offset = "0xC846E0", VA = "0x180C85CE0")]
			public Task<SetPlayfabAvatar.Types.Response> SetPlayfabAvatarAsync(SetPlayfabAvatar.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SetPlayfabAvatar.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007174")]
			[Cpp2IlInjected.Address(RVA = "0xC85E90", Offset = "0xC84890", VA = "0x180C85E90")]
			[AsyncStateMachine(typeof(_003CSetPlayfabAvatarAsync_003Ed__54))]
			public Task<SetPlayfabAvatar.Types.Response> SetPlayfabAvatarAsync(SetPlayfabAvatar.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SetPlayfabAvatar.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007175")]
			[Cpp2IlInjected.Address(RVA = "0xC85680", Offset = "0xC84080", VA = "0x180C85680")]
			public Task<ResetPlayfabNameChangeCooldown.Types.Response> ResetPlayfabNameChangeCooldownAsync(ResetPlayfabNameChangeCooldown.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<ResetPlayfabNameChangeCooldown.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007176")]
			[Cpp2IlInjected.Address(RVA = "0xC85830", Offset = "0xC84230", VA = "0x180C85830")]
			[AsyncStateMachine(typeof(_003CResetPlayfabNameChangeCooldownAsync_003Ed__56))]
			public Task<ResetPlayfabNameChangeCooldown.Types.Response> ResetPlayfabNameChangeCooldownAsync(ResetPlayfabNameChangeCooldown.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<ResetPlayfabNameChangeCooldown.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007177")]
			[Cpp2IlInjected.Address(RVA = "0xC864C0", Offset = "0xC84EC0", VA = "0x180C864C0")]
			public Task<SpendEntryTickets.Types.Response> SpendEntryTicketsAsync(SpendEntryTickets.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SpendEntryTickets.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007178")]
			[Cpp2IlInjected.Address(RVA = "0xC86340", Offset = "0xC84D40", VA = "0x180C86340")]
			[AsyncStateMachine(typeof(_003CSpendEntryTicketsAsync_003Ed__58))]
			public Task<SpendEntryTickets.Types.Response> SpendEntryTicketsAsync(SpendEntryTickets.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SpendEntryTickets.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007179")]
			[Cpp2IlInjected.Address(RVA = "0xC80D30", Offset = "0xC7F730", VA = "0x180C80D30")]
			public Task<GainVotingTickets.Types.Response> GainVotingTicketsAsync(GainVotingTickets.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<GainVotingTickets.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600717A")]
			[Cpp2IlInjected.Address(RVA = "0xC80EE0", Offset = "0xC7F8E0", VA = "0x180C80EE0")]
			[AsyncStateMachine(typeof(_003CGainVotingTicketsAsync_003Ed__60))]
			public Task<GainVotingTickets.Types.Response> GainVotingTicketsAsync(GainVotingTickets.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<GainVotingTickets.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600717B")]
			[Cpp2IlInjected.Address(RVA = "0xC7F530", Offset = "0xC7DF30", VA = "0x180C7F530")]
			public Task<BuyIAP.Types.Response> BuyIAPAsync(BuyIAP.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<BuyIAP.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600717C")]
			[Cpp2IlInjected.Address(RVA = "0xC7F3B0", Offset = "0xC7DDB0", VA = "0x180C7F3B0")]
			[AsyncStateMachine(typeof(_003CBuyIAPAsync_003Ed__62))]
			public Task<BuyIAP.Types.Response> BuyIAPAsync(BuyIAP.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<BuyIAP.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600717D")]
			[Cpp2IlInjected.Address(RVA = "0xC834F0", Offset = "0xC81EF0", VA = "0x180C834F0")]
			public Task<OnlineClaimPromoCode.Types.Response> OnlineClaimPromoCodeAsync(OnlineClaimPromoCode.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<OnlineClaimPromoCode.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600717E")]
			[Cpp2IlInjected.Address(RVA = "0xC83370", Offset = "0xC81D70", VA = "0x180C83370")]
			[AsyncStateMachine(typeof(_003COnlineClaimPromoCodeAsync_003Ed__64))]
			public Task<OnlineClaimPromoCode.Types.Response> OnlineClaimPromoCodeAsync(OnlineClaimPromoCode.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<OnlineClaimPromoCode.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600717F")]
			[Cpp2IlInjected.Address(RVA = "0xC83820", Offset = "0xC82220", VA = "0x180C83820")]
			public Task<OnlineCollectLootPresent.Types.Response> OnlineCollectLootPresentAsync(OnlineCollectLootPresent.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<OnlineCollectLootPresent.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007180")]
			[Cpp2IlInjected.Address(RVA = "0xC836A0", Offset = "0xC820A0", VA = "0x180C836A0")]
			[AsyncStateMachine(typeof(_003COnlineCollectLootPresentAsync_003Ed__66))]
			public Task<OnlineCollectLootPresent.Types.Response> OnlineCollectLootPresentAsync(OnlineCollectLootPresent.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<OnlineCollectLootPresent.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007181")]
			[Cpp2IlInjected.Address(RVA = "0xC81390", Offset = "0xC7FD90", VA = "0x180C81390")]
			public Task<GetBundles.Types.Response> GetBundlesAsync(GetBundles.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<GetBundles.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007182")]
			[Cpp2IlInjected.Address(RVA = "0xC81540", Offset = "0xC7FF40", VA = "0x180C81540")]
			[AsyncStateMachine(typeof(_003CGetBundlesAsync_003Ed__68))]
			public Task<GetBundles.Types.Response> GetBundlesAsync(GetBundles.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<GetBundles.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007183")]
			[Cpp2IlInjected.Address(RVA = "0xC82500", Offset = "0xC80F00", VA = "0x180C82500")]
			public Task<GetStores.Types.Response> GetStoresAsync(GetStores.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<GetStores.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007184")]
			[Cpp2IlInjected.Address(RVA = "0xC82380", Offset = "0xC80D80", VA = "0x180C82380")]
			[AsyncStateMachine(typeof(_003CGetStoresAsync_003Ed__70))]
			public Task<GetStores.Types.Response> GetStoresAsync(GetStores.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<GetStores.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007185")]
			[Cpp2IlInjected.Address(RVA = "0xC86670", Offset = "0xC85070", VA = "0x180C86670")]
			public Task<StorePurchase.Types.Response> StorePurchaseAsync(StorePurchase.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<StorePurchase.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007186")]
			[Cpp2IlInjected.Address(RVA = "0xC86820", Offset = "0xC85220", VA = "0x180C86820")]
			[AsyncStateMachine(typeof(_003CStorePurchaseAsync_003Ed__72))]
			public Task<StorePurchase.Types.Response> StorePurchaseAsync(StorePurchase.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<StorePurchase.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007187")]
			[Cpp2IlInjected.Address(RVA = "0xC811E0", Offset = "0xC7FBE0", VA = "0x180C811E0")]
			public Task<GetBattlePasses.Types.Response> GetBattlePassesAsync(GetBattlePasses.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<GetBattlePasses.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007188")]
			[Cpp2IlInjected.Address(RVA = "0xC81060", Offset = "0xC7FA60", VA = "0x180C81060")]
			[AsyncStateMachine(typeof(_003CGetBattlePassesAsync_003Ed__74))]
			public Task<GetBattlePasses.Types.Response> GetBattlePassesAsync(GetBattlePasses.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<GetBattlePasses.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007189")]
			[Cpp2IlInjected.Address(RVA = "0xC7FA10", Offset = "0xC7E410", VA = "0x180C7FA10")]
			public Task<CollectBattlePassTaskCurrency.Types.Response> CollectBattlePassTaskCurrencyAsync(CollectBattlePassTaskCurrency.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<CollectBattlePassTaskCurrency.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600718A")]
			[Cpp2IlInjected.Address(RVA = "0xC7FBC0", Offset = "0xC7E5C0", VA = "0x180C7FBC0")]
			[AsyncStateMachine(typeof(_003CCollectBattlePassTaskCurrencyAsync_003Ed__76))]
			public Task<CollectBattlePassTaskCurrency.Types.Response> CollectBattlePassTaskCurrencyAsync(CollectBattlePassTaskCurrency.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<CollectBattlePassTaskCurrency.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600718B")]
			[Cpp2IlInjected.Address(RVA = "0xC844E0", Offset = "0xC82EE0", VA = "0x180C844E0")]
			public Task<PurchaseBattlePassReward.Types.Response> PurchaseBattlePassRewardAsync(PurchaseBattlePassReward.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<PurchaseBattlePassReward.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600718C")]
			[Cpp2IlInjected.Address(RVA = "0xC84360", Offset = "0xC82D60", VA = "0x180C84360")]
			[AsyncStateMachine(typeof(_003CPurchaseBattlePassRewardAsync_003Ed__78))]
			public Task<PurchaseBattlePassReward.Types.Response> PurchaseBattlePassRewardAsync(PurchaseBattlePassReward.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PurchaseBattlePassReward.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600718D")]
			[Cpp2IlInjected.Address(RVA = "0xC84810", Offset = "0xC83210", VA = "0x180C84810")]
			public Task<PurchasePremiumPass.Types.Response> PurchasePremiumPassAsync(PurchasePremiumPass.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<PurchasePremiumPass.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600718E")]
			[Cpp2IlInjected.Address(RVA = "0xC84690", Offset = "0xC83090", VA = "0x180C84690")]
			[AsyncStateMachine(typeof(_003CPurchasePremiumPassAsync_003Ed__80))]
			public Task<PurchasePremiumPass.Types.Response> PurchasePremiumPassAsync(PurchasePremiumPass.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PurchasePremiumPass.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600718F")]
			[Cpp2IlInjected.Address(RVA = "0xC841B0", Offset = "0xC82BB0", VA = "0x180C841B0")]
			public Task<PurchaseBattlePassCurrency.Types.Response> PurchaseBattlePassCurrencyAsync(PurchaseBattlePassCurrency.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<PurchaseBattlePassCurrency.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007190")]
			[Cpp2IlInjected.Address(RVA = "0xC84030", Offset = "0xC82A30", VA = "0x180C84030")]
			[AsyncStateMachine(typeof(_003CPurchaseBattlePassCurrencyAsync_003Ed__82))]
			public Task<PurchaseBattlePassCurrency.Types.Response> PurchaseBattlePassCurrencyAsync(PurchaseBattlePassCurrency.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<PurchaseBattlePassCurrency.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007191")]
			[Cpp2IlInjected.Address(RVA = "0xC80070", Offset = "0xC7EA70", VA = "0x180C80070")]
			public Task<DebugAddOnlineCurrency.Types.Response> DebugAddOnlineCurrencyAsync(DebugAddOnlineCurrency.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugAddOnlineCurrency.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007192")]
			[Cpp2IlInjected.Address(RVA = "0xC80220", Offset = "0xC7EC20", VA = "0x180C80220")]
			[AsyncStateMachine(typeof(_003CDebugAddOnlineCurrencyAsync_003Ed__84))]
			public Task<DebugAddOnlineCurrency.Types.Response> DebugAddOnlineCurrencyAsync(DebugAddOnlineCurrency.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugAddOnlineCurrency.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007193")]
			[Cpp2IlInjected.Address(RVA = "0xC80520", Offset = "0xC7EF20", VA = "0x180C80520")]
			public Task<DebugSpendOnlineCurrency.Types.Response> DebugSpendOnlineCurrencyAsync(DebugSpendOnlineCurrency.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<DebugSpendOnlineCurrency.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007194")]
			[Cpp2IlInjected.Address(RVA = "0xC803A0", Offset = "0xC7EDA0", VA = "0x180C803A0")]
			[AsyncStateMachine(typeof(_003CDebugSpendOnlineCurrencyAsync_003Ed__86))]
			public Task<DebugSpendOnlineCurrency.Types.Response> DebugSpendOnlineCurrencyAsync(DebugSpendOnlineCurrency.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<DebugSpendOnlineCurrency.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007195")]
			[Cpp2IlInjected.Address(RVA = "0xC86E50", Offset = "0xC85850", VA = "0x180C86E50")]
			public Task<SyncOnline.Types.Response> SyncOnlineAsync(SyncOnline.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SyncOnline.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007196")]
			[Cpp2IlInjected.Address(RVA = "0xC86CD0", Offset = "0xC856D0", VA = "0x180C86CD0")]
			[AsyncStateMachine(typeof(_003CSyncOnlineAsync_003Ed__88))]
			public Task<SyncOnline.Types.Response> SyncOnlineAsync(SyncOnline.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SyncOnline.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007197")]
			[Cpp2IlInjected.Address(RVA = "0xC874B0", Offset = "0xC85EB0", VA = "0x180C874B0")]
			public Task<SyncOnlineInventory.Types.Response> SyncOnlineInventoryAsync(SyncOnlineInventory.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SyncOnlineInventory.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007198")]
			[Cpp2IlInjected.Address(RVA = "0xC87330", Offset = "0xC85D30", VA = "0x180C87330")]
			[AsyncStateMachine(typeof(_003CSyncOnlineInventoryAsync_003Ed__90))]
			public Task<SyncOnlineInventory.Types.Response> SyncOnlineInventoryAsync(SyncOnlineInventory.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SyncOnlineInventory.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x6007199")]
			[Cpp2IlInjected.Address(RVA = "0xC87180", Offset = "0xC85B80", VA = "0x180C87180")]
			public Task<SyncOnlineCurrencies.Types.Response> SyncOnlineCurrenciesAsync(SyncOnlineCurrencies.Types.Request request, CancellationToken cancellationToken)
			{
				//IL_0006: Expected O, but got I4
				int num = default(int);
				CallOptions callOptions = new CallOptions((MetadataCollection)num);
				num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result = default(Task<>);
				return (Task<SyncOnlineCurrencies.Types.Response>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600719A")]
			[Cpp2IlInjected.Address(RVA = "0xC87000", Offset = "0xC85A00", VA = "0x180C87000")]
			[AsyncStateMachine(typeof(_003CSyncOnlineCurrenciesAsync_003Ed__92))]
			public Task<SyncOnlineCurrencies.Types.Response> SyncOnlineCurrenciesAsync(SyncOnlineCurrencies.Types.Request request, CallOptions callOptions, CancellationToken cancellationToken)
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<SyncOnlineCurrencies.Types.Response>)(object)result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40032FD")]
		private static readonly MethodDescriptor LoginMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40032FE")]
		private static readonly MethodDescriptor PostLoginMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x40032FF")]
		private static readonly MethodDescriptor AutoRedeemFoundersPackMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003300")]
		private static readonly MethodDescriptor TransferMarketplacePacksMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003301")]
		private static readonly MethodDescriptor GetFilesMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003302")]
		private static readonly MethodDescriptor ValidateActionsMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003303")]
		private static readonly MethodDescriptor FollowUserMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003304")]
		private static readonly MethodDescriptor GetFollowDataMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003305")]
		private static readonly MethodDescriptor ListConnectionsMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003306")]
		private static readonly MethodDescriptor GetConnectionsCountMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003307")]
		private static readonly MethodDescriptor SuggestFollowerMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003308")]
		private static readonly MethodDescriptor SearchFriendsMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003309")]
		private static readonly MethodDescriptor CreateNewsFeedMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400330A")]
		private static readonly MethodDescriptor GetUserPostsMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400330B")]
		private static readonly MethodDescriptor LikeNewsFeedMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400330C")]
		private static readonly MethodDescriptor UnlikeNewsFeedMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400330D")]
		private static readonly MethodDescriptor GetInboxMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400330E")]
		private static readonly MethodDescriptor PurgeInboxMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400330F")]
		private static readonly MethodDescriptor AddInboxMessageMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003310")]
		private static readonly MethodDescriptor RemoveInboxMessageMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003311")]
		private static readonly MethodDescriptor ReadInboxMessagesMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003312")]
		private static readonly MethodDescriptor ClaimInboxMessagesMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003313")]
		private static readonly MethodDescriptor RefundInboxMessagesMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003314")]
		private static readonly MethodDescriptor PostPictureMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003315")]
		private static readonly MethodDescriptor EditPictureMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003316")]
		private static readonly MethodDescriptor SetPlayfabNameMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003317")]
		private static readonly MethodDescriptor SetPlayfabAvatarMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003318")]
		private static readonly MethodDescriptor ResetPlayfabNameChangeCooldownMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003319")]
		private static readonly MethodDescriptor SpendEntryTicketsMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400331A")]
		private static readonly MethodDescriptor GainVotingTicketsMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400331B")]
		private static readonly MethodDescriptor BuyIAPMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400331C")]
		private static readonly MethodDescriptor OnlineClaimPromoCodeMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400331D")]
		private static readonly MethodDescriptor OnlineCollectLootPresentMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400331E")]
		private static readonly MethodDescriptor GetBundlesMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400331F")]
		private static readonly MethodDescriptor GetStoresMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003320")]
		private static readonly MethodDescriptor StorePurchaseMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003321")]
		private static readonly MethodDescriptor GetBattlePassesMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003322")]
		private static readonly MethodDescriptor CollectBattlePassTaskCurrencyMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003323")]
		private static readonly MethodDescriptor PurchaseBattlePassRewardMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003324")]
		private static readonly MethodDescriptor PurchasePremiumPassMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003325")]
		private static readonly MethodDescriptor PurchaseBattlePassCurrencyMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003326")]
		private static readonly MethodDescriptor DebugAddOnlineCurrencyMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003327")]
		private static readonly MethodDescriptor DebugSpendOnlineCurrencyMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003328")]
		private static readonly MethodDescriptor SyncOnlineMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x4003329")]
		private static readonly MethodDescriptor SyncOnlineInventoryMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x400332A")]
		private static readonly MethodDescriptor SyncOnlineCurrenciesMethodDesc;

		[Cpp2IlInjected.Token(Token = "0x170013B1")]
		[field: Cpp2IlInjected.Token(Token = "0x40032FC")]
		public static ServiceDescriptor ServiceDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006FC9")]
			[Cpp2IlInjected.Address(RVA = "0x1832A90", Offset = "0x1831490", VA = "0x181832A90")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6006FCA")]
		[Cpp2IlInjected.Address(RVA = "0x1831140", Offset = "0x182FB40", VA = "0x181831140")]
		static SocialService()
		{
			ServiceDescriptor serviceDescriptor = default(ServiceDescriptor);
			ServiceDescriptor = serviceDescriptor;
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("Login");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("PostLogin");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("AutoRedeemFoundersPack");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("TransferMarketplacePacks");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("GetFiles");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("ValidateActions");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("FollowUser");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("GetFollowData");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("ListConnections");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("GetConnectionsCount");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("SuggestFollower");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("SearchFriends");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("CreateNewsFeed");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("GetUserPosts");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("LikeNewsFeed");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("UnlikeNewsFeed");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("GetInbox");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("PurgeInbox");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("AddInboxMessage");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("RemoveInboxMessage");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("ReadInboxMessages");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("ClaimInboxMessages");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("RefundInboxMessages");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("PostPicture");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("EditPicture");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("SetPlayfabName");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("SetPlayfabAvatar");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("ResetPlayfabNameChangeCooldown");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("SpendEntryTickets");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("GainVotingTickets");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("BuyIAP");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("OnlineClaimPromoCode");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("OnlineCollectLootPresent");
			ServiceDescriptor = (ServiceDescriptor)(object)ServiceDescriptor.GetMethodDescriptor("GetBundles");
			/*Error: Unexpected end of block*/;
		}
	}
}
