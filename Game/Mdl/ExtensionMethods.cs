using Cpp2IlInjected;
using UnityEngine;

namespace Mdl
{
	[Cpp2IlInjected.Token(Token = "0x20001E9")]
	public static class ExtensionMethods
	{
		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0x136AD10", Offset = "0x1369710", VA = "0x18136AD10")]
		public static void ToTexture2D(this RenderTexture rTex, Texture2D dest)
		{
			//Discarded unreachable code: IL_002d
			//IL_0026: Expected O, but got I4
			int num = 0;
			int width = rTex.width;
			int height = rTex.height;
			int num2 = 0;
			int num3 = 0;
			int destY = 0;
			int destX = 0;
			dest.ReadPixels((Rect)num2, destX, destY);
			dest.Apply();
		}
	}
}
