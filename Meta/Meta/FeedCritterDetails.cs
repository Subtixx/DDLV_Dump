using Cpp2IlInjected;
using Definitions.Items;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20009B3")]
	public class FeedCritterDetails
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002831")]
		public readonly Item Item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4002832")]
		public readonly FeedCritter.Types.CritterReaction Reaction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002833")]
		public readonly bool FirstFeedingToday;

		[Cpp2IlInjected.Token(Token = "0x6005484")]
		[Cpp2IlInjected.Address(RVA = "0x17F95E0", Offset = "0x17F7FE0", VA = "0x1817F95E0")]
		public FeedCritterDetails(Item item, FeedCritter.Types.CritterReaction reaction, bool firstFeedingToday)
		{
			//IL_0016: Expected O, but got I4
			int itemID = item.ItemID;
			base._002Ector();
			Item = (Item)itemID;
			Reaction = reaction;
			FirstFeedingToday = firstFeedingToday;
		}
	}
}
