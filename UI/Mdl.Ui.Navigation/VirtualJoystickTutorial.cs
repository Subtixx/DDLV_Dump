using System;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace Mdl.Ui.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x200095F")]
	public class VirtualJoystickTutorial : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40037C4")]
		public GameObject handCursor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40037C5")]
		private Sequence _tween;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40037C6")]
		private VirtualJoystick _joystick;

		[Cpp2IlInjected.Token(Token = "0x6003B13")]
		[Cpp2IlInjected.Address(RVA = "0x9BB7F0", Offset = "0x9BA1F0", VA = "0x1809BB7F0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0011
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003B14")]
		[Cpp2IlInjected.Address(RVA = "0x14D6860", Offset = "0x14D5260", VA = "0x1814D6860")]
		internal void Show(VirtualJoystick joystick)
		{
			_joystick = joystick;
			base.gameObject.SetActive(value: true);
			Transform transform = handCursor.transform;
			RectTransform knobBg = joystick.knobBg;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform transform2 = handCursor.transform;
			float z2 = Vector3.zero.z;
			Transform transform3 = handCursor.transform;
			float z3 = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.OutBack);
			int num = 0;
			Sequence s = DOTween.Sequence();
			Transform transform4 = handCursor.transform;
			Transform transform5 = handCursor.transform;
			Transform transform6 = handCursor.transform;
			Vector3 vector2 = default(Vector3);
			float y = vector2.y;
			int num2 = 0;
			TweenerCore<Vector3, Vector3, VectorOptions> t2 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			Sequence t3 = s.Append(t2).AppendInterval(0.3f);
			int loopType = 0;
			Sequence sequence = (_tween = t3.SetLoops(-1, (LoopType)loopType));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B15")]
		[Cpp2IlInjected.Address(RVA = "0x14D6730", Offset = "0x14D5130", VA = "0x1814D6730")]
		internal void Hide()
		{
			//Discarded unreachable code: IL_002a
			//IL_0019: Expected O, but got I8
			Sequence tween = _tween;
			int complete = 0;
			tween.Kill((byte)complete != 0);
			_tween = (Sequence)0;
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003B16")]
		[Cpp2IlInjected.Address(RVA = "0x14D6790", Offset = "0x14D5190", VA = "0x1814D6790")]
		private void LateUpdate()
		{
			//Discarded unreachable code: IL_003b
			//IL_0010: Expected O, but got I4
			VirtualJoystick joystick = _joystick;
			int num = 0;
			if (joystick != (UnityEngine.Object)num)
			{
				VirtualJoystick joystick2 = _joystick;
				GameObject gameObject = handCursor;
				RectTransform knob = joystick2.knob;
				Transform transform = gameObject.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B17")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public VirtualJoystickTutorial()
		{
		}
	}
}
