using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200033C")]
	public class CollectionTooltipSellPriceModel : CollectionTooltipModel
	{
		[Cpp2IlInjected.Token(Token = "0x600146F")]
		[Cpp2IlInjected.Address(RVA = "0x114E810", Offset = "0x114D210", VA = "0x18114E810", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltip viewBase)
		{
			//Discarded unreachable code: IL_002a
			int num = 0;
			CollectionTooltipSellPriceElementModel collectionTooltipSellPriceElementModel = new CollectionTooltipSellPriceElementModel();
			IItemData itemData = (((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).ItemData = base.ItemData);
			((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).ItemData = (IItemData)collectionTooltipSellPriceElementModel;
			ICollection<SpriteType> keys = (ICollection<SpriteType>)((IDictionary<TKey, TValue>)((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).Sprites).get_Keys();
		}

		[Cpp2IlInjected.Token(Token = "0x6001470")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CollectionTooltipSellPriceModel()
		{
		}
	}
}
