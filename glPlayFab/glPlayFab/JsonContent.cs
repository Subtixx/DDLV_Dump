using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public class JsonContent : IHttpContent
	{
		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x10329C0", Offset = "0x10313C0", VA = "0x1810329C0", Slot = "4")]
			get
			{
				return "application/json";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x10328E0", Offset = "0x10312E0", VA = "0x1810328E0", Slot = "5")]
		public HttpContent Create(Dictionary<string, string> parameters)
		{
			string content = JsonConvert.SerializeObject(parameters);
			int num = 0;
			Encoding uTF = Encoding.UTF8;
			StringContent stringContent = new StringContent(content, uTF, "application/json");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public JsonContent()
		{
		}
	}
}
