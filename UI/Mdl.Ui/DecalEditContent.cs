using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Avatar;
using Mdl.Decals;
using Mdl.Gestures;
using Mdl.Graphic;
using Mdl.InputSystem;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta.Customization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003FA")]
	[RequiredAllNotNull]
	public class DecalEditContent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20003FB")]
		public delegate void ShowColorPalletDelegate();

		[Cpp2IlInjected.Token(Token = "0x20003FC")]
		public delegate void ShowBaseColorPalletDelegate();

		[Cpp2IlInjected.Token(Token = "0x20003FD")]
		public delegate void SaveDesign(DesignWorkingCopy design);

		[Cpp2IlInjected.Token(Token = "0x20003FE")]
		private enum Mode
		{
			[Cpp2IlInjected.Token(Token = "0x40013E8")]
			Default,
			[Cpp2IlInjected.Token(Token = "0x40013E9")]
			Move,
			[Cpp2IlInjected.Token(Token = "0x40013EA")]
			Scale,
			[Cpp2IlInjected.Token(Token = "0x40013EB")]
			Rotate,
			[Cpp2IlInjected.Token(Token = "0x40013EC")]
			View
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400138B")]
		private Vector2 _startPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400138C")]
		private Vector2 _scaleOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400138D")]
		private float _startScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400138E")]
		private float _startAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001391")]
		public bool isTool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4001392")]
		public float projectorDistance = 0.6f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001393")]
		public float tapDragTolerance = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4001394")]
		public float tapMaxDuration = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001395")]
		[SerializeField]
		private float _undoAllPressDelay = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4001396")]
		[SerializeField]
		private float _gamepadScaleModifier = 0.01f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001397")]
		[SerializeField]
		private float _gamepadMoveModifier = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001398")]
		[Nulllable]
		[SerializeField]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001399")]
		[SerializeField]
		private RectTransform _inputZone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400139A")]
		[SerializeField]
		private DecalGizmo _gizmo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400139B")]
		[SerializeField]
		private RawImage _outOfMeshImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400139C")]
		[SerializeField]
		private DecalLibraryContent _library;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400139D")]
		[SerializeField]
		private DecalLayerContent _layers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400139E")]
		[SerializeField]
		private DecalColorPicker _colorPicker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400139F")]
		[SerializeField]
		private DecalColorPicker _baseColorPicker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40013A0")]
		[SerializeField]
		private Button _cameraViewButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40013A1")]
		[SerializeField]
		private ToggleButton _cutoutToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40013A2")]
		[SerializeField]
		private ToggleButton _mirrorToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40013A3")]
		[SerializeField]
		private ToggleButton _uvSpaceToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40013A4")]
		[SerializeField]
		private ToggleButton _repeatToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40013A5")]
		[SerializeField]
		private ToggleButton _flipToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40013A6")]
		[SerializeField]
		private ToggleButton _transferToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40013A7")]
		[SerializeField]
		internal NotificationButton _btnUndo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40013A8")]
		[SerializeField]
		internal NotificationButton _btnUndoAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40013A9")]
		[SerializeField]
		internal Image _highlightImageUndoAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40013AA")]
		[SerializeField]
		[Nulllable]
		internal TextBase _keyboardEscShortcutText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40013AB")]
		[SerializeField]
		[Nulllable]
		internal TextBase _gamepadEscShortcutText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40013AC")]
		[SerializeField]
		internal string _escButtonCloseStringID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40013AD")]
		[SerializeField]
		internal string _escButtonSaveAndQuitStringID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40013AE")]
		[SerializeField]
		private AK.Wwise.Event _deleteLayerSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40013AF")]
		[SerializeField]
		private AK.Wwise.Event _openSlideSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40013B0")]
		[SerializeField]
		private AK.Wwise.Event _closeSlideSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40013B5")]
		public SaveDesign OnSaveDesign;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40013B6")]
		private TouchGesture _touch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40013B7")]
		private TapGesture _tap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40013B8")]
		private InputAction inputOrbitCameraRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40013B9")]
		private InputAction inputTriggerOrbitCameraRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40013BA")]
		private InputAction inputTriggerOrbitCameraRotationMouseAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40013BB")]
		private InputAction inputTriggerOrbitCameraRotationButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40013BC")]
		private InputAction inputOrbitCameraZoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40013BD")]
		private InputAction inputMotifMove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40013BE")]
		private InputAction inputTriggerMotifRotate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40013BF")]
		private InputAction inputTriggerMotifRotateButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40013C0")]
		private InputAction inputTriggerMotifScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40013C1")]
		private InputAction inputTriggerMotifScaleButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40013C2")]
		protected InputAction inputActionUndoPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40013C3")]
		protected InputAction inputActionUndoRelease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40013C4")]
		protected InputAction inputActionUndoAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40013C5")]
		private bool _justFiredPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40013C6")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40013C7")]
		private OrbitCamera _orbitCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40013C8")]
		private OrbitCameraTarget _target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40013C9")]
		private DecalRenderingTool _renderTool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40013CA")]
		private Collider _collider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40013CB")]
		private IList<IDecal> _staticDecals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40013CC")]
		private Vector2 _lastScreenPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40013CD")]
		private RaycastHit? _lastHit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40013CE")]
		private DecalBaseItem _currentDecal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40013CF")]
		private bool _currentDecalIsInOriginalModification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40013D0")]
		private DecalLayerItem _currentHighlightedLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40013D1")]
		private int _currentView = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x254")]
		[Cpp2IlInjected.Token(Token = "0x40013D2")]
		private float _layerOriX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40013D3")]
		private float _libraryOriX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
		[Cpp2IlInjected.Token(Token = "0x40013D4")]
		private float _baseColorOriX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40013D5")]
		private float _decalColorOriX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40013D6")]
		private Tween _libraryTween;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40013D7")]
		private Tween _baseColorTween;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x40013D8")]
		private Tween _decalColorTween;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x40013D9")]
		private bool layerTransformInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x40013DA")]
		private Coroutine _drawAllCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x40013DB")]
		[SerializeField]
		private SlidingPanel _mcButtonContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x40013DC")]
		[SerializeField]
		private OrbitCameraConfig _orbitCameraConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x40013DD")]
		private Mode _mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A4")]
		[Cpp2IlInjected.Token(Token = "0x40013DE")]
		private bool _constructed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x40013DF")]
		private Color _currentDecalColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x40013E0")]
		private Color _currentBaseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x40013E1")]
		private Color _currentPreviewedDecalColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x40013E2")]
		private Color _currentPreviewedBaseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x40013E3")]
		private IDisposable controlMapScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x40013E4")]
		private bool _justFiredZoomPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F1")]
		[Cpp2IlInjected.Token(Token = "0x40013E5")]
		private bool _currentlyZoomingIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F4")]
		[Cpp2IlInjected.Token(Token = "0x40013E6")]
		private DOFDistance? _previousDof;

		[Cpp2IlInjected.Token(Token = "0x17000430")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x128"), Cpp2IlInjected.Token(Token = "0x40013B1")]
		public bool IsShown
		{
			[Cpp2IlInjected.Token(Token = "0x6001962")]
			[Cpp2IlInjected.Address(RVA = "0x897F00", Offset = "0x896900", VA = "0x180897F00")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001963")]
			[Cpp2IlInjected.Address(RVA = "0x8987B0", Offset = "0x8971B0", VA = "0x1808987B0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000431")]
		public HistoryStack<DesignWorkingCopy> DesignHistory
		{
			[Cpp2IlInjected.Token(Token = "0x6001964")]
			[Cpp2IlInjected.Address(RVA = "0x9762E0", Offset = "0x974CE0", VA = "0x1809762E0")]
			[CompilerGenerated]
			get
			{
				return _003CDesignHistory_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001965")]
			[Cpp2IlInjected.Address(RVA = "0x12F3DD0", Offset = "0x12F27D0", VA = "0x1812F3DD0")]
			[CompilerGenerated]
			set
			{
				_003CDesignHistory_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000432")]
		public AvatarCustomization AvatarCustomization
		{
			[Cpp2IlInjected.Token(Token = "0x6001966")]
			[Cpp2IlInjected.Address(RVA = "0x975DD0", Offset = "0x9747D0", VA = "0x180975DD0")]
			[CompilerGenerated]
			get
			{
				return _003CAvatarCustomization_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001967")]
			[Cpp2IlInjected.Address(RVA = "0x9765A0", Offset = "0x974FA0", VA = "0x1809765A0")]
			[CompilerGenerated]
			internal set
			{
				_003CAvatarCustomization_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000433")]
		public AvatarAppearance Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x6001968")]
			[Cpp2IlInjected.Address(RVA = "0x975DE0", Offset = "0x9747E0", VA = "0x180975DE0")]
			[CompilerGenerated]
			get
			{
				return _003CAvatar_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001969")]
			[Cpp2IlInjected.Address(RVA = "0x9765B0", Offset = "0x974FB0", VA = "0x1809765B0")]
			[CompilerGenerated]
			internal set
			{
				_003CAvatar_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000434")]
		private bool _shouldMoveDecal
		{
			[Cpp2IlInjected.Token(Token = "0x600196A")]
			[Cpp2IlInjected.Address(RVA = "0x156A760", Offset = "0x1569160", VA = "0x18156A760")]
			get
			{
				if (!_baseColorPicker.isShown && !_colorPicker.isShown)
				{
					return !_mcButtonContent.isOpened;
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event ShowColorPalletDelegate ShowColorPallet
		{
			[Cpp2IlInjected.Token(Token = "0x600195E")]
			[Cpp2IlInjected.Address(RVA = "0x156A6C0", Offset = "0x15690C0", VA = "0x18156A6C0")]
			[CompilerGenerated]
			add
			{
				ShowColorPalletDelegate showColorPallet = this.ShowColorPallet;
				Delegate @delegate = Delegate.Combine(showColorPallet, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != showColorPallet)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600195F")]
			[Cpp2IlInjected.Address(RVA = "0x156A860", Offset = "0x1569260", VA = "0x18156A860")]
			[CompilerGenerated]
			remove
			{
				ShowColorPalletDelegate showColorPallet = this.ShowColorPallet;
				Delegate @delegate = Delegate.Remove(showColorPallet, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != showColorPallet)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event ShowBaseColorPalletDelegate ShowBaseColorPallet
		{
			[Cpp2IlInjected.Token(Token = "0x6001960")]
			[Cpp2IlInjected.Address(RVA = "0x156A620", Offset = "0x1569020", VA = "0x18156A620")]
			[CompilerGenerated]
			add
			{
				ShowBaseColorPalletDelegate showBaseColorPallet = this.ShowBaseColorPallet;
				Delegate @delegate = Delegate.Combine(showBaseColorPallet, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != showBaseColorPallet)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001961")]
			[Cpp2IlInjected.Address(RVA = "0x156A7C0", Offset = "0x15691C0", VA = "0x18156A7C0")]
			[CompilerGenerated]
			remove
			{
				ShowBaseColorPalletDelegate showBaseColorPallet = this.ShowBaseColorPallet;
				Delegate @delegate = Delegate.Remove(showBaseColorPallet, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != showBaseColorPallet)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001953")]
		[Cpp2IlInjected.Address(RVA = "0x15673B0", Offset = "0x1565DB0", VA = "0x1815673B0")]
		private void StartMoveMode()
		{
			//Discarded unreachable code: IL_006c
			//IL_006b: Expected I4, but got I8
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				Transform transform = _gizmo.transform;
				UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
				float z = vector.z;
			}
			TouchGesture touch = _touch;
			DecalRenderingTool renderTool = _renderTool;
			DecalRenderingTool renderTool2 = _renderTool;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z2 = vector2.z;
			float z3 = UnityEngine.Vector3.forward.z;
			UnityEngine.Vector3 vector3 = default(UnityEngine.Vector3);
			float z4 = vector3.z;
			int num2 = 0;
			_mode = Mode.Move;
		}

		[Cpp2IlInjected.Token(Token = "0x6001954")]
		[Cpp2IlInjected.Address(RVA = "0x1562060", Offset = "0x1560A60", VA = "0x181562060")]
		private void MoveMode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001955")]
		[Cpp2IlInjected.Address(RVA = "0x1562570", Offset = "0x1560F70", VA = "0x181562570")]
		private void Move()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001956")]
		[Cpp2IlInjected.Address(RVA = "0x1566050", Offset = "0x1564A50", VA = "0x181566050")]
		[AsyncStateMachine(typeof(_003CShowEditingGizmoAsync_003Ed__3))]
		private Task ShowEditingGizmoAsync(RaycastHit hit)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001957")]
		[Cpp2IlInjected.Address(RVA = "0x1567250", Offset = "0x1565C50", VA = "0x181567250")]
		private unsafe void StartEditMode(Mode mode)
		{
			//Discarded unreachable code: IL_00a7
			//IL_0045: Expected native int or pointer, but got O
			//IL_0078: Expected native int or pointer, but got O
			TouchGesture touch = _touch;
			DecalGizmo gizmo = _gizmo;
			Vector2 _003CScreenPos_003Ek__BackingField = touch.ScreenPos;
			float y = touch.ScreenPos.y;
			Vector2 vector = gizmo.ScreenToLocal(_003CScreenPos_003Ek__BackingField);
			DecalGizmo gizmo2 = _gizmo;
			_startPos = vector;
			((Vector2*)(IntPtr)_startPos)->y = y;
			Vector2 center = gizmo2.Center;
			float radius = _gizmo.Radius;
			DecalRenderingTool renderTool = _renderTool;
			_scaleOffset = vector;
			((Vector2*)(IntPtr)_scaleOffset)->y = y;
			float num = (_startScale = renderTool.size);
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float num2 = (_startAngle = vector2.z);
			_mode = mode;
		}

		[Cpp2IlInjected.Token(Token = "0x6001958")]
		[Cpp2IlInjected.Address(RVA = "0x1567800", Offset = "0x1566200", VA = "0x181567800")]
		private void StartScaleMode()
		{
			StartEditMode(Mode.Scale);
		}

		[Cpp2IlInjected.Token(Token = "0x6001959")]
		[Cpp2IlInjected.Address(RVA = "0x15677F0", Offset = "0x15661F0", VA = "0x1815677F0")]
		private void StartRotateMode()
		{
			StartEditMode(Mode.Rotate);
		}

		[Cpp2IlInjected.Token(Token = "0x600195A")]
		[Cpp2IlInjected.Address(RVA = "0x15652B0", Offset = "0x1563CB0", VA = "0x1815652B0")]
		private void ScaleMode()
		{
			//Discarded unreachable code: IL_0092
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				InputAction inputAction = inputTriggerMotifScale;
				if (inputAction.IsTriggered)
				{
					Vector2 valueVector = inputAction.GetValueVector2();
					float size = default(float);
					_renderTool.Size = size;
					return;
				}
			}
			else
			{
				TouchGesture touch = _touch;
				if (touch.Phase != TouchGesture.PhaseType.Ended)
				{
					DecalGizmo gizmo = _gizmo;
					Vector2 _003CScreenPos_003Ek__BackingField = touch.ScreenPos;
					float y = touch.ScreenPos.y;
					Vector2 vector = gizmo.ScreenToLocal(_003CScreenPos_003Ek__BackingField);
					float radius = _gizmo.Radius;
					DecalRenderingTool renderTool = _renderTool;
				}
			}
			StartMoveMode();
		}

		[Cpp2IlInjected.Token(Token = "0x600195B")]
		[Cpp2IlInjected.Address(RVA = "0x1564D50", Offset = "0x1563750", VA = "0x181564D50")]
		private void RotateMode()
		{
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				InputAction inputAction = inputTriggerMotifRotate;
				if (inputAction.IsTriggered)
				{
					Angle angle = Trigo.PositionToAngle(inputAction.GetValueVector2());
					float roll = default(float);
					_renderTool.Roll(roll);
					return;
				}
			}
			else
			{
				TouchGesture touch = _touch;
				if (touch.Phase != TouchGesture.PhaseType.Ended)
				{
					DecalGizmo gizmo = _gizmo;
					Vector2 _003CScreenPos_003Ek__BackingField = touch.ScreenPos;
					float y = touch.ScreenPos.y;
					Vector2 vector = gizmo.ScreenToLocal(_003CScreenPos_003Ek__BackingField);
					Vector2 center = _gizmo.Center;
					DecalRenderingTool renderTool = _renderTool;
				}
			}
			StartMoveMode();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600195C")]
		[Cpp2IlInjected.Address(RVA = "0x1567610", Offset = "0x1566010", VA = "0x181567610")]
		private void StartOrbitAroundMode()
		{
			//Discarded unreachable code: IL_0042
			//IL_0041: Expected I4, but got I8
			_gizmo.Show();
			DecalRenderingTool renderTool = _renderTool;
			DecalRenderingTool renderTool2 = _renderTool;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			float z2 = UnityEngine.Vector3.forward.z;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z3 = vector2.z;
			int num = 0;
			_mode = Mode.View;
		}

		[Cpp2IlInjected.Token(Token = "0x600195D")]
		[Cpp2IlInjected.Address(RVA = "0x1564210", Offset = "0x1562C10", VA = "0x181564210")]
		private void OrbitAroundMode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600196B")]
		[Cpp2IlInjected.Address(RVA = "0x155FC80", Offset = "0x155E680", VA = "0x18155FC80")]
		private void Construct()
		{
			//Discarded unreachable code: IL_0471
			//IL_0130: Expected O, but got I4
			//IL_016b: Expected O, but got I4
			//IL_01a1: Expected O, but got I4
			//IL_01d7: Expected O, but got I4
			//IL_020d: Expected O, but got I4
			//IL_0243: Expected O, but got I4
			//IL_0279: Expected O, but got I4
			//IL_0430: Expected O, but got I4
			//IL_044a: Expected O, but got I4
			Camera camera = (_camera = SystemRoot.Instance._playerCamera);
			Camera camera2 = _camera;
			OrbitCameraConfig orbitCameraConfig = _orbitCameraConfig;
			OrbitCamera orbitCamera = (_orbitCamera = new OrbitCamera(camera2, orbitCameraConfig, allowZoom: true));
			SlidingPanel slider = _layers.Slider;
			SlidingPanel.SlidingPanelEvent value = OnLayerTransformInit;
			slider.OnOvershootFinished += value;
			AnimatedToggleButton btnBaseColor = _layers._btnBaseColor;
			ToggleButton.OnValueChangedDelegate value2 = OnBaseColorToggleChangedHandler;
			btnBaseColor.OnValueChanged += value2;
			ToggleButton btnColor = _gizmo._btnColor;
			ToggleButton.OnValueChangedDelegate value3 = OnDecalColorToggleHandler;
			btnColor.OnValueChanged += value3;
			ToggleButton btnMode = _gizmo._btnMode;
			ToggleButton.OnValueChangedDelegate value4 = OnModePanelToggleHandler;
			btnMode.OnValueChanged += value4;
			Button.ButtonClickedEvent onClick = _layers._btnBaseColor.ButtonComponent.m_OnClick;
			UnityAction call = Confirm;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _layers._btnAdd.ButtonComponent.m_OnClick;
			UnityAction call2 = Confirm;
			onClick2.AddListener(call2);
			Button cameraViewButton = _cameraViewButton;
			int num = 0;
			if (cameraViewButton != (UnityEngine.Object)num)
			{
				Button.ButtonClickedEvent onClick3 = _cameraViewButton.m_OnClick;
				UnityAction call3 = NextCameraView;
				onClick3.AddListener(call3);
			}
			ToggleButton transferToggle = _transferToggle;
			int num2 = 0;
			if (transferToggle != (UnityEngine.Object)num2)
			{
				ToggleButton transferToggle2 = _transferToggle;
				ToggleButton.OnValueChangedDelegate value5 = ToggleSeeThroughMode;
				transferToggle2.OnValueChanged += value5;
			}
			ToggleButton cutoutToggle = _cutoutToggle;
			int num3 = 0;
			if (cutoutToggle != (UnityEngine.Object)num3)
			{
				ToggleButton cutoutToggle2 = _cutoutToggle;
				ToggleButton.OnValueChangedDelegate value6 = ToggleCutoutMode;
				cutoutToggle2.OnValueChanged += value6;
			}
			ToggleButton mirrorToggle = _mirrorToggle;
			int num4 = 0;
			if (mirrorToggle != (UnityEngine.Object)num4)
			{
				ToggleButton mirrorToggle2 = _mirrorToggle;
				ToggleButton.OnValueChangedDelegate value7 = ToggleMirrorMode;
				mirrorToggle2.OnValueChanged += value7;
			}
			ToggleButton uvSpaceToggle = _uvSpaceToggle;
			int num5 = 0;
			if (uvSpaceToggle != (UnityEngine.Object)num5)
			{
				ToggleButton uvSpaceToggle2 = _uvSpaceToggle;
				ToggleButton.OnValueChangedDelegate value8 = ToggleUVSpace;
				uvSpaceToggle2.OnValueChanged += value8;
			}
			ToggleButton repeatToggle = _repeatToggle;
			int num6 = 0;
			if (repeatToggle != (UnityEngine.Object)num6)
			{
				ToggleButton repeatToggle2 = _repeatToggle;
				ToggleButton.OnValueChangedDelegate value9 = ToggleRepeat;
				repeatToggle2.OnValueChanged += value9;
			}
			ToggleButton flipToggle = _flipToggle;
			int num7 = 0;
			if (flipToggle != (UnityEngine.Object)num7)
			{
				ToggleButton flipToggle2 = _flipToggle;
				ToggleButton.OnValueChangedDelegate value10 = ToggleFlip;
				flipToggle2.OnValueChanged += value10;
			}
			Button.ButtonClickedEvent onClick4 = _btnUndo.ButtonComponent.m_OnClick;
			UnityAction call4 = Undo;
			onClick4.AddListener(call4);
			Button.ButtonClickedEvent onClick5 = _btnUndoAll.ButtonComponent.m_OnClick;
			UnityAction call5 = UndoAll;
			onClick5.AddListener(call5);
			DecalLibraryContent library = _library;
			DecalLibraryContent.SelectDecal value11 = SelectDecal;
			library.OnDecalSelected += value11;
			DecalLayerContent layers = _layers;
			DecalLayerContent.SelectDecal value12 = SelectDecal;
			layers.OnDecalSelected += value12;
			DecalLayerContent layers2 = _layers;
			DecalLayerContent.InsertDecal value13 = InsertDecal;
			layers2.OnInsertDecal += value13;
			DecalLayerContent layers3 = _layers;
			DecalLayerContent.DeleteDecal value14 = DeleteDecal;
			layers3.OnDeleteDecal += value14;
			DecalLayerContent layers4 = _layers;
			DecalLayerContent.AddDecalHandler value15 = AddDecalHandler;
			layers4.OnAddDecalHandler += value15;
			DecalColorPicker colorPicker = _colorPicker;
			DecalColorPicker.ColorChanged value16 = UpdateColor;
			colorPicker.OnColorChanged += value16;
			DecalColorPicker baseColorPicker = _baseColorPicker;
			DecalColorPicker.ColorChanged value17 = UpdateBaseColor;
			baseColorPicker.OnColorChanged += value17;
			DecalColorPicker colorPicker2 = _colorPicker;
			DecalColorPicker.ColorChanged value18 = PreviewColor;
			colorPicker2.OnColorHighlightAdded += value18;
			DecalColorPicker baseColorPicker2 = _baseColorPicker;
			DecalColorPicker.ColorChanged value19 = PreviewBaseColor;
			baseColorPicker2.OnColorHighlightAdded += value19;
			DecalGizmo gizmo = _gizmo;
			DecalGizmo.GizmoDelegate value20 = OnGizmoShown;
			gizmo.OnGizmoShown += value20;
			int num8 = default(int);
			TouchGesture touch = new TouchGesture(_inputZone, (Camera)num8);
			num8 = 0;
			_touch = touch;
			int num9 = default(int);
			TapGesture tap = new TapGesture(_inputZone, (Camera)num9);
			num9 = 0;
			_tap = tap;
			GameObject gameObject = _outOfMeshImage.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600196C")]
		[Cpp2IlInjected.Address(RVA = "0x15633A0", Offset = "0x1561DA0", VA = "0x1815633A0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_03ec
			//IL_00f8: Expected O, but got I4
			//IL_0133: Expected O, but got I4
			//IL_0169: Expected O, but got I4
			//IL_019f: Expected O, but got I4
			//IL_01d5: Expected O, but got I4
			//IL_020b: Expected O, but got I4
			//IL_0241: Expected O, but got I4
			SlidingPanel slider = _layers.Slider;
			SlidingPanel.SlidingPanelEvent value = OnLayerTransformInit;
			slider.OnOvershootFinished -= value;
			AnimatedToggleButton btnBaseColor = _layers._btnBaseColor;
			ToggleButton.OnValueChangedDelegate value2 = OnBaseColorToggleChangedHandler;
			btnBaseColor.OnValueChanged -= value2;
			ToggleButton btnColor = _gizmo._btnColor;
			ToggleButton.OnValueChangedDelegate value3 = OnDecalColorToggleHandler;
			btnColor.OnValueChanged -= value3;
			ToggleButton btnMode = _gizmo._btnMode;
			ToggleButton.OnValueChangedDelegate value4 = OnModePanelToggleHandler;
			btnMode.OnValueChanged -= value4;
			Button.ButtonClickedEvent onClick = _layers._btnBaseColor.ButtonComponent.m_OnClick;
			UnityAction call = Confirm;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _layers._btnAdd.ButtonComponent.m_OnClick;
			UnityAction call2 = Confirm;
			onClick2.RemoveListener(call2);
			Button cameraViewButton = _cameraViewButton;
			int num = 0;
			if (cameraViewButton != (UnityEngine.Object)num)
			{
				Button.ButtonClickedEvent onClick3 = _cameraViewButton.m_OnClick;
				UnityAction call3 = NextCameraView;
				onClick3.RemoveListener(call3);
			}
			ToggleButton transferToggle = _transferToggle;
			int num2 = 0;
			if (transferToggle != (UnityEngine.Object)num2)
			{
				ToggleButton transferToggle2 = _transferToggle;
				ToggleButton.OnValueChangedDelegate value5 = ToggleSeeThroughMode;
				transferToggle2.OnValueChanged -= value5;
			}
			ToggleButton cutoutToggle = _cutoutToggle;
			int num3 = 0;
			if (cutoutToggle != (UnityEngine.Object)num3)
			{
				ToggleButton cutoutToggle2 = _cutoutToggle;
				ToggleButton.OnValueChangedDelegate value6 = ToggleCutoutMode;
				cutoutToggle2.OnValueChanged -= value6;
			}
			ToggleButton mirrorToggle = _mirrorToggle;
			int num4 = 0;
			if (mirrorToggle != (UnityEngine.Object)num4)
			{
				ToggleButton mirrorToggle2 = _mirrorToggle;
				ToggleButton.OnValueChangedDelegate value7 = ToggleMirrorMode;
				mirrorToggle2.OnValueChanged -= value7;
			}
			ToggleButton uvSpaceToggle = _uvSpaceToggle;
			int num5 = 0;
			if (uvSpaceToggle != (UnityEngine.Object)num5)
			{
				ToggleButton uvSpaceToggle2 = _uvSpaceToggle;
				ToggleButton.OnValueChangedDelegate value8 = ToggleUVSpace;
				uvSpaceToggle2.OnValueChanged -= value8;
			}
			ToggleButton repeatToggle = _repeatToggle;
			int num6 = 0;
			if (repeatToggle != (UnityEngine.Object)num6)
			{
				ToggleButton repeatToggle2 = _repeatToggle;
				ToggleButton.OnValueChangedDelegate value9 = ToggleRepeat;
				repeatToggle2.OnValueChanged -= value9;
			}
			ToggleButton flipToggle = _flipToggle;
			int num7 = 0;
			if (flipToggle != (UnityEngine.Object)num7)
			{
				ToggleButton flipToggle2 = _flipToggle;
				ToggleButton.OnValueChangedDelegate value10 = ToggleFlip;
				flipToggle2.OnValueChanged -= value10;
			}
			Button.ButtonClickedEvent onClick4 = _btnUndo.ButtonComponent.m_OnClick;
			UnityAction call4 = Undo;
			onClick4.RemoveListener(call4);
			Button.ButtonClickedEvent onClick5 = _btnUndoAll.ButtonComponent.m_OnClick;
			UnityAction call5 = UndoAll;
			onClick5.RemoveListener(call5);
			DecalLibraryContent library = _library;
			DecalLibraryContent.SelectDecal value11 = SelectDecal;
			library.OnDecalSelected -= value11;
			DecalLayerContent layers = _layers;
			DecalLayerContent.SelectDecal value12 = SelectDecal;
			layers.OnDecalSelected -= value12;
			DecalLayerContent layers2 = _layers;
			DecalLayerContent.InsertDecal value13 = InsertDecal;
			layers2.OnInsertDecal -= value13;
			DecalLayerContent layers3 = _layers;
			DecalLayerContent.DeleteDecal value14 = DeleteDecal;
			layers3.OnDeleteDecal -= value14;
			DecalLayerContent layers4 = _layers;
			DecalLayerContent.AddDecalHandler value15 = AddDecalHandler;
			layers4.OnAddDecalHandler -= value15;
			DecalColorPicker colorPicker = _colorPicker;
			DecalColorPicker.ColorChanged value16 = UpdateColor;
			colorPicker.OnColorChanged -= value16;
			DecalColorPicker baseColorPicker = _baseColorPicker;
			DecalColorPicker.ColorChanged value17 = UpdateBaseColor;
			baseColorPicker.OnColorChanged -= value17;
			DecalColorPicker colorPicker2 = _colorPicker;
			DecalColorPicker.ColorChanged value18 = PreviewColor;
			colorPicker2.OnColorHighlightAdded -= value18;
			DecalColorPicker baseColorPicker2 = _baseColorPicker;
			DecalColorPicker.ColorChanged value19 = PreviewBaseColor;
			baseColorPicker2.OnColorHighlightAdded -= value19;
			DecalGizmo gizmo = _gizmo;
			DecalGizmo.GizmoDelegate value20 = OnGizmoShown;
			gizmo.OnGizmoShown -= value20;
		}

		[Cpp2IlInjected.Token(Token = "0x600196D")]
		[Cpp2IlInjected.Address(RVA = "0x1560D60", Offset = "0x155F760", VA = "0x181560D60")]
		internal bool HandleRedirection(RedirectionType redirectionType)
		{
			//Discarded unreachable code: IL_010b
			int num = 0;
			if (redirectionType != RedirectionType.ToFilter && redirectionType == RedirectionType.MenuNavGoBackward)
			{
				if ((_mcButtonContent.isOpened ? 1 : 0) != num)
				{
					int num2 = 0;
					UiRoot instance = UiRoot.Instance;
					int useKeyboardAsController = 0;
					if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
					{
						_gizmo.DeselectModeToggle();
					}
				}
				if ((_colorPicker.isShown ? 1 : 0) != num)
				{
					int num3 = 0;
					UiRoot instance2 = UiRoot.Instance;
					int useKeyboardAsController2 = 0;
					if (instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0))
					{
						_gizmo.DeselectColorToggle();
					}
				}
				DecalLibraryContent library = _library;
				if ((library.isShown ? 1 : 0) == num)
				{
					if ((_gizmo.Shown ? 1 : 0) == num)
					{
						if ((_baseColorPicker.isShown ? 1 : 0) == num)
						{
							goto IL_00f6;
						}
						_layers.DeselectBaseColorToggle();
					}
					SaveCurrentDecal();
					Cancel();
				}
				if (!library.HandleRedirection(RedirectionType.MenuNavGoBackward))
				{
					_layers.DeselectAddLayerToggle();
				}
				int num4 = 0;
				UiRoot instance3 = UiRoot.Instance;
				int useKeyboardAsController3 = 0;
				if (instance3.IsControllerConnected((byte)useKeyboardAsController3 != 0))
				{
					SetFocus();
				}
			}
			goto IL_00f6;
			IL_00f6:
			bool flag = _library.HandleRedirection(RedirectionType.ToFilter);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600196E")]
		[Cpp2IlInjected.Address(RVA = "0x1565F60", Offset = "0x1564960", VA = "0x181565F60")]
		internal void SetFocus()
		{
			//Discarded unreachable code: IL_0088
			DecalColorPicker colorPicker = _colorPicker;
			if (!colorPicker.isShown && !_baseColorPicker.isShown)
			{
				DecalLibraryContent library = _library;
				if (!library.isShown)
				{
					SlidingPanel mcButtonContent = _mcButtonContent;
					if (mcButtonContent.isHidden)
					{
						DecalLayerContent layers = _layers;
						FocusNavigation focusNavigation = _focusNavigation;
						layers.SetFocus(focusNavigation);
					}
					else
					{
						FocusNavigation focusNavigation2 = _focusNavigation;
						FocusNavigationElement componentInChildren = mcButtonContent.GetComponentInChildren<FocusNavigationElement>();
						focusNavigation2.SetFocus(componentInChildren);
					}
				}
				else
				{
					FocusNavigation focusNavigation3 = _focusNavigation;
					library.SetFocus(focusNavigation3);
				}
			}
			else
			{
				colorPicker.SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600196F")]
		[Cpp2IlInjected.Address(RVA = "0x1566290", Offset = "0x1564C90", VA = "0x181566290")]
		public unsafe void Show(UnityEngine.Vector3 cameraPos, OrbitCameraTarget target, DecalRenderingTool renderTool, Collider collider, IList<IDecal> staticDecals, HistoryStack<DesignWorkingCopy> designHistory, float transitionDuration)
		{
			//Discarded unreachable code: IL_0590
			//IL_0067: Expected O, but got I4
			//IL_007c: Expected O, but got I4
			//IL_00ce: Expected O, but got I4
			//IL_0271: Expected O, but got I4
			//IL_027d: Expected O, but got I4
			//IL_028c: Expected O, but got I4
			//IL_0294: Expected O, but got I4
			//IL_02ae: Expected O, but got I4
			//IL_02cf: Expected O, but got I4
			//IL_02cf: Expected O, but got I4
			//IL_0315: Expected O, but got I4
			//IL_033c: Expected O, but got I4
			//IL_037e: Expected O, but got I4
			//IL_040f: Expected O, but got I4
			//IL_0431: Expected O, but got I4
			//IL_0459: Expected O, but got I4
			//IL_0480: Expected O, but got I4
			//IL_049f: Expected O, but got I4
			//IL_04c6: Expected O, but got I4
			//IL_0503: Expected O, but got I4
			//IL_052a: Expected O, but got I4
			//IL_057b: Expected I4, but got I8
			int num = 0;
			if (!_constructed)
			{
				Construct();
			}
			base.gameObject.SetActive(value: true);
			if (_colorPicker.isShown)
			{
				_layers.DeselectBaseColorToggle();
			}
			if (_baseColorPicker.isShown)
			{
				_gizmo.DeselectColorToggle();
			}
			_layers.Slider.Show(andOpen: true);
			DesignHistory = (HistoryStack<DesignWorkingCopy>)0;
			_target = target;
			_renderTool = renderTool;
			_collider = (Collider)0;
			DecalRenderingTool renderTool2 = _renderTool;
			Action<Texture2D> action = (Action<Texture2D>)(object)new Action<T>(UpdateOutOfMeshTexture);
			renderTool2.add_OnCurrentTextureChanged((Action<>)(object)action);
			DecalRenderingTool renderTool3 = _renderTool;
			DecalLayerContent layers = _layers;
			int num2 = (layers.MaxLayerCount = renderTool3.maxDecals);
			if (isTool)
			{
				List<IDecal> list = (List<IDecal>)(object)new List<T>();
			}
			_staticDecals = (IList<IDecal>)0;
			_library.Refresh();
			HistoryStack<DesignWorkingCopy> historyStack = DesignHistory;
			DecalLayerContent layers2 = _layers;
			Design _003CData_003Ek__BackingField = ((DesignWorkingCopy)((HistoryStack<T>)(object)historyStack).Current).Data;
			layers2.Refresh(_003CData_003Ek__BackingField);
			OrbitCameraTarget target2 = _target;
			OrbitCamera orbitCamera = _orbitCamera;
			Transform lookAt = target2.lookAt;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			OrbitCameraTarget target3 = _target;
			float z2 = cameraPos.z;
			int num3 = 0;
			DrawAll();
			TapGesture tap = _tap;
			float num4 = (tap.DragTolerance = tapDragTolerance);
			TapGesture tap2 = _tap;
			float num5 = (tap2.MaxDuration = tapMaxDuration);
			_gizmo.DeselectModeToggle();
			ToggleButton cutoutToggle = _cutoutToggle;
			int num6 = ((cutoutToggle.IsOn = false) ? 1 : 0);
			ToggleButton flipToggle = _flipToggle;
			int num7 = ((flipToggle.IsOn = false) ? 1 : 0);
			HistoryStack<DesignWorkingCopy> historyStack2 = DesignHistory;
			ToggleButton mirrorToggle = _mirrorToggle;
			int count = ((RepeatedField<T>)(object)((DesignWorkingCopy)((HistoryStack<T>)(object)historyStack2).Current).Data.decals_).Count;
			DecalRenderingTool renderTool4 = _renderTool;
			bool flag4 = (mirrorToggle.IsActive = count < renderTool4.maxDecals);
			ToggleButton mirrorToggle2 = _mirrorToggle;
			int num8 = ((mirrorToggle2.IsOn = false) ? 1 : 0);
			ToggleButton transferToggle = _transferToggle;
			int num9 = ((transferToggle.IsOn = false) ? 1 : 0);
			ToggleButton uvSpaceToggle = _uvSpaceToggle;
			int num10 = ((uvSpaceToggle.IsOn = false) ? 1 : 0);
			_uvSpaceToggle.ButtonComponent.interactable = true;
			ToggleButton repeatToggle = _repeatToggle;
			int num11 = ((repeatToggle.IsOn = false) ? 1 : 0);
			RefreshUndoButton();
			bool flag9 = ColorUtility.TryParseHtmlString(((DesignWorkingCopy)((HistoryStack<T>)(object)DesignHistory).Current).Data.baseColor_, out *(Color*)num);
			SetBaseColor((Color)num);
			_layers.UpdateColorPreview((Color)num);
			DecalColorPicker baseColorPicker = _baseColorPicker;
			_currentBaseColor = (Color)num;
			baseColorPicker.RefreshSelected((Color)num);
			InputTriggerDown trigger = new InputTriggerDown();
			InputActionVector2D inputActionVector2D = (InputActionVector2D)(inputOrbitCameraRotation = new InputActionVector2D("DecalCamera_RotateYaw", "DecalCamera_RotatePitch", trigger, (InputProvider)num3));
			InputTriggerDown trigger2 = new InputTriggerDown();
			int num12 = default(int);
			InputActionFloat inputActionFloat = new InputActionFloat("DecalCamera_Zoom", trigger2, (string)num12, (InputProvider)num3);
			num12 = 0;
			inputOrbitCameraZoom = inputActionFloat;
			InputAction inputAction = inputOrbitCameraZoom;
			InputActionModifier_ValueModifier modifier = new InputActionModifier_ValueModifier((Func<, >)(object)new Func<T, TResult>(ZoomModifier));
			inputAction.AddModifier(modifier);
			InputTriggerDown trigger3 = new InputTriggerDown();
			int num13 = default(int);
			InputActionBool inputActionBool = new InputActionBool("DecalCamera_TriggerRotateButton", trigger3, (InputProvider)num13);
			num13 = 0;
			inputTriggerOrbitCameraRotationButton = inputActionBool;
			InputTriggerDown trigger4 = new InputTriggerDown();
			InputActionVector2D inputActionVector2D2 = (InputActionVector2D)(inputTriggerOrbitCameraRotation = new InputActionVector2D("DecalCamera_TriggerRotateYaw", "DecalCamera_TriggerRotatePitch", trigger4, (InputProvider)num3));
			InputAction inputAction2 = inputTriggerOrbitCameraRotation;
			InputActionModifier_Chord modifier2 = new InputActionModifier_Chord(inputTriggerOrbitCameraRotationButton);
			inputAction2.AddModifier(modifier2);
			InputTriggerDown trigger5 = new InputTriggerDown();
			InputActionVector2D inputActionVector2D3 = (InputActionVector2D)(inputTriggerOrbitCameraRotationMouseAxis = new InputActionVector2D("DecalCamera_TriggerRotateYaw_MouseAxis", "DecalCamera_TriggerRotatePitch_MouseAxis", trigger5, (InputProvider)num3));
			InputAction inputAction3 = inputTriggerOrbitCameraRotationMouseAxis;
			InputActionModifier_Chord modifier3 = new InputActionModifier_Chord(inputTriggerOrbitCameraRotationButton);
			inputAction3.AddModifier(modifier3);
			InputAction inputAction4 = inputTriggerOrbitCameraRotationMouseAxis;
			InputActionModifier_ScaleDeltaTime modifier4 = new InputActionModifier_ScaleDeltaTime();
			inputAction4.AddModifier(modifier4);
			InputAction inputAction5 = inputOrbitCameraRotation;
			InputActionModifier_Merge modifier5 = new InputActionModifier_Merge(inputTriggerOrbitCameraRotation);
			inputAction5.AddModifier(modifier5);
			InputAction inputAction6 = inputOrbitCameraRotation;
			InputActionModifier_Merge modifier6 = new InputActionModifier_Merge(inputTriggerOrbitCameraRotationMouseAxis);
			inputAction6.AddModifier(modifier6);
			InputTriggerPressed trigger6 = new InputTriggerPressed();
			int num14 = default(int);
			InputActionBool inputActionBool2 = new InputActionBool("DecalDesign_Undo", trigger6, (InputProvider)num14);
			num14 = 0;
			inputActionUndoPress = inputActionBool2;
			InputTriggerReleased trigger7 = new InputTriggerReleased();
			int num15 = default(int);
			InputActionBool inputActionBool3 = new InputActionBool("DecalDesign_Undo", trigger7, (InputProvider)num15);
			num15 = 0;
			inputActionUndoRelease = inputActionBool3;
			InputTriggerDownWithDelay trigger8 = new InputTriggerDownWithDelay(_undoAllPressDelay);
			int num16 = default(int);
			InputActionBool inputActionBool4 = new InputActionBool("DecalDesign_Undo", trigger8, (InputProvider)num16);
			num16 = 0;
			inputActionUndoAll = inputActionBool4;
			InputTriggerDown trigger9 = new InputTriggerDown();
			InputActionVector2D inputActionVector2D4 = (InputActionVector2D)(inputMotifMove = new InputActionVector2D("DecalDesign_MoveHorizontal", "DecalDesign_MoveVertical", trigger9, (InputProvider)num3));
			InputTriggerDown trigger10 = new InputTriggerDown();
			int num17 = default(int);
			InputActionBool inputActionBool5 = new InputActionBool("DecalDesign_TriggerRotateButton", trigger10, (InputProvider)num17);
			num17 = 0;
			inputTriggerMotifRotateButton = inputActionBool5;
			InputTriggerDown trigger11 = new InputTriggerDown();
			InputActionVector2D inputActionVector2D5 = (InputActionVector2D)(inputTriggerMotifRotate = new InputActionVector2D("DecalDesign_MoveHorizontal", "DecalDesign_MoveVertical", trigger11, (InputProvider)num3));
			InputAction inputAction7 = inputTriggerMotifRotate;
			InputActionModifier_Chord modifier7 = new InputActionModifier_Chord(inputTriggerMotifRotateButton);
			inputAction7.AddModifier(modifier7);
			InputTriggerDown trigger12 = new InputTriggerDown();
			int num18 = default(int);
			InputActionBool inputActionBool6 = new InputActionBool("DecalDesign_TriggerScaleButton", trigger12, (InputProvider)num18);
			num18 = 0;
			inputTriggerMotifScaleButton = inputActionBool6;
			InputTriggerDown trigger13 = new InputTriggerDown();
			InputActionVector2D inputActionVector2D6 = (InputActionVector2D)(inputTriggerMotifScale = new InputActionVector2D("DecalDesign_MoveHorizontal", "DecalDesign_MoveVertical", trigger13, (InputProvider)num3));
			InputAction inputAction8 = inputTriggerMotifScale;
			InputActionModifier_Chord modifier8 = new InputActionModifier_Chord(inputTriggerMotifScaleButton);
			inputAction8.AddModifier(modifier8);
			if (controlMapScope != null)
			{
			}
			PlayerNavigation system = SystemRoot.Instance.GetSystem<PlayerNavigation>();
			int[] array = new int[1];
			array[0] = 38;
			PlayerNavigation.TemporaryOverrideScope temporaryOverrideScope = (PlayerNavigation.TemporaryOverrideScope)(controlMapScope = system.OverrideControlMaps(forceImmediateStop: true, array));
		}

		[Cpp2IlInjected.Token(Token = "0x6001970")]
		[Cpp2IlInjected.Address(RVA = "0x1560F90", Offset = "0x155F990", VA = "0x181560F90")]
		internal void HideColorPallet()
		{
			//Discarded unreachable code: IL_0026
			AnimateCloseDecalColorPicker();
			if (_gizmo.gameObject.activeInHierarchy)
			{
				_gizmo.DeselectColorToggle();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001971")]
		[Cpp2IlInjected.Address(RVA = "0x1563F00", Offset = "0x1562900", VA = "0x181563F00")]
		private void OnLayerTransformInit()
		{
			//Discarded unreachable code: IL_0043
			if (!layerTransformInitialized)
			{
				Transform transform = _layers.transform;
				Transform transform2 = _library.transform;
				Transform transform3 = _baseColorPicker.transform;
				Transform transform4 = _colorPicker.transform;
				layerTransformInitialized = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001972")]
		[Cpp2IlInjected.Address(RVA = "0x1564100", Offset = "0x1562B00", VA = "0x181564100")]
		private void OnUpdatePosition()
		{
			//Discarded unreachable code: IL_0027
			//IL_0026: Expected F4, but got I4
			Transform transform = _layers.transform;
			int num = 0;
			OrbitCamera orbitCamera = _orbitCamera;
			int num2 = 0;
			int width = Screen.width;
			orbitCamera.ScreenOffset = num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001973")]
		[Cpp2IlInjected.Address(RVA = "0x1560F30", Offset = "0x155F930", VA = "0x181560F30")]
		internal void HideBaseColorPallet()
		{
			//Discarded unreachable code: IL_0026
			AnimateCloseBaseColorPicker();
			if (_layers.gameObject.activeInHierarchy)
			{
				_layers.DeselectBaseColorToggle();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001974")]
		[Cpp2IlInjected.Address(RVA = "0x155F690", Offset = "0x155E090", VA = "0x18155F690")]
		private void BumpButton(BaseButton btn)
		{
			//Discarded unreachable code: IL_002e
			Transform transform = btn.transform;
			int num = 0;
			TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions> tweenerCore = ((TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale(btn.transform, 1f, 0.3f)).SetEase(Ease.OutQuart).Play();
		}

		[Cpp2IlInjected.Token(Token = "0x6001975")]
		[Cpp2IlInjected.Address(RVA = "0x1567810", Offset = "0x1566210", VA = "0x181567810")]
		private void StartUndoAllButtonAnim()
		{
			//Discarded unreachable code: IL_0040
			//IL_0021: Expected F4, but got I4
			_highlightImageUndoAll.gameObject.SetActive(value: true);
			Image highlightImageUndoAll = _highlightImageUndoAll;
			int num = 0;
			highlightImageUndoAll.fillAmount = num;
			float undoAllPressDelay = _undoAllPressDelay;
			TweenerCore<float, float, FloatOptions> tweenerCore = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFillAmount(_highlightImageUndoAll, 1f, undoAllPressDelay)).Play();
		}

		[Cpp2IlInjected.Token(Token = "0x6001976")]
		[Cpp2IlInjected.Address(RVA = "0x15678B0", Offset = "0x15662B0", VA = "0x1815678B0")]
		private void StopUndoAllButtonAnim(bool playBumpAnim)
		{
			//Discarded unreachable code: IL_004c
			GameObject gameObject = _highlightImageUndoAll.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			_highlightImageUndoAll.fillAmount = 1f;
			Image highlightImageUndoAll = _highlightImageUndoAll;
			int complete = 0;
			int num = DOTween.Kill(highlightImageUndoAll, (byte)complete != 0);
			if (playBumpAnim)
			{
				NotificationButton btnUndoAll = _btnUndoAll;
				BumpButton(btnUndoAll);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001977")]
		[Cpp2IlInjected.Address(RVA = "0x1568630", Offset = "0x1567030", VA = "0x181568630")]
		public unsafe void Undo()
		{
			//Discarded unreachable code: IL_00f7
			//IL_0019: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_00a8: Expected O, but got I4
			//IL_00c2: Expected O, but got I4
			NotificationButton btnUndo = _btnUndo;
			int num = 0;
			DecalBaseItem currentDecal = _currentDecal;
			int num2 = 0;
			if (!(currentDecal != (UnityEngine.Object)num2))
			{
				if (!((HistoryStack<T>)(object)DesignHistory).Undo())
				{
					goto IL_00d1;
				}
				HistoryStack<DesignWorkingCopy> historyStack = DesignHistory;
				DecalLayerContent layers = _layers;
				Design _003CData_003Ek__BackingField = ((DesignWorkingCopy)((HistoryStack<T>)(object)historyStack).Current).Data;
				layers.Refresh(_003CData_003Ek__BackingField);
				bool flag = ColorUtility.TryParseHtmlString(((DesignWorkingCopy)((HistoryStack<T>)(object)DesignHistory).Current).Data.baseColor_, out *(Color*)num);
				AvatarCustomization avatarCustomization = AvatarCustomization;
				AvatarAppearance avatarAppearance = Avatar;
				ClothingItemType _003CClothingType_003Ek__BackingField = avatarCustomization.ClothingType;
				avatarAppearance.ApplyBaseColor(_003CClothingType_003Ek__BackingField, (Color)num).FireAndForgetTask();
				_layers.UpdateColorPreview((Color)num);
				DrawAll();
			}
			DecalBaseItem currentDecal2 = _currentDecal;
			int num3 = 0;
			if (currentDecal2 != (UnityEngine.Object)num3)
			{
				SaveCurrentDecal();
			}
			Cancel();
			goto IL_00d1;
			IL_00d1:
			RefreshUndoButton();
			int num4 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001978")]
		[Cpp2IlInjected.Address(RVA = "0x1568470", Offset = "0x1566E70", VA = "0x181568470")]
		private void UndoAll()
		{
			//Discarded unreachable code: IL_0021
			int num = 0;
			CancellationToken cancellationToken = UiRoot.Instance._menuStack.GetMenu<DecalMenu>().CancellationToken;
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001979")]
		[Cpp2IlInjected.Address(RVA = "0x1568350", Offset = "0x1566D50", VA = "0x181568350")]
		[AsyncStateMachine(typeof(_003CUndoAllTask_003Ed__136))]
		private Task UndoAllTask(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600197A")]
		[Cpp2IlInjected.Address(RVA = "0x1564B80", Offset = "0x1563580", VA = "0x181564B80")]
		public void RefreshUndoButton()
		{
			//Discarded unreachable code: IL_00aa
			//IL_0010: Expected O, but got I4
			DecalBaseItem currentDecal = _currentDecal;
			int num = 0;
			if (currentDecal != (UnityEngine.Object)num)
			{
			}
			HistoryStack<DesignWorkingCopy> historyStack = DesignHistory;
			if (historyStack != null)
			{
				bool flag = ((HistoryStack<T>)(object)historyStack).CanUndo();
			}
			int num2 = 0;
			Selectable selectable = _btnUndo.Selectable;
			_btnUndoAll.Selectable.interactable = (byte)num2 != 0;
			selectable.interactable = (byte)num2 != 0;
			NotificationButton btnUndoAll = _btnUndoAll;
			NotificationButton btnUndo = _btnUndo;
			btnUndoAll.IsActive = (byte)num2 != 0;
			btnUndo.IsActive = (byte)num2 != 0;
			CanvasGroup component = _btnUndo.GetComponent<CanvasGroup>();
			CanvasGroup component2 = _btnUndoAll.GetComponent<CanvasGroup>();
			if (num2 != 0)
			{
			}
			component2.alpha = 0.5f;
			component.alpha = 0.5f;
		}

		[Cpp2IlInjected.Token(Token = "0x600197B")]
		[Cpp2IlInjected.Address(RVA = "0x1564070", Offset = "0x1562A70", VA = "0x181564070")]
		public void OnSaveClickHandler()
		{
			//Discarded unreachable code: IL_0033
			if (_gizmo.Shown)
			{
				Confirm();
			}
			SaveDesign onSaveDesign = OnSaveDesign;
			if (onSaveDesign != null)
			{
				DesignWorkingCopy current = (DesignWorkingCopy)((HistoryStack<T>)(object)DesignHistory).Current;
				onSaveDesign(current);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600197C")]
		[Cpp2IlInjected.Address(RVA = "0x1560BD0", Offset = "0x155F5D0", VA = "0x181560BD0")]
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
			_003CDrawAllAsync_003Ed__140 _003CDrawAllAsync_003Ed__ = new _003CDrawAllAsync_003Ed__140(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDrawAllAsync_003Ed__._003C_003E4__this = this;
			_003CDrawAllAsync_003Ed__.decals = list;
			Coroutine coroutine = (_drawAllCoroutine = StartCoroutine(_003CDrawAllAsync_003Ed__));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600197D")]
		[Cpp2IlInjected.Address(RVA = "0x1560B40", Offset = "0x155F540", VA = "0x181560B40")]
		[IteratorStateMachine(typeof(_003CDrawAllAsync_003Ed__140))]
		private IEnumerator DrawAllAsync(IList<IDecal> decals)
		{
			int _003C_003E1__state = default(int);
			_003CDrawAllAsync_003Ed__140 _003CDrawAllAsync_003Ed__ = new _003CDrawAllAsync_003Ed__140(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDrawAllAsync_003Ed__._003C_003E4__this = this;
			_003CDrawAllAsync_003Ed__.decals = decals;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600197E")]
		[Cpp2IlInjected.Address(RVA = "0x1560FF0", Offset = "0x155F9F0", VA = "0x181560FF0")]
		public void Hide()
		{
			//Discarded unreachable code: IL_0135
			//IL_0019: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			if (controlMapScope != null)
			{
			}
			DecalRenderingTool renderTool = _renderTool;
			int num = 0;
			if (renderTool != (UnityEngine.Object)num)
			{
				DecalRenderingTool renderTool2 = _renderTool;
				Action<Texture2D> action = (Action<Texture2D>)(object)new Action<T>(UpdateOutOfMeshTexture);
				renderTool2.remove_OnCurrentTextureChanged((Action<>)(object)action);
			}
			int num2 = 0;
			_currentDecal = (DecalBaseItem)num2;
			((HistoryStack<T>)(object)DesignHistory).Flush();
			RefreshUndoButton();
			_library.Clear();
			_layers.DeselectAll();
			_gizmo.DeselectModeToggle();
			ToggleButton flipToggle = _flipToggle;
			int num3 = ((flipToggle.IsOn = false) ? 1 : 0);
			ToggleButton cutoutToggle = _cutoutToggle;
			int num4 = ((cutoutToggle.IsOn = false) ? 1 : 0);
			ToggleButton mirrorToggle = _mirrorToggle;
			int num5 = ((mirrorToggle.IsOn = false) ? 1 : 0);
			ToggleButton transferToggle = _transferToggle;
			int num6 = ((transferToggle.IsOn = false) ? 1 : 0);
			ToggleButton uvSpaceToggle = _uvSpaceToggle;
			int num7 = ((uvSpaceToggle.IsOn = false) ? 1 : 0);
			ToggleButton repeatToggle = _repeatToggle;
			int num8 = ((repeatToggle.IsOn = false) ? 1 : 0);
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

		[Cpp2IlInjected.Token(Token = "0x600197F")]
		[Cpp2IlInjected.Address(RVA = "0x15618C0", Offset = "0x15602C0", VA = "0x1815618C0")]
		private void InitConfig()
		{
			//Discarded unreachable code: IL_002b
			TapGesture tap = _tap;
			float num = (tap.DragTolerance = tapDragTolerance);
			TapGesture tap2 = _tap;
			float num2 = (tap2.MaxDuration = tapMaxDuration);
		}

		[Cpp2IlInjected.Token(Token = "0x6001980")]
		[Cpp2IlInjected.Address(RVA = "0x1561D60", Offset = "0x1560760", VA = "0x181561D60")]
		private bool IsHittingUIElement(Vector2 pos)
		{
			bool flag = default(bool);
			if (!flag)
			{
				if ((object)base.transform != null)
				{
				}
				bool flag2 = default(bool);
				return flag2;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001981")]
		[Cpp2IlInjected.Address(RVA = "0x155F760", Offset = "0x155E160", VA = "0x18155F760")]
		private bool CanMoveCamera()
		{
			bool flag = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					break;
				}
				InputAction[] array = new InputAction[2];
				InputAction inputAction = inputOrbitCameraRotation;
				if (inputAction != null && array == null)
				{
					continue;
				}
				array[0] = inputAction;
				InputAction inputAction2 = inputOrbitCameraZoom;
				if (inputAction2 != null && array == null)
				{
					continue;
				}
				array[1] = inputAction2;
				if (!InputAction.AnyTriggered(array))
				{
					break;
				}
				int num2 = 0;
				Vector2 mousePosition = Input.mousePosition;
				if (!flag)
				{
					if ((object)base.transform != null)
					{
					}
					if (flag2)
					{
						int num3 = 0;
					}
				}
				break;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001982")]
		[Cpp2IlInjected.Address(RVA = "0x1561E50", Offset = "0x1560850", VA = "0x181561E50")]
		protected unsafe void MoveCamera(float deltaTime)
		{
			//Discarded unreachable code: IL_0075
			//IL_0068: Expected O, but got I8
			if (CanMoveCamera())
			{
				OrbitCamera orbitCamera = _orbitCamera;
				InputAction inputZoom = inputOrbitCameraZoom;
				InputAction inputRotation = inputOrbitCameraRotation;
				orbitCamera.MoveWithSmoothZoom(deltaTime, inputRotation, inputZoom);
				Transform transform = _camera.transform;
				OrbitCamera orbitCamera2 = _orbitCamera;
				UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
				float z = vector.z;
				UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
				float z2 = vector2.z;
				DOFDistance? previousDof = _previousDof;
				if ((IntPtr)(((IntPtr)(void*)previousDof == (IntPtr)3) ? 1 : 0) == (IntPtr)(void*)previousDof)
				{
					ulong num = default(ulong);
					_previousDof = (DOFDistance?)(object)num;
					PostProcessManager.Instance.SetDof(DOFDistance.FAR);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001983")]
		[Cpp2IlInjected.Address(RVA = "0x1568B60", Offset = "0x1567560", VA = "0x181568B60")]
		public void UpdateState(float deltaTime)
		{
			//IL_01e8: Expected O, but got I4
			//IL_02ba: Expected O, but got I4
			//IL_04da: Expected I4, but got I8
			//IL_04ee: Expected F4, but got I4
			//IL_07db: Expected O, but got I4
			//IL_088b: Expected I4, but got I8
			//IL_0949: Expected O, but got I4
			//IL_0981: Expected O, but got I4
			//IL_09c8: Expected O, but got I4
			//IL_09df: Expected O, but got I4
			//IL_0a1d: Expected O, but got I4
			uint num6 = default(uint);
			float y2 = default(float);
			bool currentlyZoomingIn = default(bool);
			ulong num11 = default(ulong);
			bool flag3 = default(bool);
			Task asyncTask = default(Task);
			uint num18 = default(uint);
			int num20 = default(int);
			bool flag7 = default(bool);
			ulong num25 = default(ulong);
			DecalLayerItem decalLayerItem = default(DecalLayerItem);
			int num32;
			float size = default(float);
			do
			{
				IL_0000:
				_tap.Update(deltaTime);
				_touch.Update();
				InputAction[] array = new InputAction[13];
				InputAction inputAction = inputOrbitCameraRotation;
				if (inputAction != null && array == null)
				{
					goto IL_0000;
				}
				array[0] = inputAction;
				InputAction inputAction2 = inputTriggerOrbitCameraRotation;
				if (inputAction2 != null && array == null)
				{
					goto IL_0000;
				}
				array[1] = inputAction2;
				InputAction inputAction3 = inputTriggerOrbitCameraRotationButton;
				if (inputAction3 != null && array == null)
				{
					goto IL_0000;
				}
				array[2] = inputAction3;
				InputAction inputAction4 = inputTriggerOrbitCameraRotationMouseAxis;
				if (inputAction4 != null && array == null)
				{
					goto IL_0000;
				}
				array[3] = inputAction4;
				InputAction inputAction5 = inputOrbitCameraZoom;
				if (inputAction5 != null && array == null)
				{
					goto IL_0000;
				}
				array[4] = inputAction5;
				InputAction inputAction6 = inputActionUndoPress;
				if (inputAction6 != null && array == null)
				{
					goto IL_0000;
				}
				array[5] = inputAction6;
				InputAction inputAction7 = inputActionUndoRelease;
				if (inputAction7 != null && array == null)
				{
					goto IL_0000;
				}
				array[6] = inputAction7;
				InputAction inputAction8 = inputActionUndoAll;
				if (inputAction8 != null && array == null)
				{
					goto IL_0000;
				}
				array[7] = inputAction8;
				InputAction inputAction9 = inputMotifMove;
				if (inputAction9 != null && array == null)
				{
					goto IL_0000;
				}
				array[8] = inputAction9;
				InputAction inputAction10 = inputTriggerMotifRotate;
				if (inputAction10 != null && array == null)
				{
					goto IL_0000;
				}
				array[9] = inputAction10;
				InputAction inputAction11 = inputTriggerMotifRotateButton;
				if (inputAction11 != null && array == null)
				{
					goto IL_0000;
				}
				array[10] = inputAction11;
				InputAction inputAction12 = inputTriggerMotifScale;
				if (inputAction12 != null && array == null)
				{
					goto IL_0000;
				}
				array[11] = inputAction12;
				InputAction inputAction13 = inputTriggerMotifScaleButton;
				if (inputAction13 != null && array == null)
				{
					goto IL_0000;
				}
				array[12] = inputAction13;
				InputAction.UpdateAll(deltaTime, array);
				TapGesture tap = _tap;
				if (tap.IsTrue)
				{
					DecalGizmo gizmo = _gizmo;
					Vector2 _003CScreenPos_003Ek__BackingField = tap.ScreenPos;
					float y = tap.ScreenPos.y;
					if (!gizmo.PointIsInMoveZone(_003CScreenPos_003Ek__BackingField))
					{
						DecalBaseItem currentDecal = _currentDecal;
						int num = 0;
						if (!(currentDecal != (UnityEngine.Object)num))
						{
							HistoryStack<DesignWorkingCopy> historyStack = DesignHistory;
							DecalRenderingTool renderTool = _renderTool;
							List<IDecal> list = (List<IDecal>)(object)Enumerable.ToList<IDecal>((IEnumerable<>)((DesignWorkingCopy)((HistoryStack<T>)(object)historyStack).Current).get_Decals());
							renderTool.DrawLayerMap((IList<>)list);
							TapGesture tap2 = _tap;
							DecalRenderingTool renderTool2 = _renderTool;
							Vector2 _003CScreenPos_003Ek__BackingField2 = tap2.ScreenPos;
							int num2 = 0;
							int width = Screen.width;
							TapGesture tap3 = _tap;
							int num3 = 0;
							int height = Screen.height;
							int num4 = renderTool2.FindLayerAt(_003CScreenPos_003Ek__BackingField2);
							IReadOnlyList<IDecal> decals = (IReadOnlyList<IDecal>)((DesignWorkingCopy)((HistoryStack<T>)(object)DesignHistory).Current).get_Decals();
							int num5 = 0;
							if (num5 < (int)num6)
							{
								num5 += num5;
								if (num5 == (int)num6)
								{
									goto IL_02a6;
								}
								num5++;
							}
							if (num4 < num5)
							{
								DecalLayerItem decal = _layers.Select(num4);
								SelectDecal(decal);
							}
							return;
						}
						goto IL_02a6;
					}
				}
				goto IL_02c9;
				IL_0456:
				DecalLayerContent layers = _layers;
				FocusNavigation focusNavigation = _focusNavigation;
				bool flag = (focusNavigation.IsPaused = layers.isDragging);
				MoveCamera(y2);
				goto IL_0480;
				IL_02a6:
				DecalBaseItem currentDecal2 = _currentDecal;
				int num7 = 0;
				if (currentDecal2 != (UnityEngine.Object)num7)
				{
					SaveCurrentDecal();
				}
				Cancel();
				goto IL_02c9;
				IL_0431:
				StartMoveMode();
				goto IL_0437;
				IL_02c9:
				bool isInTransition = _orbitCamera.IsInTransition;
				int num8 = 0;
				if (!isInTransition && (long)inputOrbitCameraZoom != 0 && CanMoveCamera())
				{
					int num9 = 0;
					UiRoot instance = UiRoot.Instance;
					int useKeyboardAsController = 0;
					if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && inputOrbitCameraZoom.IsTriggered)
					{
						if (_justFiredZoomPress)
						{
							goto IL_0364;
						}
						_justFiredZoomPress = true;
						currentlyZoomingIn = !_currentlyZoomingIn;
					}
					InputAction inputAction14 = inputOrbitCameraZoom;
					_justFiredZoomPress = false;
					if (inputAction14.IsTriggered)
					{
						float valueFloat = inputAction14.GetValueFloat();
						_currentlyZoomingIn = currentlyZoomingIn;
					}
				}
				goto IL_0364;
				IL_0480:
				bool flag2 = ((HistoryStack<T>)(object)DesignHistory).CanUndo();
				int num10 = 0;
				if (flag2)
				{
					if ((inputActionUndoRelease.IsTriggered ? 1 : 0) == num10 && (inputActionUndoAll.IsTriggered ? 1 : 0) == num10)
					{
						if ((inputActionUndoPress.IsTriggered ? 1 : 0) == num10)
						{
							goto IL_05f2;
						}
						_highlightImageUndoAll.gameObject.SetActive((byte)num11 != 0);
						Image highlightImageUndoAll = _highlightImageUndoAll;
						int num12 = 0;
						highlightImageUndoAll.fillAmount = num12;
						float undoAllPressDelay = _undoAllPressDelay;
						TweenerCore<float, float, FloatOptions> tweenerCore = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFillAmount(_highlightImageUndoAll, 1f, undoAllPressDelay)).Play();
					}
					if ((inputActionUndoAll.IsTriggered ? 1 : 0) != num10)
					{
						flag3 = (_justFiredPress ? 1 : 0) == num10;
					}
					GameObject gameObject = _highlightImageUndoAll.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
					_highlightImageUndoAll.fillAmount = 1f;
					Image highlightImageUndoAll2 = _highlightImageUndoAll;
					int complete = 0;
					int num13 = DOTween.Kill(highlightImageUndoAll2, (byte)complete != 0);
					if (flag3)
					{
						NotificationButton btnUndoAll = _btnUndoAll;
						BumpButton(btnUndoAll);
					}
					if (!inputActionUndoAll.IsTriggered)
					{
						if ((_justFiredPress ? 1 : 0) == num10)
						{
							NotificationButton btnUndo = _btnUndo;
							BumpButton(btnUndo);
							Undo();
						}
						if ((object)this == null)
						{
							goto IL_05dd;
						}
					}
					if ((_justFiredPress ? 1 : 0) == num10)
					{
						int num14 = 0;
						CancellationToken cancellationToken = UiRoot.Instance._menuStack.GetMenu<DecalMenu>().CancellationToken;
						int num15 = 0;
						asyncTask.FireAndForgetTask();
					}
					goto IL_05dd;
				}
				goto IL_05f2;
				IL_05f2:
				bool activeSelf = _layers._gizmoGamepadShortcuts.gameObject.activeSelf;
				DecalGizmo gizmo2 = _gizmo;
				if (activeSelf != gizmo2.Shown)
				{
					GameObject gameObject2 = _layers._gizmoGamepadShortcuts.gameObject;
					bool _003CShown_003Ek__BackingField = _gizmo.Shown;
					gameObject2.SetActive(_003CShown_003Ek__BackingField);
				}
				bool activeSelf2 = _layers._openBasePickerGamepadShortcuts.gameObject.activeSelf;
				if ((_gizmo.Shown ? 1 : 0) != num10)
				{
				}
				bool flag4 = (_baseColorPicker.isShown ? 1 : 0) == num10;
				if (activeSelf2 != flag4)
				{
					GameObject gameObject3 = _layers._openBasePickerGamepadShortcuts.gameObject;
					if ((_gizmo.Shown ? 1 : 0) != num10)
					{
					}
					bool active2 = (_baseColorPicker.isShown ? 1 : 0) == num10;
					gameObject3.SetActive(active2);
				}
				bool activeSelf3 = _layers._cameraViewGamepadShortcuts.gameObject.activeSelf;
				bool flag5 = !_library._mcFilterContent.gameObject.activeSelf;
				if (activeSelf3 != flag5)
				{
					GameObject gameObject4 = _layers._cameraViewGamepadShortcuts.gameObject;
					bool active3 = !_library._mcFilterContent.gameObject.activeSelf;
					gameObject4.SetActive(active3);
				}
				bool activeSelf4 = _gizmo.rotateHighlight.gameObject.activeSelf;
				if (_mode != Mode.Rotate && (inputTriggerMotifRotateButton.IsTriggered ? 1 : 0) == num10)
				{
					int num16 = 0;
					UiRoot instance2 = UiRoot.Instance;
					int useKeyboardAsController2 = 0;
					if (instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0))
					{
					}
					DecalGizmo gizmo3 = _gizmo;
					int num17 = 0;
				}
				if ((activeSelf4 ? 1u : 0u) != num18)
				{
					GameObject gameObject5 = _gizmo.rotateHighlight.gameObject;
					if (_mode != Mode.Rotate && (inputTriggerMotifRotateButton.IsTriggered ? 1 : 0) == num10)
					{
						int num19 = 0;
						UiRoot instance3 = UiRoot.Instance;
						int useKeyboardAsController3 = 0;
						if (instance3.IsControllerConnected((byte)useKeyboardAsController3 != 0))
						{
							num20 = 0;
						}
						DecalGizmo gizmo4 = _gizmo;
						int num21 = 0;
						bool flag6 = gizmo4.PointIsInRotateZone((Vector2)num20);
					}
					gameObject5.SetActive((byte)num18 != 0);
				}
				bool activeSelf5 = _gizmo.scaleHighlight.gameObject.activeSelf;
				if (_mode != Mode.Scale && (inputTriggerMotifScaleButton.IsTriggered ? 1 : 0) == num10)
				{
					int num22 = 0;
					UiRoot instance4 = UiRoot.Instance;
					int useKeyboardAsController4 = 0;
					if (instance4.IsControllerConnected((byte)useKeyboardAsController4 != 0))
					{
					}
					DecalGizmo gizmo5 = _gizmo;
					int num23 = 0;
				}
				if (activeSelf5 != flag7)
				{
					GameObject gameObject6 = _gizmo.scaleHighlight.gameObject;
					if (_mode != Mode.Scale && (inputTriggerMotifScaleButton.IsTriggered ? 1 : 0) == num10)
					{
						int num24 = 0;
						UiRoot instance5 = UiRoot.Instance;
						int useKeyboardAsController5 = 0;
						if (!instance5.IsControllerConnected((byte)useKeyboardAsController5 != 0))
						{
						}
					}
					gameObject6.SetActive((byte)num25 != 0);
				}
				DecalLayerContent layers2 = _layers;
				Mode mode = _mode;
				TextBase motifControlGamepadShortcutsText = layers2._motifControlGamepadShortcutsText;
				if (mode == Mode.Rotate || (inputTriggerMotifRotateButton.IsTriggered ? 1 : 0) != num10 || mode == Mode.Scale || (inputTriggerMotifScaleButton.IsTriggered ? 1 : 0) == num10)
				{
				}
				motifControlGamepadShortcutsText.StringID = "menu.decal_rotate_motif";
				if ((_gizmo.Shown ? 1 : 0) == num10 && (_baseColorPicker.isShown ? 1 : 0) == num10 && (_colorPicker.isShown ? 1 : 0) == num10 && (_mcButtonContent.isOpened ? 1 : 0) == num10)
				{
					DecalLibraryContent library = _library;
				}
				int num26 = 0;
				UiRoot instance6 = UiRoot.Instance;
				int useKeyboardAsController6 = 0;
				if (!instance6.IsControllerConnected((byte)useKeyboardAsController6 != 0))
				{
					TextBase keyboardEscShortcutText = _keyboardEscShortcutText;
					int num27 = 0;
					if (!(keyboardEscShortcutText != (UnityEngine.Object)num27))
					{
						goto IL_0000;
					}
					TextBase keyboardEscShortcutText2 = _keyboardEscShortcutText;
					if (num10 != 0)
					{
					}
					string text = (keyboardEscShortcutText2.StringID = _escButtonCloseStringID);
				}
				TextBase gamepadEscShortcutText = _gamepadEscShortcutText;
				int num28 = 0;
				if (gamepadEscShortcutText != (UnityEngine.Object)num28)
				{
					TextBase gamepadEscShortcutText2 = _gamepadEscShortcutText;
					if (num10 != 0)
					{
					}
					string text2 = (gamepadEscShortcutText2.StringID = _escButtonCloseStringID);
				}
				ISupportsFocusNavigation focusedElement = _focusNavigation._focusedElement;
				while (focusedElement == null)
				{
				}
				int num29 = 0;
				while (focusedElement == null)
				{
				}
				int num30 = 0;
				if (!(decalLayerItem != (UnityEngine.Object)num30))
				{
				}
				DecalBaseItem currentDecal3 = _currentDecal;
				int num31 = 0;
				bool flag8 = currentDecal3 == (UnityEngine.Object)num31;
				if (_layers._deleteLayerGamepadShortcuts.gameObject.activeSelf != flag8)
				{
					_layers._deleteLayerGamepadShortcuts.gameObject.SetActive(flag8);
				}
				num32 = 0;
				continue;
				IL_0437:
				MoveMode();
				int num33 = 0;
				UiRoot instance7 = UiRoot.Instance;
				int useKeyboardAsController7 = 0;
				if (instance7.IsControllerConnected((byte)useKeyboardAsController7 != 0))
				{
					goto IL_0456;
				}
				goto IL_0480;
				IL_0364:
				Mode mode2 = _mode;
				if (mode2 != 0)
				{
					if (mode2 != 0)
					{
						if (mode2 != 0)
						{
							if (mode2 != 0)
							{
								if (mode2 != Mode.Move)
								{
									goto IL_0480;
								}
								OrbitAroundMode();
							}
							RotateMode();
						}
						int num34 = 0;
						UiRoot instance8 = UiRoot.Instance;
						int useKeyboardAsController8 = 0;
						if (instance8.IsControllerConnected((byte)useKeyboardAsController8 != 0))
						{
							InputAction inputAction15 = inputTriggerMotifScale;
							if (!inputAction15.IsTriggered)
							{
								goto IL_0431;
							}
							Vector2 valueVector = inputAction15.GetValueVector2();
							_renderTool.Size = size;
						}
						TouchGesture touch = _touch;
						if (touch.Phase != TouchGesture.PhaseType.Ended)
						{
							DecalGizmo gizmo6 = _gizmo;
							Vector2 _003CScreenPos_003Ek__BackingField3 = touch.ScreenPos;
							y2 = touch.ScreenPos.y;
							Vector2 vector = gizmo6.ScreenToLocal(_003CScreenPos_003Ek__BackingField3);
							float radius = _gizmo.Radius;
							_renderTool.Size = y2;
						}
						goto IL_0431;
					}
					goto IL_0437;
				}
				goto IL_0456;
				IL_05dd:
				bool flag9 = (_justFiredPress = inputActionUndoAll.IsTriggered);
				goto IL_05f2;
			}
			while (!(decalLayerItem != (UnityEngine.Object)num32) || !(_currentHighlightedLayer != decalLayerItem));
			_currentHighlightedLayer = decalLayerItem;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001984")]
		[Cpp2IlInjected.Address(RVA = "0x156A480", Offset = "0x1568E80", VA = "0x18156A480")]
		private void UpdateZoomDirection()
		{
			//Discarded unreachable code: IL_0097
			bool isInTransition = _orbitCamera.IsInTransition;
			if (isInTransition || (long)inputOrbitCameraZoom == 0 || !CanMoveCamera())
			{
				return;
			}
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && inputOrbitCameraZoom.IsTriggered)
			{
				if (!_justFiredZoomPress)
				{
					_justFiredZoomPress = true;
					bool flag = (_currentlyZoomingIn = !_currentlyZoomingIn);
				}
				return;
			}
			InputAction inputAction = inputOrbitCameraZoom;
			_justFiredZoomPress = false;
			while (!inputAction.IsTriggered)
			{
			}
			float valueFloat = inputAction.GetValueFloat();
			int num2 = 0;
			_currentlyZoomingIn = isInTransition;
		}

		[Cpp2IlInjected.Token(Token = "0x6001985")]
		[Cpp2IlInjected.Address(RVA = "0x1568950", Offset = "0x1567350", VA = "0x181568950")]
		private unsafe void UpdateDof()
		{
			//Discarded unreachable code: IL_004a
			//IL_003d: Expected O, but got I8
			Transform transform = _camera.transform;
			OrbitCamera orbitCamera = _orbitCamera;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z2 = vector2.z;
			DOFDistance? previousDof = _previousDof;
			if ((IntPtr)(((IntPtr)(void*)previousDof == (IntPtr)3) ? 1 : 0) == (IntPtr)(void*)previousDof)
			{
				ulong num = default(ulong);
				_previousDof = (DOFDistance?)(object)num;
				PostProcessManager.Instance.SetDof(DOFDistance.FAR);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001986")]
		[Cpp2IlInjected.Address(RVA = "0x156A550", Offset = "0x1568F50", VA = "0x18156A550")]
		private Vector2 ZoomModifier(Vector2 value)
		{
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0) || _currentlyZoomingIn)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001987")]
		[Cpp2IlInjected.Address(RVA = "0x1568910", Offset = "0x1567310", VA = "0x181568910")]
		private void UpdateColor(Color color)
		{
			//Discarded unreachable code: IL_001a
			DecalBaseItem currentDecal = _currentDecal;
			SetColor(currentDecal);
			_gizmo.DeselectColorToggle();
		}

		[Cpp2IlInjected.Token(Token = "0x6001988")]
		[Cpp2IlInjected.Address(RVA = "0x15688D0", Offset = "0x15672D0", VA = "0x1815688D0")]
		private void UpdateBaseColor(Color color)
		{
			//Discarded unreachable code: IL_000c
			_layers.DeselectBaseColorToggle();
		}

		[Cpp2IlInjected.Token(Token = "0x6001989")]
		[Cpp2IlInjected.Address(RVA = "0x1564940", Offset = "0x1563340", VA = "0x181564940")]
		private void PreviewColor(Color color)
		{
			//Discarded unreachable code: IL_009a
			//IL_0058: Expected O, but got I4
			//IL_007b: Expected O, but got I4
			if (!_colorPicker.isShown)
			{
				return;
			}
			Color currentPreviewedDecalColor = _currentPreviewedDecalColor;
			bool flag = default(bool);
			if (flag)
			{
				WadrobeAppearanceColorItem[] componentsInChildren = _colorPicker._mcContent.GetComponentsInChildren<WadrobeAppearanceColorItem>();
				Func<WadrobeAppearanceColorItem, bool> func = (Func<WadrobeAppearanceColorItem, bool>)(object)(Func<T, TResult>)delegate(WadrobeAppearanceColorItem x)
				{
					//Discarded unreachable code: IL_0014
					Color currentPreviewedDecalColor2 = _currentPreviewedDecalColor;
					return x.Color == currentPreviewedDecalColor2;
				};
				IEnumerable<WadrobeAppearanceColorItem> enumerable = (IEnumerable<WadrobeAppearanceColorItem>)Enumerable.Where<WadrobeAppearanceColorItem>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func);
				WadrobeAppearanceColorItem wadrobeAppearanceColorItem = Enumerable.FirstOrDefault<WadrobeAppearanceColorItem>((IEnumerable<>)enumerable);
				int num = 0;
				if (wadrobeAppearanceColorItem != (UnityEngine.Object)num)
				{
					Enumerable.FirstOrDefault<WadrobeAppearanceColorItem>((IEnumerable<>)enumerable).RemoveHighlight();
				}
			}
			DecalBaseItem currentDecal = _currentDecal;
			int num2 = 0;
			if (currentDecal != (UnityEngine.Object)num2 && _currentDecal.DecalData.allowColoring_)
			{
				DecalRenderingTool renderTool = _renderTool;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600198A")]
		[Cpp2IlInjected.Address(RVA = "0x1564710", Offset = "0x1563110", VA = "0x181564710")]
		private void PreviewBaseColor(Color color)
		{
			//Discarded unreachable code: IL_007c
			//IL_0055: Expected O, but got I4
			if (!_baseColorPicker.isShown)
			{
				return;
			}
			Color currentPreviewedBaseColor = _currentPreviewedBaseColor;
			bool flag = default(bool);
			if (flag)
			{
				WadrobeAppearanceColorItem[] componentsInChildren = _baseColorPicker._mcContent.GetComponentsInChildren<WadrobeAppearanceColorItem>();
				Func<WadrobeAppearanceColorItem, bool> func = (Func<WadrobeAppearanceColorItem, bool>)(object)(Func<T, TResult>)delegate(WadrobeAppearanceColorItem x)
				{
					//Discarded unreachable code: IL_0014
					Color currentPreviewedBaseColor2 = _currentPreviewedBaseColor;
					return x.Color == currentPreviewedBaseColor2;
				};
				IEnumerable<WadrobeAppearanceColorItem> enumerable = (IEnumerable<WadrobeAppearanceColorItem>)Enumerable.Where<WadrobeAppearanceColorItem>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func);
				WadrobeAppearanceColorItem wadrobeAppearanceColorItem = Enumerable.FirstOrDefault<WadrobeAppearanceColorItem>((IEnumerable<>)enumerable);
				int num = 0;
				if (wadrobeAppearanceColorItem != (UnityEngine.Object)num)
				{
					Enumerable.FirstOrDefault<WadrobeAppearanceColorItem>((IEnumerable<>)enumerable).RemoveHighlight();
				}
			}
			AvatarCustomization avatarCustomization = AvatarCustomization;
			AvatarAppearance avatarAppearance = Avatar;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600198B")]
		[Cpp2IlInjected.Address(RVA = "0x1565B90", Offset = "0x1564590", VA = "0x181565B90")]
		private void SetBaseColor(Color color)
		{
			//Discarded unreachable code: IL_007b
			AvatarCustomization avatarCustomization = AvatarCustomization;
			AvatarAppearance avatarAppearance = Avatar;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			DecalColorPicker baseColorPicker = _baseColorPicker;
			DesignWorkingCopy designWorkingCopy = new DesignWorkingCopy((DesignWorkingCopy)((HistoryStack<T>)(object)DesignHistory).Current);
			string text = default(string);
			string text2 = "#" + text;
			if (designWorkingCopy.Data.baseColor_ != text2)
			{
				designWorkingCopy.Data.BaseColor = text2;
				((HistoryStack<T>)(object)DesignHistory).Push((T)designWorkingCopy);
				RefreshUndoButton();
			}
			DecalLayerContent layers = _layers;
		}

		[Cpp2IlInjected.Token(Token = "0x600198C")]
		[Cpp2IlInjected.Address(RVA = "0x1564180", Offset = "0x1562B80", VA = "0x181564180")]
		public void OpenBaseColorPicker()
		{
			//Discarded unreachable code: IL_004f
			if (layerTransformInitialized)
			{
				if (!_baseColorPicker.isShown)
				{
					_gizmo.DeselectModeToggle();
					_layers._btnBaseColor.IsOn = true;
				}
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					SetFocus();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600198D")]
		[Cpp2IlInjected.Address(RVA = "0x1560A70", Offset = "0x155F470", VA = "0x181560A70")]
		public void DeleteHighlightedLayer()
		{
			//Discarded unreachable code: IL_004f
			//IL_0026: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				DecalLayerItem currentHighlightedLayer = _currentHighlightedLayer;
				int num2 = 0;
				if (currentHighlightedLayer != (UnityEngine.Object)num2)
				{
					_currentHighlightedLayer._deleteButton.m_OnClick?.Invoke();
				}
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600198E")]
		[Cpp2IlInjected.Address(RVA = "0x15628A0", Offset = "0x15612A0", VA = "0x1815628A0")]
		public void NextCameraView()
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

		[Cpp2IlInjected.Token(Token = "0x600198F")]
		[Cpp2IlInjected.Address(RVA = "0x15679F0", Offset = "0x15663F0", VA = "0x1815679F0")]
		private void ToggleFlip(bool isOn)
		{
			//Discarded unreachable code: IL_000d
			_renderTool.SetFlip(isOn);
		}

		[Cpp2IlInjected.Token(Token = "0x6001990")]
		[Cpp2IlInjected.Address(RVA = "0x1567A20", Offset = "0x1566420", VA = "0x181567A20")]
		private void ToggleMirrorMode(bool isOn)
		{
			//Discarded unreachable code: IL_0033, IL_0034
			int count = ((RepeatedField<T>)(object)((DesignWorkingCopy)((HistoryStack<T>)(object)DesignHistory).Current).Data.decals_).Count;
			DecalRenderingTool renderTool = _renderTool;
			ToggleButton mirrorToggle = _mirrorToggle;
			int num = ((mirrorToggle.IsOn = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001991")]
		[Cpp2IlInjected.Address(RVA = "0x1567990", Offset = "0x1566390", VA = "0x181567990")]
		private void ToggleCutoutMode(bool isOn)
		{
			//Discarded unreachable code: IL_000d
			_renderTool.ToggleCutoutMode(isOn);
		}

		[Cpp2IlInjected.Token(Token = "0x6001992")]
		[Cpp2IlInjected.Address(RVA = "0x1567B30", Offset = "0x1566530", VA = "0x181567B30")]
		private void ToggleSeeThroughMode(bool isOn)
		{
			//Discarded unreachable code: IL_0021
			_renderTool.ToggleSeeThroughMode(isOn);
			if (isOn)
			{
				ToggleButton uvSpaceToggle = _uvSpaceToggle;
				int num = ((uvSpaceToggle.IsOn = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001993")]
		[Cpp2IlInjected.Address(RVA = "0x1567B80", Offset = "0x1566580", VA = "0x181567B80")]
		private void ToggleUVSpace(bool isOn)
		{
			//Discarded unreachable code: IL_0021
			_renderTool.ToggleUVSpaceMode(isOn);
			if (isOn)
			{
				ToggleButton transferToggle = _transferToggle;
				int num = ((transferToggle.IsOn = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001994")]
		[Cpp2IlInjected.Address(RVA = "0x1567AE0", Offset = "0x15664E0", VA = "0x181567AE0")]
		private void ToggleRepeat(bool isOn)
		{
			//Discarded unreachable code: IL_001d
			_renderTool.ToggleRepeatMode(isOn);
			if (isOn)
			{
				_uvSpaceToggle.IsOn = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001995")]
		[Cpp2IlInjected.Address(RVA = "0x1565410", Offset = "0x1563E10", VA = "0x181565410")]
		private void SelectDecal(DecalBaseItem decal)
		{
			//Discarded unreachable code: IL_0237
			//IL_0009: Expected O, but got I4
			//IL_007f: Expected O, but got I4
			//IL_00a6: Expected O, but got I4
			//IL_0227: Expected O, but got I4
			int num = 0;
			if (!(decal == (UnityEngine.Object)num))
			{
				if (decal.Layer == -1)
				{
					int count = ((RepeatedField<T>)(object)((DesignWorkingCopy)((HistoryStack<T>)(object)DesignHistory).Current).Data.decals_).Count;
					DecalRenderingTool renderTool = _renderTool;
					if (count >= renderTool.maxDecals)
					{
						goto IL_0213;
					}
				}
				bool flag = default(bool);
				DecalRenderingTool renderTool2 = default(DecalRenderingTool);
				if (flag && decal.Layer == -1)
				{
					SetColor(decal);
					DecalItemData _003CDecalData_003Ek__BackingField = decal.DecalData;
					renderTool2 = _renderTool;
					int iD = _003CDecalData_003Ek__BackingField.ID;
				}
				int num2 = 0;
				if (renderTool2 != (UnityEngine.Object)num2)
				{
					SaveCurrentDecal();
				}
				_currentDecal = decal;
				int num3 = 0;
				Color white = Color.white;
				_colorPicker.RefreshSelected((Color)num3);
				_layers.DeselectAddLayerToggle();
				_layers.DeselectAll();
				int num4 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
				RepeatedField<Decal> decals_ = ((DesignWorkingCopy)((HistoryStack<T>)(object)DesignHistory).Current).Data.decals_;
				ToggleButton flipToggle = _flipToggle;
				Decal decal2 = default(Decal);
				bool flag2 = (flipToggle.IsOn = decal2.flipped_);
				ToggleButton cutoutToggle = _cutoutToggle;
				bool flag3 = (cutoutToggle.IsOn = decal2.cutout_);
				HistoryStack<DesignWorkingCopy> historyStack = DesignHistory;
				ToggleButton mirrorToggle = _mirrorToggle;
				int count2 = ((RepeatedField<T>)(object)((DesignWorkingCopy)((HistoryStack<T>)(object)historyStack).Current).Data.decals_).Count;
				DecalRenderingTool renderTool3 = _renderTool;
				bool flag5 = (mirrorToggle.IsActive = count2 < renderTool3.maxDecals);
				ToggleButton repeatToggle = _repeatToggle;
				bool flag6 = (repeatToggle.IsOn = decal2.repeat_);
				ToggleButton uvSpaceToggle = _uvSpaceToggle;
				bool flag7 = (uvSpaceToggle.IsOn = decal2.uVSpace_);
				ToggleButton transferToggle = _transferToggle;
				bool flag8 = (transferToggle.IsOn = decal2.seeThrough_);
				int num5 = 0;
				Task asyncTask2 = default(Task);
				asyncTask2.FireAndForgetTask();
				_library.DeselectAll();
				bool active = default(bool);
				_layers._deleteLayerGamepadShortcuts.gameObject.SetActive(active);
				int num6 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					SetFocus();
				}
				_layers.DeselectAddLayerToggle();
				RefreshUndoButton();
				int num7 = 0;
				UiRoot.Instance.MenuSectionChange("ToMMotifSelection");
			}
			goto IL_0213;
			IL_0213:
			DecalBaseItem currentDecal = _currentDecal;
			int num8 = 0;
			if (currentDecal != (UnityEngine.Object)num8)
			{
				SaveCurrentDecal();
			}
			Cancel();
		}

		[Cpp2IlInjected.Token(Token = "0x6001996")]
		[Cpp2IlInjected.Address(RVA = "0x155F320", Offset = "0x155DD20", VA = "0x18155F320")]
		private void AnimateOpenLibrary()
		{
			//Discarded unreachable code: IL_00ee
			//IL_001d: Expected O, but got I8
			Tween libraryTween = _libraryTween;
			if (libraryTween != null)
			{
				int complete = 0;
				libraryTween.Kill((byte)complete != 0);
			}
			_libraryTween = (Tween)0;
			Transform transform = _library.transform;
			int num = 0;
			Sequence s = DOTween.Sequence();
			Transform transform2 = _layers.transform;
			float layerOriX = _layerOriX;
			int num2 = 0;
			TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions> t = (TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX(transform2, layerOriX, 0.35f, (byte)num2 != 0);
			Sequence s2 = s.Append(t);
			Transform transform3 = _library.transform;
			Transform transform4 = _library.transform;
			Transform transform5 = _library.transform;
			TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions> t2 = default(TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions>);
			Sequence t3 = s2.Join(t2);
			TweenCallback tweenCallback = delegate
			{
				//Discarded unreachable code: IL_0028
				_library.isShown = true;
				AK.Wwise.Event openSlideSfx = _openSlideSfx;
				if (openSlideSfx != null)
				{
					GameObject gameObject = base.gameObject;
					uint num4 = openSlideSfx.Post(gameObject);
				}
			};
			Sequence t4 = t3.OnStart(tweenCallback);
			TweenCallback tweenCallback2 = OnUpdatePosition;
			Sequence t5 = t4.OnUpdate(tweenCallback2);
			TweenCallback action = delegate
			{
				int num3 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					SetFocus();
				}
				throw new NullReferenceException();
			};
			Sequence sequence = (Sequence)(_libraryTween = t5.OnComplete(action));
		}

		[Cpp2IlInjected.Token(Token = "0x6001997")]
		[Cpp2IlInjected.Address(RVA = "0x155E9D0", Offset = "0x155D3D0", VA = "0x18155E9D0")]
		private void AnimateCloseLibrary()
		{
			//Discarded unreachable code: IL_00f1
			//IL_001d: Expected O, but got I4
			Tween libraryTween = _libraryTween;
			if (libraryTween != null)
			{
				int complete = 0;
				libraryTween.Kill((byte)complete != 0);
			}
			int num = 0;
			_libraryTween = (Tween)num;
			Transform transform = _library.transform;
			int num2 = 0;
			Sequence s = DOTween.Sequence();
			Transform transform2 = _layers.transform;
			int num3 = 0;
			float layerOriX = _layerOriX;
			TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions> t = (TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX(transform2, layerOriX, 0.35f, (byte)num3 != 0);
			Sequence s2 = s.Append(t);
			Transform transform3 = _library.transform;
			int num4 = 0;
			float libraryOriX = _libraryOriX;
			TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions> t2 = (TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX(transform3, libraryOriX, 0.35f, (byte)num4 != 0);
			Sequence t3 = s2.Join(t2);
			TweenCallback tweenCallback = delegate
			{
				//Discarded unreachable code: IL_0028
				_library.isShown = false;
				AK.Wwise.Event closeSlideSfx = _closeSlideSfx;
				if (closeSlideSfx != null)
				{
					GameObject gameObject = base.gameObject;
					uint num6 = closeSlideSfx.Post(gameObject);
				}
			};
			Sequence t4 = t3.OnStart(tweenCallback);
			TweenCallback tweenCallback2 = OnUpdatePosition;
			Sequence t5 = t4.OnUpdate(tweenCallback2);
			TweenCallback action = delegate
			{
				_library.RefreshCategoryDisplay();
				int num5 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					SetFocus();
				}
				throw new NullReferenceException();
			};
			Sequence sequence = (Sequence)(_libraryTween = t5.OnComplete(action));
		}

		[Cpp2IlInjected.Token(Token = "0x6001998")]
		[Cpp2IlInjected.Address(RVA = "0x155EC80", Offset = "0x155D680", VA = "0x18155EC80")]
		private void AnimateOpenBaseColorPicker()
		{
			//Discarded unreachable code: IL_00e1
			//IL_001d: Expected O, but got I8
			Tween baseColorTween = _baseColorTween;
			if (baseColorTween != null)
			{
				int complete = 0;
				baseColorTween.Kill((byte)complete != 0);
			}
			_baseColorTween = (Tween)0;
			Transform transform = _baseColorPicker.transform;
			int num = 0;
			Sequence s = DOTween.Sequence();
			Transform transform2 = _layers.transform;
			float layerOriX = _layerOriX;
			int num2 = 0;
			TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions> t = (TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX(transform2, layerOriX, 0.35f, (byte)num2 != 0);
			Sequence s2 = s.Append(t);
			Transform transform3 = _baseColorPicker.transform;
			Transform transform4 = _baseColorPicker.transform;
			TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions> t2 = default(TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions>);
			Sequence t3 = s2.Join(t2);
			TweenCallback tweenCallback = delegate
			{
				//Discarded unreachable code: IL_0028
				_baseColorPicker.isShown = true;
				AK.Wwise.Event openSlideSfx = _openSlideSfx;
				if (openSlideSfx != null)
				{
					GameObject gameObject = base.gameObject;
					uint num4 = openSlideSfx.Post(gameObject);
				}
			};
			Sequence t4 = t3.OnStart(tweenCallback);
			TweenCallback tweenCallback2 = OnUpdatePosition;
			Sequence t5 = t4.OnUpdate(tweenCallback2);
			TweenCallback action = delegate
			{
				int num3 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					SetFocus();
				}
				throw new NullReferenceException();
			};
			Sequence sequence = (Sequence)(_baseColorTween = t5.OnComplete(action));
		}

		[Cpp2IlInjected.Token(Token = "0x6001999")]
		[Cpp2IlInjected.Address(RVA = "0x155E470", Offset = "0x155CE70", VA = "0x18155E470")]
		private void AnimateCloseBaseColorPicker()
		{
			//Discarded unreachable code: IL_00f1
			//IL_001d: Expected O, but got I4
			Tween baseColorTween = _baseColorTween;
			if (baseColorTween != null)
			{
				int complete = 0;
				baseColorTween.Kill((byte)complete != 0);
			}
			int num = 0;
			_baseColorTween = (Tween)num;
			Transform transform = _baseColorPicker.transform;
			int num2 = 0;
			Sequence s = DOTween.Sequence();
			Transform transform2 = _layers.transform;
			int num3 = 0;
			float layerOriX = _layerOriX;
			TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions> t = (TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX(transform2, layerOriX, 0.35f, (byte)num3 != 0);
			Sequence s2 = s.Append(t);
			Transform transform3 = _baseColorPicker.transform;
			int num4 = 0;
			float baseColorOriX = _baseColorOriX;
			TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions> t2 = (TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX(transform3, baseColorOriX, 0.35f, (byte)num4 != 0);
			Sequence t3 = s2.Join(t2);
			TweenCallback tweenCallback = delegate
			{
				//Discarded unreachable code: IL_0028
				_baseColorPicker.isShown = false;
				AK.Wwise.Event closeSlideSfx = _closeSlideSfx;
				if (closeSlideSfx != null)
				{
					GameObject gameObject = base.gameObject;
					uint num7 = closeSlideSfx.Post(gameObject);
				}
			};
			Sequence t4 = t3.OnStart(tweenCallback);
			TweenCallback tweenCallback2 = OnUpdatePosition;
			Sequence t5 = t4.OnUpdate(tweenCallback2);
			TweenCallback action = delegate
			{
				AnimatedToggleButton btnBaseColor = _layers._btnBaseColor;
				int num5 = ((btnBaseColor.IsOn = false) ? 1 : 0);
				int num6 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					SetFocus();
				}
				throw new NullReferenceException();
			};
			Sequence sequence = (Sequence)(_baseColorTween = t5.OnComplete(action));
		}

		[Cpp2IlInjected.Token(Token = "0x600199A")]
		[Cpp2IlInjected.Address(RVA = "0x155EFD0", Offset = "0x155D9D0", VA = "0x18155EFD0")]
		private void AnimateOpenDecalColorPicker()
		{
			//Discarded unreachable code: IL_00e1
			//IL_001d: Expected O, but got I8
			Tween decalColorTween = _decalColorTween;
			if (decalColorTween != null)
			{
				int complete = 0;
				decalColorTween.Kill((byte)complete != 0);
			}
			_decalColorTween = (Tween)0;
			Transform transform = _colorPicker.transform;
			int num = 0;
			Sequence s = DOTween.Sequence();
			Transform transform2 = _layers.transform;
			float layerOriX = _layerOriX;
			int num2 = 0;
			TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions> t = (TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX(transform2, layerOriX, 0.35f, (byte)num2 != 0);
			Sequence s2 = s.Append(t);
			Transform transform3 = _colorPicker.transform;
			Transform transform4 = _colorPicker.transform;
			TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions> t2 = default(TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions>);
			Sequence t3 = s2.Join(t2);
			TweenCallback tweenCallback = delegate
			{
				//Discarded unreachable code: IL_0028
				_colorPicker.isShown = true;
				AK.Wwise.Event openSlideSfx = _openSlideSfx;
				if (openSlideSfx != null)
				{
					GameObject gameObject = base.gameObject;
					uint num4 = openSlideSfx.Post(gameObject);
				}
			};
			Sequence t4 = t3.OnStart(tweenCallback);
			TweenCallback tweenCallback2 = OnUpdatePosition;
			Sequence t5 = t4.OnUpdate(tweenCallback2);
			TweenCallback action = delegate
			{
				int num3 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					SetFocus();
				}
				throw new NullReferenceException();
			};
			Sequence sequence = (Sequence)(_decalColorTween = t5.OnComplete(action));
		}

		[Cpp2IlInjected.Token(Token = "0x600199B")]
		[Cpp2IlInjected.Address(RVA = "0x155E720", Offset = "0x155D120", VA = "0x18155E720")]
		private void AnimateCloseDecalColorPicker()
		{
			//Discarded unreachable code: IL_00f1
			//IL_001d: Expected O, but got I4
			Tween decalColorTween = _decalColorTween;
			if (decalColorTween != null)
			{
				int complete = 0;
				decalColorTween.Kill((byte)complete != 0);
			}
			int num = 0;
			_decalColorTween = (Tween)num;
			Transform transform = _colorPicker.transform;
			int num2 = 0;
			Sequence s = DOTween.Sequence();
			Transform transform2 = _layers.transform;
			int num3 = 0;
			float layerOriX = _layerOriX;
			TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions> t = (TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX(transform2, layerOriX, 0.35f, (byte)num3 != 0);
			Sequence s2 = s.Append(t);
			Transform transform3 = _colorPicker.transform;
			int num4 = 0;
			float decalColorOriX = _decalColorOriX;
			TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions> t2 = (TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX(transform3, decalColorOriX, 0.35f, (byte)num4 != 0);
			Sequence t3 = s2.Join(t2);
			TweenCallback tweenCallback = delegate
			{
				//Discarded unreachable code: IL_0028
				_colorPicker.isShown = false;
				AK.Wwise.Event closeSlideSfx = _closeSlideSfx;
				if (closeSlideSfx != null)
				{
					GameObject gameObject = base.gameObject;
					uint num6 = closeSlideSfx.Post(gameObject);
				}
			};
			Sequence t4 = t3.OnStart(tweenCallback);
			TweenCallback tweenCallback2 = OnUpdatePosition;
			Sequence t5 = t4.OnUpdate(tweenCallback2);
			TweenCallback action = delegate
			{
				int num5 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					SetFocus();
				}
				throw new NullReferenceException();
			};
			Sequence sequence = (Sequence)(_decalColorTween = t5.OnComplete(action));
		}

		[Cpp2IlInjected.Token(Token = "0x600199C")]
		[Cpp2IlInjected.Address(RVA = "0x155E390", Offset = "0x155CD90", VA = "0x18155E390")]
		private void AddDecalHandler(bool isOn)
		{
			//Discarded unreachable code: IL_0073
			if (!_baseColorPicker.isShown)
			{
				if (!isOn)
				{
					AnimateCloseLibrary();
					_library.isShown = false;
				}
				_layers.DeselectBaseColorToggle();
				_gizmo.DeselectColorToggle();
				AnimateOpenLibrary();
				_library.OnPanelActivate();
				_library.isShown = true;
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					SetFocus();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600199D")]
		[Cpp2IlInjected.Address(RVA = "0x1565D90", Offset = "0x1564790", VA = "0x181565D90")]
		private void SetColor(DecalBaseItem decal)
		{
			//Discarded unreachable code: IL_0070
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(decal == (UnityEngine.Object)num) && !decal.DecalData.allowColoring_)
			{
				Color white = Color.white;
				Color white2 = Color.white;
			}
			DecalColorPicker colorPicker = _colorPicker;
			if ((object)decal != null)
			{
				DecalColorPicker colorPicker2 = _colorPicker;
				RawImage rawImage = decal._decal.RawImage;
			}
			DecalColorPicker colorPicker3 = _colorPicker;
			DecalRenderingTool renderTool = _renderTool;
			DecalColorPicker colorPicker4 = _colorPicker;
			Color currentDecalColor = _currentDecalColor;
			colorPicker4.RefreshSelected(currentDecalColor);
		}

		[Cpp2IlInjected.Token(Token = "0x600199E")]
		[Cpp2IlInjected.Address(RVA = "0x1561900", Offset = "0x1560300", VA = "0x181561900")]
		[AsyncStateMachine(typeof(_003CInitCurrentLayer_003Ed__176))]
		private Task InitCurrentLayer()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600199F")]
		[Cpp2IlInjected.Address(RVA = "0x1561280", Offset = "0x155FC80", VA = "0x181561280")]
		private void InitCameraPosition(bool mustCenterTarget, bool keepTargetDistance)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60019A0")]
		[Cpp2IlInjected.Address(RVA = "0x1561A00", Offset = "0x1560400", VA = "0x181561A00")]
		[AsyncStateMachine(typeof(_003CInitCurrentLibDecal_003Ed__178))]
		private Task InitCurrentLibDecal()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60019A1")]
		[Cpp2IlInjected.Address(RVA = "0x1566180", Offset = "0x1564B80", VA = "0x181566180")]
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

		[Cpp2IlInjected.Token(Token = "0x60019A2")]
		[Cpp2IlInjected.Address(RVA = "0x1568B00", Offset = "0x1567500", VA = "0x181568B00")]
		private void UpdateOutOfMeshTexture(Texture2D texture)
		{
			//Discarded unreachable code: IL_0028
			_outOfMeshImage.texture = texture;
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019A3")]
		[Cpp2IlInjected.Address(RVA = "0x1561B10", Offset = "0x1560510", VA = "0x181561B10")]
		private void InsertDecal(DecalLayerItem decal, int index)
		{
			//Discarded unreachable code: IL_00ce
			//IL_0010: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			DecalBaseItem currentDecal = _currentDecal;
			int num = 0;
			if (currentDecal != (UnityEngine.Object)num)
			{
				DecalBaseItem currentDecal2 = _currentDecal;
				int num2 = 0;
				if (currentDecal2 != (UnityEngine.Object)num2)
				{
					SaveCurrentDecal();
				}
				Cancel();
			}
			DesignWorkingCopy designWorkingCopy = new DesignWorkingCopy((DesignWorkingCopy)((HistoryStack<T>)(object)DesignHistory).Current);
			RepeatedField<Decal> decals_ = designWorkingCopy.Data.decals_;
			int _003CLayer_003Ek__BackingField = ((DecalBaseItem)decal).Layer;
			Decal item = (Decal)((RepeatedField<T>)(object)decals_)[_003CLayer_003Ek__BackingField];
			RepeatedField<Decal> decals_2 = designWorkingCopy.Data.decals_;
			int _003CLayer_003Ek__BackingField2 = ((DecalBaseItem)decal).Layer;
			((RepeatedField<T>)(object)decals_2).RemoveAt(_003CLayer_003Ek__BackingField2);
			RepeatedField<Decal> decals_3 = designWorkingCopy.Data.decals_;
			_003CLayer_003Ek__BackingField2 = index;
			((RepeatedField<T>)(object)decals_3).Insert(_003CLayer_003Ek__BackingField2, (T)item);
			((HistoryStack<T>)(object)DesignHistory).Push((T)designWorkingCopy);
			DecalLayerContent layers = _layers;
			Design _003CData_003Ek__BackingField = designWorkingCopy.Data;
			layers.Refresh(_003CData_003Ek__BackingField);
			DrawAll();
		}

		[Cpp2IlInjected.Token(Token = "0x60019A4")]
		[Cpp2IlInjected.Address(RVA = "0x1564EE0", Offset = "0x15638E0", VA = "0x181564EE0")]
		private void SaveCurrentDecal()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60019A5")]
		[Cpp2IlInjected.Address(RVA = "0x155FC00", Offset = "0x155E600", VA = "0x18155FC00")]
		public void Confirm()
		{
			//IL_0010: Expected O, but got I4
			DecalBaseItem currentDecal = _currentDecal;
			int num = 0;
			if (currentDecal != (UnityEngine.Object)num)
			{
				SaveCurrentDecal();
			}
			Cancel();
		}

		[Cpp2IlInjected.Token(Token = "0x60019A6")]
		[Cpp2IlInjected.Address(RVA = "0x155FA10", Offset = "0x155E410", VA = "0x18155FA10")]
		private void Cancel()
		{
			//Discarded unreachable code: IL_012b
			//IL_0104: Expected I4, but got I8
			_library.DeselectAll();
			_layers.DeselectAll();
			ToggleButton btnMode = _gizmo._btnMode;
			int num = ((btnMode.IsOn = false) ? 1 : 0);
			ToggleButton flipToggle = _flipToggle;
			int num2 = ((flipToggle.IsOn = false) ? 1 : 0);
			ToggleButton cutoutToggle = _cutoutToggle;
			int num3 = ((cutoutToggle.IsOn = false) ? 1 : 0);
			ToggleButton mirrorToggle = _mirrorToggle;
			int num4 = ((mirrorToggle.IsOn = false) ? 1 : 0);
			ToggleButton transferToggle = _transferToggle;
			int num5 = ((transferToggle.IsOn = false) ? 1 : 0);
			ToggleButton uvSpaceToggle = _uvSpaceToggle;
			int num6 = ((uvSpaceToggle.IsOn = false) ? 1 : 0);
			ToggleButton repeatToggle = _repeatToggle;
			int num7 = ((repeatToggle.IsOn = false) ? 1 : 0);
			DrawAll();
			GameObject gameObject = _outOfMeshImage.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			_gizmo.Hide();
			if (_baseColorPicker.isShown)
			{
				int isOn = 0;
				OnBaseColorToggleChangedHandler((byte)isOn != 0);
			}
			if (_colorPicker.isShown)
			{
				int isOn2 = 0;
				OnDecalColorToggleHandler((byte)isOn2 != 0);
			}
			_mode = Mode.Default;
			RefreshUndoButton();
			int num8 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019A7")]
		[Cpp2IlInjected.Address(RVA = "0x15623B0", Offset = "0x1560DB0", VA = "0x1815623B0")]
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

		[Cpp2IlInjected.Token(Token = "0x60019A8")]
		[Cpp2IlInjected.Address(RVA = "0x15608D0", Offset = "0x155F2D0", VA = "0x1815608D0")]
		private void DeleteDecal(DecalLayerItem decal)
		{
			//Discarded unreachable code: IL_0083
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(decal == (UnityEngine.Object)num))
			{
				DesignWorkingCopy designWorkingCopy = new DesignWorkingCopy((DesignWorkingCopy)((HistoryStack<T>)(object)DesignHistory).Current);
				int _003CLayer_003Ek__BackingField = ((DecalBaseItem)decal).Layer;
				if (_003CLayer_003Ek__BackingField != -1)
				{
					((RepeatedField<T>)(object)designWorkingCopy.Data.decals_).RemoveAt(_003CLayer_003Ek__BackingField);
					DecalLayerContent layers = _layers;
					Design _003CData_003Ek__BackingField = designWorkingCopy.Data;
					layers.Refresh(_003CData_003Ek__BackingField);
					((HistoryStack<T>)(object)DesignHistory).Push((T)designWorkingCopy);
				}
				AK.Wwise.Event deleteLayerSfx = _deleteLayerSfx;
				if (deleteLayerSfx != null)
				{
					GameObject gameObject = base.gameObject;
					uint num2 = deleteLayerSfx.Post(gameObject);
				}
			}
			Cancel();
		}

		[Cpp2IlInjected.Token(Token = "0x60019A9")]
		[Cpp2IlInjected.Address(RVA = "0x1564000", Offset = "0x1562A00", VA = "0x181564000")]
		private void OnModePanelToggleHandler(bool isOn)
		{
			//Discarded unreachable code: IL_0034
			SlidingPanel mcButtonContent = _mcButtonContent;
			if (!isOn)
			{
				mcButtonContent.Hide();
			}
			mcButtonContent.Show(andOpen: true);
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019AA")]
		[Cpp2IlInjected.Address(RVA = "0x1562F10", Offset = "0x1561910", VA = "0x181562F10")]
		private void OnDecalColorToggleHandler(bool isOn)
		{
			//Discarded unreachable code: IL_006a, IL_0070, IL_0076, IL_0088
			int num = 0;
			IEnumerator enumerator = _colorPicker._mcContent.transform.GetEnumerator();
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
				int num4 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				bool flag = default(bool);
				while (!flag)
				{
				}
			}
			bool flag2 = default(bool);
			if (flag2)
			{
			}
			bool flag3 = default(bool);
			if (flag3)
			{
			}
			bool flag4 = default(bool);
			if (flag4)
			{
			}
			Color white = Color.white;
			int num5 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019AB")]
		[Cpp2IlInjected.Address(RVA = "0x1562AA0", Offset = "0x15614A0", VA = "0x181562AA0")]
		private unsafe void OnBaseColorToggleChangedHandler(bool isOn)
		{
			//Discarded unreachable code: IL_0082, IL_0088, IL_008e, IL_00a0
			int num = 0;
			int num2 = 0;
			IEnumerator enumerator = _baseColorPicker._mcContent.transform.GetEnumerator();
			if (enumerator != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				int num4 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num5 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				bool flag = default(bool);
				while (!flag)
				{
				}
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				int num6 = 0;
			}
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			DesignWorkingCopy designWorkingCopy = default(DesignWorkingCopy);
			if (ColorUtility.TryParseHtmlString(designWorkingCopy.Data.baseColor_, out *(Color*)num2))
			{
			}
			Color white = Color.white;
			int num7 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019AC")]
		[Cpp2IlInjected.Address(RVA = "0x1563E30", Offset = "0x1562830", VA = "0x181563E30")]
		private void OnGizmoShown()
		{
			//Discarded unreachable code: IL_0043
			//IL_0021: Expected O, but got I4
			GameObject gameObject = _gizmo._btnColor.gameObject;
			DecalBaseItem currentDecal = _currentDecal;
			int num = 0;
			if (!(currentDecal != (UnityEngine.Object)num))
			{
			}
			bool active = _currentDecal.DecalData.allowColoring_;
			gameObject.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x60019AD")]
		[Cpp2IlInjected.Address(RVA = "0x155F9E0", Offset = "0x155E3E0", VA = "0x18155F9E0")]
		public void CancelBeforeExit()
		{
			//Discarded unreachable code: IL_0016
			if (_gizmo.Shown)
			{
				Cancel();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019AE")]
		[Cpp2IlInjected.Address(RVA = "0x15679C0", Offset = "0x15663C0", VA = "0x1815679C0")]
		public void ToggleDeleteLayerBtn(bool isControllerConnected)
		{
			//Discarded unreachable code: IL_000d
			_layers.ToggleDeleteLayerBtn(isControllerConnected);
		}

		[Cpp2IlInjected.Token(Token = "0x60019AF")]
		[Cpp2IlInjected.Address(RVA = "0x156A5E0", Offset = "0x1568FE0", VA = "0x18156A5E0")]
		public DecalEditContent()
		{
		}//IL_0052: Expected I4, but got I8

	}
}
