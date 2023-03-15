using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Localization.Formatter;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000324")]
	public class CollectionTooltipFurnitureSellPriceElementModel : CollectionTooltipElementModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000F0E")]
		public TextBase SellTextBase;

		[Cpp2IlInjected.Token(Token = "0x6001422")]
		[Cpp2IlInjected.Address(RVA = "0x114BFC0", Offset = "0x114A9C0", VA = "0x18114BFC0", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltipElement view)
		{
			//Discarded unreachable code: IL_002f
			//IL_000d: Expected O, but got I4
			int num = 0;
			string text = LocalizationManager.FromStringID("collection.or_more", (IResolver)num);
			string text2 = " " + text;
			IItemData itemData = base.ItemData;
			string text3 = default(string);
			SellTextBase.Text = text3;
		}

		[Cpp2IlInjected.Token(Token = "0x6001423")]
		[Cpp2IlInjected.Address(RVA = "0x1148EB0", Offset = "0x11478B0", VA = "0x181148EB0")]
		public CollectionTooltipFurnitureSellPriceElementModel()
		{
		}
	}
}
