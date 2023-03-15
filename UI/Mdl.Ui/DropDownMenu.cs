using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200069A")]
	[RequireComponent(typeof(Image))]
	[RequireComponent(typeof(FocusNavigationElementDropDown))]
	[RequireComponent(typeof(TMP_Dropdown))]
	public class DropDownMenu : CustomButton
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200069B")]
		public class State
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002509")]
			public Sprite BackgroundSprite;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400250A")]
			public Color LabelColor;

			[Cpp2IlInjected.Token(Token = "0x6002A96")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public State()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40024F9")]
		[SerializeField]
		private RectTransform _arrowDropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40024FA")]
		[SerializeField]
		private GameObject _bgDecoration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40024FB")]
		[SerializeField]
		private State NormalState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40024FC")]
		[SerializeField]
		private State SelectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40024FD")]
		[SerializeField]
		private State HighlightState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40024FE")]
		[SerializeField]
		private State SelectedHighlightState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40024FF")]
		[SerializeField]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4002500")]
		private TMP_Dropdown _dropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002501")]
		private Image _image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4002502")]
		private FocusNavigationElementDropDown _focusNavigationElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4002503")]
		private GameObject _dropDownList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4002504")]
		private ScrollRect _scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4002505")]
		private Scrollbar _scrollbar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4002506")]
		private bool _isOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4002507")]
		private bool _justOpenedDropDown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x162")]
		[Cpp2IlInjected.Token(Token = "0x4002508")]
		private bool _justClosedDropDown;

		[Cpp2IlInjected.Token(Token = "0x1700063C")]
		public bool IsOpened
		{
			[Cpp2IlInjected.Token(Token = "0x6002A8C")]
			[Cpp2IlInjected.Address(RVA = "0x9D1830", Offset = "0x9D0230", VA = "0x1809D1830")]
			get
			{
				return _isOpen;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A8D")]
		[Cpp2IlInjected.Address(RVA = "0xF21000", Offset = "0xF1FA00", VA = "0x180F21000")]
		protected void Awake()
		{
			TMP_Dropdown tMP_Dropdown = (_dropdown = GetComponent<TMP_Dropdown>());
			Image image = (_image = GetComponent<Image>());
			FocusNavigationElementDropDown focusNavigationElementDropDown = (_focusNavigationElement = GetComponent<FocusNavigationElementDropDown>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A8E")]
		[Cpp2IlInjected.Address(RVA = "0xF21230", Offset = "0xF1FC30", VA = "0x180F21230", Slot = "12")]
		protected override void OnEnable()
		{
			//Discarded unreachable code: IL_007b
			base.OnEnable();
			UnityEvent onHighlighted = OnHighlighted;
			UnityAction call = UpdateVisuals;
			onHighlighted.AddListener(call);
			UnityEvent onDehighlighted = OnDehighlighted;
			UnityAction call2 = UpdateVisuals;
			onDehighlighted.AddListener(call2);
			UnityEvent onPressed = OnPressed;
			UnityAction call3 = UpdateVisuals;
			onPressed.AddListener(call3);
			UnityEvent onReleased = OnReleased;
			UnityAction call4 = UpdateVisuals;
			onReleased.AddListener(call4);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A8F")]
		[Cpp2IlInjected.Address(RVA = "0xF210E0", Offset = "0xF1FAE0", VA = "0x180F210E0", Slot = "13")]
		protected override void OnDisable()
		{
			//Discarded unreachable code: IL_007b
			UnityEvent onHighlighted = OnHighlighted;
			UnityAction call = UpdateVisuals;
			onHighlighted.RemoveListener(call);
			UnityEvent onDehighlighted = OnDehighlighted;
			UnityAction call2 = UpdateVisuals;
			onDehighlighted.RemoveListener(call2);
			UnityEvent onPressed = OnPressed;
			UnityAction call3 = UpdateVisuals;
			onPressed.RemoveListener(call3);
			UnityEvent onReleased = OnReleased;
			UnityAction call4 = UpdateVisuals;
			onReleased.RemoveListener(call4);
			base.OnDisable();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A90")]
		[Cpp2IlInjected.Address(RVA = "0xF21750", Offset = "0xF20150", VA = "0x180F21750")]
		private void Update()
		{
			//Discarded unreachable code: IL_0274
			//IL_0029: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_00ea: Expected O, but got I4
			//IL_0124: Expected O, but got I4
			//IL_0175: Expected O, but got I4
			//IL_018a: Expected O, but got I4
			//IL_01d5: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				Transform transform = base.transform.Find("Dropdown List");
				if ((object)transform != null)
				{
					GameObject gameObject = transform.gameObject;
				}
				_dropDownList = (GameObject)num;
			}
			TMP_Dropdown dropdown = _dropdown;
			int num2 = 0;
			int num3 = 0;
			bool flag2 = (UnityEngine.Object)num2 != (UnityEngine.Object)num3;
			int num4 = 0;
			UiRoot instance = UiRoot.Instance;
			if ((object)instance != null)
			{
				int useKeyboardAsController = 0;
				bool flag3 = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			}
			int num5 = 0;
			if (!flag2)
			{
			}
			bool flag4 = (_justOpenedDropDown = _isOpen != flag2);
			if (flag2)
			{
			}
			bool flag5 = (_justClosedDropDown = (_isOpen ? 1 : 0) != num);
			_isOpen = flag2;
			if (flag4)
			{
				goto IL_0143;
			}
			if (flag5)
			{
				goto IL_0108;
			}
			DropDownMenuItem dropDownMenuItem = default(DropDownMenuItem);
			if (num5 != 0)
			{
				FocusNavigation focusNavigation = _focusNavigation;
				if ((object)focusNavigation != null && focusNavigation._focusedElement != null)
				{
					int num6 = 0;
					bool flag6 = default(bool);
					if (flag6)
					{
						int num7 = 0;
						if (dropDownMenuItem != (UnityEngine.Object)num7)
						{
							int index = dropDownMenuItem.transform.GetSiblingIndex() - 1;
							ScrollTo(index);
							goto IL_0108;
						}
					}
				}
			}
			goto IL_026d;
			IL_0143:
			ScrollRect scrollRect = default(ScrollRect);
			_scrollRect = scrollRect;
			Scrollbar scrollbar = (_scrollbar = _scrollRect.m_VerticalScrollbar);
			if ((object)_scrollRect != null)
			{
			}
			int num8 = 0;
			FocusNavigation focusNavigation2 = default(FocusNavigation);
			int num9 = default(int);
			if (focusNavigation2 != (UnityEngine.Object)num8 && (long)(IntPtr)focusNavigation2 < (long)num9)
			{
				int num10 = 0;
				Transform transform2 = default(Transform);
				uint num11 = default(uint);
				if (transform2 != (UnityEngine.Object)num10 && Enumerable.Contains<char>((IEnumerable<>)(object)transform2.name, (char)num11))
				{
					uint oldChar = default(uint);
					uint newChar = default(uint);
					string text2 = (transform2.name = transform2.name.Replace((char)oldChar, (char)newChar));
				}
			}
			if (num5 != 0)
			{
				FocusNavigation focusNavigation3 = _focusNavigation;
				int num12 = 0;
				if (focusNavigation3 != (UnityEngine.Object)num12)
				{
					List<TMP_Dropdown.OptionData> options = (List<TMP_Dropdown.OptionData>)(object)_dropdown.get_options();
					int num13 = 0;
					Func<Toggle, bool> func = default(Func<Toggle, bool>);
					if (_003C_003Ec._003C_003E9__22_1 == null)
					{
						func = (Func<Toggle, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Toggle t) => t.m_IsOn));
					}
					Toggle[] array = default(Toggle[]);
					Toggle toggle = default(Toggle);
					if ((object)Enumerable.First<Toggle>((IEnumerable<>)(object)array, (Func<, >)(object)func) == null)
					{
						toggle = array[0];
					}
					FocusNavigation focusNavigation4 = _focusNavigation;
					FocusNavigationElement component = toggle.GetComponent<FocusNavigationElement>();
					focusNavigation4.SetFocus(component);
				}
			}
			int value = _dropdown.m_Value;
			int _003C_003E1__state = default(int);
			_003C_003CUpdate_003Eg__ScrollToLater_007C22_0_003Ed _003C_003CUpdate_003Eg__ScrollToLater_007C22_0_003Ed = new _003C_003CUpdate_003Eg__ScrollToLater_007C22_0_003Ed(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003C_003CUpdate_003Eg__ScrollToLater_007C22_0_003Ed._003C_003E4__this = this;
			_003C_003CUpdate_003Eg__ScrollToLater_007C22_0_003Ed.idx = value;
			Coroutine coroutine = StartCoroutine(_003C_003CUpdate_003Eg__ScrollToLater_007C22_0_003Ed);
			goto IL_026d;
			IL_0108:
			_scrollbar = (Scrollbar)(object)dropDownMenuItem;
			focusNavigation2 = _focusNavigation;
			int num14 = 0;
			if (focusNavigation2 != (UnityEngine.Object)num14)
			{
				FocusNavigation focusNavigation5 = _focusNavigation;
				FocusNavigationElementDropDown focusNavigationElement = _focusNavigationElement;
				focusNavigation5.SetFocus(focusNavigationElement);
				goto IL_0143;
			}
			goto IL_026d;
			IL_026d:
			UpdateVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A91")]
		[Cpp2IlInjected.Address(RVA = "0xF210B0", Offset = "0xF1FAB0", VA = "0x180F210B0")]
		public void CloseDropDown()
		{
			//Discarded unreachable code: IL_000c
			_dropdown.Hide();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A92")]
		[Cpp2IlInjected.Address(RVA = "0xF215A0", Offset = "0xF1FFA0", VA = "0x180F215A0")]
		public void UpdateVisuals()
		{
			//Discarded unreachable code: IL_00a3
			//IL_002f: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			//IL_008f: Expected O, but got I4
			bool isHighlighted = ((TemplateButton)this)._isHighlighted;
			if (isHighlighted)
			{
			}
			if (_isOpen || !isHighlighted)
			{
			}
			State selectedHighlightState = SelectedHighlightState;
			Image image = _image;
			int num = 0;
			if (image != (UnityEngine.Object)num)
			{
				Image image2 = _image;
				Sprite sprite = (image2.sprite = selectedHighlightState.BackgroundSprite);
			}
			GameObject bgDecoration = _bgDecoration;
			int num2 = 0;
			if (bgDecoration != (UnityEngine.Object)num2)
			{
				GameObject bgDecoration2 = _bgDecoration;
				bool isOpen = _isOpen;
				bgDecoration2.SetActive(isOpen);
			}
			RectTransform arrowDropdown = _arrowDropdown;
			int num3 = 0;
			if (arrowDropdown != (UnityEngine.Object)num3)
			{
				RectTransform arrowDropdown2 = _arrowDropdown;
				bool isOpen2 = _isOpen;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A93")]
		[Cpp2IlInjected.Address(RVA = "0xF21380", Offset = "0xF1FD80", VA = "0x180F21380")]
		private void ScrollTo(int index)
		{
			//Discarded unreachable code: IL_006f
			//IL_0021: Expected O, but got I4
			//IL_0063: Expected F4, but got I4
			int size = _dropdown.get_options()._size;
			Scrollbar scrollbar = _scrollbar;
			int num = 0;
			if (scrollbar != (UnityEngine.Object)num)
			{
				float size2 = _scrollbar.m_Size;
				if (size > 0)
				{
					float verticalNormalizedPosition = _scrollRect.verticalNormalizedPosition;
					int num2 = 0;
					int num3 = 0;
					ScrollRect scrollRect = _scrollRect;
					int num4 = 0;
					float num6 = (scrollRect.verticalNormalizedPosition = Mathf.Clamp(1f, num4, 1f));
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A94")]
		[Cpp2IlInjected.Address(RVA = "0x863470", Offset = "0x861E70", VA = "0x180863470")]
		public DropDownMenu()
		{
		}
	}
}
