using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005E2")]
	public enum DialogueItemType
	{
		[Cpp2IlInjected.Token(Token = "0x4002012")]
		[OriginalName("DialogueItemType_Greeting")]
		Greeting,
		[Cpp2IlInjected.Token(Token = "0x4002013")]
		[OriginalName("DialogueItemType_Discussion")]
		Discussion,
		[Cpp2IlInjected.Token(Token = "0x4002014")]
		[OriginalName("DialogueItemType_Callout")]
		Callout,
		[Cpp2IlInjected.Token(Token = "0x4002015")]
		[OriginalName("DialogueItemType_NpcDiscussion")]
		NpcDiscussion,
		[Cpp2IlInjected.Token(Token = "0x4002016")]
		[OriginalName("DialogueItemType_GiftThanks")]
		GiftThanks,
		[Cpp2IlInjected.Token(Token = "0x4002017")]
		[OriginalName("DialogueItemType_Flag")]
		Flag,
		[Cpp2IlInjected.Token(Token = "0x4002018")]
		[OriginalName("DialogueItemType_Hangout")]
		Hangout
	}
}
