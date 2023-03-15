using System;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	public static class AsyncEventHandlerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000C9E")]
		[Cpp2IlInjected.Address(RVA = "0x26EF000", Offset = "0x26EDA00", VA = "0x1826EF000")]
		public static Task InvokeAsync(this AsyncEventHandler asyncEventHandler, object sender, EventArgs arg)
		{
			//IL_000c: Expected O, but got I4
			Func<Delegate, object, EventArgs, Task> cpp2il__autoParamName__idx_ = (Func<Delegate, object, EventArgs, Task>)(object)new Func<T1, T2, T3, TResult>(GetTask);
			int num = 0;
			return InvokeAsync(asyncEventHandler, sender, arg, (Func<, , , >)(object)cpp2il__autoParamName__idx_);
			[Cpp2IlInjected.Token(Token = "0x6000CA1")]
			[Cpp2IlInjected.Address(RVA = "0x26EF0C0", Offset = "0x26EDAC0", VA = "0x1826EF0C0")]
			static Task GetTask(Delegate listener, object _sender, EventArgs _arg)
			{
				//Discarded unreachable code: IL_000a
				if ((object)listener != null)
				{
					return (Task)typeof(AsyncEventHandler).TypeHandle;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9F")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9A0", Offset = "0x7EE3A0", VA = "0x1807EF9A0")]
		public static Task InvokeAsync<T>(this AsyncEventHandler<T> asyncEventHandler, object sender, T arg)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA0")]
		[Cpp2IlInjected.Address(RVA = "0x7EFA40", Offset = "0x7EE440", VA = "0x1807EFA40")]
		private static Task InvokeAsync<T>(Delegate cpp2il__autoParamName__idx_0, object cpp2il__autoParamName__idx_1, T arg, Func<, , , > cpp2il__autoParamName__idx_3)
		{
			if ((object)cpp2il__autoParamName__idx_0 != null)
			{
				Delegate[] invocationList = cpp2il__autoParamName__idx_0.GetInvocationList();
				Task[] tasks = new Task[invocationList.Length];
				int num = 0;
				int length = invocationList.Length;
				if (num < length)
				{
					num++;
				}
				return Task.WhenAll(tasks);
			}
			int num2 = 0;
			return Task.CompletedTask;
		}
	}
}
