using System;
using System.Collections.Generic;
using System.Linq;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Mdl.Navigation;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000351")]
	[RequiredAllNotNull]
	public class InventoryItem : BaseWardrobeItem
	{
		[Cpp2IlInjected.Token(Token = "0x2000352")]
		public delegate void InventoryGridItemPurchased(IItemData itemData, bool refreshNodes);

		[Cpp2IlInjected.Token(Token = "0x2000353")]
		public delegate void DecalItemCreate(IItemData itemData);

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000FB4")]
		public InventoryGridItemPurchased OnItemPurchased;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000FB5")]
		public DecalItemCreate OnDecalItemCreate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000FB6")]
		[SerializeField]
		private StarComponent mc_star;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000FB7")]
		[SerializeField]
		private RectTransform _mcPriceContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000FB8")]
		[SerializeField]
		private CurrencyItemView _mcPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000FB9")]
		[SerializeField]
		private TextBase _tfOwned;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000FBA")]
		private int? _maxPurchasableAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000FBB")]
		[Nulllable]
		public TextBase Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000FBC")]
		[SerializeField]
		[Nulllable]
		private BaseButton _btnCreate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000FBD")]
		[SerializeField]
		private TextBase _recommendedPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000FBE")]
		public RectTransform AmountAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000FBF")]
		[SerializeField]
		private RectTransform _mcLocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000FC0")]
		public TextBase LockedLabelAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000FC1")]
		public TextBase AmountTextAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000FC2")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000FC3")]
		[SerializeField]
		private float _greyOutOpacity = 0.4f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000FC4")]
		[SerializeField]
		private RectTransform _mcDeactivated;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000FC5")]
		public UnityEvent OnDeactivateItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000FC6")]
		public UnityEvent OnReactivateItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000FC7")]
		[SerializeField]
		public bool HideOwned;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000FC8")]
		public Action<InventoryItem> BuyAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000FC9")]
		public AK.Wwise.Event _sfxSelectEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000FCA")]
		public AK.Wwise.Event _sfxLockedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000FCC")]
		public IItemData ItemData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000FCD")]
		public bool IsMale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x133")]
		[Cpp2IlInjected.Token(Token = "0x4000FD0")]
		public bool IsDeactivated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000FD2")]
		[SerializeField]
		[Nulllable]
		private GameObject _whiteBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000FD3")]
		[SerializeField]
		[Nulllable]
		private GameObject _whiteBgHover;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000FD4")]
		[SerializeField]
		[Nulllable]
		private GameObject _whiteBgSelect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000FD5")]
		[SerializeField]
		[Nulllable]
		private GameObject _whiteBgHoverSelect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000FD6")]
		public bool ShouldBeActivated = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
		[Cpp2IlInjected.Token(Token = "0x4000FD7")]
		private bool _isHighlighted;

		[Cpp2IlInjected.Token(Token = "0x1700039C")]
		public TextBase TfOwned
		{
			[Cpp2IlInjected.Token(Token = "0x60014F5")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			get
			{
				return _tfOwned;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039D")]
		public int? MaxPurchasableAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60014F6")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			get
			{
				return _maxPurchasableAmount;
			}
			[Cpp2IlInjected.Token(Token = "0x60014F7")]
			[Cpp2IlInjected.Address(RVA = "0xD2D650", Offset = "0xD2C050", VA = "0x180D2D650")]
			set
			{
				_maxPurchasableAmount = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039E")]
		public BaseButton CreateBtn
		{
			[Cpp2IlInjected.Token(Token = "0x60014F8")]
			[Cpp2IlInjected.Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
			get
			{
				return _btnCreate;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x120"), Cpp2IlInjected.Token(Token = "0x4000FCB")]
		public bool UseFakeCatalog
		{
			[Cpp2IlInjected.Token(Token = "0x60014F9")]
			[Cpp2IlInjected.Address(RVA = "0xD2D610", Offset = "0xD2C010", VA = "0x180D2D610")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60014FA")]
			[Cpp2IlInjected.Address(RVA = "0xD2D660", Offset = "0xD2C060", VA = "0x180D2D660")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170003A0")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x131"), Cpp2IlInjected.Token(Token = "0x4000FCE")]
		public bool IsOwned
		{
			[Cpp2IlInjected.Token(Token = "0x60014FB")]
			[Cpp2IlInjected.Address(RVA = "0xD2D600", Offset = "0xD2C000", VA = "0x180D2D600")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60014FC")]
			[Cpp2IlInjected.Address(RVA = "0xD2D640", Offset = "0xD2C040", VA = "0x180D2D640")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x170003A1")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x132"), Cpp2IlInjected.Token(Token = "0x4000FCF")]
		public bool IsLocked
		{
			[Cpp2IlInjected.Token(Token = "0x60014FD")]
			[Cpp2IlInjected.Address(RVA = "0xD2D5F0", Offset = "0xD2BFF0", VA = "0x180D2D5F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60014FE")]
			[Cpp2IlInjected.Address(RVA = "0xD2D630", Offset = "0xD2C030", VA = "0x180D2D630")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x170003A2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x134"), Cpp2IlInjected.Token(Token = "0x4000FD1")]
		public bool IsBuyable
		{
			[Cpp2IlInjected.Token(Token = "0x60014FF")]
			[Cpp2IlInjected.Address(RVA = "0xD2D5E0", Offset = "0xD2BFE0", VA = "0x180D2D5E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001500")]
			[Cpp2IlInjected.Address(RVA = "0xD2D620", Offset = "0xD2C020", VA = "0x180D2D620")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x6001501")]
		[Cpp2IlInjected.Address(RVA = "0xD2C8D0", Offset = "0xD2B2D0", VA = "0x180D2C8D0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0033
			BaseButton btnCreate = _btnCreate;
			if ((object)btnCreate != null)
			{
				Button.ButtonClickedEvent onClick = btnCreate.ButtonComponent.m_OnClick;
				UnityAction call = OnCreateDecalClicked;
				onClick.AddListener(call);
			}
			_isHighlighted = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6001502")]
		[Cpp2IlInjected.Address(RVA = "0xD2CA30", Offset = "0xD2B430", VA = "0x180D2CA30")]
		private void OnDestroy()
		{
			//IL_0034: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			BaseButton btnCreate = _btnCreate;
			if ((object)btnCreate != null)
			{
				Button.ButtonClickedEvent onClick = btnCreate.ButtonComponent.m_OnClick;
				UnityAction call = OnCreateDecalClicked;
				onClick.RemoveListener(call);
			}
			int num = 0;
			OnItemPurchased = (InventoryGridItemPurchased)num;
			OnDecalItemCreate = (DecalItemCreate)num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001503")]
		[Cpp2IlInjected.Address(RVA = "0xD2CA10", Offset = "0xD2B410", VA = "0x180D2CA10")]
		private void OnCreateDecalClicked()
		{
			DecalItemCreate onDecalItemCreate = OnDecalItemCreate;
			if (onDecalItemCreate != null)
			{
				IItemData itemData = ItemData;
				onDecalItemCreate(itemData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001504")]
		[Cpp2IlInjected.Address(RVA = "0xD2CCD0", Offset = "0xD2B6D0", VA = "0x180D2CCD0")]
		internal void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0203
			//IL_0058: Expected O, but got I4
			//IL_0108: Expected O, but got I4
			//IL_01ef: Expected O, but got I4
			int num = 0;
			UpdateBg();
			if (ItemData == null || (object)typeof(UnityEngine.Object).TypeHandle != null)
			{
				return;
			}
			if ((IsBuyable ? 1 : 0) == num && (IsOwned ? 1 : 0) == num)
			{
				GameObject gameObject = _mcPriceContent.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				StarComponent starComponent = mc_star;
				int num2 = 0;
				starComponent.Color = (Color)num2;
				_mcLocked.gameObject.SetActive(value: true);
				GameObject gameObject2 = _tfOwned.gameObject;
				int active2 = 0;
				gameObject2.SetActive((byte)active2 != 0);
				GameObject gameObject3 = _mcPrice.gameObject;
				int active3 = 0;
				gameObject3.SetActive((byte)active3 != 0);
			}
			StarComponent starComponent2 = mc_star;
			Color white = Color.white;
			GameObject gameObject4 = _mcLocked.gameObject;
			int active4 = 0;
			gameObject4.SetActive((byte)active4 != 0);
			IItemData itemData = ItemData;
			bool flag = default(bool);
			if (!flag)
			{
				GameObject gameObject5 = _mcPriceContent.gameObject;
				int active5 = 0;
				gameObject5.SetActive((byte)active5 != 0);
				GameObject gameObject6 = _mcPrice.gameObject;
				int active6 = 0;
				gameObject6.SetActive((byte)active6 != 0);
			}
			CurrencyCost currencyCost = Enumerable.FirstOrDefault<CurrencyCost>((IEnumerable<>)num);
			if ((IsOwned ? 1 : 0) != num && (HideOwned ? 1 : 0) == num)
			{
				GameObject gameObject7 = _mcPriceContent.gameObject;
				int active7 = 0;
				gameObject7.SetActive((byte)active7 != 0);
				GameObject gameObject8 = _tfOwned.gameObject;
			}
			_mcPriceContent.gameObject.SetActive(value: true);
			GameObject gameObject9 = _tfOwned.gameObject;
			int active8 = 0;
			gameObject9.SetActive((byte)active8 != 0);
			_mcPrice.gameObject.SetActive(value: true);
			CurrencyItemView mcPrice = _mcPrice;
			int amount_ = currencyCost.amount_;
			IItemData currencyItemData = default(IItemData);
			mcPrice.RefreshData(currencyItemData, amount_, forceLayoutUpdate: true);
			IItemData itemData2 = ItemData;
			if (itemData2 != null && itemData2 != null)
			{
				AsyncAtlassedIcon mcIcon = _mcIcon;
				if ((IsMale ? 1 : 0) == num)
				{
					goto IL_01c5;
				}
			}
			AsyncAtlassedIcon mcIcon2 = _mcIcon;
			goto IL_01c5;
			IL_01c5:
			StarComponent starComponent3 = mc_star;
			bool flag2 = default(bool);
			if (flag2)
			{
			}
			starComponent3.Star = (flag2 ? 1 : 0);
			TextBase textBase = Name;
			int num3 = 0;
			if (textBase != (UnityEngine.Object)num3)
			{
				IItemData itemData3 = ItemData;
				TextBase textBase2 = Name;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001505")]
		[Cpp2IlInjected.Address(RVA = "0xD2C9B0", Offset = "0xD2B3B0", VA = "0x180D2C9B0")]
		public void HideLocked()
		{
			//Discarded unreachable code: IL_0023
			GameObject gameObject = _mcLocked.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			StarComponent starComponent = mc_star;
			Color white = Color.white;
		}

		[Cpp2IlInjected.Token(Token = "0x6001506")]
		[Cpp2IlInjected.Address(RVA = "0xD2C980", Offset = "0xD2B380", VA = "0x180D2C980")]
		public void DeactivateItem()
		{
			//Discarded unreachable code: IL_0013
			IsDeactivated = true;
			OnDeactivateItem.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6001507")]
		[Cpp2IlInjected.Address(RVA = "0xD2CC90", Offset = "0xD2B690", VA = "0x180D2CC90")]
		public void ReactivateItem()
		{
			//Discarded unreachable code: IL_0019
			IsDeactivated = false;
			OnReactivateItem.Invoke();
			UpdateBg();
		}

		[Cpp2IlInjected.Token(Token = "0x6001508")]
		[Cpp2IlInjected.Address(RVA = "0xD2D440", Offset = "0xD2BE40", VA = "0x180D2D440")]
		public void SetCanvasGreyOut()
		{
			//Discarded unreachable code: IL_0016
			CanvasGroup canvasGroup = _canvasGroup;
			float num = (canvasGroup.alpha = _greyOutOpacity);
		}

		[Cpp2IlInjected.Token(Token = "0x6001509")]
		[Cpp2IlInjected.Address(RVA = "0xD2D470", Offset = "0xD2BE70", VA = "0x180D2D470")]
		public void SetCanvasVisible()
		{
			//Discarded unreachable code: IL_0011
			_canvasGroup.alpha = 1f;
		}

		[Cpp2IlInjected.Token(Token = "0x600150A")]
		[Cpp2IlInjected.Address(RVA = "0xD2C7F0", Offset = "0xD2B1F0", VA = "0x180D2C7F0", Slot = "6")]
		public override void AddHighlight()
		{
			//Discarded unreachable code: IL_0053
			//IL_001f: Expected O, but got I4
			base.AddHighlight();
			if (IsDeactivated)
			{
				RectTransform mcDeactivated = _mcDeactivated;
				int num = 0;
				if (mcDeactivated != (UnityEngine.Object)num)
				{
					GameObject gameObject = _mcDeactivated.gameObject;
				}
			}
			GameObject gameObject2 = _mcDeactivated.gameObject;
			int active = 0;
			gameObject2.SetActive((byte)active != 0);
			_isHighlighted = true;
			UpdateBg();
		}

		[Cpp2IlInjected.Token(Token = "0x600150B")]
		[Cpp2IlInjected.Address(RVA = "0xD2D3E0", Offset = "0xD2BDE0", VA = "0x180D2D3E0", Slot = "7")]
		public override void RemoveHighlight()
		{
			//Discarded unreachable code: IL_0029
			base.RemoveHighlight();
			GameObject gameObject = _mcDeactivated.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			_isHighlighted = false;
			UpdateBg();
		}

		[Cpp2IlInjected.Token(Token = "0x600150C")]
		[Cpp2IlInjected.Address(RVA = "0xD2D260", Offset = "0xD2BC60", VA = "0x180D2D260", Slot = "5")]
		public override void RefreshSelected()
		{
			base.RefreshSelected();
			UpdateBg();
		}

		[Cpp2IlInjected.Token(Token = "0x600150D")]
		[Cpp2IlInjected.Address(RVA = "0xD2CB00", Offset = "0xD2B500", VA = "0x180D2CB00")]
		public void OnItemInfoClicked()
		{
			//Discarded unreachable code: IL_004e
			//IL_0024: Expected O, but got I4
			//IL_004d: Expected I4, but got I8
			//IL_004d: Expected O, but got I4
			//IL_004d: Expected O, but got I4
			//IL_004d: Expected O, but got I4
			//IL_004d: Expected O, but got I4
			int num = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			IItemData itemData = ItemData;
			bool isRedirectedFromCatalog = UseFakeCatalog;
			int num2 = default(int);
			ItemInfoPopUp.ItemInfoPopupParam menuParam = new ItemInfoPopUp.ItemInfoPopupParam(itemData, (ItemState)num2, isRedirectedFromCatalog);
			int num3 = 0;
			num2 = 0;
			int num4 = 0;
			ulong num5 = default(ulong);
			redirection.Redirect(RedirectionType.MenuItemInfo, menuParam, (PlayerTaskCollider)num4, (ItemFilterData)num3, (string)num3, (Action)num3, (byte)num3 != 0, (byte)num3 != 0, (byte)num3 != 0, (byte)num5 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600150E")]
		[Cpp2IlInjected.Address(RVA = "0xD2CC00", Offset = "0xD2B600", VA = "0x180D2CC00")]
		public void PostWwiseEvent()
		{
			if (!IsBuyable && !IsOwned && _mcLocked.gameObject.activeSelf)
			{
				AK.Wwise.Event sfxLockedEvent = _sfxLockedEvent;
				GameObject gameObject = base.gameObject;
				uint num = sfxLockedEvent.Post(gameObject);
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600150F")]
		[Cpp2IlInjected.Address(RVA = "0xD2D280", Offset = "0xD2BC80", VA = "0x180D2D280")]
		public void RefreshSizeAmount()
		{
			//Discarded unreachable code: IL_002f
			//IL_0018: Expected O, but got I4
			Transform transform = AmountTextAsset.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)num);
			TextBase amountTextAsset = AmountTextAsset;
			RectTransform amountAsset = AmountAsset;
			Transform transform2 = amountTextAsset.transform;
		}

		[Cpp2IlInjected.Token(Token = "0x6001510")]
		[Cpp2IlInjected.Address(RVA = "0xD2D4A0", Offset = "0xD2BEA0", VA = "0x180D2D4A0")]
		private void UpdateBg()
		{
			//Discarded unreachable code: IL_009f
			GameObject whiteBg = _whiteBg;
			int num = 0;
			bool active = (_isHighlighted ? 1 : 0) == num;
			whiteBg.SetActive(active);
			GameObject whiteBgHover = _whiteBgHover;
			bool active2 = _isHighlighted;
			whiteBgHover.SetActive(active2);
			_whiteBgSelect.SetActive(active2);
			GameObject whiteBgHoverSelect = _whiteBgHoverSelect;
			bool active3 = _isHighlighted;
			whiteBgHoverSelect.SetActive(active3);
			GameObject selectedBg = SelectedBg;
			active3 = !_isHighlighted;
			selectedBg.SetActive(active3);
			GameObject selectedHighlightBg = SelectedHighlightBg;
			bool active4 = _isHighlighted;
			selectedHighlightBg.SetActive(active4);
		}

		[Cpp2IlInjected.Token(Token = "0x6001511")]
		[Cpp2IlInjected.Address(RVA = "0xD2D5C0", Offset = "0xD2BFC0", VA = "0x180D2D5C0")]
		public InventoryItem()
		{
		}
	}
}
