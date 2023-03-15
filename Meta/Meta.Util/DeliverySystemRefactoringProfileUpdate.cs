using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Missions;
using Gameloft.Common;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Meta.Missions;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B0B")]
	internal class DeliverySystemRefactoringProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005DF2")]
		[Cpp2IlInjected.Address(RVA = "0x1A29160", Offset = "0x1A27B60", VA = "0x181A29160", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//IL_004b: Expected I4, but got I8
			ProfileWorld world_ = profile.world_;
			MissionSlot missionSlot = default(MissionSlot);
			if (missionSlot == null)
			{
				return;
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			if (_003C_003Ec._003C_003E9__0_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionStepData x) => string.Equals(x.stepName_, "Group09"));
			}
			MissionSlot missionSlot2 = new MissionSlot();
			missionSlot2.state_ = MissionSlotState.Invalid;
			int num = default(int);
			MissionStep item = (MissionStep)((RepeatedField<T>)(object)missionSlot2.missionSteps_)[num];
			((RepeatedField<T>)(object)missionSlot.missionSteps_).Insert(num, (T)item);
			int currentStepIndex_ = missionSlot.currentStepIndex_;
			if (currentStepIndex_ != num)
			{
				return;
			}
			RepeatedField<MissionStep> missionSteps_ = missionSlot.missionSteps_;
			currentStepIndex_++;
			MissionStepStatus status = ((MissionStep)((RepeatedField<T>)(object)missionSteps_)[currentStepIndex_]).Status;
			RepeatedField<MissionStep> missionSteps_2 = missionSlot.missionSteps_;
			if (status != MissionStepStatus.ReadyToBeCompleted)
			{
				IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)((MissionStep)((RepeatedField<T>)(object)missionSteps_2)[num]).get_AllObjectives();
				Action<MissionObjective> action = default(Action<MissionObjective>);
				if (_003C_003Ec._003C_003E9__0_2 == null)
				{
					action = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
					{
						//Discarded unreachable code: IL_000a
						//IL_0009: Expected I4, but got I8
						x.status_ = MissionStepStatus.Ongoing;
					});
				}
				MoreLinq.ForEach<MissionObjective>((IEnumerable<>)allObjectives, (Action<>)(object)action);
				RepeatedField<MissionStep> missionSteps_3 = missionSlot.missionSteps_;
				int index = num + 1;
				IEnumerable<MissionObjective> allObjectives2 = (IEnumerable<MissionObjective>)((MissionStep)((RepeatedField<T>)(object)missionSteps_3)[index]).get_AllObjectives();
				Action<MissionObjective> action2 = default(Action<MissionObjective>);
				if (_003C_003Ec._003C_003E9__0_3 == null)
				{
					action2 = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
					{
						//Discarded unreachable code: IL_000a
						//IL_0009: Expected I4, but got I8
						x.status_ = MissionStepStatus.NotStarted;
					});
				}
				MoreLinq.ForEach<MissionObjective>((IEnumerable<>)allObjectives2, (Action<>)(object)action2);
				return;
			}
			MissionStep missionStep = default(MissionStep);
			IEnumerable<MissionObjective> allObjectives3 = (IEnumerable<MissionObjective>)missionStep.get_AllObjectives();
			Action<MissionObjective> action3 = default(Action<MissionObjective>);
			if (_003C_003Ec._003C_003E9__0_1 == null)
			{
				action3 = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
				{
					//Discarded unreachable code: IL_000a
					//IL_0009: Expected I4, but got I8
					x.status_ = MissionStepStatus.Confirmed;
				});
			}
			MoreLinq.ForEach<MissionObjective>((IEnumerable<>)allObjectives3, (Action<>)(object)action3);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005DF3")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public DeliverySystemRefactoringProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
