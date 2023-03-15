using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[Cpp2IlInjected.Token(Token = "0x200004E")]
public class PhotoLensRenderer : ScriptableRendererFeature
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public bool IsEnabled = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public RenderPassEvent renderPassEvent = RenderPassEvent.AfterRenderingPostProcessing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private PhotoLensEffect photoLens;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public Material material;

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x9C0E80", Offset = "0x9BF880", VA = "0x1809C0E80", Slot = "5")]
	public unsafe override void Create()
	{
		//IL_001f: Expected O, but got I4
		//IL_0027: Expected native int or pointer, but got O
		RenderPassEvent _003CrenderPassEvent_003Ek__BackingField = renderPassEvent;
		int num = Shader.PropertyToID("_AfterPostProcessTexture");
		int num2 = 0;
		int num3 = 0;
		PhotoLensEffect photoLensEffect = default(PhotoLensEffect);
		photoLensEffect._afterPostTextureID = (RenderTargetIdentifier)num3;
		((RenderTargetIdentifier*)(IntPtr)photoLensEffect._afterPostTextureID)->m_BufferPointer = (IntPtr)num3;
		int num4 = (photoLensEffect._tempID = Shader.PropertyToID("_TempBuffer"));
		((ScriptableRenderPass)photoLensEffect).renderPassEvent = _003CrenderPassEvent_003Ek__BackingField;
		ProfilingSampler profilingSampler = (((ScriptableRenderPass)photoLensEffect).profilingSampler = new ProfilingSampler("PhotoLensEffect"));
		photoLens = photoLensEffect;
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x9C0FF0", Offset = "0x9BF9F0", VA = "0x1809C0FF0")]
	public void changeLensStrength(float progress)
	{
		//Discarded unreachable code: IL_0054
		//IL_0014: Expected O, but got F4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected F4, but got Unknown
		//IL_0031: Expected O, but got F4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected F4, but got Unknown
		PhotoLensEffect photoLensEffect = photoLens;
		Material material = photoLensEffect.material;
		float lensStrength_ = ((PhotoLensEffect)progress).lensStrength_1;
		float value = /*Error near IL_0015: Stack underflow*/* lensStrength_;
		material.SetFloat("_Strength_1", value);
		Material material2 = photoLensEffect.material;
		value = progress;
		float lensStrength_2 = ((PhotoLensEffect)value).lensStrength_2;
		float value2 = /*Error near IL_0032: Stack underflow*/* lensStrength_2;
		material2.SetFloat("_Strength_2", value2);
		photoLensEffect.material.SetFloat("_Strength_3", value2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x9C10C0", Offset = "0x9BFAC0", VA = "0x1809C10C0")]
	public void changeLens(Material material)
	{
		//Discarded unreachable code: IL_0022
		PhotoLensEffect photoLensEffect = photoLens;
		IsEnabled = true;
		photoLensEffect.shouldRender = true;
		photoLens.changeLens(material);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x9C10F0", Offset = "0x9BFAF0", VA = "0x1809C10F0")]
	public void removeLens()
	{
		//Discarded unreachable code: IL_0016
		PhotoLensEffect photoLensEffect = photoLens;
		IsEnabled = false;
		photoLensEffect.shouldRender = false;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x9C0E50", Offset = "0x9BF850", VA = "0x1809C0E50", Slot = "6")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
		//Discarded unreachable code: IL_0019
		if (IsEnabled)
		{
			PhotoLensEffect pass = photoLens;
			renderer.EnqueuePass(pass);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x9C0FD0", Offset = "0x9BF9D0", VA = "0x1809C0FD0")]
	public PhotoLensRenderer()
	{
	}//IL_0014: Expected I4, but got I8

}
