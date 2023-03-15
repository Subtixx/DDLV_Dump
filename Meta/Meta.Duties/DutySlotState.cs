using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta.Duties
{
	[Cpp2IlInjected.Token(Token = "0x20010D1")]
	public enum DutySlotState
	{
		[Cpp2IlInjected.Token(Token = "0x4004539")]
		[OriginalName("DutySlotState_None")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400453A")]
		[OriginalName("DutySlotState_NotStarted")]
		NotStarted,
		[Cpp2IlInjected.Token(Token = "0x400453B")]
		[OriginalName("DutySlotState_OnGoing")]
		OnGoing,
		[Cpp2IlInjected.Token(Token = "0x400453C")]
		[OriginalName("DutySlotState_Completed")]
		Completed,
		[Cpp2IlInjected.Token(Token = "0x400453D")]
		[OriginalName("DutySlotState_RewardsClaimed")]
		RewardsClaimed
	}
}
