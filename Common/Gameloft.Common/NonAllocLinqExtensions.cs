using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Gameloft.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class NonAllocLinqExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x26CFBF0", Offset = "0x26CE5F0", VA = "0x1826CFBF0")]
		public static NonAllocWhereEnumerator<TSource, List<TSource>.Enumerator> WhereNonAlloc<TSource>(this List<TSource> list, Func<TSource, bool> predicate)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x26CFBA0", Offset = "0x26CE5A0", VA = "0x1826CFBA0")]
		public static NonAllocWhereEnumerator<TSource, EnumeratorType> WhereNonAlloc<TSource, EnumeratorType>(this EnumeratorType enumerator, Func<TSource, bool> predicate) where EnumeratorType : struct, IEnumerator<TSource>
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x26CFB50", Offset = "0x26CE550", VA = "0x1826CFB50")]
		public static NonAllocSelectEnumerator<TSource, TResult, EnumeratorType> SelectNonAlloc<TSource, TResult, EnumeratorType>(this EnumeratorType enumerator, Func<TSource, TResult> func) where EnumeratorType : struct, IEnumerator<TSource>
		{
			int num = 0;
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}
	}
}
