using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000333")]
	public class CollectionTooltipSpawningItemModel : CollectionTooltipModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000380")]
		public ItemSpawningInVillageRecurringEventItemData RecurringEventItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600144F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CRecurringEventItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001450")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CRecurringEventItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000381")]
		public List<VillageAreaType> Areas
		{
			[Cpp2IlInjected.Token(Token = "0x6001451")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CAreas_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001452")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CAreas_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001453")]
		[Cpp2IlInjected.Address(RVA = "0x114E920", Offset = "0x114D320", VA = "0x18114E920", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltip viewBase)
		{
			//Discarded unreachable code: IL_012a
			ItemSpawningInVillageRecurringEventItemData itemSpawningInVillageRecurringEventItemData = RecurringEventItemData;
			if (itemSpawningInVillageRecurringEventItemData == null)
			{
				return;
			}
			if ((object)viewBase != null)
			{
				int num = 0;
				int num2 = 0;
				if ((object)viewBase == null)
				{
					int num3 = 0;
				}
				List<ActivityDataLocationFilter> list = (List<ActivityDataLocationFilter>)(object)AreaResolver.Resolver(Enumerable.ToList<VillageAreaType>((IEnumerable<>)(object)itemSpawningInVillageRecurringEventItemData.areaSpecification_.SpecificAreas.areas_));
				GameObject gameObject = default(GameObject);
				bool active = default(bool);
				gameObject.SetActive(active);
				bool active2 = default(bool);
				gameObject.SetActive(active2);
				CollectionTooltipSellPriceElementModel collectionTooltipSellPriceElementModel = new CollectionTooltipSellPriceElementModel();
				IItemData itemData = (((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).ItemData = base.ItemData);
				((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).ItemData = (IItemData)collectionTooltipSellPriceElementModel;
				Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField = ((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).Sprites;
				CollectionTooltipEnergyElementModel collectionTooltipEnergyElementModel = new CollectionTooltipEnergyElementModel();
				IItemData itemData2 = (((CollectionTooltipElementModel)collectionTooltipEnergyElementModel).ItemData = base.ItemData);
				((CollectionTooltipElementModel)collectionTooltipEnergyElementModel).ItemData = (IItemData)collectionTooltipEnergyElementModel;
				Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField2 = ((CollectionTooltipElementModel)collectionTooltipEnergyElementModel).Sprites;
				Transform transform = viewBase.transform;
				Transform transform2 = viewBase.transform;
			}
			int num4 = 0;
			List<VillageAreaType> list2 = Areas;
			if (list2 == null)
			{
				List<VillageAreaType> list3 = (List<VillageAreaType>)(object)Enumerable.ToList<VillageAreaType>((IEnumerable<>)(object)itemSpawningInVillageRecurringEventItemData.areaSpecification_.SpecificAreas.areas_);
			}
			List<ActivityDataLocationFilter> list4 = (List<ActivityDataLocationFilter>)(object)AreaResolver.Resolver((List<>)(object)list2);
			GameObject gameObject2 = default(GameObject);
			bool active3 = default(bool);
			gameObject2.SetActive(active3);
			bool active4 = default(bool);
			gameObject2.SetActive(active4);
			CollectionTooltipSellPriceElementModel collectionTooltipSellPriceElementModel2 = new CollectionTooltipSellPriceElementModel();
			IItemData itemData3 = (((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel2).ItemData = base.ItemData);
			((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel2).ItemData = (IItemData)collectionTooltipSellPriceElementModel2;
			Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField3 = ((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel2).Sprites;
			int num5 = 0;
			Transform transform3 = default(Transform);
			Transform transform4 = transform3.transform;
		}

		[Cpp2IlInjected.Token(Token = "0x6001454")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CollectionTooltipSpawningItemModel()
		{
		}
	}
}
