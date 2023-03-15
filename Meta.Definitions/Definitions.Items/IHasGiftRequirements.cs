using Cpp2IlInjected;
using Definitions.Util;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200066F")]
	public interface IHasGiftRequirements
	{
		[Cpp2IlInjected.Token(Token = "0x6004A7F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool IsGiftableTo(IProfile profile, Item giftTarget);
	}
}
