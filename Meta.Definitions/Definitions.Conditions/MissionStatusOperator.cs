using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000837")]
	public enum MissionStatusOperator
	{
		[Cpp2IlInjected.Token(Token = "0x40028C8")]
		[OriginalName("MissionStatusOperator_NotStarted")]
		NotStarted,
		[Cpp2IlInjected.Token(Token = "0x40028C9")]
		[OriginalName("MissionStatusOperator_StartedOrCompleted")]
		StartedOrCompleted,
		[Cpp2IlInjected.Token(Token = "0x40028CA")]
		[OriginalName("MissionStatusOperator_OnGoing")]
		OnGoing,
		[Cpp2IlInjected.Token(Token = "0x40028CB")]
		[OriginalName("MissionStatusOperator_NotOnGoing")]
		NotOnGoing,
		[Cpp2IlInjected.Token(Token = "0x40028CC")]
		[OriginalName("MissionStatusOperator_Completed")]
		Completed,
		[Cpp2IlInjected.Token(Token = "0x40028CD")]
		[OriginalName("MissionStatusOperator_NotCompleted")]
		NotCompleted,
		[Cpp2IlInjected.Token(Token = "0x40028CE")]
		[OriginalName("MissionStatusOperator_ReadyToBeCompleted")]
		ReadyToBeCompleted,
		[Cpp2IlInjected.Token(Token = "0x40028CF")]
		[OriginalName("MissionStatusOperator_NotReadyToBeCompleted")]
		NotReadyToBeCompleted
	}
}
