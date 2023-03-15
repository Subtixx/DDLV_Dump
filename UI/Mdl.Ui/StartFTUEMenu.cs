using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Mdl.Audio;
using Mdl.Avatar;
using Mdl.InputSystem;
using Mdl.Navigation;
using Mdl.Platform;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004C5")]
	public class StartFTUEMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400191A")]
		[SerializeField]
		private AvatarPresetPanel _avatarPresetPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400191B")]
		[SerializeField]
		private FTUEAppearencePanel _mcAppearencePanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400191C")]
		[SerializeField]
		private FTUENamePanel _mcNamePanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400191D")]
		[SerializeField]
		private RectTransform _mcWishPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400191E")]
		[SerializeField]
		private ButtonTmProIcon _btnWishNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400191F")]
		[SerializeField]
		private GameObject _shortcutIndicatorsHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001920")]
		[SerializeField]
		private GameObject _buttonHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001921")]
		[SerializeField]
		private NotificationButton _btnUndo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001922")]
		[SerializeField]
		private NotificationButton _btnUndoAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001923")]
		[SerializeField]
		private Image _highlightImageUndoAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001924")]
		[SerializeField]
		private AssetReference _importAvatarMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4001925")]
		protected InputAction inputActionUndoPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4001926")]
		protected InputAction inputActionUndoRelease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001927")]
		protected InputAction inputActionUndoAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001928")]
		private bool _justFiredPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4001929")]
		[SerializeField]
		private AK.Wwise.Event _undoSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400192A")]
		[SerializeField]
		private AK.Wwise.Event _sfxBack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400192B")]
		private AvatarAppearance _avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400192C")]
		private AvatarCustomization _avatarCustomization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400192D")]
		private int _currentFtuePanelIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400192E")]
		private List<IStartFTUEPanel> _ftuePanels = (List<IStartFTUEPanel>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x17000507")]
		public string PlayerName
		{
			[Cpp2IlInjected.Token(Token = "0x6001F2A")]
			[Cpp2IlInjected.Address(RVA = "0x85A6E0", Offset = "0x8590E0", VA = "0x18085A6E0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _mcNamePanel.InputName;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F2B")]
			[Cpp2IlInjected.Address(RVA = "0x85A710", Offset = "0x859110", VA = "0x18085A710")]
			set
			{
				//Discarded unreachable code: IL_000d
				_mcNamePanel.InputName = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000508")]
		private bool IsAnyFTUEPanelAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x6001F2C")]
			[Cpp2IlInjected.Address(RVA = "0x85A5B0", Offset = "0x858FB0", VA = "0x18085A5B0")]
			get
			{
				List<IStartFTUEPanel> ftuePanels = _ftuePanels;
				Func<IStartFTUEPanel, bool> _003C_003E9__25_ = _003C_003Ec._003C_003E9__25_0;
				if (_003C_003E9__25_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(IStartFTUEPanel x)
					{
						//Discarded unreachable code: IL_0015, IL_001c
						int num = 0;
						uint num2 = default(uint);
						if (num < (int)num2)
						{
							num += num;
							num++;
						}
						return x.IsInAnimation;
					};
				}
				return ((IEnumerable<>)ftuePanels).Any<IStartFTUEPanel>((Func<, >)(object)_003C_003E9__25_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F2D")]
		[Cpp2IlInjected.Address(RVA = "0x8587D0", Offset = "0x8571D0", VA = "0x1808587D0", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_0165
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _mcNamePanel.NextButton.ButtonComponent.m_OnClick;
			UnityAction call = delegate
			{
				int num = 0;
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			};
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _avatarPresetPanel.NextButton.ButtonComponent.m_OnClick;
			UnityAction call2 = OnNext;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = _avatarPresetPanel.ImportAvatarButton.ButtonComponent.m_OnClick;
			UnityAction call3 = OnAvatarImport;
			onClick3.AddListener(call3);
			Button.ButtonClickedEvent onClick4 = _mcNamePanel.BackButton.ButtonComponent.m_OnClick;
			UnityAction call4 = OnPrevious;
			onClick4.AddListener(call4);
			Button.ButtonClickedEvent onClick5 = _mcAppearencePanel.BackButton.ButtonComponent.m_OnClick;
			UnityAction call5 = OnPrevious;
			onClick5.AddListener(call5);
			Button.ButtonClickedEvent onClick6 = _mcAppearencePanel.NextButton.ButtonComponent.m_OnClick;
			UnityAction call6 = OnNext;
			onClick6.AddListener(call6);
			Button.ButtonClickedEvent onClick7 = _btnUndo.ButtonComponent.m_OnClick;
			UnityAction call7 = OnUndoClickHandler;
			onClick7.AddListener(call7);
			Button.ButtonClickedEvent onClick8 = _btnUndoAll.ButtonComponent.m_OnClick;
			UnityAction call8 = OnUndoAllClickHandler;
			onClick8.AddListener(call8);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F2E")]
		[Cpp2IlInjected.Address(RVA = "0x859850", Offset = "0x858250", VA = "0x180859850", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_010e
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _avatarPresetPanel.NextButton.ButtonComponent.m_OnClick;
			UnityAction call = OnNext;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _avatarPresetPanel.ImportAvatarButton.ButtonComponent.m_OnClick;
			UnityAction call2 = OnAvatarImport;
			onClick2.RemoveListener(call2);
			Button.ButtonClickedEvent onClick3 = _mcNamePanel.BackButton.ButtonComponent.m_OnClick;
			UnityAction call3 = OnPrevious;
			onClick3.RemoveListener(call3);
			Button.ButtonClickedEvent onClick4 = _mcAppearencePanel.BackButton.ButtonComponent.m_OnClick;
			UnityAction call4 = OnPrevious;
			onClick4.RemoveListener(call4);
			Button.ButtonClickedEvent onClick5 = _mcAppearencePanel.NextButton.ButtonComponent.m_OnClick;
			UnityAction call5 = OnNext;
			onClick5.RemoveListener(call5);
			Button.ButtonClickedEvent onClick6 = _btnUndoAll.ButtonComponent.m_OnClick;
			UnityAction call6 = OnUndoAllClickHandler;
			onClick6.RemoveListener(call6);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F2F")]
		[Cpp2IlInjected.Address(RVA = "0x857890", Offset = "0x856290", VA = "0x180857890", Slot = "27")]
		public override void OnFocusIn()
		{
			//IL_001f: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			//IL_0083: Expected O, but got I4
			//IL_009e: Expected O, but got I4
			base.OnFocusIn();
			SystemRoot.Instance.PauseSystem<PlayerNavigation>();
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num = 0;
			AvatarCustomization avatarCustomization = (_avatarCustomization = _003CInstance_003Ek__BackingField.StartSystem<AvatarCustomization>((ISystemData)num));
			_avatarPresetPanel.AvatarCustomization = avatarCustomization;
			_mcAppearencePanel.AvatarCustomization = avatarCustomization;
			AvatarCustomization.AvatarReady avatarReady = Init;
			InputTriggerPressed trigger = new InputTriggerPressed();
			int num2 = default(int);
			InputActionBool inputActionBool = new InputActionBool("AvatarCustomization_Undo", trigger, (InputProvider)num2);
			num2 = 0;
			inputActionUndoPress = inputActionBool;
			InputTriggerReleased trigger2 = new InputTriggerReleased();
			int num3 = default(int);
			InputActionBool inputActionBool2 = new InputActionBool("AvatarCustomization_Undo", trigger2, (InputProvider)num3);
			num3 = 0;
			inputActionUndoRelease = inputActionBool2;
			InputTriggerDownWithDelay trigger3 = default(InputTriggerDownWithDelay);
			int num4 = default(int);
			InputActionBool inputActionBool3 = new InputActionBool("AvatarCustomization_Undo", trigger3, (InputProvider)num4);
			num4 = 0;
			inputActionUndoAll = inputActionBool3;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F30")]
		[Cpp2IlInjected.Address(RVA = "0x857F90", Offset = "0x856990", VA = "0x180857F90", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_009f
			//IL_0010: Expected I4, but got I8
			List<IStartFTUEPanel> ftuePanels = _ftuePanels;
			_currentFtuePanelIndex = 0;
			AvatarPresetPanel avatarPresetPanel = _avatarPresetPanel;
			((List<T>)(object)ftuePanels).Add((T)avatarPresetPanel);
			List<IStartFTUEPanel> ftuePanels2 = _ftuePanels;
			FTUEAppearencePanel mcAppearencePanel = _mcAppearencePanel;
			((List<T>)(object)ftuePanels2).Add((T)mcAppearencePanel);
			List<IStartFTUEPanel> ftuePanels3 = _ftuePanels;
			FTUENamePanel mcNamePanel = _mcNamePanel;
			((List<T>)(object)ftuePanels3).Add((T)mcNamePanel);
			base.OnPush(stack, param);
			SystemRoot.Instance.GetSystem<AudioManager>().SetGameState(AudioManager.GameState.MenuStartCustomization);
			GameObject gameObject = _avatarPresetPanel.ImportAvatarButton.gameObject;
			int num = 0;
			if (PlatformUtils.GetRuntimePlatform() == RuntimePlatform.OSXPlayer)
			{
				int num2 = 0;
				if (!PlatformUtils.UseSteam())
				{
					int num3 = 0;
					bool flag = PlatformUtils.UseEpic();
				}
			}
			gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F31")]
		[Cpp2IlInjected.Address(RVA = "0x8577F0", Offset = "0x8561F0", VA = "0x1808577F0", Slot = "24")]
		protected override void OnDestroy()
		{
			//Discarded unreachable code: IL_0022
			AvatarCustomization avatarCustomization = _avatarCustomization;
			AvatarCustomization.AvatarReady value = Init;
			avatarCustomization.OnAvatarReady -= value;
			base.OnDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F32")]
		[Cpp2IlInjected.Address(RVA = "0x857CD0", Offset = "0x8566D0", VA = "0x180857CD0", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_0011
			SystemRoot.Instance.ResumeSystem<PlayerNavigation>();
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F33")]
		[Cpp2IlInjected.Address(RVA = "0x857600", Offset = "0x856000", VA = "0x180857600")]
		private void Init(AvatarAppearance avatar)
		{
			//Discarded unreachable code: IL_002e
			_avatar = avatar;
			_avatarPresetPanel.Init();
			GameObject buttonHolder = _buttonHolder;
			int active = 0;
			buttonHolder.SetActive((byte)active != 0);
			_avatarPresetPanel.Show();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F34")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856610", VA = "0x180857C10")]
		private void OnNext()
		{
			//Discarded unreachable code: IL_0055
			//IL_0053: Expected F4, but got I4
			if (IsAnyFTUEPanelAnimated)
			{
				return;
			}
			int size = ((List<>)(object)_ftuePanels)._size;
			int currentFtuePanelIndex = _currentFtuePanelIndex;
			if (currentFtuePanelIndex != size)
			{
				RefreshCurrentSlide(currentFtuePanelIndex, _currentFtuePanelIndex = currentFtuePanelIndex + 1);
				CanvasGroup component = _shortcutIndicatorsHolder.GetComponent<CanvasGroup>();
				if (_currentFtuePanelIndex > 0)
				{
				}
				int num = 0;
				component.alpha = num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F35")]
		[Cpp2IlInjected.Address(RVA = "0x857DA0", Offset = "0x8567A0", VA = "0x180857DA0")]
		private void OnPrevious()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F36")]
		[Cpp2IlInjected.Address(RVA = "0x8584D0", Offset = "0x856ED0", VA = "0x1808584D0")]
		private void RefreshCurrentSlide(int previous, int current)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F37")]
		[Cpp2IlInjected.Address(RVA = "0x8573B0", Offset = "0x855DB0", VA = "0x1808573B0")]
		private void HandleHide(IStartFTUEPanel panel)
		{
			//Discarded unreachable code: IL_001b
			if (panel != null)
			{
				int num = 0;
				if (panel != null)
				{
					_avatarCustomization.ZoomOut();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F38")]
		[Cpp2IlInjected.Address(RVA = "0x857480", Offset = "0x855E80", VA = "0x180857480")]
		private void HandleShow(IStartFTUEPanel panel)
		{
			//Discarded unreachable code: IL_0050
			if (panel != null)
			{
				int num = 0;
				if (panel != null)
				{
					GameObject buttonHolder = _buttonHolder;
					int active = 0;
					buttonHolder.SetActive((byte)active != 0);
				}
				int num2 = 0;
				if (panel != null)
				{
					AvatarAppearance avatar = _avatar;
					_buttonHolder.SetActive(value: true);
				}
				int num3 = 0;
				if (panel != null)
				{
					GameObject buttonHolder2 = _buttonHolder;
					int active2 = 0;
					buttonHolder2.SetActive((byte)active2 != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F39")]
		[Cpp2IlInjected.Address(RVA = "0x858F20", Offset = "0x857920", VA = "0x180858F20")]
		public void SetGender(bool isMale)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F3A")]
		[Cpp2IlInjected.Address(RVA = "0x859080", Offset = "0x857A80", VA = "0x180859080")]
		[AsyncStateMachine(typeof(_003CSetNameAsync_003Ed__39))]
		public Task SetNameAsync()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F3B")]
		[Cpp2IlInjected.Address(RVA = "0x858CC0", Offset = "0x8576C0", VA = "0x180858CC0")]
		public void Save()
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F3C")]
		[Cpp2IlInjected.Address(RVA = "0x858BC0", Offset = "0x8575C0", VA = "0x180858BC0")]
		[AsyncStateMachine(typeof(_003CSaveAsync_003Ed__41))]
		private Task SaveAsync()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F3D")]
		[Cpp2IlInjected.Address(RVA = "0x857180", Offset = "0x855B80", VA = "0x180857180")]
		private void GoNext()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F3E")]
		[Cpp2IlInjected.Address(RVA = "0x856DB0", Offset = "0x8557B0", VA = "0x180856DB0")]
		private void GoBack()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F3F")]
		[Cpp2IlInjected.Address(RVA = "0x858E00", Offset = "0x857800", VA = "0x180858E00")]
		private void SetFocus()
		{
			//Discarded unreachable code: IL_0036
			List<IStartFTUEPanel> ftuePanels = _ftuePanels;
			if (ftuePanels == null)
			{
				return;
			}
			int size = ((List<>)(object)ftuePanels)._size;
			if (size != 0 && _currentFtuePanelIndex < size)
			{
				MenuNavigation menuNavigation = base.MenuNavigation;
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F40")]
		[Cpp2IlInjected.Address(RVA = "0x8577D0", Offset = "0x8561D0", VA = "0x1808577D0", Slot = "35")]
		internal override void OnControllerChanged()
		{
			base.OnControllerChanged();
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F41")]
		[Cpp2IlInjected.Address(RVA = "0x857450", Offset = "0x855E50", VA = "0x180857450", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0007, IL_000e
			GoNext();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F42")]
		[Cpp2IlInjected.Address(RVA = "0x858330", Offset = "0x856D30", VA = "0x180858330")]
		private void OnUndoClickHandler()
		{
			//Discarded unreachable code: IL_0034
			NotificationButton btnUndo = _btnUndo;
			AK.Wwise.Event undoSfx = _undoSfx;
			if (undoSfx != null)
			{
				GameObject gameObject = btnUndo.gameObject;
				uint num = undoSfx.Post(gameObject);
			}
			CancellationToken cancellationToken = base.CancellationToken;
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F43")]
		[Cpp2IlInjected.Address(RVA = "0x859750", Offset = "0x858150", VA = "0x180859750")]
		[AsyncStateMachine(typeof(_003CUndoTask_003Ed__48))]
		private Task UndoTask(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F44")]
		[Cpp2IlInjected.Address(RVA = "0x858170", Offset = "0x856B70", VA = "0x180858170")]
		private void OnUndoAllClickHandler()
		{
			//Discarded unreachable code: IL_003a
			NotificationButton btnUndoAll = _btnUndoAll;
			AK.Wwise.Event undoSfx = _undoSfx;
			if (undoSfx != null)
			{
				GameObject gameObject = btnUndoAll.gameObject;
				uint num = undoSfx.Post(gameObject);
			}
			CancellationToken cancellationToken = base.CancellationToken;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F45")]
		[Cpp2IlInjected.Address(RVA = "0x859620", Offset = "0x858020", VA = "0x180859620")]
		[AsyncStateMachine(typeof(_003CUndoAllTask_003Ed__50))]
		private Task UndoAllTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F46")]
		[Cpp2IlInjected.Address(RVA = "0x859B50", Offset = "0x858550", VA = "0x180859B50")]
		private void Update()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F47")]
		[Cpp2IlInjected.Address(RVA = "0x856CC0", Offset = "0x8556C0", VA = "0x180856CC0")]
		private void BumpButton(BaseButton btn)
		{
			//Discarded unreachable code: IL_002e
			Transform transform = btn.transform;
			int num = 0;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale(btn.transform, 1f, 0.3f)).SetEase(Ease.OutQuart).Play();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F48")]
		[Cpp2IlInjected.Address(RVA = "0x859180", Offset = "0x857B80", VA = "0x180859180")]
		private void StartUndoAllButtonAnim()
		{
			//Discarded unreachable code: IL_0045
			//IL_0021: Expected F4, but got I4
			_highlightImageUndoAll.gameObject.SetActive(value: true);
			Image highlightImageUndoAll = _highlightImageUndoAll;
			int num = 0;
			highlightImageUndoAll.fillAmount = num;
			float undoAllPressDelay = _avatarCustomization._undoAllPressDelay;
			TweenerCore<float, float, FloatOptions> tweenerCore = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFillAmount(_highlightImageUndoAll, 1f, undoAllPressDelay)).Play();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F49")]
		[Cpp2IlInjected.Address(RVA = "0x859230", Offset = "0x857C30", VA = "0x180859230")]
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

		[Cpp2IlInjected.Token(Token = "0x6001F4A")]
		[Cpp2IlInjected.Address(RVA = "0x856D90", Offset = "0x855790", VA = "0x180856D90")]
		public WardrobeAppearanceContent GetAppearanceContent()
		{
			//Discarded unreachable code: IL_000c
			return _mcAppearencePanel._mcAvatarItemsContent;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F4B")]
		[Cpp2IlInjected.Address(RVA = "0x857660", Offset = "0x856060", VA = "0x180857660")]
		private void OnAvatarImport()
		{
			CancellationToken cancellationToken = base.CancellationToken;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F4C")]
		[Cpp2IlInjected.Address(RVA = "0x85A530", Offset = "0x858F30", VA = "0x18085A530")]
		public StartFTUEMenu()
		{
		}
	}
}
