using Cpp2IlInjected;
using Mdl.Utils;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000257")]
	[RequiredAllNotNull]
	[RequireComponent(typeof(InputTextBase))]
	[RequireComponent(typeof(TemplateButton))]
	public class FocusNavigationElementInputText : FocusNavigationElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000A8F")]
		[SerializeField]
		private Color _textNormalColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000A90")]
		[SerializeField]
		private Color _textHighlightColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000A91")]
		private InputTextBase _inputTextBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000A92")]
		private TemplateButton _templateButton;

		[Cpp2IlInjected.Token(Token = "0x6000EF0")]
		[Cpp2IlInjected.Address(RVA = "0x16630A0", Offset = "0x1661AA0", VA = "0x1816630A0")]
		private new void Awake()
		{
			InputTextBase inputTextBase = (_inputTextBase = GetComponent<InputTextBase>());
			TemplateButton templateButton = (_templateButton = GetComponent<TemplateButton>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EF1")]
		[Cpp2IlInjected.Address(RVA = "0x1663660", Offset = "0x1662060", VA = "0x181663660")]
		private new void Start()
		{
			//Discarded unreachable code: IL_000d
			((TMP_InputField)_inputTextBase).m_ResetOnDeActivation = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EF2")]
		[Cpp2IlInjected.Address(RVA = "0x1663280", Offset = "0x1661C80", VA = "0x181663280")]
		private new void OnEnable()
		{
			//Discarded unreachable code: IL_0041
			TMP_InputField.SelectionEvent onSelect = ((TMP_InputField)_inputTextBase).m_OnSelect;
			UnityAction<string> unityAction = (UnityAction<string>)(object)new UnityAction<T0>(OnSelect);
			((UnityEvent<T0>)(object)onSelect).AddListener((UnityAction<>)(object)unityAction);
			TMP_InputField.SubmitEvent onEndEdit = ((TMP_InputField)_inputTextBase).m_OnEndEdit;
			UnityAction<string> unityAction2 = (UnityAction<string>)(object)new UnityAction<T0>(OnEndEdit);
			((UnityEvent<T0>)(object)onEndEdit).AddListener((UnityAction<>)(object)unityAction2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EF3")]
		[Cpp2IlInjected.Address(RVA = "0x1663160", Offset = "0x1661B60", VA = "0x181663160")]
		private new void OnDisable()
		{
			//Discarded unreachable code: IL_0041
			TMP_InputField.SelectionEvent onSelect = ((TMP_InputField)_inputTextBase).m_OnSelect;
			UnityAction<string> unityAction = (UnityAction<string>)(object)new UnityAction<T0>(OnSelect);
			((UnityEvent<T0>)(object)onSelect).RemoveListener((UnityAction<>)(object)unityAction);
			TMP_InputField.SubmitEvent onEndEdit = ((TMP_InputField)_inputTextBase).m_OnEndEdit;
			UnityAction<string> unityAction2 = (UnityAction<string>)(object)new UnityAction<T0>(OnEndEdit);
			((UnityEvent<T0>)(object)onEndEdit).RemoveListener((UnityAction<>)(object)unityAction2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EF4")]
		[Cpp2IlInjected.Address(RVA = "0x1663600", Offset = "0x1662000", VA = "0x181663600", Slot = "20")]
		public override void SetFocus()
		{
			//Discarded unreachable code: IL_0021
			TMP_Text textComponent = ((TMP_InputField)_inputTextBase).m_TextComponent;
			Color color = (textComponent.color = _textHighlightColor);
			base.SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EF5")]
		[Cpp2IlInjected.Address(RVA = "0x16634E0", Offset = "0x1661EE0", VA = "0x1816634E0", Slot = "19")]
		public override void RemoveFocus()
		{
			//Discarded unreachable code: IL_003d
			TMP_Text textComponent = ((TMP_InputField)_inputTextBase).m_TextComponent;
			Color color = (textComponent.color = _textNormalColor);
			_inputTextBase.DeactivateInputField(clearSelection: true);
			TemplateButton templateButton = _templateButton;
			int num = ((templateButton.IsSelected = false) ? 1 : 0);
			base.RemoveFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EF6")]
		[Cpp2IlInjected.Address(RVA = "0x1663120", Offset = "0x1661B20", VA = "0x181663120", Slot = "22")]
		public override void Click(RedirectionType redirectionType)
		{
			//Discarded unreachable code: IL_000c
			_inputTextBase.ActivateVirtualKeyboard();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EF7")]
		[Cpp2IlInjected.Address(RVA = "0x1663440", Offset = "0x1661E40", VA = "0x181663440")]
		private void OnSelect(string what)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EF8")]
		[Cpp2IlInjected.Address(RVA = "0x16633A0", Offset = "0x1661DA0", VA = "0x1816633A0")]
		private void OnEndEdit(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EF9")]
		[Cpp2IlInjected.Address(RVA = "0x1663690", Offset = "0x1662090", VA = "0x181663690")]
		public FocusNavigationElementInputText()
		{
			Color black = Color.black;
			Color blue = Color.blue;
			base._002Ector();
		}
	}
}
