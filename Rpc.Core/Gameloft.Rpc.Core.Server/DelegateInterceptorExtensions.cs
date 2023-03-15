using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class DelegateInterceptorExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x38DAAC0", Offset = "0x38D94C0", VA = "0x1838DAAC0")]
		public static Interceptor Intercept(this ICallInvoker callInvoker, [Optional] DelegateInterceptor.Func before, [Optional] DelegateInterceptor.Func after)
		{
			DelegateInterceptor delegateInterceptor = new DelegateInterceptor(callInvoker, before, after);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x38DAB40", Offset = "0x38D9540", VA = "0x1838DAB40")]
		[IteratorStateMachine(typeof(_003CIntercept_003Ed__1))]
		public static IEnumerable<ICallInvoker> Intercept(this IEnumerable<ICallInvoker> callInvokers, [Optional] DelegateInterceptor.Func before, [Optional] DelegateInterceptor.Func after)
		{
			//IL_0012: Expected I4, but got I8
			//IL_0020: Expected I4, but got O
			int num = 0;
			_003CIntercept_003Ed__1 _003CIntercept_003Ed__ = default(_003CIntercept_003Ed__1);
			_003CIntercept_003Ed__._003C_003E1__state = -2;
			_003CIntercept_003Ed__._003C_003E3__callInvokers = callInvokers;
			_003CIntercept_003Ed__._003C_003El__initialThreadId = (int)_003CIntercept_003Ed__;
			_003CIntercept_003Ed__._003C_003E3__before = before;
			_003CIntercept_003Ed__._003C_003E3__after = after;
			/*Error: Unexpected end of block*/;
		}
	}
}
