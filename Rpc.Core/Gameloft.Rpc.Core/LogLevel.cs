using Cpp2IlInjected;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum LogLevel
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Emergency,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Alert,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Critical,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		Notice,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		Info,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		Debug
	}
}
