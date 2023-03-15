using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;

namespace Gameloft.Rpc.Core.Client
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public abstract class Transport : ICallInvoker
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int requestIdGenerator;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400010E")]
		protected IClientAuthentication Authentication
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x38E4290", Offset = "0x38E2C90", VA = "0x1838E4290")]
		protected Transport(IClientAuthentication authentication)
		{
			if (authentication == null)
			{
			}
			Authentication = authentication;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x175B550", Offset = "0x1759F50", VA = "0x18175B550", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInvokeAsync_003Ed__5<, >))]
		public Task<CallResult<TReply>> InvokeAsync<TReply, TRequest>(TRequest request, CallContext context) where TReply : IMessage, new()where TRequest : IMessage, new()
		{
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CallResult<TReply>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract Task<WrappedResponse> SendRequestAsync(WrappedRequest wrappedRequest, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x38E4280", Offset = "0x38E2C80", VA = "0x1838E4280")]
		private int CreateRequestId()
		{
			int num = requestIdGenerator;
			return requestIdGenerator = num + 1;
		}
	}
}
