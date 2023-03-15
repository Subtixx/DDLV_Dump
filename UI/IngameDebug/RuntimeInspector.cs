using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public class RuntimeInspector : SkinnedWindow
	{
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		public enum VariableVisibility
		{
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			SerializableOnly,
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			All
		}

		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		public enum HeaderVisibility
		{
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			Collapsible,
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			AlwaysVisible,
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			Hidden
		}

		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		public delegate object InspectedObjectChangingDelegate(object previousInspectedObject, object newInspectedObject);

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		public delegate void ComponentFilterDelegate(GameObject gameObject, List<Component> components);

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private const string POOL_OBJECT_NAME = "RuntimeInspectorPool";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		[SerializeField]
		private float refreshInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private float nextRefreshTime = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		[SerializeField]
		private VariableVisibility m_exposeFields = VariableVisibility.SerializableOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		[SerializeField]
		private VariableVisibility m_exposeProperties = VariableVisibility.SerializableOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		[SerializeField]
		private bool m_arrayIndicesStartAtOne;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		[SerializeField]
		private bool m_useTitleCaseNaming;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		[SerializeField]
		private bool m_showTooltips;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		[SerializeField]
		private float m_tooltipDelay = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		[SerializeField]
		private int m_nestLimit = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		[SerializeField]
		private HeaderVisibility m_inspectedObjectHeaderVisibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		[SerializeField]
		private int poolCapacity = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private Transform poolParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		[SerializeField]
		private RuntimeHierarchy m_connectedHierarchy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		[SerializeField]
		private RuntimeInspectorSettings[] settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		[SerializeField]
		[Header("Internal Variables")]
		private ScrollRect scrollView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private RectTransform drawArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		[SerializeField]
		private Image background;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		[SerializeField]
		private Image scrollbar;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private static int aliveInspectors = (int)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private readonly Dictionary<Type, InspectorField[]> typeToDrawers = (Dictionary<Type, InspectorField[]>)(object)new Dictionary<TKey, TValue>(89);

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private readonly Dictionary<Type, InspectorField[]> typeToReferenceDrawers = (Dictionary<Type, InspectorField[]>)(object)new Dictionary<TKey, TValue>(89);

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private readonly List<InspectorField> eligibleDrawers = (List<InspectorField>)(object)new List<T>(4);

		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private static readonly Dictionary<Type, List<InspectorField>> drawersPool;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private readonly List<VariableSet> hiddenVariables = (List<VariableSet>)(object)new List<T>(32);

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private readonly List<VariableSet> exposedVariables = (List<VariableSet>)(object)new List<T>(32);

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private InspectorField currentDrawer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private bool inspectLock;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private bool isDirty;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private InspectorField hoveredDrawer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private PointerEventData hoveringPointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private float hoveredDrawerTooltipShowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private object m_inspectedObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private Canvas m_canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public InspectedObjectChangingDelegate OnInspectedObjectChanging;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private ComponentFilterDelegate m_componentFilter;

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		public VariableVisibility ExposeFields
		{
			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return m_exposeFields;
			}
			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0xE42B60", Offset = "0xE41560", VA = "0x180E42B60")]
			set
			{
				if (m_exposeFields != value)
				{
					m_exposeFields = value;
					isDirty = true;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		public VariableVisibility ExposeProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return m_exposeProperties;
			}
			[Cpp2IlInjected.Token(Token = "0x6000621")]
			[Cpp2IlInjected.Address(RVA = "0xE42B70", Offset = "0xE41570", VA = "0x180E42B70")]
			set
			{
				if (m_exposeProperties != value)
				{
					m_exposeProperties = value;
					isDirty = true;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		public bool ArrayIndicesStartAtOne
		{
			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0")]
			get
			{
				return m_arrayIndicesStartAtOne;
			}
			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0xE42B20", Offset = "0xE41520", VA = "0x180E42B20")]
			set
			{
				if (m_arrayIndicesStartAtOne != value)
				{
					m_arrayIndicesStartAtOne = value;
					isDirty = true;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		public bool UseTitleCaseNaming
		{
			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0xBA18B0", Offset = "0xBA02B0", VA = "0x180BA18B0")]
			get
			{
				return m_useTitleCaseNaming;
			}
			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0xE42CE0", Offset = "0xE416E0", VA = "0x180E42CE0")]
			set
			{
				if (m_useTitleCaseNaming != value)
				{
					m_useTitleCaseNaming = value;
					isDirty = true;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		public bool ShowTooltips
		{
			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0xE42B10", Offset = "0xE41510", VA = "0x180E42B10")]
			get
			{
				return m_showTooltips;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		public float TooltipDelay
		{
			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0x823CD0", Offset = "0x8226D0", VA = "0x180823CD0")]
			get
			{
				return m_tooltipDelay;
			}
			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x824260", Offset = "0x822C60", VA = "0x180824260")]
			set
			{
				m_tooltipDelay = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		public int NestLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return m_nestLimit;
			}
			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0xE42CD0", Offset = "0xE416D0", VA = "0x180E42CD0")]
			set
			{
				if (m_nestLimit != value)
				{
					m_nestLimit = value;
					isDirty = true;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		public HeaderVisibility InspectedObjectHeaderVisibility
		{
			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0x70CB70", Offset = "0x70B570", VA = "0x18070CB70")]
			get
			{
				return m_inspectedObjectHeaderVisibility;
			}
			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0xE42B80", Offset = "0xE41580", VA = "0x180E42B80")]
			set
			{
				//IL_0022: Expected O, but got I4
				if (m_inspectedObjectHeaderVisibility == value)
				{
					return;
				}
				m_inspectedObjectHeaderVisibility = value;
				InspectorField inspectorField = currentDrawer;
				int num = 0;
				if (!(inspectorField != (UnityEngine.Object)num))
				{
					return;
				}
				InspectorField inspectorField2 = currentDrawer;
				if ((object)inspectorField2 == null)
				{
					return;
				}
				int num2 = 0;
				if ((object)inspectorField2 != null)
				{
					int num3 = 0;
					if ((object)inspectorField2 == null)
					{
						throw new InvalidCastException();
					}
					int num4 = 0;
					if ((object)inspectorField2 == null)
					{
						throw new InvalidCastException();
					}
					HeaderVisibility inspectedObjectHeaderVisibility = m_inspectedObjectHeaderVisibility;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		public RuntimeHierarchy ConnectedHierarchy
		{
			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return m_connectedHierarchy;
			}
			[Cpp2IlInjected.Token(Token = "0x600062E")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			set
			{
				m_connectedHierarchy = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		public object InspectedObject
		{
			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x738E80", Offset = "0x737880", VA = "0x180738E80")]
			get
			{
				return m_inspectedObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		public bool IsBound
		{
			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0xE42A30", Offset = "0xE41430", VA = "0x180E42A30")]
			get
			{
				object inspectedObject = m_inspectedObject;
				if (inspectedObject != null)
				{
					int num = 0;
					if (inspectedObject != null)
					{
						return inspectedObject == null;
					}
				}
				return inspectedObject != null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		public Canvas Canvas
		{
			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x738AC0", Offset = "0x7374C0", VA = "0x180738AC0")]
			get
			{
				return m_canvas;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		public ComponentFilterDelegate ComponentFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x975F10", Offset = "0x974910", VA = "0x180975F10")]
			get
			{
				return m_componentFilter;
			}
			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0xE42B30", Offset = "0xE41530", VA = "0x180E42B30")]
			set
			{
				m_componentFilter = value;
				Refresh();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xE40370", Offset = "0xE3ED70", VA = "0x180E40370", Slot = "4")]
		protected override void Awake()
		{
			//Discarded unreachable code: IL_0146
			//IL_003b: Expected O, but got I4
			base.Awake();
			RectTransform rectTransform = (drawArea = scrollView.m_Content);
			Canvas canvas = (m_canvas = GetComponentInParent<Canvas>());
			GameObject gameObject = GameObject.Find("RuntimeInspectorPool");
			int num = 0;
			if (gameObject == (UnityEngine.Object)num)
			{
				UnityEngine.Object.DontDestroyOnLoad(new GameObject("RuntimeInspectorPool"));
			}
			Transform transform = (poolParent = gameObject.transform);
			int num2 = 0;
			int num3 = 0;
			RuntimeInspectorSettings[] array = settings;
			if (num3 < array.Length)
			{
				RuntimeInspectorSettings runtimeInspectorSettings = default(RuntimeInspectorSettings);
				VariableSet[] array2 = runtimeInspectorSettings.m_hiddenVariables;
				int num4 = 0;
				if (num4 < array2.Length)
				{
					VariableSet variableSet = array2[num4];
					if (variableSet.Init())
					{
						((List<T>)(object)hiddenVariables).Add((T)variableSet);
					}
					num4++;
				}
				RuntimeInspectorSettings[] array3 = settings;
				RuntimeInspectorSettings runtimeInspectorSettings2 = default(RuntimeInspectorSettings);
				VariableSet[] array4 = runtimeInspectorSettings2.m_exposedVariables;
				int num5 = 0;
				if (num5 < array4.Length)
				{
					VariableSet variableSet2 = array4[num5];
					if (variableSet2.Init())
					{
						((List<T>)(object)exposedVariables).Add((T)variableSet2);
					}
					num5++;
				}
				RuntimeInspectorSettings[] array5 = settings;
				num2++;
				num3 = num2;
			}
			HashSet<Transform> ignoredTransformsInHierarchy = RuntimeInspectorUtils.IgnoredTransformsInHierarchy;
			RectTransform item = drawArea;
			bool flag = ((HashSet<T>)(object)ignoredTransformsInHierarchy).Add((T)item);
			HashSet<Transform> ignoredTransformsInHierarchy2 = RuntimeInspectorUtils.IgnoredTransformsInHierarchy;
			Transform item2 = poolParent;
			bool flag2 = ((HashSet<T>)(object)ignoredTransformsInHierarchy2).Add((T)item2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0xE41A60", Offset = "0xE40460", VA = "0x180E41A60")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0067
			if ((bool)poolParent)
			{
				HashSet<Transform> ignoredTransformsInHierarchy = RuntimeInspectorUtils.IgnoredTransformsInHierarchy;
				Transform item = poolParent;
				bool flag = ((HashSet<T>)(object)ignoredTransformsInHierarchy).Remove((T)item);
				UnityEngine.Object.DestroyImmediate(poolParent.gameObject);
			}
			int num = 0;
			DebugColorPicker.DestroyInstance();
			int num2 = 0;
			ObjectReferencePicker.DestroyInstance();
			((Dictionary<TKey, TValue>)(object)drawersPool).Clear();
			HashSet<Transform> ignoredTransformsInHierarchy2 = RuntimeInspectorUtils.IgnoredTransformsInHierarchy;
			RectTransform item2 = drawArea;
			bool flag2 = ((HashSet<T>)(object)ignoredTransformsInHierarchy2).Remove((T)item2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xE41EE0", Offset = "0xE408E0", VA = "0x180E41EE0")]
		private void OnTransformParentChanged()
		{
			Canvas canvas = (m_canvas = GetComponentInParent<Canvas>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0xE42310", Offset = "0xE40D10", VA = "0x180E42310")]
		private void Start()
		{
			//Discarded unreachable code: IL_0019
			int num = 0;
			DebugColorPicker.Instance.Close();
			int num2 = 0;
			ObjectReferencePicker.Instance.Close();
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xE42540", Offset = "0xE40F40", VA = "0x180E42540", Slot = "5")]
		protected override void Update()
		{
			//IL_001f: Expected O, but got I4
			//IL_010d: Expected O, but got I4
			//IL_0115: Expected O, but got I4
			//IL_011c: Expected F4, but got I4
			base.Update();
			if (!IsBound)
			{
				InspectorField inspectorField = currentDrawer;
				int num = 0;
				if (inspectorField != (UnityEngine.Object)num)
				{
					StopInspect();
				}
				return;
			}
			int num2 = 0;
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			if (!isDirty)
			{
				if (realtimeSinceStartup <= nextRefreshTime)
				{
					goto IL_0077;
				}
				nextRefreshTime = realtimeSinceStartup;
				Refresh();
			}
			object inspectedObject = m_inspectedObject;
			StopInspect();
			Inspect(inspectedObject);
			isDirty = false;
			nextRefreshTime = realtimeSinceStartup;
			goto IL_0077;
			IL_0077:
			PointerEventData pointerEventData = hoveringPointer;
			if (pointerEventData == null)
			{
				return;
			}
			if (pointerEventData == null && pointerEventData == null)
			{
				if (realtimeSinceStartup <= hoveredDrawerTooltipShowTime)
				{
					return;
				}
				if ((bool)hoveredDrawer && hoveredDrawer.gameObject.activeSelf)
				{
					string nameRaw = hoveredDrawer.NameRaw;
					PointerEventData pointer = hoveringPointer;
					UISkin skin = base.m_skin;
					Canvas canvas = m_canvas;
					int num3 = 0;
					RuntimeInspectorUtils.ShowTooltip(nameRaw, pointer, skin, canvas);
					hoveredDrawerTooltipShowTime = float.PositiveInfinity;
					return;
				}
				int num4 = 0;
				hoveredDrawer = (InspectorField)num4;
				hoveringPointer = (PointerEventData)num4;
			}
			hoveredDrawerTooltipShowTime = 0f;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xE42250", Offset = "0xE40C50", VA = "0x180E42250")]
		public void Refresh()
		{
			//Discarded unreachable code: IL_0025
			//IL_0019: Expected O, but got I4
			if (IsBound)
			{
				InspectorField inspectorField = currentDrawer;
				int num = 0;
				if (!(inspectorField == (UnityEngine.Object)num))
				{
					InspectorField inspectorField2 = currentDrawer;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0xE42180", Offset = "0xE40B80", VA = "0x180E42180")]
		public void RefreshDelayed()
		{
			nextRefreshTime = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0xE42190", Offset = "0xE40B90", VA = "0x180E42190", Slot = "6")]
		protected override void RefreshSkin()
		{
			//Discarded unreachable code: IL_0069
			UISkin skin = base.m_skin;
			Image image = background;
			Color color = (image.color = skin.m_backgroundColor);
			UISkin skin2 = base.m_skin;
			Image image2 = scrollbar;
			Color color2 = (image2.color = skin2.m_scrollbarColor);
			if (IsBound && !isDirty)
			{
				InspectorField inspectorField = currentDrawer;
				UISkin uISkin = (inspectorField.Skin = base.m_skin);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xE40F60", Offset = "0xE3F960", VA = "0x180E40F60")]
		public void Inspect(object obj)
		{
			//Discarded unreachable code: IL_0249, IL_024f, IL_0255, IL_025b, IL_0261, IL_027f, IL_0291, IL_0297, IL_029d, IL_02a3, IL_02a9
			//IL_00c1: Expected O, but got I4
			//IL_010e: Expected O, but got I4
			//IL_010e: Expected O, but got I4
			//IL_0118: Expected O, but got I4
			//IL_014e: Expected O, but got I4
			//IL_0175: Expected O, but got I4
			string empty = default(string);
			bool flag = default(bool);
			GameObject gameObject = default(GameObject);
			while (true)
			{
				int num = 0;
				if ((inspectLock ? 1 : 0) != num)
				{
					return;
				}
				isDirty = (byte)num != 0;
				InspectedObjectChangingDelegate onInspectedObjectChanging = OnInspectedObjectChanging;
				if (onInspectedObjectChanging != null)
				{
					object inspectedObject = m_inspectedObject;
					object obj2 = onInspectedObjectChanging(inspectedObject, obj);
				}
				StopInspect();
				inspectLock = true;
				m_inspectedObject = obj;
				if (obj != null)
				{
					int num2 = 0;
					if (obj == null)
					{
					}
				}
				if (obj != null)
				{
					if (!obj.GetType().IsValueType)
					{
						if (base.gameObject.activeSelf)
						{
							Type type = obj.GetType();
							RectTransform drawerParent = drawArea;
							int drawObjectsAsFields = 0;
							InspectorField[] drawersForType = GetDrawersForType(type, (byte)drawObjectsAsFields != 0);
							if (drawersForType != null && num < drawersForType.Length)
							{
								InspectorField inspectorField = drawersForType[num];
								int num3 = 0;
								if (!inspectorField.CanBindTo(type, (MemberInfo)num3))
								{
									num++;
								}
								InspectorField drawer = drawersForType[num];
								InspectorField inspectorField2 = InstantiateDrawer(drawer, drawerParent);
								inspectorField2.Inspector = this;
								UISkin uISkin = (inspectorField2.Skin = base.m_skin);
								int num5 = (inspectorField2.Depth = 0);
							}
							int num6 = 0;
							if (!((UnityEngine.Object)num != (UnityEngine.Object)num6))
							{
								m_inspectedObject = num;
							}
							Type type2 = obj.GetType();
							empty = string.Empty;
							InspectorField.Getter getter = () => m_inspectedObject;
							InspectorField.Setter setter = delegate(object value)
							{
								m_inspectedObject = value;
								/*Error: Unexpected end of block*/;
							};
							int num7 = 0;
							string nameWithType = obj.GetNameWithType((Type)num7);
							int num8 = 0;
							int num9 = 0;
							if (num != 0)
							{
								int num10 = 0;
								if (num == 0)
								{
									throw new InvalidCastException();
								}
								int num11 = 0;
								if (num == 0)
								{
									throw new InvalidCastException();
								}
							}
							currentDrawer = (InspectorField)num;
							InspectorField inspectorField3 = currentDrawer;
							if ((object)inspectorField3 != null)
							{
								int num12 = 0;
								if ((object)inspectorField3 != null)
								{
									int num13 = 0;
									if ((object)inspectorField3 == null)
									{
										throw new InvalidCastException();
									}
									int num14 = 0;
									if ((object)inspectorField3 == null)
									{
										throw new InvalidCastException();
									}
									HeaderVisibility inspectedObjectHeaderVisibility = m_inspectedObjectHeaderVisibility;
								}
							}
							if (m_inspectedObject != null)
							{
							}
							if (flag)
							{
								object inspectedObject2 = m_inspectedObject;
								if (inspectedObject2 != null)
								{
									int num15 = 0;
									if (inspectedObject2 != null)
									{
										int num16 = 0;
										if (inspectedObject2 == null)
										{
											break;
										}
										int num17 = 0;
										if (inspectedObject2 == null)
										{
											throw new InvalidCastException();
										}
									}
								}
							}
							if (!m_connectedHierarchy)
							{
								continue;
							}
							if ((bool)gameObject)
							{
								RuntimeHierarchy connectedHierarchy = m_connectedHierarchy;
								Transform selection = gameObject.transform;
								int forceSelection = 0;
								if (connectedHierarchy.Select(selection, (byte)forceSelection != 0))
								{
									continue;
								}
							}
							m_connectedHierarchy.Deselect();
						}
						Debug.LogError("Can't inspect while Inspector is inactive!");
					}
					Debug.LogError("Can't inspect a value type!");
				}
				if (empty == null)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0xE42350", Offset = "0xE40D50", VA = "0x180E42350")]
		public void StopInspect()
		{
			//Discarded unreachable code: IL_008a
			//IL_001c: Expected O, but got I4
			//IL_0058: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			while (true)
			{
				if (inspectLock)
				{
					return;
				}
				InspectorField inspectorField = currentDrawer;
				int num = 0;
				bool flag = inspectorField != (UnityEngine.Object)num;
				int num2 = 0;
				if (flag)
				{
					InspectorField inspectorField2 = currentDrawer;
					int num3 = 0;
					if ((object)inspectorField2 == null)
					{
						continue;
					}
					int num4 = 0;
					if ((object)inspectorField2 == null)
					{
						break;
					}
					int num5 = 0;
					if ((object)inspectorField2 == null)
					{
						break;
					}
					int num6 = 0;
					currentDrawer.Unbind();
					currentDrawer = (InspectorField)num2;
				}
				m_inspectedObject = num2;
				scrollView.verticalNormalizedPosition = 1f;
				int num7 = 0;
				DebugColorPicker.Instance.Close();
				int num8 = 0;
				ObjectReferencePicker.Instance.Close();
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xE40750", Offset = "0xE3F150", VA = "0x180E40750")]
		public InspectorField CreateDrawerForType(Type type, Transform drawerParent, int depth, bool drawObjectsAsFields = true, [Optional] MemberInfo variable)
		{
			InspectorField[] array = default(InspectorField[]);
			if (array != null)
			{
				int num = 0;
				int length = array.Length;
				if (num < length)
				{
					InspectorField inspectorField = array[num];
					bool flag = default(bool);
					if (!flag)
					{
						num++;
					}
					InspectorField drawer = array[num];
					InspectorField inspectorField2 = InstantiateDrawer(drawer, drawerParent);
					inspectorField2.Inspector = this;
					UISkin uISkin = (inspectorField2.Skin = base.m_skin);
					inspectorField2.Depth = depth;
				}
			}
			int num2 = 0;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xE41800", Offset = "0xE40200", VA = "0x180E41800")]
		private InspectorField InstantiateDrawer(InspectorField drawer, Transform drawerParent)
		{
			//IL_0034: Expected I4, but got I8
			Dictionary<Type, List<InspectorField>> dictionary = drawersPool;
			Type type = drawer.GetType();
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				bool flag2 = default(bool);
				if (!flag2)
				{
				}
				int worldPositionStays = 0;
				Transform transform = default(Transform);
				transform.SetParent(drawerParent, (byte)worldPositionStays != 0);
				GameObject gameObject = default(GameObject);
				ulong num2 = default(ulong);
				gameObject.SetActive((byte)num2 != 0);
			}
			int worldPositionStays2 = 0;
			UnityEngine.Object.Instantiate(drawer, drawerParent, (byte)worldPositionStays2 != 0).Initialize();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xE40880", Offset = "0xE3F280", VA = "0x180E40880")]
		private unsafe InspectorField[] GetDrawersForType(Type type, bool drawObjectsAsFields)
		{
			//Discarded unreachable code: IL_009a
			Dictionary<Type, InspectorField[]> dictionary2 = default(Dictionary<Type, InspectorField[]>);
			InspectorField[] array2 = default(InspectorField[]);
			while (true)
			{
				int num = 0;
				if (!drawObjectsAsFields)
				{
					if (((Dictionary<TKey, TValue>)(object)typeToDrawers).TryGetValue((TKey)type, out *(TValue*)num))
					{
						break;
					}
					Dictionary<Type, InspectorField[]> dictionary = typeToDrawers;
					((List<T>)(object)eligibleDrawers).Clear();
					int length = settings.Length;
					RuntimeInspectorSettings[] array = settings;
					if (num == 0)
					{
						goto IL_0072;
					}
					RuntimeInspectorSettings runtimeInspectorSettings = array[length];
				}
				if (!typeof(UnityEngine.Object).IsAssignableFrom(type))
				{
					continue;
				}
				dictionary2 = typeToReferenceDrawers;
				if (((Dictionary<TKey, TValue>)(object)dictionary2).TryGetValue((TKey)type, out *(TValue*)num))
				{
					break;
				}
				goto IL_0072;
				IL_0072:
				if (((Dictionary<TKey, TValue>)(object)dictionary2).System_002ECollections_002EGeneric_002EIDictionary_003CTKey_002CTValue_003E_002Eget_Values() != null)
				{
					List<InspectorField> list = eligibleDrawers;
				}
				array2 = (InspectorField[])(object)((List<T>)(object)eligibleDrawers).ToArray();
				throw new NullReferenceException();
			}
			return array2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xE41F30", Offset = "0xE40930", VA = "0x180E41F30")]
		internal void PoolDrawer(InspectorField drawer)
		{
			//Discarded unreachable code: IL_0047, IL_006d
			//IL_006c: Expected O, but got I4
			Dictionary<Type, List<InspectorField>> dictionary = drawersPool;
			Type type = drawer.GetType();
			bool flag = default(bool);
			if (!flag)
			{
				List<InspectorField> list = (List<InspectorField>)(object)new List<T>(poolCapacity);
				Dictionary<Type, List<InspectorField>> dictionary2 = drawersPool;
				Type type2 = drawer.GetType();
				throw new NullReferenceException();
			}
			int num = poolCapacity;
			UnityEngine.Object.Destroy(drawer.gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xE41C60", Offset = "0xE40660", VA = "0x180E41C60")]
		internal void OnDrawerHovered(InspectorField drawer, PointerEventData pointer, bool isHovering)
		{
			//Discarded unreachable code: IL_0076
			//IL_004f: Expected O, but got I4
			//IL_0056: Expected O, but got I4
			if ((bool)RuntimeInspectorUtils.tooltipPopup && RuntimeInspectorUtils.tooltipPopup.gameObject.activeSelf)
			{
				GameObject gameObject = RuntimeInspectorUtils.tooltipPopup.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			if (!isHovering)
			{
				if (!(hoveredDrawer == drawer))
				{
					return;
				}
				int num = 0;
				hoveredDrawer = (InspectorField)num;
				hoveringPointer = (PointerEventData)num;
			}
			hoveredDrawer = drawer;
			hoveringPointer = pointer;
			int num2 = 0;
			float num3 = (hoveredDrawerTooltipShowTime = Time.realtimeSinceStartup);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xE40BC0", Offset = "0xE3F5C0", VA = "0x180E40BC0")]
		internal ExposedVariablesEnumerator GetExposedVariablesForType(Type type)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0xE42880", Offset = "0xE41280", VA = "0x180E42880")]
		public RuntimeInspector()
		{
		}//IL_0014: Expected I4, but got I8
		//IL_001d: Expected I4, but got I8
		//IL_0031: Expected I4, but got I8
		//IL_003b: Expected I4, but got I8


		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0xE427F0", Offset = "0xE411F0", VA = "0x180E427F0")]
		static RuntimeInspector()
		{
			//IL_000a: Expected I4, but got O
			/*Error: Unexpected end of block*/;
		}
	}
}
