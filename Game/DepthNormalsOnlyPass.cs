using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[Cpp2IlInjected.Token(Token = "0x2000087")]
internal class DepthNormalsOnlyPass : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private ShaderTagId m_ShaderTagId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	private FilteringSettings m_FilteringSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public bool depthPriming;

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x1625620", Offset = "0x1624020", VA = "0x181625620")]
	public DepthNormalsOnlyPass()
	{
		//IL_0007: Expected O, but got I8
		//IL_0038: Expected O, but got I4
		//IL_0045: Expected I4, but got I8
		ulong num = default(ulong);
		m_ShaderTagId = (ShaderTagId)num;
		base._002Ector();
		ProfilingSampler profilingSampler = (base.profilingSampler = new ProfilingSampler("AlphaCutoutDepthNormalsOnlyPass"));
		int num2 = 0;
		RenderQueueRange all = RenderQueueRange.all;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		m_FilteringSettings = (FilteringSettings)num4;
		base.renderPassEvent = (RenderPassEvent)151;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x1625230", Offset = "0x1623C30", VA = "0x181625230", Slot = "6")]
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
	{
		int num = 0;
		int num2 = 0;
		if ((depthPriming ? 1 : 0) == num2)
		{
			int num3 = 0;
		}
		int num4 = 0;
		int num5 = 0;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x16253E0", Offset = "0x1623DE0", VA = "0x1816253E0", Slot = "9")]
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
		//Discarded unreachable code: IL_0030
		int num = 0;
		int num2 = 0;
		CommandBuffer commandBuffer = CommandBufferPool.Get();
		ProfilingSampler profilingSampler = ProfilingSampler.Get(RenderAlphaCutoutId.AlphaCutoutDepthNormalPrepass);
		commandBuffer.Clear();
		SortingCriteria defaultOpaqueSortFlags = renderingData.cameraData.defaultOpaqueSortFlags;
		while (commandBuffer != null)
		{
		}
		CommandBufferPool.Release(commandBuffer);
	}
}
