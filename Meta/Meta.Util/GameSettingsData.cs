using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Epic.OnlineServices;
using Epic.OnlineServices.Platform;
using Epic.OnlineServices.Sessions;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Meta.Online;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AAB")]
	public sealed class GameSettingsData : IMessage<GameSettingsData>, IMessage, IEquatable<GameSettingsData>, IDeepCloneable<GameSettingsData>, IMessageFieldAccessor, IStorageVersioning
	{
		[Cpp2IlInjected.Token(Token = "0x4002A8E")]
		private static readonly MessageParser<GameSettingsData> _parser = (MessageParser<GameSettingsData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new GameSettingsData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002A8F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002A90")]
		public const int InvertCameraFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002A91")]
		private bool invertCamera_;

		[Cpp2IlInjected.Token(Token = "0x4002A92")]
		public const int CameraMouseSensitivityFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002A93")]
		private float cameraMouseSensitivity_;

		[Cpp2IlInjected.Token(Token = "0x4002A94")]
		public const int CameraGamepadSensitivityFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002A95")]
		private float cameraGamepadSensitivity_;

		[Cpp2IlInjected.Token(Token = "0x4002A96")]
		public const int GamepadVibrationFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002A97")]
		private bool gamepadVibration_;

		[Cpp2IlInjected.Token(Token = "0x4002A98")]
		public const int ClickToMoveFieldNumber = 70;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4002A99")]
		private bool clickToMove_;

		[Cpp2IlInjected.Token(Token = "0x4002A9A")]
		public const int MasterVolumeFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002A9B")]
		private float masterVolume_;

		[Cpp2IlInjected.Token(Token = "0x4002A9C")]
		public const int MusicVolumeFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4002A9D")]
		private float musicVolume_;

		[Cpp2IlInjected.Token(Token = "0x4002A9E")]
		public const int SfxVolumeFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002A9F")]
		private float sfxVolume_;

		[Cpp2IlInjected.Token(Token = "0x4002AA0")]
		public const int VoiceVolumeFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4002AA1")]
		private float voiceVolume_;

		[Cpp2IlInjected.Token(Token = "0x4002AA2")]
		public const int ResolutionScaleFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002AA3")]
		private float resolutionScale_;

		[Cpp2IlInjected.Token(Token = "0x4002AA4")]
		public const int RefreshRateFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4002AA5")]
		private int refreshRate_;

		[Cpp2IlInjected.Token(Token = "0x4002AA6")]
		public const int GraphicPresetFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002AA7")]
		private string graphicPreset_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002AA8")]
		public const int ShadowResolutionFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002AA9")]
		private int shadowResolution_;

		[Cpp2IlInjected.Token(Token = "0x4002AAA")]
		public const int DistanceQualityFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4002AAB")]
		private float distanceQuality_;

		[Cpp2IlInjected.Token(Token = "0x4002AAC")]
		public const int TextureQualityFieldNumber = 17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002AAD")]
		private int textureQuality_;

		[Cpp2IlInjected.Token(Token = "0x4002AAE")]
		public const int VSyncFieldNumber = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4002AAF")]
		private bool vSync_;

		[Cpp2IlInjected.Token(Token = "0x4002AB0")]
		public const int DisableCameraShakesFieldNumber = 19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x55")]
		[Cpp2IlInjected.Token(Token = "0x4002AB1")]
		private bool disableCameraShakes_;

		[Cpp2IlInjected.Token(Token = "0x4002AB2")]
		public const int DisableFlashesFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x56")]
		[Cpp2IlInjected.Token(Token = "0x4002AB3")]
		private bool disableFlashes_;

		[Cpp2IlInjected.Token(Token = "0x4002AB4")]
		public const int LanguageCodeFieldNumber = 30;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002AB5")]
		private string languageCode_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002AB6")]
		public const int StreamingFriendlyMusicFieldNumber = 40;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002AB7")]
		private bool streamingFriendlyMusic_;

		[Cpp2IlInjected.Token(Token = "0x4002AB8")]
		public const int KeyboardLayoutFieldNumber = 50;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4002AB9")]
		private KeyboardLayout keyboardLayout_;

		[Cpp2IlInjected.Token(Token = "0x4002ABA")]
		public const int TimeOfDayVisualOffsetFieldNumber = 60;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002ABB")]
		private int timeOfDayVisualOffset_;

		[Cpp2IlInjected.Token(Token = "0x4002ABC")]
		public const int VersionFieldNumber = 100;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4002ABD")]
		private int version_;

		[Cpp2IlInjected.Token(Token = "0x1700101E")]
		[DebuggerNonUserCode]
		public static MessageParser<GameSettingsData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005CA2")]
			[Cpp2IlInjected.Address(RVA = "0x1811A40", Offset = "0x1810440", VA = "0x181811A40")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700101F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005CA3")]
			[Cpp2IlInjected.Address(RVA = "0x1811950", Offset = "0x1810350", VA = "0x181811950")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001020")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005CA4")]
			[Cpp2IlInjected.Address(RVA = "0x1811AA0", Offset = "0x18104A0", VA = "0x181811AA0", Slot = "8")]
			get
			{
				int num = 0;
				return Descriptor;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001021")]
		[DebuggerNonUserCode]
		public bool InvertCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6005CA8")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return invertCamera_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CA9")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				invertCamera_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001022")]
		[DebuggerNonUserCode]
		public float CameraMouseSensitivity
		{
			[Cpp2IlInjected.Token(Token = "0x6005CAA")]
			[Cpp2IlInjected.Address(RVA = "0x837320", Offset = "0x835D20", VA = "0x180837320")]
			get
			{
				return cameraMouseSensitivity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CAB")]
			[Cpp2IlInjected.Address(RVA = "0x837340", Offset = "0x835D40", VA = "0x180837340")]
			set
			{
				cameraMouseSensitivity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001023")]
		[DebuggerNonUserCode]
		public float CameraGamepadSensitivity
		{
			[Cpp2IlInjected.Token(Token = "0x6005CAC")]
			[Cpp2IlInjected.Address(RVA = "0x823EA0", Offset = "0x8228A0", VA = "0x180823EA0")]
			get
			{
				return cameraGamepadSensitivity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CAD")]
			[Cpp2IlInjected.Address(RVA = "0x8242A0", Offset = "0x822CA0", VA = "0x1808242A0")]
			set
			{
				cameraGamepadSensitivity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001024")]
		[DebuggerNonUserCode]
		public bool GamepadVibration
		{
			[Cpp2IlInjected.Token(Token = "0x6005CAE")]
			[Cpp2IlInjected.Address(RVA = "0x1703600", Offset = "0x1702000", VA = "0x181703600")]
			get
			{
				return gamepadVibration_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CAF")]
			[Cpp2IlInjected.Address(RVA = "0x1703720", Offset = "0x1702120", VA = "0x181703720")]
			set
			{
				gamepadVibration_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001025")]
		[DebuggerNonUserCode]
		public bool ClickToMove
		{
			[Cpp2IlInjected.Token(Token = "0x6005CB0")]
			[Cpp2IlInjected.Address(RVA = "0x1811940", Offset = "0x1810340", VA = "0x181811940")]
			get
			{
				return clickToMove_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CB1")]
			[Cpp2IlInjected.Address(RVA = "0x1811AF0", Offset = "0x18104F0", VA = "0x181811AF0")]
			set
			{
				clickToMove_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001026")]
		[DebuggerNonUserCode]
		public float MasterVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6005CB2")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF60", Offset = "0xA7C960", VA = "0x180A7DF60")]
			get
			{
				return masterVolume_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CB3")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF80", Offset = "0xA7C980", VA = "0x180A7DF80")]
			set
			{
				masterVolume_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001027")]
		[DebuggerNonUserCode]
		public float MusicVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6005CB4")]
			[Cpp2IlInjected.Address(RVA = "0xE3A600", Offset = "0xE39000", VA = "0x180E3A600")]
			get
			{
				return musicVolume_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CB5")]
			[Cpp2IlInjected.Address(RVA = "0xE3ABE0", Offset = "0xE395E0", VA = "0x180E3ABE0")]
			set
			{
				musicVolume_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001028")]
		[DebuggerNonUserCode]
		public float SfxVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6005CB6")]
			[Cpp2IlInjected.Address(RVA = "0x83A7F0", Offset = "0x8391F0", VA = "0x18083A7F0")]
			get
			{
				return sfxVolume_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CB7")]
			[Cpp2IlInjected.Address(RVA = "0xDD7740", Offset = "0xDD6140", VA = "0x180DD7740")]
			set
			{
				sfxVolume_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001029")]
		[DebuggerNonUserCode]
		public float VoiceVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6005CB8")]
			[Cpp2IlInjected.Address(RVA = "0xBC59C0", Offset = "0xBC43C0", VA = "0x180BC59C0")]
			get
			{
				return voiceVolume_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CB9")]
			[Cpp2IlInjected.Address(RVA = "0xBC5B40", Offset = "0xBC4540", VA = "0x180BC5B40")]
			set
			{
				voiceVolume_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700102A")]
		[DebuggerNonUserCode]
		public float ResolutionScale
		{
			[Cpp2IlInjected.Token(Token = "0x6005CBA")]
			[Cpp2IlInjected.Address(RVA = "0xA82BB0", Offset = "0xA815B0", VA = "0x180A82BB0")]
			get
			{
				return resolutionScale_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CBB")]
			[Cpp2IlInjected.Address(RVA = "0xA82CD0", Offset = "0xA816D0", VA = "0x180A82CD0")]
			set
			{
				resolutionScale_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700102B")]
		[DebuggerNonUserCode]
		public int RefreshRate
		{
			[Cpp2IlInjected.Token(Token = "0x6005CBC")]
			[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
			get
			{
				return refreshRate_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CBD")]
			[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
			set
			{
				refreshRate_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700102C")]
		[DebuggerNonUserCode]
		public string GraphicPreset
		{
			[Cpp2IlInjected.Token(Token = "0x6005CBE")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return graphicPreset_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CBF")]
			[Cpp2IlInjected.Address(RVA = "0x1811B10", Offset = "0x1810510", VA = "0x181811B10")]
			set
			{
				string text = (graphicPreset_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700102D")]
		[DebuggerNonUserCode]
		public int ShadowResolution
		{
			[Cpp2IlInjected.Token(Token = "0x6005CC0")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return shadowResolution_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CC1")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				shadowResolution_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700102E")]
		[DebuggerNonUserCode]
		public float DistanceQuality
		{
			[Cpp2IlInjected.Token(Token = "0x6005CC2")]
			[Cpp2IlInjected.Address(RVA = "0xF50B10", Offset = "0xF4F510", VA = "0x180F50B10")]
			get
			{
				return distanceQuality_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CC3")]
			[Cpp2IlInjected.Address(RVA = "0xDD6DA0", Offset = "0xDD57A0", VA = "0x180DD6DA0")]
			set
			{
				distanceQuality_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700102F")]
		[DebuggerNonUserCode]
		public int TextureQuality
		{
			[Cpp2IlInjected.Token(Token = "0x6005CC4")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return textureQuality_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CC5")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				textureQuality_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001030")]
		[DebuggerNonUserCode]
		public bool VSync
		{
			[Cpp2IlInjected.Token(Token = "0x6005CC6")]
			[Cpp2IlInjected.Address(RVA = "0x1781430", Offset = "0x177FE30", VA = "0x181781430")]
			get
			{
				return vSync_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CC7")]
			[Cpp2IlInjected.Address(RVA = "0x1781A50", Offset = "0x1780450", VA = "0x181781A50")]
			set
			{
				vSync_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001031")]
		[DebuggerNonUserCode]
		public bool DisableCameraShakes
		{
			[Cpp2IlInjected.Token(Token = "0x6005CC8")]
			[Cpp2IlInjected.Address(RVA = "0x881950", Offset = "0x880350", VA = "0x180881950")]
			get
			{
				return disableCameraShakes_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CC9")]
			[Cpp2IlInjected.Address(RVA = "0x881A60", Offset = "0x880460", VA = "0x180881A60")]
			set
			{
				disableCameraShakes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001032")]
		[DebuggerNonUserCode]
		public bool DisableFlashes
		{
			[Cpp2IlInjected.Token(Token = "0x6005CCA")]
			[Cpp2IlInjected.Address(RVA = "0x1811A20", Offset = "0x1810420", VA = "0x181811A20")]
			get
			{
				return disableFlashes_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CCB")]
			[Cpp2IlInjected.Address(RVA = "0x1811B00", Offset = "0x1810500", VA = "0x181811B00")]
			set
			{
				disableFlashes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001033")]
		[DebuggerNonUserCode]
		public string LanguageCode
		{
			[Cpp2IlInjected.Token(Token = "0x6005CCC")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return languageCode_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CCD")]
			[Cpp2IlInjected.Address(RVA = "0x1811B90", Offset = "0x1810590", VA = "0x181811B90")]
			set
			{
				string text = (languageCode_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001034")]
		[DebuggerNonUserCode]
		public bool StreamingFriendlyMusic
		{
			[Cpp2IlInjected.Token(Token = "0x6005CCE")]
			[Cpp2IlInjected.Address(RVA = "0x63F8A0", Offset = "0x63E2A0", VA = "0x18063F8A0")]
			get
			{
				return streamingFriendlyMusic_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CCF")]
			[Cpp2IlInjected.Address(RVA = "0x63FD00", Offset = "0x63E700", VA = "0x18063FD00")]
			set
			{
				streamingFriendlyMusic_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001035")]
		[DebuggerNonUserCode]
		public KeyboardLayout KeyboardLayout
		{
			[Cpp2IlInjected.Token(Token = "0x6005CD0")]
			[Cpp2IlInjected.Address(RVA = "0x1811A30", Offset = "0x1810430", VA = "0x181811A30")]
			get
			{
				return keyboardLayout_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CD1")]
			[Cpp2IlInjected.Address(RVA = "0x1811B80", Offset = "0x1810580", VA = "0x181811B80")]
			set
			{
				keyboardLayout_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001036")]
		[DebuggerNonUserCode]
		public int TimeOfDayVisualOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6005CD2")]
			[Cpp2IlInjected.Address(RVA = "0x724F70", Offset = "0x723970", VA = "0x180724F70")]
			get
			{
				return timeOfDayVisualOffset_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CD3")]
			[Cpp2IlInjected.Address(RVA = "0x7252F0", Offset = "0x723CF0", VA = "0x1807252F0")]
			set
			{
				timeOfDayVisualOffset_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001037")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6005CD4")]
			[Cpp2IlInjected.Address(RVA = "0x9604E0", Offset = "0x95EEE0", VA = "0x1809604E0", Slot = "15")]
			get
			{
				return version_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CD5")]
			[Cpp2IlInjected.Address(RVA = "0x960750", Offset = "0x95F150", VA = "0x180960750", Slot = "16")]
			set
			{
				version_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001038")]
		int IStorageVersioning.CurrentVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6005CE1")]
			[Cpp2IlInjected.Address(RVA = "0xD51100", Offset = "0xD4FB00", VA = "0x180D51100", Slot = "14")]
			get
			{
				return 1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005CA5")]
		[Cpp2IlInjected.Address(RVA = "0x18118E0", Offset = "0x18102E0", VA = "0x1818118E0")]
		[DebuggerNonUserCode]
		public GameSettingsData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005CA6")]
		[Cpp2IlInjected.Address(RVA = "0x1811790", Offset = "0x1810190", VA = "0x181811790")]
		[DebuggerNonUserCode]
		public GameSettingsData(GameSettingsData other)
		{
			bool flag = (invertCamera_ = other.invertCamera_);
			float num = (cameraMouseSensitivity_ = other.cameraMouseSensitivity_);
			float num2 = (cameraGamepadSensitivity_ = other.cameraGamepadSensitivity_);
			bool flag2 = (gamepadVibration_ = other.gamepadVibration_);
			bool flag3 = (clickToMove_ = other.clickToMove_);
			float num3 = (masterVolume_ = other.masterVolume_);
			float num4 = (musicVolume_ = other.musicVolume_);
			float num5 = (sfxVolume_ = other.sfxVolume_);
			float num6 = (voiceVolume_ = other.voiceVolume_);
			float num7 = (resolutionScale_ = other.resolutionScale_);
			int num8 = (refreshRate_ = other.refreshRate_);
			string text = (graphicPreset_ = other.graphicPreset_);
			int num9 = (shadowResolution_ = other.shadowResolution_);
			float num10 = (distanceQuality_ = other.distanceQuality_);
			int num11 = (textureQuality_ = other.textureQuality_);
			bool flag4 = (vSync_ = other.vSync_);
			bool flag5 = (disableCameraShakes_ = other.disableCameraShakes_);
			bool flag6 = (disableFlashes_ = other.disableFlashes_);
			string text2 = (languageCode_ = other.languageCode_);
			bool flag7 = (streamingFriendlyMusic_ = other.streamingFriendlyMusic_);
			KeyboardLayout keyboardLayout = (keyboardLayout_ = other.keyboardLayout_);
			int num12 = (timeOfDayVisualOffset_ = other.timeOfDayVisualOffset_);
			int num13 = (version_ = other.version_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005CA7")]
		[Cpp2IlInjected.Address(RVA = "0x180F2E0", Offset = "0x180DCE0", VA = "0x18180F2E0", Slot = "10")]
		[DebuggerNonUserCode]
		public GameSettingsData Clone()
		{
			//Discarded unreachable code: IL_019d
			GameSettingsData gameSettingsData = new GameSettingsData();
			gameSettingsData.graphicPreset_ = "";
			gameSettingsData.languageCode_ = "";
			bool flag = (gameSettingsData.invertCamera_ = invertCamera_);
			float num = (gameSettingsData.cameraMouseSensitivity_ = cameraMouseSensitivity_);
			float num2 = (gameSettingsData.cameraGamepadSensitivity_ = cameraGamepadSensitivity_);
			bool flag2 = (gameSettingsData.gamepadVibration_ = gamepadVibration_);
			bool flag3 = (gameSettingsData.clickToMove_ = clickToMove_);
			float num3 = (gameSettingsData.masterVolume_ = masterVolume_);
			float num4 = (gameSettingsData.musicVolume_ = musicVolume_);
			float num5 = (gameSettingsData.sfxVolume_ = sfxVolume_);
			float num6 = (gameSettingsData.voiceVolume_ = voiceVolume_);
			float num7 = (gameSettingsData.resolutionScale_ = resolutionScale_);
			int num8 = (gameSettingsData.refreshRate_ = refreshRate_);
			string text = (gameSettingsData.graphicPreset_ = graphicPreset_);
			int num9 = (gameSettingsData.shadowResolution_ = shadowResolution_);
			float num10 = (gameSettingsData.distanceQuality_ = distanceQuality_);
			int num11 = (gameSettingsData.textureQuality_ = textureQuality_);
			bool flag4 = (gameSettingsData.vSync_ = vSync_);
			bool flag5 = (gameSettingsData.disableCameraShakes_ = disableCameraShakes_);
			bool flag6 = (gameSettingsData.disableFlashes_ = disableFlashes_);
			string text2 = (gameSettingsData.languageCode_ = languageCode_);
			bool flag7 = (gameSettingsData.streamingFriendlyMusic_ = streamingFriendlyMusic_);
			KeyboardLayout keyboardLayout = (gameSettingsData.keyboardLayout_ = keyboardLayout_);
			int num12 = (gameSettingsData.timeOfDayVisualOffset_ = timeOfDayVisualOffset_);
			int num13 = (gameSettingsData.version_ = version_);
			UnknownFieldSet unknownFieldSet = (gameSettingsData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return gameSettingsData;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CD6")]
		[Cpp2IlInjected.Address(RVA = "0x180F460", Offset = "0x180DE60", VA = "0x18180F460", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((GameSettingsData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6005CD7")]
		[Cpp2IlInjected.Address(RVA = "0x180F4C0", Offset = "0x180DEC0", VA = "0x18180F4C0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GameSettingsData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.invertCamera_;
				if (invertCamera_ == flag)
				{
					bool flag2 = other.gamepadVibration_;
					if (gamepadVibration_ == flag2)
					{
						bool flag3 = other.clickToMove_;
						if (clickToMove_ == flag3)
						{
							int num = other.refreshRate_;
							if (refreshRate_ == num)
							{
								string text = other.graphicPreset_;
								if (!(graphicPreset_ != text))
								{
									int num2 = other.shadowResolution_;
									if (shadowResolution_ == num2)
									{
										int num3 = other.textureQuality_;
										if (textureQuality_ == num3)
										{
											bool flag4 = other.vSync_;
											if (vSync_ == flag4)
											{
												bool flag5 = other.disableCameraShakes_;
												if (disableCameraShakes_ == flag5)
												{
													bool flag6 = other.disableFlashes_;
													if (disableFlashes_ == flag6)
													{
														string text2 = other.languageCode_;
														if (!(languageCode_ != text2))
														{
															bool flag7 = other.streamingFriendlyMusic_;
															if (streamingFriendlyMusic_ == flag7)
															{
																KeyboardLayout keyboardLayout = other.keyboardLayout_;
																if (keyboardLayout_ == keyboardLayout)
																{
																	int num4 = other.timeOfDayVisualOffset_;
																	if (timeOfDayVisualOffset_ == num4)
																	{
																		int num5 = other.version_;
																		if (version_ == num5)
																		{
																			UnknownFieldSet unknownFields = other._unknownFields;
																			return object.Equals(_unknownFields, unknownFields);
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005CD8")]
		[Cpp2IlInjected.Address(RVA = "0x180FB50", Offset = "0x180E550", VA = "0x18180FB50", Slot = "2")]
		[DebuggerNonUserCode]
		public unsafe override int GetHashCode()
		{
			//Discarded unreachable code: IL_01a5
			//IL_004b: Expected O, but got I4
			//IL_0062: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			//IL_0090: Expected O, but got I4
			//IL_00a7: Expected O, but got I4
			//IL_0104: Expected O, but got I4
			bool flag;
			do
			{
				flag = invertCamera_;
				if (flag)
				{
				}
			}
			while (!flag);
			if (ProtobufEqualityComparers.BitwiseSingleEqualityComparer != null)
			{
				EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
			}
			if (gamepadVibration_)
			{
			}
			bool flag2 = clickToMove_;
			int num = default(int);
			if (flag2)
			{
				num = 0;
			}
			EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField2 = default(EqualityComparer<float>);
			if (flag2)
			{
				_003CBitwiseSingleEqualityComparer_003Ek__BackingField2 = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
				int hashCode = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField2).GetHashCode((T)num);
			}
			EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField3 = default(EqualityComparer<float>);
			if (_003CBitwiseSingleEqualityComparer_003Ek__BackingField2 != null)
			{
				_003CBitwiseSingleEqualityComparer_003Ek__BackingField3 = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
				int hashCode2 = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField3).GetHashCode((T)num);
			}
			EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField4 = default(EqualityComparer<float>);
			if (_003CBitwiseSingleEqualityComparer_003Ek__BackingField3 != null)
			{
				_003CBitwiseSingleEqualityComparer_003Ek__BackingField4 = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
				int hashCode3 = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField4).GetHashCode((T)num);
			}
			EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField5 = default(EqualityComparer<float>);
			if (_003CBitwiseSingleEqualityComparer_003Ek__BackingField4 != null)
			{
				_003CBitwiseSingleEqualityComparer_003Ek__BackingField5 = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
				int hashCode4 = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField5).GetHashCode((T)num);
			}
			EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField6 = default(EqualityComparer<float>);
			if (_003CBitwiseSingleEqualityComparer_003Ek__BackingField5 != null)
			{
				_003CBitwiseSingleEqualityComparer_003Ek__BackingField6 = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
				int hashCode5 = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField6).GetHashCode((T)num);
			}
			if (refreshRate_ != 0)
			{
				DesktopCrossplayStatus status = ((GetDesktopCrossplayStatusInfo*)_003CBitwiseSingleEqualityComparer_003Ek__BackingField6)->Status;
			}
			string text = graphicPreset_;
			if (text.m_stringLength != 0)
			{
				int hashCode6 = text.GetHashCode();
			}
			int num2 = shadowResolution_;
			int num3 = default(int);
			if (num2 != 0)
			{
				num3 = 0;
				Result resultCode = ((SessionSearchFindCallbackInfo*)text)->ResultCode;
			}
			EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField7 = default(EqualityComparer<float>);
			if (num2 != 0)
			{
				_003CBitwiseSingleEqualityComparer_003Ek__BackingField7 = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
				int hashCode7 = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField7).GetHashCode((T)num3);
			}
			if (textureQuality_ != 0)
			{
				DesktopCrossplayStatus status2 = ((GetDesktopCrossplayStatusInfo*)_003CBitwiseSingleEqualityComparer_003Ek__BackingField7)->Status;
			}
			if (vSync_)
			{
			}
			if (disableCameraShakes_)
			{
			}
			if (disableFlashes_)
			{
			}
			string text2 = languageCode_;
			if (text2.m_stringLength != 0)
			{
				int hashCode8 = text2.GetHashCode();
			}
			if (streamingFriendlyMusic_)
			{
			}
			if (keyboardLayout_ != 0)
			{
				Result resultCode2 = ((SessionSearchFindCallbackInfo*)text2)->ResultCode;
			}
			if (timeOfDayVisualOffset_ != 0)
			{
				Result resultCode3 = ((SessionSearchFindCallbackInfo*)text2)->ResultCode;
			}
			if (version_ != 0)
			{
				Result resultCode4 = ((SessionSearchFindCallbackInfo*)text2)->ResultCode;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode9 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CD9")]
		[Cpp2IlInjected.Address(RVA = "0x1811190", Offset = "0x180FB90", VA = "0x181811190", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005CDA")]
		[Cpp2IlInjected.Address(RVA = "0x18111F0", Offset = "0x180FBF0", VA = "0x1818111F0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_021f
			if (invertCamera_)
			{
				bool value = invertCamera_;
				output.WriteBool(value);
			}
			if (output != null)
			{
				float value2 = cameraMouseSensitivity_;
				output.WriteFloat(value2);
			}
			if (output != null)
			{
				float value3 = cameraGamepadSensitivity_;
				output.WriteFloat(value3);
			}
			if (gamepadVibration_)
			{
				bool value4 = gamepadVibration_;
				output.WriteBool(value4);
			}
			if (output != null)
			{
				float value5 = masterVolume_;
				output.WriteFloat(value5);
			}
			if (output != null)
			{
				float value6 = musicVolume_;
				output.WriteFloat(value6);
			}
			if (output != null)
			{
				float value7 = sfxVolume_;
				output.WriteFloat(value7);
			}
			if (output != null)
			{
				float value8 = voiceVolume_;
				output.WriteFloat(value8);
			}
			if (output != null)
			{
				float value9 = resolutionScale_;
				output.WriteFloat(value9);
			}
			if (refreshRate_ != 0)
			{
				int value10 = refreshRate_;
				output.WriteInt32(value10);
			}
			if (graphicPreset_.m_stringLength != 0)
			{
				string value11 = graphicPreset_;
				output.WriteString(value11);
			}
			if (shadowResolution_ != 0)
			{
				int value12 = shadowResolution_;
				output.WriteInt32(value12);
			}
			if (output != null)
			{
				float value13 = distanceQuality_;
				output.WriteFloat(value13);
			}
			if (textureQuality_ != 0)
			{
				int value14 = textureQuality_;
				output.WriteInt32(value14);
			}
			if (vSync_)
			{
				bool value15 = vSync_;
				output.WriteBool(value15);
			}
			if (disableCameraShakes_)
			{
				bool value16 = disableCameraShakes_;
				output.WriteBool(value16);
			}
			if (disableFlashes_)
			{
				bool value17 = disableFlashes_;
				output.WriteBool(value17);
			}
			if (languageCode_.m_stringLength != 0)
			{
				string value18 = languageCode_;
				output.WriteString(value18);
			}
			if (streamingFriendlyMusic_)
			{
				bool value19 = streamingFriendlyMusic_;
				output.WriteBool(value19);
			}
			if (keyboardLayout_ != 0)
			{
			}
			if (timeOfDayVisualOffset_ != 0)
			{
				int value20 = timeOfDayVisualOffset_;
				output.WriteInt32(value20);
			}
			if (clickToMove_)
			{
				bool value21 = clickToMove_;
				output.WriteBool(value21);
			}
			if (version_ != 0)
			{
				int value22 = version_;
				output.WriteInt32(value22);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005CDB")]
		[Cpp2IlInjected.Address(RVA = "0x180ED70", Offset = "0x180D770", VA = "0x18180ED70", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0127
			//IL_0127: Expected I4, but got O
			if (clickToMove_)
			{
			}
			if (clickToMove_)
			{
			}
			if (clickToMove_)
			{
			}
			if (clickToMove_)
			{
			}
			if (clickToMove_)
			{
			}
			int num = refreshRate_;
			if (num != 0)
			{
				int num2 = CodedOutputStream.ComputeInt32Size(num);
				num2++;
			}
			string text = graphicPreset_;
			if (text.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text);
				num3++;
			}
			int num4 = shadowResolution_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
			}
			int num6 = textureQuality_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7 += 2;
			}
			string text2 = languageCode_;
			if (text2.m_stringLength != 0)
			{
				int num8 = CodedOutputStream.ComputeStringSize(text2);
				num8 += 2;
			}
			KeyboardLayout keyboardLayout = keyboardLayout_;
			if (keyboardLayout != 0)
			{
				int num9 = CodedOutputStream.ComputeEnumSize((int)keyboardLayout);
				num9 += 2;
			}
			int num10 = timeOfDayVisualOffset_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11 += 2;
			}
			int num12 = version_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeInt32Size(num12);
				num13 += 2;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num14 = unknownFields.CalculateSize();
			}
			return (int)typeof(CodedOutputStream).TypeHandle;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CDC")]
		[Cpp2IlInjected.Address(RVA = "0x18105A0", Offset = "0x180EFA0", VA = "0x1818105A0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GameSettingsData other)
		{
			//Discarded unreachable code: IL_0208
			if (other != null)
			{
				bool flag = other.invertCamera_;
				if (flag)
				{
					invertCamera_ = flag;
				}
				float num = other.cameraMouseSensitivity_;
				if (flag)
				{
					cameraMouseSensitivity_ = num;
				}
				float num2 = other.cameraGamepadSensitivity_;
				if (flag)
				{
					cameraGamepadSensitivity_ = num2;
				}
				bool flag2 = other.gamepadVibration_;
				if (flag2)
				{
					gamepadVibration_ = flag2;
				}
				bool flag3 = other.clickToMove_;
				if (flag3)
				{
					clickToMove_ = flag3;
				}
				float num3 = other.masterVolume_;
				if (flag3)
				{
					masterVolume_ = num3;
				}
				float num4 = other.musicVolume_;
				if (flag3)
				{
					musicVolume_ = num4;
				}
				float num5 = other.sfxVolume_;
				if (flag3)
				{
					sfxVolume_ = num5;
				}
				float num6 = other.voiceVolume_;
				if (flag3)
				{
					voiceVolume_ = num6;
				}
				float num7 = other.resolutionScale_;
				if (flag3)
				{
					resolutionScale_ = num7;
				}
				int num8 = other.refreshRate_;
				if (num8 != 0)
				{
					refreshRate_ = num8;
				}
				string text = other.graphicPreset_;
				if (text.m_stringLength != 0)
				{
					GraphicPreset = text;
				}
				int num9 = other.shadowResolution_;
				if (num9 != 0)
				{
					shadowResolution_ = num9;
				}
				float num10 = other.distanceQuality_;
				if (num9 != 0)
				{
					distanceQuality_ = num10;
				}
				int num11 = other.textureQuality_;
				if (num11 != 0)
				{
					textureQuality_ = num11;
				}
				bool flag4 = other.vSync_;
				if (flag4)
				{
					vSync_ = flag4;
				}
				bool flag5 = other.disableCameraShakes_;
				if (flag5)
				{
					disableCameraShakes_ = flag5;
				}
				bool flag6 = other.disableFlashes_;
				if (flag6)
				{
					disableFlashes_ = flag6;
				}
				string text2 = other.languageCode_;
				if (text2.m_stringLength != 0)
				{
					LanguageCode = text2;
				}
				bool flag7 = other.streamingFriendlyMusic_;
				if (flag7)
				{
					streamingFriendlyMusic_ = flag7;
				}
				KeyboardLayout keyboardLayout = other.keyboardLayout_;
				if (keyboardLayout != 0)
				{
					keyboardLayout_ = keyboardLayout;
				}
				int num12 = other.timeOfDayVisualOffset_;
				if (num12 != 0)
				{
					timeOfDayVisualOffset_ = num12;
				}
				int num13 = other.version_;
				if (num13 != 0)
				{
					version_ = num13;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005CDD")]
		[Cpp2IlInjected.Address(RVA = "0x1810740", Offset = "0x180F140", VA = "0x181810740", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0282
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 114)
			{
				if ((int)num > 160)
				{
					if ((int)num > 400)
					{
						if (num == 480)
						{
							int num2 = (timeOfDayVisualOffset_ = input.ReadInt32());
						}
						bool flag = default(bool);
						if (num == 560)
						{
							flag = (clickToMove_ = input.ReadBool());
						}
						if (!flag)
						{
							goto IL_026b;
						}
						int num3 = (version_ = input.ReadInt32());
					}
					string text2 = default(string);
					if (num == 242)
					{
						text2 = (LanguageCode = input.ReadString());
					}
					bool flag2 = default(bool);
					if ((long)text2 == 320)
					{
						flag2 = (streamingFriendlyMusic_ = input.ReadBool());
					}
					if (!flag2)
					{
						goto IL_026b;
					}
					int num4 = (int)(keyboardLayout_ = (KeyboardLayout)input.ReadInt32());
				}
				bool flag5 = default(bool);
				if ((int)num > 136)
				{
					bool flag3 = default(bool);
					if (num == 144)
					{
						flag3 = (vSync_ = input.ReadBool());
					}
					bool flag4 = default(bool);
					if (flag3)
					{
						flag4 = (disableCameraShakes_ = input.ReadBool());
					}
					if (!flag4)
					{
						goto IL_026b;
					}
					flag5 = (disableFlashes_ = input.ReadBool());
				}
				int num5 = default(int);
				if (flag5)
				{
					num5 = (shadowResolution_ = input.ReadInt32());
				}
				if (num5 == 133)
				{
					float num6 = (distanceQuality_ = input.ReadFloat());
				}
				if (num5 != 136)
				{
					goto IL_026b;
				}
				int num7 = (textureQuality_ = input.ReadInt32());
			}
			string text4 = default(string);
			if ((int)num > 45)
			{
				if ((int)num > 69)
				{
					if (num == 101)
					{
						float num8 = (resolutionScale_ = input.ReadFloat());
					}
					int num9 = default(int);
					if (num == 104)
					{
						num9 = (refreshRate_ = input.ReadInt32());
					}
					if (num9 != 114)
					{
						goto IL_026b;
					}
					text4 = (GraphicPreset = input.ReadString());
				}
				if ((long)text4 == 53)
				{
					float num10 = (musicVolume_ = input.ReadFloat());
				}
				if ((long)text4 == 61)
				{
					float num11 = (sfxVolume_ = input.ReadFloat());
				}
				if ((long)text4 != 69)
				{
					goto IL_026b;
				}
				float num12 = (voiceVolume_ = input.ReadFloat());
			}
			bool flag6 = default(bool);
			if ((long)text4 > 21)
			{
				if ((long)text4 == 29)
				{
					float num13 = (cameraGamepadSensitivity_ = input.ReadFloat());
				}
				if ((long)text4 == 32)
				{
					flag6 = (gamepadVibration_ = input.ReadBool());
				}
				if (!flag6)
				{
					goto IL_026b;
				}
				float num14 = (masterVolume_ = input.ReadFloat());
			}
			bool flag7 = default(bool);
			if (flag6)
			{
				flag7 = (invertCamera_ = input.ReadBool());
			}
			if (flag7)
			{
				float num15 = (cameraMouseSensitivity_ = input.ReadFloat());
			}
			goto IL_026b;
			IL_026b:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005CDE")]
		[Cpp2IlInjected.Address(RVA = "0x180F880", Offset = "0x180E280", VA = "0x18180F880", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber > 50)
			{
				if (fieldNumber == 60)
				{
					int num = timeOfDayVisualOffset_;
				}
				if (fieldNumber == 70)
				{
				}
				if (fieldNumber != 100)
				{
					goto IL_0029;
				}
			}
			if (fieldNumber - 1 <= 29)
			{
				string text = graphicPreset_;
			}
			goto IL_0029;
			IL_0029:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CDF")]
		[Cpp2IlInjected.Address(RVA = "0x1810A40", Offset = "0x180F440", VA = "0x181810A40", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0039, IL_0042, IL_004b, IL_0054, IL_005d, IL_0066, IL_006f, IL_0078, IL_0081, IL_008a, IL_008b, IL_009b, IL_00a3, IL_00ab, IL_00b3, IL_00bb, IL_00c3, IL_00cb, IL_00e1, IL_00e9, IL_00ef, IL_00f5, IL_00fb, IL_0101, IL_0107, IL_010d, IL_0113, IL_0119, IL_011f, IL_0125, IL_012b, IL_0131, IL_0137
			//IL_0011: Expected I4, but got O
			//IL_001e: Expected I4, but got O
			//IL_0026: Expected I4, but got O
			//IL_0038: Expected I4, but got O
			//IL_0041: Expected F4, but got O
			//IL_004a: Expected F4, but got O
			//IL_0053: Expected I4, but got O
			//IL_005c: Expected F4, but got O
			//IL_0065: Expected F4, but got O
			//IL_006e: Expected F4, but got O
			//IL_0077: Expected F4, but got O
			//IL_0080: Expected F4, but got O
			//IL_0089: Expected I4, but got O
			//IL_00aa: Expected F4, but got I4
			if (fieldNumber > 50)
			{
				switch (fieldNumber)
				{
				case 60:
				{
					object obj3 = default(object);
					timeOfDayVisualOffset_ = (int)obj3;
					break;
				}
				case 70:
				{
					object obj2 = default(object);
					clickToMove_ = (byte)(int)obj2 != 0;
					break;
				}
				default:
				{
					object obj = default(object);
					version_ = (int)obj;
					break;
				}
				}
			}
			else if (fieldNumber - 1 <= 29)
			{
				object obj4 = default(object);
				invertCamera_ = (byte)(int)obj4 != 0;
			}
			else
			{
				if ((object)graphicPreset_ != (object)typeof(string).TypeHandle)
				{
					throw new InvalidCastException();
				}
				streamingFriendlyMusic_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005CE0")]
		[Cpp2IlInjected.Address(RVA = "0x180F050", Offset = "0x180DA50", VA = "0x18180F050", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0036, IL_0037, IL_0038, IL_0039, IL_003a, IL_003b, IL_003c, IL_003d, IL_003e, IL_003f, IL_0040, IL_0041, IL_0042, IL_0043, IL_0044, IL_0045, IL_0046
			//IL_0013: Expected I4, but got I8
			if (fieldNumber > 50)
			{
				switch (fieldNumber)
				{
				case 60:
					timeOfDayVisualOffset_ = 0;
					break;
				case 70:
					clickToMove_ = false;
					break;
				}
			}
			else if (fieldNumber - 1 <= 29)
			{
				invertCamera_ = false;
			}
			else
			{
				switch (fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005CE2")]
		[Cpp2IlInjected.Address(RVA = "0x1810280", Offset = "0x180EC80", VA = "0x181810280")]
		public Dictionary<string, string> GetLanguageChoices()
		{
			//Discarded unreachable code: IL_000c, IL_0028, IL_0030, IL_0049, IL_0051, IL_006a, IL_0076
			Dictionary<string, string> dictionary = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005CE3")]
		[Cpp2IlInjected.Address(RVA = "0x1811680", Offset = "0x1810080", VA = "0x181811680")]
		static GameSettingsData()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
