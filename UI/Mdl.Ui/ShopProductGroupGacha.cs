using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006E1")]
	public class ShopProductGroupGacha : ShopProductGroupDefault
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40026BE")]
		private List<ShopProductModel> _products;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40026BF")]
		public List<Texture2D> TexturesPresentBox;

		[Cpp2IlInjected.Token(Token = "0x6002C13")]
		[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00", Slot = "4")]
		public override void RefreshData(List<ShopProductModel> products)
		{
			_products = products;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C14")]
		[Cpp2IlInjected.Address(RVA = "0x142C820", Offset = "0x142B220", VA = "0x18142C820", Slot = "5")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_00b0, IL_00b6, IL_00bc, IL_00c2, IL_00c8, IL_00ce, IL_00d4, IL_00da, IL_00e6
			//IL_0081: Expected I4, but got I8
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
				ShopProductItemGacha shopProductItemGacha = default(ShopProductItemGacha);
				List<Texture2D> list = (shopProductItemGacha.TexturesPresentBox = TexturesPresentBox);
				List<ShopProductModel> products4 = _products;
				shopProductItemGacha.RefreshDisplay();
				num++;
			}
			Transform transform2 = default(Transform);
			if ((object)transform2.parent == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C15")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ShopProductGroupGacha()
		{
		}
	}
}
