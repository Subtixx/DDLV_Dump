using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using PlayFab;
using PlayFab.ClientModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public static class PlayFabClientInstanceAPIExt
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x10362E0", Offset = "0x1034CE0", VA = "0x1810362E0")]
		public static GetPlayerCombinedInfoRequestParams GetFullInfoRequestParameters()
		{
			//Discarded unreachable code: IL_0062
			GetPlayerCombinedInfoRequestParams getPlayerCombinedInfoRequestParams = new GetPlayerCombinedInfoRequestParams();
			getPlayerCombinedInfoRequestParams.GetCharacterInventories = true;
			getPlayerCombinedInfoRequestParams.GetTitleData = true;
			getPlayerCombinedInfoRequestParams.GetUserReadOnlyData = true;
			List<string> list = (getPlayerCombinedInfoRequestParams.PlayerStatisticNames = (List<string>)(object)new List<T>());
			PlayerProfileViewConstraints playerProfileViewConstraints = (getPlayerCombinedInfoRequestParams.ProfileConstraints = PlayFabContext.DefaultProfileConstraintsClient);
			List<string> list2 = (getPlayerCombinedInfoRequestParams.TitleDataKeys = (List<string>)(object)new List<T>());
			List<string> list3 = (getPlayerCombinedInfoRequestParams.UserDataKeys = (List<string>)(object)new List<T>());
			List<string> list4 = (getPlayerCombinedInfoRequestParams.UserReadOnlyDataKeys = (List<string>)(object)new List<T>());
			return getPlayerCombinedInfoRequestParams;
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x10364B0", Offset = "0x1034EB0", VA = "0x1810364B0")]
		public static GetPlayerCombinedInfoRequestParams GetFullInfoWithLocationsRequestParameters()
		{
			//Discarded unreachable code: IL_0062
			GetPlayerCombinedInfoRequestParams getPlayerCombinedInfoRequestParams = new GetPlayerCombinedInfoRequestParams();
			getPlayerCombinedInfoRequestParams.GetCharacterInventories = true;
			getPlayerCombinedInfoRequestParams.GetTitleData = true;
			getPlayerCombinedInfoRequestParams.GetUserReadOnlyData = true;
			List<string> list = (getPlayerCombinedInfoRequestParams.PlayerStatisticNames = (List<string>)(object)new List<T>());
			PlayerProfileViewConstraints playerProfileViewConstraints = (getPlayerCombinedInfoRequestParams.ProfileConstraints = PlayFabContext.LocationsProfileConstraintsClient);
			List<string> list2 = (getPlayerCombinedInfoRequestParams.TitleDataKeys = (List<string>)(object)new List<T>());
			List<string> list3 = (getPlayerCombinedInfoRequestParams.UserDataKeys = (List<string>)(object)new List<T>());
			List<string> list4 = (getPlayerCombinedInfoRequestParams.UserReadOnlyDataKeys = (List<string>)(object)new List<T>());
			return getPlayerCombinedInfoRequestParams;
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x26D22B0", Offset = "0x26D0CB0", VA = "0x1826D22B0")]
		public static KeyValuePair<K, V> CreatePair<K, V>(K key, V value)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x1036A90", Offset = "0x1035490", VA = "0x181036A90")]
		[AsyncStateMachine(typeof(_003CLoginWithCustomIDWithRetriesAsync_003Ed__3))]
		public static Task<PlayFabResult<LoginResult>> LoginWithCustomIDWithRetriesAsync(this PlayFabClientInstanceAPI self, LoginWithCustomIDRequest request, int maxRetries = 10)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<LoginResult>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x1036990", Offset = "0x1035390", VA = "0x181036990")]
		public static Task<PlayFabResult<LoginResult>> LoginWithCustomIDAsync(this PlayFabClientInstanceAPI self, string customId, [Optional] string playerSecret, [Optional] string encryptedRequest, [Optional] GetPlayerCombinedInfoRequestParams infoRequestParameters, [Optional] string titleId, [Optional] bool? createAccount)
		{
			//Discarded unreachable code: IL_003e
			//IL_000d: Expected O, but got I4
			//IL_0022: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			LoginWithCustomIDRequest loginWithCustomIDRequest = new LoginWithCustomIDRequest();
			loginWithCustomIDRequest.CreateAccount = (bool?)(object)0;
			loginWithCustomIDRequest.CustomId = customId;
			loginWithCustomIDRequest.PlayerSecret = playerSecret;
			loginWithCustomIDRequest.TitleId = (string)0;
			loginWithCustomIDRequest.InfoRequestParameters = (GetPlayerCombinedInfoRequestParams)0;
			loginWithCustomIDRequest.EncryptedRequest = encryptedRequest;
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<LoginResult>>)(object)self.LoginWithCustomIDAsync(loginWithCustomIDRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x10370E0", Offset = "0x1035AE0", VA = "0x1810370E0")]
		[AsyncStateMachine(typeof(_003CUpdateUserDataAsync_003Ed__5))]
		public static Task<PlayFabResult<UpdateUserDataResult>> UpdateUserDataAsync(this PlayFabClientInstanceAPI self, [Optional] Dictionary<string, string> data, [Optional] IEnumerable<string> toRemove, [Optional] UserDataPermission? permissions, bool sendPlayStreamEvent = true)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<UpdateUserDataResult>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x1037250", Offset = "0x1035C50", VA = "0x181037250")]
		public static void WritePlayerEventAsync(this PlayFabClientInstanceAPI self, string eventName, Dictionary<string, string> data)
		{
			//Discarded unreachable code: IL_009e
			//IL_0084: Expected O, but got I4
			//IL_0084: Expected O, but got I4
			Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			if (data != null)
			{
				Func<KeyValuePair<string, string>, string> _003C_003E9__6_ = _003C_003Ec._003C_003E9__6_0;
				if (_003C_003E9__6_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				Func<KeyValuePair<string, string>, object> func = default(Func<KeyValuePair<string, string>, object>);
				if (_003C_003Ec._003C_003E9__6_1 == null)
				{
					func = (Func<KeyValuePair<string, string>, object>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				Dictionary<string, KeyValuePair<string, string>> dictionary2 = (Dictionary<string, KeyValuePair<string, string>>)(object)Enumerable.ToDictionary<KeyValuePair<string, string>, string, object>((IEnumerable<>)data, (Func<, >)(object)_003C_003E9__6_, (Func<, >)(object)func);
				PlayFabClientInstanceAPIExt.AddCustomEventBodyData((Dictionary<, >)(object)dictionary, (Dictionary<, >)(object)dictionary2);
			}
			WriteClientPlayerEventRequest writeClientPlayerEventRequest = new WriteClientPlayerEventRequest();
			writeClientPlayerEventRequest.EventName = eventName;
			writeClientPlayerEventRequest.Body = dictionary;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task<PlayFabResult<WriteEventResponse>> task = (Task<PlayFabResult<WriteEventResponse>>)(object)self.WritePlayerEventAsync(writeClientPlayerEventRequest, (object)num3, (Dictionary<, >)num2);
			int num4 = 0;
			int num5 = 0;
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x1036010", Offset = "0x1034A10", VA = "0x181036010")]
		public static void AddCustomEventBodyData(this Dictionary<string, object> body, Dictionary<string, object> data)
		{
			//Discarded unreachable code: IL_000b
			bool flag = default(bool);
			if (flag)
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x1036BE0", Offset = "0x10355E0", VA = "0x181036BE0")]
		[AsyncStateMachine(typeof(_003CPlayFabFireAndForgetTask_003Ed__8))]
		private static void PlayFabFireAndForgetTask(this Task asyncTask)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x1036F00", Offset = "0x1035900", VA = "0x181036F00")]
		public static Task<PlayFabResult<UpdateUserDataResult>> UpdateUserDataAsync(this PlayFabClientInstanceAPI self, string key, string data, [Optional] UserDataPermission? permissions)
		{
			//Discarded unreachable code: IL_000c, IL_0019
			Dictionary<string, string> dictionary = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x1036760", Offset = "0x1035160", VA = "0x181036760")]
		public static Task<PlayFabResult<GetUserDataResult>> GetUserDataAsync(this PlayFabClientInstanceAPI self, string key, [Optional] string playFabId, [Optional] uint? ifChangedFromDataVersion)
		{
			//Discarded unreachable code: IL_003f
			//IL_003e: Expected O, but got I4
			//IL_003e: Expected O, but got I4
			List<string> list = (List<string>)(object)new List<T>();
			((List<T>)(object)list).Add((T)key);
			GetUserDataRequest getUserDataRequest = new GetUserDataRequest();
			List<string> list2 = (getUserDataRequest.Keys = (List<string>)(object)Enumerable.ToList<string>((IEnumerable<>)list));
			getUserDataRequest.PlayFabId = playFabId;
			getUserDataRequest.IfChangedFromDataVersion = ifChangedFromDataVersion;
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<GetUserDataResult>>)(object)self.GetUserDataAsync(getUserDataRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x1036680", Offset = "0x1035080", VA = "0x181036680")]
		public static Task<PlayFabResult<GetUserDataResult>> GetUserDataAsync(this PlayFabClientInstanceAPI self, IEnumerable<string> keys, [Optional] string playFabId, [Optional] uint? ifChangedFromDataVersion)
		{
			//Discarded unreachable code: IL_0032
			//IL_0031: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			GetUserDataRequest getUserDataRequest = new GetUserDataRequest();
			List<string> list = (getUserDataRequest.Keys = (List<string>)(object)Enumerable.ToList<string>((IEnumerable<>)keys));
			getUserDataRequest.PlayFabId = playFabId;
			getUserDataRequest.IfChangedFromDataVersion = ifChangedFromDataVersion;
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<GetUserDataResult>>)(object)self.GetUserDataAsync(getUserDataRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x10368B0", Offset = "0x10352B0", VA = "0x1810368B0")]
		public static Task<PlayFabResult<GetUserDataResult>> GetUserReadOnlyDataAsync(this PlayFabClientInstanceAPI self, IEnumerable<string> keys, [Optional] string playFabId, [Optional] uint? ifChangedFromDataVersion)
		{
			//Discarded unreachable code: IL_0032
			//IL_0031: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			GetUserDataRequest getUserDataRequest = new GetUserDataRequest();
			List<string> list = (getUserDataRequest.Keys = (List<string>)(object)Enumerable.ToList<string>((IEnumerable<>)keys));
			getUserDataRequest.PlayFabId = playFabId;
			getUserDataRequest.IfChangedFromDataVersion = ifChangedFromDataVersion;
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<GetUserDataResult>>)(object)self.GetUserReadOnlyDataAsync(getUserDataRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x1036E50", Offset = "0x1035850", VA = "0x181036E50")]
		public static Task<PlayFabResult<UpdatePlayerStatisticsResult>> UpdatePlayerStatisticsAsync(this PlayFabClientInstanceAPI self, IEnumerable<StatisticUpdate> stats)
		{
			//Discarded unreachable code: IL_0024
			//IL_0023: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			UpdatePlayerStatisticsRequest updatePlayerStatisticsRequest = new UpdatePlayerStatisticsRequest();
			List<StatisticUpdate> list = (updatePlayerStatisticsRequest.Statistics = (List<StatisticUpdate>)(object)Enumerable.ToList<StatisticUpdate>((IEnumerable<>)stats));
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<UpdatePlayerStatisticsResult>>)(object)self.UpdatePlayerStatisticsAsync(updatePlayerStatisticsRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x1036CB0", Offset = "0x10356B0", VA = "0x181036CB0")]
		public static Task<PlayFabResult<UpdatePlayerStatisticsResult>> UpdatePlayerStatisticAsync(this PlayFabClientInstanceAPI self, string stat, int value = 1, [Optional] uint? version)
		{
			//Discarded unreachable code: IL_0054
			//IL_0053: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			StatisticUpdate[] array;
			StatisticUpdate statisticUpdate;
			do
			{
				array = new StatisticUpdate[1];
				statisticUpdate = new StatisticUpdate();
				statisticUpdate.StatisticName = stat;
				statisticUpdate.Value = value;
				statisticUpdate.Version = version;
			}
			while (statisticUpdate == null);
			array[0] = statisticUpdate;
			UpdatePlayerStatisticsRequest updatePlayerStatisticsRequest = new UpdatePlayerStatisticsRequest();
			List<StatisticUpdate> list = (updatePlayerStatisticsRequest.Statistics = (List<StatisticUpdate>)(object)Enumerable.ToList<StatisticUpdate>((IEnumerable<>)(object)array));
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<UpdatePlayerStatisticsResult>>)(object)self.UpdatePlayerStatisticsAsync(updatePlayerStatisticsRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x1036160", Offset = "0x1034B60", VA = "0x181036160")]
		public static Task<PlayFabResult<ExecuteCloudScriptResult>> ExecuteCloudScriptAsync(this PlayFabClientInstanceAPI self, string functionName, object functionParameter, [Optional] CloudScriptRevisionOption? revisionSelection, [Optional] int? specificRevision)
		{
			//Discarded unreachable code: IL_003e
			//IL_002d: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			ExecuteCloudScriptRequest executeCloudScriptRequest = new ExecuteCloudScriptRequest();
			PlayFabAuthenticationContext playFabAuthenticationContext = (executeCloudScriptRequest.AuthenticationContext = self.authenticationContext);
			executeCloudScriptRequest.FunctionName = functionName;
			executeCloudScriptRequest.FunctionParameter = functionParameter;
			int num = 0;
			int num2 = 0;
			executeCloudScriptRequest.SpecificRevision = (int?)(object)0;
			executeCloudScriptRequest.RevisionSelection = revisionSelection;
			return (Task<PlayFabResult<ExecuteCloudScriptResult>>)(object)self.ExecuteCloudScriptAsync(executeCloudScriptRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x1036240", Offset = "0x1034C40", VA = "0x181036240")]
		public static Task<PlayFabResult<GetFriendsListResult>> GetFriendsListAsync(this PlayFabClientInstanceAPI self, [Optional] PlayerProfileViewConstraints constraints)
		{
			//Discarded unreachable code: IL_001b
			//IL_001a: Expected O, but got I4
			//IL_001a: Expected O, but got I4
			GetFriendsListRequest getFriendsListRequest = new GetFriendsListRequest();
			getFriendsListRequest.ProfileConstraints = constraints;
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<GetFriendsListResult>>)(object)self.GetFriendsListAsync(getFriendsListRequest, (object)num2, (Dictionary<, >)num);
		}
	}
}
