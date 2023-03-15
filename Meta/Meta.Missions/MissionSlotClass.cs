using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta.Missions
{
	[Cpp2IlInjected.Token(Token = "0x2000FEC")]
	public enum MissionSlotClass
	{
		[Cpp2IlInjected.Token(Token = "0x4004164")]
		[OriginalName("Story")]
		Story,
		[Cpp2IlInjected.Token(Token = "0x4004165")]
		[OriginalName("Village")]
		Village,
		[Cpp2IlInjected.Token(Token = "0x4004166")]
		[OriginalName("EventStory")]
		EventStory,
		[Cpp2IlInjected.Token(Token = "0x4004167")]
		[OriginalName("EventSystemic")]
		EventSystemic,
		[Cpp2IlInjected.Token(Token = "0x4004168")]
		[OriginalName("TimeLimitedEvent")]
		TimeLimitedEvent,
		[Cpp2IlInjected.Token(Token = "0x4004169")]
		[OriginalName("Secret")]
		Secret
	}
}
