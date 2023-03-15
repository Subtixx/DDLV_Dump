using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000022")]
public class GetComponentHereAttribute : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool force;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float valueWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float labelWidth;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2F118F0", Offset = "0x2F102F0", VA = "0x182F118F0")]
	public GetComponentHereAttribute(bool force = false)
	{
		this.force = force;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2F11920", Offset = "0x2F10320", VA = "0x182F11920")]
	public GetComponentHereAttribute(bool force, float labelWidth, float valueWidth = 0f)
	{
		this.labelWidth = labelWidth;
		this.valueWidth = valueWidth;
		this.force = force;
	}
}
