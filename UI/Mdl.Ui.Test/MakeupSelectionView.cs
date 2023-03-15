using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Avatar;
using Mdl.Ui.Widgets;
using Meta;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x2000908")]
	internal class MakeupSelectionView : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000909")]
		public delegate void MakeupSelected(MakeupItem makeup);

		[Cpp2IlInjected.Token(Token = "0x200090A")]
		public delegate void MakeupRemoved(MakeupItemType makeupType);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400356B")]
		public LoopVerticalScrollRect loopScrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400356C")]
		public FilterBox filterBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400356F")]
		private List<MakeupItemData> _ownedItems = (List<MakeupItemData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003570")]
		private MakeupItemType _currentType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003571")]
		private List<MakeupItemData> _currentItems = (List<MakeupItemData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003572")]
		private List<MakeupItemData> _allItems = (List<MakeupItemData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003573")]
		private bool _isMale;

		[Cpp2IlInjected.Token(Token = "0x1400006C")]
		public event MakeupSelected OnMakeupSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60038BF")]
			[Cpp2IlInjected.Address(RVA = "0xFAA0B0", Offset = "0xFA8AB0", VA = "0x180FAA0B0")]
			[CompilerGenerated]
			add
			{
				MakeupSelected onMakeupSelected = this.OnMakeupSelected;
				Delegate @delegate = Delegate.Combine(onMakeupSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onMakeupSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60038C0")]
			[Cpp2IlInjected.Address(RVA = "0xFAA1F0", Offset = "0xFA8BF0", VA = "0x180FAA1F0")]
			[CompilerGenerated]
			remove
			{
				MakeupSelected onMakeupSelected = this.OnMakeupSelected;
				Delegate @delegate = Delegate.Remove(onMakeupSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onMakeupSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400006D")]
		public event MakeupRemoved OnMakeupRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x60038C1")]
			[Cpp2IlInjected.Address(RVA = "0xFAA010", Offset = "0xFA8A10", VA = "0x180FAA010")]
			[CompilerGenerated]
			add
			{
				MakeupRemoved onMakeupRemoved = this.OnMakeupRemoved;
				Delegate @delegate = Delegate.Combine(onMakeupRemoved, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onMakeupRemoved)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60038C2")]
			[Cpp2IlInjected.Address(RVA = "0xFAA150", Offset = "0xFA8B50", VA = "0x180FAA150")]
			[CompilerGenerated]
			remove
			{
				MakeupRemoved onMakeupRemoved = this.OnMakeupRemoved;
				Delegate @delegate = Delegate.Remove(onMakeupRemoved, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onMakeupRemoved)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038C3")]
		[Cpp2IlInjected.Address(RVA = "0xFA94E0", Offset = "0xFA7EE0", VA = "0x180FA94E0")]
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

		[Cpp2IlInjected.Token(Token = "0x60038C4")]
		[Cpp2IlInjected.Address(RVA = "0xFA95F0", Offset = "0xFA7FF0", VA = "0x180FA95F0")]
		private void FilterItems()
		{
			//Discarded unreachable code: IL_007a
			//IL_0043: Expected O, but got I4
			FilterBox filterBox = this.filterBox;
			List<MakeupItemData> allItems = _allItems;
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)filterBox.CurrentFilters();
			int num = 0;
			List<MakeupItemData> list = (_currentItems = (List<MakeupItemData>)(object)FilterUtil.Filter<MakeupItemData>((IEnumerable<>)allItems, (IEnumerable<>)hashSet, FilterUtil.FilterCombineMode.Intersection, (FilterUtil.FilterCombineMode)num));
			List<MakeupItemData> currentItems = _currentItems;
			int num2 = 0;
			int index = 0;
			((List<T>)(object)currentItems).Insert(index, (T)num2);
			List<MakeupItemData> currentItems2 = _currentItems;
			LoopVerticalScrollRect loopVerticalScrollRect = loopScrollRect;
			int num3 = (loopVerticalScrollRect.totalCount = ((List<>)(object)currentItems2)._size);
			LoopVerticalScrollRect loopVerticalScrollRect2 = loopScrollRect;
			int offset = 0;
			loopVerticalScrollRect2.RefillCells(offset);
		}

		[Cpp2IlInjected.Token(Token = "0x60038C5")]
		[Cpp2IlInjected.Address(RVA = "0xFA9C30", Offset = "0xFA8630", VA = "0x180FA9C30")]
		private void UpdateData(ListEventData data)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60038C6")]
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

		[Cpp2IlInjected.Token(Token = "0x60038C7")]
		[Cpp2IlInjected.Address(RVA = "0xFA96E0", Offset = "0xFA80E0", VA = "0x180FA96E0")]
		public void Populate(MakeupItemType makeupType, AvatarAppearance avatar)
		{
			//Discarded unreachable code: IL_0183
			//IL_0010: Expected I4, but got I8
			//IL_014c: Expected O, but got I4
			loopScrollRect.totalCount = 0;
			LoopVerticalScrollRect loopVerticalScrollRect = loopScrollRect;
			int offset = 0;
			loopVerticalScrollRect.RefillCells(offset);
			RectTransform content = ((LoopScrollRect)loopScrollRect).m_Content;
			int num = 0;
			Vector2 vector = (content.anchoredPosition = Vector2.zero);
			bool flag = (_isMale = avatar.IsMale);
			_currentType = makeupType;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IEnumerable<> enumerable = default(IEnumerable<>);
			List<MakeupItemData> list = (_allItems = (List<MakeupItemData>)(object)Enumerable.ToList<MakeupItemData>(enumerable));
			List<MakeupItemData> allItems = _allItems;
			if (!_isMale)
			{
				if (_003C_003Ec._003C_003E9__19_1 != null)
				{
					goto IL_00b9;
				}
				Func<MakeupItemData, bool> func = (Func<MakeupItemData, bool>)(object)(Func<T, TResult>)delegate(MakeupItemData m)
				{
					//Discarded unreachable code: IL_000c
					string femaleMakeupAddress_ = m.femaleMakeupAddress_;
					return m == null;
				};
			}
			Func<MakeupItemData, bool> func2 = default(Func<MakeupItemData, bool>);
			if (_003C_003Ec._003C_003E9__19_0 == null)
			{
				func2 = (Func<MakeupItemData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MakeupItemData m)
				{
					//Discarded unreachable code: IL_000c
					string maleMakeupAddress_ = m.maleMakeupAddress_;
					return m == null;
				});
			}
			goto IL_00b9;
			IL_00b9:
			List<MakeupItemData> list2 = (_allItems = (List<MakeupItemData>)(object)Enumerable.ToList<MakeupItemData>(Enumerable.Where<MakeupItemData>((IEnumerable<>)allItems, (Func<, >)(object)func2)));
			Profile _003CCurrentProfile_003Ek__BackingField = avatar.CurrentProfile;
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			ListInventory makeup = _003CCurrentProfile_003Ek__BackingField.Makeup;
			List<MakeupItemData> list3 = (_ownedItems = (List<MakeupItemData>)(object)Enumerable.ToList<MakeupItemData>(ItemDatabaseExtensions.GetOwnedMakeup(_003CInstance_003Ek__BackingField2, makeup)));
			FilterBox filterBox = this.filterBox;
			List<MakeupItemData> allItems2 = _allItems;
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)filterBox.CurrentFilters();
			int num2 = 0;
			List<> list4 = (List<>)(object)(_currentItems = (List<MakeupItemData>)(object)FilterUtil.Filter<MakeupItemData>((IEnumerable<>)allItems2, (IEnumerable<>)hashSet, FilterUtil.FilterCombineMode.Intersection, (FilterUtil.FilterCombineMode)num2));
			List<MakeupItemData> currentItems = _currentItems;
			int num3 = 0;
			int index = 0;
			((List<T>)(object)currentItems).Insert(index, (T)num3);
			List<MakeupItemData> currentItems2 = _currentItems;
			LoopVerticalScrollRect loopVerticalScrollRect2 = loopScrollRect;
			int num4 = (loopVerticalScrollRect2.totalCount = ((List<>)(object)currentItems2)._size);
			LoopVerticalScrollRect loopVerticalScrollRect3 = loopScrollRect;
			int offset2 = 0;
			loopVerticalScrollRect3.RefillCells(offset2);
		}

		[Cpp2IlInjected.Token(Token = "0x60038C8")]
		[Cpp2IlInjected.Address(RVA = "0xFA9BC0", Offset = "0xFA85C0", VA = "0x180FA9BC0")]
		private void SelectMakeup(MakeupItemData data)
		{
			if (data != null)
			{
				if (this.OnMakeupSelected != null)
				{
					int iD = data.ID;
				}
				return;
			}
			MakeupRemoved onMakeupRemoved = this.OnMakeupRemoved;
			while (onMakeupRemoved == null)
			{
			}
			MakeupItemType currentType = _currentType;
			onMakeupRemoved(currentType);
		}

		[Cpp2IlInjected.Token(Token = "0x60038C9")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F40", Offset = "0xFA8940", VA = "0x180FA9F40")]
		public MakeupSelectionView()
		{
		}
	}
}
