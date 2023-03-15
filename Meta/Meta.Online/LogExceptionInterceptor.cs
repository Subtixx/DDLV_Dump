using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Rpc.Core;
using Gameloft.Rpc.Core.Client;
using Serilog;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F24")]
	internal class LogExceptionInterceptor : Interceptor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003DCB")]
		private readonly Client client;

		[Cpp2IlInjected.Token(Token = "0x170015A4")]
		private Serilog.ILogger logger
		{
			[Cpp2IlInjected.Token(Token = "0x6007C82")]
			[Cpp2IlInjected.Address(RVA = "0x7BA190", Offset = "0x7B8B90", VA = "0x1807BA190")]
			get
			{
				//Discarded unreachable code: IL_000c
				return client.Log;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007C83")]
		[Cpp2IlInjected.Address(RVA = "0x7BA150", Offset = "0x7B8B50", VA = "0x1807BA150")]
		public LogExceptionInterceptor(ICallInvoker continuationInvoker, Client client)
			: base(continuationInvoker)
		{
			this.client = client;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C84")]
		[Cpp2IlInjected.Address(RVA = "0x19C3450", Offset = "0x19C1E50", VA = "0x1819C3450", Slot = "5")]
		[AsyncStateMachine(typeof(_003CInvokeAsync_003Ed__4<, >))]
		public override Task<CallResult<TReply>> InvokeAsync<TReply, TRequest>(TRequest request, CallContext context)
		{
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CallResult<TReply>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C85")]
		[Cpp2IlInjected.Address(RVA = "0x18B0770", Offset = "0x18AF170", VA = "0x1818B0770")]
		private bool LogException(RpcException e)
		{
			if (client.Log != null)
			{
				string text = e.ToString();
			}
			int num = 0;
			throw new NullReferenceException();
		}
	}
}
