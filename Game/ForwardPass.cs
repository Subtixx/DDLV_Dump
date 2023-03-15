using System;
using Cpp2IlInjected;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[Cpp2IlInjected.Token(Token = "0x2000089")]
internal class ForwardPass : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	private ShaderTagId m_ShaderTagId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private FilteringSettings m_FilteringSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private RenderStateBlock m_RenderStateBlock;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public bool depthPriming;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private ShaderTagId m_ShaderTagIdAlphaTest;

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x1464D20", Offset = "0x1463720", VA = "0x181464D20")]
	public unsafe ForwardPass()
	{
		//IL_0049: Expected O, but got I4
		//IL_0059: Expected I4, but got I8
		//IL_0064: Expected O, but got I4
		//IL_006c: Expected native int or pointer, but got O
		int num = 0;
		m_ShaderTagId = (ShaderTagId)"AlphaTestNoDiscard";
		m_ShaderTagIdAlphaTest = (ShaderTagId)"AlphaTestNoDiscard";
		base._002Ector();
		ProfilingSampler profilingSampler = (base.profilingSampler = new ProfilingSampler("AlphaCutoutForwardPass"));
		int num2 = 0;
		RenderQueueRange opaque = RenderQueueRange.opaque;
		int num3 = 0;
		int num4 = 0;
		int mask = 0;
		m_FilteringSettings = (FilteringSettings)num4;
		int num5 = 0;
		base.renderPassEvent = (RenderPassEvent)251;
		int num6 = 0;
		m_RenderStateBlock = (RenderStateBlock)num6;
		((RenderStateBlock*)(IntPtr)m_RenderStateBlock)->m_Mask = (RenderStateMask)mask;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x1464C90", Offset = "0x1463690", VA = "0x181464C90", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
	{
		CompareFunction compareFunction = default(CompareFunction);
		if (depthPriming || compareFunction == CompareFunction.Equal)
		{
			int num = 0;
			int num2 = 0;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x14649A0", Offset = "0x14633A0", VA = "0x1814649A0", Slot = "9")]
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
		//Discarded unreachable code: IL_003e
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		CommandBuffer commandBuffer = CommandBufferPool.Get();
		commandBuffer.Clear();
		bool flag = depthPriming;
		if (!flag)
		{
			while (flag)
			{
			}
		}
		while (flag)
		{
		}
		FilteringSettings filteringSettings = m_FilteringSettings;
		CommandBufferPool.Release(commandBuffer);
	}
}
