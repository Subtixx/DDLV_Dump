using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf.Collections;
using Mdl.Decals;
using Mdl.Gestures;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta.Customization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x2000914")]
	public class DecalEditView : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000915")]
		public delegate void SaveDesign(DesignWorkingCopy design);

		[Cpp2IlInjected.Token(Token = "0x2000916")]
		private enum Mode
		{
			[Cpp2IlInjected.Token(Token = "0x40035BE")]
			Default,
			[Cpp2IlInjected.Token(Token = "0x40035BF")]
			Move,
			[Cpp2IlInjected.Token(Token = "0x40035C0")]
			Scale,
			[Cpp2IlInjected.Token(Token = "0x40035C1")]
			Rotate,
			[Cpp2IlInjected.Token(Token = "0x40035C2")]
			View
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400358F")]
		private Vector2 _startPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003590")]
		private Vector2 _scaleOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003591")]
		private float _startScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4003592")]
		private float _startAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003593")]
		public bool isTool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4003594")]
		public float projectorDistance = 0.6f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003595")]
		public float tapDragTolerance = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4003596")]
		public float tapMaxDuration = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003597")]
		[SerializeField]
		private RectTransform _inputZone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003598")]
		[SerializeField]
		private DecalTransformGizmo _gizmo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003599")]
		[SerializeField]
		private RawImage _outOfMeshImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400359A")]
		[SerializeField]
		private DecalLibraryView _library;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400359B")]
		[SerializeField]
		private DecalLayerView _layers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400359C")]
		[SerializeField]
		private ColorPicker _colorPicker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400359D")]
		[SerializeField]
		private SlidingPanel _colorPickerPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400359E")]
		[SerializeField]
		private Button _cameraViewButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400359F")]
		[SerializeField]
		private Toggle _seeThroughToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40035A0")]
		[SerializeField]
		private Toggle _cutoutToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40035A1")]
		[SerializeField]
		private Toggle _mirrorToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40035A2")]
		[SerializeField]
		private Toggle _uvSpaceToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40035A3")]
		[SerializeField]
		private Toggle _repeatToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40035A4")]
		[SerializeField]
		private Button _flipButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40035A5")]
		[SerializeField]
		private Button _undoButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40035A6")]
		[SerializeField]
		private Button _redoButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40035A7")]
		[SerializeField]
		private Button _saveButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40035A8")]
		[SerializeField]
		private Button _saveToFileButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40035A9")]
		[SerializeField]
		private Button _loadFromFileButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40035AC")]
		public SaveDesign OnSaveDesign;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40035AD")]
		private MoveGesture _move;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40035AE")]
		private TouchGesture _touch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40035AF")]
		private TapGesture _tap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40035B0")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40035B1")]
		private OrbitCamera _orbitCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40035B2")]
		private OrbitCameraTarget _target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40035B3")]
		private DecalRenderingTool _renderTool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40035B4")]
		private Collider _collider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40035B5")]
		private IList<IDecal> _staticDecals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40035B6")]
		private Vector2 _lastScreenPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40035B7")]
		private RaycastHit? _lastHit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40035B8")]
		private DecalView _currentDecal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40035B9")]
		private int _currentView = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40035BA")]
		private Coroutine _drawAllCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40035BB")]
		private Mode _mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
		[Cpp2IlInjected.Token(Token = "0x40035BC")]
		private bool _constructed;

		[Cpp2IlInjected.Token(Token = "0x170007E7")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xD8"), Cpp2IlInjected.Token(Token = "0x40035AA")]
		public bool IsShown
		{
			[Cpp2IlInjected.Token(Token = "0x6003911")]
			[Cpp2IlInjected.Address(RVA = "0x12AAE10", Offset = "0x12A9810", VA = "0x1812AAE10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003912")]
			[Cpp2IlInjected.Address(RVA = "0x12AAE20", Offset = "0x12A9820", VA = "0x1812AAE20")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007E8")]
		public HistoryStack<DesignWorkingCopy> DesignHistory
		{
			[Cpp2IlInjected.Token(Token = "0x6003913")]
			[Cpp2IlInjected.Address(RVA = "0x738AC0", Offset = "0x7374C0", VA = "0x180738AC0")]
			[CompilerGenerated]
			get
			{
				return _003CDesignHistory_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003914")]
			[Cpp2IlInjected.Address(RVA = "0x976550", Offset = "0x974F50", VA = "0x180976550")]
			[CompilerGenerated]
			private set
			{
				_003CDesignHistory_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003907")]
		[Cpp2IlInjected.Address(RVA = "0x12A9F60", Offset = "0x12A8960", VA = "0x1812A9F60")]
		private unsafe void StartMoveMode()
		{
			//Discarded unreachable code: IL_0067
			//IL_002f: Expected native int or pointer, but got O
			//IL_0066: Expected I4, but got I8
			TouchGesture touch = _touch;
			Vector2 _003CScreenPos_003Ek__BackingField = touch.ScreenPos;
			float y = touch.ScreenPos.y;
			DecalRenderingTool renderTool = _renderTool;
			_lastScreenPos = _003CScreenPos_003Ek__BackingField;
			((Vector2*)(IntPtr)_lastScreenPos)->y = y;
			DecalRenderingTool renderTool2 = _renderTool;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			float z2 = UnityEngine.Vector3.forward.z;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z3 = vector2.z;
			int num = 0;
			_mode = Mode.Move;
		}

		[Cpp2IlInjected.Token(Token = "0x6003908")]
		[Cpp2IlInjected.Address(RVA = "0x12A82F0", Offset = "0x12A6CF0", VA = "0x1812A82F0")]
		private unsafe void MoveMode()
		{
			//Discarded unreachable code: IL_0176
			//IL_003d: Expected native int or pointer, but got O
			while (true)
			{
				if (_move != null)
				{
				}
				TouchGesture touch = _touch;
				if (touch.Phase == TouchGesture.PhaseType.Began)
				{
					Vector2 _003CScreenPos_003Ek__BackingField = touch.ScreenPos;
					float y = touch.ScreenPos.y;
					_lastScreenPos = _003CScreenPos_003Ek__BackingField;
					((Vector2*)(IntPtr)_lastScreenPos)->y = y;
					DecalTransformGizmo gizmo = _gizmo;
					Vector2 _003CScreenPos_003Ek__BackingField2 = touch.ScreenPos;
					float y2 = touch.ScreenPos.y;
					if (gizmo.PointIsInScaleZone(_003CScreenPos_003Ek__BackingField2))
					{
						StartEditMode(Mode.Scale);
						return;
					}
					TouchGesture touch2 = _touch;
					DecalTransformGizmo gizmo2 = _gizmo;
					Vector2 _003CScreenPos_003Ek__BackingField3 = touch2.ScreenPos;
					float y3 = touch2.ScreenPos.y;
					if (gizmo2.PointIsInRotateZone(_003CScreenPos_003Ek__BackingField3))
					{
						StartEditMode(Mode.Rotate);
						return;
					}
					TouchGesture touch3 = _touch;
					DecalTransformGizmo gizmo3 = _gizmo;
					Vector2 _003CScreenPos_003Ek__BackingField4 = touch3.ScreenPos;
					float y4 = touch3.ScreenPos.y;
					if (!gizmo3.PointIsInMoveZone(_003CScreenPos_003Ek__BackingField4))
					{
						StartOrbitAroundMode();
						return;
					}
				}
				if (_touch.Phase != TouchGesture.PhaseType.Ended)
				{
					break;
				}
				if (_outOfMeshImage.gameObject.activeSelf)
				{
					DesignWorkingCopy designWorkingCopy = new DesignWorkingCopy((DesignWorkingCopy)((HistoryStack<T>)(object)DesignHistory).Current);
					int _003CLayer_003Ek__BackingField = _currentDecal.Layer;
					if (_003CLayer_003Ek__BackingField != -1)
					{
						((RepeatedField<T>)(object)designWorkingCopy.Data.decals_).RemoveAt(_003CLayer_003Ek__BackingField);
						DecalLayerView layers = _layers;
						Design _003CData_003Ek__BackingField = designWorkingCopy.Data;
						layers.Refresh(_003CData_003Ek__BackingField);
						((HistoryStack<T>)(object)DesignHistory).Push((T)designWorkingCopy);
					}
					Cancel();
					return;
				}
			}
			Move();
		}

		[Cpp2IlInjected.Token(Token = "0x6003909")]
		[Cpp2IlInjected.Address(RVA = "0x12A87C0", Offset = "0x12A71C0", VA = "0x1812A87C0")]
		private void Move()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600390A")]
		[Cpp2IlInjected.Address(RVA = "0x12A9DA0", Offset = "0x12A87A0", VA = "0x1812A9DA0")]
		private unsafe void StartEditMode(Mode mode)
		{
			//Discarded unreachable code: IL_00a7
			//IL_0045: Expected native int or pointer, but got O
			//IL_0078: Expected native int or pointer, but got O
			TouchGesture touch = _touch;
			DecalTransformGizmo gizmo = _gizmo;
			Vector2 _003CScreenPos_003Ek__BackingField = touch.ScreenPos;
			float y = touch.ScreenPos.y;
			Vector2 vector = gizmo.ScreenToLocal(_003CScreenPos_003Ek__BackingField);
			DecalTransformGizmo gizmo2 = _gizmo;
			_startPos = vector;
			((Vector2*)(IntPtr)_startPos)->y = y;
			RectTransform rect = gizmo2._rect;
			RectTransform rect2 = _gizmo._rect;
			DecalRenderingTool renderTool = _renderTool;
			_scaleOffset = vector;
			((Vector2*)(IntPtr)_scaleOffset)->y = y;
			float num = (_startScale = renderTool.size);
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float num2 = (_startAngle = vector2.z);
			_mode = mode;
		}

		[Cpp2IlInjected.Token(Token = "0x600390B")]
		[Cpp2IlInjected.Address(RVA = "0x12AA440", Offset = "0x12A8E40", VA = "0x1812AA440")]
		private void StartScaleMode()
		{
			StartEditMode(Mode.Scale);
		}

		[Cpp2IlInjected.Token(Token = "0x600390C")]
		[Cpp2IlInjected.Address(RVA = "0x12AA430", Offset = "0x12A8E30", VA = "0x1812AA430")]
		private void StartRotateMode()
		{
			StartEditMode(Mode.Rotate);
		}

		[Cpp2IlInjected.Token(Token = "0x600390D")]
		[Cpp2IlInjected.Address(RVA = "0x12A93A0", Offset = "0x12A7DA0", VA = "0x1812A93A0")]
		private void RotateMode()
		{
			TouchGesture touch = _touch;
			if (touch.Phase != TouchGesture.PhaseType.Ended)
			{
				Vector2 _003CScreenPos_003Ek__BackingField = touch.ScreenPos;
				DecalTransformGizmo gizmo = _gizmo;
				float y = touch.ScreenPos.y;
				Vector2 vector = gizmo.ScreenToLocal(_003CScreenPos_003Ek__BackingField);
				RectTransform rect = _gizmo._rect;
				DecalRenderingTool renderTool = _renderTool;
				float num = default(float);
				y = num;
				renderTool.Roll(y);
				return;
			}
			StartMoveMode();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600390E")]
		[Cpp2IlInjected.Address(RVA = "0x12A9570", Offset = "0x12A7F70", VA = "0x1812A9570")]
		private void ScaleMode()
		{
			//Discarded unreachable code: IL_0054
			TouchGesture touch = _touch;
			if (touch.Phase != TouchGesture.PhaseType.Ended)
			{
				DecalTransformGizmo gizmo = _gizmo;
				Vector2 _003CScreenPos_003Ek__BackingField = touch.ScreenPos;
				float y = touch.ScreenPos.y;
				Vector2 vector = gizmo.ScreenToLocal(_003CScreenPos_003Ek__BackingField);
				RectTransform rect = _gizmo._rect;
				_renderTool.Size = y;
			}
			else
			{
				StartMoveMode();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600390F")]
		[Cpp2IlInjected.Address(RVA = "0x12AA150", Offset = "0x12A8B50", VA = "0x1812AA150")]
		private void StartOrbitAroundMode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003910")]
		[Cpp2IlInjected.Address(RVA = "0x12A8EE0", Offset = "0x12A78E0", VA = "0x1812A8EE0")]
		private void OrbitAroundMode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003915")]
		[Cpp2IlInjected.Address(RVA = "0x12A6F30", Offset = "0x12A5930", VA = "0x1812A6F30")]
		private void Construct()
		{
			//Discarded unreachable code: IL_031e
			//IL_0020: Expected O, but got I4
			//IL_02b9: Expected I4, but got I8
			//IL_02b9: Expected O, but got I4
			//IL_02d6: Expected O, but got I4
			//IL_02f0: Expected O, but got I4
			Camera camera = (_camera = SystemRoot.Instance._playerCamera);
			int allowZoom = default(int);
			int num = default(int);
			OrbitCamera orbitCamera = new OrbitCamera(_camera, (OrbitCameraConfig)num, (byte)allowZoom != 0);
			allowZoom = 0;
			num = 0;
			_orbitCamera = orbitCamera;
			DecalTransformGizmo gizmo = _gizmo;
			DecalTransformGizmo.ConfirmDelegate b = Confirm;
			DecalTransformGizmo.ConfirmDelegate onConfirm = gizmo.OnConfirm;
			Delegate @delegate = Delegate.Combine(onConfirm, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onConfirm)
				{
				}
				Button.ButtonClickedEvent onClick = _cameraViewButton.m_OnClick;
				UnityAction call = NextCameraView;
				onClick.AddListener(call);
				Toggle.ToggleEvent onValueChanged = _seeThroughToggle.onValueChanged;
				UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(ToggleSeeThroughMode);
				((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
				Toggle.ToggleEvent onValueChanged2 = _cutoutToggle.onValueChanged;
				UnityAction<bool> unityAction2 = (UnityAction<bool>)(object)new UnityAction<T0>(ToggleCutoutMode);
				((UnityEvent<T0>)(object)onValueChanged2).AddListener((UnityAction<>)(object)unityAction2);
				Toggle.ToggleEvent onValueChanged3 = _mirrorToggle.onValueChanged;
				UnityAction<bool> unityAction3 = (UnityAction<bool>)(object)new UnityAction<T0>(ToggleMirrorMode);
				((UnityEvent<T0>)(object)onValueChanged3).AddListener((UnityAction<>)(object)unityAction3);
				Toggle.ToggleEvent onValueChanged4 = _uvSpaceToggle.onValueChanged;
				UnityAction<bool> unityAction4 = (UnityAction<bool>)(object)new UnityAction<T0>(ToggleUVSpace);
				((UnityEvent<T0>)(object)onValueChanged4).AddListener((UnityAction<>)(object)unityAction4);
				Toggle.ToggleEvent onValueChanged5 = _repeatToggle.onValueChanged;
				UnityAction<bool> unityAction5 = (UnityAction<bool>)(object)new UnityAction<T0>(ToggleRepeat);
				((UnityEvent<T0>)(object)onValueChanged5).AddListener((UnityAction<>)(object)unityAction5);
				Button.ButtonClickedEvent onClick2 = _flipButton.m_OnClick;
				UnityAction call2 = Flip;
				onClick2.AddListener(call2);
				Button.ButtonClickedEvent onClick3 = _undoButton.m_OnClick;
				UnityAction call3 = Undo;
				onClick3.AddListener(call3);
				Button.ButtonClickedEvent onClick4 = _redoButton.m_OnClick;
				UnityAction call4 = Redo;
				onClick4.AddListener(call4);
				Button.ButtonClickedEvent onClick5 = _saveButton.m_OnClick;
				UnityAction call5 = Save;
				onClick5.AddListener(call5);
				DecalLibraryView library = _library;
				DecalLibraryView.SelectDecal b2 = SelectDecal;
				DecalLibraryView.SelectDecal onDecalSelected = library.OnDecalSelected;
				Delegate delegate2 = Delegate.Combine(onDecalSelected, b2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					while ((object)delegate2 != onDecalSelected)
					{
					}
					DecalLayerView layers = _layers;
					DecalLayerView.SelectDecal b3 = SelectDecal;
					DecalLayerView.SelectDecal onDecalSelected2 = layers.OnDecalSelected;
					Delegate delegate3 = Delegate.Combine(onDecalSelected2, b3);
					if ((object)delegate3 == null || (object)delegate3 != null)
					{
						while ((object)delegate3 != onDecalSelected2)
						{
						}
						DecalLayerView layers2 = _layers;
						DecalLayerView.InsertDecal b4 = InsertDecal;
						DecalLayerView.InsertDecal onInsertDecal = layers2.OnInsertDecal;
						Delegate delegate4 = Delegate.Combine(onInsertDecal, b4);
						if ((object)delegate4 == null || (object)delegate4 != null)
						{
							while ((object)delegate4 != onInsertDecal)
							{
							}
							ColorPicker colorPicker = _colorPicker;
							ColorPicker.ColorChanged value = UpdateColor;
							colorPicker.OnColorChanged += value;
							ulong num3 = default(ulong);
							int automaticRotation = default(int);
							int num2 = default(int);
							MoveGesture move = new MoveGesture(_inputZone, (Camera)num2, (byte)automaticRotation != 0, (byte)num3 != 0);
							automaticRotation = 0;
							num2 = 0;
							_move = move;
							int num4 = default(int);
							TouchGesture touch = new TouchGesture(_inputZone, (Camera)num4);
							num4 = 0;
							_touch = touch;
							int num5 = default(int);
							TapGesture tap = new TapGesture(_inputZone, (Camera)num5);
							num5 = 0;
							_tap = tap;
							GameObject gameObject = _outOfMeshImage.gameObject;
							int active = 0;
							gameObject.SetActive((byte)active != 0);
							_constructed = true;
							return;
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003916")]
		[Cpp2IlInjected.Address(RVA = "0x12A9980", Offset = "0x12A8380", VA = "0x1812A9980")]
		public void Show(UnityEngine.Vector3 cameraPos, OrbitCameraTarget target, DecalRenderingTool renderTool, Collider collider, IList<IDecal> staticDecals, HistoryStack<DesignWorkingCopy> designHistory, float transitionDuration)
		{
			//Discarded unreachable code: IL_018f
			//IL_0022: Expected O, but got I4
			//IL_003e: Expected O, but got I4
			//IL_006f: Expected O, but got I4
			//IL_0086: Expected I4, but got I8
			//IL_00df: Expected F4, but got I8
			//IL_00ec: Expected F4, but got I8
			if (!_constructed)
			{
				Construct();
			}
			base.gameObject.SetActive(value: true);
			DesignHistory = (HistoryStack<DesignWorkingCopy>)0;
			IsShown = true;
			_target = target;
			_renderTool = renderTool;
			_collider = (Collider)0;
			DecalRenderingTool renderTool2 = _renderTool;
			Action<Texture2D> action = (Action<Texture2D>)(object)new Action<T>(UpdateOutOfMeshTexture);
			renderTool2.add_OnCurrentTextureChanged((Action<>)(object)action);
			if (isTool)
			{
				List<IDecal> list = (List<IDecal>)(object)new List<T>();
			}
			_staticDecals = (IList<IDecal>)0;
			DecalLibraryView library = _library;
			_currentView = -1;
			library.Refresh();
			HistoryStack<DesignWorkingCopy> historyStack = DesignHistory;
			DecalLayerView layers = _layers;
			Design _003CData_003Ek__BackingField = ((DesignWorkingCopy)((HistoryStack<T>)(object)historyStack).Current).Data;
			layers.Refresh(_003CData_003Ek__BackingField);
			OrbitCamera orbitCamera = _orbitCamera;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			float z2 = cameraPos.z;
			DrawAll();
			ulong num = default(ulong);
			_move.MaxForce = (long)num;
			_move.Friction = (long)num;
			TapGesture tap = _tap;
			float num2 = (tap.DragTolerance = tapDragTolerance);
			TapGesture tap2 = _tap;
			float num3 = (tap2.MaxDuration = tapMaxDuration);
			Toggle cutoutToggle = _cutoutToggle;
			int num4 = ((cutoutToggle.isOn = false) ? 1 : 0);
			Toggle mirrorToggle = _mirrorToggle;
			int num5 = ((mirrorToggle.isOn = false) ? 1 : 0);
			Toggle seeThroughToggle = _seeThroughToggle;
			int num6 = ((seeThroughToggle.isOn = false) ? 1 : 0);
			Toggle uvSpaceToggle = _uvSpaceToggle;
			int num7 = ((uvSpaceToggle.isOn = false) ? 1 : 0);
			_uvSpaceToggle.interactable = true;
			Toggle repeatToggle = _repeatToggle;
			int num8 = ((repeatToggle.isOn = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003917")]
		[Cpp2IlInjected.Address(RVA = "0x12AA540", Offset = "0x12A8F40", VA = "0x1812AA540")]
		public void Undo()
		{
			//Discarded unreachable code: IL_0052
			//IL_0010: Expected O, but got I4
			DecalView currentDecal = _currentDecal;
			int num = 0;
			if (!(currentDecal != (UnityEngine.Object)num))
			{
				if (((HistoryStack<T>)(object)DesignHistory).Undo())
				{
					HistoryStack<DesignWorkingCopy> historyStack = DesignHistory;
					DecalLayerView layers = _layers;
					Design _003CData_003Ek__BackingField = ((DesignWorkingCopy)((HistoryStack<T>)(object)historyStack).Current).Data;
					layers.Refresh(_003CData_003Ek__BackingField);
					DrawAll();
				}
			}
			else
			{
				Cancel();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003918")]
		[Cpp2IlInjected.Address(RVA = "0x12A92B0", Offset = "0x12A7CB0", VA = "0x1812A92B0")]
		public void Redo()
		{
			//Discarded unreachable code: IL_0051
			//IL_0010: Expected O, but got I4
			DecalView currentDecal = _currentDecal;
			int num = 0;
			if (currentDecal != (UnityEngine.Object)num)
			{
				Cancel();
			}
			if (((HistoryStack<T>)(object)DesignHistory).Redo())
			{
				HistoryStack<DesignWorkingCopy> historyStack = DesignHistory;
				DecalLayerView layers = _layers;
				Design _003CData_003Ek__BackingField = ((DesignWorkingCopy)((HistoryStack<T>)(object)historyStack).Current).Data;
				layers.Refresh(_003CData_003Ek__BackingField);
				DrawAll();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003919")]
		[Cpp2IlInjected.Address(RVA = "0x12A9500", Offset = "0x12A7F00", VA = "0x1812A9500")]
		public void Save()
		{
			//Discarded unreachable code: IL_001f
			SaveDesign onSaveDesign = OnSaveDesign;
			if (onSaveDesign != null)
			{
				DesignWorkingCopy current = (DesignWorkingCopy)((HistoryStack<T>)(object)DesignHistory).Current;
				onSaveDesign(current);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600391A")]
		[Cpp2IlInjected.Address(RVA = "0x12A7A60", Offset = "0x12A6460", VA = "0x1812A7A60")]
		private void DrawAll()
		{
			Coroutine drawAllCoroutine = _drawAllCoroutine;
			if (drawAllCoroutine != null)
			{
				StopCoroutine(drawAllCoroutine);
			}
			List<IDecal> list = (List<IDecal>)(object)new List<T>();
			IList<IDecal> staticDecals = _staticDecals;
			((List<T>)(object)list).AddRange((IEnumerable<>)staticDecals);
			IReadOnlyList<IDecal> decals = (IReadOnlyList<IDecal>)((DesignWorkingCopy)((HistoryStack<T>)(object)DesignHistory).Current).get_Decals();
			((List<T>)(object)list).AddRange((IEnumerable<>)decals);
			int _003C_003E1__state = default(int);
			_003CDrawAllAsync_003Ed__70 _003CDrawAllAsync_003Ed__ = new _003CDrawAllAsync_003Ed__70(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDrawAllAsync_003Ed__._003C_003E4__this = this;
			_003CDrawAllAsync_003Ed__.decals = list;
			Coroutine coroutine = (_drawAllCoroutine = StartCoroutine(_003CDrawAllAsync_003Ed__));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600391B")]
		[Cpp2IlInjected.Address(RVA = "0x12A79D0", Offset = "0x12A63D0", VA = "0x1812A79D0")]
		[IteratorStateMachine(typeof(_003CDrawAllAsync_003Ed__70))]
		private IEnumerator DrawAllAsync(IList<IDecal> decals)
		{
			int _003C_003E1__state = default(int);
			_003CDrawAllAsync_003Ed__70 _003CDrawAllAsync_003Ed__ = new _003CDrawAllAsync_003Ed__70(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDrawAllAsync_003Ed__._003C_003E4__this = this;
			_003CDrawAllAsync_003Ed__.decals = decals;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600391C")]
		[Cpp2IlInjected.Address(RVA = "0x12A7C20", Offset = "0x12A6620", VA = "0x1812A7C20")]
		public void Hide()
		{
			//Discarded unreachable code: IL_013d
			//IL_0010: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			DecalRenderingTool renderTool = _renderTool;
			int num = 0;
			if (renderTool != (UnityEngine.Object)num)
			{
				DecalRenderingTool renderTool2 = _renderTool;
				Action<Texture2D> action = (Action<Texture2D>)(object)new Action<T>(UpdateOutOfMeshTexture);
				renderTool2.remove_OnCurrentTextureChanged((Action<>)(object)action);
			}
			int num2 = 0;
			_currentDecal = (DecalView)num2;
			DecalLibraryView library = _library;
			library.loopScrollRect.totalCount = num2;
			LoopVerticalScrollRect loopScrollRect = library.loopScrollRect;
			int offset = 0;
			loopScrollRect.RefillCells(offset);
			RectTransform content = ((LoopScrollRect)library.loopScrollRect).m_Content;
			int num3 = 0;
			Vector2 vector = (content.anchoredPosition = Vector2.zero);
			_layers.DeselectAll();
			Toggle cutoutToggle = _cutoutToggle;
			int num4 = ((cutoutToggle.isOn = false) ? 1 : 0);
			Toggle mirrorToggle = _mirrorToggle;
			int num5 = ((mirrorToggle.isOn = false) ? 1 : 0);
			Toggle seeThroughToggle = _seeThroughToggle;
			int num6 = ((seeThroughToggle.isOn = false) ? 1 : 0);
			Toggle uvSpaceToggle = _uvSpaceToggle;
			int num7 = ((uvSpaceToggle.isOn = false) ? 1 : 0);
			Toggle repeatToggle = _repeatToggle;
			int num8 = ((repeatToggle.isOn = false) ? 1 : 0);
			GameObject gameObject = _outOfMeshImage.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			_gizmo.Hide();
			_mode = (Mode)num2;
			GameObject gameObject2 = base.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			IsShown = (byte)num2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600391D")]
		[Cpp2IlInjected.Address(RVA = "0x12A7E70", Offset = "0x12A6870", VA = "0x1812A7E70")]
		private void InitConfig()
		{
			//Discarded unreachable code: IL_0079
			OrbitCameraConfig cameraConfig = _target.cameraConfig;
			MoveGesture move = _move;
			float num = (move.MaxForce = cameraConfig.moveMaxForce);
			OrbitCameraConfig cameraConfig2 = _target.cameraConfig;
			MoveGesture move2 = _move;
			float num2 = (move2.Friction = cameraConfig2.moveFriction);
			TapGesture tap = _tap;
			float num3 = (tap.DragTolerance = tapDragTolerance);
			TapGesture tap2 = _tap;
			float num4 = (tap2.MaxDuration = tapMaxDuration);
		}

		[Cpp2IlInjected.Token(Token = "0x600391E")]
		[Cpp2IlInjected.Address(RVA = "0x12AA770", Offset = "0x12A9170", VA = "0x1812AA770")]
		public void UpdateState(float deltaTime)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600391F")]
		[Cpp2IlInjected.Address(RVA = "0x12AA640", Offset = "0x12A9040", VA = "0x1812AA640")]
		private void UpdateColor(Color color)
		{
			//Discarded unreachable code: IL_0040
			//IL_0010: Expected O, but got I4
			DecalView currentDecal = _currentDecal;
			int num = 0;
			if (!(currentDecal == (UnityEngine.Object)num) && !currentDecal.DecalData.allowColoring_)
			{
				DecalRenderingTool renderTool = _renderTool;
				Color white = Color.white;
			}
			else
			{
				ColorPicker colorPicker = _colorPicker;
				DecalRenderingTool renderTool2 = _renderTool;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003920")]
		[Cpp2IlInjected.Address(RVA = "0x12A8CE0", Offset = "0x12A76E0", VA = "0x1812A8CE0")]
		private void NextCameraView()
		{
			//Discarded unreachable code: IL_007d
			//IL_0020: Expected I4, but got I8
			OrbitCameraTarget target = _target;
			List<OrbitCameraTarget.CameraView> cameraViews = target.cameraViews;
			if (_mode != 0)
			{
				_mode = Mode.View;
			}
			List<OrbitCameraTarget.CameraView> cameraViews2 = target.cameraViews;
			int currentView = _currentView;
			OrbitCamera orbitCamera = _orbitCamera;
			currentView++;
			List<OrbitCameraTarget.CameraView> cameraViews3 = target.cameraViews;
			int num = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			num += num;
			OrbitCameraTarget target2 = _target;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			Transform lookAt = target2.lookAt;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z2 = vector2.z;
			OrbitCameraTarget target3 = _target;
		}

		[Cpp2IlInjected.Token(Token = "0x6003921")]
		[Cpp2IlInjected.Address(RVA = "0x12A7BF0", Offset = "0x12A65F0", VA = "0x1812A7BF0")]
		private void Flip()
		{
			//Discarded unreachable code: IL_000c
			_renderTool.ToggleFlip();
		}

		[Cpp2IlInjected.Token(Token = "0x6003922")]
		[Cpp2IlInjected.Address(RVA = "0x12AA480", Offset = "0x12A8E80", VA = "0x1812AA480")]
		private void ToggleMirrorMode(bool isOn)
		{
			//Discarded unreachable code: IL_000d
			_renderTool.ToggleMirrorMode(isOn);
		}

		[Cpp2IlInjected.Token(Token = "0x6003923")]
		[Cpp2IlInjected.Address(RVA = "0x12AA450", Offset = "0x12A8E50", VA = "0x1812AA450")]
		private void ToggleCutoutMode(bool isOn)
		{
			//Discarded unreachable code: IL_000d
			_renderTool.ToggleCutoutMode(isOn);
		}

		[Cpp2IlInjected.Token(Token = "0x6003924")]
		[Cpp2IlInjected.Address(RVA = "0x12AA4E0", Offset = "0x12A8EE0", VA = "0x1812AA4E0")]
		private void ToggleSeeThroughMode(bool isOn)
		{
			//Discarded unreachable code: IL_000d
			_renderTool.ToggleSeeThroughMode(isOn);
		}

		[Cpp2IlInjected.Token(Token = "0x6003925")]
		[Cpp2IlInjected.Address(RVA = "0x12AA510", Offset = "0x12A8F10", VA = "0x1812AA510")]
		private void ToggleUVSpace(bool isOn)
		{
			//Discarded unreachable code: IL_000d
			_renderTool.ToggleUVSpaceMode(isOn);
		}

		[Cpp2IlInjected.Token(Token = "0x6003926")]
		[Cpp2IlInjected.Address(RVA = "0x12AA4B0", Offset = "0x12A8EB0", VA = "0x1812AA4B0")]
		private void ToggleRepeat(bool isOn)
		{
			//Discarded unreachable code: IL_000d
			_renderTool.ToggleRepeatMode(isOn);
		}

		[Cpp2IlInjected.Token(Token = "0x6003927")]
		[Cpp2IlInjected.Address(RVA = "0x12A9690", Offset = "0x12A8090", VA = "0x1812A9690")]
		[AsyncStateMachine(typeof(_003CSelectDecal_003Ed__82))]
		private void SelectDecal(DecalView decal)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		[Cpp2IlInjected.Token(Token = "0x6003928")]
		[Cpp2IlInjected.Address(RVA = "0x12A9790", Offset = "0x12A8190", VA = "0x1812A9790")]
		private void SetColor(DecalView decal)
		{
			//Discarded unreachable code: IL_002f
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(decal == (UnityEngine.Object)num) && !decal.DecalData.allowColoring_)
			{
				Color white = Color.white;
			}
			ColorPicker colorPicker = _colorPicker;
			DecalRenderingTool renderTool = _renderTool;
		}

		[Cpp2IlInjected.Token(Token = "0x6003929")]
		[Cpp2IlInjected.Address(RVA = "0x12A7F00", Offset = "0x12A6900", VA = "0x1812A7F00")]
		[AsyncStateMachine(typeof(_003CInitCurrentLayer_003Ed__84))]
		private Task InitCurrentLayer()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600392A")]
		[Cpp2IlInjected.Address(RVA = "0x12A8000", Offset = "0x12A6A00", VA = "0x1812A8000")]
		[AsyncStateMachine(typeof(_003CInitCurrentLibDecal_003Ed__85))]
		private Task InitCurrentLibDecal()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600392B")]
		[Cpp2IlInjected.Address(RVA = "0x12A9870", Offset = "0x12A8270", VA = "0x1812A9870")]
		private void ShowOutOfMeshImage(Vector2 screenPos)
		{
			//Discarded unreachable code: IL_003f
			_outOfMeshImage.gameObject.SetActive(value: true);
			DecalRenderingTool renderTool = _renderTool;
			RawImage outOfMeshImage = _outOfMeshImage;
			Texture2D texture2D = (Texture2D)(outOfMeshImage.texture = renderTool.CurrentTexture);
			Vector2 anchoredPosition = default(Vector2);
			_outOfMeshImage.GetComponent<RectTransform>().anchoredPosition = anchoredPosition;
		}

		[Cpp2IlInjected.Token(Token = "0x600392C")]
		[Cpp2IlInjected.Address(RVA = "0x12AA750", Offset = "0x12A9150", VA = "0x1812AA750")]
		private void UpdateOutOfMeshTexture(Texture2D texture)
		{
			//Discarded unreachable code: IL_000d
			_outOfMeshImage.texture = texture;
		}

		[Cpp2IlInjected.Token(Token = "0x600392D")]
		[Cpp2IlInjected.Address(RVA = "0x12A8100", Offset = "0x12A6B00", VA = "0x1812A8100")]
		private void InsertDecal(DecalView decal, int index)
		{
			//Discarded unreachable code: IL_00ad
			//IL_0010: Expected O, but got I4
			DecalView currentDecal = _currentDecal;
			int num = 0;
			if (currentDecal != (UnityEngine.Object)num)
			{
				Cancel();
			}
			DesignWorkingCopy designWorkingCopy = new DesignWorkingCopy((DesignWorkingCopy)((HistoryStack<T>)(object)DesignHistory).Current);
			RepeatedField<Decal> decals_ = designWorkingCopy.Data.decals_;
			int _003CLayer_003Ek__BackingField = decal.Layer;
			Decal item = (Decal)((RepeatedField<T>)(object)decals_)[_003CLayer_003Ek__BackingField];
			RepeatedField<Decal> decals_2 = designWorkingCopy.Data.decals_;
			int _003CLayer_003Ek__BackingField2 = decal.Layer;
			((RepeatedField<T>)(object)decals_2).RemoveAt(_003CLayer_003Ek__BackingField2);
			RepeatedField<Decal> decals_3 = designWorkingCopy.Data.decals_;
			_003CLayer_003Ek__BackingField2 = index;
			((RepeatedField<T>)(object)decals_3).Insert(_003CLayer_003Ek__BackingField2, (T)item);
			((HistoryStack<T>)(object)DesignHistory).Push((T)designWorkingCopy);
			DecalLayerView layers = _layers;
			Design _003CData_003Ek__BackingField = designWorkingCopy.Data;
			layers.Refresh(_003CData_003Ek__BackingField);
			DrawAll();
		}

		[Cpp2IlInjected.Token(Token = "0x600392E")]
		[Cpp2IlInjected.Address(RVA = "0x12A6D10", Offset = "0x12A5710", VA = "0x1812A6D10")]
		private void Confirm()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600392F")]
		[Cpp2IlInjected.Address(RVA = "0x12A78B0", Offset = "0x12A62B0", VA = "0x1812A78B0")]
		private void Delete()
		{
			//Discarded unreachable code: IL_005a
			DesignWorkingCopy designWorkingCopy = new DesignWorkingCopy((DesignWorkingCopy)((HistoryStack<T>)(object)DesignHistory).Current);
			int _003CLayer_003Ek__BackingField = _currentDecal.Layer;
			if (_003CLayer_003Ek__BackingField != -1)
			{
				((RepeatedField<T>)(object)designWorkingCopy.Data.decals_).RemoveAt(_003CLayer_003Ek__BackingField);
				DecalLayerView layers = _layers;
				Design _003CData_003Ek__BackingField = designWorkingCopy.Data;
				layers.Refresh(_003CData_003Ek__BackingField);
				((HistoryStack<T>)(object)DesignHistory).Push((T)designWorkingCopy);
			}
			Cancel();
		}

		[Cpp2IlInjected.Token(Token = "0x6003930")]
		[Cpp2IlInjected.Address(RVA = "0x12A6B10", Offset = "0x12A5510", VA = "0x1812A6B10")]
		private void Cancel()
		{
			//Discarded unreachable code: IL_00f3
			//IL_0009: Expected O, but got I4
			int num = 0;
			_currentDecal = (DecalView)num;
			_library.DeselectAll();
			_layers.DeselectAll();
			Toggle cutoutToggle = _cutoutToggle;
			int num2 = ((cutoutToggle.isOn = false) ? 1 : 0);
			Toggle mirrorToggle = _mirrorToggle;
			int num3 = ((mirrorToggle.isOn = false) ? 1 : 0);
			Toggle seeThroughToggle = _seeThroughToggle;
			int num4 = ((seeThroughToggle.isOn = false) ? 1 : 0);
			Toggle uvSpaceToggle = _uvSpaceToggle;
			int num5 = ((uvSpaceToggle.isOn = false) ? 1 : 0);
			Toggle repeatToggle = _repeatToggle;
			int num6 = ((repeatToggle.isOn = false) ? 1 : 0);
			DrawAll();
			GameObject gameObject = _outOfMeshImage.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			_gizmo.Hide();
			Camera camera = _camera;
			OrbitCamera orbitCamera = _orbitCamera;
			_mode = (Mode)num;
			Transform transform = camera.transform;
			OrbitCameraTarget target = _target;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			Transform lookAt = target.lookAt;
			OrbitCameraTarget target2 = _target;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z2 = vector2.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6003931")]
		[Cpp2IlInjected.Address(RVA = "0x12A8600", Offset = "0x12A7000", VA = "0x1812A8600")]
		private void MoveProjector(RaycastHit hit)
		{
			//Discarded unreachable code: IL_003e
			DecalRenderingTool renderTool = _renderTool;
			Transform transform = _camera.transform;
			Transform transform2 = _camera.transform;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			DecalRenderingTool renderTool2 = _renderTool;
			Transform transform3 = _camera.transform;
		}

		[Cpp2IlInjected.Token(Token = "0x6003932")]
		[Cpp2IlInjected.Address(RVA = "0x12AADE0", Offset = "0x12A97E0", VA = "0x1812AADE0")]
		public DecalEditView()
		{
		}//IL_0031: Expected I4, but got I8

	}
}
