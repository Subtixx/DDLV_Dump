using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000014")]
public class onStateMachine : StateMachineBehaviour
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct boolStates
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public bool isTrigger;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public List<boolStates> stateEnter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public List<boolStates> stateExit;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x842B50", Offset = "0x841550", VA = "0x180842B50", Slot = "9")]
	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x842CD0", Offset = "0x8416D0", VA = "0x180842CD0", Slot = "10")]
	public override void OnStateMachineExit(Animator animator, int stateMachinePathHash)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x842E50", Offset = "0x841850", VA = "0x180842E50")]
	public onStateMachine()
	{
	}
}
