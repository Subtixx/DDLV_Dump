using System;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[Category("Mdl/Request")]
	[Icon("Dialogue", false, "")]
	public class DebugAddFreeTimer : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public BBParameter<TimerType> TimerType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		private CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		private System.Threading.Tasks.Task completeRequestTask;

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x1617290", Offset = "0x1615C90", VA = "0x181617290", Slot = "13")]
		protected override void OnExecute()
		{
			//IL_002a: Expected I4, but got O
			CancellationTokenSource cancellationTokenSource = (cts = new CancellationTokenSource());
			Client metaClient = SystemRoot.Instance.MetaClient;
			Meta.DebugAddFreeTimer.Types.Request request = new Meta.DebugAddFreeTimer.Types.Request();
			TimerType timerType = (request.timerType_ = (TimerType)((BBParameter<T>)(object)TimerType).value);
			CancellationToken token = cts.Token;
			Task<Meta.DebugAddFreeTimer.Types.Response> task = (Task<Meta.DebugAddFreeTimer.Types.Response>)(completeRequestTask = metaClient.DebugAddFreeTimer(request, token));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x1617460", Offset = "0x1615E60", VA = "0x181617460", Slot = "14")]
		protected override void OnUpdate()
		{
			//Discarded unreachable code: IL_0055
			if (!completeRequestTask.IsCompletedSuccessfully())
			{
				if (completeRequestTask.IsFaulted || completeRequestTask.IsCanceled)
				{
					AggregateException exception = completeRequestTask.Exception;
					string text = $"CompleteRequest failed {exception}";
					int success = 0;
					EndAction((byte)success != 0);
				}
			}
			else
			{
				EndAction(success: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x1617430", Offset = "0x1615E30", VA = "0x181617430", Slot = "16")]
		protected override void OnStop()
		{
			//Discarded unreachable code: IL_0012
			((object)this)._002Ector();
			cts.Cancel();
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x8CB450", Offset = "0x8C9E50", VA = "0x1808CB450")]
		public DebugAddFreeTimer()
		{
		}
	}
}
