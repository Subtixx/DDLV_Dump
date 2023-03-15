using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using DG.Tweening;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002B5")]
	[RequiredAllNotNull]
	public class MoanaBoatFish : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000C6D")]
		[SerializeField]
		private RectTransform _mcHead;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000C6E")]
		[SerializeField]
		private RectTransform _mcTail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000C6F")]
		[SerializeField]
		private RectTransform _mcBody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000C70")]
		[SerializeField]
		private float _delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000C71")]
		[SerializeField]
		private float _bodyDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000C72")]
		private Sequence _tweenBody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000C73")]
		private Sequence _tweenHead;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000C74")]
		private Sequence _tweenTail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000C75")]
		[SerializeField]
		private int displace = 10;

		[Cpp2IlInjected.Token(Token = "0x600110B")]
		[Cpp2IlInjected.Address(RVA = "0x1293D00", Offset = "0x1292700", VA = "0x181293D00")]
		public void StartAnimation()
		{
			//Discarded unreachable code: IL_001f
			base.gameObject.SetActive(value: true);
			StopAllCoroutines();
			Animate();
			AnimateBody();
		}

		[Cpp2IlInjected.Token(Token = "0x600110C")]
		[Cpp2IlInjected.Address(RVA = "0x1293C10", Offset = "0x1292610", VA = "0x181293C10")]
		private void Animate()
		{
			//Discarded unreachable code: IL_0022
			if (base.isActiveAndEnabled)
			{
				int _003C_003E1__state = default(int);
				_003CAnimateCoroutine_003Ed__12 _003CAnimateCoroutine_003Ed__ = new _003CAnimateCoroutine_003Ed__12(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CAnimateCoroutine_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = StartCoroutine(_003CAnimateCoroutine_003Ed__);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600110D")]
		[Cpp2IlInjected.Address(RVA = "0x1293B10", Offset = "0x1292510", VA = "0x181293B10")]
		private void AnimateBody()
		{
			//Discarded unreachable code: IL_0022
			if (base.isActiveAndEnabled)
			{
				int _003C_003E1__state = default(int);
				_003CAnimateBodyCoroutine_003Ed__13 _003CAnimateBodyCoroutine_003Ed__ = new _003CAnimateBodyCoroutine_003Ed__13(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CAnimateBodyCoroutine_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = StartCoroutine(_003CAnimateBodyCoroutine_003Ed__);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600110E")]
		[Cpp2IlInjected.Address(RVA = "0x1293BA0", Offset = "0x12925A0", VA = "0x181293BA0")]
		[IteratorStateMachine(typeof(_003CAnimateCoroutine_003Ed__12))]
		private IEnumerator AnimateCoroutine()
		{
			int _003C_003E1__state = default(int);
			_003CAnimateCoroutine_003Ed__12 _003CAnimateCoroutine_003Ed__ = new _003CAnimateCoroutine_003Ed__12(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CAnimateCoroutine_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600110F")]
		[Cpp2IlInjected.Address(RVA = "0x1293AA0", Offset = "0x12924A0", VA = "0x181293AA0")]
		[IteratorStateMachine(typeof(_003CAnimateBodyCoroutine_003Ed__13))]
		private IEnumerator AnimateBodyCoroutine()
		{
			int _003C_003E1__state = default(int);
			_003CAnimateBodyCoroutine_003Ed__13 _003CAnimateBodyCoroutine_003Ed__ = new _003CAnimateBodyCoroutine_003Ed__13(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CAnimateBodyCoroutine_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001110")]
		[Cpp2IlInjected.Address(RVA = "0x1293CA0", Offset = "0x12926A0", VA = "0x181293CA0")]
		private void OnDestroy()
		{
			Sequence tweenHead = _tweenHead;
			if (tweenHead != null)
			{
				int complete = 0;
				tweenHead.Kill((byte)complete != 0);
			}
			Sequence tweenTail = _tweenTail;
			if (tweenTail != null)
			{
				int complete2 = 0;
				tweenTail.Kill((byte)complete2 != 0);
			}
			Sequence tweenBody = _tweenBody;
			if (tweenBody != null)
			{
				int complete3 = 0;
				tweenBody.Kill((byte)complete3 != 0);
			}
			StopAllCoroutines();
		}

		[Cpp2IlInjected.Token(Token = "0x6001111")]
		[Cpp2IlInjected.Address(RVA = "0x1293D70", Offset = "0x1292770", VA = "0x181293D70")]
		public MoanaBoatFish()
		{
		}//IL_000a: Expected I4, but got I8

	}
}
