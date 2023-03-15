using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class DelegateInterceptor : Interceptor
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public delegate void Func(CallContext context);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly Func before;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly Func after;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x38DABF0", Offset = "0x38D95F0", VA = "0x1838DABF0")]
		internal DelegateInterceptor(ICallInvoker continuationInvoker, Func before, Func after)
		{
			base.continuationInvoker = continuationInvoker;
			if ((object)typeof(IService).TypeHandle == null)
			{
			}
			base.Service = (IService)typeof(IService).TypeHandle;
			this.before = before;
			this.after = after;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x16DAF40", Offset = "0x16D9940", VA = "0x1816DAF40", Slot = "6")]
		[AsyncStateMachine(typeof(_003CInvokeAsync_003Ed__4<, >))]
		public override Task<CallResult<TReply>> InvokeAsync<TReply, TRequest>(TRequest request, CallContext context)
		{
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CallResult<TReply>>)(object)result;
		}
	}
}
