using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Gameloft.Common;
using Gameloft.FileSystem.Abstraction;
using Gameloft.Tracking.Device;
using Mdl.Avatar;
using Mdl.Ftue.Cutscenes.Clips;
using Mdl.Online;
using Mdl.Platform;
using Mdl.Systems;
using Mdl.Tracking;
using Mdl.Utils;
using Meta;
using Meta.Online;
using Meta.Tracking;
using Meta.Util;
using Newtonsoft.Json.Linq;
using Serilog;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;

namespace Mdl
{
	[Cpp2IlInjected.Token(Token = "0x20001FF")]
	public class Startup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001131")]
		[SerializeField]
		private PlayerAvatar _avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001132")]
		[SerializeField]
		private GameloftTrackingConfig _gameloftTrackingConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001133")]
		public CutsceneClipSequence startupSequence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001134")]
		public UnityEvent StartThrobberEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001135")]
		[ItemID]
		[SerializeField]
		private int _introSceneDefinitionItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001136")]
		public string introSceneAvatarNodeAnchorName = "AvatarPosition";

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001137")]
		[ItemID]
		public int ftueIntroItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4001138")]
		[ItemID]
		public int ftueVillageIntroItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001139")]
		public AssetReference DebugSettingsMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400113A")]
		private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400113B")]
		[SerializeField]
		private Canvas _startUpCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400113C")]
		private bool introSceneLoaded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001142")]
		private bool debugSettingsWasActive;

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		public static Startup Instance
		{
			[Cpp2IlInjected.Token(Token = "0x600087C")]
			[Cpp2IlInjected.Address(RVA = "0xF5FC30", Offset = "0xF5E630", VA = "0x180F5FC30")]
			[CompilerGenerated]
			get
			{
				return _003CInstance_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600087D")]
			[Cpp2IlInjected.Address(RVA = "0xF60040", Offset = "0xF5EA40", VA = "0x180F60040")]
			[CompilerGenerated]
			private set
			{
				_003CInstance_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Startup)(object)"";


		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		public SceneItemData introSceneItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(RVA = "0xF5FE10", Offset = "0xF5E810", VA = "0x180F5FE10")]
			get
			{
				//Discarded unreachable code: IL_0016
				int introSceneDefinitionItem = _introSceneDefinitionItem;
				ItemDatabase itemDatabase = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)introSceneDefinitionItem);
				SceneItemData result = default(SceneItemData);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		public CancellationToken CancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0xF5FBB0", Offset = "0xF5E5B0", VA = "0x180F5FBB0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _cancellationTokenSource.Token;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		[field: Cpp2IlInjected.Token(Token = "0x400113D")]
		public static bool ShowStartMenu
		{
			[Cpp2IlInjected.Token(Token = "0x6000880")]
			[Cpp2IlInjected.Address(RVA = "0xF5FDB0", Offset = "0xF5E7B0", VA = "0x180F5FDB0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000881")]
			[Cpp2IlInjected.Address(RVA = "0xF60170", Offset = "0xF5EB70", VA = "0x180F60170")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		[field: Cpp2IlInjected.Token(Token = "0x400113E")]
		public static bool ShowStartMenuCutscene
		{
			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0xF5FCF0", Offset = "0xF5E6F0", VA = "0x180F5FCF0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000883")]
			[Cpp2IlInjected.Address(RVA = "0xF600B0", Offset = "0xF5EAB0", VA = "0x180F600B0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		[field: Cpp2IlInjected.Token(Token = "0x400113F")]
		public static bool ShowStartMenuPressAnyKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000884")]
			[Cpp2IlInjected.Address(RVA = "0xF5FD50", Offset = "0xF5E750", VA = "0x180F5FD50")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000885")]
			[Cpp2IlInjected.Address(RVA = "0xF60110", Offset = "0xF5EB10", VA = "0x180F60110")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		public static string ClientID
		{
			[Cpp2IlInjected.Token(Token = "0x6000886")]
			[Cpp2IlInjected.Address(RVA = "0xF5FBD0", Offset = "0xF5E5D0", VA = "0x180F5FBD0")]
			[CompilerGenerated]
			get
			{
				return _003CClientID_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0xF5FFD0", Offset = "0xF5E9D0", VA = "0x180F5FFD0")]
			[CompilerGenerated]
			set
			{
				Instance = (Startup)(object)value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		public Func<Task> BeforeCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			[CompilerGenerated]
			get
			{
				return _003CBeforeCompletion_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			[CompilerGenerated]
			set
			{
				_003CBeforeCompletion_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		private Serilog.ILogger seriLogger
		{
			[Cpp2IlInjected.Token(Token = "0x600088A")]
			[Cpp2IlInjected.Address(RVA = "0xF5FF20", Offset = "0xF5E920", VA = "0x180F5FF20")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.SeriLogger;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public static bool IsLoadingScopeEnable
		{
			[Cpp2IlInjected.Token(Token = "0x600089F")]
			[Cpp2IlInjected.Address(RVA = "0xF5FC90", Offset = "0xF5E690", VA = "0x180F5FC90")]
			get
			{
				//Discarded unreachable code: IL_0010
				int num = 0;
				return !DebugSettings.Settings.disableLoadingScope_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xF5CBD0", Offset = "0xF5B5D0", VA = "0x180F5CBD0")]
		public void Awake()
		{
			Instance = this;
			Physics.autoSimulation = false;
			UnityProfiler unityProfiler = new UnityProfiler();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0xF5D8D0", Offset = "0xF5C2D0", VA = "0x180F5D8D0")]
		private void OnDestroy()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0xF5CF40", Offset = "0xF5B940", VA = "0x180F5CF40")]
		public void Destroy()
		{
			//Discarded unreachable code: IL_000c
			_cancellationTokenSource.Cancel();
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0xF5DDE0", Offset = "0xF5C7E0", VA = "0x180F5DDE0")]
		private unsafe void Start()
		{
			//Discarded unreachable code: IL_0118
			//IL_00b2: Expected O, but got I4
			int num = 0;
			Camera playerCamera = SystemRoot.Instance._playerCamera;
			int num2 = 0;
			Serilog.ILogger logger = seriLogger;
			int num3 = 0;
			string dataPath = Application.dataPath;
			string text = "dataPath: " + dataPath;
			Serilog.ILogger logger2 = seriLogger;
			int num4 = 0;
			string streamingAssetsPath = Application.streamingAssetsPath;
			string text2 = "streamingAssetsPath: " + streamingAssetsPath;
			Serilog.ILogger logger3 = seriLogger;
			IFileSystem _003CSave_003Ek__BackingField = FileSystem.Save;
			Serilog.ILogger logger4 = seriLogger;
			int num5 = 0;
			string runningStore = PlatformUtils.GetRunningStore();
			string text3 = "RunningStore: " + runningStore;
			Serilog.ILogger logger5 = seriLogger;
			string runningPlatformName = PlatformUtils.GetRunningPlatformName();
			string text4 = "RunningPlatformName: " + runningPlatformName;
			Serilog.ILogger logger6 = seriLogger;
			int num6 = 0;
			bool flag = default(bool);
			string text5 = $"IsWindowsStore: {flag}";
			Screen.sleepTimeout = -1;
			int num7 = 0;
			if (Application.platform != RuntimePlatform.OSXPlayer)
			{
				int num8 = 0;
				if (Application.platform != 0)
				{
					goto IL_0100;
				}
			}
			GameloftTrackingConfig gameloftTrackingConfig = _gameloftTrackingConfig;
			int num9 = 0;
			string runningStore2 = PlatformUtils.GetRunningStore();
			SystemRoot systemRoot = SystemRoot.Instance;
			string version = default(string);
			if (gameloftTrackingConfig.TryGetClientId(runningStore2, version, out *(string*)text5))
			{
				Instance = (Startup)(object)gameloftTrackingConfig;
			}
			goto IL_0100;
			IL_0100:
			CancellationToken token = _cancellationTokenSource.Token;
			int num10 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0xF5E560", Offset = "0xF5CF60", VA = "0x180F5E560")]
		private void StartupTracking()
		{
			//Discarded unreachable code: IL_02fe, IL_0304, IL_030a, IL_0310, IL_0316, IL_031c, IL_0322, IL_0328, IL_032e, IL_0334, IL_033a, IL_0340, IL_0346, IL_034c, IL_0352
			//IL_003d: Expected O, but got I4
			//IL_00ad: Expected O, but got I4
			//IL_0127: Expected O, but got I4
			//IL_0143: Expected O, but got I4
			//IL_0159: Expected O, but got I4
			//IL_0246: Expected O, but got I4
			//IL_0246: Expected O, but got I4
			//IL_0246: Expected O, but got I4
			int num3;
			bool isGameloftTrackingAllowed2 = default(bool);
			Mdl.Online.Client client = default(Mdl.Online.Client);
			bool flag = default(bool);
			Meta.Online.Client client2 = default(Meta.Online.Client);
			Meta.Online.Client client3 = default(Meta.Online.Client);
			string buildFullName = default(string);
			do
			{
				IL_0000:
				int num = 0;
				int num2 = 0;
				num3 = 0;
				int num4 = 0;
				TrackingManager.Init();
				if (!SystemRoot.Instance.Client.IsGameloftTrackingAllowed)
				{
					bool isGameloftTrackingAllowed = SystemRoot.Instance.Client.IsGameloftTrackingAllowed;
					Debug.Log($"DeltaDNA tracking consumer not started since IsDDNATrackingAllowed={isGameloftTrackingAllowed}");
				}
				TrackingManager trackingManager = TrackingManager.Instance;
				DeltaDNAConsumer consumer = new DeltaDNAConsumer(SeriloggerWrapper.CreateLoggerConfig(SystemRoot.ErrorReporter, "[DDSDK] "));
				trackingManager.AddConsumer(consumer, isMain: true);
				int num5 = 0;
				string runningStore = PlatformUtils.GetRunningStore();
				if (!SystemRoot.Instance.Client.IsGameloftTrackingAllowed && !SystemRoot.Instance.Client.IsForceOfflineBy(ForceOfflineReasonFlag.AgeGate))
				{
					isGameloftTrackingAllowed2 = client.IsGameloftTrackingAllowed;
					Debug.Log($"Tracker.Net (gameloft tracking) consumer not started since IsGameloftTrackingAllowed={isGameloftTrackingAllowed2}");
				}
				while (runningStore == null)
				{
				}
				SystemRoot systemRoot = SystemRoot.Instance;
				Gameloft.Common.Version _003CVersion_003Ek__BackingField = systemRoot.Version;
				int build = systemRoot.Version.version.build;
				string buildType = systemRoot.Version.buildType;
				while (!flag)
				{
				}
				int num6 = 0;
				if (DebugSettings.Settings.disableGameloftTracking_)
				{
					Debug.Log("Gameloft tracking disabled with DebugSettings.Settings.DisableGameloftTracking");
				}
				TrackingManager trackingManager2 = TrackingManager.Instance;
				LoggerConfiguration loggerConfig = SeriloggerWrapper.CreateLoggerConfig(SystemRoot.ErrorReporter, "[Tracking.{SourceContext}] ({Level:u3}): ");
				GameloftTrackingConsumer consumer2 = new GameloftTrackingConsumer((string)num3, loggerConfig);
				int isMain = 0;
				trackingManager2.AddConsumer(consumer2, (byte)isMain != 0);
				string text = $"Failed to initialize Gameloft Tracking due to following exception => {isGameloftTrackingAllowed2}";
				int num7 = 0;
				int num8 = 0;
				if (num3 != 0)
				{
					goto IL_0000;
				}
				Debug.LogException((Exception)num8);
				int num9 = 0;
				TrackingManager trackingManager3 = TrackingManager.Instance;
				Profile profile = SystemRoot.Instance.MetaClient.profile;
				int num10 = 0;
				string version = Application.version;
				int num11 = 0;
				string runningStore2 = PlatformUtils.GetRunningStore();
				SystemRoot systemRoot2 = SystemRoot.Instance;
				Gameloft.Common.Version _003CVersion_003Ek__BackingField2 = systemRoot2.Version;
				int build2 = systemRoot2.Version.version.build;
				string buildType2 = systemRoot2.Version.buildType;
				OnlineClient metaOnlineClient = SystemRoot.Instance.MetaOnlineClient;
				if (metaOnlineClient == null || metaOnlineClient.EntityId == null)
				{
					LocalStorage _003CLocalStorage_003Ek__BackingField = client2.LocalStorage;
					if (_003CLocalStorage_003Ek__BackingField != null)
					{
						LocalStorageData.OnlineInfo _003COnlineInfo_003Ek__BackingField = ((LocalStorageData)((BaseStorage<DataType>)(object)_003CLocalStorage_003Ek__BackingField).Data).User.OnlineInfo;
					}
				}
				OnlineClient metaOnlineClient2 = SystemRoot.Instance.MetaOnlineClient;
				if (metaOnlineClient2 == null || metaOnlineClient2.PlayFabId == null)
				{
					LocalStorage _003CLocalStorage_003Ek__BackingField2 = client3.LocalStorage;
					if (_003CLocalStorage_003Ek__BackingField2 != null)
					{
						LocalStorageData.OnlineInfo _003COnlineInfo_003Ek__BackingField2 = ((LocalStorageData)((BaseStorage<DataType>)(object)_003CLocalStorage_003Ek__BackingField2).Data).User.OnlineInfo;
					}
				}
				trackingManager3.AddClientInfo(profile, version, runningStore2, buildFullName, (string)num9, (string)num9, (ILocation)num7);
				TrackingManager trackingManager4 = TrackingManager.Instance;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				Profile profile2 = SystemRoot.Instance.MetaClient.profile;
				trackingManager4.RegisterListeners(_003CDispatcher_003Ek__BackingField, profile2);
				int num12 = 0;
				if (Application.platform != 0)
				{
					int num13 = 0;
					if (Application.platform != RuntimePlatform.OSXPlayer)
					{
						continue;
					}
				}
				int num14 = 0;
				RegionListUtils.InitializeRegionListUtils();
				int defaultValue = 0;
				if (!RegionListUtils.Get("UserAgeTrackingSent", (byte)defaultValue != 0))
				{
					TrackingManager trackingManager5 = TrackingManager.Instance;
					if (trackingManager5 != null)
					{
						int num15 = 0;
						int userAge = RegionListUtils.GetUserAge(DeviceInfo.Collect().Country, "Mixt_Plus");
						trackingManager5.trackAgeGateEvent(userAge);
					}
					JToken value = true;
					RegionListUtils.Set("UserAgeTrackingSent", value);
					int num16 = 0;
					bool flag2 = RegionListUtils.Save();
				}
			}
			while (num3 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0xF5DD70", Offset = "0xF5C770", VA = "0x180F5DD70")]
		public static bool ShowSimpleDebugPrompt()
		{
			//Discarded unreachable code: IL_002d
			int num = 0;
			if (!Environment.CommandLine.Contains("--debug"))
			{
				int num2 = 0;
				if (Application.platform != RuntimePlatform.IPhonePlayer)
				{
					int num3 = 0;
					if (Application.platform != RuntimePlatform.Android)
					{
						int num4 = 0;
					}
				}
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0")]
		public static bool ShowDebugSettingsMenuAtLaunch()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0xF5E430", Offset = "0xF5CE30", VA = "0x180F5E430")]
		[AsyncStateMachine(typeof(_003CStartupSequence_003Ed__50))]
		private Task StartupSequence(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0xF5D970", Offset = "0xF5C370", VA = "0x180F5D970")]
		public void OnNewOrContinueGame()
		{
			//Discarded unreachable code: IL_001a
			CancellationToken token = _cancellationTokenSource.Token;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0xF5D7A0", Offset = "0xF5C1A0", VA = "0x180F5D7A0")]
		[AsyncStateMachine(typeof(_003CNewOrContinueGame_003Ed__52))]
		private Task NewOrContinueGame(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0xF5D0A0", Offset = "0xF5BAA0", VA = "0x180F5D0A0")]
		[AsyncStateMachine(typeof(_003CFtueIntroSequence_003Ed__53))]
		private Task FtueIntroSequence(Meta.Online.Client client, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0xF5DB00", Offset = "0xF5C500", VA = "0x180F5DB00")]
		[AsyncStateMachine(typeof(_003CPreGameLoad_003Ed__54))]
		private Task<Meta.Online.Client.PreGameLoadChainResult> PreGameLoad(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<Meta.Online.Client.PreGameLoadChainResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0xF5D690", Offset = "0xF5C090", VA = "0x180F5D690")]
		[AsyncStateMachine(typeof(_003CLogin_003Ed__55))]
		private Task Login(CancellationToken ct)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0xF5CF60", Offset = "0xF5B960", VA = "0x180F5CF60")]
		[AsyncStateMachine(typeof(_003CDoFadeIn_003Ed__56))]
		private Task<bool> DoFadeIn(bool skipIntroSequence)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0xF5D440", Offset = "0xF5BE40", VA = "0x180F5D440")]
		[AsyncStateMachine(typeof(_003CLoadIntroScene_003Ed__57))]
		private Task LoadIntroScene(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0xF5D560", Offset = "0xF5BF60", VA = "0x180F5D560")]
		[AsyncStateMachine(typeof(_003CLoadVillage_003Ed__58))]
		private Task LoadVillage(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0xF5F5F0", Offset = "0xF5DFF0", VA = "0x180F5F5F0")]
		[AsyncStateMachine(typeof(_003CTrackClaimedFoundersPacks_003Ed__59))]
		private Task TrackClaimedFoundersPacks(Profile profile, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0xF5DC20", Offset = "0xF5C620", VA = "0x180F5DC20")]
		[AsyncStateMachine(typeof(_003CShowDiskSpaceIssuePopup_003Ed__60))]
		private Task ShowDiskSpaceIssuePopup(string drive, int missingSpaceInMb, int requiredSpaceInMb, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0xF5D1E0", Offset = "0xF5BBE0", VA = "0x180F5D1E0")]
		public static extern bool GetDiskFreeSpaceEx(string lpDirectoryName, out ulong lpFreeBytesAvailable, out ulong lpTotalNumberOfBytes, out ulong lpTotalNumberOfFreeBytes);

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0xF5D2A0", Offset = "0xF5BCA0", VA = "0x180F5D2A0")]
		public static bool HasDiskSpaceIssue(out string drive, out int missingSpaceInMb, out int requiredSpaceInMb)
		{
			int value = (requiredSpaceInMb.m_value = (missingSpaceInMb.m_value = 0));
			IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
			bool flag = default(bool);
			if (!flag)
			{
				IFileSystem _003CSave_003Ek__BackingField = FileSystem.Save;
				bool flag2 = default(bool);
				if (!flag2)
				{
				}
				return true;
			}
			requiredSpaceInMb.m_value = value;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0xF5CD30", Offset = "0xF5B730", VA = "0x180F5CD30")]
		public static SettingScope CreateLoadingScope(int targetFps)
		{
			//IL_0040: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			int num = 0;
			DebugSettings settings = DebugSettings.Settings;
			int num2 = 0;
			if ((object)typeof(SettingScope).TypeHandle == null || (object)typeof(SettingScope).TypeHandle == null || (object)typeof(SettingScope).TypeHandle != null)
			{
			}
			int num3 = 0;
			if ((DebugSettings.Settings.disableLoadingScope_ ? 1 : 0) == num2)
			{
				int num4 = 0;
				uint num5 = default(uint);
				string text = default(string);
				return new SettingScope((int)num5, (Nullable<>)num2, (Nullable<>)num2, (Nullable<>)num2, text);
			}
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0xF5FB20", Offset = "0xF5E520", VA = "0x180F5FB20")]
		public Startup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0xF5FA90", Offset = "0xF5E490", VA = "0x180F5FA90")]
		static Startup()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
