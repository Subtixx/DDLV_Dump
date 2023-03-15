using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;

namespace Gameloft.Rpc.Core.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public interface ICallInvoker
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CallResult<TReply>> InvokeAsync<TReply, TRequest>(TRequest request, CallContext context) where TReply : IMessage, new()where TRequest : IMessage, new();
	}
}
