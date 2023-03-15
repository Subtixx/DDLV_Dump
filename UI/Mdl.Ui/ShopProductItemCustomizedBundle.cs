using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006EF")]
	public class ShopProductItemCustomizedBundle : ShopProductItemDefault
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002736")]
		public GameObject ItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4002737")]
		public RectTransform ItemsContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002738")]
		[Space]
		public GameObject Background;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002739")]
		public GameObject Title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400273A")]
		public GameObject Subtitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400273B")]
		public GameObject InfoButtonWhite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400273C")]
		public GameObject InfoButtonBlue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400273D")]
		public GameObject PurchaseButtonRed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400273E")]
		public GameObject PurchaseButtonBlue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400273F")]
		[SerializeField]
		[Space]
		private TextBase _tfTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002740")]
		[SerializeField]
		private TextBase _tfSubtitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4002741")]
		private ShopProductPurchaseButton _mcPurchase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4002742")]
		[Space]
		public ShopProductItemCustomizedBundleTemplate Template;

		[Cpp2IlInjected.Token(Token = "0x6002C4F")]
		[Cpp2IlInjected.Address(RVA = "0x739E90", Offset = "0x738890", VA = "0x180739E90", Slot = "25")]
		public override void RefreshData(ShopProductModel model)
		{
			base.Model = model;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C50")]
		[Cpp2IlInjected.Address(RVA = "0x1431440", Offset = "0x142FE40", VA = "0x181431440", Slot = "26")]
		public unsafe override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_01f6, IL_01fc, IL_0202, IL_0208, IL_020e, IL_0214, IL_0220
			//IL_01e7: Expected I4, but got O
			//IL_01f5: Expected I4, but got O
			int num = 0;
			UIDownloadableImageTemplate backgroundTemplate = Template.BackgroundTemplate;
			GameObject background = Background;
			backgroundTemplate.Load(background);
			UITextTemplate titleTemplate = Template.TitleTemplate;
			GameObject title = Title;
			titleTemplate.Load(title);
			UITextTemplate subtitleTemplate = Template.SubtitleTemplate;
			GameObject subtitle = Subtitle;
			subtitleTemplate.Load(subtitle);
			UIChildTemplate infoButtonTemplateWhite = Template.InfoButtonTemplateWhite;
			GameObject infoButtonWhite = InfoButtonWhite;
			infoButtonTemplateWhite.Load(infoButtonWhite);
			UIChildTemplate infoButtonTemplateBlue = Template.InfoButtonTemplateBlue;
			GameObject infoButtonBlue = InfoButtonBlue;
			infoButtonTemplateBlue.Load(infoButtonBlue);
			UIChildTemplate purchaseButtonTemplateRed = Template.PurchaseButtonTemplateRed;
			GameObject purchaseButtonRed = PurchaseButtonRed;
			purchaseButtonTemplateRed.Load(purchaseButtonRed);
			UIChildTemplate purchaseButtonTemplateBlue = Template.PurchaseButtonTemplateBlue;
			GameObject purchaseButtonBlue = PurchaseButtonBlue;
			purchaseButtonTemplateBlue.Load(purchaseButtonBlue);
			List<ShopProductSubItemCustomizedBundleTemplate> subItemTemplates = Template.SubItemTemplates;
			int childCount = ItemsContainer.childCount;
			RectTransform itemsContainer = ItemsContainer;
			if (num < childCount)
			{
				GameObject gameObject = itemsContainer.GetChild(num).gameObject;
			}
			GameObject gameObject2 = UnityEngine.Object.Instantiate(ItemPrefab, itemsContainer);
			int active = 0;
			gameObject2.SetActive((byte)active != 0);
			ShopProductSubItemCustomizedBundle component = gameObject2.GetComponent<ShopProductSubItemCustomizedBundle>();
			List<ShopProductSubItemCustomizedBundleTemplate> subItemTemplates2 = Template.SubItemTemplates;
			component.Template = (ShopProductSubItemCustomizedBundleTemplate)(object)component;
			num++;
			ShopProductItemCustomizedBundleTemplate template = Template;
			ShopProductModel shopProductModel = base.Model;
			if (shopProductModel == null)
			{
				return;
			}
			int num2 = 0;
			int num3 = 0;
			if (shopProductModel == null)
			{
				return;
			}
			Client client = default(Client);
			DateTime localTime = client.LocalTime;
			ShopProductModel shopProductModel2 = base.Model;
			int num4 = 0;
			IEnumerator enumerator = ItemsContainer.GetEnumerator();
			GameObject gameObject4 = default(GameObject);
			if (enumerator != null)
			{
				if (enumerator != null)
				{
					int num5 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
				}
				int active2 = 0;
				GameObject gameObject3 = default(GameObject);
				gameObject3.SetActive((byte)active2 != 0);
				num3++;
				int num6 = 0;
				gameObject4.SetActive(value: true);
				num3++;
			}
			int num7 = default(int);
			if ((object)gameObject4 != null)
			{
				num7 = 0;
			}
			int num8 = 0;
			bool flag = default(bool);
			if (flag)
			{
			}
			int num9 = 0;
			bool flag2 = default(bool);
			if (flag2)
			{
			}
			bool flag3 = default(bool);
			if (flag3)
			{
				BaseButton baseButton = default(BaseButton);
				((int*)num7)->m_value = (int)baseButton;
			}
			bool flag4 = default(bool);
			if (flag4)
			{
				BaseButton baseButton2 = default(BaseButton);
				((int*)num7)->m_value = (int)baseButton2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C51")]
		[Cpp2IlInjected.Address(RVA = "0x1431230", Offset = "0x142FC30", VA = "0x181431230")]
		public void OnPurchaseClicked()
		{
			//Discarded unreachable code: IL_0024
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			int num3 = 0;
			int num4 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C52")]
		[Cpp2IlInjected.Address(RVA = "0x1431120", Offset = "0x142FB20", VA = "0x181431120")]
		[AsyncStateMachine(typeof(_003CDoFakePurchaseTransaction_003Ed__16))]
		private Task DoFakePurchaseTransaction(CancellationToken ct)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C53")]
		[Cpp2IlInjected.Address(RVA = "0x142EDD0", Offset = "0x142D7D0", VA = "0x18142EDD0")]
		public ShopProductItemCustomizedBundle()
		{
		}
	}
}
