using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Avatar;
using Mdl.Ui.Widgets;
using Meta;
using Meta.Customization;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x20008FC")]
	internal class ClothingSelectionView : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20008FD")]
		public delegate void ClothesSelected(Item item);

		[Cpp2IlInjected.Token(Token = "0x20008FE")]
		public delegate void ClothesRemoved(ClothingItemType clothingType);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400354F")]
		public LoopVerticalScrollRect loopScrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003550")]
		public FilterBox filterBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003553")]
		private List<ClothingItemData> _ownedItems = (List<ClothingItemData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003554")]
		private ClothingItemType _currentType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003555")]
		private List<ClothingItemData> _currentItems = (List<ClothingItemData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003556")]
		private List<ClothingItemData> _allItems = (List<ClothingItemData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003557")]
		private bool _isMale;

		[Cpp2IlInjected.Token(Token = "0x14000066")]
		public event ClothesSelected OnClothesSelected
		{
			[Cpp2IlInjected.Token(Token = "0x600387C")]
			[Cpp2IlInjected.Address(RVA = "0x1002BA0", Offset = "0x10015A0", VA = "0x181002BA0")]
			[CompilerGenerated]
			add
			{
				ClothesSelected onClothesSelected = this.OnClothesSelected;
				Delegate @delegate = Delegate.Combine(onClothesSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onClothesSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600387D")]
			[Cpp2IlInjected.Address(RVA = "0x1002CE0", Offset = "0x10016E0", VA = "0x181002CE0")]
			[CompilerGenerated]
			remove
			{
				ClothesSelected onClothesSelected = this.OnClothesSelected;
				Delegate @delegate = Delegate.Remove(onClothesSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onClothesSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000067")]
		public event ClothesRemoved OnClothesRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x600387E")]
			[Cpp2IlInjected.Address(RVA = "0x1002B00", Offset = "0x1001500", VA = "0x181002B00")]
			[CompilerGenerated]
			add
			{
				ClothesRemoved onClothesRemoved = this.OnClothesRemoved;
				Delegate @delegate = Delegate.Combine(onClothesRemoved, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onClothesRemoved)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600387F")]
			[Cpp2IlInjected.Address(RVA = "0x1002C40", Offset = "0x1001640", VA = "0x181002C40")]
			[CompilerGenerated]
			remove
			{
				ClothesRemoved onClothesRemoved = this.OnClothesRemoved;
				Delegate @delegate = Delegate.Remove(onClothesRemoved, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onClothesRemoved)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003880")]
		[Cpp2IlInjected.Address(RVA = "0x10021B0", Offset = "0x1000BB0", VA = "0x1810021B0")]
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

		[Cpp2IlInjected.Token(Token = "0x6003881")]
		[Cpp2IlInjected.Address(RVA = "0x10022C0", Offset = "0x1000CC0", VA = "0x1810022C0")]
		private void FilterItems()
		{
			//Discarded unreachable code: IL_0088
			//IL_0051: Expected O, but got I4
			FilterBox filterBox = this.filterBox;
			List<ClothingItemData> allItems = _allItems;
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)filterBox.CurrentFilters();
			int num = 0;
			List<> list = (List<>)(object)(_currentItems = (List<ClothingItemData>)(object)FilterUtil.Filter<ClothingItemData>((IEnumerable<>)allItems, (IEnumerable<>)hashSet, FilterUtil.FilterCombineMode.Intersection, (FilterUtil.FilterCombineMode)num));
			if (AvatarRules.CanBeEmpty(_currentType))
			{
				List<ClothingItemData> currentItems = _currentItems;
				int num2 = 0;
				int index = 0;
				((List<T>)(object)currentItems).Insert(index, (T)num2);
			}
			List<ClothingItemData> currentItems2 = _currentItems;
			LoopVerticalScrollRect loopVerticalScrollRect = loopScrollRect;
			int num3 = (loopVerticalScrollRect.totalCount = ((List<>)(object)currentItems2)._size);
			LoopVerticalScrollRect loopVerticalScrollRect2 = loopScrollRect;
			int offset = 0;
			loopVerticalScrollRect2.RefillCells(offset);
		}

		[Cpp2IlInjected.Token(Token = "0x6003882")]
		[Cpp2IlInjected.Address(RVA = "0x1002720", Offset = "0x1001120", VA = "0x181002720")]
		private void UpdateData(ListEventData data)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003883")]
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

		[Cpp2IlInjected.Token(Token = "0x6003884")]
		[Cpp2IlInjected.Address(RVA = "0x10023C0", Offset = "0x1000DC0", VA = "0x1810023C0")]
		public void Populate(ClothingItemType clothingType, AvatarAppearance avatar)
		{
			//Discarded unreachable code: IL_012d
			//IL_0010: Expected I4, but got I8
			//IL_00f6: Expected O, but got I4
			loopScrollRect.totalCount = 0;
			LoopVerticalScrollRect loopVerticalScrollRect = loopScrollRect;
			int offset = 0;
			loopVerticalScrollRect.RefillCells(offset);
			RectTransform content = ((LoopScrollRect)loopScrollRect).m_Content;
			int num = 0;
			Vector2 vector = (content.anchoredPosition = Vector2.zero);
			bool flag = (_isMale = avatar.IsMale);
			_currentType = clothingType;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IEnumerable<> enumerable = default(IEnumerable<>);
			List<ClothingItemData> list = (_allItems = (List<ClothingItemData>)(object)Enumerable.ToList<ClothingItemData>(enumerable));
			Profile _003CCurrentProfile_003Ek__BackingField = avatar.CurrentProfile;
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			ListInventory wardrobe = _003CCurrentProfile_003Ek__BackingField.Wardrobe;
			List<ClothingItemData> list2 = (_ownedItems = (List<ClothingItemData>)(object)Enumerable.ToList<ClothingItemData>(ItemDatabaseExtensions.GetOwnedClothes(_003CInstance_003Ek__BackingField2, wardrobe)));
			FilterBox filterBox = this.filterBox;
			List<ClothingItemData> allItems = _allItems;
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)filterBox.CurrentFilters();
			int num2 = 0;
			List<> list3 = (List<>)(object)(_currentItems = (List<ClothingItemData>)(object)FilterUtil.Filter<ClothingItemData>((IEnumerable<>)allItems, (IEnumerable<>)hashSet, FilterUtil.FilterCombineMode.Intersection, (FilterUtil.FilterCombineMode)num2));
			if (AvatarRules.CanBeEmpty(_currentType))
			{
				List<ClothingItemData> currentItems = _currentItems;
				int num3 = 0;
				int index = 0;
				((List<T>)(object)currentItems).Insert(index, (T)num3);
			}
			List<ClothingItemData> currentItems2 = _currentItems;
			LoopVerticalScrollRect loopVerticalScrollRect2 = loopScrollRect;
			int num4 = (loopVerticalScrollRect2.totalCount = ((List<>)(object)currentItems2)._size);
			LoopVerticalScrollRect loopVerticalScrollRect3 = loopScrollRect;
			int offset2 = 0;
			loopVerticalScrollRect3.RefillCells(offset2);
		}

		[Cpp2IlInjected.Token(Token = "0x6003885")]
		[Cpp2IlInjected.Address(RVA = "0x10026C0", Offset = "0x10010C0", VA = "0x1810026C0")]
		private void SelectClothes(ClothingItemData data)
		{
			if (data != null)
			{
				if (this.OnClothesSelected != null)
				{
					int iD = data.ID;
				}
				return;
			}
			ClothesRemoved onClothesRemoved = this.OnClothesRemoved;
			while (onClothesRemoved == null)
			{
			}
			ClothingItemType currentType = _currentType;
			onClothesRemoved(currentType);
		}

		[Cpp2IlInjected.Token(Token = "0x6003886")]
		[Cpp2IlInjected.Address(RVA = "0x1002A30", Offset = "0x1001430", VA = "0x181002A30")]
		public ClothingSelectionView()
		{
		}
	}
}
