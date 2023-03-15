using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000012")]
public class onState : StateMachineBehaviour
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct boolStates
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public bool state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public bool isTrigger;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public List<boolStates> stateEnter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public List<boolStates> stateExit;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x842E60", Offset = "0x841860", VA = "0x180842E60", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x842FE0", Offset = "0x8419E0", VA = "0x180842FE0", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x842E50", Offset = "0x841850", VA = "0x180842E50")]
	public onState()
	{
	}
}
