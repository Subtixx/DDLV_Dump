using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum FollowStatus
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[OriginalName("Unknown")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[OriginalName("NotFollowing")]
		NotFollowing,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[OriginalName("Following")]
		Following
	}
}
