using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006BE")]
	[RequireComponent(typeof(Toggle))]
	public class ToggleText : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400261B")]
		public TextBase LabelOFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400261C")]
		public TextBase LabelON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400261D")]
		private Toggle _toggle;

		[Cpp2IlInjected.Token(Token = "0x6002B7B")]
		[Cpp2IlInjected.Address(RVA = "0x17F1CD0", Offset = "0x17F06D0", VA = "0x1817F1CD0")]
		private void Awake()
		{
			Toggle toggle = (_toggle = GetComponent<Toggle>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B7C")]
		[Cpp2IlInjected.Address(RVA = "0x17F1DE0", Offset = "0x17F07E0", VA = "0x1817F1DE0")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0061
			Toggle.ToggleEvent onValueChanged = _toggle.onValueChanged;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
			Toggle toggle = _toggle;
			TextBase labelOFF = LabelOFF;
			bool isOn = toggle.m_IsOn;
			GameObject gameObject = labelOFF.gameObject;
			bool active = !isOn;
			gameObject.SetActive(active);
			LabelON.gameObject.SetActive(isOn);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B7D")]
		[Cpp2IlInjected.Address(RVA = "0x17F1D20", Offset = "0x17F0720", VA = "0x1817F1D20")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0021
			Toggle.ToggleEvent onValueChanged = _toggle.onValueChanged;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B7E")]
		[Cpp2IlInjected.Address(RVA = "0x17F1F00", Offset = "0x17F0900", VA = "0x1817F1F00")]
		public void OnValueChangedHandler(bool value)
		{
			//Discarded unreachable code: IL_0023
			LabelOFF.gameObject.SetActive(value);
			LabelON.gameObject.SetActive(value);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B7F")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ToggleText()
		{
		}
	}
}
