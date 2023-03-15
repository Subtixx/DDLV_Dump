using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Meta.Grids;
using Meta.Missions;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AFE")]
	internal class UrsulaPaperProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005DD6")]
		[Cpp2IlInjected.Address(RVA = "0x15DDA90", Offset = "0x15DC490", VA = "0x1815DDA90", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_00c2, IL_00c8, IL_00ce, IL_00d4, IL_00da, IL_00e0, IL_00e6, IL_00ec, IL_00f2, IL_00f8, IL_00fe
			//IL_00ac: Expected O, but got I4
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
			int currentStepIndex_ = missionSlot.currentStepIndex_;
			MissionStepData missionStepData = default(MissionStepData);
			string stepName_ = missionStepData.stepName_;
			if (missionStepData == null)
			{
				return;
			}
			ProfilePlayer player_ = profile.player_;
			List<uint> list = (List<uint>)(object)new List<T>();
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
						goto IL_0099;
					}
					num++;
				}
				if (collection != null)
				{
					while (collection == null)
					{
					}
					if (profile.gameInfo_ != null)
					{
						num3 = 0;
						AmountWithState amountWithState = default(AmountWithState);
						if (amountWithState != null)
						{
							int? amount_ = amountWithState.amount_;
							goto IL_0099;
						}
					}
					goto IL_00a0;
				}
				goto IL_00ac;
			}
			goto IL_00b1;
			IL_00ac:
			if (collection == null)
			{
			}
			goto IL_00b1;
			IL_00b1:
			if (values != null)
			{
			}
			int num4 = num4 + num;
			if (num4 >= 3)
			{
			}
			return;
			IL_00a0:
			num += num;
			((List<T>)(object)list).Add((T)num);
			goto IL_00ac;
			IL_0099:
			num3 += num3;
			goto IL_00a0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005DD7")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public UrsulaPaperProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
