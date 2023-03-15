using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class OpenIdConnection
	{
		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public abstract string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public abstract string ClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public abstract string BaseUri
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract IOpenIdAPI CreateNewUserAPI();

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract IOpenIdAPI CreateConfirmEmailAPI();

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract IOpenIdAPI CreateAuthorizationAPI();

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract IOpenIdAPI CreateResetUserPasswordAPI();

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract IOpenIdAPI CreateNewUserPasswordAPI();

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x1034BB0", Offset = "0x10335B0", VA = "0x181034BB0")]
		public Task<HttpResponseMessage> CreateUser(OpenIdRequestParameters parameters, HttpClientWithTimeout httpClient)
		{
			HttpMethod post_method = HttpMethod.post_method;
			IOpenIdAPI openIdAPI = CreateNewUserAPI();
			return (Task<HttpResponseMessage>)(object)this.SendRequest(parameters, httpClient, post_method, openIdAPI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x1034AB0", Offset = "0x10334B0", VA = "0x181034AB0")]
		public Task<HttpResponseMessage> ConfirmEmail(OpenIdRequestParameters parameters, HttpClientWithTimeout httpClient)
		{
			HttpMethod get_method = HttpMethod.get_method;
			IOpenIdAPI openIdAPI = CreateConfirmEmailAPI();
			return (Task<HttpResponseMessage>)(object)this.SendRequest(parameters, httpClient, get_method, openIdAPI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x10349B0", Offset = "0x10333B0", VA = "0x1810349B0")]
		public Task<HttpResponseMessage> Authorize(OpenIdRequestParameters parameters, HttpClientWithTimeout httpClient)
		{
			HttpMethod post_method = HttpMethod.post_method;
			IOpenIdAPI openIdAPI = CreateAuthorizationAPI();
			return (Task<HttpResponseMessage>)(object)this.SendRequest(parameters, httpClient, post_method, openIdAPI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x1034CB0", Offset = "0x10336B0", VA = "0x181034CB0")]
		public Task<HttpResponseMessage> ResetUserPassword(OpenIdRequestParameters parameters, HttpClientWithTimeout httpClient)
		{
			HttpMethod post_method = HttpMethod.post_method;
			IOpenIdAPI openIdAPI = CreateResetUserPasswordAPI();
			return (Task<HttpResponseMessage>)(object)this.SendRequest(parameters, httpClient, post_method, openIdAPI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x1034F30", Offset = "0x1033930", VA = "0x181034F30")]
		public Task<HttpResponseMessage> SetNewUserPassword(OpenIdRequestParameters parameters, HttpClientWithTimeout httpClient)
		{
			HttpMethod post_method = HttpMethod.post_method;
			IOpenIdAPI openIdAPI = CreateNewUserPasswordAPI();
			return (Task<HttpResponseMessage>)(object)this.SendRequest(parameters, httpClient, post_method, openIdAPI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x1034DB0", Offset = "0x10337B0", VA = "0x181034DB0")]
		[AsyncStateMachine(typeof(_003CSendRequest_003Ed__16))]
		private Task<HttpResponseMessage> SendRequest(OpenIdRequestParameters parameters, HttpClientWithTimeout httpClient, HttpMethod httpMethod, IOpenIdAPI openIdApi)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<HttpResponseMessage>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x1034910", Offset = "0x1033310", VA = "0x181034910")]
		private void ApplyFixedParams(OpenIdRequestParameters parameters)
		{
			//Discarded unreachable code: IL_0012
			bool flag = default(bool);
			if (!flag)
			{
				string clientId = ClientId;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected OpenIdConnection()
		{
		}
	}
}
