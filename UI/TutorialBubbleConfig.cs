using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000033")]
[CreateAssetMenu]
public class TutorialBubbleConfig : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public enum BubblePosition
	{
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Top,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		Bottom,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		Right
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public string Label;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool ShowBlocker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public BubblePosition Position;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
	public TutorialBubbleConfig()
	{
	}
}
