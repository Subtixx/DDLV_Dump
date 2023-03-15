using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class HighlightPass : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private List<ShaderTagId> _shaderTagIdList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public Material material;

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x154F4C0", Offset = "0x154DEC0", VA = "0x18154F4C0")]
	public HighlightPass()
	{
		//Discarded unreachable code: IL_0033
		//IL_0025: Expected I4, but got I8
		ProfilingSampler profilingSampler = (base.profilingSampler = new ProfilingSampler("Highlight Pass"));
		base.renderPassEvent = RenderPassEvent.AfterRenderingTransparents;
		List<ShaderTagId> list = (_shaderTagIdList = (List<ShaderTagId>)(object)new List<T>());
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x154EE30", Offset = "0x154D830", VA = "0x18154EE30", Slot = "9")]
	public unsafe override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
		//Discarded unreachable code: IL_007e
		//IL_0038: Expected I8, but got I4
		int num6;
		CommandBuffer buffer;
		do
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			num6 = 0;
			int num7 = 0;
			buffer = CommandBufferPool.Get();
			int num8 = 0;
			RenderQueueRange all = RenderQueueRange.all;
			int num9 = 0;
			int num10 = 0;
			int num11 = 0;
			int num12 = 0;
			xxHash3.Write64LE((void*)num4, (ulong)num6);
			SortingCriteria defaultOpaqueSortFlags = renderingData.cameraData.defaultOpaqueSortFlags;
			int num13 = 0;
			Mesh fullscreenMesh = RenderingUtils.fullscreenMesh;
			Matrix4x4 identity = Matrix4x4.identity;
			float m = identity.m01;
			float m2 = identity.m02;
			float m3 = identity.m03;
		}
		while (num6 != 0);
		CommandBufferPool.Release(buffer);
	}
}
