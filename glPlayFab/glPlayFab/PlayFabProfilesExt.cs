using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using PlayFab;
using PlayFab.EconomyModels;
using PlayFab.LeaderboardsModels;
using PlayFab.ProfilesModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	public static class PlayFabProfilesExt
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x103F1C0", Offset = "0x103DBC0", VA = "0x18103F1C0")]
		public static PlayFab.ProfilesModels.EntityKey GetProfilesEntityKey(this PlayFabAuthenticationContext self)
		{
			//Discarded unreachable code: IL_0024
			PlayFab.ProfilesModels.EntityKey entityKey = new PlayFab.ProfilesModels.EntityKey();
			string text = (entityKey.Type = self.EntityType);
			string text2 = (entityKey.Id = self.EntityId);
			return entityKey;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x103ED60", Offset = "0x103D760", VA = "0x18103ED60")]
		public static PlayFab.ProfilesModels.EntityKey GetEntityKey(this PlayFabProfilesInstanceAPI self)
		{
			//Discarded unreachable code: IL_002b
			PlayFabAuthenticationContext authenticationContext = self.authenticationContext;
			PlayFab.ProfilesModels.EntityKey entityKey = new PlayFab.ProfilesModels.EntityKey();
			string text = (entityKey.Type = authenticationContext.EntityType);
			string text2 = (entityKey.Id = authenticationContext.EntityId);
			return entityKey;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x103F620", Offset = "0x103E020", VA = "0x18103F620")]
		public static PlayFab.LeaderboardsModels.EntityStatisticChildValue ToProfiles(this PlayFab.ProfilesModels.EntityStatisticChildValue self)
		{
			//Discarded unreachable code: IL_0032
			PlayFab.LeaderboardsModels.EntityStatisticChildValue entityStatisticChildValue = new PlayFab.LeaderboardsModels.EntityStatisticChildValue();
			string text = (entityStatisticChildValue.ChildName = self.ChildName);
			string text2 = (entityStatisticChildValue.Metadata = self.Metadata);
			int num = (entityStatisticChildValue.Value = self.Value);
			return entityStatisticChildValue;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x103F390", Offset = "0x103DD90", VA = "0x18103F390")]
		public static PlayFab.LeaderboardsModels.EntityStatisticValue ToLeaderboards(this PlayFab.ProfilesModels.EntityStatisticValue self)
		{
			//Discarded unreachable code: IL_00a6
			//IL_0064: Expected O, but got I4
			PlayFab.LeaderboardsModels.EntityStatisticValue entityStatisticValue = new PlayFab.LeaderboardsModels.EntityStatisticValue();
			Dictionary<string, PlayFab.ProfilesModels.EntityStatisticChildValue> childStatistics = self.ChildStatistics;
			if (childStatistics != null)
			{
				Func<KeyValuePair<string, PlayFab.ProfilesModels.EntityStatisticChildValue>, string> _003C_003E9__3_ = _003C_003Ec._003C_003E9__3_0;
				if (_003C_003E9__3_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				Func<KeyValuePair<string, PlayFab.ProfilesModels.EntityStatisticChildValue>, PlayFab.LeaderboardsModels.EntityStatisticChildValue> func = default(Func<KeyValuePair<string, PlayFab.ProfilesModels.EntityStatisticChildValue>, PlayFab.LeaderboardsModels.EntityStatisticChildValue>);
				if (_003C_003Ec._003C_003E9__3_1 == null)
				{
					func = (Func<KeyValuePair<string, PlayFab.ProfilesModels.EntityStatisticChildValue>, PlayFab.LeaderboardsModels.EntityStatisticChildValue>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				Dictionary<string, KeyValuePair<string, PlayFab.ProfilesModels.EntityStatisticChildValue>> dictionary = (Dictionary<string, KeyValuePair<string, PlayFab.ProfilesModels.EntityStatisticChildValue>>)(object)Enumerable.ToDictionary<KeyValuePair<string, PlayFab.ProfilesModels.EntityStatisticChildValue>, string, PlayFab.LeaderboardsModels.EntityStatisticChildValue>((IEnumerable<>)childStatistics, (Func<, >)(object)_003C_003E9__3_, (Func<, >)(object)func);
			}
			int num = 0;
			entityStatisticValue.ChildStatistics = (Dictionary<string, PlayFab.LeaderboardsModels.EntityStatisticChildValue>)num;
			string text = (entityStatisticValue.Metadata = self.Metadata);
			string text2 = (entityStatisticValue.Name = self.Name);
			int? num2 = (entityStatisticValue.Value = self.Value);
			int num3 = (entityStatisticValue.Version = self.Version);
			return entityStatisticValue;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x103EDF0", Offset = "0x103D7F0", VA = "0x18103EDF0")]
		[AsyncStateMachine(typeof(_003CGetProfileAsync_003Ed__4))]
		public static Task<PlayFabResult<GetEntityProfileResponse>> GetProfileAsync(this PlayFabProfilesInstanceAPI self, PlayFab.ProfilesModels.EntityKey entity)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<GetEntityProfileResponse>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x103EF30", Offset = "0x103D930", VA = "0x18103EF30")]
		[AsyncStateMachine(typeof(_003CGetProfilesAsync_003Ed__5))]
		public static Task<PlayFabResult<GetEntityProfilesResponse>> GetProfilesAsync(this PlayFabProfilesInstanceAPI self, List<PlayFab.ProfilesModels.EntityKey> entities, int throttle = 10)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<GetEntityProfilesResponse>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x103F080", Offset = "0x103DA80", VA = "0x18103F080")]
		[AsyncStateMachine(typeof(_003CGetProfilesAsync_003Ed__6))]
		public static Task<PlayFabResult<GetEntityProfilesResponse>> GetProfilesAsync(this PlayFabProfilesInstanceAPI self, List<PlayFab.EconomyModels.EntityKey> economyEntities)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<GetEntityProfilesResponse>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x103F240", Offset = "0x103DC40", VA = "0x18103F240")]
		[AsyncStateMachine(typeof(_003CGetTitlePlayersFromMasterPlayerAccountIdsAsync_003Ed__7))]
		public static Task<PlayFabResult<GetTitlePlayersFromMasterPlayerAccountIdsResponse>> GetTitlePlayersFromMasterPlayerAccountIdsAsync(this PlayFabProfilesInstanceAPI self, List<string> playfabIds, int throttle = 10)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<GetTitlePlayersFromMasterPlayerAccountIdsResponse>>)(object)result;
		}
	}
}
