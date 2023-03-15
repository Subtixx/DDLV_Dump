using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200032F")]
	public class CollectionTooltipFishingModel : CollectionTooltipModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700037D")]
		public FishItemData FishItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6001441")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CFishItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001442")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CFishItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001443")]
		[Cpp2IlInjected.Address(RVA = "0x114B220", Offset = "0x1149C20", VA = "0x18114B220", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltip viewBase)
		{
			//Discarded unreachable code: IL_00f6, IL_00fc, IL_0102, IL_0108, IL_010e
			//IL_0077: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			//IL_00b0: Expected O, but got I4
			//IL_00cc: Expected O, but got I4
			FishItemData fishItemData = default(FishItemData);
			IEnumerable<> enumerable = default(IEnumerable<>);
			List<VillageAreaType> list;
			uint num5 = default(uint);
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				if ((object)viewBase == null)
				{
				}
				int num4 = 0;
				if ((IntPtr)FishItemData == (IntPtr)num3)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					IItemData itemData = base.ItemData;
					FishItemData = fishItemData;
				}
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				Func<FishingDataItemData, bool> func = (Func<FishingDataItemData, bool>)(object)(Func<T, TResult>)delegate(FishingDataItemData y)
				{
					Item item = y.result_.Item;
					int iD = FishItemData.ID;
					throw new NullReferenceException();
				};
				IEnumerable<FishingDataItemData> enumerable2 = (IEnumerable<FishingDataItemData>)Enumerable.Where<FishingDataItemData>(enumerable, (Func<, >)(object)func);
				list = (List<VillageAreaType>)(object)new List<T>();
				if (list == null)
				{
					break;
				}
				if (num3 < (int)num5)
				{
					num3 += num3;
					if (num3 == (int)num5)
					{
						goto IL_0082;
					}
					num3++;
				}
				if (!flag)
				{
					break;
				}
				if (((List<T>)(object)list).Contains((T)num2))
				{
					continue;
				}
				((List<T>)(object)list).Add((T)num2);
				goto IL_0082;
				IL_0082:
				num2 += num2;
				break;
			}
			if (list != null)
			{
			}
			List<ActivityDataLocationFilter> list2 = (List<ActivityDataLocationFilter>)(object)AreaResolver.Resolver((List<>)(object)list);
			GameObject gameObject = default(GameObject);
			bool active = default(bool);
			gameObject.SetActive(active);
			CollectionTooltipSellPriceElementModel collectionTooltipSellPriceElementModel = new CollectionTooltipSellPriceElementModel();
			int num6 = 0;
			((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).ItemData = (IItemData)num6;
			Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField = ((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).Sprites;
			CollectionTooltipEnergyElementModel collectionTooltipEnergyElementModel = new CollectionTooltipEnergyElementModel();
			int num7 = 0;
			((CollectionTooltipElementModel)collectionTooltipEnergyElementModel).ItemData = (IItemData)num7;
			Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField2 = ((CollectionTooltipElementModel)collectionTooltipEnergyElementModel).Sprites;
			int num8 = 0;
			Transform transform = viewBase.transform;
			Transform transform2 = viewBase.transform.transform;
			Transform transform3 = viewBase.transform;
		}

		[Cpp2IlInjected.Token(Token = "0x6001444")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CollectionTooltipFishingModel()
		{
		}
	}
}
