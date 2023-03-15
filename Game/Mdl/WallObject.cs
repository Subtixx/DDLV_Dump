using Cpp2IlInjected;
using UnityEngine;

namespace Mdl
{
	[Cpp2IlInjected.Token(Token = "0x20001EB")]
	public class WallObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0xD4DCB0", Offset = "0xD4C6B0", VA = "0x180D4DCB0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0085
			MeshRenderer[] componentsInChildren = GetComponentsInChildren<MeshRenderer>();
			int num = LayerMask.NameToLayer("GridGizmo");
			int num2 = 0;
			int num3 = 0;
			int length = componentsInChildren.Length;
			if (num2 >= length)
			{
				return;
			}
			MeshRenderer meshRenderer = componentsInChildren[num3];
			if (meshRenderer.gameObject.layer != num)
			{
				Material[] materialArray = ((Renderer)meshRenderer).GetMaterialArray();
				int num4 = 0;
				if (num4 < materialArray.Length)
				{
					Material material = materialArray[num4];
					material.EnableKeyword("LOD_FADE_CROSSFADE");
					material.SetFloat("wallObject", 1f);
					num4++;
				}
			}
			num3++;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public WallObject()
		{
		}
	}
}
