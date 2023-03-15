using System.Collections.Generic;
using Cpp2IlInjected;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Meta.Grids;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B13")]
	internal class StorageManagementProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005E09")]
		[Cpp2IlInjected.Address(RVA = "0xC09620", Offset = "0xC08020", VA = "0x180C09620", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_0081, IL_0087, IL_008d, IL_0093, IL_0099, IL_009f, IL_00a5
			int num = 0;
			ICollection<Grid> values = (ICollection<Grid>)((MapField<TKey, TValue>)(object)profile.world_.gridCollection_.grids_).get_Values();
			uint num2 = default(uint);
			if (values != null && num < (int)num2)
			{
				num += num;
				if (num != (int)num2)
				{
					num++;
				}
			}
			int num3 = 0;
			if (values != null)
			{
			}
			ICollection<DiffGrid> values2 = (ICollection<DiffGrid>)((MapField<TKey, TValue>)(object)profile.world_.gridCollection_.diffGrids_).get_Values();
			uint num4 = default(uint);
			if (num3 < (int)num4)
			{
				num3 += num3;
				num3++;
			}
			uint num5 = default(uint);
			if (values2 != null && num3 < (int)num5)
			{
				num3 += num3;
				if (num3 != (int)num5)
				{
					num3++;
				}
			}
			if (values2 == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E0A")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public StorageManagementProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
