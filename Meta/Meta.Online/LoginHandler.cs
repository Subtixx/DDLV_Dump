using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CloudScripts;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.Common;
using Gameloft.FileSystem.Abstraction;
using glPlayFab;
using Meta.Online.Economy;
using Meta.Social;
using Meta.Util;
using Newtonsoft.Json;
using PlayFab;
using PlayFab.ClientModels;
using Serilog;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F4F")]
	public class LoginHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000F50")]
		public class OnlineEnvironmentResult
		{
			[Cpp2IlInjected.Token(Token = "0x170015E9")]
			public string TitleId
			{
				[Cpp2IlInjected.Token(Token = "0x6007DAF")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CTitleId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007DB0")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CTitleId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170015EA")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4003E80")]
			public OnlineEnvironment EnvType
			{
				[Cpp2IlInjected.Token(Token = "0x6007DB1")]
				[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6007DB2")]
				[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170015EB")]
			public PlayFabError PlayFabError
			{
				[Cpp2IlInjected.Token(Token = "0x6007DB3")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabError_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007DB4")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabError_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170015EC")]
			public bool IsValid
			{
				[Cpp2IlInjected.Token(Token = "0x6007DB5")]
				[Cpp2IlInjected.Address(RVA = "0x12F48E0", Offset = "0x12F32E0", VA = "0x1812F48E0")]
				get
				{
					if (EnvType != OnlineEnvironment.Invalid && !string.IsNullOrEmpty(TitleId))
					{
						return (long)PlayFabError == 0;
					}
					int num = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170015ED")]
			public static OnlineEnvironmentResult Invalid
			{
				[Cpp2IlInjected.Token(Token = "0x6007DB7")]
				[Cpp2IlInjected.Address(RVA = "0x12F4880", Offset = "0x12F3280", VA = "0x1812F4880")]
				get
				{
					//Discarded unreachable code: IL_0018
					//IL_0016: Expected I4, but got I8
					OnlineEnvironmentResult onlineEnvironmentResult = new OnlineEnvironmentResult();
					onlineEnvironmentResult.EnvType = OnlineEnvironment.Invalid;
					return onlineEnvironmentResult;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007DB6")]
			[Cpp2IlInjected.Address(RVA = "0x12F4860", Offset = "0x12F3260", VA = "0x1812F4860")]
			public OnlineEnvironmentResult WithPlayFabError(PlayFabError playFabError)
			{
				PlayFabError = playFabError;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6007DB8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public OnlineEnvironmentResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000F51")]
		public class LoginResult
		{
			[Cpp2IlInjected.Token(Token = "0x2000F52")]
			public enum ErrorCode
			{
				[Cpp2IlInjected.Token(Token = "0x4003E85")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4003E86")]
				AlreadyFullOnline,
				[Cpp2IlInjected.Token(Token = "0x4003E87")]
				FailedToGetEnvironment,
				[Cpp2IlInjected.Token(Token = "0x4003E88")]
				PlayFabLoginFailed,
				[Cpp2IlInjected.Token(Token = "0x4003E89")]
				PortalLoginFailed,
				[Cpp2IlInjected.Token(Token = "0x4003E8A")]
				OfflineOnly,
				[Cpp2IlInjected.Token(Token = "0x4003E8B")]
				NoInternet
			}

			[Cpp2IlInjected.Token(Token = "0x170015EE")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4003E82")]
			public ErrorCode Error
			{
				[Cpp2IlInjected.Token(Token = "0x6007DB9")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6007DBA")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170015EF")]
			public PlayFabError PlayFabError
			{
				[Cpp2IlInjected.Token(Token = "0x6007DBB")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabError_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007DBC")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabError_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170015F0")]
			public bool IsSuccess
			{
				[Cpp2IlInjected.Token(Token = "0x6007DBD")]
				[Cpp2IlInjected.Address(RVA = "0xE606E0", Offset = "0xE5F0E0", VA = "0x180E606E0")]
				get
				{
					return Error == ErrorCode.Success;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170015F1")]
			public bool IsWebError
			{
				[Cpp2IlInjected.Token(Token = "0x6007DBE")]
				[Cpp2IlInjected.Address(RVA = "0x12F4500", Offset = "0x12F2F00", VA = "0x1812F4500")]
				get
				{
					PlayFabError playFabError = PlayFabError;
					if (playFabError != null)
					{
						return playFabError.IsWebError();
					}
					if (Error == ErrorCode.NoInternet)
					{
						return true;
					}
					return 1L == 4L;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007DBF")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public LoginResult WithError(ErrorCode error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6007DC0")]
			[Cpp2IlInjected.Address(RVA = "0x763FD0", Offset = "0x7629D0", VA = "0x180763FD0")]
			public LoginResult WithPlayFabError(PlayFabError playFabError)
			{
				PlayFabError = playFabError;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6007DC1")]
			[Cpp2IlInjected.Address(RVA = "0x12F44A0", Offset = "0x12F2EA0", VA = "0x1812F44A0")]
			public static LoginResult New(ErrorCode error)
			{
				//Discarded unreachable code: IL_0011
				LoginResult loginResult = new LoginResult();
				loginResult.Error = error;
				return loginResult;
			}

			[Cpp2IlInjected.Token(Token = "0x6007DC2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public LoginResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000F53")]
		public enum LogoutResult
		{
			[Cpp2IlInjected.Token(Token = "0x4003E8D")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4003E8E")]
			AlreadyLoggedOut
		}

		[Cpp2IlInjected.Token(Token = "0x2000F54")]
		public delegate void PlayFabLoginCompleted(ClientSession clientSession);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003E70")]
		private readonly OnlineClient onlineClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003E71")]
		public readonly AuthManager AuthentificationManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003E73")]
		private CancellationTokenSource validateSessionCTS;

		[Cpp2IlInjected.Token(Token = "0x4003E74")]
		private const int LocationLoginInterval = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003E75")]
		private ClientSession clientSession;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003E7B")]
		public string TitleSettingsRelativePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003E7D")]
		private TimeSpan OnlineTimeOffset;

		[Cpp2IlInjected.Token(Token = "0x170015D9")]
		private Client client
		{
			[Cpp2IlInjected.Token(Token = "0x6007D7D")]
			[Cpp2IlInjected.Address(RVA = "0x18B26F0", Offset = "0x18B10F0", VA = "0x1818B26F0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return onlineClient.client;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015DA")]
		public EconomyManager EconomyManager
		{
			[Cpp2IlInjected.Token(Token = "0x6007D7E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CEconomyManager_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007D7F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			private set
			{
				_003CEconomyManager_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015DB")]
		private double ValidateSessionIntervalTime
		{
			[Cpp2IlInjected.Token(Token = "0x6007D80")]
			[Cpp2IlInjected.Address(RVA = "0x18B2640", Offset = "0x18B1040", VA = "0x1818B2640")]
			get
			{
				int num = 0;
				if (DebugSettings.Settings.forceValidateSessionIntervalTimeInSec_ > 0)
				{
					int num2 = 0;
					DebugSettings settings = DebugSettings.Settings;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015DC")]
		public ClientSession ClientSession
		{
			[Cpp2IlInjected.Token(Token = "0x6007D81")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return clientSession;
			}
			[Cpp2IlInjected.Token(Token = "0x6007D82")]
			[Cpp2IlInjected.Address(RVA = "0x18B27F0", Offset = "0x18B11F0", VA = "0x1818B27F0")]
			private set
			{
				//Discarded unreachable code: IL_0072
				//IL_002e: Expected O, but got I4
				if (clientSession != value)
				{
					CancellationTokenSource cancellationTokenSource = validateSessionCTS;
					int num = 0;
					if (cancellationTokenSource != null)
					{
						cancellationTokenSource.Cancel();
						validateSessionCTS.Dispose();
						validateSessionCTS = (CancellationTokenSource)num;
					}
					clientSession = value;
					bool flag = cancellationTokenSource != null;
					if (num != (flag ? 1 : 0) && (IntPtr)validateSessionCTS == (IntPtr)num)
					{
						CancellationTokenSource cancellationTokenSource2 = (validateSessionCTS = new CancellationTokenSource());
						CancellationToken token = validateSessionCTS.Token;
						int num2 = 0;
						int num3 = 0;
						Task asyncTask = default(Task);
						asyncTask.FireAndForgetTask();
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015DD")]
		public DisneyCloudScript PlayfabScriptExecutor
		{
			[Cpp2IlInjected.Token(Token = "0x6007D83")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CPlayfabScriptExecutor_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007D84")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			private set
			{
				_003CPlayfabScriptExecutor_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015DE")]
		public LoginResult LastLoginResult
		{
			[Cpp2IlInjected.Token(Token = "0x6007D85")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CLastLoginResult_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007D86")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			private set
			{
				_003CLastLoginResult_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015DF")]
		public CloudScripts.Login.Result CloudLastLoginResult
		{
			[Cpp2IlInjected.Token(Token = "0x6007D87")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CCloudLastLoginResult_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007D88")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			private set
			{
				_003CCloudLastLoginResult_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015E0")]
		internal OnlineEnvironmentResult CachedOnlineEnvironmentResult
		{
			[Cpp2IlInjected.Token(Token = "0x6007D89")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CCachedOnlineEnvironmentResult_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007D8A")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			private set
			{
				_003CCachedOnlineEnvironmentResult_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015E1")]
		public TitleSettings ClientTitleSettings
		{
			[Cpp2IlInjected.Token(Token = "0x6007D8B")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003CClientTitleSettings_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007D8C")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			private set
			{
				_003CClientTitleSettings_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015E2")]
		public Gameloft.Common.Version GameVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6007D8D")]
			[Cpp2IlInjected.Address(RVA = "0x18B2560", Offset = "0x18B0F60", VA = "0x1818B2560")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015E3")]
		internal Serilog.ILogger Log
		{
			[Cpp2IlInjected.Token(Token = "0x6007D8E")]
			[Cpp2IlInjected.Address(RVA = "0x18B25B0", Offset = "0x18B0FB0", VA = "0x1818B25B0")]
			get
			{
				Client client = onlineClient.client;
				if (client != null)
				{
					return client.Log;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015E4")]
		private PlayFab.ClientModels.LoginResult loginResult
		{
			[Cpp2IlInjected.Token(Token = "0x6007D8F")]
			[Cpp2IlInjected.Address(RVA = "0x18B2710", Offset = "0x18B1110", VA = "0x1818B2710")]
			get
			{
				AuthManager.LoginToPlayFabResult activeLogin = AuthentificationManager.ActiveLogin;
				if (activeLogin != null)
				{
					PlayFabResult<PlayFab.ClientModels.LoginResult> _003CLoginResult_003Ek__BackingField = activeLogin.LoginResult;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015E5")]
		private IFileSystem SaveFileSystem
		{
			[Cpp2IlInjected.Token(Token = "0x6007D90")]
			[Cpp2IlInjected.Address(RVA = "0x738FA0", Offset = "0x7379A0", VA = "0x180738FA0")]
			get
			{
				return FileSystem.Save;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015E6")]
		public DateTime OnlineTime
		{
			[Cpp2IlInjected.Token(Token = "0x6007D93")]
			[Cpp2IlInjected.Address(RVA = "0x18B25E0", Offset = "0x18B0FE0", VA = "0x1818B25E0")]
			get
			{
				int num = 0;
				DateTime utcNow = DateTime.UtcNow;
				TimeSpan onlineTimeOffset = OnlineTimeOffset;
				return utcNow + onlineTimeOffset;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015E7")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x78"), Cpp2IlInjected.Token(Token = "0x4003E7E")]
		public bool IsDevInPlayFab
		{
			[Cpp2IlInjected.Token(Token = "0x6007D94")]
			[Cpp2IlInjected.Address(RVA = "0xAE8610", Offset = "0xAE7010", VA = "0x180AE8610")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007D95")]
			[Cpp2IlInjected.Address(RVA = "0xBCC430", Offset = "0xBCAE30", VA = "0x180BCC430")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170015E8")]
		private bool HasValidateSessionActive
		{
			[Cpp2IlInjected.Token(Token = "0x6007DA5")]
			[Cpp2IlInjected.Address(RVA = "0x106AF40", Offset = "0x1069940", VA = "0x18106AF40")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x140000A2")]
		public event PlayFabLoginCompleted OnPlayFabLoginCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6007D91")]
			[Cpp2IlInjected.Address(RVA = "0x18B24C0", Offset = "0x18B0EC0", VA = "0x1818B24C0")]
			[CompilerGenerated]
			add
			{
				PlayFabLoginCompleted onPlayFabLoginCompleted = this.OnPlayFabLoginCompleted;
				Delegate @delegate = Delegate.Combine(onPlayFabLoginCompleted, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onPlayFabLoginCompleted)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6007D92")]
			[Cpp2IlInjected.Address(RVA = "0x18B2750", Offset = "0x18B1150", VA = "0x1818B2750")]
			[CompilerGenerated]
			remove
			{
				PlayFabLoginCompleted onPlayFabLoginCompleted = this.OnPlayFabLoginCompleted;
				Delegate @delegate = Delegate.Remove(onPlayFabLoginCompleted, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onPlayFabLoginCompleted)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007D79")]
		[Cpp2IlInjected.Address(RVA = "0x18B0CC0", Offset = "0x18AF6C0", VA = "0x1818B0CC0")]
		private string GetLocString(string val, string defaultVal)
		{
			return defaultVal;
		}

		[Cpp2IlInjected.Token(Token = "0x6007D7A")]
		[Cpp2IlInjected.Address(RVA = "0x18B11C0", Offset = "0x18AFBC0", VA = "0x1818B11C0")]
		[AsyncStateMachine(typeof(_003CHandleVersionUpdatePopup_003Ed__1))]
		private Task<bool> HandleVersionUpdatePopup(bool mandatory)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007D7B")]
		[Cpp2IlInjected.Address(RVA = "0x18B10B0", Offset = "0x18AFAB0", VA = "0x1818B10B0")]
		[AsyncStateMachine(typeof(_003CHandleMaintenancePopup_003Ed__2))]
		private Task HandleMaintenancePopup()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007D7C")]
		[Cpp2IlInjected.Address(RVA = "0x18B0FA0", Offset = "0x18AF9A0", VA = "0x1818B0FA0")]
		[AsyncStateMachine(typeof(_003CHandleKillVersionPopup_003Ed__3))]
		private Task HandleKillVersionPopup()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007D96")]
		[Cpp2IlInjected.Address(RVA = "0x18B0CF0", Offset = "0x18AF6F0", VA = "0x1818B0CF0")]
		public string GetPlayFabGameManagerLink(string titleId, string playfabID)
		{
			while ("" == null && "" == null)
			{
				string[] array = new string[5];
				if ("https://developer.playfab.com/en-US/" != null && "https://developer.playfab.com/en-US/" == null)
				{
					continue;
				}
				array[0] = "https://developer.playfab.com/en-US/";
				if (titleId != null && "https://developer.playfab.com/en-US/" == null)
				{
					continue;
				}
				array[1] = titleId;
				if ("/players/" != null && "/players/" == null)
				{
					continue;
				}
				array[2] = "/players/";
				if (playfabID == null || "/players/" != null)
				{
					array[3] = playfabID;
					if ("/overview" == null || "/overview" != null)
					{
						array[4] = "/overview";
						return string.Concat(array);
					}
				}
			}
			return "";
		}

		[Cpp2IlInjected.Token(Token = "0x6007D97")]
		[Cpp2IlInjected.Address(RVA = "0x18B2390", Offset = "0x18B0D90", VA = "0x1818B2390")]
		public LoginHandler(OnlineClient onlineClient)
		{
			//IL_0040: Expected O, but got I4
			LoginResult loginResult = (LastLoginResult = LoginResult.New(LoginResult.ErrorCode.OfflineOnly));
			int num = 0;
			OnlineEnvironmentResult onlineEnvironmentResult = (CachedOnlineEnvironmentResult = OnlineEnvironmentResult.Invalid);
			TitleSettings titleSettings = (ClientTitleSettings = new TitleSettings());
			TitleSettingsRelativePath = "config/title_settings.json";
			int num2 = 0;
			PostLogout((CancellationToken)num2);
			this.onlineClient = onlineClient;
			AuthManager authManager = (AuthentificationManager = new AuthManager(onlineClient));
			int num3 = 0;
			OnlineEnvironmentResult onlineEnvironmentResult2 = (CachedOnlineEnvironmentResult = OnlineEnvironmentResult.Invalid);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007D98")]
		[Cpp2IlInjected.Address(RVA = "0x18B0A10", Offset = "0x18AF410", VA = "0x1818B0A10")]
		public void Destroy()
		{
			//Discarded unreachable code: IL_0018
			CancellationTokenSource cancellationTokenSource = validateSessionCTS;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				cancellationTokenSource.Dispose();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007D99")]
		[Cpp2IlInjected.Address(RVA = "0x18B1E20", Offset = "0x18B0820", VA = "0x1818B1E20")]
		[AsyncStateMachine(typeof(_003CTryLogin_003Ed__66))]
		public Task<LoginResult> TryLogin(CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<LoginResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007D9A")]
		[Cpp2IlInjected.Address(RVA = "0x18B19C0", Offset = "0x18B03C0", VA = "0x1818B19C0")]
		private void PreLogin(CancellationToken ct)
		{
			//Discarded unreachable code: IL_002e
			IFileSystem _003CSave_003Ek__BackingField = FileSystem.Save;
			if ((object)typeof(FileSystem).TypeHandle != null)
			{
				string titleSettingsRelativePath = TitleSettingsRelativePath;
				TitleSettings titleSettings = (ClientTitleSettings = JsonConvert.DeserializeObject<TitleSettings>(FileSystem.Save.ReadAllText(titleSettingsRelativePath)));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007D9B")]
		[Cpp2IlInjected.Address(RVA = "0x18B15A0", Offset = "0x18AFFA0", VA = "0x1818B15A0")]
		[AsyncStateMachine(typeof(_003CLogin_003Ed__68))]
		private Task<LoginResult> Login(CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<LoginResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007D9C")]
		[Cpp2IlInjected.Address(RVA = "0x18B1D00", Offset = "0x18B0700", VA = "0x1818B1D00")]
		[AsyncStateMachine(typeof(_003CTryLoginPostSimulator_003Ed__69))]
		public Task TryLoginPostSimulator(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007D9D")]
		[Cpp2IlInjected.Address(RVA = "0x18B1890", Offset = "0x18B0290", VA = "0x1818B1890")]
		[AsyncStateMachine(typeof(_003CPostLogin_003Ed__70))]
		private Task PostLogin(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007D9E")]
		[Cpp2IlInjected.Address(RVA = "0x18B08D0", Offset = "0x18AF2D0", VA = "0x1818B08D0")]
		[AsyncStateMachine(typeof(_003CCheckAndTransferMarketplacePacks_003Ed__71))]
		private Task<Meta.Social.TransferMarketplacePacks.Types.Result?> CheckAndTransferMarketplacePacks(CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<Meta.Social.TransferMarketplacePacks.Types.Result?>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007D9F")]
		[Cpp2IlInjected.Address(RVA = "0x18B1F60", Offset = "0x18B0960", VA = "0x1818B1F60")]
		public LogoutResult TryLogout(CancellationToken ct)
		{
			//IL_001c: Expected O, but got I4
			//IL_0031: Expected I4, but got I8
			bool isLoggedInWithAllServices = this.onlineClient.IsLoggedInWithAllServices;
			LogoutFromPlayFab(ct);
			int num = 0;
			CloudLastLoginResult = (CloudScripts.Login.Result)num;
			OnlineClient onlineClient = this.onlineClient;
			int enable = 0;
			ulong num2 = default(ulong);
			onlineClient.SetOnlineStatus(OnlineClient.OnlineStatus.PortalLoggedIn, (byte)enable != 0, ct, (byte)num2 != 0);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007DA0")]
		[Cpp2IlInjected.Address(RVA = "0x18B16E0", Offset = "0x18B00E0", VA = "0x1818B16E0")]
		private void LogoutFromPlayFab(CancellationToken ct)
		{
			//Discarded unreachable code: IL_0083
			//IL_0041: Expected O, but got I4
			AuthentificationManager.LogoutFromPlayFab(ct);
			ITransportPlugin plugin = PluginManager.GetPlugin<ITransportPlugin>(PluginContract.PlayFab_Transport, "");
			if (plugin != null)
			{
				int num = 0;
				if (plugin != null)
				{
					int num2 = 0;
				}
			}
			ClientSession clientSession = this.clientSession;
			if (clientSession == null)
			{
				return;
			}
			clientSession.Dispose();
			int num3 = 0;
			ClientSession = (ClientSession)num3;
			Client client = onlineClient.client;
			if (client != null)
			{
				Simulator<SocialServiceServer, SocialService.SocialServiceClient> socialSimulator = client.socialSimulator;
				if (socialSimulator != null && ((Simulator<SERVER, CLIENT>)(object)socialSimulator).ServerService != null)
				{
					SocialServiceServer serverService = (SocialServiceServer)(object)((Simulator<SERVER, CLIENT>)(object)onlineClient.client.socialSimulator).ServerService;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007DA1")]
		[Cpp2IlInjected.Address(RVA = "0x18B0870", Offset = "0x18AF270", VA = "0x1818B0870")]
		private void LogoutFromPortal(CancellationToken ct)
		{
			//Discarded unreachable code: IL_001d
			//IL_0009: Expected O, but got I8
			//IL_001c: Expected I4, but got I8
			CloudLastLoginResult = (CloudScripts.Login.Result)0;
			OnlineClient onlineClient = this.onlineClient;
			int enable = 0;
			ulong num = default(ulong);
			onlineClient.SetOnlineStatus(OnlineClient.OnlineStatus.PortalLoggedIn, (byte)enable != 0, ct, (byte)num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6007DA2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void PostLogout(CancellationToken ct)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6007DA3")]
		[Cpp2IlInjected.Address(RVA = "0x18B07F0", Offset = "0x18AF1F0", VA = "0x1818B07F0")]
		public void CHEAT_LogoutFromPlayFab(CancellationToken ct)
		{
			//Discarded unreachable code: IL_0028
			//IL_0027: Expected I4, but got I8
			bool isLoggedInWithAllServices = this.onlineClient.IsLoggedInWithAllServices;
			LogoutFromPlayFab(ct);
			OnlineClient onlineClient = this.onlineClient;
			int enable = 0;
			ulong num = default(ulong);
			onlineClient.SetOnlineStatus(OnlineClient.OnlineStatus.PortalLoggedIn, (byte)enable != 0, ct, (byte)num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6007DA4")]
		[Cpp2IlInjected.Address(RVA = "0x18B0870", Offset = "0x18AF270", VA = "0x1818B0870")]
		public void CHEAT_LogoutFromPortal(CancellationToken ct)
		{
			//Discarded unreachable code: IL_001d
			//IL_0009: Expected O, but got I8
			//IL_001c: Expected I4, but got I8
			CloudLastLoginResult = (CloudScripts.Login.Result)0;
			OnlineClient onlineClient = this.onlineClient;
			int enable = 0;
			ulong num = default(ulong);
			onlineClient.SetOnlineStatus(OnlineClient.OnlineStatus.PortalLoggedIn, (byte)enable != 0, ct, (byte)num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6007DA6")]
		[Cpp2IlInjected.Address(RVA = "0x18B1B20", Offset = "0x18B0520", VA = "0x1818B1B20")]
		private void StartValidateSessionCTS()
		{
			//Discarded unreachable code: IL_0033
			if ((long)validateSessionCTS == 0)
			{
				CancellationTokenSource cancellationTokenSource = (validateSessionCTS = new CancellationTokenSource());
				CancellationToken token = validateSessionCTS.Token;
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007DA7")]
		[Cpp2IlInjected.Address(RVA = "0x18B0A10", Offset = "0x18AF410", VA = "0x1818B0A10")]
		private void EndValidateSessionCTS()
		{
			//Discarded unreachable code: IL_0018
			CancellationTokenSource cancellationTokenSource = validateSessionCTS;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				cancellationTokenSource.Dispose();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007DA8")]
		[Cpp2IlInjected.Address(RVA = "0x18B0B80", Offset = "0x18AF580", VA = "0x1818B0B80")]
		[AsyncStateMachine(typeof(_003CFetchOnlineEnvironmentWithCache_003Ed__82))]
		private Task<OnlineEnvironmentResult> FetchOnlineEnvironmentWithCache(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<OnlineEnvironmentResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007DA9")]
		[Cpp2IlInjected.Address(RVA = "0x18B0A60", Offset = "0x18AF460", VA = "0x1818B0A60")]
		[AsyncStateMachine(typeof(_003CFetchOnlineEnvironmentImpl_003Ed__83))]
		private Task<OnlineEnvironmentResult> FetchOnlineEnvironmentImpl(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<OnlineEnvironmentResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007DAA")]
		[Cpp2IlInjected.Address(RVA = "0x18B2130", Offset = "0x18B0B30", VA = "0x1818B2130")]
		[AsyncStateMachine(typeof(_003CValidateVersion_003Ed__84))]
		private Task<bool> ValidateVersion()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007DAB")]
		[Cpp2IlInjected.Address(RVA = "0x18B1300", Offset = "0x18AFD00", VA = "0x1818B1300")]
		[AsyncStateMachine(typeof(_003CLoginWithPlayfab_003Ed__85))]
		private Task<PlayFabError> LoginWithPlayfab(OnlineEnvironmentResult envResult, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PlayFabError>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007DAC")]
		[Cpp2IlInjected.Address(RVA = "0x18B1460", Offset = "0x18AFE60", VA = "0x1818B1460")]
		[AsyncStateMachine(typeof(_003CLoginWithPortal_003Ed__86))]
		private Task<bool> LoginWithPortal(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007DAD")]
		[Cpp2IlInjected.Address(RVA = "0x18B1FF0", Offset = "0x18B09F0", VA = "0x1818B1FF0")]
		[AsyncStateMachine(typeof(_003CUpdateSessionToken_003Ed__87))]
		public Task<bool> UpdateSessionToken([Optional] string fakeSessionToken)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007DAE")]
		[Cpp2IlInjected.Address(RVA = "0x18B2260", Offset = "0x18B0C60", VA = "0x1818B2260")]
		[AsyncStateMachine(typeof(_003CWaitForSessionValidation_003Ed__88))]
		private Task WaitForSessionValidation(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}
	}
}
