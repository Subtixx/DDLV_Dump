using System;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000644")]
	[Flags]
	public enum ExpandHouseEventType
	{
		[Cpp2IlInjected.Token(Token = "0x4002231")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4002232")]
		RoomExpanded = 1,
		[Cpp2IlInjected.Token(Token = "0x4002233")]
		RoomAdded = 2,
		[Cpp2IlInjected.Token(Token = "0x4002234")]
		FloorAdded = 4
	}
}
