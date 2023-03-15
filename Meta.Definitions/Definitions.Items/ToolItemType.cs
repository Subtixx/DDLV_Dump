using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000629")]
	public enum ToolItemType
	{
		[Cpp2IlInjected.Token(Token = "0x40021E3")]
		[OriginalName("ToolItemType_Gardening")]
		Gardening = 0,
		[Cpp2IlInjected.Token(Token = "0x40021E4")]
		[OriginalName("ToolItemType_Fishing")]
		Fishing = 1,
		[Cpp2IlInjected.Token(Token = "0x40021E5")]
		[OriginalName("ToolItemType_Mining")]
		Mining = 4,
		[Cpp2IlInjected.Token(Token = "0x40021E6")]
		[OriginalName("ToolItemType_Watering")]
		Watering = 5,
		[Cpp2IlInjected.Token(Token = "0x40021E7")]
		[OriginalName("ToolItemType_Misc")]
		Misc = 6
	}
}
