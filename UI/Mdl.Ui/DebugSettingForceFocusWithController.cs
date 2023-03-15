using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003E6")]
	public class DebugSettingForceFocusWithController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001331")]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.Token(Token = "0x60018D0")]
		[Cpp2IlInjected.Address(RVA = "0x1552E10", Offset = "0x1551810", VA = "0x181552E10")]
		private void Awake()
		{
			FocusNavigation focusNavigation = (_focusNavigation = GetComponentInParent<FocusNavigation>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60018D1")]
		[Cpp2IlInjected.Address(RVA = "0x1552EF0", Offset = "0x15518F0", VA = "0x181552EF0")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_001c
			FocusNavigation focusNavigation = _focusNavigation;
			FocusNavigation.FocusChanged value = OnFocusChanged;
			focusNavigation.OnFocusChanged += value;
		}

		[Cpp2IlInjected.Token(Token = "0x60018D2")]
		[Cpp2IlInjected.Address(RVA = "0x1552E60", Offset = "0x1551860", VA = "0x181552E60")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_001c
			FocusNavigation focusNavigation = _focusNavigation;
			FocusNavigation.FocusChanged value = OnFocusChanged;
			focusNavigation.OnFocusChanged -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x60018D3")]
		[Cpp2IlInjected.Address(RVA = "0x1552F80", Offset = "0x1551980", VA = "0x181552F80")]
		private void OnFocusChanged(ISupportsFocusNavigation item)
		{
			//Discarded unreachable code: IL_009b
			//IL_007b: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0) || item == null)
			{
				return;
			}
			int num2 = 0;
			if (item == null)
			{
				return;
			}
			GameObject gameObject = base.gameObject;
			GameObject gameObject2 = default(GameObject);
			if (!(gameObject2 == gameObject))
			{
				int num3 = 0;
				if (!EventSystem.current.m_SelectionGuard)
				{
					int num4 = 0;
					GameObject currentSelected = EventSystem.current.m_CurrentSelected;
					GameObject gameObject3 = base.gameObject;
					if (currentSelected == gameObject3)
					{
						int num5 = 0;
						EventSystem current = EventSystem.current;
						int num6 = 0;
						current.SetSelectedGameObject((GameObject)num6);
					}
				}
			}
			else
			{
				int _003C_003E1__state = default(int);
				_003CRequestFocusLater_003Ed__5 _003CRequestFocusLater_003Ed__ = new _003CRequestFocusLater_003Ed__5(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CRequestFocusLater_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = StartCoroutine(_003CRequestFocusLater_003Ed__);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60018D4")]
		[Cpp2IlInjected.Address(RVA = "0x15531E0", Offset = "0x1551BE0", VA = "0x1815531E0")]
		[IteratorStateMachine(typeof(_003CRequestFocusLater_003Ed__5))]
		private IEnumerator RequestFocusLater()
		{
			int _003C_003E1__state = default(int);
			_003CRequestFocusLater_003Ed__5 _003CRequestFocusLater_003Ed__ = new _003CRequestFocusLater_003Ed__5(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRequestFocusLater_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60018D5")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DebugSettingForceFocusWithController()
		{
		}
	}
}
