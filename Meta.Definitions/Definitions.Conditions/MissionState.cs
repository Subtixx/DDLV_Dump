using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000835")]
	public enum MissionState
	{
		[Cpp2IlInjected.Token(Token = "0x40028BA")]
		[OriginalName("MissionState_NotAvailableYet")]
		NotAvailableYet = 0,
		[Cpp2IlInjected.Token(Token = "0x40028BB")]
		[OriginalName("MissionState_Available")]
		Available = 2,
		[Cpp2IlInjected.Token(Token = "0x40028BC")]
		[OriginalName("MissionState_OnGoing")]
		OnGoing = 4,
		[Cpp2IlInjected.Token(Token = "0x40028BD")]
		[OriginalName("MissionState_Completed")]
		Completed = 8
	}
}
