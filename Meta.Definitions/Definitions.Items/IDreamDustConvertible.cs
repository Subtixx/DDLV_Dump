using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000680")]
	public interface IDreamDustConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x1700135A")]
		Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6004ABC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700135B")]
		int DreamDustOverrideValue
		{
			[Cpp2IlInjected.Token(Token = "0x6004ABD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
