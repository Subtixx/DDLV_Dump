using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public interface IRequestProcessor
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<WrappedResponse> HandleRequestAsync(WrappedRequest request, AuthContext authContext, CallerContext callerContext, CancellationToken ct);
	}
}
