using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MinMaxSliderAttribute : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly float max;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly float min;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly string varToCheckHideDiferent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly object value;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2F17530", Offset = "0x2F15F30", VA = "0x182F17530")]
	public MinMaxSliderAttribute(float min, float max, string varToCheckHideDiferent = "", [Optional] object value)
	{
		//IL_0022: Expected O, but got I4
		((DeallocateOnJobCompletionAttribute)(object)this)._002Ector();
		this.varToCheckHideDiferent = varToCheckHideDiferent;
		this.min = min;
		this.max = max;
		this.value = 0;
		/*Error: Unexpected end of block*/;
	}
}
