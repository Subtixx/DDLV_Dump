#define USE_GRAPHIC_SETTINGS
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Audio;
using Mdl.CameraFeedback;
using Mdl.Gestures;
using Mdl.Graphic.Weather;
using Meta;
using Meta.Online;
using Meta.Util;
using Rewired;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Mdl.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200095B")]
	public class GameSettingsSystem : System
	{
		[Cpp2IlInjected.Token(Token = "0x200095C")]
		public enum DisplayModeEnum
		{
			[Cpp2IlInjected.Token(Token = "0x4003400")]
			Fullsceen = 0,
			[Cpp2IlInjected.Token(Token = "0x4003401")]
			FullsceenNoBorders = 1,
			[Cpp2IlInjected.Token(Token = "0x4003402")]
			Windowed = 3
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40033F0")]
		[SerializeField]
		private RTPC _masterVolumeRTPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40033F1")]
		[SerializeField]
		private RTPC _musicVolumeRTPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40033F2")]
		[SerializeField]
		private RTPC _sfxVolumeRTPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40033F3")]
		[SerializeField]
		private RTPC _voiceVolumeRTPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40033F4")]
		[SerializeField]
		private AK.Wwise.Event streamingFriendlyMusicOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40033F5")]
		[SerializeField]
		private AK.Wwise.Event streamingFriendlyMusicOff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40033F6")]
		private InputBehavior _cameraInputBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40033F7")]
		private UniversalRenderPipelineAsset _universalRenderPipeline;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40033F8")]
		private Vector2Int initialResolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40033F9")]
		private float initialResolutionScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40033FA")]
		private int initialRefreshRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40033FB")]
		private string initialGraphicPreset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40033FC")]
		private UnityEngine.ShadowResolution _currentPresetDefaultShadowResolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40033FD")]
		private float _currentPresetDefaultLodBias;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40033FE")]
		private int _currentPresetDefaultMasterTextureLimit;

		[Cpp2IlInjected.Token(Token = "0x17000623")]
		private static GameSettings Settings
		{
			[Cpp2IlInjected.Token(Token = "0x6002B38")]
			[Cpp2IlInjected.Address(RVA = "0x8BFB60", Offset = "0x8BE560", VA = "0x1808BFB60")]
			get
			{
				//Discarded unreachable code: IL_0010
				return SystemRoot.Instance.MetaClient.GameSettings;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000624")]
		public bool InvertCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6002B3A")]
			[Cpp2IlInjected.Address(RVA = "0x8BF900", Offset = "0x8BE300", VA = "0x1808BF900")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).invertCamera_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B3B")]
			[Cpp2IlInjected.Address(RVA = "0x8C0520", Offset = "0x8BEF20", VA = "0x1808C0520")]
			set
			{
				//Discarded unreachable code: IL_003a
				int num = 0;
				if (((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).invertCamera_ != value)
				{
					int num2 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).invertCamera_ = value;
					ApplyInvertCamera();
					int num3 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000625")]
		public bool ClickToMove
		{
			[Cpp2IlInjected.Token(Token = "0x6002B3C")]
			[Cpp2IlInjected.Address(RVA = "0x8BF6D0", Offset = "0x8BE0D0", VA = "0x1808BF6D0")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).clickToMove_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B3D")]
			[Cpp2IlInjected.Address(RVA = "0x8BFFD0", Offset = "0x8BE9D0", VA = "0x1808BFFD0")]
			set
			{
				//Discarded unreachable code: IL_003a
				int num = 0;
				if (((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).clickToMove_ != value)
				{
					int num2 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).clickToMove_ = value;
					ApplyClickToMove();
					int num3 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000626")]
		public float CameraMouseSensitivity
		{
			[Cpp2IlInjected.Token(Token = "0x6002B40")]
			[Cpp2IlInjected.Address(RVA = "0x8BF680", Offset = "0x8BE080", VA = "0x1808BF680")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).cameraMouseSensitivity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B41")]
			[Cpp2IlInjected.Address(RVA = "0x8BFF10", Offset = "0x8BE910", VA = "0x1808BFF10")]
			set
			{
				//Discarded unreachable code: IL_0035
				int num = 0;
				if (((BaseStorage<DataType>)(object)Settings).Data != null)
				{
					int num2 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).cameraMouseSensitivity_ = value;
					ApplyCameraMouseSensitivity();
					int num3 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000627")]
		public float CameraGamepadSensitivity
		{
			[Cpp2IlInjected.Token(Token = "0x6002B43")]
			[Cpp2IlInjected.Address(RVA = "0x8BF630", Offset = "0x8BE030", VA = "0x1808BF630")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).cameraGamepadSensitivity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B44")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE50", Offset = "0x8BE850", VA = "0x1808BFE50")]
			set
			{
				//Discarded unreachable code: IL_0035
				int num = 0;
				if (((BaseStorage<DataType>)(object)Settings).Data != null)
				{
					int num2 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).cameraGamepadSensitivity_ = value;
					ApplyCameraGamepadSensitivity();
					int num3 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000628")]
		public bool GamepadVibration
		{
			[Cpp2IlInjected.Token(Token = "0x6002B46")]
			[Cpp2IlInjected.Address(RVA = "0x8BF860", Offset = "0x8BE260", VA = "0x1808BF860")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).gamepadVibration_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B47")]
			[Cpp2IlInjected.Address(RVA = "0x8C0390", Offset = "0x8BED90", VA = "0x1808C0390")]
			set
			{
				//Discarded unreachable code: IL_0038
				int num = 0;
				if (((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).gamepadVibration_ != value)
				{
					int num2 = 0;
					GameSettingsData data = (GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data;
					int num3 = 0;
					data.gamepadVibration_ = value;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000629")]
		public KeyboardLayout KeyboardLayout
		{
			[Cpp2IlInjected.Token(Token = "0x6002B49")]
			[Cpp2IlInjected.Address(RVA = "0x8BF950", Offset = "0x8BE350", VA = "0x1808BF950")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).keyboardLayout_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B4A")]
			[Cpp2IlInjected.Address(RVA = "0x8C05E0", Offset = "0x8BEFE0", VA = "0x1808C05E0")]
			set
			{
				//Discarded unreachable code: IL_0040
				int num = 0;
				if (((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).keyboardLayout_ != value)
				{
					int num2 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).keyboardLayout_ = value;
					int num3 = 0;
					CustomizedPlayerInputSystem.ApplyKeyboardLayout();
					int num4 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700062A")]
		public FullScreenMode DisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x6002B4C")]
			[Cpp2IlInjected.Address(RVA = "0x8BF7C0", Offset = "0x8BE1C0", VA = "0x1808BF7C0")]
			get
			{
				int num = 0;
				return Screen.fullScreenMode;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B4D")]
			[Cpp2IlInjected.Address(RVA = "0x8C0210", Offset = "0x8BEC10", VA = "0x1808C0210")]
			set
			{
				int num = 0;
				if (Screen.fullScreenMode == value)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700062B")]
		public int Display
		{
			[Cpp2IlInjected.Token(Token = "0x6002B4E")]
			[Cpp2IlInjected.Address(RVA = "0x8BF7D0", Offset = "0x8BE1D0", VA = "0x1808BF7D0")]
			get
			{
				int defaultValue = 0;
				return PlayerPrefs.GetInt("UnitySelectMonitor", defaultValue);
			}
			[Cpp2IlInjected.Token(Token = "0x6002B4F")]
			[Cpp2IlInjected.Address(RVA = "0x8C0240", Offset = "0x8BEC40", VA = "0x1808C0240")]
			set
			{
				PlayerPrefs.SetInt("UnitySelectMonitor", value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700062C")]
		public Vector2Int Resolution
		{
			[Cpp2IlInjected.Token(Token = "0x6002B50")]
			[Cpp2IlInjected.Address(RVA = "0x8BFB30", Offset = "0x8BE530", VA = "0x1808BFB30")]
			get
			{
				int num = 0;
				int width = Screen.width;
				int num2 = 0;
				int height = Screen.height;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B51")]
			[Cpp2IlInjected.Address(RVA = "0x8C0AE0", Offset = "0x8BF4E0", VA = "0x1808C0AE0")]
			set
			{
				//Discarded unreachable code: IL_0063
				//IL_0056: Expected I4, but got O
				int num = 0;
				int width = Screen.width;
				int num2 = 0;
				int height = Screen.height;
				if ((IntPtr)width != (IntPtr)value || (IntPtr)width != (IntPtr)value)
				{
					int num3 = 0;
					FullScreenMode fullScreenMode = Screen.fullScreenMode;
					int x = value.m_X;
					int num4 = 0;
					GameSettingsData data = (GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data;
					Resolution currentResolution = Screen.currentResolution;
					int refreshRate = currentResolution.m_RefreshRate;
					int num5 = 0;
					data.refreshRate_ = (int)currentResolution;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700062D")]
		public float ResolutionScale
		{
			[Cpp2IlInjected.Token(Token = "0x6002B52")]
			[Cpp2IlInjected.Address(RVA = "0x8BFAE0", Offset = "0x8BE4E0", VA = "0x1808BFAE0")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).resolutionScale_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B53")]
			[Cpp2IlInjected.Address(RVA = "0x8C0A20", Offset = "0x8BF420", VA = "0x1808C0A20")]
			set
			{
				//Discarded unreachable code: IL_0035
				int num = 0;
				if (((BaseStorage<DataType>)(object)Settings).Data != null)
				{
					int num2 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).resolutionScale_ = value;
					ApplyResolutionScale();
					int num3 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700062E")]
		public int RefreshRate
		{
			[Cpp2IlInjected.Token(Token = "0x6002B55")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA90", Offset = "0x8BE490", VA = "0x1808BFA90")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).refreshRate_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B56")]
			[Cpp2IlInjected.Address(RVA = "0x8C0960", Offset = "0x8BF360", VA = "0x1808C0960")]
			set
			{
				//Discarded unreachable code: IL_003a
				int num = 0;
				if (((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).refreshRate_ != value)
				{
					int num2 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).refreshRate_ = value;
					ApplyRefreshRate();
					int num3 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700062F")]
		public string GraphicPreset
		{
			[Cpp2IlInjected.Token(Token = "0x6002B58")]
			[Cpp2IlInjected.Address(RVA = "0x8BF8B0", Offset = "0x8BE2B0", VA = "0x1808BF8B0")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).graphicPreset_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B59")]
			[Cpp2IlInjected.Address(RVA = "0x8C0440", Offset = "0x8BEE40", VA = "0x1808C0440")]
			set
			{
				//Discarded unreachable code: IL_0049
				int num = 0;
				if (((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).graphicPreset_ != value)
				{
					int num2 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).GraphicPreset = value;
					ApplyGraphicPreset(force: true);
					int num3 = 0;
					UpdatePresetSettings();
					int num4 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000630")]
		public UnityEngine.ShadowResolution ShadowResolution
		{
			[Cpp2IlInjected.Token(Token = "0x6002B5E")]
			[Cpp2IlInjected.Address(RVA = "0x8BFC70", Offset = "0x8BE670", VA = "0x1808BFC70")]
			get
			{
				int num = 0;
				int shadowResolution_ = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).shadowResolution_;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002B5F")]
			[Cpp2IlInjected.Address(RVA = "0x8C0CB0", Offset = "0x8BF6B0", VA = "0x1808C0CB0")]
			set
			{
				//Discarded unreachable code: IL_003d
				int num = 0;
				if (((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).shadowResolution_ != (int)value)
				{
					int num2 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).shadowResolution_ = (int)value;
					ApplyShadowResolution();
					int num3 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000631")]
		public float DistanceQuality
		{
			[Cpp2IlInjected.Token(Token = "0x6002B61")]
			[Cpp2IlInjected.Address(RVA = "0x8BF810", Offset = "0x8BE210", VA = "0x1808BF810")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).distanceQuality_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B62")]
			[Cpp2IlInjected.Address(RVA = "0x8C0280", Offset = "0x8BEC80", VA = "0x1808C0280")]
			set
			{
				//Discarded unreachable code: IL_0046
				int num = 0;
				if (((BaseStorage<DataType>)(object)Settings).Data != null)
				{
					int num2 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).distanceQuality_ = value;
					int num3 = 0;
					QualitySettings.lodBias = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).distanceQuality_;
					int num4 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000632")]
		public int TextureQuality
		{
			[Cpp2IlInjected.Token(Token = "0x6002B64")]
			[Cpp2IlInjected.Address(RVA = "0x8BFD10", Offset = "0x8BE710", VA = "0x1808BFD10")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).textureQuality_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B65")]
			[Cpp2IlInjected.Address(RVA = "0x8C0E30", Offset = "0x8BF830", VA = "0x1808C0E30")]
			set
			{
				//Discarded unreachable code: IL_004c
				int num = 0;
				if (((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).textureQuality_ != value)
				{
					int num2 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).textureQuality_ = value;
					int num3 = 0;
					QualitySettings.masterTextureLimit = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).textureQuality_;
					int num4 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000633")]
		public bool VSync
		{
			[Cpp2IlInjected.Token(Token = "0x6002B67")]
			[Cpp2IlInjected.Address(RVA = "0x8BFDB0", Offset = "0x8BE7B0", VA = "0x1808BFDB0")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).vSync_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B68")]
			[Cpp2IlInjected.Address(RVA = "0x8C10B0", Offset = "0x8BFAB0", VA = "0x1808C10B0")]
			set
			{
				//Discarded unreachable code: IL_004a
				//IL_0039: Expected O, but got I4
				int num = 0;
				if (((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).vSync_ != value)
				{
					int num2 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).vSync_ = value;
					int num3 = 0;
					GameSettings settings = Settings;
					int num4 = 0;
					SettingScope.ApplyVSyncSetting(settings, (GraphicSettingsData)num4);
					int num5 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000634")]
		public bool DisableCameraShakes
		{
			[Cpp2IlInjected.Token(Token = "0x6002B6A")]
			[Cpp2IlInjected.Address(RVA = "0x8BF720", Offset = "0x8BE120", VA = "0x1808BF720")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).disableCameraShakes_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B6B")]
			[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BEA90", VA = "0x1808C0090")]
			set
			{
				//Discarded unreachable code: IL_003a
				int num = 0;
				if (((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).disableCameraShakes_ != value)
				{
					int num2 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).disableCameraShakes_ = value;
					ApplyDisableCameraShakes();
					int num3 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000635")]
		public bool DisableFlashes
		{
			[Cpp2IlInjected.Token(Token = "0x6002B6D")]
			[Cpp2IlInjected.Address(RVA = "0x8BF770", Offset = "0x8BE170", VA = "0x1808BF770")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).disableFlashes_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B6E")]
			[Cpp2IlInjected.Address(RVA = "0x8C0150", Offset = "0x8BEB50", VA = "0x1808C0150")]
			set
			{
				//Discarded unreachable code: IL_003a
				int num = 0;
				if (((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).disableFlashes_ != value)
				{
					int num2 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).disableFlashes_ = value;
					ApplyDisableFlashes();
					int num3 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000636")]
		public float MasterVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6002B70")]
			[Cpp2IlInjected.Address(RVA = "0x8BF9F0", Offset = "0x8BE3F0", VA = "0x1808BF9F0")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).masterVolume_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B71")]
			[Cpp2IlInjected.Address(RVA = "0x8C07E0", Offset = "0x8BF1E0", VA = "0x1808C07E0")]
			set
			{
				//Discarded unreachable code: IL_0035
				int num = 0;
				if (((BaseStorage<DataType>)(object)Settings).Data != null)
				{
					int num2 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).masterVolume_ = value;
					ApplyMasterVolume();
					int num3 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000637")]
		public float MusicVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6002B73")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA40", Offset = "0x8BE440", VA = "0x1808BFA40")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).musicVolume_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B74")]
			[Cpp2IlInjected.Address(RVA = "0x8C08A0", Offset = "0x8BF2A0", VA = "0x1808C08A0")]
			set
			{
				//Discarded unreachable code: IL_0035
				int num = 0;
				if (((BaseStorage<DataType>)(object)Settings).Data != null)
				{
					int num2 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).musicVolume_ = value;
					ApplyMusicVolume();
					int num3 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000638")]
		public float SfxVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6002B76")]
			[Cpp2IlInjected.Address(RVA = "0x8BFC20", Offset = "0x8BE620", VA = "0x1808BFC20")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).sfxVolume_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B77")]
			[Cpp2IlInjected.Address(RVA = "0x8C0BF0", Offset = "0x8BF5F0", VA = "0x1808C0BF0")]
			set
			{
				//Discarded unreachable code: IL_0035
				int num = 0;
				if (((BaseStorage<DataType>)(object)Settings).Data != null)
				{
					int num2 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).sfxVolume_ = value;
					ApplySfxVolume();
					int num3 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000639")]
		public float VoiceVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6002B79")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE00", Offset = "0x8BE800", VA = "0x1808BFE00")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).voiceVolume_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B7A")]
			[Cpp2IlInjected.Address(RVA = "0x8C11C0", Offset = "0x8BFBC0", VA = "0x1808C11C0")]
			set
			{
				//Discarded unreachable code: IL_0035
				int num = 0;
				if (((BaseStorage<DataType>)(object)Settings).Data != null)
				{
					int num2 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).voiceVolume_ = value;
					ApplyVoiceVolume();
					int num3 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700063A")]
		public bool StreamingFriendlyMusic
		{
			[Cpp2IlInjected.Token(Token = "0x6002B7C")]
			[Cpp2IlInjected.Address(RVA = "0x8BFCC0", Offset = "0x8BE6C0", VA = "0x1808BFCC0")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).streamingFriendlyMusic_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B7D")]
			[Cpp2IlInjected.Address(RVA = "0x8C0D70", Offset = "0x8BF770", VA = "0x1808C0D70")]
			set
			{
				//Discarded unreachable code: IL_003a
				int num = 0;
				if (((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).streamingFriendlyMusic_ != value)
				{
					int num2 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).streamingFriendlyMusic_ = value;
					ApplyStreamingFriendlyMusic();
					int num3 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700063B")]
		public string LanguageCode
		{
			[Cpp2IlInjected.Token(Token = "0x6002B7F")]
			[Cpp2IlInjected.Address(RVA = "0x8BF9A0", Offset = "0x8BE3A0", VA = "0x1808BF9A0")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).languageCode_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B80")]
			[Cpp2IlInjected.Address(RVA = "0x8C06E0", Offset = "0x8BF0E0", VA = "0x1808C06E0")]
			set
			{
				//Discarded unreachable code: IL_004e
				int num = 0;
				if (((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).languageCode_ != value)
				{
					int num2 = 0;
					GlobalStorage.Instance.SetLastLanguage(value);
					int num3 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).LanguageCode = value;
					ApplyLanguageCode();
					int num4 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700063C")]
		public int TimeOfDayVisualOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6002B83")]
			[Cpp2IlInjected.Address(RVA = "0x8BFD60", Offset = "0x8BE760", VA = "0x1808BFD60")]
			get
			{
				//Discarded unreachable code: IL_0012
				int num = 0;
				return ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).timeOfDayVisualOffset_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002B84")]
			[Cpp2IlInjected.Address(RVA = "0x8C0F30", Offset = "0x8BF930", VA = "0x1808C0F30")]
			set
			{
				//Discarded unreachable code: IL_0050
				int num = Mathf.Clamp(value, -12, 12);
				int num2 = 0;
				if (((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).timeOfDayVisualOffset_ != value)
				{
					int num3 = 0;
					((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).timeOfDayVisualOffset_ = value;
					SystemRoot.Instance.GetSystem<AudioManager>().UpdateTimeOfDay();
					int num4 = 0;
					bool flag = ((BaseStorage<DataType>)(object)Settings).RequiresSave();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B39")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4D0", Offset = "0x8BDED0", VA = "0x1808BF4D0")]
		public static void SaveAppliedSettings()
		{
			//Discarded unreachable code: IL_0012
			int num = 0;
			GameSettings settings = Settings;
			int isForced = 0;
			((BaseStorage<DataType>)(object)settings).Save((byte)isForced != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B3E")]
		[Cpp2IlInjected.Address(RVA = "0x8BD820", Offset = "0x8BC220", VA = "0x1808BD820")]
		private void ApplyClickToMove()
		{
			//Discarded unreachable code: IL_00c9
			int num = 0;
			int num2 = 0;
			int playerCount = ReInput.players.playerCount;
			if (num >= playerCount)
			{
				return;
			}
			int num3 = 0;
			IList<Rewired.Player> players = (IList<Rewired.Player>)ReInput.players.get_Players();
			int num4 = 0;
			if (_003C_003Ec._003C_003E9__10_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((ControllerMapLayoutManager.RuleSet item) => string.Equals(item._tag, "clicktomoveON"));
			}
			Action<ControllerMapLayoutManager.RuleSet> action = default(Action<ControllerMapLayoutManager.RuleSet>);
			if (_003C_003Ec._003C_003E9__10_1 == null)
			{
				action = (Action<ControllerMapLayoutManager.RuleSet>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(ControllerMapLayoutManager.RuleSet item)
				{
					//Discarded unreachable code: IL_001a
					int num6 = 0;
					bool flag2 = (item._enabled = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).clickToMove_);
				});
			}
			List<> list = default(List<>);
			((List<T>)(object)list).ForEach((Action<>)(object)action);
			Predicate<ControllerMapLayoutManager.RuleSet> predicate = default(Predicate<ControllerMapLayoutManager.RuleSet>);
			if (_003C_003Ec._003C_003E9__10_2 == null)
			{
				predicate = (Predicate<ControllerMapLayoutManager.RuleSet>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((ControllerMapLayoutManager.RuleSet item) => string.Equals(item._tag, "clicktomoveOFF")));
			}
			List<> list2 = ((List<T>)(object)list).FindAll((Predicate<>)(object)predicate);
			Action<ControllerMapLayoutManager.RuleSet> action2 = default(Action<ControllerMapLayoutManager.RuleSet>);
			if (_003C_003Ec._003C_003E9__10_3 == null)
			{
				action2 = (Action<ControllerMapLayoutManager.RuleSet>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(ControllerMapLayoutManager.RuleSet item)
				{
					//Discarded unreachable code: IL_001d
					int num5 = 0;
					bool flag = (item._enabled = !((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).clickToMove_);
				});
			}
			((List<T>)(object)list2).ForEach((Action<>)(object)action2);
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B3F")]
		[Cpp2IlInjected.Address(RVA = "0x8BE270", Offset = "0x8BCC70", VA = "0x1808BE270")]
		private void ApplyInvertCamera()
		{
			//Discarded unreachable code: IL_0096
			int[] array = new int[8];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			int num = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = 0;
			Rewired.Player.ControllerHelper.MapHelper maps = players.GetPlayer(playerId).controllers.maps;
			int num2 = 0;
			int length = array.Length;
			if (num2 >= length)
			{
				return;
			}
			int num3 = array[num2];
			List<ActionElementMap> list = (List<ActionElementMap>)(object)new List<T>();
			int num4 = 0;
			int axisMapsWithAction = maps.GetAxisMapsWithAction(num3, (byte)num4 != 0, (List<>)(object)list);
			Action<ActionElementMap> _003C_003E9__11_ = _003C_003Ec._003C_003E9__11_0;
			if (_003C_003E9__11_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(ActionElementMap i)
				{
					//Discarded unreachable code: IL_001a
					int num5 = 0;
					bool flag = (i._invert = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).invertCamera_);
				};
			}
			((List<T>)(object)list).ForEach((Action<>)(object)_003C_003E9__11_);
			num2++;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B42")]
		[Cpp2IlInjected.Address(RVA = "0x8BD7B0", Offset = "0x8BC1B0", VA = "0x1808BD7B0")]
		private void ApplyCameraMouseSensitivity()
		{
			//Discarded unreachable code: IL_0021
			InputBehavior cameraInputBehavior = _cameraInputBehavior;
			int num = 0;
			float num2 = (cameraInputBehavior.mouseXYAxisSensitivity = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).cameraMouseSensitivity_);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B45")]
		[Cpp2IlInjected.Address(RVA = "0x8BD740", Offset = "0x8BC140", VA = "0x1808BD740")]
		private void ApplyCameraGamepadSensitivity()
		{
			//Discarded unreachable code: IL_0021
			InputBehavior cameraInputBehavior = _cameraInputBehavior;
			int num = 0;
			float num2 = (cameraInputBehavior.joystickAxisSensitivity = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).cameraGamepadSensitivity_);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B48")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void ApplyGamepadVibration()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002B4B")]
		[Cpp2IlInjected.Address(RVA = "0x8BE510", Offset = "0x8BCF10", VA = "0x1808BE510")]
		private void ApplyKeyboardLayout()
		{
			int num = 0;
			CustomizedPlayerInputSystem.ApplyKeyboardLayout();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B54")]
		[Cpp2IlInjected.Address(RVA = "0x8BE800", Offset = "0x8BD200", VA = "0x1808BE800")]
		[Conditional("USE_GRAPHIC_SETTINGS")]
		private void ApplyResolutionScale()
		{
			//Discarded unreachable code: IL_0021
			UniversalRenderPipelineAsset universalRenderPipeline = _universalRenderPipeline;
			int num = 0;
			float num2 = (universalRenderPipeline.renderScale = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).resolutionScale_);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B57")]
		[Cpp2IlInjected.Address(RVA = "0x8BE780", Offset = "0x8BD180", VA = "0x1808BE780")]
		[Conditional("USE_GRAPHIC_SETTINGS")]
		private void ApplyRefreshRate()
		{
			//Discarded unreachable code: IL_001b
			Resolution currentResolution = Screen.currentResolution;
			int num = 0;
			int refreshRate = currentResolution.m_RefreshRate;
			GameSettingsData data = (GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B5A")]
		[Cpp2IlInjected.Address(RVA = "0x8BE740", Offset = "0x8BD140", VA = "0x1808BE740")]
		private void ApplyPresetDefaultSettings()
		{
			QualitySettings.shadowResolution = _currentPresetDefaultShadowResolution;
			QualitySettings.lodBias = _currentPresetDefaultLodBias;
			QualitySettings.masterTextureLimit = _currentPresetDefaultMasterTextureLimit;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B5B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF520", Offset = "0x8BDF20", VA = "0x1808BF520")]
		private void SavePresetDefaultSettings()
		{
			int num = 0;
			UnityEngine.ShadowResolution shadowResolution = QualitySettings.shadowResolution;
			int num2 = 0;
			_currentPresetDefaultShadowResolution = shadowResolution;
			float lodBias = QualitySettings.lodBias;
			int num3 = 0;
			_currentPresetDefaultLodBias = lodBias;
			int num4 = (_currentPresetDefaultMasterTextureLimit = QualitySettings.masterTextureLimit);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B5C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF560", Offset = "0x8BDF60", VA = "0x1808BF560")]
		private static void UpdatePresetSettings()
		{
			//Discarded unreachable code: IL_0061
			int num = 0;
			GameSettingsData data = (GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data;
			int num2 = 0;
			UnityEngine.ShadowResolution shadowResolution = QualitySettings.shadowResolution;
			int num3 = 0;
			data.shadowResolution_ = (int)shadowResolution;
			GameSettingsData data2 = (GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data;
			int num4 = 0;
			float lodBias = QualitySettings.lodBias;
			int num5 = 0;
			data2.distanceQuality_ = lodBias;
			GameSettingsData data3 = (GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data;
			int num6 = 0;
			int num7 = (data3.textureQuality_ = QualitySettings.masterTextureLimit);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B5D")]
		[Cpp2IlInjected.Address(RVA = "0x8BE100", Offset = "0x8BCB00", VA = "0x1808BE100")]
		[Conditional("USE_GRAPHIC_SETTINGS")]
		private void ApplyGraphicPreset(bool force)
		{
			//Discarded unreachable code: IL_00ac
			if (!force)
			{
				int num = 0;
				string graphicPreset_ = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).graphicPreset_;
				int num2 = 0;
				string[] names = QualitySettings.names;
				int num3 = 0;
				int qualityLevel = QualitySettings.GetQualityLevel();
				string text = names[qualityLevel];
				if (!(graphicPreset_ != text))
				{
					return;
				}
			}
			QualitySettings.shadowResolution = _currentPresetDefaultShadowResolution;
			QualitySettings.lodBias = _currentPresetDefaultLodBias;
			QualitySettings.masterTextureLimit = _currentPresetDefaultMasterTextureLimit;
			int num4 = 0;
			GraphicSettings.UpdateQuality(((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).graphicPreset_);
			int num5 = 0;
			UnityEngine.ShadowResolution shadowResolution = QualitySettings.shadowResolution;
			int num6 = 0;
			_currentPresetDefaultShadowResolution = shadowResolution;
			float lodBias = QualitySettings.lodBias;
			int num7 = 0;
			_currentPresetDefaultLodBias = lodBias;
			int num8 = (_currentPresetDefaultMasterTextureLimit = QualitySettings.masterTextureLimit);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B60")]
		[Cpp2IlInjected.Address(RVA = "0x8BE8E0", Offset = "0x8BD2E0", VA = "0x1808BE8E0")]
		[Conditional("USE_GRAPHIC_SETTINGS")]
		private void ApplyShadowResolution()
		{
			//Discarded unreachable code: IL_0067
			//IL_0058: Expected O, but got I4
			//IL_0066: Expected O, but got I4
			int num = 0;
			if ("m_AdditionalLightsShadowmapResolution" == null)
			{
			}
			int num2 = 0;
			Type typeFromHandle = typeof(UniversalRenderPipelineAsset);
			Type typeFromHandle2 = typeof(UniversalRenderPipelineAsset);
			int num3 = 0;
			int shadowResolution_ = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).shadowResolution_;
			if (shadowResolution_ != 0 && shadowResolution_ != 0)
			{
				switch (shadowResolution_)
				{
				}
			}
			FieldInfo fieldInfo = default(FieldInfo);
			int num4 = default(int);
			fieldInfo.SetValue("m_AdditionalLightsShadowmapResolution", num4);
			FieldInfo fieldInfo2 = default(FieldInfo);
			int num5 = default(int);
			fieldInfo2.SetValue("m_AdditionalLightsShadowmapResolution", num5);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B63")]
		[Cpp2IlInjected.Address(RVA = "0x8BE0A0", Offset = "0x8BCAA0", VA = "0x1808BE0A0")]
		[Conditional("USE_GRAPHIC_SETTINGS")]
		private void ApplyDistanceQuality()
		{
			//Discarded unreachable code: IL_0017
			int num = 0;
			QualitySettings.lodBias = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).distanceQuality_;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B66")]
		[Cpp2IlInjected.Address(RVA = "0x8BEBA0", Offset = "0x8BD5A0", VA = "0x1808BEBA0")]
		[Conditional("USE_GRAPHIC_SETTINGS")]
		private void ApplyTextureQuality()
		{
			//Discarded unreachable code: IL_0017
			int num = 0;
			QualitySettings.masterTextureLimit = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).textureQuality_;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B69")]
		[Cpp2IlInjected.Address(RVA = "0x8BEC00", Offset = "0x8BD600", VA = "0x1808BEC00")]
		[Conditional("USE_GRAPHIC_SETTINGS")]
		private void ApplyVSync()
		{
			//IL_0011: Expected O, but got I4
			int num = 0;
			GameSettings settings = Settings;
			int num2 = 0;
			SettingScope.ApplyVSyncSetting(settings, (GraphicSettingsData)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B6C")]
		[Cpp2IlInjected.Address(RVA = "0x8BDD40", Offset = "0x8BC740", VA = "0x1808BDD40")]
		private void ApplyDisableCameraShakes()
		{
			//Discarded unreachable code: IL_002d
			CameraFeedbackSystem component = SystemRoot.Instance._playerCamera.GetComponent<CameraFeedbackSystem>();
			int num = 0;
			bool flag2 = (component.enabled = !((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).disableCameraShakes_);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B6F")]
		[Cpp2IlInjected.Address(RVA = "0x8BDE60", Offset = "0x8BC860", VA = "0x1808BDE60")]
		private void ApplyDisableFlashes()
		{
			//Discarded unreachable code: IL_004d
			Client metaClient = SystemRoot.Instance.MetaClient;
			if (metaClient != null && (long)metaClient.profile != 0)
			{
				WeatherSystem system = SystemRoot.Instance.GetSystem<WeatherSystem>();
				string currentWeather_ = SystemRoot.Instance.MetaClient.profile.world_.currentWeather_;
				system.TransitionToWeather(currentWeather_).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B72")]
		[Cpp2IlInjected.Address(RVA = "0x8BE660", Offset = "0x8BD060", VA = "0x1808BE660")]
		private void ApplyMasterVolume()
		{
			//Discarded unreachable code: IL_0021
			RTPC masterVolumeRTPC = _masterVolumeRTPC;
			int num = 0;
			float masterVolume_ = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).masterVolume_;
			masterVolumeRTPC.SetGlobalValue(masterVolume_);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B75")]
		[Cpp2IlInjected.Address(RVA = "0x8BE6D0", Offset = "0x8BD0D0", VA = "0x1808BE6D0")]
		private void ApplyMusicVolume()
		{
			//Discarded unreachable code: IL_0021
			RTPC musicVolumeRTPC = _musicVolumeRTPC;
			int num = 0;
			float musicVolume_ = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).musicVolume_;
			musicVolumeRTPC.SetGlobalValue(musicVolume_);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B78")]
		[Cpp2IlInjected.Address(RVA = "0x8BE870", Offset = "0x8BD270", VA = "0x1808BE870")]
		private void ApplySfxVolume()
		{
			//Discarded unreachable code: IL_0021
			RTPC sfxVolumeRTPC = _sfxVolumeRTPC;
			int num = 0;
			float sfxVolume_ = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).sfxVolume_;
			sfxVolumeRTPC.SetGlobalValue(sfxVolume_);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B7B")]
		[Cpp2IlInjected.Address(RVA = "0x8BEC60", Offset = "0x8BD660", VA = "0x1808BEC60")]
		private void ApplyVoiceVolume()
		{
			//Discarded unreachable code: IL_0021
			RTPC voiceVolumeRTPC = _voiceVolumeRTPC;
			int num = 0;
			float voiceVolume_ = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).voiceVolume_;
			voiceVolumeRTPC.SetGlobalValue(voiceVolume_);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B7E")]
		[Cpp2IlInjected.Address(RVA = "0x8BEB10", Offset = "0x8BD510", VA = "0x1808BEB10")]
		private void ApplyStreamingFriendlyMusic()
		{
			int num = 0;
			GameSettingsData data = (GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data;
			int num2 = 0;
			if ((data.streamingFriendlyMusic_ ? 1 : 0) == num2)
			{
				AK.Wwise.Event @event = streamingFriendlyMusicOff;
				GameObject gameObject = base.gameObject;
				uint num3 = @event.Post(gameObject);
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B81")]
		[Cpp2IlInjected.Address(RVA = "0x8BE560", Offset = "0x8BCF60", VA = "0x1808BE560")]
		private void ApplyLanguageCode()
		{
			//Discarded unreachable code: IL_0025
			LocalizationManager localizationManager = SystemRoot.Instance._localizationManager;
			int num = 0;
			string languageCode_ = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).languageCode_;
			localizationManager.ChangeLanguage(languageCode_);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B82")]
		[Cpp2IlInjected.Address(RVA = "0x8BECD0", Offset = "0x8BD6D0", VA = "0x1808BECD0")]
		public Dictionary<string, string> GetLanguageChoices()
		{
			//Discarded unreachable code: IL_000d
			int num = 0;
			return (Dictionary<string, string>)(object)Settings.GetLanguageChoices();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B85")]
		[Cpp2IlInjected.Address(RVA = "0x8BED00", Offset = "0x8BD700", VA = "0x1808BED00", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			//Discarded unreachable code: IL_0225, IL_022b, IL_0231, IL_0237, IL_023d, IL_0243, IL_0249, IL_024f, IL_0255, IL_025b, IL_0261, IL_0267, IL_026d, IL_0273, IL_0279, IL_027f, IL_0285, IL_028b, IL_0291, IL_0297, IL_029d, IL_02a3, IL_02a9, IL_02af, IL_02b5
			//IL_0064: Expected O, but got I4
			MiniProfile miniProfile;
			while (true)
			{
				int num = 0;
				int num2 = 0;
				ReInput.PlayerHelper players = ReInput.players;
				int playerId = 0;
				InputBehavior inputBehavior = (_cameraInputBehavior = players.GetPlayer(playerId).controllers.maps.GetInputBehavior("Camera"));
				int num3 = 0;
				if (inputBehavior == null)
				{
				}
				int num4 = 0;
				_universalRenderPipeline = (UniversalRenderPipelineAsset)(object)inputBehavior;
				int refreshRate = Screen.currentResolution.m_RefreshRate;
				int refreshRate2 = Screen.currentResolution.m_RefreshRate;
				initialResolution = (Vector2Int)refreshRate;
				float num5 = (initialResolutionScale = _universalRenderPipeline.m_RenderScale);
				int num6 = 0;
				if (((BaseStorage<DataType>)(object)Settings).Data == null)
				{
					int num7 = 0;
					GameSettingsData data2 = (GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data;
					float num8 = (data2.resolutionScale_ = _universalRenderPipeline.m_RenderScale);
				}
				int num9 = (initialRefreshRate = Screen.currentResolution.m_RefreshRate);
				int num10 = 0;
				if (((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).refreshRate_ == 0)
				{
					int num11 = 0;
					GameSettingsData data3 = (GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data;
					int num12 = (data3.refreshRate_ = initialRefreshRate);
				}
				int num13 = 0;
				string[] names = QualitySettings.names;
				int num14 = 0;
				int qualityLevel = QualitySettings.GetQualityLevel();
				string text = (initialGraphicPreset = names[qualityLevel]);
				int num15 = 0;
				UnityEngine.ShadowResolution shadowResolution = (_currentPresetDefaultShadowResolution = QualitySettings.shadowResolution);
				int num16 = 0;
				float num17 = (_currentPresetDefaultLodBias = QualitySettings.lodBias);
				int num18 = 0;
				int num19 = (_currentPresetDefaultMasterTextureLimit = QualitySettings.masterTextureLimit);
				int num20 = 0;
				GameSettingsData data4 = (GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data;
				string graphicPreset_ = data4.graphicPreset_;
				if (data4 != null)
				{
					int num21 = 0;
					GameSettingsData data5 = (GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data;
					string text3 = (data5.GraphicPreset = initialGraphicPreset);
					int num22 = 0;
					UpdatePresetSettings();
				}
				LocalStorage _003CLocalStorage_003Ek__BackingField = SystemRoot.Instance.MetaClient.LocalStorage;
				if (_003CLocalStorage_003Ek__BackingField != null)
				{
					miniProfile = _003CLocalStorage_003Ek__BackingField.MiniProfile;
					if (miniProfile != null)
					{
						break;
					}
				}
			}
			string currentCountry = default(string);
			if (string.IsNullOrEmpty(miniProfile.playerCountryCode_))
			{
				int num23 = 0;
				currentCountry = RegionUtils.GetCurrentCountry();
			}
			if (RegionUtils.COUNTRY_CODE_FRIENDLY_STREAMING.Contains(currentCountry))
			{
				int num24 = 0;
				((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).streamingFriendlyMusic_ = true;
			}
			int num25 = 0;
			GameSettings settings = Settings;
			int isForced = 0;
			((BaseStorage<DataType>)(object)settings).Save((byte)isForced != 0);
			ApplyAllSettings();
			UnityEngine.Debug.LogError("Exception was raised in GameSettingsSystem.OnSystemStart THIS NEEDS TO BE FIXED.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002B86")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnSystemPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002B87")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002B88")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
		public override void OnSystemStop()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002B89")]
		[Cpp2IlInjected.Address(RVA = "0x8BF350", Offset = "0x8BDD50", VA = "0x1808BF350")]
		public void ResetToDefaults()
		{
			//Discarded unreachable code: IL_00a9
			int num = 0;
			((BaseStorage<DataType>)(object)Settings).ResetToDefault();
			int value = 0;
			PlayerPrefs.SetInt("UnitySelectMonitor", value);
			Vector2Int vector2Int = initialResolution;
			Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
			int num2 = 0;
			GameSettingsData data = (GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data;
			float num3 = (data.resolutionScale_ = initialResolutionScale);
			int num4 = 0;
			GameSettingsData data2 = (GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data;
			int num5 = (data2.refreshRate_ = initialRefreshRate);
			int num6 = 0;
			GameSettingsData data3 = (GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data;
			string text2 = (data3.GraphicPreset = initialGraphicPreset);
			ApplyGraphicPreset(force: true);
			int num7 = 0;
			UpdatePresetSettings();
			int num8 = 0;
			((BaseStorage<DataType>)(object)Settings).Save(isForced: true);
			ApplyAllSettings();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B8A")]
		[Cpp2IlInjected.Address(RVA = "0x8BD2F0", Offset = "0x8BBCF0", VA = "0x1808BD2F0")]
		private void ApplyAllSettings()
		{
			//Discarded unreachable code: IL_0184
			//IL_00d7: Expected O, but got I4
			ApplyInvertCamera();
			ApplyClickToMove();
			InputBehavior cameraInputBehavior = _cameraInputBehavior;
			int num = 0;
			float num2 = (cameraInputBehavior.mouseXYAxisSensitivity = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).cameraMouseSensitivity_);
			InputBehavior cameraInputBehavior2 = _cameraInputBehavior;
			int num3 = 0;
			float num4 = (cameraInputBehavior2.joystickAxisSensitivity = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).cameraGamepadSensitivity_);
			int num5 = 0;
			CustomizedPlayerInputSystem.ApplyKeyboardLayout();
			UniversalRenderPipelineAsset universalRenderPipeline = _universalRenderPipeline;
			int num6 = 0;
			float num7 = (universalRenderPipeline.renderScale = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).resolutionScale_);
			ApplyRefreshRate();
			int force = 0;
			ApplyGraphicPreset((byte)force != 0);
			ApplyShadowResolution();
			int num8 = 0;
			QualitySettings.lodBias = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).distanceQuality_;
			int num9 = 0;
			QualitySettings.masterTextureLimit = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).textureQuality_;
			int num10 = 0;
			GameSettings settings = Settings;
			int num11 = 0;
			SettingScope.ApplyVSyncSetting(settings, (GraphicSettingsData)num11);
			ApplyDisableCameraShakes();
			ApplyDisableFlashes();
			RTPC masterVolumeRTPC = _masterVolumeRTPC;
			int num12 = 0;
			float masterVolume_ = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).masterVolume_;
			masterVolumeRTPC.SetGlobalValue(masterVolume_);
			RTPC musicVolumeRTPC = _musicVolumeRTPC;
			int num13 = 0;
			float musicVolume_ = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).musicVolume_;
			musicVolumeRTPC.SetGlobalValue(musicVolume_);
			RTPC sfxVolumeRTPC = _sfxVolumeRTPC;
			int num14 = 0;
			float sfxVolume_ = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).sfxVolume_;
			sfxVolumeRTPC.SetGlobalValue(sfxVolume_);
			RTPC voiceVolumeRTPC = _voiceVolumeRTPC;
			int num15 = 0;
			float voiceVolume_ = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).voiceVolume_;
			voiceVolumeRTPC.SetGlobalValue(voiceVolume_);
			ApplyStreamingFriendlyMusic();
			ApplyLanguageCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B8B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public GameSettingsSystem()
		{
		}
	}
}
