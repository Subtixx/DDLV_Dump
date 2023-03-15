using System;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Meta.Grids;
using Meta.Missions;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B04")]
	internal class Ariel020MemoryShardProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005DE4")]
		[Cpp2IlInjected.Address(RVA = "0x18EAAD0", Offset = "0x18E94D0", VA = "0x1818EAAD0", Slot = "5")]
		protected unsafe override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_00cf
			//IL_005c: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_00cc: Expected O, but got I4
			int num = 0;
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
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionStepData x) => string.Equals(x.stepName_, "Group11"));
			}
			int num2 = default(int);
			if (missionSlot.currentStepIndex_ != num2 || !((MapField<TKey, TValue>)(object)profile.conditionalEventHistory_.activeEvents_).TryGetValue((TKey)num2, out *(TValue*)num))
			{
				return;
			}
			SpawnActionState spawnActionState = default(SpawnActionState);
			RepeatedField<GridObjectAddress> spawnedObjects_ = spawnActionState.spawnedObjects_;
			int index = 0;
			GridObjectAddress gridObjectAddress = (GridObjectAddress)((RepeatedField<T>)(object)spawnedObjects_)[index];
			GridCollection gridCollection_ = profile.world_.gridCollection_;
			uint gridID_ = gridObjectAddress.gridID_;
			if (gridCollection_.TryGetGrid(gridID_, out *(IGrid*)num))
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				if (num == 0 && !profile.player_.HasItem((Item)num))
				{
					bool flag2 = ((MapField<TKey, TValue>)(object)profile.conditionalEventHistory_.activeEvents_).Remove((TKey)num2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DE5")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public Ariel020MemoryShardProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
