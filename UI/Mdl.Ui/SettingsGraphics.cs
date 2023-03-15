using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Epic.OnlineServices.RTCAudio;
using Gameloft.Localization.Formatter;
using Mdl.Cheats;
using Mdl.Platform;
using Mdl.Systems;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006AE")]
	public class SettingsGraphics : SettingsMenuPanel
	{
		[Cpp2IlInjected.Token(Token = "0x4002598")]
		private const int MinWidth = 640;

		[Cpp2IlInjected.Token(Token = "0x4002599")]
		private const int MinHeight = 480;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400259A")]
		private List<string> _displayModeLabels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400259B")]
		private Dictionary<GameSettingsSystem.DisplayModeEnum, FullScreenMode> _displayModes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400259C")]
		private List<(int, UnityEngine.Display)> _displays;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400259D")]
		private Resolution[] _resolutions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400259E")]
		private List<(string str, float scale)> _resolutionScales;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400259F")]
		private Resolution[] _refreshRates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40025A0")]
		private List<string> _graphicPresets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40025A1")]
		private List<string> _shadowResolutions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40025A2")]
		private List<(string, float)> _distanceQualities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40025A3")]
		private List<(int, string)> _textureQualities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40025A4")]
		private List<(int, string)> _vSyncCounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40025A5")]
		[SerializeField]
		private ScrollRect _scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40025A6")]
		[SerializeField]
		private SettingsItemGroup _displayModeItemGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40025A7")]
		[SerializeField]
		private SettingsItemGroup _displayItemGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40025A8")]
		[SerializeField]
		private SettingsItemGroup _resolutionItemGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40025A9")]
		[SerializeField]
		private SettingsItemGroup _resolutionScaleItemGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40025AA")]
		[SerializeField]
		private SettingsItemGroup _refreshRateItemGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40025AB")]
		[SerializeField]
		private SettingsItemGroup _graphicPresetItemGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40025AC")]
		[SerializeField]
		private SettingsItemGroup _shadowResolutionItemGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40025AD")]
		[SerializeField]
		private SettingsItemGroup _distanceQualityItemGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40025AE")]
		[SerializeField]
		private SettingsItemGroup _textureQualityItemGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40025AF")]
		[SerializeField]
		private SettingsItemGroup _vSyncCountItemGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40025B0")]
		[SerializeField]
		private SettingsItemGroup _disableCameraShakesItemGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40025B1")]
		[SerializeField]
		private SettingsItemGroup _disableFlashesItemGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40025B2")]
		[SerializeField]
		private ComboBoxTMP _displayModeComboBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40025B3")]
		[SerializeField]
		private ComboBoxTMP _displayComboBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40025B4")]
		[SerializeField]
		private ComboBoxTMP _resolutionComboBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40025B5")]
		[SerializeField]
		private ComboBoxTMP _resolutionScaleComboBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40025B6")]
		[SerializeField]
		private ComboBoxTMP _refreshRateComboBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40025B7")]
		[SerializeField]
		private ComboBoxTMP _graphicPresetComboBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40025B8")]
		[SerializeField]
		private ComboBoxTMP _shadowResolutionComboBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40025B9")]
		[SerializeField]
		private ComboBoxTMP _distanceQualityComboBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40025BA")]
		[SerializeField]
		private ComboBoxTMP _textureQualityComboBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40025BB")]
		[SerializeField]
		private Toggle _vSyncCountToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40025BC")]
		[SerializeField]
		private Slider _gammaSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40025BD")]
		[SerializeField]
		private Toggle _disableCameraShakesToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40025BE")]
		[SerializeField]
		private Toggle _disableFlashesToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40025BF")]
		[SerializeField]
		private Slider _timeOfDayOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40025C0")]
		[SerializeField]
		private TextBase _timeOfDayOffsetValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40025C1")]
		private int currentResolutionIndex;

		[Cpp2IlInjected.Token(Token = "0x40025C2")]
		private static List<Resolution> _resolutionMacOS;

		[Cpp2IlInjected.Token(Token = "0x17000645")]
		public override FocusNavigationElement FirstFocusNavigationElement
		{
			[Cpp2IlInjected.Token(Token = "0x6002AE4")]
			[Cpp2IlInjected.Address(RVA = "0x126B3A0", Offset = "0x1269DA0", VA = "0x18126B3A0", Slot = "4")]
			get
			{
				//Discarded unreachable code: IL_0016
				int num = 0;
				if (PlatformUtils.UseGraphicSettings())
				{
				}
				return _disableCameraShakesToggle.GetComponentInChildren<FocusNavigationElement>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AE5")]
		[Cpp2IlInjected.Address(RVA = "0x1268930", Offset = "0x1267330", VA = "0x181268930")]
		private void RefreshComboBoxes()
		{
			//Discarded unreachable code: IL_0044, IL_006f, IL_009c, IL_00b1, IL_00d2, IL_00eb, IL_0103, IL_011c, IL_0179, IL_0192, IL_01bd, IL_01d6, IL_01e9, IL_0202, IL_0224, IL_022c, IL_023b, IL_0254, IL_026e, IL_0283, IL_028b, IL_02a4, IL_02b7, IL_02c9, IL_02d1, IL_02ea, IL_02fd, IL_0312, IL_0350, IL_0369
			//IL_013d: Expected O, but got I4
			int num = 0;
			if (!PlatformUtils.IsSteamDeck())
			{
				List<string> list = (List<string>)(object)new List<T>();
				((List<T>)(object)list).Add((T)"menu.settings_graphics_display_mode_fullscreen");
				((List<T>)(object)list).Add((T)"menu.settings_graphics_display_mode_fullscreen_no_borders");
				((List<T>)(object)list).Add((T)"menu.settings_graphics_display_mode_windowed");
				_displayModeLabels = list;
				Dictionary<GameSettingsSystem.DisplayModeEnum, FullScreenMode> dictionary = (Dictionary<GameSettingsSystem.DisplayModeEnum, FullScreenMode>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
			List<string> list2 = (List<string>)(object)new List<T>();
			((List<T>)(object)list2).Add((T)"menu.settings_graphics_display_mode_fullscreen");
			_displayModeLabels = list2;
			Dictionary<GameSettingsSystem.DisplayModeEnum, FullScreenMode> dictionary2 = (Dictionary<GameSettingsSystem.DisplayModeEnum, FullScreenMode>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AE6")]
		[Cpp2IlInjected.Address(RVA = "0x126A790", Offset = "0x1269190", VA = "0x18126A790")]
		private unsafe void RefreshRefreshRateComboBox()
		{
			//Discarded unreachable code: IL_00e5
			//IL_00d0: Expected O, but got I4
			int num = 0;
			Resolution[] resolutions = Screen.resolutions;
			Func<Resolution, bool> _003C_003E9__46_ = _003C_003Ec._003C_003E9__46_0;
			if (_003C_003E9__46_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Resolution i)
				{
					int width = ((Resolution*)i)->width;
					Resolution currentResolution = Screen.currentResolution;
					int refreshRate2 = currentResolution.m_RefreshRate;
					if ((IntPtr)width != (IntPtr)currentResolution)
					{
						int num3 = 0;
					}
					width = ((Resolution*)i)->height;
					Resolution currentResolution2 = Screen.currentResolution;
					int refreshRate3 = currentResolution2.m_RefreshRate;
					return (IntPtr)width == (IntPtr)currentResolution2;
				};
			}
			Resolution[] array = (_refreshRates = Enumerable.Where<Resolution>((IEnumerable<>)(object)resolutions, (Func<, >)(object)_003C_003E9__46_).ToArray<Resolution>());
			_refreshRateComboBox._dropdown.ClearOptions();
			TMP_Dropdown dropdown = _refreshRateComboBox._dropdown;
			Resolution[] refreshRates = _refreshRates;
			Func<Resolution, string> func = default(Func<Resolution, string>);
			if (_003C_003Ec._003C_003E9__46_1 == null)
			{
				func = (Func<Resolution, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Resolution i)
				{
					//IL_0012: Expected O, but got I4
					int refreshRate = ((Resolution*)i)->refreshRate;
					return $"{refreshRate} Hz";
				});
			}
			List<string> list = (List<string>)(object)Enumerable.ToList<string>(Enumerable.Distinct<string>(Enumerable.Select<Resolution, string>((IEnumerable<>)(object)refreshRates, (Func<, >)(object)func)));
			dropdown.AddOptions((List<>)(object)list);
			if (_refreshRates.Length == 0)
			{
				TMP_Dropdown dropdown2 = _refreshRateComboBox._dropdown;
				List<string> list2 = (List<string>)(object)new List<T>();
				int num2 = 0;
				string item = LocalizationManager.FromStringID("menu.settings_graphics_refresh_rate_default", (IResolver)num2);
				((List<T>)(object)list2).Add((T)item);
				dropdown2.AddOptions((List<>)(object)list2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AE7")]
		[Cpp2IlInjected.Address(RVA = "0x1267C30", Offset = "0x1266630", VA = "0x181267C30")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_024c
			//IL_024b: Expected F4, but got I4
			RefreshComboBoxes();
			int num = 0;
			if (!PlatformUtils.UseGraphicSettings())
			{
				HideDisplay();
			}
			TMP_Dropdown.DropdownEvent onValueChanged = _displayModeComboBox._dropdown.m_OnValueChanged;
			UnityAction<int> unityAction = (UnityAction<int>)(object)new UnityAction<T0>(OnDisplayModeChanged);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
			TMP_Dropdown.DropdownEvent onValueChanged2 = _displayComboBox._dropdown.m_OnValueChanged;
			UnityAction<int> unityAction2 = (UnityAction<int>)(object)new UnityAction<T0>(OnDisplayChanged);
			((UnityEvent<T0>)(object)onValueChanged2).AddListener((UnityAction<>)(object)unityAction2);
			TMP_Dropdown.DropdownEvent onValueChanged3 = _resolutionComboBox._dropdown.m_OnValueChanged;
			UnityAction<int> unityAction3 = (UnityAction<int>)(object)new UnityAction<T0>(OnResolutionChanged);
			((UnityEvent<T0>)(object)onValueChanged3).AddListener((UnityAction<>)(object)unityAction3);
			TMP_Dropdown.DropdownEvent onValueChanged4 = _resolutionScaleComboBox._dropdown.m_OnValueChanged;
			UnityAction<int> unityAction4 = (UnityAction<int>)(object)new UnityAction<T0>(OnResolutionScaleChanged);
			((UnityEvent<T0>)(object)onValueChanged4).AddListener((UnityAction<>)(object)unityAction4);
			TMP_Dropdown.DropdownEvent onValueChanged5 = _refreshRateComboBox._dropdown.m_OnValueChanged;
			UnityAction<int> unityAction5 = (UnityAction<int>)(object)new UnityAction<T0>(OnRefreshRateChanged);
			((UnityEvent<T0>)(object)onValueChanged5).AddListener((UnityAction<>)(object)unityAction5);
			TMP_Dropdown.DropdownEvent onValueChanged6 = _graphicPresetComboBox._dropdown.m_OnValueChanged;
			UnityAction<int> unityAction6 = (UnityAction<int>)(object)new UnityAction<T0>(OnGraphicPresetChanged);
			((UnityEvent<T0>)(object)onValueChanged6).AddListener((UnityAction<>)(object)unityAction6);
			TMP_Dropdown.DropdownEvent onValueChanged7 = _shadowResolutionComboBox._dropdown.m_OnValueChanged;
			UnityAction<int> unityAction7 = (UnityAction<int>)(object)new UnityAction<T0>(OnShadowResolutionChanged);
			((UnityEvent<T0>)(object)onValueChanged7).AddListener((UnityAction<>)(object)unityAction7);
			TMP_Dropdown.DropdownEvent onValueChanged8 = _distanceQualityComboBox._dropdown.m_OnValueChanged;
			UnityAction<int> unityAction8 = (UnityAction<int>)(object)new UnityAction<T0>(OnDistanceQualityChanged);
			((UnityEvent<T0>)(object)onValueChanged8).AddListener((UnityAction<>)(object)unityAction8);
			TMP_Dropdown.DropdownEvent onValueChanged9 = _textureQualityComboBox._dropdown.m_OnValueChanged;
			UnityAction<int> unityAction9 = (UnityAction<int>)(object)new UnityAction<T0>(OnTextureQualityChanged);
			((UnityEvent<T0>)(object)onValueChanged9).AddListener((UnityAction<>)(object)unityAction9);
			Toggle.ToggleEvent onValueChanged10 = _vSyncCountToggle.onValueChanged;
			UnityAction<bool> unityAction10 = (UnityAction<bool>)(object)new UnityAction<T0>(OnVSyncChanged);
			((UnityEvent<T0>)(object)onValueChanged10).AddListener((UnityAction<>)(object)unityAction10);
			Slider.SliderEvent onValueChanged11 = _gammaSlider.m_OnValueChanged;
			UnityAction<float> unityAction11 = (UnityAction<float>)(object)new UnityAction<T0>(OnGammaChanged);
			((UnityEvent<T0>)(object)onValueChanged11).AddListener((UnityAction<>)(object)unityAction11);
			Toggle.ToggleEvent onValueChanged12 = _disableCameraShakesToggle.onValueChanged;
			UnityAction<bool> unityAction12 = (UnityAction<bool>)(object)new UnityAction<T0>(OnDisableCameraShakesChanged);
			((UnityEvent<T0>)(object)onValueChanged12).AddListener((UnityAction<>)(object)unityAction12);
			Toggle.ToggleEvent onValueChanged13 = _disableFlashesToggle.onValueChanged;
			UnityAction<bool> unityAction13 = (UnityAction<bool>)(object)new UnityAction<T0>(OnDisableFlashesChanged);
			((UnityEvent<T0>)(object)onValueChanged13).AddListener((UnityAction<>)(object)unityAction13);
			Slider.SliderEvent onValueChanged14 = _timeOfDayOffset.m_OnValueChanged;
			UnityAction<float> unityAction14 = (UnityAction<float>)(object)new UnityAction<T0>(OnTimeOfDayOffsetChanged);
			((UnityEvent<T0>)(object)onValueChanged14).AddListener((UnityAction<>)(object)unityAction14);
			LoadGameSettings();
			int num2 = 0;
			Invoke("SetScrollToTop", num2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AE8")]
		[Cpp2IlInjected.Address(RVA = "0x126AB40", Offset = "0x1269540", VA = "0x18126AB40")]
		private void SetScrollToTop()
		{
			//Discarded unreachable code: IL_0011
			_scrollRect.verticalNormalizedPosition = 1f;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AE9")]
		[Cpp2IlInjected.Address(RVA = "0x1266F70", Offset = "0x1265970", VA = "0x181266F70")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_022d
			int num = 0;
			if (PlatformUtils.UseGraphicSettings())
			{
				TMP_Dropdown.DropdownEvent onValueChanged = _displayModeComboBox._dropdown.m_OnValueChanged;
				UnityAction<int> unityAction = (UnityAction<int>)(object)new UnityAction<T0>(OnDisplayModeChanged);
				((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
				TMP_Dropdown.DropdownEvent onValueChanged2 = _displayComboBox._dropdown.m_OnValueChanged;
				UnityAction<int> unityAction2 = (UnityAction<int>)(object)new UnityAction<T0>(OnDisplayChanged);
				((UnityEvent<T0>)(object)onValueChanged2).RemoveListener((UnityAction<>)(object)unityAction2);
				TMP_Dropdown.DropdownEvent onValueChanged3 = _resolutionComboBox._dropdown.m_OnValueChanged;
				UnityAction<int> unityAction3 = (UnityAction<int>)(object)new UnityAction<T0>(OnResolutionChanged);
				((UnityEvent<T0>)(object)onValueChanged3).RemoveListener((UnityAction<>)(object)unityAction3);
				TMP_Dropdown.DropdownEvent onValueChanged4 = _resolutionScaleComboBox._dropdown.m_OnValueChanged;
				UnityAction<int> unityAction4 = (UnityAction<int>)(object)new UnityAction<T0>(OnResolutionScaleChanged);
				((UnityEvent<T0>)(object)onValueChanged4).RemoveListener((UnityAction<>)(object)unityAction4);
				TMP_Dropdown.DropdownEvent onValueChanged5 = _refreshRateComboBox._dropdown.m_OnValueChanged;
				UnityAction<int> unityAction5 = (UnityAction<int>)(object)new UnityAction<T0>(OnRefreshRateChanged);
				((UnityEvent<T0>)(object)onValueChanged5).RemoveListener((UnityAction<>)(object)unityAction5);
				TMP_Dropdown.DropdownEvent onValueChanged6 = _graphicPresetComboBox._dropdown.m_OnValueChanged;
				UnityAction<int> unityAction6 = (UnityAction<int>)(object)new UnityAction<T0>(OnGraphicPresetChanged);
				((UnityEvent<T0>)(object)onValueChanged6).RemoveListener((UnityAction<>)(object)unityAction6);
				TMP_Dropdown.DropdownEvent onValueChanged7 = _shadowResolutionComboBox._dropdown.m_OnValueChanged;
				UnityAction<int> unityAction7 = (UnityAction<int>)(object)new UnityAction<T0>(OnShadowResolutionChanged);
				((UnityEvent<T0>)(object)onValueChanged7).RemoveListener((UnityAction<>)(object)unityAction7);
				TMP_Dropdown.DropdownEvent onValueChanged8 = _distanceQualityComboBox._dropdown.m_OnValueChanged;
				UnityAction<int> unityAction8 = (UnityAction<int>)(object)new UnityAction<T0>(OnDistanceQualityChanged);
				((UnityEvent<T0>)(object)onValueChanged8).RemoveListener((UnityAction<>)(object)unityAction8);
				TMP_Dropdown.DropdownEvent onValueChanged9 = _textureQualityComboBox._dropdown.m_OnValueChanged;
				UnityAction<int> unityAction9 = (UnityAction<int>)(object)new UnityAction<T0>(OnTextureQualityChanged);
				((UnityEvent<T0>)(object)onValueChanged9).RemoveListener((UnityAction<>)(object)unityAction9);
				Toggle.ToggleEvent onValueChanged10 = _vSyncCountToggle.onValueChanged;
				UnityAction<bool> unityAction10 = (UnityAction<bool>)(object)new UnityAction<T0>(OnVSyncChanged);
				((UnityEvent<T0>)(object)onValueChanged10).RemoveListener((UnityAction<>)(object)unityAction10);
				Slider.SliderEvent onValueChanged11 = _gammaSlider.m_OnValueChanged;
				UnityAction<float> unityAction11 = (UnityAction<float>)(object)new UnityAction<T0>(OnGammaChanged);
				((UnityEvent<T0>)(object)onValueChanged11).RemoveListener((UnityAction<>)(object)unityAction11);
			}
			Toggle.ToggleEvent onValueChanged12 = _disableCameraShakesToggle.onValueChanged;
			UnityAction<bool> unityAction12 = (UnityAction<bool>)(object)new UnityAction<T0>(OnDisableCameraShakesChanged);
			((UnityEvent<T0>)(object)onValueChanged12).RemoveListener((UnityAction<>)(object)unityAction12);
			Toggle.ToggleEvent onValueChanged13 = _disableFlashesToggle.onValueChanged;
			UnityAction<bool> unityAction13 = (UnityAction<bool>)(object)new UnityAction<T0>(OnDisableFlashesChanged);
			((UnityEvent<T0>)(object)onValueChanged13).RemoveListener((UnityAction<>)(object)unityAction13);
			Slider.SliderEvent onValueChanged14 = _timeOfDayOffset.m_OnValueChanged;
			UnityAction<float> unityAction14 = (UnityAction<float>)(object)new UnityAction<T0>(OnTimeOfDayOffsetChanged);
			((UnityEvent<T0>)(object)onValueChanged14).RemoveListener((UnityAction<>)(object)unityAction14);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AEA")]
		[Cpp2IlInjected.Address(RVA = "0x1266540", Offset = "0x1264F40", VA = "0x181266540")]
		private void HideDisplay()
		{
			//Discarded unreachable code: IL_00f3
			GameObject gameObject = _displayModeItemGroup.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _displayItemGroup.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			GameObject gameObject3 = _resolutionItemGroup.gameObject;
			int active3 = 0;
			gameObject3.SetActive((byte)active3 != 0);
			GameObject gameObject4 = _resolutionScaleItemGroup.gameObject;
			int active4 = 0;
			gameObject4.SetActive((byte)active4 != 0);
			GameObject gameObject5 = _refreshRateItemGroup.gameObject;
			int active5 = 0;
			gameObject5.SetActive((byte)active5 != 0);
			GameObject gameObject6 = _graphicPresetItemGroup.gameObject;
			int active6 = 0;
			gameObject6.SetActive((byte)active6 != 0);
			GameObject gameObject7 = _shadowResolutionItemGroup.gameObject;
			int active7 = 0;
			gameObject7.SetActive((byte)active7 != 0);
			GameObject gameObject8 = _distanceQualityItemGroup.gameObject;
			int active8 = 0;
			gameObject8.SetActive((byte)active8 != 0);
			GameObject gameObject9 = _textureQualityItemGroup.gameObject;
			int active9 = 0;
			gameObject9.SetActive((byte)active9 != 0);
			GameObject gameObject10 = _vSyncCountItemGroup.gameObject;
			int active10 = 0;
			gameObject10.SetActive((byte)active10 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AEB")]
		[Cpp2IlInjected.Address(RVA = "0x1266700", Offset = "0x1265100", VA = "0x181266700", Slot = "5")]
		public unsafe override void LoadGameSettings()
		{
			//Discarded unreachable code: IL_02c5
			Toggle disableCameraShakesToggle = _disableCameraShakesToggle;
			bool flag = (disableCameraShakesToggle.isOn = base.Settings.DisableCameraShakes);
			Toggle disableFlashesToggle = _disableFlashesToggle;
			bool flag2 = (disableFlashesToggle.isOn = base.Settings.DisableFlashes);
			Slider timeOfDayOffset = _timeOfDayOffset;
			int timeOfDayVisualOffset = base.Settings.TimeOfDayVisualOffset;
			int timeOfDayVisualOffset2 = base.Settings.TimeOfDayVisualOffset;
			UpdateTimeOfDayOffsetValue(timeOfDayVisualOffset2);
			int num = 0;
			if (!PlatformUtils.UseGraphicSettings())
			{
				return;
			}
			ComboBoxTMP displayModeComboBox = _displayModeComboBox;
			Dictionary<GameSettingsSystem.DisplayModeEnum, FullScreenMode> displayModes = _displayModes;
			TMP_Dropdown dropdown = displayModeComboBox._dropdown;
			Dictionary<GameSettingsSystem.DisplayModeEnum, FullScreenMode>.ValueCollection values = (Dictionary<GameSettingsSystem.DisplayModeEnum, FullScreenMode>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)displayModes).get_Values();
			int displayMode = (int)base.Settings.DisplayMode;
			int num2 = default(int);
			displayMode = (dropdown.value = num2);
			_displayModeComboBox._dropdown.RefreshShownValue();
			TMP_Dropdown dropdown2 = _displayComboBox._dropdown;
			List<(int, UnityEngine.Display)> displays = _displays;
			Predicate<(int, UnityEngine.Display)> predicate = (Predicate<(int, UnityEngine.Display)>)(object)(Predicate<T>)delegate
			{
				//Discarded unreachable code: IL_000e
				int display = base.Settings.Display;
				bool result2 = default(bool);
				return result2;
			};
			int num5 = (dropdown2.value = ((List<T>)(object)displays).FindIndex((Predicate<>)(object)predicate));
			_displayComboBox._dropdown.RefreshShownValue();
			Resolution[] resolutions = _resolutions;
			Predicate<Resolution> predicate2 = (Predicate<Resolution>)(object)(Predicate<T>)delegate(Resolution resolution)
			{
				//Discarded unreachable code: IL_0033
				int width = ((Resolution*)resolution)->width;
				Vector2Int resolution2 = base.Settings.Resolution;
				if ((IntPtr)width != (IntPtr)resolution2)
				{
					int num16 = 0;
				}
				int height = ((Resolution*)resolution)->height;
				Vector2Int resolution3 = base.Settings.Resolution;
				return (IntPtr)height == (IntPtr)resolution3;
			};
			int num6 = default(int);
			currentResolutionIndex = num6;
			if (num6 == -1)
			{
				int num7 = (currentResolutionIndex = Enumerable.Count<Resolution>((IEnumerable<>)(object)_resolutions));
			}
			TMP_Dropdown dropdown3 = _resolutionComboBox._dropdown;
			int num9 = (dropdown3.value = 0);
			_resolutionComboBox._dropdown.RefreshShownValue();
			List<(string, float)> resolutionScales = _resolutionScales;
			Predicate<(string, float)> predicate3 = (Predicate<(string, float)>)(object)(Predicate<T>)delegate
			{
				float resolutionScale = base.Settings.ResolutionScale;
				throw new NullReferenceException();
			};
			int value = ((List<T>)(object)resolutionScales).FindIndex((Predicate<>)(object)predicate3);
			_resolutionScaleComboBox._dropdown.value = value;
			_resolutionScaleComboBox._dropdown.RefreshShownValue();
			LoadRefreshRateGameSettings();
			int num10 = 0;
			string[] names = QualitySettings.names;
			Predicate<string> predicate4 = (Predicate<string>)(object)(Predicate<T>)delegate(string x)
			{
				//Discarded unreachable code: IL_0014
				string graphicPreset = base.Settings.GraphicPreset;
				return string.Equals(x, graphicPreset);
			};
			TMP_Dropdown dropdown4 = _graphicPresetComboBox._dropdown;
			int num11 = default(int);
			int num13 = (dropdown4.value = num11 - 1);
			_graphicPresetComboBox._dropdown.RefreshShownValue();
			TMP_Dropdown dropdown5 = _shadowResolutionComboBox._dropdown;
			int num14 = (dropdown5.value = (int)base.Settings.ShadowResolution);
			_shadowResolutionComboBox._dropdown.RefreshShownValue();
			List<(string, float)> distanceQualities = _distanceQualities;
			Predicate<(string, float)> predicate5 = (Predicate<(string, float)>)(object)(Predicate<T>)delegate
			{
				GameSettingsSystem settings = base.Settings;
				float distanceQuality2 = settings.DistanceQuality;
				if ((object)settings == null)
				{
					return true;
				}
				int num15 = 0;
				throw new NullReferenceException();
			};
			int value2 = ((List<T>)(object)distanceQualities).FindIndex((Predicate<>)(object)predicate5);
			_distanceQualityComboBox._dropdown.value = value2;
			_distanceQualityComboBox._dropdown.RefreshShownValue();
			List<(int, string)> textureQualities = _textureQualities;
			Predicate<(int, string)> predicate6 = (Predicate<(int, string)>)(object)(Predicate<T>)delegate
			{
				//Discarded unreachable code: IL_000e
				int textureQuality2 = base.Settings.TextureQuality;
				bool result = default(bool);
				return result;
			};
			int value3 = ((List<T>)(object)textureQualities).FindIndex((Predicate<>)(object)predicate6);
			_textureQualityComboBox._dropdown.value = value3;
			_textureQualityComboBox._dropdown.RefreshShownValue();
			Toggle vSyncCountToggle = _vSyncCountToggle;
			bool flag3 = (vSyncCountToggle.isOn = base.Settings.VSync);
		}

		[Cpp2IlInjected.Token(Token = "0x6002AEC")]
		[Cpp2IlInjected.Address(RVA = "0x1266E20", Offset = "0x1265820", VA = "0x181266E20")]
		private unsafe void LoadRefreshRateGameSettings()
		{
			//Discarded unreachable code: IL_0036
			Resolution[] refreshRates = _refreshRates;
			Predicate<Resolution> predicate = (Predicate<Resolution>)(object)(Predicate<T>)delegate(Resolution resolution)
			{
				int width = ((Resolution*)resolution)->width;
				Vector2Int resolution2 = base.Settings.Resolution;
				if ((IntPtr)width == (IntPtr)resolution2)
				{
					width = ((Resolution*)resolution)->height;
					Vector2Int resolution3 = base.Settings.Resolution;
					if ((IntPtr)width == (IntPtr)resolution3)
					{
						int refreshRate = ((Resolution*)resolution)->refreshRate;
						int refreshRate2 = base.Settings.RefreshRate;
						return refreshRate == refreshRate2;
					}
				}
				int num = 0;
				throw new NullReferenceException();
			};
			int value = default(int);
			_refreshRateComboBox._dropdown.value = value;
			_refreshRateComboBox._dropdown.RefreshShownValue();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AED")]
		[Cpp2IlInjected.Address(RVA = "0x12679E0", Offset = "0x12663E0", VA = "0x1812679E0")]
		private void OnDisplayModeChanged(int displayIndex)
		{
			//Discarded unreachable code: IL_0085
			int num = (int)Enumerable.ElementAt<FullScreenMode>((IEnumerable<>)(object)((Dictionary<TKey, TValue>)(object)_displayModes).get_Values(), displayIndex);
			if (base.Settings.DisplayMode != FullScreenMode.Windowed)
			{
			}
			bool flag = num != 3;
			GameSettingsSystem settings = base.Settings;
			int num2 = 0;
			if (Application.platform != 0)
			{
				int num3 = 0;
				if (Application.platform != RuntimePlatform.OSXPlayer)
				{
					return;
				}
			}
			if (flag || base.Settings.DisplayMode != (FullScreenMode)num)
			{
				Resolution[] resolutions = _resolutions;
				int num4 = currentResolutionIndex;
				Resolution[] resolutions2 = _resolutions;
				int num5 = currentResolutionIndex;
				num4 = num5;
				num5 += 4;
				num5 = num4;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AEE")]
		[Cpp2IlInjected.Address(RVA = "0x1267630", Offset = "0x1266030", VA = "0x181267630")]
		private void OnDisplayChanged(int displayIndex)
		{
			//Discarded unreachable code: IL_0115
			//IL_0053: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			TextBase label;
			string[] array;
			while (true)
			{
				int display = base.Settings.Display;
				GameSettingsSystem settings = base.Settings;
				label = _displayItemGroup._label;
				array = new string[5];
				if ("<size=95%>" != null && "<size=95%>" == null)
				{
					continue;
				}
				array[0] = "<size=95%>";
				int num = 0;
				string text = LocalizationManager.FromStringID("menu.settings_graphics_display", (IResolver)num);
				if (text != null && text == null)
				{
					continue;
				}
				array[1] = text;
				if ("</size>\n<alpha=#77><size=60%>" != null && "</size>\n<alpha=#77><size=60%>" == null)
				{
					continue;
				}
				array[2] = "</size>\n<alpha=#77><size=60%>";
				int num2 = 0;
				string text2 = LocalizationManager.FromStringID("menu.settings_need_restart", (IResolver)num2);
				if (text2 == null || text2 != null)
				{
					array[3] = text2;
					if ("</size>" == null || "</size>" != null)
					{
						break;
					}
				}
			}
			array[4] = "</size>";
			string text4 = (label.Text = string.Concat(array));
			_displayItemGroup._label.TextComponent.verticalAlignment = VerticalAlignmentOptions.Middle;
			_displayItemGroup._label.TextComponent.lineSpacing = 5f;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AEF")]
		[Cpp2IlInjected.Address(RVA = "0x1268650", Offset = "0x1267050", VA = "0x181268650")]
		private unsafe void OnResolutionChanged(int resolutionIndex)
		{
			//Discarded unreachable code: IL_002e
			currentResolutionIndex = resolutionIndex;
			GameSettingsSystem settings = base.Settings;
			Resolution[] resolutions = _resolutions;
			int height = ((Resolution*)_resolutions)->height;
			RefreshRefreshRateComboBox();
			LoadRefreshRateGameSettings();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AF0")]
		[Cpp2IlInjected.Address(RVA = "0x1268740", Offset = "0x1267140", VA = "0x181268740")]
		private void OnResolutionScaleChanged(int resolutionScaleIndex)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002AF1")]
		[Cpp2IlInjected.Address(RVA = "0x12685C0", Offset = "0x1266FC0", VA = "0x1812685C0")]
		private void OnRefreshRateChanged(int refreshRateIndex)
		{
			//Discarded unreachable code: IL_001d
			if (_refreshRates.Length > refreshRateIndex)
			{
				GameSettingsSystem settings = base.Settings;
				Resolution[] refreshRates = _refreshRates;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AF2")]
		[Cpp2IlInjected.Address(RVA = "0x1268350", Offset = "0x1266D50", VA = "0x181268350")]
		private void OnGraphicPresetChanged(int graphicPresetIndex)
		{
			//Discarded unreachable code: IL_00de
			GameSettingsSystem settings = base.Settings;
			int num = 0;
			string[] names = QualitySettings.names;
			int num2 = graphicPresetIndex + 1;
			string text2 = (settings.GraphicPreset = names[num2]);
			TMP_Dropdown dropdown = _shadowResolutionComboBox._dropdown;
			int num3 = (dropdown.value = (int)base.Settings.ShadowResolution);
			_shadowResolutionComboBox._dropdown.RefreshShownValue();
			List<(string, float)> distanceQualities = _distanceQualities;
			Predicate<(string, float)> predicate = (Predicate<(string, float)>)(object)(Predicate<T>)delegate
			{
				GameSettingsSystem settings2 = base.Settings;
				float distanceQuality2 = settings2.DistanceQuality;
				if ((object)settings2 == null)
				{
					return true;
				}
				int num4 = 0;
				throw new NullReferenceException();
			};
			int value = ((List<T>)(object)distanceQualities).FindIndex((Predicate<>)(object)predicate);
			_distanceQualityComboBox._dropdown.value = value;
			_distanceQualityComboBox._dropdown.RefreshShownValue();
			List<(int, string)> textureQualities = _textureQualities;
			Predicate<(int, string)> predicate2 = (Predicate<(int, string)>)(object)(Predicate<T>)delegate
			{
				//Discarded unreachable code: IL_000e
				int textureQuality2 = base.Settings.TextureQuality;
				bool result = default(bool);
				return result;
			};
			int value2 = ((List<T>)(object)textureQualities).FindIndex((Predicate<>)(object)predicate2);
			_textureQualityComboBox._dropdown.value = value2;
			_textureQualityComboBox._dropdown.RefreshShownValue();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AF3")]
		[Cpp2IlInjected.Address(RVA = "0x12687E0", Offset = "0x12671E0", VA = "0x1812687E0")]
		private void OnShadowResolutionChanged(int shadowResolutionIndex)
		{
			//Discarded unreachable code: IL_0008
			GameSettingsSystem settings = base.Settings;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AF4")]
		[Cpp2IlInjected.Address(RVA = "0x1267B90", Offset = "0x1266590", VA = "0x181267B90")]
		private void OnDistanceQualityChanged(int distanceQualityIndex)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002AF5")]
		[Cpp2IlInjected.Address(RVA = "0x1268810", Offset = "0x1267210", VA = "0x181268810")]
		private void OnTextureQualityChanged(int textureQualityIndex)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002AF6")]
		[Cpp2IlInjected.Address(RVA = "0x1268900", Offset = "0x1267300", VA = "0x181268900")]
		private void OnVSyncChanged(bool vSync)
		{
			//Discarded unreachable code: IL_000d
			base.Settings.VSync = vSync;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AF7")]
		[Cpp2IlInjected.Address(RVA = "0x1268340", Offset = "0x1266D40", VA = "0x181268340")]
		private void OnGammaChanged(float gamma)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002AF8")]
		[Cpp2IlInjected.Address(RVA = "0x1266F10", Offset = "0x1265910", VA = "0x181266F10")]
		private void OnDisableCameraShakesChanged(bool disableCameraShakes)
		{
			//Discarded unreachable code: IL_000d
			base.Settings.DisableCameraShakes = disableCameraShakes;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AF9")]
		[Cpp2IlInjected.Address(RVA = "0x1266F40", Offset = "0x1265940", VA = "0x181266F40")]
		private void OnDisableFlashesChanged(bool disableFlashes)
		{
			//Discarded unreachable code: IL_000d
			base.Settings.DisableFlashes = disableFlashes;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AFA")]
		[Cpp2IlInjected.Address(RVA = "0x12688A0", Offset = "0x12672A0", VA = "0x1812688A0")]
		private void OnTimeOfDayOffsetChanged(float offsetFloat)
		{
			//Discarded unreachable code: IL_001b
			int num = Mathf.RoundToInt(offsetFloat);
			UpdateTimeOfDayOffsetValue(num);
			base.Settings.TimeOfDayVisualOffset = num;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AFB")]
		[Cpp2IlInjected.Address(RVA = "0x126AE80", Offset = "0x1269880", VA = "0x18126AE80")]
		private void UpdateTimeOfDayOffsetValue(int offset)
		{
			//Discarded unreachable code: IL_001f, IL_0033
			TextBase timeOfDayOffsetValue = _timeOfDayOffsetValue;
			Dictionary<string, object> arg = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			string text = string.Format("{0:+;-;+}{0:#;#;0}", arg);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AFC")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public SettingsGraphics()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002AFD")]
		[Cpp2IlInjected.Address(RVA = "0x126AFA0", Offset = "0x12699A0", VA = "0x18126AFA0")]
		static unsafe SettingsGraphics()
		{
			//Discarded unreachable code: IL_0091
			List<Resolution> list = (List<Resolution>)(object)new List<T>();
			((Epic.OnlineServices.RTCAudio.GetAudioInputDeviceByIndexOptionsInternal*)list)->DeviceInfoIndex = 540u;
			((Epic.OnlineServices.RTCAudio.GetAudioInputDeviceByIndexOptionsInternal*)list)->DeviceInfoIndex = 576u;
			((Epic.OnlineServices.RTCAudio.GetAudioInputDeviceByIndexOptionsInternal*)list)->DeviceInfoIndex = 720u;
			((Epic.OnlineServices.RTCAudio.GetAudioInputDeviceByIndexOptionsInternal*)list)->DeviceInfoIndex = 756u;
			((Epic.OnlineServices.RTCAudio.GetAudioInputDeviceByIndexOptionsInternal*)list)->DeviceInfoIndex = 900u;
			((Epic.OnlineServices.RTCAudio.GetAudioInputDeviceByIndexOptionsInternal*)list)->DeviceInfoIndex = 1080u;
			((Epic.OnlineServices.RTCAudio.GetAudioInputDeviceByIndexOptionsInternal*)list)->DeviceInfoIndex = 1152u;
			((Epic.OnlineServices.RTCAudio.GetAudioInputDeviceByIndexOptionsInternal*)list)->DeviceInfoIndex = 1440u;
			((Epic.OnlineServices.RTCAudio.GetAudioInputDeviceByIndexOptionsInternal*)list)->DeviceInfoIndex = 1620u;
			((Epic.OnlineServices.RTCAudio.GetAudioInputDeviceByIndexOptionsInternal*)list)->DeviceInfoIndex = 1800u;
			((Epic.OnlineServices.RTCAudio.GetAudioInputDeviceByIndexOptionsInternal*)list)->DeviceInfoIndex = 2304u;
			_resolutionMacOS = list;
		}
	}
}
