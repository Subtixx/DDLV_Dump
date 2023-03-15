using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Systems;
using Meta.Online;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006BC")]
	public class SettingsSounds : SettingsMenuPanel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002611")]
		[SerializeField]
		private Slider _masterVolumeSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002612")]
		[SerializeField]
		private Slider _musicVolumeSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002613")]
		[SerializeField]
		private Slider _sfxVolumeSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002614")]
		[SerializeField]
		private Slider _voiceVolumeSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002615")]
		[SerializeField]
		private Toggle _streamingFriendlyMusicToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002616")]
		[SerializeField]
		private GameObject _streamingFriendlyMusic;

		[Cpp2IlInjected.Token(Token = "0x17000656")]
		public override FocusNavigationElement FirstFocusNavigationElement
		{
			[Cpp2IlInjected.Token(Token = "0x6002B6B")]
			[Cpp2IlInjected.Address(RVA = "0x1426500", Offset = "0x1424F00", VA = "0x181426500", Slot = "4")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _masterVolumeSlider.GetComponentInChildren<FocusNavigationElement>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B6C")]
		[Cpp2IlInjected.Address(RVA = "0x1425FC0", Offset = "0x14249C0", VA = "0x181425FC0")]
		public void OnEnable()
		{
			//Discarded unreachable code: IL_00b5
			Slider.SliderEvent onValueChanged = _masterVolumeSlider.m_OnValueChanged;
			UnityAction<float> unityAction = (UnityAction<float>)(object)new UnityAction<T0>(OnMasterVolumeChanged);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
			Slider.SliderEvent onValueChanged2 = _musicVolumeSlider.m_OnValueChanged;
			UnityAction<float> unityAction2 = (UnityAction<float>)(object)new UnityAction<T0>(OnMusicVolumeChanged);
			((UnityEvent<T0>)(object)onValueChanged2).AddListener((UnityAction<>)(object)unityAction2);
			Slider.SliderEvent onValueChanged3 = _sfxVolumeSlider.m_OnValueChanged;
			UnityAction<float> unityAction3 = (UnityAction<float>)(object)new UnityAction<T0>(OnSfxVolumeChanged);
			((UnityEvent<T0>)(object)onValueChanged3).AddListener((UnityAction<>)(object)unityAction3);
			Slider.SliderEvent onValueChanged4 = _voiceVolumeSlider.m_OnValueChanged;
			UnityAction<float> unityAction4 = (UnityAction<float>)(object)new UnityAction<T0>(OnVoiceVolumeChanged);
			((UnityEvent<T0>)(object)onValueChanged4).AddListener((UnityAction<>)(object)unityAction4);
			Toggle.ToggleEvent onValueChanged5 = _streamingFriendlyMusicToggle.onValueChanged;
			UnityAction<bool> unityAction5 = (UnityAction<bool>)(object)new UnityAction<T0>(OnStreamingFriendlyMusicChanged);
			((UnityEvent<T0>)(object)onValueChanged5).AddListener((UnityAction<>)(object)unityAction5);
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B6D")]
		[Cpp2IlInjected.Address(RVA = "0x1425D50", Offset = "0x1424750", VA = "0x181425D50")]
		public void OnDisable()
		{
			//Discarded unreachable code: IL_00ad
			Slider.SliderEvent onValueChanged = _masterVolumeSlider.m_OnValueChanged;
			UnityAction<float> unityAction = (UnityAction<float>)(object)new UnityAction<T0>(OnMasterVolumeChanged);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
			Slider.SliderEvent onValueChanged2 = _musicVolumeSlider.m_OnValueChanged;
			UnityAction<float> unityAction2 = (UnityAction<float>)(object)new UnityAction<T0>(OnMusicVolumeChanged);
			((UnityEvent<T0>)(object)onValueChanged2).RemoveListener((UnityAction<>)(object)unityAction2);
			Slider.SliderEvent onValueChanged3 = _sfxVolumeSlider.m_OnValueChanged;
			UnityAction<float> unityAction3 = (UnityAction<float>)(object)new UnityAction<T0>(OnSfxVolumeChanged);
			((UnityEvent<T0>)(object)onValueChanged3).RemoveListener((UnityAction<>)(object)unityAction3);
			Slider.SliderEvent onValueChanged4 = _voiceVolumeSlider.m_OnValueChanged;
			UnityAction<float> unityAction4 = (UnityAction<float>)(object)new UnityAction<T0>(OnVoiceVolumeChanged);
			((UnityEvent<T0>)(object)onValueChanged4).RemoveListener((UnityAction<>)(object)unityAction4);
			Toggle.ToggleEvent onValueChanged5 = _streamingFriendlyMusicToggle.onValueChanged;
			UnityAction<bool> unityAction5 = (UnityAction<bool>)(object)new UnityAction<T0>(OnStreamingFriendlyMusicChanged);
			((UnityEvent<T0>)(object)onValueChanged5).RemoveListener((UnityAction<>)(object)unityAction5);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B6E")]
		[Cpp2IlInjected.Address(RVA = "0x1425A90", Offset = "0x1424490", VA = "0x181425A90", Slot = "5")]
		public override void LoadGameSettings()
		{
			//Discarded unreachable code: IL_00de
			//IL_00ae: Expected O, but got I4
			Slider masterVolumeSlider = _masterVolumeSlider;
			float num = (masterVolumeSlider.value = base.Settings.MasterVolume);
			Slider musicVolumeSlider = _musicVolumeSlider;
			num = (musicVolumeSlider.value = base.Settings.MusicVolume);
			Slider sfxVolumeSlider = _sfxVolumeSlider;
			num = (sfxVolumeSlider.value = base.Settings.SfxVolume);
			Slider voiceVolumeSlider = _voiceVolumeSlider;
			num = (voiceVolumeSlider.value = base.Settings.VoiceVolume);
			Toggle streamingFriendlyMusicToggle = _streamingFriendlyMusicToggle;
			bool flag = (streamingFriendlyMusicToggle.isOn = base.Settings.StreamingFriendlyMusic);
			LocalStorage _003CLocalStorage_003Ek__BackingField = SystemRoot.Instance.MetaClient.LocalStorage;
			if (_003CLocalStorage_003Ek__BackingField == null || _003CLocalStorage_003Ek__BackingField.MiniProfile != null)
			{
			}
			string currentCountry = default(string);
			if (string.IsNullOrEmpty((string)0))
			{
				int num2 = 0;
				currentCountry = RegionUtils.GetCurrentCountry();
			}
			GameObject streamingFriendlyMusic2 = _streamingFriendlyMusic;
			bool active = !RegionUtils.COUNTRY_CODE_FRIENDLY_STREAMING.Contains(currentCountry);
			streamingFriendlyMusic2.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B6F")]
		[Cpp2IlInjected.Address(RVA = "0x1426370", Offset = "0x1424D70", VA = "0x181426370")]
		private void UpdateStreamingFriendlySettings()
		{
			//Discarded unreachable code: IL_004e
			//IL_0023: Expected O, but got I4
			LocalStorage _003CLocalStorage_003Ek__BackingField = SystemRoot.Instance.MetaClient.LocalStorage;
			if (_003CLocalStorage_003Ek__BackingField == null || _003CLocalStorage_003Ek__BackingField.MiniProfile != null)
			{
			}
			string currentCountry = default(string);
			if (string.IsNullOrEmpty((string)0))
			{
				int num = 0;
				currentCountry = RegionUtils.GetCurrentCountry();
			}
			GameObject streamingFriendlyMusic = _streamingFriendlyMusic;
			bool active = !RegionUtils.COUNTRY_CODE_FRIENDLY_STREAMING.Contains(currentCountry);
			streamingFriendlyMusic.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B70")]
		[Cpp2IlInjected.Address(RVA = "0x1426240", Offset = "0x1424C40", VA = "0x181426240")]
		private void OnMasterVolumeChanged(float volume)
		{
			//Discarded unreachable code: IL_000d
			base.Settings.MasterVolume = volume;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B71")]
		[Cpp2IlInjected.Address(RVA = "0x1426280", Offset = "0x1424C80", VA = "0x181426280")]
		private void OnMusicVolumeChanged(float volume)
		{
			//Discarded unreachable code: IL_000d
			base.Settings.MusicVolume = volume;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B72")]
		[Cpp2IlInjected.Address(RVA = "0x14262C0", Offset = "0x1424CC0", VA = "0x1814262C0")]
		private void OnSfxVolumeChanged(float volume)
		{
			//Discarded unreachable code: IL_000d
			base.Settings.SfxVolume = volume;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B73")]
		[Cpp2IlInjected.Address(RVA = "0x1426330", Offset = "0x1424D30", VA = "0x181426330")]
		private void OnVoiceVolumeChanged(float volume)
		{
			//Discarded unreachable code: IL_000d
			base.Settings.VoiceVolume = volume;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B74")]
		[Cpp2IlInjected.Address(RVA = "0x1426300", Offset = "0x1424D00", VA = "0x181426300")]
		private void OnStreamingFriendlyMusicChanged(bool streaming)
		{
			//Discarded unreachable code: IL_000d
			base.Settings.StreamingFriendlyMusic = streaming;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B75")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SettingsSounds()
		{
		}
	}
}
