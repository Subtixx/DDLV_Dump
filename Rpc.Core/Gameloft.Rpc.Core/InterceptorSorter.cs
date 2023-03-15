using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class InterceptorSorter
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private class EdgeComparer : IEqualityComparer<(object, object)>
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x38DADE0", Offset = "0x38D97E0", VA = "0x1838DADE0", Slot = "4")]
			private bool System_002ECollections_002EGeneric_002EIEqualityComparer_003C_0028System_002EObject_002CSystem_002EObject_0029_003E_002EEquals((object, object) x, (object, object) y)
			{
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x38DAE60", Offset = "0x38D9860", VA = "0x1838DAE60", Slot = "5")]
			private unsafe int System_002ECollections_002EGeneric_002EIEqualityComparer_003C_0028System_002EObject_002CSystem_002EObject_0029_003E_002EGetHashCode((object, object) obj)
			{
				return ((ValueTuple<T1, T2>*)obj)->GetHashCode();
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public EdgeComparer()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x38DE2F0", Offset = "0x38DCCF0", VA = "0x1838DE2F0")]
		public static List<InterceptorBuilderBase> Sort(List<InterceptorBuilderBase> list)
		{
			//Discarded unreachable code: IL_00e9, IL_00ef, IL_00f5, IL_00fb, IL_0101, IL_0107, IL_010d, IL_0113
			//IL_0019: Expected O, but got I4
			//IL_002c: Expected O, but got I4
			List<(object, object)> list2 = (List<(object, object)>)(object)new List<T>();
			bool flag = default(bool);
			if (flag)
			{
				if (flag)
				{
					int num = 0;
					((List<T>)(object)list2).Add((T)num);
				}
				if (flag)
				{
				}
				if (flag)
				{
					int num2 = 0;
					((List<T>)(object)list2).Add((T)num2);
				}
				if (!flag)
				{
				}
			}
			EdgeComparer edgeComparer = default(EdgeComparer);
			List<(object, object)> cpp2il__autoParamName__idx_ = (List<(object, object)>)(object)Enumerable.ToList<(object, object)>(Enumerable.Distinct<(object, object)>((IEnumerable<>)list2, (IEqualityComparer<>)edgeComparer));
			Func<InterceptorBuilderBase, object> func = default(Func<InterceptorBuilderBase, object>);
			if (_003C_003Ec._003C_003E9__0_0 == null)
			{
				func = (Func<InterceptorBuilderBase, object>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((InterceptorBuilderBase x) => x.InterceptorType));
			}
			List<object> list3 = (List<object>)(object)TopologicalSort<object>(Enumerable.ToList<object>(Enumerable.Select<InterceptorBuilderBase, object>((IEnumerable<>)list, (Func<, >)(object)func)), (List<>)(object)cpp2il__autoParamName__idx_);
			Func<InterceptorBuilderBase, object> func2 = default(Func<InterceptorBuilderBase, object>);
			if (_003C_003Ec._003C_003E9__0_1 == null)
			{
				func2 = (Func<InterceptorBuilderBase, object>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((InterceptorBuilderBase kv) => kv.InterceptorType));
			}
			Func<InterceptorBuilderBase, InterceptorBuilderBase> func3 = default(Func<InterceptorBuilderBase, InterceptorBuilderBase>);
			if (_003C_003Ec._003C_003E9__0_2 == null)
			{
				func3 = (Func<InterceptorBuilderBase, InterceptorBuilderBase>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((InterceptorBuilderBase kv) => kv));
			}
			_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = default(_003C_003Ec__DisplayClass0_0);
			Dictionary<InterceptorBuilderBase, object> dictionary = (Dictionary<InterceptorBuilderBase, object>)(object)(CS_0024_003C_003E8__locals0.mapping = (Dictionary<object, InterceptorBuilderBase>)(object)Enumerable.ToDictionary<InterceptorBuilderBase, object, InterceptorBuilderBase>((IEnumerable<>)list, (Func<, >)(object)func2, (Func<, >)(object)func3));
			Func<object, InterceptorBuilderBase> func4 = (Func<object, InterceptorBuilderBase>)(object)(Func<T, TResult>)((object x) => (InterceptorBuilderBase)((Dictionary<TKey, TValue>)(object)CS_0024_003C_003E8__locals0.mapping)[(TKey)x]);
			return (List<InterceptorBuilderBase>)(object)Enumerable.ToList<InterceptorBuilderBase>(Enumerable.Select<object, InterceptorBuilderBase>((IEnumerable<>)list3, (Func<, >)(object)func4));
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x19AC8F0", Offset = "0x19AB2F0", VA = "0x1819AC8F0")]
		private static List<> TopologicalSort<T>(List<> cpp2il__autoParamName__idx_0, List<> cpp2il__autoParamName__idx_1)
		{
			//Discarded unreachable code: IL_0099, IL_009f, IL_00a5, IL_00ab, IL_00b7, IL_00bd, IL_00c3
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int size = cpp2il__autoParamName__idx_0._size;
				if (num2 != 0)
				{
					while (num2 == 0)
					{
					}
					while (num2 == 0)
					{
					}
					if (num2 != 0)
					{
					}
				}
				int num4 = 0;
				if (num4 < num2)
				{
					num4 += num4;
					num4++;
				}
				if (num3 != 0)
				{
					break;
				}
				num4 += 312;
				num4 += num2;
				if (num4 > 0)
				{
					if (flag)
					{
						while (!flag)
						{
						}
						while (flag)
						{
						}
					}
					int num5 = 0;
					if ((long)num5 < (long)(IntPtr)typeof(IDisposable).TypeHandle)
					{
						num5 += num5;
						num5++;
					}
					int num6 = 0;
					if (num3 != 0)
					{
						continue;
					}
					num5 += 312;
					num5 += num2;
					if (num4 >= num5)
					{
					}
				}
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}
	}
}
