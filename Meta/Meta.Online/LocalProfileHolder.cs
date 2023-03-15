using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using glPlayFab;
using Google.Protobuf.WellKnownTypes;
using Meta.Util;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F40")]
	public class LocalProfileHolder : IProfileHolder
	{
		[Cpp2IlInjected.Token(Token = "0x2000F41")]
		[Flags]
		public enum SaveFlags
		{
			[Cpp2IlInjected.Token(Token = "0x4003E55")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4003E56")]
			OnExit = 1,
			[Cpp2IlInjected.Token(Token = "0x4003E57")]
			NoUpload = 2
		}

		[Cpp2IlInjected.Token(Token = "0x2000F42")]
		public delegate void LocalProfileDeleted();

		[Cpp2IlInjected.Token(Token = "0x2000F43")]
		public delegate Task LocalProfileSaved(byte[] jProfile, Profile profile, SaveFlags saveFlags);

		[Cpp2IlInjected.Token(Token = "0x2000F44")]
		private struct Scope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003E58")]
			private readonly LocalProfileHolder localProfileHolder;

			[Cpp2IlInjected.Token(Token = "0x6007D26")]
			[Cpp2IlInjected.Address(RVA = "0x11EF810", Offset = "0x11EE210", VA = "0x1811EF810")]
			public Scope(LocalProfileHolder localProfileHolder)
			{
				//Discarded unreachable code: IL_000e
				this.localProfileHolder = localProfileHolder;
				localProfileHolder.BeginIgnoreSave();
			}

			[Cpp2IlInjected.Token(Token = "0x6007D27")]
			[Cpp2IlInjected.Address(RVA = "0x11EF7F0", Offset = "0x11EE1F0", VA = "0x1811EF7F0", Slot = "4")]
			public void Dispose()
			{
			}//Discarded unreachable code: IL_0001

		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003E47")]
		private readonly Client client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003E4A")]
		private ConcurrentStack<Profile> ProfilesToSave = (ConcurrentStack<Profile>)(object)new ConcurrentStack<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003E4B")]
		private Task _SaveTaskThreaded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003E4C")]
		private Profile profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003E50")]
		private bool ignoreSave;

		[Cpp2IlInjected.Token(Token = "0x170015B7")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4003E48")]
		public bool IsDelayingWrite
		{
			[Cpp2IlInjected.Token(Token = "0x6007CF2")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007CF3")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170015B8")]
		public IWritableDisplayer ProgressDisplayer
		{
			[Cpp2IlInjected.Token(Token = "0x6007CF4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CProgressDisplayer_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007CF5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CProgressDisplayer_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015B9")]
		public Profile Profile
		{
			[Cpp2IlInjected.Token(Token = "0x6007CF6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "4")]
			get
			{
				return profile;
			}
			[Cpp2IlInjected.Token(Token = "0x6007CF7")]
			[Cpp2IlInjected.Address(RVA = "0x18AF710", Offset = "0x18AE110", VA = "0x1818AF710", Slot = "5")]
			set
			{
				profile = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015BA")]
		public IFileSystem FileSystem
		{
			[Cpp2IlInjected.Token(Token = "0x6007CF8")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CFileSystem_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007CF9")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			private set
			{
				_003CFileSystem_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015BB")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x4003E4E")]
		public string FullProfilePath
		{
			[Cpp2IlInjected.Token(Token = "0x6007CFA")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170015BC")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x50"), Cpp2IlInjected.Token(Token = "0x4003E4F")]
		public DeviceInfo CurrentDeviceInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6007CFB")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170015BD")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x60"), Cpp2IlInjected.Token(Token = "0x4003E51")]
		public DateTime LastSavedDate
		{
			[Cpp2IlInjected.Token(Token = "0x6007CFC")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007CFD")]
			[Cpp2IlInjected.Address(RVA = "0x1542C90", Offset = "0x1541690", VA = "0x181542C90")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170015BE")]
		public static string NewProfilePath
		{
			[Cpp2IlInjected.Token(Token = "0x6007D03")]
			[Cpp2IlInjected.Address(RVA = "0x18AF490", Offset = "0x18ADE90", VA = "0x1818AF490")]
			get
			{
				//Discarded unreachable code: IL_0050
				int num = 0;
				if (!string.IsNullOrEmpty(DebugSettings.Settings.playfabProfileSlot_))
				{
					int num2 = 0;
					return DebugSettings.Settings.playfabProfileSlot_;
				}
				int num3 = 0;
				if (!string.IsNullOrEmpty(DebugSettings.Settings.profileSlot_))
				{
					int num4 = 0;
					return DebugSettings.Settings.profileSlot_;
				}
				int num5 = 0;
				return ServerConfig.Instance.defaultProfilePath_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015BF")]
		private bool IsSavingThreadRunning
		{
			[Cpp2IlInjected.Token(Token = "0x6007D0F")]
			[Cpp2IlInjected.Address(RVA = "0x18AF430", Offset = "0x18ADE30", VA = "0x1818AF430")]
			get
			{
				Task saveTaskThreaded = _SaveTaskThreaded;
				if (saveTaskThreaded != null && !saveTaskThreaded.IsCompleted && !_SaveTaskThreaded.IsFaulted)
				{
					return !_SaveTaskThreaded.IsCanceled;
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015C0")]
		public static bool IsPrettyJson
		{
			[Cpp2IlInjected.Token(Token = "0x6007D15")]
			[Cpp2IlInjected.Address(RVA = "0x18AF3F0", Offset = "0x18ADDF0", VA = "0x1818AF3F0")]
			get
			{
				return App.IsEditor;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400009F")]
		public event LocalProfileDeleted OnLocalProfileDeleted
		{
			[Cpp2IlInjected.Token(Token = "0x6007CFE")]
			[Cpp2IlInjected.Address(RVA = "0x18AF2B0", Offset = "0x18ADCB0", VA = "0x1818AF2B0")]
			[CompilerGenerated]
			add
			{
				LocalProfileDeleted onLocalProfileDeleted = this.OnLocalProfileDeleted;
				Delegate @delegate = Delegate.Combine(onLocalProfileDeleted, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onLocalProfileDeleted)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6007CFF")]
			[Cpp2IlInjected.Address(RVA = "0x18AF5D0", Offset = "0x18ADFD0", VA = "0x1818AF5D0")]
			[CompilerGenerated]
			remove
			{
				LocalProfileDeleted onLocalProfileDeleted = this.OnLocalProfileDeleted;
				Delegate @delegate = Delegate.Remove(onLocalProfileDeleted, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onLocalProfileDeleted)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x140000A0")]
		public event LocalProfileSaved OnLocalProfileSaved
		{
			[Cpp2IlInjected.Token(Token = "0x6007D00")]
			[Cpp2IlInjected.Address(RVA = "0x18AF350", Offset = "0x18ADD50", VA = "0x1818AF350")]
			[CompilerGenerated]
			add
			{
				LocalProfileSaved onLocalProfileSaved = this.OnLocalProfileSaved;
				Delegate @delegate = Delegate.Combine(onLocalProfileSaved, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onLocalProfileSaved)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6007D01")]
			[Cpp2IlInjected.Address(RVA = "0x18AF670", Offset = "0x18AE070", VA = "0x1818AF670")]
			[CompilerGenerated]
			remove
			{
				LocalProfileSaved onLocalProfileSaved = this.OnLocalProfileSaved;
				Delegate @delegate = Delegate.Remove(onLocalProfileSaved, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onLocalProfileSaved)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007D02")]
		[Cpp2IlInjected.Address(RVA = "0x18AF1C0", Offset = "0x18ADBC0", VA = "0x1818AF1C0")]
		public LocalProfileHolder(Client client, IFileSystem filesystem, string profilePath, DeviceInfo info, bool isDelayingWrite)
		{
			//IL_002f: Expected O, but got I4
			this.client = client;
			FileSystem = filesystem;
			FullProfilePath = profilePath;
			CurrentDeviceInfo = (DeviceInfo)0;
			IsDelayingWrite = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6007D04")]
		[Cpp2IlInjected.Address(RVA = "0x18AE100", Offset = "0x18ACB00", VA = "0x1818AE100", Slot = "6")]
		public void Reset(Func<Profile, ITransactionContext> createTransactionContext, ProfileEventDispatcher dispatcher, bool actualize)
		{
			//Discarded unreachable code: IL_00a2
			//IL_007f: Expected I4, but got I8
			int num = 0;
			DebugSettings settings = DebugSettings.Settings;
			string playfabProfileSlot_ = settings.playfabProfileSlot_;
			if (settings == null)
			{
				int num2 = 0;
				DebugSettings settings2 = DebugSettings.Settings;
			}
			int num3 = 0;
			DebugSettings settings3 = DebugSettings.Settings;
			string profileSlot_ = settings3.profileSlot_;
			if (settings3 == null)
			{
				int num4 = 0;
				DebugSettings settings4 = DebugSettings.Settings;
			}
			int num5 = 0;
			string defaultProfilePath_ = ServerConfig.Instance.defaultProfilePath_;
			DeviceInfo info = CurrentDeviceInfo;
			Profile profile = (this.profile = ProfileUtil.NewProfile(defaultProfilePath_, info));
			Profile profile2 = this.profile;
			if (profile2 != null)
			{
				profile2.ProfileLocation = Profile.Location.SimulatorClient;
			}
			if (actualize)
			{
				Profile profile3 = this.profile;
				ITransactionContext transactionContext = (ITransactionContext)createTransactionContext((T)profile3);
				InitProfileResult initProfileResult = profile3.InitAndActualize(transactionContext, dispatcher);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007D05")]
		[Cpp2IlInjected.Address(RVA = "0x18AD250", Offset = "0x18ABC50", VA = "0x1818AD250")]
		public void DeleteProfileFile()
		{
			//Discarded unreachable code: IL_0070
			//IL_005b: Expected I4, but got I8
			IFileSystem fileSystem = FileSystem;
			LocalStorage _003CLocalStorage_003Ek__BackingField = client.LocalStorage;
			if (_003CLocalStorage_003Ek__BackingField != null && (long)((LocalStorageData)((BaseStorage<DataType>)(object)_003CLocalStorage_003Ek__BackingField).Data).User.ProfileInfo.MiniProfile != 0)
			{
				LocalStorageData.ProfileInfo _003CProfileInfo_003Ek__BackingField = ((LocalStorageData)((BaseStorage<DataType>)(object)_003CLocalStorage_003Ek__BackingField).Data).User.ProfileInfo;
				LocalStorageData.ProfileInfo _003CProfileInfo_003Ek__BackingField2 = ((LocalStorageData)((BaseStorage<DataType>)(object)_003CLocalStorage_003Ek__BackingField).Data).User.ProfileInfo;
				ulong num = default(ulong);
				((BaseStorage<DataType>)(object)_003CLocalStorage_003Ek__BackingField).Save((byte)num != 0);
			}
			this.OnLocalProfileDeleted?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6007D06")]
		[Cpp2IlInjected.Address(RVA = "0x18AD530", Offset = "0x18ABF30", VA = "0x1818AD530")]
		public bool HasLocalProfile()
		{
			IFileSystem fileSystem = FileSystem;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007D07")]
		[Cpp2IlInjected.Address(RVA = "0x18AD5E0", Offset = "0x18ABFE0", VA = "0x1818AD5E0")]
		public string LoadProfileAsStr()
		{
			//Discarded unreachable code: IL_002b
			IFileSystem fileSystem = FileSystem;
			if ((object)typeof(IReadOnlyFileSystem).TypeHandle != null)
			{
				IFileSystem self = FileSystem;
				string path = FullProfilePath;
				return self.ReadAllText(path);
			}
			return string.Empty;
		}

		[Cpp2IlInjected.Token(Token = "0x6007D08")]
		[Cpp2IlInjected.Address(RVA = "0x18AD780", Offset = "0x18AC180", VA = "0x1818AD780")]
		public byte[] LoadProfileToCompressedBuffer()
		{
			//Discarded unreachable code: IL_003a
			IFileSystem fileSystem = FileSystem;
			if ((object)typeof(IReadOnlyFileSystem).TypeHandle == null)
			{
				int num = 0;
			}
			IFileSystem self = FileSystem;
			string path = FullProfilePath;
			byte[] data = self.ReadAllBytes(path);
			string profileFilename = DisneyPlayFabContext.ProfileFilename;
			return glPlayFab.Compression.CompressZip(data, profileFilename);
		}

		[Cpp2IlInjected.Token(Token = "0x6007D09")]
		[Cpp2IlInjected.Address(RVA = "0x18AD6B0", Offset = "0x18AC0B0", VA = "0x1818AD6B0")]
		public LoadProfileResult LoadProfileFile()
		{
			//Discarded unreachable code: IL_0032
			IFileSystem fs = FileSystem;
			string profilePath = FullProfilePath;
			int num = 0;
			ServerConfig instance = ServerConfig.Instance;
			DeviceInfo info = CurrentDeviceInfo;
			string defaultProfilePath_ = instance.defaultProfilePath_;
			return ProfileUtil.LoadOrCreateProfile(fs, profilePath, defaultProfilePath_, info);
		}

		[Cpp2IlInjected.Token(Token = "0x6007D0A")]
		[Cpp2IlInjected.Address(RVA = "0x18ADE30", Offset = "0x18AC830", VA = "0x1818ADE30", Slot = "7")]
		public Task<Profile> Reset(Func<Profile, ITransactionContext> createTransactionContext, ProfileEventDispatcher dispatcher, TimeSpan playerTimeZoneOffset, DeviceInfo deviceInfo, bool isDev, CancellationToken ct)
		{
			//Discarded unreachable code: IL_00e4
			//IL_005b: Expected I4, but got I8
			//IL_0084: Expected O, but got I4
			//IL_0084: Expected O, but got I4
			//IL_008d: Expected I4, but got I8
			IFileSystem fileSystem = FileSystem;
			LocalStorage _003CLocalStorage_003Ek__BackingField = client.LocalStorage;
			if (_003CLocalStorage_003Ek__BackingField != null && (long)((LocalStorageData)((BaseStorage<DataType>)(object)_003CLocalStorage_003Ek__BackingField).Data).User.ProfileInfo.MiniProfile != 0)
			{
				LocalStorageData.ProfileInfo _003CProfileInfo_003Ek__BackingField = ((LocalStorageData)((BaseStorage<DataType>)(object)_003CLocalStorage_003Ek__BackingField).Data).User.ProfileInfo;
				LocalStorageData.ProfileInfo _003CProfileInfo_003Ek__BackingField2 = ((LocalStorageData)((BaseStorage<DataType>)(object)_003CLocalStorage_003Ek__BackingField).Data).User.ProfileInfo;
				ulong num = default(ulong);
				((BaseStorage<DataType>)(object)_003CLocalStorage_003Ek__BackingField).Save((byte)num != 0);
			}
			this.OnLocalProfileDeleted?.Invoke();
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			this.Reset((Func<, >)num4, (ProfileEventDispatcher)num3, (byte)num2 != 0);
			ulong num5 = default(ulong);
			SetupTimeZoneOffset(playerTimeZoneOffset, (byte)num5 != 0);
			ProfileGameInfo gameInfo_ = this.profile.gameInfo_;
			ProfileSettings settings_ = this.profile.settings_;
			bool flag = (settings_.isDev_ = settings_ != null);
			Profile profile = this.profile;
			ITransactionContext transactionContext = (ITransactionContext)createTransactionContext((T)profile);
			InitProfileResult initProfileResult = profile.InitAndActualize(transactionContext, dispatcher);
			return (Task<Profile>)(object)Task.FromResult(this.profile);
		}

		[Cpp2IlInjected.Token(Token = "0x6007D0B")]
		[Cpp2IlInjected.Address(RVA = "0x18AEF00", Offset = "0x18AD900", VA = "0x1818AEF00")]
		private void SyncProfileOnlineVersionOnLoad(Profile profile)
		{
			//Discarded unreachable code: IL_011c
			//IL_00e0: Expected O, but got I4
			//IL_00e0: Expected O, but got I4
			if (this.client.HasSuccessfulyUpdateOnlineVersionInThisSession)
			{
				Profile profile2 = this.profile;
				ProfileGameInfo profileGameInfo = default(ProfileGameInfo);
				int onlineVersion_ = profileGameInfo.onlineVersion_;
				int previousOnlineVersion = this.client.PreviousOnlineVersion;
				if (onlineVersion_ == previousOnlineVersion)
				{
					Profile profile3 = this.profile;
					Client client = this.client;
					ProfileGameInfo gameInfo_ = profile3.gameInfo_;
					int num = (gameInfo_.onlineVersion_ = client.UpdatedOnlineVersion);
				}
			}
			LocalStorage _003CLocalStorage_003Ek__BackingField = this.client.LocalStorage;
			if (_003CLocalStorage_003Ek__BackingField == null)
			{
				return;
			}
			MiniProfile _003CMiniProfile_003Ek__BackingField = ((LocalStorageData)((BaseStorage<DataType>)(object)_003CLocalStorage_003Ek__BackingField).Data).User.ProfileInfo.MiniProfile;
			if (_003CMiniProfile_003Ek__BackingField != null)
			{
				ProfileGameInfo gameInfo_2 = this.profile.gameInfo_;
				int onlineVersion_2 = _003CMiniProfile_003Ek__BackingField.gameInfo_.onlineVersion_;
				if (gameInfo_2.onlineVersion_ < onlineVersion_2)
				{
					int onlineVersion_3 = this.profile.gameInfo_.onlineVersion_;
					int onlineVersion_4 = _003CMiniProfile_003Ek__BackingField.gameInfo_.onlineVersion_;
					string text = $"Profile OnlineVersion={onlineVersion_2} was lower then MiniProfile.OnlineVersion={onlineVersion_2}";
					ProfileGameInfo gameInfo_3 = this.profile.gameInfo_;
					ProfileGameInfo gameInfo_4 = _003CMiniProfile_003Ek__BackingField.gameInfo_;
					int num2 = (gameInfo_4.onlineVersion_ = gameInfo_3.onlineVersion_);
					((BaseStorage<DataType>)(object)this.client.LocalStorage).Save(isForced: true);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007D0C")]
		[Cpp2IlInjected.Address(RVA = "0x18AD890", Offset = "0x18AC290", VA = "0x1818AD890", Slot = "8")]
		public unsafe Task<LoadAndInitProfileResult> Load(Func<Profile, ITransactionContext> createTransactionContext, ProfileEventDispatcher dispatcher, TimeSpan playerTimeZoneOffset, DeviceInfo deviceInfo, bool isDev, CancellationToken ct)
		{
			//IL_005f: Expected I4, but got I8
			//IL_00ee: Expected O, but got I4
			IFileSystem fs = FileSystem;
			string profilePath = FullProfilePath;
			int num = 0;
			string defaultProfilePath_ = ServerConfig.Instance.defaultProfilePath_;
			DeviceInfo deviceInfo2 = CurrentDeviceInfo;
			LoadProfileResult loadProfileResult = ProfileUtil.LoadOrCreateProfile(fs, profilePath, defaultProfilePath_, deviceInfo2);
			Profile profile_ = loadProfileResult.profile_;
			if (profile_ != null)
			{
				this.profile = profile_;
				Profile profile = this.profile;
				if (profile != null)
				{
					profile.ProfileLocation = Profile.Location.SimulatorClient;
				}
				SyncProfileOnlineVersionOnLoad(profile);
				int overrideExistingValue = 0;
				SetupTimeZoneOffset(playerTimeZoneOffset, (byte)overrideExistingValue != 0);
				ProfileGameInfo gameInfo_ = this.profile.gameInfo_;
				ProfileSettings settings_ = this.profile.settings_;
				bool flag = (settings_.isDev_ = settings_ != null);
				Profile profile2 = this.profile;
				ITransactionContext transactionContext = (ITransactionContext)createTransactionContext((T)profile2);
				InitProfileResult initResult_ = profile2.InitAndActualize(transactionContext, dispatcher);
				LoadAndInitProfileResult loadAndInitProfileResult = new LoadAndInitProfileResult();
				loadAndInitProfileResult.loadResult_ = loadProfileResult;
				loadAndInitProfileResult.initResult_ = initResult_;
				return (Task<LoadAndInitProfileResult>)(object)Task.FromResult(loadAndInitProfileResult);
			}
			int num2 = 0;
			LoadAndInitProfileResult loadAndInitProfileResult2 = default(LoadAndInitProfileResult);
			((object)loadAndInitProfileResult2).FieldGetter((string)num2, defaultProfilePath_, ref *(object*)deviceInfo2);
			loadAndInitProfileResult2.loadResult_ = loadProfileResult;
			InitProfileResult initProfileResult = (loadAndInitProfileResult2.initResult_ = new InitProfileResult());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007D0D")]
		[Cpp2IlInjected.Address(RVA = "0x18AEBC0", Offset = "0x18AD5C0", VA = "0x1818AEBC0")]
		private void SetupTimeZoneOffset(TimeSpan playerTimeZoneOffset, bool overrideExistingValue)
		{
			//Discarded unreachable code: IL_00dc
			if (!overrideExistingValue && (long)this.profile.world_.timeZoneOffset_ != 0)
			{
				int num = 0;
				TimeZoneInfo local = TimeZoneInfo.Local;
				int num2 = 0;
				DateTime now = DateTime.Now;
				bool flag = local.IsDaylightSavingTime(now);
				ProfileWorld world_ = this.profile.world_;
				if (flag == world_.timeZoneOffsetIsDST_)
				{
					return;
				}
				world_.timeZoneOffsetIsDST_ = flag;
				Profile profile = this.profile;
				if (!flag)
				{
					ProfileWorld world_2 = profile.world_;
					TimeSpan timeSpan = default(TimeSpan);
					Google.Protobuf.WellKnownTypes.Duration duration = timeSpan.ToProto();
					Google.Protobuf.WellKnownTypes.Duration timeZoneOffset_ = default(Google.Protobuf.WellKnownTypes.Duration);
					world_2.timeZoneOffset_ = timeZoneOffset_;
					return;
				}
				TimeSpan timeSpan2 = default(TimeSpan);
				Google.Protobuf.WellKnownTypes.Duration duration2 = timeSpan2.ToProto();
			}
			ProfileWorld world_3 = this.profile.world_;
			Google.Protobuf.WellKnownTypes.Duration duration3 = (world_3.timeZoneOffset_ = playerTimeZoneOffset.ToProto());
			ProfileWorld world_4 = this.profile.world_;
			int num3 = 0;
			TimeZoneInfo local2 = TimeZoneInfo.Local;
			int num4 = 0;
			DateTime now2 = DateTime.Now;
			bool flag2 = (world_4.timeZoneOffsetIsDST_ = local2.IsDaylightSavingTime(now2));
		}

		[Cpp2IlInjected.Token(Token = "0x6007D0E")]
		[Cpp2IlInjected.Address(RVA = "0x18ADCF0", Offset = "0x18AC6F0", VA = "0x1818ADCF0")]
		internal void QueueSaveProfile(Profile profile)
		{
			if (IsDelayingWrite)
			{
				if (!profile.IsSaveRequested)
				{
					throw new NullReferenceException();
				}
				int num = 0;
				if (!DebugSettings.Settings.disableAutoSave_)
				{
					profile.IsSaveRequested = false;
					ConcurrentStack<Profile> profilesToSave = ProfilesToSave;
					Profile profile2 = profile.Clone();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007D10")]
		[Cpp2IlInjected.Address(RVA = "0x18AE660", Offset = "0x18AD060", VA = "0x1818AE660")]
		public void SaveOnExit()
		{
			SaveWithFlags(SaveFlags.OnExit);
		}

		[Cpp2IlInjected.Token(Token = "0x6007D11")]
		[Cpp2IlInjected.Address(RVA = "0x18AE650", Offset = "0x18AD050", VA = "0x1818AE650")]
		public void SaveNoUpload()
		{
			SaveWithFlags(SaveFlags.NoUpload);
		}

		[Cpp2IlInjected.Token(Token = "0x6007D12")]
		[Cpp2IlInjected.Address(RVA = "0x18AE670", Offset = "0x18AD070", VA = "0x1818AE670")]
		private void SaveWithFlags(SaveFlags saveFlags)
		{
			//Discarded unreachable code: IL_0045
			Task saveTaskThreaded = _SaveTaskThreaded;
			if (saveTaskThreaded == null || saveTaskThreaded.IsCompleted || _SaveTaskThreaded.IsFaulted || _SaveTaskThreaded.IsCanceled || !_SaveTaskThreaded.Wait(10))
			{
			}
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6007D13")]
		[Cpp2IlInjected.Address(RVA = "0x18ADBB0", Offset = "0x18AC5B0", VA = "0x1818ADBB0")]
		public void ProccessSaveQueue()
		{
			//Discarded unreachable code: IL_0061
			if (!IsDelayingWrite)
			{
				return;
			}
			Task saveTaskThreaded = _SaveTaskThreaded;
			if ((saveTaskThreaded == null || saveTaskThreaded.IsCompleted || _SaveTaskThreaded.IsFaulted || _SaveTaskThreaded.IsCanceled) && !((ConcurrentStack<T>)(object)ProfilesToSave).IsEmpty)
			{
				Task task = (_SaveTaskThreaded = Task.Run(delegate
				{
					DoProcessSaveQueue();
				}));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007D14")]
		[Cpp2IlInjected.Address(RVA = "0x18AD3D0", Offset = "0x18ABDD0", VA = "0x1818AD3D0")]
		private unsafe void DoProcessSaveQueue()
		{
			//Discarded unreachable code: IL_0042, IL_0048
			//IL_003c: Expected O, but got I4
			//IL_003c: Expected O, but got I4
			int num = 0;
			if (ProgressDisplayer != null)
			{
			}
			Security security = new Security("b5qhh8saJ8UlDJUzTZXd2Tg6mbo8W8n5");
			if (!((ConcurrentStack<T>)(object)ProfilesToSave).TryPop(out *(T*)num))
			{
			}
			((ConcurrentStack<T>)(object)ProfilesToSave).Clear();
			int num2 = 0;
			Task task = SaveNoIgnore((Profile)num, (SaveFlags)num2, (CancellationToken)num, security);
			if (num2 == 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007D16")]
		[Cpp2IlInjected.Address(RVA = "0x18AE330", Offset = "0x18ACD30", VA = "0x1818AE330")]
		private Task SaveNoIgnore(Profile profile, SaveFlags saveFlags, CancellationToken ct, [Optional] Security security)
		{
			//Discarded unreachable code: IL_00b4
			//IL_00ab: Expected I4, but got I8
			IFileSystem fileSystem = FileSystem;
			bool _003CIsEditor_003Ek__BackingField = App.IsEditor;
			int num = 0;
			if (DebugSettings.Settings.forceProfileEncryption_)
			{
			}
			int num2 = 0;
			bool flag = (IntPtr)"{il2cpp field on {'constant30' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x0}" == (IntPtr)num2;
			int num3 = 0;
			DateTime now = DateTime.Now;
			LocalProfileSaved onLocalProfileSaved = this.OnLocalProfileSaved;
			LastSavedDate = now;
			if (onLocalProfileSaved != null)
			{
			}
			LocalStorage _003CLocalStorage_003Ek__BackingField = client.LocalStorage;
			if (_003CLocalStorage_003Ek__BackingField != null)
			{
				MiniProfile miniProfile = profile.GetMiniProfile();
				MiniProfile _003CMiniProfile_003Ek__BackingField = ((LocalStorageData)((BaseStorage<DataType>)(object)_003CLocalStorage_003Ek__BackingField).Data).User.ProfileInfo.MiniProfile;
				if (_003CMiniProfile_003Ek__BackingField == null || !_003CMiniProfile_003Ek__BackingField.Equals(miniProfile))
				{
					((LocalStorageData)((BaseStorage<DataType>)(object)_003CLocalStorage_003Ek__BackingField).Data).User.ProfileInfo.MiniProfile = miniProfile;
					ulong num4 = default(ulong);
					((BaseStorage<DataType>)(object)_003CLocalStorage_003Ek__BackingField).Save((byte)num4 != 0);
				}
			}
			int num5 = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6007D17")]
		[Cpp2IlInjected.Address(RVA = "0x18AE8E0", Offset = "0x18AD2E0", VA = "0x1818AE8E0", Slot = "9")]
		public Task Save(Profile profile, CancellationToken ct)
		{
			//Discarded unreachable code: IL_004d
			if (!ignoreSave)
			{
				Task saveTaskThreaded = _SaveTaskThreaded;
				if (saveTaskThreaded == null || saveTaskThreaded.IsCompleted || _SaveTaskThreaded.IsFaulted || _SaveTaskThreaded.IsCanceled)
				{
					int num = 0;
					Task result = default(Task);
					return result;
				}
				Profile profile2 = this.profile;
			}
			int num2 = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6007D18")]
		[Cpp2IlInjected.Address(RVA = "0x18AEA50", Offset = "0x18AD450", VA = "0x1818AEA50")]
		public Task Save(Profile profile, SaveFlags saveFlags, CancellationToken ct, Security security)
		{
			if (!ignoreSave)
			{
				Task saveTaskThreaded = _SaveTaskThreaded;
				if (saveTaskThreaded == null || saveTaskThreaded.IsCompleted || _SaveTaskThreaded.IsFaulted || _SaveTaskThreaded.IsCanceled)
				{
					throw new NullReferenceException();
				}
				Profile profile2 = this.profile;
			}
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6007D19")]
		[Cpp2IlInjected.Address(RVA = "0x18AD000", Offset = "0x18ABA00", VA = "0x1818AD000", Slot = "10")]
		public Task AskForSave(Profile profile, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0065
			if (!IsDelayingWrite)
			{
				Profile profile2 = this.profile;
				if (ignoreSave)
				{
					goto IL_005c;
				}
				Task saveTaskThreaded = _SaveTaskThreaded;
				if (saveTaskThreaded == null || saveTaskThreaded.IsCompleted || _SaveTaskThreaded.IsFaulted || _SaveTaskThreaded.IsCanceled)
				{
					int num = 0;
					int num2 = 0;
					Task result = default(Task);
					return result;
				}
			}
			this.profile.IsSaveRequested = true;
			goto IL_005c;
			IL_005c:
			int num3 = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6007D1A")]
		[Cpp2IlInjected.Address(RVA = "0x18AD580", Offset = "0x18ABF80", VA = "0x1818AD580")]
		public IDisposable IgnoreSaveScope()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6007D1B")]
		[Cpp2IlInjected.Address(RVA = "0x18AD240", Offset = "0x18ABC40", VA = "0x1818AD240")]
		public void BeginIgnoreSave()
		{
			ignoreSave = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6007D1C")]
		[Cpp2IlInjected.Address(RVA = "0x18AD510", Offset = "0x18ABF10", VA = "0x1818AD510")]
		public void EndIgnoreSave()
		{
			//IL_0021: Expected O, but got I4
			if (ignoreSave)
			{
				Profile profile = this.profile;
				int num = 0;
				ignoreSave = false;
				Task task = AskForSave(profile, (CancellationToken)num);
			}
		}
	}
}
