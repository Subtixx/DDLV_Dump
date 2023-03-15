using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200000F")]
public class SimpleController : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public string HorizontalAxis = "Horizontal";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public string JumpAxis = "Jump";

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public string FireAxis = "Fire 1";

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public GameObject Projectile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private Rigidbody2D rb;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float velocity = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public float ProjectileVelocity = 7f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	public bool grounded;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3DC19F0", Offset = "0x3DC03F0", VA = "0x183DC19F0")]
	private void Start()
	{
		Rigidbody2D rigidbody2D = (rb = GetComponent<Rigidbody2D>());
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1A40", Offset = "0x3DC0440", VA = "0x183DC1A40")]
	private void Update()
	{
		//Discarded unreachable code: IL_00cd
		//IL_002a: Expected O, but got I4
		//IL_005e: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		Rigidbody2D rigidbody2D = rb;
		float axis = Input.GetAxis("Horizontal");
		Rigidbody2D rigidbody2D2 = rb;
		int num = 0;
		Vector2 vector = rigidbody2D2.velocity;
		rigidbody2D.velocity = (Vector2)num;
		if (grounded && Input.GetButtonDown(JumpAxis))
		{
			Rigidbody2D rigidbody2D3 = rb;
			int num2 = 0;
			Vector2 vector2 = rigidbody2D3.velocity;
			rigidbody2D3.velocity = (Vector2)num2;
			grounded = false;
		}
		if (Input.GetButtonDown(FireAxis))
		{
			GameObject projectile = Projectile;
			Transform transform = base.transform;
			int num3 = 0;
			float z = Vector3.right.z;
			int num4 = 0;
			Quaternion identity = Quaternion.identity;
			GameObject gameObject = Object.Instantiate(projectile, (Vector3)num4, (Quaternion)num3);
			Collider2D component = gameObject.GetComponent<Collider2D>();
			Collider2D component2 = GetComponent<Collider2D>();
			Physics2D.IgnoreCollision(component, component2);
			Rigidbody2D component3 = gameObject.GetComponent<Rigidbody2D>();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x17F7150", Offset = "0x17F5B50", VA = "0x1817F7150")]
	private void OnCollisionEnter2D(Collision2D col)
	{
		grounded = true;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x17F7150", Offset = "0x17F5B50", VA = "0x1817F7150")]
	private void OnCollisionStay2D(Collision2D col)
	{
		grounded = true;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3DC19E0", Offset = "0x3DC03E0", VA = "0x183DC19E0")]
	private void OnCollisionExit2D(Collision2D col)
	{
		grounded = false;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1DC0", Offset = "0x3DC07C0", VA = "0x183DC1DC0")]
	public SimpleController()
	{
	}
}
