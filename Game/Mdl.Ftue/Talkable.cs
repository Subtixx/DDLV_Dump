using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Motion;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using UnityEngine;

namespace Mdl.Ftue
{
	[Cpp2IlInjected.Token(Token = "0x2000587")]
	public class Talkable : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002217")]
		public DialogueActor actor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002218")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002219")]
		public Blackboard blackboard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400221A")]
		public Transform targetCameraPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400221B")]
		private Vector3 startingCamPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400221C")]
		private Quaternion startingCamRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400221D")]
		private Tween<float> transition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400221E")]
		private Camera camera;

		[Cpp2IlInjected.Token(Token = "0x60018B2")]
		[Cpp2IlInjected.Address(RVA = "0x106EAB0", Offset = "0x106D4B0", VA = "0x18106EAB0")]
		[AsyncStateMachine(typeof(_003CDoTransition_003Ed__8))]
		public System.Threading.Tasks.Task DoTransition(Camera camera, float duration, EasingFunction easingFunction, CancellationToken ct)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60018B3")]
		[Cpp2IlInjected.Address(RVA = "0x106EC10", Offset = "0x106D610", VA = "0x18106EC10")]
		[IteratorStateMachine(typeof(_003CTransitionCoroutine_003Ed__9))]
		private IEnumerator TransitionCoroutine()
		{
			int _003C_003E1__state = default(int);
			_003CTransitionCoroutine_003Ed__9 _003CTransitionCoroutine_003Ed__ = new _003CTransitionCoroutine_003Ed__9(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CTransitionCoroutine_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60018B4")]
		[Cpp2IlInjected.Address(RVA = "0x106EC80", Offset = "0x106D680", VA = "0x18106EC80")]
		private void UpdateCamera(float value, float progress)
		{
			//Discarded unreachable code: IL_0040
			//IL_002a: Expected O, but got I4
			Transform transform = camera.transform;
			Transform transform2 = targetCameraPos;
			float z = startingCamPosition.z;
			int num = 0;
			transform.position = (Vector3)num;
			Transform transform3 = camera.transform;
			Transform transform4 = targetCameraPos;
		}

		[Cpp2IlInjected.Token(Token = "0x60018B5")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public Talkable()
		{
		}
	}
}
