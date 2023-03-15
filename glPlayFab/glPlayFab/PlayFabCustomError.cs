using Cpp2IlInjected;
using PlayFab;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	public class PlayFabCustomError : PlayFabError
	{
		[Cpp2IlInjected.Token(Token = "0x200012B")]
		public enum CustomErrorCode
		{
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			Success = 50000,
			[Cpp2IlInjected.Token(Token = "0x400047C")]
			HttpRequestTimeout,
			[Cpp2IlInjected.Token(Token = "0x400047D")]
			HttpRequestCancelled,
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			MissingRequestData
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public CustomErrorCode CustomError;

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		public bool IsTimeoutError
		{
			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x103C8B0", Offset = "0x103B2B0", VA = "0x18103C8B0")]
			get
			{
				return CustomError == CustomErrorCode.HttpRequestTimeout;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x103C850", Offset = "0x103B250", VA = "0x18103C850")]
		public PlayFabCustomError()
		{
		}
	}
}
