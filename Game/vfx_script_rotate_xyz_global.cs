using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000D5")]
public class vfx_script_rotate_xyz_global : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public float xAngle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public float yAngle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public float zAngle;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	private void Start()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x843160", Offset = "0x841B60", VA = "0x180843160")]
	private void Update()
	{
		//Discarded unreachable code: IL_002b
		Transform transform = base.transform;
		float num = zAngle;
		int relativeTo = 0;
		float num2 = yAngle;
		float num3 = xAngle;
		transform.Rotate(num3, num2, num, (Space)relativeTo);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public vfx_script_rotate_xyz_global()
	{
		((MeshRenderer)(object)this)._002Ector();
	}
}
