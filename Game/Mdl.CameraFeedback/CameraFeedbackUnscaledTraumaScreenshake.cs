using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.CameraFeedback
{
	[Cpp2IlInjected.Token(Token = "0x2000945")]
	public class CameraFeedbackUnscaledTraumaScreenshake : CameraFeedbackExtension
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003368")]
		[SerializeField]
		private AnimationCurve traumaCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003369")]
		[SerializeField]
		private Vector3 maxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400336A")]
		[SerializeField]
		private Vector3 maxTranslation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400336B")]
		[SerializeField]
		private float traumaReduction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400336C")]
		[SerializeField]
		private float timeMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400336D")]
		private float trauma;

		[Cpp2IlInjected.Token(Token = "0x6002AB3")]
		[Cpp2IlInjected.Address(RVA = "0x164D170", Offset = "0x164BB70", VA = "0x18164D170", Slot = "6")]
		public override void OnFeedback(ref CameraFeedbackSystem.Modification modification)
		{
			//Discarded unreachable code: IL_0103
			//IL_00f8: Expected F4, but got I4
			AnimationCurve animationCurve = traumaCurve;
			float time = trauma;
			float num = animationCurve.Evaluate(time);
			Quaternion rotation = modification.rotation;
			int num2 = 0;
			float unscaledTime = Time.unscaledTime;
			float y = timeMultiplier;
			float num3 = Mathf.PerlinNoise(42314.152f, y);
			int num4 = 0;
			float unscaledTime2 = Time.unscaledTime;
			float y2 = timeMultiplier;
			float z = Mathf.PerlinNoise(56291.277f, y2);
			int num5 = 0;
			float unscaledTime3 = Time.unscaledTime;
			float y3 = timeMultiplier;
			float x = Mathf.PerlinNoise(16912.246f, y3);
			y3 = num3;
			Quaternion quaternion = Quaternion.Euler(x, y3, z);
			int num6 = 0;
			float unscaledTime4 = Time.unscaledTime;
			float y4 = timeMultiplier;
			float num7 = Mathf.PerlinNoise(78312.76f, y4);
			int num8 = 0;
			num3 = num7;
			float unscaledTime5 = Time.unscaledTime;
			float y5 = timeMultiplier;
			float num9 = Mathf.PerlinNoise(13781.458f, y5);
			z = num9;
			num9 = z;
			num9 = num3;
			int num10 = 0;
			float b = trauma;
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			float num11 = (trauma = Mathf.Max(0f, b));
		}

		[Cpp2IlInjected.Token(Token = "0x6002AB4")]
		[Cpp2IlInjected.Address(RVA = "0x164D140", Offset = "0x164BB40", VA = "0x18164D140", Slot = "7")]
		public override void OnReset()
		{
			trauma = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AB5")]
		[Cpp2IlInjected.Address(RVA = "0x164CE70", Offset = "0x164B870", VA = "0x18164CE70")]
		public void AddTrauma(float trauma)
		{
			this.trauma = trauma;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AB6")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CameraFeedbackUnscaledTraumaScreenshake()
		{
		}
	}
}
