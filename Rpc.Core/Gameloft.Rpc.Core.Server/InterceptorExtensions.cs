using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public static class InterceptorExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public delegate Interceptor CreatorFunc(ICallInvoker callInvoker);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x38DDF20", Offset = "0x38DC920", VA = "0x1838DDF20")]
		public static Interceptor Intercept(this ICallInvoker callInvoker, CreatorFunc func)
		{
			//Discarded unreachable code: IL_0008
			return func(callInvoker);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x38DDE90", Offset = "0x38DC890", VA = "0x1838DDE90")]
		[IteratorStateMachine(typeof(_003CIntercept_003Ed__2))]
		public static IEnumerable<ICallInvoker> Intercept(this IEnumerable<ICallInvoker> callInvokers, CreatorFunc func)
		{
			//IL_0012: Expected I4, but got I8
			//IL_0020: Expected I4, but got O
			int num = 0;
			_003CIntercept_003Ed__2 _003CIntercept_003Ed__ = default(_003CIntercept_003Ed__2);
			_003CIntercept_003Ed__._003C_003E1__state = -2;
			_003CIntercept_003Ed__._003C_003E3__callInvokers = callInvokers;
			_003CIntercept_003Ed__._003C_003El__initialThreadId = (int)_003CIntercept_003Ed__;
			_003CIntercept_003Ed__._003C_003E3__func = func;
			/*Error: Unexpected end of block*/;
		}
	}
}
