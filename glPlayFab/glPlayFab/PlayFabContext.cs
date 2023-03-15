using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using PlayFab;
using PlayFab.ClientModels;
using PlayFab.CloudScriptModels;
using PlayFab.DataModels;
using PlayFab.EconomyModels;
using PlayFab.LeaderboardsModels;
using PlayFab.ProfilesModels;
using PlayFab.ServerModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	public class PlayFabContext
	{
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		public class Log
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			private ILogger logger;

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
			public Log(ILogger logger)
			{
				this.logger = logger;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x1AEB570", Offset = "0x1AE9F70", VA = "0x181AEB570")]
			public void info(string msg)
			{
				if (logger == null)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x1AEB5F0", Offset = "0x1AE9FF0", VA = "0x181AEB5F0")]
			public void warning(string msg)
			{
				if (logger == null)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0x1AEB4F0", Offset = "0x1AE9EF0", VA = "0x181AEB4F0")]
			public void error(string msg)
			{
				if (logger == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000103")]
		public class GetOnlineTitleDataConfigResult<TitleDataConfigType> where TitleDataConfigType : ITitleDataConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public TitleDataConfigType Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public bool WasSync;

			[Cpp2IlInjected.Token(Token = "0x60004FF")]
			[Cpp2IlInjected.Address(RVA = "0x2452F10", Offset = "0x2451910", VA = "0x182452F10")]
			public GetOnlineTitleDataConfigResult<TitleDataConfigType> WithOnlineData(TitleDataConfigType data)
			{
				((GetOnlineTitleDataConfigResult<>)(object)this).Data = data;
				((GetOnlineTitleDataConfigResult<>)(object)this).WasSync = true;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x911AA0", VA = "0x1809130A0")]
			public GetOnlineTitleDataConfigResult()
			{
			}//Discarded unreachable code: IL_0007

		}

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public const string ConfigTitleId = "76926";

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public const string DebugConfigTitleSettingsKey = "DebugSettings";

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public const string ConfigTitleSettingsKey = "NewSettings";

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public const string TitleConfigFilename = "TitleConfig";

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public const string TitleEventsFilename = "TitleEvents";

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public const int MaxEnvironments = 4;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public const string PlaystationAppServerClientId = "9f82ad68-2134-44c3-acd7-398e4e3c7eb9";

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public const string PlaystationAppServerClientSecret = "W8KSIaivtL3Z6NX2";

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private const int IssuerIdDevelopment = 1;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private const int IssuerIdQA = 8;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private const int IssuerIdProduction = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public readonly PlayFabClientInstanceAPI client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public readonly PlayFabAuthenticationInstanceAPI auth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public readonly PlayFabAdminInstanceAPI admin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public readonly PlayFabServerInstanceAPI server;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public readonly PlayFabDataInstanceAPI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public readonly PlayFabCloudScriptInstanceAPI cloudscript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public readonly PlayFabLeaderboardsInstanceAPI leaderboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public readonly PlayFabEconomyInstanceAPI economy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public readonly PlayFabProfilesInstanceAPI profiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public readonly PlayFabEventsInstanceAPI events;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public readonly PlayFabGroupsInstanceAPI groups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public readonly PlayFabExperimentationInstanceAPI experimentation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public readonly HttpClientWithTimeout http;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public readonly PlayFabTLEContext tleCtx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public readonly string BasePlayFabId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public readonly string BaseEntityId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public readonly string BaseEntityType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		protected readonly Random random;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		protected readonly Log log;

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		private TitleConfig TitleConfig
		{
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			[CompilerGenerated]
			get
			{
				return _003CTitleConfig_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4A0", Offset = "0x7D9EA0", VA = "0x1807DB4A0")]
			[CompilerGenerated]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		private List<Event> TitleEvents
		{
			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			[CompilerGenerated]
			get
			{
				return _003CTitleEvents_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0x7DB490", Offset = "0x7D9E90", VA = "0x1807DB490")]
			[CompilerGenerated]
			set
			{
				_003CTitleEvents_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		private TitleDataConfigHolder<FeaturesToggleConfig> FeaturesToggleConfig
		{
			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			[CompilerGenerated]
			get
			{
				return _003CFeaturesToggleConfig_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0xAE8630", Offset = "0xAE7030", VA = "0x180AE8630")]
			[CompilerGenerated]
			set
			{
				_003CFeaturesToggleConfig_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public string BaseEntityToken
		{
			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF50", Offset = "0x7D9950", VA = "0x1807DAF50")]
			[CompilerGenerated]
			get
			{
				return _003CBaseEntityToken_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4B0", Offset = "0x7D9EB0", VA = "0x1807DB4B0")]
			[CompilerGenerated]
			private set
			{
				_003CBaseEntityToken_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		protected ISerializerPlugin Serializer
		{
			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0x103C700", Offset = "0x103B100", VA = "0x18103C700")]
			get
			{
				return PluginManager.GetPlugin<ISerializerPlugin>(PluginContract.PlayFab_Serializer, "");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public string TitleId
		{
			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0x103C770", Offset = "0x103B170", VA = "0x18103C770")]
			get
			{
				//Discarded unreachable code: IL_002a
				PlayFabApiSettings apiSettings;
				do
				{
					PlayFabAuthenticationInstanceAPI playFabAuthenticationInstanceAPI = auth;
					if (playFabAuthenticationInstanceAPI == null)
					{
						break;
					}
					apiSettings = playFabAuthenticationInstanceAPI.apiSettings;
				}
				while (apiSettings != null && apiSettings.TitleId != null);
				return PlayFabSettings.staticSettings.TitleId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public string TitlePlayerAccountEntityType
		{
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x103C800", Offset = "0x103B200", VA = "0x18103C800")]
			get
			{
				return Entity.GetName(Entity.Types.TitlePlayerAccount);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public PlayFab.DataModels.EntityKey DataEntity
		{
			[Cpp2IlInjected.Token(Token = "0x60004DD")]
			[Cpp2IlInjected.Address(RVA = "0x103C340", Offset = "0x103AD40", VA = "0x18103C340")]
			get
			{
				Entity.Types type = Entity.GetType(BaseEntityType);
				PlayFab.DataModels.EntityKey result = default(PlayFab.DataModels.EntityKey);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public PlayFab.LeaderboardsModels.EntityKey LeaderboardsEntity
		{
			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0x103C580", Offset = "0x103AF80", VA = "0x18103C580")]
			get
			{
				Entity.Types type = Entity.GetType(BaseEntityType);
				PlayFab.LeaderboardsModels.EntityKey result = default(PlayFab.LeaderboardsModels.EntityKey);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public PlayFab.CloudScriptModels.EntityKey CloudScriptEntity
		{
			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0x103C2B0", Offset = "0x103ACB0", VA = "0x18103C2B0")]
			get
			{
				Entity.Types type = Entity.GetType(BaseEntityType);
				PlayFab.CloudScriptModels.EntityKey result = default(PlayFab.CloudScriptModels.EntityKey);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public PlayFab.EconomyModels.EntityKey EconomyEntity
		{
			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0x103C430", Offset = "0x103AE30", VA = "0x18103C430")]
			get
			{
				Entity.Types type = Entity.GetType(BaseEntityType);
				PlayFab.EconomyModels.EntityKey result = default(PlayFab.EconomyModels.EntityKey);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		public PlayFab.ProfilesModels.EntityKey ProfilesEntity
		{
			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0x103C670", Offset = "0x103B070", VA = "0x18103C670")]
			get
			{
				Entity.Types type = Entity.GetType(BaseEntityType);
				PlayFab.ProfilesModels.EntityKey result = default(PlayFab.ProfilesModels.EntityKey);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		[field: Cpp2IlInjected.Token(Token = "0x40003A2")]
		public static PlayFab.ClientModels.PlayerProfileViewConstraints DefaultProfileConstraintsClient
		{
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0x103C3D0", Offset = "0x103ADD0", VA = "0x18103C3D0")]
			get;
		} = (PlayFab.ClientModels.PlayerProfileViewConstraints)(object)new PlayFab.ServerModels.PlayerProfileViewConstraints
		{
			ShowAvatarUrl = true,
			ShowCreated = true,
			ShowLinkedAccounts = true,
			ShowPushNotificationRegistrations = true,
			ShowValuesToDate = true
		};


		[Cpp2IlInjected.Token(Token = "0x17000152")]
		[field: Cpp2IlInjected.Token(Token = "0x40003A3")]
		public static PlayFab.ClientModels.PlayerProfileViewConstraints LocationsProfileConstraintsClient
		{
			[Cpp2IlInjected.Token(Token = "0x60004E3")]
			[Cpp2IlInjected.Address(RVA = "0x103C610", Offset = "0x103B010", VA = "0x18103C610")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		[field: Cpp2IlInjected.Token(Token = "0x40003A4")]
		public static PlayFab.ClientModels.PlayerProfileViewConstraints FullProfileConstraintsClient
		{
			[Cpp2IlInjected.Token(Token = "0x60004E4")]
			[Cpp2IlInjected.Address(RVA = "0x103C4C0", Offset = "0x103AEC0", VA = "0x18103C4C0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		[field: Cpp2IlInjected.Token(Token = "0x40003A5")]
		public static PlayFab.ServerModels.PlayerProfileViewConstraints FullProfileConstraintsServer
		{
			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0x103C520", Offset = "0x103AF20", VA = "0x18103C520")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x1039C20", Offset = "0x1038620", VA = "0x181039C20")]
		public string GetEnvironmentBaseURL(int issuerId)
		{
			return issuerId switch
			{
				1 => "https://s2s.sp-int.playstation.net", 
				8 => "https://s2s.prod-qa.playstation.net", 
				_ => "https://s2s.np.playstation.net", 
			};
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x103AD60", Offset = "0x1039760", VA = "0x18103AD60")]
		public bool IsDebugTitle()
		{
			string titleId = TitleId;
			if (string.IsNullOrEmpty(titleId))
			{
				int num = 0;
			}
			string titleId2 = OnlineEnvironmentConfig.GetTitleId(OnlineEnvironment.Debug);
			return string.Equals(titleId, titleId2);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x103ADF0", Offset = "0x10397F0", VA = "0x18103ADF0")]
		public bool IsDevTitle()
		{
			string titleId = TitleId;
			if (string.IsNullOrEmpty(titleId))
			{
				int num = 0;
			}
			string titleId2 = OnlineEnvironmentConfig.GetTitleId(OnlineEnvironment.Dev);
			return string.Equals(titleId, titleId2);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x103AE80", Offset = "0x1039880", VA = "0x18103AE80")]
		protected void LogError(PlayFabError error, string message, params object[] args)
		{
			//Discarded unreachable code: IL_002b
			Log log = this.log;
			string text = string.Format(message, args);
			string text2 = error.GenerateErrorReport();
			string msg = text + ": " + text2;
			log.error(msg);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x103BFE0", Offset = "0x103A9E0", VA = "0x18103BFE0")]
		public PlayFabContext(ClientSession session, [Optional] ILogger logger)
		{
			//Discarded unreachable code: IL_011a
			int num = 0;
			DateTime utcNow = DateTime.UtcNow;
			int seed = default(int);
			random = new Random(seed);
			base._002Ector();
			PlayFabClientInstanceAPI playFabClientInstanceAPI = (client = session.client);
			PlayFabAuthenticationInstanceAPI playFabAuthenticationInstanceAPI = (auth = session.auth);
			PlayFabDataInstanceAPI playFabDataInstanceAPI = (data = session.data);
			PlayFabLeaderboardsInstanceAPI playFabLeaderboardsInstanceAPI = (leaderboards = session.leaderboards);
			PlayFabCloudScriptInstanceAPI playFabCloudScriptInstanceAPI = (cloudscript = session.cloudscript);
			PlayFabEconomyInstanceAPI playFabEconomyInstanceAPI = (economy = session.economy);
			PlayFabProfilesInstanceAPI playFabProfilesInstanceAPI = (profiles = session.profiles);
			HttpClientWithTimeout httpClientWithTimeout = (http = session.http);
			string text = (BasePlayFabId = session.loginResult.PlayFabId);
			string text2 = (BaseEntityId = session.loginResult.EntityToken.Entity.Id);
			string text3 = (BaseEntityType = session.loginResult.EntityToken.Entity.Type);
			string text4 = (BaseEntityToken = session.loginResult.EntityToken.EntityToken);
			Log log = (this.log = new Log(logger));
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x103B9A0", Offset = "0x103A3A0", VA = "0x18103B9A0")]
		public PlayFabContext(PlayFabAuthenticationContext context, User user, string userEntityToken, HttpClientWithTimeout httpClient, [Optional] ILogger logger)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x103B680", Offset = "0x103A080", VA = "0x18103B680")]
		public void UpdateAuthenticationContext(PlayFabAuthenticationContext newAuthenticationContext)
		{
			auth?.authenticationContext?.CopyFrom(newAuthenticationContext);
			admin?.authenticationContext?.CopyFrom(newAuthenticationContext);
			server?.authenticationContext?.CopyFrom(newAuthenticationContext);
			data?.authenticationContext?.CopyFrom(newAuthenticationContext);
			leaderboards?.authenticationContext?.CopyFrom(newAuthenticationContext);
			cloudscript?.authenticationContext?.CopyFrom(newAuthenticationContext);
			economy?.authenticationContext?.CopyFrom(newAuthenticationContext);
			profiles?.authenticationContext?.CopyFrom(newAuthenticationContext);
			events?.authenticationContext?.CopyFrom(newAuthenticationContext);
			groups?.authenticationContext?.CopyFrom(newAuthenticationContext);
			experimentation?.authenticationContext?.CopyFrom(newAuthenticationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x7DB4B0", Offset = "0x7D9EB0", VA = "0x1807DB4B0")]
		public void UpdateUserEntityToken(string newEntityToken)
		{
			BaseEntityToken = newEntityToken;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x103AF30", Offset = "0x1039930", VA = "0x18103AF30")]
		public Entity.Types ResolveEntityType(string type)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x1039880", Offset = "0x1038280", VA = "0x181039880")]
		public PlayFab.DataModels.EntityKey CreateDataEntity(string id, Entity.Types type)
		{
			//Discarded unreachable code: IL_0018
			PlayFab.DataModels.EntityKey entityKey = new PlayFab.DataModels.EntityKey();
			entityKey.Id = id;
			string _003CType_003Ek__BackingField = default(string);
			entityKey.Type = _003CType_003Ek__BackingField;
			return entityKey;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x1039AA0", Offset = "0x10384A0", VA = "0x181039AA0")]
		public PlayFab.LeaderboardsModels.EntityKey CreateLeaderboardEntity(string id, Entity.Types type)
		{
			//Discarded unreachable code: IL_0018
			PlayFab.LeaderboardsModels.EntityKey entityKey = new PlayFab.LeaderboardsModels.EntityKey();
			entityKey.Id = id;
			string _003CType_003Ek__BackingField = default(string);
			entityKey.Type = _003CType_003Ek__BackingField;
			return entityKey;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x10397C0", Offset = "0x10381C0", VA = "0x1810397C0")]
		public PlayFab.CloudScriptModels.EntityKey CreateCloudScriptEntity(string id, Entity.Types type)
		{
			//Discarded unreachable code: IL_0018
			PlayFab.CloudScriptModels.EntityKey entityKey = new PlayFab.CloudScriptModels.EntityKey();
			entityKey.Id = id;
			string _003CType_003Ek__BackingField = default(string);
			entityKey.Type = _003CType_003Ek__BackingField;
			return entityKey;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x1039940", Offset = "0x1038340", VA = "0x181039940")]
		public PlayFab.EconomyModels.EntityKey CreateEconomyEntity(string id, Entity.Types type)
		{
			//Discarded unreachable code: IL_0018
			PlayFab.EconomyModels.EntityKey entityKey = new PlayFab.EconomyModels.EntityKey();
			entityKey.Id = id;
			string _003CType_003Ek__BackingField = default(string);
			entityKey.Type = _003CType_003Ek__BackingField;
			return entityKey;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x1039A10", Offset = "0x1038410", VA = "0x181039A10")]
		public PlayFab.EconomyModels.EntityKey CreateEconomyEntity(string id, string type)
		{
			//Discarded unreachable code: IL_0016
			PlayFab.EconomyModels.EntityKey entityKey = new PlayFab.EconomyModels.EntityKey();
			entityKey.Id = id;
			entityKey.Type = type;
			return entityKey;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x1039B60", Offset = "0x1038560", VA = "0x181039B60")]
		public PlayFab.ProfilesModels.EntityKey CreateProfileEntity(string id, Entity.Types type)
		{
			//Discarded unreachable code: IL_0018
			PlayFab.ProfilesModels.EntityKey entityKey = new PlayFab.ProfilesModels.EntityKey();
			entityKey.Id = id;
			string _003CType_003Ek__BackingField = default(string);
			entityKey.Type = _003CType_003Ek__BackingField;
			return entityKey;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x103A9E0", Offset = "0x10393E0", VA = "0x18103A9E0")]
		[AsyncStateMachine(typeof(_003CGetTitleConfigAsync_003Ed__90))]
		public Task<TitleConfig> GetTitleConfigAsync([Optional] CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<TitleConfig>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x103AB10", Offset = "0x1039510", VA = "0x18103AB10")]
		[AsyncStateMachine(typeof(_003CGetTitleEventsAsync_003Ed__91))]
		public Task<List<Event>> GetTitleEventsAsync([Optional] CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<List<Event>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x26D2460", Offset = "0x26D0E60", VA = "0x1826D2460")]
		[AsyncStateMachine(typeof(_003CGetOnlineTitleDataConfig_003Ed__93<>))]
		public Task<GetOnlineTitleDataConfigResult<TitleDataConfigType>> GetOnlineTitleDataConfig<TitleDataConfigType>(TitleDataConfigType defaultData, [Optional] CancellationToken ct) where TitleDataConfigType : ITitleDataConfig
		{
			int num = 0;
			int num2 = 0;
			Task<> result = default(Task<>);
			return (Task<GetOnlineTitleDataConfigResult<TitleDataConfigType>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x1039CA0", Offset = "0x10386A0", VA = "0x181039CA0")]
		[AsyncStateMachine(typeof(_003CGetFeaturesToggleConfigAsync_003Ed__94))]
		public Task<FeaturesToggleConfig> GetFeaturesToggleConfigAsync([Optional] FeaturesToggleConfig defaultData, [Optional] ITitleDataOnlineSyncCondition syncCondition, [Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<FeaturesToggleConfig>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x103A180", Offset = "0x1038B80", VA = "0x18103A180")]
		[AsyncStateMachine(typeof(_003CGetMinUser_003Ed__95))]
		public Task<User> GetMinUser([Optional] CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<User>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x1039F40", Offset = "0x1038940", VA = "0x181039F40")]
		[AsyncStateMachine(typeof(_003CGetMaxUser_003Ed__96))]
		public Task<User> GetMaxUser([Optional] CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<User>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x103A2A0", Offset = "0x1038CA0", VA = "0x18103A2A0")]
		[AsyncStateMachine(typeof(_003CGetNewsfeedUsers_003Ed__97))]
		public Task<List<User>> GetNewsfeedUsers([Optional] CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<List<User>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x103A060", Offset = "0x1038A60", VA = "0x18103A060")]
		[AsyncStateMachine(typeof(_003CGetMinUserEntityAsync_003Ed__98))]
		public Task<PlayFab.LeaderboardsModels.EntityKey> GetMinUserEntityAsync()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PlayFab.LeaderboardsModels.EntityKey>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x1039E20", Offset = "0x1038820", VA = "0x181039E20")]
		[AsyncStateMachine(typeof(_003CGetMaxUserEntityAsync_003Ed__99))]
		public Task<PlayFab.LeaderboardsModels.EntityKey> GetMaxUserEntityAsync()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PlayFab.LeaderboardsModels.EntityKey>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x103AFB0", Offset = "0x10399B0", VA = "0x18103AFB0", Slot = "4")]
		public virtual Task<StartEvent.Result> StartEventAsync(StartEvent.Request request)
		{
			return (Task<StartEvent.Result>)(object)Task.FromResult(new StartEvent.Result());
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x103B040", Offset = "0x1039A40", VA = "0x18103B040")]
		public List<CurrencyDetails> ToCurrencyDetails(List<(string, int)> currencies)
		{
			//Discarded unreachable code: IL_003b, IL_0041, IL_0047, IL_004d
			List<CurrencyDetails> list = (List<CurrencyDetails>)(object)new List<T>();
			bool flag = default(bool);
			if (flag)
			{
				CurrencyDetails currencyDetails = new CurrencyDetails();
				CatalogAlternateId catalogAlternateId = new CatalogAlternateId();
				catalogAlternateId.Type = "FriendlyId";
				currencyDetails.AlternateId = catalogAlternateId;
				currencyDetails.Amount = 0;
				((List<T>)(object)list).Add((T)currencyDetails);
			}
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x1039680", Offset = "0x1038080", VA = "0x181039680")]
		[AsyncStateMachine(typeof(_003CAddCurrencies_003Ed__102))]
		public Task<PlayFabResult<AddVirtualCurrenciesResult>> AddCurrencies(List<(string, int)> currencies)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<AddVirtualCurrenciesResult>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x103A3E0", Offset = "0x1038DE0", VA = "0x18103A3E0")]
		[AsyncStateMachine(typeof(_003CGetProfileAsync_003Ed__103))]
		public Task<PlayFabResult<GetEntityProfileResponse>> GetProfileAsync(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<GetEntityProfileResponse>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x103A7E0", Offset = "0x10391E0", VA = "0x18103A7E0")]
		[AsyncStateMachine(typeof(_003CGetStatisticsAsync_003Ed__104))]
		public Task<IReadOnlyDictionary<string, PlayFab.ProfilesModels.EntityStatisticValue>> GetStatisticsAsync(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<IReadOnlyDictionary<string, PlayFab.ProfilesModels.EntityStatisticValue>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x103A930", Offset = "0x1039330", VA = "0x18103A930")]
		public Task<Dictionary<string, PlayFab.ProfilesModels.EntityStatisticValue>> GetStatisticsAsync(EntityProfileBody profile, CancellationToken ct)
		{
			while (profile != null && profile.Statistics != null)
			{
			}
			return (Task<Dictionary<string, PlayFab.ProfilesModels.EntityStatisticValue>>)(object)Task.FromResult((Dictionary<string, PlayFab.ProfilesModels.EntityStatisticValue>)(object)new Dictionary<TKey, TValue>());
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x103A500", Offset = "0x1038F00", VA = "0x18103A500")]
		[AsyncStateMachine(typeof(_003CGetStatisticAsync_003Ed__106))]
		public Task<PlayFab.ProfilesModels.EntityStatisticValue> GetStatisticAsync(string name, [Optional] int? version, [Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PlayFab.ProfilesModels.EntityStatisticValue>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x103A670", Offset = "0x1039070", VA = "0x18103A670")]
		[AsyncStateMachine(typeof(_003CGetStatisticValue_003Ed__107))]
		public Task<int> GetStatisticValue(string name, int value, [Optional] int? version, [Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<int>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x103AC40", Offset = "0x1039640", VA = "0x18103AC40")]
		[AsyncStateMachine(typeof(_003CGetVirtualCurrenciesAsync_003Ed__108))]
		public Task<PlayFabResult<GetVirtualCurrenciesResult>> GetVirtualCurrenciesAsync(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<GetVirtualCurrenciesResult>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x103B7E0", Offset = "0x103A1E0", VA = "0x18103B7E0")]
		static PlayFabContext()
		{
			throw new NullReferenceException();
		}
	}
}
