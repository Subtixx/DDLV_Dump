using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;

namespace Mdl.Streaming
{
	[Cpp2IlInjected.Token(Token = "0x2000800")]
	public class PendingLoads
	{
		[Cpp2IlInjected.Token(Token = "0x2000801")]
		private struct PendingLoadEntry : IComparable<PendingLoadEntry>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4002CB5")]
			public int ID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4002CB6")]
			public float CachedValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4002CB7")]
			public bool ShouldLoad;

			[Cpp2IlInjected.Token(Token = "0x60023D5")]
			[Cpp2IlInjected.Address(RVA = "0x1205430", Offset = "0x1203E30", VA = "0x181205430", Slot = "4")]
			public int CompareTo(PendingLoadEntry other)
			{
				float cachedValue = CachedValue;
				int result = default(int);
				return result;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002CB0")]
		private PendingLoadEntry[] pendingEntries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002CB1")]
		private int pendingEntryCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002CB2")]
		public Func<int, (float, bool)> UpdatePriorityCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002CB3")]
		private bool isUpToDate;

		[Cpp2IlInjected.Token(Token = "0x4002CB4")]
		private static readonly ProfilerMarker s_markerSortPriorities;

		[Cpp2IlInjected.Token(Token = "0x1700050A")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60023C6")]
			[Cpp2IlInjected.Address(RVA = "0xF0D870", Offset = "0xF0C270", VA = "0x180F0D870")]
			get
			{
				if (!isUpToDate)
				{
					bool flag = UpdateAndCheckForPending();
				}
				int num = pendingEntryCount;
				int num2 = 0;
				if (num > 0)
				{
					PendingLoadEntry[] array = pendingEntries;
					if ((long)"{il2cpp array field local5->}" != 0)
					{
						int num3 = 0;
						throw new NullReferenceException();
					}
					num2++;
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700050B")]
		public int ReadyCount
		{
			[Cpp2IlInjected.Token(Token = "0x60023C7")]
			[Cpp2IlInjected.Address(RVA = "0xF0D090", Offset = "0xF0BA90", VA = "0x180F0D090")]
			get
			{
				//Discarded unreachable code: IL_002a
				if (!isUpToDate)
				{
					bool flag = UpdateAndCheckForPending();
				}
				int num = pendingEntryCount;
				int num2 = 0;
				if (num > 0)
				{
					PendingLoadEntry[] array = pendingEntries;
					num2++;
				}
				return num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700050C")]
		public int TotalCount
		{
			[Cpp2IlInjected.Token(Token = "0x60023C8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return pendingEntryCount;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023C9")]
		[Cpp2IlInjected.Address(RVA = "0xF0D800", Offset = "0xF0C200", VA = "0x180F0D800")]
		public PendingLoads(int count)
		{
			//IL_0024: Expected O, but got I4
			PendingLoadEntry[] array = (pendingEntries = new PendingLoadEntry[count]);
			UpdatePriorityCallback = (Func<int, (float, bool)>)(pendingEntryCount = 0);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60023CA")]
		[Cpp2IlInjected.Address(RVA = "0xF0CF20", Offset = "0xF0B920", VA = "0x180F0CF20")]
		public void EnqueueUnique(int id)
		{
			//Discarded unreachable code: IL_0068
			//IL_0060: Expected O, but got I4
			int length = pendingEntries.Length;
			int num = pendingEntryCount;
			length += length;
			PendingLoadEntry[] array = pendingEntries;
			Predicate<PendingLoadEntry> predicate = (Predicate<PendingLoadEntry>)(object)(Predicate<T>)delegate
			{
				int num5 = id;
				bool result = default(bool);
				return result;
			};
			int num2 = default(int);
			if (num2 == -1)
			{
				PendingLoadEntry[] array2 = pendingEntries;
				int num3 = pendingEntryCount;
				int num4 = id;
				array2[0] = (PendingLoadEntry)num4;
				isUpToDate = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023CB")]
		[Cpp2IlInjected.Address(RVA = "0xF0D4F0", Offset = "0xF0BEF0", VA = "0x180F0D4F0")]
		public void UpdateID(int oldID, int newID)
		{
			//Discarded unreachable code: IL_0033
			//IL_0032: Expected O, but got I4
			PendingLoadEntry[] array = pendingEntries;
			Predicate<PendingLoadEntry> predicate = (Predicate<PendingLoadEntry>)(object)(Predicate<T>)delegate
			{
				int num2 = oldID;
				bool result = default(bool);
				return result;
			};
			int num = default(int);
			if (num != -1)
			{
				pendingEntries[0] = (PendingLoadEntry)newID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023CC")]
		[Cpp2IlInjected.Address(RVA = "0xF0CEA0", Offset = "0xF0B8A0", VA = "0x180F0CEA0")]
		[IteratorStateMachine(typeof(_003CDequeue_003Ed__14))]
		public IEnumerable<int> Dequeue(int count)
		{
			_003CDequeue_003Ed__14 _003CDequeue_003Ed__ = new _003CDequeue_003Ed__14(-2);
			_003CDequeue_003Ed__._003C_003E4__this = this;
			_003CDequeue_003Ed__._003C_003E3__count = count;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60023CD")]
		[Cpp2IlInjected.Address(RVA = "0xF0D620", Offset = "0xF0C020", VA = "0x180F0D620")]
		private bool UpdatePriorities()
		{
			int num = pendingEntryCount;
			int num2 = 0;
			int num3 = 0;
			if (num > 0)
			{
				PendingLoadEntry[] array = pendingEntries;
				Func<int, (float, bool)> updatePriorityCallback = UpdatePriorityCallback;
				PendingLoadEntry[] array2 = pendingEntries;
				(float, bool) tuple = default((float, bool));
				if ((object)tuple != null)
				{
				}
				array2[0] = (PendingLoadEntry)tuple;
				pendingEntries[1] = (PendingLoadEntry)tuple;
				int num4 = pendingEntryCount;
				num3++;
			}
			PendingLoadEntry[] array3 = pendingEntries;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60023CE")]
		[Cpp2IlInjected.Address(RVA = "0xF0D1C0", Offset = "0xF0BBC0", VA = "0x180F0D1C0")]
		public void Remove(int id)
		{
			//Discarded unreachable code: IL_0076
			//IL_0063: Expected O, but got I4
			//IL_006d: Expected O, but got I4
			PendingLoadEntry[] array = pendingEntries;
			Predicate<PendingLoadEntry> predicate = (Predicate<PendingLoadEntry>)(object)(Predicate<T>)delegate
			{
				int num5 = id;
				bool result = default(bool);
				return result;
			};
			int num = default(int);
			if (num != -1)
			{
				PendingLoadEntry[] array2 = pendingEntries;
				int num2 = pendingEntryCount;
				int length = array2.Length;
				int num3 = pendingEntryCount;
				PendingLoadEntry[] array3 = pendingEntries;
				pendingEntryCount = num3;
				int num4 = 0;
				array3[0] = (PendingLoadEntry)num4;
				array3[1] = (PendingLoadEntry)num4;
				isUpToDate = (byte)num4 != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023CF")]
		[Cpp2IlInjected.Address(RVA = "0xF0D110", Offset = "0xF0BB10", VA = "0x180F0D110")]
		private void RemoveIndex(int index)
		{
			//Discarded unreachable code: IL_004d
			//IL_001f: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			//IL_004c: Expected O, but got I4
			PendingLoadEntry[] array = pendingEntries;
			int num = pendingEntryCount;
			int length = array.Length;
			num = index;
			array[1] = (PendingLoadEntry)num;
			int num2 = pendingEntryCount;
			PendingLoadEntry[] array2 = pendingEntries;
			pendingEntryCount = num2;
			int num3 = 0;
			array2[0] = (PendingLoadEntry)num3;
			array2[1] = (PendingLoadEntry)num3;
		}

		[Cpp2IlInjected.Token(Token = "0x60023D0")]
		[Cpp2IlInjected.Address(RVA = "0xF0D360", Offset = "0xF0BD60", VA = "0x180F0D360")]
		public void Reset()
		{
			//IL_0009: Expected I4, but got I8
			pendingEntryCount = 0;
			isUpToDate = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60023D1")]
		[Cpp2IlInjected.Address(RVA = "0xF0D090", Offset = "0xF0BA90", VA = "0x180F0D090")]
		private int ReadyForLoadingCount()
		{
			//Discarded unreachable code: IL_002a
			if (!isUpToDate)
			{
				bool flag = UpdateAndCheckForPending();
			}
			int num = pendingEntryCount;
			int num2 = 0;
			if (num > 0)
			{
				PendingLoadEntry[] array = pendingEntries;
				num2++;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60023D2")]
		[Cpp2IlInjected.Address(RVA = "0xF0CE30", Offset = "0xF0B830", VA = "0x180F0CE30")]
		private bool AnyReadyForLoading()
		{
			//Discarded unreachable code: IL_0037
			if (!isUpToDate)
			{
				bool flag = UpdateAndCheckForPending();
			}
			int num = pendingEntryCount;
			int num2 = 0;
			if (num > 0)
			{
				PendingLoadEntry[] array = pendingEntries;
				if ((long)"{il2cpp array field local5->}" != 0)
				{
					goto IL_0035;
				}
				num2++;
			}
			int num3 = 0;
			goto IL_0035;
			IL_0035:
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60023D3")]
		[Cpp2IlInjected.Address(RVA = "0xF0D370", Offset = "0xF0BD70", VA = "0x180F0D370")]
		public bool UpdateAndCheckForPending()
		{
			int num = pendingEntryCount;
			isUpToDate = true;
			int num2 = 0;
			int num3 = pendingEntryCount;
			int num4 = 0;
			int num5 = 0;
			if (num3 > 0)
			{
				PendingLoadEntry[] array = pendingEntries;
				Func<int, (float, bool)> updatePriorityCallback = UpdatePriorityCallback;
				PendingLoadEntry[] array2 = pendingEntries;
				(float, bool) tuple = default((float, bool));
				if ((object)tuple != null)
				{
				}
				pendingEntries[1] = (PendingLoadEntry)tuple;
				int num6 = pendingEntryCount;
				num5++;
			}
			PendingLoadEntry[] array3 = pendingEntries;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60023D4")]
		[Cpp2IlInjected.Address(RVA = "0xF0D780", Offset = "0xF0C180", VA = "0x180F0D780")]
		static PendingLoads()
		{
			//IL_001a: Expected O, but got I
			int num = 0;
			int flags = 0;
			int metadataCount = 0;
			ushort categoryId = default(ushort);
			s_markerSortPriorities = (ProfilerMarker)(long)ProfilerUnsafeUtility.CreateMarker("SortByPriority", categoryId, (MarkerFlags)flags, metadataCount);
		}
	}
}
