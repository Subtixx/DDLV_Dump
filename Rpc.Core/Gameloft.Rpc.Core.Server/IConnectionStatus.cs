using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public interface IConnectionStatus
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task ClientConnectedAsync(AuthContext authContext, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task ClientDisconnectedAsync(AuthContext authContext, CancellationToken ct);
	}
}
