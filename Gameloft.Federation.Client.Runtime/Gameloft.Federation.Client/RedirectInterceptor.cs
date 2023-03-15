using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class RedirectInterceptor : IRequestSender
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly IRequestSender next;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public RedirectInterceptor(IRequestSender next)
		{
			this.next = next;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4033BF0", Offset = "0x40325F0", VA = "0x184033BF0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CGameloft_002DFederation_002DClient_002DIRequestSender_002DSendAsync_003Ed__2))]
		Task<HttpResponseMessage> IRequestSender.SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, string path, IReadableConfiguration configuration, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<HttpResponseMessage>)(object)result;
		}
	}
}
