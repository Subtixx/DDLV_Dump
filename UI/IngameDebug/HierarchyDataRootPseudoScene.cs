using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public class HierarchyDataRootPseudoScene : HierarchyDataRoot
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private readonly string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private readonly List<Transform> rootObjects = (List<Transform>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		public override string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "4")]
			get
			{
				return name;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		public override int ChildCount
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0xAE3A30", Offset = "0xAE2430", VA = "0x180AE3A30", Slot = "6")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((List<>)(object)rootObjects)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0xAE3980", Offset = "0xAE2380", VA = "0x180AE3980")]
		public HierarchyDataRootPseudoScene(RuntimeHierarchy hierarchy, string name)
			: base(hierarchy)
		{
			this.name = name;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xAE35E0", Offset = "0xAE1FE0", VA = "0x180AE35E0")]
		public void AddChild(Transform child)
		{
			//Discarded unreachable code: IL_001c
			if (!((List<T>)(object)rootObjects).Contains((T)child))
			{
				((List<T>)(object)rootObjects).Add((T)child);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xAE36C0", Offset = "0xAE20C0", VA = "0x180AE36C0")]
		public void InsertChild(int index, Transform child)
		{
			int size = ((List<>)(object)rootObjects)._size;
			int min = 0;
			int num = Mathf.Clamp(index, min, size);
			((List<T>)(object)rootObjects).Insert(num, (T)child);
			int size2 = ((List<>)(object)rootObjects)._size;
			if (size2 != num)
			{
				List<Transform> list = rootObjects;
				num = size2;
				bool flag = default(bool);
				if (flag)
				{
					throw new NullReferenceException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xAE3920", Offset = "0xAE2320", VA = "0x180AE3920")]
		public void RemoveChild(Transform child)
		{
			//Discarded unreachable code: IL_000e
			bool flag = ((List<T>)(object)rootObjects).Remove((T)child);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xAE3810", Offset = "0xAE2210", VA = "0x180AE3810", Slot = "10")]
		public override void RefreshContent()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xAE3660", Offset = "0xAE2060", VA = "0x180AE3660", Slot = "9")]
		public override Transform GetChild(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
