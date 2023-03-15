using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20007DB")]
	public enum MilestoneState
	{
		[Cpp2IlInjected.Token(Token = "0x4001F3D")]
		[OriginalName("MilestoneState_None")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4001F3E")]
		[OriginalName("MilestoneState_NotStarted")]
		NotStarted,
		[Cpp2IlInjected.Token(Token = "0x4001F3F")]
		[OriginalName("MilestoneState_OnGoing")]
		OnGoing,
		[Cpp2IlInjected.Token(Token = "0x4001F40")]
		[OriginalName("MilestoneState_Completed")]
		Completed,
		[Cpp2IlInjected.Token(Token = "0x4001F41")]
		[OriginalName("MilestoneState_RewardsClaimed")]
		RewardsClaimed
	}
}
