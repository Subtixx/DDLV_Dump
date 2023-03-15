using Cpp2IlInjected;
using Mdl.Graphic.Weather;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000096")]
[ExecuteAlways]
public class WeatherPlanarReflection : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public ReflectionProbe probe;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public ProbeData reflectionData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public bool useBlending;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public MeshRenderer rend;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private float time;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private RenderTexture blendedCubemap;

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x838CB0", Offset = "0x8376B0", VA = "0x180838CB0")]
	private void Update()
	{
		RefreshShaderStuff();
		int num = 0;
		float num2 = WeatherController.time;
		int num3 = 0;
		float num4 = (time = WeatherController.time);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	public void Refresh()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x838950", Offset = "0x837350", VA = "0x180838950")]
	private void RefreshShaderStuff()
	{
		//Discarded unreachable code: IL_00ee
		//IL_0010: Expected O, but got I4
		//IL_0073: Expected O, but got I4
		//IL_0091: Expected O, but got I4
		//IL_00c5: Expected O, but got I4
		MeshRenderer meshRenderer = rend;
		int num = 0;
		if (!(meshRenderer == (Object)num))
		{
			Transform transform = base.transform;
			ReflectionProbe reflectionProbe = probe;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			ReflectionProbe reflectionProbe2 = probe;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			MeshRenderer meshRenderer2 = rend;
			Vector3 vector4 = default(Vector3);
			float z4 = vector4.z;
			Material sharedMaterial = ((Renderer)meshRenderer2).GetSharedMaterial();
			int num2 = 0;
			sharedMaterial.SetVector("_BBoxMin", (Vector4)num2);
			Material sharedMaterial2 = ((Renderer)rend).GetSharedMaterial();
			int num3 = 0;
			sharedMaterial2.SetVector("_BBoxMax", (Vector4)num3);
			Material sharedMaterial3 = ((Renderer)rend).GetSharedMaterial();
			Transform transform2 = probe.transform;
			int num4 = 0;
			Vector3 vector5 = default(Vector3);
			float z5 = vector5.z;
			sharedMaterial3.SetVector("_CubeMapPos", (Vector4)num4);
			Material sharedMaterial4 = ((Renderer)rend).GetSharedMaterial();
			Texture customBakedTexture = probe.customBakedTexture;
			sharedMaterial4.SetTexture("_Cubemap", customBakedTexture);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x8388D0", Offset = "0x8372D0", VA = "0x1808388D0")]
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

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public WeatherPlanarReflection()
	{
	}
}
