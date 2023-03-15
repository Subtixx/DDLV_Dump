using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	public interface IHasLayout
	{
		[Cpp2IlInjected.Token(Token = "0x17000256")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000C01")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000257")]
		List<MenuLayoutTemplate> Layouts
		{
			[Cpp2IlInjected.Token(Token = "0x6000C02")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
