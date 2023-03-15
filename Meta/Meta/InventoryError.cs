using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum InventoryError
	{
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[OriginalName("InventoryError_None")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[OriginalName("InventoryError_InvalidInventory")]
		InvalidInventory,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[OriginalName("InventoryError_InvalidItem")]
		InvalidItem,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[OriginalName("InventoryError_InventoryFull")]
		InventoryFull,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[OriginalName("InventoryError_NotInInventory")]
		NotInInventory
	}
}
