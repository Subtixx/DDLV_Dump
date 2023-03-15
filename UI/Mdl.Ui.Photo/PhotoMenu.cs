using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Assets.Scripts.Gestures;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Items;
using Definitions.Util;
using Gameloft.Common;
using Gameloft.FileSystem.Abstraction;
using Mdl.Avatar;
using Mdl.InputSystem;
using Mdl.Navigation;
using Mdl.Platform;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Meta.Customization;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Photo
{
	[Cpp2IlInjected.Token(Token = "0x2000944")]
	public class PhotoMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x4003697")]
		public static readonly string PHOTO_TIMESTAMP_FORMAT = "yyyy-MM-dd HH:mm:ss.fff";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400369A")]
		private PhotoMenuParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400369B")]
		[SerializeField]
		[Header("Config")]
		private PlayerNavigationConfig _playerConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400369C")]
		[SerializeField]
		private CameraNavigationConfig _cameraConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400369D")]
		[SerializeField]
		[Header("Game Objects")]
		private PhotoView _photoView;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400369E")]
		[SerializeField]
		private TabsContainer _modeTabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400369F")]
		[SerializeField]
		private PhotoMenuTab _photoMenuTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40036A0")]
		[SerializeField]
		private Button _closeButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40036A1")]
		[SerializeField]
		private SlidingPanelGroup _slidingObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40036A2")]
		[SerializeField]
		private GameObject _vfxFireworks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40036A3")]
		[SerializeField]
		private AK.Wwise.Event _confirmSaveSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40036A4")]
		[SerializeField]
		private AK.Wwise.Event _declineSaveSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40036A5")]
		[SerializeField]
		[Header("Shortcut Indicators")]
		private GameObject _shortcutsHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40036A6")]
		[SerializeField]
		private GameObject _cameraControlShortcuts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40036A7")]
		[SerializeField]
		private GameObject _cameraControlGamepadShortcuts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40036A8")]
		[SerializeField]
		public GameObject _crouchShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40036A9")]
		[SerializeField]
		public GameObject _crouchGamepadShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40036AA")]
		[SerializeField]
		private GameObject _backShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40036AB")]
		[SerializeField]
		private GameObject _backGamepadShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40036AC")]
		[SerializeField]
		[Header("Visibility")]
		private List<GameObject> _photoModeShortcuts = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40036AD")]
		[SerializeField]
		private List<GameObject> _freeCamModeShortcuts = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40036AE")]
		[SerializeField]
		private List<GameObject> _saveShortcuts = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40036AF")]
		[SerializeField]
		private List<GameObject> _hideUiShortcut = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40036B0")]
		[SerializeField]
		[Tooltip("Used for desktop only")]
		private List<GameObject> _saveAndShareShortcuts = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40036B1")]
		[SerializeField]
		[Tooltip("Used for consoles only")]
		private List<GameObject> _shareShortcuts = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40036B2")]
		[SerializeField]
		private List<RectTransform> _updateLayout = (List<RectTransform>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40036B3")]
		[Header("Runtime")]
		public PhotoMenuTabs _currentTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40036B4")]
		[ShowNonSerializedField]
		private bool _isUIHidden;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40036B5")]
		private string _currentPicturePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40036B6")]
		private MenuStack _menuStack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40036B7")]
		private QRPrompt _qrPrompt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40036B8")]
		private bool _shareAfterSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40036B9")]
		private PhotoModeType _defaultTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40036BA")]
		private BaseUiRoot.Scope rewardMenuBlocker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40036BB")]
		private InputAction inputActionStandCrouch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40036BC")]
		private InputAction inputActionShowHideUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40036BD")]
		private InputAction inputActionChangeImageFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40036BE")]
		private InputAction inputActionChangeCameraMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40036BF")]
		private InputAction inputActionCapture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40036C0")]
		private InputAction inputActionSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40036C1")]
		private InputAction inputActionSaveAndShare;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40036C2")]
		private InputAction inputActionShareController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40036C3")]
		private InputAction inputActionLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40036C4")]
		private bool _enableAnyKeyToShowUI;

		[Cpp2IlInjected.Token(Token = "0x170007F9")]
		public static string _urlDownloadPicture
		{
			[Cpp2IlInjected.Token(Token = "0x6003A08")]
			[Cpp2IlInjected.Address(RVA = "0x9C7400", Offset = "0x9C5E00", VA = "0x1809C7400")]
			[CompilerGenerated]
			get
			{
				return _003C_urlDownloadPicture_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003A09")]
			[Cpp2IlInjected.Address(RVA = "0x9C74D0", Offset = "0x9C5ED0", VA = "0x1809C74D0")]
			[CompilerGenerated]
			set
			{
				PHOTO_TIMESTAMP_FORMAT = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007FA")]
		public static PhotoMenu Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6003A0A")]
			[Cpp2IlInjected.Address(RVA = "0x9C7330", Offset = "0x9C5D30", VA = "0x1809C7330")]
			[CompilerGenerated]
			get
			{
				return _003CInstance_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003A0B")]
			[Cpp2IlInjected.Address(RVA = "0x9C7460", Offset = "0x9C5E60", VA = "0x1809C7460")]
			[CompilerGenerated]
			private set
			{
				PHOTO_TIMESTAMP_FORMAT = (string)(object)value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007FB")]
		public bool IsUIHidden
		{
			[Cpp2IlInjected.Token(Token = "0x6003A0C")]
			[Cpp2IlInjected.Address(RVA = "0x9C7390", Offset = "0x9C5D90", VA = "0x1809C7390")]
			get
			{
				return _isUIHidden;
			}
			[Cpp2IlInjected.Token(Token = "0x6003A0D")]
			[Cpp2IlInjected.Address(RVA = "0x9C4090", Offset = "0x9C2A90", VA = "0x1809C4090")]
			private set
			{
				//IL_0015: Expected F4, but got I4
				_isUIHidden = value;
				int num = 0;
				Invoke("UpdateUI", num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007FC")]
		private bool ShouldBlockShortcuts
		{
			[Cpp2IlInjected.Token(Token = "0x6003A0E")]
			[Cpp2IlInjected.Address(RVA = "0x9C73A0", Offset = "0x9C5DA0", VA = "0x1809C73A0")]
			get
			{
				//Discarded unreachable code: IL_002e
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int ignoreThrobber = 0;
				if (instance.IsOnTop(this, (byte)ignoreThrobber != 0))
				{
					PhotoView photoView = _photoView;
					if (!photoView.isTakingPicture)
					{
						return photoView.isChangingEffect;
					}
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A0F")]
		[Cpp2IlInjected.Address(RVA = "0x9C3810", Offset = "0x9C2210", VA = "0x1809C3810")]
		private void Awake()
		{
			//IL_0012: Expected O, but got I4
			//IL_0033: Expected O, but got I4
			//IL_0055: Expected O, but got I4
			//IL_0077: Expected O, but got I4
			//IL_0099: Expected O, but got I4
			//IL_00bb: Expected O, but got I4
			//IL_00dd: Expected O, but got I4
			//IL_00ff: Expected O, but got I4
			//IL_0121: Expected O, but got I4
			InputTriggerPressed trigger = new InputTriggerPressed();
			int num = default(int);
			InputActionBool inputActionBool = new InputActionBool("PhotoMode_StandCrouch", trigger, (InputProvider)num);
			int num2 = 0;
			num = 0;
			inputActionStandCrouch = inputActionBool;
			InputTriggerPressed trigger2 = new InputTriggerPressed();
			int num3 = default(int);
			InputActionBool inputActionBool2 = new InputActionBool("PhotoMode_ShowHideUI", trigger2, (InputProvider)num3);
			num3 = 0;
			inputActionShowHideUI = inputActionBool2;
			InputTriggerPressed trigger3 = new InputTriggerPressed();
			int num4 = default(int);
			InputActionBool inputActionBool3 = new InputActionBool("PhotoMode_ImageFormat", trigger3, (InputProvider)num4);
			num4 = 0;
			inputActionChangeImageFormat = inputActionBool3;
			InputTriggerPressed trigger4 = new InputTriggerPressed();
			int num5 = default(int);
			InputActionBool inputActionBool4 = new InputActionBool("PhotoMode_CameraMode", trigger4, (InputProvider)num5);
			num5 = 0;
			inputActionChangeCameraMode = inputActionBool4;
			InputTriggerPressed trigger5 = new InputTriggerPressed();
			int num6 = default(int);
			InputActionBool inputActionBool5 = new InputActionBool("PhotoMode_Capture", trigger5, (InputProvider)num6);
			num6 = 0;
			inputActionCapture = inputActionBool5;
			InputTriggerPressed trigger6 = new InputTriggerPressed();
			int num7 = default(int);
			InputActionBool inputActionBool6 = new InputActionBool("PhotoMode_Save", trigger6, (InputProvider)num7);
			num7 = 0;
			inputActionSave = inputActionBool6;
			InputTriggerPressed trigger7 = new InputTriggerPressed();
			int num8 = default(int);
			InputActionBool inputActionBool7 = new InputActionBool("PhotoMode_SaveAndShare", trigger7, (InputProvider)num8);
			num8 = 0;
			inputActionSaveAndShare = inputActionBool7;
			InputTriggerPressed trigger8 = new InputTriggerPressed();
			int num9 = default(int);
			InputActionBool inputActionBool8 = new InputActionBool("[ X ]", trigger8, (InputProvider)num9);
			num9 = 0;
			inputActionShareController = inputActionBool8;
			InputTriggerPressed trigger9 = new InputTriggerPressed();
			int num10 = default(int);
			InputActionBool inputActionBool9 = new InputActionBool("[LT]", trigger9, (InputProvider)num10);
			num10 = 0;
			inputActionLT = inputActionBool9;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A10")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B40", Offset = "0x9C4540", VA = "0x1809C5B40")]
		private unsafe void Start()
		{
			Button.ButtonClickedEvent onClick = _closeButton.m_OnClick;
			UnityAction call = new UnityAction(this, (IntPtr)__ldftn(PhotoMenu.Close));
			onClick.AddListener(call);
			TabsContainer modeTabs = _modeTabs;
			TabsContainer.TabSelected value = ChangeMode;
			modeTabs.OnTabSelected += value;
			PhotoView photoView = _photoView;
			PhotoView.PictureTaken b = ShowConfirmationPrompt;
			PhotoView.PictureTaken onPictureTakenAction = photoView.OnPictureTakenAction;
			Delegate @delegate = Delegate.Combine(onPictureTakenAction, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onPictureTakenAction)
				{
				}
				PHOTO_TIMESTAMP_FORMAT = (string)(object)this;
				_currentPicturePath = "";
				_slidingObjects.Open();
				int num = 0;
				QRPrompt qRPrompt = (_qrPrompt = UiRoot.Instance.shareQRPrefab);
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A11")]
		[Cpp2IlInjected.Address(RVA = "0x9C4B60", Offset = "0x9C3560", VA = "0x1809C4B60", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0035
			base.OnPush(stack, param);
			BaseUiRoot.Scope scope = (rewardMenuBlocker = BaseUiRoot.Instance.RewardAnimationBlocker());
			_menuStack = stack;
			if (param != null)
			{
				int num = 0;
				if (param != null)
				{
					int num2 = 0;
					_param = (PhotoMenuParam)param;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A12")]
		[Cpp2IlInjected.Address(RVA = "0x9C48F0", Offset = "0x9C32F0", VA = "0x1809C48F0", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_0020
			base.OnPop();
			if (_vfxFireworks.activeSelf)
			{
				UnityEngine.Object.Destroy(_vfxFireworks);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A13")]
		[Cpp2IlInjected.Address(RVA = "0x9C41D0", Offset = "0x9C2BD0", VA = "0x1809C41D0", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_02db
			//IL_00c7: Expected O, but got I4
			PlayerAvatar avatar;
			OrbitCameraTarget selfieCameraTarget;
			PhotoViewAdditionalParameters photoViewAdditionalParameters;
			PhotoMenuParam param5;
			while (true)
			{
				base.OnFocusIn();
				UpdateUI();
				if (!_photoView.gameObject.activeInHierarchy)
				{
					_photoView.gameObject.SetActive(value: true);
					_photoView.ResetState();
				}
				PhotoMenuParam param = _param;
				if (param != null)
				{
					TabsContainer modeTabs = _modeTabs;
					PhotoModeType photoModeType = (_defaultTab = param.PhotoMode);
					PhotoModeType photoModeType2 = (PhotoModeType)(modeTabs.initialIndex = (int)param.PhotoMode);
					_modeTabs.Init();
					GameObject gameObject = _modeTabs.gameObject;
					bool active = !_param.IsInCharacterUnlockFlow;
					gameObject.SetActive(active);
					PhotoMenuParam param2 = _param;
					if (param2.IsInCharacterUnlockFlow)
					{
						MapCameraTransform positions = param2.Positions;
						int num = 0;
						if (positions != (UnityEngine.Object)num && (bool)_param.Positions._wishingWellPos)
						{
							_vfxFireworks.SetActive(value: true);
							Transform transform = _vfxFireworks.transform;
							Transform transform2 = (transform.parentInternal = _param.Positions._wishingWellPos);
							Transform transform3 = _vfxFireworks.transform;
							float z = UnityEngine.Vector3.zero.z;
							Transform transform4 = _vfxFireworks.transform;
							float z2 = UnityEngine.Vector3.one.z;
							Transform transform5 = _vfxFireworks.transform;
							float z3 = UnityEngine.Vector3.zero.z;
						}
					}
				}
				SystemRoot.Instance.GetSystem<PlayerNavigation>().PauseSystem();
				SystemRoot systemRoot = SystemRoot.Instance;
				PhotoMenuParam param3 = _param;
				avatar = systemRoot._avatar;
				if (param3 != null && param3.IsInCharacterUnlockFlow)
				{
					AvatarAppearance appearance = avatar.appearance;
				}
				selfieCameraTarget = avatar.appearance.selfieCameraTarget;
				photoViewAdditionalParameters = new PhotoViewAdditionalParameters();
				PhotoMenuParam param4 = _param;
				if (param4 != null)
				{
					bool flag = (photoViewAdditionalParameters.isInCrouchMode = param4.IsAvatarCrouched);
					param5 = _param;
					if (param5 != null)
					{
						break;
					}
				}
			}
			bool flag2 = (photoViewAdditionalParameters.initFromAvatarRotation = param5.IsInCharacterUnlockFlow);
			PhotoMenuParam param6 = _param;
			Transform freeCamStartTransform = default(Transform);
			if (param6 != null)
			{
				freeCamStartTransform = param6.FreeCamStartTransform;
			}
			photoViewAdditionalParameters.freeCamStartTransform = freeCamStartTransform;
			PhotoView photoView = _photoView;
			PhotoModeType defaultTab = _defaultTab;
			CameraNavigationConfig cameraConfig = _cameraConfig;
			PlayerNavigationConfig playerConfig = _playerConfig;
			photoView.Init(avatar, playerConfig, cameraConfig, selfieCameraTarget, defaultTab, photoViewAdditionalParameters);
			PhotoView photoView2 = _photoView;
			int num2 = 0;
			GameObject gameObject2 = UiRoot.Instance._worldCanvas.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			int num3 = 0;
			GraphicSettings.IncreaseShadowQuality();
			PlayerAvatar avatar2 = photoView2._avatar;
			int num4 = 0;
			avatar2.ChangeMovementEnabled((byte)num4 != 0);
			photoView2._avatar.RelaxingBehaviour.ForceEndRelax();
			photoView2.gameObject.SetActive(value: true);
			photoView2.IsShown = true;
			photoView2.InitMode();
			photoView2.ResetState();
			base.IsDataUpToDate = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A14")]
		[Cpp2IlInjected.Address(RVA = "0x9C4E90", Offset = "0x9C3890", VA = "0x1809C4E90", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__62))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__62 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__62(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A15")]
		[Cpp2IlInjected.Address(RVA = "0x9C5770", Offset = "0x9C4170", VA = "0x1809C5770")]
		private void ShowConfirmationPrompt(Texture2D texture, Meta.Customization.Avatar avatar, bool isMale, IEnumerable<int> items, SendPictureMode sendPictureMode)
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A16")]
		[Cpp2IlInjected.Address(RVA = "0x9C5610", Offset = "0x9C4010", VA = "0x1809C5610")]
		[AsyncStateMachine(typeof(_003CShowConfirmationPromptAsync_003Ed__64))]
		private Task ShowConfirmationPromptAsync(Texture2D texture, Meta.Customization.Avatar avatar, bool isMale, IEnumerable<int> items, SendPictureMode sendPictureMode)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A17")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D00", Offset = "0x9C3700", VA = "0x1809C4D00")]
		[AsyncStateMachine(typeof(_003COnSendPictureTask_003Ed__65))]
		private Task<bool> OnSendPictureTask(Texture2D texture, Meta.Customization.Avatar avatar, bool isMale, IEnumerable<int> items, SendPictureMode sendPictureMode, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A18")]
		[Cpp2IlInjected.Address(RVA = "0x9C54B0", Offset = "0x9C3EB0", VA = "0x1809C54B0")]
		[AsyncStateMachine(typeof(_003CSendToPlayfab_003Ed__66))]
		private Task<bool> SendToPlayfab(Texture2D picture, Meta.Customization.Avatar avatar, bool isMale, IEnumerable<int> items, bool applyToEvent, [Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A19")]
		[Cpp2IlInjected.Address(RVA = "0x9C5050", Offset = "0x9C3A50", VA = "0x1809C5050")]
		private void SavePictureOnConsole(Texture2D picture)
		{
			string value = Convert.ToBase64String(picture.EncodeToPNG());
			PlayerPrefs.SetString("picture", value);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A1A")]
		[Cpp2IlInjected.Address(RVA = "0x9C50D0", Offset = "0x9C3AD0", VA = "0x1809C50D0")]
		private bool SavePicture(Texture2D picture)
		{
			//Discarded unreachable code: IL_00d6, IL_00dc, IL_00e2, IL_00e8, IL_00ee, IL_00f4
			//IL_005a: Expected O, but got I4
			//IL_00c4: Expected I4, but got I8
			int num = 0;
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int freezeRendering = 0;
			IDisposable disposable = instance.ShowThrobber("SavePicture", showLogo: true, (byte)freezeRendering != 0);
			byte[] array = picture.EncodeToJPG();
			int num3 = 0;
			DateTime now = DateTime.Now;
			CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("en-US");
			string text = default(string);
			string filename = text + ".jpg";
			int num4 = 0;
			int num5 = (int)NativeGallery.SaveImageToGallery(array, "Disney Dreamlight Valley", filename, (NativeGallery.MediaSaveCallback)num4);
			IFileSystem _003CSave_003Ek__BackingField = FileSystem.Save;
			string currentPicturePath = default(string);
			_currentPicturePath = currentPicturePath;
			if (!File.Exists(_currentPicturePath))
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory(Path.GetDirectoryName(_currentPicturePath));
				File.WriteAllBytes(_currentPicturePath, array);
			}
			if (num5 != 1)
			{
				int num6 = 0;
				GenericAlert genericAlert = UiRoot.Instance._genericAlert;
				int showCloseButton = 0;
				ulong num7 = default(ulong);
				genericAlert.Alert("menu.save_picture_premission_denied", "", (byte)showCloseButton != 0, (byte)num7 != 0);
			}
			_photoView.ResetState();
			if (disposable != null)
			{
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A1B")]
		[Cpp2IlInjected.Address(RVA = "0x9C5450", Offset = "0x9C3E50", VA = "0x1809C5450")]
		private void SendEvent(SavedPhoto savedPhoto, string animationType, string animationName, string pictureState, List<Item> avatarItem, Dictionary<string, int> appearanceConfig)
		{
			savedPhoto.photoInfo.animationType = animationType;
			savedPhoto.photoInfo.animationName = animationName;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A1C")]
		[Cpp2IlInjected.Address(RVA = "0x9C3CA0", Offset = "0x9C26A0", VA = "0x1809C3CA0")]
		private void ChangeMode(int tabIndex)
		{
			//Discarded unreachable code: IL_0024
			PhotoView photoView = _photoView;
			if (photoView._mode != (PhotoModeType)tabIndex)
			{
				photoView.ResetPose();
				photoView._mode = (PhotoModeType)tabIndex;
				photoView.InitMode();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A1D")]
		[Cpp2IlInjected.Address(RVA = "0x9C6800", Offset = "0x9C5200", VA = "0x1809C6800")]
		private void Update()
		{
			//IL_036b: Expected I4, but got I8
			//IL_0375: Expected I4, but got I8
			//IL_037f: Expected I4, but got I8
			InputAction inputAction10 = default(InputAction);
			while (true)
			{
				PhotoView photoView = _photoView;
				if (photoView.IsShown)
				{
					int num = 0;
					float deltaTime = Time.deltaTime;
					PhotoMenuParam param = _param;
					if (param == null || param.IsInCharacterUnlockFlow)
					{
					}
					bool dontMoveNpcs = (long)"{il2cpp field on {'constant19' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x40}" == 5;
					photoView.UpdateState(deltaTime, dontMoveNpcs);
				}
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				int ignoreThrobber = 0;
				if (!instance.IsOnTop(this, (byte)ignoreThrobber != 0))
				{
					return;
				}
				PhotoView photoView2 = _photoView;
				if (photoView2.isTakingPicture || photoView2.isChangingEffect)
				{
					return;
				}
				int num3 = 0;
				float deltaTime2 = Time.deltaTime;
				InputAction[] array = new InputAction[9];
				InputAction inputAction = inputActionStandCrouch;
				if (inputAction != null && array == null)
				{
					continue;
				}
				array[0] = inputAction;
				InputAction inputAction2 = inputActionShowHideUI;
				if (inputAction2 != null && array == null)
				{
					continue;
				}
				array[1] = inputAction2;
				InputAction inputAction3 = inputActionChangeImageFormat;
				if (inputAction3 != null && array == null)
				{
					continue;
				}
				array[2] = inputAction3;
				InputAction inputAction4 = inputActionChangeCameraMode;
				if (inputAction4 != null && array == null)
				{
					continue;
				}
				array[3] = inputAction4;
				InputAction inputAction5 = inputActionCapture;
				if (inputAction5 != null && array == null)
				{
					continue;
				}
				array[4] = inputAction5;
				InputAction inputAction6 = inputActionSave;
				if (inputAction6 != null && array == null)
				{
					continue;
				}
				array[5] = inputAction6;
				InputAction inputAction7 = inputActionSaveAndShare;
				if (inputAction7 != null && array == null)
				{
					continue;
				}
				array[6] = inputAction7;
				InputAction inputAction8 = inputActionShareController;
				if (inputAction8 != null && array == null)
				{
					continue;
				}
				array[7] = inputAction8;
				InputAction inputAction9 = inputActionLT;
				if (inputAction9 != null && array == null)
				{
					continue;
				}
				array[8] = inputAction9;
				InputAction.UpdateAll(deltaTime2, array);
				PhotoView photoView3 = _photoView;
				if (photoView3.isPictureTaken)
				{
					break;
				}
				if (photoView3._mode == PhotoModeType.Free)
				{
					FocusNavigation focusNavigation = base.FocusNavigation;
					bool flag = (focusNavigation.IsPaused = inputActionLT.IsActuated());
					if (inputActionLT.IsTriggered)
					{
						_enableAnyKeyToShowUI = false;
					}
				}
				if (inputActionStandCrouch.IsTriggered && _photoView._mode == PhotoModeType.Selfie)
				{
					int num4 = 0;
					UiRoot instance2 = UiRoot.Instance;
					int ignoreThrobber2 = 0;
					if (instance2.IsOnTop(this, (byte)ignoreThrobber2 != 0))
					{
						PhotoView photoView4 = _photoView;
						if (!photoView4.isTakingPicture && !photoView4.isChangingEffect && !photoView4.isPictureTaken)
						{
							_enableAnyKeyToShowUI = false;
							if (!photoView4._isInCrouchAnimation)
							{
								AK.Wwise.Event toggleCrouchSfx = photoView4._toggleCrouchSfx;
								if (toggleCrouchSfx != null)
								{
									GameObject gameObject = photoView4.gameObject;
									uint num5 = toggleCrouchSfx.Post(gameObject);
								}
								bool flag2 = (photoView4.IsInCrouchMode = !photoView4.IsInCrouchMode);
								if (photoView4._mode == PhotoModeType.Selfie)
								{
									photoView4.UpdateCrouchMode();
								}
							}
						}
					}
				}
				PhotoView photoView5;
				if (inputActionChangeImageFormat.IsTriggered)
				{
					int num6 = 0;
					UiRoot instance3 = UiRoot.Instance;
					int ignoreThrobber3 = 0;
					if (instance3.IsOnTop(this, (byte)ignoreThrobber3 != 0))
					{
						photoView5 = _photoView;
						if (!photoView5.isTakingPicture && !photoView5.isChangingEffect && !photoView5.isPictureTaken)
						{
							_enableAnyKeyToShowUI = false;
							AK.Wwise.Event toggleFormatSfx = photoView5._toggleFormatSfx;
							if (toggleFormatSfx != null)
							{
								GameObject gameObject2 = photoView5.gameObject;
								uint num7 = toggleFormatSfx.Post(gameObject2);
							}
							PhotoModeImageFormat imageFormat = photoView5.imageFormat;
							if (imageFormat != 0)
							{
								if (imageFormat != PhotoModeImageFormat.Landscape)
								{
									if (imageFormat != PhotoModeImageFormat.Portrait)
									{
										goto IL_037f;
									}
									photoView5.imageFormat = PhotoModeImageFormat.Square;
								}
								photoView5.imageFormat = PhotoModeImageFormat.Portrait;
							}
							photoView5.imageFormat = PhotoModeImageFormat.Landscape;
							goto IL_037f;
						}
					}
				}
				goto IL_039d;
				IL_039d:
				if (inputActionChangeCameraMode.IsTriggered)
				{
					ActionCameraMode();
				}
				if (inputActionCapture.IsTriggered)
				{
					ActionCapture();
				}
				inputAction10 = inputActionShowHideUI;
				if (inputAction10.IsTriggered)
				{
					ActionShowHideUI();
				}
				return;
				IL_037f:
				photoView5.ShowFrame();
				int currentFrame = photoView5.photoFrameEffect.currentFrame;
				photoView5.ChangeFrame(currentFrame);
				goto IL_039d;
			}
			if (inputAction10.IsTriggered)
			{
			}
			Task task = default(Task);
			if (inputAction10.IsTriggered || inputAction10.IsTriggered)
			{
				int num8 = 0;
				UiRoot instance4 = UiRoot.Instance;
				bool flag3 = default(bool);
				if (flag3)
				{
					if ((long)instance4._genericAlert == 0)
					{
						int num9 = 0;
					}
					int num10 = 0;
					if (!PlatformUtils.IsPlaystation())
					{
						task.FireAndForgetTask();
					}
				}
			}
			while ((long)task.m_continuationObject == 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A1E")]
		[Cpp2IlInjected.Address(RVA = "0x9C40F0", Offset = "0x9C2AF0", VA = "0x1809C40F0")]
		private void LateUpdate()
		{
			if (_enableAnyKeyToShowUI && _isUIHidden)
			{
				int num = 0;
				if (Input.anyKeyDown)
				{
					ActionShowHideUI();
				}
			}
			_enableAnyKeyToShowUI = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A1F")]
		[Cpp2IlInjected.Address(RVA = "0x9C3330", Offset = "0x9C1D30", VA = "0x1809C3330")]
		public void ActionCapture()
		{
			//Discarded unreachable code: IL_0046
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int ignoreThrobber = 0;
			if (instance.IsOnTop(this, (byte)ignoreThrobber != 0))
			{
				PhotoView photoView = _photoView;
				if (!photoView.isTakingPicture && !photoView.isChangingEffect && !photoView.isPictureTaken)
				{
					_enableAnyKeyToShowUI = false;
					photoView.TakePicture();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A20")]
		[Cpp2IlInjected.Address(RVA = "0x9C35A0", Offset = "0x9C1FA0", VA = "0x1809C35A0")]
		public void ActionSave()
		{
			//Discarded unreachable code: IL_0056
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int ignoreThrobber = 0;
			if (instance.IsOnTop(this, (byte)ignoreThrobber != 0))
			{
				PhotoView photoView = _photoView;
				if (!photoView.isTakingPicture && !photoView.isChangingEffect && photoView.isPictureTaken && !photoView.saved)
				{
					_enableAnyKeyToShowUI = false;
					_shareAfterSave = false;
					photoView.ConfirmPicture();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A21")]
		[Cpp2IlInjected.Address(RVA = "0x9C31B0", Offset = "0x9C1BB0", VA = "0x1809C31B0")]
		public void ActionCameraMode()
		{
			//Discarded unreachable code: IL_00f6
			//IL_009c: Expected I4, but got I8
			//IL_00ca: Expected I4, but got I8
			//IL_00d9: Expected I4, but got I8
			//IL_00f5: Expected F4, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int ignoreThrobber = 0;
			if (!instance.IsOnTop(this, (byte)ignoreThrobber != 0))
			{
				return;
			}
			PhotoView photoView = _photoView;
			if (photoView.isTakingPicture || photoView.isChangingEffect || photoView.isPictureTaken)
			{
				return;
			}
			_enableAnyKeyToShowUI = false;
			if (!photoView._isInFovAnimation)
			{
				AK.Wwise.Event toggleModeSfx = photoView._toggleModeSfx;
				if (toggleModeSfx != null)
				{
					GameObject gameObject = photoView.gameObject;
					uint num2 = toggleModeSfx.Post(gameObject);
				}
				PhotoModeType mode = photoView._mode;
				if (mode != 0)
				{
					if (mode != PhotoModeType.Avatar)
					{
						if (mode != PhotoModeType.Free)
						{
							goto IL_00df;
						}
						photoView.ResetPose();
						photoView._mode = PhotoModeType.Selfie;
					}
					bool flag = photoView.EnvironmentAllowsFreeCamera();
					PhotoModeType mode2 = photoView._mode;
					if ((!flag && mode2 == PhotoModeType.Selfie) || mode2 == PhotoModeType.Free)
					{
						goto IL_00df;
					}
					photoView.ResetPose();
					photoView._mode = PhotoModeType.Free;
				}
				photoView.ResetPose();
				photoView._mode = PhotoModeType.Avatar;
				photoView.InitMode();
			}
			goto IL_00df;
			IL_00df:
			photoView.ResetModeTab();
			int num3 = 0;
			Invoke("UpdateUI", num3);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A22")]
		[Cpp2IlInjected.Address(RVA = "0x9C33A0", Offset = "0x9C1DA0", VA = "0x1809C33A0")]
		public void ActionImageFormat()
		{
			//Discarded unreachable code: IL_00b8
			//IL_008a: Expected I4, but got I8
			//IL_0093: Expected I4, but got I8
			//IL_009c: Expected I4, but got I8
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int ignoreThrobber = 0;
			if (!instance.IsOnTop(this, (byte)ignoreThrobber != 0))
			{
				return;
			}
			PhotoView photoView = _photoView;
			if (photoView.isTakingPicture || photoView.isChangingEffect || photoView.isPictureTaken)
			{
				return;
			}
			_enableAnyKeyToShowUI = false;
			AK.Wwise.Event toggleFormatSfx = photoView._toggleFormatSfx;
			if (toggleFormatSfx != null)
			{
				GameObject gameObject = photoView.gameObject;
				uint num2 = toggleFormatSfx.Post(gameObject);
			}
			PhotoModeImageFormat imageFormat = photoView.imageFormat;
			if (imageFormat != 0)
			{
				if (imageFormat != PhotoModeImageFormat.Landscape)
				{
					if (imageFormat != PhotoModeImageFormat.Portrait)
					{
						goto IL_009c;
					}
					photoView.imageFormat = PhotoModeImageFormat.Square;
				}
				photoView.imageFormat = PhotoModeImageFormat.Portrait;
			}
			photoView.imageFormat = PhotoModeImageFormat.Landscape;
			goto IL_009c;
			IL_009c:
			photoView.ShowFrame();
			int currentFrame = photoView.photoFrameEffect.currentFrame;
			photoView.ChangeFrame(currentFrame);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A23")]
		[Cpp2IlInjected.Address(RVA = "0x9C3620", Offset = "0x9C2020", VA = "0x1809C3620")]
		public void ActionShowHideUI()
		{
			//Discarded unreachable code: IL_0073
			//IL_0072: Expected F4, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int ignoreThrobber = 0;
			if (instance.IsOnTop(this, (byte)ignoreThrobber != 0))
			{
				PhotoView photoView = _photoView;
				if (!photoView.isTakingPicture && !photoView.isChangingEffect)
				{
					_enableAnyKeyToShowUI = false;
					GameObject in_gameObjectID = base.gameObject;
					uint num2 = AkSoundEngine.PostEvent("sfx_ui_select", in_gameObjectID);
					bool isUIHidden = _isUIHidden;
					int num3 = 0;
					bool flag = (_isUIHidden = !isUIHidden);
					Invoke("UpdateUI", num3);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A24")]
		[Cpp2IlInjected.Address(RVA = "0x9C34A0", Offset = "0x9C1EA0", VA = "0x1809C34A0")]
		public void ActionSaveAndShare()
		{
			//Discarded unreachable code: IL_0081
			do
			{
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int ignoreThrobber = 0;
				if (instance.IsOnTop(this, (byte)ignoreThrobber != 0))
				{
					PhotoView photoView = _photoView;
					if (!photoView.isTakingPicture && !photoView.isChangingEffect && photoView.isPictureTaken)
					{
						_shareAfterSave = true;
						_enableAnyKeyToShowUI = false;
						if (!photoView.saved)
						{
							photoView.ConfirmPicture();
							return;
						}
						int num2 = 0;
						continue;
					}
					return;
				}
				return;
			}
			while (PlatformUtils.IsPlaystation());
			QRPrompt qrPrompt = _qrPrompt;
			string currentPicturePath = _currentPicturePath;
			qrPrompt.UploadAsync(currentPicturePath, fromPhotoMenu: true).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A25")]
		[Cpp2IlInjected.Address(RVA = "0x9C3750", Offset = "0x9C2150", VA = "0x1809C3750")]
		public void ActionStandCrouch()
		{
			//Discarded unreachable code: IL_008d
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int ignoreThrobber = 0;
			if (!instance.IsOnTop(this, (byte)ignoreThrobber != 0))
			{
				return;
			}
			PhotoView photoView = _photoView;
			if (photoView.isTakingPicture || photoView.isChangingEffect || photoView.isPictureTaken)
			{
				return;
			}
			_enableAnyKeyToShowUI = false;
			if (!photoView._isInCrouchAnimation)
			{
				AK.Wwise.Event toggleCrouchSfx = photoView._toggleCrouchSfx;
				if (toggleCrouchSfx != null)
				{
					GameObject gameObject = photoView.gameObject;
					uint num2 = toggleCrouchSfx.Post(gameObject);
				}
				bool flag = (photoView.IsInCrouchMode = !photoView.IsInCrouchMode);
				if (photoView._mode == PhotoModeType.Selfie)
				{
					photoView.UpdateCrouchMode();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A26")]
		[Cpp2IlInjected.Address(RVA = "0x9C3CF0", Offset = "0x9C26F0", VA = "0x1809C3CF0")]
		public void Close(bool force = false)
		{
			//Discarded unreachable code: IL_0013
			_photoView.Hide();
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A27")]
		[Cpp2IlInjected.Address(RVA = "0x9C3CF0", Offset = "0x9C26F0", VA = "0x1809C3CF0")]
		public void Close()
		{
			//Discarded unreachable code: IL_0013
			_photoView.Hide();
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A28")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D30", Offset = "0x9C2730", VA = "0x1809C3D30")]
		public void ForceCloseMenu()
		{
			//IL_000f: Expected O, but got I4
			int num = 0;
			HandleRedirection(RedirectionType.MenuNavGoBackward, (MenuParam)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A29")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D40", Offset = "0x9C2740", VA = "0x1809C3D40", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_00b9, IL_00ba
			if (redirectionType > RedirectionType.MenuNavGoForward)
			{
				if (redirectionType != RedirectionType.GamePopCurrentMenu)
				{
					if (redirectionType == RedirectionType.GameTabLeft)
					{
						OnPreviousTab();
						return;
					}
					while (redirectionType != RedirectionType.GameTabRight)
					{
					}
					while (_isUIHidden)
					{
					}
					PhotoMenuTabs currentTab = _currentTab;
					PhotoMenuTab photoMenuTab = default(PhotoMenuTab);
					if (currentTab != 0)
					{
						if (currentTab != 0)
						{
							while (currentTab != PhotoMenuTabs.Emoji)
							{
							}
							photoMenuTab = _photoMenuTab;
							photoMenuTab.OnFramePressed();
						}
						else
						{
							photoMenuTab.OnFilterPressed();
						}
					}
					else
					{
						photoMenuTab.OnEmojiPressed();
					}
					return;
				}
			}
			else if (redirectionType != RedirectionType.MenuNavGoBackward)
			{
				while (redirectionType != RedirectionType.MenuNavGoForward)
				{
				}
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				bool flag = default(bool);
				while (!flag)
				{
				}
				return;
			}
			while (_isUIHidden)
			{
			}
			PhotoView photoView = _photoView;
			bool isPictureTaken = photoView.isPictureTaken;
			if (isPictureTaken)
			{
				return;
			}
			Task task = default(Task);
			if (photoView.saved == isPictureTaken)
			{
				int num2 = 0;
				task.FireAndForgetTask();
			}
			else
			{
				while (task == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A2A")]
		[Cpp2IlInjected.Address(RVA = "0x9C5920", Offset = "0x9C4320", VA = "0x1809C5920")]
		[AsyncStateMachine(typeof(_003CShowSaveFailed_003Ed__84))]
		public Task ShowSaveFailed([Optional] CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A2B")]
		[Cpp2IlInjected.Address(RVA = "0x9C5A20", Offset = "0x9C4420", VA = "0x1809C5A20")]
		[AsyncStateMachine(typeof(_003CShowSavePicturePopup_003Ed__85))]
		public Task ShowSavePicturePopup([Optional] CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A2C")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F10", Offset = "0x9C3910", VA = "0x1809C4F10")]
		public void ProceedToRetake()
		{
			//Discarded unreachable code: IL_000c
			_photoView.ResetState();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A2D")]
		[Cpp2IlInjected.Address(RVA = "0x9C4170", Offset = "0x9C2B70", VA = "0x1809C4170", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_002c
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				_photoMenuTab.resetFocus();
			}
			UpdateUI();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A2E")]
		[Cpp2IlInjected.Address(RVA = "0x9C4090", Offset = "0x9C2A90", VA = "0x1809C4090")]
		public void HideUIForPhoto(bool hide)
		{
			//IL_0015: Expected F4, but got I4
			_isUIHidden = hide;
			int num = 0;
			Invoke("UpdateUI", num);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A2F")]
		[Cpp2IlInjected.Address(RVA = "0x9C6010", Offset = "0x9C4A10", VA = "0x1809C6010")]
		public void UpdateUI()
		{
			//Discarded unreachable code: IL_01ac, IL_01b2, IL_01b8, IL_01be, IL_01c4, IL_01ca
			//IL_01ab: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			PhotoView photoView = _photoView;
			bool isPictureTaken = photoView.isPictureTaken;
			PhotoModeType mode = photoView._mode;
			int num4 = 0;
			bool flag = InputDetectionHelper.IsConsole();
			int num5 = 0;
			bool flag2 = PlatformUtils.IsPlaystation();
			_shortcutsHolder.SetActive(value: true);
			GameObject gameObject = _photoMenuTab.gameObject;
			if ((_isUIHidden ? 1 : 0) != num3)
			{
			}
			bool active = !isPictureTaken;
			gameObject.SetActive(active);
			GameObject gameObject2 = _modeTabs.gameObject;
			if ((_isUIHidden ? 1 : 0) != num3)
			{
			}
			bool active2 = !isPictureTaken;
			gameObject2.SetActive(active2);
			_cameraControlShortcuts.SetActive(active2);
			_cameraControlGamepadShortcuts.SetActive(active2);
			GameObject backShortcut = _backShortcut;
			bool active3 = (_isUIHidden ? 1 : 0) == num3;
			backShortcut.SetActive(active3);
			GameObject backGamepadShortcut = _backGamepadShortcut;
			bool active4 = (_isUIHidden ? 1 : 0) == num3;
			backGamepadShortcut.SetActive(active4);
			GameObject crouchShortcut = _crouchShortcut;
			if ((_isUIHidden ? 1 : 0) != num3)
			{
			}
			bool active5 = !isPictureTaken;
			crouchShortcut.SetActive(active5);
			GameObject crouchGamepadShortcut = _crouchGamepadShortcut;
			if ((_isUIHidden ? 1 : 0) != num3)
			{
			}
			bool active6 = !isPictureTaken;
			crouchGamepadShortcut.SetActive(active6);
			GameObject gameObject3 = _photoView.modeTabsContainer.gameObject;
			if ((_isUIHidden ? 1 : 0) != num3)
			{
			}
			bool active7 = !isPictureTaken;
			gameObject3.SetActive(active7);
			List<GameObject> photoModeShortcuts = _photoModeShortcuts;
			bool flag3 = default(bool);
			if (flag3)
			{
				if (_isUIHidden)
				{
				}
				bool flag4 = !isPictureTaken;
			}
			bool flag5 = default(bool);
			if (flag5)
			{
				bool flag6 = !isPictureTaken;
			}
			bool flag7 = default(bool);
			if (flag7)
			{
				bool flag8 = (long)"{il2cpp field on {'constant70' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StackPointer)}, offset 0x19C}" == 0;
			}
			bool flag9 = default(bool);
			if (flag9)
			{
				bool flag10 = (long)"{il2cpp field on {'constant86' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StackPointer)}, offset 0x19C}" == 0;
			}
			bool flag11 = default(bool);
			if (flag11)
			{
				int num6 = 0;
			}
			bool flag12 = default(bool);
			if (flag12)
			{
			}
			bool flag13 = default(bool);
			if (flag13)
			{
				LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A30")]
		[Cpp2IlInjected.Address(RVA = "0x9C3BD0", Offset = "0x9C25D0", VA = "0x1809C3BD0")]
		[AsyncStateMachine(typeof(_003CCameraFade_003Ed__90))]
		private Task CameraFade()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A31")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F40", Offset = "0x9C3940", VA = "0x1809C4F40", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_0036
			((object)this)._002Ector();
			PhotoView photoView = _photoView;
			PhotoView.OnRefreshHintDelegate b = UpdateUI;
			PhotoView.OnRefreshHintDelegate onRefreshHint = photoView.OnRefreshHint;
			Delegate @delegate = Delegate.Combine(onRefreshHint, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onRefreshHint)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A32")]
		[Cpp2IlInjected.Address(RVA = "0x9C5F00", Offset = "0x9C4900", VA = "0x1809C5F00", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_0036
			((object)this)._002Ector();
			PhotoView photoView = _photoView;
			PhotoView.OnRefreshHintDelegate value = UpdateUI;
			PhotoView.OnRefreshHintDelegate onRefreshHint = photoView.OnRefreshHint;
			Delegate @delegate = Delegate.Remove(onRefreshHint, value);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onRefreshHint)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A33")]
		[Cpp2IlInjected.Address(RVA = "0x9C4870", Offset = "0x9C3270", VA = "0x1809C4870")]
		private void OnNextTab()
		{
			//Discarded unreachable code: IL_003e
			if (_isUIHidden)
			{
				return;
			}
			PhotoMenuTabs currentTab = _currentTab;
			if (currentTab != 0)
			{
				switch (currentTab)
				{
				case PhotoMenuTabs.Emoji:
					_photoMenuTab.OnFramePressed();
					break;
				case PhotoMenuTabs.Pose:
				{
					PhotoMenuTab photoMenuTab = _photoMenuTab;
					photoMenuTab.OnFilterPressed();
					break;
				}
				}
			}
			else
			{
				PhotoMenuTab photoMenuTab = default(PhotoMenuTab);
				photoMenuTab.OnEmojiPressed();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A34")]
		[Cpp2IlInjected.Address(RVA = "0x9C4990", Offset = "0x9C3390", VA = "0x1809C4990")]
		private void OnPreviousTab()
		{
			//Discarded unreachable code: IL_0081
			//IL_005e: Expected I4, but got I8
			PhotoMenuTab photoMenuTab = default(PhotoMenuTab);
			UiRoot instance;
			int useKeyboardAsController;
			do
			{
				if (_isUIHidden)
				{
					return;
				}
				PhotoMenuTabs currentTab = _currentTab;
				if (_isUIHidden)
				{
					if (_isUIHidden)
					{
						if (_isUIHidden)
						{
							if (currentTab == PhotoMenuTabs.Emoji)
							{
								_photoMenuTab.OnFramePressed();
							}
						}
						else
						{
							photoMenuTab = _photoMenuTab;
							photoMenuTab.OnFilterPressed();
						}
					}
					else
					{
						photoMenuTab.OnEmojiPressed();
					}
					return;
				}
				Instance._currentTab = PhotoMenuTabs.Pose;
				int num = 0;
				instance = UiRoot.Instance;
				useKeyboardAsController = 0;
			}
			while (!instance.IsControllerConnected((byte)useKeyboardAsController != 0));
			int num2 = 0;
			Tab tab = default(Tab);
			FocusNavigationElement componentInChildren = tab.GetComponentInChildren<FocusNavigationElement>();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A35")]
		[Cpp2IlInjected.Address(RVA = "0x9C7170", Offset = "0x9C5B70", VA = "0x1809C7170")]
		public PhotoMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003A36")]
		[Cpp2IlInjected.Address(RVA = "0x9C7120", Offset = "0x9C5B20", VA = "0x1809C7120")]
		static PhotoMenu()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
