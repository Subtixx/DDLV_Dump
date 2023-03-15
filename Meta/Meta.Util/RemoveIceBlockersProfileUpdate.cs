using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Meta.Grids;
using Meta.Missions;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B17")]
	internal class RemoveIceBlockersProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005E11")]
		[Cpp2IlInjected.Address(RVA = "0x5C8A00", Offset = "0x5C7400", VA = "0x1805C8A00", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_0112, IL_0118, IL_011e, IL_0124, IL_012a, IL_0130, IL_0136
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected O, but got Unknown
			int num = 0;
			ProfileWorld world_ = profile.world_;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			MissionStep missionStep = default(MissionStep);
			RepeatedField<MissionSubStep> subSteps_ = missionStep.subSteps_;
			int index = 0;
			RepeatedField<MissionObjective> objectives_ = ((MissionSubStep)((RepeatedField<T>)(object)subSteps_)[index]).objectives_;
			int index2 = 0;
			MissionObjective missionObjective = (MissionObjective)((RepeatedField<T>)(object)objectives_)[index2];
			float currentAmount = missionObjective.CurrentAmount;
			ICollection<DiffGrid> values = (ICollection<DiffGrid>)((MapField<TKey, TValue>)(object)profile.world_.gridCollection_.diffGrids_).get_Values();
			ICollection<> collection = default(ICollection<>);
			int num3 = default(int);
			if (values != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_008c;
					}
					num++;
				}
				if (collection != null)
				{
					while (collection == null)
					{
					}
					num3 = 0;
					AmountWithState amountWithState = default(AmountWithState);
					if (amountWithState != null)
					{
						int? amount_ = amountWithState.amount_;
						goto IL_008c;
					}
					goto IL_0093;
				}
				goto IL_0097;
			}
			goto IL_009c;
			IL_0097:
			if (collection == null)
			{
			}
			goto IL_009c;
			IL_0093:
			num += num;
			goto IL_0097;
			IL_009c:
			if (values != null)
			{
			}
			MissionStep missionStep2 = default(MissionStep);
			RepeatedField<MissionSubStep> subSteps_2 = missionStep2.subSteps_;
			int index3 = 0;
			RepeatedField<MissionObjective> objectives_2 = ((MissionSubStep)((RepeatedField<T>)(object)subSteps_2)[index3]).objectives_;
			int index4 = 0;
			MissionObjective missionObjective2 = (MissionObjective)((RepeatedField<T>)(object)objectives_2)[index4];
			missionObjective = (MissionObjective)(missionObjective + num);
			missionObjective2.targetAmount_ = currentAmount;
			if (num != 0)
			{
				return;
			}
			MissionStep missionStep3 = default(MissionStep);
			IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)missionStep3.get_AllObjectives();
			Action<MissionObjective> action = default(Action<MissionObjective>);
			if (_003C_003Ec._003C_003E9__0_0 == null)
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
			IL_008c:
			num3 += num3;
			goto IL_0093;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E12")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public RemoveIceBlockersProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
