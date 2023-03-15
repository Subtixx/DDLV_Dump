using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Rpc.Core;
using Gameloft.Rpc.Core.Client;
using Serilog;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F26")]
	internal class PlayFabRequestResultInterceptor : Interceptor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003DD4")]
		private readonly Client client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003DD5")]
		private int consecutiveNetworkErrorFailures;

		[Cpp2IlInjected.Token(Token = "0x4003DD6")]
		private const int maxConsecutiveNetworkFailures = 3;

		[Cpp2IlInjected.Token(Token = "0x170015A5")]
		private Serilog.ILogger logger
		{
			[Cpp2IlInjected.Token(Token = "0x6007C89")]
			[Cpp2IlInjected.Address(RVA = "0x7BA190", Offset = "0x7B8B90", VA = "0x1807BA190")]
			get
			{
				//Discarded unreachable code: IL_000c
				return client.Log;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007C8A")]
		[Cpp2IlInjected.Address(RVA = "0x7BA150", Offset = "0x7B8B50", VA = "0x1807BA150")]
		public PlayFabRequestResultInterceptor(ICallInvoker continuationInvoker, Client client)
			: base(continuationInvoker)
		{
			this.client = client;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C8B")]
		[Cpp2IlInjected.Address(RVA = "0x26D25C0", Offset = "0x26D0FC0", VA = "0x1826D25C0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CInvokeAsync_003Ed__6<, >))]
		public override Task<CallResult<TReply>> InvokeAsync<TReply, TRequest>(TRequest request, CallContext context)
		{
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CallResult<TReply>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C8C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA140", Offset = "0x7B8B40", VA = "0x1807BA140")]
		private void ResetNetworkErrorFailures()
		{
			//IL_0009: Expected I4, but got I8
			consecutiveNetworkErrorFailures = 0;
		}
	}
}
