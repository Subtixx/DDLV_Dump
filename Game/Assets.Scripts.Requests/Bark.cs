using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Utils;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[Category("Mdl/Request")]
	[Icon("Dialogue", false, "")]
	public class Bark : MdlActionTask<IDialogueActor>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private BBParameter<System.Threading.Tasks.Task> doBarkTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private CancellationTokenSource cts;

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x163AAF0", Offset = "0x16394F0", VA = "0x18163AAF0", Slot = "13")]
		protected override void OnExecute()
		{
			((object)this)._002Ector();
			CancellationTokenSource cancellationTokenSource = (cts = new CancellationTokenSource());
			CancellationToken token = cts.Token;
			int num = 0;
			System.Threading.Tasks.Task task = default(System.Threading.Tasks.Task);
			BBParameter<> bBParameter = (BBParameter<>)(object)(doBarkTask = (BBParameter<System.Threading.Tasks.Task>)(object)BBParameter<T>.op_Implicit((T)task));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x163ACB0", Offset = "0x16396B0", VA = "0x18163ACB0", Slot = "14")]
		protected override void OnUpdate()
		{
			//Discarded unreachable code: IL_004c
			if (!((System.Threading.Tasks.Task)((BBParameter<T>)(object)doBarkTask).value).IsCompletedSuccessfully())
			{
				if (((System.Threading.Tasks.Task)((BBParameter<T>)(object)doBarkTask).value).IsCanceled || ((System.Threading.Tasks.Task)((BBParameter<T>)(object)doBarkTask).value).IsFaulted)
				{
					int success = 0;
					EndAction((byte)success != 0);
				}
			}
			else
			{
				EndAction(success: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x1617430", Offset = "0x1615E30", VA = "0x181617430", Slot = "16")]
		protected override void OnStop()
		{
			//Discarded unreachable code: IL_0012
			((object)this)._002Ector();
			cts.Cancel();
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x163A9D0", Offset = "0x16393D0", VA = "0x18163A9D0")]
		[AsyncStateMachine(typeof(_003CDoBark_003Ed__5))]
		private System.Threading.Tasks.Task DoBark(CancellationToken ct)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x163AD90", Offset = "0x1639790", VA = "0x18163AD90")]
		public Bark()
		{
			((MdlActionTask<T>)(object)this)._002Ector();
		}
	}
}
