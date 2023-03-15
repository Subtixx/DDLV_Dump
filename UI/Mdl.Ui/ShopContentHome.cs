using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006C6")]
	public class ShopContentHome : ShopContentDefault
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002632")]
		private List<ShopProductItemCustomizedBundleTemplate> _templates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002633")]
		private List<ShopProductModel> _productsAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002634")]
		private List<ShopProductModel> _productsBundle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002635")]
		private List<ShopProductModel> _productsGem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002636")]
		private List<ShopProductModel> _productsCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002637")]
		private List<ShopProductModel> _productsGacha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002638")]
		private GameObject _mcBundleProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002639")]
		private GameObject _mcGemProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400263A")]
		private GameObject _mcGachaProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400263B")]
		private GameObject _mcCurrencyProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400263C")]
		[SerializeField]
		protected GameObject _prefabGemProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400263D")]
		[SerializeField]
		protected GameObject _prefabGachaProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400263E")]
		[SerializeField]
		protected GameObject _prefabCurrencyProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400263F")]
		[Space]
		[SerializeField]
		private List<Texture2D> _texturesPresentBox;

		[Cpp2IlInjected.Token(Token = "0x6002B94")]
		[Cpp2IlInjected.Address(RVA = "0x14274F0", Offset = "0x1425EF0", VA = "0x1814274F0", Slot = "4")]
		public override void RefreshData(List<ShopProductModel> products, [Optional] List<ShopProductItemCustomizedBundleTemplate> templates)
		{
			//Discarded unreachable code: IL_006d, IL_0073, IL_0079, IL_007f, IL_0085
			_productsAll = products;
			_templates = templates;
			List<ShopProductModel> list = (_productsBundle = (List<ShopProductModel>)(object)new List<T>());
			List<ShopProductModel> list2 = (_productsGem = (List<ShopProductModel>)(object)new List<T>());
			List<ShopProductModel> list3 = (_productsCurrency = (List<ShopProductModel>)(object)new List<T>());
			List<ShopProductModel> list4 = (_productsGacha = (List<ShopProductModel>)(object)new List<T>());
			bool flag = default(bool);
			if (flag)
			{
				while (!flag)
				{
				}
				List<ShopProductModel> productsCurrency = _productsCurrency;
				List<ShopProductModel> productsGacha = _productsGacha;
				List<ShopProductModel> productsGem = _productsGem;
				List<ShopProductModel> productsBundle = _productsBundle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B95")]
		[Cpp2IlInjected.Address(RVA = "0x1427790", Offset = "0x1426190", VA = "0x181427790", Slot = "5")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0192
			//IL_0023: Expected O, but got I4
			//IL_008e: Expected O, but got I4
			//IL_00e8: Expected O, but got I4
			//IL_0153: Expected O, but got I4
			Transform parent = _mcProductGroupsHolder.transform;
			List<ShopProductModel> productsBundle = _productsBundle;
			GameObject mcBundleProductGroup = _mcBundleProductGroup;
			int num = 0;
			if (mcBundleProductGroup == (Object)num)
			{
				GameObject gameObject = (_mcBundleProductGroup = Object.Instantiate(_prefabProductGroup, parent));
			}
			ShopProductGroupBundlePaging component = _mcBundleProductGroup.GetComponent<ShopProductGroupBundlePaging>();
			List<ShopProductItemCustomizedBundleTemplate> list = (component.Templates = _templates);
			List<ShopProductModel> productsBundle2 = _productsBundle;
			component.RefreshData((List<>)(object)productsBundle2);
			component.RefreshDisplay();
			List<ShopProductModel> productsGem = _productsGem;
			GameObject mcGemProductGroup = _mcGemProductGroup;
			int num2 = 0;
			if (mcGemProductGroup == (Object)num2)
			{
				GameObject gameObject2 = (_mcGemProductGroup = Object.Instantiate(_prefabGemProductGroup, parent));
			}
			ShopProductGroupGem component2 = _mcGemProductGroup.GetComponent<ShopProductGroupGem>();
			List<ShopProductModel> productsGem2 = _productsGem;
			component2.RefreshData((List<>)(object)productsGem2);
			component2.RefreshDisplay();
			List<ShopProductModel> productsGacha = _productsGacha;
			GameObject mcGachaProductGroup = _mcGachaProductGroup;
			int num3 = 0;
			if (mcGachaProductGroup == (Object)num3)
			{
				GameObject gameObject3 = (_mcGachaProductGroup = Object.Instantiate(_prefabGachaProductGroup, parent));
			}
			ShopProductGroupGacha component3 = _mcGachaProductGroup.GetComponent<ShopProductGroupGacha>();
			List<Texture2D> list2 = (component3.TexturesPresentBox = _texturesPresentBox);
			List<ShopProductModel> productsGacha2 = _productsGacha;
			component3.RefreshData((List<>)(object)productsGacha2);
			component3.RefreshDisplay();
			List<ShopProductModel> productsCurrency = _productsCurrency;
			GameObject mcCurrencyProductGroup = _mcCurrencyProductGroup;
			int num4 = 0;
			if (mcCurrencyProductGroup == (Object)num4)
			{
				GameObject gameObject4 = (_mcCurrencyProductGroup = Object.Instantiate(_prefabCurrencyProductGroup, parent));
			}
			ShopProductGroupCurrency component4 = _mcCurrencyProductGroup.GetComponent<ShopProductGroupCurrency>();
			List<ShopProductModel> productsCurrency2 = _productsCurrency;
			component4.RefreshData((List<>)(object)productsCurrency2);
			component4.RefreshDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B96")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ShopContentHome()
		{
		}
	}
}
