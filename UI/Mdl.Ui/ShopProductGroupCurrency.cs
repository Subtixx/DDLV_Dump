using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006DF")]
	public class ShopProductGroupCurrency : ShopProductGroupDefault
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40026BB")]
		private List<ShopProductModel> _products;

		[Cpp2IlInjected.Token(Token = "0x6002C0D")]
		[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00", Slot = "4")]
		public override void RefreshData(List<ShopProductModel> products)
		{
			_products = products;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C0E")]
		[Cpp2IlInjected.Address(RVA = "0x142C430", Offset = "0x142AE30", VA = "0x18142C430", Slot = "5")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_009c, IL_00a2, IL_00a8, IL_00ae, IL_00b4, IL_00ba, IL_00c0, IL_00c6, IL_00d2
			//IL_007e: Expected I4, but got I8
			int num = 0;
			Transform transform = _mcProductsHolder.transform;
			int childCount = transform.childCount;
			List<ShopProductModel> products = _products;
			GameObject gameObject = UnityEngine.Object.Instantiate(_prefabProduct, transform);
			childCount++;
			List<ShopProductModel> products2 = _products;
			IEnumerator enumerator = transform.GetEnumerator();
			if (enumerator != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if (enumerator == null)
				{
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				List<ShopProductModel> products3 = _products;
				int active = 0;
				GameObject gameObject2 = default(GameObject);
				gameObject2.SetActive((byte)active != 0);
				num++;
				GameObject gameObject3 = default(GameObject);
				ulong num4 = default(ulong);
				gameObject3.SetActive((byte)num4 != 0);
				List<ShopProductModel> products4 = _products;
				ShopProductItemCurrency shopProductItemCurrency = default(ShopProductItemCurrency);
				shopProductItemCurrency.RefreshDisplay();
				num++;
			}
			Transform transform2 = default(Transform);
			if ((object)transform2.parent == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C0F")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ShopProductGroupCurrency()
		{
		}
	}
}
