using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[Cpp2IlInjected.Token(Token = "0x2000088")]
internal class DepthOnlyPass : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	private FilteringSettings m_FilteringSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	private ShaderTagId m_ShaderTagId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public bool depthPriming;

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x1625AA0", Offset = "0x16244A0", VA = "0x181625AA0")]
	public DepthOnlyPass()
	{
		//IL_0007: Expected O, but got I8
		//IL_0038: Expected O, but got I4
		//IL_0045: Expected I4, but got I8
		ulong num = default(ulong);
		m_ShaderTagId = (ShaderTagId)num;
		base._002Ector();
		ProfilingSampler profilingSampler = (base.profilingSampler = new ProfilingSampler("AlphaCutoutDepthOnlyPass"));
		int num2 = 0;
		RenderQueueRange all = RenderQueueRange.all;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		m_FilteringSettings = (FilteringSettings)num4;
		base.renderPassEvent = (RenderPassEvent)151;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x16257A0", Offset = "0x16241A0", VA = "0x1816257A0", Slot = "6")]
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
	{
		//IL_0016: Expected O, but got I4
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		if ((depthPriming ? 1 : 0) == num3)
		{
		}
		ConfigureTarget((RenderTargetIdentifier)num2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x1625860", Offset = "0x1624260", VA = "0x181625860", Slot = "9")]
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
		//Discarded unreachable code: IL_0028
		int num = 0;
		int num2 = 0;
		CommandBuffer commandBuffer = CommandBufferPool.Get();
		commandBuffer.Clear();
		SortingCriteria defaultOpaqueSortFlags = renderingData.cameraData.defaultOpaqueSortFlags;
		while (commandBuffer != null)
		{
		}
		CommandBufferPool.Release(commandBuffer);
	}
}
