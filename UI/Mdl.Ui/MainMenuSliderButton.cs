using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000265")]
	[RequireComponent(typeof(Slider))]
	public class MainMenuSliderButton : CustomButton
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000ABF")]
		public ShortcutDefinition ShortcutDefinition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000AC0")]
		public ImageHelper DynamicIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000AC1")]
		public GameObject QuestIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000AC2")]
		private Slider _slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000AC3")]
		private SliderMenu _sliderMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000AC4")]
		[SerializeField]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000AC5")]
		private FocusNavigationElement _focusNavigationElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000AC6")]
		private bool _changed;

		[Cpp2IlInjected.Token(Token = "0x6000F3D")]
		[Cpp2IlInjected.Address(RVA = "0xFA5310", Offset = "0xFA3D10", VA = "0x180FA5310")]
		protected void Awake()
		{
			Slider slider = (_slider = GetComponent<Slider>());
			SliderMenu sliderMenu = (_sliderMenu = GetComponentInChildren<SliderMenu>());
			FocusNavigationElement focusNavigationElement = (_focusNavigationElement = GetComponent<FocusNavigationElement>());
			((TemplateButton)this).UseHighlightWhenSelected = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3E")]
		[Cpp2IlInjected.Address(RVA = "0xFA5620", Offset = "0xFA4020", VA = "0x180FA5620", Slot = "12")]
		protected override void OnEnable()
		{
			//Discarded unreachable code: IL_00dd
			base.OnEnable();
			Slider.SliderEvent onValueChanged = _slider.m_OnValueChanged;
			UnityAction<float> unityAction = (UnityAction<float>)(object)new UnityAction<T0>(OnValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
			UnityEvent onSelected = OnSelected;
			UnityAction call = UpdateVisuals;
			onSelected.AddListener(call);
			UnityEvent onDeselected = OnDeselected;
			UnityAction call2 = UpdateVisuals;
			onDeselected.AddListener(call2);
			UnityEvent onHighlighted = OnHighlighted;
			UnityAction call3 = UpdateVisuals;
			onHighlighted.AddListener(call3);
			UnityEvent onDehighlighted = OnDehighlighted;
			UnityAction call4 = UpdateVisuals;
			onDehighlighted.AddListener(call4);
			UnityEvent onPressed = OnPressed;
			UnityAction call5 = UpdateVisuals;
			onPressed.AddListener(call5);
			UnityEvent onReleased = OnReleased;
			UnityAction call6 = UpdateVisuals;
			onReleased.AddListener(call6);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3F")]
		[Cpp2IlInjected.Address(RVA = "0xFA53C0", Offset = "0xFA3DC0", VA = "0x180FA53C0", Slot = "13")]
		protected override void OnDisable()
		{
			//Discarded unreachable code: IL_00dd
			Slider.SliderEvent onValueChanged = _slider.m_OnValueChanged;
			UnityAction<float> unityAction = (UnityAction<float>)(object)new UnityAction<T0>(OnValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
			UnityEvent onSelected = OnSelected;
			UnityAction call = UpdateVisuals;
			onSelected.RemoveListener(call);
			UnityEvent onDeselected = OnDeselected;
			UnityAction call2 = UpdateVisuals;
			onDeselected.RemoveListener(call2);
			UnityEvent onHighlighted = OnHighlighted;
			UnityAction call3 = UpdateVisuals;
			onHighlighted.RemoveListener(call3);
			UnityEvent onDehighlighted = OnDehighlighted;
			UnityAction call4 = UpdateVisuals;
			onDehighlighted.RemoveListener(call4);
			UnityEvent onPressed = OnPressed;
			UnityAction call5 = UpdateVisuals;
			onPressed.RemoveListener(call5);
			UnityEvent onReleased = OnReleased;
			UnityAction call6 = UpdateVisuals;
			onReleased.RemoveListener(call6);
			base.OnDisable();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F40")]
		[Cpp2IlInjected.Address(RVA = "0xFA5890", Offset = "0xFA4290", VA = "0x180FA5890", Slot = "19")]
		public override void RefreshDisplay()
		{
			base.RefreshDisplay();
			UpdateVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F41")]
		[Cpp2IlInjected.Address(RVA = "0xFA5880", Offset = "0xFA4280", VA = "0x180FA5880")]
		private void OnValueChangedHandler(float value)
		{
			_changed = true;
			UpdateVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F42")]
		[Cpp2IlInjected.Address(RVA = "0xFA58B0", Offset = "0xFA42B0", VA = "0x180FA58B0")]
		private void UpdateSliderMenuVisuals()
		{
			//Discarded unreachable code: IL_0096
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			bool isPressed = ((TemplateButton)this)._isPressed;
			if (!flag)
			{
				if (!isPressed)
				{
					bool isHighlighted = ((TemplateButton)this)._isHighlighted;
					if (!isHighlighted || _changed == isPressed)
					{
						SliderMenu sliderMenu = _sliderMenu;
						if (!isHighlighted)
						{
							_changed = isHighlighted;
							sliderMenu.OnEnable();
						}
						else
						{
							sliderMenu.Highlight();
						}
						return;
					}
				}
				_sliderMenu.Press();
			}
			else if (!isPressed)
			{
				_sliderMenu.OnEnable();
				_changed = false;
			}
			else
			{
				_sliderMenu.Press();
				_changed = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F43")]
		[Cpp2IlInjected.Address(RVA = "0xFA59A0", Offset = "0xFA43A0", VA = "0x180FA59A0")]
		private void UpdateVisuals()
		{
			//Discarded unreachable code: IL_00cc
			//IL_009e: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			bool isPressed = ((TemplateButton)this)._isPressed;
			if (!flag)
			{
				if (!isPressed)
				{
					bool isHighlighted = ((TemplateButton)this)._isHighlighted;
					if (!isHighlighted || _changed == isPressed)
					{
						SliderMenu sliderMenu = _sliderMenu;
						if (!isHighlighted)
						{
							_changed = isHighlighted;
							sliderMenu.OnEnable();
						}
						sliderMenu.Highlight();
					}
				}
				_sliderMenu.Press();
			}
			if (!isPressed)
			{
				_sliderMenu.OnEnable();
			}
			_sliderMenu.Press();
			_changed = false;
			ButtonViewDefault view = base.View;
			int num2 = 0;
			if (view != (Object)num2)
			{
				base.View.DynamicIcon.SetColorRGB(16577222);
				base.View.Label.SetColorRGB(16577222);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F44")]
		[Cpp2IlInjected.Address(RVA = "0x863470", Offset = "0x861E70", VA = "0x180863470")]
		public MainMenuSliderButton()
		{
		}
	}
}
