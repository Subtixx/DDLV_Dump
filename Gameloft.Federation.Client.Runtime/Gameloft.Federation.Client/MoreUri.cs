using System;
using Cpp2IlInjected;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class MoreUri
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4033A80", Offset = "0x4032480", VA = "0x184033A80")]
		public static string EscapeLongDataString(string dataString)
		{
			//Discarded unreachable code: IL_0007, IL_004b, IL_004f
			return Uri.EscapeDataString(dataString);
		}
	}
}
