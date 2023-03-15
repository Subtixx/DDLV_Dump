using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using glPlayFab.Disney;
using Google.Protobuf.Collections;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AF2")]
	internal class OldPickledHerringProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005DB8")]
		[Cpp2IlInjected.Address(RVA = "0x13A1AC0", Offset = "0x13A04C0", VA = "0x1813A1AC0", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_0058, IL_005e, IL_0064, IL_006a
			//IL_0038: Expected O, but got I4
			//IL_004c: Expected I4, but got I8
			//IL_004c: Expected O, but got I4
			ICollection<ContainerInventory> values;
			uint num4 = default(uint);
			bool flag = default(bool);
			uint value = default(uint);
			long num5 = default(long);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				values = (ICollection<ContainerInventory>)((MapField<TKey, TValue>)(object)profile.player_.containerInventories_).get_Values();
				if (values == null)
				{
					break;
				}
				if (num3 < (int)num4)
				{
					num3 += num3;
					if (num3 == (int)num4)
					{
						goto IL_004c;
					}
					num3++;
				}
				if (!flag)
				{
					break;
				}
				if (((BattlePassReward)num2).Price == 0)
				{
					continue;
				}
				num5 = Convert.ToInt64(value);
				((BattlePassReward)num2).Price = (int)num5;
				goto IL_004c;
				IL_004c:
				num5 += num5;
				break;
			}
			if (values == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DB9")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public OldPickledHerringProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
