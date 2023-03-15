using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Gameloft.Localization.Formatter;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000322")]
	public class CollectionTooltipEverywhereArea : CollectionTooltipElementModel
	{
		[Cpp2IlInjected.Token(Token = "0x600141E")]
		[Cpp2IlInjected.Address(RVA = "0x114AC40", Offset = "0x1149640", VA = "0x18114AC40", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltipElement view)
		{
			//Discarded unreachable code: IL_001b, IL_0037, IL_0049
			//IL_0014: Expected O, but got I4
			Dictionary<TextType, string> dictionary = base.Texts;
			int num = 0;
			string text = LocalizationManager.FromStringID("menu.label_village_area_everywhere", (IResolver)num);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600141F")]
		[Cpp2IlInjected.Address(RVA = "0x1148EB0", Offset = "0x11478B0", VA = "0x181148EB0")]
		public CollectionTooltipEverywhereArea()
		{
		}
	}
}
