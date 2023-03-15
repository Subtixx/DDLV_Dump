using System;
using Cpp2IlInjected;
using Mdl.Graphic.Sky;
using Mdl.Graphic.Weather;
using UnityEngine;
using UnityEngine.Rendering;

[Cpp2IlInjected.Token(Token = "0x200008D")]
public class Stars : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static Color starsColor;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static float starsIntensity;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0xF5C710", Offset = "0xF5B110", VA = "0x180F5C710")]
	private void OnEnable()
	{
		RenderPipelineManager.remove_beginCameraRendering((Action<, >)(object)new Action<T1, T2>(Draw));
		RenderPipelineManager.add_beginCameraRendering((Action<, >)(object)new Action<T1, T2>(Draw));
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0xF5C660", Offset = "0xF5B060", VA = "0x180F5C660")]
	private void OnDisable()
	{
		RenderPipelineManager.remove_beginCameraRendering((Action<, >)(object)new Action<T1, T2>(Draw));
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0xF5C5B0", Offset = "0xF5AFB0", VA = "0x180F5C5B0")]
	private void Draw(ScriptableRenderContext context, Camera camera)
	{
		//Discarded unreachable code: IL_001c
		//IL_0011: Expected O, but got I4
		int num = 0;
		ConstellationLibrary constellations = WeatherController.constellations;
		int num2 = 0;
		if (!(constellations == (UnityEngine.Object)num2))
		{
			constellations.Draw(camera);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public Stars()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0xF5C7F0", Offset = "0xF5B1F0", VA = "0x180F5C7F0")]
	static Stars()
	{
		Color white = Color.white;
	}
}
