using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Graphic.Sky;
using Mdl.Graphic.Wind;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x20004E9")]
	public static class WeatherController
	{
		[Cpp2IlInjected.Token(Token = "0x4001EC7")]
		private const int timeBypass = 2880;

		[Cpp2IlInjected.Token(Token = "0x4001EC8")]
		public const string TagLabelClouds = "Clouds";

		[Cpp2IlInjected.Token(Token = "0x4001EC9")]
		public const string TagLabelFog = "Fog";

		[Cpp2IlInjected.Token(Token = "0x4001ECA")]
		public const string TagLabelRain = "Rain";

		[Cpp2IlInjected.Token(Token = "0x4001ECB")]
		public const string TagLabelWind = "Wind";

		[Cpp2IlInjected.Token(Token = "0x4001ECC")]
		public const string TagLabelCurse = "Curse";

		[Cpp2IlInjected.Token(Token = "0x4001ECD")]
		public const string TagLabelHereAndThere = "HereAndThere";

		[Cpp2IlInjected.Token(Token = "0x4001ECE")]
		public static bool paused = (byte)(int)new Dictionary<TKey, TValue>() != 0;

		[Cpp2IlInjected.Token(Token = "0x4001ECF")]
		public static IWeatherController current;

		[Cpp2IlInjected.Token(Token = "0x4001ED0")]
		private static float lastUpdateTimeStamp;

		[Cpp2IlInjected.Token(Token = "0x4001ED1")]
		public static float windTime;

		[Cpp2IlInjected.Token(Token = "0x4001ED2")]
		public static float windLeavesTime;

		[Cpp2IlInjected.Token(Token = "0x4001ED3")]
		private static float fogNoiseTime;

		[Cpp2IlInjected.Token(Token = "0x4001ED4")]
		private static bool _lightsOn;

		[Cpp2IlInjected.Token(Token = "0x4001ED5")]
		public static bool day;

		[Cpp2IlInjected.Token(Token = "0x4001ED6")]
		public static float dayFactor;

		[Cpp2IlInjected.Token(Token = "0x4001ED7")]
		private static float controllerTime;

		[Cpp2IlInjected.Token(Token = "0x4001ED8")]
		public static WeatherTimeline mainTimeline;

		[Cpp2IlInjected.Token(Token = "0x4001ED9")]
		private static List<(WeatherTimeline timeline, float weight)> timelines;

		[Cpp2IlInjected.Token(Token = "0x4001EDA")]
		private static Dictionary<string, float> tags;

		[Cpp2IlInjected.Token(Token = "0x4001EDB")]
		private static List<(WeatherModifier modifier, float weight)> prevFrameModifiers;

		[Cpp2IlInjected.Token(Token = "0x4001EDC")]
		private static Material skyPrepassMaterial;

		[Cpp2IlInjected.Token(Token = "0x4001EDD")]
		public static RenderTexture skyColorsA;

		[Cpp2IlInjected.Token(Token = "0x4001EDE")]
		public static RenderTexture skyColorsB;

		[Cpp2IlInjected.Token(Token = "0x4001EDF")]
		public static RenderTexture skyColorsC;

		[Cpp2IlInjected.Token(Token = "0x4001EE0")]
		public static bool skyColorsSwap;

		[Cpp2IlInjected.Token(Token = "0x4001EE1")]
		private static bool computeSkyColors;

		[Cpp2IlInjected.Token(Token = "0x4001EE2")]
		private static int skyColorsStep;

		[Cpp2IlInjected.Token(Token = "0x4001EE3")]
		private static bool loadingCubemap;

		[Cpp2IlInjected.Token(Token = "0x4001EE4")]
		private static AssetReference currentCubemap;

		[Cpp2IlInjected.Token(Token = "0x4001EE5")]
		private static Volume volume;

		[Cpp2IlInjected.Token(Token = "0x4001EE6")]
		private static Bloom bloom;

		[Cpp2IlInjected.Token(Token = "0x4001EE7")]
		private static Vignette vignette;

		[Cpp2IlInjected.Token(Token = "0x4001EE8")]
		private static ColorAdjustments colorAdjustments;

		[Cpp2IlInjected.Token(Token = "0x4001EE9")]
		private static SplitToning splitToning;

		[Cpp2IlInjected.Token(Token = "0x4001EEA")]
		private static LiftGammaGain liftGammaGain;

		[Cpp2IlInjected.Token(Token = "0x4001EEB")]
		private static ColorCurves colorCurves;

		[Cpp2IlInjected.Token(Token = "0x4001EEC")]
		private static Tonemapping tonemapping;

		[Cpp2IlInjected.Token(Token = "0x4001EED")]
		private static HashSet<IWeatherController> controllers;

		[Cpp2IlInjected.Token(Token = "0x4001EEE")]
		public static bool disableSplitToningOverride;

		[Cpp2IlInjected.Token(Token = "0x4001EEF")]
		private static float[] weights;

		[Cpp2IlInjected.Token(Token = "0x4001EF0")]
		private static Texture[] textures;

		[Cpp2IlInjected.Token(Token = "0x4001EF1")]
		public static bool overrideTimelines;

		[Cpp2IlInjected.Token(Token = "0x4001EF2")]
		private static WeatherTimeline overrideTimelinesValue;

		[Cpp2IlInjected.Token(Token = "0x4001EF3")]
		public static bool overrideTime;

		[Cpp2IlInjected.Token(Token = "0x4001EF4")]
		private static double overrideTimeStamp;

		[Cpp2IlInjected.Token(Token = "0x4001EF5")]
		private static float overrideTimeValue;

		[Cpp2IlInjected.Token(Token = "0x4001EF6")]
		public static bool overridePostProcess;

		[Cpp2IlInjected.Token(Token = "0x4001EF7")]
		private static double overridePostProcessStamp;

		[Cpp2IlInjected.Token(Token = "0x4001EF8")]
		private static PostProcess overridePostProcessValue;

		[Cpp2IlInjected.Token(Token = "0x4001EF9")]
		private static Transform anchor;

		[Cpp2IlInjected.Token(Token = "0x4001EFA")]
		private static Vector3 anchorOffset;

		[Cpp2IlInjected.Token(Token = "0x170002BA")]
		private static bool lightsOn
		{
			[Cpp2IlInjected.Token(Token = "0x60015A5")]
			[Cpp2IlInjected.Address(RVA = "0xD5A670", Offset = "0xD59070", VA = "0x180D5A670")]
			get
			{
				return _lightsOn;
			}
			[Cpp2IlInjected.Token(Token = "0x60015A6")]
			[Cpp2IlInjected.Address(RVA = "0xD5A9A0", Offset = "0xD593A0", VA = "0x180D5A9A0")]
			set
			{
				//Discarded unreachable code: IL_001e
				//IL_0011: Expected F4, but got I4
				//IL_0029: Expected O, but got I4
				if (value)
				{
				}
				int num = 0;
				Shader.SetGlobalFloat("_GlobalEmissiveIntensity", num);
				LightToggle.globalStatus = value;
				_lightsOn = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BB")]
		public unsafe static bool IsRaining
		{
			[Cpp2IlInjected.Token(Token = "0x60015A7")]
			[Cpp2IlInjected.Address(RVA = "0xD5A4D0", Offset = "0xD58ED0", VA = "0x180D5A4D0")]
			get
			{
				//Discarded unreachable code: IL_001b
				int num = 0;
				bool flag = ((Dictionary<TKey, TValue>)(object)tags).TryGetValue((TKey)"Rain", out *(TValue*)num);
				if (!flag)
				{
					return flag;
				}
				return flag;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BC")]
		public static bool IsLightsOn
		{
			[Cpp2IlInjected.Token(Token = "0x60015A8")]
			[Cpp2IlInjected.Address(RVA = "0xD5A470", Offset = "0xD58E70", VA = "0x180D5A470")]
			get
			{
				return _lightsOn;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BD")]
		public static bool ForceAllConstellationsOn
		{
			[Cpp2IlInjected.Token(Token = "0x60015A9")]
			[Cpp2IlInjected.Address(RVA = "0xD5A3B0", Offset = "0xD58DB0", VA = "0x180D5A3B0")]
			get
			{
				WeatherTimeline weatherTimeline = mainTimeline;
				if ((object)weatherTimeline != null)
				{
					ConstellationLibrary constellationLibrary = weatherTimeline.constellations;
					if ((object)constellationLibrary != null)
					{
						return constellationLibrary.forceAllConstellationsOn;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x60015AA")]
			[Cpp2IlInjected.Address(RVA = "0xD5A810", Offset = "0xD59210", VA = "0x180D5A810")]
			set
			{
				//Discarded unreachable code: IL_0027
				//IL_0013: Expected O, but got I4
				//IL_0013: Expected O, but got I4
				if ((object)mainTimeline != null)
				{
				}
				int num = 0;
				int num2 = 0;
				if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
				{
					mainTimeline.constellations.forceAllConstellationsOn = value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BE")]
		public static ConstellationLibrary constellations
		{
			[Cpp2IlInjected.Token(Token = "0x60015AB")]
			[Cpp2IlInjected.Address(RVA = "0xD5A600", Offset = "0xD59000", VA = "0x180D5A600")]
			get
			{
				WeatherTimeline weatherTimeline;
				do
				{
					weatherTimeline = mainTimeline;
				}
				while ((object)weatherTimeline == null);
				return weatherTimeline.constellations;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BF")]
		public static CloudLibrary clouds
		{
			[Cpp2IlInjected.Token(Token = "0x60015AC")]
			[Cpp2IlInjected.Address(RVA = "0xD5A590", Offset = "0xD58F90", VA = "0x180D5A590")]
			get
			{
				WeatherTimeline weatherTimeline;
				do
				{
					weatherTimeline = mainTimeline;
				}
				while ((object)weatherTimeline == null);
				return weatherTimeline.clouds;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C0")]
		public static float time
		{
			[Cpp2IlInjected.Token(Token = "0x60015C1")]
			[Cpp2IlInjected.Address(RVA = "0xD5A6D0", Offset = "0xD590D0", VA = "0x180D5A6D0")]
			get
			{
				//Discarded unreachable code: IL_0006
				return controllerTime;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015AD")]
		[Cpp2IlInjected.Address(RVA = "0xD51110", Offset = "0xD4FB10", VA = "0x180D51110")]
		public static void AddController(IWeatherController controller)
		{
			//Discarded unreachable code: IL_0067
			//IL_0036: Expected F4, but got I4
			//IL_0044: Expected F4, but got I4
			//IL_004a: Expected F4, but got I4
			//IL_0066: Expected I4, but got O
			if (((HashSet<T>)(object)controllers).Add((T)controller))
			{
				Debug.Log("Enable WeatherController");
				int num = 0;
				WeatherIDs.LoadKeys();
				bool flag = _lightsOn;
				if (flag)
				{
				}
				int num2 = 0;
				Shader.SetGlobalFloat("_GlobalEmissiveIntensity", num2);
				LightToggle.globalStatus = flag;
				int num3 = 0;
				fogNoiseTime = num3;
				windTime = num3;
				computeSkyColors = (byte)num3 != 0;
				loadingCubemap = (byte)num3 != 0;
				((List<T>)(object)prevFrameModifiers).Clear();
				paused = (byte)(int)controller != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015AE")]
		[Cpp2IlInjected.Address(RVA = "0xD576E0", Offset = "0xD560E0", VA = "0x180D576E0")]
		public static void RemoveController(IWeatherController controller)
		{
			//Discarded unreachable code: IL_0035
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (((HashSet<T>)(object)controllers).Remove((T)controller))
			{
				HashSet<IWeatherController> hashSet = controllers;
				bool flag = default(bool);
				if (flag)
				{
					paused = (byte)num2 != 0;
				}
			}
			HashSet<IWeatherController> hashSet2 = controllers;
			int num4 = 0;
			OnDisable();
		}

		[Cpp2IlInjected.Token(Token = "0x60015AF")]
		[Cpp2IlInjected.Address(RVA = "0xD574F0", Offset = "0xD55EF0", VA = "0x180D574F0")]
		private static void OnEnable()
		{
			//Discarded unreachable code: IL_0053
			//IL_0028: Expected F4, but got I4
			//IL_0036: Expected F4, but got I4
			//IL_003c: Expected F4, but got I4
			Debug.Log("Enable WeatherController");
			int num = 0;
			WeatherIDs.LoadKeys();
			bool flag = _lightsOn;
			if (flag)
			{
			}
			int num2 = 0;
			Shader.SetGlobalFloat("_GlobalEmissiveIntensity", num2);
			LightToggle.globalStatus = flag;
			int num3 = 0;
			fogNoiseTime = num3;
			windTime = num3;
			computeSkyColors = (byte)num3 != 0;
			loadingCubemap = (byte)num3 != 0;
			((List<T>)(object)prevFrameModifiers).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x60015B0")]
		[Cpp2IlInjected.Address(RVA = "0xD57260", Offset = "0xD55C60", VA = "0x180D57260")]
		private static void OnDisable()
		{
			//Discarded unreachable code: IL_0055, IL_005b
			//IL_0033: Expected O, but got I4
			int num = 0;
			Debug.Log("Disable WeatherController");
			List<(WeatherModifier, float)> list = prevFrameModifiers;
			bool flag = default(bool);
			if (flag)
			{
			}
			((List<T>)(object)prevFrameModifiers).Clear();
			RenderTexture renderTexture = skyColorsA;
			int num2 = 0;
			if (renderTexture != (UnityEngine.Object)num2)
			{
				skyColorsA.Release();
				skyColorsB.Release();
				skyColorsC.Release();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015B1")]
		[Cpp2IlInjected.Address(RVA = "0xD58AB0", Offset = "0xD574B0", VA = "0x180D58AB0")]
		public static void UpdateNow()
		{
			//Discarded unreachable code: IL_000c
			Evaluate(current, force: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60015B2")]
		[Cpp2IlInjected.Address(RVA = "0xD56400", Offset = "0xD54E00", VA = "0x180D56400")]
		public static void Evaluate(IWeatherController controller, bool force = false)
		{
			//Discarded unreachable code: IL_0125
			//IL_000f: Expected O, but got I4
			//IL_009d: Expected I4, but got O
			//IL_00bd: Expected O, but got I4
			//IL_00da: Expected O, but got I4
			//IL_00e1: Expected F4, but got I4
			WeatherTimeline weatherTimeline = mainTimeline;
			int num = 0;
			if (weatherTimeline != (UnityEngine.Object)num)
			{
				int num2 = 0;
				float deltaTime = Time.deltaTime;
				windTime = mainTimeline.GetFloat("windSpeed");
				int num3 = 0;
				deltaTime = Time.deltaTime;
				windLeavesTime = mainTimeline.GetFloat("windLeavesSpeed");
				float value = windTime;
				Shader.SetGlobalFloatImpl(WeatherIDs._Wind_Time, value);
				float value2 = windLeavesTime;
				Shader.SetGlobalFloatImpl(WeatherIDs._Wind_LeavesTime, value2);
			}
			if (controller != null)
			{
				float num5;
				if (!force)
				{
					int num4 = 0;
					num5 = Time.time;
				}
				int num6 = 0;
				num5 = (lastUpdateTimeStamp = Time.time);
				paused = (byte)(int)controller != 0;
				((List<T>)(object)timelines).Clear();
				WeatherTimeline weatherTimeline2 = overrideTimelinesValue;
				int num7 = 0;
				int num8 = 0;
				int num9 = default(int);
				if (weatherTimeline2 != (UnityEngine.Object)num8)
				{
					num9 = 0;
					List<(WeatherTimeline, float)> list = timelines;
					WeatherTimeline weatherTimeline3 = overrideTimelinesValue;
					((List<T>)(object)list).Add((T)num9);
				}
				controllerTime = num9;
				Volume volume = WeatherController.volume;
				bool flag = default(bool);
				if (flag)
				{
					paused = flag;
					int num10 = 0;
					LoadPostProcessComponents();
				}
				int num11 = 0;
				UpdateCubemap();
				int num12 = 0;
				EvaluateUsedTimelines();
				int num13 = 0;
				ApplyInheritance();
				int num14 = 0;
				UpdateSkyColors();
				int num15 = 0;
				ApplyValues();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015B3")]
		[Cpp2IlInjected.Address(RVA = "0xD56E30", Offset = "0xD55830", VA = "0x180D56E30")]
		private static void LoadPostProcessComponents()
		{
			//Discarded unreachable code: IL_0093
			//IL_003b: Expected O, but got I4
			paused = (paused = (paused = (paused = (paused = (paused = (paused = false))))));
			Volume volume = WeatherController.volume;
			int num = 0;
			if (volume != (UnityEngine.Object)num)
			{
				VolumeProfile profile = WeatherController.volume.profile;
				VolumeProfile profile2 = WeatherController.volume.profile;
				VolumeProfile profile3 = WeatherController.volume.profile;
				VolumeProfile profile4 = WeatherController.volume.profile;
				VolumeProfile profile5 = WeatherController.volume.profile;
				VolumeProfile profile6 = WeatherController.volume.profile;
				VolumeProfile profile7 = WeatherController.volume.profile;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015B4")]
		[Cpp2IlInjected.Address(RVA = "0xD55DE0", Offset = "0xD547E0", VA = "0x180D55DE0")]
		private static void EvaluateUsedTimelines()
		{
			//Discarded unreachable code: IL_003a, IL_003f, IL_0049, IL_00a7, IL_00ad, IL_00b3, IL_00b9, IL_00bf, IL_00c5, IL_00cb, IL_00d1, IL_00d7, IL_00dd
			//IL_0028: Expected O, but got I4
			//IL_0076: Expected O, but got I4
			//IL_0084: Expected F4, but got I4
			//IL_00a4: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			HashSet<WeatherTimeline> hashSet = (HashSet<WeatherTimeline>)(object)new HashSet<T>();
			List<(WeatherTimeline, float)> list = timelines;
			bool flag = default(bool);
			if (flag)
			{
				int num4 = 0;
				bool flag2 = default(bool);
				if (flag2)
				{
					bool flag3 = ((HashSet<T>)(object)hashSet).Add((T)num4);
				}
				int num5 = 0;
				Dictionary<string, float> dictionary = tags;
				throw new NullReferenceException();
			}
			bool flag4 = default(bool);
			if (flag4)
			{
				int num6 = 0;
				float f = time;
				int num7 = Mathf.FloorToInt(f);
				WeatherTimeline weatherTimeline = mainTimeline;
				if ((UnityEngine.Object)num2 == weatherTimeline)
				{
					Hash128 hash = Hash128.Compute(UnityEngine.Random.Range(0f, 1f));
				}
				int num8 = 0;
				f = time;
				WeatherTimeline weatherTimeline2 = mainTimeline;
				bool flag5 = (UnityEngine.Object)num2 == weatherTimeline2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015B5")]
		[Cpp2IlInjected.Address(RVA = "0xD51F50", Offset = "0xD50950", VA = "0x180D51F50")]
		private static void ApplyInheritance()
		{
			//Discarded unreachable code: IL_0023
			int num = 0;
			List<(WeatherTimeline, float)> list = timelines;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				if (flag2)
				{
				}
				string text = default(string);
				Debug.LogError(text + " - This timeline must be in classic mode and have a fallback to be evaluated correctly.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015B6")]
		[Cpp2IlInjected.Address(RVA = "0xD58B60", Offset = "0xD57560", VA = "0x180D58B60")]
		private static void UpdateSkyColors()
		{
			//Discarded unreachable code: IL_0223, IL_0277, IL_0288, IL_029e, IL_02b9, IL_02c3, IL_02cf, IL_02e5, IL_02f5, IL_0382
			//IL_00e9: Expected O, but got I4
			//IL_00f5: Expected O, but got I4
			//IL_011e: Expected O, but got I4
			//IL_0141: Expected O, but got I4
			//IL_015a: Expected O, but got I4
			//IL_0172: Expected O, but got I4
			//IL_019d: Expected O, but got I4
			//IL_01ba: Expected O, but got I4
			//IL_01ee: Expected I4, but got O
			//IL_01ff: Expected I4, but got O
			//IL_029b: Expected O, but got I4
			//IL_02b6: Expected O, but got I4
			//IL_02cf: Expected I4, but got O
			//IL_02e2: Expected O, but got I4
			//IL_0318: Expected I4, but got O
			//IL_0347: Expected I4, but got O
			//IL_0376: Expected I4, but got O
			List<(Texture, float)> list;
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			string text = default(string);
			string text2 = default(string);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			WeatherTimeline weatherTimeline = default(WeatherTimeline);
			WeatherTimeline weatherTimeline2 = default(WeatherTimeline);
			bool flag6 = default(bool);
			bool result = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				list = (List<(Texture, float)>)(object)new List<T>();
				List<(WeatherTimeline, float)> list2 = timelines;
				if (!flag)
				{
					break;
				}
				List<(Texture, float)> list3 = (List<(Texture, float)>)(object)new List<T>();
				int num5 = 0;
				int num6 = 0;
				if (!flag2)
				{
					int num7 = 0;
					int num8 = 0;
					if (!flag3)
					{
						string[] array = new string[5];
						if ("The timeline " != null && "The timeline " == null)
						{
							continue;
						}
						array[0] = "The timeline ";
						if (text != null && text == null)
						{
							continue;
						}
						array[1] = text;
						if (" and its parent " != null && " and its parent " == null)
						{
							continue;
						}
						array[2] = " and its parent ";
						if (text2 != null && text2 == null)
						{
							continue;
						}
						array[3] = text2;
						if (" have no skycolors." != null && " have no skycolors." == null)
						{
							continue;
						}
						array[4] = " have no skycolors.";
						Debug.LogError(string.Concat(array));
					}
					int num9 = 0;
					((List<T>)(object)list3).Add((T)num9);
				}
				int num10 = 0;
				((List<T>)(object)list3).Add((T)num10);
				if (flag4)
				{
					Dictionary<string, float> dictionary = tags;
					while (!flag5)
					{
					}
					Texture2D skyColors = weatherTimeline.skyColors;
					int num11 = 0;
					int num12 = 0;
					if (!(skyColors != (UnityEngine.Object)num12))
					{
						continue;
					}
					int num13 = 0;
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
					num4 += 2;
					num4 += num4;
					int num14 = 0;
					((List<T>)(object)list3)[num4] = (T)num14;
					num4++;
					Texture2D skyColors2 = weatherTimeline2.skyColors;
					int num15 = 0;
					((List<T>)(object)list3).Add((T)num15);
				}
				if (flag6)
				{
					int num16 = 0;
					Texture tex = (Texture)num16;
					Predicate<(Texture, float)> predicate = (Predicate<(Texture, float)>)(object)(Predicate<T>)(((Texture tex, float weight) sc) => result);
					int num17 = ((List<T>)(object)list).FindIndex((Predicate<>)(object)predicate);
					if (num17 == -1)
					{
						int num18 = 0;
						((List<T>)(object)list).Add((T)num18);
					}
					int num19 = 0;
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
					num17 += num17;
					int num20 = 0;
					((List<T>)(object)list)[num17] = (T)num20;
				}
				break;
			}
			int num21 = 0;
			int size = ((List<>)(object)list)._size;
			if (size == 0 || size == 1)
			{
				return;
			}
			skyColorsStep = num21;
			paused = (byte)(int)new float[((List<>)(object)list)._size] != 0;
			paused = (byte)(int)new Texture[((List<>)(object)list)._size] != 0;
			int size2 = ((List<>)(object)list)._size;
			if (num21 < size2)
			{
				int num22 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				Texture[] array2 = textures;
				throw new IndexOutOfRangeException();
			}
			int length = weights.Length;
			if (length > 0)
			{
				if (1 < length)
				{
					float[] array3 = weights;
				}
				float[] array4 = weights;
				float num23 = (array4[0] = array4[num21]);
				if (1 >= length)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015B7")]
		[Cpp2IlInjected.Address(RVA = "0xD547D0", Offset = "0xD531D0", VA = "0x180D547D0")]
		private static void ApplyValues()
		{
			//IL_003b: Expected O, but got I4
			//IL_005e: Expected O, but got I4
			//IL_0089: Expected O, but got I4
			//IL_00a6: Expected O, but got I4
			//IL_00bd: Expected O, but got I4
			//IL_00f4: Expected O, but got I4
			//IL_0111: Expected O, but got I4
			//IL_012e: Expected O, but got I4
			//IL_0159: Expected O, but got I4
			//IL_0176: Expected O, but got I4
			//IL_01e9: Expected O, but got I4
			//IL_02ae: Expected O, but got I4
			uint num5 = default(uint);
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool result5 = default(bool);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			WeatherTimeline weatherTimeline = default(WeatherTimeline);
			WeatherTimeline weatherTimeline2 = default(WeatherTimeline);
			bool flag6 = default(bool);
			bool result3 = default(bool);
			bool flag7 = default(bool);
			bool flag8 = default(bool);
			bool flag9 = default(bool);
			bool result2 = default(bool);
			WeatherModifier modifier3 = default(WeatherModifier);
			bool flag10 = default(bool);
			bool result = default(bool);
			bool flag11 = default(bool);
			do
			{
				IL_0000:
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				List<(WeatherModifier, float)> list = (List<(WeatherModifier, float)>)(object)new List<T>();
				List<(WeatherTimeline, float)> list2 = (List<(WeatherTimeline, float)>)(object)new List<T>();
				IWeatherController weatherController = current;
				if (num4 < (int)num5)
				{
					num4 += num4;
					num4++;
				}
				if (flag)
				{
					int num6 = 0;
					((List<T>)(object)list).Add((T)num6);
				}
				List<(WeatherTimeline, float)> list3 = timelines;
				if (flag2)
				{
					if (flag3)
					{
						WeatherModifier modifier = (WeatherModifier)0;
						Predicate<(WeatherModifier, float)> predicate = (Predicate<(WeatherModifier, float)>)(object)(Predicate<T>)(((WeatherModifier modifier, float weight) m) => result5);
						int num7 = ((List<T>)(object)list).FindIndex((Predicate<>)(object)predicate);
						if (num7 == -1)
						{
							int num8 = 0;
							((List<T>)(object)list).Add((T)num8);
						}
						int num9 = 0;
						System.ThrowHelper.ThrowArgumentOutOfRangeException();
						num7 += num7;
						int num10 = 0;
						((List<T>)(object)list)[num7] = (T)num10;
					}
					if (flag4)
					{
						WeatherTimeline.Variant variant = (WeatherTimeline.Variant)num3;
						Dictionary<string, float> dictionary = tags;
						while (!flag5)
						{
						}
						Predicate<(WeatherTimeline, float)> predicate2 = (Predicate<(WeatherTimeline, float)>)(object)(Predicate<T>)delegate
						{
							//Discarded unreachable code: IL_0010
							if (!variant.isReference)
							{
							}
							bool result4 = default(bool);
							return result4;
						};
						int num11 = ((List<T>)(object)list2).FindIndex((Predicate<>)(object)predicate2);
						if (num11 == -1)
						{
							int num12 = 0;
							((List<T>)(object)list2).Add((T)num12);
						}
						int num13 = 0;
						System.ThrowHelper.ThrowArgumentOutOfRangeException();
						weatherTimeline = (WeatherTimeline)(object)((object)weatherTimeline + (object)weatherTimeline);
						int num14 = 0;
						((List<T>)(object)list2)[num11] = (T)num14;
						List<WeatherModifier> modifiers = weatherTimeline2.modifiers;
						if (flag6)
						{
							WeatherModifier modifier2 = (WeatherModifier)0;
							Predicate<(WeatherModifier, float)> predicate3 = (Predicate<(WeatherModifier, float)>)(object)(Predicate<T>)(((WeatherModifier modifier, float weight) m) => result3);
							int num15 = ((List<T>)(object)list).FindIndex((Predicate<>)(object)predicate3);
							if (num15 == -1)
							{
								int num16 = 0;
								((List<T>)(object)list).Add((T)num16);
							}
							int num17 = 0;
							System.ThrowHelper.ThrowArgumentOutOfRangeException();
							num15 += num15;
							int num18 = 0;
							((List<T>)(object)list)[num15] = (T)num18;
						}
					}
					int num19 = 0;
					while (!flag7)
					{
					}
					WeatherTimeline weatherTimeline3 = mainTimeline;
				}
				int num20 = 0;
				if (flag8)
				{
					WeatherTimeline weatherTimeline4 = mainTimeline;
				}
				List<(WeatherModifier, float)> list4 = prevFrameModifiers;
				if (flag9)
				{
					Predicate<(WeatherModifier, float)> predicate4 = (Predicate<(WeatherModifier, float)>)(object)(Predicate<T>)(((WeatherModifier modifier, float weight) m) => result2);
					if (((List<T>)(object)list).FindIndex((Predicate<>)(object)predicate4) != -1)
					{
						goto IL_0000;
					}
					modifier3.Disable();
				}
				if (flag10)
				{
					int num21 = 0;
					WeatherModifier modifier4 = (WeatherModifier)num21;
					List<(WeatherModifier, float)> list5 = prevFrameModifiers;
					Predicate<(WeatherModifier, float)> predicate5 = (Predicate<(WeatherModifier, float)>)(object)(Predicate<T>)(((WeatherModifier modifier, float weight) m) => result);
					if (((List<T>)(object)list5).FindIndex((Predicate<>)(object)predicate5) == -1)
					{
						modifier4.Enable();
					}
					WeatherModifier weatherModifier = modifier4;
					int num22 = 0;
					float num23 = time;
				}
				int num24 = 0;
				ApplySkyValues();
				int num25 = 0;
				ApplyEffectsValues();
				int num26 = 0;
				ApplyFogValues();
				int num27 = 0;
				ApplyPostProcessValues();
				int num28 = 0;
				ApplyLightingValues();
				if (CameraLight.updateCameraLightCallback != null)
				{
					WeatherTimeline weatherTimeline5 = mainTimeline;
					int num29 = 0;
					WeatherData.RuntimeBlendable cameraLightColor = WeatherIDs.lighting.cameraLightColor;
					WeatherTimeline weatherTimeline6 = mainTimeline;
					int num30 = 0;
					int id = WeatherIDs.lighting.cameraLightIntensity.id;
					float @float = weatherTimeline6.GetFloat(id);
				}
				WeatherMap map = mainTimeline.map;
				int num31 = 0;
				if (map != (UnityEngine.Object)num31)
				{
					mainTimeline.map.SendToShaders();
				}
			}
			while (!flag11);
			int num32 = 0;
			float num33 = time;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60015B8")]
		[Cpp2IlInjected.Address(RVA = "0xD53380", Offset = "0xD51D80", VA = "0x180D53380")]
		private static void ApplySkyValues()
		{
			//IL_0104: Expected F4, but got I4
			int num = 0;
			if (mainTimeline.isStatic)
			{
				WeatherTimeline weatherTimeline = mainTimeline;
			}
			int num2 = 0;
			float num3 = time;
			WeatherTimeline weatherTimeline2 = mainTimeline;
			int num4 = 0;
			WeatherData.RuntimeBlendable starsColor = WeatherIDs.sky.starsColor;
			WeatherTimeline weatherTimeline3 = mainTimeline;
			int num5 = 0;
			int id = WeatherIDs.sky.starsIntensity.id;
			Stars.starsIntensity = weatherTimeline3.GetFloat(id);
			WeatherTimeline weatherTimeline4 = mainTimeline;
			int num6 = 0;
			int id2 = WeatherIDs.lighting.shadowStrength.id;
			float @float = weatherTimeline4.GetFloat(id2);
			TimeSettings timeSettings = mainTimeline.time;
			@float = num3;
			float num7 = Mathf.Clamp01(@float);
			TimeSettings timeSettings2 = mainTimeline.time;
			num7 = num3;
			float num8 = Mathf.Clamp01(num7);
			num7 = Mathf.Clamp01(1f);
			float num9 = Mathf.Clamp01(1f);
			TimeSettings timeSettings3 = mainTimeline.time;
			if (!(num3 > timeSettings3.lightsDisablingTime))
			{
			}
			float lightsEnablingTime = mainTimeline.time.lightsEnablingTime;
			if (true)
			{
			}
			int num10 = 0;
			Shader.SetGlobalFloat("_GlobalEmissiveIntensity", num10);
			LightToggle.globalStatus = true;
			_lightsOn = true;
			Shader.SetGlobalFloat("_DayFactor", num7);
			num7 = num3;
			Shader.SetGlobalFloat("_TimeOfDay", num7);
			WeatherTimeline weatherTimeline5 = mainTimeline;
			int num11 = 0;
			int id3 = WeatherIDs.sky.skyVerticalOffset.id;
			num7 = weatherTimeline5.GetFloat(id3);
			Shader.SetGlobalFloat("_SkyVerticalOffset", num7);
			WeatherTimeline weatherTimeline6 = mainTimeline;
			int num12 = 0;
			int id4 = WeatherIDs.sky.atmosphereDayOffset.id;
			num7 = weatherTimeline6.GetFloat(id4);
			Shader.SetGlobalFloat("_DayOffset", num7);
			WeatherTimeline weatherTimeline7 = mainTimeline;
			int num13 = 0;
			int id5 = WeatherIDs.sky.atmosphereColorNight.id;
			float float2 = weatherTimeline7.GetFloat(id5);
			int num14 = 0;
			num7 = float2;
			Shader.SetGlobalFloat("_ColorNightDome", num7);
			TimeSettings timeSettings4 = mainTimeline.time;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			WeatherTimeline weatherTimeline8 = mainTimeline;
			int num15 = 0;
			WeatherData.RuntimeBlendable sunLightColor = WeatherIDs.lighting.sunLightColor;
			WeatherTimeline weatherTimeline9 = mainTimeline;
			int num16 = 0;
			int id6 = WeatherIDs.lighting.sunLightIntensity.id;
			Sun.lightIntensity = weatherTimeline9.GetFloat(id6);
			WeatherTimeline weatherTimeline10 = mainTimeline;
			int num17 = 0;
			WeatherData.RuntimeBlendable sunColor = WeatherIDs.sky.sunColor;
			WeatherTimeline weatherTimeline11 = mainTimeline;
			int num18 = 0;
			int id7 = WeatherIDs.sky.sunSize.id;
			Sun.size = weatherTimeline11.GetFloat(id7);
			Sun.shadowStrength = @float;
			int num19 = 0;
			TimeSettings timeSettings5 = mainTimeline.time;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			WeatherTimeline weatherTimeline12 = mainTimeline;
			int num20 = 0;
			WeatherData.RuntimeBlendable moonLightColor = WeatherIDs.lighting.moonLightColor;
			WeatherTimeline weatherTimeline13 = mainTimeline;
			int num21 = 0;
			int id8 = WeatherIDs.lighting.moonLightIntensity.id;
			Moon.lightIntensity = weatherTimeline13.GetFloat(id8);
			WeatherTimeline weatherTimeline14 = mainTimeline;
			int num22 = 0;
			WeatherData.RuntimeBlendable moonColor = WeatherIDs.sky.moonColor;
			WeatherTimeline weatherTimeline15 = mainTimeline;
			int num23 = 0;
			int id9 = WeatherIDs.sky.moonSize.id;
			Moon.size = weatherTimeline15.GetFloat(id9);
			Moon.shadowStrength = @float;
			WeatherTimeline weatherTimeline16 = mainTimeline;
			int num24 = 0;
			int id10 = WeatherIDs.sky.moonPhase.id;
			num7 = weatherTimeline16.GetFloat(id10);
			Shader.SetGlobalFloat("_MoonCycle", num7);
			float num25 = (SkyPrepass.sunSize = Sun.size);
			WeatherTimeline weatherTimeline17 = mainTimeline;
			int num26 = 0;
			int id11 = WeatherIDs.sky.sunGradientIntensity.id;
			SkyPrepass.sunGradientIntensity = weatherTimeline17.GetFloat(id11);
			WeatherTimeline weatherTimeline18 = mainTimeline;
			int num27 = 0;
			int id12 = WeatherIDs.sky.sunCorona.id;
			SkyPrepass.sunCoronaRange = weatherTimeline18.GetFloat(id12);
			WeatherTimeline weatherTimeline19 = mainTimeline;
			int num28 = 0;
			int id13 = WeatherIDs.sky.sunHorizonBlending.id;
			SkyPrepass.sunHorizonBlending = weatherTimeline19.GetFloat(id13);
			WeatherTimeline weatherTimeline20 = mainTimeline;
			int num29 = 0;
			int id14 = WeatherIDs.sky.sunHorizonPower.id;
			SkyPrepass.sunHorizonPower = weatherTimeline20.GetFloat(id14);
			SkyPrepass.moonSize = Moon.size;
			WeatherTimeline weatherTimeline21 = mainTimeline;
			int num30 = 0;
			int id15 = WeatherIDs.sky.moonGradientIntensity.id;
			SkyPrepass.moonGradientIntensity = weatherTimeline21.GetFloat(id15);
			WeatherTimeline weatherTimeline22 = mainTimeline;
			int num31 = 0;
			int id16 = WeatherIDs.sky.moonCorona.id;
			SkyPrepass.moonCoronaRange = weatherTimeline22.GetFloat(id16);
			WeatherTimeline weatherTimeline23 = mainTimeline;
			int num32 = 0;
			int id17 = WeatherIDs.sky.moonHorizonBlending.id;
			SkyPrepass.moonHorizonBlending = weatherTimeline23.GetFloat(id17);
			WeatherTimeline weatherTimeline24 = mainTimeline;
			int num33 = 0;
			int id18 = WeatherIDs.sky.moonHorizonPower.id;
			SkyPrepass.moonHorizonPower = weatherTimeline24.GetFloat(id18);
			WeatherTimeline weatherTimeline25 = mainTimeline;
			int num34 = 0;
			int id19 = WeatherIDs.sky.cloudScaleFactor.id;
			num25 = (Clouds.cloudsScaleFactor = weatherTimeline25.GetFloat(id19));
			WeatherTimeline weatherTimeline26 = mainTimeline;
			int num35 = 0;
			int id20 = WeatherIDs.sky.cloudCount.id;
			Clouds.cloudsCount = weatherTimeline26.GetFloat(id20);
			int cloudsAmbientColor = WeatherIDs._CloudsAmbientColor;
			WeatherTimeline weatherTimeline27 = mainTimeline;
			int num36 = 0;
			WeatherData.RuntimeBlendable cloudAmbientColor = WeatherIDs.sky.cloudAmbientColor;
			int cloudsGlobalColor = WeatherIDs._CloudsGlobalColor;
			WeatherTimeline weatherTimeline28 = mainTimeline;
			int num37 = 0;
			WeatherData.RuntimeBlendable cloudGlobalColor = WeatherIDs.sky.cloudGlobalColor;
			int cloudsContrast = WeatherIDs._CloudsContrast;
			WeatherTimeline weatherTimeline29 = mainTimeline;
			int num38 = 0;
			int id21 = WeatherIDs.sky.cloudContrast.id;
			num7 = weatherTimeline29.GetFloat(id21);
			Shader.SetGlobalFloatImpl(cloudsContrast, num7);
			WeatherTimeline weatherTimeline30 = mainTimeline;
			int num39 = 0;
			int id22 = WeatherIDs.sky.cloudScatteringSunFactor.id;
			num3 = weatherTimeline30.GetFloat(id22);
			float b = default(float);
			num9 = Mathf.Max(0.01f, b);
			WeatherTimeline weatherTimeline31 = mainTimeline;
			int num40 = 0;
			int id23 = WeatherIDs.sky.cloudScatteringMoonFactor.id;
			num25 = weatherTimeline31.GetFloat(id23);
			float b2 = default(float);
			@float = Mathf.Max(0.01f, b2);
			WeatherTimeline weatherTimeline32 = mainTimeline;
			int num41 = 0;
			int id24 = WeatherIDs.sky.cloudScatteringSunRange.id;
			float float3 = weatherTimeline32.GetFloat(id24);
			WeatherTimeline weatherTimeline33 = mainTimeline;
			int num42 = 0;
			WeatherData.RuntimeBlendable cloudScatteringMoonRange = WeatherIDs.sky.cloudScatteringMoonRange;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60015B9")]
		[Cpp2IlInjected.Address(RVA = "0xD51520", Offset = "0xD4FF20", VA = "0x180D51520")]
		private static void ApplyEffectsValues()
		{
			//Discarded unreachable code: IL_00ee
			//IL_00d4: Expected O, but got I4
			int wind_Force = WeatherIDs._Wind_Force;
			int num = 0;
			WeatherTimeline weatherTimeline = mainTimeline;
			int id = WeatherIDs.effects.windStrength.id;
			float @float = weatherTimeline.GetFloat(id);
			Shader.SetGlobalFloatImpl(wind_Force, @float);
			int wind_Frequency = WeatherIDs._Wind_Frequency;
			IWeatherController weatherController = current;
			Shader.SetGlobalFloatImpl(wind_Frequency, @float);
			int windAtlas = WeatherIDs._WindAtlas;
			IWeatherController weatherController2 = current;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			WeatherTimeline weatherTimeline2 = mainTimeline;
			int num4 = 0;
			int id2 = WeatherIDs.effects.windGrassStrength.id;
			GrassSettings.windGrassStrength = weatherTimeline2.GetFloat(id2);
			WeatherTimeline weatherTimeline3 = mainTimeline;
			int num5 = 0;
			int id3 = WeatherIDs.effects.windGrassSpeed.id;
			GrassSettings.windGrassSpeed = weatherTimeline3.GetFloat(id3);
			WindAtlas wind = mainTimeline.wind;
			int num6 = 0;
			if (wind != (UnityEngine.Object)num6)
			{
				WindAtlas wind2 = mainTimeline.wind;
				int num7 = 0;
				wind2.ShareBuffer();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015BA")]
		[Cpp2IlInjected.Address(RVA = "0xD518B0", Offset = "0xD502B0", VA = "0x180D518B0")]
		private static void ApplyFogValues()
		{
			//IL_0156: Expected O, but got I4
			//IL_01f9: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			WeatherTimeline weatherTimeline = mainTimeline;
			int num3 = 0;
			int id = WeatherIDs.effects.useFog.id;
			float @float = weatherTimeline.GetFloat(id);
			if (FogPass.useFog = false)
			{
				Shader.EnableKeyword("CUSTOM_FOG");
				int hF_FalloffCurve = WeatherIDs._HF_FalloffCurve;
				int num4 = 0;
				WeatherTimeline weatherTimeline2 = mainTimeline;
				int id2 = WeatherIDs.effects.heightFogFalloffCurve.id;
				float float2 = weatherTimeline2.GetFloat(id2);
				Shader.SetGlobalFloatImpl(hF_FalloffCurve, float2);
				int hF_UseHeightMap = WeatherIDs._HF_UseHeightMap;
				WeatherTimeline weatherTimeline3 = mainTimeline;
				int num5 = 0;
				int id3 = WeatherIDs.effects.heightFogUseMap.id;
				float2 = weatherTimeline3.GetFloat(id3);
				Shader.SetGlobalFloatImpl(hF_UseHeightMap, float2);
				WeatherTimeline weatherTimeline4 = mainTimeline;
				int num6 = 0;
				int id4 = WeatherIDs.effects.heightFogNearRange.id;
				float float3 = weatherTimeline4.GetFloat(id4);
				WeatherTimeline weatherTimeline5 = mainTimeline;
				int num7 = 0;
				int id5 = WeatherIDs.effects.heightFogNearHeight.id;
				float float4 = weatherTimeline5.GetFloat(id5);
				WeatherTimeline weatherTimeline6 = mainTimeline;
				int num8 = 0;
				int id6 = WeatherIDs.effects.heightFogNearFalloff.id;
				float float5 = weatherTimeline6.GetFloat(id6);
				WeatherTimeline weatherTimeline7 = mainTimeline;
				int num9 = 0;
				int id7 = WeatherIDs.effects.fogSkyColorsDistance.id;
				float float6 = weatherTimeline7.GetFloat(id7);
				float2 = float3;
				Shader.SetGlobalVector(WeatherIDs._HF_NearInfos, (Vector4)num);
				WeatherTimeline weatherTimeline8 = mainTimeline;
				int num10 = 0;
				int id8 = WeatherIDs.effects.heightFogFarRange.id;
				float3 = weatherTimeline8.GetFloat(id8);
				WeatherTimeline weatherTimeline9 = mainTimeline;
				int num11 = 0;
				int id9 = WeatherIDs.effects.heightFogFarHeight.id;
				float4 = weatherTimeline9.GetFloat(id9);
				WeatherTimeline weatherTimeline10 = mainTimeline;
				int num12 = 0;
				int id10 = WeatherIDs.effects.heightFogFarFalloff.id;
				float5 = weatherTimeline10.GetFloat(id10);
				WeatherTimeline weatherTimeline11 = mainTimeline;
				int num13 = 0;
				int id11 = WeatherIDs.effects.fogSkyColorsSmoothing.id;
				float float7 = weatherTimeline11.GetFloat(id11);
				Shader.SetGlobalVector(WeatherIDs._HF_FarInfos, (Vector4)num2);
				int num14 = 0;
				float4 = Time.deltaTime;
				WeatherTimeline weatherTimeline12 = mainTimeline;
				int num15 = 0;
				int id12 = WeatherIDs.effects.fogNoiseSpeed.id;
				fogNoiseTime = weatherTimeline12.GetFloat(id12);
				int fogNoiseAmplitudes = WeatherIDs._FogNoiseAmplitudes;
				WeatherTimeline weatherTimeline13 = mainTimeline;
				int num16 = 0;
				WeatherData.RuntimeBlendable fogNoiseAmplitudes2 = WeatherIDs.effects.fogNoiseAmplitudes;
				float value = fogNoiseTime;
				Shader.SetGlobalFloatImpl(WeatherIDs._FogNoiseTime, value);
				return;
			}
			Shader.DisableKeyword("CUSTOM_FOG");
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60015BB")]
		[Cpp2IlInjected.Address(RVA = "0xD52410", Offset = "0xD50E10", VA = "0x180D52410")]
		private static void ApplyPostProcessValues()
		{
			//Discarded unreachable code: IL_04ac
			//IL_0185: Expected O, but got I4
			bool flag = default(bool);
			if (flag)
			{
				Bloom bloom = WeatherController.bloom;
				WeatherTimeline weatherTimeline = mainTimeline;
				MinFloatParameter intensity = bloom.intensity;
				int num = 0;
				int id = WeatherIDs.postProcess.bloomIntensity.id;
				float num2 = (intensity.value = weatherTimeline.GetFloat(id));
				MinFloatParameter threshold = WeatherController.bloom.threshold;
				int num3 = 0;
				WeatherTimeline weatherTimeline2 = mainTimeline;
				int id2 = WeatherIDs.postProcess.bloomThreshold.id;
				num2 = (threshold.value = weatherTimeline2.GetFloat(id2));
				ClampedFloatParameter scatter = WeatherController.bloom.scatter;
				int num4 = 0;
				WeatherTimeline weatherTimeline3 = mainTimeline;
				int id3 = WeatherIDs.postProcess.bloomScattering.id;
				num2 = (scatter.value = weatherTimeline3.GetFloat(id3));
				ColorParameter tint = WeatherController.bloom.tint;
				int num5 = 0;
				WeatherTimeline weatherTimeline4 = mainTimeline;
				WeatherData.RuntimeBlendable bloomColor = WeatherIDs.postProcess.bloomColor;
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				Vignette vignette = WeatherController.vignette;
				WeatherTimeline weatherTimeline5 = mainTimeline;
				ClampedFloatParameter intensity2 = vignette.intensity;
				int num6 = 0;
				int id4 = WeatherIDs.postProcess.vignetteIntensity.id;
				float num7 = (intensity2.value = weatherTimeline5.GetFloat(id4));
				ColorParameter color = WeatherController.vignette.color;
				int num8 = 0;
				WeatherTimeline weatherTimeline6 = mainTimeline;
				WeatherData.RuntimeBlendable vignetteColor = WeatherIDs.postProcess.vignetteColor;
			}
			bool flag3 = default(bool);
			if (flag3)
			{
				ColorAdjustments colorAdjustments = WeatherController.colorAdjustments;
				WeatherTimeline weatherTimeline7 = mainTimeline;
				FloatParameter postExposure = colorAdjustments.postExposure;
				int num9 = 0;
				int id5 = WeatherIDs.postProcess.colorAdjPostExposure.id;
				float num7 = weatherTimeline7.GetFloat(id5);
				((VolumeParameter<T>)(object)postExposure).value = (T)id5;
				ClampedFloatParameter contrast = WeatherController.colorAdjustments.contrast;
				int num10 = 0;
				WeatherTimeline weatherTimeline8 = mainTimeline;
				int id6 = WeatherIDs.postProcess.colorAdjContrast.id;
				num7 = (contrast.value = weatherTimeline8.GetFloat(id6));
				ColorParameter colorFilter = WeatherController.colorAdjustments.colorFilter;
				int num11 = 0;
				WeatherTimeline weatherTimeline9 = mainTimeline;
				WeatherData.RuntimeBlendable colorAdjFilter = WeatherIDs.postProcess.colorAdjFilter;
				ClampedFloatParameter hueShift = WeatherController.colorAdjustments.hueShift;
				int num12 = 0;
				WeatherTimeline weatherTimeline10 = mainTimeline;
				int id7 = WeatherIDs.postProcess.colorAdjHueShift.id;
				num7 = (hueShift.value = weatherTimeline10.GetFloat(id7));
				ClampedFloatParameter saturation = WeatherController.colorAdjustments.saturation;
				int num13 = 0;
				WeatherTimeline weatherTimeline11 = mainTimeline;
				int id8 = WeatherIDs.postProcess.colorAdjSaturation.id;
				num7 = (saturation.value = weatherTimeline11.GetFloat(id8));
			}
			bool flag4 = default(bool);
			if (flag4)
			{
				SplitToning splitToning = WeatherController.splitToning;
				WeatherTimeline weatherTimeline12 = mainTimeline;
				ColorParameter shadows = splitToning.shadows;
				int num14 = 0;
				WeatherData.RuntimeBlendable splitToningShadows = WeatherIDs.postProcess.splitToningShadows;
				ColorParameter highlights = WeatherController.splitToning.highlights;
				int num15 = 0;
				WeatherTimeline weatherTimeline13 = mainTimeline;
				WeatherData.RuntimeBlendable splitToningHighlits = WeatherIDs.postProcess.splitToningHighlits;
				ClampedFloatParameter balance = WeatherController.splitToning.balance;
				int num16 = 0;
				WeatherTimeline weatherTimeline14 = mainTimeline;
				int id9 = WeatherIDs.postProcess.splitToningBalance.id;
				float num7 = (balance.value = weatherTimeline14.GetFloat(id9));
				ColorParameter shadows2 = WeatherController.splitToning.shadows;
				bool flag6 = (shadows2.overrideState = (long)"{il2cpp field on {'constant243' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0xD0}" == 0);
				ColorParameter highlights2 = WeatherController.splitToning.highlights;
				bool flag8 = (highlights2.overrideState = (long)"{il2cpp field on {'constant251' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0xD0}" == 0);
				ClampedFloatParameter balance2 = WeatherController.splitToning.balance;
				bool flag10 = (balance2.overrideState = (long)"{il2cpp field on {'constant259' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0xD0}" == 0);
			}
			WeatherTimeline weatherTimeline15 = mainTimeline;
			int num17 = 0;
			int id10 = WeatherIDs.postProcess.bloomEdgesThreshold.id;
			float num18 = Mathf.GammaToLinearSpace(weatherTimeline15.GetFloat(id10));
			WeatherTimeline weatherTimeline16 = mainTimeline;
			int num19 = 0;
			int id11 = WeatherIDs.postProcess.bloomEdgesScattering.id;
			float float9 = weatherTimeline16.GetFloat(id11);
			float num20 = Mathf.Lerp(0.05f, 0.95f, float9);
			WeatherTimeline weatherTimeline17 = mainTimeline;
			int num21 = 0;
			int id12 = WeatherIDs.postProcess.bloomEdgesIntensity.id;
			float float10 = weatherTimeline17.GetFloat(id12);
			int num22 = 0;
			WeatherTimeline weatherTimeline18 = mainTimeline;
			int num23 = 0;
			WeatherData.RuntimeBlendable bloomEdgesColor = WeatherIDs.postProcess.bloomEdgesColor;
			int useBloomVignette = WeatherIDs._UseBloomVignette;
			WeatherTimeline weatherTimeline19 = mainTimeline;
			int num24 = 0;
			int id13 = WeatherIDs.postProcess.bloomEdgesFactor.id;
			float float11 = weatherTimeline19.GetFloat(id13);
			Shader.SetGlobalFloatImpl(useBloomVignette, float11);
			int bloom_IntensityTint = WeatherIDs._Bloom_IntensityTint;
			float11 = num18;
			float num25 = float11 * 0.5f;
			num25 = num20;
			int bloomParams = WeatherIDs._BloomParams2;
			int useColorGradVignette = WeatherIDs._UseColorGradVignette;
			WeatherTimeline weatherTimeline20 = mainTimeline;
			int num26 = 0;
			int id14 = WeatherIDs.postProcess.colorAdjEdgesFactor.id;
			num25 = weatherTimeline20.GetFloat(id14);
			Shader.SetGlobalFloatImpl(useColorGradVignette, num25);
			int globalGlossBias = WeatherIDs._GlobalGlossBias;
			WeatherTimeline weatherTimeline21 = mainTimeline;
			int num27 = 0;
			int id15 = WeatherIDs.postProcess.globalGlossBias.id;
			num25 = weatherTimeline21.GetFloat(id15);
			Shader.SetGlobalFloatImpl(globalGlossBias, num25);
		}

		[Cpp2IlInjected.Token(Token = "0x60015BC")]
		[Cpp2IlInjected.Address(RVA = "0xD52140", Offset = "0xD50B40", VA = "0x180D52140")]
		private static void ApplyLightingValues()
		{
			//Discarded unreachable code: IL_0048
			int num = 0;
			WeatherTimeline weatherTimeline = mainTimeline;
			int num2 = 0;
			int id = WeatherIDs.lighting.ambientLight.id;
			float @float = weatherTimeline.GetFloat(id);
			int num3 = 0;
			WeatherTimeline weatherTimeline2 = mainTimeline;
			string[] shKey = WeatherIDs.shKey;
			num3++;
			RenderSettings.ambientMode = AmbientMode.Custom;
			RenderSettings.ambientSkyboxAmount = @float;
		}

		[Cpp2IlInjected.Token(Token = "0x60015BD")]
		[Cpp2IlInjected.Address(RVA = "0xD513D0", Offset = "0xD4FDD0", VA = "0x180D513D0")]
		private static void ApplyCameraLightValues()
		{
			//Discarded unreachable code: IL_0042
			if (CameraLight.updateCameraLightCallback != null)
			{
				WeatherTimeline weatherTimeline = mainTimeline;
				int num = 0;
				WeatherData.RuntimeBlendable cameraLightColor = WeatherIDs.lighting.cameraLightColor;
				WeatherTimeline weatherTimeline2 = mainTimeline;
				int num2 = 0;
				int id = WeatherIDs.lighting.cameraLightIntensity.id;
				float @float = weatherTimeline2.GetFloat(id);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015BE")]
		[Cpp2IlInjected.Address(RVA = "0xD57DD0", Offset = "0xD567D0", VA = "0x180D57DD0")]
		private static void SetLights(bool enable)
		{
			//IL_0011: Expected F4, but got I4
			if (enable)
			{
			}
			int num = 0;
			Shader.SetGlobalFloat("_GlobalEmissiveIntensity", num);
			LightToggle.globalStatus = enable;
		}

		[Cpp2IlInjected.Token(Token = "0x60015BF")]
		[Cpp2IlInjected.Address(RVA = "0xD581E0", Offset = "0xD56BE0", VA = "0x180D581E0")]
		public static void SetTimelinesOverride(WeatherTimeline timeline)
		{
			//IL_0006: Expected I4, but got O
			paused = (byte)(int)timeline != 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60015C0")]
		[Cpp2IlInjected.Address(RVA = "0xD55D60", Offset = "0xD54760", VA = "0x180D55D60")]
		public static void DisableTimelineOverride()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60015C2")]
		[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD56B20", VA = "0x180D58120")]
		public static void SetTimeOverride(float time, double duration = 3.0)
		{
			int num = 0;
			double realtimeSinceStartupAsDouble = Time.realtimeSinceStartupAsDouble;
			overrideTimeValue = time;
		}

		[Cpp2IlInjected.Token(Token = "0x60015C3")]
		[Cpp2IlInjected.Address(RVA = "0xD55D00", Offset = "0xD54700", VA = "0x180D55D00")]
		public static void DisableTimeOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60015C4")]
		[Cpp2IlInjected.Address(RVA = "0xD57E30", Offset = "0xD56830", VA = "0x180D57E30")]
		public static void SetPostProcessOverride(PostProcess postProcess, double duration)
		{
			int num = 0;
			double realtimeSinceStartupAsDouble = Time.realtimeSinceStartupAsDouble;
			overridePostProcessValue = postProcess;
			Evaluate(current, force: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60015C5")]
		[Cpp2IlInjected.Address(RVA = "0xD55CA0", Offset = "0xD546A0", VA = "0x180D55CA0")]
		public static void DisablePostProcessOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60015C6")]
		[Cpp2IlInjected.Address(RVA = "0xD56CA0", Offset = "0xD556A0", VA = "0x180D56CA0")]
		public static PostProcess GetPostProcess(bool ignoreOverride)
		{
			if (!ignoreOverride)
			{
				return overridePostProcessValue;
			}
			return GraphicSettings.PostProcess;
		}

		[Cpp2IlInjected.Token(Token = "0x60015C7")]
		[Cpp2IlInjected.Address(RVA = "0xD57F80", Offset = "0xD56980", VA = "0x180D57F80")]
		public static void SetTag(string label, float value)
		{
			//Discarded unreachable code: IL_004b
			//IL_003c: Expected F4, but got I4
			//IL_004a: Expected O, but got I4
			if (!(value > 0.001f))
			{
				bool flag = ((Dictionary<TKey, TValue>)(object)tags).Remove((TKey)label);
				return;
			}
			int num = 0;
			GameSettingsSystem gameSettingsSystem = default(GameSettingsSystem);
			if (string.Equals(label, "Rain") && gameSettingsSystem.DisableFlashes)
			{
				int num2 = 0;
				float num3 = Mathf.Clamp(value, num2, 0.79f);
			}
			((Dictionary<TKey, TValue>)(object)tags)[(TKey)label] = (TValue)num;
		}

		[Cpp2IlInjected.Token(Token = "0x60015C8")]
		[Cpp2IlInjected.Address(RVA = "0xD56D80", Offset = "0xD55780", VA = "0x180D56D80")]
		public static float GetTag(string label)
		{
			Dictionary<string, float> dictionary = tags;
			bool flag = default(bool);
			if (!flag)
			{
				int num = 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60015C9")]
		[Cpp2IlInjected.Address(RVA = "0xD56A80", Offset = "0xD55480", VA = "0x180D56A80")]
		public static IEnumerable<KeyValuePair<string, float>> GetActiveTags()
		{
			Dictionary<string, float> dictionary = tags;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60015CA")]
		[Cpp2IlInjected.Address(RVA = "0xD57CB0", Offset = "0xD566B0", VA = "0x180D57CB0")]
		public static void ResetTags()
		{
			//Discarded unreachable code: IL_000b
			((Dictionary<TKey, TValue>)(object)tags).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x60015CB")]
		[Cpp2IlInjected.Address(RVA = "0xD57D30", Offset = "0xD56730", VA = "0x180D57D30")]
		public static void SetAnchor(Transform anchor, [Optional] Vector3 offset)
		{
			//IL_0006: Expected I4, but got O
			paused = (byte)(int)anchor != 0;
			float z = offset.z;
		}

		[Cpp2IlInjected.Token(Token = "0x60015CC")]
		[Cpp2IlInjected.Address(RVA = "0xD57960", Offset = "0xD56360", VA = "0x180D57960")]
		public static void ResetAnchor()
		{
			//Discarded unreachable code: IL_0050
			//IL_001e: Expected O, but got I4
			//IL_001e: Expected O, but got I4
			//IL_0049: Expected I4, but got O
			//IL_004f: Expected O, but got I4
			int num = 0;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField == null || (object)_003CInstance_003Ek__BackingField._avatar != null)
			{
			}
			int num2 = 0;
			if (!((UnityEngine.Object)num != (UnityEngine.Object)num2))
			{
				IWeatherController weatherController = current;
				int num3 = 0;
				if (weatherController != null)
				{
					int num4 = 0;
					if (weatherController != null)
					{
						goto IL_0035;
					}
				}
				throw new InvalidCastException();
			}
			goto IL_0035;
			IL_0035:
			paused = (byte)(int)SystemRoot.Instance._avatar.transform != 0;
			anchorOffset = (Vector3)0;
		}

		[Cpp2IlInjected.Token(Token = "0x60015CD")]
		[Cpp2IlInjected.Address(RVA = "0xD56AE0", Offset = "0xD554E0", VA = "0x180D56AE0")]
		public static Vector3 GetAnchorPoint()
		{
			//IL_000f: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			Transform transform = anchor;
			int num = 0;
			if (transform == (UnityEngine.Object)num)
			{
				int num2 = 0;
				ResetAnchor();
			}
			Transform transform2 = anchor;
			int num3 = 0;
			if (!(transform2 == (UnityEngine.Object)num3))
			{
				Transform transform3 = anchor;
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60015CE")]
		[Cpp2IlInjected.Address(RVA = "0xD58540", Offset = "0xD56F40", VA = "0x180D58540")]
		private static void UpdateCubemap()
		{
			//Discarded unreachable code: IL_0112
			//IL_0011: Expected O, but got I4
			//IL_006c: Expected O, but got I4
			//IL_009b: Expected O, but got I4
			//IL_009b: Expected O, but got I4
			//IL_00e8: Expected O, but got I4
			//IL_010c: Expected O, but got I4
			int num = 0;
			WeatherTimeline weatherTimeline = mainTimeline;
			int num2 = 0;
			if (weatherTimeline == (UnityEngine.Object)num2)
			{
				return;
			}
			if ((mainTimeline.isStatic ? 1 : 0) != num)
			{
				WeatherTimeline weatherTimeline2 = mainTimeline;
			}
			int num3 = 0;
			float num4 = time;
			RenderSettings.defaultReflectionMode = DefaultReflectionMode.Custom;
			if (!currentCubemap.IsValid() || (object)currentCubemap.Asset != null)
			{
			}
			ProbeData lighting = mainTimeline.lighting;
			int num5 = 0;
			if (lighting != (UnityEngine.Object)num5)
			{
				ProbeData lighting2 = mainTimeline.lighting;
				bool flag = default(bool);
				if (flag)
				{
					goto IL_0106;
				}
			}
			if ((object)mainTimeline.parent != null)
			{
			}
			int num6 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num6)
			{
				ProbeData lighting3 = mainTimeline.parent.lighting;
				bool flag2 = default(bool);
				if (flag2)
				{
					goto IL_0106;
				}
			}
			WeatherTimeline parent = mainTimeline.parent;
			ProbeData lighting4 = default(ProbeData);
			if ((object)parent != null)
			{
				WeatherTimeline parent2 = parent.parent;
				if ((object)parent2 != null)
				{
					lighting4 = parent2.lighting;
				}
			}
			int num7 = 0;
			if (lighting4 != (UnityEngine.Object)num7)
			{
				ProbeData lighting5 = mainTimeline.parent.parent.lighting;
				bool flag3 = default(bool);
				if (!flag3)
				{
					return;
				}
				goto IL_0106;
			}
			return;
			IL_0106:
			LoadCubemap((AssetReference)num).FireAndForgetTask();
			[Cpp2IlInjected.Token(Token = "0x60015D2")]
			[Cpp2IlInjected.Address(RVA = "0xD58430", Offset = "0xD56E30", VA = "0x180D58430")]
			[AsyncStateMachine(typeof(_003C_003CUpdateCubemap_003Eg__LoadCubemap_007C100_1_003Ed))]
			static Task LoadCubemap(AssetReference newCubemap)
			{
				int num8 = 0;
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015CF")]
		[Cpp2IlInjected.Address(RVA = "0xD5A200", Offset = "0xD58C00", VA = "0x180D5A200")]
		static WeatherController()
		{
			//IL_000a: Expected I4, but got O
			//IL_0014: Expected I4, but got O
			//IL_001e: Expected I4, but got O
			//IL_0029: Expected I4, but got O
			//IL_0034: Expected I4, but got O
			paused = (byte)(int)new List<T>() != 0;
			paused = (byte)(int)new HashSet<T>() != 0;
			paused = (byte)(int)new float[0] != 0;
			paused = (byte)(int)new Texture[0] != 0;
			/*Error: Unexpected end of block*/;
		}
	}
}
