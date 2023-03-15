using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200000E")]
public class Projectile : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0A50", Offset = "0x3DBF450", VA = "0x183DC0A50")]
	private void OnCollisionEnter2D(Collision2D col)
	{
		Object.Destroy(base.gameObject);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public Projectile()
	{
	}
}
