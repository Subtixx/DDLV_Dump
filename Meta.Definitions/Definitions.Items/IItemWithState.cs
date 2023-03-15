using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006D2")]
	public interface IItemWithState
	{
		[Cpp2IlInjected.Token(Token = "0x1700139B")]
		int ItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6004C19")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700139C")]
		Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6004C1A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700139D")]
		ItemState State
		{
			[Cpp2IlInjected.Token(Token = "0x6004C1B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6004C1C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}
	}
}
