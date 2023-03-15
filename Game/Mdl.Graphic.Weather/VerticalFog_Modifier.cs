using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x20004DF")]
	[CreateAssetMenu]
	public class VerticalFog_Modifier : WeatherModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E87")]
		public Vector3 center;

		[Cpp2IlInjected.Token(Token = "0x170002AD")]
		public override string menuName
		{
			[Cpp2IlInjected.Token(Token = "0x6001577")]
			[Cpp2IlInjected.Address(RVA = "0xD462F0", Offset = "0xD44CF0", VA = "0x180D462F0", Slot = "4")]
			get
			{
				return "Vertical Fog";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001578")]
		[Cpp2IlInjected.Address(RVA = "0xD46230", Offset = "0xD44C30", VA = "0x180D46230", Slot = "6")]
		public override void Disable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001579")]
		[Cpp2IlInjected.Address(RVA = "0xD46290", Offset = "0xD44C90", VA = "0x180D46290", Slot = "5")]
		public override void Enable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600157A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void BeforeEvaluation(float time, WeatherTimeline mainTimeline, float weight)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600157B")]
		[Cpp2IlInjected.Address(RVA = "0xD45D90", Offset = "0xD44790", VA = "0x180D45D90", Slot = "8")]
		public override void AfterEvaluation(float time, WeatherTimeline mainTimeline, float weight)
		{
			//Discarded unreachable code: IL_00cd
			//IL_0013: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			//IL_008d: Expected O, but got I4
			//IL_00cc: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			Transform anchor = WeatherController.anchor;
			int num3 = 0;
			if (anchor == (Object)num3)
			{
				int num4 = 0;
				WeatherController.ResetAnchor();
			}
			Transform anchor2 = WeatherController.anchor;
			int num5 = 0;
			if (!(anchor2 == (Object)num5))
			{
				Transform anchor3 = WeatherController.anchor;
			}
			int num6 = 0;
			float z = center.z;
			float @float = mainTimeline.GetFloat("heightFogNearRange");
			float float2 = mainTimeline.GetFloat("heightFogNearHeight");
			float float3 = mainTimeline.GetFloat("heightFogNearFalloff");
			float float4 = mainTimeline.GetFloat("fogSkyColorsDistance");
			int num7 = 0;
			Shader.SetGlobalVector(WeatherIDs._HF_NearInfos, (Vector4)num);
			@float = mainTimeline.GetFloat("heightFogFarRange");
			float2 = mainTimeline.GetFloat("heightFogFarHeight");
			float3 = mainTimeline.GetFloat("heightFogFarFalloff");
			float float5 = mainTimeline.GetFloat("fogSkyColorsSmoothing");
			Shader.SetGlobalVector(WeatherIDs._HF_FarInfos, (Vector4)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x600157C")]
		[Cpp2IlInjected.Address(RVA = "0x842E50", Offset = "0x841850", VA = "0x180842E50")]
		public VerticalFog_Modifier()
		{
		}
	}
}
