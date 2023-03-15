using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public Material sharedMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public WaterQuality waterQuality = WaterQuality.High;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public bool edgeBlend = true;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7C80", Offset = "0x3DC6680", VA = "0x183DC7C80")]
		public void UpdateShader()
		{
			//Discarded unreachable code: IL_005f, IL_0097
			do
			{
				WaterQuality waterQuality = this.waterQuality;
				Material material = sharedMaterial;
				Shader shader = material.shader;
				Shader shader2 = material.shader;
				material.shader.maximumLOD = 501;
				bool flag = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth);
				if (!flag)
				{
					edgeBlend = flag;
				}
				if (!edgeBlend)
				{
					Shader.EnableKeyword("WATER_EDGEBLEND_OFF");
					Shader.DisableKeyword("WATER_EDGEBLEND_ON");
					return;
				}
				Shader.EnableKeyword("WATER_EDGEBLEND_ON");
				Shader.DisableKeyword("WATER_EDGEBLEND_OFF");
				int num = 0;
			}
			while (!Camera.main);
			int num2 = 0;
			DepthTextureMode depthTextureMode = Camera.main.depthTextureMode;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7E70", Offset = "0x3DC6870", VA = "0x183DC7E70")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
			//Discarded unreachable code: IL_001a
			if ((bool)currentCam && edgeBlend)
			{
				DepthTextureMode depthTextureMode = currentCam.depthTextureMode;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7E00", Offset = "0x3DC6800", VA = "0x183DC7E00")]
		public void Update()
		{
			if ((bool)sharedMaterial)
			{
				UpdateShader();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7F00", Offset = "0x3DC6900", VA = "0x183DC7F00")]
		public WaterBase()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
