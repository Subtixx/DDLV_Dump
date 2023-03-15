using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public delegate Interceptor InterceptorFunc(HostBuilderState builderState, ICallInvoker invoker);
}
