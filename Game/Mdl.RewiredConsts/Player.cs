using Cpp2IlInjected;
using Rewired.Dev;

namespace Mdl.RewiredConsts
{
	[Cpp2IlInjected.Token(Token = "0x200021F")]
	public static class Player
	{
		[Cpp2IlInjected.Token(Token = "0x40012D0")]
		[PlayerIdFieldInfo]
		public const int SYSTEM = 9999999;

		[Cpp2IlInjected.Token(Token = "0x40012D1")]
		[PlayerIdFieldInfo]
		public const int LOCALPLAYER = 0;

		[Cpp2IlInjected.Token(Token = "0x40012D2")]
		[PlayerIdFieldInfo]
		public const int MARKETINGPLAYER = 1;
	}
}
