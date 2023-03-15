using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Localization.Formatter;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000325")]
	public class CollectionTooltipEnergyElementModel : CollectionTooltipElementModel
	{
		[Cpp2IlInjected.Token(Token = "0x6001424")]
		[Cpp2IlInjected.Address(RVA = "0x114A940", Offset = "0x1149340", VA = "0x18114A940", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltipElement view)
		{
			//Discarded unreachable code: IL_0064
			//IL_0031: Expected O, but got I4
			if (base.ItemData != null && "collection.or_more" != null)
			{
				IItemData itemData = base.ItemData;
				bool flag = default(bool);
				if (itemData != null && itemData != null && !flag)
				{
					int num = 0;
					string text = LocalizationManager.FromStringID("collection.or_more", (IResolver)num);
					string text2 = " " + text;
				}
				Dictionary<TextType, string> dictionary = base.Texts;
				string text3 = string.Format("+{0}{1}", "collection.or_more", "");
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001425")]
		[Cpp2IlInjected.Address(RVA = "0x1148EB0", Offset = "0x11478B0", VA = "0x181148EB0")]
		public CollectionTooltipEnergyElementModel()
		{
		}
	}
}
