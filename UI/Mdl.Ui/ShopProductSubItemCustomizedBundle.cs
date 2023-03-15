using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000708")]
	public class ShopProductSubItemCustomizedBundle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002865")]
		public GameObject NameHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002866")]
		public GameObject NameText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002867")]
		public GameObject NameBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002868")]
		public GameObject IconHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002869")]
		public GameObject IconImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400286A")]
		public GameObject IconBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400286B")]
		public GameObject AmountHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400286C")]
		public GameObject AmountText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400286D")]
		public GameObject AmountBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400286E")]
		public GameObject Rarity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400286F")]
		[Space]
		[SerializeField]
		private AsyncAtlassedIcon _mcImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002870")]
		[SerializeField]
		private TextBase _tfAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002871")]
		[SerializeField]
		private TextBase _tfName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002872")]
		[SerializeField]
		private GameObject _mcRarity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002873")]
		[Space]
		public ShopProductSubItemCustomizedBundleTemplate Template;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002874")]
		[Space]
		[SerializeField]
		[ItemID]
		private int _item = (int)Item.Invalid;

		[Cpp2IlInjected.Token(Token = "0x17000678")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002CC7")]
			[Cpp2IlInjected.Address(RVA = "0x143C780", Offset = "0x143B180", VA = "0x18143C780")]
			get
			{
				long num = Convert.ToInt64((uint)_item);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CC8")]
			[Cpp2IlInjected.Address(RVA = "0x725370", Offset = "0x723D70", VA = "0x180725370")]
			set
			{
				//IL_0007: Expected I4, but got O
				_item = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000679")]
		public IItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6002CC9")]
			[Cpp2IlInjected.Address(RVA = "0x143C6C0", Offset = "0x143B0C0", VA = "0x18143C6C0")]
			get
			{
				//Discarded unreachable code: IL_0008
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				IItemData result = default(IItemData);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700067A")]
		public ItemReward ItemReward
		{
			[Cpp2IlInjected.Token(Token = "0x6002CCA")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			[CompilerGenerated]
			get
			{
				return _003CItemReward_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CCB")]
			[Cpp2IlInjected.Address(RVA = "0x824230", Offset = "0x822C30", VA = "0x180824230")]
			[CompilerGenerated]
			set
			{
				_003CItemReward_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CCC")]
		[Cpp2IlInjected.Address(RVA = "0x143BE50", Offset = "0x143A850", VA = "0x18143BE50")]
		public void RefreshDisplay(ItemReward reward)
		{
			//Discarded unreachable code: IL_0240, IL_0246, IL_0258
			int num = 0;
			UIChildTemplate nameHolderTemplate = Template.NameHolderTemplate;
			GameObject nameHolder = NameHolder;
			nameHolderTemplate.Load(nameHolder);
			UITextTemplate nameTextTemplate = Template.NameTextTemplate;
			GameObject nameText = NameText;
			nameTextTemplate.Load(nameText);
			UIChildTemplate nameBackgroundTemplate = Template.NameBackgroundTemplate;
			GameObject nameBg = NameBg;
			nameBackgroundTemplate.Load(nameBg);
			UIChildTemplate iconHolderTemplate = Template.IconHolderTemplate;
			GameObject iconHolder = IconHolder;
			iconHolderTemplate.Load(iconHolder);
			UIChildTemplate iconTemplate = Template.IconTemplate;
			GameObject iconImage = IconImage;
			iconTemplate.Load(iconImage);
			UIChildTemplate iconBackgroundTemplate = Template.IconBackgroundTemplate;
			GameObject iconBg = IconBg;
			iconBackgroundTemplate.Load(iconBg);
			UIChildTemplate amountHolderTemplate = Template.AmountHolderTemplate;
			GameObject amountHolder = AmountHolder;
			amountHolderTemplate.Load(amountHolder);
			UITextTemplate amountTextTemplate = Template.AmountTextTemplate;
			GameObject amountText = AmountText;
			amountTextTemplate.Load(amountText);
			UIChildTemplate amountBackgroundTemplate = Template.AmountBackgroundTemplate;
			GameObject amountBg = AmountBg;
			amountBackgroundTemplate.Load(amountBg);
			UIChildTemplate rarityTemplate = Template.RarityTemplate;
			GameObject rarity = Rarity;
			rarityTemplate.Load(rarity);
			ShopProductSubItemCustomizedBundleTemplate template = Template;
			GameObject gameObject = base.gameObject;
			template.Load(gameObject);
			ItemReward = reward;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = reward.Item;
			if (NameHolder.activeSelf)
			{
				TextBase tfName = _tfName;
			}
			if (IconHolder.activeSelf)
			{
				AsyncAtlassedIcon mcImage = _mcImage;
			}
			if (AmountHolder.activeSelf)
			{
				TextBase tfAmount = _tfAmount;
				string text = default(string);
				string text3 = (tfAmount.Text = "x" + text);
				if ((object)_tfAmount.transform != null)
				{
				}
				if ((object)_tfAmount.transform.parent == null)
				{
				}
			}
			if (!Rarity.activeSelf)
			{
				return;
			}
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			Item item2 = reward.Item;
			IEnumerator enumerator = _mcRarity.transform.GetEnumerator();
			bool flag = default(bool);
			if (enumerator != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num4 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				IHasRarity hasRarity = default(IHasRarity);
				if (hasRarity == null)
				{
				}
				flag = num < num;
				GameObject gameObject2 = default(GameObject);
				gameObject2.SetActive(flag);
				num++;
			}
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CCD")]
		[Cpp2IlInjected.Address(RVA = "0x143C650", Offset = "0x143B050", VA = "0x18143C650")]
		public ShopProductSubItemCustomizedBundle()
		{
		}//IL_000d: Expected I4, but got O

	}
}
