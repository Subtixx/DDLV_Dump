using System;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200008A")]
public class FogHeightmapBaker : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[Flags]
	public enum Channels
	{
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		Red = 1,
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		Green = 2,
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		Blue = 4,
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		Alpha = 8
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public int size = 2048;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public int padding = 50;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public int blur = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public LayerMask layer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public Channels channels = Channels.Red;

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x145DAC0", Offset = "0x145C4C0", VA = "0x18145DAC0")]
	public FogHeightmapBaker()
	{
	}//IL_000d: Expected I4, but got I8
	//IL_0017: Expected I4, but got I8
	//IL_0020: Expected I4, but got I8
	//IL_0029: Expected I4, but got I8

}
