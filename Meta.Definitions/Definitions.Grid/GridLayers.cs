using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x20006E1")]
	public enum GridLayers
	{
		[Cpp2IlInjected.Token(Token = "0x40022ED")]
		[OriginalName("GridLayers_None")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40022EE")]
		[OriginalName("GridLayers_Ground")]
		Ground = 1,
		[Cpp2IlInjected.Token(Token = "0x40022EF")]
		[OriginalName("GridLayers_Floor")]
		Floor = 2,
		[Cpp2IlInjected.Token(Token = "0x40022F0")]
		[OriginalName("GridLayers_Low")]
		Low = 4,
		[Cpp2IlInjected.Token(Token = "0x40022F1")]
		[OriginalName("GridLayers_Medium")]
		Medium = 8,
		[Cpp2IlInjected.Token(Token = "0x40022F2")]
		[OriginalName("GridLayers_High")]
		High = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40022F3")]
		[OriginalName("GridLayers_Clear")]
		Clear = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40022F4")]
		[OriginalName("GridLayers_Blocking")]
		Blocking = 0x40
	}
}
