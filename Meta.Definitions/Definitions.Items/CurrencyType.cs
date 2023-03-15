using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005FB")]
	public enum CurrencyType
	{
		[Cpp2IlInjected.Token(Token = "0x40020AA")]
		[OriginalName("Soft")]
		Soft = 0,
		[Cpp2IlInjected.Token(Token = "0x40020AB")]
		[OriginalName("Hard")]
		Hard = 1,
		[Cpp2IlInjected.Token(Token = "0x40020AC")]
		[OriginalName("Social")]
		Social = 2,
		[Cpp2IlInjected.Token(Token = "0x40020AD")]
		[OriginalName("Duplicate")]
		Duplicate = 3,
		[Cpp2IlInjected.Token(Token = "0x40020AE")]
		[OriginalName("CharacterShard")]
		CharacterShard = 4,
		[Cpp2IlInjected.Token(Token = "0x40020AF")]
		[OriginalName("Limited")]
		Limited = 5,
		[Cpp2IlInjected.Token(Token = "0x40020B0")]
		[OriginalName("Token")]
		Token = 7,
		[Cpp2IlInjected.Token(Token = "0x40020B1")]
		[OriginalName("StoreFrontSpecific")]
		StoreFrontSpecific = 8
	}
}
