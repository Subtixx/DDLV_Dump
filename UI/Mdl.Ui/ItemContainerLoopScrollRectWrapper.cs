using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	public class ItemContainerLoopScrollRectWrapper : ItemContainerBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public LayoutGroup ListLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		private LoopScrollRect _itemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		private int _initialSelectionIndex;

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<float> OnAdaptSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000AEF")]
			[Cpp2IlInjected.Address(RVA = "0xD34B60", Offset = "0xD33560", VA = "0x180D34B60")]
			[CompilerGenerated]
			add
			{
				Action<float> onAdaptSize = this.OnAdaptSize;
				Delegate @delegate = Delegate.Combine(onAdaptSize, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onAdaptSize)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000AF0")]
			[Cpp2IlInjected.Address(RVA = "0xD34C00", Offset = "0xD33600", VA = "0x180D34C00")]
			[CompilerGenerated]
			remove
			{
				Action<float> onAdaptSize = this.OnAdaptSize;
				Delegate @delegate = Delegate.Remove(onAdaptSize, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onAdaptSize)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF1")]
		[Cpp2IlInjected.Address(RVA = "0xD34A20", Offset = "0xD33420", VA = "0x180D34A20")]
		public ItemContainerLoopScrollRectWrapper(LoopScrollRect itemList)
		{
			//Discarded unreachable code: IL_004e
			_itemList = itemList;
			LoopScrollRect.ListEvents onItemData = _itemList.m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnListItemData);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = _itemList.m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnListItemTapped);
			((UnityEvent<T0>)(object)onItemTap).AddListener((UnityAction<>)(object)unityAction2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF2")]
		[Cpp2IlInjected.Address(RVA = "0xD343C0", Offset = "0xD32DC0", VA = "0x180D343C0", Slot = "12")]
		public override void Dispose()
		{
			LoopScrollRect.ListEvents onItemData = _itemList.m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnListItemData);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = _itemList.m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnListItemTapped);
			((UnityEvent<T0>)(object)onItemTap).RemoveListener((UnityAction<>)(object)unityAction2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF3")]
		[Cpp2IlInjected.Address(RVA = "0xD344F0", Offset = "0xD32EF0", VA = "0x180D344F0", Slot = "11")]
		public override void InitItems(int itemCount, int initialSelectionIndex)
		{
			//Discarded unreachable code: IL_0101
			//IL_0010: Expected O, but got I4
			//IL_00c5: Expected O, but got I4
			LoopScrollRect itemList = _itemList;
			int num = 0;
			if (itemList == (UnityEngine.Object)num)
			{
				return;
			}
			_itemList.totalCount = itemCount;
			LoopScrollRect itemList2 = _itemList;
			int offset = 0;
			itemList2.RefillCells(offset);
			_itemList.m_Content.RebuildLayout();
			if ((long)this.OnAdaptSize != 0)
			{
				Transform transform = _itemList.transform;
				int left = ListLayout.m_Padding.left;
				RectOffset padding = ListLayout.m_Padding;
				int num2 = 0;
				int right = padding.right;
				LoopScrollRect itemList3 = _itemList;
				if (itemList3.totalCount > 0)
				{
					RectTransform content = itemList3.m_Content;
					int index = 0;
					float preferredWidth = LayoutUtility.GetPreferredWidth(content.GetChild(index).GetComponent<RectTransform>());
				}
				this.OnAdaptSize((T)num2);
			}
			LoopScrollRect itemList4 = _itemList;
			Action callback = OnAutoScrollFinished;
			itemList4.ScrollToCell(initialSelectionIndex, 100000f, callback);
			LoopScrollRect itemList5 = _itemList;
			_initialSelectionIndex = initialSelectionIndex;
			itemList5.RefreshCells();
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF4")]
		[Cpp2IlInjected.Address(RVA = "0xD347B0", Offset = "0xD331B0", VA = "0x180D347B0")]
		private void OnAutoScrollFinished()
		{
			//Discarded unreachable code: IL_001d
			//IL_001c: Expected O, but got I4
			RectTransform content = _itemList.m_Content;
			int num = 0;
			Vector2 anchoredPosition = content.anchoredPosition;
			content.anchoredPosition = (Vector2)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF5")]
		[Cpp2IlInjected.Address(RVA = "0xD34820", Offset = "0xD33220", VA = "0x180D34820")]
		public void OnListItemData(ListEventData data)
		{
			//Discarded unreachable code: IL_0040
			LoopScrollRect itemList = _itemList;
			GameObject displayObject = data.DisplayObject;
			int itemIndex = data.ItemIndex;
			int selectedIndex = itemList.SelectedIndex;
			ItemDataDelegate onItemData = base.OnItemData;
			if (onItemData != null)
			{
				bool selected = selectedIndex == data.ItemIndex;
				onItemData(displayObject, itemIndex, selected);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF6")]
		[Cpp2IlInjected.Address(RVA = "0xD348A0", Offset = "0xD332A0", VA = "0x180D348A0")]
		public void OnListItemTapped(ListEventData data)
		{
			//Discarded unreachable code: IL_0023
			ItemActivatedDelegate onItemActivated = base.OnItemActivated;
			if (onItemActivated != null)
			{
				int itemIndex = data.ItemIndex;
				GameObject displayObject = data.DisplayObject;
				onItemActivated(displayObject, itemIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF7")]
		[Cpp2IlInjected.Address(RVA = "0xD348E0", Offset = "0xD332E0", VA = "0x180D348E0", Slot = "13")]
		public override void SetFocus(FocusNavigation focusNavigation)
		{
			//Discarded unreachable code: IL_0066
			//IL_0028: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			int initialSelectionIndex = _initialSelectionIndex;
			LoopScrollRect itemList = _itemList;
			if (initialSelectionIndex < itemList.totalCount)
			{
				Transform itemByDataIndex = itemList.GetItemByDataIndex(initialSelectionIndex);
				int num = 0;
				if (itemByDataIndex == (UnityEngine.Object)num)
				{
					LoopScrollRect itemList2 = _itemList;
					int firstVisibleItemIndex = itemList2.GetFirstVisibleItemIndex();
					Transform itemByDataIndex2 = itemList2.GetItemByDataIndex(firstVisibleItemIndex);
				}
				int num2 = 0;
				if (itemByDataIndex != (UnityEngine.Object)num2)
				{
					FocusNavigationElement component = itemByDataIndex.GetComponent<FocusNavigationElement>();
					focusNavigation.SetFocus(component);
				}
			}
		}
	}
}
