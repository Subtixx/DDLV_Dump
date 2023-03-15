using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using Google.Protobuf.Collections;
using Mdl.Utils;
using Meta;
using Meta.Duties;
using Meta.Online;
using UnityEngine;

namespace Mdl.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200095E")]
	public class PlatformAchievements : System
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200095F")]
		private class AchievementInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400340A")]
			[ItemID]
			public int achievementID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400340B")]
			public string windowsXboxAchievementID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400340C")]
			public string playstationTrophyID;

			[Cpp2IlInjected.Token(Token = "0x6002B9B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public AchievementInfo()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003409")]
		[SerializeField]
		private List<AchievementInfo> achievements;

		[Cpp2IlInjected.Token(Token = "0x6002B93")]
		[Cpp2IlInjected.Address(RVA = "0xF13920", Offset = "0xF12320", VA = "0x180F13920", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			//Discarded unreachable code: IL_0025
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.DutyAchRewardCollected value = Dispatcher_OnDutyAchRewardCollected;
			_003CDispatcher_003Ek__BackingField.OnDutyAchRewardCollected += value;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B94")]
		[Cpp2IlInjected.Address(RVA = "0xF13A50", Offset = "0xF12450", VA = "0x180F13A50", Slot = "5")]
		public override void OnSystemStop()
		{
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField == null)
			{
				return;
			}
			Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
			if (metaClient != null)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = metaClient.Dispatcher;
				if (_003CDispatcher_003Ek__BackingField != null)
				{
					ProfileEventDispatcher.DutyAchRewardCollected value = Dispatcher_OnDutyAchRewardCollected;
					_003CDispatcher_003Ek__BackingField.OnDutyAchRewardCollected -= value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B95")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnSystemPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002B96")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002B97")]
		[Cpp2IlInjected.Address(RVA = "0xF13710", Offset = "0xF12110", VA = "0x180F13710")]
		private void Dispatcher_OnDutyAchRewardCollected(List<AnyReward> rewards, DutyAchItemType dutyAchtype, Item achievementItem)
		{
			//Discarded unreachable code: IL_009d
			//IL_0016: Expected O, but got I4
			int itemID = achievementItem.ItemID;
			Item achievementItem2 = (Item)itemID;
			if (dutyAchtype != DutyAchItemType.Achievement)
			{
				return;
			}
			List<AchievementInfo> list = achievements;
			Func<AchievementInfo, bool> func = (Func<AchievementInfo, bool>)(object)(Func<T, TResult>)delegate(AchievementInfo x)
			{
				//Discarded unreachable code: IL_0011
				Item item = achievementItem2;
				return (IntPtr)x.achievementID == (IntPtr)item;
			};
			AchievementInfo achievement = Enumerable.FirstOrDefault<AchievementInfo>((IEnumerable<>)list, (Func<, >)(object)func);
			if ((long)achievement != 0)
			{
				Client client = default(Client);
				RepeatedField<AchievementData> achievementsData_ = client.profile.player_.achievementsData_;
				Func<AchievementData, bool> func2 = (Func<AchievementData, bool>)(object)(Func<T, TResult>)delegate(AchievementData x)
				{
					//Discarded unreachable code: IL_0016
					int achievementID = achievement.achievementID;
					return x.achievementID_ == achievementID;
				};
				AchievementData achievementData = Enumerable.FirstOrDefault<AchievementData>((IEnumerable<>)(object)achievementsData_, (Func<, >)(object)func2);
				if (achievementData != null && !achievementData.IsLastMilestoneClaimed)
				{
					int previousMilestone = achievementData.PreviousMilestone;
					int lastMilestone = achievementData.LastMilestone;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B98")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void ProgressAchievement(AchievementInfo achievement, int claimedMilestone, int lastMilestone)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002B99")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void CompleteAchievement(AchievementInfo achievement)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002B9A")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public PlatformAchievements()
		{
		}
	}
}
