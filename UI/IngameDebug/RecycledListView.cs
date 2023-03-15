using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[RequireComponent(typeof(ScrollRect))]
	public class RecycledListView : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		[SerializeField]
		private RectTransform viewportTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		[SerializeField]
		private RectTransform contentTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private float itemHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private float _1OverItemHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private float m_viewportWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private float m_viewportHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private readonly Dictionary<int, RecycledListItem> items = (Dictionary<int, RecycledListItem>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private readonly Stack<RecycledListItem> pooledItems = (Stack<RecycledListItem>)(object)new Stack<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private IListViewAdapter adapter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private bool isDirty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private int currentTopIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private int currentBottomIndex;

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public float ViewportWidth
		{
			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x83A7F0", Offset = "0x8391F0", VA = "0x18083A7F0")]
			get
			{
				return m_viewportWidth;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public float ViewportHeight
		{
			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0xBC59C0", Offset = "0xBC43C0", VA = "0x180BC59C0")]
			get
			{
				return m_viewportHeight;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0xF42230", Offset = "0xF40C30", VA = "0x180F42230")]
		private void Start()
		{
			//Discarded unreachable code: IL_0021
			ScrollRect.ScrollRectEvent onValueChanged = GetComponent<ScrollRect>().m_OnValueChanged;
			UnityAction<Vector2> unityAction = (UnityAction<Vector2>)(object)(UnityAction<T0>)delegate
			{
				int updateAllVisibleItems = 0;
				UpdateItemsInTheList((byte)updateAllVisibleItems != 0);
			};
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xF427D0", Offset = "0xF411D0", VA = "0x180F427D0")]
		private void Update()
		{
			//Discarded unreachable code: IL_002f
			//IL_0019: Expected F4, but got O
			//IL_0020: Expected F4, but got I4
			if (isDirty)
			{
				RectTransform rectTransform = viewportTransform;
				int updateAllVisibleItems = 0;
				Rect rect = default(Rect);
				m_viewportWidth = (float)rect;
				m_viewportHeight = 0f;
				isDirty = false;
				UpdateItemsInTheList((byte)updateAllVisibleItems != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0xF421B0", Offset = "0xF40BB0", VA = "0x180F421B0")]
		public void SetAdapter(IListViewAdapter adapter)
		{
			//Discarded unreachable code: IL_0008
			this.adapter = adapter;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0xF426A0", Offset = "0xF410A0", VA = "0x180F426A0")]
		public void UpdateList(bool resetContentPosition = true)
		{
			//Discarded unreachable code: IL_006e
			//IL_004f: Expected O, but got I4
			//IL_005f: Expected F4, but got O
			//IL_0066: Expected F4, but got I4
			if (resetContentPosition)
			{
				RectTransform rectTransform = contentTransform;
				int num = 0;
				Vector2 vector = (rectTransform.anchoredPosition = Vector2.zero);
			}
			IListViewAdapter listViewAdapter = adapter;
			int num2 = 0;
			float b = default(float);
			float num3 = Mathf.Max(1f, b);
			RectTransform rectTransform2 = contentTransform;
			int num4 = 0;
			Vector2 sizeDelta = rectTransform2.sizeDelta;
			rectTransform2.sizeDelta = (Vector2)num4;
			RectTransform rectTransform3 = viewportTransform;
			Rect rect = default(Rect);
			m_viewportWidth = (float)rect;
			m_viewportHeight = 0f;
			UpdateItemsInTheList(updateAllVisibleItems: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0xF41FC0", Offset = "0xF409C0", VA = "0x180F41FC0")]
		public void ResetList()
		{
			//Discarded unreachable code: IL_00da
			//IL_0047: Expected I4, but got O
			//IL_006a: Expected I4, but got I8
			//IL_00bb: Expected O, but got I4
			//IL_00cb: Expected F4, but got O
			//IL_00d2: Expected F4, but got I4
			IListViewAdapter listViewAdapter = adapter;
			_1OverItemHeight = 1f;
			if (currentTopIndex > -1)
			{
				int num = currentBottomIndex;
				if (num > -1)
				{
					IListViewAdapter listViewAdapter2 = adapter;
					if ((long)num > (long)(IntPtr)typeof(IListViewAdapter).TypeHandle)
					{
						IListViewAdapter listViewAdapter3 = adapter;
						currentBottomIndex = (int)typeof(IListViewAdapter).TypeHandle;
					}
					int bottomIndex = currentBottomIndex;
					int topIndex = currentTopIndex;
					DestroyItemsBetweenIndices(topIndex, bottomIndex);
					currentTopIndex = -1;
				}
			}
			RectTransform rectTransform = contentTransform;
			int num2 = 0;
			Vector2 vector = (rectTransform.anchoredPosition = Vector2.zero);
			IListViewAdapter listViewAdapter4 = adapter;
			int num3 = 0;
			float b = default(float);
			float num4 = Mathf.Max(1f, b);
			RectTransform rectTransform2 = contentTransform;
			int num5 = 0;
			Vector2 sizeDelta = rectTransform2.sizeDelta;
			rectTransform2.sizeDelta = (Vector2)num5;
			RectTransform rectTransform3 = viewportTransform;
			Rect rect = default(Rect);
			m_viewportWidth = (float)rect;
			m_viewportHeight = 0f;
			UpdateItemsInTheList(updateAllVisibleItems: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x5B9FB0", Offset = "0x5B89B0", VA = "0x1805B9FB0")]
		private void OnRectTransformDimensionsChange()
		{
			isDirty = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0xF42450", Offset = "0xF40E50", VA = "0x180F42450")]
		private void UpdateItemsInTheList(bool updateAllVisibleItems = false)
		{
			//Discarded unreachable code: IL_003a, IL_0065, IL_006b, IL_007b, IL_0093, IL_00a1, IL_00b3, IL_00cb, IL_00f3, IL_0102, IL_0112, IL_011d
			//IL_0039: Expected I4, but got I8
			//IL_0069: Invalid comparison between F4 and I4
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected F4, but got Unknown
			//IL_007b: Expected I4, but got F4
			//IL_0085: Expected I4, but got F4
			//IL_0091: Invalid comparison between F4 and I4
			//IL_009d: Expected I4, but got F4
			//IL_00b3: Expected I4, but got F4
			//IL_00c7: Expected I4, but got F4
			//IL_00df: Expected I4, but got F4
			//IL_00e9: Expected I4, but got F4
			//IL_00f3: Expected I4, but got F4
			//IL_00fb: Expected I4, but got F4
			if (adapter != null)
			{
				int num = currentTopIndex;
				if (num != -1)
				{
					int bottomIndex = currentBottomIndex;
					DestroyItemsBetweenIndices(num, bottomIndex);
					currentTopIndex = -1;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xF41CE0", Offset = "0xF406E0", VA = "0x180F41CE0")]
		private void CreateItemsBetweenIndices(int topIndex, int bottomIndex)
		{
			//Discarded unreachable code: IL_0051, IL_0055, IL_0056
			//IL_0039: Expected I4, but got I8
			int num = 0;
			Stack<RecycledListItem> stack = pooledItems;
			IListViewAdapter listViewAdapter = adapter;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			IListViewAdapter listViewAdapter2 = adapter;
			listViewAdapter2 = (IListViewAdapter)(object)((object)listViewAdapter2 + (object)listViewAdapter2);
			RecycledListItem recycledListItem = default(RecycledListItem);
			ulong num3 = default(ulong);
			recycledListItem.gameObject.SetActive((byte)num3 != 0);
			if ((object)recycledListItem.transform != null)
			{
				Dictionary<int, RecycledListItem> dictionary = items;
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0xF41AF0", Offset = "0xF404F0", VA = "0x180F41AF0")]
		private void CreateItemAtIndex(int index)
		{
			//Discarded unreachable code: IL_005f
			//IL_0039: Expected I4, but got I8
			//IL_0048: Expected O, but got I4
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected F4, but got Unknown
			//IL_005e: Expected O, but got I4
			Stack<RecycledListItem> stack = pooledItems;
			int num = 0;
			IListViewAdapter listViewAdapter = adapter;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			IListViewAdapter listViewAdapter2 = adapter;
			listViewAdapter2 = (IListViewAdapter)(object)((object)listViewAdapter2 + (object)listViewAdapter2);
			RecycledListItem recycledListItem = default(RecycledListItem);
			ulong num3 = default(ulong);
			recycledListItem.gameObject.SetActive((byte)num3 != 0);
			Transform transform = recycledListItem.transform;
			float num4 = ((RecycledListView)0).itemHeight;
			float num5 = /*Error near IL_0049: Stack underflow*/* num4;
			if ((object)transform != null)
			{
				((Dictionary<TKey, TValue>)(object)items)[(TKey)index] = (TValue)recycledListItem;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0xF41EF0", Offset = "0xF408F0", VA = "0x180F41EF0")]
		private void DestroyItemsBetweenIndices(int topIndex, int bottomIndex)
		{
			//Discarded unreachable code: IL_002e
			//IL_000c: Expected O, but got I4
			RecycledListItem recycledListItem = (RecycledListItem)((Dictionary<TKey, TValue>)(object)items)[(TKey)topIndex];
			GameObject gameObject = recycledListItem.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			((Stack<T>)(object)pooledItems).Push((T)recycledListItem);
			while (topIndex <= bottomIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0xF42310", Offset = "0xF40D10", VA = "0x180F42310")]
		private void UpdateItemContentsBetweenIndices(int topIndex, int bottomIndex)
		{
			//Discarded unreachable code: IL_002e
			//IL_000e: Expected O, but got I4
			int num = 0;
			RecycledListItem recycledListItem = (RecycledListItem)((Dictionary<TKey, TValue>)(object)items)[(TKey)topIndex];
			recycledListItem.Position = topIndex;
			IListViewAdapter listViewAdapter = adapter;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			while (topIndex <= bottomIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0xF42850", Offset = "0xF41250", VA = "0x180F42850")]
		public RecycledListView()
		{
		}//IL_0023: Expected I4, but got I8

	}
}
