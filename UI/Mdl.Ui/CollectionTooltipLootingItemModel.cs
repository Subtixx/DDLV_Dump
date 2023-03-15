using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000334")]
	public class CollectionTooltipLootingItemModel : CollectionTooltipModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000382")]
		public LootTableItemData LootItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6001455")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CLootItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001456")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CLootItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000383")]
		public List<VillageAreaType> Areas
		{
			[Cpp2IlInjected.Token(Token = "0x6001457")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CAreas_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001458")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CAreas_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001459")]
		[Cpp2IlInjected.Address(RVA = "0x114C770", Offset = "0x114B170", VA = "0x18114C770", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltip viewBase)
		{
			//Discarded unreachable code: IL_0090
			if ((long)LootItemData != 0)
			{
				List<VillageAreaType> list = Areas;
				if (list != null)
				{
					int num = 0;
					int num2 = 0;
					List<ActivityDataLocationFilter> list2 = (List<ActivityDataLocationFilter>)(object)AreaResolver.Resolver((List<>)(object)list);
					List<VillageAreaType> list3 = Areas;
					GameObject gameObject = default(GameObject);
					bool active = default(bool);
					gameObject.SetActive(active);
					List<VillageAreaType> list4 = Areas;
					bool active2 = default(bool);
					gameObject.SetActive(active2);
					CollectionTooltipSellPriceElementModel collectionTooltipSellPriceElementModel = new CollectionTooltipSellPriceElementModel();
					IItemData itemData = (((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).ItemData = base.ItemData);
					viewBase.CollectionItem = (CollectionItem)(object)collectionTooltipSellPriceElementModel;
					Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField = ((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).Sprites;
					Transform transform = viewBase.transform;
					Transform transform2 = viewBase.transform;
					Transform transform3 = viewBase.transform;
					Transform transform4 = viewBase.transform;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600145A")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CollectionTooltipLootingItemModel()
		{
		}
	}
}
