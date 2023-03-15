using System.Collections.Generic;
using Cpp2IlInjected;

namespace Gameloft.Localization.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface IStringTable
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		IEnumerable<KeyValuePair<string, string>> Strings
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool TryGetValue(string key, out string value);
	}
}
