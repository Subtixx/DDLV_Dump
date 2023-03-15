using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000274")]
	public class PressAnyKey : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000B21")]
		[SerializeField]
		[Tooltip("Whether we check for inputs when gameobject enabled or not.")]
		private bool _checkOnEnabled = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000B22")]
		public UnityEvent OnAnyKeyPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000B23")]
		private Coroutine _waitingForAnyKey;

		[Cpp2IlInjected.Token(Token = "0x6000FA1")]
		[Cpp2IlInjected.Address(RVA = "0xE1AFC0", Offset = "0xE199C0", VA = "0x180E1AFC0")]
		private void OnEnable()
		{
			if (_checkOnEnabled)
			{
				StartCheckForAnyInput();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FA2")]
		[Cpp2IlInjected.Address(RVA = "0xE1AF80", Offset = "0xE19980", VA = "0x180E1AF80")]
		private void OnDisable()
		{
			Coroutine waitingForAnyKey = _waitingForAnyKey;
			if (waitingForAnyKey != null)
			{
				StopCoroutine(waitingForAnyKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FA3")]
		[Cpp2IlInjected.Address(RVA = "0xE1AF80", Offset = "0xE19980", VA = "0x180E1AF80")]
		private void StopCheckForAnyInput()
		{
			Coroutine waitingForAnyKey = _waitingForAnyKey;
			if (waitingForAnyKey != null)
			{
				StopCoroutine(waitingForAnyKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FA4")]
		[Cpp2IlInjected.Address(RVA = "0xE1AFD0", Offset = "0xE199D0", VA = "0x180E1AFD0")]
		public void StartCheckForAnyInput()
		{
			//IL_001b: Expected O, but got I8
			Coroutine waitingForAnyKey = _waitingForAnyKey;
			if (waitingForAnyKey != null)
			{
				StopCoroutine(waitingForAnyKey);
				_waitingForAnyKey = (Coroutine)0;
			}
			Action action = delegate
			{
				//Discarded unreachable code: IL_000c
				OnAnyKeyPressed.Invoke();
			};
			int _003C_003E1__state = default(int);
			_003CWaitForAnyInputsCoroutine_003Ed__7 _003CWaitForAnyInputsCoroutine_003Ed__ = new _003CWaitForAnyInputsCoroutine_003Ed__7(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitForAnyInputsCoroutine_003Ed__._003C_003E4__this = this;
			_003CWaitForAnyInputsCoroutine_003Ed__.action = action;
			Coroutine coroutine = (_waitingForAnyKey = StartCoroutine(_003CWaitForAnyInputsCoroutine_003Ed__));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FA5")]
		[Cpp2IlInjected.Address(RVA = "0xE1B110", Offset = "0xE19B10", VA = "0x180E1B110")]
		[IteratorStateMachine(typeof(_003CWaitForAnyInputsCoroutine_003Ed__7))]
		private IEnumerator WaitForAnyInputsCoroutine(Action action)
		{
			int _003C_003E1__state = default(int);
			_003CWaitForAnyInputsCoroutine_003Ed__7 _003CWaitForAnyInputsCoroutine_003Ed__ = new _003CWaitForAnyInputsCoroutine_003Ed__7(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitForAnyInputsCoroutine_003Ed__._003C_003E4__this = this;
			_003CWaitForAnyInputsCoroutine_003Ed__.action = action;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FA6")]
		[Cpp2IlInjected.Address(RVA = "0x8CA520", Offset = "0x8C8F20", VA = "0x1808CA520")]
		public PressAnyKey()
		{
		}
	}
}
