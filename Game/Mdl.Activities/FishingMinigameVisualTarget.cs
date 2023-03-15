using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B3F")]
	internal class FishingMinigameVisualTarget : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003E8F")]
		[Category]
		[SerializeField]
		private SpriteRenderer waitingCircle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003E90")]
		[Category]
		[SerializeField]
		private SpriteRenderer triggerCircle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003E91")]
		[Category]
		[SerializeField]
		private SpriteRenderer failCircle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003E92")]
		[SerializeField]
		private float fadeInDuration = 0.15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4003E93")]
		[SerializeField]
		private float fadeOutDuration = 0.3f;

		[Cpp2IlInjected.Token(Token = "0x60033FB")]
		[Cpp2IlInjected.Address(RVA = "0x1376EF0", Offset = "0x13758F0", VA = "0x181376EF0")]
		public void StartRound()
		{
			//Discarded unreachable code: IL_0058
			//IL_0019: Expected O, but got I4
			//IL_0019: Expected F4, but got I4
			float duration = fadeInDuration;
			int num = 0;
			int num2 = 0;
			IEnumerator routine = Fading(num2, 1f, duration, (Action)num);
			Coroutine coroutine = StartCoroutine(routine);
			waitingCircle.enabled = true;
			SpriteRenderer spriteRenderer = triggerCircle;
			int num3 = ((spriteRenderer.enabled = false) ? 1 : 0);
			SpriteRenderer spriteRenderer2 = failCircle;
			int num4 = ((spriteRenderer2.enabled = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60033FC")]
		[Cpp2IlInjected.Address(RVA = "0x1376CE0", Offset = "0x13756E0", VA = "0x181376CE0")]
		public void EnterTrigger()
		{
			//Discarded unreachable code: IL_002d
			SpriteRenderer spriteRenderer = waitingCircle;
			int num = ((spriteRenderer.enabled = false) ? 1 : 0);
			triggerCircle.enabled = true;
			SpriteRenderer spriteRenderer2 = failCircle;
			int num2 = ((spriteRenderer2.enabled = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60033FD")]
		[Cpp2IlInjected.Address(RVA = "0x1376CE0", Offset = "0x13756E0", VA = "0x181376CE0")]
		public void ExitTrigger()
		{
			//Discarded unreachable code: IL_002d
			SpriteRenderer spriteRenderer = waitingCircle;
			int num = ((spriteRenderer.enabled = false) ? 1 : 0);
			triggerCircle.enabled = true;
			SpriteRenderer spriteRenderer2 = failCircle;
			int num2 = ((spriteRenderer2.enabled = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60033FE")]
		[Cpp2IlInjected.Address(RVA = "0x1376CA0", Offset = "0x13756A0", VA = "0x181376CA0")]
		public void EndRound()
		{
			//IL_0019: Expected O, but got I4
			//IL_0019: Expected F4, but got I4
			float duration = fadeOutDuration;
			int num = 0;
			int num2 = 0;
			IEnumerator routine = Fading(1f, num2, duration, (Action)num);
			Coroutine coroutine = StartCoroutine(routine);
		}

		[Cpp2IlInjected.Token(Token = "0x60033FF")]
		[Cpp2IlInjected.Address(RVA = "0x1376E70", Offset = "0x1375870", VA = "0x181376E70")]
		public void Fail()
		{
			//Discarded unreachable code: IL_0058
			//IL_0019: Expected O, but got I4
			//IL_0019: Expected F4, but got I4
			float duration = fadeOutDuration;
			int num = 0;
			int num2 = 0;
			IEnumerator routine = Fading(1f, num2, duration, (Action)num);
			Coroutine coroutine = StartCoroutine(routine);
			SpriteRenderer spriteRenderer = waitingCircle;
			int num3 = ((spriteRenderer.enabled = false) ? 1 : 0);
			SpriteRenderer spriteRenderer2 = triggerCircle;
			int num4 = ((spriteRenderer2.enabled = false) ? 1 : 0);
			failCircle.enabled = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003400")]
		[Cpp2IlInjected.Address(RVA = "0x1376D30", Offset = "0x1375730", VA = "0x181376D30")]
		private void FadeIn()
		{
			//IL_0019: Expected O, but got I4
			//IL_0019: Expected F4, but got I4
			float duration = fadeInDuration;
			int num = 0;
			int num2 = 0;
			IEnumerator routine = Fading(num2, 1f, duration, (Action)num);
			Coroutine coroutine = StartCoroutine(routine);
		}

		[Cpp2IlInjected.Token(Token = "0x6003401")]
		[Cpp2IlInjected.Address(RVA = "0x1376D70", Offset = "0x1375770", VA = "0x181376D70")]
		private void FadeOut([Optional] Action callback)
		{
			//IL_0017: Expected F4, but got I4
			float duration = fadeOutDuration;
			int num = 0;
			IEnumerator routine = Fading(1f, num, duration, callback);
			Coroutine coroutine = StartCoroutine(routine);
		}

		[Cpp2IlInjected.Token(Token = "0x6003402")]
		[Cpp2IlInjected.Address(RVA = "0x1376DB0", Offset = "0x13757B0", VA = "0x181376DB0")]
		[IteratorStateMachine(typeof(_003CFading_003Ed__12))]
		private IEnumerator Fading(float from, float to, float duration, Action callback)
		{
			//IL_0017: Expected O, but got I4
			int _003C_003E1__state = default(int);
			_003CFading_003Ed__12 _003CFading_003Ed__ = new _003CFading_003Ed__12(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CFading_003Ed__._003C_003E4__this = this;
			_003CFading_003Ed__.callback = (Action)0;
			_003CFading_003Ed__.from = from;
			_003CFading_003Ed__.to = to;
			_003CFading_003Ed__.duration = duration;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003403")]
		[Cpp2IlInjected.Address(RVA = "0x1376F70", Offset = "0x1375970", VA = "0x181376F70")]
		public FishingMinigameVisualTarget()
		{
		}
	}
}
