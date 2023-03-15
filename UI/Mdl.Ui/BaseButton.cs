using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AK.Wwise;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Mdl.InputSystem;
using Mdl.Platform;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.U2D;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	public class BaseButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler, IPointerClickHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000189")]
		public delegate void OnBaseButtonPress(BaseButton button);

		[Cpp2IlInjected.Token(Token = "0x200018A")]
		public delegate void OnBaseButtonRelease(BaseButton button);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		[SerializeField]
		private Vector3 _scaleOnMouseOver1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		[SerializeField]
		private Vector3 _scaleOnMouseOver2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		[SerializeField]
		private Vector3 _scaleOnMouseOut1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		[SerializeField]
		private Vector3 _scaleOnMouseOut2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		[SerializeField]
		private Vector3 _scaleOnMouseUp1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		[SerializeField]
		private Vector3 _scaleOnMouseUp2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		[SerializeField]
		private Vector3 _scaleOnMouseDown1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		[SerializeField]
		private Vector3 _scaleOnMouseDown2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		[SerializeField]
		private Vector3 _scaleDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public float HighlightSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public float animationInDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public float animationOutDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public float shootout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public Vector3 ScaleMouseEnter;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		[SerializeField]
		[Space]
		private Selectable _selectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private Button _button;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private Toggle _toggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public UnityEvent OnPointerEntered;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public UnityEvent OnPointerExited;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public UnityEvent OnHighlightAdded;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public UnityEvent OnHighlightRemoved;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		[FormerlySerializedAs("OnMouseLeftButtonPressed")]
		public UnityEvent OnLeftClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public UnityEvent OnRightClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public AK.Wwise.Event _sfxEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public FocusNavigation FocusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public FocusNavigationElement FocusNavigationElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public Image Background;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public GameObject Highlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public TextBase Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public SpriteAtlasImage BackgroundSpriteAtlas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public Sprite EnableSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public Sprite DisableSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public Color EnableSpriteColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public Color DisableSpriteColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public RectTransform AnimatedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private Tween _tween;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private bool _isClicked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x171")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		private bool _isAnimated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x172")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public bool UseTweenOnMouseOverAndOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x173")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public bool UseTweenOnMouseDownAndUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public bool UseScaleOnMouseOver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x175")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public bool UseScaleOnHighlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x176")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public bool UseFocusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x177")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		[FormerlySerializedAs("UseHighlight")]
		public bool UseHighlightOnMouseHover;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public bool UseHighlightOnMouseFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x179")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public bool CheckCursorIsVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17A")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public bool IgnoreHighlightExit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17B")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public bool IgnoreHighlightEventsWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		[SerializeField]
		protected bool _isActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17D")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		[SerializeField]
		[Header("Hold Settings")]
		private bool _useHold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		[SerializeField]
		[VisibleIf("_useHold")]
		private float _holdTimeSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		[SerializeField]
		[VisibleIf("_useHold")]
		private GameObject _holdMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		[SerializeField]
		[VisibleIf("_useHold")]
		private Image _holdProgressImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		[SerializeField]
		[VisibleIf("_useHold")]
		private TextBase _holdCompleteLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		[SerializeField]
		[VisibleIf("_useHold")]
		private RectTransform _labelHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		[VisibleIf("_useHold")]
		public UnityEvent OnHoldComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private bool _holding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private float _holdElapsedSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private InputActionBool _holdInputActionPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private InputActionBool _holdInputActionReleased;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		private bool _holdCompleteAnimationIn;

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public Button ButtonComponent
		{
			[Cpp2IlInjected.Token(Token = "0x600098F")]
			[Cpp2IlInjected.Address(RVA = "0xA5EAF0", Offset = "0xA5D4F0", VA = "0x180A5EAF0")]
			get
			{
				bool flag = default(bool);
				if (flag)
				{
				}
				Selectable selectable = Selectable;
				if ((object)selectable == null)
				{
				}
				int num = 0;
				_button = (Button)selectable;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public Toggle ToggleComponent
		{
			[Cpp2IlInjected.Token(Token = "0x6000990")]
			[Cpp2IlInjected.Address(RVA = "0xA5ED70", Offset = "0xA5D770", VA = "0x180A5ED70")]
			get
			{
				bool flag = default(bool);
				if (flag)
				{
				}
				Selectable selectable = Selectable;
				if ((object)selectable == null)
				{
				}
				int num = 0;
				_toggle = (Toggle)selectable;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public Selectable Selectable
		{
			[Cpp2IlInjected.Token(Token = "0x6000991")]
			[Cpp2IlInjected.Address(RVA = "0xA5EC90", Offset = "0xA5D690", VA = "0x180A5EC90")]
			get
			{
				bool flag = default(bool);
				if (flag)
				{
				}
				return _selectable = GetComponent<Selectable>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		private bool IsHighlighted
		{
			[Cpp2IlInjected.Token(Token = "0x6000992")]
			[Cpp2IlInjected.Address(RVA = "0xA5EC00", Offset = "0xA5D600", VA = "0x180A5EC00")]
			get
			{
				//Discarded unreachable code: IL_0023
				//IL_0010: Expected O, but got I4
				GameObject highlight = Highlight;
				int num = 0;
				bool flag = highlight != (UnityEngine.Object)num;
				if (!flag)
				{
					return flag;
				}
				return Highlight.activeSelf;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public bool IsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000993")]
			[Cpp2IlInjected.Address(RVA = "0xA5EBF0", Offset = "0xA5D5F0", VA = "0x180A5EBF0")]
			get
			{
				return _isActive;
			}
			[Cpp2IlInjected.Token(Token = "0x6000994")]
			[Cpp2IlInjected.Address(RVA = "0xA5EFC0", Offset = "0xA5D9C0", VA = "0x180A5EFC0")]
			set
			{
				_isActive = value;
				((ISupportInitialize)this).BeginInit();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public virtual SpriteAtlas SpriteAtlas
		{
			[Cpp2IlInjected.Token(Token = "0x6000995")]
			[Cpp2IlInjected.Address(RVA = "0xA5ED50", Offset = "0xA5D750", VA = "0x180A5ED50", Slot = "9")]
			get
			{
				SpriteAtlasImage backgroundSpriteAtlas;
				do
				{
					backgroundSpriteAtlas = BackgroundSpriteAtlas;
				}
				while ((object)backgroundSpriteAtlas == null);
				return backgroundSpriteAtlas.SpriteAtlas;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public bool UseHold
		{
			[Cpp2IlInjected.Token(Token = "0x6000996")]
			[Cpp2IlInjected.Address(RVA = "0xA5EE70", Offset = "0xA5D870", VA = "0x180A5EE70")]
			get
			{
				return _useHold;
			}
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0xA5EFE0", Offset = "0xA5D9E0", VA = "0x180A5EFE0")]
			set
			{
				_useHold = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event OnBaseButtonPress OnPress
		{
			[Cpp2IlInjected.Token(Token = "0x600098B")]
			[Cpp2IlInjected.Address(RVA = "0xA5E9B0", Offset = "0xA5D3B0", VA = "0x180A5E9B0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600098C")]
			[Cpp2IlInjected.Address(RVA = "0xA5EE80", Offset = "0xA5D880", VA = "0x180A5EE80")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event OnBaseButtonRelease OnRelease
		{
			[Cpp2IlInjected.Token(Token = "0x600098D")]
			[Cpp2IlInjected.Address(RVA = "0xA5EA50", Offset = "0xA5D450", VA = "0x180A5EA50")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600098E")]
			[Cpp2IlInjected.Address(RVA = "0xA5EF20", Offset = "0xA5D920", VA = "0x180A5EF20")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000998")]
		[Cpp2IlInjected.Address(RVA = "0xA5DED0", Offset = "0xA5C8D0", VA = "0x180A5DED0")]
		private void Start()
		{
			//IL_0019: Expected O, but got I4
			//IL_002c: Expected O, but got I4
			//IL_0077: Expected O, but got I4
			//IL_0099: Expected O, but got I4
			if (!_isActive)
			{
				Sprite disableSprite = DisableSprite;
				int num = 0;
				if (disableSprite != (UnityEngine.Object)num)
				{
					SpriteAtlasImage backgroundSpriteAtlas = BackgroundSpriteAtlas;
					int num2 = 0;
					if (backgroundSpriteAtlas != (UnityEngine.Object)num2)
					{
						Sprite disableSprite2 = DisableSprite;
						SpriteAtlasImage backgroundSpriteAtlas2 = BackgroundSpriteAtlas;
						string text2 = (backgroundSpriteAtlas2.ImageAddress = disableSprite2.name);
					}
				}
			}
			CursorWrapper.OnCursorChanged += OnCursorChanged;
			InputTriggerPressed trigger = new InputTriggerPressed();
			int num3 = default(int);
			InputActionBool holdInputActionPressed = new InputActionBool("[ A ]", trigger, (InputProvider)num3);
			num3 = 0;
			_holdInputActionPressed = holdInputActionPressed;
			InputTriggerReleased trigger2 = new InputTriggerReleased();
			int num4 = default(int);
			InputActionBool holdInputActionReleased = new InputActionBool("[ A ]", trigger2, (InputProvider)num4);
			num4 = 0;
			_holdInputActionReleased = holdInputActionReleased;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0xA5E7E0", Offset = "0xA5D1E0", VA = "0x180A5E7E0")]
		private void Update()
		{
			UpdateHolding();
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0xA5CB70", Offset = "0xA5B570", VA = "0x180A5CB70")]
		private void OnDestroy()
		{
			CursorWrapper.OnCursorChanged -= OnCursorChanged;
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0xA5CB50", Offset = "0xA5B550", VA = "0x180A5CB50")]
		private void OnCursorChanged(bool visible, CursorLockMode lockState)
		{
			if (!visible || lockState == CursorLockMode.Locked)
			{
				((ISupportInitialize)this).BeginInit();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBE0", Offset = "0xA5B5E0", VA = "0x180A5CBE0")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0076
			//IL_0024: Expected O, but got I4
			//IL_0050: Expected O, but got I4
			Tween tween = _tween;
			if (tween != null)
			{
				int complete = 0;
				tween.Kill((byte)complete != 0);
			}
			RectTransform animatedContent = AnimatedContent;
			int num = 0;
			if (animatedContent != (UnityEngine.Object)num)
			{
				RectTransform animatedContent2 = AnimatedContent;
				float z = _scaleDefault.z;
			}
			GameObject highlight = Highlight;
			int num2 = 0;
			if (highlight != (UnityEngine.Object)num2 && Highlight.activeSelf)
			{
				GameObject highlight2 = Highlight;
				int active = 0;
				highlight2.SetActive((byte)active != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA90", Offset = "0xA5B490", VA = "0x180A5CA90")]
		public void KillTween()
		{
			//Discarded unreachable code: IL_003d
			//IL_0024: Expected O, but got I4
			Tween tween = _tween;
			if (tween != null)
			{
				int complete = 0;
				tween.Kill((byte)complete != 0);
			}
			RectTransform animatedContent = AnimatedContent;
			int num = 0;
			if (animatedContent != (UnityEngine.Object)num)
			{
				RectTransform animatedContent2 = AnimatedContent;
				float z = _scaleDefault.z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE20", Offset = "0xA5C820", VA = "0x180A5DE20")]
		public void SetFocus()
		{
			//Discarded unreachable code: IL_0025
			if (!UseHighlightOnMouseFocus)
			{
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					return;
				}
			}
			((ISupportInitialize)this).BeginInit();
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0xA5CD20", Offset = "0xA5B720", VA = "0x180A5CD20", Slot = "10")]
		public virtual void OnHighlightEnter()
		{
			//Discarded unreachable code: IL_005c
			//IL_0010: Expected O, but got I4
			//IL_0038: Expected O, but got I4
			GameObject highlight = Highlight;
			int num = 0;
			if (highlight != (UnityEngine.Object)num)
			{
				Highlight.SetActive(value: true);
			}
			if (UseScaleOnHighlight)
			{
				RectTransform animatedContent = AnimatedContent;
				int num2 = 0;
				if (animatedContent != (UnityEngine.Object)num2)
				{
					RectTransform animatedContent2 = AnimatedContent;
					float z = ScaleMouseEnter.z;
				}
			}
			OnHighlightAdded.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0xA5CE30", Offset = "0xA5B830", VA = "0x180A5CE30", Slot = "11")]
		public virtual void OnHighlightExit()
		{
			//Discarded unreachable code: IL_006d
			//IL_0019: Expected O, but got I4
			//IL_0049: Expected O, but got I4
			if (IgnoreHighlightExit)
			{
				return;
			}
			GameObject highlight = Highlight;
			int num = 0;
			if (highlight != (UnityEngine.Object)num)
			{
				GameObject highlight2 = Highlight;
				int active = 0;
				highlight2.SetActive((byte)active != 0);
			}
			if (UseScaleOnHighlight)
			{
				RectTransform animatedContent = AnimatedContent;
				int num2 = 0;
				if (animatedContent != (UnityEngine.Object)num2)
				{
					RectTransform animatedContent2 = AnimatedContent;
					float z = _scaleDefault.z;
				}
			}
			OnHighlightRemoved.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0xA5D190", Offset = "0xA5BB90", VA = "0x180A5D190", Slot = "12")]
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_01ef
			//IL_003b: Expected O, but got I4
			//IL_007f: Expected O, but got I4
			//IL_0155: Expected O, but got I4
			//IL_018a: Expected O, but got I4
			//IL_01a1: Expected O, but got I4
			if (IgnoreHighlightEventsWhenInactive && !_isActive)
			{
				return;
			}
			if (CheckCursorIsVisible)
			{
				int num = 0;
				if (!CursorWrapper.Visible)
				{
					return;
				}
			}
			Selectable selectable = Selectable;
			int num2 = 0;
			if (!(selectable != (UnityEngine.Object)num2) || !Selectable.m_Interactable)
			{
				return;
			}
			int num3 = 0;
			if (!PlatformUtils.IsPCPlayer())
			{
				return;
			}
			if (UseTweenOnMouseOverAndOut)
			{
				RectTransform animatedContent = AnimatedContent;
				int num4 = 0;
				if (animatedContent != (UnityEngine.Object)num4 && _isActive && _isClicked)
				{
					Button buttonComponent = ButtonComponent;
					if ((object)buttonComponent == null || buttonComponent.IsInteractable())
					{
						KillBump();
						int num5 = 0;
						Sequence s = DOTween.Sequence();
						float z = _scaleOnMouseOver1.z;
						RectTransform animatedContent2 = AnimatedContent;
						TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
						TweenerCore<Vector3, Vector3, VectorOptions> t2 = t.SetEase(Ease.OutCubic);
						Sequence s2 = s.Append(t2);
						float z2 = _scaleOnMouseOver2.z;
						RectTransform animatedContent3 = AnimatedContent;
						float overshoot = shootout;
						TweenerCore<Vector3, Vector3, VectorOptions> t3 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
						TweenerCore<Vector3, Vector3, VectorOptions> t4 = t3.SetEase(Ease.OutBack, overshoot);
						Sequence sequence = (Sequence)(_tween = s2.Append(t4));
						_isAnimated = true;
					}
				}
			}
			if (UseScaleOnMouseOver)
			{
				RectTransform animatedContent4 = AnimatedContent;
				int num6 = 0;
				if (animatedContent4 != (UnityEngine.Object)num6)
				{
					RectTransform animatedContent5 = AnimatedContent;
					float z3 = ScaleMouseEnter.z;
				}
			}
			if (UseFocusNavigation)
			{
				FocusNavigation focusNavigation = FocusNavigation;
				int num7 = 0;
				if (focusNavigation != (UnityEngine.Object)num7)
				{
					FocusNavigationElement focusNavigationElement = FocusNavigationElement;
					int num8 = 0;
					if (focusNavigationElement != (UnityEngine.Object)num8)
					{
						FocusNavigation focusNavigation2 = FocusNavigation;
						FocusNavigationElement focusNavigationElement2 = FocusNavigationElement;
						focusNavigation2.SetFocus(focusNavigationElement2);
					}
				}
			}
			if (UseHighlightOnMouseHover)
			{
				OnHighlightEnter();
			}
			int num9 = 0;
			UiRoot.Instance.OnJoystickChangeHander(active: true);
			OnPointerEntered?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0xA5E160", Offset = "0xA5CB60", VA = "0x180A5E160")]
		private void TweenOnEnter()
		{
			if (_isActive && _isClicked)
			{
				Button buttonComponent = ButtonComponent;
				if ((object)buttonComponent == null || buttonComponent.IsInteractable())
				{
					KillBump();
					int num = 0;
					Sequence s = DOTween.Sequence();
					float z = _scaleOnMouseOver1.z;
					RectTransform animatedContent = AnimatedContent;
					TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
					TweenerCore<Vector3, Vector3, VectorOptions> t2 = t.SetEase(Ease.OutCubic);
					Sequence s2 = s.Append(t2);
					float z2 = _scaleOnMouseOver2.z;
					RectTransform animatedContent2 = AnimatedContent;
					float overshoot = shootout;
					TweenerCore<Vector3, Vector3, VectorOptions> t3 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
					TweenerCore<Vector3, Vector3, VectorOptions> t4 = t3.SetEase(Ease.OutBack, overshoot);
					Sequence sequence = (Sequence)(_tween = s2.Append(t4));
					_isAnimated = true;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0xA5D580", Offset = "0xA5BF80", VA = "0x180A5D580", Slot = "13")]
		public virtual void OnPointerExit(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_019b
			//IL_0054: Expected O, but got I4
			//IL_012a: Expected O, but got I4
			if (IgnoreHighlightEventsWhenInactive && !_isActive)
			{
				return;
			}
			if (CheckCursorIsVisible)
			{
				int num = 0;
				if (!CursorWrapper.Visible)
				{
					return;
				}
			}
			int num2 = 0;
			if (PlatformUtils.IsPCPlayer())
			{
				if (UseTweenOnMouseOverAndOut)
				{
					RectTransform animatedContent = AnimatedContent;
					int num3 = 0;
					if (animatedContent != (UnityEngine.Object)num3 && _isActive && _isClicked)
					{
						Button buttonComponent = ButtonComponent;
						if ((object)buttonComponent == null || buttonComponent.IsInteractable())
						{
							KillBump();
							int num4 = 0;
							Sequence s = DOTween.Sequence();
							float z = _scaleOnMouseOut1.z;
							RectTransform animatedContent2 = AnimatedContent;
							TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
							TweenerCore<Vector3, Vector3, VectorOptions> t2 = t.SetEase(Ease.OutCubic);
							Sequence s2 = s.Append(t2);
							float z2 = _scaleOnMouseOut2.z;
							RectTransform animatedContent3 = AnimatedContent;
							float overshoot = shootout;
							TweenerCore<Vector3, Vector3, VectorOptions> t3 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
							TweenerCore<Vector3, Vector3, VectorOptions> t4 = t3.SetEase(Ease.OutElastic, overshoot);
							Sequence sequence = (Sequence)(_tween = s2.Append(t4));
							_isAnimated = false;
						}
					}
				}
				if (UseScaleOnMouseOver)
				{
					RectTransform animatedContent4 = AnimatedContent;
					int num5 = 0;
					if (animatedContent4 != (UnityEngine.Object)num5)
					{
						RectTransform animatedContent5 = AnimatedContent;
						float z3 = _scaleDefault.z;
					}
				}
				if (UseHighlightOnMouseHover)
				{
					OnHighlightExit();
				}
				int num6 = 0;
				UiRoot instance = UiRoot.Instance;
				int active = 0;
				instance.OnJoystickChangeHander((byte)active != 0);
				OnPointerExited?.Invoke();
			}
			AnimateCompleteOut();
			if (_useHold && _holding)
			{
				_holding = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0xA5CF50", Offset = "0xA5B950", VA = "0x180A5CF50", Slot = "8")]
		public void OnPointerClick(PointerEventData eventData)
		{
			if (!_isActive)
			{
				return;
			}
			if ((object)ButtonComponent != null)
			{
			}
			if (eventData != null && (!_useHold || !(_holdTimeSeconds > _holdElapsedSeconds)))
			{
				PointerEventData.InputButton _003Cbutton_003Ek__BackingField = eventData.button;
				if (_003Cbutton_003Ek__BackingField == PointerEventData.InputButton.Left || _003Cbutton_003Ek__BackingField == PointerEventData.InputButton.Right)
				{
					OnLeftClick?.Invoke();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2F0", Offset = "0xA5CCF0", VA = "0x180A5E2F0")]
		private void TweenOnExit()
		{
			if (_isActive && _isClicked)
			{
				Button buttonComponent = ButtonComponent;
				if ((object)buttonComponent == null || buttonComponent.IsInteractable())
				{
					KillBump();
					int num = 0;
					Sequence s = DOTween.Sequence();
					float z = _scaleOnMouseOut1.z;
					RectTransform animatedContent = AnimatedContent;
					TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
					TweenerCore<Vector3, Vector3, VectorOptions> t2 = t.SetEase(Ease.OutCubic);
					Sequence s2 = s.Append(t2);
					float z2 = _scaleOnMouseOut2.z;
					RectTransform animatedContent2 = AnimatedContent;
					float overshoot = shootout;
					TweenerCore<Vector3, Vector3, VectorOptions> t3 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
					TweenerCore<Vector3, Vector3, VectorOptions> t4 = t3.SetEase(Ease.OutElastic, overshoot);
					Sequence sequence = (Sequence)(_tween = s2.Append(t4));
					_isAnimated = false;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0xA5C9E0", Offset = "0xA5B3E0", VA = "0x180A5C9E0")]
		private void KillBump()
		{
			//Discarded unreachable code: IL_0039
			//IL_0020: Expected O, but got I4
			Tween tween = _tween;
			int complete = 0;
			tween.Kill((byte)complete != 0);
			RectTransform animatedContent = AnimatedContent;
			int num = 0;
			if (animatedContent != (UnityEngine.Object)num)
			{
				RectTransform animatedContent2 = AnimatedContent;
				float z = _scaleDefault.z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B190", VA = "0x180A5C790")]
		public void Bump()
		{
			KillBump();
			int num = 0;
			Sequence s = DOTween.Sequence();
			float z = _scaleOnMouseDown1.z;
			RectTransform animatedContent = AnimatedContent;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			Sequence s2 = s.Append(t);
			float z2 = _scaleDefault.z;
			RectTransform animatedContent2 = AnimatedContent;
			TweenerCore<Vector3, Vector3, VectorOptions> t2 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			Sequence sequence = (Sequence)(_tween = s2.Append(t2));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0xA5D890", Offset = "0xA5C290", VA = "0x180A5D890", Slot = "14")]
		public virtual void OnPointerUp([Optional] PointerEventData eventData)
		{
			//IL_001c: Expected O, but got I4
			if (UseTweenOnMouseDownAndUp)
			{
				RectTransform animatedContent = AnimatedContent;
				int num = 0;
				if (animatedContent != (UnityEngine.Object)num && _isActive)
				{
					if (_isClicked && _isAnimated)
					{
						Button buttonComponent = ButtonComponent;
						if ((object)buttonComponent == null || buttonComponent.IsInteractable())
						{
							KillBump();
							int num2 = 0;
							Sequence s = DOTween.Sequence();
							float z = _scaleDefault.z;
							RectTransform animatedContent2 = AnimatedContent;
							TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
							Sequence sequence = (Sequence)(_tween = s.Append(t));
							_isAnimated = false;
						}
					}
					_isClicked = false;
				}
			}
			this.OnRelease?.Invoke(this);
			DoneHolding();
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0xA5DB30", Offset = "0xA5C530", VA = "0x180A5DB30")]
		private void OnTweenUp()
		{
			if (!_isActive)
			{
				return;
			}
			if (_isClicked && _isAnimated)
			{
				Button buttonComponent = ButtonComponent;
				if ((object)buttonComponent == null || buttonComponent.IsInteractable())
				{
					KillBump();
					int num = 0;
					Sequence s = DOTween.Sequence();
					float z = _scaleDefault.z;
					RectTransform animatedContent = AnimatedContent;
					TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
					Sequence sequence = (Sequence)(_tween = s.Append(t));
					_isAnimated = false;
				}
			}
			_isClicked = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0xA5CFE0", Offset = "0xA5B9E0", VA = "0x180A5CFE0", Slot = "15")]
		public virtual void OnPointerDown([Optional] PointerEventData eventData)
		{
			//Discarded unreachable code: IL_00b0
			//IL_0019: Expected O, but got I4
			if (UseTweenOnMouseDownAndUp)
			{
				RectTransform animatedContent = AnimatedContent;
				int num = 0;
				if (animatedContent != (UnityEngine.Object)num && _isActive)
				{
					Button buttonComponent = ButtonComponent;
					if ((object)buttonComponent == null || buttonComponent.IsInteractable())
					{
						_isClicked = true;
						KillBump();
						int num2 = 0;
						Sequence s = DOTween.Sequence();
						float z = _scaleOnMouseDown1.z;
						RectTransform animatedContent2 = AnimatedContent;
						TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
						Sequence sequence = (Sequence)(_tween = s.Append(t));
					}
				}
			}
			this.OnPress?.Invoke(this);
			if (_useHold)
			{
				Button buttonComponent2 = ButtonComponent;
				_holding = true;
				_holdElapsedSeconds = 0f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0xA5DA30", Offset = "0xA5C430", VA = "0x180A5DA30")]
		private void OnTweenDown()
		{
			if (_isActive)
			{
				Button buttonComponent = ButtonComponent;
				if ((object)buttonComponent == null || buttonComponent.IsInteractable())
				{
					_isClicked = true;
					KillBump();
					int num = 0;
					Sequence s = DOTween.Sequence();
					float z = _scaleOnMouseDown1.z;
					RectTransform animatedContent = AnimatedContent;
					TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
					Sequence sequence = (Sequence)(_tween = s.Append(t));
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0xA5DC50", Offset = "0xA5C650", VA = "0x180A5DC50")]
		public void PostWwiseEvent()
		{
			//Discarded unreachable code: IL_0021
			if (_isActive)
			{
				AK.Wwise.Event sfxEvent = _sfxEvent;
				GameObject gameObject = base.gameObject;
				uint num = sfxEvent.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0xA5DCA0", Offset = "0xA5C6A0", VA = "0x180A5DCA0", Slot = "16")]
		public virtual void RefreshActive()
		{
			//Discarded unreachable code: IL_008f
			//IL_0010: Expected O, but got I4
			//IL_0026: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			Sprite disableSprite = DisableSprite;
			int num = 0;
			if (!(disableSprite != (UnityEngine.Object)num))
			{
				return;
			}
			Sprite enableSprite = EnableSprite;
			int num2 = 0;
			if (!(enableSprite != (UnityEngine.Object)num2))
			{
				return;
			}
			SpriteAtlasImage backgroundSpriteAtlas = BackgroundSpriteAtlas;
			int num3 = 0;
			if (backgroundSpriteAtlas != (UnityEngine.Object)num3)
			{
				SpriteAtlasImage backgroundSpriteAtlas2 = BackgroundSpriteAtlas;
				if (_isActive)
				{
				}
				string text2 = (backgroundSpriteAtlas2.ImageAddress = DisableSprite.name);
				Image image = BackgroundSpriteAtlas.Image;
				if (_isActive)
				{
				}
				Color color = (image.color = DisableSpriteColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0F0", Offset = "0xA5CAF0", VA = "0x180A5E0F0")]
		public void TriggerButtonClick()
		{
			//Discarded unreachable code: IL_0009
			bool flag = default(bool);
			if (flag && (object)this == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE80", Offset = "0xA5C880", VA = "0x180A5DE80")]
		private void StartHolding()
		{
			//Discarded unreachable code: IL_0023
			if (_useHold)
			{
				Button buttonComponent = ButtonComponent;
				_holding = true;
				_holdElapsedSeconds = 0f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0xA5E480", Offset = "0xA5CE80", VA = "0x180A5E480")]
		private void UpdateHolding()
		{
			//Discarded unreachable code: IL_0169
			//IL_001c: Expected O, but got I4
			//IL_014c: Expected O, but got I4
			while (_useHold)
			{
				GameObject highlight = Highlight;
				int num = 0;
				if (highlight != (UnityEngine.Object)num && Highlight.activeSelf)
				{
					int num2 = 0;
					UiRoot instance = UiRoot.Instance;
					int useKeyboardAsController = 0;
					if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
					{
						goto IL_00ef;
					}
					int num3 = 0;
					float deltaTime = Time.deltaTime;
					InputAction[] array = new InputAction[2];
					InputActionBool holdInputActionPressed = _holdInputActionPressed;
					if (holdInputActionPressed != null && array == null)
					{
						continue;
					}
					array[0] = holdInputActionPressed;
					InputActionBool holdInputActionReleased = _holdInputActionReleased;
					if (holdInputActionReleased != null && array == null)
					{
						continue;
					}
					array[1] = holdInputActionReleased;
					InputAction.UpdateAll(deltaTime, array);
					if (!_holding)
					{
						InputActionBool holdInputActionPressed2 = _holdInputActionPressed;
						StartHolding();
						if (!_holding)
						{
							goto IL_00ef;
						}
					}
					InputActionBool holdInputActionReleased2 = _holdInputActionReleased;
					DoneHolding();
				}
				AnimateCompleteOut();
				if (_useHold)
				{
					if (!_holding)
					{
						goto IL_0138;
					}
					_holding = false;
				}
				goto IL_00ef;
				IL_00ef:
				if (_holding)
				{
					int num4 = 0;
					float deltaTime2 = Time.deltaTime;
					Image holdProgressImage = _holdProgressImage;
					_holdElapsedSeconds = deltaTime2;
					float num6 = (holdProgressImage.fillAmount = Mathf.Clamp01(deltaTime2));
					if (!(_holdElapsedSeconds <= _holdTimeSeconds))
					{
						AnimateCompleteIn();
					}
				}
				goto IL_0138;
				IL_0138:
				GameObject holdMask = _holdMask;
				int num7 = 0;
				if (holdMask != (UnityEngine.Object)num7)
				{
					GameObject holdMask2 = _holdMask;
					bool holding = _holding;
					holdMask2.SetActive(holding);
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0xA5C890", Offset = "0xA5B290", VA = "0x180A5C890")]
		private void CancelHolding()
		{
			AnimateCompleteOut();
			if (_useHold && _holding)
			{
				_holding = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0xA5C8C0", Offset = "0xA5B2C0", VA = "0x180A5C8C0")]
		private void DoneHolding()
		{
			//Discarded unreachable code: IL_006e
			//IL_005a: Expected I4, but got O
			_003C_003Ec__DisplayClass110_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass110_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			AnimateCompleteOut();
			if (_useHold && _holding)
			{
				_holding = false;
				Button buttonComponent = ButtonComponent;
				if (!(_holdTimeSeconds > _holdElapsedSeconds))
				{
					OnHoldComplete?.Invoke();
					return;
				}
				CS_0024_003C_003E8__locals0.originalIgnoreHighlightExit = (byte)(int)CS_0024_003C_003E8__locals0 != 0;
				Button button = default(Button);
				int num = ((button.interactable = false) ? 1 : 0);
				IEnumerator enumerator = RestoreInteractable();
			}
			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0x8E47A0", Offset = "0x8E31A0", VA = "0x1808E47A0")]
			[IteratorStateMachine(typeof(_003C_003Ec__DisplayClass110_0._003C_003CDoneHolding_003Eg__RestoreInteractable_007C0_003Ed))]
			IEnumerator RestoreInteractable()
			{
				int _003C_003E1__state = default(int);
				_003C_003Ec__DisplayClass110_0._003C_003CDoneHolding_003Eg__RestoreInteractable_007C0_003Ed _003C_003CDoneHolding_003Eg__RestoreInteractable_007C0_003Ed = new _003C_003Ec__DisplayClass110_0._003C_003CDoneHolding_003Eg__RestoreInteractable_007C0_003Ed(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003C_003CDoneHolding_003Eg__RestoreInteractable_007C0_003Ed._003C_003E4__this = CS_0024_003C_003E8__locals0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0xA5C460", Offset = "0xA5AE60", VA = "0x180A5C460")]
		private void AnimateCompleteIn()
		{
			//Discarded unreachable code: IL_014a
			//IL_005a: Expected F4, but got I4
			//IL_008b: Expected F4, but got I4
			//IL_008b: Expected F4, but got I4
			//IL_00d0: Expected F4, but got I4
			//IL_00f5: Expected F4, but got I4
			if (_useHold && !_holdCompleteAnimationIn)
			{
				int num = 0;
				RectTransform labelHolder = _labelHolder;
				int num2 = 0;
				_holdCompleteAnimationIn = true;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(labelHolder, 20f, 0.2f, (byte)num2 != 0);
				TextMeshProUGUI textComponent = Label.TextComponent;
				int num3 = 0;
				TweenerCore<Color, Color, ColorOptions> tweenerCore2 = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOFade((UnityEngine.UI.Graphic)textComponent, (float)num3, 0.2f);
				_holdCompleteLabel.gameObject.SetActive(value: true);
				TextMeshProUGUI textComponent2 = _holdCompleteLabel.TextComponent;
				int num4 = 0;
				int num5 = 0;
				TweenerCore<Color, Color, ColorOptions> tweenerCore3 = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOFade((UnityEngine.UI.Graphic)textComponent2, (float)num5, (float)num4);
				TweenerCore<Color, Color, ColorOptions> tweenerCore4 = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOFade((UnityEngine.UI.Graphic)_holdCompleteLabel.TextComponent, 1f, 0.2f);
				TextBase holdCompleteLabel = _holdCompleteLabel;
				int num6 = 0;
				RectTransform rectTransform = holdCompleteLabel.RectTransform;
				int num7 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore5 = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(rectTransform, -20f, (float)num7, (byte)num6 != 0);
				RectTransform rectTransform2 = _holdCompleteLabel.RectTransform;
				int num8 = 0;
				int num9 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore6 = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(rectTransform2, (float)num9, 0.2f, (byte)num8 != 0);
				int num10 = 0;
				Sequence s = DOTween.Sequence();
				float z = _scaleOnMouseDown1.z;
				RectTransform animatedContent = AnimatedContent;
				TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
				Sequence s2 = s.Append(t);
				float z2 = _scaleDefault.z;
				RectTransform animatedContent2 = AnimatedContent;
				TweenerCore<Vector3, Vector3, VectorOptions> t2 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
				Sequence sequence = (Sequence)(_tween = s2.Append(t2));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0xA5C6B0", Offset = "0xA5B0B0", VA = "0x180A5C6B0")]
		private void AnimateCompleteOut()
		{
			//Discarded unreachable code: IL_008f
			//IL_002b: Expected F4, but got I4
			//IL_0067: Expected F4, but got I4
			if (_useHold)
			{
				int num = 0;
				_holdCompleteAnimationIn = false;
				RectTransform labelHolder = _labelHolder;
				int num2 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(labelHolder, (float)num2, 0.2f, (byte)num != 0);
				TweenerCore<Color, Color, ColorOptions> tweenerCore2 = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOFade((UnityEngine.UI.Graphic)Label.TextComponent, 1f, 0.2f);
				TextMeshProUGUI textComponent = _holdCompleteLabel.TextComponent;
				int num3 = 0;
				TweenerCore<Color, Color, ColorOptions> tweenerCore3 = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOFade((UnityEngine.UI.Graphic)textComponent, (float)num3, 0.2f);
				TextBase holdCompleteLabel = _holdCompleteLabel;
				int num4 = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore4 = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(holdCompleteLabel.RectTransform, -20f, 0.2f, (byte)num4 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0xA5E7F0", Offset = "0xA5D1F0", VA = "0x180A5E7F0")]
		public unsafe BaseButton()
		{
			//IL_000c: Expected F4, but got I8
			//IL_0007: Expected native int or pointer, but got O
			//IL_0018: Expected F4, but got I8
			//IL_0013: Expected native int or pointer, but got O
			//IL_0024: Expected F4, but got I8
			//IL_001f: Expected native int or pointer, but got O
			//IL_0030: Expected F4, but got I8
			//IL_002b: Expected native int or pointer, but got O
			//IL_003d: Expected F4, but got I8
			//IL_0038: Expected native int or pointer, but got O
			//IL_004a: Expected F4, but got I8
			//IL_0045: Expected native int or pointer, but got O
			//IL_0057: Expected F4, but got I8
			//IL_0052: Expected native int or pointer, but got O
			//IL_0064: Expected F4, but got I8
			//IL_005f: Expected native int or pointer, but got O
			//IL_0078: Expected native int or pointer, but got O
			//IL_008a: Expected F4, but got I8
			//IL_0085: Expected native int or pointer, but got O
			ulong num = default(ulong);
			((Vector3*)(IntPtr)_scaleOnMouseOver1)->z = (long)num;
			ulong num2 = default(ulong);
			((Vector3*)(IntPtr)_scaleOnMouseOver2)->z = (long)num2;
			ulong num3 = default(ulong);
			((Vector3*)(IntPtr)_scaleOnMouseOut1)->z = (long)num3;
			ulong num4 = default(ulong);
			((Vector3*)(IntPtr)_scaleOnMouseOut2)->z = (long)num4;
			ulong num5 = default(ulong);
			((Vector3*)(IntPtr)_scaleOnMouseUp1)->z = (long)num5;
			ulong num6 = default(ulong);
			((Vector3*)(IntPtr)_scaleOnMouseUp2)->z = (long)num6;
			ulong num7 = default(ulong);
			((Vector3*)(IntPtr)_scaleOnMouseDown1)->z = (long)num7;
			ulong num8 = default(ulong);
			((Vector3*)(IntPtr)_scaleOnMouseDown2)->z = (long)num8;
			float z = Vector3.one.z;
			((Vector3*)(IntPtr)_scaleDefault)->z = z;
			ulong num9 = default(ulong);
			((Vector3*)(IntPtr)ScaleMouseEnter)->z = (long)num9;
			HighlightSize = 0.85f;
			animationInDuration = 0.2f;
			animationOutDuration = 0.6f;
			shootout = 1.3f;
			Color white = Color.white;
			Color white2 = Color.white;
			UseHighlightOnMouseFocus = true;
			_isActive = true;
			_holdTimeSeconds = 3f;
			base._002Ector();
		}
	}
}
