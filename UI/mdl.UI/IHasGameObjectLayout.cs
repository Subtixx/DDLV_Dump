using System.Collections.Generic;
using Cpp2IlInjected;

namespace mdl.UI
{
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	public interface IHasGameObjectLayout
	{
		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60008E9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		List<GameObjectLayoutTemplate> Layouts
		{
			[Cpp2IlInjected.Token(Token = "0x60008EA")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
