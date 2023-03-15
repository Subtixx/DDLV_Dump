using System;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000098")]
public class EnumFlagAttribute : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public string name;

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x8BB8E0", Offset = "0x8BA2E0", VA = "0x1808BB8E0")]
	public EnumFlagAttribute()
	{
		((System.MonoTODOAttribute)(object)this)._002Ector();
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8B0", Offset = "0x8BB2B0", VA = "0x1808BC8B0")]
	public EnumFlagAttribute(string name)
	{
		((System.MonoTODOAttribute)(object)this)._002Ector();
		this.name = name;
		/*Error: Unexpected end of block*/;
	}
}
