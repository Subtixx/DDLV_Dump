using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Ui.Widgets;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x200091E")]
	public class DecalLibraryView : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200091F")]
		public delegate void SelectDecal(DecalView decal);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40035E0")]
		public LoopVerticalScrollRect loopScrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40035E1")]
		public FilterBox filterBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40035E3")]
		private List<DecalItemData> _allDecals = (List<DecalItemData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40035E4")]
		private List<DecalItemData> _currentDecals = (List<DecalItemData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40035E5")]
		private DecalView _current;

		[Cpp2IlInjected.Token(Token = "0x14000072")]
		public event SelectDecal OnDecalSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6003959")]
			[Cpp2IlInjected.Address(RVA = "0x12B5CD0", Offset = "0x12B46D0", VA = "0x1812B5CD0")]
			[CompilerGenerated]
			add
			{
				SelectDecal onDecalSelected = this.OnDecalSelected;
				Delegate @delegate = Delegate.Combine(onDecalSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDecalSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600395A")]
			[Cpp2IlInjected.Address(RVA = "0x12B5D70", Offset = "0x12B4770", VA = "0x1812B5D70")]
			[CompilerGenerated]
			remove
			{
				SelectDecal onDecalSelected = this.OnDecalSelected;
				Delegate @delegate = Delegate.Remove(onDecalSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDecalSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600395B")]
		[Cpp2IlInjected.Address(RVA = "0x12B5100", Offset = "0x12B3B00", VA = "0x1812B5100")]
		private void Awake()
		{
			//Discarded unreachable code: IL_003c
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)loopScrollRect).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(UpdateData);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			FilterBox filterBox = this.filterBox;
			FilterSelector.FilterSelectedByUser value = FilterItems;
			filterBox.OnFilterSelectedByUser += value;
		}

		[Cpp2IlInjected.Token(Token = "0x600395C")]
		[Cpp2IlInjected.Address(RVA = "0x12B5520", Offset = "0x12B3F20", VA = "0x1812B5520")]
		private void FilterItems()
		{
			//Discarded unreachable code: IL_0061
			FilterBox filterBox = this.filterBox;
			List<DecalItemData> allDecals = _allDecals;
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)filterBox.CurrentFilters();
			int num = 0;
			List<> list = (List<>)(object)(_currentDecals = (List<DecalItemData>)(object)FilterUtil.Filter<DecalItemData>((IEnumerable<>)allDecals, (IEnumerable<>)hashSet, FilterUtil.FilterCombineMode.Intersection, (FilterUtil.FilterCombineMode)num));
			List<DecalItemData> currentDecals = _currentDecals;
			LoopVerticalScrollRect loopVerticalScrollRect = loopScrollRect;
			int num2 = (loopVerticalScrollRect.totalCount = ((List<>)(object)currentDecals)._size);
			LoopVerticalScrollRect loopVerticalScrollRect2 = loopScrollRect;
			int offset = 0;
			loopVerticalScrollRect2.RefillCells(offset);
		}

		[Cpp2IlInjected.Token(Token = "0x600395D")]
		[Cpp2IlInjected.Address(RVA = "0x12B5A40", Offset = "0x12B4440", VA = "0x1812B5A40")]
		private void UpdateData(ListEventData data)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600395E")]
		[Cpp2IlInjected.Address(RVA = "0x12B5210", Offset = "0x12B3C10", VA = "0x1812B5210")]
		public unsafe void DeselectAll()
		{
			//Discarded unreachable code: IL_0064, IL_006a, IL_0070, IL_0076, IL_0088
			uint num2 = default(uint);
			DecalView component = default(DecalView);
			GameObject gameObject = default(GameObject);
			while (true)
			{
				int num = 0;
				IEnumerator enumerator = ((LoopScrollRect)loopScrollRect).m_Content.GetEnumerator();
				if (enumerator != null)
				{
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
					int num3 = 0;
					if (enumerator == null)
					{
						break;
					}
					int num4 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					component = gameObject.GetComponent<DecalView>();
					GameObject selectedHighlight = component._selectedHighlight;
					int active = 0;
					selectedHighlight.SetActive((byte)active != 0);
				}
				int value = 0;
				if ((object)component != null)
				{
					((int*)null)->m_value = value;
					throw new NullReferenceException();
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600395F")]
		[Cpp2IlInjected.Address(RVA = "0x12B5480", Offset = "0x12B3E80", VA = "0x1812B5480")]
		public void Deselect()
		{
			//IL_0010: Expected O, but got I4
			//IL_0031: Expected O, but got I8
			DecalView current = _current;
			int num = 0;
			if (current != (UnityEngine.Object)num)
			{
				GameObject selectedHighlight = _current._selectedHighlight;
				int active = 0;
				selectedHighlight.SetActive((byte)active != 0);
			}
			_current = (DecalView)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003960")]
		[Cpp2IlInjected.Address(RVA = "0xE44720", Offset = "0xE43120", VA = "0x180E44720")]
		public void Clear()
		{
			//Discarded unreachable code: IL_003c
			//IL_000e: Expected I4, but got I8
			loopScrollRect.totalCount = 0;
			LoopVerticalScrollRect loopVerticalScrollRect = loopScrollRect;
			int offset = 0;
			loopVerticalScrollRect.RefillCells(offset);
			RectTransform content = ((LoopScrollRect)loopScrollRect).m_Content;
			int num = 0;
			Vector2 vector = (content.anchoredPosition = Vector2.zero);
		}

		[Cpp2IlInjected.Token(Token = "0x6003961")]
		[Cpp2IlInjected.Address(RVA = "0x12B55E0", Offset = "0x12B3FE0", VA = "0x1812B55E0")]
		public void Refresh()
		{
			//Discarded unreachable code: IL_009e, IL_00a4, IL_00b0
			//IL_0080: Expected O, but got I4
			int num = 0;
			loopScrollRect.totalCount = num;
			LoopVerticalScrollRect loopVerticalScrollRect = loopScrollRect;
			int offset = 0;
			loopVerticalScrollRect.RefillCells(offset);
			RectTransform content = ((LoopScrollRect)loopScrollRect).m_Content;
			int num2 = 0;
			Vector2 vector = (content.anchoredPosition = Vector2.zero);
			((List<T>)(object)_allDecals).Clear();
			IEnumerable<IItemData> allByType = (IEnumerable<IItemData>)ItemDatabase.Instance.GetAllByType(ItemType.Decal);
			if (allByType != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					if (num == (int)num3)
					{
						goto IL_0080;
					}
					num++;
				}
				if (num == 0 || num != 0)
				{
					((List<T>)(object)_allDecals).Add((T)num);
					goto IL_0080;
				}
				throw new InvalidCastException();
			}
			goto IL_008c;
			IL_008c:
			if (allByType != null)
			{
			}
			List<> list = default(List<>);
			int size = list._size;
			int num4 = 0;
			return;
			IL_0080:
			num += num;
			num += 312;
			goto IL_008c;
		}

		[Cpp2IlInjected.Token(Token = "0x6003962")]
		[Cpp2IlInjected.Address(RVA = "0x12B5950", Offset = "0x12B4350", VA = "0x1812B5950")]
		private void SelectionChanged(DecalView decal)
		{
			//Discarded unreachable code: IL_0067
			//IL_002e: Expected O, but got I4
			DecalView current = _current;
			if ((object)current != null)
			{
				GameObject selectedHighlight = current._selectedHighlight;
				int active = 0;
				selectedHighlight.SetActive((byte)active != 0);
			}
			bool flag = current == decal;
			int num = 0;
			_current = (DecalView)num;
			_current?._selectedHighlight.SetActive(value: true);
			SelectDecal onDecalSelected = this.OnDecalSelected;
			if (onDecalSelected != null)
			{
				DecalView current2 = _current;
				onDecalSelected(current2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003963")]
		[Cpp2IlInjected.Address(RVA = "0x12B5C20", Offset = "0x12B4620", VA = "0x1812B5C20")]
		public DecalLibraryView()
		{
		}
	}
}
