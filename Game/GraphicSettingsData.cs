using System;
using System.Reflection;
using Cpp2IlInjected;
using Mdl;
using Mdl.Environments;
using Mdl.Graphic;
using Mdl.Graphic.Weather;
using Mdl.Performance;
using Mdl.Platform;
using Mdl.Streaming;
using Mdl.Systems;
using Mdl.Utils;
using Meta.Util;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.Universal;

[Cpp2IlInjected.Token(Token = "0x200004D")]
[CreateAssetMenu]
public class GraphicSettingsData : ScriptableObject
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public string Name = "";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public bool RenderPostProcessing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public AntialiasingMode AntialiasingMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public AntialiasingQuality AntialiasingQuality;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public bool EnableShadow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public bool EnableParticles = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public bool EnablePostProcess;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public PostProcess PostProcess;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public float RenderScale = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public int ShadowCascadeCount = 1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public float ShadowDistance = 40f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public bool SupportsHDR;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public int MaxAdditionalLightsCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public LightRenderingMode AdditionalLightsRenderingMode = LightRenderingMode.PerPixel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public bool AdditionalLightsDisabledInVillage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4D")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public bool SoftShadowsSupported;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public int TargetFrameRate = 30;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public VSyncEnum vSync = VSyncEnum.EveryVBlank;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public LevelComplexityEnum GraphicLevelComplexity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public LevelComplexityUpdateMode LevelComplexityUpdateMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public bool UseOcclusionCulling;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public float StreamingMipmapsMemoryBudget = 512f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public int StreamingMipmapsMaxLevelReduction = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public bool StreamingTextureDiscardUnusedMips;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public float FogCullingOffsetOverride;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public bool HasDOF = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x75")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public bool HasSSAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x76")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public bool HasGrass = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public LowMemoryManager.MemoryCleanStrategy MemoryCleanStrategy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public float GrassDistanceBias = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public float GrassDensityFactor = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public int ShadowRefreshRate = 1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public bool UseDynamicResolution;

	[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public bool EnableLogInRelease;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public float[] LayerCullDistances = new float[32];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public int AkGameObjNumIdleUpdatePerFrame = 20;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public bool RewiredDisableKeyboard;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public int maxWindQuality = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public bool forceDepthPriming = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public bool OptimizedDepthPriming;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public float SortCriteriaBias = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public float SkyPrepassResFactor = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public bool SupportsReturnToMainMenu = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public bool StopNan;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB2")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public bool UseSRPBatcher = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public GraphicsJobsSyncPoint GraphicsJobsSyncPoint = GraphicsJobsSyncPoint.WaitForPresent;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public int VFXPoolGlobalDistanceMultiplier = 1;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	[NotNull]
	public StreamingManagerConfig GridObjectStreamingManagerConfig;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public PrefabSelectorConfig PrefabSelector;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public bool RebuildNavMeshAfterChanges = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public bool UnloadUnnecessaryFontsOnGameStart;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int vSyncCount
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830")]
		get
		{
			VSyncEnum vSyncEnum = vSync;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xCE2620", Offset = "0xCE1020", VA = "0x180CE2620")]
	public unsafe void ApplySettings()
	{
		//Discarded unreachable code: IL_04c8
		//IL_0150: Expected F4, but got I4
		//IL_022e: Expected O, but got I4
		//IL_0240: Expected O, but got I4
		//IL_0252: Expected O, but got I4
		//IL_02b0: Expected O, but got I4
		//IL_0310: Expected O, but got I4
		//IL_032a: Expected O, but got I4
		//IL_03dd: Expected O, but got I4
		string text = Name;
		int num = 0;
		string text2 = "GraphicSettingsData.Apply " + text;
		int num2 = 0;
		if (text2 == null)
		{
		}
		int num3 = 0;
		UniversalAdditionalCameraData playerCameraUniversalAdditionalData = SystemRoot.Instance._playerCameraUniversalAdditionalData;
		FieldInfo field = typeof(UniversalRenderPipelineAsset).GetField("m_AdditionalLightsRenderingMode", BindingFlags.Instance | BindingFlags.NonPublic);
		FieldInfo field2 = typeof(UniversalRenderPipelineAsset).GetField("m_SoftShadowsSupported", BindingFlags.Instance | BindingFlags.NonPublic);
		FieldInfo field3 = typeof(UniversalRenderPipelineAsset).GetField("m_ShadowDistance", BindingFlags.Instance | BindingFlags.NonPublic);
		GraphicSettings.EnableShadow = EnableShadow;
		bool enableParticles = EnableParticles;
		bool flag = (IntPtr)"{il2cpp field on {'constant87' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x6D}" != (IntPtr)(enableParticles ? 1 : 0);
		GraphicSettings._enableParticles = enableParticles;
		if (flag)
		{
			GraphicSettings.UpdateParticles(force: true);
		}
		GraphicSettings.EnablePostProcess = EnablePostProcess;
		GraphicSettings.PostProcess = PostProcess;
		GraphicSettings.FogCullingOffsetOverride = FogCullingOffsetOverride;
		bool hasSSAO = HasSSAO;
		int num4 = 0;
		GraphicSettings.HasSSAO = hasSSAO;
		ScriptableRendererFeature renderFeature = GraphicSettings.GetRenderFeature("SSAO");
		if ((object)renderFeature != null)
		{
			bool flag2 = (renderFeature.m_Active = GraphicSettings.HasSSAO);
		}
		GraphicSettings.HasGrass = HasGrass;
		Grass renderFeature2 = GraphicSettings.GetRenderFeature<Grass>();
		if ((object)renderFeature2 != null)
		{
			bool flag3 = (((ScriptableRendererFeature)renderFeature2).m_Active = GraphicSettings.HasGrass);
		}
		GraphicSettings.GrassDistanceBias = GrassDistanceBias;
		GraphicSettings.GrassDensityFactor = GrassDensityFactor;
		GraphicSettings.SkyPrepassResFactor = SkyPrepassResFactor;
		Shader.SetGlobalFloat("_MaxWindQuality", num4);
		QualitySettings.streamingMipmapsMemoryBudget = StreamingMipmapsMemoryBudget;
		QualitySettings.streamingMipmapsMaxLevelReduction = StreamingMipmapsMaxLevelReduction;
		Texture.streamingTextureDiscardUnusedMips = StreamingTextureDiscardUnusedMips;
		GraphicsDeviceSettings.graphicsJobsSyncPoint = GraphicsJobsSyncPoint;
		bool flag4 = (playerCameraUniversalAdditionalData.m_RenderPostProcessing = RenderPostProcessing);
		AntialiasingMode antialiasingMode = (playerCameraUniversalAdditionalData.m_Antialiasing = AntialiasingMode);
		AntialiasingQuality antialiasingQuality = (playerCameraUniversalAdditionalData.m_AntialiasingQuality = AntialiasingQuality);
		bool flag5 = (playerCameraUniversalAdditionalData.m_StopNaN = StopNan);
		float renderScale = RenderScale;
		int shadowCascadeCount = ShadowCascadeCount;
		bool supportsHDR = SupportsHDR;
		int maxAdditionalLightsCount = MaxAdditionalLightsCount;
		int shadowRefreshRate = ShadowRefreshRate;
		bool useSRPBatcher = UseSRPBatcher;
		int num5 = 0;
		ScriptableRenderer scriptableRenderer = default(ScriptableRenderer);
		if (scriptableRenderer != null)
		{
		}
		if ((forceDepthPriming ? 1 : 0) == num || scriptableRenderer != null)
		{
		}
		GraphicSettings.SortCriteriaBias = SortCriteriaBias;
		GraphicSettings.OptimizedDepthPriming = OptimizedDepthPriming;
		bool softShadowsSupported = SoftShadowsSupported;
		field2.SetValue(text2, softShadowsSupported);
		LightRenderingMode additionalLightsRenderingMode = AdditionalLightsRenderingMode;
		field.SetValue(text2, additionalLightsRenderingMode);
		float shadowDistance = ShadowDistance;
		field3.SetValue(text2, additionalLightsRenderingMode);
		GridObjectStreamingManager.Config = GridObjectStreamingManagerConfig;
		DistanceCullingManager.FirstBand = GridObjectStreamingManagerConfig.DistanceCullingFirstBand;
		DistanceCullingManager.SecondBand = GridObjectStreamingManagerConfig.DistanceCullingSecondBand;
		DistanceCullingManager.TallFirstBand = GridObjectStreamingManagerConfig.TallDistanceCullingFirstBand;
		DistanceCullingManager.TallSecondBand = GridObjectStreamingManagerConfig.TallDistanceCullingSecondBand;
		DistanceCullingManager instance = DistanceCullingManager.Instance;
		int num6 = 0;
		if (instance != (UnityEngine.Object)num6)
		{
			DistanceCullingManager.Instance.UpdateDistanceBands();
		}
		DistanceCulling.LoadsPerSecond = GridObjectStreamingManagerConfig.DistanceCullingLoadsPerSecond;
		DistanceCulling.Limiter = GridObjectStreamingManagerConfig.DistanceCullingLimitMethod;
		DistanceCulling.MaxConcurrentLoads = GridObjectStreamingManagerConfig.DistanceCullingMaxConcurrentLoads;
		DistanceCulling.BoostedMaxConcurrentLoads = GridObjectStreamingManagerConfig.DistanceCullingBoostedMaxConcurrentLoads;
		DistanceCullingManager instance2 = DistanceCullingManager.Instance;
		int num7 = 0;
		if (instance2 != (UnityEngine.Object)num7)
		{
			DistanceCullingManager.Instance.ResetLoadLimit();
		}
		SettingScope.ApplyTargetFrameRateSetting(this);
		SettingScope.ApplyVSyncSetting((GameSettings)0, this);
		LevelComplexityManager levelComplexityManager = SystemRoot.Instance._levelComplexityManager;
		LevelComplexityEnum graphicLevelComplexity = GraphicLevelComplexity;
		levelComplexityManager.SetLevelComplexity(graphicLevelComplexity);
		LevelComplexityManager levelComplexityManager2 = SystemRoot.Instance._levelComplexityManager;
		LevelComplexityUpdateMode levelComplexityUpdateMode2 = (levelComplexityManager2.CurrentUpdateMode = LevelComplexityUpdateMode);
		if (SystemRoot.Instance._levelComplexityManager._updateMode == LevelComplexityUpdateMode.AlwaysDisable)
		{
		}
		Camera playerCamera = SystemRoot.Instance._playerCamera;
		bool flag6 = (playerCamera.useOcclusionCulling = UseOcclusionCulling);
		Camera playerCamera2 = SystemRoot.Instance._playerCamera;
		float[] array = (playerCamera2.layerCullDistances = LayerCullDistances);
		SystemRoot.Instance._playerCamera.layerCullSpherical = true;
		DynamicResolution component = SystemRoot.Instance._playerCamera.GetComponent<DynamicResolution>();
		int num8 = 0;
		if (component != (UnityEngine.Object)num8)
		{
			bool flag7 = (component.enabled = UseDynamicResolution);
		}
		bool rebuildNavMeshAfterChanges = RebuildNavMeshAfterChanges;
		int num9 = 0;
		VillageEnvironment.RebuildNavMeshOnRefresh = rebuildNavMeshAfterChanges;
		DDVAkGameObjUpdateManager instance3 = DDVAkGameObjUpdateManager.Instance;
		int num10 = (instance3.NumIdleUpdatePerFrame = AkGameObjNumIdleUpdatePerFrame);
		LowMemoryManager singleton = LowMemoryManager._singleton;
		LowMemoryManager.MemoryCleanStrategy memoryCleanStrategy = (singleton.CurrentCleanStrategy = MemoryCleanStrategy);
		VFXPool.DistanceMultiplier = VFXPoolGlobalDistanceMultiplier;
		PostProcessManager componentInChildren = SystemRoot.Instance.gameObject.GetComponentInChildren<PostProcessManager>();
		if (componentInChildren.noDOF.TryGet<DepthOfField>(out *(DepthOfField*)num))
		{
			bool hasDOF = HasDOF;
		}
		if (componentInChildren.nearDOF.TryGet<DepthOfField>(out *(DepthOfField*)num))
		{
			bool hasDOF2 = HasDOF;
		}
		if (componentInChildren.midDOF.TryGet<DepthOfField>(out *(DepthOfField*)num))
		{
			bool hasDOF3 = HasDOF;
		}
		if (componentInChildren.farDOF.TryGet<DepthOfField>(out *(DepthOfField*)num))
		{
			bool hasDOF4 = HasDOF;
		}
		if (componentInChildren.baseProfile.TryGet<DepthOfField>(out *(DepthOfField*)num))
		{
			bool hasDOF5 = HasDOF;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0xCE39A0", Offset = "0xCE23A0", VA = "0x180CE39A0")]
	public static void SetUnityLogEnable(bool isEnable)
	{
		ILogger s_Logger = Debug.s_Logger;
		if (!isEnable)
		{
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0xCE3AF0", Offset = "0xCE24F0", VA = "0x180CE3AF0")]
	public GraphicSettingsData()
	{
	}//IL_0026: Expected I4, but got I8
	//IL_003a: Expected I4, but got I8
	//IL_0044: Expected I4, but got I8
	//IL_004d: Expected I4, but got I8
	//IL_0061: Expected I4, but got I8
	//IL_008e: Expected I4, but got I8
	//IL_00a7: Expected I4, but got I8
	//IL_00b0: Expected I4, but got I8
	//IL_00e4: Expected I4, but got I8
	//IL_00ed: Expected I4, but got I8

}
