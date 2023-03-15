using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class Reset : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	[SerializeField]
	private Boot boot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	[SerializeField]
	private List<string> gameObjectsToKeep;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	[SerializeField]
	private GameObject ResetCamera;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0xCC1860", Offset = "0xCC0260", VA = "0x180CC1860")]
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(ResetCamera);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0xCC1930", Offset = "0xCC0330", VA = "0x180CC1930")]
	private void Start()
	{
		//Discarded unreachable code: IL_0019
		int _003C_003E1__state = default(int);
		_003CResetGame_003Ed__5 _003CResetGame_003Ed__ = new _003CResetGame_003Ed__5(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CResetGame_003Ed__._003C_003E4__this = this;
		Coroutine coroutine = StartCoroutine(_003CResetGame_003Ed__);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0xCC18C0", Offset = "0xCC02C0", VA = "0x180CC18C0")]
	[IteratorStateMachine(typeof(_003CResetGame_003Ed__5))]
	private IEnumerator ResetGame()
	{
		int _003C_003E1__state = default(int);
		_003CResetGame_003Ed__5 _003CResetGame_003Ed__ = new _003CResetGame_003Ed__5(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CResetGame_003Ed__._003C_003E4__this = this;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public Reset()
	{
		((MeshFilter)(object)this)._002Ector();
	}
}
