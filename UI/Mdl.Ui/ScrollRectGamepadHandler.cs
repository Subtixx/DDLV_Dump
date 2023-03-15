using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.RewiredConsts;
using Rewired;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000886")]
	public class ScrollRectGamepadHandler : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003274")]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int RewiredAxisX = 146;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4003275")]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int RewiredAxisY = 147;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003276")]
		private List<int> supportedAxisInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003277")]
		public ScrollRect ScrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003278")]
		public LoopScrollRect LoopScrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003279")]
		public float StickInputThreshold = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400327A")]
		public float ScrollSpeed = 6f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400327B")]
		private UiRoot _uiRoot;

		[Cpp2IlInjected.Token(Token = "0x60035D5")]
		[Cpp2IlInjected.Address(RVA = "0x12584C0", Offset = "0x1256EC0", VA = "0x1812584C0")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0076
			//IL_002e: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			if ((long)supportedAxisInputs == 0)
			{
				List<int> list = (supportedAxisInputs = (List<int>)(object)new List<T>(4));
				List<int> list2 = supportedAxisInputs;
				int rewiredAxisX = RewiredAxisX;
				((List<T>)(object)list2).Add((T)rewiredAxisX);
				List<int> list3 = supportedAxisInputs;
				int rewiredAxisY = RewiredAxisY;
				((List<T>)(object)list3).Add((T)rewiredAxisY);
			}
			int num = 0;
			UiRoot uiRoot = (_uiRoot = UiRoot.Instance);
			int _003C_003E1__state = default(int);
			_003COnFocusUpdate_003Ed__11 _003COnFocusUpdate_003Ed__ = new _003COnFocusUpdate_003Ed__11(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnFocusUpdate_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003COnFocusUpdate_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x60035D6")]
		[Cpp2IlInjected.Address(RVA = "0x8B48F0", Offset = "0x8B32F0", VA = "0x1808B48F0")]
		private void OnDisable()
		{
			StopAllCoroutines();
		}

		[Cpp2IlInjected.Token(Token = "0x60035D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B48F0", Offset = "0x8B32F0", VA = "0x1808B48F0")]
		private void OnDestroy()
		{
			StopAllCoroutines();
		}

		[Cpp2IlInjected.Token(Token = "0x60035D8")]
		[Cpp2IlInjected.Address(RVA = "0x1258600", Offset = "0x1257000", VA = "0x181258600")]
		[IteratorStateMachine(typeof(_003COnFocusUpdate_003Ed__11))]
		private IEnumerator OnFocusUpdate()
		{
			int _003C_003E1__state = default(int);
			_003COnFocusUpdate_003Ed__11 _003COnFocusUpdate_003Ed__ = new _003COnFocusUpdate_003Ed__11(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnFocusUpdate_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60035D9")]
		[Cpp2IlInjected.Address(RVA = "0x1258450", Offset = "0x1256E50", VA = "0x181258450")]
		private bool IsInputValid(int input)
		{
			//IL_000d: Expected I4, but got O
			float axis = Input.GetAxis(input);
			return (byte)(int)typeof(Input).TypeHandle != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60035DA")]
		[Cpp2IlInjected.Address(RVA = "0x1258280", Offset = "0x1256C80", VA = "0x181258280")]
		private bool HasValidInput(List<int> inputs)
		{
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			if (flag)
			{
				while ((object)typeof(Input).TypeHandle == null)
				{
				}
				num2++;
			}
			if (num2 + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60035DB")]
		[Cpp2IlInjected.Address(RVA = "0x1258680", Offset = "0x1257080", VA = "0x181258680")]
		public ScrollRectGamepadHandler()
		{
		}//IL_000d: Expected I4, but got I8
		//IL_001a: Expected I4, but got I8

	}
}
