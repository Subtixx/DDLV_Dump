using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public interface ICallInvoker
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		IService Service
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<CallResult<TReply>> InvokeAsync<TReply, TRequest>(TRequest request, CallContext context) where TReply : class, IMessage, new()where TRequest : class, IMessage, new();
	}
}
