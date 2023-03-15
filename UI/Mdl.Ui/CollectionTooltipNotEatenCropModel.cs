using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000317")]
	public class CollectionTooltipNotEatenCropModel : CollectionTooltipModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700036A")]
		public SeedItemData SeedItemData
		{
			[Cpp2IlInjected.Token(Token = "0x60013E9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CSeedItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60013EA")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CSeedItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013EB")]
		[Cpp2IlInjected.Address(RVA = "0x114D600", Offset = "0x114C000", VA = "0x18114D600", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltip viewBase)
		{
			//Discarded unreachable code: IL_00da
			//IL_0038: Expected O, but got I4
			//IL_0078: Expected F4, but got I4
			if ((long)SeedItemData != 0)
			{
				if ((object)viewBase == null)
				{
				}
				int num = 0;
				List<VillageAreaType> list = (List<VillageAreaType>)(object)new List<T>();
				SeedItemData seedItemData = SeedItemData;
				if (seedItemData.hasGrowthBoost_)
				{
					VillageAreaType villageArea_ = seedItemData.villageArea_;
					((List<T>)(object)list).Add((T)villageArea_);
				}
				List<ActivityDataLocationFilter> list2 = (List<ActivityDataLocationFilter>)(object)AreaResolver.Resolver((List<>)(object)list);
				GameObject gameObject = default(GameObject);
				bool active = default(bool);
				gameObject.SetActive(active);
				bool active2 = default(bool);
				gameObject.SetActive(active2);
				int producedAmount_ = SeedItemData.producedAmount_;
				long seconds = SeedItemData.productionPeriod_.Seconds;
				string text = TextUtilities.FormatAbbrTime(0f);
				CollectionTooltipSellPriceElementModel collectionTooltipSellPriceElementModel = new CollectionTooltipSellPriceElementModel();
				IItemData itemData = (((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).ItemData = base.ItemData);
				((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).ItemData = (IItemData)collectionTooltipSellPriceElementModel;
				Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField = ((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).Sprites;
				int num2 = 0;
				Transform transform = viewBase.transform;
				Transform transform2 = viewBase.transform.transform;
				Transform transform3 = viewBase.transform;
				GameObject gameObject2 = transform2.gameObject;
				int active3 = 0;
				gameObject2.SetActive((byte)active3 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013EC")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CollectionTooltipNotEatenCropModel()
		{
		}
	}
}
