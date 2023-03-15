using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000048")]
[CreateAssetMenu]
public class BoingScaleEffectData : ScriptableObject
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public AnimationCurve scaleX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public AnimationCurve scaleY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public AnimationCurve scaleZ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public float animationDuration = 0.75f;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x16436F0", Offset = "0x16420F0", VA = "0x1816436F0")]
	public BoingScaleEffectData()
	{
	}
}
