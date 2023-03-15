using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000330")]
	public class CollectionTooltipWildCropModel : CollectionTooltipModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700037E")]
		public WildCropsSpawningInVillageRecurringEventItemData RecurringEventItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6001446")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CRecurringEventItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001447")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CRecurringEventItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001448")]
		[Cpp2IlInjected.Address(RVA = "0x114F050", Offset = "0x114DA50", VA = "0x18114F050", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltip viewBase)
		{
			//Discarded unreachable code: IL_009f
			WildCropsSpawningInVillageRecurringEventItemData wildCropsSpawningInVillageRecurringEventItemData = RecurringEventItemData;
			if (wildCropsSpawningInVillageRecurringEventItemData != null)
			{
				if ((object)viewBase == null)
				{
				}
				int num = 0;
				List<ActivityDataLocationFilter> list = (List<ActivityDataLocationFilter>)(object)AreaResolver.Resolver(Enumerable.ToList<VillageAreaType>((IEnumerable<>)(object)wildCropsSpawningInVillageRecurringEventItemData.areaSpecification_.SpecificAreas.areas_));
				CollectionTooltipSellPriceElementModel collectionTooltipSellPriceElementModel = new CollectionTooltipSellPriceElementModel();
				IItemData itemData = (((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).ItemData = base.ItemData);
				((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).ItemData = (IItemData)collectionTooltipSellPriceElementModel;
				Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField = ((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).Sprites;
				CollectionTooltipEnergyElementModel collectionTooltipEnergyElementModel = new CollectionTooltipEnergyElementModel();
				IItemData itemData2 = (((CollectionTooltipElementModel)collectionTooltipEnergyElementModel).ItemData = base.ItemData);
				((CollectionTooltipElementModel)collectionTooltipEnergyElementModel).ItemData = (IItemData)collectionTooltipEnergyElementModel;
				Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField2 = ((CollectionTooltipElementModel)collectionTooltipEnergyElementModel).Sprites;
				int num2 = 0;
				Transform transform = viewBase.transform;
				Transform transform2 = viewBase.transform.transform;
				Transform transform3 = viewBase.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001449")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CollectionTooltipWildCropModel()
		{
		}
	}
}
