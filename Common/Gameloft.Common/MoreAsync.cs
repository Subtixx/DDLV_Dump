using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Log;
using Serilog;

namespace Gameloft.Common
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class MoreAsync
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static ILogger Logger
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4113CE0", Offset = "0x41126E0", VA = "0x184113CE0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x26CAB50", Offset = "0x26C9550", VA = "0x1826CAB50")]
		[AsyncStateMachine(typeof(_003CWithCancellation_003Ed__4<>))]
		public static Task<T> WithCancellation<T>(this Task<T> task, bool throwIfCancelled, CancellationToken ct)
		{
			Task<> result = default(Task<>);
			return (Task<T>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4113B80", Offset = "0x4112580", VA = "0x184113B80")]
		[AsyncStateMachine(typeof(_003CFireAndForgetTask_003Ed__5))]
		public static void FireAndForgetTask(this Task asyncTask)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4113AB0", Offset = "0x41124B0", VA = "0x184113AB0")]
		public static void CancelAndDispose(ref CancellationTokenSource tokenSource)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4113B00", Offset = "0x4112500", VA = "0x184113B00")]
		public static void CancelAndRenew(ref CancellationTokenSource tokenSource)
		{
			//Discarded unreachable code: IL_0013
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			cancellationTokenSource.Cancel();
			cancellationTokenSource.Dispose();
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4113C50", Offset = "0x4112650", VA = "0x184113C50")]
		static MoreAsync()
		{
			ILogger logger = Serilogger.Create("TaskExtensions");
			/*Error: Unexpected end of block*/;
		}
	}
}
