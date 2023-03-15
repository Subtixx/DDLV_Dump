using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000753")]
	public class HistoryStack<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4002A2A")]
		private List<T> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4002A2B")]
		private int currentIndex;

		[Cpp2IlInjected.Token(Token = "0x17000499")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x6002094")]
			[Cpp2IlInjected.Address(RVA = "0x1C1A750", Offset = "0x1C19150", VA = "0x181C1A750")]
			get
			{
				((ICollection<T>)((HistoryStack<>)(object)this).history).Clear();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002095")]
		[Cpp2IlInjected.Address(RVA = "0x1C1A680", Offset = "0x1C19080", VA = "0x181C1A680")]
		public HistoryStack(T initialState)
		{
			//Discarded unreachable code: IL_001f
			((HistoryStack<>)(object)this).history = (List<T>)(object)new List<T>();
			base._002Ector();
			((ICollection<T>)((HistoryStack<>)(object)this).history).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6002096")]
		[Cpp2IlInjected.Address(RVA = "0x1C1A530", Offset = "0x1C18F30", VA = "0x181C1A530")]
		public void Push(T state)
		{
			//Discarded unreachable code: IL_002a
			bool flag = CanRedo();
			List<> list = (List<>)(object)((HistoryStack<>)(object)this).history;
			if (flag)
			{
				int index = ((List<T>)(object)list).Count - 1;
				((List<T>)(object)list).RemoveAt(index);
			}
			((List<T>)(object)list).Add((T)state);
		}

		[Cpp2IlInjected.Token(Token = "0x6002097")]
		[Cpp2IlInjected.Address(RVA = "0x1C1A4A0", Offset = "0x1C18EA0", VA = "0x181C1A4A0")]
		public void Flush()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002098")]
		[Cpp2IlInjected.Address(RVA = "0x1C1A340", Offset = "0x1C18D40", VA = "0x181C1A340")]
		public bool Clean(Func<T, bool> predicate)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002099")]
		[Cpp2IlInjected.Address(RVA = "0x1C1A640", Offset = "0x1C19040", VA = "0x181C1A640")]
		public bool Undo()
		{
			//Discarded unreachable code: IL_000f
			bool flag = CanUndo();
			if (!flag)
			{
				return flag;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600209A")]
		[Cpp2IlInjected.Address(RVA = "0x112F8F0", Offset = "0x112E2F0", VA = "0x18112F8F0")]
		public void UndoAll()
		{
			//IL_0009: Expected I4, but got I8
			((HistoryStack<>)(object)this).currentIndex = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600209B")]
		[Cpp2IlInjected.Address(RVA = "0x1C1A600", Offset = "0x1C19000", VA = "0x181C1A600")]
		public bool Redo()
		{
			//Discarded unreachable code: IL_000f
			bool flag = CanRedo();
			if (!flag)
			{
				return flag;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600209C")]
		[Cpp2IlInjected.Address(RVA = "0x1C1A330", Offset = "0x1C18D30", VA = "0x181C1A330")]
		public bool CanUndo()
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600209D")]
		[Cpp2IlInjected.Address(RVA = "0x1C1A2F0", Offset = "0x1C18CF0", VA = "0x181C1A2F0")]
		public bool CanRedo()
		{
			//Discarded unreachable code: IL_0018
			int num = ((HistoryStack<>)(object)this).currentIndex;
			int count = ((List<T>)(object)((HistoryStack<>)(object)this).history).Count;
			return num < count;
		}
	}
}
