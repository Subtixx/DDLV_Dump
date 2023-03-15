using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.CameraFeedback
{
	[Cpp2IlInjected.Token(Token = "0x2000944")]
	public class CameraFeedbackTraumaScreenshake : CameraFeedbackExtension
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003362")]
		[SerializeField]
		private AnimationCurve traumaCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003363")]
		[SerializeField]
		private Vector3 maxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4003364")]
		[SerializeField]
		private Vector3 maxTranslation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003365")]
		[SerializeField]
		private float traumaReduction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4003366")]
		[SerializeField]
		private float timeMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003367")]
		private float trauma;

		[Cpp2IlInjected.Token(Token = "0x17000612")]
		public AnimationCurve TraumaCurve
		{
			[Cpp2IlInjected.Token(Token = "0x6002AA5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return traumaCurve;
			}
			[Cpp2IlInjected.Token(Token = "0x6002AA6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				traumaCurve = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000613")]
		public unsafe Vector3 MaxAngle
		{
			[Cpp2IlInjected.Token(Token = "0x6002AA7")]
			[Cpp2IlInjected.Address(RVA = "0x164D150", Offset = "0x164BB50", VA = "0x18164D150")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6002AA8")]
			[Cpp2IlInjected.Address(RVA = "0xCB8060", Offset = "0xCB6A60", VA = "0x180CB8060")]
			set
			{
				//IL_000e: Expected native int or pointer, but got O
				float z = value.z;
				((Vector3*)(IntPtr)maxAngle)->z = z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000614")]
		public unsafe Vector3 MaxTranslation
		{
			[Cpp2IlInjected.Token(Token = "0x6002AA9")]
			[Cpp2IlInjected.Address(RVA = "0x137EEB0", Offset = "0x137D8B0", VA = "0x18137EEB0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6002AAA")]
			[Cpp2IlInjected.Address(RVA = "0x137EED0", Offset = "0x137D8D0", VA = "0x18137EED0")]
			set
			{
				//IL_000e: Expected native int or pointer, but got O
				float z = value.z;
				((Vector3*)(IntPtr)maxTranslation)->z = z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000615")]
		public float TraumaReduction
		{
			[Cpp2IlInjected.Token(Token = "0x6002AAB")]
			[Cpp2IlInjected.Address(RVA = "0x823CC0", Offset = "0x8226C0", VA = "0x180823CC0")]
			get
			{
				return traumaReduction;
			}
			[Cpp2IlInjected.Token(Token = "0x6002AAC")]
			[Cpp2IlInjected.Address(RVA = "0x824250", Offset = "0x822C50", VA = "0x180824250")]
			set
			{
				traumaReduction = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000616")]
		public float TimeMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6002AAD")]
			[Cpp2IlInjected.Address(RVA = "0xD392E0", Offset = "0xD37CE0", VA = "0x180D392E0")]
			get
			{
				return timeMultiplier;
			}
			[Cpp2IlInjected.Token(Token = "0x6002AAE")]
			[Cpp2IlInjected.Address(RVA = "0xEFF4C0", Offset = "0xEFDEC0", VA = "0x180EFF4C0")]
			set
			{
				timeMultiplier = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AAF")]
		[Cpp2IlInjected.Address(RVA = "0x164CE80", Offset = "0x164B880", VA = "0x18164CE80", Slot = "6")]
		public override void OnFeedback(ref CameraFeedbackSystem.Modification modification)
		{
			//Discarded unreachable code: IL_0103
			//IL_00f8: Expected F4, but got I4
			AnimationCurve animationCurve = traumaCurve;
			float time = trauma;
			float num = animationCurve.Evaluate(time);
			Quaternion rotation = modification.rotation;
			int num2 = 0;
			float time2 = Time.time;
			float y = timeMultiplier;
			float num3 = Mathf.PerlinNoise(4234.1533f, y);
			int num4 = 0;
			float time3 = Time.time;
			float y2 = timeMultiplier;
			float z = Mathf.PerlinNoise(5291.2783f, y2);
			int num5 = 0;
			float time4 = Time.time;
			float y3 = timeMultiplier;
			float x = Mathf.PerlinNoise(1612.2456f, y3);
			y3 = num3;
			Quaternion quaternion = Quaternion.Euler(x, y3, z);
			int num6 = 0;
			float time5 = Time.time;
			float y4 = timeMultiplier;
			float num7 = Mathf.PerlinNoise(7812.754f, y4);
			int num8 = 0;
			num3 = num7;
			float time6 = Time.time;
			float y5 = timeMultiplier;
			float num9 = Mathf.PerlinNoise(1371.4575f, y5);
			z = num9;
			num9 = z;
			num9 = num3;
			int num10 = 0;
			float b = trauma;
			float deltaTime = Time.deltaTime;
			float num11 = (trauma = Mathf.Max(0f, b));
		}

		[Cpp2IlInjected.Token(Token = "0x6002AB0")]
		[Cpp2IlInjected.Address(RVA = "0x164D140", Offset = "0x164BB40", VA = "0x18164D140", Slot = "7")]
		public override void OnReset()
		{
			trauma = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AB1")]
		[Cpp2IlInjected.Address(RVA = "0x164CE70", Offset = "0x164B870", VA = "0x18164CE70")]
		public void AddTrauma(float trauma)
		{
			this.trauma = trauma;
		}

		[Cpp2IlInjected.Token(Token = "0x6002AB2")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CameraFeedbackTraumaScreenshake()
		{
		}
	}
}
