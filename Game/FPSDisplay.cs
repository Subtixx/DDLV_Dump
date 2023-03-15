using System.Text;
using Cpp2IlInjected;
using Mdl.Platform;
using Meta.Util;
using UnityEngine;
using UnityEngine.Profiling;

[Cpp2IlInjected.Token(Token = "0x20000C2")]
public class FPSDisplay : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	private float deltaTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	private Rect fpsRect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	private Rect fpsRectTL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	private Rect fpsRectBR;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	private GUIStyle fpsStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	private GUIStyle fpsStyleContour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	private Rect infoRect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	private Rect infoRectTL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	private Rect infoRectBR;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	private GUIStyle infoStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	private GUIStyle infoStyleContour;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	private FrameTiming[] frameTimings;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	private double gpuFrameTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	private double cpuFrameTime;

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x136AE00", Offset = "0x1369800", VA = "0x18136AE00")]
	private void Awake()
	{
		//Discarded unreachable code: IL_0178
		//IL_0028: Expected O, but got I4
		//IL_0030: Expected O, but got I4
		//IL_0038: Expected O, but got I4
		//IL_006b: Expected I4, but got I8
		//IL_0084: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_00d5: Expected O, but got I4
		//IL_00dd: Expected O, but got I4
		//IL_00e5: Expected O, but got I4
		//IL_0100: Expected O, but got I4
		//IL_0121: Expected O, but got I4
		//IL_014b: Expected O, but got I4
		//IL_0157: Expected O, but got I4
		//IL_016f: Expected F8, but got I4
		//IL_0177: Expected F8, but got I4
		int num = 0;
		int width = Screen.width;
		int num2 = 0;
		int height = Screen.height;
		int num3 = 0;
		int num4 = 0;
		ulong num5 = num5 + num5;
		int num6 = 0;
		fpsRect = (Rect)num3;
		fpsRectTL = (Rect)num6;
		fpsRectBR = (Rect)num6;
		GUIStyle gUIStyle = (fpsStyle = new GUIStyle());
		fpsStyle.alignment = TextAnchor.UpperRight;
		GUIStyle gUIStyle2 = fpsStyle;
		ulong num7 = num7 + num7;
		gUIStyle2.fontSize = (int)num7;
		GUIStyleState normal = fpsStyle.normal;
		int num8 = 0;
		normal.textColor = (Color)num8;
		GUIStyle gUIStyle3 = (fpsStyleContour = new GUIStyle(fpsStyle));
		GUIStyleState normal2 = fpsStyleContour.normal;
		int num9 = 0;
		normal2.textColor = (Color)num9;
		int num10 = 0;
		ulong num11 = num11 + num11;
		int num12 = 0;
		num11 += num11;
		ulong num13 = num13 + num13;
		infoRect = (Rect)num10;
		infoRectTL = (Rect)num10;
		infoRectBR = (Rect)num10;
		GUIStyle gUIStyle4 = (infoStyle = new GUIStyle());
		int num14 = 0;
		GUIStyleState gUIStyleState = default(GUIStyleState);
		gUIStyleState.textColor = (Color)num14;
		GUIStyle gUIStyle5 = default(GUIStyle);
		infoStyleContour = gUIStyle5;
		GUIStyleState normal3 = infoStyleContour.normal;
		int num15 = 0;
		normal3.textColor = (Color)num15;
		int num16 = 0;
		if ((DebugSettings.Settings.easyRead_ ? 1 : 0) != num12)
		{
			GUIStyleState normal4 = fpsStyle.normal;
			int num17 = 0;
			normal4.textColor = (Color)num17;
			int num18 = 0;
			GUIStyleState gUIStyleState2 = default(GUIStyleState);
			gUIStyleState2.textColor = (Color)num18;
		}
		FrameTiming[] array = (frameTimings = new FrameTiming[1]);
		gpuFrameTime = num12;
		cpuFrameTime = num12;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x136CB30", Offset = "0x136B530", VA = "0x18136CB30")]
	private void Update()
	{
		//Discarded unreachable code: IL_0067, IL_0074, IL_0079, IL_0090
		//IL_0054: Expected F8, but got O
		//IL_0066: Expected F8, but got O
		//IL_0083: Expected O, but got I4
		int num = 0;
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		int num2 = 0;
		float num3 = (deltaTime = unscaledDeltaTime * 0.1f);
		FrameTimingManager.CaptureFrameTimings();
		FrameTiming[] timings = frameTimings;
		uint latestTimings = FrameTimingManager.GetLatestTimings(1u, timings);
		FrameTiming[] array = frameTimings;
		int length = array.Length;
		FrameTiming frameTiming = array[3];
		gpuFrameTime = (double)frameTiming;
		FrameTiming frameTiming2 = array[1];
		cpuFrameTime = (double)frameTiming2;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x136B460", Offset = "0x1369E60", VA = "0x18136B460")]
	private void OnGUI()
	{
		//IL_00f0: Expected I4, but got I8
		//IL_010e: Expected I4, but got I8
		//IL_016e: Expected I4, but got I8
		//IL_017b: Expected I4, but got I8
		//IL_01b7: Expected O, but got I4
		//IL_02df: Expected O, but got I4
		//IL_0305: Expected O, but got I4
		//IL_0366: Expected O, but got I4
		//IL_038c: Expected O, but got I4
		//IL_049b: Expected O, but got I8
		//IL_04b5: Expected O, but got I8
		//IL_04d1: Expected O, but got I4
		//IL_0515: Expected O, but got I4
		//IL_052f: Expected O, but got I8
		//IL_0549: Expected O, but got I8
		//IL_0563: Expected O, but got I8
		ulong num7 = default(ulong);
		ulong num8 = default(ulong);
		int num12 = default(int);
		ulong num13 = default(ulong);
		ulong num14 = default(ulong);
		ulong num15 = default(ulong);
		StringBuilder stringBuilder;
		uint capacity = default(uint);
		uint maxCapacity = default(uint);
		int num19 = default(int);
		StringBuilder arg2 = default(StringBuilder);
		StringBuilder arg8 = default(StringBuilder);
		DebugSettings settings2;
		do
		{
			IL_0000:
			int num = 0;
			int width = Screen.width;
			int num2 = 0;
			int height = Screen.height;
			int num3 = 0;
			DebugSettings settings = DebugSettings.Settings;
			int num4 = 0;
			if ((settings.showFPS_ ? 1 : 0) != num4)
			{
				float num5 = deltaTime * 1000f;
				if ((settings.showFPS_ ? 1 : 0) == num4 || (settings.showFPS_ ? 1 : 0) == num4)
				{
					string text = $"{settings:0.00} ms ({settings:0.} fps)";
				}
				object[] array = new object[4];
				if (array != null && array == null)
				{
					goto IL_0000;
				}
				array[0] = array;
				if (array != null && array == null)
				{
					goto IL_0000;
				}
				array[1] = array;
				if (array != null && array == null)
				{
					goto IL_0000;
				}
				array[2] = array;
				if (array != null && array == null)
				{
					goto IL_0000;
				}
				array[3] = array;
				string text2 = string.Format("CPU: {0:0.00} ms GPU: {1:0.00} ms {2:0.00} ms ({3:0.} fps)", array);
				int num6 = 0;
				num7 += num7;
				GUIStyle gUIStyle = fpsStyle;
				num8 += num8;
				gUIStyle.fontSize = (int)num8;
				int num9 = 0;
				if ((DebugSettings.Settings.easyRead_ ? 1 : 0) != num6)
				{
					fpsStyleContour.fontSize = (int)num8;
				}
			}
			int num10 = 0;
			if (!DebugSettings.Settings.showMipmapStreamingInfo_)
			{
				int num11 = 0;
				if (!DebugSettings.Settings.showMemoryInfo_)
				{
					num12 = 0;
					if (!DebugSettings.Settings.showSystemInfo_)
					{
						goto IL_0000;
					}
				}
			}
			num12 += num12;
			num13 += num13;
			num14 += num14;
			GUIStyle gUIStyle2 = infoStyle;
			num15 += num15;
			gUIStyle2.fontSize = (int)num15;
			infoStyleContour.fontSize = (int)num15;
			stringBuilder = new StringBuilder((int)capacity, (int)maxCapacity);
			int num16 = 0;
			if (!DebugSettings.Settings.showSystemInfo_)
			{
				int num17 = 0;
				if (!DebugSettings.Settings.showMemoryInfo_)
				{
					goto IL_01cc;
				}
			}
			int num18 = 0;
			StringBuilder arg = stringBuilder.AppendFormat("SystemMemorySize: {0:#,#} MB\n", num19);
			int num20 = 0;
			StringBuilder stringBuilder2 = stringBuilder.AppendFormat("GraphicsMemorySize: {0:#,#} MB\n", arg);
			goto IL_01cc;
			IL_01cc:
			int num21 = 0;
			if (DebugSettings.Settings.showSystemInfo_)
			{
				int num22 = 0;
				DeviceManager singleton = DeviceManager._singleton;
				int num23 = 0;
				StringBuilder arg3 = stringBuilder.AppendFormat("ProcessorType: {0}\n", arg2);
				int num24 = 0;
				StringBuilder arg4 = stringBuilder.AppendFormat("ProcessorFrequency: {0}\n", arg3);
				int num25 = 0;
				StringBuilder arg5 = stringBuilder.AppendFormat("ProcessorCount: {0}\n", arg4);
				int num26 = 0;
				StringBuilder stringBuilder3 = stringBuilder.AppendFormat("GraphicsDeviceVendor: {0}\n", arg5);
				int num27 = 0;
				string graphicsDeviceName = Mdl.Platform.SystemInfo.graphicsDeviceName;
				StringBuilder arg6 = stringBuilder.AppendFormat("GraphicsDeviceName: {0}\n", graphicsDeviceName);
				int num28 = 0;
				StringBuilder arg7 = stringBuilder.AppendFormat("GraphicsDeviceVersion: {0}\n", arg6);
				int num29 = 0;
				StringBuilder stringBuilder4 = stringBuilder.AppendFormat("GraphicsShaderLevel: {0}\n", arg7);
				string _003CGpuVariantSeriesSuffix_003Ek__BackingField = singleton.GpuVariantSeriesSuffix;
				string _003CGpuVariantSeries_003Ek__BackingField = singleton.GpuVariantSeries;
				StringBuilder stringBuilder5 = stringBuilder.AppendFormat("GpuVariantSeries: {0} / {1}\n", _003CGpuVariantSeries_003Ek__BackingField, _003CGpuVariantSeriesSuffix_003Ek__BackingField);
				string _003CGpuVariantModel_003Ek__BackingField = singleton.GpuVariantModel;
				StringBuilder stringBuilder6 = stringBuilder.AppendFormat("GpuVariantModel: {0}\n", _003CGpuVariantModel_003Ek__BackingField);
				int _003CGpuVariantModelMajorNumber_003Ek__BackingField = singleton.GpuVariantModelMajorNumber;
				string _003CGpuVariantModelMajorPrefix_003Ek__BackingField = singleton.GpuVariantModelMajorPrefix;
				string _003CGpuVariantModelMajorSuffix_003Ek__BackingField = singleton.GpuVariantModelMajorSuffix;
				StringBuilder stringBuilder7 = stringBuilder.AppendFormat("GpuVariantModelMajorPrefix: {0} / {1} / {2}\n", _003CGpuVariantModelMajorPrefix_003Ek__BackingField, _003CGpuVariantModelMajorNumber_003Ek__BackingField, _003CGpuVariantModelMajorSuffix_003Ek__BackingField);
				string _003CGpuVariantModelMinorPrefix_003Ek__BackingField = singleton.GpuVariantModelMinorPrefix;
				string _003CGpuVariantModelMinorSuffix_003Ek__BackingField = singleton.GpuVariantModelMinorSuffix;
				StringBuilder stringBuilder8 = stringBuilder.AppendFormat("GpuVariantModelMinorPrefix: {0} / {1} / {2}\n", _003CGpuVariantModelMinorPrefix_003Ek__BackingField, _003CGpuVariantModelMajorNumber_003Ek__BackingField, _003CGpuVariantModelMinorSuffix_003Ek__BackingField);
				string _003CCpuVariantSeries_003Ek__BackingField = singleton.CpuVariantSeries;
				StringBuilder stringBuilder9 = stringBuilder.AppendFormat("CpuVariantSeries: {0}\n", _003CCpuVariantSeries_003Ek__BackingField);
				string _003CCpuVariantModel_003Ek__BackingField = singleton.CpuVariantModel;
				StringBuilder stringBuilder10 = stringBuilder.AppendFormat("CpuVariantModel: {0}\n", _003CCpuVariantModel_003Ek__BackingField);
				int _003CCpuVariantModelMajorNumber_003Ek__BackingField = singleton.CpuVariantModelMajorNumber;
				string _003CCpuVariantModelMajorPrefix_003Ek__BackingField = singleton.CpuVariantModelMajorPrefix;
				string _003CCpuVariantModelMajorSuffix_003Ek__BackingField = singleton.CpuVariantModelMajorSuffix;
				StringBuilder stringBuilder11 = stringBuilder.AppendFormat("CpuVariantModelMajor: {0} / {1} / {2}\n", _003CCpuVariantModelMajorPrefix_003Ek__BackingField, _003CCpuVariantModelMajorNumber_003Ek__BackingField, _003CCpuVariantModelMajorSuffix_003Ek__BackingField);
				string _003CCpuVariantModelMinorPrefix_003Ek__BackingField = singleton.CpuVariantModelMinorPrefix;
				string _003CCpuVariantModelMinorSuffix_003Ek__BackingField = singleton.CpuVariantModelMinorSuffix;
				StringBuilder stringBuilder12 = stringBuilder.AppendFormat("CpuVariantModelMinor: {0} / {1} / {2}\n", _003CCpuVariantModelMinorPrefix_003Ek__BackingField, _003CCpuVariantModelMajorNumber_003Ek__BackingField, _003CCpuVariantModelMinorSuffix_003Ek__BackingField);
				string profileStr = singleton.SystemMemory.ProfileStr;
				StringBuilder stringBuilder13 = stringBuilder.AppendFormat("SystemMemory: {0}\n", profileStr);
				string profileStr2 = singleton.GraphicsMemory.ProfileStr;
				StringBuilder stringBuilder14 = stringBuilder.AppendFormat("GraphicsMemory: {0}\n", profileStr2);
				string profileStr3 = singleton.ProcessorType.ProfileStr;
				StringBuilder stringBuilder15 = stringBuilder.AppendFormat("ProcessorTypeProfile: {0}\n", profileStr3);
				string profileStr4 = singleton.ProcessorFrequency.ProfileStr;
				StringBuilder stringBuilder16 = stringBuilder.AppendFormat("ProcessorFrequency: {0}\n", profileStr4);
				string profileStr5 = singleton.ProcessorCount.ProfileStr;
				StringBuilder stringBuilder17 = stringBuilder.AppendFormat("ProcessorCount: {0}\n", profileStr5);
				string profileStr6 = singleton.GraphicsDevice.ProfileStr;
				StringBuilder stringBuilder18 = stringBuilder.AppendFormat("GraphicsDevice: {0}\n", profileStr6);
				string profileStr7 = singleton.GraphicsQuality.ProfileStr;
				StringBuilder stringBuilder19 = stringBuilder.AppendFormat("GraphicsQuality: {0}\n", profileStr7);
				int num30 = 0;
				StringBuilder stringBuilder20 = stringBuilder.AppendFormat("using: {0}\n", arg8);
			}
			int num31 = 0;
			if (DebugSettings.Settings.showMemoryInfo_)
			{
				int num32 = 0;
				long allocatedMemoryForGraphicsDriver = Profiler.GetAllocatedMemoryForGraphicsDriver();
				StringBuilder stringBuilder21 = stringBuilder.AppendFormat("AllocatedMemoryForGraphicsDriver: {0:#,#,,.0} MB\n", allocatedMemoryForGraphicsDriver);
				int num33 = 0;
				allocatedMemoryForGraphicsDriver = Profiler.GetTotalAllocatedMemoryLong();
				StringBuilder stringBuilder22 = stringBuilder.AppendFormat("AllocatedTotalAllocatedMemory: {0:#,#,,.0} MB\n", allocatedMemoryForGraphicsDriver);
				int _003CNumLowMemoryCounter_003Ek__BackingField = DeviceManager._singleton.NumLowMemoryCounter;
				StringBuilder stringBuilder23 = stringBuilder.AppendFormat("NumLowMemoryCounter: {0}\n", _003CNumLowMemoryCounter_003Ek__BackingField);
			}
			int num34 = 0;
			settings2 = DebugSettings.Settings;
		}
		while (!settings2.showMipmapStreamingInfo_);
		int num35 = 0;
		StringBuilder stringBuilder24 = stringBuilder.AppendFormat("SystemInfo.supportsMipStreaming: {0}\n", settings2);
		int num36 = 0;
		bool streamingMipmapsActive = QualitySettings.streamingMipmapsActive;
		StringBuilder stringBuilder25 = stringBuilder.AppendFormat("QualitySettings.streamingMipmapsActive: {0}\n", streamingMipmapsActive);
		int num37 = 0;
		ulong nonStreamingTextureCount = Texture.nonStreamingTextureCount;
		StringBuilder stringBuilder26 = stringBuilder.AppendFormat("NonStreamingTextureCount: {0}\n", nonStreamingTextureCount);
		int num38 = 0;
		nonStreamingTextureCount = Texture.streamingTextureCount;
		StringBuilder stringBuilder27 = stringBuilder.AppendFormat("StreamingTextureCount: {0}\n", nonStreamingTextureCount);
		int num39 = 0;
		nonStreamingTextureCount = Texture.streamingMipmapUploadCount;
		StringBuilder stringBuilder28 = stringBuilder.AppendFormat("StreamingMipmapUploadCount: {0}\n", nonStreamingTextureCount);
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public FPSDisplay()
	{
	}
}
