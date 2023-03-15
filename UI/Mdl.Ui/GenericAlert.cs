using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using Mdl.InputSystem;
using Mdl.Ui.Cache;
using Mdl.Ui.Widgets;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200021A")]
	public class GenericAlert : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400094A")]
		[SerializeField]
		private GameObject _titleContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400094B")]
		[SerializeField]
		private TextBase tf_title;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400094C")]
		[SerializeField]
		private Transform tf_messagesContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400094D")]
		[SerializeField]
		private ScrollRect mc_messagesScroll;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400094E")]
		[SerializeField]
		private ScrollRect mc_devNoteScroll;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400094F")]
		[SerializeField]
		private TextBase tf_devNote;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000950")]
		[SerializeField]
		private ButtonTmProIcon _buttonPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000951")]
		[SerializeField]
		private Button btn_close;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000952")]
		[SerializeField]
		private RectTransform _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000953")]
		[SerializeField]
		private CanvasGroup _canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000954")]
		[SerializeField]
		private RectTransform _trashBin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000955")]
		[SerializeField]
		private RectTransform _mcAnimatedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000956")]
		[SerializeField]
		private RectTransform _mcButtonHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000957")]
		[SerializeField]
		private ParticleSystem backgroundSparkle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000958")]
		[SerializeField]
		private bool skipLocalization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000959")]
		protected PopUpArgs _currentPopUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400095A")]
		protected Queue<PopUpArgs> _queue = (Queue<PopUpArgs>)(object)new Queue<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400095B")]
		private bool _isBusy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400095C")]
		public AK.Wwise.Event sfxCloseEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400095D")]
		public AK.Wwise.Event sfxCancelEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400095E")]
		private string _popupSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400095F")]
		private bool _canClickButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x4000960")]
		[SerializeField]
		private float _animDuration = 0.35f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000961")]
		[SerializeField]
		private float _maxMessageHeight = 450f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
		[Cpp2IlInjected.Token(Token = "0x4000962")]
		[SerializeField]
		private float _minMessageHeight = 150f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000963")]
		private float _contentOriginalY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000964")]
		private InputAction _inputMessageScroll;

		[Cpp2IlInjected.Token(Token = "0x17000293")]
		public RectTransform ButtonsHolder
		{
			[Cpp2IlInjected.Token(Token = "0x6000D4E")]
			[Cpp2IlInjected.Address(RVA = "0x9762E0", Offset = "0x974CE0", VA = "0x1809762E0")]
			get
			{
				return _mcButtonHolder;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000294")]
		public PopUpArgs CurrentGenericAlert
		{
			[Cpp2IlInjected.Token(Token = "0x6000D4F")]
			[Cpp2IlInjected.Address(RVA = "0x738F60", Offset = "0x737960", VA = "0x180738F60")]
			get
			{
				return _currentPopUp;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D50")]
			[Cpp2IlInjected.Address(RVA = "0x9765D0", Offset = "0x974FD0", VA = "0x1809765D0")]
			set
			{
				_currentPopUp = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D51")]
		[Cpp2IlInjected.Address(RVA = "0xE52BE0", Offset = "0xE515E0", VA = "0x180E52BE0")]
		private void Start()
		{
			//IL_0017: Expected O, but got I4
			//IL_006f: Expected O, but got I4
			//IL_006f: Expected O, but got I4
			int isDefaultGamepadFocus = default(int);
			int num = default(int);
			int style = default(int);
			AlertButton alertButton = new AlertButton((AlertButtonStyle)style, (string)num, (byte)isDefaultGamepadFocus != 0);
			int num2 = 0;
			isDefaultGamepadFocus = 0;
			num = 0;
			style = 0;
			AlertButton seleced = alertButton;
			seleced.Style = (AlertButtonStyle)num2;
			Button.ButtonClickedEvent onClick = btn_close.m_OnClick;
			UnityAction call = delegate
			{
				//Discarded unreachable code: IL_0019
				//IL_0018: Expected O, but got I4
				GenericAlert genericAlert = this;
				AlertButton selected = seleced;
				int num4 = 0;
				genericAlert.onButtonTouchHandler(selected, (BaseButton)num4);
			};
			onClick.AddListener(call);
			InputTriggerDown trigger = new InputTriggerDown();
			int num3 = default(int);
			InputActionFloat inputMessageScroll = new InputActionFloat("[RStick Axis Y]", trigger, (string)num3, (InputProvider)num2);
			num3 = 0;
			_inputMessageScroll = inputMessageScroll;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000D52")]
		[Cpp2IlInjected.Address(RVA = "0xE53020", Offset = "0xE51A20", VA = "0x180E53020")]
		private void onButtonTouchHandler(AlertButton selected, [Optional] BaseButton selectedButton)
		{
			//Discarded unreachable code: IL_00e6
			//IL_0015: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_00b0: Expected F4, but got I4
			if (!_canClickButton)
			{
				return;
			}
			int num = 0;
			if (selectedButton != (UnityEngine.Object)num)
			{
				SoundComponent component = selectedButton.GetComponent<SoundComponent>();
				int num2 = 0;
				if (!(component != (UnityEngine.Object)num2))
				{
					selectedButton.PostWwiseEvent();
				}
				AK.Wwise.Event @event = selectedButton.GetComponent<SoundComponent>().SFXS[0];
				if (@event != null)
				{
					GameObject gameObject = selectedButton.gameObject;
					uint num3 = @event.Post(gameObject);
				}
			}
			KillAnimation();
			float contentOriginalY = _contentOriginalY;
			int num4 = 0;
			float animDuration = _animDuration;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)_mcContent, contentOriginalY, animDuration, (byte)num4 != 0)).SetEase(Ease.OutCirc).Play();
			float animDuration2 = _animDuration;
			CanvasGroup canvas = _canvas;
			int num5 = 0;
			TweenerCore<float, float, FloatOptions> tweenerCore2 = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(canvas, (float)num5, animDuration2)).SetEase(Ease.OutCirc).Play();
			int _003C_003E1__state = default(int);
			_003CDoHideEndOfFrame_003Ed__37 _003CDoHideEndOfFrame_003Ed__ = new _003CDoHideEndOfFrame_003Ed__37(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDoHideEndOfFrame_003Ed__._003C_003E4__this = this;
			_003CDoHideEndOfFrame_003Ed__.selected = selected;
			Coroutine coroutine = StartCoroutine(_003CDoHideEndOfFrame_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D53")]
		[Cpp2IlInjected.Address(RVA = "0xE52AF0", Offset = "0xE514F0", VA = "0x180E52AF0")]
		private void StartAnimOut()
		{
			//IL_0051: Expected F4, but got I4
			KillAnimation();
			float contentOriginalY = _contentOriginalY;
			int num = 0;
			float animDuration = _animDuration;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)_mcContent, contentOriginalY, animDuration, (byte)num != 0)).SetEase(Ease.OutCirc).Play();
			float animDuration2 = _animDuration;
			CanvasGroup canvas = _canvas;
			int num2 = 0;
			TweenerCore<float, float, FloatOptions> tweenerCore2 = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(canvas, (float)num2, animDuration2)).SetEase(Ease.OutCirc).Play();
		}

		[Cpp2IlInjected.Token(Token = "0x6000D54")]
		[Cpp2IlInjected.Address(RVA = "0xE52920", Offset = "0xE51320", VA = "0x180E52920")]
		private void StartAnimIn()
		{
			//Discarded unreachable code: IL_0083
			KillAnimation();
			RectTransform mcContent = _mcContent;
			RectTransform mcContent2 = _mcContent;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			float animDuration = _animDuration;
			int num = 0;
			float contentOriginalY = _contentOriginalY;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)_mcContent, contentOriginalY, animDuration, (byte)num != 0)).SetEase(Ease.OutCirc).Play();
			float animDuration2 = _animDuration;
			TweenerCore<float, float, FloatOptions> tweenerCore2 = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_canvas, 1f, animDuration2)).SetDelay(0.05f).SetEase(Ease.OutCirc).Play();
		}

		[Cpp2IlInjected.Token(Token = "0x6000D55")]
		[Cpp2IlInjected.Address(RVA = "0xE50690", Offset = "0xE4F090", VA = "0x180E50690")]
		private void KillAnimation()
		{
			//Discarded unreachable code: IL_0043
			RectTransform mcContent = _mcContent;
			RectTransform mcContent2 = _mcContent;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			CanvasGroup canvas = _canvas;
			int complete = 0;
			int num = DOTween.Kill(canvas, (byte)complete != 0);
			RectTransform mcContent3 = _mcContent;
			int complete2 = 0;
			int num2 = DOTween.Kill(mcContent3, (byte)complete2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D56")]
		[Cpp2IlInjected.Address(RVA = "0xE4FCD0", Offset = "0xE4E6D0", VA = "0x180E4FCD0")]
		[IteratorStateMachine(typeof(_003CDoHideEndOfFrame_003Ed__37))]
		private IEnumerator DoHideEndOfFrame(AlertButton selected)
		{
			int _003C_003E1__state = default(int);
			_003CDoHideEndOfFrame_003Ed__37 _003CDoHideEndOfFrame_003Ed__ = new _003CDoHideEndOfFrame_003Ed__37(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDoHideEndOfFrame_003Ed__._003C_003E4__this = this;
			_003CDoHideEndOfFrame_003Ed__.selected = selected;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000D57")]
		[Cpp2IlInjected.Address(RVA = "0xE52520", Offset = "0xE50F20", VA = "0x180E52520", Slot = "39")]
		public virtual void Show()
		{
			//Discarded unreachable code: IL_015b
			//IL_015a: Expected O, but got I4
			RectTransform mcContent = _mcContent;
			_isFocused = true;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			KillAnimation();
			RectTransform mcContent2 = _mcContent;
			RectTransform mcContent3 = _mcContent;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			float animDuration = _animDuration;
			int num = 0;
			float contentOriginalY = _contentOriginalY;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)_mcContent, contentOriginalY, animDuration, (byte)num != 0)).SetEase(Ease.OutCirc).Play();
			float animDuration2 = _animDuration;
			TweenerCore<float, float, FloatOptions> tweenerCore2 = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_canvas, 1f, animDuration2)).SetDelay(0.05f).SetEase(Ease.OutCirc).Play();
			string popupSFX = _popupSFX;
			if (tweenerCore2 == null)
			{
				string popupSFX2 = _popupSFX;
				GameObject in_gameObjectID = base.gameObject;
				uint num2 = AkSoundEngine.PostEvent(popupSFX2, in_gameObjectID);
			}
			MenuLayoutTemplate oldLayout = _oldLayout;
			MenuLayoutTemplate currentLayout = GetCurrentLayout();
			if (oldLayout != currentLayout)
			{
				OnLayoutChange();
			}
			base.gameObject.SetActive(value: true);
			int _003C_003E1__state = default(int);
			_003CSetupMessageLayout_003Ed__48 _003CSetupMessageLayout_003Ed__ = new _003CSetupMessageLayout_003Ed__48(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CSetupMessageLayout_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CSetupMessageLayout_003Ed__);
			int _003C_003E1__state2 = default(int);
			_003CAllowButtonClick_003Ed__49 _003CAllowButtonClick_003Ed__ = new _003CAllowButtonClick_003Ed__49(_003C_003E1__state2);
			_003C_003E1__state2 = 0;
			_003CAllowButtonClick_003Ed__._003C_003E4__this = this;
			Coroutine coroutine2 = StartCoroutine(_003CAllowButtonClick_003Ed__);
			bool flag = CheckAndStartControlOverride();
			base.MenuNavigation.RefreshAll(forcelyUpdate: true);
			int num3 = 0;
			((UnityEvent<T0>)(object)UiRoot.Instance.Dispatcher.OnGenericAlertOnOff)?.Invoke((T0)1);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D58")]
		[Cpp2IlInjected.Address(RVA = "0xE50480", Offset = "0xE4EE80", VA = "0x180E50480", Slot = "40")]
		public virtual void Hide()
		{
			//Discarded unreachable code: IL_00db
			//IL_007a: Expected O, but got I4
			//IL_00a9: Expected O, but got I4
			//IL_00d4: Expected O, but got I4
			ScrollRect scrollRect = mc_messagesScroll;
			_isFocused = false;
			int num = ((scrollRect.enabled = false) ? 1 : 0);
			Transform transform = tf_messagesContainer;
			bool flag2 = default(bool);
			if (flag2)
			{
				int num2 = 0;
			}
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			KillAnimation();
			Queue<PopUpArgs> queue = _queue;
			int num3 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
				int num4 = 0;
				if (focusNavigation != (UnityEngine.Object)num4 && _mcButtonHolder.transform.childCount > 0)
				{
					FocusNavigation focusNavigation2 = base.MenuNavigation.FocusNavigation;
					int num5 = 0;
					focusNavigation2.SetFocus((FocusNavigationElement)num5);
				}
			}
			StopControlOverride();
			int num6 = 0;
			UnityEvent<bool> onGenericAlertOnOff = UiRoot.Instance.Dispatcher.OnGenericAlertOnOff;
			if (onGenericAlertOnOff != null)
			{
				int num7 = 0;
				((UnityEvent<T0>)(object)onGenericAlertOnOff).Invoke((T0)num7);
			}
			ResolveQueue();
		}

		[Cpp2IlInjected.Token(Token = "0x6000D59")]
		[Cpp2IlInjected.Address(RVA = "0xE4F9A0", Offset = "0xE4E3A0", VA = "0x180E4F9A0")]
		public void Alert(PopUpArgs args)
		{
			//Discarded unreachable code: IL_001c
			((Queue<T>)(object)_queue).Enqueue((T)args);
			if (!_isBusy)
			{
				ResolveQueue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5A")]
		[Cpp2IlInjected.Address(RVA = "0xE4FA10", Offset = "0xE4E410", VA = "0x180E4FA10")]
		public void Alert(string message, string title = "", bool showCloseButton = false, bool skipLocManager = false)
		{
			//Discarded unreachable code: IL_008a
			//IL_000f: Expected O, but got I4
			PopUpArgs popUpArgs;
			int num = default(int);
			int isDefaultGamepadFocus = default(int);
			string[] array2;
			while (true)
			{
				popUpArgs = new PopUpArgs();
				AlertButton alertButton = new AlertButton(AlertButtonStyle.Confirm, (string)num, (byte)isDefaultGamepadFocus != 0);
				isDefaultGamepadFocus = 0;
				num = 0;
				AlertButton[] array = new AlertButton[1];
				if (alertButton == null || array != null)
				{
					array[0] = alertButton;
					popUpArgs.ButtonsList = array;
					array2 = new string[1];
					if (message == null || array2 != null)
					{
						break;
					}
				}
			}
			array2[0] = message;
			popUpArgs.MessageStrIDs = array2;
			popUpArgs.TitleStrID = title;
			popUpArgs.SkipLocManager = false;
			popUpArgs.ShowCloseButton = showCloseButton;
			((Queue<T>)(object)_queue).Enqueue((T)popUpArgs);
			if (!_isBusy)
			{
				ResolveQueue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5B")]
		[Cpp2IlInjected.Address(RVA = "0xE4FD60", Offset = "0xE4E760", VA = "0x180E4FD60")]
		private static string GenerateThrobberKey(IEnumerable<string> ids)
		{
			Guid guid = Guid.NewGuid();
			string input = string.Join("|", (IEnumerable<>)ids);
			string empty = string.Empty;
			string text = Regex.Replace(input, "<.*?>", empty);
			string text2 = default(string);
			Debug.Log("[UI] Throbber key for GenericAlert:" + text2 + " => " + text);
			return text2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5C")]
		[Cpp2IlInjected.Address(RVA = "0xE4F660", Offset = "0xE4E060", VA = "0x180E4F660")]
		[AsyncStateMachine(typeof(_003CAlertAsync_003Ed__43))]
		public Task<AlertButton> AlertAsync(PopUpArgs args, [Optional] CancellationToken cancellationToken)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<AlertButton>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5D")]
		[Cpp2IlInjected.Address(RVA = "0xE4F480", Offset = "0xE4DE80", VA = "0x180E4F480")]
		[AsyncStateMachine(typeof(_003CAlertAsync_003Ed__44))]
		public Task<AlertButton> AlertAsync(string message, IEnumerable<AlertButton> buttons, string title = "", bool showCloseButton = false, string devNote = "", [Optional] AK.Wwise.Event confirmSFX, [Optional] AK.Wwise.Event cancelSFX, [Optional] string popupSFX, [Optional] CancellationToken cancellationToken)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<AlertButton>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5E")]
		[Cpp2IlInjected.Address(RVA = "0xE4F7B0", Offset = "0xE4E1B0", VA = "0x180E4F7B0")]
		[AsyncStateMachine(typeof(_003CAlertAsync_003Ed__45))]
		public Task<AlertButton> AlertAsync(IEnumerable<string> messages, IEnumerable<AlertButton> buttons, string title = "", bool showCloseButton = false, string devNote = "", [Optional] AK.Wwise.Event confirmSFX, [Optional] AK.Wwise.Event cancelSFX, [Optional] string popupSFX, [Optional] CancellationToken cancellationToken)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<AlertButton>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5F")]
		[Cpp2IlInjected.Address(RVA = "0xE50920", Offset = "0xE4F320", VA = "0x180E50920")]
		private void ResolveQueue()
		{
			//Discarded unreachable code: IL_0028, IL_0030
			PopUpArgs popUpArgs = (_currentPopUp = (PopUpArgs)((Queue<T>)(object)_queue).Dequeue());
			_isBusy = true;
			SetupPopUp();
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6000D60")]
		[Cpp2IlInjected.Address(RVA = "0xE50A40", Offset = "0xE4F440", VA = "0x180E50A40", Slot = "41")]
		protected virtual void SetupPopUp()
		{
			//IL_005b: Expected O, but got I4
			//IL_00ee: Expected O, but got I4
			//IL_017e: Expected O, but got I4
			//IL_01d0: Expected I4, but got I8
			//IL_0234: Expected O, but got I4
			//IL_02c3: Expected O, but got I4
			//IL_0348: Expected O, but got I4
			//IL_042c: Expected O, but got I4
			//IL_047f: Expected O, but got I4
			//IL_04a0: Expected I4, but got F4
			//IL_04a9: Expected I8, but got I4
			//IL_04bd: Expected O, but got I4
			//IL_0513: Expected O, but got I4
			bool flag = default(bool);
			ButtonTmProIcon buttonTmProIcon = default(ButtonTmProIcon);
			bool flag2 = default(bool);
			GameObject obj = default(GameObject);
			int num6 = default(int);
			int num7 = default(int);
			uint num8 = default(uint);
			int num9 = default(int);
			Transform transform2 = default(Transform);
			EscFonctionality escFonctionality = default(EscFonctionality);
			uint num11 = default(uint);
			ButtonTmProIcon instance = default(ButtonTmProIcon);
			AlertButton item = default(AlertButton);
			TextBase label = default(TextBase);
			int num13 = default(int);
			Button.ButtonClickedEvent onClick = default(Button.ButtonClickedEvent);
			int num14 = default(int);
			MenuNavigation menuNavigation = default(MenuNavigation);
			FocusNavigation focusNavigation2 = default(FocusNavigation);
			MenuNavigation menuNavigation2 = default(MenuNavigation);
			bool isDefaultGamepadFocus = default(bool);
			int num21 = default(int);
			Client client = default(Client);
			int num22 = default(int);
			GameObject gameObject6 = default(GameObject);
			IEnumerable<> enumerable = default(IEnumerable<>);
			uint num23 = default(uint);
			string text3 = default(string);
			ulong num25 = default(ulong);
			AsyncAtlassedIcon currencyIcon = default(AsyncAtlassedIcon);
			AtlassedIcon currentData = default(AtlassedIcon);
			SoundComponent soundComponent = default(SoundComponent);
			SoundComponent soundComponent2 = default(SoundComponent);
			SoundComponent soundComponent3 = default(SoundComponent);
			while (true)
			{
				int num = 0;
				int canClickButton = 0;
				int num2 = 0;
				_canClickButton = (byte)canClickButton != 0;
				GameObject gameObject = btn_close.gameObject;
				bool _003CShowCloseButton_003Ek__BackingField = _currentPopUp.ShowCloseButton;
				gameObject.SetActive(_003CShowCloseButton_003Ek__BackingField);
				List<Transform> list = (List<Transform>)(object)new List<T>();
				IEnumerator enumerator = _mcButtonHolder.GetEnumerator();
				if (enumerator != null)
				{
					int num3 = 0;
					if (enumerator == null)
					{
						continue;
					}
					int num4 = 0;
					flag = buttonTmProIcon != (UnityEngine.Object)num4;
					if (flag)
					{
						buttonTmProIcon.ButtonComponent.m_OnClick.RemoveAllListeners();
					}
				}
				if (flag)
				{
				}
				if (flag2)
				{
					UnityEngine.Object.Destroy(obj);
				}
				int num5 = 0;
				Transform transform = tf_messagesContainer;
				if (num6 < num7)
				{
					int index = 0;
					GameObject gameObject2 = transform.GetChild(index).gameObject;
				}
				if ((int)num8 < num9)
				{
					GameObject gameObject3 = transform2.gameObject;
					bool active = (int)num8 < num7;
					int num10 = 0;
					gameObject3.SetActive(active);
					num8++;
					while ((object)gameObject3 != null)
					{
					}
				}
				_003C_003Ec__DisplayClass47_0 CS_0024_003C_003E8__locals0;
				if ((object)escFonctionality != null)
				{
					CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass47_0();
					CS_0024_003C_003E8__locals0._003C_003E4__this = (GenericAlert)0;
					if (num5 < (int)num11)
					{
						num5 += num5;
						if (num5 == (int)num11)
						{
							goto IL_01a8;
						}
						num5++;
					}
					CS_0024_003C_003E8__locals0.item = (AlertButton)(object)CS_0024_003C_003E8__locals0;
					CS_0024_003C_003E8__locals0.instance = instance;
					item = CS_0024_003C_003E8__locals0.item;
					AlertButtonStyle style = item.Style;
					if (style != 0)
					{
						if (style == AlertButtonStyle.Close)
						{
							goto IL_0309;
						}
						if (style == AlertButtonStyle.Close)
						{
							goto IL_0284;
						}
						if (style == AlertButtonStyle.Close)
						{
							goto IL_01ec;
						}
						if (style == AlertButtonStyle.Confirm)
						{
							int costAmount = item.CostAmount;
							label = CS_0024_003C_003E8__locals0.instance.Label;
							int num12 = 0;
							string text2 = (label.Text = LocalizationManager.FromStringID(item.Label, (IResolver)num12));
							GameObject gameObject4 = CS_0024_003C_003E8__locals0.instance._currencyIcon.gameObject;
							num13 = 0;
							gameObject4.SetActive((byte)num13 != 0);
							goto IL_01a8;
						}
					}
					goto IL_0361;
				}
				goto IL_0463;
				IL_0361:
				AlertButton item2 = CS_0024_003C_003E8__locals0.item;
				ButtonTmProIcon instance2 = CS_0024_003C_003E8__locals0.instance;
				if (item2.Style != AlertButtonStyle.ConfirmWithHold)
				{
					onClick = instance2.ButtonComponent.m_OnClick;
					UnityAction call = delegate
					{
						//Discarded unreachable code: IL_001e
						GenericAlert _003C_003E4__this2 = CS_0024_003C_003E8__locals0._003C_003E4__this;
						ButtonTmProIcon instance8 = CS_0024_003C_003E8__locals0.instance;
						AlertButton item4 = CS_0024_003C_003E8__locals0.item;
						_003C_003E4__this2.onButtonTouchHandler(item4, instance8);
					};
					onClick.AddListener(call);
					goto IL_03a3;
				}
				goto IL_03b9;
				IL_03b9:
				UnityAction call2 = delegate
				{
					//Discarded unreachable code: IL_001e
					GenericAlert _003C_003E4__this = CS_0024_003C_003E8__locals0._003C_003E4__this;
					ButtonTmProIcon instance7 = CS_0024_003C_003E8__locals0.instance;
					AlertButton item3 = CS_0024_003C_003E8__locals0.item;
					_003C_003E4__this.onButtonTouchHandler(item3, instance7);
				};
				onClick.AddListener(call2);
				if (CS_0024_003C_003E8__locals0.item.Style != AlertButtonStyle.Confirm && num5 != num14 && !CS_0024_003C_003E8__locals0.item.IsDefaultGamepadFocus)
				{
					num5++;
				}
				int num15 = 0;
				UiRoot instance3 = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (!instance3.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					continue;
				}
				FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
				int num16 = 0;
				if (focusNavigation != (UnityEngine.Object)num16)
				{
					focusNavigation2 = menuNavigation2.FocusNavigation;
					FocusNavigationElement component = CS_0024_003C_003E8__locals0.instance.GetComponent<FocusNavigationElement>();
					focusNavigation2.SetFocus(component);
					isDefaultGamepadFocus = CS_0024_003C_003E8__locals0.item.IsDefaultGamepadFocus;
				}
				num5++;
				goto IL_0463;
				IL_0463:
				int num17 = 0;
				if ((object)escFonctionality != null)
				{
				}
				if (isDefaultGamepadFocus)
				{
					continue;
				}
				int num18 = 0;
				if (focusNavigation2 == (UnityEngine.Object)num18)
				{
					Button button = (escFonctionality.BtnToClickOnEsc = focusNavigation2.GetComponentInChildren<Button>());
				}
				long num19 = Mathf.Clamp(-1, 1, 0) * 300;
				int num20 = 0;
				if (num5 > 4)
				{
					Debug.LogWarning($"[UI] GenericAlert supports up to 4 buttons, {num21} passed");
				}
				Profile profile = client.profile;
				if (profile != null)
				{
					ProfileSettings settings_ = profile.settings_;
					if (settings_ != null)
					{
						bool isDev_ = settings_.isDev_;
					}
				}
				ScrollRect scrollRect = mc_devNoteScroll;
				if (num17 == 0)
				{
					GameObject gameObject5 = scrollRect.gameObject;
					num22 = 0;
					int active2 = 0;
					gameObject5.SetActive((byte)active2 != 0);
				}
				bool active3 = !string.IsNullOrEmpty((string)num22);
				gameObject6.SetActive(active3);
				if (enumerable != null && num17 < (int)num23)
				{
					num17 += num17;
					if (num17 != (int)num23)
					{
						num17++;
					}
				}
				if (enumerable != null)
				{
					int num24 = 0;
				}
				if (num17 == 0)
				{
					/*Error: Could not find block for branch target IL_054f*/;
				}
				continue;
				IL_01a8:
				num13 += num13;
				label.Text = text3;
				CS_0024_003C_003E8__locals0.instance._currencyIcon.gameObject.SetActive((byte)num25 != 0);
				currencyIcon = CS_0024_003C_003E8__locals0.instance._currencyIcon;
				IItemData costCurrency = CS_0024_003C_003E8__locals0.item.CostCurrency;
				goto IL_01ec;
				IL_0284:
				TextBase label2 = CS_0024_003C_003E8__locals0.instance.Label;
				string text4 = (label2.StringID = item.Label);
				if (currentData == null)
				{
				}
				SoundComponent component2 = CS_0024_003C_003E8__locals0.instance.GetComponent<SoundComponent>();
				int num26 = 0;
				bool flag3 = component2 != (UnityEngine.Object)num26;
				ButtonTmProIcon instance4 = CS_0024_003C_003E8__locals0.instance;
				if (!flag3)
				{
					instance4._sfxEvent = (AK.Wwise.Event)(object)currentData;
				}
				AK.Wwise.Event[] sFXS = soundComponent.SFXS;
				if (currentData != null && (object)soundComponent == null)
				{
					continue;
				}
				sFXS[0] = (AK.Wwise.Event)(object)currentData;
				((BaseButton)CS_0024_003C_003E8__locals0.instance)._useHold = true;
				goto IL_0309;
				IL_0309:
				TextBase label4 = CS_0024_003C_003E8__locals0.instance.Label;
				string text5 = (label4.StringID = item.Label);
				if (currentData == null)
				{
				}
				SoundComponent component3 = CS_0024_003C_003E8__locals0.instance.GetComponent<SoundComponent>();
				int num27 = 0;
				bool flag4 = component3 != (UnityEngine.Object)num27;
				ButtonTmProIcon instance5 = CS_0024_003C_003E8__locals0.instance;
				if (!flag4)
				{
					instance5._sfxEvent = (AK.Wwise.Event)(object)currentData;
					goto IL_0361;
				}
				goto IL_03a3;
				IL_01ec:
				TextBase label6 = CS_0024_003C_003E8__locals0.instance.Label;
				string text6 = (label6.StringID = item.Label);
				currentData = currencyIcon._currentData;
				if (currentData == null)
				{
				}
				SoundComponent component4 = CS_0024_003C_003E8__locals0.instance.GetComponent<SoundComponent>();
				int num28 = 0;
				bool flag5 = component4 != (UnityEngine.Object)num28;
				ButtonTmProIcon instance6 = CS_0024_003C_003E8__locals0.instance;
				if (!flag5)
				{
					instance6._sfxEvent = (AK.Wwise.Event)(object)currentData;
				}
				AK.Wwise.Event[] sFXS2 = soundComponent2.SFXS;
				if (currentData != null && (object)soundComponent2 == null)
				{
					continue;
				}
				sFXS2[0] = (AK.Wwise.Event)(object)currentData;
				Button button2 = (escFonctionality.BtnToClickOnEsc = CS_0024_003C_003E8__locals0.instance.GetComponent<Button>());
				goto IL_0284;
				IL_03a3:
				AK.Wwise.Event[] sFXS3 = soundComponent3.SFXS;
				if (onClick != null && (object)soundComponent3 == null)
				{
					continue;
				}
				goto IL_03b9;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D61")]
		[Cpp2IlInjected.Address(RVA = "0xE509D0", Offset = "0xE4F3D0", VA = "0x180E509D0")]
		[IteratorStateMachine(typeof(_003CSetupMessageLayout_003Ed__48))]
		private IEnumerator SetupMessageLayout()
		{
			int _003C_003E1__state = default(int);
			_003CSetupMessageLayout_003Ed__48 _003CSetupMessageLayout_003Ed__ = new _003CSetupMessageLayout_003Ed__48(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CSetupMessageLayout_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000D62")]
		[Cpp2IlInjected.Address(RVA = "0xE4FC60", Offset = "0xE4E660", VA = "0x180E4FC60")]
		[IteratorStateMachine(typeof(_003CAllowButtonClick_003Ed__49))]
		private IEnumerator AllowButtonClick()
		{
			int _003C_003E1__state = default(int);
			_003CAllowButtonClick_003Ed__49 _003CAllowButtonClick_003Ed__ = new _003CAllowButtonClick_003Ed__49(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CAllowButtonClick_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000D63")]
		[Cpp2IlInjected.Address(RVA = "0xE52DB0", Offset = "0xE517B0", VA = "0x180E52DB0")]
		private void Update()
		{
			//Discarded unreachable code: IL_0092
			Vector2 anchoredPosition3 = default(Vector2);
			while (mc_messagesScroll.enabled)
			{
				int num = 0;
				float deltaTime = Time.deltaTime;
				InputAction[] array = new InputAction[1];
				InputAction inputMessageScroll = _inputMessageScroll;
				if (inputMessageScroll == null || array != null)
				{
					array[0] = inputMessageScroll;
					InputAction.UpdateAll(deltaTime, array);
					InputAction inputMessageScroll2 = _inputMessageScroll;
					if (inputMessageScroll2.IsTriggered)
					{
						float valueFloat = inputMessageScroll2.GetValueFloat();
						ScrollRect scrollRect = mc_messagesScroll;
						deltaTime = valueFloat;
						RectTransform content = scrollRect.m_Content;
						Vector2 anchoredPosition = content.anchoredPosition;
						Vector2 anchoredPosition2 = mc_messagesScroll.m_Content.anchoredPosition;
						content.anchoredPosition = anchoredPosition3;
					}
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D64")]
		[Cpp2IlInjected.Address(RVA = "0xE52230", Offset = "0xE50C30", VA = "0x180E52230", Slot = "42")]
		public virtual void ShowCurrencyInHud()
		{
			//Discarded unreachable code: IL_00ca
			//IL_0030: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			//IL_00c9: Expected O, but got I4
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			int num3 = 0;
			if (top != null)
			{
				int num4 = 0;
				if (top == null)
				{
				}
			}
			int num5 = 0;
			if (!((UnityEngine.Object)num3 != (UnityEngine.Object)num5))
			{
				return;
			}
			int num6 = 0;
			GameObject gameObject = default(GameObject);
			if (gameObject != (UnityEngine.Object)num6)
			{
				GameObject gameObject2 = default(GameObject);
				Canvas component = gameObject2.GetComponent<Canvas>();
				int num7 = 0;
				if (component == (UnityEngine.Object)num7)
				{
					GameObject gameObject3 = default(GameObject);
					Canvas canvas = gameObject3.AddComponent<Canvas>();
					GameObject gameObject4 = default(GameObject);
					GraphicRaycaster graphicRaycaster = gameObject4.AddComponent<GraphicRaycaster>();
					int num8 = 0;
					Canvas component2 = UiRoot.Instance._popupStack.GetComponent<Canvas>();
					canvas.overrideSorting = true;
					int num9 = (canvas.sortingLayerID = component2.sortingLayerID);
					int sortingOrder = 0;
					int sortingOrder2 = component2.sortingOrder;
					canvas.sortingOrder = sortingOrder;
					SlidingPanel slidingPanel = default(SlidingPanel);
					slidingPanel?.Show(andOpen: true);
					LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)num3);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D65")]
		[Cpp2IlInjected.Address(RVA = "0xE50200", Offset = "0xE4EC00", VA = "0x180E50200", Slot = "43")]
		public virtual void HideCurrencyInHud()
		{
			//Discarded unreachable code: IL_008d
			//IL_0030: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			//IL_0060: Expected O, but got I4
			//IL_0076: Expected O, but got I4
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			int num3 = 0;
			if (top != null)
			{
				int num4 = 0;
				if (top == null)
				{
				}
			}
			int num5 = 0;
			if (!((UnityEngine.Object)num3 != (UnityEngine.Object)num5))
			{
				return;
			}
			int num6 = 0;
			GameObject gameObject = default(GameObject);
			if (gameObject != (UnityEngine.Object)num6)
			{
				GameObject gameObject2 = default(GameObject);
				Canvas component = gameObject2.GetComponent<Canvas>();
				GameObject gameObject3 = default(GameObject);
				GraphicRaycaster component2 = gameObject3.GetComponent<GraphicRaycaster>();
				int num7 = 0;
				if (component2 != (UnityEngine.Object)num7)
				{
					UnityEngine.Object.Destroy(component2);
				}
				int num8 = 0;
				if (component != (UnityEngine.Object)num8)
				{
					UnityEngine.Object.Destroy(component);
				}
				SlidingPanel slidingPanel = default(SlidingPanel);
				slidingPanel?.Hide();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D66")]
		[Cpp2IlInjected.Address(RVA = "0xE507B0", Offset = "0xE4F1B0", VA = "0x180E507B0", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0098
			//IL_0034: Expected O, but got I4
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
				int num2 = 0;
				if (focusNavigation != (UnityEngine.Object)num2 && (long)base.MenuNavigation.FocusNavigation._focusedElement == 0 && _mcButtonHolder.childCount > 0)
				{
					MenuNavigation menuNavigation = base.MenuNavigation;
					RectTransform mcButtonHolder = _mcButtonHolder;
					FocusNavigation focusNavigation2 = menuNavigation.FocusNavigation;
					int index = mcButtonHolder.childCount - 1;
					FocusNavigationElement component = mcButtonHolder.GetChild(index).GetComponent<FocusNavigationElement>();
					focusNavigation2.SetFocus(component);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D67")]
		[Cpp2IlInjected.Address(RVA = "0xE4FEE0", Offset = "0xE4E8E0", VA = "0x180E4FEE0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_00f0
			switch (redirectionType)
			{
			case RedirectionType.GenericAlertNo:
			case RedirectionType.GamePromptClose:
			{
				IEnumerable<AlertButton> _003CButtonsList_003Ek__BackingField = _currentPopUp.ButtonsList;
				Func<AlertButton, bool> _003C_003E9__54_ = _003C_003Ec._003C_003E9__54_1;
				if (_003C_003E9__54_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(AlertButton x)
					{
						//Discarded unreachable code: IL_0012
						AlertButtonStyle style = x.Style;
						return style == AlertButtonStyle.Cancel || style == AlertButtonStyle.Close;
					};
				}
				int num = MoreLinq.FindIndex<AlertButton>((IEnumerable<>)_003CButtonsList_003Ek__BackingField, (Func<, >)(object)_003C_003E9__54_);
				int num2 = Enumerable.Count<AlertButton>((IEnumerable<>)_currentPopUp.ButtonsList);
				RectTransform mcButtonHolder = _mcButtonHolder;
				break;
			}
			case RedirectionType.GenericAlertYes:
				break;
			default:
				return;
			}
			IEnumerable<AlertButton> _003CButtonsList_003Ek__BackingField2 = _currentPopUp.ButtonsList;
			Func<AlertButton, bool> func = default(Func<AlertButton, bool>);
			if (_003C_003Ec._003C_003E9__54_0 == null)
			{
				func = (Func<AlertButton, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((AlertButton x) => x.Style == AlertButtonStyle.Confirm));
			}
			int index = MoreLinq.FindIndex<AlertButton>((IEnumerable<>)_003CButtonsList_003Ek__BackingField2, (Func<, >)(object)func);
			_mcButtonHolder.GetChild(index).GetComponent<ButtonTmProIcon>()?.ButtonComponent.m_OnClick?.Invoke();
			menuParam?.OnFocusInAction?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6000D68")]
		[Cpp2IlInjected.Address(RVA = "0xE52F80", Offset = "0xE51980", VA = "0x180E52F80")]
		public GenericAlert()
		{
		}
	}
}
