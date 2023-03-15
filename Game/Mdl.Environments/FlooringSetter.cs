using Cpp2IlInjected;
using Definitions.Items;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000649")]
	public class FlooringSetter : TrimmingSetter
	{
		[Cpp2IlInjected.Token(Token = "0x170003F1")]
		public override TrimmingItemType HandledTrimmingItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6001C05")]
			[Cpp2IlInjected.Address(RVA = "0xD51100", Offset = "0xD4FB00", VA = "0x180D51100", Slot = "4")]
			get
			{
				return TrimmingItemType.Flooring;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C06")]
		[Cpp2IlInjected.Address(RVA = "0xD4DE40", Offset = "0xD4C840", VA = "0x180D4DE40")]
		public FlooringSetter()
		{
		}
	}
}
