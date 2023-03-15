using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200002E")]
public class ResponsivePropertyAttribute : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool LabelUseTwoLines;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8BB8E0", Offset = "0x8BA2E0", VA = "0x1808BB8E0")]
	public ResponsivePropertyAttribute()
	{
	}
}
