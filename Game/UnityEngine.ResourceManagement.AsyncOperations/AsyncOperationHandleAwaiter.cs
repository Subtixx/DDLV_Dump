using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public struct AsyncOperationHandleAwaiter : INotifyCompletion
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private AsyncOperationHandle asyncOperation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private bool useUnityContext;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60004E9")]
			[Cpp2IlInjected.Address(RVA = "0xA45E60", Offset = "0xA44860", VA = "0x180A45E60")]
			get
			{
				bool flag = default(bool);
				if (!flag)
				{
					return flag;
				}
				return !useUnityContext;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xA45E30", Offset = "0xA44830", VA = "0x180A45E30")]
		public AsyncOperationHandleAwaiter(AsyncOperationHandle asyncOperation)
		{
			useUnityContext = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xA45C10", Offset = "0xA44610", VA = "0x180A45C10", Slot = "4")]
		public unsafe void OnCompleted(Action continuation)
		{
			bool flag = default(bool);
			if (!flag)
			{
				bool useContext = useUnityContext;
				Action<AsyncOperationHandle> action = (Action<AsyncOperationHandle>)(object)(Action<T>)delegate(AsyncOperationHandle operation)
				{
					Exception operationException = ((AsyncOperationHandle*)operation)->OperationException;
					if (operationException != null)
					{
						Exception operationException2 = ((AsyncOperationHandle*)operation)->OperationException;
						AggregateException ex = new AggregateException("Exception while doing an async operation", operationException2);
						/*Error: Unexpected end of block*/;
					}
					if ((IntPtr)(useContext ? 1 : 0) == (IntPtr)operationException)
					{
						continuation?.Invoke();
					}
					else if (_003C_003Ec._003C_003E9__5_2 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(SendOrPostCallback)delegate(object x)
						{
							if (x == null || x != null)
							{
								return;
							}
							throw new InvalidCastException();
						};
					}
				};
				return;
			}
			if (!useUnityContext)
			{
				while (System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) == null)
				{
				}
			}
			if (_003C_003Ec._003C_003E9__5_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(SendOrPostCallback)delegate(object x)
				{
					if (x == null || x != null)
					{
						return;
					}
					throw new InvalidCastException();
				};
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xA45BD0", Offset = "0xA445D0", VA = "0x180A45BD0")]
		public unsafe AsyncOperationHandleAwaiter ConfigureUnityContext(bool useUnityContext)
		{
			//IL_0002: Expected O, but got Ref
			return (AsyncOperationHandleAwaiter)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xA45BF0", Offset = "0xA445F0", VA = "0x180A45BF0")]
		public unsafe AsyncOperationHandleAwaiter GetAwaiter()
		{
			//IL_0002: Expected O, but got Ref
			return (AsyncOperationHandleAwaiter)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public struct AsyncOperationHandleAwaiter<T> : INotifyCompletion
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private AsyncOperationHandle<T> asyncOperation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private bool useUnityContext;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x3021230", Offset = "0x301FC30", VA = "0x183021230")]
			get
			{
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x3021200", Offset = "0x301FC00", VA = "0x183021200")]
		public AsyncOperationHandleAwaiter(AsyncOperationHandle<T> asyncOperation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x3020D20", Offset = "0x301F720", VA = "0x183020D20", Slot = "4")]
		public void OnCompleted(Action continuation)
		{
			//Discarded unreachable code: IL_000c, IL_0010, IL_0018
			((AsyncOperationHandleAwaiter<>._003C_003Ec__DisplayClass5_0)(object)new _003C_003Ec__DisplayClass5_0()).continuation = continuation;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x3020800", Offset = "0x301F200", VA = "0x183020800")]
		public T GetResult()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x3020780", Offset = "0x301F180", VA = "0x183020780")]
		public unsafe AsyncOperationHandleAwaiter<T> ConfigureUnityContext(bool useUnityContext)
		{
			//IL_0002: Expected O, but got Ref
			return (AsyncOperationHandleAwaiter<T>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x16AFD60", Offset = "0x16AE760", VA = "0x1816AFD60")]
		public unsafe AsyncOperationHandleAwaiter<T> GetAwaiter()
		{
			//IL_0002: Expected O, but got Ref
			return (AsyncOperationHandleAwaiter<T>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}
	}
}
