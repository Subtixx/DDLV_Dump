using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006CF")]
	[Flags]
	public enum ItemEditStatus
	{
		[Cpp2IlInjected.Token(Token = "0x40022B5")]
		NoChanges = 0,
		[Cpp2IlInjected.Token(Token = "0x40022B6")]
		Invalid = 1,
		[Cpp2IlInjected.Token(Token = "0x40022B7")]
		Renamed = 2,
		[Cpp2IlInjected.Token(Token = "0x40022B8")]
		Deleted = 4
	}
}
