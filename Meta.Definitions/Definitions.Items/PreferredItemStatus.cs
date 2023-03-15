using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000613")]
	public enum PreferredItemStatus
	{
		[Cpp2IlInjected.Token(Token = "0x400216A")]
		[OriginalName("PreferredItemStatus_Unknown")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x400216B")]
		[OriginalName("PreferredItemStatus_Category")]
		Category,
		[Cpp2IlInjected.Token(Token = "0x400216C")]
		[OriginalName("PreferredItemStatus_Discovered")]
		Discovered
	}
}
