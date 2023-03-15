using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Grid;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Meta.Grids;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B09")]
	internal class VillageGridDataChangesProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005DEF")]
		[Cpp2IlInjected.Address(RVA = "0x15E1630", Offset = "0x15E0030", VA = "0x1815E1630", Slot = "5")]
		protected unsafe override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_0056, IL_005c
			//IL_0021: Expected O, but got I4
			int num;
			ICollection<> collection = default(ICollection<>);
			GridPosition gridPosition = default(GridPosition);
			bool flag = default(bool);
			do
			{
				num = 0;
				ProfileWorld world_ = profile.world_;
				GridCollection gridCollection_ = world_.gridCollection_;
				uint gridID_ = ((Village.Types.VillageArea)((MapField<TKey, TValue>)(object)world_.village_.areas_)[(TKey)1]).gridID_;
				if (!gridCollection_.TryGetGrid(gridID_, out *(IGrid*)num) || num == 0 || num == 0)
				{
					break;
				}
				if (collection != null)
				{
					while ((long)gridPosition >= 90)
					{
					}
					while (!flag)
					{
					}
				}
				if (collection != null)
				{
				}
			}
			while (num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6005DF0")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public VillageGridDataChangesProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
