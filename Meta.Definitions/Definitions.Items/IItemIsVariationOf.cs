using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006A8")]
	public interface IItemIsVariationOf
	{
		[Cpp2IlInjected.Token(Token = "0x17001385")]
		int IsVariationOf
		{
			[Cpp2IlInjected.Token(Token = "0x6004B00")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001386")]
		Item IsVariationOfItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004B01")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
