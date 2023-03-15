using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000746")]
	internal static class EnumerableExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600205C")]
		[Cpp2IlInjected.Address(RVA = "0x122D5E0", Offset = "0x122BFE0", VA = "0x18122D5E0")]
		public static IEnumerable<TSource> Valid<TSource>(this IEnumerable<TSource> source) where TSource : class
		{
			IEnumerator<> enumerator = ((IEnumerable<T>)source).GetEnumerator();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600205D")]
		[Cpp2IlInjected.Address(RVA = "0x122D590", Offset = "0x122BF90", VA = "0x18122D590")]
		public static TElementType RandomElement<TElementType>(this IEnumerable<> P_0)
		{
			int num = 0;
			IEnumerator<> enumerator = ((IEnumerable<T>)P_0).GetEnumerator();
			/*Error: Unexpected end of block*/;
		}
	}
}
