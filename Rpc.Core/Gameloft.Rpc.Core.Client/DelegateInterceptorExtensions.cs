using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Client
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public static class DelegateInterceptorExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x38DAA20", Offset = "0x38D9420", VA = "0x1838DAA20")]
		public static Interceptor Intercept(this ICallInvoker callInvoker, [Optional] DelegateInterceptor.Func before, [Optional] DelegateInterceptor.Func after)
		{
			DelegateInterceptor delegateInterceptor = default(DelegateInterceptor);
			((Interceptor)delegateInterceptor).continuationInvoker = callInvoker;
			delegateInterceptor.before = before;
			delegateInterceptor.after = after;
			/*Error: Unexpected end of block*/;
		}
	}
}
