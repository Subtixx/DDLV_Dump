using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000836")]
	public enum MissionStateOperator
	{
		[Cpp2IlInjected.Token(Token = "0x40028BF")]
		[OriginalName("MissionStateOperator_NotAvailableYet")]
		NotAvailableYet,
		[Cpp2IlInjected.Token(Token = "0x40028C0")]
		[OriginalName("MissionStateOperator_AvailableOrMore")]
		AvailableOrMore,
		[Cpp2IlInjected.Token(Token = "0x40028C1")]
		[OriginalName("MissionStateOperator_Available")]
		Available,
		[Cpp2IlInjected.Token(Token = "0x40028C2")]
		[OriginalName("MissionStateOperator_NotAvailable")]
		NotAvailable,
		[Cpp2IlInjected.Token(Token = "0x40028C3")]
		[OriginalName("MissionStateOperator_OnGoing")]
		OnGoing,
		[Cpp2IlInjected.Token(Token = "0x40028C4")]
		[OriginalName("MissionStateOperator_NotOnGoing")]
		NotOnGoing,
		[Cpp2IlInjected.Token(Token = "0x40028C5")]
		[OriginalName("MissionStateOperator_Completed")]
		Completed,
		[Cpp2IlInjected.Token(Token = "0x40028C6")]
		[OriginalName("MissionStateOperator_NotCompleted")]
		NotCompleted
	}
}
