using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;
using Newtonsoft.Json.Linq;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AC5")]
	internal abstract class RemoveClothingProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002AF6")]
		private readonly Item[] clothingItemsToDelete;

		[Cpp2IlInjected.Token(Token = "0x6005D4D")]
		[Cpp2IlInjected.Address(RVA = "0x5C7440", Offset = "0x5C5E40", VA = "0x1805C7440")]
		protected RemoveClothingProfileUpdate(Item[] clothingItemsToDelete)
		{
			((BattlePassReward)(object)this)._002Ector();
			this.clothingItemsToDelete = clothingItemsToDelete;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D4E")]
		[Cpp2IlInjected.Address(RVA = "0x5C7400", Offset = "0x5C5E00", VA = "0x1805C7400", Slot = "4")]
		protected override void DoApplyJson(JObject profile)
		{
			Item[] array = clothingItemsToDelete;
			ProfileUpdateCommonMethods.RemoveItemsInListInventory(profile, 1u, (IEnumerable<>)(object)array);
			Item[] array2 = clothingItemsToDelete;
			ProfileUpdateCommonMethods.RemoveItemsInCollections(profile, (IEnumerable<>)(object)array2);
		}
	}
}
