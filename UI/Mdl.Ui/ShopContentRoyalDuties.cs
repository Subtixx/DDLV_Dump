using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006C7")]
	public class ShopContentRoyalDuties : ShopContentDefault
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002640")]
		private List<ShopProductModel> _products;

		[Cpp2IlInjected.Token(Token = "0x6002B97")]
		[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00", Slot = "4")]
		public override void RefreshData(List<ShopProductModel> products, [Optional] List<ShopProductItemCustomizedBundleTemplate> templates)
		{
			_products = products;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B98")]
		[Cpp2IlInjected.Address(RVA = "0x1427BE0", Offset = "0x14265E0", VA = "0x181427BE0", Slot = "5")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_00e9, IL_00ef, IL_00f5, IL_00fb, IL_0101, IL_010d
			//IL_00dd: Expected I4, but got I8
			int num = 0;
			List<List<ShopProductModel>> list = (List<List<ShopProductModel>>)(object)new List<T>();
			List<ShopProductModel> products = _products;
			Func<ShopProductModel, bool> func = (Func<ShopProductModel, bool>)(object)(Func<T, TResult>)((ShopProductModel x) => !checkGroupCondition(x));
			List<ShopProductModel> item = (List<ShopProductModel>)(object)Enumerable.ToList<ShopProductModel>(Enumerable.Where<ShopProductModel>((IEnumerable<>)products, (Func<, >)(object)func));
			((List<T>)(object)list).Add((T)item);
			List<ShopProductModel> products2 = _products;
			Func<ShopProductModel, bool> func2 = (Func<ShopProductModel, bool>)(object)(Func<T, TResult>)((ShopProductModel x) => checkGroupCondition(x));
			List<ShopProductModel> item2 = (List<ShopProductModel>)(object)Enumerable.ToList<ShopProductModel>(Enumerable.Where<ShopProductModel>((IEnumerable<>)products2, (Func<, >)(object)func2));
			((List<T>)(object)list).Add((T)item2);
			int size = ((List<>)(object)list)._size;
			Transform transform = _mcProductGroupsHolder.transform;
			int childCount = transform.childCount;
			if (childCount < size)
			{
				size -= childCount;
				GameObject gameObject = UnityEngine.Object.Instantiate(_prefabProductGroup, transform);
			}
			if (transform.GetEnumerator() != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if (num == 0)
				{
					num += 328;
				}
				int num3 = 0;
				if (num == 0)
				{
					throw new InvalidCastException();
				}
				int active = 0;
				GameObject gameObject2 = default(GameObject);
				gameObject2.SetActive((byte)active != 0);
				num++;
				GameObject gameObject3 = default(GameObject);
				ulong num4 = default(ulong);
				gameObject3.SetActive((byte)num4 != 0);
				ShopProductGroupRoyalDuties shopProductGroupRoyalDuties = default(ShopProductGroupRoyalDuties);
				shopProductGroupRoyalDuties.RefreshDisplay();
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B99")]
		[Cpp2IlInjected.Address(RVA = "0x14280B0", Offset = "0x1426AB0", VA = "0x1814280B0")]
		private bool checkGroupCondition(ShopProductModel x)
		{
			if (x != null)
			{
				int num = 0;
				if (x != null)
				{
					ItemReward itemReward = default(ItemReward);
					Item item = itemReward.Item;
					ItemType itemType = default(ItemType);
					ItemType itemType2 = default(ItemType);
					if (itemType == ItemType.Furniture || itemType2 == ItemType.Clothing)
					{
						return true;
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B9A")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ShopContentRoyalDuties()
		{
		}
	}
}
