using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200061F")]
	public enum MissionItemType
	{
		[Cpp2IlInjected.Token(Token = "0x40021B9")]
		[OriginalName("MissionItemType_MissionData")]
		MissionData,
		[Cpp2IlInjected.Token(Token = "0x40021BA")]
		[OriginalName("MissionItemType_ScalingScript")]
		ScalingScript,
		[Cpp2IlInjected.Token(Token = "0x40021BB")]
		[OriginalName("MissionItemType_MissionQuest")]
		MissionQuest
	}
}
