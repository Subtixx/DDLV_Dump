using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using PlayFab;
using PlayFab.LeaderboardsModels;
using PlayFab.ProfilesModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	public static class PlayFabLeaderboardsInstanceAPIExt
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x103E350", Offset = "0x103CD50", VA = "0x18103E350")]
		public static PlayFab.LeaderboardsModels.EntityKey GetLeaderboardEntityKey(this PlayFabAuthenticationContext self)
		{
			//Discarded unreachable code: IL_0024
			PlayFab.LeaderboardsModels.EntityKey entityKey = new PlayFab.LeaderboardsModels.EntityKey();
			string text = (entityKey.Type = self.EntityType);
			string text2 = (entityKey.Id = self.EntityId);
			return entityKey;
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x103E2C0", Offset = "0x103CCC0", VA = "0x18103E2C0")]
		public static PlayFab.LeaderboardsModels.EntityKey GetEntityKey(this PlayFabLeaderboardsInstanceAPI self)
		{
			//Discarded unreachable code: IL_002b
			PlayFabAuthenticationContext authenticationContext = self.authenticationContext;
			PlayFab.LeaderboardsModels.EntityKey entityKey = new PlayFab.LeaderboardsModels.EntityKey();
			string text = (entityKey.Type = authenticationContext.EntityType);
			string text2 = (entityKey.Id = authenticationContext.EntityId);
			return entityKey;
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x103EC10", Offset = "0x103D610", VA = "0x18103EC10")]
		[AsyncStateMachine(typeof(_003CUpdateStatisticsWithRetriesAsync_003Ed__2))]
		public static Task<PlayFabResult<UpdateStatisticsResponse>> UpdateStatisticsWithRetriesAsync(this PlayFabLeaderboardsInstanceAPI self, UpdateStatisticsRequest request, int maxRetries = 4)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<UpdateStatisticsResponse>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x103EA10", Offset = "0x103D410", VA = "0x18103EA10")]
		public static Task<PlayFabResult<UpdateStatisticsResponse>> UpdateStatisticsAsync(this PlayFabLeaderboardsInstanceAPI self, PlayFab.LeaderboardsModels.EntityKey entity, IEnumerable<StatisticUpdate> statistics, [Optional] string metadata, [Optional] int? expectedProfileVersion, [Optional] bool? forceUpdate)
		{
			//Discarded unreachable code: IL_003b
			UpdateStatisticsRequest updateStatisticsRequest = new UpdateStatisticsRequest();
			updateStatisticsRequest.Entity = entity;
			updateStatisticsRequest.EntityLeaderboardMetadata = metadata;
			updateStatisticsRequest.ExpectedProfileVersion = (int?)updateStatisticsRequest;
			updateStatisticsRequest.ForceUpdate = (bool?)updateStatisticsRequest;
			List<StatisticUpdate> list = (updateStatisticsRequest.Statistics = (List<StatisticUpdate>)(object)Enumerable.ToList<StatisticUpdate>((IEnumerable<>)statistics));
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<UpdateStatisticsResponse>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x103E790", Offset = "0x103D190", VA = "0x18103E790")]
		public static Task<PlayFabResult<UpdateStatisticsResponse>> UpdateStatisticAsync(this PlayFabLeaderboardsInstanceAPI self, PlayFab.LeaderboardsModels.EntityKey entity, StatisticUpdate statistic, [Optional] string metadata, [Optional] int? expectedProfileVersion, [Optional] bool? forceUpdate)
		{
			//Discarded unreachable code: IL_0053
			StatisticUpdate[] array;
			do
			{
				array = new StatisticUpdate[1];
			}
			while (statistic != null && array == null);
			array[0] = statistic;
			UpdateStatisticsRequest updateStatisticsRequest = new UpdateStatisticsRequest();
			updateStatisticsRequest.Entity = entity;
			updateStatisticsRequest.EntityLeaderboardMetadata = metadata;
			updateStatisticsRequest.ExpectedProfileVersion = (int?)updateStatisticsRequest;
			updateStatisticsRequest.ForceUpdate = (bool?)updateStatisticsRequest;
			List<StatisticUpdate> list = (updateStatisticsRequest.Statistics = (List<StatisticUpdate>)(object)Enumerable.ToList<StatisticUpdate>((IEnumerable<>)(object)array));
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<UpdateStatisticsResponse>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x103E3D0", Offset = "0x103CDD0", VA = "0x18103E3D0")]
		public static Task<PlayFabResult<IncrementStatisticVersionResponse>> IncrementStatisticVersionAsync(this PlayFabLeaderboardsInstanceAPI self, string name)
		{
			//Discarded unreachable code: IL_001b
			//IL_001a: Expected O, but got I4
			//IL_001a: Expected O, but got I4
			IncrementStatisticVersionRequest incrementStatisticVersionRequest = new IncrementStatisticVersionRequest();
			incrementStatisticVersionRequest.Name = name;
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<IncrementStatisticVersionResponse>>)(object)self.IncrementStatisticVersionAsync(incrementStatisticVersionRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x103E470", Offset = "0x103CE70", VA = "0x18103E470")]
		public static PlayFab.ProfilesModels.EntityStatisticChildValue ToProfiles(this PlayFab.LeaderboardsModels.EntityStatisticChildValue self)
		{
			//Discarded unreachable code: IL_0032
			PlayFab.ProfilesModels.EntityStatisticChildValue entityStatisticChildValue = new PlayFab.ProfilesModels.EntityStatisticChildValue();
			string text = (entityStatisticChildValue.ChildName = self.ChildName);
			string text2 = (entityStatisticChildValue.Metadata = self.Metadata);
			int num = (entityStatisticChildValue.Value = self.Value);
			return entityStatisticChildValue;
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x103E500", Offset = "0x103CF00", VA = "0x18103E500")]
		public static PlayFab.ProfilesModels.EntityStatisticValue ToProfiles(this PlayFab.LeaderboardsModels.EntityStatisticValue self)
		{
			//Discarded unreachable code: IL_00a6
			//IL_0064: Expected O, but got I4
			PlayFab.ProfilesModels.EntityStatisticValue entityStatisticValue = new PlayFab.ProfilesModels.EntityStatisticValue();
			Dictionary<string, PlayFab.LeaderboardsModels.EntityStatisticChildValue> childStatistics = self.ChildStatistics;
			if (childStatistics != null)
			{
				Func<KeyValuePair<string, PlayFab.LeaderboardsModels.EntityStatisticChildValue>, string> _003C_003E9__7_ = _003C_003Ec._003C_003E9__7_0;
				if (_003C_003E9__7_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				Func<KeyValuePair<string, PlayFab.LeaderboardsModels.EntityStatisticChildValue>, PlayFab.ProfilesModels.EntityStatisticChildValue> func = default(Func<KeyValuePair<string, PlayFab.LeaderboardsModels.EntityStatisticChildValue>, PlayFab.ProfilesModels.EntityStatisticChildValue>);
				if (_003C_003Ec._003C_003E9__7_1 == null)
				{
					func = (Func<KeyValuePair<string, PlayFab.LeaderboardsModels.EntityStatisticChildValue>, PlayFab.ProfilesModels.EntityStatisticChildValue>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				Dictionary<string, KeyValuePair<string, PlayFab.LeaderboardsModels.EntityStatisticChildValue>> dictionary = (Dictionary<string, KeyValuePair<string, PlayFab.LeaderboardsModels.EntityStatisticChildValue>>)(object)Enumerable.ToDictionary<KeyValuePair<string, PlayFab.LeaderboardsModels.EntityStatisticChildValue>, string, PlayFab.ProfilesModels.EntityStatisticChildValue>((IEnumerable<>)childStatistics, (Func<, >)(object)_003C_003E9__7_, (Func<, >)(object)func);
			}
			int num = 0;
			entityStatisticValue.ChildStatistics = (Dictionary<string, PlayFab.ProfilesModels.EntityStatisticChildValue>)num;
			string text = (entityStatisticValue.Metadata = self.Metadata);
			string text2 = (entityStatisticValue.Name = self.Name);
			int? num2 = (entityStatisticValue.Value = self.Value);
			int num3 = (entityStatisticValue.Version = self.Version);
			return entityStatisticValue;
		}
	}
}
