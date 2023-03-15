using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Meta.Missions;

namespace Meta.Duties
{
	[Cpp2IlInjected.Token(Token = "0x20010CC")]
	public class AchievementsUtils
	{
		[Cpp2IlInjected.Token(Token = "0x600884D")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D420", Offset = "0x1E2BE20", VA = "0x181E2D420")]
		public static void GenerateAchievements(Profile profile, ProfileEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_00e9, IL_00ef, IL_00f5, IL_00fb, IL_0101, IL_0107, IL_010d, IL_0113, IL_0119, IL_011f
			//IL_004c: Expected O, but got I4
			IEnumerable<> enumerable = default(IEnumerable<>);
			bool flag = default(bool);
			ItemFilter itemFilter_ = default(ItemFilter);
			while (true)
			{
				int num = 0;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Func<AchievementItemData, bool> _003C_003E9__0_ = _003C_003Ec._003C_003E9__0_0;
				if (_003C_003E9__0_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((AchievementItemData x) => x.status_ != DutyStatus.Debug);
				}
				List<AchievementItemData> list = (List<AchievementItemData>)(object)Enumerable.ToList<AchievementItemData>(Enumerable.Where<AchievementItemData>(enumerable, (Func<, >)(object)_003C_003E9__0_));
				if (flag)
				{
					AchievementItemData item = (AchievementItemData)0;
					RepeatedField<AchievementData> achievementsData_ = profile.player_.achievementsData_;
					Predicate<AchievementData> predicate = (Predicate<AchievementData>)(object)(Predicate<T>)delegate(AchievementData x)
					{
						//Discarded unreachable code: IL_001a
						AchievementItemData achievementItemData = item;
						int achievementID_ = x.achievementID_;
						int iD = achievementItemData.ID;
						return achievementID_ == iD;
					};
					if (!ProtoExtensions.Exists<AchievementData>((RepeatedField<>)(object)achievementsData_, (Predicate<>)(object)predicate))
					{
						Random random = new Random(profile.player_.GetRandomSeed("AchRandomSeed"));
						AchievementData achievementData = new AchievementData();
						int num2 = (achievementData.achievementID_ = ((BattlePassReward)(object)achievementData).Price);
						achievementData.curAmount_ = num;
						achievementData.state_ = (AchievementState)num;
						achievementData.itemFilter_ = itemFilter_;
						profile.player_.AdvanceRandomSeed("AchRandomSeed");
						((RepeatedField<T>)(object)profile.player_.achievementsData_).Add((T)achievementData);
						achievementData.Start(profile, dispatcher);
						break;
					}
					continue;
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600884E")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D950", Offset = "0x1E2C350", VA = "0x181E2D950")]
		private static ItemFilter GetItemFilter(AchievementItemData itemData, Random random, Profile profile)
		{
			//Discarded unreachable code: IL_008f
			//IL_002d: Expected I4, but got I8
			//IL_0068: Expected I4, but got O
			int num = 0;
			ItemSelector itemSelector = itemData.ItemSelector;
			string name_ = itemData.name_;
			string debugName = "Achievement:" + name_;
			int onlySeedCrop = 0;
			ulong num2 = default(ulong);
			ItemFilter itemFilter = ItemFilter.New(itemSelector, profile, random, (byte)onlySeedCrop != 0, (byte)num != 0, (byte)num2 != 0, debugName);
			if ((IntPtr)itemFilter.data_ == (IntPtr)num)
			{
				IUniqueItem getIUniqueItem = itemData.GetIUniqueItem;
				if (getIUniqueItem != null)
				{
					uint num3 = default(uint);
					if (num < (int)num3)
					{
						num += num;
						num++;
					}
					bool flag = default(bool);
					if (flag)
					{
						ItemFilterData itemFilterData = new ItemFilterData();
						itemFilterData.item_ = (int)getIUniqueItem;
						ItemType type_ = default(ItemType);
						itemFilterData.type_ = type_;
						ItemType itemType = default(ItemType);
						int activityItemType_ = default(int);
						if (itemType == ItemType.ActivityItem)
						{
							ActivityItemType activityItemType = default(ActivityItemType);
							activityItemType_ = (int)activityItemType;
						}
						itemFilterData.activityItemType_ = (ActivityItemType)activityItemType_;
						itemFilter.data_ = itemFilterData;
					}
				}
			}
			return itemFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x600884F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public AchievementsUtils()
		{
		}
	}
}
