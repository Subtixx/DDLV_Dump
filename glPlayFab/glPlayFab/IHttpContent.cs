using System.Collections.Generic;
using System.Net.Http;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public interface IHttpContent
	{
		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		string Type
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		HttpContent Create(Dictionary<string, string> parameters);
	}
}
