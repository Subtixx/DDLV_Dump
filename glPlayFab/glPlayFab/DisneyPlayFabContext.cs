using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using PlayFab;
using Serilog;
using Serilog.Configuration;
using Serilog.Core;
using Serilog.Events;
using Serilog.Sinks.SystemConsole.Themes;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class DisneyPlayFabContext : PlayFabContext
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private class PlayFabGlobalSettings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public string TitleId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public string DeveloperSecretKey;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public SerilogAdapter Logger;

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public PlayFabGlobalSettings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private class PlayFabAuthSession
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public PlayFabAuthenticationContext Context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public DateTime? TokenExpiration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public SemaphoreSlim RefreshTokenSemaphore;

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public bool IsServerTokenRefreshRequired
			{
				[Cpp2IlInjected.Token(Token = "0x6000139")]
				[Cpp2IlInjected.Address(RVA = "0x14EFB00", Offset = "0x14EE500", VA = "0x1814EFB00")]
				get
				{
					//Discarded unreachable code: IL_0018
					if ((long)playFabAuthSession.Context == 0)
					{
						return true;
					}
					return HasServerTokenExpired;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public bool HasServerTokenExpired
			{
				[Cpp2IlInjected.Token(Token = "0x600013A")]
				[Cpp2IlInjected.Address(RVA = "0x14EF8F0", Offset = "0x14EE2F0", VA = "0x1814EF8F0")]
				get
				{
					//Discarded unreachable code: IL_002f
					PlayFabAuthSession playFabAuthSession = DisneyPlayFabContext.playFabAuthSession;
					int num = 0;
					DateTime utcNow = DateTime.UtcNow;
					uint minValue = default(uint);
					uint maxValue = default(uint);
					int num2 = new Random().Next((int)minValue, (int)maxValue);
					PlayFabAuthSession playFabAuthSession2 = DisneyPlayFabContext.playFabAuthSession;
					DateTime dateTime = default(DateTime);
					DateTime dateTime2 = default(DateTime);
					return dateTime > dateTime2;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x14EF830", Offset = "0x14EE230", VA = "0x1814EF830")]
			public int GetEarlyTokenRefreshTimeInSeconds(bool addRandomOffset)
			{
				//Discarded unreachable code: IL_0023
				int num = 0;
				if (addRandomOffset)
				{
					uint minValue = default(uint);
					uint maxValue = default(uint);
					int num2 = new Random().Next((int)minValue, (int)maxValue);
				}
				int earlyTokenRefreshTimeInSeconds = EarlyTokenRefreshTimeInSeconds;
				return earlyTokenRefreshTimeInSeconds + num;
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public PlayFabAuthSession()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private static int EarlyTokenRefreshTimeInSeconds;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private static PlayFabGlobalSettings playFabGlobalSettings;

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private static PlayFabAuthSession playFabAuthSession;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public static readonly string ProfileFilename;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly string MiniProfileFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly string CurrencyDreamDust = "DreamDust";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public readonly string CurrencyHardCurrency = "Gem";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly string CurrencySoftCurrency = "StarCoin";

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public readonly string CurrencySocialCurrency = "Heart";

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public readonly string LeaderboardNameLikes = "Likes";

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public readonly string LeaderboardCategoryGiven = "Given";

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public readonly string LeaderboardCategoryReceived = "Received";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public readonly string LeaderboardTypeAllTime = "AllTime";

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public readonly int MaxLikesGivenRewardsPerDay = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public readonly int MaxLikesReceivedRewardsPerDay = 10;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly string SpentHardCurrencyPrefix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public readonly string PendingVoteFileName = "pending_vote";

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public readonly string PendingSubmissionFileName = "pending_submission";

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public readonly string FollowersFilename = "followers";

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public readonly string FollowingLeaderboard = "FollowingsCount";

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public readonly string FollowerLeaderboard = "FollowersCount";

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static string LatestGameVersionLeaderboard;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static string LeaderboardDisplayNameUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public readonly int DisplayNameUpdateFrequencyInDays = 30;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public readonly string UserDataKey_CurrentSessionToken = "CurrentSessionToken";

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public readonly string UserDataKey_CurrentGameSessionInfo = "CurrentGameSessionInfo";

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public const string UserDataKey_IsDev = "IsDev";

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public const string UserDataKey_IsDevBattlePass = "IsDevBattlePass";

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public const string UserDataKey_IsDevShop = "IsDevShop";

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public const string UserDataKey_IsTesterEnv = "IsTesterEnv";

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public const string UserDataKey_IsQAPromo = "IsQAPromo";

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string DailyLeaderboardNameLikesGiven
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x102DFC0", Offset = "0x102C9C0", VA = "0x18102DFC0")]
			get
			{
				int num = 0;
				DateTime utcNow = DateTime.UtcNow;
				string result = default(string);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string DailyLeaderboardNameLikesReceived
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x102E050", Offset = "0x102CA50", VA = "0x18102E050")]
			get
			{
				int num = 0;
				DateTime utcNow = DateTime.UtcNow;
				string result = default(string);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string AllTimeLeaderboardNameLikesGiven
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x102DFA0", Offset = "0x102C9A0", VA = "0x18102DFA0")]
			get
			{
				string leaderboardCategoryGiven = LeaderboardCategoryGiven;
				return AllTimeLeaderboardNameLikes(leaderboardCategoryGiven);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string AllTimeLeaderboardNameLikesReceived
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x102DFB0", Offset = "0x102C9B0", VA = "0x18102DFB0")]
			get
			{
				string leaderboardCategoryReceived = LeaderboardCategoryReceived;
				return AllTimeLeaderboardNameLikes(leaderboardCategoryReceived);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string ClientVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x975C80", Offset = "0x974680", VA = "0x180975C80")]
			[CompilerGenerated]
			get
			{
				return _003CClientVersion_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x976520", Offset = "0x974F20", VA = "0x180976520")]
			[CompilerGenerated]
			private set
			{
				_003CClientVersion_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x102D360", Offset = "0x102BD60", VA = "0x18102D360")]
		private static void SetPlayFabSettings(string titleId, string secretKey, Serilog.ILogger logger)
		{
			//Discarded unreachable code: IL_00eb
			//IL_0032: Expected I4, but got O
			//IL_0075: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_00d8: Expected O, but got I4
			PlayFabGlobalSettings playFabGlobalSettings = DisneyPlayFabContext.playFabGlobalSettings;
			if (playFabGlobalSettings != null && (long)playFabGlobalSettings.Logger != 0)
			{
				return;
			}
			PlayFabGlobalSettings playFabGlobalSettings2 = new PlayFabGlobalSettings();
			playFabGlobalSettings2.TitleId = titleId;
			playFabGlobalSettings2.DeveloperSecretKey = secretKey;
			EarlyTokenRefreshTimeInSeconds = (int)playFabGlobalSettings2;
			PlayFabSettings.staticSettings.TitleId = titleId;
			PlayFabSettings.staticSettings.DeveloperSecretKey = secretKey;
			int num = 0;
			if (logger == null)
			{
				LoggerConfiguration loggerConfiguration = new LoggerConfiguration();
				int num2 = 0;
				LoggerSinkConfiguration _003CWriteTo_003Ek__BackingField = loggerConfiguration.WriteTo;
				int num3 = 0;
				LoggerConfiguration loggerConfiguration2 = ConsoleLoggerConfigurationExtensions.Console(_003CWriteTo_003Ek__BackingField, (LogEventLevel)num3, "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}", (IFormatProvider)num2, (LoggingLevelSwitch)num, (Nullable<>)num, (ConsoleTheme)num);
				int num4 = 0;
				LoggerSinkConfiguration _003CWriteTo_003Ek__BackingField2 = loggerConfiguration2.WriteTo;
				int restrictedToMinimumLevel = 0;
				Serilog.Core.Logger logger2 = _003CWriteTo_003Ek__BackingField2.Debug((LogEventLevel)restrictedToMinimumLevel, "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}", (IFormatProvider)num4, (LoggingLevelSwitch)num).CreateLogger();
			}
			PlayFabGlobalSettings playFabGlobalSettings3 = DisneyPlayFabContext.playFabGlobalSettings;
			SerilogAdapter serilogAdapter = (playFabGlobalSettings3.Logger = new SerilogAdapter(logger));
			SerilogAdapter logger3 = DisneyPlayFabContext.playFabGlobalSettings.Logger;
			IPlayFabPlugin playFabPlugin = default(IPlayFabPlugin);
			if (playFabPlugin != null)
			{
				int num5 = 0;
				if (playFabPlugin != null)
				{
					return;
				}
			}
			int num6 = default(int);
			PlayFabSysHttp plugin = new PlayFabSysHttp(logger3, (ICloudScriptExecutor)num6);
			num6 = 0;
			PluginManager.SetPlugin(plugin, PluginContract.PlayFab_Transport);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x102D780", Offset = "0x102C180", VA = "0x18102D780")]
		private static void UpdatePlayFabTitleSettings(string titleId, string secretKey)
		{
			PlayFabSettings.staticSettings.TitleId = titleId;
			PlayFabSettings.staticSettings.DeveloperSecretKey = secretKey;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x102C890", Offset = "0x102B290", VA = "0x18102C890")]
		[AsyncStateMachine(typeof(_003CCreateForClientAsync_003Ed__7))]
		public static Task<(DisneyPlayFabContext, PlayFabError)> CreateForClientAsync(string titleId, string secretKey, string clientEntityToken, [Optional] string clientVersion, [Optional] Serilog.ILogger logger)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<(DisneyPlayFabContext, PlayFabError)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x102CA10", Offset = "0x102B410", VA = "0x18102CA10")]
		[AsyncStateMachine(typeof(_003CCreateForServerAsync_003Ed__8))]
		public static Task<(DisneyPlayFabContext, PlayFabError)> CreateForServerAsync(string titleId, string secretKey, [Optional] string clientVersion, [Optional] Serilog.ILogger logger)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<(DisneyPlayFabContext, PlayFabError)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x102CB90", Offset = "0x102B590", VA = "0x18102CB90")]
		[AsyncStateMachine(typeof(_003CCreateForServersAsync_003Ed__9))]
		public static Task<List<DisneyPlayFabContext>> CreateForServersAsync(List<(string, string)> titles, [Optional] string clientVersion, [Optional] Serilog.ILogger logger)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<List<DisneyPlayFabContext>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x102D230", Offset = "0x102BC30", VA = "0x18102D230")]
		[AsyncStateMachine(typeof(_003CRefreshAuthSession_003Ed__10))]
		public static Task<PlayFabError> RefreshAuthSession([Optional] Serilog.ILogger logger)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PlayFabError>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x102CCF0", Offset = "0x102B6F0", VA = "0x18102CCF0")]
		public string DailyLeaderboardNameLikesReceivedByDay(DayOfWeek dayOfWeek)
		{
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x102CD10", Offset = "0x102B710", VA = "0x18102CD10")]
		public string DailyLeaderboardNameLikes(string category, DayOfWeek dayOfWeek)
		{
			//Discarded unreachable code: IL_008d
			string[] array;
			while (true)
			{
				array = new string[5];
				string leaderboardNameLikes = LeaderboardNameLikes;
				if (leaderboardNameLikes != null && array == null)
				{
					continue;
				}
				array[0] = leaderboardNameLikes;
				if ("_" != null && "_" == null)
				{
					continue;
				}
				array[1] = "_";
				if (category != null && "_" == null)
				{
					continue;
				}
				array[2] = category;
				if ("_" == null || "_" != null)
				{
					array[3] = "_";
					if ("_" == null || "_" != null)
					{
						break;
					}
				}
			}
			array[4] = "_";
			return string.Concat(array);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x102C4C0", Offset = "0x102AEC0", VA = "0x18102C4C0")]
		public string AllTimeLeaderboardNameLikes(string category)
		{
			//Discarded unreachable code: IL_008c
			string[] array;
			string leaderboardTypeAllTime;
			while (true)
			{
				array = new string[5];
				string leaderboardNameLikes = LeaderboardNameLikes;
				if (leaderboardNameLikes != null && array == null)
				{
					continue;
				}
				array[0] = leaderboardNameLikes;
				if ("_" != null && "_" == null)
				{
					continue;
				}
				array[1] = "_";
				if (category != null && "_" == null)
				{
					continue;
				}
				array[2] = category;
				if ("_" == null || "_" != null)
				{
					array[3] = "_";
					leaderboardTypeAllTime = LeaderboardTypeAllTime;
					if (leaderboardTypeAllTime == null || "_" != null)
					{
						break;
					}
				}
			}
			array[4] = leaderboardTypeAllTime;
			return string.Concat(array);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x102C810", Offset = "0x102B210", VA = "0x18102C810")]
		public static string ConfigName(ConfigType type)
		{
			//Discarded unreachable code: IL_0006
			return (string)typeof(ConfigType).TypeHandle;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x102C7A0", Offset = "0x102B1A0", VA = "0x18102C7A0")]
		public static string ConfigFilename(ConfigType type)
		{
			string text = default(string);
			return text + ".json";
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x102C720", Offset = "0x102B120", VA = "0x18102C720")]
		public static string BuildConfigKey(ConfigType type, string version)
		{
			string text = default(string);
			return text + "_" + version;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x102D9E0", Offset = "0x102C3E0", VA = "0x18102D9E0")]
		public DisneyPlayFabContext(ClientSession session, [Optional] ILogger logger, [Optional] string clientVersion)
			: base(session, logger)
		{
			//IL_0062: Expected I4, but got I8
			//IL_006c: Expected I4, but got I8
			//IL_00ad: Expected I4, but got I8
			if ("FollowingsCount" != null)
			{
			}
			ClientVersion = clientVersion;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x102DCC0", Offset = "0x102C6C0", VA = "0x18102DCC0")]
		public DisneyPlayFabContext(PlayFabAuthenticationContext context, User user, string userToken, HttpClientWithTimeout httpClient, [Optional] ILogger logger, [Optional] string clientVersion)
		{
			//IL_0062: Expected I4, but got I8
			//IL_006c: Expected I4, but got I8
			//IL_00ad: Expected I4, but got I8
			//IL_00ca: Expected O, but got I4
			ClientVersion = (string)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x102D0F0", Offset = "0x102BAF0", VA = "0x18102D0F0")]
		[AsyncStateMachine(typeof(_003CIsDisplayNameChangeAvailable_003Ed__59))]
		public Task<bool> IsDisplayNameChangeAvailable([Optional] CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x102CFB0", Offset = "0x102B9B0", VA = "0x18102CFB0")]
		public bool IsDisplayNameChangeAvailable(string lastChangeTimeAsStr)
		{
			int num = 0;
			if ((object)typeof(DateTime).TypeHandle != null)
			{
			}
			int num2 = 0;
			DateTime dateTime = Convert.ToDateTime(lastChangeTimeAsStr);
			DateTime self = default(DateTime);
			long num3 = self.Days();
			int num4 = 0;
			long num5 = DateTime.UtcNow.Days();
			return num3 <= num5;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x102D830", Offset = "0x102C230", VA = "0x18102D830")]
		static DisneyPlayFabContext()
		{
			//IL_001a: Expected I4, but got O
			//IL_0024: Expected I4, but got O
			//IL_002e: Expected I4, but got O
			//IL_0038: Expected I4, but got O
			//IL_0042: Expected I4, but got O
			//IL_004c: Expected I4, but got O
			PlayFabAuthSession playFabAuthSession = new PlayFabAuthSession();
			SemaphoreSlim semaphoreSlim = (playFabAuthSession.RefreshTokenSemaphore = new SemaphoreSlim(1));
			EarlyTokenRefreshTimeInSeconds = (int)playFabAuthSession;
			EarlyTokenRefreshTimeInSeconds = (int)"profile";
			EarlyTokenRefreshTimeInSeconds = (int)"mini_profile";
			EarlyTokenRefreshTimeInSeconds = (int)"Spent_";
			EarlyTokenRefreshTimeInSeconds = (int)"LatestGameVersion";
			EarlyTokenRefreshTimeInSeconds = (int)"DisplayName_Update";
			throw new NullReferenceException();
		}
	}
}
