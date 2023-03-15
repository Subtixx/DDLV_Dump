using System;
using Cpp2IlInjected;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000705")]
	public class ShopProductPurchaseButton : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002851")]
		[SerializeField]
		private GameObject _mcOldPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002852")]
		[SerializeField]
		private TextBase _tfOldPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002853")]
		[SerializeField]
		private TextBase _tfPurchaseDesc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002854")]
		[SerializeField]
		private ButtonTmPro _btnPurchase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002855")]
		[SerializeField]
		private GameObject _mcDiscount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002856")]
		[SerializeField]
		private TextBase _tfDiscount;

		[Cpp2IlInjected.Token(Token = "0x6002CBF")]
		[Cpp2IlInjected.Address(RVA = "0x143B3A0", Offset = "0x1439DA0", VA = "0x18143B3A0")]
		public void RefreshDisplay(ShopProductModel model)
		{
			//Discarded unreachable code: IL_0054, IL_007a, IL_00bc, IL_00ca
			if (model != null)
			{
				int num = 0;
				int num2 = 0;
				if (model != null)
				{
					Client client = default(Client);
					DateTime localTime = client.LocalTime;
					int num3 = 0;
					string text = default(string);
					_btnPurchase.Label.Text = text;
					int num4 = 0;
					GameObject mcOldPrice = _mcOldPrice;
					int active = 0;
					mcOldPrice.SetActive((byte)active != 0);
					GameObject mcDiscount = _mcDiscount;
					int active2 = 0;
					mcDiscount.SetActive((byte)active2 != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CC0")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ShopProductPurchaseButton()
		{
		}
	}
}
