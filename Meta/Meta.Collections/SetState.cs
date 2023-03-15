using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2001118")]
	public enum SetState
	{
		[Cpp2IlInjected.Token(Token = "0x4004671")]
		[OriginalName("SetState_NotComplete")]
		NotComplete,
		[Cpp2IlInjected.Token(Token = "0x4004672")]
		[OriginalName("SetState_Completed")]
		Completed,
		[Cpp2IlInjected.Token(Token = "0x4004673")]
		[OriginalName("SetState_RewardGiven")]
		RewardGiven
	}
}
