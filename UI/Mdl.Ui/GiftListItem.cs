using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000514")]
	public class GiftListItem : InventorySellItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001B67")]
		[SerializeField]
		private Image _mcSelectedTransparentBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001B68")]
		[SerializeField]
		private SpriteAtlasImage _mcSelectedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001B69")]
		[SerializeField]
		private Sprite _buySelectedSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001B6A")]
		[SerializeField]
		private Sprite _selectedSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001B6B")]
		[SerializeField]
		protected StarComponent _mcStar;

		[Cpp2IlInjected.Token(Token = "0x1700052E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xD0"), Cpp2IlInjected.Token(Token = "0x4001B65")]
		public int MaxSelectableItems
		{
			[Cpp2IlInjected.Token(Token = "0x600210F")]
			[Cpp2IlInjected.Address(RVA = "0xE58440", Offset = "0xE56E40", VA = "0x180E58440")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002110")]
			[Cpp2IlInjected.Address(RVA = "0xE58490", Offset = "0xE56E90", VA = "0x180E58490")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700052F")]
		public Dictionary<int, int> SelectedItemsAndAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6002111")]
			[Cpp2IlInjected.Address(RVA = "0x738E80", Offset = "0x737880", VA = "0x180738E80")]
			[CompilerGenerated]
			get
			{
				return _003CSelectedItemsAndAmount_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002112")]
			[Cpp2IlInjected.Address(RVA = "0x739E90", Offset = "0x738890", VA = "0x180739E90")]
			[CompilerGenerated]
			set
			{
				_003CSelectedItemsAndAmount_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000530")]
		public override bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6002113")]
			[Cpp2IlInjected.Address(RVA = "0xD2FCE0", Offset = "0xD2E6E0", VA = "0x180D2FCE0", Slot = "4")]
			get
			{
				return _isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x6002114")]
			[Cpp2IlInjected.Address(RVA = "0xE58450", Offset = "0xE56E50", VA = "0x180E58450", Slot = "5")]
			set
			{
				//Discarded unreachable code: IL_0014
				_isSelected = value;
				_mcSelected.SetActive(value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000531")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x108"), Cpp2IlInjected.Token(Token = "0x4001B6C")]
		public GiftMenu.GiftMenuTabs ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6002115")]
			[Cpp2IlInjected.Address(RVA = "0xE58430", Offset = "0xE56E30", VA = "0x180E58430")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002116")]
			[Cpp2IlInjected.Address(RVA = "0xE58480", Offset = "0xE56E80", VA = "0x180E58480")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000532")]
		public ItemState State
		{
			[Cpp2IlInjected.Token(Token = "0x6002117")]
			[Cpp2IlInjected.Address(RVA = "0x7389D0", Offset = "0x7373D0", VA = "0x1807389D0")]
			[CompilerGenerated]
			get
			{
				return _003CState_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002118")]
			[Cpp2IlInjected.Address(RVA = "0x83E110", Offset = "0x83CB10", VA = "0x18083E110")]
			[CompilerGenerated]
			internal set
			{
				_003CState_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002119")]
		[Cpp2IlInjected.Address(RVA = "0xE57BD0", Offset = "0xE565D0", VA = "0x180E57BD0", Slot = "8")]
		internal override void RefreshSelectedAmount(bool autoSelect = false)
		{
			//Discarded unreachable code: IL_0063
			TextBase tfPrice = _tfPrice;
			if (IsSelected)
			{
			}
			string text = default(string);
			tfPrice.Text = text;
			LayoutRebuilder.ForceRebuildLayoutImmediate(_mcCurrencyHolder);
			RefreshAddButton();
			int num = base.SelectedAmount;
			string text2 = default(string);
			_tfSelectedAmount.Text = text2;
			OnAmountChangedDelegate onAmountChanged = OnAmountChanged;
			if (onAmountChanged != null)
			{
				int amount = base.SelectedAmount;
				onAmountChanged(this, amount);
			}
			RefreshCurrency();
		}

		[Cpp2IlInjected.Token(Token = "0x600211A")]
		[Cpp2IlInjected.Address(RVA = "0xE57D10", Offset = "0xE56710", VA = "0x180E57D10")]
		public void RefreshSelectedDisplay()
		{
			//Discarded unreachable code: IL_0056
			_mcSelectedTransparentBackground.gameObject.SetActive(value: true);
			_btnDeselect.gameObject.SetActive(value: true);
			_btnAdd.gameObject.SetActive(value: true);
			_btnSubtract.gameObject.SetActive(value: true);
			_tfSelectedAmount.gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600211B")]
		[Cpp2IlInjected.Address(RVA = "0xE57A80", Offset = "0xE56480", VA = "0x180E57A80", Slot = "9")]
		protected override void RefreshCurrency()
		{
			//Discarded unreachable code: IL_0070
			int num = base.InventoryCount;
			SpriteAtlasImage mcSelectedBg = _mcSelectedBg;
			string text2 = (mcSelectedBg.ImageAddress = _selectedSprite.name);
			GameObject gameObject = _mcCurrencyBg.gameObject;
			int num2 = 0;
			bool active = base.InventoryCount == 0;
			gameObject.SetActive(active);
			GameObject gameObject2 = _mcCurrencyHolder.gameObject;
			bool active2 = base.InventoryCount == 0;
			gameObject2.SetActive(active2);
			LayoutRebuilder.ForceRebuildLayoutImmediate(_mcCurrencyHolder);
		}

		[Cpp2IlInjected.Token(Token = "0x600211C")]
		[Cpp2IlInjected.Address(RVA = "0xE57DF0", Offset = "0xE567F0", VA = "0x180E57DF0", Slot = "6")]
		internal override void Refresh()
		{
			//Discarded unreachable code: IL_01b3
			//IL_0019: Expected O, but got I4
			//IL_002d: Expected O, but got I4
			//IL_0104: Expected O, but got I4
			//IL_0136: Expected O, but got I4
			//IL_0189: Expected O, but got I4
			AsyncAtlassedIcon asyncAtlassedIcon = mc_icon;
			int num = 0;
			RawImage rawImage = asyncAtlassedIcon.RawImage;
			int num2 = 0;
			rawImage.texture = (Texture)num2;
			TextBase textBase = tf_itemName;
			int num3 = 0;
			if (textBase != (UnityEngine.Object)num3)
			{
				TextBase textBase2 = tf_itemName;
				string text2 = (textBase2.StringID = base.ItemName);
			}
			Transform transform = _mcStar.transform;
			int num4 = 0;
			if (58 == 0)
			{
				IItemData itemData = base.ItemData;
				if (itemData != null && itemData != null)
				{
					_mcStar.gameObject.SetActive(value: false);
					_mcStar.Star = 16777216;
				}
				GameObject gameObject = tf_itemName.gameObject;
				bool active = ItemType == (GiftMenu.GiftMenuTabs)num;
				gameObject.SetActive(active);
			}
			GameObject gameObject2 = tf_itemName.gameObject;
			bool active2 = ItemType == (GiftMenu.GiftMenuTabs)num;
			gameObject2.SetActive(active2);
			_mcStar.gameObject.SetActive(value: true);
			StarComponent mcStar = _mcStar;
			IItemData itemData2 = base.ItemData;
			bool flag = default(bool);
			if (flag)
			{
				int num5 = (base.Price = Enumerable.FirstOrDefault<CurrencyCost>((IEnumerable<>)num).amount_);
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				AsyncAtlassedIcon mcCurrency = _mcCurrency;
			}
			TextBase textBase3 = tf_inventoryCount;
			int num6 = 0;
			if (textBase3 != (UnityEngine.Object)num6)
			{
				int num7 = base.InventoryCount;
				string text3 = default(string);
				tf_inventoryCount.Text = text3;
				if ((object)tf_inventoryCount.transform != null)
				{
				}
				TextBase textBase4 = tf_inventoryCount;
				RectTransform mcInventoryCounterContent = _mcInventoryCounterContent;
				Transform transform2 = textBase4.transform;
			}
			AsyncAtlassedIcon asyncAtlassedIcon2 = mc_icon;
			int num8 = 0;
			if (asyncAtlassedIcon2 != (UnityEngine.Object)num8)
			{
				AsyncAtlassedIcon asyncAtlassedIcon3 = mc_icon;
				string icon = base.IconTexture;
				bool flag2 = asyncAtlassedIcon3.SetIcon(icon);
			}
			int autoSelect = 0;
			RefreshSelectedAmount((byte)autoSelect != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600211D")]
		[Cpp2IlInjected.Address(RVA = "0xE578E0", Offset = "0xE562E0", VA = "0x180E578E0")]
		internal void RefreshAddButton()
		{
			//Discarded unreachable code: IL_0057
			if (!IsSelected)
			{
				return;
			}
			BaseButton btnAdd = _btnAdd;
			int num = MaxSelectableItems;
			Dictionary<int, int> dictionary = SelectedItemsAndAmount;
			Func<KeyValuePair<int, int>, int> _003C_003E9__28_ = _003C_003Ec._003C_003E9__28_0;
			if (_003C_003E9__28_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			int num2 = Enumerable.Sum<KeyValuePair<int, int>>((IEnumerable<>)dictionary, (Func<, >)(object)_003C_003E9__28_);
			int num3 = base.SelectedAmount;
			bool isActive = default(bool);
			btnAdd.IsActive = isActive;
		}

		[Cpp2IlInjected.Token(Token = "0x600211E")]
		[Cpp2IlInjected.Address(RVA = "0xE578B0", Offset = "0xE562B0", VA = "0x180E578B0", Slot = "7")]
		protected override void OnDeselectHandler()
		{
			base.OnDeselectHandler();
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x600211F")]
		[Cpp2IlInjected.Address(RVA = "0xE58420", Offset = "0xE56E20", VA = "0x180E58420")]
		public GiftListItem()
		{
		}
	}
}
