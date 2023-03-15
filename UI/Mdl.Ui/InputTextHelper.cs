using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001F6")]
	[RequireComponent(typeof(InputTextBase))]
	public class InputTextHelper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400088D")]
		[SerializeField]
		public UnityEvent OnEmpty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400088E")]
		[SerializeField]
		public UnityEvent OnFilled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400088F")]
		private InputTextBase _inputTextBase;

		[Cpp2IlInjected.Token(Token = "0x6000C98")]
		[Cpp2IlInjected.Address(RVA = "0xD238D0", Offset = "0xD222D0", VA = "0x180D238D0")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0068
			//IL_0010: Expected O, but got I4
			InputTextBase inputTextBase = _inputTextBase;
			int num = 0;
			if (inputTextBase == (Object)num)
			{
				InputTextBase inputTextBase2 = (_inputTextBase = GetComponent<InputTextBase>());
			}
			TMP_InputField.OnChangeEvent onValueChanged = ((TMP_InputField)_inputTextBase).m_OnValueChanged;
			UnityAction<string> unityAction = (UnityAction<string>)(object)new UnityAction<T0>(OnValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
			TMP_InputField.SubmitEvent onEndEdit = ((TMP_InputField)_inputTextBase).m_OnEndEdit;
			UnityAction<string> unityAction2 = (UnityAction<string>)(object)new UnityAction<T0>(OnValueChangedHandler);
			((UnityEvent<T0>)(object)onEndEdit).AddListener((UnityAction<>)(object)unityAction2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C99")]
		[Cpp2IlInjected.Address(RVA = "0xD237C0", Offset = "0xD221C0", VA = "0x180D237C0")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0041
			TMP_InputField.OnChangeEvent onValueChanged = ((TMP_InputField)_inputTextBase).m_OnValueChanged;
			UnityAction<string> unityAction = (UnityAction<string>)(object)new UnityAction<T0>(OnValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
			TMP_InputField.SubmitEvent onEndEdit = ((TMP_InputField)_inputTextBase).m_OnEndEdit;
			UnityAction<string> unityAction2 = (UnityAction<string>)(object)new UnityAction<T0>(OnValueChangedHandler);
			((UnityEvent<T0>)(object)onEndEdit).RemoveListener((UnityAction<>)(object)unityAction2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9A")]
		[Cpp2IlInjected.Address(RVA = "0xD23A50", Offset = "0xD22450", VA = "0x180D23A50")]
		private void OnValueChangedHandler(string text)
		{
			if (text == null)
			{
			}
			OnEmpty?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9B")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public InputTextHelper()
		{
		}
	}
}
