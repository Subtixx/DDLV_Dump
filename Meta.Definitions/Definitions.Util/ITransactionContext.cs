using System;
using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	public interface ITransactionContext
	{
		[Cpp2IlInjected.Token(Token = "0x17000345")]
		DateTime Now
		{
			[Cpp2IlInjected.Token(Token = "0x6000D96")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000346")]
		DateTime LocalNow
		{
			[Cpp2IlInjected.Token(Token = "0x6000D97")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000347")]
		bool IsServer
		{
			[Cpp2IlInjected.Token(Token = "0x6000D98")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
}
