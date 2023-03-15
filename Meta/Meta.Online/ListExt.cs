using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000EF3")]
	public static class ListExt
	{
		[Cpp2IlInjected.Token(Token = "0x6007BB3")]
		[Cpp2IlInjected.Address(RVA = "0x19C0DF0", Offset = "0x19BF7F0", VA = "0x1819C0DF0")]
		public static void ForEach<T>(this IReadOnlyList<T> self, Action<T> action)
		{
			//Discarded unreachable code: IL_0027, IL_002d
			int num = 0;
			if ((object)typeof(IEnumerator).TypeHandle != null)
			{
				if ((long)num < (long)(IntPtr)typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				num += num;
				num += 312;
			}
		}
	}
}
