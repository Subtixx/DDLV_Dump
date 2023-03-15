using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

[Cpp2IlInjected.Token(Token = "0x2000049")]
[CreateAssetMenu]
public class PhotoEffectData : ScriptableObject
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public PhotoFrameData frame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public Material lens;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public VolumeProfile postProcessing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public Sprite icon;

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
	public PhotoEffectData()
	{
	}
}
