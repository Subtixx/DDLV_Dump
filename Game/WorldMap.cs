using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class WorldMap : ScriptableObject
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public Rect rect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public Vector2Int resolution;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	[Range(0f, 1f)]
	public float previewOpacity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public Texture2D texture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public Vector2 heightMinMax;

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x8423C0", Offset = "0x840DC0", VA = "0x1808423C0")]
	public WorldMap()
	{
		//IL_001b: Expected O, but got I4
		//IL_0023: Expected O, but got I8
		int num = 0;
		Vector2 zero = Vector2.zero;
		int num2 = 0;
		Vector2 one = Vector2.one;
		rect = (Rect)0;
		ulong num3 = default(ulong);
		resolution = (Vector2Int)num3;
		previewOpacity = 1f;
		base._002Ector();
	}
}
