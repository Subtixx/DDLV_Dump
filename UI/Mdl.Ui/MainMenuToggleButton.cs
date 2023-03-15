using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000267")]
	[RequireComponent(typeof(Toggle))]
	[RequireComponent(typeof(ToggleText))]
	public class MainMenuToggleButton : CustomButton
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000268")]
		public class State
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000ADD")]
			public Sprite BackgroundSprite;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000ADE")]
			public Color LabelColor;

			[Cpp2IlInjected.Token(Token = "0x6000F5E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public State()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000AD3")]
		public ShortcutDefinition ShortcutDefinition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000AD4")]
		public ImageHelper DynamicIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000AD5")]
		public GameObject QuestIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000AD6")]
		public Image Background;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000AD7")]
		[SerializeField]
		private State NormalState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000AD8")]
		[SerializeField]
		private State SelectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000AD9")]
		[SerializeField]
		private State HighlightState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000ADA")]
		[SerializeField]
		private State SelectedHighlightState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000ADB")]
		private Toggle _toggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000ADC")]
		private ToggleText _toggleText;

		[Cpp2IlInjected.Token(Token = "0x6000F56")]
		[Cpp2IlInjected.Address(RVA = "0xFA67F0", Offset = "0xFA51F0", VA = "0x180FA67F0")]
		protected void Awake()
		{
			((TemplateButton)this).UseHighlightWhenSelected = true;
			Toggle toggle = (_toggle = GetComponent<Toggle>());
			ToggleText toggleText = (_toggleText = GetComponent<ToggleText>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F57")]
		[Cpp2IlInjected.Address(RVA = "0xFA6A10", Offset = "0xFA5410", VA = "0x180FA6A10", Slot = "12")]
		protected override void OnEnable()
		{
			//Discarded unreachable code: IL_009a
			base.OnEnable();
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
			UnityEvent onClicked = OnClicked;
			UnityAction call5 = OnTogglePressed;
			onClicked.AddListener(call5);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F58")]
		[Cpp2IlInjected.Address(RVA = "0xFA6870", Offset = "0xFA5270", VA = "0x180FA6870", Slot = "13")]
		protected override void OnDisable()
		{
			//Discarded unreachable code: IL_009a
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
			UnityEvent onClicked = OnClicked;
			UnityAction call5 = OnTogglePressed;
			onClicked.RemoveListener(call5);
			base.OnDisable();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F59")]
		[Cpp2IlInjected.Address(RVA = "0xFA6CE0", Offset = "0xFA56E0", VA = "0x180FA6CE0", Slot = "19")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_005d
			base.RefreshDisplay();
			State selectedState = SelectedState;
			TextBase labelOFF = _toggleText.LabelOFF;
			Color labelColor = selectedState.LabelColor;
			labelOFF.SetColor(labelColor);
			TextBase labelON = _toggleText.LabelON;
			Color labelColor2 = selectedState.LabelColor;
			labelON.SetColor(labelColor2);
			Image background = Background;
			Sprite sprite = (background.sprite = selectedState.BackgroundSprite);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5A")]
		[Cpp2IlInjected.Address(RVA = "0xFA6DB0", Offset = "0xFA57B0", VA = "0x180FA6DB0")]
		private void UpdateVisuals()
		{
			//Discarded unreachable code: IL_0057
			State selectedState = SelectedState;
			TextBase labelOFF = _toggleText.LabelOFF;
			Color labelColor = selectedState.LabelColor;
			labelOFF.SetColor(labelColor);
			TextBase labelON = _toggleText.LabelON;
			Color labelColor2 = selectedState.LabelColor;
			labelON.SetColor(labelColor2);
			Image background = Background;
			Sprite sprite = (background.sprite = selectedState.BackgroundSprite);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5B")]
		[Cpp2IlInjected.Address(RVA = "0xFA6C20", Offset = "0xFA5620", VA = "0x180FA6C20")]
		public void OnTogglePressed()
		{
			//Discarded unreachable code: IL_004e
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int _003C_003E1__state = default(int);
				_003COnTogglePressedGamepad_003Ed__17 _003COnTogglePressedGamepad_003Ed__ = new _003COnTogglePressedGamepad_003Ed__17(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003COnTogglePressedGamepad_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = StartCoroutine(_003COnTogglePressedGamepad_003Ed__);
			}
			else
			{
				Toggle toggle = _toggle;
				bool flag2 = (toggle.isOn = !toggle.m_IsOn);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5C")]
		[Cpp2IlInjected.Address(RVA = "0xFA6BB0", Offset = "0xFA55B0", VA = "0x180FA6BB0")]
		[IteratorStateMachine(typeof(_003COnTogglePressedGamepad_003Ed__17))]
		private IEnumerator OnTogglePressedGamepad()
		{
			int _003C_003E1__state = default(int);
			_003COnTogglePressedGamepad_003Ed__17 _003COnTogglePressedGamepad_003Ed__ = new _003COnTogglePressedGamepad_003Ed__17(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnTogglePressedGamepad_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5D")]
		[Cpp2IlInjected.Address(RVA = "0x863470", Offset = "0x861E70", VA = "0x180863470")]
		public MainMenuToggleButton()
		{
		}
	}
}
