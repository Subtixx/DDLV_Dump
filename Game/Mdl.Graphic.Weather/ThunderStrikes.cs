using System;
using AK.Wwise;
using Cpp2IlInjected;
using Mdl.Graphic.Sky;
using UnityEngine;
using UnityEngine.Rendering;

namespace Mdl.Graphic.Weather
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20004DC")]
	[CreateAssetMenu]
	public class ThunderStrikes : WeatherModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E74")]
		public Vector2 delayBetweenStrikes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001E75")]
		public Vector2 strikeDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001E76")]
		public AnimationCurve[] strikeBrightnessAdditive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001E77")]
		public float strikeBrightnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4001E78")]
		[Range(0f, 1f)]
		public float rainFactorThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001E79")]
		public CloudStaticLibrary lightningClouds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001E7A")]
		public AK.Wwise.Event thunderSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001E7B")]
		private float nextStrikeStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4001E7C")]
		private float currentStrikeLifetime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001E7D")]
		private float currentStrikeDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4001E7E")]
		private int currentStrikeCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001E7F")]
		private Vector2Int currentCloudID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001E80")]
		private float lightningBrightness;

		[Cpp2IlInjected.Token(Token = "0x170002AB")]
		public override string menuName
		{
			[Cpp2IlInjected.Token(Token = "0x600156A")]
			[Cpp2IlInjected.Address(RVA = "0x1075E00", Offset = "0x1074800", VA = "0x181075E00", Slot = "4")]
			get
			{
				return "Thunder Strikes";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600156B")]
		[Cpp2IlInjected.Address(RVA = "0x1075D50", Offset = "0x1074750", VA = "0x181075D50", Slot = "5")]
		public override void Enable()
		{
			nextStrikeStartTime = 0f;
			RenderPipelineManager.add_beginFrameRendering((Action<, >)(object)new Action<T1, T2>(DrawLightning));
		}

		[Cpp2IlInjected.Token(Token = "0x600156C")]
		[Cpp2IlInjected.Address(RVA = "0x1075C40", Offset = "0x1074640", VA = "0x181075C40", Slot = "6")]
		public override void Disable()
		{
			RenderPipelineManager.remove_beginFrameRendering((Action<, >)(object)new Action<T1, T2>(DrawLightning));
		}

		[Cpp2IlInjected.Token(Token = "0x600156D")]
		[Cpp2IlInjected.Address(RVA = "0x1075900", Offset = "0x1074300", VA = "0x181075900", Slot = "7")]
		public override void BeforeEvaluation(float time, WeatherTimeline mainTimeline, float weight)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600156E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "8")]
		public override void AfterEvaluation(float time, WeatherTimeline mainTimeline, float weight)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600156F")]
		[Cpp2IlInjected.Address(RVA = "0x1075CF0", Offset = "0x10746F0", VA = "0x181075CF0")]
		private void DrawLightning(ScriptableRenderContext context, Camera[] cameras)
		{
			//Discarded unreachable code: IL_0037
			int num = 0;
			float deltaTime = Time.deltaTime;
			float num2 = lightningBrightness;
			currentStrikeLifetime = deltaTime;
			if (!(num2 <= 0.1f))
			{
				CloudStaticLibrary cloudStaticLibrary = lightningClouds;
				Vector2Int id = currentCloudID;
				cloudStaticLibrary.DrawOne(id, num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001570")]
		[Cpp2IlInjected.Address(RVA = "0x842E50", Offset = "0x841850", VA = "0x180842E50")]
		public ThunderStrikes()
		{
		}
	}
}
