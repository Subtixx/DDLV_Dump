using System;
using Cpp2IlInjected;
using Mdl.Utils;
using Mono.Net.Security;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class TextMeshProSwitcherBehaviour : PlayableBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	public Color color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	public int fontSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	[StringId(false)]
	public string stringID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public bool localizeText;

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x17EC6A0", Offset = "0x17EB0A0", VA = "0x1817EC6A0")]
	public TextMeshProSwitcherBehaviour()
	{
		//IL_0010: Expected I4, but got I8
		Color white = Color.white;
		fontSize = 14;
		localizeText = true;
		((Mono.Net.Security.MobileAuthenticatedStream._003C_003Ec__DisplayClass66_0)(object)this)._002Ector();
	}
}
