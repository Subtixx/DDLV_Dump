using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200069E")]
	[RequireComponent(typeof(Toggle))]
	[RequireComponent(typeof(RectTransform))]
	public class DropDownMenuItem : CustomButton
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200069F")]
		public class State
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400251B")]
			public Sprite BackgroundSprite;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400251C")]
			public Color LabelColor;

			[Cpp2IlInjected.Token(Token = "0x6002AA6")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public State()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002511")]
		[SerializeField]
		[Header("Item Position")]
		private Vector2 _notHighlightMargin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002512")]
		[SerializeField]
		private Vector2 _highlightMargin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002513")]
		[SerializeField]
		[Header("Item States")]
		private Image _background;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002514")]
		[SerializeField]
		private State NormalState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002515")]
		[SerializeField]
		private State SelectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4002516")]
		[SerializeField]
		private State HighlightState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4002517")]
		[SerializeField]
		private State SelectedHighlightState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4002518")]
		private RectTransform _rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002519")]
		private Toggle _toggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400251A")]
		private TMP_Text _itemLabel;

		[Cpp2IlInjected.Token(Token = "0x6002AA0")]
		[Cpp2IlInjected.Address(RVA = "0xF209B0", Offset = "0xF1F3B0", VA = "0x180F209B0")]
		private void Awake()
		{
			((TemplateButton)this).UseHighlightWhenSelected = true;
			RectTransform rectTransform = (_rectTransform = GetComponent<RectTransform>());
			Toggle toggle = (_toggle = GetComponent<Toggle>());
			TMP_Text tMP_Text = (_itemLabel = GetComponentInChildren<TMP_Text>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AA1")]
		[Cpp2IlInjected.Address(RVA = "0xF20C40", Offset = "0xF1F640", VA = "0x180F20C40", Slot = "12")]
		protected override void OnEnable()
		{
			//Discarded unreachable code: IL_00a5
			base.OnEnable();
			Toggle.ToggleEvent onValueChanged = _toggle.onValueChanged;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnToggleValueChanged);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
			UnityEvent onHighlighted = OnHighlighted;
			UnityAction call = UpdateVisuals;
			onHighlighted.AddListener(call);
			UnityEvent onDehighlighted = OnDehighlighted;
			UnityAction call2 = UpdateVisuals;
			onDehighlighted.AddListener(call2);
			UnityEvent onSelected = OnSelected;
			UnityAction call3 = UpdateVisuals;
			onSelected.AddListener(call3);
			UnityEvent onDeselected = OnDeselected;
			UnityAction call4 = UpdateVisuals;
			onDeselected.AddListener(call4);
			UpdateVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AA2")]
		[Cpp2IlInjected.Address(RVA = "0xF20A60", Offset = "0xF1F460", VA = "0x180F20A60", Slot = "13")]
		protected override void OnDisable()
		{
			//Discarded unreachable code: IL_009f
			Toggle.ToggleEvent onValueChanged = _toggle.onValueChanged;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnToggleValueChanged);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
			UnityEvent onHighlighted = OnHighlighted;
			UnityAction call = UpdateVisuals;
			onHighlighted.RemoveListener(call);
			UnityEvent onDehighlighted = OnDehighlighted;
			UnityAction call2 = UpdateVisuals;
			onDehighlighted.RemoveListener(call2);
			UnityEvent onSelected = OnSelected;
			UnityAction call3 = UpdateVisuals;
			onSelected.RemoveListener(call3);
			UnityEvent onDeselected = OnDeselected;
			UnityAction call4 = UpdateVisuals;
			onDeselected.RemoveListener(call4);
			base.OnDisable();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AA3")]
		[Cpp2IlInjected.Address(RVA = "0xF20E30", Offset = "0xF1F830", VA = "0x180F20E30")]
		private void OnToggleValueChanged(bool newValue)
		{
			UpdateVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AA4")]
		[Cpp2IlInjected.Address(RVA = "0xF20E40", Offset = "0xF1F840", VA = "0x180F20E40")]
		private void UpdateVisuals()
		{
			//Discarded unreachable code: IL_00a8
			//IL_006b: Expected O, but got I4
			bool isHighlighted = ((TemplateButton)this)._isHighlighted;
			if (isHighlighted)
			{
			}
			float y = _notHighlightMargin.y;
			Toggle toggle = _toggle;
			if (!isHighlighted || !toggle.m_IsOn)
			{
			}
			State selectedState = default(State);
			if (toggle.m_IsOn)
			{
				selectedState = SelectedState;
			}
			RectTransform rectTransform = _rectTransform;
			_rectTransform.SetRight(y);
			Image background = _background;
			Sprite backgroundSprite = selectedState.BackgroundSprite;
			int num = 0;
			if (backgroundSprite != (UnityEngine.Object)num)
			{
				Color white = Color.white;
			}
			Image background2 = _background;
			Sprite sprite = (background2.sprite = selectedState.BackgroundSprite);
			TMP_Text itemLabel = _itemLabel;
			Color color = (itemLabel.color = selectedState.LabelColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AA5")]
		[Cpp2IlInjected.Address(RVA = "0x863470", Offset = "0x861E70", VA = "0x180863470")]
		public DropDownMenuItem()
		{
		}
	}
}
