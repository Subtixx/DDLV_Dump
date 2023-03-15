using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Gameloft.Common;
using Mdl.Characters;
using Mdl.Systems;
using Meta;
using NodeCanvas;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Dialogues
{
	[Cpp2IlInjected.Token(Token = "0x2000829")]
	public class DialogueSystem : Mdl.Systems.System
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002D81")]
		private readonly Stack<DialogueInstance> currentDialogues = (Stack<DialogueInstance>)(object)new Stack<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002D82")]
		[Header("Gift Animation Settings")]
		public float giveOffset = -0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4002D83")]
		public float animationTime = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002D84")]
		public float presentationTime = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002D85")]
		public AssetReferenceGameObject itemPickedUpGizmoPrefab;

		[Cpp2IlInjected.Token(Token = "0x4002D86")]
		public const string FLUX_MULTIPLE_CHOICE_CLASS_NAME = "FluxMultipleChoiceNode";

		[Cpp2IlInjected.Token(Token = "0x4002D87")]
		public const string FLUX_GREETING_SWITCHER_CLASS_NAME = "FluxGreetingDialogueSwitcherNode";

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002D88")]
		public AssetReference GiveItemFastConfirmPopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002D89")]
		private List<DialogueInstance> queuedDialogues = (List<DialogueInstance>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002D8A")]
		private TaskCompletionSource<bool> queuedDialoguesCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x17000531")]
		internal InventoryFullResolution DialogueInventoryFullResolution
		{
			[Cpp2IlInjected.Token(Token = "0x60024A1")]
			[Cpp2IlInjected.Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
			[CompilerGenerated]
			get
			{
				return _003CDialogueInventoryFullResolution_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60024A2")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACE0", Offset = "0xA596E0", VA = "0x180A5ACE0")]
			[CompilerGenerated]
			set
			{
				_003CDialogueInventoryFullResolution_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000532")]
		public bool TalkingToPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60024AB")]
			[Cpp2IlInjected.Address(RVA = "0x1631590", Offset = "0x162FF90", VA = "0x181631590")]
			get
			{
				Stack<DialogueInstance> stack = currentDialogues;
				Func<DialogueInstance, bool> _003C_003E9__30_ = _003C_003Ec._003C_003E9__30_0;
				if (_003C_003E9__30_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((DialogueInstance x) => x.DialogueType == DialogueType.TalkToPlayer);
				}
				return Enumerable.Count<DialogueInstance>((IEnumerable<>)stack, (Func<, >)(object)_003C_003E9__30_) > 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000058")]
		public event AsyncEventHandler<DialogueInstance> NewDialogueStartedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600249D")]
			[Cpp2IlInjected.Address(RVA = "0x16314F0", Offset = "0x162FEF0", VA = "0x1816314F0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600249E")]
			[Cpp2IlInjected.Address(RVA = "0x1631760", Offset = "0x1630160", VA = "0x181631760")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000059")]
		public event AsyncEventHandler<DialogueInstance> CurrentDialogueFinishedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600249F")]
			[Cpp2IlInjected.Address(RVA = "0x1631450", Offset = "0x162FE50", VA = "0x181631450")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60024A0")]
			[Cpp2IlInjected.Address(RVA = "0x16316C0", Offset = "0x16300C0", VA = "0x1816316C0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600249C")]
		[Cpp2IlInjected.Address(RVA = "0x162F990", Offset = "0x162E390", VA = "0x18162F990")]
		[AsyncStateMachine(typeof(_003CAllTalkToPlayerDialoguesOverTask_003Ed__10))]
		public System.Threading.Tasks.Task AllTalkToPlayerDialoguesOverTask()
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60024A3")]
		[Cpp2IlInjected.Address(RVA = "0x1630020", Offset = "0x162EA20", VA = "0x181630020", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			DialogueTree.add_OnDialogueStarted((Action<>)(object)new Action<T>(OnDialogueStarted));
			DialogueTree.add_OnDialoguePaused((Action<>)(object)new Action<T>(OnDialoguePaused));
			DialogueTree.add_OnSubtitlesRequest((Action<>)(object)new Action<T>(OnSubtitlesRequest));
			DialogueTree.add_OnMultipleChoiceRequest((Action<>)(object)new Action<T>(OnMultipleChoiceRequest));
		}

		[Cpp2IlInjected.Token(Token = "0x60024A4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnSystemPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60024A5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60024A6")]
		[Cpp2IlInjected.Address(RVA = "0x1630190", Offset = "0x162EB90", VA = "0x181630190", Slot = "5")]
		public override void OnSystemStop()
		{
			DialogueTree.remove_OnDialogueStarted((Action<>)(object)new Action<T>(OnDialogueStarted));
			DialogueTree.remove_OnDialoguePaused((Action<>)(object)new Action<T>(OnDialoguePaused));
			DialogueTree.remove_OnSubtitlesRequest((Action<>)(object)new Action<T>(OnSubtitlesRequest));
			DialogueTree.remove_OnMultipleChoiceRequest((Action<>)(object)new Action<T>(OnMultipleChoiceRequest));
		}

		[Cpp2IlInjected.Token(Token = "0x60024A7")]
		[Cpp2IlInjected.Address(RVA = "0x1536C40", Offset = "0x1535640", VA = "0x181536C40")]
		private void OnDestroy()
		{
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x60024A8")]
		[Cpp2IlInjected.Address(RVA = "0x1630580", Offset = "0x162EF80", VA = "0x181630580")]
		[AsyncStateMachine(typeof(_003CQueueDialogue_003Ed__26))]
		public Task<StartDialogueResult> QueueDialogue(DialogueType dialogueType, DialogueTree dialogueTree, [Optional] IDialogueActor instigator, [Optional] IBlackboard blackboard, int priority = 0, [Optional] Func<System.Threading.Tasks.Task> onComplete, bool mustRestoreCurrentDialogue = false)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<StartDialogueResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60024A9")]
		[Cpp2IlInjected.Address(RVA = "0x1630CC0", Offset = "0x162F6C0", VA = "0x181630CC0")]
		public Task<StartDialogueResult> StartDialogue(DialogueType dialogueType, DialogueTree dialogueTree, [Optional] IDialogueActor instigator, [Optional] IBlackboard blackboard, [Optional] CancellationToken ct)
		{
			//Discarded unreachable code: IL_0055
			//IL_0032: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			//IL_0042: Expected I4, but got I8
			DialogueInstance dialogueInstance = default(DialogueInstance);
			TaskCompletionSource<StartDialogueResult> taskCompletionSource = (dialogueInstance.tcs = (TaskCompletionSource<StartDialogueResult>)(object)new TaskCompletionSource<TResult>());
			dialogueInstance.ReleaseOnStop = true;
			dialogueInstance.DialogueTree = dialogueTree;
			dialogueInstance.DialogueType = dialogueType;
			dialogueInstance.Instigator = instigator;
			dialogueInstance.Blackboard = (IBlackboard)0;
			dialogueInstance.CancellationToken = (CancellationToken)0;
			dialogueInstance.Priority = 0;
			TryPlayDialogue(dialogueInstance);
			return (Task<StartDialogueResult>)(object)((TaskCompletionSource<>)(object)dialogueInstance.tcs).m_task;
		}

		[Cpp2IlInjected.Token(Token = "0x60024AA")]
		[Cpp2IlInjected.Address(RVA = "0x1630E30", Offset = "0x162F830", VA = "0x181630E30")]
		private void TryPlayDialogue(DialogueInstance dialogueInstance)
		{
			DialogueInstance dialogueInstance2 = (DialogueInstance)((Stack<T>)(object)currentDialogues).Peek();
			DialogueType dialogueType = default(DialogueType);
			if (dialogueInstance.DialogueType < dialogueType)
			{
				int success = 0;
				DialogueTree dialogueTree = default(DialogueTree);
				dialogueTree.Stop((byte)success != 0);
				int num = 0;
				System.Threading.Tasks.Task asyncTask = default(System.Threading.Tasks.Task);
				asyncTask.FireAndForgetTask();
				return;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60024AC")]
		[Cpp2IlInjected.Address(RVA = "0x1630300", Offset = "0x162ED00", VA = "0x181630300")]
		[AsyncStateMachine(typeof(_003CPlayDialogue_003Ed__31))]
		private System.Threading.Tasks.Task PlayDialogue(DialogueInstance instance)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60024AD")]
		[Cpp2IlInjected.Address(RVA = "0x1630720", Offset = "0x162F120", VA = "0x181630720")]
		private Task<bool> ResumePreviousDialogue()
		{
			//Discarded unreachable code: IL_0037
			//IL_002f: Expected I4, but got I8
			//IL_002f: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			DialogueInstance dialogueInstance = (DialogueInstance)((Stack<T>)(object)currentDialogues).Peek();
			if (dialogueInstance != null)
			{
				IDialogueActor instigator = dialogueInstance.Instigator;
				DialogueTree dialogueTree = dialogueInstance.DialogueTree;
				int num = 0;
				int num2 = 0;
				ulong num3 = default(ulong);
				return (Task<bool>)(object)NodeCanvasExtensions.StartDialogueAsync(dialogueTree, instigator, (IBlackboard)num2, (CancellationToken)num, (byte)num3 != 0);
			}
			return (Task<bool>)(object)System.Threading.Tasks.Task.FromResult(result: false);
		}

		[Cpp2IlInjected.Token(Token = "0x60024AE")]
		[Cpp2IlInjected.Address(RVA = "0x162FDD0", Offset = "0x162E7D0", VA = "0x18162FDD0")]
		private void OnDialogueStarted(DialogueTree obj)
		{
			//Discarded unreachable code: IL_002c
			DialogueInstance dialogueInstance = (DialogueInstance)((Stack<T>)(object)currentDialogues).Peek();
			if (dialogueInstance != null)
			{
				bool _003CPaused_003Ek__BackingField = dialogueInstance.Paused;
				dialogueInstance.Paused = false;
				if (_003CPaused_003Ek__BackingField && dialogueInstance.OnDialogueResumed == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024AF")]
		[Cpp2IlInjected.Address(RVA = "0x162FCE0", Offset = "0x162E6E0", VA = "0x18162FCE0")]
		private void OnDialoguePaused(DialogueTree obj)
		{
			//Discarded unreachable code: IL_002c
			DialogueInstance dialogueInstance = (DialogueInstance)((Stack<T>)(object)currentDialogues).Peek();
			if (dialogueInstance != null)
			{
				bool _003CPaused_003Ek__BackingField = dialogueInstance.Paused;
				dialogueInstance.Paused = true;
				if (!_003CPaused_003Ek__BackingField && dialogueInstance.OnDialoguePaused == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024B0")]
		[Cpp2IlInjected.Address(RVA = "0x162FF70", Offset = "0x162E970", VA = "0x18162FF70")]
		private void OnSubtitlesRequest(SubtitlesRequestInfo obj)
		{
			//Discarded unreachable code: IL_0024
			DialogueInstance dialogueInstance = (DialogueInstance)((Stack<T>)(object)currentDialogues).Peek();
			((EventHandler<TEventArgs>)(object)dialogueInstance?.OnSubtitleRequest)?.Invoke((object)dialogueInstance, (TEventArgs)obj);
		}

		[Cpp2IlInjected.Token(Token = "0x60024B1")]
		[Cpp2IlInjected.Address(RVA = "0x162FEC0", Offset = "0x162E8C0", VA = "0x18162FEC0")]
		private void OnMultipleChoiceRequest(MultipleChoiceRequestInfo obj)
		{
			//Discarded unreachable code: IL_0024
			DialogueInstance dialogueInstance = (DialogueInstance)((Stack<T>)(object)currentDialogues).Peek();
			((EventHandler<TEventArgs>)(object)dialogueInstance?.OnMultipleChoiceRequest)?.Invoke((object)dialogueInstance, (TEventArgs)obj);
		}

		[Cpp2IlInjected.Token(Token = "0x60024B2")]
		[Cpp2IlInjected.Address(RVA = "0x162FC80", Offset = "0x162E680", VA = "0x18162FC80")]
		private DialogueInstance GetCurrentDialogue()
		{
			//Discarded unreachable code: IL_0010
			Stack<DialogueInstance> stack = currentDialogues;
			int num = 0;
			return (DialogueInstance)((Stack<T>)(object)stack).Peek();
		}

		[Cpp2IlInjected.Token(Token = "0x60024B3")]
		[Cpp2IlInjected.Address(RVA = "0x162FA90", Offset = "0x162E490", VA = "0x18162FA90")]
		public List<Item> GetCurrentDialogueCharacters()
		{
			//Discarded unreachable code: IL_005a
			List<Item> result = (List<Item>)(object)new List<T>();
			DialogueInstance dialogueInstance = (DialogueInstance)((Stack<T>)(object)currentDialogues).Peek();
			if (dialogueInstance != null && dialogueInstance.DialogueType == DialogueType.TalkToPlayer)
			{
				List<DialogueTree.ActorParameter> actorParameters = dialogueInstance.DialogueTree._actorParameters;
				Func<DialogueTree.ActorParameter, Item> _003C_003E9__38_ = _003C_003Ec._003C_003E9__38_0;
				if (_003C_003E9__38_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(DialogueTree.ActorParameter x)
					{
						IDialogueActor actor = x.actor;
						int num = 0;
						if (actor != null)
						{
							int num2 = 0;
							if (actor != null)
							{
								throw new NullReferenceException();
							}
						}
						throw new InvalidCastException();
					};
				}
				List<Item> list = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<DialogueTree.ActorParameter, Item>((IEnumerable<>)actorParameters, (Func<, >)(object)_003C_003E9__38_));
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60024B4")]
		[Cpp2IlInjected.Address(RVA = "0x1630800", Offset = "0x162F200", VA = "0x181630800")]
		public void SetCurrentDialogueActor(Mdl.Characters.Character character)
		{
			//Discarded unreachable code: IL_004f
			DialogueInstance dialogueInstance = (DialogueInstance)((Stack<T>)(object)currentDialogues).Peek();
			if (dialogueInstance == null)
			{
				return;
			}
			List<DialogueTree.ActorParameter> actorParameters = dialogueInstance.DialogueTree._actorParameters;
			Func<DialogueTree.ActorParameter, bool> _003C_003E9__39_ = _003C_003Ec._003C_003E9__39_0;
			if (_003C_003E9__39_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(DialogueTree.ActorParameter x)
				{
					//Discarded unreachable code: IL_001d
					IDialogueActor actor = x.actor;
					if (actor == null)
					{
						return actor != null;
					}
					int num = 0;
					return actor != null;
				};
			}
			DialogueTree.ActorParameter actorParameter = Enumerable.FirstOrDefault<DialogueTree.ActorParameter>((IEnumerable<>)actorParameters, (Func<, >)(object)_003C_003E9__39_);
			if (actorParameter != null)
			{
				actorParameter.actor = character;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024B5")]
		[Cpp2IlInjected.Address(RVA = "0x16309B0", Offset = "0x162F3B0", VA = "0x1816309B0")]
		public void SetupGiveAnimationDialogueFailsafe(IBlackboard blackboard, bool prepareNow = false)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60024B6")]
		[Cpp2IlInjected.Address(RVA = "0x1630430", Offset = "0x162EE30", VA = "0x181630430")]
		internal void PrepareGiveAnimationDialogueFailsafe()
		{
			//Discarded unreachable code: IL_0039
			DialogueInstance dialogueInstance = (DialogueInstance)((Stack<T>)(object)currentDialogues).Peek();
			if (dialogueInstance != null)
			{
				AsyncEventHandler b = OnGiveDialogueWillFinish;
				AsyncEventHandler onDialogueWillFinish = dialogueInstance.OnDialogueWillFinish;
				Delegate @delegate = Delegate.Combine(onDialogueWillFinish, b);
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				while ((object)@delegate != onDialogueWillFinish)
				{
				}
			}
			[Cpp2IlInjected.Token(Token = "0x60024B9")]
			[Cpp2IlInjected.Address(RVA = "0x1631100", Offset = "0x162FB00", VA = "0x181631100")]
			[AsyncStateMachine(typeof(_003C_003CPrepareGiveAnimationDialogueFailsafe_003Eg__OnGiveDialogueWillFinish_007C41_0_003Ed))]
			System.Threading.Tasks.Task OnGiveDialogueWillFinish(object sender, EventArgs arg)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024B7")]
		[Cpp2IlInjected.Address(RVA = "0x1631370", Offset = "0x162FD70", VA = "0x181631370")]
		public DialogueSystem()
		{
		}
	}
}
