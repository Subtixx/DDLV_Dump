using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000310")]
	public class CollectionTooltipCharacterLockedModel : CollectionTooltipModel
	{
		[Cpp2IlInjected.Token(Token = "0x60013D5")]
		[Cpp2IlInjected.Address(RVA = "0x11478E0", Offset = "0x11462E0", VA = "0x1811478E0", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltip viewBase)
		{
			//Discarded unreachable code: IL_0045
			int num = 0;
			CollectionTooltipItemNameElementModel collectionTooltipItemNameElementModel = new CollectionTooltipItemNameElementModel();
			IItemData itemData = (((CollectionTooltipElementModel)collectionTooltipItemNameElementModel).ItemData = base.ItemData);
			((CollectionTooltipElementModel)collectionTooltipItemNameElementModel).ItemData = (IItemData)collectionTooltipItemNameElementModel;
			CollectionItem _003CCollectionItem_003Ek__BackingField = viewBase.CollectionItem;
			if ((object)_003CCollectionItem_003Ek__BackingField != null)
			{
				GameObject view = _003CCollectionItem_003Ek__BackingField.GetView();
				viewBase.OnRefresh?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013D6")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CollectionTooltipCharacterLockedModel()
		{
		}
	}
}
