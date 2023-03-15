using Cpp2IlInjected;
using UnityEngine;

namespace SoftMasking.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	public static class MaterialOps
	{
		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x118AF60", Offset = "0x1189960", VA = "0x18118AF60")]
		public static bool SupportsSoftMask(this Material mat)
		{
			//Discarded unreachable code: IL_000c
			return mat.HasProperty("_SoftMask");
		}

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0x118AEC0", Offset = "0x11898C0", VA = "0x18118AEC0")]
		public static bool HasDefaultUIShader(this Material mat)
		{
			//Discarded unreachable code: IL_001c
			Shader shader = mat.shader;
			int num = 0;
			Shader shader2 = Canvas.GetDefaultCanvasMaterial().shader;
			return shader == shader2;
		}

		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0x118AE20", Offset = "0x1189820", VA = "0x18118AE20")]
		public static bool HasDefaultETC1UIShader(this Material mat)
		{
			//Discarded unreachable code: IL_001c
			Shader shader = mat.shader;
			int num = 0;
			Shader shader2 = Canvas.GetETC1SupportedCanvasMaterial().shader;
			return shader == shader2;
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x118ADF0", Offset = "0x11897F0", VA = "0x18118ADF0")]
		public static void EnableKeyword(this Material mat, string keyword, bool enabled)
		{
			//Discarded unreachable code: IL_0014
			if (!enabled)
			{
				mat.DisableKeyword(keyword);
			}
			else
			{
				mat.EnableKeyword(keyword);
			}
		}
	}
}
