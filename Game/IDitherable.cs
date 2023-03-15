using System;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal interface IDitherable
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event EventHandler DitherableDestroyEvent;

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ShouldDither();

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject GetDitherableGameObject();
}
