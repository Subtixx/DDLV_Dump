using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Rpc.Core;
using Gameloft.Rpc.Core.Client;
using Meta.Online;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A3E")]
	internal class ClientRequestResultInterceptor : Interceptor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40028C7")]
		private readonly Client client;

		[Cpp2IlInjected.Token(Token = "0x60058A6")]
		[Cpp2IlInjected.Address(RVA = "0x7BA150", Offset = "0x7B8B50", VA = "0x1807BA150")]
		public ClientRequestResultInterceptor(ICallInvoker continuationInvoker, Client client)
			: base(continuationInvoker)
		{
			this.client = client;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60058A7")]
		[Cpp2IlInjected.Address(RVA = "0x16CACE0", Offset = "0x16C96E0", VA = "0x1816CACE0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CInvokeAsync_003Ed__2<, >))]
		public override Task<CallResult<TReply>> InvokeAsync<TReply, TRequest>(TRequest request, CallContext context)
		{
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CallResult<TReply>>)(object)result;
		}
	}
}
