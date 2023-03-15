using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Gestures
{
	[Cpp2IlInjected.Token(Token = "0x2000540")]
	public class MoveGestureTest : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002099")]
		public float friction = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400209A")]
		public float maxForce = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400209B")]
		public float scaleSpeed = 0.01f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400209C")]
		public float minScale = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400209D")]
		public float maxScale = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400209E")]
		[SerializeField]
		private RectTransform _zone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400209F")]
		[SerializeField]
		private RectTransform _inputPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40020A0")]
		private MoveGesture _move;

		[Cpp2IlInjected.Token(Token = "0x600173F")]
		[Cpp2IlInjected.Address(RVA = "0xEFDAC0", Offset = "0xEFC4C0", VA = "0x180EFDAC0")]
		private void Start()
		{
			//IL_0047: Expected O, but got I4
			RectTransform zone = _zone;
			int num = 0;
			MoveGesture moveGesture = default(MoveGesture);
			moveGesture.MaxForce = 0.5f;
			moveGesture.Friction = 0.5f;
			moveGesture.MouseWheelScaleSpeed = 1200f;
			moveGesture.MouseRotationSpeed = 6f;
			moveGesture.JoystickRotationSpeed = 120f;
			moveGesture.ApplyRotation((Vector3)num);
			moveGesture._zone = zone;
			moveGesture._automaticRotation = false;
			_move = moveGesture;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001740")]
		[Cpp2IlInjected.Address(RVA = "0xEFDB80", Offset = "0xEFC580", VA = "0x180EFDB80")]
		private void Update()
		{
			//Discarded unreachable code: IL_00a6
			MoveGesture move = _move;
			float num = (move.Friction = friction);
			MoveGesture move2 = _move;
			float num2 = (move2.MaxForce = maxForce);
			int num3 = 0;
			MoveGesture move3 = _move;
			float deltaTime = Time.deltaTime;
			move3.UpdatePc(deltaTime);
			MoveGesture move4 = _move;
			RectTransform inputPosition = _inputPosition;
			Vector2 _003CLocalPos_003Ek__BackingField = move4.LocalPos;
			float y = move4.LocalPos.y;
			RectTransform inputPosition2 = _inputPosition;
			MoveGesture move5 = _move;
			float num4 = scaleSpeed;
			RectTransform inputPosition3 = _inputPosition;
			MoveGesture move6 = _move;
			RectTransform inputPosition4 = _inputPosition;
			Vector2 _003CLocalAngle_003Ek__BackingField = move6.LocalAngle;
		}

		[Cpp2IlInjected.Token(Token = "0x6001741")]
		[Cpp2IlInjected.Address(RVA = "0xEFDD00", Offset = "0xEFC700", VA = "0x180EFDD00")]
		public MoveGestureTest()
		{
		}
	}
}
