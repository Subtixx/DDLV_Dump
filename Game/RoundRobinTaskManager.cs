using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000074")]
public class RoundRobinTaskManager : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public struct Info
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public Vector3 CamPos
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x1603990", Offset = "0x1602390", VA = "0x181603990")]
			[CompilerGenerated]
			readonly get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x16039B0", Offset = "0x16023B0", VA = "0x1816039B0")]
			[CompilerGenerated]
			set
			{
				float z = value.z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xC"), Cpp2IlInjected.Token(Token = "0x40002C2")]
		public float FixedDeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x108A040", Offset = "0x1088A40", VA = "0x18108A040")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x108A070", Offset = "0x1088A70", VA = "0x18108A070")]
			set;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private int CurrentAllocParallel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private int CurrentMaxAllocSequencial;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private int MaxActionsPerThread = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private Action[] ActionListParallel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private Action[] ActionListSequencial;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private Action DummyAction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private int MaxActionsPerFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private int NumTaskAdded;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private int NumTaskTotal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private int ActionFrameCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private Queue<(bool, Action)> TicketQueueParallel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private Queue<(bool, Action)> TicketQueueSequencial;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private Info FrameInfoInternal;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public static RoundRobinTaskManager Singleton
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xCC66B0", Offset = "0xCC50B0", VA = "0x180CC66B0")]
		[CompilerGenerated]
		get
		{
			return _003CSingleton_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xCC66F0", Offset = "0xCC50F0", VA = "0x180CC66F0")]
		[CompilerGenerated]
		private set
		{
			_003CSingleton_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Info FrameInfo
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xCC66A0", Offset = "0xCC50A0", VA = "0x180CC66A0")]
		get
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0xCC5910", Offset = "0xCC4310", VA = "0x180CC5910")]
	[RuntimeInitializeOnLoadMethod]
	private static void ReloadRoundRobinTaskManager()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0xCC5D90", Offset = "0xCC4790", VA = "0x180CC5D90")]
	private void Start()
	{
		Singleton = this;
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0xCC5DE0", Offset = "0xCC47E0", VA = "0x180CC5DE0")]
	private void Update()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0xCC5760", Offset = "0xCC4160", VA = "0x180CC5760")]
	private void RebindTempDeque(Queue<Action> tempParallelDequeue, Queue<Action> tempSequencialDequeue)
	{
		//Discarded unreachable code: IL_0041
		//IL_0021: Expected O, but got I4
		//IL_0040: Expected O, but got I4
		if (tempParallelDequeue != null && tempSequencialDequeue != null)
		{
			Action action = (Action)((Queue<T>)(object)tempParallelDequeue).Dequeue();
			Queue<(bool, Action)> ticketQueueParallel = TicketQueueParallel;
			int num = 0;
			int num2 = 0;
			((Queue<T>)(object)ticketQueueParallel).Enqueue((T)num);
			Action action2 = (Action)((Queue<T>)(object)tempSequencialDequeue).Dequeue();
			Queue<(bool, Action)> ticketQueueSequencial = TicketQueueSequencial;
			int num3 = 0;
			int num4 = 0;
			((Queue<T>)(object)ticketQueueSequencial).Enqueue((T)num3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0xCC5650", Offset = "0xCC4050", VA = "0x180CC5650")]
	public bool AppendTask(Action fp, Action fs, bool _fpRemoveOnExecuted = true, bool _fsRemoveOnExecuted = true)
	{
		//Discarded unreachable code: IL_0020
		//IL_0010: Expected O, but got I4
		//IL_001e: Expected O, but got I4
		Queue<(bool, Action)> ticketQueueParallel = TicketQueueParallel;
		int num = 0;
		((Queue<T>)(object)ticketQueueParallel).Enqueue((T)num);
		int num2 = 0;
		((Queue<T>)(object)TicketQueueSequencial).Enqueue((T)num2);
		return true;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0xCC5950", Offset = "0xCC4350", VA = "0x180CC5950")]
	public bool RemoveParallelTask(Action fp)
	{
		//IL_003f: Expected I4, but got O
		List<(bool, Action)> list = (List<(bool, Action)>)(object)Enumerable.ToList<(bool, Action)>((IEnumerable<>)TicketQueueParallel);
		bool result = default(bool);
		Func<(bool, Action), bool> func = (Func<(bool, Action), bool>)(object)(Func<T, TResult>)(((bool, Action) x) => result);
		int num = 0;
		bool flag = default(bool);
		if (!flag)
		{
			((Queue<T>)(object)TicketQueueParallel).Clear();
			Queue<(bool, Action)> queue = (TicketQueueParallel = (Queue<(bool, Action)>)(object)new Queue<T>((int)list));
			return true;
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0xCC5B70", Offset = "0xCC4570", VA = "0x180CC5B70")]
	public bool RemoveSequentialTask(Action fs)
	{
		//IL_003f: Expected I4, but got O
		List<(bool, Action)> list = (List<(bool, Action)>)(object)Enumerable.ToList<(bool, Action)>((IEnumerable<>)TicketQueueSequencial);
		bool result = default(bool);
		Func<(bool, Action), bool> func = (Func<(bool, Action), bool>)(object)(Func<T, TResult>)(((bool, Action) x) => result);
		int num = 0;
		bool flag = default(bool);
		if (!flag)
		{
			((Queue<T>)(object)TicketQueueSequencial).Clear();
			Queue<(bool, Action)> queue = (TicketQueueSequencial = (Queue<(bool, Action)>)(object)new Queue<T>((int)list));
			return true;
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0xCC54F0", Offset = "0xCC3EF0", VA = "0x180CC54F0")]
	public bool AppendParallelTask(Action fp, bool _fpRemoveOnExecuted = true)
	{
		//Discarded unreachable code: IL_0012
		//IL_0010: Expected O, but got I4
		Queue<(bool, Action)> ticketQueueParallel = TicketQueueParallel;
		int num = 0;
		((Queue<T>)(object)ticketQueueParallel).Enqueue((T)num);
		return true;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0xCC55A0", Offset = "0xCC3FA0", VA = "0x180CC55A0")]
	public bool AppendSequentialTask(Action fs, bool _fsRemoveOnExecuted = true)
	{
		//Discarded unreachable code: IL_0012
		//IL_0010: Expected O, but got I4
		Queue<(bool, Action)> ticketQueueSequencial = TicketQueueSequencial;
		int num = 0;
		((Queue<T>)(object)ticketQueueSequencial).Enqueue((T)num);
		return true;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0xCC6510", Offset = "0xCC4F10", VA = "0x180CC6510")]
	public RoundRobinTaskManager()
	{
		//IL_0009: Expected I4, but got I8
		Action _003C_003E9__29_ = _003C_003Ec._003C_003E9__29_0;
		if (_003C_003E9__29_ == null)
		{
			_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
		}
		DummyAction = _003C_003E9__29_;
		TicketQueueParallel = (Queue<(bool, Action)>)(object)new Queue<T>();
		TicketQueueSequencial = (Queue<(bool, Action)>)(object)new Queue<T>();
		base._002Ector();
	}
}
