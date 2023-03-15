using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class Displace : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2F0AF00", Offset = "0x2F09900", VA = "0x182F0AF00")]
		public void Awake()
		{
			if (!base.enabled)
			{
				Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_OFF");
				Shader.DisableKeyword("WATER_VERTEX_DISPLACEMENT_ON");
			}
			else
			{
				Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_ON");
				Shader.DisableKeyword("WATER_VERTEX_DISPLACEMENT_OFF");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x2F0AFF0", Offset = "0x2F099F0", VA = "0x182F0AFF0")]
		public void OnEnable()
		{
			Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_ON");
			Shader.DisableKeyword("WATER_VERTEX_DISPLACEMENT_OFF");
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2F0AFA0", Offset = "0x2F099A0", VA = "0x182F0AFA0")]
		public void OnDisable()
		{
			Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_OFF");
			Shader.DisableKeyword("WATER_VERTEX_DISPLACEMENT_ON");
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public Displace()
		{
		}
	}
}
