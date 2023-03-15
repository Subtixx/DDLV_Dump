using System;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000017")]
public class InputDebug : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	public Vector2 AXIS;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	private void Start()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2F12320", Offset = "0x2F10D20", VA = "0x182F12320")]
	private unsafe void Update()
	{
		//IL_001d: Expected O, but got F4
		//IL_0024: Expected native int or pointer, but got O
		float axis = Input.GetAxis("Horizontal");
		float axis2 = Input.GetAxis("Vertical");
		AXIS = (Vector2)axis;
		((Vector2*)(IntPtr)AXIS)->y = axis2;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public InputDebug()
	{
	}
}
