using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000332")]
	public class CollectionTooltipFlowerModel : CollectionTooltipModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700037F")]
		public FlowerSpawningInVillageRecurringEventItemData RecurringEventItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600144B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CRecurringEventItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600144C")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CRecurringEventItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600144D")]
		[Cpp2IlInjected.Address(RVA = "0x114BA10", Offset = "0x114A410", VA = "0x18114BA10", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltip viewBase)
		{
			//Discarded unreachable code: IL_007d
			FlowerSpawningInVillageRecurringEventItemData flowerSpawningInVillageRecurringEventItemData = RecurringEventItemData;
			if (flowerSpawningInVillageRecurringEventItemData != null)
			{
				if ((object)viewBase == null)
				{
				}
				int num = 0;
				List<ActivityDataLocationFilter> list = (List<ActivityDataLocationFilter>)(object)AreaResolver.Resolver(Enumerable.ToList<VillageAreaType>((IEnumerable<>)(object)flowerSpawningInVillageRecurringEventItemData.areas_));
				GameObject gameObject = default(GameObject);
				bool active = default(bool);
				gameObject.SetActive(active);
				bool active2 = default(bool);
				gameObject.SetActive(active2);
				CollectionTooltipSellPriceElementModel collectionTooltipSellPriceElementModel = new CollectionTooltipSellPriceElementModel();
				IItemData itemData = (((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).ItemData = base.ItemData);
				((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).ItemData = (IItemData)collectionTooltipSellPriceElementModel;
				Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField = ((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).Sprites;
				int num2 = 0;
				Transform transform = viewBase.transform;
				Transform transform2 = viewBase.transform.transform;
				Transform transform3 = viewBase.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600144E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CollectionTooltipFlowerModel()
		{
		}
	}
}
