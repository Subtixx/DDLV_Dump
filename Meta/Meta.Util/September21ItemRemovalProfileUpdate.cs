using System;
using Cpp2IlInjected;
using Definitions.Items;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AE0")]
	internal class September21ItemRemovalProfileUpdate : RemoveFurnitureProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D83")]
		[Cpp2IlInjected.Address(RVA = "0x1773660", Offset = "0x1772060", VA = "0x181773660")]
		public September21ItemRemovalProfileUpdate()
		{
			//Discarded unreachable code: IL_0037
			//IL_001b: Expected O, but got I8
			//IL_002f: Expected O, but got I8
			Item[] array = new Item[2];
			array[0] = (Item)Convert.ToInt64(40001304u);
			array[0] = (Item)Convert.ToInt64(40001321u);
			base._002Ector(array);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D84")]
		[Cpp2IlInjected.Address(RVA = "0x1773580", Offset = "0x1771F80", VA = "0x181773580", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_001f
			Item[] array = new Item[2];
			array[0] = (Item)array;
			array[0] = (Item)array;
			ProfileUpdateCommonMethods.RemoveTrimmingItems(profile, array);
		}
	}
}
