using System;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200003A")]
public class WallETreads : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float treadMaxSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public Animator animator;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Renderer meshRenderer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Material leftMaterial;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Material rightMaterial;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Vector2 leftOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Vector2 rightOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int textureID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int UID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int VID;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0xD4D670", Offset = "0xD4C070", VA = "0x180D4D670")]
	private void Start()
	{
		//Discarded unreachable code: IL_006b
		Material material = (leftMaterial = meshRenderer.GetMaterialArray()[3]);
		Material material2 = (rightMaterial = meshRenderer.GetMaterialArray()[2]);
		int num = (textureID = Shader.PropertyToID("_MainTex"));
		int num2 = (UID = Animator.StringToHash("U"));
		int num3 = (VID = Animator.StringToHash("V"));
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xD4D770", Offset = "0xD4C170", VA = "0x180D4D770")]
	private unsafe void Update()
	{
		//Discarded unreachable code: IL_00be
		//IL_0044: Expected native int or pointer, but got O
		//IL_0058: Expected native int or pointer, but got O
		Animator animator = this.animator;
		int uID = UID;
		float @float = animator.GetFloat(uID);
		Animator animator2 = this.animator;
		int vID = VID;
		float float2 = animator2.GetFloat(vID);
		int num = 0;
		float deltaTime = Time.deltaTime;
		int num2 = 0;
		((Vector2*)(IntPtr)leftOffset)->y = deltaTime;
		float deltaTime2 = Time.deltaTime;
		((Vector2*)(IntPtr)rightOffset)->y = deltaTime2;
		Material material = leftMaterial;
		Vector2 offset = leftOffset;
		float y = leftOffset.y;
		int num3 = textureID;
		material.SetTextureOffsetImpl(num3, offset);
		Material material2 = rightMaterial;
		Vector2 offset2 = rightOffset;
		float y2 = rightOffset.y;
		int num4 = textureID;
		material2.SetTextureOffsetImpl(num4, offset2);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public WallETreads()
	{
	}
}
