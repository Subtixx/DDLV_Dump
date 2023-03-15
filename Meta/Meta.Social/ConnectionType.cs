using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000B3E")]
	public enum ConnectionType
	{
		[Cpp2IlInjected.Token(Token = "0x4002B95")]
		[OriginalName("ConnectionType_Friend")]
		Friend,
		[Cpp2IlInjected.Token(Token = "0x4002B96")]
		[OriginalName("ConnectionType_Followee")]
		Followee,
		[Cpp2IlInjected.Token(Token = "0x4002B97")]
		[OriginalName("ConnectionType_Follower")]
		Follower,
		[Cpp2IlInjected.Token(Token = "0x4002B98")]
		[OriginalName("ConnectionType_Guild")]
		Guild
	}
}
