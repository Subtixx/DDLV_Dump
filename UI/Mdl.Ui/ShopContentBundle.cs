using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006C1")]
	public class ShopContentBundle : ShopContentDefault
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002622")]
		private List<ShopProductModel> _productsAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002623")]
		private List<ShopProductModel> _productsCharacterBundle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002624")]
		private List<ShopProductModel> _productsRegularBundle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002625")]
		private List<ShopProductModel> _productsDailyReward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002627")]
		private GameObject _mcDailyRewardProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002628")]
		private GameObject _mcRegularBundleProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002629")]
		private GameObject _mcCharacterBundleProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400262A")]
		[SerializeField]
		protected GameObject _prefabDailyRewardProductGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400262B")]
		[SerializeField]
		protected GameObject _prefabCharacterBundleProductGroup;

		[Cpp2IlInjected.Token(Token = "0x17000657")]
		public List<ShopProductItemCustomizedBundleTemplate> _templates
		{
			[Cpp2IlInjected.Token(Token = "0x6002B82")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003C_templates_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B83")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			set
			{
				_003C_templates_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B84")]
		[Cpp2IlInjected.Address(RVA = "0x1426550", Offset = "0x1424F50", VA = "0x181426550", Slot = "4")]
		public override void RefreshData(List<ShopProductModel> products, [Optional] List<ShopProductItemCustomizedBundleTemplate> templates)
		{
			//Discarded unreachable code: IL_005e, IL_0064, IL_006a, IL_0070
			_productsAll = products;
			_templates = templates;
			List<ShopProductModel> list = (_productsDailyReward = (List<ShopProductModel>)(object)new List<T>());
			List<ShopProductModel> list2 = (_productsCharacterBundle = (List<ShopProductModel>)(object)new List<T>());
			List<ShopProductModel> list3 = (_productsRegularBundle = (List<ShopProductModel>)(object)new List<T>());
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
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

		[Cpp2IlInjected.Token(Token = "0x6002B85")]
		[Cpp2IlInjected.Address(RVA = "0x1426820", Offset = "0x1425220", VA = "0x181426820", Slot = "5")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0138
			//IL_0023: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_00e8: Expected O, but got I4
			Transform parent = _mcProductGroupsHolder.transform;
			List<ShopProductModel> productsDailyReward = _productsDailyReward;
			GameObject mcDailyRewardProductGroup = _mcDailyRewardProductGroup;
			int num = 0;
			if (mcDailyRewardProductGroup == (Object)num)
			{
				GameObject gameObject = (_mcDailyRewardProductGroup = Object.Instantiate(_prefabDailyRewardProductGroup, parent));
			}
			ShopProductGroupBundle component = _mcDailyRewardProductGroup.GetComponent<ShopProductGroupBundle>();
			List<ShopProductModel> productsDailyReward2 = _productsDailyReward;
			component.RefreshData((List<>)(object)productsDailyReward2);
			component.RefreshDisplay();
			List<ShopProductModel> productsCharacterBundle = _productsCharacterBundle;
			GameObject mcCharacterBundleProductGroup = _mcCharacterBundleProductGroup;
			int num2 = 0;
			if (mcCharacterBundleProductGroup == (Object)num2)
			{
				GameObject gameObject2 = (_mcCharacterBundleProductGroup = Object.Instantiate(_prefabCharacterBundleProductGroup, parent));
			}
			ShopProductGroupBundle component2 = _mcCharacterBundleProductGroup.GetComponent<ShopProductGroupBundle>();
			List<ShopProductModel> productsCharacterBundle2 = _productsCharacterBundle;
			component2.RefreshData((List<>)(object)productsCharacterBundle2);
			List<ShopProductItemCustomizedBundleTemplate> list = (component2.Templates = _templates);
			component2.RefreshDisplay();
			List<ShopProductModel> productsRegularBundle = _productsRegularBundle;
			GameObject mcRegularBundleProductGroup = _mcRegularBundleProductGroup;
			int num3 = 0;
			if (mcRegularBundleProductGroup == (Object)num3)
			{
				GameObject gameObject3 = (_mcRegularBundleProductGroup = Object.Instantiate(_prefabProductGroup, parent));
			}
			ShopProductGroupBundle component3 = _mcRegularBundleProductGroup.GetComponent<ShopProductGroupBundle>();
			List<ShopProductModel> productsRegularBundle2 = _productsRegularBundle;
			component3.RefreshData((List<>)(object)productsRegularBundle2);
			List<ShopProductItemCustomizedBundleTemplate> list2 = (component3.Templates = _templates);
			component3.RefreshDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B86")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ShopContentBundle()
		{
		}
	}
}
