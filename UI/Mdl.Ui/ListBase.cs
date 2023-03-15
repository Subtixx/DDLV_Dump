using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001BE")]
	public class ListBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20001BF")]
		public class ListEventData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400076F")]
			public GameObject DisplayObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000770")]
			public int ItemIndex;

			[Cpp2IlInjected.Token(Token = "0x6000B30")]
			[Cpp2IlInjected.Address(RVA = "0xAFD030", Offset = "0xAFBA30", VA = "0x180AFD030")]
			public ListEventData(GameObject displayItem, int index)
			{
				DisplayObject = displayItem;
				ItemIndex = index;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001C0")]
		public class ListEvents : UnityEvent<ListEventData>
		{
			[Cpp2IlInjected.Token(Token = "0x6000B31")]
			[Cpp2IlInjected.Address(RVA = "0xAFD0C0", Offset = "0xAFBAC0", VA = "0x180AFD0C0")]
			public ListEvents()
			{
				((UnityEvent<T0>)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		[SerializeField]
		private RectTransform m_Content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		[SerializeField]
		private GameObject prefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		private int _totalCount;

		[Cpp2IlInjected.Token(Token = "0x4000761")]
		public static readonly int INVALID_INDEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		public int MaxSelectableItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		private List<int> selectedIndexes = (List<int>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		private List<int> deselectedIndexes = (List<int>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		[SerializeField]
		private int _selectedIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		private int _rawSelectedIndex = INVALID_INDEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public bool DeselectWhenSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public bool DeselectOldest = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		[SerializeField]
		private ListEvents m_OnItemData = new ListEvents();

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		[SerializeField]
		private ListEvents m_OnItemTap = new ListEvents();

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		[SerializeField]
		private ListEvents m_OnItemRightClick = new ListEvents();

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		[SerializeField]
		private ListEvents m_OnItemTapAndHold = new ListEvents();

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		[SerializeField]
		private ListEvents m_OnItemSelect = new ListEvents();

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		[SerializeField]
		private ListEvents m_OnItemDeselect = new ListEvents();

		[Cpp2IlInjected.Token(Token = "0x1700021B")]
		public GameObject Prefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000B07")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return prefab;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B08")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				prefab = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		public RectTransform content
		{
			[Cpp2IlInjected.Token(Token = "0x6000B09")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return m_Content;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B0A")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				m_Content = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		public int TotalCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000B0B")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return _totalCount;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B0C")]
			[Cpp2IlInjected.Address(RVA = "0x132E2B0", Offset = "0x132CCB0", VA = "0x18132E2B0")]
			set
			{
				if (_totalCount == value)
				{
					RefreshCells();
					return;
				}
				_totalCount = value;
				if (value != 0)
				{
					int offset = 0;
					RefillCells(offset);
				}
				else
				{
					ClearCells();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021E")]
		public int[] SelectedIndexes
		{
			[Cpp2IlInjected.Token(Token = "0x6000B0D")]
			[Cpp2IlInjected.Address(RVA = "0x132DF90", Offset = "0x132C990", VA = "0x18132DF90")]
			get
			{
				//Discarded unreachable code: IL_000c
				return (int[])(object)((List<T>)(object)selectedIndexes).ToArray();
			}
			[Cpp2IlInjected.Token(Token = "0x6000B0E")]
			[Cpp2IlInjected.Address(RVA = "0x132E280", Offset = "0x132CC80", VA = "0x18132E280")]
			set
			{
				IEnumerator routine = SelectedCoroutine(value);
				Coroutine coroutine = StartCoroutine(routine);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		public int RawSelectedIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000B0F")]
			[Cpp2IlInjected.Address(RVA = "0x70CB70", Offset = "0x70B570", VA = "0x18070CB70")]
			get
			{
				return _rawSelectedIndex;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000220")]
		public int SelectedIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000B10")]
			[Cpp2IlInjected.Address(RVA = "0x132DED0", Offset = "0x132C8D0", VA = "0x18132DED0")]
			get
			{
				//Discarded unreachable code: IL_002a
				int size = ((List<>)(object)selectedIndexes)._size;
				if (size > 0 && size == 0)
				{
					int num = 0;
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				return _selectedIndex = INVALID_INDEX;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B11")]
			[Cpp2IlInjected.Address(RVA = "0x132E1D0", Offset = "0x132CBD0", VA = "0x18132E1D0")]
			set
			{
				//Discarded unreachable code: IL_0043
				_rawSelectedIndex = value;
				_selectedIndex = value;
				if (base.gameObject.activeInHierarchy)
				{
					int[] array = new int[1];
					int num = (array[0] = _selectedIndex);
					IEnumerator routine = SelectedCoroutine(array);
					Coroutine coroutine = StartCoroutine(routine);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000221")]
		public ListEvents OnItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6000B13")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return m_OnItemData;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B14")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			set
			{
				m_OnItemData = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000222")]
		public ListEvents OnItemTap
		{
			[Cpp2IlInjected.Token(Token = "0x6000B15")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return m_OnItemTap;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B16")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			set
			{
				m_OnItemTap = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000223")]
		public ListEvents OnItemRightClick
		{
			[Cpp2IlInjected.Token(Token = "0x6000B17")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return m_OnItemRightClick;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B18")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			set
			{
				m_OnItemRightClick = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000224")]
		public ListEvents OnItemTapAndHold
		{
			[Cpp2IlInjected.Token(Token = "0x6000B19")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return m_OnItemTapAndHold;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B1A")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			set
			{
				m_OnItemTapAndHold = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000225")]
		public ListEvents OnItemSelect
		{
			[Cpp2IlInjected.Token(Token = "0x6000B1B")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return m_OnItemSelect;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B1C")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			set
			{
				m_OnItemSelect = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000226")]
		public ListEvents OnItemDeselect
		{
			[Cpp2IlInjected.Token(Token = "0x6000B1D")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return m_OnItemDeselect;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B1E")]
			[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60")]
			set
			{
				m_OnItemDeselect = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x132DAC0", Offset = "0x132C4C0", VA = "0x18132DAC0")]
		[IteratorStateMachine(typeof(_003CSelectedCoroutine_003Ed__28))]
		private IEnumerator SelectedCoroutine(int[] selectedIndexes)
		{
			int _003C_003E1__state = default(int);
			_003CSelectedCoroutine_003Ed__28 _003CSelectedCoroutine_003Ed__ = new _003CSelectedCoroutine_003Ed__28(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CSelectedCoroutine_003Ed__._003C_003E4__this = this;
			_003CSelectedCoroutine_003Ed__.selectedIndexes = selectedIndexes;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "4")]
		protected virtual bool UpdateItems(Bounds viewBounds, Bounds contentBounds)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B20")]
		[Cpp2IlInjected.Address(RVA = "0x132CB80", Offset = "0x132B580", VA = "0x18132CB80")]
		private void ClearCells()
		{
			//Discarded unreachable code: IL_005e, IL_0064, IL_0070
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			if (!Application.isPlaying)
			{
				return;
			}
			List<Transform> list = (List<Transform>)(object)new List<T>();
			IEnumerator enumerator = m_Content.transform.GetEnumerator();
			int num6 = default(int);
			if (enumerator != null)
			{
				uint num5 = default(uint);
				if (num3 < (int)num5)
				{
					num3 += num3;
					num3++;
				}
				if (enumerator == null)
				{
					num3 += num3;
				}
				num6 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
			}
			if (num6 != 0)
			{
			}
			bool flag = default(bool);
			if (flag)
			{
			}
			int iNVALID_INDEX = INVALID_INDEX;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x132D070", Offset = "0x132BA70", VA = "0x18132D070")]
		private void DestroyItem(Transform transform)
		{
			//Discarded unreachable code: IL_0052
			//IL_0010: Expected O, but got I4
			Button component = transform.GetComponent<Button>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				component.m_OnClick.RemoveAllListeners();
				int num2 = 0;
				if ((object)component == null)
				{
				}
			}
			GameObject gameObject = transform.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			Transform transform2 = (transform.parentInternal = transform.root);
			UnityEngine.Object.Destroy(transform.gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x132D840", Offset = "0x132C240", VA = "0x18132D840")]
		public void RefreshCells()
		{
			//Discarded unreachable code: IL_009c
			int num = 0;
			if (!Application.isPlaying || !base.isActiveAndEnabled)
			{
				return;
			}
			RectTransform rectTransform = m_Content;
			int num2 = 0;
			int childCount = rectTransform.transform.childCount;
			if (num2 < childCount)
			{
				Transform child = m_Content.transform.GetChild(num2);
				DestroyItem(child);
				Transform child2 = base.transform.GetChild(num2);
				ListEvents onItemData = m_OnItemData;
				if (onItemData != null)
				{
					ListEventData arg = new ListEventData(m_Content.transform.GetChild(num2).gameObject, num2);
					((UnityEvent<T0>)(object)onItemData).Invoke((T0)arg);
				}
				RectTransform rectTransform2 = m_Content;
				num2++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x132D7A0", Offset = "0x132C1A0", VA = "0x18132D7A0")]
		public void RefillCells(int offset = 0)
		{
			//IL_0020: Expected O, but got I4
			int num = 0;
			if (!Application.isPlaying)
			{
				return;
			}
			ClearCells();
			GameObject gameObject = prefab;
			int num2 = 0;
			if (gameObject != (UnityEngine.Object)num2)
			{
				int num3 = 0;
				if (_totalCount > num3)
				{
					RectTransform rectTransform = InstantiateNextItem(num3);
					num3++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x132D2E0", Offset = "0x132BCE0", VA = "0x18132D2E0")]
		private RectTransform InstantiateNextItem(int itemIdx)
		{
			//Discarded unreachable code: IL_018d
			//IL_0086: Expected O, but got I4
			//IL_00ce: Expected O, but got I4
			GameObject original = prefab;
			RectTransform parent = m_Content;
			GameObject item = UnityEngine.Object.Instantiate(original, parent);
			item.transform.SetAsLastSibling();
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
					ListBase listBase4 = this;
					int itemIdx5 = itemIdx;
					GameObject item5 = item;
					listBase4.onItemClickHandler(item5, itemIdx5);
				};
				onClick.AddListener(call);
			}
			CustomButton component3 = item.GetComponent<CustomButton>();
			int num2 = 0;
			UnityEvent onRightClicked = default(UnityEvent);
			if (component3 != (UnityEngine.Object)num2)
			{
				component3.OnClicked.RemoveAllListeners();
				UnityEvent onClicked = component3.OnClicked;
				UnityAction call2 = delegate
				{
					//Discarded unreachable code: IL_001e
					ListBase listBase3 = this;
					int itemIdx4 = itemIdx;
					GameObject item4 = item;
					listBase3.onItemClickHandler(item4, itemIdx4);
				};
				onClicked.AddListener(call2);
				component3.OnRightClicked.RemoveAllListeners();
				onRightClicked = component3.OnRightClicked;
				UnityAction call3 = delegate
				{
					//Discarded unreachable code: IL_001e
					ListBase listBase2 = this;
					int itemIdx3 = itemIdx;
					GameObject item3 = item;
					listBase2.onItemRightClickHandler(item3, itemIdx3);
				};
				onRightClicked.AddListener(call3);
			}
			if ((object)component2 != null)
			{
				int num3 = 0;
				if ((object)component2 != null)
				{
					onRightClicked.RemoveAllListeners();
					UnityAction unityAction = delegate
					{
						//Discarded unreachable code: IL_001e
						ListBase listBase = this;
						int itemIdx2 = itemIdx;
						GameObject item2 = item;
						listBase.onItemTapAndHoldHandler(item2, itemIdx2);
					};
				}
			}
			component.gameObject.SetActive(value: true);
			ListEvents onItemData = m_OnItemData;
			if (onItemData != null)
			{
				GameObject displayItem = component.gameObject;
				int index = itemIdx;
				ListEventData arg = new ListEventData(displayItem, index);
				((UnityEvent<T0>)(object)onItemData).Invoke((T0)arg);
			}
			return component;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x132DFE0", Offset = "0x132C9E0", VA = "0x18132DFE0")]
		private void onItemClickHandler([Optional] GameObject item, int itemIdx = 0)
		{
			ListEvents onItemTap = m_OnItemTap;
			if (onItemTap != null)
			{
				ListEventData arg = new ListEventData(item, itemIdx);
				((UnityEvent<T0>)(object)onItemTap).Invoke((T0)arg);
			}
			AddSelectedIndex(itemIdx);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x132E090", Offset = "0x132CA90", VA = "0x18132E090")]
		private void onItemRightClickHandler([Optional] GameObject item, int itemIdx = 0)
		{
			ListEvents onItemRightClick = m_OnItemRightClick;
			if (onItemRightClick != null)
			{
				ListEventData arg = new ListEventData(item, itemIdx);
				((UnityEvent<T0>)(object)onItemRightClick).Invoke((T0)arg);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x132E130", Offset = "0x132CB30", VA = "0x18132E130")]
		private void onItemTapAndHoldHandler([Optional] GameObject item, int itemIdx = 0)
		{
			ListEvents onItemTapAndHold = m_OnItemTapAndHold;
			if (onItemTapAndHold != null)
			{
				ListEventData arg = new ListEventData(item, itemIdx);
				((UnityEvent<T0>)(object)onItemTapAndHold).Invoke((T0)arg);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x132DB50", Offset = "0x132C550", VA = "0x18132DB50")]
		protected void SetSelectedIndexes(int[] indexes)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x132CFB0", Offset = "0x132B9B0", VA = "0x18132CFB0")]
		protected void DeselectItemAt(int index)
		{
			//IL_001a: Expected O, but got I4
			Transform itemByDataIndex = GetItemByDataIndex(index);
			if ((object)itemByDataIndex != null)
			{
				GameObject gameObject = itemByDataIndex.gameObject;
			}
			ListEventData arg = new ListEventData((GameObject)0, index);
			((UnityEvent<T0>)(object)m_OnItemDeselect)?.Invoke((T0)arg);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x132CF20", Offset = "0x132B920", VA = "0x18132CF20")]
		public void DeselectAllItems()
		{
			int num = 0;
			if (_totalCount > num)
			{
				DeselectItemAt(num);
				num++;
			}
			int num2 = (SelectedIndex = INVALID_INDEX);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x132DA00", Offset = "0x132C400", VA = "0x18132DA00")]
		protected void SelectItemAt(int index)
		{
			//IL_001a: Expected O, but got I4
			Transform itemByDataIndex = GetItemByDataIndex(index);
			if ((object)itemByDataIndex != null)
			{
				GameObject gameObject = itemByDataIndex.gameObject;
			}
			ListEventData arg = new ListEventData((GameObject)0, index);
			((UnityEvent<T0>)(object)m_OnItemSelect)?.Invoke((T0)arg);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x132D1F0", Offset = "0x132BBF0", VA = "0x18132D1F0", Slot = "5")]
		public virtual Transform GetItemByDataIndex(int index)
		{
			//IL_001e: Expected O, but got I4
			if (index < _totalCount)
			{
				Transform transform = m_Content.transform;
				int num = 0;
				if (!(transform == (UnityEngine.Object)num))
				{
					int childCount = m_Content.transform.childCount;
					if (index < childCount)
					{
						return m_Content.transform.GetChild(index);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x132C9F0", Offset = "0x132B3F0", VA = "0x18132C9F0")]
		protected void AddSelectedIndex(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x132DCE0", Offset = "0x132C6E0", VA = "0x18132DCE0")]
		public ListBase()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
