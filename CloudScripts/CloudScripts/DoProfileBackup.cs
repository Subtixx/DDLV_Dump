using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using glPlayFab;
using Newtonsoft.Json;
using PlayFab.EconomyModels;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	public class DoProfileBackup
	{
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		public enum SaveBackupType
		{
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			AutoSave = 18,
			[Cpp2IlInjected.Token(Token = "0x4000559")]
			NewGame,
			[Cpp2IlInjected.Token(Token = "0x400055A")]
			Conflict,
			[Cpp2IlInjected.Token(Token = "0x400055B")]
			Corruption,
			[Cpp2IlInjected.Token(Token = "0x400055C")]
			Cheat,
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			CustomerCare
		}

		[Cpp2IlInjected.Token(Token = "0x200011F")]
		public class PersistenceConfig
		{
			[Cpp2IlInjected.Token(Token = "0x2000120")]
			public enum CleaningSortType
			{
				[Cpp2IlInjected.Token(Token = "0x4000567")]
				RemoveCreationTimeOldest
			}

			[Cpp2IlInjected.Token(Token = "0x400055E")]
			public static readonly TimeSpan UpdateFrequencyAlways = TimeSpan.Zero;

			[Cpp2IlInjected.Token(Token = "0x400055F")]
			public static readonly TimeSpan MinimalGameplayTimespentAlways = TimeSpan.Zero;

			[Cpp2IlInjected.Token(Token = "0x4000560")]
			public static readonly int KeepInfiniteBackups;

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000561")]
			public bool IsActive
			{
				[Cpp2IlInjected.Token(Token = "0x6000385")]
				[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000386")]
				[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4000562")]
			public int MaxNumberToKeep
			{
				[Cpp2IlInjected.Token(Token = "0x6000387")]
				[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000388")]
				[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000563")]
			public TimeSpan UpdateFrequency
			{
				[Cpp2IlInjected.Token(Token = "0x6000389")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600038A")]
				[Cpp2IlInjected.Address(RVA = "0x6E5AC0", Offset = "0x6E44C0", VA = "0x1806E5AC0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4000564")]
			public TimeSpan MinimalGameplayTimespent
			{
				[Cpp2IlInjected.Token(Token = "0x600038B")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600038C")]
				[Cpp2IlInjected.Address(RVA = "0x7F4590", Offset = "0x7F2F90", VA = "0x1807F4590")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4000565")]
			public CleaningSortType CleaningType
			{
				[Cpp2IlInjected.Token(Token = "0x600038D")]
				[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600038E")]
				[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public PersistenceConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000121")]
		public class ProfileBackupConfigData : ITitleDataConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			private string BackupConfigDataKey;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			public Dictionary<SaveBackupType, PersistenceConfig> PersistenceConfigPerType = (Dictionary<SaveBackupType, PersistenceConfig>)(object)new Dictionary<TKey, TValue>();

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x392F150", Offset = "0x392DB50", VA = "0x18392F150")]
			public ProfileBackupConfigData(string key)
			{
				BackupConfigDataKey = key;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "4")]
			public string GetTitleDataConfigKeyName()
			{
				return BackupConfigDataKey;
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x392EFF0", Offset = "0x392D9F0", VA = "0x18392EFF0")]
			public static ProfileBackupConfigData CreateDefault()
			{
				string defaultProfileBackupConfigTitleDataKey = ClientFeaturesToggleConfig.DefaultProfileBackupConfigTitleDataKey;
				ProfileBackupConfigData profileBackupConfigData = default(ProfileBackupConfigData);
				Dictionary<SaveBackupType, PersistenceConfig> dictionary = (profileBackupConfigData.PersistenceConfigPerType = (Dictionary<SaveBackupType, PersistenceConfig>)(object)new Dictionary<TKey, TValue>());
				profileBackupConfigData.BackupConfigDataKey = defaultProfileBackupConfigTitleDataKey;
				Dictionary<SaveBackupType, PersistenceConfig> dictionary2 = (profileBackupConfigData.PersistenceConfigPerType = DefaultPersistenceConfigData);
				return profileBackupConfigData;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000122")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			ExceptionRaised,
			[Cpp2IlInjected.Token(Token = "0x400056D")]
			NotLoggedIn,
			[Cpp2IlInjected.Token(Token = "0x400056E")]
			HTTPNotAvailable,
			[Cpp2IlInjected.Token(Token = "0x400056F")]
			EconomyAPINotAvailable,
			[Cpp2IlInjected.Token(Token = "0x4000570")]
			InvalidArg_Data,
			[Cpp2IlInjected.Token(Token = "0x4000571")]
			InvalidArg_Filename,
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			InvalidArg_DisplayProps,
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			CouldNotCreateUGC,
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			CloudScriptError,
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			MissingPersistenceConfig,
			[Cpp2IlInjected.Token(Token = "0x4000576")]
			CouldNotGetCurrentBackups,
			[Cpp2IlInjected.Token(Token = "0x4000577")]
			CouldNotDownloadRemoteSave,
			[Cpp2IlInjected.Token(Token = "0x4000578")]
			CouldNotCompressRemoteSave,
			[Cpp2IlInjected.Token(Token = "0x4000579")]
			BackupInactive,
			[Cpp2IlInjected.Token(Token = "0x400057A")]
			CouldNotPrepareContentsUrl
		}

		[Cpp2IlInjected.Token(Token = "0x2000123")]
		public enum SuccessType
		{
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			Failed,
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			BackupDone,
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			SkippedNotActive,
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			SkippedUpdateFrequency,
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			SkippedMinimalGameplayTimespent,
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			SkippedNotSupported
		}

		[Cpp2IlInjected.Token(Token = "0x2000124")]
		public class Result
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			public Error Error;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			public SuccessType SuccessType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			public string BackupID;

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			public bool IsBackupAvailable
			{
				[Cpp2IlInjected.Token(Token = "0x6000394")]
				[Cpp2IlInjected.Address(RVA = "0x39303A0", Offset = "0x392EDA0", VA = "0x1839303A0")]
				get
				{
					if (SuccessType != SuccessType.BackupDone)
					{
						int num = 0;
					}
					return !string.IsNullOrEmpty(BackupID);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			public bool IsBackupSuccessful
			{
				[Cpp2IlInjected.Token(Token = "0x6000395")]
				[Cpp2IlInjected.Address(RVA = "0xE606E0", Offset = "0xE5F0E0", VA = "0x180E606E0")]
				get
				{
					return Error == Error.Success;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(Error errorCode)
			{
				Error = errorCode;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x392FAF0", Offset = "0x392E4F0", VA = "0x18392FAF0")]
			public Result WithResult(SuccessType successType, [Optional] string backupID)
			{
				//IL_0010: Expected I4, but got I8
				SuccessType = successType;
				Error = Error.Success;
				BackupID = backupID;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000125")]
		public class DisplayProperties
		{
			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			public string PlayfabID
			{
				[Cpp2IlInjected.Token(Token = "0x6000399")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayfabID_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600039A")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CPlayfabID_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000586")]
			public SaveBackupType BackupType
			{
				[Cpp2IlInjected.Token(Token = "0x600039B")]
				[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600039C")]
				[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			public string PlayerName
			{
				[Cpp2IlInjected.Token(Token = "0x600039D")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayerName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600039E")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CPlayerName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			[JsonIgnore]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4000588")]
			public DateTime ModifiedTime
			{
				[Cpp2IlInjected.Token(Token = "0x600039F")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60003A0")]
				[Cpp2IlInjected.Address(RVA = "0x6E6160", Offset = "0x6E4B60", VA = "0x1806E6160")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4000589")]
			public int TimePlayedInMinutes
			{
				[Cpp2IlInjected.Token(Token = "0x60003A1")]
				[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60003A2")]
				[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x34"), Cpp2IlInjected.Token(Token = "0x400058A")]
			public int PlayerLevel
			{
				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000AB")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x400058B")]
			public int PlayerXp
			{
				[Cpp2IlInjected.Token(Token = "0x60003A5")]
				[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60003A6")]
				[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x3C"), Cpp2IlInjected.Token(Token = "0x400058C")]
			public int SoftCurrency
			{
				[Cpp2IlInjected.Token(Token = "0x60003A7")]
				[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60003A8")]
				[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x400058D")]
			public int HardCurrency
			{
				[Cpp2IlInjected.Token(Token = "0x60003A9")]
				[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60003AA")]
				[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000AE")]
			public string DeviceID
			{
				[Cpp2IlInjected.Token(Token = "0x60003AB")]
				[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
				[CompilerGenerated]
				get
				{
					return _003CDeviceID_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60003AC")]
				[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
				[CompilerGenerated]
				set
				{
					_003CDeviceID_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AF")]
			public string DeviceModel
			{
				[Cpp2IlInjected.Token(Token = "0x60003AD")]
				[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
				[CompilerGenerated]
				get
				{
					return _003CDeviceModel_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60003AE")]
				[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
				[CompilerGenerated]
				set
				{
					_003CDeviceModel_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B0")]
			public string DeviceName
			{
				[Cpp2IlInjected.Token(Token = "0x60003AF")]
				[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
				[CompilerGenerated]
				get
				{
					return _003CDeviceName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60003B0")]
				[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
				[CompilerGenerated]
				set
				{
					_003CDeviceName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public DisplayProperties()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000126")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000591")]
			public SaveBackupType Type
			{
				[Cpp2IlInjected.Token(Token = "0x60003B2")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60003B3")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4000592")]
			public bool UseRemoteSave
			{
				[Cpp2IlInjected.Token(Token = "0x60003B4")]
				[Cpp2IlInjected.Address(RVA = "0xC58490", Offset = "0xC56E90", VA = "0x180C58490")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60003B5")]
				[Cpp2IlInjected.Address(RVA = "0xC584C0", Offset = "0xC56EC0", VA = "0x180C584C0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000B3")]
			public byte[] FileData
			{
				[Cpp2IlInjected.Token(Token = "0x60003B6")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CFileData_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60003B7")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CFileData_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B4")]
			public DisplayProperties DisplayProps
			{
				[Cpp2IlInjected.Token(Token = "0x60003B8")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CDisplayProps_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60003B9")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CDisplayProps_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			} = new DisplayProperties();


			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x392F3A0", Offset = "0x392DDA0", VA = "0x18392F3A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public static readonly string BackupProfileFilename = "profile.zip";

		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public static readonly Dictionary<SaveBackupType, PersistenceConfig> DefaultPersistenceConfigData;

		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public static Dictionary<SaveBackupType, PersistenceConfig> ActivePersistenceConfigData;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public static PersistenceConfig UnitTestDebugPersistenceConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x116D550", Offset = "0x116BF50", VA = "0x18116D550")]
			[CompilerGenerated]
			get
			{
				return _003CUnitTestDebugPersistenceConfig_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x116D5B0", Offset = "0x116BFB0", VA = "0x18116D5B0")]
			[CompilerGenerated]
			set
			{
				BackupProfileFilename = (string)(object)value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x116CFF0", Offset = "0x116B9F0", VA = "0x18116CFF0")]
		[AsyncStateMachine(typeof(_003CDoProfileBackupImplAsync_003Ed__15))]
		public static Task<Result> DoProfileBackupImplAsync(PlayFabContext context, EntityKey creatorEntity, Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public DoProfileBackup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x116D150", Offset = "0x116BB50", VA = "0x18116D150")]
		static DoProfileBackup()
		{
			//Discarded unreachable code: IL_004c, IL_008c, IL_00cc, IL_010c, IL_0153, IL_019a
			//IL_0027: Expected I4, but got I8
			//IL_0065: Expected I4, but got I8
			//IL_00a5: Expected I4, but got I8
			//IL_00e5: Expected I4, but got I8
			//IL_0125: Expected I4, but got I8
			//IL_016c: Expected I4, but got I8
			//IL_01b0: Expected O, but got I4
			Dictionary<SaveBackupType, PersistenceConfig> dictionary = (Dictionary<SaveBackupType, PersistenceConfig>)(object)new Dictionary<TKey, TValue>();
			TimeSpan _003CUpdateFrequency_003Ek__BackingField = default(TimeSpan);
			PersistenceConfig persistenceConfig = new PersistenceConfig
			{
				IsActive = true,
				MaxNumberToKeep = 30,
				UpdateFrequency = _003CUpdateFrequency_003Ek__BackingField
			};
			int _003CCleaningType_003Ek__BackingField = 0;
			TimeSpan timeSpan = (persistenceConfig.MinimalGameplayTimespent = PersistenceConfig.MinimalGameplayTimespentAlways);
			persistenceConfig.CleaningType = (PersistenceConfig.CleaningSortType)_003CCleaningType_003Ek__BackingField;
			throw new NullReferenceException();
		}
	}
}
