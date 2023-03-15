using System;
using System.Collections;
using Cpp2IlInjected;
using Mdl.Graphic.Sky;
using Mdl.Graphic.Weather;
using UnityEngine;
using UnityEngine.Rendering;

[Cpp2IlInjected.Token(Token = "0x200008C")]
public class Clouds : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static float cloudsScaleFactor;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static float cloudsCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private CloudLibrary lastClouds;

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0xA89DD0", Offset = "0xA887D0", VA = "0x180A89DD0")]
	private void OnEnable()
	{
		RenderPipelineManager.remove_beginCameraRendering((Action<, >)(object)new Action<T1, T2>(Draw));
		RenderPipelineManager.add_beginCameraRendering((Action<, >)(object)new Action<T1, T2>(Draw));
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0xA89D20", Offset = "0xA88720", VA = "0x180A89D20")]
	private void OnDisable()
	{
		RenderPipelineManager.remove_beginCameraRendering((Action<, >)(object)new Action<T1, T2>(Draw));
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0xA89BF0", Offset = "0xA885F0", VA = "0x180A89BF0")]
	private void Draw(ScriptableRenderContext context, Camera camera)
	{
		//Discarded unreachable code: IL_0043
		//IL_0011: Expected O, but got I4
		int num = 0;
		CloudLibrary clouds = WeatherController.clouds;
		int num2 = 0;
		if (!(clouds == (UnityEngine.Object)num2))
		{
			CloudLibrary cloudLibrary = lastClouds;
			if (clouds == cloudLibrary)
			{
				GameObject parent = base.gameObject;
				int num3 = 0;
				float time = Time.time;
				clouds.CloudUpdate(parent, time, camera);
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0xA89EB0", Offset = "0xA888B0", VA = "0x180A89EB0")]
	private void Update()
	{
		//Discarded unreachable code: IL_0060, IL_0066, IL_0078
		//IL_0013: Expected O, but got I4
		int num = 0;
		int num2 = 0;
		CloudLibrary clouds = WeatherController.clouds;
		int num3 = 0;
		if (clouds == (UnityEngine.Object)num3)
		{
			return;
		}
		CloudLibrary cloudLibrary = lastClouds;
		if (!(clouds != cloudLibrary))
		{
			return;
		}
		IEnumerator enumerator = base.transform.GetEnumerator();
		GameObject gameObject = default(GameObject);
		if (enumerator != null)
		{
			int num4 = 0;
			if (enumerator == null)
			{
				throw new InvalidCastException();
			}
			int num5 = 0;
			if (enumerator == null)
			{
				throw new InvalidCastException();
			}
			UnityEngine.Object.Destroy(gameObject);
		}
		if ((object)gameObject != null)
		{
		}
		GameObject parent = default(GameObject);
		clouds.Init(parent);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public Clouds()
	{
	}
}
