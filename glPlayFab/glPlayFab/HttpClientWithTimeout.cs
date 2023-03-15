using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class HttpClientWithTimeout : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private const double defaultRequestTimeout = 10.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private HttpClient httpClient = new HttpClient();

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public Uri BaseAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x1030710", Offset = "0x102F110", VA = "0x181030710")]
			get
			{
				//Discarded unreachable code: IL_000c
				return httpClient.base_address;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public HttpRequestHeaders DefaultRequestHeaders
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x1030730", Offset = "0x102F130", VA = "0x181030730")]
			get
			{
				//Discarded unreachable code: IL_000c
				return httpClient.DefaultRequestHeaders;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x1030490", Offset = "0x102EE90", VA = "0x181030490")]
		public void SetBaseAddress(Uri baseAddress)
		{
			httpClient.base_address = baseAddress;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x1030640", Offset = "0x102F040", VA = "0x181030640")]
		public HttpClientWithTimeout()
		{
			//Discarded unreachable code: IL_0020
			TimeSpan timeout = default(TimeSpan);
			httpClient.Timeout = timeout;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1030570", Offset = "0x102EF70", VA = "0x181030570")]
		public HttpClientWithTimeout(double timeoutInSeconds)
		{
			//Discarded unreachable code: IL_0029
			HttpClient httpClient = this.httpClient;
			TimeSpan timeSpan2 = (httpClient.Timeout = TimeSpan.FromSeconds(timeoutInSeconds));
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x102FAE0", Offset = "0x102E4E0", VA = "0x18102FAE0", Slot = "4")]
		public void Dispose()
		{
			httpClient?.Dispose();
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x102FF50", Offset = "0x102E950", VA = "0x18102FF50")]
		public Task<HttpResponseMessage> GetAsync(string requestUri, double timeout = 10.0, [Optional] CancellationToken ct)
		{
			Func<string, CancellationToken, Task<HttpResponseMessage>> func = (Func<string, CancellationToken, Task<HttpResponseMessage>>)(object)(Func<T1, T2, TResult>)((string _requestUri, CancellationToken _ct) => (Task<HttpResponseMessage>)(object)httpClient.GetAsync(_requestUri, _ct));
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<HttpResponseMessage>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x1030120", Offset = "0x102EB20", VA = "0x181030120")]
		public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content, double timeout = 10.0, [Optional] CancellationToken ct)
		{
			Func<string, HttpContent, CancellationToken, Task<HttpResponseMessage>> func = (Func<string, HttpContent, CancellationToken, Task<HttpResponseMessage>>)(object)(Func<T1, T2, T3, TResult>)((string _requestUri, HttpContent _content, CancellationToken _ct) => (Task<HttpResponseMessage>)(object)httpClient.PostAsync(_requestUri, _content, _ct));
			Task<HttpResponseMessage> result = default(Task<HttpResponseMessage>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x10301F0", Offset = "0x102EBF0", VA = "0x1810301F0")]
		public Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content, double timeout = 10.0, [Optional] CancellationToken ct)
		{
			Func<string, HttpContent, CancellationToken, Task<HttpResponseMessage>> func = (Func<string, HttpContent, CancellationToken, Task<HttpResponseMessage>>)(object)(Func<T1, T2, T3, TResult>)((string _requestUri, HttpContent _content, CancellationToken _ct) => (Task<HttpResponseMessage>)(object)httpClient.PutAsync(_requestUri, _content, _ct));
			Task<HttpResponseMessage> result = default(Task<HttpResponseMessage>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x10302C0", Offset = "0x102ECC0", VA = "0x1810302C0")]
		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, double timeout = 10.0, [Optional] CancellationToken ct)
		{
			Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> func = (Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>>)(object)(Func<T1, T2, TResult>)delegate
			{
				((IDisposable)httpClient).Dispose();
				throw new NullReferenceException();
			};
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<HttpResponseMessage>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x102FDE0", Offset = "0x102E7E0", VA = "0x18102FDE0")]
		[AsyncStateMachine(typeof(_003CExecuteUriRequest_003Ed__14))]
		private Task<HttpResponseMessage> ExecuteUriRequest(Func<string, CancellationToken, Task<HttpResponseMessage>> request, string requestUri, double timeout, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<HttpResponseMessage>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x102FC70", Offset = "0x102E670", VA = "0x18102FC70")]
		[AsyncStateMachine(typeof(_003CExecuteContentRequest_003Ed__15))]
		private Task<HttpResponseMessage> ExecuteContentRequest(Func<string, HttpContent, CancellationToken, Task<HttpResponseMessage>> request, string requestUri, HttpContent content, double timeout, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<HttpResponseMessage>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x102FB00", Offset = "0x102E500", VA = "0x18102FB00")]
		[AsyncStateMachine(typeof(_003CExecuteBasicRequest_003Ed__16))]
		private Task<HttpResponseMessage> ExecuteBasicRequest(Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> request, HttpRequestMessage requestMessage, double timeout, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<HttpResponseMessage>)(object)result;
		}
	}
}
