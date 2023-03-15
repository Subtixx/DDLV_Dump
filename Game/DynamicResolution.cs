using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000049")]
public class DynamicResolution : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public static double gpuFrameTime;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public static double cpuFrameTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private FrameTiming[] frameTimings = new FrameTiming[3];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public float maxResolutionWidthScale = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public float maxResolutionHeightScale = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public float minResolutionWidthScale = 0.8f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public float minResolutionHeightScale = 0.8f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public float scaleWidthIncrement = 0.1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public float scaleHeightIncrement = 0.1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private float m_widthScale = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private float m_heightScale = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private uint m_frameCount;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const uint kNumFrameTimings = 2u;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x19D0440", Offset = "0x19CEE40", VA = "0x1819D0440")]
	private void Update()
	{
		DetermineResolution();
		float heightScale = m_heightScale;
		ScalableBufferManager.ResizeBuffers(m_widthScale, heightScale);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x19D0120", Offset = "0x19CEB20", VA = "0x1819D0120")]
	private void DetermineResolution()
	{
		//Discarded unreachable code: IL_0080, IL_00b7, IL_00cc, IL_00d4, IL_00eb
		//IL_0041: Expected F8, but got O
		if ((int)m_frameCount > 2)
		{
			int num = 0;
			FrameTimingManager.CaptureFrameTimings();
			FrameTiming[] timings = frameTimings;
			uint latestTimings = FrameTimingManager.GetLatestTimings(2u, timings);
			int length = frameTimings.Length;
			cpuFrameTime = (double)frameTimings[1];
			float heightScale = m_heightScale;
			float heightScale2 = Mathf.Min(maxResolutionHeightScale, heightScale);
			float b = scaleWidthIncrement;
			m_heightScale = heightScale2;
			float num2 = (m_widthScale = Mathf.Min(maxResolutionWidthScale, b));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x19D0540", Offset = "0x19CEF40", VA = "0x1819D0540")]
	public DynamicResolution()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	static DynamicResolution()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}
}
