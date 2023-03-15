using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200060D")]
	public enum MissionStepStatus
	{
		[Cpp2IlInjected.Token(Token = "0x4002135")]
		[OriginalName("MissionStepStatus_NotStarted")]
		NotStarted,
		[Cpp2IlInjected.Token(Token = "0x4002136")]
		[OriginalName("MissionStepStatus_Ongoing")]
		Ongoing,
		[Cpp2IlInjected.Token(Token = "0x4002137")]
		[OriginalName("MissionStepStatus_ReadyToBeCompleted")]
		ReadyToBeCompleted,
		[Cpp2IlInjected.Token(Token = "0x4002138")]
		[OriginalName("MissionStepStatus_Completed")]
		Completed,
		[Cpp2IlInjected.Token(Token = "0x4002139")]
		[OriginalName("MissionStepStatus_Confirmed")]
		Confirmed
	}
}
