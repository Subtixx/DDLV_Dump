using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000FBF")]
	internal class AsyncSemaphorePriority<T> where T : struct, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40040E2")]
		private readonly T[] priorities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40040E3")]
		private readonly Dictionary<T, Queue<TaskCompletionSource<bool>>> priorityQueues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40040E4")]
		private readonly SynchronizationContext synchronizationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40040E5")]
		private int count;

		[Cpp2IlInjected.Token(Token = "0x6007F6A")]
		[Cpp2IlInjected.Address(RVA = "0x3027A30", Offset = "0x3026430", VA = "0x183027A30")]
		public AsyncSemaphorePriority(int initialCount, SynchronizationContext synchronizationContext)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6007F6B")]
		[Cpp2IlInjected.Address(RVA = "0x3027840", Offset = "0x3026240", VA = "0x183027840")]
		public unsafe Task WaitAsync(T priority)
		{
			//Discarded unreachable code: IL_0057, IL_005d
			int num = 0;
			Dictionary<, > obj = (Dictionary<, >)(object)((AsyncSemaphorePriority<>)(object)this).priorityQueues;
			Monitor.Enter(obj, ref *(bool*)num);
			int num2 = ((AsyncSemaphorePriority<>)(object)this).count;
			if (((Dictionary<TKey, TValue>)(object)((AsyncSemaphorePriority<>)(object)this).priorityQueues).TryGetValue((TKey)priority, out *(TValue*)num))
			{
				Task<> task = (Task<>)(object)((TaskCompletionSource<>)(object)new TaskCompletionSource<TResult>()).m_task;
				int num3 = 0;
				Task completedTask = Task.CompletedTask;
				Monitor.Exit(obj);
				return completedTask;
			}
			Exception ex = new Exception("Invalid priority");
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007F6C")]
		[Cpp2IlInjected.Address(RVA = "0x3027490", Offset = "0x3025E90", VA = "0x183027490")]
		public void Release()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
