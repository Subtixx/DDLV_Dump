using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Meta.Missions;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AEB")]
	internal class ElsaNewVisitAreaStepProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005DA1")]
		[Cpp2IlInjected.Address(RVA = "0x174B470", Offset = "0x1749E70", VA = "0x18174B470", Slot = "5")]
		protected unsafe override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_01b8, IL_01be, IL_01c4, IL_01ca, IL_01d0, IL_01d6
			//IL_001b: Expected O, but got I4
			//IL_001b: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			ProfileWorld world_ = profile.world_;
			int num4 = 0;
			MissionSlot missionSlot = world_.GetMissionSlot((Item)num3, (Func<, >)num4);
			if (missionSlot == null || !ItemDatabase.Instance.TryGetItemData((Item)num3, out *(MissionItemData*)num))
			{
				return;
			}
			if (_003C_003Ec._003C_003E9__0_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionStepData x) => string.Equals(x.stepName_, "Group12"));
			}
			MissionStep missionStep = new MissionStep();
			MissionStepData missionStepData = default(MissionStepData);
			RepeatedField<MissionSubStepData> subSteps_ = missionStepData.subSteps_;
			bool flag = default(bool);
			if (flag)
			{
				MissionSubStep missionSubStep = new MissionSubStep();
				int num5 = 0;
				bool flag2 = default(bool);
				if (flag2)
				{
					RepeatedField<MissionObjective> objectives_ = missionSubStep.objectives_;
					MissionObjective item = new MissionObjective();
					((RepeatedField<T>)(object)objectives_).Add((T)item);
				}
				((RepeatedField<T>)(object)missionStep.subSteps_).Add((T)missionSubStep);
			}
			IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)missionStep.get_AllObjectives();
			Action<MissionObjective> action = default(Action<MissionObjective>);
			if (_003C_003Ec._003C_003E9__0_1 == null)
			{
				action = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate
				{
				}//Discarded unreachable code: IL_0001
				);
			}
			MoreLinq.ForEach<MissionObjective>((IEnumerable<>)allObjectives, (Action<>)(object)action);
			int num6 = default(int);
			((RepeatedField<T>)(object)missionSlot.missionSteps_).Insert(num6, (T)missionStep);
			if (missionSlot.currentStepIndex_ != num6)
			{
				if (missionSlot.currentStepIndex_ <= num6)
				{
					return;
				}
				IEnumerable<MissionObjective> allObjectives2 = (IEnumerable<MissionObjective>)((MissionStep)((RepeatedField<T>)(object)missionSlot.missionSteps_)[num6]).get_AllObjectives();
				Action<MissionObjective> action2 = default(Action<MissionObjective>);
				if (_003C_003Ec._003C_003E9__0_4 == null)
				{
					action2 = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
					{
						//Discarded unreachable code: IL_000a
						//IL_0009: Expected I4, but got I8
						x.status_ = MissionStepStatus.Confirmed;
					});
				}
				MoreLinq.ForEach<MissionObjective>((IEnumerable<>)allObjectives2, (Action<>)(object)action2);
				return;
			}
			IEnumerable<MissionObjective> allObjectives3 = (IEnumerable<MissionObjective>)((MissionStep)((RepeatedField<T>)(object)missionSlot.missionSteps_)[num3]).get_AllObjectives();
			Action<MissionObjective> action3 = default(Action<MissionObjective>);
			if (_003C_003Ec._003C_003E9__0_2 == null)
			{
				action3 = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
				{
					//Discarded unreachable code: IL_000a
					//IL_0009: Expected I4, but got I8
					x.status_ = MissionStepStatus.Ongoing;
				});
			}
			MoreLinq.ForEach<MissionObjective>((IEnumerable<>)allObjectives3, (Action<>)(object)action3);
			RepeatedField<MissionStep> missionSteps_ = missionSlot.missionSteps_;
			MissionStep missionStep2 = default(MissionStep);
			IEnumerable<MissionObjective> allObjectives4 = (IEnumerable<MissionObjective>)missionStep2.get_AllObjectives();
			Action<MissionObjective> action4 = default(Action<MissionObjective>);
			if (_003C_003Ec._003C_003E9__0_3 == null)
			{
				action4 = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
				{
					//Discarded unreachable code: IL_000a
					//IL_0009: Expected I4, but got I8
					x.status_ = MissionStepStatus.NotStarted;
				});
			}
			MoreLinq.ForEach<MissionObjective>((IEnumerable<>)allObjectives4, (Action<>)(object)action4);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005DA2")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public ElsaNewVisitAreaStepProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
