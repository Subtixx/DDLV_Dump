using Cpp2IlInjected;
using Mdl.Graphic.Weather;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000097")]
[ExecuteAlways]
public class WeatherReflectionProbe : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public ReflectionProbe probe;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public ProbeData reflectionData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public bool useBlending;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private float time;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private RenderTexture blendedCubemap;

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x839930", Offset = "0x838330", VA = "0x180839930")]
	private void Update()
	{
		int num = 0;
		float num2 = WeatherController.time;
		int num3 = 0;
		float num4 = (time = WeatherController.time);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	public void Refresh()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x8398B0", Offset = "0x8382B0", VA = "0x1808398B0")]
	private void OnDisable()
	{
		//Discarded unreachable code: IL_001f
		//IL_0010: Expected O, but got I4
		RenderTexture renderTexture = blendedCubemap;
		int num = 0;
		if (renderTexture != (Object)num)
		{
			blendedCubemap.Release();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public WeatherReflectionProbe()
	{
	}
}
