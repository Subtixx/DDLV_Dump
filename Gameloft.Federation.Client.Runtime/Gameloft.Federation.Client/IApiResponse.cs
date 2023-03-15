using System.Net;
using Cpp2IlInjected;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface IApiResponse
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		HttpStatusCode StatusCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		string RawContent
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
