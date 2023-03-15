using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mdl.Graphic.Weather;
using Mdl.Performance;
using Mdl.Systems;
using Meta.Util;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

[Cpp2IlInjected.Token(Token = "0x200004B")]
public class GraphicSettings : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private static float OldDefaultCullingDistance;

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private static float OldGroundCullingDistance;

	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private static bool IsGroundCullingDistanceDisabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public List<GraphicSettingsData> OriginalGraphicSettingsData = (List<GraphicSettingsData>)(object)new List<T>();

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[SerializeField]
	private List<GraphicSettingsData> _settings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[SerializeField]
	private GraphicSettingsDataOverride _settingsOverrides;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public const string NoOverride = "NoOverride";

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public const string QualityDefault = "Default";

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public const string QualityUltraLow = "PC Ultra Low";

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public const string QualityVeryLow = "PC Very Low";

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public const string QualityLow = "PC Low";

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public const string QualityMedium = "PC Medium";

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public const string QualityHigh = "PC High";

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public const string QualityVeryHigh = "PC Very High";

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public const string QualityUltra = "PC Ultra";

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public const string QualityUltraHigh = "PC Ultra High";

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public const string QualitySwitch = "Switch";

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public const string QualitySwitchDocked = "SwitchDocked";

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public const string QualityPS4 = "PS4";

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public const string QualityPS4Pro = "PS4 Pro";

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public const string QualityPS5 = "PS5";

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public const string QualityXboxOne = "XboxOne";

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public const string QualityXboxOneS = "XboxOneS";

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public const string QualityXboxOneX = "XboxOneX";

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public const string QualityXboxSeriesS = "XboxSeriesS";

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public const string QualityXboxSeriesX = "XboxSeriesX";

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public const string QualityiOSLow = "iOS Low";

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public const string QualityiOSMedium = "iOS Medium";

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public const string QualityiOSHigh = "iOS High";

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public const string QualityAndroidLow = "Android Low";

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public const string QualityAndroidMedium = "Android Medium";

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public const string QualityAndroidHigh = "Android High";

	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public const string QualityUnknown = "Unknown";

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public const string DisplayModeFullscreen = "menu.settings_graphics_display_mode_fullscreen";

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public const string DisplayModeWindowed = "menu.settings_graphics_display_mode_windowed";

	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public const string DisplayModeFullscreenNoBorders = "menu.settings_graphics_display_mode_fullscreen_no_borders";

	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public const int TextureQualityDefaultValue = 0;

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public const string TextureQualityDefault = "menu.settings_graphics_texture_quality_default";

	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public const int TextureQualityLowValue = 1;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public const string TextureQualityLow = "menu.settings_graphics_texture_quality_low";

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int TextureQualityVeryLowValue = 2;

	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public const string TextureQualityVeryLow = "menu.settings_graphics_texture_quality_very_low";

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private FrameTiming[] frameTimings = new FrameTiming[1];

	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public static double gpuFrameTime;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public static double cpuFrameTime;

	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private static Dictionary<string, GameObject> VfxLayerMap;

	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private static bool ApplyGraphicQualitySettingsCalled;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private static bool IsInGraphicQualitySettings;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private static bool _enableShadow;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private static bool _enableParticles;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static bool _enablePostProcess;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static bool _enableEvilFog;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public static PostProcess PostProcess;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static GraphicSettings Instance
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xCE95A0", Offset = "0xCE7FA0", VA = "0x180CE95A0")]
		[CompilerGenerated]
		get
		{
			return _003CInstance_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xCEA390", Offset = "0xCE8D90", VA = "0x180CEA390")]
		[CompilerGenerated]
		private set
		{
			_003CInstance_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<GraphicSettingsData> GraphicSettingsData
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
		get
		{
			return _settings;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
		set
		{
			_settings = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public GraphicSettingsDataOverride GraphicSettingsDataOverrides
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
		get
		{
			return _settingsOverrides;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	[field: Cpp2IlInjected.Token(Token = "0x4000196")]
	public static float FogCullingOffsetOverride
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xCE9300", Offset = "0xCE7D00", VA = "0x180CE9300")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xCEA0C0", Offset = "0xCE8AC0", VA = "0x180CEA0C0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	[field: Cpp2IlInjected.Token(Token = "0x4000197")]
	public static bool HasSSAO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xCE94E0", Offset = "0xCE7EE0", VA = "0x180CE94E0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xCEA2D0", Offset = "0xCE8CD0", VA = "0x180CEA2D0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	[field: Cpp2IlInjected.Token(Token = "0x4000198")]
	public static bool NPCCameraLights
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xCE96D0", Offset = "0xCE80D0", VA = "0x180CE96D0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xCEA590", Offset = "0xCE8F90", VA = "0x180CEA590")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	[field: Cpp2IlInjected.Token(Token = "0x4000199")]
	public static bool HasGrass
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xCE9480", Offset = "0xCE7E80", VA = "0x180CE9480")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xCEA270", Offset = "0xCE8C70", VA = "0x180CEA270")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	[field: Cpp2IlInjected.Token(Token = "0x400019A")]
	public static float GrassDistanceBias
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xCE9420", Offset = "0xCE7E20", VA = "0x180CE9420")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xCEA200", Offset = "0xCE8C00", VA = "0x180CEA200")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	[field: Cpp2IlInjected.Token(Token = "0x400019B")]
	public static float GrassDensityFactor
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xCE93C0", Offset = "0xCE7DC0", VA = "0x180CE93C0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xCEA190", Offset = "0xCE8B90", VA = "0x180CEA190")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	[field: Cpp2IlInjected.Token(Token = "0x400019C")]
	public static float SkyPrepassResFactor
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xCE9790", Offset = "0xCE8190", VA = "0x180CE9790")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xCEA650", Offset = "0xCE9050", VA = "0x180CEA650")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	[field: Cpp2IlInjected.Token(Token = "0x400019D")]
	public static int ForceLOD
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xCE9360", Offset = "0xCE7D60", VA = "0x180CE9360")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xCEA130", Offset = "0xCE8B30", VA = "0x180CEA130")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	[field: Cpp2IlInjected.Token(Token = "0x400019E")]
	public static float TargetGPUFrameTime
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xCE9850", Offset = "0xCE8250", VA = "0x180CE9850")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xCEA730", Offset = "0xCE9130", VA = "0x180CEA730")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[field: Cpp2IlInjected.Token(Token = "0x400019F")]
	public static bool DynamicResolution
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xCE9090", Offset = "0xCE7A90", VA = "0x180CE9090")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xCE9A40", Offset = "0xCE8440", VA = "0x180CE9A40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	[field: Cpp2IlInjected.Token(Token = "0x40001A0")]
	public static float SortCriteriaBias
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xCE97F0", Offset = "0xCE81F0", VA = "0x180CE97F0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xCEA6C0", Offset = "0xCE90C0", VA = "0x180CEA6C0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	[field: Cpp2IlInjected.Token(Token = "0x40001A1")]
	public static bool OptimizedDepthPriming
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xCE9730", Offset = "0xCE8130", VA = "0x180CE9730")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xCEA5F0", Offset = "0xCE8FF0", VA = "0x180CEA5F0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	[field: Cpp2IlInjected.Token(Token = "0x40001A2")]
	public static bool TilesetInDepthPriming
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xCE98B0", Offset = "0xCE82B0", VA = "0x180CE98B0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xCEA7A0", Offset = "0xCE91A0", VA = "0x180CEA7A0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static GraphicSettingsData CurrentGraphicSettingsData
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xCE8FE0", Offset = "0xCE79E0", VA = "0x180CE8FE0")]
		[CompilerGenerated]
		get
		{
			return _003CCurrentGraphicSettingsData_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xCE99D0", Offset = "0xCE83D0", VA = "0x180CE99D0")]
		[CompilerGenerated]
		set
		{
			Instance = (GraphicSettings)(object)value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static WeatherSystem WeatherTrigger
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xCE9910", Offset = "0xCE8310", VA = "0x180CE9910")]
		[CompilerGenerated]
		get
		{
			return _003CWeatherTrigger_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xCEA800", Offset = "0xCE9200", VA = "0x180CEA800")]
		[CompilerGenerated]
		set
		{
			Instance = (GraphicSettings)(object)value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	[field: Cpp2IlInjected.Token(Token = "0x40001A6")]
	public static bool InitializeGraphicQualityCalled
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xCE9540", Offset = "0xCE7F40", VA = "0x180CE9540")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xCEA330", Offset = "0xCE8D30", VA = "0x180CEA330")]
		private set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static int LodSkipInit
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xCEA4E0", Offset = "0xCE8EE0", VA = "0x180CEA4E0")]
		set
		{
			//Discarded unreachable code: IL_002b
			int num = 0;
			LodSkipEnum overrideLodSkip_ = DebugSettings.Settings.overrideLodSkip_;
			if (overrideLodSkip_ != 0)
			{
				switch (overrideLodSkip_)
				{
				}
			}
			int num2 = 0;
			uint num3 = default(uint);
			if (QualitySettings.maximumLODLevel != (int)num3)
			{
				QualitySettings.maximumLODLevel = (int)num3;
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static int LodSkip
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xCE96C0", Offset = "0xCE80C0", VA = "0x180CE96C0")]
		get
		{
			int num = 0;
			return QualitySettings.maximumLODLevel;
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xCEA580", Offset = "0xCE8F80", VA = "0x180CEA580")]
		set
		{
			QualitySettings.maximumLODLevel = value;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	[field: Cpp2IlInjected.Token(Token = "0x40001AA")]
	public static bool _supportShadow
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xCE9970", Offset = "0xCE8370", VA = "0x180CE9970")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xCEA870", Offset = "0xCE9270", VA = "0x180CEA870")]
		private set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static bool EnableShadow
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xCE92A0", Offset = "0xCE7CA0", VA = "0x180CE92A0")]
		get
		{
			return _enableShadow;
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xCE9E20", Offset = "0xCE8820", VA = "0x180CE9E20")]
		set
		{
			//Discarded unreachable code: IL_0054
			bool flag = (IntPtr)"{il2cpp field on {'constant16' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x6B}" != (IntPtr)(value ? 1 : 0);
			_enableShadow = value;
			int num = 0;
			if (!DebugSettings.Settings.runtimeAdjustableQuality_ && !value)
			{
				int num2 = 0;
				GraphicSettings graphicSettings = Instance;
				int num3 = 0;
				FieldInfo field = typeof(UniversalRenderPipelineAsset).GetField("m_MainLightShadowsSupported", BindingFlags.Instance | BindingFlags.NonPublic);
			}
			if (flag)
			{
				UpdateShadow(force: true);
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static bool EnableParticles
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xCE9150", Offset = "0xCE7B50", VA = "0x180CE9150")]
		get
		{
			return _enableParticles;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xCE9B00", Offset = "0xCE8500", VA = "0x180CE9B00")]
		set
		{
			bool flag = (IntPtr)"{il2cpp field on {'constant10' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x6D}" != (IntPtr)(value ? 1 : 0);
			_enableParticles = value;
			if (flag)
			{
				UpdateParticles(force: true);
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[field: Cpp2IlInjected.Token(Token = "0x40001AC")]
	public static float LodAnimationLoadDistance
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xCE9600", Offset = "0xCE8000", VA = "0x180CE9600")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xCEA400", Offset = "0xCE8E00", VA = "0x180CEA400")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	[field: Cpp2IlInjected.Token(Token = "0x40001AD")]
	public static float LodAnimationUnloadOffset
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xCE9660", Offset = "0xCE8060", VA = "0x180CE9660")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xCEA470", Offset = "0xCE8E70", VA = "0x180CEA470")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static bool EnablePostProcess
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xCE91B0", Offset = "0xCE7BB0", VA = "0x180CE91B0")]
		get
		{
			Camera playerCamera = SystemRoot.Instance._playerCamera;
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			throw new NullReferenceException();
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xCE9BD0", Offset = "0xCE85D0", VA = "0x180CE9BD0")]
		set
		{
			//Discarded unreachable code: IL_0033
			bool flag = (IntPtr)"{il2cpp field on {'constant10' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x78}" != (IntPtr)(value ? 1 : 0);
			_enablePostProcess = value;
			if (flag)
			{
				Camera playerCamera = SystemRoot.Instance._playerCamera;
				bool flag2 = default(bool);
				if (flag2)
				{
					bool enablePostProcess = _enablePostProcess;
				}
			}
			_enablePostProcess = value;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static bool EnableEvilFog
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xCE90F0", Offset = "0xCE7AF0", VA = "0x180CE90F0")]
		get
		{
			return _enableEvilFog;
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xCE9AA0", Offset = "0xCE84A0", VA = "0x180CE9AA0")]
		set
		{
			_enableEvilFog = value;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static string CurrentQualitySettingsName
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xCE9040", Offset = "0xCE7A40", VA = "0x180CE9040")]
		get
		{
			//Discarded unreachable code: IL_0018
			int num = 0;
			string[] names = QualitySettings.names;
			int num2 = 0;
			int qualityLevel = QualitySettings.GetQualityLevel();
			return names[qualityLevel];
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0xCE6380", Offset = "0xCE4D80", VA = "0x180CE6380")]
	private void OnEnable()
	{
		int num = 0;
		LowMemoryManager.CreateSingleton();
		SceneManager.add_sceneLoaded((UnityAction<, >)(object)new UnityAction<T0, T1>(OnSceneLoaded));
		SceneManager.add_sceneUnloaded((UnityAction<>)(object)new UnityAction<T0>(OnSceneUnloaded));
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0xCE6270", Offset = "0xCE4C70", VA = "0x180CE6270")]
	private void OnDisable()
	{
		SceneManager.remove_sceneLoaded((UnityAction<, >)(object)new UnityAction<T0, T1>(OnSceneLoaded));
		SceneManager.remove_sceneUnloaded((UnityAction<>)(object)new UnityAction<T0>(OnSceneUnloaded));
		int num = 0;
		LowMemoryManager.DestroySingleton();
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xCE69D0", Offset = "0xCE53D0", VA = "0x180CE69D0")]
	[RuntimeInitializeOnLoadMethod]
	private static void ReloadGraphicSettings()
	{
		//Discarded unreachable code: IL_000b
		((Dictionary<TKey, TValue>)(object)VfxLayerMap).Clear();
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0xCE4FB0", Offset = "0xCE39B0", VA = "0x180CE4FB0")]
	private void Awake()
	{
		Instance = this;
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0xCE7B60", Offset = "0xCE6560", VA = "0x180CE7B60")]
	private void Start()
	{
		//Discarded unreachable code: IL_0068
		int num = 0;
		int qualityLevel = QualitySettings.GetQualityLevel();
		string text = default(string);
		string text2 = "Initial Quality Level: " + text;
		int num2 = 0;
		string text3 = default(string);
		string text4 = "SystemInfo.graphicsShaderLevel: " + text3;
		int num3 = 0;
		string text5 = default(string);
		string text6 = "SystemInfo.systemMemorySize: " + text5;
		int num4 = 0;
		List<GraphicSettingsData> settings = Instance._settings;
		int size = ((List<>)(object)settings)._size;
		object syncRoot = ((List<>)(object)settings)._syncRoot;
		num4++;
		InitializeGraphicQuality();
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0xCE6810", Offset = "0xCE5210", VA = "0x180CE6810")]
	private static GameObject RecursiveBreathFirstSearch(GameObject go, string name, int maxDepth = 3)
	{
		Transform transform = go.transform.Find(name);
		if (!transform && maxDepth > 0)
		{
			Transform[] componentsInChildren = go.GetComponentsInChildren<Transform>();
			int num = 0;
			int length = componentsInChildren.Length;
			if (num < length)
			{
				GameObject go2 = componentsInChildren[num].gameObject;
				int maxDepth2 = maxDepth - 1;
				GameObject gameObject = RecursiveBreathFirstSearch(go2, name, maxDepth2);
				if (!gameObject)
				{
					num++;
				}
				return gameObject;
			}
		}
		GameObject gameObject2 = transform.gameObject;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0xCE6490", Offset = "0xCE4E90", VA = "0x180CE6490")]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		//Discarded unreachable code: IL_0040
		GameObject[] array = default(GameObject[]);
		if (array != null && array.Length != 0 && (bool)RecursiveBreathFirstSearch(array[0], "VFXLayer"))
		{
			Dictionary<string, GameObject> vfxLayerMap = VfxLayerMap;
			throw new NullReferenceException();
		}
		UpdateParticles(force: false);
		UpdateShadow(force: false);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0xCE66A0", Offset = "0xCE50A0", VA = "0x180CE66A0")]
	private void OnSceneUnloaded(Scene scene)
	{
		//Discarded unreachable code: IL_000c, IL_0010, IL_001d, IL_001e
		Dictionary<string, GameObject> vfxLayerMap = VfxLayerMap;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0xCE5EF0", Offset = "0xCE48F0", VA = "0x180CE5EF0")]
	private static string MapProfile(ProfileEnum profile)
	{
		//Discarded unreachable code: IL_000e, IL_0014, IL_001a, IL_0020, IL_0026, IL_002c, IL_0032, IL_0038, IL_003e, IL_0044, IL_004a, IL_0050, IL_0056, IL_005c, IL_0062, IL_0068, IL_006e, IL_0074, IL_007a, IL_0080, IL_0086, IL_008c, IL_0092, IL_0098, IL_009e
		if (profile <= ProfileEnum.Unknown)
		{
			return "Default";
		}
		Exception ex = new Exception("missing mapping");
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0xCE5B40", Offset = "0xCE4540", VA = "0x180CE5B40")]
	public static void InitializeGraphicQuality(string qualityNameToApply = "Default")
	{
		//Discarded unreachable code: IL_00a0
		int num = 0;
		DeviceManager.CreateSingleton();
		DeviceManager singleton = DeviceManager._singleton;
		singleton.Execute();
		if (string.IsNullOrEmpty(qualityNameToApply) || string.Equals(qualityNameToApply, "Default"))
		{
			int profileEnum = (int)((DeviceManager.ProfileGroup)singleton.GraphicsQuality).profileEnum;
			string a = default(string);
			bool flag = string.Equals(a, "Unknown");
		}
		UpdateQuality("PC Ultra Low");
		int num2 = 0;
		int qualityLevel = QualitySettings.GetQualityLevel();
		string text = default(string);
		string text2 = "Assigned Quality Level: " + text;
		int num3 = 0;
		if (DebugSettings.Settings.screenMode_ <= ScreenModeEnum.ScreenModeWindowed960X540)
		{
			Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
			int num4 = 0;
			int systemWidth = Display.main.systemWidth;
			int num5 = 0;
			int systemHeight = Display.main.systemHeight;
			Screen.fullScreenMode = FullScreenMode.Windowed;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0xCE6B30", Offset = "0xCE5530", VA = "0x180CE6B30")]
	public static void SetAdditionalLights(bool EnteringVillage)
	{
		//Discarded unreachable code: IL_0059
		//IL_000f: Expected O, but got I4
		//IL_0058: Expected O, but got I4
		GraphicSettingsData graphicSettingsData = CurrentGraphicSettingsData;
		int num = 0;
		if (graphicSettingsData != (UnityEngine.Object)num && CurrentGraphicSettingsData.AdditionalLightsDisabledInVillage)
		{
			int num2 = 0;
			RenderPipelineAsset renderPipelineAsset = GraphicsSettings.renderPipelineAsset;
			if ((object)renderPipelineAsset == null)
			{
			}
			int num3 = 0;
			int num4 = 0;
			FieldInfo field = typeof(UniversalRenderPipelineAsset).GetField("m_AdditionalLightsRenderingMode", BindingFlags.Instance | BindingFlags.NonPublic);
			if (!EnteringVillage)
			{
			}
			LightRenderingMode lightRenderingMode = default(LightRenderingMode);
			field.SetValue(renderPipelineAsset, lightRenderingMode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0xCE4860", Offset = "0xCE3260", VA = "0x180CE4860")]
	public static void ApplySettingsOverride([Optional] string levelName)
	{
		//Discarded unreachable code: IL_0029
		//IL_0014: Expected O, but got I4
		GraphicSettingsDataOverride settingsOverrides = Instance._settingsOverrides;
		int num = 0;
		if (settingsOverrides != (UnityEngine.Object)num)
		{
			Instance._settingsOverrides.ApplySettingsOverride(levelName);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0xCE6EC0", Offset = "0xCE58C0", VA = "0x180CE6EC0")]
	public static void SetRenderFrameInterval(int _interval = 1)
	{
		OnDemandRendering.renderFrameInterval = _interval;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0xCE8660", Offset = "0xCE7060", VA = "0x180CE8660")]
	public static void UpdateQuality(string name)
	{
		//Discarded unreachable code: IL_0032
		int num = 0;
		string[] names = QualitySettings.names;
		int num2 = 0;
		string[] names2 = QualitySettings.names;
		int num3 = default(int);
		if (num3 < names2.Length)
		{
			QualitySettings.SetQualityLevel(num3);
			int num4 = 0;
			ApplyGraphicQualitySettings();
			int num5 = 0;
			ApplyStreamingMipmapsSettings();
			return;
		}
		int num6 = 0;
		string[] names3 = QualitySettings.names;
		string text = string.Join(", ", names3);
		string message = default(string);
		Exception ex = new Exception(message);
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0xCE8870", Offset = "0xCE7270", VA = "0x180CE8870")]
	public static void UpdateQuality(int index)
	{
		int num = 0;
		string[] names = QualitySettings.names;
		if (index < names.Length)
		{
			QualitySettings.SetQualityLevel(index);
			int num2 = 0;
			ApplyGraphicQualitySettings();
			int num3 = 0;
			ApplyStreamingMipmapsSettings();
			return;
		}
		int num4 = 0;
		string[] names2 = QualitySettings.names;
		string text = string.Join(", ", names2);
		string message = default(string);
		Exception ex = new Exception(message);
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xCE4A00", Offset = "0xCE3400", VA = "0x180CE4A00")]
	public static void ApplyStreamingMipmapsSettings()
	{
		//Discarded unreachable code: IL_0279
		//IL_00f3: Expected I4, but got I8
		//IL_0277: Expected I4, but got I8
		bool streamingMipmapsActive = default(bool);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool streamingMipmapsActive2 = default(bool);
		uint streamingMipmapsMaxLevelReduction = default(uint);
		ulong num13 = default(ulong);
		while (true)
		{
			int num = 0;
			StreamingMipmapsEnum overrideStreamingMipmaps_ = DebugSettings.Settings.overrideStreamingMipmaps_;
			if (overrideStreamingMipmaps_ != 0)
			{
				if (overrideStreamingMipmaps_ == StreamingMipmapsEnum.StreamingMipmapDefault)
				{
					goto IL_00ec;
				}
				if (overrideStreamingMipmaps_ != StreamingMipmapsEnum.StreamingMipmapOn)
				{
				}
			}
			int num2 = 0;
			string[] names = QualitySettings.names;
			int num3 = 0;
			int qualityLevel = QualitySettings.GetQualityLevel();
			string text = names[qualityLevel];
			if (text != null)
			{
				uint num4 = _003CPrivateImplementationDetails_003E.ComputeStringHash(text);
				if ((int)num4 > -1496277599)
				{
					if ((int)num4 > -638330479)
					{
						if (num4 == 3678612990u)
						{
						}
						if (num4 == 3748143762u)
						{
						}
						if (num4 != 3793595974u)
						{
							goto IL_00f3;
						}
						if (string.Equals(text, "Android Low"))
						{
							goto IL_00ec;
						}
					}
					if (num4 == 3255084459u)
					{
					}
					if (num4 != 3656636817u)
					{
						goto IL_00f3;
					}
				}
				if ((int)num4 > 1626996419)
				{
					if (num4 == 2209998103u)
					{
					}
					if (num4 == 2291985208u)
					{
					}
					if (num4 != 2798689697u)
					{
						goto IL_00f3;
					}
				}
				if (num4 == 210666120)
				{
				}
				if (num4 == 1626996419 && string.Equals(text, "PC Medium"))
				{
					goto IL_00ec;
				}
			}
			goto IL_00f3;
			IL_00f3:
			int num5 = 0;
			if (DebugSettings.Settings.overrideStreamingMipmaps_ == StreamingMipmapsEnum.StreamingMipmapDefault)
			{
				break;
			}
			int num6 = 0;
			string[] names2 = QualitySettings.names;
			int num7 = 0;
			int qualityLevel2 = QualitySettings.GetQualityLevel();
			string text2 = names2[qualityLevel2];
			if (text2 == null)
			{
				break;
			}
			uint num8 = _003CPrivateImplementationDetails_003E.ComputeStringHash(text2);
			if ((int)num8 > -2084969193)
			{
				if ((int)num8 > -1369203552)
				{
					if (num8 == 3656636817u)
					{
					}
					if (num8 == 3678612990u)
					{
						if (!string.Equals(text2, "PC Low"))
						{
							break;
						}
						int num9 = 0;
						streamingMipmapsActive = QualitySettings.streamingMipmapsActive;
						if (!streamingMipmapsActive)
						{
							break;
						}
						QualitySettings.streamingMipmapsMemoryBudget = 48f;
					}
					if (!streamingMipmapsActive)
					{
						break;
					}
					flag = string.Equals(text2, "PC Very Low");
					if (flag)
					{
						goto IL_0202;
					}
				}
				if (flag)
				{
				}
				if (!flag)
				{
					break;
				}
				flag2 = string.Equals(text2, "PC High");
			}
			if ((flag2 ? 1 : 0) > (true ? 1 : 0))
			{
				if (!flag2 || !string.Equals(text2, "PC Ultra High"))
				{
					continue;
				}
				if (!string.Equals(text2, "PC Very High") || !string.Equals(text2, "SwitchDocked"))
				{
					break;
				}
				goto IL_0202;
			}
			goto IL_021b;
			IL_021b:
			if (!streamingMipmapsActive2)
			{
				continue;
			}
			if (string.Equals(text2, "PC Ultra") && string.Equals(text2, "PC Medium"))
			{
				int num10 = 0;
				if (QualitySettings.streamingMipmapsActive)
				{
					int num11 = 0;
					QualitySettings.streamingMipmapsMemoryBudget = 64f;
					QualitySettings.streamingMipmapsMaxLevelReduction = (int)streamingMipmapsMaxLevelReduction;
				}
			}
			break;
			IL_0202:
			int num12 = 0;
			streamingMipmapsActive2 = QualitySettings.streamingMipmapsActive;
			if (!streamingMipmapsActive2)
			{
				break;
			}
			QualitySettings.streamingMipmapsMemoryBudget = 32f;
			goto IL_021b;
			IL_00ec:
			QualitySettings.streamingMipmapsActive = (byte)num13 != 0;
			goto IL_00f3;
		}
		int num14 = 0;
		if (DebugSettings.Settings.streamingTextureFreeUnused_)
		{
			ulong num15 = default(ulong);
			Texture.streamingTextureDiscardUnusedMips = (byte)num15 != 0;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	private static void ApplyTextureQualitySettings()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0xCE3C90", Offset = "0xCE2690", VA = "0x180CE3C90")]
	private static void ApplyGraphicQualitySettings()
	{
		//Discarded unreachable code: IL_0235
		//IL_001b: Expected O, but got I4
		//IL_00e3: Expected O, but got I4
		LODGroup.crossFadeAnimationDuration = 0.3f;
		int num = 0;
		RenderPipelineAsset renderPipeline = QualitySettings.renderPipeline;
		int num2 = 0;
		if (renderPipeline != (UnityEngine.Object)num2)
		{
			int num3 = 0;
			GraphicsSettings.renderPipelineAsset = QualitySettings.renderPipeline;
		}
		int num4 = 0;
		RenderPipelineAsset renderPipelineAsset = GraphicsSettings.renderPipelineAsset;
		if ((object)renderPipelineAsset == null)
		{
		}
		int num5 = 0;
		UniversalAdditionalCameraData playerCameraUniversalAdditionalData = SystemRoot.Instance._playerCameraUniversalAdditionalData;
		Type typeFromHandle = typeof(UniversalRenderPipelineAsset);
		Type typeFromHandle2 = typeof(UniversalRenderPipelineAsset);
		Type typeFromHandle3 = typeof(UniversalRenderPipelineAsset);
		Type typeFromHandle4 = typeof(UniversalRenderPipelineAsset);
		Type typeFromHandle5 = typeof(UniversalRenderPipelineAsset);
		Type typeFromHandle6 = typeof(UniversalRenderPipelineAsset);
		List<GraphicSettingsData> settings = Instance._settings;
		Func<GraphicSettingsData, bool> func = default(Func<GraphicSettingsData, bool>);
		if (_003C_003Ec._003C_003E9__143_0 == null)
		{
			func = (Func<GraphicSettingsData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GraphicSettingsData x)
			{
				//Discarded unreachable code: IL_000f
				//IL_000f: Expected I4, but got O
				string text3 = x.Name;
				int num18 = 0;
				return (byte)(int)typeof(GraphicSettings).TypeHandle != 0;
			});
		}
		Instance = (GraphicSettings)(object)Enumerable.FirstOrDefault<GraphicSettingsData>(Enumerable.Where<GraphicSettingsData>((IEnumerable<>)settings, (Func<, >)(object)func));
		GraphicSettingsData graphicSettingsData = CurrentGraphicSettingsData;
		int num6 = 0;
		if (graphicSettingsData != (UnityEngine.Object)num6)
		{
			CurrentGraphicSettingsData.ApplySettings();
		}
		int num7 = 0;
		string[] names = QualitySettings.names;
		int num8 = 0;
		int qualityLevel = QualitySettings.GetQualityLevel();
		if (names[qualityLevel] != null)
		{
			if (qualityLevel > -2002982088)
			{
				if (qualityLevel > -616354306)
				{
					if (qualityLevel == -546823534)
					{
					}
					if (qualityLevel != -501371322)
					{
						goto IL_0161;
					}
				}
				if (qualityLevel == -638330479)
				{
				}
				if (qualityLevel != -616354306)
				{
					goto IL_0161;
				}
			}
			if (qualityLevel == 210666120)
			{
			}
			if (qualityLevel == -2084969193)
			{
			}
			if (qualityLevel != -2002982088)
			{
			}
		}
		goto IL_0161;
		IL_0161:
		int num9 = 0;
		string[] names2 = QualitySettings.names;
		int num10 = 0;
		int qualityLevel2 = QualitySettings.GetQualityLevel();
		string text = names2[qualityLevel2];
		if (qualityLevel2 == 0)
		{
			int num11 = 0;
			string[] names3 = QualitySettings.names;
			int num12 = 0;
			int qualityLevel3 = QualitySettings.GetQualityLevel();
			string text2 = names3[qualityLevel3];
			if (qualityLevel3 == 0)
			{
				goto IL_01bb;
			}
		}
		uint num13 = default(uint);
		playerCameraUniversalAdditionalData.requiresDepthTexture = (byte)num13 != 0;
		playerCameraUniversalAdditionalData.m_RequiresDepthTextureOption = (CameraOverrideOption)num13;
		goto IL_01bb;
		IL_01bb:
		int num14 = 0;
		SetShadowsCurrentSettings();
		int num15 = 0;
		int maximumLODLevel = QualitySettings.maximumLODLevel;
		int num16 = 0;
		LodSkipEnum overrideLodSkip_ = DebugSettings.Settings.overrideLodSkip_;
		if (overrideLodSkip_ != 0)
		{
			overrideLodSkip_ = (LodSkipEnum)((int)overrideLodSkip_ - (int)num13);
			if (overrideLodSkip_ != 0 && overrideLodSkip_ == (LodSkipEnum)num13)
			{
			}
		}
		int num17 = 0;
		if (QualitySettings.maximumLODLevel != maximumLODLevel)
		{
			QualitySettings.maximumLODLevel = maximumLODLevel;
		}
		Type typeFromHandle7 = typeof(UniversalRenderPipelineAsset);
		FieldInfo fieldInfo = default(FieldInfo);
		fieldInfo.SetValue(renderPipelineAsset, fieldInfo);
		Type typeFromHandle8 = typeof(UniversalRenderPipelineAsset);
		FieldInfo fieldInfo2 = default(FieldInfo);
		fieldInfo2.SetValue(renderPipelineAsset, fieldInfo2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0xCE89A0", Offset = "0xCE73A0", VA = "0x180CE89A0")]
	private static void UpdateShadow(bool force)
	{
		//Discarded unreachable code: IL_0090
		if (1 == 0)
		{
			return;
		}
		Light[] array = UnityEngine.Object.FindObjectsOfType<Light>();
		int num = 0;
		int length = array.Length;
		if (num >= length)
		{
			return;
		}
		Light light = array[num];
		int num2 = 0;
		if (light.shadows != 0)
		{
			ShadowModeRestore shadowModeRestore = light.gameObject.AddComponent<ShadowModeRestore>();
			LightShadows lightShadows = (shadowModeRestore.shadows = light.shadows);
			int num3 = (int)(light.shadows = LightShadows.None);
			num++;
			ShadowModeRestore component = light.gameObject.GetComponent<ShadowModeRestore>();
			if ((bool)component)
			{
				LightShadows lightShadows3 = (light.shadows = component.shadows);
				UnityEngine.Object.Destroy(component);
			}
		}
		num++;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0xCE8320", Offset = "0xCE6D20", VA = "0x180CE8320")]
	private static void UpdateParticles(bool force)
	{
		//Discarded unreachable code: IL_001e
		int num = 0;
		if (1u != 0)
		{
			Dictionary<string, GameObject>.ValueCollection values = (Dictionary<string, GameObject>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)VfxLayerMap).get_Values();
			bool flag = default(bool);
			if (flag)
			{
				bool enableParticles = _enableParticles;
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0xCE7DF0", Offset = "0xCE67F0", VA = "0x180CE7DF0")]
	public static void ToggleGroundCullingDistance(bool turnOff)
	{
		//Discarded unreachable code: IL_00a4
		//IL_0070: Expected F4, but got I4
		//IL_0082: Expected F4, but got I4
		if (!turnOff)
		{
			float[] layerCullDistances = CurrentGraphicSettingsData.LayerCullDistances;
			float num = (layerCullDistances[0] = OldDefaultCullingDistance);
			float num2 = layerCullDistances[14];
			float oldGroundCullingDistance = OldGroundCullingDistance;
			return;
		}
		OldDefaultCullingDistance = CurrentGraphicSettingsData.LayerCullDistances[0];
		OldGroundCullingDistance = CurrentGraphicSettingsData.LayerCullDistances[8];
		float[] layerCullDistances2 = CurrentGraphicSettingsData.LayerCullDistances;
		int num3 = 0;
		layerCullDistances2[0] = num3;
		CurrentGraphicSettingsData.LayerCullDistances[8] = num3;
		Camera playerCamera = SystemRoot.Instance._playerCamera;
		float[] array = (playerCamera.layerCullDistances = CurrentGraphicSettingsData.LayerCullDistances);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0xCE84F0", Offset = "0xCE6EF0", VA = "0x180CE84F0")]
	private static void UpdatePostProcess(bool force)
	{
		//Discarded unreachable code: IL_001b
		if (1u != 0)
		{
			Camera playerCamera = SystemRoot.Instance._playerCamera;
			bool flag = default(bool);
			if (flag)
			{
				bool enablePostProcess = _enablePostProcess;
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0xCE5370", Offset = "0xCE3D70", VA = "0x180CE5370")]
	public static bool HasPostProcess(PostProcess postProcess)
	{
		PostProcess postProcess2 = PostProcess;
		bool result = default(bool);
		return result;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0xCE6E10", Offset = "0xCE5810", VA = "0x180CE6E10")]
	public static void SetPostProcess(PostProcess postProcess, bool value)
	{
		if (value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0xCE53E0", Offset = "0xCE3DE0", VA = "0x180CE53E0")]
	public static void IncreaseShadowQuality()
	{
		string text;
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		bool flag5 = default(bool);
		do
		{
			int num = 0;
			if ((object)GraphicsSettings.renderPipelineAsset == null)
			{
			}
			int num2 = 0;
			FieldInfo field = typeof(UniversalRenderPipelineAsset).GetField("m_MainLightShadowsSupported", BindingFlags.Instance | BindingFlags.NonPublic);
			FieldInfo field2 = typeof(UniversalRenderPipelineAsset).GetField("m_MainLightShadowmapResolution", BindingFlags.Instance | BindingFlags.NonPublic);
			FieldInfo field3 = typeof(UniversalRenderPipelineAsset).GetField("m_AdditionalLightShadowsSupported", BindingFlags.Instance | BindingFlags.NonPublic);
			FieldInfo field4 = typeof(UniversalRenderPipelineAsset).GetField("m_AdditionalLightsShadowmapResolution", BindingFlags.Instance | BindingFlags.NonPublic);
			int num3 = 0;
			string[] names = QualitySettings.names;
			int num4 = 0;
			int qualityLevel = QualitySettings.GetQualityLevel();
			text = names[qualityLevel];
			if (text == null)
			{
				return;
			}
			if (qualityLevel > 2003991532)
			{
				if (qualityLevel > -833334004)
				{
					if (qualityLevel > -616354306)
					{
						if (qualityLevel == -546823534)
						{
							flag = string.Equals(text, "PC Very Low");
							if (!flag)
							{
								return;
							}
							goto IL_0137;
						}
						while (!flag)
						{
						}
						flag2 = string.Equals(text, "PS4");
						if (flag2)
						{
							break;
						}
					}
					if (flag2)
					{
						flag3 = string.Equals(text, "Switch");
						if (flag3)
						{
							goto IL_0177;
						}
					}
					while (!flag3)
					{
					}
				}
				if ((flag3 ? 1 : 0) > (true ? 1 : 0))
				{
					if (flag3)
					{
					}
					while (!flag3)
					{
					}
				}
				if (flag3)
				{
				}
				while (!flag3)
				{
				}
				flag4 = string.Equals(text, "PC Ultra Low");
				while (!flag4)
				{
				}
			}
			goto IL_0137;
			IL_0137:
			if ((flag4 ? 1 : 0) > (true ? 1 : 0))
			{
				if ((flag4 ? 1 : 0) > (true ? 1 : 0))
				{
					if (flag4)
					{
					}
					while (!flag4)
					{
					}
				}
				if (flag4)
				{
				}
				while (!flag4)
				{
				}
			}
			if ((flag4 ? 1 : 0) > (true ? 1 : 0))
			{
				if (flag4)
				{
				}
				while (!flag4)
				{
				}
				flag5 = string.Equals(text, "PC Medium");
				while (!flag5)
				{
				}
			}
			goto IL_0177;
			IL_0177:
			if (flag5)
			{
			}
			while (!flag5)
			{
			}
		}
		while (!string.Equals(text, "XboxOneS"));
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0xCE6F10", Offset = "0xCE5910", VA = "0x180CE6F10")]
	public static void SetShadowsCurrentSettings()
	{
		string text;
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		bool flag5 = default(bool);
		bool flag6 = default(bool);
		bool flag7 = default(bool);
		bool flag8 = default(bool);
		bool flag9 = default(bool);
		bool flag10 = default(bool);
		bool flag11 = default(bool);
		bool flag12 = default(bool);
		bool flag13 = default(bool);
		do
		{
			int num = 0;
			if ((object)GraphicsSettings.renderPipelineAsset == null)
			{
			}
			int num2 = 0;
			FieldInfo field = typeof(UniversalRenderPipelineAsset).GetField("m_MainLightShadowsSupported", BindingFlags.Instance | BindingFlags.NonPublic);
			FieldInfo field2 = typeof(UniversalRenderPipelineAsset).GetField("m_MainLightShadowmapResolution", BindingFlags.Instance | BindingFlags.NonPublic);
			FieldInfo field3 = typeof(UniversalRenderPipelineAsset).GetField("m_AdditionalLightShadowsSupported", BindingFlags.Instance | BindingFlags.NonPublic);
			FieldInfo field4 = typeof(UniversalRenderPipelineAsset).GetField("m_AdditionalLightsShadowmapResolution", BindingFlags.Instance | BindingFlags.NonPublic);
			int num3 = 0;
			string[] names = QualitySettings.names;
			int num4 = 0;
			int qualityLevel = QualitySettings.GetQualityLevel();
			text = names[qualityLevel];
			if (text == null)
			{
				return;
			}
			if (qualityLevel > -2084969193)
			{
				if (qualityLevel > -1039882837)
				{
					if (qualityLevel > -616354306)
					{
						if (qualityLevel == -546823534)
						{
							flag = string.Equals(text, "PC Very Low");
							if (!flag)
							{
								return;
							}
							goto IL_013e;
						}
						if (flag)
						{
							flag2 = string.Equals(text, "Android Low");
							if (flag2)
							{
								goto IL_023b;
							}
						}
						while (!flag2)
						{
						}
						flag3 = string.Equals(text, "PS4");
						if (flag3)
						{
							goto IL_01f3;
						}
					}
					if (flag3)
					{
					}
					if (flag3)
					{
						flag4 = string.Equals(text, "Switch");
						while (!flag4)
						{
						}
					}
					while (!flag4)
					{
					}
					flag5 = string.Equals(text, "PC Low");
					while (!flag5)
					{
					}
				}
				goto IL_013e;
			}
			goto IL_0172;
			IL_023b:
			while (!flag6)
			{
			}
			continue;
			IL_0223:
			if (flag7)
			{
				flag6 = string.Equals(text, "iOS Low");
				while (!flag6)
				{
				}
			}
			goto IL_023b;
			IL_0172:
			if ((flag8 ? 1 : 0) > (true ? 1 : 0))
			{
				if ((flag8 ? 1 : 0) > (true ? 1 : 0))
				{
					if (flag8)
					{
					}
					if (flag8)
					{
					}
					while (!flag8)
					{
					}
					flag9 = string.Equals(text, "SwitchDocked");
					while (!flag9)
					{
					}
				}
				if (flag9)
				{
					flag10 = string.Equals(text, "XboxSeriesS");
					if (flag10)
					{
						break;
					}
				}
				if (flag10)
				{
					flag11 = string.Equals(text, "XboxSeriesX");
					if (flag11)
					{
						goto IL_020b;
					}
				}
				while (!flag11)
				{
				}
			}
			if ((flag11 ? 1 : 0) > (true ? 1 : 0))
			{
				if (flag11)
				{
					flag12 = string.Equals(text, "XboxOneS");
					while (!flag12)
					{
					}
				}
				goto IL_01f3;
			}
			goto IL_0223;
			IL_01f3:
			if (flag12)
			{
				flag13 = string.Equals(text, "PC Ultra");
				while (!flag13)
				{
				}
			}
			goto IL_020b;
			IL_013e:
			if ((flag5 ? 1 : 0) > (true ? 1 : 0))
			{
				if (flag5)
				{
				}
				if (flag5)
				{
				}
				while (!flag5)
				{
				}
				flag8 = string.Equals(text, "Android Medium");
				if (flag8)
				{
					goto IL_0223;
				}
			}
			if (flag8)
			{
			}
			while (!flag8)
			{
			}
			goto IL_0172;
			IL_020b:
			while (!flag13)
			{
			}
			flag7 = string.Equals(text, "PC Medium");
			while (!flag7)
			{
			}
			goto IL_0223;
		}
		while (!string.Equals(text, "XboxOneX"));
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0xCE3C20", Offset = "0xCE2620", VA = "0x180CE3C20")]
	public static void ActivateRenderPass(string label, bool active)
	{
		ScriptableRendererFeature renderFeature = GetRenderFeature(label);
		if ((object)renderFeature != null)
		{
			renderFeature.m_Active = active;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x1BB80C0", Offset = "0x1BB6AC0", VA = "0x181BB80C0")]
	public static T GetRenderFeature<T>() where T : ScriptableRendererFeature
	{
		RenderPipelineAsset renderPipelineAsset;
		do
		{
			int num = 0;
			renderPipelineAsset = GraphicsSettings.renderPipelineAsset;
		}
		while ((object)renderPipelineAsset == null);
		string text;
		if ((object)renderPipelineAsset != null)
		{
			int num2 = 0;
			FieldInfo[] fields = typeof(ScriptableRenderer).GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			int num3 = 0;
			int num4 = 0;
			int length = fields.Length;
			if (num3 < length)
			{
				text = fields[num4].Name;
				if (text != null)
				{
					ScriptableRenderer obj = default(ScriptableRenderer);
					object value = fields[num4].GetValue(obj);
					int num5 = 0;
					if (value != null)
					{
						goto IL_0075;
					}
					num5++;
				}
				num4++;
				goto IL_0075;
			}
			goto IL_007a;
		}
		goto IL_0083;
		IL_007a:
		int num6 = 0;
		throw new NullReferenceException();
		IL_0083:
		throw new InvalidCastException();
		IL_0075:
		if (text != null)
		{
			goto IL_007a;
		}
		goto IL_0083;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0xCE5060", Offset = "0xCE3A60", VA = "0x180CE5060")]
	public static ScriptableRendererFeature GetRenderFeature(string label)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		if ("m_RendererFeatures" != null)
		{
			int num4 = 0;
			if ("m_RendererFeatures" != null)
			{
				int num5 = 0;
				Type typeFromHandle = typeof(ScriptableRenderer);
				FieldInfo[] array = default(FieldInfo[]);
				int length = array.Length;
				if (num3 < length)
				{
					if (array[num3].Name == null)
					{
						num3++;
					}
					ScriptableRenderer obj = default(ScriptableRenderer);
					object value = array[num3].GetValue(obj);
					int num6 = 0;
					if ((long)num3 < (long)(IntPtr)value)
					{
						int num7 = 0;
						System.ThrowHelper.ThrowArgumentOutOfRangeException();
						string text = default(string);
						if (text == null)
						{
							num3++;
							uint num8 = num8 + 8;
						}
						int num9 = 0;
						System.ThrowHelper.ThrowArgumentOutOfRangeException();
					}
				}
				throw new NullReferenceException();
			}
		}
		throw new InvalidCastException();
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0xCE8F30", Offset = "0xCE7930", VA = "0x180CE8F30")]
	public GraphicSettings()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0xCE8C70", Offset = "0xCE7670", VA = "0x180CE8C70")]
	static GraphicSettings()
	{
		//IL_0008: Expected F4, but got I4
		//IL_000e: Expected F4, but got I4
		//IL_001a: Expected F8, but got I4
		//IL_0020: Expected F8, but got I4
		//IL_0026: Expected F4, but got I4
		//IL_0038: Expected O, but got I4
		int num = 0;
		OldDefaultCullingDistance = num;
		OldGroundCullingDistance = num;
		IsGroundCullingDistanceDisabled = (byte)num != 0;
		gpuFrameTime = num;
		cpuFrameTime = num;
		FogCullingOffsetOverride = num;
		DynamicResolution = (byte)num != 0;
		OptimizedDepthPriming = (byte)num != 0;
		Instance = (GraphicSettings)num;
		Instance = (GraphicSettings)(object)new Dictionary<TKey, TValue>();
	}
}
