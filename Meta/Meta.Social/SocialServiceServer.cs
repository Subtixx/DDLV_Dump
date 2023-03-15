using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Definitions.Util;
using Gameloft.Common;
using Gameloft.Rpc.Core.Server;
using glPlayFab;
using Google.Protobuf.Collections;
using PlayFab;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000DB1")]
	public class SocialServiceServer : SocialService.SocialServiceBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000DB2")]
		public class SyncOnlinePlayerInboxResult
		{
			[Cpp2IlInjected.Token(Token = "0x2000DB3")]
			public class UpdatedData
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4003730")]
				public int Amount;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4003731")]
				public bool Refunded;

				[Cpp2IlInjected.Token(Token = "0x6007297")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public UpdatedData()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400372F")]
			public Dictionary<string, UpdatedData> OnlineIdsUpdatedData = (Dictionary<string, UpdatedData>)(object)new Dictionary<TKey, TValue>();

			[Cpp2IlInjected.Token(Token = "0x6007296")]
			[Cpp2IlInjected.Address(RVA = "0x570730", Offset = "0x56F130", VA = "0x180570730")]
			public SyncOnlinePlayerInboxResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400371D")]
		private static readonly HttpClient httpClient = new HttpClient();

		[Cpp2IlInjected.Token(Token = "0x400371E")]
		private const string UNITY_FAKE_STORE = "fake";

		[Cpp2IlInjected.Token(Token = "0x400371F")]
		private const string APPLE_APP_STORE = "AppleAppStore";

		[Cpp2IlInjected.Token(Token = "0x4003720")]
		private const string GOOGLE_PLAY_STORE = "GooglePlay";

		[Cpp2IlInjected.Token(Token = "0x4003721")]
		private const string APPLE_APP_STORE_SANDBOX_URL = "https://sandbox.itunes.apple.com/verifyReceipt";

		[Cpp2IlInjected.Token(Token = "0x4003722")]
		private const string APPLE_APP_STORE_PRODUCTION_URL = "https://buy.itunes.apple.com/verifyReceipt";

		[Cpp2IlInjected.Token(Token = "0x4003723")]
		private const string GOOGLE_PLAY_PRODUCTS_URL = "https://www.googleapis.com/androidpublisher/v3/applications/packageName/purchases/products/productId/tokens/token";

		[Cpp2IlInjected.Token(Token = "0x4003724")]
		private const string GOOGLE_PLAY_SUBSCRIPTIONS_URL = "https://www.googleapis.com/androidpublisher/v3/applications/packageName/purchases/subscriptions/subscriptionId/tokens/token";

		[Cpp2IlInjected.Token(Token = "0x4003725")]
		private const string GOOGLE_PLAY_PACKAGE_NAME_TOKEN = "packageName";

		[Cpp2IlInjected.Token(Token = "0x4003726")]
		private const string GOOGLE_PLAY_PRODUCT_ID_TOKEN = "productId";

		[Cpp2IlInjected.Token(Token = "0x4003727")]
		private const string GOOGLE_PLAY_TOKEN_TOKEN = "token";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003728")]
		public readonly string NewsfeedImagePrefix = "Post";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003729")]
		public readonly int DefaultPostsNum = 25;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400372A")]
		private readonly IProfileHolder profileHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400372B")]
		private readonly NetworkDataProvider networkData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400372C")]
		private readonly ServerTransactionContext serverTransactionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400372E")]
		private ClientSession clientSession;

		[Cpp2IlInjected.Token(Token = "0x170013C2")]
		private ProfileEventDispatcher Dispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x6007289")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CDispatcher_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600728A")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			set
			{
				_003CDispatcher_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013C3")]
		public ISerializerPlugin Serializer
		{
			[Cpp2IlInjected.Token(Token = "0x600728C")]
			[Cpp2IlInjected.Address(RVA = "0x1831040", Offset = "0x182FA40", VA = "0x181831040")]
			get
			{
				return PluginManager.GetPlugin<ISerializerPlugin>(PluginContract.PlayFab_Serializer, "");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013C4")]
		private DisneyPlayFabContext playfabContext
		{
			[Cpp2IlInjected.Token(Token = "0x600728D")]
			[Cpp2IlInjected.Address(RVA = "0x18310B0", Offset = "0x182FAB0", VA = "0x1818310B0")]
			get
			{
				ClientSession clientSession = this.clientSession;
				if (clientSession != null && clientSession.playfabContext != null)
				{
					int num = 0;
				}
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013C5")]
		public IProfileHolder ProfileHolder
		{
			[Cpp2IlInjected.Token(Token = "0x600728E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return profileHolder;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013C6")]
		public Profile Profile
		{
			[Cpp2IlInjected.Token(Token = "0x600728F")]
			[Cpp2IlInjected.Address(RVA = "0x1830F90", Offset = "0x182F990", VA = "0x181830F90")]
			get
			{
				//Discarded unreachable code: IL_001c, IL_0023
				IProfileHolder profileHolder = this.profileHolder;
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				return profileHolder.Profile;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600725E")]
		[Cpp2IlInjected.Address(RVA = "0x182FAC0", Offset = "0x182E4C0", VA = "0x18182FAC0", Slot = "40")]
		public override Task<OnlineCollectLootPresent.Types.Response> OnlineCollectLootPresentAsync(OnlineCollectLootPresent.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			OnlineCollectLootPresent.Types.Response response = new OnlineCollectLootPresent.Types.Response();
			response.request_ = request;
			return (Task<OnlineCollectLootPresent.Types.Response>)(object)ExecuteAndApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600725F")]
		[Cpp2IlInjected.Address(RVA = "0x1830800", Offset = "0x182F200", VA = "0x181830800", Slot = "18")]
		public override Task<SuggestFollower.Types.Response> SuggestFollowerAsync(SuggestFollower.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SuggestFollower.Types.Response response = new SuggestFollower.Types.Response();
			response.request_ = request;
			return (Task<SuggestFollower.Types.Response>)(object)ExecuteTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007260")]
		[Cpp2IlInjected.Address(RVA = "0x1830540", Offset = "0x182EF40", VA = "0x181830540", Slot = "19")]
		public override Task<SearchFriends.Types.Response> SearchFriendsAsync(SearchFriends.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SearchFriends.Types.Response response = new SearchFriends.Types.Response();
			response.request_ = request;
			return (Task<SearchFriends.Types.Response>)(object)ExecuteTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007261")]
		[Cpp2IlInjected.Address(RVA = "0x182F2F0", Offset = "0x182DCF0", VA = "0x18182F2F0", Slot = "15")]
		public override Task<GetFollowData.Types.Response> GetFollowDataAsync(GetFollowData.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			GetFollowData.Types.Response response = new GetFollowData.Types.Response();
			response.request_ = request;
			return (Task<GetFollowData.Types.Response>)(object)ExecuteTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007262")]
		[Cpp2IlInjected.Address(RVA = "0x182F0E0", Offset = "0x182DAE0", VA = "0x18182F0E0", Slot = "14")]
		public override Task<FollowUser.Types.Response> FollowUserAsync(FollowUser.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			FollowUser.Types.Response response = new FollowUser.Types.Response();
			response.request_ = request;
			return (Task<FollowUser.Types.Response>)(object)ExecuteTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007263")]
		[Cpp2IlInjected.Address(RVA = "0x1830D40", Offset = "0x182F740", VA = "0x181830D40")]
		[AsyncStateMachine(typeof(_003CValidateReceiptAsync_003Ed__16))]
		public Task<bool> ValidateReceiptAsync(string receipt)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007264")]
		[Cpp2IlInjected.Address(RVA = "0x182EBA0", Offset = "0x182D5A0", VA = "0x18182EBA0", Slot = "38")]
		[AsyncStateMachine(typeof(_003CBuyIAPAsync_003Ed__17))]
		public override Task<BuyIAP.Types.Response> BuyIAPAsync(BuyIAP.Types.Request request, CallContext context)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<BuyIAP.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007265")]
		[Cpp2IlInjected.Address(RVA = "0x182F3A0", Offset = "0x182DDA0", VA = "0x18182F3A0", Slot = "24")]
		[AsyncStateMachine(typeof(_003CGetInboxAsync_003Ed__18))]
		public override Task<GetInbox.Types.Response> GetInboxAsync(GetInbox.Types.Request request, CallContext context)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GetInbox.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007266")]
		[Cpp2IlInjected.Address(RVA = "0x18301D0", Offset = "0x182EBD0", VA = "0x1818301D0", Slot = "28")]
		public override Task<ReadInboxMessages.Types.Response> ReadInboxMessagesAsync(ReadInboxMessages.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_001f
			//IL_0016: Expected I4, but got I8
			ReadInboxMessages.Types.Response response = new ReadInboxMessages.Types.Response();
			response.request_ = request;
			response.result_ = ReadInboxMessages.Types.Result.Success;
			return (Task<ReadInboxMessages.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007267")]
		[Cpp2IlInjected.Address(RVA = "0x182ECC0", Offset = "0x182D6C0", VA = "0x18182ECC0", Slot = "29")]
		[AsyncStateMachine(typeof(_003CClaimInboxMessagesAsync_003Ed__20))]
		public override Task<ClaimInboxMessages.Types.Response> ClaimInboxMessagesAsync(ClaimInboxMessages.Types.Request request, CallContext context)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<ClaimInboxMessages.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007268")]
		[Cpp2IlInjected.Address(RVA = "0x1830280", Offset = "0x182EC80", VA = "0x181830280", Slot = "30")]
		[AsyncStateMachine(typeof(_003CRefundInboxMessagesAsync_003Ed__21))]
		public override Task<RefundInboxMessages.Types.Response> RefundInboxMessagesAsync(RefundInboxMessages.Types.Request request, CallContext context)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<RefundInboxMessages.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007269")]
		[Cpp2IlInjected.Address(RVA = "0x182E7C0", Offset = "0x182D1C0", VA = "0x18182E7C0", Slot = "26")]
		public override Task<AddInboxMessage.Types.Response> AddInboxMessageAsync(AddInboxMessage.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0081
			//IL_008e: Expected O, but got I4
			//IL_00b2: Expected I4, but got I8
			int num = 0;
			if ((IntPtr)clientSession != (IntPtr)num)
			{
				AddInboxMessage.Types.Response response = new AddInboxMessage.Types.Response();
				response.result_ = (AddInboxMessage.Types.Result)num;
				Random random = new Random();
				if (num < request.messageNum_)
				{
					InboxMessage inboxMessage = new InboxMessage();
					string text = default(string);
					string text3 = (inboxMessage.Message = "test message" + text);
					inboxMessage.Title = "test title";
					int maxValue = 0;
					inboxMessage.Subtitle = "test subtitle";
					Dictionary<int, int> dictionary = (Dictionary<int, int>)(object)new Dictionary<TKey, TValue>();
					int num2 = 0;
					Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
					int num3 = random.Next(5, maxValue);
					throw new NullReferenceException();
				}
				Task<> result = default(Task<>);
				return (Task<AddInboxMessage.Types.Response>)(object)result;
			}
			AddInboxMessage.Types.Response response2 = new AddInboxMessage.Types.Response();
			response2.result_ = AddInboxMessage.Types.Result.UnknownError;
			Task<> task = Task.FromResult(response2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600726A")]
		[Cpp2IlInjected.Address(RVA = "0x18303E0", Offset = "0x182EDE0", VA = "0x1818303E0", Slot = "27")]
		public override Task<RemoveInboxMessage.Types.Response> RemoveInboxMessageAsync(RemoveInboxMessage.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_001f
			//IL_0016: Expected I4, but got I8
			RemoveInboxMessage.Types.Response response = new RemoveInboxMessage.Types.Response();
			response.request_ = request;
			response.result_ = RemoveInboxMessage.Types.Result.Success;
			return (Task<RemoveInboxMessage.Types.Response>)(object)ApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600726B")]
		[Cpp2IlInjected.Address(RVA = "0x182FEE0", Offset = "0x182E8E0", VA = "0x18182FEE0", Slot = "25")]
		[AsyncStateMachine(typeof(_003CPurgeInboxAsync_003Ed__24))]
		public override Task<PurgeInbox.Types.Response> PurgeInboxAsync(PurgeInbox.Types.Request request, CallContext context)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PurgeInbox.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600726C")]
		[Cpp2IlInjected.Address(RVA = "0x1830AC0", Offset = "0x182F4C0", VA = "0x181830AC0")]
		[AsyncStateMachine(typeof(_003CSyncOnlinePlayerInbox_003Ed__26))]
		private Task<SyncOnlinePlayerInboxResult> SyncOnlinePlayerInbox(Player player, World world)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<SyncOnlinePlayerInboxResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600726D")]
		[Cpp2IlInjected.Address(RVA = "0x182F4E0", Offset = "0x182DEE0", VA = "0x18182F4E0")]
		[AsyncStateMachine(typeof(_003CGetOnlinePlayerInbox_003Ed__27))]
		private Task<Inbox> GetOnlinePlayerInbox(Player player, World world, ITransactionContext transactionContext)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<Inbox>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600726E")]
		[Cpp2IlInjected.Address(RVA = "0x182F660", Offset = "0x182E060", VA = "0x18182F660")]
		[AsyncStateMachine(typeof(_003CGetPlayerInbox_003Ed__28))]
		private Task<Inbox> GetPlayerInbox(Player player, World world, ITransactionContext transactionContext)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<Inbox>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600726F")]
		[Cpp2IlInjected.Address(RVA = "0x1830020", Offset = "0x182EA20", VA = "0x181830020")]
		private int PurgeInboxMessagesInternal(Inbox inbox, PurgeFilter filter)
		{
			//Discarded unreachable code: IL_005c
			RepeatedField<InboxMessage> repeatedField = (RepeatedField<InboxMessage>)(object)((RepeatedField<T>)(object)inbox.inboxMessages_).Clone();
			Func<InboxMessage, bool> func = (Func<InboxMessage, bool>)(object)(Func<T, TResult>)delegate(InboxMessage x)
			{
				//Discarded unreachable code: IL_0044
				if (filter.IsEnabled(PurgeFilter.Claimed) && x.status_ == InboxMessageStatus.Claimed)
				{
					return true;
				}
				bool flag2 = filter.IsEnabled(PurgeFilter.Expired);
				if (!flag2)
				{
					return flag2;
				}
				int num = 0;
				long num2 = DateTime.UtcNow.ToProto().ToEpoch();
				long num3 = default(long);
				return num3 < num2;
			};
			IEnumerable<InboxMessage> enumerable = (IEnumerable<InboxMessage>)Enumerable.Where<InboxMessage>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
			Action<InboxMessage> action = (Action<InboxMessage>)(object)(Action<T>)delegate(InboxMessage x)
			{
				//Discarded unreachable code: IL_0013
				bool flag = ((RepeatedField<T>)(object)inbox.inboxMessages_).Remove((T)x);
			};
			MoreLinq.ForEach<InboxMessage>((IEnumerable<>)enumerable, (Action<>)(object)action);
			return Enumerable.Count<InboxMessage>((IEnumerable<>)enumerable);
		}

		[Cpp2IlInjected.Token(Token = "0x6007270")]
		[Cpp2IlInjected.Address(RVA = "0x182F240", Offset = "0x182DC40", VA = "0x18182F240", Slot = "41")]
		public override Task<GetBundles.Types.Response> GetBundlesAsync(GetBundles.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			GetBundles.Types.Response response = new GetBundles.Types.Response();
			response.request_ = request;
			return (Task<GetBundles.Types.Response>)(object)ExecuteAndApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007271")]
		[Cpp2IlInjected.Address(RVA = "0x182F7E0", Offset = "0x182E1E0", VA = "0x18182F7E0", Slot = "42")]
		public override Task<GetStores.Types.Response> GetStoresAsync(GetStores.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			GetStores.Types.Response response = new GetStores.Types.Response();
			response.request_ = request;
			return (Task<GetStores.Types.Response>)(object)ExecuteAndApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007272")]
		[Cpp2IlInjected.Address(RVA = "0x1830750", Offset = "0x182F150", VA = "0x181830750", Slot = "43")]
		public override Task<StorePurchase.Types.Response> StorePurchaseAsync(StorePurchase.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			StorePurchase.Types.Response response = new StorePurchase.Types.Response();
			response.request_ = request;
			return (Task<StorePurchase.Types.Response>)(object)ExecuteAndApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007273")]
		[Cpp2IlInjected.Address(RVA = "0x182FA10", Offset = "0x182E410", VA = "0x18182FA10", Slot = "39")]
		public override Task<OnlineClaimPromoCode.Types.Response> OnlineClaimPromoCodeAsync(OnlineClaimPromoCode.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			OnlineClaimPromoCode.Types.Response response = new OnlineClaimPromoCode.Types.Response();
			response.request_ = request;
			return (Task<OnlineClaimPromoCode.Types.Response>)(object)ExecuteTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007274")]
		[Cpp2IlInjected.Address(RVA = "0x182F190", Offset = "0x182DB90", VA = "0x18182F190", Slot = "44")]
		public override Task<GetBattlePasses.Types.Response> GetBattlePassesAsync(GetBattlePasses.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			GetBattlePasses.Types.Response response = new GetBattlePasses.Types.Response();
			response.request_ = request;
			return (Task<GetBattlePasses.Types.Response>)(object)ExecuteAndApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007275")]
		[Cpp2IlInjected.Address(RVA = "0x182EE20", Offset = "0x182D820", VA = "0x18182EE20", Slot = "45")]
		public override Task<CollectBattlePassTaskCurrency.Types.Response> CollectBattlePassTaskCurrencyAsync(CollectBattlePassTaskCurrency.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			CollectBattlePassTaskCurrency.Types.Response response = new CollectBattlePassTaskCurrency.Types.Response();
			response.request_ = request;
			return (Task<CollectBattlePassTaskCurrency.Types.Response>)(object)ExecuteAndApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007276")]
		[Cpp2IlInjected.Address(RVA = "0x182FD80", Offset = "0x182E780", VA = "0x18182FD80", Slot = "46")]
		public override Task<PurchaseBattlePassReward.Types.Response> PurchaseBattlePassRewardAsync(PurchaseBattlePassReward.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			PurchaseBattlePassReward.Types.Response response = new PurchaseBattlePassReward.Types.Response();
			response.request_ = request;
			return (Task<PurchaseBattlePassReward.Types.Response>)(object)ExecuteAndApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007277")]
		[Cpp2IlInjected.Address(RVA = "0x182FE30", Offset = "0x182E830", VA = "0x18182FE30", Slot = "47")]
		public override Task<PurchasePremiumPass.Types.Response> PurchasePremiumPassAsync(PurchasePremiumPass.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			PurchasePremiumPass.Types.Response response = new PurchasePremiumPass.Types.Response();
			response.request_ = request;
			return (Task<PurchasePremiumPass.Types.Response>)(object)ExecuteAndApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007278")]
		[Cpp2IlInjected.Address(RVA = "0x182FCD0", Offset = "0x182E6D0", VA = "0x18182FCD0", Slot = "48")]
		public override Task<PurchaseBattlePassCurrency.Types.Response> PurchaseBattlePassCurrencyAsync(PurchaseBattlePassCurrency.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			PurchaseBattlePassCurrency.Types.Response response = new PurchaseBattlePassCurrency.Types.Response();
			response.request_ = request;
			return (Task<PurchaseBattlePassCurrency.Types.Response>)(object)ExecuteAndApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007279")]
		[Cpp2IlInjected.Address(RVA = "0x182EF80", Offset = "0x182D980", VA = "0x18182EF80", Slot = "49")]
		public override Task<DebugAddOnlineCurrency.Types.Response> DebugAddOnlineCurrencyAsync(DebugAddOnlineCurrency.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugAddOnlineCurrency.Types.Response response = new DebugAddOnlineCurrency.Types.Response();
			response.request_ = request;
			return (Task<DebugAddOnlineCurrency.Types.Response>)(object)ExecuteAndApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600727A")]
		[Cpp2IlInjected.Address(RVA = "0x182F030", Offset = "0x182DA30", VA = "0x18182F030", Slot = "50")]
		public override Task<DebugSpendOnlineCurrency.Types.Response> DebugSpendOnlineCurrencyAsync(DebugSpendOnlineCurrency.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			DebugSpendOnlineCurrency.Types.Response response = new DebugSpendOnlineCurrency.Types.Response();
			response.request_ = request;
			return (Task<DebugSpendOnlineCurrency.Types.Response>)(object)ExecuteAndApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600727B")]
		[Cpp2IlInjected.Address(RVA = "0x18308B0", Offset = "0x182F2B0", VA = "0x1818308B0", Slot = "51")]
		public override Task<SyncOnline.Types.Response> SyncOnlineAsync(SyncOnline.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SyncOnline.Types.Response response = new SyncOnline.Types.Response();
			response.request_ = request;
			return (Task<SyncOnline.Types.Response>)(object)ExecuteAndApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600727C")]
		[Cpp2IlInjected.Address(RVA = "0x1830A10", Offset = "0x182F410", VA = "0x181830A10", Slot = "52")]
		public override Task<SyncOnlineInventory.Types.Response> SyncOnlineInventoryAsync(SyncOnlineInventory.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SyncOnlineInventory.Types.Response response = new SyncOnlineInventory.Types.Response();
			response.request_ = request;
			return (Task<SyncOnlineInventory.Types.Response>)(object)ExecuteAndApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600727D")]
		[Cpp2IlInjected.Address(RVA = "0x1830960", Offset = "0x182F360", VA = "0x181830960", Slot = "53")]
		public override Task<SyncOnlineCurrencies.Types.Response> SyncOnlineCurrenciesAsync(SyncOnlineCurrencies.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SyncOnlineCurrencies.Types.Response response = new SyncOnlineCurrencies.Types.Response();
			response.request_ = request;
			return (Task<SyncOnlineCurrencies.Types.Response>)(object)ExecuteAndApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600727E")]
		[Cpp2IlInjected.Address(RVA = "0x182EED0", Offset = "0x182D8D0", VA = "0x18182EED0", Slot = "20")]
		public override Task<CreateNewsFeed.Types.Response> CreateNewsFeedAsync(CreateNewsFeed.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			CreateNewsFeed.Types.Response response = new CreateNewsFeed.Types.Response();
			response.request_ = request;
			return (Task<CreateNewsFeed.Types.Response>)(object)ExecuteTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600727F")]
		[Cpp2IlInjected.Address(RVA = "0x182F8B0", Offset = "0x182E2B0", VA = "0x18182F8B0", Slot = "21")]
		public override Task<GetUserPosts.Types.Response> GetUserPostsAsync(GetUserPosts.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			GetUserPosts.Types.Response response = new GetUserPosts.Types.Response();
			response.request_ = request;
			return (Task<GetUserPosts.Types.Response>)(object)ExecuteTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007280")]
		[Cpp2IlInjected.Address(RVA = "0x182FC20", Offset = "0x182E620", VA = "0x18182FC20", Slot = "31")]
		public override Task<PostPicture.Types.Response> PostPictureAsync(PostPicture.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			PostPicture.Types.Response response = new PostPicture.Types.Response();
			response.request_ = request;
			return (Task<PostPicture.Types.Response>)(object)ExecuteAndApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007281")]
		[Cpp2IlInjected.Address(RVA = "0x182F960", Offset = "0x182E360", VA = "0x18182F960", Slot = "22")]
		public override Task<LikeNewsFeed.Types.Response> LikeNewsFeedAsync(LikeNewsFeed.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0028
			//IL_0016: Expected I4, but got I8
			//IL_001f: Expected I4, but got I8
			LikeNewsFeed.Types.Response response = new LikeNewsFeed.Types.Response();
			response.request_ = request;
			response.result_ = LikeNewsFeed.Types.Result.Success;
			response.bonusSocialRewards_ = 0;
			return (Task<LikeNewsFeed.Types.Response>)(object)ExecuteAndApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007282")]
		[Cpp2IlInjected.Address(RVA = "0x1830C90", Offset = "0x182F690", VA = "0x181830C90", Slot = "23")]
		public override Task<UnlikeNewsFeed.Types.Response> UnlikeNewsFeedAsync(UnlikeNewsFeed.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_001f
			//IL_0016: Expected I4, but got I8
			UnlikeNewsFeed.Types.Response response = new UnlikeNewsFeed.Types.Response();
			response.request_ = request;
			response.result_ = UnlikeNewsFeed.Types.Result.Success;
			return (Task<UnlikeNewsFeed.Types.Response>)(object)ExecuteTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007283")]
		[Cpp2IlInjected.Address(RVA = "0x182FB70", Offset = "0x182E570", VA = "0x18182FB70", Slot = "9")]
		public override Task<PostLogin.Types.Response> PostLoginAsync(PostLogin.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			PostLogin.Types.Response response = new PostLogin.Types.Response();
			response.request_ = request;
			return (Task<PostLogin.Types.Response>)(object)ExecuteAndApplyTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007284")]
		[Cpp2IlInjected.Address(RVA = "0x182EAF0", Offset = "0x182D4F0", VA = "0x18182EAF0", Slot = "10")]
		public override Task<AutoRedeemFoundersPack.Types.Response> AutoRedeemFoundersPackAsync(AutoRedeemFoundersPack.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			AutoRedeemFoundersPack.Types.Response response = new AutoRedeemFoundersPack.Types.Response();
			response.request_ = request;
			return (Task<AutoRedeemFoundersPack.Types.Response>)(object)ExecuteTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007285")]
		[Cpp2IlInjected.Address(RVA = "0x1830BE0", Offset = "0x182F5E0", VA = "0x181830BE0", Slot = "11")]
		public override Task<TransferMarketplacePacks.Types.Response> TransferMarketplacePacksAsync(TransferMarketplacePacks.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			TransferMarketplacePacks.Types.Response response = new TransferMarketplacePacks.Types.Response();
			response.request_ = request;
			return (Task<TransferMarketplacePacks.Types.Response>)(object)ExecuteTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007286")]
		[Cpp2IlInjected.Address(RVA = "0x18305F0", Offset = "0x182EFF0", VA = "0x1818305F0", Slot = "34")]
		public override Task<SetPlayfabAvatar.Types.Response> SetPlayfabAvatarAsync(SetPlayfabAvatar.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SetPlayfabAvatar.Types.Response response = new SetPlayfabAvatar.Types.Response();
			response.request_ = request;
			return (Task<SetPlayfabAvatar.Types.Response>)(object)ExecuteTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007287")]
		[Cpp2IlInjected.Address(RVA = "0x18306A0", Offset = "0x182F0A0", VA = "0x1818306A0", Slot = "33")]
		public override Task<SetPlayfabName.Types.Response> SetPlayfabNameAsync(SetPlayfabName.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			SetPlayfabName.Types.Response response = new SetPlayfabName.Types.Response();
			response.request_ = request;
			return (Task<SetPlayfabName.Types.Response>)(object)ExecuteTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6007288")]
		[Cpp2IlInjected.Address(RVA = "0x1830490", Offset = "0x182EE90", VA = "0x181830490", Slot = "35")]
		public override Task<ResetPlayfabNameChangeCooldown.Types.Response> ResetPlayfabNameChangeCooldownAsync(ResetPlayfabNameChangeCooldown.Types.Request request, CallContext context)
		{
			//Discarded unreachable code: IL_0016
			ResetPlayfabNameChangeCooldown.Types.Response response = new ResetPlayfabNameChangeCooldown.Types.Response();
			response.request_ = request;
			return (Task<ResetPlayfabNameChangeCooldown.Types.Response>)(object)ExecuteTransaction(response, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600728B")]
		[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
		public void SetClientSession(ClientSession clientSession)
		{
			this.clientSession = clientSession;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007290")]
		[Cpp2IlInjected.Address(RVA = "0x182F890", Offset = "0x182E290", VA = "0x18182F890")]
		internal ServerTransactionContext GetTransactionContext(Profile profile, CallContext callContext)
		{
			//Discarded unreachable code: IL_000e
			return serverTransactionContext.PrepareForTransaction(profile, callContext);
		}

		[Cpp2IlInjected.Token(Token = "0x6007291")]
		[Cpp2IlInjected.Address(RVA = "0x1830ED0", Offset = "0x182F8D0", VA = "0x181830ED0")]
		public SocialServiceServer(IProfileHolder profileHolder, ProfileEventDispatcher dispatcher, NetworkDataProvider networkData, ServerTransactionContext serverTransactionContext)
		{
			//IL_0015: Expected I4, but got I8
			//IL_0037: Expected O, but got I4
			this.profileHolder = profileHolder;
			Dispatcher = dispatcher;
			this.networkData = networkData;
			this.serverTransactionContext = (ServerTransactionContext)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007292")]
		[Cpp2IlInjected.Address(RVA = "0x1B23FC0", Offset = "0x1B229C0", VA = "0x181B23FC0")]
		[AsyncStateMachine(typeof(_003CExecuteAndApplyTransaction_003Ed__76<>))]
		private Task<> ExecuteAndApplyTransaction<TResponse>(TResponse response, CallContext cpp2il__autoParamName__idx_1) where TResponse : IOnlineAndTransactionAction
		{
			int num = 0;
			Task<> result = default(Task<>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007293")]
		[Cpp2IlInjected.Address(RVA = "0x1B24130", Offset = "0x1B22B30", VA = "0x181B24130")]
		[AsyncStateMachine(typeof(_003CExecuteTransaction_003Ed__77<>))]
		private Task<> ExecuteTransaction<TResponse>(TResponse response, CallContext cpp2il__autoParamName__idx_1) where TResponse : IOnlineAction
		{
			int num = 0;
			Task<> result = default(Task<>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007294")]
		[Cpp2IlInjected.Address(RVA = "0x1B23DD0", Offset = "0x1B227D0", VA = "0x181B23DD0")]
		private Task<> ApplyTransaction<TResponse>(TResponse response, CallContext cpp2il__autoParamName__idx_1) where TResponse : ITransactionAction
		{
			//Discarded unreachable code: IL_0027
			int num = 0;
			Profile profile = Profile;
			Profile profile2 = Profile;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			ServerTransactionContext serverTransactionContext = default(ServerTransactionContext);
			if (serverTransactionContext != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007295")]
		[Cpp2IlInjected.Address(RVA = "0x1830E60", Offset = "0x182F860", VA = "0x181830E60")]
		static SocialServiceServer()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
