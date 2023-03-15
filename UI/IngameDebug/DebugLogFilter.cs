using Cpp2IlInjected;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public enum DebugLogFilter
	{
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		Info = 1,
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		Warning = 2,
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		Error = 4,
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		All = 7
	}
}
