using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200032D")]
	public class CollectionTooltipEverywhereItemModel : CollectionTooltipModel
	{
		[Cpp2IlInjected.Token(Token = "0x600143E")]
		[Cpp2IlInjected.Address(RVA = "0x114AD40", Offset = "0x1149740", VA = "0x18114AD40", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltip viewBase)
		{
			//Discarded unreachable code: IL_0025
			int num = 0;
			CollectionTooltipSellPriceElementModel collectionTooltipSellPriceElementModel = new CollectionTooltipSellPriceElementModel();
			IItemData itemData = (((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).ItemData = base.ItemData);
			((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).ItemData = (IItemData)collectionTooltipSellPriceElementModel;
			Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField = ((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).Sprites;
		}

		[Cpp2IlInjected.Token(Token = "0x600143F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CollectionTooltipEverywhereItemModel()
		{
		}
	}
}
