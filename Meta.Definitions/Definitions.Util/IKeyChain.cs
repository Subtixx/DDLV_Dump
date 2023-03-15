using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	public interface IKeyChain
	{
		[Cpp2IlInjected.Token(Token = "0x6000D9D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Get(string key);

		[Cpp2IlInjected.Token(Token = "0x6000D9E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string Set(string key, string value);

		[Cpp2IlInjected.Token(Token = "0x6000D9F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool TryGet(string key, out string value);

		[Cpp2IlInjected.Token(Token = "0x6000DA0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Delete(string key);
	}
}
