using Cpp2IlInjected;
using UnityEngine.Rendering.Universal;

[Cpp2IlInjected.Token(Token = "0x2000085")]
public class RenderAlphaCutout : ScriptableRendererFeature
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private DepthNormalsOnlyPass _DepthNormalsOnlyPass;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private DepthOnlyPass _DepthOnlyPass;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private ForwardPass _OpaquePass;

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0xCC0550", Offset = "0xCBEF50", VA = "0x180CC0550", Slot = "5")]
	public override void Create()
	{
		DepthNormalsOnlyPass depthNormalsOnlyPass = (_DepthNormalsOnlyPass = new DepthNormalsOnlyPass());
		DepthOnlyPass depthOnlyPass = (_DepthOnlyPass = new DepthOnlyPass());
		ForwardPass forwardPass = (_OpaquePass = new ForwardPass());
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0xCC0350", Offset = "0xCBED50", VA = "0x180CC0350", Slot = "6")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0xBB5040", Offset = "0xBB3A40", VA = "0x180BB5040")]
	public RenderAlphaCutout()
	{
	}
}
