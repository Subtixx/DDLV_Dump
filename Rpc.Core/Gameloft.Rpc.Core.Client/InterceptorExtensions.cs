using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public static class InterceptorExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public delegate Interceptor CreatorFunc(ICallInvoker callInvoker);

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x38DDF20", Offset = "0x38DC920", VA = "0x1838DDF20")]
		public static Interceptor Intercept(this ICallInvoker callInvoker, CreatorFunc func)
		{
			//Discarded unreachable code: IL_0008
			return func(callInvoker);
		}
	}
}
