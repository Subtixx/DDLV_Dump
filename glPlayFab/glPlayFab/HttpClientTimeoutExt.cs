using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public static class HttpClientTimeoutExt
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x102F7D0", Offset = "0x102E1D0", VA = "0x18102F7D0")]
		[AsyncStateMachine(typeof(_003CPutBlobAsync_003Ed__0))]
		public static Task<HttpResponseMessage> PutBlobAsync(this HttpClientWithTimeout self, string requestUri, byte[] bytes, [Optional] CancellationToken cancellationToken)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<HttpResponseMessage>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x102F940", Offset = "0x102E340", VA = "0x18102F940")]
		public static Task<HttpResponseMessage> PutBlobAsync(this HttpClientWithTimeout self, string requestUri, string data, [Optional] CancellationToken cancellationToken)
		{
			//Discarded unreachable code: IL_0019
			int num = 0;
			byte[] bytes = Encoding.UTF8.GetBytes(data);
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num2 = 0;
			Task<> result = default(Task<>);
			return (Task<HttpResponseMessage>)(object)result;
		}
	}
}
