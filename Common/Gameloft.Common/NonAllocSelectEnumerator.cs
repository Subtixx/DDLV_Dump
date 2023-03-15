using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Gameloft.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct NonAllocSelectEnumerator<TSource, TResult, EnumeratorType> : IEnumerator<TResult>, IEnumerator, IDisposable where EnumeratorType : struct, IEnumerator<TSource>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private EnumeratorType enumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly Func<TSource, TResult> func;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public TResult Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x1AC8E00", Offset = "0x1AC7800", VA = "0x181AC8E00", Slot = "4")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x1AC8D80", Offset = "0x1AC7780", VA = "0x181AC8D80", Slot = "7")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1AC8DC0", Offset = "0x1AC77C0", VA = "0x181AC8DC0")]
		public NonAllocSelectEnumerator(EnumeratorType enumerator, Func<TSource, TResult> func)
		{
			System.Runtime.CompilerServices.Unsafe.As<NonAllocSelectEnumerator<TSource, TResult, EnumeratorType>, NonAllocSelectEnumerator<, , >>(ref this).enumerator = (EnumeratorType)func;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1AC8BA0", Offset = "0x1AC75A0", VA = "0x181AC8BA0", Slot = "6")]
		public bool MoveNext()
		{
			int num = 0;
			num += num;
			num++;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1AC8C80", Offset = "0x1AC7680", VA = "0x181AC8C80", Slot = "8")]
		public void Reset()
		{
			int num = 0;
			num += num;
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1AC8AC0", Offset = "0x1AC74C0", VA = "0x181AC8AC0", Slot = "5")]
		public void Dispose()
		{
			int num = 0;
			num += num;
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x16AFD60", Offset = "0x16AE760", VA = "0x1816AFD60")]
		public unsafe NonAllocSelectEnumerator<TSource, TResult, EnumeratorType> GetEnumerator()
		{
			//IL_0002: Expected O, but got Ref
			return (NonAllocSelectEnumerator<TSource, TResult, EnumeratorType>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}
	}
}
