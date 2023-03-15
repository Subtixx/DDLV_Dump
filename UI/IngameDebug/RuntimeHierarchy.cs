using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public class RuntimeHierarchy : SkinnedWindow, IListViewAdapter
	{
		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		public delegate void SelectionChangedDelegate(Transform selection);

		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		public delegate void DoubleClickDelegate(Transform selection);

		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		public delegate bool GameObjectFilterDelegate(Transform transform);

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		[SerializeField]
		private float m_refreshInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		[SerializeField]
		private float m_objectNamesRefreshInterval = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		[SerializeField]
		private float m_searchRefreshInterval = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private float nextHierarchyRefreshTime = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private float nextObjectNamesRefreshTime = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private float nextSearchRefreshTime = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		[SerializeField]
		private bool m_exposeUnityScenes = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		[SerializeField]
		private bool m_exposeDontDestroyOnLoadScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		[SerializeField]
		private string[] pseudoScenesOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		[SerializeField]
		private bool m_createDraggedReferenceOnHold = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		[SerializeField]
		private float m_draggedReferenceHoldTime = 0.4f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		[SerializeField]
		private bool m_canReorganizeItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		[SerializeField]
		private float m_doubleClickThreshold = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		[SerializeField]
		private bool m_showHorizontalScrollbar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private bool m_isInSearchMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		[SerializeField]
		private RuntimeInspector m_connectedInspector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		[SerializeField]
		[Header("Internal Variables")]
		private ScrollRect scrollView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		[SerializeField]
		private RectTransform drawArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		[SerializeField]
		private RecycledListView listView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		[SerializeField]
		private Image background;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		[SerializeField]
		private Image verticalScrollbar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		[SerializeField]
		private Image horizontalScrollbar;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		[SerializeField]
		private InputField searchInputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		[SerializeField]
		private Image searchIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		[SerializeField]
		private Image searchInputFieldBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		[SerializeField]
		private LayoutElement searchBarLayoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		[SerializeField]
		private Image selectedPathBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		[SerializeField]
		private Text selectedPathText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		[SerializeField]
		private HierarchyDragDropListener dragDropListener;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		[SerializeField]
		private GameObject drawerPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		[SerializeField]
		private GameObject dragDropPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		[SerializeField]
		private Sprite m_sceneDrawerBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		[SerializeField]
		private Sprite m_transformDrawerBackground;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private static int aliveHierarchies;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private readonly List<HierarchyField> drawers = (List<HierarchyField>)(object)new List<T>(32);

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private readonly List<HierarchyDataRoot> sceneData = (List<HierarchyDataRoot>)(object)new List<T>(8);

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private readonly List<HierarchyDataRoot> searchSceneData = (List<HierarchyDataRoot>)(object)new List<T>(8);

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private readonly Dictionary<string, HierarchyDataRootPseudoScene> pseudoSceneDataLookup = (Dictionary<string, HierarchyDataRootPseudoScene>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private int totalItemCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private bool isListViewDirty = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private bool shouldRecalculateContentWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private float lastClickTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private HierarchyField currentlyPressedDrawer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private float pressedDrawerDraggedReferenceCreateTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private PointerEventData pressedDrawerActivePointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private Canvas m_canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private float m_autoScrollSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private PointerEventData nullPointerEventData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public SelectionChangedDelegate OnSelectionChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public DoubleClickDelegate OnItemDoubleClicked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private Transform m_currentSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private GameObjectFilterDelegate m_gameObjectDelegate;

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		public float RefreshInterval
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF60", Offset = "0xA7C960", VA = "0x180A7DF60")]
			get
			{
				return m_refreshInterval;
			}
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF80", Offset = "0xA7C980", VA = "0x180A7DF80")]
			set
			{
				m_refreshInterval = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		public float ObjectNamesRefreshInterval
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0xE3A600", Offset = "0xE39000", VA = "0x180E3A600")]
			get
			{
				return m_objectNamesRefreshInterval;
			}
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0xE3ABE0", Offset = "0xE395E0", VA = "0x180E3ABE0")]
			set
			{
				m_objectNamesRefreshInterval = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		public float SearchRefreshInterval
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x83A7F0", Offset = "0x8391F0", VA = "0x18083A7F0")]
			get
			{
				return m_searchRefreshInterval;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0xDD7740", Offset = "0xDD6140", VA = "0x180DD7740")]
			set
			{
				m_searchRefreshInterval = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		public bool ExposeUnityScenes
		{
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
			get
			{
				return m_exposeUnityScenes;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0xE3A8B0", Offset = "0xE392B0", VA = "0x180E3A8B0")]
			set
			{
				if (m_exposeUnityScenes == value)
				{
					return;
				}
				int num = 0;
				m_exposeUnityScenes = value;
				int num2 = 0;
				int sceneCount = SceneManager.sceneCount;
				if (num < sceneCount)
				{
					if (!value)
					{
						Scene sceneAt = SceneManager.GetSceneAt(num);
						num++;
					}
					Scene sceneAt2 = SceneManager.GetSceneAt(num);
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public bool ExposeDontDestroyOnLoadScene
		{
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0xE3A5E0", Offset = "0xE38FE0", VA = "0x180E3A5E0")]
			get
			{
				return m_exposeDontDestroyOnLoadScene;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xE3A860", Offset = "0xE39260", VA = "0x180E3A860")]
			set
			{
				if (m_exposeDontDestroyOnLoadScene != value)
				{
					m_exposeDontDestroyOnLoadScene = value;
					if (!value)
					{
						Scene dontDestroyOnLoadScene = GetDontDestroyOnLoadScene();
					}
					else
					{
						Scene dontDestroyOnLoadScene2 = GetDontDestroyOnLoadScene();
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		public bool CreateDraggedReferenceOnHold
		{
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730")]
			get
			{
				return m_createDraggedReferenceOnHold;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set
			{
				m_createDraggedReferenceOnHold = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public float DraggedReferenceHoldTime
		{
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0xE3A5D0", Offset = "0xE38FD0", VA = "0x180E3A5D0")]
			get
			{
				return m_draggedReferenceHoldTime;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(RVA = "0xE3A850", Offset = "0xE39250", VA = "0x180E3A850")]
			set
			{
				m_draggedReferenceHoldTime = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public bool CanReorganizeItems
		{
			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0xA5F820", Offset = "0xA5E220", VA = "0x180A5F820")]
			get
			{
				return m_canReorganizeItems;
			}
			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0xE3A650", Offset = "0xE39050", VA = "0x180E3A650")]
			set
			{
				m_canReorganizeItems = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public float DoubleClickThreshold
		{
			[Cpp2IlInjected.Token(Token = "0x60005DB")]
			[Cpp2IlInjected.Address(RVA = "0xE3A5C0", Offset = "0xE38FC0", VA = "0x180E3A5C0")]
			get
			{
				return m_doubleClickThreshold;
			}
			[Cpp2IlInjected.Token(Token = "0x60005DC")]
			[Cpp2IlInjected.Address(RVA = "0xA5F1D0", Offset = "0xA5DBD0", VA = "0x180A5F1D0")]
			set
			{
				m_doubleClickThreshold = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public bool ShowHorizontalScrollbar
		{
			[Cpp2IlInjected.Token(Token = "0x60005DD")]
			[Cpp2IlInjected.Address(RVA = "0x63F8A0", Offset = "0x63E2A0", VA = "0x18063F8A0")]
			get
			{
				return m_showHorizontalScrollbar;
			}
			[Cpp2IlInjected.Token(Token = "0x60005DE")]
			[Cpp2IlInjected.Address(RVA = "0xE3AC20", Offset = "0xE39620", VA = "0x180E3AC20")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public string SearchTerm
		{
			[Cpp2IlInjected.Token(Token = "0x60005DF")]
			[Cpp2IlInjected.Address(RVA = "0xE3A610", Offset = "0xE39010", VA = "0x180E3A610")]
			get
			{
				//Discarded unreachable code: IL_000c
				return searchInputField.m_Text;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0xE3ABF0", Offset = "0xE395F0", VA = "0x180E3ABF0")]
			set
			{
				//Discarded unreachable code: IL_000d
				searchInputField.text = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public bool IsInSearchMode
		{
			[Cpp2IlInjected.Token(Token = "0x60005E1")]
			[Cpp2IlInjected.Address(RVA = "0xE3A5F0", Offset = "0xE38FF0", VA = "0x180E3A5F0")]
			get
			{
				return m_isInSearchMode;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public RuntimeInspector ConnectedInspector
		{
			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return m_connectedInspector;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0xE3A660", Offset = "0xE39060", VA = "0x180E3A660")]
			set
			{
				//Discarded unreachable code: IL_0041
				if (m_connectedInspector != value)
				{
					m_connectedInspector = value;
					if ((bool)m_currentSelection)
					{
						Transform currentSelection = m_currentSelection;
						RuntimeInspector connectedInspector = m_connectedInspector;
						GameObject obj = currentSelection.gameObject;
						connectedInspector.Inspect(obj);
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		internal Sprite SceneDrawerBackground
		{
			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0x7393C0", Offset = "0x737DC0", VA = "0x1807393C0")]
			get
			{
				return m_sceneDrawerBackground;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		internal Sprite TransformDrawerBackground
		{
			[Cpp2IlInjected.Token(Token = "0x60005E5")]
			[Cpp2IlInjected.Address(RVA = "0x975F10", Offset = "0x974910", VA = "0x180975F10")]
			get
			{
				return m_transformDrawerBackground;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		internal int ItemCount
		{
			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(RVA = "0x9760F0", Offset = "0x974AF0", VA = "0x1809760F0")]
			get
			{
				return totalItemCount;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public Canvas Canvas
		{
			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(RVA = "0x975DE0", Offset = "0x9747E0", VA = "0x180975DE0")]
			get
			{
				return m_canvas;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		internal float AutoScrollSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0xE3A640", Offset = "0xE39040", VA = "0x180E3A640")]
			set
			{
				m_autoScrollSpeed = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public Transform CurrentSelection
		{
			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0x738C10", Offset = "0x737610", VA = "0x180738C10")]
			get
			{
				return m_currentSelection;
			}
			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39160", VA = "0x180E3A760")]
			private set
			{
				//IL_0015: Expected O, but got I4
				//IL_001f: Expected O, but got I4
				bool flag = value;
				int num = 0;
				if (m_currentSelection != (UnityEngine.Object)num)
				{
					m_currentSelection = (Transform)num;
					SelectionChangedDelegate onSelectionChanged = OnSelectionChanged;
					if (onSelectionChanged != null)
					{
						Transform currentSelection = m_currentSelection;
						onSelectionChanged(currentSelection);
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public GameObjectFilterDelegate GameObjectFilter
		{
			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x739220", Offset = "0x737C20", VA = "0x180739220")]
			get
			{
				return m_gameObjectDelegate;
			}
			[Cpp2IlInjected.Token(Token = "0x60005EC")]
			[Cpp2IlInjected.Address(RVA = "0xE3A9B0", Offset = "0xE393B0", VA = "0x180E3A9B0")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		int IListViewAdapter.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0x9760F0", Offset = "0x974AF0", VA = "0x1809760F0", Slot = "7")]
			get
			{
				return totalItemCount;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		float IListViewAdapter.ItemHeight
		{
			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0xE37B50", Offset = "0xE36550", VA = "0x180E37B50", Slot = "8")]
			get
			{
				UISkin skin = base.m_skin;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0xE360F0", Offset = "0xE34AF0", VA = "0x180E360F0", Slot = "4")]
		protected override void Awake()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0xE39AA0", Offset = "0xE384A0", VA = "0x180E39AA0")]
		private void Start()
		{
			SceneManager.add_sceneLoaded((UnityAction<, >)(object)new UnityAction<T0, T1>(OnSceneLoaded));
			SceneManager.add_sceneUnloaded((UnityAction<>)(object)new UnityAction<T0>(OnSceneUnloaded));
			if (m_exposeUnityScenes)
			{
				int num = 0;
				int num2 = 0;
				int sceneCount = SceneManager.sceneCount;
				if (num < sceneCount)
				{
					Scene sceneAt = SceneManager.GetSceneAt(num);
					num++;
				}
			}
			if (m_exposeDontDestroyOnLoadScene)
			{
				Scene dontDestroyOnLoadScene = GetDontDestroyOnLoadScene();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0xE37B70", Offset = "0xE36570", VA = "0x180E37B70")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_003f
			SceneManager.remove_sceneLoaded((UnityAction<, >)(object)new UnityAction<T0, T1>(OnSceneLoaded));
			SceneManager.remove_sceneUnloaded((UnityAction<>)(object)new UnityAction<T0>(OnSceneUnloaded));
			int num = 0;
			HierarchyData.ClearPool();
			HashSet<Transform> ignoredTransformsInHierarchy = RuntimeInspectorUtils.IgnoredTransformsInHierarchy;
			RectTransform item = drawArea;
			bool flag = ((HashSet<T>)(object)ignoredTransformsInHierarchy).Remove((T)item);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0xE37DE0", Offset = "0xE367E0", VA = "0x180E37DE0")]
		private void OnRectTransformDimensionsChange()
		{
			shouldRecalculateContentWidth = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0xE38600", Offset = "0xE37000", VA = "0x180E38600")]
		private void OnTransformParentChanged()
		{
			Canvas canvas = (m_canvas = GetComponentInParent<Canvas>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0xE39D20", Offset = "0xE38720", VA = "0x180E39D20", Slot = "5")]
		protected override void Update()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xE39200", Offset = "0xE37C00", VA = "0x180E39200")]
		public void Refresh()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0xE38650", Offset = "0xE37050", VA = "0x180E38650")]
		private void RefreshListView()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0xE39A90", Offset = "0xE38490", VA = "0x180E39A90")]
		public void SetListViewDirty()
		{
			isListViewDirty = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0xE38C00", Offset = "0xE37600", VA = "0x180E38C00")]
		public void RefreshSearchResults()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xE387E0", Offset = "0xE371E0", VA = "0x180E387E0")]
		public void RefreshNameOf(Transform target)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0xE38D90", Offset = "0xE37790", VA = "0x180E38D90", Slot = "6")]
		protected override void RefreshSkin()
		{
			//Discarded unreachable code: IL_00fe
			//IL_00d2: Expected O, but got I4
			UISkin skin = base.m_skin;
			Image image = background;
			UISkin skin2 = base.m_skin;
			Image image2 = verticalScrollbar;
			UISkin skin3 = base.m_skin;
			Image image3 = horizontalScrollbar;
			InputField inputField = searchInputField;
			UISkin skin4 = base.m_skin;
			inputField.m_TextComponent.SetSkinInputFieldText(skin4);
			UISkin skin5 = base.m_skin;
			Image image4 = searchInputFieldBackground;
			Color inputFieldNormalBackgroundColor = skin5.m_inputFieldNormalBackgroundColor;
			UISkin skin6 = base.m_skin;
			Image image5 = searchIcon;
			UISkin skin7 = base.m_skin;
			LayoutElement layoutElement = searchBarLayoutElement;
			UISkin skin8 = base.m_skin;
			Image image6 = selectedPathBackground;
			Color backgroundColor = skin8.m_backgroundColor;
			UISkin skin9 = base.m_skin;
			selectedPathText.SetSkinButtonText(skin9);
			Graphic placeholder = searchInputField.m_Placeholder;
			if ((object)placeholder == null)
			{
			}
			int num = 0;
			int num2 = 0;
			if (placeholder != (UnityEngine.Object)num2)
			{
				Color color = placeholder.color;
				Color color2 = placeholder.color;
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(drawArea);
			listView.ResetList();
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xE378C0", Offset = "0xE362C0", VA = "0x180E378C0", Slot = "10")]
		void IListViewAdapter.SetItemContent(RecycledListItem item)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0xE37120", Offset = "0xE35B20", VA = "0x180E37120", Slot = "11")]
		void IListViewAdapter.OnItemClicked(RecycledListItem item)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0xE36C90", Offset = "0xE35690", VA = "0x180E36C90")]
		internal HierarchyData GetDataAt(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0xE37D50", Offset = "0xE36750", VA = "0x180E37D50")]
		public void OnDrawerPointerEvent(HierarchyField drawer, PointerEventData eventData, bool isPointerDown)
		{
			//IL_0034: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			if (isPointerDown)
			{
				if (m_createDraggedReferenceOnHold)
				{
					currentlyPressedDrawer = drawer;
					pressedDrawerActivePointer = eventData;
					int num = 0;
					float num2 = (pressedDrawerDraggedReferenceCreateTime = Time.realtimeSinceStartup);
				}
			}
			else
			{
				int num3 = 0;
				currentlyPressedDrawer = (HierarchyField)num3;
				pressedDrawerActivePointer = (PointerEventData)num3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0xE396D0", Offset = "0xE380D0", VA = "0x180E396D0")]
		public bool Select(Transform selection, bool forceSelection = false)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0xE36BE0", Offset = "0xE355E0", VA = "0x180E36BE0")]
		public void Deselect()
		{
			//Discarded unreachable code: IL_000f
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0xE38390", Offset = "0xE36D90", VA = "0x180E38390")]
		private void OnSearchTermChanged(string search)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xE37DF0", Offset = "0xE367F0", VA = "0x180E37DF0")]
		private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0xE38100", Offset = "0xE36B00", VA = "0x180E38100")]
		private void OnSceneUnloaded(Scene arg0)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0xE36DB0", Offset = "0xE357B0", VA = "0x180E36DB0")]
		private Scene GetDontDestroyOnLoadScene()
		{
			//IL_002d: Expected O, but got I4
			//IL_002d: Expected O, but got I4
			//IL_0036: Expected O, but got I4
			int num;
			do
			{
				num = 0;
				GameObject gameObject = new GameObject();
				UnityEngine.Object.DontDestroyOnLoad(gameObject);
				int handle = gameObject.scene.m_Handle;
				UnityEngine.Object.DestroyImmediate(gameObject);
				int num2 = 0;
				int num3 = 0;
				if ((UnityEngine.Object)num != (UnityEngine.Object)num3)
				{
					UnityEngine.Object.DestroyImmediate((UnityEngine.Object)num);
				}
			}
			while (num != 0);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0xE35E60", Offset = "0xE34860", VA = "0x180E35E60")]
		public void AddToPseudoScene(string scene, Transform transform)
		{
			//Discarded unreachable code: IL_0014
			Dictionary<string, HierarchyDataRootPseudoScene> dictionary = pseudoSceneDataLookup;
			bool flag = default(bool);
			if (!flag)
			{
				HierarchyDataRootPseudoScene hierarchyDataRootPseudoScene = CreatePseudoSceneInternal(scene);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0xE35F10", Offset = "0xE34910", VA = "0x180E35F10")]
		public unsafe void AddToPseudoScene(string scene, IEnumerable<Transform> transforms)
		{
			//Discarded unreachable code: IL_0043, IL_0049
			HierarchyDataRootPseudoScene hierarchyDataRootPseudoScene = default(HierarchyDataRootPseudoScene);
			uint num2 = default(uint);
			int num;
			do
			{
				num = 0;
				if (!((Dictionary<TKey, TValue>)(object)pseudoSceneDataLookup).TryGetValue((TKey)scene, out *(TValue*)num))
				{
					hierarchyDataRootPseudoScene = CreatePseudoSceneInternal(scene);
				}
				if (hierarchyDataRootPseudoScene != null)
				{
					if (num < (int)num2)
					{
						num += num;
						if (num != (int)num2)
						{
							num++;
						}
					}
					num += num;
					num += 312;
				}
				if (hierarchyDataRootPseudoScene != null)
				{
				}
			}
			while (num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0xE393D0", Offset = "0xE37DD0", VA = "0x180E393D0")]
		public unsafe void RemoveFromPseudoScene(string scene, Transform transform, bool deleteSceneIfEmpty)
		{
			//Discarded unreachable code: IL_0026
			Dictionary<string, HierarchyDataRootPseudoScene> dictionary = pseudoSceneDataLookup;
			bool flag = default(bool);
			ulong num = default(ulong);
			if (flag && num != 0 && deleteSceneIfEmpty && ((ulong*)num)->GetTypeCode() == TypeCode.Empty)
			{
				DeletePseudoScene(scene);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0xE394A0", Offset = "0xE37EA0", VA = "0x180E394A0")]
		public unsafe void RemoveFromPseudoScene(string scene, IEnumerable<Transform> transforms, bool deleteSceneIfEmpty)
		{
			//Discarded unreachable code: IL_0042, IL_0048
			int num = 0;
			bool flag = ((Dictionary<TKey, TValue>)(object)pseudoSceneDataLookup).TryGetValue((TKey)scene, out *(TValue*)num);
			if (num == 0)
			{
				return;
			}
			if (flag)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num != (int)num2)
					{
						num++;
					}
				}
				num += num;
				num += 312;
			}
			if (flag)
			{
			}
			if (((int*)num)->GetTypeCode() != 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0xE36F60", Offset = "0xE35960", VA = "0x180E36F60")]
		private HierarchyDataRootPseudoScene GetPseudoScene(string scene, bool createIfNotExists)
		{
			Dictionary<string, HierarchyDataRootPseudoScene> dictionary = pseudoSceneDataLookup;
			bool flag = default(bool);
			if (!flag)
			{
				if (!createIfNotExists)
				{
					int num = 0;
				}
				HierarchyDataRootPseudoScene result = default(HierarchyDataRootPseudoScene);
				return result;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0xE36760", Offset = "0xE35160", VA = "0x180E36760")]
		public void CreatePseudoScene(string scene)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_0019, IL_001a
			Dictionary<string, HierarchyDataRootPseudoScene> dictionary = pseudoSceneDataLookup;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0xE36500", Offset = "0xE34F00", VA = "0x180E36500")]
		private HierarchyDataRootPseudoScene CreatePseudoSceneInternal(string scene)
		{
			//Discarded unreachable code: IL_0091, IL_00c7, IL_00cc, IL_00d0
			string a = default(string);
			do
			{
				string[] array = pseudoScenesOrder;
				int num = 0;
				if (array.Length == num)
				{
					int count = ((Dictionary<TKey, TValue>)(object)pseudoSceneDataLookup).Count;
					HierarchyDataRootPseudoScene hierarchyDataRootPseudoScene = new HierarchyDataRootPseudoScene(this, scene);
					List<HierarchyDataRoot> list = sceneData;
					Dictionary<string, HierarchyDataRootPseudoScene> dictionary = pseudoSceneDataLookup;
					int size = ((List<>)(object)list)._size;
					int count2 = ((Dictionary<TKey, TValue>)(object)dictionary).Count;
					List<HierarchyDataRoot> list2 = sceneData;
					size -= count2;
					count += size;
					((List<T>)(object)list2).Insert(count, (T)hierarchyDataRootPseudoScene);
					List<HierarchyDataRoot> list3 = searchSceneData;
					HierarchyDataRootSearch item = new HierarchyDataRootSearch(this, hierarchyDataRootPseudoScene);
					((List<T>)(object)list3).Insert(count, (T)item);
					Dictionary<string, HierarchyDataRootPseudoScene> dictionary2 = pseudoSceneDataLookup;
					throw new NullReferenceException();
				}
				while (num >= array.Length)
				{
				}
			}
			while (string.Equals(a, scene));
			string[] array2 = pseudoScenesOrder;
			Dictionary<string, HierarchyDataRootPseudoScene> dictionary3 = pseudoSceneDataLookup;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xE367D0", Offset = "0xE351D0", VA = "0x180E367D0")]
		public void DeleteAllPseudoScenes()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0xE369B0", Offset = "0xE353B0", VA = "0x180E369B0")]
		public void DeletePseudoScene(string scene)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xE37020", Offset = "0xE35A20", VA = "0x180E37020", Slot = "9")]
		RecycledListItem IListViewAdapter.CreateItem(Transform parent)
		{
			GameObject original = drawerPrefab;
			int worldPositionStays = 0;
			HierarchyField component = UnityEngine.Object.Instantiate(original, parent, (byte)worldPositionStays != 0).GetComponent<HierarchyField>();
			component.Initialize(this);
			UISkin uISkin = (component.Skin = base.m_skin);
			((List<T>)(object)drawers).Add((T)component);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xE3A430", Offset = "0xE38E30", VA = "0x180E3A430")]
		public RuntimeHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		static RuntimeHierarchy()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
