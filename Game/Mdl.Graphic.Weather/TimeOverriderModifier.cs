using System;
using Cpp2IlInjected;
using Mdl.Graphic.Sky;
using Unity.Mathematics;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20004DD")]
	[CreateAssetMenu]
	public class TimeOverriderModifier : WeatherModifier
	{
		[Cpp2IlInjected.Token(Token = "0x20004DE")]
		public enum LightMode
		{
			[Cpp2IlInjected.Token(Token = "0x4001E84")]
			Classic,
			[Cpp2IlInjected.Token(Token = "0x4001E85")]
			DayOnly,
			[Cpp2IlInjected.Token(Token = "0x4001E86")]
			NightOnly
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E81")]
		public TimeSettings timeSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001E82")]
		public LightMode lightMode;

		[Cpp2IlInjected.Token(Token = "0x170002AC")]
		public override string menuName
		{
			[Cpp2IlInjected.Token(Token = "0x6001571")]
			[Cpp2IlInjected.Address(RVA = "0x10765F0", Offset = "0x1074FF0", VA = "0x1810765F0", Slot = "4")]
			get
			{
				return "Utils/Time overrider";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001572")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void Disable()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001573")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
		public override void Enable()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001574")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void BeforeEvaluation(float time, WeatherTimeline mainTimeline, float weight)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001575")]
		[Cpp2IlInjected.Address(RVA = "0x1075E30", Offset = "0x1074830", VA = "0x181075E30", Slot = "8")]
		public override void AfterEvaluation(float time, WeatherTimeline mainTimeline, float weight)
		{
			//IL_00fb: Expected F4, but got I4
			//IL_0135: Expected F4, but got I4
			//IL_015d: Expected F4, but got I4
			//IL_0185: Expected F4, but got I4
			TimeSettings timeSettings = this.timeSettings;
			int num = 0;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			float4[] propValues = mainTimeline._propValues;
			int num2 = 0;
			WeatherData.RuntimeBlendable shadowStrength = WeatherIDs.lighting.shadowStrength;
			int id = shadowStrength.id;
			shadowStrength = (WeatherData.RuntimeBlendable)(object)((object)shadowStrength + (object)shadowStrength);
			int sunDirection = WeatherIDs._SunDirection;
			int num3 = 0;
			TimeSettings timeSettings2 = this.timeSettings;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			Vector3 vector4 = default(Vector3);
			float z4 = vector4.z;
			float4[] propValues2 = mainTimeline._propValues;
			int num4 = 0;
			WeatherData.RuntimeBlendable shadowStrength2 = WeatherIDs.lighting.shadowStrength;
			int id2 = shadowStrength2.id;
			shadowStrength2 = (WeatherData.RuntimeBlendable)(object)((object)shadowStrength2 + (object)shadowStrength2);
			int moonDirection = WeatherIDs._MoonDirection;
			LightMode lightMode = this.lightMode;
			if (lightMode == LightMode.DayOnly)
			{
				int dayFactor = WeatherIDs._DayFactor;
				float value = Mathf.Lerp(Shader.GetGlobalFloatImpl(dayFactor), 0.5f, time);
				Shader.SetGlobalFloatImpl(dayFactor, value);
				int timeOfDay = WeatherIDs._TimeOfDay;
				float value2 = Mathf.Lerp(Shader.GetGlobalFloatImpl(timeOfDay), 0.5f, time);
				Shader.SetGlobalFloatImpl(timeOfDay, value2);
				int num5 = 0;
				float a = (Moon.lightIntensity = Mathf.Lerp(Moon.lightIntensity, num5, time));
				int num6 = 0;
				float4[] propValues3 = mainTimeline._propValues;
				WeatherData.RuntimeBlendable sunLightIntensity = WeatherIDs.lighting.sunLightIntensity;
				int id3 = sunLightIntensity.id;
				sunLightIntensity = (WeatherData.RuntimeBlendable)(object)((object)sunLightIntensity + (object)sunLightIntensity);
				Sun.lightIntensity = Mathf.Lerp(a, num5, time);
				return;
			}
			while (lightMode != LightMode.NightOnly)
			{
			}
			int dayFactor2 = WeatherIDs._DayFactor;
			float globalFloatImpl = Shader.GetGlobalFloatImpl(dayFactor2);
			int num7 = 0;
			float value3 = Mathf.Lerp(globalFloatImpl, num7, time);
			Shader.SetGlobalFloatImpl(dayFactor2, value3);
			int timeOfDay2 = WeatherIDs._TimeOfDay;
			float globalFloatImpl2 = Shader.GetGlobalFloatImpl(timeOfDay2);
			int num8 = 0;
			float num9 = Mathf.Lerp(globalFloatImpl2, num8, time);
			Shader.SetGlobalFloatImpl(timeOfDay2, num9);
			int num10 = 0;
			float4[] propValues4 = mainTimeline._propValues;
			WeatherData.RuntimeBlendable moonLightIntensity = WeatherIDs.lighting.moonLightIntensity;
			int id4 = moonLightIntensity.id;
			moonLightIntensity = (WeatherData.RuntimeBlendable)(object)((object)moonLightIntensity + (object)moonLightIntensity);
			Moon.lightIntensity = Mathf.Lerp(num9, num9, time);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001576")]
		[Cpp2IlInjected.Address(RVA = "0x842E50", Offset = "0x841850", VA = "0x180842E50")]
		public TimeOverriderModifier()
		{
		}
	}
}
