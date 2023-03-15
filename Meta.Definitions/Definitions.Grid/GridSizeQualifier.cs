using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x20006E3")]
	public enum GridSizeQualifier
	{
		[Cpp2IlInjected.Token(Token = "0x4002305")]
		[OriginalName("GridSizeQualifier_None")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4002306")]
		[OriginalName("GridSizeQualifier_Small")]
		Small,
		[Cpp2IlInjected.Token(Token = "0x4002307")]
		[OriginalName("GridSizeQualifier_Medium")]
		Medium,
		[Cpp2IlInjected.Token(Token = "0x4002308")]
		[OriginalName("GridSizeQualifier_Large")]
		Large,
		[Cpp2IlInjected.Token(Token = "0x4002309")]
		[OriginalName("GridSizeQualifier_Huge")]
		Huge
	}
}
