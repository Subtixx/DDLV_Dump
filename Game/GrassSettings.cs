using System;
using Cpp2IlInjected;
using UnityEngine;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class GrassSettings
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public Shader maskShader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public ComputeShader computeShader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public Texture2D noiseTex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public float windGustDistance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public float maxGrassDistance = 50f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public Vector2 windDirection;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static float windGrassSpeed;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static float windGrassStrength;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0xCEAEB0", Offset = "0xCE98B0", VA = "0x180CEAEB0")]
	public GrassSettings()
	{
	}
}
