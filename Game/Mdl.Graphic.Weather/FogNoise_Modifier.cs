using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20004D8")]
	[CreateAssetMenu]
	public class FogNoise_Modifier : WeatherModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E5C")]
		[Space]
		[Header("Noise")]
		[Space(16f)]
		[Tooltip("Noise texture used in the fog. Only the red channel is used.")]
		public Texture2D noise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001E5D")]
		[Tooltip("Tilling of the noise")]
		public float noiseTilling = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4001E5E")]
		[Tooltip("Speed of the noise")]
		public float noiseSpeed = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001E5F")]
		[Tooltip("Amplitude of the noise")]
		public float noiseFactor = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4001E60")]
		private bool enable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001E61")]
		private readonly int evilNoiseID = Shader.PropertyToID("_EvilNoise");

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4001E62")]
		private readonly int evilNoiseInfosID = Shader.PropertyToID("_EvilNoiseInfos");

		[Cpp2IlInjected.Token(Token = "0x170002A9")]
		public override string menuName
		{
			[Cpp2IlInjected.Token(Token = "0x600155B")]
			[Cpp2IlInjected.Address(RVA = "0x145DC10", Offset = "0x145C610", VA = "0x18145DC10", Slot = "4")]
			get
			{
				return "Fog Noise";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600155C")]
		[Cpp2IlInjected.Address(RVA = "0x145DB80", Offset = "0x145C580", VA = "0x18145DB80", Slot = "5")]
		public override void Enable()
		{
			enable = true;
		}

		[Cpp2IlInjected.Token(Token = "0x600155D")]
		[Cpp2IlInjected.Address(RVA = "0x145DB70", Offset = "0x145C570", VA = "0x18145DB70", Slot = "6")]
		public override void Disable()
		{
			enable = false;
		}

		[Cpp2IlInjected.Token(Token = "0x600155E")]
		[Cpp2IlInjected.Address(RVA = "0x145DAF0", Offset = "0x145C4F0", VA = "0x18145DAF0", Slot = "7")]
		public override void BeforeEvaluation(float time, WeatherTimeline mainTimeline, float weight)
		{
			//IL_0032: Expected O, but got I4
			Texture2D value = noise;
			Shader.SetGlobalTextureImpl(evilNoiseID, (Texture)value);
			int nameID = evilNoiseInfosID;
			float num = noiseSpeed;
			int num2 = 0;
			float num3 = noiseTilling;
			Shader.SetGlobalVector(nameID, (Vector4)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x600155F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "8")]
		public override void AfterEvaluation(float time, WeatherTimeline mainTimeline, float weight)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001560")]
		[Cpp2IlInjected.Address(RVA = "0x145DB90", Offset = "0x145C590", VA = "0x18145DB90")]
		public FogNoise_Modifier()
		{
		}
	}
}
