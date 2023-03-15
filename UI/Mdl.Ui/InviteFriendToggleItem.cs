using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004BD")]
	public class InviteFriendToggleItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40018F2")]
		[SerializeField]
		private Toggle _toggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40018F3")]
		[SerializeField]
		private TextBase _tfLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40018F4")]
		[SerializeField]
		private TextBase _tfDesc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40018F5")]
		[SerializeField]
		private Image _mcOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40018F6")]
		[SerializeField]
		private Image _mcOff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40018F7")]
		[SerializeField]
		private Color _blueColor;

		[Cpp2IlInjected.Token(Token = "0x6001EE9")]
		[Cpp2IlInjected.Address(RVA = "0xD31F30", Offset = "0xD30930", VA = "0x180D31F30")]
		private void Start()
		{
			//Discarded unreachable code: IL_00b5
			Toggle.ToggleEvent onValueChanged = _toggle.onValueChanged;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
			Toggle toggle = _toggle;
			Image mcOn = _mcOn;
			bool isOn = toggle.m_IsOn;
			mcOn.gameObject.SetActive(isOn);
			GameObject gameObject = _mcOff.gameObject;
			bool active = !isOn;
			gameObject.SetActive(active);
			TextMeshProUGUI textComponent = _tfLabel.TextComponent;
			if (isOn)
			{
				Color white = Color.white;
			}
			Color color = (textComponent.color = _blueColor);
			TextMeshProUGUI textComponent2 = _tfDesc.TextComponent;
			if (isOn)
			{
				Color white2 = Color.white;
			}
			Color color2 = (textComponent2.color = _blueColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6001EEA")]
		[Cpp2IlInjected.Address(RVA = "0xD31D40", Offset = "0xD30740", VA = "0x180D31D40")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0021
			Toggle.ToggleEvent onValueChanged = _toggle.onValueChanged;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6001EEB")]
		[Cpp2IlInjected.Address(RVA = "0xD31E00", Offset = "0xD30800", VA = "0x180D31E00")]
		private void OnValueChangedHandler(bool isOn)
		{
			//Discarded unreachable code: IL_006e
			_mcOn.gameObject.SetActive(isOn);
			_mcOff.gameObject.SetActive(isOn);
			TextMeshProUGUI textComponent = _tfLabel.TextComponent;
			if (isOn)
			{
				Color white = Color.white;
			}
			Color color = (textComponent.color = _blueColor);
			TextMeshProUGUI textComponent2 = _tfDesc.TextComponent;
			if (isOn)
			{
				Color white2 = Color.white;
			}
			Color color2 = (textComponent2.color = _blueColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6001EEC")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public InviteFriendToggleItem()
		{
		}
	}
}
