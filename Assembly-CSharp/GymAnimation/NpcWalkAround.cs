using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Characters;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GymAnimation
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class NpcWalkAround : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public Transform forward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Transform backward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Transform left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Transform right;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Button forwardBackwardButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Button sideToSideButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Button randomButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Button stopButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Character[] characters;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1E96820", Offset = "0x1E95220", VA = "0x181E96820")]
		private void Start()
		{
			//Discarded unreachable code: IL_0089
			Button.ButtonClickedEvent onClick = forwardBackwardButton.m_OnClick;
			UnityAction call = MoveForwardBackward;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = sideToSideButton.m_OnClick;
			UnityAction call2 = MoveSideToSide;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = randomButton.m_OnClick;
			UnityAction call3 = MoveRandom;
			onClick3.AddListener(call3);
			Button.ButtonClickedEvent onClick4 = stopButton.m_OnClick;
			UnityAction call4 = Stop;
			onClick4.AddListener(call4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1E969D0", Offset = "0x1E953D0", VA = "0x181E969D0")]
		private void Stop()
		{
			//Discarded unreachable code: IL_006e
			StopAllCoroutines();
			Character[] array = characters;
			if (array != null)
			{
				int num = 0;
				int length = array.Length;
				if (num < length)
				{
					Character character = array[num];
					Animator componentInChildren = character.GetComponentInChildren<Animator>();
					int value = 0;
					componentInChildren.SetBool("Move", (byte)value != 0);
					Transform _003Ctransform_003Ek__BackingField = character.transform;
					float z = Vector3.zero.z;
					Transform _003Ctransform_003Ek__BackingField2 = character.transform;
					Quaternion identity = Quaternion.identity;
					character.enabled = true;
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1E96270", Offset = "0x1E94C70", VA = "0x181E96270")]
		private void MoveForwardBackward()
		{
			//Discarded unreachable code: IL_0063
			StopAllCoroutines();
			Character[] array = (characters = UnityEngine.Object.FindObjectsOfType<Character>());
			Character[] array2 = characters;
			if (array2 != null)
			{
				int num = 0;
				int length = array2.Length;
				if (num < length)
				{
					Character character = array2[num];
					_003CMoveForwardBackwardAsync_003Ed__12 _003CMoveForwardBackwardAsync_003Ed__ = default(_003CMoveForwardBackwardAsync_003Ed__12);
					((IDisposable)_003CMoveForwardBackwardAsync_003Ed__).Dispose();
					_003CMoveForwardBackwardAsync_003Ed__._003C_003E4__this = this;
					_003CMoveForwardBackwardAsync_003Ed__._003C_003E1__state = num;
					_003CMoveForwardBackwardAsync_003Ed__.character = character;
					Coroutine coroutine = StartCoroutine(_003CMoveForwardBackwardAsync_003Ed__);
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1E961E0", Offset = "0x1E94BE0", VA = "0x181E961E0")]
		[IteratorStateMachine(typeof(_003CMoveForwardBackwardAsync_003Ed__12))]
		private IEnumerator MoveForwardBackwardAsync(Character character)
		{
			//IL_0016: Expected I4, but got I8
			_003CMoveForwardBackwardAsync_003Ed__12 _003CMoveForwardBackwardAsync_003Ed__ = default(_003CMoveForwardBackwardAsync_003Ed__12);
			((IDisposable)_003CMoveForwardBackwardAsync_003Ed__).Dispose();
			_003CMoveForwardBackwardAsync_003Ed__._003C_003E4__this = this;
			_003CMoveForwardBackwardAsync_003Ed__._003C_003E1__state = 0;
			_003CMoveForwardBackwardAsync_003Ed__.character = character;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1E96630", Offset = "0x1E95030", VA = "0x181E96630")]
		private void MoveSideToSide()
		{
			//Discarded unreachable code: IL_0063
			StopAllCoroutines();
			Character[] array = (characters = UnityEngine.Object.FindObjectsOfType<Character>());
			Character[] array2 = characters;
			if (array2 != null)
			{
				int num = 0;
				int length = array2.Length;
				if (num < length)
				{
					Character character = array2[num];
					_003CMoveSideToSideAsync_003Ed__14 _003CMoveSideToSideAsync_003Ed__ = default(_003CMoveSideToSideAsync_003Ed__14);
					((IDisposable)_003CMoveSideToSideAsync_003Ed__).Dispose();
					_003CMoveSideToSideAsync_003Ed__._003C_003E4__this = this;
					_003CMoveSideToSideAsync_003Ed__._003C_003E1__state = num;
					_003CMoveSideToSideAsync_003Ed__.character = character;
					Coroutine coroutine = StartCoroutine(_003CMoveSideToSideAsync_003Ed__);
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1E965A0", Offset = "0x1E94FA0", VA = "0x181E965A0")]
		[IteratorStateMachine(typeof(_003CMoveSideToSideAsync_003Ed__14))]
		private IEnumerator MoveSideToSideAsync(Character character)
		{
			//IL_0016: Expected I4, but got I8
			_003CMoveSideToSideAsync_003Ed__14 _003CMoveSideToSideAsync_003Ed__ = default(_003CMoveSideToSideAsync_003Ed__14);
			((IDisposable)_003CMoveSideToSideAsync_003Ed__).Dispose();
			_003CMoveSideToSideAsync_003Ed__._003C_003E4__this = this;
			_003CMoveSideToSideAsync_003Ed__._003C_003E1__state = 0;
			_003CMoveSideToSideAsync_003Ed__.character = character;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1E96450", Offset = "0x1E94E50", VA = "0x181E96450")]
		private void MoveRandom()
		{
			//Discarded unreachable code: IL_0063
			StopAllCoroutines();
			Character[] array = (characters = UnityEngine.Object.FindObjectsOfType<Character>());
			Character[] array2 = characters;
			if (array2 != null)
			{
				int num = 0;
				int length = array2.Length;
				if (num < length)
				{
					Character character = array2[num];
					_003CMoveRandomAsync_003Ed__16 _003CMoveRandomAsync_003Ed__ = default(_003CMoveRandomAsync_003Ed__16);
					((IDisposable)_003CMoveRandomAsync_003Ed__).Dispose();
					_003CMoveRandomAsync_003Ed__._003C_003E4__this = this;
					_003CMoveRandomAsync_003Ed__._003C_003E1__state = num;
					_003CMoveRandomAsync_003Ed__.character = character;
					Coroutine coroutine = StartCoroutine(_003CMoveRandomAsync_003Ed__);
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1E963C0", Offset = "0x1E94DC0", VA = "0x181E963C0")]
		[IteratorStateMachine(typeof(_003CMoveRandomAsync_003Ed__16))]
		private IEnumerator MoveRandomAsync(Character character)
		{
			//IL_0016: Expected I4, but got I8
			_003CMoveRandomAsync_003Ed__16 _003CMoveRandomAsync_003Ed__ = default(_003CMoveRandomAsync_003Ed__16);
			((IDisposable)_003CMoveRandomAsync_003Ed__).Dispose();
			_003CMoveRandomAsync_003Ed__._003C_003E4__this = this;
			_003CMoveRandomAsync_003Ed__._003C_003E1__state = 0;
			_003CMoveRandomAsync_003Ed__.character = character;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1E96780", Offset = "0x1E95180", VA = "0x181E96780")]
		[IteratorStateMachine(typeof(_003CMoveTo_003Ed__17))]
		private unsafe IEnumerator MoveTo(Character character, Vector3 dest, float speed)
		{
			//IL_0016: Expected I4, but got I8
			//IL_002b: Expected native int or pointer, but got O
			_003CMoveTo_003Ed__17 _003CMoveTo_003Ed__ = default(_003CMoveTo_003Ed__17);
			((IDisposable)_003CMoveTo_003Ed__).Dispose();
			_003CMoveTo_003Ed__.character = character;
			_003CMoveTo_003Ed__._003C_003E1__state = 0;
			float z = dest.z;
			_003CMoveTo_003Ed__.speed = speed;
			((Vector3*)(IntPtr)_003CMoveTo_003Ed__.dest)->z = z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public NpcWalkAround()
		{
		}
	}
}
