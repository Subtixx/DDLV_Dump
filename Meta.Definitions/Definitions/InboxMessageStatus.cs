using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public enum InboxMessageStatus
	{
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		[OriginalName("Unread")]
		Unread,
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		[OriginalName("Read")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		[OriginalName("Claimed")]
		Claimed,
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		[OriginalName("Unclaimable")]
		Unclaimable,
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		[OriginalName("Expired")]
		Expired,
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		[OriginalName("Invalid")]
		Invalid
	}
}
