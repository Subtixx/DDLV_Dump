using Cpp2IlInjected;
using Definitions.Items;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x20010F5")]
	public interface IFurniture
	{
		[Cpp2IlInjected.Token(Token = "0x1700182E")]
		Item FurnitureItem
		{
			[Cpp2IlInjected.Token(Token = "0x6008A3F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700182F")]
		int CurrentDesign
		{
			[Cpp2IlInjected.Token(Token = "0x6008A40")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
