using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.Characters.Critters;
using Mdl.Characters.Pets;
using Mdl.Environments;
using Mdl.Gestures;
using Mdl.Graphic;
using Mdl.Graphic.Weather;
using Mdl.Grid;
using Mdl.InputSystem;
using Mdl.Items;
using Mdl.Motion;
using Mdl.Navigation;
using Mdl.Navigation.ControlSchemes;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using Meta.Customization;
using Meta.Online;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

namespace Mdl.Ui.Photo
{
	[Cpp2IlInjected.Token(Token = "0x2000950")]
	[RequiredAllNotNull]
	public class PhotoView : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000951")]
		public delegate void PictureTaken(Texture2D picture, Meta.Customization.Avatar avatar, bool isMale, IEnumerable<int> items, SendPictureMode sendPictureMode);

		[Cpp2IlInjected.Token(Token = "0x2000952")]
		public delegate void OnRefreshHintDelegate();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003719")]
		[SerializeField]
		private float freeCameraMaxDistanceFromAvatar = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400371A")]
		[SerializeField]
		public TabsContainer modeTabsContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400371B")]
		[SerializeField]
		private Tab selfieCameraTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400371C")]
		[SerializeField]
		private Tab avatarCameraTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400371D")]
		[SerializeField]
		private Tab freeCameraTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400371E")]
		[SerializeField]
		private PhotoMenuTab _phoneMenuTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400371F")]
		[SerializeField]
		private AK.Wwise.Event _captureSfxEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003720")]
		[SerializeField]
		private AK.Wwise.Event _toggleCrouchSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003721")]
		[SerializeField]
		private AK.Wwise.Event _toggleFormatSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003722")]
		[SerializeField]
		private AK.Wwise.Event _toggleModeSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003723")]
		[SerializeField]
		private AK.Wwise.Event _saveSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003724")]
		public float selfieFov = 48f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003725")]
		public ViewMargins npcReactViewMargins;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003726")]
		public float npcReactMinDistance = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4003727")]
		public float npcReactMaxDistance = 15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4003728")]
		public float crouchAmount = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4003729")]
		public float shadowCascadeSafeDistanceOffset = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400372A")]
		public bool saved;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400372B")]
		[ShowNonSerializedField]
		private PhotoModeExpression currentExpression = PhotoModeExpression.None;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400372C")]
		[ShowNonSerializedField]
		private PhotoModePoseSelfie currentPoseSelfie = PhotoModePoseSelfie.LoopAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400372D")]
		[ShowNonSerializedField]
		private PhotoModePoseStanding currentPoseStanding = PhotoModePoseStanding.None;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400372E")]
		private PhotoModeType _mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400372F")]
		public RectTransform inputZone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4003730")]
		public RawImage picture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4003731")]
		public int photoPixelMultiplier = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4003732")]
		public bool isTakingPicture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC5")]
		[Cpp2IlInjected.Token(Token = "0x4003733")]
		public bool isPictureTaken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC6")]
		[Cpp2IlInjected.Token(Token = "0x4003734")]
		public bool isChangingEffect;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4003736")]
		public PhotoModeImageFormat imageFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4003737")]
		private Texture2D finalPhoto;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4003738")]
		public Image fade;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4003739")]
		public Image bgFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400373A")]
		public Image bgFormatCaptured;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400373B")]
		public Image bgFormatClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400373C")]
		public GameObject _toggleUiMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400373D")]
		public GameObject customFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400373E")]
		public GameObject blurBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400373F")]
		private FocusNavigation _focusNav;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4003740")]
		private PhotoMenu photoMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4003741")]
		public PhotoFrame photoFrameEffect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4003742")]
		public PhotoEffect photoEffect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4003743")]
		public float _avatarFov = 55f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x4003744")]
		public float _maleSelfieFov = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4003745")]
		public RectTransform frame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4003746")]
		public RectTransform blurLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4003747")]
		public RectTransform blurRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4003748")]
		public AK.Wwise.Event sfxTakePicture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400374B")]
		private MoveGesture _move;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400374C")]
		private InputAction actionPan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400374D")]
		private InputAction actionRotate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400374E")]
		private InputAction actionZoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400374F")]
		private InputAction actionTriggerRotateButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4003750")]
		private InputAction actionTriggerRotate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4003751")]
		private InputAction actionTriggerRotateMouseAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4003752")]
		private InputAction actionRotateAvatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4003753")]
		private InputAction actionTriggerRotateAvatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4003754")]
		private InputAction actionTriggerRotateAvatarMouseAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4003755")]
		private InputAction actionTriggerPanButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4003756")]
		private InputAction actionTriggerPan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4003757")]
		private InputAction actionTriggerZoomButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4003758")]
		private InputAction actionTriggerZoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4003759")]
		private InputAction actionFreeCameraPan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400375A")]
		private OrbitCamera _orbitCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400375B")]
		private SelfieCamera _selfieCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x400375C")]
		private SelfieCameraController _selfieCameraController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x400375D")]
		private FreeCameraControl _freeCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x400375E")]
		private CameraNavigationConfig _cameraConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x400375F")]
		private PlayerNavigationConfig _playerConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4003760")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4003761")]
		private PlayerAvatar _avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4003762")]
		private OrbitCameraTarget _selfieCameraTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4003763")]
		private bool _constructed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4003764")]
		private Tween<UnityEngine.Vector3> _positionTransition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4003765")]
		private Tween<Quaternion> _rotationTransition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4003766")]
		private Tween<float> _fovTransition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4003767")]
		private Tween<UnityEngine.Vector3> _avatarCrouchTransition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4003768")]
		private UnityEngine.Vector3 _selfieLookAtFlat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
		[Cpp2IlInjected.Token(Token = "0x4003769")]
		private bool _isInCrouchAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25D")]
		[Cpp2IlInjected.Token(Token = "0x400376A")]
		private bool _isInFovAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x400376B")]
		private float _normalFov;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400376C")]
		private List<Mdl.Characters.Character> _npcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400376D")]
		private List<ItemScript> _interests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400376E")]
		private List<Mdl.Characters.Pets.Pet> _pets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400376F")]
		private LookAtBehaviour _avatarLookAtBehaviour;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4003770")]
		private AimConstraint[] _eyeAimConstraints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4003771")]
		private UniversalRenderPipelineAsset lwrp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4003772")]
		private UnityEngine.Vector3 m_Cascade4SplitOld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A4")]
		[Cpp2IlInjected.Token(Token = "0x4003773")]
		private float m_Cascade2SplitOld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4003774")]
		private FieldInfo m_Cascade4Split = typeof(UniversalRenderPipelineAsset).GetField("m_Cascade4Split", BindingFlags.Instance | BindingFlags.NonPublic);

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4003775")]
		private FieldInfo m_Cascade2Split = typeof(UniversalRenderPipelineAsset).GetField("m_Cascade2Split", BindingFlags.Instance | BindingFlags.NonPublic);

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4003776")]
		private IDisposable controlMapScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4003777")]
		private bool shouldInitFromAvatarRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4003778")]
		private Transform freeCamStartTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4003779")]
		private Toolbox.TemporaryHideToolScope hidePhoneScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x400377A")]
		private Toolbox.TemporarySwitchToolScope removeToolScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x400377B")]
		private GameObject freeCameraTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x400377C")]
		private List<int> itemsInScreenshot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400377D")]
		private CallOnce initFreeCameraModeAfterTransition = new CallOnce();

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x400377E")]
		private CancellationTokenSource visualEffectCTS = new CancellationTokenSource();

		[Cpp2IlInjected.Token(Token = "0x170007FF")]
		public PhotoModeType Mode
		{
			[Cpp2IlInjected.Token(Token = "0x6003A61")]
			[Cpp2IlInjected.Address(RVA = "0x9D1840", Offset = "0x9D0240", VA = "0x1809D1840")]
			get
			{
				return _mode;
			}
			[Cpp2IlInjected.Token(Token = "0x6003A62")]
			[Cpp2IlInjected.Address(RVA = "0x9D19B0", Offset = "0x9D03B0", VA = "0x1809D19B0")]
			set
			{
				if (_mode != value)
				{
					ResetPose();
					_mode = value;
					InitMode();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000800")]
		public FocusNavigation FocusNav
		{
			[Cpp2IlInjected.Token(Token = "0x6003A65")]
			[Cpp2IlInjected.Address(RVA = "0x9D16C0", Offset = "0x9D00C0", VA = "0x1809D16C0")]
			get
			{
				//Discarded unreachable code: IL_0041
				//IL_0010: Expected O, but got I4
				//IL_003a: Expected O, but got I4
				FocusNavigation focusNav = _focusNav;
				int num = 0;
				if (!(focusNav != (UnityEngine.Object)num))
				{
					if (!photoMenu)
					{
						int num2 = 0;
					}
					if ((object)photoMenu.MenuNavigation != null)
					{
					}
					int num3 = 0;
					_focusNav = (FocusNavigation)num3;
				}
				return _focusNav;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000801")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x160"), Cpp2IlInjected.Token(Token = "0x4003749")]
		public bool IsShown
		{
			[Cpp2IlInjected.Token(Token = "0x6003A66")]
			[Cpp2IlInjected.Address(RVA = "0x9D1830", Offset = "0x9D0230", VA = "0x1809D1830")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003A67")]
			[Cpp2IlInjected.Address(RVA = "0x9D19A0", Offset = "0x9D03A0", VA = "0x1809D19A0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000802")]
		public bool IsSelfieMode
		{
			[Cpp2IlInjected.Token(Token = "0x6003A68")]
			[Cpp2IlInjected.Address(RVA = "0x9D17F0", Offset = "0x9D01F0", VA = "0x1809D17F0")]
			get
			{
				return _mode == PhotoModeType.Selfie;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000803")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x161"), Cpp2IlInjected.Token(Token = "0x400374A")]
		public bool IsInCrouchMode
		{
			[Cpp2IlInjected.Token(Token = "0x6003A69")]
			[Cpp2IlInjected.Address(RVA = "0x9D17C0", Offset = "0x9D01C0", VA = "0x1809D17C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003A6A")]
			[Cpp2IlInjected.Address(RVA = "0x9D1990", Offset = "0x9D0390", VA = "0x1809D1990")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000804")]
		public static bool IsSavingScreenshotToSystemSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6003A6B")]
			[Cpp2IlInjected.Address(RVA = "0x9D17D0", Offset = "0x9D01D0", VA = "0x1809D17D0")]
			get
			{
				int num = 0;
				return Application.platform != RuntimePlatform.Switch;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000805")]
		private bool IsShowingPhoto
		{
			[Cpp2IlInjected.Token(Token = "0x6003A6C")]
			[Cpp2IlInjected.Address(RVA = "0x9D1800", Offset = "0x9D0200", VA = "0x1809D1800")]
			get
			{
				//Discarded unreachable code: IL_0011
				return picture.gameObject.activeSelf;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000806")]
		private static CameraCollisionSystem CameraCollisionSystem
		{
			[Cpp2IlInjected.Token(Token = "0x6003A6D")]
			[Cpp2IlInjected.Address(RVA = "0x9D1600", Offset = "0x9D0000", VA = "0x1809D1600")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.GetSystem<CameraCollisionSystem>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000079")]
		public event PictureTaken OnPictureTakenAction
		{
			[Cpp2IlInjected.Token(Token = "0x6003A5F")]
			[Cpp2IlInjected.Address(RVA = "0x9D14C0", Offset = "0x9CFEC0", VA = "0x1809D14C0")]
			[CompilerGenerated]
			add
			{
				PictureTaken onPictureTakenAction = this.OnPictureTakenAction;
				Delegate @delegate = Delegate.Combine(onPictureTakenAction, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onPictureTakenAction)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003A60")]
			[Cpp2IlInjected.Address(RVA = "0x9D1850", Offset = "0x9D0250", VA = "0x1809D1850")]
			[CompilerGenerated]
			remove
			{
				PictureTaken onPictureTakenAction = this.OnPictureTakenAction;
				Delegate @delegate = Delegate.Remove(onPictureTakenAction, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onPictureTakenAction)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400007A")]
		public event OnRefreshHintDelegate OnRefreshHint
		{
			[Cpp2IlInjected.Token(Token = "0x6003A63")]
			[Cpp2IlInjected.Address(RVA = "0x9D1560", Offset = "0x9CFF60", VA = "0x1809D1560")]
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
			[Cpp2IlInjected.Token(Token = "0x6003A64")]
			[Cpp2IlInjected.Address(RVA = "0x9D18F0", Offset = "0x9D02F0", VA = "0x1809D18F0")]
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

		[Cpp2IlInjected.Token(Token = "0x6003A6E")]
		[Cpp2IlInjected.Address(RVA = "0x9CEBD0", Offset = "0x9CD5D0", VA = "0x1809CEBD0")]
		private unsafe void Start()
		{
			//Discarded unreachable code: IL_013b
			//IL_001e: Expected F4, but got I4
			//IL_0029: Expected F4, but got I4
			//IL_00a8: Expected F4, but got O
			//IL_00a3: Expected native int or pointer, but got O
			//IL_00c3: Expected F4, but got O
			RectTransform rectTransform = frame;
			RectTransform component = blurBackground.GetComponent<RectTransform>();
			int num = 0;
			component.SetLeft(num);
			int num2 = 0;
			component.SetRight(num2);
			RectTransform component2 = picture.GetComponent<RectTransform>();
			int num3 = 0;
			isPictureTaken = false;
			PhotoMenu photoMenu = (this.photoMenu = UiRoot.Instance.GetComponentInChildren<PhotoMenu>());
			ShowFrame();
			Cleanup(start: true);
			int num4 = 0;
			if ((object)photoMenu == null)
			{
			}
			int num5 = 0;
			lwrp = (UniversalRenderPipelineAsset)(object)photoMenu;
			FieldInfo cascade4Split = m_Cascade4Split;
			UniversalRenderPipelineAsset obj = lwrp;
			object value = cascade4Split.GetValue(obj);
			FieldInfo cascade2Split = m_Cascade2Split;
			object obj2 = value;
			((UnityEngine.Vector3*)(IntPtr)m_Cascade4SplitOld)->z = (float)obj2;
			UniversalRenderPipelineAsset obj3 = lwrp;
			object value2 = cascade2Split.GetValue(obj3);
			m_Cascade2SplitOld = (float)value2;
			int num6 = 0;
			CountedBool.RefState refState = CameraCollisionSystem.FocusPlayerAvatar.AddReference();
			int num7 = 0;
			CameraCollisionSystem.UpdateCharacterVisibilityFromPlayerCamera();
			GameObject gameObject = (freeCameraTarget = new GameObject("photoViewFreeCamera"));
			Transform transform = freeCameraTarget.transform;
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject2 = default(GameObject);
			Transform transform3 = (transform.parent = gameObject2.transform);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A6F")]
		[Cpp2IlInjected.Address(RVA = "0x9CD880", Offset = "0x9CC280", VA = "0x1809CD880")]
		private void OnDestroy()
		{
			//IL_0014: Expected O, but got I4
			//IL_0036: Expected O, but got I4
			UnityEngine.Object.Destroy(freeCameraTarget);
			int num = 0;
			freeCameraTarget = (GameObject)num;
			int num2 = 0;
			CountedBool.RefState refState = CameraCollisionSystem.FocusPlayerAvatar.ReleaseReference();
			if (controlMapScope != null)
			{
			}
			controlMapScope = (IDisposable)num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A70")]
		[Cpp2IlInjected.Address(RVA = "0x9C8170", Offset = "0x9C6B70", VA = "0x1809C8170")]
		private void Construct()
		{
			//Discarded unreachable code: IL_0073
			//IL_0020: Expected O, but got I4
			//IL_004d: Expected I4, but got I8
			//IL_004d: Expected O, but got I4
			Camera camera = (_camera = SystemRoot.Instance._playerCamera);
			int allowZoom = default(int);
			int num = default(int);
			OrbitCamera orbitCamera = new OrbitCamera(_camera, (OrbitCameraConfig)num, (byte)allowZoom != 0);
			allowZoom = 0;
			num = 0;
			_orbitCamera = orbitCamera;
			FreeCameraControl freeCameraControl = (_freeCamera = new FreeCameraControl());
			ulong num3 = default(ulong);
			int automaticRotation = default(int);
			int num2 = default(int);
			MoveGesture move = new MoveGesture(inputZone, (Camera)num2, (byte)automaticRotation != 0, (byte)num3 != 0);
			automaticRotation = 0;
			num2 = 0;
			_move = move;
			float num4 = (_normalFov = _camera.fieldOfView);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A71")]
		[Cpp2IlInjected.Address(RVA = "0x9CBCA0", Offset = "0x9CA6A0", VA = "0x1809CBCA0")]
		public void Init(PlayerAvatar avatar, PlayerNavigationConfig playerConfig, CameraNavigationConfig cameraConfig, OrbitCameraTarget selfieCameraTarget, PhotoModeType mode, PhotoViewAdditionalParameters additionalParameters)
		{
			//IL_002b: Expected O, but got I4
			//IL_0058: Expected I4, but got I8
			//IL_0058: Expected O, but got I4
			//IL_00c0: Expected O, but got I4
			//IL_00e3: Expected O, but got I4
			//IL_0103: Expected O, but got I4
			//IL_0103: Expected O, but got I4
			//IL_0125: Expected O, but got I4
			//IL_0167: Expected O, but got I4
			//IL_0198: Expected O, but got I4
			//IL_023f: Expected O, but got I4
			//IL_0269: Expected O, but got I4
			//IL_02c4: Expected O, but got I4
			//IL_02e8: Expected O, but got I4
			//IL_02e8: Expected O, but got I4
			//IL_0348: Expected O, but got I4
			//IL_0348: Expected O, but got I4
			//IL_0379: Expected O, but got I4
			//IL_0379: Expected O, but got I4
			//IL_03c5: Expected O, but got I4
			//IL_03c5: Expected O, but got I4
			//IL_042b: Expected O, but got I4
			//IL_0464: Expected O, but got I4
			//IL_046b: Expected O, but got I4
			//IL_0472: Expected O, but got I4
			//IL_04ae: Expected O, but got I4
			int num2 = default(int);
			int allowZoom = default(int);
			int num3 = default(int);
			int automaticRotation = default(int);
			ulong num4 = default(ulong);
			bool flag = default(bool);
			int num6 = default(int);
			int num7 = default(int);
			InputActionModifier_Chord modifier = default(InputActionModifier_Chord);
			int num8 = default(int);
			InputActionModifier_Chord modifier2 = default(InputActionModifier_Chord);
			int num9 = default(int);
			int num11 = default(int);
			int num12 = default(int);
			int num13 = default(int);
			InputActionModifier_Chord modifier11 = default(InputActionModifier_Chord);
			int num14 = default(int);
			int num15 = default(int);
			InputActionModifier_Chord modifier12 = default(InputActionModifier_Chord);
			int num16 = default(int);
			int num17 = default(int);
			FreeCameraControl freeCamera2;
			ICameraBoundary[] array;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			DistanceBasedBoundary distanceBasedBoundary = default(DistanceBasedBoundary);
			Boundaries currentBoundaries;
			while (true)
			{
				int num = 0;
				if ((_constructed ? 1 : 0) == num)
				{
					Camera camera = (_camera = SystemRoot.Instance._playerCamera);
					OrbitCamera orbitCamera = new OrbitCamera(_camera, (OrbitCameraConfig)num2, (byte)allowZoom != 0);
					allowZoom = 0;
					num2 = 0;
					_orbitCamera = orbitCamera;
					FreeCameraControl freeCameraControl = (_freeCamera = new FreeCameraControl());
					MoveGesture move = new MoveGesture(inputZone, (Camera)num3, (byte)automaticRotation != 0, (byte)num4 != 0);
					automaticRotation = 0;
					num3 = 0;
					_move = move;
					float num5 = (_normalFov = _camera.fieldOfView);
				}
				_mode = PhotoModeType.Selfie;
				IsInCrouchMode = false;
				shouldInitFromAvatarRotation = false;
				if (flag)
				{
				}
				Transform transform = (freeCamStartTransform = avatar.navigationStartCamera);
				InputTriggerDown trigger = new InputTriggerDown();
				InputActionVector2D inputActionVector2D = (InputActionVector2D)(actionPan = new InputActionVector2D("CameraTool_PanHorizontal", "CameraTool_PanVertical", trigger, (InputProvider)num));
				InputTriggerDown trigger2 = new InputTriggerDown();
				InputActionVector2D inputActionVector2D2 = (InputActionVector2D)(actionRotate = new InputActionVector2D("CameraTool_RotateYaw", "CameraTool_RotatePitch", trigger2, (InputProvider)num));
				InputTriggerDown trigger3 = new InputTriggerDown();
				InputActionFloat inputActionFloat = new InputActionFloat("CameraTool_Zoom", trigger3, (string)num6, (InputProvider)num);
				num6 = 0;
				actionZoom = inputActionFloat;
				InputTriggerDown trigger4 = new InputTriggerDown();
				InputActionBool inputActionBool = new InputActionBool("CameraTool_TriggerRotateButton", trigger4, (InputProvider)num7);
				num7 = 0;
				actionTriggerRotateButton = inputActionBool;
				EventHandler eventHandler = OnRotateTriggerPressed;
				EventHandler eventHandler2 = OnRotateTriggerReleased;
				InputTriggerDown trigger5 = new InputTriggerDown();
				InputActionVector2D inputActionVector2D3 = (InputActionVector2D)(actionTriggerRotate = new InputActionVector2D("CameraTool_TriggerRotateYaw", "CameraTool_TriggerRotatePitch", trigger5, (InputProvider)num));
				actionTriggerRotate.AddModifier(modifier);
				InputTriggerDown trigger6 = new InputTriggerDown();
				InputActionVector2D inputActionVector2D4 = new InputActionVector2D("CameraTool_TriggerRotateYaw_MouseAxis", "CameraTool_TriggerRotatePitch_MouseAxis", trigger6, (InputProvider)num8);
				num8 = 0;
				actionTriggerRotateMouseAxis = inputActionVector2D4;
				actionTriggerRotateMouseAxis.AddModifier(modifier2);
				InputAction inputAction = actionTriggerRotateMouseAxis;
				InputActionModifier_ScaleDeltaTime modifier3 = new InputActionModifier_ScaleDeltaTime();
				inputAction.AddModifier(modifier3);
				InputAction inputAction2 = actionRotate;
				InputActionModifier_Merge modifier4 = new InputActionModifier_Merge(actionTriggerRotate);
				inputAction2.AddModifier(modifier4);
				InputAction inputAction3 = actionRotate;
				InputActionModifier_Merge modifier5 = new InputActionModifier_Merge(actionTriggerRotateMouseAxis);
				inputAction3.AddModifier(modifier5);
				InputAction inputAction4 = actionRotate;
				InputActionModifier_SuppressIf modifier6 = new InputActionModifier_SuppressIf((Func<>)(object)(Func<TResult>)(() => actionTriggerZoomButton.IsTriggered));
				inputAction4.AddModifier(modifier6);
				InputTriggerDown trigger7 = new InputTriggerDown();
				InputActionBool inputActionBool2 = new InputActionBool("CameraTool_TriggerPanButton", trigger7, (InputProvider)num9);
				int num10 = 0;
				num9 = 0;
				actionTriggerPanButton = inputActionBool2;
				InputTriggerDown trigger8 = new InputTriggerDown();
				InputActionVector2D inputActionVector2D5 = (InputActionVector2D)(actionTriggerPan = new InputActionVector2D("CameraTool_TriggerPanHorizontal", "CameraTool_TriggerPanVertical", trigger8, (InputProvider)num10));
				InputAction inputAction5 = actionTriggerPan;
				InputActionModifier_Chord modifier7 = new InputActionModifier_Chord(actionTriggerPanButton);
				inputAction5.AddModifier(modifier7);
				InputAction inputAction6 = actionPan;
				InputActionModifier_Merge modifier8 = new InputActionModifier_Merge(actionTriggerPan);
				inputAction6.AddModifier(modifier8);
				InputTriggerDown trigger9 = new InputTriggerDown();
				InputActionBool inputActionBool3 = new InputActionBool("CameraTool_TriggerZoomButton", trigger9, (InputProvider)num11);
				num11 = 0;
				actionTriggerZoomButton = inputActionBool3;
				InputTriggerDown trigger10 = new InputTriggerDown();
				InputActionFloat inputActionFloat2 = new InputActionFloat("CameraTool_TriggerZoom", trigger10, (string)num12, (InputProvider)num10);
				num12 = 0;
				actionTriggerZoom = inputActionFloat2;
				InputAction inputAction7 = actionTriggerZoom;
				InputActionModifier_Chord modifier9 = new InputActionModifier_Chord(actionTriggerZoomButton);
				inputAction7.AddModifier(modifier9);
				InputAction inputAction8 = actionZoom;
				InputActionModifier_Merge modifier10 = new InputActionModifier_Merge(actionTriggerZoom);
				inputAction8.AddModifier(modifier10);
				InputTriggerDown trigger11 = new InputTriggerDown();
				InputActionFloat inputActionFloat3 = new InputActionFloat("CameraTool_TriggerRotateAvatar", trigger11, (string)num13, (InputProvider)num10);
				num13 = 0;
				actionTriggerRotateAvatar = inputActionFloat3;
				actionTriggerRotateAvatar.AddModifier(modifier11);
				InputTriggerDown trigger12 = new InputTriggerDown();
				InputActionFloat inputActionFloat4 = new InputActionFloat("CameraTool_TriggerRotateAvatar_MouseAxis", trigger12, (string)num14, (InputProvider)num15);
				num15 = 0;
				num14 = 0;
				actionTriggerRotateAvatarMouseAxis = inputActionFloat4;
				actionTriggerRotateAvatarMouseAxis.AddModifier(modifier12);
				InputAction inputAction9 = actionTriggerRotateAvatarMouseAxis;
				InputActionModifier_ScaleDeltaTime modifier13 = new InputActionModifier_ScaleDeltaTime();
				inputAction9.AddModifier(modifier13);
				InputTriggerDown trigger13 = new InputTriggerDown();
				InputActionFloat inputActionFloat5 = new InputActionFloat("CameraTool_RotateAvatar", trigger13, (string)num16, (InputProvider)num17);
				num17 = 0;
				num16 = 0;
				actionRotateAvatar = inputActionFloat5;
				InputAction inputAction10 = actionRotateAvatar;
				InputActionModifier_Merge modifier14 = new InputActionModifier_Merge(actionTriggerRotateAvatar);
				inputAction10.AddModifier(modifier14);
				InputAction inputAction11 = actionRotateAvatar;
				InputActionModifier_Merge modifier15 = new InputActionModifier_Merge(actionTriggerRotateAvatarMouseAxis);
				inputAction11.AddModifier(modifier15);
				InputTriggerDown trigger14 = new InputTriggerDown();
				InputActionVector2D inputActionVector2D6 = (InputActionVector2D)(actionFreeCameraPan = new InputActionVector2D("CameraTool_PanHorizontal", "CameraTool_PanVertical", trigger14, (InputProvider)num17));
				InputAction inputAction12 = actionFreeCameraPan;
				InputActionModifier_Merge modifier16 = new InputActionModifier_Merge(actionTriggerPan);
				int num18 = 0;
				inputAction12.AddModifier(modifier16);
				_avatar = avatar;
				_playerConfig = (PlayerNavigationConfig)0;
				_cameraConfig = (CameraNavigationConfig)0;
				_selfieCameraTarget = (OrbitCameraTarget)0;
				FreeCameraControl freeCamera = _freeCamera;
				PlayerNavigationConfig playerConfig2 = _playerConfig;
				int num19 = 0;
				Camera camera2 = _camera;
				CameraNavigationConfig cameraConfig2 = _cameraConfig;
				Transform initialCamera = freeCamStartTransform;
				freeCamera.Init(camera2, (PlayerAvatar)num18, playerConfig2, initialCamera, cameraConfig2);
				freeCamera2 = _freeCamera;
				array = new ICameraBoundary[0];
				float z = vector.z;
				if (distanceBasedBoundary == null || distanceBasedBoundary != null)
				{
					array[0] = distanceBasedBoundary;
					int num20 = 0;
					currentBoundaries = CameraUtil.GetCurrentBoundaries();
					if ((object)currentBoundaries == null || (object)currentBoundaries != null)
					{
						break;
					}
				}
			}
			array[1] = currentBoundaries;
			freeCamera2.SetBoundaries(array);
			OrbitCamera orbitCamera2 = _orbitCamera;
			Camera camera3 = _camera;
			OrbitCameraTarget selfieCameraTarget2 = _selfieCameraTarget;
			OrbitCameraConfig _003CConfig_003Ek__BackingField = orbitCamera2.Config;
			SelfieCamera selfieCamera = new SelfieCamera(camera3, selfieCameraTarget2, _003CConfig_003Ek__BackingField);
			int num21 = 0;
			_selfieCamera = selfieCamera;
			OrbitCamera orbitCamera3 = _orbitCamera;
			SelfieCameraController selfieCameraController = default(SelfieCameraController);
			_selfieCameraController = selfieCameraController;
			List<Mdl.Characters.Character> list = (_npcs = (List<Mdl.Characters.Character>)(object)Enumerable.ToList<Mdl.Characters.Character>(SystemRoot.Instance.GetSystem<CharacterManager>().GetActiveCharacters(true)));
			TabsContainer tabsContainer = modeTabsContainer;
			TabsContainer.TabSelected value = ToggleModeCamera;
			tabsContainer.OnTabSelected += value;
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A72")]
		[Cpp2IlInjected.Address(RVA = "0x9CD980", Offset = "0x9CC380", VA = "0x1809CD980")]
		private void OnRotateTriggerPressed(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0021
			//IL_0019: Expected I4, but got I8
			int num = 0;
			InputProvider inputProvider = DefaultInputProvider.Get();
			int[] array = new int[1];
			array[0] = 4;
			inputProvider.EnableMaps(array);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A73")]
		[Cpp2IlInjected.Address(RVA = "0x9CDA10", Offset = "0x9CC410", VA = "0x1809CDA10")]
		private void OnRotateTriggerReleased(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0021
			//IL_0019: Expected I4, but got I8
			int num = 0;
			InputProvider inputProvider = DefaultInputProvider.Get();
			int[] array = new int[1];
			array[0] = 4;
			inputProvider.EnableMaps(array);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A74")]
		[Cpp2IlInjected.Address(RVA = "0x9CF4F0", Offset = "0x9CDEF0", VA = "0x1809CF4F0")]
		public void ToggleCrouchMode()
		{
			if (!_isInCrouchAnimation)
			{
				AK.Wwise.Event toggleCrouchSfx = _toggleCrouchSfx;
				if (toggleCrouchSfx != null)
				{
					GameObject gameObject = base.gameObject;
					uint num = toggleCrouchSfx.Post(gameObject);
				}
				bool flag = (IsInCrouchMode = !IsInCrouchMode);
				if (_mode == PhotoModeType.Selfie)
				{
					UpdateCrouchMode();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A75")]
		[Cpp2IlInjected.Address(RVA = "0x9CFB50", Offset = "0x9CE550", VA = "0x1809CFB50")]
		private unsafe void UpdateCrouchMode()
		{
			//Discarded unreachable code: IL_00da
			//IL_006f: Expected O, but got I4
			//IL_0081: Expected O, but got I4
			int num = 0;
			_isInCrouchAnimation = true;
			Transform _003Ctransform_003Ek__BackingField = _avatar.transform;
			float y = _selfieLookAtFlat.y;
			Transform _003Ctransform_003Ek__BackingField2 = _avatar.transform;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			if ((IsInCrouchMode ? 1 : 0) != num)
			{
				float z2 = UnityEngine.Vector3.up.z;
			}
			Transform _003Ctransform_003Ek__BackingField3 = _avatar.transform;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z3 = vector2.z;
			int num2 = default(int);
			Tween<UnityEngine.Vector3>.InterpolationFunction interpolationFunction = (Tween<UnityEngine.Vector3>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<UnityEngine.Vector3, UnityEngine.Vector3, float, UnityEngine.Vector3>*/)(&UnityEngine.Vector3.Lerp));
			num2 = 0;
			int num3 = default(int);
			EasingFunction easingFunction = new EasingFunction(num3, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.QuadEaseInOut));
			num3 = 0;
			Tween<UnityEngine.Vector3> avatarCrouchTransition = default(Tween<UnityEngine.Vector3>);
			_avatarCrouchTransition = avatarCrouchTransition;
			Tween<UnityEngine.Vector3> avatarCrouchTransition2 = _avatarCrouchTransition;
			Tween<UnityEngine.Vector3>.UpdateEventHandler updateEventHandler = (Tween<UnityEngine.Vector3>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(CrouchTransition);
			((Tween<T>)(object)avatarCrouchTransition2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			Tween<UnityEngine.Vector3> avatarCrouchTransition3 = _avatarCrouchTransition;
			Tween<UnityEngine.Vector3>.FinishEventHandler finishEventHandler = (Tween<UnityEngine.Vector3>.FinishEventHandler)(object)(Tween<T>.FinishEventHandler)delegate
			{
				_isInCrouchAnimation = false;
			};
			((Tween<T>)(object)avatarCrouchTransition3).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler);
			List<Mdl.Characters.Character> npcs = _npcs;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A76")]
		[Cpp2IlInjected.Address(RVA = "0x9CA440", Offset = "0x9C8E40", VA = "0x1809CA440")]
		private unsafe void InitMode()
		{
			//IL_005e: Expected O, but got I4
			//IL_0070: Expected O, but got I4
			//IL_0082: Expected O, but got F4
			//IL_00ac: Expected O, but got I4
			//IL_00be: Expected O, but got I4
			//IL_00d0: Expected O, but got F4
			//IL_00df: Expected O, but got I4
			//IL_00f1: Expected O, but got I4
			//IL_0103: Expected O, but got F4
			//IL_011b: Expected O, but got F4
			//IL_013e: Expected F4, but got I4
			//IL_0154: Expected I4, but got I8
			//IL_0165: Expected O, but got I4
			//IL_01b8: Expected O, but got I4
			//IL_01ca: Expected O, but got I4
			//IL_01dc: Expected O, but got F4
			//IL_01f4: Expected O, but got F4
			//IL_0217: Expected F4, but got I4
			//IL_022d: Expected I4, but got I8
			//IL_0239: Expected O, but got I4
			_freeCamera.Reset();
			List<Mdl.Characters.Character> npcs = _npcs;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
			}
			int num = 0;
			bool flag3 = default(bool);
			if (!flag3)
			{
			}
			bool flag4 = default(bool);
			if (flag4)
			{
				int num2 = 0;
				int num3 = 0;
			}
			int num4 = 0;
			int num5 = 0;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			int num6 = 0;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z2 = vector2.z;
			UnityEngine.Vector3 vector3 = default(UnityEngine.Vector3);
			float z3 = vector3.z;
			int num7 = default(int);
			Tween<UnityEngine.Vector3>.InterpolationFunction interpolationFunction = (Tween<UnityEngine.Vector3>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num7, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<UnityEngine.Vector3, UnityEngine.Vector3, float, UnityEngine.Vector3>*/)(&UnityEngine.Vector3.Lerp));
			num7 = 0;
			int num8 = default(int);
			EasingFunction easingFunction = new EasingFunction(num8, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.QuadEaseInOut));
			num8 = 0;
			Tween<UnityEngine.Vector3>.UpdateEventHandler updateEventHandler = (Tween<UnityEngine.Vector3>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(((PhotoView)z2).UpdateCameraPosition);
			System.DelegateData data = ((Delegate)easingFunction).data;
			UnityEngine.Vector3 vector4 = default(UnityEngine.Vector3);
			float z4 = vector4.z;
			UnityEngine.Vector3 vector5 = default(UnityEngine.Vector3);
			float z5 = vector5.z;
			int num9 = default(int);
			Tween<Quaternion>.InterpolationFunction interpolationFunction2 = (Tween<Quaternion>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num9, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Quaternion, Quaternion, float, Quaternion>*/)(&Quaternion.Lerp));
			num9 = 0;
			int num10 = default(int);
			EasingFunction easingFunction2 = new EasingFunction(num10, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.QuadEaseInOut));
			num10 = 0;
			Tween<Quaternion>.UpdateEventHandler updateEventHandler2 = (Tween<Quaternion>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(((PhotoView)z2).UpdateCameraRotation);
			int num11 = default(int);
			Tween<float>.InterpolationFunction interpolationFunction3 = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num11, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
			num11 = 0;
			int num12 = default(int);
			EasingFunction easingFunction3 = new EasingFunction(num12, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.QuadEaseInOut));
			num12 = 0;
			Tween<float>.UpdateEventHandler updateEventHandler3 = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(((PhotoView)z2).UpdateFov);
			Tween<float> tween = default(Tween<float>);
			((Tween<T>)(object)tween).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler3);
			Tween<float>.FinishEventHandler finishEventHandler = (Tween<float>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(((PhotoView)z2)._003CInitMode_003Eb__135_2);
			if (easingFunction3 != null)
			{
			}
			Animator animator = default(Animator);
			int layerIndex = animator.GetLayerIndex("Facial_Animation_Portrait");
			int num13 = 0;
			Animator animator2 = default(Animator);
			animator2.SetLayerWeight(layerIndex, num13);
			if (1L != 0L)
			{
			}
			(new int[1])[0] = 30;
			bool flag5 = default(bool);
			if (!flag5)
			{
			}
			int num14 = 0;
			PlayerNavigation playerNavigation = default(PlayerNavigation);
			if (playerNavigation != (UnityEngine.Object)num14)
			{
				int num15 = 0;
			}
			int num16 = 0;
			Mdl.Systems.System.SystemEvent systemPausedEvent = ((Mdl.Systems.System)playerNavigation).SystemPausedEvent;
			UnityEngine.Vector3 vector6 = default(UnityEngine.Vector3);
			float z6 = vector6.z;
			int num17 = 0;
			bool method_is_virtual = ((Delegate)systemPausedEvent).method_is_virtual;
			UnityEngine.Vector3 vector7 = default(UnityEngine.Vector3);
			float z7 = vector7.z;
			UnityEngine.Vector3 vector8 = default(UnityEngine.Vector3);
			float z8 = vector8.z;
			UnityEngine.Vector3 vector9 = default(UnityEngine.Vector3);
			float z9 = vector9.z;
			float num18 = default(float);
			float num19 = num18;
			int num20 = default(int);
			Tween<float>.InterpolationFunction interpolationFunction4 = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num20, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
			num20 = 0;
			int num21 = default(int);
			EasingFunction easingFunction4 = new EasingFunction(num21, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.QuadEaseInOut));
			num21 = 0;
			Tween<float>.UpdateEventHandler updateEventHandler4 = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(((PhotoView)z2).UpdateFov);
			Tween<float> tween2 = default(Tween<float>);
			((Tween<T>)(object)tween2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler4);
			Tween<float>.FinishEventHandler finishEventHandler2 = (Tween<float>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(((PhotoView)z2)._003CInitMode_003Eb__135_0);
			if (easingFunction4 != null)
			{
			}
			Animator animator3 = default(Animator);
			int layerIndex2 = animator3.GetLayerIndex("Facial_Animation_Portrait");
			int num22 = 0;
			Animator animator4 = default(Animator);
			animator4.SetLayerWeight(layerIndex2, num22);
			if (1L != 0L)
			{
			}
			(new int[1])[0] = 28;
			int num23 = 0;
			PlayerNavigation playerNavigation2 = default(PlayerNavigation);
			if (playerNavigation2 != (UnityEngine.Object)num23)
			{
				int num24 = 0;
			}
			PlayerAvatar avatar = ((Mdl.Systems.System)playerNavigation2).avatar;
			UnityEngine.Vector3 vector10 = default(UnityEngine.Vector3);
			float z10 = vector10.z;
			UnityEngine.Vector3 vector11 = default(UnityEngine.Vector3);
			float z11 = vector11.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A77")]
		[Cpp2IlInjected.Address(RVA = "0x9C8350", Offset = "0x9C6D50", VA = "0x1809C8350")]
		private void CrouchTransition(UnityEngine.Vector3 position, float progress)
		{
			//Discarded unreachable code: IL_0014
			Transform _003Ctransform_003Ek__BackingField = _avatar.transform;
			float z = position.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A78")]
		[Cpp2IlInjected.Address(RVA = "0x9CFFE0", Offset = "0x9CE9E0", VA = "0x1809CFFE0")]
		private void UpdateFov(float value, float progress)
		{
			//Discarded unreachable code: IL_000d
			_camera.fieldOfView = value;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A79")]
		[Cpp2IlInjected.Address(RVA = "0x9D0010", Offset = "0x9CEA10", VA = "0x1809D0010")]
		private void UpdateSelfieCameraTween(float fov, float progress)
		{
			//Discarded unreachable code: IL_0026
			_camera.fieldOfView = fov;
			if (!(progress <= 0.5f))
			{
				_avatar.appearance.SetSelfieMode(selfie: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A7A")]
		[Cpp2IlInjected.Address(RVA = "0x9CFB00", Offset = "0x9CE500", VA = "0x1809CFB00")]
		private void UpdateCameraRotation(Quaternion rotation, float progress)
		{
			//Discarded unreachable code: IL_000d
			Transform transform = _camera.transform;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A7B")]
		[Cpp2IlInjected.Address(RVA = "0x9CFAB0", Offset = "0x9CE4B0", VA = "0x1809CFAB0")]
		private void UpdateCameraPosition(UnityEngine.Vector3 position, float progress)
		{
			//Discarded unreachable code: IL_0014
			Transform transform = _camera.transform;
			float z = position.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A7C")]
		[Cpp2IlInjected.Address(RVA = "0x9CA3D0", Offset = "0x9C8DD0", VA = "0x1809CA3D0")]
		private void InitConfig()
		{
			//Discarded unreachable code: IL_004c
			OrbitCameraConfig cameraConfig = _avatar.appearance.orbitCameraTarget.cameraConfig;
			MoveGesture move = _move;
			float num = (move.MaxForce = cameraConfig.moveMaxForce);
			CameraNavigationConfig cameraConfig2 = _cameraConfig;
			MoveGesture move2 = _move;
			float num2 = (move2.Friction = cameraConfig2.moveFriction);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A7D")]
		[Cpp2IlInjected.Address(RVA = "0x9CF160", Offset = "0x9CDB60", VA = "0x1809CF160")]
		public void TakePicture()
		{
			//Discarded unreachable code: IL_010c
			//IL_00a7: Expected F4, but got I4
			if (!_isInFovAnimation && !isTakingPicture)
			{
				AK.Wwise.Event @event = sfxTakePicture;
				isTakingPicture = true;
				Image image = bgFormat;
				int num = ((image.enabled = false) ? 1 : 0);
				Image image2 = bgFormatCaptured;
				int num2 = ((image2.enabled = false) ? 1 : 0);
				Image image3 = bgFormatClick;
				int num3 = ((image3.enabled = false) ? 1 : 0);
				GameObject gameObject = modeTabsContainer.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				PhotoMenu photoMenu = this.photoMenu;
				photoMenu._isUIHidden = true;
				int num4 = 0;
				photoMenu.Invoke("UpdateUI", num4);
				RectTransform component = bgFormat.GetComponent<RectTransform>();
				if (!isPictureTaken)
				{
				}
				RectTransform rectTransform = bgFormatCaptured.GetComponent<RectTransform>();
				int num5 = 0;
				Transform transform = UiRoot.Instance._menuStack.GetComponent<CanvasScaler>().transform;
				RectTransform rectTransform2 = rectTransform;
				Action<Texture2D> action = (Action<Texture2D>)(object)(Action<T>)delegate(Texture2D result)
				{
					//Discarded unreachable code: IL_00eb
					//IL_004a: Expected I4, but got I8
					finalPhoto = result;
					isPictureTaken = true;
					PhotoView photoView = this;
					RawImage rawImage = photoView.picture;
					Texture2D texture2D = (Texture2D)(rawImage.texture = photoView.finalPhoto);
					ulong num6 = default(ulong);
					picture.gameObject.SetActive((byte)num6 != 0);
					RectTransform component2 = picture.GetComponent<RectTransform>();
					Vector2 vector = (component2.sizeDelta = rectTransform.sizeDelta);
					PlayFrameAnimation();
					PhotoMenu photoMenu2 = this.photoMenu;
					int num7 = ((photoMenu2.IsUIHidden = false) ? 1 : 0);
					this.OnRefreshHint?.Invoke();
					Client metaClient = SystemRoot.Instance.MetaClient;
					PhotoModeType mode = _mode;
					SceneStack sceneStack = SystemRoot.Instance._sceneStack;
					int num8 = 0;
					Task<Meta.PictureTaken.Types.Response> asyncTask = default(Task<Meta.PictureTaken.Types.Response>);
					asyncTask.FireAndForgetTask();
					isTakingPicture = false;
				};
				IEnumerator routine = default(IEnumerator);
				Coroutine coroutine = StartCoroutine(routine);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A7E")]
		[Cpp2IlInjected.Address(RVA = "0x9C8650", Offset = "0x9C7050", VA = "0x1809C8650")]
		private unsafe void ExtractItemsFromScreenshot(out List<int> items, out List<int> gardenCropItems)
		{
			//Discarded unreachable code: IL_02c7
			//IL_00e4: Expected O, but got Ref
			int num = 0;
			VibrationsManager.TriggerSelection();
			Camera camera = SystemRoot.Instance._playerCamera;
			float[] array = new float[4];
			int length = array.Length;
			float maxSqrDistanceNpc = default(float);
			float num2 = (array[0] = maxSqrDistanceNpc);
			float maxSqrDistanceInterest = default(float);
			float num3 = (array[1] = maxSqrDistanceInterest);
			float maxSqrDistanceCritter = default(float);
			float num4 = (array[1] = maxSqrDistanceCritter);
			float maxDistance = Mathf.Max(array);
			if (length <= 3)
			{
			}
			Plane[] frustumPlanes = GetFrustrumForFrame(camera, maxDistance);
			Camera camera2 = camera;
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			GameObject gameObject = default(GameObject);
			Mdl.Environments.Environment component = gameObject.GetComponent<Mdl.Environments.Environment>();
			Transform transform = camera.transform;
			List<int> list = (List<int>)(object)new List<T>();
			GridScript gridScript = default(GridScript);
			if ((object)gridScript != null)
			{
				Transform transform2 = camera.transform;
				List<int> list2 = default(List<int>);
				if (list2 != null)
				{
					goto IL_00dc;
				}
			}
			List<int> items2 = (List<int>)(object)new List<T>();
			goto IL_00dc;
			IL_00dc:
			((List<>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref items))._items = (T[])(object)items2;
			List<Mdl.Characters.Character> npcs = _npcs;
			Func<Mdl.Characters.Character, bool> func = (Func<Mdl.Characters.Character, bool>)(object)new Func<T, TResult>(IsValidNPC);
			IEnumerable<Mdl.Characters.Character> enumerable = (IEnumerable<Mdl.Characters.Character>)Enumerable.Where<Mdl.Characters.Character>((IEnumerable<>)npcs, (Func<, >)(object)func);
			Func<Mdl.Characters.Character, int> func2 = default(Func<Mdl.Characters.Character, int>);
			if (_003C_003Ec._003C_003E9__143_0 == null)
			{
				func2 = (Func<Mdl.Characters.Character, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Mdl.Characters.Character x)
				{
					Item _003CItem_003Ek__BackingField = x.Item;
					throw new NullReferenceException();
				});
			}
			List<int> list3 = (List<int>)(object)Enumerable.ToList<int>(Enumerable.Select<Mdl.Characters.Character, int>((IEnumerable<>)enumerable, (Func<, >)(object)func2));
			List<ItemScript> interests = _interests;
			Func<ItemScript, bool> func3 = (Func<ItemScript, bool>)(object)new Func<T, TResult>(IsValidInterest);
			IEnumerable<ItemScript> enumerable2 = (IEnumerable<ItemScript>)Enumerable.Where<ItemScript>((IEnumerable<>)interests, (Func<, >)(object)func3);
			Func<ItemScript, int> func4 = default(Func<ItemScript, int>);
			if (_003C_003Ec._003C_003E9__143_1 == null)
			{
				func4 = (Func<ItemScript, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ItemScript x)
				{
					Item item4 = x.Item;
					throw new NullReferenceException();
				});
			}
			List<int> list4 = (List<int>)(object)Enumerable.ToList<int>(Enumerable.Select<ItemScript, int>((IEnumerable<>)enumerable2, (Func<, >)(object)func4));
			IEnumerable<Mdl.Characters.Critters.Critter> activeCritters = (IEnumerable<Mdl.Characters.Critters.Critter>)SystemRoot.Instance.GetSystem<CritterManager>().GetActiveCritters();
			Func<Mdl.Characters.Critters.Critter, bool> func5 = (Func<Mdl.Characters.Critters.Critter, bool>)(object)new Func<T, TResult>(IsValidCritter);
			IEnumerable<Mdl.Characters.Critters.Critter> enumerable3 = (IEnumerable<Mdl.Characters.Critters.Critter>)Enumerable.Where<Mdl.Characters.Critters.Critter>((IEnumerable<>)activeCritters, (Func<, >)(object)func5);
			Func<Mdl.Characters.Critters.Critter, int> func6 = default(Func<Mdl.Characters.Critters.Critter, int>);
			if (_003C_003Ec._003C_003E9__143_2 == null)
			{
				func6 = (Func<Mdl.Characters.Critters.Critter, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Mdl.Characters.Critters.Critter x)
				{
					Item item3 = x.Item;
					throw new NullReferenceException();
				});
			}
			IEnumerable<Mdl.Characters.Critters.Critter> enumerable4 = (IEnumerable<Mdl.Characters.Critters.Critter>)Enumerable.Select<Mdl.Characters.Critters.Critter, int>((IEnumerable<>)enumerable3, (Func<, >)(object)func6);
			List<Mdl.Characters.Pets.Pet> pets = _pets;
			Func<Mdl.Characters.Pets.Pet, bool> func7 = (Func<Mdl.Characters.Pets.Pet, bool>)(object)new Func<T, TResult>(IsValidPet);
			IEnumerable<Mdl.Characters.Pets.Pet> enumerable5 = (IEnumerable<Mdl.Characters.Pets.Pet>)Enumerable.Where<Mdl.Characters.Pets.Pet>((IEnumerable<>)pets, (Func<, >)(object)func7);
			Func<Mdl.Characters.Pets.Pet, int> func8 = default(Func<Mdl.Characters.Pets.Pet, int>);
			if (_003C_003Ec._003C_003E9__143_3 == null)
			{
				func8 = (Func<Mdl.Characters.Pets.Pet, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Mdl.Characters.Pets.Pet x)
				{
					Item item2 = x.GetComponent<ItemScript>().Item;
					throw new NullReferenceException();
				});
			}
			IEnumerable<Mdl.Characters.Pets.Pet> enumerable6 = (IEnumerable<Mdl.Characters.Pets.Pet>)Enumerable.Select<Mdl.Characters.Pets.Pet, int>((IEnumerable<>)enumerable5, (Func<, >)(object)func8);
			BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
			uint num5 = num5 + 20;
			num5 += num5;
			List<ItemScript> interests2 = _interests;
			Action<ItemScript> action = (Action<ItemScript>)(object)(Action<T>)delegate(ItemScript x)
			{
				//Discarded unreachable code: IL_004b
				//IL_0045: Expected O, but got I4
				//IL_0045: Expected O, but got F4
				Transform transform10 = camera.transform;
				Transform transform11 = x.transform;
				UnityEngine.Vector3 vector9 = default(UnityEngine.Vector3);
				float z9 = vector9.z;
				Plane[] frustumPlanes9 = frustumPlanes;
				bool flag8 = IsInFrustum(x, frustumPlanes9);
				Item item = x.Item;
				float num9 = default(float);
				UnityEngine.Debug.LogError($"PointOfInterest-Dist: {num9:F2}, Visible: {flag8}, Name: {item}");
			};
			((List<T>)(object)interests2).ForEach((Action<>)(object)action);
			List<Mdl.Characters.Character> npcs2 = _npcs;
			Action<Mdl.Characters.Character> action2 = (Action<Mdl.Characters.Character>)(object)(Action<T>)delegate(Mdl.Characters.Character x)
			{
				//Discarded unreachable code: IL_0052
				//IL_004c: Expected O, but got I4
				//IL_004c: Expected O, but got F4
				Transform transform9 = camera.transform;
				UnityEngine.Vector3 vector7 = default(UnityEngine.Vector3);
				float z7 = vector7.z;
				Transform _003Ctransform_003Ek__BackingField = x.transform;
				UnityEngine.Vector3 vector8 = default(UnityEngine.Vector3);
				float z8 = vector8.z;
				Plane[] frustumPlanes8 = frustumPlanes;
				bool flag7 = x.IsInFrustum(frustumPlanes8);
				string arg3 = x.name;
				UnityEngine.Debug.LogError($"NPC-Dist: {z7:F2}, Visible: {flag7}, Name: {arg3}");
			};
			((List<T>)(object)npcs2).ForEach((Action<>)(object)action2);
			IEnumerable<Mdl.Characters.Critters.Critter> activeCritters2 = (IEnumerable<Mdl.Characters.Critters.Critter>)SystemRoot.Instance.GetSystem<CritterManager>().GetActiveCritters();
			Action<Mdl.Characters.Critters.Critter> action3 = (Action<Mdl.Characters.Critters.Critter>)(object)(Action<T>)delegate(Mdl.Characters.Critters.Critter x)
			{
				//Discarded unreachable code: IL_0052
				//IL_004c: Expected O, but got I4
				//IL_004c: Expected O, but got F4
				Transform transform7 = camera.transform;
				UnityEngine.Vector3 vector5 = default(UnityEngine.Vector3);
				float z5 = vector5.z;
				Transform transform8 = x.transform;
				UnityEngine.Vector3 vector6 = default(UnityEngine.Vector3);
				float z6 = vector6.z;
				Plane[] frustumPlanes7 = frustumPlanes;
				bool flag6 = x.IsInFrustum(frustumPlanes7);
				string arg2 = x.name;
				UnityEngine.Debug.LogError($"Critter-Dist: {z5:F2}, Visible: {flag6}, Name: {arg2}");
			};
			MoreLinq.ForEach<Mdl.Characters.Critters.Critter>((IEnumerable<>)activeCritters2, (Action<>)(object)action3);
			List<Mdl.Characters.Pets.Pet> pets2 = _pets;
			Action<Mdl.Characters.Pets.Pet> action4 = (Action<Mdl.Characters.Pets.Pet>)(object)(Action<T>)delegate(Mdl.Characters.Pets.Pet x)
			{
				//Discarded unreachable code: IL_0052
				//IL_004c: Expected O, but got I4
				//IL_004c: Expected O, but got F4
				Transform transform5 = camera.transform;
				UnityEngine.Vector3 vector3 = default(UnityEngine.Vector3);
				float z3 = vector3.z;
				Transform transform6 = x.transform;
				UnityEngine.Vector3 vector4 = default(UnityEngine.Vector3);
				float z4 = vector4.z;
				Plane[] frustumPlanes6 = frustumPlanes;
				bool flag5 = x.IsInFrustum(frustumPlanes6);
				string arg = x.name;
				UnityEngine.Debug.LogError($"Critter-Dist: {z3:F2}, Visible: {flag5}, Name: {arg}");
			};
			((List<T>)(object)pets2).ForEach((Action<>)(object)action4);
			[Cpp2IlInjected.Token(Token = "0x6003AA8")]
			[Cpp2IlInjected.Address(RVA = "0x9CF7A0", Offset = "0x9CE1A0", VA = "0x1809CF7A0")]
			static bool IsRenderingOn(Component obj)
			{
				//Discarded unreachable code: IL_001f
				//IL_0010: Expected O, but got I4
				SkinnedMeshRenderer componentInChildren = obj.GetComponentInChildren<SkinnedMeshRenderer>();
				int num6 = 0;
				if (componentInChildren == (UnityEngine.Object)num6)
				{
					return true;
				}
				return !componentInChildren.forceRenderingOff;
			}
			[Cpp2IlInjected.Token(Token = "0x6003AC4")]
			[Cpp2IlInjected.Address(RVA = "0x158D420", Offset = "0x158BE20", VA = "0x18158D420")]
			bool IsValidCritter(Mdl.Characters.Critters.Critter critter)
			{
				//Discarded unreachable code: IL_0025
				float maxSqrMagnitude3 = maxSqrDistanceCritter;
				bool flag2 = IsValidDistance(critter, maxSqrMagnitude3);
				if (!flag2)
				{
					return flag2;
				}
				Plane[] frustumPlanes3 = frustumPlanes;
				return critter.IsInFrustum(frustumPlanes3);
			}
			[Cpp2IlInjected.Token(Token = "0x6003AC1")]
			[Cpp2IlInjected.Address(RVA = "0x158D470", Offset = "0x158BE70", VA = "0x18158D470")]
			bool IsValidDistance(Component obj, float maxSqrMagnitude)
			{
				//Discarded unreachable code: IL_0032
				Transform transform3 = camera.transform;
				UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
				float z = vector.z;
				Transform transform4 = obj.transform;
				UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
				float z2 = vector2.z;
				float num7 = default(float);
				if (!(maxSqrMagnitude > num7))
				{
					int num8 = 0;
				}
				return IsRenderingOn(obj);
			}
			[Cpp2IlInjected.Token(Token = "0x6003AC3")]
			[Cpp2IlInjected.Address(RVA = "0x158D570", Offset = "0x158BF70", VA = "0x18158D570")]
			bool IsValidInterest(ItemScript script)
			{
				float maxSqrMagnitude4 = maxSqrDistanceInterest;
				bool flag3 = IsValidDistance(script, maxSqrMagnitude4);
				if (!flag3)
				{
					return flag3;
				}
				Plane[] frustumPlanes4 = frustumPlanes;
				return IsInFrustum(script, frustumPlanes4);
			}
			[Cpp2IlInjected.Token(Token = "0x6003AC2")]
			[Cpp2IlInjected.Address(RVA = "0x158D5C0", Offset = "0x158BFC0", VA = "0x18158D5C0")]
			bool IsValidNPC(Mdl.Characters.Character character)
			{
				//Discarded unreachable code: IL_0025
				float maxSqrMagnitude5 = maxSqrDistanceNpc;
				bool flag4 = IsValidDistance(character, maxSqrMagnitude5);
				if (!flag4)
				{
					return flag4;
				}
				Plane[] frustumPlanes5 = frustumPlanes;
				return character.IsInFrustum(frustumPlanes5);
			}
			[Cpp2IlInjected.Token(Token = "0x6003AC5")]
			[Cpp2IlInjected.Address(RVA = "0x158D610", Offset = "0x158C010", VA = "0x18158D610")]
			bool IsValidPet(Mdl.Characters.Pets.Pet pet)
			{
				//Discarded unreachable code: IL_0025
				float maxSqrMagnitude2 = maxSqrDistanceCritter;
				bool flag = IsValidDistance(pet, maxSqrMagnitude2);
				if (!flag)
				{
					return flag;
				}
				Plane[] frustumPlanes2 = frustumPlanes;
				return pet.IsInFrustum(frustumPlanes2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A7F")]
		[Cpp2IlInjected.Address(RVA = "0x9C9660", Offset = "0x9C8060", VA = "0x1809C9660")]
		private static Plane[] GetFrustrumForFrame(Camera camera, float maxDistance)
		{
			//Discarded unreachable code: IL_00dd
			//IL_00a4: Expected O, but got I4
			//IL_00ae: Expected O, but got I4
			//IL_00b8: Expected O, but got I4
			//IL_00c5: Expected O, but got I4
			//IL_00cf: Expected O, but got I4
			//IL_00da: Expected O, but got I4
			int pixelWidth = camera.pixelWidth;
			int pixelHeight = camera.pixelHeight;
			float nearClipPlane = camera.nearClipPlane;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			float nearClipPlane2 = camera.nearClipPlane;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z2 = vector2.z;
			nearClipPlane = nearClipPlane2;
			nearClipPlane = nearClipPlane2;
			nearClipPlane = nearClipPlane2;
			float nearClipPlane3 = camera.nearClipPlane;
			nearClipPlane = nearClipPlane2;
			UnityEngine.Vector3 vector3 = default(UnityEngine.Vector3);
			float z3 = vector3.z;
			nearClipPlane = nearClipPlane3;
			nearClipPlane = nearClipPlane3;
			nearClipPlane = nearClipPlane3;
			float nearClipPlane4 = camera.nearClipPlane;
			UnityEngine.Vector3 vector4 = default(UnityEngine.Vector3);
			float z4 = vector4.z;
			nearClipPlane = nearClipPlane4;
			UnityEngine.Vector3 vector5 = default(UnityEngine.Vector3);
			float z5 = vector5.z;
			nearClipPlane = nearClipPlane4;
			nearClipPlane = nearClipPlane4;
			nearClipPlane = nearClipPlane4;
			nearClipPlane = nearClipPlane4;
			Transform component = camera.GetComponent<Transform>();
			UnityEngine.Vector3 vector6 = default(UnityEngine.Vector3);
			float z6 = vector6.z;
			Plane[] array = new Plane[6];
			int num = 0;
			array[0] = (Plane)num;
			array[2] = (Plane)num;
			array[4] = (Plane)num;
			int num2 = 0;
			array[6] = (Plane)num;
			array[8] = (Plane)num;
			array[10] = (Plane)num;
			return array;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A80")]
		[Cpp2IlInjected.Address(RVA = "0x9CD650", Offset = "0x9CC050", VA = "0x1809CD650")]
		private static bool IsInFrustum(Component component, Plane[] frustumPlanes)
		{
			//IL_0010: Expected O, but got I4
			Collider component2 = component.GetComponent<Collider>();
			int num = 0;
			if (!(component2 != (UnityEngine.Object)num))
			{
				List<MeshRenderer> list = (List<MeshRenderer>)(object)new List<T>();
				component.GetComponentsInChildren<MeshRenderer>((List<>)(object)list);
				int size = ((List<>)(object)list)._size;
				int num2 = 0;
				Bounds bounds = default(Bounds);
				uint num3 = default(uint);
				if ((long)(int)num3 < (long)(IntPtr)bounds)
				{
					int num4 = 0;
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
					num3++;
				}
			}
			Collider component3 = component.GetComponent<Collider>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A81")]
		[Cpp2IlInjected.Address(RVA = "0x9C7F60", Offset = "0x9C6960", VA = "0x1809C7F60")]
		public void ConfirmPicture()
		{
			//Discarded unreachable code: IL_006d
			AK.Wwise.Event saveSfx = _saveSfx;
			if (saveSfx != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = saveSfx.Post(gameObject);
			}
			if (this.OnPictureTakenAction != null)
			{
				Texture texture = picture.m_Texture;
				Meta.Customization.Avatar activeAvatar = SystemRoot.Instance.MetaClient.profile.player_.ActiveAvatar;
				ProfilePlayer player_ = SystemRoot.Instance.MetaClient.profile.player_;
				List<int> list = itemsInScreenshot;
				if ((object)texture == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A82")]
		[Cpp2IlInjected.Address(RVA = "0x9CE4C0", Offset = "0x9CCEC0", VA = "0x1809CE4C0")]
		private void SharePicture()
		{
			//Discarded unreachable code: IL_0050
			if (this.OnPictureTakenAction != null)
			{
				Texture texture = picture.m_Texture;
				Meta.Customization.Avatar activeAvatar = SystemRoot.Instance.MetaClient.profile.player_.ActiveAvatar;
				ProfilePlayer player_ = SystemRoot.Instance.MetaClient.profile.player_;
				List<int> list = itemsInScreenshot;
				if ((object)texture == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A83")]
		[Cpp2IlInjected.Address(RVA = "0x9CE2D0", Offset = "0x9CCCD0", VA = "0x1809CE2D0")]
		private void ShareEventPicture()
		{
			//Discarded unreachable code: IL_0050
			if (this.OnPictureTakenAction != null)
			{
				Texture texture = picture.m_Texture;
				Meta.Customization.Avatar activeAvatar = SystemRoot.Instance.MetaClient.profile.player_.ActiveAvatar;
				ProfilePlayer player_ = SystemRoot.Instance.MetaClient.profile.player_;
				List<int> list = itemsInScreenshot;
				if ((object)texture == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A84")]
		[Cpp2IlInjected.Address(RVA = "0x9CE130", Offset = "0x9CCB30", VA = "0x1809CE130")]
		public void ResetState()
		{
			//Discarded unreachable code: IL_00bb
			//IL_002c: Expected O, but got I4
			//IL_005a: Expected O, but got I4
			//IL_0081: Expected O, but got I4
			GameObject toggleUiMenu = _toggleUiMenu;
			saved = false;
			isPictureTaken = false;
			toggleUiMenu.SetActive(value: true);
			GameObject gameObject = blurBackground;
			int num = 0;
			if (gameObject != (UnityEngine.Object)num)
			{
				GameObject gameObject2 = blurBackground;
				int active = 0;
				gameObject2.SetActive((byte)active != 0);
			}
			Texture texture = picture.m_Texture;
			int num2 = 0;
			if (texture != (UnityEngine.Object)num2)
			{
				UnityEngine.Object.DestroyImmediate(picture.m_Texture);
				RawImage rawImage = picture;
				int num3 = 0;
				rawImage.texture = (Texture)num3;
			}
			GameObject gameObject3 = picture.gameObject;
			int active2 = 0;
			gameObject3.SetActive((byte)active2 != 0);
			this.OnRefreshHint?.Invoke();
			ShowFrame();
			ResetModeTab();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A85")]
		[Cpp2IlInjected.Address(RVA = "0x9D11D0", Offset = "0x9CFBD0", VA = "0x1809D11D0")]
		private void UpdateTabsBasedOnScene()
		{
			//Discarded unreachable code: IL_0054
			//IL_0019: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			if (!EnvironmentAllowsFreeCamera())
			{
				Tab tab = freeCameraTab;
				int num = 0;
				if (tab != (UnityEngine.Object)num)
				{
					GameObject gameObject = freeCameraTab.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
				}
			}
			TabsContainer tabsContainer = modeTabsContainer;
			int num2 = 0;
			if (tabsContainer != (UnityEngine.Object)num2)
			{
				modeTabsContainer.Init();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A86")]
		[Cpp2IlInjected.Address(RVA = "0x9C8530", Offset = "0x9C6F30", VA = "0x1809C8530")]
		private bool EnvironmentAllowsFreeCamera()
		{
			//Discarded unreachable code: IL_002b
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			return gameObject.GetComponent<Mdl.Environments.Environment>().AllowPhotoToolFreeCamera;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A87")]
		[Cpp2IlInjected.Address(RVA = "0x9CEAD0", Offset = "0x9CD4D0", VA = "0x1809CEAD0")]
		public void Show()
		{
			//Discarded unreachable code: IL_0066
			int num = 0;
			GameObject gameObject = UiRoot.Instance._worldCanvas.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			int num2 = 0;
			GraphicSettings.IncreaseShadowQuality();
			PlayerAvatar avatar = _avatar;
			int num3 = 0;
			avatar.ChangeMovementEnabled((byte)num3 != 0);
			_avatar.RelaxingBehaviour.ForceEndRelax();
			base.gameObject.SetActive(value: true);
			IsShown = true;
			InitMode();
			ResetState();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A88")]
		[Cpp2IlInjected.Address(RVA = "0x9C9E50", Offset = "0x9C8850", VA = "0x1809C9E50")]
		public void Hide()
		{
			//Discarded unreachable code: IL_00b5, IL_00bb
			int num = 0;
			int num2 = 0;
			UiRoot.Instance._worldCanvas.gameObject.SetActive(value: true);
			int num3 = 0;
			GraphicSettings.SetShadowsCurrentSettings();
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			IsShown = (byte)num != 0;
			PostProcessManager.Instance.SetDof(DOFDistance.DEFAULT);
			AvatarAppearance appearance = _avatar.appearance;
			int selfieMode = 0;
			appearance.SetSelfieMode((byte)selfieMode != 0);
			Camera camera = _camera;
			float num4 = (camera.fieldOfView = _normalFov);
			List<Mdl.Characters.Character> npcs = _npcs;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
			}
			int num5 = 0;
			int num6 = 0;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z2 = vector2.z;
			UnityEngine.Vector3 vector3 = default(UnityEngine.Vector3);
			float z3 = vector3.z;
			int num7 = 0;
			WeatherController.ResetAnchor();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A89")]
		[Cpp2IlInjected.Address(RVA = "0x9D0490", Offset = "0x9CEE90", VA = "0x1809D0490")]
		public void UpdateState(float deltaTime, bool dontMoveNpcs)
		{
			//IL_01f4: Expected O, but got I4
			//IL_0219: Expected O, but got I4
			//IL_028c: Expected O, but got I4
			//IL_02af: Expected O, but got I4
			//IL_0376: Expected O, but got F4
			//IL_0391: Expected O, but got F4
			//IL_03fc: Expected O, but got F4
			//IL_0428: Expected O, but got I4
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float num3 = default(float);
			AimConstraint aimConstraint = default(AimConstraint);
			while (true)
			{
				int num = 0;
				CameraCollisionSystem.UpdateCharacterVisibilityFromPlayerCamera();
				if (picture.gameObject.activeSelf)
				{
					return;
				}
				_move.Update(deltaTime);
				InputAction[] array = new InputAction[14];
				InputAction inputAction = actionPan;
				if (inputAction != null && array == null)
				{
					continue;
				}
				array[0] = inputAction;
				InputAction inputAction2 = actionRotate;
				if (inputAction2 != null && array == null)
				{
					continue;
				}
				array[1] = inputAction2;
				InputAction inputAction3 = actionZoom;
				if (inputAction3 != null && array == null)
				{
					continue;
				}
				array[2] = inputAction3;
				InputAction inputAction4 = actionTriggerRotateButton;
				if (inputAction4 != null && array == null)
				{
					continue;
				}
				array[3] = inputAction4;
				InputAction inputAction5 = actionTriggerRotate;
				if (inputAction5 != null && array == null)
				{
					continue;
				}
				array[4] = inputAction5;
				InputAction inputAction6 = actionTriggerRotateMouseAxis;
				if (inputAction6 != null && array == null)
				{
					continue;
				}
				array[5] = inputAction6;
				InputAction inputAction7 = actionTriggerPanButton;
				if (inputAction7 != null && array == null)
				{
					continue;
				}
				array[6] = inputAction7;
				InputAction inputAction8 = actionTriggerPan;
				if (inputAction8 != null && array == null)
				{
					continue;
				}
				array[7] = inputAction8;
				InputAction inputAction9 = actionTriggerRotateAvatar;
				if (inputAction9 != null && array == null)
				{
					continue;
				}
				array[8] = inputAction9;
				InputAction inputAction10 = actionTriggerRotateAvatarMouseAxis;
				if (inputAction10 != null && array == null)
				{
					continue;
				}
				array[9] = inputAction10;
				InputAction inputAction11 = actionRotateAvatar;
				if (inputAction11 != null && array == null)
				{
					continue;
				}
				array[10] = inputAction11;
				InputAction inputAction12 = actionFreeCameraPan;
				if (inputAction12 != null && array == null)
				{
					continue;
				}
				array[11] = inputAction12;
				InputAction inputAction13 = actionTriggerZoomButton;
				if (inputAction13 != null && array == null)
				{
					continue;
				}
				array[12] = inputAction13;
				InputAction inputAction14 = actionTriggerZoom;
				if (inputAction14 != null && array == null)
				{
					continue;
				}
				array[13] = inputAction14;
				InputAction.UpdateAll(deltaTime, array);
				Tween<float> fovTransition = _fovTransition;
				int num2 = 0;
				if (fovTransition != null)
				{
					int reverse = 0;
					if (!((Tween<T>)(object)fovTransition).Play(deltaTime, (byte)reverse != 0))
					{
						_fovTransition = (Tween<float>)num2;
					}
				}
				Tween<UnityEngine.Vector3> avatarCrouchTransition = _avatarCrouchTransition;
				if (avatarCrouchTransition != null)
				{
					int reverse2 = 0;
					if (!((Tween<T>)(object)avatarCrouchTransition).Play(deltaTime, (byte)reverse2 != 0))
					{
						_avatarCrouchTransition = (Tween<UnityEngine.Vector3>)num2;
					}
				}
				Tween<UnityEngine.Vector3> positionTransition = _positionTransition;
				if (positionTransition != null && (IntPtr)_rotationTransition != (IntPtr)num2)
				{
					int reverse3 = 0;
					if (!((Tween<T>)(object)positionTransition).Play(deltaTime, (byte)reverse3 != 0))
					{
						FreeCameraControl freeCamera = _freeCamera;
						CameraNavigationConfig cameraConfig = _cameraConfig;
						PlayerNavigationConfig playerConfig = _playerConfig;
						PlayerAvatar avatar = _avatar;
						Camera camera = _camera;
						Transform initialCamera = freeCamStartTransform;
						freeCamera.Init(camera, avatar, playerConfig, initialCamera, cameraConfig);
						_positionTransition = (Tween<UnityEngine.Vector3>)num2;
					}
					Tween<Quaternion> rotationTransition = _rotationTransition;
					int reverse4 = 0;
					if (((Tween<T>)(object)rotationTransition).Play(deltaTime, (byte)reverse4 != 0))
					{
						return;
					}
					_rotationTransition = (Tween<Quaternion>)num2;
				}
				PhotoModeType mode = _mode;
				if (mode != 0)
				{
					if (mode != 0)
					{
						if (mode == PhotoModeType.Avatar)
						{
							FreeCameraControl freeCamera2 = _freeCamera;
							InputAction zoomAction = actionZoom;
							InputAction panAction = actionFreeCameraPan;
							MoveGesture move = _move;
							InputAction rotateAction = actionRotate;
							freeCamera2.MoveCamera(deltaTime, move, panAction, rotateAction, zoomAction, (byte)num2 != 0);
							Transform transform = freeCameraTarget.transform;
							Camera camera2 = _camera;
							FreeCameraControl freeCamera3 = _freeCamera;
							Transform transform2 = camera2.transform;
							CallOnce callOnce = initFreeCameraModeAfterTransition;
							Action a = delegate
							{
								//Discarded unreachable code: IL_0021
								//IL_0015: Expected O, but got I4
								Transform anchor = freeCameraTarget.transform;
								int num6 = 0;
								WeatherController.SetAnchor(anchor, (UnityEngine.Vector3)num6);
								PostProcessManager.Instance.SetDof(DOFDistance.DEFAULT);
							};
							callOnce.InvokeOnce(a);
							float z = m_Cascade4SplitOld.z;
							FieldInfo cascade4Split = m_Cascade4Split;
							UniversalRenderPipelineAsset obj = lwrp;
							cascade4Split.SetValue(obj, z);
							FieldInfo cascade2Split = m_Cascade2Split;
							UniversalRenderPipelineAsset obj2 = lwrp;
							cascade2Split.SetValue(obj2, z);
						}
						if (_mode != PhotoModeType.Free)
						{
							Transform transform3 = _camera.transform;
							Transform _003Ctransform_003Ek__BackingField = _avatar.transform;
							Transform transform4 = _camera.transform;
							Transform _003Ctransform_003Ek__BackingField2 = _avatar.transform;
							float z2 = vector.z;
							if (lwrp.shadowCascadeOption != ShadowCascadesOption.TwoCascades)
							{
								break;
							}
							UniversalRenderPipelineAsset obj3 = lwrp;
							m_Cascade2Split.SetValue(obj3, num3);
						}
						return;
					}
					OrbitCamera orbitCamera = _orbitCamera;
					InputAction inputAction15 = actionZoom;
				}
				UpdateSelfieCamera(dontMoveNpcs);
				LookAtBehaviour avatarLookAtBehaviour = _avatarLookAtBehaviour;
				int num4 = 0;
				if (avatarLookAtBehaviour != (UnityEngine.Object)num4)
				{
					int length = _eyeAimConstraints.Length;
					float num5 = (aimConstraint.weight = _avatarLookAtBehaviour.CurrentWeight);
					break;
				}
			}
			FieldInfo cascade4Split2 = m_Cascade4Split;
			UniversalRenderPipelineAsset obj4 = lwrp;
			object value = cascade4Split2.GetValue(obj4);
			UniversalRenderPipelineAsset universalRenderPipelineAsset = lwrp;
			FieldInfo cascade4Split3 = m_Cascade4Split;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A8A")]
		[Cpp2IlInjected.Address(RVA = "0x9D0070", Offset = "0x9CEA70", VA = "0x1809D0070")]
		private void UpdateSelfieCamera(bool dontMoveNpcs)
		{
			//Discarded unreachable code: IL_014f, IL_0155, IL_015b
			int num = 0;
			SelfieCameraController selfieCameraController = _selfieCameraController;
			InputAction rotateCamera = actionRotate;
			InputAction rotateAvatar = actionRotateAvatar;
			selfieCameraController.AddInput(rotateAvatar, rotateCamera);
			SelfieCameraController selfieCameraController2 = _selfieCameraController;
			int num2 = 0;
			float deltaTime = Time.deltaTime;
			selfieCameraController2.Update(deltaTime);
			float degrees = Trigo.ClampAngleDegrees180(_selfieCamera.CurrentPitch);
			float minPitch = _selfieCameraTarget.cameraConfig.minPitch;
			float num3 = Mathf.Clamp01(Trigo.ClampAngleDegrees180(degrees)) * 2f;
			_avatar.appearance.SetSelfieAngle(deltaTime);
			if (!_selfieCameraController.IsInTransition)
			{
				Transform transform = _selfieCameraTarget.transform;
				UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
				float z = vector.z;
				OrbitCameraConfig cameraConfig = _selfieCameraTarget.cameraConfig;
				Transform transform2 = _selfieCamera.Camera.transform;
				UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
				float z2 = vector2.z;
				Transform transform3 = _selfieCameraTarget.transform;
				UnityEngine.Vector3 vector3 = default(UnityEngine.Vector3);
				float z3 = vector3.z;
				float num4 = default(float);
				minPitch = num4;
				List<Mdl.Characters.Character> npcs = _npcs;
				bool flag = default(bool);
				if (flag)
				{
					float num5 = npcReactMinDistance;
					float num6 = npcReactMaxDistance;
					float y = _selfieLookAtFlat.y;
					OrbitCameraConfig cameraConfig2 = _selfieCameraTarget.cameraConfig;
					float minPitch2 = cameraConfig2.minPitch;
					float maxPitch = cameraConfig2.maxPitch;
					ViewMargins viewMargins = npcReactViewMargins;
					PlayerAvatar avatar = _avatar;
					Camera camera = _camera;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A8B")]
		[Cpp2IlInjected.Address(RVA = "0x9CDCD0", Offset = "0x9CC6D0", VA = "0x1809CDCD0")]
		private static float RemapPitchToAnimationRange(float currentPitch, float minPitch, float maxPitch)
		{
			return Trigo.ClampAngleDegrees180(currentPitch) * -1f;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A8C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_ONSCREEN_PHOTOVIEW")]
		private static void OnscreenDebug(string name, float value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003A8D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_ONSCREEN_PHOTOVIEW")]
		private static void OnscreenDebug(string name, string value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003A8E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_ONSCREEN_PHOTOVIEW")]
		private static void OnscreenDebug(string name, bool value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003A8F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_ONSCREEN_PHOTOVIEW")]
		private static void OnscreenDebug(string name, Vector2 value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003A90")]
		[Cpp2IlInjected.Address(RVA = "0x9C5450", Offset = "0x9C3E50", VA = "0x1809C5450")]
		private void SendEvent(SavedPhoto savedPhoto, string animationType, string animationName, string pictureState, List<Item> avatarItem, Dictionary<string, int> appearanceConfig)
		{
			savedPhoto.photoInfo.animationType = animationType;
			savedPhoto.photoInfo.animationName = animationName;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A91")]
		[Cpp2IlInjected.Address(RVA = "0x9CF560", Offset = "0x9CDF60", VA = "0x1809CF560")]
		public void ToggleImageFormat()
		{
			//Discarded unreachable code: IL_0064
			//IL_0036: Expected I4, but got I8
			//IL_003f: Expected I4, but got I8
			//IL_0048: Expected I4, but got I8
			AK.Wwise.Event toggleFormatSfx = _toggleFormatSfx;
			if (toggleFormatSfx != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = toggleFormatSfx.Post(gameObject);
			}
			PhotoModeImageFormat photoModeImageFormat = imageFormat;
			if (photoModeImageFormat != 0)
			{
				if (photoModeImageFormat != PhotoModeImageFormat.Landscape)
				{
					if (photoModeImageFormat != PhotoModeImageFormat.Portrait)
					{
						goto IL_0048;
					}
					imageFormat = PhotoModeImageFormat.Square;
				}
				imageFormat = PhotoModeImageFormat.Portrait;
			}
			imageFormat = PhotoModeImageFormat.Landscape;
			goto IL_0048;
			IL_0048:
			ShowFrame();
			int currentFrame = photoFrameEffect.currentFrame;
			ChangeFrame(currentFrame);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A92")]
		[Cpp2IlInjected.Address(RVA = "0x9C9DF0", Offset = "0x9C87F0", VA = "0x1809C9DF0")]
		private void HideFrame()
		{
			//Discarded unreachable code: IL_0035
			Image image = bgFormat;
			int num = ((image.enabled = false) ? 1 : 0);
			Image image2 = bgFormatCaptured;
			int num2 = ((image2.enabled = false) ? 1 : 0);
			Image image3 = bgFormatClick;
			int num3 = ((image3.enabled = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A93")]
		[Cpp2IlInjected.Address(RVA = "0x9CE6B0", Offset = "0x9CD0B0", VA = "0x1809CE6B0")]
		private void ShowFrame()
		{
			//Discarded unreachable code: IL_0190
			Image image = bgFormat;
			int num = ((image.enabled = false) ? 1 : 0);
			Image image2 = bgFormatCaptured;
			int num2 = ((image2.enabled = false) ? 1 : 0);
			Image image3 = bgFormatClick;
			int num3 = ((image3.enabled = false) ? 1 : 0);
			RectTransform component = bgFormat.GetComponent<RectTransform>();
			int num4 = 0;
			RectTransform component2 = UiRoot.Instance._menuStack.GetComponent<RectTransform>();
			int num5 = 0;
			CanvasScaler component3 = UiRoot.Instance._menuStack.GetComponent<CanvasScaler>();
			Vector2 sizeDelta = component2.sizeDelta;
			PhotoModeImageFormat photoModeImageFormat = imageFormat;
			if (photoModeImageFormat != 0)
			{
				if (photoModeImageFormat != PhotoModeImageFormat.Landscape)
				{
					if (photoModeImageFormat != PhotoModeImageFormat.Portrait)
					{
						goto IL_00e9;
					}
					Vector2 sizeDelta2 = component2.sizeDelta;
					Vector2 sizeDelta3 = component2.sizeDelta;
				}
				int num6 = 0;
				Camera main = Camera.main;
				float aspect = main.aspect;
				if ((object)main == null)
				{
					Vector2 sizeDelta4 = component2.sizeDelta;
					Vector2 sizeDelta5 = component2.sizeDelta;
				}
				Vector2 sizeDelta6 = component2.sizeDelta;
				Vector2 sizeDelta7 = component2.sizeDelta;
			}
			Vector2 sizeDelta8 = component2.sizeDelta;
			Vector2 sizeDelta9 = component2.sizeDelta;
			goto IL_00e9;
			IL_00e9:
			bgFormat.enabled = true;
			RectTransform component4 = bgFormatCaptured.GetComponent<RectTransform>();
			Vector2 vector = (component4.sizeDelta = component.sizeDelta);
			Image image4 = bgFormatCaptured;
			int num7 = ((image4.enabled = false) ? 1 : 0);
			RectTransform component5 = bgFormatClick.GetComponent<RectTransform>();
			Vector2 sizeDelta11 = component.sizeDelta;
			Vector2 sizeDelta12 = component.sizeDelta;
			component5.sizeDelta = sizeDelta11;
			Image image5 = bgFormatClick;
			int num8 = ((image5.enabled = false) ? 1 : 0);
			RectTransform component6 = customFrame.GetComponent<RectTransform>();
			Vector2 vector2 = (component6.sizeDelta = component.sizeDelta);
			customFrame.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A94")]
		[Cpp2IlInjected.Address(RVA = "0x9CDAA0", Offset = "0x9CC4A0", VA = "0x1809CDAA0")]
		private void PlayFrameAnimation()
		{
			//IL_0036: Expected F4, but got I4
			//IL_0036: Expected F4, but got I4
			//IL_005b: Expected F4, but got I4
			//IL_005b: Expected F4, but got I4
			//IL_00da: Expected F4, but got I4
			//IL_00ff: Expected F4, but got I4
			int num = 0;
			Sequence sequence = DOTween.Sequence();
			TweenCallback callback = delegate
			{
				//Discarded unreachable code: IL_0029
				Image image7 = bgFormat;
				int num12 = ((image7.enabled = false) ? 1 : 0);
				bgFormatCaptured.enabled = true;
				bgFormatClick.enabled = true;
			};
			Sequence sequence2 = sequence.AppendCallback(callback);
			Image image = fade;
			int num2 = 0;
			int num3 = 0;
			TweenerCore<Color, Color, ColorOptions> t = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOFade(image, (float)num3, (float)num2);
			Sequence sequence3 = sequence.Append(t);
			Image image2 = bgFormatClick;
			int num4 = 0;
			int num5 = 0;
			TweenerCore<Color, Color, ColorOptions> t2 = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOFade(image2, (float)num5, (float)num4);
			Sequence sequence4 = sequence.Join(t2);
			TweenerCore<Color, Color, ColorOptions> t3 = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOFade(fade, 0.5f, 0.25f);
			Sequence sequence5 = sequence.Append(t3);
			TweenerCore<Color, Color, ColorOptions> t4 = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOFade(bgFormatClick, 1f, 0.25f);
			Sequence sequence6 = sequence.Join(t4);
			TweenCallback callback2 = delegate
			{
				//Discarded unreachable code: IL_0049
				//IL_0034: Expected F4, but got I4
				AK.Wwise.Event captureSfxEvent = _captureSfxEvent;
				GameObject gameObject = base.gameObject;
				uint num10 = captureSfxEvent.Post(gameObject);
				PhotoMenu photoMenu = this.photoMenu;
				photoMenu._isUIHidden = false;
				int num11 = 0;
				photoMenu.Invoke("UpdateUI", num11);
				GameObject toggleUiMenu = _toggleUiMenu;
				int active = 0;
				toggleUiMenu.SetActive((byte)active != 0);
			};
			Sequence sequence7 = sequence.AppendCallback(callback2);
			Image image3 = fade;
			int num6 = 0;
			TweenerCore<Color, Color, ColorOptions> t5 = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOFade(image3, (float)num6, 0.25f);
			Sequence sequence8 = sequence.Append(t5);
			Image image4 = bgFormatClick;
			int num7 = 0;
			TweenerCore<Color, Color, ColorOptions> t6 = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOFade(image4, (float)num7, 0.5f);
			Sequence sequence9 = sequence.Join(t6);
			TweenCallback action = delegate
			{
				//Discarded unreachable code: IL_002d
				Image image5 = bgFormat;
				int num8 = ((image5.enabled = false) ? 1 : 0);
				bgFormatCaptured.enabled = true;
				Image image6 = bgFormatClick;
				int num9 = ((image6.enabled = false) ? 1 : 0);
			};
			Sequence sequence10 = sequence.OnComplete(action);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A95")]
		[Cpp2IlInjected.Address(RVA = "0x9CF090", Offset = "0x9CDA90", VA = "0x1809CF090")]
		public void SwitchToNextCameraMode()
		{
			//IL_0048: Expected I4, but got I8
			//IL_0076: Expected I4, but got I8
			//IL_0085: Expected I4, but got I8
			if (!_isInFovAnimation)
			{
				AK.Wwise.Event toggleModeSfx = _toggleModeSfx;
				if (toggleModeSfx != null)
				{
					GameObject gameObject = base.gameObject;
					uint num = toggleModeSfx.Post(gameObject);
				}
				PhotoModeType mode = _mode;
				if (mode != 0)
				{
					if (mode != PhotoModeType.Avatar)
					{
						if (mode != PhotoModeType.Free)
						{
							goto IL_008b;
						}
						ResetPose();
						_mode = PhotoModeType.Selfie;
					}
					bool flag = EnvironmentAllowsFreeCamera();
					PhotoModeType mode2 = _mode;
					if ((!flag && mode2 == PhotoModeType.Selfie) || mode2 == PhotoModeType.Free)
					{
						goto IL_008b;
					}
					ResetPose();
					_mode = PhotoModeType.Free;
				}
				ResetPose();
				_mode = PhotoModeType.Avatar;
				InitMode();
			}
			goto IL_008b;
			IL_008b:
			ResetModeTab();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A96")]
		[Cpp2IlInjected.Address(RVA = "0x9CDD30", Offset = "0x9CC730", VA = "0x1809CDD30")]
		private void ResetModeTab()
		{
			//Discarded unreachable code: IL_009a
			//IL_0010: Expected O, but got I4
			PhotoMenu photoMenu = this.photoMenu;
			int num = 0;
			if (photoMenu != (UnityEngine.Object)num && this.photoMenu._isUIHidden)
			{
				GameObject gameObject = modeTabsContainer.gameObject;
			}
			modeTabsContainer.gameObject.SetActive(value: true);
			Image component = selfieCameraTab.icon.gameObject.GetComponent<Image>();
			Image component2 = avatarCameraTab.icon.gameObject.GetComponent<Image>();
			Image component3 = freeCameraTab.icon.gameObject.GetComponent<Image>();
			switch (_mode)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A97")]
		[Cpp2IlInjected.Address(RVA = "0x9CF600", Offset = "0x9CE000", VA = "0x1809CF600")]
		private void ToggleModeCamera(int index)
		{
			PhotoModeType mode = _mode;
			if (mode != (PhotoModeType)index)
			{
				AK.Wwise.Event toggleModeSfx = _toggleModeSfx;
				if (toggleModeSfx != null)
				{
					GameObject gameObject = base.gameObject;
					uint num = toggleModeSfx.Post(gameObject);
				}
			}
			if (mode != (PhotoModeType)index)
			{
				ResetPose();
				_mode = (PhotoModeType)index;
				InitMode();
			}
			ResetModeTab();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A98")]
		[Cpp2IlInjected.Address(RVA = "0x9C7BD0", Offset = "0x9C65D0", VA = "0x1809C7BD0")]
		public void ChangeVisualEffect(int index, bool isClose)
		{
			isChangingEffect = true;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A99")]
		[Cpp2IlInjected.Address(RVA = "0x9C7860", Offset = "0x9C6260", VA = "0x1809C7860")]
		public void ChangePose(int iconIndex)
		{
			int num = 0;
			if (_mode == (PhotoModeType)num)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A9A")]
		[Cpp2IlInjected.Address(RVA = "0x9C7AA0", Offset = "0x9C64A0", VA = "0x1809C7AA0")]
		private void ChangePose(PhotoModePoseSelfie poseSelfie, bool init = false)
		{
			//Discarded unreachable code: IL_006e
			if (init || currentPoseSelfie != poseSelfie)
			{
				PlayerAvatar avatar = _avatar;
				currentPoseSelfie = poseSelfie;
				avatar.Animator.ResetTrigger("selfieExit");
				_avatar.Animator.ResetTrigger("selfieChange");
				_avatar.Animator.SetInteger("SelfieNumber", (int)poseSelfie);
				_avatar.Animator.SetTrigger("selfieChange");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A9B")]
		[Cpp2IlInjected.Address(RVA = "0x9C7880", Offset = "0x9C6280", VA = "0x1809C7880")]
		private void ChangePose(PhotoModePoseStanding poseStanding, bool init = false)
		{
			//Discarded unreachable code: IL_00c9
			//IL_00c8: Expected F4, but got I4
			if (init || currentPoseStanding != poseStanding)
			{
				PlayerAvatar avatar = _avatar;
				currentPoseStanding = poseStanding;
				avatar.Animator.ResetTrigger("PhotoPose_Body");
				PlayerAvatar avatar2 = _avatar;
				if (poseStanding != PhotoModePoseStanding.None)
				{
					avatar2.Animator.ResetTrigger("selfieExit");
					_avatar.Animator.ResetTrigger("Exit_Body");
					_avatar.Animator.SetInteger("PhotoPose_BodyNumber", (int)poseStanding);
					Animator animator = _avatar.Animator;
				}
				avatar2.Animator.SetTrigger("Exit_Body");
				Animator animator2 = _avatar.Animator;
				Animator animator3 = _avatar.Animator;
				int num = 0;
				int layerIndex = animator3.GetLayerIndex("Facial_Animation");
				animator2.SetLayerWeight(layerIndex, num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A9C")]
		[Cpp2IlInjected.Address(RVA = "0x9CE020", Offset = "0x9CCA20", VA = "0x1809CE020")]
		private void ResetPose()
		{
			//Discarded unreachable code: IL_005c
			PlayerAvatar avatar = _avatar;
			if (_mode != 0)
			{
				avatar.Animator.ResetTrigger("PhotoPose_Body");
				_avatar.Animator.SetTrigger("Exit_Body");
			}
			else
			{
				avatar.Animator.ResetTrigger("selfieChange");
				_avatar.Animator.SetTrigger("selfieExit");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A9D")]
		[Cpp2IlInjected.Address(RVA = "0x9C7540", Offset = "0x9C5F40", VA = "0x1809C7540")]
		public void ChangeExpression(PhotoModeExpression expression, bool init = false)
		{
			//IL_007c: Expected F4, but got I4
			if (init || currentExpression != expression)
			{
				PlayerAvatar avatar = _avatar;
				currentExpression = expression;
				if (expression == PhotoModeExpression.None)
				{
					Animator animator = default(Animator);
					animator.SetTrigger("PhotoMode_Default");
					Animator animator2 = default(Animator);
					int layerIndex = animator2.GetLayerIndex("Facial_Animation");
					throw new NullReferenceException();
				}
				avatar.Animator.SetInteger("PhotoPose_FaceNumber", (int)expression);
				_avatar.Animator.SetTrigger("PhotoPose_Face");
				Animator animator3 = _avatar.Animator;
				Animator animator4 = _avatar.Animator;
				int num = 0;
				int layerIndex2 = animator4.GetLayerIndex("Facial_Animation");
				int num2 = 0;
				animator3.SetLayerWeight(layerIndex2, num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A9E")]
		[Cpp2IlInjected.Address(RVA = "0x9C7720", Offset = "0x9C6120", VA = "0x1809C7720")]
		public void ChangeFrame(int index)
		{
			//Discarded unreachable code: IL_0018
			photoFrameEffect.currentFrame = index;
			photoFrameEffect.RemoveFrame();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A9F")]
		[Cpp2IlInjected.Address(RVA = "0x9C95E0", Offset = "0x9C7FE0", VA = "0x1809C95E0")]
		private RectTransform GetCanvasRect()
		{
			//Discarded unreachable code: IL_0021
			RectTransform component = bgFormat.GetComponent<RectTransform>();
			if (!isPictureTaken)
			{
			}
			return bgFormatCaptured.GetComponent<RectTransform>();
		}

		[Cpp2IlInjected.Token(Token = "0x6003AA0")]
		[Cpp2IlInjected.Address(RVA = "0x9C7D40", Offset = "0x9C6740", VA = "0x1809C7D40")]
		public void Cleanup(bool start)
		{
			//Discarded unreachable code: IL_00b4
			//IL_0023: Expected I4, but got I8
			//IL_005a: Expected O, but got I4
			//IL_00a6: Expected F4, but got I4
			ResetState();
			ChangeVisualEffect(-1, isClose: true);
			photoFrameEffect.currentFrame = -1;
			photoFrameEffect.RemoveFrame();
			ResetPose();
			if (!start)
			{
				_avatar.Animator.SetTrigger("Exit_Face");
				bool flag = default(bool);
				if (flag)
				{
					int num = 0;
					removeToolScope = (Toolbox.TemporarySwitchToolScope)num;
				}
				PlayerAvatar avatar = _avatar;
				bool flag2 = default(bool);
				if (flag2)
				{
					int num2 = 0;
				}
				int num3 = 0;
				EnableEyeAimConstraints((byte)num3 != 0);
				Animator animator = _avatar.Animator;
				int layerIndex = _avatar.Animator.GetLayerIndex("Facial_Animation_Portrait");
				int num4 = 0;
				animator.SetLayerWeight(layerIndex, num4);
			}
			else
			{
				int init = 0;
				ChangeExpression(PhotoModeExpression.None, (byte)init != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AA1")]
		[Cpp2IlInjected.Address(RVA = "0x9C83A0", Offset = "0x9C6DA0", VA = "0x1809C83A0")]
		private void EnableEyeAimConstraints(bool enabled)
		{
			//Discarded unreachable code: IL_0065
			//IL_005e: Expected O, but got I4
			AimConstraint[] eyeAimConstraints = _eyeAimConstraints;
			int num = 0;
			int num2 = 0;
			int length = eyeAimConstraints.Length;
			if (num >= length)
			{
				return;
			}
			AimConstraint aimConstraint = eyeAimConstraints[num];
			if (aimConstraint.constraintActive != enabled)
			{
				aimConstraint.constraintActive = enabled;
				if (!enabled)
				{
					if (aimConstraint.sourceCount <= 0)
					{
						goto IL_0060;
					}
					int index = 0;
					aimConstraint.RemoveSource(index);
					num++;
				}
				int num3 = 0;
				int num4 = 0;
				int num5 = aimConstraint.AddSource((ConstraintSource)num3);
			}
			goto IL_0060;
			IL_0060:
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AA2")]
		[Cpp2IlInjected.Address(RVA = "0x9D12C0", Offset = "0x9CFCC0", VA = "0x1809D12C0")]
		public PhotoView()
		{
		}//Discarded unreachable code: IL_00ea
		//IL_0052: Expected I4, but got I8
		//IL_005c: Expected I4, but got I8
		//IL_006c: Expected I4, but got I8
		//IL_0075: Expected I4, but got I8

	}
}
