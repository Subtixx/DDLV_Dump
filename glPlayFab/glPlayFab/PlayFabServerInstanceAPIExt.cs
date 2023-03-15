using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using PlayFab;
using PlayFab.ServerModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public static class PlayFabServerInstanceAPIExt
	{
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x103F9E0", Offset = "0x103E3E0", VA = "0x18103F9E0")]
		public static EntityKey GetServerEntityKey(this PlayFabAuthenticationContext self)
		{
			//Discarded unreachable code: IL_0024
			EntityKey entityKey = new EntityKey();
			string text = (entityKey.Type = self.EntityType);
			string text2 = (entityKey.Id = self.EntityId);
			return entityKey;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x103F8A0", Offset = "0x103E2A0", VA = "0x18103F8A0")]
		public static EntityKey GetEntityKey(this PlayFabServerInstanceAPI self)
		{
			//Discarded unreachable code: IL_002b
			PlayFabAuthenticationContext authenticationContext = self.authenticationContext;
			EntityKey entityKey = new EntityKey();
			string text = (entityKey.Type = authenticationContext.EntityType);
			string text2 = (entityKey.Id = authenticationContext.EntityId);
			return entityKey;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x1040350", Offset = "0x103ED50", VA = "0x181040350")]
		public static Task<PlayFabResult<UpdatePlayerStatisticsResult>> UpdatePlayerStatisticsAsync(this PlayFabServerInstanceAPI self, string playFabId, IEnumerable<StatisticUpdate> stats, [Optional] bool? forceUpdate)
		{
			//Discarded unreachable code: IL_0032
			//IL_0031: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			UpdatePlayerStatisticsRequest updatePlayerStatisticsRequest = new UpdatePlayerStatisticsRequest();
			updatePlayerStatisticsRequest.PlayFabId = playFabId;
			List<StatisticUpdate> list = (updatePlayerStatisticsRequest.Statistics = (List<StatisticUpdate>)(object)Enumerable.ToList<StatisticUpdate>((IEnumerable<>)stats));
			updatePlayerStatisticsRequest.ForceUpdate = forceUpdate;
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<UpdatePlayerStatisticsResult>>)(object)self.UpdatePlayerStatisticsAsync(updatePlayerStatisticsRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x1040200", Offset = "0x103EC00", VA = "0x181040200")]
		public static Task<PlayFabResult<UpdatePlayerStatisticsResult>> UpdatePlayerStatisticAsync(this PlayFabServerInstanceAPI self, string playFabId, string stat, int value = 1, [Optional] uint? version, bool forceUpdate = false)
		{
			//Discarded unreachable code: IL_003a
			//IL_001b: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			StatisticUpdate[] array;
			StatisticUpdate statisticUpdate;
			do
			{
				array = new StatisticUpdate[1];
				statisticUpdate = new StatisticUpdate();
				statisticUpdate.StatisticName = stat;
				statisticUpdate.Version = (uint?)(object)0;
				statisticUpdate.Value = value;
			}
			while (statisticUpdate == null);
			array[0] = statisticUpdate;
			int num = 0;
			return (Task<PlayFabResult<UpdatePlayerStatisticsResult>>)(object)PlayFabServerInstanceAPIExt.UpdatePlayerStatisticsAsync(self, playFabId, (IEnumerable<>)(object)array, (Nullable<>)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x103FFD0", Offset = "0x103E9D0", VA = "0x18103FFD0")]
		public static Task<PlayFabResult<UpdatePlayerStatisticsResult>> ResetPlayerStatisticAsync(this PlayFabServerInstanceAPI self, string playFabId, string stat, int value = 0)
		{
			//Discarded unreachable code: IL_0033
			//IL_0032: Expected O, but got I4
			StatisticUpdate[] array;
			StatisticUpdate statisticUpdate;
			do
			{
				array = new StatisticUpdate[1];
				statisticUpdate = new StatisticUpdate();
				statisticUpdate.StatisticName = stat;
				statisticUpdate.Value = value;
			}
			while (statisticUpdate == null);
			array[0] = statisticUpdate;
			int num = 0;
			return (Task<PlayFabResult<UpdatePlayerStatisticsResult>>)(object)PlayFabServerInstanceAPIExt.UpdatePlayerStatisticsAsync(self, playFabId, (IEnumerable<>)(object)array, (Nullable<>)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x103F930", Offset = "0x103E330", VA = "0x18103F930")]
		public static Task<PlayFabResult<GetFriendsListResult>> GetFriendsListAsync(this PlayFabServerInstanceAPI self, string playFabId, [Optional] PlayerProfileViewConstraints constraints)
		{
			//Discarded unreachable code: IL_0022
			//IL_0021: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			GetFriendsListRequest getFriendsListRequest = new GetFriendsListRequest();
			getFriendsListRequest.PlayFabId = playFabId;
			getFriendsListRequest.ProfileConstraints = constraints;
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<GetFriendsListResult>>)(object)self.GetFriendsListAsync(getFriendsListRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x103FA60", Offset = "0x103E460", VA = "0x18103FA60")]
		public static Task<PlayFabResult<GetUserDataResult>> GetUserDataAsync(this PlayFabServerInstanceAPI self, string playFabId, string key)
		{
			//Discarded unreachable code: IL_0031
			//IL_0030: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			List<string> list = (List<string>)(object)new List<T>();
			((List<T>)(object)list).Add((T)key);
			GetUserDataRequest getUserDataRequest = new GetUserDataRequest();
			getUserDataRequest.PlayFabId = playFabId;
			getUserDataRequest.Keys = list;
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<GetUserDataResult>>)(object)self.GetUserDataAsync(getUserDataRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x103FB80", Offset = "0x103E580", VA = "0x18103FB80")]
		public static Task<PlayFabResult<GetUserDataResult>> GetUserDataAsync(this PlayFabServerInstanceAPI self, string playFabId, List<string> keys)
		{
			//Discarded unreachable code: IL_0022
			//IL_0021: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			GetUserDataRequest getUserDataRequest = new GetUserDataRequest();
			getUserDataRequest.PlayFabId = playFabId;
			getUserDataRequest.Keys = keys;
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<GetUserDataResult>>)(object)self.GetUserDataAsync(getUserDataRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x1040430", Offset = "0x103EE30", VA = "0x181040430")]
		public static Task<PlayFabResult<UpdateUserDataResult>> UpdateUserDataAsync(this PlayFabServerInstanceAPI self, string playFabId, Dictionary<string, string> data)
		{
			//Discarded unreachable code: IL_0022
			//IL_0021: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			UpdateUserDataRequest updateUserDataRequest = new UpdateUserDataRequest();
			updateUserDataRequest.PlayFabId = playFabId;
			updateUserDataRequest.Data = data;
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<UpdateUserDataResult>>)(object)self.UpdateUserDataAsync(updateUserDataRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x103FEB0", Offset = "0x103E8B0", VA = "0x18103FEB0")]
		public static Task<PlayFabResult<GetUserDataResult>> GetUserReadOnlyDataAsync(this PlayFabServerInstanceAPI self, string playFabId, string key)
		{
			//Discarded unreachable code: IL_0031
			//IL_0030: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			List<string> list = (List<string>)(object)new List<T>();
			((List<T>)(object)list).Add((T)key);
			GetUserDataRequest getUserDataRequest = new GetUserDataRequest();
			getUserDataRequest.PlayFabId = playFabId;
			getUserDataRequest.Keys = list;
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<GetUserDataResult>>)(object)self.GetUserReadOnlyDataAsync(getUserDataRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x103FE00", Offset = "0x103E800", VA = "0x18103FE00")]
		public static Task<PlayFabResult<GetUserDataResult>> GetUserReadOnlyDataAsync(this PlayFabServerInstanceAPI self, string playFabId, List<string> keys)
		{
			//Discarded unreachable code: IL_0022
			//IL_0021: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			GetUserDataRequest getUserDataRequest = new GetUserDataRequest();
			getUserDataRequest.PlayFabId = playFabId;
			getUserDataRequest.Keys = keys;
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<GetUserDataResult>>)(object)self.GetUserReadOnlyDataAsync(getUserDataRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x10406C0", Offset = "0x103F0C0", VA = "0x1810406C0")]
		public static Task<PlayFabResult<UpdateUserDataResult>> UpdateUserReadOnlyDataAsync(this PlayFabServerInstanceAPI self, string playFabId, Dictionary<string, string> data)
		{
			//Discarded unreachable code: IL_0022
			//IL_0021: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			UpdateUserDataRequest updateUserDataRequest = new UpdateUserDataRequest();
			updateUserDataRequest.PlayFabId = playFabId;
			updateUserDataRequest.Data = data;
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<UpdateUserDataResult>>)(object)self.UpdateUserReadOnlyDataAsync(updateUserDataRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x103FC30", Offset = "0x103E630", VA = "0x18103FC30")]
		public static Task<PlayFabResult<GetUserDataResult>> GetUserInternalDataAsync(this PlayFabServerInstanceAPI self, string playFabId, string key)
		{
			//Discarded unreachable code: IL_0031
			//IL_0030: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			List<string> list = (List<string>)(object)new List<T>();
			((List<T>)(object)list).Add((T)key);
			GetUserDataRequest getUserDataRequest = new GetUserDataRequest();
			getUserDataRequest.PlayFabId = playFabId;
			getUserDataRequest.Keys = list;
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<GetUserDataResult>>)(object)self.GetUserInternalDataAsync(getUserDataRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x103FD50", Offset = "0x103E750", VA = "0x18103FD50")]
		public static Task<PlayFabResult<GetUserDataResult>> GetUserInternalDataAsync(this PlayFabServerInstanceAPI self, string playFabId, List<string> keys)
		{
			//Discarded unreachable code: IL_0022
			//IL_0021: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			GetUserDataRequest getUserDataRequest = new GetUserDataRequest();
			getUserDataRequest.PlayFabId = playFabId;
			getUserDataRequest.Keys = keys;
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<GetUserDataResult>>)(object)self.GetUserInternalDataAsync(getUserDataRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x10404E0", Offset = "0x103EEE0", VA = "0x1810404E0")]
		public static Task<PlayFabResult<UpdateUserDataResult>> UpdateUserInternalDataAsync(this PlayFabServerInstanceAPI self, string playFabId, string key, string value)
		{
			//Discarded unreachable code: IL_000c, IL_0030
			//IL_002f: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			Dictionary<string, string> dictionary = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x1040610", Offset = "0x103F010", VA = "0x181040610")]
		public static Task<PlayFabResult<UpdateUserDataResult>> UpdateUserInternalDataAsync(this PlayFabServerInstanceAPI self, string playFabId, Dictionary<string, string> data)
		{
			//Discarded unreachable code: IL_0022
			//IL_0021: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			UpdateUserInternalDataRequest updateUserInternalDataRequest = new UpdateUserInternalDataRequest();
			updateUserInternalDataRequest.PlayFabId = playFabId;
			updateUserInternalDataRequest.Data = data;
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<UpdateUserDataResult>>)(object)self.UpdateUserInternalDataAsync(updateUserInternalDataRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x1040110", Offset = "0x103EB10", VA = "0x181040110")]
		public static Task<PlayFabResult<EmptyResponse>> SetFriendTagsAsync(this PlayFabServerInstanceAPI self, string playFabId, string friendPlayFabId, IEnumerable<string> tags)
		{
			//Discarded unreachable code: IL_0032
			//IL_0031: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			SetFriendTagsRequest setFriendTagsRequest = new SetFriendTagsRequest();
			setFriendTagsRequest.PlayFabId = playFabId;
			setFriendTagsRequest.FriendPlayFabId = friendPlayFabId;
			List<string> list = (setFriendTagsRequest.Tags = (List<string>)(object)Enumerable.ToList<string>((IEnumerable<>)tags));
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<EmptyResponse>>)(object)self.SetFriendTagsAsync(setFriendTagsRequest, (object)num2, (Dictionary<, >)num);
		}
	}
}
