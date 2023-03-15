using System.Collections.Generic;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000697")]
	public interface ICharactersAvaibility
	{
		[Cpp2IlInjected.Token(Token = "0x6004AE9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool? CheckCharactersAvaibility(List<int> availableCharacters);
	}
}
