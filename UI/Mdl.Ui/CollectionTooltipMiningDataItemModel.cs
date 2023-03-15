using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000335")]
	public class CollectionTooltipMiningDataItemModel : CollectionTooltipModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000384")]
		public MiningDataItemData MiningDataItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600145B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CMiningDataItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600145C")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CMiningDataItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000385")]
		public List<ActivityDataLocationFilter> Areas
		{
			[Cpp2IlInjected.Token(Token = "0x600145D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CAreas_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600145E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CAreas_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600145F")]
		[Cpp2IlInjected.Address(RVA = "0x114D2A0", Offset = "0x114BCA0", VA = "0x18114D2A0", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltip viewBase)
		{
			//Discarded unreachable code: IL_009d
			if ((long)MiningDataItemData != 0)
			{
				if ((object)viewBase == null)
				{
				}
				int num = 0;
				ActivityDataLocationFilter activityDataLocationFilter = default(ActivityDataLocationFilter);
				if (Areas == null)
				{
					List<ActivityDataLocationFilter> list = (List<ActivityDataLocationFilter>)(object)new List<T>();
					activityDataLocationFilter = new ActivityDataLocationFilter();
					VillageAreaType villageArea = MiningDataItemData.location_.VillageArea;
					((List<T>)(object)list).Add((T)activityDataLocationFilter);
				}
				GameObject gameObject = default(GameObject);
				bool active = default(bool);
				gameObject.SetActive(active);
				bool active2 = default(bool);
				gameObject.SetActive(active2);
				CollectionTooltipSellPriceElementModel collectionTooltipSellPriceElementModel = new CollectionTooltipSellPriceElementModel();
				IItemData itemData = (((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).ItemData = base.ItemData);
				activityDataLocationFilter.locationType_ = collectionTooltipSellPriceElementModel;
				Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField = ((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).Sprites;
				int num2 = 0;
				Transform transform = viewBase.transform;
				Transform transform2 = viewBase.transform.transform;
				Transform transform3 = viewBase.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001460")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CollectionTooltipMiningDataItemModel()
		{
		}
	}
}
