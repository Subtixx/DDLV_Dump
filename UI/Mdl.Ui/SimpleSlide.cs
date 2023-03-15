using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using DG.Tweening;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000209")]
	public class SimpleSlide : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200020A")]
		private enum SlideSide
		{
			[Cpp2IlInjected.Token(Token = "0x40008FD")]
			Top,
			[Cpp2IlInjected.Token(Token = "0x40008FE")]
			Bottom,
			[Cpp2IlInjected.Token(Token = "0x40008FF")]
			Left,
			[Cpp2IlInjected.Token(Token = "0x4000900")]
			Right
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40008F1")]
		[SerializeField]
		private SlideSide _slideType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40008F2")]
		[SerializeField]
		private float _slideEffectTime = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40008F3")]
		private Sequence _tweenSequence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40008F4")]
		private Coroutine _slideCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40008F5")]
		private float _height = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40008F6")]
		private float _width = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40008F7")]
		private float _posX = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40008F8")]
		private float _posY = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40008F9")]
		private float _heightInitial = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40008FA")]
		private float _widthInitial = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40008FB")]
		private RectTransform _rectTransform;

		[Cpp2IlInjected.Token(Token = "0x6000CF7")]
		[Cpp2IlInjected.Address(RVA = "0x15F2970", Offset = "0x15F1370", VA = "0x1815F2970")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0037
			//IL_0028: Expected F4, but got I4
			//IL_0036: Expected F4, but got O
			RectTransform rectTransform = (_rectTransform = GetComponent<RectTransform>());
			Vector2 anchoredPosition = _rectTransform.anchoredPosition;
			RectTransform rectTransform2 = _rectTransform;
			_heightInitial = 0f;
			Vector2 anchoredPosition2 = rectTransform2.anchoredPosition;
			_widthInitial = (float)anchoredPosition2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF8")]
		[Cpp2IlInjected.Address(RVA = "0x15F2940", Offset = "0x15F1340", VA = "0x1815F2940")]
		private void OnDisable()
		{
			Coroutine slideCoroutine = _slideCoroutine;
			if (slideCoroutine != null)
			{
				StopCoroutine(slideCoroutine);
			}
			Sequence tweenSequence = _tweenSequence;
			int complete = 0;
			tweenSequence.Kill((byte)complete != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF9")]
		[Cpp2IlInjected.Address(RVA = "0x15F2A10", Offset = "0x15F1410", VA = "0x1815F2A10")]
		public void ResetPosition()
		{
			//Discarded unreachable code: IL_0016
			RectTransform rectTransform = _rectTransform;
			float widthInitial = _widthInitial;
			float heightInitial = _heightInitial;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CFA")]
		[Cpp2IlInjected.Address(RVA = "0x15F28B0", Offset = "0x15F12B0", VA = "0x1815F28B0")]
		public void DoSlideIn()
		{
			int _003C_003E1__state = default(int);
			_003CSlideIn_003Ed__16 _003CSlideIn_003Ed__ = new _003CSlideIn_003Ed__16(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CSlideIn_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = (_slideCoroutine = StartCoroutine(_003CSlideIn_003Ed__));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CFB")]
		[Cpp2IlInjected.Address(RVA = "0x15F2A50", Offset = "0x15F1450", VA = "0x1815F2A50")]
		[IteratorStateMachine(typeof(_003CSlideIn_003Ed__16))]
		private IEnumerator SlideIn()
		{
			int _003C_003E1__state = default(int);
			_003CSlideIn_003Ed__16 _003CSlideIn_003Ed__ = new _003CSlideIn_003Ed__16(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CSlideIn_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CFC")]
		[Cpp2IlInjected.Address(RVA = "0x15F2AC0", Offset = "0x15F14C0", VA = "0x1815F2AC0")]
		public SimpleSlide()
		{
		}
	}
}
