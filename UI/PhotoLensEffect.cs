using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[Cpp2IlInjected.Token(Token = "0x200004D")]
public class PhotoLensEffect : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private Material material;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public bool shouldRender;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private RenderTargetIdentifier _afterPostTextureID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private int _tempID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private float lensStrength_1;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private float lensStrength_2;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private float lensStrength_3;

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x9C0A30", Offset = "0x9BF430", VA = "0x1809C0A30")]
	public unsafe PhotoLensEffect(RenderPassEvent renderPassEvent)
	{
		//IL_0018: Expected O, but got I4
		//IL_001f: Expected native int or pointer, but got O
		int num = Shader.PropertyToID("_AfterPostProcessTexture");
		int num2 = 0;
		int num3 = 0;
		_afterPostTextureID = (RenderTargetIdentifier)num3;
		((RenderTargetIdentifier*)(IntPtr)_afterPostTextureID)->m_BufferPointer = (IntPtr)num3;
		_tempID = Shader.PropertyToID("_TempBuffer");
		base._002Ector();
		base.renderPassEvent = renderPassEvent;
		ProfilingSampler profilingSampler = (base.profilingSampler = new ProfilingSampler("PhotoLensEffect"));
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x9C0C00", Offset = "0x9BF600", VA = "0x1809C0C00")]
	public void changeLens(Material material)
	{
		//Discarded unreachable code: IL_00d6
		//IL_0071: Expected O, but got I4
		//IL_0096: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
		this.material = material;
		float num = (lensStrength_1 = material.GetFloat("_Strength_1"));
		float num2 = (lensStrength_2 = material.GetFloat("_Strength_2"));
		float num3 = (lensStrength_3 = material.GetFloat("_Strength_3"));
		Texture texture = material.GetTexture("_LensTex_1");
		Texture texture2 = material.GetTexture("_LensTex_2");
		Texture texture3 = material.GetTexture("_LensTex_3");
		int num4 = 0;
		if (!(texture != (UnityEngine.Object)num4))
		{
			material.DisableKeyword("_USELENS_1");
		}
		material.EnableKeyword("_USELENS_1");
		int num5 = 0;
		if (!(texture2 != (UnityEngine.Object)num5))
		{
			material.DisableKeyword("_USELENS_2");
		}
		material.EnableKeyword("_USELENS_2");
		int num6 = 0;
		if (!(texture3 != (UnityEngine.Object)num6))
		{
			material.DisableKeyword("_USELENS_3");
		}
		else
		{
			material.EnableKeyword("_USELENS_3");
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x9C0B40", Offset = "0x9BF540", VA = "0x1809C0B40")]
	public void changeLensStrength(float progress)
	{
		//Discarded unreachable code: IL_004a
		//IL_000d: Expected O, but got F4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected F4, but got Unknown
		//IL_002a: Expected O, but got F4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected F4, but got Unknown
		Material material = this.material;
		float num = ((PhotoLensEffect)progress).lensStrength_1;
		float value = /*Error near IL_000e: Stack underflow*/* num;
		material.SetFloat("_Strength_1", value);
		Material material2 = this.material;
		value = progress;
		float num2 = ((PhotoLensEffect)value).lensStrength_2;
		float value2 = /*Error near IL_002b: Stack underflow*/* num2;
		material2.SetFloat("_Strength_2", value2);
		this.material.SetFloat("_Strength_3", value2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x9C09B0", Offset = "0x9BF3B0", VA = "0x1809C09B0", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
	{
		//Discarded unreachable code: IL_0058
		base.OnCameraSetup(cmd, ref renderingData);
		RenderTextureDescriptor cameraTargetDescriptor = renderingData.cameraData.cameraTargetDescriptor;
		RenderTextureMemoryless _003Cmemoryless_003Ek__BackingField = renderingData.cameraData.cameraTargetDescriptor._003Cmemoryless_003Ek__BackingField;
		int _003CmipCount_003Ek__BackingField = renderingData.cameraData.cameraTargetDescriptor._003CmipCount_003Ek__BackingField;
		int tempID = _tempID;
		TextureDimension _003Cdimension_003Ek__BackingField = renderingData.cameraData.cameraTargetDescriptor.dimension;
		cmd.GetTemporaryRT(tempID, cameraTargetDescriptor);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x9C0740", Offset = "0x9BF140", VA = "0x1809C0740", Slot = "9")]
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
		//Discarded unreachable code: IL_0056
		int num = 0;
		if ((shouldRender ? 1 : 0) != num)
		{
			int num2 = 0;
			CommandBuffer buffer = CommandBufferPool.Get();
			RenderTargetIdentifier afterPostTextureID = _afterPostTextureID;
			IntPtr bufferPointer = _afterPostTextureID.m_BufferPointer;
			RenderTargetIdentifier renderTargetIdentifier = default(RenderTargetIdentifier);
			IntPtr bufferPointer2 = renderTargetIdentifier.m_BufferPointer;
			RenderTargetIdentifier afterPostTextureID2 = _afterPostTextureID;
			IntPtr bufferPointer3 = _afterPostTextureID.m_BufferPointer;
			RenderTargetIdentifier renderTargetIdentifier2 = default(RenderTargetIdentifier);
			IntPtr bufferPointer4 = renderTargetIdentifier2.m_BufferPointer;
			CommandBufferPool.Release(buffer);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x9C0970", Offset = "0x9BF370", VA = "0x1809C0970", Slot = "7")]
	public unsafe override void OnCameraCleanup(CommandBuffer cmd)
	{
		//Discarded unreachable code: IL_0019
		int num = 0;
		base.OnCameraSetup(cmd, ref *(RenderingData*)num);
		int tempID = _tempID;
		cmd.ReleaseTemporaryRT(tempID);
	}
}
