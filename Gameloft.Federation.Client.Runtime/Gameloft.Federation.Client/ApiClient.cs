using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class ApiClient : ISynchronousClient, IAsynchronousClient
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly string baseUrl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly IReadOnlyDictionary<string, Func<RequestOptions, HttpContent>> contentConverters;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x40321E0", Offset = "0x4030BE0", VA = "0x1840321E0")]
		public unsafe ApiClient(string basePath)
		{
			//Discarded unreachable code: IL_0030, IL_0047, IL_005f
			//IL_0027: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			//IL_0054: Expected O, but got I4
			if ("multipart/form-data" == null)
			{
				baseUrl = basePath;
				Dictionary<string, Func<RequestOptions, HttpContent>> dictionary = (Dictionary<string, Func<RequestOptions, HttpContent>>)(object)new Dictionary<TKey, TValue>();
				int num = default(int);
				Func<RequestOptions, HttpContent> func = (Func<RequestOptions, HttpContent>)(object)new Func<T, TResult>(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<RequestOptions, HttpContent>*/)(&ToJsonContent));
				num = 0;
				throw new NullReferenceException();
			}
			ArgumentException ex = new ArgumentException("basePath cannot be empty");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4031570", Offset = "0x402FF70", VA = "0x184031570")]
		private static System.Net.Http.HttpMethod ToHttpMethod(HttpMethod method)
		{
			//Discarded unreachable code: IL_000a, IL_0010, IL_0016, IL_001c, IL_0022
			while (method > HttpMethod.Patch)
			{
			}
			return System.Net.Http.HttpMethod.get_method;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x40319D0", Offset = "0x40303D0", VA = "0x1840319D0")]
		private static HttpContent ToJsonContent(RequestOptions options)
		{
			CustomJsonCodec customJsonCodec = new CustomJsonCodec();
			JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
			jsonSerializerSettings.ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor;
			DefaultContractResolver defaultContractResolver = new DefaultContractResolver();
			CamelCaseNamingStrategy camelCaseNamingStrategy = new CamelCaseNamingStrategy();
			((NamingStrategy)camelCaseNamingStrategy).OverrideSpecifiedNames = true;
			defaultContractResolver.NamingStrategy = camelCaseNamingStrategy;
			jsonSerializerSettings.ContractResolver = defaultContractResolver;
			jsonSerializerSettings.NullValueHandling = NullValueHandling.Ignore;
			customJsonCodec.serializerSettings = jsonSerializerSettings;
			object _003CData_003Ek__BackingField = options.Data;
			JsonSerializerSettings serializerSettings = customJsonCodec.serializerSettings;
			string content = JsonConvert.SerializeObject(_003CData_003Ek__BackingField, serializerSettings);
			int num = 0;
			Encoding uTF = Encoding.UTF8;
			StringContent stringContent = new StringContent(content, uTF, "application/json");
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x40313B0", Offset = "0x402FDB0", VA = "0x1840313B0")]
		private static HttpContent ToFormUrlEncodedContent(RequestOptions options)
		{
			Dictionary<string, string> _003CFormParameters_003Ek__BackingField = options.FormParameters;
			Func<KeyValuePair<string, string>, string> _003C_003E9__5_ = _003C_003Ec._003C_003E9__5_0;
			if (_003C_003E9__5_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			IEnumerable<KeyValuePair<string, string>> enumerable = (IEnumerable<KeyValuePair<string, string>>)Enumerable.Select<KeyValuePair<string, string>, string>((IEnumerable<>)_003CFormParameters_003Ek__BackingField, (Func<, >)(object)_003C_003E9__5_);
			string content = string.Join("&", (IEnumerable<>)enumerable);
			int num = 0;
			Encoding uTF = Encoding.UTF8;
			StringContent stringContent = new StringContent(content, uTF, "application/x-www-form-urlencoded");
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4031BE0", Offset = "0x40305E0", VA = "0x184031BE0")]
		private static HttpContent ToMultipartFormDataContent(RequestOptions options)
		{
			//Discarded unreachable code: IL_0029, IL_002f, IL_0035
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
			Dictionary<string, string> _003CFormParameters_003Ek__BackingField = options.FormParameters;
			bool flag = default(bool);
			if (flag)
			{
			}
			bool flag2 = default(bool);
			if (flag2)
			{
			}
			bool flag3 = default(bool);
			if (flag3)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x40308E0", Offset = "0x402F2E0", VA = "0x1840308E0")]
		private HttpRequestMessage NewRequest(HttpMethod method, string path, RequestOptions options, IReadableConfiguration configuration)
		{
			//Discarded unreachable code: IL_0148, IL_014e, IL_0154, IL_0160
			//IL_011b: Expected O, but got I4
			bool flag = default(bool);
			string oldValue = default(string);
			string newValue = default(string);
			Multimap<string, string> _003CQueryParameters_003Ek__BackingField2 = default(Multimap<string, string>);
			Func<KeyValuePair<string, IList<string>>, string> func = default(Func<KeyValuePair<string, IList<string>>, string>);
			string text2 = default(string);
			string requestUri = default(string);
			System.Net.Http.HttpMethod method2 = default(System.Net.Http.HttpMethod);
			uint num4 = default(uint);
			bool flag2 = default(bool);
			Func<string, bool> func2 = default(Func<string, bool>);
			Func<string, Func<RequestOptions, HttpContent>> func3 = default(Func<string, Func<RequestOptions, HttpContent>>);
			HttpContent _003CContent_003Ek__BackingField = default(HttpContent);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				HttpRequestMessage httpRequestMessage;
				IEnumerator<> enumerator;
				if (path != null)
				{
					if (options == null)
					{
						continue;
					}
					if (options.PathParameters != null && flag)
					{
						string text = path.Replace(oldValue, newValue);
					}
					string uri = "&" + path;
					Multimap<string, string> _003CQueryParameters_003Ek__BackingField = options.QueryParameters;
					if (_003CQueryParameters_003Ek__BackingField != null && ((Multimap<TKey, TValue>)(object)_003CQueryParameters_003Ek__BackingField).Count > 0)
					{
						UriBuilder uriBuilder = new UriBuilder(uri);
						_003CQueryParameters_003Ek__BackingField2 = options.QueryParameters;
						if (_003C_003Ec._003C_003E9__7_0 == null)
						{
							func = (Func<KeyValuePair<string, IList<string>>, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
							{
								throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
							});
						}
						IEnumerable<KeyValuePair<string, IList<string>>> enumerable = (IEnumerable<KeyValuePair<string, IList<string>>>)Enumerable.Select<KeyValuePair<string, IList<string>>, string>((IEnumerable<>)_003CQueryParameters_003Ek__BackingField2, (Func<, >)(object)func);
						string text4 = (uriBuilder.Query = string.Join(text2, (IEnumerable<>)enumerable));
						requestUri = uriBuilder.Uri.ToString();
					}
					httpRequestMessage = new HttpRequestMessage(method2, requestUri);
					Multimap<string, string> _003CHeaderParameters_003Ek__BackingField = options.HeaderParameters;
					if (_003CHeaderParameters_003Ek__BackingField != null)
					{
						enumerator = ((Multimap<TKey, TValue>)(object)_003CHeaderParameters_003Ek__BackingField).GetEnumerator();
						if (enumerator != null)
						{
							if (num < (int)num4)
							{
								num += num;
								if (num == (int)num4)
								{
									goto IL_00f8;
								}
								num++;
							}
							int num5 = 0;
							if (num != 0)
							{
								HttpRequestHeaders headers = httpRequestMessage.Headers;
							}
							goto IL_00f8;
						}
						goto IL_0101;
					}
					goto IL_010e;
				}
				ArgumentNullException ex = new ArgumentNullException("path");
				throw new NullReferenceException();
				IL_0101:
				if (enumerator != null)
				{
					int num6 = 0;
				}
				if (_003CQueryParameters_003Ek__BackingField2 != null)
				{
					break;
				}
				goto IL_010e;
				IL_00f8:
				if (num != 0)
				{
				}
				if (_003CQueryParameters_003Ek__BackingField2 != null)
				{
					throw new NullReferenceException();
				}
				goto IL_0101;
				IL_010e:
				if (flag2)
				{
					if (Enumerable.FirstOrDefault<Func<RequestOptions, HttpContent>>(Enumerable.Select<string, Func<RequestOptions, HttpContent>>(Enumerable.Where<string>((IEnumerable<>)num, (Func<, >)(object)func2), (Func<, >)(object)func3)) == null)
					{
						break;
					}
					httpRequestMessage.Content = _003CContent_003Ek__BackingField;
				}
				return httpRequestMessage;
			}
			ArgumentException ex2 = new ArgumentException("Unsupported content type", "options");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2D6B990", Offset = "0x2D6A390", VA = "0x182D6B990")]
		[AsyncStateMachine(typeof(_003CToApiResponseAsync_003Ed__8<>))]
		private Task<ApiResponse<T>> ToApiResponseAsync<T>(HttpResponseMessage response, CustomJsonCodec jsonCodec)
		{
			int num = 0;
			int num2 = 0;
			Task<> result = default(Task<>);
			return (Task<ApiResponse<T>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4031230", Offset = "0x402FC30", VA = "0x184031230")]
		[AsyncStateMachine(typeof(_003CSendAsync_003Ed__11))]
		private static Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, string path, IReadableConfiguration configuration, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<HttpResponseMessage>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2D6B770", Offset = "0x2D6A170", VA = "0x182D6B770")]
		[AsyncStateMachine(typeof(_003CExecAsync_003Ed__12<>))]
		private Task<ApiResponse<T>> ExecAsync<T>(HttpMethod method, string path, RequestOptions options, IReadableConfiguration configuration, CancellationToken ct)
		{
			Task<> result = default(Task<>);
			return (Task<ApiResponse<T>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2D6B900", Offset = "0x2D6A300", VA = "0x182D6B900", Slot = "4")]
		public Task<ApiResponse<T>> GetAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration, CancellationToken ct)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2D6B940", Offset = "0x2D6A340", VA = "0x182D6B940", Slot = "5")]
		public Task<ApiResponse<T>> PostAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration, CancellationToken ct)
		{
			throw new NullReferenceException();
		}
	}
}
