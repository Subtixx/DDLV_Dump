using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.CameraFeedback
{
	[Cpp2IlInjected.Token(Token = "0x2000943")]
	public class CameraFeedbackRotationNoise : CameraFeedbackExtension
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400335A")]
		[SerializeField]
		private Vector3 amplitude;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400335B")]
		[SerializeField]
		private Vector3 frequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400335C")]
		[SerializeField]
		private Vector3 delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400335D")]
		[SerializeField]
		private float lerp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400335E")]
		private Quaternion _desiredRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400335F")]
		private Quaternion _currentRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003360")]
		private float amplitudeMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4003361")]
		private float frequencyMultiplier;

		[Cpp2IlInjected.Token(Token = "0x6002A9F")]
		[Cpp2IlInjected.Address(RVA = "0x164C190", Offset = "0x164AB90", VA = "0x18164C190")]
		private Quaternion Compute()
		{
			int num = 0;
			float time = Time.time;
			int num2 = 0;
			float time2 = Time.time;
			int num3 = 0;
			float time3 = Time.time;
			float x = default(float);
			float y = default(float);
			float z = default(float);
			Quaternion quaternion = Quaternion.Euler(x, y, z);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AA0")]
		[Cpp2IlInjected.Address(RVA = "0x164C300", Offset = "0x164AD00", VA = "0x18164C300", Slot = "6")]
		public override void OnFeedback(ref CameraFeedbackSystem.Modification modification)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected F4, but got Unknown
			//IL_003b: Expected O, but got F4
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected F4, but got Unknown
			//IL_0066: Expected O, but got F4
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected F4, but got Unknown
			//IL_007a: Expected O, but got F4
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Expected O, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected F4, but got Unknown
			//IL_00ce: Expected F4, but got I4
			//IL_00f4: Expected F4, but got I4
			int num = 0;
			float time = Time.time;
			float num2 = ((CameraFeedbackRotationNoise)frequency).frequencyMultiplier;
			float y = /*Error near IL_0014: Stack underflow*/* num2;
			float y2 = Mathf.PerlinNoise(42314.152f, y);
			int num3 = 0;
			float time2 = Time.time;
			float num4 = ((CameraFeedbackRotationNoise)frequency.y).frequencyMultiplier;
			float y3 = /*Error near IL_003c: Stack underflow*/* num4;
			float z = Mathf.PerlinNoise(56291.277f, y3);
			int num5 = 0;
			float time3 = Time.time;
			float num6 = ((CameraFeedbackRotationNoise)frequency.z).frequencyMultiplier;
			float y4 = /*Error near IL_0067: Stack underflow*/* num6;
			float z2 = ((CameraFeedbackRotationNoise)Mathf.PerlinNoise(16912.246f, y4)).amplitude.z;
			float num7 = ((CameraFeedbackRotationNoise)(/*Error near IL_0080: Stack underflow*/ * z2)).amplitudeMultiplier;
			Quaternion quaternion = Quaternion.Euler(/*Error near IL_0086: Stack underflow*/ * num7, y2, z);
			Quaternion currentRotation = _currentRotation;
			int num8 = 0;
			float deltaTime = Time.deltaTime;
			Quaternion rotation = modification.rotation;
			int num9 = 0;
			float b = amplitudeMultiplier;
			float deltaTime2 = Time.deltaTime;
			float t = lerp;
			b = Mathf.Lerp(0f, b, t);
			int num10 = 0;
			amplitudeMultiplier = b;
			float deltaTime3 = Time.deltaTime;
			float t2 = lerp;
			float num11 = (frequencyMultiplier = Mathf.Lerp(0f, b, t2));
		}

		[Cpp2IlInjected.Token(Token = "0x6002AA1")]
		[Cpp2IlInjected.Address(RVA = "0x164C540", Offset = "0x164AF40", VA = "0x18164C540", Slot = "7")]
		public override void OnReset()
		{
			//IL_0009: Expected F4, but got I4
			int num = 0;
			amplitudeMultiplier = num;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AA2")]
		[Cpp2IlInjected.Address(RVA = "0x164C550", Offset = "0x164AF50", VA = "0x18164C550")]
		public CameraFeedbackRotationNoise SetAmplitude(float value)
		{
			amplitudeMultiplier = value;
			return this;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AA3")]
		[Cpp2IlInjected.Address(RVA = "0x164C560", Offset = "0x164AF60", VA = "0x18164C560")]
		public CameraFeedbackRotationNoise SetFrequency(float value)
		{
			frequencyMultiplier = value;
			return this;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AA4")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CameraFeedbackRotationNoise()
		{
		}
	}
}
