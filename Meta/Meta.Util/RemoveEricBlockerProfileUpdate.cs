using System;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AD8")]
	internal class RemoveEricBlockerProfileUpdate : RemoveFurnitureProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D75")]
		[Cpp2IlInjected.Address(RVA = "0x5C7470", Offset = "0x5C5E70", VA = "0x1805C7470")]
		public RemoveEricBlockerProfileUpdate()
		{
			//IL_001b: Expected O, but got I8
			Item[] array = new Item[1];
			array[0] = (Item)Convert.ToInt64(40600058u);
			((BattlePassReward)(object)this)._002Ector();
			base.furnitureItemsToDelete = array;
			throw new NullReferenceException();
		}
	}
}
