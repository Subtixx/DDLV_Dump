using Cpp2IlInjected;
using Definitions.Items;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x200023F")]
	public class SubTypeNullFilter : ISubTypeFilter
	{
		[Cpp2IlInjected.Token(Token = "0x600157A")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "4")]
		public bool IsValid(ItemDatabase itemDb, Item item)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600157B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public SubTypeNullFilter()
		{
		}
	}
}
