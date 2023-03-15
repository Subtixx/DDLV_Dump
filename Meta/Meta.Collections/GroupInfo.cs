using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;

namespace Meta.Collections
{
	[Cpp2IlInjected.Token(Token = "0x200110B")]
	public class GroupInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004640")]
		private Dictionary<IItemData, bool> collectionItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004642")]
		private CollectionSetGroup groupData;

		[Cpp2IlInjected.Token(Token = "0x1700185B")]
		public Dictionary<IItemData, bool> CollectionItems
		{
			[Cpp2IlInjected.Token(Token = "0x6008AEC")]
			[Cpp2IlInjected.Address(RVA = "0x1D1D5C0", Offset = "0x1D1BFC0", VA = "0x181D1D5C0")]
			get
			{
				//Discarded unreachable code: IL_0076
				if (groupData.NeedsUpdate)
				{
					Dictionary<IItemData, bool> dictionary = collectionItems;
					int num = 0;
					int count = ((Dictionary<TKey, TValue>)(object)dictionary).Count;
					CollectionSetGroup collectionSetGroup = groupData;
					if (num < count)
					{
						int count2 = ((MapField<TKey, TValue>)(object)collectionSetGroup.groupsCollectionItems_).Count;
						if (num < count2)
						{
							Dictionary<IItemData, bool> dictionary2 = collectionItems;
							KeyValuePair<int, bool> keyValuePair = Enumerable.ElementAt<KeyValuePair<int, bool>>((IEnumerable<>)(object)groupData.groupsCollectionItems_, num);
							throw new NullReferenceException();
						}
						Dictionary<IItemData, bool> dictionary3 = collectionItems;
						num++;
					}
					collectionSetGroup.NeedsUpdate = false;
				}
				return collectionItems;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700185C")]
		public string GroupName
		{
			[Cpp2IlInjected.Token(Token = "0x6008AED")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CGroupName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6008AEE")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			private set
			{
				_003CGroupName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700185D")]
		public SetState GroupState
		{
			[Cpp2IlInjected.Token(Token = "0x6008AEF")]
			[Cpp2IlInjected.Address(RVA = "0x1D1E210", Offset = "0x1D1CC10", VA = "0x181D1E210")]
			get
			{
				//Discarded unreachable code: IL_000c
				return groupData.state_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008AF0")]
		[Cpp2IlInjected.Address(RVA = "0x1D1DF90", Offset = "0x1D1C990", VA = "0x181D1DF90")]
		public GroupInfo(CollectionSetGroup groupData, string groupName)
		{
			//Discarded unreachable code: IL_0033, IL_0039, IL_003f
			this.groupData = groupData;
			Dictionary<IItemData, bool> dictionary = (collectionItems = (Dictionary<IItemData, bool>)(object)new Dictionary<TKey, TValue>());
			MapField<int, bool> groupsCollectionItems_ = groupData.groupsCollectionItems_;
			bool flag = default(bool);
			if (flag)
			{
				IItemData itemData = default(IItemData);
				while (itemData == null)
				{
				}
				Dictionary<IItemData, bool> dictionary2 = (Dictionary<IItemData, bool>)(object)this.get_CollectionItems();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008AF1")]
		[Cpp2IlInjected.Address(RVA = "0x1D1D5C0", Offset = "0x1D1BFC0", VA = "0x181D1D5C0")]
		private Dictionary<IItemData, bool> GetCollectionItems()
		{
			//Discarded unreachable code: IL_0076
			if (groupData.NeedsUpdate)
			{
				Dictionary<IItemData, bool> dictionary = collectionItems;
				int num = 0;
				int count = ((Dictionary<TKey, TValue>)(object)dictionary).Count;
				CollectionSetGroup collectionSetGroup = groupData;
				if (num < count)
				{
					int count2 = ((MapField<TKey, TValue>)(object)collectionSetGroup.groupsCollectionItems_).Count;
					if (num < count2)
					{
						Dictionary<IItemData, bool> dictionary2 = collectionItems;
						KeyValuePair<int, bool> keyValuePair = Enumerable.ElementAt<KeyValuePair<int, bool>>((IEnumerable<>)(object)groupData.groupsCollectionItems_, num);
						throw new NullReferenceException();
					}
					Dictionary<IItemData, bool> dictionary3 = collectionItems;
					num++;
				}
				collectionSetGroup.NeedsUpdate = false;
			}
			return collectionItems;
		}

		[Cpp2IlInjected.Token(Token = "0x6008AF2")]
		[Cpp2IlInjected.Address(RVA = "0x1D1D810", Offset = "0x1D1C210", VA = "0x181D1D810")]
		public static CropExtraInfo GetExtraCropInfo(IItemData itemData)
		{
			//IL_0013: Expected O, but got I4
			//IL_0055: Expected I4, but got O
			//IL_009c: Expected I4, but got O
			int num = 0;
			if (itemData != null)
			{
			}
			CropItemData cropData = (CropItemData)num;
			if ((IntPtr)cropData == (IntPtr)num && itemData != null && itemData != null)
			{
				int num2 = 0;
				Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
				CropExtraInfo cropExtraInfo = new CropExtraInfo();
				CurrencyCost currencyCost = new CurrencyCost();
				currencyCost.amount_ = num;
				int num3 = 0;
				Item softCurrencyItem2 = CurrencyItem.SoftCurrencyItem;
				currencyCost.id_ = (int)softCurrencyItem2;
				cropExtraInfo.Price = currencyCost;
				return cropExtraInfo;
			}
			IEnumerable<> allByType = ItemDatabase.Instance.GetAllByType<SeedItemData, ActivityItemType>(ItemType.ActivityItem, (ActivityItemType)num);
			int num4 = 0;
			Item softCurrencyItem3 = CurrencyItem.SoftCurrencyItem;
			CurrencyCost currencyCost2 = new CurrencyCost();
			currencyCost2.amount_ = num;
			int num5 = 0;
			Item softCurrencyItem4 = CurrencyItem.SoftCurrencyItem;
			currencyCost2.id_ = (int)softCurrencyItem4;
			CropExtraInfo cropExtraInfo2 = new CropExtraInfo();
			cropExtraInfo2.Price = currencyCost2;
			Func<SeedItemData, bool> func = (Func<SeedItemData, bool>)(object)(Func<T, TResult>)delegate(SeedItemData x)
			{
				Item producedItem = x.ProducedItem;
				int iD = cropData.ID;
				throw new NullReferenceException();
			};
			SeedItemData seedItemData = Enumerable.FirstOrDefault<SeedItemData>(allByType, (Func<, >)(object)func);
			Duration productionPeriod_ = default(Duration);
			if (seedItemData != null)
			{
				productionPeriod_ = seedItemData.productionPeriod_;
			}
			cropExtraInfo2.Time = productionPeriod_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008AF3")]
		[Cpp2IlInjected.Address(RVA = "0x1D1DC10", Offset = "0x1D1C610", VA = "0x181D1DC10")]
		public static FishExtraInfo GetExtraFishInfo(IItemData itemData)
		{
			//IL_0013: Expected O, but got I4
			int num = 0;
			if (itemData != null)
			{
			}
			FishItemData fishData = (FishItemData)num;
			if ((long)fishData == 0)
			{
				int num2 = 0;
			}
			IEnumerable<> allByType = ItemDatabase.Instance.GetAllByType<FishingDataItemData, ActivityDataItemType>(ItemType.ActivityData, ActivityDataItemType.FishingData);
			Func<FishingDataItemData, bool> func = (Func<FishingDataItemData, bool>)(object)(Func<T, TResult>)delegate(FishingDataItemData y)
			{
				Item item = y.result_.Item;
				int iD = fishData.ID;
				throw new NullReferenceException();
			};
			FishingDataItemData fishingDataItemData = Enumerable.FirstOrDefault<FishingDataItemData>(allByType, (Func<, >)(object)func);
			FishExtraInfo fishExtraInfo = new FishExtraInfo();
			float num3 = (fishExtraInfo.BestCatch = fishData.maxMass_);
			string text = (fishExtraInfo.FishSchedule = fishingDataItemData.appearanceCondition_);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008AF4")]
		[Cpp2IlInjected.Address(RVA = "0x1D1D730", Offset = "0x1D1C130", VA = "0x181D1D730")]
		public static CritterExtraInfo GetExtraCritterInfo(IItemData itemData)
		{
			if (itemData != null && itemData != null)
			{
				CritterExtraInfo critterExtraInfo = new CritterExtraInfo();
				List<CritterItemData.Types.DailyScheduleData> list = default(List<CritterItemData.Types.DailyScheduleData>);
				critterExtraInfo.CritterSchedule = list;
				critterExtraInfo.FavoriteGift = (ItemSelector)(object)list;
				critterExtraInfo.FavoriteGiftDescription = (string)(object)list;
				return critterExtraInfo;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008AF5")]
		[Cpp2IlInjected.Address(RVA = "0x1D1DE30", Offset = "0x1D1C830", VA = "0x181D1DE30")]
		public static MemoriesExtraInfo GetExtraMemoryShardInfo(IItemData itemData, Profile profile)
		{
			int num = 0;
			if (profile != null && itemData != null && itemData != null)
			{
				MapField<int, int> memoryShards_ = profile.player_.memoryShards_;
				bool flag = default(bool);
				if (flag)
				{
					MemoriesExtraInfo memoriesExtraInfo = new MemoriesExtraInfo();
					int num2 = default(int);
					if (num < num2)
					{
					}
					memoriesExtraInfo.RareFind = (RewardAppearanceCondition)num;
					memoriesExtraInfo.ShardProgress = num;
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}
	}
}
