using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x200050F")]
	public class WeatherData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000510")]
		public class Set
		{
			[Cpp2IlInjected.Token(Token = "0x6001693")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Set()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000511")]
		public class SettingsSet : Set
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001FD4")]
			[KeyRef]
			[NiceName("Key name")]
			[Group("Key")]
			public PreComputedData name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001FD5")]
			[KeyRef]
			[Group("Key")]
			[NiceName("Time")]
			public PreComputedData time;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4001FD6")]
			[KeyRef]
			[NiceName("Duration")]
			[Group("Key")]
			public PreComputedData duration;

			[Cpp2IlInjected.Token(Token = "0x6001694")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SettingsSet()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000512")]
		public class LightingSet : Set
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001FD7")]
			[Group("Sun")]
			[NiceName("Sun light color")]
			[ColorUsage(false, false)]
			public RuntimeBlendable sunLightColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001FD8")]
			[NiceName("Sun light intensity")]
			[Min(0f)]
			[Group("Sun")]
			public RuntimeBlendable sunLightIntensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4001FD9")]
			[Group("Moon")]
			[NiceName("Moon light color")]
			[ColorUsage(false, false)]
			public RuntimeBlendable moonLightColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4001FDA")]
			[NiceName("Moon light intensity")]
			[Group("Moon")]
			[Min(0f)]
			public RuntimeBlendable moonLightIntensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4001FDB")]
			[Group("Misc")]
			[NiceName("Ambient Light")]
			[Min(0f)]
			public RuntimeBlendable ambientLight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4001FDC")]
			[Slider01]
			[Group("Misc")]
			[NiceName("Shadow Strength")]
			public RuntimeBlendable shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4001FDD")]
			[NiceName("Camera light color")]
			[ColorUsage(false, false)]
			[Group("Misc")]
			public RuntimeBlendable cameraLightColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4001FDE")]
			[NiceName("Camera light intensity")]
			[Slider(0f, 0f)]
			[Group("Misc")]
			public RuntimeBlendable cameraLightIntensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4001FDF")]
			[SphericalHarmonics]
			[Group("Spherical Harmonics")]
			public PreComputedData sphericalHarmonics;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4001FE0")]
			[HideInInspector]
			public RuntimeBlendable sh_00;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4001FE1")]
			[HideInInspector]
			public RuntimeBlendable sh_01;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4001FE2")]
			[HideInInspector]
			public RuntimeBlendable sh_02;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4001FE3")]
			[HideInInspector]
			public RuntimeBlendable sh_03;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4001FE4")]
			[HideInInspector]
			public RuntimeBlendable sh_04;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4001FE5")]
			[HideInInspector]
			public RuntimeBlendable sh_05;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4001FE6")]
			[HideInInspector]
			public RuntimeBlendable sh_06;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4001FE7")]
			[HideInInspector]
			public RuntimeBlendable sh_07;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4001FE8")]
			[HideInInspector]
			public RuntimeBlendable sh_08;

			[Cpp2IlInjected.Token(Token = "0x6001695")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public LightingSet()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000513")]
		public class SkySet : Set
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001FE9")]
			[SkyGradient]
			[Group("Atmosphere")]
			[NiceName("Gradient")]
			public PreComputedData atmosphereGradient = new PreComputedData();

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001FEA")]
			[Slider(-0.5f, 0.5f)]
			[NiceName("Vertical Offset")]
			[Group("Atmosphere")]
			public RuntimeBlendable skyVerticalOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4001FEB")]
			[NiceName("Day Offset")]
			[Group("Atmosphere")]
			[Slider(-1f, 1f)]
			public RuntimeBlendable atmosphereDayOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4001FEC")]
			[Slider01]
			[NiceName("Color Night Dome")]
			[Group("Atmosphere")]
			public RuntimeBlendable atmosphereColorNight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4001FED")]
			[Group("Sun")]
			[Slider(0f, 0.5f)]
			[NiceName("Size")]
			[Header("Main Shape")]
			public RuntimeBlendable sunSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4001FEE")]
			[ColorUsage(false, true)]
			[NiceName("Color")]
			[Group("Sun")]
			public RuntimeBlendable sunColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4001FEF")]
			[SkyGradient]
			[Group("Sun")]
			[Header("Corona")]
			[NiceName("Gradient")]
			public PreComputedData sunGradient = new PreComputedData();

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4001FF0")]
			[Cpp2IlInjected.Attribute(Name = "SliderAttribute", RVA = "0x116AF0", Offset = "0x115EF0")]
			[NiceName("Gradient Intensity")]
			[Group("Sun")]
			public RuntimeBlendable sunGradientIntensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4001FF1")]
			[Slider01]
			[NiceName("Range")]
			[Group("Sun")]
			public RuntimeBlendable sunCorona;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4001FF2")]
			[Slider01]
			[Group("Sun")]
			[NiceName("Horizon Blending")]
			public RuntimeBlendable sunHorizonBlending;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4001FF3")]
			[Slider01]
			[Group("Sun")]
			[NiceName("Horizon Power")]
			public RuntimeBlendable sunHorizonPower;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4001FF4")]
			[Slider(0f, 0.5f)]
			[NiceName("Size")]
			[Group("Moon")]
			[Header("Main Shape")]
			public RuntimeBlendable moonSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4001FF5")]
			[ColorUsage(false, true)]
			[NiceName("Color")]
			[Group("Moon")]
			public RuntimeBlendable moonColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4001FF6")]
			[Space]
			[Slider11]
			[Space(10f)]
			[Group("Moon")]
			[NiceName("Moon Phase")]
			public RuntimeBlendable moonPhase;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4001FF7")]
			[SkyGradient]
			[Group("Moon")]
			[NiceName("Gradient")]
			[Header("Corona")]
			public PreComputedData moonGradient = new PreComputedData();

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4001FF8")]
			[Group("Moon")]
			[NiceName("Gradient Intensity")]
			[Slider(0f, 0f)]
			public RuntimeBlendable moonGradientIntensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4001FF9")]
			[Slider01]
			[Group("Moon")]
			[NiceName("Range")]
			public RuntimeBlendable moonCorona;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4001FFA")]
			[Slider01]
			[NiceName("Horizon Blending")]
			[Group("Moon")]
			public RuntimeBlendable moonHorizonBlending;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4001FFB")]
			[Slider01]
			[Group("Moon")]
			[NiceName("Horizon Power")]
			public RuntimeBlendable moonHorizonPower;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4001FFC")]
			[Group("Stars")]
			[NiceName("Color")]
			[ColorUsage(false, false)]
			public RuntimeBlendable starsColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4001FFD")]
			[Float]
			[NiceName("Intensity")]
			[Group("Stars")]
			public RuntimeBlendable starsIntensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4001FFE")]
			[Float]
			[Group("Clouds")]
			[NiceName("Count")]
			public RuntimeBlendable cloudCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4001FFF")]
			[Min(0f)]
			[NiceName("Scale factor")]
			[Group("Clouds")]
			public RuntimeBlendable cloudScaleFactor;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4002000")]
			[Group("Clouds")]
			[NiceName("Ambient Color")]
			[ColorUsage(false, true)]
			public RuntimeBlendable cloudAmbientColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4002001")]
			[Group("Clouds")]
			[NiceName("Sun & Moon Factor")]
			[ColorUsage(false, true)]
			public RuntimeBlendable cloudGlobalColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4002002")]
			[Float]
			[Group("Clouds")]
			[NiceName("Contrast light")]
			public RuntimeBlendable cloudContrast;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4002003")]
			[NiceName("Scattering Sun Factor")]
			[Min(0f)]
			[Group("Clouds")]
			public RuntimeBlendable cloudScatteringSunFactor;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x4002004")]
			[Slider01]
			[NiceName("Scattering Sun Range")]
			[Group("Clouds")]
			public RuntimeBlendable cloudScatteringSunRange;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4002005")]
			[Min(0f)]
			[NiceName("Scattering Moon Factor")]
			[Group("Clouds")]
			public RuntimeBlendable cloudScatteringMoonFactor;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4002006")]
			[Slider01]
			[NiceName("Scattering Moon Range")]
			[Group("Clouds")]
			public RuntimeBlendable cloudScatteringMoonRange;

			[Cpp2IlInjected.Token(Token = "0x6001696")]
			[Cpp2IlInjected.Address(RVA = "0xF88020", Offset = "0xF86A20", VA = "0x180F88020")]
			public SkySet()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000514")]
		public class EffectsSet : Set
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002007")]
			[Min(0f)]
			[Group("Wind")]
			[Separator("Wind")]
			[NiceName("Wind Strength")]
			public RuntimeBlendable windStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002008")]
			[Min(0f)]
			[NiceName("Wind Speed")]
			[Group("Wind")]
			public RuntimeBlendable windSpeed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4002009")]
			[NiceName("Wind Leaves Speed")]
			[Min(0f)]
			[Group("Wind")]
			public RuntimeBlendable windLeavesSpeed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400200A")]
			[NiceName("Wind Grass Strength")]
			[Group("Wind")]
			[Min(0f)]
			public RuntimeBlendable windGrassStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400200B")]
			[NiceName("Wind Grass Speed")]
			[Min(0f)]
			[Group("Wind")]
			public RuntimeBlendable windGrassSpeed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400200C")]
			[Space]
			[Toggle]
			[Space(10f)]
			[NiceName("Use Fog")]
			[Separator("Height Fog")]
			[Group("Fog")]
			public RuntimeBlendable useFog;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400200D")]
			[Toggle]
			[Group("Fog")]
			[NiceName("Use Height map")]
			public RuntimeBlendable heightFogUseMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400200E")]
			[Slider01]
			[Group("Fog")]
			[NiceName("Falloff curve")]
			public RuntimeBlendable heightFogFalloffCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400200F")]
			[SkyGradient]
			[Group("Fog")]
			[NiceName("Gradient")]
			[Header("Colors")]
			public PreComputedData fogGradient = new PreComputedData();

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4002010")]
			[Float]
			[Group("Fog")]
			[NiceName("Sky Colors Distance")]
			public RuntimeBlendable fogSkyColorsDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4002011")]
			[Group("Fog")]
			[Min(0.0001f)]
			[NiceName("Sky Colors Smoothing")]
			public RuntimeBlendable fogSkyColorsSmoothing;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4002012")]
			[Space]
			[NiceName("Near Range")]
			[Space(10f)]
			[Group("Fog")]
			[Min(0.5f)]
			[Header("Near")]
			public RuntimeBlendable heightFogNearRange;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4002013")]
			[Float]
			[Group("Fog")]
			[NiceName("Near Height")]
			public RuntimeBlendable heightFogNearHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4002014")]
			[Group("Fog")]
			[NiceName("Near Falloff")]
			[Min(0.001f)]
			public RuntimeBlendable heightFogNearFalloff;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4002015")]
			[Space]
			[Space(10f)]
			[Group("Fog")]
			[NiceName("Far Range")]
			[Header("Far")]
			[Min(1f)]
			public RuntimeBlendable heightFogFarRange;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4002016")]
			[Float]
			[NiceName("Far Height")]
			[Group("Fog")]
			public RuntimeBlendable heightFogFarHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4002017")]
			[Group("Fog")]
			[NiceName("Far Falloff")]
			[Min(0.001f)]
			public RuntimeBlendable heightFogFarFalloff;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4002018")]
			[Vector]
			[Header("Noise")]
			[Group("Fog")]
			[NiceName("Noise Amplitudes")]
			public RuntimeBlendable fogNoiseAmplitudes;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4002019")]
			[Float]
			[Group("Fog")]
			[NiceName("Noise Speed")]
			public RuntimeBlendable fogNoiseSpeed;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400201A")]
			[Slider01]
			[Group("Fog")]
			[NiceName("Depth Fog Opacity")]
			[Header("Depth Fog")]
			public RuntimeBlendable depthFogOpacity;

			[Cpp2IlInjected.Token(Token = "0x6001697")]
			[Cpp2IlInjected.Address(RVA = "0xF87310", Offset = "0xF85D10", VA = "0x180F87310")]
			public EffectsSet()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000515")]
		public class PostProcessSet : Set
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400201B")]
			[Min(0f)]
			[NiceName("Intensity")]
			[Group("Bloom")]
			public RuntimeBlendable bloomIntensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400201C")]
			[Min(0f)]
			[Group("Bloom")]
			[NiceName("Threshold")]
			public RuntimeBlendable bloomThreshold;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400201D")]
			[Slider01]
			[Group("Bloom")]
			[NiceName("Scattering")]
			public RuntimeBlendable bloomScattering;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400201E")]
			[ColorUsage(false, true)]
			[Group("Bloom")]
			[NiceName("Color")]
			public RuntimeBlendable bloomColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400201F")]
			[Slider01]
			[Group("Bloom Edges")]
			[NiceName("Use edges")]
			public RuntimeBlendable bloomEdgesFactor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4002020")]
			[Group("Bloom Edges")]
			[NiceName("Edges Intensity")]
			[Min(0f)]
			public RuntimeBlendable bloomEdgesIntensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4002021")]
			[Float]
			[Group("Bloom Edges")]
			[NiceName("Edges Threshold")]
			public RuntimeBlendable bloomEdgesThreshold;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4002022")]
			[Slider01]
			[Group("Bloom Edges")]
			[NiceName("Edges Scattering")]
			public RuntimeBlendable bloomEdgesScattering;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4002023")]
			[Group("Bloom Edges")]
			[ColorUsage(false, true)]
			[NiceName("Edges Color")]
			public RuntimeBlendable bloomEdgesColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4002024")]
			[Slider01]
			[NiceName("Intensity")]
			[Group("Vignette")]
			public RuntimeBlendable vignetteIntensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4002025")]
			[ColorUsage(false, true)]
			[Group("Vignette")]
			[NiceName("Color")]
			public RuntimeBlendable vignetteColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4002026")]
			[Group("Color Adjustements")]
			[NiceName("Post Exposure")]
			[Slider(-100f, 100f)]
			public RuntimeBlendable colorAdjPostExposure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4002027")]
			[Group("Color Adjustements")]
			[NiceName("Contrast")]
			[Slider(-100f, 100f)]
			public RuntimeBlendable colorAdjContrast;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4002028")]
			[NiceName("Color Filter")]
			[ColorUsage(false, true)]
			[Group("Color Adjustements")]
			public RuntimeBlendable colorAdjFilter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4002029")]
			[NiceName("Hue shift")]
			[Group("Color Adjustements")]
			[Slider(-180f, 180f)]
			public RuntimeBlendable colorAdjHueShift;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400202A")]
			[Slider(-100f, 100f)]
			[Group("Color Adjustements")]
			[NiceName("Saturation")]
			public RuntimeBlendable colorAdjSaturation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400202B")]
			[Slider01]
			[NiceName("Use edges")]
			[Group("Color Adjustements")]
			public RuntimeBlendable colorAdjEdgesFactor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400202C")]
			[ColorUsage(false, true)]
			[NiceName("Shadows")]
			[Group("Split Toning")]
			public RuntimeBlendable splitToningShadows;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400202D")]
			[ColorUsage(false, true)]
			[NiceName("Highlights")]
			[Group("Split Toning")]
			public RuntimeBlendable splitToningHighlits;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400202E")]
			[NiceName("Balance")]
			[Slider(-100f, 100f)]
			[Group("Split Toning")]
			public RuntimeBlendable splitToningBalance;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400202F")]
			[Group("Rain")]
			[NiceName("Gloss Bias")]
			[Slider(0f, 1f)]
			public RuntimeBlendable globalGlossBias;

			[Cpp2IlInjected.Token(Token = "0x6001698")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public PostProcessSet()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000516")]
		public class RuntimeBlendable : IKeyProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002030")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x6001699")]
			[Cpp2IlInjected.Address(RVA = "0xF87D10", Offset = "0xF86710", VA = "0x180F87D10")]
			public static implicit operator int(RuntimeBlendable blendable)
			{
				//Discarded unreachable code: IL_0007
				return blendable.id;
			}

			[Cpp2IlInjected.Token(Token = "0x600169A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public RuntimeBlendable()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000517")]
		public class PreComputedData : IKeyProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002031")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x600169B")]
			[Cpp2IlInjected.Address(RVA = "0xF87D10", Offset = "0xF86710", VA = "0x180F87D10")]
			public static implicit operator int(PreComputedData preComputedData)
			{
				//Discarded unreachable code: IL_0007
				return preComputedData.id;
			}

			[Cpp2IlInjected.Token(Token = "0x600169C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public PreComputedData()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001FCD")]
		private static string[] _IDToName;

		[Cpp2IlInjected.Token(Token = "0x4001FCE")]
		private static int _count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001FCF")]
		public SettingsSet settings = new SettingsSet();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001FD0")]
		public LightingSet lighting = new LightingSet();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001FD1")]
		public SkySet sky = new SkySet();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001FD2")]
		public EffectsSet effects = new EffectsSet();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001FD3")]
		public PostProcessSet postProcess = new PostProcessSet();

		[Cpp2IlInjected.Token(Token = "0x170002EE")]
		public static string[] IDToName
		{
			[Cpp2IlInjected.Token(Token = "0x600168E")]
			[Cpp2IlInjected.Address(RVA = "0x835C30", Offset = "0x834630", VA = "0x180835C30")]
			get
			{
				//Discarded unreachable code: IL_000d
				int num = 0;
				LoadRemaps();
				return _IDToName;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EF")]
		public static int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600168F")]
			[Cpp2IlInjected.Address(RVA = "0x835B70", Offset = "0x834570", VA = "0x180835B70")]
			get
			{
				//Discarded unreachable code: IL_000d
				int num = 0;
				LoadRemaps();
				return _count;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600168D")]
		[Cpp2IlInjected.Address(RVA = "0x835500", Offset = "0x833F00", VA = "0x180835500")]
		public static int GetId(string name)
		{
			//Discarded unreachable code: IL_0029
			int num = 0;
			LoadRemaps();
			string[] iDToName = _IDToName;
			Predicate<string> predicate = (Predicate<string>)(object)(Predicate<T>)delegate(string s)
			{
				string b = name;
				return string.Equals(s, b);
			};
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001690")]
		[Cpp2IlInjected.Address(RVA = "0x835680", Offset = "0x834080", VA = "0x180835680")]
		private static void LoadRemaps()
		{
			//Discarded unreachable code: IL_00d3
			List<string> list = (List<string>)(object)new List<T>();
			FieldInfo[] fields = typeof(WeatherData).GetFields();
			int num = 0;
			int num2 = 0;
			int length = fields.Length;
			if (num < length)
			{
				FieldInfo fieldInfo = fields[num2];
				Type baseType = fieldInfo.FieldType.BaseType;
				Type typeFromHandle = typeof(Set);
				if (((object)baseType).Equals((object)typeFromHandle))
				{
					FieldInfo[] fields2 = fieldInfo.FieldType.GetFields();
					int num3 = 0;
					if (num3 < fields2.Length)
					{
						FieldInfo fieldInfo2 = fields2[num3];
						Type typeFromHandle2 = typeof(IKeyProperty);
						Type fieldType = fieldInfo2.FieldType;
						if (typeFromHandle2.IsAssignableFrom(fieldType))
						{
							string name = fieldInfo2.Name;
							((List<T>)(object)list).Add((T)name);
						}
						num3++;
					}
				}
				num2++;
			}
			_IDToName = (string[])(object)((List<T>)(object)list).ToArray();
			_count = ((List<>)(object)list)._size;
		}

		[Cpp2IlInjected.Token(Token = "0x6001691")]
		[Cpp2IlInjected.Address(RVA = "0x835A30", Offset = "0x834430", VA = "0x180835A30")]
		public WeatherData()
		{
		}
	}
}
