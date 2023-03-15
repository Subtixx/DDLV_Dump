using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Gameloft.Common
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class MoreLinq
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x26CBBC0", Offset = "0x26CA5C0", VA = "0x1826CBBC0")]
		public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
		{
			//Discarded unreachable code: IL_0023, IL_0029
			int num = 0;
			if ((object)typeof(IEnumerator).TypeHandle != null)
			{
				if ((long)num < (long)(IntPtr)typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				num += 312;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x26CB1C0", Offset = "0x26C9BC0", VA = "0x1826CB1C0")]
		public static int FindIndex<T>(this IEnumerable<T> items, Func<T, bool> predicate)
		{
			//Discarded unreachable code: IL_003e
			int num = 0;
			if (items != null)
			{
				num += num;
				num++;
				if (num == 0)
				{
					num++;
					num += 312;
				}
				num++;
				num++;
				if (num != 0)
				{
					return num;
				}
			}
			ArgumentNullException ex = new ArgumentNullException("items");
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x19ADCD0", Offset = "0x19AC6D0", VA = "0x1819ADCD0")]
		public static int IndexOf<T>(this IEnumerable<T> items, T item)
		{
			IEnumerator<> enumerator = ((IEnumerable<T>)items).GetEnumerator();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1241F00", Offset = "0x1240900", VA = "0x181241F00")]
		public static T MinByOrDefault<T, S>(this IEnumerable<T> enumerable, Func<T, S> by) where S : IComparable<S>
		{
			IEnumerator<> enumerator = ((IEnumerable<T>)enumerable).GetEnumerator();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x26CE4A0", Offset = "0x26CCEA0", VA = "0x1826CE4A0")]
		[IteratorStateMachine(typeof(_003CShuffle_003Ed__4<>))]
		public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source, Random rng, int firstElements = -1)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x26CDC00", Offset = "0x26CC600", VA = "0x1826CDC00")]
		public static T MinByOrDefault<T, S>(this IEnumerable<T> enumerable, Func<T, S> by, T defaultValue) where S : IComparable<S>
		{
			//Discarded unreachable code: IL_0032, IL_0038
			int num = 0;
			if ((object)typeof(IEnumerator).TypeHandle != null)
			{
				if ((long)num < (long)(IntPtr)typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				uint num2 = default(uint);
				while (num2 == 0)
				{
				}
				num += num;
				num2 += 312;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1241F00", Offset = "0x1240900", VA = "0x181241F00")]
		public static T MaxByOrDefault<T, S>(this IEnumerable<T> enumerable, Func<T, S> by) where S : IComparable<S>
		{
			IEnumerator<> enumerator = ((IEnumerable<T>)enumerable).GetEnumerator();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x26CCCB0", Offset = "0x26CB6B0", VA = "0x1826CCCB0")]
		public static T MaxByOrDefault<T, S>(this IEnumerable<T> enumerable, Func<T, S> by, T defaultValue) where S : IComparable<S>
		{
			//Discarded unreachable code: IL_0032, IL_0038
			int num = 0;
			if ((object)typeof(IEnumerator).TypeHandle != null)
			{
				if ((long)num < (long)(IntPtr)typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				uint num2 = default(uint);
				while (num2 == 0)
				{
				}
				num += num;
				num2 += 312;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x26CE2C0", Offset = "0x26CCCC0", VA = "0x1826CE2C0")]
		public static T MinBy<T, S>(this IEnumerable<T> enumerable, Func<T, S> by) where S : IComparable<S>
		{
			IEnumerator<> enumerator = ((IEnumerable<T>)enumerable).GetEnumerator();
			InvalidOperationException ex = new InvalidOperationException("Can't aggregate an empty enumerable");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x26CD160", Offset = "0x26CBB60", VA = "0x1826CD160")]
		public static T MaxBy<T, S>(this IEnumerable<T> enumerable, Func<T, S> by) where S : IComparable<S>
		{
			//Discarded unreachable code: IL_004a
			int num = 0;
			int num2 = 0;
			if ((object)typeof(IEnumerator).TypeHandle != null)
			{
				int num3 = 0;
				if ((object)typeof(IEnumerator).TypeHandle != null)
				{
					if ((long)num2 < (long)(IntPtr)typeof(IEnumerator).TypeHandle)
					{
						num2 += num2;
						num2++;
					}
					uint num4 = default(uint);
					while (num4 == 0)
					{
					}
					num4 += 312;
				}
			}
			InvalidOperationException ex = new InvalidOperationException("Can't aggregate an empty enumerable");
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x26CC780", Offset = "0x26CB180", VA = "0x1826CC780")]
		public static TValue GetValueOrDefault<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)
		{
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				if (num != (int)num2)
				{
					num++;
				}
			}
			num += 328;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x17554E0", Offset = "0x1753EE0", VA = "0x1817554E0")]
		public static HashSet<T> ToHashSet<T>(this IEnumerable<T> source)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7F0C20", Offset = "0x7EF620", VA = "0x1807F0C20")]
		public static IEnumerable<(T1, T2)> Zip<T1, T2>(this IEnumerable<T1> enumerable1, IEnumerable<T2> enumerable2)
		{
			IEnumerator<> enumerator = ((IEnumerable<T>)enumerable1).GetEnumerator();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x165AB70", Offset = "0x1659570", VA = "0x18165AB70")]
		[IteratorStateMachine(typeof(_003CYield_003Ed__24<>))]
		public static IEnumerable<T> Yield<T>(this T item)
		{
			throw new NullReferenceException();
		}
	}
}
