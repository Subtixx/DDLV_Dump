using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class d
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD530", Offset = "0x3DCBF30", VA = "0x183DCD530")]
	public static void l(object txt)
	{
		//Discarded unreachable code: IL_000c
		Debug.Log(txt.ToString());
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD5B0", Offset = "0x3DCBFB0", VA = "0x183DCD5B0")]
	public static void le(string txt)
	{
		//Discarded unreachable code: IL_000c
		Debug.LogError(txt.ToString());
	}
}
