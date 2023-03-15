using System.Collections.Generic;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200069A")]
	public interface ITutorializable
	{
		[Cpp2IlInjected.Token(Token = "0x1700137A")]
		bool IsTutorial
		{
			[Cpp2IlInjected.Token(Token = "0x6004AEE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700137B")]
		IEnumerable<int> IsTutorialDuringFtueEvents
		{
			[Cpp2IlInjected.Token(Token = "0x6004AEF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
