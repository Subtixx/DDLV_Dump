using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	public class TemplateButton : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IHasSFX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private bool _interactable = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		private bool _isActivated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private bool _isPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		private bool _isHighlighted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		private bool _isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		[Space]
		public AK.Wwise.Event[] SFXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		[Space]
		public UnityEvent OnHighlighted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public UnityEvent OnDehighlighted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public UnityEvent OnSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public UnityEvent OnDeselected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public UnityEvent OnPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public UnityEvent OnReleased;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public UnityEvent OnActivated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public UnityEvent OnDeactivated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		public UnityEvent OnClicked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public UnityEvent OnRightClicked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public UnityEvent OnPointerEntered;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public UnityEvent OnPointerExited;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public UnityEvent OnEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		public UnityEvent OnDisabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		public UnityEvent OnDispose;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public bool Frozen;

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		public bool IsInteractable
		{
			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return _interactable;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A17")]
			[Cpp2IlInjected.Address(RVA = "0x17E8560", Offset = "0x17E6F60", VA = "0x1817E8560")]
			set
			{
				//Discarded unreachable code: IL_0029
				//IL_0017: Expected O, but got I4
				_interactable = value;
				CanvasGroup component = GetComponent<CanvasGroup>();
				int num = 0;
				if (component != (Object)num)
				{
					bool flag = (component.blocksRaycasts = _interactable);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		public bool IsActivated
		{
			[Cpp2IlInjected.Token(Token = "0x6000A18")]
			[Cpp2IlInjected.Address(RVA = "0x63C0C0", Offset = "0x63AAC0", VA = "0x18063C0C0")]
			get
			{
				return _isActivated;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A19")]
			[Cpp2IlInjected.Address(RVA = "0x17E84E0", Offset = "0x17E6EE0", VA = "0x1817E84E0")]
			set
			{
				if (_isActivated != value)
				{
					_isActivated = value;
					if (!value)
					{
					}
					OnActivated?.Invoke();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		public bool IsPressed
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1A")]
			[Cpp2IlInjected.Address(RVA = "0x63C0B0", Offset = "0x63AAB0", VA = "0x18063C0B0")]
			get
			{
				return _isPressed;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A1B")]
			[Cpp2IlInjected.Address(RVA = "0x17E8610", Offset = "0x17E7010", VA = "0x1817E8610")]
			set
			{
				if (_isPressed != value)
				{
					_isPressed = value;
					if (!value)
					{
					}
					OnPressed?.Invoke();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public bool IsHighlighted
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1C")]
			[Cpp2IlInjected.Address(RVA = "0x63C0A0", Offset = "0x63AAA0", VA = "0x18063C0A0")]
			get
			{
				return _isHighlighted;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A1D")]
			[Cpp2IlInjected.Address(RVA = "0x17E8510", Offset = "0x17E6F10", VA = "0x1817E8510")]
			set
			{
				if ((!_isSelected || !IgnoreHighlightWhenSelected) && (_isActivated || !IgnoreHighlightWhenNotActivated) && (_isHighlighted != value || Frozen))
				{
					_isHighlighted = value;
					if (!value)
					{
					}
					OnHighlighted?.Invoke();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1E")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return _isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A1F")]
			[Cpp2IlInjected.Address(RVA = "0x17E8640", Offset = "0x17E7040", VA = "0x1817E8640")]
			set
			{
				if (_isSelected == value || (!_isActivated && IgnoreHighlightWhenNotActivated))
				{
					return;
				}
				_isSelected = value;
				if (!value)
				{
				}
				if (!_isHighlighted)
				{
					if (!UseHighlightWhenSelected)
					{
						goto IL_0063;
					}
					_isHighlighted = true;
				}
				if (IgnoreHighlightWhenSelected)
				{
					_isHighlighted = false;
					OnDehighlighted?.Invoke();
				}
				goto IL_0063;
				IL_0063:
				OnSelected?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1D"), Cpp2IlInjected.Token(Token = "0x40006DD")]
		public bool IsMuted
		{
			[Cpp2IlInjected.Token(Token = "0x6000A20")]
			[Cpp2IlInjected.Address(RVA = "0x63C0F0", Offset = "0x63AAF0", VA = "0x18063C0F0", Slot = "9")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000A21")]
			[Cpp2IlInjected.Address(RVA = "0x63C2C0", Offset = "0x63ACC0", VA = "0x18063C2C0", Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1E"), Cpp2IlInjected.Token(Token = "0x40006DE")]
		public bool IgnoreHighlightWhenSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6000A22")]
			[Cpp2IlInjected.Address(RVA = "0x17E84B0", Offset = "0x17E6EB0", VA = "0x1817E84B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000A23")]
			[Cpp2IlInjected.Address(RVA = "0x17E84D0", Offset = "0x17E6ED0", VA = "0x1817E84D0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1F"), Cpp2IlInjected.Token(Token = "0x40006DF")]
		public bool IgnoreHighlightWhenNotActivated
		{
			[Cpp2IlInjected.Token(Token = "0x6000A24")]
			[Cpp2IlInjected.Address(RVA = "0x17E84A0", Offset = "0x17E6EA0", VA = "0x1817E84A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000A25")]
			[Cpp2IlInjected.Address(RVA = "0x17E84C0", Offset = "0x17E6EC0", VA = "0x1817E84C0")]
			set;
		} = true;


		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x40006E0")]
		public bool UseHighlightWhenSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6000A26")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000A27")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		public FocusNavigation FocusNavigation
		{
			[Cpp2IlInjected.Token(Token = "0x6000A28")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CFocusNavigation_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A29")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CFocusNavigation_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		public FocusNavigationElement FocusNavigationElement
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CFocusNavigationElement_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CFocusNavigationElement_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0x17E83E0", Offset = "0x17E6DE0", VA = "0x1817E83E0")]
		private void Start()
		{
			//IL_0010: Expected O, but got I4
			FocusNavigationElement focusNavigationElement = FocusNavigationElement;
			int num = 0;
			if (focusNavigationElement == (Object)num)
			{
				FocusNavigationElement focusNavigationElement2 = (FocusNavigationElement = GetComponent<FocusNavigationElement>());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x17E7CB0", Offset = "0x17E66B0", VA = "0x1817E7CB0", Slot = "12")]
		protected virtual void OnEnable()
		{
			OnEnabled?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x17E7C90", Offset = "0x17E6690", VA = "0x1817E7C90", Slot = "13")]
		protected virtual void OnDisable()
		{
			OnDisabled?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x17E7D90", Offset = "0x17E6790", VA = "0x1817E7D90", Slot = "7")]
		public void OnPointerEnter(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_00e7
			//IL_0091: Expected O, but got I4
			//IL_00a8: Expected O, but got I4
			if (!_interactable)
			{
				return;
			}
			int num = 0;
			if (!CursorWrapper.Visible)
			{
				return;
			}
			OnPointerEntered?.Invoke();
			if ((!_isSelected || !IgnoreHighlightWhenSelected) && (_isActivated || !IgnoreHighlightWhenNotActivated) && (!_isHighlighted || Frozen))
			{
				UnityEvent onHighlighted = OnHighlighted;
				_isHighlighted = true;
				onHighlighted?.Invoke();
			}
			FocusNavigation focusNavigation = FocusNavigation;
			Frozen = false;
			int num2 = 0;
			if (!(focusNavigation != (Object)num2))
			{
				return;
			}
			FocusNavigationElement focusNavigationElement = FocusNavigationElement;
			int num3 = 0;
			if (focusNavigationElement != (Object)num3 && _isHighlighted)
			{
				if (FocusNavigation._focusedElement == null)
				{
					int num4 = 0;
				}
				int num5 = 0;
				bool flag = default(bool);
				if (flag)
				{
					FocusNavigation focusNavigation2 = FocusNavigation;
					FocusNavigationElement focus = FocusNavigationElement;
					focusNavigation2.SetFocus(focus);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x17E7F60", Offset = "0x17E6960", VA = "0x1817E7F60", Slot = "8")]
		public void OnPointerExit(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_00e7
			//IL_0096: Expected O, but got I4
			//IL_00ad: Expected O, but got I4
			//IL_00e6: Expected O, but got I4
			if (!_interactable)
			{
				return;
			}
			int num = 0;
			if (!CursorWrapper.Visible || Frozen)
			{
				return;
			}
			OnPointerExited?.Invoke();
			if ((!_isSelected || !IgnoreHighlightWhenSelected) && (_isActivated || !IgnoreHighlightWhenNotActivated) && (_isHighlighted || Frozen))
			{
				_isHighlighted = false;
				OnDehighlighted?.Invoke();
			}
			FocusNavigation focusNavigation = FocusNavigation;
			int num2 = 0;
			if (!(focusNavigation != (Object)num2))
			{
				return;
			}
			FocusNavigationElement focusNavigationElement = FocusNavigationElement;
			int num3 = 0;
			if (focusNavigationElement != (Object)num3 && !_isHighlighted)
			{
				if (FocusNavigation._focusedElement == null)
				{
					int num4 = 0;
				}
				int num5 = 0;
				bool flag = default(bool);
				if (flag)
				{
					FocusNavigation focusNavigation2 = FocusNavigation;
					int num6 = 0;
					focusNavigation2.SetFocus((FocusNavigationElement)num6);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0x17E7D50", Offset = "0x17E6750", VA = "0x1817E7D50", Slot = "5")]
		public void OnPointerDown(PointerEventData eventData)
		{
			if (_interactable)
			{
				int num = 0;
				if (CursorWrapper.Clickable && !_isPressed)
				{
					UnityEvent onPressed = OnPressed;
					_isPressed = true;
					onPressed?.Invoke();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x17E8140", Offset = "0x17E6B40", VA = "0x1817E8140", Slot = "6")]
		public void OnPointerUp(PointerEventData eventData)
		{
			if (_interactable)
			{
				int num = 0;
				if (CursorWrapper.Clickable && _isPressed)
				{
					_isPressed = false;
					OnReleased?.Invoke();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0x17E7CD0", Offset = "0x17E66D0", VA = "0x1817E7CD0", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_003d
			if (!_interactable)
			{
				return;
			}
			int num = 0;
			if (UiRoot.Instance.IsCursorSupported())
			{
				int num2 = 0;
				if (!CursorWrapper.Clickable)
				{
					return;
				}
			}
			if (eventData.button != PointerEventData.InputButton.Right)
			{
			}
			OnRightClicked?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0x17E8250", Offset = "0x17E6C50", VA = "0x1817E8250", Slot = "14")]
		public virtual void PostSfx(int index)
		{
			//Discarded unreachable code: IL_0045
			if (!IsMuted)
			{
				AK.Wwise.Event[] sFXS = SFXS;
				if (sFXS.Length > index && sFXS[index].IsValid())
				{
					AK.Wwise.Event @event = SFXS[index];
					GameObject gameObject = base.gameObject;
					uint num = @event.Post(gameObject);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0x17E8180", Offset = "0x17E6B80", VA = "0x1817E8180", Slot = "15")]
		public virtual void PostSfxSafely(int index)
		{
			//Discarded unreachable code: IL_0053
			if (!IsMuted && base.gameObject.activeInHierarchy)
			{
				AK.Wwise.Event[] sFXS = SFXS;
				if (sFXS.Length > index && sFXS[index].IsValid())
				{
					AK.Wwise.Event @event = SFXS[index];
					GameObject gameObject = base.gameObject;
					uint num = @event.Post(gameObject);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x17E8300", Offset = "0x17E6D00", VA = "0x1817E8300", Slot = "16")]
		internal virtual void Release()
		{
			UseHighlightWhenSelected = false;
			IgnoreHighlightWhenSelected = false;
			if (!_isActivated)
			{
				_isActivated = true;
				OnActivated?.Invoke();
			}
			IsInteractable = true;
			if (_isPressed)
			{
				_isPressed = false;
				OnReleased?.Invoke();
			}
			if ((!_isSelected || !IgnoreHighlightWhenSelected) && (_isActivated || !IgnoreHighlightWhenNotActivated) && (_isHighlighted || Frozen))
			{
				_isHighlighted = false;
				OnDehighlighted?.Invoke();
			}
			if (_isSelected && (_isActivated || !IgnoreHighlightWhenNotActivated))
			{
				_isSelected = false;
				OnDeselected?.Invoke();
			}
			OnDispose?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A37")]
		[Cpp2IlInjected.Address(RVA = "0x17E8480", Offset = "0x17E6E80", VA = "0x1817E8480")]
		public TemplateButton()
		{
		}
	}
}
