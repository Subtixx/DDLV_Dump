using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface IAsynchronousClient
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<ApiResponse<T>> GetAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration, [Optional] CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<ApiResponse<T>> PostAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration, [Optional] CancellationToken ct);
	}
}
