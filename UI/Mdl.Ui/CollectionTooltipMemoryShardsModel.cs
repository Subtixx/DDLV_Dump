using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000337")]
	public class CollectionTooltipMemoryShardsModel : CollectionTooltipModel
	{
		[Cpp2IlInjected.Token(Token = "0x6001462")]
		[Cpp2IlInjected.Address(RVA = "0x114D110", Offset = "0x114BB10", VA = "0x18114D110", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltip viewBase)
		{
			//Discarded unreachable code: IL_0051
			int num = 0;
			CollectionTooltipMemoryShardsElementModel collectionTooltipMemoryShardsElementModel = new CollectionTooltipMemoryShardsElementModel();
			IItemData itemData = (((CollectionTooltipElementModel)collectionTooltipMemoryShardsElementModel).ItemData = base.ItemData);
			int num2 = 0;
			collectionTooltipMemoryShardsElementModel.tooltipView = (CollectionTooltipMemoryShards)viewBase;
			collectionTooltipMemoryShardsElementModel.tooltipView = (CollectionTooltipMemoryShards)(object)collectionTooltipMemoryShardsElementModel;
			CollectionItem _003CCollectionItem_003Ek__BackingField = viewBase.CollectionItem;
			if ((object)_003CCollectionItem_003Ek__BackingField != null)
			{
				GameObject view = _003CCollectionItem_003Ek__BackingField.GetView();
				viewBase.OnRefresh?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001463")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CollectionTooltipMemoryShardsModel()
		{
		}
	}
}
