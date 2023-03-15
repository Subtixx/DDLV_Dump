using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public interface IServerAuthentication
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<bool> Verify(string token, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<AuthContext> GetAuthContext(string token, CancellationToken ct);
	}
}
