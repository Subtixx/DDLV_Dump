using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using PlayFab;
using PlayFab.EconomyModels;
using PlayFab.LeaderboardsModels;
using PlayFab.ServerModels;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000D99")]
	public class KnownProfiles
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40036C8")]
		private readonly PlayFabProfilesInstanceAPI profiles;

		[Cpp2IlInjected.Token(Token = "0x170013B7")]
		private Dictionary<string, KnownProfileInfo> KnowProfiles
		{
			[Cpp2IlInjected.Token(Token = "0x6007204")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CKnowProfiles_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007205")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CKnowProfiles_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<string, KnownProfileInfo>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x170013B8")]
		public List<string> EntityIds
		{
			[Cpp2IlInjected.Token(Token = "0x6007209")]
			[Cpp2IlInjected.Address(RVA = "0x18A1D10", Offset = "0x18A0710", VA = "0x1818A1D10")]
			get
			{
				//Discarded unreachable code: IL_0011
				return (List<string>)(object)Enumerable.ToList<string>((IEnumerable<>)(object)((Dictionary<TKey, TValue>)(object)KnowProfiles).get_Keys());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007206")]
		[Cpp2IlInjected.Address(RVA = "0x18A1C70", Offset = "0x18A0670", VA = "0x1818A1C70")]
		public KnownProfiles(PlayFabProfilesInstanceAPI _profiles)
		{
			profiles = _profiles;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007207")]
		[Cpp2IlInjected.Address(RVA = "0x18A17C0", Offset = "0x18A01C0", VA = "0x1818A17C0")]
		public KnownProfileInfo Get(string entityId)
		{
			if (entityId != null)
			{
				Dictionary<string, KnownProfileInfo> dictionary = KnowProfiles;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007208")]
		[Cpp2IlInjected.Address(RVA = "0x18A12E0", Offset = "0x189FCE0", VA = "0x1818A12E0")]
		public KnownProfileInfo GetByPlayfabId(string playfabId)
		{
			if ((long)playfabId == 0)
			{
				int num = 0;
			}
			Dictionary<string, KnownProfileInfo>.ValueCollection values = (Dictionary<string, KnownProfileInfo>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)KnowProfiles).get_Values();
			Func<KnownProfileInfo, bool> func = (Func<KnownProfileInfo, bool>)(object)(Func<T, TResult>)delegate(KnownProfileInfo x)
			{
				//Discarded unreachable code: IL_0014
				string b = playfabId;
				return string.Equals(x.PlayfabId, b);
			};
			KnownProfileInfo knownProfileInfo = Enumerable.FirstOrDefault<KnownProfileInfo>((IEnumerable<>)(object)values, (Func<, >)(object)func);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600720A")]
		[Cpp2IlInjected.Address(RVA = "0x18A1710", Offset = "0x18A0110", VA = "0x1818A1710")]
		public string GetName(string entityId)
		{
			//Discarded unreachable code: IL_0021
			if (entityId != null)
			{
				Dictionary<string, KnownProfileInfo> dictionary = KnowProfiles;
				bool flag = default(bool);
				ulong num = default(ulong);
				if (flag && num != 0 && num != 0)
				{
				}
			}
			return "PlayerName";
		}

		[Cpp2IlInjected.Token(Token = "0x600720B")]
		[Cpp2IlInjected.Address(RVA = "0x18A16B0", Offset = "0x18A00B0", VA = "0x1818A16B0")]
		public string GetNameByPlayfabId(string playfabId)
		{
			KnownProfileInfo byPlayfabId = GetByPlayfabId(playfabId);
			if (byPlayfabId == null || byPlayfabId.DisplayName == null)
			{
			}
			return "PlayerName";
		}

		[Cpp2IlInjected.Token(Token = "0x600720C")]
		[Cpp2IlInjected.Address(RVA = "0x18A0B80", Offset = "0x189F580", VA = "0x1818A0B80")]
		public bool AddInfo(KnownProfileInfo info)
		{
			//Discarded unreachable code: IL_002b
			if (info != null)
			{
				string _003CEntityId_003Ek__BackingField = info.EntityId;
				string _003CPlayfabId_003Ek__BackingField = info.PlayfabId;
				string _003CDisplayName_003Ek__BackingField = info.DisplayName;
				if (1 == 0)
				{
					Dictionary<string, KnownProfileInfo> dictionary = KnowProfiles;
					throw new NullReferenceException();
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600720D")]
		[Cpp2IlInjected.Address(RVA = "0x18A0C30", Offset = "0x189F630", VA = "0x1818A0C30")]
		public bool AddInfo(string entityId, string playfabId, string displayName, string avatarUrl)
		{
			KnownProfileInfo info = default(KnownProfileInfo);
			return AddInfo(info);
		}

		[Cpp2IlInjected.Token(Token = "0x600720E")]
		[Cpp2IlInjected.Address(RVA = "0x18A0C80", Offset = "0x189F680", VA = "0x1818A0C80")]
		[AsyncStateMachine(typeof(_003CBuildCreatorsInfoInternal_003Ed__14))]
		private Task<bool> BuildCreatorsInfoInternal(List<PlayFab.EconomyModels.EntityKey> entities)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600720F")]
		[Cpp2IlInjected.Address(RVA = "0x18A0DC0", Offset = "0x189F7C0", VA = "0x1818A0DC0")]
		[AsyncStateMachine(typeof(_003CBuildCreatorsInfo_003Ed__15))]
		public Task<bool> BuildCreatorsInfo(List<PlayFab.EconomyModels.EntityKey> entities)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007210")]
		[Cpp2IlInjected.Address(RVA = "0x18A0F00", Offset = "0x189F900", VA = "0x1818A0F00")]
		[AsyncStateMachine(typeof(_003CBuildCreatorsInfo_003Ed__16))]
		public Task<bool> BuildCreatorsInfo(List<PlayFab.EconomyModels.CatalogItem> items)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007211")]
		[Cpp2IlInjected.Address(RVA = "0x18A1400", Offset = "0x189FE00", VA = "0x1818A1400")]
		public unsafe KnownProfileInfo GetCreatorInfo(PlayFab.EconomyModels.CatalogItem item)
		{
			//IL_0020: Expected O, but got I4
			int num = 0;
			if (item == null || item.CreatorEntity != null)
			{
			}
			if (num == 0 || ((Dictionary<TKey, TValue>)(object)KnowProfiles).TryGetValue((TKey)num, out *(TValue*)num))
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007212")]
		[Cpp2IlInjected.Address(RVA = "0x18A14A0", Offset = "0x189FEA0", VA = "0x1818A14A0")]
		public string GetCreatorName(PlayFab.EconomyModels.CatalogItem item)
		{
			//Discarded unreachable code: IL_002e
			if (item == null || item.CreatorEntity != null)
			{
			}
			if (false)
			{
				Dictionary<string, KnownProfileInfo> dictionary = KnowProfiles;
				bool flag;
				ulong num;
				if (flag && num != 0 && num == 0)
				{
				}
			}
			return "PlayerName";
		}

		[Cpp2IlInjected.Token(Token = "0x6007213")]
		[Cpp2IlInjected.Address(RVA = "0x18A1040", Offset = "0x189FA40", VA = "0x1818A1040")]
		[AsyncStateMachine(typeof(_003CBuildFriendsInfo_003Ed__19))]
		public Task<bool> BuildFriendsInfo(List<FollowData> friends)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007214")]
		[Cpp2IlInjected.Address(RVA = "0x18A15E0", Offset = "0x189FFE0", VA = "0x1818A15E0")]
		public KnownProfileInfo GetFriendInfo(FriendInfo friend)
		{
			//Discarded unreachable code: IL_0006
			if (friend != null)
			{
			}
			KnownProfileInfo result = default(KnownProfileInfo);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007215")]
		[Cpp2IlInjected.Address(RVA = "0x18A1570", Offset = "0x189FF70", VA = "0x1818A1570")]
		public string GetFriendEntityId(FriendInfo friend)
		{
			//Discarded unreachable code: IL_0021
			//IL_000d: Expected O, but got I4
			if (friend != null)
			{
			}
			int num = 0;
			KnownProfileInfo byPlayfabId = GetByPlayfabId((string)num);
			if (byPlayfabId == null || byPlayfabId.EntityId == null)
			{
			}
			return "";
		}

		[Cpp2IlInjected.Token(Token = "0x6007216")]
		[Cpp2IlInjected.Address(RVA = "0x18A1190", Offset = "0x189FB90", VA = "0x1818A1190")]
		[AsyncStateMachine(typeof(_003CBuildLeaderboardInfo_003Ed__22))]
		public Task<bool> BuildLeaderboardInfo(List<EntityLeaderboardEntry> entries, bool getAvatar = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007217")]
		[Cpp2IlInjected.Address(RVA = "0x18A1610", Offset = "0x18A0010", VA = "0x1818A1610")]
		public unsafe KnownProfileInfo GetLeaderboardInfo(EntityLeaderboardEntry entry)
		{
			//IL_0020: Expected O, but got I4
			int num = 0;
			if (entry == null || entry.EntityLineage != null)
			{
			}
			if (num == 0 || ((Dictionary<TKey, TValue>)(object)KnowProfiles).TryGetValue((TKey)num, out *(TValue*)num))
			{
			}
			throw new NullReferenceException();
		}
	}
}
