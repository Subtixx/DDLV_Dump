using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public interface IClientAuthentication
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<string> GenerateToken(CancellationToken ct);
	}
}
