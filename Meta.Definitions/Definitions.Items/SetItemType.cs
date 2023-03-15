using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000625")]
	public enum SetItemType
	{
		[Cpp2IlInjected.Token(Token = "0x40021CC")]
		[OriginalName("SetItemType_Furniture")]
		Furniture,
		[Cpp2IlInjected.Token(Token = "0x40021CD")]
		[OriginalName("SetItemType_Clothing")]
		Clothing,
		[Cpp2IlInjected.Token(Token = "0x40021CE")]
		[OriginalName("SetItemType_Decal")]
		Decal,
		[Cpp2IlInjected.Token(Token = "0x40021CF")]
		[OriginalName("SetItemType_Makeup")]
		Makeup
	}
}
