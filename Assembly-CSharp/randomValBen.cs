using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000007")]
public class randomValBen : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private Animator anim;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private SkinnedMeshRenderer face;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private float val;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1EAC710", Offset = "0x1EAB110", VA = "0x181EAC710")]
	private void Start()
	{
		//Discarded unreachable code: IL_0054
		SkinnedMeshRenderer skinnedMeshRenderer = (face = GetComponentInChildren<SkinnedMeshRenderer>());
		SkinnedMeshRenderer skinnedMeshRenderer2 = face;
		int num = 0;
		int blendShapeCount = skinnedMeshRenderer2.sharedMesh.blendShapeCount;
		if (num < blendShapeCount)
		{
			SkinnedMeshRenderer skinnedMeshRenderer3 = face;
			val = 100f;
			skinnedMeshRenderer3.SetBlendShapeWeight(num, 100f);
			SkinnedMeshRenderer skinnedMeshRenderer4 = face;
			num++;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	private void Update()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public randomValBen()
	{
	}
}
