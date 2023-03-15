using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.RewiredConsts;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta.Customization;
using Rewired;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000408")]
	[RequiredAllNotNull]
	public class DecalLayerContent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000409")]
		public delegate void SelectDecal(DecalBaseItem decal);

		[Cpp2IlInjected.Token(Token = "0x200040A")]
		public delegate void InsertDecal(DecalLayerItem decal, int index);

		[Cpp2IlInjected.Token(Token = "0x200040B")]
		public delegate void DeleteDecal(DecalLayerItem decal);

		[Cpp2IlInjected.Token(Token = "0x200040C")]
		public delegate void AddDecalHandler(bool isOn);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001419")]
		public DecalLayerItem decalPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400141A")]
		public RectTransform decalsAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400141B")]
		[SerializeField]
		private ScrollRect _scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400141C")]
		[SerializeField]
		private TextBase _tfLayerCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400141D")]
		[SerializeField]
		private AnimatedToggleButton _btnAdd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400141E")]
		[SerializeField]
		private AnimatedToggleButton _btnBaseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400141F")]
		[SerializeField]
		private Image _colorPreview;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001420")]
		[SerializeField]
		private RectTransform _gizmoGamepadShortcuts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001421")]
		[SerializeField]
		private RectTransform _openBasePickerGamepadShortcuts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001422")]
		[SerializeField]
		private RectTransform _deleteLayerGamepadShortcuts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001423")]
		[SerializeField]
		private RectTransform _cameraViewGamepadShortcuts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001424")]
		[SerializeField]
		private TextBase _motifControlGamepadShortcutsText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001425")]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int RewiredAxisX = 144;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4001426")]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int RewiredAxisY = 145;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001427")]
		[SerializeField]
		[NotNull]
		private ShortcutDefinition _shortcutHoldKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001428")]
		[SerializeField]
		private float _holdTime = 0.3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400142D")]
		public SlidingPanel Slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400142E")]
		private RectTransform _rect;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400142F")]
		private RectTransform _dragIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4001430")]
		[SerializeField]
		private RectTransform _startScrollUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001431")]
		[SerializeField]
		private RectTransform _startScrollDown;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001432")]
		private float _time;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4001433")]
		private Vector2 _startHold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001434")]
		private DecalLayerItem _current;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001435")]
		private DecalLayerItem _currentHold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001436")]
		private List<DecalLayerItem> _decals = (List<DecalLayerItem>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001437")]
		public int MaxLayerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4001438")]
		private bool isDragging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x105")]
		[Cpp2IlInjected.Token(Token = "0x4001439")]
		private bool holdToReorder = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400143A")]
		[SerializeField]
		[Nulllable]
		private FocusNavigation _focusNav;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400143B")]
		[SerializeField]
		private float _autoScrollSpeed = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x400143C")]
		[SerializeField]
		private float _minScrollDistance = 30f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400143D")]
		[Nulllable]
		public DecalLayerItem _lastFocusedElem;

		[Cpp2IlInjected.Token(Token = "0x1700043F")]
		public RectTransform GizmoGamepadShortcuts
		{
			[Cpp2IlInjected.Token(Token = "0x60019FD")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return _gizmoGamepadShortcuts;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000440")]
		public RectTransform OpenBaseColorPickerGamepadShortcuts
		{
			[Cpp2IlInjected.Token(Token = "0x60019FE")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return _openBasePickerGamepadShortcuts;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000441")]
		public RectTransform DeleteLayerGamepadShortcuts
		{
			[Cpp2IlInjected.Token(Token = "0x60019FF")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return _deleteLayerGamepadShortcuts;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000442")]
		public RectTransform CameraViewGamepadShortcuts
		{
			[Cpp2IlInjected.Token(Token = "0x6001A00")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return _cameraViewGamepadShortcuts;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000443")]
		public TextBase MotifControlGamepadShortcutsText
		{
			[Cpp2IlInjected.Token(Token = "0x6001A01")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return _motifControlGamepadShortcutsText;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000444")]
		public ToggleButton BaseColorBtn
		{
			[Cpp2IlInjected.Token(Token = "0x6001A02")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				AnimatedToggleButton btnBaseColor = _btnBaseColor;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000445")]
		public AnimatedToggleButton AddBtn
		{
			[Cpp2IlInjected.Token(Token = "0x6001A03")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return _btnAdd;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000446")]
		public DecalLayerItem Current
		{
			[Cpp2IlInjected.Token(Token = "0x6001A0C")]
			[Cpp2IlInjected.Address(RVA = "0x7393C0", Offset = "0x737DC0", VA = "0x1807393C0")]
			get
			{
				return _current;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000447")]
		public int LastLayerIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6001A0D")]
			[Cpp2IlInjected.Address(RVA = "0x12AF880", Offset = "0x12AE280", VA = "0x1812AF880")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((List<>)(object)_decals)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000448")]
		private bool isJoystickDragging
		{
			[Cpp2IlInjected.Token(Token = "0x6001A0E")]
			[Cpp2IlInjected.Address(RVA = "0x12AF8D0", Offset = "0x12AE2D0", VA = "0x1812AF8D0")]
			get
			{
				//Discarded unreachable code: IL_001d
				if (!isDragging)
				{
					int num = 0;
				}
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				return instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000449")]
		public bool IsDragging
		{
			[Cpp2IlInjected.Token(Token = "0x6001A0F")]
			[Cpp2IlInjected.Address(RVA = "0x12AF870", Offset = "0x12AE270", VA = "0x1812AF870")]
			get
			{
				return isDragging;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002F")]
		public event SelectDecal OnDecalSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6001A04")]
			[Cpp2IlInjected.Address(RVA = "0x12AF690", Offset = "0x12AE090", VA = "0x1812AF690")]
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
			[Cpp2IlInjected.Token(Token = "0x6001A05")]
			[Cpp2IlInjected.Address(RVA = "0x12AF9B0", Offset = "0x12AE3B0", VA = "0x1812AF9B0")]
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

		[Cpp2IlInjected.Token(Token = "0x14000030")]
		public event InsertDecal OnInsertDecal
		{
			[Cpp2IlInjected.Token(Token = "0x6001A06")]
			[Cpp2IlInjected.Address(RVA = "0x12AF7D0", Offset = "0x12AE1D0", VA = "0x1812AF7D0")]
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
			[Cpp2IlInjected.Token(Token = "0x6001A07")]
			[Cpp2IlInjected.Address(RVA = "0x12AFAF0", Offset = "0x12AE4F0", VA = "0x1812AFAF0")]
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

		[Cpp2IlInjected.Token(Token = "0x14000031")]
		public event DeleteDecal OnDeleteDecal
		{
			[Cpp2IlInjected.Token(Token = "0x6001A08")]
			[Cpp2IlInjected.Address(RVA = "0x12AF730", Offset = "0x12AE130", VA = "0x1812AF730")]
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
			[Cpp2IlInjected.Token(Token = "0x6001A09")]
			[Cpp2IlInjected.Address(RVA = "0x12AFA50", Offset = "0x12AE450", VA = "0x1812AFA50")]
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

		[Cpp2IlInjected.Token(Token = "0x14000032")]
		public event AddDecalHandler OnAddDecalHandler
		{
			[Cpp2IlInjected.Token(Token = "0x6001A0A")]
			[Cpp2IlInjected.Address(RVA = "0x12AF5F0", Offset = "0x12ADFF0", VA = "0x1812AF5F0")]
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
			[Cpp2IlInjected.Token(Token = "0x6001A0B")]
			[Cpp2IlInjected.Address(RVA = "0x12AF910", Offset = "0x12AE310", VA = "0x1812AF910")]
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

		[Cpp2IlInjected.Token(Token = "0x6001A10")]
		[Cpp2IlInjected.Address(RVA = "0x12AC870", Offset = "0x12AB270", VA = "0x1812AC870")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0066
			RectTransform rectTransform = (_rect = GetComponent<RectTransform>());
			AnimatedToggleButton btnAdd = _btnAdd;
			ToggleButton.OnValueChangedDelegate value = OnAddDecalHandlers;
			btnAdd.OnValueChanged += value;
			SlidingPanel slider = Slider;
			SlidingPanel.SlidingPanelEvent value2 = OnSliderShow;
			slider.OnOvershootFinished += value2;
			SlidingPanel slider2 = Slider;
			SlidingPanel.SlidingPanelEvent value3 = OnSliderClose;
			slider2.OnClose += value3;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A11")]
		[Cpp2IlInjected.Address(RVA = "0x12ACDB0", Offset = "0x12AB7B0", VA = "0x1812ACDB0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0056
			AnimatedToggleButton btnAdd = _btnAdd;
			ToggleButton.OnValueChangedDelegate value = OnAddDecalHandlers;
			btnAdd.OnValueChanged -= value;
			SlidingPanel slider = Slider;
			SlidingPanel.SlidingPanelEvent value2 = OnSliderShow;
			slider.OnOvershootFinished -= value2;
			SlidingPanel slider2 = Slider;
			SlidingPanel.SlidingPanelEvent value3 = OnSliderClose;
			slider2.OnClose -= value3;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A12")]
		[Cpp2IlInjected.Address(RVA = "0x12AE160", Offset = "0x12ACB60", VA = "0x1812AE160")]
		private unsafe void Update()
		{
			//IL_0041: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_00ca: Expected O, but got I4
			//IL_0114: Expected O, but got I4
			//IL_011c: Expected O, but got I4
			//IL_012d: Expected O, but got I4
			//IL_0162: Expected O, but got I4
			//IL_0169: Expected O, but got I4
			//IL_0176: Expected I4, but got I8
			//IL_01fc: Expected F4, but got I4
			//IL_01f7: Expected native int or pointer, but got O
			//IL_0203: Expected F4, but got I4
			//IL_023e: Expected O, but got I4
			//IL_025e: Expected O, but got I4
			//IL_029e: Expected O, but got I4
			//IL_02b4: Expected O, but got I4
			//IL_02ce: Expected O, but got I4
			//IL_033f: Expected O, but got I4
			//IL_03b7: Expected F4, but got I4
			//IL_03be: Expected F4, but got I4
			//IL_03e5: Expected O, but got I4
			//IL_04ff: Expected O, but got I4
			//IL_04ff: Expected O, but got I4
			//IL_050a: Expected O, but got I4
			//IL_0578: Expected F4, but got I4
			bool flag = default(bool);
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			bool flag2 = default(bool);
			Transform transform = default(Transform);
			float num18 = default(float);
			DecalLayerItem current3 = default(DecalLayerItem);
			UnityEngine.Vector3 vector6 = default(UnityEngine.Vector3);
			UnityEngine.Vector3 vector7 = default(UnityEngine.Vector3);
			bool flag4 = default(bool);
			UnityEngine.Vector3 vector8 = default(UnityEngine.Vector3);
			UnityEngine.Vector3 vector9 = default(UnityEngine.Vector3);
			UnityEngine.Vector3 vector10 = default(UnityEngine.Vector3);
			bool flag5 = default(bool);
			FocusNavigationElement focusNavigationElement = default(FocusNavigationElement);
			FocusNavigationElement focusNavigationElement2 = default(FocusNavigationElement);
			int num30 = default(int);
			ulong num31 = default(ulong);
			DecalLayerItem decalLayerItem3 = default(DecalLayerItem);
			int num35 = default(int);
			ulong num38 = default(ulong);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				if ((Input.GetMouseButtonUp(0) || Input.GetButtonUp(_shortcutHoldKey.Self.RewiredActionId)) && flag)
				{
					RectTransform dragIcon = _dragIcon;
					int num3 = 0;
					if (dragIcon != (UnityEngine.Object)num3)
					{
						if ((isDragging ? 1 : 0) != num2)
						{
							int num4 = 0;
							UiRoot instance = UiRoot.Instance;
							int useKeyboardAsController = 0;
							if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
							{
								FocusNavigation focusNav = _focusNav;
								int num5 = 0;
								if (focusNav != (UnityEngine.Object)num5)
								{
									ISupportsFocusNavigation focusedElement = _focusNav._focusedElement;
									int num6 = 0;
									int num7 = 0;
									RectTransform dragIcon2 = _dragIcon;
									float z = vector.z;
									float z2 = vector2.z;
									if (flag2)
									{
										DecalLayerItem component = transform.GetComponent<DecalLayerItem>();
										goto IL_00bb;
									}
								}
								goto IL_00be;
							}
						}
						goto IL_00bb;
					}
				}
				if (Input.GetMouseButtonDown(0) || Input.GetButtonDown(_shortcutHoldKey.Self.RewiredActionId))
				{
					int num8 = 0;
					Vector2 mousePosition = Input.mousePosition;
					Vector2 vector3 = (_startHold = ScreenToLocal(mousePosition));
					((Vector2*)(IntPtr)_startHold)->y = 0f;
					_time = num2;
					holdToReorder = true;
				}
				if (!Input.GetMouseButton(0) && !Input.GetButton(_shortcutHoldKey.Self.RewiredActionId))
				{
					_focusNav.IsMovementPaused = (byte)num2 != 0;
					_currentHold = (DecalLayerItem)num2;
				}
				_focusNav.IsMovementPaused = true;
				DecalLayerItem currentHold = _currentHold;
				int num9 = 0;
				if (currentHold == (UnityEngine.Object)num9)
				{
					int num10 = 0;
					UiRoot instance2 = UiRoot.Instance;
					int useKeyboardAsController2 = 0;
					if (instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0))
					{
						ISupportsFocusNavigation focusedElement2 = _focusNav._focusedElement;
						if (focusedElement2 != null)
						{
							int num11 = 0;
							if (focusedElement2 == null)
							{
							}
						}
					}
					int num12 = 0;
					DecalLayerItem decalLayerItem = (_currentHold = RaycastDecal((Vector2)num2));
				}
				int num13 = 0;
				if (currentHold == (UnityEngine.Object)num13)
				{
					DecalLayerItem current = _current;
					int num14 = 0;
					if (current == (UnityEngine.Object)num14)
					{
						float time = _time;
						int num15 = 0;
						float num16 = (_time = Time.deltaTime);
						if ((holdToReorder ? 1 : 0) != num2)
						{
							int num17 = 0;
							Vector2 mousePosition2 = Input.mousePosition;
							Vector2 vector4 = ScreenToLocal(mousePosition2);
							if (!(_minScrollDistance <= num18))
							{
								DecalLayerItem decalLayerItem2 = (_current = _currentHold);
								DecalLayerItem current2 = _current;
								int num19 = 0;
								if (current2 != (UnityEngine.Object)num19)
								{
									current3 = _current;
									RectTransform rect = _rect;
									((DecalBaseItem)current3)._decal.transform.parentInternal = rect;
									Transform transform2 = ((DecalBaseItem)current3)._decal.transform;
									RectTransform rectTransform = (_dragIcon = ((DecalBaseItem)current3)._decal.GetComponent<RectTransform>());
									ScrollRect scrollRect = _scrollRect;
									int num20 = ((scrollRect.enabled = false) ? 1 : 0);
									isDragging = true;
									_focusNav.IsPaused = true;
									_time = num2;
								}
								_time = num2;
							}
						}
						int num21 = 0;
						Vector2 mousePosition3 = Input.mousePosition;
						Vector2 vector5 = ScreenToLocal(mousePosition3);
						holdToReorder = (byte)num2 != 0;
					}
				}
				int num22 = 0;
				if (!(current3 != (UnityEngine.Object)num22))
				{
					continue;
				}
				if ((isDragging ? 1 : 0) != num2)
				{
					int num23 = 0;
					UiRoot instance3 = UiRoot.Instance;
					int useKeyboardAsController3 = 0;
					if (instance3.IsControllerConnected((byte)useKeyboardAsController3 != 0))
					{
						if ((isDragging ? 1 : 0) == num2)
						{
							break;
						}
						int num24 = 0;
						UiRoot instance4 = UiRoot.Instance;
						int useKeyboardAsController4 = 0;
						if (!instance4.IsControllerConnected((byte)useKeyboardAsController4 != 0))
						{
							break;
						}
						float axis = Input.GetAxis(RewiredAxisX);
						float time = Input.GetAxis(RewiredAxisY);
						int num25 = 0;
						MenuStack menuStack = UiRoot.Instance._menuStack;
						Transform transform3 = menuStack.transform;
						Transform transform4 = menuStack.transform;
						float z3 = vector6.z;
						float z4 = vector7.z;
						int num26 = 0;
						Transform transform5 = UiRoot.Instance._menuStack.transform;
						if (flag4)
						{
							float z5 = vector8.z;
						}
						IEnumerator enumerator = decalsAnchor.GetEnumerator();
						if (enumerator != null)
						{
							if (enumerator == null)
							{
							}
							int num27 = 0;
							if (enumerator == null)
							{
								continue;
							}
							float z6 = vector9.z;
							float z7 = vector10.z;
							while (!flag5)
							{
							}
							if (_focusNav._focusedElement != null)
							{
								int num28 = 0;
							}
							int num29 = 0;
							if ((UnityEngine.Object)num2 == (UnityEngine.Object)num29 || (UnityEngine.Object)num2 != focusNavigationElement)
							{
								_focusNav.SetFocus(focusNavigationElement2);
							}
						}
						num30 = 0;
						if ((object)focusNavigationElement2 != null)
						{
						}
						if (num31 != 0)
						{
							continue;
						}
					}
				}
				int num32 = 0;
				break;
				IL_00bb:
				int num33 = 0;
				goto IL_00be;
				IL_00be:
				int num34 = 0;
				if (decalLayerItem3 != (UnityEngine.Object)num34)
				{
					int childCount = decalsAnchor.childCount;
					Transform transform6 = decalLayerItem3.transform;
					num35 = 0;
					int siblingIndex = transform6.GetSiblingIndex();
					InsertDecal onInsertDecal = this.OnInsertDecal;
					if (onInsertDecal != null)
					{
						childCount -= siblingIndex;
						int index = childCount - 1;
						onInsertDecal((DecalLayerItem)num35, index);
					}
					_lastFocusedElem = (DecalLayerItem)num35;
				}
				RectTransform dragIcon3 = _dragIcon;
				((Transform)dragIcon3).parentInternal = (Transform)num35;
				float z8 = UnityEngine.Vector3.one.z;
				float z9 = UnityEngine.Vector3.zero.z;
				int num36 = 0;
				Vector2 vector11 = (dragIcon3.sizeDelta = Vector2.zero);
				int num37 = 0;
				_current = (DecalLayerItem)num2;
				_dragIcon = (RectTransform)num2;
				_scrollRect.enabled = (byte)num38 != 0;
				isDragging = (byte)num2 != 0;
				_focusNav.IsPaused = (byte)num2 != 0;
				int num39 = 0;
				UiRoot instance5 = UiRoot.Instance;
				int useKeyboardAsController5 = 0;
				if (instance5.IsControllerConnected((byte)useKeyboardAsController5 != 0))
				{
					FocusNavigation focusNav2 = _focusNav;
					SetFocus(focusNav2);
				}
				return;
			}
			UnityEngine.Vector3 vector12 = default(UnityEngine.Vector3);
			float z10 = vector12.z;
			UnityEngine.Vector3 vector13 = default(UnityEngine.Vector3);
			float z11 = vector13.z;
			bool flag6 = default(bool);
			float b = default(float);
			if (flag6)
			{
				b = Mathf.Min(1f, b);
			}
			UnityEngine.Vector3 vector14 = default(UnityEngine.Vector3);
			float z12 = vector14.z;
			UnityEngine.Vector3 vector15 = default(UnityEngine.Vector3);
			float z13 = vector15.z;
			bool flag7 = default(bool);
			while (!flag7)
			{
			}
			float num40 = default(float);
			b = num40;
			b = Mathf.Max(num30, b);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A13")]
		[Cpp2IlInjected.Address(RVA = "0x12AD8B0", Offset = "0x12AC2B0", VA = "0x1812AD8B0")]
		public Vector2 ScreenToLocal(Vector2 screenPos)
		{
			RectTransform rect = _rect;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A14")]
		[Cpp2IlInjected.Address(RVA = "0x12AC9D0", Offset = "0x12AB3D0", VA = "0x1812AC9D0")]
		private void Delete(DecalLayerItem decal)
		{
			//IL_0018: Expected O, but got I8
			if (_current == decal)
			{
				_current = (DecalLayerItem)0;
			}
			this.OnDeleteDecal?.Invoke(decal);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A15")]
		[Cpp2IlInjected.Address(RVA = "0x12AD940", Offset = "0x12AC340", VA = "0x1812AD940")]
		public DecalLayerItem Select(int layer)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001A16")]
		[Cpp2IlInjected.Address(RVA = "0x12ACAC0", Offset = "0x12AB4C0", VA = "0x1812ACAC0")]
		public void DeselectAll()
		{
			//Discarded unreachable code: IL_000e, IL_0014
			List<DecalLayerItem> decals = _decals;
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A17")]
		[Cpp2IlInjected.Address(RVA = "0x12ACC10", Offset = "0x12AB610", VA = "0x1812ACC10")]
		public void Deselect()
		{
			//IL_0010: Expected O, but got I4
			//IL_002c: Expected O, but got I8
			DecalLayerItem current = _current;
			int num = 0;
			if (current != (UnityEngine.Object)num)
			{
				DecalLayerItem current2 = _current;
				int selected = 0;
				current2.SetSelected((byte)selected != 0);
			}
			_current = (DecalLayerItem)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A18")]
		[Cpp2IlInjected.Address(RVA = "0x12AD580", Offset = "0x12ABF80", VA = "0x1812AD580")]
		public void SaveLayer(Design design, int layer)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001A19")]
		[Cpp2IlInjected.Address(RVA = "0x12ADB90", Offset = "0x12AC590", VA = "0x1812ADB90")]
		public void SendFocusToButtonColor(FocusDirection direction, int input, FocusNavigationElement currentElement, ISupportsFocusNavigation ret)
		{
			//Discarded unreachable code: IL_0021
			if (direction == FocusDirection.Down)
			{
				AnimatedToggleButton btnBaseColor = _btnBaseColor;
				FocusNavigation focusNav = _focusNav;
				FocusNavigationElement component = btnBaseColor.GetComponent<FocusNavigationElement>();
				focusNav.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A1A")]
		[Cpp2IlInjected.Address(RVA = "0x12ADC00", Offset = "0x12AC600", VA = "0x1812ADC00")]
		public void SendFocusToList(FocusDirection direction, int input, FocusNavigationElement currentElement, ISupportsFocusNavigation ret)
		{
			if (direction == FocusDirection.Up)
			{
				int childCount = decalsAnchor.childCount;
				FocusNavigation focusNav = _focusNav;
				if (childCount == 0)
				{
					throw new NullReferenceException();
				}
				RectTransform rectTransform = decalsAnchor;
				int index = rectTransform.childCount - 1;
				FocusNavigationElement component = rectTransform.GetChild(index).GetComponent<FocusNavigationElement>();
				focusNav.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A1B")]
		[Cpp2IlInjected.Address(RVA = "0x12AD180", Offset = "0x12ABB80", VA = "0x1812AD180")]
		public unsafe void Refresh(Design design)
		{
			//Discarded unreachable code: IL_00af, IL_00b5, IL_00bb, IL_00c7
			GameObject gameObject = default(GameObject);
			GameObject gameObject2 = default(GameObject);
			int num4 = default(int);
			GameObject gameObject3 = default(GameObject);
			int num5 = default(int);
			Transform transform = default(Transform);
			while (true)
			{
				if (decalsAnchor.childCount > 1)
				{
					Vector2 anchoredPosition = decalsAnchor.anchoredPosition;
				}
				int num = 0;
				Vector2 zero = Vector2.zero;
				IEnumerator enumerator = decalsAnchor.GetEnumerator();
				if (enumerator != null)
				{
					if (enumerator == null)
					{
					}
					int num2 = 0;
					if (enumerator == null)
					{
						break;
					}
					if (!(_btnAdd.gameObject != gameObject))
					{
						continue;
					}
					UnityEngine.Object.Destroy(gameObject2);
				}
				int num3 = 0;
				if ((object)gameObject2 != null)
				{
					((int*)null)->m_value = num3;
					bool active = (long)num4 < (long)(IntPtr)"{il2cpp field on {'constant41' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StackPointer)}, offset 0x100}";
					gameObject3.SetActive(active);
					if (num3 < num5)
					{
						num3++;
					}
					int num6 = 0;
					transform.SetAsFirstSibling();
					int num7 = 0;
					UiRoot instance = UiRoot.Instance;
					int useKeyboardAsController = 0;
					bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A1C")]
		[Cpp2IlInjected.Address(RVA = "0x12ADE00", Offset = "0x12AC800", VA = "0x1812ADE00")]
		private void SetLayersCounterText(int count)
		{
			//Discarded unreachable code: IL_0013, IL_0020, IL_0034
			TextBase tfLayerCounter = _tfLayerCounter;
			Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A1D")]
		[Cpp2IlInjected.Address(RVA = "0x12AC430", Offset = "0x12AAE30", VA = "0x1812AC430")]
		private unsafe void AddNewLayer(Decal decal, int layer)
		{
			//Discarded unreachable code: IL_0121
			//IL_0056: Expected O, but got I4
			//IL_0071: Expected O, but got I4
			int num = 0;
			DecalLayerItem original = decalPrefab;
			RectTransform parent = decalsAnchor;
			DecalLayerItem decalLayerItem = UnityEngine.Object.Instantiate(original, parent);
			Transform transform = decalLayerItem.transform;
			float z = UnityEngine.Vector3.one.z;
			decalLayerItem.transform.SetAsFirstSibling();
			bool flag = ColorUtility.TryParseHtmlString(decal.color_, out *(Color*)num);
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			DecalItemData decalData = default(DecalItemData);
			decalLayerItem.Init(decalData, (Color)num, layer);
			decalLayerItem.decal = decal;
			DecalLayerItem current = _current;
			int num2 = 0;
			if (current != (UnityEngine.Object)num2)
			{
				Decal decal2 = _current.decal;
				if (decal2 != null)
				{
					Decal decal3 = decalLayerItem.decal;
					bool flag2 = decal2.Equals(decal3);
				}
			}
			int selected = 0;
			decalLayerItem.SetSelected((byte)selected != 0);
			_lastFocusedElem = decalLayerItem;
			_current = decalLayerItem;
			DecalLayerItem.SelectDecal b = SelectionChanged;
			DecalLayerItem.SelectDecal onDecalSelected = decalLayerItem.OnDecalSelected;
			Delegate @delegate = Delegate.Combine(onDecalSelected, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onDecalSelected)
				{
				}
				DecalLayerItem.DeleteDecal b2 = Delete;
				DecalLayerItem.DeleteDecal onDecalDeleted = decalLayerItem.OnDecalDeleted;
				Delegate delegate2 = Delegate.Combine(onDecalDeleted, b2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					while ((object)delegate2 != onDecalDeleted)
					{
					}
					((List<T>)(object)_decals).Add((T)decalLayerItem);
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A1E")]
		[Cpp2IlInjected.Address(RVA = "0x12ACF40", Offset = "0x12AB940", VA = "0x1812ACF40")]
		private void OnSliderShow()
		{
			//Discarded unreachable code: IL_0023
			_btnAdd.ButtonComponent.interactable = true;
			_btnBaseColor.ButtonComponent.interactable = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A1F")]
		[Cpp2IlInjected.Address(RVA = "0x12ACEE0", Offset = "0x12AB8E0", VA = "0x1812ACEE0")]
		private void OnSliderClose()
		{
			//Discarded unreachable code: IL_002b
			Button buttonComponent = _btnAdd.ButtonComponent;
			int num = ((buttonComponent.interactable = false) ? 1 : 0);
			Button buttonComponent2 = _btnBaseColor.ButtonComponent;
			int num2 = ((buttonComponent2.interactable = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A20")]
		[Cpp2IlInjected.Address(RVA = "0x12ACFA0", Offset = "0x12AB9A0", VA = "0x1812ACFA0")]
		private DecalLayerItem RaycastDecal(Vector2 screenPos)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001A21")]
		[Cpp2IlInjected.Address(RVA = "0x12ADF40", Offset = "0x12AC940", VA = "0x1812ADF40")]
		public void ToggleDeleteLayerBtn(bool isControllerConnected)
		{
			//Discarded unreachable code: IL_0032, IL_0038, IL_003e, IL_0044
			//IL_0016: Expected O, but got I4
			bool flag = default(bool);
			CanvasGroup canvasGroup = default(CanvasGroup);
			while (true)
			{
				List<DecalLayerItem> decals = _decals;
				if (!flag)
				{
					break;
				}
				int num = 0;
				if (canvasGroup != (UnityEngine.Object)num)
				{
					CanvasGroup component = canvasGroup.GetComponent<CanvasGroup>();
					if (isControllerConnected)
					{
					}
					component.alpha = 1f;
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A22")]
		[Cpp2IlInjected.Address(RVA = "0x12ADA30", Offset = "0x12AC430", VA = "0x1812ADA30")]
		private void SelectionChanged(DecalLayerItem decal)
		{
			//IL_0010: Expected O, but got I4
			//IL_0020: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			//IL_0046: Expected O, but got I4
			RectTransform dragIcon = _dragIcon;
			int num = 0;
			if (!(dragIcon != (UnityEngine.Object)num))
			{
				int num2 = 0;
				int num3 = 0;
				_current = (DecalLayerItem)num3;
				int num4 = 0;
				bool flag = default(bool);
				if (flag)
				{
					_lastFocusedElem = (DecalLayerItem)num4;
				}
				this.OnDecalSelected?.Invoke((DecalBaseItem)num4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A23")]
		[Cpp2IlInjected.Address(RVA = "0x12ACBE0", Offset = "0x12AB5E0", VA = "0x1812ACBE0")]
		public void DeselectBaseColorToggle()
		{
			//Discarded unreachable code: IL_0011
			AnimatedToggleButton btnBaseColor = _btnBaseColor;
			int num = ((btnBaseColor.IsOn = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A24")]
		[Cpp2IlInjected.Address(RVA = "0x12ACA90", Offset = "0x12AB490", VA = "0x1812ACA90")]
		public void DeselectAddLayerToggle()
		{
			//Discarded unreachable code: IL_0011
			AnimatedToggleButton btnAdd = _btnAdd;
			int num = ((btnAdd.IsOn = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A25")]
		[Cpp2IlInjected.Address(RVA = "0x12AE120", Offset = "0x12ACB20", VA = "0x1812AE120")]
		public void UpdateColorPreview(Color color)
		{
			//Discarded unreachable code: IL_0008
			Image colorPreview = _colorPreview;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A26")]
		[Cpp2IlInjected.Address(RVA = "0x12ACCB0", Offset = "0x12AB6B0", VA = "0x1812ACCB0")]
		private DecalLayerItem GetFocusedLayer()
		{
			ISupportsFocusNavigation focusedElement = _focusNav._focusedElement;
			if (focusedElement != null)
			{
				int num = 0;
				DecalLayerItem result = default(DecalLayerItem);
				if (focusedElement != null)
				{
					return result;
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A27")]
		[Cpp2IlInjected.Address(RVA = "0x12ADCC0", Offset = "0x12AC6C0", VA = "0x1812ADCC0")]
		internal void SetFocus(FocusNavigation focusNavigation)
		{
			//IL_001e: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			if (decalsAnchor.childCount <= 0)
			{
				return;
			}
			DecalLayerItem lastFocusedElem = _lastFocusedElem;
			int num = 0;
			if (!(lastFocusedElem != (UnityEngine.Object)num))
			{
				DecalLayerItem current = _current;
				int num2 = 0;
				if (!(current != (UnityEngine.Object)num2))
				{
					RectTransform rectTransform = decalsAnchor;
					int index = 0;
					FocusNavigationElement component = rectTransform.GetChild(index).GetComponent<FocusNavigationElement>();
					focusNavigation.SetFocus(component);
					return;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A28")]
		[Cpp2IlInjected.Address(RVA = "0x12ACD60", Offset = "0x12AB760", VA = "0x1812ACD60")]
		private void OnAddDecalHandlers(bool isOn)
		{
			this.OnAddDecalHandler?.Invoke(isOn);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A29")]
		[Cpp2IlInjected.Address(RVA = "0x12AF540", Offset = "0x12ADF40", VA = "0x1812AF540")]
		public DecalLayerContent()
		{
		}//IL_000d: Expected I4, but got I8
		//IL_001a: Expected I4, but got I8

	}
}
