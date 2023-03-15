using Cpp2IlInjected;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20009AF")]
	public enum SlotUpdatedReason
	{
		[Cpp2IlInjected.Token(Token = "0x400281C")]
		AnyChanges,
		[Cpp2IlInjected.Token(Token = "0x400281D")]
		Generated,
		[Cpp2IlInjected.Token(Token = "0x400281E")]
		Started,
		[Cpp2IlInjected.Token(Token = "0x400281F")]
		Completed,
		[Cpp2IlInjected.Token(Token = "0x4002820")]
		Cancelled
	}
}
