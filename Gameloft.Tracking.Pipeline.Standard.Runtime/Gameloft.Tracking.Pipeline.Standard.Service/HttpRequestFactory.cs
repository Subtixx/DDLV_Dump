using Cpp2IlInjected;
using Gameloft.Tracking.Service;

namespace Gameloft.Tracking.Pipeline.Standard.Service
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal sealed class HttpRequestFactory : IHttpRequestCreatorFactory
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x28C2150", Offset = "0x28C0B50", VA = "0x1828C2150", Slot = "4")]
		public IHttpRequestCreator Create(ServiceOptions options)
		{
			return HttpRequestCreator.Create(options);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public HttpRequestFactory()
		{
		}
	}
}
