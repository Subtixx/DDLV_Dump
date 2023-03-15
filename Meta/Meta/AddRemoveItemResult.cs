using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20007D9")]
	public enum AddRemoveItemResult
	{
		[Cpp2IlInjected.Token(Token = "0x4001F30")]
		[OriginalName("AddRemoveItemResult_Success")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x4001F31")]
		[OriginalName("AddRemoveItemResult_InvalidItem")]
		InvalidItem,
		[Cpp2IlInjected.Token(Token = "0x4001F32")]
		[OriginalName("AddRemoveItemResult_InventoryFull")]
		InventoryFull,
		[Cpp2IlInjected.Token(Token = "0x4001F33")]
		[OriginalName("AddRemoveItemResult_InvalidInventory")]
		InvalidInventory,
		[Cpp2IlInjected.Token(Token = "0x4001F34")]
		[OriginalName("AddRemoveItemResult_NotInInventory")]
		NotInInventory,
		[Cpp2IlInjected.Token(Token = "0x4001F35")]
		[OriginalName("AddRemoveItemResult_InvalidCharacter")]
		InvalidCharacter,
		[Cpp2IlInjected.Token(Token = "0x4001F36")]
		[OriginalName("AddRemoveItemResult_MemoryShardAlreadyCollected")]
		MemoryShardAlreadyCollected
	}
}
