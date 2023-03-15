using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class DefaultRequestSender : IRequestSender, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly HttpClient httpClient = new HttpClient();

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		[field: Cpp2IlInjected.Token(Token = "0x400002E")]
		public static IRequestSender Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x40335A0", Offset = "0x4031FA0", VA = "0x1840335A0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4033420", Offset = "0x4031E20", VA = "0x184033420", Slot = "4")]
		Task<HttpResponseMessage> IRequestSender.SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, string path, IReadableConfiguration configuration, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0009
			HttpClient httpClient = this.httpClient;
			Task<HttpResponseMessage> result = default(Task<HttpResponseMessage>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4033400", Offset = "0x4031E00", VA = "0x184033400", Slot = "5")]
		public void Dispose()
		{
			//Discarded unreachable code: IL_000c
			httpClient.Dispose();
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4033530", Offset = "0x4031F30", VA = "0x184033530")]
		public DefaultRequestSender()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4033450", Offset = "0x4031E50", VA = "0x184033450")]
		static DefaultRequestSender()
		{
			DefaultRequestSender defaultRequestSender = new DefaultRequestSender();
			HttpClient httpClient = (defaultRequestSender.httpClient = new HttpClient());
			RedirectInterceptor redirectInterceptor = default(RedirectInterceptor);
			redirectInterceptor.next = defaultRequestSender;
			Instance = redirectInterceptor;
			/*Error: Unexpected end of block*/;
		}
	}
}
