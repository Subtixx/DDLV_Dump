using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using glPlayFab;
using PlayFab.EconomyModels;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000DA6")]
	public sealed class NewsfeedUtils
	{
		[Cpp2IlInjected.Token(Token = "0x40036F0")]
		public static string NewsfeedImagePrefix = "Post";

		[Cpp2IlInjected.Token(Token = "0x40036F1")]
		public static int DefaultPostsNum;

		[Cpp2IlInjected.Token(Token = "0x600723C")]
		[Cpp2IlInjected.Address(RVA = "0x139B440", Offset = "0x1399E40", VA = "0x18139B440")]
		[AsyncStateMachine(typeof(_003CAddNewsFeedUserInfo_003Ed__2))]
		public static Task AddNewsFeedUserInfo(ClientSession clientSession, List<CatalogItem> items, List<NewsFeedPost> list, KnownProfiles knownProfiles, int max, bool acceptMyPost = false)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600723D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public NewsfeedUtils()
		{
		}
	}
}
