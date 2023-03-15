using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;

namespace UnityEngine
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public struct AsyncOperationAwaiter : INotifyCompletion
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private AsyncOperation asyncOperation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private bool useUnityContext;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0xA45B00", Offset = "0xA44500", VA = "0x180A45B00")]
			get
			{
				//Discarded unreachable code: IL_0010
				bool flag = default(bool);
				if (!flag)
				{
					return flag;
				}
				return !useUnityContext;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xA45AE0", Offset = "0xA444E0", VA = "0x180A45AE0")]
		public AsyncOperationAwaiter(AsyncOperation asyncOperation)
		{
			this.asyncOperation = asyncOperation;
			useUnityContext = false;
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0xA458A0", Offset = "0xA442A0", VA = "0x180A458A0", Slot = "4")]
		public void OnCompleted(Action continuation)
		{
			bool flag = default(bool);
			if (!flag)
			{
				bool useContext = useUnityContext;
				Action<AsyncOperation> action = (Action<AsyncOperation>)(object)(Action<T>)delegate
				{
					//Discarded unreachable code: IL_0039
					if (!useContext)
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

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0")]
		public object GetResult()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xA45880", Offset = "0xA44280", VA = "0x180A45880")]
		public unsafe AsyncOperationAwaiter ConfigureUnityContext(bool useUnityContext)
		{
			//IL_0002: Expected O, but got Ref
			return (AsyncOperationAwaiter)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0xA45890", Offset = "0xA44290", VA = "0x180A45890")]
		public unsafe AsyncOperationAwaiter GetAwaiter()
		{
			//IL_0002: Expected O, but got Ref
			return (AsyncOperationAwaiter)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}
	}
}
