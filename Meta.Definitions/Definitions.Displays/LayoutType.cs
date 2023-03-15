using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Displays
{
	[Cpp2IlInjected.Token(Token = "0x2000749")]
	public enum LayoutType
	{
		[Cpp2IlInjected.Token(Token = "0x4002469")]
		[OriginalName("OneItem")]
		OneItem,
		[Cpp2IlInjected.Token(Token = "0x400246A")]
		[OriginalName("TwoItemsMirror")]
		TwoItemsMirror,
		[Cpp2IlInjected.Token(Token = "0x400246B")]
		[OriginalName("TwoItemsCorner")]
		TwoItemsCorner,
		[Cpp2IlInjected.Token(Token = "0x400246C")]
		[OriginalName("FourItems")]
		FourItems,
		[Cpp2IlInjected.Token(Token = "0x400246D")]
		[OriginalName("Auto")]
		Auto
	}
}
