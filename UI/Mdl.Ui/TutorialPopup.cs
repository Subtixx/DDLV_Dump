using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AK.Wwise;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl.InputSystem;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200074A")]
	public class TutorialPopup : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002A84")]
		public Transform ContentContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4002A85")]
		public GameObject Content;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002A86")]
		public new FocusNavigation FocusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002A87")]
		[SerializeField]
		public GameObject Ps5Version;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4002A88")]
		[SerializeField]
		public GameObject XboxSeriesVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002A89")]
		[SerializeField]
		public List<GameObject> altContent = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002A8A")]
		[SerializeField]
		private AK.Wwise.Event _okSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002A8B")]
		private bool _canClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x109")]
		[Cpp2IlInjected.Token(Token = "0x4002A8C")]
		private bool _hasClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10A")]
		[Cpp2IlInjected.Token(Token = "0x4002A8D")]
		private bool _startCoroutineOnEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002A8E")]
		private InputAction _inputActionA;

		[Cpp2IlInjected.Token(Token = "0x6002E8F")]
		[Cpp2IlInjected.Address(RVA = "0x17F55D0", Offset = "0x17F3FD0", VA = "0x1817F55D0")]
		private void OnEnable()
		{
			//IL_0032: Expected O, but got I4
			if (_startCoroutineOnEnable)
			{
				_startCoroutineOnEnable = false;
				IEnumerator routine = ShowOkButtonDelay();
				Coroutine coroutine = StartCoroutine(routine);
			}
			InputTriggerPressed trigger = new InputTriggerPressed();
			int num = default(int);
			InputActionBool inputActionA = new InputActionBool("[ A ]", trigger, (InputProvider)num);
			num = 0;
			_inputActionA = inputActionA;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E90")]
		[Cpp2IlInjected.Address(RVA = "0x17F66F0", Offset = "0x17F50F0", VA = "0x1817F66F0")]
		private void Update()
		{
			//Discarded unreachable code: IL_005b
			float deltaTime;
			InputAction[] array;
			InputAction inputActionA;
			do
			{
				int num = 0;
				deltaTime = Time.deltaTime;
				array = new InputAction[1];
				inputActionA = _inputActionA;
			}
			while (inputActionA != null && array == null);
			array[0] = inputActionA;
			InputAction.UpdateAll(deltaTime, array);
			if (_inputActionA.IsTriggered && !_hasClick)
			{
				int num2 = 0;
				if (UiRoot.Instance.MenuOnTop == this)
				{
					OnOkButton();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E91")]
		[Cpp2IlInjected.Address(RVA = "0x17F5AA0", Offset = "0x17F44A0", VA = "0x1817F5AA0", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002E92")]
		[Cpp2IlInjected.Address(RVA = "0x17F56B0", Offset = "0x17F40B0", VA = "0x1817F56B0", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_001d
			base.OnFocusIn();
			BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
			uint num = num + 20;
			num += num;
			PopSelf();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E93")]
		[Cpp2IlInjected.Address(RVA = "0x17F6260", Offset = "0x17F4C60", VA = "0x1817F6260")]
		private void OnShowContent()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002E94")]
		[Cpp2IlInjected.Address(RVA = "0x17F54E0", Offset = "0x17F3EE0", VA = "0x1817F54E0", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_004a
			//IL_0031: Expected O, but got I4
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigationElement componentInChildren = Content.GetComponentInChildren<FocusNavigationElement>();
				int num2 = 0;
				if (componentInChildren != (UnityEngine.Object)num2 && !componentInChildren.IsInFocus)
				{
					FocusNavigation.SetFocus(componentInChildren);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E95")]
		[Cpp2IlInjected.Address(RVA = "0x17F63D0", Offset = "0x17F4DD0", VA = "0x1817F63D0")]
		private void OnShowOkButton()
		{
			//Discarded unreachable code: IL_005b
			//IL_0032: Expected O, but got I4
			TutorialPopupContent component = Content.GetComponent<TutorialPopupContent>();
			Action action = OnShowOkButton;
			Delegate @delegate = Delegate.Remove(action, action);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				component.OnShowOkButton = (Action)num;
				if (base.gameObject.activeInHierarchy)
				{
					IEnumerator routine = ShowOkButtonDelay();
					Coroutine coroutine = StartCoroutine(routine);
				}
				else
				{
					_startCoroutineOnEnable = true;
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E96")]
		[Cpp2IlInjected.Address(RVA = "0x17F6680", Offset = "0x17F5080", VA = "0x1817F6680")]
		[IteratorStateMachine(typeof(_003CShowOkButtonDelay_003Ed__18))]
		private IEnumerator ShowOkButtonDelay()
		{
			int _003C_003E1__state = default(int);
			_003CShowOkButtonDelay_003Ed__18 _003CShowOkButtonDelay_003Ed__ = new _003CShowOkButtonDelay_003Ed__18(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CShowOkButtonDelay_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E97")]
		[Cpp2IlInjected.Address(RVA = "0x17F57E0", Offset = "0x17F41E0", VA = "0x1817F57E0")]
		private void OnOkButton()
		{
			//Discarded unreachable code: IL_00da
			//IL_004c: Expected O, but got I4
			//IL_0097: Expected F4, but got I4
			if (_canClick)
			{
				GameObject content = Content;
				_canClick = false;
				TutorialPopupContent component = content.GetComponent<TutorialPopupContent>();
				Action action = OnOkButton;
				Delegate @delegate = Delegate.Remove(action, action);
				int num = 0;
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				component.OnOkButton = (Action)num;
				AK.Wwise.Event okSfx = _okSfx;
				if (okSfx != null)
				{
					GameObject gameObject = base.gameObject;
					uint num2 = okSfx.Post(gameObject);
				}
				RectTransform component2 = Content.GetComponent<RectTransform>();
				CanvasGroup component3 = ContentContainer.GetComponent<CanvasGroup>();
				int num3 = 0;
				TweenerCore<float, float, FloatOptions> tweenerCore = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(component3, (float)num3, 0.25f)).SetEase(Ease.InCirc).Play();
				Vector2 anchoredPosition = component2.anchoredPosition;
				TweenerCore<Vector2, Vector2, VectorOptions> t = default(TweenerCore<Vector2, Vector2, VectorOptions>);
				TweenerCore<Vector2, Vector2, VectorOptions> t2 = t.SetEase(Ease.InCirc);
				TweenCallback action2 = OnPopMenu;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = t2.OnComplete(action2).Play();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E98")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		private void OnPopMenu()
		{
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E99")]
		[Cpp2IlInjected.Address(RVA = "0x17F54D0", Offset = "0x17F3ED0", VA = "0x1817F54D0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			if (redirectionType == RedirectionType.GamePromptGoForward)
			{
				OnOkButton();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E9A")]
		[Cpp2IlInjected.Address(RVA = "0x17F6510", Offset = "0x17F4F10", VA = "0x1817F6510")]
		public void PopDialog()
		{
			//Discarded unreachable code: IL_0021
			//IL_0015: Expected O, but got I4
			DialogueMenu menu = _stack.GetMenu<DialogueMenu>();
			int num = 0;
			if (menu != (UnityEngine.Object)num)
			{
				IExtenderProvider[] extenderProviders = ((IExtenderListService)menu).GetExtenderProviders();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E9B")]
		[Cpp2IlInjected.Address(RVA = "0x17F65C0", Offset = "0x17F4FC0", VA = "0x1817F65C0")]
		private void SetOkFocus()
		{
			//Discarded unreachable code: IL_002e
			//IL_0015: Expected O, but got I4
			FocusNavigationElement componentInChildren = Content.GetComponentInChildren<FocusNavigationElement>();
			int num = 0;
			if (componentInChildren != (UnityEngine.Object)num && !componentInChildren.IsInFocus)
			{
				FocusNavigation.SetFocus(componentInChildren);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E9C")]
		[Cpp2IlInjected.Address(RVA = "0x17F6840", Offset = "0x17F5240", VA = "0x1817F6840")]
		public TutorialPopup()
		{
		}
	}
}
