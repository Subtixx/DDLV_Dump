using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Missions
{
	[Cpp2IlInjected.Token(Token = "0x200025B")]
	public enum MissionSlotState
	{
		[Cpp2IlInjected.Token(Token = "0x4000961")]
		[OriginalName("MissionSlotState_Invalid")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000962")]
		[OriginalName("MissionSlotState_Available")]
		Available,
		[Cpp2IlInjected.Token(Token = "0x4000963")]
		[OriginalName("MissionSlotState_OnGoing")]
		OnGoing,
		[Cpp2IlInjected.Token(Token = "0x4000964")]
		[OriginalName("MissionSlotState_Completed")]
		Completed
	}
}
