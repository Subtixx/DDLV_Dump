using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.InputSystem;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000837")]
	public class EscFonctionality : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003082")]
		public Button BtnToClickOnEsc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003083")]
		public UnityEvent EventToTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003084")]
		private InputAction _exitActionPress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003085")]
		private InputAction _exitActionRelease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003086")]
		private Coroutine _waitFrameCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003087")]
		private bool _doneWaiting;

		[Cpp2IlInjected.Token(Token = "0x600342D")]
		[Cpp2IlInjected.Address(RVA = "0xF25E30", Offset = "0xF24830", VA = "0x180F25E30")]
		private void OnEnable()
		{
			//IL_0012: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			InputTriggerPressed trigger = new InputTriggerPressed();
			int num = default(int);
			InputActionBool exitActionPress = new InputActionBool("[Esc]", trigger, (InputProvider)num);
			num = 0;
			_exitActionPress = exitActionPress;
			InputTriggerReleased trigger2 = new InputTriggerReleased();
			int num2 = default(int);
			InputActionBool exitActionRelease = new InputActionBool("[Esc]", trigger2, (InputProvider)num2);
			num2 = 0;
			_exitActionRelease = exitActionRelease;
			int _003C_003E1__state = default(int);
			_003CWaitFrame_003Ed__8 _003CWaitFrame_003Ed__ = new _003CWaitFrame_003Ed__8(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitFrame_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = (_waitFrameCoroutine = StartCoroutine(_003CWaitFrame_003Ed__));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600342E")]
		[Cpp2IlInjected.Address(RVA = "0xF25FB0", Offset = "0xF249B0", VA = "0x180F25FB0")]
		private void Update()
		{
			//Discarded unreachable code: IL_00b4
			//IL_0082: Expected O, but got I4
			float deltaTime;
			InputAction[] array;
			InputAction exitActionRelease;
			while (true)
			{
				int num = 0;
				deltaTime = Time.deltaTime;
				array = new InputAction[2];
				InputAction exitActionPress = _exitActionPress;
				if (exitActionPress == null || array != null)
				{
					array[0] = exitActionPress;
					exitActionRelease = _exitActionRelease;
					if (exitActionRelease == null || array != null)
					{
						break;
					}
				}
			}
			array[1] = exitActionRelease;
			InputAction.UpdateAll(deltaTime, array);
			if (_exitActionPress.IsTriggered)
			{
				if (!_doneWaiting)
				{
					Coroutine waitFrameCoroutine = _waitFrameCoroutine;
					StopCoroutine(waitFrameCoroutine);
				}
				Button btnToClickOnEsc = BtnToClickOnEsc;
				int num2 = 0;
				if (btnToClickOnEsc != (UnityEngine.Object)num2 || EventToTrigger != null)
				{
					BtnToClickOnEsc.m_OnClick.Invoke();
				}
			}
			if (_exitActionRelease.IsTriggered)
			{
				_doneWaiting = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600342F")]
		[Cpp2IlInjected.Address(RVA = "0xF261C0", Offset = "0xF24BC0", VA = "0x180F261C0")]
		[IteratorStateMachine(typeof(_003CWaitFrame_003Ed__8))]
		private IEnumerator WaitFrame()
		{
			int _003C_003E1__state = default(int);
			_003CWaitFrame_003Ed__8 _003CWaitFrame_003Ed__ = new _003CWaitFrame_003Ed__8(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitFrame_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003430")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public EscFonctionality()
		{
		}
	}
}
