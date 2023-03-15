using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Util;
using Epic.OnlineServices;
using Epic.OnlineServices.Platform;
using Epic.OnlineServices.Sessions;
using Gameloft.FileSystem.Abstraction;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using StoreFrontEnums;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AA3")]
	public sealed class DebugSettings : IMessage<DebugSettings>, IMessage, IEquatable<DebugSettings>, IDeepCloneable<DebugSettings>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000AA4")]
		public class DebugSettingsDispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x2000AA5")]
			public delegate void Load();

			[Cpp2IlInjected.Token(Token = "0x2000AA6")]
			public delegate void FirstMenuConfirm();

			[Cpp2IlInjected.Token(Token = "0x1400008A")]
			public event Load OnLoad
			{
				[Cpp2IlInjected.Token(Token = "0x6005C89")]
				[Cpp2IlInjected.Address(RVA = "0x998EF0", Offset = "0x9978F0", VA = "0x180998EF0")]
				[CompilerGenerated]
				add
				{
					Load onLoad = this.OnLoad;
					Delegate @delegate = Delegate.Combine(onLoad, value);
					if ((object)@delegate == null || (object)@delegate != null)
					{
						while ((object)@delegate != onLoad)
						{
						}
						return;
					}
					throw new InvalidCastException();
				}
				[Cpp2IlInjected.Token(Token = "0x6005C8A")]
				[Cpp2IlInjected.Address(RVA = "0x999030", Offset = "0x997A30", VA = "0x180999030")]
				[CompilerGenerated]
				remove
				{
					Load onLoad = this.OnLoad;
					Delegate @delegate = Delegate.Remove(onLoad, value);
					if ((object)@delegate == null || (object)@delegate != null)
					{
						while ((object)@delegate != onLoad)
						{
						}
						return;
					}
					throw new InvalidCastException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400008B")]
			public event FirstMenuConfirm OnFirstMenuConfirm
			{
				[Cpp2IlInjected.Token(Token = "0x6005C8C")]
				[Cpp2IlInjected.Address(RVA = "0x998E50", Offset = "0x997850", VA = "0x180998E50")]
				[CompilerGenerated]
				add
				{
					FirstMenuConfirm onFirstMenuConfirm = this.OnFirstMenuConfirm;
					Delegate @delegate = Delegate.Combine(onFirstMenuConfirm, value);
					if ((object)@delegate == null || (object)@delegate != null)
					{
						while ((object)@delegate != onFirstMenuConfirm)
						{
						}
						return;
					}
					throw new InvalidCastException();
				}
				[Cpp2IlInjected.Token(Token = "0x6005C8D")]
				[Cpp2IlInjected.Address(RVA = "0x998F90", Offset = "0x997990", VA = "0x180998F90")]
				[CompilerGenerated]
				remove
				{
					FirstMenuConfirm onFirstMenuConfirm = this.OnFirstMenuConfirm;
					Delegate @delegate = Delegate.Remove(onFirstMenuConfirm, value);
					if ((object)@delegate == null || (object)@delegate != null)
					{
						while ((object)@delegate != onFirstMenuConfirm)
						{
						}
						return;
					}
					throw new InvalidCastException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6005C8B")]
			[Cpp2IlInjected.Address(RVA = "0x998E30", Offset = "0x997830", VA = "0x180998E30")]
			internal void RaiseOnLoad()
			{
				this.OnLoad?.Invoke();
			}

			[Cpp2IlInjected.Token(Token = "0x6005C8E")]
			[Cpp2IlInjected.Address(RVA = "0x998E10", Offset = "0x997810", VA = "0x180998E10")]
			public void RaiseOnConfirm()
			{
				this.OnFirstMenuConfirm?.Invoke();
			}

			[Cpp2IlInjected.Token(Token = "0x6005C8F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public DebugSettingsDispatcher()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40029A5")]
		private static readonly MessageParser<DebugSettings> _parser = (MessageParser<DebugSettings>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new DebugSettings()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40029A6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40029A7")]
		public const int ResetProfileOnceFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40029A8")]
		private bool resetProfileOnce_;

		[Cpp2IlInjected.Token(Token = "0x40029A9")]
		public const int ResetProfileFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x40029AA")]
		private bool resetProfile_;

		[Cpp2IlInjected.Token(Token = "0x40029AB")]
		public const int ShowStartMenuFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x40029AC")]
		private bool showStartMenu_;

		[Cpp2IlInjected.Token(Token = "0x40029AD")]
		public const int ProfileSlotFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40029AE")]
		private string profileSlot_;

		[Cpp2IlInjected.Token(Token = "0x40029AF")]
		public const int SkipIntroSequenceFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40029B0")]
		private bool skipIntroSequence_;

		[Cpp2IlInjected.Token(Token = "0x40029B1")]
		public const int SkipAllCutscenesFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40029B2")]
		private bool skipAllCutscenes_;

		[Cpp2IlInjected.Token(Token = "0x40029B3")]
		public const int CanAlwaysSkipCutsceneFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x40029B4")]
		private bool canAlwaysSkipCutscene_;

		[Cpp2IlInjected.Token(Token = "0x40029B5")]
		public const int DisableAllFtueFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x40029B6")]
		private bool disableAllFtue_;

		[Cpp2IlInjected.Token(Token = "0x40029B7")]
		public const int BackgroundLoadingThreadPriorityFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40029B8")]
		private MetaThreadPriority backgroundLoadingThreadPriority_;

		[Cpp2IlInjected.Token(Token = "0x40029B9")]
		public const int UnlockAllToolsFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40029BA")]
		private bool unlockAllTools_;

		[Cpp2IlInjected.Token(Token = "0x40029BB")]
		public const int ForceCharactersOutsideFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40029BC")]
		private bool forceCharactersOutside_;

		[Cpp2IlInjected.Token(Token = "0x40029BD")]
		public const int UseCheatsFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x40029BE")]
		private bool useCheats_;

		[Cpp2IlInjected.Token(Token = "0x40029BF")]
		public const int UseDefaultFreeCamFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33")]
		[Cpp2IlInjected.Token(Token = "0x40029C0")]
		private bool useDefaultFreeCam_;

		[Cpp2IlInjected.Token(Token = "0x40029C1")]
		public const int UseMarketingCamFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40029C2")]
		private bool useMarketingCam_;

		[Cpp2IlInjected.Token(Token = "0x40029C3")]
		public const int ShowLocalizationRefFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40029C4")]
		private bool showLocalizationRef_;

		[Cpp2IlInjected.Token(Token = "0x40029C5")]
		public const int ShowLocalizationStringIdsFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
		[Cpp2IlInjected.Token(Token = "0x40029C6")]
		private bool showLocalizationStringIds_;

		[Cpp2IlInjected.Token(Token = "0x40029C7")]
		public const int EnablePseudolocalizationFieldNumber = 17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37")]
		[Cpp2IlInjected.Token(Token = "0x40029C8")]
		private bool enablePseudolocalization_;

		[Cpp2IlInjected.Token(Token = "0x40029C9")]
		public const int OfflineFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40029CA")]
		private bool offline_;

		[Cpp2IlInjected.Token(Token = "0x40029CB")]
		public const int EnvironmentFieldNumber = 21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40029CC")]
		private string environment_;

		[Cpp2IlInjected.Token(Token = "0x40029CD")]
		public const int CloudFunctionModeFieldNumber = 22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40029CE")]
		private CloudFunctionMode cloudFunctionMode_;

		[Cpp2IlInjected.Token(Token = "0x40029CF")]
		public const int ShowScheduledStarPathEventsFieldNumber = 23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40029D0")]
		private bool showScheduledStarPathEvents_;

		[Cpp2IlInjected.Token(Token = "0x40029D1")]
		public const int ShowScheduledBundlesAndStoresFieldNumber = 24;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D")]
		[Cpp2IlInjected.Token(Token = "0x40029D2")]
		private bool showScheduledBundlesAndStores_;

		[Cpp2IlInjected.Token(Token = "0x40029D3")]
		public const int UserIdFieldNumber = 25;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40029D4")]
		private string userId_;

		[Cpp2IlInjected.Token(Token = "0x40029D5")]
		public const int PasswordFieldNumber = 26;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40029D6")]
		private string password_;

		[Cpp2IlInjected.Token(Token = "0x40029D7")]
		public const int PortalIpFieldNumber = 30;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40029D8")]
		private string portalIp_;

		[Cpp2IlInjected.Token(Token = "0x40029D9")]
		public const int PortalPortFieldNumber = 31;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40029DA")]
		private int portalPort_;

		[Cpp2IlInjected.Token(Token = "0x40029DB")]
		public const int CloudFunctionVersionsFieldNumber = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40029DC")]
		private int cloudFunctionVersions_;

		[Cpp2IlInjected.Token(Token = "0x40029DD")]
		public const int ResetOnlineUserIdFieldNumber = 35;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40029DE")]
		private bool resetOnlineUserId_;

		[Cpp2IlInjected.Token(Token = "0x40029DF")]
		public const int PlayfabProfileSlotFieldNumber = 36;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40029E0")]
		private string playfabProfileSlot_;

		[Cpp2IlInjected.Token(Token = "0x40029E1")]
		public const int OverrideStreamingConfigFieldNumber = 37;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40029E2")]
		private StreamingConfigOverrideType overrideStreamingConfig_;

		[Cpp2IlInjected.Token(Token = "0x40029E3")]
		public const int DefaultVillageDataPathFieldNumber = 40;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40029E4")]
		private string defaultVillageDataPath_;

		[Cpp2IlInjected.Token(Token = "0x40029E5")]
		public const int AltVillageSceneFieldNumber = 41;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40029E6")]
		private string altVillageScene_;

		[Cpp2IlInjected.Token(Token = "0x40029E7")]
		public const int UseSoftwareCursorFieldNumber = 42;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40029E8")]
		private bool useSoftwareCursor_;

		[Cpp2IlInjected.Token(Token = "0x40029E9")]
		public const int UseSteamworksFieldNumber = 43;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x40029EA")]
		private bool useSteamworks_;

		[Cpp2IlInjected.Token(Token = "0x40029EB")]
		public const int LanguageFieldNumber = 44;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40029EC")]
		private string language_;

		[Cpp2IlInjected.Token(Token = "0x40029ED")]
		public const int AutoDetectQualityFieldNumber = 45;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40029EE")]
		private bool autoDetectQuality_;

		[Cpp2IlInjected.Token(Token = "0x40029EF")]
		public const int GraphicQualityFieldNumber = 46;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40029F0")]
		private string graphicQuality_;

		[Cpp2IlInjected.Token(Token = "0x40029F1")]
		public const int OverrideShaderQualityFieldNumber = 47;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40029F2")]
		private ShaderQualityEnum overrideShaderQuality_;

		[Cpp2IlInjected.Token(Token = "0x40029F3")]
		public const int OverrideStreamingMipmapsFieldNumber = 48;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40029F4")]
		private StreamingMipmapsEnum overrideStreamingMipmaps_;

		[Cpp2IlInjected.Token(Token = "0x40029F5")]
		public const int OverrideLodSkipFieldNumber = 49;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40029F6")]
		private LodSkipEnum overrideLodSkip_;

		[Cpp2IlInjected.Token(Token = "0x40029F7")]
		public const int RuntimeAdjustableQualityFieldNumber = 50;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40029F8")]
		private bool runtimeAdjustableQuality_;

		[Cpp2IlInjected.Token(Token = "0x40029F9")]
		public const int ScreenModeFieldNumber = 51;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40029FA")]
		private ScreenModeEnum screenMode_;

		[Cpp2IlInjected.Token(Token = "0x40029FB")]
		public const int StreamingTextureFreeUnusedFieldNumber = 52;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40029FC")]
		private bool streamingTextureFreeUnused_;

		[Cpp2IlInjected.Token(Token = "0x40029FD")]
		public const int LowMemoryManagerFieldNumber = 53;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCD")]
		[Cpp2IlInjected.Token(Token = "0x40029FE")]
		private bool lowMemoryManager_;

		[Cpp2IlInjected.Token(Token = "0x40029FF")]
		public const int DebugAccountLinkingFieldNumber = 60;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCE")]
		[Cpp2IlInjected.Token(Token = "0x4002A00")]
		private bool debugAccountLinking_;

		[Cpp2IlInjected.Token(Token = "0x4002A01")]
		public const int DisableProfileUploadFieldNumber = 61;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCF")]
		[Cpp2IlInjected.Token(Token = "0x4002A02")]
		private bool disableProfileUpload_;

		[Cpp2IlInjected.Token(Token = "0x4002A03")]
		public const int ForceConflictPromptFieldNumber = 62;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002A04")]
		private bool forceConflictPrompt_;

		[Cpp2IlInjected.Token(Token = "0x4002A05")]
		public const int ResolveConflictDelayMSFieldNumber = 63;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4002A06")]
		private int resolveConflictDelayMS_;

		[Cpp2IlInjected.Token(Token = "0x4002A07")]
		public const int ForceNativeUnlinkFieldNumber = 67;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4002A08")]
		private bool forceNativeUnlink_;

		[Cpp2IlInjected.Token(Token = "0x4002A09")]
		public const int OverrideSaveOnExitPolicyFieldNumber = 68;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4002A0A")]
		private SaveOnExitPolicyType overrideSaveOnExitPolicy_;

		[Cpp2IlInjected.Token(Token = "0x4002A0B")]
		public const int DeleteLocalProfileOnlyFieldNumber = 69;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002A0C")]
		private bool deleteLocalProfileOnly_;

		[Cpp2IlInjected.Token(Token = "0x4002A0D")]
		public const int DontRestoreRemoteSaveFieldNumber = 70;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x4002A0E")]
		private bool dontRestoreRemoteSave_;

		[Cpp2IlInjected.Token(Token = "0x4002A0F")]
		public const int OverrideUploadProfileCooldownMinFieldNumber = 71;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4002A10")]
		private float overrideUploadProfileCooldownMin_;

		[Cpp2IlInjected.Token(Token = "0x4002A11")]
		public const int OverrideShowLoginPromptCooldownSecFieldNumber = 72;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002A12")]
		private float overrideShowLoginPromptCooldownSec_;

		[Cpp2IlInjected.Token(Token = "0x4002A13")]
		public const int ForceProfileEncryptionFieldNumber = 103;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4002A14")]
		private bool forceProfileEncryption_;

		[Cpp2IlInjected.Token(Token = "0x4002A15")]
		public const int DisableAutoSaveFieldNumber = 104;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x4002A16")]
		private bool disableAutoSave_;

		[Cpp2IlInjected.Token(Token = "0x4002A17")]
		public const int UseMinimalLogVerbosityFieldNumber = 105;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
		[Cpp2IlInjected.Token(Token = "0x4002A18")]
		private bool useMinimalLogVerbosity_;

		[Cpp2IlInjected.Token(Token = "0x4002A19")]
		public const int DisableSwitchCPUBoostModeFieldNumber = 106;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
		[Cpp2IlInjected.Token(Token = "0x4002A1A")]
		private bool disableSwitchCPUBoostMode_;

		[Cpp2IlInjected.Token(Token = "0x4002A1B")]
		public const int DisableLoadingScopeFieldNumber = 107;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4002A1C")]
		private bool disableLoadingScope_;

		[Cpp2IlInjected.Token(Token = "0x4002A1D")]
		public const int ForceEnableLoadingScopeForSwitchFieldNumber = 108;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF1")]
		[Cpp2IlInjected.Token(Token = "0x4002A1E")]
		private bool forceEnableLoadingScopeForSwitch_;

		[Cpp2IlInjected.Token(Token = "0x4002A1F")]
		public const int OnlineAutoLoginFieldNumber = 109;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF2")]
		[Cpp2IlInjected.Token(Token = "0x4002A20")]
		private bool onlineAutoLogin_;

		[Cpp2IlInjected.Token(Token = "0x4002A21")]
		public const int DisableGameloftTrackingFieldNumber = 110;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF3")]
		[Cpp2IlInjected.Token(Token = "0x4002A22")]
		private bool disableGameloftTracking_;

		[Cpp2IlInjected.Token(Token = "0x4002A23")]
		public const int ForceValidateSessionIntervalTimeInSecFieldNumber = 111;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4002A24")]
		private int forceValidateSessionIntervalTimeInSec_;

		[Cpp2IlInjected.Token(Token = "0x4002A25")]
		public const int UseOnlineDebugConfigSettingsFieldNumber = 112;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002A26")]
		private bool useOnlineDebugConfigSettings_;

		[Cpp2IlInjected.Token(Token = "0x4002A27")]
		public const int CommandLineArgumentsFieldNumber = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002A28")]
		private string commandLineArguments_;

		[Cpp2IlInjected.Token(Token = "0x4002A29")]
		public const int PlayerLogBackupMaxAmountFieldNumber = 301;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002A2A")]
		private int playerLogBackupMaxAmount_;

		[Cpp2IlInjected.Token(Token = "0x4002A2B")]
		public const int SystemTimeAddDaysFieldNumber = 320;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x4002A2C")]
		private int systemTimeAddDays_;

		[Cpp2IlInjected.Token(Token = "0x4002A2D")]
		public const int SystemTimeAddHoursFieldNumber = 321;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002A2E")]
		private int systemTimeAddHours_;

		[Cpp2IlInjected.Token(Token = "0x4002A2F")]
		public const int SystemTimeAddMinutesFieldNumber = 322;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4002A30")]
		private int systemTimeAddMinutes_;

		[Cpp2IlInjected.Token(Token = "0x4002A31")]
		public const int MuteAllFieldNumber = 400;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002A32")]
		private bool muteAll_;

		[Cpp2IlInjected.Token(Token = "0x4002A33")]
		public const int MuteMusicFieldNumber = 401;

		[Cpp2IlInjected.FieldOffset(Offset = "0x119")]
		[Cpp2IlInjected.Token(Token = "0x4002A34")]
		private bool muteMusic_;

		[Cpp2IlInjected.Token(Token = "0x4002A35")]
		public const int MuteSfxFieldNumber = 402;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11A")]
		[Cpp2IlInjected.Token(Token = "0x4002A36")]
		private bool muteSfx_;

		[Cpp2IlInjected.Token(Token = "0x4002A37")]
		public const int MuteVOFieldNumber = 403;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11B")]
		[Cpp2IlInjected.Token(Token = "0x4002A38")]
		private bool muteVO_;

		[Cpp2IlInjected.Token(Token = "0x4002A39")]
		public const int AllowPortraitScreenFieldNumber = 500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x4002A3A")]
		private bool allowPortraitScreen_;

		[Cpp2IlInjected.Token(Token = "0x4002A3B")]
		public const int UsePortraitScreenOnlyFieldNumber = 501;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
		[Cpp2IlInjected.Token(Token = "0x4002A3C")]
		private bool usePortraitScreenOnly_;

		[Cpp2IlInjected.Token(Token = "0x4002A3D")]
		public const int UseIngameDebugFieldNumber = 550;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11E")]
		[Cpp2IlInjected.Token(Token = "0x4002A3E")]
		private bool useIngameDebug_;

		[Cpp2IlInjected.Token(Token = "0x4002A3F")]
		public const int OverridePlatformFieldNumber = 551;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4002A40")]
		private string overridePlatform_;

		[Cpp2IlInjected.Token(Token = "0x4002A41")]
		public const int ShowFPSFieldNumber = 552;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4002A42")]
		private bool showFPS_;

		[Cpp2IlInjected.Token(Token = "0x4002A43")]
		public const int ShowMipmapStreamingInfoFieldNumber = 553;

		[Cpp2IlInjected.FieldOffset(Offset = "0x129")]
		[Cpp2IlInjected.Token(Token = "0x4002A44")]
		private bool showMipmapStreamingInfo_;

		[Cpp2IlInjected.Token(Token = "0x4002A45")]
		public const int ShowSystemInfoFieldNumber = 554;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12A")]
		[Cpp2IlInjected.Token(Token = "0x4002A46")]
		private bool showSystemInfo_;

		[Cpp2IlInjected.Token(Token = "0x4002A47")]
		public const int ShowMemoryInfoFieldNumber = 555;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12B")]
		[Cpp2IlInjected.Token(Token = "0x4002A48")]
		private bool showMemoryInfo_;

		[Cpp2IlInjected.Token(Token = "0x4002A49")]
		public const int LogDeviceInfoFieldNumber = 556;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x4002A4A")]
		private bool logDeviceInfo_;

		[Cpp2IlInjected.Token(Token = "0x4002A4B")]
		public const int EasyReadFieldNumber = 576;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
		[Cpp2IlInjected.Token(Token = "0x4002A4C")]
		private bool easyRead_;

		[Cpp2IlInjected.Token(Token = "0x4002A4D")]
		public const int ForceNoGamepadFieldNumber = 578;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
		[Cpp2IlInjected.Token(Token = "0x4002A4E")]
		private bool forceNoGamepad_;

		[Cpp2IlInjected.Token(Token = "0x4002A4F")]
		public const int OverrideGamepadControlTypeFieldNumber = 579;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4002A50")]
		private ControlType overrideGamepadControlType_;

		[Cpp2IlInjected.Token(Token = "0x4002A51")]
		public const int DisableDistanceCullingFieldNumber = 580;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4002A52")]
		private bool disableDistanceCulling_;

		[Cpp2IlInjected.Token(Token = "0x4002A53")]
		public const int ForceUnityLogTypeFieldNumber = 581;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002A54")]
		private UnityLogType forceUnityLogType_;

		[Cpp2IlInjected.Token(Token = "0x4002A55")]
		public const int DisableGridObjStreamingFieldNumber = 582;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x4002A56")]
		private bool disableGridObjStreaming_;

		[Cpp2IlInjected.Token(Token = "0x4002A57")]
		public const int AutoBuildHouseFieldNumber = 583;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x4002A58")]
		private bool autoBuildHouse_;

		[Cpp2IlInjected.Token(Token = "0x4002A59")]
		public const int InfiniteStaminaFieldNumber = 584;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x4002A5A")]
		private bool infiniteStamina_;

		[Cpp2IlInjected.Token(Token = "0x4002A5B")]
		public const int ForceBacktraceOnFieldNumber = 585;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x4002A5C")]
		private bool forceBacktraceOn_;

		[Cpp2IlInjected.Token(Token = "0x4002A5D")]
		public const int RdpHackFieldNumber = 603;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4002A5E")]
		private bool rdpHack_;

		[Cpp2IlInjected.Token(Token = "0x4002A5F")]
		public const int OverridePcControlsFieldNumber = 600;

		[Cpp2IlInjected.FieldOffset(Offset = "0x141")]
		[Cpp2IlInjected.Token(Token = "0x4002A60")]
		private bool overridePcControls_;

		[Cpp2IlInjected.Token(Token = "0x4002A61")]
		public const int OverrideControlSchemeFieldNumber = 601;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x4002A62")]
		private ControlSchemeType overrideControlScheme_;

		[Cpp2IlInjected.Token(Token = "0x4002A63")]
		public const int OVerrideHookedControlSchemeFieldNumber = 602;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4002A64")]
		private ControlSchemeType oVerrideHookedControlScheme_;

		[Cpp2IlInjected.Token(Token = "0x4002A65")]
		public const int ActivateS1HackFieldNumber = 604;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x4002A66")]
		private bool activateS1Hack_;

		[Cpp2IlInjected.Token(Token = "0x4002A67")]
		public const int OverrideMarketPlaceNameFieldNumber = 700;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4002A68")]
		private string overrideMarketPlaceName_;

		[Cpp2IlInjected.Token(Token = "0x4002A69")]
		public const int PSNOverrideServiceLabelFieldNumber = 701;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4002A6A")]
		private string pSNOverrideServiceLabel_;

		[Cpp2IlInjected.Token(Token = "0x4002A6B")]
		public const int PSNOverrideEnvFieldNumber = 702;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4002A6C")]
		private string pSNOverrideEnv_;

		[Cpp2IlInjected.Token(Token = "0x4002A6D")]
		public const int DoFakeRedeemFromClientFieldNumber = 704;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4002A6E")]
		private bool doFakeRedeemFromClient_;

		[Cpp2IlInjected.Token(Token = "0x4002A6F")]
		public const int OverridePlayfabOriginFieldNumber = 703;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x4002A70")]
		private PlayfabOriginId overridePlayfabOrigin_;

		[Cpp2IlInjected.Token(Token = "0x4002A71")]
		public const int ForceSaveToPlayFabFailureFieldNumber = 750;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4002A72")]
		private bool forceSaveToPlayFabFailure_;

		[Cpp2IlInjected.Token(Token = "0x4002A73")]
		public const int NxSimulateNoInternetFieldNumber = 751;

		[Cpp2IlInjected.FieldOffset(Offset = "0x171")]
		[Cpp2IlInjected.Token(Token = "0x4002A74")]
		private bool nxSimulateNoInternet_;

		[Cpp2IlInjected.Token(Token = "0x4002A75")]
		public const int NxSimulateNoNSAFieldNumber = 752;

		[Cpp2IlInjected.FieldOffset(Offset = "0x172")]
		[Cpp2IlInjected.Token(Token = "0x4002A76")]
		private bool nxSimulateNoNSA_;

		[Cpp2IlInjected.Token(Token = "0x4002A77")]
		public const int OnlineSimulateNoInternetFieldNumber = 760;

		[Cpp2IlInjected.FieldOffset(Offset = "0x173")]
		[Cpp2IlInjected.Token(Token = "0x4002A78")]
		private bool onlineSimulateNoInternet_;

		[Cpp2IlInjected.Token(Token = "0x4002A79")]
		public const int OnlineSimulatePlayFabNotLoggedInFieldNumber = 761;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x4002A7A")]
		private bool onlineSimulatePlayFabNotLoggedIn_;

		[Cpp2IlInjected.Token(Token = "0x4002A7B")]
		public const int OnlineSimulatePortalNotLoggedInFieldNumber = 762;

		[Cpp2IlInjected.FieldOffset(Offset = "0x175")]
		[Cpp2IlInjected.Token(Token = "0x4002A7C")]
		private bool onlineSimulatePortalNotLoggedIn_;

		[Cpp2IlInjected.Token(Token = "0x4002A7D")]
		public const string GraphicQualityNoOverride = "NoOverride";

		[Cpp2IlInjected.Token(Token = "0x4002A7E")]
		private static readonly string DebugSettingsFile;

		[Cpp2IlInjected.Token(Token = "0x4002A7F")]
		private static readonly string DefaultDebugSettingsPath;

		[Cpp2IlInjected.Token(Token = "0x4002A80")]
		private static readonly string DebugSettingsForceOnPath;

		[Cpp2IlInjected.Token(Token = "0x4002A81")]
		private static DebugSettingsDispatcher _dispatcher;

		[Cpp2IlInjected.Token(Token = "0x4002A83")]
		private static DebugSettings _settings;

		[Cpp2IlInjected.Token(Token = "0x17000FA9")]
		[DebuggerNonUserCode]
		public static MessageParser<DebugSettings> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005B91")]
			[Cpp2IlInjected.Address(RVA = "0x18D7BD0", Offset = "0x18D65D0", VA = "0x1818D7BD0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FAA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005B92")]
			[Cpp2IlInjected.Address(RVA = "0x18D7770", Offset = "0x18D6170", VA = "0x1818D7770")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FAB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005B93")]
			[Cpp2IlInjected.Address(RVA = "0x18D7E10", Offset = "0x18D6810", VA = "0x1818D7E10", Slot = "8")]
			get
			{
				int num = 0;
				return Descriptor;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FAC")]
		[DebuggerNonUserCode]
		public bool ResetProfileOnce
		{
			[Cpp2IlInjected.Token(Token = "0x6005B98")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return resetProfileOnce_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005B99")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				resetProfileOnce_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FAD")]
		[DebuggerNonUserCode]
		public bool ResetProfile
		{
			[Cpp2IlInjected.Token(Token = "0x6005B9A")]
			[Cpp2IlInjected.Address(RVA = "0x63C0C0", Offset = "0x63AAC0", VA = "0x18063C0C0")]
			get
			{
				return resetProfile_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005B9B")]
			[Cpp2IlInjected.Address(RVA = "0x63C290", Offset = "0x63AC90", VA = "0x18063C290")]
			set
			{
				resetProfile_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FAE")]
		[DebuggerNonUserCode]
		public bool ShowStartMenu
		{
			[Cpp2IlInjected.Token(Token = "0x6005B9C")]
			[Cpp2IlInjected.Address(RVA = "0x63C0B0", Offset = "0x63AAB0", VA = "0x18063C0B0")]
			get
			{
				return showStartMenu_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005B9D")]
			[Cpp2IlInjected.Address(RVA = "0x63C280", Offset = "0x63AC80", VA = "0x18063C280")]
			set
			{
				showStartMenu_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FAF")]
		[DebuggerNonUserCode]
		public string ProfileSlot
		{
			[Cpp2IlInjected.Token(Token = "0x6005B9E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return profileSlot_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005B9F")]
			[Cpp2IlInjected.Address(RVA = "0x18D8670", Offset = "0x18D7070", VA = "0x1818D8670")]
			set
			{
				string text = (profileSlot_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FB0")]
		[DebuggerNonUserCode]
		public bool SkipIntroSequence
		{
			[Cpp2IlInjected.Token(Token = "0x6005BA0")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return skipIntroSequence_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BA1")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				skipIntroSequence_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FB1")]
		[DebuggerNonUserCode]
		public bool SkipAllCutscenes
		{
			[Cpp2IlInjected.Token(Token = "0x6005BA2")]
			[Cpp2IlInjected.Address(RVA = "0xA44560", Offset = "0xA42F60", VA = "0x180A44560")]
			get
			{
				return skipAllCutscenes_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BA3")]
			[Cpp2IlInjected.Address(RVA = "0xDC79B0", Offset = "0xDC63B0", VA = "0x180DC79B0")]
			set
			{
				skipAllCutscenes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FB2")]
		[DebuggerNonUserCode]
		public bool CanAlwaysSkipCutscene
		{
			[Cpp2IlInjected.Token(Token = "0x6005BA4")]
			[Cpp2IlInjected.Address(RVA = "0xDC7980", Offset = "0xDC6380", VA = "0x180DC7980")]
			get
			{
				return canAlwaysSkipCutscene_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BA5")]
			[Cpp2IlInjected.Address(RVA = "0xDC79A0", Offset = "0xDC63A0", VA = "0x180DC79A0")]
			set
			{
				canAlwaysSkipCutscene_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FB3")]
		[DebuggerNonUserCode]
		public bool DisableAllFtue
		{
			[Cpp2IlInjected.Token(Token = "0x6005BA6")]
			[Cpp2IlInjected.Address(RVA = "0xDC7990", Offset = "0xDC6390", VA = "0x180DC7990")]
			get
			{
				return disableAllFtue_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BA7")]
			[Cpp2IlInjected.Address(RVA = "0xDC79C0", Offset = "0xDC63C0", VA = "0x180DC79C0")]
			set
			{
				disableAllFtue_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FB4")]
		[DebuggerNonUserCode]
		public MetaThreadPriority BackgroundLoadingThreadPriority
		{
			[Cpp2IlInjected.Token(Token = "0x6005BA8")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return backgroundLoadingThreadPriority_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BA9")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				backgroundLoadingThreadPriority_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FB5")]
		[DebuggerNonUserCode]
		public bool UnlockAllTools
		{
			[Cpp2IlInjected.Token(Token = "0x6005BAA")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			get
			{
				return unlockAllTools_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BAB")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
			set
			{
				unlockAllTools_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FB6")]
		[DebuggerNonUserCode]
		public bool ForceCharactersOutside
		{
			[Cpp2IlInjected.Token(Token = "0x6005BAC")]
			[Cpp2IlInjected.Address(RVA = "0x997D90", Offset = "0x996790", VA = "0x180997D90")]
			get
			{
				return forceCharactersOutside_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BAD")]
			[Cpp2IlInjected.Address(RVA = "0x997DC0", Offset = "0x9967C0", VA = "0x180997DC0")]
			set
			{
				forceCharactersOutside_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FB7")]
		[DebuggerNonUserCode]
		public bool UseCheats
		{
			[Cpp2IlInjected.Token(Token = "0x6005BAE")]
			[Cpp2IlInjected.Address(RVA = "0x997D80", Offset = "0x996780", VA = "0x180997D80")]
			get
			{
				return useCheats_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BAF")]
			[Cpp2IlInjected.Address(RVA = "0x997DB0", Offset = "0x9967B0", VA = "0x180997DB0")]
			set
			{
				useCheats_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FB8")]
		[DebuggerNonUserCode]
		public bool UseDefaultFreeCam
		{
			[Cpp2IlInjected.Token(Token = "0x6005BB0")]
			[Cpp2IlInjected.Address(RVA = "0x18D7D70", Offset = "0x18D6770", VA = "0x1818D7D70")]
			get
			{
				return useDefaultFreeCam_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BB1")]
			[Cpp2IlInjected.Address(RVA = "0x18D8750", Offset = "0x18D7150", VA = "0x1818D8750")]
			set
			{
				useDefaultFreeCam_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FB9")]
		[DebuggerNonUserCode]
		public bool UseMarketingCam
		{
			[Cpp2IlInjected.Token(Token = "0x6005BB2")]
			[Cpp2IlInjected.Address(RVA = "0xCCE8B0", Offset = "0xCCD2B0", VA = "0x180CCE8B0")]
			get
			{
				return useMarketingCam_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BB3")]
			[Cpp2IlInjected.Address(RVA = "0xCCE8C0", Offset = "0xCCD2C0", VA = "0x180CCE8C0")]
			set
			{
				useMarketingCam_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FBA")]
		[DebuggerNonUserCode]
		public bool ShowLocalizationRef
		{
			[Cpp2IlInjected.Token(Token = "0x6005BB4")]
			[Cpp2IlInjected.Address(RVA = "0x18D7D00", Offset = "0x18D6700", VA = "0x1818D7D00")]
			get
			{
				return showLocalizationRef_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BB5")]
			[Cpp2IlInjected.Address(RVA = "0x18D86F0", Offset = "0x18D70F0", VA = "0x1818D86F0")]
			set
			{
				showLocalizationRef_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FBB")]
		[DebuggerNonUserCode]
		public bool ShowLocalizationStringIds
		{
			[Cpp2IlInjected.Token(Token = "0x6005BB6")]
			[Cpp2IlInjected.Address(RVA = "0x18D7D10", Offset = "0x18D6710", VA = "0x1818D7D10")]
			get
			{
				return showLocalizationStringIds_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BB7")]
			[Cpp2IlInjected.Address(RVA = "0x18D8700", Offset = "0x18D7100", VA = "0x1818D8700")]
			set
			{
				showLocalizationStringIds_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FBC")]
		[DebuggerNonUserCode]
		public bool EnablePseudolocalization
		{
			[Cpp2IlInjected.Token(Token = "0x6005BB8")]
			[Cpp2IlInjected.Address(RVA = "0x18D7A10", Offset = "0x18D6410", VA = "0x1818D7A10")]
			get
			{
				return enablePseudolocalization_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BB9")]
			[Cpp2IlInjected.Address(RVA = "0x18D8050", Offset = "0x18D6A50", VA = "0x1818D8050")]
			set
			{
				enablePseudolocalization_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FBD")]
		[DebuggerNonUserCode]
		public bool Offline
		{
			[Cpp2IlInjected.Token(Token = "0x6005BBA")]
			[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0")]
			get
			{
				return offline_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BBB")]
			[Cpp2IlInjected.Address(RVA = "0xA62700", Offset = "0xA61100", VA = "0x180A62700")]
			set
			{
				offline_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FBE")]
		[DebuggerNonUserCode]
		public string Environment
		{
			[Cpp2IlInjected.Token(Token = "0x6005BBC")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return environment_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BBD")]
			[Cpp2IlInjected.Address(RVA = "0x18D8060", Offset = "0x18D6A60", VA = "0x1818D8060")]
			set
			{
				string text = (environment_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FBF")]
		[DebuggerNonUserCode]
		public CloudFunctionMode CloudFunctionMode
		{
			[Cpp2IlInjected.Token(Token = "0x6005BBE")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return cloudFunctionMode_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BBF")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				cloudFunctionMode_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FC0")]
		[DebuggerNonUserCode]
		public bool ShowScheduledStarPathEvents
		{
			[Cpp2IlInjected.Token(Token = "0x6005BC0")]
			[Cpp2IlInjected.Address(RVA = "0x70CA70", Offset = "0x70B470", VA = "0x18070CA70")]
			get
			{
				return showScheduledStarPathEvents_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BC1")]
			[Cpp2IlInjected.Address(RVA = "0x70CE60", Offset = "0x70B860", VA = "0x18070CE60")]
			set
			{
				showScheduledStarPathEvents_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FC1")]
		[DebuggerNonUserCode]
		public bool ShowScheduledBundlesAndStores
		{
			[Cpp2IlInjected.Token(Token = "0x6005BC2")]
			[Cpp2IlInjected.Address(RVA = "0xD2FCE0", Offset = "0xD2E6E0", VA = "0x180D2FCE0")]
			get
			{
				return showScheduledBundlesAndStores_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BC3")]
			[Cpp2IlInjected.Address(RVA = "0x145D940", Offset = "0x145C340", VA = "0x18145D940")]
			set
			{
				showScheduledBundlesAndStores_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FC2")]
		[DebuggerNonUserCode]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6005BC4")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return userId_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BC5")]
			[Cpp2IlInjected.Address(RVA = "0x18D8790", Offset = "0x18D7190", VA = "0x1818D8790")]
			set
			{
				string text = (userId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FC3")]
		[DebuggerNonUserCode]
		public string Password
		{
			[Cpp2IlInjected.Token(Token = "0x6005BC6")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return password_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BC7")]
			[Cpp2IlInjected.Address(RVA = "0x18D8520", Offset = "0x18D6F20", VA = "0x1818D8520")]
			set
			{
				string text = (password_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FC4")]
		[DebuggerNonUserCode]
		public string PortalIp
		{
			[Cpp2IlInjected.Token(Token = "0x6005BC8")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return portalIp_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BC9")]
			[Cpp2IlInjected.Address(RVA = "0x18D8600", Offset = "0x18D7000", VA = "0x1818D8600")]
			set
			{
				string text = (portalIp_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FC5")]
		[DebuggerNonUserCode]
		public int PortalPort
		{
			[Cpp2IlInjected.Token(Token = "0x6005BCA")]
			[Cpp2IlInjected.Address(RVA = "0x724F70", Offset = "0x723970", VA = "0x180724F70")]
			get
			{
				return portalPort_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BCB")]
			[Cpp2IlInjected.Address(RVA = "0x7252F0", Offset = "0x723CF0", VA = "0x1807252F0")]
			set
			{
				portalPort_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FC6")]
		[DebuggerNonUserCode]
		public int CloudFunctionVersions
		{
			[Cpp2IlInjected.Token(Token = "0x6005BCC")]
			[Cpp2IlInjected.Address(RVA = "0x9604E0", Offset = "0x95EEE0", VA = "0x1809604E0")]
			get
			{
				return cloudFunctionVersions_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BCD")]
			[Cpp2IlInjected.Address(RVA = "0x960750", Offset = "0x95F150", VA = "0x180960750")]
			set
			{
				cloudFunctionVersions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FC7")]
		[DebuggerNonUserCode]
		public bool ResetOnlineUserId
		{
			[Cpp2IlInjected.Token(Token = "0x6005BCE")]
			[Cpp2IlInjected.Address(RVA = "0x975C90", Offset = "0x974690", VA = "0x180975C90")]
			get
			{
				return resetOnlineUserId_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BCF")]
			[Cpp2IlInjected.Address(RVA = "0x976530", Offset = "0x974F30", VA = "0x180976530")]
			set
			{
				resetOnlineUserId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FC8")]
		[DebuggerNonUserCode]
		public string PlayfabProfileSlot
		{
			[Cpp2IlInjected.Token(Token = "0x6005BD0")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return playfabProfileSlot_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BD1")]
			[Cpp2IlInjected.Address(RVA = "0x18D8590", Offset = "0x18D6F90", VA = "0x1818D8590")]
			set
			{
				string text = (playfabProfileSlot_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FC9")]
		[DebuggerNonUserCode]
		public StreamingConfigOverrideType OverrideStreamingConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6005BD2")]
			[Cpp2IlInjected.Address(RVA = "0x1024670", Offset = "0x1023070", VA = "0x181024670")]
			get
			{
				return overrideStreamingConfig_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BD3")]
			[Cpp2IlInjected.Address(RVA = "0x10247F0", Offset = "0x10231F0", VA = "0x1810247F0")]
			set
			{
				overrideStreamingConfig_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FCA")]
		[DebuggerNonUserCode]
		public string DefaultVillageDataPath
		{
			[Cpp2IlInjected.Token(Token = "0x6005BD4")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			get
			{
				return defaultVillageDataPath_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BD5")]
			[Cpp2IlInjected.Address(RVA = "0x18D7F70", Offset = "0x18D6970", VA = "0x1818D7F70")]
			set
			{
				string text = (defaultVillageDataPath_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FCB")]
		[DebuggerNonUserCode]
		public string AltVillageScene
		{
			[Cpp2IlInjected.Token(Token = "0x6005BD6")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			get
			{
				return altVillageScene_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BD7")]
			[Cpp2IlInjected.Address(RVA = "0x18D7E70", Offset = "0x18D6870", VA = "0x1818D7E70")]
			set
			{
				string text = (altVillageScene_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FCC")]
		[DebuggerNonUserCode]
		public bool UseSoftwareCursor
		{
			[Cpp2IlInjected.Token(Token = "0x6005BD8")]
			[Cpp2IlInjected.Address(RVA = "0xA8E0F0", Offset = "0xA8CAF0", VA = "0x180A8E0F0")]
			get
			{
				return useSoftwareCursor_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BD9")]
			[Cpp2IlInjected.Address(RVA = "0xAEDA40", Offset = "0xAEC440", VA = "0x180AEDA40")]
			set
			{
				useSoftwareCursor_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FCD")]
		[DebuggerNonUserCode]
		public bool UseSteamworks
		{
			[Cpp2IlInjected.Token(Token = "0x6005BDA")]
			[Cpp2IlInjected.Address(RVA = "0x1525170", Offset = "0x1523B70", VA = "0x181525170")]
			get
			{
				return useSteamworks_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BDB")]
			[Cpp2IlInjected.Address(RVA = "0x15251B0", Offset = "0x1523BB0", VA = "0x1815251B0")]
			set
			{
				useSteamworks_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FCE")]
		[DebuggerNonUserCode]
		public string Language
		{
			[Cpp2IlInjected.Token(Token = "0x6005BDC")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
			get
			{
				return language_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BDD")]
			[Cpp2IlInjected.Address(RVA = "0x18D81B0", Offset = "0x18D6BB0", VA = "0x1818D81B0")]
			set
			{
				string text = (language_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FCF")]
		[DebuggerNonUserCode]
		public bool AutoDetectQuality
		{
			[Cpp2IlInjected.Token(Token = "0x6005BDE")]
			[Cpp2IlInjected.Address(RVA = "0x7DAEB0", Offset = "0x7D98B0", VA = "0x1807DAEB0")]
			get
			{
				return autoDetectQuality_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BDF")]
			[Cpp2IlInjected.Address(RVA = "0x7DB480", Offset = "0x7D9E80", VA = "0x1807DB480")]
			set
			{
				autoDetectQuality_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FD0")]
		[DebuggerNonUserCode]
		public string GraphicQuality
		{
			[Cpp2IlInjected.Token(Token = "0x6005BE0")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF50", Offset = "0x7D9950", VA = "0x1807DAF50")]
			get
			{
				return graphicQuality_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BE1")]
			[Cpp2IlInjected.Address(RVA = "0x18D8140", Offset = "0x18D6B40", VA = "0x1818D8140")]
			set
			{
				string text = (graphicQuality_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FD1")]
		[DebuggerNonUserCode]
		public ShaderQualityEnum OverrideShaderQuality
		{
			[Cpp2IlInjected.Token(Token = "0x6005BE2")]
			[Cpp2IlInjected.Address(RVA = "0xD2FCF0", Offset = "0xD2E6F0", VA = "0x180D2FCF0")]
			get
			{
				return overrideShaderQuality_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BE3")]
			[Cpp2IlInjected.Address(RVA = "0xD2FD30", Offset = "0xD2E730", VA = "0x180D2FD30")]
			set
			{
				overrideShaderQuality_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FD2")]
		[DebuggerNonUserCode]
		public StreamingMipmapsEnum OverrideStreamingMipmaps
		{
			[Cpp2IlInjected.Token(Token = "0x6005BE4")]
			[Cpp2IlInjected.Address(RVA = "0x18D7BB0", Offset = "0x18D65B0", VA = "0x1818D7BB0")]
			get
			{
				return overrideStreamingMipmaps_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BE5")]
			[Cpp2IlInjected.Address(RVA = "0x18D8420", Offset = "0x18D6E20", VA = "0x1818D8420")]
			set
			{
				overrideStreamingMipmaps_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FD3")]
		[DebuggerNonUserCode]
		public LodSkipEnum OverrideLodSkip
		{
			[Cpp2IlInjected.Token(Token = "0x6005BE6")]
			[Cpp2IlInjected.Address(RVA = "0x148A150", Offset = "0x1488B50", VA = "0x18148A150")]
			get
			{
				return overrideLodSkip_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BE7")]
			[Cpp2IlInjected.Address(RVA = "0x148A410", Offset = "0x1488E10", VA = "0x18148A410")]
			set
			{
				overrideLodSkip_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FD4")]
		[DebuggerNonUserCode]
		public bool RuntimeAdjustableQuality
		{
			[Cpp2IlInjected.Token(Token = "0x6005BE8")]
			[Cpp2IlInjected.Address(RVA = "0x12E8560", Offset = "0x12E6F60", VA = "0x1812E8560")]
			get
			{
				return runtimeAdjustableQuality_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BE9")]
			[Cpp2IlInjected.Address(RVA = "0x12E87A0", Offset = "0x12E71A0", VA = "0x1812E87A0")]
			set
			{
				runtimeAdjustableQuality_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FD5")]
		[DebuggerNonUserCode]
		public ScreenModeEnum ScreenMode
		{
			[Cpp2IlInjected.Token(Token = "0x6005BEA")]
			[Cpp2IlInjected.Address(RVA = "0x148A270", Offset = "0x1488C70", VA = "0x18148A270")]
			get
			{
				return screenMode_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BEB")]
			[Cpp2IlInjected.Address(RVA = "0x148A490", Offset = "0x1488E90", VA = "0x18148A490")]
			set
			{
				screenMode_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FD6")]
		[DebuggerNonUserCode]
		public bool StreamingTextureFreeUnused
		{
			[Cpp2IlInjected.Token(Token = "0x6005BEC")]
			[Cpp2IlInjected.Address(RVA = "0x18D7D40", Offset = "0x18D6740", VA = "0x1818D7D40")]
			get
			{
				return streamingTextureFreeUnused_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BED")]
			[Cpp2IlInjected.Address(RVA = "0x18D8730", Offset = "0x18D7130", VA = "0x1818D8730")]
			set
			{
				streamingTextureFreeUnused_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FD7")]
		[DebuggerNonUserCode]
		public bool LowMemoryManager
		{
			[Cpp2IlInjected.Token(Token = "0x6005BEE")]
			[Cpp2IlInjected.Address(RVA = "0x18D7AA0", Offset = "0x18D64A0", VA = "0x1818D7AA0")]
			get
			{
				return lowMemoryManager_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BEF")]
			[Cpp2IlInjected.Address(RVA = "0x18D8230", Offset = "0x18D6C30", VA = "0x1818D8230")]
			set
			{
				lowMemoryManager_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FD8")]
		[DebuggerNonUserCode]
		public bool DebugAccountLinking
		{
			[Cpp2IlInjected.Token(Token = "0x6005BF0")]
			[Cpp2IlInjected.Address(RVA = "0x18D7750", Offset = "0x18D6150", VA = "0x1818D7750")]
			get
			{
				return debugAccountLinking_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BF1")]
			[Cpp2IlInjected.Address(RVA = "0x18D7F60", Offset = "0x18D6960", VA = "0x1818D7F60")]
			set
			{
				debugAccountLinking_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FD9")]
		[DebuggerNonUserCode]
		public bool DisableProfileUpload
		{
			[Cpp2IlInjected.Token(Token = "0x6005BF2")]
			[Cpp2IlInjected.Address(RVA = "0x18D7860", Offset = "0x18D6260", VA = "0x1818D7860")]
			get
			{
				return disableProfileUpload_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BF3")]
			[Cpp2IlInjected.Address(RVA = "0x18D8010", Offset = "0x18D6A10", VA = "0x1818D8010")]
			set
			{
				disableProfileUpload_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FDA")]
		[DebuggerNonUserCode]
		public bool ForceConflictPrompt
		{
			[Cpp2IlInjected.Token(Token = "0x6005BF4")]
			[Cpp2IlInjected.Address(RVA = "0xAFC360", Offset = "0xAFAD60", VA = "0x180AFC360")]
			get
			{
				return forceConflictPrompt_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BF5")]
			[Cpp2IlInjected.Address(RVA = "0xAFC480", Offset = "0xAFAE80", VA = "0x180AFC480")]
			set
			{
				forceConflictPrompt_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FDB")]
		[DebuggerNonUserCode]
		public int ResolveConflictDelayMS
		{
			[Cpp2IlInjected.Token(Token = "0x6005BF6")]
			[Cpp2IlInjected.Address(RVA = "0x18D7C30", Offset = "0x18D6630", VA = "0x1818D7C30")]
			get
			{
				return resolveConflictDelayMS_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BF7")]
			[Cpp2IlInjected.Address(RVA = "0x18D86E0", Offset = "0x18D70E0", VA = "0x1818D86E0")]
			set
			{
				resolveConflictDelayMS_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FDC")]
		[DebuggerNonUserCode]
		public bool ForceNativeUnlink
		{
			[Cpp2IlInjected.Token(Token = "0x6005BF8")]
			[Cpp2IlInjected.Address(RVA = "0x12AAE10", Offset = "0x12A9810", VA = "0x1812AAE10")]
			get
			{
				return forceNativeUnlink_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BF9")]
			[Cpp2IlInjected.Address(RVA = "0x12AAE20", Offset = "0x12A9820", VA = "0x1812AAE20")]
			set
			{
				forceNativeUnlink_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FDD")]
		[DebuggerNonUserCode]
		public SaveOnExitPolicyType OverrideSaveOnExitPolicy
		{
			[Cpp2IlInjected.Token(Token = "0x6005BFA")]
			[Cpp2IlInjected.Address(RVA = "0x18D7B90", Offset = "0x18D6590", VA = "0x1818D7B90")]
			get
			{
				return overrideSaveOnExitPolicy_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BFB")]
			[Cpp2IlInjected.Address(RVA = "0x18D8400", Offset = "0x18D6E00", VA = "0x1818D8400")]
			set
			{
				overrideSaveOnExitPolicy_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FDE")]
		[DebuggerNonUserCode]
		public bool DeleteLocalProfileOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6005BFC")]
			[Cpp2IlInjected.Address(RVA = "0x18D7760", Offset = "0x18D6160", VA = "0x1818D7760")]
			get
			{
				return deleteLocalProfileOnly_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BFD")]
			[Cpp2IlInjected.Address(RVA = "0x18D7FE0", Offset = "0x18D69E0", VA = "0x1818D7FE0")]
			set
			{
				deleteLocalProfileOnly_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FDF")]
		[DebuggerNonUserCode]
		public bool DontRestoreRemoteSave
		{
			[Cpp2IlInjected.Token(Token = "0x6005BFE")]
			[Cpp2IlInjected.Address(RVA = "0x18D79F0", Offset = "0x18D63F0", VA = "0x1818D79F0")]
			get
			{
				return dontRestoreRemoteSave_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BFF")]
			[Cpp2IlInjected.Address(RVA = "0x18D8030", Offset = "0x18D6A30", VA = "0x1818D8030")]
			set
			{
				dontRestoreRemoteSave_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FE0")]
		[DebuggerNonUserCode]
		public float OverrideUploadProfileCooldownMin
		{
			[Cpp2IlInjected.Token(Token = "0x6005C00")]
			[Cpp2IlInjected.Address(RVA = "0x18D7BC0", Offset = "0x18D65C0", VA = "0x1818D7BC0")]
			get
			{
				return overrideUploadProfileCooldownMin_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C01")]
			[Cpp2IlInjected.Address(RVA = "0x18D8430", Offset = "0x18D6E30", VA = "0x1818D8430")]
			set
			{
				overrideUploadProfileCooldownMin_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FE1")]
		[DebuggerNonUserCode]
		public float OverrideShowLoginPromptCooldownSec
		{
			[Cpp2IlInjected.Token(Token = "0x6005C02")]
			[Cpp2IlInjected.Address(RVA = "0x18D7BA0", Offset = "0x18D65A0", VA = "0x1818D7BA0")]
			get
			{
				return overrideShowLoginPromptCooldownSec_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C03")]
			[Cpp2IlInjected.Address(RVA = "0x18D8410", Offset = "0x18D6E10", VA = "0x1818D8410")]
			set
			{
				overrideShowLoginPromptCooldownSec_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FE2")]
		[DebuggerNonUserCode]
		public bool ForceProfileEncryption
		{
			[Cpp2IlInjected.Token(Token = "0x6005C04")]
			[Cpp2IlInjected.Address(RVA = "0x18D7A50", Offset = "0x18D6450", VA = "0x1818D7A50")]
			get
			{
				return forceProfileEncryption_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C05")]
			[Cpp2IlInjected.Address(RVA = "0x18D8100", Offset = "0x18D6B00", VA = "0x1818D8100")]
			set
			{
				forceProfileEncryption_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FE3")]
		[DebuggerNonUserCode]
		public bool DisableAutoSave
		{
			[Cpp2IlInjected.Token(Token = "0x6005C06")]
			[Cpp2IlInjected.Address(RVA = "0x18D7840", Offset = "0x18D6240", VA = "0x1818D7840")]
			get
			{
				return disableAutoSave_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C07")]
			[Cpp2IlInjected.Address(RVA = "0x18D7FF0", Offset = "0x18D69F0", VA = "0x1818D7FF0")]
			set
			{
				disableAutoSave_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FE4")]
		[DebuggerNonUserCode]
		public bool UseMinimalLogVerbosity
		{
			[Cpp2IlInjected.Token(Token = "0x6005C08")]
			[Cpp2IlInjected.Address(RVA = "0x18D7D90", Offset = "0x18D6790", VA = "0x1818D7D90")]
			get
			{
				return useMinimalLogVerbosity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C09")]
			[Cpp2IlInjected.Address(RVA = "0x18D8770", Offset = "0x18D7170", VA = "0x1818D8770")]
			set
			{
				useMinimalLogVerbosity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FE5")]
		[DebuggerNonUserCode]
		public bool DisableSwitchCPUBoostMode
		{
			[Cpp2IlInjected.Token(Token = "0x6005C0A")]
			[Cpp2IlInjected.Address(RVA = "0x18D7870", Offset = "0x18D6270", VA = "0x1818D7870")]
			get
			{
				return disableSwitchCPUBoostMode_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C0B")]
			[Cpp2IlInjected.Address(RVA = "0x18D8020", Offset = "0x18D6A20", VA = "0x1818D8020")]
			set
			{
				disableSwitchCPUBoostMode_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FE6")]
		[DebuggerNonUserCode]
		public bool DisableLoadingScope
		{
			[Cpp2IlInjected.Token(Token = "0x6005C0C")]
			[Cpp2IlInjected.Address(RVA = "0x110E5C0", Offset = "0x110CFC0", VA = "0x18110E5C0")]
			get
			{
				return disableLoadingScope_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C0D")]
			[Cpp2IlInjected.Address(RVA = "0x14B2070", Offset = "0x14B0A70", VA = "0x1814B2070")]
			set
			{
				disableLoadingScope_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FE7")]
		[DebuggerNonUserCode]
		public bool ForceEnableLoadingScopeForSwitch
		{
			[Cpp2IlInjected.Token(Token = "0x6005C0E")]
			[Cpp2IlInjected.Address(RVA = "0x18D7A30", Offset = "0x18D6430", VA = "0x1818D7A30")]
			get
			{
				return forceEnableLoadingScopeForSwitch_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C0F")]
			[Cpp2IlInjected.Address(RVA = "0x18D80E0", Offset = "0x18D6AE0", VA = "0x1818D80E0")]
			set
			{
				forceEnableLoadingScopeForSwitch_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FE8")]
		[DebuggerNonUserCode]
		public bool OnlineAutoLogin
		{
			[Cpp2IlInjected.Token(Token = "0x6005C10")]
			[Cpp2IlInjected.Address(RVA = "0x18D7B20", Offset = "0x18D6520", VA = "0x1818D7B20")]
			get
			{
				return onlineAutoLogin_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C11")]
			[Cpp2IlInjected.Address(RVA = "0x18D82B0", Offset = "0x18D6CB0", VA = "0x1818D82B0")]
			set
			{
				onlineAutoLogin_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FE9")]
		[DebuggerNonUserCode]
		public bool DisableGameloftTracking
		{
			[Cpp2IlInjected.Token(Token = "0x6005C12")]
			[Cpp2IlInjected.Address(RVA = "0x18D7850", Offset = "0x18D6250", VA = "0x1818D7850")]
			get
			{
				return disableGameloftTracking_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C13")]
			[Cpp2IlInjected.Address(RVA = "0x18D8000", Offset = "0x18D6A00", VA = "0x1818D8000")]
			set
			{
				disableGameloftTracking_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FEA")]
		[DebuggerNonUserCode]
		public int ForceValidateSessionIntervalTimeInSec
		{
			[Cpp2IlInjected.Token(Token = "0x6005C14")]
			[Cpp2IlInjected.Address(RVA = "0x18D7A80", Offset = "0x18D6480", VA = "0x1818D7A80")]
			get
			{
				return forceValidateSessionIntervalTimeInSec_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C15")]
			[Cpp2IlInjected.Address(RVA = "0x18D8130", Offset = "0x18D6B30", VA = "0x1818D8130")]
			set
			{
				forceValidateSessionIntervalTimeInSec_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FEB")]
		[DebuggerNonUserCode]
		public bool UseOnlineDebugConfigSettings
		{
			[Cpp2IlInjected.Token(Token = "0x6005C16")]
			[Cpp2IlInjected.Address(RVA = "0xF32FF0", Offset = "0xF319F0", VA = "0x180F32FF0")]
			get
			{
				return useOnlineDebugConfigSettings_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C17")]
			[Cpp2IlInjected.Address(RVA = "0xF33000", Offset = "0xF31A00", VA = "0x180F33000")]
			set
			{
				useOnlineDebugConfigSettings_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FEC")]
		[DebuggerNonUserCode]
		public string CommandLineArguments
		{
			[Cpp2IlInjected.Token(Token = "0x6005C18")]
			[Cpp2IlInjected.Address(RVA = "0x7389E0", Offset = "0x7373E0", VA = "0x1807389E0")]
			get
			{
				return commandLineArguments_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C19")]
			[Cpp2IlInjected.Address(RVA = "0x18D7EF0", Offset = "0x18D68F0", VA = "0x1818D7EF0")]
			set
			{
				string text = (commandLineArguments_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FED")]
		[DebuggerNonUserCode]
		public int PlayerLogBackupMaxAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6005C1A")]
			[Cpp2IlInjected.Address(RVA = "0xE58430", Offset = "0xE56E30", VA = "0x180E58430")]
			get
			{
				return playerLogBackupMaxAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C1B")]
			[Cpp2IlInjected.Address(RVA = "0xE58480", Offset = "0xE56E80", VA = "0x180E58480")]
			set
			{
				playerLogBackupMaxAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FEE")]
		[DebuggerNonUserCode]
		public int SystemTimeAddDays
		{
			[Cpp2IlInjected.Token(Token = "0x6005C1C")]
			[Cpp2IlInjected.Address(RVA = "0x18D7D50", Offset = "0x18D6750", VA = "0x1818D7D50")]
			get
			{
				return systemTimeAddDays_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C1D")]
			[Cpp2IlInjected.Address(RVA = "0x18D8740", Offset = "0x18D7140", VA = "0x1818D8740")]
			set
			{
				systemTimeAddDays_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FEF")]
		[DebuggerNonUserCode]
		public int SystemTimeAddHours
		{
			[Cpp2IlInjected.Token(Token = "0x6005C1E")]
			[Cpp2IlInjected.Address(RVA = "0xE4DF60", Offset = "0xE4C960", VA = "0x180E4DF60")]
			get
			{
				return systemTimeAddHours_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C1F")]
			[Cpp2IlInjected.Address(RVA = "0x14A99F0", Offset = "0x14A83F0", VA = "0x1814A99F0")]
			set
			{
				systemTimeAddHours_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FF0")]
		[DebuggerNonUserCode]
		public int SystemTimeAddMinutes
		{
			[Cpp2IlInjected.Token(Token = "0x6005C20")]
			[Cpp2IlInjected.Address(RVA = "0x18D7D60", Offset = "0x18D6760", VA = "0x1818D7D60")]
			get
			{
				return systemTimeAddMinutes_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C21")]
			[Cpp2IlInjected.Address(RVA = "0x14A9920", Offset = "0x14A8320", VA = "0x1814A9920")]
			set
			{
				systemTimeAddMinutes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FF1")]
		[DebuggerNonUserCode]
		public bool MuteAll
		{
			[Cpp2IlInjected.Token(Token = "0x6005C22")]
			[Cpp2IlInjected.Address(RVA = "0x18D7AB0", Offset = "0x18D64B0", VA = "0x1818D7AB0")]
			get
			{
				return muteAll_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C23")]
			[Cpp2IlInjected.Address(RVA = "0x18D8240", Offset = "0x18D6C40", VA = "0x1818D8240")]
			set
			{
				muteAll_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FF2")]
		[DebuggerNonUserCode]
		public bool MuteMusic
		{
			[Cpp2IlInjected.Token(Token = "0x6005C24")]
			[Cpp2IlInjected.Address(RVA = "0x18D7AC0", Offset = "0x18D64C0", VA = "0x1818D7AC0")]
			get
			{
				return muteMusic_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C25")]
			[Cpp2IlInjected.Address(RVA = "0x18D8250", Offset = "0x18D6C50", VA = "0x1818D8250")]
			set
			{
				muteMusic_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FF3")]
		[DebuggerNonUserCode]
		public bool MuteSfx
		{
			[Cpp2IlInjected.Token(Token = "0x6005C26")]
			[Cpp2IlInjected.Address(RVA = "0x18D7AD0", Offset = "0x18D64D0", VA = "0x1818D7AD0")]
			get
			{
				return muteSfx_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C27")]
			[Cpp2IlInjected.Address(RVA = "0x18D8260", Offset = "0x18D6C60", VA = "0x1818D8260")]
			set
			{
				muteSfx_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FF4")]
		[DebuggerNonUserCode]
		public bool MuteVO
		{
			[Cpp2IlInjected.Token(Token = "0x6005C28")]
			[Cpp2IlInjected.Address(RVA = "0x18D7AE0", Offset = "0x18D64E0", VA = "0x1818D7AE0")]
			get
			{
				return muteVO_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C29")]
			[Cpp2IlInjected.Address(RVA = "0x18D8270", Offset = "0x18D6C70", VA = "0x1818D8270")]
			set
			{
				muteVO_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FF5")]
		[DebuggerNonUserCode]
		public bool AllowPortraitScreen
		{
			[Cpp2IlInjected.Token(Token = "0x6005C2A")]
			[Cpp2IlInjected.Address(RVA = "0xFF8910", Offset = "0xFF7310", VA = "0x180FF8910")]
			get
			{
				return allowPortraitScreen_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C2B")]
			[Cpp2IlInjected.Address(RVA = "0x18D7E60", Offset = "0x18D6860", VA = "0x1818D7E60")]
			set
			{
				allowPortraitScreen_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FF6")]
		[DebuggerNonUserCode]
		public bool UsePortraitScreenOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6005C2C")]
			[Cpp2IlInjected.Address(RVA = "0x18D7DA0", Offset = "0x18D67A0", VA = "0x1818D7DA0")]
			get
			{
				return usePortraitScreenOnly_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C2D")]
			[Cpp2IlInjected.Address(RVA = "0x18D8780", Offset = "0x18D7180", VA = "0x1818D8780")]
			set
			{
				usePortraitScreenOnly_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FF7")]
		[DebuggerNonUserCode]
		public bool UseIngameDebug
		{
			[Cpp2IlInjected.Token(Token = "0x6005C2E")]
			[Cpp2IlInjected.Address(RVA = "0x18D7D80", Offset = "0x18D6780", VA = "0x1818D7D80")]
			get
			{
				return useIngameDebug_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C2F")]
			[Cpp2IlInjected.Address(RVA = "0x18D8760", Offset = "0x18D7160", VA = "0x1818D8760")]
			set
			{
				useIngameDebug_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FF8")]
		[DebuggerNonUserCode]
		public string OverridePlatform
		{
			[Cpp2IlInjected.Token(Token = "0x6005C30")]
			[Cpp2IlInjected.Address(RVA = "0x9760E0", Offset = "0x974AE0", VA = "0x1809760E0")]
			get
			{
				return overridePlatform_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C31")]
			[Cpp2IlInjected.Address(RVA = "0x18D8390", Offset = "0x18D6D90", VA = "0x1818D8390")]
			set
			{
				string text = (overridePlatform_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FF9")]
		[DebuggerNonUserCode]
		public bool ShowFPS
		{
			[Cpp2IlInjected.Token(Token = "0x6005C32")]
			[Cpp2IlInjected.Address(RVA = "0x897F00", Offset = "0x896900", VA = "0x180897F00")]
			get
			{
				return showFPS_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C33")]
			[Cpp2IlInjected.Address(RVA = "0x8987B0", Offset = "0x8971B0", VA = "0x1808987B0")]
			set
			{
				showFPS_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FFA")]
		[DebuggerNonUserCode]
		public bool ShowMipmapStreamingInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6005C34")]
			[Cpp2IlInjected.Address(RVA = "0x897F10", Offset = "0x896910", VA = "0x180897F10")]
			get
			{
				return showMipmapStreamingInfo_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C35")]
			[Cpp2IlInjected.Address(RVA = "0x898860", Offset = "0x897260", VA = "0x180898860")]
			set
			{
				showMipmapStreamingInfo_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FFB")]
		[DebuggerNonUserCode]
		public bool ShowSystemInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6005C36")]
			[Cpp2IlInjected.Address(RVA = "0x18D7D30", Offset = "0x18D6730", VA = "0x1818D7D30")]
			get
			{
				return showSystemInfo_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C37")]
			[Cpp2IlInjected.Address(RVA = "0x18D8720", Offset = "0x18D7120", VA = "0x1818D8720")]
			set
			{
				showSystemInfo_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FFC")]
		[DebuggerNonUserCode]
		public bool ShowMemoryInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6005C38")]
			[Cpp2IlInjected.Address(RVA = "0x18D7D20", Offset = "0x18D6720", VA = "0x1818D7D20")]
			get
			{
				return showMemoryInfo_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C39")]
			[Cpp2IlInjected.Address(RVA = "0x18D8710", Offset = "0x18D7110", VA = "0x1818D8710")]
			set
			{
				showMemoryInfo_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FFD")]
		[DebuggerNonUserCode]
		public bool LogDeviceInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6005C3A")]
			[Cpp2IlInjected.Address(RVA = "0x18D7A90", Offset = "0x18D6490", VA = "0x1818D7A90")]
			get
			{
				return logDeviceInfo_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C3B")]
			[Cpp2IlInjected.Address(RVA = "0x18D8220", Offset = "0x18D6C20", VA = "0x1818D8220")]
			set
			{
				logDeviceInfo_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FFE")]
		[DebuggerNonUserCode]
		public bool EasyRead
		{
			[Cpp2IlInjected.Token(Token = "0x6005C3C")]
			[Cpp2IlInjected.Address(RVA = "0x18D7A00", Offset = "0x18D6400", VA = "0x1818D7A00")]
			get
			{
				return easyRead_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C3D")]
			[Cpp2IlInjected.Address(RVA = "0x18D8040", Offset = "0x18D6A40", VA = "0x1818D8040")]
			set
			{
				easyRead_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FFF")]
		[DebuggerNonUserCode]
		public bool ForceNoGamepad
		{
			[Cpp2IlInjected.Token(Token = "0x6005C3E")]
			[Cpp2IlInjected.Address(RVA = "0x18D7A40", Offset = "0x18D6440", VA = "0x1818D7A40")]
			get
			{
				return forceNoGamepad_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C3F")]
			[Cpp2IlInjected.Address(RVA = "0x18D80F0", Offset = "0x18D6AF0", VA = "0x1818D80F0")]
			set
			{
				forceNoGamepad_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001000")]
		[DebuggerNonUserCode]
		public ControlType OverrideGamepadControlType
		{
			[Cpp2IlInjected.Token(Token = "0x6005C40")]
			[Cpp2IlInjected.Address(RVA = "0x18D7B70", Offset = "0x18D6570", VA = "0x1818D7B70")]
			get
			{
				return overrideGamepadControlType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C41")]
			[Cpp2IlInjected.Address(RVA = "0x18D8300", Offset = "0x18D6D00", VA = "0x1818D8300")]
			set
			{
				overrideGamepadControlType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001001")]
		[DebuggerNonUserCode]
		public bool DisableDistanceCulling
		{
			[Cpp2IlInjected.Token(Token = "0x6005C42")]
			[Cpp2IlInjected.Address(RVA = "0xD2D5E0", Offset = "0xD2BFE0", VA = "0x180D2D5E0")]
			get
			{
				return disableDistanceCulling_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C43")]
			[Cpp2IlInjected.Address(RVA = "0xD2D620", Offset = "0xD2C020", VA = "0x180D2D620")]
			set
			{
				disableDistanceCulling_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001002")]
		[DebuggerNonUserCode]
		public UnityLogType ForceUnityLogType
		{
			[Cpp2IlInjected.Token(Token = "0x6005C44")]
			[Cpp2IlInjected.Address(RVA = "0x18D7A70", Offset = "0x18D6470", VA = "0x1818D7A70")]
			get
			{
				return forceUnityLogType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C45")]
			[Cpp2IlInjected.Address(RVA = "0x18D8120", Offset = "0x18D6B20", VA = "0x1818D8120")]
			set
			{
				forceUnityLogType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001003")]
		[DebuggerNonUserCode]
		public bool DisableGridObjStreaming
		{
			[Cpp2IlInjected.Token(Token = "0x6005C46")]
			[Cpp2IlInjected.Address(RVA = "0xE4DF70", Offset = "0xE4C970", VA = "0x180E4DF70")]
			get
			{
				return disableGridObjStreaming_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C47")]
			[Cpp2IlInjected.Address(RVA = "0xE4E110", Offset = "0xE4CB10", VA = "0x180E4E110")]
			set
			{
				disableGridObjStreaming_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001004")]
		[DebuggerNonUserCode]
		public bool AutoBuildHouse
		{
			[Cpp2IlInjected.Token(Token = "0x6005C48")]
			[Cpp2IlInjected.Address(RVA = "0x18D7740", Offset = "0x18D6140", VA = "0x1818D7740")]
			get
			{
				return autoBuildHouse_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C49")]
			[Cpp2IlInjected.Address(RVA = "0x18D7EE0", Offset = "0x18D68E0", VA = "0x1818D7EE0")]
			set
			{
				autoBuildHouse_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001005")]
		[DebuggerNonUserCode]
		public bool InfiniteStamina
		{
			[Cpp2IlInjected.Token(Token = "0x6005C4A")]
			[Cpp2IlInjected.Address(RVA = "0x12F32D0", Offset = "0x12F1CD0", VA = "0x1812F32D0")]
			get
			{
				return infiniteStamina_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C4B")]
			[Cpp2IlInjected.Address(RVA = "0x12F41C0", Offset = "0x12F2BC0", VA = "0x1812F41C0")]
			set
			{
				infiniteStamina_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001006")]
		[DebuggerNonUserCode]
		public bool ForceBacktraceOn
		{
			[Cpp2IlInjected.Token(Token = "0x6005C4C")]
			[Cpp2IlInjected.Address(RVA = "0x18D7A20", Offset = "0x18D6420", VA = "0x1818D7A20")]
			get
			{
				return forceBacktraceOn_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C4D")]
			[Cpp2IlInjected.Address(RVA = "0x18D80D0", Offset = "0x18D6AD0", VA = "0x1818D80D0")]
			set
			{
				forceBacktraceOn_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001007")]
		[DebuggerNonUserCode]
		public bool RdpHack
		{
			[Cpp2IlInjected.Token(Token = "0x6005C4E")]
			[Cpp2IlInjected.Address(RVA = "0xD06C80", Offset = "0xD05680", VA = "0x180D06C80")]
			get
			{
				return rdpHack_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C4F")]
			[Cpp2IlInjected.Address(RVA = "0xD07450", Offset = "0xD05E50", VA = "0x180D07450")]
			set
			{
				rdpHack_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001008")]
		[DebuggerNonUserCode]
		public bool OverridePcControls
		{
			[Cpp2IlInjected.Token(Token = "0x6005C50")]
			[Cpp2IlInjected.Address(RVA = "0x18D7B80", Offset = "0x18D6580", VA = "0x1818D7B80")]
			get
			{
				return overridePcControls_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C51")]
			[Cpp2IlInjected.Address(RVA = "0x18D8380", Offset = "0x18D6D80", VA = "0x1818D8380")]
			set
			{
				overridePcControls_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001009")]
		[DebuggerNonUserCode]
		public ControlSchemeType OverrideControlScheme
		{
			[Cpp2IlInjected.Token(Token = "0x6005C52")]
			[Cpp2IlInjected.Address(RVA = "0x18D7B60", Offset = "0x18D6560", VA = "0x1818D7B60")]
			get
			{
				return overrideControlScheme_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C53")]
			[Cpp2IlInjected.Address(RVA = "0x18D82F0", Offset = "0x18D6CF0", VA = "0x1818D82F0")]
			set
			{
				overrideControlScheme_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700100A")]
		[DebuggerNonUserCode]
		public ControlSchemeType OVerrideHookedControlScheme
		{
			[Cpp2IlInjected.Token(Token = "0x6005C54")]
			[Cpp2IlInjected.Address(RVA = "0x18D7B10", Offset = "0x18D6510", VA = "0x1818D7B10")]
			get
			{
				return oVerrideHookedControlScheme_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C55")]
			[Cpp2IlInjected.Address(RVA = "0x18D82A0", Offset = "0x18D6CA0", VA = "0x1818D82A0")]
			set
			{
				oVerrideHookedControlScheme_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700100B")]
		[DebuggerNonUserCode]
		public bool ActivateS1Hack
		{
			[Cpp2IlInjected.Token(Token = "0x6005C56")]
			[Cpp2IlInjected.Address(RVA = "0xA5C3C0", Offset = "0xA5ADC0", VA = "0x180A5C3C0")]
			get
			{
				return activateS1Hack_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C57")]
			[Cpp2IlInjected.Address(RVA = "0xA5C400", Offset = "0xA5AE00", VA = "0x180A5C400")]
			set
			{
				activateS1Hack_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700100C")]
		[DebuggerNonUserCode]
		public string OverrideMarketPlaceName
		{
			[Cpp2IlInjected.Token(Token = "0x6005C58")]
			[Cpp2IlInjected.Address(RVA = "0x975C80", Offset = "0x974680", VA = "0x180975C80")]
			get
			{
				return overrideMarketPlaceName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C59")]
			[Cpp2IlInjected.Address(RVA = "0x18D8310", Offset = "0x18D6D10", VA = "0x1818D8310")]
			set
			{
				string text = (overrideMarketPlaceName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700100D")]
		[DebuggerNonUserCode]
		public string PSNOverrideServiceLabel
		{
			[Cpp2IlInjected.Token(Token = "0x6005C5A")]
			[Cpp2IlInjected.Address(RVA = "0x738A00", Offset = "0x737400", VA = "0x180738A00")]
			get
			{
				return pSNOverrideServiceLabel_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C5B")]
			[Cpp2IlInjected.Address(RVA = "0x18D84B0", Offset = "0x18D6EB0", VA = "0x1818D84B0")]
			set
			{
				string text = (pSNOverrideServiceLabel_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700100E")]
		[DebuggerNonUserCode]
		public string PSNOverrideEnv
		{
			[Cpp2IlInjected.Token(Token = "0x6005C5C")]
			[Cpp2IlInjected.Address(RVA = "0x738EC0", Offset = "0x7378C0", VA = "0x180738EC0")]
			get
			{
				return pSNOverrideEnv_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C5D")]
			[Cpp2IlInjected.Address(RVA = "0x18D8440", Offset = "0x18D6E40", VA = "0x1818D8440")]
			set
			{
				string text = (pSNOverrideEnv_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700100F")]
		[DebuggerNonUserCode]
		public bool DoFakeRedeemFromClient
		{
			[Cpp2IlInjected.Token(Token = "0x6005C5E")]
			[Cpp2IlInjected.Address(RVA = "0x18D7990", Offset = "0x18D6390", VA = "0x1818D7990")]
			get
			{
				return doFakeRedeemFromClient_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C5F")]
			[Cpp2IlInjected.Address(RVA = "0x12F4200", Offset = "0x12F2C00", VA = "0x1812F4200")]
			set
			{
				doFakeRedeemFromClient_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001010")]
		[DebuggerNonUserCode]
		public PlayfabOriginId OverridePlayfabOrigin
		{
			[Cpp2IlInjected.Token(Token = "0x6005C60")]
			[Cpp2IlInjected.Address(RVA = "0x975F70", Offset = "0x974970", VA = "0x180975F70")]
			get
			{
				return overridePlayfabOrigin_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C61")]
			[Cpp2IlInjected.Address(RVA = "0x9765C0", Offset = "0x974FC0", VA = "0x1809765C0")]
			set
			{
				overridePlayfabOrigin_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001011")]
		[DebuggerNonUserCode]
		public bool ForceSaveToPlayFabFailure
		{
			[Cpp2IlInjected.Token(Token = "0x6005C62")]
			[Cpp2IlInjected.Address(RVA = "0x18D7A60", Offset = "0x18D6460", VA = "0x1818D7A60")]
			get
			{
				return forceSaveToPlayFabFailure_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C63")]
			[Cpp2IlInjected.Address(RVA = "0x18D8110", Offset = "0x18D6B10", VA = "0x1818D8110")]
			set
			{
				forceSaveToPlayFabFailure_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001012")]
		[DebuggerNonUserCode]
		public bool NxSimulateNoInternet
		{
			[Cpp2IlInjected.Token(Token = "0x6005C64")]
			[Cpp2IlInjected.Address(RVA = "0x18D7AF0", Offset = "0x18D64F0", VA = "0x1818D7AF0")]
			get
			{
				return nxSimulateNoInternet_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C65")]
			[Cpp2IlInjected.Address(RVA = "0x18D8280", Offset = "0x18D6C80", VA = "0x1818D8280")]
			set
			{
				nxSimulateNoInternet_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001013")]
		[DebuggerNonUserCode]
		public bool NxSimulateNoNSA
		{
			[Cpp2IlInjected.Token(Token = "0x6005C66")]
			[Cpp2IlInjected.Address(RVA = "0x18D7B00", Offset = "0x18D6500", VA = "0x1818D7B00")]
			get
			{
				return nxSimulateNoNSA_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C67")]
			[Cpp2IlInjected.Address(RVA = "0x18D8290", Offset = "0x18D6C90", VA = "0x1818D8290")]
			set
			{
				nxSimulateNoNSA_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001014")]
		[DebuggerNonUserCode]
		public bool OnlineSimulateNoInternet
		{
			[Cpp2IlInjected.Token(Token = "0x6005C68")]
			[Cpp2IlInjected.Address(RVA = "0x18D7B30", Offset = "0x18D6530", VA = "0x1818D7B30")]
			get
			{
				return onlineSimulateNoInternet_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C69")]
			[Cpp2IlInjected.Address(RVA = "0x18D82C0", Offset = "0x18D6CC0", VA = "0x1818D82C0")]
			set
			{
				onlineSimulateNoInternet_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001015")]
		[DebuggerNonUserCode]
		public bool OnlineSimulatePlayFabNotLoggedIn
		{
			[Cpp2IlInjected.Token(Token = "0x6005C6A")]
			[Cpp2IlInjected.Address(RVA = "0x18D7B40", Offset = "0x18D6540", VA = "0x1818D7B40")]
			get
			{
				return onlineSimulatePlayFabNotLoggedIn_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C6B")]
			[Cpp2IlInjected.Address(RVA = "0x18D82D0", Offset = "0x18D6CD0", VA = "0x1818D82D0")]
			set
			{
				onlineSimulatePlayFabNotLoggedIn_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001016")]
		[DebuggerNonUserCode]
		public bool OnlineSimulatePortalNotLoggedIn
		{
			[Cpp2IlInjected.Token(Token = "0x6005C6C")]
			[Cpp2IlInjected.Address(RVA = "0x18D7B50", Offset = "0x18D6550", VA = "0x1818D7B50")]
			get
			{
				return onlineSimulatePortalNotLoggedIn_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C6D")]
			[Cpp2IlInjected.Address(RVA = "0x18D82E0", Offset = "0x18D6CE0", VA = "0x1818D82E0")]
			set
			{
				onlineSimulatePortalNotLoggedIn_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001017")]
		public static DebugSettingsDispatcher Dispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x6005C79")]
			[Cpp2IlInjected.Address(RVA = "0x18D7880", Offset = "0x18D6280", VA = "0x1818D7880")]
			get
			{
				//Discarded unreachable code: IL_0010
				_parser = (MessageParser<DebugSettings>)(object)new DebugSettingsDispatcher();
				return _dispatcher;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001018")]
		[field: Cpp2IlInjected.Token(Token = "0x4002A82")]
		public static bool WasCreatedThisSession
		{
			[Cpp2IlInjected.Token(Token = "0x6005C7A")]
			[Cpp2IlInjected.Address(RVA = "0x18D7DB0", Offset = "0x18D67B0", VA = "0x1818D7DB0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005C7B")]
			[Cpp2IlInjected.Address(RVA = "0x18D8800", Offset = "0x18D7200", VA = "0x1818D8800")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001019")]
		public static DebugSettings Settings
		{
			[Cpp2IlInjected.Token(Token = "0x6005C7C")]
			[Cpp2IlInjected.Address(RVA = "0x18D7C40", Offset = "0x18D6640", VA = "0x1818D7C40")]
			get
			{
				//Discarded unreachable code: IL_000d
				int num = 0;
				Load();
				return _settings;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700101A")]
		private static IFileSystem FileSystem
		{
			[Cpp2IlInjected.Token(Token = "0x6005C7D")]
			[Cpp2IlInjected.Address(RVA = "0x738C50", Offset = "0x737650", VA = "0x180738C50")]
			get
			{
				return Definitions.Util.FileSystem.SaveGlobal;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700101B")]
		public bool DoResetProfile
		{
			[Cpp2IlInjected.Token(Token = "0x6005C7E")]
			[Cpp2IlInjected.Address(RVA = "0x18D79A0", Offset = "0x18D63A0", VA = "0x1818D79A0")]
			get
			{
				if (!resetProfile_ && !resetProfileOnce_ && string.IsNullOrEmpty(profileSlot_))
				{
					return !string.IsNullOrEmpty(playfabProfileSlot_);
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700101C")]
		public bool UseDebugGoButton
		{
			[Cpp2IlInjected.Token(Token = "0x6005C87")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B94")]
		[Cpp2IlInjected.Address(RVA = "0x18D7540", Offset = "0x18D5F40", VA = "0x1818D7540")]
		[DebuggerNonUserCode]
		public DebugSettings()
		{
			profileSlot_ = "";
			environment_ = "";
			userId_ = "";
			password_ = "";
			portalIp_ = "";
			playfabProfileSlot_ = "";
			defaultVillageDataPath_ = "";
			altVillageScene_ = "";
			language_ = "";
			graphicQuality_ = "";
			commandLineArguments_ = "";
			overridePlatform_ = "";
			overrideMarketPlaceName_ = "";
			pSNOverrideServiceLabel_ = "";
			pSNOverrideEnv_ = "";
			base._002Ector();
			string text = (graphicQuality_ = ProtoPreconditions.CheckNotNull("NoOverride", "value"));
			showStartMenu_ = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B95")]
		[Cpp2IlInjected.Address(RVA = "0x18D2F10", Offset = "0x18D1910", VA = "0x1818D2F10")]
		private void OnConstruction()
		{
			string text = (graphicQuality_ = ProtoPreconditions.CheckNotNull("NoOverride", "value"));
			showStartMenu_ = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B96")]
		[Cpp2IlInjected.Address(RVA = "0x18D6FC0", Offset = "0x18D59C0", VA = "0x1818D6FC0")]
		[DebuggerNonUserCode]
		public DebugSettings(DebugSettings other)
		{
			bool flag = (resetProfileOnce_ = other.resetProfileOnce_);
			bool flag2 = (resetProfile_ = other.resetProfile_);
			bool flag3 = (showStartMenu_ = other.showStartMenu_);
			string text = (profileSlot_ = other.profileSlot_);
			bool flag4 = (skipIntroSequence_ = other.skipIntroSequence_);
			bool flag5 = (skipAllCutscenes_ = other.skipAllCutscenes_);
			bool flag6 = (canAlwaysSkipCutscene_ = other.canAlwaysSkipCutscene_);
			bool flag7 = (disableAllFtue_ = other.disableAllFtue_);
			MetaThreadPriority metaThreadPriority = (backgroundLoadingThreadPriority_ = other.backgroundLoadingThreadPriority_);
			bool flag8 = (unlockAllTools_ = other.unlockAllTools_);
			bool flag9 = (forceCharactersOutside_ = other.forceCharactersOutside_);
			bool flag10 = (useCheats_ = other.useCheats_);
			bool flag11 = (useDefaultFreeCam_ = other.useDefaultFreeCam_);
			bool flag12 = (useMarketingCam_ = other.useMarketingCam_);
			bool flag13 = (showLocalizationRef_ = other.showLocalizationRef_);
			bool flag14 = (showLocalizationStringIds_ = other.showLocalizationStringIds_);
			bool flag15 = (enablePseudolocalization_ = other.enablePseudolocalization_);
			bool flag16 = (offline_ = other.offline_);
			string text2 = (environment_ = other.environment_);
			CloudFunctionMode cloudFunctionMode = (cloudFunctionMode_ = other.cloudFunctionMode_);
			bool flag17 = (showScheduledStarPathEvents_ = other.showScheduledStarPathEvents_);
			bool flag18 = (showScheduledBundlesAndStores_ = other.showScheduledBundlesAndStores_);
			string text3 = (userId_ = other.userId_);
			string text4 = (password_ = other.password_);
			string text5 = (portalIp_ = other.portalIp_);
			int num = (portalPort_ = other.portalPort_);
			int num2 = (cloudFunctionVersions_ = other.cloudFunctionVersions_);
			bool flag19 = (resetOnlineUserId_ = other.resetOnlineUserId_);
			string text6 = (playfabProfileSlot_ = other.playfabProfileSlot_);
			StreamingConfigOverrideType streamingConfigOverrideType = (overrideStreamingConfig_ = other.overrideStreamingConfig_);
			string text7 = (defaultVillageDataPath_ = other.defaultVillageDataPath_);
			string text8 = (altVillageScene_ = other.altVillageScene_);
			bool flag20 = (useSoftwareCursor_ = other.useSoftwareCursor_);
			bool flag21 = (useSteamworks_ = other.useSteamworks_);
			string text9 = (language_ = other.language_);
			bool flag22 = (autoDetectQuality_ = other.autoDetectQuality_);
			string text10 = (graphicQuality_ = other.graphicQuality_);
			ShaderQualityEnum shaderQualityEnum = (overrideShaderQuality_ = other.overrideShaderQuality_);
			StreamingMipmapsEnum streamingMipmapsEnum = (overrideStreamingMipmaps_ = other.overrideStreamingMipmaps_);
			LodSkipEnum lodSkipEnum = (overrideLodSkip_ = other.overrideLodSkip_);
			bool flag23 = (runtimeAdjustableQuality_ = other.runtimeAdjustableQuality_);
			ScreenModeEnum screenModeEnum = (screenMode_ = other.screenMode_);
			bool flag24 = (streamingTextureFreeUnused_ = other.streamingTextureFreeUnused_);
			bool flag25 = (lowMemoryManager_ = other.lowMemoryManager_);
			bool flag26 = (debugAccountLinking_ = other.debugAccountLinking_);
			bool flag27 = (disableProfileUpload_ = other.disableProfileUpload_);
			bool flag28 = (forceConflictPrompt_ = other.forceConflictPrompt_);
			int num3 = (resolveConflictDelayMS_ = other.resolveConflictDelayMS_);
			bool flag29 = (forceNativeUnlink_ = other.forceNativeUnlink_);
			SaveOnExitPolicyType saveOnExitPolicyType = (overrideSaveOnExitPolicy_ = other.overrideSaveOnExitPolicy_);
			bool flag30 = (deleteLocalProfileOnly_ = other.deleteLocalProfileOnly_);
			bool flag31 = (dontRestoreRemoteSave_ = other.dontRestoreRemoteSave_);
			float num4 = (overrideUploadProfileCooldownMin_ = other.overrideUploadProfileCooldownMin_);
			float num5 = (overrideShowLoginPromptCooldownSec_ = other.overrideShowLoginPromptCooldownSec_);
			bool flag32 = (forceProfileEncryption_ = other.forceProfileEncryption_);
			bool flag33 = (disableAutoSave_ = other.disableAutoSave_);
			bool flag34 = (useMinimalLogVerbosity_ = other.useMinimalLogVerbosity_);
			bool flag35 = (disableSwitchCPUBoostMode_ = other.disableSwitchCPUBoostMode_);
			bool flag36 = (disableLoadingScope_ = other.disableLoadingScope_);
			bool flag37 = (forceEnableLoadingScopeForSwitch_ = other.forceEnableLoadingScopeForSwitch_);
			bool flag38 = (onlineAutoLogin_ = other.onlineAutoLogin_);
			bool flag39 = (disableGameloftTracking_ = other.disableGameloftTracking_);
			int num6 = (forceValidateSessionIntervalTimeInSec_ = other.forceValidateSessionIntervalTimeInSec_);
			bool flag40 = (useOnlineDebugConfigSettings_ = other.useOnlineDebugConfigSettings_);
			string text11 = (commandLineArguments_ = other.commandLineArguments_);
			int num7 = (playerLogBackupMaxAmount_ = other.playerLogBackupMaxAmount_);
			int num8 = (systemTimeAddDays_ = other.systemTimeAddDays_);
			int num9 = (systemTimeAddHours_ = other.systemTimeAddHours_);
			int num10 = (systemTimeAddMinutes_ = other.systemTimeAddMinutes_);
			bool flag41 = (muteAll_ = other.muteAll_);
			bool flag42 = (muteMusic_ = other.muteMusic_);
			bool flag43 = (muteSfx_ = other.muteSfx_);
			bool flag44 = (muteVO_ = other.muteVO_);
			bool flag45 = (allowPortraitScreen_ = other.allowPortraitScreen_);
			bool flag46 = (usePortraitScreenOnly_ = other.usePortraitScreenOnly_);
			bool flag47 = (useIngameDebug_ = other.useIngameDebug_);
			string text12 = (overridePlatform_ = other.overridePlatform_);
			bool flag48 = (showFPS_ = other.showFPS_);
			bool flag49 = (showMipmapStreamingInfo_ = other.showMipmapStreamingInfo_);
			bool flag50 = (showSystemInfo_ = other.showSystemInfo_);
			bool flag51 = (showMemoryInfo_ = other.showMemoryInfo_);
			bool flag52 = (logDeviceInfo_ = other.logDeviceInfo_);
			bool flag53 = (easyRead_ = other.easyRead_);
			bool flag54 = (forceNoGamepad_ = other.forceNoGamepad_);
			ControlType controlType = (overrideGamepadControlType_ = other.overrideGamepadControlType_);
			bool flag55 = (disableDistanceCulling_ = other.disableDistanceCulling_);
			UnityLogType unityLogType = (forceUnityLogType_ = other.forceUnityLogType_);
			bool flag56 = (disableGridObjStreaming_ = other.disableGridObjStreaming_);
			bool flag57 = (autoBuildHouse_ = other.autoBuildHouse_);
			bool flag58 = (infiniteStamina_ = other.infiniteStamina_);
			bool flag59 = (forceBacktraceOn_ = other.forceBacktraceOn_);
			bool flag60 = (rdpHack_ = other.rdpHack_);
			bool flag61 = (overridePcControls_ = other.overridePcControls_);
			ControlSchemeType controlSchemeType = (overrideControlScheme_ = other.overrideControlScheme_);
			ControlSchemeType controlSchemeType2 = (oVerrideHookedControlScheme_ = other.oVerrideHookedControlScheme_);
			bool flag62 = (activateS1Hack_ = other.activateS1Hack_);
			string text13 = (overrideMarketPlaceName_ = other.overrideMarketPlaceName_);
			string text14 = (pSNOverrideServiceLabel_ = other.pSNOverrideServiceLabel_);
			string text15 = (pSNOverrideEnv_ = other.pSNOverrideEnv_);
			bool flag63 = (doFakeRedeemFromClient_ = other.doFakeRedeemFromClient_);
			PlayfabOriginId playfabOriginId = (overridePlayfabOrigin_ = other.overridePlayfabOrigin_);
			bool flag64 = (forceSaveToPlayFabFailure_ = other.forceSaveToPlayFabFailure_);
			bool flag65 = (nxSimulateNoInternet_ = other.nxSimulateNoInternet_);
			bool flag66 = (nxSimulateNoNSA_ = other.nxSimulateNoNSA_);
			bool flag67 = (onlineSimulateNoInternet_ = other.onlineSimulateNoInternet_);
			bool flag68 = (onlineSimulatePlayFabNotLoggedIn_ = other.onlineSimulatePlayFabNotLoggedIn_);
			bool flag69 = (onlineSimulatePortalNotLoggedIn_ = other.onlineSimulatePortalNotLoggedIn_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B97")]
		[Cpp2IlInjected.Address(RVA = "0x18CEAD0", Offset = "0x18CD4D0", VA = "0x1818CEAD0", Slot = "10")]
		[DebuggerNonUserCode]
		public DebugSettings Clone()
		{
			return new DebugSettings(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005C6E")]
		[Cpp2IlInjected.Address(RVA = "0x18CF3F0", Offset = "0x18CDDF0", VA = "0x1818CF3F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((DebugSettings)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6005C6F")]
		[Cpp2IlInjected.Address(RVA = "0x18CEB30", Offset = "0x18CD530", VA = "0x1818CEB30", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DebugSettings other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.resetProfileOnce_;
				if (resetProfileOnce_ == flag)
				{
					bool flag2 = other.resetProfile_;
					if (resetProfile_ == flag2)
					{
						bool flag3 = other.showStartMenu_;
						if (showStartMenu_ == flag3)
						{
							string text = other.profileSlot_;
							if (!(profileSlot_ != text))
							{
								bool flag4 = other.skipIntroSequence_;
								if (WasCreatedThisSession == flag4)
								{
									bool flag5 = other.skipAllCutscenes_;
									if (skipAllCutscenes_ == flag5)
									{
										bool flag6 = other.canAlwaysSkipCutscene_;
										if (canAlwaysSkipCutscene_ == flag6)
										{
											bool flag7 = other.disableAllFtue_;
											if (disableAllFtue_ == flag7)
											{
												MetaThreadPriority metaThreadPriority = other.backgroundLoadingThreadPriority_;
												if (backgroundLoadingThreadPriority_ == metaThreadPriority)
												{
													bool flag8 = other.unlockAllTools_;
													if ((IntPtr)_settings == (IntPtr)(flag8 ? 1 : 0))
													{
														bool flag9 = other.forceCharactersOutside_;
														if (forceCharactersOutside_ == flag9)
														{
															bool flag10 = other.useCheats_;
															if (useCheats_ == flag10)
															{
																bool flag11 = other.useDefaultFreeCam_;
																if (useDefaultFreeCam_ == flag11)
																{
																	bool flag12 = other.useMarketingCam_;
																	if (useMarketingCam_ == flag12)
																	{
																		bool flag13 = other.showLocalizationRef_;
																		if (showLocalizationRef_ == flag13)
																		{
																			bool flag14 = other.showLocalizationStringIds_;
																			if (showLocalizationStringIds_ == flag14)
																			{
																				bool flag15 = other.enablePseudolocalization_;
																				if (enablePseudolocalization_ == flag15)
																				{
																					bool flag16 = other.offline_;
																					if (offline_ == flag16)
																					{
																						string text2 = other.environment_;
																						if (!(environment_ != text2))
																						{
																							CloudFunctionMode cloudFunctionMode = other.cloudFunctionMode_;
																							if (cloudFunctionMode_ == cloudFunctionMode)
																							{
																								bool flag17 = other.showScheduledStarPathEvents_;
																								if (showScheduledStarPathEvents_ == flag17)
																								{
																									bool flag18 = other.showScheduledBundlesAndStores_;
																									if (showScheduledBundlesAndStores_ == flag18)
																									{
																										string text3 = other.userId_;
																										if (!(userId_ != text3))
																										{
																											string text4 = other.password_;
																											if (!(password_ != text4))
																											{
																												string text5 = other.portalIp_;
																												if (!(portalIp_ != text5))
																												{
																													int num = other.portalPort_;
																													if (portalPort_ == num)
																													{
																														int num2 = other.cloudFunctionVersions_;
																														if (cloudFunctionVersions_ == num2)
																														{
																															bool flag19 = other.resetOnlineUserId_;
																															if (resetOnlineUserId_ == flag19)
																															{
																																string text6 = other.playfabProfileSlot_;
																																if (!(playfabProfileSlot_ != text6))
																																{
																																	StreamingConfigOverrideType streamingConfigOverrideType = other.overrideStreamingConfig_;
																																	if (overrideStreamingConfig_ == streamingConfigOverrideType)
																																	{
																																		string text7 = other.defaultVillageDataPath_;
																																		if (!(defaultVillageDataPath_ != text7))
																																		{
																																			string text8 = other.altVillageScene_;
																																			if (!(altVillageScene_ != text8))
																																			{
																																				bool flag20 = other.useSoftwareCursor_;
																																				if (useSoftwareCursor_ == flag20)
																																				{
																																					bool flag21 = other.useSteamworks_;
																																					if (useSteamworks_ == flag21)
																																					{
																																						string text9 = other.language_;
																																						if (!(language_ != text9))
																																						{
																																							bool flag22 = other.autoDetectQuality_;
																																							if (autoDetectQuality_ == flag22)
																																							{
																																								string text10 = other.graphicQuality_;
																																								if (!(graphicQuality_ != text10))
																																								{
																																									ShaderQualityEnum shaderQualityEnum = other.overrideShaderQuality_;
																																									if (overrideShaderQuality_ == shaderQualityEnum)
																																									{
																																										StreamingMipmapsEnum streamingMipmapsEnum = other.overrideStreamingMipmaps_;
																																										if (overrideStreamingMipmaps_ == streamingMipmapsEnum)
																																										{
																																											LodSkipEnum lodSkipEnum = other.overrideLodSkip_;
																																											if (overrideLodSkip_ == lodSkipEnum)
																																											{
																																												bool flag23 = other.runtimeAdjustableQuality_;
																																												if (runtimeAdjustableQuality_ == flag23)
																																												{
																																													ScreenModeEnum screenModeEnum = other.screenMode_;
																																													if (screenMode_ == screenModeEnum)
																																													{
																																														bool flag24 = other.streamingTextureFreeUnused_;
																																														if (streamingTextureFreeUnused_ == flag24)
																																														{
																																															bool flag25 = other.lowMemoryManager_;
																																															if (lowMemoryManager_ == flag25)
																																															{
																																																bool flag26 = other.debugAccountLinking_;
																																																if (debugAccountLinking_ == flag26)
																																																{
																																																	bool flag27 = other.disableProfileUpload_;
																																																	if (disableProfileUpload_ == flag27)
																																																	{
																																																		bool flag28 = other.forceConflictPrompt_;
																																																		if (forceConflictPrompt_ == flag28)
																																																		{
																																																			int num3 = other.resolveConflictDelayMS_;
																																																			if (resolveConflictDelayMS_ == num3)
																																																			{
																																																				bool flag29 = other.forceNativeUnlink_;
																																																				if (forceNativeUnlink_ == flag29)
																																																				{
																																																					SaveOnExitPolicyType saveOnExitPolicyType = other.overrideSaveOnExitPolicy_;
																																																					if (overrideSaveOnExitPolicy_ == saveOnExitPolicyType)
																																																					{
																																																						bool flag30 = other.deleteLocalProfileOnly_;
																																																						if (deleteLocalProfileOnly_ == flag30)
																																																						{
																																																							bool flag31 = other.dontRestoreRemoteSave_;
																																																							if (dontRestoreRemoteSave_ == flag31)
																																																							{
																																																								bool flag32 = other.forceProfileEncryption_;
																																																								if (forceProfileEncryption_ == flag32)
																																																								{
																																																									bool flag33 = other.disableAutoSave_;
																																																									if (disableAutoSave_ == flag33)
																																																									{
																																																										bool flag34 = other.useMinimalLogVerbosity_;
																																																										if (useMinimalLogVerbosity_ == flag34)
																																																										{
																																																											bool flag35 = other.disableSwitchCPUBoostMode_;
																																																											if (disableSwitchCPUBoostMode_ == flag35)
																																																											{
																																																												bool flag36 = other.disableLoadingScope_;
																																																												if (disableLoadingScope_ == flag36)
																																																												{
																																																													bool flag37 = other.forceEnableLoadingScopeForSwitch_;
																																																													if (forceEnableLoadingScopeForSwitch_ == flag37)
																																																													{
																																																														bool flag38 = other.onlineAutoLogin_;
																																																														if (onlineAutoLogin_ == flag38)
																																																														{
																																																															bool flag39 = other.disableGameloftTracking_;
																																																															if (disableGameloftTracking_ == flag39)
																																																															{
																																																																int num4 = other.forceValidateSessionIntervalTimeInSec_;
																																																																if (forceValidateSessionIntervalTimeInSec_ == num4)
																																																																{
																																																																	bool flag40 = other.useOnlineDebugConfigSettings_;
																																																																	if (useOnlineDebugConfigSettings_ == flag40)
																																																																	{
																																																																		string text11 = other.commandLineArguments_;
																																																																		if (!(commandLineArguments_ != text11))
																																																																		{
																																																																			int num5 = other.playerLogBackupMaxAmount_;
																																																																			if (playerLogBackupMaxAmount_ == num5)
																																																																			{
																																																																				int num6 = other.systemTimeAddDays_;
																																																																				if (systemTimeAddDays_ == num6)
																																																																				{
																																																																					int num7 = other.systemTimeAddHours_;
																																																																					if (systemTimeAddHours_ == num7)
																																																																					{
																																																																						int num8 = other.systemTimeAddMinutes_;
																																																																						if (systemTimeAddMinutes_ == num8)
																																																																						{
																																																																							bool flag41 = other.muteAll_;
																																																																							if (muteAll_ == flag41)
																																																																							{
																																																																								bool flag42 = other.muteMusic_;
																																																																								if (muteMusic_ == flag42)
																																																																								{
																																																																									bool flag43 = other.muteSfx_;
																																																																									if (muteSfx_ == flag43)
																																																																									{
																																																																										bool flag44 = other.muteVO_;
																																																																										if (muteVO_ == flag44)
																																																																										{
																																																																											bool flag45 = other.allowPortraitScreen_;
																																																																											if (allowPortraitScreen_ == flag45)
																																																																											{
																																																																												bool flag46 = other.usePortraitScreenOnly_;
																																																																												if (usePortraitScreenOnly_ == flag46)
																																																																												{
																																																																													bool flag47 = other.useIngameDebug_;
																																																																													if (useIngameDebug_ == flag47)
																																																																													{
																																																																														string text12 = other.overridePlatform_;
																																																																														if (!(overridePlatform_ != text12))
																																																																														{
																																																																															bool flag48 = other.showFPS_;
																																																																															if (showFPS_ == flag48)
																																																																															{
																																																																																bool flag49 = other.showMipmapStreamingInfo_;
																																																																																if (showMipmapStreamingInfo_ == flag49)
																																																																																{
																																																																																	bool flag50 = other.showSystemInfo_;
																																																																																	if (showSystemInfo_ == flag50)
																																																																																	{
																																																																																		bool flag51 = other.showMemoryInfo_;
																																																																																		if (showMemoryInfo_ == flag51)
																																																																																		{
																																																																																			bool flag52 = other.logDeviceInfo_;
																																																																																			if (logDeviceInfo_ == flag52)
																																																																																			{
																																																																																				bool flag53 = other.easyRead_;
																																																																																				if (easyRead_ == flag53)
																																																																																				{
																																																																																					bool flag54 = other.forceNoGamepad_;
																																																																																					if (forceNoGamepad_ == flag54)
																																																																																					{
																																																																																						ControlType controlType = other.overrideGamepadControlType_;
																																																																																						if (overrideGamepadControlType_ == controlType)
																																																																																						{
																																																																																							bool flag55 = other.disableDistanceCulling_;
																																																																																							if (disableDistanceCulling_ == flag55)
																																																																																							{
																																																																																								UnityLogType unityLogType = other.forceUnityLogType_;
																																																																																								if (forceUnityLogType_ == unityLogType)
																																																																																								{
																																																																																									bool flag56 = other.disableGridObjStreaming_;
																																																																																									if (disableGridObjStreaming_ == flag56)
																																																																																									{
																																																																																										bool flag57 = other.autoBuildHouse_;
																																																																																										if (autoBuildHouse_ == flag57)
																																																																																										{
																																																																																											bool flag58 = other.infiniteStamina_;
																																																																																											if (infiniteStamina_ == flag58)
																																																																																											{
																																																																																												bool flag59 = other.forceBacktraceOn_;
																																																																																												if (forceBacktraceOn_ == flag59)
																																																																																												{
																																																																																													bool flag60 = other.rdpHack_;
																																																																																													if (rdpHack_ == flag60)
																																																																																													{
																																																																																														bool flag61 = other.overridePcControls_;
																																																																																														if (overridePcControls_ == flag61)
																																																																																														{
																																																																																															ControlSchemeType controlSchemeType = other.overrideControlScheme_;
																																																																																															if (overrideControlScheme_ == controlSchemeType)
																																																																																															{
																																																																																																ControlSchemeType controlSchemeType2 = other.oVerrideHookedControlScheme_;
																																																																																																if (oVerrideHookedControlScheme_ == controlSchemeType2)
																																																																																																{
																																																																																																	bool flag62 = other.activateS1Hack_;
																																																																																																	if (activateS1Hack_ == flag62)
																																																																																																	{
																																																																																																		string text13 = other.overrideMarketPlaceName_;
																																																																																																		if (!(overrideMarketPlaceName_ != text13))
																																																																																																		{
																																																																																																			string text14 = other.pSNOverrideServiceLabel_;
																																																																																																			if (!(pSNOverrideServiceLabel_ != text14))
																																																																																																			{
																																																																																																				string text15 = other.pSNOverrideEnv_;
																																																																																																				if (!(pSNOverrideEnv_ != text15))
																																																																																																				{
																																																																																																					bool flag63 = other.doFakeRedeemFromClient_;
																																																																																																					if (doFakeRedeemFromClient_ == flag63)
																																																																																																					{
																																																																																																						PlayfabOriginId playfabOriginId = other.overridePlayfabOrigin_;
																																																																																																						if (overridePlayfabOrigin_ == playfabOriginId)
																																																																																																						{
																																																																																																							bool flag64 = other.forceSaveToPlayFabFailure_;
																																																																																																							if (forceSaveToPlayFabFailure_ == flag64)
																																																																																																							{
																																																																																																								bool flag65 = other.nxSimulateNoInternet_;
																																																																																																								if (nxSimulateNoInternet_ == flag65)
																																																																																																								{
																																																																																																									bool flag66 = other.nxSimulateNoNSA_;
																																																																																																									if (nxSimulateNoNSA_ == flag66)
																																																																																																									{
																																																																																																										bool flag67 = other.onlineSimulateNoInternet_;
																																																																																																										if (onlineSimulateNoInternet_ == flag67)
																																																																																																										{
																																																																																																											bool flag68 = other.onlineSimulatePlayFabNotLoggedIn_;
																																																																																																											if (onlineSimulatePlayFabNotLoggedIn_ == flag68)
																																																																																																											{
																																																																																																												bool flag69 = other.onlineSimulatePortalNotLoggedIn_;
																																																																																																												if (onlineSimulatePortalNotLoggedIn_ == flag69)
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
			int num9 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C70")]
		[Cpp2IlInjected.Address(RVA = "0x18CFFA0", Offset = "0x18CE9A0", VA = "0x1818CFFA0", Slot = "2")]
		[DebuggerNonUserCode]
		public unsafe override int GetHashCode()
		{
			//Discarded unreachable code: IL_05c5
			//IL_0303: Expected O, but got I4
			//IL_031a: Expected O, but got I4
			if (resetProfileOnce_)
			{
			}
			if (resetProfile_)
			{
			}
			if (showStartMenu_)
			{
			}
			string text = profileSlot_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			if (skipIntroSequence_)
			{
			}
			if (skipAllCutscenes_)
			{
			}
			if (canAlwaysSkipCutscene_)
			{
			}
			if (disableAllFtue_)
			{
			}
			if (backgroundLoadingThreadPriority_ != 0)
			{
				Result resultCode = ((SessionSearchFindCallbackInfo*)text)->ResultCode;
			}
			if (unlockAllTools_)
			{
			}
			if (forceCharactersOutside_)
			{
			}
			if (useCheats_)
			{
			}
			if (useDefaultFreeCam_)
			{
			}
			if (useMarketingCam_)
			{
			}
			if (showLocalizationRef_)
			{
			}
			if (showLocalizationStringIds_)
			{
			}
			if (enablePseudolocalization_)
			{
			}
			if (offline_)
			{
			}
			string text2 = environment_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			if (cloudFunctionMode_ != 0)
			{
				Result resultCode2 = ((SessionSearchFindCallbackInfo*)text2)->ResultCode;
			}
			if (showScheduledStarPathEvents_)
			{
			}
			if (showScheduledBundlesAndStores_)
			{
			}
			string text3 = userId_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = password_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			string text5 = portalIp_;
			if (text5.m_stringLength != 0)
			{
				int hashCode5 = text5.GetHashCode();
			}
			if (portalPort_ != 0)
			{
				Result resultCode3 = ((SessionSearchFindCallbackInfo*)text5)->ResultCode;
			}
			if (cloudFunctionVersions_ != 0)
			{
				Result resultCode4 = ((SessionSearchFindCallbackInfo*)text5)->ResultCode;
			}
			if (resetOnlineUserId_)
			{
			}
			string text6 = playfabProfileSlot_;
			if (text6.m_stringLength != 0)
			{
				int hashCode6 = text6.GetHashCode();
			}
			if (overrideStreamingConfig_ != 0)
			{
				Result resultCode5 = ((SessionSearchFindCallbackInfo*)text6)->ResultCode;
			}
			string text7 = defaultVillageDataPath_;
			if (text7.m_stringLength != 0)
			{
				int hashCode7 = text7.GetHashCode();
			}
			string text8 = altVillageScene_;
			if (text8.m_stringLength != 0)
			{
				int hashCode8 = text8.GetHashCode();
			}
			if (useSoftwareCursor_)
			{
			}
			if (useSteamworks_)
			{
			}
			string text9 = language_;
			if (text9.m_stringLength != 0)
			{
				int hashCode9 = text9.GetHashCode();
			}
			if (autoDetectQuality_)
			{
			}
			string text10 = graphicQuality_;
			if (text10.m_stringLength != 0)
			{
				int hashCode10 = text10.GetHashCode();
			}
			if (overrideShaderQuality_ != 0)
			{
				Result resultCode6 = ((SessionSearchFindCallbackInfo*)text10)->ResultCode;
			}
			if (overrideStreamingMipmaps_ != 0)
			{
				Result resultCode7 = ((SessionSearchFindCallbackInfo*)text10)->ResultCode;
			}
			if (overrideLodSkip_ != 0)
			{
				Result resultCode8 = ((SessionSearchFindCallbackInfo*)text10)->ResultCode;
			}
			if (runtimeAdjustableQuality_)
			{
			}
			if (screenMode_ != 0)
			{
				Result resultCode9 = ((SessionSearchFindCallbackInfo*)text10)->ResultCode;
			}
			if (streamingTextureFreeUnused_)
			{
			}
			if (lowMemoryManager_)
			{
			}
			if (debugAccountLinking_)
			{
			}
			if (disableProfileUpload_)
			{
			}
			if (forceConflictPrompt_)
			{
			}
			if (resolveConflictDelayMS_ != 0)
			{
				Result resultCode10 = ((SessionSearchFindCallbackInfo*)text10)->ResultCode;
			}
			if (forceNativeUnlink_)
			{
			}
			if (overrideSaveOnExitPolicy_ != 0)
			{
				Result resultCode11 = ((SessionSearchFindCallbackInfo*)text10)->ResultCode;
			}
			if (deleteLocalProfileOnly_)
			{
			}
			bool flag = dontRestoreRemoteSave_;
			int num = default(int);
			if (flag)
			{
				num = 0;
			}
			EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField = default(EqualityComparer<float>);
			if (flag)
			{
				_003CBitwiseSingleEqualityComparer_003Ek__BackingField = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
				int hashCode11 = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField).GetHashCode((T)num);
			}
			EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField2 = default(EqualityComparer<float>);
			if (_003CBitwiseSingleEqualityComparer_003Ek__BackingField != null)
			{
				_003CBitwiseSingleEqualityComparer_003Ek__BackingField2 = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
				int hashCode12 = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField2).GetHashCode((T)num);
			}
			if (forceProfileEncryption_)
			{
			}
			if (disableAutoSave_)
			{
			}
			if (useMinimalLogVerbosity_)
			{
			}
			if (disableSwitchCPUBoostMode_)
			{
			}
			if (disableLoadingScope_)
			{
			}
			if (forceEnableLoadingScopeForSwitch_)
			{
			}
			if (onlineAutoLogin_)
			{
			}
			if (disableGameloftTracking_)
			{
			}
			if (forceValidateSessionIntervalTimeInSec_ != 0)
			{
				DesktopCrossplayStatus status = ((GetDesktopCrossplayStatusInfo*)_003CBitwiseSingleEqualityComparer_003Ek__BackingField2)->Status;
			}
			if (useOnlineDebugConfigSettings_)
			{
			}
			string text11 = commandLineArguments_;
			if (text11.m_stringLength != 0)
			{
				int hashCode13 = text11.GetHashCode();
			}
			if (playerLogBackupMaxAmount_ != 0)
			{
				Result resultCode12 = ((SessionSearchFindCallbackInfo*)text11)->ResultCode;
			}
			if (systemTimeAddDays_ != 0)
			{
				Result resultCode13 = ((SessionSearchFindCallbackInfo*)text11)->ResultCode;
			}
			if (systemTimeAddHours_ != 0)
			{
				Result resultCode14 = ((SessionSearchFindCallbackInfo*)text11)->ResultCode;
			}
			if (systemTimeAddMinutes_ != 0)
			{
				Result resultCode15 = ((SessionSearchFindCallbackInfo*)text11)->ResultCode;
			}
			if (muteAll_)
			{
			}
			if (muteMusic_)
			{
			}
			if (muteSfx_)
			{
			}
			if (muteVO_)
			{
			}
			if (allowPortraitScreen_)
			{
			}
			if (usePortraitScreenOnly_)
			{
			}
			if (useIngameDebug_)
			{
			}
			string text12 = overridePlatform_;
			if (text12.m_stringLength != 0)
			{
				int hashCode14 = text12.GetHashCode();
			}
			if (showFPS_)
			{
			}
			if (showMipmapStreamingInfo_)
			{
			}
			if (showSystemInfo_)
			{
			}
			if (showMemoryInfo_)
			{
			}
			if (logDeviceInfo_)
			{
			}
			if (easyRead_)
			{
			}
			if (forceNoGamepad_)
			{
			}
			if (overrideGamepadControlType_ != 0)
			{
				Result resultCode16 = ((SessionSearchFindCallbackInfo*)text12)->ResultCode;
			}
			if (disableDistanceCulling_)
			{
			}
			if (forceUnityLogType_ != 0)
			{
				Result resultCode17 = ((SessionSearchFindCallbackInfo*)text12)->ResultCode;
			}
			if (disableGridObjStreaming_)
			{
			}
			if (autoBuildHouse_)
			{
			}
			if (infiniteStamina_)
			{
			}
			if (forceBacktraceOn_)
			{
			}
			if (rdpHack_)
			{
			}
			if (overridePcControls_)
			{
			}
			if (overrideControlScheme_ != 0)
			{
				Result resultCode18 = ((SessionSearchFindCallbackInfo*)text12)->ResultCode;
			}
			if (oVerrideHookedControlScheme_ != 0)
			{
				Result resultCode19 = ((SessionSearchFindCallbackInfo*)text12)->ResultCode;
			}
			if (activateS1Hack_)
			{
			}
			string text13 = overrideMarketPlaceName_;
			if (text13.m_stringLength != 0)
			{
				int hashCode15 = text13.GetHashCode();
			}
			string text14 = pSNOverrideServiceLabel_;
			if (text14.m_stringLength != 0)
			{
				int hashCode16 = text14.GetHashCode();
			}
			string text15 = pSNOverrideEnv_;
			if (text15.m_stringLength != 0)
			{
				int hashCode17 = text15.GetHashCode();
			}
			if (doFakeRedeemFromClient_)
			{
			}
			if (overridePlayfabOrigin_ != 0)
			{
				Result resultCode20 = ((SessionSearchFindCallbackInfo*)text15)->ResultCode;
			}
			if (forceSaveToPlayFabFailure_)
			{
			}
			if (nxSimulateNoInternet_)
			{
			}
			if (nxSimulateNoNSA_)
			{
			}
			if (onlineSimulateNoInternet_)
			{
			}
			if (onlineSimulatePlayFabNotLoggedIn_)
			{
			}
			if (onlineSimulatePortalNotLoggedIn_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode18 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C71")]
		[Cpp2IlInjected.Address(RVA = "0x18D57E0", Offset = "0x18D41E0", VA = "0x1818D57E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005C72")]
		[Cpp2IlInjected.Address(RVA = "0x18D5840", Offset = "0x18D4240", VA = "0x1818D5840", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_09e4
			if (resetProfileOnce_)
			{
				bool value = resetProfileOnce_;
				output.WriteBool(value);
			}
			if (resetProfile_)
			{
				bool value2 = resetProfile_;
				output.WriteBool(value2);
			}
			if (showStartMenu_)
			{
				bool value3 = showStartMenu_;
				output.WriteBool(value3);
			}
			if (profileSlot_.m_stringLength != 0)
			{
				string value4 = profileSlot_;
				output.WriteString(value4);
			}
			if (WasCreatedThisSession)
			{
				bool value5 = skipIntroSequence_;
				output.WriteBool(value5);
			}
			if (skipAllCutscenes_)
			{
				bool value6 = skipAllCutscenes_;
				output.WriteBool(value6);
			}
			if (canAlwaysSkipCutscene_)
			{
				bool value7 = canAlwaysSkipCutscene_;
				output.WriteBool(value7);
			}
			if (disableAllFtue_)
			{
				bool value8 = disableAllFtue_;
				output.WriteBool(value8);
			}
			if (backgroundLoadingThreadPriority_ != 0)
			{
			}
			if ((long)_settings != 0)
			{
				bool value9 = unlockAllTools_;
				output.WriteBool(value9);
			}
			if (forceCharactersOutside_)
			{
				bool value10 = forceCharactersOutside_;
				output.WriteBool(value10);
			}
			if (useCheats_)
			{
				bool value11 = useCheats_;
				output.WriteBool(value11);
			}
			if (useDefaultFreeCam_)
			{
				bool value12 = useDefaultFreeCam_;
				output.WriteBool(value12);
			}
			if (useMarketingCam_)
			{
				bool value13 = useMarketingCam_;
				output.WriteBool(value13);
			}
			if (showLocalizationRef_)
			{
				bool value14 = showLocalizationRef_;
				output.WriteBool(value14);
			}
			if (showLocalizationStringIds_)
			{
				bool value15 = showLocalizationStringIds_;
				output.WriteBool(value15);
			}
			if (enablePseudolocalization_)
			{
				bool value16 = enablePseudolocalization_;
				output.WriteBool(value16);
			}
			if (offline_)
			{
				bool value17 = offline_;
				output.WriteBool(value17);
			}
			if (environment_.m_stringLength != 0)
			{
				string value18 = environment_;
				output.WriteString(value18);
			}
			if (cloudFunctionMode_ != 0)
			{
			}
			if (showScheduledStarPathEvents_)
			{
				bool value19 = showScheduledStarPathEvents_;
				output.WriteBool(value19);
			}
			if (showScheduledBundlesAndStores_)
			{
				bool value20 = showScheduledBundlesAndStores_;
				output.WriteBool(value20);
			}
			if (userId_.m_stringLength != 0)
			{
				string value21 = userId_;
				output.WriteString(value21);
			}
			if (password_.m_stringLength != 0)
			{
				string value22 = password_;
				output.WriteString(value22);
			}
			if (portalIp_.m_stringLength != 0)
			{
				string value23 = portalIp_;
				output.WriteString(value23);
			}
			if (portalPort_ != 0)
			{
				int value24 = portalPort_;
				output.WriteInt32(value24);
			}
			if (cloudFunctionVersions_ != 0)
			{
				int value25 = cloudFunctionVersions_;
				output.WriteInt32(value25);
			}
			if (resetOnlineUserId_)
			{
				bool value26 = resetOnlineUserId_;
				output.WriteBool(value26);
			}
			if (playfabProfileSlot_.m_stringLength != 0)
			{
				string value27 = playfabProfileSlot_;
				output.WriteString(value27);
			}
			if (overrideStreamingConfig_ != 0)
			{
			}
			if (defaultVillageDataPath_.m_stringLength != 0)
			{
				string value28 = defaultVillageDataPath_;
				output.WriteString(value28);
			}
			if (altVillageScene_.m_stringLength != 0)
			{
				string value29 = altVillageScene_;
				output.WriteString(value29);
			}
			if (useSoftwareCursor_)
			{
				bool value30 = useSoftwareCursor_;
				output.WriteBool(value30);
			}
			if (useSteamworks_)
			{
				bool value31 = useSteamworks_;
				output.WriteBool(value31);
			}
			if (language_.m_stringLength != 0)
			{
				string value32 = language_;
				output.WriteString(value32);
			}
			if (autoDetectQuality_)
			{
				bool value33 = autoDetectQuality_;
				output.WriteBool(value33);
			}
			if (graphicQuality_.m_stringLength != 0)
			{
				string value34 = graphicQuality_;
				output.WriteString(value34);
			}
			if (overrideShaderQuality_ != 0)
			{
			}
			if (overrideStreamingMipmaps_ != 0)
			{
			}
			if (overrideLodSkip_ != 0)
			{
			}
			if (runtimeAdjustableQuality_)
			{
				bool value35 = runtimeAdjustableQuality_;
				output.WriteBool(value35);
			}
			if (screenMode_ != 0)
			{
			}
			if (streamingTextureFreeUnused_)
			{
				bool value36 = streamingTextureFreeUnused_;
				output.WriteBool(value36);
			}
			if (lowMemoryManager_)
			{
				bool value37 = lowMemoryManager_;
				output.WriteBool(value37);
			}
			if (debugAccountLinking_)
			{
				bool value38 = debugAccountLinking_;
				output.WriteBool(value38);
			}
			if (disableProfileUpload_)
			{
				bool value39 = disableProfileUpload_;
				output.WriteBool(value39);
			}
			if (forceConflictPrompt_)
			{
				bool value40 = forceConflictPrompt_;
				output.WriteBool(value40);
			}
			if (resolveConflictDelayMS_ != 0)
			{
				int value41 = resolveConflictDelayMS_;
				output.WriteInt32(value41);
			}
			if (forceNativeUnlink_)
			{
				bool value42 = forceNativeUnlink_;
				output.WriteBool(value42);
			}
			if (overrideSaveOnExitPolicy_ != 0)
			{
			}
			if (deleteLocalProfileOnly_)
			{
				bool value43 = deleteLocalProfileOnly_;
				output.WriteBool(value43);
			}
			if (dontRestoreRemoteSave_)
			{
				bool value44 = dontRestoreRemoteSave_;
				output.WriteBool(value44);
			}
			if (output != null)
			{
				float value45 = overrideUploadProfileCooldownMin_;
				output.WriteFloat(value45);
			}
			if (output != null)
			{
				float value46 = overrideShowLoginPromptCooldownSec_;
				output.WriteFloat(value46);
			}
			if (forceProfileEncryption_)
			{
				bool value47 = forceProfileEncryption_;
				output.WriteBool(value47);
			}
			if (disableAutoSave_)
			{
				bool value48 = disableAutoSave_;
				output.WriteBool(value48);
			}
			if (useMinimalLogVerbosity_)
			{
				bool value49 = useMinimalLogVerbosity_;
				output.WriteBool(value49);
			}
			if (disableSwitchCPUBoostMode_)
			{
				bool value50 = disableSwitchCPUBoostMode_;
				output.WriteBool(value50);
			}
			if (disableLoadingScope_)
			{
				bool value51 = disableLoadingScope_;
				output.WriteBool(value51);
			}
			if (forceEnableLoadingScopeForSwitch_)
			{
				bool value52 = forceEnableLoadingScopeForSwitch_;
				output.WriteBool(value52);
			}
			if (onlineAutoLogin_)
			{
				bool value53 = onlineAutoLogin_;
				output.WriteBool(value53);
			}
			if (disableGameloftTracking_)
			{
				bool value54 = disableGameloftTracking_;
				output.WriteBool(value54);
			}
			if (forceValidateSessionIntervalTimeInSec_ != 0)
			{
				int value55 = forceValidateSessionIntervalTimeInSec_;
				output.WriteInt32(value55);
			}
			if (useOnlineDebugConfigSettings_)
			{
				bool value56 = useOnlineDebugConfigSettings_;
				output.WriteBool(value56);
			}
			if (commandLineArguments_.m_stringLength != 0)
			{
				string value57 = commandLineArguments_;
				output.WriteString(value57);
			}
			if (playerLogBackupMaxAmount_ != 0)
			{
				int value58 = playerLogBackupMaxAmount_;
				output.WriteInt32(value58);
			}
			if (systemTimeAddDays_ != 0)
			{
				int value59 = systemTimeAddDays_;
				output.WriteInt32(value59);
			}
			if (systemTimeAddHours_ != 0)
			{
				int value60 = systemTimeAddHours_;
				output.WriteInt32(value60);
			}
			if (systemTimeAddMinutes_ != 0)
			{
				int value61 = systemTimeAddMinutes_;
				output.WriteInt32(value61);
			}
			if (muteAll_)
			{
				bool value62 = muteAll_;
				output.WriteBool(value62);
			}
			if (muteMusic_)
			{
				bool value63 = muteMusic_;
				output.WriteBool(value63);
			}
			if (muteSfx_)
			{
				bool value64 = muteSfx_;
				output.WriteBool(value64);
			}
			if (muteVO_)
			{
				bool value65 = muteVO_;
				output.WriteBool(value65);
			}
			if (allowPortraitScreen_)
			{
				bool value66 = allowPortraitScreen_;
				output.WriteBool(value66);
			}
			if (usePortraitScreenOnly_)
			{
				bool value67 = usePortraitScreenOnly_;
				output.WriteBool(value67);
			}
			if (useIngameDebug_)
			{
				bool value68 = useIngameDebug_;
				output.WriteBool(value68);
			}
			if (overridePlatform_.m_stringLength != 0)
			{
				string value69 = overridePlatform_;
				output.WriteString(value69);
			}
			if (showFPS_)
			{
				bool value70 = showFPS_;
				output.WriteBool(value70);
			}
			if (showMipmapStreamingInfo_)
			{
				bool value71 = showMipmapStreamingInfo_;
				output.WriteBool(value71);
			}
			if (showSystemInfo_)
			{
				bool value72 = showSystemInfo_;
				output.WriteBool(value72);
			}
			if (showMemoryInfo_)
			{
				bool value73 = showMemoryInfo_;
				output.WriteBool(value73);
			}
			if (logDeviceInfo_)
			{
				bool value74 = logDeviceInfo_;
				output.WriteBool(value74);
			}
			if (easyRead_)
			{
				bool value75 = easyRead_;
				output.WriteBool(value75);
			}
			if (forceNoGamepad_)
			{
				bool value76 = forceNoGamepad_;
				output.WriteBool(value76);
			}
			if (overrideGamepadControlType_ != 0)
			{
			}
			if (disableDistanceCulling_)
			{
				bool value77 = disableDistanceCulling_;
				output.WriteBool(value77);
			}
			if (forceUnityLogType_ != 0)
			{
			}
			if (disableGridObjStreaming_)
			{
				bool value78 = disableGridObjStreaming_;
				output.WriteBool(value78);
			}
			if (autoBuildHouse_)
			{
				bool value79 = autoBuildHouse_;
				output.WriteBool(value79);
			}
			if (infiniteStamina_)
			{
				bool value80 = infiniteStamina_;
				output.WriteBool(value80);
			}
			if (forceBacktraceOn_)
			{
				bool value81 = forceBacktraceOn_;
				output.WriteBool(value81);
			}
			if (overridePcControls_)
			{
				bool value82 = overridePcControls_;
				output.WriteBool(value82);
			}
			if (overrideControlScheme_ != 0)
			{
			}
			if (oVerrideHookedControlScheme_ != 0)
			{
			}
			if (rdpHack_)
			{
				bool value83 = rdpHack_;
				output.WriteBool(value83);
			}
			if (activateS1Hack_)
			{
				bool value84 = activateS1Hack_;
				output.WriteBool(value84);
			}
			if (overrideMarketPlaceName_.m_stringLength != 0)
			{
			}
			if (pSNOverrideServiceLabel_.m_stringLength != 0)
			{
				string value85 = pSNOverrideServiceLabel_;
				output.WriteString(value85);
			}
			if (pSNOverrideEnv_.m_stringLength != 0)
			{
				string value86 = pSNOverrideEnv_;
				output.WriteString(value86);
			}
			if (overridePlayfabOrigin_ != 0)
			{
			}
			if (doFakeRedeemFromClient_)
			{
				bool value87 = doFakeRedeemFromClient_;
				output.WriteBool(value87);
			}
			if (forceSaveToPlayFabFailure_)
			{
				bool value88 = forceSaveToPlayFabFailure_;
				output.WriteBool(value88);
			}
			if (nxSimulateNoInternet_)
			{
				bool value89 = nxSimulateNoInternet_;
				output.WriteBool(value89);
			}
			if (nxSimulateNoNSA_)
			{
				bool value90 = nxSimulateNoNSA_;
				output.WriteBool(value90);
			}
			if (onlineSimulateNoInternet_)
			{
				bool value91 = onlineSimulateNoInternet_;
				output.WriteBool(value91);
			}
			if (onlineSimulatePlayFabNotLoggedIn_)
			{
				bool value92 = onlineSimulatePlayFabNotLoggedIn_;
				output.WriteBool(value92);
			}
			if (onlineSimulatePortalNotLoggedIn_)
			{
				bool value93 = onlineSimulatePortalNotLoggedIn_;
				output.WriteBool(value93);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005C73")]
		[Cpp2IlInjected.Address(RVA = "0x18CD350", Offset = "0x18CBD50", VA = "0x1818CD350", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			string text = profileSlot_;
			if (text.m_stringLength != 0)
			{
				int num = CodedOutputStream.ComputeStringSize(text);
				num++;
			}
			MetaThreadPriority metaThreadPriority = backgroundLoadingThreadPriority_;
			if (metaThreadPriority != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)metaThreadPriority);
				num2++;
			}
			string text2 = environment_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3 += 2;
			}
			CloudFunctionMode cloudFunctionMode = cloudFunctionMode_;
			if (cloudFunctionMode != 0)
			{
				int num4 = CodedOutputStream.ComputeEnumSize((int)cloudFunctionMode);
				num4 += 2;
			}
			string text3 = userId_;
			if (text3.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text3);
				num5 += 2;
			}
			string text4 = password_;
			if (text4.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text4);
				num6 += 2;
			}
			string text5 = portalIp_;
			if (text5.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text5);
				num7 += 2;
			}
			int num8 = portalPort_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9 += 2;
			}
			int num10 = cloudFunctionVersions_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11 += 2;
			}
			string text6 = playfabProfileSlot_;
			if (text6.m_stringLength != 0)
			{
				int num12 = CodedOutputStream.ComputeStringSize(text6);
				num12 += 2;
			}
			StreamingConfigOverrideType streamingConfigOverrideType = overrideStreamingConfig_;
			if (streamingConfigOverrideType != 0)
			{
				int num13 = CodedOutputStream.ComputeEnumSize((int)streamingConfigOverrideType);
				num13 += 2;
			}
			string text7 = defaultVillageDataPath_;
			if (text7.m_stringLength != 0)
			{
				int num14 = CodedOutputStream.ComputeStringSize(text7);
				num14 += 2;
			}
			string text8 = altVillageScene_;
			if (text8.m_stringLength != 0)
			{
				int num15 = CodedOutputStream.ComputeStringSize(text8);
				num15 += 2;
			}
			string text9 = language_;
			if (text9.m_stringLength != 0)
			{
				int num16 = CodedOutputStream.ComputeStringSize(text9);
				num16 += 2;
			}
			string text10 = graphicQuality_;
			if (text10.m_stringLength != 0)
			{
				int num17 = CodedOutputStream.ComputeStringSize(text10);
				num17 += 2;
			}
			ShaderQualityEnum shaderQualityEnum = overrideShaderQuality_;
			if (shaderQualityEnum != 0)
			{
				int num18 = CodedOutputStream.ComputeEnumSize((int)shaderQualityEnum);
				num18 += 2;
			}
			StreamingMipmapsEnum streamingMipmapsEnum = overrideStreamingMipmaps_;
			if (streamingMipmapsEnum != 0)
			{
				int num19 = CodedOutputStream.ComputeEnumSize((int)streamingMipmapsEnum);
				num19 += 2;
			}
			LodSkipEnum lodSkipEnum = overrideLodSkip_;
			if (lodSkipEnum != 0)
			{
				int num20 = CodedOutputStream.ComputeEnumSize((int)lodSkipEnum);
				num20 += 2;
			}
			ScreenModeEnum screenModeEnum = screenMode_;
			if (screenModeEnum != 0)
			{
				int num21 = CodedOutputStream.ComputeEnumSize((int)screenModeEnum);
				num21 += 2;
			}
			int num22 = resolveConflictDelayMS_;
			if (num22 != 0)
			{
				int num23 = CodedOutputStream.ComputeInt32Size(num22);
				num23 += 2;
			}
			SaveOnExitPolicyType saveOnExitPolicyType = overrideSaveOnExitPolicy_;
			if (saveOnExitPolicyType != 0)
			{
				int num24 = CodedOutputStream.ComputeEnumSize((int)saveOnExitPolicyType);
				num24 += 2;
			}
			if (dontRestoreRemoteSave_)
			{
			}
			if (dontRestoreRemoteSave_)
			{
			}
			int num25 = forceValidateSessionIntervalTimeInSec_;
			if (num25 != 0)
			{
				int num26 = CodedOutputStream.ComputeInt32Size(num25);
				num26 += 2;
			}
			string text11 = commandLineArguments_;
			if (text11.m_stringLength != 0)
			{
				int num27 = CodedOutputStream.ComputeStringSize(text11);
				num27 += 2;
			}
			int num28 = playerLogBackupMaxAmount_;
			if (num28 != 0)
			{
				int num29 = CodedOutputStream.ComputeInt32Size(num28);
				num29 += 2;
			}
			int num30 = systemTimeAddDays_;
			if (num30 != 0)
			{
				int num31 = CodedOutputStream.ComputeInt32Size(num30);
				num31 += 2;
			}
			int num32 = systemTimeAddHours_;
			if (num32 != 0)
			{
				int num33 = CodedOutputStream.ComputeInt32Size(num32);
				num33 += 2;
			}
			int num34 = systemTimeAddMinutes_;
			if (num34 != 0)
			{
				int num35 = CodedOutputStream.ComputeInt32Size(num34);
				num35 += 2;
			}
			string text12 = overridePlatform_;
			if (text12.m_stringLength != 0)
			{
				int num36 = CodedOutputStream.ComputeStringSize(text12);
				num36 += 2;
			}
			ControlType controlType = overrideGamepadControlType_;
			if (controlType != 0)
			{
				int num37 = CodedOutputStream.ComputeEnumSize((int)controlType);
				num37 += 2;
			}
			UnityLogType unityLogType = forceUnityLogType_;
			if (unityLogType != 0)
			{
				int num38 = CodedOutputStream.ComputeEnumSize((int)unityLogType);
				num38 += 2;
			}
			ControlSchemeType controlSchemeType = overrideControlScheme_;
			if (controlSchemeType != 0)
			{
				int num39 = CodedOutputStream.ComputeEnumSize((int)controlSchemeType);
				num39 += 2;
			}
			ControlSchemeType controlSchemeType2 = oVerrideHookedControlScheme_;
			if (controlSchemeType2 != 0)
			{
				int num40 = CodedOutputStream.ComputeEnumSize((int)controlSchemeType2);
				num40 += 2;
			}
			string text13 = overrideMarketPlaceName_;
			if (text13.m_stringLength != 0)
			{
				int num41 = CodedOutputStream.ComputeStringSize(text13);
				num41 += 2;
			}
			string text14 = pSNOverrideServiceLabel_;
			if (text14.m_stringLength != 0)
			{
				int num42 = CodedOutputStream.ComputeStringSize(text14);
				num42 += 2;
			}
			string text15 = pSNOverrideEnv_;
			if (text15.m_stringLength != 0)
			{
				int num43 = CodedOutputStream.ComputeStringSize(text15);
				num43 += 2;
			}
			PlayfabOriginId playfabOriginId = overridePlayfabOrigin_;
			if (playfabOriginId != 0)
			{
				int num44 = CodedOutputStream.ComputeEnumSize((int)playfabOriginId);
				num44 += 2;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num45 = unknownFields.CalculateSize();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C74")]
		[Cpp2IlInjected.Address(RVA = "0x18D1910", Offset = "0x18D0310", VA = "0x1818D1910", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DebugSettings other)
		{
			//Discarded unreachable code: IL_092d
			if (other != null)
			{
				bool flag = other.resetProfileOnce_;
				if (flag)
				{
					resetProfileOnce_ = flag;
				}
				bool flag2 = other.resetProfile_;
				if (flag2)
				{
					resetProfile_ = flag2;
				}
				bool flag3 = other.showStartMenu_;
				if (flag3)
				{
					showStartMenu_ = flag3;
				}
				string text = other.profileSlot_;
				if (text.m_stringLength != 0)
				{
					ProfileSlot = text;
				}
				bool flag4 = other.skipIntroSequence_;
				if (flag4)
				{
					skipIntroSequence_ = flag4;
				}
				bool flag5 = other.skipAllCutscenes_;
				if (flag5)
				{
					skipAllCutscenes_ = flag5;
				}
				bool flag6 = other.canAlwaysSkipCutscene_;
				if (flag6)
				{
					canAlwaysSkipCutscene_ = flag6;
				}
				bool flag7 = other.disableAllFtue_;
				if (flag7)
				{
					disableAllFtue_ = flag7;
				}
				MetaThreadPriority metaThreadPriority = other.backgroundLoadingThreadPriority_;
				if (metaThreadPriority != 0)
				{
					backgroundLoadingThreadPriority_ = metaThreadPriority;
				}
				bool flag8 = other.unlockAllTools_;
				if (flag8)
				{
					unlockAllTools_ = flag8;
				}
				bool flag9 = other.forceCharactersOutside_;
				if (flag9)
				{
					forceCharactersOutside_ = flag9;
				}
				bool flag10 = other.useCheats_;
				if (flag10)
				{
					useCheats_ = flag10;
				}
				bool flag11 = other.useDefaultFreeCam_;
				if (flag11)
				{
					useDefaultFreeCam_ = flag11;
				}
				bool flag12 = other.useMarketingCam_;
				if (flag12)
				{
					useMarketingCam_ = flag12;
				}
				bool flag13 = other.showLocalizationRef_;
				if (flag13)
				{
					showLocalizationRef_ = flag13;
				}
				bool flag14 = other.showLocalizationStringIds_;
				if (flag14)
				{
					showLocalizationStringIds_ = flag14;
				}
				bool flag15 = other.enablePseudolocalization_;
				if (flag15)
				{
					enablePseudolocalization_ = flag15;
				}
				bool flag16 = other.offline_;
				if (flag16)
				{
					offline_ = flag16;
				}
				string text2 = other.environment_;
				if (text2.m_stringLength != 0)
				{
					Environment = text2;
				}
				CloudFunctionMode cloudFunctionMode = other.cloudFunctionMode_;
				if (cloudFunctionMode != 0)
				{
					cloudFunctionMode_ = cloudFunctionMode;
				}
				bool flag17 = other.showScheduledStarPathEvents_;
				if (flag17)
				{
					showScheduledStarPathEvents_ = flag17;
				}
				bool flag18 = other.showScheduledBundlesAndStores_;
				if (flag18)
				{
					showScheduledBundlesAndStores_ = flag18;
				}
				string text3 = other.userId_;
				if (text3.m_stringLength != 0)
				{
					UserId = text3;
				}
				string text4 = other.password_;
				if (text4.m_stringLength != 0)
				{
					Password = text4;
				}
				string text5 = other.portalIp_;
				if (text5.m_stringLength != 0)
				{
					PortalIp = text5;
				}
				int num = other.portalPort_;
				if (num != 0)
				{
					portalPort_ = num;
				}
				int num2 = other.cloudFunctionVersions_;
				if (num2 != 0)
				{
					cloudFunctionVersions_ = num2;
				}
				bool flag19 = other.resetOnlineUserId_;
				if (flag19)
				{
					resetOnlineUserId_ = flag19;
				}
				string text6 = other.playfabProfileSlot_;
				if (text6.m_stringLength != 0)
				{
					PlayfabProfileSlot = text6;
				}
				StreamingConfigOverrideType streamingConfigOverrideType = other.overrideStreamingConfig_;
				if (streamingConfigOverrideType != 0)
				{
					overrideStreamingConfig_ = streamingConfigOverrideType;
				}
				string text7 = other.defaultVillageDataPath_;
				if (text7.m_stringLength != 0)
				{
					DefaultVillageDataPath = text7;
				}
				string text8 = other.altVillageScene_;
				if (text8.m_stringLength != 0)
				{
					AltVillageScene = text8;
				}
				bool flag20 = other.useSoftwareCursor_;
				if (flag20)
				{
					useSoftwareCursor_ = flag20;
				}
				bool flag21 = other.useSteamworks_;
				if (flag21)
				{
					useSteamworks_ = flag21;
				}
				string text9 = other.language_;
				if (text9.m_stringLength != 0)
				{
					Language = text9;
				}
				bool flag22 = other.autoDetectQuality_;
				if (flag22)
				{
					autoDetectQuality_ = flag22;
				}
				string text10 = other.graphicQuality_;
				if (text10.m_stringLength != 0)
				{
					GraphicQuality = text10;
				}
				ShaderQualityEnum shaderQualityEnum = other.overrideShaderQuality_;
				if (shaderQualityEnum != 0)
				{
					overrideShaderQuality_ = shaderQualityEnum;
				}
				StreamingMipmapsEnum streamingMipmapsEnum = other.overrideStreamingMipmaps_;
				if (streamingMipmapsEnum != 0)
				{
					overrideStreamingMipmaps_ = streamingMipmapsEnum;
				}
				LodSkipEnum lodSkipEnum = other.overrideLodSkip_;
				if (lodSkipEnum != 0)
				{
					overrideLodSkip_ = lodSkipEnum;
				}
				bool flag23 = other.runtimeAdjustableQuality_;
				if (flag23)
				{
					runtimeAdjustableQuality_ = flag23;
				}
				ScreenModeEnum screenModeEnum = other.screenMode_;
				if (screenModeEnum != 0)
				{
					screenMode_ = screenModeEnum;
				}
				bool flag24 = other.streamingTextureFreeUnused_;
				if (flag24)
				{
					streamingTextureFreeUnused_ = flag24;
				}
				bool flag25 = other.lowMemoryManager_;
				if (flag25)
				{
					lowMemoryManager_ = flag25;
				}
				bool flag26 = other.debugAccountLinking_;
				if (flag26)
				{
					debugAccountLinking_ = flag26;
				}
				bool flag27 = other.disableProfileUpload_;
				if (flag27)
				{
					disableProfileUpload_ = flag27;
				}
				bool flag28 = other.forceConflictPrompt_;
				if (flag28)
				{
					forceConflictPrompt_ = flag28;
				}
				int num3 = other.resolveConflictDelayMS_;
				if (num3 != 0)
				{
					resolveConflictDelayMS_ = num3;
				}
				bool flag29 = other.forceNativeUnlink_;
				if (flag29)
				{
					forceNativeUnlink_ = flag29;
				}
				SaveOnExitPolicyType saveOnExitPolicyType = other.overrideSaveOnExitPolicy_;
				if (saveOnExitPolicyType != 0)
				{
					overrideSaveOnExitPolicy_ = saveOnExitPolicyType;
				}
				bool flag30 = other.deleteLocalProfileOnly_;
				if (flag30)
				{
					deleteLocalProfileOnly_ = flag30;
				}
				bool flag31 = other.dontRestoreRemoteSave_;
				if (flag31)
				{
					dontRestoreRemoteSave_ = flag31;
				}
				float num4 = other.overrideUploadProfileCooldownMin_;
				if (flag31)
				{
					overrideUploadProfileCooldownMin_ = num4;
				}
				float num5 = other.overrideShowLoginPromptCooldownSec_;
				if (flag31)
				{
					overrideShowLoginPromptCooldownSec_ = num5;
				}
				bool flag32 = other.forceProfileEncryption_;
				if (flag32)
				{
					forceProfileEncryption_ = flag32;
				}
				bool flag33 = other.disableAutoSave_;
				if (flag33)
				{
					disableAutoSave_ = flag33;
				}
				bool flag34 = other.useMinimalLogVerbosity_;
				if (flag34)
				{
					useMinimalLogVerbosity_ = flag34;
				}
				bool flag35 = other.disableSwitchCPUBoostMode_;
				if (flag35)
				{
					disableSwitchCPUBoostMode_ = flag35;
				}
				bool flag36 = other.disableLoadingScope_;
				if (flag36)
				{
					disableLoadingScope_ = flag36;
				}
				bool flag37 = other.forceEnableLoadingScopeForSwitch_;
				if (flag37)
				{
					forceEnableLoadingScopeForSwitch_ = flag37;
				}
				bool flag38 = other.onlineAutoLogin_;
				if (flag38)
				{
					onlineAutoLogin_ = flag38;
				}
				bool flag39 = other.disableGameloftTracking_;
				if (flag39)
				{
					disableGameloftTracking_ = flag39;
				}
				int num6 = other.forceValidateSessionIntervalTimeInSec_;
				if (num6 != 0)
				{
					forceValidateSessionIntervalTimeInSec_ = num6;
				}
				bool flag40 = other.useOnlineDebugConfigSettings_;
				if (flag40)
				{
					useOnlineDebugConfigSettings_ = flag40;
				}
				string text11 = other.commandLineArguments_;
				if (text11.m_stringLength != 0)
				{
					CommandLineArguments = text11;
				}
				int num7 = other.playerLogBackupMaxAmount_;
				if (num7 != 0)
				{
					playerLogBackupMaxAmount_ = num7;
				}
				int num8 = other.systemTimeAddDays_;
				if (num8 != 0)
				{
					systemTimeAddDays_ = num8;
				}
				int num9 = other.systemTimeAddHours_;
				if (num9 != 0)
				{
					systemTimeAddHours_ = num9;
				}
				int num10 = other.systemTimeAddMinutes_;
				if (num10 != 0)
				{
					systemTimeAddMinutes_ = num10;
				}
				bool flag41 = other.muteAll_;
				if (flag41)
				{
					muteAll_ = flag41;
				}
				bool flag42 = other.muteMusic_;
				if (flag42)
				{
					muteMusic_ = flag42;
				}
				bool flag43 = other.muteSfx_;
				if (flag43)
				{
					muteSfx_ = flag43;
				}
				bool flag44 = other.muteVO_;
				if (flag44)
				{
					muteVO_ = flag44;
				}
				bool flag45 = other.allowPortraitScreen_;
				if (flag45)
				{
					allowPortraitScreen_ = flag45;
				}
				bool flag46 = other.usePortraitScreenOnly_;
				if (flag46)
				{
					usePortraitScreenOnly_ = flag46;
				}
				bool flag47 = other.useIngameDebug_;
				if (flag47)
				{
					useIngameDebug_ = flag47;
				}
				string text12 = other.overridePlatform_;
				if (text12.m_stringLength != 0)
				{
					OverridePlatform = text12;
				}
				bool flag48 = other.showFPS_;
				if (flag48)
				{
					showFPS_ = flag48;
				}
				bool flag49 = other.showMipmapStreamingInfo_;
				if (flag49)
				{
					showMipmapStreamingInfo_ = flag49;
				}
				bool flag50 = other.showSystemInfo_;
				if (flag50)
				{
					showSystemInfo_ = flag50;
				}
				bool flag51 = other.showMemoryInfo_;
				if (flag51)
				{
					showMemoryInfo_ = flag51;
				}
				bool flag52 = other.logDeviceInfo_;
				if (flag52)
				{
					logDeviceInfo_ = flag52;
				}
				bool flag53 = other.easyRead_;
				if (flag53)
				{
					easyRead_ = flag53;
				}
				bool flag54 = other.forceNoGamepad_;
				if (flag54)
				{
					forceNoGamepad_ = flag54;
				}
				ControlType controlType = other.overrideGamepadControlType_;
				if (controlType != 0)
				{
					overrideGamepadControlType_ = controlType;
				}
				bool flag55 = other.disableDistanceCulling_;
				if (flag55)
				{
					disableDistanceCulling_ = flag55;
				}
				UnityLogType unityLogType = other.forceUnityLogType_;
				if (unityLogType != 0)
				{
					forceUnityLogType_ = unityLogType;
				}
				bool flag56 = other.disableGridObjStreaming_;
				if (flag56)
				{
					disableGridObjStreaming_ = flag56;
				}
				bool flag57 = other.autoBuildHouse_;
				if (flag57)
				{
					autoBuildHouse_ = flag57;
				}
				bool flag58 = other.infiniteStamina_;
				if (flag58)
				{
					infiniteStamina_ = flag58;
				}
				bool flag59 = other.forceBacktraceOn_;
				if (flag59)
				{
					forceBacktraceOn_ = flag59;
				}
				bool flag60 = other.rdpHack_;
				if (flag60)
				{
					rdpHack_ = flag60;
				}
				bool flag61 = other.overridePcControls_;
				if (flag61)
				{
					overridePcControls_ = flag61;
				}
				ControlSchemeType controlSchemeType = other.overrideControlScheme_;
				if (controlSchemeType != 0)
				{
					overrideControlScheme_ = controlSchemeType;
				}
				ControlSchemeType controlSchemeType2 = other.oVerrideHookedControlScheme_;
				if (controlSchemeType2 != 0)
				{
					oVerrideHookedControlScheme_ = controlSchemeType2;
				}
				bool flag62 = other.activateS1Hack_;
				if (flag62)
				{
					activateS1Hack_ = flag62;
				}
				string text13 = other.overrideMarketPlaceName_;
				if (text13.m_stringLength != 0)
				{
					OverrideMarketPlaceName = text13;
				}
				string text14 = other.pSNOverrideServiceLabel_;
				if (text14.m_stringLength != 0)
				{
					PSNOverrideServiceLabel = text14;
				}
				string text15 = other.pSNOverrideEnv_;
				if (text15.m_stringLength != 0)
				{
					PSNOverrideEnv = text15;
				}
				bool flag63 = other.doFakeRedeemFromClient_;
				if (flag63)
				{
					doFakeRedeemFromClient_ = flag63;
				}
				PlayfabOriginId playfabOriginId = other.overridePlayfabOrigin_;
				if (playfabOriginId != 0)
				{
					overridePlayfabOrigin_ = playfabOriginId;
				}
				bool flag64 = other.forceSaveToPlayFabFailure_;
				if (flag64)
				{
					forceSaveToPlayFabFailure_ = flag64;
				}
				bool flag65 = other.nxSimulateNoInternet_;
				if (flag65)
				{
					nxSimulateNoInternet_ = flag65;
				}
				bool flag66 = other.nxSimulateNoNSA_;
				if (flag66)
				{
					nxSimulateNoNSA_ = flag66;
				}
				bool flag67 = other.onlineSimulateNoInternet_;
				if (flag67)
				{
					onlineSimulateNoInternet_ = flag67;
				}
				bool flag68 = other.onlineSimulatePlayFabNotLoggedIn_;
				if (flag68)
				{
					onlineSimulatePlayFabNotLoggedIn_ = flag68;
				}
				bool flag69 = other.onlineSimulatePortalNotLoggedIn_;
				if (flag69)
				{
					onlineSimulatePortalNotLoggedIn_ = flag69;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C75")]
		[Cpp2IlInjected.Address(RVA = "0x18D20C0", Offset = "0x18D0AC0", VA = "0x1818D20C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0baf
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 573)
			{
				if ((int)num > 4432)
				{
					if ((int)num > 4808)
					{
						if ((int)num > 5624)
						{
							if ((int)num > 6008)
							{
								if ((int)num > 6080)
								{
									if (num == 6088)
									{
										bool flag = (onlineSimulatePlayFabNotLoggedIn_ = input.ReadBool());
									}
									if (num != 6096)
									{
										goto IL_0b98;
									}
									bool flag2 = (onlineSimulatePortalNotLoggedIn_ = input.ReadBool());
								}
								bool flag3 = default(bool);
								if (num == 6016)
								{
									flag3 = (nxSimulateNoNSA_ = input.ReadBool());
								}
								if (!flag3)
								{
									goto IL_0b98;
								}
								bool flag4 = (onlineSimulateNoInternet_ = input.ReadBool());
							}
							bool flag5 = default(bool);
							if (num == 5632)
							{
								flag5 = (doFakeRedeemFromClient_ = input.ReadBool());
							}
							bool flag6 = default(bool);
							if (flag5)
							{
								flag6 = (forceSaveToPlayFabFailure_ = input.ReadBool());
							}
							if (!flag6)
							{
								goto IL_0b98;
							}
							bool flag7 = (nxSimulateNoInternet_ = input.ReadBool());
						}
						string text6 = default(string);
						if ((int)num > 4832)
						{
							int num2 = default(int);
							if ((int)num > 5610)
							{
								string text2 = default(string);
								if (num == 5618)
								{
									text2 = (PSNOverrideEnv = input.ReadString());
								}
								if ((long)text2 != 5624)
								{
									goto IL_0b98;
								}
								num2 = (int)(overridePlayfabOrigin_ = (PlayfabOriginId)input.ReadInt32());
							}
							string text4 = default(string);
							if (num2 == 5602)
							{
								text4 = (OverrideMarketPlaceName = input.ReadString());
							}
							if ((long)text4 != 5610)
							{
								goto IL_0b98;
							}
							text6 = (PSNOverrideServiceLabel = input.ReadString());
						}
						int num3 = default(int);
						if ((long)text6 == 4816)
						{
							num3 = (int)(oVerrideHookedControlScheme_ = (ControlSchemeType)input.ReadInt32());
						}
						bool flag8 = default(bool);
						if (num3 == 4824)
						{
							flag8 = (rdpHack_ = input.ReadBool());
						}
						if (!flag8)
						{
							goto IL_0b98;
						}
						bool flag9 = (activateS1Hack_ = input.ReadBool());
					}
					bool flag14 = default(bool);
					if ((int)num > 4640)
					{
						bool flag12 = default(bool);
						if ((int)num > 4664)
						{
							int num4 = default(int);
							if ((int)num > 4680)
							{
								bool flag10 = default(bool);
								if (num == 4800)
								{
									flag10 = (overridePcControls_ = input.ReadBool());
								}
								if (!flag10)
								{
									goto IL_0b98;
								}
								num4 = (int)(overrideControlScheme_ = (ControlSchemeType)input.ReadInt32());
							}
							bool flag11 = default(bool);
							if (num4 == 4672)
							{
								flag11 = (infiniteStamina_ = input.ReadBool());
							}
							if (!flag11)
							{
								goto IL_0b98;
							}
							flag12 = (forceBacktraceOn_ = input.ReadBool());
						}
						int num5 = default(int);
						if (flag12)
						{
							num5 = (int)(forceUnityLogType_ = (UnityLogType)input.ReadInt32());
						}
						bool flag13 = default(bool);
						if (num5 == 4656)
						{
							flag13 = (disableGridObjStreaming_ = input.ReadBool());
						}
						if (!flag13)
						{
							goto IL_0b98;
						}
						flag14 = (autoBuildHouse_ = input.ReadBool());
					}
					bool flag16 = default(bool);
					if ((flag14 ? 1 : 0) > (false ? 1 : 0))
					{
						bool flag15 = default(bool);
						if (flag14)
						{
							flag15 = (forceNoGamepad_ = input.ReadBool());
						}
						int num6 = default(int);
						if (flag15)
						{
							num6 = (int)(overrideGamepadControlType_ = (ControlType)input.ReadInt32());
						}
						if (num6 != 4640)
						{
							goto IL_0b98;
						}
						flag16 = (disableDistanceCulling_ = input.ReadBool());
					}
					bool flag17 = default(bool);
					if (flag16)
					{
						flag17 = (showMemoryInfo_ = input.ReadBool());
					}
					bool flag18 = default(bool);
					if (flag17)
					{
						flag18 = (logDeviceInfo_ = input.ReadBool());
					}
					if (flag18)
					{
						goto IL_0b98;
					}
					bool flag19 = (easyRead_ = input.ReadBool());
				}
				int num9 = default(int);
				if ((int)num > 2408)
				{
					bool flag25 = default(bool);
					if ((int)num > 3224)
					{
						bool flag22 = default(bool);
						if ((int)num > 4400)
						{
							bool flag21 = default(bool);
							if ((int)num > 4416)
							{
								bool flag20 = default(bool);
								if (num == 4424)
								{
									flag20 = (showMipmapStreamingInfo_ = input.ReadBool());
								}
								if (!flag20)
								{
									goto IL_0b98;
								}
								flag21 = (showSystemInfo_ = input.ReadBool());
							}
							string text8 = default(string);
							if (flag21)
							{
								text8 = (OverridePlatform = input.ReadString());
							}
							if ((long)text8 != 4416)
							{
								goto IL_0b98;
							}
							flag22 = (showFPS_ = input.ReadBool());
						}
						bool flag23 = default(bool);
						if (flag22)
						{
							flag23 = (allowPortraitScreen_ = input.ReadBool());
						}
						bool flag24 = default(bool);
						if (flag23)
						{
							flag24 = (usePortraitScreenOnly_ = input.ReadBool());
						}
						if (!flag24)
						{
							goto IL_0b98;
						}
						flag25 = (useIngameDebug_ = input.ReadBool());
					}
					bool flag29 = default(bool);
					if ((flag25 ? 1 : 0) > (true ? 1 : 0))
					{
						bool flag27 = default(bool);
						if ((flag25 ? 1 : 0) > (true ? 1 : 0))
						{
							bool flag26 = default(bool);
							if (flag25)
							{
								flag26 = (muteSfx_ = input.ReadBool());
							}
							if (!flag26)
							{
								goto IL_0b98;
							}
							flag27 = (muteVO_ = input.ReadBool());
						}
						bool flag28 = default(bool);
						if (flag27)
						{
							flag28 = (muteAll_ = input.ReadBool());
						}
						if (!flag28)
						{
							goto IL_0b98;
						}
						flag29 = (muteMusic_ = input.ReadBool());
					}
					int num7 = default(int);
					if (!flag29)
					{
						num7 = (systemTimeAddDays_ = input.ReadInt32());
					}
					int num8 = default(int);
					if (num7 == 2568)
					{
						num8 = (systemTimeAddHours_ = input.ReadInt32());
					}
					if (num8 != 2576)
					{
						goto IL_0b98;
					}
					num9 = (systemTimeAddMinutes_ = input.ReadInt32());
				}
				bool flag33 = default(bool);
				if (num9 > 856)
				{
					bool flag30 = default(bool);
					if (num9 > 880)
					{
						int num10 = default(int);
						if (num9 > 896)
						{
							string text10 = default(string);
							if (num9 == 2402)
							{
								text10 = (CommandLineArguments = input.ReadString());
							}
							if ((long)text10 != 2408)
							{
								goto IL_0b98;
							}
							num10 = (playerLogBackupMaxAmount_ = input.ReadInt32());
						}
						int num11 = default(int);
						if (num10 == 888)
						{
							num11 = (forceValidateSessionIntervalTimeInSec_ = input.ReadInt32());
						}
						if (num11 != 896)
						{
							goto IL_0b98;
						}
						flag30 = (useOnlineDebugConfigSettings_ = input.ReadBool());
					}
					bool flag31 = default(bool);
					if (flag30)
					{
						flag31 = (forceEnableLoadingScopeForSwitch_ = input.ReadBool());
					}
					bool flag32 = default(bool);
					if (flag31)
					{
						flag32 = (onlineAutoLogin_ = input.ReadBool());
					}
					if (!flag32)
					{
						goto IL_0b98;
					}
					flag33 = (disableGameloftTracking_ = input.ReadBool());
				}
				bool flag36 = default(bool);
				if ((flag33 ? 1 : 0) > (true ? 1 : 0))
				{
					bool flag34 = default(bool);
					if (flag33)
					{
						flag34 = (useMinimalLogVerbosity_ = input.ReadBool());
					}
					bool flag35 = default(bool);
					if (flag34)
					{
						flag35 = (disableSwitchCPUBoostMode_ = input.ReadBool());
					}
					if (!flag35)
					{
						goto IL_0b98;
					}
					flag36 = (disableLoadingScope_ = input.ReadBool());
				}
				if (flag36)
				{
					float num12 = (overrideShowLoginPromptCooldownSec_ = input.ReadFloat());
				}
				bool flag37 = default(bool);
				if (flag36)
				{
					flag37 = (forceProfileEncryption_ = input.ReadBool());
				}
				if (!flag37)
				{
					goto IL_0b98;
				}
				bool flag38 = (disableAutoSave_ = input.ReadBool());
			}
			string text20 = default(string);
			if ((int)num > 248)
			{
				int num17 = default(int);
				if ((int)num > 384)
				{
					bool flag42 = default(bool);
					if ((int)num > 488)
					{
						bool flag40 = default(bool);
						if ((int)num > 536)
						{
							bool flag39 = default(bool);
							if ((int)num > 552)
							{
								if (num == 560)
								{
									flag39 = (dontRestoreRemoteSave_ = input.ReadBool());
								}
								if (!flag39)
								{
									goto IL_0b98;
								}
								float num13 = (overrideUploadProfileCooldownMin_ = input.ReadFloat());
							}
							int num14 = default(int);
							if (flag39)
							{
								num14 = (int)(overrideSaveOnExitPolicy_ = (SaveOnExitPolicyType)input.ReadInt32());
							}
							if (num14 != 552)
							{
								goto IL_0b98;
							}
							flag40 = (deleteLocalProfileOnly_ = input.ReadBool());
						}
						bool flag41 = default(bool);
						if (flag40)
						{
							flag41 = (forceConflictPrompt_ = input.ReadBool());
						}
						int num15 = default(int);
						if (flag41)
						{
							num15 = (resolveConflictDelayMS_ = input.ReadInt32());
						}
						if (num15 != 536)
						{
							goto IL_0b98;
						}
						flag42 = (forceNativeUnlink_ = input.ReadBool());
					}
					bool flag46 = default(bool);
					if ((flag42 ? 1 : 0) > (true ? 1 : 0))
					{
						bool flag44 = default(bool);
						if ((flag42 ? 1 : 0) > (true ? 1 : 0))
						{
							bool flag43 = default(bool);
							if (flag42)
							{
								flag43 = (debugAccountLinking_ = input.ReadBool());
							}
							if (!flag43)
							{
								goto IL_0b98;
							}
							flag44 = (disableProfileUpload_ = input.ReadBool());
						}
						bool flag45 = default(bool);
						if (flag44)
						{
							flag45 = (streamingTextureFreeUnused_ = input.ReadBool());
						}
						if (!flag45)
						{
							goto IL_0b98;
						}
						flag46 = (lowMemoryManager_ = input.ReadBool());
					}
					int num16 = default(int);
					if (flag46)
					{
						num16 = (int)(overrideLodSkip_ = (LodSkipEnum)input.ReadInt32());
					}
					bool flag47 = default(bool);
					if (num16 == 400)
					{
						flag47 = (runtimeAdjustableQuality_ = input.ReadBool());
					}
					if (!flag47)
					{
						goto IL_0b98;
					}
					num17 = (int)(screenMode_ = (ScreenModeEnum)input.ReadInt32());
				}
				string text14 = default(string);
				if (num17 > 330)
				{
					string text12 = default(string);
					if (num17 > 354)
					{
						int num19 = default(int);
						if (num17 > 370)
						{
							int num18 = default(int);
							if (num17 == 376)
							{
								num18 = (int)(overrideShaderQuality_ = (ShaderQualityEnum)input.ReadInt32());
							}
							if (num18 != 384)
							{
								goto IL_0b98;
							}
							num19 = (int)(overrideStreamingMipmaps_ = (StreamingMipmapsEnum)input.ReadInt32());
						}
						bool flag48 = default(bool);
						if (num19 == 360)
						{
							flag48 = (autoDetectQuality_ = input.ReadBool());
						}
						if (!flag48)
						{
							goto IL_0b98;
						}
						text12 = (GraphicQuality = input.ReadString());
					}
					bool flag49 = default(bool);
					if ((long)text12 == 336)
					{
						flag49 = (useSoftwareCursor_ = input.ReadBool());
					}
					bool flag50 = default(bool);
					if (flag49)
					{
						flag50 = (useSteamworks_ = input.ReadBool());
					}
					if (!flag50)
					{
						goto IL_0b98;
					}
					text14 = (Language = input.ReadString());
				}
				string text18 = default(string);
				if ((long)text14 > 290)
				{
					int num20 = default(int);
					if ((long)text14 == 296)
					{
						num20 = (int)(overrideStreamingConfig_ = (StreamingConfigOverrideType)input.ReadInt32());
					}
					string text16 = default(string);
					if (num20 == 322)
					{
						text16 = (DefaultVillageDataPath = input.ReadString());
					}
					if ((long)text16 != 330)
					{
						goto IL_0b98;
					}
					text18 = (AltVillageScene = input.ReadString());
				}
				int num21 = default(int);
				if ((long)text18 == 256)
				{
					num21 = (cloudFunctionVersions_ = input.ReadInt32());
				}
				bool flag51 = default(bool);
				if (num21 == 280)
				{
					flag51 = (resetOnlineUserId_ = input.ReadBool());
				}
				if (!flag51)
				{
					goto IL_0b98;
				}
				text20 = (PlayfabProfileSlot = input.ReadString());
			}
			bool flag58 = default(bool);
			if ((long)text20 > 104)
			{
				bool flag53 = default(bool);
				if ((long)text20 > 170)
				{
					string text26 = default(string);
					if ((long)text20 > 192)
					{
						int num22 = default(int);
						if ((long)text20 > 210)
						{
							string text22 = default(string);
							if ((long)text20 == 242)
							{
								text22 = (PortalIp = input.ReadString());
							}
							if ((long)text22 != 248)
							{
								goto IL_0b98;
							}
							num22 = (portalPort_ = input.ReadInt32());
						}
						string text24 = default(string);
						if (num22 == 202)
						{
							text24 = (UserId = input.ReadString());
						}
						if ((long)text24 != 210)
						{
							goto IL_0b98;
						}
						text26 = (Password = input.ReadString());
					}
					int num23 = default(int);
					if ((long)text26 == 176)
					{
						num23 = (int)(cloudFunctionMode_ = (CloudFunctionMode)input.ReadInt32());
					}
					bool flag52 = default(bool);
					if (num23 == 184)
					{
						flag52 = (showScheduledStarPathEvents_ = input.ReadBool());
					}
					if (!flag52)
					{
						goto IL_0b98;
					}
					flag53 = (showScheduledBundlesAndStores_ = input.ReadBool());
				}
				string text28 = default(string);
				if ((flag53 ? 1 : 0) > (true ? 1 : 0))
				{
					bool flag54 = default(bool);
					if (flag53)
					{
						flag54 = (enablePseudolocalization_ = input.ReadBool());
					}
					bool flag55 = default(bool);
					if (flag54)
					{
						flag55 = (offline_ = input.ReadBool());
					}
					if (!flag55)
					{
						goto IL_0b98;
					}
					text28 = (Environment = input.ReadString());
				}
				bool flag56 = default(bool);
				if ((long)text28 == 112)
				{
					flag56 = (useMarketingCam_ = input.ReadBool());
				}
				bool flag57 = default(bool);
				if (flag56)
				{
					flag57 = (showLocalizationRef_ = input.ReadBool());
				}
				if (!flag57)
				{
					goto IL_0b98;
				}
				flag58 = (showLocalizationStringIds_ = input.ReadBool());
			}
			int num24 = default(int);
			if ((flag58 ? 1 : 0) > (true ? 1 : 0))
			{
				bool flag62 = default(bool);
				if ((flag58 ? 1 : 0) > (true ? 1 : 0))
				{
					bool flag60 = default(bool);
					if ((flag58 ? 1 : 0) > (true ? 1 : 0))
					{
						bool flag59 = default(bool);
						if (flag58)
						{
							flag59 = (useCheats_ = input.ReadBool());
						}
						if (!flag59)
						{
							goto IL_0b98;
						}
						flag60 = (useDefaultFreeCam_ = input.ReadBool());
					}
					bool flag61 = default(bool);
					if (flag60)
					{
						flag61 = (unlockAllTools_ = input.ReadBool());
					}
					if (!flag61)
					{
						goto IL_0b98;
					}
					flag62 = (forceCharactersOutside_ = input.ReadBool());
				}
				bool flag63 = default(bool);
				if (flag62)
				{
					flag63 = (canAlwaysSkipCutscene_ = input.ReadBool());
				}
				bool flag64 = default(bool);
				if (flag63)
				{
					flag64 = (disableAllFtue_ = input.ReadBool());
				}
				if (!flag64)
				{
					goto IL_0b98;
				}
				num24 = (int)(backgroundLoadingThreadPriority_ = (MetaThreadPriority)input.ReadInt32());
			}
			bool flag66 = default(bool);
			if (num24 > 24)
			{
				string text30 = default(string);
				if (num24 == 34)
				{
					text30 = (ProfileSlot = input.ReadString());
				}
				bool flag65 = default(bool);
				if ((long)text30 == 40)
				{
					flag65 = (skipIntroSequence_ = input.ReadBool());
				}
				if (!flag65)
				{
					goto IL_0b98;
				}
				flag66 = (skipAllCutscenes_ = input.ReadBool());
			}
			bool flag67 = default(bool);
			if (flag66)
			{
				flag67 = (resetProfileOnce_ = input.ReadBool());
			}
			bool flag68 = default(bool);
			if (flag67)
			{
				flag68 = (resetProfile_ = input.ReadBool());
			}
			if (flag68)
			{
				bool flag69 = (showStartMenu_ = input.ReadBool());
			}
			goto IL_0b98;
			IL_0b98:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005C76")]
		[Cpp2IlInjected.Address(RVA = "0x18CF450", Offset = "0x18CDE50", VA = "0x1818CF450", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber > 500)
			{
				if (fieldNumber > 585)
				{
					if (fieldNumber > 704 && (object)typeof(UnityLogType).TypeHandle != null && (object)typeof(UnityLogType).TypeHandle != null && (long)typeof(UnityLogType).TypeHandle != 1 && (long)typeof(UnityLogType).TypeHandle != 1 && (long)typeof(UnityLogType).TypeHandle != 1 && fieldNumber != 1)
					{
						goto IL_017b;
					}
					if ((object)typeof(UnityLogType).TypeHandle != null)
					{
						if ((object)typeof(UnityLogType).TypeHandle != null)
						{
							if ((object)typeof(UnityLogType).TypeHandle != null && (object)typeof(UnityLogType).TypeHandle != null && (long)typeof(UnityLogType).TypeHandle != 1)
							{
								if ((long)typeof(UnityLogType).TypeHandle != 1)
								{
									if ((long)typeof(UnityLogType).TypeHandle != 1)
									{
										if ((long)typeof(UnityLogType).TypeHandle != 1)
										{
											if ((long)typeof(UnityLogType).TypeHandle != 1 && fieldNumber != 1)
											{
												goto IL_017b;
											}
											PlayfabOriginId playfabOriginId = overridePlayfabOrigin_;
										}
										string text = pSNOverrideEnv_;
									}
									string text2 = pSNOverrideServiceLabel_;
								}
								string text3 = overrideMarketPlaceName_;
							}
							ControlSchemeType controlSchemeType = oVerrideHookedControlScheme_;
						}
						ControlSchemeType controlSchemeType2 = overrideControlScheme_;
					}
				}
				if (fieldNumber == 501)
				{
				}
				if ((long)typeof(UnityLogType).TypeHandle <= 6)
				{
					string text4 = overridePlatform_;
				}
				if (fieldNumber > 9)
				{
					goto IL_017b;
				}
				ControlType controlType = overrideGamepadControlType_;
			}
			if (fieldNumber > 301)
			{
				if ((object)typeof(UnityLogType).TypeHandle != null)
				{
					if ((object)typeof(UnityLogType).TypeHandle != null)
					{
						if ((long)typeof(UnityLogType).TypeHandle != 1 && (object)typeof(UnityLogType).TypeHandle != null && (object)typeof(UnityLogType).TypeHandle != null && (object)typeof(UnityLogType).TypeHandle != null && (long)typeof(UnityLogType).TypeHandle != 1 && fieldNumber != 500)
						{
							goto IL_017b;
						}
						int num = systemTimeAddMinutes_;
					}
					int num2 = systemTimeAddHours_;
				}
				int num3 = systemTimeAddDays_;
			}
			if (fieldNumber - 1 <= 111)
			{
				bool flag = resetProfileOnce_;
			}
			goto IL_017b;
			IL_017b:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C77")]
		[Cpp2IlInjected.Address(RVA = "0x18D3610", Offset = "0x18D2010", VA = "0x1818D3610", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0148, IL_0149, IL_0159, IL_0161, IL_0169, IL_0171, IL_0179, IL_0181, IL_0189, IL_0191, IL_0199, IL_01a1, IL_01a9, IL_01b1, IL_01b9, IL_01c1, IL_026c, IL_0275, IL_027e, IL_027f, IL_028f, IL_0297, IL_029f, IL_02a7, IL_02af, IL_02b7, IL_02bf, IL_02c7, IL_02cf, IL_02d7, IL_02df, IL_02e7, IL_02ef, IL_02f7, IL_02ff, IL_0300, IL_0310, IL_0318, IL_0320, IL_0328, IL_0329, IL_032a, IL_032b, IL_033b, IL_0343, IL_034b
			//IL_0057: Expected I4, but got O
			//IL_005f: Expected I4, but got O
			//IL_0067: Expected I4, but got O
			//IL_006f: Expected I4, but got O
			//IL_0078: Expected I4, but got O
			//IL_0081: Expected I4, but got O
			//IL_00e9: Expected I4, but got O
			//IL_00f2: Expected I4, but got O
			//IL_013e: Expected I4, but got O
			//IL_0147: Expected I4, but got O
			//IL_0223: Expected I4, but got O
			//IL_022c: Expected I4, but got O
			//IL_0235: Expected I4, but got O
			//IL_023e: Expected I4, but got O
			//IL_0247: Expected I4, but got O
			//IL_0250: Expected I4, but got O
			//IL_0259: Expected I4, but got O
			//IL_0262: Expected I4, but got O
			//IL_026b: Expected I4, but got O
			//IL_0274: Expected I4, but got O
			//IL_027d: Expected I4, but got O
			object obj = default(object);
			object obj2 = default(object);
			object obj3 = default(object);
			object obj4 = default(object);
			object obj5 = default(object);
			object obj6 = default(object);
			object obj7 = default(object);
			object obj8 = default(object);
			object obj9 = default(object);
			object obj10 = default(object);
			while (fieldNumber > 500)
			{
				if (fieldNumber > 585)
				{
					if (fieldNumber > 704)
					{
						if ((object)typeof(UnityLogType).TypeHandle != null)
						{
							if ((object)typeof(UnityLogType).TypeHandle != null)
							{
								if ((long)typeof(UnityLogType).TypeHandle != 1)
								{
									if ((long)typeof(UnityLogType).TypeHandle != 1)
									{
										if ((long)typeof(UnityLogType).TypeHandle != 1)
										{
											if (fieldNumber == 1)
											{
												onlineSimulatePortalNotLoggedIn_ = (byte)(int)obj != 0;
											}
										}
										else
										{
											onlineSimulatePlayFabNotLoggedIn_ = (byte)(int)obj2 != 0;
										}
									}
									else
									{
										onlineSimulateNoInternet_ = (byte)(int)obj3 != 0;
									}
								}
								else
								{
									nxSimulateNoNSA_ = (byte)(int)obj4 != 0;
								}
							}
							else
							{
								nxSimulateNoInternet_ = (byte)(int)obj5 != 0;
							}
						}
						else
						{
							forceSaveToPlayFabFailure_ = (byte)(int)obj6 != 0;
						}
						return;
					}
					if ((object)typeof(UnityLogType).TypeHandle != null)
					{
						if ((object)typeof(UnityLogType).TypeHandle != null)
						{
							if ((object)typeof(UnityLogType).TypeHandle != null)
							{
								if ((object)typeof(UnityLogType).TypeHandle != null)
								{
									if ((long)typeof(UnityLogType).TypeHandle != 1)
									{
										if ((long)typeof(UnityLogType).TypeHandle == 1 || (long)typeof(UnityLogType).TypeHandle == 1 || (long)typeof(UnityLogType).TypeHandle == 1)
										{
											return;
										}
										if ((long)typeof(UnityLogType).TypeHandle != 1)
										{
											while (fieldNumber != 1)
											{
											}
											doFakeRedeemFromClient_ = (byte)(int)obj7 != 0;
										}
										else
										{
											overridePlayfabOrigin_ = (PlayfabOriginId)obj8;
										}
										return;
									}
									if ((object)environment_ == (object)typeof(string).TypeHandle)
									{
										activateS1Hack_ = false;
										return;
									}
									continue;
								}
								rdpHack_ = false;
								return;
							}
							oVerrideHookedControlScheme_ = ControlSchemeType.Vpad;
							return;
						}
						overrideControlScheme_ = ControlSchemeType.Vpad;
						return;
					}
					overridePcControls_ = false;
					return;
				}
				if (fieldNumber == 501)
				{
					usePortraitScreenOnly_ = (byte)(int)obj9 != 0;
				}
				else
				{
					useIngameDebug_ = (byte)(int)obj10 != 0;
				}
				return;
			}
			if (fieldNumber > 301)
			{
				if ((object)typeof(UnityLogType).TypeHandle != null)
				{
					if ((object)typeof(UnityLogType).TypeHandle != null)
					{
						if ((long)typeof(UnityLogType).TypeHandle != 1)
						{
							if ((object)typeof(UnityLogType).TypeHandle != null)
							{
								if ((object)typeof(UnityLogType).TypeHandle != null)
								{
									if ((object)typeof(UnityLogType).TypeHandle != null)
									{
										if ((long)typeof(UnityLogType).TypeHandle != 1)
										{
											while (fieldNumber != 500)
											{
											}
											object obj11 = default(object);
											allowPortraitScreen_ = (byte)(int)obj11 != 0;
										}
										else
										{
											object obj12 = default(object);
											muteVO_ = (byte)(int)obj12 != 0;
										}
									}
									else
									{
										object obj13 = default(object);
										muteSfx_ = (byte)(int)obj13 != 0;
									}
								}
								else
								{
									object obj14 = default(object);
									muteMusic_ = (byte)(int)obj14 != 0;
								}
							}
							else
							{
								object obj15 = default(object);
								muteAll_ = (byte)(int)obj15 != 0;
							}
						}
						else
						{
							object obj16 = default(object);
							systemTimeAddMinutes_ = (int)obj16;
						}
					}
					else
					{
						object obj17 = default(object);
						systemTimeAddHours_ = (int)obj17;
					}
				}
				else
				{
					object obj18 = default(object);
					systemTimeAddDays_ = (int)obj18;
				}
			}
			else
			{
				object obj19 = default(object);
				resetProfileOnce_ = (byte)(int)obj19 != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C78")]
		[Cpp2IlInjected.Address(RVA = "0x18CDF60", Offset = "0x18CC960", VA = "0x1818CDF60", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_016c, IL_016d, IL_016e, IL_016f, IL_0170, IL_0171, IL_017b, IL_017c, IL_017d, IL_017e, IL_017f, IL_0180, IL_0181, IL_0182, IL_01e6, IL_01e7, IL_01e8, IL_01e9, IL_01ea, IL_01eb, IL_01ec, IL_01ed, IL_01ee, IL_01ef, IL_01f0, IL_01f1, IL_01f2, IL_01f3, IL_01f4, IL_01f5, IL_01f6, IL_01f7, IL_01f8, IL_01f9, IL_01fa, IL_01fb, IL_01fc, IL_01fd, IL_01fe, IL_01ff, IL_0200, IL_0201, IL_0202, IL_0203, IL_0204, IL_0205, IL_0206, IL_0207, IL_0208, IL_0209, IL_020a, IL_020b, IL_020c, IL_020d, IL_020e, IL_020f, IL_0210, IL_0211, IL_0212, IL_0213, IL_0214, IL_0215, IL_0216, IL_0217, IL_0218, IL_0219, IL_021a, IL_021b, IL_021c, IL_021d, IL_021e, IL_021f, IL_0220, IL_0221, IL_0222, IL_0223, IL_0224
			//IL_00f9: Expected I4, but got I8
			//IL_0137: Expected I4, but got I8
			//IL_0141: Expected I4, but got I8
			if (fieldNumber > 500)
			{
				if (fieldNumber > 585)
				{
					if (fieldNumber > 704)
					{
						if ("" != null)
						{
							if ("" != null)
							{
								if ((long)"" != 1)
								{
									if ((long)"" != 1)
									{
										if ((long)"" != 1)
										{
											if (fieldNumber == 1)
											{
												onlineSimulatePortalNotLoggedIn_ = false;
											}
										}
										else
										{
											onlineSimulatePlayFabNotLoggedIn_ = false;
										}
									}
									else
									{
										onlineSimulateNoInternet_ = false;
									}
								}
								else
								{
									nxSimulateNoNSA_ = false;
								}
							}
							else
							{
								nxSimulateNoInternet_ = false;
							}
						}
						else
						{
							forceSaveToPlayFabFailure_ = false;
						}
					}
					else if ("" != null)
					{
						if ("" != null)
						{
							if ("" != null)
							{
								if ("" != null)
								{
									if ((long)"" != 1)
									{
										if ((long)"" != 1)
										{
											if ((long)"" != 1)
											{
												if ((long)"" != 1)
												{
													if ((long)"" != 1)
													{
														if (fieldNumber == 1)
														{
															doFakeRedeemFromClient_ = false;
														}
													}
													else
													{
														overridePlayfabOrigin_ = PlayfabOriginId.Unknown;
													}
												}
												else
												{
													PSNOverrideEnv = "";
												}
											}
											else
											{
												PSNOverrideServiceLabel = "";
											}
										}
										else
										{
											OverrideMarketPlaceName = "";
										}
									}
									else
									{
										activateS1Hack_ = false;
									}
								}
								else
								{
									rdpHack_ = false;
								}
							}
							else
							{
								oVerrideHookedControlScheme_ = ControlSchemeType.Vpad;
							}
						}
						else
						{
							overrideControlScheme_ = ControlSchemeType.Vpad;
						}
					}
					else
					{
						overridePcControls_ = false;
					}
				}
				else if (fieldNumber == 501)
				{
					usePortraitScreenOnly_ = false;
				}
				else if ((long)"" <= 6)
				{
					useIngameDebug_ = false;
				}
				else if (fieldNumber > 9)
				{
				}
			}
			else if (fieldNumber > 301)
			{
				if ("" != null && "" != null && (long)"" != 1 && "" != null && "" != null && "" != null && (long)"" != 1 && fieldNumber == 500)
				{
					allowPortraitScreen_ = false;
				}
			}
			else
			{
				switch (fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C7F")]
		[Cpp2IlInjected.Address(RVA = "0x18D1380", Offset = "0x18CFD80", VA = "0x1818D1380")]
		private static void Load()
		{
			//Discarded unreachable code: IL_005f
			IFileSystem _003CSaveGlobal_003Ek__BackingField = Definitions.Util.FileSystem.SaveGlobal;
			if ((object)typeof(DebugSettings).TypeHandle != null)
			{
				IFileSystem _003CSaveGlobal_003Ek__BackingField2 = Definitions.Util.FileSystem.SaveGlobal;
				string debugSettingsFile = DebugSettingsFile;
				_parser = (MessageParser<DebugSettings>)(object)ProtoParser.Parse<DebugSettings>(_003CSaveGlobal_003Ek__BackingField2.ReadAllBytes(debugSettingsFile));
			}
			IFileSystem _003CData_003Ek__BackingField = Definitions.Util.FileSystem.Data;
			string defaultDebugSettingsPath = DefaultDebugSettingsPath;
			_parser = (MessageParser<DebugSettings>)(object)ProtoParser.Parse<DebugSettings>(_003CData_003Ek__BackingField.ReadAllBytes(defaultDebugSettingsPath));
			_parser = (MessageParser<DebugSettings>)(object)new DebugSettingsDispatcher();
			_dispatcher.RaiseOnLoad();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C80")]
		[Cpp2IlInjected.Address(RVA = "0x18D1200", Offset = "0x18CFC00", VA = "0x1818D1200")]
		public static void LoadFromDefaultSettings()
		{
			IFileSystem _003CData_003Ek__BackingField = Definitions.Util.FileSystem.Data;
			string defaultDebugSettingsPath = DefaultDebugSettingsPath;
			_parser = (MessageParser<DebugSettings>)(object)ProtoParser.Parse<DebugSettings>(_003CData_003Ek__BackingField.ReadAllBytes(defaultDebugSettingsPath));
		}

		[Cpp2IlInjected.Token(Token = "0x6005C81")]
		[Cpp2IlInjected.Address(RVA = "0x18D2FA0", Offset = "0x18D19A0", VA = "0x1818D2FA0")]
		public static DebugSettings PrepareDebugSettings()
		{
			//Discarded unreachable code: IL_0077
			int num = 0;
			DebugSettings settings = Settings;
			if (settings != null)
			{
				int num2 = 0;
				DebugSettings debugSettings = new DebugSettings(Settings);
				debugSettings.resetProfileOnce_ = false;
				debugSettings.forceCharactersOutside_ = false;
				string text = (debugSettings.profileSlot_ = ProtoPreconditions.CheckNotNull("", "value"));
				debugSettings.resetOnlineUserId_ = false;
				string text2 = (debugSettings.playfabProfileSlot_ = ProtoPreconditions.CheckNotNull("", "value"));
				debugSettings.systemTimeAddMinutes_ = (debugSettings.systemTimeAddDays_ = 0);
				return debugSettings;
			}
			return settings;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C82")]
		[Cpp2IlInjected.Address(RVA = "0x18D31B0", Offset = "0x18D1BB0", VA = "0x1818D31B0")]
		public static void Save()
		{
			//Discarded unreachable code: IL_00a3
			//IL_0095: Expected I4, but got I8
			//IL_0095: Expected O, but got I4
			int num = 0;
			if (Settings != null)
			{
				int num2 = 0;
				DebugSettings debugSettings = new DebugSettings(Settings);
				debugSettings.resetProfileOnce_ = false;
				debugSettings.forceCharactersOutside_ = false;
				string text = (debugSettings.profileSlot_ = ProtoPreconditions.CheckNotNull("", "value"));
				debugSettings.resetOnlineUserId_ = false;
				string text2 = (debugSettings.playfabProfileSlot_ = ProtoPreconditions.CheckNotNull("", "value"));
				debugSettings.systemTimeAddMinutes_ = (debugSettings.systemTimeAddDays_ = 0);
			}
			int num3 = 0;
			if (num3 != 0)
			{
				IFileSystem _003CSaveGlobal_003Ek__BackingField = Definitions.Util.FileSystem.SaveGlobal;
				string debugSettingsFile = DebugSettingsFile;
				int formatEnumAsIntegers = 0;
				ulong num4 = default(ulong);
				string text3 = ((IMessage)num3).ToJSONString(formatDefaultValues: true, indented: true, (byte)formatEnumAsIntegers != 0, (int)num4);
				_003CSaveGlobal_003Ek__BackingField.WriteAllText(debugSettingsFile, text3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C83")]
		[Cpp2IlInjected.Address(RVA = "0x18D34D0", Offset = "0x18D1ED0", VA = "0x1818D34D0")]
		public static void Save(DebugSettings debugSettings)
		{
			//IL_001e: Expected I4, but got I8
			if (debugSettings != null)
			{
				IFileSystem _003CSaveGlobal_003Ek__BackingField = Definitions.Util.FileSystem.SaveGlobal;
				string debugSettingsFile = DebugSettingsFile;
				int formatEnumAsIntegers = 0;
				ulong num = default(ulong);
				string text = debugSettings.ToJSONString(formatDefaultValues: true, indented: true, (byte)formatEnumAsIntegers != 0, (int)num);
				_003CSaveGlobal_003Ek__BackingField.WriteAllText(debugSettingsFile, text);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C84")]
		[Cpp2IlInjected.Address(RVA = "0x18D3160", Offset = "0x18D1B60", VA = "0x1818D3160")]
		public static void Reload()
		{
			int num = 0;
			Load();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C85")]
		[Cpp2IlInjected.Address(RVA = "0x18D1140", Offset = "0x18CFB40", VA = "0x1818D1140")]
		public static bool IsForceOn()
		{
			IFileSystem _003CSaveGlobal_003Ek__BackingField = Definitions.Util.FileSystem.SaveGlobal;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C86")]
		[Cpp2IlInjected.Address(RVA = "0x18D0D00", Offset = "0x18CF700", VA = "0x1818D0D00")]
		public static List<string> GetProfileSlotChoices(bool isAndroid)
		{
			//Discarded unreachable code: IL_00be
			List<string> list = (List<string>)(object)new List<T>();
			((List<T>)(object)list).Add((T)"");
			int num = 0;
			CustomOptions customOptions = Descriptor.FindFieldByName("ProfileSlot").CustomOptions;
			bool flag = default(bool);
			if (flag)
			{
				IFileSystem _003CSaveGlobal_003Ek__BackingField = Definitions.Util.FileSystem.SaveGlobal;
				List<string> list2 = default(List<string>);
				uint num2 = default(uint);
				IEnumerable<string> enumerable = (IEnumerable<string>)Enumerable.Skip<string>((IEnumerable<>)list2, (int)num2);
				Func<string, string> _003C_003E9__584_ = _003C_003Ec._003C_003E9__584_0;
				if (_003C_003E9__584_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((string x) => "<save>/" + x);
				}
				IEnumerable<string> enumerable2 = (IEnumerable<string>)Enumerable.Select<string, string>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__584_);
				((List<T>)(object)list).AddRange((IEnumerable<>)enumerable2);
				IFileSystem _003CData_003Ek__BackingField = Definitions.Util.FileSystem.Data;
				List<string> list3 = default(List<string>);
				uint num3 = default(uint);
				IEnumerable<string> enumerable3 = (IEnumerable<string>)Enumerable.Skip<string>((IEnumerable<>)list3, (int)num3);
				Func<string, string> func = default(Func<string, string>);
				if (_003C_003Ec._003C_003E9__584_1 == null)
				{
					func = (Func<string, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((string x) => "<data>/" + x));
				}
				IEnumerable<string> enumerable4 = (IEnumerable<string>)Enumerable.Select<string, string>((IEnumerable<>)enumerable3, (Func<, >)(object)func);
				((List<T>)(object)list).AddRange((IEnumerable<>)enumerable4);
			}
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C88")]
		[Cpp2IlInjected.Address(RVA = "0x18D6E20", Offset = "0x18D5820", VA = "0x1818D6E20")]
		static DebugSettings()
		{
			_parser = (MessageParser<DebugSettings>)(object)"debug_settings.json";
			_parser = (MessageParser<DebugSettings>)(object)"Server/default_debug_settings.json";
			_parser = (MessageParser<DebugSettings>)(object)"debug_settings_force_on";
			/*Error: Unexpected end of block*/;
		}
	}
}
