using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Grid;
using Definitions.Items;
using Gameloft.Common;
using Gameloft.Rpc.Core;
using Gameloft.Rpc.Core.Client;
using glPlayFab;
using Mdl.Activities;
using Mdl.Audio;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Platform;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.ErrorReporting;
using Meta.Online;
using Meta.Util;
using Serilog;
using StoreFrontEnums;
using UnityEngine;

namespace Mdl.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000365")]
	public class Client : MonoBehaviour, IUnityContext
	{
		[Cpp2IlInjected.Token(Token = "0x2000366")]
		public delegate void MetaClientCreated();

		[Cpp2IlInjected.Token(Token = "0x4001796")]
		private const string UniqueIdKey = "UniqueID";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001798")]
		public RewardSpawnAnimationData inventoryFullDropItemAnimationData;

		[Cpp2IlInjected.Token(Token = "0x400179A")]
		private const string Separator = " / ";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400179B")]
		private ForceOfflineReasonFlag _forceOfflineReasonFlag;

		[Cpp2IlInjected.Token(Token = "0x400179C")]
		private const int TimePlayedUpdateInterval = 5;

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public Meta.Online.Client MetaClient
		{
			[Cpp2IlInjected.Token(Token = "0x6000E80")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CMetaClient_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E81")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			private set
			{
				_003CMetaClient_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public TransactionService.TransactionServiceClient TransactionService
		{
			[Cpp2IlInjected.Token(Token = "0x6000E82")]
			[Cpp2IlInjected.Address(RVA = "0xA851E0", Offset = "0xA83BE0", VA = "0x180A851E0")]
			get
			{
				Meta.Online.Client client = MetaClient;
				if (client != null)
				{
					return client.TransactionService;
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public Profile Profile
		{
			[Cpp2IlInjected.Token(Token = "0x6000E83")]
			[Cpp2IlInjected.Address(RVA = "0xA851C0", Offset = "0xA83BC0", VA = "0x180A851C0")]
			get
			{
				Meta.Online.Client client;
				do
				{
					client = MetaClient;
				}
				while (client == null);
				return client.profile;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public bool IsPlatformConsole
		{
			[Cpp2IlInjected.Token(Token = "0x6000E8F")]
			[Cpp2IlInjected.Address(RVA = "0xA850F0", Offset = "0xA83AF0", VA = "0x180A850F0", Slot = "8")]
			get
			{
				int num = 0;
				if (Application.platform != RuntimePlatform.GameCoreXboxOne)
				{
					int num2 = 0;
					if (Application.platform != RuntimePlatform.GameCoreScarlett)
					{
						int num3 = 0;
						if (Application.platform != RuntimePlatform.PS4)
						{
							int num4 = 0;
							if (Application.platform != RuntimePlatform.PS5)
							{
								int num5 = 0;
								return Application.platform == RuntimePlatform.Switch;
							}
						}
					}
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public bool IsPlatformXbox
		{
			[Cpp2IlInjected.Token(Token = "0x6000E90")]
			[Cpp2IlInjected.Address(RVA = "0xA85190", Offset = "0xA83B90", VA = "0x180A85190", Slot = "9")]
			get
			{
				int num = 0;
				if (Application.platform == RuntimePlatform.GameCoreXboxOne)
				{
					return true;
				}
				int num2 = 0;
				return Application.platform == RuntimePlatform.GameCoreScarlett;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public bool IsPlatformPlayStation
		{
			[Cpp2IlInjected.Token(Token = "0x6000E91")]
			[Cpp2IlInjected.Address(RVA = "0xA85140", Offset = "0xA83B40", VA = "0x180A85140", Slot = "10")]
			get
			{
				int num = 0;
				if (Application.platform == RuntimePlatform.PS4)
				{
					return true;
				}
				int num2 = 0;
				return Application.platform == RuntimePlatform.PS5;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public bool IsPlatformSwitch
		{
			[Cpp2IlInjected.Token(Token = "0x6000E92")]
			[Cpp2IlInjected.Address(RVA = "0xA85170", Offset = "0xA83B70", VA = "0x180A85170", Slot = "11")]
			get
			{
				int num = 0;
				return Application.platform == RuntimePlatform.Switch;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public bool IsDebugBuildType
		{
			[Cpp2IlInjected.Token(Token = "0x6000E93")]
			[Cpp2IlInjected.Address(RVA = "0xA85020", Offset = "0xA83A20", VA = "0x180A85020", Slot = "15")]
			get
			{
				int num = 0;
				return Debug.isDebugBuild;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public bool IsForcedOffline
		{
			[Cpp2IlInjected.Token(Token = "0x6000E99")]
			[Cpp2IlInjected.Address(RVA = "0xA85070", Offset = "0xA83A70", VA = "0x180A85070", Slot = "13")]
			get
			{
				//Discarded unreachable code: IL_001e
				int num = 0;
				DebugSettings settings = DebugSettings.Settings;
				return (_forceOfflineReasonFlag = _forceOfflineReasonFlag) != ForceOfflineReasonFlag.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public ForceOfflineReasonFlag ForceOfflineReasonFlag
		{
			[Cpp2IlInjected.Token(Token = "0x6000E9A")]
			[Cpp2IlInjected.Address(RVA = "0xA84F80", Offset = "0xA83980", VA = "0x180A84F80", Slot = "14")]
			get
			{
				int num = 0;
				DebugSettings settings = DebugSettings.Settings;
				int num2 = (int)(_forceOfflineReasonFlag = _forceOfflineReasonFlag);
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public bool IsGameloftTrackingAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000E9C")]
			[Cpp2IlInjected.Address(RVA = "0xA85000", Offset = "0xA83A00", VA = "0x180A85000")]
			get
			{
				return !IsForcedOffline;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public bool IsDDNATrackingAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000E9D")]
			[Cpp2IlInjected.Address(RVA = "0xA85000", Offset = "0xA83A00", VA = "0x180A85000")]
			get
			{
				return !IsForcedOffline;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event MetaClientCreated OnMetaClientCreated
		{
			[Cpp2IlInjected.Token(Token = "0x6000E84")]
			[Cpp2IlInjected.Address(RVA = "0xA84EE0", Offset = "0xA838E0", VA = "0x180A84EE0")]
			[CompilerGenerated]
			add
			{
				MetaClientCreated onMetaClientCreated = this.OnMetaClientCreated;
				Delegate @delegate = Delegate.Combine(onMetaClientCreated, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onMetaClientCreated)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000E85")]
			[Cpp2IlInjected.Address(RVA = "0xA85200", Offset = "0xA83C00", VA = "0x180A85200")]
			[CompilerGenerated]
			remove
			{
				MetaClientCreated onMetaClientCreated = this.OnMetaClientCreated;
				Delegate @delegate = Delegate.Remove(onMetaClientCreated, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onMetaClientCreated)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7E")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		public static DeviceInfo GetDeviceInfo()
		{
			//Discarded unreachable code: IL_0040
			//IL_000f: Expected I4, but got I8
			DeviceInfo deviceInfo = new DeviceInfo();
			deviceInfo.deviceType_ = Definitions.DeviceType.Windows;
			int num = 0;
			string @string = PlayerPrefs.GetString("UniqueID");
			if (string.IsNullOrEmpty(@string))
			{
				Guid guid = Guid.NewGuid();
				string value = default(string);
				PlayerPrefs.SetString("UniqueID", value);
			}
			deviceInfo.DeviceID = @string;
			return deviceInfo;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7F")]
		[Cpp2IlInjected.Address(RVA = "0xA84320", Offset = "0xA82D20", VA = "0x180A84320")]
		public static string GetUniqueDeviceId()
		{
			string @string = PlayerPrefs.GetString("UniqueID");
			if (string.IsNullOrEmpty(@string))
			{
				Guid guid = Guid.NewGuid();
				string value = default(string);
				PlayerPrefs.SetString("UniqueID", value);
			}
			return @string;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E86")]
		[Cpp2IlInjected.Address(RVA = "0xA83AC0", Offset = "0xA824C0", VA = "0x180A83AC0")]
		public string GetBuildSessionIdentifier(bool withPlayfabId = false)
		{
			//Discarded unreachable code: IL_0230
			StringBuilder stringBuilder;
			string value = default(string);
			while (true)
			{
				stringBuilder = new StringBuilder();
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				Gameloft.Common.Version _003CVersion_003Ek__BackingField = _003CInstance_003Ek__BackingField.Version;
				int build = _003CInstance_003Ek__BackingField.Version.version.build;
				string buildType = _003CInstance_003Ek__BackingField.Version.buildType;
				if (withPlayfabId)
				{
					StringBuilder stringBuilder2 = stringBuilder.Append(" / ");
					string playFabId = MetaClient.OnlineClient.PlayFabId;
					StringBuilder stringBuilder3 = stringBuilder2.Append(playFabId);
				}
				if (MetaClient.AppConfigType == ApplicationConfigurationType.Release)
				{
					continue;
				}
				StringBuilder stringBuilder4 = stringBuilder.Append(" / ");
				Meta.Online.Client client = MetaClient;
				ApplicationConfigurationType _003CAppConfigType_003Ek__BackingField = client.AppConfigType;
				StringBuilder stringBuilder5 = stringBuilder4.Append(client);
				OnlineEnvironment cachedOnlineEnv = MetaClient.OnlineClient.CachedOnlineEnv;
				int num = (int)cachedOnlineEnv;
				if (cachedOnlineEnv == OnlineEnvironment.Prod)
				{
					break;
				}
				StringBuilder stringBuilder6 = stringBuilder.Append(" / ");
				StringBuilder stringBuilder7 = stringBuilder6.Append(stringBuilder6);
				StringBuilder stringBuilder8 = stringBuilder.Append("(").Append(value).Append(")");
				StringBuilder stringBuilder9 = stringBuilder.Append(" / ");
				string[] array = new string[6];
				if ("InternetOn=" != null && "InternetOn=" == null)
				{
					continue;
				}
				array[0] = "InternetOn=";
				bool isInternetOn = MetaClient.OnlineClient.IsInternetOn;
				string text = "No";
				if (isInternetOn)
				{
					text = "Yes";
				}
				if (text != null && !isInternetOn)
				{
					continue;
				}
				array[1] = text;
				if (", PlayFabLogin=" != null && ", PlayFabLogin=" == null)
				{
					continue;
				}
				array[2] = ", PlayFabLogin=";
				bool isLoggedInWithPlayFab = MetaClient.OnlineClient.IsLoggedInWithPlayFab;
				text = "No";
				if (isLoggedInWithPlayFab)
				{
					text = "Yes";
				}
				if (text != null && !isLoggedInWithPlayFab)
				{
					continue;
				}
				array[3] = text;
				if (", PortalLogin=" == null || ", PortalLogin=" != null)
				{
					array[4] = ", PortalLogin=";
					bool isLoggedInWithPortal = MetaClient.OnlineClient.IsLoggedInWithPortal;
					text = "No";
					if (isLoggedInWithPortal)
					{
						text = "Yes";
					}
					if (text == null || isLoggedInWithPortal)
					{
						array[5] = text;
						string value2 = string.Concat(array);
						StringBuilder stringBuilder10 = stringBuilder.Append(value2);
						break;
					}
				}
			}
			return stringBuilder.ToString();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E87")]
		[Cpp2IlInjected.Address(RVA = "0xA82E70", Offset = "0xA81870", VA = "0x180A82E70")]
		private void Awake()
		{
			//Discarded unreachable code: IL_01b0, IL_01b6, IL_01bc, IL_01c2, IL_01c8, IL_01ce
			//IL_0069: Expected I4, but got I8
			//IL_011e: Expected O, but got I4
			//IL_0152: Expected O, but got I4
			//IL_0186: Expected O, but got I4
			Serilog.ILogger logger;
			string text = default(string);
			Meta.Online.Client client = default(Meta.Online.Client);
			do
			{
				int num = (int)(_forceOfflineReasonFlag = ForceOfflineReasonFlag.None);
				int num2 = 0;
				int runtimePlayfabOriginId = (int)PlatformUtils.GetRuntimePlayfabOriginId();
				int num3 = 0;
				if (PlatformInterfaceManager.Instance != null)
				{
				}
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField != null)
				{
					SavegameManager saveGameManager = _003CInstance_003Ek__BackingField._saveGameManager;
					if ((object)saveGameManager != null)
					{
						SavegameManagerConfig config = saveGameManager.Config;
						if (config != null)
						{
							bool isDelayingWrite = config.IsDelayingWrite;
						}
					}
				}
				logger = SeriloggerWrapper.CreateLogger("Client");
				DeviceInfo deviceInfo = new DeviceInfo();
				deviceInfo.deviceType_ = Definitions.DeviceType.Windows;
				int num4 = 0;
				if (PlayerPrefs.GetString("UniqueID") != null)
				{
					Guid guid = Guid.NewGuid();
					PlayerPrefs.SetString("UniqueID", text);
				}
				deviceInfo.DeviceID = text;
				SystemRoot _003CInstance_003Ek__BackingField2 = SystemRoot.Instance;
				Gameloft.Common.Version _003CVersion_003Ek__BackingField = _003CInstance_003Ek__BackingField2.Version;
				int build = _003CInstance_003Ek__BackingField2.Version.version.build;
				string buildType = _003CInstance_003Ek__BackingField2.Version.buildType;
				IErrorReporter _003CErrorReporter_003Ek__BackingField = SystemRoot.ErrorReporter;
				int num5 = 0;
				MetaClient = client;
				this.OnMetaClientCreated?.Invoke();
				Meta.Online.Client client2 = MetaClient;
				Meta.Online.Client.InventoryFullFlowDelegate value = MetaClient_OnInventoryFull;
				client2.OnInventoryFull += value;
				SwitchNotifications instance = SwitchNotifications.Instance;
				int num6 = 0;
				if (instance != (UnityEngine.Object)num6)
				{
					SwitchNotifications instance2 = SwitchNotifications.Instance;
					SwitchNotifications.ApplicationPauseCB value2 = OnConsoleApplicationPause;
					instance2.OnApplicationPause += value2;
				}
				XboxNotifications instance3 = XboxNotifications.Instance;
				int num7 = 0;
				if (instance3 != (UnityEngine.Object)num7)
				{
					XboxNotifications instance4 = XboxNotifications.Instance;
					XboxNotifications.ApplicationPauseCB value3 = OnConsoleApplicationPause;
					instance4.OnApplicationPause += value3;
				}
				PlaystationNotifications instance5 = PlaystationNotifications.Instance;
				int num8 = 0;
				if (instance5 != (UnityEngine.Object)num8)
				{
					PlaystationNotifications instance6 = PlaystationNotifications.Instance;
					PlaystationNotifications.ApplicationPauseCB value4 = OnConsoleApplicationPause;
					instance6.OnApplicationPause += value4;
				}
			}
			while (logger != null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E88")]
		[Cpp2IlInjected.Address(RVA = "0xA84C00", Offset = "0xA83600", VA = "0x180A84C00")]
		private void Start()
		{
			InvokeRepeating("UpdateUserTotalTimeInGame", 300f, 300f);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E89")]
		[Cpp2IlInjected.Address(RVA = "0xA84EC0", Offset = "0xA838C0", VA = "0x180A84EC0")]
		private void Update()
		{
			MetaClient?.Update();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8A")]
		[Cpp2IlInjected.Address(RVA = "0xA84860", Offset = "0xA83260", VA = "0x180A84860")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_00bf
			//IL_0035: Expected O, but got I4
			//IL_0069: Expected O, but got I4
			//IL_009d: Expected O, but got I4
			Meta.Online.Client client = MetaClient;
			Meta.Online.Client.InventoryFullFlowDelegate value = MetaClient_OnInventoryFull;
			client.OnInventoryFull -= value;
			MetaClient.Destroy();
			SwitchNotifications instance = SwitchNotifications.Instance;
			int num = 0;
			if (instance != (UnityEngine.Object)num)
			{
				SwitchNotifications instance2 = SwitchNotifications.Instance;
				SwitchNotifications.ApplicationPauseCB value2 = OnConsoleApplicationPause;
				instance2.OnApplicationPause -= value2;
			}
			XboxNotifications instance3 = XboxNotifications.Instance;
			int num2 = 0;
			if (instance3 != (UnityEngine.Object)num2)
			{
				XboxNotifications instance4 = XboxNotifications.Instance;
				XboxNotifications.ApplicationPauseCB value3 = OnConsoleApplicationPause;
				instance4.OnApplicationPause -= value3;
			}
			PlaystationNotifications instance5 = PlaystationNotifications.Instance;
			int num3 = 0;
			if (instance5 != (UnityEngine.Object)num3)
			{
				PlaystationNotifications instance6 = PlaystationNotifications.Instance;
				PlaystationNotifications.ApplicationPauseCB value4 = OnConsoleApplicationPause;
				instance6.OnApplicationPause -= value4;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8B")]
		[Cpp2IlInjected.Address(RVA = "0xA836A0", Offset = "0xA820A0", VA = "0x180A836A0", Slot = "4")]
		public unsafe string GetAvatarPosition()
		{
			//Discarded unreachable code: IL_00b2, IL_00b8
			//IL_0024: Expected O, but got I4
			//IL_0024: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField == null || (object)_003CInstance_003Ek__BackingField._avatar != null)
			{
			}
			int num3 = 0;
			int num4 = 0;
			if (!((UnityEngine.Object)num3 == (UnityEngine.Object)num4))
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				SystemRoot _003CInstance_003Ek__BackingField2 = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField2 != null && (object)_003CInstance_003Ek__BackingField2._sceneStack != null)
				{
					SceneData sceneData = default(SceneData);
					AsyncOperation operation = sceneData.sceneInstance.m_Operation;
					CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
					SceneItemData sceneItemData = sceneData.sceneItemData;
					GameObject gameObject = default(GameObject);
					if ((object)gameObject != null && (object)gameObject.GetComponent<Mdl.Environments.Environment>() != null)
					{
						GridScript gridScript = default(GridScript);
						if ((object)gridScript == null)
						{
							goto IL_0093;
						}
						int allowInvalid = 0;
						GridPosition gridPosition = gridScript.GetGridPosition(in *(Vector3*)num, 1, (byte)allowInvalid != 0);
						int num5 = 0;
					}
				}
				int num6 = 0;
				goto IL_0093;
			}
			goto IL_00ac;
			IL_0093:
			int num7 = 0;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			uint gridID = default(uint);
			GridPosition gridPos = default(GridPosition);
			GridPosition direction = default(GridPosition);
			string avatarPosition = UnityContextExtensions.GetAvatarPosition(gridID, gridPos, direction);
			goto IL_00ac;
			IL_00ac:
			return string.Empty;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8C")]
		[Cpp2IlInjected.Address(RVA = "0xA842A0", Offset = "0xA82CA0", VA = "0x180A842A0", Slot = "5")]
		public string GetDeviceName()
		{
			int num = 0;
			int num2 = 0;
			if ("_Unity_Editor" != null)
			{
				return "_Unity_Editor" + "_Unity_Editor";
			}
			return "_Unity_Editor";
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8D")]
		[Cpp2IlInjected.Address(RVA = "0xA84300", Offset = "0xA82D00", VA = "0x180A84300", Slot = "6")]
		public string GetPlatformName()
		{
			return PlatformUtils.GetRunningPlatformName();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8E")]
		[Cpp2IlInjected.Address(RVA = "0xA84310", Offset = "0xA82D10", VA = "0x180A84310", Slot = "7")]
		public PlayfabNativeAuth GetRuntimePlayfabNativeAuth()
		{
			int num = 0;
			return PlatformUtils.GetRuntimePlayfabNativeAuth();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E94")]
		[Cpp2IlInjected.Address(RVA = "0xA82DD0", Offset = "0xA817D0", VA = "0x180A82DD0", Slot = "12")]
		public void AddUnityInterceptor(HostBuilder builderClient)
		{
			//Discarded unreachable code: IL_0016
			InterceptorFunc interceptorFunc = delegate(HostBuilderState state, ICallInvoker invoker)
			{
				InventoryFullInterceptor inventoryFullInterceptor = new InventoryFullInterceptor(invoker, this);
				/*Error: Unexpected end of block*/;
			};
			InterceptorBuilder interceptorBuilder = builderClient.AddInterceptor<InventoryFullInterceptor>(interceptorFunc);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E95")]
		[Cpp2IlInjected.Address(RVA = "0xA83680", Offset = "0xA82080", VA = "0x180A83680")]
		public void InitForceOfflineReasonAtStart()
		{
			//IL_0009: Expected I4, but got I8
			_forceOfflineReasonFlag = ForceOfflineReasonFlag.None;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E96")]
		[Cpp2IlInjected.Address(RVA = "0xA83680", Offset = "0xA82080", VA = "0x180A83680")]
		public void ClearAllForceOffline()
		{
			//IL_0009: Expected I4, but got I8
			_forceOfflineReasonFlag = ForceOfflineReasonFlag.None;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E97")]
		[Cpp2IlInjected.Address(RVA = "0xA84BF0", Offset = "0xA835F0", VA = "0x180A84BF0")]
		public void SetForceOfflineReason(ForceOfflineReasonFlag offlineReason)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E98")]
		[Cpp2IlInjected.Address(RVA = "0xA83690", Offset = "0xA82090", VA = "0x180A83690")]
		public void ClearForceOfflineReason(ForceOfflineReasonFlag offlineReason)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E9B")]
		[Cpp2IlInjected.Address(RVA = "0xA843D0", Offset = "0xA82DD0", VA = "0x180A843D0")]
		public bool IsForceOfflineBy(ForceOfflineReasonFlag offlineReason)
		{
			return _forceOfflineReasonFlag == offlineReason;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E9E")]
		[Cpp2IlInjected.Address(RVA = "0xA84DC0", Offset = "0xA837C0", VA = "0x180A84DC0")]
		private void UpdateUserTotalTimeInGame()
		{
			//IL_0041: Expected O, but got I4
			Meta.Online.Client client = MetaClient;
			if (client != null && client.TransactionService != null)
			{
				Meta.Online.Client client2 = MetaClient;
				Meta.Online.Client client3 = default(Meta.Online.Client);
				if (client2 != null && (long)client2.profile != 0 && client2 != null && client3 != null)
				{
					int num = 0;
					int num2 = 0;
					client3.UpdateTimeAcumulatedAsync(5, (ProfileTimerType)num2, (CancellationToken)num).FireAndForgetTask();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E9F")]
		[Cpp2IlInjected.Address(RVA = "0xA843E0", Offset = "0xA82DE0", VA = "0x180A843E0")]
		[AsyncStateMachine(typeof(_003CMetaClient_OnInventoryFull_003Ed__53))]
		private Task<bool> MetaClient_OnInventoryFull(IInventoryFullRequest request, IInventoryFullResponse response)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA0")]
		[Cpp2IlInjected.Address(RVA = "0xA84520", Offset = "0xA82F20", VA = "0x180A84520")]
		private void OnConsoleApplicationPause(bool isPaused)
		{
			//Discarded unreachable code: IL_0050
			Meta.Online.Client metaClient;
			do
			{
				if (isPaused)
				{
					SystemRoot.Instance.GetSystem<AudioManager>().PauseSystem();
					return;
				}
				SystemRoot.Instance.GetSystem<AudioManager>().ResumeSystem();
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				while ((object)_003CInstance_003Ek__BackingField == null)
				{
				}
				metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				while (metaClient == null)
				{
				}
			}
			while (metaClient.TransactionService == null);
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA1")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public Client()
		{
		}
	}
}
