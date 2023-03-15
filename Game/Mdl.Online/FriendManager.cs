using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Mdl.Systems;
using Meta;
using Meta.Online;
using Meta.Social;
using Newtonsoft.Json;

namespace Mdl.Online
{
	[Cpp2IlInjected.Token(Token = "0x200036A")]
	public class FriendManager
	{
		[Cpp2IlInjected.Token(Token = "0x200036B")]
		public class FollowInfo
		{
			[Cpp2IlInjected.Token(Token = "0x170001FE")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40017BB")]
			public DateTime LastUpdateTimestamp
			{
				[Cpp2IlInjected.Token(Token = "0x6000EE8")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000EE9")]
				[Cpp2IlInjected.Address(RVA = "0x6E5AB0", Offset = "0x6E44B0", VA = "0x1806E5AB0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170001FF")]
			public FollowData FollowData
			{
				[Cpp2IlInjected.Token(Token = "0x6000EEA")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CFollowData_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000EEB")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CFollowData_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000EEC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public FollowInfo()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200036C")]
		public class FriendsInfo
		{
			[Cpp2IlInjected.Token(Token = "0x17000200")]
			public List<FollowInfo> FollowList
			{
				[Cpp2IlInjected.Token(Token = "0x6000EED")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CFollowList_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000EEE")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CFollowList_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			} = (List<FollowInfo>)(object)new List<T>();


			[Cpp2IlInjected.Token(Token = "0x6000EEF")]
			[Cpp2IlInjected.Address(RVA = "0x1042600", Offset = "0x1041000", VA = "0x181042600")]
			public void AddFollows(IEnumerable<FollowInfo> newFollows)
			{
				//Discarded unreachable code: IL_000d
				((List<T>)(object)FollowList).AddRange((IEnumerable<>)newFollows);
			}

			[Cpp2IlInjected.Token(Token = "0x6000EF0")]
			[Cpp2IlInjected.Address(RVA = "0x1042660", Offset = "0x1041060", VA = "0x181042660")]
			public void AddFollows(IEnumerable<FollowData> newFollows)
			{
				//Discarded unreachable code: IL_0034
				Func<FollowData, FollowInfo> _003C_003E9__5_ = _003C_003Ec._003C_003E9__5_0;
				if (_003C_003E9__5_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FollowData x) => null);
				}
				IEnumerable<FollowData> enumerable = (IEnumerable<FollowData>)Enumerable.Select<FollowData, FollowInfo>((IEnumerable<>)newFollows, (Func<, >)(object)_003C_003E9__5_);
				((List<T>)(object)FollowList).AddRange((IEnumerable<>)enumerable);
			}

			[Cpp2IlInjected.Token(Token = "0x6000EF1")]
			[Cpp2IlInjected.Address(RVA = "0x10427D0", Offset = "0x10411D0", VA = "0x1810427D0")]
			public FriendsInfo()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200036E")]
		public delegate void FriendsChanged(bool followersChanged, bool followingsChanged);

		[Cpp2IlInjected.Token(Token = "0x200036F")]
		private class SearchCacheInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40017C0")]
			public List<FollowData> Result;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40017C1")]
			public DateTime Time;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40017C2")]
			public string Value;

			[Cpp2IlInjected.Token(Token = "0x6000EF9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SearchCacheInfo()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40017AB")]
		public readonly int MaxNumberOfFollowersPerPage = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40017AC")]
		public readonly int NumberOfDaysToKeepFriendInCache = 7;

		[Cpp2IlInjected.Token(Token = "0x40017AD")]
		private static FriendManager _instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40017B2")]
		private List<string> FollowerIds = (List<string>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40017B6")]
		private Task<SuggestFollower.Types.Response> _updateSuggestTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40017B7")]
		private DateTime _updateSuggestTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40017B8")]
		private Task<GetFollowData.Types.Response> _updateFriendsTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40017B9")]
		private DateTime _updateFriendsTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40017BA")]
		private List<SearchCacheInfo> SearchCache = (List<SearchCacheInfo>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public static FriendManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAE")]
			[Cpp2IlInjected.Address(RVA = "0x146FB70", Offset = "0x146E570", VA = "0x18146FB70")]
			get
			{
				//IL_0010: Expected I4, but got I8
				//IL_0019: Expected I4, but got I8
				FriendManager friendManager = new FriendManager();
				friendManager.MaxNumberOfFollowersPerPage = 15;
				friendManager.NumberOfDaysToKeepFriendInCache = 7;
				FriendsInfo friendsInfo = (friendManager.FriendsCache = new FriendsInfo());
				List<string> list = (friendManager.FollowerIds = (List<string>)(object)new List<T>());
				List<NewsFeedPost> list2 = (friendManager.SuggestList = (List<NewsFeedPost>)(object)new List<T>());
				List<FollowData> list3 = (friendManager.SearchList = (List<FollowData>)(object)new List<T>());
				friendManager.SearchedValue = "";
				List<SearchCacheInfo> list4 = (friendManager.SearchCache = (List<SearchCacheInfo>)(object)new List<T>());
				_instance = friendManager;
				return _instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		private Meta.Online.Client MetaClient
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAF")]
			[Cpp2IlInjected.Address(RVA = "0x1470030", Offset = "0x146EA30", VA = "0x181470030")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.MetaClient;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		private OnlineClient MetaOnlineClient
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB0")]
			[Cpp2IlInjected.Address(RVA = "0x14700E0", Offset = "0x146EAE0", VA = "0x1814700E0")]
			get
			{
				Meta.Online.Client metaClient = SystemRoot.Instance.MetaClient;
				if (metaClient != null)
				{
					return metaClient.OnlineClient;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		public string CurrentPlayFabId
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB1")]
			[Cpp2IlInjected.Address(RVA = "0x146F410", Offset = "0x146DE10", VA = "0x18146F410")]
			get
			{
				//Discarded unreachable code: IL_0028
				OnlineClient metaOnlineClient = MetaOnlineClient;
				if (metaOnlineClient != null)
				{
					string playFabId = metaOnlineClient.PlayFabId;
				}
				if (metaOnlineClient != null)
				{
					return "";
				}
				return MetaOnlineClient.PlayFabId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		public string FriendsCacheRelativePath
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB2")]
			[Cpp2IlInjected.Address(RVA = "0x146FAC0", Offset = "0x146E4C0", VA = "0x18146FAC0")]
			get
			{
				//Discarded unreachable code: IL_002e
				OnlineClient metaOnlineClient = MetaOnlineClient;
				if (metaOnlineClient != null)
				{
					string playFabId = metaOnlineClient.PlayFabId;
				}
				if (metaOnlineClient != null)
				{
				}
				string playFabId2 = MetaOnlineClient.PlayFabId;
				return "online/friends_cache_" + playFabId2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public IFileSystem SaveFileSystem
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB3")]
			[Cpp2IlInjected.Address(RVA = "0x738FA0", Offset = "0x7379A0", VA = "0x180738FA0")]
			get
			{
				return FileSystem.Save;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		public FriendsInfo FriendsCache
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CFriendsCache_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000EBB")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			private set
			{
				_003CFriendsCache_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = new FriendsInfo();


		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		public IEnumerable<FollowData> Follows
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBC")]
			[Cpp2IlInjected.Address(RVA = "0x146F980", Offset = "0x146E380", VA = "0x18146F980")]
			get
			{
				//Discarded unreachable code: IL_0033
				List<FollowInfo> _003CFollowList_003Ek__BackingField = FriendsCache.FollowList;
				Func<FollowInfo, FollowData> _003C_003E9__32_ = _003C_003Ec._003C_003E9__32_0;
				if (_003C_003E9__32_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FollowInfo x) => x.FollowData);
				}
				return (IEnumerable<FollowData>)Enumerable.Select<FollowInfo, FollowData>((IEnumerable<>)_003CFollowList_003Ek__BackingField, (Func<, >)(object)_003C_003E9__32_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		public IEnumerable<FollowData> Followings
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBD")]
			[Cpp2IlInjected.Address(RVA = "0x146F750", Offset = "0x146E150", VA = "0x18146F750")]
			get
			{
				//Discarded unreachable code: IL_005a
				List<FollowInfo> _003CFollowList_003Ek__BackingField = FriendsCache.FollowList;
				Func<FollowInfo, bool> _003C_003E9__34_ = _003C_003Ec._003C_003E9__34_0;
				if (_003C_003E9__34_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FollowInfo x) => x.FollowData.isFollowing_);
				}
				IEnumerable<FollowInfo> enumerable = (IEnumerable<FollowInfo>)Enumerable.Where<FollowInfo>((IEnumerable<>)_003CFollowList_003Ek__BackingField, (Func<, >)(object)_003C_003E9__34_);
				Func<FollowInfo, FollowData> func = default(Func<FollowInfo, FollowData>);
				if (_003C_003Ec._003C_003E9__34_1 == null)
				{
					func = (Func<FollowInfo, FollowData>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FollowInfo x) => x.FollowData));
				}
				return (IEnumerable<FollowData>)Enumerable.Select<FollowInfo, FollowData>((IEnumerable<>)enumerable, (Func<, >)(object)func);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public IEnumerable<FollowData> Followers
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBE")]
			[Cpp2IlInjected.Address(RVA = "0x146F4D0", Offset = "0x146DED0", VA = "0x18146F4D0")]
			get
			{
				//Discarded unreachable code: IL_005a
				List<FollowInfo> _003CFollowList_003Ek__BackingField = FriendsCache.FollowList;
				Func<FollowInfo, bool> _003C_003E9__36_ = _003C_003Ec._003C_003E9__36_0;
				if (_003C_003E9__36_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FollowInfo x) => x.FollowData.isFollower_);
				}
				IEnumerable<FollowInfo> enumerable = (IEnumerable<FollowInfo>)Enumerable.Where<FollowInfo>((IEnumerable<>)_003CFollowList_003Ek__BackingField, (Func<, >)(object)_003C_003E9__36_);
				Func<FollowInfo, FollowData> func = default(Func<FollowInfo, FollowData>);
				if (_003C_003Ec._003C_003E9__36_1 == null)
				{
					func = (Func<FollowInfo, FollowData>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FollowInfo x) => x.FollowData));
				}
				return (IEnumerable<FollowData>)Enumerable.Select<FollowInfo, FollowData>((IEnumerable<>)enumerable, (Func<, >)(object)func);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public int FollowingsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBF")]
			[Cpp2IlInjected.Address(RVA = "0x146F700", Offset = "0x146E100", VA = "0x18146F700")]
			get
			{
				return Enumerable.Count<FollowData>(this.get_Followings());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		public int FollowersCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000EC0")]
			[Cpp2IlInjected.Address(RVA = "0x146F490", Offset = "0x146DE90", VA = "0x18146F490")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((List<>)(object)FollowerIds)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		public List<NewsFeedPost> SuggestList
		{
			[Cpp2IlInjected.Token(Token = "0x6000EC1")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CSuggestList_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000EC2")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			private set
			{
				_003CSuggestList_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (List<NewsFeedPost>)(object)new List<T>();


		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		public List<FollowData> SearchList
		{
			[Cpp2IlInjected.Token(Token = "0x6000EC3")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CSearchList_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000EC4")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			private set
			{
				_003CSearchList_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (List<FollowData>)(object)new List<T>();


		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		public bool IsFriendsReady
		{
			[Cpp2IlInjected.Token(Token = "0x6000ECE")]
			[Cpp2IlInjected.Address(RVA = "0x146FE70", Offset = "0x146E870", VA = "0x18146FE70")]
			get
			{
				//IL_0010: Expected O, but got I4
				DateTime updateFriendsTime = _updateFriendsTime;
				int num = 0;
				return updateFriendsTime != (DateTime)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		public bool IsFriendsOutdated
		{
			[Cpp2IlInjected.Token(Token = "0x6000ECF")]
			[Cpp2IlInjected.Address(RVA = "0x146FD90", Offset = "0x146E790", VA = "0x18146FD90")]
			get
			{
				//IL_0010: Expected O, but got I4
				DateTime updateFriendsTime = _updateFriendsTime;
				int num = 0;
				if (!(updateFriendsTime != (DateTime)num))
				{
					return true;
				}
				int num2 = 0;
				DateTime utcNow = DateTime.UtcNow;
				DateTime dateTime = default(DateTime);
				return dateTime < utcNow;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		public bool IsSuggestReady
		{
			[Cpp2IlInjected.Token(Token = "0x6000ED0")]
			[Cpp2IlInjected.Address(RVA = "0x146FFD0", Offset = "0x146E9D0", VA = "0x18146FFD0")]
			get
			{
				//IL_0010: Expected O, but got I4
				DateTime updateSuggestTime = _updateSuggestTime;
				int num = 0;
				return updateSuggestTime != (DateTime)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		public bool IsSuggestOutdated
		{
			[Cpp2IlInjected.Token(Token = "0x6000ED1")]
			[Cpp2IlInjected.Address(RVA = "0x146FEF0", Offset = "0x146E8F0", VA = "0x18146FEF0")]
			get
			{
				//IL_0010: Expected O, but got I4
				DateTime updateSuggestTime = _updateSuggestTime;
				int num = 0;
				if (!(updateSuggestTime != (DateTime)num))
				{
					return true;
				}
				int num2 = 0;
				DateTime utcNow = DateTime.UtcNow;
				DateTime dateTime = default(DateTime);
				return dateTime < utcNow;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		public bool IsSearchReady
		{
			[Cpp2IlInjected.Token(Token = "0x6000ED2")]
			[Cpp2IlInjected.Address(RVA = "0x146FED0", Offset = "0x146E8D0", VA = "0x18146FED0")]
			get
			{
				return !string.IsNullOrEmpty(SearchedValue);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		public string SearchedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000ED3")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CSearchedValue_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000ED4")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			private set
			{
				_003CSearchedValue_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = "";


		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event FriendsChanged OnFriendsChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB4")]
			[Cpp2IlInjected.Address(RVA = "0x146F230", Offset = "0x146DC30", VA = "0x18146F230")]
			[CompilerGenerated]
			add
			{
				FriendsChanged onFriendsChanged = this.OnFriendsChanged;
				Delegate @delegate = Delegate.Combine(onFriendsChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFriendsChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000EB5")]
			[Cpp2IlInjected.Address(RVA = "0x14701A0", Offset = "0x146EBA0", VA = "0x1814701A0")]
			[CompilerGenerated]
			remove
			{
				FriendsChanged onFriendsChanged = this.OnFriendsChanged;
				Delegate @delegate = Delegate.Remove(onFriendsChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFriendsChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action OnSuggestChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB6")]
			[Cpp2IlInjected.Address(RVA = "0x146F370", Offset = "0x146DD70", VA = "0x18146F370")]
			[CompilerGenerated]
			add
			{
				Action onSuggestChange = this.OnSuggestChange;
				Delegate @delegate = Delegate.Combine(onSuggestChange, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSuggestChange)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000EB7")]
			[Cpp2IlInjected.Address(RVA = "0x14702E0", Offset = "0x146ECE0", VA = "0x1814702E0")]
			[CompilerGenerated]
			remove
			{
				Action onSuggestChange = this.OnSuggestChange;
				Delegate @delegate = Delegate.Remove(onSuggestChange, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSuggestChange)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action OnSearchChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB8")]
			[Cpp2IlInjected.Address(RVA = "0x146F2D0", Offset = "0x146DCD0", VA = "0x18146F2D0")]
			[CompilerGenerated]
			add
			{
				Action onSearchChange = this.OnSearchChange;
				Delegate @delegate = Delegate.Combine(onSearchChange, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSearchChange)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000EB9")]
			[Cpp2IlInjected.Address(RVA = "0x1470240", Offset = "0x146EC40", VA = "0x181470240")]
			[CompilerGenerated]
			remove
			{
				Action onSearchChange = this.OnSearchChange;
				Delegate @delegate = Delegate.Remove(onSearchChange, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSearchChange)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC5")]
		[Cpp2IlInjected.Address(RVA = "0x146D160", Offset = "0x146BB60", VA = "0x18146D160")]
		public bool IsFollowing(FollowData user)
		{
			//Discarded unreachable code: IL_0006
			if (user != null)
			{
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC6")]
		[Cpp2IlInjected.Address(RVA = "0x146CFB0", Offset = "0x146B9B0", VA = "0x18146CFB0")]
		public bool IsFollower(FollowData user)
		{
			//Discarded unreachable code: IL_0006
			if (user != null)
			{
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC7")]
		[Cpp2IlInjected.Address(RVA = "0x146D480", Offset = "0x146BE80", VA = "0x18146D480")]
		public bool IsSuggest(FollowData user)
		{
			//Discarded unreachable code: IL_0006
			if (user != null)
			{
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC8")]
		[Cpp2IlInjected.Address(RVA = "0x146D2D0", Offset = "0x146BCD0", VA = "0x18146D2D0")]
		public bool IsFollowing(NewsFeedPost post)
		{
			//Discarded unreachable code: IL_0017
			//IL_0016: Expected O, but got I4
			if (post == null || post.UserPost != null)
			{
			}
			int num = 0;
			return IsFollowing((string)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC9")]
		[Cpp2IlInjected.Address(RVA = "0x146D120", Offset = "0x146BB20", VA = "0x18146D120")]
		public bool IsFollower(NewsFeedPost post)
		{
			//Discarded unreachable code: IL_000d
			if (post != null)
			{
				NewsFeedUserPost userPost = post.UserPost;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECA")]
		[Cpp2IlInjected.Address(RVA = "0x146D440", Offset = "0x146BE40", VA = "0x18146D440")]
		public bool IsSuggest(NewsFeedPost post)
		{
			//Discarded unreachable code: IL_000d
			if (post != null)
			{
				NewsFeedUserPost userPost = post.UserPost;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECB")]
		[Cpp2IlInjected.Address(RVA = "0x146D190", Offset = "0x146BB90", VA = "0x18146D190")]
		public bool IsFollowing(string friendPlayfabId)
		{
			_003C_003Ec__DisplayClass56_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass56_0();
			CS_0024_003C_003E8__locals0.friendPlayfabId = friendPlayfabId;
			string friendPlayfabId2 = CS_0024_003C_003E8__locals0.friendPlayfabId;
			if (CS_0024_003C_003E8__locals0 != null)
			{
				int num = 0;
			}
			List<FollowData> list = (List<FollowData>)(object)Enumerable.ToList<FollowData>(this.get_Followings());
			Predicate<FollowData> predicate = (Predicate<FollowData>)(object)(Predicate<T>)delegate(FollowData x)
			{
				//Discarded unreachable code: IL_0014
				string friendPlayfabId3 = CS_0024_003C_003E8__locals0.friendPlayfabId;
				return string.Equals(x.playfabId_, friendPlayfabId3);
			};
			FollowData followData = (FollowData)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECC")]
		[Cpp2IlInjected.Address(RVA = "0x146CFE0", Offset = "0x146B9E0", VA = "0x18146CFE0")]
		public bool IsFollower(string friendPlayfabId)
		{
			_003C_003Ec__DisplayClass57_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass57_0();
			CS_0024_003C_003E8__locals0.friendPlayfabId = friendPlayfabId;
			string friendPlayfabId2 = CS_0024_003C_003E8__locals0.friendPlayfabId;
			if (CS_0024_003C_003E8__locals0 != null)
			{
				int num = 0;
			}
			List<FollowData> list = (List<FollowData>)(object)Enumerable.ToList<FollowData>(this.get_Followers());
			Predicate<FollowData> predicate = (Predicate<FollowData>)(object)(Predicate<T>)delegate(FollowData x)
			{
				//Discarded unreachable code: IL_0014
				string friendPlayfabId3 = CS_0024_003C_003E8__locals0.friendPlayfabId;
				return string.Equals(x.playfabId_, friendPlayfabId3);
			};
			FollowData followData = (FollowData)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECD")]
		[Cpp2IlInjected.Address(RVA = "0x146D320", Offset = "0x146BD20", VA = "0x18146D320")]
		public bool IsSuggest(string friendPlayfabId)
		{
			_003C_003Ec__DisplayClass58_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass58_0();
			CS_0024_003C_003E8__locals0.friendPlayfabId = friendPlayfabId;
			string friendPlayfabId2 = CS_0024_003C_003E8__locals0.friendPlayfabId;
			if (CS_0024_003C_003E8__locals0 != null)
			{
				int num = 0;
			}
			List<NewsFeedPost> list = SuggestList;
			if (list != null)
			{
				Predicate<NewsFeedPost> predicate = (Predicate<NewsFeedPost>)(object)(Predicate<T>)delegate(NewsFeedPost x)
				{
					//Discarded unreachable code: IL_0024
					if (x.UserPost == null)
					{
					}
					NewsFeedUserPost userPost = x.UserPost;
					string friendPlayfabId3 = CS_0024_003C_003E8__locals0.friendPlayfabId;
					return string.Equals(userPost.playfabId_, friendPlayfabId3);
				};
				NewsFeedPost newsFeedPost = (NewsFeedPost)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED5")]
		[Cpp2IlInjected.Address(RVA = "0x146D4B0", Offset = "0x146BEB0", VA = "0x18146D4B0")]
		private void LoadAndCleanFriendsCache()
		{
			//Discarded unreachable code: IL_006f
			IFileSystem _003CSave_003Ek__BackingField = FileSystem.Save;
			if (FriendsCacheRelativePath != null)
			{
				IFileSystem _003CSave_003Ek__BackingField2 = FileSystem.Save;
				string friendsCacheRelativePath = FriendsCacheRelativePath;
				FriendsInfo friendsInfo = JsonConvert.DeserializeObject<FriendsInfo>(_003CSave_003Ek__BackingField2.ReadAllText(friendsCacheRelativePath));
				List<FollowInfo> _003CFollowList_003Ek__BackingField = friendsInfo.FollowList;
				Predicate<FollowInfo> predicate = (Predicate<FollowInfo>)(object)(Predicate<T>)delegate(FollowInfo x)
				{
					//Discarded unreachable code: IL_0017
					DateTime _003CLastUpdateTimestamp_003Ek__BackingField = x.LastUpdateTimestamp;
					int num2 = 0;
					DateTime utcNow = DateTime.UtcNow;
					DateTime dateTime = default(DateTime);
					return dateTime < utcNow;
				};
				int num = ((List<T>)(object)_003CFollowList_003Ek__BackingField).RemoveAll((Predicate<>)(object)predicate);
				FriendsInfo friendsInfo2 = FriendsCache;
				List<FollowInfo> list = (friendsInfo2.FollowList = friendsInfo.FollowList);
				if (num > 0)
				{
					UpdateFriendsCache();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED6")]
		[Cpp2IlInjected.Address(RVA = "0x146ECA0", Offset = "0x146D6A0", VA = "0x18146ECA0")]
		private void UpdateFriendsCache()
		{
			//Discarded unreachable code: IL_0062
			string text = JsonConvert.SerializeObject(FriendsCache);
			IFileSystem _003CSave_003Ek__BackingField = FileSystem.Save;
			if (Path.GetDirectoryName(FriendsCacheRelativePath) == null)
			{
				IFileSystem _003CSave_003Ek__BackingField2 = FileSystem.Save;
				string directoryName = Path.GetDirectoryName(FriendsCacheRelativePath);
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
			}
			IFileSystem _003CSave_003Ek__BackingField3 = FileSystem.Save;
			string friendsCacheRelativePath = FriendsCacheRelativePath;
			_003CSave_003Ek__BackingField3.WriteAllText(friendsCacheRelativePath, text);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED7")]
		[Cpp2IlInjected.Address(RVA = "0x146D7F0", Offset = "0x146C1F0", VA = "0x18146D7F0")]
		public void OnLogin(Profile profile, CancellationToken ct)
		{
			LoadAndCleanFriendsCache();
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED8")]
		[Cpp2IlInjected.Address(RVA = "0x146D6D0", Offset = "0x146C0D0", VA = "0x18146D6D0")]
		[AsyncStateMachine(typeof(_003CLoadNextFollowersPage_003Ed__80))]
		public Task<IEnumerable<FollowData>> LoadNextFollowersPage()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<IEnumerable<FollowData>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED9")]
		[Cpp2IlInjected.Address(RVA = "0x146E040", Offset = "0x146CA40", VA = "0x18146E040")]
		private bool UpdateFollowers(IEnumerable<string> newFollowers)
		{
			//Discarded unreachable code: IL_00e4, IL_00ea, IL_00f0, IL_00f6
			_003C_003Ec__DisplayClass81_0 CS_0024_003C_003E8__locals0;
			while (true)
			{
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass81_0();
				IEnumerable<string> enumerable = (CS_0024_003C_003E8__locals0.removedFollowerIds = (IEnumerable<string>)Enumerable.Except<string>((IEnumerable<>)FollowerIds, (IEnumerable<>)newFollowers));
				if (Enumerable.Count<string>((IEnumerable<>)CS_0024_003C_003E8__locals0.removedFollowerIds) <= 0)
				{
					break;
				}
				List<FollowInfo> _003CFollowList_003Ek__BackingField = FriendsCache.FollowList;
				Func<FollowInfo, bool> func = (Func<FollowInfo, bool>)(object)(Func<T, TResult>)delegate(FollowInfo x)
				{
					//Discarded unreachable code: IL_0026
					FollowData _003CFollowData_003Ek__BackingField = x.FollowData;
					if (!_003CFollowData_003Ek__BackingField.isFollower_)
					{
						int num5 = 0;
					}
					string titleId_ = _003CFollowData_003Ek__BackingField.titleId_;
					return Enumerable.Contains<string>((IEnumerable<>)CS_0024_003C_003E8__locals0.removedFollowerIds, titleId_);
				};
				IEnumerable<FollowInfo> unfollowers = (IEnumerable<FollowInfo>)Enumerable.Where<FollowInfo>((IEnumerable<>)_003CFollowList_003Ek__BackingField, (Func<, >)(object)func);
				List<FollowInfo> _003CFollowList_003Ek__BackingField2 = FriendsCache.FollowList;
				Predicate<FollowInfo> predicate = (Predicate<FollowInfo>)(object)(Predicate<T>)delegate(FollowInfo x)
				{
					//Discarded unreachable code: IL_0022
					bool flag = Enumerable.Contains<FollowInfo>((IEnumerable<>)unfollowers, x);
					return (!flag) ? flag : (!x.FollowData.isFollowing_);
				};
				int num = ((List<T>)(object)_003CFollowList_003Ek__BackingField2).RemoveAll((Predicate<>)(object)predicate);
				IEnumerable<FollowInfo> enumerable2 = unfollowers;
				if (num != 0)
				{
					int num2 = 0;
					DateTime utcNow = DateTime.UtcNow;
				}
				if (num != 0)
				{
				}
				if (CS_0024_003C_003E8__locals0 == null)
				{
					break;
				}
			}
			int num3 = Enumerable.Count<string>((IEnumerable<>)FollowerIds);
			int num4 = Enumerable.Count<string>((IEnumerable<>)newFollowers);
			if (num3 != num4)
			{
			}
			bool result = Enumerable.Count<string>((IEnumerable<>)CS_0024_003C_003E8__locals0.removedFollowerIds) > 0;
			List<string> list = (FollowerIds = (List<string>)(object)Enumerable.ToList<string>((IEnumerable<>)newFollowers));
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDA")]
		[Cpp2IlInjected.Address(RVA = "0x146E410", Offset = "0x146CE10", VA = "0x18146E410")]
		private bool UpdateFollowings(IEnumerable<FollowData> newFollowings)
		{
			//Discarded unreachable code: IL_01cf, IL_01d5, IL_01db, IL_01e1, IL_01ed, IL_01f3, IL_01f9, IL_01ff, IL_0205, IL_020b, IL_0211, IL_0217, IL_021d, IL_0223, IL_0229, IL_022f, IL_0235, IL_023b
			//IL_01a5: Expected O, but got I4
			uint num5 = default(uint);
			FollowInfo followInfo = default(FollowInfo);
			string text4 = default(string);
			while (true)
			{
				int num = 0;
				List<FollowInfo> _003CFollowList_003Ek__BackingField = FriendsCache.FollowList;
				Func<FollowInfo, bool> func = (Func<FollowInfo, bool>)(object)(Func<T, TResult>)delegate(FollowInfo x)
				{
					if (!x.FollowData.isFollowing_)
					{
						int num9 = 0;
					}
					IEnumerable<FollowData> cpp2il__autoParamName__idx_ = newFollowings;
					Func<FollowData, bool> cpp2il__autoParamName__idx_2 = (Func<FollowData, bool>)(object)(Func<T, TResult>)delegate(FollowData y)
					{
						FollowData _003CFollowData_003Ek__BackingField7 = x.FollowData;
						string playfabId_2 = y.playfabId_;
						throw new NullReferenceException();
					};
					bool flag2 = ((IEnumerable<>)cpp2il__autoParamName__idx_).Any<FollowData>((Func<, >)(object)cpp2il__autoParamName__idx_2);
					throw new NullReferenceException();
				};
				IEnumerable<FollowInfo> unfollowings = (IEnumerable<FollowInfo>)Enumerable.Where<FollowInfo>((IEnumerable<>)_003CFollowList_003Ek__BackingField, (Func<, >)(object)func);
				List<FollowInfo> _003CFollowList_003Ek__BackingField2 = FriendsCache.FollowList;
				Predicate<FollowInfo> predicate = (Predicate<FollowInfo>)(object)(Predicate<T>)delegate(FollowInfo x)
				{
					//Discarded unreachable code: IL_0022
					bool flag = Enumerable.Contains<FollowInfo>((IEnumerable<>)unfollowings, x);
					return (!flag) ? flag : (!x.FollowData.isFollower_);
				};
				int num2 = ((List<T>)(object)_003CFollowList_003Ek__BackingField2).RemoveAll((Predicate<>)(object)predicate);
				IEnumerable<FollowInfo> enumerable = unfollowings;
				if (num2 != 0)
				{
					int num3 = 0;
					DateTime utcNow = DateTime.UtcNow;
				}
				int num4 = 0;
				if (num2 != 0)
				{
				}
				if (num != 0)
				{
					break;
				}
				List<FollowInfo> list = (List<FollowInfo>)(object)new List<T>();
				IEnumerable<FollowData> enumerable2 = newFollowings;
				if (list != null)
				{
					_003C_003Ec__DisplayClass82_2 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass82_2();
					if (num4 < (int)num5)
					{
						num4 += num4;
						if (num4 == (int)num5)
						{
							goto IL_0178;
						}
						num4++;
					}
					CS_0024_003C_003E8__locals1.following = (FollowData)(object)CS_0024_003C_003E8__locals1;
					FollowData following = CS_0024_003C_003E8__locals1.following;
					Predicate<FollowInfo> predicate2 = (Predicate<FollowInfo>)(object)(Predicate<T>)delegate(FollowInfo x)
					{
						//Discarded unreachable code: IL_0020
						FollowData _003CFollowData_003Ek__BackingField6 = x.FollowData;
						string playfabId_ = CS_0024_003C_003E8__locals1.following.playfabId_;
						return string.Equals(_003CFollowData_003Ek__BackingField6.playfabId_, playfabId_);
					};
					if (followInfo != null)
					{
						int num6 = 0;
						DateTime dateTime = (followInfo.LastUpdateTimestamp = DateTime.UtcNow);
						FollowData _003CFollowData_003Ek__BackingField = followInfo.FollowData;
						_003CFollowData_003Ek__BackingField.isFollowing_ = true;
						FollowData _003CFollowData_003Ek__BackingField2 = followInfo.FollowData;
						string text = (_003CFollowData_003Ek__BackingField2.DisplayName = _003CFollowData_003Ek__BackingField.displayName_);
						FollowData _003CFollowData_003Ek__BackingField3 = followInfo.FollowData;
						string text2 = (_003CFollowData_003Ek__BackingField3.Avatar = _003CFollowData_003Ek__BackingField.avatar_);
						FollowData _003CFollowData_003Ek__BackingField4 = followInfo.FollowData;
						string text3 = (_003CFollowData_003Ek__BackingField4.Url = _003CFollowData_003Ek__BackingField.url_);
						FollowData _003CFollowData_003Ek__BackingField5 = followInfo.FollowData;
						text4 = (_003CFollowData_003Ek__BackingField5.UrlPreview = _003CFollowData_003Ek__BackingField.urlPreview_);
						goto IL_0178;
					}
					goto IL_017f;
				}
				goto IL_01ae;
				IL_01ae:
				if (list != null)
				{
				}
				if (num == 0)
				{
					if (Enumerable.Count<FollowInfo>((IEnumerable<>)list) > 0)
					{
					}
					return Enumerable.Count<FollowInfo>((IEnumerable<>)list) > 0;
				}
				continue;
				IL_017f:
				FollowInfo followInfo2 = new FollowInfo();
				int num7 = 0;
				int num8 = 0;
				DateTime dateTime2 = (followInfo2.LastUpdateTimestamp = DateTime.UtcNow);
				followInfo2.FollowData = (FollowData)num7;
				((List<T>)(object)list).Add((T)followInfo2);
				goto IL_01ae;
				IL_0178:
				text4 += text4;
				goto IL_017f;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDB")]
		[Cpp2IlInjected.Address(RVA = "0x146EB30", Offset = "0x146D530", VA = "0x18146EB30")]
		[AsyncStateMachine(typeof(_003CUpdateFriendsAsync_003Ed__83))]
		public Task<bool> UpdateFriendsAsync(CancellationToken ct, bool updateFollowings = true, bool updateFollowers = false, bool forceRefresh = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDC")]
		[Cpp2IlInjected.Address(RVA = "0x146EF30", Offset = "0x146D930", VA = "0x18146EF30")]
		[AsyncStateMachine(typeof(_003CUpdateSuggestAsync_003Ed__84))]
		public Task<bool> UpdateSuggestAsync(CancellationToken ct, bool forceRefresh = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDD")]
		[Cpp2IlInjected.Address(RVA = "0x146CCC0", Offset = "0x146B6C0", VA = "0x18146CCC0")]
		[AsyncStateMachine(typeof(_003CFollowUserAsync_003Ed__85))]
		public Task<bool> FollowUserAsync(CancellationToken ct, FollowData user, bool waitUpdateFriends = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDE")]
		[Cpp2IlInjected.Address(RVA = "0x146CE30", Offset = "0x146B830", VA = "0x18146CE30")]
		[AsyncStateMachine(typeof(_003CFollowUserAsync_003Ed__86))]
		public Task<bool> FollowUserAsync(CancellationToken ct, string friendPlayfabId, [Optional] string entityId, bool waitUpdateFriends = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDF")]
		[Cpp2IlInjected.Address(RVA = "0x146DED0", Offset = "0x146C8D0", VA = "0x18146DED0")]
		[AsyncStateMachine(typeof(_003CUnfollowUserAsync_003Ed__87))]
		public Task<bool> UnfollowUserAsync(CancellationToken ct, FollowData user, bool waitUpdateFriends = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE0")]
		[Cpp2IlInjected.Address(RVA = "0x146DD60", Offset = "0x146C760", VA = "0x18146DD60")]
		[AsyncStateMachine(typeof(_003CUnfollowUserAsync_003Ed__88))]
		public Task<bool> UnfollowUserAsync(CancellationToken ct, string friendPlayfabId, bool waitUpdateFriends = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE1")]
		[Cpp2IlInjected.Address(RVA = "0x146D800", Offset = "0x146C200", VA = "0x18146D800")]
		[AsyncStateMachine(typeof(_003CSearchFriendAsync_003Ed__89))]
		public Task<bool> SearchFriendAsync(CancellationToken ct, string search)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE2")]
		[Cpp2IlInjected.Address(RVA = "0x146C970", Offset = "0x146B370", VA = "0x18146C970")]
		private void AddSearchResult(string value, List<FollowData> result)
		{
			//Discarded unreachable code: IL_009b
			string value2 = value;
			SearchedValue = value;
			SearchList = result;
			List<SearchCacheInfo> searchCache = SearchCache;
			Predicate<SearchCacheInfo> predicate = (Predicate<SearchCacheInfo>)(object)(Predicate<T>)delegate(SearchCacheInfo x)
			{
				//Discarded unreachable code: IL_0014
				string b = value2;
				return string.Equals(x.Value, b);
			};
			int num = ((List<T>)(object)searchCache).RemoveAll((Predicate<>)(object)predicate);
			List<SearchCacheInfo> searchCache2 = SearchCache;
			int index = 0;
			((List<T>)(object)searchCache2).RemoveAt(index);
			List<SearchCacheInfo> searchCache3 = SearchCache;
			SearchCacheInfo searchCacheInfo = new SearchCacheInfo();
			searchCacheInfo.Result = result;
			int num2 = 0;
			DateTime dateTime = (searchCacheInfo.Time = DateTime.UtcNow);
			searchCacheInfo.Value = (string)(object)result;
			((List<T>)(object)searchCache3).Add((T)searchCacheInfo);
			this.OnSearchChange?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE3")]
		[Cpp2IlInjected.Address(RVA = "0x146D960", Offset = "0x146C360", VA = "0x18146D960")]
		private bool TryLoadFromCache(string value)
		{
			int num = 0;
			int num2 = 0;
			DateTime utcNow = DateTime.UtcNow;
			DateTime dateTime = default(DateTime);
			DateTime minTime = dateTime;
			List<SearchCacheInfo> searchCache = SearchCache;
			Predicate<SearchCacheInfo> predicate = (Predicate<SearchCacheInfo>)(object)(Predicate<T>)delegate(SearchCacheInfo x)
			{
				//Discarded unreachable code: IL_0016
				DateTime time = x.Time;
				DateTime dateTime2 = minTime;
				return time < dateTime2;
			};
			int num3 = ((List<T>)(object)searchCache).RemoveAll((Predicate<>)(object)predicate);
			List<SearchCacheInfo> searchCache2 = SearchCache;
			Predicate<SearchCacheInfo> predicate2 = (Predicate<SearchCacheInfo>)(object)(Predicate<T>)delegate(SearchCacheInfo x)
			{
				//Discarded unreachable code: IL_0014
				string b = value;
				return string.Equals(x.Value, b);
			};
			SearchCacheInfo searchCacheInfo = (SearchCacheInfo)((List<T>)(object)searchCache2).Find((Predicate<>)(object)predicate2);
			if (searchCacheInfo == null)
			{
			}
			string text = (SearchedValue = searchCacheInfo.Value);
			List<FollowData> list = (SearchList = searchCacheInfo.Result);
			this.OnSearchChange?.Invoke();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE4")]
		[Cpp2IlInjected.Address(RVA = "0x146CB90", Offset = "0x146B590", VA = "0x18146CB90")]
		private void CleanupSearchCache()
		{
			//Discarded unreachable code: IL_003a
			int num = 0;
			int num2 = 0;
			DateTime utcNow = DateTime.UtcNow;
			DateTime dateTime = default(DateTime);
			DateTime minTime = dateTime;
			List<SearchCacheInfo> searchCache = SearchCache;
			Predicate<SearchCacheInfo> predicate = (Predicate<SearchCacheInfo>)(object)(Predicate<T>)delegate(SearchCacheInfo x)
			{
				//Discarded unreachable code: IL_0016
				DateTime time = x.Time;
				DateTime dateTime2 = minTime;
				return time < dateTime2;
			};
			int num3 = ((List<T>)(object)searchCache).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE5")]
		[Cpp2IlInjected.Address(RVA = "0x146F080", Offset = "0x146DA80", VA = "0x18146F080")]
		public FriendManager()
		{
		}//IL_000a: Expected I4, but got I8
		//IL_0013: Expected I4, but got I8

	}
}
