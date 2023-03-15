using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Assets.Scripts.Gestures;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Gestures;
using Mdl.InputSystem;
using Mdl.Navigation;
using Mdl.Navigation.ControlSchemes;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Grids;
using Meta.Online;
using UnityEngine;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x200045F")]
	public abstract class GridObjectGizmoSystem : Mdl.Systems.System, IVillageObjectLimitProvider
	{
		[Cpp2IlInjected.Token(Token = "0x2000460")]
		public delegate void SelectedObjectChangedDelegate(GridObjectScript previous, GridObjectScript current);

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001BB9")]
		[SerializeField]
		private PlayerNavigationConfig _playerConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001BBA")]
		[SerializeField]
		protected CameraNavigationConfig _cameraConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001BBB")]
		[SerializeField]
		private RectTransform _inputZone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001BBC")]
		[SerializeField]
		private GameObject _gridAreaRendererPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001BBD")]
		[SerializeField]
		private Color _gridAreaValidColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001BBE")]
		[SerializeField]
		private Color _gridAreaClearableColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001BBF")]
		[SerializeField]
		private Color _gridAreaConflictColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4001BC0")]
		[SerializeField]
		private GameObject _objectLimitPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4001BC1")]
		[SerializeField]
		private float _minimumGroundMovementToStartMovingObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4001BC2")]
		private GridObjectScript _selectedGridObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4001BC3")]
		protected GridScript _initialSelectedGridObjectGridScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001BC4")]
		protected GridObject _initialSelectedGridObjectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001BC5")]
		protected GridObject _mainGridTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001BC6")]
		private GridAreaRenderer gridAreaRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001BC7")]
		private bool previousDitherSetting;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4001BC8")]
		public float _objectWithConflictDitheringValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001BC9")]
		public AK.Wwise.Event _sfxPlaceItemEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001BCA")]
		public AK.Wwise.Event _sfxSelectItemEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001BCB")]
		public AK.Wwise.Event _sfxRotateItemEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001BCC")]
		public AK.Wwise.Event _sfxRemoveItemEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001BCD")]
		public AK.Wwise.Event _sfxCancelItemEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001BCE")]
		private InputDetectionHelper _inputDetection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001BCF")]
		private ComponentCache<Renderer> selectedObjectDitheredRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4001BD1")]
		private IGridMovementRestriction _currentGridMovementRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x141")]
		[Cpp2IlInjected.Token(Token = "0x4001BD4")]
		private bool isUsingMouse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x4001BD5")]
		private Vector2 previousMousePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4001BDD")]
		protected GridScript[] allGridScripts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4001BDE")]
		protected List<SubGridScript> subGridScripts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4001BDF")]
		private Vector3 metaGridOrigin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x4001BE0")]
		private GridPosition _metaGridSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4001BE1")]
		private Dictionary<GridPosition, List<GridScript>> _availableGridsForPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4001BE2")]
		private (RectInt rect, GridScript grid)[] mainGridScripts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4001BE3")]
		private bool hasWallGrids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4001BE4")]
		private IGridMovementRestriction[] gridMovementRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4001BE5")]
		protected FreeCameraControl cameraNav;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4001BE6")]
		private MoveGesture move;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4001BE7")]
		private TapGesture leftClickTapGesture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4001BE8")]
		private TapGesture rightClickTapGesture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4001BE9")]
		protected InputAction inputActionInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4001BEA")]
		protected InputAction inputCursorMove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4001BEB")]
		protected InputAction inputCursorInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4001BEC")]
		protected InputAction inputActionRotateClockwise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4001BED")]
		protected InputAction inputActionRotateCounterClockwise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4001BEE")]
		protected InputAction inputActionRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4001BEF")]
		protected InputAction inputCameraTriggerPanButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4001BF0")]
		protected InputAction inputCameraAutoPan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4001BF1")]
		protected InputAction inputCameraToggle2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4001BF2")]
		protected InputAction inputCameraPan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4001BF3")]
		protected InputAction inputCameraRotate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4001BF4")]
		protected InputAction inputCameraZoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4001BF5")]
		protected InputAction inputCameraTriggerPan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4001BF6")]
		protected InputAction inputCursorPrecisionMove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4001BF7")]
		private bool isMovingGestureActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4001BF8")]
		private GridObjectScript movedObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4001BF9")]
		private bool movedCursorDuringMovement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
		[Cpp2IlInjected.Token(Token = "0x4001BFA")]
		private Vector3 targetStartTouchPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4001BFB")]
		private Vector3 targetStartPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4001BFC")]
		protected VillageObjectLimit currentAmounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4001BFD")]
		protected VillageObjectLimitData currentLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4001BFE")]
		private Task cameraTransitionTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4001BFF")]
		[SerializeField]
		protected GridEditModeInputConfig InputConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4001C00")]
		protected InputActionModifier_ScaleExternalCurve cursorSpeedModifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4001C01")]
		private readonly List<Task> blockingTasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4001C02")]
		private GameObject _hoveredGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4001C04")]
		private List<GridPosition> validPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4001C05")]
		private Dictionary<(GridScript, GridPosition, GridOrientation), GridPosition> invalidPositionResultCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4001C06")]
		private Dictionary<(GridScript, GridPosition, GridOrientation), bool> validPositionCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x4001C07")]
		private Task<GridPosition> findValidPositionTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4001C08")]
		private CancellationTokenSource findValidPositionCTS;

		[Cpp2IlInjected.Token(Token = "0x4001C09")]
		private static int fadeKey = Shader.PropertyToID("fade");

		[Cpp2IlInjected.Token(Token = "0x4001C0A")]
		private static int wallObjectKey = Shader.PropertyToID("wallObject");

		[Cpp2IlInjected.Token(Token = "0x17000259")]
		public Vector2 InputZonePosition
		{
			[Cpp2IlInjected.Token(Token = "0x60012C0")]
			[Cpp2IlInjected.Address(RVA = "0xD07000", Offset = "0xD05A00", VA = "0x180D07000")]
			get
			{
				RectTransform inputZone = _inputZone;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025A")]
		public GridObjectScript SelectedGridObject
		{
			[Cpp2IlInjected.Token(Token = "0x60012C1")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC30", Offset = "0x7D9630", VA = "0x1807DAC30")]
			get
			{
				return _selectedGridObject;
			}
			[Cpp2IlInjected.Token(Token = "0x60012C2")]
			[Cpp2IlInjected.Address(RVA = "0xD07800", Offset = "0xD06200", VA = "0x180D07800")]
			protected set
			{
				//Discarded unreachable code: IL_01f3
				//IL_003d: Expected O, but got I4
				//IL_004d: Expected O, but got I4
				//IL_0082: Expected O, but got I4
				//IL_009a: Expected O, but got I4
				//IL_00a1: Expected O, but got I4
				//IL_00ab: Expected O, but got I4
				//IL_00b8: Expected O, but got I4
				//IL_00c2: Expected O, but got I4
				//IL_00f3: Expected O, but got I4
				//IL_010f: Expected O, but got I4
				//IL_0176: Expected O, but got I4
				//IL_01f2: Expected O, but got I4
				bool flag = default(bool);
				if (!flag)
				{
					return;
				}
				int num = 0;
				int num2 = 0;
				bool flag2 = default(bool);
				if (flag2)
				{
					GridObjectGizmoSystem.DisableConflictDithering(ComponentCache<ComponentType>.op_Implicit((ComponentCache<>)(object)selectedObjectDitheredRenderers));
					((ComponentCache<ComponentType>)(object)selectedObjectDitheredRenderers)?.Clear();
					selectedObjectDitheredRenderers = (ComponentCache<Renderer>)num2;
					bool flag3 = previousDitherSetting;
					selectedObjectDitheredRenderers = (ComponentCache<Renderer>)flag3;
					Transform transform = this.gridAreaRenderer.transform;
					Transform transform3 = (transform.parent = base.transform);
					UnityEngine.Object.Destroy(this.gridAreaRenderer.gameObject);
					this.gridAreaRenderer = (GridAreaRenderer)num2;
					if (UseEditGrid)
					{
						int num3 = 0;
						bool flag4 = default(bool);
						if (!flag4)
						{
						}
					}
					_initialSelectedGridObjectTransform = (GridObject)num2;
					_initialSelectedGridObjectGridScript = (GridScript)num2;
					int num4 = 0;
					_mainGridTransform = (GridObject)num2;
					if (movedObject == (UnityEngine.Object)num4)
					{
						movedObject = (GridObjectScript)num2;
						EventHandler selectedObjectMoveEndedEvent = this.SelectedObjectMoveEndedEvent;
						isMovingGestureActive = (byte)num2 != 0;
						if (selectedObjectMoveEndedEvent == null)
						{
						}
					}
				}
				_selectedGridObject = value;
				this.SelectedObjectChangedEvent?.Invoke(value, (GridObjectScript)num);
				bool flag5 = default(bool);
				if (!flag5)
				{
					return;
				}
				previousDitherSetting = flag5;
				int num5 = 0;
				GridTilesetObject gridTilesetObject = default(GridTilesetObject);
				if (gridTilesetObject == (UnityEngine.Object)num5)
				{
					ComponentCache<Renderer> componentCache = (selectedObjectDitheredRenderers = (ComponentCache<Renderer>)(object)new ComponentCache<ComponentType>(gridTilesetObject));
					((ComponentCache<ComponentType>)(object)selectedObjectDitheredRenderers).PreCache();
				}
				Transform parent = default(Transform);
				Collider _003CCollider_003Ek__BackingField = (this.gridAreaRenderer = UnityEngine.Object.Instantiate(_gridAreaRendererPrefab, parent).GetComponent<GridAreaRenderer>()).Collider;
				GridAreaRenderer gridAreaRenderer = this.gridAreaRenderer;
				UpdateSelectedObjectConflictedLayers();
				int num8 = default(int);
				if (UseEditGrid)
				{
					int num6 = 0;
					if (gridAreaRenderer != (UnityEngine.Object)num6)
					{
						int num7 = 0;
						num8 = 0;
					}
				}
				GridObject gridObject = default(GridObject);
				_initialSelectedGridObjectTransform = gridObject;
				GridArea gridArea = (GridArea)(_initialSelectedGridObjectGridScript = (GridScript)gridObject.gridArea);
				GridObject.SourceOneofCase sourceCase_ = gridObject.sourceCase_;
				GridObject mainGridTransform = default(GridObject);
				_mainGridTransform = mainGridTransform;
				if (num8 != 0)
				{
					int num9 = 0;
					if (num8 != 0)
					{
						GridObject mainGridTransform2 = _mainGridTransform;
						int num10 = 0;
						int num11 = 0;
						int num12 = 0;
						GridOrientation orientation_ = default(GridOrientation);
						mainGridTransform2.orientation_ = orientation_;
						GridObject mainGridTransform3 = _mainGridTransform;
						int num13 = 0;
						int num14 = 0;
						GridPosition position = default(GridPosition);
						mainGridTransform3.Position = position;
					}
				}
				int num15 = 0;
				HoveredObject = (GameObject)num15;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025B")]
		public GameObject SelectedGameObject
		{
			[Cpp2IlInjected.Token(Token = "0x60012C4")]
			[Cpp2IlInjected.Address(RVA = "0xD070A0", Offset = "0xD05AA0", VA = "0x180D070A0")]
			get
			{
				GridObjectScript selectedGridObject = _selectedGridObject;
				if ((object)selectedGridObject != null)
				{
					return selectedGridObject.gameObject;
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025C")]
		public abstract bool UseEditGrid
		{
			[Cpp2IlInjected.Token(Token = "0x60012C7")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700025D")]
		public abstract bool CanManuallySelect
		{
			[Cpp2IlInjected.Token(Token = "0x60012C8")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700025E")]
		public bool HasMovementRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x60012CD")]
			[Cpp2IlInjected.Address(RVA = "0xD06FC0", Offset = "0xD059C0", VA = "0x180D06FC0")]
			get
			{
				IGridMovementRestriction[] array = gridMovementRestrictions;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025F")]
		public IGridMovementRestriction CurrentMovementRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x60012CE")]
			[Cpp2IlInjected.Address(RVA = "0x9762E0", Offset = "0x974CE0", VA = "0x1809762E0")]
			get
			{
				return _currentGridMovementRestriction;
			}
			[Cpp2IlInjected.Token(Token = "0x60012CF")]
			[Cpp2IlInjected.Address(RVA = "0xD07460", Offset = "0xD05E60", VA = "0x180D07460")]
			protected set
			{
				IGridMovementRestriction currentGridMovementRestriction = _currentGridMovementRestriction;
				if (currentGridMovementRestriction != value)
				{
					if (currentGridMovementRestriction != null)
					{
					}
					_currentGridMovementRestriction = value;
					if (_currentGridMovementRestriction != null)
					{
					}
					if (this.CurrentMovementRestrictionChangedEvent == null)
					{
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000260")]
		internal ICustomMoveHandler CustomMoveHandler
		{
			[Cpp2IlInjected.Token(Token = "0x60012D0")]
			[Cpp2IlInjected.Address(RVA = "0x975DD0", Offset = "0x9747D0", VA = "0x180975DD0")]
			[CompilerGenerated]
			get
			{
				return _003CCustomMoveHandler_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60012D1")]
			[Cpp2IlInjected.Address(RVA = "0x9765A0", Offset = "0x974FA0", VA = "0x1809765A0")]
			[CompilerGenerated]
			set
			{
				_003CCustomMoveHandler_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000261")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x140"), Cpp2IlInjected.Token(Token = "0x4001BD3")]
		protected bool CameraOverriden
		{
			[Cpp2IlInjected.Token(Token = "0x60012D2")]
			[Cpp2IlInjected.Address(RVA = "0xD06C80", Offset = "0xD05680", VA = "0x180D06C80")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60012D3")]
			[Cpp2IlInjected.Address(RVA = "0xD07450", Offset = "0xD05E50", VA = "0x180D07450")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000262")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14C"), Cpp2IlInjected.Token(Token = "0x4001BD6")]
		public bool UpdateCursor
		{
			[Cpp2IlInjected.Token(Token = "0x60012D4")]
			[Cpp2IlInjected.Address(RVA = "0xA5C3C0", Offset = "0xA5ADC0", VA = "0x180A5C3C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60012D5")]
			[Cpp2IlInjected.Address(RVA = "0xA5C400", Offset = "0xA5AE00", VA = "0x180A5C400")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000263")]
		public Vector2 CursorPosition
		{
			[Cpp2IlInjected.Token(Token = "0x60012D6")]
			[Cpp2IlInjected.Address(RVA = "0xD06F40", Offset = "0xD05940", VA = "0x180D06F40")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60012D7")]
			[Cpp2IlInjected.Address(RVA = "0xD07560", Offset = "0xD05F60", VA = "0x180D07560")]
			[CompilerGenerated]
			private set
			{
				_003CCursorPosition_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000264")]
		public Vector2 VisualCursorPosition
		{
			[Cpp2IlInjected.Token(Token = "0x60012D8")]
			[Cpp2IlInjected.Address(RVA = "0xD07100", Offset = "0xD05B00", VA = "0x180D07100")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60012D9")]
			[Cpp2IlInjected.Address(RVA = "0xD08110", Offset = "0xD06B10", VA = "0x180D08110")]
			[CompilerGenerated]
			private set
			{
				_003CVisualCursorPosition_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000265")]
		public IEnumerable<IGridMovementRestriction> GridMovementRestrictions
		{
			[Cpp2IlInjected.Token(Token = "0x60012E2")]
			[Cpp2IlInjected.Address(RVA = "0xD06F60", Offset = "0xD05960", VA = "0x180D06F60")]
			get
			{
				IGridMovementRestriction[] array = gridMovementRestrictions;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000266")]
		public bool IsMovingSelectedObject
		{
			[Cpp2IlInjected.Token(Token = "0x60012E3")]
			[Cpp2IlInjected.Address(RVA = "0xD07040", Offset = "0xD05A40", VA = "0x180D07040")]
			get
			{
				//IL_0010: Expected O, but got I4
				GridObjectScript gridObjectScript = movedObject;
				int num = 0;
				return gridObjectScript != (UnityEngine.Object)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000267")]
		protected virtual Transform StartCameraTransform
		{
			[Cpp2IlInjected.Token(Token = "0x60012E4")]
			[Cpp2IlInjected.Address(RVA = "0xD070C0", Offset = "0xD05AC0", VA = "0x180D070C0", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_000c
				return avatar.gridEditStartCamera;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000268")]
		protected virtual Transform StartFarCameraTransform
		{
			[Cpp2IlInjected.Token(Token = "0x60012E5")]
			[Cpp2IlInjected.Address(RVA = "0xD070E0", Offset = "0xD05AE0", VA = "0x180D070E0", Slot = "17")]
			get
			{
				//Discarded unreachable code: IL_000c
				return avatar.gridEditLargeStartCamera;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000269")]
		protected bool HasBlockingTasks
		{
			[Cpp2IlInjected.Token(Token = "0x60012E7")]
			[Cpp2IlInjected.Address(RVA = "0xD06F70", Offset = "0xD05970", VA = "0x180D06F70")]
			get
			{
				//Discarded unreachable code: IL_0009
				List<Task> list = blockingTasks;
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026A")]
		protected bool ClickInput
		{
			[Cpp2IlInjected.Token(Token = "0x60012E8")]
			[Cpp2IlInjected.Address(RVA = "0xD06EF0", Offset = "0xD058F0", VA = "0x180D06EF0")]
			get
			{
				//Discarded unreachable code: IL_002a
				if (leftClickTapGesture.IsTrue)
				{
					return true;
				}
				if (!inputActionInteract.IsTriggered)
				{
					int num = 0;
				}
				return !AllowNonTouchControls;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026B")]
		public GameObject HoveredObject
		{
			[Cpp2IlInjected.Token(Token = "0x60012ED")]
			[Cpp2IlInjected.Address(RVA = "0xD06FF0", Offset = "0xD059F0", VA = "0x180D06FF0")]
			get
			{
				return _hoveredGameObject;
			}
			[Cpp2IlInjected.Token(Token = "0x60012EE")]
			[Cpp2IlInjected.Address(RVA = "0xD07570", Offset = "0xD05F70", VA = "0x180D07570")]
			private set
			{
				//Discarded unreachable code: IL_005f
				//IL_0037: Expected O, but got I4
				int num = 0;
				bool flag = default(bool);
				if (!flag)
				{
					return;
				}
				bool flag2 = default(bool);
				if (flag2)
				{
					EventHandler value2 = HoveredObjectDestroyed;
					DestroyEventProvider destroyEventProvider = default(DestroyEventProvider);
					destroyEventProvider.DestroyEvent -= value2;
					bool flag3 = default(bool);
					if (!flag3)
					{
					}
				}
				_hoveredGameObject = value;
				int num2 = 0;
				if (value != (UnityEngine.Object)num2)
				{
					DestroyEventProvider orAddComponent = value.GetOrAddComponent<DestroyEventProvider>();
					EventHandler value3 = HoveredObjectDestroyed;
					orAddComponent.DestroyEvent += value3;
					bool flag4 = default(bool);
					if (!flag4)
					{
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x2C0"), Cpp2IlInjected.Token(Token = "0x4001C03")]
		public bool AllowNonTouchControls
		{
			[Cpp2IlInjected.Token(Token = "0x60012F1")]
			[Cpp2IlInjected.Address(RVA = "0xD06C70", Offset = "0xD05670", VA = "0x180D06C70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60012F2")]
			[Cpp2IlInjected.Address(RVA = "0xD07440", Offset = "0xD05E40", VA = "0x180D07440")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700026D")]
		public abstract bool CanDuplicateSelectedObject
		{
			[Cpp2IlInjected.Token(Token = "0x60012F6")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700026E")]
		public abstract bool CanRemoveSelectedObject
		{
			[Cpp2IlInjected.Token(Token = "0x60012F9")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700026F")]
		public virtual bool CanDeselectSelectedObject
		{
			[Cpp2IlInjected.Token(Token = "0x6001300")]
			[Cpp2IlInjected.Address(RVA = "0xD06C90", Offset = "0xD05690", VA = "0x180D06C90", Slot = "24")]
			get
			{
				//IL_0010: Expected O, but got I4
				GridObjectScript selectedGridObject = _selectedGridObject;
				int num = 0;
				bool flag = selectedGridObject != (UnityEngine.Object)num;
				if (!flag)
				{
					return flag;
				}
				GridObject _003CGridObject_003Ek__BackingField = _selectedGridObject.GridObject;
				int itemID = _selectedGridObject.GridObject.ItemID;
				GridObjectScript selectedGridObject2 = _selectedGridObject;
				bool flag2 = default(bool);
				GridScript _003CGridScript_003Ek__BackingField = default(GridScript);
				GridObject _003CGridObject_003Ek__BackingField2 = default(GridObject);
				if (!flag2)
				{
					_003CGridScript_003Ek__BackingField = selectedGridObject2.GridScript;
					GridPosition position = selectedGridObject2.GridObject.Position;
					_003CGridObject_003Ek__BackingField2 = _selectedGridObject.GridObject;
					GridOrientation orientation_ = _003CGridObject_003Ek__BackingField2.orientation_;
					bool useEditGrid = UseEditGrid;
					int num2 = 0;
					bool result = default(bool);
					return result;
				}
				HashSet<uint> gridObjects = _003CGridScript_003Ek__BackingField.gridObjects;
				IGrid _003CGrid_003Ek__BackingField = _003CGridScript_003Ek__BackingField.Grid;
				GridObject.SourceOneofCase sourceCase_ = _003CGridObject_003Ek__BackingField2.sourceCase_;
				int num3 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000270")]
		protected abstract bool CanMoveSelectedObject
		{
			[Cpp2IlInjected.Token(Token = "0x600130B")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000271")]
		protected virtual bool CanTapToMoveSelectedObject
		{
			[Cpp2IlInjected.Token(Token = "0x600130C")]
			[Cpp2IlInjected.Address(RVA = "0xD06ED0", Offset = "0xD058D0", VA = "0x180D06ED0", Slot = "27")]
			get
			{
				return UseEditGrid;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event SelectedObjectChangedDelegate SelectedObjectChangedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60012C5")]
			[Cpp2IlInjected.Address(RVA = "0xD069F0", Offset = "0xD053F0", VA = "0x180D069F0")]
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
			[Cpp2IlInjected.Token(Token = "0x60012C6")]
			[Cpp2IlInjected.Address(RVA = "0xD071C0", Offset = "0xD05BC0", VA = "0x180D071C0")]
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

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event EventHandler CurrentMovementRestrictionChangedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60012DA")]
			[Cpp2IlInjected.Address(RVA = "0xD06950", Offset = "0xD05350", VA = "0x180D06950")]
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
			[Cpp2IlInjected.Token(Token = "0x60012DB")]
			[Cpp2IlInjected.Address(RVA = "0xD07120", Offset = "0xD05B20", VA = "0x180D07120")]
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

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event VillageObjectLimitChangedDelegate VillageObjectLimitChangedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60012DC")]
			[Cpp2IlInjected.Address(RVA = "0xD06BD0", Offset = "0xD055D0", VA = "0x180D06BD0", Slot = "8")]
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
			[Cpp2IlInjected.Token(Token = "0x60012DD")]
			[Cpp2IlInjected.Address(RVA = "0xD073A0", Offset = "0xD05DA0", VA = "0x180D073A0", Slot = "9")]
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

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event EventHandler SelectedObjectMoveStartedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60012DE")]
			[Cpp2IlInjected.Address(RVA = "0xD06B30", Offset = "0xD05530", VA = "0x180D06B30")]
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
			[Cpp2IlInjected.Token(Token = "0x60012DF")]
			[Cpp2IlInjected.Address(RVA = "0xD07300", Offset = "0xD05D00", VA = "0x180D07300")]
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

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event EventHandler SelectedObjectMoveEndedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60012E0")]
			[Cpp2IlInjected.Address(RVA = "0xD06A90", Offset = "0xD05490", VA = "0x180D06A90")]
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
			[Cpp2IlInjected.Token(Token = "0x60012E1")]
			[Cpp2IlInjected.Address(RVA = "0xD07260", Offset = "0xD05C60", VA = "0x180D07260")]
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

		[Cpp2IlInjected.Token(Token = "0x60012C3")]
		[Cpp2IlInjected.Address(RVA = "0xD064E0", Offset = "0xD04EE0", VA = "0x180D064E0")]
		internal void UpdatedSelectedGridObject()
		{
			((ComponentCache<ComponentType>)(object)selectedObjectDitheredRenderers)?.Dirty();
		}

		[Cpp2IlInjected.Token(Token = "0x60012C9")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract bool CanClear(Item item);

		[Cpp2IlInjected.Token(Token = "0x60012CA")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract bool CanSelectObject(GridObjectScript gridObjectScript);

		[Cpp2IlInjected.Token(Token = "0x60012CB")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract bool CanIgnoreObject(GridObjectScript gridObjectScript);

		[Cpp2IlInjected.Token(Token = "0x60012CC")]
		[Cpp2IlInjected.Address(Slot = "15")]
		public abstract bool ShouldStartAutomaticMovement();

		[Cpp2IlInjected.Token(Token = "0x60012E6")]
		[Cpp2IlInjected.Address(RVA = "0xCF99F0", Offset = "0xCF83F0", VA = "0x180CF99F0")]
		protected void AddBlockingTask(Task task)
		{
			//Discarded unreachable code: IL_000d
			((List<T>)(object)blockingTasks).Add((T)task);
		}

		[Cpp2IlInjected.Token(Token = "0x60012E9")]
		[Cpp2IlInjected.Address(RVA = "0xD00520", Offset = "0xCFEF20", VA = "0x180D00520", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			//IL_0019: Expected I4, but got I8
			//IL_0019: Expected O, but got I4
			//IL_0064: Expected O, but got I4
			//IL_0086: Expected O, but got I4
			//IL_00a8: Expected O, but got I4
			//IL_00c3: Expected F4, but got I4
			//IL_00e9: Expected O, but got I4
			//IL_0153: Expected O, but got I4
			//IL_01d3: Expected O, but got I4
			//IL_01f5: Expected O, but got I4
			//IL_0217: Expected O, but got I4
			//IL_0239: Expected O, but got I4
			//IL_025f: Expected O, but got I4
			//IL_02a6: Expected O, but got I4
			//IL_0311: Expected O, but got I4
			//IL_0370: Expected O, but got I4
			//IL_03b4: Expected O, but got I4
			//IL_03b4: Expected O, but got I4
			//IL_0475: Expected O, but got I4
			//IL_04b9: Expected O, but got I4
			//IL_04fc: Expected I4, but got O
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			ulong num6 = default(ulong);
			int automaticRotation = default(int);
			int num5 = default(int);
			MoveGesture moveGesture = new MoveGesture(_inputZone, (Camera)num5, (byte)automaticRotation != 0, (byte)num6 != 0);
			automaticRotation = 0;
			num5 = 0;
			move = moveGesture;
			MoveGesture moveGesture2 = move;
			float num7 = (moveGesture2.Friction = _cameraConfig.moveFriction);
			GridEditModeInputConfig inputConfig = InputConfig;
			InputTriggerReleased trigger = new InputTriggerReleased();
			int num8 = default(int);
			InputActionBool inputActionBool = new InputActionBool("Interact", trigger, (InputProvider)num8);
			num8 = 0;
			inputActionInteract = inputActionBool;
			InputTriggerDown trigger2 = new InputTriggerDown();
			int num9 = default(int);
			InputActionBool inputActionBool2 = new InputActionBool("EditModeCam_Toggle1", trigger2, (InputProvider)num9);
			num9 = 0;
			inputCameraTriggerPanButton = inputActionBool2;
			InputTriggerDown trigger3 = new InputTriggerDown();
			int num10 = default(int);
			InputActionBool inputActionBool3 = new InputActionBool("EditModeCam_Toggle2", trigger3, (InputProvider)num10);
			num10 = 0;
			inputCameraToggle2 = inputActionBool3;
			int num11 = default(int);
			InputActionModifier_ScaleExternalCurve inputActionModifier_ScaleExternalCurve = new InputActionModifier_ScaleExternalCurve(inputConfig.CursorPrecisionDistanceMultiplier, num11);
			num11 = 0;
			cursorSpeedModifier = inputActionModifier_ScaleExternalCurve;
			InputTriggerDown trigger4 = new InputTriggerDown();
			InputActionVector2D inputActionVector2D = (InputActionVector2D)(inputCursorPrecisionMove = new InputActionVector2D("EditModeCam_PrecisionPanHorizontal", "EditModeCam_PrecisionPanVertical", trigger4, (InputProvider)num2));
			InputAction inputAction = inputCursorPrecisionMove;
			float cursorPrecisionAcceleration = inputConfig.CursorPrecisionAcceleration;
			float cursorPrecisionDeceleration = inputConfig.CursorPrecisionDeceleration;
			InputActionModifier_Accel modifier = new InputActionModifier_Accel(cursorPrecisionAcceleration, cursorPrecisionDeceleration);
			inputAction.AddModifier(modifier);
			InputAction inputAction2 = inputCursorPrecisionMove;
			InputActionModifier_ScaleExternalCurve modifier2 = cursorSpeedModifier;
			inputAction2.AddModifier(modifier2);
			InputTriggerDown trigger5 = new InputTriggerDown();
			InputActionVector2D inputActionVector2D2 = (InputActionVector2D)(inputCursorMove = new InputActionVector2D("CursorHorizontal", "CursorVertical", trigger5, (InputProvider)num2));
			InputAction inputAction3 = inputCursorMove;
			InputActionModifier_ScaleCurve modifier3 = new InputActionModifier_ScaleCurve(inputConfig.CursorInputRemap);
			inputAction3.AddModifier(modifier3);
			InputAction inputAction4 = inputCursorMove;
			InputActionModifier_Merge modifier4 = new InputActionModifier_Merge(inputCursorPrecisionMove);
			inputAction4.AddModifier(modifier4);
			InputAction inputAction5 = inputCursorMove;
			InputActionModifier_SuppressIf modifier5 = new InputActionModifier_SuppressIf((Func<>)(object)(Func<TResult>)(() => inputCameraTriggerPanButton.IsActuated()));
			inputAction5.AddModifier(modifier5);
			InputTriggerDown trigger6 = new InputTriggerDown();
			int num12 = default(int);
			InputActionBool inputActionBool4 = new InputActionBool("Interact", trigger6, (InputProvider)num12);
			num12 = 0;
			inputCursorInteract = inputActionBool4;
			InputTriggerReleased trigger7 = new InputTriggerReleased();
			int num13 = default(int);
			InputActionBool inputActionBool5 = new InputActionBool("EditMode_RotateClockwise", trigger7, (InputProvider)num13);
			num13 = 0;
			inputActionRotateClockwise = inputActionBool5;
			InputTriggerReleased trigger8 = new InputTriggerReleased();
			int num14 = default(int);
			InputActionBool inputActionBool6 = new InputActionBool("EditMode_RotateCounter", trigger8, (InputProvider)num14);
			num14 = 0;
			inputActionRotateCounterClockwise = inputActionBool6;
			InputTriggerReleased trigger9 = new InputTriggerReleased();
			int num15 = default(int);
			InputActionBool inputActionBool7 = new InputActionBool("EditMode_Remove", trigger9, (InputProvider)num15);
			num15 = 0;
			inputActionRemove = inputActionBool7;
			InputTriggerDown trigger10 = new InputTriggerDown();
			InputActionVector2D inputActionVector2D3 = (InputActionVector2D)(inputCameraTriggerPan = new InputActionVector2D("EditModeCam_TriggerPanHorizontal", "EditModeCam_TriggerPanVertical", trigger10, (InputProvider)num2));
			InputAction inputAction6 = inputCameraTriggerPan;
			InputActionModifier_SuppressIf modifier6 = new InputActionModifier_SuppressIf((Func<>)(object)(Func<TResult>)(() => !inputCameraTriggerPanButton.IsTriggered));
			inputAction6.AddModifier(modifier6);
			InputTriggerDown trigger11 = new InputTriggerDown();
			InputActionVector2D inputActionVector2D4 = (InputActionVector2D)(inputCameraAutoPan = new InputActionVector2D("EditModeCam_TriggerPanHorizontal", "EditModeCam_TriggerPanVertical", trigger11, (InputProvider)num2));
			InputAction inputAction7 = inputCameraAutoPan;
			InputActionModifier_SuppressIf modifier7 = new InputActionModifier_SuppressIf((Func<>)(object)(Func<TResult>)delegate
			{
				//IL_0069: Expected O, but got F4
				//IL_0069: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Invalid comparison between Unknown and O
				if (inputCameraTriggerPanButton.IsTriggered)
				{
					return true;
				}
				GridEditModeInputConfig inputConfig2 = InputConfig;
				float y = CursorPosition.y;
				int num23 = 0;
				int height = Screen.height;
				float num24 = default(float);
				if (!(num24 >= y))
				{
					float y2 = CursorPosition.y;
					int num25 = 0;
					int height2 = Screen.height;
					if (!(y2 >= 1f))
					{
						Vector2 vector2 = CursorPosition;
						int num26 = 0;
						int width = Screen.width;
						float autoPanHorizontalPercent = ((GridEditModeInputConfig)num24).AutoPanHorizontalPercent;
						if ((object)(/*Error near IL_006a: Stack underflow*/ * autoPanHorizontalPercent) < vector2)
						{
							Vector2 vector3 = CursorPosition;
							int num27 = 0;
							int width2 = Screen.width;
						}
					}
				}
				int num28 = 0;
				throw new NullReferenceException();
			});
			inputAction7.AddModifier(modifier7);
			InputAction inputAction8 = inputCameraAutoPan;
			InputActionModifier_ValueModifier modifier8 = new InputActionModifier_ValueModifier((Func<, >)(object)new Func<T, TResult>(ZeroIfNotMovingTowardsAutoPan));
			inputAction8.AddModifier(modifier8);
			InputTriggerDown trigger12 = new InputTriggerDown();
			InputActionVector2D inputActionVector2D5 = (InputActionVector2D)(inputCameraPan = new InputActionVector2D("EditModeCam_PanHorizontal", "EditModeCam_PanVertical", trigger12, (InputProvider)num2));
			InputAction inputAction9 = inputCameraPan;
			InputActionModifier_Merge modifier9 = new InputActionModifier_Merge(inputCameraTriggerPan);
			inputAction9.AddModifier(modifier9);
			InputAction inputAction10 = inputCameraPan;
			InputActionModifier_Merge modifier10 = new InputActionModifier_Merge(inputCameraAutoPan);
			inputAction10.AddModifier(modifier10);
			InputTriggerDown trigger13 = new InputTriggerDown();
			InputActionVector2D inputActionVector2D6 = (InputActionVector2D)(inputCameraRotate = new InputActionVector2D("EditModeCam_RotateYaw", "EditModeCam_RotatePitch", trigger13, (InputProvider)num2));
			InputAction inputAction11 = inputCameraRotate;
			InputActionModifier_SuppressIf modifier11 = new InputActionModifier_SuppressIf((Func<>)(object)(Func<TResult>)(() => inputCameraToggle2.IsActuated()));
			inputAction11.AddModifier(modifier11);
			InputTriggerDown trigger14 = new InputTriggerDown();
			int num16 = default(int);
			InputActionFloat inputActionFloat = new InputActionFloat("EditModeCam_Zoom", trigger14, (string)num16, (InputProvider)num2);
			num16 = 0;
			inputCameraZoom = inputActionFloat;
			InputAction inputAction12 = inputCameraZoom;
			InputActionModifier_SuppressIf modifier12 = new InputActionModifier_SuppressIf((Func<>)(object)(Func<TResult>)(() => !inputCameraToggle2.IsActuated()));
			inputAction12.AddModifier(modifier12);
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			SceneItemData sceneItemData = sceneData.sceneItemData;
			if ((object)editCameraConfig == null)
			{
			}
			FreeCameraControl freeCameraControl = (cameraNav = new FreeCameraControl());
			FreeCameraControl freeCameraControl2 = cameraNav;
			Camera camera = playerCamera;
			PlayerAvatar playerAvatar = SystemRoot.Instance._avatar;
			PlayerNavigationConfig playerConfig = _playerConfig;
			Transform startCameraTransform = StartCameraTransform;
			freeCameraControl2.Init(camera, playerAvatar, playerConfig, startCameraTransform, editCameraConfig);
			PrepareInitialCameraTransition();
			int num17 = default(int);
			TapGesture tapGesture = new TapGesture(_inputZone, (Camera)num17);
			num17 = 0;
			float num18 = (tapGesture.DragTolerance = _playerConfig.tapDragTolerance);
			tapGesture.MaxDuration = 60f;
			tapGesture.UseRightClick = (byte)num2 != 0;
			leftClickTapGesture = tapGesture;
			int num19 = default(int);
			TapGesture tapGesture2 = new TapGesture(_inputZone, (Camera)num19);
			num19 = 0;
			float num20 = (tapGesture2.DragTolerance = _playerConfig.tapDragTolerance);
			tapGesture2.MaxDuration = 60f;
			tapGesture2.UseLeftClick = (byte)num2 != 0;
			rightClickTapGesture = tapGesture2;
			GameObject gameObject = default(GameObject);
			List<SubGridScript> list = (subGridScripts = (List<SubGridScript>)(object)new List<T>((int)gameObject.GetComponentsInChildren<SubGridScript>()));
			GridScript[] componentsInChildren = gameObject.GetComponentsInChildren<GridScript>();
			List<SubGridScript> list2 = subGridScripts;
			GridScript[] array = Enumerable.Except<GridScript>((IEnumerable<>)(object)componentsInChildren, (IEnumerable<>)list2).ToArray<GridScript>();
			IEnumerable<GridScript> enumerable = (IEnumerable<GridScript>)this.FilterGrids(array);
			Func<GridScript, float> func = default(Func<GridScript, float>);
			if (_003C_003Ec._003C_003E9__133_5 == null)
			{
				func = (Func<GridScript, float>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GridScript x)
				{
					//Discarded unreachable code: IL_000e
					Transform gridOrigin = x.GridOrigin;
					Vector3 vector = default(Vector3);
					return vector.y;
				});
			}
			GridScript[] array2 = (allGridScripts = ((IEnumerable<>)Enumerable.OrderByDescending<GridScript, float>((IEnumerable<>)enumerable, (Func<, >)(object)func)).ToArray<GridScript>());
			List<SubGridScript> list3 = subGridScripts;
			Predicate<SubGridScript> predicate = (Predicate<SubGridScript>)(object)(Predicate<T>)delegate(SubGridScript x)
			{
				//Discarded unreachable code: IL_0013
				GridObjectScript _003CGridObjectScript_003Ek__BackingField = x.GridObjectScript;
				GridScript[] array5 = allGridScripts;
				bool flag = default(bool);
				return !flag;
			};
			int num21 = ((List<T>)(object)list3).RemoveAll((Predicate<>)(object)predicate);
			GridScript[] array3 = allGridScripts;
			Boundaries[] cameraBoundaries = GetCameraBoundaries(gameObject, array3);
			cameraNav.SetBoundaries(cameraBoundaries);
			int num22 = 0;
			(RectInt, GridScript)[] array4 = (mainGridScripts = new(RectInt, GridScript)[allGridScripts.Length]);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60012EA")]
		[Cpp2IlInjected.Address(RVA = "0xCFE410", Offset = "0xCFCE10", VA = "0x180CFE410")]
		private bool IsCursorInAutoPanArea()
		{
			//IL_0059: Expected O, but got F4
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Invalid comparison between Unknown and O
			GridEditModeInputConfig inputConfig = InputConfig;
			float y = CursorPosition.y;
			int num = 0;
			int height = Screen.height;
			float num2 = default(float);
			if (!(num2 >= y))
			{
				float y2 = CursorPosition.y;
				int num3 = 0;
				int height2 = Screen.height;
				if (!(y2 >= 1f))
				{
					Vector2 vector = CursorPosition;
					int num4 = 0;
					int width = Screen.width;
					float autoPanHorizontalPercent = ((GridEditModeInputConfig)num2).AutoPanHorizontalPercent;
					if ((object)(/*Error near IL_005a: Stack underflow*/ * autoPanHorizontalPercent) < vector)
					{
						Vector2 vector2 = CursorPosition;
						int num5 = 0;
						int width2 = Screen.width;
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60012EB")]
		[Cpp2IlInjected.Address(RVA = "0xD06530", Offset = "0xD04F30", VA = "0x180D06530")]
		private Vector2 ZeroIfNotMovingTowardsAutoPan(Vector2 input)
		{
			//IL_0053: Expected O, but got F4
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Invalid comparison between Unknown and O
			GridEditModeInputConfig inputConfig = InputConfig;
			float y = CursorPosition.y;
			int num = 0;
			int num2 = 0;
			int height = Screen.height;
			float num3 = default(float);
			if (!(num3 >= y))
			{
				float y2 = CursorPosition.y;
				int num4 = 0;
				int height2 = Screen.height;
			}
			Vector2 vector = CursorPosition;
			int num5 = 0;
			int width = Screen.width;
			float autoPanHorizontalPercent = ((GridEditModeInputConfig)num3).AutoPanHorizontalPercent;
			if ((object)(/*Error near IL_0054: Stack underflow*/ * autoPanHorizontalPercent) < vector)
			{
				Vector2 vector2 = CursorPosition;
				int num6 = 0;
				int width2 = Screen.width;
			}
			int num7 = 0;
			Vector2 zero = Vector2.zero;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60012EC")]
		[Cpp2IlInjected.Address(RVA = "0xD04B80", Offset = "0xD03580", VA = "0x180D04B80", Slot = "18")]
		protected unsafe virtual void Update()
		{
			//IL_002b: Expected O, but got I4
			//IL_02e5: Expected native int or pointer, but got O
			//IL_0327: Expected F4, but got I4
			//IL_0327: Expected F4, but got I4
			//IL_0331: Expected native int or pointer, but got O
			//IL_033e: Expected O, but got F4
			//IL_036b: Expected native int or pointer, but got O
			//IL_03c1: Expected O, but got I4
			//IL_042e: Expected O, but got I4
			//IL_0473: Expected O, but got I4
			//IL_04c4: Expected O, but got I4
			//IL_04d2: Expected O, but got I4
			//IL_04f2: Expected O, but got I4
			//IL_053a: Expected O, but got I4
			//IL_059c: Expected I4, but got I8
			//IL_05c4: Expected O, but got I4
			//IL_05d9: Expected O, but got I4
			//IL_063a: Expected native int or pointer, but got O
			//IL_0650: Expected native int or pointer, but got O
			//IL_0672: Expected O, but got I4
			//IL_0698: Expected O, but got I4
			//IL_071a: Expected I4, but got I8
			//IL_0725: Expected I4, but got I8
			float num13 = default(float);
			Predicate<Task> predicate = default(Predicate<Task>);
			GridObjectScript selectedGridObject2 = default(GridObjectScript);
			bool flag = default(bool);
			bool flag2 = default(bool);
			Task asyncTask = default(Task);
			uint num23 = default(uint);
			bool flag4 = default(bool);
			ulong num25 = default(ulong);
			uint num27 = default(uint);
			Vector3 vector5 = default(Vector3);
			Vector3 vector6 = default(Vector3);
			Vector3 vector7 = default(Vector3);
			float minimumGroundMovementToStartMovingObject = default(float);
			float num29 = default(float);
			ulong num30 = default(ulong);
			ulong num31 = default(ulong);
			while (true)
			{
				Task task = cameraTransitionTask;
				int num = 0;
				if (task != null)
				{
					if (!task.IsCompleted || cameraTransitionTask.Exception != null)
					{
						continue;
					}
					cameraTransitionTask = (Task)num;
				}
				TapGesture tapGesture = leftClickTapGesture;
				int num2 = 0;
				float deltaTime = Time.deltaTime;
				tapGesture.Update(deltaTime);
				TapGesture tapGesture2 = rightClickTapGesture;
				int num3 = 0;
				deltaTime = Time.deltaTime;
				tapGesture2.Update(deltaTime);
				MoveGesture moveGesture = move;
				int num4 = 0;
				deltaTime = Time.deltaTime;
				moveGesture.Update(deltaTime);
				FreeCameraControl freeCameraControl = cameraNav;
				InputActionModifier_ScaleExternalCurve inputActionModifier_ScaleExternalCurve = cursorSpeedModifier;
				float currentZoom = freeCameraControl.CurrentZoom;
				int num5 = 0;
				inputActionModifier_ScaleExternalCurve.CurveIndex = currentZoom;
				float deltaTime2 = Time.deltaTime;
				InputAction[] array = new InputAction[14];
				InputAction inputAction = inputCameraTriggerPanButton;
				if (inputAction != null && array == null)
				{
					continue;
				}
				array[0] = inputAction;
				InputAction inputAction2 = inputCameraToggle2;
				if (inputAction2 != null && array == null)
				{
					continue;
				}
				array[1] = inputAction2;
				InputAction inputAction3 = inputCursorPrecisionMove;
				if (inputAction3 != null && array == null)
				{
					continue;
				}
				array[2] = inputAction3;
				InputAction inputAction4 = inputCursorMove;
				if (inputAction4 != null && array == null)
				{
					continue;
				}
				array[3] = inputAction4;
				InputAction inputAction5 = inputCursorInteract;
				if (inputAction5 != null && array == null)
				{
					continue;
				}
				array[4] = inputAction5;
				InputAction inputAction6 = inputActionInteract;
				if (inputAction6 != null && array == null)
				{
					continue;
				}
				array[5] = inputAction6;
				InputAction inputAction7 = inputActionRotateClockwise;
				if (inputAction7 != null && array == null)
				{
					continue;
				}
				array[6] = inputAction7;
				InputAction inputAction8 = inputActionRotateCounterClockwise;
				if (inputAction8 != null && array == null)
				{
					continue;
				}
				array[7] = inputAction8;
				InputAction inputAction9 = inputActionRemove;
				if (inputAction9 != null && array == null)
				{
					continue;
				}
				array[8] = inputAction9;
				InputAction inputAction10 = inputCameraTriggerPan;
				if (inputAction10 != null && array == null)
				{
					continue;
				}
				array[9] = inputAction10;
				InputAction inputAction11 = inputCameraAutoPan;
				if (inputAction11 != null && array == null)
				{
					continue;
				}
				array[10] = inputAction11;
				InputAction inputAction12 = inputCameraPan;
				if (inputAction12 != null && array == null)
				{
					continue;
				}
				array[11] = inputAction12;
				InputAction inputAction13 = inputCameraRotate;
				if (inputAction13 != null && array == null)
				{
					continue;
				}
				array[12] = inputAction13;
				InputAction inputAction14 = inputCameraZoom;
				if (inputAction14 != null && array == null)
				{
					continue;
				}
				array[13] = inputAction14;
				int num6 = 0;
				InputAction.UpdateAll(deltaTime2, array);
				if ((UpdateCursor ? 1 : 0) != num)
				{
					int num7 = 0;
					InputAction inputAction15 = inputCursorMove;
					if ((inputAction15.IsTriggered ? 1 : 0) != num)
					{
						isUsingMouse = (byte)num != 0;
					}
					GridEditModeInputConfig inputConfig = InputConfig;
					Vector2 vector = CursorPosition;
					float y = CursorPosition.y;
					Vector2 valueVector = inputAction15.GetValueVector2();
					int num8 = 0;
					int width = Screen.width;
					int num9 = 0;
					int width2 = Screen.width;
					int num10 = 0;
					float deltaTime3 = Time.deltaTime;
					((Vector2*)(IntPtr)CursorPosition)->y = y;
					previousMousePosition = vector;
					isUsingMouse = true;
					CursorPosition = vector;
					int num11 = 0;
					int width3 = Screen.width;
					int num12 = 0;
					float num14 = num13;
					int height = Screen.height;
					int num15 = 0;
					float y2 = Mathf.Clamp(num13, num15, num6);
					((Vector2*)(IntPtr)CursorPosition)->y = y2;
					CursorPosition = (Vector2)num14;
				}
				Vector2 vector2 = CursorPosition;
				float y3 = CursorPosition.y;
				List<Task> list = blockingTasks;
				VisualCursorPosition = vector2;
				((Vector2*)(IntPtr)VisualCursorPosition)->y = y3;
				if (_003C_003Ec._003C_003E9__136_0 == null)
				{
					predicate = (Predicate<Task>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((Task x) => x.IsCompleted));
				}
				int num16 = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
				List<Task> list2 = blockingTasks;
				if ((CameraOverriden ? 1 : 0) == num)
				{
					GridObjectScript gridObjectScript = movedObject;
					int num17 = 0;
					if (gridObjectScript == (UnityEngine.Object)num17 || ShouldStartAutomaticMovement())
					{
						bool controlsOverridden = AllowNonTouchControls;
						int num18 = 0;
						FreeCameraControl freeCameraControl2 = cameraNav;
						float deltaTime4 = Time.deltaTime;
						InputAction zoomAction = inputCameraZoom;
						InputAction panAction = inputCameraPan;
						MoveGesture moveGesture2 = move;
						InputAction rotateAction = inputCameraRotate;
						freeCameraControl2.MoveCamera(deltaTime4, moveGesture2, panAction, rotateAction, zoomAction, controlsOverridden);
					}
				}
				GridObjectScript selectedGridObject = _selectedGridObject;
				int num19 = 0;
				if (!(selectedGridObject != (UnityEngine.Object)num19))
				{
					if ((leftClickTapGesture.IsTrue ? 1 : 0) == num)
					{
						if ((inputActionInteract.IsTriggered ? 1 : 0) == num || (AllowNonTouchControls ? 1 : 0) != num)
						{
							continue;
						}
						selectedGridObject2 = _selectedGridObject;
						int num20 = 0;
						if (!(selectedGridObject2 == (UnityEngine.Object)num20))
						{
							continue;
						}
					}
					if (gridMovementRestrictions.Length > num && (IntPtr)_currentGridMovementRestriction == (IntPtr)num)
					{
						continue;
					}
					Vector2 vector3 = CursorPosition;
					float y4 = CursorPosition.y;
					Camera camera = playerCamera;
					if (!flag)
					{
						continue;
					}
					int num21 = 0;
					if (!(selectedGridObject2 != (UnityEngine.Object)num21) || !CanSelectObject((GridObjectScript)num21))
					{
						continue;
					}
					GridScript[] array2 = allGridScripts;
					if (!flag2 && !Enumerable.Contains<GridScript>((IEnumerable<>)subGridScripts, (GridScript)num21))
					{
						continue;
					}
					int num22 = 0;
					asyncTask.FireAndForgetTask();
				}
				if (CanMoveSelectedObject)
				{
					if (!ShouldStartAutomaticMovement() && CustomMoveHandler != null)
					{
						if (num < (int)num23)
						{
							num += num;
							num++;
						}
						HoveredObject = (GameObject)num;
						bool flag3 = isMovingGestureActive;
						InputAction inputAction16 = inputCursorInteract;
						Vector2 vector4 = CursorPosition;
						float y5 = CursorPosition.y;
						if ((inputAction16.IsTriggered ? 1 : 0) == num)
						{
							int num24 = 0;
							if (!Input.GetMouseButton(0))
							{
								isMovingGestureActive = (byte)num != 0;
								num24 += num24;
							}
						}
						if ((isMovingGestureActive ? 1 : 0) != num)
						{
							continue;
						}
						if (flag4)
						{
							isMovingGestureActive = (byte)num25 != 0;
						}
						if ((isMovingGestureActive ? 1 : 0) != num)
						{
							continue;
						}
						if (flag3)
						{
							GridObjectScript gridObjectScript2 = movedObject;
							int num26 = 0;
							if (gridObjectScript2 != (UnityEngine.Object)num26)
							{
								ICustomMoveHandler customMoveHandler = CustomMoveHandler;
								movedObject = (GridObjectScript)num;
								if (this.SelectedObjectMoveEndedEvent == null)
								{
									ICustomMoveHandler customMoveHandler2 = CustomMoveHandler;
									if (num < (int)num27)
									{
										num += num;
										num++;
									}
									if (num != 0)
									{
										GridObjectScript gridObjectScript3 = (movedObject = _selectedGridObject);
										GridObjectScript selectedGridObject3 = _selectedGridObject;
										movedCursorDuringMovement = (byte)num != 0;
										Transform transform = selectedGridObject3.transform;
										float z = vector5.z;
										((Vector3*)(IntPtr)targetStartPos)->z = z;
										float z2 = vector6.z;
										((Vector3*)(IntPtr)targetStartTouchPos)->z = z2;
										((Dictionary<TKey, TValue>)(object)validPositionCache).Clear();
										((Dictionary<TKey, TValue>)(object)invalidPositionResultCache).Clear();
										findValidPositionTask = (Task<GridPosition>)num;
										if ((IntPtr)findValidPositionCTS != (IntPtr)num)
										{
										}
										if (this.SelectedObjectMoveStartedEvent == null)
										{
										}
									}
								}
							}
						}
					}
					GridObjectScript gridObjectScript4 = movedObject;
					int num28 = 0;
					if (gridObjectScript4 != (UnityEngine.Object)num28)
					{
						float y6 = CursorPosition.y;
						float z3 = targetStartTouchPos.z;
						float z4 = vector7.z;
						if ((movedCursorDuringMovement ? 1 : 0) == num)
						{
							minimumGroundMovementToStartMovingObject = _minimumGroundMovementToStartMovingObject;
							if (num29 <= minimumGroundMovementToStartMovingObject)
							{
								goto IL_06f6;
							}
						}
						movedCursorDuringMovement = true;
						if (ShouldStartAutomaticMovement())
						{
						}
						float z5 = targetStartPos.z;
						num29 = minimumGroundMovementToStartMovingObject;
					}
				}
				goto IL_06f6;
				IL_06f6:
				if (((inputActionRotateClockwise.IsTriggered ? 1 : 0) != num || (rightClickTapGesture.IsTrue ? 1 : 0) != num) && CanRotateSelectedObject((byte)num30 != 0))
				{
					RotateSelectedObject((byte)num31 != 0);
				}
				if ((inputActionRotateCounterClockwise.IsTriggered ? 1 : 0) != num)
				{
					int clockwise = 0;
					if (CanRotateSelectedObject((byte)clockwise != 0))
					{
						int clockwise2 = 0;
						RotateSelectedObject((byte)clockwise2 != 0);
					}
				}
				if ((inputActionRemove.IsTriggered ? 1 : 0) != num && CanRemoveSelectedObject)
				{
					/*Error: Could not find block for branch target IL_0769*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012EF")]
		[Cpp2IlInjected.Address(RVA = "0xCFE400", Offset = "0xCFCE00", VA = "0x180CFE400")]
		private void HoveredObjectDestroyed(object sender, EventArgs e)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			HoveredObject = (GameObject)num;
		}

		[Cpp2IlInjected.Token(Token = "0x60012F0")]
		[Cpp2IlInjected.Address(RVA = "0xD039C0", Offset = "0xD023C0", VA = "0x180D039C0")]
		private bool TryGetGridObjectScriptFromRay(Ray ray, out GridObjectScript gridObjectScript)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60012F3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnSystemPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60012F4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60012F5")]
		[Cpp2IlInjected.Address(RVA = "0xD028D0", Offset = "0xD012D0", VA = "0x180D028D0", Slot = "5")]
		public override void OnSystemStop()
		{
			//Discarded unreachable code: IL_00a5
			//IL_0019: Expected I4, but got I8
			//IL_003c: Expected I4, but got I8
			//IL_0050: Expected O, but got I4
			//IL_005b: Expected O, but got I4
			//IL_0063: Expected O, but got I4
			//IL_006b: Expected O, but got I4
			//IL_0073: Expected O, but got I4
			//IL_007b: Expected O, but got I4
			//IL_0083: Expected O, but got I4
			//IL_008e: Expected O, but got I4
			//IL_0099: Expected O, but got I4
			int num = 0;
			InputProvider inputProvider = DefaultInputProvider.Get();
			int[] array = new int[1];
			array[0] = 1;
			inputProvider.EnableMaps(array);
			int num2 = 0;
			InputProvider inputProvider2 = DefaultInputProvider.Get();
			int[] array2 = new int[1];
			array2[0] = 2;
			inputProvider2.DisableMaps(array2);
			int num3 = 0;
			SelectedGridObject = (GridObjectScript)num3;
			int num4 = 0;
			cameraNav = (FreeCameraControl)num4;
			leftClickTapGesture = (TapGesture)num4;
			rightClickTapGesture = (TapGesture)num4;
			allGridScripts = (GridScript[])num4;
			subGridScripts = (List<SubGridScript>)num4;
			_availableGridsForPosition = (Dictionary<GridPosition, List<GridScript>>)num4;
			int num5 = 0;
			CurrentMovementRestriction = (IGridMovementRestriction)num5;
			int num6 = 0;
			HoveredObject = (GameObject)num6;
			((List<T>)(object)blockingTasks).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x60012F7")]
		[Cpp2IlInjected.Address(RVA = "0xCFB750", Offset = "0xCFA150", VA = "0x180CFB750")]
		public void DuplicateSelectedObject()
		{
			if (CanDuplicateSelectedObject)
			{
				DoDuplicateSelectedObject().FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012F8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		protected abstract Task DoDuplicateSelectedObject();

		[Cpp2IlInjected.Token(Token = "0x60012FA")]
		[Cpp2IlInjected.Address(RVA = "0xD030B0", Offset = "0xD01AB0", VA = "0x180D030B0")]
		public void RemoveSelectedObject()
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60012FB")]
		[Cpp2IlInjected.Address(RVA = "0xD02FB0", Offset = "0xD019B0", VA = "0x180D02FB0")]
		[AsyncStateMachine(typeof(_003CRemoveSelectedObjectAsync_003Ed__157))]
		private Task RemoveSelectedObjectAsync()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60012FC")]
		[Cpp2IlInjected.Address(Slot = "22")]
		protected abstract Task DoRemoveSelectedObject();

		[Cpp2IlInjected.Token(Token = "0x60012FD")]
		[Cpp2IlInjected.Address(RVA = "0xCFA0B0", Offset = "0xCF8AB0", VA = "0x180CFA0B0")]
		private bool CanRotateSelectedObjectWithOrientation(bool clockwise, out GridOrientation newOrientation)
		{
			//IL_0019: Expected O, but got I4
			int num = (newOrientation.value__ = 0);
			GridObjectScript selectedGridObject = _selectedGridObject;
			int num2 = 0;
			if (selectedGridObject != (UnityEngine.Object)num2)
			{
				GridObject _003CGridObject_003Ek__BackingField = _selectedGridObject.GridObject;
				bool flag = default(bool);
				if (!flag)
				{
					GridObject _003CGridObject_003Ek__BackingField2 = _selectedGridObject.GridObject;
					bool flag2 = default(bool);
					if (!flag2)
					{
						GridOrientation gridOrientation = (GridOrientation)(newOrientation.value__ = (int)_selectedGridObject.GridObject.orientation_.Rotate(clockwise));
						GridObjectScript selectedGridObject2 = _selectedGridObject;
						GridScript _003CGridScript_003Ek__BackingField = selectedGridObject2.GridScript;
						if ((object)_003CGridScript_003Ek__BackingField != null)
						{
							int num3 = 0;
							if ((object)_003CGridScript_003Ek__BackingField != null)
							{
								GridObject _003CGridObject_003Ek__BackingField3 = selectedGridObject2.GridObject;
								GridData gridData = _selectedGridObject.GridScript.GridData;
								int num4 = default(int);
								if (_selectedGridObject.GridScript.GridData.sizeY_ < num4)
								{
									GridOrientation gridOrientation2 = default(GridOrientation);
									int num5 = (int)gridOrientation2;
									newOrientation.value__ = (int)gridOrientation2;
									GridObject _003CGridObject_003Ek__BackingField4 = _selectedGridObject.GridObject;
									while (num5 != (int)_003CGridObject_003Ek__BackingField4.orientation_)
									{
									}
									goto IL_00de;
								}
							}
						}
						goto IL_00e1;
					}
				}
			}
			goto IL_00de;
			IL_00e1:
			throw new NullReferenceException();
			IL_00de:
			int num6 = 0;
			goto IL_00e1;
		}

		[Cpp2IlInjected.Token(Token = "0x60012FE")]
		[Cpp2IlInjected.Address(RVA = "0xCFA3A0", Offset = "0xCF8DA0", VA = "0x180CFA3A0", Slot = "23")]
		public virtual bool CanRotateSelectedObject(bool clockwise)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60012FF")]
		[Cpp2IlInjected.Address(RVA = "0xD03390", Offset = "0xD01D90", VA = "0x180D03390")]
		public void RotateSelectedObject(bool clockwise)
		{
			//Discarded unreachable code: IL_00d7
			//IL_0083: Expected O, but got I4
			bool flag = default(bool);
			if (flag)
			{
				AK.Wwise.Event sfxRotateItemEvent = _sfxRotateItemEvent;
				if (sfxRotateItemEvent != null)
				{
					GameObject gameObject = base.gameObject;
					uint num = sfxRotateItemEvent.Post(gameObject);
				}
				GridObject _003CGridObject_003Ek__BackingField = _selectedGridObject.GridObject;
				GridObjectScript selectedGridObject = _selectedGridObject;
				GridObject _003CGridObject_003Ek__BackingField2 = selectedGridObject.GridObject;
				GridScript _003CGridScript_003Ek__BackingField = selectedGridObject.GridScript;
				GridPosition position = _003CGridObject_003Ek__BackingField2.Position;
				GridObject _003CGridObject_003Ek__BackingField3 = _selectedGridObject.GridObject;
				int num2 = 0;
				GridObjectScript gridObjectScript = movedObject;
				int num3 = 0;
				if (!(gridObjectScript != (UnityEngine.Object)num3) || (movedCursorDuringMovement ? 1 : 0) == num2)
				{
				}
				GridScript _003CGridScript_003Ek__BackingField2 = _selectedGridObject.GridScript;
				GridObjectScript selectedGridObject2 = _selectedGridObject;
				bool flag2 = default(bool);
				if (!flag2)
				{
					GridScript _003CGridScript_003Ek__BackingField3 = _selectedGridObject.GridScript;
					Func<GridPosition, bool> func = (Func<GridPosition, bool>)(object)new Func<T, TResult>(ValidityCheck);
					IEnumerable<GridPosition> enumerable = default(IEnumerable<GridPosition>);
					GridPosition gridPosition = Enumerable.FirstOrDefault<GridPosition>((IEnumerable<>)enumerable);
				}
				GridOrientation newOrientation = default(GridOrientation);
				GridOrientation gridOrientation = newOrientation;
			}
			GridArea gridArea = default(GridArea);
			[Cpp2IlInjected.Token(Token = "0x6001349")]
			[Cpp2IlInjected.Address(RVA = "0x185B890", Offset = "0x185A290", VA = "0x18185B890")]
			bool ValidityCheck(GridPosition x)
			{
				//Discarded unreachable code: IL_0015
				GridObjectScript selectedGridObject3 = _selectedGridObject;
				GridArea gridArea2 = gridArea;
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001301")]
		[Cpp2IlInjected.Address(RVA = "0xCFB300", Offset = "0xCF9D00", VA = "0x180CFB300")]
		public void DeselectSelectedObject()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> asyncTask = default(Task<>);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001302")]
		[Cpp2IlInjected.Address(RVA = "0xCFB1E0", Offset = "0xCF9BE0", VA = "0x180CFB1E0")]
		[AsyncStateMachine(typeof(_003CDeselectSelectedObjectAsync_003Ed__165))]
		protected Task<bool> DeselectSelectedObjectAsync()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001303")]
		[Cpp2IlInjected.Address(Slot = "25")]
		protected abstract Task<bool> DoDeselectSelectedObject();

		[Cpp2IlInjected.Token(Token = "0x6001304")]
		[Cpp2IlInjected.Address(RVA = "0xCF9B70", Offset = "0xCF8570", VA = "0x180CF9B70")]
		public unsafe void AddNewSubGrid(SubGridScript subGridScript)
		{
			//Discarded unreachable code: IL_00c8
			List<SubGridScript> list = subGridScripts;
			int num = 0;
			if (((List<T>)(object)list).Contains((T)subGridScript))
			{
				return;
			}
			((List<T>)(object)subGridScripts).Add((T)subGridScript);
			Transform gridOrigin = subGridScript.GridObjectScript.GridScript.GridOrigin;
			float z = metaGridOrigin.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			GridObject _003CGridObject_003Ek__BackingField = subGridScript.GridObjectScript.GridObject;
			GridOrientation orientation_ = subGridScript.GridObjectScript.GridObject.orientation_;
			int num2 = default(int);
			if (num >= num2)
			{
				return;
			}
			GridOrientation orientation_2 = subGridScript.GridObjectScript.GridObject.orientation_;
			int num3 = default(int);
			if (num < num3)
			{
				GridPosition position = subGridScript.GridObjectScript.GridObject.Position;
				GridPosition mainGridPosition = default(GridPosition);
				GridPosition localGridSpacePosition = subGridScript.GetLocalGridSpacePosition(mainGridPosition);
				int num4 = (int)subGridScript.GridData[localGridSpacePosition];
				int num5 = 0;
				bool flag = default(bool);
				if (!flag)
				{
					AddGridToPosition(in *(GridPosition*)num5, subGridScript);
				}
				num++;
			}
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6001305")]
		[Cpp2IlInjected.Address(RVA = "0xD031F0", Offset = "0xD01BF0", VA = "0x180D031F0")]
		public unsafe void RemoveSubGrid(SubGridScript subGridScript)
		{
			//Discarded unreachable code: IL_0045
			if (!((List<T>)(object)subGridScripts).Remove((T)subGridScript))
			{
				return;
			}
			int num = 0;
			if ((long)(IntPtr)_metaGridSize > (long)num)
			{
				if (_metaGridSize.Y > 0)
				{
					RemoveGridFromPosition(in *(GridPosition*)num, subGridScript);
					int y = _metaGridSize.Y;
					num++;
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001306")]
		[Cpp2IlInjected.Address(RVA = "0xCFDCB0", Offset = "0xCFC6B0", VA = "0x180CFDCB0")]
		protected Vector3 GetGroundPositionFromScreenPosition(Vector2 screenPosition)
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001307")]
		[Cpp2IlInjected.Address(RVA = "0xCFD9E0", Offset = "0xCFC3E0", VA = "0x180CFD9E0")]
		protected Vector3 GetGroundPositionFromCameraPosition()
		{
			int num = 0;
			int num2 = 0;
			Transform transform = base.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001308")]
		[Cpp2IlInjected.Address(RVA = "0xCFDB00", Offset = "0xCFC500", VA = "0x180CFDB00")]
		private Vector3 GetGroundPositionFromRay(Ray ray)
		{
			Vector3? vector = default(Vector3?);
			if ((object)vector != null)
			{
			}
			int num = 0;
			int num2 = 0;
			float z = Vector3.up.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001309")]
		[Cpp2IlInjected.Address(RVA = "0xD037D0", Offset = "0xD021D0", VA = "0x180D037D0")]
		protected unsafe void StartSelectedObjectMove(Vector2 screenPosition, bool drag)
		{
			//Discarded unreachable code: IL_008a
			//IL_0033: Expected native int or pointer, but got O
			//IL_004d: Expected native int or pointer, but got O
			//IL_005a: Expected native int or pointer, but got O
			GridObjectScript gridObjectScript = (movedObject = _selectedGridObject);
			GridObjectScript selectedGridObject = _selectedGridObject;
			movedCursorDuringMovement = false;
			Transform transform = selectedGridObject.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)targetStartPos)->z = z;
			if (!drag)
			{
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				((Vector3*)(IntPtr)targetStartTouchPos)->z = z2;
			}
			((Vector3*)(IntPtr)targetStartTouchPos)->z = z;
			((Dictionary<TKey, TValue>)(object)validPositionCache).Clear();
			((Dictionary<TKey, TValue>)(object)invalidPositionResultCache).Clear();
			if ((long)findValidPositionCTS != 0)
			{
			}
			if (this.SelectedObjectMoveStartedEvent == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600130A")]
		[Cpp2IlInjected.Address(RVA = "0xD003D0", Offset = "0xCFEDD0", VA = "0x180D003D0")]
		private bool MovingGesture(out Vector2 screenPosition)
		{
			//Discarded unreachable code: IL_005d
			if (!inputCursorInteract.IsTriggered)
			{
				bool mouseButton = Input.GetMouseButton(0);
				if (!mouseButton)
				{
					isMovingGestureActive = mouseButton;
					return mouseButton;
				}
			}
			if (!isMovingGestureActive)
			{
				Vector2 screenPos = CursorPosition;
				float y = CursorPosition.y;
				RectTransform inputZone = _inputZone;
				if (Positions.IsHitByRaycast2D(screenPos, inputZone))
				{
					isMovingGestureActive = true;
				}
			}
			return isMovingGestureActive;
		}

		[Cpp2IlInjected.Token(Token = "0x600130D")]
		[Cpp2IlInjected.Address(RVA = "0xCFE940", Offset = "0xCFD340", VA = "0x180CFE940")]
		private unsafe void MoveSelectedObject(Vector3 newPosition)
		{
			//IL_002c: Expected O, but got I4
			//IL_010f: Expected O, but got I4
			//IL_011a: Expected O, but got I4
			//IL_012d: Expected O, but got I4
			//IL_016b: Expected O, but got I4
			//IL_01b1: Expected O, but got I4
			//IL_01be: Expected I4, but got I8
			//IL_01de: Expected O, but got I4
			//IL_0249: Unknown result type (might be due to invalid IL or missing references)
			//IL_024c: Expected O, but got Unknown
			//IL_0268: Expected O, but got I4
			//IL_029f: Expected O, but got I4
			//IL_0345: Expected O, but got I4
			GridArea gridArea = default(GridArea);
			bool flag = default(bool);
			bool flag2 = default(bool);
			Vector3 vector2 = default(Vector3);
			Vector3 vector3 = default(Vector3);
			bool flag3 = default(bool);
			Vector3 vector4 = default(Vector3);
			Vector3 vector5 = default(Vector3);
			Vector3 vector6 = default(Vector3);
			Vector3 vector7 = default(Vector3);
			Vector3 vector8 = default(Vector3);
			Vector3 vector9 = default(Vector3);
			float f = default(float);
			Vector3 vector10 = default(Vector3);
			Vector3 vector11 = default(Vector3);
			GridData gridData = default(GridData);
			GridData gridData2 = default(GridData);
			bool flag4 = default(bool);
			int num7 = default(int);
			AggregateException CS_0024_003C_003E8__locals0 = default(AggregateException);
			GridPosition message = default(GridPosition);
			Vector3 vector12 = default(Vector3);
			bool flag5 = default(bool);
			GridPosition gridPosition2 = default(GridPosition);
			ulong num12 = default(ulong);
			int num15 = default(int);
			int num16 = default(int);
			GridOrientation mainGridOrientation = default(GridOrientation);
			GridPosition gridPosition3 = default(GridPosition);
			bool flag6 = default(bool);
			GridOrientation? gridOrientation2 = default(GridOrientation?);
			GridOrientation gridOrientation3 = default(GridOrientation);
			bool flag7 = default(bool);
			GridPosition oldMainGridPosition = default(GridPosition);
			CancellationToken ct = default(CancellationToken);
			bool flag8 = default(bool);
			bool flag9 = default(bool);
			GridPosition className = default(GridPosition);
			bool flag10 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				GridObject _003CGridObject_003Ek__BackingField = _selectedGridObject.GridObject;
				GridScript usedGridScript = (GridScript)num;
				if ((hasWallGrids ? 1 : 0) != num)
				{
					int floorType = (int)gridArea.FloorType;
					if (flag)
					{
						Camera camera = playerCamera;
						Vector2 vector = CursorPosition;
						float y = CursorPosition.y;
						int length = mainGridScripts.Length;
						if (num < length)
						{
							GridFloorType floorType2 = gridArea.FloorType;
							if (flag2)
							{
								float z = vector2.z;
								float z2 = vector3.z;
								if (flag3)
								{
									float z3 = vector4.z;
									float z4 = vector5.z;
									float z5 = vector6.z;
									float num5 = Mathf.Sign(y);
									float z6 = vector7.z;
									float z7 = vector8.z;
									float z8 = vector9.z;
									z3 = Mathf.Sign(f);
									float z9 = vector10.z;
									float z10 = vector11.z;
									if (gridData.Contains((GridPosition)num))
									{
										int num6 = (int)gridData2[(GridPosition)num];
										if (!flag4)
										{
											goto IL_0125;
										}
									}
								}
							}
							num++;
							goto IL_0125;
						}
					}
				}
				goto IL_012d;
				IL_035e:
				GridObject _003CGridObject_003Ek__BackingField2 = _selectedGridObject.GridObject;
				num7 += 32;
				((Exception)CS_0024_003C_003E8__locals0)._message = (string)message;
				if ((long)findValidPositionCTS == 0)
				{
					CancellationTokenSource cancellationTokenSource = (findValidPositionCTS = new CancellationTokenSource());
				}
				CancellationToken cancellationToken = (CancellationToken)(((Exception)CS_0024_003C_003E8__locals0)._data = (IDictionary)findValidPositionCTS.Token);
				Task<GridPosition> task = (findValidPositionTask = (Task<GridPosition>)(object)Task.Run<GridPosition>((Func<>)(object)(Func<TResult>)delegate
				{
					//Discarded unreachable code: IL_00dc, IL_00e2, IL_00e8, IL_00ee, IL_00f4
					//IL_0024: Expected I4, but got O
					int num20 = 0;
					_003C_003Ec__DisplayClass183_3 _003C_003Ec__DisplayClass183_2 = (_003C_003Ec__DisplayClass183_3)(object)CS_0024_003C_003E8__locals0;
					_003C_003Ec__DisplayClass183_1 cS_0024_003C_003E8__locals = ((_003C_003Ec__DisplayClass183_3)(object)CS_0024_003C_003E8__locals0).CS_0024_003C_003E8__locals2;
					_003C_003Ec__DisplayClass183_0 cS_0024_003C_003E8__locals2 = cS_0024_003C_003E8__locals.CS_0024_003C_003E8__locals1;
					int loopLimit = (int)cS_0024_003C_003E8__locals;
					((List<T>)(object)((_003C_003Ec__DisplayClass183_3)(object)CS_0024_003C_003E8__locals0).CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this.validPositions).Clear();
					_003C_003Ec__DisplayClass183_0 CS_0024_003C_003E8__locals1 = ((_003C_003Ec__DisplayClass183_3)(object)CS_0024_003C_003E8__locals0).CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1;
					GridScript usedGridScript2 = CS_0024_003C_003E8__locals1.usedGridScript;
					GridPosition centerPosition = ((_003C_003Ec__DisplayClass183_3)(object)CS_0024_003C_003E8__locals0).centerPosition;
					Func<GridPosition, bool> func = (Func<GridPosition, bool>)(object)new Func<T, TResult>(EnumerationValidityCheck);
					Action<int> action = (Action<int>)(object)new Action<T>(LoopCallback);
					IEnumerable<GridPosition> enumerable = (IEnumerable<GridPosition>)usedGridScript2.EnumeratePositionsInSpiralOrder(centerPosition, 1, -1, (Func<, >)(object)func, (Action<>)(object)action);
					if (enumerable != null)
					{
						if (loopLimit != 0)
						{
							bool flag11 = default(bool);
							if (!flag11)
							{
								List<GridPosition> list = ((_003C_003Ec__DisplayClass183_3)(object)CS_0024_003C_003E8__locals0).CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this.validPositions;
							}
							num20++;
						}
						num20++;
					}
					num20++;
					int num21 = 0;
					if (enumerable != null)
					{
					}
					if (num20 != 0)
					{
					}
					if (num20 == 0)
					{
					}
					int num22 = 0;
					int num23 = 0;
					throw new NullReferenceException();
					[Cpp2IlInjected.Token(Token = "0x600134F")]
					[Cpp2IlInjected.Address(RVA = "0x185BCA0", Offset = "0x185A6A0", VA = "0x18185BCA0")]
					bool EnumerationValidityCheck(GridPosition gridPosition)
					{
						//Discarded unreachable code: IL_003e
						GridObject _003CGridObject_003Ek__BackingField3 = CS_0024_003C_003E8__locals1._003C_003E4__this._selectedGridObject.GridObject;
						GridFloorType floorType4 = CS_0024_003C_003E8__locals1.gridArea.FloorType;
						GridOrientation orientation_3 = _003CGridObject_003Ek__BackingField3.orientation_;
						int num24 = (int)floorType4;
						bool flag12 = default(bool);
						if (flag12)
						{
							GridArea gridArea2 = CS_0024_003C_003E8__locals1.gridArea;
							GridScript usedGridScript3 = CS_0024_003C_003E8__locals1.usedGridScript;
						}
						bool result = default(bool);
						return result;
					}
					[Cpp2IlInjected.Token(Token = "0x6001357")]
					[Cpp2IlInjected.Address(RVA = "0x185C9A0", Offset = "0x185B3A0", VA = "0x18185C9A0")]
					void LoopCallback(int loop)
					{
						//Discarded unreachable code: IL_001c
						List<GridPosition> list2 = _003C_003Ec__DisplayClass183_2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this.validPositions;
					}
				}));
				return;
				IL_0345:
				float z11 = metaGridOrigin.z;
				float z12 = vector12.z;
				num7 = 0;
				goto IL_035e;
				IL_0125:
				usedGridScript = (GridScript)0;
				goto IL_012d;
				IL_012d:
				float z13 = newPosition.z;
				int num8 = 0;
				Vector2Int zero = Vector2Int.zero;
				GridPosition metaGridSize = _metaGridSize;
				int num9 = _metaGridSize.Y - 1;
				GridScript gridScript = usedGridScript;
				int num10 = 0;
				if (gridScript == (UnityEngine.Object)num10)
				{
					int floorType3 = (int)gridArea.FloorType;
					if (!flag5)
					{
						int allowVoid = 0;
						usedGridScript = GetMainGridForPosition(in *(GridPosition*)gridPosition2, (byte)allowVoid != 0);
						GridScript gridScript2 = usedGridScript;
						int num11 = 0;
						if (gridScript2 == (UnityEngine.Object)num11)
						{
							usedGridScript = GetMainGridForPosition(in *(GridPosition*)gridPosition2, (byte)num12 != 0);
							GridScript gridScript3 = usedGridScript;
							int num13 = 0;
							if (gridScript3 == (UnityEngine.Object)num13)
							{
								usedGridScript = GetFirstValidGridAround(gridPosition2);
							}
						}
					}
				}
				GridOrientation orientation_ = _selectedGridObject.GridObject.orientation_;
				float z14 = newPosition.z;
				float z15 = Vector3.right.z;
				float z16 = Vector3.forward.z;
				int num14 = 0;
				Vector2Int zero2 = Vector2Int.zero;
				GridPosition metaGridSize2 = _metaGridSize;
				int y2 = _metaGridSize.Y;
				metaGridSize2 -= num15;
				y2 -= num16;
				GridScript gridScript4 = usedGridScript;
				int num17 = 0;
				if (!(gridScript4 != (UnityEngine.Object)num17))
				{
					return;
				}
				GridOrientation gridOrientation = mainGridOrientation;
				GridObject mainGridTransform = _mainGridTransform;
				GridPosition mainGridPosition = gridPosition3;
				findValidPositionTask = (Task<GridPosition>)num;
				mainGridOrientation = _mainGridTransform.orientation_;
				if (!flag6)
				{
					continue;
				}
				if ((object)gridOrientation2 != null)
				{
					mainGridOrientation = gridOrientation3;
					while (!flag7)
					{
					}
					oldMainGridPosition = oldMainGridPosition;
					Dictionary<(GridScript, GridPosition, GridOrientation), GridPosition> dictionary = invalidPositionResultCache;
					CancellationToken cancellationToken2 = ct;
					GridOrientation orientation_2 = _mainGridTransform.orientation_;
					int num18 = 0;
					int num19 = 0;
					if (flag8)
					{
						goto IL_0345;
					}
					if (dictionary != null)
					{
						if (!flag9)
						{
							return;
						}
						if (dictionary != null && CS_0024_003C_003E8__locals0 == null)
						{
							((Exception)CS_0024_003C_003E8__locals0)._className = (string)className;
							findValidPositionTask = (Task<GridPosition>)num;
							goto IL_0345;
						}
					}
					goto IL_035e;
				}
				if (!flag10)
				{
					break;
				}
			}
			_003C_003Ec__DisplayClass183_5 _003C_003Ec__DisplayClass183_ = new _003C_003Ec__DisplayClass183_5();
			((List<T>)(object)validPositions).Clear();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600130E")]
		[Cpp2IlInjected.Address(RVA = "0xCFE4F0", Offset = "0xCFCEF0", VA = "0x180CFE4F0", Slot = "28")]
		protected virtual bool IsValidMove(GridPosition mainGridPosition, GridOrientation mainGridOrientation, GridScript usedGridScript, GridArea gridArea)
		{
			bool useEditGrid = UseEditGrid;
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				GridScript _003CGridScript_003Ek__BackingField = _selectedGridObject.GridScript;
				if (usedGridScript != _003CGridScript_003Ek__BackingField)
				{
					int itemID = _selectedGridObject.GridObject.ItemID;
					Client client = default(Client);
					Profile profile = client.profile;
					Client client2 = default(Client);
					Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = client2.TransactionContext;
					IGridEditRestriction gridEditRestriction = default(IGridEditRestriction);
					if (!gridEditRestriction.CanSwitchGrid(profile, _003CTransactionContext_003Ek__BackingField))
					{
						goto IL_00a7;
					}
				}
				GridObject _003CGridObject_003Ek__BackingField = _selectedGridObject.GridObject;
				bool useEditGrid2 = UseEditGrid;
				if (_003C_003Ec._003C_003E9__184_1 == null)
				{
					Func<GridCellConflict[], bool> func = (Func<GridCellConflict[], bool>)(object)(Func<T, TResult>)delegate(GridCellConflict[] x)
					{
						Func<GridCellConflict, bool> _003C_003E9__184_2 = _003C_003Ec._003C_003E9__184_3;
						if (_003C_003E9__184_2 == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
							{
								throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
							};
						}
						return ((IEnumerable<>)(object)x).Any<GridCellConflict>((Func<, >)(object)_003C_003E9__184_2);
					};
					if (_003C_003Ec._003C_003E9__184_0 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GridCellConflict[] x)
						{
							Func<GridCellConflict, bool> _003C_003E9__184_ = _003C_003Ec._003C_003E9__184_2;
							if (_003C_003E9__184_ == null)
							{
								_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
								{
									throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
								};
							}
							return ((IEnumerable<>)(object)x).Any<GridCellConflict>((Func<, >)(object)_003C_003E9__184_);
						};
					}
				}
				bool result = default(bool);
				return result;
			}
			goto IL_00a7;
			IL_00a7:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600130F")]
		[Cpp2IlInjected.Address(RVA = "0xCF9F50", Offset = "0xCF8950", VA = "0x180CF9F50", Slot = "29")]
		protected virtual void ApplyMove(GridScript usedGridScript, GridPosition mainGridPosition, GridOrientation mainGridOrientation)
		{
			//Discarded unreachable code: IL_0030
			//IL_002f: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			GridScript _003CGridScript_003Ek__BackingField = _selectedGridObject.GridScript;
			if (usedGridScript != _003CGridScript_003Ek__BackingField)
			{
				ChangeSelectedObjectGrid(usedGridScript);
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			this.ChangeSelectedGridObjectTransform((Nullable<>)num2, (Nullable<>)num3);
		}

		[Cpp2IlInjected.Token(Token = "0x6001310")]
		[Cpp2IlInjected.Address(RVA = "0xCFAFF0", Offset = "0xCF99F0", VA = "0x180CFAFF0", Slot = "30")]
		protected virtual void ChangeSelectedObjectGrid(GridScript newGridScript)
		{
			//Discarded unreachable code: IL_00c6
			//IL_00ae: Expected O, but got I4
			GridScript initialSelectedGridObjectGridScript = _initialSelectedGridObjectGridScript;
			if (!(newGridScript == initialSelectedGridObjectGridScript))
			{
				int itemID = _selectedGridObject.GridObject.ItemID;
				GridPosition position = _selectedGridObject.GridObject.Position;
				GridObject _003CGridObject_003Ek__BackingField = _selectedGridObject.GridObject;
			}
			GridObject gridObject = _initialSelectedGridObjectTransform.Clone();
			GridPosition gridPosition = (gridObject.Position = _selectedGridObject.GridObject.Position);
			GridOrientation gridOrientation = (gridObject.orientation_ = _selectedGridObject.GridObject.orientation_);
			GridState state_ = _selectedGridObject.GridObject.state_;
			if (state_ != null)
			{
				GridState gridState = state_.Clone();
			}
			int num = 0;
			gridObject.state_ = (GridState)num;
			GridObjectScript selectedGridObject = _selectedGridObject;
			int editModeResynchronize = 0;
			selectedGridObject.Init(newGridScript, gridObject, (byte)editModeResynchronize != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001311")]
		[Cpp2IlInjected.Address(RVA = "0xCFA3C0", Offset = "0xCF8DC0", VA = "0x180CFA3C0")]
		private void ChangeSelectedGridObjectTransform([System.Runtime.InteropServices.Optional] (GridPosition position, GridOrientation orientation)? world, [System.Runtime.InteropServices.Optional] (GridPosition position, GridOrientation orientation)? local)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001312")]
		[Cpp2IlInjected.Address(RVA = "0xD04530", Offset = "0xD02F30", VA = "0x180D04530")]
		protected unsafe void UpdateSelectedObjectConflictedLayers()
		{
			//IL_0024: Expected O, but got I4
			//IL_010f: Expected F4, but got O
			//IL_010a: Expected native int or pointer, but got O
			GridObjectScript selectedGridObject = _selectedGridObject;
			int num = 0;
			GridObject _003CGridObject_003Ek__BackingField = selectedGridObject.GridObject;
			GridAreaRenderer gridAreaRenderer = this.gridAreaRenderer;
			int num2 = 0;
			if (gridAreaRenderer != (UnityEngine.Object)num2)
			{
				GridObjectScript selectedGridObject2 = _selectedGridObject;
				GridObject _003CGridObject_003Ek__BackingField2 = selectedGridObject2.GridObject;
				GridScript _003CGridScript_003Ek__BackingField = selectedGridObject2.GridScript;
				GridPosition position = _003CGridObject_003Ek__BackingField2.Position;
				GridOrientation orientation_ = _selectedGridObject.GridObject.orientation_;
				bool useEditGrid = UseEditGrid;
				GridObjectScript selectedGridObject3 = _selectedGridObject;
				GridScript _003CGridScript_003Ek__BackingField2 = selectedGridObject3.GridScript;
				if ((object)_003CGridScript_003Ek__BackingField2 != null)
				{
					int num3 = 0;
					if ((object)_003CGridScript_003Ek__BackingField2 != null)
					{
						GridOrientation orientation_2 = selectedGridObject3.GridObject.orientation_;
					}
				}
				GridOrientation orientation_3 = selectedGridObject3.GridObject.orientation_;
				if (orientation_3 != 0 && orientation_3 != 0)
				{
					switch (orientation_3)
					{
					}
				}
				Color[] array = new Color[(object)_003CGridScript_003Ek__BackingField2];
				int num4 = 0;
				int num5 = 0;
				GridPosition gridPosition = default(GridPosition);
				int x = gridPosition.X;
				if ((object)gridPosition == null)
				{
				}
				if ((long)gridPosition == 12)
				{
					int itemID = _selectedGridObject.GridObject.ItemID;
					bool flag = default(bool);
					if (!flag)
					{
					}
				}
				Color gridAreaConflictColor = _gridAreaConflictColor;
				num4 += 2;
				num4 += num4;
				((Color*)(IntPtr)array)->r = (float)gridAreaConflictColor;
				num5++;
				num4++;
				GridAreaRenderer gridAreaRenderer2 = this.gridAreaRenderer;
				GridAreaRenderer gridAreaRenderer3 = this.gridAreaRenderer;
				bool flag2 = default(bool);
				if (!flag2)
				{
					Transform transform = gridAreaRenderer3.transform;
					Quaternion identity = Quaternion.identity;
				}
				Transform transform2 = gridAreaRenderer3.transform;
				Transform gridOrigin = _selectedGridObject.GridScript.GridOrigin;
				List<Renderer> list = (List<Renderer>)(object)ComponentCache<ComponentType>.op_Implicit((ComponentCache<>)(object)selectedObjectDitheredRenderers);
				float objectWithConflictDitheringValue = _objectWithConflictDitheringValue;
				GridObjectGizmoSystem.EnableConflictDithering((List<>)(object)list, objectWithConflictDitheringValue);
				return;
			}
			GridObjectGizmoSystem.DisableConflictDithering(ComponentCache<ComponentType>.op_Implicit((ComponentCache<>)(object)selectedObjectDitheredRenderers));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001313")]
		[Cpp2IlInjected.Address(RVA = "0xCFB7E0", Offset = "0xCFA1E0", VA = "0x180CFB7E0")]
		private static void EnableConflictDithering(List<Renderer> renderers, float ditherValue)
		{
			//Discarded unreachable code: IL_0027, IL_002d, IL_0033, IL_0039
			//IL_001f: Expected O, but got I4
			//IL_001f: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (renderers != null && flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				uint num2 = default(uint);
				while (num2 == 2)
				{
				}
				int num3 = 0;
				if (!((UnityEngine.Object)num == (UnityEngine.Object)num3))
				{
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001314")]
		[Cpp2IlInjected.Address(RVA = "0xCFB470", Offset = "0xCF9E70", VA = "0x180CFB470")]
		private static void DisableConflictDithering(List<Renderer> renderers)
		{
			//Discarded unreachable code: IL_0033, IL_0039, IL_003f, IL_0045
			//IL_001f: Expected O, but got I4
			//IL_001f: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (renderers == null || !flag)
			{
				return;
			}
			bool flag2 = default(bool);
			while (!flag2)
			{
			}
			uint num2 = default(uint);
			while (num2 == 2)
			{
			}
			int num3 = 0;
			if (!((UnityEngine.Object)num == (UnityEngine.Object)num3))
			{
				int num4 = wallObjectKey;
				bool flag3 = default(bool);
				if (!flag3)
				{
					return;
				}
			}
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6001315")]
		[Cpp2IlInjected.Address(RVA = "0xCFC6E0", Offset = "0xCFB0E0", VA = "0x180CFC6E0")]
		protected (GridPosition, GridOrientation, bool, GridScript) GetGridTransform(Item item, Vector3 groundPosition, GridArea gridArea, bool findValidPosition)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001316")]
		[Cpp2IlInjected.Address(RVA = "0xCFBC40", Offset = "0xCFA640", VA = "0x180CFBC40")]
		protected GridPosition GetDuplicatePosition(in Vector3 current3DPosition, in GridPosition currentGridPosition, in GridOrientation currentGridOrientation, in GridArea gridArea, GridScript gridScriptToUse)
		{
			Transform transform = playerCamera.transform;
			Vector3 right = Vector3.right;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				Vector3 back = Vector3.back;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				bool flag2 = default(bool);
				if (flag2)
				{
					Vector3 forward = Vector3.forward;
					Vector3 vector3 = default(Vector3);
					float z3 = vector3.z;
					bool flag3 = default(bool);
					if (flag3)
					{
						Vector3 left = Vector3.left;
						Vector3 vector4 = default(Vector3);
						float z4 = vector4.z;
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001317")]
		[Cpp2IlInjected.Address(RVA = "0xCFE1C0", Offset = "0xCFCBC0", VA = "0x180CFE1C0")]
		protected GridPosition GetMetaGridPosition(Vector3 worldPosition, GridOrientation gridOrientation, GridArea gridArea)
		{
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			int num = (int)gridOrientation;
			int num2 = default(int);
			num = num2;
			float z = Vector3.right.z;
			Vector3 forward = Vector3.forward;
			int num3 = 0;
			Vector2Int zero = Vector2Int.zero;
			GridPosition metaGridSize = _metaGridSize;
			int num4 = default(int);
			metaGridSize -= num4;
			int y = _metaGridSize.Y;
			y -= num;
			GridPosition result = default(GridPosition);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001318")]
		[Cpp2IlInjected.Address(RVA = "0xCFE390", Offset = "0xCFCD90", VA = "0x180CFE390")]
		protected GridPosition GetMetaGridPosition(Vector3 worldPosition)
		{
			int num = 0;
			Vector2Int zero = Vector2Int.zero;
			GridPosition metaGridSize = _metaGridSize;
			float z = worldPosition.z;
			int y = _metaGridSize.Y;
			GridPosition result = default(GridPosition);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001319")]
		[Cpp2IlInjected.Address(RVA = "0xCFE0F0", Offset = "0xCFCAF0", VA = "0x180CFE0F0")]
		private GridPosition GetMetaGridPosition(Vector3 worldPosition, Vector2Int min, Vector2Int max)
		{
			float z = worldPosition.z;
			float z2 = metaGridOrigin.z;
			int x = max.m_X;
			int x2 = min.m_X;
			int value = default(int);
			int num = Mathf.Clamp(value, x2, x);
			value = Mathf.RoundToInt(z);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600131A")]
		[Cpp2IlInjected.Address(RVA = "0xCFC510", Offset = "0xCFAF10", VA = "0x180CFC510")]
		protected GridScript GetFirstValidGridForPosition(in GridPosition metaGridPosition, Func<GridScript, bool> validityCheck)
		{
			//IL_0039: Expected O, but got I4
			Dictionary<GridPosition, List<GridScript>> availableGridsForPosition = _availableGridsForPosition;
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				bool flag2 = default(bool);
				if (!flag2)
				{
				}
				int num2 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			int allowVoid = 0;
			GridScript mainGridForPosition = GetMainGridForPosition(in metaGridPosition, (byte)allowVoid != 0);
			int num3 = 0;
			if (!(mainGridForPosition != (UnityEngine.Object)num3) || validityCheck((T)mainGridForPosition) != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600131B")]
		[Cpp2IlInjected.Address(RVA = "0xCFDD70", Offset = "0xCFC770", VA = "0x180CFDD70")]
		protected unsafe GridScript GetMainGridForPosition(in GridPosition metaGridPosition, bool allowVoid = false)
		{
			//IL_007e: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			//IL_009f: Expected O, but got I4
			(RectInt, GridScript)[] array = mainGridScripts;
			int num = 0;
			if (num < array.Length)
			{
				int num2 = 0;
				bool flag = default(bool);
				if (!flag)
				{
					(RectInt, GridScript)[] array2 = mainGridScripts;
					int y = metaGridPosition.Y;
					bool flag2 = default(bool);
					if (flag2)
					{
						(RectInt, GridScript)[] array3 = mainGridScripts;
						float z = metaGridOrigin.z;
						Vector3 vector = default(Vector3);
						float z2 = vector.z;
						GridPosition gridPosition = metaGridPosition - *(GridPosition*)num;
						(RectInt, GridScript)[] array4 = mainGridScripts;
						GridData gridData = default(GridData);
						int num3 = (int)gridData[gridPosition];
						bool flag3 = default(bool);
						if (!flag3)
						{
							goto IL_0095;
						}
						if (allowVoid)
						{
							int num4 = 0;
							if ((UnityEngine.Object)num == (UnityEngine.Object)num4)
							{
								(RectInt, GridScript)[] array5 = mainGridScripts;
							}
						}
					}
				}
				(RectInt, GridScript)[] array6 = mainGridScripts;
				num++;
				goto IL_0095;
			}
			throw new NullReferenceException();
			IL_0095:
			(RectInt, GridScript)[] array7 = mainGridScripts;
			return (GridScript)0;
		}

		[Cpp2IlInjected.Token(Token = "0x600131C")]
		[Cpp2IlInjected.Address(RVA = "0xCFC110", Offset = "0xCFAB10", VA = "0x180CFC110")]
		protected unsafe GridScript GetFirstValidGridAround(GridPosition metaGridPosition)
		{
			//IL_0046: Expected O, but got I4
			//IL_006f: Expected O, but got I4
			//IL_009f: Expected O, but got I4
			//IL_00d8: Expected O, but got I4
			//IL_00fb: Expected O, but got I4
			GridScript gridScript = default(GridScript);
			int num5 = default(int);
			GridScript gridScript2 = default(GridScript);
			GridScript gridScript3 = default(GridScript);
			while (true)
			{
				int num = 0;
				int x = metaGridPosition.X;
				int num2 = 0;
				int y = _metaGridSize.Y;
				y = Math.Min(metaGridPosition.X, y);
				int num3 = Math.Max(0, y);
				if (typeof(UnityEngine.Object).TypeHandle < _metaGridSize)
				{
					int num4 = 0;
					if (gridScript != (UnityEngine.Object)num4)
					{
						return gridScript;
					}
				}
				if (1 > 0)
				{
					num3--;
					if (typeof(UnityEngine.Object).TypeHandle < _metaGridSize)
					{
						num5 = 0;
						if (gridScript2 != (UnityEngine.Object)num5)
						{
							continue;
						}
					}
					num++;
				}
				if (1 > 0)
				{
					if ((long)num5 < (long)(IntPtr)_metaGridSize)
					{
						int allowVoid = 0;
						GridScript mainGridForPosition = GetMainGridForPosition(in *(GridPosition*)num5, (byte)allowVoid != 0);
						int num6 = 0;
						if (mainGridForPosition != (UnityEngine.Object)num6)
						{
							continue;
						}
					}
					num++;
				}
				if (1 > 0)
				{
					num3++;
					if ((long)num5 < (long)(IntPtr)_metaGridSize)
					{
						int allowVoid2 = 0;
						GridScript mainGridForPosition2 = GetMainGridForPosition(in *(GridPosition*)num5, (byte)allowVoid2 != 0);
						int num7 = 0;
						if (mainGridForPosition2 != (UnityEngine.Object)num7)
						{
							continue;
						}
					}
					num++;
				}
				if (1 <= 0)
				{
					break;
				}
				if (1L < (long)(IntPtr)_metaGridSize)
				{
					int num8 = 0;
					if (gridScript3 != (UnityEngine.Object)num8)
					{
						continue;
					}
				}
				num++;
				break;
			}
			int num9 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600131D")]
		[Cpp2IlInjected.Address(RVA = "0xCF9A50", Offset = "0xCF8450", VA = "0x180CF9A50")]
		protected void AddGridToPosition(in GridPosition metaGridPosition, GridScript gridScript)
		{
			//Discarded unreachable code: IL_0021
			Dictionary<GridPosition, List<GridScript>> availableGridsForPosition = _availableGridsForPosition;
			bool flag = default(bool);
			if (!flag)
			{
				List<GridScript> list = (List<GridScript>)(object)new List<T>(2);
				Dictionary<GridPosition, List<GridScript>> availableGridsForPosition2 = _availableGridsForPosition;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600131E")]
		[Cpp2IlInjected.Address(RVA = "0xD02EC0", Offset = "0xD018C0", VA = "0x180D02EC0")]
		protected void RemoveGridFromPosition(in GridPosition metaGridPosition, GridScript gridScript)
		{
			//Discarded unreachable code: IL_000c
			Dictionary<GridPosition, List<GridScript>> availableGridsForPosition = _availableGridsForPosition;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600131F")]
		[Cpp2IlInjected.Address(RVA = "0xCF9F00", Offset = "0xCF8900", VA = "0x180CF9F00")]
		protected void AddObjectToLimitedAmounts(Item item)
		{
			VillageObjectLimit villageObjectLimit = currentAmounts;
			if (villageObjectLimit != null)
			{
				villageObjectLimit.AddObject(item);
				VillageObjectLimitChangedDelegate villageObjectLimitChangedEvent = this.VillageObjectLimitChangedEvent;
				if (villageObjectLimitChangedEvent != null)
				{
					VillageObjectLimitData limits = currentLimits;
					VillageObjectLimit currentAmount = currentAmounts;
					villageObjectLimitChangedEvent(currentAmount, limits);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001320")]
		[Cpp2IlInjected.Address(RVA = "0xD02F60", Offset = "0xD01960", VA = "0x180D02F60")]
		protected void RemoveObjectFromLimitedAmounts(Item item)
		{
			VillageObjectLimit villageObjectLimit = currentAmounts;
			if (villageObjectLimit != null)
			{
				villageObjectLimit.RemoveObject(item);
				VillageObjectLimitChangedDelegate villageObjectLimitChangedEvent = this.VillageObjectLimitChangedEvent;
				if (villageObjectLimitChangedEvent != null)
				{
					VillageObjectLimitData limits = currentLimits;
					VillageObjectLimit currentAmount = currentAmounts;
					villageObjectLimitChangedEvent(currentAmount, limits);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001321")]
		[Cpp2IlInjected.Address(RVA = "0xD004F0", Offset = "0xCFEEF0", VA = "0x180D004F0")]
		private void OnObjectAmountsChanged()
		{
			VillageObjectLimitChangedDelegate villageObjectLimitChangedEvent = this.VillageObjectLimitChangedEvent;
			if (villageObjectLimitChangedEvent != null)
			{
				VillageObjectLimitData limits = currentLimits;
				VillageObjectLimit currentAmount = currentAmounts;
				villageObjectLimitChangedEvent(currentAmount, limits);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001322")]
		[Cpp2IlInjected.Address(RVA = "0xD032E0", Offset = "0xD01CE0", VA = "0x180D032E0")]
		protected Task<bool> RequestClearingPermission()
		{
			return (Task<bool>)(object)Task.FromResult(result: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6001323")]
		[Cpp2IlInjected.Address(RVA = "0xD037B0", Offset = "0xD021B0", VA = "0x180D037B0")]
		public void SetNewMovementRestriction(IGridMovementRestriction gridMovementRestriction)
		{
			if (gridMovementRestriction == null || (long)_currentGridMovementRestriction == 0)
			{
				CurrentMovementRestriction = gridMovementRestriction;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001324")]
		[Cpp2IlInjected.Address(RVA = "0xD02A90", Offset = "0xD01490", VA = "0x180D02A90")]
		private void PrepareInitialCameraTransition()
		{
			Transform transform = playerCameraTransform;
			Transform startCameraTransform = StartCameraTransform;
			Transform transform2 = playerCameraTransform;
			int num = 0;
			Transform _003Ctransform_003Ek__BackingField = SystemRoot.Instance._avatar.transform;
			Transform transform3 = playerCameraTransform;
			PlayerAvatar playerAvatar = avatar;
			FreeCameraControl freeCameraControl = cameraNav;
			Transform _003Ctransform_003Ek__BackingField2 = playerAvatar.transform;
			Vector3 position = transform3.position;
			FreeCameraControl freeCameraControl2 = cameraNav;
			CameraNavigationConfig cameraConfig = _cameraConfig;
			float num2 = freeCameraControl2.DesiredPitch(cameraConfig);
			Transform transform4 = playerCameraTransform;
			Transform transform5 = playerCameraTransform;
			Transform transform6 = playerCameraTransform;
			CancellationToken activeCancellationToken = this.GetOrAddComponent<CancellationTokenProvider>().ActiveCancellationToken;
			Task task = default(Task);
			cameraTransitionTask = task;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001325")]
		[Cpp2IlInjected.Address(RVA = "0xCFBA40", Offset = "0xCFA440", VA = "0x180CFBA40", Slot = "31")]
		protected virtual IEnumerable<GridScript> FilterGrids(GridScript[] allGridScriptsWithoutFilters)
		{
			Func<GridScript, bool> _003C_003E9__209_ = _003C_003Ec._003C_003E9__209_0;
			if (_003C_003E9__209_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((GridScript x) => !x.Locked);
			}
			return (IEnumerable<GridScript>)Enumerable.Where<GridScript>((IEnumerable<>)(object)allGridScriptsWithoutFilters, (Func<, >)(object)_003C_003E9__209_);
		}

		[Cpp2IlInjected.Token(Token = "0x6001326")]
		[Cpp2IlInjected.Address(RVA = "0xCFBB60", Offset = "0xCFA560", VA = "0x180CFBB60", Slot = "32")]
		protected virtual Boundaries[] GetCameraBoundaries(GameObject sceneRoot, GridScript[] allGridScripts)
		{
			//Discarded unreachable code: IL_0020
			Boundaries[] array;
			Boundaries componentInChildren;
			do
			{
				array = new Boundaries[1];
				componentInChildren = sceneRoot.GetComponentInChildren<Boundaries>();
			}
			while ((object)componentInChildren != null && (object)componentInChildren == null);
			array[0] = componentInChildren;
			return array;
		}

		[Cpp2IlInjected.Token(Token = "0x6001327")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("VisualDebugGridObjectGizmoSystem")]
		private static void DebugDrawMovePosition(Vector3 position)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001328")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("VisualDebugGridObjectGizmoSystem")]
		private static void DebugDrawGridAndPosition(GridScript usedGridScript, GridPosition mainGridPosition, GridArea gridArea)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001329")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("VisualDebugGridObjectGizmoSystem")]
		private static void DebugDrawGridPosition(GridScript usedGridScript, GridPosition mainGridPosition)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600132A")]
		[Cpp2IlInjected.Address(RVA = "0xD03340", Offset = "0xD01D40", VA = "0x180D03340")]
		public void ResetCursorPosition()
		{
			int num = 0;
			int width = Screen.width;
			int num2 = 0;
			int height = Screen.height;
		}

		[Cpp2IlInjected.Token(Token = "0x600132B")]
		[Cpp2IlInjected.Address(RVA = "0xCFBC30", Offset = "0xCFA630", VA = "0x180CFBC30")]
		private GridEditModeInputConfig GetCurrentInputConfig()
		{
			return InputConfig;
		}

		[Cpp2IlInjected.Token(Token = "0x600132C")]
		[Cpp2IlInjected.Address(RVA = "0xD06720", Offset = "0xD05120", VA = "0x180D06720")]
		protected unsafe GridObjectGizmoSystem()
		{
			//IL_0058: Expected O, but got F4
			//IL_0060: Expected native int or pointer, but got O
			Color green = Color.green;
			Color yellow = Color.yellow;
			Color red = Color.red;
			_minimumGroundMovementToStartMovingObject = 0.5f;
			_objectWithConflictDitheringValue = 0.5f;
			_inputDetection = new InputDetectionHelper();
			int num = 0;
			UpdateCursor = true;
			int width = Screen.width;
			int num2 = 0;
			int height = Screen.height;
			float num3 = default(float);
			CursorPosition = (Vector2)num3;
			float y = default(float);
			((Vector2*)(IntPtr)CursorPosition)->y = y;
			blockingTasks = (List<Task>)(object)new List<T>();
			validPositions = (List<GridPosition>)(object)new List<T>();
			invalidPositionResultCache = (Dictionary<(GridScript, GridPosition, GridOrientation), GridPosition>)(object)new Dictionary<TKey, TValue>();
			validPositionCache = (Dictionary<(GridScript, GridPosition, GridOrientation), bool>)(object)new Dictionary<TKey, TValue>();
			base._002Ector();
		}
	}
}
