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
	[Cpp2IlInjected.Token(Token = "0x2000B1E")]
	internal class UrsulaKeyholePossessProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005E22")]
		[Cpp2IlInjected.Address(RVA = "0x15DD530", Offset = "0x15DBF30", VA = "0x1815DD530", Slot = "5")]
		protected unsafe override void DoApplyProfile(Profile profile)
		{
			//IL_00c7: Expected O, but got I4
			bool flag = default(bool);
			uint num2 = default(uint);
			MissionStep missionStep = default(MissionStep);
			while (true)
			{
				int num = 0;
				ProfileWorld world_ = profile.world_;
				if (!flag)
				{
					return;
				}
				string[] array = new string[4];
				if ("4b10ff96-2515-4ccd-93ea-59a3c7cd2f7f" != null && "4b10ff96-2515-4ccd-93ea-59a3c7cd2f7f" == null)
				{
					continue;
				}
				array[0] = "4b10ff96-2515-4ccd-93ea-59a3c7cd2f7f";
				if ("3fe2ecdc-7b5f-4a66-805c-b6d822837c39" != null && "3fe2ecdc-7b5f-4a66-805c-b6d822837c39" == null)
				{
					continue;
				}
				array[1] = "3fe2ecdc-7b5f-4a66-805c-b6d822837c39";
				if ("c6e04d36-2e00-4a1a-878d-5b65d18ede48" != null && "c6e04d36-2e00-4a1a-878d-5b65d18ede48" == null)
				{
					continue;
				}
				array[2] = "c6e04d36-2e00-4a1a-878d-5b65d18ede48";
				if ("6894610b-46ec-4291-8673-6ec166ad58df" != null && "6894610b-46ec-4291-8673-6ec166ad58df" == null)
				{
					continue;
				}
				array[3] = "6894610b-46ec-4291-8673-6ec166ad58df";
				int length = array.Length;
				if (num < length)
				{
					MapField<string, Keyhole> keyholes_ = profile.world_.keyholes_;
					string key = array[num];
					if (!((MapField<TKey, TValue>)(object)keyholes_).TryGetValue((TKey)key, out *(TValue*)num) || Keyhole.IsKeyholeCompleted((Keyhole)num))
					{
					}
					num++;
				}
				if (num2 == 0)
				{
					break;
				}
				RepeatedField<MissionSubStep> subSteps_ = missionStep.subSteps_;
				int index = 0;
				RepeatedField<MissionObjective> objectives_ = ((MissionSubStep)((RepeatedField<T>)(object)subSteps_)[index]).objectives_;
				int index2 = 0;
				MissionObjective missionObjective = (MissionObjective)((RepeatedField<T>)(object)objectives_)[index2];
				return;
			}
			MissionStep missionStep2 = default(MissionStep);
			IEnumerable<MissionObjective> allObjectives = (IEnumerable<MissionObjective>)missionStep2.get_AllObjectives();
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
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E23")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public UrsulaKeyholePossessProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
