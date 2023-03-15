using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006C5")]
	public class ShopContentGem : ShopContentDefault
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002631")]
		private List<ShopProductModel> _products;

		[Cpp2IlInjected.Token(Token = "0x6002B91")]
		[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00", Slot = "4")]
		public override void RefreshData(List<ShopProductModel> products, [Optional] List<ShopProductItemCustomizedBundleTemplate> templates)
		{
			_products = products;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B92")]
		[Cpp2IlInjected.Address(RVA = "0x14271E0", Offset = "0x1425BE0", VA = "0x1814271E0", Slot = "5")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0088, IL_008e, IL_0094, IL_009a, IL_00a0, IL_00ac
			//IL_006b: Expected I4, but got I8
			int num = 0;
			Transform transform = _mcProductGroupsHolder.transform;
			int childCount = transform.childCount;
			if (childCount < 1)
			{
				uint num2 = num2 - (uint)childCount;
				GameObject gameObject = UnityEngine.Object.Instantiate(_prefabProductGroup, transform);
			}
			IEnumerator enumerator = transform.GetEnumerator();
			if (enumerator != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				if (enumerator == null)
				{
				}
				int num4 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int active = 0;
				GameObject gameObject2 = default(GameObject);
				gameObject2.SetActive((byte)active != 0);
				num++;
				GameObject gameObject3 = default(GameObject);
				ulong num5 = default(ulong);
				gameObject3.SetActive((byte)num5 != 0);
				List<ShopProductModel> products = _products;
				ShopProductGroupGem shopProductGroupGem = default(ShopProductGroupGem);
				shopProductGroupGem.RefreshData((List<>)(object)products);
				shopProductGroupGem.RefreshDisplay();
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B93")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ShopContentGem()
		{
		}
	}
}
