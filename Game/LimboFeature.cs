using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[Cpp2IlInjected.Token(Token = "0x2000083")]
public class LimboFeature : ScriptableRendererFeature
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private class LimboRenderPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private RenderTargetIdentifier source;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private RenderTargetHandle target;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private new ProfilingSampler profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xF65FA0", Offset = "0xF649A0", VA = "0x180F65FA0")]
		public LimboRenderPass(Material material)
		{
			this.material = material;
			ProfilingSampler profilingSampler = (this.profilingSampler = new ProfilingSampler("LimboFeature"));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xF65F80", Offset = "0xF64980", VA = "0x180F65F80")]
		public unsafe void SetSource(RenderTargetIdentifier source)
		{
			//IL_000e: Expected native int or pointer, but got O
			IntPtr bufferPointer = source.m_BufferPointer;
			((RenderTargetIdentifier*)(IntPtr)this.source)->m_BufferPointer = bufferPointer;
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xF65C40", Offset = "0xF64640", VA = "0x180F65C40", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			//Discarded unreachable code: IL_009b
			int num = 0;
			int num2 = 0;
			CommandBuffer buffer = CommandBufferPool.Get();
			RenderTextureDescriptor cameraTargetDescriptor = renderingData.cameraData.cameraTargetDescriptor;
			int _003CmipCount_003Ek__BackingField = renderingData.cameraData.cameraTargetDescriptor._003CmipCount_003Ek__BackingField;
			TextureDimension _003Cdimension_003Ek__BackingField = renderingData.cameraData.cameraTargetDescriptor.dimension;
			RenderTextureMemoryless _003Cmemoryless_003Ek__BackingField = renderingData.cameraData.cameraTargetDescriptor._003Cmemoryless_003Ek__BackingField;
			int num3 = 0;
			RenderTargetIdentifier renderTargetIdentifier = source;
			IntPtr bufferPointer = source.m_BufferPointer;
			Material material = this.material;
			RenderTargetIdentifier renderTargetIdentifier2 = default(RenderTargetIdentifier);
			IntPtr bufferPointer2 = renderTargetIdentifier2.m_BufferPointer;
			RenderTargetIdentifier renderTargetIdentifier3 = source;
			IntPtr bufferPointer3 = source.m_BufferPointer;
			RenderTargetIdentifier renderTargetIdentifier4 = default(RenderTargetIdentifier);
			IntPtr bufferPointer4 = renderTargetIdentifier4.m_BufferPointer;
			CommandBufferPool.Release(buffer);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xF65F50", Offset = "0xF64950", VA = "0x180F65F50", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}//Discarded unreachable code: IL_0001

	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public Material material;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	private LimboRenderPass renderPass;

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0xBB4FB0", Offset = "0xBB39B0", VA = "0x180BB4FB0", Slot = "5")]
	public override void Create()
	{
		//Discarded unreachable code: IL_0026
		//IL_0025: Expected I4, but got I8
		LimboRenderPass limboRenderPass = (renderPass = new LimboRenderPass(material));
		((ScriptableRenderPass)renderPass).renderPassEvent = RenderPassEvent.BeforeRenderingPostProcessing;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0xBB4F30", Offset = "0xBB3930", VA = "0x180BB4F30", Slot = "6")]
	public unsafe override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
		//Discarded unreachable code: IL_0029
		//IL_0015: Expected native int or pointer, but got O
		LimboRenderPass limboRenderPass = renderPass;
		RenderTargetIdentifier renderTargetIdentifier = default(RenderTargetIdentifier);
		IntPtr bufferPointer = renderTargetIdentifier.m_BufferPointer;
		((RenderTargetIdentifier*)(IntPtr)limboRenderPass.source)->m_BufferPointer = bufferPointer;
		LimboRenderPass pass = renderPass;
		renderer.EnqueuePass(pass);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0xBB5040", Offset = "0xBB3A40", VA = "0x180BB5040")]
	public LimboFeature()
	{
	}
}
