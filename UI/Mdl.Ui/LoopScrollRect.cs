using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[DisallowMultipleComponent]
	[AddComponentMenu("")]
	[RequireComponent(typeof(RectTransform))]
	[RequireComponent(typeof(PoolManager))]
	public abstract class LoopScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController
	{
		[Cpp2IlInjected.Token(Token = "0x20001C6")]
		public enum MovementType
		{
			[Cpp2IlInjected.Token(Token = "0x40007C3")]
			Unrestricted,
			[Cpp2IlInjected.Token(Token = "0x40007C4")]
			Elastic,
			[Cpp2IlInjected.Token(Token = "0x40007C5")]
			Clamped
		}

		[Cpp2IlInjected.Token(Token = "0x20001C7")]
		public enum ScrollbarVisibility
		{
			[Cpp2IlInjected.Token(Token = "0x40007C7")]
			Permanent,
			[Cpp2IlInjected.Token(Token = "0x40007C8")]
			AutoHide,
			[Cpp2IlInjected.Token(Token = "0x40007C9")]
			AutoHideAndExpandViewport
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001C8")]
		public class ScrollRectEvent : UnityEvent<Vector2>
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE0")]
			[Cpp2IlInjected.Address(RVA = "0xAFD3D0", Offset = "0xAFBDD0", VA = "0x180AFD3D0")]
			public ScrollRectEvent()
			{
				((UnityEvent<T0>)(object)this)._002Ector();
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001C9")]
		public class ListEvents : UnityEvent<ListEventData>
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE1")]
			[Cpp2IlInjected.Address(RVA = "0xAFD080", Offset = "0xAFBA80", VA = "0x180AFD080")]
			public ListEvents()
			{
				((UnityEvent<T0>)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001CA")]
		public delegate void ScrollDelegate();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		[Tooltip("Total count, negative means INFINITE mode")]
		public int totalCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		[HideInInspector]
		protected float threshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		[Tooltip("Reverse direction for dragging")]
		public bool reverseDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		[SerializeField]
		private bool _autoActive = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		[Tooltip("Rubber scale for outside")]
		public float rubberScale = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public PoolManager ExternalPool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		protected int itemTypeStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		protected int itemTypeEnd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		protected int directionSign;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		private float m_ContentSpacing = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		protected GridLayoutGroup m_GridLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		private int m_ContentConstraintCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		[SerializeField]
		private RectTransform m_Content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		[SerializeField]
		private bool m_Horizontal = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		[SerializeField]
		private MovementType m_MovementType = MovementType.Elastic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		[SerializeField]
		private float m_Elasticity = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		[SerializeField]
		private bool m_Inertia = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		[SerializeField]
		private float m_DecelerationRate = 0.135f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		[SerializeField]
		private float m_ScrollSensitivity = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		[SerializeField]
		private RectTransform m_Viewport;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		[SerializeField]
		private Scrollbar m_HorizontalScrollbar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		[SerializeField]
		private Scrollbar m_VerticalScrollbar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		[SerializeField]
		private ScrollbarVisibility m_HorizontalScrollbarVisibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		[SerializeField]
		private ScrollbarVisibility m_VerticalScrollbarVisibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		[SerializeField]
		private float m_HorizontalScrollbarSpacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		[SerializeField]
		private float m_VerticalScrollbarSpacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		[SerializeField]
		private ScrollRectEvent m_OnValueChanged = new ScrollRectEvent();

		[Cpp2IlInjected.Token(Token = "0x400079C")]
		public static readonly int INVALID_INDEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		public int MaxSelectableItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		private List<int> selectedIndexes = (List<int>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		public bool DeselectWhenSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB2")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		public bool DeselectOldest = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		[SerializeField]
		private ListEvents m_OnItemData = new ListEvents();

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		[SerializeField]
		private ListEvents m_OnItemTap = new ListEvents();

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		[SerializeField]
		private ListEvents m_OnItemRightClick = new ListEvents();

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		[SerializeField]
		private ListEvents m_OnItemTapAndHold = new ListEvents();

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		[SerializeField]
		private ListEvents m_OnItemSelect = new ListEvents();

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		[SerializeField]
		private ListEvents m_OnItemDeselect = new ListEvents();

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		private Vector2 m_PointerStartLocalCursor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		private Vector2 m_ContentStartPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40007AE")]
		private RectTransform m_ViewRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		private Bounds m_ContentBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40007B0")]
		private Bounds m_ViewBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40007B1")]
		private Vector2 m_Velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40007B2")]
		private bool m_Dragging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x40007B3")]
		private Vector2 m_PrevPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
		[Cpp2IlInjected.Token(Token = "0x40007B4")]
		private Bounds m_PrevContentBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x40007B5")]
		private Bounds m_PrevViewBounds;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x40007B6")]
		private bool m_HasRebuiltLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x195")]
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		private bool m_HSliderExpand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x196")]
		[Cpp2IlInjected.Token(Token = "0x40007B8")]
		private bool m_VSliderExpand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		private float m_HSliderHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		private float m_VSliderWidth;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		private RectTransform m_Rect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		private RectTransform m_HorizontalScrollbarRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		private RectTransform m_VerticalScrollbarRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		private DrivenRectTransformTracker m_Tracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		private Vector2 _tempPosForScrollbar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		private readonly Vector3[] m_Corners;

		[Cpp2IlInjected.Token(Token = "0x17000229")]
		protected float contentSpacing
		{
			[Cpp2IlInjected.Token(Token = "0x6000B41")]
			[Cpp2IlInjected.Address(RVA = "0x1338C30", Offset = "0x1337630", VA = "0x181338C30")]
			get
			{
				//Discarded unreachable code: IL_00aa
				//IL_000b: Invalid comparison between F4 and I4
				//IL_002b: Expected O, but got I4
				//IL_0047: Expected O, but got I4
				//IL_0084: Expected O, but got I4
				//IL_0097: Expected O, but got I4
				float num = m_ContentSpacing;
				int num2 = 0;
				if (!(num >= (float)num2))
				{
					RectTransform rectTransform = m_Content;
					m_ContentSpacing = 0f;
					int num3 = 0;
					if (rectTransform != (UnityEngine.Object)num3)
					{
						HorizontalOrVerticalLayoutGroup component = m_Content.GetComponent<HorizontalOrVerticalLayoutGroup>();
						int num4 = 0;
						if (component != (UnityEngine.Object)num4)
						{
							float num5 = (m_ContentSpacing = component.m_Spacing);
						}
						GridLayoutGroup gridLayoutGroup = (m_GridLayout = m_Content.GetComponent<GridLayoutGroup>());
						GridLayoutGroup gridLayout = m_GridLayout;
						int num6 = 0;
						if (gridLayout != (UnityEngine.Object)num6)
						{
							GridLayoutGroup gridLayout2 = m_GridLayout;
							float num7 = (m_ContentSpacing = GetDimension((Vector2)num6));
						}
					}
					return m_ContentSpacing;
				}
				return num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		protected int contentConstraintCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000B42")]
			[Cpp2IlInjected.Address(RVA = "0x1338AF0", Offset = "0x13374F0", VA = "0x181338AF0")]
			get
			{
				//Discarded unreachable code: IL_0067
				//IL_0017: Expected I4, but got I8
				//IL_0020: Expected O, but got I4
				//IL_003a: Expected O, but got I4
				int num = m_ContentConstraintCount;
				RectTransform rectTransform = m_Content;
				m_ContentConstraintCount = 1;
				int num2 = 0;
				if (rectTransform != (UnityEngine.Object)num2)
				{
					GridLayoutGroup component = m_Content.GetComponent<GridLayoutGroup>();
					int num3 = 0;
					if (component != (UnityEngine.Object)num3)
					{
						if (component.m_Constraint == GridLayoutGroup.Constraint.Flexible)
						{
							Debug.LogWarning("[LoopScrollRect] Flexible not supported yet");
						}
						int num4 = (m_ContentConstraintCount = component.m_ConstraintCount);
					}
				}
				return m_ContentConstraintCount;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022B")]
		public RectTransform content
		{
			[Cpp2IlInjected.Token(Token = "0x6000B44")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return m_Content;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B45")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			set
			{
				m_Content = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022C")]
		public bool horizontal
		{
			[Cpp2IlInjected.Token(Token = "0x6000B46")]
			[Cpp2IlInjected.Address(RVA = "0xA5F820", Offset = "0xA5E220", VA = "0x180A5F820")]
			get
			{
				return m_Horizontal;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B47")]
			[Cpp2IlInjected.Address(RVA = "0xE3A650", Offset = "0xE39050", VA = "0x180E3A650")]
			set
			{
				m_Horizontal = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022D")]
		public MovementType movementType
		{
			[Cpp2IlInjected.Token(Token = "0x6000B48")]
			[Cpp2IlInjected.Address(RVA = "0x63F820", Offset = "0x63E220", VA = "0x18063F820")]
			get
			{
				return m_MovementType;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B49")]
			[Cpp2IlInjected.Address(RVA = "0x63FC00", Offset = "0x63E600", VA = "0x18063FC00")]
			set
			{
				m_MovementType = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		public float elasticity
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4A")]
			[Cpp2IlInjected.Address(RVA = "0x8239B0", Offset = "0x8223B0", VA = "0x1808239B0")]
			get
			{
				return m_Elasticity;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B4B")]
			[Cpp2IlInjected.Address(RVA = "0x824170", Offset = "0x822B70", VA = "0x180824170")]
			set
			{
				m_Elasticity = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		public bool inertia
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4C")]
			[Cpp2IlInjected.Address(RVA = "0xD247C0", Offset = "0xD231C0", VA = "0x180D247C0")]
			get
			{
				return m_Inertia;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B4D")]
			[Cpp2IlInjected.Address(RVA = "0xD2B640", Offset = "0xD2A040", VA = "0x180D2B640")]
			set
			{
				m_Inertia = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000230")]
		public float decelerationRate
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4E")]
			[Cpp2IlInjected.Address(RVA = "0x823CB0", Offset = "0x8226B0", VA = "0x180823CB0")]
			get
			{
				return m_DecelerationRate;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B4F")]
			[Cpp2IlInjected.Address(RVA = "0x824240", Offset = "0x822C40", VA = "0x180824240")]
			set
			{
				m_DecelerationRate = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000231")]
		public float scrollSensitivity
		{
			[Cpp2IlInjected.Token(Token = "0x6000B50")]
			[Cpp2IlInjected.Address(RVA = "0x13390A0", Offset = "0x1337AA0", VA = "0x1813390A0")]
			get
			{
				return m_ScrollSensitivity;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0x1339B10", Offset = "0x1338510", VA = "0x181339B10")]
			set
			{
				m_ScrollSensitivity = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000232")]
		public RectTransform viewport
		{
			[Cpp2IlInjected.Token(Token = "0x6000B52")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return m_Viewport;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B53")]
			[Cpp2IlInjected.Address(RVA = "0x1339D00", Offset = "0x1338700", VA = "0x181339D00")]
			set
			{
				m_Viewport = value;
				SetDirtyCaching();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000233")]
		public Scrollbar horizontalScrollbar
		{
			[Cpp2IlInjected.Token(Token = "0x6000B54")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return m_HorizontalScrollbar;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B55")]
			[Cpp2IlInjected.Address(RVA = "0x1339910", Offset = "0x1338310", VA = "0x181339910")]
			set
			{
				//Discarded unreachable code: IL_006a
				if ((bool)m_HorizontalScrollbar)
				{
					Scrollbar.ScrollEvent scrollEvent = m_HorizontalScrollbar.m_OnValueChanged;
					UnityAction<float> unityAction = (UnityAction<float>)(object)new UnityAction<T0>(SetHorizontalNormalizedPosition);
					((UnityEvent<T0>)(object)scrollEvent).RemoveListener((UnityAction<>)(object)unityAction);
				}
				m_HorizontalScrollbar = value;
				if ((bool)m_HorizontalScrollbar)
				{
					Scrollbar.ScrollEvent scrollEvent2 = m_HorizontalScrollbar.m_OnValueChanged;
					UnityAction<float> unityAction2 = (UnityAction<float>)(object)new UnityAction<T0>(SetHorizontalNormalizedPosition);
					((UnityEvent<T0>)(object)scrollEvent2).AddListener((UnityAction<>)(object)unityAction2);
				}
				SetDirtyCaching();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000234")]
		public Scrollbar verticalScrollbar
		{
			[Cpp2IlInjected.Token(Token = "0x6000B56")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			get
			{
				return m_VerticalScrollbar;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B57")]
			[Cpp2IlInjected.Address(RVA = "0x1339B40", Offset = "0x1338540", VA = "0x181339B40")]
			set
			{
				//Discarded unreachable code: IL_0035
				bool flag = default(bool);
				if (flag)
				{
					UnityAction<float> unityAction = (UnityAction<float>)(object)new UnityAction<T0>(SetVerticalNormalizedPosition);
				}
				m_VerticalScrollbar = value;
				if ((bool)value)
				{
					UnityAction<float> unityAction2 = (UnityAction<float>)(object)new UnityAction<T0>(SetVerticalNormalizedPosition);
				}
				SetDirtyCaching();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000235")]
		public ScrollbarVisibility horizontalScrollbarVisibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000B58")]
			[Cpp2IlInjected.Address(RVA = "0x63F8C0", Offset = "0x63E2C0", VA = "0x18063F8C0")]
			get
			{
				return m_HorizontalScrollbarVisibility;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B59")]
			[Cpp2IlInjected.Address(RVA = "0x1339900", Offset = "0x1338300", VA = "0x181339900")]
			set
			{
				m_HorizontalScrollbarVisibility = value;
				SetDirtyCaching();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000236")]
		public ScrollbarVisibility verticalScrollbarVisibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5A")]
			[Cpp2IlInjected.Address(RVA = "0xA8E0A0", Offset = "0xA8CAA0", VA = "0x180A8E0A0")]
			get
			{
				return m_VerticalScrollbarVisibility;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B5B")]
			[Cpp2IlInjected.Address(RVA = "0x1339B30", Offset = "0x1338530", VA = "0x181339B30")]
			set
			{
				m_VerticalScrollbarVisibility = value;
				SetDirtyCaching();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000237")]
		public float horizontalScrollbarSpacing
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5C")]
			[Cpp2IlInjected.Address(RVA = "0x1338FA0", Offset = "0x13379A0", VA = "0x181338FA0")]
			get
			{
				return m_HorizontalScrollbarSpacing;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B5D")]
			[Cpp2IlInjected.Address(RVA = "0x13398F0", Offset = "0x13382F0", VA = "0x1813398F0")]
			set
			{
				m_HorizontalScrollbarSpacing = value;
				SetDirty();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000238")]
		public float verticalScrollbarSpacing
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5E")]
			[Cpp2IlInjected.Address(RVA = "0x13392C0", Offset = "0x1337CC0", VA = "0x1813392C0")]
			get
			{
				return m_VerticalScrollbarSpacing;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B5F")]
			[Cpp2IlInjected.Address(RVA = "0x1339B20", Offset = "0x1338520", VA = "0x181339B20")]
			set
			{
				m_VerticalScrollbarSpacing = value;
				SetDirty();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000239")]
		public ScrollRectEvent onValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000B60")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			get
			{
				return m_OnValueChanged;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B61")]
			[Cpp2IlInjected.Address(RVA = "0x824230", Offset = "0x822C30", VA = "0x180824230")]
			set
			{
				m_OnValueChanged = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023A")]
		public int[] SelectedIndexes
		{
			[Cpp2IlInjected.Token(Token = "0x6000B62")]
			[Cpp2IlInjected.Address(RVA = "0x1338AA0", Offset = "0x13374A0", VA = "0x181338AA0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return (int[])(object)((List<T>)(object)selectedIndexes).ToArray();
			}
			[Cpp2IlInjected.Token(Token = "0x6000B63")]
			[Cpp2IlInjected.Address(RVA = "0x13398D0", Offset = "0x13382D0", VA = "0x1813398D0")]
			set
			{
				SetSelectedIndexes(value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023B")]
		public int SelectedIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000B64")]
			[Cpp2IlInjected.Address(RVA = "0x13389F0", Offset = "0x13373F0", VA = "0x1813389F0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000B65")]
			[Cpp2IlInjected.Address(RVA = "0x1339850", Offset = "0x1338250", VA = "0x181339850")]
			set
			{
				//Discarded unreachable code: IL_0017
				int[] array = new int[1];
				array[0] = value;
				SetSelectedIndexes(array);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xB0"), Cpp2IlInjected.Token(Token = "0x400079F")]
		public bool IsInAutoScrolling
		{
			[Cpp2IlInjected.Token(Token = "0x6000B66")]
			[Cpp2IlInjected.Address(RVA = "0x1195B30", Offset = "0x1194530", VA = "0x181195B30")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000B67")]
			[Cpp2IlInjected.Address(RVA = "0x1339830", Offset = "0x1338230", VA = "0x181339830")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700023D")]
		public ListEvents OnItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6000B68")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC20", Offset = "0x7D9620", VA = "0x1807DAC20")]
			get
			{
				return m_OnItemData;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B69")]
			[Cpp2IlInjected.Address(RVA = "0x9766B0", Offset = "0x9750B0", VA = "0x1809766B0")]
			set
			{
				m_OnItemData = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023E")]
		public ListEvents OnItemTap
		{
			[Cpp2IlInjected.Token(Token = "0x6000B6A")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC30", Offset = "0x7D9630", VA = "0x1807DAC30")]
			get
			{
				return m_OnItemTap;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B6B")]
			[Cpp2IlInjected.Address(RVA = "0xD2FD20", Offset = "0xD2E720", VA = "0x180D2FD20")]
			set
			{
				m_OnItemTap = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023F")]
		public ListEvents OnItemRightClick
		{
			[Cpp2IlInjected.Token(Token = "0x6000B6C")]
			[Cpp2IlInjected.Address(RVA = "0x738F90", Offset = "0x737990", VA = "0x180738F90")]
			get
			{
				return m_OnItemRightClick;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B6D")]
			[Cpp2IlInjected.Address(RVA = "0x11049F0", Offset = "0x11033F0", VA = "0x1811049F0")]
			set
			{
				m_OnItemRightClick = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000240")]
		public ListEvents OnItemTapAndHold
		{
			[Cpp2IlInjected.Token(Token = "0x6000B6E")]
			[Cpp2IlInjected.Address(RVA = "0x88B0D0", Offset = "0x889AD0", VA = "0x18088B0D0")]
			get
			{
				return m_OnItemTapAndHold;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B6F")]
			[Cpp2IlInjected.Address(RVA = "0x976600", Offset = "0x975000", VA = "0x180976600")]
			set
			{
				m_OnItemTapAndHold = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000241")]
		public ListEvents OnItemSelect
		{
			[Cpp2IlInjected.Token(Token = "0x6000B70")]
			[Cpp2IlInjected.Address(RVA = "0x738E80", Offset = "0x737880", VA = "0x180738E80")]
			get
			{
				return m_OnItemSelect;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B71")]
			[Cpp2IlInjected.Address(RVA = "0x739E90", Offset = "0x738890", VA = "0x180739E90")]
			set
			{
				m_OnItemSelect = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000242")]
		public ListEvents OnItemDeselect
		{
			[Cpp2IlInjected.Token(Token = "0x6000B72")]
			[Cpp2IlInjected.Address(RVA = "0x738AC0", Offset = "0x7374C0", VA = "0x180738AC0")]
			get
			{
				return m_OnItemDeselect;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B73")]
			[Cpp2IlInjected.Address(RVA = "0x976550", Offset = "0x974F50", VA = "0x180976550")]
			set
			{
				m_OnItemDeselect = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000243")]
		[HideInInspector]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xE8"), Cpp2IlInjected.Token(Token = "0x40007A8")]
		public bool MousePressIsClick
		{
			[Cpp2IlInjected.Token(Token = "0x6000B74")]
			[Cpp2IlInjected.Address(RVA = "0x13389E0", Offset = "0x13373E0", VA = "0x1813389E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000B75")]
			[Cpp2IlInjected.Address(RVA = "0x1339840", Offset = "0x1338240", VA = "0x181339840")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000244")]
		protected RectTransform viewRect
		{
			[Cpp2IlInjected.Token(Token = "0x6000B7C")]
			[Cpp2IlInjected.Address(RVA = "0x13392D0", Offset = "0x1337CD0", VA = "0x1813392D0")]
			get
			{
				bool flag = default(bool);
				if (flag)
				{
					RectTransform rectTransform = (m_ViewRect = m_Viewport);
				}
				bool flag2 = default(bool);
				if (flag2)
				{
					Transform transform = base.transform;
					if ((object)transform == null || (object)transform != null)
					{
						m_ViewRect = (RectTransform)transform;
					}
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000245")]
		public Vector2 velocity
		{
			[Cpp2IlInjected.Token(Token = "0x6000B7D")]
			[Cpp2IlInjected.Address(RVA = "0xD06F40", Offset = "0xD05940", VA = "0x180D06F40")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000B7E")]
			[Cpp2IlInjected.Address(RVA = "0xD07560", Offset = "0xD05F60", VA = "0x180D07560")]
			set
			{
				m_Velocity = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000246")]
		public bool IsDragging
		{
			[Cpp2IlInjected.Token(Token = "0x6000B7F")]
			[Cpp2IlInjected.Address(RVA = "0x13389D0", Offset = "0x13373D0", VA = "0x1813389D0")]
			get
			{
				return m_Dragging;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000247")]
		private RectTransform rectTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000B80")]
			[Cpp2IlInjected.Address(RVA = "0x1338FF0", Offset = "0x13379F0", VA = "0x181338FF0")]
			get
			{
				//IL_0010: Expected O, but got I4
				RectTransform rect = m_Rect;
				int num = 0;
				if (rect == (UnityEngine.Object)num)
				{
					RectTransform rectTransform = (m_Rect = GetComponent<RectTransform>());
				}
				return m_Rect;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000248")]
		public Vector2 normalizedPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA7")]
			[Cpp2IlInjected.Address(RVA = "0x1338FB0", Offset = "0x13379B0", VA = "0x181338FB0")]
			get
			{
				float num = horizontalNormalizedPosition;
				float num2 = verticalNormalizedPosition;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA8")]
			[Cpp2IlInjected.Address(RVA = "0x1339AD0", Offset = "0x13384D0", VA = "0x181339AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000249")]
		public float horizontalNormalizedPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA9")]
			[Cpp2IlInjected.Address(RVA = "0x1338E60", Offset = "0x1337860", VA = "0x181338E60")]
			get
			{
				while (true)
				{
					int updateItems = 0;
					UpdateBounds((byte)updateItems != 0);
					if (totalCount > 0)
					{
						int num = itemTypeStart;
						if (itemTypeEnd > num)
						{
							/*Error: Could not find block for branch target IL_0022*/;
						}
					}
				}
			}
			[Cpp2IlInjected.Token(Token = "0x6000BAA")]
			[Cpp2IlInjected.Address(RVA = "0x13364C0", Offset = "0x1334EC0", VA = "0x1813364C0")]
			set
			{
				int axis = 0;
				SetNormalizedPosition(value, axis);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024A")]
		public float verticalNormalizedPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000BAB")]
			[Cpp2IlInjected.Address(RVA = "0x1339130", Offset = "0x1337B30", VA = "0x181339130")]
			get
			{
				while (true)
				{
					int updateItems = 0;
					UpdateBounds((byte)updateItems != 0);
					if (totalCount > 0)
					{
						int num = itemTypeStart;
						if (itemTypeEnd > num)
						{
							break;
						}
					}
				}
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				Vector3 vector3 = default(Vector3);
				float z3 = vector3.z;
				Vector3 vector4 = default(Vector3);
				float z4 = vector4.z;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BAC")]
			[Cpp2IlInjected.Address(RVA = "0x1337240", Offset = "0x1335C40", VA = "0x181337240")]
			set
			{
				SetNormalizedPosition(value, 1);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024B")]
		private bool hScrollingNeeded
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB2")]
			[Cpp2IlInjected.Address(RVA = "0x1338DF0", Offset = "0x13377F0", VA = "0x181338DF0")]
			get
			{
				do
				{
					int num = 0;
				}
				while (Application.isPlaying);
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024C")]
		private bool vScrollingNeeded
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB3")]
			[Cpp2IlInjected.Address(RVA = "0x13390B0", Offset = "0x1337AB0", VA = "0x1813390B0")]
			get
			{
				int num = 0;
				if (!Application.isPlaying)
				{
					return true;
				}
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Vector3 vector2 = default(Vector3);
				float y = vector2.y;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024D")]
		public virtual float minWidth
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB6")]
			[Cpp2IlInjected.Address(RVA = "0x106F730", Offset = "0x106E130", VA = "0x18106F730", Slot = "55")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024E")]
		public virtual float preferredWidth
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB7")]
			[Cpp2IlInjected.Address(RVA = "0x106F730", Offset = "0x106E130", VA = "0x18106F730", Slot = "56")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C4"), Cpp2IlInjected.Token(Token = "0x40007C0")]
		public virtual float flexibleWidth
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB8")]
			[Cpp2IlInjected.Address(RVA = "0x1338DE0", Offset = "0x13377E0", VA = "0x181338DE0", Slot = "57")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000BB9")]
			[Cpp2IlInjected.Address(RVA = "0x13398E0", Offset = "0x13382E0", VA = "0x1813398E0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000250")]
		public virtual float minHeight
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBA")]
			[Cpp2IlInjected.Address(RVA = "0x106F730", Offset = "0x106E130", VA = "0x18106F730", Slot = "58")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000251")]
		public virtual float preferredHeight
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBB")]
			[Cpp2IlInjected.Address(RVA = "0x106F730", Offset = "0x106E130", VA = "0x18106F730", Slot = "59")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000252")]
		public virtual float flexibleHeight
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBC")]
			[Cpp2IlInjected.Address(RVA = "0x106F730", Offset = "0x106E130", VA = "0x18106F730", Slot = "60")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000253")]
		public virtual int layoutPriority
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBD")]
			[Cpp2IlInjected.Address(RVA = "0x1068830", Offset = "0x1067230", VA = "0x181068830", Slot = "61")]
			get
			{
				return -1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event ScrollDelegate ScrollStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000B76")]
			[Cpp2IlInjected.Address(RVA = "0x1338890", Offset = "0x1337290", VA = "0x181338890")]
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
			[Cpp2IlInjected.Token(Token = "0x6000B77")]
			[Cpp2IlInjected.Address(RVA = "0x13396F0", Offset = "0x13380F0", VA = "0x1813396F0")]
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

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event ScrollDelegate ScrollEnd
		{
			[Cpp2IlInjected.Token(Token = "0x6000B78")]
			[Cpp2IlInjected.Address(RVA = "0x13387F0", Offset = "0x13371F0", VA = "0x1813387F0")]
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
			[Cpp2IlInjected.Token(Token = "0x6000B79")]
			[Cpp2IlInjected.Address(RVA = "0x1339650", Offset = "0x1338050", VA = "0x181339650")]
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

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event ScrollDelegate ScrollUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x6000B7A")]
			[Cpp2IlInjected.Address(RVA = "0x1338930", Offset = "0x1337330", VA = "0x181338930")]
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
			[Cpp2IlInjected.Token(Token = "0x6000B7B")]
			[Cpp2IlInjected.Address(RVA = "0x1339790", Offset = "0x1338190", VA = "0x181339790")]
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

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(Slot = "38")]
		protected abstract float GetSize(RectTransform item);

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(Slot = "39")]
		protected abstract float GetDimension(Vector2 vector);

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(Slot = "40")]
		protected abstract Vector2 GetVector(float value);

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "41")]
		protected virtual bool UpdateItems(Bounds viewBounds, Bounds contentBounds)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B81")]
		[Cpp2IlInjected.Address(RVA = "0x1338530", Offset = "0x1336F30", VA = "0x181338530")]
		protected unsafe LoopScrollRect()
		{
			//IL_002d: Expected I4, but got I8
			//IL_006b: Expected I4, but got I8
			//IL_00f6: Expected F4, but got I4
			//IL_00f1: Expected native int or pointer, but got O
			//IL_0114: Expected F4, but got I4
			//IL_010f: Expected native int or pointer, but got O
			//IL_012f: Expected F4, but got I4
			//IL_012a: Expected native int or pointer, but got O
			int num = 0;
			Vector2 zero = Vector2.zero;
			int num2 = 0;
			m_PointerStartLocalCursor = zero;
			((Vector2*)(IntPtr)m_PointerStartLocalCursor)->y = 0f;
			Vector2 zero2 = Vector2.zero;
			int num3 = 0;
			m_ContentStartPosition = zero2;
			((Vector2*)(IntPtr)m_ContentStartPosition)->y = 0f;
			m_PrevPosition = Vector2.zero;
			((Vector2*)(IntPtr)m_PrevPosition)->y = 0f;
			m_Corners = new Vector3[4];
			base._002Ector();
			flexibleWidth = -1f;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B82")]
		[Cpp2IlInjected.Address(RVA = "0x1331B60", Offset = "0x1330560", VA = "0x181331B60")]
		public void ClearCells()
		{
			//Discarded unreachable code: IL_0069
			//IL_003b: Expected O, but got I4
			RectTransform rectTransform = m_Content;
			totalCount = (itemTypeStart = 0);
			int childCount = rectTransform.childCount;
			FocusNavigationElement component = m_Content.GetChild(childCount).GetComponent<FocusNavigationElement>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				component.CustomFindNext.RemoveAllListeners();
			}
			PoolManager currentPool = GetCurrentPool();
			Transform child = m_Content.GetChild(childCount);
			currentPool.ReturnObject(child);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B83")]
		[Cpp2IlInjected.Address(RVA = "0x13357F0", Offset = "0x13341F0", VA = "0x1813357F0")]
		public void RemoveSelectedAndHighlightState()
		{
			//Discarded unreachable code: IL_0038, IL_003e, IL_0044, IL_0050
			int num = 0;
			IEnumerator enumerator = m_Content.GetEnumerator();
			if (enumerator != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				InventoryItem inventoryItem = default(InventoryItem);
				int num4 = ((inventoryItem.IsSelected = false) ? 1 : 0);
				InventoryItem inventoryItem2 = default(InventoryItem);
				inventoryItem2.RemoveHighlight();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B84")]
		[Cpp2IlInjected.Address(RVA = "0x1335D30", Offset = "0x1334730", VA = "0x181335D30")]
		public void ScrollToCell(int index, float speed, [Optional] Action callback)
		{
			//Discarded unreachable code: IL_006d
			//IL_002d: Invalid comparison between I4 and F4
			int _003C_003E1__state = default(int);
			object[] array2;
			while (true)
			{
				int num = totalCount;
				object[] array = new object[1];
				if (array == null || array != null)
				{
					array[0] = array;
					Debug.LogWarningFormat("invalid index {0}", array);
					int index2 = 0;
					if (!(0f >= speed))
					{
						StopAllCoroutines();
						IsInAutoScrolling = true;
						_003CScrollToCellCoroutine_003Ed__170 _003CScrollToCellCoroutine_003Ed__ = new _003CScrollToCellCoroutine_003Ed__170(_003C_003E1__state);
						_003C_003E1__state = 0;
						_003CScrollToCellCoroutine_003Ed__._003C_003E4__this = this;
						_003CScrollToCellCoroutine_003Ed__.callback = callback;
						_003CScrollToCellCoroutine_003Ed__.speed = speed;
						_003CScrollToCellCoroutine_003Ed__.index = index2;
						Coroutine coroutine = StartCoroutine(_003CScrollToCellCoroutine_003Ed__);
						return;
					}
					array2 = new object[1];
					if (array2 == null || array2 != null)
					{
						break;
					}
				}
			}
			array2[0] = array2;
			Debug.LogWarningFormat("invalid speed {0}", array2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B85")]
		[Cpp2IlInjected.Address(RVA = "0x1335C80", Offset = "0x1334680", VA = "0x181335C80")]
		[IteratorStateMachine(typeof(_003CScrollToCellCoroutine_003Ed__170))]
		private IEnumerator ScrollToCellCoroutine(int index, float speed, [Optional] Action callback)
		{
			int _003C_003E1__state = default(int);
			_003CScrollToCellCoroutine_003Ed__170 _003CScrollToCellCoroutine_003Ed__ = new _003CScrollToCellCoroutine_003Ed__170(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CScrollToCellCoroutine_003Ed__._003C_003E4__this = this;
			_003CScrollToCellCoroutine_003Ed__.callback = callback;
			_003CScrollToCellCoroutine_003Ed__.speed = speed;
			_003CScrollToCellCoroutine_003Ed__.index = index;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B86")]
		[Cpp2IlInjected.Address(RVA = "0x1335560", Offset = "0x1333F60", VA = "0x181335560")]
		public void RefreshCells()
		{
			//Discarded unreachable code: IL_00b3
			//IL_0090: Expected I4, but got I8
			//IL_00a6: Expected I4, but got O
			int num = 0;
			if (!Application.isPlaying || !base.gameObject.activeInHierarchy)
			{
				return;
			}
			int num2 = itemTypeStart;
			int num3 = 0;
			itemTypeEnd = num2;
			int childCount = m_Content.childCount;
			if (num3 < childCount)
			{
				Transform child = m_Content.GetChild(num3);
				int num4 = itemTypeEnd;
				PoolManager currentPool = GetCurrentPool();
				currentPool.ReturnObject(child);
				ListEvents onItemData = m_OnItemData;
				if (onItemData != null)
				{
					GameObject displayItem = child.gameObject;
					int index = itemTypeEnd;
					ulong num5 = default(ulong);
					int reason = default(int);
					ListEventData arg = new ListEventData(displayItem, index, (ListEventReason)reason, (int)num5);
					reason = 0;
					((UnityEvent<T0>)(object)onItemData).Invoke((T0)arg);
				}
				itemTypeEnd = (int)currentPool;
				RectTransform rectTransform = m_Content;
				num3++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B87")]
		[Cpp2IlInjected.Address(RVA = "0x1334D50", Offset = "0x1333750", VA = "0x181334D50")]
		public void RefillCellsFromEnd(int offset = 0)
		{
			//Discarded unreachable code: IL_0127
			//IL_0086: Expected O, but got I4
			//IL_00e9: Invalid comparison between I4 and F4
			//IL_0101: Expected F4, but got I4
			//IL_0101: Expected F4, but got I4
			int num = 0;
			int num2 = 0;
			if (Application.isPlaying && (long)GetCurrentPool().prefabSource != 0)
			{
				StopMovement();
				int num3 = totalCount;
				if (!reverseDirection)
				{
					num3 -= offset;
				}
				itemTypeEnd = offset;
				itemTypeStart = offset;
				int num4 = 0;
				int num5 = contentConstraintCount;
				num5 = offset;
				if (num4 != 0)
				{
					Debug.LogWarning("Grid will become strange since we can't fill items in the last line");
				}
				int childCount = m_Content.childCount;
				PoolManager externalPool = ExternalPool;
				int num6 = 0;
				if (externalPool == (UnityEngine.Object)num6)
				{
					PoolManager component = GetComponent<PoolManager>();
				}
				PoolManager externalPool2 = ExternalPool;
				Transform child = m_Content.GetChild(childCount);
				externalPool2.ReturnObject(child);
				int num7 = 0;
				int num8 = 0;
				if (directionSign != -1)
				{
					RectTransform rectTransform = viewRect;
				}
				int num9 = 0;
				if ((reverseDirection ? 1 : 0) != num9)
				{
					float num10 = NewItemAtEnd();
				}
				float num11 = NewItemAtStart();
				if (!((float)num7 >= num11))
				{
				}
				Vector2 anchoredPosition = m_Content.anchoredPosition;
				float num12 = Mathf.Max((float)num7, (float)num8);
				if (reverseDirection)
				{
				}
				RectTransform rectTransform2 = directionSign switch
				{
					_ => m_Content, 
				};
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B88")]
		[Cpp2IlInjected.Address(RVA = "0x13350D0", Offset = "0x1333AD0", VA = "0x1813350D0")]
		public unsafe void RefillCells(int offset = 0)
		{
			//Discarded unreachable code: IL_0144
			//IL_0079: Expected O, but got I4
			//IL_00e1: Invalid comparison between I4 and F4
			//IL_011c: Expected O, but got I4
			//IL_0124: Expected O, but got I4
			//IL_0136: Expected O, but got I4
			//IL_0143: Expected F4, but got I4
			//IL_013e: Expected native int or pointer, but got O
			int num = 0;
			if ((long)GetCurrentPool().prefabSource == 0)
			{
				return;
			}
			StopMovement();
			int num2 = totalCount;
			if (reverseDirection)
			{
				num2 -= offset;
			}
			itemTypeStart = offset;
			itemTypeEnd = offset;
			int num3 = 0;
			int num4 = contentConstraintCount;
			num4 = offset;
			if (num3 != 0)
			{
				Debug.LogWarning("Grid will become strange since we can't fill items in the first line");
			}
			int childCount = m_Content.childCount;
			PoolManager externalPool = ExternalPool;
			int num5 = 0;
			if (externalPool == (UnityEngine.Object)num5)
			{
				PoolManager component = GetComponent<PoolManager>();
			}
			PoolManager externalPool2 = ExternalPool;
			Transform child = m_Content.GetChild(offset);
			externalPool2.ReturnObject(child);
			int num6 = 0;
			int num7 = 0;
			if (directionSign != 1)
			{
				RectTransform rectTransform = viewRect;
			}
			Rect rect = default(Rect);
			if ((long)(IntPtr)rect > (long)num6)
			{
				int num8 = 0;
				if ((reverseDirection ? 1 : 0) != num8)
				{
					float num9 = NewItemAtStart();
				}
				float num10 = NewItemAtEnd();
				if (!((float)num6 >= num10))
				{
					while ((long)(IntPtr)rect > (long)num7)
					{
					}
				}
			}
			RectTransform rectTransform2 = m_Content;
			int num11 = 0;
			Vector2 anchoredPosition = rectTransform2.anchoredPosition;
			switch (directionSign)
			{
			}
			m_Content.anchoredPosition = (Vector2)num11;
			Vector2 offset2 = CalculateOffset((Vector2)num11);
			UpdateScrollbars(offset2);
			_tempPosForScrollbar = (Vector2)num6;
			((Vector2*)(IntPtr)_tempPosForScrollbar)->y = num6;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B89")]
		[Cpp2IlInjected.Address(RVA = "0x1334020", Offset = "0x1332A20", VA = "0x181334020")]
		protected unsafe float NewItemAtStart()
		{
			//IL_0045: Expected F4, but got I4
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected F4, but got Unknown
			//IL_0089: Expected F4, but got I4
			//IL_00a8: Expected O, but got I4
			//IL_00bc: Expected F4, but got I4
			//IL_00b7: Expected native int or pointer, but got O
			//IL_00d0: Expected F4, but got I4
			//IL_00cb: Expected native int or pointer, but got O
			int num = itemTypeStart;
			int num2 = contentConstraintCount;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			if (contentConstraintCount > 0)
			{
				int itemIdx = itemTypeStart;
				RectTransform rectTransform = InstantiateNextItem(itemIdx);
				rectTransform.SetAsFirstSibling();
				float num6 = Mathf.Max(GetSize(rectTransform), num4);
				num5++;
				int num7 = contentConstraintCount;
			}
			float a = threshold;
			float b = num4 * 1.5f;
			float num8 = (threshold = Mathf.Max(a, b));
			if (!reverseDirection)
			{
				Vector2 vector = GetVector(num4);
				RectTransform rectTransform2 = m_Content;
				int num9 = 0;
				Vector2 anchoredPosition = rectTransform2.anchoredPosition;
				rectTransform2.anchoredPosition = (Vector2)num9;
				m_PrevPosition = vector;
				((Vector2*)(IntPtr)m_PrevPosition)->y = 0f;
				m_ContentStartPosition = vector;
				((Vector2*)(IntPtr)m_ContentStartPosition)->y = 0f;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(RVA = "0x1331F40", Offset = "0x1330940", VA = "0x181331F40")]
		protected unsafe float DeleteItemAtStart()
		{
			//IL_0074: Expected F4, but got I4
			//IL_00cf: Expected O, but got I4
			//IL_00fc: Expected native int or pointer, but got O
			//IL_011e: Expected native int or pointer, but got O
			if (!m_Dragging)
			{
				int num = 0;
				float y = m_Velocity.y;
				Vector2 zero = Vector2.zero;
			}
			int num2 = totalCount;
			if (itemTypeEnd < num2 && m_Content.childCount != 0)
			{
				int num3 = 0;
				int num4 = 0;
				float num5 = default(float);
				if (contentConstraintCount > 0)
				{
					RectTransform rectTransform = m_Content;
					int index = 0;
					Transform child = rectTransform.GetChild(index);
					if ((object)child != null)
					{
					}
					float a = default(float);
					num5 = Mathf.Max(a, num3);
					GetCurrentPool().ReturnObject(child);
					if (m_Content.childCount != 0)
					{
						num4++;
						int num6 = contentConstraintCount;
					}
				}
				if (!reverseDirection)
				{
					Vector2 vector = GetVector(num5);
					RectTransform rectTransform2 = m_Content;
					int num7 = 0;
					Vector2 anchoredPosition = rectTransform2.anchoredPosition;
					rectTransform2.anchoredPosition = (Vector2)num7;
					Vector2 prevPosition = m_PrevPosition;
					float y2 = m_PrevPosition.y;
					m_PrevPosition = prevPosition;
					Vector2 contentStartPosition = m_ContentStartPosition;
					((Vector2*)(IntPtr)m_PrevPosition)->y = y2;
					float y3 = m_ContentStartPosition.y;
					m_ContentStartPosition = contentStartPosition;
					((Vector2*)(IntPtr)m_ContentStartPosition)->y = y3;
				}
				return num5;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8B")]
		[Cpp2IlInjected.Address(RVA = "0x1333E50", Offset = "0x1332850", VA = "0x181333E50")]
		protected unsafe float NewItemAtEnd()
		{
			//IL_005a: Expected F4, but got I4
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected F4, but got Unknown
			//IL_00ba: Expected F4, but got I4
			//IL_00d9: Expected O, but got I4
			//IL_0106: Expected native int or pointer, but got O
			//IL_0128: Expected native int or pointer, but got O
			int num = totalCount;
			int num2 = 0;
			int num3 = 0;
			int num4 = contentConstraintCount;
			int childCount = m_Content.childCount;
			int num5 = 0;
			int num6 = contentConstraintCount;
			num6 = childCount;
			int num7 = 0;
			num4 -= num5;
			if (num4 > 0)
			{
				int itemIdx = itemTypeEnd;
				RectTransform item = InstantiateNextItem(itemIdx);
				float num8 = Mathf.Max(GetSize(item), num3);
				int num9 = itemTypeEnd;
				int num10 = totalCount;
				if ((itemTypeEnd = num9 + 1) < num10)
				{
					num7++;
				}
			}
			float a = threshold;
			float b = num3 * 1.5f;
			float num11 = (threshold = Mathf.Max(a, b));
			if (reverseDirection)
			{
				Vector2 vector = GetVector(num3);
				RectTransform rectTransform = m_Content;
				int num12 = 0;
				Vector2 anchoredPosition = rectTransform.anchoredPosition;
				rectTransform.anchoredPosition = (Vector2)num12;
				Vector2 prevPosition = m_PrevPosition;
				float y = m_PrevPosition.y;
				m_PrevPosition = prevPosition;
				Vector2 contentStartPosition = m_ContentStartPosition;
				((Vector2*)(IntPtr)m_PrevPosition)->y = y;
				float y2 = m_ContentStartPosition.y;
				m_ContentStartPosition = contentStartPosition;
				((Vector2*)(IntPtr)m_ContentStartPosition)->y = y2;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8C")]
		[Cpp2IlInjected.Address(RVA = "0x1331CA0", Offset = "0x13306A0", VA = "0x181331CA0")]
		protected unsafe float DeleteItemAtEnd()
		{
			//IL_0078: Expected F4, but got I4
			//IL_00e3: Expected O, but got I4
			//IL_00f7: Expected F4, but got I4
			//IL_00f2: Expected native int or pointer, but got O
			//IL_010b: Expected F4, but got I4
			//IL_0106: Expected native int or pointer, but got O
			if (!m_Dragging)
			{
				int num = 0;
				float y = m_Velocity.y;
				Vector2 zero = Vector2.zero;
			}
			int num2 = itemTypeStart;
			int num3 = contentConstraintCount;
			if (m_Content.childCount != 0)
			{
				int num4 = 0;
				int num5 = 0;
				float num6 = default(float);
				if (contentConstraintCount > 0)
				{
					RectTransform rectTransform = m_Content;
					int index = rectTransform.childCount - 1;
					Transform child = rectTransform.GetChild(index);
					if ((object)child != null)
					{
					}
					float a = default(float);
					num6 = Mathf.Max(a, num4);
					GetCurrentPool().ReturnObject(child);
					int num7 = 0;
					int num8 = contentConstraintCount;
					if (num7 != 0 && m_Content.childCount != 0)
					{
						num5++;
						int num9 = contentConstraintCount;
					}
				}
				if (reverseDirection)
				{
					Vector2 vector = GetVector(num6);
					RectTransform rectTransform2 = m_Content;
					int num10 = 0;
					Vector2 anchoredPosition = rectTransform2.anchoredPosition;
					rectTransform2.anchoredPosition = (Vector2)num10;
					m_PrevPosition = vector;
					((Vector2*)(IntPtr)m_PrevPosition)->y = 0f;
					m_ContentStartPosition = vector;
					((Vector2*)(IntPtr)m_ContentStartPosition)->y = 0f;
				}
				return num6;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x1333240", Offset = "0x1331C40", VA = "0x181333240")]
		private RectTransform InstantiateNextItem(int itemIdx)
		{
			//Discarded unreachable code: IL_015e
			//IL_004d: Expected O, but got I4
			//IL_010c: Expected I4, but got O
			//IL_0116: Expected I4, but got I8
			//IL_0127: Expected I4, but got I8
			//IL_013c: Expected O, but got I4
			PoolManager currentPool = GetCurrentPool();
			bool autoActive = _autoActive;
			GameObject item = currentPool.GetObject(autoActive);
			string text = default(string);
			string text2 = "Item_" + text;
			int num = 0;
			Button button = default(Button);
			if (button != (UnityEngine.Object)num)
			{
				button.m_OnClick.RemoveAllListeners();
				Button.ButtonClickedEvent onClick = button.m_OnClick;
				UnityAction call = delegate
				{
					//Discarded unreachable code: IL_001e
					LoopScrollRect loopScrollRect4 = this;
					int itemIdx5 = itemIdx;
					GameObject item5 = item;
					loopScrollRect4.onItemClickHandler(item5, itemIdx5);
				};
				onClick.AddListener(call);
				bool flag = default(bool);
				if (flag)
				{
					UnityAction call2 = delegate
					{
						//Discarded unreachable code: IL_001e
						LoopScrollRect loopScrollRect3 = this;
						int itemIdx4 = itemIdx;
						GameObject item4 = item;
						loopScrollRect3.onItemRightClickHandler(item4, itemIdx4);
					};
					onClick.AddListener(call2);
					UnityAction call3 = delegate
					{
						//Discarded unreachable code: IL_001e
						LoopScrollRect loopScrollRect2 = this;
						int itemIdx3 = itemIdx;
						GameObject item3 = item;
						loopScrollRect2.onItemMouseLeftButtonPressedHandler(item3, itemIdx3);
					};
					onClick.AddListener(call3);
				}
				int num2 = 0;
				if ((object)button != null)
				{
					UnityAction unityAction = delegate
					{
						//Discarded unreachable code: IL_001e
						LoopScrollRect loopScrollRect = this;
						int itemIdx2 = itemIdx;
						GameObject item2 = item;
						loopScrollRect.onItemTapAndHoldHandler(item2, itemIdx2);
					};
				}
			}
			RectTransform rectTransform = default(RectTransform);
			Transform transform = rectTransform.transform;
			RectTransform parent = m_Content;
			int worldPositionStays = 0;
			transform.SetParent(parent, (byte)worldPositionStays != 0);
			ListEvents onItemData = m_OnItemData;
			if (onItemData != null)
			{
				ListEventData listEventData = default(ListEventData);
				GameObject gameObject = (listEventData.DisplayObject = rectTransform.gameObject);
				listEventData.ItemIndex = (int)button;
				listEventData.Reason = ListEventReason.Usual;
				listEventData.NextItemIndex = -1;
				((UnityEvent<T0>)(object)onItemData).Invoke((T0)listEventData);
			}
			int num3 = 0;
			InventoryItem inventoryItem = default(InventoryItem);
			bool flag2 = inventoryItem == (UnityEngine.Object)num3;
			if (flag2 || inventoryItem.ShouldBeActivated != flag2)
			{
				rectTransform.gameObject.SetActive(value: true);
			}
			return rectTransform;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x1337290", Offset = "0x1335C90", VA = "0x181337290")]
		public void TriggerItemClickHandler(GameObject item, int itemIdx)
		{
			onItemClickHandler(item, itemIdx);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x13393E0", Offset = "0x1337DE0", VA = "0x1813393E0")]
		private void onItemClickHandler([Optional] GameObject item, int itemIdx = 0)
		{
			//IL_0022: Expected I4, but got I8
			//IL_0032: Expected I4, but got I8
			ListEvents onItemTap = m_OnItemTap;
			if (onItemTap != null)
			{
				ListEventData listEventData = default(ListEventData);
				listEventData.DisplayObject = item;
				listEventData.ItemIndex = itemIdx;
				listEventData.Reason = ListEventReason.Usual;
				listEventData.NextItemIndex = -1;
				((UnityEvent<T0>)(object)onItemTap).Invoke((T0)listEventData);
			}
			AddSelectedIndex(itemIdx);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x13394B0", Offset = "0x1337EB0", VA = "0x1813394B0")]
		private void onItemMouseLeftButtonPressedHandler(GameObject item, int itemIdx)
		{
			if (MousePressIsClick)
			{
				onItemClickHandler(item, itemIdx);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x13394D0", Offset = "0x1337ED0", VA = "0x1813394D0")]
		private void onItemRightClickHandler([Optional] GameObject item, int itemIdx = 0)
		{
			//IL_0022: Expected I4, but got I8
			//IL_0032: Expected I4, but got I8
			ListEvents onItemRightClick = m_OnItemRightClick;
			if (onItemRightClick != null)
			{
				ListEventData listEventData = default(ListEventData);
				listEventData.DisplayObject = item;
				listEventData.ItemIndex = itemIdx;
				listEventData.Reason = ListEventReason.Usual;
				listEventData.NextItemIndex = -1;
				((UnityEvent<T0>)(object)onItemRightClick).Invoke((T0)listEventData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x1339590", Offset = "0x1337F90", VA = "0x181339590")]
		private void onItemTapAndHoldHandler([Optional] GameObject item, int itemIdx = 0)
		{
			//IL_0022: Expected I4, but got I8
			//IL_0032: Expected I4, but got I8
			ListEvents onItemTapAndHold = m_OnItemTapAndHold;
			if (onItemTapAndHold != null)
			{
				ListEventData listEventData = default(ListEventData);
				listEventData.DisplayObject = item;
				listEventData.ItemIndex = itemIdx;
				listEventData.Reason = ListEventReason.Usual;
				listEventData.NextItemIndex = -1;
				((UnityEvent<T0>)(object)onItemTapAndHold).Invoke((T0)listEventData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x1334CF0", Offset = "0x13336F0", VA = "0x181334CF0", Slot = "42")]
		public virtual void Rebuild(CanvasUpdate executing)
		{
			switch (executing)
			{
			case CanvasUpdate.Prelayout:
				UpdateCachedData();
				break;
			case CanvasUpdate.PostLayout:
			{
				int updateItems = 0;
				UpdateBounds((byte)updateItems != 0);
				int num = 0;
				Vector2 zero = Vector2.zero;
				UpdateScrollbars(zero);
				UpdatePrevData();
				m_HasRebuiltLayout = true;
				break;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "43")]
		public virtual void LayoutComplete()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "44")]
		public virtual void GraphicUpdateComplete()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0x1337750", Offset = "0x1336150", VA = "0x181337750")]
		private void UpdateCachedData()
		{
			//Discarded unreachable code: IL_00da
			//IL_0019: Expected O, but got I4
			//IL_004d: Expected O, but got I4
			int num = 0;
			Transform transform = base.transform;
			Scrollbar scrollbar = m_HorizontalScrollbar;
			int num2 = 0;
			if (scrollbar == (UnityEngine.Object)num2)
			{
			}
			Transform transform2 = m_HorizontalScrollbar.transform;
			int hSliderExpand = 0;
			if ((object)transform2 != null)
			{
			}
			m_HorizontalScrollbarRect = (RectTransform)transform2;
			Scrollbar scrollbar2 = m_VerticalScrollbar;
			int num3 = 0;
			if (scrollbar2 == (UnityEngine.Object)num3)
			{
			}
			Transform transform3 = m_VerticalScrollbar.transform;
			if ((object)transform3 != null)
			{
			}
			m_VerticalScrollbarRect = (RectTransform)transform3;
			Transform parent = viewRect.parent;
			bool flag = parent == transform;
			if (!parent)
			{
			}
			bool flag2 = parent.parent == transform;
			bool flag3 = default(bool);
			if (!flag3)
			{
			}
			bool flag4 = default(bool);
			if (flag4)
			{
			}
			m_HSliderExpand = (byte)hSliderExpand != 0;
			bool flag5 = default(bool);
			bool vSliderExpand = default(bool);
			if (flag2 && flag5)
			{
				vSliderExpand = m_VerticalScrollbarVisibility == ScrollbarVisibility.AutoHideAndExpandViewport;
			}
			m_VSliderExpand = vSliderExpand;
			int num4 = 0;
			bool flag6 = default(bool);
			if (flag6)
			{
			}
			int num5 = 0;
			bool flag7 = default(bool);
			if (flag7)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x13348D0", Offset = "0x13332D0", VA = "0x1813348D0", Slot = "5")]
		protected override void OnEnable()
		{
			//Discarded unreachable code: IL_0070
			LayoutComplete();
			if ((bool)m_HorizontalScrollbar)
			{
				Scrollbar.ScrollEvent scrollEvent = m_HorizontalScrollbar.m_OnValueChanged;
				UnityAction<float> unityAction = (UnityAction<float>)(object)new UnityAction<T0>(SetHorizontalNormalizedPosition);
				((UnityEvent<T0>)(object)scrollEvent).AddListener((UnityAction<>)(object)unityAction);
			}
			if ((bool)m_VerticalScrollbar)
			{
				Scrollbar.ScrollEvent scrollEvent2 = m_VerticalScrollbar.m_OnValueChanged;
				UnityAction<float> unityAction2 = (UnityAction<float>)(object)new UnityAction<T0>(SetVerticalNormalizedPosition);
				((UnityEvent<T0>)(object)scrollEvent2).AddListener((UnityAction<>)(object)unityAction2);
			}
			CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild(this);
			IsInAutoScrolling = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x1334360", Offset = "0x1332D60", VA = "0x181334360", Slot = "7")]
		protected unsafe override void OnDisable()
		{
			//Discarded unreachable code: IL_0099
			//IL_0087: Expected F4, but got I4
			//IL_0082: Expected native int or pointer, but got O
			CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild(this);
			if ((bool)m_HorizontalScrollbar)
			{
				Scrollbar.ScrollEvent scrollEvent = m_HorizontalScrollbar.m_OnValueChanged;
				UnityAction<float> unityAction = (UnityAction<float>)(object)new UnityAction<T0>(SetHorizontalNormalizedPosition);
				((UnityEvent<T0>)(object)scrollEvent).RemoveListener((UnityAction<>)(object)unityAction);
			}
			if ((bool)m_VerticalScrollbar)
			{
				Scrollbar.ScrollEvent scrollEvent2 = m_VerticalScrollbar.m_OnValueChanged;
				UnityAction<float> unityAction2 = (UnityAction<float>)(object)new UnityAction<T0>(SetVerticalNormalizedPosition);
				((UnityEvent<T0>)(object)scrollEvent2).RemoveListener((UnityAction<>)(object)unityAction2);
			}
			m_HasRebuiltLayout = false;
			int num = 0;
			Vector2 vector = (m_Velocity = Vector2.zero);
			((Vector2*)(IntPtr)m_Velocity)->y = 0f;
			LayoutRebuilder.MarkLayoutForRebuild(rectTransform);
			LayoutComplete();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B99")]
		[Cpp2IlInjected.Address(RVA = "0x1333740", Offset = "0x1332140", VA = "0x181333740", Slot = "9")]
		public override bool IsActive()
		{
			//IL_001d: Expected O, but got I4
			bool flag = base.IsActive();
			if (!flag)
			{
				return flag;
			}
			RectTransform rectTransform = m_Content;
			int num = 0;
			return rectTransform != (UnityEngine.Object)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9A")]
		[Cpp2IlInjected.Address(RVA = "0x1332340", Offset = "0x1330D40", VA = "0x181332340")]
		private void EnsureLayoutHasRebuilt()
		{
			if (!m_HasRebuiltLayout)
			{
				int num = 0;
				if (!CanvasUpdateRegistry.IsRebuildingLayout())
				{
					int num2 = 0;
					Canvas.ForceUpdateCanvases();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9B")]
		[Cpp2IlInjected.Address(RVA = "0x1337250", Offset = "0x1335C50", VA = "0x181337250", Slot = "45")]
		public unsafe virtual void StopMovement()
		{
			//IL_001b: Expected F4, but got I4
			//IL_0016: Expected native int or pointer, but got O
			int num = 0;
			Vector2 vector = (m_Velocity = Vector2.zero);
			((Vector2*)(IntPtr)m_Velocity)->y = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9C")]
		[Cpp2IlInjected.Address(RVA = "0x1332850", Offset = "0x1331250", VA = "0x181332850")]
		public void ForceStopDrag()
		{
			m_Dragging = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9D")]
		[Cpp2IlInjected.Address(RVA = "0x1334B50", Offset = "0x1333550", VA = "0x181334B50", Slot = "46")]
		public virtual void OnScroll(PointerEventData data)
		{
			//Discarded unreachable code: IL_008f
			//IL_003f: Invalid comparison between O and F4
			//IL_0043: Invalid comparison between F4 and O
			//IL_0079: Expected O, but got I4
			if (IsActive())
			{
				EnsureLayoutHasRebuilt();
				int updateItems = 0;
				UpdateBounds((byte)updateItems != 0);
				float num = data.scrollDelta.y * -1f;
				Vector2 _003CscrollDelta_003Ek__BackingField = data.scrollDelta;
				if (m_Horizontal || _003CscrollDelta_003Ek__BackingField > (object)num)
				{
				}
				if ((object)num > _003CscrollDelta_003Ek__BackingField)
				{
				}
				int num2 = 0;
				Vector2 anchoredPosition = m_Content.anchoredPosition;
				Vector2 contentAnchoredPosition = default(Vector2);
				if (m_MovementType == MovementType.Clamped)
				{
					RectTransform rectTransform = m_Content;
					int num3 = 0;
					Vector2 anchoredPosition2 = rectTransform.anchoredPosition;
					contentAnchoredPosition = CalculateOffset((Vector2)num3);
				}
				SetContentAnchoredPosition(contentAnchoredPosition);
				int updateItems2 = 0;
				UpdateBounds((byte)updateItems2 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9E")]
		[Cpp2IlInjected.Address(RVA = "0x1334AF0", Offset = "0x13334F0", VA = "0x181334AF0", Slot = "47")]
		public unsafe virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_0025
			//IL_0024: Expected F4, but got I4
			//IL_001f: Expected native int or pointer, but got O
			if (eventData.button == PointerEventData.InputButton.Left)
			{
				int num = 0;
				Vector2 vector = (m_Velocity = Vector2.zero);
				((Vector2*)(IntPtr)m_Velocity)->y = 0f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9F")]
		[Cpp2IlInjected.Address(RVA = "0x13341E0", Offset = "0x1332BE0", VA = "0x1813341E0", Slot = "48")]
		public unsafe virtual void OnBeginDrag(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_009c
			//IL_004d: Expected F4, but got I4
			//IL_0048: Expected native int or pointer, but got O
			//IL_008f: Expected native int or pointer, but got O
			if (eventData.button == PointerEventData.InputButton.Left && IsActive())
			{
				this.ScrollStart?.Invoke();
				int updateItems = 0;
				UpdateBounds((byte)updateItems != 0);
				int num = 0;
				Vector2 vector = (m_PointerStartLocalCursor = Vector2.zero);
				((Vector2*)(IntPtr)m_PointerStartLocalCursor)->y = 0f;
				RectTransform rectTransform = viewRect;
				Vector2 _003Cposition_003Ek__BackingField = eventData.position;
				float y = eventData.position.y;
				Camera pressEventCamera = eventData.pressEventCamera;
				Vector2 vector2 = (m_ContentStartPosition = m_Content.anchoredPosition);
				((Vector2*)(IntPtr)m_ContentStartPosition)->y = y;
				m_Dragging = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA0")]
		[Cpp2IlInjected.Address(RVA = "0x1334AB0", Offset = "0x13334B0", VA = "0x181334AB0", Slot = "49")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_0022
			if (eventData.button == PointerEventData.InputButton.Left)
			{
				this.ScrollEnd?.Invoke();
				m_Dragging = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA1")]
		[Cpp2IlInjected.Address(RVA = "0x13345B0", Offset = "0x1332FB0", VA = "0x1813345B0", Slot = "50")]
		public virtual void OnDrag(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_007d
			//IL_0060: Expected O, but got I4
			//IL_007c: Expected O, but got I4
			if (eventData.button != 0 || !IsActive())
			{
				return;
			}
			RectTransform rectTransform = viewRect;
			Vector2 _003Cposition_003Ek__BackingField = eventData.position;
			float y = eventData.position.y;
			Camera pressEventCamera = eventData.pressEventCamera;
			bool flag = default(bool);
			if (flag)
			{
				int updateItems = 0;
				UpdateBounds((byte)updateItems != 0);
				RectTransform rectTransform2 = m_Content;
				int num = 0;
				Vector2 anchoredPosition = rectTransform2.anchoredPosition;
				Vector2 vector = CalculateOffset((Vector2)num);
				if (m_MovementType != MovementType.Elastic || m_MovementType != MovementType.Elastic)
				{
				}
				SetContentAnchoredPosition((Vector2)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x1336290", Offset = "0x1334C90", VA = "0x181336290", Slot = "51")]
		protected virtual void SetContentAnchoredPosition(Vector2 position)
		{
			//Discarded unreachable code: IL_0050
			RectTransform rectTransform = m_Content;
			if (!m_Horizontal)
			{
				Vector2 anchoredPosition = rectTransform.anchoredPosition;
			}
			Vector2 anchoredPosition2 = rectTransform.anchoredPosition;
			this.ScrollUpdate?.Invoke();
			Vector2 anchoredPosition3 = m_Content.anchoredPosition;
			m_Content.anchoredPosition = position;
			UpdateBounds(updateItems: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x1338480", Offset = "0x1336E80", VA = "0x181338480")]
		private void Update()
		{
			//Discarded unreachable code: IL_001d
			//IL_001b: Expected F4, but got I4
			float axisRaw = UnityEngine.Input.GetAxisRaw("Mouse ScrollWheel");
			int num = 0;
			m_Dragging = false;
			Vector2 vector = GetVector(num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x13337D0", Offset = "0x13321D0", VA = "0x1813337D0", Slot = "52")]
		protected unsafe virtual void LateUpdate()
		{
			//Discarded unreachable code: IL_018e
			//IL_00f3: Expected O, but got I4
			//IL_00fd: Expected O, but got I4
			//IL_0139: Expected F4, but got I4
			//IL_0134: Expected native int or pointer, but got O
			int num = 0;
			RectTransform rectTransform = m_Content;
			int num2 = 0;
			if (!rectTransform)
			{
				return;
			}
			EnsureLayoutHasRebuilt();
			UpdateScrollbarVisibility();
			int updateItems = 0;
			UpdateBounds((byte)updateItems != 0);
			int num3 = 0;
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			int num4 = 0;
			Vector2 zero = Vector2.zero;
			Vector2 offset = CalculateOffset(zero);
			if ((m_Dragging ? 1 : 0) == num)
			{
				int num5 = 0;
				Vector2 zero2 = Vector2.zero;
				int num6 = 0;
				Vector2 zero3 = Vector2.zero;
				Vector2 anchoredPosition = m_Content.anchoredPosition;
				if (m_MovementType == MovementType.Elastic && m_MovementType != MovementType.Elastic)
				{
					Vector2 anchoredPosition2 = m_Content.anchoredPosition;
					Vector2 anchoredPosition3 = m_Content.anchoredPosition;
					float num7 = default(float);
					float num8 = num7;
				}
				if ((m_Inertia ? 1 : 0) == num)
				{
				}
				float num9 = m_DecelerationRate;
				float num10 = default(float);
				float num11 = num10;
				num++;
				int num12 = 0;
				Vector2 zero4 = Vector2.zero;
				int num13 = default(int);
				if (m_MovementType == MovementType.Clamped)
				{
					RectTransform rectTransform2 = m_Content;
					num13 = 0;
					Vector2 anchoredPosition4 = rectTransform2.anchoredPosition;
					float num14 = num11;
					Vector2 vector = CalculateOffset((Vector2)num13);
				}
				SetContentAnchoredPosition((Vector2)num13);
				if ((m_Dragging ? 1 : 0) == num)
				{
					goto IL_0139;
				}
			}
			if ((m_Inertia ? 1 : 0) != num)
			{
				Vector2 anchoredPosition5 = m_Content.anchoredPosition;
				float num15 = Mathf.Clamp01(unscaledDeltaTime);
				m_Velocity = anchoredPosition5;
				((Vector2*)(IntPtr)m_Velocity)->y = 0f;
			}
			goto IL_0139;
			IL_0139:
			Bounds prevViewBounds = m_PrevViewBounds;
			bool flag = default(bool);
			if (!flag)
			{
				Bounds contentBounds = m_ContentBounds;
				if (!(contentBounds != contentBounds))
				{
					Vector2 anchoredPosition6 = m_Content.anchoredPosition;
				}
			}
			UpdateScrollbars(offset);
			ScrollRectEvent scrollRectEvent = m_OnValueChanged;
			float num16 = horizontalNormalizedPosition;
			float num17 = verticalNormalizedPosition;
			UpdatePrevData();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0x1337B70", Offset = "0x1336570", VA = "0x181337B70")]
		private void UpdatePrevData()
		{
			//Discarded unreachable code: IL_0049
			//IL_0010: Expected O, but got I4
			RectTransform rectTransform = m_Content;
			int num = 0;
			if (!(rectTransform == (UnityEngine.Object)num))
			{
				Vector2 anchoredPosition = m_Content.anchoredPosition;
			}
			int num2 = 0;
			Vector2 zero = Vector2.zero;
			Bounds bounds = (m_PrevViewBounds = m_ViewBounds);
			Bounds bounds2 = (m_PrevContentBounds = m_ContentBounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x13381B0", Offset = "0x1336BB0", VA = "0x1813381B0")]
		private void UpdateScrollbars(Vector2 offset)
		{
			//Discarded unreachable code: IL_00a6
			bool flag = m_HorizontalScrollbar;
			int num = 0;
			if (flag)
			{
				if (totalCount > 0)
				{
					Scrollbar scrollbar = m_HorizontalScrollbar;
					int num2 = itemTypeEnd;
				}
				m_HorizontalScrollbar.size = 1f;
				Scrollbar scrollbar2 = m_HorizontalScrollbar;
				float num4 = (scrollbar2.value = horizontalNormalizedPosition);
			}
			if ((bool)m_VerticalScrollbar)
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				if (totalCount > 0)
				{
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
					int num5 = itemTypeEnd;
				}
				Scrollbar scrollbar3 = m_VerticalScrollbar;
				Scrollbar scrollbar4 = m_VerticalScrollbar;
				float num7 = (scrollbar4.value = verticalNormalizedPosition);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x13364C0", Offset = "0x1334EC0", VA = "0x1813364C0")]
		private void SetHorizontalNormalizedPosition(float value)
		{
			int axis = 0;
			SetNormalizedPosition(value, axis);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x1337240", Offset = "0x1335C40", VA = "0x181337240")]
		private void SetVerticalNormalizedPosition(float value)
		{
			SetNormalizedPosition(value, 1);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x1336D60", Offset = "0x1335760", VA = "0x181336D60")]
		private void SetNormalizedPosition(float value, int axis)
		{
			//Discarded unreachable code: IL_005c
			//IL_005b: Expected I4, but got I8
			int num = 0;
			if (totalCount <= num)
			{
				return;
			}
			int num2 = itemTypeStart;
			if (itemTypeEnd <= num2)
			{
				return;
			}
			EnsureLayoutHasRebuilt();
			int updateItems = 0;
			UpdateBounds((byte)updateItems != 0);
			RectTransform rectTransform = m_Content;
			if (axis != 0)
			{
				if (axis != 1)
				{
					goto IL_003f;
				}
			}
			int num3 = 0;
			goto IL_003f;
			IL_003f:
			float num4 = default(float);
			if (!(num4 <= 0.01f))
			{
				RectTransform rectTransform2 = m_Content;
				int num5 = 0;
				ulong num6 = default(ulong);
				UpdateBounds((byte)num6 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0x1335C20", Offset = "0x1334620", VA = "0x181335C20")]
		private static float RubberDelta(float overStretching, float viewSize)
		{
			return Mathf.Sign(overStretching);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB1")]
		[Cpp2IlInjected.Address(RVA = "0x1334B40", Offset = "0x1333540", VA = "0x181334B40", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
			SetDirty();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "53")]
		public virtual void CalculateLayoutInputHorizontal()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "54")]
		public virtual void CalculateLayoutInputVertical()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x13364D0", Offset = "0x1334ED0", VA = "0x1813364D0", Slot = "62")]
		public virtual void SetLayoutHorizontal()
		{
			//Discarded unreachable code: IL_01e5
			//IL_0006: Expected F4, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_00f6: Expected O, but got I4
			//IL_0122: Expected O, but got I4
			//IL_0161: Expected O, but got I4
			//IL_0182: Expected O, but got I4
			//IL_01e4: Expected O, but got I4
			do
			{
				Physics.minPenetrationForPenalty = 0f;
				int num = 0;
			}
			while (!m_HSliderExpand && !m_VSliderExpand);
			RectTransform rectTransform = viewRect;
			RectTransform rectTransform2 = viewRect;
			int num2 = 0;
			Vector2 vector = (rectTransform2.anchorMin = Vector2.zero);
			RectTransform rectTransform3 = viewRect;
			int num3 = 0;
			Vector2 vector2 = (rectTransform3.anchorMax = Vector2.one);
			RectTransform rectTransform4 = viewRect;
			int num4 = 0;
			Vector2 vector3 = (rectTransform4.sizeDelta = Vector2.zero);
			RectTransform rectTransform5 = viewRect;
			int num5 = 0;
			Vector2 vector4 = (rectTransform5.anchoredPosition = Vector2.zero);
			LayoutRebuilder.ForceRebuildLayoutImmediate(m_Content);
			RectTransform rectTransform6 = viewRect;
			RectTransform rectTransform7 = viewRect;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			m_ViewBounds = (Bounds)num8;
			Bounds bounds = GetBounds();
			if (m_VSliderExpand && vScrollingNeeded)
			{
				RectTransform rectTransform8 = viewRect;
				RectTransform rectTransform9 = viewRect;
				int num9 = 0;
				Vector2 sizeDelta = rectTransform9.sizeDelta;
				rectTransform8.sizeDelta = (Vector2)num9;
				LayoutRebuilder.ForceRebuildLayoutImmediate(m_Content);
				RectTransform rectTransform10 = viewRect;
				RectTransform rectTransform11 = viewRect;
				int num10 = 0;
				int num11 = 0;
				int num12 = 0;
				m_ViewBounds = (Bounds)num12;
				Bounds bounds2 = GetBounds();
			}
			if (m_HSliderExpand && hScrollingNeeded)
			{
				RectTransform rectTransform12 = viewRect;
				RectTransform rectTransform13 = viewRect;
				int num13 = 0;
				Vector2 sizeDelta2 = rectTransform13.sizeDelta;
				rectTransform12.sizeDelta = (Vector2)num13;
				RectTransform rectTransform14 = viewRect;
				RectTransform rectTransform15 = viewRect;
				int num14 = 0;
				int num15 = 0;
				int num16 = 0;
				m_ViewBounds = (Bounds)num16;
				Bounds bounds3 = GetBounds();
			}
			if (m_VSliderExpand && vScrollingNeeded)
			{
				RectTransform rectTransform16 = viewRect;
				Vector2 sizeDelta3 = rectTransform16.sizeDelta;
				if ((object)rectTransform16 == null)
				{
					Vector2 sizeDelta4 = viewRect.sizeDelta;
					RectTransform rectTransform17 = viewRect;
					RectTransform rectTransform18 = viewRect;
					int num17 = 0;
					Vector2 sizeDelta5 = rectTransform18.sizeDelta;
					rectTransform17.sizeDelta = (Vector2)num17;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x1336C10", Offset = "0x1335610", VA = "0x181336C10", Slot = "63")]
		public virtual void SetLayoutVertical()
		{
			//Discarded unreachable code: IL_002e
			//IL_0025: Expected O, but got I4
			UpdateScrollbarLayout();
			RectTransform rectTransform = viewRect;
			RectTransform rectTransform2 = viewRect;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			m_ViewBounds = (Bounds)num3;
			Bounds bounds = GetBounds();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x1338020", Offset = "0x1336A20", VA = "0x181338020")]
		private void UpdateScrollbarVisibility()
		{
			//Discarded unreachable code: IL_00a3
			if ((bool)m_VerticalScrollbar && m_VerticalScrollbarVisibility != 0)
			{
				bool activeSelf = m_VerticalScrollbar.gameObject.activeSelf;
				bool flag = vScrollingNeeded;
				if (activeSelf != flag)
				{
					GameObject gameObject = m_VerticalScrollbar.gameObject;
					bool active = vScrollingNeeded;
					gameObject.SetActive(active);
				}
			}
			if ((bool)m_HorizontalScrollbar && m_HorizontalScrollbarVisibility != 0)
			{
				bool activeSelf2 = m_HorizontalScrollbar.gameObject.activeSelf;
				bool flag2 = hScrollingNeeded;
				if (activeSelf2 != flag2)
				{
					GameObject gameObject2 = m_HorizontalScrollbar.gameObject;
					bool active2 = hScrollingNeeded;
					gameObject2.SetActive(active2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x1337C40", Offset = "0x1336640", VA = "0x181337C40")]
		private void UpdateScrollbarLayout()
		{
			//IL_0034: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_006e: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_00db: Expected O, but got I4
			//IL_00f8: Expected O, but got I4
			//IL_0115: Expected O, but got I4
			//IL_013f: Expected O, but got I4
			if (m_VSliderExpand && (bool)m_HorizontalScrollbar)
			{
				RectTransform horizontalScrollbarRect = m_HorizontalScrollbarRect;
				int num = 0;
				Vector2 anchorMin = horizontalScrollbarRect.anchorMin;
				horizontalScrollbarRect.anchorMin = (Vector2)num;
				RectTransform horizontalScrollbarRect2 = m_HorizontalScrollbarRect;
				int num2 = 0;
				Vector2 anchorMax = horizontalScrollbarRect2.anchorMax;
				horizontalScrollbarRect2.anchorMax = (Vector2)num2;
				RectTransform horizontalScrollbarRect3 = m_HorizontalScrollbarRect;
				int num3 = 0;
				Vector2 anchoredPosition = horizontalScrollbarRect3.anchoredPosition;
				horizontalScrollbarRect3.anchoredPosition = (Vector2)num3;
				bool flag = vScrollingNeeded;
				RectTransform horizontalScrollbarRect4 = m_HorizontalScrollbarRect;
				if (!flag)
				{
					Vector2 sizeDelta = horizontalScrollbarRect4.sizeDelta;
				}
				int num4 = 0;
				Vector2 sizeDelta2 = horizontalScrollbarRect4.sizeDelta;
				horizontalScrollbarRect4.sizeDelta = (Vector2)num4;
			}
			if (m_HSliderExpand && (bool)m_VerticalScrollbar)
			{
				RectTransform verticalScrollbarRect = m_VerticalScrollbarRect;
				int num5 = 0;
				Vector2 anchorMin2 = verticalScrollbarRect.anchorMin;
				verticalScrollbarRect.anchorMin = (Vector2)num5;
				RectTransform verticalScrollbarRect2 = m_VerticalScrollbarRect;
				int num6 = 0;
				Vector2 anchorMax2 = verticalScrollbarRect2.anchorMax;
				verticalScrollbarRect2.anchorMax = (Vector2)num6;
				RectTransform verticalScrollbarRect3 = m_VerticalScrollbarRect;
				int num7 = 0;
				Vector2 anchoredPosition2 = verticalScrollbarRect3.anchoredPosition;
				verticalScrollbarRect3.anchoredPosition = (Vector2)num7;
				bool flag2 = hScrollingNeeded;
				RectTransform verticalScrollbarRect4 = m_VerticalScrollbarRect;
				if (flag2)
				{
					throw new NullReferenceException();
				}
				int num8 = 0;
				Vector2 sizeDelta3 = verticalScrollbarRect4.sizeDelta;
				verticalScrollbarRect4.sizeDelta = (Vector2)num8;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x1332870", Offset = "0x1331270", VA = "0x181332870")]
		public void ForceUpdateBounds()
		{
			UpdateBounds(updateItems: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x1332880", Offset = "0x1331280", VA = "0x181332880")]
		public void ForceUpdateScrollbar()
		{
			Vector2 offset = default(Vector2);
			UpdateScrollbars(offset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x13372A0", Offset = "0x1335CA0", VA = "0x1813372A0")]
		private void UpdateBounds(bool updateItems = false)
		{
			//Discarded unreachable code: IL_00a3
			//IL_0022: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			RectTransform rectTransform = viewRect;
			int num = 0;
			RectTransform rectTransform2 = viewRect;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			m_ViewBounds = (Bounds)num4;
			Bounds bounds = GetBounds();
			RectTransform rectTransform3 = m_Content;
			int num5 = 0;
			int num6 = 0;
			if (rectTransform3 == (UnityEngine.Object)num6)
			{
				return;
			}
			int num7 = 0;
			bool isPlaying = Application.isPlaying;
			if (updateItems != isPlaying && UpdateItems((Bounds)num6, (Bounds)num5))
			{
				int num8 = 0;
				if (!CanvasUpdateRegistry.IsRebuildingLayout())
				{
					int num9 = 0;
					if (!CanvasUpdateRegistry.IsRebuildingGraphics())
					{
						int num10 = 0;
						Canvas.ForceUpdateCanvases();
					}
				}
				Debug.LogError("[UI] LoopScrollRect#UpdateBounds is called while rebuilding the canvas!");
			}
			Vector2 pivot = m_Content.pivot;
			Vector2 pivot2 = m_Content.pivot;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x1332D00", Offset = "0x1331700", VA = "0x181332D00")]
		private Bounds GetBounds()
		{
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			if (!flag)
			{
				Matrix4x4 matrix4x = default(Matrix4x4);
				float m = matrix4x.m02;
				int num3 = 0;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				float num4 = Mathf.Min(Mathf.Min(m, float.MaxValue), float.MaxValue);
				float num5 = Mathf.Max(Mathf.Max(Mathf.Min(z, float.MaxValue), float.MinValue), float.MinValue);
				float num6 = Mathf.Max(z, float.MinValue);
				num3++;
				float z2 = Vector3.zero.z;
			}
			int num7 = 0;
			int num8 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x13328C0", Offset = "0x13312C0", VA = "0x1813328C0")]
		protected Bounds GetBounds4Item(int index)
		{
			//IL_0029: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			if (!flag)
			{
				Matrix4x4 matrix4x = default(Matrix4x4);
				float m = matrix4x.m02;
				int num3 = 0;
				Transform transform = default(Transform);
				if ((object)transform != null)
				{
				}
				int num4 = 0;
				if (!((UnityEngine.Object)num3 == (UnityEngine.Object)num4))
				{
					Vector3 vector = default(Vector3);
					float z = vector.z;
					float num5 = Mathf.Min(Mathf.Min(m, float.MaxValue), float.MaxValue);
					float num6 = Mathf.Max(Mathf.Max(Mathf.Min(z, float.MaxValue), float.MinValue), float.MinValue);
					float num7 = Mathf.Max(z, float.MinValue);
					num3++;
					float z2 = Vector3.zero.z;
				}
			}
			int num8 = 0;
			int num9 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x1331990", Offset = "0x1330390", VA = "0x181331990")]
		private Vector2 CalculateOffset(Vector2 delta)
		{
			int num = 0;
			Vector2 zero = Vector2.zero;
			if (m_MovementType != 0)
			{
				int num2 = 0;
				if ((m_Horizontal ? 1 : 0) == num2)
				{
					Vector3 vector = default(Vector3);
					float y = vector.y;
				}
			}
			return zero;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x1336440", Offset = "0x1334E40", VA = "0x181336440")]
		protected void SetDirty()
		{
			if (IsActive())
			{
				LayoutRebuilder.MarkLayoutForRebuild(rectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x1336390", Offset = "0x1334D90", VA = "0x181336390")]
		protected void SetDirtyCaching()
		{
			if (IsActive())
			{
				CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild(this);
				LayoutRebuilder.MarkLayoutForRebuild(rectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x13370E0", Offset = "0x1335AE0", VA = "0x1813370E0")]
		protected void SetSelectedIndexes(int[] indexes)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x13321C0", Offset = "0x1330BC0", VA = "0x1813321C0")]
		public void DeselectIndex(int index)
		{
			//Discarded unreachable code: IL_0028
			//IL_000c: Expected O, but got I4
			//IL_001b: Expected O, but got I4
			if (((List<T>)(object)selectedIndexes).Contains((T)index))
			{
				bool flag = ((List<T>)(object)selectedIndexes).Remove((T)index);
				int reason = 0;
				DeselectItemAt(index, (ListEventReason)reason);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x1332260", Offset = "0x1330C60", VA = "0x181332260")]
		protected void DeselectItemAt(int index, ListEventReason reason = ListEventReason.Usual, int nextIndex = -1)
		{
			//IL_001f: Expected O, but got I4
			Transform itemByDataIndex = GetItemByDataIndex(index);
			if ((object)itemByDataIndex != null)
			{
				GameObject gameObject = itemByDataIndex.gameObject;
			}
			int num = 0;
			ListEventData listEventData = default(ListEventData);
			listEventData.DisplayObject = (GameObject)num;
			listEventData.ItemIndex = index;
			listEventData.Reason = reason;
			listEventData.NextItemIndex = nextIndex;
			((UnityEvent<T0>)(object)m_OnItemDeselect)?.Invoke((T0)listEventData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x1336050", Offset = "0x1334A50", VA = "0x181336050")]
		protected void SelectItemAt(int index)
		{
			//IL_001c: Expected O, but got I4
			//IL_002c: Expected I4, but got I8
			//IL_003c: Expected I4, but got I8
			Transform itemByDataIndex = GetItemByDataIndex(index);
			if ((object)itemByDataIndex != null)
			{
				GameObject gameObject = itemByDataIndex.gameObject;
			}
			int num = 0;
			ListEventData listEventData = default(ListEventData);
			listEventData.DisplayObject = (GameObject)num;
			listEventData.ItemIndex = index;
			listEventData.Reason = ListEventReason.Usual;
			listEventData.NextItemIndex = -1;
			((UnityEvent<T0>)(object)m_OnItemSelect)?.Invoke((T0)listEventData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x13331F0", Offset = "0x1331BF0", VA = "0x1813331F0", Slot = "64")]
		public virtual Transform GetItemByDataIndex(int index)
		{
			//Discarded unreachable code: IL_001b
			int num = itemTypeStart;
			int num2 = itemTypeEnd;
			return m_Content.GetChild(index);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x13337B0", Offset = "0x13321B0", VA = "0x1813337B0")]
		protected bool IsIndexOutOfRange(int index)
		{
			//Discarded unreachable code: IL_000c
			int num = itemTypeEnd;
			return index > num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x1333140", Offset = "0x1331B40", VA = "0x181333140")]
		public int GetIndexOf(Transform child)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (child != (UnityEngine.Object)num)
			{
				RectTransform parent = m_Content;
				if (child.IsChildOf(parent))
				{
					int num2 = itemTypeStart;
					int siblingIndex = child.GetSiblingIndex();
					num2 += siblingIndex;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0x13317E0", Offset = "0x13301E0", VA = "0x1813317E0")]
		protected void AddSelectedIndex(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0x1335710", Offset = "0x1334110", VA = "0x181335710")]
		public void Refresh(GameObject itemListProvider)
		{
			//Discarded unreachable code: IL_0021
			//IL_0009: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (!(itemListProvider == (UnityEngine.Object)num) && flag)
			{
				totalCount = (flag ? 1 : 0);
				int offset = 0;
				RefillCells(offset);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x1336130", Offset = "0x1334B30", VA = "0x181336130")]
		public void SelectNext()
		{
			//IL_006f: Expected O, but got I4
			int selectedIndex = SelectedIndex;
			selectedIndex++;
			if (selectedIndex < totalCount)
			{
				int selectedIndex2 = SelectedIndex;
				selectedIndex2++;
			}
			int num2 = (SelectedIndex = 0);
			int selectedIndex3 = SelectedIndex;
			int num3 = FindFirstOrLastItemIndex();
			int selectedIndex4 = SelectedIndex;
			int isFirst = 0;
			selectedIndex3 = selectedIndex4;
			int num4 = FindFirstOrLastItemIndex((byte)isFirst != 0);
			if (selectedIndex3 > num4)
			{
				int selectedIndex5 = SelectedIndex;
				int num5 = 0;
				ScrollToCell(selectedIndex5, 5000f, (Action)num5);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x13361E0", Offset = "0x1334BE0", VA = "0x1813361E0")]
		public void SelectPrevious()
		{
			//IL_0063: Expected O, but got I4
			int selectedIndex = SelectedIndex;
			int selectedIndex2 = SelectedIndex;
			int num2 = (SelectedIndex = totalCount);
			int selectedIndex3 = SelectedIndex;
			int num3 = FindFirstOrLastItemIndex();
			int selectedIndex4 = SelectedIndex;
			int isFirst = 0;
			selectedIndex3 = selectedIndex4;
			int num4 = FindFirstOrLastItemIndex((byte)isFirst != 0);
			if (selectedIndex3 > num4)
			{
				int selectedIndex5 = SelectedIndex;
				int num5 = 0;
				ScrollToCell(selectedIndex5, 5000f, (Action)num5);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x1333130", Offset = "0x1331B30", VA = "0x181333130")]
		internal int GetFirstVisibleItemIndex()
		{
			return FindFirstOrLastItemIndex();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x1333230", Offset = "0x1331C30", VA = "0x181333230")]
		internal int GetLastVisibleItemIndex()
		{
			int isFirst = 0;
			return FindFirstOrLastItemIndex((byte)isFirst != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x13323B0", Offset = "0x1330DB0", VA = "0x1813323B0")]
		internal int FindFirstOrLastItemIndex(bool isFirst = true)
		{
			//Discarded unreachable code: IL_00c2
			//IL_0024: Expected O, but got I4
			RectTransform rectTransform = m_Content;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			GridLayoutGroup component = rectTransform.GetComponent<GridLayoutGroup>();
			int num5 = 0;
			if (component != (UnityEngine.Object)num5)
			{
				int top = ((LayoutGroup)component).m_Padding.top;
				int left = ((LayoutGroup)component).m_Padding.left;
				int bottom = ((LayoutGroup)component).m_Padding.bottom;
			}
			RectTransform rectTransform2 = viewRect;
			RectTransform rectTransform3 = viewRect;
			int num6 = itemTypeStart;
			float z = Vector3.zero.z;
			bool flag = default(bool);
			if (flag)
			{
				int num7 = directionSign;
				if (num7 != -1)
				{
					if (num7 != 1)
					{
						goto IL_00af;
					}
					if (!isFirst)
					{
					}
				}
				if (isFirst)
				{
					Vector3 vector = default(Vector3);
					float z2 = vector.z;
				}
				Vector3 vector2 = default(Vector3);
				float z3 = vector2.z;
				Vector3 vector3 = default(Vector3);
				float z4 = vector3.z;
			}
			goto IL_00af;
			IL_00af:
			num6++;
			while (num6 <= itemTypeEnd)
			{
			}
			return num6;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x1335AE0", Offset = "0x13344E0", VA = "0x181335AE0")]
		private void ResetScrollbarValueCoroutine(Scrollbar scrollbar)
		{
			//Discarded unreachable code: IL_0046
			//IL_0009: Expected O, but got I4
			//IL_0015: Expected F4, but got I4
			//IL_003b: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			int num = 0;
			if (scrollbar != (UnityEngine.Object)num)
			{
				int num2 = 0;
				scrollbar.value = num2;
				Vector2 anchoredPosition = m_Content.anchoredPosition;
				RectTransform rectTransform = m_Content;
				int num3 = 0;
				Vector2 anchoredPosition2 = rectTransform.anchoredPosition;
				Vector2 vector = CalculateOffset((Vector2)num3);
				SetContentAnchoredPosition((Vector2)num3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x1335C10", Offset = "0x1334610", VA = "0x181335C10")]
		public void ResetVerticalValue()
		{
			Scrollbar scrollbar = m_VerticalScrollbar;
			ResetScrollbarValueCoroutine(scrollbar);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x1335AD0", Offset = "0x13344D0", VA = "0x181335AD0")]
		public void ResetHorizontalValue()
		{
			Scrollbar scrollbar = m_HorizontalScrollbar;
			ResetScrollbarValueCoroutine(scrollbar);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x1335A10", Offset = "0x1334410", VA = "0x181335A10")]
		private void ResetContentPosition()
		{
			//Discarded unreachable code: IL_002f
			//IL_0023: Expected O, but got I4
			//IL_002c: Expected O, but got I4
			Vector2 anchoredPosition = m_Content.anchoredPosition;
			RectTransform rectTransform = m_Content;
			int num = 0;
			Vector2 anchoredPosition2 = rectTransform.anchoredPosition;
			Vector2 vector = CalculateOffset((Vector2)num);
			float size = GetSize((RectTransform)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x13330A0", Offset = "0x1331AA0", VA = "0x1813330A0")]
		public PoolManager GetCurrentPool()
		{
			//IL_0010: Expected O, but got I4
			PoolManager externalPool = ExternalPool;
			int num = 0;
			if (externalPool == (UnityEngine.Object)num)
			{
				return GetComponent<PoolManager>();
			}
			return ExternalPool;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x1335440", Offset = "0x1333E40", VA = "0x181335440")]
		public void RefreshAt(int index)
		{
			//Discarded unreachable code: IL_005a
			//IL_0011: Expected O, but got I4
			//IL_0040: Expected I4, but got I8
			//IL_0051: Expected I4, but got I8
			Transform itemByDataIndex = GetItemByDataIndex(index);
			int num = 0;
			if (itemByDataIndex != (UnityEngine.Object)num)
			{
				ListEvents onItemData = m_OnItemData;
				if (onItemData != null)
				{
					ListEventData listEventData = default(ListEventData);
					GameObject gameObject = (listEventData.DisplayObject = itemByDataIndex.gameObject);
					listEventData.ItemIndex = index;
					listEventData.Reason = ListEventReason.Usual;
					listEventData.NextItemIndex = -1;
					((UnityEvent<T0>)(object)onItemData).Invoke((T0)listEventData);
				}
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0xCBB870", Offset = "0xCBA270", VA = "0x180CBB870", Slot = "23")]
		Transform ICanvasElement.get_transform()
		{
			return base.transform;
		}
	}
}
