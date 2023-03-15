using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200069B")]
	public interface IHasUnlockConditions
	{
		[Cpp2IlInjected.Token(Token = "0x1700137C")]
		CatalogVisibilityConditions CatalogVisibilityConditions
		{
			[Cpp2IlInjected.Token(Token = "0x6004AF0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
