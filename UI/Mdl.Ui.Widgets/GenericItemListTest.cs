using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009A8")]
	public class GenericItemListTest : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40038E1")]
		public LoopVerticalScrollRect loopScrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40038E2")]
		public DynamicTabContainer furnitureTabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40038E3")]
		public DynamicTabContainer clothingTabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40038E4")]
		public FilterBox filterBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40038E5")]
		public FilterSelectorTest testFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40038E6")]
		private List<IItemData> currentItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40038E7")]
		private IEnumerable<IItemData> allClothing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40038E8")]
		private IEnumerable<IItemData> allFurniture;

		[Cpp2IlInjected.Token(Token = "0x6003C9C")]
		[Cpp2IlInjected.Address(RVA = "0xE53450", Offset = "0xE51E50", VA = "0x180E53450")]
		private void Start()
		{
			//Discarded unreachable code: IL_0198
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)loopScrollRect).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(UpdateData);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			DynamicTabContainer dynamicTabContainer = furnitureTabs;
			FilterSelector.FilterSelectedByUser value = FilterItems;
			dynamicTabContainer.OnFilterSelectedByUser += value;
			DynamicTabContainer dynamicTabContainer2 = clothingTabs;
			FilterSelector.FilterSelectedByUser value2 = FilterItems;
			dynamicTabContainer2.OnFilterSelectedByUser += value2;
			FilterBox filterBox = this.filterBox;
			FilterSelector.FilterSelectedByUser value3 = FilterItems;
			filterBox.OnFilterSelectedByUser += value3;
			FilterSelectorTest filterSelectorTest = testFilter;
			FilterSelector.FilterSelectedByUser value4 = FilterItems;
			filterSelectorTest.OnFilterSelectedByUser += value4;
			IEnumerable<IItemData> enumerable = (allClothing = (IEnumerable<IItemData>)ItemDatabase.Instance.GetAllByType(ItemType.Clothing));
			IEnumerable<IItemData> enumerable2 = (allFurniture = (IEnumerable<IItemData>)ItemDatabase.Instance.GetAllByType(ItemType.Furniture));
			DynamicTabContainer dynamicTabContainer3 = clothingTabs;
			IEnumerable<IItemData> enumerable3 = allClothing;
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)dynamicTabContainer3.CurrentFilters();
			int num = 0;
			List<> list = (List<>)(object)(currentItems = (List<IItemData>)(object)FilterUtil.Filter<IItemData>((IEnumerable<>)enumerable3, (IEnumerable<>)hashSet, FilterUtil.FilterCombineMode.Intersection, (FilterUtil.FilterCombineMode)num));
			DynamicTabContainer dynamicTabContainer4 = furnitureTabs;
			List<IItemData> list2 = currentItems;
			IEnumerable<IItemData> enumerable4 = allFurniture;
			HashSet<Filter> hashSet2 = (HashSet<Filter>)(object)dynamicTabContainer4.CurrentFilters();
			int num2 = 0;
			List<> list3 = FilterUtil.Filter<IItemData>((IEnumerable<>)enumerable4, (IEnumerable<>)hashSet2, FilterUtil.FilterCombineMode.Intersection, (FilterUtil.FilterCombineMode)num2);
			((List<T>)(object)list2).AddRange((IEnumerable<>)list3);
			FilterBox filterBox2 = this.filterBox;
			List<IItemData> list4 = currentItems;
			HashSet<Filter> hashSet3 = (HashSet<Filter>)(object)filterBox2.CurrentFilters();
			int num3 = 0;
			List<> list5 = (List<>)(object)(currentItems = (List<IItemData>)(object)FilterUtil.Filter<IItemData>((IEnumerable<>)list4, (IEnumerable<>)hashSet3, FilterUtil.FilterCombineMode.Intersection, (FilterUtil.FilterCombineMode)num3));
			List<IItemData> list6 = currentItems;
			LoopVerticalScrollRect loopVerticalScrollRect = loopScrollRect;
			int num4 = (loopVerticalScrollRect.totalCount = ((List<>)(object)list6)._size);
			LoopVerticalScrollRect loopVerticalScrollRect2 = loopScrollRect;
			int offset = 0;
			loopVerticalScrollRect2.RefillCells(offset);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C9D")]
		[Cpp2IlInjected.Address(RVA = "0xE532C0", Offset = "0xE51CC0", VA = "0x180E532C0")]
		private void FilterItems()
		{
			//Discarded unreachable code: IL_00ce
			DynamicTabContainer dynamicTabContainer = clothingTabs;
			IEnumerable<IItemData> enumerable = allClothing;
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)dynamicTabContainer.CurrentFilters();
			int num = 0;
			List<> list = (List<>)(object)(currentItems = (List<IItemData>)(object)FilterUtil.Filter<IItemData>((IEnumerable<>)enumerable, (IEnumerable<>)hashSet, FilterUtil.FilterCombineMode.Intersection, (FilterUtil.FilterCombineMode)num));
			DynamicTabContainer dynamicTabContainer2 = furnitureTabs;
			List<IItemData> list2 = currentItems;
			IEnumerable<IItemData> enumerable2 = allFurniture;
			HashSet<Filter> hashSet2 = (HashSet<Filter>)(object)dynamicTabContainer2.CurrentFilters();
			int num2 = 0;
			List<> list3 = FilterUtil.Filter<IItemData>((IEnumerable<>)enumerable2, (IEnumerable<>)hashSet2, FilterUtil.FilterCombineMode.Intersection, (FilterUtil.FilterCombineMode)num2);
			((List<T>)(object)list2).AddRange((IEnumerable<>)list3);
			FilterBox filterBox = this.filterBox;
			List<IItemData> list4 = currentItems;
			HashSet<Filter> hashSet3 = (HashSet<Filter>)(object)filterBox.CurrentFilters();
			int num3 = 0;
			List<> list5 = (List<>)(object)(currentItems = (List<IItemData>)(object)FilterUtil.Filter<IItemData>((IEnumerable<>)list4, (IEnumerable<>)hashSet3, FilterUtil.FilterCombineMode.Intersection, (FilterUtil.FilterCombineMode)num3));
			List<IItemData> list6 = currentItems;
			LoopVerticalScrollRect loopVerticalScrollRect = loopScrollRect;
			int num4 = (loopVerticalScrollRect.totalCount = ((List<>)(object)list6)._size);
			LoopVerticalScrollRect loopVerticalScrollRect2 = loopScrollRect;
			int offset = 0;
			loopVerticalScrollRect2.RefillCells(offset);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C9E")]
		[Cpp2IlInjected.Address(RVA = "0xE538A0", Offset = "0xE522A0", VA = "0x180E538A0")]
		private void UpdateData(ListEventData data)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003C9F")]
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

		[Cpp2IlInjected.Token(Token = "0x6003CA0")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public GenericItemListTest()
		{
		}
	}
}
