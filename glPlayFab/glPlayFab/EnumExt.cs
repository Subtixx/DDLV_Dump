using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public static class EnumExt
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1650BD0", Offset = "0x164F5D0", VA = "0x181650BD0")]
		public static IEnumerable<T> GetValues<T>() where T : Enum
		{
			Array values = Enum.GetValues(typeof(Type));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x102E590", Offset = "0x102CF90", VA = "0x18102E590")]
		[IteratorStateMachine(typeof(_003CGetFlags_003Ed__1))]
		public static IEnumerable<Enum> GetFlags(this Enum e)
		{
			new _003CGetFlags_003Ed__1(-2)._003C_003E3__e = e;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x1243B00", Offset = "0x1242500", VA = "0x181243B00")]
		[IteratorStateMachine(typeof(_003CChunkBy_003Ed__2<>))]
		public static IEnumerable<List<T>> ChunkBy<T>(this List<T> self, int nSize)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x16509A0", Offset = "0x164F3A0", VA = "0x1816509A0")]
		[AsyncStateMachine(typeof(_003CForEachAsyncThrottled_DEBUG_003Ed__3<>))]
		public static void ForEachAsyncThrottled_DEBUG<T>(this List<T> list, Func<T, Task> action, int throttle)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x1650A90", Offset = "0x164F490", VA = "0x181650A90")]
		[AsyncStateMachine(typeof(_003CForEachAsyncThrottled_DEBUG_003Ed__4<>))]
		public static Task ForEachAsyncThrottled_DEBUG<T>(this List<T> list, CancellationToken ct, Func<CancellationToken, T, Task> action, int throttle)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x1650830", Offset = "0x164F230", VA = "0x181650830")]
		[AsyncStateMachine(typeof(_003CForEachAsyncThrottled_DEBUG_003Ed__5<>))]
		public static Task<bool> ForEachAsyncThrottled_DEBUG<T>(this List<T> list, CancellationToken ct, Func<CancellationToken, T, Task<bool>> action, int throttle, bool stopOnException = false)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x1650F50", Offset = "0x164F950", VA = "0x181650F50")]
		[AsyncStateMachine(typeof(_003CWhenAllThrottled_003Ed__6<, >))]
		public static Task<Tuple<OUT, Exception>[]> WhenAllThrottled<OUT, IN>(this IReadOnlyList<IN> self, Func<IN, Task<OUT>> action, int throttle = 10)
		{
			int num = 0;
			int num2 = 0;
			Task<> result = default(Task<>);
			return (Task<Tuple<OUT, Exception>[]>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1650C80", Offset = "0x164F680", VA = "0x181650C80")]
		[AsyncStateMachine(typeof(_003CWhenAllThrottled_003Ed__7<, >))]
		public static Task<Tuple<OUT, Exception>[]> WhenAllThrottled<OUT, IN>(this IReadOnlyList<IN> self, Func<IN, CancellationToken, Task<OUT>> action, int throttle = 10, [Optional] CancellationToken ct)
		{
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<Tuple<OUT, Exception>[]>)(object)result;
		}
	}
}
