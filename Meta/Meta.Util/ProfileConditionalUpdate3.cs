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
	[Cpp2IlInjected.Token(Token = "0x2000AE4")]
	internal class ProfileConditionalUpdate3 : ProfileConditionalUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D8A")]
		[Cpp2IlInjected.Address(RVA = "0x94E640", Offset = "0x94D040", VA = "0x18094E640")]
		public ProfileConditionalUpdate3()
		{
			((BattlePassReward)(object)this)._002Ector();
			base.updateName = "ProfileUpdate3";
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D8B")]
		[Cpp2IlInjected.Address(RVA = "0x94E070", Offset = "0x94CA70", VA = "0x18094E070", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			base.DoApplyProfile(profile);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D8C")]
		[Cpp2IlInjected.Address(RVA = "0x94E080", Offset = "0x94CA80", VA = "0x18094E080")]
		public unsafe static void FixUniqueHerringIssue(Profile profile)
		{
			//Discarded unreachable code: IL_00b9
			//IL_004c: Expected O, but got I8
			int num;
			uint value = default(uint);
			long num3;
			uint value2 = default(uint);
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			do
			{
				num = 0;
				long num2 = Convert.ToInt64(value);
				num3 = Convert.ToInt64(value2);
				ProfileWorld world_ = profile.world_;
				if (flag)
				{
					continue;
				}
				ProfileWorld world_2 = profile.world_;
				if (!flag2)
				{
					ProfileWorld world_3 = profile.world_;
					if (!flag3)
					{
					}
				}
				return;
			}
			while (!((MapField<TKey, TValue>)(object)profile.player_.fishRecords_).TryGetValue((TKey)num3, out *(TValue*)num));
			int num4 = 0;
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
			MissionStep missionStep2 = default(MissionStep);
			IEnumerable<MissionObjective> allObjectives2 = (IEnumerable<MissionObjective>)missionStep2.get_AllObjectives();
			Action<MissionObjective> action2 = default(Action<MissionObjective>);
			if (_003C_003Ec._003C_003E9__2_1 == null)
			{
				action2 = (Action<MissionObjective>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(MissionObjective x)
				{
					//Discarded unreachable code: IL_000a
					//IL_0009: Expected I4, but got I8
					x.status_ = MissionStepStatus.Confirmed;
				});
			}
			MoreLinq.ForEach<MissionObjective>((IEnumerable<>)allObjectives2, (Action<>)(object)action2);
		}
	}
}
