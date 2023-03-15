using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B39")]
	public sealed class GameSynchronizationContext : SynchronizationContext
	{
		[Cpp2IlInjected.Token(Token = "0x2000B3A")]
		private struct WorkRequest
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4002B8F")]
			private readonly SendOrPostCallback delegateCallback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4002B90")]
			private readonly object delagateState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002B91")]
			private readonly ManualResetEvent waitHandle;

			[Cpp2IlInjected.Token(Token = "0x6005E94")]
			[Cpp2IlInjected.Address(RVA = "0x9B1580", Offset = "0x9AFF80", VA = "0x1809B1580")]
			public WorkRequest(SendOrPostCallback callback, object state, [Optional] ManualResetEvent waitHandle)
			{
				delegateCallback = callback;
				delagateState = state;
				this.waitHandle = waitHandle;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6005E95")]
			[Cpp2IlInjected.Address(RVA = "0x9B14E0", Offset = "0x9AFEE0", VA = "0x1809B14E0")]
			public void Invoke()
			{
			}//Discarded unreachable code: IL_0001, IL_0002

		}

		[Cpp2IlInjected.Token(Token = "0x4002B8A")]
		private const int InitialCapacity = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002B8B")]
		private readonly List<WorkRequest> asyncWorkQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002B8C")]
		private readonly List<WorkRequest> currentFramework = (List<WorkRequest>)(object)new List<T>(20);

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002B8D")]
		private readonly int mainThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4002B8E")]
		private int trackedCount;

		[Cpp2IlInjected.Token(Token = "0x6005E88")]
		[Cpp2IlInjected.Address(RVA = "0x1D020F0", Offset = "0x1D00AF0", VA = "0x181D020F0")]
		public GameSynchronizationContext(int mainThreadId)
		{
			List<WorkRequest> list = (asyncWorkQueue = (List<WorkRequest>)(object)new List<T>(20));
			this.mainThreadId = mainThreadId;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E89")]
		[Cpp2IlInjected.Address(RVA = "0x1D02040", Offset = "0x1D00A40", VA = "0x181D02040")]
		private GameSynchronizationContext(List<WorkRequest> queue, int mainThreadId)
		{
			asyncWorkQueue = queue;
			this.mainThreadId = mainThreadId;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E8A")]
		[Cpp2IlInjected.Address(RVA = "0x1D01E40", Offset = "0x1D00840", VA = "0x181D01E40", Slot = "4")]
		public unsafe override void Send(SendOrPostCallback callback, object state)
		{
			//Discarded unreachable code: IL_006a, IL_0070, IL_0076
			//IL_004d: Expected O, but got I4
			int num = 0;
			int num2 = mainThreadId;
			int num3 = 0;
			int managedThreadId = Thread.CurrentThread.ManagedThreadId;
			if (num2 != managedThreadId)
			{
				int initialState = default(int);
				ManualResetEvent manualResetEvent = new ManualResetEvent((byte)initialState != 0);
				initialState = 0;
				List<WorkRequest> obj = asyncWorkQueue;
				Monitor.Enter(obj, ref *(bool*)num);
				List<WorkRequest> list = asyncWorkQueue;
				int num4 = 0;
				int num5 = 0;
				((List<T>)(object)list).Add((T)num4);
				Monitor.Exit(obj);
				bool flag = manualResetEvent.WaitOne();
				if (manualResetEvent == null)
				{
				}
			}
			callback(state);
		}

		[Cpp2IlInjected.Token(Token = "0x6005E8B")]
		[Cpp2IlInjected.Address(RVA = "0x1D01D20", Offset = "0x1D00720", VA = "0x181D01D20", Slot = "6")]
		public override void OperationStarted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005E8C")]
		[Cpp2IlInjected.Address(RVA = "0x1D01D10", Offset = "0x1D00710", VA = "0x181D01D10", Slot = "7")]
		public override void OperationCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005E8D")]
		[Cpp2IlInjected.Address(RVA = "0x1D01D30", Offset = "0x1D00730", VA = "0x181D01D30", Slot = "5")]
		public unsafe override void Post(SendOrPostCallback callback, object state)
		{
			//Discarded unreachable code: IL_002a
			//IL_0023: Expected O, but got I4
			int num = 0;
			List<WorkRequest> obj = asyncWorkQueue;
			Monitor.Enter(obj, ref *(bool*)num);
			List<WorkRequest> list = asyncWorkQueue;
			int num2 = 0;
			int num3 = 0;
			((List<T>)(object)list).Add((T)num2);
			Monitor.Exit(obj);
		}

		[Cpp2IlInjected.Token(Token = "0x6005E8E")]
		[Cpp2IlInjected.Address(RVA = "0x1D01700", Offset = "0x1D00100", VA = "0x181D01700", Slot = "8")]
		public override SynchronizationContext CreateCopy()
		{
			List<WorkRequest> list = asyncWorkQueue;
			int num = mainThreadId;
			GameSynchronizationContext gameSynchronizationContext = new GameSynchronizationContext(20);
			List<WorkRequest> list2 = (gameSynchronizationContext.currentFramework = (List<WorkRequest>)(object)new List<T>(20));
			gameSynchronizationContext.asyncWorkQueue = list;
			gameSynchronizationContext.mainThreadId = num;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E8F")]
		[Cpp2IlInjected.Address(RVA = "0x1D017E0", Offset = "0x1D001E0", VA = "0x181D017E0")]
		public unsafe void Exec()
		{
			//Discarded unreachable code: IL_0040, IL_0046, IL_004c
			int num = 0;
			int num2 = 0;
			List<WorkRequest> obj = asyncWorkQueue;
			Monitor.Enter(obj, ref *(bool*)num2);
			List<WorkRequest> list = currentFramework;
			List<WorkRequest> list2 = asyncWorkQueue;
			((List<T>)(object)list).AddRange((IEnumerable<>)list2);
			((List<T>)(object)asyncWorkQueue).Clear();
			Monitor.Exit(obj);
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E90")]
		[Cpp2IlInjected.Address(RVA = "0x1D01BA0", Offset = "0x1D005A0", VA = "0x181D01BA0")]
		private bool HasPendingTasks()
		{
			//Discarded unreachable code: IL_0009
			List<WorkRequest> list = asyncWorkQueue;
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E91")]
		[Cpp2IlInjected.Address(RVA = "0x1D01BF0", Offset = "0x1D005F0", VA = "0x181D01BF0")]
		private static void InitializeSynchronizationContext()
		{
			//Discarded unreachable code: IL_0043
			int num = 0;
			int managedThreadId = Thread.CurrentThread.ManagedThreadId;
			GameSynchronizationContext gameSynchronizationContext = new GameSynchronizationContext(20);
			List<WorkRequest> list = (gameSynchronizationContext.currentFramework = (List<WorkRequest>)(object)new List<T>(20));
			List<WorkRequest> list2 = (gameSynchronizationContext.asyncWorkQueue = (List<WorkRequest>)(object)new List<T>(20));
			gameSynchronizationContext.mainThreadId = managedThreadId;
			SynchronizationContext.SetSynchronizationContext(gameSynchronizationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x6005E92")]
		[Cpp2IlInjected.Address(RVA = "0x1D01B40", Offset = "0x1D00540", VA = "0x181D01B40")]
		private static void ExecuteTasks()
		{
			int num = 0;
			SynchronizationContext current = SynchronizationContext.Current;
			if (current != null && current == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E93")]
		[Cpp2IlInjected.Address(RVA = "0x1D019E0", Offset = "0x1D003E0", VA = "0x181D019E0")]
		private static bool ExecutePendingTasks(long millisecondsTimeout)
		{
			//Discarded unreachable code: IL_0034
			int num = 0;
			SynchronizationContext current = SynchronizationContext.Current;
			if (current != null && current != null)
			{
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
				Thread.Sleep(1);
				if (1L == 0L)
				{
				}
				int num2 = 0;
			}
			return true;
		}
	}
}
