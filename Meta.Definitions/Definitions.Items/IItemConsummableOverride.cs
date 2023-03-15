using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200066B")]
	public interface IItemConsummableOverride
	{
		[Cpp2IlInjected.Token(Token = "0x1700134A")]
		Item? ConsummableOverrideItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004A7B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
