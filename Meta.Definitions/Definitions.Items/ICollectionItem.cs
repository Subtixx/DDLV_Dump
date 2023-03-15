using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006AA")]
	public interface ICollectionItem
	{
		[Cpp2IlInjected.Token(Token = "0x17001387")]
		Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6004B03")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001388")]
		bool CanBeCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6004B04")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
