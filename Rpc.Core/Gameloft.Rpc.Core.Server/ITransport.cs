using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface ITransport
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task StartAsync(IRequestProcessor processor, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task StopAsync(CancellationToken token);
	}
}
