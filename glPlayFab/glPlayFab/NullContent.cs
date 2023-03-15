using System.Collections.Generic;
using System.Net.Http;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class NullContent : IHttpContent
	{
		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x1034440", Offset = "0x1032E40", VA = "0x181034440", Slot = "4")]
			get
			{
				return "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "5")]
		public HttpContent Create(Dictionary<string, string> parameters)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public NullContent()
		{
		}
	}
}
