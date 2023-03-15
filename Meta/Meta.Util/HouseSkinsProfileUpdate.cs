using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;
using Google.Protobuf.Collections;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B0F")]
	internal class HouseSkinsProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005E01")]
		[Cpp2IlInjected.Address(RVA = "0x1705A60", Offset = "0x1704460", VA = "0x181705A60", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_009e
			//IL_0015: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			//IL_0047: Expected I4, but got I8
			int num = ((RepeatedField<T>)(object)profile.world_.unlockedBuildings_).IndexOf((T)20000013);
			if (num != -1)
			{
				((RepeatedField<T>)(object)profile.world_.unlockedBuildings_)[num] = (T)20500000;
			}
			profile.world_.playerHouse_.houseItemID_ = 20500000;
			Item[] array = new Item[5];
			array[0] = (Item)array;
			array[0] = (Item)array;
			array[1] = (Item)array;
			array[1] = (Item)array;
			int num2 = 0;
			array[2] = (Item)array;
			int length = array.Length;
			if (num2 < length)
			{
				Item item = array[num2];
				ListInventory buildings = profile.player_.Buildings;
				num2++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E02")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public HouseSkinsProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
