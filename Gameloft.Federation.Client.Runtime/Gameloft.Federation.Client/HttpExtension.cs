using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class HttpExtension
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static System.Net.Http.HttpMethod Patch
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x4033A20", Offset = "0x4032420", VA = "0x184033A20")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4033730", Offset = "0x4032130", VA = "0x184033730")]
		[AsyncStateMachine(typeof(_003CCloneAsync_003Ed__3))]
		public static Task<HttpRequestMessage> CloneAsync(this HttpRequestMessage request)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<HttpRequestMessage>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4033870", Offset = "0x4032270", VA = "0x184033870")]
		[AsyncStateMachine(typeof(_003CCloneAsync_003Ed__4))]
		private static Task<HttpContent> CloneAsync(this HttpContent content)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<HttpContent>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x40339A0", Offset = "0x40323A0", VA = "0x1840339A0")]
		static HttpExtension()
		{
			System.Net.Http.HttpMethod httpMethod = new System.Net.Http.HttpMethod("PATCH");
			/*Error: Unexpected end of block*/;
		}
	}
}
