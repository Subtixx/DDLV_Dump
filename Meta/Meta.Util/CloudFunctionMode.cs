using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000A9F")]
	public enum CloudFunctionMode
	{
		[Cpp2IlInjected.Token(Token = "0x4002991")]
		[OriginalName("Embed")]
		Embed,
		[Cpp2IlInjected.Token(Token = "0x4002992")]
		[OriginalName("Ip")]
		Ip,
		[Cpp2IlInjected.Token(Token = "0x4002993")]
		[OriginalName("GameloftPortal")]
		GameloftPortal,
		[Cpp2IlInjected.Token(Token = "0x4002994")]
		[OriginalName("PlayFab")]
		PlayFab
	}
}
