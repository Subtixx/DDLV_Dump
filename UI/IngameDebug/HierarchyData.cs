using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public abstract class HierarchyData
	{
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private static readonly List<HierarchyDataTransform> transformDataPool;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private static readonly List<List<HierarchyDataTransform>> childrenListPool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		protected List<HierarchyDataTransform> children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		protected HierarchyData parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		protected int m_index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		protected int m_height = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		protected int m_depth;

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		public abstract string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		public abstract bool IsActive
		{
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		public abstract int ChildCount
		{
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		public abstract Transform BoundTransform
		{
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public HierarchyDataRoot Root
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0xAE6170", Offset = "0xAE4B70", VA = "0x180AE6170")]
			get
			{
				HierarchyData hierarchyData = default(HierarchyData);
				if ((long)parent != 0)
				{
					hierarchyData = parent;
				}
				if (hierarchyData == null)
				{
					int num = 0;
				}
				int num2 = 0;
				while (hierarchyData != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return m_index;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		public int AbsoluteIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xAE6120", Offset = "0xAE4B20", VA = "0x180AE6120")]
			get
			{
				int num;
				HierarchyData hierarchyData;
				do
				{
					num = m_index;
					hierarchyData = parent;
					if (hierarchyData == null)
					{
						break;
					}
					num++;
				}
				while (hierarchyData.parent != null);
				return num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		public int Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return m_height;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		public int Depth
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return m_depth;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public bool CanExpand
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xAE6140", Offset = "0xAE4B40", VA = "0x180AE6140")]
			get
			{
				return ChildCount > 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		public bool IsExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xAE6160", Offset = "0xAE4B60", VA = "0x180AE6160")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0xAE6210", Offset = "0xAE4C10", VA = "0x180AE6210")]
			set
			{
				int num3 = default(int);
				HierarchyData hierarchyData2 = default(HierarchyData);
				while (true)
				{
					if ((IntPtr)typeof(HierarchyDataTransform).TypeHandle == (IntPtr)(value ? 1 : 0))
					{
						return;
					}
					if (!value)
					{
						PoolChildrenList();
					}
					int childCount = ChildCount;
					if (childCount == 0)
					{
						return;
					}
					PopChildrenList();
					int height = m_height;
					bool flag = Refresh();
					int height2 = m_height;
					height2 -= height;
					if (childCount == 0)
					{
						return;
					}
					HierarchyData hierarchyData = parent;
					int num = 0;
					if (hierarchyData != null)
					{
						List<HierarchyDataTransform> list = hierarchyData.children;
						int num2 = 0;
						if (this == null)
						{
							break;
						}
						int size = ((List<>)(object)list)._size;
						int num4 = num3 + 1;
						if (num4 < size)
						{
							num4++;
						}
						if (hierarchyData.parent != null)
						{
							continue;
						}
					}
					if ((IntPtr)parent != (IntPtr)num)
					{
						hierarchyData2 = parent;
					}
					if (hierarchyData2 != null)
					{
						int num5 = 0;
						if (hierarchyData2 == null)
						{
							throw new InvalidCastException();
						}
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xAE59A0", Offset = "0xAE43A0", VA = "0x180AE59A0", Slot = "8")]
		public virtual bool Refresh()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xAE4A50", Offset = "0xAE3450", VA = "0x180AE4A50")]
		public HierarchyData FindDataAtIndex(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xAE4D30", Offset = "0xAE3730", VA = "0x180AE4D30")]
		public HierarchyDataTransform FindTransform(Transform target, [Optional] Transform nextInPath)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract Transform GetChild(int index);

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xAE54C0", Offset = "0xAE3EC0", VA = "0x180AE54C0")]
		public int IndexOf(Transform transform)
		{
			int childCount = ChildCount;
			if ((object)GetChild(childCount) != transform)
			{
			}
			return childCount;
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xAE51C0", Offset = "0xAE3BC0", VA = "0x180AE51C0")]
		private void GenerateChildItem(Transform child, int index, RuntimeHierarchy hierarchy)
		{
			//Discarded unreachable code: IL_008f
			//IL_0042: Expected I4, but got I8
			//IL_006b: Expected I4, but got O
			bool flag = ((HashSet<T>)(object)RuntimeInspectorUtils.IgnoredTransformsInHierarchy).Contains((T)child);
			bool flag2 = !flag;
			if (!flag)
			{
				RuntimeHierarchy.GameObjectFilterDelegate gameObjectDelegate = hierarchy.m_gameObjectDelegate;
				if (gameObjectDelegate != null)
				{
					flag2 = gameObjectDelegate(child);
				}
			}
			int index2 = ((List<>)(object)transformDataPool)._size - 1;
			new HierarchyDataTransform().m_height = 1;
			List<HierarchyDataTransform> list = transformDataPool;
			int num = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			((List<T>)(object)transformDataPool).RemoveAt(index2);
			if (this == null)
			{
			}
			int num2 = 0;
			((List<>)(object)list)._size = (int)this;
			bool flag3 = this != null;
			if (!flag2)
			{
			}
			int depth = m_depth;
			depth++;
			List<HierarchyDataTransform> list2 = children;
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0xAE5ED0", Offset = "0xAE48D0", VA = "0x180AE5ED0")]
		private void RemoveChildItem(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xAE5540", Offset = "0xAE3F40", VA = "0x180AE5540")]
		protected void PoolChildrenList()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0xAE5740", Offset = "0xAE4140", VA = "0x180AE5740")]
		protected void PopChildrenList()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xAE4850", Offset = "0xAE3250", VA = "0x180AE4850")]
		public static void ClearPool()
		{
			//Discarded unreachable code: IL_0056
			((List<T>)(object)childrenListPool).Clear();
			((List<T>)(object)transformDataPool).Clear();
			if (((List<T>)(object)childrenListPool).Capacity > 128)
			{
				((List<T>)(object)childrenListPool).Capacity = 128;
			}
			if (((List<T>)(object)transformDataPool).Capacity > 128)
			{
				((List<T>)(object)transformDataPool).Capacity = 128;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xAE6110", Offset = "0xAE4B10", VA = "0x180AE6110")]
		protected HierarchyData()
		{
		}//IL_0009: Expected I4, but got I8


		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xAE6030", Offset = "0xAE4A30", VA = "0x180AE6030")]
		static HierarchyData()
		{
			uint capacity = default(uint);
			transformDataPool = (List<HierarchyDataTransform>)(object)new List<T>((int)capacity);
			uint capacity2 = default(uint);
			transformDataPool = (List<HierarchyDataTransform>)(object)new List<T>((int)capacity2);
			/*Error: Unexpected end of block*/;
		}
	}
}
