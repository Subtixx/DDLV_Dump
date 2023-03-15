using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Meta.Missions;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B1C")]
	internal class StitchRepairedTVProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005E1C")]
		[Cpp2IlInjected.Address(RVA = "0xC08150", Offset = "0xC06B50", VA = "0x180C08150", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_00d0, IL_00d6, IL_00dc
			int num = 0;
			ProfileWorld world_ = profile.world_;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (!flag || !flag2)
			{
				return;
			}
			if (_003C_003Ec._003C_003E9__0_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionStepData x) => string.Equals(x.stepName_, "Group02"));
			}
			if (_003C_003Ec._003C_003E9__0_1 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionStepData x) => string.Equals(x.stepName_, "Group04"));
			}
			MissionStep missionStep = default(MissionStep);
			MissionStep missionStep2 = default(MissionStep);
			MissionStep missionStep3 = default(MissionStep);
			MissionStep missionStep4 = default(MissionStep);
			MissionStepStatus status = default(MissionStepStatus);
			if ((missionStep.Status == MissionStepStatus.Completed || missionStep2.Status == MissionStepStatus.Confirmed) && missionStep3.Status != MissionStepStatus.ReadyToBeCompleted && missionStep4.Status != MissionStepStatus.Completed)
			{
				MissionStep missionStep5 = default(MissionStep);
				status = missionStep5.Status;
			}
			int num2 = 0;
			int num3 = (int)status;
			ICollection<ContainerInventory> values = (ICollection<ContainerInventory>)((MapField<TKey, TValue>)(object)profile.player_.containerInventories_).get_Values();
			if (values != null)
			{
				uint num4 = default(uint);
				if (num < (int)num4)
				{
					num += num;
					if (num == (int)num4)
					{
						goto IL_00b8;
					}
					num++;
				}
				bool flag3 = default(bool);
				while (!flag3)
				{
				}
				goto IL_00b8;
			}
			goto IL_00bf;
			IL_00bf:
			if (values != null)
			{
			}
			ulong num5 = default(ulong);
			if (num5 == 0)
			{
				int num6 = (int)status;
			}
			return;
			IL_00b8:
			num3 += num3;
			goto IL_00bf;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E1D")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public StitchRepairedTVProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
