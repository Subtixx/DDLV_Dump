using System.Collections.Generic;
using Cpp2IlInjected;

namespace System
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class SystemExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1752AD0", Offset = "0x17514D0", VA = "0x181752AD0")]
		public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> keyValuePair, out TKey key, out TValue value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1752C70", Offset = "0x1751670", VA = "0x181752C70")]
		public static bool TryGetValue<T>(this T? nullable, out T value) where T : struct
		{
			int num = 0;
			int num2 = 0;
			return true;
		}
	}
}
