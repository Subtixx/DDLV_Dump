using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public abstract class ServiceBase : IService, ICallInvoker
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly string serviceName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly Dictionary<string, RpcMethodBinding> methods = (Dictionary<string, RpcMethodBinding>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		string IService.Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "4")]
			get
			{
				return serviceName;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public IService Service
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x7EF5A0", Offset = "0x7EDFA0", VA = "0x1807EF5A0", Slot = "6")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x38E3980", Offset = "0x38E2380", VA = "0x1838E3980")]
		public ServiceBase(string serviceName)
		{
			this.serviceName = serviceName;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x38E3760", Offset = "0x38E2160", VA = "0x1838E3760")]
		protected void AddMethod(RpcMethodBinding methodBinding)
		{
			//Discarded unreachable code: IL_001c
			Dictionary<string, RpcMethodBinding> dictionary = methods;
			string name = methodBinding.Descriptor.Name;
			((Dictionary<TKey, TValue>)(object)dictionary).Add((TKey)name, (TValue)methodBinding);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x1B22EC0", Offset = "0x1B218C0", VA = "0x181B22EC0", Slot = "7")]
		[AsyncStateMachine(typeof(_003CInvokeAsync_003Ed__8<, >))]
		public Task<CallResult<TReply>> InvokeAsync<TReply, TRequest>(TRequest request, CallContext context) where TReply : class, IMessage, new()where TRequest : class, IMessage, new()
		{
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CallResult<TReply>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x38E37E0", Offset = "0x38E21E0", VA = "0x1838E37E0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CGameloft_002DRpc_002DCore_002DServer_002DIService_002DHandleRequestAsync_003Ed__9))]
		Task<CallResult<IMessage>> IService.HandleRequestAsync(ICallInvoker callInvoker, WrappedRequest wrappedRequest, AuthContext authContext, CallerContext callerContext, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CallResult<IMessage>>)(object)result;
		}
	}
}
