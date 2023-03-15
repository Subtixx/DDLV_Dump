using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Rpc.Core;
using Gameloft.Rpc.Core.Client;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F28")]
	public class SemaphoreInterceptor : Interceptor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003DDE")]
		private Client client;

		[Cpp2IlInjected.Token(Token = "0x6007C90")]
		[Cpp2IlInjected.Address(RVA = "0x7BA150", Offset = "0x7B8B50", VA = "0x1807BA150")]
		internal SemaphoreInterceptor(ICallInvoker invoker, Client client)
			: base(invoker)
		{
			this.client = client;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C91")]
		[Cpp2IlInjected.Address(RVA = "0x1B20A70", Offset = "0x1B1F470", VA = "0x181B20A70", Slot = "5")]
		[AsyncStateMachine(typeof(_003CInvokeAsync_003Ed__2<, >))]
		public override Task<CallResult<TReply>> InvokeAsync<TReply, TRequest>(TRequest request, CallContext context)
		{
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CallResult<TReply>>)(object)result;
		}
	}
}
