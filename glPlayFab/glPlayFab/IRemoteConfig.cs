using System;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface IRemoteConfig
	{
		[Cpp2IlInjected.Token(Token = "0x17000062")]
		Type ClassType
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		ConfigType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
