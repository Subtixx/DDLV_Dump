using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000645")]
	public class PhoneListScroller : ScrollRect
	{
		[Cpp2IlInjected.Token(Token = "0x2000646")]
		public delegate void ScrollDelegate();

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4002322")]
		public int TotalCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x4002323")]
		private int _itemEndIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4002324")]
		private List<GameObject> _items = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4002328")]
		public ListBase.ListEvents OnItemData = new ListBase.ListEvents();

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4002329")]
		[SerializeField]
		public GameObject _itemPrefab;

		[Cpp2IlInjected.Token(Token = "0x14000046")]
		public event ScrollDelegate ScrollStart
		{
			[Cpp2IlInjected.Token(Token = "0x60028CE")]
			[Cpp2IlInjected.Address(RVA = "0x9B7550", Offset = "0x9B5F50", VA = "0x1809B7550")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60028CF")]
			[Cpp2IlInjected.Address(RVA = "0x9B7730", Offset = "0x9B6130", VA = "0x1809B7730")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000047")]
		public event ScrollDelegate ScrollEnd
		{
			[Cpp2IlInjected.Token(Token = "0x60028D0")]
			[Cpp2IlInjected.Address(RVA = "0x9B74B0", Offset = "0x9B5EB0", VA = "0x1809B74B0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60028D1")]
			[Cpp2IlInjected.Address(RVA = "0x9B7690", Offset = "0x9B6090", VA = "0x1809B7690")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000048")]
		public event ScrollDelegate ScrollUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x60028D2")]
			[Cpp2IlInjected.Address(RVA = "0x9B75F0", Offset = "0x9B5FF0", VA = "0x1809B75F0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60028D3")]
			[Cpp2IlInjected.Address(RVA = "0x9B77D0", Offset = "0x9B61D0", VA = "0x1809B77D0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028D4")]
		[Cpp2IlInjected.Address(RVA = "0x9B7350", Offset = "0x9B5D50", VA = "0x1809B7350", Slot = "6")]
		protected override void Start()
		{
			//Discarded unreachable code: IL_001c
			ScrollRectEvent scrollRectEvent = base.m_OnValueChanged;
			UnityAction<Vector2> unityAction = (UnityAction<Vector2>)(object)new UnityAction<T0>(OnValueChanedHandler);
			((UnityEvent<T0>)(object)scrollRectEvent).AddListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60028D5")]
		[Cpp2IlInjected.Address(RVA = "0x9B70E0", Offset = "0x9B5AE0", VA = "0x1809B70E0", Slot = "8")]
		protected override void OnDestroy()
		{
			//Discarded unreachable code: IL_001c
			ScrollRectEvent scrollRectEvent = base.m_OnValueChanged;
			UnityAction<Vector2> unityAction = (UnityAction<Vector2>)(object)new UnityAction<T0>(OnValueChanedHandler);
			((UnityEvent<T0>)(object)scrollRectEvent).RemoveListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60028D6")]
		[Cpp2IlInjected.Address(RVA = "0x9B71C0", Offset = "0x9B5BC0", VA = "0x1809B71C0")]
		private void OnValueChanedHandler(Vector2 arg0)
		{
			AddItem();
		}

		[Cpp2IlInjected.Token(Token = "0x60028D7")]
		[Cpp2IlInjected.Address(RVA = "0x9B70B0", Offset = "0x9B5AB0", VA = "0x1809B70B0", Slot = "44")]
		public override void OnBeginDrag(PointerEventData eventData)
		{
			base.OnBeginDrag(eventData);
			this.ScrollStart?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60028D8")]
		[Cpp2IlInjected.Address(RVA = "0x9B7190", Offset = "0x9B5B90", VA = "0x1809B7190", Slot = "45")]
		public override void OnEndDrag(PointerEventData eventData)
		{
			base.OnEndDrag(eventData);
			this.ScrollEnd?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60028D9")]
		[Cpp2IlInjected.Address(RVA = "0x9B71D0", Offset = "0x9B5BD0", VA = "0x1809B71D0")]
		public void RefreshList()
		{
			//Discarded unreachable code: IL_000c
			List<GameObject> items = _items;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028DA")]
		[Cpp2IlInjected.Address(RVA = "0x9B6E70", Offset = "0x9B5870", VA = "0x1809B6E70")]
		private void AddItem()
		{
			//Discarded unreachable code: IL_0088
			int totalCount = TotalCount;
			if (_itemEndIndex < totalCount)
			{
				RectTransform rectTransform = base.m_Content;
				Vector2 anchoredPosition = base.m_Content.anchoredPosition;
				RectTransform rectTransform2 = base.viewRect;
				GameObject itemPrefab = _itemPrefab;
				RectTransform parent = base.m_Content;
				GameObject gameObject = UnityEngine.Object.Instantiate(itemPrefab, parent);
				((List<T>)(object)_items).Add((T)gameObject);
				ListBase.ListEvents onItemData = OnItemData;
				if (onItemData != null)
				{
					int itemEndIndex = _itemEndIndex;
					ListBase.ListEventData arg = new ListBase.ListEventData(gameObject, itemEndIndex);
					((UnityEvent<T0>)(object)onItemData).Invoke((T0)arg);
				}
				LayoutRebuilder.ForceRebuildLayoutImmediate(base.m_Content);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028DB")]
		[Cpp2IlInjected.Address(RVA = "0x9B7400", Offset = "0x9B5E00", VA = "0x1809B7400")]
		public PhoneListScroller()
		{
		}
	}
}
