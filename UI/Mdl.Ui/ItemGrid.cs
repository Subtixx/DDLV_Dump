using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[DisallowMultipleComponent]
	[AddComponentMenu("UI/Item Grid", 51)]
	public class ItemGrid : MonoBehaviour, IItemContainer, IFocusNavigationOverrideFindNext
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		[SerializeField]
		private GameObject _prefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		private GridLayoutGroup _gridLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		private Transform _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		private int _itemCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		private int _selectedIndex = -1;

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event ItemDataDelegate OnItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF8")]
			[Cpp2IlInjected.Address(RVA = "0xD35BF0", Offset = "0xD345F0", VA = "0x180D35BF0", Slot = "4")]
			[CompilerGenerated]
			add
			{
				ItemDataDelegate onItemData = this.OnItemData;
				Delegate @delegate = Delegate.Combine(onItemData, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemData)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000AF9")]
			[Cpp2IlInjected.Address(RVA = "0xD35D30", Offset = "0xD34730", VA = "0x180D35D30", Slot = "5")]
			[CompilerGenerated]
			remove
			{
				ItemDataDelegate onItemData = this.OnItemData;
				Delegate @delegate = Delegate.Remove(onItemData, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemData)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event ItemActivatedDelegate OnItemActivated
		{
			[Cpp2IlInjected.Token(Token = "0x6000AFA")]
			[Cpp2IlInjected.Address(RVA = "0xD35B50", Offset = "0xD34550", VA = "0x180D35B50", Slot = "6")]
			[CompilerGenerated]
			add
			{
				ItemActivatedDelegate onItemActivated = this.OnItemActivated;
				Delegate @delegate = Delegate.Combine(onItemActivated, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemActivated)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000AFB")]
			[Cpp2IlInjected.Address(RVA = "0xD35C90", Offset = "0xD34690", VA = "0x180D35C90", Slot = "7")]
			[CompilerGenerated]
			remove
			{
				ItemActivatedDelegate onItemActivated = this.OnItemActivated;
				Delegate @delegate = Delegate.Remove(onItemActivated, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemActivated)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFC")]
		[Cpp2IlInjected.Address(RVA = "0xD352F0", Offset = "0xD33CF0", VA = "0x180D352F0")]
		public void Awake()
		{
			//IL_0023: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			GridLayoutGroup gridLayoutGroup = (_gridLayout = base.gameObject.GetComponentInChildren<GridLayoutGroup>());
			GridLayoutGroup gridLayout = _gridLayout;
			int num = 0;
			if (gridLayout != (UnityEngine.Object)num)
			{
				Transform transform = _gridLayout.transform;
			}
			int num2 = 0;
			_content = (Transform)num2;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFD")]
		[Cpp2IlInjected.Address(RVA = "0xD35830", Offset = "0xD34230", VA = "0x180D35830")]
		private void UpdateCells()
		{
			//Discarded unreachable code: IL_0124
			//IL_0010: Expected O, but got I4
			//IL_00a2: Expected O, but got I4
			GridLayoutGroup gridLayout = _gridLayout;
			int num = 0;
			if (gridLayout == (UnityEngine.Object)num)
			{
				return;
			}
			_gridLayout.gameObject.DestroyAllChildrens();
			int num2 = 0;
			if (_itemCount <= num2)
			{
				return;
			}
			int itemIdx = num2;
			GameObject item = UnityEngine.Object.Instantiate(_prefab);
			GameObject gameObject = item;
			string text = default(string);
			string text3 = (gameObject.name = "Item_" + text);
			RectTransform component = item.GetComponent<RectTransform>();
			Button component2 = item.GetComponent<Button>();
			int num3 = 0;
			if (component2 != (UnityEngine.Object)num3)
			{
				component2.m_OnClick.RemoveAllListeners();
				Button.ButtonClickedEvent onClick = component2.m_OnClick;
				UnityAction call = delegate
				{
					//Discarded unreachable code: IL_001e
					ItemGrid itemGrid = this;
					int itemIdx2 = itemIdx;
					GameObject item2 = item;
					itemGrid.OnItemClickHandler(item2, itemIdx2);
				};
				onClick.AddListener(call);
			}
			Transform transform = component.transform;
			Transform content = _content;
			int num4 = 0;
			transform.SetParent(content, (byte)num4 != 0);
			ItemDataDelegate onItemData = this.OnItemData;
			if (onItemData != null)
			{
				GameObject displayObject = component.gameObject;
				bool selected = num4 == _selectedIndex;
				onItemData(displayObject, num4, selected);
			}
			num2++;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFE")]
		[Cpp2IlInjected.Address(RVA = "0xD353E0", Offset = "0xD33DE0", VA = "0x180D353E0")]
		private RectTransform InstantiateItem(int itemIdx)
		{
			//Discarded unreachable code: IL_00e9
			//IL_0069: Expected O, but got I4
			GameObject item = UnityEngine.Object.Instantiate(_prefab);
			GameObject gameObject = item;
			string text = default(string);
			string text3 = (gameObject.name = "Item_" + text);
			RectTransform component = item.GetComponent<RectTransform>();
			Button component2 = item.GetComponent<Button>();
			int num = 0;
			if (component2 != (UnityEngine.Object)num)
			{
				component2.m_OnClick.RemoveAllListeners();
				Button.ButtonClickedEvent onClick = component2.m_OnClick;
				UnityAction call = delegate
				{
					//Discarded unreachable code: IL_001e
					ItemGrid itemGrid = this;
					int itemIdx2 = itemIdx;
					GameObject item2 = item;
					itemGrid.OnItemClickHandler(item2, itemIdx2);
				};
				onClick.AddListener(call);
			}
			Transform transform = component.transform;
			Transform content = _content;
			int num2 = 0;
			transform.SetParent(content, (byte)num2 != 0);
			ItemDataDelegate onItemData = this.OnItemData;
			if (onItemData != null)
			{
				GameObject displayObject = component.gameObject;
				bool selected = num2 == _selectedIndex;
				onItemData(displayObject, num2, selected);
			}
			return component;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFF")]
		[Cpp2IlInjected.Address(RVA = "0xD35640", Offset = "0xD34040", VA = "0x180D35640")]
		private void OnItemClickHandler([Optional] GameObject item, int itemIdx = 0)
		{
			this.OnItemActivated?.Invoke(item, itemIdx);
			_selectedIndex = itemIdx;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B00")]
		[Cpp2IlInjected.Address(RVA = "0xD357B0", Offset = "0xD341B0", VA = "0x180D357B0", Slot = "10")]
		public bool TryFindNextFocusElement(FocusDirection direction, int input, FocusNavigationElement currentElement, out ISupportsFocusNavigation nextElement)
		{
			//Discarded unreachable code: IL_0009
			ISupportsFocusNavigation[] componentsInChildren = GetComponentsInChildren<ISupportsFocusNavigation>();
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B01")]
		[Cpp2IlInjected.Address(RVA = "0xD353D0", Offset = "0xD33DD0", VA = "0x180D353D0", Slot = "8")]
		public void InitItems(int itemCount, int initialSelectionIndex)
		{
			_itemCount = itemCount;
			_selectedIndex = initialSelectionIndex;
			UpdateCells();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0xD35670", Offset = "0xD34070", VA = "0x180D35670", Slot = "9")]
		public void SetFocus(FocusNavigation focusNavigation)
		{
			//Discarded unreachable code: IL_007b
			//IL_0041: Expected O, but got I4
			//IL_0066: Expected O, but got I4
			_focusNavigation = focusNavigation;
			int selectedIndex = _selectedIndex;
			int childCount = _content.childCount;
			if (selectedIndex < childCount)
			{
				Transform content = _content;
				int selectedIndex2 = _selectedIndex;
				Transform child = content.GetChild(selectedIndex2);
				int num = 0;
				if (child == (UnityEngine.Object)num)
				{
					Transform content2 = _content;
					int index = 0;
					Transform child2 = content2.GetChild(index);
				}
				int num2 = 0;
				if (child != (UnityEngine.Object)num2)
				{
					FocusNavigationElement component = child.GetComponent<FocusNavigationElement>();
					focusNavigation.SetFocus(component);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0xD35B40", Offset = "0xD34540", VA = "0x180D35B40")]
		public ItemGrid()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
