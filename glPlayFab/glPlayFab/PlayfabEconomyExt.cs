using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using PlayFab;
using PlayFab.EconomyModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public static class PlayfabEconomyExt
	{
		[Cpp2IlInjected.Token(Token = "0x200015B")]
		public class InventoryItemsResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			public List<InventoryItem> Items;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			public PlayFabError Error;

			[Cpp2IlInjected.Token(Token = "0x6000686")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public InventoryItemsResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200015C")]
		public class InventoryItemWithMetadataResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			public InventoryItem Item;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			public CatalogItem ItemMetadata;

			[Cpp2IlInjected.Token(Token = "0x6000687")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public InventoryItemWithMetadataResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200015D")]
		public class InventoryItemsWithMetadataResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			public List<InventoryItemWithMetadataResult> Items;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			public PlayFabError Error;

			[Cpp2IlInjected.Token(Token = "0x6000688")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public InventoryItemsWithMetadataResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200015E")]
		public class GetInventoryItemsResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			public List<CatalogItem> ItemMetadata;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public List<InventoryItem> Items;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			public PlayFabError Error;

			[Cpp2IlInjected.Token(Token = "0x6000689")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public GetInventoryItemsResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200015F")]
		public class GrantBundleResult
		{
			[Cpp2IlInjected.Token(Token = "0x1700018E")]
			public CatalogItem Bundle
			{
				[Cpp2IlInjected.Token(Token = "0x600068A")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CBundle_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600068B")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CBundle_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700018F")]
			public PlayFabResult<GrantInventoryItemsResult> GrantInventoryItemsResult
			{
				[Cpp2IlInjected.Token(Token = "0x600068C")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CGrantInventoryItemsResult_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600068D")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CGrantInventoryItemsResult_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000190")]
			public PlayFabResult<AddVirtualCurrenciesResult> AddVirtualCurrenciesResult
			{
				[Cpp2IlInjected.Token(Token = "0x600068E")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CAddVirtualCurrenciesResult_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600068F")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CAddVirtualCurrenciesResult_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x1AEB490", Offset = "0x1AE9E90", VA = "0x181AEB490")]
			public bool IsSuccess()
			{
				if (GrantInventoryItemsResult == null || AddVirtualCurrenciesResult != null)
				{
				}
				int num = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public GrantBundleResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public const int GetDraftItemsMaxPageSize = 10;

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public const int GetInventoryItemsMaxPageSize = 200;

		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public const string ContentTypePropName = "content";

		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public const string LinkItemIdPropName = "linkid";

		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public const string NotStartedPropName = "notstarted";

		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public const string IsHiddenPropName = "hidden";

		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public const string EventIsPremiumPropName = "ispremium";

		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public const string EventPremiumBundleBoughtPropName = "bundlebought";

		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public const string EventTasksPropName = "tasks";

		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public const string EventRewardsPropName = "rewards";

		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public static string ItemsTypeFilter;

		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public const string SelectAll = "startDate,endDate,title,description";

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public const string SelectTitleAndDesc = "title,description";

		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public const string SelectDates = "startDate,endDate";

		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public const int SearchItemsMaxPageSize = 225;

		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public static Dictionary<SearchOperator, SearchOperator> InverseOperatorMappings;

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public static string UgcTypeFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(RVA = "0x14F4520", Offset = "0x14F2F20", VA = "0x1814F4520")]
			get
			{
				//IL_000c: Expected O, but got I4
				//IL_000c: Expected O, but got I4
				SearchField searchField = default(SearchField);
				SearchType searchType = default(SearchType);
				return $"{searchField} eq '{searchType}'";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public static string CurrencyTypeFilter
		{
			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(RVA = "0x14F4370", Offset = "0x14F2D70", VA = "0x1814F4370")]
			get
			{
				//IL_000c: Expected O, but got I4
				//IL_000c: Expected O, but got I4
				SearchField searchField = default(SearchField);
				SearchType searchType = default(SearchType);
				return $"{searchField} eq '{searchType}'";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public static string BundleTypeFilter
		{
			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(RVA = "0x14F42E0", Offset = "0x14F2CE0", VA = "0x1814F42E0")]
			get
			{
				//IL_000c: Expected O, but got I4
				//IL_000c: Expected O, but got I4
				SearchField searchField = default(SearchField);
				SearchType searchType = default(SearchType);
				return $"{searchField} eq '{searchType}'";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public static string RecipeTypeFilter
		{
			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(RVA = "0x14F4400", Offset = "0x14F2E00", VA = "0x1814F4400")]
			get
			{
				//IL_000c: Expected O, but got I4
				//IL_000c: Expected O, but got I4
				SearchField searchField = default(SearchField);
				SearchType searchType = default(SearchType);
				return $"{searchField} eq '{searchType}'";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public static string StoreTypeFilter
		{
			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(RVA = "0x14F4490", Offset = "0x14F2E90", VA = "0x1814F4490")]
			get
			{
				//IL_000c: Expected O, but got I4
				//IL_000c: Expected O, but got I4
				SearchField searchField = default(SearchField);
				SearchType searchType = default(SearchType);
				return $"{searchField} eq '{searchType}'";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x14F3AF0", Offset = "0x14F24F0", VA = "0x1814F3AF0")]
		public static string ToQuery(this SearchField searchField)
		{
			//Discarded unreachable code: IL_0002
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x14F24B0", Offset = "0x14F0EB0", VA = "0x1814F24B0")]
		public static bool IsCollection(this SearchField searchField)
		{
			if (searchField == SearchField.alternateIds_any)
			{
				return true;
			}
			return searchField == SearchField.alternateIds_all;
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x14F2690", Offset = "0x14F1090", VA = "0x1814F2690")]
		public static string ParseDisplayPropertyName(this SearchField searchField)
		{
			//Discarded unreachable code: IL_0002
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x14F1530", Offset = "0x14EFF30", VA = "0x1814F1530")]
		public static EntityKey GetEconomyEntityKey(this PlayFabAuthenticationContext self)
		{
			//Discarded unreachable code: IL_0024
			EntityKey entityKey = new EntityKey();
			string text = (entityKey.Type = self.EntityType);
			string text2 = (entityKey.Id = self.EntityId);
			return entityKey;
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x14F15B0", Offset = "0x14EFFB0", VA = "0x1814F15B0")]
		public static EntityKey GetEntityKey(this PlayFabEconomyInstanceAPI self)
		{
			//Discarded unreachable code: IL_002b
			PlayFabAuthenticationContext authenticationContext = self.authenticationContext;
			EntityKey entityKey = new EntityKey();
			string text = (entityKey.Type = authenticationContext.EntityType);
			string text2 = (entityKey.Id = authenticationContext.EntityId);
			return entityKey;
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x14F0470", Offset = "0x14EEE70", VA = "0x1814F0470")]
		public static string BuildEntityStr(this PlayFabEconomyInstanceAPI self)
		{
			//Discarded unreachable code: IL_0022
			PlayFabAuthenticationContext authenticationContext = self.authenticationContext;
			string entityType = authenticationContext.EntityType;
			string entityId = authenticationContext.EntityId;
			return entityType + "!" + entityId;
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x14F0360", Offset = "0x14EED60", VA = "0x1814F0360")]
		public static string BuildEntityStr(this PlayFabEconomyInstanceAPI self, Entity.Types entityType, string entityId)
		{
			string text = default(string);
			return text + "!" + entityId;
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x14F0420", Offset = "0x14EEE20", VA = "0x1814F0420")]
		public static string BuildEntityStr(this PlayFabEconomyInstanceAPI self, string entityType, string entityId)
		{
			return entityType + "!" + entityId;
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x14F1410", Offset = "0x14EFE10", VA = "0x1814F1410")]
		[AsyncStateMachine(typeof(_003CGetAllDraftItemsAsync_003Ed__18))]
		public static Task<IList<CatalogItem>> GetAllDraftItemsAsync(this PlayFabEconomyInstanceAPI self)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<IList<CatalogItem>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x14F1680", Offset = "0x14F0080", VA = "0x1814F1680")]
		public static Task<InventoryItemsWithMetadataResult> GetInventoryCatalogItems(this PlayFabEconomyInstanceAPI self, EntityKey entity, bool getItemMetadata = false, [Optional] ItemFilter itemFilter)
		{
			Task<InventoryItemsWithMetadataResult> result = default(Task<InventoryItemsWithMetadataResult>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x14F1830", Offset = "0x14F0230", VA = "0x1814F1830")]
		public static Task<InventoryItemsResult> GetInventoryInbox(this PlayFabEconomyInstanceAPI self, EntityKey entity, [Optional] ItemFilter itemFilter, int minAmount = 1)
		{
			//IL_0015: Expected O, but got I4
			int num = 0;
			List<string> mailboxContentTypes = (List<string>)(object)PlayFabContentType.GetMailboxContentTypes();
			int num2 = 0;
			return (Task<InventoryItemsResult>)(object)PlayfabEconomyExt.GetInventory(self, entity, minAmount, (Nullable<>)num2, (List<>)(object)mailboxContentTypes, itemFilter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x14F1760", Offset = "0x14F0160", VA = "0x1814F1760")]
		public static Task<InventoryItemsWithMetadataResult> GetInventoryInboxWithMetadata(this PlayFabEconomyInstanceAPI self, EntityKey entity, [Optional] ItemFilter itemFilter)
		{
			//IL_0015: Expected O, but got I4
			int num = 0;
			List<string> mailboxContentTypes = (List<string>)(object)PlayFabContentType.GetMailboxContentTypes();
			int num2 = 0;
			return (Task<InventoryItemsWithMetadataResult>)(object)PlayfabEconomyExt.GetInventoryWithMetadata(self, entity, 1, (Nullable<>)num2, (List<>)(object)mailboxContentTypes, itemFilter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x14F1BB0", Offset = "0x14F05B0", VA = "0x1814F1BB0")]
		public static Task<InventoryItemsResult> GetInventoryMarketplacePurchases(this PlayFabEconomyInstanceAPI self, EntityKey entity, [Optional] ItemFilter itemFilter, int minAmount = 1)
		{
			//Discarded unreachable code: IL_0022
			//IL_0021: Expected O, but got I4
			List<string> list = (List<string>)(object)new List<T>();
			string name = PlayFabContentType.GetName(ContentType.Key_MarketMailbox);
			((List<T>)(object)list).Add((T)name);
			int num = 0;
			return (Task<InventoryItemsResult>)(object)PlayfabEconomyExt.GetInventory(self, entity, minAmount, (Nullable<>)num, (List<>)(object)list, itemFilter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x14F1A70", Offset = "0x14F0470", VA = "0x1814F1A70")]
		public static Task<InventoryItemsWithMetadataResult> GetInventoryMarketplacePurchasesWithMetaData(this PlayFabEconomyInstanceAPI self, EntityKey entity, [Optional] ItemFilter itemFilter, int minAmount = 1)
		{
			//Discarded unreachable code: IL_0022
			//IL_0021: Expected O, but got I4
			List<string> list = (List<string>)(object)new List<T>();
			string name = PlayFabContentType.GetName(ContentType.Key_MarketMailbox);
			((List<T>)(object)list).Add((T)name);
			int num = 0;
			return (Task<InventoryItemsWithMetadataResult>)(object)PlayfabEconomyExt.GetInventoryWithMetadata(self, entity, minAmount, (Nullable<>)num, (List<>)(object)list, itemFilter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x14F1F30", Offset = "0x14F0930", VA = "0x1814F1F30")]
		[AsyncStateMachine(typeof(_003CGetInventory_003Ed__27))]
		public static Task<InventoryItemsResult> GetInventory(this PlayFabEconomyInstanceAPI self, EntityKey entity, int minAmount = 1, [Optional] SearchType? type, [Optional] List<string> contentTypes, [Optional] ItemFilter itemFilter)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<InventoryItemsResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x14F1CF0", Offset = "0x14F06F0", VA = "0x1814F1CF0")]
		public static Task<InventoryItemsWithMetadataResult> GetInventoryWithMetadata(this PlayFabEconomyInstanceAPI self, EntityKey entity, int minAmount = 1, [Optional] SearchType? type, [Optional] List<string> contentTypes, [Optional] ItemFilter itemFilter)
		{
			Task<InventoryItemsWithMetadataResult> result = default(Task<InventoryItemsWithMetadataResult>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x14F1DA0", Offset = "0x14F07A0", VA = "0x1814F1DA0")]
		[AsyncStateMachine(typeof(_003CGetInventory_003Ed__29))]
		private static Task<InventoryItemsWithMetadataResult> GetInventory(this PlayFabEconomyInstanceAPI self, EntityKey entity, bool getItemMetadata, int minAmount = 1, [Optional] SearchType? type, [Optional] List<string> contentTypes, [Optional] ItemFilter itemFilter)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<InventoryItemsWithMetadataResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x14F1910", Offset = "0x14F0310", VA = "0x1814F1910")]
		[AsyncStateMachine(typeof(_003CGetInventoryItemsAsync_003Ed__31))]
		private static Task<GetInventoryItemsResult> GetInventoryItemsAsync(this PlayFabEconomyInstanceAPI self, EntityKey entity, [Optional] ItemFilter itemFilter)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GetInventoryItemsResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x14F2330", Offset = "0x14F0D30", VA = "0x1814F2330")]
		[AsyncStateMachine(typeof(_003CGrantBundleAsync_003Ed__33))]
		public static Task<GrantBundleResult> GrantBundleAsync(this PlayFabEconomyInstanceAPI self, PlayFabContext context, CatalogItem bundle, List<CatalogItem> referencedItems)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GrantBundleResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x14F1140", Offset = "0x14EFB40", VA = "0x1814F1140")]
		public static Task<IList<CatalogItem>> FilterCatalogItemsAsync(this PlayFabEconomyInstanceAPI self, bool getAllLocalizedTexts = false)
		{
			string itemsTypeFilter = ItemsTypeFilter;
			return (Task<IList<CatalogItem>>)(object)PlayfabEconomyExt.FilterItemsAsync(self, itemsTypeFilter, getAllLocalizedTexts);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x14F11C0", Offset = "0x14EFBC0", VA = "0x1814F11C0")]
		public static Task<IList<CatalogItem>> FilterCurrenciesAsync(this PlayFabEconomyInstanceAPI self)
		{
			int num = 0;
			string currencyTypeFilter = CurrencyTypeFilter;
			int num2 = 0;
			return (Task<IList<CatalogItem>>)(object)PlayfabEconomyExt.FilterItemsAsync(self, currencyTypeFilter, (byte)num2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x14F13B0", Offset = "0x14EFDB0", VA = "0x1814F13B0")]
		public static Task<IList<CatalogItem>> FilterUgcItemsAsync(this PlayFabEconomyInstanceAPI self)
		{
			int num = 0;
			string ugcTypeFilter = UgcTypeFilter;
			int num2 = 0;
			return (Task<IList<CatalogItem>>)(object)PlayfabEconomyExt.FilterItemsAsync(self, ugcTypeFilter, (byte)num2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x14F08B0", Offset = "0x14EF2B0", VA = "0x1814F08B0")]
		public static Task<IList<CatalogItem>> FilterBundlesAsync(this PlayFabEconomyInstanceAPI self)
		{
			int num = 0;
			string bundleTypeFilter = BundleTypeFilter;
			int num2 = 0;
			return (Task<IList<CatalogItem>>)(object)PlayfabEconomyExt.FilterItemsAsync(self, bundleTypeFilter, (byte)num2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x14F1350", Offset = "0x14EFD50", VA = "0x1814F1350")]
		public static Task<IList<CatalogItem>> FilterStoresAsync(this PlayFabEconomyInstanceAPI self)
		{
			int num = 0;
			string storeTypeFilter = StoreTypeFilter;
			int num2 = 0;
			return (Task<IList<CatalogItem>>)(object)PlayfabEconomyExt.FilterItemsAsync(self, storeTypeFilter, (byte)num2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x14F12F0", Offset = "0x14EFCF0", VA = "0x1814F12F0")]
		public static Task<IList<CatalogItem>> FilterRecipesAsync(this PlayFabEconomyInstanceAPI self)
		{
			int num = 0;
			string recipeTypeFilter = RecipeTypeFilter;
			int num2 = 0;
			return (Task<IList<CatalogItem>>)(object)PlayfabEconomyExt.FilterItemsAsync(self, recipeTypeFilter, (byte)num2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x14F1220", Offset = "0x14EFC20", VA = "0x1814F1220")]
		public static Task<IList<CatalogItem>> FilterItemsAsync(this PlayFabEconomyInstanceAPI self, string filter, bool getAllLocalizedTexts = false)
		{
			//IL_0014: Expected O, but got I4
			if (!getAllLocalizedTexts)
			{
			}
			int num = 0;
			string text = default(string);
			return (Task<IList<CatalogItem>>)(object)PlayfabEconomyExt.SearchAllItemsAsync(self, filter, (string)num, "id", text);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x14F2DF0", Offset = "0x14F17F0", VA = "0x1814F2DF0")]
		public static Task<IList<CatalogItem>> SearchAllItemsAsync(this PlayFabEconomyInstanceAPI self, [Optional] string filter, [Optional] string search, string orderBy = "id", [Optional] string select)
		{
			//Discarded unreachable code: IL_0032
			//IL_0022: Expected O, but got I4
			SearchItemsRequest searchItemsRequest = new SearchItemsRequest();
			searchItemsRequest.Search = search;
			searchItemsRequest.Filter = filter;
			searchItemsRequest.OrderBy = orderBy;
			searchItemsRequest.Select = (string)0;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<IList<CatalogItem>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x14F3010", Offset = "0x14F1A10", VA = "0x1814F3010")]
		[AsyncStateMachine(typeof(_003CSearchAllItemsAsync_003Ed__58))]
		public static Task<IList<CatalogItem>> SearchAllItemsAsync(this PlayFabEconomyInstanceAPI self, SearchItemsRequest request)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<IList<CatalogItem>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x14F20B0", Offset = "0x14F0AB0", VA = "0x1814F20B0")]
		public static Task<IList<CatalogItem>> GetUserAllSaveBackupsByType(this PlayFabEconomyInstanceAPI self, EntityKey entityKey, string contentTypeName)
		{
			//Discarded unreachable code: IL_0051
			string _003CId_003Ek__BackingField = entityKey.Id;
			string extraFilter = "contentType eq '" + contentTypeName + "'";
			int num = 0;
			string filter = self.UgcFilterByCreator(Entity.Types.TitlePlayerAccount, _003CId_003Ek__BackingField, extraFilter, (SearchOperator)num, (SearchExtraFlags)num);
			SearchItemsRequest searchItemsRequest = new SearchItemsRequest();
			searchItemsRequest.Filter = filter;
			searchItemsRequest.OrderBy = "CreationDate desc";
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<IList<CatalogItem>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x14F3160", Offset = "0x14F1B60", VA = "0x1814F3160")]
		[AsyncStateMachine(typeof(_003CSearchAllItemsReturnNullOnErrorAsync_003Ed__60))]
		public static Task<IList<CatalogItem>> SearchAllItemsReturnNullOnErrorAsync(this PlayFabEconomyInstanceAPI self, SearchItemsRequest request)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<IList<CatalogItem>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x14F33B0", Offset = "0x14F1DB0", VA = "0x1814F33B0")]
		public static Task<PlayFabResult<SearchItemsResponse>> SearchItemsAsync(this PlayFabEconomyInstanceAPI self, [Optional] string search, [Optional] string filter, [Optional] string select, string orderBy = "creationDate desc, id", int count = 225, [Optional] EntityKey entity, bool expandReferencedItems = false, [Optional] Dictionary<string, string> extraHeaders)
		{
			//Discarded unreachable code: IL_003b
			//IL_000d: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			SearchItemsRequest searchItemsRequest = new SearchItemsRequest();
			searchItemsRequest.Entity = (EntityKey)0;
			searchItemsRequest.Search = search;
			searchItemsRequest.Filter = filter;
			searchItemsRequest.Select = select;
			searchItemsRequest.OrderBy = (string)0;
			int num = 0;
			searchItemsRequest.Count = 0;
			searchItemsRequest.ExpandReferencedItems = (bool?)(object)num;
			Task<PlayFabResult<SearchItemsResponse>> result = default(Task<PlayFabResult<SearchItemsResponse>>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x14F32B0", Offset = "0x14F1CB0", VA = "0x1814F32B0")]
		public static Task<PlayFabResult<SearchItemsResponse>> SearchBundleItemsAsync(this PlayFabEconomyInstanceAPI self, bool getAllLocalizedTexts = false)
		{
			//IL_002f: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			//IL_002f: Expected I4, but got I8
			//IL_002f: Expected O, but got I4
			int num = 0;
			string bundleTypeFilter = BundleTypeFilter;
			string text = "startDate,endDate";
			if (getAllLocalizedTexts)
			{
				text = "startDate,endDate,title,description";
			}
			int num2 = 0;
			int num3 = 0;
			string text2 = default(string);
			ulong num4 = default(ulong);
			return (Task<PlayFabResult<SearchItemsResponse>>)(object)PlayfabEconomyExt.SearchItemsAsync(self, (string)num3, bundleTypeFilter, text, text2, (int)num4, (EntityKey)num2, (byte)num2 != 0, (Dictionary<, >)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x14F34E0", Offset = "0x14F1EE0", VA = "0x1814F34E0")]
		public static Task<PlayFabResult<SearchItemsResponse>> SearchRecipeItemsAsync(this PlayFabEconomyInstanceAPI self, bool getAllLocalizedTexts = false)
		{
			//IL_002f: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			//IL_002f: Expected I4, but got I8
			//IL_002f: Expected O, but got I4
			int num = 0;
			string recipeTypeFilter = RecipeTypeFilter;
			string text = "startDate,endDate";
			if (getAllLocalizedTexts)
			{
				text = "startDate,endDate,title,description";
			}
			int num2 = 0;
			int num3 = 0;
			string text2 = default(string);
			ulong num4 = default(ulong);
			return (Task<PlayFabResult<SearchItemsResponse>>)(object)PlayfabEconomyExt.SearchItemsAsync(self, (string)num3, recipeTypeFilter, text, text2, (int)num4, (EntityKey)num2, (byte)num2 != 0, (Dictionary<, >)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x14F35E0", Offset = "0x14F1FE0", VA = "0x1814F35E0")]
		public static Task<PlayFabResult<SearchItemsResponse>> SearchStoreItemsAsync(this PlayFabEconomyInstanceAPI self, bool getAllLocalizedTexts = false)
		{
			//IL_002f: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			//IL_002f: Expected I4, but got I8
			//IL_002f: Expected O, but got I4
			int num = 0;
			string storeTypeFilter = StoreTypeFilter;
			string text = "startDate,endDate";
			if (getAllLocalizedTexts)
			{
				text = "startDate,endDate,title,description";
			}
			int num2 = 0;
			int num3 = 0;
			string text2 = default(string);
			ulong num4 = default(ulong);
			return (Task<PlayFabResult<SearchItemsResponse>>)(object)PlayfabEconomyExt.SearchItemsAsync(self, (string)num3, storeTypeFilter, text, text2, (int)num4, (EntityKey)num2, (byte)num2 != 0, (Dictionary<, >)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x14F29E0", Offset = "0x14F13E0", VA = "0x1814F29E0")]
		public static Task<PlayFabResult<SearchItemsResponse>> SearchActiveBundles(this PlayFabEconomyInstanceAPI self, ContentType contentType, [Optional] List<KnownEconomyItem> versionedItems)
		{
			//IL_0022: Expected O, but got I4
			int num = 0;
			string text = default(string);
			string text2 = BundleTypeFilter + " and " + text;
			int num2 = 0;
			return (Task<PlayFabResult<SearchItemsResponse>>)(object)PlayfabEconomyExt.SearchActiveEconomyItems(self, text2, (List<>)(object)versionedItems, (Dictionary<, >)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x14F2D00", Offset = "0x14F1700", VA = "0x1814F2D00")]
		public static Task<PlayFabResult<SearchItemsResponse>> SearchActiveStores(this PlayFabEconomyInstanceAPI self, ContentType contentType, [Optional] List<KnownEconomyItem> versionedItems)
		{
			//IL_0022: Expected O, but got I4
			int num = 0;
			string text = default(string);
			string text2 = StoreTypeFilter + " and " + text;
			int num2 = 0;
			return (Task<PlayFabResult<SearchItemsResponse>>)(object)PlayfabEconomyExt.SearchActiveEconomyItems(self, text2, (List<>)(object)versionedItems, (Dictionary<, >)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x14F2C30", Offset = "0x14F1630", VA = "0x1814F2C30")]
		public static Task<PlayFabResult<SearchItemsResponse>> SearchActiveMessages(this PlayFabEconomyInstanceAPI self, [Optional] List<KnownEconomyItem> versionedItems)
		{
			//IL_0013: Expected O, but got I4
			string text = ContentType.Global_MailboxMessage.ToFilter();
			int num = 0;
			return (Task<PlayFabResult<SearchItemsResponse>>)(object)PlayfabEconomyExt.SearchActiveEconomyItems(self, text, (List<>)(object)versionedItems, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x14F2910", Offset = "0x14F1310", VA = "0x1814F2910")]
		public static Task<PlayFabResult<SearchItemsResponse>> SearchActiveBattlePasses(this PlayFabEconomyInstanceAPI self, [Optional] Dictionary<string, string> extraHeaders)
		{
			//IL_0012: Expected O, but got I4
			string text = ContentType.Item_BattlePassBaseConfig.ToFilter();
			int num = 0;
			return (Task<PlayFabResult<SearchItemsResponse>>)(object)PlayfabEconomyExt.SearchActiveEconomyItems(self, text, (List<>)num, (Dictionary<, >)(object)extraHeaders);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x14F3A10", Offset = "0x14F2410", VA = "0x1814F3A10")]
		public static Task<PlayFabResult<SearchItemsResponse>> TEMP_SearchActiveMessages(this PlayFabEconomyInstanceAPI self, string highLevelTypeFilter, [Optional] List<KnownEconomyItem> versionedItems)
		{
			//IL_0020: Expected O, but got I4
			string text = ContentType.Global_MailboxMessage.ToFilter();
			string text2 = highLevelTypeFilter + " and " + text;
			int num = 0;
			return (Task<PlayFabResult<SearchItemsResponse>>)(object)PlayfabEconomyExt.SearchActiveEconomyItems(self, text2, (List<>)(object)versionedItems, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x14F2AD0", Offset = "0x14F14D0", VA = "0x1814F2AD0")]
		[AsyncStateMachine(typeof(_003CSearchActiveEconomyItems_003Ed__70))]
		private static Task<PlayFabResult<SearchItemsResponse>> SearchActiveEconomyItems(this PlayFabEconomyInstanceAPI self, string filter, List<KnownEconomyItem> versionedItems, [Optional] Dictionary<string, string> extraHeaders)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<SearchItemsResponse>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x14F36E0", Offset = "0x14F20E0", VA = "0x1814F36E0")]
		[AsyncStateMachine(typeof(_003CSearchTLE_003Ed__71))]
		public static Task<CatalogItem> SearchTLE(this PlayFabEconomyInstanceAPI self, string eventName, string gameVersion)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CatalogItem>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x14F24C0", Offset = "0x14F0EC0", VA = "0x1814F24C0")]
		public static string ItemFilterBy(this PlayFabEconomyInstanceAPI self, SearchField field, string value, [Optional] string extraFilter, SearchOperator searchOperator = SearchOperator.eq, SearchExtraFlags extraFlags = SearchExtraFlags.None)
		{
			//Discarded unreachable code: IL_0013
			new List<T>().Add((T)value);
			string itemsTypeFilter = ItemsTypeFilter;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x14F2600", Offset = "0x14F1000", VA = "0x1814F2600")]
		public static string ItemFilterBy(this PlayFabEconomyInstanceAPI self, SearchField field, IEnumerable<string> values, [Optional] string extraFilter, SearchOperator searchOperator = SearchOperator.eq, SearchExtraFlags extraFlags = SearchExtraFlags.None)
		{
			string itemsTypeFilter = ItemsTypeFilter;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x14F06E0", Offset = "0x14EF0E0", VA = "0x1814F06E0")]
		public static string CurrencyFilterBy(this PlayFabEconomyInstanceAPI self, SearchField field, string value, [Optional] string extraFilter, SearchOperator searchOperator = SearchOperator.eq, SearchExtraFlags extraFlags = SearchExtraFlags.None)
		{
			//Discarded unreachable code: IL_0015
			new List<T>().Add((T)value);
			int num = 0;
			string currencyTypeFilter = CurrencyTypeFilter;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x14F0820", Offset = "0x14EF220", VA = "0x1814F0820")]
		public static string CurrencyFilterBy(this PlayFabEconomyInstanceAPI self, SearchField field, IEnumerable<string> values, [Optional] string extraFilter, SearchOperator searchOperator = SearchOperator.eq, SearchExtraFlags extraFlags = SearchExtraFlags.None)
		{
			int num = 0;
			string currencyTypeFilter = CurrencyTypeFilter;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x14F0510", Offset = "0x14EEF10", VA = "0x1814F0510")]
		public static string BundleFilterBy(this PlayFabEconomyInstanceAPI self, SearchField field, string value, [Optional] string extraFilter, SearchOperator searchOperator = SearchOperator.eq, SearchExtraFlags extraFlags = SearchExtraFlags.None)
		{
			//Discarded unreachable code: IL_0015
			new List<T>().Add((T)value);
			int num = 0;
			string bundleTypeFilter = BundleTypeFilter;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x14F0650", Offset = "0x14EF050", VA = "0x1814F0650")]
		public static string BundleFilterBy(this PlayFabEconomyInstanceAPI self, SearchField field, IEnumerable<string> values, [Optional] string extraFilter, SearchOperator searchOperator = SearchOperator.eq, SearchExtraFlags extraFlags = SearchExtraFlags.None)
		{
			int num = 0;
			string bundleTypeFilter = BundleTypeFilter;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x14F2740", Offset = "0x14F1140", VA = "0x1814F2740")]
		public static string RecipeFilterBy(this PlayFabEconomyInstanceAPI self, SearchField field, string value, [Optional] string extraFilter, SearchOperator searchOperator = SearchOperator.eq, SearchExtraFlags extraFlags = SearchExtraFlags.None)
		{
			//Discarded unreachable code: IL_0015
			new List<T>().Add((T)value);
			int num = 0;
			string recipeTypeFilter = RecipeTypeFilter;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x14F2880", Offset = "0x14F1280", VA = "0x1814F2880")]
		public static string RecipeFilterBy(this PlayFabEconomyInstanceAPI self, SearchField field, IEnumerable<string> values, [Optional] string extraFilter, SearchOperator searchOperator = SearchOperator.eq, SearchExtraFlags extraFlags = SearchExtraFlags.None)
		{
			int num = 0;
			string recipeTypeFilter = RecipeTypeFilter;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x14F38D0", Offset = "0x14F22D0", VA = "0x1814F38D0")]
		public static string StoreFilterBy(this PlayFabEconomyInstanceAPI self, SearchField field, string value, [Optional] string extraFilter, SearchOperator searchOperator = SearchOperator.eq, SearchExtraFlags extraFlags = SearchExtraFlags.None)
		{
			//Discarded unreachable code: IL_0015
			new List<T>().Add((T)value);
			int num = 0;
			string storeTypeFilter = StoreTypeFilter;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x14F3840", Offset = "0x14F2240", VA = "0x1814F3840")]
		public static string StoreFilterBy(this PlayFabEconomyInstanceAPI self, SearchField field, IEnumerable<string> values, [Optional] string extraFilter, SearchOperator searchOperator = SearchOperator.eq, SearchExtraFlags extraFlags = SearchExtraFlags.None)
		{
			int num = 0;
			string storeTypeFilter = StoreTypeFilter;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x14F3D30", Offset = "0x14F2730", VA = "0x1814F3D30")]
		public static string UgcFilterByCreator(this PlayFabEconomyInstanceAPI self, Entity.Types creatorEntityType, string value, [Optional] string extraFilter, SearchOperator searchOperator = SearchOperator.eq, SearchExtraFlags extraFlags = SearchExtraFlags.None)
		{
			//Discarded unreachable code: IL_0046
			List<string> list = (List<string>)(object)new List<T>();
			((List<T>)(object)list).Add((T)value);
			Func<string, string> func = (Func<string, string>)(object)(Func<T, TResult>)delegate
			{
				PlayFabEconomyInstanceAPI playFabEconomyInstanceAPI = self;
				Entity.Types types = creatorEntityType;
				string result2 = default(string);
				return result2;
			};
			IEnumerable<string> enumerable = (IEnumerable<string>)Enumerable.Select<string, string>((IEnumerable<>)list, (Func<, >)(object)func);
			int num = 0;
			string ugcTypeFilter = UgcTypeFilter;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x14F3B90", Offset = "0x14F2590", VA = "0x1814F3B90")]
		public static string UgcFilterByCreator(this PlayFabEconomyInstanceAPI self, Entity.Types creatorEntityType, IEnumerable<string> values, [Optional] string extraFilter, SearchOperator searchOperator = SearchOperator.eq, SearchExtraFlags extraFlags = SearchExtraFlags.None)
		{
			//Discarded unreachable code: IL_0038
			Func<string, string> func = (Func<string, string>)(object)(Func<T, TResult>)delegate
			{
				PlayFabEconomyInstanceAPI playFabEconomyInstanceAPI = self;
				Entity.Types types = creatorEntityType;
				string result2 = default(string);
				return result2;
			};
			IEnumerable<string> enumerable = (IEnumerable<string>)Enumerable.Select<string, string>((IEnumerable<>)values, (Func<, >)(object)func);
			int num = 0;
			string ugcTypeFilter = UgcTypeFilter;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x14F3F60", Offset = "0x14F2960", VA = "0x1814F3F60")]
		public static string UgcFilterBy(this PlayFabEconomyInstanceAPI self, SearchField field, string value, [Optional] string extraFilter, SearchOperator searchOperator = SearchOperator.eq, SearchExtraFlags extraFlags = SearchExtraFlags.None)
		{
			//Discarded unreachable code: IL_0015
			new List<T>().Add((T)value);
			int num = 0;
			string ugcTypeFilter = UgcTypeFilter;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x14F40A0", Offset = "0x14F2AA0", VA = "0x1814F40A0")]
		public static string UgcFilterBy(this PlayFabEconomyInstanceAPI self, SearchField field, IEnumerable<string> values, [Optional] string extraFilter, SearchOperator searchOperator = SearchOperator.eq, SearchExtraFlags extraFlags = SearchExtraFlags.None)
		{
			int num = 0;
			string ugcTypeFilter = UgcTypeFilter;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x14F0190", Offset = "0x14EEB90", VA = "0x1814F0190")]
		public static string BasicFilterBy(this PlayFabEconomyInstanceAPI self, SearchField field, string value, [Optional] string extraFilter, SearchOperator searchOperator = SearchOperator.eq, SearchExtraFlags extraFlags = SearchExtraFlags.None)
		{
			//Discarded unreachable code: IL_000d
			new List<T>().Add((T)value);
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x14F02D0", Offset = "0x14EECD0", VA = "0x1814F02D0")]
		public static string BasicFilterBy(this PlayFabEconomyInstanceAPI self, SearchField field, IEnumerable<string> values, [Optional] string extraFilter, SearchOperator searchOperator = SearchOperator.eq, SearchExtraFlags extraFlags = SearchExtraFlags.None)
		{
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x14F0910", Offset = "0x14EF310", VA = "0x1814F0910")]
		private static string FilterBy(string filter, SearchField searchField, IEnumerable<string> values, [Optional] string extraFilter, SearchOperator searchOperator = SearchOperator.eq, SearchExtraFlags extraFlags = SearchExtraFlags.None)
		{
			//Discarded unreachable code: IL_0197
			//IL_011c: Expected O, but got I4
			//IL_0134: Expected O, but got I4
			string text = default(string);
			Func<string, bool> func = default(Func<string, bool>);
			bool result = default(bool);
			IEnumerable<string> enumerable;
			string text3;
			bool flag2 = default(bool);
			SearchOperator searchOperator2 = default(SearchOperator);
			SearchOperator searchOperator3 = default(SearchOperator);
			bool flag3 = default(bool);
			string text6 = default(string);
			while (true)
			{
				if (text == null)
				{
					string[] array = new string[5];
					if (filter != null && array == null)
					{
						continue;
					}
					array[0] = filter;
					if (" " != null && " " == null)
					{
						continue;
					}
					array[1] = " ";
					if (filter != null && " " == null)
					{
						continue;
					}
					array[2] = filter;
					if (" " != null && " " == null)
					{
						continue;
					}
					array[3] = " ";
					if (extraFilter != null && " " == null)
					{
						continue;
					}
					array[4] = extraFilter;
					string text2 = string.Concat(array);
				}
				if (values == null)
				{
					continue;
				}
				if (_003C_003Ec._003C_003E9__88_0 == null)
				{
					func = (Func<string, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((string x) => result));
				}
				enumerable = (IEnumerable<string>)Enumerable.Where<string>((IEnumerable<>)values, (Func<, >)(object)func);
				if (enumerable == null)
				{
					continue;
				}
				bool flag = Enumerable.Any<string>((IEnumerable<>)enumerable);
				if (flag)
				{
					if (!flag)
					{
					}
					int num = 0;
					text3 = filter + " " + "and" + " (";
					if (searchField == SearchField.alternateIds_any || searchField == SearchField.alternateIds_all)
					{
						break;
					}
					if (!flag2)
					{
					}
					Dictionary<SearchOperator, SearchOperator> inverseOperatorMappings = InverseOperatorMappings;
					Dictionary<SearchOperator, SearchOperator> inverseOperatorMappings2 = InverseOperatorMappings;
					string arg = string.Join($"' and {text} {searchOperator2} '", (IEnumerable<>)enumerable);
					string text4 = $" ({text} {searchOperator3} '{arg}')";
					string text5 = text3 + text4;
					if (flag3)
					{
						text6 = text5 + " or " + text + " eq null";
						break;
					}
				}
			}
			string arg2 = string.Join($"' or x/value {text6} '", (IEnumerable<>)enumerable);
			string text7 = $" ({text}(x: x/value {text6} '{arg2}'))";
			return string.Concat(text3 + text7, ")");
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x14F4130", Offset = "0x14F2B30", VA = "0x1814F4130")]
		static PlayfabEconomyExt()
		{
			//Discarded unreachable code: IL_001e, IL_0024, IL_002a, IL_0030, IL_0036, IL_003c, IL_0044
			//IL_000c: Expected O, but got I4
			//IL_000c: Expected O, but got I4
			SearchField searchField = default(SearchField);
			SearchType searchType = default(SearchType);
			ItemsTypeFilter = $"{searchField} eq '{searchType}'";
			Dictionary<SearchOperator, SearchOperator> dictionary = (Dictionary<SearchOperator, SearchOperator>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}
	}
}
