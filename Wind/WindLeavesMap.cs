using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000002")]
public class WindLeavesMap : ScriptableObject
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D sourceTex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector2[] pivots = new Vector2[0];

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x414A730", Offset = "0x4149130", VA = "0x18414A730")]
	public WindLeavesMap()
	{
	}
}
