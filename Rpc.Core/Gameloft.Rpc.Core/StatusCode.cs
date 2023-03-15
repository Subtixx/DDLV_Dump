using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public enum StatusCode
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[OriginalName("Ok")]
		Ok,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[OriginalName("Cancelled")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[OriginalName("DeadlineExpired")]
		DeadlineExpired,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[OriginalName("NotImplemented")]
		NotImplemented,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[OriginalName("Unavailable")]
		Unavailable,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[OriginalName("Unauthorized")]
		Unauthorized,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[OriginalName("InternalError")]
		InternalError,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[OriginalName("Unknown")]
		Unknown
	}
}
