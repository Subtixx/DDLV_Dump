using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200032B")]
	public class CollectionTooltipEnergySellPriceModel : CollectionTooltipModel
	{
		[Cpp2IlInjected.Token(Token = "0x600143B")]
		[Cpp2IlInjected.Address(RVA = "0x114AAB0", Offset = "0x11494B0", VA = "0x18114AAB0", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltip viewBase)
		{
			//Discarded unreachable code: IL_0054
			int num = 0;
			CollectionTooltipSellPriceElementModel collectionTooltipSellPriceElementModel = new CollectionTooltipSellPriceElementModel();
			IItemData itemData = (((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).ItemData = base.ItemData);
			((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).ItemData = (IItemData)collectionTooltipSellPriceElementModel;
			Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField = ((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).Sprites;
			CollectionTooltipEnergyElementModel collectionTooltipEnergyElementModel = new CollectionTooltipEnergyElementModel();
			IItemData itemData2 = (((CollectionTooltipElementModel)collectionTooltipEnergyElementModel).ItemData = base.ItemData);
			((CollectionTooltipElementModel)collectionTooltipEnergyElementModel).ItemData = (IItemData)collectionTooltipEnergyElementModel;
			ICollection<SpriteType> keys = (ICollection<SpriteType>)((IDictionary<TKey, TValue>)((CollectionTooltipElementModel)collectionTooltipEnergyElementModel).Sprites).get_Keys();
		}

		[Cpp2IlInjected.Token(Token = "0x600143C")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CollectionTooltipEnergySellPriceModel()
		{
		}
	}
}
