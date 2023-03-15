using System;
using Cpp2IlInjected;
using PlayFab;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	public class PlayFabResultException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x103F6B0", Offset = "0x103E0B0", VA = "0x18103F6B0")]
		public PlayFabResultException(PlayFabError error)
			: base(error.GenerateErrorReport())
		{
		}//Discarded unreachable code: IL_000f

	}
}
