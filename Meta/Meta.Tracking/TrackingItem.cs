using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A91")]
	public class TrackingItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002954")]
		public int itemAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002955")]
		public string itemName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002956")]
		public string itemType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002957")]
		public int itemRarity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002958")]
		public Dictionary<string, string> ItemTraits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002959")]
		public Dictionary<TagItemType, string> ItemTags;

		[Cpp2IlInjected.Token(Token = "0x6005B83")]
		[Cpp2IlInjected.Address(RVA = "0x78D480", Offset = "0x78BE80", VA = "0x18078D480")]
		public unsafe TrackingItem(int itemAmount, string itemName, string itemType, int itemRarity, Dictionary<string, string> ItemTraits, Dictionary<TagItemType, string> ItemTags)
		{
			//IL_000b: Expected O, but got I4
			//IL_0027: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			int num = 0;
			base.FieldGetter((string)num, itemName, ref *(object*)itemType);
			this.itemName = itemName;
			this.itemAmount = itemAmount;
			this.itemType = itemType;
			this.ItemTraits = (Dictionary<string, string>)0;
			this.itemRarity = 0;
			this.ItemTags = (Dictionary<TagItemType, string>)0;
			/*Error: Unexpected end of block*/;
		}
	}
}
