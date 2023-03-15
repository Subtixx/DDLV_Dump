using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000B3F")]
	public enum ConnectionTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4002B9A")]
		[OriginalName("ConnectionTypes_None")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4002B9B")]
		[OriginalName("ConnectionTypes_Friend")]
		Friend = 1,
		[Cpp2IlInjected.Token(Token = "0x4002B9C")]
		[OriginalName("ConnectionTypes_Followee")]
		Followee = 2,
		[Cpp2IlInjected.Token(Token = "0x4002B9D")]
		[OriginalName("ConnectionTypes_Follower")]
		Follower = 4,
		[Cpp2IlInjected.Token(Token = "0x4002B9E")]
		[OriginalName("ConnectionTypes_Guild")]
		Guild = 8
	}
}
