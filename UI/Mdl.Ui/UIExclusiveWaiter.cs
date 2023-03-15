using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20008B6")]
	internal class UIExclusiveWaiter : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20008B7")]
		private struct InternalScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400342F")]
			private readonly Action _onDispose;

			[Cpp2IlInjected.Token(Token = "0x6003719")]
			[Cpp2IlInjected.Address(RVA = "0x6DDCC0", Offset = "0x6DC6C0", VA = "0x1806DDCC0")]
			public InternalScope(Action onDispose)
			{
				_onDispose = onDispose;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600371A")]
			[Cpp2IlInjected.Address(RVA = "0x134FE90", Offset = "0x134E890", VA = "0x18134FE90", Slot = "4")]
			public void Dispose()
			{
			}//Discarded unreachable code: IL_0001

		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400342E")]
		private SemaphoreSlim _semaphore;

		[Cpp2IlInjected.Token(Token = "0x6003715")]
		[Cpp2IlInjected.Address(RVA = "0xC96180", Offset = "0xC94B80", VA = "0x180C96180")]
		public UIExclusiveWaiter()
		{
			SemaphoreSlim semaphoreSlim = (_semaphore = new SemaphoreSlim(1, 1));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003716")]
		[Cpp2IlInjected.Address(RVA = "0xC96000", Offset = "0xC94A00", VA = "0x180C96000", Slot = "4")]
		public void Dispose()
		{
			_semaphore.Dispose();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003717")]
		[Cpp2IlInjected.Address(RVA = "0xC96060", Offset = "0xC94A60", VA = "0x180C96060")]
		[AsyncStateMachine(typeof(_003CWaitAsync_003Ed__4))]
		public Task<IDisposable> WaitAsync()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<IDisposable>)(object)result;
		}
	}
}
