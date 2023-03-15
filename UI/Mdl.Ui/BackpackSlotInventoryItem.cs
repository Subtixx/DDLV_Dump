using System;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Newtonsoft.Json.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200034B")]
	public class BackpackSlotInventoryItem : BackpackInventoryItem, IPointerClickHandler, IEventSystemHandler, IDragHandler, IDropHandler, IPointerEnterHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x200034C")]
		public enum AssociatedMenuEnum
		{
			[Cpp2IlInjected.Token(Token = "0x4000FA2")]
			Backpack,
			[Cpp2IlInjected.Token(Token = "0x4000FA3")]
			Storage
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000F83")]
		public Action<bool> SelectItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000F84")]
		[SerializeField]
		private GameObject _questMarker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000F85")]
		[SerializeField]
		private GameObject _starHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000F86")]
		[SerializeField]
		private TextBase _starCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000F87")]
		[SerializeField]
		private GameObject _selectedHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000F88")]
		[SerializeField]
		private TextBase _selectedCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000F89")]
		[SerializeField]
		private GameObject _background;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000F8A")]
		[SerializeField]
		private GameObject _emptyBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000F8B")]
		[SerializeField]
		private GameObject _highlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000F8C")]
		[SerializeField]
		private GameObject _selectedOutline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000F8D")]
		[SerializeField]
		private GameObject _selectedOutlineHover;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000F8E")]
		[SerializeField]
		private GameObject _amountSelectorClicked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000F8F")]
		[SerializeField]
		private GameObject _lockedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000F90")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000F91")]
		public Action Drag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000F92")]
		public Action Drop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000F93")]
		public Action OnRightClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000F94")]
		public bool IsDragging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x149")]
		[Cpp2IlInjected.Token(Token = "0x4000F95")]
		public bool IsDisabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14A")]
		[Cpp2IlInjected.Token(Token = "0x4000F96")]
		public bool IsDraggingSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14B")]
		[Cpp2IlInjected.Token(Token = "0x4000F97")]
		public bool ShowDisabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000F99")]
		private int _stars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x4000F9A")]
		private bool _hover;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000F9C")]
		public AssociatedMenuEnum AssociatedMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000F9D")]
		[Header("Realm")]
		public AsyncAtlassedIcon RealmImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000F9E")]
		public GameObject RealmHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000F9F")]
		public GameObject RealmOutlineHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000FA0")]
		private bool _isRealmItem;

		[Cpp2IlInjected.Token(Token = "0x17000393")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14C"), Cpp2IlInjected.Token(Token = "0x4000F98")]
		public bool IsPressedByGamepad
		{
			[Cpp2IlInjected.Token(Token = "0x60014BF")]
			[Cpp2IlInjected.Address(RVA = "0xA5C3C0", Offset = "0xA5ADC0", VA = "0x180A5C3C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60014C0")]
			[Cpp2IlInjected.Address(RVA = "0xA5C400", Offset = "0xA5AE00", VA = "0x180A5C400")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000394")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60014C1")]
			[Cpp2IlInjected.Address(RVA = "0xA5C3B0", Offset = "0xA5ADB0", VA = "0x180A5C3B0")]
			get
			{
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000395")]
		public GameObject AmountSelectorClicked
		{
			[Cpp2IlInjected.Token(Token = "0x60014C2")]
			[Cpp2IlInjected.Address(RVA = "0xA5C390", Offset = "0xA5AD90", VA = "0x180A5C390")]
			get
			{
				return _amountSelectorClicked;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000396")]
		public int Stars
		{
			[Cpp2IlInjected.Token(Token = "0x60014C3")]
			[Cpp2IlInjected.Address(RVA = "0xA5C3E0", Offset = "0xA5ADE0", VA = "0x180A5C3E0")]
			get
			{
				return _stars;
			}
			[Cpp2IlInjected.Token(Token = "0x60014C4")]
			[Cpp2IlInjected.Address(RVA = "0xA5C320", Offset = "0xA5AD20", VA = "0x180A5C320")]
			set
			{
				//Discarded unreachable code: IL_0027
				GameObject starHolder = _starHolder;
				_stars = value;
				bool active = value > 0;
				starHolder.SetActive(active);
				string text = default(string);
				_starCount.Text = text;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000397")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x155"), Cpp2IlInjected.Token(Token = "0x4000F9B")]
		public bool HasQuestMarker
		{
			[Cpp2IlInjected.Token(Token = "0x60014C5")]
			[Cpp2IlInjected.Address(RVA = "0xA5C3A0", Offset = "0xA5ADA0", VA = "0x180A5C3A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60014C6")]
			[Cpp2IlInjected.Address(RVA = "0xA5C3F0", Offset = "0xA5ADF0", VA = "0x180A5C3F0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000398")]
		public bool IsRealmItem
		{
			[Cpp2IlInjected.Token(Token = "0x60014C7")]
			[Cpp2IlInjected.Address(RVA = "0xA5C3D0", Offset = "0xA5ADD0", VA = "0x180A5C3D0")]
			get
			{
				return _isRealmItem;
			}
			[Cpp2IlInjected.Token(Token = "0x60014C8")]
			[Cpp2IlInjected.Address(RVA = "0xA5C410", Offset = "0xA5AE10", VA = "0x180A5C410")]
			set
			{
				//Discarded unreachable code: IL_0029
				_isRealmItem = value;
				RealmHolder.SetActive(value);
				GameObject realmOutlineHolder = RealmOutlineHolder;
				bool isRealmItem = _isRealmItem;
				realmOutlineHolder.SetActive(isRealmItem);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014C9")]
		[Cpp2IlInjected.Address(RVA = "0xA5B7F0", Offset = "0xA5A1F0", VA = "0x180A5B7F0", Slot = "6")]
		public override void AddHighlight()
		{
			//Discarded unreachable code: IL_001d
			if (!IsDisabled)
			{
				base.AddHighlight();
				_highlight.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014CA")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE20", Offset = "0xA5A820", VA = "0x180A5BE20", Slot = "7")]
		public override void RemoveHighlight()
		{
			//Discarded unreachable code: IL_003c
			//IL_0019: Expected O, but got I4
			if (!IsDisabled)
			{
				BaseButton component = GetComponent<BaseButton>();
				int num = 0;
				if (!(component != (UnityEngine.Object)num) || !component.IgnoreHighlightExit)
				{
					base.RemoveHighlight();
					GameObject highlight = _highlight;
					int active = 0;
					highlight.SetActive((byte)active != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014CB")]
		[Cpp2IlInjected.Address(RVA = "0xA5B860", Offset = "0xA5A260", VA = "0x180A5B860")]
		public void OnClick()
		{
			//Discarded unreachable code: IL_0031
			if (!ShowDisabled)
			{
				BaseButton component = GetComponent<BaseButton>();
				if (component._isActive)
				{
					AK.Wwise.Event sfxEvent = component._sfxEvent;
					GameObject gameObject = component.gameObject;
					uint num = sfxEvent.Post(gameObject);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014CC")]
		[Cpp2IlInjected.Address(RVA = "0xA5BB10", Offset = "0xA5A510", VA = "0x180A5BB10")]
		public void OnSelectItem(bool selected)
		{
			//IL_0022: Expected O, but got I4
			if (!IsDisabled)
			{
				Action<bool> selectItem = SelectItem;
				_hover = selected;
				((Action<T>)(object)selectItem)?.Invoke((T)selected);
				Refresh();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014CD")]
		[Cpp2IlInjected.Address(RVA = "0xA5B830", Offset = "0xA5A230", VA = "0x180A5B830")]
		public void OnBeginDrag()
		{
			if (!IsDisabled && !ShowDisabled)
			{
				Drag?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014CE")]
		[Cpp2IlInjected.Address(RVA = "0xA5B920", Offset = "0xA5A320", VA = "0x180A5B920")]
		public bool OnDrop()
		{
			if (!IsDisabled && !ShowDisabled)
			{
				Drop?.Invoke();
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60014CF")]
		[Cpp2IlInjected.Address(RVA = "0xA5B990", Offset = "0xA5A390", VA = "0x180A5B990")]
		public void OnPointerClick(BaseEventData eventData)
		{
			if (!IsDisabled && eventData != null)
			{
				int num = 0;
				if (eventData != null)
				{
					OnRightClick?.Invoke();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5C320", Offset = "0xA5AD20", VA = "0x180A5C320", Slot = "10")]
		public override void SetStarCount(int count)
		{
			//Discarded unreachable code: IL_0027
			GameObject starHolder = _starHolder;
			_stars = count;
			bool active = count > 0;
			starHolder.SetActive(active);
			string text = default(string);
			_starCount.Text = text;
		}

		[Cpp2IlInjected.Token(Token = "0x60014D1")]
		[Cpp2IlInjected.Address(RVA = "0xA5C240", Offset = "0xA5AC40", VA = "0x180A5C240")]
		public void SetStarCount(IItemData itemData, ItemState state)
		{
			if ((object)typeof(MealItemData).TypeHandle == null)
			{
				if (itemData != null && itemData != null)
				{
					object underlyingCollection = ((Newtonsoft.Json.Utilities.IWrappedCollection)this).UnderlyingCollection;
				}
				else
				{
					object underlyingCollection2 = ((Newtonsoft.Json.Utilities.IWrappedCollection)this).UnderlyingCollection;
				}
			}
			else
			{
				object underlyingCollection3 = ((Newtonsoft.Json.Utilities.IWrappedCollection)this).UnderlyingCollection;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014D2")]
		[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AB30", VA = "0x180A5C130")]
		public void SetSelectedCount(int selectedCount)
		{
			//Discarded unreachable code: IL_0020
			GameObject selectedHolder = _selectedHolder;
			bool active = selectedCount > 0;
			selectedHolder.SetActive(active);
			string text = default(string);
			_selectedCount.Text = text;
		}

		[Cpp2IlInjected.Token(Token = "0x60014D3")]
		[Cpp2IlInjected.Address(RVA = "0xA5BB90", Offset = "0xA5A590", VA = "0x180A5BB90", Slot = "9")]
		internal override void Refresh()
		{
			//Discarded unreachable code: IL_0167
			//IL_010d: Expected O, but got I4
			bool active2 = default(bool);
			bool active3 = default(bool);
			bool active4 = default(bool);
			GameObject selectedOutline;
			while (true)
			{
				base.Refresh();
				GameObject questMarker = _questMarker;
				IsDisabled = false;
				bool active = HasQuestMarker;
				questMarker.SetActive(active);
				_background.SetActive(active2);
				_emptyBackground.SetActive(active3);
				base.mc_icon.gameObject.SetActive(active4);
				CanvasGroup canvasGroup = _canvasGroup;
				if (IsDraggingSelf || !ShowDisabled)
				{
				}
				canvasGroup.alpha = 0.5f;
				GameObject highlight = _highlight;
				int num = 0;
				if ((_hover ? 1 : 0) == num)
				{
					continue;
				}
				bool active5 = IsDragging;
				highlight.SetActive(active5);
				GameObject selectedOutlineHover = _selectedOutlineHover;
				if ((_hover ? 1 : 0) != num)
				{
					bool active6 = ShowSelected;
					selectedOutlineHover.SetActive(active6);
					selectedOutline = _selectedOutline;
					if ((_hover ? 1 : 0) == num)
					{
						break;
					}
				}
			}
			bool active7 = ShowSelected;
			selectedOutline.SetActive(active7);
			GameObject selectedHighlightBg = SelectedHighlightBg;
			int num2 = 0;
			if (selectedHighlightBg != (UnityEngine.Object)num2)
			{
				GameObject selectedHighlightBg2 = SelectedHighlightBg;
				bool isSelected = _isSelected;
				selectedHighlightBg2.SetActive(isSelected);
			}
			GameObject lockedBg = _lockedBg;
			int active8 = 0;
			lockedBg.SetActive((byte)active8 != 0);
			GetComponent<BaseButton>().UseHighlightOnMouseHover = true;
			GetComponent<BaseButton>().ButtonComponent.interactable = true;
			GetComponent<FocusNavigationBackpackSlotElement>().IgnoreThis = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60014D4")]
		[Cpp2IlInjected.Address(RVA = "0xA5BEE0", Offset = "0xA5A8E0", VA = "0x180A5BEE0")]
		public void SetDeactivated()
		{
			//Discarded unreachable code: IL_0137
			GameObject realmHolder = RealmHolder;
			_isRealmItem = false;
			int active = 0;
			realmHolder.SetActive((byte)active != 0);
			GameObject realmOutlineHolder = RealmOutlineHolder;
			bool isRealmItem = _isRealmItem;
			realmOutlineHolder.SetActive(isRealmItem);
			RectTransform mcInventoryCounterContent = _mcInventoryCounterContent;
			IsDisabled = true;
			GameObject gameObject = mcInventoryCounterContent.gameObject;
			int active2 = 0;
			gameObject.SetActive((byte)active2 != 0);
			_lockedBg.SetActive(value: true);
			GameObject selectedOutline = _selectedOutline;
			int active3 = 0;
			selectedOutline.SetActive((byte)active3 != 0);
			GameObject selectedOutlineHover = _selectedOutlineHover;
			int active4 = 0;
			selectedOutlineHover.SetActive((byte)active4 != 0);
			GameObject questMarker = _questMarker;
			int active5 = 0;
			questMarker.SetActive((byte)active5 != 0);
			GameObject gameObject2 = base.mc_icon.gameObject;
			int active6 = 0;
			gameObject2.SetActive((byte)active6 != 0);
			GameObject emptyBackground = _emptyBackground;
			int active7 = 0;
			emptyBackground.SetActive((byte)active7 != 0);
			GameObject background = _background;
			int active8 = 0;
			background.SetActive((byte)active8 != 0);
			int starCount = 0;
			SetStarCount(starCount);
			GameObject selectedHolder = _selectedHolder;
			int active9 = 0;
			selectedHolder.SetActive((byte)active9 != 0);
			string text = default(string);
			_selectedCount.Text = text;
			GetComponent<BaseButton>().UseHighlightOnMouseHover = false;
			Button buttonComponent = GetComponent<BaseButton>().ButtonComponent;
			int num = ((buttonComponent.interactable = false) ? 1 : 0);
			GetComponent<FocusNavigationBackpackSlotElement>().IgnoreThis = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60014D5")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8E0", Offset = "0xA5A2E0", VA = "0x180A5B8E0", Slot = "12")]
		public void OnDrag(PointerEventData eventData)
		{
			if (eventData != null && eventData.button == PointerEventData.InputButton.Left && !IsDisabled && !ShowDisabled)
			{
				Drag?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014D6")]
		[Cpp2IlInjected.Address(RVA = "0xA5B990", Offset = "0xA5A390", VA = "0x180A5B990", Slot = "11")]
		public void OnPointerClick(PointerEventData eventData)
		{
			if (!IsDisabled && eventData != null)
			{
				int num = 0;
				if (eventData != null && eventData.button == PointerEventData.InputButton.Right)
				{
					OnRightClick?.Invoke();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014D7")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA30", Offset = "0xA5A430", VA = "0x180A5BA30", Slot = "14")]
		public void OnPointerEnter(PointerEventData eventData)
		{
			//IL_0022: Expected O, but got I4
			if (!IsDisabled)
			{
				Action<bool> selectItem = SelectItem;
				_hover = true;
				((Action<T>)(object)selectItem)?.Invoke((T)1);
				object underlyingCollection = ((Newtonsoft.Json.Utilities.IWrappedCollection)this).UnderlyingCollection;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014D8")]
		[Cpp2IlInjected.Address(RVA = "0xA5BAA0", Offset = "0xA5A4A0", VA = "0x180A5BAA0", Slot = "15")]
		public void OnPointerExit(PointerEventData eventData)
		{
			//IL_0024: Expected O, but got I4
			if (!IsDisabled)
			{
				Action<bool> selectItem = SelectItem;
				_hover = false;
				if (selectItem != null)
				{
					int num = 0;
					selectItem((T)num);
				}
				object underlyingCollection = ((Newtonsoft.Json.Utilities.IWrappedCollection)this).UnderlyingCollection;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014D9")]
		[Cpp2IlInjected.Address(RVA = "0xA5B960", Offset = "0xA5A360", VA = "0x180A5B960", Slot = "13")]
		public void OnDrop(PointerEventData eventData)
		{
			if (!IsDisabled && !ShowDisabled)
			{
				Drop?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014DA")]
		[Cpp2IlInjected.Address(RVA = "0xA5C190", Offset = "0xA5AB90", VA = "0x180A5C190")]
		public void SetSelectedOutline(bool value)
		{
			//Discarded unreachable code: IL_002d
			//IL_0010: Expected O, but got I4
			GameObject selectedHighlightBg = SelectedHighlightBg;
			int num = 0;
			if (selectedHighlightBg != (UnityEngine.Object)num)
			{
				SelectedHighlightBg.SetActive(value);
				_isSelected = value;
				RefreshSelected();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014DB")]
		[Cpp2IlInjected.Address(RVA = "0xA5AC90", Offset = "0xA59690", VA = "0x180A5AC90")]
		public BackpackSlotInventoryItem()
		{
			base._inventoryCountSize = 80f;
			base._inventoryCountPadding = 50f;
			ShowSelected = true;
			((MonoBehaviour)this)._002Ector();
		}
	}
}
