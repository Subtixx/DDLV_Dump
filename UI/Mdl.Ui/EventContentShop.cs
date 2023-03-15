using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200045E")]
	public class EventContentShop : EventContentBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001607")]
		private List<ShopProductModel> _productsAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001608")]
		private List<ShopProductModel> _productsCharacterBundle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001609")]
		private List<ShopProductModel> _productsRegularBundle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400160A")]
		private List<ShopProductModel> _productsDailyReward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400160B")]
		private List<ShopProductModel> _productsGem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400160C")]
		private List<ShopProductModel> _productsCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400160D")]
		private List<ShopProductModel> _productsGacha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400160E")]
		[SerializeField]
		private GameObject _mcProductGroupsHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400160F")]
		private GameObject _mcDailyRewardProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001610")]
		private GameObject _mcRegularBundleProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001611")]
		private GameObject _mcCharacterBundleProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001612")]
		private GameObject _mcGemProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001613")]
		private GameObject _mcGachaProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001614")]
		private GameObject _mcCurrencyProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001615")]
		[SerializeField]
		protected GameObject _prefabBundleProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001616")]
		[SerializeField]
		protected GameObject _prefabDailyRewardProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001617")]
		[SerializeField]
		protected GameObject _prefabCharacterBundleProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001618")]
		[SerializeField]
		protected GameObject _prefabGemProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001619")]
		[SerializeField]
		protected GameObject _prefabGachaProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400161A")]
		[SerializeField]
		protected GameObject _prefabCurrencyProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400161B")]
		[Space]
		[SerializeField]
		private List<Texture2D> _texturesPresentBox;

		[Cpp2IlInjected.Token(Token = "0x6001C38")]
		[Cpp2IlInjected.Address(RVA = "0xF279C0", Offset = "0xF263C0", VA = "0x180F279C0", Slot = "4")]
		public override void RefreshData(EventContentModelBase model)
		{
			//Discarded unreachable code: IL_00a2, IL_00a8, IL_00ae, IL_00b4, IL_00ba, IL_00c0, IL_00c6, IL_00cc
			if (model == null)
			{
				return;
			}
			int num = 0;
			if (model == null)
			{
				return;
			}
			List<ShopProductModel> list = (_productsDailyReward = (List<ShopProductModel>)(object)new List<T>());
			List<ShopProductModel> list2 = (_productsCharacterBundle = (List<ShopProductModel>)(object)new List<T>());
			List<ShopProductModel> list3 = (_productsRegularBundle = (List<ShopProductModel>)(object)new List<T>());
			List<ShopProductModel> list4 = (_productsGem = (List<ShopProductModel>)(object)new List<T>());
			List<ShopProductModel> list5 = (_productsCurrency = (List<ShopProductModel>)(object)new List<T>());
			List<ShopProductModel> list6 = (_productsGacha = (List<ShopProductModel>)(object)new List<T>());
			bool flag = default(bool);
			if (flag)
			{
				List<ShopProductModel> productsCurrency = _productsCurrency;
				List<ShopProductModel> productsGacha = _productsGacha;
				List<ShopProductModel> productsGem = _productsGem;
				int num2 = 0;
				bool flag2 = default(bool);
				if (!flag2)
				{
					List<ShopProductModel> productsRegularBundle = _productsRegularBundle;
				}
				List<ShopProductModel> productsCharacterBundle = _productsCharacterBundle;
				List<ShopProductModel> productsDailyReward = _productsDailyReward;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C39")]
		[Cpp2IlInjected.Address(RVA = "0xF27DA0", Offset = "0xF267A0", VA = "0x180F27DA0", Slot = "5")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0235
			//IL_0023: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_00d7: Expected O, but got I4
			//IL_0131: Expected O, but got I4
			//IL_018b: Expected O, but got I4
			//IL_01f6: Expected O, but got I4
			Transform parent = _mcProductGroupsHolder.transform;
			List<ShopProductModel> productsCharacterBundle = _productsCharacterBundle;
			GameObject mcCharacterBundleProductGroup = _mcCharacterBundleProductGroup;
			int num = 0;
			if (mcCharacterBundleProductGroup == (Object)num)
			{
				GameObject gameObject = (_mcCharacterBundleProductGroup = Object.Instantiate(_prefabCharacterBundleProductGroup, parent));
			}
			ShopProductGroupBundle component = _mcCharacterBundleProductGroup.GetComponent<ShopProductGroupBundle>();
			List<ShopProductModel> productsCharacterBundle2 = _productsCharacterBundle;
			component.RefreshData((List<>)(object)productsCharacterBundle2);
			component.RefreshDisplay();
			List<ShopProductModel> productsDailyReward = _productsDailyReward;
			GameObject mcDailyRewardProductGroup = _mcDailyRewardProductGroup;
			int num2 = 0;
			if (mcDailyRewardProductGroup == (Object)num2)
			{
				GameObject gameObject2 = (_mcDailyRewardProductGroup = Object.Instantiate(_prefabDailyRewardProductGroup, parent));
			}
			ShopProductGroupBundle component2 = _mcDailyRewardProductGroup.GetComponent<ShopProductGroupBundle>();
			List<ShopProductModel> productsDailyReward2 = _productsDailyReward;
			component2.RefreshData((List<>)(object)productsDailyReward2);
			component2.RefreshDisplay();
			List<ShopProductModel> productsRegularBundle = _productsRegularBundle;
			GameObject mcRegularBundleProductGroup = _mcRegularBundleProductGroup;
			int num3 = 0;
			if (mcRegularBundleProductGroup == (Object)num3)
			{
				GameObject gameObject3 = (_mcRegularBundleProductGroup = Object.Instantiate(_prefabBundleProductGroup, parent));
			}
			ShopProductGroupBundle component3 = _mcRegularBundleProductGroup.GetComponent<ShopProductGroupBundle>();
			List<ShopProductModel> productsRegularBundle2 = _productsRegularBundle;
			component3.RefreshData((List<>)(object)productsRegularBundle2);
			component3.RefreshDisplay();
			List<ShopProductModel> productsGem = _productsGem;
			GameObject mcGemProductGroup = _mcGemProductGroup;
			int num4 = 0;
			if (mcGemProductGroup == (Object)num4)
			{
				GameObject gameObject4 = (_mcGemProductGroup = Object.Instantiate(_prefabGemProductGroup, parent));
			}
			ShopProductGroupGem component4 = _mcGemProductGroup.GetComponent<ShopProductGroupGem>();
			List<ShopProductModel> productsGem2 = _productsGem;
			component4.RefreshData((List<>)(object)productsGem2);
			component4.RefreshDisplay();
			List<ShopProductModel> productsGacha = _productsGacha;
			GameObject mcGachaProductGroup = _mcGachaProductGroup;
			int num5 = 0;
			if (mcGachaProductGroup == (Object)num5)
			{
				GameObject gameObject5 = (_mcGachaProductGroup = Object.Instantiate(_prefabGachaProductGroup, parent));
			}
			ShopProductGroupGacha component5 = _mcGachaProductGroup.GetComponent<ShopProductGroupGacha>();
			List<Texture2D> list = (component5.TexturesPresentBox = _texturesPresentBox);
			List<ShopProductModel> productsGacha2 = _productsGacha;
			component5.RefreshData((List<>)(object)productsGacha2);
			component5.RefreshDisplay();
			List<ShopProductModel> productsCurrency = _productsCurrency;
			GameObject mcCurrencyProductGroup = _mcCurrencyProductGroup;
			int num6 = 0;
			if (mcCurrencyProductGroup == (Object)num6)
			{
				GameObject gameObject6 = (_mcCurrencyProductGroup = Object.Instantiate(_prefabCurrencyProductGroup, parent));
			}
			ShopProductGroupCurrency component6 = _mcCurrencyProductGroup.GetComponent<ShopProductGroupCurrency>();
			List<ShopProductModel> productsCurrency2 = _productsCurrency;
			component6.RefreshData((List<>)(object)productsCurrency2);
			component6.RefreshDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C3A")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public EventContentShop()
		{
		}
	}
}
