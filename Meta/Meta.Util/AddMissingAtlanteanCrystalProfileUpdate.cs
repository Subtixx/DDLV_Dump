using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;
using Google.Protobuf.Collections;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B1B")]
	internal class AddMissingAtlanteanCrystalProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005E1A")]
		[Cpp2IlInjected.Address(RVA = "0x18E5CA0", Offset = "0x18E46A0", VA = "0x1818E5CA0", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_003e, IL_0044, IL_004a
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			ICollection<ContainerInventory> values = (ICollection<ContainerInventory>)((MapField<TKey, TValue>)(object)profile.player_.containerInventories_).get_Values();
			if (values != null)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				num++;
			}
			num++;
			int num2 = 0;
			if (values != null)
			{
			}
			if (num == 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E1B")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public AddMissingAtlanteanCrystalProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
