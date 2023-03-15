using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Meta;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x2000932")]
	internal class FurnitureSelectionView : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000933")]
		public delegate void FurnitureSelected(FurnitureItem furniture);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003637")]
		public LoopVerticalScrollRect loopScrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003638")]
		public FilterBox filterBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400363A")]
		private List<FurnitureItemData> _ownedItems = (List<FurnitureItemData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400363B")]
		private FurnitureItemType _currentType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400363C")]
		private List<FurnitureItemData> _currentItems = (List<FurnitureItemData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400363D")]
		private List<FurnitureItemData> _allItems = (List<FurnitureItemData>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x14000078")]
		public event FurnitureSelected OnFurnitureSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60039E7")]
			[Cpp2IlInjected.Address(RVA = "0xE44EC0", Offset = "0xE438C0", VA = "0x180E44EC0")]
			[CompilerGenerated]
			add
			{
				FurnitureSelected onFurnitureSelected = this.OnFurnitureSelected;
				Delegate @delegate = Delegate.Combine(onFurnitureSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFurnitureSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60039E8")]
			[Cpp2IlInjected.Address(RVA = "0xE44F60", Offset = "0xE43960", VA = "0x180E44F60")]
			[CompilerGenerated]
			remove
			{
				FurnitureSelected onFurnitureSelected = this.OnFurnitureSelected;
				Delegate @delegate = Delegate.Remove(onFurnitureSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFurnitureSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039E9")]
		[Cpp2IlInjected.Address(RVA = "0xE44610", Offset = "0xE43010", VA = "0x180E44610")]
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

		[Cpp2IlInjected.Token(Token = "0x60039EA")]
		[Cpp2IlInjected.Address(RVA = "0xE44780", Offset = "0xE43180", VA = "0x180E44780")]
		private void FilterItems()
		{
			//Discarded unreachable code: IL_0061
			FilterBox filterBox = this.filterBox;
			List<FurnitureItemData> allItems = _allItems;
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)filterBox.CurrentFilters();
			int num = 0;
			List<> list = (List<>)(object)(_currentItems = (List<FurnitureItemData>)(object)FilterUtil.Filter<FurnitureItemData>((IEnumerable<>)allItems, (IEnumerable<>)hashSet, FilterUtil.FilterCombineMode.Intersection, (FilterUtil.FilterCombineMode)num));
			List<FurnitureItemData> currentItems = _currentItems;
			LoopVerticalScrollRect loopVerticalScrollRect = loopScrollRect;
			int num2 = (loopVerticalScrollRect.totalCount = ((List<>)(object)currentItems)._size);
			LoopVerticalScrollRect loopVerticalScrollRect2 = loopScrollRect;
			int offset = 0;
			loopVerticalScrollRect2.RefillCells(offset);
		}

		[Cpp2IlInjected.Token(Token = "0x60039EB")]
		[Cpp2IlInjected.Address(RVA = "0xE44BE0", Offset = "0xE435E0", VA = "0x180E44BE0")]
		private void UpdateData(ListEventData data)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60039EC")]
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

		[Cpp2IlInjected.Token(Token = "0x60039ED")]
		[Cpp2IlInjected.Address(RVA = "0xE44840", Offset = "0xE43240", VA = "0x180E44840")]
		public void Populate(FurnitureItemType furnitureType)
		{
			//Discarded unreachable code: IL_0100
			//IL_0010: Expected I4, but got I8
			loopScrollRect.totalCount = 0;
			LoopVerticalScrollRect loopVerticalScrollRect = loopScrollRect;
			int offset = 0;
			loopVerticalScrollRect.RefillCells(offset);
			RectTransform content = ((LoopScrollRect)loopScrollRect).m_Content;
			int num = 0;
			Vector2 vector = (content.anchoredPosition = Vector2.zero);
			_currentType = furnitureType;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IEnumerable<> enumerable = default(IEnumerable<>);
			List<FurnitureItemData> list = (_allItems = (List<FurnitureItemData>)(object)Enumerable.ToList<FurnitureItemData>(enumerable));
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			ListInventory catalog = SystemRoot.Instance.Client.MetaClient.profile.Catalog;
			List<FurnitureItemData> list2 = (_ownedItems = (List<FurnitureItemData>)(object)Enumerable.ToList<FurnitureItemData>(ItemDatabaseExtensions.GetOwnedFurnitures(_003CInstance_003Ek__BackingField2, catalog)));
			FilterBox filterBox = this.filterBox;
			List<FurnitureItemData> allItems = _allItems;
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)filterBox.CurrentFilters();
			int num2 = 0;
			List<> list3 = (List<>)(object)(_currentItems = (List<FurnitureItemData>)(object)FilterUtil.Filter<FurnitureItemData>((IEnumerable<>)allItems, (IEnumerable<>)hashSet, FilterUtil.FilterCombineMode.Intersection, (FilterUtil.FilterCombineMode)num2));
			List<FurnitureItemData> currentItems = _currentItems;
			LoopVerticalScrollRect loopVerticalScrollRect2 = loopScrollRect;
			int num3 = (loopVerticalScrollRect2.totalCount = ((List<>)(object)currentItems)._size);
			LoopVerticalScrollRect loopVerticalScrollRect3 = loopScrollRect;
			int offset2 = 0;
			loopVerticalScrollRect3.RefillCells(offset2);
		}

		[Cpp2IlInjected.Token(Token = "0x60039EE")]
		[Cpp2IlInjected.Address(RVA = "0xE44B90", Offset = "0xE43590", VA = "0x180E44B90")]
		private void SelectFurniture(FurnitureItemData data)
		{
			//Discarded unreachable code: IL_0011
			if (this.OnFurnitureSelected != null)
			{
				int iD = data.ID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039EF")]
		[Cpp2IlInjected.Address(RVA = "0xE44DF0", Offset = "0xE437F0", VA = "0x180E44DF0")]
		public FurnitureSelectionView()
		{
		}
	}
}
