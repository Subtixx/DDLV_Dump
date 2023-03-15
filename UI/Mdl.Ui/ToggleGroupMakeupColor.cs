using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000769")]
	public class ToggleGroupMakeupColor : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002B47")]
		[SerializeField]
		private Toggle _toggleMakeupMainColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002B48")]
		[SerializeField]
		private Toggle _toggleMakeupSecondColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002B49")]
		[SerializeField]
		private Toggle _toggleMakeupThirdColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002B4A")]
		[HideInInspector]
		public WardrobeAppearanceContent AppearanceContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002B4B")]
		[HideInInspector]
		public MakeupColor MakeupColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002B4C")]
		[SerializeField]
		private FocusNavigationElement _navElementMain;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002B4D")]
		[SerializeField]
		private FocusNavigationElement _navElementSec;

		[Cpp2IlInjected.Token(Token = "0x170006C1")]
		public Toggle ToggleMakeupMainColor
		{
			[Cpp2IlInjected.Token(Token = "0x6002F77")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _toggleMakeupMainColor;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C2")]
		public Toggle ToggleMakeupSecondColor
		{
			[Cpp2IlInjected.Token(Token = "0x6002F78")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _toggleMakeupSecondColor;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C3")]
		public Toggle ToggleMakeupThirdColor
		{
			[Cpp2IlInjected.Token(Token = "0x6002F79")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _toggleMakeupThirdColor;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F7A")]
		[Cpp2IlInjected.Address(RVA = "0x17F1890", Offset = "0x17F0290", VA = "0x1817F1890")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_00d1
			Toggle.ToggleEvent onValueChanged = _toggleMakeupMainColor.onValueChanged;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnMakeupMainValueChanged);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
			Toggle.ToggleEvent onValueChanged2 = _toggleMakeupSecondColor.onValueChanged;
			UnityAction<bool> unityAction2 = (UnityAction<bool>)(object)new UnityAction<T0>(OnMakeupSecondValueChanged);
			((UnityEvent<T0>)(object)onValueChanged2).RemoveListener((UnityAction<>)(object)unityAction2);
			Toggle.ToggleEvent onValueChanged3 = _toggleMakeupThirdColor.onValueChanged;
			UnityAction<bool> unityAction3 = (UnityAction<bool>)(object)new UnityAction<T0>(OnMakeupThirdValueChanged);
			((UnityEvent<T0>)(object)onValueChanged3).RemoveListener((UnityAction<>)(object)unityAction3);
			Toggle.ToggleEvent onValueChanged4 = _toggleMakeupMainColor.onValueChanged;
			UnityAction<bool> unityAction4 = (UnityAction<bool>)(object)new UnityAction<T0>(OnMakeupMainValueChanged);
			((UnityEvent<T0>)(object)onValueChanged4).AddListener((UnityAction<>)(object)unityAction4);
			Toggle.ToggleEvent onValueChanged5 = _toggleMakeupSecondColor.onValueChanged;
			UnityAction<bool> unityAction5 = (UnityAction<bool>)(object)new UnityAction<T0>(OnMakeupSecondValueChanged);
			((UnityEvent<T0>)(object)onValueChanged5).AddListener((UnityAction<>)(object)unityAction5);
			Toggle.ToggleEvent onValueChanged6 = _toggleMakeupThirdColor.onValueChanged;
			UnityAction<bool> unityAction6 = (UnityAction<bool>)(object)new UnityAction<T0>(OnMakeupThirdValueChanged);
			((UnityEvent<T0>)(object)onValueChanged6).AddListener((UnityAction<>)(object)unityAction6);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F7B")]
		[Cpp2IlInjected.Address(RVA = "0x17F1710", Offset = "0x17F0110", VA = "0x1817F1710")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0065
			Toggle.ToggleEvent onValueChanged = _toggleMakeupMainColor.onValueChanged;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnMakeupMainValueChanged);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
			Toggle.ToggleEvent onValueChanged2 = _toggleMakeupSecondColor.onValueChanged;
			UnityAction<bool> unityAction2 = (UnityAction<bool>)(object)new UnityAction<T0>(OnMakeupSecondValueChanged);
			((UnityEvent<T0>)(object)onValueChanged2).RemoveListener((UnityAction<>)(object)unityAction2);
			Toggle.ToggleEvent onValueChanged3 = _toggleMakeupThirdColor.onValueChanged;
			UnityAction<bool> unityAction3 = (UnityAction<bool>)(object)new UnityAction<T0>(OnMakeupThirdValueChanged);
			((UnityEvent<T0>)(object)onValueChanged3).RemoveListener((UnityAction<>)(object)unityAction3);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F7C")]
		[Cpp2IlInjected.Address(RVA = "0x17F1B20", Offset = "0x17F0520", VA = "0x1817F1B20")]
		private void OnMakeupMainValueChanged(bool isShown)
		{
			//Discarded unreachable code: IL_0027
			WardrobeAppearanceContent appearanceContent = AppearanceContent;
			FocusNavigationElement navElementMain = _navElementMain;
			MakeupColor makeupColor = MakeupColor;
			Toggle toggleMakeupMainColor = _toggleMakeupMainColor;
			appearanceContent.OnMakeupMainColorToggle(isShown, toggleMakeupMainColor, makeupColor, navElementMain);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F7D")]
		[Cpp2IlInjected.Address(RVA = "0x17F1B60", Offset = "0x17F0560", VA = "0x1817F1B60")]
		private void OnMakeupSecondValueChanged(bool isShown)
		{
			//Discarded unreachable code: IL_0027
			WardrobeAppearanceContent appearanceContent = AppearanceContent;
			FocusNavigationElement navElementSec = _navElementSec;
			MakeupColor makeupColor = MakeupColor;
			Toggle toggleMakeupSecondColor = _toggleMakeupSecondColor;
			appearanceContent.OnMakeupSecondColorPanelToggle(isShown, toggleMakeupSecondColor, makeupColor, navElementSec);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F7E")]
		[Cpp2IlInjected.Address(RVA = "0x17F1BA0", Offset = "0x17F05A0", VA = "0x1817F1BA0")]
		private void OnMakeupThirdValueChanged(bool isShown)
		{
			//Discarded unreachable code: IL_0027
			WardrobeAppearanceContent appearanceContent = AppearanceContent;
			FocusNavigationElement navElementSec = _navElementSec;
			MakeupColor makeupColor = MakeupColor;
			Toggle toggleMakeupThirdColor = _toggleMakeupThirdColor;
			appearanceContent.OnMakeupThirdColorPanelToggle(isShown, toggleMakeupThirdColor, makeupColor, navElementSec);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F7F")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ToggleGroupMakeupColor()
		{
		}
	}
}
