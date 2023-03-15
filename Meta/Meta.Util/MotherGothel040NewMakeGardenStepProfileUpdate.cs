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
	[Cpp2IlInjected.Token(Token = "0x2000B02")]
	internal class MotherGothel040NewMakeGardenStepProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005DDB")]
		[Cpp2IlInjected.Address(RVA = "0x1393F10", Offset = "0x1392910", VA = "0x181393F10", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//IL_004b: Expected I4, but got I8
			MissionSlot missionSlot = default(MissionSlot);
			bool flag = default(bool);
			int num = default(int);
			Action<MissionObjective> action = default(Action<MissionObjective>);
			uint value = default(uint);
			bool flag2 = default(bool);
			MissionStep missionStep = default(MissionStep);
			Action<MissionObjective> action2 = default(Action<MissionObjective>);
			MissionStep missionStep2 = default(MissionStep);
			Action<MissionObjective> action3 = default(Action<MissionObjective>);
			MissionStep missionStep3 = default(MissionStep);
			do
			{
				ProfileWorld world_ = profile.world_;
				if (missionSlot == null)
				{
					return;
				}
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				if (!flag)
				{
					return;
				}
				if (_003C_003Ec._003C_003E9__0_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionStepData x) => string.Equals(x.stepName_, "Group11"));
				}
				MissionSlot missionSlot2 = new MissionSlot();
				missionSlot2.state_ = MissionSlotState.Invalid;
				MissionStep item = (MissionStep)((RepeatedField<T>)(object)missionSlot2.missionSteps_)[num];
				((RepeatedField<T>)(object)missionSlot.missionSteps_).Insert(num, (T)item);
				if (missionSlot.currentStepIndex_ != num)
				{
					if (missionSlot.currentStepIndex_ <= num)
					{
						return;
					}
					IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)((MissionStep)((RepeatedField<T>)(object)missionSlot.missionSteps_)[num]).get_AllObjectives();
					if (_003C_003Ec._003C_003E9__0_4 == null)
					{
						action = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
						{
							//Discarded unreachable code: IL_000a
							//IL_0009: Expected I4, but got I8
							x.status_ = MissionStepStatus.Confirmed;
						});
					}
					MoreLinq.ForEach<MissionObjective>((IEnumerable<>)allObjectives, (Action<>)(object)action);
					return;
				}
				ProfilePlayer player_ = profile.player_;
				long num2 = Convert.ToInt64(value);
				if (!flag2)
				{
					IEnumerable<MissionObjective> allObjectives2 = (IEnumerable<MissionObjective>)missionStep.get_AllObjectives();
					if (_003C_003Ec._003C_003E9__0_2 == null)
					{
						action2 = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
						{
							//Discarded unreachable code: IL_000a
							//IL_0009: Expected I4, but got I8
							x.status_ = MissionStepStatus.Ongoing;
						});
					}
					MoreLinq.ForEach<MissionObjective>((IEnumerable<>)allObjectives2, (Action<>)(object)action2);
					IEnumerable<MissionObjective> allObjectives3 = (IEnumerable<MissionObjective>)missionStep2.get_AllObjectives();
					if (_003C_003Ec._003C_003E9__0_3 == null)
					{
						action3 = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
						{
							//Discarded unreachable code: IL_000a
							//IL_0009: Expected I4, but got I8
							x.status_ = MissionStepStatus.NotStarted;
						});
					}
					MoreLinq.ForEach<MissionObjective>((IEnumerable<>)allObjectives3, (Action<>)(object)action3);
				}
				IEnumerable<MissionObjective> allObjectives4 = (IEnumerable<MissionObjective>)missionStep3.get_AllObjectives();
			}
			while (_003C_003Ec._003C_003E9__0_1 != null);
			Action<MissionObjective> action4 = (Action<MissionObjective>)(object)(Action<T>)delegate(MissionObjective x)
			{
				//Discarded unreachable code: IL_000a
				//IL_0009: Expected I4, but got I8
				x.status_ = MissionStepStatus.Confirmed;
			};
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005DDC")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public MotherGothel040NewMakeGardenStepProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
