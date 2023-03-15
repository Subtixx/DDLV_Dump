using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Gameloft.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct NonAllocWhereEnumerator<TSource, EnumeratorType> : IEnumerator<TSource>, IEnumerator, IDisposable where EnumeratorType : struct, IEnumerator<TSource>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private EnumeratorType enumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Func<TSource, bool> predicate;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TSource Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1AC9510", Offset = "0x1AC7F10", VA = "0x181AC9510", Slot = "4")]
			get
			{
				int num = 0;
				num += num;
				num++;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x1AC93D0", Offset = "0x1AC7DD0", VA = "0x181AC93D0", Slot = "7")]
			get
			{
				int num = 0;
				num += num;
				num++;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1AC94D0", Offset = "0x1AC7ED0", VA = "0x181AC94D0")]
		public NonAllocWhereEnumerator(EnumeratorType enumerator, Func<TSource, bool> predicate)
		{
			System.Runtime.CompilerServices.Unsafe.As<NonAllocWhereEnumerator<TSource, EnumeratorType>, NonAllocWhereEnumerator<, >>(ref this).enumerator = (EnumeratorType)predicate;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1AC9060", Offset = "0x1AC7A60", VA = "0x181AC9060", Slot = "6")]
		public bool MoveNext()
		{
			int num = 0;
			num += num;
			num++;
			int num2 = 0;
			if (num != 0)
			{
				if (num < num2)
				{
					num += num;
					num++;
				}
				bool flag = default(bool);
				while (!flag)
				{
				}
				num += num;
				num += num;
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1AC92D0", Offset = "0x1AC7CD0", VA = "0x181AC92D0", Slot = "8")]
		public void Reset()
		{
			int num = 0;
			num += num;
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1AC8F80", Offset = "0x1AC7980", VA = "0x181AC8F80", Slot = "5")]
		public void Dispose()
		{
			int num = 0;
			num += num;
			num++;
		}
	}
}
