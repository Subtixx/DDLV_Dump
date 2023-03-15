using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Util;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;

namespace Mdl.Dialogues
{
	[Cpp2IlInjected.Token(Token = "0x2000825")]
	public class DialogueInstance
	{
		[Cpp2IlInjected.Token(Token = "0x2000826")]
		public class PriorityComparer : IComparer<DialogueInstance>
		{
			[Cpp2IlInjected.Token(Token = "0x4002D78")]
			public static readonly PriorityComparer Instance;

			[Cpp2IlInjected.Token(Token = "0x6002495")]
			[Cpp2IlInjected.Address(RVA = "0x137DFB0", Offset = "0x137C9B0", VA = "0x18137DFB0", Slot = "4")]
			public int Compare(DialogueInstance x, DialogueInstance y)
			{
				//Discarded unreachable code: IL_0010
				int priority = x.Priority;
				int priority2 = y.Priority;
				int result = default(int);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6002496")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public PriorityComparer()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6002497")]
			[Cpp2IlInjected.Address(RVA = "0x137DFF0", Offset = "0x137C9F0", VA = "0x18137DFF0")]
			static PriorityComparer()
			{
				PriorityComparer priorityComparer = new PriorityComparer();
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002D69")]
		public readonly DialogueType DialogueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002D6A")]
		public readonly DialogueTree DialogueTree;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002D6B")]
		public readonly IDialogueActor Instigator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002D6C")]
		public readonly int Priority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002D6D")]
		public readonly IBlackboard Blackboard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002D6E")]
		public readonly CancellationToken CancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002D6F")]
		private TaskCompletionSource<StartDialogueResult> tcs = (TaskCompletionSource<StartDialogueResult>)(object)new TaskCompletionSource<TResult>();

		[Cpp2IlInjected.Token(Token = "0x1700052E")]
		public Task<StartDialogueResult> FinishTask
		{
			[Cpp2IlInjected.Token(Token = "0x600247D")]
			[Cpp2IlInjected.Address(RVA = "0x162F570", Offset = "0x162DF70", VA = "0x18162F570")]
			get
			{
				//Discarded unreachable code: IL_000c
				return (Task<StartDialogueResult>)(object)((TaskCompletionSource<>)(object)tcs).m_task;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700052F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x4002D70")]
		public bool Paused
		{
			[Cpp2IlInjected.Token(Token = "0x600247E")]
			[Cpp2IlInjected.Address(RVA = "0x951C70", Offset = "0x950670", VA = "0x180951C70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600247F")]
			[Cpp2IlInjected.Address(RVA = "0x951E90", Offset = "0x950890", VA = "0x180951E90")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000530")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x49"), Cpp2IlInjected.Token(Token = "0x4002D71")]
		internal bool ReleaseOnStop
		{
			[Cpp2IlInjected.Token(Token = "0x6002480")]
			[Cpp2IlInjected.Address(RVA = "0x162F5B0", Offset = "0x162DFB0", VA = "0x18162F5B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002481")]
			[Cpp2IlInjected.Address(RVA = "0x162F980", Offset = "0x162E380", VA = "0x18162F980")]
			set;
		} = true;


		[Cpp2IlInjected.Token(Token = "0x14000052")]
		public event EventHandler OnDialoguePaused
		{
			[Cpp2IlInjected.Token(Token = "0x6002485")]
			[Cpp2IlInjected.Address(RVA = "0x162F250", Offset = "0x162DC50", VA = "0x18162F250")]
			[CompilerGenerated]
			add
			{
				EventHandler onDialoguePaused = this.OnDialoguePaused;
				Delegate @delegate = Delegate.Combine(onDialoguePaused, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDialoguePaused)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002486")]
			[Cpp2IlInjected.Address(RVA = "0x162F660", Offset = "0x162E060", VA = "0x18162F660")]
			[CompilerGenerated]
			remove
			{
				EventHandler onDialoguePaused = this.OnDialoguePaused;
				Delegate @delegate = Delegate.Remove(onDialoguePaused, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDialoguePaused)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000053")]
		public event EventHandler OnDialogueResumed
		{
			[Cpp2IlInjected.Token(Token = "0x6002487")]
			[Cpp2IlInjected.Address(RVA = "0x162F2F0", Offset = "0x162DCF0", VA = "0x18162F2F0")]
			[CompilerGenerated]
			add
			{
				EventHandler onDialogueResumed = this.OnDialogueResumed;
				Delegate @delegate = Delegate.Combine(onDialogueResumed, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDialogueResumed)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002488")]
			[Cpp2IlInjected.Address(RVA = "0x162F700", Offset = "0x162E100", VA = "0x18162F700")]
			[CompilerGenerated]
			remove
			{
				EventHandler onDialogueResumed = this.OnDialogueResumed;
				Delegate @delegate = Delegate.Remove(onDialogueResumed, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDialogueResumed)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000054")]
		public event AsyncEventHandler OnDialogueFinished
		{
			[Cpp2IlInjected.Token(Token = "0x6002489")]
			[Cpp2IlInjected.Address(RVA = "0x162F1B0", Offset = "0x162DBB0", VA = "0x18162F1B0")]
			[CompilerGenerated]
			add
			{
				AsyncEventHandler onDialogueFinished = this.OnDialogueFinished;
				Delegate @delegate = Delegate.Combine(onDialogueFinished, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDialogueFinished)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600248A")]
			[Cpp2IlInjected.Address(RVA = "0x162F5C0", Offset = "0x162DFC0", VA = "0x18162F5C0")]
			[CompilerGenerated]
			remove
			{
				AsyncEventHandler onDialogueFinished = this.OnDialogueFinished;
				Delegate @delegate = Delegate.Remove(onDialogueFinished, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDialogueFinished)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000055")]
		public event AsyncEventHandler OnDialogueWillFinish
		{
			[Cpp2IlInjected.Token(Token = "0x600248B")]
			[Cpp2IlInjected.Address(RVA = "0x162F390", Offset = "0x162DD90", VA = "0x18162F390")]
			[CompilerGenerated]
			add
			{
				AsyncEventHandler onDialogueWillFinish = this.OnDialogueWillFinish;
				Delegate @delegate = Delegate.Combine(onDialogueWillFinish, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDialogueWillFinish)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600248C")]
			[Cpp2IlInjected.Address(RVA = "0x162F7A0", Offset = "0x162E1A0", VA = "0x18162F7A0")]
			[CompilerGenerated]
			remove
			{
				AsyncEventHandler onDialogueWillFinish = this.OnDialogueWillFinish;
				Delegate @delegate = Delegate.Remove(onDialogueWillFinish, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDialogueWillFinish)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000056")]
		public event EventHandler<SubtitlesRequestInfo> OnSubtitleRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600248D")]
			[Cpp2IlInjected.Address(RVA = "0x162F4D0", Offset = "0x162DED0", VA = "0x18162F4D0")]
			[CompilerGenerated]
			add
			{
				EventHandler<SubtitlesRequestInfo> onSubtitleRequest = this.OnSubtitleRequest;
				Delegate @delegate = Delegate.Combine(onSubtitleRequest, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSubtitleRequest)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600248E")]
			[Cpp2IlInjected.Address(RVA = "0x162F8E0", Offset = "0x162E2E0", VA = "0x18162F8E0")]
			[CompilerGenerated]
			remove
			{
				EventHandler<SubtitlesRequestInfo> onSubtitleRequest = this.OnSubtitleRequest;
				Delegate @delegate = Delegate.Remove(onSubtitleRequest, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSubtitleRequest)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000057")]
		public event EventHandler<MultipleChoiceRequestInfo> OnMultipleChoiceRequest
		{
			[Cpp2IlInjected.Token(Token = "0x6002490")]
			[Cpp2IlInjected.Address(RVA = "0x162F430", Offset = "0x162DE30", VA = "0x18162F430")]
			[CompilerGenerated]
			add
			{
				EventHandler<MultipleChoiceRequestInfo> onMultipleChoiceRequest = this.OnMultipleChoiceRequest;
				Delegate @delegate = Delegate.Combine(onMultipleChoiceRequest, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onMultipleChoiceRequest)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002491")]
			[Cpp2IlInjected.Address(RVA = "0x162F840", Offset = "0x162E240", VA = "0x18162F840")]
			[CompilerGenerated]
			remove
			{
				EventHandler<MultipleChoiceRequestInfo> onMultipleChoiceRequest = this.OnMultipleChoiceRequest;
				Delegate @delegate = Delegate.Remove(onMultipleChoiceRequest, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onMultipleChoiceRequest)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002482")]
		[Cpp2IlInjected.Address(RVA = "0x162F0C0", Offset = "0x162DAC0", VA = "0x18162F0C0")]
		public DialogueInstance(DialogueType dialogueType, DialogueTree dialogueTree, IDialogueActor instigator, [Optional] IBlackboard blackboard, int priority = 0, [Optional] CancellationToken ct)
		{
			//IL_0038: Expected O, but got I4
			//IL_0046: Expected O, but got I4
			DialogueTree = dialogueTree;
			DialogueType = dialogueType;
			Instigator = instigator;
			Blackboard = (IBlackboard)0;
			Priority = 0;
			CancellationToken = (CancellationToken)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002483")]
		[Cpp2IlInjected.Address(RVA = "0x162EDD0", Offset = "0x162D7D0", VA = "0x18162EDD0")]
		internal void Pause()
		{
			bool flag = Paused;
			Paused = true;
			if (!flag && this.OnDialoguePaused == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002484")]
		[Cpp2IlInjected.Address(RVA = "0x162EF20", Offset = "0x162D920", VA = "0x18162EF20")]
		internal void Resume()
		{
			bool flag = Paused;
			Paused = false;
			if (flag && this.OnDialogueResumed == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600248F")]
		[Cpp2IlInjected.Address(RVA = "0x162EEC0", Offset = "0x162D8C0", VA = "0x18162EEC0")]
		internal void RaiseSubtitleRequest(SubtitlesRequestInfo subtitlesRequestInfo)
		{
			((EventHandler<TEventArgs>)(object)this.OnSubtitleRequest)?.Invoke((object)this, (TEventArgs)subtitlesRequestInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6002492")]
		[Cpp2IlInjected.Address(RVA = "0x162EE60", Offset = "0x162D860", VA = "0x18162EE60")]
		internal void RaiseMultipleChoiceRequest(MultipleChoiceRequestInfo multipleChoiceRequestInfo)
		{
			((EventHandler<TEventArgs>)(object)this.OnMultipleChoiceRequest)?.Invoke((object)this, (TEventArgs)multipleChoiceRequestInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6002493")]
		[Cpp2IlInjected.Address(RVA = "0x162EFB0", Offset = "0x162D9B0", VA = "0x18162EFB0")]
		[AsyncStateMachine(typeof(_003CSetTaskCompletion_003Ed__40))]
		internal System.Threading.Tasks.Task SetTaskCompletion(StartDialogueResult startDialogueResult)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002494")]
		[Cpp2IlInjected.Address(RVA = "0x162ED00", Offset = "0x162D700", VA = "0x18162ED00")]
		[AsyncStateMachine(typeof(_003CApplyOverrideFlagChanges_003Ed__42))]
		public System.Threading.Tasks.Task ApplyOverrideFlagChanges()
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}
	}
}
