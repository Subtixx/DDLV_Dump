using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Meta.Online;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Ftue
{
	[Cpp2IlInjected.Token(Token = "0x2000571")]
	public class FtueEventListener : Mdl.Systems.System
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40021AD")]
		private List<FtueEvent> pendingEvents = (List<FtueEvent>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40021AE")]
		private Queue<FtueEvent> triggeredEvents = (Queue<FtueEvent>)(object)new Queue<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40021AF")]
		private CancellationTokenSource ctSource = new CancellationTokenSource();

		[Cpp2IlInjected.Token(Token = "0x40021B0")]
		private static HashSet<IFtueElement> registeredElements;

		[Cpp2IlInjected.Token(Token = "0x1700033A")]
		[field: Cpp2IlInjected.Token(Token = "0x40021AC")]
		public static bool DebugDisableUI
		{
			[Cpp2IlInjected.Token(Token = "0x6001862")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B37B0", VA = "0x1808B4DB0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001863")]
			[Cpp2IlInjected.Address(RVA = "0x8B4EE0", Offset = "0x8B38E0", VA = "0x1808B4EE0")]
			set;
		} = (byte)(int)new HashSet<T>() != 0;


		[Cpp2IlInjected.Token(Token = "0x1700033B")]
		public bool EventIsOngoing
		{
			[Cpp2IlInjected.Token(Token = "0x6001864")]
			[Cpp2IlInjected.Address(RVA = "0x8B4E10", Offset = "0x8B3810", VA = "0x1808B4E10")]
			get
			{
				//Discarded unreachable code: IL_0011
				Queue<FtueEvent> queue = triggeredEvents;
				return !base.IsPaused;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700033C")]
		public IEnumerable<FtueEvent> PendingEvents
		{
			[Cpp2IlInjected.Token(Token = "0x6001865")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				List<FtueEvent> list = pendingEvents;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700033D")]
		public IEnumerable<FtueEvent> TriggeredEvents
		{
			[Cpp2IlInjected.Token(Token = "0x6001866")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				Queue<FtueEvent> queue = triggeredEvents;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700033E")]
		private static DateTime? DebugAutoSkip
		{
			[Cpp2IlInjected.Token(Token = "0x6001872")]
			[Cpp2IlInjected.Address(RVA = "0x8B4D40", Offset = "0x8B3740", VA = "0x1808B4D40")]
			[CompilerGenerated]
			get
			{
				DateTime? dateTime = _003CDebugAutoSkip_003Ek__BackingField;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6001873")]
			[Cpp2IlInjected.Address(RVA = "0x8B4E70", Offset = "0x8B3870", VA = "0x1808B4E70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001867")]
		[Cpp2IlInjected.Address(RVA = "0x8B4920", Offset = "0x8B3320", VA = "0x1808B4920")]
		public static void RegisterElement(IFtueElement element)
		{
			//Discarded unreachable code: IL_001c
			if (!((HashSet<T>)(object)registeredElements).Contains((T)element))
			{
				bool flag = ((HashSet<T>)(object)registeredElements).Add((T)element);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001868")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B40", Offset = "0x8B3540", VA = "0x1808B4B40")]
		public static void UnregisterElement(IFtueElement element)
		{
			//Discarded unreachable code: IL_000d
			bool flag = ((HashSet<T>)(object)registeredElements).Remove((T)element);
		}

		[Cpp2IlInjected.Token(Token = "0x6001869")]
		[Cpp2IlInjected.Address(RVA = "0x8B3850", Offset = "0x8B2250", VA = "0x1808B3850")]
		public static IFtueElement GetElementToActivate(FtueStep step)
		{
			int num = 0;
			HashSet<IFtueElement> hashSet = registeredElements;
			bool flag = default(bool);
			if (flag)
			{
				num += num;
				num++;
				while (!flag)
				{
				}
				num++;
			}
			if (num + 1 != 0)
			{
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600186A")]
		[Cpp2IlInjected.Address(RVA = "0x8B3B70", Offset = "0x8B2570", VA = "0x1808B3B70")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__17))]
		public Task Init(Client client)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600186B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4740", Offset = "0x8B3140", VA = "0x1808B4740")]
		private void OnEventTriggered(FtueEvent evt)
		{
			//Discarded unreachable code: IL_004f
			if (((Queue<T>)(object)triggeredEvents).Contains((T)evt))
			{
				return;
			}
			((Queue<T>)(object)triggeredEvents).Enqueue((T)evt);
			if (!base.IsPaused)
			{
				Queue<FtueEvent> queue = triggeredEvents;
				if (base.gameObject.activeInHierarchy)
				{
					StopAllCoroutines();
					IEnumerator routine = ExecuteAllEvents();
					Coroutine coroutine = StartCoroutine(routine);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600186C")]
		[Cpp2IlInjected.Address(RVA = "0x8B3700", Offset = "0x8B2100", VA = "0x1808B3700")]
		[IteratorStateMachine(typeof(_003CExecuteAllEvents_003Ed__19))]
		private IEnumerator ExecuteAllEvents()
		{
			int _003C_003E1__state = default(int);
			_003CExecuteAllEvents_003Ed__19 _003CExecuteAllEvents_003Ed__ = new _003CExecuteAllEvents_003Ed__19(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CExecuteAllEvents_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600186D")]
		[Cpp2IlInjected.Address(RVA = "0x8B3600", Offset = "0x8B2000", VA = "0x1808B3600")]
		[AsyncStateMachine(typeof(_003CExecuteAllEventsAsync_003Ed__20))]
		private Task ExecuteAllEventsAsync()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600186E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A00", Offset = "0x8B3400", VA = "0x1808B4A00")]
		public void SkipCurrentEvent()
		{
			//Discarded unreachable code: IL_000c
			ctSource.Cancel();
		}

		[Cpp2IlInjected.Token(Token = "0x600186F")]
		[Cpp2IlInjected.Address(RVA = "0x8B3770", Offset = "0x8B2170", VA = "0x1808B3770")]
		public FtueEvent FindEvent(int ftueItem)
		{
			//Discarded unreachable code: IL_0029
			List<FtueEvent> list = pendingEvents;
			Func<FtueEvent, bool> func = (Func<FtueEvent, bool>)(object)(Func<T, TResult>)delegate(FtueEvent e)
			{
				//Discarded unreachable code: IL_0018
				FtueItemData _003CItemData_003Ek__BackingField = e.ItemData;
				int num = ftueItem;
				return _003CItemData_003Ek__BackingField.iD_ == num;
			};
			return Enumerable.FirstOrDefault<FtueEvent>((IEnumerable<>)list, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6001870")]
		[Cpp2IlInjected.Address(RVA = "0x8B33B0", Offset = "0x8B1DB0", VA = "0x1808B33B0")]
		[AsyncStateMachine(typeof(_003CDebugForceTriggerEvent_003Ed__23))]
		public Task DebugForceTriggerEvent(int ftueItem)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001871")]
		[Cpp2IlInjected.Address(RVA = "0x8B34D0", Offset = "0x8B1ED0", VA = "0x1808B34D0")]
		[AsyncStateMachine(typeof(_003CDebugResetEvent_003Ed__24))]
		public Task DebugResetEvent(int ftueItem)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001874")]
		[Cpp2IlInjected.Address(RVA = "0x8B32B0", Offset = "0x8B1CB0", VA = "0x1808B32B0")]
		[AsyncStateMachine(typeof(_003CDebugCompleteAllTriggeredEvents_003Ed__29))]
		public Task DebugCompleteAllTriggeredEvents()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001875")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001876")]
		[Cpp2IlInjected.Address(RVA = "0x8B4900", Offset = "0x8B3300", VA = "0x1808B4900", Slot = "5")]
		public override void OnSystemStop()
		{
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x6001877")]
		[Cpp2IlInjected.Address(RVA = "0x8B48F0", Offset = "0x8B32F0", VA = "0x1808B48F0", Slot = "6")]
		public override void OnSystemPause()
		{
			StopAllCoroutines();
		}

		[Cpp2IlInjected.Token(Token = "0x6001878")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001879")]
		[Cpp2IlInjected.Address(RVA = "0x8B4510", Offset = "0x8B2F10", VA = "0x1808B4510")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0049, IL_004f, IL_0055, IL_005b
			//IL_0048: Expected O, but got I4
			((Queue<T>)(object)triggeredEvents).Clear();
			List<FtueEvent> list = pendingEvents;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				bool flag3 = default(bool);
				while (!flag3)
				{
				}
				Queue<FtueEvent> queue = triggeredEvents;
				bool flag4 = default(bool);
				while (flag4)
				{
				}
				Queue<FtueEvent> queue2 = triggeredEvents;
			}
			int _003C_003E1__state = default(int);
			_003CExecuteAllEvents_003Ed__19 _003CExecuteAllEvents_003Ed__ = new _003CExecuteAllEvents_003Ed__19(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CExecuteAllEvents_003Ed__._003C_003E4__this = (FtueEventListener)0;
		}

		[Cpp2IlInjected.Token(Token = "0x600187A")]
		[Cpp2IlInjected.Address(RVA = "0x8B41C0", Offset = "0x8B2BC0", VA = "0x1808B41C0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0063, IL_006f
			//IL_005c: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			Queue<FtueEvent> queue = triggeredEvents;
			bool flag = default(bool);
			if (flag)
			{
				FtueEvent.Triggered triggered = OnEventTriggered;
				Delegate @delegate = Delegate.Remove(triggered, triggered);
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				FtueEvent ftueEvent = default(FtueEvent);
				ftueEvent.OnTriggered = (FtueEvent.Triggered)@delegate;
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				FtueEvent.Triggered triggered2 = default(FtueEvent.Triggered);
				Delegate delegate2 = Delegate.Remove(triggered2, triggered2);
				if ((object)delegate2 != null && (object)delegate2 == null)
				{
					throw new InvalidCastException();
				}
				Addressables.Release((FtueEvent)num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600187B")]
		[Cpp2IlInjected.Address(RVA = "0x8B3C90", Offset = "0x8B2690", VA = "0x1808B3C90")]
		[Conditional("FTUE_LOGS")]
		private void LogFtue(string msg)
		{
			//Discarded unreachable code: IL_00c1
			//IL_003a: Expected O, but got I4
			//IL_005a: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			//IL_00a2: Expected O, but got I4
			object[] array;
			bool flag = default(bool);
			int size;
			while (true)
			{
				array = new object[7];
				if (msg != null && array == null)
				{
					continue;
				}
				array[0] = msg;
				Queue<FtueEvent> queue = triggeredEvents;
				bool isPaused = base.IsPaused;
				int num = 0;
				if (flag && !flag)
				{
					continue;
				}
				array[1] = flag;
				size = ((Queue<>)(object)triggeredEvents)._size;
				if (size != 0 && size == 0)
				{
					continue;
				}
				array[2] = size;
				int size2 = ((List<>)(object)pendingEvents)._size;
				size = size2;
				if (size2 == 0 || size2 != 0)
				{
					array[3] = size;
					int num2 = 0;
					float realtimeSinceStartup = Time.realtimeSinceStartup;
					size = size2;
					if (size2 == 0 || size2 != 0)
					{
						break;
					}
				}
			}
			array[4] = size;
			bool flag2 = DebugDisableUI;
			DateTime? dateTime = DebugAutoSkip;
			UnityEngine.Debug.LogError(string.Format("[FTUE-LOG] {0}\n\nEventIsOngoing={1}, TriggeredEvents.Count={2}, PendingEvents.Count={3}, PlayTime={4:F2}sec\nDebugDisableUI={5}, DebugAutoSkip={6}\n\n", array));
		}

		[Cpp2IlInjected.Token(Token = "0x600187C")]
		[Cpp2IlInjected.Address(RVA = "0x8B4C50", Offset = "0x8B3650", VA = "0x1808B4C50")]
		public FtueEventListener()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600187D")]
		[Cpp2IlInjected.Address(RVA = "0x8B4BD0", Offset = "0x8B35D0", VA = "0x1808B4BD0")]
		static FtueEventListener()
		{
			//IL_000a: Expected I4, but got O
			/*Error: Unexpected end of block*/;
		}
	}
}
