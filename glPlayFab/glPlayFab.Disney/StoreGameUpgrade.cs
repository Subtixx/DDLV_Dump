using Cpp2IlInjected;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	public class StoreGameUpgrade : StoreDefinition
	{
		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public override StoreType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x8C8560", Offset = "0x8C6F60", VA = "0x1808C8560", Slot = "4")]
			get
			{
				return StoreType.GameUpgrade;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public StoreGameUpgrade()
		{
		}
	}
}
