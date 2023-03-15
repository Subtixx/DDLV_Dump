using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x20004E6")]
	public class FogPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001EA2")]
		private readonly int viewToWorld = Shader.PropertyToID("_ViewToWorld");

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4001EA3")]
		private readonly int depthFogOpacity = Shader.PropertyToID("_DepthFogOpacity");

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001EA4")]
		private readonly int cullEndFade = Shader.PropertyToID("_CullEndFade");

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4001EA5")]
		private readonly int cullFarOpacity = Shader.PropertyToID("_FarOpacity");

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001EA6")]
		private readonly int cullMaxHeight = Shader.PropertyToID("_CullMaxHeight");

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4001EA7")]
		private readonly int cullOpacity = Shader.PropertyToID("_CullOpacity");

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001EA8")]
		private readonly int fogCenterID = Shader.PropertyToID("_FogCenter");

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4001EA9")]
		private readonly int fogNoiseID = Shader.PropertyToID("_FogNoise");

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001EAA")]
		private readonly int fogNoiseTillingID = Shader.PropertyToID("_FogNoiseTilling");

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4001EAB")]
		private readonly int nightDomeID = Shader.PropertyToID("_NightDome");

		[Cpp2IlInjected.Token(Token = "0x4001EAC")]
		public static Material _FogMat = (Material)(object)new ProfilingSampler("Fog pass");

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001EAD")]
		private WeatherRenderFeature.Settings settings;

		[Cpp2IlInjected.Token(Token = "0x4001EAE")]
		private static readonly ProfilingSampler sampler;

		[Cpp2IlInjected.Token(Token = "0x4001EB0")]
		public static Transform fogCenter;

		[Cpp2IlInjected.Token(Token = "0x4001EB1")]
		public static bool useFog;

		[Cpp2IlInjected.Token(Token = "0x4001EB2")]
		public static int useCustomFogCenter;

		[Cpp2IlInjected.Token(Token = "0x4001EB3")]
		public static Vector3 customFogCenter;

		[Cpp2IlInjected.Token(Token = "0x170002AF")]
		private Material fogMat
		{
			[Cpp2IlInjected.Token(Token = "0x600158D")]
			[Cpp2IlInjected.Address(RVA = "0x145E720", Offset = "0x145D120", VA = "0x18145E720")]
			get
			{
				//Discarded unreachable code: IL_002d
				//IL_000f: Expected O, but got I4
				Material material = _FogMat;
				int num = 0;
				if (material == (UnityEngine.Object)num)
				{
					_FogMat = new Material(settings.fogShader);
				}
				return _FogMat;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B0")]
		private unsafe RenderTargetIdentifier source
		{
			[Cpp2IlInjected.Token(Token = "0x600158E")]
			[Cpp2IlInjected.Address(RVA = "0x145E870", Offset = "0x145D270", VA = "0x18145E870")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600158F")]
			[Cpp2IlInjected.Address(RVA = "0x145E8A0", Offset = "0x145D2A0", VA = "0x18145E8A0")]
			[CompilerGenerated]
			set
			{
				//IL_000e: Expected native int or pointer, but got O
				IntPtr bufferPointer = value.m_BufferPointer;
				((RenderTargetIdentifier*)(IntPtr)_003Csource_003Ek__BackingField)->m_BufferPointer = bufferPointer;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001590")]
		[Cpp2IlInjected.Address(RVA = "0x145E590", Offset = "0x145CF90", VA = "0x18145E590")]
		public FogPass(WeatherRenderFeature.Settings settings)
		{
			//IL_00da: Expected I4, but got I8
			this.settings = settings;
			base.renderPassEvent = RenderPassEvent.BeforeRenderingTransparents;
		}

		[Cpp2IlInjected.Token(Token = "0x6001591")]
		[Cpp2IlInjected.Address(RVA = "0x145E4B0", Offset = "0x145CEB0", VA = "0x18145E4B0")]
		public unsafe void Setup(ScriptableRenderer renderer)
		{
			//Discarded unreachable code: IL_0014
			//IL_000e: Expected native int or pointer, but got O
			RenderTargetIdentifier renderTargetIdentifier = default(RenderTargetIdentifier);
			IntPtr bufferPointer = renderTargetIdentifier.m_BufferPointer;
			((RenderTargetIdentifier*)(IntPtr)source)->m_BufferPointer = bufferPointer;
		}

		[Cpp2IlInjected.Token(Token = "0x6001592")]
		[Cpp2IlInjected.Address(RVA = "0x145DC40", Offset = "0x145C640", VA = "0x18145DC40", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			//Discarded unreachable code: IL_0273, IL_0279, IL_027f, IL_0285, IL_028b, IL_0291, IL_0297, IL_029d, IL_02a3, IL_02a9, IL_02af, IL_02b5, IL_02bb, IL_02c1, IL_02c7, IL_02cd, IL_02d3, IL_02d9, IL_02df, IL_02e5, IL_02eb, IL_02f1, IL_02f7, IL_02fd
			//IL_0077: Expected O, but got I4
			//IL_00df: Expected F4, but got I4
			//IL_01bd: Expected O, but got I4
			//IL_026c: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			CommandBuffer commandBuffer = CommandBufferPool.Get();
			RenderTargetIdentifier renderTargetIdentifier = source;
			IntPtr bufferPointer = source.m_BufferPointer;
			ConfigureTarget(renderTargetIdentifier);
			RenderTargetIdentifier renderTarget = source;
			IntPtr bufferPointer2 = source.m_BufferPointer;
			commandBuffer.SetRenderTarget(renderTarget);
			commandBuffer.Clear();
			float value = this.settings.cullFarOpacity;
			Shader.SetGlobalFloatImpl(cullFarOpacity, value);
			WeatherTimeline mainTimeline = WeatherController.mainTimeline;
			int num3 = 0;
			bool flag = mainTimeline != (UnityEngine.Object)num3;
			int name = cullMaxHeight;
			WeatherRenderFeature.Settings settings = this.settings;
			if (!flag)
			{
				float value2 = settings.cullMaxHeight;
				Shader.SetGlobalFloatImpl(name, value2);
			}
			WeatherTimeline mainTimeline2 = WeatherController.mainTimeline;
			int num4 = 0;
			int id = WeatherIDs.effects.heightFogFarHeight.id;
			float @float = mainTimeline2.GetFloat(id);
			WeatherRenderFeature.Settings settings2 = this.settings;
			int num5 = 0;
			float value3 = Mathf.Clamp(@float, num5, 500f);
			Shader.SetGlobalFloatImpl(name, value3);
			int name2 = depthFogOpacity;
			WeatherTimeline mainTimeline3 = WeatherController.mainTimeline;
			int num6 = 0;
			int id2 = WeatherIDs.effects.depthFogOpacity.id;
			value3 = mainTimeline3.GetFloat(id2);
			Shader.SetGlobalFloatImpl(name2, value3);
			if (this.settings.useCulling)
			{
			}
			Shader.SetGlobalFloatImpl(cullOpacity, 1f);
			float num7 = renderingData.cameraData.camera.GetLayerCullDistances()[0];
			num7 = renderingData.cameraData.camera.farClipPlane;
			Shader.SetGlobalFloatImpl(cullEndFade, num7);
			Texture2D noiseTex = this.settings.noiseTex;
			Shader.SetGlobalTextureImpl(fogNoiseID, (Texture)noiseTex);
			float noiseTilling = this.settings.noiseTilling;
			Shader.SetGlobalFloatImpl(fogNoiseTillingID, noiseTilling);
			Transform transform = fogCenter;
			int num8 = 0;
			bool flag2 = transform != (UnityEngine.Object)num8;
			int num9 = fogCenterID;
			if (!flag2)
			{
				Transform transform2 = renderingData.cameraData.camera.transform;
			}
			Transform transform3 = fogCenter;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			int num10 = fogCenterID;
			Cubemap nightDome = this.settings.nightDome;
			Shader.SetGlobalTextureImpl(nightDomeID, (Texture)nightDome);
			Camera camera = renderingData.cameraData.camera;
			Material material = fogMat;
			Matrix4x4 matrix4x = default(Matrix4x4);
			float m = matrix4x.m01;
			float m2 = matrix4x.m02;
			float m3 = matrix4x.m03;
			RenderTargetIdentifier dest = source;
			IntPtr bufferPointer3 = source.m_BufferPointer;
			Material mat = fogMat;
			int num11 = 0;
			commandBuffer.Blit((Texture)num11, dest, mat);
			CommandBufferPool.Release(commandBuffer);
		}
	}
}
