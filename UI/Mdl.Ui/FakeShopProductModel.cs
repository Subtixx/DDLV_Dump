using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using glPlayFab.Disney;
using Mdl.Systems;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006C9")]
	public class FakeShopProductModel : ShopProductModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002646")]
		public int FakeUniqueID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4002647")]
		public bool FakeIsRealMoney;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002648")]
		public string FakeRealMoneyCurrencySymbol;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002649")]
		public string FakeRealMoneyCurrencyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400264A")]
		public float FakePriceAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400264B")]
		public float FakeReplacedPriceAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400264C")]
		public float FakePriceAmountX10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400264D")]
		public float FakeReplacedPriceAmountX10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400264E")]
		public int FakeGachaBoxIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400264F")]
		public Item FakePriceCurrencyItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002650")]
		public DateTime? FakeExpireDate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002651")]
		public int FakeAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4002652")]
		public int FakeReplacedAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002653")]
		public string FakeImageAddress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002654")]
		public string FeaturedTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002655")]
		public string FakeTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002656")]
		public string FakeDesc;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002657")]
		public string FakeSpecialOfferText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002658")]
		public bool FakeIsDaily;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4002659")]
		public int FakeDailyDaysPerPurchase;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400265A")]
		public ItemReward FakeDailyReward;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400265B")]
		public List<ItemReward> FakeItemRewards;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400265C")]
		public bool FakeUseBgGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400265D")]
		public Color FakeTintBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400265E")]
		public bool FakeIsBgFlipped;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400265F")]
		public float FakeBgOffsetY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002660")]
		public string FakeBundleLayoutName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002661")]
		public FakeDailyRewardProgress FakeDailyRewardProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4002662")]
		public List<FakeShopProductUnlockCondition> FakeConditions;

		[Cpp2IlInjected.Token(Token = "0x1700065D")]
		public int FakeFreeChance
		{
			[Cpp2IlInjected.Token(Token = "0x6002BA8")]
			[Cpp2IlInjected.Address(RVA = "0x152F030", Offset = "0x152DA30", VA = "0x18152F030")]
			get
			{
				return FakeDailyChance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700065E")]
		public int FakeDailyChance
		{
			[Cpp2IlInjected.Token(Token = "0x6002BA9")]
			[Cpp2IlInjected.Address(RVA = "0x152EBF0", Offset = "0x152D5F0", VA = "0x18152EBF0")]
			get
			{
				//Discarded unreachable code: IL_0051
				FakeDailyRewardProgress fakeDailyRewardProgress = FakeDailyRewardProgress;
				int result = 0;
				if (fakeDailyRewardProgress != null)
				{
					DateTime _003CExpireDate_003Ek__BackingField = fakeDailyRewardProgress.ExpireDate;
					DateTime localTime = SystemRoot.Instance.MetaClient.LocalTime;
					if (_003CExpireDate_003Ek__BackingField > localTime)
					{
						DateTime _003CLastCollectionDate_003Ek__BackingField = FakeDailyRewardProgress.LastCollectionDate;
						Client client = default(Client);
						DateTime localTime2 = client.LocalTime;
						DateTime dateTime = default(DateTime);
						DateTime dateTime2 = default(DateTime);
						bool flag = dateTime < dateTime2;
					}
				}
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700065F")]
		public int FakeDailyDayLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6002BAA")]
			[Cpp2IlInjected.Address(RVA = "0x152EDF0", Offset = "0x152D7F0", VA = "0x18152EDF0")]
			get
			{
				//Discarded unreachable code: IL_0058
				FakeDailyRewardProgress fakeDailyRewardProgress = FakeDailyRewardProgress;
				if (fakeDailyRewardProgress != null)
				{
					DateTime _003CExpireDate_003Ek__BackingField = fakeDailyRewardProgress.ExpireDate;
					DateTime localTime = SystemRoot.Instance.MetaClient.LocalTime;
					DateTime dateTime = default(DateTime);
					DateTime dateTime2 = default(DateTime);
					if (dateTime > dateTime2)
					{
						DateTime _003CExpireDate_003Ek__BackingField2 = FakeDailyRewardProgress.ExpireDate;
						Client client = default(Client);
						DateTime localTime2 = client.LocalTime;
						DateTime dateTime3 = default(DateTime);
						DateTime dateTime4 = default(DateTime);
						TimeSpan timeSpan = dateTime3 - dateTime4;
						double num = default(double);
						return Mathf.FloorToInt((float)num);
					}
				}
				return 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000660")]
		public bool FakeHasCharacterReward
		{
			[Cpp2IlInjected.Token(Token = "0x6002BAB")]
			[Cpp2IlInjected.Address(RVA = "0x152F040", Offset = "0x152DA40", VA = "0x18152F040")]
			get
			{
				List<ItemReward> fakeItemRewards = FakeItemRewards;
				if (fakeItemRewards != null)
				{
					Predicate<ItemReward> _003C_003E9__36_ = _003C_003Ec._003C_003E9__36_0;
					if (_003C_003E9__36_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(ItemReward x)
						{
							//Discarded unreachable code: IL_000c
							Item item = x.Item;
							ItemType itemType = default(ItemType);
							return itemType == ItemType.Character;
						};
					}
					return ((List<T>)(object)fakeItemRewards).Exists((Predicate<>)(object)_003C_003E9__36_);
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BAC")]
		[Cpp2IlInjected.Address(RVA = "0x152EA80", Offset = "0x152D480", VA = "0x18152EA80")]
		internal int GetConditionValue(FakeShopProductUnlockCondition.Type conditionType)
		{
			//Discarded unreachable code: IL_0042
			List<FakeShopProductUnlockCondition> fakeConditions = FakeConditions;
			if (fakeConditions != null)
			{
				Predicate<FakeShopProductUnlockCondition> predicate = (Predicate<FakeShopProductUnlockCondition>)(object)(Predicate<T>)delegate(FakeShopProductUnlockCondition x)
				{
					//Discarded unreachable code: IL_0011
					FakeShopProductUnlockCondition.Type type = conditionType;
					return x.ConditionType == type;
				};
				FakeShopProductUnlockCondition fakeShopProductUnlockCondition = (FakeShopProductUnlockCondition)((List<T>)(object)fakeConditions).Find((Predicate<>)(object)predicate);
				if (fakeShopProductUnlockCondition != null)
				{
					int conditionValue = fakeShopProductUnlockCondition.ConditionValue;
					return 0;
				}
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BAD")]
		[Cpp2IlInjected.Address(RVA = "0x152E9C0", Offset = "0x152D3C0", VA = "0x18152E9C0")]
		internal bool CanBeShown()
		{
			List<FakeShopProductUnlockCondition> fakeConditions = FakeConditions;
			if (fakeConditions != null)
			{
				Predicate<FakeShopProductUnlockCondition> predicate = (Predicate<FakeShopProductUnlockCondition>)(object)(Predicate<T>)delegate(FakeShopProductUnlockCondition y)
				{
					//Discarded unreachable code: IL_0015
					bool isPreviewAvailable = y.IsPreviewAvailable;
					if (!isPreviewAvailable)
					{
						bool flag = y.IsUnlocked(this);
					}
					return isPreviewAvailable;
				};
				return ((List<T>)(object)fakeConditions).TrueForAll((Predicate<>)(object)predicate);
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BAE")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public FakeShopProductModel()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
