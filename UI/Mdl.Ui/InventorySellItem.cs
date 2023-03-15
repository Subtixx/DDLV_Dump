using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000354")]
	[RequiredAllNotNull]
	public class InventorySellItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000355")]
		public delegate void OnAmountChangedDelegate(InventorySellItem item, int amount);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000FD8")]
		public OnAmountChangedDelegate OnAmountChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000FD9")]
		[SerializeField]
		protected AsyncAtlassedIcon mc_icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000FDA")]
		[SerializeField]
		protected TextBase tf_itemName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000FDB")]
		[SerializeField]
		protected TextBase tf_inventoryCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000FDC")]
		[SerializeField]
		protected RectTransform _mcInventoryCounterContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000FDD")]
		[SerializeField]
		protected TextBase _tfSelectedAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D")]
		[Cpp2IlInjected.Token(Token = "0x4000FE0")]
		protected bool _isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000FE1")]
		[SerializeField]
		protected TextBase _tfPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000FE2")]
		[SerializeField]
		protected AsyncAtlassedIcon _mcCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000FE3")]
		[SerializeField]
		protected RectTransform _mcCurrencyHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000FE4")]
		[SerializeField]
		protected RectTransform _mcCurrencyBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000FE5")]
		[SerializeField]
		protected RectTransform _mcButtonContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000FE6")]
		protected bool _showCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000FE7")]
		[SerializeField]
		protected Button _btnDeselect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000FE8")]
		[SerializeField]
		protected BaseButton _btnAdd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000FE9")]
		[SerializeField]
		protected BaseButton _btnSubtract;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000FF1")]
		[SerializeField]
		protected GameObject _mcSelected;

		[Cpp2IlInjected.Token(Token = "0x170003A3")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x4000FDE")]
		public int SelectedAmount
		{
			[Cpp2IlInjected.Token(Token = "0x600151A")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600151B")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170003A4")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x4C"), Cpp2IlInjected.Token(Token = "0x4000FDF")]
		public bool IsSelectable
		{
			[Cpp2IlInjected.Token(Token = "0x600151C")]
			[Cpp2IlInjected.Address(RVA = "0x70CA70", Offset = "0x70B470", VA = "0x18070CA70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600151D")]
			[Cpp2IlInjected.Address(RVA = "0x70CE60", Offset = "0x70B860", VA = "0x18070CE60")]
			set;
		} = true;


		[Cpp2IlInjected.Token(Token = "0x170003A5")]
		public virtual bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x600151E")]
			[Cpp2IlInjected.Address(RVA = "0xD2FCE0", Offset = "0xD2E6E0", VA = "0x180D2FCE0", Slot = "4")]
			get
			{
				return _isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x600151F")]
			[Cpp2IlInjected.Address(RVA = "0xD2FD00", Offset = "0xD2E700", VA = "0x180D2FD00", Slot = "5")]
			set
			{
				if (IsSelectable)
				{
					_isSelected = value;
					IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A6")]
		public bool ShowCurrency
		{
			[Cpp2IlInjected.Token(Token = "0x6001520")]
			[Cpp2IlInjected.Address(RVA = "0xAE8610", Offset = "0xAE7010", VA = "0x180AE8610")]
			get
			{
				return _showCurrency;
			}
			[Cpp2IlInjected.Token(Token = "0x6001521")]
			[Cpp2IlInjected.Address(RVA = "0xD2FD40", Offset = "0xD2E740", VA = "0x180D2FD40")]
			set
			{
				_showCurrency = value;
				IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A7")]
		internal BaseButton AddButton
		{
			[Cpp2IlInjected.Token(Token = "0x6001522")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			get
			{
				return _btnAdd;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A8")]
		internal BaseButton SubtractButton
		{
			[Cpp2IlInjected.Token(Token = "0x6001523")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			get
			{
				return _btnSubtract;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A9")]
		internal string IconTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6001524")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			[CompilerGenerated]
			get
			{
				return _003CIconTexture_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001525")]
			[Cpp2IlInjected.Address(RVA = "0x824230", Offset = "0x822C30", VA = "0x180824230")]
			[CompilerGenerated]
			set
			{
				_003CIconTexture_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AA")]
		internal AsyncAtlassedIcon IconAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6001526")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return mc_icon;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AB")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xA0"), Cpp2IlInjected.Token(Token = "0x4000FEB")]
		internal int InventoryCount
		{
			[Cpp2IlInjected.Token(Token = "0x6001527")]
			[Cpp2IlInjected.Address(RVA = "0x975DB0", Offset = "0x9747B0", VA = "0x180975DB0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001528")]
			[Cpp2IlInjected.Address(RVA = "0x976580", Offset = "0x974F80", VA = "0x180976580")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170003AC")]
		internal string ItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6001529")]
			[Cpp2IlInjected.Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
			[CompilerGenerated]
			get
			{
				return _003CItemName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600152A")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACE0", Offset = "0xA596E0", VA = "0x180A5ACE0")]
			[CompilerGenerated]
			set
			{
				_003CItemName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AD")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xB0"), Cpp2IlInjected.Token(Token = "0x4000FED")]
		internal int ItemIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600152B")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACB0", Offset = "0xA596B0", VA = "0x180A5ACB0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600152C")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACD0", Offset = "0xA596D0", VA = "0x180A5ACD0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170003AE")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xB4"), Cpp2IlInjected.Token(Token = "0x4000FEE")]
		internal int InventoryIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600152D")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACC0", Offset = "0xA596C0", VA = "0x180A5ACC0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600152E")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACF0", Offset = "0xA596F0", VA = "0x180A5ACF0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170003AF")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xB8"), Cpp2IlInjected.Token(Token = "0x4000FEF")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x600152F")]
			[Cpp2IlInjected.Address(RVA = "0xD2FCF0", Offset = "0xD2E6F0", VA = "0x180D2FCF0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001530")]
			[Cpp2IlInjected.Address(RVA = "0xD2FD30", Offset = "0xD2E730", VA = "0x180D2FD30")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x170003B0")]
		public IItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6001531")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC30", Offset = "0x7D9630", VA = "0x1807DAC30")]
			[CompilerGenerated]
			get
			{
				return _003CItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001532")]
			[Cpp2IlInjected.Address(RVA = "0xD2FD20", Offset = "0xD2E720", VA = "0x180D2FD20")]
			[CompilerGenerated]
			internal set
			{
				_003CItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001533")]
		[Cpp2IlInjected.Address(RVA = "0xD2F900", Offset = "0xD2E300", VA = "0x180D2F900", Slot = "6")]
		internal virtual void Refresh()
		{
			//Discarded unreachable code: IL_00f3
			//IL_0019: Expected O, but got I4
			//IL_002d: Expected O, but got I4
			//IL_0076: Expected O, but got I4
			//IL_00c9: Expected O, but got I4
			AsyncAtlassedIcon asyncAtlassedIcon = mc_icon;
			int num = 0;
			RawImage rawImage = asyncAtlassedIcon.RawImage;
			int num2 = 0;
			rawImage.texture = (Texture)num2;
			TextBase textBase = tf_itemName;
			int num3 = 0;
			if (textBase != (Object)num3)
			{
				TextBase textBase2 = tf_itemName;
				string text2 = (textBase2.StringID = ItemName);
			}
			int num4 = 0;
			Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			AsyncAtlassedIcon mcCurrency = _mcCurrency;
			TextBase textBase3 = tf_inventoryCount;
			int num5 = 0;
			if (textBase3 != (Object)num5)
			{
				int num6 = InventoryCount;
				string text3 = default(string);
				tf_inventoryCount.Text = text3;
				if ((object)tf_inventoryCount.transform != null)
				{
				}
				TextBase textBase4 = tf_inventoryCount;
				RectTransform mcInventoryCounterContent = _mcInventoryCounterContent;
				Transform transform = textBase4.transform;
			}
			AsyncAtlassedIcon asyncAtlassedIcon2 = mc_icon;
			int num7 = 0;
			if (asyncAtlassedIcon2 != (Object)num7)
			{
				AsyncAtlassedIcon asyncAtlassedIcon3 = mc_icon;
				string icon = IconTexture;
				bool flag = asyncAtlassedIcon3.SetIcon(icon);
			}
			int autoSelect = 0;
			RefreshSelectedAmount((byte)autoSelect != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001534")]
		[Cpp2IlInjected.Address(RVA = "0xD2F210", Offset = "0xD2DC10", VA = "0x180D2F210")]
		private void Awake()
		{
			//Discarded unreachable code: IL_00c2
			UnityAction call = default(UnityAction);
			_btnDeselect.m_OnClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick = _btnAdd.ButtonComponent.m_OnClick;
			UnityAction call2 = OnAddClickHandler;
			onClick.RemoveListener(call2);
			Button.ButtonClickedEvent onClick2 = _btnSubtract.ButtonComponent.m_OnClick;
			UnityAction call3 = OnSubtractHandler;
			onClick2.RemoveListener(call3);
			UnityAction call4 = default(UnityAction);
			_btnDeselect.m_OnClick.AddListener(call4);
			Button.ButtonClickedEvent onClick3 = _btnAdd.ButtonComponent.m_OnClick;
			UnityAction call5 = OnAddClickHandler;
			onClick3.AddListener(call5);
			Button.ButtonClickedEvent onClick4 = _btnSubtract.ButtonComponent.m_OnClick;
			UnityAction call6 = OnSubtractHandler;
			onClick4.AddListener(call6);
		}

		[Cpp2IlInjected.Token(Token = "0x6001535")]
		[Cpp2IlInjected.Address(RVA = "0xD2F530", Offset = "0xD2DF30", VA = "0x180D2F530")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_005e
			UnityAction call = default(UnityAction);
			_btnDeselect.m_OnClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick = _btnAdd.ButtonComponent.m_OnClick;
			UnityAction call2 = OnAddClickHandler;
			onClick.RemoveListener(call2);
			Button.ButtonClickedEvent onClick2 = _btnSubtract.ButtonComponent.m_OnClick;
			UnityAction call3 = OnSubtractHandler;
			onClick2.RemoveListener(call3);
		}

		[Cpp2IlInjected.Token(Token = "0x6001536")]
		[Cpp2IlInjected.Address(RVA = "0xD2F6A0", Offset = "0xD2E0A0", VA = "0x180D2F6A0")]
		private void OnSubtractHandler()
		{
			int num = SelectedAmount;
			if (num > 0)
			{
				int amount = (SelectedAmount = num - 1);
				OnAmountChanged?.Invoke(this, amount);
				IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001537")]
		[Cpp2IlInjected.Address(RVA = "0xD2F490", Offset = "0xD2DE90", VA = "0x180D2F490")]
		private void OnAddClickHandler()
		{
			//Discarded unreachable code: IL_0045
			if (_btnAdd._isActive)
			{
				int num = SelectedAmount;
				if (InventoryCount > num)
				{
					int amount = (SelectedAmount = num + 1);
					OnAmountChanged?.Invoke(this, amount);
					IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001538")]
		[Cpp2IlInjected.Address(RVA = "0xD2F500", Offset = "0xD2DF00", VA = "0x180D2F500", Slot = "7")]
		protected virtual void OnDeselectHandler()
		{
			//IL_0010: Expected I4, but got I8
			OnAmountChangedDelegate onAmountChanged = OnAmountChanged;
			SelectedAmount = 0;
			if (onAmountChanged != null)
			{
				int amount = 0;
				onAmountChanged(this, amount);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001539")]
		[Cpp2IlInjected.Address(RVA = "0xD2F750", Offset = "0xD2E150", VA = "0x180D2F750", Slot = "8")]
		internal virtual void RefreshSelectedAmount(bool autoSelect = false)
		{
			//Discarded unreachable code: IL_00e4
			if (autoSelect)
			{
				int num = (SelectedAmount = InventoryCount);
			}
			int num2 = SelectedAmount;
			GameObject mcSelected = _mcSelected;
			bool active = _isSelected;
			mcSelected.SetActive(active);
			GameObject gameObject = _mcButtonContent.gameObject;
			bool isSelected = _isSelected;
			gameObject.SetActive(isSelected);
			TextBase tfPrice = _tfPrice;
			bool isSelected2 = IsSelected;
			int num3 = Price;
			if (isSelected2)
			{
			}
			string text = default(string);
			tfPrice.Text = text;
			LayoutRebuilder.ForceRebuildLayoutImmediate(_mcCurrencyHolder);
			BaseButton btnAdd = _btnAdd;
			int num4 = SelectedAmount;
			bool flag2 = (btnAdd.IsActive = InventoryCount != num4);
			int num5 = SelectedAmount;
			string text2 = default(string);
			_tfSelectedAmount.Text = text2;
			if (autoSelect)
			{
				OnAmountChangedDelegate onAmountChanged = OnAmountChanged;
				if (onAmountChanged != null)
				{
					int amount = SelectedAmount;
					onAmountChanged(this, amount);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600153A")]
		[Cpp2IlInjected.Address(RVA = "0xD2F6F0", Offset = "0xD2E0F0", VA = "0x180D2F6F0", Slot = "9")]
		protected virtual void RefreshCurrency()
		{
			//Discarded unreachable code: IL_0035
			GameObject gameObject = _mcCurrencyBg.gameObject;
			bool showCurrency = _showCurrency;
			gameObject.SetActive(showCurrency);
			GameObject gameObject2 = _mcCurrencyHolder.gameObject;
			bool showCurrency2 = _showCurrency;
			gameObject2.SetActive(showCurrency2);
		}

		[Cpp2IlInjected.Token(Token = "0x600153B")]
		[Cpp2IlInjected.Address(RVA = "0xD2FCD0", Offset = "0xD2E6D0", VA = "0x180D2FCD0")]
		public InventorySellItem()
		{
		}
	}
}
