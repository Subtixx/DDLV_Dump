using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000009")]
public class AnimateMaterialUV : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Animator animator;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Material material;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Vector2Int spriteSheetDimensions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int textureID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int UID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int VID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private float x;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private float y;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA3D3A0", Offset = "0xA3BDA0", VA = "0x180A3D3A0")]
	private void Start()
	{
		int num = (textureID = Shader.PropertyToID("_MainTex"));
		int num2 = (UID = Animator.StringToHash("U"));
		int num3 = (VID = Animator.StringToHash("V"));
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA3D420", Offset = "0xA3BE20", VA = "0x180A3D420")]
	private void Update()
	{
		//Discarded unreachable code: IL_015c
		Animator animator = this.animator;
		int uID = UID;
		float @float = animator.GetFloat(uID);
		Animator animator2 = this.animator;
		x = @float;
		int vID = VID;
		float float2 = animator2.GetFloat(vID);
		float num = x;
		y = float2;
		if (!(num <= 0.25f) && !(float2 <= 0.25f))
		{
			Material material = this.material;
		}
		float num3 = default(float);
		if (!(num <= 0.25f))
		{
			float num2 = y;
			if (!(num2 <= -0.25f) && !(0.25f <= num2))
			{
				Material material2 = this.material;
				num3 = x;
			}
		}
		num = num3;
		float num4 = default(float);
		if (!(num3 <= 0.75f) && !(y <= 0.25f))
		{
			Material material3 = this.material;
			num4 = x;
		}
		num3 = num4;
		float num5 = default(float);
		if (!(num4 <= 0.25f) && !(0.75f <= num4) && !(y <= 0.25f))
		{
			Material material4 = this.material;
			num5 = x;
		}
		num4 = num5;
		float num7 = default(float);
		if (!(num5 <= 0.75f))
		{
			float num6 = y;
			if (!(num6 <= 0.5f) && !(0.75f <= num6))
			{
				Material material5 = this.material;
				num7 = x;
			}
		}
		if (!(num7 <= 0.25f) && !(0.75f <= num7))
		{
			float num8 = y;
			if (!(num8 <= 0.5f) && !(0.75f <= num8))
			{
				Material material6 = this.material;
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public AnimateMaterialUV()
	{
	}
}
