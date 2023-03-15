using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000657")]
	public interface IAppraisableItemData
	{
		[Cpp2IlInjected.Token(Token = "0x1700131F")]
		int Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x6004A4C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001320")]
		Quality Quality
		{
			[Cpp2IlInjected.Token(Token = "0x6004A4D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
