using System;
using Cpp2IlInjected;
using PlayFab;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	public static class PlayFabBaseResultExt
	{
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x1035B50", Offset = "0x1034550", VA = "0x181035B50")]
		public static void ThrowIfError(this PlayFabBaseResult self)
		{
			//Discarded unreachable code: IL_0012
			if ((long)self.Error == 0)
			{
				return;
			}
			throw new NullReferenceException();
		}
	}
}
