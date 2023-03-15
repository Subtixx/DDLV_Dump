using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Client
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class DelegateInterceptor : Interceptor
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public delegate void Func(CallContext context);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly Func before;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly Func after;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x79F770", Offset = "0x79E170", VA = "0x18079F770")]
		internal DelegateInterceptor(ICallInvoker continuationInvoker, Func before, Func after)
		{
			base.continuationInvoker = continuationInvoker;
			this.before = before;
			this.after = after;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x16DB0B0", Offset = "0x16D9AB0", VA = "0x1816DB0B0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CInvokeAsync_003Ed__4<, >))]
		public override Task<CallResult<TReply>> InvokeAsync<TReply, TRequest>(TRequest request, CallContext context)
		{
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CallResult<TReply>>)(object)result;
		}
	}
}
