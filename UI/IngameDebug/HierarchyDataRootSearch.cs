using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public class HierarchyDataRootSearch : HierarchyDataRoot
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private readonly List<Transform> searchResult = (List<Transform>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private readonly HierarchyDataRoot reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private string searchTerm;

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		public override string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xAE4160", Offset = "0xAE2B60", VA = "0x180AE4160", Slot = "4")]
			get
			{
				reference.RefreshContent();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		public override int ChildCount
		{
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xAE4120", Offset = "0xAE2B20", VA = "0x180AE4120", Slot = "6")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((List<>)(object)searchResult)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0xAE4070", Offset = "0xAE2A70", VA = "0x180AE4070")]
		public HierarchyDataRootSearch(RuntimeHierarchy hierarchy, HierarchyDataRoot reference)
			: base(hierarchy)
		{
			this.reference = reference;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0xAE3CA0", Offset = "0xAE26A0", VA = "0x180AE3CA0", Slot = "10")]
		public override void RefreshContent()
		{
			//Discarded unreachable code: IL_00af
			if (!base.Hierarchy.m_isInSearchMode)
			{
				return;
			}
			((List<T>)(object)searchResult).Clear();
			string text = (searchTerm = base.Hierarchy.SearchTerm);
			int childCount = reference.ChildCount;
			int num = 0;
			if (childCount <= 0)
			{
				return;
			}
			Transform child = reference.GetChild(num);
			if ((bool)child)
			{
				HashSet<Transform> ignoredTransformsInHierarchy = RuntimeInspectorUtils.IgnoredTransformsInHierarchy;
				Transform transform = child.transform;
				if (!((HashSet<T>)(object)ignoredTransformsInHierarchy).Contains((T)transform))
				{
					string name = child.name;
					string value = searchTerm;
					int num2 = name.IndexOf(value, StringComparison.OrdinalIgnoreCase);
					((List<T>)(object)searchResult).Add((T)child);
					Transform transform2 = child.transform;
					SearchTransformRecursively(transform2);
				}
			}
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0xAE3ED0", Offset = "0xAE28D0", VA = "0x180AE3ED0", Slot = "8")]
		public override bool Refresh()
		{
			//IL_0009: Expected I4, but got I8
			//IL_001f: Expected I4, but got I8
			//IL_002f: Expected I4, but got I8
			m_depth = 0;
			RefreshContent();
			bool result = ((HierarchyData)this).Refresh();
			m_height = 0;
			m_depth = -1;
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0xAE3F20", Offset = "0xAE2920", VA = "0x180AE3F20")]
		private void SearchTransformRecursively(Transform obj)
		{
			//Discarded unreachable code: IL_0055
			int num = 0;
			int childCount = obj.childCount;
			if (num < childCount)
			{
				Transform child = obj.GetChild(num);
				if (!((HashSet<T>)(object)RuntimeInspectorUtils.IgnoredTransformsInHierarchy).Contains((T)child))
				{
					string name = child.name;
					string value = searchTerm;
					int num2 = name.IndexOf(value, StringComparison.OrdinalIgnoreCase);
					((List<T>)(object)searchResult).Add((T)child);
					SearchTransformRecursively(child);
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xAE3C40", Offset = "0xAE2640", VA = "0x180AE3C40", Slot = "9")]
		public override Transform GetChild(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
