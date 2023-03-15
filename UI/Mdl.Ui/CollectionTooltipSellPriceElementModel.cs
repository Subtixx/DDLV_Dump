using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Localization.Formatter;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000323")]
	public class CollectionTooltipSellPriceElementModel : CollectionTooltipElementModel
	{
		[Cpp2IlInjected.Token(Token = "0x6001420")]
		[Cpp2IlInjected.Address(RVA = "0x114E5E0", Offset = "0x114CFE0", VA = "0x18114E5E0", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltipElement view)
		{
			//Discarded unreachable code: IL_0085
			//IL_0037: Expected O, but got I4
			//IL_0066: Expected I4, but got I8
			//IL_0066: Expected F8, but got I4
			if (base.ItemData == null)
			{
				return;
			}
			bool flag = default(bool);
			bool active = !flag;
			if (!flag)
			{
				IItemData itemData = base.ItemData;
				bool flag2 = default(bool);
				if (itemData != null && itemData != null && !flag2)
				{
					int num = 0;
					string text = LocalizationManager.FromStringID("collection.or_more", (IResolver)num);
					string text2 = " " + text;
				}
				IItemData itemData2 = base.ItemData;
				int childMaxDecimals = 0;
				Dictionary<TextType, string> dictionary = base.Texts;
				ulong num2 = default(ulong);
				string text3 = TextUtilities.FormatNumber(flag ? 1 : 0, 3, 1, childMaxDecimals, (byte)num2 != 0) + "";
				throw new NullReferenceException();
			}
			view.gameObject.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x6001421")]
		[Cpp2IlInjected.Address(RVA = "0x1148EB0", Offset = "0x11478B0", VA = "0x181148EB0")]
		public CollectionTooltipSellPriceElementModel()
		{
		}
	}
}
