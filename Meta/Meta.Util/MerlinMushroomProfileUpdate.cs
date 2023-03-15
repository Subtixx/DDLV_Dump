using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Meta.Missions;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AEE")]
	internal class MerlinMushroomProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005DAC")]
		[Cpp2IlInjected.Address(RVA = "0x7F45A0", Offset = "0x7F2FA0", VA = "0x1807F45A0", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_013b
			ProfileWorld world_ = profile.world_;
			MissionSlot missionSlot = default(MissionSlot);
			if (missionSlot != null)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				bool flag = default(bool);
				if (flag)
				{
					if (_003C_003Ec._003C_003E9__0_0 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionStepData x) => string.Equals(x.stepName_, "Group02"));
					}
					int index = default(int);
					RepeatedField<MissionSubStep> subSteps_ = ((MissionStep)((RepeatedField<T>)(object)missionSlot.missionSteps_)[index]).subSteps_;
					int index2 = 0;
					RepeatedField<MissionObjective> objectives_ = ((MissionSubStep)((RepeatedField<T>)(object)subSteps_)[index2]).objectives_;
					int index3 = 0;
					MissionObjective missionObjective = (MissionObjective)((RepeatedField<T>)(object)objectives_)[index3];
					if (missionObjective.itemFilter_.data_.item_ == 30200058)
					{
						missionObjective.targetAmount_ = 10f;
					}
				}
			}
			uint value = default(uint);
			long num = Convert.ToInt64(value);
			ProfileWorld world_2 = profile.world_;
			MissionSlot missionSlot2 = default(MissionSlot);
			if (missionSlot2 == null)
			{
				return;
			}
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			bool flag2 = default(bool);
			if (!flag2)
			{
				return;
			}
			if (_003C_003Ec._003C_003E9__0_1 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionStepData x) => string.Equals(x.stepName_, "Group01"));
			}
			int index4 = default(int);
			RepeatedField<MissionSubStep> subSteps_2 = ((MissionStep)((RepeatedField<T>)(object)missionSlot2.missionSteps_)[index4]).subSteps_;
			int index5 = 0;
			RepeatedField<MissionObjective> objectives_2 = ((MissionSubStep)((RepeatedField<T>)(object)subSteps_2)[index5]).objectives_;
			Func<MissionObjective, bool> func = default(Func<MissionObjective, bool>);
			if (_003C_003Ec._003C_003E9__0_2 == null)
			{
				func = (Func<MissionObjective, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjective x) => x.itemFilter_.data_.item_ == 30200058));
			}
			MissionObjective missionObjective2 = Enumerable.FirstOrDefault<MissionObjective>((IEnumerable<>)(object)objectives_2, (Func<, >)(object)func);
			if (missionObjective2 != null)
			{
				missionObjective2.targetAmount_ = 15f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DAD")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public MerlinMushroomProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
