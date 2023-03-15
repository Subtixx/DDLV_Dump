using System;
using Cpp2IlInjected;
using UnityEngine;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AnimatorStateTool : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private AnimatorStateInfo animatorStateInfo;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public AnimatorStateTool()
	{
	}
}
