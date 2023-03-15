using Cpp2IlInjected;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A3D")]
	public interface IInventoryFullResponse
	{
		[Cpp2IlInjected.Token(Token = "0x17000EAB")]
		InventoryFullDetails InventoryFullDetails
		{
			[Cpp2IlInjected.Token(Token = "0x60058A4")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60058A5")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
}
