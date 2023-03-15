using System;
using Cpp2IlInjected;
using Definitions.Util;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	public static class FetchableExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x2CA9170", Offset = "0x2CA7B70", VA = "0x182CA9170")]
		public static bool IsActive(this IFetchable fetchable, in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//IL_0026: Expected I4, but got O
			if ((object)typeof(ITimeLimited).TypeHandle != null && (object)typeof(ITimeLimited).TypeHandle != null && (object)typeof(ITimeLimited).TypeHandle != null && (object)typeof(ITimeLimited).TypeHandle != null)
			{
				return (byte)(int)typeof(ITimeLimited).TypeHandle != 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x2CA92F0", Offset = "0x2CA7CF0", VA = "0x182CA92F0")]
		public static bool IsValid(this IFetchable fetchable)
		{
			//Discarded unreachable code: IL_0008
			return 0 != 0;
		}
	}
}
