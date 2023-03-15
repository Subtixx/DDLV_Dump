using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface IRequestSender
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, string path, IReadableConfiguration configuration, CancellationToken ct);
	}
}
