using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001E4")]
	public interface IHasShortcutIndicators
	{
		[Cpp2IlInjected.Token(Token = "0x1700026B")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000C5D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700026C")]
		List<ShortcutIndicatorSetTemplate> ShortcutIndicatorSets
		{
			[Cpp2IlInjected.Token(Token = "0x6000C5E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ShortcutIndicatorSetTemplate GetCurrentShortcutIndicatorSet();
	}
}
