using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public enum ItemsSentToInboxReason
	{
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[OriginalName("ItemsSentToInboxReason_None")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[OriginalName("ItemsSentToInboxReason_InventoryFull")]
		InventoryFull,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[OriginalName("ItemsSentToInboxReason_SubgridItemRemoval")]
		SubgridItemRemoval
	}
}
