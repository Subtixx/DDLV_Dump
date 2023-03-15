using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using glPlayFab.Disney;
using Meta.Actions;
using Meta.Missions;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B0D")]
	internal class FixDecorateProgressionProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005DFA")]
		[Cpp2IlInjected.Address(RVA = "0x18020D0", Offset = "0x1800AD0", VA = "0x1818020D0", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			int num = 0;
			FixDecorateBlockerStepOfKris020(profile);
		}

		[Cpp2IlInjected.Token(Token = "0x6005DFB")]
		[Cpp2IlInjected.Address(RVA = "0x18025A0", Offset = "0x1800FA0", VA = "0x1818025A0")]
		private static void FixDecoratePartyStep(Profile profile, Item missionItem, Item partyItem, string activeStepName)
		{
			//Discarded unreachable code: IL_0043
			//IL_0032: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			int itemID = partyItem.ItemID;
			int itemID2 = missionItem.ItemID;
			int num = 0;
			ProfileWorld world_ = profile.world_;
			bool flag = default(bool);
			int num2 = default(int);
			if (flag && num2 > 0)
			{
				itemID = num2;
				string msg = $"{itemID} gived back for {num2} #{activeStepName}";
				bool flag2 = ActionsHelper.LogSuccess("FixDecoratePartyStep", msg);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DFC")]
		[Cpp2IlInjected.Address(RVA = "0x1802240", Offset = "0x1800C40", VA = "0x181802240")]
		private static void FixDecorateBlockerStepOfKris020(Profile profile)
		{
			int num = 0;
			uint value = default(uint);
			long num2 = Convert.ToInt64(value);
			ProfileWorld world_ = profile.world_;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			ProfilePlayer player_ = profile.player_;
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			if (!flag2 && !flag3)
			{
				int num3 = default(int);
				if (num3 > 0)
				{
					bool flag4 = ActionsHelper.LogSuccess("FixDecoratePartyStepOfKris020", "Sculpture gived back");
				}
				return;
			}
			MissionStep missionStep = default(MissionStep);
			IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)missionStep.get_AllObjectives();
			Action<MissionObjective> action = default(Action<MissionObjective>);
			if (_003C_003Ec._003C_003E9__2_0 == null)
			{
				action = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
				{
					//Discarded unreachable code: IL_000a
					//IL_0009: Expected I4, but got I8
					x.status_ = MissionStepStatus.Confirmed;
				});
			}
			MoreLinq.ForEach<MissionObjective>((IEnumerable<>)allObjectives, (Action<>)(object)action);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005DFD")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public FixDecorateProgressionProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
