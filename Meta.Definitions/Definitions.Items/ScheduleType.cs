using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005F9")]
	public enum ScheduleType
	{
		[Cpp2IlInjected.Token(Token = "0x4002099")]
		[OriginalName("ScheduleType_Any")]
		Any,
		[Cpp2IlInjected.Token(Token = "0x400209A")]
		[OriginalName("ScheduleType_Outdoor")]
		Outdoor,
		[Cpp2IlInjected.Token(Token = "0x400209B")]
		[OriginalName("ScheduleType_Indoor")]
		Indoor,
		[Cpp2IlInjected.Token(Token = "0x400209C")]
		[OriginalName("ScheduleType_Sleep")]
		Sleep,
		[Cpp2IlInjected.Token(Token = "0x400209D")]
		[OriginalName("ScheduleType_Shop")]
		Shop,
		[Cpp2IlInjected.Token(Token = "0x400209E")]
		[OriginalName("ScheduleType_Restaurant")]
		Restaurant,
		[Cpp2IlInjected.Token(Token = "0x400209F")]
		[OriginalName("ScheduleType_PlayerHouse")]
		PlayerHouse,
		[Cpp2IlInjected.Token(Token = "0x40020A0")]
		[OriginalName("ScheduleType_Event")]
		Event,
		[Cpp2IlInjected.Token(Token = "0x40020A1")]
		[OriginalName("ScheduleType_Store")]
		Store,
		[Cpp2IlInjected.Token(Token = "0x40020A2")]
		[OriginalName("ScheduleType_SpecificLocation")]
		SpecificLocation
	}
}
