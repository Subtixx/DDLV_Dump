using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F00")]
	public interface INativeNetworkManager
	{
		[Cpp2IlInjected.Token(Token = "0x6007BCC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool IsInternetAvailable();

		[Cpp2IlInjected.Token(Token = "0x6007BCD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<bool> TestInternetConnection(bool promptOnError, bool updateOnlineUser, CancellationToken ct);
	}
}
