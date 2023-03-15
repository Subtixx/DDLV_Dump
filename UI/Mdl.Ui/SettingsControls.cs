using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Gameloft.Localization.Core;
using Mdl.Cheats;
using Mdl.Gestures;
using Mdl.Systems;
using Meta.Util;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006A0")]
	public class SettingsControls : SettingsMenuPanel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400251D")]
		[SerializeField]
		private Toggle _invertCameraToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400251E")]
		[SerializeField]
		private Toggle _clickToMove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400251F")]
		[SerializeField]
		private GameObject _clickToMoveContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002520")]
		[SerializeField]
		private TMP_Text _mouseSensitivityLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002521")]
		[SerializeField]
		private GameObject _mouseSensitivitySliderContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002522")]
		[SerializeField]
		private Slider _mouseSensitivitySlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002523")]
		[SerializeField]
		private Slider _controllerSensitivitySlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002524")]
		[SerializeField]
		private Toggle _controllerVibrationToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002525")]
		[SerializeField]
		private GameObject _keyboardLayoutContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002526")]
		[SerializeField]
		private ComboBoxTMP _keyboardLayoutComboBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002527")]
		private List<(int, string)> _invertCameraElements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002528")]
		private List<(int, string)> _controllerVibrationElements;

		[Cpp2IlInjected.Token(Token = "0x1700063F")]
		public override FocusNavigationElement FirstFocusNavigationElement
		{
			[Cpp2IlInjected.Token(Token = "0x6002AA7")]
			[Cpp2IlInjected.Address(RVA = "0x1262740", Offset = "0x1261140", VA = "0x181262740", Slot = "4")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _invertCameraToggle.GetComponentInChildren<FocusNavigationElement>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AA8")]
		[Cpp2IlInjected.Address(RVA = "0x1261F80", Offset = "0x1260980", VA = "0x181261F80")]
		public void OnEnable()
		{
			//Discarded unreachable code: IL_00d4
			Toggle.ToggleEvent onValueChanged = _invertCameraToggle.onValueChanged;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnInvertCameraChanged);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
			Toggle.ToggleEvent onValueChanged2 = _clickToMove.onValueChanged;
			UnityAction<bool> unityAction2 = (UnityAction<bool>)(object)new UnityAction<T0>(OnClickToMoveChanged);
			((UnityEvent<T0>)(object)onValueChanged2).AddListener((UnityAction<>)(object)unityAction2);
			Slider.SliderEvent onValueChanged3 = _mouseSensitivitySlider.m_OnValueChanged;
			UnityAction<float> unityAction3 = (UnityAction<float>)(object)new UnityAction<T0>(OnMouseSensitivityChanged);
			((UnityEvent<T0>)(object)onValueChanged3).AddListener((UnityAction<>)(object)unityAction3);
			Slider.SliderEvent onValueChanged4 = _controllerSensitivitySlider.m_OnValueChanged;
			UnityAction<float> unityAction4 = (UnityAction<float>)(object)new UnityAction<T0>(OnControllerSensitivityChanged);
			((UnityEvent<T0>)(object)onValueChanged4).AddListener((UnityAction<>)(object)unityAction4);
			Toggle.ToggleEvent onValueChanged5 = _controllerVibrationToggle.onValueChanged;
			UnityAction<bool> unityAction5 = (UnityAction<bool>)(object)new UnityAction<T0>(OnControllerVibrationChanged);
			((UnityEvent<T0>)(object)onValueChanged5).AddListener((UnityAction<>)(object)unityAction5);
			ComboBoxTMP keyboardLayoutComboBox = _keyboardLayoutComboBox;
			ComboBoxTMP.ValueChanged value = OnKeyboardLayoutChanged;
			keyboardLayoutComboBox.OnValueChanged += value;
			(ItemType, ActivityItemType?) itemGeneratorParameters = ((ItemType, ActivityItemType?))((IItemGeneratorOwner)this).GetItemGeneratorParameters();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AA9")]
		[Cpp2IlInjected.Address(RVA = "0x1261CB0", Offset = "0x12606B0", VA = "0x181261CB0")]
		public void OnDisable()
		{
			//Discarded unreachable code: IL_00cc
			Toggle.ToggleEvent onValueChanged = _invertCameraToggle.onValueChanged;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnInvertCameraChanged);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
			Toggle.ToggleEvent onValueChanged2 = _clickToMove.onValueChanged;
			UnityAction<bool> unityAction2 = (UnityAction<bool>)(object)new UnityAction<T0>(OnClickToMoveChanged);
			((UnityEvent<T0>)(object)onValueChanged2).RemoveListener((UnityAction<>)(object)unityAction2);
			Slider.SliderEvent onValueChanged3 = _mouseSensitivitySlider.m_OnValueChanged;
			UnityAction<float> unityAction3 = (UnityAction<float>)(object)new UnityAction<T0>(OnMouseSensitivityChanged);
			((UnityEvent<T0>)(object)onValueChanged3).RemoveListener((UnityAction<>)(object)unityAction3);
			Slider.SliderEvent onValueChanged4 = _controllerSensitivitySlider.m_OnValueChanged;
			UnityAction<float> unityAction4 = (UnityAction<float>)(object)new UnityAction<T0>(OnControllerSensitivityChanged);
			((UnityEvent<T0>)(object)onValueChanged4).RemoveListener((UnityAction<>)(object)unityAction4);
			Toggle.ToggleEvent onValueChanged5 = _controllerVibrationToggle.onValueChanged;
			UnityAction<bool> unityAction5 = (UnityAction<bool>)(object)new UnityAction<T0>(OnControllerVibrationChanged);
			((UnityEvent<T0>)(object)onValueChanged5).RemoveListener((UnityAction<>)(object)unityAction5);
			ComboBoxTMP keyboardLayoutComboBox = _keyboardLayoutComboBox;
			ComboBoxTMP.ValueChanged value = OnKeyboardLayoutChanged;
			keyboardLayoutComboBox.OnValueChanged -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AAA")]
		[Cpp2IlInjected.Address(RVA = "0x1261AD0", Offset = "0x12604D0", VA = "0x181261AD0", Slot = "5")]
		public override void LoadGameSettings()
		{
			//Discarded unreachable code: IL_0095
			Toggle invertCameraToggle = _invertCameraToggle;
			bool flag = (invertCameraToggle.isOn = base.Settings.InvertCamera);
			Toggle clickToMove = _clickToMove;
			bool flag2 = (clickToMove.isOn = base.Settings.ClickToMove);
			Slider mouseSensitivitySlider = _mouseSensitivitySlider;
			float num = (mouseSensitivitySlider.value = base.Settings.CameraMouseSensitivity);
			SetupKeyboardLayout();
			Slider controllerSensitivitySlider = _controllerSensitivitySlider;
			num = (controllerSensitivitySlider.value = base.Settings.CameraGamepadSensitivity);
			Toggle controllerVibrationToggle = _controllerVibrationToggle;
			bool flag3 = (controllerVibrationToggle.isOn = base.Settings.GamepadVibration);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AAB")]
		[Cpp2IlInjected.Address(RVA = "0x12623A0", Offset = "0x1260DA0", VA = "0x1812623A0")]
		private void SetupKeyboardLayout()
		{
			//Discarded unreachable code: IL_008b, IL_00b6
			int index;
			string[] values;
			string text2 = default(string);
			while (true)
			{
				Dictionary<KeyboardLayout, string> keyboardLayoutMap = CustomizedPlayerInputSystem.KeyboardLayoutMap;
				KeyboardLayout currentKeyboardLayout = base.Settings.KeyboardLayout;
				Func<KeyValuePair<KeyboardLayout, string>, bool> func = (Func<KeyValuePair<KeyboardLayout, string>, bool>)(object)(Func<T, TResult>)delegate
				{
					KeyboardLayout keyboardLayout = currentKeyboardLayout;
					bool result = default(bool);
					return result;
				};
				index = MoreLinq.FindIndex<KeyValuePair<KeyboardLayout, string>>((IEnumerable<>)keyboardLayoutMap, (Func<, >)(object)func);
				values = new string[((Dictionary<TKey, TValue>)(object)keyboardLayoutMap).Count];
				Localizator _003CLocalizator_003Ek__BackingField = SystemRoot.Instance._localizationManager.Localizator;
				int num = 0;
				int num2 = 0;
				int count = ((Dictionary<TKey, TValue>)(object)keyboardLayoutMap).Count;
				if (num2 >= count)
				{
					break;
				}
				string text = "menu.settings_controls_keyboard_layout_" + "default";
				if (text2 == null || text2 != null)
				{
					throw new IndexOutOfRangeException();
				}
			}
			_keyboardLayoutComboBox.Init("Keyboard", index, values);
			_keyboardLayoutComboBox._dropdown.RefreshShownValue();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AAC")]
		[Cpp2IlInjected.Address(RVA = "0x1262260", Offset = "0x1260C60", VA = "0x181262260")]
		private void OnInvertCameraChanged(bool invertCameraIndex)
		{
			//Discarded unreachable code: IL_000d
			base.Settings.InvertCamera = invertCameraIndex;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AAD")]
		[Cpp2IlInjected.Address(RVA = "0x1261C10", Offset = "0x1260610", VA = "0x181261C10")]
		private void OnClickToMoveChanged(bool clickToMove)
		{
			//Discarded unreachable code: IL_000d
			base.Settings.ClickToMove = clickToMove;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AAE")]
		[Cpp2IlInjected.Address(RVA = "0x1262360", Offset = "0x1260D60", VA = "0x181262360")]
		private void OnMouseSensitivityChanged(float mouseSensitivity)
		{
			//Discarded unreachable code: IL_000d
			base.Settings.CameraMouseSensitivity = mouseSensitivity;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AAF")]
		[Cpp2IlInjected.Address(RVA = "0x1261C40", Offset = "0x1260640", VA = "0x181261C40")]
		private void OnControllerSensitivityChanged(float gamepadSensitivity)
		{
			//Discarded unreachable code: IL_000d
			base.Settings.CameraGamepadSensitivity = gamepadSensitivity;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AB0")]
		[Cpp2IlInjected.Address(RVA = "0x1261C80", Offset = "0x1260680", VA = "0x181261C80")]
		private void OnControllerVibrationChanged(bool gamepadVibrationIndex)
		{
			//Discarded unreachable code: IL_000d
			base.Settings.GamepadVibration = gamepadVibrationIndex;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AB1")]
		[Cpp2IlInjected.Address(RVA = "0x1262290", Offset = "0x1260C90", VA = "0x181262290")]
		private void OnKeyboardLayoutChanged(int keyboardLayoutIndex)
		{
			//Discarded unreachable code: IL_0019
			KeyboardLayout keyboardLayout = Enumerable.ElementAt<KeyboardLayout>((IEnumerable<>)(object)((Dictionary<TKey, TValue>)(object)CustomizedPlayerInputSystem.KeyboardLayoutMap).get_Keys(), keyboardLayoutIndex);
			GameSettingsSystem settings = base.Settings;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AB2")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public SettingsControls()
		{
		}
	}
}
