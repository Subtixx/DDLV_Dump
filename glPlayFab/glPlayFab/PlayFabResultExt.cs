using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public static class PlayFabResultExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x26D2730", Offset = "0x26D1130", VA = "0x1826D2730")]
		public unsafe static bool TryGetFunctionResult<T, E>(this PlayFabResult<T> self, out E e) where T : ExecuteFunctionResult<E> where E : class
		{
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref e) != null)
			{
			}
			throw new NullReferenceException();
		}
	}
}
