using System;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[Flags]
	public enum ConfigType : uint
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		None = 0u,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		gameconfig = 1u,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		gpuconfig = 2u,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		cpuconfig = 4u,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		All = uint.MaxValue
	}
}
