using System.Collections.Generic;
using Cpp2IlInjected;
using Meta.Social;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000996")]
	public interface IOnlinePayload
	{
		[Cpp2IlInjected.Token(Token = "0x17000E98")]
		IReadOnlyDictionary<string, Statistic> Statistics
		{
			[Cpp2IlInjected.Token(Token = "0x6005420")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000E99")]
		IReadOnlyDictionary<int, Amount> Items
		{
			[Cpp2IlInjected.Token(Token = "0x6005421")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000E9A")]
		IReadOnlyDictionary<int, Amount> Currencies
		{
			[Cpp2IlInjected.Token(Token = "0x6005422")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
}
