using Cpp2IlInjected;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A3C")]
	public interface IInventoryFullRequest
	{
		[Cpp2IlInjected.Token(Token = "0x17000EAA")]
		InventoryFullResolution InventoryFullResolution
		{
			[Cpp2IlInjected.Token(Token = "0x60058A2")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60058A3")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
}
