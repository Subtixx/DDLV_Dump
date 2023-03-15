using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005F0")]
	public enum EphemeralType
	{
		[Cpp2IlInjected.Token(Token = "0x400205E")]
		[OriginalName("EphemeralType_NightThorn")]
		NightThorn,
		[Cpp2IlInjected.Token(Token = "0x400205F")]
		[OriginalName("EphemeralType_QuestItem")]
		QuestItem,
		[Cpp2IlInjected.Token(Token = "0x4002060")]
		[OriginalName("EphemeralType_Other")]
		Other
	}
}
