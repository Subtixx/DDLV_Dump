using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B2D")]
	internal class CameraRelativeShake : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003E28")]
		private Vector3 originalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003E29")]
		[SerializeField]
		private AnimationCurve shakeFrequencyCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003E2A")]
		[SerializeField]
		private AnimationCurve shakeAmplitudeCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003E2B")]
		private Camera camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003E2C")]
		private float elapsed;

		[Cpp2IlInjected.Token(Token = "0x600338B")]
		[Cpp2IlInjected.Address(RVA = "0x12D6860", Offset = "0x12D5260", VA = "0x1812D6860")]
		public unsafe void StartShake(Camera camera)
		{
			//Discarded unreachable code: IL_0039
			//IL_001a: Expected native int or pointer, but got O
			Transform transform = base.gameObject.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)originalPosition)->z = z;
			this.camera = camera;
			base.enabled = true;
			elapsed = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x600338C")]
		[Cpp2IlInjected.Address(RVA = "0x12D68E0", Offset = "0x12D52E0", VA = "0x1812D68E0")]
		private void Update()
		{
			//Discarded unreachable code: IL_0075
			//IL_0074: Expected O, but got I4
			int num = 0;
			float deltaTime = Time.deltaTime;
			Camera camera = this.camera;
			elapsed = deltaTime;
			Transform transform = camera.transform;
			AnimationCurve animationCurve = shakeFrequencyCurve;
			float time = elapsed;
			float num2 = animationCurve.Evaluate(time);
			AnimationCurve animationCurve2 = shakeAmplitudeCurve;
			float num3 = elapsed;
			float num4 = animationCurve2.Evaluate(num3);
			GameObject gameObject = base.gameObject;
			int num5 = 0;
			Transform transform2 = gameObject.transform;
			num4 = num3;
			transform2.position = (Vector3)num5;
		}

		[Cpp2IlInjected.Token(Token = "0x600338D")]
		[Cpp2IlInjected.Address(RVA = "0x12D67F0", Offset = "0x12D51F0", VA = "0x1812D67F0")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0022
			//IL_0009: Expected O, but got I8
			camera = (Camera)0;
			Transform transform = base.gameObject.transform;
			float z = originalPosition.z;
		}

		[Cpp2IlInjected.Token(Token = "0x600338E")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CameraRelativeShake()
		{
		}
	}
}
