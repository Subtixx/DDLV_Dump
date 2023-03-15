using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Rpc.Core;
using Gameloft.Rpc.Core.Client;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F1F")]
	internal class ClientInterceptor : Interceptor
	{
		[Cpp2IlInjected.Token(Token = "0x170015A1")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4003DB4")]
		private Client Client
		{
			[Cpp2IlInjected.Token(Token = "0x6007C72")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C73")]
		[Cpp2IlInjected.Address(RVA = "0x7BA150", Offset = "0x7B8B50", VA = "0x1807BA150")]
		internal ClientInterceptor(ICallInvoker continuationInvoker, Client client)
			: base(continuationInvoker)
		{
			Client = client;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C74")]
		[Cpp2IlInjected.Address(RVA = "0x16CAB70", Offset = "0x16C9570", VA = "0x1816CAB70", Slot = "5")]
		[AsyncStateMachine(typeof(_003CInvokeAsync_003Ed__4<, >))]
		public override Task<CallResult<TReply>> InvokeAsync<TReply, TRequest>(TRequest request, CallContext context)
		{
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CallResult<TReply>>)(object)result;
		}
	}
}
