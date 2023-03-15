using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[Cpp2IlInjected.Token(Token = "0x2000080")]
public class HighlightFeature : ScriptableRendererFeature
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class HighlightSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public Shader shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public AnimationCurve defaultCurve;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public HighlightSettings()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public HighlightSettings settings = new HighlightSettings();

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static float time;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private HighlightPass _highlightPass;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private int intensityID = Shader.PropertyToID("intensity");

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x154ECA0", Offset = "0x154D6A0", VA = "0x18154ECA0")]
	public static void OverrideCurve(AnimationCurve curve)
	{
		//IL_0006: Expected F4, but got O
		time = (float)curve;
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x154ED20", Offset = "0x154D720", VA = "0x18154ED20")]
	public static void ResetCurve()
	{
		//IL_0008: Expected F4, but got I4
		//IL_000e: Expected F4, but got I4
		int num = 0;
		time = num;
		time = num;
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x154EA90", Offset = "0x154D490", VA = "0x18154EA90", Slot = "5")]
	public override void Create()
	{
		//Discarded unreachable code: IL_0042
		//IL_0025: Expected I4, but got I8
		HighlightPass highlightPass = new HighlightPass();
		ProfilingSampler profilingSampler = (((ScriptableRenderPass)highlightPass).profilingSampler = new ProfilingSampler("Highlight Pass"));
		((ScriptableRenderPass)highlightPass).renderPassEvent = RenderPassEvent.AfterRenderingTransparents;
		List<ShaderTagId> list = (highlightPass._shaderTagIdList = (List<ShaderTagId>)(object)new List<T>());
		_highlightPass = highlightPass;
		int num = 0;
		ResetCurve();
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x154E870", Offset = "0x154D270", VA = "0x18154E870", Slot = "6")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
		//Discarded unreachable code: IL_009b
		//IL_0015: Expected O, but got I4
		//IL_0045: Expected F4, but got O
		Material material = _highlightPass.material;
		int num = 0;
		if (material == (UnityEngine.Object)num)
		{
			Material material2 = new Material(settings.shader);
			_highlightPass.material = material2;
		}
		time = (float)settings.defaultCurve;
		int num2 = 0;
		time = Time.deltaTime;
		Material material3 = _highlightPass.material;
		int num3 = intensityID;
		AnimationCurve animationCurve = curve;
		float num4 = time;
		float value = animationCurve.Evaluate(num4);
		material3.SetFloatImpl(num3, value);
		HighlightPass highlightPass = _highlightPass;
		renderer.EnqueuePass(highlightPass);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x154EDA0", Offset = "0x154D7A0", VA = "0x18154EDA0")]
	public HighlightFeature()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	static HighlightFeature()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}
}
