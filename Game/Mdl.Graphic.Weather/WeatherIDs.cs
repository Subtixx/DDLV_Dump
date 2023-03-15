using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x20004F3")]
	public static class WeatherIDs
	{
		[Cpp2IlInjected.Token(Token = "0x4001F08")]
		public static readonly int _Weather_Main;

		[Cpp2IlInjected.Token(Token = "0x4001F09")]
		public static readonly int _Weather_Water;

		[Cpp2IlInjected.Token(Token = "0x4001F0A")]
		public static readonly int _Weather_Rect;

		[Cpp2IlInjected.Token(Token = "0x4001F0B")]
		public static readonly int _Weather_FogHeight;

		[Cpp2IlInjected.Token(Token = "0x4001F0C")]
		public static readonly int _SkyColors;

		[Cpp2IlInjected.Token(Token = "0x4001F0D")]
		public static readonly int _TimeOfDay;

		[Cpp2IlInjected.Token(Token = "0x4001F0E")]
		public static readonly int _SkyGroundColor;

		[Cpp2IlInjected.Token(Token = "0x4001F0F")]
		public static readonly int _SunSize;

		[Cpp2IlInjected.Token(Token = "0x4001F10")]
		public static readonly int _SunLightColor;

		[Cpp2IlInjected.Token(Token = "0x4001F11")]
		public static readonly int _SunColor;

		[Cpp2IlInjected.Token(Token = "0x4001F12")]
		public static readonly int _SunDirection;

		[Cpp2IlInjected.Token(Token = "0x4001F13")]
		public static readonly int _MoonSize;

		[Cpp2IlInjected.Token(Token = "0x4001F14")]
		public static readonly int _MoonColor;

		[Cpp2IlInjected.Token(Token = "0x4001F15")]
		public static readonly int _MoonLightColor;

		[Cpp2IlInjected.Token(Token = "0x4001F16")]
		public static readonly int _MoonDirection;

		[Cpp2IlInjected.Token(Token = "0x4001F17")]
		public static readonly int _StarsColor;

		[Cpp2IlInjected.Token(Token = "0x4001F18")]
		public static readonly int _StarsIntensity;

		[Cpp2IlInjected.Token(Token = "0x4001F19")]
		public static readonly int _DayFactor;

		[Cpp2IlInjected.Token(Token = "0x4001F1A")]
		public static readonly int _CloudsAmbientColor;

		[Cpp2IlInjected.Token(Token = "0x4001F1B")]
		public static readonly int _CloudsGlobalColor;

		[Cpp2IlInjected.Token(Token = "0x4001F1C")]
		public static readonly int _CloudsContrast;

		[Cpp2IlInjected.Token(Token = "0x4001F1D")]
		public static readonly int _HF_FalloffCurve;

		[Cpp2IlInjected.Token(Token = "0x4001F1E")]
		public static readonly int _HF_UseHeightMap;

		[Cpp2IlInjected.Token(Token = "0x4001F1F")]
		public static readonly int _HF_NearInfos;

		[Cpp2IlInjected.Token(Token = "0x4001F20")]
		public static readonly int _HF_FarInfos;

		[Cpp2IlInjected.Token(Token = "0x4001F21")]
		public static readonly int _FogNoiseAmplitudes;

		[Cpp2IlInjected.Token(Token = "0x4001F22")]
		public static readonly int _FogNoiseTime;

		[Cpp2IlInjected.Token(Token = "0x4001F23")]
		public static readonly int _Wind_Force;

		[Cpp2IlInjected.Token(Token = "0x4001F24")]
		public static readonly int _Wind_Time;

		[Cpp2IlInjected.Token(Token = "0x4001F25")]
		public static readonly int _Wind_Frequency;

		[Cpp2IlInjected.Token(Token = "0x4001F26")]
		public static readonly int _Wind_Axis;

		[Cpp2IlInjected.Token(Token = "0x4001F27")]
		public static readonly int _Wind_LeavesTime;

		[Cpp2IlInjected.Token(Token = "0x4001F28")]
		public static readonly int _WindAtlas;

		[Cpp2IlInjected.Token(Token = "0x4001F29")]
		public static readonly int _WindAtlasMinBounds;

		[Cpp2IlInjected.Token(Token = "0x4001F2A")]
		public static readonly int _WindAtlasMaxBounds;

		[Cpp2IlInjected.Token(Token = "0x4001F2B")]
		public static readonly int _UseBloomVignette;

		[Cpp2IlInjected.Token(Token = "0x4001F2C")]
		public static readonly int _Bloom_IntensityTint;

		[Cpp2IlInjected.Token(Token = "0x4001F2D")]
		public static readonly int _BloomParams2;

		[Cpp2IlInjected.Token(Token = "0x4001F2E")]
		public static readonly int _UseDofEdges;

		[Cpp2IlInjected.Token(Token = "0x4001F2F")]
		public static readonly int _UseColorGradVignette;

		[Cpp2IlInjected.Token(Token = "0x4001F30")]
		public static readonly int _GlobalGlossBias;

		[Cpp2IlInjected.Token(Token = "0x4001F31")]
		public static readonly string[] shKey;

		[Cpp2IlInjected.Token(Token = "0x4001F32")]
		private static WeatherData data;

		[Cpp2IlInjected.Token(Token = "0x170002C1")]
		public static WeatherData.SettingsSet settings
		{
			[Cpp2IlInjected.Token(Token = "0x60015E1")]
			[Cpp2IlInjected.Address(RVA = "0x837080", Offset = "0x835A80", VA = "0x180837080")]
			get
			{
				//Discarded unreachable code: IL_000b
				return data.settings;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C2")]
		public static WeatherData.LightingSet lighting
		{
			[Cpp2IlInjected.Token(Token = "0x60015E2")]
			[Cpp2IlInjected.Address(RVA = "0x836FA0", Offset = "0x8359A0", VA = "0x180836FA0")]
			get
			{
				//Discarded unreachable code: IL_000b
				return data.lighting;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C3")]
		public static WeatherData.SkySet sky
		{
			[Cpp2IlInjected.Token(Token = "0x60015E3")]
			[Cpp2IlInjected.Address(RVA = "0x8370F0", Offset = "0x835AF0", VA = "0x1808370F0")]
			get
			{
				//Discarded unreachable code: IL_000b
				return data.sky;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C4")]
		public static WeatherData.EffectsSet effects
		{
			[Cpp2IlInjected.Token(Token = "0x60015E4")]
			[Cpp2IlInjected.Address(RVA = "0x836F30", Offset = "0x835930", VA = "0x180836F30")]
			get
			{
				//Discarded unreachable code: IL_000b
				return data.effects;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C5")]
		public static WeatherData.PostProcessSet postProcess
		{
			[Cpp2IlInjected.Token(Token = "0x60015E5")]
			[Cpp2IlInjected.Address(RVA = "0x837010", Offset = "0x835A10", VA = "0x180837010")]
			get
			{
				//Discarded unreachable code: IL_000b
				return data.postProcess;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015E6")]
		[Cpp2IlInjected.Address(RVA = "0x835CF0", Offset = "0x8346F0", VA = "0x180835CF0")]
		public static void LoadKeys()
		{
			//Discarded unreachable code: IL_013c
			while (true)
			{
				FieldInfo[] fields = typeof(WeatherData).GetFields();
				int num = 0;
				int num2 = 0;
				int length = fields.Length;
				if (num >= length)
				{
					break;
				}
				Type baseType = fields[num2].FieldType.BaseType;
				Type typeFromHandle = typeof(WeatherData.Set);
				int num4;
				if (((object)baseType).Equals((object)typeFromHandle))
				{
					FieldInfo fieldInfo = fields[num2];
					WeatherData obj = data;
					object value = fieldInfo.GetValue(obj);
					int num3 = 0;
					if (value == null)
					{
						continue;
					}
					FieldInfo[] fields2 = value.GetType().GetFields();
					num4 = 0;
					if (num4 < fields2.Length)
					{
						Type fieldType = fields2[num4].FieldType;
						Type typeFromHandle2 = typeof(WeatherData.RuntimeBlendable);
						bool flag = ((object)fieldType).Equals((object)typeFromHandle2);
						int length2 = fields2.Length;
						if (!flag)
						{
							Type fieldType2 = fields2[num4].FieldType;
							Type typeFromHandle3 = typeof(WeatherData.PreComputedData);
							if (!((object)fieldType2).Equals((object)typeFromHandle3))
							{
								goto IL_0131;
							}
							WeatherData.PreComputedData preComputedData = new WeatherData.PreComputedData();
						}
						FieldInfo fieldInfo2 = fields2[num4];
						WeatherData.RuntimeBlendable runtimeBlendable = new WeatherData.RuntimeBlendable();
						int num5 = (runtimeBlendable.id = WeatherData.GetId(fields2[num4].Name));
						fieldInfo2.SetValue(value, runtimeBlendable);
						goto IL_0131;
					}
				}
				goto IL_0137;
				IL_0131:
				num4++;
				goto IL_0137;
				IL_0137:
				num2++;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015E7")]
		[Cpp2IlInjected.Address(RVA = "0x8361F0", Offset = "0x834BF0", VA = "0x1808361F0")]
		static WeatherIDs()
		{
			//IL_03ac: Expected I4, but got O
			//IL_0401: Expected I4, but got O
			string[] array;
			while (true)
			{
				_Weather_Main = Shader.PropertyToID("_Weather_Main");
				_Weather_Water = Shader.PropertyToID("_Weather_Water");
				_Weather_Rect = Shader.PropertyToID("_Weather_Rect");
				_Weather_FogHeight = Shader.PropertyToID("_Weather_FogHeight");
				_SkyColors = Shader.PropertyToID("_SkyColors");
				_TimeOfDay = Shader.PropertyToID("_TimeOfDay");
				_SkyGroundColor = Shader.PropertyToID("_SkyGroundColor");
				_SunSize = Shader.PropertyToID("_SunSize");
				_SunLightColor = Shader.PropertyToID("_SunLightColor");
				_SunColor = Shader.PropertyToID("_SunColor");
				_SunDirection = Shader.PropertyToID("_SunDirection");
				_MoonSize = Shader.PropertyToID("_MoonSize");
				_MoonColor = Shader.PropertyToID("_MoonColor");
				_MoonLightColor = Shader.PropertyToID("_MoonLightColor");
				_MoonDirection = Shader.PropertyToID("_MoonDirection");
				_StarsColor = Shader.PropertyToID("_StarsColor");
				_StarsIntensity = Shader.PropertyToID("_StarsIntensity");
				_DayFactor = Shader.PropertyToID("_DayFactor");
				_CloudsAmbientColor = Shader.PropertyToID("_CloudsAmbientColor");
				_CloudsGlobalColor = Shader.PropertyToID("_CloudsGlobalColor");
				_CloudsContrast = Shader.PropertyToID("_CloudsContrast");
				_HF_FalloffCurve = Shader.PropertyToID("_HF_FalloffCurve");
				_HF_UseHeightMap = Shader.PropertyToID("_HF_UseHeightMap");
				_HF_NearInfos = Shader.PropertyToID("_HF_NearInfos");
				_HF_FarInfos = Shader.PropertyToID("_HF_FarInfos");
				_FogNoiseAmplitudes = Shader.PropertyToID("_FogNoiseAmplitudes");
				_FogNoiseTime = Shader.PropertyToID("_FogNoiseTime");
				_Wind_Force = Shader.PropertyToID("_Wind_Force");
				_Wind_Time = Shader.PropertyToID("_Wind_Time");
				_Wind_Frequency = Shader.PropertyToID("_Wind_Frequency");
				_Wind_Axis = Shader.PropertyToID("_Wind_Axis");
				_Wind_LeavesTime = Shader.PropertyToID("_Wind_LeavesTime");
				_WindAtlas = Shader.PropertyToID("_WindAtlas");
				_WindAtlasMinBounds = Shader.PropertyToID("_WindAtlasMinBounds");
				_WindAtlasMaxBounds = Shader.PropertyToID("_WindAtlasMaxBounds");
				_UseBloomVignette = Shader.PropertyToID("_UseBloomVignette");
				_Bloom_IntensityTint = Shader.PropertyToID("_Bloom_IntensityTint");
				_BloomParams2 = Shader.PropertyToID("_BloomParams2");
				_UseDofEdges = Shader.PropertyToID("_UseDofEdges");
				_UseColorGradVignette = Shader.PropertyToID("_UseColorGradVignette");
				_GlobalGlossBias = Shader.PropertyToID("_GlobalGlossBias");
				array = new string[10];
				if ("sh_00" != null && "sh_00" == null)
				{
					continue;
				}
				array[0] = "sh_00";
				if ("sh_01" != null && "sh_01" == null)
				{
					continue;
				}
				array[1] = "sh_01";
				if ("sh_02" != null && "sh_02" == null)
				{
					continue;
				}
				array[2] = "sh_02";
				if ("sh_03" != null && "sh_03" == null)
				{
					continue;
				}
				array[3] = "sh_03";
				if ("sh_04" != null && "sh_04" == null)
				{
					continue;
				}
				array[4] = "sh_04";
				if ("sh_05" != null && "sh_05" == null)
				{
					continue;
				}
				array[5] = "sh_05";
				if ("sh_06" != null && "sh_06" == null)
				{
					continue;
				}
				array[6] = "sh_06";
				if ("sh_07" != null && "sh_07" == null)
				{
					continue;
				}
				array[7] = "sh_07";
				if ("sh_08" == null || "sh_08" != null)
				{
					array[8] = "sh_08";
					if ("sh_09" == null || "sh_09" != null)
					{
						break;
					}
				}
			}
			array[9] = "sh_09";
			_Weather_Main = (int)array;
			WeatherData weatherData = new WeatherData();
			WeatherData.SettingsSet settingsSet = (weatherData.settings = new WeatherData.SettingsSet());
			WeatherData.LightingSet lightingSet = (weatherData.lighting = new WeatherData.LightingSet());
			WeatherData.SkySet skySet = (weatherData.sky = new WeatherData.SkySet());
			WeatherData.EffectsSet effectsSet = (weatherData.effects = new WeatherData.EffectsSet());
			WeatherData.PostProcessSet postProcessSet = (weatherData.postProcess = new WeatherData.PostProcessSet());
			_Weather_Main = (int)weatherData;
			throw new NullReferenceException();
		}
	}
}
