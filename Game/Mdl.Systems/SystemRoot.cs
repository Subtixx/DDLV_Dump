using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Audio;
using Mdl.Avatar;
using Mdl.Graphic;
using Mdl.Online;
using Mdl.Platform;
using Mdl.Utils;
using Meta.ErrorReporting;
using Meta.Online;
using Meta.Util;
using Serilog;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;

namespace Mdl.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000977")]
	public class SystemRoot : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003448")]
		[SerializeField]
		private Mdl.Online.Client _client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003449")]
		[SerializeField]
		private Transform _systemContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400344A")]
		[SerializeField]
		private PlayerAvatar _avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400344B")]
		[SerializeField]
		private Camera _playerCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400344C")]
		[SerializeField]
		private Light _cameraLight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400344D")]
		[SerializeField]
		private UniversalAdditionalCameraData _playerCameraUniversalAdditionalData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400344E")]
		[SerializeField]
		private AssetReference _marketingCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400344F")]
		[SerializeField]
		private SceneStack _sceneStack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003450")]
		[SerializeField]
		private LocalizationManager _localizationManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003451")]
		[SerializeField]
		private FontManager _fontManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003452")]
		[SerializeField]
		private SavegameManager _saveGameManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003453")]
		[SerializeField]
		private LevelComplexityManager _levelComplexityManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4003455")]
		private bool _unityDoesntInitThisCorrectlyForThisConsole;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4003456")]
		private Dictionary<Type, System> _systems = (Dictionary<Type, System>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4003457")]
		private SeriloggerWrapper seriLoggerWrapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400345A")]
		[SerializeField]
		private ApplePlayFabAccountLinking platformMacos;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400345B")]
		private SettingScope _pauseLimiter;

		[Cpp2IlInjected.Token(Token = "0x17000644")]
		public static SystemRoot Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6002BF4")]
			[Cpp2IlInjected.Address(RVA = "0x106CB40", Offset = "0x106B540", VA = "0x18106CB40")]
			[CompilerGenerated]
			get
			{
				return _003CInstance_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BF5")]
			[Cpp2IlInjected.Address(RVA = "0x106CDF0", Offset = "0x106B7F0", VA = "0x18106CDF0")]
			[CompilerGenerated]
			private set
			{
				_003CInstance_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (SystemRoot)(object)new BacktraceReporter();


		[Cpp2IlInjected.Token(Token = "0x17000645")]
		public LevelComplexityManager LevelComplexityManager
		{
			[Cpp2IlInjected.Token(Token = "0x6002BF6")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return _levelComplexityManager;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000646")]
		public Mdl.Online.Client Client
		{
			[Cpp2IlInjected.Token(Token = "0x6002BF7")]
			[Cpp2IlInjected.Address(RVA = "0x106CA60", Offset = "0x106B460", VA = "0x18106CA60")]
			get
			{
				//IL_0010: Expected O, but got I4
				Mdl.Online.Client client = _client;
				int num = 0;
				if (client != (UnityEngine.Object)num)
				{
					return _client;
				}
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000647")]
		public Meta.Online.Client MetaClient
		{
			[Cpp2IlInjected.Token(Token = "0x6002BF8")]
			[Cpp2IlInjected.Address(RVA = "0x106CBD0", Offset = "0x106B5D0", VA = "0x18106CBD0")]
			get
			{
				Mdl.Online.Client client;
				do
				{
					client = Client;
				}
				while ((object)client == null);
				return client.MetaClient;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000648")]
		public OnlineClient MetaOnlineClient
		{
			[Cpp2IlInjected.Token(Token = "0x6002BF9")]
			[Cpp2IlInjected.Address(RVA = "0x106CBF0", Offset = "0x106B5F0", VA = "0x18106CBF0")]
			get
			{
				Mdl.Online.Client client = Client;
				if ((object)client != null)
				{
					Meta.Online.Client _003CMetaClient_003Ek__BackingField = client.MetaClient;
					if (_003CMetaClient_003Ek__BackingField != null)
					{
						return _003CMetaClient_003Ek__BackingField.OnlineClient;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000649")]
		public SceneStack SceneStack
		{
			[Cpp2IlInjected.Token(Token = "0x6002BFA")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return _sceneStack;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700064A")]
		public LocalizationManager LocalizationManager
		{
			[Cpp2IlInjected.Token(Token = "0x6002BFB")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return _localizationManager;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700064B")]
		public FontManager FontManager
		{
			[Cpp2IlInjected.Token(Token = "0x6002BFC")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return _fontManager;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700064C")]
		public SavegameManager SavegameManager
		{
			[Cpp2IlInjected.Token(Token = "0x6002BFD")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return _saveGameManager;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700064D")]
		public PlayerAvatar Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x6002BFE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _avatar;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700064E")]
		public Gameloft.Common.Version Version
		{
			[Cpp2IlInjected.Token(Token = "0x6002BFF")]
			[Cpp2IlInjected.Address(RVA = "0x106CC40", Offset = "0x106B640", VA = "0x18106CC40")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6002C00")]
			[Cpp2IlInjected.Address(RVA = "0x106CE60", Offset = "0x106B860", VA = "0x18106CE60")]
			[CompilerGenerated]
			private set
			{
				//IL_001a: Expected O, but got I4
				int build = value.version.build;
				string buildType = value.buildType;
				_003CVersion_003Ek__BackingField = (Gameloft.Common.Version)build;
				_003CVersion_003Ek__BackingField = (Gameloft.Common.Version)buildType;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700064F")]
		public Camera PlayerCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6002C01")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return _playerCamera;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000650")]
		public Light CameraLight
		{
			[Cpp2IlInjected.Token(Token = "0x6002C02")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return _cameraLight;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000651")]
		public UniversalAdditionalCameraData PlayerCameraURPData
		{
			[Cpp2IlInjected.Token(Token = "0x6002C03")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return _playerCameraUniversalAdditionalData;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000652")]
		public bool IsConsolePlatform
		{
			[Cpp2IlInjected.Token(Token = "0x6002C04")]
			[Cpp2IlInjected.Address(RVA = "0x106CBA0", Offset = "0x106B5A0", VA = "0x18106CBA0")]
			get
			{
				int num = 0;
				if (!Application.isConsolePlatform)
				{
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000653")]
		public IEnumerable<System> AllSystems
		{
			[Cpp2IlInjected.Token(Token = "0x6002C05")]
			[Cpp2IlInjected.Address(RVA = "0x106CA10", Offset = "0x106B410", VA = "0x18106CA10")]
			get
			{
				Dictionary<Type, System>.ValueCollection values = (Dictionary<Type, System>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)_systems).get_Values();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000654")]
		public Serilog.ILogger SeriLogger
		{
			[Cpp2IlInjected.Token(Token = "0x6002C06")]
			[Cpp2IlInjected.Address(RVA = "0x106CC20", Offset = "0x106B620", VA = "0x18106CC20")]
			get
			{
				SeriloggerWrapper seriloggerWrapper;
				do
				{
					seriloggerWrapper = seriLoggerWrapper;
				}
				while (seriloggerWrapper == null);
				return seriloggerWrapper.logger;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000655")]
		public SystemLogQueue LogQueue
		{
			[Cpp2IlInjected.Token(Token = "0x6002C07")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC30", Offset = "0x7D9630", VA = "0x1807DAC30")]
			[CompilerGenerated]
			get
			{
				return _003CLogQueue_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C08")]
			[Cpp2IlInjected.Address(RVA = "0xD2FD20", Offset = "0xD2E720", VA = "0x180D2FD20")]
			[CompilerGenerated]
			private set
			{
				_003CLogQueue_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000656")]
		public static IErrorReporter ErrorReporter
		{
			[Cpp2IlInjected.Token(Token = "0x6002C09")]
			[Cpp2IlInjected.Address(RVA = "0x106CAE0", Offset = "0x106B4E0", VA = "0x18106CAE0")]
			[CompilerGenerated]
			get
			{
				return _003CErrorReporter_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C0A")]
			[Cpp2IlInjected.Address(RVA = "0x106CD80", Offset = "0x106B780", VA = "0x18106CD80")]
			[CompilerGenerated]
			private set
			{
				Instance = (SystemRoot)value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C0B")]
		[Cpp2IlInjected.Address(RVA = "0x106C700", Offset = "0x106B100", VA = "0x18106C700")]
		private void _sceneStack_OnCurrentSceneChanged(SceneData scene)
		{
			//Discarded unreachable code: IL_0084
			//IL_0073: Expected O, but got I4
			int num = 0;
			if (!DebugSettings.Settings.showFPS_)
			{
				int num2 = 0;
				if (!DebugSettings.Settings.showMipmapStreamingInfo_)
				{
					int num3 = 0;
					if (!DebugSettings.Settings.showMemoryInfo_)
					{
						int num4 = 0;
						DebugSettings settings = DebugSettings.Settings;
					}
				}
			}
			if (ErrorReporter != null)
			{
				int num5 = 0;
				uint num6 = default(uint);
				if (num5 < (int)num6)
				{
					num5 += num5;
					num5++;
				}
			}
			uint num7 = default(uint);
			if (num7 != 0)
			{
				FPSDisplay component = base.gameObject.GetComponent<FPSDisplay>();
				int num8 = 0;
				if (component == (UnityEngine.Object)num8)
				{
					FPSDisplay fPSDisplay = base.gameObject.AddComponent<FPSDisplay>();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C0C")]
		[Cpp2IlInjected.Address(RVA = "0x106BA10", Offset = "0x106A410", VA = "0x18106BA10")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0105, IL_0164
			//IL_006f: Expected O, but got I4
			//IL_013c: Expected O, but got I4
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			Instance = this;
			SeriloggerWrapper seriloggerWrapper = SeriloggerWrapper.Instance;
			SeriloggerWrapper seriloggerWrapper2 = (seriLoggerWrapper = SeriloggerWrapper.Create(ErrorReporter));
			int num = 0;
			IErrorReporter errorReporter = ErrorReporter;
			if (errorReporter != null)
			{
				int num2 = 0;
				if (errorReporter == null)
				{
				}
			}
			int num3 = 0;
			int num4 = 0;
			if (Application.platform == RuntimePlatform.WindowsPlayer)
			{
				SystemLogQueue systemLogQueue = (LogQueue = new SystemLogQueue());
			}
			Gameloft.Common.Version version = default(Gameloft.Common.Version);
			int build = version.version.build;
			Version = (Gameloft.Common.Version)build;
			string text = (string)(Version = (Gameloft.Common.Version)version.buildType);
			System[] componentsInChildren = _systemContainer.GetComponentsInChildren<System>();
			int length = componentsInChildren.Length;
			if (num < length)
			{
				System system = componentsInChildren[num];
				GameObject gameObject = system.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				PlayerAvatar avatar = _avatar;
				Camera playerCamera = _playerCamera;
				system.avatar = avatar;
				system.playerCamera = playerCamera;
				Transform transform = (system.playerCameraTransform = playerCamera.transform);
				Dictionary<Type, System> systems = _systems;
				Type type = system.GetType();
				throw new NullReferenceException();
			}
			SceneStack sceneStack = _sceneStack;
			SceneStack.CurrentSceneChanged value = _sceneStack_OnCurrentSceneChanged;
			sceneStack.OnCurrentSceneChanged += value;
			LevelComplexityManager levelComplexityManager = _levelComplexityManager;
			int num5 = 0;
			if (levelComplexityManager != (UnityEngine.Object)num5)
			{
				LevelComplexityManager levelComplexityManager2 = _levelComplexityManager;
				LevelComplexityManager.ComplexityChanged value2 = _sceneStack.OnComplexityChanged;
				levelComplexityManager2.OnCurrentComplexityChanged += value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C0D")]
		[Cpp2IlInjected.Address(RVA = "0x106C250", Offset = "0x106AC50", VA = "0x18106C250")]
		private void OnDestroy()
		{
			//IL_001a: Expected O, but got I8
			//IL_0046: Expected O, but got I4
			_pauseLimiter?.Dispose();
			_pauseLimiter = (SettingScope)0;
			SystemLogQueue systemLogQueue = LogQueue;
			if (systemLogQueue != null)
			{
				Application.logMessageReceived -= systemLogQueue.OnLogMessage;
			}
			SceneStack sceneStack = _sceneStack;
			int num = 0;
			if (sceneStack != (UnityEngine.Object)num)
			{
				SceneStack sceneStack2 = _sceneStack;
				SceneStack.CurrentSceneChanged value = _sceneStack_OnCurrentSceneChanged;
				sceneStack2.OnCurrentSceneChanged -= value;
			}
			if ((bool)_levelComplexityManager)
			{
				LevelComplexityManager levelComplexityManager = _levelComplexityManager;
				LevelComplexityManager.ComplexityChanged value2 = _sceneStack.OnComplexityChanged;
				levelComplexityManager.OnCurrentComplexityChanged -= value2;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C0E")]
		[Cpp2IlInjected.Address(RVA = "0x1753290", Offset = "0x1751C90", VA = "0x181753290")]
		public bool SystemExist<T>() where T : System
		{
			//Discarded unreachable code: IL_000d
			Type key = default(Type);
			return ((Dictionary<TKey, TValue>)(object)_systems).ContainsKey((TKey)key);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C0F")]
		[Cpp2IlInjected.Address(RVA = "0x1753330", Offset = "0x1751D30", VA = "0x181753330")]
		public static bool TryGetSystem<T>(out T system) where T : System
		{
			//IL_000f: Expected O, but got I4
			SystemRoot systemRoot = Instance;
			int num = 0;
			if (systemRoot != (UnityEngine.Object)num)
			{
				SystemRoot systemRoot2 = Instance;
				int num2 = 0;
				return true;
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C10")]
		[Cpp2IlInjected.Address(RVA = "0x1752D00", Offset = "0x1751700", VA = "0x181752D00")]
		public T GetSystem<T>() where T : System
		{
			Type typeFromHandle = typeof(Type);
			DoValidation(typeFromHandle, "GetSystem");
			Type key = default(Type);
			System system = (System)((Dictionary<TKey, TValue>)(object)_systems)[(TKey)key];
			if ((object)system == null)
			{
			}
			if ((object)system != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C11")]
		[Cpp2IlInjected.Address(RVA = "0x1753030", Offset = "0x1751A30", VA = "0x181753030")]
		public T StartSystem<T>(ISystemData P_0) where T : System
		{
			Type typeFromHandle = typeof(Type);
			DoValidation(typeFromHandle, "StartSystem");
			Type key = default(Type);
			System system = (System)((Dictionary<TKey, TValue>)(object)_systems)[(TKey)key];
			system.StartSystem(P_0);
			if ((long)"{il2cpp array field il2cppMethodInfo->}" == 1)
			{
			}
			if ((object)system == null)
			{
			}
			if ((object)system != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C12")]
		[Cpp2IlInjected.Address(RVA = "0x17531A0", Offset = "0x1751BA0", VA = "0x1817531A0")]
		public void StopSystem<T>() where T : System
		{
			//Discarded unreachable code: IL_0029
			Type typeFromHandle = typeof(Type);
			DoValidation(typeFromHandle, "StopSystem");
			Type key = default(Type);
			((System)((Dictionary<TKey, TValue>)(object)_systems)[(TKey)key]).OnDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C13")]
		[Cpp2IlInjected.Address(RVA = "0x1752E50", Offset = "0x1751850", VA = "0x181752E50")]
		public void PauseSystem<T>() where T : System
		{
			//Discarded unreachable code: IL_0029
			Type typeFromHandle = typeof(Type);
			DoValidation(typeFromHandle, "PauseSystem");
			Type key = default(Type);
			((System)((Dictionary<TKey, TValue>)(object)_systems)[(TKey)key]).PauseSystem();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C14")]
		[Cpp2IlInjected.Address(RVA = "0x1752F40", Offset = "0x1751940", VA = "0x181752F40")]
		public void ResumeSystem<T>() where T : System
		{
			//Discarded unreachable code: IL_0029
			Type typeFromHandle = typeof(Type);
			DoValidation(typeFromHandle, "ResumeSystem");
			Type key = default(Type);
			((System)((Dictionary<TKey, TValue>)(object)_systems)[(TKey)key]).ResumeSystem();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C15")]
		[Cpp2IlInjected.Address(RVA = "0x106C020", Offset = "0x106AA20", VA = "0x18106C020")]
		public Task InitMarketingCamera()
		{
			AssetReference marketingCamera = _marketingCamera;
			Transform transform = base.transform;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C16")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void DoValidation(Type systemType, string caller)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002C17")]
		[Cpp2IlInjected.Address(RVA = "0x106C0C0", Offset = "0x106AAC0", VA = "0x18106C0C0")]
		private void OnApplicationFocus(bool hasFocus)
		{
			//Discarded unreachable code: IL_0096
			if (hasFocus)
			{
				int num = 0;
				if (!PlatformUtils.IsSteamDeck())
				{
					int num2 = 0;
					int width = Screen.width;
					int num3 = 0;
					int height = Screen.height;
				}
				int num4 = 0;
				int systemWidth = UnityEngine.Display.main.systemWidth;
				int num5 = 0;
				int systemHeight = UnityEngine.Display.main.systemHeight;
				int num6 = 0;
				bool fullScreen = Screen.fullScreen;
				Screen.SetResolution(systemWidth, systemHeight, fullScreen);
			}
			int num7 = 0;
			if ((object)typeof(UnityEngine.Display).TypeHandle == null)
			{
				GetSystem<AudioManager>()?.DoMuteAudio(hasFocus);
				if (!hasFocus && (object)_sceneStack != null)
				{
					SceneStack sceneStack = _sceneStack;
					int num8 = 0;
				}
				int pauseLimiter = 0;
				SetPauseLimiter((byte)pauseLimiter != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C18")]
		[Cpp2IlInjected.Address(RVA = "0x106C500", Offset = "0x106AF00", VA = "0x18106C500")]
		private void SetPauseLimiter(bool enabled)
		{
			//IL_001e: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			SettingScope pauseLimiter = _pauseLimiter;
			if (!enabled)
			{
				pauseLimiter?.Dispose();
				int num = 0;
				_pauseLimiter = (SettingScope)num;
			}
			if (pauseLimiter == null)
			{
				int num2 = 0;
				int num3 = 0;
				string text = default(string);
				SettingScope settingScope = new SettingScope(85, (Nullable<>)num2, (Nullable<>)num2, (Nullable<>)num2, text);
			}
			_pauseLimiter = pauseLimiter;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C19")]
		[Cpp2IlInjected.Address(RVA = "0x106CC70", Offset = "0x106B670", VA = "0x18106CC70")]
		public void initPlatformMacOS()
		{
			//Discarded unreachable code: IL_000c
			platformMacos.Init();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C1A")]
		[Cpp2IlInjected.Address(RVA = "0x106CCE0", Offset = "0x106B6E0", VA = "0x18106CCE0")]
		public void removePlatformMacOS()
		{
			int num = 0;
			if ("Remove Apple Platform" != null)
			{
				UnityEngine.Object.Destroy(platformMacos);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C1B")]
		[Cpp2IlInjected.Address(RVA = "0x106C680", Offset = "0x106B080", VA = "0x18106C680")]
		public SystemRoot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002C1C")]
		[Cpp2IlInjected.Address(RVA = "0x106C610", Offset = "0x106B010", VA = "0x18106C610")]
		static SystemRoot()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
