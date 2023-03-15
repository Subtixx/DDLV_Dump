using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public delegate Interceptor InterceptorFunc(HostBuilderState builderState, ICallInvoker invoker);
}
