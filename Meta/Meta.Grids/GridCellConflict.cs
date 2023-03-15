using System;
using Cpp2IlInjected;

namespace Meta.Grids
{
	[Cpp2IlInjected.Token(Token = "0x200108A")]
	[Flags]
	public enum GridCellConflict
	{
		[Cpp2IlInjected.Token(Token = "0x4004447")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4004448")]
		Void = 1,
		[Cpp2IlInjected.Token(Token = "0x4004449")]
		FloorType = 2,
		[Cpp2IlInjected.Token(Token = "0x400444A")]
		GridObjects = 4,
		[Cpp2IlInjected.Token(Token = "0x400444B")]
		Clearable = 8,
		[Cpp2IlInjected.Token(Token = "0x400444C")]
		All = 0xF
	}
}
