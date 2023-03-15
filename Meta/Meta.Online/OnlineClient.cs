using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CloudScripts;
using Cpp2IlInjected;
using Definitions;
using glPlayFab;
using Meta.Online.Economy;
using Meta.Util;
using PlayFab;
using PlayFab.ClientModels;
using PlayFab.DataModels;
using PlayFab.EconomyModels;
using Serilog;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F66")]
	public class OnlineClient
	{
		[Cpp2IlInjected.Token(Token = "0x2000F67")]
		public enum OnlineShopResult
		{
			[Cpp2IlInjected.Token(Token = "0x4003F25")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4003F26")]
			NoStoreAvailable,
			[Cpp2IlInjected.Token(Token = "0x4003F27")]
			BundleNotFound,
			[Cpp2IlInjected.Token(Token = "0x4003F28")]
			FetchOnCooldown
		}

		[Cpp2IlInjected.Token(Token = "0x2000F68")]
		public class GetOnlineShopsResult
		{
			[Cpp2IlInjected.Token(Token = "0x17001628")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4003F29")]
			public OnlineShopResult Result
			{
				[Cpp2IlInjected.Token(Token = "0x6007E6F")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6007E70")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17001629")]
			public List<OnlineStoreData> Stores
			{
				[Cpp2IlInjected.Token(Token = "0x6007E71")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CStores_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007E72")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CStores_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007E73")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public GetOnlineShopsResult WithResult(OnlineShopResult result)
			{
				Result = result;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6007E74")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public GetOnlineShopsResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000F69")]
		public abstract class FetchPlayFabFileResult
		{
			[Cpp2IlInjected.Token(Token = "0x2000F6A")]
			public enum ResultTypes
			{
				[Cpp2IlInjected.Token(Token = "0x4003F2D")]
				LatestVersion,
				[Cpp2IlInjected.Token(Token = "0x4003F2E")]
				DownloadSucceeded,
				[Cpp2IlInjected.Token(Token = "0x4003F2F")]
				FileNotFoundOnServer,
				[Cpp2IlInjected.Token(Token = "0x4003F30")]
				NoFileSpecified,
				[Cpp2IlInjected.Token(Token = "0x4003F31")]
				FileDeserializationError,
				[Cpp2IlInjected.Token(Token = "0x4003F32")]
				GetFilesError,
				[Cpp2IlInjected.Token(Token = "0x4003F33")]
				GetFilesTimeoutError,
				[Cpp2IlInjected.Token(Token = "0x4003F34")]
				DownloadError,
				[Cpp2IlInjected.Token(Token = "0x4003F35")]
				DownloadTimeoutError,
				[Cpp2IlInjected.Token(Token = "0x4003F36")]
				Unknown,
				[Cpp2IlInjected.Token(Token = "0x4003F37")]
				NoBackupURLFound
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003F2B")]
			public ResultTypes ResultType;

			[Cpp2IlInjected.Token(Token = "0x1700162A")]
			public bool HasOnlineError
			{
				[Cpp2IlInjected.Token(Token = "0x6007E75")]
				[Cpp2IlInjected.Address(RVA = "0x10D1940", Offset = "0x10D0340", VA = "0x1810D1940")]
				get
				{
					ResultTypes resultType = ResultType;
					if (resultType != ResultTypes.GetFilesTimeoutError)
					{
						return true;
					}
					return resultType == ResultTypes.GetFilesTimeoutError;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007E76")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			protected FetchPlayFabFileResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000F6B")]
		public class FetchMiniProfileResult : FetchPlayFabFileResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4003F38")]
			public MiniProfile MiniProfile;

			[Cpp2IlInjected.Token(Token = "0x6007E77")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public FetchMiniProfileResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000F6C")]
		public class FetchProfileResult : FetchPlayFabFileResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4003F39")]
			public Profile Profile;

			[Cpp2IlInjected.Token(Token = "0x6007E78")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public FetchProfileResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000F6D")]
		private class UpdateBackupConfigDataResult
		{
			[Cpp2IlInjected.Token(Token = "0x2000F6E")]
			public enum UpdateStatus
			{
				[Cpp2IlInjected.Token(Token = "0x4003F3D")]
				Unknown,
				[Cpp2IlInjected.Token(Token = "0x4003F3E")]
				IsNotFullOnline,
				[Cpp2IlInjected.Token(Token = "0x4003F3F")]
				HasNoClientSession,
				[Cpp2IlInjected.Token(Token = "0x4003F40")]
				HasNoClientFeaturesToggles,
				[Cpp2IlInjected.Token(Token = "0x4003F41")]
				ClientFeaturesTogglesOutdated,
				[Cpp2IlInjected.Token(Token = "0x4003F42")]
				ClientFeaturesToggleConfigBackupInactive,
				[Cpp2IlInjected.Token(Token = "0x4003F43")]
				BackupConfigOutdated,
				[Cpp2IlInjected.Token(Token = "0x4003F44")]
				ExceptionRaised,
				[Cpp2IlInjected.Token(Token = "0x4003F45")]
				UptoDate
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003F3A")]
			public UpdateStatus Status;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4003F3B")]
			public bool IsUsingGamePortalBackupImpl;

			[Cpp2IlInjected.Token(Token = "0x6007E79")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public UpdateBackupConfigDataResult WithStatus(UpdateStatus status)
			{
				Status = status;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6007E7A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public UpdateBackupConfigDataResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000F6F")]
		public class CustomerCareProfile
		{
			[Cpp2IlInjected.Token(Token = "0x2000F70")]
			public class Data
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4003F47")]
				public string BackupID;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4003F48")]
				public string CustomMessage;

				[Cpp2IlInjected.Token(Token = "0x6007E7D")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public Data()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000F71")]
			public enum Error
			{
				[Cpp2IlInjected.Token(Token = "0x4003F4A")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4003F4B")]
				GetObjectsFailed,
				[Cpp2IlInjected.Token(Token = "0x4003F4C")]
				InvalidJsonData,
				[Cpp2IlInjected.Token(Token = "0x4003F4D")]
				CouldNotFetchUGC_BackupID,
				[Cpp2IlInjected.Token(Token = "0x4003F4E")]
				Offline
			}

			[Cpp2IlInjected.Token(Token = "0x2000F72")]
			public class Result
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4003F4F")]
				public Error Error;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4003F50")]
				public Data Data;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4003F51")]
				public GetDraftItemResponse DraftItemResult;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4003F52")]
				public DoProfileBackup.DisplayProperties DisplayProps;

				[Cpp2IlInjected.Token(Token = "0x1700162B")]
				public string SafeGetCustomMessage
				{
					[Cpp2IlInjected.Token(Token = "0x6007E7E")]
					[Cpp2IlInjected.Address(RVA = "0x25D7420", Offset = "0x25D5E20", VA = "0x1825D7420")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700162C")]
				public bool HasCustomeCareProfileToApply
				{
					[Cpp2IlInjected.Token(Token = "0x6007E7F")]
					[Cpp2IlInjected.Address(RVA = "0x541490", Offset = "0x53FE90", VA = "0x180541490")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6007E80")]
				[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
				public Result WithError(Error errCode)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6007E81")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public Result()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4003F46")]
			public static readonly string CustomerCareObjectsKey;

			[Cpp2IlInjected.Token(Token = "0x6007E7B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public CustomerCareProfile()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6007E7C")]
			[Cpp2IlInjected.Address(RVA = "0x10D18F0", Offset = "0x10D02F0", VA = "0x1810D18F0")]
			static CustomerCareProfile()
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000F73")]
		public class LoginRequestParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003F53")]
			public bool IsGameloftIDLogin;

			[Cpp2IlInjected.Token(Token = "0x1700162D")]
			public static LoginRequestParams Default
			{
				[Cpp2IlInjected.Token(Token = "0x6007E82")]
				[Cpp2IlInjected.Address(RVA = "0x10D3DC0", Offset = "0x10D27C0", VA = "0x1810D3DC0")]
				get
				{
					//Discarded unreachable code: IL_000f
					LoginRequestParams loginRequestParams = new LoginRequestParams();
					loginRequestParams.IsGameloftIDLogin = false;
					return loginRequestParams;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007E83")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public LoginRequestParams()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000F74")]
		public enum OnlineMgrType
		{
			[Cpp2IlInjected.Token(Token = "0x4003F55")]
			Config,
			[Cpp2IlInjected.Token(Token = "0x4003F56")]
			Liveops
		}

		[Cpp2IlInjected.Token(Token = "0x2000F75")]
		[Flags]
		public enum OnlineStatus
		{
			[Cpp2IlInjected.Token(Token = "0x4003F58")]
			FullOffline = 0,
			[Cpp2IlInjected.Token(Token = "0x4003F59")]
			InternetOn = 1,
			[Cpp2IlInjected.Token(Token = "0x4003F5A")]
			NativeInternetOn = 2,
			[Cpp2IlInjected.Token(Token = "0x4003F5B")]
			PlayFabLoggedIn = 4,
			[Cpp2IlInjected.Token(Token = "0x4003F5C")]
			PortalLoggedIn = 8,
			[Cpp2IlInjected.Token(Token = "0x4003F5D")]
			FullOnline = -1
		}

		[Cpp2IlInjected.Token(Token = "0x2000F76")]
		public delegate void OnlineConnectionChanged(Profile profile, bool isLoggedIn, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x2000F77")]
		public delegate void ConnectionModeChanged(OnlineStatus currentOnlineStatus, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x2000F78")]
		public delegate void LoginFailure(PlayFabError playFabError);

		[Cpp2IlInjected.Token(Token = "0x2000F79")]
		public enum Result
		{
			[Cpp2IlInjected.Token(Token = "0x4003F5F")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4003F60")]
			AlreadyLoggedIn,
			[Cpp2IlInjected.Token(Token = "0x4003F61")]
			UserDeclined,
			[Cpp2IlInjected.Token(Token = "0x4003F62")]
			LoginFailed,
			[Cpp2IlInjected.Token(Token = "0x4003F63")]
			NotInitialized,
			[Cpp2IlInjected.Token(Token = "0x4003F64")]
			OfflineOnly,
			[Cpp2IlInjected.Token(Token = "0x4003F65")]
			LoginInProgress
		}

		[Cpp2IlInjected.Token(Token = "0x2000F7A")]
		public class AskForLoginResult
		{
			[Cpp2IlInjected.Token(Token = "0x1700162E")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4003F66")]
			public Result Result
			{
				[Cpp2IlInjected.Token(Token = "0x6007E90")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6007E91")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700162F")]
			public bool IsSuccess
			{
				[Cpp2IlInjected.Token(Token = "0x6007E92")]
				[Cpp2IlInjected.Address(RVA = "0x10CF5B0", Offset = "0x10CDFB0", VA = "0x1810CF5B0")]
				get
				{
					Result result = Result;
					if (result == Result.Success)
					{
						return true;
					}
					return result == Result.AlreadyLoggedIn;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007E93")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public AskForLoginResult WithResult(Result result)
			{
				Result = result;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6007E94")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public AskForLoginResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000F7B")]
		public class TestInternetInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003F67")]
			public bool PromptOnError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
			[Cpp2IlInjected.Token(Token = "0x4003F68")]
			public bool UpdateOnlineUser;

			[Cpp2IlInjected.Token(Token = "0x6007E95")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public TestInternetInfo()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4003F05")]
		public const double FetchStoresAndBundlesCooldown = 15.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003F06")]
		private DateTime? lastFetchStoresAndBundlesTimestamp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003F07")]
		private int? lastProfileVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003F08")]
		private string lastMiniProfileChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003F09")]
		private string lastProfileChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003F0A")]
		private SemaphoreSlim uploadProfileSemaphore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003F0B")]
		private TitleDataConfigHolder<DoProfileBackup.ProfileBackupConfigData> BackupConfigData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003F0C")]
		private readonly TimeSpan BackupConfigDataUpdateDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003F0D")]
		private UpdateBackupConfigDataResult LastUpdateBackupConfigDataResult;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003F0E")]
		private readonly Client client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003F0F")]
		private Dictionary<OnlineMgrType, BaseOnlineManager> onlineManagers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003F10")]
		private LoginHandler loginHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003F11")]
		private ProfileConflictResolver profileConflictResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003F12")]
		public bool SyncOnlineInventoryOnLogin;

		[Cpp2IlInjected.Token(Token = "0x4003F15")]
		public static readonly string ProfileFilename = DisneyPlayFabContext.ProfileFilename;

		[Cpp2IlInjected.Token(Token = "0x4003F16")]
		public static readonly string MiniProfileFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003F17")]
		private CancellationTokenSource internetCheckCTS;

		[Cpp2IlInjected.Token(Token = "0x4003F18")]
		public const double CheckInternetIntervalTime = 2.0;

		[Cpp2IlInjected.Token(Token = "0x4003F19")]
		public const string DefaultUrl = "https://www.playfab.com/";

		[Cpp2IlInjected.Token(Token = "0x4003F1B")]
		private const double UploadProfileDefaultCooldownMin = 3.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4003F20")]
		private bool loginInProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4003F21")]
		public readonly PlayFabAuthenticationContext ExpiredAuthenticationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4003F22")]
		private TimeSpan VerifyPurchaseDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4003F23")]
		private DateTime VerifyPurchaseLastCall;

		[Cpp2IlInjected.Token(Token = "0x170015F2")]
		public bool IsFetchStoresAndBundlesReady
		{
			[Cpp2IlInjected.Token(Token = "0x6007DE9")]
			[Cpp2IlInjected.Address(RVA = "0x13A8020", Offset = "0x13A6A20", VA = "0x1813A8020")]
			get
			{
				//Discarded unreachable code: IL_0002
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015F3")]
		private bool IsProfileBackupActive
		{
			[Cpp2IlInjected.Token(Token = "0x6007E01")]
			[Cpp2IlInjected.Address(RVA = "0x13A8230", Offset = "0x13A6C30", VA = "0x1813A8230")]
			get
			{
				UpdateBackupConfigDataResult lastUpdateBackupConfigDataResult = LastUpdateBackupConfigDataResult;
				if (lastUpdateBackupConfigDataResult != null && (long)BackupConfigData != 0)
				{
					return lastUpdateBackupConfigDataResult.Status == UpdateBackupConfigDataResult.UpdateStatus.UptoDate;
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015F4")]
		private bool IsUsingGamePortalBackupImpl
		{
			[Cpp2IlInjected.Token(Token = "0x6007E02")]
			[Cpp2IlInjected.Address(RVA = "0x13A82E0", Offset = "0x13A6CE0", VA = "0x1813A82E0")]
			get
			{
				UpdateBackupConfigDataResult lastUpdateBackupConfigDataResult = LastUpdateBackupConfigDataResult;
				if (lastUpdateBackupConfigDataResult == null)
				{
				}
				return lastUpdateBackupConfigDataResult.IsUsingGamePortalBackupImpl;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015F5")]
		public Client Client
		{
			[Cpp2IlInjected.Token(Token = "0x6007E0B")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return client;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015F6")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x79"), Cpp2IlInjected.Token(Token = "0x4003F13")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6007E0C")]
			[Cpp2IlInjected.Address(RVA = "0xAE85F0", Offset = "0xAE6FF0", VA = "0x180AE85F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007E0D")]
			[Cpp2IlInjected.Address(RVA = "0x13A8960", Offset = "0x13A7360", VA = "0x1813A8960")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170015F7")]
		internal Serilog.ILogger Log
		{
			[Cpp2IlInjected.Token(Token = "0x6007E0E")]
			[Cpp2IlInjected.Address(RVA = "0x13A8330", Offset = "0x13A6D30", VA = "0x1813A8330")]
			get
			{
				Client client;
				do
				{
					client = this.client;
				}
				while (client == null);
				return client.Log;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015F8")]
		public AuthManager AuthentificationManager
		{
			[Cpp2IlInjected.Token(Token = "0x6007E0F")]
			[Cpp2IlInjected.Address(RVA = "0x13A7C60", Offset = "0x13A6660", VA = "0x1813A7C60")]
			get
			{
				//Discarded unreachable code: IL_000c
				return loginHandler.AuthentificationManager;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015F9")]
		public EconomyManager EconomyManager
		{
			[Cpp2IlInjected.Token(Token = "0x6007E10")]
			[Cpp2IlInjected.Address(RVA = "0x13A7E40", Offset = "0x13A6840", VA = "0x1813A7E40")]
			get
			{
				LoginHandler loginHandler;
				do
				{
					loginHandler = this.loginHandler;
				}
				while (loginHandler == null);
				return loginHandler.EconomyManager;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015FA")]
		public ClientSession ClientSession
		{
			[Cpp2IlInjected.Token(Token = "0x6007E11")]
			[Cpp2IlInjected.Address(RVA = "0x13A7CB0", Offset = "0x13A66B0", VA = "0x1813A7CB0")]
			get
			{
				LoginHandler loginHandler;
				do
				{
					loginHandler = this.loginHandler;
				}
				while (loginHandler == null);
				return loginHandler.clientSession;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015FB")]
		public OnlineEnvironment CachedOnlineEnv
		{
			[Cpp2IlInjected.Token(Token = "0x6007E12")]
			[Cpp2IlInjected.Address(RVA = "0x13A7C80", Offset = "0x13A6680", VA = "0x1813A7C80")]
			get
			{
				//Discarded unreachable code: IL_0019
				return loginHandler?.CachedOnlineEnvironmentResult.EnvType ?? OnlineEnvironment.Dev;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015FC")]
		public LoginHandler.LoginResult LastLoginResult
		{
			[Cpp2IlInjected.Token(Token = "0x6007E13")]
			[Cpp2IlInjected.Address(RVA = "0x13A8320", Offset = "0x13A6D20", VA = "0x1813A8320")]
			get
			{
				LoginHandler loginHandler;
				do
				{
					loginHandler = this.loginHandler;
				}
				while (loginHandler == null);
				return loginHandler.LastLoginResult;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015FD")]
		public PlayFabError LastLoginPlayFabError
		{
			[Cpp2IlInjected.Token(Token = "0x6007E14")]
			[Cpp2IlInjected.Address(RVA = "0x13A82F0", Offset = "0x13A6CF0", VA = "0x1813A82F0")]
			get
			{
				//Discarded unreachable code: IL_0011
				return loginHandler.LastLoginResult.PlayFabError;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015FE")]
		public PlayerProfileModel PlayerProfileModel
		{
			[Cpp2IlInjected.Token(Token = "0x6007E15")]
			[Cpp2IlInjected.Address(RVA = "0x13A8490", Offset = "0x13A6E90", VA = "0x1813A8490")]
			get
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null)
					{
						return clientSession.PlayerProfileModel;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015FF")]
		public UserAccountInfo UserAccountInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6007E16")]
			[Cpp2IlInjected.Address(RVA = "0x13A8740", Offset = "0x13A7140", VA = "0x1813A8740")]
			get
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null)
					{
						return clientSession.UserAccountInfo;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001600")]
		public DateTime OnlineTime
		{
			[Cpp2IlInjected.Token(Token = "0x6007E17")]
			[Cpp2IlInjected.Address(RVA = "0x13A8340", Offset = "0x13A6D40", VA = "0x1813A8340")]
			get
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					return loginHandler.OnlineTime;
				}
				int num = 0;
				return DateTime.UtcNow;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001601")]
		public bool IsDevInPlayFab
		{
			[Cpp2IlInjected.Token(Token = "0x6007E18")]
			[Cpp2IlInjected.Address(RVA = "0x13A8010", Offset = "0x13A6A10", VA = "0x1813A8010")]
			get
			{
				LoginHandler loginHandler;
				do
				{
					loginHandler = this.loginHandler;
				}
				while (loginHandler == null);
				return loginHandler.IsDevInPlayFab;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001602")]
		public DisneyCloudScript PlayfabScriptExecutor
		{
			[Cpp2IlInjected.Token(Token = "0x6007E19")]
			[Cpp2IlInjected.Address(RVA = "0x13A84F0", Offset = "0x13A6EF0", VA = "0x1813A84F0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return loginHandler.PlayfabScriptExecutor;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001603")]
		private PlayFabAuthenticationInstanceAPI auth
		{
			[Cpp2IlInjected.Token(Token = "0x6007E1A")]
			[Cpp2IlInjected.Address(RVA = "0x13A83B0", Offset = "0x13A6DB0", VA = "0x1813A83B0")]
			get
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null)
					{
						return clientSession.auth;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001604")]
		public PlayFabAuthenticationInstanceAPI PlayFabAuth
		{
			[Cpp2IlInjected.Token(Token = "0x6007E1B")]
			[Cpp2IlInjected.Address(RVA = "0x13A83B0", Offset = "0x13A6DB0", VA = "0x1813A83B0")]
			get
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null)
					{
						return clientSession.auth;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001605")]
		private PlayFabClientInstanceAPI clientAPI
		{
			[Cpp2IlInjected.Token(Token = "0x6007E1C")]
			[Cpp2IlInjected.Address(RVA = "0x13A83D0", Offset = "0x13A6DD0", VA = "0x1813A83D0")]
			get
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null)
					{
						return clientSession.client;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001606")]
		public PlayFabClientInstanceAPI PlayFabClient
		{
			[Cpp2IlInjected.Token(Token = "0x6007E1D")]
			[Cpp2IlInjected.Address(RVA = "0x13A83D0", Offset = "0x13A6DD0", VA = "0x1813A83D0")]
			get
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null)
					{
						return clientSession.client;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001607")]
		private PlayFabDataInstanceAPI data
		{
			[Cpp2IlInjected.Token(Token = "0x6007E1E")]
			[Cpp2IlInjected.Address(RVA = "0x13A8410", Offset = "0x13A6E10", VA = "0x1813A8410")]
			get
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null)
					{
						return clientSession.data;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001608")]
		public PlayFabDataInstanceAPI PlayFabData
		{
			[Cpp2IlInjected.Token(Token = "0x6007E1F")]
			[Cpp2IlInjected.Address(RVA = "0x13A8410", Offset = "0x13A6E10", VA = "0x1813A8410")]
			get
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null)
					{
						return clientSession.data;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001609")]
		private PlayFabEconomyInstanceAPI economy
		{
			[Cpp2IlInjected.Token(Token = "0x6007E20")]
			[Cpp2IlInjected.Address(RVA = "0x13A84B0", Offset = "0x13A6EB0", VA = "0x1813A84B0")]
			get
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null)
					{
						return clientSession.economy;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700160A")]
		public PlayFabEconomyInstanceAPI PlayfabEconomy
		{
			[Cpp2IlInjected.Token(Token = "0x6007E21")]
			[Cpp2IlInjected.Address(RVA = "0x13A84B0", Offset = "0x13A6EB0", VA = "0x1813A84B0")]
			get
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null)
					{
						return clientSession.economy;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700160B")]
		private PlayFabCloudScriptInstanceAPI cloudscript
		{
			[Cpp2IlInjected.Token(Token = "0x6007E22")]
			[Cpp2IlInjected.Address(RVA = "0x13A83F0", Offset = "0x13A6DF0", VA = "0x1813A83F0")]
			get
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null)
					{
						return clientSession.cloudscript;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700160C")]
		public PlayFabCloudScriptInstanceAPI PlayFabCloudscript
		{
			[Cpp2IlInjected.Token(Token = "0x6007E23")]
			[Cpp2IlInjected.Address(RVA = "0x13A83F0", Offset = "0x13A6DF0", VA = "0x1813A83F0")]
			get
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null)
					{
						return clientSession.cloudscript;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700160D")]
		private PlayFabProfilesInstanceAPI profiles
		{
			[Cpp2IlInjected.Token(Token = "0x6007E24")]
			[Cpp2IlInjected.Address(RVA = "0x13A84D0", Offset = "0x13A6ED0", VA = "0x1813A84D0")]
			get
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null)
					{
						return clientSession.profiles;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700160E")]
		public PlayFabProfilesInstanceAPI PlayfabProfiles
		{
			[Cpp2IlInjected.Token(Token = "0x6007E25")]
			[Cpp2IlInjected.Address(RVA = "0x13A84D0", Offset = "0x13A6ED0", VA = "0x1813A84D0")]
			get
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null)
					{
						return clientSession.profiles;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700160F")]
		public TitleConfig TitleConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6007E26")]
			[Cpp2IlInjected.Address(RVA = "0x13A8510", Offset = "0x13A6F10", VA = "0x1813A8510")]
			get
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null)
					{
						return clientSession.TitleConfig;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001610")]
		public PlayFabAuthenticationContext CurrentAuthContext
		{
			[Cpp2IlInjected.Token(Token = "0x6007E27")]
			[Cpp2IlInjected.Address(RVA = "0x13A7CC0", Offset = "0x13A66C0", VA = "0x1813A7CC0")]
			get
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null)
					{
						return clientSession.AuthContext;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001611")]
		public PlayFab.DataModels.EntityKey DataTitleEntity
		{
			[Cpp2IlInjected.Token(Token = "0x6007E28")]
			[Cpp2IlInjected.Address(RVA = "0x13A7CE0", Offset = "0x13A66E0", VA = "0x1813A7CE0")]
			get
			{
				//Discarded unreachable code: IL_0024
				PlayFab.DataModels.EntityKey entityKey = new PlayFab.DataModels.EntityKey();
				string text = (entityKey.Id = TitleId);
				string text2 = (entityKey.Type = Entity.GetName(Entity.Types.Title));
				return entityKey;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001612")]
		public Dictionary<OnlineEnvironment, string> DeveloperSecretKeys
		{
			[Cpp2IlInjected.Token(Token = "0x6007E29")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			[CompilerGenerated]
			get
			{
				return _003CDeveloperSecretKeys_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007E2A")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4A0", Offset = "0x7D9EA0", VA = "0x1807DB4A0")]
			[CompilerGenerated]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001613")]
		private LoginResult loginResult
		{
			[Cpp2IlInjected.Token(Token = "0x6007E2B")]
			[Cpp2IlInjected.Address(RVA = "0x13A8760", Offset = "0x13A7160", VA = "0x1813A8760")]
			get
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null)
					{
						return clientSession.loginResult;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001614")]
		public string PlayFabId
		{
			[Cpp2IlInjected.Token(Token = "0x6007E2C")]
			[Cpp2IlInjected.Address(RVA = "0x13A8430", Offset = "0x13A6E30", VA = "0x1813A8430")]
			get
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null)
					{
						LoginResult _003CloginResult_003Ek__BackingField = clientSession.loginResult;
						if (_003CloginResult_003Ek__BackingField != null && _003CloginResult_003Ek__BackingField.PlayFabId != null)
						{
						}
					}
				}
				return "unknown";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001615")]
		public string EntityId
		{
			[Cpp2IlInjected.Token(Token = "0x6007E2D")]
			[Cpp2IlInjected.Address(RVA = "0x13A7E50", Offset = "0x13A6850", VA = "0x1813A7E50")]
			get
			{
				//Discarded unreachable code: IL_0035
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null)
					{
						LoginResult _003CloginResult_003Ek__BackingField = clientSession.loginResult;
						if (_003CloginResult_003Ek__BackingField != null && _003CloginResult_003Ek__BackingField.AuthenticationContext.EntityId != null)
						{
						}
					}
				}
				return "unknown";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001616")]
		public string TitleId
		{
			[Cpp2IlInjected.Token(Token = "0x6007E2E")]
			[Cpp2IlInjected.Address(RVA = "0x13A8530", Offset = "0x13A6F30", VA = "0x1813A8530")]
			get
			{
				//Discarded unreachable code: IL_0046
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null)
					{
						PlayFabClientInstanceAPI playFabClientInstanceAPI = clientSession.client;
						if (playFabClientInstanceAPI != null)
						{
							PlayFabApiSettings apiSettings = playFabClientInstanceAPI.apiSettings;
							if (apiSettings != null && apiSettings.TitleId != null)
							{
								goto IL_0040;
							}
						}
						return PlayFabSettings.staticSettings.TitleId;
					}
				}
				goto IL_0040;
				IL_0040:
				return "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001617")]
		public string GamerTag
		{
			[Cpp2IlInjected.Token(Token = "0x6007E2F")]
			[Cpp2IlInjected.Address(RVA = "0x13A7EC0", Offset = "0x13A68C0", VA = "0x1813A7EC0")]
			get
			{
				//Discarded unreachable code: IL_0046
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					AuthManager authentificationManager = loginHandler.AuthentificationManager;
					if (authentificationManager != null)
					{
						AuthManager.AuthentificatorBase _003CNativeAuth_003Ek__BackingField = authentificationManager.NativeAuth;
						if (_003CNativeAuth_003Ek__BackingField != null)
						{
							int num = 0;
							AuthManager.XboxAuthenticator.LoginData loginData = default(AuthManager.XboxAuthenticator.LoginData);
							AuthManager.XboxAuthenticator.LoginData loginData2 = default(AuthManager.XboxAuthenticator.LoginData);
							if (_003CNativeAuth_003Ek__BackingField != null && loginData != null && (long)loginData.GamerTag != 0)
							{
								return loginData2.GamerTag;
							}
						}
					}
				}
				return "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001618")]
		public string DebugGetPlayFabUserGMLink
		{
			[Cpp2IlInjected.Token(Token = "0x6007E30")]
			[Cpp2IlInjected.Address(RVA = "0x13A7DA0", Offset = "0x13A67A0", VA = "0x1813A7DA0")]
			get
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					string titleId = TitleId;
					LoginHandler loginHandler2 = this.loginHandler;
					if (loginHandler2 != null)
					{
						ClientSession clientSession = loginHandler2.clientSession;
						if (clientSession != null)
						{
							LoginResult _003CloginResult_003Ek__BackingField = clientSession.loginResult;
							if (_003CloginResult_003Ek__BackingField != null && _003CloginResult_003Ek__BackingField.PlayFabId != null)
							{
							}
						}
					}
					return loginHandler.GetPlayFabGameManagerLink(titleId, "unknown");
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001619")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x90"), Cpp2IlInjected.Token(Token = "0x4003F1A")]
		public OnlineStatus CurrentOnlineStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6007E31")]
			[Cpp2IlInjected.Address(RVA = "0x725190", Offset = "0x723B90", VA = "0x180725190")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007E32")]
			[Cpp2IlInjected.Address(RVA = "0x725370", Offset = "0x723D70", VA = "0x180725370")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700161A")]
		public bool IsFullOnline
		{
			[Cpp2IlInjected.Token(Token = "0x6007E33")]
			[Cpp2IlInjected.Address(RVA = "0x13A80E0", Offset = "0x13A6AE0", VA = "0x1813A80E0")]
			get
			{
				return CurrentOnlineStatus == OnlineStatus.FullOnline;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700161B")]
		public bool IsFullOffline
		{
			[Cpp2IlInjected.Token(Token = "0x6007E34")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700161C")]
		public bool IsLoggedInWithPlayFab
		{
			[Cpp2IlInjected.Token(Token = "0x6007E35")]
			[Cpp2IlInjected.Address(RVA = "0x13A8190", Offset = "0x13A6B90", VA = "0x1813A8190")]
			get
			{
				OnlineStatus onlineStatus = CurrentOnlineStatus;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700161D")]
		public bool IsLoggedInWithPortal
		{
			[Cpp2IlInjected.Token(Token = "0x6007E36")]
			[Cpp2IlInjected.Address(RVA = "0x13A81A0", Offset = "0x13A6BA0", VA = "0x1813A81A0")]
			get
			{
				OnlineStatus onlineStatus = CurrentOnlineStatus;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700161E")]
		public bool IsLoggedInWithAllServices
		{
			[Cpp2IlInjected.Token(Token = "0x6007E37")]
			[Cpp2IlInjected.Address(RVA = "0x13A8180", Offset = "0x13A6B80", VA = "0x1813A8180")]
			get
			{
				return CurrentOnlineStatus == (OnlineStatus.PlayFabLoggedIn | OnlineStatus.PortalLoggedIn);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700161F")]
		public bool IsInternetOn
		{
			[Cpp2IlInjected.Token(Token = "0x6007E38")]
			[Cpp2IlInjected.Address(RVA = "0x13A80F0", Offset = "0x13A6AF0", VA = "0x1813A80F0")]
			get
			{
				//Discarded unreachable code: IL_0034
				if (CurrentOnlineStatus == OnlineStatus.InternetOn)
				{
					int num = 0;
				}
				Client client = this.client;
				OnlineStatus onlineStatus = default(OnlineStatus);
				if ((long)client.NativeNetworkManager > 0)
				{
					onlineStatus = CurrentOnlineStatus;
					while (onlineStatus == OnlineStatus.InternetOn)
					{
					}
				}
				IUnityContext _003CUnityContext_003Ek__BackingField = client.UnityContext;
				return onlineStatus == OnlineStatus.FullOffline;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001620")]
		private bool IsNativeInternetOn
		{
			[Cpp2IlInjected.Token(Token = "0x6007E39")]
			[Cpp2IlInjected.Address(RVA = "0x13A81B0", Offset = "0x13A6BB0", VA = "0x1813A81B0")]
			get
			{
				//Discarded unreachable code: IL_002d
				Client client = this.client;
				if ((long)client.NativeNetworkManager > 0 && CurrentOnlineStatus == OnlineStatus.InternetOn)
				{
					int num = 0;
				}
				IUnityContext _003CUnityContext_003Ek__BackingField = client.UnityContext;
				return (object)typeof(IUnityContext).TypeHandle == null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001621")]
		private double UploadProfileCooldown
		{
			[Cpp2IlInjected.Token(Token = "0x6007E3C")]
			[Cpp2IlInjected.Address(RVA = "0x13A85F0", Offset = "0x13A6FF0", VA = "0x1813A85F0")]
			get
			{
				//IL_0011: Invalid comparison between F4 and I4
				int num = 0;
				float overrideUploadProfileCooldownMin_ = DebugSettings.Settings.overrideUploadProfileCooldownMin_;
				int num2 = 0;
				if (!(overrideUploadProfileCooldownMin_ <= (float)num2))
				{
					int num3 = 0;
					float overrideUploadProfileCooldownMin_2 = DebugSettings.Settings.overrideUploadProfileCooldownMin_;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001622")]
		public bool IsUploadProfileReady
		{
			[Cpp2IlInjected.Token(Token = "0x6007E3D")]
			[Cpp2IlInjected.Address(RVA = "0x13A8250", Offset = "0x13A6C50", VA = "0x1813A8250")]
			get
			{
				DateTime dateTime = LastUploadTime;
				double uploadProfileCooldown = UploadProfileCooldown;
				int num = 0;
				DateTime utcNow = DateTime.UtcNow;
				DateTime dateTime2 = default(DateTime);
				return dateTime2 < utcNow;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001623")]
		public double UploadProfileRemainingTime
		{
			[Cpp2IlInjected.Token(Token = "0x6007E3E")]
			[Cpp2IlInjected.Address(RVA = "0x13A86A0", Offset = "0x13A70A0", VA = "0x1813A86A0")]
			get
			{
				DateTime dateTime = LastUploadTime;
				double uploadProfileCooldown = UploadProfileCooldown;
				int num = 0;
				DateTime utcNow = DateTime.UtcNow;
				double result = default(double);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001624")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x98"), Cpp2IlInjected.Token(Token = "0x4003F1C")]
		public DateTime LastUploadTime
		{
			[Cpp2IlInjected.Token(Token = "0x6007E3F")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007E40")]
			[Cpp2IlInjected.Address(RVA = "0xD2D650", Offset = "0xD2C050", VA = "0x180D2D650")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001625")]
		public ProfileConflictResolver ProfileConflictResolver
		{
			[Cpp2IlInjected.Token(Token = "0x6007E47")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return profileConflictResolver;
			}
			[Cpp2IlInjected.Token(Token = "0x6007E48")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			private set
			{
				profileConflictResolver = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001626")]
		public bool HasNativeInternet
		{
			[Cpp2IlInjected.Token(Token = "0x6007E4F")]
			[Cpp2IlInjected.Address(RVA = "0x13A7FB0", Offset = "0x13A69B0", VA = "0x1813A7FB0")]
			get
			{
				Client client = this.client;
				if (client == null || client.NativeNetworkManager != null)
				{
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001627")]
		public bool HasNativeInternetImpl
		{
			[Cpp2IlInjected.Token(Token = "0x6007E50")]
			[Cpp2IlInjected.Address(RVA = "0x13A7F90", Offset = "0x13A6990", VA = "0x1813A7F90")]
			get
			{
				Client client = this.client;
				if (client != null)
				{
					return client.NativeNetworkManager != null;
				}
				return client != null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x140000A3")]
		public event OnlineConnectionChanged OnOnlineConnectionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6007E41")]
			[Cpp2IlInjected.Address(RVA = "0x13A7BC0", Offset = "0x13A65C0", VA = "0x1813A7BC0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6007E42")]
			[Cpp2IlInjected.Address(RVA = "0x13A88C0", Offset = "0x13A72C0", VA = "0x1813A88C0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x140000A4")]
		public event ConnectionModeChanged OnConnectionModeChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6007E43")]
			[Cpp2IlInjected.Address(RVA = "0x13A7A80", Offset = "0x13A6480", VA = "0x1813A7A80")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6007E44")]
			[Cpp2IlInjected.Address(RVA = "0x13A8780", Offset = "0x13A7180", VA = "0x1813A8780")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x140000A5")]
		public event LoginFailure OnLoginFailure
		{
			[Cpp2IlInjected.Token(Token = "0x6007E45")]
			[Cpp2IlInjected.Address(RVA = "0x13A7B20", Offset = "0x13A6520", VA = "0x1813A7B20")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6007E46")]
			[Cpp2IlInjected.Address(RVA = "0x13A8820", Offset = "0x13A7220", VA = "0x1813A8820")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007DEA")]
		[Cpp2IlInjected.Address(RVA = "0x26D0C80", Offset = "0x26CF680", VA = "0x1826D0C80")]
		private List<> GetLiveopsData<T>() where T : IFetchable
		{
			//IL_000d: Expected O, but got I4
			BaseOnlineManager baseOnlineManager = (BaseOnlineManager)((Dictionary<TKey, TValue>)(object)onlineManagers)[(TKey)1];
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007DEB")]
		[Cpp2IlInjected.Address(RVA = "0x26D0BC0", Offset = "0x26CF5C0", VA = "0x1826D0BC0")]
		private Task<> FetchAndGetLiveopsData<T>(CancellationToken P_0) where T : IFetchable
		{
			//IL_000d: Expected O, but got I4
			BaseOnlineManager baseOnlineManager = (BaseOnlineManager)((Dictionary<TKey, TValue>)(object)onlineManagers)[(TKey)1];
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007DEC")]
		[Cpp2IlInjected.Address(RVA = "0x13A3AF0", Offset = "0x13A24F0", VA = "0x1813A3AF0")]
		public List<OnlineBundleData> GetBundles()
		{
			return (List<OnlineBundleData>)(object)GetLiveopsData<OnlineBundleData>();
		}

		[Cpp2IlInjected.Token(Token = "0x6007DED")]
		[Cpp2IlInjected.Address(RVA = "0x13A3FB0", Offset = "0x13A29B0", VA = "0x1813A3FB0")]
		public List<OnlineStoreData> GetStores()
		{
			return (List<OnlineStoreData>)(object)GetLiveopsData<OnlineStoreData>();
		}

		[Cpp2IlInjected.Token(Token = "0x6007DEE")]
		[Cpp2IlInjected.Address(RVA = "0x13A3AB0", Offset = "0x13A24B0", VA = "0x1813A3AB0")]
		public List<BattlePassSeasonData> GetBattlePasses()
		{
			return (List<BattlePassSeasonData>)(object)GetLiveopsData<BattlePassSeasonData>();
		}

		[Cpp2IlInjected.Token(Token = "0x6007DEF")]
		[Cpp2IlInjected.Address(RVA = "0x13A3350", Offset = "0x13A1D50", VA = "0x1813A3350")]
		private Task<Dictionary<string, OnlineBundleData>> FetchAndGetBundles(CancellationToken ct)
		{
			return (Task<Dictionary<string, OnlineBundleData>>)(object)FetchAndGetLiveopsData<OnlineBundleData>(ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007DF0")]
		[Cpp2IlInjected.Address(RVA = "0x13A33A0", Offset = "0x13A1DA0", VA = "0x1813A33A0")]
		private Task<Dictionary<string, OnlineStoreData>> FetchAndGetStores(CancellationToken ct)
		{
			return (Task<Dictionary<string, OnlineStoreData>>)(object)FetchAndGetLiveopsData<OnlineStoreData>(ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007DF1")]
		[Cpp2IlInjected.Address(RVA = "0x13A3300", Offset = "0x13A1D00", VA = "0x1813A3300")]
		private Task<Dictionary<string, BattlePassSeasonData>> FetchAndGetBattlePasses(CancellationToken ct)
		{
			return (Task<Dictionary<string, BattlePassSeasonData>>)(object)FetchAndGetLiveopsData<BattlePassSeasonData>(ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007DF2")]
		[Cpp2IlInjected.Address(RVA = "0x13A3D00", Offset = "0x13A2700", VA = "0x1813A3D00")]
		[AsyncStateMachine(typeof(_003CGetOnlineShops_003Ed__14))]
		public Task<GetOnlineShopsResult> GetOnlineShops(CancellationToken ct, bool forceFetch = false, bool ignoreCooldown = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GetOnlineShopsResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007DF3")]
		[Cpp2IlInjected.Address(RVA = "0x13A46C0", Offset = "0x13A30C0", VA = "0x1813A46C0")]
		private void LogInfoOnlineSave(ProfileGameInfo profileGameInfo, string msg)
		{
			//Discarded unreachable code: IL_001e
			//IL_001c: Expected O, but got I8
			if (client != null)
			{
			}
			ulong revision_ = profileGameInfo.revision_;
			string text = $"[AL][Online/ProfileRev {revision_}] {msg}";
		}

		[Cpp2IlInjected.Token(Token = "0x6007DF4")]
		[Cpp2IlInjected.Address(RVA = "0x13A4B90", Offset = "0x13A3590", VA = "0x1813A4B90")]
		private void LogWarningOnlineSave(ProfileGameInfo profileGameInfo, string msg)
		{
			//Discarded unreachable code: IL_001e
			//IL_001c: Expected O, but got I8
			if (client != null)
			{
			}
			ulong revision_ = profileGameInfo.revision_;
			string text = $"[AL][Online/ProfileRev {revision_}] {msg}";
		}

		[Cpp2IlInjected.Token(Token = "0x6007DF5")]
		[Cpp2IlInjected.Address(RVA = "0x13A4600", Offset = "0x13A3000", VA = "0x1813A4600")]
		private void LogErrorOnlineSave(ProfileGameInfo profileGameInfo, string msg)
		{
			//Discarded unreachable code: IL_001e
			//IL_001c: Expected O, but got I8
			if (client != null)
			{
			}
			ulong revision_ = profileGameInfo.revision_;
			string text = $"[AL][Online/ProfileRev {revision_}] {msg}";
		}

		[Cpp2IlInjected.Token(Token = "0x6007DF6")]
		[Cpp2IlInjected.Address(RVA = "0x13A5490", Offset = "0x13A3E90", VA = "0x1813A5490")]
		public void ResetUploadProfileContext()
		{
			//IL_0009: Expected O, but got I4
			//IL_0010: Expected O, but got I4
			//IL_0019: Expected O, but got I8
			int num = 0;
			lastProfileVersion = (int?)(object)num;
			lastMiniProfileChecksum = (string)num;
			LastUploadTime = (DateTime)0;
		}

		[Cpp2IlInjected.Token(Token = "0x6007DF7")]
		[Cpp2IlInjected.Address(RVA = "0x13A5370", Offset = "0x13A3D70", VA = "0x1813A5370")]
		[AsyncStateMachine(typeof(_003CResetPlayFabProfileAsync_003Ed__23))]
		public Task<bool> ResetPlayFabProfileAsync([Optional] CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007DF8")]
		[Cpp2IlInjected.Address(RVA = "0x13A3670", Offset = "0x13A2070", VA = "0x1813A3670")]
		[AsyncStateMachine(typeof(_003CFetchPlayFabMiniProfile_003Ed__27))]
		public Task<FetchMiniProfileResult> FetchPlayFabMiniProfile(PlayFabDataInstanceAPI dataInst, [Optional] string checksum, [Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<FetchMiniProfileResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007DF9")]
		[Cpp2IlInjected.Address(RVA = "0x13A37F0", Offset = "0x13A21F0", VA = "0x1813A37F0")]
		[AsyncStateMachine(typeof(_003CFetchPlayFabProfile_003Ed__28))]
		public Task<FetchProfileResult> FetchPlayFabProfile(PlayFabDataInstanceAPI dataInst, [Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<FetchProfileResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007DFA")]
		[Cpp2IlInjected.Address(RVA = "0x13A3530", Offset = "0x13A1F30", VA = "0x1813A3530")]
		[AsyncStateMachine(typeof(_003CFetchPlayFabBackupProfile_003Ed__29))]
		public Task<FetchProfileResult> FetchPlayFabBackupProfile(CustomerCareProfile.Result ccResult, [Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<FetchProfileResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007DFB")]
		[Cpp2IlInjected.Address(RVA = "0x13A6F10", Offset = "0x13A5910", VA = "0x1813A6F10")]
		public Task<bool> TrySaveToPlayFab(bool waitIfSaving = false, bool force = false, bool askForLogin = false, bool forceTestInternet = false, [Optional] CancellationToken ct)
		{
			//Discarded unreachable code: IL_0027
			Simulator<TransactionServiceServerImpl, TransactionService.TransactionServiceClient> simulator = client.simulator;
			if (simulator != null)
			{
				Profile profile = ((TransactionServiceServerImpl)(object)((Simulator<SERVER, CLIENT>)(object)simulator).ServerService).Profile;
			}
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007DFC")]
		[Cpp2IlInjected.Address(RVA = "0x13A6900", Offset = "0x13A5300", VA = "0x1813A6900")]
		public Task<bool> TrySaveConflictResolverLocalProfileToPlayFab(bool waitIfSaving = false, bool force = false, bool askForLogin = false, [Optional] CancellationToken ct)
		{
			//Discarded unreachable code: IL_0011
			ProfileConflictResolver profileConflictResolver = this.profileConflictResolver;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007DFD")]
		[Cpp2IlInjected.Address(RVA = "0x13A6C00", Offset = "0x13A5600", VA = "0x1813A6C00")]
		[AsyncStateMachine(typeof(_003CTrySaveToPlayFab_003Ed__32))]
		public Task<bool> TrySaveToPlayFab(Profile profile, bool waitIfSaving = false, bool force = false, bool askForLogin = false, bool forceTestInternet = false, [Optional] CancellationToken ct, [Optional] byte[] jProfile)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007DFE")]
		[Cpp2IlInjected.Address(RVA = "0x13A6D90", Offset = "0x13A5790", VA = "0x1813A6D90")]
		[AsyncStateMachine(typeof(_003CTrySaveToPlayFab_003Ed__33))]
		private Task<bool> TrySaveToPlayFab(MiniProfile miniProfile, bool waitIfSaving = false, bool force = false, bool fromConflictResolver = false, bool askForLogin = false, [Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007DFF")]
		[Cpp2IlInjected.Address(RVA = "0x13A6A90", Offset = "0x13A5490", VA = "0x1813A6A90")]
		[AsyncStateMachine(typeof(_003CTrySaveToPlayFabAsync_003Ed__34))]
		private Task<bool> TrySaveToPlayFabAsync(Profile profile, bool waitIfSaving = false, bool force = false, [Optional] CancellationToken ct, [Optional] byte[] jProfile)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E00")]
		[Cpp2IlInjected.Address(RVA = "0x13A4330", Offset = "0x13A2D30", VA = "0x1813A4330")]
		private bool IsProfileUploadToPlayFabReady(ProfileGameInfo profileGameInfo, bool force = false, bool fromConflictResolver = false)
		{
			if (CurrentOnlineStatus == (OnlineStatus.PlayFabLoggedIn | OnlineStatus.PortalLoggedIn))
			{
				if (!profileConflictResolver.IsResolvingConflicts || !fromConflictResolver)
				{
				}
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null)
				{
					ClientSession clientSession = loginHandler.clientSession;
					if (clientSession != null && (long)clientSession.data != 0)
					{
						int num = 0;
						if (!DebugSettings.Settings.disableProfileUpload_)
						{
							if (!force)
							{
								DateTime dateTime = LastUploadTime;
								double uploadProfileCooldown = UploadProfileCooldown;
								int num2 = 0;
								DateTime utcNow = DateTime.UtcNow;
								DateTime dateTime2 = default(DateTime);
								if (!(dateTime2 < utcNow))
								{
									DateTime dateTime3 = LastUploadTime;
									uploadProfileCooldown = UploadProfileCooldown;
									int num3 = 0;
									DateTime utcNow2 = DateTime.UtcNow;
									TimeSpan arg = default(TimeSpan);
									string text = $"IsProfileUploadToPlayFabReady ? => not ready because it's still on cooldown with remaining time = {arg} seconds.";
								}
							}
							LogInfoOnlineSave(profileGameInfo, "IsProfileUploadToPlayFabReady ? => ready !");
						}
					}
				}
			}
			LogInfoOnlineSave(profileGameInfo, "IsProfileUploadToPlayFabReady ? => not ready because playing offline.");
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007E03")]
		[Cpp2IlInjected.Address(RVA = "0x13A5AE0", Offset = "0x13A44E0", VA = "0x1813A5AE0")]
		public void TraceBackupConfigToLogger(Serilog.ILogger logger)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6007E04")]
		[Cpp2IlInjected.Address(RVA = "0x13A73A0", Offset = "0x13A5DA0", VA = "0x1813A73A0")]
		[AsyncStateMachine(typeof(_003CUpdateBackupConfigData_003Ed__45))]
		private Task<UpdateBackupConfigDataResult> UpdateBackupConfigData([Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<UpdateBackupConfigDataResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E05")]
		[Cpp2IlInjected.Address(RVA = "0x13A6140", Offset = "0x13A4B40", VA = "0x1813A6140")]
		[AsyncStateMachine(typeof(_003CTriggerRemoteSaveBackup_003Ed__46))]
		public Task<DoProfileBackup.Result> TriggerRemoteSaveBackup(DoProfileBackup.SaveBackupType type)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<DoProfileBackup.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E06")]
		[Cpp2IlInjected.Address(RVA = "0x13A7110", Offset = "0x13A5B10", VA = "0x1813A7110")]
		[AsyncStateMachine(typeof(_003CTryUploadLocalSavefileAsBackup_003Ed__47))]
		public Task<DoProfileBackup.Result> TryUploadLocalSavefileAsBackup(DoProfileBackup.SaveBackupType type)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<DoProfileBackup.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E07")]
		[Cpp2IlInjected.Address(RVA = "0x13A7260", Offset = "0x13A5C60", VA = "0x1813A7260")]
		[AsyncStateMachine(typeof(_003CTryUploadSaveBackup_003Ed__48))]
		private Task<DoProfileBackup.Result> TryUploadSaveBackup(DoProfileBackup.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<DoProfileBackup.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E08")]
		[Cpp2IlInjected.Address(RVA = "0x13A2B60", Offset = "0x13A1560", VA = "0x1813A2B60")]
		[AsyncStateMachine(typeof(_003CCheckCustomerCareProfile_003Ed__50))]
		public Task<CustomerCareProfile.Result> CheckCustomerCareProfile()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<CustomerCareProfile.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E09")]
		[Cpp2IlInjected.Address(RVA = "0x13A2DB0", Offset = "0x13A17B0", VA = "0x1813A2DB0")]
		[AsyncStateMachine(typeof(_003CClearCustomerCareProfile_003Ed__51))]
		public Task<bool> ClearCustomerCareProfile()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E0A")]
		[Cpp2IlInjected.Address(RVA = "0x13A56B0", Offset = "0x13A40B0", VA = "0x1813A56B0")]
		[AsyncStateMachine(typeof(_003CSetupCustomerCareProfileRecover_003Ed__52))]
		public Task<bool> SetupCustomerCareProfileRecover(CustomerCareProfile.Data data)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E3A")]
		[Cpp2IlInjected.Address(RVA = "0x13A4230", Offset = "0x13A2C30", VA = "0x1813A4230")]
		public bool IsFullOnlineWithNativeRefresh(CancellationToken ct)
		{
			Client client = this.client;
			if (client != null && (long)client.NativeNetworkManager > 0)
			{
				Client client2 = this.client;
				if (client2 == null || client2.NativeNetworkManager != null)
				{
				}
				OnlineStatus onlineStatus = CurrentOnlineStatus;
				if (onlineStatus != (CurrentOnlineStatus = onlineStatus))
				{
					int error = 0;
					LogOnlineStatus("SetOnlineStatus", (byte)error != 0);
					ConnectionModeChanged onConnectionModeChanged = this.OnConnectionModeChanged;
					if (onConnectionModeChanged != null)
					{
						OnlineStatus currentOnlineStatus = CurrentOnlineStatus;
						onConnectionModeChanged(currentOnlineStatus, ct);
					}
				}
			}
			bool isInternetOn = IsInternetOn;
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E3B")]
		[Cpp2IlInjected.Address(RVA = "0x13A5600", Offset = "0x13A4000", VA = "0x1813A5600")]
		public void SetOnlineStatus(OnlineStatus flags, bool enable, CancellationToken ct, bool invokeOnlineStatusChangedCB = true)
		{
			OnlineStatus onlineStatus = CurrentOnlineStatus;
			if (enable)
			{
			}
			CurrentOnlineStatus = flags;
			if (onlineStatus != flags)
			{
				int error = 0;
				LogOnlineStatus("SetOnlineStatus", (byte)error != 0);
				ConnectionModeChanged onConnectionModeChanged = this.OnConnectionModeChanged;
				if (onConnectionModeChanged != null)
				{
					OnlineStatus currentOnlineStatus = CurrentOnlineStatus;
					onConnectionModeChanged(currentOnlineStatus, ct);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007E49")]
		[Cpp2IlInjected.Address(RVA = "0x13A7760", Offset = "0x13A6160", VA = "0x1813A7760")]
		public OnlineClient(Client client)
		{
			//Discarded unreachable code: IL_009d, IL_00ab
			//IL_0061: Expected O, but got I4
			SemaphoreSlim semaphoreSlim = (uploadProfileSemaphore = new SemaphoreSlim(1));
			TimeSpan backupConfigDataUpdateDelay = default(TimeSpan);
			BackupConfigDataUpdateDelay = backupConfigDataUpdateDelay;
			string entityId = default(string);
			string entityType = default(string);
			PlayFabAuthenticationContext playFabAuthenticationContext = (ExpiredAuthenticationContext = new PlayFabAuthenticationContext("25FBC92F2911BB53--248E6C0144DA332-24C55-8D849CCC41930BE-TePC3O+gnZugXnAtEyRGW1HZ3UzuF4Wu6mjdKabR0w4=", "M3x7ImkiOiIyMDIwLTA4LTI2VDE0OjMxOjQ4LjUwNjY0MzBaIiwiaWRwIjoiQ3VzdG9tIiwiZSI6IjIwMjAtMDgtMjdUMTQ6MzE6NDguNTA2NjQzMFoiLCJoIjoiNDYxRTU5NkE0OUZFOTczMCIsInMiOiIwT2R3cW5obGpTVGdTWnhlMDNjYURERjFzdnAzVUZXRTJuSXNaSE5BbmNZPSIsImVjIjoidGl0bGVfcGxheWVyX2FjY291bnQhOTU2RTJBN0UwNDJENUU3LzI0QzU1LzI1RkJDOTJGMjkxMUJCNTMvNzM1QTY3MUU4NEVEODZGMy8iLCJlaSI6IjczNUE2NzFFODRFRDg2RjMiLCJldCI6InRpdGxlX3BsYXllcl9hY2NvdW50In0=", "25FBC92F2911BB53", entityId, entityType));
			TimeSpan verifyPurchaseDelay = default(TimeSpan);
			VerifyPurchaseDelay = verifyPurchaseDelay;
			int num = 0;
			DateTime dateTime = (VerifyPurchaseLastCall = DateTime.MinValue);
			base.FieldSetter((string)num, "M3x7ImkiOiIyMDIwLTA4LTI2VDE0OjMxOjQ4LjUwNjY0MzBaIiwiaWRwIjoiQ3VzdG9tIiwiZSI6IjIwMjAtMDgtMjdUMTQ6MzE6NDguNTA2NjQzMFoiLCJoIjoiNDYxRTU5NkE0OUZFOTczMCIsInMiOiIwT2R3cW5obGpTVGdTWnhlMDNjYURERjFzdnAzVUZXRTJuSXNaSE5BbmNZPSIsImVjIjoidGl0bGVfcGxheWVyX2FjY291bnQhOTU2RTJBN0UwNDJENUU3LzI0QzU1LzI1RkJDOTJGMjkxMUJCNTMvNzM1QTY3MUU4NEVEODZGMy8iLCJlaSI6IjczNUE2NzFFODRFRDg2RjMiLCJldCI6InRpdGxlX3BsYXllcl9hY2NvdW50In0=", (object)"25FBC92F2911BB53");
			this.client = client;
			LoginHandler loginHandler = (this.loginHandler = new LoginHandler(this));
			ProfileConflictResolver profileConflictResolver = (this.profileConflictResolver = new ProfileConflictResolver(client));
			Dictionary<OnlineMgrType, BaseOnlineManager> dictionary = (Dictionary<OnlineMgrType, BaseOnlineManager>)(object)new Dictionary<TKey, TValue>();
			ConfigManager configManager = new ConfigManager(this);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007E4A")]
		[Cpp2IlInjected.Address(RVA = "0x13A4110", Offset = "0x13A2B10", VA = "0x1813A4110")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__191))]
		public Task Init(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E4B")]
		[Cpp2IlInjected.Address(RVA = "0x13A3FF0", Offset = "0x13A29F0", VA = "0x1813A3FF0")]
		[AsyncStateMachine(typeof(_003CInitPostSimulator_003Ed__192))]
		public Task InitPostSimulator(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E4C")]
		[Cpp2IlInjected.Address(RVA = "0x13A2ED0", Offset = "0x13A18D0", VA = "0x1813A2ED0")]
		public void Destroy()
		{
			//IL_0025: Expected O, but got I8
			//IL_003f: Expected O, but got I8
			CancellationTokenSource cancellationTokenSource = internetCheckCTS;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				internetCheckCTS.Dispose();
				internetCheckCTS = (CancellationTokenSource)0;
			}
			loginHandler?.Destroy();
			loginHandler = (LoginHandler)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007E4D")]
		[Cpp2IlInjected.Address(RVA = "0x13A4C50", Offset = "0x13A3650", VA = "0x1813A4C50")]
		[AsyncStateMachine(typeof(_003COnLocalProfileSaved_003Ed__194))]
		private Task OnLocalProfileSaved(byte[] jProfile, Profile profile, LocalProfileHolder.SaveFlags saveFlags)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E4E")]
		[Cpp2IlInjected.Address(RVA = "0x13A2C90", Offset = "0x13A1690", VA = "0x1813A2C90")]
		[AsyncStateMachine(typeof(_003CCheckInternetConnectionAsync_003Ed__195))]
		private Task CheckInternetConnectionAsync(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E51")]
		[Cpp2IlInjected.Address(RVA = "0x13A4780", Offset = "0x13A3180", VA = "0x1813A4780")]
		public void LogOnlineStatus(string msg, bool error)
		{
			//IL_001a: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			//IL_0066: Expected O, but got I4
			//IL_008f: Expected O, but got I4
			string[] array;
			string text5;
			while (true)
			{
				array = new string[5];
				bool isInternetOn = IsInternetOn;
				string text = $"[Online] {msg}: IsInternetOn={error}, ";
				if (text != null && text == null)
				{
					continue;
				}
				array[0] = text;
				bool isNativeInternetOn = IsNativeInternetOn;
				string text2 = $"IsNativeInternetOn={isNativeInternetOn}, ";
				if (text2 != null && text2 == null)
				{
					continue;
				}
				array[1] = text2;
				OnlineStatus onlineStatus = CurrentOnlineStatus;
				string text3 = $"PlayFabLoggedIn={onlineStatus}, ";
				if (text3 != null && text3 == null)
				{
					continue;
				}
				array[2] = text3;
				OnlineStatus onlineStatus2 = CurrentOnlineStatus;
				string text4 = $"PortalLoggedIn={onlineStatus2}, ";
				if (text4 == null || text4 != null)
				{
					array[3] = text4;
					Client client = this.client;
					IUnityContext _003CUnityContext_003Ek__BackingField = client.UnityContext;
					text5 = $"client.UnityContext.IsForcedOffline={client}";
					if (text5 == null || text5 != null)
					{
						break;
					}
				}
			}
			array[4] = text5;
			string text6 = string.Concat(array);
			Client client2 = this.client;
			if (!error)
			{
				Serilog.ILogger _003CLog_003Ek__BackingField = client2.Log;
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007E52")]
		[Cpp2IlInjected.Address(RVA = "0x13A31E0", Offset = "0x13A1BE0", VA = "0x1813A31E0")]
		[AsyncStateMachine(typeof(_003CEnsureOnlineSessionActive_003Ed__201))]
		public Task EnsureOnlineSessionActive(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E53")]
		[Cpp2IlInjected.Address(RVA = "0x13A5130", Offset = "0x13A3B30", VA = "0x1813A5130")]
		public Task<bool> RefreshNativeInternetAvailability(CancellationToken ct)
		{
			//Discarded unreachable code: IL_0038
			Client client = this.client;
			if (client != null && (long)client.NativeNetworkManager > 0)
			{
				TestInternetInfo testInternetInfo = new TestInternetInfo();
				testInternetInfo.PromptOnError = false;
				return (Task<bool>)(object)this.ReconnectToInternet(testInternetInfo, ct);
			}
			return (Task<bool>)(object)Task.FromResult(IsInternetOn);
		}

		[Cpp2IlInjected.Token(Token = "0x6007E54")]
		[Cpp2IlInjected.Address(RVA = "0x13A4DA0", Offset = "0x13A37A0", VA = "0x1813A4DA0")]
		public Task<bool> ReconnectToInternetNoTest(CancellationToken ct)
		{
			//IL_000a: Expected O, but got I4
			int num = 0;
			return (Task<bool>)(object)this.ReconnectToInternet((TestInternetInfo)num, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007E55")]
		[Cpp2IlInjected.Address(RVA = "0x13A4DB0", Offset = "0x13A37B0", VA = "0x1813A4DB0")]
		[AsyncStateMachine(typeof(_003CReconnectToInternet_003Ed__205))]
		public Task<bool> ReconnectToInternet(TestInternetInfo testInternetInfo, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E56")]
		[Cpp2IlInjected.Address(RVA = "0x13A5030", Offset = "0x13A3A30", VA = "0x1813A5030")]
		private bool RefreshInternetStatusNative(CancellationToken ct)
		{
			Client client = this.client;
			if (client != null && (long)client.NativeNetworkManager > 0)
			{
				Client client2 = this.client;
				if (client2 == null || client2.NativeNetworkManager != null)
				{
				}
				OnlineStatus onlineStatus = CurrentOnlineStatus;
				if (onlineStatus != (CurrentOnlineStatus = onlineStatus))
				{
					int error = 0;
					LogOnlineStatus("SetOnlineStatus", (byte)error != 0);
					ConnectionModeChanged onConnectionModeChanged = this.OnConnectionModeChanged;
					if (onConnectionModeChanged != null)
					{
						OnlineStatus currentOnlineStatus = CurrentOnlineStatus;
						onConnectionModeChanged(currentOnlineStatus, ct);
					}
				}
			}
			return IsInternetOn;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E57")]
		[Cpp2IlInjected.Address(RVA = "0x13A4F10", Offset = "0x13A3910", VA = "0x1813A4F10")]
		[AsyncStateMachine(typeof(_003CRefreshInternetAvailability_003Ed__207))]
		private Task RefreshInternetAvailability(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E58")]
		[Cpp2IlInjected.Address(RVA = "0x13A6290", Offset = "0x13A4C90", VA = "0x1813A6290")]
		public Task<AskForLoginResult> TryAskForLogin(CancellationToken ct, bool skipPermission = false, bool forceLogout = false, bool useBubbleText = true)
		{
			//IL_0049: Expected I4, but got I8
			//IL_005e: Expected I4, but got I8
			//IL_006b: Expected I4, but got I8
			if (IsInitialized)
			{
				if (!loginInProgress)
				{
					OnlineStatus onlineStatus = CurrentOnlineStatus;
					int num = (int)onlineStatus;
					if ((forceLogout ? 1 : 0) != num)
					{
						LoginHandler.LogoutResult logoutResult = TryLogout(ct);
					}
					if (onlineStatus != (OnlineStatus.PlayFabLoggedIn | OnlineStatus.PortalLoggedIn))
					{
						int num2 = 0;
						AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
						int num3 = 0;
					}
					AskForLoginResult askForLoginResult = new AskForLoginResult();
					askForLoginResult.Result = Result.AlreadyLoggedIn;
					return (Task<AskForLoginResult>)(object)Task.FromResult(askForLoginResult);
				}
				new AskForLoginResult().Result = Result.LoginInProgress;
			}
			new AskForLoginResult().Result = Result.NotInitialized;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007E59")]
		[Cpp2IlInjected.Address(RVA = "0x13A3E60", Offset = "0x13A2860", VA = "0x1813A3E60")]
		public string GetOnlineStatusSourceNameForLoc()
		{
			if (IsInternetOn)
			{
				OnlineStatus onlineStatus = CurrentOnlineStatus;
				if (onlineStatus != OnlineStatus.InternetOn)
				{
					string result = "portal";
					if (onlineStatus != OnlineStatus.InternetOn)
					{
						result = "unknown";
					}
					return result;
				}
				return "playfab";
			}
			return "internet";
		}

		[Cpp2IlInjected.Token(Token = "0x6007E5A")]
		[Cpp2IlInjected.Address(RVA = "0x13A3C60", Offset = "0x13A2660", VA = "0x1813A3C60")]
		private (string, string) GetLoginRequestLocIds()
		{
			string text = default(string);
			string text2 = "online.login_request_" + text + "_desc";
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E5B")]
		[Cpp2IlInjected.Address(RVA = "0x13A3B30", Offset = "0x13A2530", VA = "0x1813A3B30")]
		private (string, string) GetConnectivityIssueLocIds()
		{
			string text = default(string);
			string text2 = "online.login_connectivity_issue_" + text + "_title";
			string text3 = "online.login_connectivity_issue_" + text + "_desc";
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E5C")]
		[Cpp2IlInjected.Address(RVA = "0x13A3C00", Offset = "0x13A2600", VA = "0x1813A3C00")]
		public string GetLoginErrorMessageLocId()
		{
			string onlineStatusSourceNameForLoc = GetOnlineStatusSourceNameForLoc();
			return "online.login_connect_" + onlineStatusSourceNameForLoc + "_error";
		}

		[Cpp2IlInjected.Token(Token = "0x6007E5D")]
		[Cpp2IlInjected.Address(RVA = "0x13A57F0", Offset = "0x13A41F0", VA = "0x1813A57F0")]
		[AsyncStateMachine(typeof(_003CShowAskForConnectPrompt_003Ed__213))]
		public Task<bool> ShowAskForConnectPrompt([Optional] string titleLocId, [Optional] string messageLocId, [Optional] string subtitle)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E5E")]
		[Cpp2IlInjected.Address(RVA = "0x13A2990", Offset = "0x13A1390", VA = "0x1813A2990")]
		[AsyncStateMachine(typeof(_003CAskForLogin_003Ed__215))]
		private Task<AskForLoginResult> AskForLogin(string titleLocId, string messageLocId, CancellationToken ct, bool skipPermission = false, bool useBubbleText = true)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<AskForLoginResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E5F")]
		[Cpp2IlInjected.Address(RVA = "0x13A2B10", Offset = "0x13A1510", VA = "0x1813A2B10")]
		public void AskForLogout(CancellationToken ct)
		{
			LoginHandler.LogoutResult logoutResult = TryLogout(ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007E60")]
		[Cpp2IlInjected.Address(RVA = "0x13A2B20", Offset = "0x13A1520", VA = "0x1813A2B20")]
		public void CHEATDEBUG_LogoutFromPlayFab(CancellationToken ct)
		{
			loginHandler?.CHEAT_LogoutFromPlayFab(ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007E61")]
		[Cpp2IlInjected.Address(RVA = "0x13A2B40", Offset = "0x13A1540", VA = "0x1813A2B40")]
		public void CHEATDEBUG_LogoutFromPortal(CancellationToken ct)
		{
			loginHandler?.LogoutFromPortal(ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6007E62")]
		[Cpp2IlInjected.Address(RVA = "0x13A74E0", Offset = "0x13A5EE0", VA = "0x1813A74E0")]
		private void UpdateConnectionMode(string locInfoMsg, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0035
			client.ShowInfoMessage(locInfoMsg);
			int error = 0;
			LogOnlineStatus("UpdateConnectionMode", (byte)error != 0);
			ConnectionModeChanged onConnectionModeChanged = this.OnConnectionModeChanged;
			if (onConnectionModeChanged != null)
			{
				OnlineStatus currentOnlineStatus = CurrentOnlineStatus;
				onConnectionModeChanged(currentOnlineStatus, ct);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007E63")]
		[Cpp2IlInjected.Address(RVA = "0x13A3950", Offset = "0x13A2350", VA = "0x1813A3950")]
		[AsyncStateMachine(typeof(_003CForceRelogin_003Ed__220))]
		public Task<bool> ForceRelogin(LoginRequestParams loginRequestParams, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E64")]
		[Cpp2IlInjected.Address(RVA = "0x13A6540", Offset = "0x13A4F40", VA = "0x1813A6540")]
		[AsyncStateMachine(typeof(_003CTryLogin_003Ed__221))]
		private Task<bool> TryLogin(LoginRequestParams loginRequestParams, CancellationToken ct, bool retryOnError = false, bool useBubbleTextOnFailure = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E65")]
		[Cpp2IlInjected.Address(RVA = "0x13A54D0", Offset = "0x13A3ED0", VA = "0x1813A54D0")]
		[AsyncStateMachine(typeof(_003CResolveProfileConflicts_003Ed__222))]
		private Task ResolveProfileConflicts(LoginRequestParams loginRequestParams, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E66")]
		[Cpp2IlInjected.Address(RVA = "0x13A66C0", Offset = "0x13A50C0", VA = "0x1813A66C0")]
		private LoginHandler.LogoutResult TryLogout(CancellationToken ct)
		{
			//IL_002c: Expected O, but got I4
			//IL_0038: Expected O, but got I4
			//IL_0043: Expected O, but got I4
			//IL_004b: Expected O, but got I4
			//IL_005b: Expected O, but got I4
			LoginHandler.LogoutResult logoutResult = loginHandler.TryLogout(ct);
			int num = (int)logoutResult;
			bool flag = logoutResult == LoginHandler.LogoutResult.Success;
			if (logoutResult == LoginHandler.LogoutResult.AlreadyLoggedOut)
			{
				if (this.client != null)
				{
				}
				string text = $"[Online] TryLogout - Player failed to logout with following result => {logoutResult}";
			}
			int num2 = 0;
			lastProfileVersion = (int?)(object)num2;
			int num3 = 0;
			lastMiniProfileChecksum = (string)num3;
			lastProfileChecksum = (string)num3;
			ProfileConflictResolver profileConflictResolver = this.profileConflictResolver;
			LastUploadTime = (DateTime)num3;
			profileConflictResolver.GoOffline();
			OnlineStatus onlineStatus = CurrentOnlineStatus;
			if (onlineStatus != (CurrentOnlineStatus = onlineStatus))
			{
				int error = 0;
				LogOnlineStatus("SetOnlineStatus", (byte)error != 0);
				ConnectionModeChanged onConnectionModeChanged = this.OnConnectionModeChanged;
				if (onConnectionModeChanged != null)
				{
					OnlineStatus currentOnlineStatus = CurrentOnlineStatus;
					onConnectionModeChanged(currentOnlineStatus, ct);
				}
			}
			Client client = this.client;
			if (!flag)
			{
				Serilog.ILogger _003CLog_003Ek__BackingField = client.Log;
			}
			Serilog.ILogger _003CLog_003Ek__BackingField2 = client.Log;
			OnlineConnectionChanged onOnlineConnectionChanged = this.OnOnlineConnectionChanged;
			if (onOnlineConnectionChanged != null)
			{
				Profile profile = this.client.profile;
				int isLoggedIn = 0;
				onOnlineConnectionChanged(profile, (byte)isLoggedIn != 0, ct);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007E67")]
		[Cpp2IlInjected.Address(RVA = "0x13A7570", Offset = "0x13A5F70", VA = "0x1813A7570")]
		[AsyncStateMachine(typeof(_003CUpdateSessionToken_003Ed__224))]
		public Task<bool> UpdateSessionToken([Optional] string fakeSessionToken)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E68")]
		[Cpp2IlInjected.Address(RVA = "0x13A5970", Offset = "0x13A4370", VA = "0x1813A5970")]
		public void SimulateSessionTicketExpiration()
		{
			//Discarded unreachable code: IL_0162
			while (true)
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler == null)
				{
					break;
				}
				ClientSession clientSession = loginHandler.clientSession;
				if (clientSession == null)
				{
					break;
				}
				PlayFabAuthenticationInstanceAPI playFabAuthenticationInstanceAPI = clientSession.auth;
				if (playFabAuthenticationInstanceAPI == null)
				{
					break;
				}
				PlayFabAuthenticationContext authenticationContext = playFabAuthenticationInstanceAPI.authenticationContext;
				if (authenticationContext != null)
				{
					PlayFabAuthenticationContext expiredAuthenticationContext = ExpiredAuthenticationContext;
					authenticationContext.CopyFrom(expiredAuthenticationContext);
				}
				PlayFabDataInstanceAPI playFabDataInstanceAPI = loginHandler.clientSession.data;
				if (playFabDataInstanceAPI == null)
				{
					continue;
				}
				PlayFabAuthenticationContext authenticationContext2 = playFabDataInstanceAPI.authenticationContext;
				if (authenticationContext2 == null)
				{
					continue;
				}
				PlayFabAuthenticationContext expiredAuthenticationContext2 = ExpiredAuthenticationContext;
				authenticationContext2.CopyFrom(expiredAuthenticationContext2);
				PlayFabEconomyInstanceAPI playFabEconomyInstanceAPI = this.loginHandler.clientSession.economy;
				if (playFabEconomyInstanceAPI == null)
				{
					continue;
				}
				PlayFabAuthenticationContext authenticationContext3 = playFabEconomyInstanceAPI.authenticationContext;
				if (authenticationContext3 == null)
				{
					continue;
				}
				PlayFabAuthenticationContext expiredAuthenticationContext3 = ExpiredAuthenticationContext;
				authenticationContext3.CopyFrom(expiredAuthenticationContext3);
				PlayFabCloudScriptInstanceAPI playFabCloudScriptInstanceAPI = this.loginHandler.clientSession.cloudscript;
				if (playFabCloudScriptInstanceAPI == null)
				{
					continue;
				}
				PlayFabAuthenticationContext authenticationContext4 = playFabCloudScriptInstanceAPI.authenticationContext;
				if (authenticationContext4 == null)
				{
					continue;
				}
				PlayFabAuthenticationContext expiredAuthenticationContext4 = ExpiredAuthenticationContext;
				authenticationContext4.CopyFrom(expiredAuthenticationContext4);
				PlayFabLeaderboardsInstanceAPI leaderboards = this.loginHandler.clientSession.leaderboards;
				if (leaderboards == null)
				{
					continue;
				}
				PlayFabAuthenticationContext authenticationContext5 = leaderboards.authenticationContext;
				if (authenticationContext5 == null)
				{
					continue;
				}
				PlayFabAuthenticationContext expiredAuthenticationContext5 = ExpiredAuthenticationContext;
				authenticationContext5.CopyFrom(expiredAuthenticationContext5);
				PlayFabProfilesInstanceAPI playFabProfilesInstanceAPI = this.loginHandler.clientSession.profiles;
				if (playFabProfilesInstanceAPI != null)
				{
					PlayFabAuthenticationContext authenticationContext6 = playFabProfilesInstanceAPI.authenticationContext;
					if (authenticationContext6 != null)
					{
						PlayFabAuthenticationContext expiredAuthenticationContext6 = ExpiredAuthenticationContext;
						authenticationContext6.CopyFrom(expiredAuthenticationContext6);
					}
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007E69")]
		[Cpp2IlInjected.Address(RVA = "0x13A33F0", Offset = "0x13A1DF0", VA = "0x1813A33F0")]
		[AsyncStateMachine(typeof(_003CFetchOnlineData_003Ed__227))]
		public Task FetchOnlineData(bool forceSave, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E6A")]
		[Cpp2IlInjected.Address(RVA = "0x13A52C0", Offset = "0x13A3CC0", VA = "0x1813A52C0")]
		public Task<UserAccountInfo> RefreshUserAccountInfo(CancellationToken ct)
		{
			//Discarded unreachable code: IL_0022
			//IL_0021: Expected O, but got I4
			if (CurrentOnlineStatus != OnlineStatus.InternetOn)
			{
				return (Task<UserAccountInfo>)(object)loginHandler.clientSession.RefreshUserAccountInfo(ct);
			}
			return (Task<UserAccountInfo>)(object)Task.FromResult((UserAccountInfo)0);
		}

		[Cpp2IlInjected.Token(Token = "0x6007E6B")]
		[Cpp2IlInjected.Address(RVA = "0x13A5220", Offset = "0x13A3C20", VA = "0x1813A5220")]
		public Task RefreshPlayerProfileModel(CancellationToken ct)
		{
			//Discarded unreachable code: IL_0023
			if (CurrentOnlineStatus != OnlineStatus.InternetOn)
			{
				Task<PlayerProfileModel> task = (Task<PlayerProfileModel>)(object)loginHandler.clientSession.RefreshPlayerProfileModel(ct);
			}
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E6C")]
		[Cpp2IlInjected.Address(RVA = "0x13A3F00", Offset = "0x13A2900", VA = "0x1813A3F00")]
		public ContactEmailInfoModel GetRegisteredEmail()
		{
			LoginHandler loginHandler = this.loginHandler;
			if (loginHandler != null)
			{
				ClientSession clientSession = loginHandler.clientSession;
				if (clientSession != null && clientSession.PlayerProfileModel == null)
				{
				}
			}
			if (false && (long)(IntPtr)loginHandler > 0L)
			{
				if (loginHandler == null)
				{
					int num = 0;
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				IRedeemer redeemer = loginHandler.EconomyManager.redeemer;
				if (loginHandler == null)
				{
					int num2 = 0;
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
					EconomyManager _003CEconomyManager_003Ek__BackingField = loginHandler.EconomyManager;
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007E6D")]
		[Cpp2IlInjected.Address(RVA = "0x13A2F50", Offset = "0x13A1950", VA = "0x1813A2F50")]
		public Task EconomyVerifyPurchasewWithDelayAsync(CancellationToken ct)
		{
			//Discarded unreachable code: IL_00c9
			//IL_007e: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			if (CurrentOnlineStatus == OnlineStatus.FullOnline)
			{
				LoginHandler loginHandler = this.loginHandler;
				if (loginHandler != null && (long)loginHandler.EconomyManager != 0)
				{
					int num = 0;
					DateTime utcNow = DateTime.UtcNow;
					DateTime verifyPurchaseLastCall = VerifyPurchaseLastCall;
					TimeSpan timeSpan = utcNow - verifyPurchaseLastCall;
					TimeSpan verifyPurchaseDelay = VerifyPurchaseDelay;
					bool flag = timeSpan > verifyPurchaseDelay;
					Client client = this.client;
					if (!flag)
					{
						if (client != null)
						{
						}
						int num2 = 0;
						TimeSpan verifyPurchaseDelay2 = VerifyPurchaseDelay;
						string text = $"EconomyVerifyPurchasewWithDelayAsync skipped because of delay of {flag} is lower then {flag}";
					}
					Serilog.ILogger _003CLog_003Ek__BackingField = client.Log;
					LoginHandler loginHandler2 = this.loginHandler;
					VerifyPurchaseLastCall = utcNow;
					return loginHandler2.EconomyManager.VerifyPurchaseAsync(ct);
				}
				Serilog.ILogger _003CLog_003Ek__BackingField2 = this.client.Log;
			}
			Serilog.ILogger _003CLog_003Ek__BackingField3 = this.client.Log;
			int num3 = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6007E6E")]
		[Cpp2IlInjected.Address(RVA = "0x13A76B0", Offset = "0x13A60B0", VA = "0x1813A76B0")]
		static OnlineClient()
		{
			ProfileFilename = DisneyPlayFabContext.MiniProfileFilename;
			/*Error: Unexpected end of block*/;
		}
	}
}
