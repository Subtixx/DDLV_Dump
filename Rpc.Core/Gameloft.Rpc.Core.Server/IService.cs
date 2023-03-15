using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface IService
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<CallResult<IMessage>> HandleRequestAsync(ICallInvoker callInvoker, WrappedRequest wrappedRequest, AuthContext authContext, CallerContext callerContext, CancellationToken ct);
	}
}
