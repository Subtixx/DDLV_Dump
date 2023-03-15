using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Definitions.Rewards;
using Mdl.Systems;
using Meta;
using Meta.Online;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200083E")]
	public class FakeData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40030A5")]
		private List<string> _fakeVirtualPlayers = (List<string>)(object)new List<T>
		{
			(T)"Castet, Manea",
			(T)"Ayotte, Christian",
			(T)"Grenier, Marie-Lise",
			(T)"Relian, Slava",
			(T)"Llewellyn, Claire",
			(T)"Canzeri, Dominique",
			(T)"Despret, Remi",
			(T)"Ivanchenko, Andrey",
			(T)"Steven Walker",
			(T)"Beaulieu-Guillemette, Jonathan",
			(T)"Tetreault, Sophie",
			(T)"Forget, Justin",
			(T)"Dubray, Joel",
			(T)"Babinet,\u00a0Hippolyte",
			(T)"Kelly Walker",
			(T)"Gabaude, Alize",
			(T)"Desrosiers-Dorval, Felix",
			(T)"Joelle Landry",
			(T)"Marmen, Vincent",
			(T)"Poirier, Louis",
			(T)"Alexandre Charron",
			(T)"Prenoveau, Caroline",
			(T)"Costa, Murilo",
			(T)"Ricaldi, Lars",
			(T)"Falso, Umberto",
			(T)"Roux, Jean-Francois",
			(T)"Gagnon, David",
			(T)"Ghassemi, Amanalah",
			(T)"Han, Suk Joong",
			(T)"Valet, Louis",
			(T)"Arrondelle, Caroline",
			(T)"Puaud, Pierre Louis",
			(T)"Ikeda, Noa",
			(T)"Emily (Quynh) Phan",
			(T)"Park, Sehyun",
			(T)"Sisouk, Pamonh",
			(T)"Brand, Christophe",
			(T)"Venegas-Salgado,\u00a0Daniel-Enrique\u00a0",
			(T)"Ma, Jie",
			(T)"Samarskiy, Sergiy",
			(T)"Neves, Antonio",
			(T)"Recco, Kelly",
			(T)"Lee, Mihyun",
			(T)"Samarska, Anastasia",
			(T)"Cerlini, Gioia",
			(T)"Arens, Laura",
			(T)"Tremblay, Benoit",
			(T)"Marcheterre, Gabrielle",
			(T)"Han, Changgwon",
			(T)"Hardy, Thomas",
			(T)"Lee, Moonho",
			(T)"Catherine Verret",
			(T)"Frederic Poirier",
			(T)"Jomphe, Eric",
			(T)"Pauline Freche",
			(T)"Kim Derome",
			(T)"Sébastien Ménard",
			(T)"Jorge Peirano\u00a0",
			(T)"Philippe Beauchemin",
			(T)"Lachance-Robidoux, Dominic",
			(T)"St-Laurent, Shaun"
		};

		[Cpp2IlInjected.Token(Token = "0x40030A6")]
		private static FakeData _instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40030A7")]
		private bool _isLeaderboardInited;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40030A8")]
		private List<FakeDailyRewardProgress> _fakeDailyRewardProgresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40030A9")]
		private MegaEventData _megaEventData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40030AA")]
		private FakePurchaseHistory _fakeBundlePurchaseHistory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40030AB")]
		private FakeLeaderboardDataModel _fakeLeaderboardDataModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40030AC")]
		private int _numVisibleProducts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40030AD")]
		private Dictionary<ShopMenu.ShopMenuTabs, List<ShopProductModel>> _fakeProducts;

		[Cpp2IlInjected.Token(Token = "0x17000768")]
		public static FakeData Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6003465")]
			[Cpp2IlInjected.Address(RVA = "0x152E6F0", Offset = "0x152D0F0", VA = "0x18152E6F0")]
			get
			{
				FakeData instance = _instance;
				if (instance == null)
				{
					_instance = new FakeData();
				}
				return instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000769")]
		public List<FakeDailyRewardProgress> FakeDailyRewardProgresses
		{
			[Cpp2IlInjected.Token(Token = "0x6003466")]
			[Cpp2IlInjected.Address(RVA = "0x152E280", Offset = "0x152CC80", VA = "0x18152E280")]
			get
			{
				//IL_0018: Expected O, but got I4
				List<FakeDailyRewardProgress> fakeDailyRewardProgresses = _fakeDailyRewardProgresses;
				if (fakeDailyRewardProgresses == null)
				{
					int num = 0;
					JArray jArray = UILocalStorage.Get("fake_daily_rewards", (JArray)num);
					if (jArray != null)
					{
						List<FakeDailyRewardProgress> list = jArray.ToObject<List<FakeDailyRewardProgress>>();
					}
					_fakeDailyRewardProgresses = (List<FakeDailyRewardProgress>)(object)jArray;
					if (_fakeDailyRewardProgresses == null)
					{
						List<FakeDailyRewardProgress> list2 = (_fakeDailyRewardProgresses = (List<FakeDailyRewardProgress>)(object)new List<T>());
					}
				}
				return fakeDailyRewardProgresses;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700076A")]
		public MegaEventData MegaEventData
		{
			[Cpp2IlInjected.Token(Token = "0x6003467")]
			[Cpp2IlInjected.Address(RVA = "0x152E770", Offset = "0x152D170", VA = "0x18152E770")]
			get
			{
				if (SystemRoot.Instance.MetaClient.profile.player_.megaEventProgress_.IsActive)
				{
					MegaEventData megaEventData = _megaEventData;
					if (megaEventData == null)
					{
						ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
					}
					return megaEventData;
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700076B")]
		public FakePurchaseHistory FakeBundlePurchaseHistory
		{
			[Cpp2IlInjected.Token(Token = "0x6003468")]
			[Cpp2IlInjected.Address(RVA = "0x152E130", Offset = "0x152CB30", VA = "0x18152E130")]
			get
			{
				//Discarded unreachable code: IL_004e
				//IL_0018: Expected O, but got I4
				if ((long)_fakeBundlePurchaseHistory == 0)
				{
					int num = 0;
					JObject jObject = UILocalStorage.Get("fake_bundle_purchase_history", (JObject)num);
					if (jObject == null)
					{
						FakePurchaseHistory fakePurchaseHistory = new FakePurchaseHistory();
						List<KeyValuePair<int, DateTime>> list = (fakePurchaseHistory.PurchaseHistoryList = (List<KeyValuePair<int, DateTime>>)(object)new List<T>());
						_fakeBundlePurchaseHistory = fakePurchaseHistory;
					}
					FakePurchaseHistory fakePurchaseHistory2 = (_fakeBundlePurchaseHistory = jObject.ToObject<FakePurchaseHistory>());
				}
				return _fakeBundlePurchaseHistory;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700076C")]
		public FakeLeaderboardDataModel FakeLeaderboardData
		{
			[Cpp2IlInjected.Token(Token = "0x6003469")]
			[Cpp2IlInjected.Address(RVA = "0x152E390", Offset = "0x152CD90", VA = "0x18152E390")]
			get
			{
				//Discarded unreachable code: IL_0100
				//IL_006e: Expected O, but got I4
				//IL_008a: Expected O, but got I4
				if ((long)_fakeLeaderboardDataModel == 0)
				{
					MegaEventProgress megaEventProgress_ = SystemRoot.Instance.MetaClient.profile.player_.megaEventProgress_;
					if (megaEventProgress_.IsActive)
					{
						MegaEventData megaEventData = MegaEventData;
						Client client = default(Client);
						DateTime serverTime = client.ServerTime;
						DateTime _003CEndTime_003Ek__BackingField = megaEventProgress_.EndTime;
						DateTime _003CStartTime_003Ek__BackingField = megaEventProgress_.StartTime;
						MegaEventState state = megaEventData.GetState(serverTime, _003CStartTime_003Ek__BackingField, _003CEndTime_003Ek__BackingField);
						int num = 0;
						JObject jObject = UILocalStorage.Get("fake_event_leaderboard", (JObject)num);
						if (jObject == null)
						{
							CreateFakeTimeLimitedEvent();
							int num2 = 0;
							JObject jObject2 = UILocalStorage.Get("fake_event_leaderboard", (JObject)num2);
						}
						FakeLeaderboardDataModel fakeLeaderboardDataModel = (_fakeLeaderboardDataModel = jObject.ToObject<FakeLeaderboardDataModel>());
						FakeVirtualPlayerModel _003CPlayer_003Ek__BackingField = _fakeLeaderboardDataModel.FakePlayerRecord.Player;
						Client client2 = default(Client);
						string text = (_003CPlayer_003Ek__BackingField.Name = client2.profile.player_.name_);
						FakeVirtualPlayerModel _003CPlayer_003Ek__BackingField2 = _fakeLeaderboardDataModel.FakePlayerRecord.Player;
						Client client3 = default(Client);
						int num3 = (_003CPlayer_003Ek__BackingField2.Level = client3.profile.player_.level_);
					}
				}
				return _fakeLeaderboardDataModel;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600346A")]
		[Cpp2IlInjected.Address(RVA = "0x152CBF0", Offset = "0x152B5F0", VA = "0x18152CBF0")]
		public void InitFakeLeaderboard()
		{
			//Discarded unreachable code: IL_00dc
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField == null)
			{
				return;
			}
			Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
			if (metaClient == null || (long)metaClient.Dispatcher == 0)
			{
				return;
			}
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.PlayerXpGained value = OnPlayerXpGained;
			_003CDispatcher_003Ek__BackingField.OnPlayerXpGained -= value;
			MegaEventProgress megaEventProgress_ = SystemRoot.Instance.MetaClient.profile.player_.megaEventProgress_;
			if (megaEventProgress_.IsActive && !_isLeaderboardInited)
			{
				MegaEventData megaEventData = MegaEventData;
				Client client = default(Client);
				DateTime serverTime = client.ServerTime;
				DateTime _003CEndTime_003Ek__BackingField = megaEventProgress_.EndTime;
				DateTime _003CStartTime_003Ek__BackingField = megaEventProgress_.StartTime;
				if (megaEventData.GetState(serverTime, _003CStartTime_003Ek__BackingField, _003CEndTime_003Ek__BackingField) == MegaEventState.InProgress)
				{
					RefreshFakeLeaderboardRecords();
					Client client2 = default(Client);
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = client2.Dispatcher;
					ProfileEventDispatcher.PlayerXpGained value2 = OnPlayerXpGained;
					_003CDispatcher_003Ek__BackingField2.OnPlayerXpGained += value2;
					_isLeaderboardInited = true;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600346B")]
		[Cpp2IlInjected.Address(RVA = "0x152B5B0", Offset = "0x1529FB0", VA = "0x18152B5B0")]
		public FakeDailyRewardProgress GetFakeDailyRewardProgress(string name)
		{
			//Discarded unreachable code: IL_0092
			List<FakeDailyRewardProgress> fakeDailyRewardProgresses = (List<FakeDailyRewardProgress>)(object)this.get_FakeDailyRewardProgresses();
			Predicate<FakeDailyRewardProgress> predicate = (Predicate<FakeDailyRewardProgress>)(object)(Predicate<T>)delegate(FakeDailyRewardProgress x)
			{
				//Discarded unreachable code: IL_0014
				string b2 = name;
				return string.Equals(x.Name, b2);
			};
			if (((List<T>)(object)fakeDailyRewardProgresses).Find((Predicate<>)(object)predicate) == null)
			{
				List<FakeDailyRewardProgress> fakeDailyRewardProgresses2 = (List<FakeDailyRewardProgress>)(object)this.get_FakeDailyRewardProgresses();
				FakeDailyRewardProgress fakeDailyRewardProgress = new FakeDailyRewardProgress();
				DateTime dateTime = (fakeDailyRewardProgress.ExpireDate = DateTime.MinValue);
				DateTime dateTime2 = (fakeDailyRewardProgress.LastCollectionDate = DateTime.MinValue);
				string text = (fakeDailyRewardProgress.Name = name);
				((List<T>)(object)fakeDailyRewardProgresses2).Add((T)fakeDailyRewardProgress);
			}
			List<FakeDailyRewardProgress> fakeDailyRewardProgresses3 = (List<FakeDailyRewardProgress>)(object)this.get_FakeDailyRewardProgresses();
			Predicate<FakeDailyRewardProgress> predicate2 = (Predicate<FakeDailyRewardProgress>)(object)(Predicate<T>)delegate(FakeDailyRewardProgress x)
			{
				//Discarded unreachable code: IL_0014
				string b = name;
				return string.Equals(x.Name, b);
			};
			return (FakeDailyRewardProgress)((List<T>)(object)fakeDailyRewardProgresses3).Find((Predicate<>)(object)predicate2);
		}

		[Cpp2IlInjected.Token(Token = "0x600346C")]
		[Cpp2IlInjected.Address(RVA = "0x152D670", Offset = "0x152C070", VA = "0x18152D670")]
		public void SaveFakeBundlePurchaseHistory()
		{
			JToken value = JToken.FromObject(FakeBundlePurchaseHistory);
			UILocalStorage.Set("fake_bundle_purchase_history", value);
		}

		[Cpp2IlInjected.Token(Token = "0x600346D")]
		[Cpp2IlInjected.Address(RVA = "0x152D720", Offset = "0x152C120", VA = "0x18152D720")]
		public void SaveFakeDailyRewardProgress()
		{
			JToken value = JToken.FromObject(this.get_FakeDailyRewardProgresses());
			UILocalStorage.Set("fake_daily_rewards", value);
		}

		[Cpp2IlInjected.Token(Token = "0x600346E")]
		[Cpp2IlInjected.Address(RVA = "0x152D530", Offset = "0x152BF30", VA = "0x18152D530")]
		public void ResetFakeProgress()
		{
			JToken value = JToken.FromObject(_fakeDailyRewardProgresses = (List<FakeDailyRewardProgress>)(object)new List<T>());
			UILocalStorage.Set("fake_daily_rewards", value);
			JToken value2 = JToken.FromObject(new FakePurchaseHistory());
			UILocalStorage.Set("fake_bundle_purchase_history", value2);
		}

		[Cpp2IlInjected.Token(Token = "0x600346F")]
		[Cpp2IlInjected.Address(RVA = "0x152CFD0", Offset = "0x152B9D0", VA = "0x18152CFD0")]
		public void RefreshFakeLeaderboardRecords()
		{
			//Discarded unreachable code: IL_0111, IL_0117, IL_011d, IL_0123, IL_0129, IL_012f
			int num = 0;
			MegaEventProgress megaEventProgress_ = SystemRoot.Instance.MetaClient.profile.player_.megaEventProgress_;
			DateTime _003CStartTime_003Ek__BackingField = megaEventProgress_.StartTime;
			DateTime _003CEndTime_003Ek__BackingField = megaEventProgress_.EndTime;
			DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
			if (megaEventProgress_.IsActive && MegaEventData.GetState(serverTime, _003CStartTime_003Ek__BackingField, _003CEndTime_003Ek__BackingField) == MegaEventState.InProgress)
			{
				if (_fakeLeaderboardDataModel == null)
				{
					FakeLeaderboardDataModel fakeLeaderboardDataModel = (_fakeLeaderboardDataModel = FakeLeaderboardData);
					FakeLeaderboardDataModel fakeLeaderboardDataModel2 = _fakeLeaderboardDataModel;
				}
				TimeSpan timeSpan = _003CEndTime_003Ek__BackingField - serverTime;
				TimeSpan timeSpan2 = MegaEventData.EventDuration(_003CStartTime_003Ek__BackingField, _003CEndTime_003Ek__BackingField);
				List<FakeLeaderboardRecordModel> _003CFakeRecords_003Ek__BackingField = _fakeLeaderboardDataModel.FakeRecords;
				bool flag = default(bool);
				if (flag)
				{
					float num2 = UnityEngine.Random.Range(0.9f, 1f);
					ulong dateData = serverTime.dateData;
					float num3 = UnityEngine.Random.Range(0.75f, 0.9f);
					ulong dateData2 = serverTime.dateData;
					float num4 = UnityEngine.Random.Range(0.5f, 0.7f);
					ulong dateData3 = serverTime.dateData;
					float num5 = UnityEngine.Random.Range(0.15f, 0.4f);
					ulong dateData4 = serverTime.dateData;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003470")]
		[Cpp2IlInjected.Address(RVA = "0x1526C50", Offset = "0x1525650", VA = "0x181526C50")]
		public void Destroy()
		{
			//Discarded unreachable code: IL_0099
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.PlayerXpGained value = OnPlayerXpGained;
					_003CDispatcher_003Ek__BackingField.OnPlayerXpGained -= value;
				}
			}
			JToken value2 = JToken.FromObject(FakeBundlePurchaseHistory);
			UILocalStorage.Set("fake_bundle_purchase_history", value2);
			JToken value3 = JToken.FromObject(this.get_FakeDailyRewardProgresses());
			UILocalStorage.Set("fake_daily_rewards", value3);
			FakeLeaderboardDataModel fakeLeaderboardDataModel = _fakeLeaderboardDataModel;
			if (fakeLeaderboardDataModel != null)
			{
				JToken value4 = JToken.FromObject(fakeLeaderboardDataModel);
				UILocalStorage.Set("fake_event_leaderboard", value4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003471")]
		[Cpp2IlInjected.Address(RVA = "0x152CF80", Offset = "0x152B980", VA = "0x18152CF80")]
		private void OnPlayerXpGained(int gained, int oldLevel, int newLevel, FriendshipSource friendshipSource)
		{
			//Discarded unreachable code: IL_0016
			if (FakeLeaderboardData != null)
			{
				FakeLeaderboardRecordModel _003CFakePlayerRecord_003Ek__BackingField = _fakeLeaderboardDataModel.FakePlayerRecord;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003472")]
		[Cpp2IlInjected.Address(RVA = "0x152D7D0", Offset = "0x152C1D0", VA = "0x18152D7D0")]
		public void SaveFakeLeaderboard()
		{
			FakeLeaderboardDataModel fakeLeaderboardDataModel = _fakeLeaderboardDataModel;
			if (fakeLeaderboardDataModel != null)
			{
				JToken value = JToken.FromObject(fakeLeaderboardDataModel);
				UILocalStorage.Set("fake_event_leaderboard", value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003473")]
		[Cpp2IlInjected.Address(RVA = "0x1526520", Offset = "0x1524F20", VA = "0x181526520")]
		public void CreateFakeTimeLimitedEvent()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003474")]
		[Cpp2IlInjected.Address(RVA = "0x152B7F0", Offset = "0x152A1F0", VA = "0x18152B7F0")]
		public List<ShopProductModel> GetFakeEventShop()
		{
			//Discarded unreachable code: IL_0376
			//IL_0021: Expected I4, but got I8
			//IL_003b: Expected I4, but got O
			//IL_005e: Expected I4, but got I8
			//IL_0079: Expected I4, but got O
			//IL_011b: Expected I4, but got I8
			//IL_0126: Expected I4, but got I8
			//IL_0132: Expected O, but got I4
			//IL_0154: Expected I4, but got I8
			//IL_027c: Expected I4, but got I8
			//IL_02ec: Expected I4, but got I8
			//IL_032e: Expected F4, but got I4
			//IL_036c: Expected I4, but got I8
			int num = 0;
			List<ShopProductModel> list = (List<ShopProductModel>)(object)new List<T>();
			List<FakeShopProductUnlockCondition> list2 = (List<FakeShopProductUnlockCondition>)(object)new List<T>();
			FakeShopProductUnlockCondition fakeShopProductUnlockCondition = new FakeShopProductUnlockCondition();
			fakeShopProductUnlockCondition.ConditionType = FakeShopProductUnlockCondition.Type.UnlockCharacter;
			Item item = ItemDatabase.Instance.GetItem(ItemType.Character, "Mickey!Goofy");
			fakeShopProductUnlockCondition.ConditionValue = (int)item;
			fakeShopProductUnlockCondition.IsPreviewAvailable = (byte)num != 0;
			((List<T>)(object)list2).Add((T)fakeShopProductUnlockCondition);
			FakeShopProductUnlockCondition fakeShopProductUnlockCondition2 = new FakeShopProductUnlockCondition();
			fakeShopProductUnlockCondition2.ConditionType = FakeShopProductUnlockCondition.Type.LockCharacter;
			Item item2 = ItemDatabase.Instance.GetItem(ItemType.Character, "Mickey!Donald");
			fakeShopProductUnlockCondition2.ConditionValue = (int)item2;
			fakeShopProductUnlockCondition2.IsPreviewAvailable = (byte)num != 0;
			((List<T>)(object)list2).Add((T)fakeShopProductUnlockCondition2);
			DateTime localTime = SystemRoot.Instance.MetaClient.LocalTime;
			FakeShopProductModel fakeShopProductModel = new FakeShopProductModel();
			fakeShopProductModel.FakeImageAddress = "shop_icon_currency_hard_1";
			fakeShopProductModel.FakeTitle = "Gems 1";
			fakeShopProductModel.FakeDesc = "Desc";
			List<ItemReward> list3 = (List<ItemReward>)(object)new List<T>();
			int num2 = 0;
			int itemID = CurrencyItem.HardCurrencyItem.ItemID;
			ItemReward item3 = default(ItemReward);
			((List<T>)(object)list3).Add((T)item3);
			fakeShopProductModel.FakeItemRewards = list3;
			fakeShopProductModel.FakeIsRealMoney = true;
			fakeShopProductModel.FakePriceAmount = 9.99f;
			fakeShopProductModel.FakeReplacedPriceAmount = 19.99f;
			fakeShopProductModel.FakeAmount = 150;
			fakeShopProductModel.FakeReplacedAmount = 100;
			int num3 = 0;
			fakeShopProductModel.FakeExpireDate = (DateTime?)(object)num3;
			fakeShopProductModel.FakeRealMoneyCurrencySymbol = "$";
			fakeShopProductModel.FakeRealMoneyCurrencyName = "CAD";
			((ShopProductModel)fakeShopProductModel).Tab = ShopMenu.ShopMenuTabs.Gem;
			((List<T>)(object)list).Add((T)fakeShopProductModel);
			List<ItemReward> list4 = (List<ItemReward>)(object)new List<T>();
			int itemID2 = ItemDatabase.Instance.GetItem(ItemType.Character, "Mickey!Donald").ItemID;
			ItemReward item4 = default(ItemReward);
			((List<T>)(object)list4).Add((T)item4);
			int itemID3 = ItemDatabase.Instance.GetItem(ItemType.Furniture, "03_WallE!Set02!Planter01").ItemID;
			ItemReward item5 = default(ItemReward);
			((List<T>)(object)list4).Add((T)item5);
			int num4 = 0;
			int itemID4 = CurrencyItem.HardCurrencyItem.ItemID;
			ItemReward item6 = default(ItemReward);
			((List<T>)(object)list4).Add((T)item6);
			int num5 = 0;
			int itemID5 = CurrencyItem.SoftCurrencyItem.ItemID;
			ItemReward item7 = default(ItemReward);
			((List<T>)(object)list4).Add((T)item7);
			FakeShopProductModel fakeShopProductModel2 = new FakeShopProductModel();
			fakeShopProductModel2.FakeImageAddress = "shop_character_placeholder";
			fakeShopProductModel2.FakeTitle = "Welcome Donald";
			fakeShopProductModel2.FakeDesc = "Welcome Donald to your village";
			fakeShopProductModel2.FeaturedTag = "Welcome<br><size=150%>Donald";
			fakeShopProductModel2.FakeItemRewards = list4;
			fakeShopProductModel2.FakeIsRealMoney = true;
			fakeShopProductModel2.FakeUseBgGradient = true;
			int num6 = 0;
			fakeShopProductModel2.FakeBgOffsetY = 60f;
			fakeShopProductModel2.FakeIsBgFlipped = true;
			fakeShopProductModel2.FakePriceAmount = 9.99f;
			fakeShopProductModel2.FakeReplacedPriceAmount = 19.99f;
			fakeShopProductModel2.FakeRealMoneyCurrencySymbol = "$";
			fakeShopProductModel2.FakeRealMoneyCurrencyName = "USD";
			fakeShopProductModel2.FakeConditions = list2;
			((ShopProductModel)fakeShopProductModel2).Tab = ShopMenu.ShopMenuTabs.Bundle;
			((List<T>)(object)list).Add((T)fakeShopProductModel2);
			FakeDailyRewardProgress fakeDailyRewardProgress = GetFakeDailyRewardProgress("Event Gem");
			DateTime dateTime = default(DateTime);
			if (fakeDailyRewardProgress.ExpireDate < dateTime)
			{
				int num7 = 0;
				DateTime _003CExpireDate_003Ek__BackingField = default(DateTime);
				fakeDailyRewardProgress.ExpireDate = _003CExpireDate_003Ek__BackingField;
			}
			FakeShopProductModel fakeShopProductModel3 = new FakeShopProductModel();
			fakeShopProductModel3.FakeImageAddress = "shop_icon_currency_hard_3";
			fakeShopProductModel3.FakeTitle = "Event Gem";
			fakeShopProductModel3.FakeDesc = "Collect free Gems every day for 7 days";
			fakeShopProductModel3.FakeIsDaily = true;
			fakeShopProductModel3.FakeDailyDaysPerPurchase = 30;
			FakeDailyRewardProgress fakeDailyRewardProgress2 = (fakeShopProductModel3.FakeDailyRewardProgress = GetFakeDailyRewardProgress("Daily Gem"));
			int num8 = 0;
			int itemID6 = CurrencyItem.HardCurrencyItem.ItemID;
			ItemReward fakeDailyReward = default(ItemReward);
			fakeShopProductModel3.FakeDailyReward = fakeDailyReward;
			fakeShopProductModel3.FeaturedTag = "3x VALUE";
			fakeShopProductModel3.FakeBgOffsetY = num;
			fakeShopProductModel3.FakeUseBgGradient = true;
			fakeShopProductModel3.FakeIsRealMoney = true;
			fakeShopProductModel3.FakePriceAmount = 32.99f;
			fakeShopProductModel3.FakeRealMoneyCurrencySymbol = "$";
			fakeShopProductModel3.FakeRealMoneyCurrencyName = "USD";
			((ShopProductModel)fakeShopProductModel3).Tab = ShopMenu.ShopMenuTabs.Bundle;
			((List<T>)(object)list).Add((T)fakeShopProductModel3);
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6003475")]
		[Cpp2IlInjected.Address(RVA = "0x152C330", Offset = "0x152AD30", VA = "0x18152C330")]
		public Dictionary<ShopMenu.ShopMenuTabs, List<ShopProductModel>> GetFakeShopData(bool visibleOnly)
		{
			//Discarded unreachable code: IL_0040, IL_0055, IL_006a, IL_007f, IL_0094, IL_014f, IL_0155
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Dictionary<ShopMenu.ShopMenuTabs, List<ShopProductModel>> fakeProducts = _fakeProducts;
			if (fakeProducts == null)
			{
				Dictionary<ShopMenu.ShopMenuTabs, List<ShopProductModel>> dictionary = (_fakeProducts = (Dictionary<ShopMenu.ShopMenuTabs, List<ShopProductModel>>)(object)new Dictionary<TKey, TValue>());
				Dictionary<ShopMenu.ShopMenuTabs, List<ShopProductModel>> fakeProducts2 = _fakeProducts;
				List<ShopProductModel> list = (List<ShopProductModel>)(object)new List<T>();
				throw new NullReferenceException();
			}
			Func<KeyValuePair<ShopMenu.ShopMenuTabs, List<ShopProductModel>>, ShopMenu.ShopMenuTabs> func = default(Func<KeyValuePair<ShopMenu.ShopMenuTabs, List<ShopProductModel>>, ShopMenu.ShopMenuTabs>);
			if (_003C_003Ec._003C_003E9__30_0 == null)
			{
				func = (Func<KeyValuePair<ShopMenu.ShopMenuTabs, List<ShopProductModel>>, ShopMenu.ShopMenuTabs>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			Func<KeyValuePair<ShopMenu.ShopMenuTabs, List<ShopProductModel>>, List<ShopProductModel>> func2 = default(Func<KeyValuePair<ShopMenu.ShopMenuTabs, List<ShopProductModel>>, List<ShopProductModel>>);
			if (_003C_003Ec._003C_003E9__30_1 == null)
			{
				func2 = (Func<KeyValuePair<ShopMenu.ShopMenuTabs, List<ShopProductModel>>, List<ShopProductModel>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			Dictionary<ShopMenu.ShopMenuTabs, KeyValuePair<ShopMenu.ShopMenuTabs, List<ShopProductModel>>> dictionary2 = (Dictionary<ShopMenu.ShopMenuTabs, KeyValuePair<ShopMenu.ShopMenuTabs, List<ShopProductModel>>>)(object)Enumerable.ToDictionary<KeyValuePair<ShopMenu.ShopMenuTabs, List<ShopProductModel>>, ShopMenu.ShopMenuTabs, List<ShopProductModel>>((IEnumerable<>)fakeProducts, (Func<, >)(object)func, (Func<, >)(object)func2);
			int numVisibleProducts = num3;
			Dictionary<ShopMenu.ShopMenuTabs, KeyValuePair<ShopMenu.ShopMenuTabs, List<ShopProductModel>>>.ValueCollection values = (Dictionary<ShopMenu.ShopMenuTabs, KeyValuePair<ShopMenu.ShopMenuTabs, List<ShopProductModel>>>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)dictionary2).get_Values();
			bool flag = default(bool);
			Predicate<ShopProductModel> predicate = default(Predicate<ShopProductModel>);
			if (flag && predicate == null)
			{
				predicate = (Predicate<ShopProductModel>)(object)(Predicate<T>)delegate(ShopProductModel x)
				{
					if (x != null)
					{
						int num7 = 0;
						bool flag2 = default(bool);
						if (x != null && !flag2)
						{
						}
					}
					return true;
				};
			}
			int num4 = default(int);
			if (num4 > 0)
			{
				int num5 = numVisibleProducts;
				if (num4 < num5)
				{
					int num6 = 0;
					UiRoot.Instance.RedDotHelper.OnNewShopProductAdded();
				}
			}
			return (Dictionary<ShopMenu.ShopMenuTabs, List<ShopProductModel>>)(object)dictionary2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003476")]
		[Cpp2IlInjected.Address(RVA = "0x152CA80", Offset = "0x152B480", VA = "0x18152CA80")]
		public bool HasAnyFreeGacha()
		{
			//Discarded unreachable code: IL_002f
			//IL_0007: Expected I4, but got I8
			ulong num = default(ulong);
			Dictionary<ShopMenu.ShopMenuTabs, List<ShopProductModel>> fakeShopData = (Dictionary<ShopMenu.ShopMenuTabs, List<ShopProductModel>>)(object)this.GetFakeShopData((byte)num != 0);
			Func<ShopProductModel, bool> _003C_003E9__31_ = _003C_003Ec._003C_003E9__31_0;
			if (_003C_003E9__31_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ShopProductModel x)
				{
					if (x != null)
					{
						int num2 = 0;
						if (x != null)
						{
							int num3 = 0;
							if (x == null)
							{
								throw new InvalidCastException();
							}
							int num4 = 0;
							int num5 = default(int);
							if (x != null)
							{
								return num5 > 0;
							}
							goto IL_001e;
						}
					}
					int num6 = 0;
					goto IL_001e;
					IL_001e:
					throw new InvalidCastException();
				};
			}
			List<ShopProductModel> cpp2il__autoParamName__idx_ = default(List<ShopProductModel>);
			return ((IEnumerable<>)cpp2il__autoParamName__idx_).Any<ShopProductModel>((Func<, >)(object)_003C_003E9__31_);
		}

		[Cpp2IlInjected.Token(Token = "0x6003477")]
		[Cpp2IlInjected.Address(RVA = "0x152C910", Offset = "0x152B310", VA = "0x18152C910")]
		public bool HasAnyFreeDailyReward()
		{
			//Discarded unreachable code: IL_002f
			//IL_0007: Expected I4, but got I8
			ulong num = default(ulong);
			Dictionary<ShopMenu.ShopMenuTabs, List<ShopProductModel>> fakeShopData = (Dictionary<ShopMenu.ShopMenuTabs, List<ShopProductModel>>)(object)this.GetFakeShopData((byte)num != 0);
			Func<ShopProductModel, bool> _003C_003E9__32_ = _003C_003Ec._003C_003E9__32_0;
			if (_003C_003E9__32_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ShopProductModel x)
				{
					if (x != null)
					{
						int num2 = 0;
						if (x != null)
						{
							int num3 = 0;
							if (x != null)
							{
								int num4 = 0;
								if (x != null)
								{
									int num5 = default(int);
									if (num5 <= 0)
									{
										goto IL_002e;
									}
									int num6 = 0;
									if (x != null)
									{
										int num7 = 0;
										int num8 = default(int);
										if (x != null)
										{
											return num8 > 0;
										}
										goto IL_0031;
									}
								}
							}
							throw new InvalidCastException();
						}
					}
					goto IL_002e;
					IL_002e:
					int num9 = 0;
					goto IL_0031;
					IL_0031:
					throw new InvalidCastException();
				};
			}
			List<ShopProductModel> cpp2il__autoParamName__idx_ = default(List<ShopProductModel>);
			return ((IEnumerable<>)cpp2il__autoParamName__idx_).Any<ShopProductModel>((Func<, >)(object)_003C_003E9__32_);
		}

		[Cpp2IlInjected.Token(Token = "0x6003478")]
		[Cpp2IlInjected.Address(RVA = "0x1526FF0", Offset = "0x15259F0", VA = "0x181526FF0")]
		private void GenerateFakeShopData(Dictionary<ShopMenu.ShopMenuTabs, List<ShopProductModel>> products)
		{
			//IL_0025: Expected I4, but got I8
			//IL_002f: Expected I4, but got I8
			//IL_0054: Expected I4, but got I8
			//IL_005f: Expected I4, but got I8
			//IL_0087: Expected I4, but got I8
			//IL_0091: Expected I4, but got I8
			//IL_00b4: Expected I4, but got I8
			//IL_00bf: Expected I4, but got I8
			//IL_00e9: Expected I4, but got I8
			//IL_00f4: Expected I4, but got I8
			//IL_0117: Expected I4, but got I8
			//IL_0121: Expected I4, but got I8
			//IL_014a: Expected I4, but got I8
			//IL_0177: Expected I4, but got I8
			//IL_0192: Expected I4, but got O
			//IL_01b8: Expected I4, but got I8
			//IL_01d3: Expected I4, but got O
			//IL_0200: Expected I4, but got I8
			//IL_020a: Expected I4, but got I8
			//IL_0237: Expected I4, but got I8
			//IL_0252: Expected I4, but got O
			//IL_0278: Expected I4, but got I8
			//IL_0293: Expected I4, but got O
			//IL_02c0: Expected I4, but got I8
			//IL_02db: Expected I4, but got O
			//IL_0301: Expected I4, but got I8
			//IL_031c: Expected I4, but got O
			//IL_0349: Expected I4, but got I8
			//IL_0364: Expected I4, but got O
			//IL_038a: Expected I4, but got I8
			//IL_03a5: Expected I4, but got O
			//IL_03be: Expected O, but got I4
			//IL_0435: Expected I4, but got I8
			//IL_0457: Expected I4, but got I8
			//IL_04d5: Expected I4, but got I8
			DateTime localTime = SystemRoot.Instance.MetaClient.LocalTime;
			List<FakeShopProductUnlockCondition> list = (List<FakeShopProductUnlockCondition>)(object)new List<T>();
			FakeShopProductUnlockCondition fakeShopProductUnlockCondition = new FakeShopProductUnlockCondition();
			fakeShopProductUnlockCondition.ConditionType = FakeShopProductUnlockCondition.Type.PlayerLevel;
			fakeShopProductUnlockCondition.ConditionValue = 99;
			fakeShopProductUnlockCondition.IsPreviewAvailable = true;
			((List<T>)(object)list).Add((T)fakeShopProductUnlockCondition);
			List<FakeShopProductUnlockCondition> list2 = (List<FakeShopProductUnlockCondition>)(object)new List<T>();
			FakeShopProductUnlockCondition fakeShopProductUnlockCondition2 = new FakeShopProductUnlockCondition();
			fakeShopProductUnlockCondition2.ConditionType = FakeShopProductUnlockCondition.Type.FriendCount;
			fakeShopProductUnlockCondition2.ConditionValue = 99;
			fakeShopProductUnlockCondition2.IsPreviewAvailable = true;
			((List<T>)(object)list2).Add((T)fakeShopProductUnlockCondition2);
			List<FakeShopProductUnlockCondition> list3 = (List<FakeShopProductUnlockCondition>)(object)new List<T>();
			FakeShopProductUnlockCondition fakeShopProductUnlockCondition3 = new FakeShopProductUnlockCondition();
			fakeShopProductUnlockCondition3.ConditionType = FakeShopProductUnlockCondition.Type.DayOfWeek;
			fakeShopProductUnlockCondition3.ConditionValue = 5;
			fakeShopProductUnlockCondition3.IsPreviewAvailable = true;
			((List<T>)(object)list3).Add((T)fakeShopProductUnlockCondition3);
			FakeShopProductUnlockCondition fakeShopProductUnlockCondition4 = new FakeShopProductUnlockCondition();
			fakeShopProductUnlockCondition4.ConditionType = FakeShopProductUnlockCondition.Type.DayOfMonth;
			fakeShopProductUnlockCondition4.ConditionValue = 13;
			fakeShopProductUnlockCondition4.IsPreviewAvailable = true;
			((List<T>)(object)list3).Add((T)fakeShopProductUnlockCondition4);
			List<FakeShopProductUnlockCondition> list4 = (List<FakeShopProductUnlockCondition>)(object)new List<T>();
			FakeShopProductUnlockCondition fakeShopProductUnlockCondition5 = new FakeShopProductUnlockCondition();
			fakeShopProductUnlockCondition5.ConditionType = FakeShopProductUnlockCondition.Type.DayOfMonth;
			fakeShopProductUnlockCondition5.ConditionValue = 14;
			fakeShopProductUnlockCondition5.IsPreviewAvailable = true;
			((List<T>)(object)list4).Add((T)fakeShopProductUnlockCondition5);
			FakeShopProductUnlockCondition fakeShopProductUnlockCondition6 = new FakeShopProductUnlockCondition();
			fakeShopProductUnlockCondition6.ConditionType = FakeShopProductUnlockCondition.Type.MonthOfYear;
			fakeShopProductUnlockCondition6.ConditionValue = 2;
			fakeShopProductUnlockCondition6.IsPreviewAvailable = true;
			((List<T>)(object)list4).Add((T)fakeShopProductUnlockCondition6);
			List<FakeShopProductUnlockCondition> list5 = (List<FakeShopProductUnlockCondition>)(object)new List<T>();
			FakeShopProductUnlockCondition fakeShopProductUnlockCondition7 = new FakeShopProductUnlockCondition();
			fakeShopProductUnlockCondition7.ConditionType = FakeShopProductUnlockCondition.Type.Hour;
			fakeShopProductUnlockCondition7.IsPreviewAvailable = true;
			((List<T>)(object)list5).Add((T)fakeShopProductUnlockCondition7);
			List<FakeShopProductUnlockCondition> list6 = (List<FakeShopProductUnlockCondition>)(object)new List<T>();
			FakeShopProductUnlockCondition fakeShopProductUnlockCondition8 = new FakeShopProductUnlockCondition();
			fakeShopProductUnlockCondition8.ConditionType = FakeShopProductUnlockCondition.Type.UnlockCharacter;
			Item item = ItemDatabase.Instance.GetItem(ItemType.Character, "WallE!WallE");
			fakeShopProductUnlockCondition8.ConditionValue = (int)item;
			fakeShopProductUnlockCondition8.IsPreviewAvailable = false;
			((List<T>)(object)list6).Add((T)fakeShopProductUnlockCondition8);
			FakeShopProductUnlockCondition fakeShopProductUnlockCondition9 = new FakeShopProductUnlockCondition();
			fakeShopProductUnlockCondition9.ConditionType = FakeShopProductUnlockCondition.Type.LockCharacter;
			Item item2 = ItemDatabase.Instance.GetItem(ItemType.Character, "WallE!EVE");
			fakeShopProductUnlockCondition9.ConditionValue = (int)item2;
			fakeShopProductUnlockCondition9.IsPreviewAvailable = false;
			((List<T>)(object)list6).Add((T)fakeShopProductUnlockCondition9);
			List<FakeShopProductUnlockCondition> list7 = (List<FakeShopProductUnlockCondition>)(object)new List<T>();
			FakeShopProductUnlockCondition fakeShopProductUnlockCondition10 = new FakeShopProductUnlockCondition();
			fakeShopProductUnlockCondition10.ConditionType = FakeShopProductUnlockCondition.Type.PurchaseCount;
			fakeShopProductUnlockCondition10.ConditionValue = 1;
			fakeShopProductUnlockCondition10.IsPreviewAvailable = false;
			((List<T>)(object)list7).Add((T)fakeShopProductUnlockCondition10);
			List<FakeShopProductUnlockCondition> list8 = (List<FakeShopProductUnlockCondition>)(object)new List<T>();
			FakeShopProductUnlockCondition fakeShopProductUnlockCondition11 = new FakeShopProductUnlockCondition();
			fakeShopProductUnlockCondition11.ConditionType = FakeShopProductUnlockCondition.Type.UnlockCharacter;
			Item item3 = ItemDatabase.Instance.GetItem(ItemType.Character, "BeautyBeast!Belle");
			fakeShopProductUnlockCondition11.ConditionValue = (int)item3;
			fakeShopProductUnlockCondition11.IsPreviewAvailable = false;
			((List<T>)(object)list8).Add((T)fakeShopProductUnlockCondition11);
			FakeShopProductUnlockCondition fakeShopProductUnlockCondition12 = new FakeShopProductUnlockCondition();
			fakeShopProductUnlockCondition12.ConditionType = FakeShopProductUnlockCondition.Type.LockCharacter;
			Item item4 = ItemDatabase.Instance.GetItem(ItemType.Character, "BeautyBeast!Gaston");
			fakeShopProductUnlockCondition12.ConditionValue = (int)item4;
			fakeShopProductUnlockCondition12.IsPreviewAvailable = false;
			((List<T>)(object)list8).Add((T)fakeShopProductUnlockCondition12);
			List<FakeShopProductUnlockCondition> list9 = (List<FakeShopProductUnlockCondition>)(object)new List<T>();
			FakeShopProductUnlockCondition fakeShopProductUnlockCondition13 = new FakeShopProductUnlockCondition();
			fakeShopProductUnlockCondition13.ConditionType = FakeShopProductUnlockCondition.Type.UnlockCharacter;
			Item item5 = ItemDatabase.Instance.GetItem(ItemType.Character, "ToyStory!Buzz");
			fakeShopProductUnlockCondition13.ConditionValue = (int)item5;
			fakeShopProductUnlockCondition13.IsPreviewAvailable = false;
			((List<T>)(object)list9).Add((T)fakeShopProductUnlockCondition13);
			FakeShopProductUnlockCondition fakeShopProductUnlockCondition14 = new FakeShopProductUnlockCondition();
			fakeShopProductUnlockCondition14.ConditionType = FakeShopProductUnlockCondition.Type.LockCharacter;
			Item item6 = ItemDatabase.Instance.GetItem(ItemType.Character, "ToyStory!BoPeep");
			fakeShopProductUnlockCondition14.ConditionValue = (int)item6;
			fakeShopProductUnlockCondition14.IsPreviewAvailable = false;
			((List<T>)(object)list9).Add((T)fakeShopProductUnlockCondition14);
			List<FakeShopProductUnlockCondition> list10 = (List<FakeShopProductUnlockCondition>)(object)new List<T>();
			FakeShopProductUnlockCondition fakeShopProductUnlockCondition15 = new FakeShopProductUnlockCondition();
			fakeShopProductUnlockCondition15.ConditionType = FakeShopProductUnlockCondition.Type.UnlockCharacter;
			Item item7 = ItemDatabase.Instance.GetItem(ItemType.Character, "Frozen!Elsa");
			fakeShopProductUnlockCondition15.ConditionValue = (int)item7;
			fakeShopProductUnlockCondition15.IsPreviewAvailable = false;
			((List<T>)(object)list10).Add((T)fakeShopProductUnlockCondition15);
			FakeShopProductUnlockCondition fakeShopProductUnlockCondition16 = new FakeShopProductUnlockCondition();
			fakeShopProductUnlockCondition16.ConditionType = FakeShopProductUnlockCondition.Type.LockCharacter;
			Item item8 = ItemDatabase.Instance.GetItem(ItemType.Character, "Frozen!Olaf");
			fakeShopProductUnlockCondition16.ConditionValue = (int)item8;
			fakeShopProductUnlockCondition16.IsPreviewAvailable = false;
			((List<T>)(object)list10).Add((T)fakeShopProductUnlockCondition16);
			List<ShopProductModel> list11 = (List<ShopProductModel>)((Dictionary<TKey, TValue>)(object)products)[(TKey)2];
			FakeShopProductModel fakeShopProductModel = new FakeShopProductModel();
			fakeShopProductModel.FakeImageAddress = "shop_icon_currency_hard_1";
			fakeShopProductModel.FakeTitle = "Tiny Gems Package";
			fakeShopProductModel.FakeDesc = "Game currency for purchasing premium items";
			List<ItemReward> list12 = (List<ItemReward>)(object)new List<T>();
			int num = 0;
			int itemID = CurrencyItem.HardCurrencyItem.ItemID;
			ItemReward item9 = default(ItemReward);
			((List<T>)(object)list12).Add((T)item9);
			fakeShopProductModel.FakeItemRewards = list12;
			fakeShopProductModel.FakeIsRealMoney = true;
			fakeShopProductModel.FakePriceAmount = 0.99f;
			fakeShopProductModel.FakeAmount = 200;
			fakeShopProductModel.FakeRealMoneyCurrencySymbol = "$";
			fakeShopProductModel.FakeRealMoneyCurrencyName = "USD";
			((ShopProductModel)fakeShopProductModel).Tab = ShopMenu.ShopMenuTabs.Gem;
			((List<T>)(object)list11).Add((T)fakeShopProductModel);
			FakeShopProductModel fakeShopProductModel2 = new FakeShopProductModel();
			fakeShopProductModel2.FakeImageAddress = "shop_icon_currency_hard_2";
			fakeShopProductModel2.FakeTitle = "Small Gems Package";
			fakeShopProductModel2.FakeDesc = "Game currency for purchasing premium items";
			List<ItemReward> list13 = (List<ItemReward>)(object)new List<T>();
			int num2 = 0;
			int itemID2 = CurrencyItem.HardCurrencyItem.ItemID;
			ItemReward item10 = default(ItemReward);
			((List<T>)(object)list13).Add((T)item10);
			fakeShopProductModel2.FakeItemRewards = list13;
			fakeShopProductModel2.FakeIsRealMoney = true;
			fakeShopProductModel2.FakePriceAmount = 4.99f;
			fakeShopProductModel2.FakeAmount = 1200;
			fakeShopProductModel2.FakeRealMoneyCurrencySymbol = "$";
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003479")]
		[Cpp2IlInjected.Address(RVA = "0x152D880", Offset = "0x152C280", VA = "0x18152D880")]
		public FakeData()
		{
		}//Discarded unreachable code: IL_02b3

	}
}
