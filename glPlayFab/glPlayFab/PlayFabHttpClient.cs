using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class PlayFabHttpClient
	{
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private static HttpClientWithTimeout httpClient;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public static HttpClientWithTimeout Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x103E220", Offset = "0x103CC20", VA = "0x18103E220")]
			get
			{
				HttpClientWithTimeout httpClientWithTimeout = new HttpClientWithTimeout();
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public PlayFabHttpClient()
		{
		}
	}
}
