using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x20004E7")]
	public class SkyPrepass : ScriptableRenderPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001EB4")]
		private readonly int viewToWorld = Shader.PropertyToID("_ViewToWorld");

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4001EB5")]
		private readonly int _SunProperties = Shader.PropertyToID("_SunProperties");

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001EB6")]
		private readonly int _MoonProperties = Shader.PropertyToID("_MoonProperties");

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4001EB7")]
		private readonly int _SunGradientIntensity = Shader.PropertyToID("_SunGradientIntensity");

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001EB8")]
		private readonly int _MoonGradientIntensity = Shader.PropertyToID("_MoonGradientIntensity");

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4001EB9")]
		private readonly int _SkyPrepass = Shader.PropertyToID("_SkyPrepass");

		[Cpp2IlInjected.Token(Token = "0x4001EBA")]
		private static readonly ProfilingSampler sampler = new ProfilingSampler("Sky Prepass");

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001EBB")]
		private WeatherRenderFeature.Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001EBC")]
		private Material material;

		[Cpp2IlInjected.Token(Token = "0x4001EBD")]
		public static float sunSize;

		[Cpp2IlInjected.Token(Token = "0x4001EBE")]
		public static float sunGradientIntensity;

		[Cpp2IlInjected.Token(Token = "0x4001EBF")]
		public static float sunCoronaRange;

		[Cpp2IlInjected.Token(Token = "0x4001EC0")]
		public static float sunHorizonBlending;

		[Cpp2IlInjected.Token(Token = "0x4001EC1")]
		public static float sunHorizonPower;

		[Cpp2IlInjected.Token(Token = "0x4001EC2")]
		public static float moonSize;

		[Cpp2IlInjected.Token(Token = "0x4001EC3")]
		public static float moonGradientIntensity;

		[Cpp2IlInjected.Token(Token = "0x4001EC4")]
		public static float moonCoronaRange;

		[Cpp2IlInjected.Token(Token = "0x4001EC5")]
		public static float moonHorizonBlending;

		[Cpp2IlInjected.Token(Token = "0x4001EC6")]
		public static float moonHorizonPower;

		[Cpp2IlInjected.Token(Token = "0x6001594")]
		[Cpp2IlInjected.Address(RVA = "0xF55870", Offset = "0xF54270", VA = "0x180F55870")]
		public SkyPrepass(WeatherRenderFeature.Settings settings)
		{
			//IL_0083: Expected I4, but got I8
			base.renderPassEvent = RenderPassEvent.BeforeRenderingSkybox;
			this.settings = settings;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001595")]
		[Cpp2IlInjected.Address(RVA = "0xF555B0", Offset = "0xF53FB0", VA = "0x180F555B0", Slot = "5")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
			//Discarded unreachable code: IL_0060
			//IL_0058: Expected O, but got I4
			RenderTextureDescriptor cameraTargetDescriptor = renderingData.cameraData.cameraTargetDescriptor;
			RenderTextureMemoryless _003Cmemoryless_003Ek__BackingField = renderingData.cameraData.cameraTargetDescriptor._003Cmemoryless_003Ek__BackingField;
			int _003CmipCount_003Ek__BackingField = renderingData.cameraData.cameraTargetDescriptor._003CmipCount_003Ek__BackingField;
			TextureDimension _003Cdimension_003Ek__BackingField = renderingData.cameraData.cameraTargetDescriptor.dimension;
			int skyPrepass = _SkyPrepass;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			ConfigureTarget((RenderTargetIdentifier)num2);
			Color black = Color.black;
		}

		[Cpp2IlInjected.Token(Token = "0x6001596")]
		[Cpp2IlInjected.Address(RVA = "0xF55080", Offset = "0xF53A80", VA = "0x180F55080", Slot = "6")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
			//Discarded unreachable code: IL_001d
			bool flag = default(bool);
			if (flag)
			{
				Material material = (this.material = new Material(settings.skyPrepassShader));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001597")]
		[Cpp2IlInjected.Address(RVA = "0xF55580", Offset = "0xF53F80", VA = "0x180F55580", Slot = "7")]
		public override void OnCameraCleanup(CommandBuffer cmd)
		{
			//Discarded unreachable code: IL_000f
			int skyPrepass = _SkyPrepass;
			cmd.ReleaseTemporaryRT(skyPrepass);
		}

		[Cpp2IlInjected.Token(Token = "0x6001598")]
		[Cpp2IlInjected.Address(RVA = "0xF55150", Offset = "0xF53B50", VA = "0x180F55150", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			//Discarded unreachable code: IL_00ef, IL_00f5, IL_00fb
			//IL_009f: Expected O, but got I4
			//IL_00c8: Expected O, but got I4
			//IL_00e6: Expected O, but got I8
			Matrix4x4 matrix4x = default(Matrix4x4);
			int num4;
			RenderTargetIdentifier renderTargetIdentifier = default(RenderTargetIdentifier);
			RenderTargetIdentifier renderTargetIdentifier2 = default(RenderTargetIdentifier);
			ulong num8 = default(ulong);
			do
			{
				int num = 0;
				int num2 = 0;
				CommandBuffer commandBuffer = CommandBufferPool.Get();
				commandBuffer.Clear();
				Camera camera = renderingData.cameraData.camera;
				Material material = this.material;
				int nameID = viewToWorld;
				float m = matrix4x.m01;
				float m2 = matrix4x.m02;
				float m3 = matrix4x.m03;
				float value = sunGradientIntensity;
				commandBuffer.SetGlobalFloat(nameID, value);
				float value2 = moonGradientIntensity;
				int nameID2 = _MoonGradientIntensity;
				commandBuffer.SetGlobalFloat(nameID2, value2);
				float b = sunHorizonBlending;
				b = Mathf.Max(0.001f, b);
				float num3 = sunHorizonPower;
				num4 = 0;
				num3 = b;
				commandBuffer.SetGlobalVector(nameID2, (Vector4)num4);
				float b2 = moonHorizonBlending;
				float num5 = Mathf.Max(0.001f, b2);
				float num6 = moonHorizonPower;
				int num7 = 0;
				commandBuffer.SetGlobalVector(nameID2, (Vector4)num7);
				IntPtr bufferPointer = renderTargetIdentifier.m_BufferPointer;
				IntPtr bufferPointer2 = renderTargetIdentifier2.m_BufferPointer;
				CommandBufferPool.Release(commandBuffer);
				GC.KeepAlive(num8);
			}
			while (num4 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001599")]
		[Cpp2IlInjected.Address(RVA = "0xF557F0", Offset = "0xF541F0", VA = "0x180F557F0")]
		static SkyPrepass()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
