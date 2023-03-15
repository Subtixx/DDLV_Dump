using System.Collections.Generic;
using System.Net.Http;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public class FormUrlContent : IHttpContent
	{
		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x102EAA0", Offset = "0x102D4A0", VA = "0x18102EAA0", Slot = "4")]
			get
			{
				return "application/x-www-form-urlencoded";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x102EA40", Offset = "0x102D440", VA = "0x18102EA40", Slot = "5")]
		public HttpContent Create(Dictionary<string, string> parameters)
		{
			FormUrlEncodedContent formUrlEncodedContent = new FormUrlEncodedContent((IEnumerable<>)parameters);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public FormUrlContent()
		{
		}
	}
}
