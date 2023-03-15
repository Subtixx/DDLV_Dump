using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000642")]
	public interface ISubItem
	{
		[Cpp2IlInjected.Token(Token = "0x6004A09")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Item ToItem();

		[Cpp2IlInjected.Token(Token = "0x6004A0A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int ToInt();
	}
}
