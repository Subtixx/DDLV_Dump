using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200004A")]
[RequireComponent(typeof(MeshRenderer))]
public class ForceCubemap : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public Cubemap cubemap;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x14640F0", Offset = "0x1462AF0", VA = "0x1814640F0")]
	private void Awake()
	{
		//Discarded unreachable code: IL_002f
		MeshRenderer component = GetComponent<MeshRenderer>();
		MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
		((Renderer)component).Internal_GetPropertyBlock(materialPropertyBlock);
		Cubemap value = cubemap;
		materialPropertyBlock.SetTexture("unity_SpecCube0", value);
		((Renderer)component).Internal_SetPropertyBlock(materialPropertyBlock);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public ForceCubemap()
	{
	}
}
