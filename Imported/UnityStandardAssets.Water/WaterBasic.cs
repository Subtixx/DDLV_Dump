using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[ExecuteInEditMode]
	public class WaterBasic : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7F20", Offset = "0x3DC6920", VA = "0x183DC7F20")]
		private void Update()
		{
			//Discarded unreachable code: IL_0057
			//IL_0044: Expected F4, but got I4
			//IL_0056: Expected O, but got I4
			int num = 0;
			Renderer component = GetComponent<Renderer>();
			if ((bool)component)
			{
				Material sharedMaterial = component.GetSharedMaterial();
				if ((bool)sharedMaterial)
				{
					float @float = sharedMaterial.GetFloat("_WaveScale");
					int num2 = 0;
					float time = Time.time;
					float num3 = Mathf.Repeat(0f, 1f);
					float num4 = default(float);
					@float = num4;
					sharedMaterial.SetVector("_WaveOffset", (Vector4)num);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public WaterBasic()
		{
		}
	}
}
