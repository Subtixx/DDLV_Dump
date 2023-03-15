using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000259")]
	[RequireComponent(typeof(TemplateButton))]
	public class ForceFocusWithController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000A94")]
		private TemplateButton _control;

		[Cpp2IlInjected.Token(Token = "0x6000EFD")]
		[Cpp2IlInjected.Address(RVA = "0x166C2D0", Offset = "0x166ACD0", VA = "0x18166C2D0")]
		private void Awake()
		{
			TemplateButton templateButton = (_control = GetComponent<TemplateButton>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EFE")]
		[Cpp2IlInjected.Address(RVA = "0x166C560", Offset = "0x166AF60", VA = "0x18166C560")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0041
			UnityEvent onHighlighted = _control.OnHighlighted;
			UnityAction call = OnHighlightedHandler;
			onHighlighted.AddListener(call);
			UnityEvent onDehighlighted = _control.OnDehighlighted;
			UnityAction call2 = OnDeHighlightedHandler;
			onDehighlighted.AddListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EFF")]
		[Cpp2IlInjected.Address(RVA = "0x166C470", Offset = "0x166AE70", VA = "0x18166C470")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0041
			UnityEvent onHighlighted = _control.OnHighlighted;
			UnityAction call = OnHighlightedHandler;
			onHighlighted.RemoveListener(call);
			UnityEvent onDehighlighted = _control.OnDehighlighted;
			UnityAction call2 = OnDeHighlightedHandler;
			onDehighlighted.RemoveListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F00")]
		[Cpp2IlInjected.Address(RVA = "0x166C320", Offset = "0x166AD20", VA = "0x18166C320")]
		private void OnDeHighlightedHandler()
		{
			//Discarded unreachable code: IL_005e
			//IL_005c: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				return;
			}
			int num2 = 0;
			if (!EventSystem.current.m_SelectionGuard)
			{
				int num3 = 0;
				GameObject currentSelected = EventSystem.current.m_CurrentSelected;
				GameObject gameObject = base.gameObject;
				if (currentSelected == gameObject)
				{
					int num4 = 0;
					EventSystem current = EventSystem.current;
					int num5 = 0;
					current.SetSelectedGameObject((GameObject)num5);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F01")]
		[Cpp2IlInjected.Address(RVA = "0x166C650", Offset = "0x166B050", VA = "0x18166C650")]
		private void OnHighlightedHandler()
		{
			//Discarded unreachable code: IL_0019
			int _003C_003E1__state = default(int);
			_003CRequestFocusLater_003Ed__6 _003CRequestFocusLater_003Ed__ = new _003CRequestFocusLater_003Ed__6(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRequestFocusLater_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CRequestFocusLater_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F02")]
		[Cpp2IlInjected.Address(RVA = "0x166C6D0", Offset = "0x166B0D0", VA = "0x18166C6D0")]
		[IteratorStateMachine(typeof(_003CRequestFocusLater_003Ed__6))]
		private IEnumerator RequestFocusLater()
		{
			int _003C_003E1__state = default(int);
			_003CRequestFocusLater_003Ed__6 _003CRequestFocusLater_003Ed__ = new _003CRequestFocusLater_003Ed__6(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRequestFocusLater_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F03")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ForceFocusWithController()
		{
		}
	}
}
