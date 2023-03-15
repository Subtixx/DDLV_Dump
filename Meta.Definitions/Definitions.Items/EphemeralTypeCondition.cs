using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005F1")]
	public enum EphemeralTypeCondition
	{
		[Cpp2IlInjected.Token(Token = "0x4002062")]
		[OriginalName("EphemeralTypeCondition_Any")]
		Any,
		[Cpp2IlInjected.Token(Token = "0x4002063")]
		[OriginalName("EphemeralTypeCondition_NightThorn")]
		NightThorn,
		[Cpp2IlInjected.Token(Token = "0x4002064")]
		[OriginalName("EphemeralTypeCondition_QuestItem")]
		QuestItem,
		[Cpp2IlInjected.Token(Token = "0x4002065")]
		[OriginalName("EphemeralTypeCondition_Other")]
		Other
	}
}
