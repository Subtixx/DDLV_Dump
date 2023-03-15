using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000D6")]
public class vfx_script_rotate_xyz_local : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public float xAngle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public float yAngle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public float zAngle;

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	private void Start()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x8431B0", Offset = "0x841BB0", VA = "0x1808431B0")]
	private void Update()
	{
		//Discarded unreachable code: IL_0008
		Transform transform = base.transform;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public vfx_script_rotate_xyz_local()
	{
	}
}
