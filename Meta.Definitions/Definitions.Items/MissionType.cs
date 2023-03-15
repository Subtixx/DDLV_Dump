using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200060B")]
	public enum MissionType
	{
		[Cpp2IlInjected.Token(Token = "0x4002125")]
		[OriginalName("MissionType_Story")]
		Story,
		[Cpp2IlInjected.Token(Token = "0x4002126")]
		[OriginalName("MissionType_Village")]
		Village,
		[Cpp2IlInjected.Token(Token = "0x4002127")]
		[OriginalName("MissionType_TLE")]
		Tle,
		[Cpp2IlInjected.Token(Token = "0x4002128")]
		[OriginalName("MissionType_Secret")]
		Secret,
		[Cpp2IlInjected.Token(Token = "0x4002129")]
		[OriginalName("MissionType_Realm")]
		Realm
	}
}
